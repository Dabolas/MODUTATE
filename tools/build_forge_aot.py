#!/usr/bin/env python3
"""Development-time JVM class -> statically compiled C# method state machines.

This compiler never starts Forge or a game. Unresolved runtime operations remain
explicit PortGap failures; generated source and a successful build are not rule readiness.
"""
from __future__ import annotations
import argparse
from collections import Counter
import hashlib
import json
import math
import os
import re
from pathlib import Path
import subprocess
import sys
from forge_aot.classfile import ClassFile, descriptor

ROOT = Path(__file__).resolve().parents[1]
FORGE = ROOT / "external/forge"
OUT = ROOT / "migration/forge-aot"
INTRINSICS = {
    ("java/lang/Object","<init>","()V"), ("java/lang/Object","equals","(Ljava/lang/Object;)Z"),
    ("java/lang/Object","hashCode","()I"), ("java/lang/Object","getClass","()Ljava/lang/Class;"),
    ("java/lang/System","identityHashCode","(Ljava/lang/Object;)I"),
    ("java/lang/String","length","()I"), ("java/lang/String","isEmpty","()Z"),
    ("java/lang/String","charAt","(I)C"), ("java/lang/String","equals","(Ljava/lang/Object;)Z"),
    ("java/lang/String","hashCode","()I"), ("java/lang/String","toString","()Ljava/lang/String;"),
}
for intrinsic_source in (ROOT/"src/Forge.Aot").glob("*.cs"):
    INTRINSICS.update(re.findall(r'Bind\("([^"]+)","([^"]+)","([^"]+)"',intrinsic_source.read_text(encoding="utf-8-sig")))


def q(value): return json.dumps(value, ensure_ascii=True)
def sha(raw): return hashlib.sha256(raw).hexdigest()
def write(path, value):
    path.parent.mkdir(parents=True, exist_ok=True)
    path.write_text(json.dumps(value, ensure_ascii=True, indent=2) + "\n", encoding="utf-8")


def number(value, typ):
    if typ in {"F","D"}:
        owner, suffix = ("float", "f") if typ == "F" else ("double", "d")
        if math.isnan(value): return owner + ".NaN"
        if math.isinf(value): return owner + (".PositiveInfinity" if value > 0 else ".NegativeInfinity")
        return repr(value) + suffix
    if typ == "J": return "long.MinValue" if value == -(1 << 63) else str(value) + "L"
    return "int.MinValue" if value == -(1 << 31) else str(value)


def constant(cls, index, metadata=False):
    tag, value = cls.cp[index]
    if tag in {3,4,5,6}:
        typ = {3:"I",4:"F",5:"J",6:"D"}[tag]
        return f"JValue.{'L' if typ=='J' else typ}({number(value,typ)})"
    if tag == 8 and not metadata: return f"JValue.R(rt.String({q(cls.utf(value))}))"
    if tag == 7 and not metadata: return f"JValue.R(rt.ClassObject({q(cls.utf(value))}))"
    raise ValueError("Unported constant kind " + str(tag))


def emit_instruction(cls, instruction, gaps, concat_sites, lambda_sites, record_sites, method_id):
    op, args, pc, next_pc = instruction["op"], instruction["args"], instruction["pc"], instruction["next"]
    code, terminal = "", False
    if op == "nop": pass
    elif op == "aconst_null": code = "f.Push(JValue.R(null));"
    elif op.startswith("iconst_"): code = f"f.Push(JValue.I({-1 if op.endswith('m1') else op[-1]}));"
    elif op.startswith(("lconst_","fconst_","dconst_")):
        typ = op[0].upper(); code = f"f.Push(JValue.{typ}({op[-1]}));"
    elif op in {"bipush","sipush"}: code = f"f.Push(JValue.I({args[0]}));"
    elif op in {"ldc","ldc_w","ldc2_w"}:
        try: code = "f.Push(" + constant(cls,args[0]) + ");"
        except ValueError as error:
            gaps.append({"pc":pc,"reason":str(error)})
            code, terminal = "throw new PortGap(" + q(str(error)) + ");", True
    elif op.startswith(("iload","lload","fload","dload","aload")):
        index = int(op[-1]) if "_" in op else args[0]
        code = f"f.Push(f.Locals[{index}]);"
    elif op.startswith(("istore","lstore","fstore","dstore","astore")):
        index = int(op[-1]) if "_" in op else args[0]
        code = f"f.Locals[{index}]=f.Pop();"
    elif op in {"iaload","laload","faload","daload","aaload","baload","caload","saload"}:
        code = "int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));"
    elif op in {"iastore","lastore","fastore","dastore","aastore","bastore","castore","sastore"}:
        code = "var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);"
    elif op in {"pop","pop2","dup","dup_x1","dup_x2","dup2","dup2_x1","dup2_x2","swap"}:
        code = "f.StackOp(" + q(op) + ");"
    elif op in {p+s for p in "ilfd" for s in ("add","sub","mul","div","rem")} | {"ishl","lshl","ishr","lshr","iushr","lushr","iand","land","ior","lor","ixor","lxor","lcmp","fcmpl","fcmpg","dcmpl","dcmpg"}:
        code = "var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt," + q(op) + ",a,b));"
    elif op in {"ineg","lneg","fneg","dneg","i2l","i2f","i2d","l2i","l2f","l2d","f2i","f2l","f2d","d2i","d2l","d2f","i2b","i2c","i2s"}:
        code = "f.Push(JNumbers.Unary(" + q(op) + ",f.Pop()));"
    elif op == "iinc": code = f"f.Locals[{args[0]}]=JValue.I(unchecked(f.Locals[{args[0]}].Int+({args[1]})));"
    elif op in {"ifeq","ifne","iflt","ifge","ifgt","ifle"}:
        operator = {"ifeq":"==","ifne":"!=","iflt":"<","ifge":">=","ifgt":">","ifle":"<="}[op]
        code, terminal = f"f.Pc=f.Pop().Int{operator}0?{args[0]}:{next_pc};continue;", True
    elif op.startswith("if_icmp"):
        operator = {"eq":"==","ne":"!=","lt":"<","ge":">=","gt":">","le":"<="}[op[7:]]
        code, terminal = f"int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a{operator}b?{args[0]}:{next_pc};continue;", True
    elif op in {"if_acmpeq","if_acmpne"}:
        check = "ReferenceEquals(a,b)" if op == "if_acmpeq" else "!ReferenceEquals(a,b)"
        code, terminal = f"var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc={check}?{args[0]}:{next_pc};continue;", True
    elif op in {"ifnull","ifnonnull"}:
        operator = "==" if op == "ifnull" else "!="
        code, terminal = f"f.Pc=f.Pop().Reference{operator}null?{args[0]}:{next_pc};continue;", True
    elif op in {"goto","goto_w"}: code, terminal = f"f.Pc={args[0]};continue;", True
    elif op in {"jsr","jsr_w"}: code, terminal = f"f.Push(JValue.Address({next_pc}));f.Pc={args[0]};continue;", True
    elif op == "ret": code, terminal = f"f.Pc=f.Locals[{args[0]}].Int;continue;", True
    elif op in {"tableswitch","lookupswitch"}:
        cases = "".join(f"case {key}:f.Pc={target};break;" for key,target in instruction["pairs"])
        code, terminal = f"switch(f.Pop().Int){{{cases}default:f.Pc={instruction['default']};break;}}continue;", True
    elif op == "ireturn":code,terminal="return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));",True
    elif op in {"lreturn","freturn","dreturn","areturn"}: code, terminal = "return JStep.Return(f.Pop());", True
    elif op == "return": code, terminal = "return JStep.ReturnVoid;", True
    elif op in {"getstatic","putstatic","getfield","putfield"}:
        owner,name,desc = cls.member_ref(args[0]); reference = ",".join(map(q,(owner,name,desc)))
        if op == "getstatic": code = f"if(!rt.StaticReady(f,{reference}))return JStep.Continue;f.Push(rt.GetStatic({reference}));"
        elif op == "putstatic": code = f"if(!rt.StaticReady(f,{reference}))return JStep.Continue;rt.PutStatic({reference},f.Pop());"
        elif op == "getfield": code = f"f.Push(rt.GetField(f.Pop(),{reference}));"
        else: code = f"var value=f.Pop();rt.PutField(f.Pop(),{reference},value);"
    elif op in {"invokevirtual","invokespecial","invokestatic","invokeinterface"}:
        reference = ",".join(map(q,cls.member_ref(args[0])))
        code, terminal = f"return rt.Call(f,{reference},{q(op)},{next_pc});", True
    elif op == "invokedynamic":
        dynamic = cls.dynamic(args[0]); site = cls.name + ":" + str(method_id) + ":" + str(pc) + ":" + ".".join(dynamic["bootstrap"][:2])
        lowered = False
        if dynamic["bootstrap"][:2] == ("java/lang/invoke/StringConcatFactory","makeConcatWithConstants"):
            arguments = dynamic["arguments"]
            if arguments and cls.cp[arguments[0]][0] == 8:
                recipe = cls.utf(cls.cp[arguments[0]][1]); constants=[]
                for index in arguments[1:]:
                    tag,value=cls.cp[index]
                    if tag == 8:constants.append({"text":cls.utf(value)})
                    elif tag in {3,4,5,6}:constants.append({"expression":constant(cls,index,True),"type":{3:"I",4:"F",5:"J",6:"D"}[tag]})
                    else:break
                else:
                    parameters,_=descriptor(dynamic["descriptor"])
                    if recipe.count("\x01")==len(parameters) and recipe.count("\x02")==len(constants):
                        concat_sites.append({"id":site,"descriptor":dynamic["descriptor"],"recipe":recipe,"constants":constants})
                        lowered=True
        if dynamic["bootstrap"][:2] in {("java/lang/invoke/LambdaMetafactory","metafactory"),("java/lang/invoke/LambdaMetafactory","altMetafactory")}:
            arguments=dynamic["arguments"]
            try:
                def method_type(index):
                    tag,value=cls.cp[index]
                    if tag!=16:raise ValueError("Lambda method type missing")
                    return cls.utf(value)
                sam=method_type(arguments[0]);instantiated=method_type(arguments[2])
                tag,(reference_kind,member_index)=cls.cp[arguments[1]]
                if tag!=15 or reference_kind not in {5,6,7,8,9}:raise ValueError("Lambda method handle unsupported")
                implementation=cls.member_ref(member_index)
                captures,iface=descriptor(dynamic["descriptor"])
                if not iface.startswith("L"):raise ValueError("Lambda interface descriptor is not a reference")
                markers,bridges,notes=[],[],[]
                if dynamic["bootstrap"][1]=="altMetafactory":
                    tag,flags=cls.cp[arguments[3]]
                    if tag!=3 or flags&~7:raise ValueError("Unknown lambda metafactory flags")
                    at=4
                    if flags&1:markers.append("java/io/Serializable");notes.append("serializable-lambda-writeReplace-not-ported")
                    if flags&2:
                        tag,count=cls.cp[arguments[at]];at+=1
                        if tag!=3:raise ValueError("Lambda marker count missing")
                        for index in arguments[at:at+count]:markers.append(cls.class_name(index))
                        at+=count
                    if flags&4:
                        tag,count=cls.cp[arguments[at]];at+=1
                        if tag!=3:raise ValueError("Lambda bridge count missing")
                        for index in arguments[at:at+count]:bridges.append(method_type(index))
                        at+=count
                    if at!=len(arguments):raise ValueError("Lambda bootstrap arguments not consumed")
                elif len(arguments)!=3:raise ValueError("Unexpected lambda bootstrap arguments")
                inst_params,_=descriptor(instantiated);impl_params,impl_return=descriptor(implementation[2])
                actual=captures+inst_params
                if reference_kind in {5,7,9}:actual=actual[1:]
                if len(actual)!=len(impl_params):raise ValueError("Lambda implementation arity mismatch")
                is_ref=lambda t:t.startswith(("L","["))
                if any(is_ref(a)!=is_ref(b) for a,b in zip(actual,impl_params)):notes.append("lambda-argument-boxing-unboxing-not-linked")
                _,sam_return=descriptor(sam)
                if reference_kind==8:impl_return="L"+implementation[0]+";"
                if sam_return!="V" and is_ref(impl_return)!=is_ref(sam_return):notes.append("lambda-result-boxing-unboxing-not-linked")
                record={"id":site,"caller":method_id,"descriptor":dynamic["descriptor"],"class":"aot/lambda/S"+str(len(lambda_sites)),"interface":iface[1:-1],"samName":dynamic["name"],"samDescriptor":sam,"instantiatedDescriptor":instantiated,"implementation":implementation,"referenceKind":reference_kind,"markers":markers,"bridges":bridges,"remainingAdapters":notes}
                lambda_sites.append(record);lowered=True
                for note in notes:gaps.append({"pc":pc,"reason":note,"site":site})
            except (ValueError,IndexError,TypeError) as error:
                gaps.append({"pc":pc,"reason":"lambda-bootstrap-shape:"+str(error),"bootstrap":dynamic});lowered=True
        if dynamic["bootstrap"][:2] == ("java/lang/runtime/ObjectMethods","bootstrap"):
            try:
                arguments=dynamic["arguments"]
                owner=cls.class_name(arguments[0]);tag,name_index=cls.cp[arguments[1]]
                if tag!=8 or owner!=cls.name:raise ValueError("Record class/field metadata mismatch")
                text=cls.utf(name_index);names=text.split(";") if text else [];fields=[]
                for handle_index in arguments[2:]:
                    tag,(reference_kind,field_index)=cls.cp[handle_index]
                    if tag!=15 or reference_kind!=1:raise ValueError("Record getter is not a field handle")
                    fields.append(cls.member_ref(field_index))
                if names!=[f[1] for f in fields]:raise ValueError("Record component names/getters mismatch")
                operation=dynamic["name"];expected={"equals":"(L"+owner+";Ljava/lang/Object;)Z","hashCode":"(L"+owner+";)I","toString":"(L"+owner+";)Ljava/lang/String;"}
                if operation not in expected or dynamic["descriptor"]!=expected[operation]:raise ValueError("Record operation shape changed")
                concat_id=site+"#recordText"
                record_sites.append({"id":site,"descriptor":dynamic["descriptor"],"class":owner,"operation":operation,"concatId":concat_id,"fields":fields})
                if operation=="toString":
                    recipe=cls.simple_name+"["+", ".join(name+"=\x01" for name in names)+"]"
                    concat_sites.append({"id":concat_id,"descriptor":"("+"".join(f[2] for f in fields)+")Ljava/lang/String;","recipe":recipe,"constants":[]})
                lowered=True
            except (ValueError,IndexError,TypeError) as error:
                gaps.append({"pc":pc,"reason":"record-bootstrap-shape:"+str(error),"bootstrap":dynamic});lowered=True
        if not lowered:gaps.append({"pc":pc,"reason":"invokedynamic-bootstrap-unbound","bootstrap":dynamic})
        code, terminal = f"return rt.DynamicCall(f,{q(site)},{q(dynamic['descriptor'])},{next_pc});", True
    elif op == "new":
        name = q(cls.class_name(args[0])); code = f"if(!rt.EnsureInitialized(f,{name}))return JStep.Continue;f.Push(JValue.R(rt.Allocate({name})));"
    elif op in {"newarray","anewarray"}:
        if op == "newarray": component = {4:"Z",5:"C",6:"F",7:"D",8:"B",9:"S",10:"I",11:"J"}[args[0]]
        else:
            target = cls.class_name(args[0]); component = target if target.startswith("[") else "L"+target+";"
        code = f"f.Push(JValue.R(rt.NewArray({q(component)},f.Pop().Int)));"
    elif op == "multianewarray":
        name, dimensions = cls.class_name(args[0]), args[1]
        code = f"var lengths=new int[{dimensions}];for(int i={dimensions-1};i>=0;i--)lengths[i]=f.Pop().Int;f.Push(JValue.R(rt.MultiArray({q(name)},lengths)));"
    elif op == "arraylength": code = "f.Push(JValue.I(rt.ArrayLength(f.Pop())));"
    elif op == "athrow": code, terminal = "throw new JavaFault(rt.NonNull(f.Pop()));", True
    elif op == "checkcast":
        name = q(cls.class_name(args[0])); code = f"var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,{name}))throw rt.Fault(\"java/lang/ClassCastException\");f.Push(value);"
    elif op == "instanceof": code = f"f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,{q(cls.class_name(args[0]))})?1:0));"
    elif op == "monitorenter": code = "rt.EnterMonitor(rt.NonNull(f.Pop()));"
    elif op == "monitorexit": code = "rt.ExitMonitor(rt.NonNull(f.Pop()));"
    else: raise ValueError("Unmapped instruction: " + op)
    if not terminal: code += f"f.Pc={next_pc};continue;"
    return f"case {pc}:{{{code}}}"


def body(cls, method, method_id, gaps, concat_sites, lambda_sites, record_sites):
    cases = "\n".join(emit_instruction(cls,item,gaps,concat_sites,lambda_sites,record_sites,method_id) for item in method["instructions"])
    return f"internal static JStep M{method_id}(JRuntime rt,JFrame f)\n{{\nwhile(rt.Tick()){{f.LastPc=f.Pc;switch(f.Pc){{\n{cases}\ndefault:throw new PortGap(\"Invalid generated program position\");}}}}return JStep.Yield;\n}}\n"


def find_member(classes, owner, name, desc, field=False, visited=None):
    visited = set() if visited is None else visited
    if owner in visited or owner not in classes: return None
    visited.add(owner); cls = classes[owner][0]
    for member in cls.fields if field else cls.methods:
        if member["name"] == name and member["descriptor"] == desc: return (owner,name,desc)
    if not field and name == "<init>": return None
    parents = cls.interfaces + ([cls.super] if cls.super else []) if field else ([cls.super] if cls.super else []) + cls.interfaces
    for parent in parents:
        result = find_member(classes,parent,name,desc,field,visited.copy())
        if result: return result
    return None


def generate(modules, check=False):
    OUT.mkdir(parents=True,exist_ok=True); generated = OUT / "generated"; generated.mkdir(exist_ok=True)
    classes, inputs = {}, []
    source_inventory = json.loads((ROOT / "bridge/generated/forge-full/java-sources.json").read_text(encoding="utf-8"))["files"]
    sources = {r["path"]: r for r in source_inventory}
    for module in modules:
        folder = FORGE / module / "target/classes"
        if not folder.is_dir(): raise ValueError("Missing compiled module: " + module)
        for path in sorted(folder.rglob("*.class")):
            raw = path.read_bytes(); cls = ClassFile(raw)
            if cls.name in classes: raise ValueError("Duplicate class definition: " + cls.name)
            source = module + "/src/main/java/" + cls.name.rsplit("/",1)[0] + "/" + cls.source
            if source in sources and sha((FORGE / source).read_bytes()) != sources[source]["sha256"]:
                raise ValueError("Source snapshot changed: " + source)
            item = {"path":path.relative_to(FORGE).as_posix(),"sha256":sha(raw),"class":cls.name,"source":source,"sourceHashVerified":source in sources,"javaVersion":cls.major}
            classes[cls.name]=(cls,item);inputs.append(item)
    methods = {}; method_id=0
    for name in sorted(classes):
        for method in classes[name][0].methods:
            methods[(name,method["name"],method["descriptor"])]=method_id;method_id+=1
    outputs, method_reports, unresolved, fields_unresolved, opcodes = [], [], {}, {}, Counter()
    concat_sites=[];lambda_sites=[];record_sites=[]
    for class_id,name in enumerate(sorted(classes)):
        cls = classes[name][0]; chunks, bodies = [], []
        for field in cls.fields:
            initial = f"JValue.Default({q(field['descriptor'])})"; constant_string = "null"
            if "constantIndex" in field:
                tag,value = cls.cp[field["constantIndex"]]
                if tag == 8: constant_string=q(cls.utf(value))
                else: initial=constant(cls,field["constantIndex"],True)
            chunks.append(f"c.Add(new JField({q(field['name'])},{q(field['descriptor'])},{str(bool(field['access']&8)).lower()},{initial},{constant_string}));")
        for method in cls.methods:
            key = (name,method["name"],method["descriptor"]); mid=methods[key]; gaps=[]
            if "instructions" in method:
                bodies.append(body(cls,method,mid,gaps,concat_sites,lambda_sites,record_sites)); delegate=f"M{mid}"
                opcodes.update(i["op"] for i in method["instructions"])
            else: delegate="null"
            handlers="new JHandler[]{"+",".join(f"new JHandler({h['start']},{h['end']},{h['handler']},{q(h['type'])})" for h in method.get("handlers",[]))+"}"
            chunks.append(f"c.Add(new JMethod({mid},{q(name)},{q(method['name'])},{q(method['descriptor'])},{method['access']},{method.get('maxLocals',0)},{method.get('maxStack',0)},{handlers},{delegate}));")
            report={"id":mid,"owner":name,"name":method["name"],"descriptor":method["descriptor"],"bodyGenerated":"instructions" in method,"native":bool(method["access"]&0x100),"abstract":bool(method["access"]&0x400),"instructionCount":len(method.get("instructions",[])),"gaps":gaps}
            method_reports.append(report)
            for ins in method.get("instructions",[]):
                if ins["op"] in {"invokevirtual","invokespecial","invokestatic","invokeinterface"}:
                    ref=cls.member_ref(ins["args"][0]);resolved=find_member(classes,*ref)
                    if resolved is None and ref not in INTRINSICS:
                        unresolved.setdefault(ref,[]).append({"caller":mid,"pc":ins["pc"],"dispatch":ins["op"]})
                if ins["op"] in {"getfield","putfield","getstatic","putstatic"}:
                    ref=cls.member_ref(ins["args"][0]);resolved=find_member(classes,*ref,field=True)
                    if resolved is None:fields_unresolved.setdefault(ref,[]).append({"caller":mid,"pc":ins["pc"]})
        initializers=[]
        for i in range(0,len(chunks),64):
            initializers.append("private static void Add"+str(i//64)+"(JClass c){\n"+"\n".join(chunks[i:i+64])+"\n}\n")
        interfaces="new string[]{"+",".join(map(q,cls.interfaces))+"}"
        create=f"internal static JClass Build(){{var c=new JClass({q(name)},{q(cls.super)},{interfaces},{cls.access});"+"".join(f"Add{i}(c);" for i in range(len(initializers)))+"return c;}\n"
        text="// Static C# generated from pinned Forge class files. GPL-3.0-or-later.\nusing System;\nusing Planeswalker.ForgeAot;\nnamespace Planeswalker.ForgeAot.Generated{internal static class C"+str(class_id)+"{\n"+create+"\n".join(initializers+bodies)+"}}\n"
        destination=f"C{class_id:04d}.Generated.cs";(generated/destination).write_text(text,encoding="utf-8");outputs.append(destination)
        if (class_id+1)%200==0: print(f"AOT classes: {class_id+1}/{len(classes)}",flush=True)
    main="// Generated static program metadata. No class/JAR payload or dynamic loading.\nusing Planeswalker.ForgeAot;\nnamespace Planeswalker.ForgeAot.Generated{public static class ForgeProgram{public static JRuntime CreateForGame(){ForgeBuildStatus.Readiness.RequireReady();return new JRuntime(BuildForDevelopment());}public static JProgram BuildForDevelopment(){var p=new JProgram();"+"".join(f"p.Add(C{i}.Build());" for i in range(len(classes)))+"foreach(var f in ForgeRuleFactories.Entries)p.Factories.Add(new JRuleFactory(f[0],f[1],f[2],f[3]));ForgeConcatSites.Register(p);ForgeLambdaSites.Register(p);ForgeRecordSites.Register(p);return p;}}}\n"
    (generated/"ForgeProgram.Generated.cs").write_text(main,encoding="utf-8");outputs.append("ForgeProgram.Generated.cs")
    registries=json.loads((ROOT/"data/forge/registries.json").read_text(encoding="utf-8"))
    factories=[]
    for kind in ("triggers","replacements","effects"):
        for entry in registries[kind]["entries"]:
            class_name=entry["source"].split("/src/main/java/",1)[1].removesuffix(".java")
            expected="()V" if kind=="effects" else "(Ljava/util/Map;Lforge/game/card/Card;Z)V"
            constructor=(class_name,"<init>",expected)
            factories.append({"category":kind,"name":entry["name"],"class":class_name,"constructor":expected,"methodId":methods.get(constructor),"fullyLinked":False})
    factory_code="// All original Forge factory entries; constructor targets are resolved at build time.\nnamespace Planeswalker.ForgeAot.Generated{public static class ForgeRuleFactories{public static readonly string[][] Entries=new string[][]{\n"+",\n".join("new string[]{"+",".join(map(q,(f["category"],f["name"],f["class"],f["constructor"])))+"}" for f in factories)+"};}}\n"
    (generated/"ForgeRuleFactories.Generated.cs").write_text(factory_code,encoding="utf-8");outputs.append("ForgeRuleFactories.Generated.cs")
    concat_chunks=[]
    for start in range(0,len(concat_sites),64):
        statements=[]
        for site in concat_sites[start:start+64]:
            constants="new JConcatConstant[]{"+",".join("new JConcatConstant("+q(c["text"])+")" if "text" in c else "new JConcatConstant("+c["expression"]+","+q(c["type"])+")" for c in site["constants"])+"}"
            statements.append(f"p.ConcatSites.Add({q(site['id'])},new JConcatSite({q(site['id'])},{q(site['descriptor'])},{q(site['recipe'])},{constants}));")
        concat_chunks.append("private static void Add"+str(start//64)+"(JProgram p){"+"\n".join(statements)+"}\n")
    concat_code="// Generated StringConcatFactory sites; Java float/object formatting remains ordinary linked calls.\nusing Planeswalker.ForgeAot;namespace Planeswalker.ForgeAot.Generated{internal static class ForgeConcatSites{public static void Register(JProgram p){"+"".join(f"Add{i}(p);" for i in range(len(concat_chunks)))+"}"+"\n".join(concat_chunks)+"}}\n"
    (generated/"ForgeConcatSites.Generated.cs").write_text(concat_code,encoding="utf-8");outputs.append("ForgeConcatSites.Generated.cs")
    lambda_chunks=[]
    for start in range(0,len(lambda_sites),64):
        statements=[]
        for site in lambda_sites[start:start+64]:
            values=[site[k] for k in ("id","descriptor","class","interface","samName","samDescriptor","instantiatedDescriptor")]+list(site["implementation"])
            markers="new string[]{"+",".join(map(q,site["markers"]))+"}"
            bridges="new string[]{"+",".join(map(q,site["bridges"]))+"}"
            statements.append("{var site=new JLambdaSite("+",".join(map(q,values))+","+str(site["referenceKind"])+","+markers+","+bridges+");p.LambdaSites.Add(site.Id,site);p.Add(JRuntime.LambdaClass(site));}")
        lambda_chunks.append("private static void Add"+str(start//64)+"(JProgram p){"+"\n".join(statements)+"}\n")
    lambda_code="// Static LambdaMetafactory capture/interface/method-handle plans. No CLR Emit or proxy generation.\nusing Planeswalker.ForgeAot;namespace Planeswalker.ForgeAot.Generated{internal static class ForgeLambdaSites{public static void Register(JProgram p){"+"".join(f"Add{i}(p);" for i in range(len(lambda_chunks)))+"}"+"\n".join(lambda_chunks)+"}}\n"
    (generated/"ForgeLambdaSites.Generated.cs").write_text(lambda_code,encoding="utf-8");outputs.append("ForgeLambdaSites.Generated.cs")
    record_chunks=[]
    for start in range(0,len(record_sites),64):
        statements=[]
        for site in record_sites[start:start+64]:
            values=[site[k] for k in ("id","descriptor","class","operation","concatId")]
            fields="new JRecordField[]{"+",".join("new JRecordField("+",".join(map(q,field))+")" for field in site["fields"])+"}"
            statements.append("p.RecordSites.Add("+q(site["id"])+",new JRecordSite("+",".join(map(q,values))+","+fields+"));")
        record_chunks.append("private static void Add"+str(start//64)+"(JProgram p){"+"\n".join(statements)+"}\n")
    record_code="// Generated Java record field/bootstrap plans. No runtime method-handle construction.\nusing Planeswalker.ForgeAot;namespace Planeswalker.ForgeAot.Generated{internal static class ForgeRecordSites{public static void Register(JProgram p){"+"".join(f"Add{i}(p);" for i in range(len(record_chunks)))+"}"+"\n".join(record_chunks)+"}}\n"
    (generated/"ForgeRecordSites.Generated.cs").write_text(record_code,encoding="utf-8");outputs.append("ForgeRecordSites.Generated.cs")
    for site in lambda_sites:
        reference=tuple(site["implementation"])
        if find_member(classes,*reference) is None and reference not in INTRINSICS:
            unresolved.setdefault(reference,[]).append({"caller":site["caller"],"pc":-1,"dispatch":"lambda-method-handle"})
    readiness="// Generated activation gate. Compilable source is not equivalent to a linked and verified rule engine.\nusing Planeswalker.ForgeAot;namespace Planeswalker.ForgeAot.Generated{public static class ForgeBuildStatus{public static readonly JPortReadiness Readiness=new JPortReadiness("+str(len(unresolved))+","+str(len(fields_unresolved))+","+str(sum(len(m["gaps"]) for m in method_reports))+",false,false,false);}}\n"
    (generated/"ForgeBuildStatus.Generated.cs").write_text(readiness,encoding="utf-8");outputs.append("ForgeBuildStatus.Generated.cs")
    includes="\n".join(f'<Compile Include="generated/{file}" />' for file in outputs)
    project='<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup><TargetFramework>netstandard2.1</TargetFramework><LangVersion>latest</LangVersion><Nullable>enable</Nullable><EnableDefaultCompileItems>false</EnableDefaultCompileItems><CheckForOverflowUnderflow>false</CheckForOverflowUnderflow></PropertyGroup><ItemGroup><ProjectReference Include="../../src/Forge.Aot/Forge.Aot.csproj" />'+includes+'</ItemGroup></Project>\n'
    (OUT/"Forge.Generated.csproj").write_text(project,encoding="utf-8")
    report={"schema":1,"route":"static-jvm-bytecode-to-csharp","modules":modules,"classFiles":len(classes),"methods":len(method_reports),"generatedBodies":sum(m["bodyGenerated"] for m in method_reports),"instructionCount":sum(m["instructionCount"] for m in method_reports),"unresolvedMethodReferences":len(unresolved),"unresolvedFieldReferences":len(fields_unresolved),"bootstrapOrConstantGaps":sum(len(m["gaps"]) for m in method_reports),"compiledConcatSites":len(concat_sites),"compiledLambdaSites":len(lambda_sites),"lambdaSitesNeedingMoreAdapters":sum(bool(s["remainingAdapters"]) for s in lambda_sites),"compiledRecordSites":len(record_sites),"factoryEntries":len(factories),"factoryConstructorsFound":sum(f["methodId"] is not None for f in factories),"compilationPassed":False,"runtimeSemanticsComplete":False,"allCardsUsable":False,"workshopEngineReady":False,"gameOrMatchStarted":False}
    write(OUT/"inputs.json",{"classes":inputs,"compilerSha256":sha(Path(__file__).read_bytes()),"classReaderSha256":sha((ROOT/"tools/forge_aot/classfile.py").read_bytes()),"runtimeSources":[{"path":path.relative_to(ROOT).as_posix(),"sha256":sha(path.read_bytes())} for path in sorted((ROOT/"src/Forge.Aot").glob("*.cs"))]})
    write(OUT/"methods.json",{"methods":method_reports})
    write(OUT/"linkage-gaps.json",{"methods":[{"owner":key[0],"name":key[1],"descriptor":key[2],"callSites":sites} for key,sites in sorted(unresolved.items())],"fields":[{"owner":key[0],"name":key[1],"descriptor":key[2],"callSites":sites} for key,sites in sorted(fields_unresolved.items())],"instructionKinds":dict(sorted(opcodes.items()))})
    write(OUT/"factories.json",{"entries":factories})
    write(OUT/"lambda-sites.json",{"sites":lambda_sites})
    write(OUT/"status.json",report)
    if check:
        environment=os.environ.copy();environment["DOTNET_CLI_HOME"]=str(ROOT/".dotnet");environment["DOTNET_CLI_UI_LANGUAGE"]="en-US"
        with (OUT/"build.log").open("w",encoding="utf-8") as log:
            build=subprocess.run(["dotnet","build",str(OUT/"Forge.Generated.csproj"),"-c","Release","--nologo"],env=environment,cwd=ROOT,stdout=log,stderr=subprocess.STDOUT)
        print("\n".join((OUT/"build.log").read_text(encoding="utf-8").splitlines()[-13:]),flush=True)
        build.check_returncode()
        report["compilationPassed"]=True;write(OUT/"status.json",report)
    print(json.dumps(report),flush=True)
    return report


if __name__=="__main__":
    parser=argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--modules",nargs="+",default=["forge-core","forge-game"])
    parser.add_argument("--check",action="store_true",help="Compile C# only; never runs engine/match tests")
    parser.add_argument("--require-ready",action="store_true",help="Return nonzero until full rule/runtime/host integration is actually ready")
    args=parser.parse_args()
    report=generate(args.modules,args.check)
    if getattr(args,"require_ready",False) and not report["workshopEngineReady"]:sys.exit(2)

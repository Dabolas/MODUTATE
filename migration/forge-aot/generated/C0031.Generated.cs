// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C31{
internal static JClass Build(){var c=new JClass("forge/card/CardFacePredicates$PredicateCoreType","java/lang/Object",new string[]{"java/util/function/Predicate"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("operand","Lforge/card/CardType$CoreType;",false,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("shouldBeEqual","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(575,"forge/card/CardFacePredicates$PredicateCoreType","test","(Lforge/card/ICardFace;)Z",1,2,3,new JHandler[]{},M575));
c.Add(new JMethod(576,"forge/card/CardFacePredicates$PredicateCoreType","<init>","(Lforge/card/CardType$CoreType;Z)V",1,3,2,new JHandler[]{},M576));
c.Add(new JMethod(577,"forge/card/CardFacePredicates$PredicateCoreType","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M577));
}

internal static JStep M575(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?7:5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFacePredicates$PredicateCoreType","shouldBeEqual","Z"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFacePredicates$PredicateCoreType","operand","Lforge/card/CardType$CoreType;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/CardType","hasType","(Lforge/card/CardType$CoreType;)Z","invokevirtual",24);}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?31:27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{f.Pc=32;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M576(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFacePredicates$PredicateCoreType","operand","Lforge/card/CardType$CoreType;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFacePredicates$PredicateCoreType","shouldBeEqual","Z",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M577(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardFacePredicates$PredicateCoreType","test","(Lforge/card/ICardFace;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

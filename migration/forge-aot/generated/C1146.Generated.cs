// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1146{
internal static JClass Build(){var c=new JClass("forge/util/PredicateString","java/lang/Object",new string[]{"java/util/function/Predicate"},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("operator","Lforge/util/PredicateString$StringOp;",false,JValue.Default("Lforge/util/PredicateString$StringOp;"),null));
c.Add(new JMethod(11977,"forge/util/PredicateString","op","(Ljava/lang/String;Ljava/lang/String;)Z",20,3,2,new JHandler[]{},M11977));
c.Add(new JMethod(11978,"forge/util/PredicateString","<init>","(Lforge/util/PredicateString$StringOp;)V",1,2,2,new JHandler[]{},M11978));
c.Add(new JMethod(11979,"forge/util/PredicateString","getOperator","()Lforge/util/PredicateString$StringOp;",1,1,1,new JHandler[]{},M11979));
c.Add(new JMethod(11980,"forge/util/PredicateString","contains","(Ljava/lang/String;)Lforge/util/PredicateString;",9,1,4,new JHandler[]{},M11980));
c.Add(new JMethod(11981,"forge/util/PredicateString","containsIgnoreCase","(Ljava/lang/String;)Lforge/util/PredicateString;",9,1,4,new JHandler[]{},M11981));
c.Add(new JMethod(11982,"forge/util/PredicateString","equals","(Ljava/lang/String;)Lforge/util/PredicateString;",9,1,4,new JHandler[]{},M11982));
}

internal static JStep M11977(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/PredicateString$4","$SwitchMap$forge$util$PredicateString$StringOp","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$4","$SwitchMap$forge$util$PredicateString$StringOp","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/PredicateString","getOperator","()Lforge/util/PredicateString$StringOp;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/util/PredicateString$StringOp","ordinal","()I","invokevirtual",10);}
case 10:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=11;continue;}
case 11:{switch(f.Pop().Int){case 1:f.Pc=40;break;case 2:f.Pc=46;break;case 3:f.Pc=52;break;case 4:f.Pc=58;break;default:f.Pc=64;break;}continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","containsIgnoreCase","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z","invokestatic",45);}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","contains","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z","invokestatic",51);}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",57);}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",63);}
case 63:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11978(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/PredicateString","operator","Lforge/util/PredicateString$StringOp;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11979(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/PredicateString","operator","Lforge/util/PredicateString$StringOp;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11980(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/PredicateString$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/PredicateString$1")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","CONTAINS","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","CONTAINS","Lforge/util/PredicateString$StringOp;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/PredicateString$1","<init>","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11981(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/PredicateString$2"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/PredicateString$2")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","CONTAINS_IC","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","CONTAINS_IC","Lforge/util/PredicateString$StringOp;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/PredicateString$2","<init>","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11982(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/PredicateString$3"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/PredicateString$3")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","EQUALS","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","EQUALS","Lforge/util/PredicateString$StringOp;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/PredicateString$3","<init>","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

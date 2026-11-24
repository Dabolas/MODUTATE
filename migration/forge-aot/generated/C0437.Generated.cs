// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C437{
internal static JClass Build(){var c=new JClass("forge/game/card/Card$HasKeywordVisitor","java/lang/Object",new string[]{"forge/util/Visitor"},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("keyword","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("result","Lorg/apache/commons/lang3/mutable/MutableBoolean;",false,JValue.Default("Lorg/apache/commons/lang3/mutable/MutableBoolean;"),null));
c.Add(new JField("startOf","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(4867,"forge/game/card/Card$HasKeywordVisitor","<init>","(Ljava/lang/String;Z)V",2,3,4,new JHandler[]{},M4867));
c.Add(new JMethod(4868,"forge/game/card/Card$HasKeywordVisitor","visit","(Lforge/game/keyword/KeywordInterface;)Z",1,3,2,new JHandler[]{},M4868));
c.Add(new JMethod(4869,"forge/game/card/Card$HasKeywordVisitor","getResult","()Z",1,1,1,new JHandler[]{},M4869));
c.Add(new JMethod(4870,"forge/game/card/Card$HasKeywordVisitor","visit","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M4870));
}

internal static JStep M4867(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/mutable/MutableBoolean"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/mutable/MutableBoolean")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","<init>","(Z)V","invokespecial",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card$HasKeywordVisitor","result","Lorg/apache/commons/lang3/mutable/MutableBoolean;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card$HasKeywordVisitor","keyword","Ljava/lang/String;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card$HasKeywordVisitor","startOf","Z",value);f.Pc=26;continue;}
case 26:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4868(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card$HasKeywordVisitor","startOf","Z"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?25:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card$HasKeywordVisitor","keyword","Ljava/lang/String;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int!=0?36:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card$HasKeywordVisitor","keyword","Ljava/lang/String;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?43:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card$HasKeywordVisitor","result","Lorg/apache/commons/lang3/mutable/MutableBoolean;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","setTrue","()V","invokevirtual",43);}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card$HasKeywordVisitor","result","Lorg/apache/commons/lang3/mutable/MutableBoolean;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","isFalse","()Z","invokevirtual",50);}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4869(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card$HasKeywordVisitor","result","Lorg/apache/commons/lang3/mutable/MutableBoolean;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","isTrue","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4870(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card$HasKeywordVisitor","visit","(Lforge/game/keyword/KeywordInterface;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

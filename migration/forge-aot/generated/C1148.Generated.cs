// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1148{
internal static JClass Build(){var c=new JClass("forge/util/PredicateString$2","forge/util/PredicateString",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("val$what","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(11986,"forge/util/PredicateString$2","<init>","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)V",0,3,2,new JHandler[]{},M11986));
c.Add(new JMethod(11987,"forge/util/PredicateString$2","test","(Ljava/lang/String;)Z",1,2,3,new JHandler[]{},M11987));
c.Add(new JMethod(11988,"forge/util/PredicateString$2","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M11988));
}

internal static JStep M11986(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/PredicateString$2","val$what","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/PredicateString","<init>","(Lforge/util/PredicateString$StringOp;)V","invokespecial",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11987(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/util/PredicateString$2","val$what","Ljava/lang/String;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/PredicateString$2","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11988(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/PredicateString$2","test","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

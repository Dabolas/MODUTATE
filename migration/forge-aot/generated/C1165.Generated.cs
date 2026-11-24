// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1165{
internal static JClass Build(){var c=new JClass("forge/util/ThreadUtil$WorkerThreadFactory","java/lang/Object",new string[]{"java/util/concurrent/ThreadFactory"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("countr","I",false,JValue.Default("I"),null));
c.Add(new JField("prefix","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(12095,"forge/util/ThreadUtil$WorkerThreadFactory","<init>","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M12095));
c.Add(new JMethod(12096,"forge/util/ThreadUtil$WorkerThreadFactory","newThread","(Ljava/lang/Runnable;)Ljava/lang/Thread;",1,3,8,new JHandler[]{},M12096));
}

internal static JStep M12095(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/ThreadUtil$WorkerThreadFactory","countr","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("")));f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/ThreadUtil$WorkerThreadFactory","prefix","Ljava/lang/String;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/ThreadUtil$WorkerThreadFactory","prefix","Ljava/lang/String;",value);f.Pc=20;continue;}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12096(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/Thread"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/Thread")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/util/ThreadUtil$WorkerThreadFactory","prefix","Ljava/lang/String;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/util/ThreadUtil$WorkerThreadFactory","countr","I"));f.Pc=14;continue;}
case 14:{f.StackOp("dup_x1");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/ThreadUtil$WorkerThreadFactory","countr","I",value);f.Pc=20;continue;}
case 20:{return rt.DynamicCall(f,"forge/util/ThreadUtil$WorkerThreadFactory:12096:20:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",25);}
case 25:{return rt.Call(f,"java/lang/Thread","<init>","(Ljava/lang/Runnable;Ljava/lang/String;)V","invokespecial",28);}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/Thread","setDaemon","(Z)V","invokevirtual",34);}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

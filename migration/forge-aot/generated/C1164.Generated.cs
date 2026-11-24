// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1164{
internal static JClass Build(){var c=new JClass("forge/util/ThreadUtil","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("gameThreadPool","Ljava/util/concurrent/ExecutorService;",true,JValue.Default("Ljava/util/concurrent/ExecutorService;"),null));
c.Add(new JField("scheduledPool","Ljava/util/concurrent/ScheduledExecutorService;",true,JValue.Default("Ljava/util/concurrent/ScheduledExecutorService;"),null));
c.Add(new JField("service","Ljava/util/concurrent/ExecutorService;",true,JValue.Default("Ljava/util/concurrent/ExecutorService;"),null));
c.Add(new JMethod(12080,"forge/util/ThreadUtil","<init>","()V",1,1,1,new JHandler[]{},M12080));
c.Add(new JMethod(12081,"forge/util/ThreadUtil","getGameThreadPool","()Ljava/util/concurrent/ExecutorService;",10,0,1,new JHandler[]{},M12081));
c.Add(new JMethod(12082,"forge/util/ThreadUtil","getScheduledPool","()Ljava/util/concurrent/ScheduledExecutorService;",10,0,1,new JHandler[]{},M12082));
c.Add(new JMethod(12083,"forge/util/ThreadUtil","getComputingPool","(F)Ljava/util/concurrent/ExecutorService;",25,1,3,new JHandler[]{},M12083));
c.Add(new JMethod(12084,"forge/util/ThreadUtil","isMultiCoreSystem","()Z",9,0,2,new JHandler[]{},M12084));
c.Add(new JMethod(12085,"forge/util/ThreadUtil","invokeInGameThread","(Ljava/lang/Runnable;)V",9,1,2,new JHandler[]{},M12085));
c.Add(new JMethod(12086,"forge/util/ThreadUtil","delay","(ILjava/lang/Runnable;)Ljava/util/concurrent/ScheduledFuture;",9,2,5,new JHandler[]{},M12086));
c.Add(new JMethod(12087,"forge/util/ThreadUtil","isGameThread","()Z",9,0,2,new JHandler[]{},M12087));
c.Add(new JMethod(12088,"forge/util/ThreadUtil","getServicePool","()Ljava/util/concurrent/ExecutorService;",9,0,1,new JHandler[]{},M12088));
c.Add(new JMethod(12089,"forge/util/ThreadUtil","refreshServicePool","()V",9,0,1,new JHandler[]{},M12089));
c.Add(new JMethod(12090,"forge/util/ThreadUtil","limit","(Ljava/util/concurrent/Callable;J)Ljava/lang/Object;",9,7,4,new JHandler[]{new JHandler(2,24,39,"java/lang/Exception"),new JHandler(2,24,59,""),new JHandler(39,44,59,""),new JHandler(59,61,59,"")},M12090));
c.Add(new JMethod(12091,"forge/util/ThreadUtil","executeWithTimeout","(Ljava/util/concurrent/Callable;I)Ljava/lang/Object;",9,7,4,new JHandler[]{new JHandler(17,30,41,"java/lang/Exception"),new JHandler(17,30,62,""),new JHandler(41,51,62,""),new JHandler(62,64,62,"")},M12091));
c.Add(new JMethod(12092,"forge/util/ThreadUtil","lambda$executeWithTimeout$1","(Ljava/lang/Runnable;)Ljava/lang/Thread;",4106,2,3,new JHandler[]{},M12092));
c.Add(new JMethod(12093,"forge/util/ThreadUtil","lambda$getComputingPool$0","(Ljava/lang/Runnable;)Ljava/lang/Thread;",4106,2,2,new JHandler[]{},M12093));
c.Add(new JMethod(12094,"forge/util/ThreadUtil","<clinit>","()V",8,0,6,new JHandler[]{},M12094));
}

internal static JStep M12080(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12081(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/ThreadUtil","gameThreadPool","Ljava/util/concurrent/ExecutorService;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ThreadUtil","gameThreadPool","Ljava/util/concurrent/ExecutorService;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12082(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/ThreadUtil","scheduledPool","Ljava/util/concurrent/ScheduledExecutorService;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ThreadUtil","scheduledPool","Ljava/util/concurrent/ScheduledExecutorService;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12083(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/lang/Runtime","getRuntime","()Ljava/lang/Runtime;","invokestatic",3);}
case 3:{return rt.Call(f,"java/lang/Runtime","availableProcessors","()I","invokevirtual",6);}
case 6:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=7;continue;}
case 7:{f.Push(JValue.F(1));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fsub",a,b));f.Pc=10;continue;}
case 10:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fdiv",a,b));f.Pc=11;continue;}
case 11:{f.Push(JNumbers.Unary("f2i",f.Pop()));f.Pc=12;continue;}
case 12:{return rt.DynamicCall(f,"forge/util/ThreadUtil:12083:12:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/concurrent/ThreadFactory;",17);}
case 17:{return rt.Call(f,"java/util/concurrent/Executors","newFixedThreadPool","(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;","invokestatic",20);}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12084(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/lang/Runtime","getRuntime","()Ljava/lang/Runtime;","invokestatic",3);}
case 3:{return rt.Call(f,"java/lang/Runtime","availableProcessors","()I","invokevirtual",6);}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12085(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/ThreadUtil","getGameThreadPool","()Ljava/util/concurrent/ExecutorService;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/concurrent/ExecutorService","execute","(Ljava/lang/Runnable;)V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12086(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/ThreadUtil","getScheduledPool","()Ljava/util/concurrent/ScheduledExecutorService;","invokestatic",3);}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"java/util/concurrent/TimeUnit","MILLISECONDS","Ljava/util/concurrent/TimeUnit;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/concurrent/TimeUnit","MILLISECONDS","Ljava/util/concurrent/TimeUnit;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/concurrent/ScheduledExecutorService","schedule","(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;","invokeinterface",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12087(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/lang/Thread","currentThread","()Ljava/lang/Thread;","invokestatic",3);}
case 3:{return rt.Call(f,"java/lang/Thread","getName","()Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Push(JValue.R(rt.String("Game")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12088(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/ThreadUtil","service","Ljava/util/concurrent/ExecutorService;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ThreadUtil","service","Ljava/util/concurrent/ExecutorService;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12089(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/util/concurrent/Executors","newWorkStealingPool","()Ljava/util/concurrent/ExecutorService;","invokestatic",3);}
case 3:{if(!rt.StaticReady(f,"forge/util/ThreadUtil","service","Ljava/util/concurrent/ExecutorService;"))return JStep.Continue;rt.PutStatic("forge/util/ThreadUtil","service","Ljava/util/concurrent/ExecutorService;",f.Pop());f.Pc=6;continue;}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12090(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/util/ThreadUtil","service","Ljava/util/concurrent/ExecutorService;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/ThreadUtil","service","Ljava/util/concurrent/ExecutorService;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/concurrent/ExecutorService","submit","(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;","invokeinterface",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"java/util/concurrent/TimeUnit","MILLISECONDS","Ljava/util/concurrent/TimeUnit;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/concurrent/TimeUnit","MILLISECONDS","Ljava/util/concurrent/TimeUnit;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/concurrent/Future","get","(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;","invokeinterface",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference==null?76:28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/concurrent/Future","cancel","(Z)Z","invokeinterface",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Pc=76;continue;}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(JValue.R(null));f.Pc=42;continue;}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Pc=f.Pop().Reference==null?76:48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/concurrent/Future","cancel","(Z)Z","invokeinterface",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Pc=76;continue;}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{f.Pc=f.Pop().Reference==null?73:65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/concurrent/Future","cancel","(Z)Z","invokeinterface",72);}
case 72:{f.StackOp("pop");f.Pc=73;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12091(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/util/ThreadUtil:12091:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/concurrent/ThreadFactory;",5);}
case 5:{return rt.Call(f,"java/util/concurrent/Executors","newCachedThreadPool","(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;","invokestatic",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/concurrent/ExecutorService","submit","(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;","invokeinterface",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"java/util/concurrent/TimeUnit","MILLISECONDS","Ljava/util/concurrent/TimeUnit;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/concurrent/TimeUnit","MILLISECONDS","Ljava/util/concurrent/TimeUnit;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/concurrent/Future","get","(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;","invokeinterface",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/concurrent/Future","cancel","(Z)Z","invokeinterface",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Pc=75;continue;}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/Exception","printStackTrace","()V","invokevirtual",48);}
case 48:{f.Push(JValue.R(null));f.Pc=49;continue;}
case 49:{f.Locals[4]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/concurrent/Future","cancel","(Z)Z","invokeinterface",58);}
case 58:{f.StackOp("pop");f.Pc=59;continue;}
case 59:{f.Pc=75;continue;}
case 62:{f.Locals[6]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{f.Push(JValue.I(1));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/concurrent/Future","cancel","(Z)Z","invokeinterface",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12092(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/Thread"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/Thread")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Thread","<init>","(Ljava/lang/Runnable;)V","invokespecial",8);}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Thread","setDaemon","(Z)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12093(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/util/concurrent/Executors","defaultThreadFactory","()Ljava/util/concurrent/ThreadFactory;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/concurrent/ThreadFactory","newThread","(Ljava/lang/Runnable;)Ljava/lang/Thread;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Thread","setDaemon","(Z)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12094(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("(ThreadUtil first call): Running with priority %d%n")));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Thread","currentThread","()Ljava/lang/Thread;","invokestatic",14);}
case 14:{return rt.Call(f,"java/lang/Thread","getPriority","()I","invokevirtual",17);}
case 17:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",20);}
case 20:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/io/PrintStream","printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{if(!rt.EnsureInitialized(f,"forge/util/ThreadUtil$WorkerThreadFactory"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/ThreadUtil$WorkerThreadFactory")));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("Game")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/util/ThreadUtil$WorkerThreadFactory","<init>","(Ljava/lang/String;)V","invokespecial",34);}
case 34:{return rt.Call(f,"java/util/concurrent/Executors","newCachedThreadPool","(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;","invokestatic",37);}
case 37:{if(!rt.StaticReady(f,"forge/util/ThreadUtil","gameThreadPool","Ljava/util/concurrent/ExecutorService;"))return JStep.Continue;rt.PutStatic("forge/util/ThreadUtil","gameThreadPool","Ljava/util/concurrent/ExecutorService;",f.Pop());f.Pc=40;continue;}
case 40:{f.Push(JValue.I(2));f.Pc=41;continue;}
case 41:{if(!rt.EnsureInitialized(f,"forge/util/ThreadUtil$WorkerThreadFactory"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/ThreadUtil$WorkerThreadFactory")));f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("Delayed")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/util/ThreadUtil$WorkerThreadFactory","<init>","(Ljava/lang/String;)V","invokespecial",50);}
case 50:{return rt.Call(f,"java/util/concurrent/Executors","newScheduledThreadPool","(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;","invokestatic",53);}
case 53:{if(!rt.StaticReady(f,"forge/util/ThreadUtil","scheduledPool","Ljava/util/concurrent/ScheduledExecutorService;"))return JStep.Continue;rt.PutStatic("forge/util/ThreadUtil","scheduledPool","Ljava/util/concurrent/ScheduledExecutorService;",f.Pop());f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/concurrent/Executors","newWorkStealingPool","()Ljava/util/concurrent/ExecutorService;","invokestatic",59);}
case 59:{if(!rt.StaticReady(f,"forge/util/ThreadUtil","service","Ljava/util/concurrent/ExecutorService;"))return JStep.Continue;rt.PutStatic("forge/util/ThreadUtil","service","Ljava/util/concurrent/ExecutorService;",f.Pop());f.Pc=62;continue;}
case 62:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

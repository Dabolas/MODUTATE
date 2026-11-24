// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1144{
internal static JClass Build(){var c=new JClass("forge/util/MyRandom$CountingRandom","java/util/Random",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("delegate","Ljava/util/Random;",false,JValue.Default("Ljava/util/Random;"),null));
c.Add(new JField("calls","Ljava/util/concurrent/atomic/AtomicLong;",false,JValue.Default("Ljava/util/concurrent/atomic/AtomicLong;"),null));
c.Add(new JMethod(11967,"forge/util/MyRandom$CountingRandom","<init>","(Ljava/util/Random;)V",0,2,3,new JHandler[]{},M11967));
c.Add(new JMethod(11968,"forge/util/MyRandom$CountingRandom","next","(I)I",4,2,3,new JHandler[]{},M11968));
c.Add(new JMethod(11969,"forge/util/MyRandom$CountingRandom","setSeed","(J)V",1,3,3,new JHandler[]{},M11969));
c.Add(new JMethod(11970,"forge/util/MyRandom$CountingRandom","callCount","()J",0,1,2,new JHandler[]{},M11970));
}

internal static JStep M11967(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.L(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Random","<init>","(J)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/util/concurrent/atomic/AtomicLong"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/atomic/AtomicLong")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/concurrent/atomic/AtomicLong","<init>","()V","invokespecial",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/MyRandom$CountingRandom","calls","Ljava/util/concurrent/atomic/AtomicLong;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/MyRandom$CountingRandom","delegate","Ljava/util/Random;",value);f.Pc=21;continue;}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11968(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/MyRandom$CountingRandom","calls","Ljava/util/concurrent/atomic/AtomicLong;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/concurrent/atomic/AtomicLong","incrementAndGet","()J","invokevirtual",7);}
case 7:{f.StackOp("pop2");f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/util/MyRandom","TRACE","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/MyRandom","TRACE","Z"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?17:14;continue;}
case 14:{return rt.Call(f,"forge/util/MyRandom","trace","()V","invokestatic",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/util/MyRandom$CountingRandom","delegate","Ljava/util/Random;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Random","nextInt","()I","invokevirtual",24);}
case 24:{f.Push(JValue.I(32));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=28;continue;}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iushr",a,b));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11969(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/MyRandom$CountingRandom","delegate","Ljava/util/Random;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/util/MyRandom$CountingRandom","delegate","Ljava/util/Random;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Random","setSeed","(J)V","invokevirtual",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11970(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/MyRandom$CountingRandom","calls","Ljava/util/concurrent/atomic/AtomicLong;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/concurrent/atomic/AtomicLong","get","()J","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1159{
internal static JClass Build(){var c=new JClass("forge/util/StreamUtil$RandomCollectorSingle","forge/util/StreamUtil$RandomCollector",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(12034,"forge/util/StreamUtil$RandomCollectorSingle","<init>","()V",0,1,2,new JHandler[]{},M12034));
c.Add(new JMethod(12035,"forge/util/StreamUtil$RandomCollectorSingle","finisher","()Ljava/util/function/Function;",1,1,1,new JHandler[]{},M12035));
c.Add(new JMethod(12036,"forge/util/StreamUtil$RandomCollectorSingle","lambda$finisher$0","(Lforge/util/StreamUtil$RandomReservoir;)Ljava/util/Optional;",4106,1,2,new JHandler[]{},M12036));
}

internal static JStep M12034(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/StreamUtil$RandomCollector","<init>","(I)V","invokespecial",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12035(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/util/StreamUtil$RandomCollectorSingle:12035:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12036(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","samples","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?16:10;continue;}
case 10:{return rt.Call(f,"java/util/Optional","empty","()Ljava/util/Optional;","invokestatic",13);}
case 13:{f.Pc=27;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","samples","Ljava/util/ArrayList;"));f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/ArrayList","get","(I)Ljava/lang/Object;","invokevirtual",24);}
case 24:{return rt.Call(f,"java/util/Optional","of","(Ljava/lang/Object;)Ljava/util/Optional;","invokestatic",27);}
case 27:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1158{
internal static JClass Build(){var c=new JClass("forge/util/StreamUtil$RandomCollectorMulti","forge/util/StreamUtil$RandomCollector",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(12031,"forge/util/StreamUtil$RandomCollectorMulti","<init>","(I)V",0,2,2,new JHandler[]{},M12031));
c.Add(new JMethod(12032,"forge/util/StreamUtil$RandomCollectorMulti","finisher","()Ljava/util/function/Function;",1,1,1,new JHandler[]{},M12032));
c.Add(new JMethod(12033,"forge/util/StreamUtil$RandomCollectorMulti","lambda$finisher$0","(Lforge/util/StreamUtil$RandomReservoir;)Ljava/util/List;",4106,1,1,new JHandler[]{},M12033));
}

internal static JStep M12031(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/StreamUtil$RandomCollector","<init>","(I)V","invokespecial",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12032(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/util/StreamUtil$RandomCollectorMulti:12032:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12033(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/StreamUtil$RandomReservoir","samples","Ljava/util/ArrayList;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

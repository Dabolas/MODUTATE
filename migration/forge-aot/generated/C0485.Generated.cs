// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C485{
internal static JClass Build(){var c=new JClass("forge/game/card/DummyCardView","forge/game/card/CardView",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(5811,"forge/game/card/DummyCardView","<init>","(ILforge/trackable/Tracker;)V",1,3,3,new JHandler[]{},M5811));
c.Add(new JMethod(5812,"forge/game/card/DummyCardView","createAlternateState","(Lforge/card/CardStateName;)Lforge/game/card/CardView$CardStateView;",1,2,6,new JHandler[]{},M5812));
}

internal static JStep M5811(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/CardView","<init>","(ILforge/trackable/Tracker;)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5812(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/DummyCardView$DummyCardStateView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/DummyCardView$DummyCardStateView")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/DummyCardView","getId","()I","invokevirtual",9);}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/DummyCardView","tracker","Lforge/trackable/Tracker;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/DummyCardView$DummyCardStateView","<init>","(Lforge/game/card/DummyCardView;ILforge/card/CardStateName;Lforge/trackable/Tracker;)V","invokespecial",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

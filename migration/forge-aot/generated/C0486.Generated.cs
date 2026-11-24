// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C486{
internal static JClass Build(){var c=new JClass("forge/game/card/DummyCardView$DummyCardStateView","forge/game/card/CardView$CardStateView",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("this$0","Lforge/game/card/DummyCardView;",false,JValue.Default("Lforge/game/card/DummyCardView;"),null));
c.Add(new JMethod(5813,"forge/game/card/DummyCardView$DummyCardStateView","<init>","(Lforge/game/card/DummyCardView;ILforge/card/CardStateName;Lforge/trackable/Tracker;)V",1,5,5,new JHandler[]{},M5813));
c.Add(new JMethod(5814,"forge/game/card/DummyCardView$DummyCardStateView","updateAbilityText","(Lforge/game/card/Card;Lforge/game/card/CardState;)V",0,3,0,new JHandler[]{},M5814));
}

internal static JStep M5813(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/DummyCardView$DummyCardStateView","this$0","Lforge/game/card/DummyCardView;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[4]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardView$CardStateView","<init>","(Lforge/game/card/CardView;ILforge/card/CardStateName;Lforge/trackable/Tracker;)V","invokespecial",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5814(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

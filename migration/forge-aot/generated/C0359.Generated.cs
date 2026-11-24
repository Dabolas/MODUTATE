// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C359{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ProtectEffect$1","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(7682700789217703789L),null));
c.Add(new JField("val$gameCard","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("val$game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("this$0","Lforge/game/ability/effects/ProtectEffect;",false,JValue.Default("Lforge/game/ability/effects/ProtectEffect;"),null));
c.Add(new JMethod(3579,"forge/game/ability/effects/ProtectEffect$1","<init>","(Lforge/game/ability/effects/ProtectEffect;Lforge/game/card/Card;JLforge/game/Game;)V",0,6,3,new JHandler[]{},M3579));
c.Add(new JMethod(3580,"forge/game/ability/effects/ProtectEffect$1","run","()V",1,1,6,new JHandler[]{},M3580));
}

internal static JStep M3579(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ProtectEffect$1","this$0","Lforge/game/ability/effects/ProtectEffect;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ProtectEffect$1","val$gameCard","Lforge/game/card/Card;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ProtectEffect$1","val$timestamp","J",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ProtectEffect$1","val$game","Lforge/game/Game;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",25);}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3580(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ProtectEffect$1","val$gameCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?42:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ProtectEffect$1","val$gameCard","Lforge/game/card/Card;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ProtectEffect$1","val$timestamp","J"));f.Pc=18;continue;}
case 18:{f.Push(JValue.L(0));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","removeChangedCardKeywords","(JJZ)Z","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ProtectEffect$1","val$game","Lforge/game/Game;"));f.Pc=28;continue;}
case 28:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ProtectEffect$1","val$gameCard","Lforge/game/card/Card;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",39);}
case 39:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",42);}
case 42:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

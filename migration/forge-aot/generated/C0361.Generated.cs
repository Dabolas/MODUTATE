// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C361{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/PumpAllEffect$1","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(5415795460189457660L),null));
c.Add(new JField("val$tgtC","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("val$game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JMethod(3585,"forge/game/ability/effects/PumpAllEffect$1","<init>","(Lforge/game/card/Card;JLforge/game/Game;)V",0,5,3,new JHandler[]{},M3585));
c.Add(new JMethod(3586,"forge/game/ability/effects/PumpAllEffect$1","run","()V",1,1,5,new JHandler[]{},M3586));
}

internal static JStep M3585(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/PumpAllEffect$1","val$tgtC","Lforge/game/card/Card;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/PumpAllEffect$1","val$timestamp","J",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/PumpAllEffect$1","val$game","Lforge/game/Game;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3586(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpAllEffect$1","val$tgtC","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpAllEffect$1","val$timestamp","J"));f.Pc=8;continue;}
case 8:{f.Push(JValue.L(0));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","removePTBoost","(JJ)Z","invokevirtual",12);}
case 12:{f.StackOp("pop");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpAllEffect$1","val$tgtC","Lforge/game/card/Card;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpAllEffect$1","val$timestamp","J"));f.Pc=21;continue;}
case 21:{f.Push(JValue.L(0));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/Card","removeChangedCardKeywords","(JJ)Z","invokevirtual",25);}
case 25:{f.StackOp("pop");f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpAllEffect$1","val$tgtC","Lforge/game/card/Card;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpAllEffect$1","val$timestamp","J"));f.Pc=34;continue;}
case 34:{f.Push(JValue.L(0));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/Card","removeHiddenExtrinsicKeywords","(JJ)V","invokevirtual",38);}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpAllEffect$1","val$tgtC","Lforge/game/card/Card;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","updatePTforView","()V","invokevirtual",45);}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpAllEffect$1","val$game","Lforge/game/Game;"));f.Pc=49;continue;}
case 49:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=52;continue;}
case 52:{f.StackOp("dup");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpAllEffect$1","val$tgtC","Lforge/game/card/Card;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",60);}
case 60:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",63);}
case 63:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C203{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AnimateEffectBase$1","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-5861759814760561373L),null));
c.Add(new JField("val$c","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("val$game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JMethod(3030,"forge/game/ability/effects/AnimateEffectBase$1","<init>","(Lforge/game/card/Card;JLforge/game/Game;)V",0,5,3,new JHandler[]{},M3030));
c.Add(new JMethod(3031,"forge/game/ability/effects/AnimateEffectBase$1","run","()V",1,1,5,new JHandler[]{},M3031));
}

internal static JStep M3030(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$1","val$c","Lforge/game/card/Card;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$1","val$timestamp","J",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$1","val$game","Lforge/game/Game;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3031(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$1","val$c","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$1","val$timestamp","J"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/ability/effects/AnimateEffectBase","doUnanimate","(Lforge/game/card/Card;J)V","invokestatic",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$1","val$c","Lforge/game/card/Card;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$1","val$timestamp","J"));f.Pc=19;continue;}
case 19:{f.Push(JValue.L(0));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","removeChangedSVars","(JJ)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$1","val$c","Lforge/game/card/Card;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$1","val$timestamp","J"));f.Pc=31;continue;}
case 31:{f.Push(JValue.L(0));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","removeChangedName","(JJ)Z","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$1","val$c","Lforge/game/card/Card;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",43);}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$1","val$c","Lforge/game/card/Card;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","updatePTforView","()V","invokevirtual",50);}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$1","val$game","Lforge/game/Game;"));f.Pc=54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/AnimateEffectBase$1","val$c","Lforge/game/card/Card;"));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",65);}
case 65:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",68);}
case 68:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

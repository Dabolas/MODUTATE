// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C255{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ControlGainEffect$2","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(878543373519872418L),null));
c.Add(new JField("val$c","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$tStamp","J",false,JValue.Default("J"),null));
c.Add(new JField("val$host","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JMethod(3209,"forge/game/ability/effects/ControlGainEffect$2","<init>","(Lforge/game/card/Card;JLforge/game/card/Card;)V",0,5,3,new JHandler[]{},M3209));
c.Add(new JMethod(3210,"forge/game/ability/effects/ControlGainEffect$2","run","()V",1,1,5,new JHandler[]{},M3210));
}

internal static JStep M3209(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$2","val$c","Lforge/game/card/Card;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$2","val$tStamp","J",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$2","val$host","Lforge/game/card/Card;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3210(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$2","val$c","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantGainControl","cantGainControl","(Lforge/game/card/Card;)Z","invokestatic",7);}
case 7:{f.Pc=f.Pop().Int==0?11:10;continue;}
case 10:{return JStep.ReturnVoid;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$2","val$c","Lforge/game/card/Card;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?49:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$2","val$c","Lforge/game/card/Card;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$2","val$tStamp","J"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/Card","removeTempController","(J)V","invokevirtual",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$2","val$c","Lforge/game/card/Card;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",42);}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$2","val$c","Lforge/game/card/Card;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/GameAction","controllerChangeZoneCorrection","(Lforge/game/card/Card;)V","invokevirtual",49);}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$2","val$host","Lforge/game/card/Card;"));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$2","val$c","Lforge/game/card/Card;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","removeGainControlTargets","(Lforge/game/card/Card;)V","invokevirtual",60);}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$2","val$c","Lforge/game/card/Card;"));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ControlGainEffect$2","val$tStamp","J"));f.Pc=68;continue;}
case 68:{f.Push(JValue.L(0));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/Card","removeChangedSVars","(JJ)V","invokevirtual",72);}
case 72:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

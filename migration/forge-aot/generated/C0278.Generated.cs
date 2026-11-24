// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C278{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DamagePreventEffect$1","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("val$game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("val$eff","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$o","Lforge/game/GameEntity;",false,JValue.Default("Lforge/game/GameEntity;"),null));
c.Add(new JMethod(3300,"forge/game/ability/effects/DamagePreventEffect$1","<init>","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/GameEntity;)V",0,4,2,new JHandler[]{},M3300));
c.Add(new JMethod(3301,"forge/game/ability/effects/DamagePreventEffect$1","run","()V",1,1,4,new JHandler[]{},M3301));
}

internal static JStep M3300(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/DamagePreventEffect$1","val$game","Lforge/game/Game;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/DamagePreventEffect$1","val$eff","Lforge/game/card/Card;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/DamagePreventEffect$1","val$o","Lforge/game/GameEntity;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3301(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/DamagePreventEffect$1","val$game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/DamagePreventEffect$1","val$eff","Lforge/game/card/Card;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/GameAction","exileEffect","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/DamagePreventEffect$1","val$o","Lforge/game/GameEntity;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/GameEntity","getView","()Lforge/game/GameEntityView;","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/DamagePreventEffect$1","val$o","Lforge/game/GameEntity;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/GameEntityView","updatePreventNextDamage","(Lforge/game/GameEntity;)V","invokevirtual",29);}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/DamagePreventEffect$1","val$o","Lforge/game/GameEntity;"));f.Pc=33;continue;}
case 33:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=36;continue;}
case 36:{f.Pc=f.Pop().Int==0?60:39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/DamagePreventEffect$1","val$game","Lforge/game/Game;"));f.Pc=43;continue;}
case 43:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventPlayerStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventPlayerStatsChanged")));f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/DamagePreventEffect$1","val$o","Lforge/game/GameEntity;"));f.Pc=51;continue;}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/event/GameEventPlayerStatsChanged","<init>","(Lforge/game/player/Player;)V","invokespecial",57);}
case 57:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",60);}
case 60:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C392{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RollPlanarDiceEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3697,"forge/game/ability/effects/RollPlanarDiceEffect","<init>","()V",1,1,1,new JHandler[]{},M3697));
c.Add(new JMethod(3698,"forge/game/ability/effects/RollPlanarDiceEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,6,6,new JHandler[]{},M3698));
}

internal static JStep M3697(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3698(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","getActivePlanes","()Ljava/util/List;","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Reference!=null?18:17;continue;}
case 17:{return JStep.ReturnVoid;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("SpecialAction")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?34:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/phase/PhaseHandler","incPlanarDiceSpecialActionThisTurn","()V","invokevirtual",34);}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(null));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/PlanarDice","roll","(Lforge/game/player/Player;Lforge/game/PlanarDice;)Lforge/game/PlanarDice;","invokestatic",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventRollDie"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventRollDie")));f.Pc=45;continue;}
case 45:{f.StackOp("dup");f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/event/GameEventRollDie","<init>","(Lforge/game/PlanarDice;)V","invokespecial",51);}
case 51:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",57);}
case 57:{f.Push(JValue.R(rt.String("lblPlanarDiceResult")));f.Pc=59;continue;}
case 59:{f.Push(JValue.I(1));f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/PlanarDice","toString","()Ljava/lang/String;","invokevirtual",70);}
case 70:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",74);}
case 74:{f.Locals[5]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",80);}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(null));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",88);}
case 88:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

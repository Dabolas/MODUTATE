// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C457{
internal static JClass Build(){var c=new JClass("forge/game/card/CardFactoryUtil$4","forge/game/spellability/AbilityStatic",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(5043,"forge/game/card/CardFactoryUtil$4","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V",0,4,4,new JHandler[]{},M5043));
c.Add(new JMethod(5044,"forge/game/card/CardFactoryUtil$4","canPlay","()Z",1,3,3,new JHandler[]{},M5044));
c.Add(new JMethod(5045,"forge/game/card/CardFactoryUtil$4","isForetelling","()Z",1,1,1,new JHandler[]{},M5045));
c.Add(new JMethod(5046,"forge/game/card/CardFactoryUtil$4","resolve","()V",1,5,4,new JHandler[]{},M5046));
}

internal static JStep M5043(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/AbilityStatic","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5044(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardFactoryUtil$4","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardFactoryUtil$4","getHostCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","canPlay","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int!=0?17:15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardFactoryUtil$4","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",21);}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?51:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardFactoryUtil$4","getHostCard","()Lforge/game/card/Card;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/game/staticability/StaticAbilityForetell","canForetellAnyTurn","(Lforge/game/player/Player;Lforge/game/card/Card;)Z","invokestatic",46);}
case 46:{f.Pc=f.Pop().Int!=0?51:49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 51:{f.Push(JValue.I(1));f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5045(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5046(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardFactoryUtil$4","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardFactoryUtil$4","getHostCard","()Lforge/game/card/Card;","invokevirtual",26);}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",39);}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","setForetold","(Z)V","invokevirtual",45);}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/card/CardFactoryUtil$4","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/game/card/Card","addMayLookFaceDownExile","(Lforge/game/player/Player;)V","invokevirtual",61);}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/CardFactoryUtil$4","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",65);}
case 65:{return rt.Call(f,"forge/game/player/Player","addForetoldThisTurn","()V","invokevirtual",68);}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/CardFactoryUtil$4","isIntrinsic","()Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int!=0?81:75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{f.Push(JValue.I(1));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/card/Card","setForetoldCostByEffect","(Z)V","invokevirtual",81);}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardForetold"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardForetold")));f.Pc=85;continue;}
case 85:{f.StackOp("dup");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/CardFactoryUtil$4","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",90);}
case 90:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",93);}
case 93:{return rt.Call(f,"forge/game/event/GameEventCardForetold","<init>","(Lforge/game/player/PlayerView;)V","invokespecial",96);}
case 96:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",99);}
case 99:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

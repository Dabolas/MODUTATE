// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C302{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/EndTurnEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3388,"forge/game/ability/effects/EndTurnEffect","<init>","()V",1,1,1,new JHandler[]{},M3388));
c.Add(new JMethod(3389,"forge/game/ability/effects/EndTurnEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,7,6,new JHandler[]{},M3389));
c.Add(new JMethod(3390,"forge/game/ability/effects/EndTurnEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M3390));
}

internal static JStep M3388(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3389(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Defined")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/effects/EndTurnEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?23:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",20);}
case 20:{f.Pc=33;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int!=0?47:41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/ability/effects/EndTurnEffect","getNewChooser","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/player/Player;","invokestatic",46);}
case 46:{f.Locals[3]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("Optional")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?82:56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",60);}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(null));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",65);}
case 65:{f.Push(JValue.R(rt.String("lblDoYouWantEndTurn")));f.Pc=67;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",74);}
case 74:{f.Push(JValue.R(null));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int!=0?82:81;continue;}
case 81:{return JStep.ReturnVoid;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",86);}
case 86:{f.Locals[4]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",93);}
case 93:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearWaitingTriggers","()V","invokevirtual",96);}
case 96:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",99);}
case 99:{f.Locals[5]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",107);}
case 107:{f.Locals[6]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",114);}
case 114:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=117;continue;}
case 117:{f.StackOp("dup");f.Pc=118;continue;}
case 118:{f.Push(f.Locals[4]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",123);}
case 123:{return rt.Call(f,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",126);}
case 126:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",129);}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[5]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/CardCollection;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",135);}
case 135:{f.StackOp("pop");f.Pc=136;continue;}
case 136:{f.Push(f.Locals[6]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[4]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[1]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",144);}
case 144:{f.Push(f.Locals[4]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",149);}
case 149:{return rt.Call(f,"forge/game/zone/MagicStack","clear","()V","invokevirtual",152);}
case 152:{f.Push(f.Locals[4]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",157);}
case 157:{return rt.Call(f,"forge/game/zone/MagicStack","clearSimultaneousStack","()V","invokevirtual",160);}
case 160:{f.Push(f.Locals[4]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",165);}
case 165:{return rt.Call(f,"forge/game/phase/PhaseHandler","endCombat","()V","invokevirtual",168);}
case 168:{f.Push(f.Locals[4]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",173);}
case 173:{f.Push(JValue.I(1));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/GameAction","checkStateEffects","(Z)Z","invokevirtual",177);}
case 177:{f.StackOp("pop");f.Pc=178;continue;}
case 178:{f.Push(f.Locals[4]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",183);}
case 183:{return rt.Call(f,"forge/game/phase/PhaseHandler","endTurnByEffect","()V","invokevirtual",186);}
case 186:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3390(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("End the turn.")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

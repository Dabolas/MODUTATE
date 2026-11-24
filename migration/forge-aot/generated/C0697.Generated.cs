// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C697{
internal static JClass Build(){var c=new JClass("forge/game/phase/PhaseHandler","java/lang/Object",new string[]{"forge/util/IHasForgeLog"},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("sw","Lorg/apache/commons/lang3/time/StopWatch;",false,JValue.Default("Lorg/apache/commons/lang3/time/StopWatch;"),null));
c.Add(new JField("phase","Lforge/game/phase/PhaseType;",false,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("turn","I",false,JValue.Default("I"),null));
c.Add(new JField("extraTurns","Ljava/util/Stack;",false,JValue.Default("Ljava/util/Stack;"),null));
c.Add(new JField("extraPhases","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("nUpkeepsThisTurn","I",false,JValue.Default("I"),null));
c.Add(new JField("nUpkeepsThisGame","I",false,JValue.Default("I"),null));
c.Add(new JField("nCombatsThisTurn","I",false,JValue.Default("I"),null));
c.Add(new JField("nMainsThisTurn","I",false,JValue.Default("I"),null));
c.Add(new JField("nEndOfTurnsThisTurn","I",false,JValue.Default("I"),null));
c.Add(new JField("planarDiceSpecialActionThisTurn","I",false,JValue.Default("I"),null));
c.Add(new JField("playerTurn","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("playerPreviousTurn","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("pPlayerPriority","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("pFirstPriority","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("combat","Lforge/game/combat/Combat;",false,JValue.Default("Lforge/game/combat/Combat;"),null));
c.Add(new JField("skipDamageSteps","Z",false,JValue.Default("Z"),null));
c.Add(new JField("bRepeatCleanup","Z",false,JValue.Default("Z"),null));
c.Add(new JField("givePriorityToPlayer","Z",false,JValue.Default("Z"),null));
c.Add(new JField("game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("DEBUG_PHASES","Z",true,JValue.I(0),null));
c.Add(new JMethod(7865,"forge/game/phase/PhaseHandler","<init>","(Lforge/game/Game;)V",1,2,3,new JHandler[]{},M7865));
c.Add(new JMethod(7866,"forge/game/phase/PhaseHandler","getPhase","()Lforge/game/phase/PhaseType;",17,1,1,new JHandler[]{},M7866));
c.Add(new JMethod(7867,"forge/game/phase/PhaseHandler","setPhase","(Lforge/game/phase/PhaseType;)V",2,2,2,new JHandler[]{},M7867));
c.Add(new JMethod(7868,"forge/game/phase/PhaseHandler","getTurn","()I",17,1,1,new JHandler[]{},M7868));
c.Add(new JMethod(7869,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z",17,2,2,new JHandler[]{},M7869));
c.Add(new JMethod(7870,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;",17,1,1,new JHandler[]{},M7870));
c.Add(new JMethod(7871,"forge/game/phase/PhaseHandler","teamLead","(Lforge/game/player/Player;)Lforge/game/player/Player;",2,2,3,new JHandler[]{},M7871));
c.Add(new JMethod(7872,"forge/game/phase/PhaseHandler","nextTurnLead","()Lforge/game/player/Player;",2,2,2,new JHandler[]{},M7872));
c.Add(new JMethod(7873,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;",17,1,1,new JHandler[]{},M7873));
c.Add(new JMethod(7874,"forge/game/phase/PhaseHandler","setPlayerTurn","(Lforge/game/player/Player;)V",17,2,2,new JHandler[]{},M7874));
c.Add(new JMethod(7875,"forge/game/phase/PhaseHandler","isPlayerNextTurn","(Lforge/game/player/Player;)Z",17,2,2,new JHandler[]{},M7875));
c.Add(new JMethod(7876,"forge/game/phase/PhaseHandler","getPreviousPlayerTurn","()Lforge/game/player/Player;",17,1,1,new JHandler[]{},M7876));
c.Add(new JMethod(7877,"forge/game/phase/PhaseHandler","getPriorityPlayer","()Lforge/game/player/Player;",17,1,1,new JHandler[]{},M7877));
c.Add(new JMethod(7878,"forge/game/phase/PhaseHandler","setPriority","(Lforge/game/player/Player;)V",17,2,2,new JHandler[]{},M7878));
c.Add(new JMethod(7879,"forge/game/phase/PhaseHandler","resetPriority","()V",17,1,2,new JHandler[]{},M7879));
c.Add(new JMethod(7880,"forge/game/phase/PhaseHandler","inCombat","()Z",17,1,1,new JHandler[]{},M7880));
c.Add(new JMethod(7881,"forge/game/phase/PhaseHandler","getCombat","()Lforge/game/combat/Combat;",17,1,1,new JHandler[]{},M7881));
c.Add(new JMethod(7882,"forge/game/phase/PhaseHandler","advanceToNextPhase","()V",2,9,6,new JHandler[]{},M7882));
c.Add(new JMethod(7883,"forge/game/phase/PhaseHandler","isSkippingPhase","(Lforge/game/phase/PhaseType;)Z",2,2,2,new JHandler[]{},M7883));
c.Add(new JMethod(7884,"forge/game/phase/PhaseHandler","discardToHandSize","(Lforge/game/player/Player;)V",2,12,5,new JHandler[]{},M7884));
c.Add(new JMethod(7885,"forge/game/phase/PhaseHandler","onPhaseBegin","()V",2,7,5,new JHandler[]{},M7885));
c.Add(new JMethod(7886,"forge/game/phase/PhaseHandler","onPhaseEnd","()V",2,1,2,new JHandler[]{},M7886));
c.Add(new JMethod(7887,"forge/game/phase/PhaseHandler","onPhaseEnd","(Z)V",2,7,5,new JHandler[]{},M7887));
c.Add(new JMethod(7888,"forge/game/phase/PhaseHandler","declareAttackersTurnBasedAction","()V",2,13,5,new JHandler[]{},M7888));
c.Add(new JMethod(7889,"forge/game/phase/PhaseHandler","declareBlockersFor","(Lforge/game/player/Player;)V",2,5,3,new JHandler[]{},M7889));
c.Add(new JMethod(7890,"forge/game/phase/PhaseHandler","declareBlockersTurnBasedAction","()V",2,14,5,new JHandler[]{},M7890));
c.Add(new JMethod(7891,"forge/game/phase/PhaseHandler","restart","()V",1,1,2,new JHandler[]{},M7891));
c.Add(new JMethod(7892,"forge/game/phase/PhaseHandler","handleNextTurn","()Lforge/game/player/Player;",2,4,4,new JHandler[]{},M7892));
c.Add(new JMethod(7893,"forge/game/phase/PhaseHandler","getNextActivePlayer","()Lforge/game/player/Player;",2,8,5,new JHandler[]{},M7893));
c.Add(new JMethod(7894,"forge/game/phase/PhaseHandler","is","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;)Z",17,3,2,new JHandler[]{},M7894));
c.Add(new JMethod(7895,"forge/game/phase/PhaseHandler","is","(Lforge/game/phase/PhaseType;)Z",17,2,2,new JHandler[]{},M7895));
c.Add(new JMethod(7896,"forge/game/phase/PhaseHandler","getNextTurn","()Lforge/game/player/Player;",17,1,1,new JHandler[]{},M7896));
c.Add(new JMethod(7897,"forge/game/phase/PhaseHandler","addExtraTurn","(Lforge/game/player/Player;)Lforge/game/phase/ExtraTurn;",17,6,5,new JHandler[]{},M7897));
c.Add(new JMethod(7898,"forge/game/phase/PhaseHandler","addExtraPhase","(Lforge/game/phase/PhaseType;Ljava/util/List;Lforge/game/phase/PhaseType;)Lforge/game/phase/ExtraPhase;",17,6,6,new JHandler[]{},M7898));
c.Add(new JMethod(7899,"forge/game/phase/PhaseHandler","hasExtraPhaseAfter","(Lforge/game/phase/PhaseType;Lforge/game/phase/PhaseType;)Z",17,4,2,new JHandler[]{},M7899));
c.Add(new JMethod(7900,"forge/game/phase/PhaseHandler","isFirstCombat","()Z",17,1,2,new JHandler[]{},M7900));
c.Add(new JMethod(7901,"forge/game/phase/PhaseHandler","getNumCombat","()I",17,1,1,new JHandler[]{},M7901));
c.Add(new JMethod(7902,"forge/game/phase/PhaseHandler","getNumUpkeep","()I",17,1,1,new JHandler[]{},M7902));
c.Add(new JMethod(7903,"forge/game/phase/PhaseHandler","isFirstUpkeep","()Z",17,1,2,new JHandler[]{},M7903));
c.Add(new JMethod(7904,"forge/game/phase/PhaseHandler","isFirstUpkeepThisGame","()Z",17,1,2,new JHandler[]{},M7904));
c.Add(new JMethod(7905,"forge/game/phase/PhaseHandler","getNumMain","()I",17,1,1,new JHandler[]{},M7905));
c.Add(new JMethod(7906,"forge/game/phase/PhaseHandler","beforeFirstPostCombatMainEnd","()Z",17,1,3,new JHandler[]{},M7906));
c.Add(new JMethod(7907,"forge/game/phase/PhaseHandler","skippedDeclareBlockers","()Z",17,1,1,new JHandler[]{},M7907));
}

private static void Add1(JClass c){
c.Add(new JMethod(7908,"forge/game/phase/PhaseHandler","getNumEndOfTurn","()I",17,1,1,new JHandler[]{},M7908));
c.Add(new JMethod(7909,"forge/game/phase/PhaseHandler","setupFirstTurn","(Lforge/game/player/Player;Ljava/lang/Runnable;)V",1,3,3,new JHandler[]{},M7909));
c.Add(new JMethod(7910,"forge/game/phase/PhaseHandler","startFirstTurn","(Lforge/game/player/Player;)V",1,2,3,new JHandler[]{},M7910));
c.Add(new JMethod(7911,"forge/game/phase/PhaseHandler","startFirstTurn","(Lforge/game/player/Player;Ljava/lang/Runnable;)V",1,3,3,new JHandler[]{},M7911));
c.Add(new JMethod(7912,"forge/game/phase/PhaseHandler","mainGameLoop","()V",1,1,2,new JHandler[]{},M7912));
c.Add(new JMethod(7913,"forge/game/phase/PhaseHandler","mainLoopStep","()V",1,11,6,new JHandler[]{},M7913));
c.Add(new JMethod(7914,"forge/game/phase/PhaseHandler","checkStateBasedEffects","()Z",2,2,4,new JHandler[]{},M7914));
c.Add(new JMethod(7915,"forge/game/phase/PhaseHandler","devAdvanceToPhase","(Lforge/game/phase/PhaseType;)Z",17,2,3,new JHandler[]{},M7915));
c.Add(new JMethod(7916,"forge/game/phase/PhaseHandler","devDeclareAttackers","()V",17,1,1,new JHandler[]{},M7916));
c.Add(new JMethod(7917,"forge/game/phase/PhaseHandler","devAdvanceThroughTurnEnd","(Lforge/game/phase/PhaseType;Ljava/lang/Runnable;)Z",17,6,3,new JHandler[]{},M7917));
c.Add(new JMethod(7918,"forge/game/phase/PhaseHandler","devAdvanceToPhase","(Lforge/game/phase/PhaseType;Ljava/lang/Runnable;)Z",17,4,3,new JHandler[]{},M7918));
c.Add(new JMethod(7919,"forge/game/phase/PhaseHandler","devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;ZI)V",17,5,6,new JHandler[]{},M7919));
c.Add(new JMethod(7920,"forge/game/phase/PhaseHandler","devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;)V",17,3,5,new JHandler[]{},M7920));
c.Add(new JMethod(7921,"forge/game/phase/PhaseHandler","devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;I)V",17,4,5,new JHandler[]{},M7921));
c.Add(new JMethod(7922,"forge/game/phase/PhaseHandler","devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;Z)V",17,4,5,new JHandler[]{},M7922));
c.Add(new JMethod(7923,"forge/game/phase/PhaseHandler","endCombatPhaseByEffect","()V",17,1,2,new JHandler[]{},M7923));
c.Add(new JMethod(7924,"forge/game/phase/PhaseHandler","endTurnByEffect","()V",17,1,6,new JHandler[]{},M7924));
c.Add(new JMethod(7925,"forge/game/phase/PhaseHandler","getPlanarDiceSpecialActionThisTurn","()I",1,1,1,new JHandler[]{},M7925));
c.Add(new JMethod(7926,"forge/game/phase/PhaseHandler","incPlanarDiceSpecialActionThisTurn","()V",1,1,3,new JHandler[]{},M7926));
c.Add(new JMethod(7927,"forge/game/phase/PhaseHandler","debugPrintState","(Z)Ljava/lang/String;",1,2,5,new JHandler[]{},M7927));
c.Add(new JMethod(7928,"forge/game/phase/PhaseHandler","onStackResolved","()V",1,1,2,new JHandler[]{},M7928));
c.Add(new JMethod(7929,"forge/game/phase/PhaseHandler","endCombat","()V",1,1,2,new JHandler[]{},M7929));
c.Add(new JMethod(7930,"forge/game/phase/PhaseHandler","setCombat","(Lforge/game/combat/Combat;)V",1,2,2,new JHandler[]{},M7930));
c.Add(new JMethod(7931,"forge/game/phase/PhaseHandler","getExtraTurnForPlayer","(Lforge/game/player/Player;)I",1,5,3,new JHandler[]{},M7931));
c.Add(new JMethod(7932,"forge/game/phase/PhaseHandler","handleMultiplayerEffects","()V",2,5,3,new JHandler[]{},M7932));
c.Add(new JMethod(7933,"forge/game/phase/PhaseHandler","lambda$declareAttackersTurnBasedAction$1","(Lforge/game/player/Player;)Z",4098,2,2,new JHandler[]{},M7933));
c.Add(new JMethod(7934,"forge/game/phase/PhaseHandler","lambda$declareAttackersTurnBasedAction$0","(Lforge/game/player/Player;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M7934));
}

internal static JStep M7865(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/time/StopWatch"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/time/StopWatch")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"org/apache/commons/lang3/time/StopWatch","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","sw","Lorg/apache/commons/lang3/time/StopWatch;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","turn","I",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"java/util/Stack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Stack")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Stack","<init>","()V","invokespecial",33);}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.ClassObject("forge/game/phase/PhaseType")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"com/google/common/collect/Maps","newEnumMap","(Ljava/lang/Class;)Ljava/util/EnumMap;","invokestatic",42);}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nUpkeepsThisTurn","I",value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nUpkeepsThisGame","I",value);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nCombatsThisTurn","I",value);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nMainsThisTurn","I",value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nEndOfTurnsThisTurn","I",value);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","planarDiceSpecialActionThisTurn","I",value);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(null));f.Pc=77;continue;}
case 77:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;",value);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(null));f.Pc=82;continue;}
case 82:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","playerPreviousTurn","Lforge/game/player/Player;",value);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(null));f.Pc=87;continue;}
case 87:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","pPlayerPriority","Lforge/game/player/Player;",value);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(null));f.Pc=92;continue;}
case 92:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","pFirstPriority","Lforge/game/player/Player;",value);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(null));f.Pc=97;continue;}
case 97:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;",value);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(JValue.I(0));f.Pc=102;continue;}
case 102:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","skipDamageSteps","Z",value);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","bRepeatCleanup","Z",value);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z",value);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;",value);f.Pc=120;continue;}
case 120:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7866(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7867(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?9:8;continue;}
case 8:{return JStep.ReturnVoid;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/Game","updatePhaseForView","()V","invokevirtual",21);}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7868(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","turn","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7869(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?22:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/player/Player","sharesTeamWith","(Lforge/game/player/Player;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7870(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getSharedTeam","()Lforge/game/player/PlayerCollection;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7871(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/GameRules","hasSharedTeamTurns","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?15:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/Game","getPlayersInTurnOrder","()Lforge/game/player/PlayerCollection;","invokevirtual",22);}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{return rt.DynamicCall(f,"forge/game/phase/PhaseHandler:7871:28:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",33);}
case 33:{return rt.Call(f,"forge/game/player/PlayerCollection","filter","(Ljava/util/function/Predicate;)Lforge/game/player/PlayerCollection;","invokevirtual",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7872(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference==null?44:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=21;continue;}
case 21:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?44:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?44:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",40);}
case 40:{f.Locals[1]=f.Pop();f.Pc=41;continue;}
case 41:{f.Pc=12;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7873(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7874(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?9:8;continue;}
case 8:{return JStep.ReturnVoid;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/Game","updatePlayerTurnForView","()V","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/phase/PhaseHandler","resetPriority","()V","invokevirtual",25);}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7875(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/phase/PhaseHandler","getNextTurn","()Lforge/game/player/Player;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/player/Player","sharesTeamWith","(Lforge/game/player/Player;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7876(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerPreviousTurn","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7877(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","pPlayerPriority","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7878(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","pFirstPriority","Lforge/game/player/Player;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","pPlayerPriority","Lforge/game/player/Player;",value);f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7879(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPriority","(Lforge/game/player/Player;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7880(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7881(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7882(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/Player","isPhasesReversed","()Z","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/zone/MagicStack","clearUndoStack","()V","invokevirtual",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","bRepeatCleanup","Z"));f.Pc=29;continue;}
case 29:{f.Pc=f.Pop().Int==0?40:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","bRepeatCleanup","Z",value);f.Pc=37;continue;}
case 37:{f.Pc=522;continue;}
case 40:{f.Push(JValue.R(null));f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",56);}
case 56:{f.Pc=f.Pop().Int==0?135:59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Stack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Stack","pop","()Ljava/lang/Object;","invokevirtual",78);}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/ExtraPhase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{f.Locals[4]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/phase/ExtraPhase","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",88);}
case 88:{f.Locals[5]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Stack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Stack","isEmpty","()Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?126:112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",125);}
case 125:{f.StackOp("pop");f.Pc=126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[5]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPhase","(Lforge/game/phase/PhaseType;)V","invokevirtual",132);}
case 132:{f.Pc=156;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=139;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/phase/PhaseType","isLast","(Lforge/game/phase/PhaseType;Z)Z","invokestatic",143);}
case 143:{f.Locals[3]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=149;continue;}
case 149:{f.Push(f.Locals[2]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/phase/PhaseType","getNext","(Lforge/game/phase/PhaseType;Z)Lforge/game/phase/PhaseType;","invokestatic",153);}
case 153:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPhase","(Lforge/game/phase/PhaseType;)V","invokevirtual",156);}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{f.Pc=f.Pop().Int==0?349:160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.StackOp("dup");f.Pc=162;continue;}
case 162:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","turn","I"));f.Pc=165;continue;}
case 165:{f.Push(JValue.I(1));f.Pc=166;continue;}
case 166:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=167;continue;}
case 167:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","turn","I",value);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",179);}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/Game","updateTurnForView","()V","invokevirtual",186);}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=190;continue;}
case 190:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventTurnBegan"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventTurnBegan")));f.Pc=193;continue;}
case 193:{f.StackOp("dup");f.Pc=194;continue;}
case 194:{f.Push(f.Locals[0]);f.Pc=195;continue;}
case 195:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",201);}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","turn","I"));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/event/GameEventTurnBegan","<init>","(Lforge/game/player/PlayerView;I)V","invokespecial",208);}
case 208:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",211);}
case 211:{f.Push(f.Locals[0]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",215);}
case 215:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",218);}
case 218:{f.Locals[5]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(f.Locals[5]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",227);}
case 227:{f.Pc=f.Pop().Int==0?349:230;continue;}
case 230:{f.Push(f.Locals[5]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",237);}
case 237:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=240;continue;}
case 240:{f.Locals[6]=f.Pop();f.Pc=242;continue;}
case 242:{f.Push(f.Locals[6]);f.Pc=244;continue;}
case 244:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=247;continue;}
case 247:{f.Push(JValue.I(0));f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;Z)Lforge/game/card/CardCollectionView;","invokevirtual",251);}
case 251:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",256);}
case 256:{f.Locals[7]=f.Pop();f.Pc=258;continue;}
case 258:{f.Push(f.Locals[7]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",265);}
case 265:{f.Pc=f.Pop().Int==0?305:268;continue;}
case 268:{f.Push(f.Locals[7]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",275);}
case 275:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=278;continue;}
case 278:{f.Locals[8]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[6]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/player/Player","getTurn","()I","invokevirtual",285);}
case 285:{f.Pc=f.Pop().Int>0?296:288;continue;}
case 288:{f.Push(f.Locals[8]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/card/Card","isStartsGameInPlay","()Z","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int!=0?302:296;continue;}
case 296:{f.Push(f.Locals[8]);f.Pc=298;continue;}
case 298:{f.Push(JValue.I(0));f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/card/Card","setSickness","(Z)V","invokevirtual",302);}
case 302:{f.Pc=258;continue;}
case 305:{f.Push(f.Locals[6]);f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/player/Player","incrementTurn","()V","invokevirtual",310);}
case 310:{f.Push(f.Locals[0]);f.Pc=311;continue;}
case 311:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/player/Player","isExtraTurn","()Z","invokevirtual",317);}
case 317:{f.Pc=f.Pop().Int==0?325:320;continue;}
case 320:{f.Push(f.Locals[6]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/player/Player","incrementExtraTurnsPlayed","()V","invokevirtual",325);}
case 325:{f.Push(f.Locals[6]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/player/Player","getLandsInPlay","()Lforge/game/card/CardCollection;","invokevirtual",330);}
case 330:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","UNTAPPED","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","UNTAPPED","Ljava/util/function/Predicate;"));f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",336);}
case 336:{f.Locals[7]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[6]);f.Pc=340;continue;}
case 340:{f.Push(f.Locals[7]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/player/Player","setNumPowerSurgeLands","(I)I","invokevirtual",345);}
case 345:{f.StackOp("pop");f.Pc=346;continue;}
case 346:{f.Pc=220;continue;}
case 349:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=352;continue;}
case 352:{f.Locals[5]=f.Pop();f.Pc=354;continue;}
case 354:{f.Push(f.Locals[0]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",358);}
case 358:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",361);}
case 361:{f.Locals[6]=f.Pop();f.Pc=363;continue;}
case 363:{f.Push(f.Locals[6]);f.Pc=365;continue;}
case 365:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",370);}
case 370:{f.Pc=f.Pop().Int==0?438:373;continue;}
case 373:{f.Push(f.Locals[6]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",380);}
case 380:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=383;continue;}
case 383:{f.Locals[7]=f.Pop();f.Pc=385;continue;}
case 385:{f.Push(f.Locals[7]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",390);}
case 390:{f.Locals[8]=f.Pop();f.Pc=392;continue;}
case 392:{f.Push(f.Locals[8]);f.Pc=394;continue;}
case 394:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Phase","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Phase","Lforge/game/ability/AbilityKey;"));f.Pc=397;continue;}
case 397:{f.Push(f.Locals[0]);f.Pc=398;continue;}
case 398:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=401;continue;}
case 401:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",406);}
case 406:{f.StackOp("pop");f.Pc=407;continue;}
case 407:{f.Push(f.Locals[0]);f.Pc=408;continue;}
case 408:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",414);}
case 414:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","BeginPhase","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","BeginPhase","Lforge/game/replacement/ReplacementType;"));f.Pc=417;continue;}
case 417:{f.Push(f.Locals[8]);f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",422);}
case 422:{f.Locals[5]=f.Pop();f.Pc=424;continue;}
case 424:{f.Push(f.Locals[5]);f.Pc=426;continue;}
case 426:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=429;continue;}
case 429:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?435:432;continue;}
case 432:{f.Pc=438;continue;}
case 435:{f.Pc=363;continue;}
case 438:{f.Push(f.Locals[5]);f.Pc=440;continue;}
case 440:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=443;continue;}
case 443:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?468:446;continue;}
case 446:{f.Push(f.Locals[0]);f.Pc=447;continue;}
case 447:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=450;continue;}
case 450:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;"));f.Pc=453;continue;}
case 453:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?463:456;continue;}
case 456:{f.Push(f.Locals[0]);f.Pc=457;continue;}
case 457:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"));f.Pc=460;continue;}
case 460:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPhase","(Lforge/game/phase/PhaseType;)V","invokevirtual",463);}
case 463:{f.Push(f.Locals[0]);f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/game/phase/PhaseHandler","advanceToNextPhase","()V","invokevirtual",467);}
case 467:{return JStep.ReturnVoid;}
case 468:{f.Push(f.Locals[4]);f.Pc=470;continue;}
case 470:{f.Pc=f.Pop().Reference==null?522:473;continue;}
case 473:{f.Push(f.Locals[4]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/phase/ExtraPhase","getDelayedTriggers","()Ljava/util/List;","invokevirtual",478);}
case 478:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",483);}
case 483:{f.Locals[6]=f.Pop();f.Pc=485;continue;}
case 485:{f.Push(f.Locals[6]);f.Pc=487;continue;}
case 487:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",492);}
case 492:{f.Pc=f.Pop().Int==0?522:495;continue;}
case 495:{f.Push(f.Locals[6]);f.Pc=497;continue;}
case 497:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",502);}
case 502:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=505;continue;}
case 505:{f.Locals[7]=f.Pop();f.Pc=507;continue;}
case 507:{f.Push(f.Locals[0]);f.Pc=508;continue;}
case 508:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=511;continue;}
case 511:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",514);}
case 514:{f.Push(f.Locals[7]);f.Pc=516;continue;}
case 516:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerThisTurnDelayedTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",519);}
case 519:{f.Pc=485;continue;}
case 522:{f.Push(f.Locals[1]);f.Pc=523;continue;}
case 523:{f.Push(f.Locals[0]);f.Pc=524;continue;}
case 524:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=527;continue;}
case 527:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?536:530;continue;}
case 530:{f.Push(JValue.R(rt.String("Repeat")));f.Pc=533;continue;}
case 533:{f.Pc=557;continue;}
case 536:{f.Push(f.Locals[0]);f.Pc=537;continue;}
case 537:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=540;continue;}
case 540:{f.Push(f.Locals[1]);f.Pc=541;continue;}
case 541:{f.Push(f.Locals[2]);f.Pc=542;continue;}
case 542:{return rt.Call(f,"forge/game/phase/PhaseType","getNext","(Lforge/game/phase/PhaseType;Z)Lforge/game/phase/PhaseType;","invokestatic",545);}
case 545:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?554:548;continue;}
case 548:{f.Push(JValue.R(rt.String("")));f.Pc=551;continue;}
case 551:{f.Pc=557;continue;}
case 554:{f.Push(JValue.R(rt.String("Additional")));f.Pc=557;continue;}
case 557:{f.Locals[4]=f.Pop();f.Pc=559;continue;}
case 559:{f.Push(f.Locals[0]);f.Pc=560;continue;}
case 560:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=563;continue;}
case 563:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventTurnPhase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventTurnPhase")));f.Pc=566;continue;}
case 566:{f.StackOp("dup");f.Pc=567;continue;}
case 567:{f.Push(f.Locals[0]);f.Pc=568;continue;}
case 568:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=571;continue;}
case 571:{f.Push(f.Locals[0]);f.Pc=572;continue;}
case 572:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=575;continue;}
case 575:{f.Push(f.Locals[4]);f.Pc=577;continue;}
case 577:{return rt.Call(f,"forge/game/event/GameEventTurnPhase","<init>","(Lforge/game/player/Player;Lforge/game/phase/PhaseType;Ljava/lang/String;)V","invokespecial",580);}
case 580:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",583);}
case 583:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7883(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",7);}
case 7:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8;continue;}
case 8:{switch(f.Pop().Int){case 1:f.Pc=48;break;case 2:f.Pc=89;break;case 3:f.Pc=89;break;case 4:f.Pc=110;break;case 5:f.Pc=139;break;case 6:f.Pc=139;break;default:f.Pc=144;break;}continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","turn","I"));f.Pc=52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?87:56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",63);}
case 63:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",66);}
case 66:{f.Push(JValue.I(2));f.Pc=67;continue;}
case 67:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?83:70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",77);}
case 77:{return rt.Call(f,"forge/game/GameRules","hasSharedTeamTurns","()Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?87:83;continue;}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{f.Pc=88;continue;}
case 87:{f.Push(JValue.I(0));f.Pc=88;continue;}
case 88:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",93);}
case 93:{return rt.DynamicCall(f,"forge/game/phase/PhaseHandler:7883:93:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",98);}
case 98:{return rt.Call(f,"forge/game/player/PlayerCollection","allMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Int!=0?108:104;continue;}
case 104:{f.Push(JValue.I(1));f.Pc=105;continue;}
case 105:{f.Pc=109;continue;}
case 108:{f.Push(JValue.I(0));f.Pc=109;continue;}
case 109:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/phase/PhaseHandler","inCombat","()Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int==0?131:118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",125);}
case 125:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?135:131;continue;}
case 131:{f.Push(JValue.I(1));f.Pc=132;continue;}
case 132:{f.Pc=136;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","skipDamageSteps","Z",value);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","skipDamageSteps","Z"));f.Pc=143;continue;}
case 143:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 144:{f.Push(JValue.I(0));f.Pc=145;continue;}
case 145:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7884(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/player/Player","getMaxHandSize","()I","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/player/Player","isUnlimitedHandSize","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int!=0?32:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?32:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Pc=f.Pop().Int!=0?36:32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{f.Pc=39;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=39;continue;}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{f.Pc=f.Pop().Int>0?47:46;continue;}
case 46:{return JStep.ReturnVoid;}
case 47:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=50;continue;}
case 50:{f.StackOp("dup");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",58);}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",65);}
case 65:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",68);}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",73);}
case 73:{f.Locals[6]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[6]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",82);}
case 82:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=85;continue;}
case 85:{f.StackOp("dup");f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",89);}
case 89:{f.Locals[7]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/player/Player","getDiscardedThisTurn","()Ljava/util/List;","invokevirtual",95);}
case 95:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",98);}
case 98:{f.Locals[8]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",104);}
case 104:{f.Push(f.Locals[4]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsToDiscardToMaximumHandSize","(I)Lforge/game/card/CardCollectionView;","invokevirtual",109);}
case 109:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",114);}
case 114:{f.Locals[9]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[9]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",123);}
case 123:{f.Pc=f.Pop().Int==0?166:126;continue;}
case 126:{f.Push(f.Locals[9]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{f.Locals[10]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[10]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(null));f.Pc=142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{f.Push(f.Locals[6]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/player/Player","discard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/Card;","invokevirtual",148);}
case 148:{f.Locals[11]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[11]);f.Pc=152;continue;}
case 152:{f.Pc=f.Pop().Reference==null?163:155;continue;}
case 155:{f.Push(f.Locals[7]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[11]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",162);}
case 162:{f.StackOp("pop");f.Pc=163;continue;}
case 163:{f.Pc=116;continue;}
case 166:{f.Push(f.Locals[5]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=172;continue;}
case 172:{f.Push(JValue.R(null));f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",176);}
case 176:{f.Push(f.Locals[7]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",181);}
case 181:{f.Pc=f.Pop().Int!=0?244:184;continue;}
case 184:{f.Push(f.Locals[1]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",188);}
case 188:{f.Locals[9]=f.Pop();f.Pc=190;continue;}
case 190:{f.Push(f.Locals[9]);f.Pc=192;continue;}
case 192:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=195;continue;}
case 195:{f.Push(f.Locals[7]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",202);}
case 202:{f.StackOp("pop");f.Pc=203;continue;}
case 203:{f.Push(f.Locals[9]);f.Pc=205;continue;}
case 205:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=208;continue;}
case 208:{f.Push(JValue.R(null));f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",214);}
case 214:{f.StackOp("pop");f.Pc=215;continue;}
case 215:{f.Push(f.Locals[9]);f.Pc=217;continue;}
case 217:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DiscardedBefore","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DiscardedBefore","Lforge/game/ability/AbilityKey;"));f.Pc=220;continue;}
case 220:{f.Push(f.Locals[8]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",227);}
case 227:{f.StackOp("pop");f.Pc=228;continue;}
case 228:{f.Push(f.Locals[0]);f.Pc=229;continue;}
case 229:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",235);}
case 235:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DiscardedAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DiscardedAll","Lforge/game/trigger/TriggerType;"));f.Pc=238;continue;}
case 238:{f.Push(f.Locals[9]);f.Pc=240;continue;}
case 240:{f.Push(JValue.I(0));f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",244);}
case 244:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7885(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/trigger/TriggerHandler","resetActiveTriggers","()V","invokevirtual",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/Game","getUndoManager","()Lforge/game/undo/UndoManager;","invokevirtual",19);}
case 19:{f.Push(JValue.R(rt.String("Phase Begin.")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/undo/UndoManager","barrier","(Ljava/lang/String;)V","invokevirtual",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/phase/PhaseHandler","isSkippingPhase","(Lforge/game/phase/PhaseType;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?46:36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{f.Locals[1]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z",value);f.Pc=43;continue;}
case 43:{f.Pc=1257;continue;}
case 46:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",56);}
case 56:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=57;continue;}
case 57:{switch(f.Pop().Int){case 1:f.Pc=311;break;case 2:f.Pc=590;break;case 3:f.Pc=661;break;case 4:f.Pc=704;break;case 5:f.Pc=740;break;case 6:f.Pc=786;break;case 7:f.Pc=124;break;case 8:f.Pc=183;break;case 9:f.Pc=386;break;case 10:f.Pc=832;break;case 11:f.Pc=893;break;case 12:f.Pc=906;break;case 13:f.Pc=980;break;default:f.Pc=1257;break;}continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(JValue.I(0));f.Pc=126;continue;}
case 126:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z",value);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",133);}
case 133:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",136);}
case 136:{f.Locals[2]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",143);}
case 143:{f.Pc=f.Pop().Int==0?170:146;continue;}
case 146:{f.Push(f.Locals[2]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",152);}
case 152:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=155;continue;}
case 155:{f.Locals[3]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[0]);f.Pc=157;continue;}
case 157:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/Game","getUntap","()Lforge/game/phase/Untap;","invokevirtual",163);}
case 163:{f.Push(f.Locals[3]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/phase/Untap","executeUntil","(Lforge/game/player/Player;)V","invokevirtual",167);}
case 167:{f.Pc=137;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/Game","getUntap","()Lforge/game/phase/Untap;","invokevirtual",177);}
case 177:{return rt.Call(f,"forge/game/phase/Untap","executeAt","()V","invokevirtual",180);}
case 180:{f.Pc=1257;continue;}
case 183:{f.Push(f.Locals[0]);f.Pc=184;continue;}
case 184:{f.StackOp("dup");f.Pc=185;continue;}
case 185:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nUpkeepsThisTurn","I"));f.Pc=188;continue;}
case 188:{f.Push(JValue.I(1));f.Pc=189;continue;}
case 189:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=190;continue;}
case 190:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nUpkeepsThisTurn","I",value);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[0]);f.Pc=194;continue;}
case 194:{f.StackOp("dup");f.Pc=195;continue;}
case 195:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nUpkeepsThisGame","I"));f.Pc=198;continue;}
case 198:{f.Push(JValue.I(1));f.Pc=199;continue;}
case 199:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=200;continue;}
case 200:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nUpkeepsThisGame","I",value);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[0]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",207);}
case 207:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",210);}
case 210:{f.Locals[2]=f.Pop();f.Pc=211;continue;}
case 211:{f.Push(f.Locals[2]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",217);}
case 217:{f.Pc=f.Pop().Int==0?244:220;continue;}
case 220:{f.Push(f.Locals[2]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",226);}
case 226:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=229;continue;}
case 229:{f.Locals[3]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[0]);f.Pc=231;continue;}
case 231:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/Game","getUpkeep","()Lforge/game/phase/Phase;","invokevirtual",237);}
case 237:{f.Push(f.Locals[3]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/phase/Phase","executeUntil","(Lforge/game/player/Player;)V","invokevirtual",241);}
case 241:{f.Pc=211;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/Game","getUpkeep","()Lforge/game/phase/Phase;","invokevirtual",251);}
case 251:{return rt.Call(f,"forge/game/phase/Phase","executeAt","()V","invokevirtual",254);}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",258);}
case 258:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",261);}
case 261:{f.Locals[2]=f.Pop();f.Pc=262;continue;}
case 262:{f.Push(f.Locals[2]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",268);}
case 268:{f.Pc=f.Pop().Int==0?308:271;continue;}
case 271:{f.Push(f.Locals[2]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",277);}
case 277:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=280;continue;}
case 280:{f.Locals[3]=f.Pop();f.Pc=281;continue;}
case 281:{f.Push(f.Locals[3]);f.Pc=282;continue;}
case 282:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",288);}
case 288:{return rt.DynamicCall(f,"forge/game/phase/PhaseHandler:7885:288:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",293);}
case 293:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",298);}
case 298:{f.Pc=f.Pop().Int==0?305:301;continue;}
case 301:{f.Push(f.Locals[3]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/player/Player","advanceCrankCounter","()V","invokevirtual",305);}
case 305:{f.Pc=262;continue;}
case 308:{f.Pc=1257;continue;}
case 311:{f.Push(f.Locals[0]);f.Pc=312;continue;}
case 312:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",318);}
case 318:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",321);}
case 321:{f.Locals[2]=f.Pop();f.Pc=322;continue;}
case 322:{f.Push(f.Locals[2]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",328);}
case 328:{f.Pc=f.Pop().Int==0?348:331;continue;}
case 331:{f.Push(f.Locals[2]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",337);}
case 337:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=340;continue;}
case 340:{f.Locals[3]=f.Pop();f.Pc=341;continue;}
case 341:{f.Push(f.Locals[3]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/player/Player","resetNumDrawnThisDrawStep","()V","invokevirtual",345);}
case 345:{f.Pc=322;continue;}
case 348:{f.Push(f.Locals[0]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",352);}
case 352:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",355);}
case 355:{f.Locals[2]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(f.Locals[2]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",362);}
case 362:{f.Pc=f.Pop().Int==0?383:365;continue;}
case 365:{f.Push(f.Locals[2]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",371);}
case 371:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=374;continue;}
case 374:{f.Locals[3]=f.Pop();f.Pc=375;continue;}
case 375:{f.Push(f.Locals[3]);f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/game/player/Player","drawCard","()Lforge/game/card/CardCollectionView;","invokevirtual",379);}
case 379:{f.StackOp("pop");f.Pc=380;continue;}
case 380:{f.Pc=356;continue;}
case 383:{f.Pc=1257;continue;}
case 386:{f.Push(f.Locals[0]);f.Pc=387;continue;}
case 387:{f.StackOp("dup");f.Pc=388;continue;}
case 388:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nMainsThisTurn","I"));f.Pc=391;continue;}
case 391:{f.Push(JValue.I(1));f.Pc=392;continue;}
case 392:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=393;continue;}
case 393:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nMainsThisTurn","I",value);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[0]);f.Pc=397;continue;}
case 397:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=400;continue;}
case 400:{return rt.Call(f,"forge/game/player/Player","isArchenemy","()Z","invokevirtual",403);}
case 403:{f.Pc=f.Pop().Int==0?414:406;continue;}
case 406:{f.Push(f.Locals[0]);f.Pc=407;continue;}
case 407:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=410;continue;}
case 410:{f.Push(JValue.R(null));f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/player/Player","setSchemeInMotion","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",414);}
case 414:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=417;continue;}
case 417:{f.StackOp("dup");f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",421);}
case 421:{f.Locals[2]=f.Pop();f.Pc=422;continue;}
case 422:{f.Push(f.Locals[0]);f.Pc=423;continue;}
case 423:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",426);}
case 426:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",429);}
case 429:{f.Locals[3]=f.Pop();f.Pc=430;continue;}
case 430:{f.Push(f.Locals[3]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",436);}
case 436:{f.Pc=f.Pop().Int==0?521:439;continue;}
case 439:{f.Push(f.Locals[3]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",445);}
case 445:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=448;continue;}
case 448:{f.Locals[4]=f.Pop();f.Pc=450;continue;}
case 450:{f.Push(f.Locals[4]);f.Pc=452;continue;}
case 452:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",458);}
case 458:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",463);}
case 463:{f.Locals[5]=f.Pop();f.Pc=465;continue;}
case 465:{f.Push(f.Locals[5]);f.Pc=467;continue;}
case 467:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",472);}
case 472:{f.Pc=f.Pop().Int==0?518:475;continue;}
case 475:{f.Push(f.Locals[5]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",482);}
case 482:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=485;continue;}
case 485:{f.Locals[6]=f.Pop();f.Pc=487;continue;}
case 487:{f.Push(f.Locals[6]);f.Pc=489;continue;}
case 489:{return rt.Call(f,"forge/game/card/Card","isSaga","()Z","invokevirtual",492);}
case 492:{f.Pc=f.Pop().Int==0?515:495;continue;}
case 495:{f.Push(f.Locals[6]);f.Pc=497;continue;}
case 497:{return rt.Call(f,"forge/game/card/Card","hasChapter","()Z","invokevirtual",500);}
case 500:{f.Pc=f.Pop().Int==0?515:503;continue;}
case 503:{f.Push(f.Locals[6]);f.Pc=505;continue;}
case 505:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LORE","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LORE","Lforge/game/card/CounterEnumType;"));f.Pc=508;continue;}
case 508:{f.Push(JValue.I(1));f.Pc=509;continue;}
case 509:{f.Push(f.Locals[4]);f.Pc=511;continue;}
case 511:{f.Push(f.Locals[2]);f.Pc=512;continue;}
case 512:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",515);}
case 515:{f.Pc=465;continue;}
case 518:{f.Pc=430;continue;}
case 521:{f.Push(f.Locals[2]);f.Pc=522;continue;}
case 522:{f.Push(f.Locals[0]);f.Pc=523;continue;}
case 523:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=526;continue;}
case 526:{f.Push(JValue.R(null));f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",530);}
case 530:{f.Push(f.Locals[0]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",534);}
case 534:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",537);}
case 537:{f.Locals[3]=f.Pop();f.Pc=538;continue;}
case 538:{f.Push(f.Locals[3]);f.Pc=539;continue;}
case 539:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",544);}
case 544:{f.Pc=f.Pop().Int==0?587:547;continue;}
case 547:{f.Push(f.Locals[3]);f.Pc=548;continue;}
case 548:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",553);}
case 553:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=556;continue;}
case 556:{f.Locals[4]=f.Pop();f.Pc=558;continue;}
case 558:{f.Push(f.Locals[4]);f.Pc=560;continue;}
case 560:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=563;continue;}
case 563:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",566);}
case 566:{return rt.DynamicCall(f,"forge/game/phase/PhaseHandler:7885:566:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",571);}
case 571:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",576);}
case 576:{f.Pc=f.Pop().Int==0?584:579;continue;}
case 579:{f.Push(f.Locals[4]);f.Pc=581;continue;}
case 581:{return rt.Call(f,"forge/game/player/Player","rollToVisitAttractions","()V","invokevirtual",584);}
case 584:{f.Pc=538;continue;}
case 587:{f.Pc=1257;continue;}
case 590:{f.Push(f.Locals[0]);f.Pc=591;continue;}
case 591:{f.StackOp("dup");f.Pc=592;continue;}
case 592:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nCombatsThisTurn","I"));f.Pc=595;continue;}
case 595:{f.Push(JValue.I(1));f.Pc=596;continue;}
case 596:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=597;continue;}
case 597:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nCombatsThisTurn","I",value);f.Pc=600;continue;}
case 600:{f.Push(f.Locals[0]);f.Pc=601;continue;}
case 601:{if(!rt.EnsureInitialized(f,"forge/game/combat/Combat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/Combat")));f.Pc=604;continue;}
case 604:{f.StackOp("dup");f.Pc=605;continue;}
case 605:{f.Push(f.Locals[0]);f.Pc=606;continue;}
case 606:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=609;continue;}
case 609:{return rt.Call(f,"forge/game/combat/Combat","<init>","(Lforge/game/player/Player;)V","invokespecial",612);}
case 612:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;",value);f.Pc=615;continue;}
case 615:{f.Push(f.Locals[0]);f.Pc=616;continue;}
case 616:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",619);}
case 619:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",622);}
case 622:{f.Locals[3]=f.Pop();f.Pc=623;continue;}
case 623:{f.Push(f.Locals[3]);f.Pc=624;continue;}
case 624:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",629);}
case 629:{f.Pc=f.Pop().Int==0?658:632;continue;}
case 632:{f.Push(f.Locals[3]);f.Pc=633;continue;}
case 633:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",638);}
case 638:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=641;continue;}
case 641:{f.Locals[4]=f.Pop();f.Pc=643;continue;}
case 643:{f.Push(f.Locals[0]);f.Pc=644;continue;}
case 644:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=647;continue;}
case 647:{return rt.Call(f,"forge/game/Game","getBeginOfCombat","()Lforge/game/phase/Phase;","invokevirtual",650);}
case 650:{f.Push(f.Locals[4]);f.Pc=652;continue;}
case 652:{return rt.Call(f,"forge/game/phase/Phase","executeUntil","(Lforge/game/player/Player;)V","invokevirtual",655);}
case 655:{f.Pc=623;continue;}
case 658:{f.Pc=1257;continue;}
case 661:{f.Push(f.Locals[0]);f.Pc=662;continue;}
case 662:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=665;continue;}
case 665:{return rt.Call(f,"forge/game/combat/Combat","initConstraints","()V","invokevirtual",668);}
case 668:{f.Push(f.Locals[0]);f.Pc=669;continue;}
case 669:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=672;continue;}
case 672:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",675);}
case 675:{f.Push(JValue.R(null));f.Pc=676;continue;}
case 676:{return rt.Call(f,"forge/game/zone/MagicStack","freezeStack","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",679);}
case 679:{f.Push(f.Locals[0]);f.Pc=680;continue;}
case 680:{return rt.Call(f,"forge/game/phase/PhaseHandler","declareAttackersTurnBasedAction","()V","invokevirtual",683);}
case 683:{f.Push(f.Locals[0]);f.Pc=684;continue;}
case 684:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=687;continue;}
case 687:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",690);}
case 690:{return rt.Call(f,"forge/game/zone/MagicStack","unfreezeStack","()V","invokevirtual",693);}
case 693:{f.Push(f.Locals[0]);f.Pc=694;continue;}
case 694:{f.Push(f.Locals[0]);f.Pc=695;continue;}
case 695:{return rt.Call(f,"forge/game/phase/PhaseHandler","inCombat","()Z","invokevirtual",698);}
case 698:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z",value);f.Pc=701;continue;}
case 701:{f.Pc=1257;continue;}
case 704:{f.Push(f.Locals[0]);f.Pc=705;continue;}
case 705:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=708;continue;}
case 708:{return rt.Call(f,"forge/game/combat/Combat","removeAbsentCombatants","()Z","invokevirtual",711);}
case 711:{f.StackOp("pop");f.Pc=712;continue;}
case 712:{f.Push(f.Locals[0]);f.Pc=713;continue;}
case 713:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=716;continue;}
case 716:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",719);}
case 719:{f.Push(JValue.R(null));f.Pc=720;continue;}
case 720:{return rt.Call(f,"forge/game/zone/MagicStack","freezeStack","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",723);}
case 723:{f.Push(f.Locals[0]);f.Pc=724;continue;}
case 724:{return rt.Call(f,"forge/game/phase/PhaseHandler","declareBlockersTurnBasedAction","()V","invokevirtual",727);}
case 727:{f.Push(f.Locals[0]);f.Pc=728;continue;}
case 728:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=731;continue;}
case 731:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",734);}
case 734:{return rt.Call(f,"forge/game/zone/MagicStack","unfreezeStack","()V","invokevirtual",737);}
case 737:{f.Pc=1257;continue;}
case 740:{f.Push(f.Locals[0]);f.Pc=741;continue;}
case 741:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=744;continue;}
case 744:{return rt.Call(f,"forge/game/combat/Combat","removeAbsentCombatants","()Z","invokevirtual",747);}
case 747:{f.Pc=f.Pop().Int==0?757:750;continue;}
case 750:{f.Push(f.Locals[0]);f.Pc=751;continue;}
case 751:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=754;continue;}
case 754:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",757);}
case 757:{f.Push(f.Locals[0]);f.Pc=758;continue;}
case 758:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=761;continue;}
case 761:{f.Push(JValue.I(1));f.Pc=762;continue;}
case 762:{return rt.Call(f,"forge/game/combat/Combat","assignCombatDamage","(Z)Z","invokevirtual",765);}
case 765:{f.Pc=f.Pop().Int!=0?776:768;continue;}
case 768:{f.Push(f.Locals[0]);f.Pc=769;continue;}
case 769:{f.Push(JValue.I(0));f.Pc=770;continue;}
case 770:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z",value);f.Pc=773;continue;}
case 773:{f.Pc=1257;continue;}
case 776:{f.Push(f.Locals[0]);f.Pc=777;continue;}
case 777:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=780;continue;}
case 780:{return rt.Call(f,"forge/game/combat/Combat","dealAssignedDamage","()V","invokevirtual",783);}
case 783:{f.Pc=1257;continue;}
case 786:{f.Push(f.Locals[0]);f.Pc=787;continue;}
case 787:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=790;continue;}
case 790:{return rt.Call(f,"forge/game/combat/Combat","removeAbsentCombatants","()Z","invokevirtual",793);}
case 793:{f.Pc=f.Pop().Int==0?803:796;continue;}
case 796:{f.Push(f.Locals[0]);f.Pc=797;continue;}
case 797:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=800;continue;}
case 800:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",803);}
case 803:{f.Push(f.Locals[0]);f.Pc=804;continue;}
case 804:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=807;continue;}
case 807:{f.Push(JValue.I(0));f.Pc=808;continue;}
case 808:{return rt.Call(f,"forge/game/combat/Combat","assignCombatDamage","(Z)Z","invokevirtual",811);}
case 811:{f.Pc=f.Pop().Int!=0?822:814;continue;}
case 814:{f.Push(f.Locals[0]);f.Pc=815;continue;}
case 815:{f.Push(JValue.I(0));f.Pc=816;continue;}
case 816:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z",value);f.Pc=819;continue;}
case 819:{f.Pc=1257;continue;}
case 822:{f.Push(f.Locals[0]);f.Pc=823;continue;}
case 823:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=826;continue;}
case 826:{return rt.Call(f,"forge/game/combat/Combat","dealAssignedDamage","()V","invokevirtual",829);}
case 829:{f.Pc=1257;continue;}
case 832:{f.Push(f.Locals[0]);f.Pc=833;continue;}
case 833:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=836;continue;}
case 836:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=839;continue;}
case 839:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",842);}
case 842:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",847);}
case 847:{f.Locals[3]=f.Pop();f.Pc=848;continue;}
case 848:{f.Push(f.Locals[3]);f.Pc=849;continue;}
case 849:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",854);}
case 854:{f.Pc=f.Pop().Int==0?880:857;continue;}
case 857:{f.Push(f.Locals[3]);f.Pc=858;continue;}
case 858:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",863);}
case 863:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=866;continue;}
case 866:{f.Locals[4]=f.Pop();f.Pc=868;continue;}
case 868:{f.Push(f.Locals[4]);f.Pc=870;continue;}
case 870:{f.Push(f.Locals[0]);f.Pc=871;continue;}
case 871:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=874;continue;}
case 874:{return rt.Call(f,"forge/game/card/Card","onEndOfCombat","(Lforge/game/player/Player;)V","invokevirtual",877);}
case 877:{f.Pc=848;continue;}
case 880:{f.Push(f.Locals[0]);f.Pc=881;continue;}
case 881:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=884;continue;}
case 884:{return rt.Call(f,"forge/game/Game","getEndOfCombat","()Lforge/game/phase/Phase;","invokevirtual",887);}
case 887:{return rt.Call(f,"forge/game/phase/Phase","executeAt","()V","invokevirtual",890);}
case 890:{f.Pc=1257;continue;}
case 893:{f.Push(f.Locals[0]);f.Pc=894;continue;}
case 894:{f.StackOp("dup");f.Pc=895;continue;}
case 895:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nMainsThisTurn","I"));f.Pc=898;continue;}
case 898:{f.Push(JValue.I(1));f.Pc=899;continue;}
case 899:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=900;continue;}
case 900:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nMainsThisTurn","I",value);f.Pc=903;continue;}
case 903:{f.Pc=1257;continue;}
case 906:{f.Push(f.Locals[0]);f.Pc=907;continue;}
case 907:{f.StackOp("dup");f.Pc=908;continue;}
case 908:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nEndOfTurnsThisTurn","I"));f.Pc=911;continue;}
case 911:{f.Push(JValue.I(1));f.Pc=912;continue;}
case 912:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=913;continue;}
case 913:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nEndOfTurnsThisTurn","I",value);f.Pc=916;continue;}
case 916:{f.Push(f.Locals[0]);f.Pc=917;continue;}
case 917:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",920);}
case 920:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",923);}
case 923:{f.Locals[3]=f.Pop();f.Pc=924;continue;}
case 924:{f.Push(f.Locals[3]);f.Pc=925;continue;}
case 925:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",930);}
case 930:{f.Pc=f.Pop().Int==0?967:933;continue;}
case 933:{f.Push(f.Locals[3]);f.Pc=934;continue;}
case 934:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",939);}
case 939:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=942;continue;}
case 942:{f.Locals[4]=f.Pop();f.Pc=944;continue;}
case 944:{f.Push(f.Locals[0]);f.Pc=945;continue;}
case 945:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=948;continue;}
case 948:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",951);}
case 951:{f.Push(f.Locals[4]);f.Pc=953;continue;}
case 953:{return rt.Call(f,"forge/game/phase/Phase","executeUntil","(Lforge/game/player/Player;)V","invokevirtual",956);}
case 956:{f.Push(f.Locals[4]);f.Pc=958;continue;}
case 958:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",961);}
case 961:{return rt.Call(f,"forge/game/player/PlayerController","resetAtEndOfTurn","()V","invokevirtual",964);}
case 964:{f.Pc=924;continue;}
case 967:{f.Push(f.Locals[0]);f.Pc=968;continue;}
case 968:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=971;continue;}
case 971:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",974);}
case 974:{return rt.Call(f,"forge/game/phase/Phase","executeAt","()V","invokevirtual",977);}
case 977:{f.Pc=1257;continue;}
case 980:{f.Push(f.Locals[0]);f.Pc=981;continue;}
case 981:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",984);}
case 984:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",987);}
case 987:{f.Locals[3]=f.Pop();f.Pc=988;continue;}
case 988:{f.Push(f.Locals[3]);f.Pc=989;continue;}
case 989:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",994);}
case 994:{f.Pc=f.Pop().Int==0?1017:997;continue;}
case 997:{f.Push(f.Locals[3]);f.Pc=998;continue;}
case 998:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1003);}
case 1003:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1006;continue;}
case 1006:{f.Locals[4]=f.Pop();f.Pc=1008;continue;}
case 1008:{f.Push(f.Locals[0]);f.Pc=1009;continue;}
case 1009:{f.Push(f.Locals[4]);f.Pc=1011;continue;}
case 1011:{return rt.Call(f,"forge/game/phase/PhaseHandler","discardToHandSize","(Lforge/game/player/Player;)V","invokevirtual",1014);}
case 1014:{f.Pc=988;continue;}
case 1017:{f.Push(f.Locals[0]);f.Pc=1018;continue;}
case 1018:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1021;continue;}
case 1021:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1024;continue;}
case 1024:{return rt.Call(f,"forge/game/Game","getCardsIncludePhasingIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1027);}
case 1027:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1032);}
case 1032:{f.Locals[3]=f.Pop();f.Pc=1033;continue;}
case 1033:{f.Push(f.Locals[3]);f.Pc=1034;continue;}
case 1034:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1039);}
case 1039:{f.Pc=f.Pop().Int==0?1076:1042;continue;}
case 1042:{f.Push(f.Locals[3]);f.Pc=1043;continue;}
case 1043:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1048);}
case 1048:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1051;continue;}
case 1051:{f.Locals[4]=f.Pop();f.Pc=1053;continue;}
case 1053:{f.Push(f.Locals[4]);f.Pc=1055;continue;}
case 1055:{return rt.Call(f,"forge/game/staticability/StaticAbilityNoCleanupDamage","damageNotRemoved","(Lforge/game/card/Card;)Z","invokestatic",1058);}
case 1058:{f.Pc=f.Pop().Int!=0?1067:1061;continue;}
case 1061:{f.Push(f.Locals[4]);f.Pc=1063;continue;}
case 1063:{f.Push(JValue.I(0));f.Pc=1064;continue;}
case 1064:{return rt.Call(f,"forge/game/card/Card","setDamage","(I)V","invokevirtual",1067);}
case 1067:{f.Push(f.Locals[4]);f.Pc=1069;continue;}
case 1069:{f.Push(JValue.I(0));f.Pc=1070;continue;}
case 1070:{return rt.Call(f,"forge/game/card/Card","setHasBeenDealtDeathtouchDamage","(Z)V","invokevirtual",1073);}
case 1073:{f.Pc=1033;continue;}
case 1076:{f.Push(f.Locals[0]);f.Pc=1077;continue;}
case 1077:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1080;continue;}
case 1080:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",1083);}
case 1083:{return rt.Call(f,"forge/game/phase/Phase","executeUntil","()V","invokevirtual",1086);}
case 1086:{f.Push(f.Locals[0]);f.Pc=1087;continue;}
case 1087:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",1090);}
case 1090:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1093);}
case 1093:{f.Locals[3]=f.Pop();f.Pc=1094;continue;}
case 1094:{f.Push(f.Locals[3]);f.Pc=1095;continue;}
case 1095:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1100);}
case 1100:{f.Pc=f.Pop().Int==0?1153:1103;continue;}
case 1103:{f.Push(f.Locals[3]);f.Pc=1104;continue;}
case 1104:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1109);}
case 1109:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1112;continue;}
case 1112:{f.Locals[4]=f.Pop();f.Pc=1114;continue;}
case 1114:{f.Push(f.Locals[0]);f.Pc=1115;continue;}
case 1115:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1118;continue;}
case 1118:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",1121);}
case 1121:{f.Push(f.Locals[4]);f.Pc=1123;continue;}
case 1123:{return rt.Call(f,"forge/game/phase/Phase","executeUntilEndOfPhase","(Lforge/game/player/Player;)V","invokevirtual",1126);}
case 1126:{f.Push(f.Locals[0]);f.Pc=1127;continue;}
case 1127:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1130;continue;}
case 1130:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",1133);}
case 1133:{f.Push(f.Locals[4]);f.Pc=1135;continue;}
case 1135:{return rt.Call(f,"forge/game/phase/Phase","registerUntilEndCommand","(Lforge/game/player/Player;)V","invokevirtual",1138);}
case 1138:{f.Push(f.Locals[0]);f.Pc=1139;continue;}
case 1139:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1142;continue;}
case 1142:{return rt.Call(f,"forge/game/Game","getEndOfCombat","()Lforge/game/phase/Phase;","invokevirtual",1145);}
case 1145:{f.Push(f.Locals[4]);f.Pc=1147;continue;}
case 1147:{return rt.Call(f,"forge/game/phase/Phase","registerUntilEndCommand","(Lforge/game/player/Player;)V","invokevirtual",1150);}
case 1150:{f.Pc=1094;continue;}
case 1153:{f.Push(f.Locals[0]);f.Pc=1154;continue;}
case 1154:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1157;continue;}
case 1157:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",1160);}
case 1160:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1163);}
case 1163:{f.Locals[3]=f.Pop();f.Pc=1164;continue;}
case 1164:{f.Push(f.Locals[3]);f.Pc=1165;continue;}
case 1165:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1170);}
case 1170:{f.Pc=f.Pop().Int==0?1195:1173;continue;}
case 1173:{f.Push(f.Locals[3]);f.Pc=1174;continue;}
case 1174:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1179);}
case 1179:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1182;continue;}
case 1182:{f.Locals[4]=f.Pop();f.Pc=1184;continue;}
case 1184:{f.Push(f.Locals[4]);f.Pc=1186;continue;}
case 1186:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1189);}
case 1189:{return rt.Call(f,"forge/game/player/PlayerController","autoPassCancel","()V","invokevirtual",1192);}
case 1192:{f.Pc=1164;continue;}
case 1195:{f.Push(f.Locals[0]);f.Pc=1196;continue;}
case 1196:{f.Push(JValue.I(0));f.Pc=1197;continue;}
case 1197:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nUpkeepsThisTurn","I",value);f.Pc=1200;continue;}
case 1200:{f.Push(f.Locals[0]);f.Pc=1201;continue;}
case 1201:{f.Push(JValue.I(0));f.Pc=1202;continue;}
case 1202:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nCombatsThisTurn","I",value);f.Pc=1205;continue;}
case 1205:{f.Push(f.Locals[0]);f.Pc=1206;continue;}
case 1206:{f.Push(JValue.I(0));f.Pc=1207;continue;}
case 1207:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nMainsThisTurn","I",value);f.Pc=1210;continue;}
case 1210:{f.Push(f.Locals[0]);f.Pc=1211;continue;}
case 1211:{f.Push(JValue.I(0));f.Pc=1212;continue;}
case 1212:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","nEndOfTurnsThisTurn","I",value);f.Pc=1215;continue;}
case 1215:{f.Push(f.Locals[0]);f.Pc=1216;continue;}
case 1216:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1219;continue;}
case 1219:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",1222);}
case 1222:{return rt.Call(f,"forge/game/zone/MagicStack","resetMaxDistinctSources","()V","invokevirtual",1225);}
case 1225:{f.Push(f.Locals[0]);f.Pc=1226;continue;}
case 1226:{f.Push(JValue.I(0));f.Pc=1227;continue;}
case 1227:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z",value);f.Pc=1230;continue;}
case 1230:{f.Push(f.Locals[0]);f.Pc=1231;continue;}
case 1231:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1234;continue;}
case 1234:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1237);}
case 1237:{f.Push(JValue.I(1));f.Pc=1238;continue;}
case 1238:{return rt.Call(f,"forge/game/GameAction","checkStateEffects","(Z)Z","invokevirtual",1241);}
case 1241:{f.Pc=f.Pop().Int==0?1257:1244;continue;}
case 1244:{f.Push(f.Locals[0]);f.Pc=1245;continue;}
case 1245:{f.Push(JValue.I(1));f.Pc=1246;continue;}
case 1246:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","bRepeatCleanup","Z",value);f.Pc=1249;continue;}
case 1249:{f.Push(f.Locals[0]);f.Pc=1250;continue;}
case 1250:{f.Push(JValue.I(1));f.Pc=1251;continue;}
case 1251:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z",value);f.Pc=1254;continue;}
case 1254:{f.Pc=1257;continue;}
case 1257:{f.Push(f.Locals[1]);f.Pc=1258;continue;}
case 1258:{f.Pc=f.Pop().Int!=0?1309:1261;continue;}
case 1261:{f.Push(f.Locals[0]);f.Pc=1262;continue;}
case 1262:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",1265);}
case 1265:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1268);}
case 1268:{f.Locals[2]=f.Pop();f.Pc=1269;continue;}
case 1269:{f.Push(f.Locals[2]);f.Pc=1270;continue;}
case 1270:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1275);}
case 1275:{f.Pc=f.Pop().Int==0?1309:1278;continue;}
case 1278:{f.Push(f.Locals[2]);f.Pc=1279;continue;}
case 1279:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1284);}
case 1284:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1287;continue;}
case 1287:{f.Locals[3]=f.Pop();f.Pc=1288;continue;}
case 1288:{f.Push(f.Locals[0]);f.Pc=1289;continue;}
case 1289:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1292;continue;}
case 1292:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1295);}
case 1295:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Phase","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Phase","Lforge/game/trigger/TriggerType;"));f.Pc=1298;continue;}
case 1298:{f.Push(f.Locals[3]);f.Pc=1299;continue;}
case 1299:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",1302);}
case 1302:{f.Push(JValue.I(0));f.Pc=1303;continue;}
case 1303:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1306);}
case 1306:{f.Pc=1269;continue;}
case 1309:{f.Push(f.Locals[0]);f.Pc=1310;continue;}
case 1310:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1313;continue;}
case 1313:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",1316);}
case 1316:{return rt.Call(f,"forge/game/zone/MagicStack","unfreezeStack","()V","invokevirtual",1319);}
case 1319:{f.Push(f.Locals[0]);f.Pc=1320;continue;}
case 1320:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=1323;continue;}
case 1323:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"));f.Pc=1326;continue;}
case 1326:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1352:1329;continue;}
case 1329:{f.Push(f.Locals[0]);f.Pc=1330;continue;}
case 1330:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1333;continue;}
case 1333:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",1336);}
case 1336:{return rt.Call(f,"forge/game/zone/MagicStack","hasSimultaneousStackEntries","()Z","invokevirtual",1339);}
case 1339:{f.Pc=f.Pop().Int==0?1352:1342;continue;}
case 1342:{f.Push(f.Locals[0]);f.Pc=1343;continue;}
case 1343:{f.Push(JValue.I(1));f.Pc=1344;continue;}
case 1344:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","bRepeatCleanup","Z",value);f.Pc=1347;continue;}
case 1347:{f.Push(f.Locals[0]);f.Pc=1348;continue;}
case 1348:{f.Push(JValue.I(1));f.Pc=1349;continue;}
case 1349:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z",value);f.Pc=1352;continue;}
case 1352:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7886(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/phase/PhaseHandler","onPhaseEnd","(Z)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7887(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int==0?28:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/zone/MagicStack","isEmpty","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?28:17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Phase.nextPhase() is called, but Stack isn't empty.")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/IllegalStateException","<init>","(Ljava/lang/String;)V","invokespecial",27);}
case 27:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 28:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",31);}
case 31:{f.Locals[2]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",42);}
case 42:{f.Locals[3]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",49);}
case 49:{f.Pc=f.Pop().Int==0?124:52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Locals[4]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",68);}
case 68:{f.Push(JValue.I(1));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/mana/ManaPool","clearPool","(Z)Ljava/util/List;","invokevirtual",72);}
case 72:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",77);}
case 77:{f.Locals[5]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",84);}
case 84:{return rt.Call(f,"forge/game/mana/ManaPool","hasBurn","()Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int==0?121:90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{f.Push(JValue.I(1));f.Pc=96;continue;}
case 96:{f.Push(JValue.R(null));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/player/Player","loseLife","(IZZLforge/game/spellability/SpellAbility;)I","invokevirtual",100);}
case 100:{f.Locals[6]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[6]);f.Pc=104;continue;}
case 104:{f.Pc=f.Pop().Int<=0?121:107;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[6]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",115);}
case 115:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Pc=43;continue;}
case 124:{f.Push(f.Locals[2]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",130);}
case 130:{f.Pc=f.Pop().Int!=0?153:133;continue;}
case 133:{f.Push(f.Locals[2]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPIMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",137);}
case 137:{f.Locals[3]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",145);}
case 145:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"));f.Pc=148;continue;}
case 148:{f.Push(f.Locals[3]);f.Pc=149;continue;}
case 149:{f.Push(JValue.I(0));f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",153);}
case 153:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler$1","$SwitchMap$forge$game$phase$PhaseType","[I"));f.Pc=156;continue;}
case 156:{f.Push(f.Locals[0]);f.Pc=157;continue;}
case 157:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/phase/PhaseType","ordinal","()I","invokevirtual",163);}
case 163:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=164;continue;}
case 164:{switch(f.Pop().Int){case 7:f.Pc=353;break;case 8:f.Pc=208;break;case 9:f.Pc=542;break;case 10:f.Pc=370;break;case 11:f.Pc=542;break;case 12:f.Pc=542;break;case 13:f.Pc=424;break;default:f.Pc=542;break;}continue;}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=212;continue;}
case 212:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/Game","getCardsIncludePhasingIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",218);}
case 218:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",223);}
case 223:{f.Locals[3]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[3]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",230);}
case 230:{f.Pc=f.Pop().Int==0?322:233;continue;}
case 233:{f.Push(f.Locals[3]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",239);}
case 239:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=242;continue;}
case 242:{f.Locals[4]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(f.Locals[4]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",249);}
case 249:{f.Push(f.Locals[0]);f.Pc=250;continue;}
case 250:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/card/CardDamageHistory","setNotAttackedSinceLastUpkeepOf","(Lforge/game/player/Player;)V","invokevirtual",256);}
case 256:{f.Push(f.Locals[4]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",261);}
case 261:{f.Push(f.Locals[0]);f.Pc=262;continue;}
case 262:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/card/CardDamageHistory","setNotBlockedSinceLastUpkeepOf","(Lforge/game/player/Player;)V","invokevirtual",268);}
case 268:{f.Push(f.Locals[4]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",273);}
case 273:{f.Push(f.Locals[0]);f.Pc=274;continue;}
case 274:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/card/CardDamageHistory","setNotBeenBlockedSinceLastUpkeepOf","(Lforge/game/player/Player;)V","invokevirtual",280);}
case 280:{f.Push(f.Locals[0]);f.Pc=281;continue;}
case 281:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=284;continue;}
case 284:{f.Push(f.Locals[4]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",289);}
case 289:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",292);}
case 292:{f.Pc=f.Pop().Int==0?319:295;continue;}
case 295:{f.Push(f.Locals[4]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/card/Card","getTurnInZone","()I","invokevirtual",300);}
case 300:{f.Push(f.Locals[0]);f.Pc=301;continue;}
case 301:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",307);}
case 307:{return rt.Call(f,"forge/game/phase/PhaseHandler","getTurn","()I","invokevirtual",310);}
case 310:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?319:313;continue;}
case 313:{f.Push(f.Locals[4]);f.Pc=315;continue;}
case 315:{f.Push(JValue.I(0));f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/card/Card","setCameUnderControlSinceLastUpkeep","(Z)V","invokevirtual",319);}
case 319:{f.Pc=224;continue;}
case 322:{f.Push(f.Locals[0]);f.Pc=323;continue;}
case 323:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/Game","getUpkeep","()Lforge/game/phase/Phase;","invokevirtual",329);}
case 329:{f.Push(f.Locals[0]);f.Pc=330;continue;}
case 330:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/phase/Phase","executeUntilEndOfPhase","(Lforge/game/player/Player;)V","invokevirtual",336);}
case 336:{f.Push(f.Locals[0]);f.Pc=337;continue;}
case 337:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/Game","getUpkeep","()Lforge/game/phase/Phase;","invokevirtual",343);}
case 343:{f.Push(f.Locals[0]);f.Pc=344;continue;}
case 344:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/phase/Phase","registerUntilEndCommand","(Lforge/game/player/Player;)V","invokevirtual",350);}
case 350:{f.Pc=542;continue;}
case 353:{f.Push(f.Locals[0]);f.Pc=354;continue;}
case 354:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/Game","getUntap","()Lforge/game/phase/Untap;","invokevirtual",360);}
case 360:{f.Push(f.Locals[0]);f.Pc=361;continue;}
case 361:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/phase/Untap","executeUntilEndOfPhase","(Lforge/game/player/Player;)V","invokevirtual",367);}
case 367:{f.Pc=542;continue;}
case 370:{f.Push(JValue.R(null));f.Pc=371;continue;}
case 371:{f.Locals[3]=f.Pop();f.Pc=372;continue;}
case 372:{f.Push(f.Locals[0]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/phase/PhaseHandler","inCombat","()Z","invokevirtual",376);}
case 376:{f.Pc=f.Pop().Int==0?405:379;continue;}
case 379:{f.Push(f.Locals[0]);f.Pc=380;continue;}
case 380:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",386);}
case 386:{f.Locals[4]=f.Pop();f.Pc=388;continue;}
case 388:{f.Push(f.Locals[0]);f.Pc=389;continue;}
case 389:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/combat/Combat","getAllBlockers","()Lforge/game/card/CardCollection;","invokevirtual",395);}
case 395:{f.Locals[5]=f.Pop();f.Pc=397;continue;}
case 397:{f.Push(f.Locals[4]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[5]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/event/GameEventCombatEnded","fromCards","(Ljava/util/List;Ljava/util/List;)Lforge/game/event/GameEventCombatEnded;","invokestatic",404);}
case 404:{f.Locals[3]=f.Pop();f.Pc=405;continue;}
case 405:{f.Push(f.Locals[0]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/phase/PhaseHandler","endCombat","()V","invokevirtual",409);}
case 409:{f.Push(f.Locals[3]);f.Pc=410;continue;}
case 410:{f.Pc=f.Pop().Reference==null?542:413;continue;}
case 413:{f.Push(f.Locals[0]);f.Pc=414;continue;}
case 414:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=417;continue;}
case 417:{f.Push(f.Locals[3]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",421);}
case 421:{f.Pc=542;continue;}
case 424:{f.Push(f.Locals[0]);f.Pc=425;continue;}
case 425:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","bRepeatCleanup","Z"));f.Pc=428;continue;}
case 428:{f.Pc=f.Pop().Int!=0?507:431;continue;}
case 431:{f.Push(f.Locals[0]);f.Pc=432;continue;}
case 432:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=435;continue;}
case 435:{return rt.Call(f,"forge/game/Game","onCleanupPhase","()V","invokevirtual",438);}
case 438:{f.Push(f.Locals[0]);f.Pc=439;continue;}
case 439:{f.Push(f.Locals[0]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",443);}
case 443:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","playerPreviousTurn","Lforge/game/player/Player;",value);f.Pc=446;continue;}
case 446:{f.Push(f.Locals[0]);f.Pc=447;continue;}
case 447:{f.Push(f.Locals[0]);f.Pc=448;continue;}
case 448:{return rt.Call(f,"forge/game/phase/PhaseHandler","handleNextTurn","()Lforge/game/player/Player;","invokevirtual",451);}
case 451:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPlayerTurn","(Lforge/game/player/Player;)V","invokevirtual",454);}
case 454:{f.Push(f.Locals[0]);f.Pc=455;continue;}
case 455:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=458;continue;}
case 458:{return rt.Call(f,"forge/game/Game","getCleanup","()Lforge/game/phase/Phase;","invokevirtual",461);}
case 461:{return rt.Call(f,"forge/game/phase/Phase","executeUntil","()V","invokevirtual",464);}
case 464:{f.Push(f.Locals[0]);f.Pc=465;continue;}
case 465:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=468;continue;}
case 468:{return rt.Call(f,"forge/game/Game","getCleanup","()Lforge/game/phase/Phase;","invokevirtual",471);}
case 471:{f.Push(f.Locals[0]);f.Pc=472;continue;}
case 472:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/phase/Phase","executeUntil","(Lforge/game/player/Player;)V","invokevirtual",478);}
case 478:{f.Push(f.Locals[0]);f.Pc=479;continue;}
case 479:{return rt.Call(f,"forge/game/phase/PhaseHandler","handleMultiplayerEffects","()V","invokevirtual",482);}
case 482:{f.Push(f.Locals[0]);f.Pc=483;continue;}
case 483:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",489);}
case 489:{f.Locals[4]=f.Pop();f.Pc=491;continue;}
case 491:{f.Push(f.Locals[0]);f.Pc=492;continue;}
case 492:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",498);}
case 498:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TurnBegin","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TurnBegin","Lforge/game/trigger/TriggerType;"));f.Pc=501;continue;}
case 501:{f.Push(f.Locals[4]);f.Pc=503;continue;}
case 503:{f.Push(JValue.I(0));f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",507);}
case 507:{f.Push(f.Locals[0]);f.Pc=508;continue;}
case 508:{f.Push(JValue.I(0));f.Pc=509;continue;}
case 509:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","planarDiceSpecialActionThisTurn","I",value);f.Pc=512;continue;}
case 512:{f.Push(f.Locals[0]);f.Pc=513;continue;}
case 513:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=516;continue;}
case 516:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventTurnEnded"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventTurnEnded")));f.Pc=519;continue;}
case 519:{f.StackOp("dup");f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/game/event/GameEventTurnEnded","<init>","()V","invokespecial",523);}
case 523:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",526);}
case 526:{f.Push(f.Locals[0]);f.Pc=527;continue;}
case 527:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=530;continue;}
case 530:{return rt.Call(f,"forge/game/Game","getUndoManager","()Lforge/game/undo/UndoManager;","invokevirtual",533);}
case 533:{f.Push(JValue.R(rt.String("Turn Ended.")));f.Pc=536;continue;}
case 536:{return rt.Call(f,"forge/game/undo/UndoManager","barrier","(Ljava/lang/String;)V","invokevirtual",539);}
case 539:{f.Pc=542;continue;}
case 542:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7888(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/game/phase/PhaseHandler:7888:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",9);}
case 9:{return rt.Call(f,"forge/game/player/PlayerCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?669:15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?28:27;continue;}
case 27:{return JStep.ReturnVoid;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",35);}
case 35:{f.Locals[2]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?122:45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[3]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/combat/CombatUtil","canAttack","(Lforge/game/player/Player;)Z","invokestatic",59);}
case 59:{f.Pc=f.Pop().Int!=0?65:62;continue;}
case 62:{f.Pc=36;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/player/Player","getDeclaresAttackers","()Lforge/game/player/Player;","invokevirtual",69);}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",73);}
case 73:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=76;continue;}
case 76:{f.Locals[4]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/Game","getUndoManager","()Lforge/game/undo/UndoManager;","invokevirtual",85);}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/undo/UndoManager","isOwner","(Lforge/game/player/Player;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int!=0?106:93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/Game","getUndoManager","()Lforge/game/undo/UndoManager;","invokevirtual",100);}
case 100:{f.Push(JValue.R(rt.String("Opponent declared attackers")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/undo/UndoManager","barrier","(Ljava/lang/String;)V","invokevirtual",106);}
case 106:{f.Push(f.Locals[4]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",111);}
case 111:{f.Push(f.Locals[3]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/player/PlayerController","declareAttackers","(Lforge/game/player/Player;Lforge/game/combat/Combat;)V","invokevirtual",119);}
case 119:{f.Pc=36;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/combat/Combat","removeAbsentCombatants","()Z","invokevirtual",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/combat/CombatUtil","validateAttackers","(Lforge/game/combat/Combat;)Z","invokestatic",137);}
case 137:{f.Locals[1]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Pc=f.Pop().Int!=0?197:142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",146);}
case 146:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",149);}
case 149:{f.Locals[2]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",156);}
case 156:{f.Pc=f.Pop().Int==0?194:159;continue;}
case 159:{f.Push(f.Locals[2]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",165);}
case 165:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=168;continue;}
case 168:{f.Locals[3]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[3]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/player/Player","getDeclaresAttackers","()Lforge/game/player/Player;","invokevirtual",173);}
case 173:{f.Push(f.Locals[3]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",177);}
case 177:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",183);}
case 183:{f.Push(JValue.R(null));f.Pc=184;continue;}
case 184:{f.Push(JValue.R(null));f.Pc=185;continue;}
case 185:{f.Push(JValue.R(rt.String("Attack declaration invalid")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/player/PlayerController","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;)V","invokevirtual",191);}
case 191:{f.Pc=150;continue;}
case 194:{f.Pc=554;continue;}
case 197:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=200;continue;}
case 200:{f.StackOp("dup");f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",204);}
case 204:{f.Locals[2]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[0]);f.Pc=206;continue;}
case 206:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",212);}
case 212:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",215);}
case 215:{f.Locals[3]=f.Pop();f.Pc=216;continue;}
case 216:{f.Push(f.Locals[3]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",222);}
case 222:{f.Pc=f.Pop().Int==0?260:225;continue;}
case 225:{f.Push(f.Locals[3]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",231);}
case 231:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=234;continue;}
case 234:{f.Locals[4]=f.Pop();f.Pc=236;continue;}
case 236:{f.Push(f.Locals[4]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/card/Card","attackVigilance","()Z","invokevirtual",241);}
case 241:{f.Pc=f.Pop().Int!=0?257:244;continue;}
case 244:{f.Push(f.Locals[4]);f.Pc=246;continue;}
case 246:{f.Push(JValue.I(1));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",250);}
case 250:{f.Push(f.Locals[2]);f.Pc=251;continue;}
case 251:{f.Push(f.Locals[4]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",256);}
case 256:{f.StackOp("pop");f.Pc=257;continue;}
case 257:{f.Pc=216;continue;}
case 260:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=263;continue;}
case 263:{f.StackOp("dup");f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",267);}
case 267:{f.Locals[3]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[0]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",272);}
case 272:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",275);}
case 275:{f.Locals[4]=f.Pop();f.Pc=277;continue;}
case 277:{f.Push(f.Locals[4]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",284);}
case 284:{f.Pc=f.Pop().Int==0?405:287;continue;}
case 287:{f.Push(f.Locals[4]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",294);}
case 294:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=297;continue;}
case 297:{f.Locals[5]=f.Pop();f.Pc=299;continue;}
case 299:{f.Push(f.Locals[5]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/player/Player","getDeclaresAttackers","()Lforge/game/player/Player;","invokevirtual",304);}
case 304:{f.Push(f.Locals[5]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",309);}
case 309:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=312;continue;}
case 312:{f.Locals[6]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[0]);f.Pc=315;continue;}
case 315:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",321);}
case 321:{f.Push(f.Locals[5]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",326);}
case 326:{f.Locals[7]=f.Pop();f.Pc=328;continue;}
case 328:{f.Push(f.Locals[7]);f.Pc=330;continue;}
case 330:{f.Push(JValue.R(rt.ClassObject("forge/game/cost/CostExert")));f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/combat/CombatUtil","getOptionalAttackCostCreatures","(Lforge/game/card/CardCollection;Ljava/lang/Class;)Lforge/game/card/CardCollection;","invokestatic",336);}
case 336:{f.Locals[8]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[8]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",345);}
case 345:{f.Pc=f.Pop().Int!=0?365:348;continue;}
case 348:{f.Push(f.Locals[3]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[6]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",354);}
case 354:{f.Push(f.Locals[8]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"forge/game/player/PlayerController","exertAttackers","(Ljava/util/List;)Ljava/util/List;","invokevirtual",359);}
case 359:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",364);}
case 364:{f.StackOp("pop");f.Pc=365;continue;}
case 365:{f.Push(f.Locals[7]);f.Pc=367;continue;}
case 367:{f.Push(JValue.R(rt.ClassObject("forge/game/cost/CostEnlist")));f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/combat/CombatUtil","getOptionalAttackCostCreatures","(Lforge/game/card/CardCollection;Ljava/lang/Class;)Lforge/game/card/CardCollection;","invokestatic",373);}
case 373:{f.Locals[9]=f.Pop();f.Pc=375;continue;}
case 375:{f.Push(f.Locals[9]);f.Pc=377;continue;}
case 377:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",382);}
case 382:{f.Pc=f.Pop().Int!=0?402:385;continue;}
case 385:{f.Push(f.Locals[3]);f.Pc=386;continue;}
case 386:{f.Push(f.Locals[6]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",391);}
case 391:{f.Push(f.Locals[9]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/player/PlayerController","enlistAttackers","(Ljava/util/List;)Ljava/util/List;","invokevirtual",396);}
case 396:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",401);}
case 401:{f.StackOp("pop");f.Pc=402;continue;}
case 402:{f.Pc=277;continue;}
case 405:{f.Push(f.Locals[0]);f.Pc=406;continue;}
case 406:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=409;continue;}
case 409:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",412);}
case 412:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",415);}
case 415:{f.Locals[4]=f.Pop();f.Pc=417;continue;}
case 417:{f.Push(f.Locals[4]);f.Pc=419;continue;}
case 419:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",424);}
case 424:{f.Pc=f.Pop().Int==0?554:427;continue;}
case 427:{f.Push(f.Locals[4]);f.Pc=429;continue;}
case 429:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",434);}
case 434:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=437;continue;}
case 437:{f.Locals[5]=f.Pop();f.Pc=439;continue;}
case 439:{f.Push(f.Locals[0]);f.Pc=440;continue;}
case 440:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=443;continue;}
case 443:{f.Push(f.Locals[5]);f.Pc=445;continue;}
case 445:{f.Push(f.Locals[0]);f.Pc=446;continue;}
case 446:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=449;continue;}
case 449:{f.Push(f.Locals[3]);f.Pc=450;continue;}
case 450:{return rt.Call(f,"forge/game/combat/CombatUtil","checkPropagandaEffects","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/combat/Combat;Ljava/util/List;)Z","invokestatic",453);}
case 453:{f.Locals[6]=f.Pop();f.Pc=455;continue;}
case 455:{f.Push(f.Locals[6]);f.Pc=457;continue;}
case 457:{f.Pc=f.Pop().Int!=0?551:460;continue;}
case 460:{f.Push(f.Locals[0]);f.Pc=461;continue;}
case 461:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=464;continue;}
case 464:{f.Push(f.Locals[5]);f.Pc=466;continue;}
case 466:{return rt.Call(f,"forge/game/combat/Combat","removeFromCombat","(Lforge/game/card/Card;)V","invokevirtual",469);}
case 469:{f.Push(f.Locals[2]);f.Pc=470;continue;}
case 470:{f.Push(f.Locals[5]);f.Pc=472;continue;}
case 472:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",475);}
case 475:{f.Pc=f.Pop().Int==0?484:478;continue;}
case 478:{f.Push(f.Locals[5]);f.Pc=480;continue;}
case 480:{f.Push(JValue.I(0));f.Pc=481;continue;}
case 481:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",484);}
case 484:{f.Push(f.Locals[0]);f.Pc=485;continue;}
case 485:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=488;continue;}
case 488:{return rt.Call(f,"forge/game/combat/CombatUtil","validateAttackers","(Lforge/game/combat/Combat;)Z","invokestatic",491);}
case 491:{f.Locals[1]=f.Pop();f.Pc=492;continue;}
case 492:{f.Push(f.Locals[1]);f.Pc=493;continue;}
case 493:{f.Pc=f.Pop().Int!=0?551:496;continue;}
case 496:{f.Push(f.Locals[2]);f.Pc=497;continue;}
case 497:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",500);}
case 500:{f.Locals[7]=f.Pop();f.Pc=502;continue;}
case 502:{f.Push(f.Locals[7]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",509);}
case 509:{f.Pc=f.Pop().Int==0?533:512;continue;}
case 512:{f.Push(f.Locals[7]);f.Pc=514;continue;}
case 514:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",519);}
case 519:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=522;continue;}
case 522:{f.Locals[8]=f.Pop();f.Pc=524;continue;}
case 524:{f.Push(f.Locals[8]);f.Pc=526;continue;}
case 526:{f.Push(JValue.I(0));f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",530);}
case 530:{f.Pc=502;continue;}
case 533:{f.Push(f.Locals[0]);f.Pc=534;continue;}
case 534:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=537;continue;}
case 537:{return rt.Call(f,"forge/game/combat/Combat","removeAbsentCombatants","()Z","invokevirtual",540);}
case 540:{f.StackOp("pop");f.Pc=541;continue;}
case 541:{f.Push(f.Locals[0]);f.Pc=542;continue;}
case 542:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/game/combat/Combat","initConstraints","()V","invokevirtual",548);}
case 548:{f.Pc=554;continue;}
case 551:{f.Pc=417;continue;}
case 554:{f.Push(f.Locals[1]);f.Pc=555;continue;}
case 555:{f.Pc=f.Pop().Int==0?17:558;continue;}
case 558:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=561;continue;}
case 561:{f.StackOp("dup");f.Pc=562;continue;}
case 562:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",565);}
case 565:{f.Locals[2]=f.Pop();f.Pc=566;continue;}
case 566:{f.Push(f.Locals[0]);f.Pc=567;continue;}
case 567:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=570;continue;}
case 570:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",573);}
case 573:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",576);}
case 576:{f.Locals[3]=f.Pop();f.Pc=577;continue;}
case 577:{f.Push(f.Locals[3]);f.Pc=578;continue;}
case 578:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",583);}
case 583:{f.Pc=f.Pop().Int==0?632:586;continue;}
case 586:{f.Push(f.Locals[3]);f.Pc=587;continue;}
case 587:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",592);}
case 592:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=595;continue;}
case 595:{f.Locals[4]=f.Pop();f.Pc=597;continue;}
case 597:{f.Push(f.Locals[4]);f.Pc=599;continue;}
case 599:{return rt.Call(f,"forge/game/card/Card","attackVigilance","()Z","invokevirtual",602);}
case 602:{f.Pc=f.Pop().Int!=0?629:605;continue;}
case 605:{f.Push(f.Locals[4]);f.Pc=607;continue;}
case 607:{f.Push(JValue.I(0));f.Pc=608;continue;}
case 608:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",611);}
case 611:{f.Push(f.Locals[4]);f.Pc=613;continue;}
case 613:{f.Push(JValue.I(1));f.Pc=614;continue;}
case 614:{f.Push(JValue.R(null));f.Pc=615;continue;}
case 615:{f.Push(JValue.R(null));f.Pc=616;continue;}
case 616:{return rt.Call(f,"forge/game/card/Card","tap","(ZLforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z","invokevirtual",619);}
case 619:{f.Pc=f.Pop().Int==0?629:622;continue;}
case 622:{f.Push(f.Locals[2]);f.Pc=623;continue;}
case 623:{f.Push(f.Locals[4]);f.Pc=625;continue;}
case 625:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",628);}
case 628:{f.StackOp("pop");f.Pc=629;continue;}
case 629:{f.Pc=577;continue;}
case 632:{f.Push(f.Locals[2]);f.Pc=633;continue;}
case 633:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",636);}
case 636:{f.Pc=f.Pop().Int!=0?669:639;continue;}
case 639:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",642);}
case 642:{f.Locals[3]=f.Pop();f.Pc=643;continue;}
case 643:{f.Push(f.Locals[3]);f.Pc=644;continue;}
case 644:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=647;continue;}
case 647:{f.Push(f.Locals[2]);f.Pc=648;continue;}
case 648:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",653);}
case 653:{f.StackOp("pop");f.Pc=654;continue;}
case 654:{f.Push(f.Locals[0]);f.Pc=655;continue;}
case 655:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=658;continue;}
case 658:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",661);}
case 661:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"));f.Pc=664;continue;}
case 664:{f.Push(f.Locals[3]);f.Pc=665;continue;}
case 665:{f.Push(JValue.I(0));f.Pc=666;continue;}
case 666:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",669);}
case 669:{f.Push(f.Locals[0]);f.Pc=670;continue;}
case 670:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=673;continue;}
case 673:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",676);}
case 676:{f.Pc=f.Pop().Int==0?680:679;continue;}
case 679:{return JStep.ReturnVoid;}
case 680:{f.Push(f.Locals[0]);f.Pc=681;continue;}
case 681:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=684;continue;}
case 684:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",687);}
case 687:{return rt.Call(f,"forge/game/trigger/TriggerHandler","resetActiveTriggers","()V","invokevirtual",690);}
case 690:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",693);}
case 693:{f.Locals[1]=f.Pop();f.Pc=694;continue;}
case 694:{f.Push(f.Locals[0]);f.Pc=695;continue;}
case 695:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=698;continue;}
case 698:{return rt.Call(f,"forge/game/combat/Combat","getDefenders","()Lforge/util/collect/FCollectionView;","invokevirtual",701);}
case 701:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",706);}
case 706:{f.Locals[2]=f.Pop();f.Pc=707;continue;}
case 707:{f.Push(f.Locals[2]);f.Pc=708;continue;}
case 708:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",713);}
case 713:{f.Pc=f.Pop().Int==0?745:716;continue;}
case 716:{f.Push(f.Locals[2]);f.Pc=717;continue;}
case 717:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",722);}
case 722:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=725;continue;}
case 725:{f.Locals[3]=f.Pop();f.Pc=726;continue;}
case 726:{f.Push(f.Locals[1]);f.Pc=727;continue;}
case 727:{f.Push(f.Locals[3]);f.Pc=728;continue;}
case 728:{f.Push(f.Locals[0]);f.Pc=729;continue;}
case 729:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=732;continue;}
case 732:{f.Push(f.Locals[3]);f.Pc=733;continue;}
case 733:{return rt.Call(f,"forge/game/combat/Combat","getAttackersOf","(Lforge/game/GameEntity;)Lforge/game/card/CardCollection;","invokevirtual",736);}
case 736:{return rt.Call(f,"com/google/common/collect/Multimap","putAll","(Ljava/lang/Object;Ljava/lang/Iterable;)Z","invokeinterface",741);}
case 741:{f.StackOp("pop");f.Pc=742;continue;}
case 742:{f.Pc=707;continue;}
case 745:{f.Push(f.Locals[0]);f.Pc=746;continue;}
case 746:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=749;continue;}
case 749:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAttackersDeclared"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAttackersDeclared")));f.Pc=752;continue;}
case 752:{f.StackOp("dup");f.Pc=753;continue;}
case 753:{f.Push(f.Locals[0]);f.Pc=754;continue;}
case 754:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=757;continue;}
case 757:{f.Push(f.Locals[1]);f.Pc=758;continue;}
case 758:{return rt.Call(f,"forge/game/event/GameEventAttackersDeclared","<init>","(Lforge/game/player/Player;Lcom/google/common/collect/Multimap;)V","invokespecial",761);}
case 761:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",764);}
case 764:{f.Push(f.Locals[0]);f.Pc=765;continue;}
case 765:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=768;continue;}
case 768:{f.Push(f.Locals[0]);f.Pc=769;continue;}
case 769:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=772;continue;}
case 772:{return rt.Call(f,"forge/game/Game","getPlayersInTurnOrder","(Lforge/game/player/Player;)Lforge/game/player/PlayerCollection;","invokevirtual",775);}
case 775:{f.Push(f.Locals[0]);f.Pc=776;continue;}
case 776:{return rt.DynamicCall(f,"forge/game/phase/PhaseHandler:7888:776:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/phase/PhaseHandler;)Ljava/util/function/Predicate;",781);}
case 781:{return rt.Call(f,"forge/game/player/PlayerCollection","filter","(Ljava/util/function/Predicate;)Lforge/game/player/PlayerCollection;","invokevirtual",784);}
case 784:{f.Locals[2]=f.Pop();f.Pc=785;continue;}
case 785:{f.Push(f.Locals[2]);f.Pc=786;continue;}
case 786:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",789);}
case 789:{f.Push(JValue.I(1));f.Pc=790;continue;}
case 790:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?797:793;continue;}
case 793:{f.Push(JValue.I(1));f.Pc=794;continue;}
case 794:{f.Pc=798;continue;}
case 797:{f.Push(JValue.I(0));f.Pc=798;continue;}
case 798:{f.Locals[3]=f.Pop();f.Pc=799;continue;}
case 799:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=802;continue;}
case 802:{f.StackOp("dup");f.Pc=803;continue;}
case 803:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",806);}
case 806:{f.Locals[4]=f.Pop();f.Pc=808;continue;}
case 808:{f.Push(f.Locals[3]);f.Pc=809;continue;}
case 809:{f.Pc=f.Pop().Int==0?821:812;continue;}
case 812:{f.Push(f.Locals[4]);f.Pc=814;continue;}
case 814:{f.Push(JValue.R(null));f.Pc=815;continue;}
case 815:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",820);}
case 820:{f.StackOp("pop");f.Pc=821;continue;}
case 821:{f.Push(f.Locals[4]);f.Pc=823;continue;}
case 823:{f.Push(f.Locals[2]);f.Pc=824;continue;}
case 824:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",829);}
case 829:{f.StackOp("pop");f.Pc=830;continue;}
case 830:{f.Push(f.Locals[4]);f.Pc=832;continue;}
case 832:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",837);}
case 837:{f.Locals[5]=f.Pop();f.Pc=839;continue;}
case 839:{f.Push(f.Locals[5]);f.Pc=841;continue;}
case 841:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",846);}
case 846:{f.Pc=f.Pop().Int==0?1195:849;continue;}
case 849:{f.Push(f.Locals[5]);f.Pc=851;continue;}
case 851:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",856);}
case 856:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=859;continue;}
case 859:{f.Locals[6]=f.Pop();f.Pc=861;continue;}
case 861:{f.Push(f.Locals[6]);f.Pc=863;continue;}
case 863:{f.Pc=f.Pop().Reference!=null?876:866;continue;}
case 866:{f.Push(f.Locals[0]);f.Pc=867;continue;}
case 867:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=870;continue;}
case 870:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",873);}
case 873:{f.Pc=888;continue;}
case 876:{f.Push(f.Locals[0]);f.Pc=877;continue;}
case 877:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=880;continue;}
case 880:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",883);}
case 883:{f.Push(f.Locals[6]);f.Pc=885;continue;}
case 885:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",888);}
case 888:{f.Locals[7]=f.Pop();f.Pc=890;continue;}
case 890:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=893;continue;}
case 893:{f.StackOp("dup");f.Pc=894;continue;}
case 894:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",897);}
case 897:{f.Locals[8]=f.Pop();f.Pc=899;continue;}
case 899:{f.Push(f.Locals[0]);f.Pc=900;continue;}
case 900:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=903;continue;}
case 903:{return rt.Call(f,"forge/game/combat/Combat","getDefenders","()Lforge/util/collect/FCollectionView;","invokevirtual",906);}
case 906:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",911);}
case 911:{f.Locals[9]=f.Pop();f.Pc=913;continue;}
case 913:{f.Push(f.Locals[9]);f.Pc=915;continue;}
case 915:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",920);}
case 920:{f.Pc=f.Pop().Int==0?1092:923;continue;}
case 923:{f.Push(f.Locals[9]);f.Pc=925;continue;}
case 925:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",930);}
case 930:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=933;continue;}
case 933:{f.Locals[10]=f.Pop();f.Pc=935;continue;}
case 935:{f.Push(f.Locals[6]);f.Pc=937;continue;}
case 937:{f.Pc=f.Pop().Reference!=null?952:940;continue;}
case 940:{f.Push(f.Locals[0]);f.Pc=941;continue;}
case 941:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=944;continue;}
case 944:{f.Push(f.Locals[10]);f.Pc=946;continue;}
case 946:{return rt.Call(f,"forge/game/combat/Combat","getAttackersOf","(Lforge/game/GameEntity;)Lforge/game/card/CardCollection;","invokevirtual",949);}
case 949:{f.Pc=966;continue;}
case 952:{f.Push(f.Locals[0]);f.Pc=953;continue;}
case 953:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=956;continue;}
case 956:{f.Push(f.Locals[10]);f.Pc=958;continue;}
case 958:{return rt.Call(f,"forge/game/combat/Combat","getAttackersOf","(Lforge/game/GameEntity;)Lforge/game/card/CardCollection;","invokevirtual",961);}
case 961:{f.Push(f.Locals[6]);f.Pc=963;continue;}
case 963:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",966);}
case 966:{f.Locals[11]=f.Pop();f.Pc=968;continue;}
case 968:{f.Push(f.Locals[11]);f.Pc=970;continue;}
case 970:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",973);}
case 973:{f.Pc=f.Pop().Int!=0?1089:976;continue;}
case 976:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",979);}
case 979:{f.Locals[12]=f.Pop();f.Pc=981;continue;}
case 981:{f.Push(f.Locals[12]);f.Pc=983;continue;}
case 983:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=986;continue;}
case 986:{f.Push(f.Locals[11]);f.Pc=988;continue;}
case 988:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",993);}
case 993:{f.StackOp("pop");f.Pc=994;continue;}
case 994:{f.Push(f.Locals[12]);f.Pc=996;continue;}
case 996:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AttackingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AttackingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=999;continue;}
case 999:{f.Push(f.Locals[6]);f.Pc=1001;continue;}
case 1001:{f.Pc=f.Pop().Reference!=null?1011:1004;continue;}
case 1004:{f.Push(f.Locals[0]);f.Pc=1005;continue;}
case 1005:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=1008;continue;}
case 1008:{f.Pc=1013;continue;}
case 1011:{f.Push(f.Locals[6]);f.Pc=1013;continue;}
case 1013:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1018);}
case 1018:{f.StackOp("pop");f.Pc=1019;continue;}
case 1019:{f.Push(f.Locals[3]);f.Pc=1020;continue;}
case 1020:{f.Pc=f.Pop().Int==0?1047:1023;continue;}
case 1023:{f.Push(f.Locals[12]);f.Pc=1025;continue;}
case 1025:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OneOfAttackingTeam","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OneOfAttackingTeam","Lforge/game/ability/AbilityKey;"));f.Pc=1028;continue;}
case 1028:{f.Push(f.Locals[6]);f.Pc=1030;continue;}
case 1030:{f.Pc=f.Pop().Reference==null?1037:1033;continue;}
case 1033:{f.Push(JValue.I(1));f.Pc=1034;continue;}
case 1034:{f.Pc=1038;continue;}
case 1037:{f.Push(JValue.I(0));f.Pc=1038;continue;}
case 1038:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",1041);}
case 1041:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1046);}
case 1046:{f.StackOp("pop");f.Pc=1047;continue;}
case 1047:{f.Push(f.Locals[12]);f.Pc=1049;continue;}
case 1049:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AttackedTarget","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AttackedTarget","Lforge/game/ability/AbilityKey;"));f.Pc=1052;continue;}
case 1052:{f.Push(f.Locals[10]);f.Pc=1054;continue;}
case 1054:{return rt.Call(f,"java/util/Collections","singletonList","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",1057);}
case 1057:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1062);}
case 1062:{f.StackOp("pop");f.Pc=1063;continue;}
case 1063:{f.Push(f.Locals[8]);f.Pc=1065;continue;}
case 1065:{f.Push(f.Locals[10]);f.Pc=1067;continue;}
case 1067:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1072);}
case 1072:{f.StackOp("pop");f.Pc=1073;continue;}
case 1073:{f.Push(f.Locals[0]);f.Pc=1074;continue;}
case 1074:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1077;continue;}
case 1077:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1080);}
case 1080:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackersDeclaredOneTarget","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackersDeclaredOneTarget","Lforge/game/trigger/TriggerType;"));f.Pc=1083;continue;}
case 1083:{f.Push(f.Locals[12]);f.Pc=1085;continue;}
case 1085:{f.Push(JValue.I(0));f.Pc=1086;continue;}
case 1086:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1089);}
case 1089:{f.Pc=913;continue;}
case 1092:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1095);}
case 1095:{f.Locals[9]=f.Pop();f.Pc=1097;continue;}
case 1097:{f.Push(f.Locals[9]);f.Pc=1099;continue;}
case 1099:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=1102;continue;}
case 1102:{f.Push(f.Locals[7]);f.Pc=1104;continue;}
case 1104:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1109);}
case 1109:{f.StackOp("pop");f.Pc=1110;continue;}
case 1110:{f.Push(f.Locals[9]);f.Pc=1112;continue;}
case 1112:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AttackingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AttackingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=1115;continue;}
case 1115:{f.Push(f.Locals[6]);f.Pc=1117;continue;}
case 1117:{f.Pc=f.Pop().Reference!=null?1127:1120;continue;}
case 1120:{f.Push(f.Locals[0]);f.Pc=1121;continue;}
case 1121:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=1124;continue;}
case 1124:{f.Pc=1129;continue;}
case 1127:{f.Push(f.Locals[6]);f.Pc=1129;continue;}
case 1129:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1134);}
case 1134:{f.StackOp("pop");f.Pc=1135;continue;}
case 1135:{f.Push(f.Locals[9]);f.Pc=1137;continue;}
case 1137:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AttackedTarget","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AttackedTarget","Lforge/game/ability/AbilityKey;"));f.Pc=1140;continue;}
case 1140:{f.Push(f.Locals[8]);f.Pc=1142;continue;}
case 1142:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1147);}
case 1147:{f.StackOp("pop");f.Pc=1148;continue;}
case 1148:{f.Push(f.Locals[3]);f.Pc=1149;continue;}
case 1149:{f.Pc=f.Pop().Int==0?1176:1152;continue;}
case 1152:{f.Push(f.Locals[9]);f.Pc=1154;continue;}
case 1154:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OneOfAttackingTeam","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OneOfAttackingTeam","Lforge/game/ability/AbilityKey;"));f.Pc=1157;continue;}
case 1157:{f.Push(f.Locals[6]);f.Pc=1159;continue;}
case 1159:{f.Pc=f.Pop().Reference==null?1166:1162;continue;}
case 1162:{f.Push(JValue.I(1));f.Pc=1163;continue;}
case 1163:{f.Pc=1167;continue;}
case 1166:{f.Push(JValue.I(0));f.Pc=1167;continue;}
case 1167:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",1170);}
case 1170:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1175);}
case 1175:{f.StackOp("pop");f.Pc=1176;continue;}
case 1176:{f.Push(f.Locals[0]);f.Pc=1177;continue;}
case 1177:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1180;continue;}
case 1180:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1183);}
case 1183:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackersDeclared","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackersDeclared","Lforge/game/trigger/TriggerType;"));f.Pc=1186;continue;}
case 1186:{f.Push(f.Locals[9]);f.Pc=1188;continue;}
case 1188:{f.Push(JValue.I(0));f.Pc=1189;continue;}
case 1189:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1192);}
case 1192:{f.Pc=839;continue;}
case 1195:{f.Push(f.Locals[0]);f.Pc=1196;continue;}
case 1196:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=1199;continue;}
case 1199:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",1202);}
case 1202:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1205);}
case 1205:{f.Locals[5]=f.Pop();f.Pc=1207;continue;}
case 1207:{f.Push(f.Locals[5]);f.Pc=1209;continue;}
case 1209:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1214);}
case 1214:{f.Pc=f.Pop().Int==0?1246:1217;continue;}
case 1217:{f.Push(f.Locals[5]);f.Pc=1219;continue;}
case 1219:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1224);}
case 1224:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1227;continue;}
case 1227:{f.Locals[6]=f.Pop();f.Pc=1229;continue;}
case 1229:{f.Push(f.Locals[0]);f.Pc=1230;continue;}
case 1230:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1233;continue;}
case 1233:{f.Push(f.Locals[6]);f.Pc=1235;continue;}
case 1235:{f.Push(f.Locals[0]);f.Pc=1236;continue;}
case 1236:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=1239;continue;}
case 1239:{f.Push(JValue.I(1));f.Pc=1240;continue;}
case 1240:{return rt.Call(f,"forge/game/combat/CombatUtil","checkDeclaredAttacker","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/combat/Combat;Z)V","invokestatic",1243);}
case 1243:{f.Pc=1207;continue;}
case 1246:{f.Push(f.Locals[0]);f.Pc=1247;continue;}
case 1247:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1250;continue;}
case 1250:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1253);}
case 1253:{return rt.Call(f,"forge/game/trigger/TriggerHandler","resetActiveTriggers","()V","invokevirtual",1256);}
case 1256:{f.Push(f.Locals[0]);f.Pc=1257;continue;}
case 1257:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1260;continue;}
case 1260:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",1263);}
case 1263:{f.Push(f.Locals[0]);f.Pc=1264;continue;}
case 1264:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1267;continue;}
case 1267:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=1270;continue;}
case 1270:{f.StackOp("dup");f.Pc=1271;continue;}
case 1271:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",1274);}
case 1274:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1277);}
case 1277:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7889(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getDeclaresBlockers","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/player/Player;Lforge/game/combat/Combat;)Z","invokestatic",20);}
case 20:{f.Pc=f.Pop().Int==0?102:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",27);}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",38);}
case 38:{f.StackOp("pop");f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",46);}
case 46:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","DeclareBlocker","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","DeclareBlocker","Lforge/game/replacement/ReplacementType;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",53);}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=60;continue;}
case 60:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?102:63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/Game","getUndoManager","()Lforge/game/undo/UndoManager;","invokevirtual",70);}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/undo/UndoManager","isOwner","(Lforge/game/player/Player;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int!=0?90:77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/Game","getUndoManager","()Lforge/game/undo/UndoManager;","invokevirtual",84);}
case 84:{f.Push(JValue.R(rt.String("Opponent declared blockers")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/undo/UndoManager","barrier","(Ljava/lang/String;)V","invokevirtual",90);}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",94);}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/player/PlayerController","declareBlockers","(Lforge/game/player/Player;Lforge/game/combat/Combat;)V","invokevirtual",102);}
case 102:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7890(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",21);}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/combat/Combat","isPlayerAttacked","(Lforge/game/player/Player;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?726:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?44:41;continue;}
case 41:{f.Pc=726;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/player/Player","getSharedTeam","()Lforge/game/player/PlayerCollection;","invokevirtual",48);}
case 48:{f.Locals[3]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/player/PlayerCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",59);}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int==0?103:71;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",78);}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{f.Locals[6]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[6]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/phase/PhaseHandler","declareBlockersFor","(Lforge/game/player/Player;)V","invokevirtual",89);}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?100:99;continue;}
case 99:{return JStep.ReturnVoid;}
case 100:{f.Pc=61;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",107);}
case 107:{f.Push(JValue.I(1));f.Pc=108;continue;}
case 108:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?122:111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/combat/CombatUtil","validateTeamBlock","(Lforge/game/combat/Combat;Lforge/game/player/Player;)Ljava/lang/String;","invokestatic",119);}
case 119:{f.Pc=123;continue;}
case 122:{f.Push(JValue.R(null));f.Pc=123;continue;}
case 123:{f.Locals[4]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[4]);f.Pc=127;continue;}
case 127:{f.Pc=f.Pop().Reference==null?184:130;continue;}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",134);}
case 134:{f.Locals[5]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[5]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",143);}
case 143:{f.Pc=f.Pop().Int==0?184:146;continue;}
case 146:{f.Push(f.Locals[5]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",153);}
case 153:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=156;continue;}
case 156:{f.Locals[6]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[6]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/player/Player","getDeclaresBlockers","()Lforge/game/player/Player;","invokevirtual",163);}
case 163:{f.Push(f.Locals[6]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",168);}
case 168:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",174);}
case 174:{f.Push(JValue.R(null));f.Pc=175;continue;}
case 175:{f.Push(JValue.R(null));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[4]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/player/PlayerController","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;)V","invokevirtual",181);}
case 181:{f.Pc=136;continue;}
case 184:{f.Push(f.Locals[4]);f.Pc=186;continue;}
case 186:{f.Pc=f.Pop().Reference!=null?55:189;continue;}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/combat/Combat","getAllBlockers","()Lforge/game/card/CardCollection;","invokevirtual",196);}
case 196:{f.Push(f.Locals[3]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/util/collect/FCollectionView;)Lforge/game/card/CardCollection;","invokestatic",200);}
case 200:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",203);}
case 203:{f.Locals[5]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[5]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",212);}
case 212:{f.Pc=f.Pop().Int==0?304:215;continue;}
case 215:{f.Push(f.Locals[5]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",222);}
case 222:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=225;continue;}
case 225:{f.Locals[6]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[0]);f.Pc=228;continue;}
case 228:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=231;continue;}
case 231:{f.Push(f.Locals[6]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",236);}
case 236:{f.Locals[7]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[7]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",245);}
case 245:{f.Locals[8]=f.Pop();f.Pc=247;continue;}
case 247:{f.Push(f.Locals[8]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",254);}
case 254:{f.Pc=f.Pop().Int==0?301:257;continue;}
case 257:{f.Push(f.Locals[8]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",264);}
case 264:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=267;continue;}
case 267:{f.Locals[9]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[0]);f.Pc=270;continue;}
case 270:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=273;continue;}
case 273:{f.Push(f.Locals[6]);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[9]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/combat/CombatUtil","payRequiredBlockCosts","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",280);}
case 280:{f.Locals[10]=f.Pop();f.Pc=282;continue;}
case 282:{f.Push(f.Locals[10]);f.Pc=284;continue;}
case 284:{f.Pc=f.Pop().Int!=0?298:287;continue;}
case 287:{f.Push(f.Locals[0]);f.Pc=288;continue;}
case 288:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=291;continue;}
case 291:{f.Push(f.Locals[9]);f.Pc=293;continue;}
case 293:{f.Push(f.Locals[6]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/combat/Combat","removeBlockAssignment","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",298);}
case 298:{f.Pc=247;continue;}
case 301:{f.Pc=205;continue;}
case 304:{f.Push(JValue.I(1));f.Pc=305;continue;}
case 305:{f.Locals[5]=f.Pop();f.Pc=307;continue;}
case 307:{f.Push(f.Locals[0]);f.Pc=308;continue;}
case 308:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/combat/Combat","getAllBlockers","()Lforge/game/card/CardCollection;","invokevirtual",314);}
case 314:{f.Push(f.Locals[3]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/util/collect/FCollectionView;)Lforge/game/card/CardCollection;","invokestatic",318);}
case 318:{f.Locals[6]=f.Pop();f.Pc=320;continue;}
case 320:{f.Push(f.Locals[6]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",327);}
case 327:{f.Locals[7]=f.Pop();f.Pc=329;continue;}
case 329:{f.Push(f.Locals[7]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",336);}
case 336:{f.Pc=f.Pop().Int==0?524:339;continue;}
case 339:{f.Push(f.Locals[7]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",346);}
case 346:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=349;continue;}
case 349:{f.Locals[8]=f.Pop();f.Pc=351;continue;}
case 351:{f.Push(JValue.I(0));f.Pc=352;continue;}
case 352:{f.Locals[9]=f.Pop();f.Pc=354;continue;}
case 354:{f.Push(f.Locals[8]);f.Pc=356;continue;}
case 356:{f.Push(JValue.R(rt.String("CARDNAME can't attack or block alone.")));f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",362);}
case 362:{f.Pc=f.Pop().Int!=0?376:365;continue;}
case 365:{f.Push(f.Locals[8]);f.Pc=367;continue;}
case 367:{f.Push(JValue.R(rt.String("CARDNAME can't block alone.")));f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",373);}
case 373:{f.Pc=f.Pop().Int==0?380:376;continue;}
case 376:{f.Push(JValue.I(1));f.Pc=377;continue;}
case 377:{f.Pc=381;continue;}
case 380:{f.Push(JValue.I(0));f.Pc=381;continue;}
case 381:{f.Locals[10]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(f.Locals[6]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",390);}
case 390:{f.Push(JValue.I(2));f.Pc=391;continue;}
case 391:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?405:394;continue;}
case 394:{f.Push(f.Locals[10]);f.Pc=396;continue;}
case 396:{f.Pc=f.Pop().Int==0?405:399;continue;}
case 399:{f.Push(JValue.I(1));f.Pc=400;continue;}
case 400:{f.Locals[9]=f.Pop();f.Pc=402;continue;}
case 402:{f.Pc=504;continue;}
case 405:{f.Push(f.Locals[6]);f.Pc=407;continue;}
case 407:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",412);}
case 412:{f.Push(JValue.I(3));f.Pc=413;continue;}
case 413:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?433:416;continue;}
case 416:{f.Push(f.Locals[8]);f.Pc=418;continue;}
case 418:{f.Push(JValue.R(rt.String("CARDNAME can't block unless at least two other creatures block.")));f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",424);}
case 424:{f.Pc=f.Pop().Int==0?433:427;continue;}
case 427:{f.Push(JValue.I(1));f.Pc=428;continue;}
case 428:{f.Locals[9]=f.Pop();f.Pc=430;continue;}
case 430:{f.Pc=504;continue;}
case 433:{f.Push(f.Locals[8]);f.Pc=435;continue;}
case 435:{f.Push(JValue.R(rt.String("CARDNAME can't block unless a creature with greater power also blocks.")));f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",441);}
case 441:{f.Pc=f.Pop().Int==0?504:444;continue;}
case 444:{f.Push(JValue.I(1));f.Pc=445;continue;}
case 445:{f.Locals[9]=f.Pop();f.Pc=447;continue;}
case 447:{f.Push(f.Locals[8]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",452);}
case 452:{f.Locals[11]=f.Pop();f.Pc=454;continue;}
case 454:{f.Push(f.Locals[6]);f.Pc=456;continue;}
case 456:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",461);}
case 461:{f.Locals[12]=f.Pop();f.Pc=463;continue;}
case 463:{f.Push(f.Locals[12]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",470);}
case 470:{f.Pc=f.Pop().Int==0?504:473;continue;}
case 473:{f.Push(f.Locals[12]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",480);}
case 480:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=483;continue;}
case 483:{f.Locals[13]=f.Pop();f.Pc=485;continue;}
case 485:{f.Push(f.Locals[13]);f.Pc=487;continue;}
case 487:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",490);}
case 490:{f.Push(f.Locals[11]);f.Pc=492;continue;}
case 492:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?501:495;continue;}
case 495:{f.Push(JValue.I(0));f.Pc=496;continue;}
case 496:{f.Locals[9]=f.Pop();f.Pc=498;continue;}
case 498:{f.Pc=504;continue;}
case 501:{f.Pc=463;continue;}
case 504:{f.Push(f.Locals[9]);f.Pc=506;continue;}
case 506:{f.Pc=f.Pop().Int==0?521:509;continue;}
case 509:{f.Push(f.Locals[0]);f.Pc=510;continue;}
case 510:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=513;continue;}
case 513:{f.Push(f.Locals[8]);f.Pc=515;continue;}
case 515:{return rt.Call(f,"forge/game/combat/Combat","undoBlockingAssignment","(Lforge/game/card/Card;)V","invokevirtual",518);}
case 518:{f.Push(JValue.I(0));f.Pc=519;continue;}
case 519:{f.Locals[5]=f.Pop();f.Pc=521;continue;}
case 521:{f.Pc=329;continue;}
case 524:{f.Push(f.Locals[5]);f.Pc=526;continue;}
case 526:{f.Pc=f.Pop().Int==0?304:529;continue;}
case 529:{f.Push(f.Locals[3]);f.Pc=530;continue;}
case 530:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",533);}
case 533:{f.Locals[6]=f.Pop();f.Pc=535;continue;}
case 535:{f.Push(f.Locals[6]);f.Pc=537;continue;}
case 537:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",542);}
case 542:{f.Pc=f.Pop().Int==0?726:545;continue;}
case 545:{f.Push(f.Locals[6]);f.Pc=547;continue;}
case 547:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",552);}
case 552:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=555;continue;}
case 555:{f.Locals[7]=f.Pop();f.Pc=557;continue;}
case 557:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",560);}
case 560:{f.Locals[8]=f.Pop();f.Pc=562;continue;}
case 562:{f.Push(f.Locals[0]);f.Pc=563;continue;}
case 563:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=566;continue;}
case 566:{f.Push(f.Locals[7]);f.Pc=568;continue;}
case 568:{return rt.Call(f,"forge/game/combat/Combat","getDefendersControlledBy","(Lforge/game/player/Player;)Lforge/util/collect/FCollection;","invokevirtual",571);}
case 571:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",574);}
case 574:{f.Locals[9]=f.Pop();f.Pc=576;continue;}
case 576:{f.Push(f.Locals[9]);f.Pc=578;continue;}
case 578:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",583);}
case 583:{f.Pc=f.Pop().Int==0?705:586;continue;}
case 586:{f.Push(f.Locals[9]);f.Pc=588;continue;}
case 588:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",593);}
case 593:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=596;continue;}
case 596:{f.Locals[10]=f.Pop();f.Pc=598;continue;}
case 598:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","hashKeys","()Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",601);}
case 601:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","arrayListValues","()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;","invokevirtual",604);}
case 604:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$ListMultimapBuilder","build","()Lcom/google/common/collect/ListMultimap;","invokevirtual",607);}
case 607:{f.Locals[11]=f.Pop();f.Pc=609;continue;}
case 609:{f.Push(f.Locals[0]);f.Pc=610;continue;}
case 610:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=613;continue;}
case 613:{f.Push(f.Locals[10]);f.Pc=615;continue;}
case 615:{return rt.Call(f,"forge/game/combat/Combat","getAttackersOf","(Lforge/game/GameEntity;)Lforge/game/card/CardCollection;","invokevirtual",618);}
case 618:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",621);}
case 621:{f.Locals[12]=f.Pop();f.Pc=623;continue;}
case 623:{f.Push(f.Locals[12]);f.Pc=625;continue;}
case 625:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",630);}
case 630:{f.Pc=f.Pop().Int==0?690:633;continue;}
case 633:{f.Push(f.Locals[12]);f.Pc=635;continue;}
case 635:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",640);}
case 640:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=643;continue;}
case 643:{f.Locals[13]=f.Pop();f.Pc=645;continue;}
case 645:{f.Push(f.Locals[11]);f.Pc=647;continue;}
case 647:{f.Push(f.Locals[13]);f.Pc=649;continue;}
case 649:{f.Push(f.Locals[0]);f.Pc=650;continue;}
case 650:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=653;continue;}
case 653:{f.Push(f.Locals[13]);f.Pc=655;continue;}
case 655:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",658);}
case 658:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",661);}
case 661:{f.Pc=f.Pop().Int==0?672:664;continue;}
case 664:{f.Push(f.Locals[13]);f.Pc=666;continue;}
case 666:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",669);}
case 669:{f.Pc=681;continue;}
case 672:{f.Push(f.Locals[0]);f.Pc=673;continue;}
case 673:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=676;continue;}
case 676:{f.Push(f.Locals[13]);f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",681);}
case 681:{return rt.Call(f,"com/google/common/collect/Multimap","putAll","(Ljava/lang/Object;Ljava/lang/Iterable;)Z","invokeinterface",686);}
case 686:{f.StackOp("pop");f.Pc=687;continue;}
case 687:{f.Pc=623;continue;}
case 690:{f.Push(f.Locals[8]);f.Pc=692;continue;}
case 692:{f.Push(f.Locals[10]);f.Pc=694;continue;}
case 694:{f.Push(f.Locals[11]);f.Pc=696;continue;}
case 696:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",701);}
case 701:{f.StackOp("pop");f.Pc=702;continue;}
case 702:{f.Pc=576;continue;}
case 705:{f.Push(f.Locals[0]);f.Pc=706;continue;}
case 706:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=709;continue;}
case 709:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventBlockersDeclared"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventBlockersDeclared")));f.Pc=712;continue;}
case 712:{f.StackOp("dup");f.Pc=713;continue;}
case 713:{f.Push(f.Locals[7]);f.Pc=715;continue;}
case 715:{f.Push(f.Locals[8]);f.Pc=717;continue;}
case 717:{return rt.Call(f,"forge/game/event/GameEventBlockersDeclared","<init>","(Lforge/game/player/Player;Ljava/util/Map;)V","invokespecial",720);}
case 720:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",723);}
case 723:{f.Pc=535;continue;}
case 726:{f.Push(f.Locals[1]);f.Pc=727;continue;}
case 727:{f.Push(f.Locals[0]);f.Pc=728;continue;}
case 728:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=731;continue;}
case 731:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?13:734;continue;}
case 734:{f.Push(f.Locals[0]);f.Pc=735;continue;}
case 735:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=738;continue;}
case 738:{return rt.Call(f,"forge/game/combat/Combat","orderBlockersForDamageAssignment","()V","invokevirtual",741);}
case 741:{f.Push(f.Locals[0]);f.Pc=742;continue;}
case 742:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=745;continue;}
case 745:{return rt.Call(f,"forge/game/combat/Combat","orderAttackersForDamageAssignment","()V","invokevirtual",748);}
case 748:{f.Push(f.Locals[0]);f.Pc=749;continue;}
case 749:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=752;continue;}
case 752:{return rt.Call(f,"forge/game/combat/Combat","removeAbsentCombatants","()Z","invokevirtual",755);}
case 755:{f.StackOp("pop");f.Pc=756;continue;}
case 756:{f.Push(f.Locals[0]);f.Pc=757;continue;}
case 757:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=760;continue;}
case 760:{f.Push(f.Locals[0]);f.Pc=761;continue;}
case 761:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=764;continue;}
case 764:{return rt.Call(f,"forge/game/combat/Combat","fireTriggersForUnblockedAttackers","(Lforge/game/Game;)V","invokevirtual",767);}
case 767:{f.Push(f.Locals[0]);f.Pc=768;continue;}
case 768:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=771;continue;}
case 771:{return rt.Call(f,"forge/game/combat/Combat","getAllBlockers","()Lforge/game/card/CardCollection;","invokevirtual",774);}
case 774:{f.Locals[3]=f.Pop();f.Pc=775;continue;}
case 775:{f.Push(f.Locals[3]);f.Pc=776;continue;}
case 776:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",781);}
case 781:{f.Pc=f.Pop().Int!=0?929:784;continue;}
case 784:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",787);}
case 787:{f.Locals[4]=f.Pop();f.Pc=789;continue;}
case 789:{f.Push(f.Locals[3]);f.Pc=790;continue;}
case 790:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",795);}
case 795:{f.Locals[5]=f.Pop();f.Pc=797;continue;}
case 797:{f.Push(f.Locals[5]);f.Pc=799;continue;}
case 799:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",804);}
case 804:{f.Pc=f.Pop().Int==0?883:807;continue;}
case 807:{f.Push(f.Locals[5]);f.Pc=809;continue;}
case 809:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",814);}
case 814:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=817;continue;}
case 817:{f.Locals[6]=f.Pop();f.Pc=819;continue;}
case 819:{f.Push(f.Locals[0]);f.Pc=820;continue;}
case 820:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=823;continue;}
case 823:{f.Push(f.Locals[6]);f.Pc=825;continue;}
case 825:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",828);}
case 828:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",831);}
case 831:{f.Locals[7]=f.Pop();f.Pc=833;continue;}
case 833:{f.Push(f.Locals[7]);f.Pc=835;continue;}
case 835:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",840);}
case 840:{f.Pc=f.Pop().Int==0?880:843;continue;}
case 843:{f.Push(f.Locals[7]);f.Pc=845;continue;}
case 845:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",850);}
case 850:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=853;continue;}
case 853:{f.Locals[8]=f.Pop();f.Pc=855;continue;}
case 855:{f.Push(f.Locals[4]);f.Pc=857;continue;}
case 857:{f.Push(f.Locals[8]);f.Pc=859;continue;}
case 859:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",864);}
case 864:{f.Pc=f.Pop().Int!=0?877:867;continue;}
case 867:{f.Push(f.Locals[4]);f.Pc=869;continue;}
case 869:{f.Push(f.Locals[8]);f.Pc=871;continue;}
case 871:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",876);}
case 876:{f.StackOp("pop");f.Pc=877;continue;}
case 877:{f.Pc=833;continue;}
case 880:{f.Pc=797;continue;}
case 883:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",886);}
case 886:{f.Locals[5]=f.Pop();f.Pc=888;continue;}
case 888:{f.Push(f.Locals[5]);f.Pc=890;continue;}
case 890:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Blockers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Blockers","Lforge/game/ability/AbilityKey;"));f.Pc=893;continue;}
case 893:{f.Push(f.Locals[3]);f.Pc=894;continue;}
case 894:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",899);}
case 899:{f.StackOp("pop");f.Pc=900;continue;}
case 900:{f.Push(f.Locals[5]);f.Pc=902;continue;}
case 902:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=905;continue;}
case 905:{f.Push(f.Locals[4]);f.Pc=907;continue;}
case 907:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",912);}
case 912:{f.StackOp("pop");f.Pc=913;continue;}
case 913:{f.Push(f.Locals[0]);f.Pc=914;continue;}
case 914:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=917;continue;}
case 917:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",920);}
case 920:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","BlockersDeclared","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","BlockersDeclared","Lforge/game/trigger/TriggerType;"));f.Pc=923;continue;}
case 923:{f.Push(f.Locals[5]);f.Pc=925;continue;}
case 925:{f.Push(JValue.I(0));f.Pc=926;continue;}
case 926:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",929);}
case 929:{f.Push(f.Locals[0]);f.Pc=930;continue;}
case 930:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=933;continue;}
case 933:{return rt.Call(f,"forge/game/combat/Combat","getAllBlockers","()Lforge/game/card/CardCollection;","invokevirtual",936);}
case 936:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",939);}
case 939:{f.Locals[4]=f.Pop();f.Pc=941;continue;}
case 941:{f.Push(f.Locals[4]);f.Pc=943;continue;}
case 943:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",948);}
case 948:{f.Pc=f.Pop().Int==0?1051:951;continue;}
case 951:{f.Push(f.Locals[4]);f.Pc=953;continue;}
case 953:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",958);}
case 958:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=961;continue;}
case 961:{f.Locals[5]=f.Pop();f.Pc=963;continue;}
case 963:{f.Push(f.Locals[5]);f.Pc=965;continue;}
case 965:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",968);}
case 968:{return rt.Call(f,"forge/game/card/CardDamageHistory","getCreatureBlockedThisCombat","()Z","invokevirtual",971);}
case 971:{f.Pc=f.Pop().Int==0?977:974;continue;}
case 974:{f.Pc=941;continue;}
case 977:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",980);}
case 980:{f.Locals[6]=f.Pop();f.Pc=982;continue;}
case 982:{f.Push(f.Locals[6]);f.Pc=984;continue;}
case 984:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"));f.Pc=987;continue;}
case 987:{f.Push(f.Locals[5]);f.Pc=989;continue;}
case 989:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",994);}
case 994:{f.StackOp("pop");f.Pc=995;continue;}
case 995:{f.Push(f.Locals[6]);f.Pc=997;continue;}
case 997:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=1000;continue;}
case 1000:{f.Push(f.Locals[0]);f.Pc=1001;continue;}
case 1001:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=1004;continue;}
case 1004:{f.Push(f.Locals[5]);f.Pc=1006;continue;}
case 1006:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",1009);}
case 1009:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1014);}
case 1014:{f.StackOp("pop");f.Pc=1015;continue;}
case 1015:{f.Push(f.Locals[0]);f.Pc=1016;continue;}
case 1016:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1019;continue;}
case 1019:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1022);}
case 1022:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Blocks","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Blocks","Lforge/game/trigger/TriggerType;"));f.Pc=1025;continue;}
case 1025:{f.Push(f.Locals[6]);f.Pc=1027;continue;}
case 1027:{f.Push(JValue.I(0));f.Pc=1028;continue;}
case 1028:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1031);}
case 1031:{f.Push(f.Locals[5]);f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",1036);}
case 1036:{f.Push(JValue.I(1));f.Pc=1037;continue;}
case 1037:{return rt.Call(f,"forge/game/card/CardDamageHistory","setCreatureBlockedThisCombat","(Z)V","invokevirtual",1040);}
case 1040:{f.Push(f.Locals[5]);f.Pc=1042;continue;}
case 1042:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",1045);}
case 1045:{return rt.Call(f,"forge/game/card/CardDamageHistory","clearNotBlockedSinceLastUpkeepOf","()V","invokevirtual",1048);}
case 1048:{f.Pc=941;continue;}
case 1051:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",1054);}
case 1054:{f.Locals[4]=f.Pop();f.Pc=1056;continue;}
case 1056:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",1059);}
case 1059:{f.Locals[5]=f.Pop();f.Pc=1061;continue;}
case 1061:{f.Push(f.Locals[0]);f.Pc=1062;continue;}
case 1062:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=1065;continue;}
case 1065:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",1068);}
case 1068:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1071);}
case 1071:{f.Locals[6]=f.Pop();f.Pc=1073;continue;}
case 1073:{f.Push(f.Locals[6]);f.Pc=1075;continue;}
case 1075:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1080);}
case 1080:{f.Pc=f.Pop().Int==0?1353:1083;continue;}
case 1083:{f.Push(f.Locals[6]);f.Pc=1085;continue;}
case 1085:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1090);}
case 1090:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1093;continue;}
case 1093:{f.Locals[7]=f.Pop();f.Pc=1095;continue;}
case 1095:{f.Push(f.Locals[0]);f.Pc=1096;continue;}
case 1096:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=1099;continue;}
case 1099:{f.Push(f.Locals[7]);f.Pc=1101;continue;}
case 1101:{return rt.Call(f,"forge/game/combat/Combat","isBlocked","(Lforge/game/card/Card;)Z","invokevirtual",1104);}
case 1104:{f.Pc=f.Pop().Int==0?1115:1107;continue;}
case 1107:{f.Push(f.Locals[7]);f.Pc=1109;continue;}
case 1109:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",1112);}
case 1112:{return rt.Call(f,"forge/game/card/CardDamageHistory","clearNotBeenBlockedSinceLastUpkeepOf","()V","invokevirtual",1115);}
case 1115:{f.Push(f.Locals[0]);f.Pc=1116;continue;}
case 1116:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=1119;continue;}
case 1119:{f.Push(f.Locals[7]);f.Pc=1121;continue;}
case 1121:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",1124);}
case 1124:{f.Locals[8]=f.Pop();f.Pc=1126;continue;}
case 1126:{f.Push(f.Locals[8]);f.Pc=1128;continue;}
case 1128:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1133);}
case 1133:{f.Pc=f.Pop().Int==0?1139:1136;continue;}
case 1136:{f.Pc=1073;continue;}
case 1139:{f.Push(f.Locals[4]);f.Pc=1141;continue;}
case 1141:{f.Push(f.Locals[7]);f.Pc=1143;continue;}
case 1143:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1148);}
case 1148:{f.StackOp("pop");f.Pc=1149;continue;}
case 1149:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1152);}
case 1152:{f.Locals[9]=f.Pop();f.Pc=1154;continue;}
case 1154:{f.Push(f.Locals[9]);f.Pc=1156;continue;}
case 1156:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=1159;continue;}
case 1159:{f.Push(f.Locals[7]);f.Pc=1161;continue;}
case 1161:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1166);}
case 1166:{f.StackOp("pop");f.Pc=1167;continue;}
case 1167:{f.Push(f.Locals[9]);f.Pc=1169;continue;}
case 1169:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Blockers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Blockers","Lforge/game/ability/AbilityKey;"));f.Pc=1172;continue;}
case 1172:{f.Push(f.Locals[8]);f.Pc=1174;continue;}
case 1174:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1179);}
case 1179:{f.StackOp("pop");f.Pc=1180;continue;}
case 1180:{f.Push(f.Locals[9]);f.Pc=1182;continue;}
case 1182:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Defender","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Defender","Lforge/game/ability/AbilityKey;"));f.Pc=1185;continue;}
case 1185:{f.Push(f.Locals[0]);f.Pc=1186;continue;}
case 1186:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=1189;continue;}
case 1189:{f.Push(f.Locals[7]);f.Pc=1191;continue;}
case 1191:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",1194);}
case 1194:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1199);}
case 1199:{f.StackOp("pop");f.Pc=1200;continue;}
case 1200:{f.Push(f.Locals[9]);f.Pc=1202;continue;}
case 1202:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=1205;continue;}
case 1205:{f.Push(f.Locals[0]);f.Pc=1206;continue;}
case 1206:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=1209;continue;}
case 1209:{f.Push(f.Locals[7]);f.Pc=1211;continue;}
case 1211:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",1214);}
case 1214:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1219);}
case 1219:{f.StackOp("pop");f.Pc=1220;continue;}
case 1220:{f.Push(f.Locals[0]);f.Pc=1221;continue;}
case 1221:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1224;continue;}
case 1224:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1227);}
case 1227:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackerBlocked","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackerBlocked","Lforge/game/trigger/TriggerType;"));f.Pc=1230;continue;}
case 1230:{f.Push(f.Locals[9]);f.Pc=1232;continue;}
case 1232:{f.Push(JValue.I(0));f.Pc=1233;continue;}
case 1233:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1236);}
case 1236:{f.Push(f.Locals[8]);f.Pc=1238;continue;}
case 1238:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1243);}
case 1243:{f.Locals[9]=f.Pop();f.Pc=1245;continue;}
case 1245:{f.Push(f.Locals[9]);f.Pc=1247;continue;}
case 1247:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1252);}
case 1252:{f.Pc=f.Pop().Int==0?1341:1255;continue;}
case 1255:{f.Push(f.Locals[9]);f.Pc=1257;continue;}
case 1257:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1262);}
case 1262:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1265;continue;}
case 1265:{f.Locals[10]=f.Pop();f.Pc=1267;continue;}
case 1267:{f.Push(f.Locals[10]);f.Pc=1269;continue;}
case 1269:{f.Push(f.Locals[7]);f.Pc=1271;continue;}
case 1271:{f.Push(f.Locals[5]);f.Pc=1273;continue;}
case 1273:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;Ljava/util/Map;)Lforge/game/card/Card;","invokestatic",1276);}
case 1276:{return rt.Call(f,"forge/game/card/Card","addBlockedThisTurn","(Lforge/game/card/Card;)V","invokevirtual",1279);}
case 1279:{f.Push(f.Locals[7]);f.Pc=1281;continue;}
case 1281:{f.Push(f.Locals[10]);f.Pc=1283;continue;}
case 1283:{f.Push(f.Locals[5]);f.Pc=1285;continue;}
case 1285:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;Ljava/util/Map;)Lforge/game/card/Card;","invokestatic",1288);}
case 1288:{return rt.Call(f,"forge/game/card/Card","addBlockedByThisTurn","(Lforge/game/card/Card;)V","invokevirtual",1291);}
case 1291:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1294);}
case 1294:{f.Locals[11]=f.Pop();f.Pc=1296;continue;}
case 1296:{f.Push(f.Locals[11]);f.Pc=1298;continue;}
case 1298:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=1301;continue;}
case 1301:{f.Push(f.Locals[7]);f.Pc=1303;continue;}
case 1303:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1308);}
case 1308:{f.StackOp("pop");f.Pc=1309;continue;}
case 1309:{f.Push(f.Locals[11]);f.Pc=1311;continue;}
case 1311:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"));f.Pc=1314;continue;}
case 1314:{f.Push(f.Locals[10]);f.Pc=1316;continue;}
case 1316:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1321);}
case 1321:{f.StackOp("pop");f.Pc=1322;continue;}
case 1322:{f.Push(f.Locals[0]);f.Pc=1323;continue;}
case 1323:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1326;continue;}
case 1326:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1329);}
case 1329:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackerBlockedByCreature","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackerBlockedByCreature","Lforge/game/trigger/TriggerType;"));f.Pc=1332;continue;}
case 1332:{f.Push(f.Locals[11]);f.Pc=1334;continue;}
case 1334:{f.Push(JValue.I(0));f.Pc=1335;continue;}
case 1335:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1338);}
case 1338:{f.Pc=1245;continue;}
case 1341:{f.Push(f.Locals[7]);f.Pc=1343;continue;}
case 1343:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",1346);}
case 1346:{f.Push(JValue.I(1));f.Pc=1347;continue;}
case 1347:{return rt.Call(f,"forge/game/card/CardDamageHistory","setCreatureGotBlockedThisCombat","(Z)V","invokevirtual",1350);}
case 1350:{f.Pc=1073;continue;}
case 1353:{f.Push(f.Locals[4]);f.Pc=1355;continue;}
case 1355:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1360);}
case 1360:{f.Pc=f.Pop().Int!=0?1397:1363;continue;}
case 1363:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1366);}
case 1366:{f.Locals[6]=f.Pop();f.Pc=1368;continue;}
case 1368:{f.Push(f.Locals[6]);f.Pc=1370;continue;}
case 1370:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=1373;continue;}
case 1373:{f.Push(f.Locals[4]);f.Pc=1375;continue;}
case 1375:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1380);}
case 1380:{f.StackOp("pop");f.Pc=1381;continue;}
case 1381:{f.Push(f.Locals[0]);f.Pc=1382;continue;}
case 1382:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1385;continue;}
case 1385:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1388);}
case 1388:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackerBlockedOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackerBlockedOnce","Lforge/game/trigger/TriggerType;"));f.Pc=1391;continue;}
case 1391:{f.Push(f.Locals[6]);f.Pc=1393;continue;}
case 1393:{f.Push(JValue.I(0));f.Pc=1394;continue;}
case 1394:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1397);}
case 1397:{f.Push(f.Locals[0]);f.Pc=1398;continue;}
case 1398:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1401;continue;}
case 1401:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",1404);}
case 1404:{f.Push(f.Locals[0]);f.Pc=1405;continue;}
case 1405:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=1408;continue;}
case 1408:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=1411;continue;}
case 1411:{f.StackOp("dup");f.Pc=1412;continue;}
case 1412:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",1415);}
case 1415:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1418);}
case 1418:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7891(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Stack","clear","()V","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","turn","I",value);f.Pc=21;continue;}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7892(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/zone/MagicStack","onNextTurn","()V","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearThisTurnDelayedTrigger","()V","invokevirtual",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/phase/PhaseHandler","getNextActivePlayer","()Lforge/game/player/Player;","invokevirtual",24);}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int!=0?40:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/phase/PhaseHandler","getNextActivePlayer","()Lforge/game/player/Player;","invokevirtual",36);}
case 36:{f.Locals[1]=f.Pop();f.Pc=37;continue;}
case 37:{f.Pc=25;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/player/Player","getSharedTeam","()Lforge/game/player/PlayerCollection;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",47);}
case 47:{f.Locals[2]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?81:57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[3]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",74);}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/trigger/TriggerHandler","handlePlayerDefinedDelTriggers","(Lforge/game/player/Player;)V","invokevirtual",78);}
case 78:{f.Pc=48;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=85;continue;}
case 85:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/Game","getCardsIncludePhasingIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",91);}
case 91:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",96);}
case 96:{f.Locals[2]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",103);}
case 103:{f.Pc=f.Pop().Int==0?127:106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{f.Locals[3]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[3]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/card/Card","isUntapped","()Z","invokevirtual",121);}
case 121:{return rt.Call(f,"forge/game/card/Card","setStartedTheTurnUntapped","(Z)V","invokevirtual",124);}
case 124:{f.Pc=97;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/Game","getMonarch","()Lforge/game/player/Player;","invokevirtual",138);}
case 138:{return rt.Call(f,"forge/game/Game","setMonarchBeginTurn","(Lforge/game/player/Player;)V","invokevirtual",141);}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",148);}
case 148:{if(!rt.StaticReady(f,"forge/game/GameType","Planechase","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Planechase","Lforge/game/GameType;"));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/GameRules","hasAppliedVariant","(Lforge/game/GameType;)Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int==0?223:157;continue;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/Game","getActivePlanes","()Ljava/util/List;","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Reference==null?223:167;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/Game","getActivePlanes","()Ljava/util/List;","invokevirtual",174);}
case 174:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",179);}
case 179:{f.Locals[2]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",186);}
case 186:{f.Pc=f.Pop().Int==0?223:189;continue;}
case 189:{f.Push(f.Locals[2]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",195);}
case 195:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=198;continue;}
case 198:{f.Locals[3]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[3]);f.Pc=200;continue;}
case 200:{f.Pc=f.Pop().Reference==null?220:203;continue;}
case 203:{f.Push(f.Locals[3]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[1]);f.Pc=205;continue;}
case 205:{f.Push(JValue.L(0));f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",209);}
case 209:{f.Push(f.Locals[0]);f.Pc=210;continue;}
case 210:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",216);}
case 216:{f.Push(f.Locals[3]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/GameAction","controllerChangeZoneCorrection","(Lforge/game/card/Card;)V","invokevirtual",220);}
case 220:{f.Pc=180;continue;}
case 223:{f.Push(f.Locals[1]);f.Pc=224;continue;}
case 224:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7893(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Stack","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?23:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Stack","pop","()Ljava/lang/Object;","invokevirtual",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/ExtraTurn"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.R(null));f.Pc=24;continue;}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Reference==null?36:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/phase/ExtraTurn","getPlayer","()Lforge/game/player/Player;","invokevirtual",33);}
case 33:{f.Pc=40;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/phase/PhaseHandler","nextTurnLead","()Lforge/game/player/Player;","invokevirtual",40);}
case 40:{f.Locals[2]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Stack","isEmpty","()Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int!=0?55:51;continue;}
case 51:{f.Push(JValue.I(1));f.Pc=52;continue;}
case 52:{f.Pc=56;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{f.Locals[3]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/phase/PhaseHandler","getExtraTurnForPlayer","(Lforge/game/player/Player;)I","invokevirtual",63);}
case 63:{return rt.Call(f,"forge/game/player/Player","setExtraTurnCount","(I)V","invokevirtual",66);}
case 66:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=69;continue;}
case 69:{f.Locals[4]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/player/Player","getSharedTeam","()Lforge/game/player/PlayerCollection;","invokevirtual",75);}
case 75:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",78);}
case 78:{f.Locals[5]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",87);}
case 87:{f.Pc=f.Pop().Int==0?155:90;continue;}
case 90:{f.Push(f.Locals[5]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",97);}
case 97:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=100;continue;}
case 100:{f.Locals[6]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[6]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",107);}
case 107:{f.Locals[7]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[7]);f.Pc=111;continue;}
case 111:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ExtraTurn","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ExtraTurn","Lforge/game/ability/AbilityKey;"));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[3]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",118);}
case 118:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",123);}
case 123:{f.StackOp("pop");f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",131);}
case 131:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","BeginTurn","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","BeginTurn","Lforge/game/replacement/ReplacementType;"));f.Pc=134;continue;}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",139);}
case 139:{f.Locals[4]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=146;continue;}
case 146:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?152:149;continue;}
case 149:{f.Pc=155;continue;}
case 152:{f.Pc=80;continue;}
case 155:{f.Push(f.Locals[4]);f.Pc=157;continue;}
case 157:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=160;continue;}
case 160:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?177:163;continue;}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{f.Pc=f.Pop().Reference!=null?172:167;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[2]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPlayerTurn","(Lforge/game/player/Player;)V","invokevirtual",172);}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/phase/PhaseHandler","getNextActivePlayer","()Lforge/game/player/Player;","invokevirtual",176);}
case 176:{return JStep.Return(f.Pop());}
case 177:{f.Push(f.Locals[2]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[3]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/player/Player","setExtraTurn","(Z)V","invokevirtual",182);}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Pc=f.Pop().Reference==null?268:186;continue;}
case 186:{f.Push(f.Locals[1]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/phase/ExtraTurn","getDelayedTriggers","()Ljava/util/List;","invokevirtual",190);}
case 190:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",195);}
case 195:{f.Locals[5]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[5]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",204);}
case 204:{f.Pc=f.Pop().Int==0?234:207;continue;}
case 207:{f.Push(f.Locals[5]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",214);}
case 214:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=217;continue;}
case 217:{f.Locals[6]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",226);}
case 226:{f.Push(f.Locals[6]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerThisTurnDelayedTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",231);}
case 231:{f.Pc=197;continue;}
case 234:{f.Push(f.Locals[1]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/phase/ExtraTurn","isSkipUntap","()Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int==0?254:241;continue;}
case 241:{f.Push(f.Locals[1]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/phase/ExtraTurn","getSkipUntapSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",245);}
case 245:{f.Push(f.Locals[2]);f.Pc=246;continue;}
case 246:{f.Push(JValue.R(null));f.Pc=247;continue;}
case 247:{f.Push(JValue.R(null));f.Pc=248;continue;}
case 248:{f.Push(JValue.R(rt.String("Untap")));f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/ability/effects/SkipPhaseEffect","createSkipPhaseEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokestatic",254);}
case 254:{f.Push(f.Locals[1]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/phase/ExtraTurn","isCantSetSchemesInMotion","()Z","invokevirtual",258);}
case 258:{f.Pc=f.Pop().Int==0?268:261;continue;}
case 261:{f.Push(f.Locals[1]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/phase/ExtraTurn","getCantSetSchemesInMotionSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",265);}
case 265:{return rt.Call(f,"forge/game/ability/effects/AddTurnEffect","createCantSetSchemesInMotionEffect","(Lforge/game/spellability/SpellAbility;)V","invokestatic",268);}
case 268:{f.Push(f.Locals[2]);f.Pc=269;continue;}
case 269:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7894(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?20:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?20:16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Pc=21;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7895(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7896(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Stack","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?15:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/phase/PhaseHandler","nextTurnLead","()Lforge/game/player/Player;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Stack","peek","()Ljava/lang/Object;","invokevirtual",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/ExtraTurn"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/phase/ExtraTurn","getPlayer","()Lforge/game/player/Player;","invokevirtual",28);}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7897(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Stack","isEmpty","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?34:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"forge/game/phase/ExtraTurn"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/ExtraTurn")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/phase/PhaseHandler","nextTurnLead","()Lforge/game/player/Player;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/phase/ExtraTurn","<init>","(Lforge/game/player/Player;)V","invokespecial",27);}
case 27:{return rt.Call(f,"java/util/Stack","push","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Pc=48;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Stack","peek","()Ljava/lang/Object;","invokevirtual",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/ExtraTurn"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/phase/ExtraTurn","getPlayer","()Lforge/game/player/Player;","invokevirtual",47);}
case 47:{f.Locals[2]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/game/phase/ExtraTurn"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/ExtraTurn")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/phase/PhaseHandler","teamLead","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",61);}
case 61:{return rt.Call(f,"forge/game/phase/ExtraTurn","<init>","(Lforge/game/player/Player;)V","invokespecial",64);}
case 64:{return rt.Call(f,"java/util/Stack","push","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/ExtraTurn"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Locals[3]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",78);}
case 78:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",81);}
case 81:{f.Locals[4]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",90);}
case 90:{f.Pc=f.Pop().Int==0?119:93;continue;}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",100);}
case 100:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=103;continue;}
case 103:{f.Locals[5]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[5]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[5]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/phase/PhaseHandler","getExtraTurnForPlayer","(Lforge/game/player/Player;)I","invokevirtual",113);}
case 113:{return rt.Call(f,"forge/game/player/Player","setExtraTurnCount","(I)V","invokevirtual",116);}
case 116:{f.Pc=83;continue;}
case 119:{f.Push(JValue.I(1));f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.NewArray("Lforge/game/player/Player;",f.Pop().Int)));f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{f.Push(JValue.I(0));f.Pc=125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=127;continue;}
case 127:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",130);}
case 130:{f.Locals[4]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[2]);f.Pc=133;continue;}
case 133:{f.Pc=f.Pop().Reference==null?145:136;continue;}
case 136:{f.Push(f.Locals[4]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[2]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",144);}
case 144:{f.StackOp("pop");f.Pc=145;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=149;continue;}
case 149:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventPlayerStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventPlayerStatsChanged")));f.Pc=152;continue;}
case 152:{f.StackOp("dup");f.Pc=153;continue;}
case 153:{f.Push(f.Locals[4]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/event/GameEventPlayerStatsChanged","<init>","(Ljava/util/Collection;)V","invokespecial",158);}
case 158:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",161);}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7898(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[4]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",11);}
case 11:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?218:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/PhaseType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int!=0?60:41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{if(!rt.EnsureInitialized(f,"java/util/Stack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Stack")));f.Pc=50;continue;}
case 50:{f.StackOp("dup");f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Stack","<init>","()V","invokespecial",54);}
case 54:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",68);}
case 68:{f.Push(JValue.I(1));f.Pc=69;continue;}
case 69:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=70;continue;}
case 70:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?114:73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",84);}
case 84:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Stack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=87;continue;}
case 87:{if(!rt.EnsureInitialized(f,"forge/game/phase/ExtraPhase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/ExtraPhase")));f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{f.Push(JValue.I(1));f.Pc=95;continue;}
case 95:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",101);}
case 101:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/PhaseType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/phase/ExtraPhase","<init>","(Lforge/game/phase/PhaseType;)V","invokespecial",107);}
case 107:{return rt.Call(f,"java/util/Stack","push","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{f.Pc=212;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",124);}
case 124:{f.Pc=f.Pop().Int==0?186:127;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",137);}
case 137:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Stack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Stack","isEmpty","()Z","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Int!=0?186:146;continue;}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=150;continue;}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",157);}
case 157:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Stack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=164;continue;}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",170);}
case 170:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Stack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/Stack","pop","()Ljava/lang/Object;","invokevirtual",176);}
case 176:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/ExtraPhase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/util/Stack","push","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",182);}
case 182:{f.StackOp("pop");f.Pc=183;continue;}
case 183:{f.Pc=212;continue;}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=190;continue;}
case 190:{f.Push(f.Locals[5]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",197);}
case 197:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Stack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=200;continue;}
case 200:{if(!rt.EnsureInitialized(f,"forge/game/phase/ExtraPhase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/ExtraPhase")));f.Pc=203;continue;}
case 203:{f.StackOp("dup");f.Pc=204;continue;}
case 204:{f.Push(f.Locals[3]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/phase/ExtraPhase","<init>","(Lforge/game/phase/PhaseType;)V","invokespecial",208);}
case 208:{return rt.Call(f,"java/util/Stack","push","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",211);}
case 211:{f.StackOp("pop");f.Pc=212;continue;}
case 212:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=215;continue;}
case 215:{f.Pc=3;continue;}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=222;continue;}
case 222:{f.Push(f.Locals[1]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",228);}
case 228:{f.Pc=f.Pop().Int!=0?249:231;continue;}
case 231:{f.Push(f.Locals[0]);f.Pc=232;continue;}
case 232:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=235;continue;}
case 235:{f.Push(f.Locals[1]);f.Pc=236;continue;}
case 236:{if(!rt.EnsureInitialized(f,"java/util/Stack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Stack")));f.Pc=239;continue;}
case 239:{f.StackOp("dup");f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/Stack","<init>","()V","invokespecial",243);}
case 243:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",248);}
case 248:{f.StackOp("pop");f.Pc=249;continue;}
case 249:{f.Push(f.Locals[0]);f.Pc=250;continue;}
case 250:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=253;continue;}
case 253:{f.Push(f.Locals[1]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",259);}
case 259:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Stack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=262;continue;}
case 262:{if(!rt.EnsureInitialized(f,"forge/game/phase/ExtraPhase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/ExtraPhase")));f.Pc=265;continue;}
case 265:{f.StackOp("dup");f.Pc=266;continue;}
case 266:{f.Push(f.Locals[2]);f.Pc=267;continue;}
case 267:{f.Push(JValue.I(0));f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",273);}
case 273:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/PhaseType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/phase/ExtraPhase","<init>","(Lforge/game/phase/PhaseType;)V","invokespecial",279);}
case 279:{return rt.Call(f,"java/util/Stack","push","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",282);}
case 282:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/ExtraPhase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=285;continue;}
case 285:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7899(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Stack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference==null?43:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Stack","isEmpty","()Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int!=0?43:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Stack","peek","()Ljava/lang/Object;","invokevirtual",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/ExtraPhase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/phase/ExtraPhase","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",35);}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?43:39;continue;}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{f.Pc=44;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7900(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nCombatsThisTurn","I"));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7901(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nCombatsThisTurn","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7902(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nUpkeepsThisTurn","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7903(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/phase/PhaseHandler","is","(Lforge/game/phase/PhaseType;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?21:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nUpkeepsThisTurn","I"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int!=0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7904(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/phase/PhaseHandler","is","(Lforge/game/phase/PhaseType;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?21:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nUpkeepsThisGame","I"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int!=0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7905(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nMainsThisTurn","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7906(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nMainsThisTurn","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/phase/PhaseHandler","is","(Lforge/game/phase/PhaseType;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?18:14;continue;}
case 14:{f.Push(JValue.I(2));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?26:22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Pc=27;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7907(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","skipDamageSteps","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7908(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","nEndOfTurnsThisTurn","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7909(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?18:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Turns already started, call this only once per game")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/IllegalStateException","<init>","(Ljava/lang/String;)V","invokespecial",17);}
case 17:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/phase/PhaseHandler","teamLead","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPlayerTurn","(Lforge/game/player/Player;)V","invokevirtual",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/phase/PhaseHandler","advanceToNextPhase","()V","invokevirtual",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/phase/PhaseHandler","onPhaseBegin","()V","invokevirtual",35);}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Reference==null?55:44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/Runnable","run","()V","invokeinterface",50);}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(1));f.Pc=52;continue;}
case 52:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z",value);f.Pc=55;continue;}
case 55:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7910(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/phase/PhaseHandler","startFirstTurn","(Lforge/game/player/Player;Ljava/lang/Runnable;)V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7911(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/phase/PhaseHandler","setupFirstTurn","(Lforge/game/player/Player;Ljava/lang/Runnable;)V","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/phase/PhaseHandler","mainGameLoop","()V","invokevirtual",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7912(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?30:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/Game","getAge","()Lforge/game/GameStage;","invokevirtual",17);}
case 17:{if(!rt.StaticReady(f,"forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;"));f.Pc=20;continue;}
case 20:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?30:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/phase/PhaseHandler","mainLoopStep","()V","invokevirtual",27);}
case 27:{f.Pc=0;continue;}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7913(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?396:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/phase/PhaseHandler","checkStateBasedEffects","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?19:18;continue;}
case 18:{return JStep.ReturnVoid;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","pPlayerPriority","Lforge/game/player/Player;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/player/Player","hasLost","()Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?32:29;continue;}
case 29:{f.Pc=361;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=36;continue;}
case 36:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventPlayerPriority"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventPlayerPriority")));f.Pc=39;continue;}
case 39:{f.StackOp("dup");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",47);}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPriorityPlayer","()Lforge/game/player/Player;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",58);}
case 58:{return rt.Call(f,"forge/game/event/GameEventPlayerPriority","<init>","(Lforge/game/player/PlayerView;Lforge/game/phase/PhaseType;Lforge/game/player/PlayerView;)V","invokespecial",61);}
case 61:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",64);}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/Game","stashGameState","()V","invokevirtual",71);}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","pPlayerPriority","Lforge/game/player/Player;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",78);}
case 78:{return rt.Call(f,"forge/game/player/PlayerController","chooseSpellAbilityToPlay","()Ljava/util/List;","invokevirtual",81);}
case 81:{f.Locals[1]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{f.Pc=f.Pop().Reference!=null?89:86;continue;}
case 86:{f.Pc=361;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/Game","getUndoManager","()Lforge/game/undo/UndoManager;","invokevirtual",96);}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","pPlayerPriority","Lforge/game/player/Player;"));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/undo/UndoManager","isOwner","(Lforge/game/player/Player;)Z","invokevirtual",103);}
case 103:{f.Pc=f.Pop().Int!=0?119:106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/Game","getUndoManager","()Lforge/game/undo/UndoManager;","invokevirtual",113);}
case 113:{f.Push(JValue.R(rt.String("Opponent acted")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/undo/UndoManager","barrier","(Ljava/lang/String;)V","invokevirtual",119);}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{f.Locals[3]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(JValue.I(0));f.Pc=122;continue;}
case 122:{f.Locals[4]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",130);}
case 130:{f.Locals[5]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[5]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",139);}
case 139:{f.Pc=f.Pop().Int==0?310:142;continue;}
case 142:{f.Push(f.Locals[5]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",149);}
case 149:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=152;continue;}
case 152:{f.Locals[6]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[6]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",159);}
case 159:{f.Locals[7]=f.Pop();f.Pc=161;continue;}
case 161:{f.Push(f.Locals[7]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",166);}
case 166:{f.Locals[8]=f.Pop();f.Pc=168;continue;}
case 168:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=171;continue;}
case 171:{f.StackOp("dup");f.Pc=172;continue;}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",179);}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",186);}
case 186:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",189);}
case 189:{f.Locals[9]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[0]);f.Pc=192;continue;}
case 192:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","pPlayerPriority","Lforge/game/player/Player;"));f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",198);}
case 198:{f.Push(f.Locals[6]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/player/PlayerController","playChosenSpellAbility","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",203);}
case 203:{f.Pc=f.Pop().Int==0?212:206;continue;}
case 206:{f.Push(JValue.I(1));f.Pc=207;continue;}
case 207:{f.Locals[4]=f.Pop();f.Pc=209;continue;}
case 209:{f.Pc=224;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=216;continue;}
case 216:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","EXPERIMENTAL_RESTORE_SNAPSHOT","Z"));f.Pc=219;continue;}
case 219:{f.Pc=f.Pop().Int==0?224:222;continue;}
case 222:{f.Push(JValue.I(1));f.Pc=223;continue;}
case 223:{f.Locals[3]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[0]);f.Pc=225;continue;}
case 225:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=228;continue;}
case 228:{f.Push(f.Locals[7]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",233);}
case 233:{f.Locals[7]=f.Pop();f.Pc=235;continue;}
case 235:{f.Push(f.Locals[7]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",240);}
case 240:{f.Locals[10]=f.Pop();f.Pc=242;continue;}
case 242:{f.Push(f.Locals[10]);f.Pc=244;continue;}
case 244:{f.Pc=f.Pop().Reference==null?307:247;continue;}
case 247:{f.Push(f.Locals[8]);f.Pc=249;continue;}
case 249:{f.Pc=f.Pop().Reference==null?307:252;continue;}
case 252:{f.Push(f.Locals[10]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[8]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",259);}
case 259:{f.Pc=f.Pop().Int!=0?307:262;continue;}
case 262:{f.Push(f.Locals[6]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",267);}
case 267:{f.Pc=f.Pop().Int!=0?278:270;continue;}
case 270:{f.Push(f.Locals[6]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/spellability/SpellAbility","isLandAbility","()Z","invokevirtual",275);}
case 275:{f.Pc=f.Pop().Int==0?307:278;continue;}
case 278:{f.Push(f.Locals[9]);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[8]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",285);}
case 285:{f.Push(f.Locals[10]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",290);}
case 290:{f.Push(f.Locals[7]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",295);}
case 295:{f.StackOp("pop");f.Pc=296;continue;}
case 296:{f.Push(f.Locals[9]);f.Pc=298;continue;}
case 298:{f.Push(f.Locals[0]);f.Pc=299;continue;}
case 299:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=302;continue;}
case 302:{f.Push(f.Locals[6]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",307);}
case 307:{f.Pc=132;continue;}
case 310:{f.Push(f.Locals[4]);f.Pc=312;continue;}
case 312:{f.Pc=f.Pop().Int==0?327:315;continue;}
case 315:{f.Push(f.Locals[0]);f.Pc=316;continue;}
case 316:{f.Push(f.Locals[0]);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[0]);f.Pc=318;continue;}
case 318:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","pPlayerPriority","Lforge/game/player/Player;"));f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/phase/PhaseHandler","teamLead","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",324);}
case 324:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPriority","(Lforge/game/player/Player;)V","invokevirtual",327);}
case 327:{f.Push(f.Locals[3]);f.Pc=328;continue;}
case 328:{f.Pc=f.Pop().Int!=0?338:331;continue;}
case 331:{f.Push(f.Locals[0]);f.Pc=332;continue;}
case 332:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/Game","copyLastState","()V","invokevirtual",338);}
case 338:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=341;continue;}
case 341:{f.Push(f.Locals[2]);f.Pc=342;continue;}
case 342:{f.Push(JValue.I(999));f.Pc=345;continue;}
case 345:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?11:348;continue;}
case 348:{f.Push(f.Locals[0]);f.Pc=349;continue;}
case 349:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","pPlayerPriority","Lforge/game/player/Player;"));f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",355);}
case 355:{return rt.Call(f,"forge/game/player/PlayerController","isAI","()Z","invokevirtual",358);}
case 358:{f.Pc=f.Pop().Int==0?11:361;continue;}
case 361:{f.Push(f.Locals[2]);f.Pc=362;continue;}
case 362:{f.Push(JValue.I(999));f.Pc=365;continue;}
case 365:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?396:368;continue;}
case 368:{f.Push(f.Locals[0]);f.Pc=369;continue;}
case 369:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","pPlayerPriority","Lforge/game/player/Player;"));f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",375);}
case 375:{return rt.Call(f,"forge/game/player/PlayerController","isAI","()Z","invokevirtual",378);}
case 378:{f.Pc=f.Pop().Int==0?396:381;continue;}
case 381:{if(!rt.StaticReady(f,"forge/game/phase/PhaseHandler","aiLog","Lorg/tinylog/TaggedLogger;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseHandler","aiLog","Lorg/tinylog/TaggedLogger;"));f.Pc=384;continue;}
case 384:{f.Push(f.Locals[1]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",388);}
case 388:{return rt.DynamicCall(f,"forge/game/phase/PhaseHandler:7913:388:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",393);}
case 393:{return rt.Call(f,"org/tinylog/TaggedLogger","warn","(Ljava/lang/Object;)V","invokevirtual",396);}
case 396:{f.Push(f.Locals[0]);f.Pc=397;continue;}
case 397:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=400;continue;}
case 400:{f.Push(f.Locals[0]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPriorityPlayer","()Lforge/game/player/Player;","invokevirtual",404);}
case 404:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",407);}
case 407:{f.Locals[1]=f.Pop();f.Pc=408;continue;}
case 408:{f.Push(f.Locals[0]);f.Pc=409;continue;}
case 409:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=412;continue;}
case 412:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",415);}
case 415:{f.Pc=f.Pop().Int!=0?422:418;continue;}
case 418:{f.Push(f.Locals[1]);f.Pc=419;continue;}
case 419:{f.Pc=f.Pop().Reference!=null?423:422;continue;}
case 422:{return JStep.ReturnVoid;}
case 423:{f.Push(JValue.I(0));f.Pc=424;continue;}
case 424:{f.Locals[2]=f.Pop();f.Pc=425;continue;}
case 425:{f.Push(f.Locals[0]);f.Pc=426;continue;}
case 426:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","pFirstPriority","Lforge/game/player/Player;"));f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/game/player/Player","hasLost","()Z","invokevirtual",432);}
case 432:{f.Pc=f.Pop().Int==0?474:435;continue;}
case 435:{f.Push(f.Locals[0]);f.Pc=436;continue;}
case 436:{f.Push(f.Locals[0]);f.Pc=437;continue;}
case 437:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=440;continue;}
case 440:{f.Push(f.Locals[0]);f.Pc=441;continue;}
case 441:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","pFirstPriority","Lforge/game/player/Player;"));f.Pc=444;continue;}
case 444:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",447);}
case 447:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","pFirstPriority","Lforge/game/player/Player;",value);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[0]);f.Pc=451;continue;}
case 451:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","pPlayerPriority","Lforge/game/player/Player;"));f.Pc=454;continue;}
case 454:{return rt.Call(f,"forge/game/player/Player","hasLost","()Z","invokevirtual",457);}
case 457:{f.Pc=f.Pop().Int==0?472:460;continue;}
case 460:{f.Push(f.Locals[0]);f.Pc=461;continue;}
case 461:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","pFirstPriority","Lforge/game/player/Player;"));f.Pc=464;continue;}
case 464:{f.Push(f.Locals[1]);f.Pc=465;continue;}
case 465:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?472:468;continue;}
case 468:{f.Push(JValue.I(1));f.Pc=469;continue;}
case 469:{f.Pc=473;continue;}
case 472:{f.Push(JValue.I(0));f.Pc=473;continue;}
case 473:{f.Locals[2]=f.Pop();f.Pc=474;continue;}
case 474:{f.Push(f.Locals[0]);f.Pc=475;continue;}
case 475:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","pFirstPriority","Lforge/game/player/Player;"));f.Pc=478;continue;}
case 478:{f.Push(f.Locals[1]);f.Pc=479;continue;}
case 479:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?591:482;continue;}
case 482:{f.Push(f.Locals[2]);f.Pc=483;continue;}
case 483:{f.Pc=f.Pop().Int!=0?591:486;continue;}
case 486:{f.Push(f.Locals[0]);f.Pc=487;continue;}
case 487:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z"));f.Pc=490;continue;}
case 490:{f.Locals[3]=f.Pop();f.Pc=491;continue;}
case 491:{f.Push(f.Locals[0]);f.Pc=492;continue;}
case 492:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",498);}
case 498:{return rt.Call(f,"forge/game/zone/MagicStack","isEmpty","()Z","invokevirtual",501);}
case 501:{f.Pc=f.Pop().Int!=0?508:504;continue;}
case 504:{f.Push(f.Locals[3]);f.Pc=505;continue;}
case 505:{f.Pc=f.Pop().Int!=0?565:508;continue;}
case 508:{f.Push(f.Locals[0]);f.Pc=509;continue;}
case 509:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=512;continue;}
case 512:{return rt.Call(f,"forge/game/player/Player","hasLost","()Z","invokevirtual",515);}
case 515:{f.Pc=f.Pop().Int==0?536:518;continue;}
case 518:{f.Push(f.Locals[0]);f.Pc=519;continue;}
case 519:{f.Push(f.Locals[0]);f.Pc=520;continue;}
case 520:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=523;continue;}
case 523:{f.Push(f.Locals[0]);f.Pc=524;continue;}
case 524:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",530);}
case 530:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPriority","(Lforge/game/player/Player;)V","invokevirtual",533);}
case 533:{f.Pc=544;continue;}
case 536:{f.Push(f.Locals[0]);f.Pc=537;continue;}
case 537:{f.Push(f.Locals[0]);f.Pc=538;continue;}
case 538:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=541;continue;}
case 541:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPriority","(Lforge/game/player/Player;)V","invokevirtual",544);}
case 544:{f.Push(f.Locals[0]);f.Pc=545;continue;}
case 545:{f.Push(JValue.I(1));f.Pc=546;continue;}
case 546:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z",value);f.Pc=549;continue;}
case 549:{f.Push(f.Locals[0]);f.Pc=550;continue;}
case 550:{f.Push(f.Locals[3]);f.Pc=551;continue;}
case 551:{return rt.Call(f,"forge/game/phase/PhaseHandler","onPhaseEnd","(Z)V","invokevirtual",554);}
case 554:{f.Push(f.Locals[0]);f.Pc=555;continue;}
case 555:{return rt.Call(f,"forge/game/phase/PhaseHandler","advanceToNextPhase","()V","invokevirtual",558);}
case 558:{f.Push(f.Locals[0]);f.Pc=559;continue;}
case 559:{return rt.Call(f,"forge/game/phase/PhaseHandler","onPhaseBegin","()V","invokevirtual",562);}
case 562:{f.Pc=588;continue;}
case 565:{f.Push(f.Locals[0]);f.Pc=566;continue;}
case 566:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=569;continue;}
case 569:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",572);}
case 572:{return rt.Call(f,"forge/game/zone/MagicStack","hasSimultaneousStackEntries","()Z","invokevirtual",575);}
case 575:{f.Pc=f.Pop().Int!=0?588:578;continue;}
case 578:{f.Push(f.Locals[0]);f.Pc=579;continue;}
case 579:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=582;continue;}
case 582:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",585);}
case 585:{return rt.Call(f,"forge/game/zone/MagicStack","resolveStack","()V","invokevirtual",588);}
case 588:{f.Pc=596;continue;}
case 591:{f.Push(f.Locals[0]);f.Pc=592;continue;}
case 592:{f.Push(f.Locals[1]);f.Pc=593;continue;}
case 593:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","pPlayerPriority","Lforge/game/player/Player;",value);f.Pc=596;continue;}
case 596:{f.Push(f.Locals[0]);f.Pc=597;continue;}
case 597:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=600;continue;}
case 600:{return rt.Call(f,"forge/game/Game","getAge","()Lforge/game/GameStage;","invokevirtual",603);}
case 603:{if(!rt.StaticReady(f,"forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;"));f.Pc=606;continue;}
case 606:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?643:609;continue;}
case 609:{f.Push(f.Locals[0]);f.Pc=610;continue;}
case 610:{f.Push(JValue.R(null));f.Pc=611;continue;}
case 611:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPhase","(Lforge/game/phase/PhaseType;)V","invokevirtual",614);}
case 614:{f.Push(f.Locals[0]);f.Pc=615;continue;}
case 615:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=618;continue;}
case 618:{return rt.Call(f,"forge/game/Game","updatePhaseForView","()V","invokevirtual",621);}
case 621:{f.Push(f.Locals[0]);f.Pc=622;continue;}
case 622:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=625;continue;}
case 625:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventGameRestarted"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventGameRestarted")));f.Pc=628;continue;}
case 628:{f.StackOp("dup");f.Pc=629;continue;}
case 629:{f.Push(f.Locals[0]);f.Pc=630;continue;}
case 630:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=633;continue;}
case 633:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",636);}
case 636:{return rt.Call(f,"forge/game/event/GameEventGameRestarted","<init>","(Lforge/game/player/PlayerView;)V","invokespecial",639);}
case 639:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",642);}
case 642:{return JStep.ReturnVoid;}
case 643:{f.Push(f.Locals[0]);f.Pc=644;continue;}
case 644:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=647;continue;}
case 647:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",650);}
case 650:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",653);}
case 653:{f.Locals[3]=f.Pop();f.Pc=654;continue;}
case 654:{f.Push(f.Locals[3]);f.Pc=655;continue;}
case 655:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",660);}
case 660:{f.Pc=f.Pop().Int==0?696:663;continue;}
case 663:{f.Push(f.Locals[3]);f.Pc=664;continue;}
case 664:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",669);}
case 669:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=672;continue;}
case 672:{f.Locals[4]=f.Pop();f.Pc=674;continue;}
case 674:{f.Push(f.Locals[4]);f.Pc=676;continue;}
case 676:{f.Push(f.Locals[0]);f.Pc=677;continue;}
case 677:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPriorityPlayer","()Lforge/game/player/Player;","invokevirtual",680);}
case 680:{f.Push(f.Locals[4]);f.Pc=682;continue;}
case 682:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?689:685;continue;}
case 685:{f.Push(JValue.I(1));f.Pc=686;continue;}
case 686:{f.Pc=690;continue;}
case 689:{f.Push(JValue.I(0));f.Pc=690;continue;}
case 690:{return rt.Call(f,"forge/game/player/Player","setHasPriority","(Z)V","invokevirtual",693);}
case 693:{f.Pc=654;continue;}
case 696:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7914(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",15);}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/GameAction","checkStateEffects","(ZLjava/util/Set;)Z","invokevirtual",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?33:31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",40);}
case 40:{return rt.Call(f,"forge/game/zone/MagicStack","addAllTriggeredAbilitiesToStack","()Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int!=0?8:46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/game/zone/MagicStack","isEmpty","()Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?69:59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",66);}
case 66:{return rt.Call(f,"forge/game/zone/MagicStack","clearTriggerRepeats","()V","invokevirtual",69);}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",75);}
case 75:{f.Pc=f.Pop().Int!=0?108:78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=82;continue;}
case 82:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=85;continue;}
case 85:{f.StackOp("dup");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Ljava/util/Collection;)V","invokespecial",90);}
case 90:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",93);}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",100);}
case 100:{return rt.DynamicCall(f,"forge/game/phase/PhaseHandler:7914:100:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Consumer;",105);}
case 105:{return rt.Call(f,"forge/game/player/PlayerCollection","forEach","(Ljava/util/function/Consumer;)V","invokevirtual",108);}
case 108:{f.Push(JValue.I(0));f.Pc=109;continue;}
case 109:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7915(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/phase/PhaseHandler","devAdvanceToPhase","(Lforge/game/phase/PhaseType;Ljava/lang/Runnable;)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7916(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/phase/PhaseHandler","declareAttackersTurnBasedAction","()V","invokevirtual",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7917(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","isPhasesReversed","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","turn","I"));f.Pc=16;continue;}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","turn","I"));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?40:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/phase/PhaseType","isBefore","(Lforge/game/phase/PhaseType;Z)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?142:40;continue;}
case 40:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(60));f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?67:50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int!=0?67:60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/phase/PhaseHandler","checkStateBasedEffects","()Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int==0?69:67;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Pc=f.Pop().Reference==null?79:73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/Runnable","run","()V","invokeinterface",79);}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/phase/PhaseHandler","onPhaseEnd","()V","invokevirtual",83);}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{f.Locals[5]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Pc=f.Pop().Reference==null?131:90;continue;}
case 90:{f.Push(f.Locals[5]);f.Pc=92;continue;}
case 92:{f.Push(JValue.I(3));f.Pc=93;continue;}
case 93:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?131:96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",103);}
case 103:{return rt.Call(f,"forge/game/zone/MagicStack","isEmpty","()Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int!=0?131:109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",116);}
case 116:{f.Pc=f.Pop().Int!=0?131:119;continue;}
case 119:{f.Push(f.Locals[2]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/Runnable","run","()V","invokeinterface",125);}
case 125:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=128;continue;}
case 128:{f.Pc=86;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/phase/PhaseHandler","advanceToNextPhase","()V","invokevirtual",135);}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/phase/PhaseHandler","onPhaseBegin","()V","invokevirtual",139);}
case 139:{f.Pc=20;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/phase/PhaseHandler","checkStateBasedEffects","()Z","invokevirtual",146);}
case 146:{f.StackOp("pop");f.Pc=147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int!=0?161:157;continue;}
case 157:{f.Push(JValue.I(1));f.Pc=158;continue;}
case 158:{f.Pc=162;continue;}
case 161:{f.Push(JValue.I(0));f.Pc=162;continue;}
case 162:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7918(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","isPhasesReversed","()Z","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/phase/PhaseType","isBefore","(Lforge/game/phase/PhaseType;Z)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?66:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/phase/PhaseHandler","checkStateBasedEffects","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?29:27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference==null?51:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Runnable","run","()V","invokeinterface",39);}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?51:49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/phase/PhaseHandler","onPhaseEnd","()V","invokevirtual",55);}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/phase/PhaseHandler","advanceToNextPhase","()V","invokevirtual",59);}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/phase/PhaseHandler","onPhaseBegin","()V","invokevirtual",63);}
case 63:{f.Pc=8;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/phase/PhaseHandler","checkStateBasedEffects","()Z","invokevirtual",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Push(JValue.I(1));f.Pc=72;continue;}
case 72:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7919(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?9:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPhase","(Lforge/game/phase/PhaseType;)V","invokevirtual",9);}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference==null?18:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPlayerTurn","(Lforge/game/player/Player;)V","invokevirtual",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","turn","I",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=28;continue;}
case 28:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventTurnPhase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventTurnPhase")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("dev")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/event/GameEventTurnPhase","<init>","(Lforge/game/player/Player;Lforge/game/phase/PhaseType;Ljava/lang/String;)V","invokespecial",46);}
case 46:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",49);}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Int==0?57:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/phase/PhaseHandler","endCombat","()V","invokevirtual",57);}
case 57:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7920(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/phase/PhaseHandler","devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;ZI)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7921(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/phase/PhaseHandler","devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;ZI)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7922(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/phase/PhaseHandler","devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;ZI)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7923(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/phase/PhaseHandler","endCombat","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",11);}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/GameAction","checkStateEffects","(Z)Z","invokevirtual",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPhase","(Lforge/game/phase/PhaseType;)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/phase/PhaseHandler","advanceToNextPhase","()V","invokevirtual",27);}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7924(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraPhases","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/phase/PhaseHandler","setPhase","(Lforge/game/phase/PhaseType;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=20;continue;}
case 20:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventTurnPhase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventTurnPhase")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/event/GameEventTurnPhase","<init>","(Lforge/game/player/Player;Lforge/game/phase/PhaseType;Ljava/lang/String;)V","invokespecial",38);}
case 38:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",41);}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/phase/PhaseHandler","onPhaseBegin","()V","invokevirtual",45);}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7925(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","planarDiceSpecialActionThisTurn","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7926(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","planarDiceSpecialActionThisTurn","I"));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","planarDiceSpecialActionThisTurn","I",value);f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7927(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("%s's %s [%sP] %s")));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(4));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=13;continue;}
case 13:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","phase","Lforge/game/phase/PhaseType;"));f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseType","nameForUi","Ljava/lang/String;"));f.Pc=23;continue;}
case 23:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(JValue.I(2));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Int==0?36:30;continue;}
case 30:{f.Push(JValue.R(rt.String("+")));f.Pc=33;continue;}
case 33:{f.Pc=39;continue;}
case 36:{f.Push(JValue.R(rt.String("-")));f.Pc=39;continue;}
case 39:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=40;continue;}
case 40:{f.StackOp("dup");f.Pc=41;continue;}
case 41:{f.Push(JValue.I(3));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPriorityPlayer","()Lforge/game/player/Player;","invokevirtual",46);}
case 46:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",50);}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7928(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","givePriorityToPlayer","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7929(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getEndOfCombat","()Lforge/game/phase/Phase;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/phase/Phase","executeUntil","()V","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/Game","getEndOfCombat","()Lforge/game/phase/Phase;","invokevirtual",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/phase/Phase","executeUntilEndOfPhase","(Lforge/game/player/Player;)V","invokevirtual",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/phase/PhaseHandler","inCombat","()Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?43:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/combat/Combat","endCombat","()V","invokevirtual",38);}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(null));f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",50);}
case 50:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7930(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7931(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Stack","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?21:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Stack","size","()I","invokevirtual",17);}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?23:21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","extraTurns","Ljava/util/Stack;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Stack","size","()I","invokevirtual",37);}
case 37:{return rt.Call(f,"java/util/Stack","subList","(II)Ljava/util/List;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",45);}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",52);}
case 52:{f.Pc=f.Pop().Int==0?87:55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/ExtraTurn"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{f.Locals[4]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/phase/ExtraTurn","getPlayer","()Lforge/game/player/Player;","invokevirtual",71);}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int!=0?81:78;continue;}
case 78:{f.Pc=87;continue;}
case 81:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=84;continue;}
case 84:{f.Pc=46;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7932(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerPreviousTurn","Lforge/game/player/Player;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","playerTurn","Lforge/game/player/Player;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",29);}
case 29:{f.Locals[2]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/Game","getTurnOrder","()Lforge/game/Direction;","invokevirtual",37);}
case 37:{return rt.Call(f,"forge/game/Direction","getShift","()I","invokevirtual",40);}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?204:46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=49;continue;}
case 49:{f.Locals[1]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Int>=0?70:54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",61);}
case 61:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",64);}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=66;continue;}
case 66:{f.Locals[1]=f.Pop();f.Pc=67;continue;}
case 67:{f.Pc=88;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",78);}
case 78:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",81);}
case 81:{f.Push(JValue.I(1));f.Pc=82;continue;}
case 82:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=83;continue;}
case 83:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?88:86;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{f.Locals[1]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",95);}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{f.Locals[4]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[4]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/player/Player","hasLost","()Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?201:112;continue;}
case 112:{f.Push(f.Locals[4]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/phase/Untap","doPhasing","(Lforge/game/player/Player;)V","invokestatic",117);}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/Game","getUntap","()Lforge/game/phase/Untap;","invokevirtual",124);}
case 124:{f.Push(f.Locals[4]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/phase/Untap","executeUntil","(Lforge/game/player/Player;)V","invokevirtual",129);}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/Game","getUpkeep","()Lforge/game/phase/Phase;","invokevirtual",136);}
case 136:{f.Push(f.Locals[4]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/phase/Phase","executeUntil","(Lforge/game/player/Player;)V","invokevirtual",141);}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/Game","getUpkeep","()Lforge/game/phase/Phase;","invokevirtual",148);}
case 148:{f.Push(f.Locals[4]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/phase/Phase","executeUntilEndOfPhase","(Lforge/game/player/Player;)V","invokevirtual",153);}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/Game","getEndOfCombat","()Lforge/game/phase/Phase;","invokevirtual",160);}
case 160:{f.Push(f.Locals[4]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/phase/Phase","executeUntilEndOfPhase","(Lforge/game/player/Player;)V","invokevirtual",165);}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",172);}
case 172:{f.Push(f.Locals[4]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/phase/Phase","executeUntil","(Lforge/game/player/Player;)V","invokevirtual",177);}
case 177:{f.Push(f.Locals[0]);f.Pc=178;continue;}
case 178:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",184);}
case 184:{f.Push(f.Locals[4]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/phase/Phase","executeUntilEndOfPhase","(Lforge/game/player/Player;)V","invokevirtual",189);}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","game","Lforge/game/Game;"));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/Game","getCleanup","()Lforge/game/phase/Phase;","invokevirtual",196);}
case 196:{f.Push(f.Locals[4]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/phase/Phase","executeUntil","(Lforge/game/player/Player;)V","invokevirtual",201);}
case 201:{f.Pc=41;continue;}
case 204:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7933(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseHandler","combat","Lforge/game/combat/Combat;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/game/phase/PhaseHandler:7933:8:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",13);}
case 13:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7934(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C168{
internal static JClass Build(){var c=new JClass("forge/game/GameView","forge/trackable/TrackableObject",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(8522884512960961528L),null));
c.Add(new JField("game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("match","Lforge/game/Match;",false,JValue.Default("Lforge/game/Match;"),null));
c.Add(new JField("gameLog","Lforge/game/GameLog;",false,JValue.Default("Lforge/game/GameLog;"),null));
c.Add(new JMethod(2646,"forge/game/GameView","<init>","(Lforge/game/Game;)V",1,3,3,new JHandler[]{},M2646));
c.Add(new JMethod(2647,"forge/game/GameView","getMatch","()Lforge/game/Match;",1,1,1,new JHandler[]{},M2647));
c.Add(new JMethod(2648,"forge/game/GameView","getGame","()Lforge/game/Game;",1,1,1,new JHandler[]{},M2648));
c.Add(new JMethod(2649,"forge/game/GameView","getPlayers","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M2649));
c.Add(new JMethod(2650,"forge/game/GameView","updatePlayers","(Lforge/game/Game;)V",1,2,3,new JHandler[]{},M2650));
c.Add(new JMethod(2651,"forge/game/GameView","getTitle","()Ljava/lang/String;",1,1,2,new JHandler[]{},M2651));
c.Add(new JMethod(2652,"forge/game/GameView","isCommander","()Z",1,1,2,new JHandler[]{},M2652));
c.Add(new JMethod(2653,"forge/game/GameView","getGameType","()Lforge/game/GameType;",1,1,2,new JHandler[]{},M2653));
c.Add(new JMethod(2654,"forge/game/GameView","getPoisonCountersToLose","()I",1,1,2,new JHandler[]{},M2654));
c.Add(new JMethod(2655,"forge/game/GameView","getNumGamesInMatch","()I",1,1,2,new JHandler[]{},M2655));
c.Add(new JMethod(2656,"forge/game/GameView","getTurn","()I",1,1,2,new JHandler[]{},M2656));
c.Add(new JMethod(2657,"forge/game/GameView","updateTurn","(Lforge/game/phase/PhaseHandler;)V",0,2,3,new JHandler[]{},M2657));
c.Add(new JMethod(2658,"forge/game/GameView","getPhase","()Lforge/game/phase/PhaseType;",1,1,2,new JHandler[]{},M2658));
c.Add(new JMethod(2659,"forge/game/GameView","updatePhase","(Lforge/game/phase/PhaseHandler;)V",0,2,3,new JHandler[]{},M2659));
c.Add(new JMethod(2660,"forge/game/GameView","getPlayerTurn","()Lforge/game/player/PlayerView;",1,1,2,new JHandler[]{},M2660));
c.Add(new JMethod(2661,"forge/game/GameView","updatePlayerTurn","(Lforge/game/phase/PhaseHandler;)V",0,2,3,new JHandler[]{},M2661));
c.Add(new JMethod(2662,"forge/game/GameView","updatePlanarPlayer","(Lforge/game/player/PlayerView;)V",1,2,3,new JHandler[]{},M2662));
c.Add(new JMethod(2663,"forge/game/GameView","getPlanarPlayer","()Lforge/game/player/PlayerView;",1,1,2,new JHandler[]{},M2663));
c.Add(new JMethod(2664,"forge/game/GameView","getStack","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M2664));
c.Add(new JMethod(2665,"forge/game/GameView","peekStack","()Lforge/game/spellability/StackItemView;",1,1,2,new JHandler[]{},M2665));
c.Add(new JMethod(2666,"forge/game/GameView","getStormCount","()I",1,1,2,new JHandler[]{},M2666));
c.Add(new JMethod(2667,"forge/game/GameView","updateStack","(Lforge/game/zone/MagicStack;)V",0,2,3,new JHandler[]{},M2667));
c.Add(new JMethod(2668,"forge/game/GameView","getNumPlayedGamesInMatch","()I",1,1,2,new JHandler[]{},M2668));
c.Add(new JMethod(2669,"forge/game/GameView","isMulligan","()Z",1,1,2,new JHandler[]{},M2669));
c.Add(new JMethod(2670,"forge/game/GameView","updateIsMulligan","(Z)V",1,2,3,new JHandler[]{},M2670));
c.Add(new JMethod(2671,"forge/game/GameView","isGameOver","()Z",1,1,2,new JHandler[]{},M2671));
c.Add(new JMethod(2672,"forge/game/GameView","isMatchOver","()Z",1,1,2,new JHandler[]{},M2672));
c.Add(new JMethod(2673,"forge/game/GameView","getWinningPlayerName","()Ljava/lang/String;",1,1,2,new JHandler[]{},M2673));
c.Add(new JMethod(2674,"forge/game/GameView","getWinningTeam","()I",1,1,2,new JHandler[]{},M2674));
c.Add(new JMethod(2675,"forge/game/GameView","updateGameOver","(Lforge/game/Game;)V",0,2,3,new JHandler[]{},M2675));
c.Add(new JMethod(2676,"forge/game/GameView","getGameLog","()Lforge/game/GameLog;",1,1,1,new JHandler[]{},M2676));
c.Add(new JMethod(2677,"forge/game/GameView","initGameLog","()V",1,1,3,new JHandler[]{},M2677));
c.Add(new JMethod(2678,"forge/game/GameView","getDependencies","()Ljava/lang/String;",1,1,2,new JHandler[]{},M2678));
c.Add(new JMethod(2679,"forge/game/GameView","setDependencies","(Lcom/google/common/collect/Table;)V",1,8,3,new JHandler[]{},M2679));
c.Add(new JMethod(2680,"forge/game/GameView","getCombat","()Lforge/game/combat/CombatView;",1,1,2,new JHandler[]{},M2680));
c.Add(new JMethod(2681,"forge/game/GameView","updateCombat","(Lforge/game/combat/Combat;)V",0,9,5,new JHandler[]{},M2681));
c.Add(new JMethod(2682,"forge/game/GameView","isMatchWonBy","(Lforge/LobbyPlayer;)Z",1,2,2,new JHandler[]{},M2682));
c.Add(new JMethod(2683,"forge/game/GameView","getOutcomesOfMatch","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M2683));
c.Add(new JMethod(2684,"forge/game/GameView","isWinner","(Lforge/LobbyPlayer;)Z",1,2,2,new JHandler[]{},M2684));
c.Add(new JMethod(2685,"forge/game/GameView","getGamesWonBy","(Lforge/LobbyPlayer;)I",1,2,2,new JHandler[]{},M2685));
c.Add(new JMethod(2686,"forge/game/GameView","getDeck","(Lforge/game/player/PlayerView;)Lforge/deck/Deck;",1,4,2,new JHandler[]{},M2686));
c.Add(new JMethod(2687,"forge/game/GameView","getOutcome","()Lforge/game/GameOutcome;",1,1,2,new JHandler[]{},M2687));
c.Add(new JMethod(2688,"forge/game/GameView","getAnteResult","(Lforge/game/player/PlayerView;)Lforge/game/GameOutcome$AnteResult;",1,2,2,new JHandler[]{},M2688));
c.Add(new JMethod(2689,"forge/game/GameView","toString","()Ljava/lang/String;",1,1,5,new JHandler[]{},M2689));
}

internal static JStep M2646(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/Game","getId","()I","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/trackable/TrackableObject","<init>","(ILforge/trackable/Tracker;)V","invokespecial",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/Game","getMatch","()Lforge/game/Match;","invokevirtual",17);}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameView","match","Lforge/game/Match;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameView","game","Lforge/game/Game;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/Game","getGameLog","()Lforge/game/GameLog;","invokevirtual",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameView","gameLog","Lforge/game/GameLog;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Title","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Title","Lforge/trackable/TrackableProperty;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/Game","getMatch","()Lforge/game/Match;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/Match","getTitle","()Ljava/lang/String;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",47);}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","WinningTeam","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","WinningTeam","Lforge/trackable/TrackableProperty;"));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(-1));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",55);}
case 55:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",58);}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",62);}
case 62:{f.Locals[2]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsCommander","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsCommander","Lforge/trackable/TrackableProperty;"));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/GameRules","hasCommander","()Z","invokevirtual",71);}
case 71:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",74);}
case 74:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",77);}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GameType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","GameType","Lforge/trackable/TrackableProperty;"));f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/GameRules","getGameType","()Lforge/game/GameType;","invokevirtual",85);}
case 85:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",88);}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PoisonCountersToLose","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PoisonCountersToLose","Lforge/trackable/TrackableProperty;"));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/GameRules","getPoisonCountersToLose","()I","invokevirtual",96);}
case 96:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",99);}
case 99:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",102);}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumGamesInMatch","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NumGamesInMatch","Lforge/trackable/TrackableProperty;"));f.Pc=106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/GameRules","getGamesPerMatch","()I","invokevirtual",110);}
case 110:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",113);}
case 113:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",116);}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumPlayedGamesInMatch","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NumPlayedGamesInMatch","Lforge/trackable/TrackableProperty;"));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/Game","getMatch","()Lforge/game/Match;","invokevirtual",124);}
case 124:{return rt.Call(f,"forge/game/Match","getOutcomes","()Ljava/util/Collection;","invokevirtual",127);}
case 127:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",132);}
case 132:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",135);}
case 135:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",138);}
case 138:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2647(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameView","match","Lforge/game/Match;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2648(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameView","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2649(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Players","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Players","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2650(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Players","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Players","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/PlayerView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2651(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Title","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Title","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2652(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","IsCommander","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","IsCommander","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2653(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GameType","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","GameType","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2654(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PoisonCountersToLose","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PoisonCountersToLose","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2655(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumGamesInMatch","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NumGamesInMatch","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2656(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Turn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Turn","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2657(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Turn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Turn","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/phase/PhaseHandler","getTurn","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2658(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Phase","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Phase","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/PhaseType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2659(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Phase","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Phase","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2660(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlayerTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PlayerTurn","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2661(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlayerTurn","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PlayerTurn","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2662(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlanarPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PlanarPlayer","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2663(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlanarPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PlanarPlayer","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2664(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Stack","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Stack","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/collect/FCollection","getEmpty","()Lforge/util/collect/FCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2665(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameView","getStack","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/StackItemView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2666(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","StormCount","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","StormCount","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2667(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Stack","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Stack","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/StackItemView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","StormCount","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","StormCount","Lforge/trackable/TrackableProperty;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellsCastThisTurn","()Ljava/util/List;","invokevirtual",19);}
case 19:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",24);}
case 24:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",27);}
case 27:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",30);}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2668(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","NumPlayedGamesInMatch","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","NumPlayedGamesInMatch","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2669(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Mulligan","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Mulligan","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2670(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Mulligan","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Mulligan","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2671(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GameOver","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","GameOver","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2672(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MatchOver","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MatchOver","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2673(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","WinningPlayerName","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","WinningPlayerName","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2674(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","WinningTeam","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","WinningTeam","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2675(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","GameOver","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","GameOver","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","MatchOver","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","MatchOver","Lforge/trackable/TrackableProperty;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/Game","getMatch","()Lforge/game/Match;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/Match","isMatchOver","()Z","invokevirtual",25);}
case 25:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",28);}
case 28:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/Game","getOutcome","()Lforge/game/GameOutcome;","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Reference==null?65:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/Game","getOutcome","()Lforge/game/GameOutcome;","invokevirtual",42);}
case 42:{return rt.Call(f,"forge/game/GameOutcome","getWinningLobbyPlayer","()Lforge/LobbyPlayer;","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Reference==null?65:48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","WinningPlayerName","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","WinningPlayerName","Lforge/trackable/TrackableProperty;"));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/Game","getOutcome","()Lforge/game/GameOutcome;","invokevirtual",56);}
case 56:{return rt.Call(f,"forge/game/GameOutcome","getWinningLobbyPlayer","()Lforge/LobbyPlayer;","invokevirtual",59);}
case 59:{return rt.Call(f,"forge/LobbyPlayer","getName","()Ljava/lang/String;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",65);}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","WinningTeam","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","WinningTeam","Lforge/trackable/TrackableProperty;"));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/Game","getOutcome","()Lforge/game/GameOutcome;","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Reference!=null?80:76;continue;}
case 76:{f.Push(JValue.I(-1));f.Pc=77;continue;}
case 77:{f.Pc=87;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/Game","getOutcome","()Lforge/game/GameOutcome;","invokevirtual",84);}
case 84:{return rt.Call(f,"forge/game/GameOutcome","getWinningTeam","()I","invokevirtual",87);}
case 87:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",90);}
case 90:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",93);}
case 93:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2676(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameView","gameLog","Lforge/game/GameLog;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2677(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.EnsureInitialized(f,"forge/game/GameLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLog")));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameLog","<init>","()V","invokespecial",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameView","gameLog","Lforge/game/GameLog;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2678(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Dependencies","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Dependencies","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2679(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/Table","isEmpty","()Z","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Int==0?20:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Dependencies","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Dependencies","Lforge/trackable/TrackableProperty;"));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",19);}
case 19:{return JStep.ReturnVoid;}
case 20:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",27);}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(JValue.R(null));f.Pc=29;continue;}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTINUOUS_LAYERS_WITH_DEPENDENCY","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CONTINUOUS_LAYERS_WITH_DEPENDENCY","Lcom/google/common/collect/ImmutableList;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"com/google/common/collect/ImmutableList","iterator","()Lcom/google/common/collect/UnmodifiableIterator;","invokevirtual",36);}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",45);}
case 45:{f.Pc=f.Pop().Int==0?202:48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",55);}
case 55:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbilityLayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=58;continue;}
case 58:{f.Locals[5]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"com/google/common/collect/Table","cellSet","()Ljava/util/Set;","invokeinterface",66);}
case 66:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",71);}
case 71:{f.Locals[6]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",80);}
case 80:{f.Pc=f.Pop().Int==0?199:83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table$Cell"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{f.Locals[7]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",102);}
case 102:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[5]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",112);}
case 112:{f.Pc=f.Pop().Int==0?196:115;continue;}
case 115:{f.Push(f.Locals[3]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?144:121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{f.Locals[3]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[2]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[3]);f.Pc=126;continue;}
case 126:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbilityLayer","num","Ljava/lang/String;"));f.Pc=129;continue;}
case 129:{return rt.DynamicCall(f,"forge/game/GameView:2679:129:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",134);}
case 134:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",137);}
case 137:{f.Push(JValue.R(rt.String(": ")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",143);}
case 143:{f.StackOp("pop");f.Pc=144;continue;}
case 144:{f.Push(f.Locals[2]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[7]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",152);}
case 152:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",158);}
case 158:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",161);}
case 161:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",164);}
case 164:{f.Push(JValue.R(rt.String(" <- ")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",170);}
case 170:{f.Push(f.Locals[7]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",177);}
case 177:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",183);}
case 183:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",186);}
case 186:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",189);}
case 189:{f.Push(JValue.R(rt.String("\n")));f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",195);}
case 195:{f.StackOp("pop");f.Pc=196;continue;}
case 196:{f.Pc=73;continue;}
case 199:{f.Pc=38;continue;}
case 202:{f.Push(f.Locals[0]);f.Pc=203;continue;}
case 203:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Dependencies","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Dependencies","Lforge/trackable/TrackableProperty;"));f.Pc=206;continue;}
case 206:{f.Push(f.Locals[2]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",210);}
case 210:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",213);}
case 213:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2680(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CombatView","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CombatView","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/CombatView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2681(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?13:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CombatView","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CombatView","Lforge/trackable/TrackableProperty;"));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",12);}
case 12:{return JStep.ReturnVoid;}
case 13:{if(!rt.EnsureInitialized(f,"forge/game/combat/CombatView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/CombatView")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/combat/Combat","getAttackingPlayer","()Lforge/game/player/Player;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/combat/CombatView","<init>","(Lforge/trackable/Tracker;)V","invokespecial",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByBand","()Ljava/util/Map;","invokevirtual",35);}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/combat/Combat","getAttackingBands","()Ljava/util/List;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",45);}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?155:57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",64);}
case 64:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=67;continue;}
case 67:{f.Locals[5]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{f.Pc=f.Pop().Reference!=null?77:74;continue;}
case 74:{f.Pc=47;continue;}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[5]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{f.Locals[6]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/combat/AttackingBand;)Lforge/game/card/CardCollection;","invokevirtual",96);}
case 96:{f.Locals[7]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/combat/AttackingBand","isBlocked","()Ljava/lang/Boolean;","invokevirtual",103);}
case 103:{if(!rt.StaticReady(f,"java/lang/Boolean","TRUE","Ljava/lang/Boolean;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","TRUE","Ljava/lang/Boolean;"));f.Pc=106;continue;}
case 106:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?113:109;continue;}
case 109:{f.Push(JValue.I(1));f.Pc=110;continue;}
case 110:{f.Pc=114;continue;}
case 113:{f.Push(JValue.I(0));f.Pc=114;continue;}
case 114:{f.Locals[8]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[5]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/combat/AttackingBand","getAttackers","()Lforge/game/card/CardCollectionView;","invokevirtual",122);}
case 122:{return rt.Call(f,"forge/game/card/CardView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",125);}
case 125:{f.Push(f.Locals[6]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/GameEntityView","get","(Lforge/game/GameEntity;)Lforge/game/GameEntityView;","invokestatic",130);}
case 130:{f.Push(f.Locals[8]);f.Pc=132;continue;}
case 132:{f.Pc=f.Pop().Int==0?143:135;continue;}
case 135:{f.Push(f.Locals[7]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/card/CardView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",140);}
case 140:{f.Pc=144;continue;}
case 143:{f.Push(JValue.R(null));f.Pc=144;continue;}
case 144:{f.Push(f.Locals[7]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/card/CardView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",149);}
case 149:{return rt.Call(f,"forge/game/combat/CombatView","addAttackingBand","(Ljava/lang/Iterable;Lforge/game/GameEntityView;Ljava/lang/Iterable;Ljava/lang/Iterable;)V","invokevirtual",152);}
case 152:{f.Pc=47;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CombatView","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CombatView","Lforge/trackable/TrackableProperty;"));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[2]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/GameView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",163);}
case 163:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2682(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameView","getMatch","()Lforge/game/Match;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Match","isWonBy","(Lforge/LobbyPlayer;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2683(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameView","getMatch","()Lforge/game/Match;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/Match","getOutcomes","()Ljava/util/Collection;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2684(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameView","getOutcome","()Lforge/game/GameOutcome;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameOutcome","isWinner","(Lforge/LobbyPlayer;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2685(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameView","getMatch","()Lforge/game/Match;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Match","getGamesWonBy","(Lforge/LobbyPlayer;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2686(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameView","getMatch","()Lforge/game/Match;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/GameView","getMatch","()Lforge/game/Match;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/Match","getPlayers","()Ljava/util/List;","invokevirtual",16);}
case 16:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?60:31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getPlayer","()Lforge/LobbyPlayer;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/game/player/PlayerView","isLobbyPlayer","(Lforge/LobbyPlayer;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int==0?57:52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getDeck","()Lforge/deck/Deck;","invokevirtual",56);}
case 56:{return JStep.Return(f.Pop());}
case 57:{f.Pc=22;continue;}
case 60:{f.Push(JValue.R(null));f.Pc=61;continue;}
case 61:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2687(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameView","getMatch","()Lforge/game/Match;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameView","getId","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/Match","getOutcomeById","(I)Lforge/game/GameOutcome;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2688(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameView","getOutcome","()Lforge/game/GameOutcome;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameOutcome","getAnteResult","(Lforge/game/player/PlayerView;)Lforge/game/GameOutcome$AnteResult;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2689(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("GameView[id=%d, turn=%d, phase=%s, players=%d, gameOver=%b]")));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(5));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/GameView","getId","()I","invokevirtual",13);}
case 13:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",16);}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/GameView","getTurn","()I","invokevirtual",23);}
case 23:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",26);}
case 26:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{f.Push(JValue.I(2));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/GameView","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",33);}
case 33:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(JValue.I(3));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/GameView","getPlayers","()Lforge/util/collect/FCollectionView;","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Reference==null?55:43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/GameView","getPlayers","()Lforge/util/collect/FCollectionView;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/util/collect/FCollectionView","size","()I","invokeinterface",52);}
case 52:{f.Pc=56;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",59);}
case 59:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=60;continue;}
case 60:{f.StackOp("dup");f.Pc=61;continue;}
case 61:{f.Push(JValue.I(4));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/GameView","isGameOver","()Z","invokevirtual",66);}
case 66:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",69);}
case 69:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",73);}
case 73:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

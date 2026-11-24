// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C158{
internal static JClass Build(){var c=new JClass("forge/game/GameOutcome","java/lang/Object",new string[]{"java/lang/Iterable"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("lastTurnNumber","I",false,JValue.Default("I"),null));
c.Add(new JField("lifeDelta","I",false,JValue.Default("I"),null));
c.Add(new JField("winningTeam","I",false,JValue.Default("I"),null));
c.Add(new JField("playerRating","Ljava/util/HashMap;",false,JValue.Default("Ljava/util/HashMap;"),null));
c.Add(new JField("playerNames","Ljava/util/HashMap;",false,JValue.Default("Ljava/util/HashMap;"),null));
c.Add(new JField("anteResult","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("winCondition","Lforge/game/GameEndReason;",false,JValue.Default("Lforge/game/GameEndReason;"),null));
c.Add(new JMethod(2479,"forge/game/GameOutcome","<init>","(Lforge/game/GameEndReason;Ljava/lang/Iterable;)V",1,5,3,new JHandler[]{},M2479));
c.Add(new JMethod(2480,"forge/game/GameOutcome","calculateLifeDelta","(Ljava/lang/Iterable;)V",2,6,4,new JHandler[]{},M2480));
c.Add(new JMethod(2481,"forge/game/GameOutcome","isDraw","()Z",1,3,1,new JHandler[]{},M2481));
c.Add(new JMethod(2482,"forge/game/GameOutcome","isWinner","(Lforge/LobbyPlayer;)Z",1,4,2,new JHandler[]{},M2482));
c.Add(new JMethod(2483,"forge/game/GameOutcome","isWinner","(Lforge/game/player/RegisteredPlayer;)Z",1,4,2,new JHandler[]{},M2483));
c.Add(new JMethod(2484,"forge/game/GameOutcome","getWinningLobbyPlayer","()Lforge/LobbyPlayer;",1,3,1,new JHandler[]{},M2484));
c.Add(new JMethod(2485,"forge/game/GameOutcome","getWinningPlayer","()Lforge/game/player/RegisteredPlayer;",1,3,1,new JHandler[]{},M2485));
c.Add(new JMethod(2486,"forge/game/GameOutcome","getWinningTeam","()I",1,1,1,new JHandler[]{},M2486));
c.Add(new JMethod(2487,"forge/game/GameOutcome","getWinCondition","()Lforge/game/GameEndReason;",1,1,1,new JHandler[]{},M2487));
c.Add(new JMethod(2488,"forge/game/GameOutcome","getLastTurnNumber","()I",1,1,1,new JHandler[]{},M2488));
c.Add(new JMethod(2489,"forge/game/GameOutcome","getLifeDelta","()I",1,1,1,new JHandler[]{},M2489));
c.Add(new JMethod(2490,"forge/game/GameOutcome","getWinSpellEffect","()Ljava/lang/String;",1,4,1,new JHandler[]{},M2490));
c.Add(new JMethod(2491,"forge/game/GameOutcome","iterator","()Ljava/util/Iterator;",1,1,1,new JHandler[]{},M2491));
c.Add(new JMethod(2492,"forge/game/GameOutcome","setTurnsPlayed","(I)V",1,2,2,new JHandler[]{},M2492));
c.Add(new JMethod(2493,"forge/game/GameOutcome","getPlayerNames","()Ljava/util/HashMap;",1,1,1,new JHandler[]{},M2493));
c.Add(new JMethod(2494,"forge/game/GameOutcome","getOutcomeStrings","()Ljava/util/List;",1,4,3,new JHandler[]{},M2494));
c.Add(new JMethod(2495,"forge/game/GameOutcome","getOutcomeString","(Lforge/game/player/RegisteredPlayer;)Ljava/lang/String;",1,2,3,new JHandler[]{},M2495));
c.Add(new JMethod(2496,"forge/game/GameOutcome","addAnteWon","(Lforge/game/player/RegisteredPlayer;Ljava/util/List;)V",1,3,4,new JHandler[]{},M2496));
c.Add(new JMethod(2497,"forge/game/GameOutcome","addAnteLost","(Lforge/game/player/RegisteredPlayer;Ljava/util/List;)V",1,3,4,new JHandler[]{},M2497));
c.Add(new JMethod(2498,"forge/game/GameOutcome","getAnteResult","(Lforge/game/player/RegisteredPlayer;)Lforge/game/GameOutcome$AnteResult;",1,2,2,new JHandler[]{},M2498));
c.Add(new JMethod(2499,"forge/game/GameOutcome","getAnteResult","(Lforge/game/player/PlayerView;)Lforge/game/GameOutcome$AnteResult;",1,4,2,new JHandler[]{},M2499));
}

internal static JStep M2479(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameOutcome","lastTurnNumber","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameOutcome","lifeDelta","I",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(-1));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameOutcome","winningTeam","I",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",27);}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameOutcome","playerRating","Ljava/util/HashMap;",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashMap")));f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/LinkedHashMap","<init>","()V","invokespecial",38);}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameOutcome","playerNames","Ljava/util/HashMap;",value);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=45;continue;}
case 45:{f.StackOp("dup");f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",49);}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameOutcome","anteResult","Ljava/util/Map;",value);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameOutcome","winCondition","Lforge/game/GameEndReason;",value);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",63);}
case 63:{f.Locals[3]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",70);}
case 70:{f.Pc=f.Pop().Int==0?153:73;continue;}
case 73:{f.Push(f.Locals[3]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{f.Locals[4]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","playerRating","Ljava/util/HashMap;"));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/player/Player","getRegisteredPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",93);}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/player/Player","getStats","()Lforge/game/player/PlayerStatistics;","invokevirtual",98);}
case 98:{return rt.Call(f,"java/util/HashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",101);}
case 101:{f.StackOp("pop");f.Pc=102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","playerNames","Ljava/util/HashMap;"));f.Pc=106;continue;}
case 106:{f.Push(f.Locals[4]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/player/Player","getRegisteredPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",111);}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",116);}
case 116:{return rt.Call(f,"java/util/HashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",119);}
case 119:{f.StackOp("pop");f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","winCondition","Lforge/game/GameEndReason;"));f.Pc=124;continue;}
case 124:{if(!rt.StaticReady(f,"forge/game/GameEndReason","AllOpposingTeamsLost","Lforge/game/GameEndReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameEndReason","AllOpposingTeamsLost","Lforge/game/GameEndReason;"));f.Pc=127;continue;}
case 127:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?150:130;continue;}
case 130:{f.Push(f.Locals[4]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/player/Player","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",135);}
case 135:{return rt.Call(f,"forge/game/player/PlayerOutcome","hasWon","()Z","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int==0?150:141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[4]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/player/Player","getTeam","()I","invokevirtual",147);}
case 147:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameOutcome","winningTeam","I",value);f.Pc=150;continue;}
case 150:{f.Pc=64;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","winCondition","Lforge/game/GameEndReason;"));f.Pc=157;continue;}
case 157:{if(!rt.StaticReady(f,"forge/game/GameEndReason","Draw","Lforge/game/GameEndReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameEndReason","Draw","Lforge/game/GameEndReason;"));f.Pc=160;continue;}
case 160:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?164:163;continue;}
case 163:{return JStep.ReturnVoid;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[2]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/game/GameOutcome","calculateLifeDelta","(Ljava/lang/Iterable;)V","invokevirtual",169);}
case 169:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2480(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",10);}
case 10:{f.Locals[4]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?67:22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[5]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/player/Player","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/game/player/PlayerOutcome","hasWon","()Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?56:45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",51);}
case 51:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=52;continue;}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Pc=64;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",62);}
case 62:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=63;continue;}
case 63:{f.Locals[2]=f.Pop();f.Pc=64;continue;}
case 64:{f.Pc=12;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",75);}
case 75:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameOutcome","lifeDelta","I",value);f.Pc=78;continue;}
case 78:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2481(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","playerRating","Ljava/util/HashMap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","values","()Ljava/util/Collection;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?47:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerStatistics"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[2]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/player/PlayerStatistics","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",36);}
case 36:{return rt.Call(f,"forge/game/player/PlayerOutcome","hasWon","()Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?44:42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 44:{f.Pc=13;continue;}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2482(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","playerRating","Ljava/util/HashMap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","entrySet","()Ljava/util/Set;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?74:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerStatistics"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/player/PlayerStatistics","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/player/PlayerOutcome","hasWon","()Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?71:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getPlayer","()Lforge/LobbyPlayer;","invokevirtual",62);}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/LobbyPlayer","equals","(Ljava/lang/Object;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?71:69;continue;}
case 69:{f.Push(JValue.I(1));f.Pc=70;continue;}
case 70:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 71:{f.Pc=13;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2483(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","playerRating","Ljava/util/HashMap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","entrySet","()Ljava/util/Set;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?71:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerStatistics"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/player/PlayerStatistics","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/player/PlayerOutcome","hasWon","()Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?68:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?68:66;continue;}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Pc=13;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2484(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","playerRating","Ljava/util/HashMap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","entrySet","()Ljava/util/Set;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?66:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[2]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerStatistics"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/player/PlayerStatistics","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/player/PlayerOutcome","hasWon","()Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?63:50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getPlayer","()Lforge/LobbyPlayer;","invokevirtual",62);}
case 62:{return JStep.Return(f.Pop());}
case 63:{f.Pc=13;continue;}
case 66:{f.Push(JValue.R(null));f.Pc=67;continue;}
case 67:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2485(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","playerRating","Ljava/util/HashMap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","entrySet","()Ljava/util/Set;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?63:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[2]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerStatistics"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/player/PlayerStatistics","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/player/PlayerOutcome","hasWon","()Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?60:50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{return JStep.Return(f.Pop());}
case 60:{f.Pc=13;continue;}
case 63:{f.Push(JValue.R(null));f.Pc=64;continue;}
case 64:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2486(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","winningTeam","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2487(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","winCondition","Lforge/game/GameEndReason;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2488(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","lastTurnNumber","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2489(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","lifeDelta","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2490(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","playerRating","Ljava/util/HashMap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","values","()Ljava/util/Collection;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?52:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerStatistics"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[2]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/player/PlayerStatistics","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/player/PlayerOutcome","hasWon","()Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?49:44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerOutcome","altWinSourceName","Ljava/lang/String;"));f.Pc=48;continue;}
case 48:{return JStep.Return(f.Pop());}
case 49:{f.Pc=13;continue;}
case 52:{f.Push(JValue.R(null));f.Pc=53;continue;}
case 53:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2491(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","playerRating","Ljava/util/HashMap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","entrySet","()Ljava/util/Set;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2492(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameOutcome","lastTurnNumber","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2493(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","playerNames","Ljava/util/HashMap;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2494(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","playerNames","Ljava/util/HashMap;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/HashMap","keySet","()Ljava/util/Set;","invokevirtual",11);}
case 11:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?51:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/GameOutcome","getOutcomeString","(Lforge/game/player/RegisteredPlayer;)Ljava/lang/String;","invokevirtual",42);}
case 42:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Pc=17;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2495(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","playerNames","Ljava/util/HashMap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/HashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","playerRating","Ljava/util/HashMap;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/HashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",19);}
case 19:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerStatistics"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/player/PlayerStatistics","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",25);}
case 25:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",28);}
case 28:{return rt.DynamicCall(f,"forge/game/GameOutcome:2495:28:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",33);}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2496(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","anteResult","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int!=0?31:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","anteResult","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{if(!rt.EnsureInitialized(f,"forge/game/GameOutcome$AnteResult"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameOutcome$AnteResult")));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/GameOutcome$AnteResult","<init>","()V","invokespecial",25);}
case 25:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","anteResult","Ljava/util/Map;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameOutcome$AnteResult"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/GameOutcome$AnteResult","addWon","(Ljava/util/List;)V","invokevirtual",48);}
case 48:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2497(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","anteResult","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int!=0?31:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","anteResult","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{if(!rt.EnsureInitialized(f,"forge/game/GameOutcome$AnteResult"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameOutcome$AnteResult")));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/GameOutcome$AnteResult","<init>","()V","invokespecial",25);}
case 25:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","anteResult","Ljava/util/Map;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameOutcome$AnteResult"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/GameOutcome$AnteResult","addLost","(Ljava/util/List;)V","invokevirtual",48);}
case 48:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2498(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","anteResult","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameOutcome$AnteResult"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2499(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome","anteResult","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?66:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getPlayer","()Lforge/LobbyPlayer;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/player/PlayerView","isLobbyPlayer","(Lforge/LobbyPlayer;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?63:53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameOutcome$AnteResult"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{return JStep.Return(f.Pop());}
case 63:{f.Pc=15;continue;}
case 66:{f.Push(JValue.R(null));f.Pc=67;continue;}
case 67:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C173{
internal static JClass Build(){var c=new JClass("forge/game/Match","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("removedCards","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("players","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("rules","Lforge/game/GameRules;",false,JValue.Default("Lforge/game/GameRules;"),null));
c.Add(new JField("title","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("events","Lcom/google/common/eventbus/EventBus;",false,JValue.Default("Lcom/google/common/eventbus/EventBus;"),null));
c.Add(new JField("gameOutcomes","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("lastOutcome","Lforge/game/GameOutcome;",false,JValue.Default("Lforge/game/GameOutcome;"),null));
c.Add(new JField("playedMains","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(2705,"forge/game/Match","<init>","(Lforge/game/GameRules;Ljava/util/List;Ljava/lang/String;)V",1,4,4,new JHandler[]{},M2705));
c.Add(new JMethod(2706,"forge/game/Match","getRules","()Lforge/game/GameRules;",1,1,1,new JHandler[]{},M2706));
c.Add(new JMethod(2707,"forge/game/Match","getTitle","()Ljava/lang/String;",0,5,3,new JHandler[]{},M2707));
c.Add(new JMethod(2708,"forge/game/Match","addGamePlayed","(Lforge/game/Game;)V",1,2,3,new JHandler[]{},M2708));
c.Add(new JMethod(2709,"forge/game/Match","createGame","()Lforge/game/Game;",1,1,5,new JHandler[]{},M2709));
c.Add(new JMethod(2710,"forge/game/Match","startGame","(Lforge/game/Game;)V",1,2,3,new JHandler[]{},M2710));
c.Add(new JMethod(2711,"forge/game/Match","startGame","(Lforge/game/Game;Ljava/lang/Runnable;)V",1,7,6,new JHandler[]{},M2711));
c.Add(new JMethod(2712,"forge/game/Match","getPlayedMain","(Lforge/game/player/RegisteredPlayer;)Ljava/util/List;",1,3,2,new JHandler[]{},M2712));
c.Add(new JMethod(2713,"forge/game/Match","getOutcomeById","(I)Lforge/game/GameOutcome;",1,2,2,new JHandler[]{},M2713));
c.Add(new JMethod(2714,"forge/game/Match","clearGamesPlayed","()V",1,3,1,new JHandler[]{},M2714));
c.Add(new JMethod(2715,"forge/game/Match","getOutcomes","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M2715));
c.Add(new JMethod(2716,"forge/game/Match","getLastOutcome","()Lforge/game/GameOutcome;",1,1,1,new JHandler[]{},M2716));
c.Add(new JMethod(2717,"forge/game/Match","isMatchOver","()Z",1,8,4,new JHandler[]{},M2717));
c.Add(new JMethod(2718,"forge/game/Match","getGamesWonBy","(Lforge/LobbyPlayer;)I",1,5,2,new JHandler[]{},M2718));
c.Add(new JMethod(2719,"forge/game/Match","getGamesWon","()Lcom/google/common/collect/Multiset;",1,4,2,new JHandler[]{},M2719));
c.Add(new JMethod(2720,"forge/game/Match","isWonBy","(Lforge/LobbyPlayer;)Z",1,2,2,new JHandler[]{},M2720));
c.Add(new JMethod(2721,"forge/game/Match","getWinner","()Lforge/game/player/RegisteredPlayer;",1,1,1,new JHandler[]{},M2721));
c.Add(new JMethod(2722,"forge/game/Match","getPlayers","()Ljava/util/List;",1,1,1,new JHandler[]{},M2722));
c.Add(new JMethod(2723,"forge/game/Match","getRemovedAnteCards","(Lforge/deck/Deck;)Ljava/util/Set;",10,7,2,new JHandler[]{},M2723));
c.Add(new JMethod(2724,"forge/game/Match","getRemovedCards","()Ljava/util/List;",1,1,1,new JHandler[]{},M2724));
c.Add(new JMethod(2725,"forge/game/Match","removeCard","(Lforge/item/PaperCard;)V",1,2,2,new JHandler[]{},M2725));
c.Add(new JMethod(2726,"forge/game/Match","preparePlayerZone","(Lforge/game/player/Player;Lforge/game/zone/ZoneType;Lforge/deck/CardPool;Z)V",10,12,2,new JHandler[]{},M2726));
c.Add(new JMethod(2727,"forge/game/Match","prepareAllZones","(Lforge/game/Game;)V",2,22,6,new JHandler[]{new JHandler(792,865,868,"java/lang/Exception")},M2727));
c.Add(new JMethod(2728,"forge/game/Match","executeOwnershipChanges","(Lforge/game/Game;)V",2,16,3,new JHandler[]{},M2728));
c.Add(new JMethod(2729,"forge/game/Match","getAnteResult","(Lforge/game/player/RegisteredPlayer;)Lforge/game/GameOutcome$AnteResult;",1,6,2,new JHandler[]{},M2729));
c.Add(new JMethod(2730,"forge/game/Match","fireEvent","(Lforge/game/event/Event;)V",1,2,2,new JHandler[]{},M2730));
c.Add(new JMethod(2731,"forge/game/Match","subscribeToEvents","(Ljava/lang/Object;)V",1,2,2,new JHandler[]{},M2731));
}

internal static JStep M2705(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Match","removedCards","Ljava/util/List;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"com/google/common/eventbus/EventBus"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("com/google/common/eventbus/EventBus")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("match events")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"com/google/common/eventbus/EventBus","<init>","(Ljava/lang/String;)V","invokespecial",21);}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Match","events","Lcom/google/common/eventbus/EventBus;",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",28);}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Match","gameOutcomes","Ljava/util/Map;",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(null));f.Pc=33;continue;}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Match","lastOutcome","Lforge/game/GameOutcome;",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{if(!rt.EnsureInitialized(f,"java/util/IdentityHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/IdentityHashMap")));f.Pc=40;continue;}
case 40:{f.StackOp("dup");f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/IdentityHashMap","<init>","()V","invokespecial",44);}
case 44:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Match","playedMains","Ljava/util/Map;",value);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",52);}
case 52:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",55);}
case 55:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Match","players","Ljava/util/List;",value);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;",value);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Match","title","Ljava/lang/String;",value);f.Pc=68;continue;}
case 68:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2706(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2707(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Match","getGamesWon","()Lcom/google/common/collect/Multiset;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","title","Ljava/lang/String;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String(" (")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","players","Ljava/util/List;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?75:43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[4]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"com/google/common/collect/Multiset","count","(Ljava/lang/Object;)I","invokeinterface",63);}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.Push(JValue.I(45));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Pc=34;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",80);}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/StringBuilder","deleteCharAt","(I)Ljava/lang/StringBuilder;","invokevirtual",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Push(JValue.I(41));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",92);}
case 92:{f.StackOp("pop");f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",97);}
case 97:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2708(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?17:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Game is not over yet.")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/IllegalStateException","<init>","(Ljava/lang/String;)V","invokespecial",16);}
case 16:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/Game","getOutcome","()Lforge/game/GameOutcome;","invokevirtual",22);}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/Match","lastOutcome","Lforge/game/GameOutcome;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","gameOutcomes","Ljava/util/Map;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/Game","getId","()I","invokevirtual",33);}
case 33:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/Game","getOutcome","()Lforge/game/GameOutcome;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2709(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/Game"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/Game")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","players","Ljava/util/List;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Game","<init>","(Ljava/lang/Iterable;Lforge/game/GameRules;Lforge/game/Match;)V","invokespecial",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2710(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/Match","startGame","(Lforge/game/Game;Ljava/lang/Runnable;)V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2711(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/Match","prepareAllZones","(Lforge/game/Game;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/GameRules","useAnte","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?151:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/GameRules","getMatchAnteRarity","()Z","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/GameRules","getAnteIncludeBasicLands","()Z","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/Game","chooseCardsForAnte","(ZZ)Lcom/google/common/collect/Multimap;","invokevirtual",33);}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",40);}
case 40:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",45);}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?143:57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",64);}
case 64:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=67;continue;}
case 67:{f.Locals[5]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{f.Locals[6]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",85);}
case 85:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",95);}
case 95:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(null));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",102);}
case 102:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",105);}
case 105:{f.StackOp("pop");f.Pc=106;continue;}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=110;continue;}
case 110:{f.StackOp("dup");f.Pc=111;continue;}
case 111:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;"));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[6]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",119);}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",126);}
case 126:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",129);}
case 129:{return rt.DynamicCall(f,"forge/game/Match:2711:129:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",134);}
case 134:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",137);}
case 137:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",140);}
case 140:{f.Pc=47;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[3]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/event/GameEventAnteCardsSelected","fromCards","(Lcom/google/common/collect/Multimap;)Lforge/game/event/GameEventAnteCardsSelected;","invokestatic",148);}
case 148:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",151);}
case 151:{f.Push(f.Locals[1]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",155);}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","lastOutcome","Lforge/game/GameOutcome;"));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[2]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/GameAction","startGame","(Lforge/game/GameOutcome;Ljava/lang/Runnable;)V","invokevirtual",163);}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/Match","executeOwnershipChanges","(Lforge/game/Game;)V","invokevirtual",168);}
case 168:{f.Push(f.Locals[1]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/Game","clearCaches","()V","invokevirtual",172);}
case 172:{f.Push(f.Locals[1]);f.Pc=173;continue;}
case 173:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventGameFinished"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventGameFinished")));f.Pc=176;continue;}
case 176:{f.StackOp("dup");f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/event/GameEventGameFinished","<init>","()V","invokespecial",180);}
case 180:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",183);}
case 183:{return rt.Call(f,"java/lang/System","gc","()V","invokestatic",186);}
case 186:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2712(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","playedMains","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference!=null?22:18;continue;}
case 18:{f.Push(JValue.R(null));f.Pc=19;continue;}
case 19:{f.Pc=26;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",26);}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2713(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","gameOutcomes","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",8);}
case 8:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13);}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameOutcome"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2714(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","gameOutcomes","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","players","Ljava/util/List;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?45:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/player/RegisteredPlayer","restoreDeck","()V","invokevirtual",42);}
case 42:{f.Pc=19;continue;}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2715(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","gameOutcomes","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2716(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","lastOutcome","Lforge/game/GameOutcome;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2717(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","players","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",9);}
case 9:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=11;continue;}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Match","getOutcomes","()Ljava/util/Collection;","invokevirtual",16);}
case 16:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?129:31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameOutcome"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/GameOutcome","getWinningLobbyPlayer","()Lforge/LobbyPlayer;","invokevirtual",45);}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","players","Ljava/util/List;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",59);}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int==0?126:71;continue;}
case 71:{f.Push(f.Locals[6]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",78);}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{f.Locals[7]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[7]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getPlayer","()Lforge/LobbyPlayer;","invokevirtual",88);}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/LobbyPlayer","equals","(Ljava/lang/Object;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?120:96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[5]);f.Pc=99;continue;}
case 99:{f.StackOp("dup2");f.Pc=100;continue;}
case 100:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[5]);f.Pc=107;continue;}
case 107:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/GameRules","getGamesToWinMatch","()I","invokevirtual",115);}
case 115:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?120:118;continue;}
case 118:{f.Push(JValue.I(1));f.Pc=119;continue;}
case 119:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 120:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=123;continue;}
case 123:{f.Pc=61;continue;}
case 126:{f.Pc=22;continue;}
case 129:{f.Push(JValue.I(0));f.Pc=130;continue;}
case 130:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2718(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/Match","getOutcomes","()Ljava/util/Collection;","invokevirtual",6);}
case 6:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?50:21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameOutcome"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/GameOutcome","getWinningLobbyPlayer","()Lforge/LobbyPlayer;","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/LobbyPlayer","equals","(Ljava/lang/Object;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?47:44;continue;}
case 44:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=47;continue;}
case 47:{f.Pc=12;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2719(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","players","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",9);}
case 9:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","(I)Lcom/google/common/collect/HashMultiset;","invokestatic",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/Match","getOutcomes","()Ljava/util/Collection;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?65:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameOutcome"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/GameOutcome","getWinningPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Reference!=null?51:49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return JStep.Return(f.Pop());}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/GameOutcome","getWinningPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",56);}
case 56:{return rt.Call(f,"com/google/common/collect/Multiset","add","(Ljava/lang/Object;)Z","invokeinterface",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Pc=23;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2720(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/Match","getGamesWonBy","(Lforge/LobbyPlayer;)I","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/GameRules","getGamesToWinMatch","()I","invokevirtual",12);}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?19:15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Pc=20;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2721(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Match","isMatchOver","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","lastOutcome","Lforge/game/GameOutcome;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/GameOutcome","getWinningPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2722(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","players","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2723(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Remove CARDNAME from your deck before playing if you're not playing for ante.")));f.Pc=3;continue;}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/deck/Deck","iterator","()Ljava/util/Iterator;","invokevirtual",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?127:26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",50);}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",59);}
case 59:{f.Pc=f.Pop().Int==0?124:62;continue;}
case 62:{f.Push(f.Locals[5]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",69);}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{f.Locals[6]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",87);}
case 87:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",90);}
case 90:{return rt.Call(f,"forge/card/ICardFace","getKeywords","()Ljava/lang/Iterable;","invokeinterface",95);}
case 95:{f.Push(JValue.R(rt.String("Remove CARDNAME from your deck before playing if you're not playing for ante.")));f.Pc=98;continue;}
case 98:{return rt.Call(f,"com/google/common/collect/Iterables","contains","(Ljava/lang/Iterable;Ljava/lang/Object;)Z","invokestatic",101);}
case 101:{f.Pc=f.Pop().Int==0?121:104;continue;}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[6]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Pc=52;continue;}
case 124:{f.Pc=17;continue;}
case 127:{f.Push(f.Locals[2]);f.Pc=128;continue;}
case 128:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2724(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","removedCards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2725(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","removedCards","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2726(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",5);}
case 5:{f.Locals[4]=f.Pop();f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",14);}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",20);}
case 20:{f.Locals[6]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[6]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map$Entry","comparingByKey","()Ljava/util/Comparator;","invokestatic",27);}
case 27:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",32);}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",39);}
case 39:{f.Locals[7]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[7]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",48);}
case 48:{f.Pc=f.Pop().Int==0?153:51;continue;}
case 51:{f.Push(f.Locals[7]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Locals[8]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[8]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{f.Locals[9]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{f.Locals[10]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[10]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[8]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",87);}
case 87:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",93);}
case 93:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?150:96;continue;}
case 96:{f.Push(f.Locals[9]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",102);}
case 102:{f.Locals[11]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[9]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/item/PaperCard","isFoil","()Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int!=0?123:112;continue;}
case 112:{f.Push(f.Locals[3]);f.Pc=113;continue;}
case 113:{f.Pc=f.Pop().Int==0?128:116;continue;}
case 116:{f.Push(JValue.I(5));f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/util/MyRandom","percentTrue","(I)Z","invokestatic",120);}
case 120:{f.Pc=f.Pop().Int==0?128:123;continue;}
case 123:{f.Push(f.Locals[11]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/Card","setRandomFoil","()V","invokevirtual",128);}
case 128:{f.Push(f.Locals[11]);f.Pc=130;continue;}
case 130:{f.Push(JValue.I(1));f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/Card","setCollectible","(Z)V","invokevirtual",134);}
case 134:{f.Push(f.Locals[5]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[11]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",143);}
case 143:{f.StackOp("pop");f.Pc=144;continue;}
case 144:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=147;continue;}
case 147:{f.Pc=78;continue;}
case 150:{f.Pc=41;continue;}
case 153:{f.Push(f.Locals[4]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[5]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/zone/PlayerZone","setCards","(Ljava/lang/Iterable;)V","invokevirtual",160);}
case 160:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2727(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/trigger/Trigger","resetIDs","()V","invokestatic",3);}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearDelayedTrigger","()V","invokevirtual",10);}
case 10:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",29);}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",35);}
case 35:{f.Locals[5]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/Game","getMatch","()Lforge/game/Match;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/Match","getPlayers","()Ljava/util/List;","invokevirtual",44);}
case 44:{f.Locals[6]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","gameOutcomes","Ljava/util/Map;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",55);}
case 55:{f.Locals[7]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[7]);f.Pc=59;continue;}
case 59:{f.Pc=f.Pop().Int!=0?79:62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/GameRules","getGameType","()Lforge/game/GameType;","invokevirtual",69);}
case 69:{return rt.Call(f,"forge/game/GameType","isSideboardingAllowed","()Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?79:75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{f.Pc=80;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{f.Locals[8]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/GameRules","getSideboardForAI","()Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?115:92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/GameRules","getGameType","()Lforge/game/GameType;","invokevirtual",99);}
case 99:{return rt.Call(f,"forge/game/GameType","getDeckFormat","()Lforge/deck/DeckFormat;","invokevirtual",102);}
case 102:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/deck/DeckFormat","equals","(Ljava/lang/Object;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?115:111;continue;}
case 111:{f.Push(JValue.I(1));f.Pc=112;continue;}
case 112:{f.Pc=116;continue;}
case 115:{f.Push(JValue.I(0));f.Pc=116;continue;}
case 116:{f.Locals[9]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","playedMains","Ljava/util/Map;"));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",127);}
case 127:{f.Push(f.Locals[8]);f.Pc=129;continue;}
case 129:{f.Pc=f.Pop().Int==0?204:132;continue;}
case 132:{f.Push(f.Locals[6]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",139);}
case 139:{f.Locals[10]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[10]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",148);}
case 148:{f.Pc=f.Pop().Int==0?204:151;continue;}
case 151:{f.Push(f.Locals[10]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",158);}
case 158:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=161;continue;}
case 161:{f.Locals[11]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[11]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getDeck","()Lforge/deck/Deck;","invokevirtual",168);}
case 168:{f.Pc=f.Pop().Reference==null?201:171;continue;}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","playedMains","Ljava/util/Map;"));f.Pc=175;continue;}
case 175:{f.Push(f.Locals[11]);f.Pc=177;continue;}
case 177:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=180;continue;}
case 180:{f.StackOp("dup");f.Pc=181;continue;}
case 181:{f.Push(f.Locals[11]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getDeck","()Lforge/deck/Deck;","invokevirtual",186);}
case 186:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",189);}
case 189:{return rt.Call(f,"forge/deck/CardPool","toFlatList","()Ljava/util/List;","invokevirtual",192);}
case 192:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",195);}
case 195:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",200);}
case 200:{f.StackOp("pop");f.Pc=201;continue;}
case 201:{f.Pc=141;continue;}
case 204:{f.Push(JValue.R(null));f.Pc=205;continue;}
case 205:{f.Locals[10]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(f.Locals[8]);f.Pc=209;continue;}
case 209:{f.Pc=f.Pop().Int==0?273:212;continue;}
case 212:{f.Push(f.Locals[9]);f.Pc=214;continue;}
case 214:{f.Pc=f.Pop().Int==0?273:217;continue;}
case 217:{f.Push(JValue.I(0));f.Pc=218;continue;}
case 218:{f.Locals[11]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(f.Locals[11]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[5]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/util/collect/FCollectionView","size","()I","invokeinterface",229);}
case 229:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?273:232;continue;}
case 232:{f.Push(f.Locals[5]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[11]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/util/collect/FCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",241);}
case 241:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=244;continue;}
case 244:{f.Locals[12]=f.Pop();f.Pc=246;continue;}
case 246:{f.Push(f.Locals[12]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",251);}
case 251:{return rt.Call(f,"forge/game/player/PlayerController","isAI","()Z","invokevirtual",254);}
case 254:{f.Pc=f.Pop().Int!=0?267:257;continue;}
case 257:{f.Push(f.Locals[12]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",262);}
case 262:{f.Locals[10]=f.Pop();f.Pc=264;continue;}
case 264:{f.Pc=273;continue;}
case 267:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=270;continue;}
case 270:{f.Pc=220;continue;}
case 273:{f.Push(JValue.I(0));f.Pc=274;continue;}
case 274:{f.Locals[11]=f.Pop();f.Pc=276;continue;}
case 276:{f.Push(f.Locals[11]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[6]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",285);}
case 285:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1249:288;continue;}
case 288:{f.Push(f.Locals[5]);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[11]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/util/collect/FCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",297);}
case 297:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=300;continue;}
case 300:{f.Locals[12]=f.Pop();f.Pc=302;continue;}
case 302:{f.Push(f.Locals[6]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[11]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",311);}
case 311:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=314;continue;}
case 314:{f.Locals[13]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[12]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",321);}
case 321:{f.Locals[14]=f.Pop();f.Pc=323;continue;}
case 323:{f.Push(f.Locals[8]);f.Pc=325;continue;}
case 325:{f.Pc=f.Pop().Int==0?780:328;continue;}
case 328:{f.Push(f.Locals[14]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/player/PlayerController","isAI","()Z","invokevirtual",333);}
case 333:{f.Pc=f.Pop().Int==0?348:336;continue;}
case 336:{f.Push(f.Locals[14]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/game/player/PlayerController","sideboardsByItself","()Z","invokevirtual",341);}
case 341:{f.Pc=f.Pop().Int==0?348:344;continue;}
case 344:{f.Push(JValue.I(1));f.Pc=345;continue;}
case 345:{f.Pc=349;continue;}
case 348:{f.Push(JValue.I(0));f.Pc=349;continue;}
case 349:{f.Locals[15]=f.Pop();f.Pc=351;continue;}
case 351:{f.Push(f.Locals[10]);f.Pc=353;continue;}
case 353:{f.Pc=f.Pop().Reference==null?373:356;continue;}
case 356:{f.Push(f.Locals[14]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/player/PlayerController","isAI","()Z","invokevirtual",361);}
case 361:{f.Pc=f.Pop().Int==0?373:364;continue;}
case 364:{f.Push(f.Locals[15]);f.Pc=366;continue;}
case 366:{f.Pc=f.Pop().Int!=0?373:369;continue;}
case 369:{f.Push(f.Locals[10]);f.Pc=371;continue;}
case 371:{f.Locals[14]=f.Pop();f.Pc=373;continue;}
case 373:{f.Push(f.Locals[13]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getDeck","()Lforge/deck/Deck;","invokevirtual",378);}
case 378:{f.Locals[16]=f.Pop();f.Pc=380;continue;}
case 380:{f.Push(f.Locals[0]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/Match","getRemovedCards","()Ljava/util/List;","invokevirtual",384);}
case 384:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",389);}
case 389:{f.Pc=f.Pop().Int!=0?555:392;continue;}
case 392:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=395;continue;}
case 395:{f.StackOp("dup");f.Pc=396;continue;}
case 396:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",399);}
case 399:{f.Locals[17]=f.Pop();f.Pc=401;continue;}
case 401:{f.Push(f.Locals[17]);f.Pc=403;continue;}
case 403:{f.Push(f.Locals[16]);f.Pc=405;continue;}
case 405:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",411);}
case 411:{return rt.Call(f,"forge/deck/CardPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",414);}
case 414:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=417;continue;}
case 417:{f.StackOp("dup");f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",421);}
case 421:{f.Locals[18]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(f.Locals[18]);f.Pc=425;continue;}
case 425:{f.Push(f.Locals[16]);f.Pc=427;continue;}
case 427:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/deck/Deck","getOrCreate","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",433);}
case 433:{return rt.Call(f,"forge/deck/CardPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",436);}
case 436:{f.Push(f.Locals[0]);f.Pc=437;continue;}
case 437:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","removedCards","Ljava/util/List;"));f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",445);}
case 445:{f.Locals[19]=f.Pop();f.Pc=447;continue;}
case 447:{f.Push(f.Locals[19]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",454);}
case 454:{f.Pc=f.Pop().Int==0?513:457;continue;}
case 457:{f.Push(f.Locals[19]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",464);}
case 464:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=467;continue;}
case 467:{f.Locals[20]=f.Pop();f.Pc=469;continue;}
case 469:{f.Push(f.Locals[17]);f.Pc=471;continue;}
case 471:{f.Push(f.Locals[20]);f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/deck/CardPool","contains","(Lforge/item/InventoryItem;)Z","invokevirtual",476);}
case 476:{f.Pc=f.Pop().Int==0?491:479;continue;}
case 479:{f.Push(f.Locals[17]);f.Pc=481;continue;}
case 481:{f.Push(f.Locals[20]);f.Pc=483;continue;}
case 483:{f.Push(JValue.I(1));f.Pc=484;continue;}
case 484:{return rt.Call(f,"forge/deck/CardPool","remove","(Lforge/item/InventoryItem;I)Z","invokevirtual",487);}
case 487:{f.StackOp("pop");f.Pc=488;continue;}
case 488:{f.Pc=510;continue;}
case 491:{f.Push(f.Locals[18]);f.Pc=493;continue;}
case 493:{f.Push(f.Locals[20]);f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/deck/CardPool","contains","(Lforge/item/InventoryItem;)Z","invokevirtual",498);}
case 498:{f.Pc=f.Pop().Int==0?510:501;continue;}
case 501:{f.Push(f.Locals[18]);f.Pc=503;continue;}
case 503:{f.Push(f.Locals[20]);f.Pc=505;continue;}
case 505:{f.Push(JValue.I(1));f.Pc=506;continue;}
case 506:{return rt.Call(f,"forge/deck/CardPool","remove","(Lforge/item/InventoryItem;I)Z","invokevirtual",509);}
case 509:{f.StackOp("pop");f.Pc=510;continue;}
case 510:{f.Pc=447;continue;}
case 513:{f.Push(f.Locals[16]);f.Pc=515;continue;}
case 515:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",518);}
case 518:{return rt.Call(f,"forge/deck/CardPool","clear","()V","invokevirtual",521);}
case 521:{f.Push(f.Locals[16]);f.Pc=523;continue;}
case 523:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",526);}
case 526:{f.Push(f.Locals[17]);f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/deck/CardPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",531);}
case 531:{f.Push(f.Locals[16]);f.Pc=533;continue;}
case 533:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=536;continue;}
case 536:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",539);}
case 539:{return rt.Call(f,"forge/deck/CardPool","clear","()V","invokevirtual",542);}
case 542:{f.Push(f.Locals[16]);f.Pc=544;continue;}
case 544:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=547;continue;}
case 547:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",550);}
case 550:{f.Push(f.Locals[18]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"forge/deck/CardPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",555);}
case 555:{f.Push(f.Locals[14]);f.Pc=557;continue;}
case 557:{f.Push(f.Locals[16]);f.Pc=559;continue;}
case 559:{f.Push(f.Locals[0]);f.Pc=560;continue;}
case 560:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=563;continue;}
case 563:{return rt.Call(f,"forge/game/GameRules","getGameType","()Lforge/game/GameType;","invokevirtual",566);}
case 566:{f.Push(f.Locals[12]);f.Pc=568;continue;}
case 568:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",571);}
case 571:{return rt.Call(f,"forge/game/player/PlayerController","sideboard","(Lforge/deck/Deck;Lforge/game/GameType;Ljava/lang/String;)Ljava/util/List;","invokevirtual",574);}
case 574:{f.Locals[17]=f.Pop();f.Pc=576;continue;}
case 576:{f.Push(f.Locals[15]);f.Pc=578;continue;}
case 578:{f.Pc=f.Pop().Int==0?655:581;continue;}
case 581:{f.Push(f.Locals[16]);f.Pc=583;continue;}
case 583:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=586;continue;}
case 586:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",589);}
case 589:{f.Pc=f.Pop().Int==0?655:592;continue;}
case 592:{f.Push(f.Locals[14]);f.Pc=594;continue;}
case 594:{return rt.Call(f,"forge/game/player/PlayerController","getSideboardingReport","()Ljava/util/List;","invokevirtual",597);}
case 597:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",602);}
case 602:{f.Locals[18]=f.Pop();f.Pc=604;continue;}
case 604:{f.Push(f.Locals[18]);f.Pc=606;continue;}
case 606:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",611);}
case 611:{f.Pc=f.Pop().Int==0?655:614;continue;}
case 614:{f.Push(f.Locals[18]);f.Pc=616;continue;}
case 616:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",621);}
case 621:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=624;continue;}
case 624:{f.Locals[19]=f.Pop();f.Pc=626;continue;}
case 626:{f.Push(f.Locals[1]);f.Pc=627;continue;}
case 627:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=630;continue;}
case 630:{f.StackOp("dup");f.Pc=631;continue;}
case 631:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","SIDEBOARD","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","SIDEBOARD","Lforge/game/GameLogEntryType;"));f.Pc=634;continue;}
case 634:{f.Push(f.Locals[12]);f.Pc=636;continue;}
case 636:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",639);}
case 639:{f.Push(f.Locals[19]);f.Pc=641;continue;}
case 641:{return rt.DynamicCall(f,"forge/game/Match:2727:641:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",646);}
case 646:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",649);}
case 649:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",652);}
case 652:{f.Pc=604;continue;}
case 655:{f.Push(JValue.R(null));f.Pc=656;continue;}
case 656:{f.Push(f.Locals[17]);f.Pc=658;continue;}
case 658:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?780:661;continue;}
case 661:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=664;continue;}
case 664:{f.StackOp("dup");f.Pc=665;continue;}
case 665:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",668);}
case 668:{f.Locals[18]=f.Pop();f.Pc=670;continue;}
case 670:{f.Push(f.Locals[18]);f.Pc=672;continue;}
case 672:{f.Push(f.Locals[16]);f.Pc=674;continue;}
case 674:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=677;continue;}
case 677:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",680);}
case 680:{return rt.Call(f,"forge/deck/CardPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",683);}
case 683:{f.Push(f.Locals[18]);f.Pc=685;continue;}
case 685:{f.Push(f.Locals[16]);f.Pc=687;continue;}
case 687:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=690;continue;}
case 690:{return rt.Call(f,"forge/deck/Deck","getOrCreate","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",693);}
case 693:{return rt.Call(f,"forge/deck/CardPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",696);}
case 696:{f.Push(f.Locals[17]);f.Pc=698;continue;}
case 698:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",703);}
case 703:{f.Locals[19]=f.Pop();f.Pc=705;continue;}
case 705:{f.Push(f.Locals[19]);f.Pc=707;continue;}
case 707:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",712);}
case 712:{f.Pc=f.Pop().Int==0?738:715;continue;}
case 715:{f.Push(f.Locals[19]);f.Pc=717;continue;}
case 717:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",722);}
case 722:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=725;continue;}
case 725:{f.Locals[20]=f.Pop();f.Pc=727;continue;}
case 727:{f.Push(f.Locals[18]);f.Pc=729;continue;}
case 729:{f.Push(f.Locals[20]);f.Pc=731;continue;}
case 731:{return rt.Call(f,"forge/deck/CardPool","remove","(Lforge/item/InventoryItem;)Z","invokevirtual",734);}
case 734:{f.StackOp("pop");f.Pc=735;continue;}
case 735:{f.Pc=705;continue;}
case 738:{f.Push(f.Locals[16]);f.Pc=740;continue;}
case 740:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",743);}
case 743:{return rt.Call(f,"forge/deck/CardPool","clear","()V","invokevirtual",746);}
case 746:{f.Push(f.Locals[16]);f.Pc=748;continue;}
case 748:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",751);}
case 751:{f.Push(f.Locals[17]);f.Pc=753;continue;}
case 753:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/Iterable;)V","invokevirtual",756);}
case 756:{f.Push(f.Locals[16]);f.Pc=758;continue;}
case 758:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=761;continue;}
case 761:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",764);}
case 764:{return rt.Call(f,"forge/deck/CardPool","clear","()V","invokevirtual",767);}
case 767:{f.Push(f.Locals[16]);f.Pc=769;continue;}
case 769:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=772;continue;}
case 772:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",775);}
case 775:{f.Push(f.Locals[18]);f.Pc=777;continue;}
case 777:{return rt.Call(f,"forge/deck/CardPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",780);}
case 780:{f.Push(f.Locals[13]);f.Pc=782;continue;}
case 782:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getDeck","()Lforge/deck/Deck;","invokevirtual",785);}
case 785:{f.Locals[15]=f.Pop();f.Pc=787;continue;}
case 787:{f.Push(f.Locals[15]);f.Pc=789;continue;}
case 789:{f.Pc=f.Pop().Reference!=null?870:792;continue;}
case 792:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=795;continue;}
case 795:{f.Push(f.Locals[13]);f.Pc=797;continue;}
case 797:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getPlayer","()Lforge/LobbyPlayer;","invokevirtual",800);}
case 800:{return rt.Call(f,"forge/LobbyPlayer","getName","()Ljava/lang/String;","invokevirtual",803);}
case 803:{return rt.DynamicCall(f,"forge/game/Match:2727:803:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",808);}
case 808:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",811);}
case 811:{f.Push(f.Locals[0]);f.Pc=812;continue;}
case 812:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=815;continue;}
case 815:{return rt.Call(f,"forge/game/GameRules","getGameType","()Lforge/game/GameType;","invokevirtual",818);}
case 818:{return rt.Call(f,"forge/game/GameType","getDeckFormat","()Lforge/deck/DeckFormat;","invokevirtual",821);}
case 821:{return rt.Call(f,"forge/deck/DeckFormat","getMainRange","()Lorg/apache/commons/lang3/Range;","invokevirtual",824);}
case 824:{return rt.Call(f,"org/apache/commons/lang3/Range","getMinimum","()Ljava/lang/Object;","invokevirtual",827);}
case 827:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=830;continue;}
case 830:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",833);}
case 833:{f.Locals[16]=f.Pop();f.Pc=835;continue;}
case 835:{if(!rt.EnsureInitialized(f,"forge/deck/Deck"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/Deck")));f.Pc=838;continue;}
case 838:{f.StackOp("dup");f.Pc=839;continue;}
case 839:{f.Push(JValue.R(rt.String("NULL")));f.Pc=842;continue;}
case 842:{return rt.Call(f,"forge/deck/Deck","<init>","(Ljava/lang/String;)V","invokespecial",845);}
case 845:{f.Locals[15]=f.Pop();f.Pc=847;continue;}
case 847:{f.Push(f.Locals[16]);f.Pc=849;continue;}
case 849:{f.Pc=f.Pop().Int<=0?865:852;continue;}
case 852:{f.Push(f.Locals[15]);f.Pc=854;continue;}
case 854:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",857);}
case 857:{f.Push(JValue.R(rt.String("Wastes")));f.Pc=860;continue;}
case 860:{f.Push(f.Locals[16]);f.Pc=862;continue;}
case 862:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/String;I)V","invokevirtual",865);}
case 865:{f.Pc=870;continue;}
case 868:{f.Locals[16]=f.Pop();f.Pc=870;continue;}
case 870:{f.Push(f.Locals[15]);f.Pc=872;continue;}
case 872:{return rt.Call(f,"forge/deck/Deck","getValid","()Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",875);}
case 875:{f.Locals[16]=f.Pop();f.Pc=877;continue;}
case 877:{f.Push(f.Locals[12]);f.Pc=879;continue;}
case 879:{f.Push(f.Locals[16]);f.Pc=881;continue;}
case 881:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",884);}
case 884:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=887;continue;}
case 887:{return rt.Call(f,"forge/deck/Deck","getDraftNotes","()Ljava/util/Map;","invokevirtual",890);}
case 890:{return rt.Call(f,"forge/game/player/Player","setDraftNotes","(Ljava/util/Map;)V","invokevirtual",893);}
case 893:{f.Push(JValue.R(null));f.Pc=894;continue;}
case 894:{f.Locals[17]=f.Pop();f.Pc=896;continue;}
case 896:{f.Push(f.Locals[0]);f.Pc=897;continue;}
case 897:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=900;continue;}
case 900:{return rt.Call(f,"forge/game/GameRules","useAnte","()Z","invokevirtual",903);}
case 903:{f.Pc=f.Pop().Int!=0?1007:906;continue;}
case 906:{f.Push(f.Locals[16]);f.Pc=908;continue;}
case 908:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",911);}
case 911:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=914;continue;}
case 914:{return rt.Call(f,"forge/game/Match","getRemovedAnteCards","(Lforge/deck/Deck;)Ljava/util/Set;","invokestatic",917);}
case 917:{f.Locals[17]=f.Pop();f.Pc=919;continue;}
case 919:{f.Push(f.Locals[17]);f.Pc=921;continue;}
case 921:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",926);}
case 926:{f.Locals[18]=f.Pop();f.Pc=928;continue;}
case 928:{f.Push(f.Locals[18]);f.Pc=930;continue;}
case 930:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",935);}
case 935:{f.Pc=f.Pop().Int==0?1007:938;continue;}
case 938:{f.Push(f.Locals[18]);f.Pc=940;continue;}
case 940:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",945);}
case 945:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=948;continue;}
case 948:{f.Locals[19]=f.Pop();f.Pc=950;continue;}
case 950:{f.Push(f.Locals[16]);f.Pc=952;continue;}
case 952:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",955);}
case 955:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=958;continue;}
case 958:{return rt.Call(f,"forge/deck/Deck","iterator","()Ljava/util/Iterator;","invokevirtual",961);}
case 961:{f.Locals[20]=f.Pop();f.Pc=963;continue;}
case 963:{f.Push(f.Locals[20]);f.Pc=965;continue;}
case 965:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",970);}
case 970:{f.Pc=f.Pop().Int==0?1004:973;continue;}
case 973:{f.Push(f.Locals[20]);f.Pc=975;continue;}
case 975:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",980);}
case 980:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=983;continue;}
case 983:{f.Locals[21]=f.Pop();f.Pc=985;continue;}
case 985:{f.Push(f.Locals[21]);f.Pc=987;continue;}
case 987:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",992);}
case 992:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=995;continue;}
case 995:{f.Push(f.Locals[19]);f.Pc=997;continue;}
case 997:{return rt.Call(f,"forge/deck/CardPool","removeAll","(Lforge/item/InventoryItem;)Z","invokevirtual",1000);}
case 1000:{f.StackOp("pop");f.Pc=1001;continue;}
case 1001:{f.Pc=963;continue;}
case 1004:{f.Pc=928;continue;}
case 1007:{f.Push(f.Locals[12]);f.Pc=1009;continue;}
case 1009:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=1012;continue;}
case 1012:{f.Push(f.Locals[16]);f.Pc=1014;continue;}
case 1014:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",1017);}
case 1017:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1020;continue;}
case 1020:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",1023);}
case 1023:{f.Push(f.Locals[13]);f.Pc=1025;continue;}
case 1025:{return rt.Call(f,"forge/game/player/RegisteredPlayer","useRandomFoil","()Z","invokevirtual",1028);}
case 1028:{return rt.Call(f,"forge/game/Match","preparePlayerZone","(Lforge/game/player/Player;Lforge/game/zone/ZoneType;Lforge/deck/CardPool;Z)V","invokestatic",1031);}
case 1031:{f.Push(f.Locals[16]);f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",1036);}
case 1036:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1039;continue;}
case 1039:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=1042;continue;}
case 1042:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",1045);}
case 1045:{f.Pc=f.Pop().Int==0?1083:1048;continue;}
case 1048:{f.Push(f.Locals[12]);f.Pc=1050;continue;}
case 1050:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=1053;continue;}
case 1053:{f.Push(f.Locals[16]);f.Pc=1055;continue;}
case 1055:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",1058);}
case 1058:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1061;continue;}
case 1061:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=1064;continue;}
case 1064:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",1067);}
case 1067:{f.Push(f.Locals[13]);f.Pc=1069;continue;}
case 1069:{return rt.Call(f,"forge/game/player/RegisteredPlayer","useRandomFoil","()Z","invokevirtual",1072);}
case 1072:{return rt.Call(f,"forge/game/Match","preparePlayerZone","(Lforge/game/player/Player;Lforge/game/zone/ZoneType;Lforge/deck/CardPool;Z)V","invokestatic",1075);}
case 1075:{f.Push(f.Locals[12]);f.Pc=1077;continue;}
case 1077:{f.Push(f.Locals[1]);f.Pc=1078;continue;}
case 1078:{f.Push(f.Locals[14]);f.Pc=1080;continue;}
case 1080:{return rt.Call(f,"forge/game/player/Player","assignCompanion","(Lforge/game/Game;Lforge/game/player/PlayerController;)V","invokevirtual",1083);}
case 1083:{f.Push(f.Locals[12]);f.Pc=1085;continue;}
case 1085:{f.Push(f.Locals[13]);f.Pc=1087;continue;}
case 1087:{return rt.Call(f,"forge/game/player/Player","initVariantsZones","(Lforge/game/player/RegisteredPlayer;)V","invokevirtual",1090);}
case 1090:{f.Push(f.Locals[12]);f.Pc=1092;continue;}
case 1092:{f.Push(JValue.R(null));f.Pc=1093;continue;}
case 1093:{return rt.Call(f,"forge/game/player/Player","shuffle","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1096);}
case 1096:{f.Push(f.Locals[7]);f.Pc=1098;continue;}
case 1098:{f.Pc=f.Pop().Int==0?1148:1101;continue;}
case 1101:{f.Push(f.Locals[12]);f.Pc=1103;continue;}
case 1103:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1106);}
case 1106:{f.Push(f.Locals[16]);f.Pc=1108;continue;}
case 1108:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",1111);}
case 1111:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1114;continue;}
case 1114:{return rt.Call(f,"forge/game/player/PlayerController","complainCardsCantPlayWell","(Lforge/deck/Deck;)Ljava/util/Map;","invokevirtual",1117);}
case 1117:{f.Locals[18]=f.Pop();f.Pc=1119;continue;}
case 1119:{f.Push(f.Locals[18]);f.Pc=1121;continue;}
case 1121:{f.Pc=f.Pop().Reference==null?1145:1124;continue;}
case 1124:{f.Push(f.Locals[18]);f.Pc=1126;continue;}
case 1126:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",1131);}
case 1131:{f.Pc=f.Pop().Int!=0?1145:1134;continue;}
case 1134:{f.Push(f.Locals[2]);f.Pc=1135;continue;}
case 1135:{f.Push(f.Locals[12]);f.Pc=1137;continue;}
case 1137:{f.Push(f.Locals[18]);f.Pc=1139;continue;}
case 1139:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1144);}
case 1144:{f.StackOp("pop");f.Pc=1145;continue;}
case 1145:{f.Pc=1199;continue;}
case 1148:{f.Push(f.Locals[12]);f.Pc=1150;continue;}
case 1150:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=1153;continue;}
case 1153:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1156);}
case 1156:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1161);}
case 1161:{f.Locals[18]=f.Pop();f.Pc=1163;continue;}
case 1163:{f.Push(f.Locals[18]);f.Pc=1165;continue;}
case 1165:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1170);}
case 1170:{f.Pc=f.Pop().Int==0?1199:1173;continue;}
case 1173:{f.Push(f.Locals[18]);f.Pc=1175;continue;}
case 1175:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1180);}
case 1180:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1183;continue;}
case 1183:{f.Locals[19]=f.Pop();f.Pc=1185;continue;}
case 1185:{f.Push(f.Locals[19]);f.Pc=1187;continue;}
case 1187:{f.Push(JValue.I(0));f.Pc=1188;continue;}
case 1188:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",1191);}
case 1191:{f.Push(f.Locals[19]);f.Pc=1193;continue;}
case 1193:{return rt.Call(f,"forge/game/card/Card","resetActivationsPerTurn","()V","invokevirtual",1196);}
case 1196:{f.Pc=1163;continue;}
case 1199:{f.Push(f.Locals[17]);f.Pc=1201;continue;}
case 1201:{f.Pc=f.Pop().Reference==null?1225:1204;continue;}
case 1204:{f.Push(f.Locals[17]);f.Pc=1206;continue;}
case 1206:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",1211);}
case 1211:{f.Pc=f.Pop().Int!=0?1225:1214;continue;}
case 1214:{f.Push(f.Locals[3]);f.Pc=1215;continue;}
case 1215:{f.Push(f.Locals[12]);f.Pc=1217;continue;}
case 1217:{f.Push(f.Locals[17]);f.Pc=1219;continue;}
case 1219:{return rt.Call(f,"com/google/common/collect/Multimap","putAll","(Ljava/lang/Object;Ljava/lang/Iterable;)Z","invokeinterface",1224);}
case 1224:{f.StackOp("pop");f.Pc=1225;continue;}
case 1225:{f.Push(f.Locals[4]);f.Pc=1227;continue;}
case 1227:{f.Push(f.Locals[12]);f.Pc=1229;continue;}
case 1229:{f.Push(f.Locals[16]);f.Pc=1231;continue;}
case 1231:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",1234);}
case 1234:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1237;continue;}
case 1237:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1242);}
case 1242:{f.StackOp("pop");f.Pc=1243;continue;}
case 1243:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=1246;continue;}
case 1246:{f.Pc=276;continue;}
case 1249:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1252);}
case 1252:{f.Locals[11]=f.Pop();f.Pc=1254;continue;}
case 1254:{f.Push(f.Locals[2]);f.Pc=1255;continue;}
case 1255:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",1260);}
case 1260:{f.Pc=f.Pop().Int!=0?1306:1263;continue;}
case 1263:{f.Push(f.Locals[0]);f.Pc=1264;continue;}
case 1264:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=1267;continue;}
case 1267:{return rt.Call(f,"forge/game/GameRules","getGameType","()Lforge/game/GameType;","invokevirtual",1270);}
case 1270:{return rt.Call(f,"forge/game/GameType","isCardPoolLimited","()Z","invokevirtual",1273);}
case 1273:{f.Pc=f.Pop().Int!=0?1306:1276;continue;}
case 1276:{f.Push(f.Locals[0]);f.Pc=1277;continue;}
case 1277:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=1280;continue;}
case 1280:{return rt.Call(f,"forge/game/GameRules","warnAboutAICards","()Z","invokevirtual",1283);}
case 1283:{f.Pc=f.Pop().Int==0?1306:1286;continue;}
case 1286:{f.Push(f.Locals[1]);f.Pc=1287;continue;}
case 1287:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1290);}
case 1290:{f.Push(f.Locals[11]);f.Pc=1292;continue;}
case 1292:{f.Push(JValue.R(rt.String("lblAICantPlayCards")));f.Pc=1295;continue;}
case 1295:{f.Push(JValue.I(0));f.Pc=1296;continue;}
case 1296:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1299;continue;}
case 1299:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1302);}
case 1302:{f.Push(f.Locals[2]);f.Pc=1303;continue;}
case 1303:{return rt.Call(f,"forge/game/GameAction","revealUnplayableByAI","(Ljava/lang/String;Ljava/util/Map;)V","invokevirtual",1306);}
case 1306:{f.Push(f.Locals[3]);f.Pc=1307;continue;}
case 1307:{return rt.Call(f,"com/google/common/collect/Multimap","isEmpty","()Z","invokeinterface",1312);}
case 1312:{f.Pc=f.Pop().Int!=0?1335:1315;continue;}
case 1315:{f.Push(f.Locals[1]);f.Pc=1316;continue;}
case 1316:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1319);}
case 1319:{f.Push(f.Locals[11]);f.Pc=1321;continue;}
case 1321:{f.Push(JValue.R(rt.String("lblAnteCardsRemoved")));f.Pc=1324;continue;}
case 1324:{f.Push(JValue.I(0));f.Pc=1325;continue;}
case 1325:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1328;continue;}
case 1328:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1331);}
case 1331:{f.Push(f.Locals[3]);f.Pc=1332;continue;}
case 1332:{return rt.Call(f,"forge/game/GameAction","revealAnte","(Ljava/lang/String;Lcom/google/common/collect/Multimap;)V","invokevirtual",1335);}
case 1335:{f.Push(f.Locals[4]);f.Pc=1337;continue;}
case 1337:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",1342);}
case 1342:{f.Pc=f.Pop().Int!=0?1354:1345;continue;}
case 1345:{f.Push(f.Locals[1]);f.Pc=1346;continue;}
case 1346:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1349);}
case 1349:{f.Push(f.Locals[4]);f.Pc=1351;continue;}
case 1351:{return rt.Call(f,"forge/game/GameAction","revealUnsupported","(Ljava/util/Map;)V","invokevirtual",1354);}
case 1354:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2728(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getOutcome","()Lforge/game/GameOutcome;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","players","Ljava/util/List;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(JValue.I(-1));f.Pc=25;continue;}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{f.Locals[6]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[6]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?397:37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",41);}
case 41:{f.Push(f.Locals[6]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[7]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[7]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/player/Player","getRegisteredPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",56);}
case 56:{f.Locals[8]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[7]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/player/Player","getLostOwnership","()Lforge/game/card/CardCollectionView;","invokevirtual",63);}
case 63:{f.Locals[9]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[7]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/player/Player","getGainedOwnership","()Lforge/game/card/CardCollectionView;","invokevirtual",70);}
case 70:{f.Locals[10]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[9]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int!=0?149:82;continue;}
case 82:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=85;continue;}
case 85:{f.StackOp("dup");f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",89);}
case 89:{f.Locals[11]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[9]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",98);}
case 98:{f.Locals[12]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[12]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",107);}
case 107:{f.Pc=f.Pop().Int==0?141:110;continue;}
case 110:{f.Push(f.Locals[12]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",117);}
case 117:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=120;continue;}
case 120:{f.Locals[13]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[11]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[13]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",129);}
case 129:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",137);}
case 137:{f.StackOp("pop");f.Pc=138;continue;}
case 138:{f.Pc=100;continue;}
case 141:{f.Push(f.Locals[2]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[8]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[11]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/GameOutcome","addAnteLost","(Lforge/game/player/RegisteredPlayer;Ljava/util/List;)V","invokevirtual",149);}
case 149:{f.Push(f.Locals[10]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",156);}
case 156:{f.Pc=f.Pop().Int!=0?226:159;continue;}
case 159:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=162;continue;}
case 162:{f.StackOp("dup");f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",166);}
case 166:{f.Locals[11]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[10]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",175);}
case 175:{f.Locals[12]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[12]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",184);}
case 184:{f.Pc=f.Pop().Int==0?218:187;continue;}
case 187:{f.Push(f.Locals[12]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",194);}
case 194:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=197;continue;}
case 197:{f.Locals[13]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[11]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[13]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",206);}
case 206:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",214);}
case 214:{f.StackOp("pop");f.Pc=215;continue;}
case 215:{f.Pc=177;continue;}
case 218:{f.Push(f.Locals[2]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[8]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[11]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/GameOutcome","addAnteWon","(Lforge/game/player/RegisteredPlayer;Ljava/util/List;)V","invokevirtual",226);}
case 226:{f.Push(f.Locals[0]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/Match","getRules","()Lforge/game/GameRules;","invokevirtual",230);}
case 230:{return rt.Call(f,"forge/game/GameRules","useAnte","()Z","invokevirtual",233);}
case 233:{f.Pc=f.Pop().Int!=0?239:236;continue;}
case 236:{f.Pc=391;continue;}
case 239:{f.Push(f.Locals[2]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/GameOutcome","isDraw","()Z","invokevirtual",243);}
case 243:{f.Pc=f.Pop().Int==0?249:246;continue;}
case 246:{f.Pc=391;continue;}
case 249:{f.Push(f.Locals[7]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/player/Player","hasLost","()Z","invokevirtual",254);}
case 254:{f.Pc=f.Pop().Int!=0?264:257;continue;}
case 257:{f.Push(f.Locals[6]);f.Pc=259;continue;}
case 259:{f.Locals[5]=f.Pop();f.Pc=261;continue;}
case 261:{f.Pc=391;continue;}
case 264:{f.Push(f.Locals[0]);f.Pc=265;continue;}
case 265:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","players","Ljava/util/List;"));f.Pc=268;continue;}
case 268:{f.Push(f.Locals[6]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",275);}
case 275:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getDeck","()Lforge/deck/Deck;","invokevirtual",281);}
case 281:{f.Locals[11]=f.Pop();f.Pc=283;continue;}
case 283:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=286;continue;}
case 286:{f.StackOp("dup");f.Pc=287;continue;}
case 287:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",290);}
case 290:{f.Locals[12]=f.Pop();f.Pc=292;continue;}
case 292:{f.Push(f.Locals[7]);f.Pc=294;continue;}
case 294:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"));f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",300);}
case 300:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",305);}
case 305:{f.Locals[13]=f.Pop();f.Pc=307;continue;}
case 307:{f.Push(f.Locals[13]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",314);}
case 314:{f.Pc=f.Pop().Int==0?383:317;continue;}
case 317:{f.Push(f.Locals[13]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",324);}
case 324:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=327;continue;}
case 327:{f.Locals[14]=f.Pop();f.Pc=329;continue;}
case 329:{f.Push(f.Locals[14]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/card/Card","isCollectible","()Z","invokevirtual",334);}
case 334:{f.Pc=f.Pop().Int!=0?340:337;continue;}
case 337:{f.Pc=307;continue;}
case 340:{f.Push(f.Locals[14]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",345);}
case 345:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=348;continue;}
case 348:{f.Locals[15]=f.Pop();f.Pc=350;continue;}
case 350:{f.Push(f.Locals[11]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",355);}
case 355:{f.Push(f.Locals[15]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/deck/CardPool","remove","(Lforge/item/InventoryItem;)Z","invokevirtual",360);}
case 360:{f.StackOp("pop");f.Pc=361;continue;}
case 361:{f.Push(f.Locals[12]);f.Pc=363;continue;}
case 363:{f.Push(f.Locals[15]);f.Pc=365;continue;}
case 365:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",370);}
case 370:{f.StackOp("pop");f.Pc=371;continue;}
case 371:{f.Push(f.Locals[3]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[15]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",379);}
case 379:{f.StackOp("pop");f.Pc=380;continue;}
case 380:{f.Pc=307;continue;}
case 383:{f.Push(f.Locals[2]);f.Pc=384;continue;}
case 384:{f.Push(f.Locals[8]);f.Pc=386;continue;}
case 386:{f.Push(f.Locals[12]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/GameOutcome","addAnteLost","(Lforge/game/player/RegisteredPlayer;Ljava/util/List;)V","invokevirtual",391);}
case 391:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=394;continue;}
case 394:{f.Pc=30;continue;}
case 397:{f.Push(f.Locals[0]);f.Pc=398;continue;}
case 398:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/GameRules","useAnte","()Z","invokevirtual",404);}
case 404:{f.Pc=f.Pop().Int==0?533:407;continue;}
case 407:{f.Push(f.Locals[5]);f.Pc=409;continue;}
case 409:{f.Pc=f.Pop().Int<0?533:412;continue;}
case 412:{f.Push(f.Locals[1]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",416);}
case 416:{f.Push(f.Locals[5]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",421);}
case 421:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=424;continue;}
case 424:{f.Locals[6]=f.Pop();f.Pc=426;continue;}
case 426:{f.Push(f.Locals[6]);f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/game/player/Player","getRegisteredPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",431);}
case 431:{f.Locals[7]=f.Pop();f.Pc=433;continue;}
case 433:{f.Push(f.Locals[2]);f.Pc=434;continue;}
case 434:{f.Push(f.Locals[7]);f.Pc=436;continue;}
case 436:{f.Push(f.Locals[3]);f.Pc=437;continue;}
case 437:{return rt.Call(f,"forge/game/GameOutcome","addAnteWon","(Lforge/game/player/RegisteredPlayer;Ljava/util/List;)V","invokevirtual",440);}
case 440:{f.Push(f.Locals[0]);f.Pc=441;continue;}
case 441:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","rules","Lforge/game/GameRules;"));f.Pc=444;continue;}
case 444:{return rt.Call(f,"forge/game/GameRules","getGameType","()Lforge/game/GameType;","invokevirtual",447);}
case 447:{return rt.Call(f,"forge/game/GameType","canAddWonCardsMidGame","()Z","invokevirtual",450);}
case 450:{f.Pc=f.Pop().Int==0?533:453;continue;}
case 453:{f.Push(f.Locals[6]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",458);}
case 458:{f.Push(f.Locals[3]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsYouWonToAddToDeck","(Ljava/util/List;)Ljava/util/List;","invokevirtual",462);}
case 462:{f.Locals[8]=f.Pop();f.Pc=464;continue;}
case 464:{f.Push(JValue.R(null));f.Pc=465;continue;}
case 465:{f.Push(f.Locals[8]);f.Pc=467;continue;}
case 467:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?533:470;continue;}
case 470:{f.Push(f.Locals[0]);f.Pc=471;continue;}
case 471:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","players","Ljava/util/List;"));f.Pc=474;continue;}
case 474:{f.Push(f.Locals[5]);f.Pc=476;continue;}
case 476:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",481);}
case 481:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/RegisteredPlayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=484;continue;}
case 484:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getDeck","()Lforge/deck/Deck;","invokevirtual",487);}
case 487:{f.Locals[9]=f.Pop();f.Pc=489;continue;}
case 489:{f.Push(f.Locals[8]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",496);}
case 496:{f.Locals[10]=f.Pop();f.Pc=498;continue;}
case 498:{f.Push(f.Locals[10]);f.Pc=500;continue;}
case 500:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",505);}
case 505:{f.Pc=f.Pop().Int==0?533:508;continue;}
case 508:{f.Push(f.Locals[10]);f.Pc=510;continue;}
case 510:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",515);}
case 515:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=518;continue;}
case 518:{f.Locals[11]=f.Pop();f.Pc=520;continue;}
case 520:{f.Push(f.Locals[9]);f.Pc=522;continue;}
case 522:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",525);}
case 525:{f.Push(f.Locals[11]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;)V","invokevirtual",530);}
case 530:{f.Pc=498;continue;}
case 533:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2729(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameOutcome$AnteResult"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameOutcome$AnteResult")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameOutcome$AnteResult","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","gameOutcomes","Ljava/util/Map;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?80:32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameOutcome"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/GameOutcome","getAnteResult","(Lforge/game/player/RegisteredPlayer;)Lforge/game/GameOutcome$AnteResult;","invokevirtual",49);}
case 49:{f.Locals[5]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{f.Pc=f.Pop().Reference!=null?59:56;continue;}
case 56:{f.Pc=23;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome$AnteResult","wonCards","Ljava/util/List;"));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/GameOutcome$AnteResult","addWon","(Ljava/util/List;)V","invokevirtual",68);}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/game/GameOutcome$AnteResult","lostCards","Ljava/util/List;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/GameOutcome$AnteResult","addLost","(Ljava/util/List;)V","invokevirtual",77);}
case 77:{f.Pc=23;continue;}
case 80:{f.Push(f.Locals[2]);f.Pc=81;continue;}
case 81:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2730(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","events","Lcom/google/common/eventbus/EventBus;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/eventbus/EventBus","post","(Ljava/lang/Object;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2731(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/Match","events","Lcom/google/common/eventbus/EventBus;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/eventbus/EventBus","register","(Ljava/lang/Object;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

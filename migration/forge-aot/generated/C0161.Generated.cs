// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C161{
internal static JClass Build(){var c=new JClass("forge/game/GameSnapshot","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("origGame","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("newGame","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("restore","Z",false,JValue.Default("Z"),null));
c.Add(new JField("gameObjectMap","Lforge/game/GameSnapshot$SnapshotEntityMap;",false,JValue.Default("Lforge/game/GameSnapshot$SnapshotEntityMap;"),null));
c.Add(new JMethod(2537,"forge/game/GameSnapshot","<init>","(Lforge/game/Game;)V",1,2,4,new JHandler[]{},M2537));
c.Add(new JMethod(2538,"forge/game/GameSnapshot","getCopiedGame","()Lforge/game/Game;",1,1,1,new JHandler[]{},M2538));
c.Add(new JMethod(2539,"forge/game/GameSnapshot","makeCopy","()Lforge/game/Game;",1,1,3,new JHandler[]{},M2539));
c.Add(new JMethod(2540,"forge/game/GameSnapshot","makeCopy","(Ljava/util/List;Z)Lforge/game/Game;",1,6,6,new JHandler[]{},M2540));
c.Add(new JMethod(2541,"forge/game/GameSnapshot","restoreGameState","(Lforge/game/Game;)V",1,2,4,new JHandler[]{},M2541));
c.Add(new JMethod(2542,"forge/game/GameSnapshot","assignGameState","(Lforge/game/Game;Lforge/game/Game;Z)V",1,12,4,new JHandler[]{},M2542));
c.Add(new JMethod(2543,"forge/game/GameSnapshot","assignPlayerState","(Lforge/game/player/Player;Lforge/game/player/Player;)V",1,4,3,new JHandler[]{},M2543));
c.Add(new JMethod(2544,"forge/game/GameSnapshot","copyManaPool","(Lforge/game/player/Player;Lforge/game/player/Player;)V",2,6,5,new JHandler[]{},M2544));
c.Add(new JMethod(2545,"forge/game/GameSnapshot","copyMana","(Lforge/game/mana/Mana;Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/mana/Mana;",2,7,6,new JHandler[]{},M2545));
c.Add(new JMethod(2546,"forge/game/GameSnapshot","copyStack","(Lforge/game/Game;Lforge/game/Game;)V",2,14,5,new JHandler[]{},M2546));
c.Add(new JMethod(2547,"forge/game/GameSnapshot","copyGameState","(Lforge/game/Game;Lforge/game/Game;)V",1,11,8,new JHandler[]{},M2547));
c.Add(new JMethod(2548,"forge/game/GameSnapshot","getCardsToCopy","(Lforge/game/Game;)Lforge/game/card/CardCollectionView;",10,4,3,new JHandler[]{},M2548));
c.Add(new JMethod(2549,"forge/game/GameSnapshot","findCardById","(Lforge/game/Game;I)Lforge/game/card/Card;",10,7,2,new JHandler[]{},M2549));
c.Add(new JMethod(2550,"forge/game/GameSnapshot","createCardCopy","(Lforge/game/Game;Lforge/game/player/Player;Lforge/game/card/Card;)Lforge/game/card/Card;",2,5,4,new JHandler[]{},M2550));
c.Add(new JMethod(2551,"forge/game/GameSnapshot","setCardInCopiedGame","(Lforge/game/Game;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/zone/ZoneType;I)V",2,9,3,new JHandler[]{},M2551));
c.Add(new JMethod(2552,"forge/game/GameSnapshot","isMelded","(Lforge/game/card/Card;)Z",10,3,2,new JHandler[]{},M2552));
c.Add(new JMethod(2553,"forge/game/GameSnapshot","findSAInCard","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;",10,6,2,new JHandler[]{},M2553));
c.Add(new JMethod(2554,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/game/card/Card;",2,3,2,new JHandler[]{},M2554));
c.Add(new JMethod(2555,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;",2,3,2,new JHandler[]{},M2555));
c.Add(new JMethod(2556,"forge/game/GameSnapshot","find","(Lforge/game/GameObject;)Lforge/game/GameObject;",1,2,3,new JHandler[]{},M2556));
c.Add(new JMethod(2557,"forge/game/GameSnapshot","reverseFind","(Lforge/game/GameObject;)Lforge/game/GameObject;",1,2,3,new JHandler[]{},M2557));
c.Add(new JMethod(2558,"forge/game/GameSnapshot","lambda$assignGameState$1","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/game/card/Card;",4098,3,3,new JHandler[]{},M2558));
c.Add(new JMethod(2559,"forge/game/GameSnapshot","lambda$assignGameState$0","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/game/card/Card;",4098,3,3,new JHandler[]{},M2559));
}

internal static JStep M2537(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameSnapshot","newGame","Lforge/game/Game;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameSnapshot","restore","Z",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"forge/game/GameSnapshot$SnapshotEntityMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameSnapshot$SnapshotEntityMap")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/GameSnapshot$SnapshotEntityMap","<init>","(Lforge/game/GameSnapshot;)V","invokespecial",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameSnapshot","gameObjectMap","Lforge/game/GameSnapshot$SnapshotEntityMap;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameSnapshot","origGame","Lforge/game/Game;",value);f.Pc=31;continue;}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2538(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","origGame","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2539(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/GameSnapshot","makeCopy","(Ljava/util/List;Z)Lforge/game/Game;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2540(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?9:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Pc=23;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","origGame","Lforge/game/Game;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Game","getMatch","()Lforge/game/Match;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/Match","getPlayers","()Ljava/util/List;","invokevirtual",19);}
case 19:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","origGame","Lforge/game/Game;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",30);}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{if(!rt.EnsureInitialized(f,"forge/game/Match"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/Match")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","origGame","Lforge/game/Game;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/Game","getView","()Lforge/game/GameView;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/game/GameView","getTitle","()Ljava/lang/String;","invokevirtual",49);}
case 49:{return rt.Call(f,"forge/game/Match","<init>","(Lforge/game/GameRules;Ljava/util/List;Ljava/lang/String;)V","invokespecial",52);}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{if(!rt.EnsureInitialized(f,"forge/game/Game"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/Game")));f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[5]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/Game","<init>","(Ljava/lang/Iterable;Lforge/game/GameRules;Lforge/game/Match;)V","invokespecial",67);}
case 67:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameSnapshot","newGame","Lforge/game/Game;",value);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameSnapshot","restore","Z",value);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","origGame","Lforge/game/Game;"));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","newGame","Lforge/game/Game;"));f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/GameSnapshot","assignGameState","(Lforge/game/Game;Lforge/game/Game;Z)V","invokevirtual",88);}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","newGame","Lforge/game/Game;"));f.Pc=92;continue;}
case 92:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2541(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","newGame","Lforge/game/Game;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/Game","getTimestamp","()J","invokevirtual",10);}
case 10:{return rt.DynamicCall(f,"forge/game/GameSnapshot:2541:10:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(J)Ljava/lang/String;",15);}
case 15:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameSnapshot","restore","Z",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventSnapshotRestored"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventSnapshotRestored")));f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/event/GameEventSnapshotRestored","<init>","(Z)V","invokespecial",32);}
case 32:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",35);}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","newGame","Lforge/game/Game;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/GameSnapshot","assignGameState","(Lforge/game/Game;Lforge/game/Game;Z)V","invokevirtual",45);}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventSnapshotRestored"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventSnapshotRestored")));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/event/GameEventSnapshotRestored","<init>","(Z)V","invokespecial",54);}
case 54:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",57);}
case 57:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2542(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[4]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",12);}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?52:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",19);}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",36);}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[6]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/GameSnapshot","assignPlayerState","(Lforge/game/player/Player;Lforge/game/player/Player;)V","invokevirtual",46);}
case 46:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=49;continue;}
case 49:{f.Pc=3;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",56);}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",65);}
case 65:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",68);}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",74);}
case 74:{f.Push(f.Locals[4]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",79);}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/phase/PhaseHandler","getTurn","()I","invokevirtual",86);}
case 86:{return rt.Call(f,"forge/game/phase/PhaseHandler","devModeSet","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;I)V","invokevirtual",89);}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",93);}
case 93:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/trigger/TriggerHandler","suppressMode","(Lforge/game/trigger/TriggerType;)V","invokevirtual",99);}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",103);}
case 103:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",106);}
case 106:{f.Locals[6]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[6]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",115);}
case 115:{f.Pc=f.Pop().Int==0?148:118;continue;}
case 118:{f.Push(f.Locals[6]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",125);}
case 125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=128;continue;}
case 128:{f.Locals[7]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[7]);f.Pc=132;continue;}
case 132:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",138);}
case 138:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/PlayerZoneBattlefield"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=141;continue;}
case 141:{f.Push(JValue.I(0));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/zone/PlayerZoneBattlefield","setTriggers","(Z)V","invokevirtual",145);}
case 145:{f.Pc=108;continue;}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[1]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/GameSnapshot","copyGameState","(Lforge/game/Game;Lforge/game/Game;)V","invokevirtual",154);}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",158);}
case 158:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",161);}
case 161:{f.Locals[6]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[6]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",170);}
case 170:{f.Pc=f.Pop().Int==0?247:173;continue;}
case 173:{f.Push(f.Locals[6]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",180);}
case 180:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=183;continue;}
case 183:{f.Locals[7]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[2]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[7]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",192);}
case 192:{f.Locals[8]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[7]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[8]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[0]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[2]);f.Pc=200;continue;}
case 200:{return rt.DynamicCall(f,"forge/game/GameSnapshot:2542:200:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/GameSnapshot;Lforge/game/Game;)Ljava/util/function/Function;",205);}
case 205:{return rt.Call(f,"forge/game/player/Player","copyCommandersToSnapshot","(Lforge/game/player/Player;Ljava/util/function/Function;)V","invokevirtual",208);}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","restore","Z"));f.Pc=212;continue;}
case 212:{f.Pc=f.Pop().Int!=0?229:215;continue;}
case 215:{f.Push(f.Locals[7]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[8]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[2]);f.Pc=221;continue;}
case 221:{return rt.DynamicCall(f,"forge/game/GameSnapshot:2542:221:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/GameSnapshot;Lforge/game/Game;)Ljava/util/function/Function;",226);}
case 226:{return rt.Call(f,"forge/game/player/Player","copyEffectCardsToSnapshot","(Lforge/game/player/Player;Ljava/util/function/Function;)V","invokevirtual",229);}
case 229:{f.Push(f.Locals[8]);f.Pc=231;continue;}
case 231:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",237);}
case 237:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/PlayerZoneBattlefield"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=240;continue;}
case 240:{f.Push(JValue.I(1));f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/zone/PlayerZoneBattlefield","setTriggers","(Z)V","invokevirtual",244);}
case 244:{f.Pc=163;continue;}
case 247:{f.Push(f.Locals[2]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",251);}
case 251:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearSuppression","(Lforge/game/trigger/TriggerType;)V","invokevirtual",257);}
case 257:{f.Push(f.Locals[2]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/Game","getCardsInGame","()Lforge/game/card/CardCollectionView;","invokevirtual",261);}
case 261:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",266);}
case 266:{f.Locals[6]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[6]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",275);}
case 275:{f.Pc=f.Pop().Int==0?523:278;continue;}
case 278:{f.Push(f.Locals[6]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",285);}
case 285:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=288;continue;}
case 288:{f.Locals[7]=f.Pop();f.Pc=290;continue;}
case 290:{f.Push(f.Locals[1]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[7]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",296);}
case 296:{return rt.Call(f,"forge/game/Game","findById","(I)Lforge/game/card/Card;","invokevirtual",299);}
case 299:{f.Locals[8]=f.Pop();f.Pc=301;continue;}
case 301:{f.Push(f.Locals[8]);f.Pc=303;continue;}
case 303:{f.Pc=f.Pop().Reference!=null?325:306;continue;}
case 306:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=309;continue;}
case 309:{f.Push(f.Locals[7]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",314);}
case 314:{return rt.DynamicCall(f,"forge/game/GameSnapshot:2542:314:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",319);}
case 319:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",322);}
case 322:{f.Pc=268;continue;}
case 325:{f.Push(f.Locals[8]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/card/Card","hasRemembered","()Z","invokevirtual",330);}
case 330:{f.Pc=f.Pop().Int==0?450:333;continue;}
case 333:{f.Push(f.Locals[8]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",338);}
case 338:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",343);}
case 343:{f.Locals[9]=f.Pop();f.Pc=345;continue;}
case 345:{f.Push(f.Locals[9]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",352);}
case 352:{f.Pc=f.Pop().Int==0?450:355;continue;}
case 355:{f.Push(f.Locals[9]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",362);}
case 362:{f.Locals[10]=f.Pop();f.Pc=364;continue;}
case 364:{f.Push(f.Locals[10]);f.Pc=366;continue;}
case 366:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/GameObject")?1:0));f.Pc=369;continue;}
case 369:{f.Pc=f.Pop().Int==0?411:372;continue;}
case 372:{f.Push(f.Locals[10]);f.Pc=374;continue;}
case 374:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=377;continue;}
case 377:{f.Pc=f.Pop().Int==0?394:380;continue;}
case 380:{f.Push(f.Locals[10]);f.Pc=382;continue;}
case 382:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",388);}
case 388:{f.Pc=f.Pop().Reference!=null?394:391;continue;}
case 391:{f.Pc=345;continue;}
case 394:{f.Push(f.Locals[7]);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[0]);f.Pc=397;continue;}
case 397:{f.Push(f.Locals[10]);f.Pc=399;continue;}
case 399:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=402;continue;}
case 402:{return rt.Call(f,"forge/game/GameSnapshot","find","(Lforge/game/GameObject;)Lforge/game/GameObject;","invokevirtual",405);}
case 405:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",408);}
case 408:{f.Pc=447;continue;}
case 411:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=414;continue;}
case 414:{f.Push(f.Locals[7]);f.Pc=416;continue;}
case 416:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",419);}
case 419:{f.Push(f.Locals[10]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",424);}
case 424:{f.Push(f.Locals[10]);f.Pc=426;continue;}
case 426:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",429);}
case 429:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",432);}
case 432:{return rt.DynamicCall(f,"forge/game/GameSnapshot:2542:432:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",437);}
case 437:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",440);}
case 440:{f.Push(f.Locals[7]);f.Pc=442;continue;}
case 442:{f.Push(f.Locals[10]);f.Pc=444;continue;}
case 444:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",447);}
case 447:{f.Pc=345;continue;}
case 450:{f.Push(f.Locals[7]);f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/game/card/Card","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",455);}
case 455:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",460);}
case 460:{f.Locals[9]=f.Pop();f.Pc=462;continue;}
case 462:{f.Push(f.Locals[9]);f.Pc=464;continue;}
case 464:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",469);}
case 469:{f.Pc=f.Pop().Int==0?520:472;continue;}
case 472:{f.Push(f.Locals[9]);f.Pc=474;continue;}
case 474:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",479);}
case 479:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=482;continue;}
case 482:{f.Locals[10]=f.Pop();f.Pc=484;continue;}
case 484:{f.Push(f.Locals[10]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",489);}
case 489:{f.Locals[11]=f.Pop();f.Pc=491;continue;}
case 491:{f.Push(f.Locals[11]);f.Pc=493;continue;}
case 493:{f.Pc=f.Pop().Reference==null?517:496;continue;}
case 496:{f.Push(f.Locals[11]);f.Pc=498;continue;}
case 498:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",501);}
case 501:{f.Push(f.Locals[2]);f.Pc=502;continue;}
case 502:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?517:505;continue;}
case 505:{f.Push(f.Locals[10]);f.Pc=507;continue;}
case 507:{f.Push(f.Locals[0]);f.Pc=508;continue;}
case 508:{f.Push(f.Locals[2]);f.Pc=509;continue;}
case 509:{f.Push(f.Locals[11]);f.Pc=511;continue;}
case 511:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",514);}
case 514:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",517);}
case 517:{f.Pc=462;continue;}
case 520:{f.Pc=268;continue;}
case 523:{f.Push(f.Locals[4]);f.Pc=525;continue;}
case 525:{return rt.Call(f,"forge/game/phase/PhaseHandler","getCombat","()Lforge/game/combat/Combat;","invokevirtual",528);}
case 528:{f.Pc=f.Pop().Reference==null?558:531;continue;}
case 531:{if(!rt.EnsureInitialized(f,"forge/game/combat/Combat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/Combat")));f.Pc=534;continue;}
case 534:{f.StackOp("dup");f.Pc=535;continue;}
case 535:{f.Push(f.Locals[4]);f.Pc=537;continue;}
case 537:{return rt.Call(f,"forge/game/phase/PhaseHandler","getCombat","()Lforge/game/combat/Combat;","invokevirtual",540);}
case 540:{f.Push(f.Locals[0]);f.Pc=541;continue;}
case 541:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","gameObjectMap","Lforge/game/GameSnapshot$SnapshotEntityMap;"));f.Pc=544;continue;}
case 544:{return rt.Call(f,"forge/game/combat/Combat","<init>","(Lforge/game/combat/Combat;Lforge/game/IEntityMap;)V","invokespecial",547);}
case 547:{f.Locals[6]=f.Pop();f.Pc=549;continue;}
case 549:{f.Push(f.Locals[2]);f.Pc=550;continue;}
case 550:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",553);}
case 553:{f.Push(f.Locals[6]);f.Pc=555;continue;}
case 555:{return rt.Call(f,"forge/game/phase/PhaseHandler","setCombat","(Lforge/game/combat/Combat;)V","invokevirtual",558);}
case 558:{f.Push(f.Locals[3]);f.Pc=559;continue;}
case 559:{f.Pc=f.Pop().Int==0?568:562;continue;}
case 562:{f.Push(f.Locals[0]);f.Pc=563;continue;}
case 563:{f.Push(f.Locals[1]);f.Pc=564;continue;}
case 564:{f.Push(f.Locals[2]);f.Pc=565;continue;}
case 565:{return rt.Call(f,"forge/game/GameSnapshot","copyStack","(Lforge/game/Game;Lforge/game/Game;)V","invokevirtual",568);}
case 568:{f.Push(f.Locals[0]);f.Pc=569;continue;}
case 569:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","restore","Z"));f.Pc=572;continue;}
case 572:{f.Pc=f.Pop().Int==0?632:575;continue;}
case 575:{f.Push(f.Locals[2]);f.Pc=576;continue;}
case 576:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",579);}
case 579:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",582);}
case 582:{f.Locals[6]=f.Pop();f.Pc=584;continue;}
case 584:{f.Push(f.Locals[6]);f.Pc=586;continue;}
case 586:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",591);}
case 591:{f.Pc=f.Pop().Int==0?614:594;continue;}
case 594:{f.Push(f.Locals[6]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",601);}
case 601:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=604;continue;}
case 604:{f.Locals[7]=f.Pop();f.Pc=606;continue;}
case 606:{f.Push(f.Locals[7]);f.Pc=608;continue;}
case 608:{return rt.Call(f,"forge/game/player/Player","updateAllZonesForView","()V","invokevirtual",611);}
case 611:{f.Pc=584;continue;}
case 614:{f.Push(f.Locals[2]);f.Pc=615;continue;}
case 615:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",618);}
case 618:{return rt.Call(f,"forge/game/phase/PhaseHandler","getCombat","()Lforge/game/combat/Combat;","invokevirtual",621);}
case 621:{f.Locals[6]=f.Pop();f.Pc=623;continue;}
case 623:{f.Push(f.Locals[6]);f.Pc=625;continue;}
case 625:{f.Pc=f.Pop().Reference==null?632:628;continue;}
case 628:{f.Push(f.Locals[2]);f.Pc=629;continue;}
case 629:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",632);}
case 632:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2543(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","restore","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?15:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/player/Player","dangerouslySetController","(Lforge/game/player/PlayerController;)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",20);}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/player/Player","setLife","(ILforge/game/spellability/SpellAbility;)Z","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/player/Player","getLifeLostLastTurn","()I","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/player/Player","setLifeLostLastTurn","(I)V","invokevirtual",33);}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/player/Player","getLifeLostThisTurn","()I","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/game/player/Player","setLifeLostThisTurn","(I)V","invokevirtual",41);}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/player/Player","getLifeGainedThisTurn","()I","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/game/player/Player","setLifeGainedThisTurn","(I)V","invokevirtual",49);}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/player/Player","getLifeStartedThisTurnWith","()I","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/game/player/Player","setLifeStartedThisTurnWith","(I)V","invokevirtual",57);}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/player/Player","getDamageReceivedThisTurn","()Ljava/util/List;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/player/Player","setDamageReceivedThisTurn","(Ljava/util/List;)V","invokevirtual",65);}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/player/Player","getLandsPlayedThisTurn","()I","invokevirtual",70);}
case 70:{return rt.Call(f,"forge/game/player/Player","setLandsPlayedThisTurn","(I)V","invokevirtual",73);}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/player/Player","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",78);}
case 78:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","(Ljava/lang/Iterable;)Lcom/google/common/collect/HashMultiset;","invokestatic",81);}
case 81:{return rt.Call(f,"forge/game/player/Player","setCounters","(Lcom/google/common/collect/Multiset;)V","invokevirtual",84);}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/player/Player","hasBlessing","()Z","invokevirtual",89);}
case 89:{f.Push(JValue.R(null));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/player/Player","setBlessing","(ZLjava/lang/String;)V","invokevirtual",93);}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/player/Player","getLibrarySearched","()I","invokevirtual",98);}
case 98:{return rt.Call(f,"forge/game/player/Player","setLibrarySearched","(I)V","invokevirtual",101);}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/player/Player","getSpellsCastLastTurn","()I","invokevirtual",106);}
case 106:{return rt.Call(f,"forge/game/player/Player","setSpellsCastLastTurn","(I)V","invokevirtual",109);}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/player/Player","getCommittedCrimeThisTurn","()I","invokevirtual",114);}
case 114:{return rt.Call(f,"forge/game/player/Player","setCommitedCrimeThisTurn","(I)V","invokevirtual",117);}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/player/Player","getDilemmasFacedThisTurn","()I","invokevirtual",122);}
case 122:{return rt.Call(f,"forge/game/player/Player","setDilemmasFacedThisTurn","(I)V","invokevirtual",125);}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/player/Player","getExpentThisTurn","()I","invokevirtual",130);}
case 130:{return rt.Call(f,"forge/game/player/Player","setExpentThisTurn","(I)V","invokevirtual",133);}
case 133:{f.Push(JValue.I(0));f.Pc=134;continue;}
case 134:{f.Locals[3]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/player/Player","getSpellsCastThisTurn","()I","invokevirtual",140);}
case 140:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?153:143;continue;}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/player/Player","addSpellCastThisTurn","()V","invokevirtual",147);}
case 147:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=150;continue;}
case 150:{f.Pc=135;continue;}
case 153:{f.Push(f.Locals[2]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/player/Player","getMaxHandSize","()I","invokevirtual",158);}
case 158:{return rt.Call(f,"forge/game/player/Player","setMaxHandSize","(I)V","invokevirtual",161);}
case 161:{f.Push(f.Locals[2]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/player/Player","isUnlimitedHandSize","()Z","invokevirtual",166);}
case 166:{return rt.Call(f,"forge/game/player/Player","setUnlimitedHandSize","(Z)V","invokevirtual",169);}
case 169:{f.Push(f.Locals[2]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[1]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/player/Player","getCrankCounter","()I","invokevirtual",174);}
case 174:{return rt.Call(f,"forge/game/player/Player","setCrankCounter","(I)V","invokevirtual",177);}
case 177:{f.Push(f.Locals[0]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[1]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[2]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/GameSnapshot","copyManaPool","(Lforge/game/player/Player;Lforge/game/player/Player;)V","invokevirtual",183);}
case 183:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2544(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/mana/ManaPool","resetPool","()V","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/mana/ManaPool","iterator","()Ljava/util/Iterator;","invokevirtual",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?61:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",47);}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/GameSnapshot","copyMana","(Lforge/game/mana/Mana;Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/mana/Mana;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/mana/ManaPool","addManaNoEvent","(Lforge/game/mana/Mana;)V","invokevirtual",58);}
case 58:{f.Pc=21;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/player/Player","updateManaForView","()V","invokevirtual",65);}
case 65:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2545(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/mana/Mana","getSourceCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",13);}
case 13:{f.Locals[5]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[5]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference!=null?22:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{if(!rt.EnsureInitialized(f,"forge/game/mana/Mana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/Mana")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",30);}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",36);}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/mana/Mana","<init>","(BLforge/game/card/Card;Lforge/game/spellability/AbilityManaPart;Lforge/game/player/Player;)V","invokespecial",40);}
case 40:{f.Locals[6]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",47);}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","setSourceCard","(Lforge/game/card/Card;)V","invokevirtual",52);}
case 52:{f.Push(f.Locals[6]);f.Pc=54;continue;}
case 54:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2546(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/zone/MagicStack","iterator","()Ljava/util/Iterator;","invokevirtual",15);}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?59:27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[5]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getId","()I","invokevirtual",45);}
case 45:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",48);}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Pc=17;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",63);}
case 63:{return rt.Call(f,"forge/game/zone/MagicStack","iterator","()Ljava/util/Iterator;","invokevirtual",66);}
case 66:{f.Locals[4]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",75);}
case 75:{f.Pc=f.Pop().Int==0?392:78;continue;}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{f.Locals[5]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[5]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getId","()I","invokevirtual",95);}
case 95:{f.Locals[6]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[6]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",103);}
case 103:{f.Push(JValue.R(null));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",109);}
case 109:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=112;continue;}
case 112:{f.Locals[7]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[7]);f.Pc=116;continue;}
case 116:{f.Pc=f.Pop().Reference==null?148:119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","restore","Z"));f.Pc=123;continue;}
case 123:{f.Pc=f.Pop().Int!=0?68:126;continue;}
case 126:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=129;continue;}
case 129:{f.Push(f.Locals[5]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",134);}
case 134:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",137);}
case 137:{return rt.DynamicCall(f,"forge/game/GameSnapshot:2546:137:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",142);}
case 142:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",145);}
case 145:{f.Pc=68;continue;}
case 148:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=151;continue;}
case 151:{f.Push(f.Locals[5]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",156);}
case 156:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",159);}
case 159:{return rt.DynamicCall(f,"forge/game/GameSnapshot:2546:159:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",164);}
case 164:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",167);}
case 167:{f.Push(f.Locals[5]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",172);}
case 172:{f.Locals[8]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[8]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",179);}
case 179:{f.Locals[9]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[2]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[9]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",188);}
case 188:{f.Locals[10]=f.Pop();f.Pc=190;continue;}
case 190:{f.Push(f.Locals[10]);f.Pc=192;continue;}
case 192:{f.Pc=f.Pop().Reference!=null?214:195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[2]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[0]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[2]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[9]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",204);}
case 204:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",207);}
case 207:{f.Push(f.Locals[9]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/GameSnapshot","createCardCopy","(Lforge/game/Game;Lforge/game/player/Player;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",212);}
case 212:{f.Locals[10]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(JValue.R(null));f.Pc=215;continue;}
case 215:{f.Locals[11]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[8]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",222);}
case 222:{f.Pc=f.Pop().Int==0?234:225;continue;}
case 225:{f.Push(f.Locals[8]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[10]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/GameSnapshot","findSAInCard","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",232);}
case 232:{f.Locals[11]=f.Pop();f.Pc=234;continue;}
case 234:{f.Push(f.Locals[11]);f.Pc=236;continue;}
case 236:{f.Pc=f.Pop().Reference==null?389:239;continue;}
case 239:{f.Push(f.Locals[11]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[2]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[8]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",248);}
case 248:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",251);}
case 251:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",254);}
case 254:{f.Push(f.Locals[8]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",259);}
case 259:{f.Pc=f.Pop().Int==0?378:262;continue;}
case 262:{f.Push(f.Locals[8]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",267);}
case 267:{return rt.Call(f,"forge/game/spellability/TargetChoices","iterator","()Ljava/util/Iterator;","invokevirtual",270);}
case 270:{f.Locals[12]=f.Pop();f.Pc=272;continue;}
case 272:{f.Push(f.Locals[12]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",279);}
case 279:{f.Pc=f.Pop().Int==0?378:282;continue;}
case 282:{f.Push(f.Locals[12]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",289);}
case 289:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=292;continue;}
case 292:{f.Locals[13]=f.Pop();f.Pc=294;continue;}
case 294:{f.Push(f.Locals[13]);f.Pc=296;continue;}
case 296:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=299;continue;}
case 299:{f.Pc=f.Pop().Int==0?324:302;continue;}
case 302:{f.Push(f.Locals[11]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",307);}
case 307:{f.Push(f.Locals[0]);f.Pc=308;continue;}
case 308:{f.Push(f.Locals[2]);f.Pc=309;continue;}
case 309:{f.Push(f.Locals[13]);f.Pc=311;continue;}
case 311:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",317);}
case 317:{return rt.Call(f,"forge/game/spellability/TargetChoices","add","(Lforge/game/GameObject;)Z","invokevirtual",320);}
case 320:{f.StackOp("pop");f.Pc=321;continue;}
case 321:{f.Pc=375;continue;}
case 324:{f.Push(f.Locals[13]);f.Pc=326;continue;}
case 326:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=329;continue;}
case 329:{f.Pc=f.Pop().Int==0?354:332;continue;}
case 332:{f.Push(f.Locals[11]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",337);}
case 337:{f.Push(f.Locals[0]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[2]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[13]);f.Pc=341;continue;}
case 341:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",347);}
case 347:{return rt.Call(f,"forge/game/spellability/TargetChoices","add","(Lforge/game/GameObject;)Z","invokevirtual",350);}
case 350:{f.StackOp("pop");f.Pc=351;continue;}
case 351:{f.Pc=375;continue;}
case 354:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=357;continue;}
case 357:{f.Push(f.Locals[13]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",362);}
case 362:{f.Push(f.Locals[8]);f.Pc=364;continue;}
case 364:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",367);}
case 367:{return rt.DynamicCall(f,"forge/game/GameSnapshot:2546:367:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",372);}
case 372:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",375);}
case 375:{f.Pc=272;continue;}
case 378:{f.Push(f.Locals[2]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",382);}
case 382:{f.Push(f.Locals[11]);f.Pc=384;continue;}
case 384:{f.Push(f.Locals[6]);f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/game/zone/MagicStack","add","(Lforge/game/spellability/SpellAbility;I)V","invokevirtual",389);}
case 389:{f.Pc=68;continue;}
case 392:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2547(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/Game","getAge","()Lforge/game/GameStage;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/Game","setAge","(Lforge/game/GameStage;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/Game","getTimestamp","()J","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/Game","dangerouslySetTimestamp","(J)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","restore","Z"));f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Int!=0?28:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/Game","dangerouslySyncCardIdCounters","(Lforge/game/Game;)V","invokevirtual",28);}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/Game","getStartingPlayer","()Lforge/game/player/Player;","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Reference==null?48:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/Game","getStartingPlayer","()Lforge/game/player/Player;","invokevirtual",42);}
case 42:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/Game","setStartingPlayer","(Lforge/game/player/Player;)V","invokevirtual",48);}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/Game","getMonarch","()Lforge/game/player/Player;","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Reference==null?68:55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/Game","getMonarch","()Lforge/game/player/Player;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",65);}
case 65:{return rt.Call(f,"forge/game/Game","setMonarch","(Lforge/game/player/Player;)V","invokevirtual",68);}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/Game","getMonarchBeginTurn","()Lforge/game/player/Player;","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Reference==null?88:75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/Game","getMonarchBeginTurn","()Lforge/game/player/Player;","invokevirtual",82);}
case 82:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",85);}
case 85:{return rt.Call(f,"forge/game/Game","setMonarchBeginTurn","(Lforge/game/player/Player;)V","invokevirtual",88);}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/Game","getHasInitiative","()Lforge/game/player/Player;","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Reference==null?108:95;continue;}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/Game","getHasInitiative","()Lforge/game/player/Player;","invokevirtual",102);}
case 102:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",105);}
case 105:{return rt.Call(f,"forge/game/Game","setHasInitiative","(Lforge/game/player/Player;)V","invokevirtual",108);}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/Game","getDayTime","()Ljava/lang/Boolean;","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Reference==null?123:115;continue;}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/Game","getDayTime","()Ljava/lang/Boolean;","invokevirtual",120);}
case 120:{return rt.Call(f,"forge/game/Game","setDayTime","(Ljava/lang/Boolean;)V","invokevirtual",123);}
case 123:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",126);}
case 126:{f.Locals[3]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/GameSnapshot","getCardsToCopy","(Lforge/game/Game;)Lforge/game/card/CardCollectionView;","invokestatic",131);}
case 131:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",136);}
case 136:{f.Locals[4]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[4]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",145);}
case 145:{f.Pc=f.Pop().Int==0?345:148;continue;}
case 148:{f.Push(f.Locals[4]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",155);}
case 155:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=158;continue;}
case 158:{f.Locals[5]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[5]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",166);}
case 166:{return rt.Call(f,"forge/game/GameSnapshot","findCardById","(Lforge/game/Game;I)Lforge/game/card/Card;","invokestatic",169);}
case 169:{f.Locals[6]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[2]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[5]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",178);}
case 178:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",181);}
case 181:{f.Locals[7]=f.Pop();f.Pc=183;continue;}
case 183:{f.Push(f.Locals[5]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",188);}
case 188:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",191);}
case 191:{f.Locals[8]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(JValue.I(0));f.Pc=194;continue;}
case 194:{f.Locals[9]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[8]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/zone/ZoneType","isOrdered","()Z","invokevirtual",201);}
case 201:{f.Pc=f.Pop().Int==0?221:204;continue;}
case 204:{f.Push(f.Locals[5]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",209);}
case 209:{return rt.Call(f,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",212);}
case 212:{f.Push(f.Locals[5]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/card/CardCollectionView","indexOf","(Ljava/lang/Object;)I","invokeinterface",219);}
case 219:{f.Locals[9]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(f.Locals[6]);f.Pc=223;continue;}
case 223:{f.Pc=f.Pop().Reference!=null?240:226;continue;}
case 226:{f.Push(f.Locals[0]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[2]);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[7]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[5]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/GameSnapshot","createCardCopy","(Lforge/game/Game;Lforge/game/player/Player;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",235);}
case 235:{f.Locals[6]=f.Pop();f.Pc=237;continue;}
case 237:{f.Pc=292;continue;}
case 240:{f.Push(f.Locals[6]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",245);}
case 245:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",248);}
case 248:{f.Locals[10]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(f.Locals[10]);f.Pc=252;continue;}
case 252:{f.Push(f.Locals[8]);f.Pc=254;continue;}
case 254:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?292:257;continue;}
case 257:{f.Push(f.Locals[10]);f.Pc=259;continue;}
case 259:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",265);}
case 265:{f.Pc=f.Pop().Int==0?280:268;continue;}
case 268:{f.Push(f.Locals[2]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",272);}
case 272:{f.Push(f.Locals[6]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/zone/Zone","remove","(Lforge/game/card/Card;)V","invokevirtual",277);}
case 277:{f.Pc=292;continue;}
case 280:{f.Push(f.Locals[7]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[10]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",287);}
case 287:{f.Push(f.Locals[6]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/zone/PlayerZone","remove","(Lforge/game/card/Card;)V","invokevirtual",292);}
case 292:{f.Push(f.Locals[8]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/zone/ZoneType","isOrdered","()Z","invokevirtual",297);}
case 297:{f.Pc=f.Pop().Int!=0?318:300;continue;}
case 300:{f.Push(f.Locals[0]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[2]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[7]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[5]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[6]);f.Pc=308;continue;}
case 308:{f.Push(f.Locals[8]);f.Pc=310;continue;}
case 310:{f.Push(f.Locals[9]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/GameSnapshot","setCardInCopiedGame","(Lforge/game/Game;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/zone/ZoneType;I)V","invokevirtual",315);}
case 315:{f.Pc=342;continue;}
case 318:{f.Push(f.Locals[3]);f.Pc=319;continue;}
case 319:{if(!rt.EnsureInitialized(f,"forge/game/GameSnapshot$UnorderedEntities"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameSnapshot$UnorderedEntities")));f.Pc=322;continue;}
case 322:{f.StackOp("dup");f.Pc=323;continue;}
case 323:{f.Push(f.Locals[7]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[5]);f.Pc=327;continue;}
case 327:{f.Push(f.Locals[6]);f.Pc=329;continue;}
case 329:{f.Push(f.Locals[8]);f.Pc=331;continue;}
case 331:{f.Push(f.Locals[9]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/GameSnapshot$UnorderedEntities","<init>","(Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/zone/ZoneType;I)V","invokespecial",336);}
case 336:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",341);}
case 341:{f.StackOp("pop");f.Pc=342;continue;}
case 342:{f.Pc=138;continue;}
case 345:{f.Push(f.Locals[3]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"java/util/Collections","sort","(Ljava/util/List;)V","invokestatic",349);}
case 349:{f.Push(f.Locals[3]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",355);}
case 355:{f.Locals[4]=f.Pop();f.Pc=357;continue;}
case 357:{f.Push(f.Locals[4]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",364);}
case 364:{f.Pc=f.Pop().Int==0?412:367;continue;}
case 367:{f.Push(f.Locals[4]);f.Pc=369;continue;}
case 369:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",374);}
case 374:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameSnapshot$UnorderedEntities"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=377;continue;}
case 377:{f.Locals[5]=f.Pop();f.Pc=379;continue;}
case 379:{f.Push(f.Locals[0]);f.Pc=380;continue;}
case 380:{f.Push(f.Locals[2]);f.Pc=381;continue;}
case 381:{f.Push(f.Locals[5]);f.Pc=383;continue;}
case 383:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","toPlayer","Lforge/game/player/Player;"));f.Pc=386;continue;}
case 386:{f.Push(f.Locals[5]);f.Pc=388;continue;}
case 388:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","fromCard","Lforge/game/card/Card;"));f.Pc=391;continue;}
case 391:{f.Push(f.Locals[5]);f.Pc=393;continue;}
case 393:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","newCard","Lforge/game/card/Card;"));f.Pc=396;continue;}
case 396:{f.Push(f.Locals[5]);f.Pc=398;continue;}
case 398:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","fromType","Lforge/game/zone/ZoneType;"));f.Pc=401;continue;}
case 401:{f.Push(f.Locals[5]);f.Pc=403;continue;}
case 403:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","zonePosition","I"));f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/GameSnapshot","setCardInCopiedGame","(Lforge/game/Game;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/zone/ZoneType;I)V","invokevirtual",409);}
case 409:{f.Pc=357;continue;}
case 412:{f.Push(f.Locals[2]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/Game","getCardsInGame","()Lforge/game/card/CardCollectionView;","invokevirtual",416);}
case 416:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",421);}
case 421:{f.Locals[4]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(f.Locals[4]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",430);}
case 430:{f.Pc=f.Pop().Int==0?479:433;continue;}
case 433:{f.Push(f.Locals[4]);f.Pc=435;continue;}
case 435:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",440);}
case 440:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=443;continue;}
case 443:{f.Locals[5]=f.Pop();f.Pc=445;continue;}
case 445:{f.Push(f.Locals[1]);f.Pc=446;continue;}
case 446:{f.Push(f.Locals[5]);f.Pc=448;continue;}
case 448:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",451);}
case 451:{return rt.Call(f,"forge/game/Game","findById","(I)Lforge/game/card/Card;","invokevirtual",454);}
case 454:{f.Pc=f.Pop().Reference!=null?476:457;continue;}
case 457:{f.Push(f.Locals[5]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",462);}
case 462:{f.Locals[6]=f.Pop();f.Pc=464;continue;}
case 464:{f.Push(f.Locals[6]);f.Pc=466;continue;}
case 466:{f.Pc=f.Pop().Reference==null?476:469;continue;}
case 469:{f.Push(f.Locals[6]);f.Pc=471;continue;}
case 471:{f.Push(f.Locals[5]);f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/zone/Zone","remove","(Lforge/game/card/Card;)V","invokevirtual",476);}
case 476:{f.Pc=423;continue;}
case 479:{f.Push(f.Locals[2]);f.Pc=480;continue;}
case 480:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",486);}
case 486:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",491);}
case 491:{f.Locals[4]=f.Pop();f.Pc=493;continue;}
case 493:{f.Push(f.Locals[4]);f.Pc=495;continue;}
case 495:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",500);}
case 500:{f.Pc=f.Pop().Int==0?847:503;continue;}
case 503:{f.Push(f.Locals[4]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",510);}
case 510:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=513;continue;}
case 513:{f.Locals[5]=f.Pop();f.Pc=515;continue;}
case 515:{f.Push(f.Locals[1]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[5]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",521);}
case 521:{return rt.Call(f,"forge/game/Game","findById","(I)Lforge/game/card/Card;","invokevirtual",524);}
case 524:{f.Locals[6]=f.Pop();f.Pc=526;continue;}
case 526:{f.Push(f.Locals[6]);f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/game/card/Card","isAttachedToEntity","()Z","invokevirtual",531);}
case 531:{f.Pc=f.Pop().Int==0?580:534;continue;}
case 534:{f.Push(f.Locals[6]);f.Pc=536;continue;}
case 536:{return rt.Call(f,"forge/game/card/Card","getAttachedTo","()Lforge/game/card/Card;","invokevirtual",539);}
case 539:{f.Locals[7]=f.Pop();f.Pc=541;continue;}
case 541:{f.Push(f.Locals[7]);f.Pc=543;continue;}
case 543:{f.Pc=f.Pop().Reference!=null?550:546;continue;}
case 546:{f.Push(JValue.R(null));f.Pc=547;continue;}
case 547:{f.Pc=559;continue;}
case 550:{f.Push(f.Locals[2]);f.Pc=551;continue;}
case 551:{f.Push(f.Locals[7]);f.Pc=553;continue;}
case 553:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",556);}
case 556:{return rt.Call(f,"forge/game/Game","findById","(I)Lforge/game/card/Card;","invokevirtual",559);}
case 559:{f.Locals[8]=f.Pop();f.Pc=561;continue;}
case 561:{f.Push(f.Locals[8]);f.Pc=563;continue;}
case 563:{f.Pc=f.Pop().Reference==null?580:566;continue;}
case 566:{f.Push(f.Locals[5]);f.Pc=568;continue;}
case 568:{f.Push(f.Locals[8]);f.Pc=570;continue;}
case 570:{return rt.Call(f,"forge/game/card/Card","setEntityAttachedTo","(Lforge/game/GameEntity;)V","invokevirtual",573);}
case 573:{f.Push(f.Locals[8]);f.Pc=575;continue;}
case 575:{f.Push(f.Locals[5]);f.Pc=577;continue;}
case 577:{return rt.Call(f,"forge/game/card/Card","addAttachedCard","(Lforge/game/card/Card;)V","invokevirtual",580);}
case 580:{f.Push(f.Locals[5]);f.Pc=582;continue;}
case 582:{f.Push(f.Locals[6]);f.Pc=584;continue;}
case 584:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",587);}
case 587:{f.Pc=f.Pop().Reference!=null?594:590;continue;}
case 590:{f.Push(JValue.R(null));f.Pc=591;continue;}
case 591:{f.Pc=606;continue;}
case 594:{f.Push(f.Locals[2]);f.Pc=595;continue;}
case 595:{f.Push(f.Locals[6]);f.Pc=597;continue;}
case 597:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",600);}
case 600:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",603);}
case 603:{return rt.Call(f,"forge/game/Game","findById","(I)Lforge/game/card/Card;","invokevirtual",606);}
case 606:{return rt.Call(f,"forge/game/card/Card","setMeldedWith","(Lforge/game/card/Card;)V","invokevirtual",609);}
case 609:{f.Push(f.Locals[6]);f.Pc=611;continue;}
case 611:{return rt.Call(f,"forge/game/card/Card","getCloneOrigin","()Lforge/game/card/Card;","invokevirtual",614);}
case 614:{f.Pc=f.Pop().Reference==null?634:617;continue;}
case 617:{f.Push(f.Locals[5]);f.Pc=619;continue;}
case 619:{f.Push(f.Locals[2]);f.Pc=620;continue;}
case 620:{f.Push(f.Locals[6]);f.Pc=622;continue;}
case 622:{return rt.Call(f,"forge/game/card/Card","getCloneOrigin","()Lforge/game/card/Card;","invokevirtual",625);}
case 625:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",628);}
case 628:{return rt.Call(f,"forge/game/Game","findById","(I)Lforge/game/card/Card;","invokevirtual",631);}
case 631:{return rt.Call(f,"forge/game/card/Card","setCloneOrigin","(Lforge/game/card/Card;)V","invokevirtual",634);}
case 634:{f.Push(f.Locals[6]);f.Pc=636;continue;}
case 636:{return rt.Call(f,"forge/game/card/Card","getHaunting","()Lforge/game/card/Card;","invokevirtual",639);}
case 639:{f.Pc=f.Pop().Reference==null?659:642;continue;}
case 642:{f.Push(f.Locals[5]);f.Pc=644;continue;}
case 644:{f.Push(f.Locals[2]);f.Pc=645;continue;}
case 645:{f.Push(f.Locals[6]);f.Pc=647;continue;}
case 647:{return rt.Call(f,"forge/game/card/Card","getHaunting","()Lforge/game/card/Card;","invokevirtual",650);}
case 650:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",653);}
case 653:{return rt.Call(f,"forge/game/Game","findById","(I)Lforge/game/card/Card;","invokevirtual",656);}
case 656:{return rt.Call(f,"forge/game/card/Card","setHaunting","(Lforge/game/card/Card;)V","invokevirtual",659);}
case 659:{f.Push(f.Locals[6]);f.Pc=661;continue;}
case 661:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",664);}
case 664:{f.Pc=f.Pop().Reference==null?684:667;continue;}
case 667:{f.Push(f.Locals[5]);f.Pc=669;continue;}
case 669:{f.Push(f.Locals[2]);f.Pc=670;continue;}
case 670:{f.Push(f.Locals[6]);f.Pc=672;continue;}
case 672:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",675);}
case 675:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",678);}
case 678:{return rt.Call(f,"forge/game/Game","findById","(I)Lforge/game/card/Card;","invokevirtual",681);}
case 681:{return rt.Call(f,"forge/game/card/Card","setEffectSource","(Lforge/game/card/Card;)V","invokevirtual",684);}
case 684:{f.Push(f.Locals[6]);f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/card/Card","isPaired","()Z","invokevirtual",689);}
case 689:{f.Pc=f.Pop().Int==0?709:692;continue;}
case 692:{f.Push(f.Locals[5]);f.Pc=694;continue;}
case 694:{f.Push(f.Locals[2]);f.Pc=695;continue;}
case 695:{f.Push(f.Locals[6]);f.Pc=697;continue;}
case 697:{return rt.Call(f,"forge/game/card/Card","getPairedWith","()Lforge/game/card/Card;","invokevirtual",700);}
case 700:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",703);}
case 703:{return rt.Call(f,"forge/game/Game","findById","(I)Lforge/game/card/Card;","invokevirtual",706);}
case 706:{return rt.Call(f,"forge/game/card/Card","setPairedWith","(Lforge/game/card/Card;)V","invokevirtual",709);}
case 709:{f.Push(f.Locals[6]);f.Pc=711;continue;}
case 711:{return rt.Call(f,"forge/game/card/Card","getCopiedPermanent","()Lforge/game/card/Card;","invokevirtual",714);}
case 714:{f.Pc=f.Pop().Reference==null?734:717;continue;}
case 717:{f.Push(f.Locals[5]);f.Pc=719;continue;}
case 719:{f.Push(f.Locals[2]);f.Pc=720;continue;}
case 720:{f.Push(f.Locals[6]);f.Pc=722;continue;}
case 722:{return rt.Call(f,"forge/game/card/Card","getCopiedPermanent","()Lforge/game/card/Card;","invokevirtual",725);}
case 725:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",728);}
case 728:{return rt.Call(f,"forge/game/Game","findById","(I)Lforge/game/card/Card;","invokevirtual",731);}
case 731:{return rt.Call(f,"forge/game/card/Card","setCopiedPermanent","(Lforge/game/card/Card;)V","invokevirtual",734);}
case 734:{f.Push(f.Locals[6]);f.Pc=736;continue;}
case 736:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",739);}
case 739:{f.Pc=f.Pop().Int==0?844:742;continue;}
case 742:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=745;continue;}
case 745:{f.StackOp("dup");f.Pc=746;continue;}
case 746:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",749);}
case 749:{f.Locals[7]=f.Pop();f.Pc=751;continue;}
case 751:{f.Push(f.Locals[6]);f.Pc=753;continue;}
case 753:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",756);}
case 756:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",761);}
case 761:{f.Locals[8]=f.Pop();f.Pc=763;continue;}
case 763:{f.Push(f.Locals[8]);f.Pc=765;continue;}
case 765:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",770);}
case 770:{f.Pc=f.Pop().Int==0?829:773;continue;}
case 773:{f.Push(f.Locals[8]);f.Pc=775;continue;}
case 775:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",780);}
case 780:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=783;continue;}
case 783:{f.Locals[9]=f.Pop();f.Pc=785;continue;}
case 785:{f.Push(f.Locals[2]);f.Pc=786;continue;}
case 786:{f.Push(f.Locals[9]);f.Pc=788;continue;}
case 788:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",791);}
case 791:{return rt.Call(f,"forge/game/GameSnapshot","findCardById","(Lforge/game/Game;I)Lforge/game/card/Card;","invokestatic",794);}
case 794:{f.Locals[10]=f.Pop();f.Pc=796;continue;}
case 796:{f.Push(f.Locals[10]);f.Pc=798;continue;}
case 798:{f.Pc=f.Pop().Reference!=null?804:801;continue;}
case 801:{f.Pc=763;continue;}
case 804:{f.Push(f.Locals[10]);f.Pc=806;continue;}
case 806:{f.Push(f.Locals[5]);f.Pc=808;continue;}
case 808:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?818:811;continue;}
case 811:{f.Push(f.Locals[10]);f.Pc=813;continue;}
case 813:{f.Push(f.Locals[5]);f.Pc=815;continue;}
case 815:{return rt.Call(f,"forge/game/card/Card","setMergedToCard","(Lforge/game/card/Card;)V","invokevirtual",818);}
case 818:{f.Push(f.Locals[7]);f.Pc=820;continue;}
case 820:{f.Push(f.Locals[10]);f.Pc=822;continue;}
case 822:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",825);}
case 825:{f.StackOp("pop");f.Pc=826;continue;}
case 826:{f.Pc=763;continue;}
case 829:{f.Push(f.Locals[7]);f.Pc=831;continue;}
case 831:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",834);}
case 834:{f.Pc=f.Pop().Int!=0?844:837;continue;}
case 837:{f.Push(f.Locals[5]);f.Pc=839;continue;}
case 839:{f.Push(f.Locals[7]);f.Pc=841;continue;}
case 841:{return rt.Call(f,"forge/game/card/Card","setMergedCards","(Ljava/lang/Iterable;)V","invokevirtual",844);}
case 844:{f.Pc=493;continue;}
case 847:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2548(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Game","getCardsInGame","()Lforge/game/card/CardCollectionView;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?57:29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",50);}
case 50:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Pc=20;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2549(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/Game","findById","(I)Lforge/game/card/Card;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference==null?12:10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?154:29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",56);}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?95:68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{f.Locals[6]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",85);}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?92:89;continue;}
case 89:{f.Push(f.Locals[6]);f.Pc=91;continue;}
case 91:{return JStep.Return(f.Pop());}
case 92:{f.Pc=58;continue;}
case 95:{f.Push(f.Locals[4]);f.Pc=97;continue;}
case 97:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/PlayerZoneBattlefield"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/zone/PlayerZoneBattlefield","getMeldedCards","()Lforge/game/card/CardCollection;","invokevirtual",109);}
case 109:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",112);}
case 112:{f.Locals[5]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",121);}
case 121:{f.Pc=f.Pop().Int==0?151:124;continue;}
case 124:{f.Push(f.Locals[5]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",131);}
case 131:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=134;continue;}
case 134:{f.Locals[6]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[6]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",141);}
case 141:{f.Push(f.Locals[1]);f.Pc=142;continue;}
case 142:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?148:145;continue;}
case 145:{f.Push(f.Locals[6]);f.Pc=147;continue;}
case 147:{return JStep.Return(f.Pop());}
case 148:{f.Pc=114;continue;}
case 151:{f.Pc=20;continue;}
case 154:{f.Push(JValue.R(null));f.Pc=155;continue;}
case 155:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2550(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCopyService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCopyService")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardCopyService","<init>","(Lforge/game/card/Card;Lforge/game/Game;)V","invokespecial",9);}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardCopyService","copyCard","(ZLforge/game/player/Player;)Lforge/game/card/Card;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/Card","dangerouslySetGame","(Lforge/game/Game;)V","invokevirtual",22);}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2551(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[5]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?32:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",15);}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/zone/Zone","add","(Lforge/game/card/Card;)V","invokevirtual",20);}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/card/Card","setZone","(Lforge/game/zone/Zone;)V","invokevirtual",29);}
case 29:{f.Pc=192;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/GameSnapshot","isMelded","(Lforge/game/card/Card;)Z","invokestatic",36);}
case 36:{f.Pc=f.Pop().Int==0?76:39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/PlayerZoneBattlefield"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[7]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Reference!=null?66:59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[7]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/Card","setZone","(Lforge/game/zone/Zone;)V","invokevirtual",66);}
case 66:{f.Push(f.Locals[7]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/zone/PlayerZoneBattlefield","addToMelded","(Lforge/game/card/Card;)V","invokevirtual",73);}
case 73:{f.Pc=192;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",83);}
case 83:{f.Locals[8]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[8]);f.Pc=87;continue;}
case 87:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/zone/PlayerZoneBattlefield")?1:0));f.Pc=90;continue;}
case 90:{f.Pc=f.Pop().Int==0?107:93;continue;}
case 93:{f.Push(f.Locals[8]);f.Pc=95;continue;}
case 95:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/PlayerZoneBattlefield"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=98;continue;}
case 98:{f.Locals[7]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[7]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[4]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/zone/PlayerZoneBattlefield","removeFromMelded","(Lforge/game/card/Card;)V","invokevirtual",107);}
case 107:{f.Push(f.Locals[5]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/zone/ZoneType","isOrdered","()Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?170:115;continue;}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",121);}
case 121:{f.Locals[7]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{f.Pc=f.Pop().Int>=0?134:128;continue;}
case 128:{f.Push(JValue.I(0));f.Pc=129;continue;}
case 129:{f.Locals[6]=f.Pop();f.Pc=131;continue;}
case 131:{f.Pc=151;continue;}
case 134:{f.Push(f.Locals[6]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[7]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",141);}
case 141:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?151:144;continue;}
case 144:{f.Push(f.Locals[7]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",149);}
case 149:{f.Locals[6]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[5]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",157);}
case 157:{f.Push(f.Locals[4]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[6]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",164);}
case 164:{return rt.Call(f,"forge/game/zone/PlayerZone","add","(Lforge/game/card/Card;Ljava/lang/Integer;)V","invokevirtual",167);}
case 167:{f.Pc=181;continue;}
case 170:{f.Push(f.Locals[2]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[5]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",176);}
case 176:{f.Push(f.Locals[4]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/zone/PlayerZone","add","(Lforge/game/card/Card;)V","invokevirtual",181);}
case 181:{f.Push(f.Locals[4]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[2]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[5]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",189);}
case 189:{return rt.Call(f,"forge/game/card/Card","setZone","(Lforge/game/zone/Zone;)V","invokevirtual",192);}
case 192:{f.Push(f.Locals[4]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[3]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/card/Card","getGameTimestamp","()J","invokevirtual",198);}
case 198:{return rt.Call(f,"forge/game/card/Card","setGameTimestamp","(J)V","invokevirtual",201);}
case 201:{f.Push(f.Locals[4]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[3]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/card/Card","getLayerTimestamp","()J","invokevirtual",207);}
case 207:{return rt.Call(f,"forge/game/card/Card","setLayerTimestamp","(J)V","invokevirtual",210);}
case 210:{f.Push(f.Locals[4]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[3]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",216);}
case 216:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",219);}
case 219:{f.Push(f.Locals[4]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[3]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",225);}
case 225:{return rt.Call(f,"forge/game/card/Card","setFaceDown","(Z)V","invokevirtual",228);}
case 228:{f.Push(f.Locals[4]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[3]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/card/Card","getManifestedSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",234);}
case 234:{return rt.Call(f,"forge/game/card/Card","setManifested","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",237);}
case 237:{f.Push(f.Locals[4]);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[3]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/card/Card","hasSickness","()Z","invokevirtual",243);}
case 243:{return rt.Call(f,"forge/game/card/Card","setSickness","(Z)V","invokevirtual",246);}
case 246:{f.Push(f.Locals[4]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[3]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/card/Card","isBackSide","()Z","invokevirtual",252);}
case 252:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",255);}
case 255:{f.Push(f.Locals[4]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[3]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",261);}
case 261:{f.Push(JValue.I(0));f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",265);}
case 265:{f.StackOp("pop");f.Pc=266;continue;}
case 266:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2552(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/zone/PlayerZoneBattlefield")?1:0));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int==0?32:12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/PlayerZoneBattlefield"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/zone/PlayerZoneBattlefield","getMeldedCards","()Lforge/game/card/CardCollection;","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2553(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getAllSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?53:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",41);}
case 41:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?50:47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return JStep.Return(f.Pop());}
case 50:{f.Pc=15;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalMapParams","()Ljava/util/Map;","invokevirtual",57);}
case 57:{f.Locals[3]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/Card","getAllSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",67);}
case 67:{f.Locals[4]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?111:79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",86);}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{f.Locals[5]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalMapParams","()Ljava/util/Map;","invokevirtual",97);}
case 97:{return rt.Call(f,"java/util/Map","equals","(Ljava/lang/Object;)Z","invokeinterface",102);}
case 102:{f.Pc=f.Pop().Int==0?108:105;continue;}
case 105:{f.Push(f.Locals[5]);f.Pc=107;continue;}
case 107:{return JStep.Return(f.Pop());}
case 108:{f.Pc=69;continue;}
case 111:{f.Push(JValue.R(null));f.Pc=112;continue;}
case 112:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2554(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/GameSnapshot","findCardById","(Lforge/game/Game;I)Lforge/game/card/Card;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2555(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","getId","()I","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/Game","getPlayer","(I)Lforge/game/player/Player;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2556(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?20:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","newGame","Lforge/game/Game;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",19);}
case 19:{return JStep.Return(f.Pop());}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int==0?40:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","newGame","Lforge/game/Game;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",39);}
case 39:{return JStep.Return(f.Pop());}
case 40:{f.Push(JValue.R(null));f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2557(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?20:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","origGame","Lforge/game/Game;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",19);}
case 19:{return JStep.Return(f.Pop());}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int==0?40:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot","origGame","Lforge/game/Game;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",39);}
case 39:{return JStep.Return(f.Pop());}
case 40:{f.Push(JValue.R(null));f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2558(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2559(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/GameSnapshot","findBy","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

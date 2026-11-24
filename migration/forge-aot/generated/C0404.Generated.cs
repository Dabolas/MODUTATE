// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C404{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/SubgameEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3738,"forge/game/ability/effects/SubgameEffect","<init>","()V",1,1,1,new JHandler[]{},M3738));
c.Add(new JMethod(3739,"forge/game/ability/effects/SubgameEffect","createSubGame","(Lforge/game/Game;I)Lforge/game/Game;",2,6,7,new JHandler[]{},M3739));
c.Add(new JMethod(3740,"forge/game/ability/effects/SubgameEffect","setCardsInZone","(Lforge/game/player/Player;Lforge/game/zone/ZoneType;Lforge/game/card/CardCollectionView;Z)V",2,10,3,new JHandler[]{},M3740));
c.Add(new JMethod(3741,"forge/game/ability/effects/SubgameEffect","initVariantsZonesSubgame","(Lforge/game/Game;Lforge/game/player/Player;Lforge/game/player/Player;)V",2,10,3,new JHandler[]{},M3741));
c.Add(new JMethod(3742,"forge/game/ability/effects/SubgameEffect","prepareAllZonesSubgame","(Lforge/game/Game;Lforge/game/Game;)V",2,14,5,new JHandler[]{},M3742));
c.Add(new JMethod(3743,"forge/game/ability/effects/SubgameEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,27,7,new JHandler[]{},M3743));
}

internal static JStep M3738(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3739(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?50:23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/player/Player","getRegisteredPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",41);}
case 41:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Pc=13;continue;}
case 50:{if(!rt.EnsureInitialized(f,"forge/game/Game"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/Game")));f.Pc=53;continue;}
case 53:{f.StackOp("dup");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",59);}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/Game","getMatch","()Lforge/game/Match;","invokevirtual",63);}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/Game","<init>","(Ljava/lang/Iterable;Lforge/game/GameRules;Lforge/game/Match;Lforge/game/Game;I)V","invokespecial",68);}
case 68:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3740(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",5);}
case 5:{f.Locals[5]=f.Pop();f.Pc=7;continue;}
case 7:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",10);}
case 10:{f.Locals[6]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[7]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[7]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?98:30;continue;}
case 30:{f.Push(f.Locals[7]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[8]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[8]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int!=0?20:50;continue;}
case 50:{f.Push(f.Locals[8]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/Card","isCopiedSpell","()Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?61:58;continue;}
case 58:{f.Pc=20;continue;}
case 61:{f.Push(f.Locals[8]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",66);}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",70);}
case 70:{f.Locals[9]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[9]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{f.Pc=f.Pop().Int==0?95:87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[9]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[8]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/player/Player","addMaingameCardMapping","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",95);}
case 95:{f.Pc=20;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/zone/PlayerZone","setCards","(Ljava/lang/Iterable;)V","invokevirtual",105);}
case 105:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3741(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/player/Player","getRegisteredPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",13);}
case 13:{f.Locals[5]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[5]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getVanguardAvatars","()Ljava/util/List;","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Reference==null?71:23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getVanguardAvatars","()Ljava/util/List;","invokevirtual",28);}
case 28:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?71:45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[7]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",65);}
case 65:{return rt.Call(f,"forge/game/zone/PlayerZone","add","(Lforge/game/card/Card;)V","invokevirtual",68);}
case 68:{f.Pc=35;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",78);}
case 78:{f.Locals[6]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",87);}
case 87:{f.Locals[7]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",96);}
case 96:{f.Pc=f.Pop().Int==0?152:99;continue;}
case 99:{f.Push(f.Locals[7]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",106);}
case 106:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=109;continue;}
case 109:{f.Locals[8]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[8]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",116);}
case 116:{f.Pc=f.Pop().Int==0?149:119;continue;}
case 119:{f.Push(f.Locals[8]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",124);}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",128);}
case 128:{f.Locals[9]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[9]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/player/Player","initCommanderColor","(Lforge/game/card/Card;)V","invokevirtual",136);}
case 136:{f.Push(f.Locals[4]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[9]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/zone/PlayerZone","add","(Lforge/game/card/Card;)V","invokevirtual",143);}
case 143:{f.Push(f.Locals[3]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[9]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/player/Player","addCommander","(Lforge/game/card/Card;)V","invokevirtual",149);}
case 149:{f.Pc=89;continue;}
case 152:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3742(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(JValue.I(8));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=27;continue;}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(JValue.I(2));f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=33;continue;}
case 33:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(JValue.I(3));f.Pc=36;continue;}
case 36:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=39;continue;}
case 39:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=40;continue;}
case 40:{f.StackOp("dup");f.Pc=41;continue;}
case 41:{f.Push(JValue.I(4));f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=45;continue;}
case 45:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{f.Push(JValue.I(5));f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=51;continue;}
case 51:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=52;continue;}
case 52:{f.StackOp("dup");f.Pc=53;continue;}
case 53:{f.Push(JValue.I(6));f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"));f.Pc=58;continue;}
case 58:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=59;continue;}
case 59:{f.StackOp("dup");f.Pc=60;continue;}
case 60:{f.Push(JValue.I(7));f.Pc=62;continue;}
case 62:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"));f.Pc=65;continue;}
case 65:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",69);}
case 69:{f.Locals[5]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{f.Locals[6]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/util/collect/FCollectionView","size","()I","invokeinterface",82);}
case 82:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?436:85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/util/collect/FCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{f.Locals[7]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/util/collect/FCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",107);}
case 107:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=110;continue;}
case 110:{f.Locals[8]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[7]);f.Pc=115;continue;}
case 115:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=118;continue;}
case 118:{f.Push(f.Locals[8]);f.Pc=120;continue;}
case 120:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",126);}
case 126:{f.Push(JValue.I(0));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/ability/effects/SubgameEffect","setCardsInZone","(Lforge/game/player/Player;Lforge/game/zone/ZoneType;Lforge/game/card/CardCollectionView;Z)V","invokevirtual",130);}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[5]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[8]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/Game","getCardsInOwnedBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollectionView;","invokevirtual",138);}
case 138:{f.Locals[9]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[9]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",147);}
case 147:{f.Pc=f.Pop().Int!=0?218:150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[7]);f.Pc=153;continue;}
case 153:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=156;continue;}
case 156:{f.Push(f.Locals[9]);f.Pc=158;continue;}
case 158:{f.Push(JValue.I(1));f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/ability/effects/SubgameEffect","setCardsInZone","(Lforge/game/player/Player;Lforge/game/zone/ZoneType;Lforge/game/card/CardCollectionView;Z)V","invokevirtual",162);}
case 162:{f.Push(f.Locals[7]);f.Pc=164;continue;}
case 164:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",170);}
case 170:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",175);}
case 175:{f.Locals[10]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[10]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",184);}
case 184:{f.Pc=f.Pop().Int==0?207:187;continue;}
case 187:{f.Push(f.Locals[10]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",194);}
case 194:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=197;continue;}
case 197:{f.Locals[11]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[11]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",204);}
case 204:{f.Pc=177;continue;}
case 207:{f.Push(f.Locals[7]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[2]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[7]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",215);}
case 215:{return rt.Call(f,"forge/game/player/Player","assignCompanion","(Lforge/game/Game;Lforge/game/player/PlayerController;)V","invokevirtual",218);}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[7]);f.Pc=221;continue;}
case 221:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"));f.Pc=224;continue;}
case 224:{f.Push(f.Locals[8]);f.Pc=226;continue;}
case 226:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"));f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",232);}
case 232:{f.Push(JValue.I(0));f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/ability/effects/SubgameEffect","setCardsInZone","(Lforge/game/player/Player;Lforge/game/zone/ZoneType;Lforge/game/card/CardCollectionView;Z)V","invokevirtual",236);}
case 236:{f.Push(f.Locals[0]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[7]);f.Pc=239;continue;}
case 239:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"));f.Pc=242;continue;}
case 242:{f.Push(f.Locals[8]);f.Pc=244;continue;}
case 244:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",250);}
case 250:{f.Push(JValue.I(0));f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/ability/effects/SubgameEffect","setCardsInZone","(Lforge/game/player/Player;Lforge/game/zone/ZoneType;Lforge/game/card/CardCollectionView;Z)V","invokevirtual",254);}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[7]);f.Pc=257;continue;}
case 257:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"));f.Pc=260;continue;}
case 260:{f.Push(f.Locals[8]);f.Pc=262;continue;}
case 262:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"));f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",268);}
case 268:{f.Push(JValue.I(0));f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/ability/effects/SubgameEffect","setCardsInZone","(Lforge/game/player/Player;Lforge/game/zone/ZoneType;Lforge/game/card/CardCollectionView;Z)V","invokevirtual",272);}
case 272:{f.Push(f.Locals[7]);f.Pc=274;continue;}
case 274:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","StickerSheets","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","StickerSheets","Lforge/game/zone/ZoneType;"));f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",280);}
case 280:{f.Locals[10]=f.Pop();f.Pc=282;continue;}
case 282:{f.Push(f.Locals[8]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/player/Player","getRegisteredPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",287);}
case 287:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getStickerSheets","()Ljava/lang/Iterable;","invokevirtual",290);}
case 290:{f.Push(JValue.I(3));f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",294);}
case 294:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",299);}
case 299:{f.Locals[11]=f.Pop();f.Pc=301;continue;}
case 301:{f.Push(f.Locals[11]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",308);}
case 308:{f.Pc=f.Pop().Int==0?348:311;continue;}
case 311:{f.Push(f.Locals[11]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",318);}
case 318:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/IPaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=321;continue;}
case 321:{f.Locals[12]=f.Pop();f.Pc=323;continue;}
case 323:{f.Push(f.Locals[12]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[7]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",330);}
case 330:{f.Locals[13]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[13]);f.Pc=334;continue;}
case 334:{f.Push(JValue.I(0));f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/card/Card","setCollectible","(Z)V","invokevirtual",338);}
case 338:{f.Push(f.Locals[10]);f.Pc=340;continue;}
case 340:{f.Push(f.Locals[13]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/zone/PlayerZone","add","(Lforge/game/card/Card;)V","invokevirtual",345);}
case 345:{f.Pc=301;continue;}
case 348:{f.Push(f.Locals[7]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/card/Card","refreshSheetViews","(Lforge/game/player/Player;)V","invokestatic",353);}
case 353:{f.Push(f.Locals[0]);f.Pc=354;continue;}
case 354:{f.Push(f.Locals[7]);f.Pc=356;continue;}
case 356:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"));f.Pc=359;continue;}
case 359:{f.Push(f.Locals[8]);f.Pc=361;continue;}
case 361:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"));f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",367);}
case 367:{f.Push(JValue.I(0));f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/ability/effects/SubgameEffect","setCardsInZone","(Lforge/game/player/Player;Lforge/game/zone/ZoneType;Lforge/game/card/CardCollectionView;Z)V","invokevirtual",371);}
case 371:{f.Push(f.Locals[0]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[2]);f.Pc=373;continue;}
case 373:{f.Push(f.Locals[8]);f.Pc=375;continue;}
case 375:{f.Push(f.Locals[7]);f.Pc=377;continue;}
case 377:{return rt.Call(f,"forge/game/ability/effects/SubgameEffect","initVariantsZonesSubgame","(Lforge/game/Game;Lforge/game/player/Player;Lforge/game/player/Player;)V","invokevirtual",380);}
case 380:{f.Push(f.Locals[7]);f.Pc=382;continue;}
case 382:{f.Push(JValue.R(null));f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/game/player/Player","shuffle","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",386);}
case 386:{f.Push(f.Locals[7]);f.Pc=388;continue;}
case 388:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"));f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",394);}
case 394:{return rt.Call(f,"forge/game/zone/PlayerZone","shuffle","()V","invokevirtual",397);}
case 397:{f.Push(f.Locals[7]);f.Pc=399;continue;}
case 399:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"));f.Pc=402;continue;}
case 402:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",405);}
case 405:{return rt.Call(f,"forge/game/zone/PlayerZone","shuffle","()V","invokevirtual",408);}
case 408:{f.Push(f.Locals[7]);f.Pc=410;continue;}
case 410:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"));f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",416);}
case 416:{return rt.Call(f,"forge/game/zone/PlayerZone","shuffle","()V","invokevirtual",419);}
case 419:{f.Push(f.Locals[7]);f.Pc=421;continue;}
case 421:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"));f.Pc=424;continue;}
case 424:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",427);}
case 427:{return rt.Call(f,"forge/game/zone/PlayerZone","shuffle","()V","invokevirtual",430);}
case 430:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=433;continue;}
case 433:{f.Pc=74;continue;}
case 436:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3743(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.I(-1));f.Pc=11;continue;}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("StartingLife")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?33:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("StartingLife")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",28);}
case 28:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/ability/effects/SubgameEffect","createSubGame","(Lforge/game/Game;I)Lforge/game/Game;","invokevirtual",40);}
case 40:{f.Locals[5]=f.Pop();f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",45);}
case 45:{f.Push(JValue.R(rt.String("lblSubgameStart")));f.Pc=48;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=52;continue;}
case 52:{f.StackOp("dup");f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",58);}
case 58:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",62);}
case 62:{f.Locals[6]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/Game","getMatch","()Lforge/game/Match;","invokevirtual",68);}
case 68:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventSubgameStart"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventSubgameStart")));f.Pc=71;continue;}
case 71:{f.StackOp("dup");f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/event/GameEventSubgameStart","<init>","(Lforge/game/Game;Ljava/lang/String;)V","invokespecial",79);}
case 79:{return rt.Call(f,"forge/game/Match","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",82);}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/ability/effects/SubgameEffect","prepareAllZonesSubgame","(Lforge/game/Game;Lforge/game/Game;)V","invokevirtual",89);}
case 89:{f.Push(f.Locals[5]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",94);}
case 94:{f.Push(JValue.R(null));f.Pc=95;continue;}
case 95:{f.Push(JValue.R(null));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/GameAction","startGame","(Lforge/game/GameOutcome;Ljava/lang/Runnable;)V","invokevirtual",99);}
case 99:{f.Push(f.Locals[5]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/Game","clearCaches","()V","invokevirtual",104);}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/Game","getOutcome","()Lforge/game/GameOutcome;","invokevirtual",109);}
case 109:{f.Locals[7]=f.Pop();f.Pc=111;continue;}
case 111:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",114);}
case 114:{f.Locals[8]=f.Pop();f.Pc=116;continue;}
case 116:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",119);}
case 119:{f.Locals[9]=f.Pop();f.Pc=121;continue;}
case 121:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=124;continue;}
case 124:{f.StackOp("dup");f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",128);}
case 128:{f.Locals[10]=f.Pop();f.Pc=130;continue;}
case 130:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=133;continue;}
case 133:{f.StackOp("dup");f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",137);}
case 137:{f.Locals[11]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[3]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",143);}
case 143:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",146);}
case 146:{f.Locals[12]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[12]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",155);}
case 155:{f.Pc=f.Pop().Int==0?269:158;continue;}
case 158:{f.Push(f.Locals[12]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",165);}
case 165:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=168;continue;}
case 168:{f.Locals[13]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[7]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[13]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/player/Player","getRegisteredPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",177);}
case 177:{return rt.Call(f,"forge/game/GameOutcome","isWinner","(Lforge/game/player/RegisteredPlayer;)Z","invokevirtual",180);}
case 180:{f.Pc=f.Pop().Int==0?226:183;continue;}
case 183:{f.Push(f.Locals[8]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",190);}
case 190:{f.Pc=f.Pop().Int!=0?202:193;continue;}
case 193:{f.Push(f.Locals[10]);f.Pc=195;continue;}
case 195:{f.Push(JValue.R(rt.String(", ")));f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",201);}
case 201:{f.StackOp("pop");f.Pc=202;continue;}
case 202:{f.Push(f.Locals[10]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[13]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",209);}
case 209:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",212);}
case 212:{f.StackOp("pop");f.Pc=213;continue;}
case 213:{f.Push(f.Locals[8]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[13]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",222);}
case 222:{f.StackOp("pop");f.Pc=223;continue;}
case 223:{f.Pc=266;continue;}
case 226:{f.Push(f.Locals[9]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",233);}
case 233:{f.Pc=f.Pop().Int!=0?245:236;continue;}
case 236:{f.Push(f.Locals[11]);f.Pc=238;continue;}
case 238:{f.Push(JValue.R(rt.String(", ")));f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",244);}
case 244:{f.StackOp("pop");f.Pc=245;continue;}
case 245:{f.Push(f.Locals[11]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[13]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",252);}
case 252:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",255);}
case 255:{f.StackOp("pop");f.Pc=256;continue;}
case 256:{f.Push(f.Locals[9]);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[13]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",265);}
case 265:{f.StackOp("pop");f.Pc=266;continue;}
case 266:{f.Pc=148;continue;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("RememberPlayers")));f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",276);}
case 276:{f.Pc=f.Pop().Int==0?325:279;continue;}
case 279:{f.Push(f.Locals[1]);f.Pc=280;continue;}
case 280:{f.Push(JValue.R(rt.String("RememberPlayers")));f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",286);}
case 286:{f.Locals[12]=f.Pop();f.Pc=288;continue;}
case 288:{f.Push(f.Locals[12]);f.Pc=290;continue;}
case 290:{f.Push(JValue.R(rt.String("Win")));f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",296);}
case 296:{f.Pc=f.Pop().Int==0?308:299;continue;}
case 299:{f.Push(f.Locals[2]);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[8]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",305);}
case 305:{f.Pc=325;continue;}
case 308:{f.Push(f.Locals[12]);f.Pc=310;continue;}
case 310:{f.Push(JValue.R(rt.String("NotWin")));f.Pc=313;continue;}
case 313:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",316);}
case 316:{f.Pc=f.Pop().Int==0?325:319;continue;}
case 319:{f.Push(f.Locals[2]);f.Pc=320;continue;}
case 320:{f.Push(f.Locals[9]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",325);}
case 325:{f.Push(f.Locals[7]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/GameOutcome","isDraw","()Z","invokevirtual",330);}
case 330:{f.Pc=f.Pop().Int==0?349:333;continue;}
case 333:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",336);}
case 336:{f.Push(JValue.R(rt.String("lblSubgameEndDraw")));f.Pc=339;continue;}
case 339:{f.Push(JValue.I(0));f.Pc=340;continue;}
case 340:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",346);}
case 346:{f.Pc=378;continue;}
case 349:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",352);}
case 352:{f.Push(JValue.R(rt.String("lblSubgameEnd")));f.Pc=355;continue;}
case 355:{f.Push(JValue.I(2));f.Pc=356;continue;}
case 356:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=359;continue;}
case 359:{f.StackOp("dup");f.Pc=360;continue;}
case 360:{f.Push(JValue.I(0));f.Pc=361;continue;}
case 361:{f.Push(f.Locals[10]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",366);}
case 366:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=367;continue;}
case 367:{f.StackOp("dup");f.Pc=368;continue;}
case 368:{f.Push(JValue.I(1));f.Pc=369;continue;}
case 369:{f.Push(f.Locals[11]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",374);}
case 374:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",378);}
case 378:{f.Locals[12]=f.Pop();f.Pc=380;continue;}
case 380:{f.Push(f.Locals[3]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/Game","getMatch","()Lforge/game/Match;","invokevirtual",384);}
case 384:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventSubgameEnd"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventSubgameEnd")));f.Pc=387;continue;}
case 387:{f.StackOp("dup");f.Pc=388;continue;}
case 388:{f.Push(f.Locals[3]);f.Pc=389;continue;}
case 389:{f.Push(f.Locals[12]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/event/GameEventSubgameEnd","<init>","(Lforge/game/Game;Ljava/lang/String;)V","invokespecial",394);}
case 394:{return rt.Call(f,"forge/game/Match","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",397);}
case 397:{f.Push(f.Locals[3]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/Game","getDayTime","()Ljava/lang/Boolean;","invokevirtual",401);}
case 401:{f.Pc=f.Pop().Reference==null?422:404;continue;}
case 404:{f.Push(f.Locals[3]);f.Pc=405;continue;}
case 405:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventDayTimeChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventDayTimeChanged")));f.Pc=408;continue;}
case 408:{f.StackOp("dup");f.Pc=409;continue;}
case 409:{f.Push(f.Locals[3]);f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/game/Game","getDayTime","()Ljava/lang/Boolean;","invokevirtual",413);}
case 413:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",416);}
case 416:{return rt.Call(f,"forge/game/event/GameEventDayTimeChanged","<init>","(Z)V","invokespecial",419);}
case 419:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",422);}
case 422:{f.Push(f.Locals[3]);f.Pc=423;continue;}
case 423:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",426);}
case 426:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",429);}
case 429:{f.Locals[13]=f.Pop();f.Pc=431;continue;}
case 431:{f.Push(f.Locals[13]);f.Pc=433;continue;}
case 433:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",438);}
case 438:{f.Pc=f.Pop().Int==0?556:441;continue;}
case 441:{f.Push(f.Locals[13]);f.Pc=443;continue;}
case 443:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",448);}
case 448:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=451;continue;}
case 451:{f.Locals[14]=f.Pop();f.Pc=453;continue;}
case 453:{f.Push(f.Locals[3]);f.Pc=454;continue;}
case 454:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventZone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventZone")));f.Pc=457;continue;}
case 457:{f.StackOp("dup");f.Pc=458;continue;}
case 458:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=461;continue;}
case 461:{f.Push(f.Locals[14]);f.Pc=463;continue;}
case 463:{if(!rt.StaticReady(f,"forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"));f.Pc=466;continue;}
case 466:{f.Push(JValue.R(null));f.Pc=467;continue;}
case 467:{return rt.Call(f,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;Lforge/game/event/EventValueChangeType;Lforge/game/card/Card;)V","invokespecial",470);}
case 470:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",473);}
case 473:{f.Push(f.Locals[3]);f.Pc=474;continue;}
case 474:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventZone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventZone")));f.Pc=477;continue;}
case 477:{f.StackOp("dup");f.Pc=478;continue;}
case 478:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=481;continue;}
case 481:{f.Push(f.Locals[14]);f.Pc=483;continue;}
case 483:{if(!rt.StaticReady(f,"forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"));f.Pc=486;continue;}
case 486:{f.Push(JValue.R(null));f.Pc=487;continue;}
case 487:{return rt.Call(f,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;Lforge/game/event/EventValueChangeType;Lforge/game/card/Card;)V","invokespecial",490);}
case 490:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",493);}
case 493:{f.Push(f.Locals[3]);f.Pc=494;continue;}
case 494:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventZone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventZone")));f.Pc=497;continue;}
case 497:{f.StackOp("dup");f.Pc=498;continue;}
case 498:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=501;continue;}
case 501:{f.Push(f.Locals[14]);f.Pc=503;continue;}
case 503:{if(!rt.StaticReady(f,"forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"));f.Pc=506;continue;}
case 506:{f.Push(JValue.R(null));f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;Lforge/game/event/EventValueChangeType;Lforge/game/card/Card;)V","invokespecial",510);}
case 510:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",513);}
case 513:{f.Push(f.Locals[3]);f.Pc=514;continue;}
case 514:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventZone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventZone")));f.Pc=517;continue;}
case 517:{f.StackOp("dup");f.Pc=518;continue;}
case 518:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=521;continue;}
case 521:{f.Push(f.Locals[14]);f.Pc=523;continue;}
case 523:{if(!rt.StaticReady(f,"forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"));f.Pc=526;continue;}
case 526:{f.Push(JValue.R(null));f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;Lforge/game/event/EventValueChangeType;Lforge/game/card/Card;)V","invokespecial",530);}
case 530:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",533);}
case 533:{f.Push(f.Locals[3]);f.Pc=534;continue;}
case 534:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventZone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventZone")));f.Pc=537;continue;}
case 537:{f.StackOp("dup");f.Pc=538;continue;}
case 538:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=541;continue;}
case 541:{f.Push(f.Locals[14]);f.Pc=543;continue;}
case 543:{if(!rt.StaticReady(f,"forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"));f.Pc=546;continue;}
case 546:{f.Push(JValue.R(null));f.Pc=547;continue;}
case 547:{return rt.Call(f,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;Lforge/game/event/EventValueChangeType;Lforge/game/card/Card;)V","invokespecial",550);}
case 550:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",553);}
case 553:{f.Pc=431;continue;}
case 556:{f.Push(f.Locals[5]);f.Pc=558;continue;}
case 558:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",561);}
case 561:{f.Locals[13]=f.Pop();f.Pc=563;continue;}
case 563:{f.Push(f.Locals[3]);f.Pc=564;continue;}
case 564:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",567);}
case 567:{f.Locals[14]=f.Pop();f.Pc=569;continue;}
case 569:{f.Push(JValue.I(0));f.Pc=570;continue;}
case 570:{f.Locals[15]=f.Pop();f.Pc=572;continue;}
case 572:{f.Push(f.Locals[15]);f.Pc=574;continue;}
case 574:{f.Push(f.Locals[14]);f.Pc=576;continue;}
case 576:{return rt.Call(f,"forge/util/collect/FCollectionView","size","()I","invokeinterface",581);}
case 581:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?979:584;continue;}
case 584:{f.Push(f.Locals[13]);f.Pc=586;continue;}
case 586:{f.Push(f.Locals[15]);f.Pc=588;continue;}
case 588:{return rt.Call(f,"forge/util/collect/FCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",593);}
case 593:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=596;continue;}
case 596:{f.Locals[16]=f.Pop();f.Pc=598;continue;}
case 598:{f.Push(f.Locals[14]);f.Pc=600;continue;}
case 600:{f.Push(f.Locals[15]);f.Pc=602;continue;}
case 602:{return rt.Call(f,"forge/util/collect/FCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",607);}
case 607:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=610;continue;}
case 610:{f.Locals[17]=f.Pop();f.Pc=612;continue;}
case 612:{f.Push(f.Locals[17]);f.Pc=614;continue;}
case 614:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Subgame","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Subgame","Lforge/game/zone/ZoneType;"));f.Pc=617;continue;}
case 617:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",620);}
case 620:{f.Locals[18]=f.Pop();f.Pc=622;continue;}
case 622:{f.Push(f.Locals[17]);f.Pc=624;continue;}
case 624:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=627;continue;}
case 627:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",630);}
case 630:{f.Locals[19]=f.Pop();f.Pc=632;continue;}
case 632:{f.Push(f.Locals[18]);f.Pc=634;continue;}
case 634:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",639);}
case 639:{f.Locals[20]=f.Pop();f.Pc=641;continue;}
case 641:{f.Push(f.Locals[20]);f.Pc=643;continue;}
case 643:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",648);}
case 648:{f.Pc=f.Pop().Int==0?673:651;continue;}
case 651:{f.Push(f.Locals[20]);f.Pc=653;continue;}
case 653:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",658);}
case 658:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=661;continue;}
case 661:{f.Locals[21]=f.Pop();f.Pc=663;continue;}
case 663:{f.Push(f.Locals[19]);f.Pc=665;continue;}
case 665:{f.Push(f.Locals[21]);f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/game/zone/PlayerZone","add","(Lforge/game/card/Card;)V","invokevirtual",670);}
case 670:{f.Pc=641;continue;}
case 673:{f.Push(f.Locals[17]);f.Pc=675;continue;}
case 675:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Subgame","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Subgame","Lforge/game/zone/ZoneType;"));f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",681);}
case 681:{f.Push(JValue.I(1));f.Pc=682;continue;}
case 682:{return rt.Call(f,"forge/game/zone/PlayerZone","removeAllCards","(Z)V","invokevirtual",685);}
case 685:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",688);}
case 688:{f.Locals[20]=f.Pop();f.Pc=690;continue;}
case 690:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",693);}
case 693:{f.Locals[21]=f.Pop();f.Pc=695;continue;}
case 695:{f.Push(f.Locals[16]);f.Pc=697;continue;}
case 697:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=700;continue;}
case 700:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",703);}
case 703:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",708);}
case 708:{f.Locals[22]=f.Pop();f.Pc=710;continue;}
case 710:{f.Push(f.Locals[22]);f.Pc=712;continue;}
case 712:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",717);}
case 717:{f.Pc=f.Pop().Int==0?753:720;continue;}
case 720:{f.Push(f.Locals[22]);f.Pc=722;continue;}
case 722:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",727);}
case 727:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=730;continue;}
case 730:{f.Locals[23]=f.Pop();f.Pc=732;continue;}
case 732:{f.Push(f.Locals[23]);f.Pc=734;continue;}
case 734:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",737);}
case 737:{f.Pc=f.Pop().Int==0?750:740;continue;}
case 740:{f.Push(f.Locals[20]);f.Pc=742;continue;}
case 742:{f.Push(f.Locals[23]);f.Pc=744;continue;}
case 744:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",749);}
case 749:{f.StackOp("pop");f.Pc=750;continue;}
case 750:{f.Pc=710;continue;}
case 753:{f.Push(f.Locals[17]);f.Pc=755;continue;}
case 755:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=758;continue;}
case 758:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",761);}
case 761:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",766);}
case 766:{f.Locals[22]=f.Pop();f.Pc=768;continue;}
case 768:{f.Push(f.Locals[22]);f.Pc=770;continue;}
case 770:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",775);}
case 775:{f.Pc=f.Pop().Int==0?872:778;continue;}
case 778:{f.Push(f.Locals[22]);f.Pc=780;continue;}
case 780:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",785);}
case 785:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=788;continue;}
case 788:{f.Locals[23]=f.Pop();f.Pc=790;continue;}
case 790:{f.Push(f.Locals[23]);f.Pc=792;continue;}
case 792:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",795);}
case 795:{f.Pc=f.Pop().Int==0?869:798;continue;}
case 798:{f.Push(JValue.I(0));f.Pc=799;continue;}
case 799:{f.Locals[24]=f.Pop();f.Pc=801;continue;}
case 801:{f.Push(f.Locals[20]);f.Pc=803;continue;}
case 803:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",808);}
case 808:{f.Locals[25]=f.Pop();f.Pc=810;continue;}
case 810:{f.Push(f.Locals[25]);f.Pc=812;continue;}
case 812:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",817);}
case 817:{f.Pc=f.Pop().Int==0?854:820;continue;}
case 820:{f.Push(f.Locals[25]);f.Pc=822;continue;}
case 822:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",827);}
case 827:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=830;continue;}
case 830:{f.Locals[26]=f.Pop();f.Pc=832;continue;}
case 832:{f.Push(f.Locals[23]);f.Pc=834;continue;}
case 834:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",837);}
case 837:{f.Push(f.Locals[26]);f.Pc=839;continue;}
case 839:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",842);}
case 842:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",845);}
case 845:{f.Pc=f.Pop().Int==0?851:848;continue;}
case 848:{f.Push(JValue.I(1));f.Pc=849;continue;}
case 849:{f.Locals[24]=f.Pop();f.Pc=851;continue;}
case 851:{f.Pc=810;continue;}
case 854:{f.Push(f.Locals[24]);f.Pc=856;continue;}
case 856:{f.Pc=f.Pop().Int!=0?869:859;continue;}
case 859:{f.Push(f.Locals[21]);f.Pc=861;continue;}
case 861:{f.Push(f.Locals[23]);f.Pc=863;continue;}
case 863:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",868);}
case 868:{f.StackOp("pop");f.Pc=869;continue;}
case 869:{f.Pc=768;continue;}
case 872:{f.Push(f.Locals[21]);f.Pc=874;continue;}
case 874:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",879);}
case 879:{f.Locals[22]=f.Pop();f.Pc=881;continue;}
case 881:{f.Push(f.Locals[22]);f.Pc=883;continue;}
case 883:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",888);}
case 888:{f.Pc=f.Pop().Int==0?923:891;continue;}
case 891:{f.Push(f.Locals[22]);f.Pc=893;continue;}
case 893:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",898);}
case 898:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=901;continue;}
case 901:{f.Locals[23]=f.Pop();f.Pc=903;continue;}
case 903:{f.Push(f.Locals[3]);f.Pc=904;continue;}
case 904:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",907);}
case 907:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=910;continue;}
case 910:{f.Push(f.Locals[23]);f.Pc=912;continue;}
case 912:{f.Push(JValue.R(null));f.Pc=913;continue;}
case 913:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",916);}
case 916:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",919);}
case 919:{f.StackOp("pop");f.Pc=920;continue;}
case 920:{f.Pc=881;continue;}
case 923:{f.Push(f.Locals[17]);f.Pc=925;continue;}
case 925:{f.Push(f.Locals[1]);f.Pc=926;continue;}
case 926:{return rt.Call(f,"forge/game/player/Player","shuffle","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",929);}
case 929:{f.Push(f.Locals[17]);f.Pc=931;continue;}
case 931:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"));f.Pc=934;continue;}
case 934:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",937);}
case 937:{return rt.Call(f,"forge/game/zone/PlayerZone","shuffle","()V","invokevirtual",940);}
case 940:{f.Push(f.Locals[17]);f.Pc=942;continue;}
case 942:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"));f.Pc=945;continue;}
case 945:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",948);}
case 948:{return rt.Call(f,"forge/game/zone/PlayerZone","shuffle","()V","invokevirtual",951);}
case 951:{f.Push(f.Locals[17]);f.Pc=953;continue;}
case 953:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"));f.Pc=956;continue;}
case 956:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",959);}
case 959:{return rt.Call(f,"forge/game/zone/PlayerZone","shuffle","()V","invokevirtual",962);}
case 962:{f.Push(f.Locals[17]);f.Pc=964;continue;}
case 964:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"));f.Pc=967;continue;}
case 967:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",970);}
case 970:{return rt.Call(f,"forge/game/zone/PlayerZone","shuffle","()V","invokevirtual",973);}
case 973:{f.Locals[15]=JValue.I(unchecked(f.Locals[15].Int+(1)));f.Pc=976;continue;}
case 976:{f.Pc=572;continue;}
case 979:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

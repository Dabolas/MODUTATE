// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1049{
internal static JClass Build(){var c=new JClass("forge/game/zone/Zone","java/lang/Object",new string[]{"java/io/Serializable","java/lang/Iterable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-5687652485777639176L),null));
c.Add(new JField("cardList","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("zoneType","Lforge/game/zone/ZoneType;",false,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("cardsAddedThisTurn","Lcom/google/common/collect/ListMultimap;",false,JValue.Default("Lcom/google/common/collect/ListMultimap;"),null));
c.Add(new JField("cardsAddedLastTurn","Lcom/google/common/collect/ListMultimap;",false,JValue.Default("Lcom/google/common/collect/ListMultimap;"),null));
c.Add(new JField("enteredFromThisTurn","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("COMPARATOR","Ljava/util/Comparator;",true,JValue.Default("Ljava/util/Comparator;"),null));
c.Add(new JMethod(11110,"forge/game/zone/Zone","sort","()V",4,1,2,new JHandler[]{},M11110));
c.Add(new JMethod(11111,"forge/game/zone/Zone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/Game;)V",1,3,3,new JHandler[]{},M11111));
c.Add(new JMethod(11112,"forge/game/zone/Zone","onChanged","()V",4,1,0,new JHandler[]{},M11112));
c.Add(new JMethod(11113,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M11113));
c.Add(new JMethod(11114,"forge/game/zone/Zone","getView","()Lforge/game/zone/ZoneView;",1,1,4,new JHandler[]{},M11114));
c.Add(new JMethod(11115,"forge/game/zone/Zone","reorder","(Lforge/game/card/Card;I)V",17,3,3,new JHandler[]{},M11115));
c.Add(new JMethod(11116,"forge/game/zone/Zone","add","(Lforge/game/card/Card;)V",17,2,3,new JHandler[]{},M11116));
c.Add(new JMethod(11117,"forge/game/zone/Zone","add","(Lforge/game/card/Card;Ljava/lang/Integer;)V",17,3,4,new JHandler[]{},M11117));
c.Add(new JMethod(11118,"forge/game/zone/Zone","add","(Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/card/Card;)V",1,4,5,new JHandler[]{},M11118));
c.Add(new JMethod(11119,"forge/game/zone/Zone","add","(Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/card/Card;Z)V",1,7,7,new JHandler[]{},M11119));
c.Add(new JMethod(11120,"forge/game/zone/Zone","contains","(Lforge/game/card/Card;)Z",17,2,2,new JHandler[]{},M11120));
c.Add(new JMethod(11121,"forge/game/zone/Zone","contains","(Ljava/util/function/Predicate;)Z",17,2,2,new JHandler[]{},M11121));
c.Add(new JMethod(11122,"forge/game/zone/Zone","remove","(Lforge/game/card/Card;)V",1,2,7,new JHandler[]{},M11122));
c.Add(new JMethod(11123,"forge/game/zone/Zone","setCards","(Ljava/lang/Iterable;)V",17,4,7,new JHandler[]{},M11123));
c.Add(new JMethod(11124,"forge/game/zone/Zone","removeAllCards","(Z)V",17,4,2,new JHandler[]{},M11124));
c.Add(new JMethod(11125,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z",17,2,2,new JHandler[]{},M11125));
c.Add(new JMethod(11126,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;)Z",17,3,2,new JHandler[]{},M11126));
c.Add(new JMethod(11127,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;",17,1,1,new JHandler[]{},M11127));
c.Add(new JMethod(11128,"forge/game/zone/Zone","size","()I",17,1,1,new JHandler[]{},M11128));
c.Add(new JMethod(11129,"forge/game/zone/Zone","get","(I)Lforge/game/card/Card;",17,2,2,new JHandler[]{},M11129));
c.Add(new JMethod(11130,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;",17,1,2,new JHandler[]{},M11130));
c.Add(new JMethod(11131,"forge/game/zone/Zone","getCards","(Z)Lforge/game/card/CardCollectionView;",1,2,1,new JHandler[]{},M11131));
c.Add(new JMethod(11132,"forge/game/zone/Zone","isEmpty","()Z",17,1,1,new JHandler[]{},M11132));
c.Add(new JMethod(11133,"forge/game/zone/Zone","getCardsAddedThisTurn","(Lforge/game/zone/ZoneType;)Ljava/util/List;",17,2,2,new JHandler[]{},M11133));
c.Add(new JMethod(11134,"forge/game/zone/Zone","getCardsAddedLastTurn","(Lforge/game/zone/ZoneType;)Ljava/util/List;",17,2,2,new JHandler[]{},M11134));
c.Add(new JMethod(11135,"forge/game/zone/Zone","isCardAddedThisTurn","(Lforge/game/card/Card;Lforge/game/zone/ZoneType;)Z",17,3,3,new JHandler[]{},M11135));
c.Add(new JMethod(11136,"forge/game/zone/Zone","getCardsAdded","(Lcom/google/common/collect/ListMultimap;Lforge/game/zone/ZoneType;)Ljava/util/List;",10,2,2,new JHandler[]{},M11136));
c.Add(new JMethod(11137,"forge/game/zone/Zone","resetCardsAddedThisTurn","()V",17,1,2,new JHandler[]{},M11137));
c.Add(new JMethod(11138,"forge/game/zone/Zone","iterator","()Ljava/util/Iterator;",1,1,1,new JHandler[]{},M11138));
c.Add(new JMethod(11139,"forge/game/zone/Zone","shuffle","()V",1,1,2,new JHandler[]{},M11139));
c.Add(new JMethod(11140,"forge/game/zone/Zone","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11140));
c.Add(new JMethod(11141,"forge/game/zone/Zone","getLKICopy","(Ljava/util/Map;)Lforge/game/zone/Zone;",1,3,4,new JHandler[]{},M11141));
c.Add(new JMethod(11142,"forge/game/zone/Zone","saveLKI","(Lforge/game/card/Card;Lforge/game/card/Card;)V",1,6,3,new JHandler[]{},M11142));
c.Add(new JMethod(11143,"forge/game/zone/Zone","updateLKI","(Lforge/game/card/Card;)V",1,5,3,new JHandler[]{},M11143));
c.Add(new JMethod(11144,"forge/game/zone/Zone","lambda$static$1","(Lforge/game/card/Card;)Ljava/lang/Float;",4106,1,1,new JHandler[]{},M11144));
c.Add(new JMethod(11145,"forge/game/zone/Zone","lambda$static$0","(Lforge/game/card/Card;)I",4106,1,1,new JHandler[]{},M11145));
c.Add(new JMethod(11146,"forge/game/zone/Zone","<clinit>","()V",8,0,2,new JHandler[]{},M11146));
}

internal static JStep M11110(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/Zone","COMPARATOR","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/Zone","COMPARATOR","Ljava/util/Comparator;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/CardCollection","sort","(Ljava/util/Comparator;)V","invokevirtual",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11111(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.ClassObject("forge/game/zone/ZoneType")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","enumKeys","(Ljava/lang/Class;)Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",21);}
case 21:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","arrayListValues","()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;","invokevirtual",24);}
case 24:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$ListMultimapBuilder","build","()Lcom/google/common/collect/ListMultimap;","invokevirtual",27);}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/Zone","cardsAddedThisTurn","Lcom/google/common/collect/ListMultimap;",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.ClassObject("forge/game/zone/ZoneType")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","enumKeys","(Ljava/lang/Class;)Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",36);}
case 36:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","arrayListValues","()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;","invokevirtual",39);}
case 39:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$ListMultimapBuilder","build","()Lcom/google/common/collect/ListMultimap;","invokevirtual",42);}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/Zone","cardsAddedLastTurn","Lcom/google/common/collect/ListMultimap;",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",49);}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/Zone","enteredFromThisTurn","Ljava/util/Map;",value);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;",value);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/Zone","game","Lforge/game/Game;",value);f.Pc=62;continue;}
case 62:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11112(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11113(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11114(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneView")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/zone/ZoneView","<init>","(Lforge/game/player/PlayerView;Lforge/game/zone/ZoneType;)V","invokespecial",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11115(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardCollection","add","(ILjava/lang/Object;)V","invokevirtual",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11116(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/zone/Zone","add","(Lforge/game/card/Card;Ljava/lang/Integer;)V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11117(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/zone/Zone","add","(Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/card/Card;)V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11118(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/zone/Zone","add","(Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/card/Card;Z)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11119(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?30:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?30:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int<=0?30:21;continue;}
case 21:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Warning: tried to add a card to zone with a specific non-zero index, but the zone was empty! Canceling Zone#add to avoid a crash.")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",29);}
case 29:{return JStep.ReturnVoid;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Reference!=null?114:34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=41;continue;}
case 41:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?114:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?114:51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",55);}
case 55:{f.Locals[2]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","game","Lforge/game/Game;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",63);}
case 63:{if(!rt.StaticReady(f,"forge/game/GameType","Oathbreaker","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Oathbreaker","Lforge/game/GameType;"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/GameRules","hasAppliedVariant","(Lforge/game/GameType;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?114:72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",76);}
case 76:{return rt.Call(f,"forge/card/CardRules","canBeSignatureSpell","()Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?114:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int!=0?114:92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=96;continue;}
case 96:{f.Push(JValue.I(0));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",100);}
case 100:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?114:109;continue;}
case 109:{f.Push(JValue.I(1));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",113);}
case 113:{f.Locals[2]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{f.Pc=f.Pop().Int!=0?261:119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int!=0?215:126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","game","Lforge/game/Game;"));f.Pc=130;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",134);}
case 134:{f.Locals[5]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[5]);f.Pc=138;continue;}
case 138:{f.Pc=f.Pop().Reference!=null?147:141;continue;}
case 141:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=144;continue;}
case 144:{f.Pc=152;continue;}
case 147:{f.Push(f.Locals[5]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",152);}
case 152:{f.Locals[6]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[6]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[0]);f.Pc=157;continue;}
case 157:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=160;continue;}
case 160:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?215:163;continue;}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;","invokevirtual",168);}
case 168:{return rt.Call(f,"forge/game/card/Card","setTurnInController","(Lforge/game/player/Player;)V","invokevirtual",171);}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","game","Lforge/game/Game;"));f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",179);}
case 179:{return rt.Call(f,"forge/game/phase/PhaseHandler","getTurn","()I","invokevirtual",182);}
case 182:{return rt.Call(f,"forge/game/card/Card","setTurnInZone","(I)V","invokevirtual",185);}
case 185:{f.Push(f.Locals[3]);f.Pc=186;continue;}
case 186:{f.Pc=f.Pop().Reference==null?215:189;continue;}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardsAddedThisTurn","Lcom/google/common/collect/ListMultimap;"));f.Pc=193;continue;}
case 193:{f.Push(f.Locals[6]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[3]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"com/google/common/collect/ListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",201);}
case 201:{f.StackOp("pop");f.Pc=202;continue;}
case 202:{f.Push(f.Locals[0]);f.Pc=203;continue;}
case 203:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","enteredFromThisTurn","Ljava/util/Map;"));f.Pc=206;continue;}
case 206:{f.Push(f.Locals[3]);f.Pc=207;continue;}
case 207:{f.Push(f.Locals[6]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",214);}
case 214:{f.StackOp("pop");f.Pc=215;continue;}
case 215:{f.Push(f.Locals[0]);f.Pc=216;continue;}
case 216:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=219;continue;}
case 219:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=222;continue;}
case 222:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?230:225;continue;}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{f.Push(JValue.I(0));f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",230);}
case 230:{f.Push(f.Locals[0]);f.Pc=231;continue;}
case 231:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=234;continue;}
case 234:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=237;continue;}
case 237:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?261:240;continue;}
case 240:{f.Push(f.Locals[1]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",244);}
case 244:{f.Pc=f.Pop().Int==0?261:247;continue;}
case 247:{f.Push(f.Locals[1]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",251);}
case 251:{f.Pc=f.Pop().Int!=0?261:254;continue;}
case 254:{f.Push(f.Locals[1]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",258);}
case 258:{return rt.Call(f,"forge/game/player/Player","descend","()V","invokevirtual",261);}
case 261:{f.Push(f.Locals[1]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[0]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/card/Card","setZone","(Lforge/game/zone/Zone;)V","invokevirtual",266);}
case 266:{f.Push(f.Locals[0]);f.Pc=267;continue;}
case 267:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=270;continue;}
case 270:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=273;continue;}
case 273:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?310:276;continue;}
case 276:{f.Push(f.Locals[1]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",280);}
case 280:{f.Pc=f.Pop().Int==0?310:283;continue;}
case 283:{f.Push(f.Locals[1]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",287);}
case 287:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=290;continue;}
case 290:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?310:293;continue;}
case 293:{f.Push(f.Locals[0]);f.Pc=294;continue;}
case 294:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=297;continue;}
case 297:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=300;continue;}
case 300:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?338:303;continue;}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/card/Card","getCopiedPermanent","()Lforge/game/card/Card;","invokevirtual",307);}
case 307:{f.Pc=f.Pop().Reference==null?338:310;continue;}
case 310:{f.Push(f.Locals[2]);f.Pc=311;continue;}
case 311:{f.Pc=f.Pop().Reference!=null?326:314;continue;}
case 314:{f.Push(f.Locals[0]);f.Pc=315;continue;}
case 315:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=318;continue;}
case 318:{f.Push(f.Locals[1]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",322);}
case 322:{f.StackOp("pop");f.Pc=323;continue;}
case 323:{f.Pc=338;continue;}
case 326:{f.Push(f.Locals[0]);f.Pc=327;continue;}
case 327:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=330;continue;}
case 330:{f.Push(f.Locals[2]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",334);}
case 334:{f.Push(f.Locals[1]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/card/CardCollection","add","(ILjava/lang/Object;)V","invokevirtual",338);}
case 338:{f.Push(f.Locals[0]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/game/zone/Zone","onChanged","()V","invokevirtual",342);}
case 342:{f.Push(f.Locals[0]);f.Pc=343;continue;}
case 343:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","game","Lforge/game/Game;"));f.Pc=346;continue;}
case 346:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventZone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventZone")));f.Pc=349;continue;}
case 349:{f.StackOp("dup");f.Pc=350;continue;}
case 350:{f.Push(f.Locals[0]);f.Pc=351;continue;}
case 351:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=354;continue;}
case 354:{f.Push(f.Locals[0]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;","invokevirtual",358);}
case 358:{if(!rt.StaticReady(f,"forge/game/event/EventValueChangeType","Added","Lforge/game/event/EventValueChangeType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/EventValueChangeType","Added","Lforge/game/event/EventValueChangeType;"));f.Pc=361;continue;}
case 361:{f.Push(f.Locals[1]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;Lforge/game/event/EventValueChangeType;Lforge/game/card/Card;)V","invokespecial",365);}
case 365:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",368);}
case 368:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11120(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11121(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11122(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?41:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/zone/Zone","onChanged","()V","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","game","Lforge/game/Game;"));f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventZone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventZone")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;","invokevirtual",31);}
case 31:{if(!rt.StaticReady(f,"forge/game/event/EventValueChangeType","Removed","Lforge/game/event/EventValueChangeType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/EventValueChangeType","Removed","Lforge/game/event/EventValueChangeType;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;Lforge/game/event/EventValueChangeType;Lforge/game/card/Card;)V","invokespecial",38);}
case 38:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",41);}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11123(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?50:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/Card","setZone","(Lforge/game/zone/Zone;)V","invokevirtual",38);}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Pc=14;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/zone/Zone","onChanged","()V","invokevirtual",54);}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","game","Lforge/game/Game;"));f.Pc=58;continue;}
case 58:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventZone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventZone")));f.Pc=61;continue;}
case 61:{f.StackOp("dup");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;","invokevirtual",70);}
case 70:{if(!rt.StaticReady(f,"forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"));f.Pc=73;continue;}
case 73:{f.Push(JValue.R(null));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;Lforge/game/event/EventValueChangeType;Lforge/game/card/Card;)V","invokespecial",77);}
case 77:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",80);}
case 80:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11124(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int==0?14:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",11);}
case 11:{f.Pc=49;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?49:31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/zone/Zone","remove","(Lforge/game/card/Card;)V","invokevirtual",46);}
case 46:{f.Pc=22;continue;}
case 49:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11125(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11126(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?20:8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;","invokevirtual",13);}
case 13:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?20:16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Pc=21;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11127(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11128(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11129(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11130(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/zone/Zone","getCards","(Z)Lforge/game/card/CardCollectionView;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11131(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11132(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11133(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardsAddedThisTurn","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/zone/Zone","getCardsAdded","(Lcom/google/common/collect/ListMultimap;Lforge/game/zone/ZoneType;)Ljava/util/List;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11134(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardsAddedLastTurn","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/zone/Zone","getCardsAdded","(Lcom/google/common/collect/ListMultimap;Lforge/game/zone/ZoneType;)Ljava/util/List;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11135(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardsAddedThisTurn","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/ListMultimap","containsEntry","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int==0?29:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","enteredFromThisTurn","Ljava/util/Map;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",25);}
case 25:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11136(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?15:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",11);}
case 11:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"com/google/common/collect/ListMultimap","isEmpty","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?28:24;continue;}
case 24:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",27);}
case 27:{return JStep.Return(f.Pop());}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"com/google/common/collect/ListMultimap","values","()Ljava/util/Collection;","invokeinterface",34);}
case 34:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",37);}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11137(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardsAddedLastTurn","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/ListMultimap","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardsAddedLastTurn","Lcom/google/common/collect/ListMultimap;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardsAddedThisTurn","Lcom/google/common/collect/ListMultimap;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"com/google/common/collect/ListMultimap","putAll","(Lcom/google/common/collect/Multimap;)Z","invokeinterface",22);}
case 22:{f.StackOp("pop");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardsAddedThisTurn","Lcom/google/common/collect/ListMultimap;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"com/google/common/collect/ListMultimap","clear","()V","invokeinterface",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","enteredFromThisTurn","Ljava/util/Map;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",41);}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11138(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11139(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",7);}
case 7:{return rt.Call(f,"java/util/Collections","shuffle","(Ljava/util/List;Ljava/util/Random;)V","invokestatic",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/zone/Zone","onChanged","()V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11140(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/zone/ZoneType","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11141(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/zone/Zone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/Zone")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","game","Lforge/game/Game;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/zone/Zone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/Game;)V","invokespecial",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/zone/Zone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopyList","(Ljava/lang/Iterable;Ljava/util/Map;)Ljava/util/List;","invokestatic",25);}
case 25:{return rt.Call(f,"forge/game/zone/Zone","setCards","(Ljava/lang/Iterable;)V","invokevirtual",28);}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11142(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference!=null?19:13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=16;continue;}
case 16:{f.Pc=23;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=31;continue;}
case 31:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?35:34;continue;}
case 34:{return JStep.ReturnVoid;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",39);}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardsAddedThisTurn","Lcom/google/common/collect/ListMultimap;"));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"com/google/common/collect/ListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","enteredFromThisTurn","Ljava/util/Map;"));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",68);}
case 68:{f.StackOp("pop");f.Pc=69;continue;}
case 69:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11143(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","enteredFromThisTurn","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference!=null?19:18;continue;}
case 18:{return JStep.ReturnVoid;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/Zone","cardsAddedThisTurn","Lcom/google/common/collect/ListMultimap;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",29);}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/List","lastIndexOf","(Ljava/lang/Object;)I","invokeinterface",37);}
case 37:{f.Locals[4]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Int<0?57:44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",51);}
case 51:{return rt.Call(f,"java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokeinterface",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11144(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/ColorSet","getOrderWeight","()F","invokevirtual",7);}
case 7:{return rt.Call(f,"java/lang/Float","valueOf","(F)Ljava/lang/Float;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11145(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",4);}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11146(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/zone/Zone:11146:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",5);}
case 5:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",8);}
case 8:{return rt.DynamicCall(f,"forge/game/zone/Zone:11146:8:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",13);}
case 13:{return rt.Call(f,"java/util/Comparator","thenComparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokeinterface",18);}
case 18:{return rt.DynamicCall(f,"forge/game/zone/Zone:11146:18:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",23);}
case 23:{return rt.Call(f,"java/util/Comparator","comparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokestatic",26);}
case 26:{return rt.Call(f,"java/util/Comparator","thenComparing","(Ljava/util/Comparator;)Ljava/util/Comparator;","invokeinterface",31);}
case 31:{return rt.DynamicCall(f,"forge/game/zone/Zone:11146:31:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",36);}
case 36:{return rt.Call(f,"java/util/Comparator","thenComparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokeinterface",41);}
case 41:{if(!rt.StaticReady(f,"forge/game/zone/Zone","COMPARATOR","Ljava/util/Comparator;"))return JStep.Continue;rt.PutStatic("forge/game/zone/Zone","COMPARATOR","Ljava/util/Comparator;",f.Pop());f.Pc=44;continue;}
case 44:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

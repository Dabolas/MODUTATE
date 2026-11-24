// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C722{
internal static JClass Build(){var c=new JClass("forge/game/player/RegisteredPlayer","java/lang/Object",new string[]{},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("originalDeck","Lforge/deck/Deck;",false,JValue.Default("Lforge/deck/Deck;"),null));
c.Add(new JField("currentDeck","Lforge/deck/Deck;",false,JValue.Default("Lforge/deck/Deck;"),null));
c.Add(new JField("EmptyList","Ljava/lang/Iterable;",true,JValue.Default("Ljava/lang/Iterable;"),null));
c.Add(new JField("player","Lforge/LobbyPlayer;",false,JValue.Default("Lforge/LobbyPlayer;"),null));
c.Add(new JField("startingLife","I",false,JValue.Default("I"),null));
c.Add(new JField("startingHand","I",false,JValue.Default("I"),null));
c.Add(new JField("manaShards","I",false,JValue.Default("I"),null));
c.Add(new JField("extraCardsOnBattlefield","Ljava/lang/Iterable;",false,JValue.Default("Ljava/lang/Iterable;"),null));
c.Add(new JField("extraCardsInCommandZone","Ljava/lang/Iterable;",false,JValue.Default("Ljava/lang/Iterable;"),null));
c.Add(new JField("schemes","Ljava/lang/Iterable;",false,JValue.Default("Ljava/lang/Iterable;"),null));
c.Add(new JField("planes","Ljava/lang/Iterable;",false,JValue.Default("Ljava/lang/Iterable;"),null));
c.Add(new JField("conspiracies","Ljava/lang/Iterable;",false,JValue.Default("Ljava/lang/Iterable;"),null));
c.Add(new JField("attractions","Ljava/lang/Iterable;",false,JValue.Default("Ljava/lang/Iterable;"),null));
c.Add(new JField("contraptions","Ljava/lang/Iterable;",false,JValue.Default("Ljava/lang/Iterable;"),null));
c.Add(new JField("stickerSheets","Ljava/lang/Iterable;",false,JValue.Default("Ljava/lang/Iterable;"),null));
c.Add(new JField("commanders","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("vanguardAvatars","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("planeswalker","Lforge/item/PaperCard;",false,JValue.Default("Lforge/item/PaperCard;"),null));
c.Add(new JField("teamNumber","I",false,JValue.Default("I"),null));
c.Add(new JField("id","Ljava/lang/Integer;",false,JValue.Default("Ljava/lang/Integer;"),null));
c.Add(new JField("randomFoil","Z",false,JValue.Default("Z"),null));
c.Add(new JField("enableETBCountersEffect","Z",false,JValue.Default("Z"),null));
c.Add(new JField("startGameScripts","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(8781,"forge/game/player/RegisteredPlayer","<init>","(Lforge/deck/Deck;)V",1,2,2,new JHandler[]{},M8781));
c.Add(new JMethod(8782,"forge/game/player/RegisteredPlayer","getId","()Ljava/lang/Integer;",17,1,1,new JHandler[]{},M8782));
c.Add(new JMethod(8783,"forge/game/player/RegisteredPlayer","setId","(Ljava/lang/Integer;)V",17,2,2,new JHandler[]{},M8783));
c.Add(new JMethod(8784,"forge/game/player/RegisteredPlayer","getDeck","()Lforge/deck/Deck;",17,1,1,new JHandler[]{},M8784));
c.Add(new JMethod(8785,"forge/game/player/RegisteredPlayer","getStartingLife","()I",17,1,1,new JHandler[]{},M8785));
c.Add(new JMethod(8786,"forge/game/player/RegisteredPlayer","setStartingLife","(I)V",17,2,2,new JHandler[]{},M8786));
c.Add(new JMethod(8787,"forge/game/player/RegisteredPlayer","getManaShards","()I",17,1,1,new JHandler[]{},M8787));
c.Add(new JMethod(8788,"forge/game/player/RegisteredPlayer","setManaShards","(I)V",17,2,2,new JHandler[]{},M8788));
c.Add(new JMethod(8789,"forge/game/player/RegisteredPlayer","hasEnableETBCountersEffect","()Z",1,1,1,new JHandler[]{},M8789));
c.Add(new JMethod(8790,"forge/game/player/RegisteredPlayer","setEnableETBCountersEffect","(Z)V",1,2,2,new JHandler[]{},M8790));
c.Add(new JMethod(8791,"forge/game/player/RegisteredPlayer","getCardsOnBattlefield","()Ljava/lang/Iterable;",17,1,1,new JHandler[]{},M8791));
c.Add(new JMethod(8792,"forge/game/player/RegisteredPlayer","getExtraCardsInCommandZone","()Ljava/lang/Iterable;",17,1,1,new JHandler[]{},M8792));
c.Add(new JMethod(8793,"forge/game/player/RegisteredPlayer","addExtraCardsOnBattlefield","(Ljava/lang/Iterable;)V",17,2,3,new JHandler[]{},M8793));
c.Add(new JMethod(8794,"forge/game/player/RegisteredPlayer","addExtraCardsInCommandZone","(Ljava/lang/Iterable;)V",17,2,3,new JHandler[]{},M8794));
c.Add(new JMethod(8795,"forge/game/player/RegisteredPlayer","getStartGameScripts","()Ljava/util/List;",17,1,1,new JHandler[]{},M8795));
c.Add(new JMethod(8796,"forge/game/player/RegisteredPlayer","addStartGameScript","(Ljava/util/List;)V",17,2,2,new JHandler[]{},M8796));
c.Add(new JMethod(8797,"forge/game/player/RegisteredPlayer","getStartingHand","()I",1,1,1,new JHandler[]{},M8797));
c.Add(new JMethod(8798,"forge/game/player/RegisteredPlayer","setStartingHand","(I)V",1,2,2,new JHandler[]{},M8798));
c.Add(new JMethod(8799,"forge/game/player/RegisteredPlayer","getSchemes","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M8799));
c.Add(new JMethod(8800,"forge/game/player/RegisteredPlayer","getPlanes","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M8800));
c.Add(new JMethod(8801,"forge/game/player/RegisteredPlayer","setPlanes","(Ljava/lang/Iterable;)V",1,2,2,new JHandler[]{},M8801));
c.Add(new JMethod(8802,"forge/game/player/RegisteredPlayer","getConspiracies","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M8802));
c.Add(new JMethod(8803,"forge/game/player/RegisteredPlayer","assignConspiracies","()V",1,1,3,new JHandler[]{},M8803));
c.Add(new JMethod(8804,"forge/game/player/RegisteredPlayer","getTeamNumber","()I",1,1,1,new JHandler[]{},M8804));
c.Add(new JMethod(8805,"forge/game/player/RegisteredPlayer","setTeamNumber","(I)V",1,2,2,new JHandler[]{},M8805));
c.Add(new JMethod(8806,"forge/game/player/RegisteredPlayer","forCommander","(Lforge/deck/Deck;)Lforge/game/player/RegisteredPlayer;",9,2,3,new JHandler[]{},M8806));
c.Add(new JMethod(8807,"forge/game/player/RegisteredPlayer","forVariants","(ILjava/util/Set;Lforge/deck/Deck;Ljava/lang/Iterable;ZLjava/lang/Iterable;Lforge/deck/CardPool;)Lforge/game/player/RegisteredPlayer;",9,8,3,new JHandler[]{},M8807));
c.Add(new JMethod(8808,"forge/game/player/RegisteredPlayer","getPlayer","()Lforge/LobbyPlayer;",1,1,1,new JHandler[]{},M8808));
c.Add(new JMethod(8809,"forge/game/player/RegisteredPlayer","setPlayer","(Lforge/LobbyPlayer;)Lforge/game/player/RegisteredPlayer;",1,2,2,new JHandler[]{},M8809));
c.Add(new JMethod(8810,"forge/game/player/RegisteredPlayer","getCommanders","()Ljava/util/List;",1,1,1,new JHandler[]{},M8810));
c.Add(new JMethod(8811,"forge/game/player/RegisteredPlayer","assignCommander","()V",1,1,2,new JHandler[]{},M8811));
c.Add(new JMethod(8812,"forge/game/player/RegisteredPlayer","getVanguardAvatars","()Ljava/util/List;",1,1,1,new JHandler[]{},M8812));
c.Add(new JMethod(8813,"forge/game/player/RegisteredPlayer","assignVanguardAvatar","()V",1,2,2,new JHandler[]{},M8813));
c.Add(new JMethod(8814,"forge/game/player/RegisteredPlayer","setVanguardAvatars","(Ljava/util/List;)V",2,4,3,new JHandler[]{},M8814));
c.Add(new JMethod(8815,"forge/game/player/RegisteredPlayer","getPlaneswalker","()Lforge/item/PaperCard;",1,1,1,new JHandler[]{},M8815));
c.Add(new JMethod(8816,"forge/game/player/RegisteredPlayer","setPlaneswalker","(Lforge/item/PaperCard;)V",1,2,2,new JHandler[]{},M8816));
c.Add(new JMethod(8817,"forge/game/player/RegisteredPlayer","getAttractions","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M8817));
c.Add(new JMethod(8818,"forge/game/player/RegisteredPlayer","assignAttractions","()V",2,1,3,new JHandler[]{},M8818));
c.Add(new JMethod(8819,"forge/game/player/RegisteredPlayer","getContraptions","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M8819));
c.Add(new JMethod(8820,"forge/game/player/RegisteredPlayer","assignContraptions","()V",2,1,3,new JHandler[]{},M8820));
c.Add(new JMethod(8821,"forge/game/player/RegisteredPlayer","getStickerSheets","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M8821));
}

private static void Add1(JClass c){
c.Add(new JMethod(8822,"forge/game/player/RegisteredPlayer","assignStickerSheets","()V",2,1,3,new JHandler[]{},M8822));
c.Add(new JMethod(8823,"forge/game/player/RegisteredPlayer","restoreDeck","()V",1,1,3,new JHandler[]{},M8823));
c.Add(new JMethod(8824,"forge/game/player/RegisteredPlayer","useRandomFoil","()Z",1,1,1,new JHandler[]{},M8824));
c.Add(new JMethod(8825,"forge/game/player/RegisteredPlayer","setRandomFoil","(Z)V",1,2,2,new JHandler[]{},M8825));
c.Add(new JMethod(8826,"forge/game/player/RegisteredPlayer","<clinit>","()V",8,0,1,new JHandler[]{},M8826));
}

internal static JStep M8781(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","player","Lforge/LobbyPlayer;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(20));f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","startingLife","I",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(7));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","startingHand","I",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","manaShards","I",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(null));f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsOnBattlefield","Ljava/lang/Iterable;",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(null));f.Pc=33;continue;}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsInCommandZone","Ljava/lang/Iterable;",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(null));f.Pc=38;continue;}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","schemes","Ljava/lang/Iterable;",value);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(null));f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","planes","Ljava/lang/Iterable;",value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","conspiracies","Ljava/lang/Iterable;",value);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(null));f.Pc=53;continue;}
case 53:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","attractions","Ljava/lang/Iterable;",value);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(null));f.Pc=58;continue;}
case 58:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","contraptions","Ljava/lang/Iterable;",value);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(JValue.R(null));f.Pc=63;continue;}
case 63:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","stickerSheets","Ljava/lang/Iterable;",value);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",70);}
case 70:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","commanders","Ljava/util/List;",value);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(null));f.Pc=75;continue;}
case 75:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","vanguardAvatars","Ljava/util/List;",value);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(null));f.Pc=80;continue;}
case 80:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","planeswalker","Lforge/item/PaperCard;",value);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(JValue.I(-1));f.Pc=85;continue;}
case 85:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","teamNumber","I",value);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(null));f.Pc=90;continue;}
case 90:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","id","Ljava/lang/Integer;",value);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","randomFoil","Z",value);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","enableETBCountersEffect","Z",value);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",107);}
case 107:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","startGameScripts","Ljava/util/List;",value);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","originalDeck","Lforge/deck/Deck;",value);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/player/RegisteredPlayer","restoreDeck","()V","invokevirtual",119);}
case 119:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8782(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","id","Ljava/lang/Integer;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8783(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","id","Ljava/lang/Integer;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8784(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","currentDeck","Lforge/deck/Deck;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8785(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","startingLife","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8786(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","startingLife","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8787(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","manaShards","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8788(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","manaShards","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8789(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","enableETBCountersEffect","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8790(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","enableETBCountersEffect","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8791(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsOnBattlefield","Ljava/lang/Iterable;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?13:7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"));f.Pc=10;continue;}
case 10:{f.Pc=17;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsOnBattlefield","Ljava/lang/Iterable;"));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8792(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsInCommandZone","Ljava/lang/Iterable;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?13:7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"));f.Pc=10;continue;}
case 10:{f.Pc=17;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsInCommandZone","Ljava/lang/Iterable;"));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8793(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsOnBattlefield","Ljava/lang/Iterable;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsOnBattlefield","Ljava/lang/Iterable;",value);f.Pc=12;continue;}
case 12:{f.Pc=27;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsOnBattlefield","Ljava/lang/Iterable;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"com/google/common/collect/Iterables","concat","(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/lang/Iterable;","invokestatic",24);}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsOnBattlefield","Ljava/lang/Iterable;",value);f.Pc=27;continue;}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8794(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsInCommandZone","Ljava/lang/Iterable;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsInCommandZone","Ljava/lang/Iterable;",value);f.Pc=12;continue;}
case 12:{f.Pc=27;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsInCommandZone","Ljava/lang/Iterable;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"com/google/common/collect/Iterables","concat","(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/lang/Iterable;","invokestatic",24);}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","extraCardsInCommandZone","Ljava/lang/Iterable;",value);f.Pc=27;continue;}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8795(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","startGameScripts","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8796(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","startGameScripts","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8797(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","startingHand","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8798(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","startingHand","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8799(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","schemes","Ljava/lang/Iterable;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?13:7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"));f.Pc=10;continue;}
case 10:{f.Pc=17;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","schemes","Ljava/lang/Iterable;"));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8800(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","planes","Ljava/lang/Iterable;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?13:7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"));f.Pc=10;continue;}
case 10:{f.Pc=17;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","planes","Ljava/lang/Iterable;"));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8801(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","planes","Ljava/lang/Iterable;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8802(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","conspiracies","Ljava/lang/Iterable;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?13:7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"));f.Pc=10;continue;}
case 10:{f.Pc=17;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","conspiracies","Ljava/lang/Iterable;"));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8803(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","currentDeck","Lforge/deck/Deck;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?30:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","currentDeck","Lforge/deck/Deck;"));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/deck/CardPool","toFlatList","()Ljava/util/List;","invokevirtual",27);}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","conspiracies","Ljava/lang/Iterable;",value);f.Pc=30;continue;}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8804(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","teamNumber","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8805(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","teamNumber","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8806(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/player/RegisteredPlayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/RegisteredPlayer")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/RegisteredPlayer","<init>","(Lforge/deck/Deck;)V","invokespecial",8);}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",14);}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","commanders","Ljava/util/List;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(40));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/player/RegisteredPlayer","setStartingLife","(I)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8807(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/player/RegisteredPlayer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/RegisteredPlayer")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/RegisteredPlayer","<init>","(Lforge/deck/Deck;)V","invokespecial",8);}
case 8:{f.Locals[7]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/game/GameType","Archenemy","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Archenemy","Lforge/game/GameType;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?40:22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int==0?40:27;continue;}
case 27:{f.Push(f.Locals[7]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(40));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/player/RegisteredPlayer","setStartingLife","(I)V","invokevirtual",34);}
case 34:{f.Push(f.Locals[7]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","schemes","Ljava/lang/Iterable;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/game/GameType","ArchenemyRumble","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","ArchenemyRumble","Lforge/game/GameType;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",49);}
case 49:{f.Pc=f.Pop().Int==0?65:52;continue;}
case 52:{f.Push(f.Locals[7]);f.Pc=54;continue;}
case 54:{f.Push(JValue.I(40));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/player/RegisteredPlayer","setStartingLife","(I)V","invokevirtual",59);}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","schemes","Ljava/lang/Iterable;",value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/game/GameType","TwoHeadedGiant","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","TwoHeadedGiant","Lforge/game/GameType;"));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",74);}
case 74:{f.Pc=f.Pop().Int==0?101:77;continue;}
case 77:{f.Push(f.Locals[7]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{if(!rt.StaticReady(f,"forge/game/GameType","Commander","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Commander","Lforge/game/GameType;"));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",88);}
case 88:{f.Pc=f.Pop().Int==0?96:91;continue;}
case 91:{f.Push(JValue.I(40));f.Pc=93;continue;}
case 93:{f.Pc=98;continue;}
case 96:{f.Push(JValue.I(30));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/player/RegisteredPlayer","setStartingLife","(I)V","invokevirtual",101);}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/game/GameType","Commander","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Commander","Lforge/game/GameType;"));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",110);}
case 110:{f.Pc=f.Pop().Int==0?135:113;continue;}
case 113:{f.Push(f.Locals[7]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",119);}
case 119:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","commanders","Ljava/util/List;",value);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[7]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[7]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getStartingLife","()I","invokevirtual",129);}
case 129:{f.Push(JValue.I(20));f.Pc=131;continue;}
case 131:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/player/RegisteredPlayer","setStartingLife","(I)V","invokevirtual",135);}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{if(!rt.StaticReady(f,"forge/game/GameType","Oathbreaker","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Oathbreaker","Lforge/game/GameType;"));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",144);}
case 144:{f.Pc=f.Pop().Int==0?156:147;continue;}
case 147:{f.Push(f.Locals[7]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[2]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",153);}
case 153:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","commanders","Ljava/util/List;",value);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{if(!rt.StaticReady(f,"forge/game/GameType","TinyLeaders","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","TinyLeaders","Lforge/game/GameType;"));f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",165);}
case 165:{f.Pc=f.Pop().Int==0?189:168;continue;}
case 168:{f.Push(f.Locals[7]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[2]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",174);}
case 174:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","commanders","Ljava/util/List;",value);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[7]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[7]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getStartingLife","()I","invokevirtual",184);}
case 184:{f.Push(JValue.I(5));f.Pc=185;continue;}
case 185:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/player/RegisteredPlayer","setStartingLife","(I)V","invokevirtual",189);}
case 189:{f.Push(f.Locals[1]);f.Pc=190;continue;}
case 190:{if(!rt.StaticReady(f,"forge/game/GameType","Brawl","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Brawl","Lforge/game/GameType;"));f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",198);}
case 198:{f.Pc=f.Pop().Int==0?243:201;continue;}
case 201:{f.Push(f.Locals[7]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[2]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",207);}
case 207:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","commanders","Ljava/util/List;",value);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[0]);f.Pc=211;continue;}
case 211:{f.Push(JValue.I(2));f.Pc=212;continue;}
case 212:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?230:215;continue;}
case 215:{f.Push(f.Locals[7]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[7]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getStartingLife","()I","invokevirtual",222);}
case 222:{f.Push(JValue.I(5));f.Pc=223;continue;}
case 223:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/player/RegisteredPlayer","setStartingLife","(I)V","invokevirtual",227);}
case 227:{f.Pc=243;continue;}
case 230:{f.Push(f.Locals[7]);f.Pc=232;continue;}
case 232:{f.Push(f.Locals[7]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getStartingLife","()I","invokevirtual",237);}
case 237:{f.Push(JValue.I(10));f.Pc=239;continue;}
case 239:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/player/RegisteredPlayer","setStartingLife","(I)V","invokevirtual",243);}
case 243:{f.Push(f.Locals[1]);f.Pc=244;continue;}
case 244:{if(!rt.StaticReady(f,"forge/game/GameType","Planechase","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Planechase","Lforge/game/GameType;"));f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",252);}
case 252:{f.Pc=f.Pop().Int==0?262:255;continue;}
case 255:{f.Push(f.Locals[7]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[5]);f.Pc=259;continue;}
case 259:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","planes","Ljava/lang/Iterable;",value);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[1]);f.Pc=263;continue;}
case 263:{if(!rt.StaticReady(f,"forge/game/GameType","Vanguard","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Vanguard","Lforge/game/GameType;"));f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",271);}
case 271:{f.Pc=f.Pop().Int!=0?298:274;continue;}
case 274:{f.Push(f.Locals[1]);f.Pc=275;continue;}
case 275:{if(!rt.StaticReady(f,"forge/game/GameType","MomirBasic","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","MomirBasic","Lforge/game/GameType;"));f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",283);}
case 283:{f.Pc=f.Pop().Int!=0?298:286;continue;}
case 286:{f.Push(f.Locals[1]);f.Pc=287;continue;}
case 287:{if(!rt.StaticReady(f,"forge/game/GameType","MoJhoSto","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","MoJhoSto","Lforge/game/GameType;"));f.Pc=290;continue;}
case 290:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",295);}
case 295:{f.Pc=f.Pop().Int==0?326:298;continue;}
case 298:{f.Push(f.Locals[7]);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[6]);f.Pc=302;continue;}
case 302:{f.Pc=f.Pop().Reference!=null?318:305;continue;}
case 305:{f.Push(f.Locals[2]);f.Pc=306;continue;}
case 306:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"));f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",312);}
case 312:{return rt.Call(f,"forge/deck/CardPool","toFlatList","()Ljava/util/List;","invokevirtual",315);}
case 315:{f.Pc=323;continue;}
case 318:{f.Push(f.Locals[6]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/deck/CardPool","toFlatList","()Ljava/util/List;","invokevirtual",323);}
case 323:{return rt.Call(f,"forge/game/player/RegisteredPlayer","setVanguardAvatars","(Ljava/util/List;)V","invokevirtual",326);}
case 326:{f.Push(f.Locals[7]);f.Pc=328;continue;}
case 328:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8808(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","player","Lforge/LobbyPlayer;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8809(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","player","Lforge/LobbyPlayer;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8810(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","commanders","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8811(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","currentDeck","Lforge/deck/Deck;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/Deck","getCommanders","()Ljava/util/List;","invokevirtual",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","commanders","Ljava/util/List;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8812(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","vanguardAvatars","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8813(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","currentDeck","Lforge/deck/Deck;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference!=null?20:16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{f.Pc=24;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/deck/CardPool","toFlatList","()Ljava/util/List;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/player/RegisteredPlayer","setVanguardAvatars","(Ljava/util/List;)V","invokevirtual",27);}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8814(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","vanguardAvatars","Ljava/util/List;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","vanguardAvatars","Ljava/util/List;"));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference!=null?13:12;continue;}
case 12:{return JStep.ReturnVoid;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","vanguardAvatars","Ljava/util/List;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?77:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getStartingLife","()I","invokevirtual",47);}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/card/CardRules","getLife","()I","invokevirtual",54);}
case 54:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/player/RegisteredPlayer","setStartingLife","(I)V","invokevirtual",58);}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/player/RegisteredPlayer","getStartingHand","()I","invokevirtual",63);}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",67);}
case 67:{return rt.Call(f,"forge/card/CardRules","getHand","()I","invokevirtual",70);}
case 70:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/player/RegisteredPlayer","setStartingHand","(I)V","invokevirtual",74);}
case 74:{f.Pc=23;continue;}
case 77:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8815(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","planeswalker","Lforge/item/PaperCard;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8816(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","planeswalker","Lforge/item/PaperCard;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","planeswalker","Lforge/item/PaperCard;"));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?27:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","currentDeck","Lforge/deck/Deck;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","planeswalker","Lforge/item/PaperCard;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/deck/CardPool","remove","(Lforge/item/InventoryItem;)Z","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8817(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","attractions","Ljava/lang/Iterable;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8818(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","currentDeck","Lforge/deck/Deck;"));f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?30:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","currentDeck","Lforge/deck/Deck;"));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/deck/CardPool","toFlatList","()Ljava/util/List;","invokevirtual",27);}
case 27:{f.Pc=33;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"));f.Pc=33;continue;}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","attractions","Ljava/lang/Iterable;",value);f.Pc=36;continue;}
case 36:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8819(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","contraptions","Ljava/lang/Iterable;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8820(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","currentDeck","Lforge/deck/Deck;"));f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?30:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","currentDeck","Lforge/deck/Deck;"));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/deck/CardPool","toFlatList","()Ljava/util/List;","invokevirtual",27);}
case 27:{f.Pc=33;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"));f.Pc=33;continue;}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","contraptions","Ljava/lang/Iterable;",value);f.Pc=36;continue;}
case 36:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8821(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","stickerSheets","Ljava/lang/Iterable;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8822(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","currentDeck","Lforge/deck/Deck;"));f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?30:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","currentDeck","Lforge/deck/Deck;"));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/deck/CardPool","toFlatList","()Ljava/util/List;","invokevirtual",27);}
case 27:{f.Pc=33;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"));f.Pc=33;continue;}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","stickerSheets","Ljava/lang/Iterable;",value);f.Pc=36;continue;}
case 36:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8823(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","originalDeck","Lforge/deck/Deck;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","originalDeck","Lforge/deck/Deck;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/Deck","getName","()Ljava/lang/String;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/deck/Deck","copyTo","(Ljava/lang/String;)Lforge/deck/DeckBase;","invokevirtual",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","currentDeck","Lforge/deck/Deck;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/player/RegisteredPlayer","assignAttractions","()V","invokevirtual",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/player/RegisteredPlayer","assignContraptions","()V","invokevirtual",29);}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/player/RegisteredPlayer","assignStickerSheets","()V","invokevirtual",33);}
case 33:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8824(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/RegisteredPlayer","randomFoil","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8825(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/RegisteredPlayer","randomFoil","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8826(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/util/Collections","emptyList","()Ljava/util/List;","invokestatic",3);}
case 3:{if(!rt.StaticReady(f,"forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;"))return JStep.Continue;rt.PutStatic("forge/game/player/RegisteredPlayer","EmptyList","Ljava/lang/Iterable;",f.Pop());f.Pc=6;continue;}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

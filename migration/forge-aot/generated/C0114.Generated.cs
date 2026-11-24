// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C114{
internal static JClass Build(){var c=new JClass("forge/deck/generation/DeckGeneratorBase","java/lang/Object",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("trace","Lforge/util/DebugTrace;",false,JValue.Default("Lforge/util/DebugTrace;"),null));
c.Add(new JField("cardCounts","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("maxDuplicates","I",false,JValue.Default("I"),null));
c.Add(new JField("useArtifacts","Z",false,JValue.Default("Z"),null));
c.Add(new JField("basicLandEdition","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("inverseDLands","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("dLands","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("colors","Lforge/card/ColorSet;",false,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("tDeck","Lforge/deck/CardPool;",false,JValue.Default("Lforge/deck/CardPool;"),null));
c.Add(new JField("pool","Lforge/deck/generation/IDeckGenPool;",false,JValue.Default("Lforge/deck/generation/IDeckGenPool;"),null));
c.Add(new JField("landPool","Lforge/deck/generation/IDeckGenPool;",false,JValue.Default("Lforge/deck/generation/IDeckGenPool;"),null));
c.Add(new JField("format","Lforge/deck/DeckFormat;",false,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("fullCardDB","Lforge/deck/generation/IDeckGenPool;",false,JValue.Default("Lforge/deck/generation/IDeckGenPool;"),null));
c.Add(new JField("AI_CAN_PLAY","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("COLORLESS_CARDS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JMethod(1685,"forge/deck/generation/DeckGeneratorBase","getLandPercentage","()F",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(1686,"forge/deck/generation/DeckGeneratorBase","getCreaturePercentage","()F",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(1687,"forge/deck/generation/DeckGeneratorBase","getSpellPercentage","()F",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(1688,"forge/deck/generation/DeckGeneratorBase","<init>","(Lforge/deck/generation/IDeckGenPool;Lforge/deck/DeckFormat;Ljava/util/function/Predicate;)V",1,4,5,new JHandler[]{},M1688));
c.Add(new JMethod(1689,"forge/deck/generation/DeckGeneratorBase","<init>","(Lforge/deck/generation/IDeckGenPool;Lforge/deck/DeckFormat;)V",1,3,5,new JHandler[]{},M1689));
c.Add(new JMethod(1690,"forge/deck/generation/DeckGeneratorBase","setSingleton","(Z)V",1,2,2,new JHandler[]{},M1690));
c.Add(new JMethod(1691,"forge/deck/generation/DeckGeneratorBase","setUseArtifacts","(Z)V",1,2,2,new JHandler[]{},M1691));
c.Add(new JMethod(1692,"forge/deck/generation/DeckGeneratorBase","addCreaturesAndSpells","(ILjava/util/List;Z)V",4,10,8,new JHandler[]{},M1692));
c.Add(new JMethod(1693,"forge/deck/generation/DeckGeneratorBase","getDeck","(IZ)Lforge/deck/CardPool;",1,3,1,new JHandler[]{},M1693));
c.Add(new JMethod(1694,"forge/deck/generation/DeckGeneratorBase","setBasicLandPool","(Ljava/lang/String;)Z",4,3,5,new JHandler[]{},M1694));
c.Add(new JMethod(1695,"forge/deck/generation/DeckGeneratorBase","addSome","(ILjava/util/List;)I",4,7,6,new JHandler[]{},M1695));
c.Add(new JMethod(1696,"forge/deck/generation/DeckGeneratorBase","addSomeStr","(ILjava/util/List;)I",4,7,3,new JHandler[]{},M1696));
c.Add(new JMethod(1697,"forge/deck/generation/DeckGeneratorBase","addBasicLand","(I)V",4,2,3,new JHandler[]{},M1697));
c.Add(new JMethod(1698,"forge/deck/generation/DeckGeneratorBase","addBasicLand","(ILjava/lang/String;)V",4,11,4,new JHandler[]{},M1698));
c.Add(new JMethod(1699,"forge/deck/generation/DeckGeneratorBase","adjustDeckSize","(I)V",4,7,3,new JHandler[]{},M1699));
c.Add(new JMethod(1700,"forge/deck/generation/DeckGeneratorBase","addCmcAdjusted","(Ljava/lang/Iterable;ILjava/util/List;)V",4,18,6,new JHandler[]{},M1700));
c.Add(new JMethod(1701,"forge/deck/generation/DeckGeneratorBase","selectCardsOfMatchingColorForPlayer","(Z)Ljava/lang/Iterable;",4,5,3,new JHandler[]{},M1701));
c.Add(new JMethod(1702,"forge/deck/generation/DeckGeneratorBase","countLands","(Lforge/util/ItemPool;)Ljava/util/Map;",12,5,3,new JHandler[]{},M1702));
c.Add(new JMethod(1703,"forge/deck/generation/DeckGeneratorBase","increment","(Ljava/util/Map;Ljava/lang/String;I)V",12,3,4,new JHandler[]{},M1703));
c.Add(new JMethod(1704,"forge/deck/generation/DeckGeneratorBase","getDualLandList","(Z)Ljava/util/List;",4,2,2,new JHandler[]{},M1704));
c.Add(new JMethod(1705,"forge/deck/generation/DeckGeneratorBase","getDualLandList","(Ljava/util/function/Predicate;)Ljava/util/List;",4,8,4,new JHandler[]{},M1705));
c.Add(new JMethod(1706,"forge/deck/generation/DeckGeneratorBase","regexLandSearch","(Ljava/lang/String;Ljava/lang/Iterable;)Ljava/util/List;",1,9,3,new JHandler[]{},M1706));
c.Add(new JMethod(1707,"forge/deck/generation/DeckGeneratorBase","regexFetchLandSearch","(Ljava/lang/Iterable;)Ljava/util/List;",1,10,4,new JHandler[]{},M1707));
c.Add(new JMethod(1708,"forge/deck/generation/DeckGeneratorBase","addCardNameToList","(Ljava/lang/String;Ljava/util/List;)V",2,3,2,new JHandler[]{},M1708));
c.Add(new JMethod(1709,"forge/deck/generation/DeckGeneratorBase","lambda$static$1","(Lforge/card/CardRules;)Z",4106,2,1,new JHandler[]{},M1709));
c.Add(new JMethod(1710,"forge/deck/generation/DeckGeneratorBase","lambda$selectCardsOfMatchingColorForPlayer$0","(Lforge/card/CardRules;)Z",4098,2,1,new JHandler[]{},M1710));
c.Add(new JMethod(1711,"forge/deck/generation/DeckGeneratorBase","<clinit>","()V",8,0,2,new JHandler[]{},M1711));
}

internal static JStep M1688(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/util/DebugTrace"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/DebugTrace")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/DebugTrace","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","cardCounts","Ljava/util/Map;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(4));f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","maxDuplicates","I",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","useArtifacts","Z",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(null));f.Pc=38;continue;}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","basicLandEdition","Ljava/lang/String;",value);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=45;continue;}
case 45:{f.StackOp("dup");f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",49);}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","inverseDLands","Ljava/util/List;",value);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",60);}
case 60:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","dLands","Ljava/util/List;",value);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",71);}
case 71:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","tDeck","Lforge/deck/CardPool;",value);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGenPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGenPool")));f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/deck/DeckFormat","getCardPool","(Lforge/deck/generation/IDeckGenPool;)Lforge/deck/generation/IDeckGenPool;","invokevirtual",84);}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/deck/generation/IDeckGenPool","getAllCards","(Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokeinterface",90);}
case 90:{return rt.Call(f,"forge/deck/generation/DeckGenPool","<init>","(Ljava/lang/Iterable;)V","invokespecial",93);}
case 93:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","pool","Lforge/deck/generation/IDeckGenPool;",value);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","format","Lforge/deck/DeckFormat;",value);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","fullCardDB","Lforge/deck/generation/IDeckGenPool;",value);f.Pc=106;continue;}
case 106:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1689(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/util/DebugTrace"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/DebugTrace")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/DebugTrace","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","cardCounts","Ljava/util/Map;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(4));f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","maxDuplicates","I",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","useArtifacts","Z",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(null));f.Pc=38;continue;}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","basicLandEdition","Ljava/lang/String;",value);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=45;continue;}
case 45:{f.StackOp("dup");f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",49);}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","inverseDLands","Ljava/util/List;",value);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",60);}
case 60:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","dLands","Ljava/util/List;",value);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",71);}
case 71:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","tDeck","Lforge/deck/CardPool;",value);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGenPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGenPool")));f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/deck/DeckFormat","getCardPool","(Lforge/deck/generation/IDeckGenPool;)Lforge/deck/generation/IDeckGenPool;","invokevirtual",84);}
case 84:{return rt.Call(f,"forge/deck/generation/IDeckGenPool","getAllCards","()Ljava/lang/Iterable;","invokeinterface",89);}
case 89:{return rt.Call(f,"forge/deck/generation/DeckGenPool","<init>","(Ljava/lang/Iterable;)V","invokespecial",92);}
case 92:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","pool","Lforge/deck/generation/IDeckGenPool;",value);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","format","Lforge/deck/DeckFormat;",value);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","fullCardDB","Lforge/deck/generation/IDeckGenPool;",value);f.Pc=105;continue;}
case 105:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1690(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Int==0?9:5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{f.Pc=10;continue;}
case 9:{f.Push(JValue.I(4));f.Pc=10;continue;}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","maxDuplicates","I",value);f.Pc=13;continue;}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1691(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","useArtifacts","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1692(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Building deck of ")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",9);}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",16);}
case 16:{f.Push(JValue.R(rt.String("cards\n")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","selectCardsOfMatchingColorForPlayer","(Z)Ljava/lang/Iterable;","invokevirtual",27);}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_CREATURE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_CREATURE","Ljava/util/function/Predicate;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",37);}
case 37:{f.Locals[5]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","getCreaturePercentage","()F","invokevirtual",43);}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=45;continue;}
case 45:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fmul",a,b));f.Pc=46;continue;}
case 46:{f.Push(JNumbers.Unary("f2d",f.Pop()));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/Math","ceil","(D)D","invokestatic",50);}
case 50:{f.Push(JNumbers.Unary("d2i",f.Pop()));f.Pc=51;continue;}
case 51:{f.Locals[6]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;"));f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("Creatures to add:")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",62);}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",67);}
case 67:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",70);}
case 70:{f.Push(JValue.R(rt.String("\n")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","addCmcAdjusted","(Ljava/lang/Iterable;ILjava/util/List;)V","invokevirtual",85);}
case 85:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_NON_CREATURE_SPELL","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_NON_CREATURE_SPELL","Ljava/util/function/Predicate;"));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",91);}
case 91:{f.Locals[7]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",100);}
case 100:{f.Locals[8]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","getSpellPercentage","()F","invokevirtual",106);}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=108;continue;}
case 108:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fmul",a,b));f.Pc=109;continue;}
case 109:{f.Push(JNumbers.Unary("f2d",f.Pop()));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/Math","ceil","(D)D","invokestatic",113);}
case 113:{f.Push(JNumbers.Unary("d2i",f.Pop()));f.Pc=114;continue;}
case 114:{f.Locals[9]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;"));f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.String("Spells to add:")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",125);}
case 125:{f.Push(f.Locals[9]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",130);}
case 130:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",133);}
case 133:{f.Push(JValue.R(rt.String("\n")));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",138);}
case 138:{f.StackOp("pop");f.Pc=139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[8]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[9]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[2]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","addCmcAdjusted","(Ljava/lang/Iterable;ILjava/util/List;)V","invokevirtual",148);}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;"));f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("Current deck size: %d... should be %f%n")));f.Pc=154;continue;}
case 154:{f.Push(JValue.I(2));f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=158;continue;}
case 158:{f.StackOp("dup");f.Pc=159;continue;}
case 159:{f.Push(JValue.I(0));f.Pc=160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","tDeck","Lforge/deck/CardPool;"));f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",167);}
case 167:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",170);}
case 170:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=171;continue;}
case 171:{f.StackOp("dup");f.Pc=172;continue;}
case 172:{f.Push(JValue.I(1));f.Pc=173;continue;}
case 173:{f.Push(f.Locals[1]);f.Pc=174;continue;}
case 174:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=175;continue;}
case 175:{f.Push(f.Locals[0]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","getCreaturePercentage","()F","invokevirtual",179);}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","getSpellPercentage","()F","invokevirtual",183);}
case 183:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fadd",a,b));f.Pc=184;continue;}
case 184:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fmul",a,b));f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/lang/Float","valueOf","(F)Ljava/lang/Float;","invokestatic",188);}
case 188:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",192);}
case 192:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",195);}
case 195:{f.StackOp("pop");f.Pc=196;continue;}
case 196:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1693(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1694(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?20:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCardPredicates","printedInSet","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",8);}
case 8:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Pc=24;continue;}
case 20:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;"));f.Pc=23;continue;}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGenPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGenPool")));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",32);}
case 32:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",35);}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/util/function/Predicate;)Ljava/util/List;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/deck/generation/DeckGenPool","<init>","(Ljava/lang/Iterable;)V","invokespecial",42);}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","landPool","Lforge/deck/generation/IDeckGenPool;",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","landPool","Lforge/deck/generation/IDeckGenPool;"));f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("Plains")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/deck/generation/IDeckGenPool","contains","(Ljava/lang/String;)Z","invokeinterface",56);}
case 56:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1695(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int!=0?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?234:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",26);}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",30);}
case 30:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","cardCounts","Ljava/util/Map;"));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",49);}
case 49:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",60);}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=62;continue;}
case 62:{f.Locals[6]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","maxDuplicates","I"));f.Pc=70;continue;}
case 70:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?203:73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","tDeck","Lforge/deck/CardPool;"));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","pool","Lforge/deck/generation/IDeckGenPool;"));f.Pc=81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",91);}
case 91:{return rt.Call(f,"forge/deck/generation/IDeckGenPool","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokeinterface",96);}
case 96:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;)V","invokevirtual",99);}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","basicLandEdition","Ljava/lang/String;"));f.Pc=103;continue;}
case 103:{f.Pc=f.Pop().Reference!=null?127:106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[5]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",112);}
case 112:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","setBasicLandPool","(Ljava/lang/String;)Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int==0?127:118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",124);}
case 124:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","basicLandEdition","Ljava/lang/String;",value);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","cardCounts","Ljava/util/Map;"));f.Pc=131;continue;}
case 131:{f.Push(f.Locals[5]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",136);}
case 136:{f.Push(f.Locals[6]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",141);}
case 141:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",146);}
case 146:{f.StackOp("pop");f.Pc=147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;"));f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("(%d) %s [%s]%n")));f.Pc=153;continue;}
case 153:{f.Push(JValue.I(3));f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=157;continue;}
case 157:{f.StackOp("dup");f.Pc=158;continue;}
case 158:{f.Push(JValue.I(0));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",164);}
case 164:{return rt.Call(f,"forge/card/CardRules","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",167);}
case 167:{return rt.Call(f,"forge/card/mana/ManaCost","getCMC","()I","invokevirtual",170);}
case 170:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",173);}
case 173:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=174;continue;}
case 174:{f.StackOp("dup");f.Pc=175;continue;}
case 175:{f.Push(JValue.I(1));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[5]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",181);}
case 181:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=182;continue;}
case 182:{f.StackOp("dup");f.Pc=183;continue;}
case 183:{f.Push(JValue.I(2));f.Pc=184;continue;}
case 184:{f.Push(f.Locals[5]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",189);}
case 189:{return rt.Call(f,"forge/card/CardRules","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",192);}
case 192:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",196);}
case 196:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",199);}
case 199:{f.StackOp("pop");f.Pc=200;continue;}
case 200:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=203;continue;}
case 203:{f.Push(f.Locals[6]);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[0]);f.Pc=206;continue;}
case 206:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","maxDuplicates","I"));f.Pc=209;continue;}
case 209:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?231:212;continue;}
case 212:{f.Push(f.Locals[2]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[5]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",220);}
case 220:{f.StackOp("pop");f.Pc=221;continue;}
case 221:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(-1)));f.Pc=224;continue;}
case 224:{f.Push(f.Locals[3]);f.Pc=225;continue;}
case 225:{f.Pc=f.Pop().Int!=0?231:228;continue;}
case 228:{f.Pc=234;continue;}
case 231:{f.Pc=16;continue;}
case 234:{f.Push(f.Locals[4]);f.Pc=236;continue;}
case 236:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1696(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int!=0?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?154:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",26);}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",30);}
case 30:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","cardCounts","Ljava/util/Map;"));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",57);}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=59;continue;}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","maxDuplicates","I"));f.Pc=67;continue;}
case 67:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?123:70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","tDeck","Lforge/deck/CardPool;"));f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","pool","Lforge/deck/generation/IDeckGenPool;"));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[5]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/deck/generation/IDeckGenPool","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokeinterface",85);}
case 85:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;)V","invokevirtual",88);}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","cardCounts","Ljava/util/Map;"));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",99);}
case 99:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;"));f.Pc=109;continue;}
case 109:{f.Push(f.Locals[5]);f.Pc=111;continue;}
case 111:{return rt.DynamicCall(f,"forge/deck/generation/DeckGeneratorBase:1696:111:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",116);}
case 116:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",119);}
case 119:{f.StackOp("pop");f.Pc=120;continue;}
case 120:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=123;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","maxDuplicates","I"));f.Pc=129;continue;}
case 129:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?151:132;continue;}
case 132:{f.Push(f.Locals[2]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[5]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",140);}
case 140:{f.StackOp("pop");f.Pc=141;continue;}
case 141:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(-1)));f.Pc=144;continue;}
case 144:{f.Push(f.Locals[3]);f.Pc=145;continue;}
case 145:{f.Pc=f.Pop().Int!=0?151:148;continue;}
case 148:{f.Pc=154;continue;}
case 151:{f.Pc=16;continue;}
case 154:{f.Push(f.Locals[4]);f.Pc=156;continue;}
case 156:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1697(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","addBasicLand","(ILjava/lang/String;)V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1698(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",11);}
case 11:{f.Push(JValue.R(rt.String(" basic lands remain")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",17);}
case 17:{f.Push(JValue.R(rt.String("\n")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",22);}
case 22:{f.StackOp("pop");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","tDeck","Lforge/deck/CardPool;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","countLands","(Lforge/util/ItemPool;)Ljava/util/Map;","invokestatic",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Int<=0?65:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?65:44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=48;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{return rt.Call(f,"com/google/common/collect/ImmutableList","get","(I)Ljava/lang/Object;","invokevirtual",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",59);}
case 59:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Push(JValue.F(0));f.Pc=66;continue;}
case 66:{f.Locals[4]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",74);}
case 74:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",79);}
case 79:{f.Locals[5]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",88);}
case 88:{f.Pc=f.Pop().Int==0?161:91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",98);}
case 98:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=101;continue;}
case 101:{f.Locals[6]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[4]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[6]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",118);}
case 118:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=119;continue;}
case 119:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fadd",a,b));f.Pc=120;continue;}
case 120:{f.Locals[4]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;"));f.Pc=126;continue;}
case 126:{f.Push(f.Locals[6]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",133);}
case 133:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",136);}
case 136:{f.Push(JValue.R(rt.String(":")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",142);}
case 142:{f.Push(f.Locals[6]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",149);}
case 149:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",152);}
case 152:{f.Push(JValue.R(rt.String("\n")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",157);}
case 157:{f.StackOp("pop");f.Pc=158;continue;}
case 158:{f.Pc=81;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;"));f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("totalColor:")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",171);}
case 171:{f.Push(f.Locals[4]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/lang/Float","valueOf","(F)Ljava/lang/Float;","invokestatic",176);}
case 176:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",179);}
case 179:{f.Push(JValue.R(rt.String("\n")));f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",184);}
case 184:{f.StackOp("pop");f.Pc=185;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{f.Locals[5]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(f.Locals[3]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",194);}
case 194:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",199);}
case 199:{f.Locals[6]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[6]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",208);}
case 208:{f.Pc=f.Pop().Int==0?402:211;continue;}
case 211:{f.Push(f.Locals[6]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",218);}
case 218:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=221;continue;}
case 221:{f.Locals[7]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(f.Locals[7]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",230);}
case 230:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=233;continue;}
case 233:{f.Locals[8]=f.Pop();f.Pc=235;continue;}
case 235:{f.Push(f.Locals[5]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[1]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[7]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",245);}
case 245:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",251);}
case 251:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=252;continue;}
case 252:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=253;continue;}
case 253:{f.Push(f.Locals[4]);f.Pc=255;continue;}
case 255:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fdiv",a,b));f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/lang/Math","round","(F)I","invokestatic",259);}
case 259:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",262);}
case 262:{f.Locals[9]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(f.Locals[0]);f.Pc=265;continue;}
case 265:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;"));f.Pc=268;continue;}
case 268:{f.Push(JValue.R(rt.String("nLand-")));f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",274);}
case 274:{f.Push(f.Locals[8]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",279);}
case 279:{f.Push(JValue.R(rt.String(":")));f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",285);}
case 285:{f.Push(f.Locals[9]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",290);}
case 290:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",293);}
case 293:{f.Push(JValue.R(rt.String("\n")));f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",298);}
case 298:{f.StackOp("pop");f.Pc=299;continue;}
case 299:{f.Push(f.Locals[0]);f.Pc=300;continue;}
case 300:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","cardCounts","Ljava/util/Map;"));f.Pc=303;continue;}
case 303:{f.Push(f.Locals[8]);f.Pc=305;continue;}
case 305:{f.Push(f.Locals[9]);f.Pc=307;continue;}
case 307:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",310);}
case 310:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",315);}
case 315:{f.StackOp("pop");f.Pc=316;continue;}
case 316:{f.Push(f.Locals[0]);f.Pc=317;continue;}
case 317:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","landPool","Lforge/deck/generation/IDeckGenPool;"));f.Pc=320;continue;}
case 320:{f.Push(JValue.R(rt.String("Plains")));f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/deck/generation/IDeckGenPool","contains","(Ljava/lang/String;)Z","invokeinterface",327);}
case 327:{f.Pc=f.Pop().Int!=0?345:330;continue;}
case 330:{f.Push(f.Locals[0]);f.Pc=331;continue;}
case 331:{f.Push(JValue.R(rt.String("BFZ")));f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","setBasicLandPool","(Ljava/lang/String;)Z","invokevirtual",337);}
case 337:{f.StackOp("pop");f.Pc=338;continue;}
case 338:{f.Push(f.Locals[0]);f.Pc=339;continue;}
case 339:{f.Push(JValue.R(rt.String("BFZ")));f.Pc=342;continue;}
case 342:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","basicLandEdition","Ljava/lang/String;",value);f.Pc=345;continue;}
case 345:{f.Push(JValue.I(0));f.Pc=346;continue;}
case 346:{f.Locals[10]=f.Pop();f.Pc=348;continue;}
case 348:{f.Push(f.Locals[10]);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[9]);f.Pc=352;continue;}
case 352:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?392:355;continue;}
case 355:{f.Push(f.Locals[0]);f.Pc=356;continue;}
case 356:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","tDeck","Lforge/deck/CardPool;"));f.Pc=359;continue;}
case 359:{f.Push(f.Locals[0]);f.Pc=360;continue;}
case 360:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","landPool","Lforge/deck/generation/IDeckGenPool;"));f.Pc=363;continue;}
case 363:{f.Push(f.Locals[8]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[2]);f.Pc=366;continue;}
case 366:{f.Pc=f.Pop().Reference==null?373:369;continue;}
case 369:{f.Push(f.Locals[2]);f.Pc=370;continue;}
case 370:{f.Pc=377;continue;}
case 373:{f.Push(f.Locals[0]);f.Pc=374;continue;}
case 374:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","basicLandEdition","Ljava/lang/String;"));f.Pc=377;continue;}
case 377:{return rt.Call(f,"forge/deck/generation/IDeckGenPool","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokeinterface",382);}
case 382:{f.Push(JValue.I(1));f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",386);}
case 386:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=389;continue;}
case 389:{f.Pc=348;continue;}
case 392:{f.Push(f.Locals[5]);f.Pc=394;continue;}
case 394:{f.Push(f.Locals[9]);f.Pc=396;continue;}
case 396:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=397;continue;}
case 397:{f.Locals[5]=f.Pop();f.Pc=399;continue;}
case 399:{f.Pc=201;continue;}
case 402:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1699(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","tDeck","Lforge/deck/CardPool;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?31:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","tDeck","Lforge/deck/CardPool;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/deck/CardPool","toFlatList","()Ljava/util/List;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","addSome","(ILjava/util/List;)I","invokevirtual",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Pc=165;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?165:36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(3));f.Pc=40;continue;}
case 40:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?165:43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?165:48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","tDeck","Lforge/deck/CardPool;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/deck/CardPool","toFlatList","()Ljava/util/List;","invokevirtual",55);}
case 55:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",60);}
case 60:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","NOT_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","NOT_BASIC_LAND","Ljava/util/function/Predicate;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",68);}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/util/StreamUtil","random","(I)Ljava/util/stream/Collector;","invokestatic",74);}
case 74:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{f.Locals[4]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","tDeck","Lforge/deck/CardPool;"));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/deck/CardPool","removeAllFlat","(Ljava/lang/Iterable;)V","invokevirtual",93);}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",100);}
case 100:{f.Locals[5]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",109);}
case 109:{f.Pc=f.Pop().Int==0?151:112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",119);}
case 119:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=122;continue;}
case 122:{f.Locals[6]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;"));f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("Removed:")));f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",134);}
case 134:{f.Push(f.Locals[6]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",139);}
case 139:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",142);}
case 142:{f.Push(JValue.R(rt.String("\n")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",147);}
case 147:{f.StackOp("pop");f.Pc=148;continue;}
case 148:{f.Pc=102;continue;}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","tDeck","Lforge/deck/CardPool;"));f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",158);}
case 158:{f.Locals[2]=f.Pop();f.Pc=159;continue;}
case 159:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=162;continue;}
case 162:{f.Pc=38;continue;}
case 165:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1700(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[5]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[5]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?52:21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/ImmutablePair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[6]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","getRight","()Ljava/lang/Object;","invokevirtual",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",46);}
case 46:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=47;continue;}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Pc=11;continue;}
case 52:{f.Push(JValue.F(0.6000000238418579f));f.Pc=55;continue;}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","maxDuplicates","I"));f.Pc=63;continue;}
case 63:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fmul",a,b));f.Pc=67;continue;}
case 67:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fdiv",a,b));f.Pc=68;continue;}
case 68:{f.Locals[6]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[6]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=75;continue;}
case 75:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fdiv",a,b));f.Pc=76;continue;}
case 76:{f.Locals[7]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=83;continue;}
case 83:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fdiv",a,b));f.Pc=84;continue;}
case 84:{f.Locals[8]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",92);}
case 92:{f.Locals[9]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[9]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",101);}
case 101:{f.Pc=f.Pop().Int==0?310:104;continue;}
case 104:{f.Push(f.Locals[9]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",111);}
case 111:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/ImmutablePair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=114;continue;}
case 114:{f.Locals[10]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[10]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","getLeft","()Ljava/lang/Object;","invokevirtual",122);}
case 122:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/function/Predicate"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",128);}
case 128:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",131);}
case 131:{f.Locals[11]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[10]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","getRight","()Ljava/lang/Object;","invokevirtual",138);}
case 138:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",144);}
case 144:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=145;continue;}
case 145:{f.Push(f.Locals[7]);f.Pc=147;continue;}
case 147:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fmul",a,b));f.Pc=148;continue;}
case 148:{f.Push(JNumbers.Unary("f2d",f.Pop()));f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/lang/Math","ceil","(D)D","invokestatic",152);}
case 152:{f.Push(JNumbers.Unary("d2i",f.Pop()));f.Pc=153;continue;}
case 153:{f.Locals[12]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[10]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","getRight","()Ljava/lang/Object;","invokevirtual",160);}
case 160:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",166);}
case 166:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=167;continue;}
case 167:{f.Push(f.Locals[8]);f.Pc=169;continue;}
case 169:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fmul",a,b));f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/lang/Math","round","(F)I","invokestatic",173);}
case 173:{f.Locals[13]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[0]);f.Pc=176;continue;}
case 176:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","trace","Lforge/util/DebugTrace;"));f.Pc=179;continue;}
case 179:{f.Push(JValue.R(rt.String("Adding %d cards for cmc range from a pool with %d cards:%n")));f.Pc=182;continue;}
case 182:{f.Push(JValue.I(2));f.Pc=183;continue;}
case 183:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=186;continue;}
case 186:{f.StackOp("dup");f.Pc=187;continue;}
case 187:{f.Push(JValue.I(0));f.Pc=188;continue;}
case 188:{f.Push(f.Locals[13]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",193);}
case 193:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=194;continue;}
case 194:{f.StackOp("dup");f.Pc=195;continue;}
case 195:{f.Push(JValue.I(1));f.Pc=196;continue;}
case 196:{f.Push(f.Locals[12]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",201);}
case 201:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",205);}
case 205:{return rt.Call(f,"forge/util/DebugTrace","append","(Ljava/lang/Object;)Lforge/util/DebugTrace;","invokevirtual",208);}
case 208:{f.StackOp("pop");f.Pc=209;continue;}
case 209:{f.Push(f.Locals[11]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[12]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",216);}
case 216:{f.Locals[14]=f.Pop();f.Pc=218;continue;}
case 218:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",221);}
case 221:{f.Locals[15]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(f.Locals[14]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",230);}
case 230:{f.Locals[16]=f.Pop();f.Pc=232;continue;}
case 232:{f.Push(f.Locals[16]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",239);}
case 239:{f.Pc=f.Pop().Int==0?298:242;continue;}
case 242:{f.Push(f.Locals[16]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",249);}
case 249:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=252;continue;}
case 252:{f.Locals[17]=f.Pop();f.Pc=254;continue;}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","cardCounts","Ljava/util/Map;"));f.Pc=258;continue;}
case 258:{f.Push(f.Locals[17]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",263);}
case 263:{f.Push(JValue.I(0));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",267);}
case 267:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",272);}
case 272:{f.StackOp("pop");f.Pc=273;continue;}
case 273:{f.Push(f.Locals[15]);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[0]);f.Pc=276;continue;}
case 276:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","pool","Lforge/deck/generation/IDeckGenPool;"));f.Pc=279;continue;}
case 279:{f.Push(f.Locals[17]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",284);}
case 284:{return rt.Call(f,"forge/deck/generation/IDeckGenPool","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokeinterface",289);}
case 289:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",294);}
case 294:{f.StackOp("pop");f.Pc=295;continue;}
case 295:{f.Pc=232;continue;}
case 298:{f.Push(f.Locals[0]);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[13]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[15]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","addSome","(ILjava/util/List;)I","invokevirtual",306);}
case 306:{f.StackOp("pop");f.Pc=307;continue;}
case 307:{f.Pc=94;continue;}
case 310:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1701(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int==0?10:4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/deck/generation/DeckGeneratorBase","AI_CAN_PLAY","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/generation/DeckGeneratorBase","AI_CAN_PLAY","Ljava/util/function/Predicate;"));f.Pc=7;continue;}
case 7:{f.Pc=13;continue;}
case 10:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_KEPT_IN_RANDOM_DECKS","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_KEPT_IN_RANDOM_DECKS","Ljava/util/function/Predicate;"));f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"forge/deck/generation/DeckGeneratorBase$MatchColorIdentity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/generation/DeckGeneratorBase$MatchColorIdentity")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","colors","Lforge/card/ColorSet;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$MatchColorIdentity","<init>","(Lforge/card/ColorSet;)V","invokespecial",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.DynamicCall(f,"forge/deck/generation/DeckGeneratorBase:1701:27:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/deck/generation/DeckGeneratorBase;)Ljava/util/function/Predicate;",32);}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","useArtifacts","Z"));f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Int==0?51:41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/deck/generation/DeckGeneratorBase","COLORLESS_CARDS","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/generation/DeckGeneratorBase","COLORLESS_CARDS","Ljava/util/function/Predicate;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",50);}
case 50:{f.Locals[3]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","pool","Lforge/deck/generation/IDeckGenPool;"));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/deck/generation/IDeckGenPool","getAllCards","()Ljava/lang/Iterable;","invokeinterface",60);}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",67);}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",74);}
case 74:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",77);}
case 77:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",80);}
case 80:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1702(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/TreeMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/ItemPool","iterator","()Ljava/util/Iterator;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?234:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/card/CardRules","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/card/mana/ManaCost","getColorProfile","()B","invokevirtual",50);}
case 50:{f.Locals[4]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Int==0?88:59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return rt.Call(f,"com/google/common/collect/ImmutableList","get","(I)Ljava/lang/Object;","invokevirtual",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",82);}
case 82:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","increment","(Ljava/util/Map;Ljava/lang/String;I)V","invokestatic",85);}
case 85:{f.Pc=231;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{f.Push(JValue.I(2));f.Pc=91;continue;}
case 91:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=92;continue;}
case 92:{f.Pc=f.Pop().Int==0?124:95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=99;continue;}
case 99:{f.Push(JValue.I(1));f.Pc=100;continue;}
case 100:{return rt.Call(f,"com/google/common/collect/ImmutableList","get","(I)Ljava/lang/Object;","invokevirtual",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[3]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",118);}
case 118:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","increment","(Ljava/util/Map;Ljava/lang/String;I)V","invokestatic",121);}
case 121:{f.Pc=231;continue;}
case 124:{f.Push(f.Locals[4]);f.Pc=126;continue;}
case 126:{f.Push(JValue.I(4));f.Pc=127;continue;}
case 127:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=128;continue;}
case 128:{f.Pc=f.Pop().Int==0?160:131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=135;continue;}
case 135:{f.Push(JValue.I(2));f.Pc=136;continue;}
case 136:{return rt.Call(f,"com/google/common/collect/ImmutableList","get","(I)Ljava/lang/Object;","invokevirtual",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[3]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",148);}
case 148:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",154);}
case 154:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","increment","(Ljava/util/Map;Ljava/lang/String;I)V","invokestatic",157);}
case 157:{f.Pc=231;continue;}
case 160:{f.Push(f.Locals[4]);f.Pc=162;continue;}
case 162:{f.Push(JValue.I(8));f.Pc=164;continue;}
case 164:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=165;continue;}
case 165:{f.Pc=f.Pop().Int==0?197:168;continue;}
case 168:{f.Push(f.Locals[1]);f.Pc=169;continue;}
case 169:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=172;continue;}
case 172:{f.Push(JValue.I(3));f.Pc=173;continue;}
case 173:{return rt.Call(f,"com/google/common/collect/ImmutableList","get","(I)Ljava/lang/Object;","invokevirtual",176);}
case 176:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[3]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",185);}
case 185:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",191);}
case 191:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","increment","(Ljava/util/Map;Ljava/lang/String;I)V","invokestatic",194);}
case 194:{f.Pc=231;continue;}
case 197:{f.Push(f.Locals[4]);f.Pc=199;continue;}
case 199:{f.Push(JValue.I(16));f.Pc=201;continue;}
case 201:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=202;continue;}
case 202:{f.Pc=f.Pop().Int==0?231:205;continue;}
case 205:{f.Push(f.Locals[1]);f.Pc=206;continue;}
case 206:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=209;continue;}
case 209:{f.Push(JValue.I(4));f.Pc=210;continue;}
case 210:{return rt.Call(f,"com/google/common/collect/ImmutableList","get","(I)Ljava/lang/Object;","invokevirtual",213);}
case 213:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=216;continue;}
case 216:{f.Push(f.Locals[3]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",222);}
case 222:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",228);}
case 228:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","increment","(Ljava/util/Map;Ljava/lang/String;I)V","invokestatic",231);}
case 231:{f.Pc=13;continue;}
case 234:{f.Push(f.Locals[1]);f.Pc=235;continue;}
case 235:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1703(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",6);}
case 6:{return rt.DynamicCall(f,"forge/deck/generation/DeckGeneratorBase:1703:6:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiFunction;",11);}
case 11:{return rt.Call(f,"java/util/Map","merge","(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;","invokeinterface",16);}
case 16:{f.StackOp("pop");f.Pc=17;continue;}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1704(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Int==0?11:5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/deck/generation/DeckGeneratorBase","AI_CAN_PLAY","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/generation/DeckGeneratorBase","AI_CAN_PLAY","Ljava/util/function/Predicate;"));f.Pc=8;continue;}
case 8:{f.Pc=14;continue;}
case 11:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_KEPT_IN_RANDOM_DECKS","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_KEPT_IN_RANDOM_DECKS","Ljava/util/function/Predicate;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","getDualLandList","(Ljava/util/function/Predicate;)Ljava/util/List;","invokevirtual",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1705(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","colors","Lforge/card/ColorSet;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",7);}
case 7:{f.Push(JValue.I(3));f.Pc=8;continue;}
case 8:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?33:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Rupture Spire")));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","dLands","Ljava/util/List;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","addCardNameToList","(Ljava/lang/String;Ljava/util/List;)V","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Undiscovered Paradise")));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","dLands","Ljava/util/List;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","addCardNameToList","(Ljava/lang/String;Ljava/util/List;)V","invokevirtual",33);}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","colors","Lforge/card/ColorSet;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",40);}
case 40:{f.Push(JValue.I(2));f.Pc=41;continue;}
case 41:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?66:44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("Evolving Wilds")));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","dLands","Ljava/util/List;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","addCardNameToList","(Ljava/lang/String;Ljava/util/List;)V","invokevirtual",55);}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("Terramorphic Expanse")));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","dLands","Ljava/util/List;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","addCardNameToList","(Ljava/lang/String;Ljava/util/List;)V","invokevirtual",66);}
case 66:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;"));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/card/CardRulesPredicates","coreType","(Lforge/card/CardType$CoreType;)Ljava/util/function/Predicate;","invokestatic",72);}
case 72:{f.Locals[2]=f.Pop();f.Pc=73;continue;}
case 73:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","NOT_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","NOT_BASIC_LAND","Ljava/util/function/Predicate;"));f.Pc=76;continue;}
case 76:{f.Locals[3]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","pool","Lforge/deck/generation/IDeckGenPool;"));f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",88);}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",94);}
case 94:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",97);}
case 97:{return rt.Call(f,"forge/deck/generation/IDeckGenPool","getAllCards","(Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokeinterface",102);}
case 102:{f.Locals[4]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(JValue.I(4));f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=108;continue;}
case 108:{f.StackOp("dup");f.Pc=109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("Add \\{([WUBRG])\\} or \\{([WUBRG])\\}")));f.Pc=113;continue;}
case 113:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=114;continue;}
case 114:{f.StackOp("dup");f.Pc=115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("Add \\{([WUBRG])\\}, \\{([WUBRG])\\}, or \\{([WUBRG])\\}")));f.Pc=119;continue;}
case 119:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=120;continue;}
case 120:{f.StackOp("dup");f.Pc=121;continue;}
case 121:{f.Push(JValue.I(2));f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("Add \\{([WUBRG])\\}\\{([WUBRG])\\}")));f.Pc=125;continue;}
case 125:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=126;continue;}
case 126:{f.StackOp("dup");f.Pc=127;continue;}
case 127:{f.Push(JValue.I(3));f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("Add \\{[WUBRG]\\}\\{[WUBRG]\\}, \\{([WUBRG])\\}\\{([WUBRG])\\}, or \\{[WUBRG]\\}\\{[WUBRG]\\}")));f.Pc=131;continue;}
case 131:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",135);}
case 135:{f.Locals[5]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[5]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",144);}
case 144:{f.Locals[6]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[6]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",153);}
case 153:{f.Pc=f.Pop().Int==0?180:156;continue;}
case 156:{f.Push(f.Locals[6]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",163);}
case 163:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=166;continue;}
case 166:{f.Locals[7]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[7]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[4]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","regexLandSearch","(Ljava/lang/String;Ljava/lang/Iterable;)Ljava/util/List;","invokevirtual",176);}
case 176:{f.StackOp("pop");f.Pc=177;continue;}
case 177:{f.Pc=146;continue;}
case 180:{f.Push(f.Locals[0]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[4]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","regexFetchLandSearch","(Ljava/lang/Iterable;)Ljava/util/List;","invokevirtual",186);}
case 186:{f.StackOp("pop");f.Pc=187;continue;}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","dLands","Ljava/util/List;"));f.Pc=191;continue;}
case 191:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1706(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?157:23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/card/CardRules","getOracleText","()Ljava/lang/String;","invokevirtual",44);}
case 44:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",47);}
case 47:{f.Locals[6]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[6]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?154:57;continue;}
case 57:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=60;continue;}
case 60:{f.StackOp("dup");f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",64);}
case 64:{f.Locals[7]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{f.Locals[8]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[8]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[6]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/regex/Matcher","groupCount","()I","invokevirtual",76);}
case 76:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?100:79;continue;}
case 79:{f.Push(f.Locals[7]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[6]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[8]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",88);}
case 88:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",93);}
case 93:{f.StackOp("pop");f.Pc=94;continue;}
case 94:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=97;continue;}
case 97:{f.Pc=69;continue;}
case 100:{f.Push(f.Locals[7]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/card/ColorSet","fromNames","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",105);}
case 105:{f.Locals[8]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","colors","Lforge/card/ColorSet;"));f.Pc=111;continue;}
case 111:{f.Push(f.Locals[8]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/card/ColorSet","hasAllColors","(I)Z","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Int==0?138:122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",128);}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","dLands","Ljava/util/List;"));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","addCardNameToList","(Ljava/lang/String;Ljava/util/List;)V","invokevirtual",135);}
case 135:{f.Pc=151;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[5]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",144);}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","inverseDLands","Ljava/util/List;"));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","addCardNameToList","(Ljava/lang/String;Ljava/util/List;)V","invokevirtual",151);}
case 151:{f.Pc=49;continue;}
case 154:{f.Pc=13;continue;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","dLands","Ljava/util/List;"));f.Pc=161;continue;}
case 161:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1707(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Search your library for an* ([^\\s]*) or ([^\\s]*) card")));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("Plains")));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("W")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("Forest")));f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("G")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Mountain")));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("R")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("Island")));f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("U")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("Swamp")));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("B")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("Search your library for an* ([^\\s]*) or ([^\\s]*) card")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",82);}
case 82:{f.Locals[4]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",90);}
case 90:{f.Locals[5]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",99);}
case 99:{f.Pc=f.Pop().Int==0?246:102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",109);}
case 109:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=112;continue;}
case 112:{f.Locals[6]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[6]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",121);}
case 121:{return rt.Call(f,"forge/card/CardRules","getOracleText","()Ljava/lang/String;","invokevirtual",124);}
case 124:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",127);}
case 127:{f.Locals[7]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[7]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int==0?243:137;continue;}
case 137:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=140;continue;}
case 140:{f.StackOp("dup");f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",144);}
case 144:{f.Locals[8]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(JValue.I(1));f.Pc=147;continue;}
case 147:{f.Locals[9]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[9]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[7]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/regex/Matcher","groupCount","()I","invokevirtual",156);}
case 156:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?189:159;continue;}
case 159:{f.Push(f.Locals[8]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[7]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[9]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",169);}
case 169:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",174);}
case 174:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",182);}
case 182:{f.StackOp("pop");f.Pc=183;continue;}
case 183:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=186;continue;}
case 186:{f.Pc=149;continue;}
case 189:{f.Push(f.Locals[8]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/card/ColorSet","fromNames","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",194);}
case 194:{f.Locals[9]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","colors","Lforge/card/ColorSet;"));f.Pc=200;continue;}
case 200:{f.Push(f.Locals[9]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",205);}
case 205:{return rt.Call(f,"forge/card/ColorSet","hasAllColors","(I)Z","invokevirtual",208);}
case 208:{f.Pc=f.Pop().Int==0?227:211;continue;}
case 211:{f.Push(f.Locals[0]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[6]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",217);}
case 217:{f.Push(f.Locals[0]);f.Pc=218;continue;}
case 218:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","dLands","Ljava/util/List;"));f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","addCardNameToList","(Ljava/lang/String;Ljava/util/List;)V","invokevirtual",224);}
case 224:{f.Pc=240;continue;}
case 227:{f.Push(f.Locals[0]);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[6]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",233);}
case 233:{f.Push(f.Locals[0]);f.Pc=234;continue;}
case 234:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","inverseDLands","Ljava/util/List;"));f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase","addCardNameToList","(Ljava/lang/String;Ljava/util/List;)V","invokevirtual",240);}
case 240:{f.Pc=129;continue;}
case 243:{f.Pc=92;continue;}
case 246:{f.Push(f.Locals[0]);f.Pc=247;continue;}
case 247:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","dLands","Ljava/util/List;"));f.Pc=250;continue;}
case 250:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1708(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","pool","Lforge/deck/generation/IDeckGenPool;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/generation/IDeckGenPool","contains","(Ljava/lang/String;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?21:13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1709(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardRules","getColorIdentity","()Lforge/card/ColorSet;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?26:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/mana/ManaCost","isNoCost","()Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int!=0?26:22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Pc=27;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1710(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getAiHints","()Lforge/card/CardAiHints;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardAiHints","getRemNonCommanderDecks","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?20:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase","format","Lforge/deck/DeckFormat;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/deck/DeckFormat","hasCommander","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1711(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_KEPT_IN_AI_DECKS","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_KEPT_IN_AI_DECKS","Ljava/util/function/Predicate;"));f.Pc=3;continue;}
case 3:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_KEPT_IN_RANDOM_DECKS","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_KEPT_IN_RANDOM_DECKS","Ljava/util/function/Predicate;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",11);}
case 11:{if(!rt.StaticReady(f,"forge/deck/generation/DeckGeneratorBase","AI_CAN_PLAY","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/deck/generation/DeckGeneratorBase","AI_CAN_PLAY","Ljava/util/function/Predicate;",f.Pop());f.Pc=14;continue;}
case 14:{return rt.DynamicCall(f,"forge/deck/generation/DeckGeneratorBase:1711:14:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",19);}
case 19:{if(!rt.StaticReady(f,"forge/deck/generation/DeckGeneratorBase","COLORLESS_CARDS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/deck/generation/DeckGeneratorBase","COLORLESS_CARDS","Ljava/util/function/Predicate;",f.Pop());f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C85{
internal static JClass Build(){var c=new JClass("forge/deck/Deck","forge/deck/DeckBase",new string[]{"java/lang/Iterable"},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-8539667316828440829L),null));
c.Add(new JField("DEFAULT_SLEEVE_OFFSET","I",true,JValue.I(500),null));
c.Add(new JField("parts","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("tags","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("aiHints","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("keyCards","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("altCommanders","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("draftNotes","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("deferredSections","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("loadedSections","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("deckFormat","Lforge/deck/DeckFormat;",false,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("sourceUrl","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("lastCardArtPreferenceUsed","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("lastCardArtOptimisationOptionUsed","Ljava/lang/Boolean;",false,JValue.Default("Ljava/lang/Boolean;"),null));
c.Add(new JField("includeCardsFromUnspecifiedSet","Z",false,JValue.Default("Z"),null));
c.Add(new JField("sleeveArtKey","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sleeveArtOffset","I",false,JValue.Default("I"),null));
c.Add(new JField("unplayableAI","Lforge/deck/Deck$UnplayableAICards;",false,JValue.Default("Lforge/deck/Deck$UnplayableAICards;"),null));
c.Add(new JField("$assertionsDisabled","Z",true,JValue.Default("Z"),null));
c.Add(new JMethod(1326,"forge/deck/Deck","<init>","()V",1,1,2,new JHandler[]{},M1326));
c.Add(new JMethod(1327,"forge/deck/Deck","<init>","(Ljava/lang/String;)V",1,2,4,new JHandler[]{},M1327));
c.Add(new JMethod(1328,"forge/deck/Deck","<init>","(Lforge/deck/Deck;)V",1,2,3,new JHandler[]{},M1328));
c.Add(new JMethod(1329,"forge/deck/Deck","<init>","(Lforge/deck/Deck;Ljava/lang/String;)V",1,3,4,new JHandler[]{},M1329));
c.Add(new JMethod(1330,"forge/deck/Deck","getItemType","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1330));
c.Add(new JMethod(1331,"forge/deck/Deck","hashCode","()I",1,1,1,new JHandler[]{},M1331));
c.Add(new JMethod(1332,"forge/deck/Deck","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1332));
c.Add(new JMethod(1333,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;",1,1,2,new JHandler[]{},M1333));
c.Add(new JMethod(1334,"forge/deck/Deck","getValid","()Lorg/apache/commons/lang3/tuple/Pair;",1,7,2,new JHandler[]{},M1334));
c.Add(new JMethod(1335,"forge/deck/Deck","getCommanders","()Ljava/util/List;",1,5,2,new JHandler[]{},M1335));
c.Add(new JMethod(1336,"forge/deck/Deck","getOathbreaker","()Lforge/item/PaperCard;",1,5,2,new JHandler[]{},M1336));
c.Add(new JMethod(1337,"forge/deck/Deck","getSignatureSpell","()Lforge/item/PaperCard;",1,5,2,new JHandler[]{},M1337));
c.Add(new JMethod(1338,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;",1,2,2,new JHandler[]{},M1338));
c.Add(new JMethod(1339,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z",1,3,2,new JHandler[]{},M1339));
c.Add(new JMethod(1340,"forge/deck/Deck","removeCardName","(Ljava/lang/String;)Lforge/item/PaperCard;",1,8,2,new JHandler[]{},M1340));
c.Add(new JMethod(1341,"forge/deck/Deck","removeAnteCard","(Lforge/item/PaperCard;)V",1,4,2,new JHandler[]{},M1341));
c.Add(new JMethod(1342,"forge/deck/Deck","getOrCreate","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;",1,3,3,new JHandler[]{},M1342));
c.Add(new JMethod(1343,"forge/deck/Deck","putSection","(Lforge/deck/DeckSection;Lforge/deck/CardPool;)V",1,3,3,new JHandler[]{},M1343));
c.Add(new JMethod(1344,"forge/deck/Deck","setDeferredSections","(Ljava/util/Map;)V",1,2,2,new JHandler[]{},M1344));
c.Add(new JMethod(1345,"forge/deck/Deck","cloneFieldsTo","(Lforge/deck/DeckBase;)V",4,6,3,new JHandler[]{},M1345));
c.Add(new JMethod(1346,"forge/deck/Deck","newInstance","(Ljava/lang/String;)Lforge/deck/DeckBase;",4,2,3,new JHandler[]{},M1346));
c.Add(new JMethod(1347,"forge/deck/Deck","loadDeferredSections","()V",2,11,3,new JHandler[]{},M1347));
c.Add(new JMethod(1348,"forge/deck/Deck","getNamesToKeepWithNoEdition","(Ljava/util/Map;)Ljava/util/Set;",2,9,2,new JHandler[]{},M1348));
c.Add(new JMethod(1349,"forge/deck/Deck","normalizeDeferredSections","(Ljava/util/Set;)V",2,15,3,new JHandler[]{},M1349));
c.Add(new JMethod(1350,"forge/deck/Deck","getPoolRequest","(Ljava/util/Map$Entry;Ljava/util/Set;)Ljava/lang/String;",2,6,6,new JHandler[]{},M1350));
c.Add(new JMethod(1351,"forge/deck/Deck","getAllCardNamesWithNoSpecifiedEdition","(Ljava/util/List;)Ljava/util/ArrayList;",2,8,2,new JHandler[]{},M1351));
c.Add(new JMethod(1352,"forge/deck/Deck","optimiseCardArt","(Ljava/util/List;)V",1,8,3,new JHandler[]{},M1352));
c.Add(new JMethod(1353,"forge/deck/Deck","optimiseCardArtSelectionInDeckSections","(Ljava/util/Map;)V",2,2,3,new JHandler[]{},M1353));
c.Add(new JMethod(1354,"forge/deck/Deck","optimiseCardArtSelectionInDeckSections","(Ljava/util/Map;Ljava/util/List;)V",2,25,9,new JHandler[]{},M1354));
c.Add(new JMethod(1355,"forge/deck/Deck","addCardToPool","(Lforge/deck/CardPool;Lforge/item/PaperCard;IZ)V",2,10,5,new JHandler[]{},M1355));
c.Add(new JMethod(1356,"forge/deck/Deck","addAlternativeCardPrintInPoolWithMultipleArt","(Lforge/item/PaperCard;Lforge/deck/CardPool;ILjava/util/List;)V",2,16,5,new JHandler[]{},M1356));
c.Add(new JMethod(1357,"forge/deck/Deck","isCardArtUpdateRequired","(Lforge/item/PaperCard;Ljava/util/Date;)Z",2,6,2,new JHandler[]{},M1357));
c.Add(new JMethod(1358,"forge/deck/Deck","iterator","()Ljava/util/Iterator;",1,1,1,new JHandler[]{},M1358));
c.Add(new JMethod(1359,"forge/deck/Deck","getTags","()Ljava/util/Set;",1,1,1,new JHandler[]{},M1359));
c.Add(new JMethod(1360,"forge/deck/Deck","getAllCardsInASinglePool","()Lforge/deck/CardPool;",1,1,3,new JHandler[]{},M1360));
c.Add(new JMethod(1361,"forge/deck/Deck","getAllCardsInASinglePool","(ZZ)Lforge/deck/CardPool;",1,8,3,new JHandler[]{},M1361));
c.Add(new JMethod(1362,"forge/deck/Deck","countByName","(Ljava/lang/String;)I",1,5,3,new JHandler[]{},M1362));
c.Add(new JMethod(1363,"forge/deck/Deck","count","(Lforge/item/PaperCard;)I",1,5,3,new JHandler[]{},M1363));
c.Add(new JMethod(1364,"forge/deck/Deck","getSleeveArtKey","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1364));
c.Add(new JMethod(1365,"forge/deck/Deck","setSleeveArtKey","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M1365));
c.Add(new JMethod(1366,"forge/deck/Deck","getSleeveArtOffset","()I",1,1,1,new JHandler[]{},M1366));
c.Add(new JMethod(1367,"forge/deck/Deck","setSleeveArtOffset","(I)V",1,2,2,new JHandler[]{},M1367));
c.Add(new JMethod(1368,"forge/deck/Deck","getKeyCards","()Ljava/util/List;",1,1,3,new JHandler[]{},M1368));
c.Add(new JMethod(1369,"forge/deck/Deck","addKeyCard","(Ljava/lang/String;)V",1,3,2,new JHandler[]{},M1369));
c.Add(new JMethod(1370,"forge/deck/Deck","removeKeyCard","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M1370));
}

private static void Add1(JClass c){
c.Add(new JMethod(1371,"forge/deck/Deck","isKeyCard","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M1371));
c.Add(new JMethod(1372,"forge/deck/Deck","getAltCommanders","()Ljava/util/List;",1,1,3,new JHandler[]{},M1372));
c.Add(new JMethod(1373,"forge/deck/Deck","addAltCommander","(Ljava/lang/String;)V",1,3,2,new JHandler[]{},M1373));
c.Add(new JMethod(1374,"forge/deck/Deck","setDraftNotes","(Ljava/util/Map;)V",1,5,3,new JHandler[]{},M1374));
c.Add(new JMethod(1375,"forge/deck/Deck","getDraftNotes","()Ljava/util/Map;",1,1,1,new JHandler[]{},M1375));
c.Add(new JMethod(1376,"forge/deck/Deck","setDeckFormat","(Lforge/deck/DeckFormat;)V",1,2,2,new JHandler[]{},M1376));
c.Add(new JMethod(1377,"forge/deck/Deck","getDeckFormat","()Lforge/deck/DeckFormat;",1,1,1,new JHandler[]{},M1377));
c.Add(new JMethod(1378,"forge/deck/Deck","setSourceUrl","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M1378));
c.Add(new JMethod(1379,"forge/deck/Deck","getSourceUrl","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1379));
c.Add(new JMethod(1380,"forge/deck/Deck","setAiHints","(Ljava/lang/String;)V",1,7,2,new JHandler[]{},M1380));
c.Add(new JMethod(1381,"forge/deck/Deck","getAiHints","()Ljava/util/Set;",1,1,1,new JHandler[]{},M1381));
c.Add(new JMethod(1382,"forge/deck/Deck","getAiHint","(Ljava/lang/String;)Ljava/lang/String;",1,4,3,new JHandler[]{},M1382));
c.Add(new JMethod(1383,"forge/deck/Deck","setAiHint","(Ljava/lang/String;Ljava/lang/String;)V",1,3,3,new JHandler[]{},M1383));
c.Add(new JMethod(1384,"forge/deck/Deck","getUnplayableAICards","()Lforge/deck/Deck$UnplayableAICards;",1,1,4,new JHandler[]{},M1384));
c.Add(new JMethod(1385,"forge/deck/Deck","isEmpty","()Z",1,3,1,new JHandler[]{},M1385));
c.Add(new JMethod(1386,"forge/deck/Deck","getImageKey","(Z)Ljava/lang/String;",1,2,1,new JHandler[]{},M1386));
c.Add(new JMethod(1387,"forge/deck/Deck","getHumanDeck","()Lforge/deck/Deck;",1,1,1,new JHandler[]{},M1387));
c.Add(new JMethod(1388,"forge/deck/Deck","readResolve","()Ljava/lang/Object;",2,1,4,new JHandler[]{},M1388));
c.Add(new JMethod(1389,"forge/deck/Deck","equals","(Ljava/lang/Object;)Z",1,9,2,new JHandler[]{},M1389));
c.Add(new JMethod(1390,"forge/deck/Deck","getAverageCMC","()I",1,9,2,new JHandler[]{},M1390));
c.Add(new JMethod(1391,"forge/deck/Deck","generateTextExport","()Ljava/lang/String;",1,11,4,new JHandler[]{},M1391));
c.Add(new JMethod(1392,"forge/deck/Deck","lambda$generateTextExport$5","(Ljava/util/Map$Entry;)I",4106,1,1,new JHandler[]{},M1392));
c.Add(new JMethod(1393,"forge/deck/Deck","lambda$generateTextExport$4","(Ljava/util/Map$Entry;)Ljava/lang/String;",4106,1,1,new JHandler[]{},M1393));
c.Add(new JMethod(1394,"forge/deck/Deck","lambda$setAiHint$3","(Ljava/lang/String;Ljava/lang/String;)Z",4106,2,2,new JHandler[]{},M1394));
c.Add(new JMethod(1395,"forge/deck/Deck","lambda$normalizeDeferredSections$2","(Ljava/lang/String;)Ljava/util/List;",4106,1,2,new JHandler[]{},M1395));
c.Add(new JMethod(1396,"forge/deck/Deck","lambda$normalizeDeferredSections$1","(Ljava/lang/String;)Ljava/util/List;",4106,1,2,new JHandler[]{},M1396));
c.Add(new JMethod(1397,"forge/deck/Deck","lambda$getCommanders$0","(Lforge/item/PaperCard;)Ljava/lang/Boolean;",4106,1,1,new JHandler[]{},M1397));
c.Add(new JMethod(1398,"forge/deck/Deck","<clinit>","()V",8,0,1,new JHandler[]{},M1398));
}

internal static JStep M1326(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/Deck","<init>","(Ljava/lang/String;)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1327(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/DeckBase","<init>","(Ljava/lang/String;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/util/EnumMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/EnumMap")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.ClassObject("forge/deck/DeckSection")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/EnumMap","<init>","(Ljava/lang/Class;)V","invokespecial",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"java/util/TreeSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeSet")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/TreeSet","<init>","(Ljava/util/Comparator;)V","invokespecial",29);}
case 29:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","tags","Ljava/util/Set;",value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"java/util/TreeSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeSet")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/TreeSet","<init>","()V","invokespecial",40);}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","aiHints","Ljava/util/Set;",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",51);}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","keyCards","Ljava/util/List;",value);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",62);}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","altCommanders","Ljava/util/List;",value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",73);}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","draftNotes","Ljava/util/Map;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(null));f.Pc=78;continue;}
case 78:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","deferredSections","Ljava/util/Map;",value);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(null));f.Pc=83;continue;}
case 83:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","loadedSections","Ljava/util/Map;",value);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("")));f.Pc=89;continue;}
case 89:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","lastCardArtPreferenceUsed","Ljava/lang/String;",value);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(null));f.Pc=94;continue;}
case 94:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","lastCardArtOptimisationOptionUsed","Ljava/lang/Boolean;",value);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","includeCardsFromUnspecifiedSet","Z",value);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("")));f.Pc=105;continue;}
case 105:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","sleeveArtKey","Ljava/lang/String;",value);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(JValue.I(500));f.Pc=112;continue;}
case 112:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","sleeveArtOffset","I",value);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(null));f.Pc=117;continue;}
case 117:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","unplayableAI","Lforge/deck/Deck$UnplayableAICards;",value);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/deck/Deck","getOrCreate","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",127);}
case 127:{f.StackOp("pop");f.Pc=128;continue;}
case 128:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1328(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/Deck","getName","()Ljava/lang/String;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/deck/Deck","<init>","(Lforge/deck/Deck;Ljava/lang/String;)V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1329(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/DeckBase","<init>","(Ljava/lang/String;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/util/EnumMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/EnumMap")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.ClassObject("forge/deck/DeckSection")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/EnumMap","<init>","(Ljava/lang/Class;)V","invokespecial",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"java/util/TreeSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeSet")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/TreeSet","<init>","(Ljava/util/Comparator;)V","invokespecial",29);}
case 29:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","tags","Ljava/util/Set;",value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"java/util/TreeSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeSet")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/TreeSet","<init>","()V","invokespecial",40);}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","aiHints","Ljava/util/Set;",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",51);}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","keyCards","Ljava/util/List;",value);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",62);}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","altCommanders","Ljava/util/List;",value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",73);}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","draftNotes","Ljava/util/Map;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(null));f.Pc=78;continue;}
case 78:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","deferredSections","Ljava/util/Map;",value);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(null));f.Pc=83;continue;}
case 83:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","loadedSections","Ljava/util/Map;",value);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("")));f.Pc=89;continue;}
case 89:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","lastCardArtPreferenceUsed","Ljava/lang/String;",value);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(null));f.Pc=94;continue;}
case 94:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","lastCardArtOptimisationOptionUsed","Ljava/lang/Boolean;",value);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","includeCardsFromUnspecifiedSet","Z",value);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("")));f.Pc=105;continue;}
case 105:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","sleeveArtKey","Ljava/lang/String;",value);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(JValue.I(500));f.Pc=112;continue;}
case 112:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","sleeveArtOffset","I",value);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(null));f.Pc=117;continue;}
case 117:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","unplayableAI","Lforge/deck/Deck$UnplayableAICards;",value);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/deck/Deck","cloneFieldsTo","(Lforge/deck/DeckBase;)V","invokevirtual",125);}
case 125:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1330(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Deck")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1331(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/Deck","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1332(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/Deck","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1333(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/Deck","loadDeferredSections","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1334(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?156:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[4]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",58);}
case 58:{f.Locals[5]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",67);}
case 67:{f.Pc=f.Pop().Int==0?153:70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{f.Locals[6]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Reference==null?150:98;continue;}
case 98:{f.Push(f.Locals[6]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",105);}
case 105:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",111);}
case 111:{return rt.Call(f,"forge/card/CardRules","isUnsupported","()Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?150:117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[6]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",125);}
case 125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",133);}
case 133:{f.StackOp("pop");f.Pc=134;continue;}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[6]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",143);}
case 143:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/deck/CardPool","remove","(Lforge/item/InventoryItem;)Z","invokevirtual",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Pc=60;continue;}
case 153:{f.Pc=23;continue;}
case 156:{f.Push(f.Locals[0]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",161);}
case 161:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1335(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference!=null?18:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?63:32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Pc=23;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",69);}
case 69:{f.Push(JValue.I(1));f.Pc=70;continue;}
case 70:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?87:73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.DynamicCall(f,"forge/deck/Deck:1335:74:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",79);}
case 79:{return rt.Call(f,"java/util/Comparator","comparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokestatic",82);}
case 82:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",87);}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1336(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference!=null?14:12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?66:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/card/CardRules","canBeOathbreaker","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?63:60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return JStep.Return(f.Pop());}
case 63:{f.Pc=19;continue;}
case 66:{f.Push(JValue.R(null));f.Pc=67;continue;}
case 67:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1337(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference!=null?14:12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?66:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/card/CardRules","canBeSignatureSpell","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?63:60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return JStep.Return(f.Pop());}
case 63:{f.Pc=19;continue;}
case 66:{f.Push(JValue.R(null));f.Pc=67;continue;}
case 67:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1338(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/Deck","loadDeferredSections","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",14);}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1339(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference==null?21:10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/deck/CardPool","isEmpty","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1340(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?122:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[5]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",52);}
case 52:{f.Locals[6]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",61);}
case 61:{f.Pc=f.Pop().Int==0?119:64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{f.Locals[7]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[7]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",89);}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?116:96;continue;}
case 96:{f.Push(f.Locals[7]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{f.Locals[2]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[5]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/deck/CardPool","remove","(Lforge/item/InventoryItem;)Z","invokevirtual",113);}
case 113:{f.StackOp("pop");f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{return JStep.Return(f.Pop());}
case 116:{f.Pc=54;continue;}
case 119:{f.Pc=15;continue;}
case 122:{f.Push(JValue.R(null));f.Pc=123;continue;}
case 123:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1341(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?37:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/deck/CardPool","contains","(Lforge/item/InventoryItem;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?37:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/deck/CardPool","remove","(Lforge/item/InventoryItem;)Z","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{return JStep.ReturnVoid;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",46);}
case 46:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",51);}
case 51:{f.Locals[2]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",58);}
case 58:{f.Pc=f.Pop().Int==0?89:61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Locals[3]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/deck/CardPool","contains","(Lforge/item/InventoryItem;)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int==0?86:79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/deck/CardPool","remove","(Lforge/item/InventoryItem;)Z","invokevirtual",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{return JStep.ReturnVoid;}
case 86:{f.Pc=52;continue;}
case 89:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1342(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference==null?12:10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1343(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1344(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","deferredSections","Ljava/util/Map;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1345(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/DeckBase","cloneFieldsTo","(Lforge/deck/DeckBase;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/deck/Deck","loadDeferredSections","()V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Reference==null?105:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",30);}
case 30:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",35);}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?105:45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=59;continue;}
case 59:{f.StackOp("dup");f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",63);}
case 63:{f.Locals[5]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckSection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",96);}
case 96:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/deck/CardPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",102);}
case 102:{f.Pc=36;continue;}
case 105:{f.Push(f.Locals[2]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","aiHints","Ljava/util/Set;"));f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String(" | ")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",115);}
case 115:{return rt.Call(f,"forge/deck/Deck","setAiHints","(Ljava/lang/String;)V","invokevirtual",118);}
case 118:{f.Push(f.Locals[2]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","draftNotes","Ljava/util/Map;"));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/deck/Deck","setDraftNotes","(Ljava/util/Map;)V","invokevirtual",126);}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","deckFormat","Lforge/deck/DeckFormat;"));f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/deck/Deck","setDeckFormat","(Lforge/deck/DeckFormat;)V","invokevirtual",134);}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","sourceUrl","Ljava/lang/String;"));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/deck/Deck","setSourceUrl","(Ljava/lang/String;)V","invokevirtual",142);}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","tags","Ljava/util/Set;"));f.Pc=146;continue;}
case 146:{f.Pc=f.Pop().Reference==null?163:149;continue;}
case 149:{f.Push(f.Locals[2]);f.Pc=150;continue;}
case 150:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","tags","Ljava/util/Set;"));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","tags","Ljava/util/Set;"));f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",162);}
case 162:{f.StackOp("pop");f.Pc=163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","keyCards","Ljava/util/List;"));f.Pc=167;continue;}
case 167:{f.Pc=f.Pop().Reference==null?184:170;continue;}
case 170:{f.Push(f.Locals[2]);f.Pc=171;continue;}
case 171:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","keyCards","Ljava/util/List;"));f.Pc=174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","keyCards","Ljava/util/List;"));f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",183);}
case 183:{f.StackOp("pop");f.Pc=184;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","altCommanders","Ljava/util/List;"));f.Pc=188;continue;}
case 188:{f.Pc=f.Pop().Reference==null?205:191;continue;}
case 191:{f.Push(f.Locals[2]);f.Pc=192;continue;}
case 192:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","altCommanders","Ljava/util/List;"));f.Pc=195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","altCommanders","Ljava/util/List;"));f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",204);}
case 204:{f.StackOp("pop");f.Pc=205;continue;}
case 205:{f.Push(f.Locals[2]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[0]);f.Pc=207;continue;}
case 207:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","sleeveArtKey","Ljava/lang/String;"));f.Pc=210;continue;}
case 210:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","sleeveArtKey","Ljava/lang/String;",value);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[2]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[0]);f.Pc=215;continue;}
case 215:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","sleeveArtOffset","I"));f.Pc=218;continue;}
case 218:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","sleeveArtOffset","I",value);f.Pc=221;continue;}
case 221:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1346(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/Deck"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/Deck")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/Deck","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1347(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","deferredSections","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","loadedSections","Ljava/util/Map;"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference!=null?15:14;continue;}
case 14:{return JStep.ReturnVoid;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","loadedSections","Ljava/util/Map;"));f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Reference==null?30:22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","includeCardsFromUnspecifiedSet","Z"));f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Int!=0?30:29;continue;}
case 29:{return JStep.ReturnVoid;}
case 30:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",33);}
case 33:{return rt.Call(f,"forge/StaticData","getCardArtPreferenceName","()Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Locals[1]=f.Pop();f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",40);}
case 40:{return rt.Call(f,"forge/StaticData","isEnabledCardArtSmartSelection","()Z","invokevirtual",43);}
case 43:{f.Locals[2]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","lastCardArtOptimisationOptionUsed","Ljava/lang/Boolean;"));f.Pc=48;continue;}
case 48:{f.Pc=f.Pop().Reference!=null?59:51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",56);}
case 56:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","lastCardArtOptimisationOptionUsed","Ljava/lang/Boolean;",value);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","loadedSections","Ljava/util/Map;"));f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Reference==null?89:66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","lastCardArtPreferenceUsed","Ljava/lang/String;"));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?89:77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","lastCardArtOptimisationOptionUsed","Ljava/lang/Boolean;"));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",84);}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?89:88;continue;}
case 88:{return JStep.ReturnVoid;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","deferredSections","Ljava/util/Map;"));f.Pc=93;continue;}
case 93:{f.Pc=f.Pop().Reference==null?123:96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","deferredSections","Ljava/util/Map;"));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/deck/Deck","getNamesToKeepWithNoEdition","(Ljava/util/Map;)Ljava/util/Set;","invokevirtual",105);}
case 105:{return rt.Call(f,"forge/deck/Deck","normalizeDeferredSections","(Ljava/util/Set;)V","invokevirtual",108);}
case 108:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","deferredSections","Ljava/util/Map;"));f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/HashMap","<init>","(Ljava/util/Map;)V","invokespecial",119);}
case 119:{f.Locals[3]=f.Pop();f.Pc=120;continue;}
case 120:{f.Pc=135;continue;}
case 123:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=126;continue;}
case 126:{f.StackOp("dup");f.Pc=127;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","loadedSections","Ljava/util/Map;"));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/HashMap","<init>","(Ljava/util/Map;)V","invokespecial",134);}
case 134:{f.Locals[3]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=139;continue;}
case 139:{f.StackOp("dup");f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",143);}
case 143:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","loadedSections","Ljava/util/Map;",value);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","lastCardArtPreferenceUsed","Ljava/lang/String;",value);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[2]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",156);}
case 156:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","lastCardArtOptimisationOptionUsed","Ljava/lang/Boolean;",value);f.Pc=159;continue;}
case 159:{f.Push(JValue.R(null));f.Pc=160;continue;}
case 160:{f.Locals[4]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[2]);f.Pc=163;continue;}
case 163:{f.Pc=f.Pop().Int==0?177:166;continue;}
case 166:{if(!rt.EnsureInitialized(f,"java/util/EnumMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/EnumMap")));f.Pc=169;continue;}
case 169:{f.StackOp("dup");f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.ClassObject("forge/deck/DeckSection")));f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/util/EnumMap","<init>","(Ljava/lang/Class;)V","invokespecial",175);}
case 175:{f.Locals[4]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[3]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",183);}
case 183:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",188);}
case 188:{f.Locals[5]=f.Pop();f.Pc=190;continue;}
case 190:{f.Push(f.Locals[5]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",197);}
case 197:{f.Pc=f.Pop().Int==0?332:200;continue;}
case 200:{f.Push(f.Locals[5]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",207);}
case 207:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=210;continue;}
case 210:{f.Locals[6]=f.Pop();f.Pc=212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","loadedSections","Ljava/util/Map;"));f.Pc=216;continue;}
case 216:{f.Push(f.Locals[6]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",223);}
case 223:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[6]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",233);}
case 233:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",241);}
case 241:{f.StackOp("pop");f.Pc=242;continue;}
case 242:{f.Push(f.Locals[6]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",249);}
case 249:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/deck/DeckSection","smartValueOf","(Ljava/lang/String;)Lforge/deck/DeckSection;","invokestatic",255);}
case 255:{f.Locals[7]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[7]);f.Pc=259;continue;}
case 259:{f.Pc=f.Pop().Reference!=null?265:262;continue;}
case 262:{f.Pc=190;continue;}
case 265:{f.Push(f.Locals[6]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",272);}
case 272:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=275;continue;}
case 275:{f.Locals[8]=f.Pop();f.Pc=277;continue;}
case 277:{f.Push(f.Locals[0]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[8]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/deck/Deck","getAllCardNamesWithNoSpecifiedEdition","(Ljava/util/List;)Ljava/util/ArrayList;","invokevirtual",283);}
case 283:{f.Locals[9]=f.Pop();f.Pc=285;continue;}
case 285:{f.Push(f.Locals[9]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"java/util/ArrayList","isEmpty","()Z","invokevirtual",290);}
case 290:{f.Pc=f.Pop().Int!=0?314:293;continue;}
case 293:{f.Push(f.Locals[0]);f.Pc=294;continue;}
case 294:{f.Push(JValue.I(1));f.Pc=295;continue;}
case 295:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","includeCardsFromUnspecifiedSet","Z",value);f.Pc=298;continue;}
case 298:{f.Push(f.Locals[2]);f.Pc=299;continue;}
case 299:{f.Pc=f.Pop().Int==0?314:302;continue;}
case 302:{f.Push(f.Locals[4]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[7]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[9]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",313);}
case 313:{f.StackOp("pop");f.Pc=314;continue;}
case 314:{f.Push(f.Locals[8]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/deck/CardPool","fromCardList","(Ljava/lang/Iterable;)Lforge/deck/CardPool;","invokestatic",319);}
case 319:{f.Locals[10]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[0]);f.Pc=322;continue;}
case 322:{f.Push(f.Locals[7]);f.Pc=324;continue;}
case 324:{f.Push(f.Locals[10]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/deck/Deck","putSection","(Lforge/deck/DeckSection;Lforge/deck/CardPool;)V","invokevirtual",329);}
case 329:{f.Pc=190;continue;}
case 332:{f.Push(f.Locals[0]);f.Pc=333;continue;}
case 333:{f.Push(JValue.R(null));f.Pc=334;continue;}
case 334:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","deferredSections","Ljava/util/Map;",value);f.Pc=337;continue;}
case 337:{f.Push(f.Locals[0]);f.Pc=338;continue;}
case 338:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","includeCardsFromUnspecifiedSet","Z"));f.Pc=341;continue;}
case 341:{f.Pc=f.Pop().Int==0?354:344;continue;}
case 344:{f.Push(f.Locals[2]);f.Pc=345;continue;}
case 345:{f.Pc=f.Pop().Int==0?354:348;continue;}
case 348:{f.Push(f.Locals[0]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[4]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/deck/Deck","optimiseCardArtSelectionInDeckSections","(Ljava/util/Map;)V","invokevirtual",354);}
case 354:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1348(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",22);}
case 22:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",27);}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int==0?166:39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[5]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/deck/DeckSection","smartValueOf","(Ljava/lang/String;)Lforge/deck/DeckSection;","invokestatic",64);}
case 64:{f.Pc=f.Pop().Reference!=null?70:67;continue;}
case 67:{f.Pc=29;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/deck/CardPool","processCardList","(Ljava/lang/Iterable;)Ljava/util/List;","invokestatic",83);}
case 83:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",88);}
case 88:{f.Locals[6]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",97);}
case 97:{f.Pc=f.Pop().Int==0?163:100;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",107);}
case 107:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=110;continue;}
case 110:{f.Locals[7]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[7]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",117);}
case 117:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",123);}
case 123:{f.Locals[8]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[8]);f.Pc=127;continue;}
case 127:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","edition","Ljava/lang/String;"));f.Pc=130;continue;}
case 130:{f.Pc=f.Pop().Reference!=null?148:133;continue;}
case 133:{f.Push(f.Locals[2]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[8]);f.Pc=136;continue;}
case 136:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",144);}
case 144:{f.StackOp("pop");f.Pc=145;continue;}
case 145:{f.Pc=160;continue;}
case 148:{f.Push(f.Locals[3]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[8]);f.Pc=151;continue;}
case 151:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",159);}
case 159:{f.StackOp("pop");f.Pc=160;continue;}
case 160:{f.Pc=90;continue;}
case 163:{f.Pc=29;continue;}
case 166:{f.Push(f.Locals[2]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[3]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/util/Set","removeAll","(Ljava/util/Collection;)Z","invokeinterface",173);}
case 173:{f.StackOp("pop");f.Pc=174;continue;}
case 174:{f.Push(f.Locals[2]);f.Pc=175;continue;}
case 175:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1349(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/TreeMap","<init>","(Ljava/util/Comparator;)V","invokespecial",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","deferredSections","Ljava/util/Map;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",20);}
case 20:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?312:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/deck/DeckSection","smartValueOf","(Ljava/lang/String;)Lforge/deck/DeckSection;","invokestatic",59);}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Reference!=null?96:66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",84);}
case 84:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",92);}
case 92:{f.StackOp("pop");f.Pc=93;continue;}
case 93:{f.Pc=26;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{f.Locals[6]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[6]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/deck/CardPool","fromCardList","(Ljava/lang/Iterable;)Lforge/deck/CardPool;","invokestatic",113);}
case 113:{f.Locals[7]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[7]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/deck/CardPool","countDistinct","()I","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int!=0?126:123;continue;}
case 123:{f.Pc=26;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[4]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",134);}
case 134:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=137;continue;}
case 137:{return rt.DynamicCall(f,"forge/deck/Deck:1349:137:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",142);}
case 142:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",147);}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{f.Locals[8]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[7]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",157);}
case 157:{f.Locals[9]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[9]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",166);}
case 166:{f.Pc=f.Pop().Int==0?309:169;continue;}
case 169:{f.Push(f.Locals[9]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",176);}
case 176:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=179;continue;}
case 179:{f.Locals[10]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[10]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",188);}
case 188:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=191;continue;}
case 191:{f.Locals[11]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(f.Locals[0]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[10]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/deck/Deck","getPoolRequest","(Ljava/util/Map$Entry;Ljava/util/Set;)Ljava/lang/String;","invokevirtual",200);}
case 200:{f.Locals[12]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[5]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[11]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",209);}
case 209:{f.Pc=f.Pop().Int!=0?231:212;continue;}
case 212:{f.Push(f.Locals[5]);f.Pc=214;continue;}
case 214:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=217;continue;}
case 217:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?244:220;continue;}
case 220:{f.Push(f.Locals[11]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",225);}
case 225:{return rt.Call(f,"forge/card/CardRules","canBeCreature","()Z","invokevirtual",228);}
case 228:{f.Pc=f.Pop().Int==0?244:231;continue;}
case 231:{f.Push(f.Locals[8]);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[12]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",240);}
case 240:{f.StackOp("pop");f.Pc=241;continue;}
case 241:{f.Pc=306;continue;}
case 244:{f.Push(f.Locals[11]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/deck/DeckSection","matchingSection","(Lforge/item/PaperCard;)Lforge/deck/DeckSection;","invokestatic",249);}
case 249:{f.Locals[13]=f.Pop();f.Pc=251;continue;}
case 251:{if(!rt.StaticReady(f,"forge/deck/Deck","$assertionsDisabled","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/Deck","$assertionsDisabled","Z"));f.Pc=254;continue;}
case 254:{f.Pc=f.Pop().Int!=0?275:257;continue;}
case 257:{f.Push(f.Locals[13]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[11]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",264);}
case 264:{f.Pc=f.Pop().Int!=0?275:267;continue;}
case 267:{if(!rt.EnsureInitialized(f,"java/lang/AssertionError"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/AssertionError")));f.Pc=270;continue;}
case 270:{f.StackOp("dup");f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/lang/AssertionError","<init>","()V","invokespecial",274);}
case 274:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 275:{f.Push(f.Locals[2]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[13]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/deck/DeckSection","name","()Ljava/lang/String;","invokevirtual",281);}
case 281:{return rt.DynamicCall(f,"forge/deck/Deck:1349:281:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",286);}
case 286:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",291);}
case 291:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=294;continue;}
case 294:{f.Locals[14]=f.Pop();f.Pc=296;continue;}
case 296:{f.Push(f.Locals[14]);f.Pc=298;continue;}
case 298:{f.Push(f.Locals[12]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",305);}
case 305:{f.StackOp("pop");f.Pc=306;continue;}
case 306:{f.Pc=159;continue;}
case 309:{f.Pc=26;continue;}
case 312:{f.Push(f.Locals[0]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[2]);f.Pc=314;continue;}
case 314:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","deferredSections","Ljava/util/Map;",value);f.Pc=317;continue;}
case 317:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1350(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",19);}
case 19:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=22;continue;}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",30);}
case 30:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?88:38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/item/PaperCard","getMarkedFlags","()Lforge/item/PaperCard$PaperCardFlags;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/item/PaperCard$PaperCardFlags","toMap","()Ljava/util/Map;","invokevirtual",46);}
case 46:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int==0?88:54;continue;}
case 54:{f.Push(JValue.R(rt.String("%d %s")));f.Pc=57;continue;}
case 57:{f.Push(JValue.I(2));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=61;continue;}
case 61:{f.StackOp("dup");f.Pc=62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",67);}
case 67:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.I(1));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",75);}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/item/PaperCard","isFoil","()Z","invokevirtual",80);}
case 80:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",83);}
case 83:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",87);}
case 87:{return JStep.Return(f.Pop());}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Lforge/item/PaperCard;)Ljava/lang/String;","invokestatic",93);}
case 93:{f.Locals[5]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("%d %s")));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(2));f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=102;continue;}
case 102:{f.StackOp("dup");f.Pc=103;continue;}
case 103:{f.Push(JValue.I(0));f.Pc=104;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",108);}
case 108:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.I(1));f.Pc=111;continue;}
case 111:{f.Push(f.Locals[5]);f.Pc=113;continue;}
case 113:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",117);}
case 117:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1351(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/CardPool","processCardList","(Ljava/lang/Iterable;)Ljava/util/List;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?81:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[6]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",58);}
case 58:{f.Locals[7]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[7]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","edition","Ljava/lang/String;"));f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Reference!=null?78:68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[7]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{f.Pc=21;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1352(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","isEnabledCardArtSmartSelection","()Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?10:9;continue;}
case 9:{return JStep.ReturnVoid;}
case 10:{if(!rt.EnsureInitialized(f,"java/util/EnumMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/EnumMap")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.ClassObject("forge/deck/DeckSection")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/EnumMap","<init>","(Ljava/lang/Class;)V","invokespecial",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",29);}
case 29:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?153:44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",62);}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",77);}
case 77:{f.Locals[6]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",86);}
case 86:{f.Pc=f.Pop().Int==0?123:89;continue;}
case 89:{f.Push(f.Locals[6]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",96);}
case 96:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=99;continue;}
case 99:{f.Locals[7]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[7]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",110);}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",116);}
case 116:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",119);}
case 119:{f.StackOp("pop");f.Pc=120;continue;}
case 120:{f.Pc=79;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/ArrayList","isEmpty","()Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int!=0?150:131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[4]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckSection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[5]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Pc=35;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[2]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/deck/Deck","optimiseCardArtSelectionInDeckSections","(Ljava/util/Map;Ljava/util/List;)V","invokevirtual",159);}
case 159:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1353(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/Deck","optimiseCardArtSelectionInDeckSections","(Ljava/util/Map;Ljava/util/List;)V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1354(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/StaticData","cardArtPreferenceIsLatest","()Z","invokevirtual",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/StaticData","isCoreExpansionOnlyFilterSet","()Z","invokevirtual",14);}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Reference==null?56:31;continue;}
case 31:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/deck/CardPool","<init>","(Ljava/lang/Iterable;)V","invokespecial",53);}
case 53:{f.Pc=57;continue;}
case 56:{f.Push(JValue.R(null));f.Pc=57;continue;}
case 57:{f.Locals[6]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",68);}
case 68:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",73);}
case 73:{f.Locals[7]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",82);}
case 82:{f.Pc=f.Pop().Int==0?530:85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",92);}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{f.Locals[8]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[8]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckSection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[9]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[9]);f.Pc=111;continue;}
case 111:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=114;continue;}
case 114:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?136:117;continue;}
case 117:{f.Push(f.Locals[9]);f.Pc=119;continue;}
case 119:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=122;continue;}
case 122:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?136:125;continue;}
case 125:{f.Push(f.Locals[9]);f.Pc=127;continue;}
case 127:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=130;continue;}
case 130:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?136:133;continue;}
case 133:{f.Pc=75;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[9]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(null));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",145);}
case 145:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/ArrayList"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=148;continue;}
case 148:{f.Locals[10]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[10]);f.Pc=152;continue;}
case 152:{f.Pc=f.Pop().Reference==null?75:155;continue;}
case 155:{f.Push(f.Locals[10]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/ArrayList","size","()I","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int!=0?166:163;continue;}
case 163:{f.Pc=75;continue;}
case 166:{f.Push(f.Locals[8]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",173);}
case 173:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=176;continue;}
case 176:{f.Locals[11]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[11]);f.Pc=180;continue;}
case 180:{f.Locals[12]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[9]);f.Pc=184;continue;}
case 184:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=187;continue;}
case 187:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?209:190;continue;}
case 190:{f.Push(f.Locals[6]);f.Pc=192;continue;}
case 192:{f.Pc=f.Pop().Reference==null?209:195;continue;}
case 195:{f.Push(f.Locals[6]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[4]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/deck/CardPool","getPivotCardEdition","(Z)Lforge/card/CardEdition;","invokevirtual",202);}
case 202:{f.Pc=f.Pop().Reference==null?209:205;continue;}
case 205:{f.Push(f.Locals[6]);f.Pc=207;continue;}
case 207:{f.Locals[12]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[12]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/deck/CardPool","getTheMostFrequentEditionType","()Lforge/card/CardEdition$Type;","invokevirtual",214);}
case 214:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"));f.Pc=217;continue;}
case 217:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?224:220;continue;}
case 220:{f.Push(JValue.I(1));f.Pc=221;continue;}
case 221:{f.Pc=225;continue;}
case 224:{f.Push(JValue.I(0));f.Pc=225;continue;}
case 225:{f.Locals[13]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[12]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/deck/CardPool","isModern","()Z","invokevirtual",232);}
case 232:{f.Locals[14]=f.Pop();f.Pc=234;continue;}
case 234:{f.Push(f.Locals[3]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/StaticData","cardArtPreferenceIsBlackBorder","()Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int==0?247:241;continue;}
case 241:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"));f.Pc=244;continue;}
case 244:{f.Pc=252;continue;}
case 247:{f.Push(f.Locals[12]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/deck/CardPool","getDominantBorderColor","()Lforge/card/CardEdition$BorderColor;","invokevirtual",252);}
case 252:{f.Locals[15]=f.Pop();f.Pc=254;continue;}
case 254:{f.Push(f.Locals[12]);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[4]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/deck/CardPool","getPivotCardEdition","(Z)Lforge/card/CardEdition;","invokevirtual",261);}
case 261:{f.Locals[16]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(f.Locals[16]);f.Pc=265;continue;}
case 265:{f.Pc=f.Pop().Reference!=null?271:268;continue;}
case 268:{f.Pc=75;continue;}
case 271:{f.Push(f.Locals[16]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",276);}
case 276:{f.Locals[17]=f.Pop();f.Pc=278;continue;}
case 278:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=281;continue;}
case 281:{f.StackOp("dup");f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",285);}
case 285:{f.Locals[18]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[11]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",292);}
case 292:{f.Locals[19]=f.Pop();f.Pc=294;continue;}
case 294:{f.Push(f.Locals[19]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",301);}
case 301:{f.Pc=f.Pop().Int==0?513:304;continue;}
case 304:{f.Push(f.Locals[19]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",311);}
case 311:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=314;continue;}
case 314:{f.Locals[20]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[20]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",323);}
case 323:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=326;continue;}
case 326:{f.Locals[21]=f.Pop();f.Pc=328;continue;}
case 328:{f.Push(f.Locals[20]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",335);}
case 335:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=338;continue;}
case 338:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",341);}
case 341:{f.Locals[22]=f.Pop();f.Pc=343;continue;}
case 343:{f.Push(f.Locals[10]);f.Pc=345;continue;}
case 345:{f.Push(f.Locals[21]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",350);}
case 350:{return rt.Call(f,"java/util/ArrayList","contains","(Ljava/lang/Object;)Z","invokevirtual",353);}
case 353:{f.Pc=f.Pop().Int!=0?374:356;continue;}
case 356:{f.Push(f.Locals[0]);f.Pc=357;continue;}
case 357:{f.Push(f.Locals[18]);f.Pc=359;continue;}
case 359:{f.Push(f.Locals[21]);f.Pc=361;continue;}
case 361:{f.Push(f.Locals[22]);f.Pc=363;continue;}
case 363:{f.Push(f.Locals[21]);f.Pc=365;continue;}
case 365:{return rt.Call(f,"forge/item/PaperCard","isFoil","()Z","invokevirtual",368);}
case 368:{return rt.Call(f,"forge/deck/Deck","addCardToPool","(Lforge/deck/CardPool;Lforge/item/PaperCard;IZ)V","invokevirtual",371);}
case 371:{f.Pc=294;continue;}
case 374:{f.Push(f.Locals[0]);f.Pc=375;continue;}
case 375:{f.Push(f.Locals[21]);f.Pc=377;continue;}
case 377:{f.Push(f.Locals[17]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/deck/Deck","isCardArtUpdateRequired","(Lforge/item/PaperCard;Ljava/util/Date;)Z","invokevirtual",382);}
case 382:{f.Pc=f.Pop().Int!=0?421:385;continue;}
case 385:{f.Push(f.Locals[21]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",390);}
case 390:{return rt.Call(f,"forge/card/CardRules","isVariant","()Z","invokevirtual",393);}
case 393:{f.Pc=f.Pop().Int!=0?425:396;continue;}
case 396:{f.Push(f.Locals[3]);f.Pc=397;continue;}
case 397:{f.Push(f.Locals[21]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[15]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/StaticData","hasBorderMismatch","(Lforge/item/PaperCard;Lforge/card/CardEdition$BorderColor;)Z","invokevirtual",404);}
case 404:{f.Pc=f.Pop().Int!=0?421:407;continue;}
case 407:{f.Push(f.Locals[21]);f.Pc=409;continue;}
case 409:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",412);}
case 412:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",415);}
case 415:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",418);}
case 418:{f.Pc=f.Pop().Int==0?425:421;continue;}
case 421:{f.Push(JValue.I(1));f.Pc=422;continue;}
case 422:{f.Pc=426;continue;}
case 425:{f.Push(JValue.I(0));f.Pc=426;continue;}
case 426:{f.Locals[23]=f.Pop();f.Pc=428;continue;}
case 428:{f.Push(f.Locals[23]);f.Pc=430;continue;}
case 430:{f.Pc=f.Pop().Int!=0?451:433;continue;}
case 433:{f.Push(f.Locals[0]);f.Pc=434;continue;}
case 434:{f.Push(f.Locals[18]);f.Pc=436;continue;}
case 436:{f.Push(f.Locals[21]);f.Pc=438;continue;}
case 438:{f.Push(f.Locals[22]);f.Pc=440;continue;}
case 440:{f.Push(f.Locals[21]);f.Pc=442;continue;}
case 442:{return rt.Call(f,"forge/item/PaperCard","isFoil","()Z","invokevirtual",445);}
case 445:{return rt.Call(f,"forge/deck/Deck","addCardToPool","(Lforge/deck/CardPool;Lforge/item/PaperCard;IZ)V","invokevirtual",448);}
case 448:{f.Pc=294;continue;}
case 451:{f.Push(f.Locals[3]);f.Pc=452;continue;}
case 452:{f.Push(f.Locals[21]);f.Pc=454;continue;}
case 454:{f.Push(f.Locals[17]);f.Pc=456;continue;}
case 456:{f.Push(f.Locals[4]);f.Pc=458;continue;}
case 458:{f.Push(f.Locals[5]);f.Pc=460;continue;}
case 460:{f.Push(f.Locals[13]);f.Pc=462;continue;}
case 462:{f.Push(f.Locals[14]);f.Pc=464;continue;}
case 464:{f.Push(f.Locals[2]);f.Pc=465;continue;}
case 465:{f.Push(f.Locals[15]);f.Pc=467;continue;}
case 467:{return rt.Call(f,"forge/StaticData","getAlternativeCardPrint","(Lforge/item/PaperCard;Ljava/util/Date;ZZZZLjava/util/List;Lforge/card/CardEdition$BorderColor;)Lforge/item/PaperCard;","invokevirtual",470);}
case 470:{f.Locals[24]=f.Pop();f.Pc=472;continue;}
case 472:{f.Push(f.Locals[24]);f.Pc=474;continue;}
case 474:{f.Pc=f.Pop().Reference!=null?495:477;continue;}
case 477:{f.Push(f.Locals[0]);f.Pc=478;continue;}
case 478:{f.Push(f.Locals[18]);f.Pc=480;continue;}
case 480:{f.Push(f.Locals[21]);f.Pc=482;continue;}
case 482:{f.Push(f.Locals[22]);f.Pc=484;continue;}
case 484:{f.Push(f.Locals[21]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/item/PaperCard","isFoil","()Z","invokevirtual",489);}
case 489:{return rt.Call(f,"forge/deck/Deck","addCardToPool","(Lforge/deck/CardPool;Lforge/item/PaperCard;IZ)V","invokevirtual",492);}
case 492:{f.Pc=510;continue;}
case 495:{f.Push(f.Locals[0]);f.Pc=496;continue;}
case 496:{f.Push(f.Locals[18]);f.Pc=498;continue;}
case 498:{f.Push(f.Locals[24]);f.Pc=500;continue;}
case 500:{f.Push(f.Locals[22]);f.Pc=502;continue;}
case 502:{f.Push(f.Locals[21]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/item/PaperCard","isFoil","()Z","invokevirtual",507);}
case 507:{return rt.Call(f,"forge/deck/Deck","addCardToPool","(Lforge/deck/CardPool;Lforge/item/PaperCard;IZ)V","invokevirtual",510);}
case 510:{f.Pc=294;continue;}
case 513:{f.Push(f.Locals[0]);f.Pc=514;continue;}
case 514:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=517;continue;}
case 517:{f.Push(f.Locals[9]);f.Pc=519;continue;}
case 519:{f.Push(f.Locals[18]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",526);}
case 526:{f.StackOp("pop");f.Pc=527;continue;}
case 527:{f.Pc=75;continue;}
case 530:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1355(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{f.Locals[5]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",9);}
case 9:{f.Push(JValue.I(-1));f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?42:13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",17);}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?42:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int==0?34:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",31);}
case 31:{f.Pc=35;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",39);}
case 39:{f.Pc=264;continue;}
case 42:{f.Push(f.Locals[5]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",47);}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/CardDb","getTraditionalFramePrints","(Lforge/item/PaperCard;)Ljava/util/List;","invokevirtual",51);}
case 51:{f.Locals[6]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",60);}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?135:64;continue;}
case 64:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",71);}
case 71:{f.Locals[7]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",80);}
case 80:{f.Locals[8]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[8]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",89);}
case 89:{f.Pc=f.Pop().Int==0?123:92;continue;}
case 92:{f.Push(f.Locals[8]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{f.Locals[9]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[9]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",111);}
case 111:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",114);}
case 114:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",119);}
case 119:{f.StackOp("pop");f.Pc=120;continue;}
case 120:{f.Pc=82;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[2]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[7]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/deck/Deck","addAlternativeCardPrintInPoolWithMultipleArt","(Lforge/item/PaperCard;Lforge/deck/CardPool;ILjava/util/List;)V","invokevirtual",132);}
case 132:{f.Pc=264;continue;}
case 135:{f.Push(f.Locals[6]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",142);}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?182:146;continue;}
case 146:{f.Push(f.Locals[6]);f.Pc=148;continue;}
case 148:{f.Push(JValue.I(0));f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",154);}
case 154:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=157;continue;}
case 157:{f.Locals[7]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[4]);f.Pc=162;continue;}
case 162:{f.Pc=f.Pop().Int==0?173:165;continue;}
case 165:{f.Push(f.Locals[7]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",170);}
case 170:{f.Pc=175;continue;}
case 173:{f.Push(f.Locals[7]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[3]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",179);}
case 179:{f.Pc=264;continue;}
case 182:{f.Push(f.Locals[5]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[2]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/StaticData","getCardArtCount","(Lforge/item/PaperCard;)I","invokevirtual",188);}
case 188:{f.Locals[7]=f.Pop();f.Pc=190;continue;}
case 190:{f.Push(f.Locals[7]);f.Pc=192;continue;}
case 192:{f.Push(JValue.I(1));f.Pc=193;continue;}
case 193:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?246:196;continue;}
case 196:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=199;continue;}
case 199:{f.StackOp("dup");f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",203);}
case 203:{f.Locals[8]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(JValue.I(1));f.Pc=206;continue;}
case 206:{f.Locals[9]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[9]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[7]);f.Pc=212;continue;}
case 212:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?234:215;continue;}
case 215:{f.Push(f.Locals[8]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[9]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",222);}
case 222:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",227);}
case 227:{f.StackOp("pop");f.Pc=228;continue;}
case 228:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=231;continue;}
case 231:{f.Pc=208;continue;}
case 234:{f.Push(f.Locals[0]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[2]);f.Pc=236;continue;}
case 236:{f.Push(f.Locals[1]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[3]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[8]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/deck/Deck","addAlternativeCardPrintInPoolWithMultipleArt","(Lforge/item/PaperCard;Lforge/deck/CardPool;ILjava/util/List;)V","invokevirtual",243);}
case 243:{f.Pc=264;continue;}
case 246:{f.Push(f.Locals[1]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[4]);f.Pc=249;continue;}
case 249:{f.Pc=f.Pop().Int==0?259:252;continue;}
case 252:{f.Push(f.Locals[2]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",256);}
case 256:{f.Pc=260;continue;}
case 259:{f.Push(f.Locals[2]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[3]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",264);}
case 264:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1356(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{f.Locals[5]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",12);}
case 12:{f.Locals[6]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Locals[7]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Locals[8]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/item/PaperCard","isFoil","()Z","invokevirtual",30);}
case 30:{f.Locals[9]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[6]);f.Pc=35;continue;}
case 35:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=36;continue;}
case 36:{f.Locals[10]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[10]);f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Int<=0?50:43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[6]);f.Pc=46;continue;}
case 46:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=47;continue;}
case 47:{f.Pc=51;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{f.Locals[11]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(JValue.I(1));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[10]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",59);}
case 59:{f.Locals[10]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{f.Locals[12]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(JValue.R(null));f.Pc=65;continue;}
case 65:{f.Locals[13]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",74);}
case 74:{f.Locals[14]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[14]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",83);}
case 83:{f.Pc=f.Pop().Int==0?143:86;continue;}
case 86:{f.Push(f.Locals[14]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",99);}
case 99:{f.Locals[15]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[7]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[8]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[15]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[9]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/StaticData","getOrLoadCommonCard","(Ljava/lang/String;Ljava/lang/String;IZ)Lforge/item/PaperCard;","invokevirtual",114);}
case 114:{f.Locals[13]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[12]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[10]);f.Pc=120;continue;}
case 120:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=121;continue;}
case 121:{f.Locals[12]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[13]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[10]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",131);}
case 131:{f.Push(f.Locals[12]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[3]);f.Pc=134;continue;}
case 134:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?140:137;continue;}
case 137:{f.Pc=143;continue;}
case 140:{f.Pc=76;continue;}
case 143:{f.Push(f.Locals[11]);f.Pc=145;continue;}
case 145:{f.Pc=f.Pop().Int<=0?156:148;continue;}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[13]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[11]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",156);}
case 156:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1357(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardRules","isVariant","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",15);}
case 15:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/card/CardDb","hasPreferredArt","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?63:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",35);}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","edition","Ljava/lang/String;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",44);}
case 44:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?63:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","artIndex","I"));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",58);}
case 58:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?63:61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 63:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",66);}
case 66:{return rt.Call(f,"forge/StaticData","cardArtPreferenceIsLatest","()Z","invokevirtual",69);}
case 69:{f.Locals[3]=f.Pop();f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",73);}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",77);}
case 77:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",80);}
case 80:{f.Locals[4]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{f.Pc=f.Pop().Reference!=null?89:87;continue;}
case 87:{f.Push(JValue.I(0));f.Pc=88;continue;}
case 88:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",94);}
case 94:{f.Locals[5]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[5]);f.Pc=98;continue;}
case 98:{f.Pc=f.Pop().Reference!=null?103:101;continue;}
case 101:{f.Push(JValue.I(0));f.Pc=102;continue;}
case 102:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{f.Pc=f.Pop().Int==0?122:107;continue;}
case 107:{f.Push(f.Locals[5]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Date","compareTo","(Ljava/util/Date;)I","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int<=0?120:116;continue;}
case 116:{f.Push(JValue.I(1));f.Pc=117;continue;}
case 117:{f.Pc=121;continue;}
case 120:{f.Push(JValue.I(0));f.Pc=121;continue;}
case 121:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 122:{f.Push(f.Locals[5]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[2]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/Date","compareTo","(Ljava/util/Date;)I","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int>=0?135:131;continue;}
case 131:{f.Push(JValue.I(1));f.Pc=132;continue;}
case 132:{f.Pc=136;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1358(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/Deck","loadDeferredSections","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",13);}
case 13:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1359(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","tags","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1360(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/Deck","getAllCardsInASinglePool","(ZZ)Lforge/deck/CardPool;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1361(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/CardPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/CardPool")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/CardPool","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/deck/CardPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?37:26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/deck/CardPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",37);}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Int==0?62:41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?62:51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",59);}
case 59:{return rt.Call(f,"forge/deck/CardPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",62);}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Int==0?118:66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/deck/DeckSection","NONTRADITIONAL_SECTIONS","[Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","NONTRADITIONAL_SECTIONS","[Lforge/deck/DeckSection;"));f.Pc=69;continue;}
case 69:{f.Locals[4]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=74;continue;}
case 74:{f.Locals[5]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{f.Locals[6]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?118:86;continue;}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=91;continue;}
case 91:{f.Locals[7]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[7]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/deck/Deck","has","(Lforge/deck/DeckSection;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int==0?112:102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",109);}
case 109:{return rt.Call(f,"forge/deck/CardPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",112);}
case 112:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=115;continue;}
case 115:{f.Pc=79;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1362(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/Deck","iterator","()Ljava/util/Iterator;","invokevirtual",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?47:16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/deck/CardPool","countByName","(Ljava/lang/String;)I","invokevirtual",42);}
case 42:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=43;continue;}
case 43:{f.Locals[2]=f.Pop();f.Pc=44;continue;}
case 44:{f.Pc=7;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1363(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/deck/Deck","iterator","()Ljava/util/Iterator;","invokevirtual",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?47:16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/deck/CardPool","count","(Lforge/item/InventoryItem;)I","invokevirtual",42);}
case 42:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=43;continue;}
case 43:{f.Locals[2]=f.Pop();f.Pc=44;continue;}
case 44:{f.Pc=7;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1364(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","sleeveArtKey","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?12:7;continue;}
case 7:{f.Push(JValue.R(rt.String("")));f.Pc=9;continue;}
case 9:{f.Pc=16;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","sleeveArtKey","Ljava/lang/String;"));f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1365(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Reference!=null?10:5;continue;}
case 5:{f.Push(JValue.R(rt.String("")));f.Pc=7;continue;}
case 7:{f.Pc=11;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","sleeveArtKey","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1366(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","sleeveArtOffset","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1367(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","sleeveArtOffset","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1368(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","keyCards","Ljava/util/List;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1369(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?43:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?43:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","keyCards","Ljava/util/List;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int!=0?43:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","keyCards","Ljava/util/List;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1370(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?18:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","keyCards","Ljava/util/List;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",17);}
case 17:{f.StackOp("pop");f.Pc=18;continue;}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1371(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","keyCards","Ljava/util/List;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",14);}
case 14:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",19);}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1372(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","altCommanders","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?17:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",14);}
case 14:{f.Pc=28;continue;}
case 17:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","altCommanders","Ljava/util/List;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",28);}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1373(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?43:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?43:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","altCommanders","Ljava/util/List;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int!=0?43:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","altCommanders","Ljava/util/List;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1374(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",11);}
case 11:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?83:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Reference==null?17:53;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?64:61;continue;}
case 61:{f.Pc=17;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","draftNotes","Ljava/util/Map;"));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",74);}
case 74:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Pc=17;continue;}
case 83:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1375(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","draftNotes","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1376(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","deckFormat","Lforge/deck/DeckFormat;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1377(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","deckFormat","Lforge/deck/DeckFormat;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1378(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","sourceUrl","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1379(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","sourceUrl","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1380(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?14:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?15:14;continue;}
case 14:{return JStep.ReturnVoid;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("\\|")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=27;continue;}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?66:39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=43;continue;}
case 43:{f.Locals[6]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","aiHints","Ljava/util/Set;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[6]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",54);}
case 54:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=63;continue;}
case 63:{f.Pc=32;continue;}
case 66:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1381(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","aiHints","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1382(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","aiHints","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?68:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",33);}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",37);}
case 37:{return rt.DynamicCall(f,"forge/deck/Deck:1382:37:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",42);}
case 42:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?65:48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("$")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",56);}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",61);}
case 61:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",64);}
case 64:{return JStep.Return(f.Pop());}
case 65:{f.Pc=10;continue;}
case 68:{f.Push(JValue.R(rt.String("")));f.Pc=70;continue;}
case 70:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1383(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?14:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?15:14;continue;}
case 14:{return JStep.ReturnVoid;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","aiHints","Ljava/util/Set;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.DynamicCall(f,"forge/deck/Deck:1383:20:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",25);}
case 25:{return rt.Call(f,"java/util/Set","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","aiHints","Ljava/util/Set;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",40);}
case 40:{return rt.DynamicCall(f,"forge/deck/Deck:1383:40:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",45);}
case 45:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1384(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","unplayableAI","Lforge/deck/Deck$UnplayableAICards;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?19:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/deck/Deck$UnplayableAICards"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/Deck$UnplayableAICards")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/deck/Deck$UnplayableAICards","<init>","(Lforge/deck/Deck;)V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck","unplayableAI","Lforge/deck/Deck$UnplayableAICards;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","unplayableAI","Lforge/deck/Deck$UnplayableAICards;"));f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1385(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/Deck","loadDeferredSections","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",13);}
case 13:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?50:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/deck/CardPool","isEmpty","()Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int!=0?47:45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 47:{f.Pc=19;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1386(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1387(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1388(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","tags","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?32:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"forge/deck/Deck"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/Deck")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/deck/Deck","getName","()Ljava/lang/String;","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Reference!=null?24:19;continue;}
case 19:{f.Push(JValue.R(rt.String("")));f.Pc=21;continue;}
case 21:{f.Pc=28;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/deck/Deck","getName","()Ljava/lang/String;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/deck/Deck","<init>","(Lforge/deck/Deck;Ljava/lang/String;)V","invokespecial",31);}
case 31:{return JStep.Return(f.Pop());}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1389(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/deck/DeckBase")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?185:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckBase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/deck/DeckBase","equals","(Ljava/lang/Object;)Z","invokespecial",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Int!=0?24:22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",39);}
case 39:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",44);}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",53);}
case 53:{f.Pc=f.Pop().Int==0?108:56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckSection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[6]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[6]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",75);}
case 75:{f.Locals[7]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=81;continue;}
case 81:{f.Push(f.Locals[6]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",88);}
case 88:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=91;continue;}
case 91:{f.Locals[8]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[8]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/deck/CardPool","equals","(Ljava/lang/Object;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int!=0?105:103;continue;}
case 103:{f.Push(JValue.I(0));f.Pc=104;continue;}
case 104:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 105:{f.Pc=46;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",118);}
case 118:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",123);}
case 123:{f.Locals[5]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[5]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",132);}
case 132:{f.Pc=f.Pop().Int==0?183:135;continue;}
case 135:{f.Push(f.Locals[5]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",142);}
case 142:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckSection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=145;continue;}
case 145:{f.Locals[6]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[4]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[6]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",154);}
case 154:{f.Locals[7]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[0]);f.Pc=157;continue;}
case 157:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck","parts","Ljava/util/Map;"));f.Pc=160;continue;}
case 160:{f.Push(f.Locals[6]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",167);}
case 167:{f.Pc=f.Pop().Int!=0?180:170;continue;}
case 170:{f.Push(f.Locals[7]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",175);}
case 175:{f.Pc=f.Pop().Int<=0?180:178;continue;}
case 178:{f.Push(JValue.I(0));f.Pc=179;continue;}
case 179:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 180:{f.Pc=125;continue;}
case 183:{f.Push(JValue.I(1));f.Pc=184;continue;}
case 184:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 185:{f.Push(JValue.I(0));f.Pc=186;continue;}
case 186:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1390(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/Deck","iterator","()Ljava/util/Iterator;","invokevirtual",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?210:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/deck/Deck$1","$SwitchMap$forge$deck$DeckSection","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/Deck$1","$SwitchMap$forge$deck$DeckSection","[I"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckSection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/deck/DeckSection","ordinal","()I","invokevirtual",45);}
case 45:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=46;continue;}
case 46:{switch(f.Pop().Int){case 1:f.Pc=72;break;case 2:f.Pc=72;break;default:f.Pc=207;break;}continue;}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",85);}
case 85:{f.Locals[5]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",94);}
case 94:{f.Pc=f.Pop().Int==0?204:97;continue;}
case 97:{f.Push(f.Locals[5]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[6]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[6]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",116);}
case 116:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",122);}
case 122:{f.Locals[7]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[7]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",129);}
case 129:{f.Locals[8]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[8]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/card/CardType","isLand","()Z","invokevirtual",136);}
case 136:{f.Pc=f.Pop().Int!=0?201:139;continue;}
case 139:{f.Push(f.Locals[8]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/card/CardType","isArtifact","()Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int!=0?187:147;continue;}
case 147:{f.Push(f.Locals[8]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",152);}
case 152:{f.Pc=f.Pop().Int!=0?187:155;continue;}
case 155:{f.Push(f.Locals[8]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/card/CardType","isEnchantment","()Z","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int!=0?187:163;continue;}
case 163:{f.Push(f.Locals[8]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/card/CardType","isPlaneswalker","()Z","invokevirtual",168);}
case 168:{f.Pc=f.Pop().Int!=0?187:171;continue;}
case 171:{f.Push(f.Locals[8]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/card/CardType","isInstant","()Z","invokevirtual",176);}
case 176:{f.Pc=f.Pop().Int!=0?187:179;continue;}
case 179:{f.Push(f.Locals[8]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/card/CardType","isSorcery","()Z","invokevirtual",184);}
case 184:{f.Pc=f.Pop().Int==0?201:187;continue;}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[7]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/card/CardRules","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",193);}
case 193:{return rt.Call(f,"forge/card/mana/ManaCost","getCMC","()I","invokevirtual",196);}
case 196:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=197;continue;}
case 197:{f.Locals[1]=f.Pop();f.Pc=198;continue;}
case 198:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=201;continue;}
case 201:{f.Pc=87;continue;}
case 204:{f.Pc=207;continue;}
case 207:{f.Pc=9;continue;}
case 210:{f.Push(f.Locals[2]);f.Pc=211;continue;}
case 211:{f.Pc=f.Pop().Int!=0?218:214;continue;}
case 214:{f.Push(JValue.I(0));f.Pc=215;continue;}
case 215:{f.Pc=225;continue;}
case 218:{f.Push(f.Locals[1]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[2]);f.Pc=220;continue;}
case 220:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=221;continue;}
case 221:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/lang/Math","round","(F)I","invokestatic",225);}
case 225:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1391(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/lang/System","lineSeparator","()Ljava/lang/String;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/deck/Deck","getName","()Ljava/lang/String;","invokevirtual",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("[Commander")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?37:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("Commander")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?40:37;continue;}
case 37:{f.Push(JValue.R(rt.String("")));f.Pc=39;continue;}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Reference!=null?50:45;continue;}
case 45:{f.Push(JValue.R(rt.String("")));f.Pc=47;continue;}
case 47:{f.Pc=58;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.DynamicCall(f,"forge/deck/Deck:1391:53:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",58);}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/deck/DeckSection","values","()[Lforge/deck/DeckSection;","invokestatic",65);}
case 65:{f.Locals[4]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=70;continue;}
case 70:{f.Locals[5]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(JValue.I(0));f.Pc=73;continue;}
case 73:{f.Locals[6]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[6]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?251:82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[6]);f.Pc=86;continue;}
case 86:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=87;continue;}
case 87:{f.Locals[7]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[7]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",95);}
case 95:{f.Locals[8]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[8]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Reference==null?245:102;continue;}
case 102:{f.Push(f.Locals[8]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/deck/CardPool","isEmpty","()Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?113:110;continue;}
case 110:{f.Pc=245;continue;}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[7]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/deck/DeckSection","toString","()Ljava/lang/String;","invokevirtual",119);}
case 119:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",122);}
case 122:{f.Push(JValue.R(rt.String(": ")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",128);}
case 128:{f.StackOp("pop");f.Pc=129;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",134);}
case 134:{f.StackOp("pop");f.Pc=135;continue;}
case 135:{f.Push(f.Locals[8]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/util/StreamUtil","stream","(Ljava/lang/Iterable;)Ljava/util/stream/Stream;","invokestatic",140);}
case 140:{return rt.DynamicCall(f,"forge/deck/Deck:1391:140:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",145);}
case 145:{return rt.DynamicCall(f,"forge/deck/Deck:1391:145:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",150);}
case 150:{return rt.DynamicCall(f,"forge/deck/Deck:1391:150:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",155);}
case 155:{return rt.Call(f,"java/util/stream/Collectors","summingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;","invokestatic",158);}
case 158:{return rt.Call(f,"java/util/stream/Collectors","groupingBy","(Ljava/util/function/Function;Ljava/util/function/Supplier;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;","invokestatic",161);}
case 161:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",166);}
case 166:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/TreeMap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/TreeMap","entrySet","()Ljava/util/Set;","invokevirtual",172);}
case 172:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",177);}
case 177:{f.Locals[9]=f.Pop();f.Pc=179;continue;}
case 179:{f.Push(f.Locals[9]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",186);}
case 186:{f.Pc=f.Pop().Int==0?239:189;continue;}
case 189:{f.Push(f.Locals[9]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",196);}
case 196:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=199;continue;}
case 199:{f.Locals[10]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[10]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",209);}
case 209:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",212);}
case 212:{f.Push(JValue.R(rt.String(" ")));f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",218);}
case 218:{f.Push(f.Locals[10]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",225);}
case 225:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",231);}
case 231:{f.Push(f.Locals[1]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",235);}
case 235:{f.StackOp("pop");f.Pc=236;continue;}
case 236:{f.Pc=179;continue;}
case 239:{f.Push(f.Locals[2]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[1]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",244);}
case 244:{f.StackOp("pop");f.Pc=245;continue;}
case 245:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=248;continue;}
case 248:{f.Pc=75;continue;}
case 251:{f.Push(f.Locals[2]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",255);}
case 255:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1392(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1393(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/item/PaperCard","getCardName","()Ljava/lang/String;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1394(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.DynamicCall(f,"forge/deck/Deck:1394:8:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",13);}
case 13:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1395(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1396(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1397(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardRules","canBeSignatureSpell","()Z","invokevirtual",7);}
case 7:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1398(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/deck/Deck")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/Class","desiredAssertionStatus","()Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int!=0?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/deck/Deck","$assertionsDisabled","Z"))return JStep.Continue;rt.PutStatic("forge/deck/Deck","$assertionsDisabled","Z",f.Pop());f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

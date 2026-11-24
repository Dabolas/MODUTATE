// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C10{
internal static JClass Build(){var c=new JClass("forge/StaticData","java/lang/Object",new string[]{},33);Add0(c);Add1(c);Add2(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cardReader","Lforge/CardStorageReader;",false,JValue.Default("Lforge/CardStorageReader;"),null));
c.Add(new JField("customCardReader","Lforge/CardStorageReader;",false,JValue.Default("Lforge/CardStorageReader;"),null));
c.Add(new JField("tokenReader","Lforge/CardStorageReader;",false,JValue.Default("Lforge/CardStorageReader;"),null));
c.Add(new JField("blockDataFolder","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("commonCards","Lforge/card/CardDb;",false,JValue.Default("Lforge/card/CardDb;"),null));
c.Add(new JField("variantCards","Lforge/card/CardDb;",false,JValue.Default("Lforge/card/CardDb;"),null));
c.Add(new JField("allTokens","Lforge/token/TokenDb;",false,JValue.Default("Lforge/token/TokenDb;"),null));
c.Add(new JField("editions","Lforge/card/CardEdition$Collection;",false,JValue.Default("Lforge/card/CardEdition$Collection;"),null));
c.Add(new JField("funnyCards","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("filtered","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("regularRules","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("variantRules","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("placeholderFacesInProgress","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("missingLazyCards","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("lazyLoadLock","Ljava/lang/Object;",false,JValue.Default("Ljava/lang/Object;"),null));
c.Add(new JField("lazyLoadDepth","I",false,JValue.Default("I"),null));
c.Add(new JField("allCardsLoaded","Z",false,JValue.Default("Z"),null));
c.Add(new JField("standardPredicate","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("brawlPredicate","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("pioneerPredicate","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("modernPredicate","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("commanderPredicate","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("oathbreakerPredicate","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("filteredHandsEnabled","Z",false,JValue.Default("Z"),null));
c.Add(new JField("mulliganRule","Lforge/MulliganDefs$MulliganRule;",false,JValue.Default("Lforge/MulliganDefs$MulliganRule;"),null));
c.Add(new JField("allowCustomCardsInDecksConformance","Z",false,JValue.Default("Z"),null));
c.Add(new JField("enableSmartCardArtSelection","Z",false,JValue.Default("Z"),null));
c.Add(new JField("loadNonLegalCards","Z",false,JValue.Default("Z"),null));
c.Add(new JField("enableUnknownCards","Z",false,JValue.Default("Z"),null));
c.Add(new JField("sourceImageForClone","Z",false,JValue.Default("Z"),null));
c.Add(new JField("boosters","Lforge/util/storage/IStorage;",false,JValue.Default("Lforge/util/storage/IStorage;"),null));
c.Add(new JField("specialBoosters","Lforge/util/storage/IStorage;",false,JValue.Default("Lforge/util/storage/IStorage;"),null));
c.Add(new JField("tournaments","Lforge/util/storage/IStorage;",false,JValue.Default("Lforge/util/storage/IStorage;"),null));
c.Add(new JField("fatPacks","Lforge/util/storage/IStorage;",false,JValue.Default("Lforge/util/storage/IStorage;"),null));
c.Add(new JField("boosterBoxes","Lforge/util/storage/IStorage;",false,JValue.Default("Lforge/util/storage/IStorage;"),null));
c.Add(new JField("printSheets","Lforge/util/storage/IStorage;",false,JValue.Default("Lforge/util/storage/IStorage;"),null));
c.Add(new JField("setLookup","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("lastInstance","Lforge/StaticData;",true,JValue.Default("Lforge/StaticData;"),null));
c.Add(new JField("sortedEditions","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("editionsTypeMap","Ljava/util/TreeMap;",false,JValue.Default("Ljava/util/TreeMap;"),null));
c.Add(new JField("MAX_BORDER_MATCH_DISTANCE_MS","J",true,JValue.L(126144000000L),null));
c.Add(new JMethod(81,"forge/StaticData","<init>","(Lforge/CardStorageReader;Lforge/CardStorageReader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)V",1,9,15,new JHandler[]{},M81));
c.Add(new JMethod(82,"forge/StaticData","<init>","(Lforge/CardStorageReader;Lforge/CardStorageReader;Lforge/CardStorageReader;Lforge/CardStorageReader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZZZ)V",1,14,15,new JHandler[]{},M82));
c.Add(new JMethod(83,"forge/StaticData","<init>","(Lforge/CardStorageReader;Lforge/CardStorageReader;Lforge/CardStorageReader;Lforge/CardStorageReader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZZZLjava/util/function/BiPredicate;)V",1,20,8,new JHandler[]{},M83));
c.Add(new JMethod(84,"forge/StaticData","instance","()Lforge/StaticData;",9,0,1,new JHandler[]{},M84));
c.Add(new JMethod(85,"forge/StaticData","getSetLookup","()Ljava/util/Map;",1,1,1,new JHandler[]{},M85));
c.Add(new JMethod(86,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;",17,1,1,new JHandler[]{},M86));
c.Add(new JMethod(87,"forge/StaticData","getSortedEditions","()Ljava/util/List;",17,3,3,new JHandler[]{},M87));
c.Add(new JMethod(88,"forge/StaticData","getEditionsTypeMap","()Ljava/util/Map;",17,5,4,new JHandler[]{},M88));
c.Add(new JMethod(89,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;",1,3,2,new JHandler[]{},M89));
c.Add(new JMethod(90,"forge/StaticData","getOrLoadCommonCard","(Ljava/lang/String;Ljava/lang/String;IZ)Lforge/item/PaperCard;",1,6,4,new JHandler[]{},M90));
c.Add(new JMethod(91,"forge/StaticData","getOrLoadCard","(Ljava/lang/String;Ljava/lang/String;IZ)Lforge/item/PaperCard;",1,9,4,new JHandler[]{},M91));
c.Add(new JMethod(92,"forge/StaticData","attemptToLoadCard","(Ljava/lang/String;)V",1,2,3,new JHandler[]{},M92));
c.Add(new JMethod(93,"forge/StaticData","ensureAllCardsLoaded","()V",1,7,3,new JHandler[]{new JHandler(54,195,208,""),new JHandler(208,210,208,""),new JHandler(25,34,233,""),new JHandler(35,230,233,""),new JHandler(233,237,233,"")},M93));
c.Add(new JMethod(94,"forge/StaticData","loadAllCardsEntry","(Lforge/card/CardRules;)V",2,3,4,new JHandler[]{},M94));
c.Add(new JMethod(95,"forge/StaticData","loadCustomCards","()V",2,4,3,new JHandler[]{},M95));
c.Add(new JMethod(96,"forge/StaticData","resetLazyLoadedCards","()V",1,4,4,new JHandler[]{new JHandler(72,102,115,""),new JHandler(18,130,133,""),new JHandler(133,136,133,"")},M96));
c.Add(new JMethod(97,"forge/StaticData","lazyLoadCard","(Ljava/lang/String;Ljava/lang/String;)Z",1,8,3,new JHandler[]{new JHandler(84,111,156,""),new JHandler(126,141,156,""),new JHandler(156,158,156,""),new JHandler(30,40,171,""),new JHandler(41,67,171,""),new JHandler(68,123,171,""),new JHandler(126,153,171,""),new JHandler(156,175,171,"")},M97));
c.Add(new JMethod(98,"forge/StaticData","attemptToLoadCard","(Ljava/lang/String;Ljava/lang/String;)V",1,6,3,new JHandler[]{new JHandler(17,23,36,""),new JHandler(36,38,36,""),new JHandler(7,53,56,""),new JHandler(56,60,56,"")},M98));
c.Add(new JMethod(99,"forge/StaticData","attemptToLoadCardInner","(Ljava/lang/String;Ljava/lang/String;)V",2,7,4,new JHandler[]{new JHandler(89,96,111,""),new JHandler(111,113,111,"")},M99));
c.Add(new JMethod(100,"forge/StaticData","fetchCard","(Ljava/lang/String;)Lforge/item/PaperCard;",1,2,4,new JHandler[]{},M100));
c.Add(new JMethod(101,"forge/StaticData","fetchCard","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;",1,7,4,new JHandler[]{},M101));
c.Add(new JMethod(102,"forge/StaticData","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;Ljava/lang/String;IZ)Lforge/item/PaperCard;",1,10,5,new JHandler[]{},M102));
c.Add(new JMethod(103,"forge/StaticData","getCardFromSupportedEditions","(Ljava/lang/String;ZLforge/card/CardDb$CardArtPreference;Ljava/util/List;Ljava/util/Date;)Lforge/item/PaperCard;",1,11,5,new JHandler[]{},M103));
}

private static void Add1(JClass c){
c.Add(new JMethod(104,"forge/StaticData","matchTargetCardDb","(Ljava/lang/String;)Lforge/card/CardDb;",2,4,2,new JHandler[]{},M104));
c.Add(new JMethod(105,"forge/StaticData","isMTGCard","(Ljava/lang/String;)Z",1,3,2,new JHandler[]{},M105));
c.Add(new JMethod(106,"forge/StaticData","getTournamentPacks","()Lforge/util/storage/IStorage;",17,1,10,new JHandler[]{},M106));
c.Add(new JMethod(107,"forge/StaticData","getBoosters","()Lforge/util/storage/IStorage;",17,1,5,new JHandler[]{},M107));
c.Add(new JMethod(108,"forge/StaticData","getSpecialBoosters","()Lforge/util/storage/IStorage;",17,1,10,new JHandler[]{},M108));
c.Add(new JMethod(109,"forge/StaticData","getPrintSheets","()Lforge/util/storage/IStorage;",1,1,5,new JHandler[]{},M109));
c.Add(new JMethod(110,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;",1,1,1,new JHandler[]{},M110));
c.Add(new JMethod(111,"forge/StaticData","getVariantCards","()Lforge/card/CardDb;",1,1,1,new JHandler[]{},M111));
c.Add(new JMethod(112,"forge/StaticData","getAvailableDatabases","()Ljava/util/Map;",1,2,3,new JHandler[]{},M112));
c.Add(new JMethod(113,"forge/StaticData","getAllTokens","()Lforge/token/TokenDb;",1,1,1,new JHandler[]{},M113));
c.Add(new JMethod(114,"forge/StaticData","allowCustomCardsInDecksConformance","()Z",1,1,1,new JHandler[]{},M114));
c.Add(new JMethod(115,"forge/StaticData","setStandardPredicate","(Ljava/util/function/Predicate;)V",1,2,2,new JHandler[]{},M115));
c.Add(new JMethod(116,"forge/StaticData","setPioneerPredicate","(Ljava/util/function/Predicate;)V",1,2,2,new JHandler[]{},M116));
c.Add(new JMethod(117,"forge/StaticData","setModernPredicate","(Ljava/util/function/Predicate;)V",1,2,2,new JHandler[]{},M117));
c.Add(new JMethod(118,"forge/StaticData","setCommanderPredicate","(Ljava/util/function/Predicate;)V",1,2,2,new JHandler[]{},M118));
c.Add(new JMethod(119,"forge/StaticData","setOathbreakerPredicate","(Ljava/util/function/Predicate;)V",1,2,2,new JHandler[]{},M119));
c.Add(new JMethod(120,"forge/StaticData","setBrawlPredicate","(Ljava/util/function/Predicate;)V",1,2,2,new JHandler[]{},M120));
c.Add(new JMethod(121,"forge/StaticData","getStandardPredicate","()Ljava/util/function/Predicate;",1,1,1,new JHandler[]{},M121));
c.Add(new JMethod(122,"forge/StaticData","getPioneerPredicate","()Ljava/util/function/Predicate;",1,1,1,new JHandler[]{},M122));
c.Add(new JMethod(123,"forge/StaticData","getModernPredicate","()Ljava/util/function/Predicate;",1,1,1,new JHandler[]{},M123));
c.Add(new JMethod(124,"forge/StaticData","getCommanderPredicate","()Ljava/util/function/Predicate;",1,1,1,new JHandler[]{},M124));
c.Add(new JMethod(125,"forge/StaticData","getOathbreakerPredicate","()Ljava/util/function/Predicate;",1,1,1,new JHandler[]{},M125));
c.Add(new JMethod(126,"forge/StaticData","getBrawlPredicate","()Ljava/util/function/Predicate;",1,1,1,new JHandler[]{},M126));
c.Add(new JMethod(127,"forge/StaticData","getAlternativeCardPrint","(Lforge/item/PaperCard;Ljava/util/Date;)Lforge/item/PaperCard;",1,5,6,new JHandler[]{},M127));
c.Add(new JMethod(128,"forge/StaticData","getAlternativeCardPrint","(Lforge/item/PaperCard;Ljava/util/Date;ZZLjava/util/List;)Lforge/item/PaperCard;",1,8,6,new JHandler[]{},M128));
c.Add(new JMethod(129,"forge/StaticData","getAlternativeCardPrint","(Lforge/item/PaperCard;Ljava/util/Date;ZZZZ)Lforge/item/PaperCard;",1,7,8,new JHandler[]{},M129));
c.Add(new JMethod(130,"forge/StaticData","getAlternativeCardPrint","(Lforge/item/PaperCard;Ljava/util/Date;ZZZZLjava/util/List;)Lforge/item/PaperCard;",1,8,9,new JHandler[]{},M130));
c.Add(new JMethod(131,"forge/StaticData","getAlternativeCardPrint","(Lforge/item/PaperCard;Ljava/util/Date;ZZZZLjava/util/List;Lforge/card/CardEdition$BorderColor;)Lforge/item/PaperCard;",1,12,8,new JHandler[]{},M131));
c.Add(new JMethod(132,"forge/StaticData","isStrictBlackBorder","(Lforge/card/CardEdition$BorderColor;)Z",2,2,2,new JHandler[]{},M132));
c.Add(new JMethod(133,"forge/StaticData","distanceToDate","(Lforge/item/PaperCard;Ljava/util/Date;)J",2,4,4,new JHandler[]{},M133));
c.Add(new JMethod(134,"forge/StaticData","findClosestBasicLandPrint","(Lforge/item/PaperCard;Ljava/util/Date;ZZLjava/util/List;Lforge/card/CardEdition$BorderColor;)Lforge/item/PaperCard;",2,9,7,new JHandler[]{},M134));
c.Add(new JMethod(135,"forge/StaticData","hasBorderMismatch","(Lforge/item/PaperCard;Lforge/card/CardEdition$BorderColor;)Z",1,5,2,new JHandler[]{},M135));
c.Add(new JMethod(136,"forge/StaticData","hasBorder","(Lforge/item/PaperCard;Lforge/card/CardEdition$BorderColor;)Z",2,3,3,new JHandler[]{},M136));
c.Add(new JMethod(137,"forge/StaticData","findClosestPrintWithBorder","(Lforge/item/PaperCard;Ljava/util/Date;Lforge/card/CardEdition$BorderColor;ZZLjava/util/List;)Lforge/item/PaperCard;",2,22,4,new JHandler[]{},M137));
c.Add(new JMethod(138,"forge/StaticData","getAlternativeCardPrintByDate","(Lforge/item/PaperCard;Ljava/util/Date;ZZZZLjava/util/List;)Lforge/item/PaperCard;",2,11,6,new JHandler[]{},M138));
c.Add(new JMethod(139,"forge/StaticData","hasWorseEditionRank","(Lforge/item/PaperCard;Lforge/item/PaperCard;)Z",2,4,4,new JHandler[]{},M139));
c.Add(new JMethod(140,"forge/StaticData","isOnPreferredSideOfDate","(Lforge/item/PaperCard;Ljava/util/Date;Z)Z",2,5,2,new JHandler[]{},M140));
c.Add(new JMethod(141,"forge/StaticData","searchAlternativeCardCandidate","(Lforge/item/PaperCard;ZLjava/util/Date;Lforge/card/CardDb$CardArtPreference;Ljava/util/List;)Lforge/item/PaperCard;",2,12,7,new JHandler[]{},M141));
c.Add(new JMethod(142,"forge/StaticData","searchAlternativeCardCandidateWithFilter","(Lforge/item/PaperCard;ZLjava/util/Date;Lforge/card/CardDb$CardArtPreference;Ljava/util/function/Predicate;)Lforge/item/PaperCard;",2,10,6,new JHandler[]{},M142));
c.Add(new JMethod(143,"forge/StaticData","getReferenceDate","(Ljava/util/Date;Z)Ljava/util/Date;",2,4,3,new JHandler[]{},M143));
c.Add(new JMethod(144,"forge/StaticData","getSearchStrategyForAlternativeCardArt","(ZZ)Lforge/card/CardDb$CardArtPreference;",2,4,1,new JHandler[]{},M144));
c.Add(new JMethod(145,"forge/StaticData","tryToGetCardPrintFromExpansionSet","(Lforge/item/PaperCard;ZZLjava/util/List;)Lforge/item/PaperCard;",2,11,6,new JHandler[]{},M145));
c.Add(new JMethod(146,"forge/StaticData","tryToGetCardPrintWithMatchingFrame","(Lforge/item/PaperCard;ZZZLjava/util/List;)Lforge/item/PaperCard;",2,13,6,new JHandler[]{},M146));
c.Add(new JMethod(147,"forge/StaticData","getCardArtCount","(Lforge/item/PaperCard;)I",1,6,3,new JHandler[]{},M147));
c.Add(new JMethod(148,"forge/StaticData","getFilteredHandsEnabled","()Z",1,1,1,new JHandler[]{},M148));
c.Add(new JMethod(149,"forge/StaticData","setFilteredHandsEnabled","(Z)V",1,2,2,new JHandler[]{},M149));
c.Add(new JMethod(150,"forge/StaticData","setMulliganRule","(Lforge/MulliganDefs$MulliganRule;)V",1,2,2,new JHandler[]{},M150));
c.Add(new JMethod(151,"forge/StaticData","getMulliganRule","()Lforge/MulliganDefs$MulliganRule;",1,1,1,new JHandler[]{},M151));
c.Add(new JMethod(152,"forge/StaticData","setCardArtPreference","(ZZ)V",1,3,3,new JHandler[]{},M152));
c.Add(new JMethod(153,"forge/StaticData","getCardArtPreferenceName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M153));
c.Add(new JMethod(154,"forge/StaticData","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;",1,1,1,new JHandler[]{},M154));
c.Add(new JMethod(155,"forge/StaticData","getCardArtPreference","(ZZ)Lforge/card/CardDb$CardArtPreference;",1,3,3,new JHandler[]{},M155));
c.Add(new JMethod(156,"forge/StaticData","cardArtPreferenceIsBlackBorder","()Z",1,1,1,new JHandler[]{},M156));
c.Add(new JMethod(157,"forge/StaticData","isCoreExpansionOnlyFilterSet","()Z",1,1,1,new JHandler[]{},M157));
c.Add(new JMethod(158,"forge/StaticData","cardArtPreferenceIsLatest","()Z",1,1,1,new JHandler[]{},M158));
c.Add(new JMethod(159,"forge/StaticData","getCardArtAvailablePreferences","()[Ljava/lang/String;",1,4,5,new JHandler[]{},M159));
c.Add(new JMethod(160,"forge/StaticData","audit","(Ljava/lang/StringBuffer;Ljava/lang/StringBuffer;)Lorg/apache/commons/lang3/tuple/Pair;",1,3,4,new JHandler[]{},M160));
c.Add(new JMethod(161,"forge/StaticData","audit","(Ljava/lang/StringBuffer;Ljava/lang/StringBuffer;Ljava/util/function/IntConsumer;)Lorg/apache/commons/lang3/tuple/Pair;",1,32,12,new JHandler[]{new JHandler(520,528,531,"java/lang/InterruptedException"),new JHandler(520,528,531,"java/util/concurrent/ExecutionException"),new JHandler(614,635,728,"java/lang/Exception"),new JHandler(638,725,728,"java/lang/Exception"),new JHandler(210,754,764,""),new JHandler(764,766,764,"")},M161));
c.Add(new JMethod(162,"forge/StaticData","groupByCode","(Ljava/util/List;)Ljava/util/Map;",10,5,3,new JHandler[]{},M162));
c.Add(new JMethod(163,"forge/StaticData","prettifyCardArtPreferenceName","(Lforge/card/CardDb$CardArtPreference;)Ljava/lang/String;",2,8,2,new JHandler[]{},M163));
c.Add(new JMethod(164,"forge/StaticData","setCardArtPreference","(ZZZ)V",1,4,4,new JHandler[]{},M164));
c.Add(new JMethod(165,"forge/StaticData","setCardArtPreference","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M165));
c.Add(new JMethod(166,"forge/StaticData","setPreferredLanguageAvailability","(Ljava/util/function/BiPredicate;)V",1,2,2,new JHandler[]{},M166));
c.Add(new JMethod(167,"forge/StaticData","isEnabledCardArtSmartSelection","()Z",1,1,1,new JHandler[]{},M167));
}

private static void Add2(JClass c){
c.Add(new JMethod(168,"forge/StaticData","setEnableSmartCardArtSelection","(Z)V",1,2,2,new JHandler[]{},M168));
c.Add(new JMethod(169,"forge/StaticData","useSourceImageForClone","()Z",1,1,1,new JHandler[]{},M169));
c.Add(new JMethod(170,"forge/StaticData","setSourceImageForClone","(Z)V",1,2,2,new JHandler[]{},M170));
c.Add(new JMethod(171,"forge/StaticData","isRebalanced","(Ljava/lang/String;)Z",1,5,2,new JHandler[]{},M171));
c.Add(new JMethod(172,"forge/StaticData","getOtherImageKey","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1,6,5,new JHandler[]{},M172));
c.Add(new JMethod(173,"forge/StaticData","lambda$groupByCode$3","(Ljava/lang/String;)Ljava/util/List;",4106,1,2,new JHandler[]{},M173));
c.Add(new JMethod(174,"forge/StaticData","lambda$audit$2","(Ljava/util/Map$Entry;Lforge/card/CardEdition;Ljava/util/Queue;Ljava/util/Queue;Ljava/util/Queue;Ljava/util/function/IntConsumer;Ljava/util/concurrent/atomic/AtomicInteger;ILjava/util/concurrent/atomic/AtomicInteger;)V",4098,20,6,new JHandler[]{new JHandler(0,100,590,"java/lang/Exception"),new JHandler(154,174,590,"java/lang/Exception"),new JHandler(228,267,590,"java/lang/Exception"),new JHandler(321,534,590,"java/lang/Exception"),new JHandler(0,100,653,""),new JHandler(154,174,653,""),new JHandler(228,267,653,""),new JHandler(321,534,653,""),new JHandler(590,597,653,""),new JHandler(653,655,653,"")},M174));
c.Add(new JMethod(175,"forge/StaticData","lambda$searchAlternativeCardCandidate$1","(Lforge/card/CardDb$CardArtPreference;ILforge/item/PaperCard;)Z",4098,5,2,new JHandler[]{},M175));
c.Add(new JMethod(176,"forge/StaticData","lambda$findClosestPrintWithBorder$0","(Lforge/card/CardDb$CardArtPreference;ILforge/item/PaperCard;)Z",4098,4,3,new JHandler[]{},M176));
c.Add(new JMethod(177,"forge/StaticData","<clinit>","()V",8,0,1,new JHandler[]{},M177));
}

internal static JStep M81(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[5]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("")));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[6]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[7]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[8]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/StaticData","<init>","(Lforge/CardStorageReader;Lforge/CardStorageReader;Lforge/CardStorageReader;Lforge/CardStorageReader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZZZLjava/util/function/BiPredicate;)V","invokespecial",24);}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M82(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[6]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[7]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[8]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[9]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[10]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[11]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[12]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[13]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(null));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/StaticData","<init>","(Lforge/CardStorageReader;Lforge/CardStorageReader;Lforge/CardStorageReader;Lforge/CardStorageReader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZZZLjava/util/function/BiPredicate;)V","invokespecial",28);}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M83(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","funnyCards","Ljava/util/Set;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","filtered","Ljava/util/Set;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentSkipListMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentSkipListMap")));f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/concurrent/ConcurrentSkipListMap","<init>","(Ljava/util/Comparator;)V","invokespecial",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","regularRules","Ljava/util/Map;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentSkipListMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentSkipListMap")));f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/concurrent/ConcurrentSkipListMap","<init>","(Ljava/util/Comparator;)V","invokespecial",51);}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","variantRules","Ljava/util/Map;",value);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",62);}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","placeholderFacesInProgress","Ljava/util/Set;",value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",73);}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","missingLazyCards","Ljava/util/Set;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{if(!rt.EnsureInitialized(f,"java/lang/Object"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/Object")));f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",84);}
case 84:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadLock","Ljava/lang/Object;",value);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","allCardsLoaded","Z",value);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","filteredHandsEnabled","Z",value);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/MulliganDefs","getDefaultRule","()Lforge/MulliganDefs$MulliganRule;","invokestatic",106);}
case 106:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","mulliganRule","Lforge/MulliganDefs$MulliganRule;",value);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=113;continue;}
case 113:{f.StackOp("dup");f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",117);}
case 117:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","setLookup","Ljava/util/Map;",value);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","cardReader","Lforge/CardStorageReader;",value);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","customCardReader","Lforge/CardStorageReader;",value);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","tokenReader","Lforge/CardStorageReader;",value);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Collection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Collection")));f.Pc=139;continue;}
case 139:{f.StackOp("dup");f.Pc=140;continue;}
case 140:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Reader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Reader")));f.Pc=143;continue;}
case 143:{f.StackOp("dup");f.Pc=144;continue;}
case 144:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=147;continue;}
case 147:{f.StackOp("dup");f.Pc=148;continue;}
case 148:{f.Push(f.Locals[5]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",153);}
case 153:{return rt.Call(f,"forge/card/CardEdition$Reader","<init>","(Ljava/io/File;)V","invokespecial",156);}
case 156:{return rt.Call(f,"forge/card/CardEdition$Collection","<init>","(Lforge/util/IItemReader;)V","invokespecial",159);}
case 159:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;",value);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[0]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[7]);f.Pc=165;continue;}
case 165:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","blockDataFolder","Ljava/lang/String;",value);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[12]);f.Pc=171;continue;}
case 171:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","allowCustomCardsInDecksConformance","Z",value);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[13]);f.Pc=177;continue;}
case 177:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","enableSmartCardArtSelection","Z",value);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[0]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[11]);f.Pc=183;continue;}
case 183:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","loadNonLegalCards","Z",value);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[10]);f.Pc=189;continue;}
case 189:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","enableUnknownCards","Z",value);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[0]);f.Pc=193;continue;}
case 193:{if(!rt.StaticReady(f,"forge/StaticData","lastInstance","Lforge/StaticData;"))return JStep.Continue;rt.PutStatic("forge/StaticData","lastInstance","Lforge/StaticData;",f.Pop());f.Pc=196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=200;continue;}
case 200:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Collection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Collection")));f.Pc=203;continue;}
case 203:{f.StackOp("dup");f.Pc=204;continue;}
case 204:{if(!rt.EnsureInitialized(f,"forge/card/CardEdition$Reader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardEdition$Reader")));f.Pc=207;continue;}
case 207:{f.StackOp("dup");f.Pc=208;continue;}
case 208:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=211;continue;}
case 211:{f.StackOp("dup");f.Pc=212;continue;}
case 212:{f.Push(f.Locals[6]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",217);}
case 217:{f.Push(JValue.I(1));f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/card/CardEdition$Reader","<init>","(Ljava/io/File;Z)V","invokespecial",221);}
case 221:{return rt.Call(f,"forge/card/CardEdition$Collection","<init>","(Lforge/util/IItemReader;)V","invokespecial",224);}
case 224:{return rt.Call(f,"forge/card/CardEdition$Collection","append","(Lforge/card/CardEdition$Collection;)V","invokevirtual",227);}
case 227:{f.Push(f.Locals[11]);f.Pc=229;continue;}
case 229:{f.Pc=f.Pop().Int!=0?362:232;continue;}
case 232:{f.Push(f.Locals[0]);f.Pc=233;continue;}
case 233:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/card/CardEdition$Collection","iterator","()Ljava/util/Iterator;","invokevirtual",239);}
case 239:{f.Locals[15]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[15]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",248);}
case 248:{f.Pc=f.Pop().Int==0?362:251;continue;}
case 251:{f.Push(f.Locals[15]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",258);}
case 258:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=261;continue;}
case 261:{f.Locals[16]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(f.Locals[16]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",268);}
case 268:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","FUNNY","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","FUNNY","Lforge/card/CardEdition$Type;"));f.Pc=271;continue;}
case 271:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?285:274;continue;}
case 274:{f.Push(f.Locals[16]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/card/CardEdition","getBorderColor","()Lforge/card/CardEdition$BorderColor;","invokevirtual",279);}
case 279:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","SILVER","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","SILVER","Lforge/card/CardEdition$BorderColor;"));f.Pc=282;continue;}
case 282:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?359:285;continue;}
case 285:{f.Push(f.Locals[16]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/card/CardEdition","getFunnyEternalCards","()Ljava/util/List;","invokevirtual",290);}
case 290:{f.Locals[17]=f.Pop();f.Pc=292;continue;}
case 292:{f.Push(f.Locals[16]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/card/CardEdition","getAllCardsInSet","()Ljava/util/List;","invokevirtual",297);}
case 297:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",302);}
case 302:{f.Locals[18]=f.Pop();f.Pc=304;continue;}
case 304:{f.Push(f.Locals[18]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",311);}
case 311:{f.Pc=f.Pop().Int==0?359:314;continue;}
case 314:{f.Push(f.Locals[18]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",321);}
case 321:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=324;continue;}
case 324:{f.Locals[19]=f.Pop();f.Pc=326;continue;}
case 326:{f.Push(f.Locals[17]);f.Pc=328;continue;}
case 328:{f.Push(f.Locals[19]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",335);}
case 335:{f.Pc=f.Pop().Int==0?341:338;continue;}
case 338:{f.Pc=304;continue;}
case 341:{f.Push(f.Locals[0]);f.Pc=342;continue;}
case 342:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","funnyCards","Ljava/util/Set;"));f.Pc=345;continue;}
case 345:{f.Push(f.Locals[19]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",350);}
case 350:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",355);}
case 355:{f.StackOp("pop");f.Pc=356;continue;}
case 356:{f.Pc=304;continue;}
case 359:{f.Pc=241;continue;}
case 362:{f.Push(f.Locals[1]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/CardStorageReader","loadCards","()Ljava/lang/Iterable;","invokevirtual",366);}
case 366:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",371);}
case 371:{f.Locals[15]=f.Pop();f.Pc=373;continue;}
case 373:{f.Push(f.Locals[15]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",380);}
case 380:{f.Pc=f.Pop().Int==0?495:383;continue;}
case 383:{f.Push(f.Locals[15]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",390);}
case 390:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=393;continue;}
case 393:{f.Locals[16]=f.Pop();f.Pc=395;continue;}
case 395:{f.Push(JValue.R(null));f.Pc=396;continue;}
case 396:{f.Push(f.Locals[16]);f.Pc=398;continue;}
case 398:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?404:401;continue;}
case 401:{f.Pc=373;continue;}
case 404:{f.Push(f.Locals[16]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/card/CardRules","getPreInitName","()Ljava/lang/String;","invokevirtual",409);}
case 409:{f.Locals[17]=f.Pop();f.Pc=411;continue;}
case 411:{f.Push(f.Locals[11]);f.Pc=413;continue;}
case 413:{f.Pc=f.Pop().Int!=0?453:416;continue;}
case 416:{f.Push(f.Locals[0]);f.Pc=417;continue;}
case 417:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","funnyCards","Ljava/util/Set;"));f.Pc=420;continue;}
case 420:{f.Push(f.Locals[17]);f.Pc=422;continue;}
case 422:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",427);}
case 427:{f.Pc=f.Pop().Int==0?453:430;continue;}
case 430:{f.Push(f.Locals[16]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",435);}
case 435:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",438);}
case 438:{f.Pc=f.Pop().Int!=0?453:441;continue;}
case 441:{f.Push(f.Locals[0]);f.Pc=442;continue;}
case 442:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","filtered","Ljava/util/Set;"));f.Pc=445;continue;}
case 445:{f.Push(f.Locals[17]);f.Pc=447;continue;}
case 447:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",452);}
case 452:{f.StackOp("pop");f.Pc=453;continue;}
case 453:{f.Push(f.Locals[16]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/card/CardRules","isVariant","()Z","invokevirtual",458);}
case 458:{f.Pc=f.Pop().Int==0?478:461;continue;}
case 461:{f.Push(f.Locals[0]);f.Pc=462;continue;}
case 462:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantRules","Ljava/util/Map;"));f.Pc=465;continue;}
case 465:{f.Push(f.Locals[17]);f.Pc=467;continue;}
case 467:{f.Push(f.Locals[16]);f.Pc=469;continue;}
case 469:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",474);}
case 474:{f.StackOp("pop");f.Pc=475;continue;}
case 475:{f.Pc=492;continue;}
case 478:{f.Push(f.Locals[0]);f.Pc=479;continue;}
case 479:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","regularRules","Ljava/util/Map;"));f.Pc=482;continue;}
case 482:{f.Push(f.Locals[17]);f.Pc=484;continue;}
case 484:{f.Push(f.Locals[16]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",491);}
case 491:{f.StackOp("pop");f.Pc=492;continue;}
case 492:{f.Pc=373;continue;}
case 495:{f.Push(f.Locals[0]);f.Pc=496;continue;}
case 496:{return rt.Call(f,"forge/StaticData","loadCustomCards","()V","invokevirtual",499);}
case 499:{f.Push(f.Locals[0]);f.Pc=500;continue;}
case 500:{if(!rt.EnsureInitialized(f,"forge/card/CardDb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardDb")));f.Pc=503;continue;}
case 503:{f.StackOp("dup");f.Pc=504;continue;}
case 504:{f.Push(f.Locals[0]);f.Pc=505;continue;}
case 505:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","regularRules","Ljava/util/Map;"));f.Pc=508;continue;}
case 508:{f.Push(f.Locals[0]);f.Pc=509;continue;}
case 509:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=512;continue;}
case 512:{f.Push(f.Locals[0]);f.Pc=513;continue;}
case 513:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","filtered","Ljava/util/Set;"));f.Pc=516;continue;}
case 516:{return rt.Call(f,"forge/card/CardDb","<init>","(Ljava/util/Map;Lforge/card/CardEdition$Collection;Ljava/util/Set;)V","invokespecial",519);}
case 519:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;",value);f.Pc=522;continue;}
case 522:{f.Push(f.Locals[0]);f.Pc=523;continue;}
case 523:{if(!rt.EnsureInitialized(f,"forge/card/CardDb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardDb")));f.Pc=526;continue;}
case 526:{f.StackOp("dup");f.Pc=527;continue;}
case 527:{f.Push(f.Locals[0]);f.Pc=528;continue;}
case 528:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantRules","Ljava/util/Map;"));f.Pc=531;continue;}
case 531:{f.Push(f.Locals[0]);f.Pc=532;continue;}
case 532:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=535;continue;}
case 535:{f.Push(f.Locals[0]);f.Pc=536;continue;}
case 536:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","filtered","Ljava/util/Set;"));f.Pc=539;continue;}
case 539:{return rt.Call(f,"forge/card/CardDb","<init>","(Ljava/util/Map;Lforge/card/CardEdition$Collection;Ljava/util/Set;)V","invokespecial",542);}
case 542:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;",value);f.Pc=545;continue;}
case 545:{f.Push(f.Locals[0]);f.Pc=546;continue;}
case 546:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=549;continue;}
case 549:{f.Push(f.Locals[9]);f.Pc=551;continue;}
case 551:{return rt.Call(f,"forge/card/CardDb","setCardArtPreference","(Ljava/lang/String;)V","invokevirtual",554);}
case 554:{f.Push(f.Locals[0]);f.Pc=555;continue;}
case 555:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=558;continue;}
case 558:{f.Push(f.Locals[9]);f.Pc=560;continue;}
case 560:{return rt.Call(f,"forge/card/CardDb","setCardArtPreference","(Ljava/lang/String;)V","invokevirtual",563);}
case 563:{f.Push(f.Locals[0]);f.Pc=564;continue;}
case 564:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=567;continue;}
case 567:{f.Push(f.Locals[14]);f.Pc=569;continue;}
case 569:{return rt.Call(f,"forge/card/CardDb","setPreferredLanguageAvailability","(Ljava/util/function/BiPredicate;)V","invokevirtual",572);}
case 572:{f.Push(f.Locals[0]);f.Pc=573;continue;}
case 573:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=576;continue;}
case 576:{f.Push(f.Locals[14]);f.Pc=578;continue;}
case 578:{return rt.Call(f,"forge/card/CardDb","setPreferredLanguageAvailability","(Ljava/util/function/BiPredicate;)V","invokevirtual",581);}
case 581:{f.Push(f.Locals[0]);f.Pc=582;continue;}
case 582:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=585;continue;}
case 585:{f.Push(JValue.I(0));f.Pc=586;continue;}
case 586:{f.Push(JValue.I(0));f.Pc=587;continue;}
case 587:{f.Push(f.Locals[10]);f.Pc=589;continue;}
case 589:{return rt.Call(f,"forge/card/CardDb","initialize","(ZZZ)V","invokevirtual",592);}
case 592:{f.Push(f.Locals[0]);f.Pc=593;continue;}
case 593:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=596;continue;}
case 596:{f.Push(JValue.I(0));f.Pc=597;continue;}
case 597:{f.Push(JValue.I(0));f.Pc=598;continue;}
case 598:{f.Push(f.Locals[10]);f.Pc=600;continue;}
case 600:{return rt.Call(f,"forge/card/CardDb","initialize","(ZZZ)V","invokevirtual",603);}
case 603:{f.Push(f.Locals[0]);f.Pc=604;continue;}
case 604:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","tokenReader","Lforge/CardStorageReader;"));f.Pc=607;continue;}
case 607:{f.Pc=f.Pop().Reference==null?776:610;continue;}
case 610:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=613;continue;}
case 613:{f.StackOp("dup");f.Pc=614;continue;}
case 614:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=617;continue;}
case 617:{return rt.Call(f,"java/util/TreeMap","<init>","(Ljava/util/Comparator;)V","invokespecial",620);}
case 620:{f.Locals[15]=f.Pop();f.Pc=622;continue;}
case 622:{f.Push(f.Locals[0]);f.Pc=623;continue;}
case 623:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","tokenReader","Lforge/CardStorageReader;"));f.Pc=626;continue;}
case 626:{return rt.Call(f,"forge/CardStorageReader","loadCards","()Ljava/lang/Iterable;","invokevirtual",629);}
case 629:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",634);}
case 634:{f.Locals[16]=f.Pop();f.Pc=636;continue;}
case 636:{f.Push(f.Locals[16]);f.Pc=638;continue;}
case 638:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",643);}
case 643:{f.Pc=f.Pop().Int==0?685:646;continue;}
case 646:{f.Push(f.Locals[16]);f.Pc=648;continue;}
case 648:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",653);}
case 653:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=656;continue;}
case 656:{f.Locals[17]=f.Pop();f.Pc=658;continue;}
case 658:{f.Push(JValue.R(null));f.Pc=659;continue;}
case 659:{f.Push(f.Locals[17]);f.Pc=661;continue;}
case 661:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?667:664;continue;}
case 664:{f.Pc=636;continue;}
case 667:{f.Push(f.Locals[15]);f.Pc=669;continue;}
case 669:{f.Push(f.Locals[17]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/card/CardRules","getNormalizedName","()Ljava/lang/String;","invokevirtual",674);}
case 674:{f.Push(f.Locals[17]);f.Pc=676;continue;}
case 676:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",681);}
case 681:{f.StackOp("pop");f.Pc=682;continue;}
case 682:{f.Pc=636;continue;}
case 685:{f.Push(f.Locals[4]);f.Pc=687;continue;}
case 687:{f.Pc=f.Pop().Reference==null?756:690;continue;}
case 690:{f.Push(f.Locals[4]);f.Pc=692;continue;}
case 692:{return rt.Call(f,"forge/CardStorageReader","loadCards","()Ljava/lang/Iterable;","invokevirtual",695);}
case 695:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",700);}
case 700:{f.Locals[16]=f.Pop();f.Pc=702;continue;}
case 702:{f.Push(f.Locals[16]);f.Pc=704;continue;}
case 704:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",709);}
case 709:{f.Pc=f.Pop().Int==0?756:712;continue;}
case 712:{f.Push(f.Locals[16]);f.Pc=714;continue;}
case 714:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",719);}
case 719:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=722;continue;}
case 722:{f.Locals[17]=f.Pop();f.Pc=724;continue;}
case 724:{f.Push(JValue.R(null));f.Pc=725;continue;}
case 725:{f.Push(f.Locals[17]);f.Pc=727;continue;}
case 727:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?733:730;continue;}
case 730:{f.Pc=702;continue;}
case 733:{f.Push(f.Locals[17]);f.Pc=735;continue;}
case 735:{return rt.Call(f,"forge/card/CardRules","setCustom","()V","invokevirtual",738);}
case 738:{f.Push(f.Locals[15]);f.Pc=740;continue;}
case 740:{f.Push(f.Locals[17]);f.Pc=742;continue;}
case 742:{return rt.Call(f,"forge/card/CardRules","getNormalizedName","()Ljava/lang/String;","invokevirtual",745);}
case 745:{f.Push(f.Locals[17]);f.Pc=747;continue;}
case 747:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",752);}
case 752:{f.StackOp("pop");f.Pc=753;continue;}
case 753:{f.Pc=702;continue;}
case 756:{f.Push(f.Locals[0]);f.Pc=757;continue;}
case 757:{if(!rt.EnsureInitialized(f,"forge/token/TokenDb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/token/TokenDb")));f.Pc=760;continue;}
case 760:{f.StackOp("dup");f.Pc=761;continue;}
case 761:{f.Push(f.Locals[15]);f.Pc=763;continue;}
case 763:{f.Push(f.Locals[0]);f.Pc=764;continue;}
case 764:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=767;continue;}
case 767:{return rt.Call(f,"forge/token/TokenDb","<init>","(Ljava/util/Map;Lforge/card/CardEdition$Collection;)V","invokespecial",770);}
case 770:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","allTokens","Lforge/token/TokenDb;",value);f.Pc=773;continue;}
case 773:{f.Pc=781;continue;}
case 776:{f.Push(f.Locals[0]);f.Pc=777;continue;}
case 777:{f.Push(JValue.R(null));f.Pc=778;continue;}
case 778:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","allTokens","Lforge/token/TokenDb;",value);f.Pc=781;continue;}
case 781:{f.Push(f.Locals[8]);f.Pc=783;continue;}
case 783:{return rt.Call(f,"forge/util/FileUtil","isDirectoryWithFiles","(Ljava/lang/String;)Z","invokestatic",786);}
case 786:{f.Pc=f.Pop().Int==0?873:789;continue;}
case 789:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=792;continue;}
case 792:{f.StackOp("dup");f.Pc=793;continue;}
case 793:{f.Push(f.Locals[8]);f.Pc=795;continue;}
case 795:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;)V","invokespecial",798);}
case 798:{return rt.Call(f,"java/io/File","listFiles","()[Ljava/io/File;","invokevirtual",801);}
case 801:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",804);}
case 804:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/io/File;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=807;continue;}
case 807:{f.Locals[15]=f.Pop();f.Pc=809;continue;}
case 809:{f.Push(f.Locals[15]);f.Pc=811;continue;}
case 811:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=812;continue;}
case 812:{f.Locals[16]=f.Pop();f.Pc=814;continue;}
case 814:{f.Push(JValue.I(0));f.Pc=815;continue;}
case 815:{f.Locals[17]=f.Pop();f.Pc=817;continue;}
case 817:{f.Push(f.Locals[17]);f.Pc=819;continue;}
case 819:{f.Push(f.Locals[16]);f.Pc=821;continue;}
case 821:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?873:824;continue;}
case 824:{f.Push(f.Locals[15]);f.Pc=826;continue;}
case 826:{f.Push(f.Locals[17]);f.Pc=828;continue;}
case 828:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=829;continue;}
case 829:{f.Locals[18]=f.Pop();f.Pc=831;continue;}
case 831:{f.Push(f.Locals[18]);f.Pc=833;continue;}
case 833:{return rt.Call(f,"java/io/File","isFile","()Z","invokevirtual",836);}
case 836:{f.Pc=f.Pop().Int==0?867:839;continue;}
case 839:{f.Push(f.Locals[0]);f.Pc=840;continue;}
case 840:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","setLookup","Ljava/util/Map;"));f.Pc=843;continue;}
case 843:{f.Push(f.Locals[18]);f.Pc=845;continue;}
case 845:{return rt.Call(f,"java/io/File","getName","()Ljava/lang/String;","invokevirtual",848);}
case 848:{f.Push(JValue.R(rt.String(".txt")));f.Pc=851;continue;}
case 851:{f.Push(JValue.R(rt.String("")));f.Pc=853;continue;}
case 853:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",856);}
case 856:{f.Push(f.Locals[18]);f.Pc=858;continue;}
case 858:{return rt.Call(f,"forge/util/FileUtil","readFile","(Ljava/io/File;)Ljava/util/List;","invokestatic",861);}
case 861:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",866);}
case 866:{f.StackOp("pop");f.Pc=867;continue;}
case 867:{f.Locals[17]=JValue.I(unchecked(f.Locals[17].Int+(1)));f.Pc=870;continue;}
case 870:{f.Pc=817;continue;}
case 873:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M84(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/StaticData","lastInstance","Lforge/StaticData;"))return JStep.Continue;f.Push(rt.GetStatic("forge/StaticData","lastInstance","Lforge/StaticData;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M85(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","setLookup","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M86(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M87(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","sortedEditions","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?73:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","sortedEditions","Ljava/util/List;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/CardEdition$Collection","iterator","()Ljava/util/Iterator;","invokevirtual",25);}
case 25:{f.Locals[1]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?59:35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[2]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","sortedEditions","Ljava/util/List;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Pc=26;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","sortedEditions","Ljava/util/List;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Collections","sort","(Ljava/util/List;)V","invokestatic",66);}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","sortedEditions","Ljava/util/List;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Collections","reverse","(Ljava/util/List;)V","invokestatic",73);}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","sortedEditions","Ljava/util/List;"));f.Pc=77;continue;}
case 77:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M88(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editionsTypeMap","Ljava/util/TreeMap;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?119:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/TreeMap","<init>","()V","invokespecial",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","editionsTypeMap","Ljava/util/TreeMap;",value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/card/CardEdition$Type","values","()[Lforge/card/CardEdition$Type;","invokestatic",21);}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=24;continue;}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?60:32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=35;continue;}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editionsTypeMap","Ljava/util/TreeMap;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",50);}
case 50:{return rt.Call(f,"java/util/TreeMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=57;continue;}
case 57:{f.Pc=27;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/StaticData","getSortedEditions","()Ljava/util/List;","invokevirtual",64);}
case 64:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",69);}
case 69:{f.Locals[1]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?119:79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{f.Locals[2]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",93);}
case 93:{f.Locals[3]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editionsTypeMap","Ljava/util/TreeMap;"));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/TreeMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",102);}
case 102:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=105;continue;}
case 105:{f.Locals[4]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[4]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",115);}
case 115:{f.StackOp("pop");f.Pc=116;continue;}
case 116:{f.Pc=70;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editionsTypeMap","Ljava/util/TreeMap;"));f.Pc=123;continue;}
case 123:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M89(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("???")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?14:10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"));f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M90(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperCard;","invokevirtual",10);}
case 10:{f.Locals[5]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[5]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference!=null?35:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/StaticData","attemptToLoadCard","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperCard;","invokevirtual",33);}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{f.Pc=f.Pop().Reference!=null?51:40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",49);}
case 49:{f.Locals[5]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{f.Pc=f.Pop().Reference!=null?58:56;continue;}
case 56:{f.Push(JValue.R(null));f.Pc=57;continue;}
case 57:{return JStep.Return(f.Pop());}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Int==0?71:63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",68);}
case 68:{f.Pc=73;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M91(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/StaticData","getAvailableDatabases","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{f.Locals[6]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/StaticData","getAvailableDatabases","()Ljava/util/Map;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",18);}
case 18:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",23);}
case 23:{f.Locals[7]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[7]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?68:35;continue;}
case 35:{f.Push(f.Locals[7]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardDb"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[8]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[8]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperCard;","invokevirtual",55);}
case 55:{f.Locals[6]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{f.Pc=f.Pop().Reference==null?65:62;continue;}
case 62:{f.Pc=68;continue;}
case 65:{f.Pc=25;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{f.Pc=f.Pop().Reference!=null?138:73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/StaticData","attemptToLoadCard","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",79);}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/StaticData","getAvailableDatabases","()Ljava/util/Map;","invokevirtual",83);}
case 83:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",88);}
case 88:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",93);}
case 93:{f.Locals[7]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",102);}
case 102:{f.Pc=f.Pop().Int==0?138:105;continue;}
case 105:{f.Push(f.Locals[7]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardDb"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{f.Locals[8]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[8]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[3]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperCard;","invokevirtual",125);}
case 125:{f.Locals[6]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[6]);f.Pc=129;continue;}
case 129:{f.Pc=f.Pop().Reference==null?135:132;continue;}
case 132:{f.Pc=138;continue;}
case 135:{f.Pc=95;continue;}
case 138:{f.Push(f.Locals[6]);f.Pc=140;continue;}
case 140:{f.Pc=f.Pop().Reference!=null?201:143;continue;}
case 143:{f.Push(f.Locals[0]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/StaticData","getAvailableDatabases","()Ljava/util/Map;","invokevirtual",147);}
case 147:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",152);}
case 152:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",157);}
case 157:{f.Locals[7]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[7]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",166);}
case 166:{f.Pc=f.Pop().Int==0?201:169;continue;}
case 169:{f.Push(f.Locals[7]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",176);}
case 176:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardDb"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=179;continue;}
case 179:{f.Locals[8]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[8]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[2]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",188);}
case 188:{f.Locals[6]=f.Pop();f.Pc=190;continue;}
case 190:{f.Push(f.Locals[6]);f.Pc=192;continue;}
case 192:{f.Pc=f.Pop().Reference==null?198:195;continue;}
case 195:{f.Pc=201;continue;}
case 198:{f.Pc=159;continue;}
case 201:{f.Push(f.Locals[6]);f.Pc=203;continue;}
case 203:{f.Pc=f.Pop().Reference!=null?208:206;continue;}
case 206:{f.Push(JValue.R(null));f.Pc=207;continue;}
case 207:{return JStep.Return(f.Pop());}
case 208:{f.Push(f.Locals[4]);f.Pc=210;continue;}
case 210:{f.Pc=f.Pop().Int==0?221:213;continue;}
case 213:{f.Push(f.Locals[6]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",218);}
case 218:{f.Pc=223;continue;}
case 221:{f.Push(f.Locals[6]);f.Pc=223;continue;}
case 223:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M92(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/StaticData","attemptToLoadCard","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M93(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","allCardsLoaded","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?17:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","cardReader","Lforge/CardStorageReader;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/CardStorageReader","isLoadingCardsLazily","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?18:17;continue;}
case 17:{return JStep.ReturnVoid;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadLock","Ljava/lang/Object;"));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Locals[1]=f.Pop();f.Pc=24;continue;}
case 24:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","allCardsLoaded","Z"));f.Pc=29;continue;}
case 29:{f.Pc=f.Pop().Int==0?35:32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=34;continue;}
case 34:{return JStep.ReturnVoid;}
case 35:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Lazy card database: loading all remaining cards")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",44);}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.StackOp("dup");f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=51;continue;}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",61);}
case 61:{f.Locals[2]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","cardReader","Lforge/CardStorageReader;"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/CardStorageReader","readAllCards","()Ljava/lang/Iterable;","invokevirtual",69);}
case 69:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",74);}
case 74:{f.Locals[3]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",81);}
case 81:{f.Pc=f.Pop().Int==0?137:84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{f.Locals[4]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[4]);f.Pc=97;continue;}
case 97:{f.Pc=f.Pop().Reference!=null?103:100;continue;}
case 100:{f.Pc=75;continue;}
case 103:{f.Push(f.Locals[4]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/card/CardRules","getPlaceholderFaceNames","()Ljava/util/Collection;","invokevirtual",108);}
case 108:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",113);}
case 113:{f.Pc=f.Pop().Int!=0?128:116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[4]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Pc=75;continue;}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/StaticData","loadAllCardsEntry","(Lforge/card/CardRules;)V","invokevirtual",134);}
case 134:{f.Pc=75;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",143);}
case 143:{f.Locals[3]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[3]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",150);}
case 150:{f.Pc=f.Pop().Int==0?173:153;continue;}
case 153:{f.Push(f.Locals[3]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",159);}
case 159:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=162;continue;}
case 162:{f.Locals[4]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[4]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/StaticData","loadAllCardsEntry","(Lforge/card/CardRules;)V","invokevirtual",170);}
case 170:{f.Pc=144;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=177;continue;}
case 177:{f.Push(f.Locals[0]);f.Pc=178;continue;}
case 178:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","enableUnknownCards","Z"));f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/card/CardDb","addUnassignedCardPrints","(Z)V","invokevirtual",184);}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=188;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","enableUnknownCards","Z"));f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/card/CardDb","addUnassignedCardPrints","(Z)V","invokevirtual",195);}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.StackOp("dup");f.Pc=197;continue;}
case 197:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=200;continue;}
case 200:{f.Push(JValue.I(1));f.Pc=201;continue;}
case 201:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=202;continue;}
case 202:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=205;continue;}
case 205:{f.Pc=223;continue;}
case 208:{f.Locals[5]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[0]);f.Pc=211;continue;}
case 211:{f.StackOp("dup");f.Pc=212;continue;}
case 212:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=215;continue;}
case 215:{f.Push(JValue.I(1));f.Pc=216;continue;}
case 216:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=217;continue;}
case 217:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[5]);f.Pc=222;continue;}
case 222:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 223:{f.Push(f.Locals[0]);f.Pc=224;continue;}
case 224:{f.Push(JValue.I(1));f.Pc=225;continue;}
case 225:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","allCardsLoaded","Z",value);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[1]);f.Pc=229;continue;}
case 229:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=230;continue;}
case 230:{f.Pc=240;continue;}
case 233:{f.Locals[6]=f.Pop();f.Pc=235;continue;}
case 235:{f.Push(f.Locals[1]);f.Pc=236;continue;}
case 236:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=237;continue;}
case 237:{f.Push(f.Locals[6]);f.Pc=239;continue;}
case 239:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 240:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M94(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getPreInitName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardDb","getRules","(Ljava/lang/String;Z)Lforge/card/CardRules;","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Reference!=null?29:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/CardDb","getRules","(Ljava/lang/String;Z)Lforge/card/CardRules;","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Reference==null?30:29;continue;}
case 29:{return JStep.ReturnVoid;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","loadNonLegalCards","Z"));f.Pc=34;continue;}
case 34:{f.Pc=f.Pop().Int!=0?71:37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","funnyCards","Ljava/util/Set;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",47);}
case 47:{f.Pc=f.Pop().Int==0?71:50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int!=0?71:60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","filtered","Ljava/util/Set;"));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/card/CardRules","isVariant","()Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int==0?91:78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(null));f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/card/CardDb","loadCard","(Ljava/lang/String;Ljava/lang/String;Lforge/card/CardRules;)V","invokevirtual",88);}
case 88:{f.Pc=101;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=95;continue;}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(null));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/card/CardDb","loadCard","(Ljava/lang/String;Ljava/lang/String;Lforge/card/CardRules;)V","invokevirtual",101);}
case 101:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M95(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","customCardReader","Lforge/CardStorageReader;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","customCardReader","Lforge/CardStorageReader;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/CardStorageReader","loadCards","()Ljava/lang/Iterable;","invokevirtual",15);}
case 15:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",20);}
case 20:{f.Locals[1]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?94:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[2]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(JValue.R(null));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?48:45;continue;}
case 45:{f.Pc=21;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/card/CardRules","setCustom","()V","invokevirtual",57);}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/card/CardRules","isVariant","()Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?79:64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantRules","Ljava/util/Map;"));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Pc=91;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","regularRules","Ljava/util/Map;"));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Pc=21;continue;}
case 94:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M96(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","cardReader","Lforge/CardStorageReader;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/CardStorageReader","isLoadingCardsLazily","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?11:10;continue;}
case 10:{return JStep.ReturnVoid;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadLock","Ljava/lang/Object;"));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/CardDb","clearLoadedCards","()V","invokevirtual",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/card/CardDb","clearLoadedCards","()V","invokevirtual",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","missingLazyCards","Ljava/util/Set;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Set","clear","()V","invokeinterface",41);}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","filtered","Ljava/util/Set;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Set","clear","()V","invokeinterface",50);}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","allCardsLoaded","Z",value);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","customCardReader","Lforge/CardStorageReader;"));f.Pc=59;continue;}
case 59:{f.Pc=f.Pop().Reference==null?128:62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=67;continue;}
case 67:{f.Push(JValue.I(1));f.Pc=68;continue;}
case 68:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=69;continue;}
case 69:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/StaticData","loadCustomCards","()V","invokevirtual",76);}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=80;continue;}
case 80:{f.Push(JValue.I(0));f.Pc=81;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","enableUnknownCards","Z"));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/card/CardDb","initialize","(ZZZ)V","invokevirtual",89);}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=93;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","enableUnknownCards","Z"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/card/CardDb","initialize","(ZZZ)V","invokevirtual",102);}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.StackOp("dup");f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=107;continue;}
case 107:{f.Push(JValue.I(1));f.Pc=108;continue;}
case 108:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=109;continue;}
case 109:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=112;continue;}
case 112:{f.Pc=128;continue;}
case 115:{f.Locals[2]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.StackOp("dup");f.Pc=118;continue;}
case 118:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=121;continue;}
case 121:{f.Push(JValue.I(1));f.Pc=122;continue;}
case 122:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=123;continue;}
case 123:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=130;continue;}
case 130:{f.Pc=138;continue;}
case 133:{f.Locals[3]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=136;continue;}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 138:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M97(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?21:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?21:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","cardReader","Lforge/CardStorageReader;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/CardStorageReader","isLoadingCardsLazily","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?23:21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadLock","Ljava/lang/Object;"));f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=34;continue;}
case 34:{f.Pc=f.Pop().Int<=0?41:37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=40;continue;}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"java/util/Locale","ROOT","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","ROOT","Ljava/util/Locale;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","toLowerCase","(Ljava/util/Locale;)Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","missingLazyCards","Ljava/util/Set;"));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",61);}
case 61:{f.Pc=f.Pop().Int==0?68:64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/StaticData","attemptToLoadCard","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",74);}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=79;continue;}
case 79:{f.Push(JValue.I(1));f.Pc=80;continue;}
case 80:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=81;continue;}
case 81:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/card/CardDb","getRules","(Ljava/lang/String;Z)Lforge/card/CardRules;","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Reference!=null?108:96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/card/CardDb","getRules","(Ljava/lang/String;Z)Lforge/card/CardRules;","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Reference==null?126:108;continue;}
case 108:{f.Push(JValue.I(1));f.Pc=109;continue;}
case 109:{f.Locals[5]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.StackOp("dup");f.Pc=113;continue;}
case 113:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=116;continue;}
case 116:{f.Push(JValue.I(1));f.Pc=117;continue;}
case 117:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=118;continue;}
case 118:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[3]);f.Pc=122;continue;}
case 122:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=123;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","missingLazyCards","Ljava/util/Set;"));f.Pc=130;continue;}
case 130:{f.Push(f.Locals[4]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",137);}
case 137:{f.StackOp("pop");f.Pc=138;continue;}
case 138:{f.Push(JValue.I(0));f.Pc=139;continue;}
case 139:{f.Locals[5]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.StackOp("dup");f.Pc=143;continue;}
case 143:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=146;continue;}
case 146:{f.Push(JValue.I(1));f.Pc=147;continue;}
case 147:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=148;continue;}
case 148:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[3]);f.Pc=152;continue;}
case 152:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[5]);f.Pc=155;continue;}
case 155:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 156:{f.Locals[6]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.StackOp("dup");f.Pc=160;continue;}
case 160:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=163;continue;}
case 163:{f.Push(JValue.I(1));f.Pc=164;continue;}
case 164:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=165;continue;}
case 165:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[6]);f.Pc=170;continue;}
case 170:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 171:{f.Locals[7]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[3]);f.Pc=174;continue;}
case 174:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=175;continue;}
case 175:{f.Push(f.Locals[7]);f.Pc=177;continue;}
case 177:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M98(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadLock","Ljava/lang/Object;"));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/StaticData","attemptToLoadCardInner","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=33;continue;}
case 33:{f.Pc=51;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.StackOp("dup");f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","lazyLoadDepth","I"));f.Pc=43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=45;continue;}
case 45:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","lazyLoadDepth","I",value);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=53;continue;}
case 53:{f.Pc=63;continue;}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 63:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M99(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardDb","getRules","(Ljava/lang/String;Z)Lforge/card/CardRules;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference!=null?24:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardDb","getRules","(Ljava/lang/String;Z)Lforge/card/CardRules;","invokevirtual",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference!=null?37:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","cardReader","Lforge/CardStorageReader;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/CardStorageReader","attemptToLoadCard","(Ljava/lang/String;)Lforge/card/CardRules;","invokevirtual",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Reference!=null?42:41;continue;}
case 41:{return JStep.ReturnVoid;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/CardRules","getPlaceholderFaceNames","()Ljava/util/Collection;","invokevirtual",46);}
case 46:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",51);}
case 51:{f.Locals[4]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",60);}
case 60:{f.Pc=f.Pop().Int==0?131:63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{f.Locals[5]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","placeholderFacesInProgress","Ljava/util/Set;"));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",86);}
case 86:{f.Pc=f.Pop().Int==0?128:89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[5]);f.Pc=92;continue;}
case 92:{f.Push(JValue.R(null));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/StaticData","attemptToLoadCard","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",96);}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","placeholderFacesInProgress","Ljava/util/Set;"));f.Pc=100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",107);}
case 107:{f.StackOp("pop");f.Pc=108;continue;}
case 108:{f.Pc=128;continue;}
case 111:{f.Locals[6]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","placeholderFacesInProgress","Ljava/util/Set;"));f.Pc=117;continue;}
case 117:{f.Push(f.Locals[5]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Push(f.Locals[6]);f.Pc=127;continue;}
case 127:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 128:{f.Pc=53;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","loadNonLegalCards","Z"));f.Pc=135;continue;}
case 135:{f.Pc=f.Pop().Int!=0?178:138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","funnyCards","Ljava/util/Set;"));f.Pc=142;continue;}
case 142:{f.Push(f.Locals[3]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/card/CardRules","getPreInitName","()Ljava/lang/String;","invokevirtual",146);}
case 146:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",151);}
case 151:{f.Pc=f.Pop().Int==0?178:154;continue;}
case 154:{f.Push(f.Locals[3]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",158);}
case 158:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",161);}
case 161:{f.Pc=f.Pop().Int!=0?178:164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","filtered","Ljava/util/Set;"));f.Pc=168;continue;}
case 168:{f.Push(f.Locals[3]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/card/CardRules","getPreInitName","()Ljava/lang/String;","invokevirtual",172);}
case 172:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",177);}
case 177:{f.StackOp("pop");f.Pc=178;continue;}
case 178:{f.Push(f.Locals[3]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/card/CardRules","isVariant","()Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int==0?198:185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=189;continue;}
case 189:{f.Push(f.Locals[1]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[2]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[3]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/card/CardDb","loadCard","(Ljava/lang/String;Ljava/lang/String;Lforge/card/CardRules;)V","invokevirtual",195);}
case 195:{f.Pc=208;continue;}
case 198:{f.Push(f.Locals[0]);f.Pc=199;continue;}
case 199:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=202;continue;}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[2]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[3]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/card/CardDb","loadCard","(Ljava/lang/String;Ljava/lang/String;Lforge/card/CardRules;)V","invokevirtual",208);}
case 208:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M100(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/StaticData","fetchCard","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M101(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/StaticData","getAvailableDatabases","()Ljava/util/Map;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",12);}
case 12:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[5]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[5]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?62:29;continue;}
case 29:{f.Push(f.Locals[5]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardDb"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[6]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[6]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",49);}
case 49:{f.Locals[4]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{f.Pc=f.Pop().Reference==null?59:56;continue;}
case 56:{f.Pc=62;continue;}
case 59:{f.Pc=19;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M102(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",4);}
case 4:{f.Locals[6]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[6]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[6]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","isFoil","Z"));f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Int!=0?21:16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Int==0?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$CardRequest","isFoil","Z",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[6]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/StaticData","matchTargetCardDb","(Ljava/lang/String;)Lforge/card/CardDb;","invokevirtual",38);}
case 38:{f.Locals[7]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[7]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Reference!=null?47:45;continue;}
case 45:{f.Push(JValue.R(null));f.Pc=46;continue;}
case 46:{return JStep.Return(f.Pop());}
case 47:{f.Push(f.Locals[7]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[6]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","isFoil","Z"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/card/CardDb","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;Ljava/lang/String;Z)Lforge/item/PaperCard;","invokevirtual",60);}
case 60:{f.Locals[8]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[8]);f.Pc=64;continue;}
case 64:{f.Pc=f.Pop().Reference!=null?133:67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int!=0?133:77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{f.Push(JValue.I(-1));f.Pc=80;continue;}
case 80:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?114:83;continue;}
case 83:{f.Push(f.Locals[7]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/card/CardDb","getMaxArtIndex","(Ljava/lang/String;)I","invokevirtual",89);}
case 89:{f.Locals[9]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[9]);f.Pc=95;continue;}
case 95:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?114:98;continue;}
case 98:{f.Push(f.Locals[7]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[4]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","isFoil","Z"));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/card/CardDb","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;IZ)Lforge/item/PaperCard;","invokevirtual",112);}
case 112:{f.Locals[8]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[8]);f.Pc=116;continue;}
case 116:{f.Pc=f.Pop().Reference!=null?133:119;continue;}
case 119:{f.Push(f.Locals[7]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","isFoil","Z"));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/card/CardDb","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;Z)Lforge/item/PaperCard;","invokevirtual",131);}
case 131:{f.Locals[8]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[8]);f.Pc=135;continue;}
case 135:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M103(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",4);}
case 4:{f.Locals[6]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[6]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","isFoil","Z"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int!=0?18:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[6]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/StaticData","matchTargetCardDb","(Ljava/lang/String;)Lforge/card/CardDb;","invokevirtual",33);}
case 33:{f.Locals[7]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[7]);f.Pc=37;continue;}
case 37:{f.Pc=f.Pop().Reference!=null?42:40;continue;}
case 40:{f.Push(JValue.R(null));f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
case 42:{f.Push(JValue.R(null));f.Pc=43;continue;}
case 43:{f.Locals[8]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Pc=f.Pop().Reference==null?59:50;continue;}
case 50:{f.Push(f.Locals[7]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/card/CardDb","isLegal","(Ljava/util/Collection;)Ljava/util/function/Predicate;","invokevirtual",57);}
case 57:{f.Locals[8]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",64);}
case 64:{f.Locals[10]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Reference==null?105:71;continue;}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[10]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[8]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/card/CardDb","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;Ljava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",83);}
case 83:{f.Locals[9]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[9]);f.Pc=87;continue;}
case 87:{f.Pc=f.Pop().Reference!=null?117:90;continue;}
case 90:{f.Push(f.Locals[7]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[10]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[8]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/card/CardDb","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",100);}
case 100:{f.Locals[9]=f.Pop();f.Pc=102;continue;}
case 102:{f.Pc=117;continue;}
case 105:{f.Push(f.Locals[7]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[10]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[8]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/card/CardDb","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",115);}
case 115:{f.Locals[9]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[9]);f.Pc=119;continue;}
case 119:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M104(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/StaticData","getAvailableDatabases","()Ljava/util/Map;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?47:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardDb"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/CardDb","contains","(Ljava/lang/String;)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?44:42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
case 44:{f.Pc=15;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M105(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?14:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/card/CardDb","contains","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int!=0?49:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/CardDb","contains","(Ljava/lang/String;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?53:49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{f.Pc=54;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M106(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","tournaments","Lforge/util/storage/IStorage;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?42:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/util/storage/StorageBase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/storage/StorageBase")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Starter sets")));f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"forge/item/SealedTemplate$Reader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/SealedTemplate$Reader")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","blockDataFolder","Ljava/lang/String;"));f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("starters.txt")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",33);}
case 33:{return rt.Call(f,"forge/item/SealedTemplate$Reader","<init>","(Ljava/io/File;)V","invokespecial",36);}
case 36:{return rt.Call(f,"forge/util/storage/StorageBase","<init>","(Ljava/lang/String;Lforge/util/IItemReader;)V","invokespecial",39);}
case 39:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","tournaments","Lforge/util/storage/IStorage;",value);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","tournaments","Lforge/util/storage/IStorage;"));f.Pc=46;continue;}
case 46:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M107(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","boosters","Lforge/util/storage/IStorage;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?28:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/util/storage/StorageBase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/storage/StorageBase")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Boosters")));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/CardEdition$Collection","getBoosterGenerator","()Lforge/util/IItemReader;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/util/storage/StorageBase","<init>","(Ljava/lang/String;Lforge/util/IItemReader;)V","invokespecial",25);}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","boosters","Lforge/util/storage/IStorage;",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","boosters","Lforge/util/storage/IStorage;"));f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M108(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","specialBoosters","Lforge/util/storage/IStorage;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?42:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/util/storage/StorageBase"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/storage/StorageBase")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Special boosters")));f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"forge/item/SealedTemplate$Reader"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/SealedTemplate$Reader")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","blockDataFolder","Ljava/lang/String;"));f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("boosters-special.txt")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",33);}
case 33:{return rt.Call(f,"forge/item/SealedTemplate$Reader","<init>","(Ljava/io/File;)V","invokespecial",36);}
case 36:{return rt.Call(f,"forge/util/storage/StorageBase","<init>","(Ljava/lang/String;Lforge/util/IItemReader;)V","invokespecial",39);}
case 39:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","specialBoosters","Lforge/util/storage/IStorage;",value);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","specialBoosters","Lforge/util/storage/IStorage;"));f.Pc=46;continue;}
case 46:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M109(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","printSheets","Lforge/util/storage/IStorage;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?32:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/io/File"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/io/File")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","blockDataFolder","Ljava/lang/String;"));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("printsheets.txt")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/io/File","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/card/PrintSheet","initializePrintSheets","(Ljava/io/File;Lforge/card/CardEdition$Collection;)Lforge/util/storage/IStorage;","invokestatic",29);}
case 29:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","printSheets","Lforge/util/storage/IStorage;",value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","printSheets","Lforge/util/storage/IStorage;"));f.Pc=36;continue;}
case 36:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M110(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M111(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M112(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/LinkedHashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Common")));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Variant")));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M113(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","allTokens","Lforge/token/TokenDb;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M114(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","allowCustomCardsInDecksConformance","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M115(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","standardPredicate","Ljava/util/function/Predicate;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M116(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","pioneerPredicate","Ljava/util/function/Predicate;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M117(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","modernPredicate","Ljava/util/function/Predicate;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M118(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","commanderPredicate","Ljava/util/function/Predicate;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M119(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","oathbreakerPredicate","Ljava/util/function/Predicate;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M120(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","brawlPredicate","Ljava/util/function/Predicate;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M121(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","standardPredicate","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M122(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","pioneerPredicate","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M123(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","modernPredicate","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M124(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commanderPredicate","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M125(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","oathbreakerPredicate","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M126(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","brawlPredicate","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M127(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/StaticData","cardArtPreferenceIsLatest","()Z","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/StaticData","isCoreExpansionOnlyFilterSet","()Z","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(null));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/StaticData","getAlternativeCardPrint","(Lforge/item/PaperCard;Ljava/util/Date;ZZLjava/util/List;)Lforge/item/PaperCard;","invokevirtual",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M128(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/StaticData","getReferenceDate","(Ljava/util/Date;Z)Ljava/util/Date;","invokevirtual",6);}
case 6:{f.Locals[6]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/StaticData","getSearchStrategyForAlternativeCardArt","(ZZ)Lforge/card/CardDb$CardArtPreference;","invokevirtual",15);}
case 15:{f.Locals[7]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[6]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[7]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/StaticData","searchAlternativeCardCandidate","(Lforge/item/PaperCard;ZLjava/util/Date;Lforge/card/CardDb$CardArtPreference;Ljava/util/List;)Lforge/item/PaperCard;","invokevirtual",29);}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M129(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[6]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/StaticData","getAlternativeCardPrint","(Lforge/item/PaperCard;Ljava/util/Date;ZZZZLjava/util/List;)Lforge/item/PaperCard;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M130(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[6]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[7]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/StaticData","getAlternativeCardPrint","(Lforge/item/PaperCard;Ljava/util/Date;ZZZZLjava/util/List;Lforge/card/CardEdition$BorderColor;)Lforge/item/PaperCard;","invokevirtual",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M131(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?36:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[7]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[8]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/StaticData","findClosestBasicLandPrint","(Lforge/item/PaperCard;Ljava/util/Date;ZZLjava/util/List;Lforge/card/CardEdition$BorderColor;)Lforge/item/PaperCard;","invokevirtual",26);}
case 26:{f.Locals[9]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[9]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference==null?36:33;continue;}
case 33:{f.Push(f.Locals[9]);f.Pc=35;continue;}
case 35:{return JStep.Return(f.Pop());}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[5]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[6]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[7]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/StaticData","getAlternativeCardPrintByDate","(Lforge/item/PaperCard;Ljava/util/Date;ZZZZLjava/util/List;)Lforge/item/PaperCard;","invokevirtual",51);}
case 51:{f.Locals[9]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[8]);f.Pc=55;continue;}
case 55:{f.Pc=f.Pop().Reference!=null?61:58;continue;}
case 58:{f.Push(f.Locals[9]);f.Pc=60;continue;}
case 60:{return JStep.Return(f.Pop());}
case 61:{f.Push(f.Locals[9]);f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Reference==null?71:66;continue;}
case 66:{f.Push(f.Locals[9]);f.Pc=68;continue;}
case 68:{f.Pc=72;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Locals[10]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[10]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[8]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/StaticData","hasBorder","(Lforge/item/PaperCard;Lforge/card/CardEdition$BorderColor;)Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?88:85;continue;}
case 85:{f.Push(f.Locals[9]);f.Pc=87;continue;}
case 87:{return JStep.Return(f.Pop());}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[8]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[7]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/StaticData","findClosestPrintWithBorder","(Lforge/item/PaperCard;Ljava/util/Date;Lforge/card/CardEdition$BorderColor;ZZLjava/util/List;)Lforge/item/PaperCard;","invokevirtual",101);}
case 101:{f.Locals[11]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[11]);f.Pc=105;continue;}
case 105:{f.Pc=f.Pop().Reference!=null?146:108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/StaticData","isStrictBlackBorder","(Lforge/card/CardEdition$BorderColor;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?146:117;continue;}
case 117:{f.Push(f.Locals[7]);f.Pc=119;continue;}
case 119:{f.Pc=f.Pop().Reference==null?146:122;continue;}
case 122:{f.Push(f.Locals[7]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",129);}
case 129:{f.Pc=f.Pop().Int!=0?146:132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[8]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[4]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(null));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/StaticData","findClosestPrintWithBorder","(Lforge/item/PaperCard;Ljava/util/Date;Lforge/card/CardEdition$BorderColor;ZZLjava/util/List;)Lforge/item/PaperCard;","invokevirtual",144);}
case 144:{f.Locals[11]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[11]);f.Pc=148;continue;}
case 148:{f.Pc=f.Pop().Reference!=null?154:151;continue;}
case 151:{f.Push(f.Locals[9]);f.Pc=153;continue;}
case 153:{return JStep.Return(f.Pop());}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[8]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/StaticData","isStrictBlackBorder","(Lforge/card/CardEdition$BorderColor;)Z","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int!=0?195:163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[11]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[2]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/StaticData","distanceToDate","(Lforge/item/PaperCard;Ljava/util/Date;)J","invokevirtual",170);}
case 170:{f.Push(JValue.L(126144000000L));f.Pc=173;continue;}
case 173:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=174;continue;}
case 174:{f.Pc=f.Pop().Int<=0?195:177;continue;}
case 177:{f.Push(f.Locals[0]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[11]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/StaticData","distanceToDate","(Lforge/item/PaperCard;Ljava/util/Date;)J","invokevirtual",184);}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[10]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[2]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/StaticData","distanceToDate","(Lforge/item/PaperCard;Ljava/util/Date;)J","invokevirtual",191);}
case 191:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=192;continue;}
case 192:{f.Pc=f.Pop().Int>0?198:195;continue;}
case 195:{f.Push(f.Locals[11]);f.Pc=197;continue;}
case 197:{return JStep.Return(f.Pop());}
case 198:{f.Push(f.Locals[9]);f.Pc=200;continue;}
case 200:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M132(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/StaticData","cardArtPreferenceIsBlackBorder","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M133(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference==null?23:16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Reference!=null?27:23;continue;}
case 23:{f.Push(JValue.L(9223372036854775807L));f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",31);}
case 31:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",34);}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",38);}
case 38:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/Math","abs","(J)J","invokestatic",42);}
case 42:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M134(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[5]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/StaticData","findClosestPrintWithBorder","(Lforge/item/PaperCard;Ljava/util/Date;Lforge/card/CardEdition$BorderColor;ZZLjava/util/List;)Lforge/item/PaperCard;","invokevirtual",12);}
case 12:{f.Locals[7]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[6]);f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Reference!=null?22:19;continue;}
case 19:{f.Push(f.Locals[7]);f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[6]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/StaticData","findClosestPrintWithBorder","(Lforge/item/PaperCard;Ljava/util/Date;Lforge/card/CardEdition$BorderColor;ZZLjava/util/List;)Lforge/item/PaperCard;","invokevirtual",35);}
case 35:{f.Locals[8]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[8]);f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Reference!=null?80:42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/StaticData","isStrictBlackBorder","(Lforge/card/CardEdition$BorderColor;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?80:51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{f.Pc=f.Pop().Reference==null?80:56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int!=0?80:66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[6]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(null));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/StaticData","findClosestPrintWithBorder","(Lforge/item/PaperCard;Ljava/util/Date;Lforge/card/CardEdition$BorderColor;ZZLjava/util/List;)Lforge/item/PaperCard;","invokevirtual",78);}
case 78:{f.Locals[8]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[8]);f.Pc=82;continue;}
case 82:{f.Pc=f.Pop().Reference==null?134:85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{f.Pc=f.Pop().Reference==null?131:90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/StaticData","isStrictBlackBorder","(Lforge/card/CardEdition$BorderColor;)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int!=0?131:99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[8]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/StaticData","distanceToDate","(Lforge/item/PaperCard;Ljava/util/Date;)J","invokevirtual",106);}
case 106:{f.Push(JValue.L(126144000000L));f.Pc=109;continue;}
case 109:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=110;continue;}
case 110:{f.Pc=f.Pop().Int<=0?131:113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[8]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/StaticData","distanceToDate","(Lforge/item/PaperCard;Ljava/util/Date;)J","invokevirtual",120);}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[7]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/StaticData","distanceToDate","(Lforge/item/PaperCard;Ljava/util/Date;)J","invokevirtual",127);}
case 127:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=128;continue;}
case 128:{f.Pc=f.Pop().Int>0?134:131;continue;}
case 131:{f.Push(f.Locals[8]);f.Pc=133;continue;}
case 133:{return JStep.Return(f.Pop());}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M135(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Reference!=null?24:22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/card/CardEdition","getBorderColor","()Lforge/card/CardEdition$BorderColor;","invokevirtual",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"));f.Pc=35;continue;}
case 35:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?46:38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","WHITE","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","WHITE","Lforge/card/CardEdition$BorderColor;"));f.Pc=43;continue;}
case 43:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?56:46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?56:52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{f.Pc=57;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M136(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/StaticData","hasBorderMismatch","(Lforge/item/PaperCard;Lforge/card/CardEdition$BorderColor;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?13:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M137(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[4]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[5]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/StaticData","getCardArtPreference","(ZZ)Lforge/card/CardDb$CardArtPreference;","invokevirtual",8);}
case 8:{f.Locals[7]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{f.Locals[8]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[6]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference==null?39:18;continue;}
case 18:{f.Push(f.Locals[6]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int!=0?39:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/card/CardDb","isLegal","(Ljava/util/Collection;)Ljava/util/function/Predicate;","invokevirtual",37);}
case 37:{f.Locals[8]=f.Pop();f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",46);}
case 46:{f.Locals[9]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",56);}
case 56:{return rt.Call(f,"forge/card/CardDb","getAllCardsNoAlt","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",59);}
case 59:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",64);}
case 64:{f.Locals[10]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[10]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",73);}
case 73:{f.Pc=f.Pop().Int==0?178:76;continue;}
case 76:{f.Push(f.Locals[10]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{f.Locals[11]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[11]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/item/PaperCard","getRarity","()Lforge/card/CardRarity;","invokevirtual",93);}
case 93:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=96;continue;}
case 96:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?102:99;continue;}
case 99:{f.Pc=66;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=106;continue;}
case 106:{f.Push(f.Locals[11]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",111);}
case 111:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",114);}
case 114:{f.Locals[12]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[12]);f.Pc=118;continue;}
case 118:{f.Pc=f.Pop().Reference==null?66:121;continue;}
case 121:{f.Push(f.Locals[12]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Reference==null?66:129;continue;}
case 129:{f.Push(f.Locals[3]);f.Pc=130;continue;}
case 130:{f.Pc=f.Pop().Reference==null?145:133;continue;}
case 133:{f.Push(f.Locals[12]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/card/CardEdition","getBorderColor","()Lforge/card/CardEdition$BorderColor;","invokevirtual",138);}
case 138:{f.Push(f.Locals[3]);f.Pc=139;continue;}
case 139:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?145:142;continue;}
case 142:{f.Pc=66;continue;}
case 145:{f.Push(f.Locals[8]);f.Pc=147;continue;}
case 147:{f.Pc=f.Pop().Reference==null?165:150;continue;}
case 150:{f.Push(f.Locals[8]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[11]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",159);}
case 159:{f.Pc=f.Pop().Int!=0?165:162;continue;}
case 162:{f.Pc=66;continue;}
case 165:{f.Push(f.Locals[9]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[11]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",174);}
case 174:{f.StackOp("pop");f.Pc=175;continue;}
case 175:{f.Pc=66;continue;}
case 178:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=181;continue;}
case 181:{f.StackOp("dup");f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",185);}
case 185:{f.Locals[10]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[9]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",194);}
case 194:{f.Locals[11]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[11]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",203);}
case 203:{f.Pc=f.Pop().Int==0?251:206;continue;}
case 206:{f.Push(f.Locals[11]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",213);}
case 213:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=216;continue;}
case 216:{f.Locals[12]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[7]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[0]);f.Pc=221;continue;}
case 221:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=224;continue;}
case 224:{f.Push(f.Locals[12]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",229);}
case 229:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",232);}
case 232:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","accept","(Lforge/card/CardEdition;)Z","invokevirtual",235);}
case 235:{f.Pc=f.Pop().Int==0?248:238;continue;}
case 238:{f.Push(f.Locals[10]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[12]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",247);}
case 247:{f.StackOp("pop");f.Pc=248;continue;}
case 248:{f.Pc=196;continue;}
case 251:{f.Push(f.Locals[10]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",258);}
case 258:{f.Pc=f.Pop().Int!=0?265:261;continue;}
case 261:{f.Push(f.Locals[10]);f.Pc=263;continue;}
case 263:{f.Locals[9]=f.Pop();f.Pc=265;continue;}
case 265:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=268;continue;}
case 268:{f.StackOp("dup");f.Pc=269;continue;}
case 269:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",272);}
case 272:{f.Locals[11]=f.Pop();f.Pc=274;continue;}
case 274:{f.Push(f.Locals[9]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",281);}
case 281:{f.Locals[12]=f.Pop();f.Pc=283;continue;}
case 283:{f.Push(f.Locals[12]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",290);}
case 290:{f.Pc=f.Pop().Int==0?350:293;continue;}
case 293:{f.Push(f.Locals[12]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",300);}
case 300:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=303;continue;}
case 303:{f.Locals[13]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[13]);f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",310);}
case 310:{f.Push(f.Locals[1]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",314);}
case 314:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?337:317;continue;}
case 317:{f.Push(f.Locals[13]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",322);}
case 322:{f.Push(JValue.I(1));f.Pc=323;continue;}
case 323:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?337:326;continue;}
case 326:{f.Push(f.Locals[1]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",330);}
case 330:{f.Push(JValue.I(1));f.Pc=331;continue;}
case 331:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?337:334;continue;}
case 334:{f.Pc=283;continue;}
case 337:{f.Push(f.Locals[11]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[13]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",346);}
case 346:{f.StackOp("pop");f.Pc=347;continue;}
case 347:{f.Pc=283;continue;}
case 350:{f.Push(f.Locals[7]);f.Pc=352;continue;}
case 352:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","blackBorderOnly","Z"));f.Pc=355;continue;}
case 355:{f.Pc=f.Pop().Int==0?443:358;continue;}
case 358:{f.Push(JValue.I(2147483647));f.Pc=361;continue;}
case 361:{f.Locals[12]=f.Pop();f.Pc=363;continue;}
case 363:{f.Push(f.Locals[11]);f.Pc=365;continue;}
case 365:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",370);}
case 370:{f.Locals[13]=f.Pop();f.Pc=372;continue;}
case 372:{f.Push(f.Locals[13]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",379);}
case 379:{f.Pc=f.Pop().Int==0?421:382;continue;}
case 382:{f.Push(f.Locals[13]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",389);}
case 389:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=392;continue;}
case 392:{f.Locals[14]=f.Pop();f.Pc=394;continue;}
case 394:{f.Push(f.Locals[12]);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[7]);f.Pc=398;continue;}
case 398:{f.Push(f.Locals[0]);f.Pc=399;continue;}
case 399:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=402;continue;}
case 402:{f.Push(f.Locals[14]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",407);}
case 407:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",410);}
case 410:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","getEditionRank","(Lforge/card/CardEdition;)I","invokevirtual",413);}
case 413:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",416);}
case 416:{f.Locals[12]=f.Pop();f.Pc=418;continue;}
case 418:{f.Pc=372;continue;}
case 421:{f.Push(f.Locals[12]);f.Pc=423;continue;}
case 423:{f.Locals[13]=f.Pop();f.Pc=425;continue;}
case 425:{f.Push(f.Locals[11]);f.Pc=427;continue;}
case 427:{f.Push(f.Locals[0]);f.Pc=428;continue;}
case 428:{f.Push(f.Locals[7]);f.Pc=430;continue;}
case 430:{f.Push(f.Locals[13]);f.Pc=432;continue;}
case 432:{return rt.DynamicCall(f,"forge/StaticData:137:432:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/StaticData;Lforge/card/CardDb$CardArtPreference;I)Ljava/util/function/Predicate;",437);}
case 437:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",442);}
case 442:{f.StackOp("pop");f.Pc=443;continue;}
case 443:{f.Push(JValue.R(null));f.Pc=444;continue;}
case 444:{f.Locals[12]=f.Pop();f.Pc=446;continue;}
case 446:{f.Push(JValue.L(9223372036854775807L));f.Pc=449;continue;}
case 449:{f.Locals[13]=f.Pop();f.Pc=451;continue;}
case 451:{f.Push(f.Locals[11]);f.Pc=453;continue;}
case 453:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",458);}
case 458:{f.Locals[15]=f.Pop();f.Pc=460;continue;}
case 460:{f.Push(f.Locals[15]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",467);}
case 467:{f.Pc=f.Pop().Int==0?604:470;continue;}
case 470:{f.Push(f.Locals[15]);f.Pc=472;continue;}
case 472:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",477);}
case 477:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=480;continue;}
case 480:{f.Locals[16]=f.Pop();f.Pc=482;continue;}
case 482:{f.Push(f.Locals[0]);f.Pc=483;continue;}
case 483:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=486;continue;}
case 486:{f.Push(f.Locals[16]);f.Pc=488;continue;}
case 488:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",491);}
case 491:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",494);}
case 494:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",497);}
case 497:{f.Locals[17]=f.Pop();f.Pc=499;continue;}
case 499:{f.Push(f.Locals[17]);f.Pc=501;continue;}
case 501:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",504);}
case 504:{f.Push(f.Locals[2]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",508);}
case 508:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=509;continue;}
case 509:{return rt.Call(f,"java/lang/Math","abs","(J)J","invokestatic",512);}
case 512:{f.Locals[18]=f.Pop();f.Pc=514;continue;}
case 514:{f.Push(f.Locals[18]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[13]);f.Pc=518;continue;}
case 518:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=519;continue;}
case 519:{f.Pc=f.Pop().Int>=0?526:522;continue;}
case 522:{f.Push(JValue.I(1));f.Pc=523;continue;}
case 523:{f.Pc=527;continue;}
case 526:{f.Push(JValue.I(0));f.Pc=527;continue;}
case 527:{f.Locals[20]=f.Pop();f.Pc=529;continue;}
case 529:{f.Push(f.Locals[20]);f.Pc=531;continue;}
case 531:{f.Pc=f.Pop().Int!=0?588:534;continue;}
case 534:{f.Push(f.Locals[18]);f.Pc=536;continue;}
case 536:{f.Push(f.Locals[13]);f.Pc=538;continue;}
case 538:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=539;continue;}
case 539:{f.Pc=f.Pop().Int!=0?588:542;continue;}
case 542:{f.Push(f.Locals[12]);f.Pc=544;continue;}
case 544:{f.Pc=f.Pop().Reference==null?588:547;continue;}
case 547:{f.Push(f.Locals[0]);f.Pc=548;continue;}
case 548:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=551;continue;}
case 551:{f.Push(f.Locals[12]);f.Pc=553;continue;}
case 553:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",556);}
case 556:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",559);}
case 559:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",562);}
case 562:{f.Locals[21]=f.Pop();f.Pc=564;continue;}
case 564:{f.Push(f.Locals[4]);f.Pc=566;continue;}
case 566:{f.Pc=f.Pop().Int==0?579:569;continue;}
case 569:{f.Push(f.Locals[17]);f.Pc=571;continue;}
case 571:{f.Push(f.Locals[21]);f.Pc=573;continue;}
case 573:{return rt.Call(f,"java/util/Date","after","(Ljava/util/Date;)Z","invokevirtual",576);}
case 576:{f.Pc=586;continue;}
case 579:{f.Push(f.Locals[17]);f.Pc=581;continue;}
case 581:{f.Push(f.Locals[21]);f.Pc=583;continue;}
case 583:{return rt.Call(f,"java/util/Date","before","(Ljava/util/Date;)Z","invokevirtual",586);}
case 586:{f.Locals[20]=f.Pop();f.Pc=588;continue;}
case 588:{f.Push(f.Locals[20]);f.Pc=590;continue;}
case 590:{f.Pc=f.Pop().Int==0?601:593;continue;}
case 593:{f.Push(f.Locals[16]);f.Pc=595;continue;}
case 595:{f.Locals[12]=f.Pop();f.Pc=597;continue;}
case 597:{f.Push(f.Locals[18]);f.Pc=599;continue;}
case 599:{f.Locals[13]=f.Pop();f.Pc=601;continue;}
case 601:{f.Pc=460;continue;}
case 604:{f.Push(f.Locals[12]);f.Pc=606;continue;}
case 606:{f.Pc=f.Pop().Reference!=null?611:609;continue;}
case 609:{f.Push(JValue.R(null));f.Pc=610;continue;}
case 610:{return JStep.Return(f.Pop());}
case 611:{f.Push(f.Locals[0]);f.Pc=612;continue;}
case 612:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=615;continue;}
case 615:{f.Push(f.Locals[12]);f.Pc=617;continue;}
case 617:{return rt.Call(f,"forge/card/CardDb","getTraditionalFramePrint","(Lforge/item/PaperCard;)Lforge/item/PaperCard;","invokevirtual",620);}
case 620:{f.Locals[12]=f.Pop();f.Pc=622;continue;}
case 622:{f.Push(f.Locals[1]);f.Pc=623;continue;}
case 623:{return rt.Call(f,"forge/item/PaperCard","isFoil","()Z","invokevirtual",626);}
case 626:{f.Pc=f.Pop().Int==0?637:629;continue;}
case 629:{f.Push(f.Locals[12]);f.Pc=631;continue;}
case 631:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",634);}
case 634:{f.Pc=639;continue;}
case 637:{f.Push(f.Locals[12]);f.Pc=639;continue;}
case 639:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M138(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[7]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/StaticData","getAlternativeCardPrint","(Lforge/item/PaperCard;Ljava/util/Date;ZZLjava/util/List;)Lforge/item/PaperCard;","invokevirtual",11);}
case 11:{f.Locals[8]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[8]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference!=null?21:18;continue;}
case 18:{f.Push(f.Locals[8]);f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/StaticData","getReferenceDate","(Ljava/util/Date;Z)Ljava/util/Date;","invokevirtual",27);}
case 27:{f.Locals[9]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[8]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[7]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/StaticData","tryToGetCardPrintWithMatchingFrame","(Lforge/item/PaperCard;ZZZLjava/util/List;)Lforge/item/PaperCard;","invokevirtual",42);}
case 42:{f.Locals[10]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[10]);f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Reference==null?76:49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[10]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[9]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/StaticData","isOnPreferredSideOfDate","(Lforge/item/PaperCard;Ljava/util/Date;Z)Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?76:61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[10]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[8]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/StaticData","hasWorseEditionRank","(Lforge/item/PaperCard;Lforge/item/PaperCard;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int!=0?76:72;continue;}
case 72:{f.Push(f.Locals[10]);f.Pc=74;continue;}
case 74:{f.Locals[8]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{f.Pc=f.Pop().Int==0?131:81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{f.Pc=f.Pop().Int==0?131:86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[8]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[7]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/StaticData","tryToGetCardPrintFromExpansionSet","(Lforge/item/PaperCard;ZZLjava/util/List;)Lforge/item/PaperCard;","invokevirtual",97);}
case 97:{f.Locals[10]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[10]);f.Pc=101;continue;}
case 101:{f.Pc=f.Pop().Reference==null?131:104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[10]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[9]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/StaticData","isOnPreferredSideOfDate","(Lforge/item/PaperCard;Ljava/util/Date;Z)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?131:116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[10]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[8]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/StaticData","hasWorseEditionRank","(Lforge/item/PaperCard;Lforge/item/PaperCard;)Z","invokevirtual",124);}
case 124:{f.Pc=f.Pop().Int!=0?131:127;continue;}
case 127:{f.Push(f.Locals[10]);f.Pc=129;continue;}
case 129:{f.Locals[8]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[8]);f.Pc=133;continue;}
case 133:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M139(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardDb","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","getEditionRank","(Lforge/card/CardEdition;)I","invokevirtual",23);}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",35);}
case 35:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","getEditionRank","(Lforge/card/CardEdition;)I","invokevirtual",38);}
case 38:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?45:41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{f.Pc=46;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M140(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference==null?26:18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Reference!=null?28:26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Pc=f.Pop().Int==0?52:32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",37);}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Date","before","(Ljava/util/Date;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int!=0?48:44;continue;}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{f.Pc=69;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{f.Pc=69;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",57);}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Date","after","(Ljava/util/Date;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?68:64;continue;}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{f.Pc=69;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M141(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[6]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[5]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference==null?29:8;continue;}
case 8:{f.Push(f.Locals[5]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int!=0?29:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[5]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/card/CardDb","isLegal","(Ljava/util/Collection;)Ljava/util/function/Predicate;","invokevirtual",27);}
case 27:{f.Locals[6]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/CardDb","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokevirtual",36);}
case 36:{f.Locals[7]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[7]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","blackBorderOnly","Z"));f.Pc=43;continue;}
case 43:{f.Pc=f.Pop().Int==0?115:46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{f.Locals[8]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[8]);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(2));f.Pc=52;continue;}
case 52:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?115:55;continue;}
case 55:{f.Push(f.Locals[8]);f.Pc=57;continue;}
case 57:{f.Locals[9]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[7]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[9]);f.Pc=64;continue;}
case 64:{return rt.DynamicCall(f,"forge/StaticData:141:64:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/StaticData;Lforge/card/CardDb$CardArtPreference;I)Ljava/util/function/Predicate;",69);}
case 69:{f.Locals[10]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{f.Pc=f.Pop().Reference!=null?87:82;continue;}
case 82:{f.Push(f.Locals[10]);f.Pc=84;continue;}
case 84:{f.Pc=96;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[10]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",96);}
case 96:{return rt.Call(f,"forge/StaticData","searchAlternativeCardCandidateWithFilter","(Lforge/item/PaperCard;ZLjava/util/Date;Lforge/card/CardDb$CardArtPreference;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",99);}
case 99:{f.Locals[11]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[11]);f.Pc=103;continue;}
case 103:{f.Pc=f.Pop().Reference==null?109:106;continue;}
case 106:{f.Push(f.Locals[11]);f.Pc=108;continue;}
case 108:{return JStep.Return(f.Pop());}
case 109:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=112;continue;}
case 112:{f.Pc=49;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[4]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[6]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/StaticData","searchAlternativeCardCandidateWithFilter","(Lforge/item/PaperCard;ZLjava/util/Date;Lforge/card/CardDb$CardArtPreference;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",126);}
case 126:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M142(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{f.Locals[6]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[7]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",16);}
case 16:{f.Locals[8]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(JValue.R(null));f.Pc=19;continue;}
case 19:{f.Locals[9]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Int==0?63:25;continue;}
case 25:{f.Push(f.Locals[6]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[7]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[8]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/CardDb","getCardFromEditionsReleasedAfter","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",39);}
case 39:{f.Locals[9]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[9]);f.Pc=43;continue;}
case 43:{f.Pc=f.Pop().Reference!=null?98:46;continue;}
case 46:{f.Push(f.Locals[6]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[7]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/card/CardDb","getCardFromEditionsReleasedAfter","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;Ljava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",58);}
case 58:{f.Locals[9]=f.Pop();f.Pc=60;continue;}
case 60:{f.Pc=98;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[7]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[8]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/card/CardDb","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",77);}
case 77:{f.Locals[9]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[9]);f.Pc=81;continue;}
case 81:{f.Pc=f.Pop().Reference!=null?98:84;continue;}
case 84:{f.Push(f.Locals[6]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[7]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[3]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/card/CardDb","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;Ljava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",96);}
case 96:{f.Locals[9]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[9]);f.Pc=100;continue;}
case 100:{f.Pc=f.Pop().Reference!=null?105:103;continue;}
case 103:{f.Push(JValue.R(null));f.Pc=104;continue;}
case 104:{return JStep.Return(f.Pop());}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/item/PaperCard","isFoil","()Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?120:112;continue;}
case 112:{f.Push(f.Locals[9]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",117);}
case 117:{f.Pc=122;continue;}
case 120:{f.Push(f.Locals[9]);f.Pc=122;continue;}
case 122:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M143(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/util/Calendar","getInstance","()Ljava/util/Calendar;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Calendar","setTime","(Ljava/util/Date;)V","invokevirtual",9);}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int==0?23:13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(5));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(-2));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Calendar","add","(II)V","invokevirtual",20);}
case 20:{f.Pc=29;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(5));f.Pc=25;continue;}
case 25:{f.Push(JValue.I(2));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Calendar","add","(II)V","invokevirtual",29);}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Calendar","getTime","()Ljava/util/Date;","invokevirtual",33);}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M144(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int==0?22:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Int==0?15:8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"));f.Pc=11;continue;}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Pc=37;continue;}
case 15:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"));f.Pc=18;continue;}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Pc=37;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Int==0?33:26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","LATEST_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","LATEST_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"));f.Pc=29;continue;}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Pc=37;continue;}
case 33:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","LATEST_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","LATEST_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"));f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M145(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",11);}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[5]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",18);}
case 18:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"));f.Pc=21;continue;}
case 21:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?26:24;continue;}
case 24:{f.Push(JValue.R(null));f.Pc=25;continue;}
case 25:{return JStep.Return(f.Pop());}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?35:31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Pc=36;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?44:40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{f.Pc=45;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{f.Locals[6]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/StaticData","getSearchStrategyForAlternativeCardArt","(ZZ)Lforge/card/CardDb$CardArtPreference;","invokevirtual",54);}
case 54:{f.Locals[7]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Locals[8]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[8]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Reference==null?132:64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[8]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",73);}
case 73:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",76);}
case 76:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",79);}
case 79:{f.Locals[9]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[8]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[9]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[7]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/StaticData","searchAlternativeCardCandidate","(Lforge/item/PaperCard;ZLjava/util/Date;Lforge/card/CardDb$CardArtPreference;Ljava/util/List;)Lforge/item/PaperCard;","invokevirtual",94);}
case 94:{f.Locals[8]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{f.Pc=f.Pop().Reference==null?129:101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[8]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",110);}
case 110:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",113);}
case 113:{f.Locals[10]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[10]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",120);}
case 120:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"));f.Pc=123;continue;}
case 123:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?129:126;continue;}
case 126:{f.Pc=132;continue;}
case 129:{f.Pc=59;continue;}
case 132:{f.Push(f.Locals[8]);f.Pc=134;continue;}
case 134:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M146(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",11);}
case 11:{f.Locals[6]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[6]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardEdition","isModern","()Z","invokevirtual",18);}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{f.Locals[7]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[7]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Int==0?37:35;continue;}
case 35:{f.Push(JValue.R(null));f.Pc=36;continue;}
case 36:{return JStep.Return(f.Pop());}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?47:43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{f.Pc=48;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?56:52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{f.Pc=57;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{f.Locals[8]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[8]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/StaticData","getSearchStrategyForAlternativeCardArt","(ZZ)Lforge/card/CardDb$CardArtPreference;","invokevirtual",66);}
case 66:{f.Locals[9]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Locals[10]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[10]);f.Pc=73;continue;}
case 73:{f.Pc=f.Pop().Reference==null?144:76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[10]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",85);}
case 85:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",88);}
case 88:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",91);}
case 91:{f.Locals[11]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[10]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[11]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[9]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/StaticData","searchAlternativeCardCandidate","(Lforge/item/PaperCard;ZLjava/util/Date;Lforge/card/CardDb$CardArtPreference;Ljava/util/List;)Lforge/item/PaperCard;","invokevirtual",107);}
case 107:{f.Locals[10]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[10]);f.Pc=111;continue;}
case 111:{f.Pc=f.Pop().Reference==null?141:114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=118;continue;}
case 118:{f.Push(f.Locals[10]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",123);}
case 123:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",126);}
case 126:{f.Locals[12]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[12]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/card/CardEdition","isModern","()Z","invokevirtual",133);}
case 133:{f.Push(f.Locals[4]);f.Pc=135;continue;}
case 135:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?141:138;continue;}
case 138:{f.Pc=144;continue;}
case 141:{f.Pc=71;continue;}
case 144:{f.Push(f.Locals[10]);f.Pc=146;continue;}
case 146:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M147(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/StaticData","getAvailableDatabases","()Ljava/util/Map;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?63:26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardDb"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",43);}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/card/CardDb","getArtCount","(Ljava/lang/String;Ljava/lang/String;)I","invokevirtual",50);}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{f.Pc=f.Pop().Int<=0?60:57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 60:{f.Pc=17;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M148(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","filteredHandsEnabled","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M149(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","filteredHandsEnabled","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M150(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","mulliganRule","Lforge/MulliganDefs$MulliganRule;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M151(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","mulliganRule","Lforge/MulliganDefs$MulliganRule;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M152(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardDb","setCardArtPreference","(ZZ)V","invokevirtual",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardDb","setCardArtPreference","(ZZ)V","invokevirtual",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M153(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardDb","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","toString","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M154(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardDb","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M155(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Int!=0?17:6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/StaticData","cardArtPreferenceIsBlackBorder","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","of","(ZZZ)Lforge/card/CardDb$CardArtPreference;","invokestatic",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M156(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardDb","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokevirtual",7);}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","blackBorderOnly","Z"));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M157(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardDb","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokevirtual",7);}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","filterSets","Z"));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M158(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardDb","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;","invokevirtual",7);}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","latestFirst","Z"));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M159(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","values","()[Lforge/card/CardDb$CardArtPreference;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=15;continue;}
case 15:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?34:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/StaticData","prettifyCardArtPreferenceName","(Lforge/card/CardDb$CardArtPreference;)Ljava/lang/String;","invokevirtual",27);}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=31;continue;}
case 31:{f.Pc=12;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M160(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/StaticData","audit","(Ljava/lang/StringBuffer;Ljava/lang/StringBuffer;Ljava/util/function/IntConsumer;)Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M161(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentLinkedQueue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentLinkedQueue")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/concurrent/ConcurrentLinkedQueue","<init>","()V","invokespecial",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentLinkedQueue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentLinkedQueue")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/concurrent/ConcurrentLinkedQueue","<init>","()V","invokespecial",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentLinkedQueue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentLinkedQueue")));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/concurrent/ConcurrentLinkedQueue","<init>","()V","invokespecial",25);}
case 25:{f.Locals[6]=f.Pop();f.Pc=27;continue;}
case 27:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentLinkedQueue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentLinkedQueue")));f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/concurrent/ConcurrentLinkedQueue","<init>","()V","invokespecial",34);}
case 34:{f.Locals[7]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{f.Locals[8]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{f.Locals[9]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("^F\u2605?\\d+\u2605?")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",48);}
case 48:{f.Locals[10]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{f.Locals[11]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/card/CardEdition$Collection","iterator","()Ljava/util/Iterator;","invokevirtual",60);}
case 60:{f.Locals[12]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[12]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",69);}
case 69:{f.Pc=f.Pop().Int==0?175:72;continue;}
case 72:{f.Push(f.Locals[12]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{f.Locals[13]=f.Pop();f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","FUNNY","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","FUNNY","Lforge/card/CardEdition$Type;"));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[13]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",92);}
case 92:{return rt.Call(f,"forge/card/CardEdition$Type","equals","(Ljava/lang/Object;)Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?101:98;continue;}
case 98:{f.Pc=62;continue;}
case 101:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",108);}
case 108:{f.Locals[14]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[13]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/card/CardEdition","getObtainableCards","()Ljava/util/List;","invokevirtual",115);}
case 115:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",120);}
case 120:{f.Locals[15]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[15]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",129);}
case 129:{f.Pc=f.Pop().Int==0?160:132;continue;}
case 132:{f.Push(f.Locals[15]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{f.Locals[16]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[14]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[16]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",151);}
case 151:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",156);}
case 156:{f.StackOp("pop");f.Pc=157;continue;}
case 157:{f.Pc=122;continue;}
case 160:{f.Push(f.Locals[11]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[14]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",169);}
case 169:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=170;continue;}
case 170:{f.Locals[11]=f.Pop();f.Pc=172;continue;}
case 172:{f.Pc=62;continue;}
case 175:{f.Push(JValue.I(1));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[11]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",181);}
case 181:{f.Locals[12]=f.Pop();f.Pc=183;continue;}
case 183:{if(!rt.EnsureInitialized(f,"java/util/concurrent/atomic/AtomicInteger"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/atomic/AtomicInteger")));f.Pc=186;continue;}
case 186:{f.StackOp("dup");f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","<init>","()V","invokespecial",190);}
case 190:{f.Locals[13]=f.Pop();f.Pc=192;continue;}
case 192:{if(!rt.EnsureInitialized(f,"java/util/concurrent/atomic/AtomicInteger"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/atomic/AtomicInteger")));f.Pc=195;continue;}
case 195:{f.StackOp("dup");f.Pc=196;continue;}
case 196:{f.Push(JValue.I(-1));f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","<init>","(I)V","invokespecial",200);}
case 200:{f.Locals[14]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(JValue.F(0.5f));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/util/ThreadUtil","getComputingPool","(F)Ljava/util/concurrent/ExecutorService;","invokestatic",208);}
case 208:{f.Locals[15]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[0]);f.Pc=211;continue;}
case 211:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/card/CardEdition$Collection","iterator","()Ljava/util/Iterator;","invokevirtual",217);}
case 217:{f.Locals[16]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[16]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",226);}
case 226:{f.Pc=f.Pop().Int==0?754:229;continue;}
case 229:{f.Push(f.Locals[16]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",236);}
case 236:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=239;continue;}
case 239:{f.Locals[17]=f.Pop();f.Pc=241;continue;}
case 241:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","FUNNY","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","FUNNY","Lforge/card/CardEdition$Type;"));f.Pc=244;continue;}
case 244:{f.Push(f.Locals[17]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",249);}
case 249:{return rt.Call(f,"forge/card/CardEdition$Type","equals","(Ljava/lang/Object;)Z","invokevirtual",252);}
case 252:{f.Pc=f.Pop().Int==0?258:255;continue;}
case 255:{f.Pc=219;continue;}
case 258:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=261;continue;}
case 261:{f.StackOp("dup");f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",265);}
case 265:{f.Locals[18]=f.Pop();f.Pc=267;continue;}
case 267:{f.Push(f.Locals[17]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/card/CardEdition","getObtainableCards","()Ljava/util/List;","invokevirtual",272);}
case 272:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",277);}
case 277:{f.Locals[19]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[19]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",286);}
case 286:{f.Pc=f.Pop().Int==0?403:289;continue;}
case 289:{f.Push(f.Locals[19]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",296);}
case 296:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=299;continue;}
case 299:{f.Locals[20]=f.Pop();f.Pc=301;continue;}
case 301:{f.Push(JValue.I(1));f.Pc=302;continue;}
case 302:{f.Locals[21]=f.Pop();f.Pc=304;continue;}
case 304:{f.Push(f.Locals[18]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[20]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",311);}
case 311:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",316);}
case 316:{f.Pc=f.Pop().Int==0?347:319;continue;}
case 319:{f.Push(f.Locals[18]);f.Pc=321;continue;}
case 321:{f.Push(f.Locals[20]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",326);}
case 326:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",331);}
case 331:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=334;continue;}
case 334:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",337);}
case 337:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",343);}
case 343:{f.Push(JValue.I(1));f.Pc=344;continue;}
case 344:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=345;continue;}
case 345:{f.Locals[21]=f.Pop();f.Pc=347;continue;}
case 347:{f.Push(f.Locals[18]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[20]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",354);}
case 354:{f.Push(f.Locals[20]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;","invokevirtual",359);}
case 359:{f.Pc=f.Pop().Reference==null?382:362;continue;}
case 362:{f.Push(f.Locals[10]);f.Pc=364;continue;}
case 364:{f.Push(f.Locals[20]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;","invokevirtual",369);}
case 369:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",372);}
case 372:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",375);}
case 375:{f.Pc=f.Pop().Int==0?382:378;continue;}
case 378:{f.Push(JValue.I(1));f.Pc=379;continue;}
case 379:{f.Pc=383;continue;}
case 382:{f.Push(JValue.I(0));f.Pc=383;continue;}
case 383:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",386);}
case 386:{f.Push(f.Locals[21]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",391);}
case 391:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",394);}
case 394:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",399);}
case 399:{f.StackOp("pop");f.Pc=400;continue;}
case 400:{f.Pc=279;continue;}
case 403:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=406;continue;}
case 406:{f.StackOp("dup");f.Pc=407;continue;}
case 407:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",410);}
case 410:{f.Locals[19]=f.Pop();f.Pc=412;continue;}
case 412:{f.Push(f.Locals[18]);f.Pc=414;continue;}
case 414:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",419);}
case 419:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",424);}
case 424:{f.Locals[20]=f.Pop();f.Pc=426;continue;}
case 426:{f.Push(f.Locals[20]);f.Pc=428;continue;}
case 428:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",433);}
case 433:{f.Pc=f.Pop().Int==0?489:436;continue;}
case 436:{f.Push(f.Locals[20]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",443);}
case 443:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=446;continue;}
case 446:{f.Locals[21]=f.Pop();f.Pc=448;continue;}
case 448:{f.Push(f.Locals[19]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[15]);f.Pc=452;continue;}
case 452:{f.Push(f.Locals[0]);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[21]);f.Pc=455;continue;}
case 455:{f.Push(f.Locals[17]);f.Pc=457;continue;}
case 457:{f.Push(f.Locals[4]);f.Pc=459;continue;}
case 459:{f.Push(f.Locals[6]);f.Pc=461;continue;}
case 461:{f.Push(f.Locals[5]);f.Pc=463;continue;}
case 463:{f.Push(f.Locals[3]);f.Pc=464;continue;}
case 464:{f.Push(f.Locals[13]);f.Pc=466;continue;}
case 466:{f.Push(f.Locals[12]);f.Pc=468;continue;}
case 468:{f.Push(f.Locals[14]);f.Pc=470;continue;}
case 470:{return rt.DynamicCall(f,"forge/StaticData:161:470:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/StaticData;Ljava/util/Map$Entry;Lforge/card/CardEdition;Ljava/util/Queue;Ljava/util/Queue;Ljava/util/Queue;Ljava/util/function/IntConsumer;Ljava/util/concurrent/atomic/AtomicInteger;ILjava/util/concurrent/atomic/AtomicInteger;)Ljava/lang/Runnable;",475);}
case 475:{return rt.Call(f,"java/util/concurrent/ExecutorService","submit","(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;","invokeinterface",480);}
case 480:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",485);}
case 485:{f.StackOp("pop");f.Pc=486;continue;}
case 486:{f.Pc=426;continue;}
case 489:{f.Push(f.Locals[19]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",496);}
case 496:{f.Locals[20]=f.Pop();f.Pc=498;continue;}
case 498:{f.Push(f.Locals[20]);f.Pc=500;continue;}
case 500:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",505);}
case 505:{f.Pc=f.Pop().Int==0?541:508;continue;}
case 508:{f.Push(f.Locals[20]);f.Pc=510;continue;}
case 510:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",515);}
case 515:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/concurrent/Future"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=518;continue;}
case 518:{f.Locals[21]=f.Pop();f.Pc=520;continue;}
case 520:{f.Push(f.Locals[21]);f.Pc=522;continue;}
case 522:{return rt.Call(f,"java/util/concurrent/Future","get","()Ljava/lang/Object;","invokeinterface",527);}
case 527:{f.StackOp("pop");f.Pc=528;continue;}
case 528:{f.Pc=538;continue;}
case 531:{f.Locals[22]=f.Pop();f.Pc=533;continue;}
case 533:{f.Push(f.Locals[22]);f.Pc=535;continue;}
case 535:{return rt.Call(f,"java/lang/Exception","printStackTrace","()V","invokevirtual",538);}
case 538:{f.Pc=498;continue;}
case 541:{f.Push(f.Locals[17]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/card/CardEdition","getTokens","()Lcom/google/common/collect/Multimap;","invokevirtual",546);}
case 546:{return rt.Call(f,"com/google/common/collect/Multimap","asMap","()Ljava/util/Map;","invokeinterface",551);}
case 551:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",556);}
case 556:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",561);}
case 561:{f.Locals[20]=f.Pop();f.Pc=563;continue;}
case 563:{f.Push(f.Locals[20]);f.Pc=565;continue;}
case 565:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",570);}
case 570:{f.Pc=f.Pop().Int==0?751:573;continue;}
case 573:{f.Push(f.Locals[20]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",580);}
case 580:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=583;continue;}
case 583:{f.Locals[21]=f.Pop();f.Pc=585;continue;}
case 585:{f.Push(f.Locals[21]);f.Pc=587;continue;}
case 587:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",592);}
case 592:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=595;continue;}
case 595:{f.Locals[22]=f.Pop();f.Pc=597;continue;}
case 597:{f.Push(f.Locals[21]);f.Pc=599;continue;}
case 599:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",604);}
case 604:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=607;continue;}
case 607:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",612);}
case 612:{f.Locals[23]=f.Pop();f.Pc=614;continue;}
case 614:{f.Push(f.Locals[0]);f.Pc=615;continue;}
case 615:{return rt.Call(f,"forge/StaticData","getAllTokens","()Lforge/token/TokenDb;","invokevirtual",618);}
case 618:{f.Push(f.Locals[22]);f.Pc=620;continue;}
case 620:{f.Push(f.Locals[17]);f.Pc=622;continue;}
case 622:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",625);}
case 625:{return rt.Call(f,"forge/token/TokenDb","getToken","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperToken;","invokevirtual",628);}
case 628:{f.Locals[24]=f.Pop();f.Pc=630;continue;}
case 630:{f.Push(f.Locals[24]);f.Pc=632;continue;}
case 632:{f.Pc=f.Pop().Reference!=null?638:635;continue;}
case 635:{f.Pc=563;continue;}
case 638:{f.Push(JValue.I(0));f.Pc=639;continue;}
case 639:{f.Locals[25]=f.Pop();f.Pc=641;continue;}
case 641:{f.Push(f.Locals[25]);f.Pc=643;continue;}
case 643:{f.Push(f.Locals[23]);f.Pc=645;continue;}
case 645:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?725:648;continue;}
case 648:{f.Push(f.Locals[24]);f.Pc=650;continue;}
case 650:{f.Push(f.Locals[25]);f.Pc=652;continue;}
case 652:{return rt.Call(f,"forge/item/PaperToken","getImageKey","(I)Ljava/lang/String;","invokevirtual",655);}
case 655:{f.Locals[26]=f.Pop();f.Pc=657;continue;}
case 657:{f.Push(f.Locals[26]);f.Pc=659;continue;}
case 659:{return rt.Call(f,"forge/ImageKeys","getImageFile","(Ljava/lang/String;)Ljava/io/File;","invokestatic",662);}
case 662:{f.Locals[27]=f.Pop();f.Pc=664;continue;}
case 664:{f.Push(f.Locals[27]);f.Pc=666;continue;}
case 666:{f.Pc=f.Pop().Reference!=null?719:669;continue;}
case 669:{f.Push(f.Locals[4]);f.Pc=671;continue;}
case 671:{f.Push(f.Locals[17]);f.Pc=673;continue;}
case 673:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",676);}
case 676:{f.Push(f.Locals[17]);f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",681);}
case 681:{return rt.DynamicCall(f,"forge/StaticData:161:681:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",686);}
case 686:{return rt.Call(f,"java/util/Queue","add","(Ljava/lang/Object;)Z","invokeinterface",691);}
case 691:{f.StackOp("pop");f.Pc=692;continue;}
case 692:{f.Push(f.Locals[7]);f.Pc=694;continue;}
case 694:{f.Push(f.Locals[17]);f.Pc=696;continue;}
case 696:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",699);}
case 699:{f.Push(f.Locals[24]);f.Pc=701;continue;}
case 701:{f.Push(f.Locals[25]);f.Pc=703;continue;}
case 703:{f.Push(JValue.I(1));f.Pc=704;continue;}
case 704:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=705;continue;}
case 705:{return rt.Call(f,"forge/item/PaperToken","getImageFilename","(I)Ljava/lang/String;","invokevirtual",708);}
case 708:{return rt.DynamicCall(f,"forge/StaticData:161:708:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",713);}
case 713:{return rt.Call(f,"java/util/Queue","add","(Ljava/lang/Object;)Z","invokeinterface",718);}
case 718:{f.StackOp("pop");f.Pc=719;continue;}
case 719:{f.Locals[25]=JValue.I(unchecked(f.Locals[25].Int+(1)));f.Pc=722;continue;}
case 722:{f.Pc=641;continue;}
case 725:{f.Pc=748;continue;}
case 728:{f.Locals[24]=f.Pop();f.Pc=730;continue;}
case 730:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=733;continue;}
case 733:{f.Push(f.Locals[22]);f.Pc=735;continue;}
case 735:{f.Push(f.Locals[17]);f.Pc=737;continue;}
case 737:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",740);}
case 740:{return rt.DynamicCall(f,"forge/StaticData:161:740:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",745);}
case 745:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",748);}
case 748:{f.Pc=563;continue;}
case 751:{f.Pc=219;continue;}
case 754:{f.Push(f.Locals[15]);f.Pc=756;continue;}
case 756:{return rt.Call(f,"java/util/concurrent/ExecutorService","shutdown","()V","invokeinterface",761);}
case 761:{f.Pc=776;continue;}
case 764:{f.Locals[28]=f.Pop();f.Pc=766;continue;}
case 766:{f.Push(f.Locals[15]);f.Pc=768;continue;}
case 768:{return rt.Call(f,"java/util/concurrent/ExecutorService","shutdown","()V","invokeinterface",773);}
case 773:{f.Push(f.Locals[28]);f.Pc=775;continue;}
case 775:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 776:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=779;continue;}
case 779:{f.StackOp("dup");f.Pc=780;continue;}
case 780:{f.Push(f.Locals[5]);f.Pc=782;continue;}
case 782:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",785);}
case 785:{f.Locals[16]=f.Pop();f.Pc=787;continue;}
case 787:{f.Push(f.Locals[16]);f.Pc=789;continue;}
case 789:{f.Push(JValue.R(null));f.Pc=790;continue;}
case 790:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",795);}
case 795:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=798;continue;}
case 798:{f.StackOp("dup");f.Pc=799;continue;}
case 799:{f.Push(f.Locals[6]);f.Pc=801;continue;}
case 801:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",804);}
case 804:{f.Locals[17]=f.Pop();f.Pc=806;continue;}
case 806:{f.Push(f.Locals[17]);f.Pc=808;continue;}
case 808:{f.Push(JValue.R(null));f.Pc=809;continue;}
case 809:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",814);}
case 814:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=817;continue;}
case 817:{f.StackOp("dup");f.Pc=818;continue;}
case 818:{f.Push(f.Locals[7]);f.Pc=820;continue;}
case 820:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",823);}
case 823:{f.Locals[18]=f.Pop();f.Pc=825;continue;}
case 825:{f.Push(f.Locals[18]);f.Pc=827;continue;}
case 827:{f.Push(JValue.R(null));f.Pc=828;continue;}
case 828:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",833);}
case 833:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=836;continue;}
case 836:{f.StackOp("dup");f.Pc=837;continue;}
case 837:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashSet")));f.Pc=840;continue;}
case 840:{f.StackOp("dup");f.Pc=841;continue;}
case 841:{f.Push(f.Locals[4]);f.Pc=843;continue;}
case 843:{return rt.Call(f,"java/util/LinkedHashSet","<init>","(Ljava/util/Collection;)V","invokespecial",846);}
case 846:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",849);}
case 849:{f.Locals[19]=f.Pop();f.Pc=851;continue;}
case 851:{f.Push(f.Locals[19]);f.Pc=853;continue;}
case 853:{f.Push(JValue.R(null));f.Pc=854;continue;}
case 854:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",859);}
case 859:{f.Push(f.Locals[16]);f.Pc=861;continue;}
case 861:{return rt.Call(f,"forge/StaticData","groupByCode","(Ljava/util/List;)Ljava/util/Map;","invokestatic",864);}
case 864:{f.Locals[20]=f.Pop();f.Pc=866;continue;}
case 866:{f.Push(f.Locals[17]);f.Pc=868;continue;}
case 868:{return rt.Call(f,"forge/StaticData","groupByCode","(Ljava/util/List;)Ljava/util/Map;","invokestatic",871);}
case 871:{f.Locals[21]=f.Pop();f.Pc=873;continue;}
case 873:{f.Push(f.Locals[18]);f.Pc=875;continue;}
case 875:{return rt.Call(f,"forge/StaticData","groupByCode","(Ljava/util/List;)Ljava/util/Map;","invokestatic",878);}
case 878:{f.Locals[22]=f.Pop();f.Pc=880;continue;}
case 880:{f.Push(f.Locals[19]);f.Pc=882;continue;}
case 882:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",887);}
case 887:{f.Locals[23]=f.Pop();f.Pc=889;continue;}
case 889:{f.Push(f.Locals[23]);f.Pc=891;continue;}
case 891:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",896);}
case 896:{f.Pc=f.Pop().Int==0?1408:899;continue;}
case 899:{f.Push(f.Locals[23]);f.Pc=901;continue;}
case 901:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",906);}
case 906:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=909;continue;}
case 909:{f.Locals[24]=f.Pop();f.Pc=911;continue;}
case 911:{f.Push(f.Locals[24]);f.Pc=913;continue;}
case 913:{f.Push(JValue.R(rt.String("_")));f.Pc=916;continue;}
case 916:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",919);}
case 919:{f.Locals[25]=f.Pop();f.Pc=921;continue;}
case 921:{f.Push(f.Locals[25]);f.Pc=923;continue;}
case 923:{f.Push(JValue.I(0));f.Pc=924;continue;}
case 924:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=925;continue;}
case 925:{f.Locals[26]=f.Pop();f.Pc=927;continue;}
case 927:{f.Push(JValue.I(0));f.Pc=928;continue;}
case 928:{f.Locals[27]=f.Pop();f.Pc=930;continue;}
case 930:{f.Push(JValue.I(0));f.Pc=931;continue;}
case 931:{f.Locals[28]=f.Pop();f.Pc=933;continue;}
case 933:{f.Push(JValue.I(0));f.Pc=934;continue;}
case 934:{f.Locals[29]=f.Pop();f.Pc=936;continue;}
case 936:{f.Push(f.Locals[20]);f.Pc=938;continue;}
case 938:{f.Push(f.Locals[26]);f.Pc=940;continue;}
case 940:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",943);}
case 943:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",948);}
case 948:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=951;continue;}
case 951:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",956);}
case 956:{f.Locals[30]=f.Pop();f.Pc=958;continue;}
case 958:{f.Push(f.Locals[30]);f.Pc=960;continue;}
case 960:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",965);}
case 965:{f.Pc=f.Pop().Int==0?1074:968;continue;}
case 968:{f.Push(f.Locals[30]);f.Pc=970;continue;}
case 970:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",975);}
case 975:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=978;continue;}
case 978:{f.Locals[31]=f.Pop();f.Pc=980;continue;}
case 980:{f.Push(f.Locals[8]);f.Pc=982;continue;}
case 982:{f.Pc=f.Pop().Int!=0?996:985;continue;}
case 985:{f.Push(f.Locals[1]);f.Pc=986;continue;}
case 986:{f.Push(JValue.R(rt.String("\n-------------------\nNO IMAGE FOUND LIST\n-------------------\n\n")));f.Pc=989;continue;}
case 989:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",992);}
case 992:{f.StackOp("pop");f.Pc=993;continue;}
case 993:{f.Push(JValue.I(1));f.Pc=994;continue;}
case 994:{f.Locals[8]=f.Pop();f.Pc=996;continue;}
case 996:{f.Push(f.Locals[27]);f.Pc=998;continue;}
case 998:{f.Pc=f.Pop().Int!=0?1046:1001;continue;}
case 1001:{f.Push(f.Locals[1]);f.Pc=1002;continue;}
case 1002:{f.Push(f.Locals[24]);f.Pc=1004;continue;}
case 1004:{f.Push(f.Locals[26]);f.Pc=1006;continue;}
case 1006:{return rt.DynamicCall(f,"forge/StaticData:161:1006:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1011);}
case 1011:{f.Push(JValue.R(rt.String("")));f.Pc=1013;continue;}
case 1013:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",1016);}
case 1016:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1019);}
case 1019:{f.Push(JValue.R(rt.String(" (")));f.Pc=1022;continue;}
case 1022:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1025);}
case 1025:{f.Push(f.Locals[26]);f.Pc=1027;continue;}
case 1027:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1030);}
case 1030:{f.Push(JValue.R(rt.String(")")));f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1036);}
case 1036:{f.Push(JValue.R(rt.String("\n")));f.Pc=1039;continue;}
case 1039:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1042);}
case 1042:{f.StackOp("pop");f.Pc=1043;continue;}
case 1043:{f.Push(JValue.I(1));f.Pc=1044;continue;}
case 1044:{f.Locals[27]=f.Pop();f.Pc=1046;continue;}
case 1046:{f.Push(f.Locals[1]);f.Pc=1047;continue;}
case 1047:{f.Push(JValue.R(rt.String("    ")));f.Pc=1050;continue;}
case 1050:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1053);}
case 1053:{f.Push(f.Locals[31]);f.Pc=1055;continue;}
case 1055:{f.Push(f.Locals[26]);f.Pc=1057;continue;}
case 1057:{return rt.DynamicCall(f,"forge/StaticData:161:1057:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1062);}
case 1062:{f.Push(JValue.R(rt.String("")));f.Pc=1064;continue;}
case 1064:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",1067);}
case 1067:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1070);}
case 1070:{f.StackOp("pop");f.Pc=1071;continue;}
case 1071:{f.Pc=958;continue;}
case 1074:{f.Push(f.Locals[27]);f.Pc=1076;continue;}
case 1076:{f.Pc=f.Pop().Int==0?1087:1079;continue;}
case 1079:{f.Push(f.Locals[1]);f.Pc=1080;continue;}
case 1080:{f.Push(JValue.R(rt.String("\n")));f.Pc=1083;continue;}
case 1083:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1086);}
case 1086:{f.StackOp("pop");f.Pc=1087;continue;}
case 1087:{f.Push(f.Locals[22]);f.Pc=1089;continue;}
case 1089:{f.Push(f.Locals[26]);f.Pc=1091;continue;}
case 1091:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",1094);}
case 1094:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1099);}
case 1099:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1102;continue;}
case 1102:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1107);}
case 1107:{f.Locals[30]=f.Pop();f.Pc=1109;continue;}
case 1109:{f.Push(f.Locals[30]);f.Pc=1111;continue;}
case 1111:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1116);}
case 1116:{f.Pc=f.Pop().Int==0?1241:1119;continue;}
case 1119:{f.Push(f.Locals[30]);f.Pc=1121;continue;}
case 1121:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1126);}
case 1126:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1129;continue;}
case 1129:{f.Locals[31]=f.Pop();f.Pc=1131;continue;}
case 1131:{f.Push(f.Locals[8]);f.Pc=1133;continue;}
case 1133:{f.Pc=f.Pop().Int!=0?1147:1136;continue;}
case 1136:{f.Push(f.Locals[1]);f.Pc=1137;continue;}
case 1137:{f.Push(JValue.R(rt.String("\n-------------------\nNO IMAGE FOUND LIST\n-------------------\n\n")));f.Pc=1140;continue;}
case 1140:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1143);}
case 1143:{f.StackOp("pop");f.Pc=1144;continue;}
case 1144:{f.Push(JValue.I(1));f.Pc=1145;continue;}
case 1145:{f.Locals[8]=f.Pop();f.Pc=1147;continue;}
case 1147:{f.Push(f.Locals[27]);f.Pc=1149;continue;}
case 1149:{f.Pc=f.Pop().Int!=0?1197:1152;continue;}
case 1152:{f.Push(f.Locals[1]);f.Pc=1153;continue;}
case 1153:{f.Push(f.Locals[24]);f.Pc=1155;continue;}
case 1155:{f.Push(f.Locals[26]);f.Pc=1157;continue;}
case 1157:{return rt.DynamicCall(f,"forge/StaticData:161:1157:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1162);}
case 1162:{f.Push(JValue.R(rt.String("")));f.Pc=1164;continue;}
case 1164:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",1167);}
case 1167:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1170);}
case 1170:{f.Push(JValue.R(rt.String(" (")));f.Pc=1173;continue;}
case 1173:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1176);}
case 1176:{f.Push(f.Locals[26]);f.Pc=1178;continue;}
case 1178:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1181);}
case 1181:{f.Push(JValue.R(rt.String(")")));f.Pc=1184;continue;}
case 1184:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1187);}
case 1187:{f.Push(JValue.R(rt.String("\n")));f.Pc=1190;continue;}
case 1190:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1193);}
case 1193:{f.StackOp("pop");f.Pc=1194;continue;}
case 1194:{f.Push(JValue.I(1));f.Pc=1195;continue;}
case 1195:{f.Locals[27]=f.Pop();f.Pc=1197;continue;}
case 1197:{f.Push(f.Locals[29]);f.Pc=1199;continue;}
case 1199:{f.Pc=f.Pop().Int!=0?1213:1202;continue;}
case 1202:{f.Push(f.Locals[1]);f.Pc=1203;continue;}
case 1203:{f.Push(JValue.R(rt.String("  TOKENS\n")));f.Pc=1206;continue;}
case 1206:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1209);}
case 1209:{f.StackOp("pop");f.Pc=1210;continue;}
case 1210:{f.Push(JValue.I(1));f.Pc=1211;continue;}
case 1211:{f.Locals[29]=f.Pop();f.Pc=1213;continue;}
case 1213:{f.Push(f.Locals[1]);f.Pc=1214;continue;}
case 1214:{f.Push(JValue.R(rt.String("    ")));f.Pc=1217;continue;}
case 1217:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1220);}
case 1220:{f.Push(f.Locals[31]);f.Pc=1222;continue;}
case 1222:{f.Push(f.Locals[26]);f.Pc=1224;continue;}
case 1224:{return rt.DynamicCall(f,"forge/StaticData:161:1224:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1229);}
case 1229:{f.Push(JValue.R(rt.String("")));f.Pc=1231;continue;}
case 1231:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",1234);}
case 1234:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1237);}
case 1237:{f.StackOp("pop");f.Pc=1238;continue;}
case 1238:{f.Pc=1109;continue;}
case 1241:{f.Push(f.Locals[29]);f.Pc=1243;continue;}
case 1243:{f.Pc=f.Pop().Int==0?1254:1246;continue;}
case 1246:{f.Push(f.Locals[1]);f.Pc=1247;continue;}
case 1247:{f.Push(JValue.R(rt.String("\n")));f.Pc=1250;continue;}
case 1250:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1253);}
case 1253:{f.StackOp("pop");f.Pc=1254;continue;}
case 1254:{f.Push(f.Locals[21]);f.Pc=1256;continue;}
case 1256:{f.Push(f.Locals[26]);f.Pc=1258;continue;}
case 1258:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",1261);}
case 1261:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1266);}
case 1266:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1269;continue;}
case 1269:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1274);}
case 1274:{f.Locals[30]=f.Pop();f.Pc=1276;continue;}
case 1276:{f.Push(f.Locals[30]);f.Pc=1278;continue;}
case 1278:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1283);}
case 1283:{f.Pc=f.Pop().Int==0?1392:1286;continue;}
case 1286:{f.Push(f.Locals[30]);f.Pc=1288;continue;}
case 1288:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1293);}
case 1293:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1296;continue;}
case 1296:{f.Locals[31]=f.Pop();f.Pc=1298;continue;}
case 1298:{f.Push(f.Locals[9]);f.Pc=1300;continue;}
case 1300:{f.Pc=f.Pop().Int!=0?1314:1303;continue;}
case 1303:{f.Push(f.Locals[2]);f.Pc=1304;continue;}
case 1304:{f.Push(JValue.R(rt.String("\n-------------------\nUNIMPLEMENTED CARD LIST\n-------------------\n\n")));f.Pc=1307;continue;}
case 1307:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1310);}
case 1310:{f.StackOp("pop");f.Pc=1311;continue;}
case 1311:{f.Push(JValue.I(1));f.Pc=1312;continue;}
case 1312:{f.Locals[9]=f.Pop();f.Pc=1314;continue;}
case 1314:{f.Push(f.Locals[28]);f.Pc=1316;continue;}
case 1316:{f.Pc=f.Pop().Int!=0?1364:1319;continue;}
case 1319:{f.Push(f.Locals[2]);f.Pc=1320;continue;}
case 1320:{f.Push(f.Locals[24]);f.Pc=1322;continue;}
case 1322:{f.Push(f.Locals[26]);f.Pc=1324;continue;}
case 1324:{return rt.DynamicCall(f,"forge/StaticData:161:1324:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1329);}
case 1329:{f.Push(JValue.R(rt.String("")));f.Pc=1331;continue;}
case 1331:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",1334);}
case 1334:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1337);}
case 1337:{f.Push(JValue.R(rt.String(" (")));f.Pc=1340;continue;}
case 1340:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1343);}
case 1343:{f.Push(f.Locals[26]);f.Pc=1345;continue;}
case 1345:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1348);}
case 1348:{f.Push(JValue.R(rt.String(")")));f.Pc=1351;continue;}
case 1351:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1354);}
case 1354:{f.Push(JValue.R(rt.String("\n")));f.Pc=1357;continue;}
case 1357:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1360);}
case 1360:{f.StackOp("pop");f.Pc=1361;continue;}
case 1361:{f.Push(JValue.I(1));f.Pc=1362;continue;}
case 1362:{f.Locals[28]=f.Pop();f.Pc=1364;continue;}
case 1364:{f.Push(f.Locals[2]);f.Pc=1365;continue;}
case 1365:{f.Push(JValue.R(rt.String("     ")));f.Pc=1368;continue;}
case 1368:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1371);}
case 1371:{f.Push(f.Locals[31]);f.Pc=1373;continue;}
case 1373:{f.Push(f.Locals[26]);f.Pc=1375;continue;}
case 1375:{return rt.DynamicCall(f,"forge/StaticData:161:1375:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1380);}
case 1380:{f.Push(JValue.R(rt.String("")));f.Pc=1382;continue;}
case 1382:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",1385);}
case 1385:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1388);}
case 1388:{f.StackOp("pop");f.Pc=1389;continue;}
case 1389:{f.Pc=1276;continue;}
case 1392:{f.Push(f.Locals[28]);f.Pc=1394;continue;}
case 1394:{f.Pc=f.Pop().Int==0?1405:1397;continue;}
case 1397:{f.Push(f.Locals[2]);f.Pc=1398;continue;}
case 1398:{f.Push(JValue.R(rt.String("\n")));f.Pc=1401;continue;}
case 1401:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1404);}
case 1404:{f.StackOp("pop");f.Pc=1405;continue;}
case 1405:{f.Pc=889;continue;}
case 1408:{f.Push(f.Locals[16]);f.Pc=1410;continue;}
case 1410:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1415);}
case 1415:{f.Push(f.Locals[18]);f.Pc=1417;continue;}
case 1417:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1422);}
case 1422:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1423;continue;}
case 1423:{f.Locals[23]=f.Pop();f.Pc=1425;continue;}
case 1425:{f.Push(f.Locals[17]);f.Pc=1427;continue;}
case 1427:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1432);}
case 1432:{f.Locals[24]=f.Pop();f.Pc=1434;continue;}
case 1434:{f.Push(f.Locals[23]);f.Pc=1436;continue;}
case 1436:{f.Push(f.Locals[24]);f.Pc=1438;continue;}
case 1438:{return rt.DynamicCall(f,"forge/StaticData:161:1438:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(II)Ljava/lang/String;",1443);}
case 1443:{f.Locals[25]=f.Pop();f.Pc=1445;continue;}
case 1445:{f.Push(f.Locals[2]);f.Pc=1446;continue;}
case 1446:{f.Push(JValue.R(rt.String("\n-----------\n")));f.Pc=1449;continue;}
case 1449:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1452);}
case 1452:{f.Push(f.Locals[25]);f.Pc=1454;continue;}
case 1454:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1457);}
case 1457:{f.Push(JValue.R(rt.String("-----------\n\n")));f.Pc=1460;continue;}
case 1460:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/String;)Ljava/lang/StringBuffer;","invokevirtual",1463);}
case 1463:{f.StackOp("pop");f.Pc=1464;continue;}
case 1464:{f.Push(f.Locals[1]);f.Pc=1465;continue;}
case 1465:{f.Push(f.Locals[2]);f.Pc=1466;continue;}
case 1466:{return rt.Call(f,"java/lang/StringBuffer","append","(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;","invokevirtual",1469);}
case 1469:{f.StackOp("pop");f.Pc=1470;continue;}
case 1470:{f.Push(f.Locals[23]);f.Pc=1472;continue;}
case 1472:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1475);}
case 1475:{f.Push(f.Locals[24]);f.Pc=1477;continue;}
case 1477:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1480);}
case 1480:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",1483);}
case 1483:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M162(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?72:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("_")));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(2));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=44;continue;}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.DynamicCall(f,"forge/StaticData:162:49:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",54);}
case 54:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",68);}
case 68:{f.StackOp("pop");f.Pc=69;continue;}
case 69:{f.Pc=15;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M163(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","toString","()Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(JValue.R(rt.String("_")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=25;continue;}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{f.Locals[6]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[6]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?69:37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[6]);f.Pc=41;continue;}
case 41:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=42;continue;}
case 42:{f.Locals[7]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[7]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",50);}
case 50:{return rt.Call(f,"forge/util/TextUtil","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",53);}
case 53:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",56);}
case 56:{f.Push(JValue.R(rt.String(" ")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=66;continue;}
case 66:{f.Pc=30;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",73);}
case 73:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",76);}
case 76:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M164(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardDb","setCardArtPreference","(ZZZ)V","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/card/CardDb","setCardArtPreference","(ZZZ)V","invokevirtual",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M165(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardDb","setCardArtPreference","(Ljava/lang/String;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardDb","setCardArtPreference","(Ljava/lang/String;)V","invokevirtual",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M166(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","commonCards","Lforge/card/CardDb;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardDb","setPreferredLanguageAvailability","(Ljava/util/function/BiPredicate;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","variantCards","Lforge/card/CardDb;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardDb","setPreferredLanguageAvailability","(Ljava/util/function/BiPredicate;)V","invokevirtual",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M167(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","enableSmartCardArtSelection","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M168(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","enableSmartCardArtSelection","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M169(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","sourceImageForClone","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M170(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/StaticData","sourceImageForClone","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M171(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("A-")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",16);}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",20);}
case 20:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?77:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[3]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",56);}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Reference==null?74:63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/card/CardEdition","isRebalanced","(Ljava/lang/String;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?74:72;continue;}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 74:{f.Pc=26;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M172(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Reference==null?77:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",19);}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardEdition","getOtherSet","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference==null?77:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/CardEdition","findOther","(Ljava/lang/String;)Lforge/card/CardEdition$EditionEntry;","invokevirtual",40);}
case 40:{f.Locals[4]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Reference==null?77:47;continue;}
case 47:{f.Push(JValue.R(rt.String("%s|%s|%s")));f.Pc=50;continue;}
case 50:{f.Push(JValue.I(3));f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=54;continue;}
case 54:{f.StackOp("dup");f.Pc=55;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{f.Push(JValue.I(1));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(2));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;","invokevirtual",69);}
case 69:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",73);}
case 73:{return rt.Call(f,"forge/ImageKeys","getTokenKey","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",76);}
case 76:{return JStep.Return(f.Pop());}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/card/CardEdition$Collection","iterator","()Ljava/util/Iterator;","invokevirtual",84);}
case 84:{f.Locals[3]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",91);}
case 91:{f.Pc=f.Pop().Int==0?155:94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",100);}
case 100:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=103;continue;}
case 103:{f.Locals[4]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[4]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/card/CardEdition","findOther","(Ljava/lang/String;)Lforge/card/CardEdition$EditionEntry;","invokevirtual",111);}
case 111:{f.Locals[5]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[5]);f.Pc=115;continue;}
case 115:{f.Pc=f.Pop().Reference==null?152:118;continue;}
case 118:{f.Push(JValue.R(rt.String("%s|%s|%s")));f.Pc=121;continue;}
case 121:{f.Push(JValue.I(3));f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(JValue.I(0));f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=129;continue;}
case 129:{f.StackOp("dup");f.Pc=130;continue;}
case 130:{f.Push(JValue.I(1));f.Pc=131;continue;}
case 131:{f.Push(f.Locals[4]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",136);}
case 136:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{f.Push(JValue.I(2));f.Pc=139;continue;}
case 139:{f.Push(f.Locals[5]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;","invokevirtual",144);}
case 144:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",148);}
case 148:{return rt.Call(f,"forge/ImageKeys","getTokenKey","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",151);}
case 151:{return JStep.Return(f.Pop());}
case 152:{f.Pc=85;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/ImageKeys","getTokenKey","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",159);}
case 159:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M173(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M174(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Locals[10]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",29);}
case 29:{f.Locals[11]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",49);}
case 49:{f.Locals[12]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",55);}
case 55:{f.Push(f.Locals[10]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",61);}
case 61:{f.Push(f.Locals[11]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperCard;","invokevirtual",66);}
case 66:{f.Locals[13]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[13]);f.Pc=70;continue;}
case 70:{f.Pc=f.Pop().Reference!=null?90:73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/StaticData","getVariantCards","()Lforge/card/CardDb;","invokevirtual",77);}
case 77:{f.Push(f.Locals[10]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",83);}
case 83:{f.Push(f.Locals[11]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperCard;","invokevirtual",88);}
case 88:{f.Locals[13]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[13]);f.Pc=92;continue;}
case 92:{f.Pc=f.Pop().Reference!=null?321:95;continue;}
case 95:{f.Push(f.Locals[12]);f.Pc=97;continue;}
case 97:{f.Pc=f.Pop().Int==0?154:100;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{f.Pc=f.Pop().Reference==null?153:105;continue;}
case 105:{f.Push(f.Locals[7]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","incrementAndGet","()I","invokevirtual",110);}
case 110:{f.Locals[14]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(JValue.L(100L));f.Pc=115;continue;}
case 115:{f.Push(f.Locals[14]);f.Pc=117;continue;}
case 117:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=118;continue;}
case 118:{f.Push(JValue.L(100L));f.Pc=121;continue;}
case 121:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[8]);f.Pc=124;continue;}
case 124:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=125;continue;}
case 125:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/lang/Math","min","(JJ)J","invokestatic",129);}
case 129:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=130;continue;}
case 130:{f.Locals[15]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[9]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[15]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","getAndSet","(I)I","invokevirtual",139);}
case 139:{f.Push(f.Locals[15]);f.Pc=141;continue;}
case 141:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?153:144;continue;}
case 144:{f.Push(f.Locals[6]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[15]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/function/IntConsumer","accept","(I)V","invokeinterface",153);}
case 153:{return JStep.ReturnVoid;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","loadNonLegalCards","Z"));f.Pc=158;continue;}
case 158:{f.Pc=f.Pop().Int!=0?228:161;continue;}
case 161:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","FUNNY","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","FUNNY","Lforge/card/CardEdition$Type;"));f.Pc=164;continue;}
case 164:{f.Push(f.Locals[2]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",168);}
case 168:{return rt.Call(f,"forge/card/CardEdition$Type","equals","(Ljava/lang/Object;)Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int==0?228:174;continue;}
case 174:{f.Push(f.Locals[6]);f.Pc=176;continue;}
case 176:{f.Pc=f.Pop().Reference==null?227:179;continue;}
case 179:{f.Push(f.Locals[7]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","incrementAndGet","()I","invokevirtual",184);}
case 184:{f.Locals[14]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(JValue.L(100L));f.Pc=189;continue;}
case 189:{f.Push(f.Locals[14]);f.Pc=191;continue;}
case 191:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=192;continue;}
case 192:{f.Push(JValue.L(100L));f.Pc=195;continue;}
case 195:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=196;continue;}
case 196:{f.Push(f.Locals[8]);f.Pc=198;continue;}
case 198:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=199;continue;}
case 199:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/lang/Math","min","(JJ)J","invokestatic",203);}
case 203:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=204;continue;}
case 204:{f.Locals[15]=f.Pop();f.Pc=206;continue;}
case 206:{f.Push(f.Locals[9]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[15]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","getAndSet","(I)I","invokevirtual",213);}
case 213:{f.Push(f.Locals[15]);f.Pc=215;continue;}
case 215:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?227:218;continue;}
case 218:{f.Push(f.Locals[6]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[15]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/util/function/IntConsumer","accept","(I)V","invokeinterface",227);}
case 227:{return JStep.ReturnVoid;}
case 228:{f.Push(f.Locals[3]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[2]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",233);}
case 233:{f.Push(f.Locals[2]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",237);}
case 237:{return rt.DynamicCall(f,"forge/StaticData:174:237:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",242);}
case 242:{return rt.Call(f,"java/util/Queue","add","(Ljava/lang/Object;)Z","invokeinterface",247);}
case 247:{f.StackOp("pop");f.Pc=248;continue;}
case 248:{f.Push(f.Locals[4]);f.Pc=250;continue;}
case 250:{f.Push(f.Locals[2]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",254);}
case 254:{f.Push(f.Locals[10]);f.Pc=256;continue;}
case 256:{return rt.DynamicCall(f,"forge/StaticData:174:256:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",261);}
case 261:{return rt.Call(f,"java/util/Queue","add","(Ljava/lang/Object;)Z","invokeinterface",266);}
case 266:{f.StackOp("pop");f.Pc=267;continue;}
case 267:{f.Push(f.Locals[6]);f.Pc=269;continue;}
case 269:{f.Pc=f.Pop().Reference==null?320:272;continue;}
case 272:{f.Push(f.Locals[7]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","incrementAndGet","()I","invokevirtual",277);}
case 277:{f.Locals[14]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(JValue.L(100L));f.Pc=282;continue;}
case 282:{f.Push(f.Locals[14]);f.Pc=284;continue;}
case 284:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=285;continue;}
case 285:{f.Push(JValue.L(100L));f.Pc=288;continue;}
case 288:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=289;continue;}
case 289:{f.Push(f.Locals[8]);f.Pc=291;continue;}
case 291:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=292;continue;}
case 292:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/lang/Math","min","(JJ)J","invokestatic",296);}
case 296:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=297;continue;}
case 297:{f.Locals[15]=f.Pop();f.Pc=299;continue;}
case 299:{f.Push(f.Locals[9]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[15]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","getAndSet","(I)I","invokevirtual",306);}
case 306:{f.Push(f.Locals[15]);f.Pc=308;continue;}
case 308:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?320:311;continue;}
case 311:{f.Push(f.Locals[6]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[15]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"java/util/function/IntConsumer","accept","(I)V","invokeinterface",320);}
case 320:{return JStep.ReturnVoid;}
case 321:{f.Push(f.Locals[13]);f.Pc=323;continue;}
case 323:{f.Push(JValue.R(rt.String("")));f.Pc=325;continue;}
case 325:{f.Push(JValue.I(1));f.Pc=326;continue;}
case 326:{f.Push(JValue.I(0));f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/util/ImageUtil","getImageRelativePath","(Lforge/item/IPaperCard;Ljava/lang/String;ZZ)Ljava/lang/String;","invokestatic",330);}
case 330:{f.Locals[14]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[14]);f.Pc=334;continue;}
case 334:{f.Pc=f.Pop().Reference==null?423:337;continue;}
case 337:{f.Push(f.Locals[14]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/ImageKeys","getImageFile","(Ljava/lang/String;)Ljava/io/File;","invokestatic",342);}
case 342:{f.Locals[15]=f.Pop();f.Pc=344;continue;}
case 344:{f.Push(f.Locals[15]);f.Pc=346;continue;}
case 346:{f.Pc=f.Pop().Reference!=null?371:349;continue;}
case 349:{f.Push(f.Locals[14]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/ImageKeys","hasSetLookup","(Ljava/lang/String;)Z","invokestatic",354);}
case 354:{f.Pc=f.Pop().Int==0?371:357;continue;}
case 357:{f.Push(f.Locals[14]);f.Pc=359;continue;}
case 359:{f.Push(f.Locals[14]);f.Pc=361;continue;}
case 361:{return rt.DynamicCall(f,"forge/StaticData:174:361:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",366);}
case 366:{return rt.Call(f,"forge/ImageKeys","setLookUpFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",369);}
case 369:{f.Locals[15]=f.Pop();f.Pc=371;continue;}
case 371:{f.Push(f.Locals[15]);f.Pc=373;continue;}
case 373:{f.Pc=f.Pop().Reference!=null?423:376;continue;}
case 376:{f.Push(f.Locals[14]);f.Pc=378;continue;}
case 378:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",381);}
case 381:{f.Pc=f.Pop().Int!=0?423:384;continue;}
case 384:{f.Push(f.Locals[3]);f.Pc=385;continue;}
case 385:{f.Push(f.Locals[2]);f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",389);}
case 389:{f.Push(f.Locals[2]);f.Pc=390;continue;}
case 390:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",393);}
case 393:{return rt.DynamicCall(f,"forge/StaticData:174:393:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",398);}
case 398:{return rt.Call(f,"java/util/Queue","add","(Ljava/lang/Object;)Z","invokeinterface",403);}
case 403:{f.StackOp("pop");f.Pc=404;continue;}
case 404:{f.Push(f.Locals[5]);f.Pc=406;continue;}
case 406:{f.Push(f.Locals[2]);f.Pc=407;continue;}
case 407:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",410);}
case 410:{f.Push(f.Locals[14]);f.Pc=412;continue;}
case 412:{return rt.DynamicCall(f,"forge/StaticData:174:412:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",417);}
case 417:{return rt.Call(f,"java/util/Queue","add","(Ljava/lang/Object;)Z","invokeinterface",422);}
case 422:{f.StackOp("pop");f.Pc=423;continue;}
case 423:{f.Push(f.Locals[13]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/item/PaperCard","hasBackFace","()Z","invokevirtual",428);}
case 428:{f.Pc=f.Pop().Int==0?534:431;continue;}
case 431:{f.Push(f.Locals[13]);f.Pc=433;continue;}
case 433:{f.Push(JValue.R(rt.String("back")));f.Pc=436;continue;}
case 436:{f.Push(JValue.I(1));f.Pc=437;continue;}
case 437:{f.Push(JValue.I(0));f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/util/ImageUtil","getImageRelativePath","(Lforge/item/IPaperCard;Ljava/lang/String;ZZ)Ljava/lang/String;","invokestatic",441);}
case 441:{f.Locals[15]=f.Pop();f.Pc=443;continue;}
case 443:{f.Push(f.Locals[15]);f.Pc=445;continue;}
case 445:{f.Pc=f.Pop().Reference==null?534:448;continue;}
case 448:{f.Push(f.Locals[15]);f.Pc=450;continue;}
case 450:{return rt.Call(f,"forge/ImageKeys","getImageFile","(Ljava/lang/String;)Ljava/io/File;","invokestatic",453);}
case 453:{f.Locals[16]=f.Pop();f.Pc=455;continue;}
case 455:{f.Push(f.Locals[16]);f.Pc=457;continue;}
case 457:{f.Pc=f.Pop().Reference!=null?482:460;continue;}
case 460:{f.Push(f.Locals[15]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"forge/ImageKeys","hasSetLookup","(Ljava/lang/String;)Z","invokestatic",465);}
case 465:{f.Pc=f.Pop().Int==0?482:468;continue;}
case 468:{f.Push(f.Locals[15]);f.Pc=470;continue;}
case 470:{f.Push(f.Locals[15]);f.Pc=472;continue;}
case 472:{return rt.DynamicCall(f,"forge/StaticData:174:472:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",477);}
case 477:{return rt.Call(f,"forge/ImageKeys","setLookUpFile","(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;","invokestatic",480);}
case 480:{f.Locals[16]=f.Pop();f.Pc=482;continue;}
case 482:{f.Push(f.Locals[16]);f.Pc=484;continue;}
case 484:{f.Pc=f.Pop().Reference!=null?534:487;continue;}
case 487:{f.Push(f.Locals[15]);f.Pc=489;continue;}
case 489:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",492);}
case 492:{f.Pc=f.Pop().Int!=0?534:495;continue;}
case 495:{f.Push(f.Locals[3]);f.Pc=496;continue;}
case 496:{f.Push(f.Locals[2]);f.Pc=497;continue;}
case 497:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",500);}
case 500:{f.Push(f.Locals[2]);f.Pc=501;continue;}
case 501:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",504);}
case 504:{return rt.DynamicCall(f,"forge/StaticData:174:504:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",509);}
case 509:{return rt.Call(f,"java/util/Queue","add","(Ljava/lang/Object;)Z","invokeinterface",514);}
case 514:{f.StackOp("pop");f.Pc=515;continue;}
case 515:{f.Push(f.Locals[5]);f.Pc=517;continue;}
case 517:{f.Push(f.Locals[2]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",521);}
case 521:{f.Push(f.Locals[15]);f.Pc=523;continue;}
case 523:{return rt.DynamicCall(f,"forge/StaticData:174:523:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",528);}
case 528:{return rt.Call(f,"java/util/Queue","add","(Ljava/lang/Object;)Z","invokeinterface",533);}
case 533:{f.StackOp("pop");f.Pc=534;continue;}
case 534:{f.Push(f.Locals[6]);f.Pc=536;continue;}
case 536:{f.Pc=f.Pop().Reference==null?711:539;continue;}
case 539:{f.Push(f.Locals[7]);f.Pc=541;continue;}
case 541:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","incrementAndGet","()I","invokevirtual",544);}
case 544:{f.Locals[10]=f.Pop();f.Pc=546;continue;}
case 546:{f.Push(JValue.L(100L));f.Pc=549;continue;}
case 549:{f.Push(f.Locals[10]);f.Pc=551;continue;}
case 551:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=552;continue;}
case 552:{f.Push(JValue.L(100L));f.Pc=555;continue;}
case 555:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=556;continue;}
case 556:{f.Push(f.Locals[8]);f.Pc=558;continue;}
case 558:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=559;continue;}
case 559:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=560;continue;}
case 560:{return rt.Call(f,"java/lang/Math","min","(JJ)J","invokestatic",563);}
case 563:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=564;continue;}
case 564:{f.Locals[11]=f.Pop();f.Pc=566;continue;}
case 566:{f.Push(f.Locals[9]);f.Pc=568;continue;}
case 568:{f.Push(f.Locals[11]);f.Pc=570;continue;}
case 570:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","getAndSet","(I)I","invokevirtual",573);}
case 573:{f.Push(f.Locals[11]);f.Pc=575;continue;}
case 575:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?587:578;continue;}
case 578:{f.Push(f.Locals[6]);f.Pc=580;continue;}
case 580:{f.Push(f.Locals[11]);f.Pc=582;continue;}
case 582:{return rt.Call(f,"java/util/function/IntConsumer","accept","(I)V","invokeinterface",587);}
case 587:{f.Pc=711;continue;}
case 590:{f.Locals[10]=f.Pop();f.Pc=592;continue;}
case 592:{f.Push(f.Locals[10]);f.Pc=594;continue;}
case 594:{return rt.Call(f,"java/lang/Exception","printStackTrace","()V","invokevirtual",597);}
case 597:{f.Push(f.Locals[6]);f.Pc=599;continue;}
case 599:{f.Pc=f.Pop().Reference==null?711:602;continue;}
case 602:{f.Push(f.Locals[7]);f.Pc=604;continue;}
case 604:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","incrementAndGet","()I","invokevirtual",607);}
case 607:{f.Locals[10]=f.Pop();f.Pc=609;continue;}
case 609:{f.Push(JValue.L(100L));f.Pc=612;continue;}
case 612:{f.Push(f.Locals[10]);f.Pc=614;continue;}
case 614:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=615;continue;}
case 615:{f.Push(JValue.L(100L));f.Pc=618;continue;}
case 618:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=619;continue;}
case 619:{f.Push(f.Locals[8]);f.Pc=621;continue;}
case 621:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=622;continue;}
case 622:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=623;continue;}
case 623:{return rt.Call(f,"java/lang/Math","min","(JJ)J","invokestatic",626);}
case 626:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=627;continue;}
case 627:{f.Locals[11]=f.Pop();f.Pc=629;continue;}
case 629:{f.Push(f.Locals[9]);f.Pc=631;continue;}
case 631:{f.Push(f.Locals[11]);f.Pc=633;continue;}
case 633:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","getAndSet","(I)I","invokevirtual",636);}
case 636:{f.Push(f.Locals[11]);f.Pc=638;continue;}
case 638:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?650:641;continue;}
case 641:{f.Push(f.Locals[6]);f.Pc=643;continue;}
case 643:{f.Push(f.Locals[11]);f.Pc=645;continue;}
case 645:{return rt.Call(f,"java/util/function/IntConsumer","accept","(I)V","invokeinterface",650);}
case 650:{f.Pc=711;continue;}
case 653:{f.Locals[17]=f.Pop();f.Pc=655;continue;}
case 655:{f.Push(f.Locals[6]);f.Pc=657;continue;}
case 657:{f.Pc=f.Pop().Reference==null?708:660;continue;}
case 660:{f.Push(f.Locals[7]);f.Pc=662;continue;}
case 662:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","incrementAndGet","()I","invokevirtual",665);}
case 665:{f.Locals[18]=f.Pop();f.Pc=667;continue;}
case 667:{f.Push(JValue.L(100L));f.Pc=670;continue;}
case 670:{f.Push(f.Locals[18]);f.Pc=672;continue;}
case 672:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=673;continue;}
case 673:{f.Push(JValue.L(100L));f.Pc=676;continue;}
case 676:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lmul",a,b));f.Pc=677;continue;}
case 677:{f.Push(f.Locals[8]);f.Pc=679;continue;}
case 679:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=680;continue;}
case 680:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=681;continue;}
case 681:{return rt.Call(f,"java/lang/Math","min","(JJ)J","invokestatic",684);}
case 684:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=685;continue;}
case 685:{f.Locals[19]=f.Pop();f.Pc=687;continue;}
case 687:{f.Push(f.Locals[9]);f.Pc=689;continue;}
case 689:{f.Push(f.Locals[19]);f.Pc=691;continue;}
case 691:{return rt.Call(f,"java/util/concurrent/atomic/AtomicInteger","getAndSet","(I)I","invokevirtual",694);}
case 694:{f.Push(f.Locals[19]);f.Pc=696;continue;}
case 696:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?708:699;continue;}
case 699:{f.Push(f.Locals[6]);f.Pc=701;continue;}
case 701:{f.Push(f.Locals[19]);f.Pc=703;continue;}
case 703:{return rt.Call(f,"java/util/function/IntConsumer","accept","(I)V","invokeinterface",708);}
case 708:{f.Push(f.Locals[17]);f.Pc=710;continue;}
case 710:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 711:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M175(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference==null?43:18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardEdition","getBorderColor","()Lforge/card/CardEdition$BorderColor;","invokevirtual",23);}
case 23:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"));f.Pc=26;continue;}
case 26:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?43:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","getEditionRank","(Lforge/card/CardEdition;)I","invokevirtual",35);}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?43:39;continue;}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{f.Pc=44;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M176(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/StaticData","editions","Lforge/card/CardEdition$Collection;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","getEditionRank","(Lforge/card/CardEdition;)I","invokevirtual",15);}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?23:19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M177(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/StaticData","lastInstance","Lforge/StaticData;"))return JStep.Continue;rt.PutStatic("forge/StaticData","lastInstance","Lforge/StaticData;",f.Pop());f.Pc=4;continue;}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

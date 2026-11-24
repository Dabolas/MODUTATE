// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C13{
internal static JClass Build(){var c=new JClass("forge/card/CardDb","java/lang/Object",new string[]{"forge/card/ICardDatabase","forge/deck/generation/IDeckGenPool"},49);Add0(c);Add1(c);Add2(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("foilSuffix","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"+"));
c.Add(new JField("NameSetSeparator","C",true,JValue.I(124),null));
c.Add(new JField("FlagPrefix","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"#"));
c.Add(new JField("FlagSeparator","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"\t"));
c.Add(new JField("CARD_RULES_NAME_COMPARATOR","Ljava/util/Comparator;",true,JValue.Default("Ljava/util/Comparator;"),null));
c.Add(new JField("allCardsByName","Lcom/google/common/collect/ListMultimap;",false,JValue.Default("Lcom/google/common/collect/ListMultimap;"),null));
c.Add(new JField("rulesByPrimaryName","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("rulesByAltName","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("allCardsByRules","Lcom/google/common/collect/ListMultimap;",false,JValue.Default("Lcom/google/common/collect/ListMultimap;"),null));
c.Add(new JField("uniqueCardsByRules","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("facesByName","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("normalizedNames","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("artPrefs","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("flavorNameMappings","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("uniqueCardsByFlavorName","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("artIds","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("editions","Lforge/card/CardEdition$Collection;",false,JValue.Default("Lforge/card/CardEdition$Collection;"),null));
c.Add(new JField("filtered","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("nonLegendaryCreatureNames","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("defaultCardArtPreference","Lforge/card/CardDb$CardArtPreference;",false,JValue.Default("Lforge/card/CardDb$CardArtPreference;"),null));
c.Add(new JField("preferredLanguageAvailability","Ljava/util/function/BiPredicate;",false,JValue.Default("Ljava/util/function/BiPredicate;"),null));
c.Add(new JField("initialized","Z",false,JValue.Default("Z"),null));
c.Add(new JField("EDITION_NON_PROMO","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("EDITION_NON_REPRINT","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("editor","Lforge/card/CardDb$Editor;",false,JValue.Default("Lforge/card/CardDb$Editor;"),null));
c.Add(new JField("$assertionsDisabled","Z",true,JValue.Default("Z"),null));
c.Add(new JMethod(208,"forge/card/CardDb","<init>","(Ljava/util/Map;Lforge/card/CardEdition$Collection;Ljava/util/Set;)V",1,9,4,new JHandler[]{},M208));
c.Add(new JMethod(209,"forge/card/CardDb","addFaceToDbNames","(Lforge/card/ICardFace;Lforge/card/CardRules;)V",2,7,3,new JHandler[]{},M209));
c.Add(new JMethod(210,"forge/card/CardDb","cacheFaceFlavorName","(Lforge/card/ICardFace;)V",2,4,3,new JHandler[]{},M210));
c.Add(new JMethod(211,"forge/card/CardDb","cacheRuleFlavorNames","(Lforge/card/CardRules;)V",2,7,3,new JHandler[]{},M211));
c.Add(new JMethod(212,"forge/card/CardDb","addSetCard","(Lforge/card/CardEdition;Lforge/card/CardEdition$EditionEntry;Lforge/card/CardRules;)V",2,10,11,new JHandler[]{},M212));
c.Add(new JMethod(213,"forge/card/CardDb","addFromSetByName","(Ljava/lang/String;Lforge/card/CardEdition;Lforge/card/CardRules;)Z",2,8,4,new JHandler[]{},M213));
c.Add(new JMethod(214,"forge/card/CardDb","containsPrinting","(Lforge/card/CardRules;Ljava/lang/String;Ljava/lang/String;)Z",2,6,2,new JHandler[]{},M214));
c.Add(new JMethod(215,"forge/card/CardDb","clearLoadedCards","()V",1,1,1,new JHandler[]{},M215));
c.Add(new JMethod(216,"forge/card/CardDb","loadCard","(Ljava/lang/String;Ljava/lang/String;Lforge/card/CardRules;)V",1,8,5,new JHandler[]{new JHandler(7,15,18,"java/util/NoSuchElementException")},M216));
c.Add(new JMethod(217,"forge/card/CardDb","reIndex","(Lforge/card/CardRules;)V",2,8,4,new JHandler[]{},M217));
c.Add(new JMethod(218,"forge/card/CardDb","addFromSetByAnyName","(Ljava/lang/String;Lforge/card/CardEdition;Lforge/card/CardRules;)Z",2,8,5,new JHandler[]{},M218));
c.Add(new JMethod(219,"forge/card/CardDb","initialize","(ZZZ)V",1,15,7,new JHandler[]{},M219));
c.Add(new JMethod(220,"forge/card/CardDb","addUnassignedCardPrints","(Z)V",1,7,3,new JHandler[]{},M220));
c.Add(new JMethod(221,"forge/card/CardDb","addUnassignedCardPrints","(ZLforge/card/CardEdition;)V",2,5,6,new JHandler[]{},M221));
c.Add(new JMethod(222,"forge/card/CardDb","addCard","(Lforge/item/PaperCard;)V",1,8,3,new JHandler[]{},M222));
c.Add(new JMethod(223,"forge/card/CardDb","reIndex","()V",2,5,3,new JHandler[]{},M223));
c.Add(new JMethod(224,"forge/card/CardDb","restorePreferredArts","()V",2,4,3,new JHandler[]{},M224));
c.Add(new JMethod(225,"forge/card/CardDb","getTraditionalFramePrint","(Lforge/item/PaperCard;)Lforge/item/PaperCard;",1,4,3,new JHandler[]{},M225));
c.Add(new JMethod(226,"forge/card/CardDb","getTraditionalFramePrints","(Lforge/item/PaperCard;)Ljava/util/List;",1,7,2,new JHandler[]{},M226));
c.Add(new JMethod(227,"forge/card/CardDb","collectorNumberBase","(Ljava/lang/String;)I",10,2,3,new JHandler[]{},M227));
c.Add(new JMethod(228,"forge/card/CardDb","isTraditionalFramePrint","(Lforge/item/PaperCard;)Z",1,5,2,new JHandler[]{},M228));
c.Add(new JMethod(229,"forge/card/CardDb","getBestUniquePrint","(Ljava/util/Collection;)Lforge/item/PaperCard;",2,2,4,new JHandler[]{},M229));
c.Add(new JMethod(230,"forge/card/CardDb","isBorderMismatch","(Lforge/item/PaperCard;)Z",2,3,2,new JHandler[]{},M230));
c.Add(new JMethod(231,"forge/card/CardDb","isPreferredLanguagePrint","(Lforge/item/PaperCard;)Z",2,3,3,new JHandler[]{},M231));
c.Add(new JMethod(232,"forge/card/CardDb","setPreferredArt","(Ljava/lang/String;Ljava/lang/String;I)Z",1,6,3,new JHandler[]{},M232));
c.Add(new JMethod(233,"forge/card/CardDb","hasPreferredArt","(Ljava/lang/String;)Z",1,2,3,new JHandler[]{},M233));
c.Add(new JMethod(234,"forge/card/CardDb","getCardArtPreference","()Lforge/card/CardDb$CardArtPreference;",1,1,1,new JHandler[]{},M234));
c.Add(new JMethod(235,"forge/card/CardDb","setCardArtPreference","(ZZ)V",1,3,4,new JHandler[]{},M235));
c.Add(new JMethod(236,"forge/card/CardDb","setCardArtPreference","(ZZZ)V",1,6,3,new JHandler[]{},M236));
c.Add(new JMethod(237,"forge/card/CardDb","setPreferredLanguageAvailability","(Ljava/util/function/BiPredicate;)V",1,2,2,new JHandler[]{},M237));
c.Add(new JMethod(238,"forge/card/CardDb","getRules","(Ljava/lang/String;Z)Lforge/card/CardRules;",1,4,3,new JHandler[]{},M238));
c.Add(new JMethod(239,"forge/card/CardDb","getLoadedRules","(Ljava/lang/String;Z)Lforge/card/CardRules;",2,4,2,new JHandler[]{},M239));
c.Add(new JMethod(240,"forge/card/CardDb","lazyLoad","(Ljava/lang/String;Ljava/lang/String;)Z",2,4,3,new JHandler[]{},M240));
c.Add(new JMethod(241,"forge/card/CardDb","getRulesOrElseUnsupported","(Ljava/lang/String;)Lforge/card/CardRules;",1,3,3,new JHandler[]{},M241));
c.Add(new JMethod(242,"forge/card/CardDb","setCardArtPreference","(Ljava/lang/String;)V",1,4,5,new JHandler[]{},M242));
c.Add(new JMethod(243,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;",1,3,2,new JHandler[]{},M243));
c.Add(new JMethod(244,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;",1,4,2,new JHandler[]{},M244));
c.Add(new JMethod(245,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperCard;",1,6,3,new JHandler[]{},M245));
}

private static void Add1(JClass c){
c.Add(new JMethod(246,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;",1,6,3,new JHandler[]{},M246));
c.Add(new JMethod(247,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;)Lforge/item/PaperCard;",1,7,4,new JHandler[]{},M247));
c.Add(new JMethod(248,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Lforge/item/PaperCard;",1,7,4,new JHandler[]{},M248));
c.Add(new JMethod(249,"forge/card/CardDb","tryGetCard","(Lforge/card/CardDb$CardRequest;)Lforge/item/PaperCard;",2,5,6,new JHandler[]{},M249));
c.Add(new JMethod(250,"forge/card/CardDb","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;ILjava/lang/String;Z)Lforge/item/PaperCard;",1,14,4,new JHandler[]{},M250));
c.Add(new JMethod(251,"forge/card/CardDb","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/function/Predicate;)Lforge/item/PaperCard;",1,5,5,new JHandler[]{},M251));
c.Add(new JMethod(252,"forge/card/CardDb","getCardFromEditionsReleasedBefore","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;",1,6,7,new JHandler[]{},M252));
c.Add(new JMethod(253,"forge/card/CardDb","getCardFromEditionsReleasedAfter","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;Ljava/util/function/Predicate;)Lforge/item/PaperCard;",1,6,7,new JHandler[]{},M253));
c.Add(new JMethod(254,"forge/card/CardDb","tryToGetCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/function/Predicate;)Lforge/item/PaperCard;",2,5,7,new JHandler[]{},M254));
c.Add(new JMethod(255,"forge/card/CardDb","tryToGetCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;ZLjava/util/function/Predicate;)Lforge/item/PaperCard;",2,17,4,new JHandler[]{},M255));
c.Add(new JMethod(256,"forge/card/CardDb","preferTraditionalFrame","(Lforge/item/PaperCard;Lforge/card/CardDb$CardRequest;)Lforge/item/PaperCard;",2,5,2,new JHandler[]{},M256));
c.Add(new JMethod(257,"forge/card/CardDb","getMaxArtIndex","(Ljava/lang/String;)I",1,5,2,new JHandler[]{},M257));
c.Add(new JMethod(258,"forge/card/CardDb","getArtCount","(Ljava/lang/String;Ljava/lang/String;)I",1,3,4,new JHandler[]{},M258));
c.Add(new JMethod(259,"forge/card/CardDb","getArtCount","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I",1,6,3,new JHandler[]{},M259));
c.Add(new JMethod(260,"forge/card/CardDb","isNonLegendaryCreatureName","(Ljava/lang/String;)Z",1,5,3,new JHandler[]{},M260));
c.Add(new JMethod(261,"forge/card/CardDb","getAllCards","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M261));
c.Add(new JMethod(262,"forge/card/CardDb","getUniqueCards","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M262));
c.Add(new JMethod(263,"forge/card/CardDb","getAllFaces","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M263));
c.Add(new JMethod(264,"forge/card/CardDb","streamAllCards","()Ljava/util/stream/Stream;",1,1,1,new JHandler[]{},M264));
c.Add(new JMethod(265,"forge/card/CardDb","streamUniqueCards","()Ljava/util/stream/Stream;",1,1,1,new JHandler[]{},M265));
c.Add(new JMethod(266,"forge/card/CardDb","streamAllFaces","()Ljava/util/stream/Stream;",1,1,1,new JHandler[]{},M266));
c.Add(new JMethod(267,"forge/card/CardDb","getAllNonPromosNonReprintsNoAlt","()Ljava/util/Collection;",1,1,2,new JHandler[]{},M267));
c.Add(new JMethod(268,"forge/card/CardDb","getNormalizedName","(Ljava/lang/String;)Ljava/lang/String;",1,2,3,new JHandler[]{},M268));
c.Add(new JMethod(269,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;",1,3,3,new JHandler[]{},M269));
c.Add(new JMethod(270,"forge/card/CardDb","getAllCardsNoAlt","(Ljava/lang/String;)Ljava/util/List;",1,3,3,new JHandler[]{},M270));
c.Add(new JMethod(271,"forge/card/CardDb","getAllCards","(Lforge/card/CardRules;)Ljava/util/List;",1,2,2,new JHandler[]{},M271));
c.Add(new JMethod(272,"forge/card/CardDb","getAllCards","(Lforge/item/PaperCard;)Ljava/util/List;",1,2,2,new JHandler[]{},M272));
c.Add(new JMethod(273,"forge/card/CardDb","getAllCards","(Ljava/util/function/Predicate;)Ljava/util/List;",1,2,2,new JHandler[]{},M273));
c.Add(new JMethod(274,"forge/card/CardDb","getAllCards","(Ljava/lang/String;Ljava/util/function/Predicate;)Ljava/util/List;",1,3,2,new JHandler[]{},M274));
c.Add(new JMethod(275,"forge/card/CardDb","getAllCards","(Lforge/item/PaperCard;Ljava/util/function/Predicate;)Ljava/util/List;",1,3,2,new JHandler[]{},M275));
c.Add(new JMethod(276,"forge/card/CardDb","getAllCards","(Lforge/card/CardRules;Ljava/util/function/Predicate;)Ljava/util/List;",1,3,2,new JHandler[]{},M276));
c.Add(new JMethod(277,"forge/card/CardDb","getAllCardsNoAlt","(Ljava/lang/String;Ljava/util/function/Predicate;)Ljava/util/List;",1,3,2,new JHandler[]{},M277));
c.Add(new JMethod(278,"forge/card/CardDb","getAllCards","(Lforge/card/CardEdition;)Ljava/util/Collection;",1,6,3,new JHandler[]{},M278));
c.Add(new JMethod(279,"forge/card/CardDb","getUniqueByName","(Ljava/lang/String;)Lforge/item/PaperCard;",1,3,3,new JHandler[]{},M279));
c.Add(new JMethod(280,"forge/card/CardDb","getUniqueByNameNoAlt","(Ljava/lang/String;)Lforge/item/PaperCard;",1,3,3,new JHandler[]{},M280));
c.Add(new JMethod(281,"forge/card/CardDb","getFaceByName","(Ljava/lang/String;)Lforge/card/ICardFace;",1,3,3,new JHandler[]{},M281));
c.Add(new JMethod(282,"forge/card/CardDb","contains","(Ljava/lang/String;)Z",1,2,3,new JHandler[]{},M282));
c.Add(new JMethod(283,"forge/card/CardDb","iterator","()Ljava/util/Iterator;",1,1,1,new JHandler[]{},M283));
c.Add(new JMethod(284,"forge/card/CardDb","wasPrintedInSets","(Ljava/util/Collection;)Ljava/util/function/Predicate;",1,2,2,new JHandler[]{},M284));
c.Add(new JMethod(285,"forge/card/CardDb","isLegal","(Ljava/util/Collection;)Ljava/util/function/Predicate;",1,2,1,new JHandler[]{},M285));
c.Add(new JMethod(286,"forge/card/CardDb","wasPrintedAtRarity","(Lforge/card/CardRarity;)Ljava/util/function/Predicate;",1,2,2,new JHandler[]{},M286));
c.Add(new JMethod(287,"forge/card/CardDb","createUnsupportedCard","(Ljava/lang/String;)Lforge/item/PaperCard;",1,9,5,new JHandler[]{},M287));
c.Add(new JMethod(288,"forge/card/CardDb","getEditor","()Lforge/card/CardDb$Editor;",1,1,1,new JHandler[]{},M288));
c.Add(new JMethod(289,"forge/card/CardDb","getAllCardsNoAlt","(Ljava/lang/String;Ljava/util/function/Predicate;)Ljava/util/Collection;",4161,3,3,new JHandler[]{},M289));
c.Add(new JMethod(290,"forge/card/CardDb","getAllCards","(Ljava/lang/String;Ljava/util/function/Predicate;)Ljava/util/Collection;",4161,3,3,new JHandler[]{},M290));
c.Add(new JMethod(291,"forge/card/CardDb","getAllCards","(Ljava/util/function/Predicate;)Ljava/util/Collection;",4161,2,2,new JHandler[]{},M291));
c.Add(new JMethod(292,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/Collection;",4161,2,2,new JHandler[]{},M292));
c.Add(new JMethod(293,"forge/card/CardDb","getAllCards","(Ljava/util/function/Predicate;)Ljava/lang/Iterable;",4161,2,2,new JHandler[]{},M293));
c.Add(new JMethod(294,"forge/card/CardDb","getAllCards","()Ljava/lang/Iterable;",4161,1,1,new JHandler[]{},M294));
c.Add(new JMethod(295,"forge/card/CardDb","lambda$wasPrintedAtRarity$24","(Lforge/card/CardRarity;Lforge/item/PaperCard;)Z",4098,3,3,new JHandler[]{},M295));
c.Add(new JMethod(296,"forge/card/CardDb","lambda$isLegal$23","(Ljava/util/Collection;Lforge/item/PaperCard;)Z",4106,2,2,new JHandler[]{},M296));
c.Add(new JMethod(297,"forge/card/CardDb","lambda$wasPrintedInSets$22","(Ljava/util/Collection;Lforge/item/PaperCard;)Z",4098,3,3,new JHandler[]{},M297));
c.Add(new JMethod(298,"forge/card/CardDb","lambda$wasPrintedInSets$21","(Ljava/util/Collection;Lforge/item/PaperCard;Ljava/lang/String;)Z",4106,3,2,new JHandler[]{},M298));
c.Add(new JMethod(299,"forge/card/CardDb","lambda$static$20","(Lforge/item/PaperCard;)Z",4106,3,2,new JHandler[]{},M299));
c.Add(new JMethod(300,"forge/card/CardDb","lambda$static$19","(Lforge/item/PaperCard;)Z",4106,3,2,new JHandler[]{},M300));
c.Add(new JMethod(301,"forge/card/CardDb","lambda$getArtCount$18","(Ljava/lang/String;Lforge/item/PaperCard;)Z",4106,2,2,new JHandler[]{},M301));
c.Add(new JMethod(302,"forge/card/CardDb","lambda$getArtCount$17","(Ljava/lang/String;Lforge/item/PaperCard;)Z",4106,2,2,new JHandler[]{},M302));
c.Add(new JMethod(303,"forge/card/CardDb","lambda$tryToGetCardFromEditions$16","(Lforge/card/CardDb$CardRequest;Lforge/item/PaperCard;)Z",4106,2,2,new JHandler[]{},M303));
c.Add(new JMethod(304,"forge/card/CardDb","lambda$tryToGetCardFromEditions$15","(Lforge/card/CardDb$CardRequest;Lforge/item/PaperCard;)Z",4106,2,2,new JHandler[]{},M304));
c.Add(new JMethod(305,"forge/card/CardDb","lambda$tryToGetCardFromEditions$14","(Lforge/card/CardDb$CardRequest;ZLjava/util/Date;Lforge/item/PaperCard;)Z",4098,6,2,new JHandler[]{},M305));
c.Add(new JMethod(306,"forge/card/CardDb","lambda$tryToGetCardFromEditions$13","(Lforge/item/PaperCard;)Z",4106,1,1,new JHandler[]{},M306));
c.Add(new JMethod(307,"forge/card/CardDb","lambda$getCardFromSet$12","(Ljava/lang/String;Lforge/item/PaperCard;)Z",4106,2,2,new JHandler[]{},M307));
c.Add(new JMethod(308,"forge/card/CardDb","lambda$getCardFromSet$11","(Ljava/lang/String;Ljava/lang/String;)Z",4106,2,2,new JHandler[]{},M308));
c.Add(new JMethod(309,"forge/card/CardDb","lambda$getCardFromSet$10","(Ljava/lang/String;Lforge/item/PaperCard;)Z",4106,2,2,new JHandler[]{},M309));
}

private static void Add2(JClass c){
c.Add(new JMethod(310,"forge/card/CardDb","lambda$getCardFromSet$9","(ILforge/item/PaperCard;)Z",4106,2,2,new JHandler[]{},M310));
c.Add(new JMethod(311,"forge/card/CardDb","lambda$getCardFromSet$8","(Ljava/lang/String;Ljava/lang/String;Lforge/item/PaperCard;)Z",4106,4,2,new JHandler[]{},M311));
c.Add(new JMethod(312,"forge/card/CardDb","lambda$getBestUniquePrint$7","(Ljava/util/Collection;)Lforge/item/PaperCard;",4106,1,1,new JHandler[]{},M312));
c.Add(new JMethod(313,"forge/card/CardDb","lambda$getBestUniquePrint$6","(Lforge/item/PaperCard;)Ljava/lang/Integer;",4098,2,2,new JHandler[]{},M313));
c.Add(new JMethod(314,"forge/card/CardDb","lambda$getBestUniquePrint$5","(Lforge/item/PaperCard;)Lforge/card/CardEdition;",4098,2,2,new JHandler[]{},M314));
c.Add(new JMethod(315,"forge/card/CardDb","lambda$getBestUniquePrint$4","(Lforge/item/PaperCard;)Ljava/lang/Integer;",4098,2,2,new JHandler[]{},M315));
c.Add(new JMethod(316,"forge/card/CardDb","lambda$getBestUniquePrint$3","(Lforge/item/PaperCard;)Ljava/lang/Integer;",4098,2,2,new JHandler[]{},M316));
c.Add(new JMethod(317,"forge/card/CardDb","lambda$getBestUniquePrint$2","(Lforge/item/PaperCard;)Z",4106,1,2,new JHandler[]{},M317));
c.Add(new JMethod(318,"forge/card/CardDb","lambda$getTraditionalFramePrints$1","(ILforge/item/PaperCard;)Z",4106,3,2,new JHandler[]{},M318));
c.Add(new JMethod(319,"forge/card/CardDb","lambda$addFromSetByName$0","(Lforge/card/CardRules;Lforge/card/CardEdition$EditionEntry;)Z",4106,2,2,new JHandler[]{},M319));
c.Add(new JMethod(320,"forge/card/CardDb","<clinit>","()V",8,0,2,new JHandler[]{},M320));
}

internal static JStep M208(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentSkipListMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentSkipListMap")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/concurrent/ConcurrentSkipListMap","<init>","(Ljava/util/Comparator;)V","invokespecial",15);}
case 15:{return rt.DynamicCall(f,"forge/card/CardDb:208:15:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",20);}
case 20:{return rt.Call(f,"com/google/common/collect/Multimaps","newListMultimap","(Ljava/util/Map;Lcom/google/common/base/Supplier;)Lcom/google/common/collect/ListMultimap;","invokestatic",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","allCardsByName","Lcom/google/common/collect/ListMultimap;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentSkipListMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentSkipListMap")));f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/concurrent/ConcurrentSkipListMap","<init>","(Ljava/util/Comparator;)V","invokespecial",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","rulesByAltName","Ljava/util/Map;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentSkipListMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentSkipListMap")));f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/card/CardDb","CARD_RULES_NAME_COMPARATOR","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb","CARD_RULES_NAME_COMPARATOR","Ljava/util/Comparator;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/concurrent/ConcurrentSkipListMap","<init>","(Ljava/util/Comparator;)V","invokespecial",51);}
case 51:{return rt.DynamicCall(f,"forge/card/CardDb:208:51:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",56);}
case 56:{return rt.Call(f,"com/google/common/collect/Multimaps","newListMultimap","(Ljava/util/Map;Lcom/google/common/base/Supplier;)Lcom/google/common/collect/ListMultimap;","invokestatic",59);}
case 59:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","allCardsByRules","Lcom/google/common/collect/ListMultimap;",value);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentSkipListMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentSkipListMap")));f.Pc=66;continue;}
case 66:{f.StackOp("dup");f.Pc=67;continue;}
case 67:{if(!rt.StaticReady(f,"forge/card/CardDb","CARD_RULES_NAME_COMPARATOR","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb","CARD_RULES_NAME_COMPARATOR","Ljava/util/Comparator;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/concurrent/ConcurrentSkipListMap","<init>","(Ljava/util/Comparator;)V","invokespecial",73);}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","uniqueCardsByRules","Ljava/util/Map;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentSkipListMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentSkipListMap")));f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/concurrent/ConcurrentSkipListMap","<init>","(Ljava/util/Comparator;)V","invokespecial",87);}
case 87:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","facesByName","Ljava/util/Map;",value);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentSkipListMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentSkipListMap")));f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/concurrent/ConcurrentSkipListMap","<init>","(Ljava/util/Comparator;)V","invokespecial",101);}
case 101:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","normalizedNames","Ljava/util/Map;",value);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=108;continue;}
case 108:{f.StackOp("dup");f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",112);}
case 112:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","flavorNameMappings","Ljava/util/Map;",value);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentSkipListMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentSkipListMap")));f.Pc=119;continue;}
case 119:{f.StackOp("dup");f.Pc=120;continue;}
case 120:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/concurrent/ConcurrentSkipListMap","<init>","(Ljava/util/Comparator;)V","invokespecial",126);}
case 126:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","uniqueCardsByFlavorName","Ljava/util/Map;",value);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",133);}
case 133:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","artIds","Ljava/util/Map;",value);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",140);}
case 140:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","nonLegendaryCreatureNames","Ljava/util/Map;",value);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[0]);f.Pc=144;continue;}
case 144:{if(!rt.EnsureInitialized(f,"forge/card/CardDb$Editor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardDb$Editor")));f.Pc=147;continue;}
case 147:{f.StackOp("dup");f.Pc=148;continue;}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/card/CardDb$Editor","<init>","(Lforge/card/CardDb;)V","invokespecial",152);}
case 152:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","editor","Lforge/card/CardDb$Editor;",value);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","filtered","Ljava/util/Set;",value);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[1]);f.Pc=162;continue;}
case 162:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","rulesByPrimaryName","Ljava/util/Map;",value);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[2]);f.Pc=167;continue;}
case 167:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;",value);f.Pc=170;continue;}
case 170:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=173;continue;}
case 173:{f.StackOp("dup");f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",177);}
case 177:{f.Locals[4]=f.Pop();f.Pc=179;continue;}
case 179:{f.Push(f.Locals[1]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",185);}
case 185:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",190);}
case 190:{f.Locals[5]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[5]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",199);}
case 199:{f.Pc=f.Pop().Int==0?311:202;continue;}
case 202:{f.Push(f.Locals[5]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",209);}
case 209:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=212;continue;}
case 212:{f.Locals[6]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[6]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/card/CardRules","hasPlaceholderFaces","()Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int==0?232:222;continue;}
case 222:{f.Push(f.Locals[4]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[6]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",231);}
case 231:{f.StackOp("pop");f.Pc=232;continue;}
case 232:{f.Push(f.Locals[3]);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[6]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/card/CardRules","getPreInitName","()Ljava/lang/String;","invokevirtual",238);}
case 238:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",243);}
case 243:{f.Pc=f.Pop().Int==0?249:246;continue;}
case 246:{f.Pc=192;continue;}
case 249:{f.Push(f.Locals[6]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/card/CardRules","getAllFaces","()Ljava/util/List;","invokevirtual",254);}
case 254:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",259);}
case 259:{f.Locals[7]=f.Pop();f.Pc=261;continue;}
case 261:{f.Push(f.Locals[7]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",268);}
case 268:{f.Pc=f.Pop().Int==0?294:271;continue;}
case 271:{f.Push(f.Locals[7]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",278);}
case 278:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=281;continue;}
case 281:{f.Locals[8]=f.Pop();f.Pc=283;continue;}
case 283:{f.Push(f.Locals[0]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[8]);f.Pc=286;continue;}
case 286:{f.Push(f.Locals[6]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/card/CardDb","addFaceToDbNames","(Lforge/card/ICardFace;Lforge/card/CardRules;)V","invokevirtual",291);}
case 291:{f.Pc=261;continue;}
case 294:{f.Push(f.Locals[6]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/card/CardRules","hasFunctionalVariants","()Z","invokevirtual",299);}
case 299:{f.Pc=f.Pop().Int==0?308:302;continue;}
case 302:{f.Push(f.Locals[0]);f.Pc=303;continue;}
case 303:{f.Push(f.Locals[6]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/card/CardDb","cacheRuleFlavorNames","(Lforge/card/CardRules;)V","invokevirtual",308);}
case 308:{f.Pc=192;continue;}
case 311:{f.Push(f.Locals[4]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",318);}
case 318:{f.Locals[5]=f.Pop();f.Pc=320;continue;}
case 320:{f.Push(f.Locals[5]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",327);}
case 327:{f.Pc=f.Pop().Int==0?354:330;continue;}
case 330:{f.Push(f.Locals[5]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",337);}
case 337:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=340;continue;}
case 340:{f.Locals[6]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[6]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[0]);f.Pc=345;continue;}
case 345:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","facesByName","Ljava/util/Map;"));f.Pc=348;continue;}
case 348:{return rt.Call(f,"forge/card/CardRules","supplyPlaceholderFaces","(Ljava/util/Map;)V","invokevirtual",351);}
case 351:{f.Pc=320;continue;}
case 354:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M209(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","facesByName","Ljava/util/Map;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByPrimaryName","Ljava/util/Map;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",34);}
case 34:{f.Pc=f.Pop().Int!=0?49:37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByAltName","Ljava/util/Map;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Map","putIfAbsent","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","stripAccents","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",53);}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?77:64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","normalizedNames","Ljava/util/Map;"));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",76);}
case 76:{f.StackOp("pop");f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/card/ICardFace","hasFunctionalVariants","()Z","invokeinterface",83);}
case 83:{f.Pc=f.Pop().Int==0?135:86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/card/ICardFace","getFunctionalVariants","()Ljava/util/Map;","invokeinterface",92);}
case 92:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",97);}
case 97:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",102);}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",111);}
case 111:{f.Pc=f.Pop().Int==0?135:114;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",121);}
case 121:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=124;continue;}
case 124:{f.Locals[6]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[6]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/card/CardDb","cacheFaceFlavorName","(Lforge/card/ICardFace;)V","invokevirtual",132);}
case 132:{f.Pc=104;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;","invokeinterface",141);}
case 141:{f.Pc=f.Pop().Reference==null?149:144;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/card/CardDb","cacheFaceFlavorName","(Lforge/card/ICardFace;)V","invokevirtual",149);}
case 149:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M210(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?12:11;continue;}
case 11:{return JStep.ReturnVoid;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","facesByName","Ljava/util/Map;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","putIfAbsent","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","stripAccents","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",28);}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int!=0?49:37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","normalizedNames","Ljava/util/Map;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M211(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getSupportedFunctionalVariants","()Ljava/util/Set;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference!=null?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/CardRules","getSupportedFunctionalVariants","()Ljava/util/Set;","invokevirtual",19);}
case 19:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?100:36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[5]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/card/CardRules","getDisplayNameForVariant","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Locals[6]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?68:65;continue;}
case 65:{f.Pc=26;continue;}
case 68:{f.Push(JValue.I(1));f.Pc=69;continue;}
case 69:{f.Locals[2]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByAltName","Ljava/util/Map;"));f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","flavorNameMappings","Ljava/util/Map;"));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[5]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",96);}
case 96:{f.StackOp("pop");f.Pc=97;continue;}
case 97:{f.Pc=26;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{f.Pc=f.Pop().Int==0?117:104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","flavorNameMappings","Ljava/util/Map;"));f.Pc=108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",116);}
case 116:{f.StackOp("pop");f.Pc=117;continue;}
case 117:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M212(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.DynamicCall(f,"forge/card/CardDb:212:11:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","artIds","Ljava/util/Map;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[5]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?53:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","artIds","Ljava/util/Map;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",49);}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=51;continue;}
case 51:{f.Locals[4]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","artIds","Ljava/util/Map;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",64);}
case 64:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","getFunctionalVariantName","()Ljava/lang/String;","invokevirtual",74);}
case 74:{f.Locals[6]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","getFlavorName","()Ljava/lang/String;","invokevirtual",80);}
case 80:{f.Locals[7]=f.Pop();f.Pc=82;continue;}
case 82:{if(!rt.StaticReady(f,"forge/card/CardDb","$assertionsDisabled","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb","$assertionsDisabled","Z"));f.Pc=85;continue;}
case 85:{f.Pc=f.Pop().Int!=0?106:88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{f.Pc=f.Pop().Reference==null?106:93;continue;}
case 93:{f.Push(f.Locals[7]);f.Pc=95;continue;}
case 95:{f.Pc=f.Pop().Reference==null?106:98;continue;}
case 98:{if(!rt.EnsureInitialized(f,"java/lang/AssertionError"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/AssertionError")));f.Pc=101;continue;}
case 101:{f.StackOp("dup");f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/AssertionError","<init>","()V","invokespecial",105);}
case 105:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 106:{f.Push(f.Locals[6]);f.Pc=108;continue;}
case 108:{f.Pc=f.Pop().Reference!=null?143:111;continue;}
case 111:{f.Push(f.Locals[3]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",115);}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",119);}
case 119:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",122);}
case 122:{f.Pc=f.Pop().Int!=0?143:125;continue;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","flavorNameMappings","Ljava/util/Map;"));f.Pc=129;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",133);}
case 133:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",138);}
case 138:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=141;continue;}
case 141:{f.Locals[6]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[7]);f.Pc=145;continue;}
case 145:{f.Pc=f.Pop().Reference==null?298:148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",152);}
case 152:{f.Push(JValue.R(rt.String("OM")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",157);}
case 157:{f.Pc=f.Pop().Int==0?165:160;continue;}
case 160:{f.Push(JValue.R(rt.String("Alchemy")));f.Pc=162;continue;}
case 162:{f.Pc=184;continue;}
case 165:{f.Push(f.Locals[1]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",169);}
case 169:{f.Push(JValue.R(rt.String("SLX")));f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",174);}
case 174:{f.Pc=f.Pop().Int==0?183:177;continue;}
case 177:{f.Push(JValue.R(rt.String("UniversesWithin")));f.Pc=180;continue;}
case 180:{f.Pc=184;continue;}
case 183:{f.Push(JValue.R(null));f.Pc=184;continue;}
case 184:{f.Locals[8]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[3]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[7]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[8]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/card/CardRules","findOrCreateVariantForFlavorName","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",194);}
case 194:{f.Locals[6]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[3]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[6]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/card/CardRules","getDisplayNameForVariant","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",202);}
case 202:{f.Locals[9]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[0]);f.Pc=205;continue;}
case 205:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","flavorNameMappings","Ljava/util/Map;"));f.Pc=208;continue;}
case 208:{f.Push(f.Locals[9]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",215);}
case 215:{f.Pc=f.Pop().Int!=0?298:218;continue;}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","flavorNameMappings","Ljava/util/Map;"));f.Pc=222;continue;}
case 222:{f.Push(f.Locals[9]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[6]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",231);}
case 231:{f.StackOp("pop");f.Pc=232;continue;}
case 232:{f.Push(f.Locals[0]);f.Pc=233;continue;}
case 233:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","flavorNameMappings","Ljava/util/Map;"));f.Pc=236;continue;}
case 236:{f.Push(f.Locals[3]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",240);}
case 240:{f.Push(JValue.R(rt.String("")));f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",247);}
case 247:{f.StackOp("pop");f.Pc=248;continue;}
case 248:{f.Push(f.Locals[0]);f.Pc=249;continue;}
case 249:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByAltName","Ljava/util/Map;"));f.Pc=252;continue;}
case 252:{f.Push(f.Locals[9]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[3]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",260);}
case 260:{f.StackOp("pop");f.Pc=261;continue;}
case 261:{f.Push(f.Locals[0]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[3]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",266);}
case 266:{f.Push(f.Locals[6]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/card/ICardFace","getFunctionalVariant","(Ljava/lang/String;)Lforge/card/ICardFace;","invokeinterface",273);}
case 273:{return rt.Call(f,"forge/card/CardDb","cacheFaceFlavorName","(Lforge/card/ICardFace;)V","invokevirtual",276);}
case 276:{f.Push(f.Locals[3]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",280);}
case 280:{f.Pc=f.Pop().Reference==null?298:283;continue;}
case 283:{f.Push(f.Locals[0]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[3]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",288);}
case 288:{f.Push(f.Locals[6]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/card/ICardFace","getFunctionalVariant","(Ljava/lang/String;)Lforge/card/ICardFace;","invokeinterface",295);}
case 295:{return rt.Call(f,"forge/card/CardDb","cacheFaceFlavorName","(Lforge/card/ICardFace;)V","invokevirtual",298);}
case 298:{f.Push(f.Locals[0]);f.Pc=299;continue;}
case 299:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=302;continue;}
case 302:{f.StackOp("dup");f.Pc=303;continue;}
case 303:{f.Push(f.Locals[3]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",308);}
case 308:{f.Push(f.Locals[2]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","rarity","()Lforge/card/CardRarity;","invokevirtual",312);}
case 312:{f.Push(f.Locals[4]);f.Pc=314;continue;}
case 314:{f.Push(JValue.I(0));f.Pc=315;continue;}
case 315:{f.Push(f.Locals[2]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;","invokevirtual",319);}
case 319:{f.Push(f.Locals[2]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","artistName","()Ljava/lang/String;","invokevirtual",323);}
case 323:{f.Push(f.Locals[6]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;IZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",328);}
case 328:{return rt.Call(f,"forge/card/CardDb","addCard","(Lforge/item/PaperCard;)V","invokevirtual",331);}
case 331:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M213(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardEdition","getCardInSet","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",5);}
case 5:{f.Locals[4]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardRules","hasFunctionalVariants","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?45:14;continue;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",21);}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.DynamicCall(f,"forge/card/CardDb:213:22:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardRules;)Ljava/util/function/Predicate;",27);}
case 27:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",32);}
case 32:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",35);}
case 35:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",52);}
case 52:{f.Pc=f.Pop().Int==0?57:55;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{f.Locals[5]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",67);}
case 67:{f.Locals[6]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[6]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?125:79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",86);}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{f.Locals[7]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[3]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",97);}
case 97:{f.Push(f.Locals[7]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;","invokevirtual",102);}
case 102:{return rt.Call(f,"forge/card/CardDb","containsPrinting","(Lforge/card/CardRules;Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?111:108;continue;}
case 108:{f.Pc=69;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[7]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[3]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/card/CardDb","addSetCard","(Lforge/card/CardEdition;Lforge/card/CardEdition$EditionEntry;Lforge/card/CardRules;)V","invokevirtual",119);}
case 119:{f.Push(JValue.I(1));f.Pc=120;continue;}
case 120:{f.Locals[5]=f.Pop();f.Pc=122;continue;}
case 122:{f.Pc=69;continue;}
case 125:{f.Push(f.Locals[5]);f.Pc=127;continue;}
case 127:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M214(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByRules","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",10);}
case 10:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?68:27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[5]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?65:51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",56);}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?65:63;continue;}
case 63:{f.Push(JValue.I(1));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 65:{f.Pc=17;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M215(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByName","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/ListMultimap","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByRules","Lcom/google/common/collect/ListMultimap;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"com/google/common/collect/ListMultimap","clear","()V","invokeinterface",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByRules","Ljava/util/Map;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByFlavorName","Ljava/util/Map;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","facesByName","Ljava/util/Map;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",45);}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByAltName","Ljava/util/Map;"));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",54);}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByPrimaryName","Ljava/util/Map;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",63);}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","normalizedNames","Ljava/util/Map;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",72);}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","flavorNameMappings","Ljava/util/Map;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",81);}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","artIds","Ljava/util/Map;"));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",90);}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","nonLegendaryCreatureNames","Ljava/util/Map;"));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",99);}
case 99:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M216(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","hasPlaceholderFaces","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?26:7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","facesByName","Ljava/util/Map;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/CardRules","supplyPlaceholderFaces","(Ljava/util/Map;)V","invokevirtual",15);}
case 15:{f.Pc=26;continue;}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/NoSuchElementException","printStackTrace","()V","invokevirtual",25);}
case 25:{return JStep.ReturnVoid;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByPrimaryName","Ljava/util/Map;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Map","putIfAbsent","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Reference!=null?114:43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","filtered","Ljava/util/Set;"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/CardRules","getPreInitName","()Ljava/lang/String;","invokevirtual",51);}
case 51:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",56);}
case 56:{f.Pc=f.Pop().Int!=0?114:59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/CardRules","getAllFaces","()Ljava/util/List;","invokevirtual",63);}
case 63:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",68);}
case 68:{f.Locals[4]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int==0?102:80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",87);}
case 87:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=90;continue;}
case 90:{f.Locals[5]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[5]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[3]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/card/CardDb","addFaceToDbNames","(Lforge/card/ICardFace;Lforge/card/CardRules;)V","invokevirtual",99);}
case 99:{f.Pc=70;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/card/CardRules","hasFunctionalVariants","()Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?114:109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/card/CardDb","cacheRuleFlavorNames","(Lforge/card/CardRules;)V","invokevirtual",114);}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{f.Locals[4]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=121;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",125);}
case 125:{f.Locals[5]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[5]);f.Pc=129;continue;}
case 129:{f.Pc=f.Pop().Reference==null?143:132;continue;}
case 132:{f.Push(f.Locals[5]);f.Pc=134;continue;}
case 134:{if(!rt.StaticReady(f,"forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"));f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/card/CardEdition","equals","(Ljava/lang/Object;)Z","invokevirtual",140);}
case 140:{f.Pc=f.Pop().Int==0?193:143;continue;}
case 143:{f.Push(f.Locals[0]);f.Pc=144;continue;}
case 144:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/card/CardEdition$Collection","iterator","()Ljava/util/Iterator;","invokevirtual",150);}
case 150:{f.Locals[6]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[6]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",159);}
case 159:{f.Pc=f.Pop().Int==0?190:162;continue;}
case 162:{f.Push(f.Locals[6]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",169);}
case 169:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=172;continue;}
case 172:{f.Locals[7]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[4]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[7]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[3]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/card/CardDb","addFromSetByAnyName","(Ljava/lang/String;Lforge/card/CardEdition;Lforge/card/CardRules;)Z","invokevirtual",184);}
case 184:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=185;continue;}
case 185:{f.Locals[4]=f.Pop();f.Pc=187;continue;}
case 187:{f.Pc=152;continue;}
case 190:{f.Pc=206;continue;}
case 193:{f.Push(f.Locals[4]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[5]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[3]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/card/CardDb","addFromSetByAnyName","(Ljava/lang/String;Lforge/card/CardEdition;Lforge/card/CardRules;)Z","invokevirtual",203);}
case 203:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=204;continue;}
case 204:{f.Locals[4]=f.Pop();f.Pc=206;continue;}
case 206:{f.Push(f.Locals[4]);f.Pc=208;continue;}
case 208:{f.Pc=f.Pop().Int==0?216:211;continue;}
case 211:{f.Push(f.Locals[0]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[3]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/card/CardDb","reIndex","(Lforge/card/CardRules;)V","invokevirtual",216);}
case 216:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M217(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByRules","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int!=0?88:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/CardDb","getBestUniquePrint","(Ljava/util/Collection;)Lforge/item/PaperCard;","invokevirtual",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/card/CardDb","artPrefs","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb","artPrefs","Ljava/util/Map;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",33);}
case 33:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Pc=f.Pop().Reference==null?76:48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",54);}
case 54:{f.Locals[5]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{f.Pc=f.Pop().Reference==null?76:61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",66);}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int==0?76:73;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{f.Locals[3]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByRules","Ljava/util/Map;"));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[3]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/card/CardRules","hasFunctionalVariants","()Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?102:95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/card/CardRules","getSupportedFunctionalVariants","()Ljava/util/Set;","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Reference!=null?103:102;continue;}
case 102:{return JStep.ReturnVoid;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/card/CardRules","getSupportedFunctionalVariants","()Ljava/util/Set;","invokevirtual",107);}
case 107:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",112);}
case 112:{f.Locals[3]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[3]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",119);}
case 119:{f.Pc=f.Pop().Int==0?239:122;continue;}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",128);}
case 128:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=131;continue;}
case 131:{f.Locals[4]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/card/CardRules","getDisplayNameForVariant","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",139);}
case 139:{f.Locals[5]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[5]);f.Pc=143;continue;}
case 143:{f.Pc=f.Pop().Reference==null?113:146;continue;}
case 146:{f.Push(f.Locals[5]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",152);}
case 152:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",155);}
case 155:{f.Pc=f.Pop().Int==0?161:158;continue;}
case 158:{f.Pc=113;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","flavorNameMappings","Ljava/util/Map;"));f.Pc=165;continue;}
case 165:{f.Push(f.Locals[5]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",172);}
case 172:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=175;continue;}
case 175:{f.Locals[6]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[6]);f.Pc=179;continue;}
case 179:{f.Pc=f.Pop().Reference==null?113:182;continue;}
case 182:{f.Push(f.Locals[6]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int==0?195:192;continue;}
case 192:{f.Pc=113;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByName","Lcom/google/common/collect/ListMultimap;"));f.Pc=199;continue;}
case 199:{f.Push(f.Locals[5]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",206);}
case 206:{f.Locals[7]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[7]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",215);}
case 215:{f.Pc=f.Pop().Int!=0?236:218;continue;}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByFlavorName","Ljava/util/Map;"));f.Pc=222;continue;}
case 222:{f.Push(f.Locals[5]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[0]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[7]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/card/CardDb","getBestUniquePrint","(Ljava/util/Collection;)Lforge/item/PaperCard;","invokevirtual",230);}
case 230:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",235);}
case 235:{f.StackOp("pop");f.Pc=236;continue;}
case 236:{f.Pc=113;continue;}
case 239:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M218(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[3]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardDb","addFromSetByName","(Ljava/lang/String;Lforge/card/CardEdition;Lforge/card/CardRules;)Z","invokevirtual",10);}
case 10:{f.Locals[4]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int!=0?35:23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/card/CardDb","addFromSetByName","(Ljava/lang/String;Lforge/card/CardEdition;Lforge/card/CardRules;)Z","invokevirtual",32);}
case 32:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/CardRules","hasFunctionalVariants","()Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?132:42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/CardRules","getSupportedFunctionalVariants","()Ljava/util/Set;","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Reference==null?132:49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/card/CardRules","getSupportedFunctionalVariants","()Ljava/util/Set;","invokevirtual",53);}
case 53:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",58);}
case 58:{f.Locals[5]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",67);}
case 67:{f.Pc=f.Pop().Int==0?132:70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{f.Locals[6]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/card/CardRules","getDisplayNameForVariant","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",88);}
case 88:{f.Locals[7]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[7]);f.Pc=92;continue;}
case 92:{f.Pc=f.Pop().Reference==null?129:95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",101);}
case 101:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int!=0?129:107;continue;}
case 107:{f.Push(f.Locals[7]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int!=0?129:116;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[7]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/card/CardDb","addFromSetByName","(Ljava/lang/String;Lforge/card/CardEdition;Lforge/card/CardRules;)Z","invokevirtual",126);}
case 126:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=127;continue;}
case 127:{f.Locals[4]=f.Pop();f.Pc=129;continue;}
case 129:{f.Pc=60;continue;}
case 132:{f.Push(f.Locals[4]);f.Pc=134;continue;}
case 134:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M219(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/LinkedHashSet","<init>","()V","invokespecial",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(JValue.R(null));f.Pc=19;continue;}
case 19:{f.Locals[6]=f.Pop();f.Pc=21;continue;}
case 21:{if(!rt.EnsureInitialized(f,"java/util/Date"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Date")));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Date","<init>","()V","invokespecial",28);}
case 28:{f.Locals[7]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/card/CardEdition$Collection","getOrderedEditions","()Ljava/lang/Iterable;","invokevirtual",37);}
case 37:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",42);}
case 42:{f.Locals[8]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[8]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int==0?489:54;continue;}
case 54:{f.Push(f.Locals[8]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{f.Locals[9]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[9]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",71);}
case 71:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;"));f.Pc=74;continue;}
case 74:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?88:77;continue;}
case 77:{f.Push(f.Locals[9]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",82);}
case 82:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"));f.Pc=85;continue;}
case 85:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?92:88;continue;}
case 88:{f.Push(JValue.I(1));f.Pc=89;continue;}
case 89:{f.Pc=93;continue;}
case 92:{f.Push(JValue.I(0));f.Pc=93;continue;}
case 93:{f.Locals[10]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[10]);f.Pc=97;continue;}
case 97:{f.Pc=f.Pop().Int!=0?111:100;continue;}
case 100:{f.Push(f.Locals[9]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",105);}
case 105:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","REPRINT","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","REPRINT","Lforge/card/CardEdition$Type;"));f.Pc=108;continue;}
case 108:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?115:111;continue;}
case 111:{f.Push(JValue.I(1));f.Pc=112;continue;}
case 112:{f.Pc=116;continue;}
case 115:{f.Push(JValue.I(0));f.Pc=116;continue;}
case 116:{f.Locals[11]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{f.Pc=f.Pop().Int==0?153:122;continue;}
case 122:{f.Push(f.Locals[11]);f.Pc=124;continue;}
case 124:{f.Pc=f.Pop().Int==0?153:127;continue;}
case 127:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=130;continue;}
case 130:{f.Push(f.Locals[9]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",135);}
case 135:{f.Push(f.Locals[9]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/card/CardEdition","getAllCardsInSet","()Ljava/util/List;","invokevirtual",140);}
case 140:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",145);}
case 145:{return rt.DynamicCall(f,"forge/card/CardDb:219:145:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",150);}
case 150:{return rt.Call(f,"java/io/PrintStream","print","(Ljava/lang/String;)V","invokevirtual",153);}
case 153:{f.Push(f.Locals[10]);f.Pc=155;continue;}
case 155:{f.Pc=f.Pop().Int==0?180:158;continue;}
case 158:{f.Push(f.Locals[9]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",163);}
case 163:{f.Push(f.Locals[7]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Date","after","(Ljava/util/Date;)Z","invokevirtual",168);}
case 168:{f.Pc=f.Pop().Int==0?180:171;continue;}
case 171:{f.Push(f.Locals[6]);f.Pc=173;continue;}
case 173:{f.Pc=f.Pop().Reference!=null?180:176;continue;}
case 176:{f.Push(f.Locals[9]);f.Pc=178;continue;}
case 178:{f.Locals[6]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[9]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/card/CardEdition","getAllCardsInSet","()Ljava/util/List;","invokevirtual",185);}
case 185:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",190);}
case 190:{f.Locals[12]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[12]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",199);}
case 199:{f.Pc=f.Pop().Int==0?331:202;continue;}
case 202:{f.Push(f.Locals[12]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",209);}
case 209:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=212;continue;}
case 212:{f.Locals[13]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[0]);f.Pc=215;continue;}
case 215:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByPrimaryName","Ljava/util/Map;"));f.Pc=218;continue;}
case 218:{f.Push(f.Locals[13]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",223);}
case 223:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",228);}
case 228:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=231;continue;}
case 231:{f.Locals[14]=f.Pop();f.Pc=233;continue;}
case 233:{f.Push(f.Locals[14]);f.Pc=235;continue;}
case 235:{f.Pc=f.Pop().Reference!=null?257:238;continue;}
case 238:{f.Push(f.Locals[0]);f.Pc=239;continue;}
case 239:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByAltName","Ljava/util/Map;"));f.Pc=242;continue;}
case 242:{f.Push(f.Locals[13]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",247);}
case 247:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",252);}
case 252:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=255;continue;}
case 255:{f.Locals[14]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[14]);f.Pc=259;continue;}
case 259:{f.Pc=f.Pop().Reference!=null?278:262;continue;}
case 262:{f.Push(f.Locals[5]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[13]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",269);}
case 269:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",274);}
case 274:{f.StackOp("pop");f.Pc=275;continue;}
case 275:{f.Pc=192;continue;}
case 278:{f.Push(f.Locals[14]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/card/CardRules","hasFunctionalVariants","()Z","invokevirtual",283);}
case 283:{f.Pc=f.Pop().Int==0?318:286;continue;}
case 286:{f.Push(f.Locals[13]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","getFunctionalVariantName","()Ljava/lang/String;","invokevirtual",291);}
case 291:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",294);}
case 294:{f.Pc=f.Pop().Int==0?318:297;continue;}
case 297:{f.Push(f.Locals[14]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/card/CardRules","getSupportedFunctionalVariants","()Ljava/util/Set;","invokevirtual",302);}
case 302:{f.Push(f.Locals[13]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","getFunctionalVariantName","()Ljava/lang/String;","invokevirtual",307);}
case 307:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",312);}
case 312:{f.Pc=f.Pop().Int!=0?318:315;continue;}
case 315:{f.Pc=192;continue;}
case 318:{f.Push(f.Locals[0]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[9]);f.Pc=321;continue;}
case 321:{f.Push(f.Locals[13]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[14]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/card/CardDb","addSetCard","(Lforge/card/CardEdition;Lforge/card/CardEdition$EditionEntry;Lforge/card/CardRules;)V","invokevirtual",328);}
case 328:{f.Pc=192;continue;}
case 331:{f.Push(f.Locals[11]);f.Pc=333;continue;}
case 333:{f.Pc=f.Pop().Int==0?451:336;continue;}
case 336:{f.Push(f.Locals[1]);f.Pc=337;continue;}
case 337:{f.Pc=f.Pop().Int==0?451:340;continue;}
case 340:{f.Push(f.Locals[5]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",347);}
case 347:{f.Pc=f.Pop().Int==0?362:350;continue;}
case 350:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=353;continue;}
case 353:{f.Push(JValue.R(rt.String(" ... 100% ")));f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",359);}
case 359:{f.Pc=451;continue;}
case 362:{f.Push(f.Locals[9]);f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/card/CardEdition","getAllCardsInSet","()Ljava/util/List;","invokevirtual",367);}
case 367:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",372);}
case 372:{f.Push(f.Locals[5]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",379);}
case 379:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=380;continue;}
case 380:{f.Push(JValue.I(10000));f.Pc=383;continue;}
case 383:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=384;continue;}
case 384:{f.Push(f.Locals[9]);f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/card/CardEdition","getAllCardsInSet","()Ljava/util/List;","invokevirtual",389);}
case 389:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",394);}
case 394:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=395;continue;}
case 395:{f.Locals[12]=f.Pop();f.Pc=397;continue;}
case 397:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=400;continue;}
case 400:{f.Push(JValue.R(rt.String(" ... %.2f%% (%s missing: %s)%n")));f.Pc=403;continue;}
case 403:{f.Push(JValue.I(3));f.Pc=404;continue;}
case 404:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=407;continue;}
case 407:{f.StackOp("dup");f.Pc=408;continue;}
case 408:{f.Push(JValue.I(0));f.Pc=409;continue;}
case 409:{f.Push(f.Locals[12]);f.Pc=411;continue;}
case 411:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=412;continue;}
case 412:{f.Push(JValue.F(0.009999999776482582f));f.Pc=415;continue;}
case 415:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fmul",a,b));f.Pc=416;continue;}
case 416:{return rt.Call(f,"java/lang/Float","valueOf","(F)Ljava/lang/Float;","invokestatic",419);}
case 419:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=420;continue;}
case 420:{f.StackOp("dup");f.Pc=421;continue;}
case 421:{f.Push(JValue.I(1));f.Pc=422;continue;}
case 422:{f.Push(f.Locals[5]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",429);}
case 429:{f.Push(JValue.R(rt.String("card")));f.Pc=432;continue;}
case 432:{return rt.Call(f,"forge/util/Lang","nounWithAmount","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",435);}
case 435:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=436;continue;}
case 436:{f.StackOp("dup");f.Pc=437;continue;}
case 437:{f.Push(JValue.I(2));f.Pc=438;continue;}
case 438:{f.Push(f.Locals[5]);f.Pc=440;continue;}
case 440:{f.Push(JValue.R(rt.String(" | ")));f.Pc=443;continue;}
case 443:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",446);}
case 446:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=447;continue;}
case 447:{return rt.Call(f,"java/io/PrintStream","printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;","invokevirtual",450);}
case 450:{f.StackOp("pop");f.Pc=451;continue;}
case 451:{f.Push(f.Locals[11]);f.Pc=453;continue;}
case 453:{f.Pc=f.Pop().Int==0?470:456;continue;}
case 456:{f.Push(f.Locals[2]);f.Pc=457;continue;}
case 457:{f.Pc=f.Pop().Int==0?470:460;continue;}
case 460:{f.Push(f.Locals[4]);f.Pc=462;continue;}
case 462:{f.Push(f.Locals[5]);f.Pc=464;continue;}
case 464:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",469);}
case 469:{f.StackOp("pop");f.Pc=470;continue;}
case 470:{f.Push(f.Locals[5]);f.Pc=472;continue;}
case 472:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",477);}
case 477:{f.Push(f.Locals[0]);f.Pc=478;continue;}
case 478:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","artIds","Ljava/util/Map;"));f.Pc=481;continue;}
case 481:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",486);}
case 486:{f.Pc=44;continue;}
case 489:{f.Push(f.Locals[2]);f.Pc=490;continue;}
case 490:{f.Pc=f.Pop().Int==0?531:493;continue;}
case 493:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=496;continue;}
case 496:{f.Push(JValue.R(rt.String("Totally %d cards not implemented: %s\n")));f.Pc=499;continue;}
case 499:{f.Push(JValue.I(2));f.Pc=500;continue;}
case 500:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=503;continue;}
case 503:{f.StackOp("dup");f.Pc=504;continue;}
case 504:{f.Push(JValue.I(0));f.Pc=505;continue;}
case 505:{f.Push(f.Locals[4]);f.Pc=507;continue;}
case 507:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",512);}
case 512:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",515);}
case 515:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=516;continue;}
case 516:{f.StackOp("dup");f.Pc=517;continue;}
case 517:{f.Push(JValue.I(1));f.Pc=518;continue;}
case 518:{f.Push(f.Locals[4]);f.Pc=520;continue;}
case 520:{f.Push(JValue.R(rt.String(" | ")));f.Pc=523;continue;}
case 523:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",526);}
case 526:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=527;continue;}
case 527:{return rt.Call(f,"java/io/PrintStream","printf","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;","invokevirtual",530);}
case 530:{f.StackOp("pop");f.Pc=531;continue;}
case 531:{f.Push(f.Locals[0]);f.Pc=532;continue;}
case 532:{f.Push(f.Locals[3]);f.Pc=533;continue;}
case 533:{f.Push(f.Locals[6]);f.Pc=535;continue;}
case 535:{return rt.Call(f,"forge/card/CardDb","addUnassignedCardPrints","(ZLforge/card/CardEdition;)V","invokevirtual",538);}
case 538:{f.Push(f.Locals[0]);f.Pc=539;continue;}
case 539:{f.Push(JValue.I(1));f.Pc=540;continue;}
case 540:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","initialized","Z",value);f.Pc=543;continue;}
case 543:{f.Push(f.Locals[0]);f.Pc=544;continue;}
case 544:{return rt.Call(f,"forge/card/CardDb","reIndex","()V","invokevirtual",547);}
case 547:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M220(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{if(!rt.EnsureInitialized(f,"java/util/Date"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Date")));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Date","<init>","()V","invokespecial",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardEdition$Collection","getOrderedEditions","()Ljava/lang/Iterable;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?101:34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",51);}
case 51:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;"));f.Pc=54;continue;}
case 54:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?68:57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",62);}
case 62:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"));f.Pc=65;continue;}
case 65:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?72:68;continue;}
case 68:{f.Push(JValue.I(1));f.Pc=69;continue;}
case 69:{f.Pc=73;continue;}
case 72:{f.Push(JValue.I(0));f.Pc=73;continue;}
case 73:{f.Locals[6]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[6]);f.Pc=77;continue;}
case 77:{f.Pc=f.Pop().Int==0?98:80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",85);}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Date","after","(Ljava/util/Date;)Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?98:92;continue;}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{f.Locals[2]=f.Pop();f.Pc=95;continue;}
case 95:{f.Pc=101;continue;}
case 98:{f.Pc=24;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/card/CardDb","addUnassignedCardPrints","(ZLforge/card/CardEdition;)V","invokevirtual",107);}
case 107:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M221(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?19:4;continue;}
case 4:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",11);}
case 11:{return rt.DynamicCall(f,"forge/card/CardDb:221:11:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",16);}
case 16:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByPrimaryName","Ljava/util/Map;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",28);}
case 28:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?238:43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[4]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/card/CardDb","contains","(Ljava/lang/String;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int!=0?235:66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/card/CardRules","isCustom","()Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int!=0?194:74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Pc=f.Pop().Reference==null?129:78;continue;}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/card/CardRules","getPath","()Ljava/lang/String;","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Reference==null?129:86;continue;}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/card/CardRules","getPath","()Ljava/lang/String;","invokevirtual",91);}
case 91:{f.Push(JValue.R(rt.String("upcoming/")));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",97);}
case 97:{f.Pc=f.Pop().Int==0?129:100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{f.Push(f.Locals[4]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",111);}
case 111:{if(!rt.StaticReady(f,"forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;)V","invokespecial",117);}
case 117:{return rt.Call(f,"forge/card/CardDb","addCard","(Lforge/item/PaperCard;)V","invokevirtual",120);}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[4]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/card/CardDb","reIndex","(Lforge/card/CardRules;)V","invokevirtual",126);}
case 126:{f.Pc=235;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Pc=f.Pop().Int==0?235:133;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","filtered","Ljava/util/Set;"));f.Pc=137;continue;}
case 137:{f.Push(f.Locals[4]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",142);}
case 142:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",147);}
case 147:{f.Pc=f.Pop().Int!=0?235:150;continue;}
case 150:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[4]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",158);}
case 158:{return rt.DynamicCall(f,"forge/card/CardDb:221:158:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",163);}
case 163:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",166);}
case 166:{f.Push(f.Locals[0]);f.Pc=167;continue;}
case 167:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=170;continue;}
case 170:{f.StackOp("dup");f.Pc=171;continue;}
case 171:{f.Push(f.Locals[4]);f.Pc=173;continue;}
case 173:{f.Push(JValue.R(rt.String("???")));f.Pc=176;continue;}
case 176:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;)V","invokespecial",182);}
case 182:{return rt.Call(f,"forge/card/CardDb","addCard","(Lforge/item/PaperCard;)V","invokevirtual",185);}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[4]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/card/CardDb","reIndex","(Lforge/card/CardRules;)V","invokevirtual",191);}
case 191:{f.Pc=235;continue;}
case 194:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=197;continue;}
case 197:{f.Push(f.Locals[4]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",202);}
case 202:{return rt.DynamicCall(f,"forge/card/CardDb:221:202:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",207);}
case 207:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",210);}
case 210:{f.Push(f.Locals[0]);f.Pc=211;continue;}
case 211:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=214;continue;}
case 214:{f.StackOp("dup");f.Pc=215;continue;}
case 215:{f.Push(f.Locals[4]);f.Pc=217;continue;}
case 217:{f.Push(JValue.R(rt.String("USER")));f.Pc=220;continue;}
case 220:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;)V","invokespecial",226);}
case 226:{return rt.Call(f,"forge/card/CardDb","addCard","(Lforge/item/PaperCard;)V","invokevirtual",229);}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[4]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/card/CardDb","reIndex","(Lforge/card/CardRules;)V","invokevirtual",235);}
case 235:{f.Pc=34;continue;}
case 238:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M222(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","filtered","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?17:16;continue;}
case 16:{return JStep.ReturnVoid;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByName","Lcom/google/common/collect/ListMultimap;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"com/google/common/collect/ListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",38);}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByRules","Lcom/google/common/collect/ListMultimap;"));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"com/google/common/collect/ListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",55);}
case 55:{if(!rt.StaticReady(f,"forge/card/CardSplitType","None","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","None","Lforge/card/CardSplitType;"));f.Pc=58;continue;}
case 58:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?69:61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/card/CardRules","hasFunctionalVariants","()Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int!=0?69:68;continue;}
case 68:{return JStep.ReturnVoid;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/item/PaperCard","getAllFaces","()Ljava/util/List;","invokevirtual",73);}
case 73:{f.Locals[4]=f.Pop();f.Pc=75;continue;}
case 75:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",82);}
case 82:{f.Locals[5]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",91);}
case 91:{return rt.DynamicCall(f,"forge/card/CardDb:222:91:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",96);}
case 96:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",101);}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{f.StackOp("dup");f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",107);}
case 107:{f.StackOp("pop");f.Pc=108;continue;}
case 108:{return rt.DynamicCall(f,"forge/card/CardDb:222:108:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Set;)Ljava/util/function/Consumer;",113);}
case 113:{return rt.Call(f,"java/util/stream/Stream","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",118);}
case 118:{f.Push(f.Locals[4]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",125);}
case 125:{return rt.DynamicCall(f,"forge/card/CardDb:222:125:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",130);}
case 130:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",135);}
case 135:{return rt.DynamicCall(f,"forge/card/CardDb:222:135:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",140);}
case 140:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",145);}
case 145:{f.Push(f.Locals[5]);f.Pc=147;continue;}
case 147:{f.StackOp("dup");f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",151);}
case 151:{f.StackOp("pop");f.Pc=152;continue;}
case 152:{return rt.DynamicCall(f,"forge/card/CardDb:222:152:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Set;)Ljava/util/function/Consumer;",157);}
case 157:{return rt.Call(f,"java/util/stream/Stream","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",162);}
case 162:{f.Push(f.Locals[5]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[2]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",170);}
case 170:{f.StackOp("pop");f.Pc=171;continue;}
case 171:{f.Push(f.Locals[5]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",178);}
case 178:{f.Locals[6]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[6]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",187);}
case 187:{f.Pc=f.Pop().Int==0?218:190;continue;}
case 190:{f.Push(f.Locals[6]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",197);}
case 197:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=200;continue;}
case 200:{f.Locals[7]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[0]);f.Pc=203;continue;}
case 203:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByName","Lcom/google/common/collect/ListMultimap;"));f.Pc=206;continue;}
case 206:{f.Push(f.Locals[7]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[1]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"com/google/common/collect/ListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",214);}
case 214:{f.StackOp("pop");f.Pc=215;continue;}
case 215:{f.Pc=180;continue;}
case 218:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M223(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByRules","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByFlavorName","Ljava/util/Map;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByRules","Lcom/google/common/collect/ListMultimap;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"com/google/common/collect/ListMultimap","asMap","()Ljava/util/Map;","invokeinterface",27);}
case 27:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",32);}
case 32:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",37);}
case 37:{f.Locals[1]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",44);}
case 44:{f.Pc=f.Pop().Int==0?94:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[2]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",64);}
case 64:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/card/CardDb","getBestUniquePrint","(Ljava/util/Collection;)Lforge/item/PaperCard;","invokevirtual",70);}
case 70:{f.Locals[3]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByRules","Ljava/util/Map;"));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Pc=38;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","flavorNameMappings","Ljava/util/Map;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",103);}
case 103:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",108);}
case 108:{f.Locals[1]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",115);}
case 115:{f.Pc=f.Pop().Int==0?190:118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",124);}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{f.Locals[2]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[2]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",134);}
case 134:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",142);}
case 142:{f.Pc=f.Pop().Int==0?148:145;continue;}
case 145:{f.Pc=109;continue;}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",154);}
case 154:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=157;continue;}
case 157:{f.Locals[3]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByName","Lcom/google/common/collect/ListMultimap;"));f.Pc=163;continue;}
case 163:{f.Push(f.Locals[3]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",169);}
case 169:{return rt.Call(f,"forge/card/CardDb","getBestUniquePrint","(Ljava/util/Collection;)Lforge/item/PaperCard;","invokevirtual",172);}
case 172:{f.Locals[4]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByFlavorName","Ljava/util/Map;"));f.Pc=178;continue;}
case 178:{f.Push(f.Locals[3]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[4]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",186);}
case 186:{f.StackOp("pop");f.Pc=187;continue;}
case 187:{f.Pc=109;continue;}
case 190:{f.Push(f.Locals[0]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/card/CardDb","restorePreferredArts","()V","invokevirtual",194);}
case 194:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M224(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardDb","artPrefs","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb","artPrefs","Ljava/util/Map;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",12);}
case 12:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",15);}
case 15:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",18);}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?89:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Reference!=null?45:42;continue;}
case 42:{f.Pc=19;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",50);}
case 50:{f.Locals[3]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Reference==null?86:55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByRules","Lcom/google/common/collect/ListMultimap;"));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",63);}
case 63:{return rt.Call(f,"com/google/common/collect/ListMultimap","containsKey","(Ljava/lang/Object;)Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int==0?86:71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByRules","Ljava/util/Map;"));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",79);}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Pc=19;continue;}
case 89:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M225(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?12:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardDb","isTraditionalFramePrint","(Lforge/item/PaperCard;)Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?14:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/CardDb","getTraditionalFramePrints","(Lforge/item/PaperCard;)Ljava/util/List;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?31:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",36);}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",40);}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",48);}
case 48:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{f.Locals[3]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/item/PaperCard","isFoil","()Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?72:65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",69);}
case 69:{f.Pc=73;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M226(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{return rt.Call(f,"java/util/Collections","emptyList","()Ljava/util/List;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference!=null?28:24;continue;}
case 24:{return rt.Call(f,"java/util/Collections","emptyList","()Ljava/util/List;","invokestatic",27);}
case 27:{return JStep.Return(f.Pop());}
case 28:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",35);}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByRules","Lcom/google/common/collect/ListMultimap;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",44);}
case 44:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",49);}
case 49:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",54);}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int==0?132:66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",73);}
case 73:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=76;continue;}
case 76:{f.Locals[5]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[5]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",83);}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",87);}
case 87:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?129:93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[5]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",99);}
case 99:{return rt.Call(f,"forge/card/CardEdition","isTraditionalFrame","(Ljava/lang/String;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int==0?129:105;continue;}
case 105:{f.Push(f.Locals[5]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/item/PaperCard","getFunctionalVariant","()Ljava/lang/String;","invokevirtual",110);}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/item/PaperCard","getFunctionalVariant","()Ljava/lang/String;","invokevirtual",114);}
case 114:{return rt.Call(f,"java/util/Objects","equals","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",117);}
case 117:{f.Pc=f.Pop().Int==0?129:120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",128);}
case 128:{f.StackOp("pop");f.Pc=129;continue;}
case 129:{f.Pc=56;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",136);}
case 136:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",139);}
case 139:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",142);}
case 142:{f.Pc=f.Pop().Int!=0?216:145;continue;}
case 145:{f.Push(JValue.I(2147483647));f.Pc=148;continue;}
case 148:{f.Locals[4]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[3]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",156);}
case 156:{f.Locals[5]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[5]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",165);}
case 165:{f.Pc=f.Pop().Int==0?198:168;continue;}
case 168:{f.Push(f.Locals[5]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",175);}
case 175:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=178;continue;}
case 178:{f.Locals[6]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[4]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[6]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",187);}
case 187:{return rt.Call(f,"forge/card/CardDb","collectorNumberBase","(Ljava/lang/String;)I","invokestatic",190);}
case 190:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",193);}
case 193:{f.Locals[4]=f.Pop();f.Pc=195;continue;}
case 195:{f.Pc=158;continue;}
case 198:{f.Push(f.Locals[4]);f.Pc=200;continue;}
case 200:{f.Locals[5]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[3]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[5]);f.Pc=205;continue;}
case 205:{return rt.DynamicCall(f,"forge/card/CardDb:226:205:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",210);}
case 210:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",215);}
case 215:{f.StackOp("pop");f.Pc=216;continue;}
case 216:{f.Push(f.Locals[3]);f.Pc=217;continue;}
case 217:{return rt.DynamicCall(f,"forge/card/CardDb:226:217:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",222);}
case 222:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",225);}
case 225:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",230);}
case 230:{f.Push(f.Locals[3]);f.Pc=231;continue;}
case 231:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M227(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{f.Push(JValue.I(2147483647));f.Pc=7;continue;}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",15);}
case 15:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?41:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(9));f.Pc=21;continue;}
case 21:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?41:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",29);}
case 29:{return rt.Call(f,"java/lang/Character","isDigit","(C)Z","invokestatic",32);}
case 32:{f.Pc=f.Pop().Int==0?41:35;continue;}
case 35:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=38;continue;}
case 38:{f.Pc=10;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Int!=0?51:45;continue;}
case 45:{f.Push(JValue.I(2147483647));f.Pc=48;continue;}
case 48:{f.Pc=60;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",57);}
case 57:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",60);}
case 60:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M228(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference==null?27:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/card/CardEdition","isTraditionalFrame","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?29:27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",36);}
case 36:{return rt.Call(f,"forge/card/CardType","isBasicLand","()Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?44:42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/card/CardDb","getTraditionalFramePrints","(Lforge/item/PaperCard;)Ljava/util/List;","invokevirtual",49);}
case 49:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",54);}
case 54:{f.Locals[3]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",61);}
case 61:{f.Pc=f.Pop().Int==0?95:64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{f.Locals[4]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",80);}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",84);}
case 84:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int==0?92:90;continue;}
case 90:{f.Push(JValue.I(1));f.Pc=91;continue;}
case 91:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 92:{f.Pc=55;continue;}
case 95:{f.Push(JValue.I(0));f.Pc=96;continue;}
case 96:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M229(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",6);}
case 6:{return rt.DynamicCall(f,"forge/card/CardDb:229:6:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",11);}
case 11:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.DynamicCall(f,"forge/card/CardDb:229:17:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb;)Ljava/util/function/Function;",22);}
case 22:{return rt.Call(f,"java/util/Comparator","comparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokestatic",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.DynamicCall(f,"forge/card/CardDb:229:26:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb;)Ljava/util/function/Function;",31);}
case 31:{return rt.Call(f,"java/util/Comparator","thenComparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokeinterface",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.DynamicCall(f,"forge/card/CardDb:229:37:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb;)Ljava/util/function/Function;",42);}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","defaultCardArtPreference","Lforge/card/CardDb$CardArtPreference;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Comparator","thenComparing","(Ljava/util/function/Function;Ljava/util/Comparator;)Ljava/util/Comparator;","invokeinterface",51);}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.DynamicCall(f,"forge/card/CardDb:229:52:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb;)Ljava/util/function/Function;",57);}
case 57:{return rt.Call(f,"java/util/Comparator","thenComparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokeinterface",62);}
case 62:{return rt.DynamicCall(f,"forge/card/CardDb:229:62:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",67);}
case 67:{return rt.Call(f,"java/util/Comparator","thenComparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokeinterface",72);}
case 72:{return rt.Call(f,"java/util/stream/Stream","min","(Ljava/util/Comparator;)Ljava/util/Optional;","invokeinterface",77);}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.DynamicCall(f,"forge/card/CardDb:229:78:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Collection;)Ljava/util/function/Supplier;",83);}
case 83:{return rt.Call(f,"java/util/Optional","orElseGet","(Ljava/util/function/Supplier;)Ljava/lang/Object;","invokevirtual",86);}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M230(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","defaultCardArtPreference","Lforge/card/CardDb$CardArtPreference;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?17:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","defaultCardArtPreference","Lforge/card/CardDb$CardArtPreference;"));f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","blackBorderOnly","Z"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int!=0?19:17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Reference==null?49:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/CardEdition","getBorderColor","()Lforge/card/CardEdition$BorderColor;","invokevirtual",39);}
case 39:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"));f.Pc=42;continue;}
case 42:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?49:45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{f.Pc=50;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M231(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","preferredLanguageAvailability","Ljava/util/function/BiPredicate;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference!=null?27:25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","preferredLanguageAvailability","Ljava/util/function/BiPredicate;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/card/CardEdition","getScryfallCode","()Ljava/lang/String;","invokevirtual",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",39);}
case 39:{return rt.Call(f,"java/util/function/BiPredicate","test","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",44);}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M232(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;","invokestatic",6);}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[4]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",14);}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Reference==null?52:21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/card/CardDb","artPrefs","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb","artPrefs","Ljava/util/Map;"));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",32);}
case 32:{f.StackOp("pop");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByRules","Ljava/util/Map;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[5]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",42);}
case 42:{f.Push(f.Locals[5]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M233(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardDb","artPrefs","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb","artPrefs","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Reference==null?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M234(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","defaultCardArtPreference","Lforge/card/CardDb$CardArtPreference;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M235(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardDb","setCardArtPreference","(ZZZ)V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M236(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","of","(ZZZ)Lforge/card/CardDb$CardArtPreference;","invokestatic",6);}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","defaultCardArtPreference","Lforge/card/CardDb$CardArtPreference;"));f.Pc=14;continue;}
case 14:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","defaultCardArtPreference","Lforge/card/CardDb$CardArtPreference;",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Int==0?46:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","initialized","Z"));f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Int==0?46:42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/CardDb","reIndex","()V","invokevirtual",46);}
case 46:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M237(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb","preferredLanguageAvailability","Ljava/util/function/BiPredicate;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","initialized","Z"));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int==0?16:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardDb","reIndex","()V","invokevirtual",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M238(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardDb","getLoadedRules","(Ljava/lang/String;Z)Lforge/card/CardRules;","invokevirtual",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?27:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardDb","lazyLoad","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?27:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/CardDb","getLoadedRules","(Ljava/lang/String;Z)Lforge/card/CardRules;","invokevirtual",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M239(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb","getNormalizedName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByPrimaryName","Ljava/util/Map;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference!=null?28:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Int!=0?30:28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","rulesByAltName","Ljava/util/Map;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M240(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference==null?21:8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/StaticData","lazyLoadCard","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M241(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardDb","getRules","(Ljava/lang/String;Z)Lforge/card/CardRules;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?16:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/CardRules","getUnsupportedCardNamed","(Ljava/lang/String;)Lforge/card/CardRules;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M242(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("latest")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("original")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?38:26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("earliest")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?38:36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("core")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",45);}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("black")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",56);}
case 56:{return rt.Call(f,"forge/card/CardDb","setCardArtPreference","(ZZZ)V","invokevirtual",59);}
case 59:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M243(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardDb","tryGetCard","(Lforge/card/CardDb$CardRequest;)Lforge/item/PaperCard;","invokevirtual",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M244(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardDb","tryGetCard","(Lforge/card/CardDb$CardRequest;)Lforge/item/PaperCard;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M245(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;","invokestatic",6);}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",13);}
case 13:{f.Locals[5]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/card/CardDb","tryGetCard","(Lforge/card/CardDb$CardRequest;)Lforge/item/PaperCard;","invokevirtual",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M246(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",6);}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",13);}
case 13:{f.Locals[5]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/card/CardDb","tryGetCard","(Lforge/card/CardDb$CardRequest;)Lforge/item/PaperCard;","invokevirtual",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M247(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[4]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;)Ljava/lang/String;","invokestatic",8);}
case 8:{f.Locals[5]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[5]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",15);}
case 15:{f.Locals[6]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[6]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardDb","tryGetCard","(Lforge/card/CardDb$CardRequest;)Lforge/item/PaperCard;","invokevirtual",23);}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M248(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[4]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;","invokestatic",8);}
case 8:{f.Locals[5]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[5]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",15);}
case 15:{f.Locals[6]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[6]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardDb","tryGetCard","(Lforge/card/CardDb$CardRequest;)Lforge/item/PaperCard;","invokevirtual",23);}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M249(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","edition","Ljava/lang/String;"));f.Pc=10;continue;}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference==null?88:15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int!=0?88:22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",33);}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","artIndex","I"));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","collectorNumber","Ljava/lang/String;"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","isFoil","Z"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/card/CardDb","getCardFromSet","(Ljava/lang/String;Lforge/card/CardEdition;ILjava/lang/String;Z)Lforge/item/PaperCard;","invokevirtual",55);}
case 55:{f.Locals[4]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{f.Pc=f.Pop().Reference==null?80:62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","flags","Ljava/util/Map;"));f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Reference==null?80:69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","flags","Ljava/util/Map;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/item/PaperCard","copyWithFlags","(Ljava/util/Map;)Lforge/item/PaperCard;","invokevirtual",78);}
case 78:{f.Locals[4]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{f.Pc=f.Pop().Reference==null?88:85;continue;}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{return JStep.Return(f.Pop());}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",96);}
case 96:{f.Locals[3]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",103);}
case 103:{f.Pc=f.Pop().Int==0?108:106;continue;}
case 106:{f.Push(JValue.R(null));f.Pc=107;continue;}
case 107:{return JStep.Return(f.Pop());}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","isFoil","Z"));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",119);}
case 119:{f.Locals[4]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[4]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","defaultCardArtPreference","Lforge/card/CardDb$CardArtPreference;"));f.Pc=128;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","artIndex","I"));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/card/CardDb","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;I)Lforge/item/PaperCard;","invokevirtual",135);}
case 135:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M250(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?8:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference!=null?10:8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",14);}
case 14:{f.Locals[6]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[6]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=21;continue;}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[5]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int!=0?35:27;continue;}
case 27:{f.Push(f.Locals[6]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","isFoil","Z"));f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Int==0?39:35;continue;}
case 35:{f.Push(JValue.I(1));f.Pc=36;continue;}
case 36:{f.Pc=40;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{f.Locals[5]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",46);}
case 46:{f.Locals[7]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/card/CardEdition","getCode2","()Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Locals[8]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[7]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[8]);f.Pc=58;continue;}
case 58:{return rt.DynamicCall(f,"forge/card/CardDb:250:58:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;Ljava/lang/String;)Ljava/util/function/Predicate;",63);}
case 63:{f.Locals[9]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Int<=0?84:69;continue;}
case 69:{f.Push(f.Locals[9]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{return rt.DynamicCall(f,"forge/card/CardDb:250:72:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",77);}
case 77:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",82);}
case 82:{f.Locals[9]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{f.Pc=f.Pop().Reference==null?124:89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int!=0?124:97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int!=0?124:108;continue;}
case 108:{f.Push(f.Locals[9]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[4]);f.Pc=112;continue;}
case 112:{return rt.DynamicCall(f,"forge/card/CardDb:250:112:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",117);}
case 117:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",122);}
case 122:{f.Locals[9]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[9]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;Ljava/util/function/Predicate;)Ljava/util/List;","invokevirtual",131);}
case 131:{f.Locals[10]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[10]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",140);}
case 140:{f.Pc=f.Pop().Int==0?145:143;continue;}
case 143:{f.Push(JValue.R(null));f.Pc=144;continue;}
case 144:{return JStep.Return(f.Pop());}
case 145:{f.Push(f.Locals[10]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",152);}
case 152:{return rt.DynamicCall(f,"forge/card/CardDb:250:152:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",157);}
case 157:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",162);}
case 162:{return rt.Call(f,"java/util/stream/Stream","distinct","()Ljava/util/stream/Stream;","invokeinterface",167);}
case 167:{return rt.Call(f,"java/util/stream/Stream","count","()J","invokeinterface",172);}
case 172:{f.Push(JValue.L(1));f.Pc=173;continue;}
case 173:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=174;continue;}
case 174:{f.Pc=f.Pop().Int<=0?227:177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Locals[11]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[10]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",187);}
case 187:{return rt.DynamicCall(f,"forge/card/CardDb:250:187:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",192);}
case 192:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",197);}
case 197:{f.Push(f.Locals[11]);f.Pc=199;continue;}
case 199:{return rt.DynamicCall(f,"forge/card/CardDb:250:199:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",204);}
case 204:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",209);}
case 209:{f.Pc=f.Pop().Int==0?227:212;continue;}
case 212:{f.Push(f.Locals[10]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[11]);f.Pc=216;continue;}
case 216:{return rt.DynamicCall(f,"forge/card/CardDb:250:216:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",221);}
case 221:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",226);}
case 226:{f.StackOp("pop");f.Pc=227;continue;}
case 227:{f.Push(f.Locals[10]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",234);}
case 234:{f.Locals[11]=f.Pop();f.Pc=236;continue;}
case 236:{f.Push(f.Locals[11]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",243);}
case 243:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=246;continue;}
case 246:{f.Locals[12]=f.Pop();f.Pc=248;continue;}
case 248:{f.Push(f.Locals[12]);f.Pc=250;continue;}
case 250:{f.Locals[13]=f.Pop();f.Pc=252;continue;}
case 252:{f.Push(f.Locals[12]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/item/PaperCard","hasImage","()Z","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Int!=0?285:260;continue;}
case 260:{f.Push(f.Locals[11]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",267);}
case 267:{f.Pc=f.Pop().Int==0?285:270;continue;}
case 270:{f.Push(f.Locals[11]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",277);}
case 277:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=280;continue;}
case 280:{f.Locals[12]=f.Pop();f.Pc=282;continue;}
case 282:{f.Pc=252;continue;}
case 285:{f.Push(f.Locals[12]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/item/PaperCard","hasImage","()Z","invokevirtual",290);}
case 290:{f.Pc=f.Pop().Int==0?298:293;continue;}
case 293:{f.Push(f.Locals[12]);f.Pc=295;continue;}
case 295:{f.Pc=300;continue;}
case 298:{f.Push(f.Locals[13]);f.Pc=300;continue;}
case 300:{f.Locals[12]=f.Pop();f.Pc=302;continue;}
case 302:{f.Push(f.Locals[5]);f.Pc=304;continue;}
case 304:{f.Pc=f.Pop().Int==0?315:307;continue;}
case 307:{f.Push(f.Locals[12]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",312);}
case 312:{f.Pc=317;continue;}
case 315:{f.Push(f.Locals[12]);f.Pc=317;continue;}
case 317:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M251(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardDb","tryToGetCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M252(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[5]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardDb","tryToGetCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;ZLjava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M253(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[5]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardDb","tryToGetCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;ZLjava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M254(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardDb","tryToGetCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;ILjava/util/Date;ZLjava/util/function/Predicate;)Lforge/item/PaperCard;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M255(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",10);}
case 10:{f.Locals[7]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference==null?20:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Pc=24;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","defaultCardArtPreference","Lforge/card/CardDb$CardArtPreference;"));f.Pc=24;continue;}
case 24:{f.Locals[8]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[7]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[7]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","artIndex","I"));f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$CardRequest","artIndex","I",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[7]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","artIndex","I"));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?60:49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?60:54;continue;}
case 54:{f.Push(f.Locals[7]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$CardRequest","artIndex","I",value);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{f.Pc=f.Pop().Reference==null?70:65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{f.Pc=75;continue;}
case 70:{return rt.DynamicCall(f,"forge/card/CardDb:255:70:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",75);}
case 75:{f.Locals[6]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{f.Pc=f.Pop().Reference==null?99:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[7]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[5]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.DynamicCall(f,"forge/card/CardDb:255:89:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb;Lforge/card/CardDb$CardRequest;ZLjava/util/Date;)Ljava/util/function/Predicate;",94);}
case 94:{f.Locals[10]=f.Pop();f.Pc=96;continue;}
case 96:{f.Pc=108;continue;}
case 99:{f.Push(f.Locals[7]);f.Pc=101;continue;}
case 101:{return rt.DynamicCall(f,"forge/card/CardDb:255:101:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb$CardRequest;)Ljava/util/function/Predicate;",106);}
case 106:{f.Locals[10]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[10]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[6]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",117);}
case 117:{f.Locals[10]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[7]);f.Pc=122;continue;}
case 122:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=125;continue;}
case 125:{f.Push(f.Locals[10]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/card/CardDb","getAllCardsNoAlt","(Ljava/lang/String;Ljava/util/function/Predicate;)Ljava/util/List;","invokevirtual",130);}
case 130:{f.Locals[9]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[9]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",139);}
case 139:{f.Pc=f.Pop().Int==0?155:142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[7]);f.Pc=145;continue;}
case 145:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=148;continue;}
case 148:{f.Push(f.Locals[10]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;Ljava/util/function/Predicate;)Ljava/util/List;","invokevirtual",153);}
case 153:{f.Locals[9]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[9]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",162);}
case 162:{f.Pc=f.Pop().Int==0?167:165;continue;}
case 165:{f.Push(JValue.R(null));f.Pc=166;continue;}
case 166:{return JStep.Return(f.Pop());}
case 167:{f.Push(f.Locals[9]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",174);}
case 174:{f.Push(JValue.I(1));f.Pc=175;continue;}
case 175:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?196:178;continue;}
case 178:{f.Push(f.Locals[0]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[9]);f.Pc=181;continue;}
case 181:{f.Push(JValue.I(0));f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",187);}
case 187:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[7]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/card/CardDb","preferTraditionalFrame","(Lforge/item/PaperCard;Lforge/card/CardDb$CardRequest;)Lforge/item/PaperCard;","invokevirtual",195);}
case 195:{return JStep.Return(f.Pop());}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","flavorNameMappings","Ljava/util/Map;"));f.Pc=200;continue;}
case 200:{f.Push(f.Locals[7]);f.Pc=202;continue;}
case 202:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",210);}
case 210:{f.Pc=f.Pop().Int==0?265:213;continue;}
case 213:{f.Push(f.Locals[9]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",220);}
case 220:{f.Push(f.Locals[7]);f.Pc=222;continue;}
case 222:{return rt.DynamicCall(f,"forge/card/CardDb:255:222:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb$CardRequest;)Ljava/util/function/Predicate;",227);}
case 227:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",232);}
case 232:{return rt.Call(f,"java/util/stream/Collectors","toSet","()Ljava/util/stream/Collector;","invokestatic",235);}
case 235:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",240);}
case 240:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=243;continue;}
case 243:{f.Locals[11]=f.Pop();f.Pc=245;continue;}
case 245:{f.Push(f.Locals[11]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",252);}
case 252:{f.Pc=f.Pop().Int!=0?265:255;continue;}
case 255:{f.Push(f.Locals[9]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[11]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/util/List","retainAll","(Ljava/util/Collection;)Z","invokeinterface",264);}
case 264:{f.StackOp("pop");f.Pc=265;continue;}
case 265:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=268;continue;}
case 268:{f.StackOp("dup");f.Pc=269;continue;}
case 269:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",272);}
case 272:{f.Locals[11]=f.Pop();f.Pc=274;continue;}
case 274:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=277;continue;}
case 277:{f.StackOp("dup");f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",281);}
case 281:{f.Locals[12]=f.Pop();f.Pc=283;continue;}
case 283:{f.Push(f.Locals[9]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",290);}
case 290:{f.Locals[13]=f.Pop();f.Pc=292;continue;}
case 292:{f.Push(f.Locals[13]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",299);}
case 299:{f.Pc=f.Pop().Int==0?384:302;continue;}
case 302:{f.Push(f.Locals[13]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",309);}
case 309:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=312;continue;}
case 312:{f.Locals[14]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[14]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",319);}
case 319:{f.Locals[15]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[15]);f.Pc=323;continue;}
case 323:{f.Push(JValue.R(rt.String("???")));f.Pc=326;continue;}
case 326:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",329);}
case 329:{f.Pc=f.Pop().Int==0?340:332;continue;}
case 332:{if(!rt.StaticReady(f,"forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"));f.Pc=335;continue;}
case 335:{f.Locals[16]=f.Pop();f.Pc=337;continue;}
case 337:{f.Pc=354;continue;}
case 340:{f.Push(f.Locals[0]);f.Pc=341;continue;}
case 341:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=344;continue;}
case 344:{f.Push(f.Locals[14]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",349);}
case 349:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",352);}
case 352:{f.Locals[16]=f.Pop();f.Pc=354;continue;}
case 354:{f.Push(f.Locals[16]);f.Pc=356;continue;}
case 356:{f.Pc=f.Pop().Reference==null?381:359;continue;}
case 359:{f.Push(f.Locals[11]);f.Pc=361;continue;}
case 361:{f.Push(f.Locals[16]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",368);}
case 368:{f.StackOp("pop");f.Pc=369;continue;}
case 369:{f.Push(f.Locals[12]);f.Pc=371;continue;}
case 371:{f.Push(f.Locals[15]);f.Pc=373;continue;}
case 373:{f.Push(f.Locals[14]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",380);}
case 380:{f.StackOp("pop");f.Pc=381;continue;}
case 381:{f.Pc=292;continue;}
case 384:{f.Push(f.Locals[11]);f.Pc=386;continue;}
case 386:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",391);}
case 391:{f.Pc=f.Pop().Int==0?396:394;continue;}
case 394:{f.Push(JValue.R(null));f.Pc=395;continue;}
case 395:{return JStep.Return(f.Pop());}
case 396:{f.Push(f.Locals[11]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",403);}
case 403:{f.Push(f.Locals[8]);f.Pc=405;continue;}
case 405:{f.StackOp("dup");f.Pc=406;continue;}
case 406:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",409);}
case 409:{f.StackOp("pop");f.Pc=410;continue;}
case 410:{return rt.DynamicCall(f,"forge/card/CardDb:255:410:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb$CardArtPreference;)Ljava/util/function/Predicate;",415);}
case 415:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",420);}
case 420:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",423);}
case 423:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",428);}
case 428:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=431;continue;}
case 431:{f.Locals[13]=f.Pop();f.Pc=433;continue;}
case 433:{f.Push(f.Locals[13]);f.Pc=435;continue;}
case 435:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",440);}
case 440:{f.Pc=f.Pop().Int==0?453:443;continue;}
case 443:{f.Push(f.Locals[13]);f.Pc=445;continue;}
case 445:{f.Push(f.Locals[11]);f.Pc=447;continue;}
case 447:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",452);}
case 452:{f.StackOp("pop");f.Pc=453;continue;}
case 453:{f.Push(f.Locals[13]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",460);}
case 460:{f.Push(JValue.I(1));f.Pc=461;continue;}
case 461:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?512:464;continue;}
case 464:{f.Push(f.Locals[13]);f.Pc=466;continue;}
case 466:{return rt.Call(f,"java/util/Collections","sort","(Ljava/util/List;)V","invokestatic",469);}
case 469:{f.Push(f.Locals[8]);f.Pc=471;continue;}
case 471:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","latestFirst","Z"));f.Pc=474;continue;}
case 474:{f.Pc=f.Pop().Int==0?482:477;continue;}
case 477:{f.Push(f.Locals[13]);f.Pc=479;continue;}
case 479:{return rt.Call(f,"java/util/Collections","reverse","(Ljava/util/List;)V","invokestatic",482);}
case 482:{f.Push(f.Locals[8]);f.Pc=484;continue;}
case 484:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","blackBorderOnly","Z"));f.Pc=487;continue;}
case 487:{f.Pc=f.Pop().Int==0?512:490;continue;}
case 490:{f.Push(f.Locals[13]);f.Pc=492;continue;}
case 492:{f.Push(f.Locals[8]);f.Pc=494;continue;}
case 494:{f.StackOp("dup");f.Pc=495;continue;}
case 495:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",498);}
case 498:{f.StackOp("pop");f.Pc=499;continue;}
case 499:{return rt.DynamicCall(f,"forge/card/CardDb:255:499:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb$CardArtPreference;)Ljava/util/function/ToIntFunction;",504);}
case 504:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",507);}
case 507:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",512);}
case 512:{f.Push(f.Locals[12]);f.Pc=514;continue;}
case 514:{f.Push(f.Locals[13]);f.Pc=516;continue;}
case 516:{f.Push(JValue.I(0));f.Pc=517;continue;}
case 517:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",522);}
case 522:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=525;continue;}
case 525:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",528);}
case 528:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",533);}
case 533:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=536;continue;}
case 536:{f.Locals[14]=f.Pop();f.Pc=538;continue;}
case 538:{f.Push(f.Locals[0]);f.Pc=539;continue;}
case 539:{f.Push(f.Locals[14]);f.Pc=541;continue;}
case 541:{f.Push(f.Locals[7]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/card/CardDb","preferTraditionalFrame","(Lforge/item/PaperCard;Lforge/card/CardDb$CardRequest;)Lforge/item/PaperCard;","invokevirtual",546);}
case 546:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M256(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","collectorNumber","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?24:7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","collectorNumber","Ljava/lang/String;"));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("N.A.")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Int==0?34:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Pc=39;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/CardDb","getTraditionalFramePrint","(Lforge/item/PaperCard;)Lforge/item/PaperCard;","invokevirtual",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","isFoil","Z"));f.Pc=45;continue;}
case 45:{f.Pc=f.Pop().Int==0?56:48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",53);}
case 53:{f.Pc=58;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M257(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(-1));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(JValue.I(-1));f.Pc=7;continue;}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?57:28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[4]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",45);}
case 45:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?54:48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",53);}
case 53:{f.Locals[2]=f.Pop();f.Pc=54;continue;}
case 54:{f.Pc=19;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M258(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardDb","getArtCount","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M259(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?8:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference!=null?10:8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.DynamicCall(f,"forge/card/CardDb:259:11:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Reference==null?46:22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?46:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.DynamicCall(f,"forge/card/CardDb:259:34:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",39);}
case 39:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",44);}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/card/CardDb","getAllCardsNoAlt","(Ljava/lang/String;Ljava/util/function/Predicate;)Ljava/util/List;","invokevirtual",53);}
case 53:{f.Locals[5]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",62);}
case 62:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M260(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","nonLegendaryCreatureNames","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference==null?23:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",22);}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 23:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",26);}
case 26:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardDb","getFaceByName","(Ljava/lang/String;)Lforge/card/ICardFace;","invokevirtual",33);}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Reference!=null?55:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","nonLegendaryCreatureNames","Ljava/util/Map;"));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",47);}
case 47:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",61);}
case 61:{f.Locals[4]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/card/CardType","isCreature","()Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int==0?83:71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/card/CardType","isLegendary","()Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int!=0?83:79;continue;}
case 79:{f.Push(JValue.I(1));f.Pc=80;continue;}
case 80:{f.Pc=84;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",87);}
case 87:{f.Locals[2]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","nonLegendaryCreatureNames","Ljava/util/Map;"));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",99);}
case 99:{f.StackOp("pop");f.Pc=100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",104);}
case 104:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M261(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByRules","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/ListMultimap","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Collections","unmodifiableCollection","(Ljava/util/Collection;)Ljava/util/Collection;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M262(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByRules","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M263(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","facesByName","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M264(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByRules","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/ListMultimap","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M265(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByRules","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M266(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","facesByName","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M267(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardDb","streamAllCards","()Ljava/util/stream/Stream;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/card/CardDb","EDITION_NON_REPRINT","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb","EDITION_NON_REPRINT","Ljava/util/function/Predicate;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",12);}
case 12:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",15);}
case 15:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",20);}
case 20:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M268(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","normalizedNames","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M269(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByName","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardDb","getNormalizedName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",9);}
case 9:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?48:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(null));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/card/CardDb","lazyLoad","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?48:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByName","Lcom/google/common/collect/ListMultimap;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/card/CardDb","getNormalizedName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",42);}
case 42:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",47);}
case 47:{return JStep.Return(f.Pop());}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M270(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardDb","getRules","(Ljava/lang/String;Z)Lforge/card/CardRules;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?15:11;continue;}
case 11:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByRules","Lcom/google/common/collect/ListMultimap;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",25);}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M271(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByRules","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M272(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Lforge/card/CardRules;)Ljava/util/List;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M273(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardDb","streamAllCards","()Ljava/util/stream/Stream;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",10);}
case 10:{return rt.DynamicCall(f,"forge/card/CardDb:273:10:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",15);}
case 15:{return rt.Call(f,"java/util/stream/Collectors","toCollection","(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;","invokestatic",18);}
case 18:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M274(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",10);}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",16);}
case 16:{return rt.DynamicCall(f,"forge/card/CardDb:274:16:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",21);}
case 21:{return rt.Call(f,"java/util/stream/Collectors","toCollection","(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;","invokestatic",24);}
case 24:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M275(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Lforge/item/PaperCard;)Ljava/util/List;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",10);}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",16);}
case 16:{return rt.DynamicCall(f,"forge/card/CardDb:275:16:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",21);}
case 21:{return rt.Call(f,"java/util/stream/Collectors","toCollection","(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;","invokestatic",24);}
case 24:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M276(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Lforge/card/CardRules;)Ljava/util/List;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",10);}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",16);}
case 16:{return rt.DynamicCall(f,"forge/card/CardDb:276:16:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",21);}
case 21:{return rt.Call(f,"java/util/stream/Collectors","toCollection","(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;","invokestatic",24);}
case 24:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M277(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb","getAllCardsNoAlt","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",10);}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",16);}
case 16:{return rt.DynamicCall(f,"forge/card/CardDb:277:16:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",21);}
case 21:{return rt.Call(f,"java/util/stream/Collectors","toCollection","(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;","invokestatic",24);}
case 24:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M278(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardEdition","getAllCardsInSet","()Ljava/util/List;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?69:23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",40);}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",47);}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Reference!=null?57:54;continue;}
case 54:{f.Pc=14;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Pc=14;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M279(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByFlavorName","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?27:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByFlavorName","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardDb","getRules","(Ljava/lang/String;Z)Lforge/card/CardRules;","invokevirtual",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Reference!=null?40:38;continue;}
case 38:{f.Push(JValue.R(null));f.Pc=39;continue;}
case 39:{return JStep.Return(f.Pop());}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByRules","Ljava/util/Map;"));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M280(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardDb","getRules","(Ljava/lang/String;Z)Lforge/card/CardRules;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?13:11;continue;}
case 11:{f.Push(JValue.R(null));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","uniqueCardsByRules","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M281(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","facesByName","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardDb","getNormalizedName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",9);}
case 9:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",14);}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Reference!=null?49:22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(null));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/card/CardDb","lazyLoad","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?49:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","facesByName","Ljava/util/Map;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/CardDb","getNormalizedName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",45);}
case 45:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=48;continue;}
case 48:{f.Locals[2]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M282(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","allCardsByName","Lcom/google/common/collect/ListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardDb","getNormalizedName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",9);}
case 9:{return rt.Call(f,"com/google/common/collect/ListMultimap","containsKey","(Ljava/lang/Object;)Z","invokeinterface",14);}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M283(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardDb","getAllCards","()Ljava/util/Collection;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M284(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/card/CardDb:284:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb;Ljava/util/Collection;)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M285(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/CardDb:285:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Collection;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M286(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/card/CardDb:286:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb;Lforge/card/CardRarity;)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M287(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardDb$CardRequest","fromString","(Ljava/lang/String;)Lforge/card/CardDb$CardRequest;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"));f.Pc=8;continue;}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"));f.Pc=12;continue;}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","edition","Ljava/lang/String;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",21);}
case 21:{f.Pc=f.Pop().Int==0?136:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/CardEdition$Collection","iterator","()Ljava/util/Iterator;","invokevirtual",31);}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?133:43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[6]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[6]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/card/CardEdition","getAllCardsInSet","()Ljava/util/List;","invokevirtual",60);}
case 60:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",65);}
case 65:{f.Locals[7]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[7]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",74);}
case 74:{f.Pc=f.Pop().Int==0?120:77;continue;}
case 77:{f.Push(f.Locals[7]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",84);}
case 84:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=87;continue;}
case 87:{f.Locals[8]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[8]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",94);}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Int==0?117:104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{f.Locals[3]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[8]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","rarity","()Lforge/card/CardRarity;","invokevirtual",112);}
case 112:{f.Locals[4]=f.Pop();f.Pc=114;continue;}
case 114:{f.Pc=120;continue;}
case 117:{f.Pc=67;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"));f.Pc=124;continue;}
case 124:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?130:127;continue;}
case 127:{f.Pc=133;continue;}
case 130:{f.Pc=33;continue;}
case 133:{f.Pc=220;continue;}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=140;continue;}
case 140:{f.Push(f.Locals[2]);f.Pc=141;continue;}
case 141:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","edition","Ljava/lang/String;"));f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",147);}
case 147:{f.Locals[3]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[3]);f.Pc=149;continue;}
case 149:{f.Pc=f.Pop().Reference==null?216:152;continue;}
case 152:{f.Push(f.Locals[3]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/card/CardEdition","getAllCardsInSet","()Ljava/util/List;","invokevirtual",156);}
case 156:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",161);}
case 161:{f.Locals[5]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[5]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",170);}
case 170:{f.Pc=f.Pop().Int==0?213:173;continue;}
case 173:{f.Push(f.Locals[5]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",180);}
case 180:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=183;continue;}
case 183:{f.Locals[6]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[6]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","name","()Ljava/lang/String;","invokevirtual",190);}
case 190:{f.Push(f.Locals[2]);f.Pc=191;continue;}
case 191:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",197);}
case 197:{f.Pc=f.Pop().Int==0?210:200;continue;}
case 200:{f.Push(f.Locals[6]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","rarity","()Lforge/card/CardRarity;","invokevirtual",205);}
case 205:{f.Locals[4]=f.Pop();f.Pc=207;continue;}
case 207:{f.Pc=213;continue;}
case 210:{f.Pc=163;continue;}
case 213:{f.Pc=220;continue;}
case 216:{if(!rt.StaticReady(f,"forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"));f.Pc=219;continue;}
case 219:{f.Locals[3]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(f.Locals[4]);f.Pc=222;continue;}
case 222:{if(!rt.StaticReady(f,"forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"));f.Pc=225;continue;}
case 225:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?240:228;continue;}
case 228:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String("Forge could not find this card in the Database. Any chance you might have mistyped the card name?")));f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",237);}
case 237:{f.Pc=249;continue;}
case 240:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=243;continue;}
case 243:{f.Push(JValue.R(rt.String("We're sorry, but this card is not supported yet.")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",249);}
case 249:{if(!rt.EnsureInitialized(f,"forge/item/PaperCard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCard")));f.Pc=252;continue;}
case 252:{f.StackOp("dup");f.Pc=253;continue;}
case 253:{f.Push(f.Locals[2]);f.Pc=254;continue;}
case 254:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/card/CardRules","getUnsupportedCardNamed","(Ljava/lang/String;)Lforge/card/CardRules;","invokestatic",260);}
case 260:{f.Push(f.Locals[3]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",264);}
case 264:{f.Push(f.Locals[4]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/item/PaperCard","<init>","(Lforge/card/CardRules;Ljava/lang/String;Lforge/card/CardRarity;)V","invokespecial",269);}
case 269:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M288(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editor","Lforge/card/CardDb$Editor;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M289(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardDb","getAllCardsNoAlt","(Ljava/lang/String;Ljava/util/function/Predicate;)Ljava/util/List;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M290(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;Ljava/util/function/Predicate;)Ljava/util/List;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M291(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/util/function/Predicate;)Ljava/util/List;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M292(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M293(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/util/function/Predicate;)Ljava/util/List;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M294(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardDb","getAllCards","()Ljava/util/Collection;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M295(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Lforge/item/PaperCard;)Ljava/util/List;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",10);}
case 10:{return rt.DynamicCall(f,"forge/card/CardDb:295:10:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",15);}
case 15:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",20);}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",25);}
case 25:{f.StackOp("pop");f.Pc=26;continue;}
case 26:{return rt.DynamicCall(f,"forge/card/CardDb:295:26:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardRarity;)Ljava/util/function/Predicate;",31);}
case 31:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",36);}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M296(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?21:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",9);}
case 9:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M297(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Lforge/item/PaperCard;)Ljava/util/List;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",10);}
case 10:{return rt.DynamicCall(f,"forge/card/CardDb:297:10:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",15);}
case 15:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",20);}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.DynamicCall(f,"forge/card/CardDb:297:22:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Collection;Lforge/item/PaperCard;)Ljava/util/function/Predicate;",27);}
case 27:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",32);}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M298(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",7);}
case 7:{f.Pc=f.Pop().Int==0?31:10;continue;}
case 10:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",13);}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/card/CardEdition","isCardObtainable","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?31:27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{f.Pc=32;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M299(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference!=null?29:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("???")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?29:27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference==null?50:33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","REPRINT_SET_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","REPRINT_SET_TYPES","Ljava/util/EnumSet;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int!=0?50:46;continue;}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{f.Pc=51;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M300(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference!=null?29:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("???")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?29:27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference==null?47:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",37);}
case 37:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","PROMO","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","PROMO","Lforge/card/CardEdition$Type;"));f.Pc=40;continue;}
case 40:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?47:43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{f.Pc=48;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M301(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperCard","getFunctionalVariant","()Ljava/lang/String;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M302(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M303(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getDisplayName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","cardName","Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M304(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","artIndex","I"));f.Pc=8;continue;}
case 8:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?15:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Pc=16;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M305(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardRequest","artIndex","I"));f.Pc=9;continue;}
case 9:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?14:12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",26);}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference!=null?35:33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Pc=f.Pop().Int==0?49:39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",44);}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Date","before","(Ljava/util/Date;)Z","invokevirtual",48);}
case 48:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",54);}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Date","after","(Ljava/util/Date;)Z","invokevirtual",58);}
case 58:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M306(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M307(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?15:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Pc=16;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M308(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M309(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M310(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperCard","getArtIndex","()I","invokevirtual",5);}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M311(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?21:13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M312(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M313(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb","isTraditionalFramePrint","(Lforge/item/PaperCard;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?12:8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M314(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M315(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb","isPreferredLanguagePrint","(Lforge/item/PaperCard;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?12:8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M316(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/CardDb","isBorderMismatch","(Lforge/item/PaperCard;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M317(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getRarity","()Lforge/card/CardRarity;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardRarity","equals","(Ljava/lang/Object;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M318(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardDb","collectorNumberBase","(Ljava/lang/String;)I","invokestatic",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(2147483647));f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?24:15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M319(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","getFunctionalVariantName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",7);}
case 7:{f.Pc=f.Pop().Int!=0?26:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardRules","getSupportedFunctionalVariants","()Ljava/util/Set;","invokevirtual",14);}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","getFunctionalVariantName","()Ljava/lang/String;","invokevirtual",18);}
case 18:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?30:26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{f.Pc=31;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M320(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardDb")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/Class","desiredAssertionStatus","()Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int!=0?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardDb","$assertionsDisabled","Z"))return JStep.Continue;rt.PutStatic("forge/card/CardDb","$assertionsDisabled","Z",f.Pop());f.Pc=16;continue;}
case 16:{return rt.DynamicCall(f,"forge/card/CardDb:320:16:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",21);}
case 21:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Comparator","comparing","(Ljava/util/function/Function;Ljava/util/Comparator;)Ljava/util/Comparator;","invokestatic",27);}
case 27:{if(!rt.StaticReady(f,"forge/card/CardDb","CARD_RULES_NAME_COMPARATOR","Ljava/util/Comparator;"))return JStep.Continue;rt.PutStatic("forge/card/CardDb","CARD_RULES_NAME_COMPARATOR","Ljava/util/Comparator;",f.Pop());f.Pc=30;continue;}
case 30:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",33);}
case 33:{if(!rt.StaticReady(f,"forge/card/CardDb","artPrefs","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/card/CardDb","artPrefs","Ljava/util/Map;",f.Pop());f.Pc=36;continue;}
case 36:{return rt.DynamicCall(f,"forge/card/CardDb:320:36:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",41);}
case 41:{if(!rt.StaticReady(f,"forge/card/CardDb","EDITION_NON_PROMO","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardDb","EDITION_NON_PROMO","Ljava/util/function/Predicate;",f.Pop());f.Pc=44;continue;}
case 44:{return rt.DynamicCall(f,"forge/card/CardDb:320:44:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",49);}
case 49:{if(!rt.StaticReady(f,"forge/card/CardDb","EDITION_NON_REPRINT","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/card/CardDb","EDITION_NON_REPRINT","Ljava/util/function/Predicate;",f.Pop());f.Pc=52;continue;}
case 52:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C465{
internal static JClass Build(){var c=new JClass("forge/game/card/CardPredicates","java/lang/Object",new string[]{},49);Add0(c);Add1(c);Add2(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("TAPPED","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("UNTAPPED","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("CAN_TAP","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("CAN_CREW","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("CREATURES","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("NON_CREATURES","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("ENCHANTMENTS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("FORTIFICATION","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("NON_TOKEN","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("TOKEN","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("BASIC_LANDS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("NONBASIC_LANDS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("ARTIFACTS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("INSTANTS_AND_SORCERIES","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("LANDS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("NON_LANDS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("LANDS_PRODUCING_MANA","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("PERMANENTS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("NONLAND_PERMANENTS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("hasFirstStrike","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("hasSecondStrike","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("PLANESWALKERS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("BATTLES","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JMethod(5136,"forge/game/card/CardPredicates","<init>","()V",1,1,1,new JHandler[]{},M5136));
c.Add(new JMethod(5137,"forge/game/card/CardPredicates","isController","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5137));
c.Add(new JMethod(5138,"forge/game/card/CardPredicates","isControlledByAnyOf","(Lforge/util/collect/FCollectionView;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5138));
c.Add(new JMethod(5139,"forge/game/card/CardPredicates","isOwner","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5139));
c.Add(new JMethod(5140,"forge/game/card/CardPredicates","ownerLives","()Ljava/util/function/Predicate;",9,0,1,new JHandler[]{},M5140));
c.Add(new JMethod(5141,"forge/game/card/CardPredicates","isType","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5141));
c.Add(new JMethod(5142,"forge/game/card/CardPredicates","hasKeyword","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5142));
c.Add(new JMethod(5143,"forge/game/card/CardPredicates","hasKeyword","(Lforge/game/keyword/Keyword;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5143));
c.Add(new JMethod(5144,"forge/game/card/CardPredicates","containsKeyword","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5144));
c.Add(new JMethod(5145,"forge/game/card/CardPredicates","isTargetableBy","(Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;",9,1,2,new JHandler[]{},M5145));
c.Add(new JMethod(5146,"forge/game/card/CardPredicates","nameEquals","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5146));
c.Add(new JMethod(5147,"forge/game/card/CardPredicates","nameNotEquals","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5147));
c.Add(new JMethod(5148,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5148));
c.Add(new JMethod(5149,"forge/game/card/CardPredicates","sharesCMCWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5149));
c.Add(new JMethod(5150,"forge/game/card/CardPredicates","sharesColorWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5150));
c.Add(new JMethod(5151,"forge/game/card/CardPredicates","sharesControllerWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5151));
c.Add(new JMethod(5152,"forge/game/card/CardPredicates","sharesCardTypeWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5152));
c.Add(new JMethod(5153,"forge/game/card/CardPredicates","sharesAllCardTypesWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5153));
c.Add(new JMethod(5154,"forge/game/card/CardPredicates","sharesCreatureTypeWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5154));
c.Add(new JMethod(5155,"forge/game/card/CardPredicates","sharesLandTypeWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5155));
c.Add(new JMethod(5156,"forge/game/card/CardPredicates","possibleBlockers","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5156));
c.Add(new JMethod(5157,"forge/game/card/CardPredicates","possibleBlockerForAtLeastOne","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5157));
c.Add(new JMethod(5158,"forge/game/card/CardPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;",9,4,4,new JHandler[]{},M5158));
c.Add(new JMethod(5159,"forge/game/card/CardPredicates","restriction","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;",9,4,4,new JHandler[]{},M5159));
c.Add(new JMethod(5160,"forge/game/card/CardPredicates","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;",9,2,2,new JHandler[]{},M5160));
c.Add(new JMethod(5161,"forge/game/card/CardPredicates","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;",9,2,2,new JHandler[]{},M5161));
c.Add(new JMethod(5162,"forge/game/card/CardPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;",9,2,2,new JHandler[]{},M5162));
c.Add(new JMethod(5163,"forge/game/card/CardPredicates","isColor","(B)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5163));
c.Add(new JMethod(5164,"forge/game/card/CardPredicates","isExactlyColor","(B)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5164));
c.Add(new JMethod(5165,"forge/game/card/CardPredicates","isColorless","()Ljava/util/function/Predicate;",9,0,1,new JHandler[]{},M5165));
c.Add(new JMethod(5166,"forge/game/card/CardPredicates","isEquippedBy","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5166));
c.Add(new JMethod(5167,"forge/game/card/CardPredicates","isEnchantedBy","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5167));
c.Add(new JMethod(5168,"forge/game/card/CardPredicates","hasCMC","(I)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5168));
c.Add(new JMethod(5169,"forge/game/card/CardPredicates","greaterCMC","(I)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5169));
c.Add(new JMethod(5170,"forge/game/card/CardPredicates","lessCMC","(I)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5170));
c.Add(new JMethod(5171,"forge/game/card/CardPredicates","evenCMC","()Ljava/util/function/Predicate;",9,0,1,new JHandler[]{},M5171));
c.Add(new JMethod(5172,"forge/game/card/CardPredicates","oddCMC","()Ljava/util/function/Predicate;",9,0,1,new JHandler[]{},M5172));
c.Add(new JMethod(5173,"forge/game/card/CardPredicates","hasCounters","()Ljava/util/function/Predicate;",9,0,1,new JHandler[]{},M5173));
c.Add(new JMethod(5174,"forge/game/card/CardPredicates","hasCounter","(Lforge/game/card/CounterType;)Ljava/util/function/Predicate;",9,1,2,new JHandler[]{},M5174));
c.Add(new JMethod(5175,"forge/game/card/CardPredicates","hasCounter","(Lforge/game/card/CounterType;I)Ljava/util/function/Predicate;",9,2,2,new JHandler[]{},M5175));
c.Add(new JMethod(5176,"forge/game/card/CardPredicates","hasLessCounter","(Lforge/game/card/CounterType;I)Ljava/util/function/Predicate;",9,2,2,new JHandler[]{},M5176));
}

private static void Add1(JClass c){
c.Add(new JMethod(5177,"forge/game/card/CardPredicates","canReceiveCounters","(Lforge/game/card/CounterType;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5177));
c.Add(new JMethod(5178,"forge/game/card/CardPredicates","hasGreaterPowerThan","(I)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5178));
c.Add(new JMethod(5179,"forge/game/card/CardPredicates","compareByCounterType","(Lforge/game/card/CounterType;)Ljava/util/Comparator;",9,1,1,new JHandler[]{},M5179));
c.Add(new JMethod(5180,"forge/game/card/CardPredicates","hasSVar","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5180));
c.Add(new JMethod(5181,"forge/game/card/CardPredicates","isExiledWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5181));
c.Add(new JMethod(5182,"forge/game/card/CardPredicates","compareByGameTimestamp","()Ljava/util/Comparator;",9,0,1,new JHandler[]{},M5182));
c.Add(new JMethod(5183,"forge/game/card/CardPredicates","inZone","(Lforge/game/zone/ZoneType;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5183));
c.Add(new JMethod(5184,"forge/game/card/CardPredicates","inZone","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5184));
c.Add(new JMethod(5185,"forge/game/card/CardPredicates","isRemAIDeck","()Ljava/util/function/Predicate;",9,0,1,new JHandler[]{},M5185));
c.Add(new JMethod(5186,"forge/game/card/CardPredicates","castSA","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5186));
c.Add(new JMethod(5187,"forge/game/card/CardPredicates","phasedIn","()Ljava/util/function/Predicate;",9,0,1,new JHandler[]{},M5187));
c.Add(new JMethod(5188,"forge/game/card/CardPredicates","isAttractionWithLight","(I)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5188));
c.Add(new JMethod(5189,"forge/game/card/CardPredicates","isContraptionOnSprocket","(I)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M5189));
c.Add(new JMethod(5190,"forge/game/card/CardPredicates","lambda$static$58","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5190));
c.Add(new JMethod(5191,"forge/game/card/CardPredicates","lambda$static$57","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5191));
c.Add(new JMethod(5192,"forge/game/card/CardPredicates","lambda$static$56","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5192));
c.Add(new JMethod(5193,"forge/game/card/CardPredicates","lambda$static$55","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5193));
c.Add(new JMethod(5194,"forge/game/card/CardPredicates","lambda$static$54","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5194));
c.Add(new JMethod(5195,"forge/game/card/CardPredicates","lambda$static$53","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5195));
c.Add(new JMethod(5196,"forge/game/card/CardPredicates","lambda$static$52","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5196));
c.Add(new JMethod(5197,"forge/game/card/CardPredicates","lambda$static$51","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5197));
c.Add(new JMethod(5198,"forge/game/card/CardPredicates","lambda$static$50","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5198));
c.Add(new JMethod(5199,"forge/game/card/CardPredicates","lambda$static$49","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5199));
c.Add(new JMethod(5200,"forge/game/card/CardPredicates","lambda$isContraptionOnSprocket$48","(ILforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5200));
c.Add(new JMethod(5201,"forge/game/card/CardPredicates","lambda$isAttractionWithLight$47","(ILforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5201));
c.Add(new JMethod(5202,"forge/game/card/CardPredicates","lambda$phasedIn$46","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5202));
c.Add(new JMethod(5203,"forge/game/card/CardPredicates","lambda$castSA$45","(Ljava/util/function/Predicate;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5203));
c.Add(new JMethod(5204,"forge/game/card/CardPredicates","lambda$isRemAIDeck$44","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5204));
c.Add(new JMethod(5205,"forge/game/card/CardPredicates","lambda$inZone$43","(Ljava/lang/Iterable;Lforge/game/card/Card;)Z",4106,5,2,new JHandler[]{},M5205));
c.Add(new JMethod(5206,"forge/game/card/CardPredicates","lambda$inZone$42","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Z",4106,3,2,new JHandler[]{},M5206));
c.Add(new JMethod(5207,"forge/game/card/CardPredicates","lambda$isExiledWith$41","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5207));
c.Add(new JMethod(5208,"forge/game/card/CardPredicates","lambda$hasSVar$40","(Ljava/lang/String;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5208));
c.Add(new JMethod(5209,"forge/game/card/CardPredicates","lambda$compareByCounterType$39","(Lforge/game/card/CounterType;Lforge/game/card/Card;)I",4106,2,2,new JHandler[]{},M5209));
c.Add(new JMethod(5210,"forge/game/card/CardPredicates","lambda$hasGreaterPowerThan$38","(ILforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5210));
c.Add(new JMethod(5211,"forge/game/card/CardPredicates","lambda$canReceiveCounters$37","(Lforge/game/card/CounterType;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5211));
c.Add(new JMethod(5212,"forge/game/card/CardPredicates","lambda$hasLessCounter$36","(Lforge/game/card/CounterType;ILforge/game/card/Card;)Z",4106,4,2,new JHandler[]{},M5212));
c.Add(new JMethod(5213,"forge/game/card/CardPredicates","lambda$hasCounter$35","(Lforge/game/card/CounterType;ILforge/game/card/Card;)Z",4106,3,2,new JHandler[]{},M5213));
c.Add(new JMethod(5214,"forge/game/card/CardPredicates","lambda$oddCMC$34","(Lforge/game/card/Card;)Z",4106,1,2,new JHandler[]{},M5214));
c.Add(new JMethod(5215,"forge/game/card/CardPredicates","lambda$evenCMC$33","(Lforge/game/card/Card;)Z",4106,1,2,new JHandler[]{},M5215));
c.Add(new JMethod(5216,"forge/game/card/CardPredicates","lambda$lessCMC$32","(ILforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5216));
c.Add(new JMethod(5217,"forge/game/card/CardPredicates","lambda$greaterCMC$31","(ILforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5217));
c.Add(new JMethod(5218,"forge/game/card/CardPredicates","lambda$hasCMC$30","(ILforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5218));
c.Add(new JMethod(5219,"forge/game/card/CardPredicates","lambda$isEnchantedBy$29","(Ljava/lang/String;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5219));
c.Add(new JMethod(5220,"forge/game/card/CardPredicates","lambda$isEquippedBy$28","(Ljava/lang/String;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5220));
c.Add(new JMethod(5221,"forge/game/card/CardPredicates","lambda$isColorless$27","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5221));
c.Add(new JMethod(5222,"forge/game/card/CardPredicates","lambda$isExactlyColor$26","(BLforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5222));
c.Add(new JMethod(5223,"forge/game/card/CardPredicates","lambda$isColor$25","(BLforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5223));
c.Add(new JMethod(5224,"forge/game/card/CardPredicates","lambda$canBeAttached$24","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)Z",4106,3,3,new JHandler[]{},M5224));
c.Add(new JMethod(5225,"forge/game/card/CardPredicates","lambda$canExiledBy$23","(Lforge/game/spellability/SpellAbility;ZLforge/game/card/Card;)Z",4106,3,3,new JHandler[]{},M5225));
c.Add(new JMethod(5226,"forge/game/card/CardPredicates","lambda$canBeSacrificedBy$22","(Lforge/game/spellability/SpellAbility;ZLforge/game/card/Card;)Z",4106,3,3,new JHandler[]{},M5226));
c.Add(new JMethod(5227,"forge/game/card/CardPredicates","lambda$restriction$21","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/card/Card;)Z",4106,5,5,new JHandler[]{},M5227));
c.Add(new JMethod(5228,"forge/game/card/CardPredicates","lambda$restriction$20","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/card/Card;)Z",4106,5,5,new JHandler[]{},M5228));
c.Add(new JMethod(5229,"forge/game/card/CardPredicates","lambda$possibleBlockerForAtLeastOne$19","(Ljava/lang/Iterable;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5229));
c.Add(new JMethod(5230,"forge/game/card/CardPredicates","lambda$possibleBlockers$18","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5230));
c.Add(new JMethod(5231,"forge/game/card/CardPredicates","lambda$sharesLandTypeWith$17","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5231));
c.Add(new JMethod(5232,"forge/game/card/CardPredicates","lambda$sharesCreatureTypeWith$16","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5232));
c.Add(new JMethod(5233,"forge/game/card/CardPredicates","lambda$sharesAllCardTypesWith$15","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5233));
c.Add(new JMethod(5234,"forge/game/card/CardPredicates","lambda$sharesCardTypeWith$14","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5234));
c.Add(new JMethod(5235,"forge/game/card/CardPredicates","lambda$sharesControllerWith$13","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5235));
c.Add(new JMethod(5236,"forge/game/card/CardPredicates","lambda$sharesColorWith$12","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5236));
c.Add(new JMethod(5237,"forge/game/card/CardPredicates","lambda$sharesCMCWith$11","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5237));
c.Add(new JMethod(5238,"forge/game/card/CardPredicates","lambda$sharesNameWith$10","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5238));
c.Add(new JMethod(5239,"forge/game/card/CardPredicates","lambda$nameNotEquals$9","(Ljava/lang/String;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5239));
c.Add(new JMethod(5240,"forge/game/card/CardPredicates","lambda$nameEquals$8","(Ljava/lang/String;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5240));
}

private static void Add2(JClass c){
c.Add(new JMethod(5241,"forge/game/card/CardPredicates","lambda$containsKeyword$7","(Ljava/lang/String;Lforge/game/card/Card;)Z",4106,4,2,new JHandler[]{},M5241));
c.Add(new JMethod(5242,"forge/game/card/CardPredicates","lambda$hasKeyword$6","(Lforge/game/keyword/Keyword;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5242));
c.Add(new JMethod(5243,"forge/game/card/CardPredicates","lambda$hasKeyword$5","(Ljava/lang/String;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5243));
c.Add(new JMethod(5244,"forge/game/card/CardPredicates","lambda$isType$4","(Ljava/lang/String;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5244));
c.Add(new JMethod(5245,"forge/game/card/CardPredicates","lambda$ownerLives$3","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5245));
c.Add(new JMethod(5246,"forge/game/card/CardPredicates","lambda$isOwner$2","(Lforge/game/player/Player;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5246));
c.Add(new JMethod(5247,"forge/game/card/CardPredicates","lambda$isControlledByAnyOf$1","(Lforge/util/collect/FCollectionView;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5247));
c.Add(new JMethod(5248,"forge/game/card/CardPredicates","lambda$isController$0","(Lforge/game/player/Player;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5248));
c.Add(new JMethod(5249,"forge/game/card/CardPredicates","<clinit>","()V",8,0,1,new JHandler[]{},M5249));
}

internal static JStep M5136(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5137(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5137:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5138(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5138:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/util/collect/FCollectionView;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5139(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5139:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5140(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5140:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5141(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5141:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5142(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5142:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5143(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5143:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/keyword/Keyword;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5144(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5144:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5145(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",5);}
case 5:{f.StackOp("pop");f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5145:6:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5146(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5146:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5147(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5147:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5148(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5148:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5149(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5149:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5150(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5150:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5151(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5151:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5152(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5152:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5153(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5153:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5154(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5154:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5155(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5155:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5156(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5156:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5157(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5157:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5158(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5158:4:java/lang/invoke/LambdaMetafactory.metafactory","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5159(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5159:4:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5160(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5160:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5161(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5161:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5162(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5162:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5163(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5163:1:java/lang/invoke/LambdaMetafactory.metafactory","(B)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5164(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5164:1:java/lang/invoke/LambdaMetafactory.metafactory","(B)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5165(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5165:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5166(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5166:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5167(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5167:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5168(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5168:1:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5169(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5169:1:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5170(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5170:1:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5171(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5171:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5172(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5172:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5173(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5173:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5174(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","hasCounter","(Lforge/game/card/CounterType;I)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5175(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5175:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CounterType;I)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5176(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5176:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CounterType;I)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5177(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5177:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CounterType;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5178(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5178:1:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5179(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5179:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CounterType;)Ljava/util/function/ToIntFunction;",6);}
case 6:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5180(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5180:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5181(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5181:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5182(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5182:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToLongFunction;",5);}
case 5:{return rt.Call(f,"java/util/Comparator","comparingLong","(Ljava/util/function/ToLongFunction;)Ljava/util/Comparator;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5183(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5183:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/zone/ZoneType;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5184(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5184:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5185(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5185:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5186(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5186:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5187(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5187:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5188(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5188:1:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5189(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5189:1:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5190(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?25:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","hasFirstStrike","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?21:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","hasDoubleStrike","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5191(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?25:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","hasFirstStrike","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?21:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","hasDoubleStrike","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5192(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5193(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isBasicLand","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?26:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?30:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","getManaAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int!=0?30:26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{f.Pc=31;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5194(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5195(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","isBasicLand","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5196(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","isBasicLand","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5197(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","isTokenCard","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5198(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","isTokenCard","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5199(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5200(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getSprocket","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?19:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","isContraption","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?19:15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Pc=20;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5201(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isAttraction","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?27:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getAttractionLights","()Ljava/util/Set;","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",15);}
case 15:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5202(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5203(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",14);}
case 14:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",19);}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5204(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?24:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/card/CardRules","getAiHints","()Lforge/card/CardAiHints;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/card/CardAiHints","getRemAIDecks","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5205(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getLastKnownZone","()Lforge/game/zone/Zone;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?50:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?50:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?47:45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 47:{f.Pc=16;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5206(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getLastKnownZone","()Lforge/game/zone/Zone;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?21:9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5207(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getExiledWith","()Lforge/game/card/Card;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5208(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","hasSVar","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5209(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5210(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5211(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","canReceiveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5212(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",5);}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Int<=0?19:10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?19:15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Pc=20;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5213(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?13:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5214(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",4);}
case 4:{f.Push(JValue.I(2));f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5215(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",4);}
case 4:{f.Push(JValue.I(2));f.Pc=5;continue;}
case 5:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Int!=0?13:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5216(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5217(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5218(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","sharesCMCWith","(I)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5219(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","isEnchantedBy","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5220(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","isEquippedBy","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5221(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5222(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/ColorSet","hasExactlyColor","(I)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5223(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5224(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5225(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5226(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5227(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Reference==null?21:5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5228(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Reference==null?21:5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5229(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?19:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlockAtLeastOne","(Lforge/game/card/Card;Ljava/lang/Iterable;)Z","invokestatic",12);}
case 12:{f.Pc=f.Pop().Int==0?19:15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Pc=20;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5230(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5231(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","sharesLandTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5232(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","sharesCreatureTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5233(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","sharesAllCardTypesWith","(Lforge/game/card/Card;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5234(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","sharesCardTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5235(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","sharesControllerWith","(Lforge/game/card/Card;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5236(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","sharesColorWith","(Lforge/game/card/Card;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5237(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","sharesCMCWith","(Lforge/game/card/Card;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5238(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","sharesNameWith","(Lforge/game/card/Card;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5239(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?15:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Pc=16;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5240(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5241(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getHiddenExtrinsicKeywords","()Ljava/lang/Iterable;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/PredicateString","contains","(Ljava/lang/String;)Lforge/util/PredicateString;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/util/IterableUtil","any","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Z","invokestatic",11);}
case 11:{f.Pc=f.Pop().Int==0?16:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",20);}
case 20:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?63:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[3]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",51);}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?60:58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 60:{f.Pc=26;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5242(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5243(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5244(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5245(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5246(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5247(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/util/collect/FCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5248(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5249(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","TAPPED","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","TAPPED","Ljava/util/function/Predicate;",f.Pop());f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:8:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",13);}
case 13:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","UNTAPPED","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","UNTAPPED","Ljava/util/function/Predicate;",f.Pop());f.Pc=16;continue;}
case 16:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:16:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",21);}
case 21:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CAN_TAP","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","CAN_TAP","Ljava/util/function/Predicate;",f.Pop());f.Pc=24;continue;}
case 24:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:24:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",29);}
case 29:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CAN_CREW","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","CAN_CREW","Ljava/util/function/Predicate;",f.Pop());f.Pc=32;continue;}
case 32:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:32:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",37);}
case 37:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;",f.Pop());f.Pc=40;continue;}
case 40:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:40:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",45);}
case 45:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","NON_CREATURES","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","NON_CREATURES","Ljava/util/function/Predicate;",f.Pop());f.Pc=48;continue;}
case 48:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:48:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",53);}
case 53:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","ENCHANTMENTS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","ENCHANTMENTS","Ljava/util/function/Predicate;",f.Pop());f.Pc=56;continue;}
case 56:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:56:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",61);}
case 61:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","FORTIFICATION","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","FORTIFICATION","Ljava/util/function/Predicate;",f.Pop());f.Pc=64;continue;}
case 64:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:64:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",69);}
case 69:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","NON_TOKEN","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","NON_TOKEN","Ljava/util/function/Predicate;",f.Pop());f.Pc=72;continue;}
case 72:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:72:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",77);}
case 77:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","TOKEN","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","TOKEN","Ljava/util/function/Predicate;",f.Pop());f.Pc=80;continue;}
case 80:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:80:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",85);}
case 85:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","BASIC_LANDS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","BASIC_LANDS","Ljava/util/function/Predicate;",f.Pop());f.Pc=88;continue;}
case 88:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:88:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",93);}
case 93:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","NONBASIC_LANDS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","NONBASIC_LANDS","Ljava/util/function/Predicate;",f.Pop());f.Pc=96;continue;}
case 96:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:96:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",101);}
case 101:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","ARTIFACTS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","ARTIFACTS","Ljava/util/function/Predicate;",f.Pop());f.Pc=104;continue;}
case 104:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:104:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",109);}
case 109:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","INSTANTS_AND_SORCERIES","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","INSTANTS_AND_SORCERIES","Ljava/util/function/Predicate;",f.Pop());f.Pc=112;continue;}
case 112:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:112:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",117);}
case 117:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","LANDS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","LANDS","Ljava/util/function/Predicate;",f.Pop());f.Pc=120;continue;}
case 120:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:120:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",125);}
case 125:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","NON_LANDS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","NON_LANDS","Ljava/util/function/Predicate;",f.Pop());f.Pc=128;continue;}
case 128:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:128:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",133);}
case 133:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","LANDS_PRODUCING_MANA","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","LANDS_PRODUCING_MANA","Ljava/util/function/Predicate;",f.Pop());f.Pc=136;continue;}
case 136:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:136:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",141);}
case 141:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","PERMANENTS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","PERMANENTS","Ljava/util/function/Predicate;",f.Pop());f.Pc=144;continue;}
case 144:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:144:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",149);}
case 149:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","NONLAND_PERMANENTS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","NONLAND_PERMANENTS","Ljava/util/function/Predicate;",f.Pop());f.Pc=152;continue;}
case 152:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:152:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",157);}
case 157:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","hasFirstStrike","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","hasFirstStrike","Ljava/util/function/Predicate;",f.Pop());f.Pc=160;continue;}
case 160:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:160:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",165);}
case 165:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","hasSecondStrike","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","hasSecondStrike","Ljava/util/function/Predicate;",f.Pop());f.Pc=168;continue;}
case 168:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:168:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",173);}
case 173:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","PLANESWALKERS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","PLANESWALKERS","Ljava/util/function/Predicate;",f.Pop());f.Pc=176;continue;}
case 176:{return rt.DynamicCall(f,"forge/game/card/CardPredicates:5249:176:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",181);}
case 181:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","BATTLES","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardPredicates","BATTLES","Ljava/util/function/Predicate;",f.Pop());f.Pc=184;continue;}
case 184:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

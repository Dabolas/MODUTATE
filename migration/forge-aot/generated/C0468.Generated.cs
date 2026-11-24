// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C468{
internal static JClass Build(){var c=new JClass("forge/game/card/CardState","java/lang/Object",new string[]{"forge/game/GameObject","forge/game/IHasSVars","forge/util/ITranslatable"},33);Add0(c);Add1(c);Add2(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("type","Lforge/card/CardType;",false,JValue.Default("Lforge/card/CardType;"),null));
c.Add(new JField("changedType","Lforge/card/CardTypeView;",false,JValue.Default("Lforge/card/CardTypeView;"),null));
c.Add(new JField("manaCost","Lforge/card/mana/ManaCost;",false,JValue.Default("Lforge/card/mana/ManaCost;"),null));
c.Add(new JField("perpetualAdjustedManaCost","Lforge/card/mana/ManaCost;",false,JValue.Default("Lforge/card/mana/ManaCost;"),null));
c.Add(new JField("color","Lforge/card/ColorSet;",false,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("oracleText","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("functionalVariantName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("flavorName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("basePower","I",false,JValue.Default("I"),null));
c.Add(new JField("baseToughness","I",false,JValue.Default("I"),null));
c.Add(new JField("basePowerString","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("baseToughnessString","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("baseLoyalty","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("baseDefense","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("intrinsicKeywords","Lforge/game/keyword/KeywordCollection;",false,JValue.Default("Lforge/game/keyword/KeywordCollection;"),null));
c.Add(new JField("attractionLights","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("abilities","Lforge/util/collect/FCollection;",false,JValue.Default("Lforge/util/collect/FCollection;"),null));
c.Add(new JField("triggers","Lforge/util/collect/FCollection;",false,JValue.Default("Lforge/util/collect/FCollection;"),null));
c.Add(new JField("replacementEffects","Lforge/util/collect/FCollection;",false,JValue.Default("Lforge/util/collect/FCollection;"),null));
c.Add(new JField("staticAbilities","Lforge/util/collect/FCollection;",false,JValue.Default("Lforge/util/collect/FCollection;"),null));
c.Add(new JField("staticAbilitiesVersion","I",false,JValue.Default("I"),null));
c.Add(new JField("staticCache","Lforge/game/card/CardState$StaticAbilitiesCache;",false,JValue.Default("Lforge/game/card/CardState$StaticAbilitiesCache;"),null));
c.Add(new JField("replacementEffectsVersion","I",false,JValue.Default("I"),null));
c.Add(new JField("replacementCacheRules","Lforge/game/card/CardState$ReplacementEffectsCache;",false,JValue.Default("Lforge/game/card/CardState$ReplacementEffectsCache;"),null));
c.Add(new JField("replacementCacheNoRules","Lforge/game/card/CardState$ReplacementEffectsCache;",false,JValue.Default("Lforge/game/card/CardState$ReplacementEffectsCache;"),null));
c.Add(new JField("imageKey","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sVars","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("abilityForTrigger","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cachedKeywords","Lforge/game/keyword/KeywordCollection;",false,JValue.Default("Lforge/game/keyword/KeywordCollection;"),null));
c.Add(new JField("rarity","Lforge/card/CardRarity;",false,JValue.Default("Lforge/card/CardRarity;"),null));
c.Add(new JField("setCode","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("view","Lforge/game/card/CardView$CardStateView;",false,JValue.Default("Lforge/game/card/CardView$CardStateView;"),null));
c.Add(new JField("card","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("landAbility","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("auraAbility","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("permanentAbility","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("landManaAbilities","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("loyaltyRep","Lforge/game/replacement/ReplacementEffect;",false,JValue.Default("Lforge/game/replacement/ReplacementEffect;"),null));
c.Add(new JField("defenseRep","Lforge/game/replacement/ReplacementEffect;",false,JValue.Default("Lforge/game/replacement/ReplacementEffect;"),null));
c.Add(new JField("sagaRep","Lforge/game/replacement/ReplacementEffect;",false,JValue.Default("Lforge/game/replacement/ReplacementEffect;"),null));
c.Add(new JField("adventureRep","Lforge/game/replacement/ReplacementEffect;",false,JValue.Default("Lforge/game/replacement/ReplacementEffect;"),null));
c.Add(new JField("omenRep","Lforge/game/replacement/ReplacementEffect;",false,JValue.Default("Lforge/game/replacement/ReplacementEffect;"),null));
c.Add(new JField("vengeanceRep","Lforge/game/replacement/ReplacementEffect;",false,JValue.Default("Lforge/game/replacement/ReplacementEffect;"),null));
c.Add(new JField("manifestUp","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("cloakUp","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("landTraitChanges","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(5258,"forge/game/card/CardState","<init>","(Lforge/game/card/Card;Lforge/card/CardStateName;)V",1,3,3,new JHandler[]{},M5258));
c.Add(new JMethod(5259,"forge/game/card/CardState","<init>","(Lforge/game/card/CardView$CardStateView;Lforge/game/card/Card;)V",1,3,4,new JHandler[]{},M5259));
c.Add(new JMethod(5260,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;",1,1,1,new JHandler[]{},M5260));
c.Add(new JMethod(5261,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M5261));
c.Add(new JMethod(5262,"forge/game/card/CardState","getName","()Ljava/lang/String;",17,1,1,new JHandler[]{},M5262));
c.Add(new JMethod(5263,"forge/game/card/CardState","setName","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M5263));
c.Add(new JMethod(5264,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;",1,1,1,new JHandler[]{},M5264));
c.Add(new JMethod(5265,"forge/game/card/CardState","toString","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5265));
c.Add(new JMethod(5266,"forge/game/card/CardState","getTypeWithChanges","()Lforge/card/CardTypeView;",1,1,2,new JHandler[]{},M5266));
c.Add(new JMethod(5267,"forge/game/card/CardState","updateTypes","()V",1,1,3,new JHandler[]{},M5267));
c.Add(new JMethod(5268,"forge/game/card/CardState","updateTypesForView","()V",1,1,2,new JHandler[]{},M5268));
c.Add(new JMethod(5269,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;",17,1,1,new JHandler[]{},M5269));
c.Add(new JMethod(5270,"forge/game/card/CardState","addType","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M5270));
c.Add(new JMethod(5271,"forge/game/card/CardState","addType","(Ljava/lang/Iterable;)V",17,2,2,new JHandler[]{},M5271));
c.Add(new JMethod(5272,"forge/game/card/CardState","setType","(Lforge/card/CardType;)V",17,2,2,new JHandler[]{},M5272));
c.Add(new JMethod(5273,"forge/game/card/CardState","removeType","(Lforge/card/CardType$Supertype;)V",17,2,2,new JHandler[]{},M5273));
c.Add(new JMethod(5274,"forge/game/card/CardState","removeCardTypes","(Z)V",17,2,1,new JHandler[]{},M5274));
}

private static void Add1(JClass c){
c.Add(new JMethod(5275,"forge/game/card/CardState","setCreatureTypes","(Ljava/util/Collection;)V",17,2,2,new JHandler[]{},M5275));
c.Add(new JMethod(5276,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;",17,1,1,new JHandler[]{},M5276));
c.Add(new JMethod(5277,"forge/game/card/CardState","setManaCost","(Lforge/card/mana/ManaCost;)V",17,2,2,new JHandler[]{},M5277));
c.Add(new JMethod(5278,"forge/game/card/CardState","calculatePerpetualAdjustedManaCost","()V",1,6,7,new JHandler[]{new JHandler(125,144,147,"java/lang/NumberFormatException")},M5278));
c.Add(new JMethod(5279,"forge/game/card/CardState","getPerpetualAdjustedManaCost","()Lforge/card/mana/ManaCost;",1,1,1,new JHandler[]{},M5279));
c.Add(new JMethod(5280,"forge/game/card/CardState","getColor","()Lforge/card/ColorSet;",17,1,1,new JHandler[]{},M5280));
c.Add(new JMethod(5281,"forge/game/card/CardState","addColor","(Lforge/card/ColorSet;)V",17,2,5,new JHandler[]{},M5281));
c.Add(new JMethod(5282,"forge/game/card/CardState","setColor","(Lforge/card/ColorSet;)V",17,2,2,new JHandler[]{},M5282));
c.Add(new JMethod(5283,"forge/game/card/CardState","getOracleText","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5283));
c.Add(new JMethod(5284,"forge/game/card/CardState","setOracleText","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M5284));
c.Add(new JMethod(5285,"forge/game/card/CardState","getFunctionalVariantName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5285));
c.Add(new JMethod(5286,"forge/game/card/CardState","setFunctionalVariantName","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M5286));
c.Add(new JMethod(5287,"forge/game/card/CardState","getFlavorName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5287));
c.Add(new JMethod(5288,"forge/game/card/CardState","setFlavorName","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M5288));
c.Add(new JMethod(5289,"forge/game/card/CardState","getBasePower","()I",17,1,1,new JHandler[]{},M5289));
c.Add(new JMethod(5290,"forge/game/card/CardState","setBasePower","(I)V",17,2,2,new JHandler[]{},M5290));
c.Add(new JMethod(5291,"forge/game/card/CardState","getBaseToughness","()I",17,1,1,new JHandler[]{},M5291));
c.Add(new JMethod(5292,"forge/game/card/CardState","setBaseToughness","(I)V",17,2,2,new JHandler[]{},M5292));
c.Add(new JMethod(5293,"forge/game/card/CardState","getBasePowerString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M5293));
c.Add(new JMethod(5294,"forge/game/card/CardState","getBaseToughnessString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M5294));
c.Add(new JMethod(5295,"forge/game/card/CardState","setBasePowerString","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M5295));
c.Add(new JMethod(5296,"forge/game/card/CardState","setBaseToughnessString","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M5296));
c.Add(new JMethod(5297,"forge/game/card/CardState","hasPrintedPT","()Z",17,1,1,new JHandler[]{},M5297));
c.Add(new JMethod(5298,"forge/game/card/CardState","getBaseLoyalty","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5298));
c.Add(new JMethod(5299,"forge/game/card/CardState","setBaseLoyalty","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M5299));
c.Add(new JMethod(5300,"forge/game/card/CardState","getBaseDefense","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5300));
c.Add(new JMethod(5301,"forge/game/card/CardState","setBaseDefense","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M5301));
c.Add(new JMethod(5302,"forge/game/card/CardState","getAttractionLights","()Ljava/util/Set;",1,1,1,new JHandler[]{},M5302));
c.Add(new JMethod(5303,"forge/game/card/CardState","setAttractionLights","(Ljava/util/Set;)V",17,2,2,new JHandler[]{},M5303));
c.Add(new JMethod(5304,"forge/game/card/CardState","getCachedKeywords","()Lforge/game/keyword/KeywordCollection;",17,1,1,new JHandler[]{},M5304));
c.Add(new JMethod(5305,"forge/game/card/CardState","getCachedKeyword","(Lforge/game/keyword/Keyword;)Ljava/util/Collection;",17,2,2,new JHandler[]{},M5305));
c.Add(new JMethod(5306,"forge/game/card/CardState","setCachedKeywords","(Lforge/game/keyword/KeywordCollection;)V",17,2,2,new JHandler[]{},M5306));
c.Add(new JMethod(5307,"forge/game/card/CardState","hasKeyword","(Lforge/game/keyword/Keyword;)Z",17,2,2,new JHandler[]{},M5307));
c.Add(new JMethod(5308,"forge/game/card/CardState","getIntrinsicKeywords","()Ljava/util/Collection;",17,1,1,new JHandler[]{},M5308));
c.Add(new JMethod(5309,"forge/game/card/CardState","hasIntrinsicKeyword","(Ljava/lang/String;)Z",17,2,2,new JHandler[]{},M5309));
c.Add(new JMethod(5310,"forge/game/card/CardState","hasIntrinsicKeyword","(Lforge/game/keyword/Keyword;)Z",17,2,2,new JHandler[]{},M5310));
c.Add(new JMethod(5311,"forge/game/card/CardState","setIntrinsicKeywords","(Ljava/lang/Iterable;Z)V",17,5,4,new JHandler[]{},M5311));
c.Add(new JMethod(5312,"forge/game/card/CardState","addIntrinsicKeyword","(Ljava/lang/String;Z)Lforge/game/keyword/KeywordInterface;",17,7,4,new JHandler[]{new JHandler(14,23,26,"java/lang/Exception")},M5312));
c.Add(new JMethod(5313,"forge/game/card/CardState","addIntrinsicKeywords","(Ljava/lang/Iterable;)Z",17,2,3,new JHandler[]{},M5313));
c.Add(new JMethod(5314,"forge/game/card/CardState","addIntrinsicKeywords","(Ljava/lang/Iterable;Z)Z",17,6,3,new JHandler[]{},M5314));
c.Add(new JMethod(5315,"forge/game/card/CardState","removeIntrinsicKeyword","(Ljava/lang/String;)Z",17,2,2,new JHandler[]{},M5315));
c.Add(new JMethod(5316,"forge/game/card/CardState","removeIntrinsicKeyword","(Lforge/game/keyword/KeywordInterface;)Z",17,2,2,new JHandler[]{},M5316));
c.Add(new JMethod(5317,"forge/game/card/CardState","removeIntrinsicKeyword","(Lforge/game/keyword/Keyword;)Z",17,2,2,new JHandler[]{},M5317));
c.Add(new JMethod(5318,"forge/game/card/CardState","getSpellAbilities","()Lforge/util/collect/FCollectionView;",17,2,3,new JHandler[]{},M5318));
c.Add(new JMethod(5319,"forge/game/card/CardState","getManaAbilities","()Lforge/util/collect/FCollectionView;",17,2,3,new JHandler[]{},M5319));
c.Add(new JMethod(5320,"forge/game/card/CardState","getNonManaAbilities","()Lforge/util/collect/FCollectionView;",17,2,3,new JHandler[]{},M5320));
c.Add(new JMethod(5321,"forge/game/card/CardState","updateSpellAbilities","(Lforge/util/collect/FCollection;)V",20,3,5,new JHandler[]{},M5321));
c.Add(new JMethod(5322,"forge/game/card/CardState","getLandManaForColor","(Lforge/card/MagicColor$Color;)Lforge/game/spellability/SpellAbility;",1,2,3,new JHandler[]{},M5322));
c.Add(new JMethod(5323,"forge/game/card/CardState","getLandTraitChanges","()Ljava/util/List;",1,1,1,new JHandler[]{},M5323));
c.Add(new JMethod(5324,"forge/game/card/CardState","getIntrinsicSpellAbilities","()Ljava/lang/Iterable;",17,1,2,new JHandler[]{},M5324));
c.Add(new JMethod(5325,"forge/game/card/CardState","getFirstAbility","()Lforge/game/spellability/SpellAbility;",17,1,2,new JHandler[]{},M5325));
c.Add(new JMethod(5326,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;",17,1,2,new JHandler[]{},M5326));
c.Add(new JMethod(5327,"forge/game/card/CardState","getFirstSpellAbilityWithFallback","()Lforge/game/spellability/SpellAbility;",17,3,5,new JHandler[]{},M5327));
c.Add(new JMethod(5328,"forge/game/card/CardState","getAuraSpell","()Lforge/game/spellability/SpellAbility;",17,7,3,new JHandler[]{},M5328));
c.Add(new JMethod(5329,"forge/game/card/CardState","hasSpellAbility","(Lforge/game/spellability/SpellAbility;)Z",17,2,2,new JHandler[]{},M5329));
c.Add(new JMethod(5330,"forge/game/card/CardState","hasSpellAbility","(I)Z",17,4,2,new JHandler[]{},M5330));
c.Add(new JMethod(5331,"forge/game/card/CardState","addSpellAbility","(Lforge/game/spellability/SpellAbility;)Z",17,2,2,new JHandler[]{},M5331));
c.Add(new JMethod(5332,"forge/game/card/CardState","getTriggers","()Lforge/util/collect/FCollectionView;",17,2,3,new JHandler[]{},M5332));
c.Add(new JMethod(5333,"forge/game/card/CardState","hasTrigger","(Lforge/game/trigger/Trigger;)Z",17,2,2,new JHandler[]{},M5333));
c.Add(new JMethod(5334,"forge/game/card/CardState","hasTrigger","(I)Z",17,4,2,new JHandler[]{},M5334));
c.Add(new JMethod(5335,"forge/game/card/CardState","addTrigger","(Lforge/game/trigger/Trigger;)Z",17,2,2,new JHandler[]{},M5335));
c.Add(new JMethod(5336,"forge/game/card/CardState","getStaticAbilities","()Lforge/util/collect/FCollectionView;",17,12,11,new JHandler[]{},M5336));
c.Add(new JMethod(5337,"forge/game/card/CardState","staticAbilitiesStamp","()I",2,1,2,new JHandler[]{},M5337));
c.Add(new JMethod(5338,"forge/game/card/CardState","buildStaticAbilities","()Lforge/util/collect/FCollection;",2,2,3,new JHandler[]{},M5338));
}

private static void Add2(JClass c){
c.Add(new JMethod(5339,"forge/game/card/CardState","addStaticAbility","(Lforge/game/staticability/StaticAbility;)Z",17,3,3,new JHandler[]{},M5339));
c.Add(new JMethod(5340,"forge/game/card/CardState","removeStaticAbility","(Lforge/game/staticability/StaticAbility;)Z",17,3,3,new JHandler[]{},M5340));
c.Add(new JMethod(5341,"forge/game/card/CardState","getReplacementEffects","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M5341));
c.Add(new JMethod(5342,"forge/game/card/CardState","getReplacementEffects","(Z)Lforge/util/collect/FCollectionView;",1,14,10,new JHandler[]{},M5342));
c.Add(new JMethod(5343,"forge/game/card/CardState","replacementEffectsStamp","()I",2,1,2,new JHandler[]{},M5343));
c.Add(new JMethod(5344,"forge/game/card/CardState","replacementFlags","(Z)I",2,4,2,new JHandler[]{},M5344));
c.Add(new JMethod(5345,"forge/game/card/CardState","buildReplacementEffects","(Z)Lforge/util/collect/FCollection;",2,3,4,new JHandler[]{},M5345));
c.Add(new JMethod(5346,"forge/game/card/CardState","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Z",1,3,3,new JHandler[]{},M5346));
c.Add(new JMethod(5347,"forge/game/card/CardState","hasReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Z",17,2,2,new JHandler[]{},M5347));
c.Add(new JMethod(5348,"forge/game/card/CardState","hasReplacementEffect","(I)Z",17,2,2,new JHandler[]{},M5348));
c.Add(new JMethod(5349,"forge/game/card/CardState","getReplacementEffect","(I)Lforge/game/replacement/ReplacementEffect;",17,4,2,new JHandler[]{},M5349));
c.Add(new JMethod(5350,"forge/game/card/CardState","getLoyaltyRep","()Lforge/game/replacement/ReplacementEffect;",1,1,4,new JHandler[]{},M5350));
c.Add(new JMethod(5351,"forge/game/card/CardState","getDefenseRep","()Lforge/game/replacement/ReplacementEffect;",1,1,4,new JHandler[]{},M5351));
c.Add(new JMethod(5352,"forge/game/card/CardState","getSagaRep","()Lforge/game/replacement/ReplacementEffect;",1,1,4,new JHandler[]{},M5352));
c.Add(new JMethod(5353,"forge/game/card/CardState","getSVars","()Ljava/util/Map;",17,1,1,new JHandler[]{},M5353));
c.Add(new JMethod(5354,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;",17,2,2,new JHandler[]{},M5354));
c.Add(new JMethod(5355,"forge/game/card/CardState","hasSVar","(Ljava/lang/String;)Z",17,2,2,new JHandler[]{},M5355));
c.Add(new JMethod(5356,"forge/game/card/CardState","setSVar","(Ljava/lang/String;Ljava/lang/String;)V",17,3,3,new JHandler[]{},M5356));
c.Add(new JMethod(5357,"forge/game/card/CardState","setSVars","(Ljava/util/Map;)V",17,2,3,new JHandler[]{},M5357));
c.Add(new JMethod(5358,"forge/game/card/CardState","removeSVar","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M5358));
c.Add(new JMethod(5359,"forge/game/card/CardState","getFoil","()I",17,2,2,new JHandler[]{},M5359));
c.Add(new JMethod(5360,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V",17,3,4,new JHandler[]{},M5360));
c.Add(new JMethod(5361,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;ZLforge/game/CardTraitBase;)V",17,9,8,new JHandler[]{},M5361));
c.Add(new JMethod(5362,"forge/game/card/CardState","addAbilitiesFrom","(Lforge/game/card/CardState;Z)V",17,5,4,new JHandler[]{},M5362));
c.Add(new JMethod(5363,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/card/CardStateName;Z)Lforge/game/card/CardState;",1,4,5,new JHandler[]{},M5363));
c.Add(new JMethod(5364,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;",1,3,5,new JHandler[]{},M5364));
c.Add(new JMethod(5365,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/card/CardStateName;Lforge/game/CardTraitBase;)Lforge/game/card/CardState;",1,4,5,new JHandler[]{},M5365));
c.Add(new JMethod(5366,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/card/CardStateName;ZLforge/game/CardTraitBase;)Lforge/game/card/CardState;",1,6,4,new JHandler[]{},M5366));
c.Add(new JMethod(5367,"forge/game/card/CardState","getRarity","()Lforge/card/CardRarity;",1,1,1,new JHandler[]{},M5367));
c.Add(new JMethod(5368,"forge/game/card/CardState","setRarity","(Lforge/card/CardRarity;)V",1,2,2,new JHandler[]{},M5368));
c.Add(new JMethod(5369,"forge/game/card/CardState","getSetCode","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5369));
c.Add(new JMethod(5370,"forge/game/card/CardState","setSetCode","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M5370));
c.Add(new JMethod(5371,"forge/game/card/CardState","getImageKey","()Ljava/lang/String;",17,1,1,new JHandler[]{},M5371));
c.Add(new JMethod(5372,"forge/game/card/CardState","setImageKey","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M5372));
c.Add(new JMethod(5373,"forge/game/card/CardState","hasProperty","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z",1,5,5,new JHandler[]{},M5373));
c.Add(new JMethod(5374,"forge/game/card/CardState","getTraits","()Lcom/google/common/collect/ImmutableList;",1,1,2,new JHandler[]{},M5374));
c.Add(new JMethod(5375,"forge/game/card/CardState","resetOriginalHost","(Lforge/game/card/Card;)V",1,4,2,new JHandler[]{},M5375));
c.Add(new JMethod(5376,"forge/game/card/CardState","updateChangedText","()V",1,3,1,new JHandler[]{},M5376));
c.Add(new JMethod(5377,"forge/game/card/CardState","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V",1,5,3,new JHandler[]{},M5377));
c.Add(new JMethod(5378,"forge/game/card/CardState","hasChapter","()Z",17,1,2,new JHandler[]{},M5378));
c.Add(new JMethod(5379,"forge/game/card/CardState","getFinalChapterNr","()I",17,4,2,new JHandler[]{},M5379));
c.Add(new JMethod(5380,"forge/game/card/CardState","getManifestUp","()Lforge/game/spellability/SpellAbility;",1,1,6,new JHandler[]{},M5380));
c.Add(new JMethod(5381,"forge/game/card/CardState","getCloakUp","()Lforge/game/spellability/SpellAbility;",1,1,6,new JHandler[]{},M5381));
c.Add(new JMethod(5382,"forge/game/card/CardState","getAbilityForTrigger","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;",1,2,3,new JHandler[]{},M5382));
c.Add(new JMethod(5383,"forge/game/card/CardState","getTranslationKey","()Ljava/lang/String;",1,2,2,new JHandler[]{},M5383));
c.Add(new JMethod(5384,"forge/game/card/CardState","getUntranslatedType","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5384));
c.Add(new JMethod(5385,"forge/game/card/CardState","getTranslatedName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5385));
c.Add(new JMethod(5386,"forge/game/card/CardState","isWorthy","()Z",1,3,2,new JHandler[]{},M5386));
c.Add(new JMethod(5387,"forge/game/card/CardState","lambda$getAbilityForTrigger$2","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;",4098,2,3,new JHandler[]{},M5387));
c.Add(new JMethod(5388,"forge/game/card/CardState","lambda$getLandManaForColor$1","(Lforge/card/MagicColor$Color;)Lforge/game/spellability/SpellAbility;",4098,4,2,new JHandler[]{},M5388));
c.Add(new JMethod(5389,"forge/game/card/CardState","lambda$updateSpellAbilities$0","(Lforge/game/spellability/SpellAbility;)Z",4106,1,2,new JHandler[]{},M5389));
}

internal static JStep M5258(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardView","createAlternateState","(Lforge/card/CardStateName;)Lforge/game/card/CardView$CardStateView;","invokevirtual",9);}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardState","<init>","(Lforge/game/card/CardView$CardStateView;Lforge/game/card/Card;)V","invokespecial",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5259(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("")));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","name","Ljava/lang/String;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/CardType","<init>","(Z)V","invokespecial",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(null));f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","changedType","Lforge/card/CardTypeView;",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"));f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","manaCost","Lforge/card/mana/ManaCost;",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(null));f.Pc=36;continue;}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","perpetualAdjustedManaCost","Lforge/card/mana/ManaCost;",value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{if(!rt.StaticReady(f,"forge/card/ColorSet","C","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","C","Lforge/card/ColorSet;"));f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","color","Lforge/card/ColorSet;",value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("")));f.Pc=49;continue;}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","oracleText","Ljava/lang/String;",value);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(JValue.R(null));f.Pc=54;continue;}
case 54:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","functionalVariantName","Ljava/lang/String;",value);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(null));f.Pc=59;continue;}
case 59:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","flavorName","Ljava/lang/String;",value);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","basePower","I",value);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","baseToughness","I",value);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(null));f.Pc=74;continue;}
case 74:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","basePowerString","Ljava/lang/String;",value);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(null));f.Pc=79;continue;}
case 79:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","baseToughnessString","Ljava/lang/String;",value);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("")));f.Pc=85;continue;}
case 85:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","baseLoyalty","Ljava/lang/String;",value);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("")));f.Pc=91;continue;}
case 91:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","baseDefense","Ljava/lang/String;",value);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{if(!rt.EnsureInitialized(f,"forge/game/keyword/KeywordCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/keyword/KeywordCollection")));f.Pc=98;continue;}
case 98:{f.StackOp("dup");f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/keyword/KeywordCollection","<init>","()V","invokespecial",102);}
case 102:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","intrinsicKeywords","Lforge/game/keyword/KeywordCollection;",value);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(null));f.Pc=107;continue;}
case 107:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","attractionLights","Ljava/util/Set;",value);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=114;continue;}
case 114:{f.StackOp("dup");f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",118);}
case 118:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;",value);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",129);}
case 129:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","triggers","Lforge/util/collect/FCollection;",value);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=136;continue;}
case 136:{f.StackOp("dup");f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",140);}
case 140:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","replacementEffects","Lforge/util/collect/FCollection;",value);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[0]);f.Pc=144;continue;}
case 144:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=147;continue;}
case 147:{f.StackOp("dup");f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",151);}
case 151:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","staticAbilities","Lforge/util/collect/FCollection;",value);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{f.Push(JValue.I(0));f.Pc=156;continue;}
case 156:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","staticAbilitiesVersion","I",value);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(null));f.Pc=161;continue;}
case 161:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","staticCache","Lforge/game/card/CardState$StaticAbilitiesCache;",value);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(JValue.I(0));f.Pc=166;continue;}
case 166:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","replacementEffectsVersion","I",value);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[0]);f.Pc=170;continue;}
case 170:{f.Push(JValue.R(null));f.Pc=171;continue;}
case 171:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","replacementCacheRules","Lforge/game/card/CardState$ReplacementEffectsCache;",value);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{f.Push(JValue.R(null));f.Pc=176;continue;}
case 176:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","replacementCacheNoRules","Lforge/game/card/CardState$ReplacementEffectsCache;",value);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("")));f.Pc=182;continue;}
case 182:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","imageKey","Ljava/lang/String;",value);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"com/google/common/collect/Maps","newTreeMap","()Ljava/util/TreeMap;","invokestatic",189);}
case 189:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","sVars","Ljava/util/Map;",value);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[0]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",196);}
case 196:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","abilityForTrigger","Ljava/util/Map;",value);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[0]);f.Pc=200;continue;}
case 200:{if(!rt.EnsureInitialized(f,"forge/game/keyword/KeywordCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/keyword/KeywordCollection")));f.Pc=203;continue;}
case 203:{f.StackOp("dup");f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/keyword/KeywordCollection","<init>","()V","invokespecial",207);}
case 207:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","cachedKeywords","Lforge/game/keyword/KeywordCollection;",value);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[0]);f.Pc=211;continue;}
case 211:{if(!rt.StaticReady(f,"forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"));f.Pc=214;continue;}
case 214:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","rarity","Lforge/card/CardRarity;",value);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[0]);f.Pc=218;continue;}
case 218:{f.Push(JValue.R(rt.String("???")));f.Pc=220;continue;}
case 220:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","setCode","Ljava/lang/String;",value);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[0]);f.Pc=224;continue;}
case 224:{f.Push(JValue.R(rt.ClassObject("forge/card/MagicColor$Color")));f.Pc=226;continue;}
case 226:{return rt.Call(f,"com/google/common/collect/Maps","newEnumMap","(Ljava/lang/Class;)Ljava/util/EnumMap;","invokestatic",229);}
case 229:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","landManaAbilities","Ljava/util/Map;",value);f.Pc=232;continue;}
case 232:{f.Push(f.Locals[0]);f.Pc=233;continue;}
case 233:{if(!rt.EnsureInitialized(f,"forge/game/card/CardState$LandTraitChanges"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardState$LandTraitChanges")));f.Pc=236;continue;}
case 236:{f.StackOp("dup");f.Pc=237;continue;}
case 237:{f.Push(f.Locals[0]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/card/CardState$LandTraitChanges","<init>","(Lforge/game/card/CardState;)V","invokespecial",241);}
case 241:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",244);}
case 244:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","landTraitChanges","Ljava/util/List;",value);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[0]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[1]);f.Pc=249;continue;}
case 249:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;",value);f.Pc=252;continue;}
case 252:{f.Push(f.Locals[0]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[2]);f.Pc=254;continue;}
case 254:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;",value);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[0]);f.Pc=258;continue;}
case 258:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=261;continue;}
case 261:{f.Push(f.Locals[0]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateRarity","(Lforge/game/card/CardState;)V","invokevirtual",265);}
case 265:{f.Push(f.Locals[0]);f.Pc=266;continue;}
case 266:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=269;continue;}
case 269:{f.Push(f.Locals[0]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateSetCode","(Lforge/game/card/CardState;)V","invokevirtual",273);}
case 273:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5260(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5261(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5262(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5263(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","name","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateName","(Lforge/game/card/CardState;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5264(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getState","()Lforge/card/CardStateName;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5265(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getState","()Lforge/card/CardStateName;","invokevirtual",11);}
case 11:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",14);}
case 14:{return rt.DynamicCall(f,"forge/game/card/CardState:5265:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5266(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","changedType","Lforge/card/CardTypeView;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",11);}
case 11:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardTypeView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5267(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getChangedCardTypes","()Ljava/lang/Iterable;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/card/CardTypeView","getTypeWithChanges","(Ljava/lang/Iterable;)Lforge/card/CardTypeView;","invokeinterface",17);}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","changedType","Lforge/card/CardTypeView;",value);f.Pc=20;continue;}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5268(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateType","(Lforge/game/card/CardState;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5269(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5270(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","add","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?19:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardState","updateTypes","()V","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardState","updateTypesForView","()V","invokevirtual",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5271(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?19:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardState","updateTypes","()V","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardState","updateTypesForView","()V","invokevirtual",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5272(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?9:8;continue;}
case 8:{return JStep.ReturnVoid;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/CardType","isEmpty","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?27:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardType","isEmpty","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?27:26;continue;}
case 26:{return JStep.ReturnVoid;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/card/CardType","clear","()V","invokevirtual",34);}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/card/CardType","addAll","(Lforge/card/CardType;)Z","invokevirtual",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/CardState","updateTypes","()V","invokevirtual",47);}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/CardState","updateTypesForView","()V","invokevirtual",51);}
case 51:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5273(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","remove","(Lforge/card/CardType$Supertype;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?19:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardState","updateTypes","()V","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardState","updateTypesForView","()V","invokevirtual",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5274(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardType","removeCardTypes","()V","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int==0?18:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardType","sanisfySubtypes","()V","invokevirtual",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardState","updateTypes","()V","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardState","updateTypesForView","()V","invokevirtual",26);}
case 26:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5275(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","setCreatureTypes","(Ljava/util/Collection;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?19:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardState","updateTypes","()V","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardState","updateTypesForView","()V","invokevirtual",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5276(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5277(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","manaCost","Lforge/card/mana/ManaCost;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateManaCost","(Lforge/game/card/CardState;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5278(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?40:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Reference==null?40:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/mana/ManaCost","getGenericCost","()I","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?41:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/card/mana/ManaCost","getShardCount","(Lforge/card/mana/ManaCostShard;)I","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int!=0?41:40;continue;}
case 40:{return JStep.ReturnVoid;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Locals[1]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/CardState","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",52);}
case 52:{f.Locals[2]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",59);}
case 59:{f.Pc=f.Pop().Int==0?152:62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",68);}
case 68:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=71;continue;}
case 71:{f.Locals[3]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("Card.Self")));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",82);}
case 82:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?149:88;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{f.Locals[4]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ReduceCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","ReduceCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?107:101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{f.Locals[4]=f.Pop();f.Pc=104;continue;}
case 104:{f.Pc=120;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","RaiseCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","RaiseCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?120:117;continue;}
case 117:{f.Push(JValue.I(-1));f.Pc=118;continue;}
case 118:{f.Locals[4]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[4]);f.Pc=122;continue;}
case 122:{f.Pc=f.Pop().Int==0?149:125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("Amount")));f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("1")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",136);}
case 136:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",139);}
case 139:{f.Push(f.Locals[4]);f.Pc=141;continue;}
case 141:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=142;continue;}
case 142:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=143;continue;}
case 143:{f.Locals[1]=f.Pop();f.Pc=144;continue;}
case 144:{f.Pc=149;continue;}
case 147:{f.Locals[5]=f.Pop();f.Pc=149;continue;}
case 149:{f.Pc=53;continue;}
case 152:{f.Push(f.Locals[1]);f.Pc=153;continue;}
case 153:{f.Pc=f.Pop().Int!=0?157:156;continue;}
case 156:{return JStep.ReturnVoid;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/card/mana/ManaCost","getGenericCost","()I","invokevirtual",164);}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=166;continue;}
case 166:{f.Locals[2]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=171;continue;}
case 171:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/card/mana/ManaCost","getShardCount","(Lforge/card/mana/ManaCostShard;)I","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int!=0?186:180;continue;}
case 180:{f.Push(JValue.I(0));f.Pc=181;continue;}
case 181:{f.Push(f.Locals[2]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",185);}
case 185:{f.Locals[2]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=190;continue;}
case 190:{f.StackOp("dup");f.Pc=191;continue;}
case 191:{f.Push(f.Locals[2]);f.Pc=192;continue;}
case 192:{f.Pc=f.Pop().Int==0?204:195;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{return rt.DynamicCall(f,"forge/game/card/CardState:5278:196:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",201);}
case 201:{f.Pc=206;continue;}
case 204:{f.Push(JValue.R(rt.String("")));f.Pc=206;continue;}
case 206:{f.Push(f.Locals[0]);f.Pc=207;continue;}
case 207:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/card/mana/ManaCost","getShortString","()Ljava/lang/String;","invokevirtual",213);}
case 213:{f.Push(f.Locals[0]);f.Pc=214;continue;}
case 214:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/card/mana/ManaCost","getGenericCost","()I","invokevirtual",220);}
case 220:{return rt.DynamicCall(f,"forge/game/card/CardState:5278:220:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",225);}
case 225:{f.Push(JValue.R(rt.String("")));f.Pc=227;continue;}
case 227:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",230);}
case 230:{return rt.DynamicCall(f,"forge/game/card/CardState:5278:230:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",235);}
case 235:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",238);}
case 238:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","perpetualAdjustedManaCost","Lforge/card/mana/ManaCost;",value);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=245;continue;}
case 245:{f.Push(f.Locals[0]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateManaCost","(Lforge/game/card/CardState;)V","invokevirtual",249);}
case 249:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5279(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","perpetualAdjustedManaCost","Lforge/card/mana/ManaCost;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",11);}
case 11:{f.Pc=18;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","perpetualAdjustedManaCost","Lforge/card/mana/ManaCost;"));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5280(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","color","Lforge/card/ColorSet;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5281(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(2));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/ColorSet;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","color","Lforge/card/ColorSet;"));f.Pc=11;continue;}
case 11:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/ColorSet","combine","([Lforge/card/ColorSet;)Lforge/card/ColorSet;","invokestatic",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","color","Lforge/card/ColorSet;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateColors","(Lforge/game/card/Card;)V","invokevirtual",33);}
case 33:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5282(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","color","Lforge/card/ColorSet;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateColors","(Lforge/game/card/Card;)V","invokevirtual",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5283(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","oracleText","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5284(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","oracleText","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardView$CardStateView","setOracleText","(Ljava/lang/String;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5285(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","functionalVariantName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5286(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?13:11;continue;}
case 11:{f.Push(JValue.R(null));f.Pc=12;continue;}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","functionalVariantName","Ljava/lang/String;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardView$CardStateView","setFunctionalVariantName","(Ljava/lang/String;)V","invokevirtual",26);}
case 26:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5287(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","flavorName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5288(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","flavorName","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateName","(Lforge/game/card/CardState;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5289(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","basePower","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5290(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","basePower","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?9:8;continue;}
case 8:{return JStep.ReturnVoid;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","basePower","I",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updatePower","(Lforge/game/card/CardState;)V","invokevirtual",22);}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5291(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","baseToughness","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5292(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","baseToughness","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?9:8;continue;}
case 8:{return JStep.ReturnVoid;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","baseToughness","I",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateToughness","(Lforge/game/card/CardState;)V","invokevirtual",22);}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5293(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","basePowerString","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5294(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","baseToughnessString","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5295(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","basePowerString","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5296(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","baseToughnessString","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5297(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","basePowerString","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",7);}
case 7:{f.Pc=f.Pop().Int==0?20:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","baseToughnessString","Ljava/lang/String;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",17);}
case 17:{f.Pc=f.Pop().Int!=0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5298(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","baseLoyalty","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5299(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","baseLoyalty","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateLoyalty","(Lforge/game/card/CardState;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5300(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","baseDefense","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5301(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","baseDefense","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateDefense","(Lforge/game/card/CardState;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5302(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","attractionLights","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5303(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","attractionLights","Ljava/util/Set;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateAttractionLights","(Lforge/game/card/CardState;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5304(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","cachedKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5305(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","cachedKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordCollection","getValues","(Lforge/game/keyword/Keyword;)Ljava/util/Collection;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5306(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","cachedKeywords","Lforge/game/keyword/KeywordCollection;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5307(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","cachedKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordCollection","contains","(Lforge/game/keyword/Keyword;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5308(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","intrinsicKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/keyword/KeywordCollection","getValues","()Ljava/util/Collection;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5309(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","intrinsicKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordCollection","contains","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5310(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","intrinsicKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordCollection","contains","(Lforge/game/keyword/Keyword;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5311(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","intrinsicKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/keyword/KeywordCollection","clear","()V","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?57:23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","intrinsicKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/keyword/KeywordInterface","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordInterface;","invokeinterface",50);}
case 50:{return rt.Call(f,"forge/game/keyword/KeywordCollection","insert","(Lforge/game/keyword/KeywordInterface;)Z","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Pc=14;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/Card","updateKeywordsCache","(Lforge/game/card/CardState;)V","invokevirtual",65);}
case 65:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5312(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","intrinsicKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/keyword/KeywordCollection","add","(Ljava/lang/String;)Lforge/game/keyword/KeywordInterface;","invokevirtual",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Pc=96;continue;}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("CardState:addIntrinsicKeyword: failed to parse Keyword")));f.Pc=31;continue;}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"io/sentry/Breadcrumb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("io/sentry/Breadcrumb")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[5]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"io/sentry/Breadcrumb","<init>","(Ljava/lang/String;)V","invokespecial",42);}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[6]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("Card")));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",56);}
case 56:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",59);}
case 59:{f.Push(f.Locals[6]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Keyword")));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",68);}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"io/sentry/Sentry","addBreadcrumb","(Lio/sentry/Breadcrumb;)V","invokestatic",73);}
case 73:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",85);}
case 85:{return rt.DynamicCall(f,"forge/game/card/CardState:5312:85:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",90);}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",95);}
case 95:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{f.Pc=f.Pop().Reference==null?115:100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{f.Pc=f.Pop().Int==0?115:104;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=109;continue;}
case 109:{f.Push(JValue.I(1));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/keyword/KeywordInterface","createTraits","(Lforge/game/card/Card;Z)V","invokeinterface",115);}
case 115:{f.Push(f.Locals[3]);f.Pc=116;continue;}
case 116:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5313(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/CardState","addIntrinsicKeywords","(Ljava/lang/Iterable;Z)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5314(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?47:20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardState","addIntrinsicKeyword","(Ljava/lang/String;Z)Lforge/game/keyword/KeywordInterface;","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Reference==null?44:42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Pc=10;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5315(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","intrinsicKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordCollection","remove","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5316(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","intrinsicKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordCollection","remove","(Lforge/game/keyword/KeywordInterface;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5317(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","intrinsicKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordCollection","removeAll","(Lforge/game/keyword/Keyword;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5318(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardState","updateSpellAbilities","(Lforge/util/collect/FCollection;)V","invokevirtual",13);}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","updateSpellAbilities","(Ljava/util/List;Lforge/game/card/CardState;)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5319(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardState","updateSpellAbilities","(Lforge/util/collect/FCollection;)V","invokevirtual",13);}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","updateSpellAbilities","(Ljava/util/List;Lforge/game/card/CardState;)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.DynamicCall(f,"forge/game/card/CardState:5319:32:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",37);}
case 37:{return rt.Call(f,"java/util/function/Predicate","not","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",40);}
case 40:{return rt.Call(f,"forge/util/collect/FCollection","removeIf","(Ljava/util/function/Predicate;)Z","invokevirtual",43);}
case 43:{f.StackOp("pop");f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5320(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardState","updateSpellAbilities","(Lforge/util/collect/FCollection;)V","invokevirtual",13);}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","updateSpellAbilities","(Ljava/util/List;Lforge/game/card/CardState;)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.DynamicCall(f,"forge/game/card/CardState:5320:32:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",37);}
case 37:{return rt.Call(f,"forge/util/collect/FCollection","removeIf","(Ljava/util/function/Predicate;)Z","invokevirtual",40);}
case 40:{f.StackOp("pop");f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5321(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?89:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",17);}
case 17:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?51:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",30);}
case 30:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",36);}
case 36:{f.Locals[2]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/CardState","updateSpellAbilities","(Lforge/util/collect/FCollection;)V","invokevirtual",51);}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",55);}
case 55:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?89:64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",68);}
case 68:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",74);}
case 74:{f.Locals[2]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;"));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/card/CardState","updateSpellAbilities","(Lforge/util/collect/FCollection;)V","invokevirtual",89);}
case 89:{if(!rt.StaticReady(f,"forge/game/card/CardState$1","$SwitchMap$forge$card$CardStateName","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardState$1","$SwitchMap$forge$card$CardStateName","[I"));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",96);}
case 96:{return rt.Call(f,"forge/card/CardStateName","ordinal","()I","invokevirtual",99);}
case 99:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=100;continue;}
case 100:{switch(f.Pop().Int){case 1:f.Pc=152;break;case 2:f.Pc=163;break;case 3:f.Pc=163;break;case 4:f.Pc=163;break;case 5:f.Pc=163;break;case 6:f.Pc=163;break;case 7:f.Pc=163;break;case 8:f.Pc=163;break;case 9:f.Pc=163;break;default:f.Pc=166;break;}continue;}
case 152:{f.Push(f.Locals[0]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",156);}
case 156:{return rt.Call(f,"forge/game/card/Card","isModal","()Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int!=0?167:162;continue;}
case 162:{return JStep.ReturnVoid;}
case 163:{f.Pc=167;continue;}
case 166:{return JStep.ReturnVoid;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",171);}
case 171:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int==0?207:180;continue;}
case 180:{f.Push(f.Locals[0]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",184);}
case 184:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",190);}
case 190:{f.Pc=f.Pop().Int!=0?206:193;continue;}
case 193:{f.Push(f.Locals[0]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",197);}
case 197:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",203);}
case 203:{f.Pc=f.Pop().Int==0?207:206;continue;}
case 206:{return JStep.ReturnVoid;}
case 207:{f.Push(f.Locals[0]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/card/CardState","getTypeWithChanges","()Lforge/card/CardTypeView;","invokevirtual",211);}
case 211:{f.Locals[2]=f.Pop();f.Pc=212;continue;}
case 212:{f.Push(f.Locals[2]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/card/CardTypeView","isLand","()Z","invokeinterface",218);}
case 218:{f.Pc=f.Pop().Int==0?256:221;continue;}
case 221:{f.Push(f.Locals[0]);f.Pc=222;continue;}
case 222:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","landAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=225;continue;}
case 225:{f.Pc=f.Pop().Reference!=null?244:228;continue;}
case 228:{f.Push(f.Locals[0]);f.Pc=229;continue;}
case 229:{if(!rt.EnsureInitialized(f,"forge/game/spellability/LandAbility"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/LandAbility")));f.Pc=232;continue;}
case 232:{f.StackOp("dup");f.Pc=233;continue;}
case 233:{f.Push(f.Locals[0]);f.Pc=234;continue;}
case 234:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=237;continue;}
case 237:{f.Push(f.Locals[0]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/spellability/LandAbility","<init>","(Lforge/game/card/Card;Lforge/game/card/CardState;)V","invokespecial",241);}
case 241:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","landAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{f.Push(f.Locals[0]);f.Pc=246;continue;}
case 246:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","landAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",252);}
case 252:{f.StackOp("pop");f.Pc=253;continue;}
case 253:{f.Pc=334;continue;}
case 256:{f.Push(f.Locals[2]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/card/CardTypeView","isAura","()Z","invokeinterface",262);}
case 262:{f.Pc=f.Pop().Int==0?277:265;continue;}
case 265:{f.Push(f.Locals[1]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[0]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/card/CardState","getAuraSpell","()Lforge/game/spellability/SpellAbility;","invokevirtual",270);}
case 270:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",273);}
case 273:{f.StackOp("pop");f.Pc=274;continue;}
case 274:{f.Pc=334;continue;}
case 277:{f.Push(f.Locals[2]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/card/CardTypeView","isPermanent","()Z","invokeinterface",283);}
case 283:{f.Pc=f.Pop().Int==0?334:286;continue;}
case 286:{f.Push(f.Locals[0]);f.Pc=287;continue;}
case 287:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;"));f.Pc=290;continue;}
case 290:{return rt.DynamicCall(f,"forge/game/card/CardState:5321:290:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",295);}
case 295:{return rt.Call(f,"forge/util/collect/FCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",298);}
case 298:{f.Pc=f.Pop().Int==0?302:301;continue;}
case 301:{return JStep.ReturnVoid;}
case 302:{f.Push(f.Locals[0]);f.Pc=303;continue;}
case 303:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","permanentAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=306;continue;}
case 306:{f.Pc=f.Pop().Reference!=null?325:309;continue;}
case 309:{f.Push(f.Locals[0]);f.Pc=310;continue;}
case 310:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellPermanent"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellPermanent")));f.Pc=313;continue;}
case 313:{f.StackOp("dup");f.Pc=314;continue;}
case 314:{f.Push(f.Locals[0]);f.Pc=315;continue;}
case 315:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=318;continue;}
case 318:{f.Push(f.Locals[0]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/spellability/SpellPermanent","<init>","(Lforge/game/card/Card;Lforge/game/card/CardState;)V","invokespecial",322);}
case 322:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","permanentAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[1]);f.Pc=326;continue;}
case 326:{f.Push(f.Locals[0]);f.Pc=327;continue;}
case 327:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","permanentAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",333);}
case 333:{f.StackOp("pop");f.Pc=334;continue;}
case 334:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5322(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","landManaAbilities","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/game/card/CardState:5322:6:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CardState;)Ljava/util/function/Function;",11);}
case 11:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5323(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","landTraitChanges","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5324(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/game/card/CardState:5324:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",9);}
case 9:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5325(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getIntrinsicSpellAbilities","()Ljava/lang/Iterable;","invokevirtual",4);}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5326(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Reference==null?18:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",17);}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardState","getNonManaAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",22);}
case 22:{f.Push(JValue.R(null));f.Pc=23;continue;}
case 23:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5327(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardState","getTypeWithChanges","()Lforge/card/CardTypeView;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference!=null?23:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardTypeView","isLand","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?25:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/card/CardTypeView","isAura","()Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?39:34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/CardState","getAuraSpell","()Lforge/game/spellability/SpellAbility;","invokevirtual",38);}
case 38:{return JStep.Return(f.Pop());}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","permanentAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=43;continue;}
case 43:{f.Pc=f.Pop().Reference!=null?62:46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellPermanent"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellPermanent")));f.Pc=50;continue;}
case 50:{f.StackOp("dup");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellPermanent","<init>","(Lforge/game/card/Card;Lforge/game/card/CardState;)V","invokespecial",59);}
case 59:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","permanentAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","permanentAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=66;continue;}
case 66:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5328(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getTypeWithChanges","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardTypeView","isAura","()Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int!=0?16:14;continue;}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","auraAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference!=null?188:23;continue;}
case 23:{f.Push(JValue.R(rt.String("")));f.Pc=25;continue;}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("")));f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","ENCHANT","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","ENCHANT","Lforge/game/keyword/Keyword;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/CardState","getCachedKeyword","(Lforge/game/keyword/Keyword;)Ljava/util/Collection;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",41);}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",50);}
case 50:{f.Pc=f.Pop().Int==0?89:53;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",60);}
case 60:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=63;continue;}
case 63:{f.Locals[5]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/KeywordWithType")?1:0));f.Pc=70;continue;}
case 70:{f.Pc=f.Pop().Int==0?86:73;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordWithType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{f.Locals[6]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/keyword/KeywordWithType","getTypeDescription","()Ljava/lang/String;","invokevirtual",85);}
case 85:{f.Locals[2]=f.Pop();f.Pc=86;continue;}
case 86:{f.Pc=89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("AttachAITgts")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/CardState","hasSVar","(Ljava/lang/String;)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?113:99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("AttachAITgts")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",107);}
case 107:{return rt.DynamicCall(f,"forge/game/card/CardState:5328:107:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",112);}
case 112:{f.Locals[3]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("AttachAILogic")));f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/CardState","hasSVar","(Ljava/lang/String;)Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?137:123;continue;}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("AttachAILogic")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",131);}
case 131:{return rt.DynamicCall(f,"forge/game/card/CardState:5328:131:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",136);}
case 136:{f.Locals[3]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("AttachAIValid")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/card/CardState","hasSVar","(Ljava/lang/String;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int==0?161:147;continue;}
case 147:{f.Push(f.Locals[3]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("AttachAIValid")));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",155);}
case 155:{return rt.DynamicCall(f,"forge/game/card/CardState:5328:155:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",160);}
case 160:{f.Locals[3]=f.Pop();f.Pc=161;continue;}
case 161:{f.Push(f.Locals[2]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[3]);f.Pc=163;continue;}
case 163:{return rt.DynamicCall(f,"forge/game/card/CardState:5328:163:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",168);}
case 168:{f.Locals[4]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[4]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",177);}
case 177:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","auraAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[0]);f.Pc=181;continue;}
case 181:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","auraAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=184;continue;}
case 184:{f.Push(JValue.I(1));f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",188);}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","auraAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=192;continue;}
case 192:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5329(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5330(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?42:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getId","()I","invokevirtual",34);}
case 34:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?39:37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 39:{f.Pc=10;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5331(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5332(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","triggers","Lforge/util/collect/FCollection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",16);}
case 16:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?87:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",29);}
case 29:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?56:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",43);}
case 43:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",49);}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","triggers","Lforge/util/collect/FCollection;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",60);}
case 60:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?87:69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",74);}
case 74:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",80);}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","triggers","Lforge/util/collect/FCollection;"));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/Card","updateTriggers","(Ljava/util/List;Lforge/game/card/CardState;)V","invokevirtual",96);}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5333(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5334(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?42:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/trigger/Trigger","getId","()I","invokevirtual",34);}
case 34:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?39:37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 39:{f.Pc=10;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5335(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","triggers","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5336(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","getChangedCardTraits","()Lcom/google/common/collect/Table;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/util/collect/FSnapshotTable","versionOf","(Lcom/google/common/collect/Table;)Ljava/lang/Object;","invokestatic",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","getChangedCardTraitsByText","()Lcom/google/common/collect/Table;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/util/collect/FSnapshotTable","versionOf","(Lcom/google/common/collect/Table;)Ljava/lang/Object;","invokestatic",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Reference==null?30:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Reference!=null?35:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/CardState","buildStaticAbilities","()Lforge/util/collect/FCollection;","invokevirtual",34);}
case 34:{return JStep.Return(f.Pop());}
case 35:{f.Push(JValue.R(null));f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(JValue.R(null));f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",44);}
case 44:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?102:53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",57);}
case 57:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?77:66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",70);}
case 70:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",76);}
case 76:{f.Locals[3]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",81);}
case 81:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int==0?102:90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",94);}
case 94:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",100);}
case 100:{f.Locals[4]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{f.Pc=f.Pop().Reference!=null?110:106;continue;}
case 106:{f.Push(JValue.I(-1));f.Pc=107;continue;}
case 107:{f.Pc=114;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/CardState","staticAbilitiesStamp","()I","invokevirtual",114);}
case 114:{f.Locals[5]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{f.Pc=f.Pop().Reference!=null?125:121;continue;}
case 121:{f.Push(JValue.I(-1));f.Pc=122;continue;}
case 122:{f.Pc=130;continue;}
case 125:{f.Push(f.Locals[4]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/card/CardState","staticAbilitiesStamp","()I","invokevirtual",130);}
case 130:{f.Locals[6]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/card/CardState","staticAbilitiesStamp","()I","invokevirtual",136);}
case 136:{f.Locals[7]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/card/Card","hasRemoveIntrinsic","()Z","invokevirtual",145);}
case 145:{f.Locals[8]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","cachedKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=151;continue;}
case 151:{f.Locals[9]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticCache","Lforge/game/card/CardState$StaticAbilitiesCache;"));f.Pc=157;continue;}
case 157:{f.Locals[10]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[10]);f.Pc=161;continue;}
case 161:{f.Pc=f.Pop().Reference==null?241:164;continue;}
case 164:{f.Push(f.Locals[10]);f.Pc=166;continue;}
case 166:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$StaticAbilitiesCache","traits","Ljava/lang/Object;"));f.Pc=169;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?241:173;continue;}
case 173:{f.Push(f.Locals[10]);f.Pc=175;continue;}
case 175:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$StaticAbilitiesCache","traitsByText","Ljava/lang/Object;"));f.Pc=178;continue;}
case 178:{f.Push(f.Locals[2]);f.Pc=179;continue;}
case 179:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?241:182;continue;}
case 182:{f.Push(f.Locals[10]);f.Pc=184;continue;}
case 184:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$StaticAbilitiesCache","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=187;continue;}
case 187:{f.Push(f.Locals[9]);f.Pc=189;continue;}
case 189:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?241:192;continue;}
case 192:{f.Push(f.Locals[10]);f.Pc=194;continue;}
case 194:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$StaticAbilitiesCache","removeIntrinsic","Z"));f.Pc=197;continue;}
case 197:{f.Push(f.Locals[8]);f.Pc=199;continue;}
case 199:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?241:202;continue;}
case 202:{f.Push(f.Locals[10]);f.Pc=204;continue;}
case 204:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$StaticAbilitiesCache","ownVersion","I"));f.Pc=207;continue;}
case 207:{f.Push(f.Locals[7]);f.Pc=209;continue;}
case 209:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?241:212;continue;}
case 212:{f.Push(f.Locals[10]);f.Pc=214;continue;}
case 214:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$StaticAbilitiesCache","leftVersion","I"));f.Pc=217;continue;}
case 217:{f.Push(f.Locals[5]);f.Pc=219;continue;}
case 219:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?241:222;continue;}
case 222:{f.Push(f.Locals[10]);f.Pc=224;continue;}
case 224:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$StaticAbilitiesCache","rightVersion","I"));f.Pc=227;continue;}
case 227:{f.Push(f.Locals[6]);f.Pc=229;continue;}
case 229:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?241:232;continue;}
case 232:{f.Push(f.Locals[10]);f.Pc=234;continue;}
case 234:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$StaticAbilitiesCache","value","Lforge/util/collect/FCollection;"));f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/util/collect/FCollection","shareCopy","()Lforge/util/collect/FCollection;","invokevirtual",240);}
case 240:{return JStep.Return(f.Pop());}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/card/CardState","buildStaticAbilities","()Lforge/util/collect/FCollection;","invokevirtual",245);}
case 245:{f.Locals[11]=f.Pop();f.Pc=247;continue;}
case 247:{f.Push(f.Locals[0]);f.Pc=248;continue;}
case 248:{if(!rt.EnsureInitialized(f,"forge/game/card/CardState$StaticAbilitiesCache"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardState$StaticAbilitiesCache")));f.Pc=251;continue;}
case 251:{f.StackOp("dup");f.Pc=252;continue;}
case 252:{f.Push(f.Locals[11]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[1]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[2]);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[9]);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[8]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[7]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[5]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[6]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/game/card/CardState$StaticAbilitiesCache","<init>","(Lforge/util/collect/FCollection;Ljava/lang/Object;Ljava/lang/Object;Lforge/game/keyword/KeywordCollection;ZIII)V","invokespecial",269);}
case 269:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","staticCache","Lforge/game/card/CardState$StaticAbilitiesCache;",value);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[11]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/util/collect/FCollection","shareCopy","()Lforge/util/collect/FCollection;","invokevirtual",277);}
case 277:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5337(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilitiesVersion","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilities","Lforge/util/collect/FCollection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/collect/FCollection","version","()I","invokevirtual",11);}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5338(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilities","Lforge/util/collect/FCollection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",16);}
case 16:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?87:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",29);}
case 29:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?56:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",43);}
case 43:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",49);}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilities","Lforge/util/collect/FCollection;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",60);}
case 60:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?87:69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",74);}
case 74:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",80);}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilities","Lforge/util/collect/FCollection;"));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/Card","updateStaticAbilities","(Ljava/util/List;Lforge/game/card/CardState;)V","invokevirtual",96);}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5339(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilities","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilitiesVersion","I"));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","staticAbilitiesVersion","I",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5340(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilities","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilitiesVersion","I"));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","staticAbilitiesVersion","I",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5341(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardState","getReplacementEffects","(Z)Lforge/util/collect/FCollectionView;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5342(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","getChangedCardTraits","()Lcom/google/common/collect/Table;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/util/collect/FSnapshotTable","versionOf","(Lcom/google/common/collect/Table;)Ljava/lang/Object;","invokestatic",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","getChangedCardTraitsByText","()Lcom/google/common/collect/Table;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/util/collect/FSnapshotTable","versionOf","(Lcom/google/common/collect/Table;)Ljava/lang/Object;","invokestatic",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Reference==null?30:26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Reference!=null?36:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/CardState","buildReplacementEffects","(Z)Lforge/util/collect/FCollection;","invokevirtual",35);}
case 35:{return JStep.Return(f.Pop());}
case 36:{f.Push(JValue.R(null));f.Pc=37;continue;}
case 37:{f.Locals[4]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(JValue.R(null));f.Pc=40;continue;}
case 40:{f.Locals[5]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",46);}
case 46:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?105:55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",59);}
case 59:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?80:68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",72);}
case 72:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",78);}
case 78:{f.Locals[4]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",84);}
case 84:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?105:93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",97);}
case 97:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",103);}
case 103:{f.Locals[5]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[4]);f.Pc=107;continue;}
case 107:{f.Pc=f.Pop().Reference!=null?114:110;continue;}
case 110:{f.Push(JValue.I(-1));f.Pc=111;continue;}
case 111:{f.Pc=119;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/CardState","replacementEffectsStamp","()I","invokevirtual",119);}
case 119:{f.Locals[6]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{f.Pc=f.Pop().Reference!=null?130:126;continue;}
case 126:{f.Push(JValue.I(-1));f.Pc=127;continue;}
case 127:{f.Pc=135;continue;}
case 130:{f.Push(f.Locals[5]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/card/CardState","replacementEffectsStamp","()I","invokevirtual",135);}
case 135:{f.Locals[7]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/card/CardState","replacementEffectsStamp","()I","invokevirtual",141);}
case 141:{f.Locals[8]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[0]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/card/CardState","replacementFlags","(Z)I","invokevirtual",148);}
case 148:{f.Locals[9]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","cachedKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=154;continue;}
case 154:{f.Locals[10]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{f.Pc=f.Pop().Int==0?167:160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementCacheRules","Lforge/game/card/CardState$ReplacementEffectsCache;"));f.Pc=164;continue;}
case 164:{f.Pc=171;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementCacheNoRules","Lforge/game/card/CardState$ReplacementEffectsCache;"));f.Pc=171;continue;}
case 171:{f.Locals[11]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[11]);f.Pc=175;continue;}
case 175:{f.Pc=f.Pop().Reference==null?255:178;continue;}
case 178:{f.Push(f.Locals[11]);f.Pc=180;continue;}
case 180:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","traits","Ljava/lang/Object;"));f.Pc=183;continue;}
case 183:{f.Push(f.Locals[2]);f.Pc=184;continue;}
case 184:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?255:187;continue;}
case 187:{f.Push(f.Locals[11]);f.Pc=189;continue;}
case 189:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","traitsByText","Ljava/lang/Object;"));f.Pc=192;continue;}
case 192:{f.Push(f.Locals[3]);f.Pc=193;continue;}
case 193:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?255:196;continue;}
case 196:{f.Push(f.Locals[11]);f.Pc=198;continue;}
case 198:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=201;continue;}
case 201:{f.Push(f.Locals[10]);f.Pc=203;continue;}
case 203:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?255:206;continue;}
case 206:{f.Push(f.Locals[11]);f.Pc=208;continue;}
case 208:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","flags","I"));f.Pc=211;continue;}
case 211:{f.Push(f.Locals[9]);f.Pc=213;continue;}
case 213:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?255:216;continue;}
case 216:{f.Push(f.Locals[11]);f.Pc=218;continue;}
case 218:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","ownVersion","I"));f.Pc=221;continue;}
case 221:{f.Push(f.Locals[8]);f.Pc=223;continue;}
case 223:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?255:226;continue;}
case 226:{f.Push(f.Locals[11]);f.Pc=228;continue;}
case 228:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","leftVersion","I"));f.Pc=231;continue;}
case 231:{f.Push(f.Locals[6]);f.Pc=233;continue;}
case 233:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?255:236;continue;}
case 236:{f.Push(f.Locals[11]);f.Pc=238;continue;}
case 238:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","rightVersion","I"));f.Pc=241;continue;}
case 241:{f.Push(f.Locals[7]);f.Pc=243;continue;}
case 243:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?255:246;continue;}
case 246:{f.Push(f.Locals[11]);f.Pc=248;continue;}
case 248:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","value","Lforge/util/collect/FCollection;"));f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/util/collect/FCollection","shareCopy","()Lforge/util/collect/FCollection;","invokevirtual",254);}
case 254:{return JStep.Return(f.Pop());}
case 255:{f.Push(f.Locals[0]);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[1]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/card/CardState","buildReplacementEffects","(Z)Lforge/util/collect/FCollection;","invokevirtual",260);}
case 260:{f.Locals[12]=f.Pop();f.Pc=262;continue;}
case 262:{if(!rt.EnsureInitialized(f,"forge/game/card/CardState$ReplacementEffectsCache"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardState$ReplacementEffectsCache")));f.Pc=265;continue;}
case 265:{f.StackOp("dup");f.Pc=266;continue;}
case 266:{f.Push(f.Locals[12]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[2]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[3]);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[10]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[9]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[8]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[6]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[7]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/card/CardState$ReplacementEffectsCache","<init>","(Lforge/util/collect/FCollection;Ljava/lang/Object;Ljava/lang/Object;Lforge/game/keyword/KeywordCollection;IIII)V","invokespecial",283);}
case 283:{f.Locals[13]=f.Pop();f.Pc=285;continue;}
case 285:{f.Push(f.Locals[1]);f.Pc=286;continue;}
case 286:{f.Pc=f.Pop().Int==0?298:289;continue;}
case 289:{f.Push(f.Locals[0]);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[13]);f.Pc=292;continue;}
case 292:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","replacementCacheRules","Lforge/game/card/CardState$ReplacementEffectsCache;",value);f.Pc=295;continue;}
case 295:{f.Pc=304;continue;}
case 298:{f.Push(f.Locals[0]);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[13]);f.Pc=301;continue;}
case 301:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","replacementCacheNoRules","Lforge/game/card/CardState$ReplacementEffectsCache;",value);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[12]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/util/collect/FCollection","shareCopy","()Lforge/util/collect/FCollection;","invokevirtual",309);}
case 309:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5343(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffectsVersion","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffects","Lforge/util/collect/FCollection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/collect/FCollection","version","()I","invokevirtual",11);}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5344(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","hasRemoveIntrinsic","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/CardState","getTypeWithChanges","()Lforge/card/CardTypeView;","invokevirtual",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/card/CardTypeView","isPlaneswalker","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?34:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(2));f.Pc=32;continue;}
case 32:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=33;continue;}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/card/CardTypeView","isBattle","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?47:43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(4));f.Pc=45;continue;}
case 45:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=46;continue;}
case 46:{f.Locals[2]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/CardTypeView","isSaga","()Z","invokeinterface",53);}
case 53:{f.Pc=f.Pop().Int==0?61:56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(8));f.Pc=59;continue;}
case 59:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=60;continue;}
case 60:{f.Locals[2]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Pc=f.Pop().Int==0?157:65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("Adventure")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int==0?83:78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Push(JValue.I(16));f.Pc=81;continue;}
case 81:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=82;continue;}
case 82:{f.Locals[2]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("Omen")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?101:96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{f.Push(JValue.I(32));f.Pc=99;continue;}
case 99:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=100;continue;}
case 100:{f.Locals[2]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=105;continue;}
case 105:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","SHIELD","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","SHIELD","Lforge/game/card/CounterEnumType;"));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int<=0?119:114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{f.Push(JValue.I(64));f.Pc=117;continue;}
case 117:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=118;continue;}
case 118:{f.Locals[2]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=123;continue;}
case 123:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","STUN","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","STUN","Lforge/game/card/CounterEnumType;"));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",129);}
case 129:{f.Pc=f.Pop().Int<=0?138:132;continue;}
case 132:{f.Push(f.Locals[2]);f.Pc=133;continue;}
case 133:{f.Push(JValue.I(128));f.Pc=136;continue;}
case 136:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=137;continue;}
case 137:{f.Locals[2]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","FINALITY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","FINALITY","Lforge/game/card/CounterEnumType;"));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Int<=0?157:151;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{f.Push(JValue.I(256));f.Pc=155;continue;}
case 155:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=156;continue;}
case 156:{f.Locals[2]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[2]);f.Pc=158;continue;}
case 158:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5345(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffects","Lforge/util/collect/FCollection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",16);}
case 16:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?87:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",29);}
case 29:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?56:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",43);}
case 43:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",49);}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffects","Lforge/util/collect/FCollection;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",60);}
case 60:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?87:69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",74);}
case 74:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",80);}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffects","Lforge/util/collect/FCollection;"));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/Card","updateReplacementEffects","(Ljava/util/List;Lforge/game/card/CardState;Z)V","invokevirtual",97);}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Pc=f.Pop().Int!=0?103:101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{return JStep.Return(f.Pop());}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("Adventure")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?140:116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","adventureRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=120;continue;}
case 120:{f.Pc=f.Pop().Reference!=null?131:123;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/CardFactoryUtil","setupAdventureAbility","(Lforge/game/card/CardState;)Lforge/game/replacement/ReplacementEffect;","invokestatic",128);}
case 128:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","adventureRep","Lforge/game/replacement/ReplacementEffect;",value);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","adventureRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",139);}
case 139:{f.StackOp("pop");f.Pc=140;continue;}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("Omen")));f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?177:153;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","omenRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=157;continue;}
case 157:{f.Pc=f.Pop().Reference!=null?168:160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/CardFactoryUtil","setupOmenAbility","(Lforge/game/card/CardState;)Lforge/game/replacement/ReplacementEffect;","invokestatic",165);}
case 165:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","omenRep","Lforge/game/replacement/ReplacementEffect;",value);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[2]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[0]);f.Pc=170;continue;}
case 170:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","omenRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",176);}
case 176:{f.StackOp("pop");f.Pc=177;continue;}
case 177:{f.Push(f.Locals[0]);f.Pc=178;continue;}
case 178:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("Vengeance")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",187);}
case 187:{f.Pc=f.Pop().Int==0?214:190;continue;}
case 190:{f.Push(f.Locals[0]);f.Pc=191;continue;}
case 191:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","vengeanceRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=194;continue;}
case 194:{f.Pc=f.Pop().Reference!=null?205:197;continue;}
case 197:{f.Push(f.Locals[0]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[0]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/card/CardFactoryUtil","setupVengeanceAbility","(Lforge/game/card/CardState;)Lforge/game/replacement/ReplacementEffect;","invokestatic",202);}
case 202:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","vengeanceRep","Lforge/game/replacement/ReplacementEffect;",value);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[2]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[0]);f.Pc=207;continue;}
case 207:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","vengeanceRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",213);}
case 213:{f.StackOp("pop");f.Pc=214;continue;}
case 214:{f.Push(f.Locals[2]);f.Pc=215;continue;}
case 215:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5346(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffects","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffectsVersion","I"));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","replacementEffectsVersion","I",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5347(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getReplacementEffects","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/collect/FCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5348(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardState","getReplacementEffect","(I)Lforge/game/replacement/ReplacementEffect;","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Reference==null?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5349(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getReplacementEffects","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?42:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getId","()I","invokevirtual",34);}
case 34:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?39:37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
case 39:{f.Pc=10;continue;}
case 42:{f.Push(JValue.R(null));f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5350(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","loyaltyRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?25:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","baseLoyalty","Ljava/lang/String;"));f.Pc=12;continue;}
case 12:{return rt.DynamicCall(f,"forge/game/card/CardState:5350:12:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardFactoryUtil","makeEtbCounter","(Ljava/lang/String;Lforge/game/card/CardState;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",22);}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","loyaltyRep","Lforge/game/replacement/ReplacementEffect;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","loyaltyRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5351(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","defenseRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?25:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","baseDefense","Ljava/lang/String;"));f.Pc=12;continue;}
case 12:{return rt.DynamicCall(f,"forge/game/card/CardState:5351:12:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardFactoryUtil","makeEtbCounter","(Ljava/lang/String;Lforge/game/card/CardState;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",22);}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","defenseRep","Lforge/game/replacement/ReplacementEffect;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","defenseRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5352(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","sagaRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?19:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("etbCounter:LORE:1")));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardFactoryUtil","makeEtbCounter","(Ljava/lang/String;Lforge/game/card/CardState;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","sagaRep","Lforge/game/replacement/ReplacementEffect;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","sagaRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5353(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","sVars","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5354(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","sVars","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?27:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","sVars","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
case 27:{f.Push(JValue.R(rt.String("")));f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5355(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","sVars","Ljava/util/Map;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5356(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","sVars","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateFoilIndex","(Lforge/game/card/CardState;)V","invokevirtual",29);}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5357(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/Maps","newTreeMap","()Ljava/util/TreeMap;","invokestatic",4);}
case 4:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","sVars","Ljava/util/Map;",value);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","sVars","Ljava/util/Map;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateFoilIndex","(Lforge/game/card/CardState;)V","invokevirtual",34);}
case 34:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5358(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","sVars","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5359(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Foil")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int!=0?20:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",19);}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5360(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;ZLforge/game/CardTraitBase;)V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5361(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/card/CardState","setName","(Ljava/lang/String;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","type","Lforge/card/CardType;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardState","setType","(Lforge/card/CardType;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/card/CardState","setManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CardState","getColor","()Lforge/card/ColorSet;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/card/CardState","setColor","(Lforge/card/ColorSet;)V","invokevirtual",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/CardState","getOracleText","()Ljava/lang/String;","invokevirtual",37);}
case 37:{return rt.Call(f,"forge/game/card/CardState","setOracleText","(Ljava/lang/String;)V","invokevirtual",40);}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/CardState","getFunctionalVariantName","()Ljava/lang/String;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/card/CardState","setFunctionalVariantName","(Ljava/lang/String;)V","invokevirtual",48);}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/CardState","getBasePower","()I","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/game/card/CardState","setBasePower","(I)V","invokevirtual",56);}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/CardState","getBaseToughness","()I","invokevirtual",61);}
case 61:{return rt.Call(f,"forge/game/card/CardState","setBaseToughness","(I)V","invokevirtual",64);}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/CardState","getBasePowerString","()Ljava/lang/String;","invokevirtual",69);}
case 69:{return rt.Call(f,"forge/game/card/CardState","setBasePowerString","(Ljava/lang/String;)V","invokevirtual",72);}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/CardState","getBaseToughnessString","()Ljava/lang/String;","invokevirtual",77);}
case 77:{return rt.Call(f,"forge/game/card/CardState","setBaseToughnessString","(Ljava/lang/String;)V","invokevirtual",80);}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/CardState","getBaseLoyalty","()Ljava/lang/String;","invokevirtual",85);}
case 85:{return rt.Call(f,"forge/game/card/CardState","setBaseLoyalty","(Ljava/lang/String;)V","invokevirtual",88);}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/CardState","getBaseDefense","()Ljava/lang/String;","invokevirtual",93);}
case 93:{return rt.Call(f,"forge/game/card/CardState","setBaseDefense","(Ljava/lang/String;)V","invokevirtual",96);}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/CardState","getAttractionLights","()Ljava/util/Set;","invokevirtual",101);}
case 101:{return rt.Call(f,"forge/game/card/CardState","setAttractionLights","(Ljava/util/Set;)V","invokevirtual",104);}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/card/CardState","getFlavorName","()Ljava/lang/String;","invokevirtual",109);}
case 109:{return rt.Call(f,"forge/game/card/CardState","setFlavorName","(Ljava/lang/String;)V","invokevirtual",112);}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/card/CardState","getSVars","()Ljava/util/Map;","invokevirtual",117);}
case 117:{return rt.Call(f,"forge/game/card/CardState","setSVars","(Ljava/util/Map;)V","invokevirtual",120);}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilityForTrigger","Ljava/util/Map;"));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",129);}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilityForTrigger","Ljava/util/Map;"));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",138);}
case 138:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",143);}
case 143:{f.Locals[4]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[4]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",152);}
case 152:{f.Pc=f.Pop().Int==0?208:155;continue;}
case 155:{f.Push(f.Locals[4]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",162);}
case 162:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=165;continue;}
case 165:{f.Locals[5]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilityForTrigger","Ljava/util/Map;"));f.Pc=171;continue;}
case 171:{f.Push(f.Locals[5]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",178);}
case 178:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[5]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",188);}
case 188:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[0]);f.Pc=192;continue;}
case 192:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=195;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",199);}
case 199:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",204);}
case 204:{f.StackOp("pop");f.Pc=205;continue;}
case 205:{f.Pc=145;continue;}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;"));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/util/collect/FCollection","clear","()V","invokevirtual",215);}
case 215:{f.Push(f.Locals[1]);f.Pc=216;continue;}
case 216:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;"));f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",222);}
case 222:{f.Locals[4]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[4]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",231);}
case 231:{f.Pc=f.Pop().Int==0?275:234;continue;}
case 234:{f.Push(f.Locals[4]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",241);}
case 241:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=244;continue;}
case 244:{f.Locals[5]=f.Pop();f.Pc=246;continue;}
case 246:{f.Push(f.Locals[5]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",251);}
case 251:{f.Pc=f.Pop().Int==0?272:254;continue;}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;"));f.Pc=258;continue;}
case 258:{f.Push(f.Locals[5]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[0]);f.Pc=261;continue;}
case 261:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=264;continue;}
case 264:{f.Push(f.Locals[2]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",268);}
case 268:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",271);}
case 271:{f.StackOp("pop");f.Pc=272;continue;}
case 272:{f.Pc=224;continue;}
case 275:{f.Push(f.Locals[0]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[1]);f.Pc=277;continue;}
case 277:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","intrinsicKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/keyword/KeywordCollection","getValues","()Ljava/util/Collection;","invokevirtual",283);}
case 283:{f.Push(f.Locals[2]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/card/CardState","setIntrinsicKeywords","(Ljava/lang/Iterable;Z)V","invokevirtual",287);}
case 287:{f.Push(f.Locals[0]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[1]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/card/CardState","getImageKey","()Ljava/lang/String;","invokevirtual",292);}
case 292:{return rt.Call(f,"forge/game/card/CardState","setImageKey","(Ljava/lang/String;)V","invokevirtual",295);}
case 295:{f.Push(f.Locals[0]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[1]);f.Pc=297;continue;}
case 297:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","rarity","Lforge/card/CardRarity;"));f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/card/CardState","setRarity","(Lforge/card/CardRarity;)V","invokevirtual",303);}
case 303:{f.Push(f.Locals[0]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","setCode","Ljava/lang/String;"));f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/card/CardState","setSetCode","(Ljava/lang/String;)V","invokevirtual",311);}
case 311:{f.Push(JValue.R(null));f.Pc=312;continue;}
case 312:{f.Locals[4]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[3]);f.Pc=315;continue;}
case 315:{f.Pc=f.Pop().Reference==null?352:318;continue;}
case 318:{f.Push(f.Locals[3]);f.Pc=319;continue;}
case 319:{f.Push(JValue.R(rt.String("DoesntHaveThisAbility")));f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/CardTraitBase","hasParam","(Ljava/lang/String;)Z","invokevirtual",325);}
case 325:{f.Pc=f.Pop().Int==0?352:328;continue;}
case 328:{f.Push(f.Locals[3]);f.Pc=329;continue;}
case 329:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",335);}
case 335:{f.Locals[5]=f.Pop();f.Pc=337;continue;}
case 337:{f.Push(f.Locals[5]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",342);}
case 342:{f.Pc=f.Pop().Int==0?352:345;continue;}
case 345:{f.Push(f.Locals[5]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",350);}
case 350:{f.Locals[4]=f.Pop();f.Pc=352;continue;}
case 352:{f.Push(f.Locals[0]);f.Pc=353;continue;}
case 353:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","triggers","Lforge/util/collect/FCollection;"));f.Pc=356;continue;}
case 356:{return rt.Call(f,"forge/util/collect/FCollection","clear","()V","invokevirtual",359);}
case 359:{f.Push(f.Locals[1]);f.Pc=360;continue;}
case 360:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","triggers","Lforge/util/collect/FCollection;"));f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",366);}
case 366:{f.Locals[5]=f.Pop();f.Pc=368;continue;}
case 368:{f.Push(f.Locals[5]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",375);}
case 375:{f.Pc=f.Pop().Int==0?468:378;continue;}
case 378:{f.Push(f.Locals[5]);f.Pc=380;continue;}
case 380:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",385);}
case 385:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=388;continue;}
case 388:{f.Locals[6]=f.Pop();f.Pc=390;continue;}
case 390:{f.Push(f.Locals[6]);f.Pc=392;continue;}
case 392:{f.Push(f.Locals[4]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/game/trigger/Trigger","equals","(Ljava/lang/Object;)Z","invokevirtual",397);}
case 397:{f.Pc=f.Pop().Int==0?403:400;continue;}
case 400:{f.Pc=368;continue;}
case 403:{f.Push(f.Locals[6]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/trigger/Trigger","isIntrinsic","()Z","invokevirtual",408);}
case 408:{f.Pc=f.Pop().Int==0?465:411;continue;}
case 411:{f.Push(f.Locals[0]);f.Pc=412;continue;}
case 412:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","triggers","Lforge/util/collect/FCollection;"));f.Pc=415;continue;}
case 415:{f.Push(f.Locals[6]);f.Pc=417;continue;}
case 417:{f.Push(f.Locals[0]);f.Pc=418;continue;}
case 418:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=421;continue;}
case 421:{f.Push(f.Locals[2]);f.Pc=422;continue;}
case 422:{f.Push(JValue.I(0));f.Pc=423;continue;}
case 423:{f.Push(f.Locals[6]);f.Pc=425;continue;}
case 425:{f.Push(JValue.R(rt.String("Execute")));f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",431);}
case 431:{f.Pc=f.Pop().Int==0?457:434;continue;}
case 434:{f.Push(f.Locals[0]);f.Pc=435;continue;}
case 435:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilityForTrigger","Ljava/util/Map;"));f.Pc=438;continue;}
case 438:{f.Push(f.Locals[6]);f.Pc=440;continue;}
case 440:{f.Push(JValue.R(rt.String("Execute")));f.Pc=443;continue;}
case 443:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",446);}
case 446:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",451);}
case 451:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=454;continue;}
case 454:{f.Pc=458;continue;}
case 457:{f.Push(JValue.R(null));f.Pc=458;continue;}
case 458:{return rt.Call(f,"forge/game/trigger/Trigger","copy","(Lforge/game/card/Card;ZZLforge/game/spellability/SpellAbility;)Lforge/game/trigger/Trigger;","invokevirtual",461);}
case 461:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",464);}
case 464:{f.StackOp("pop");f.Pc=465;continue;}
case 465:{f.Pc=368;continue;}
case 468:{f.Push(JValue.R(null));f.Pc=469;continue;}
case 469:{f.Locals[5]=f.Pop();f.Pc=471;continue;}
case 471:{f.Push(f.Locals[3]);f.Pc=472;continue;}
case 472:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=475;continue;}
case 475:{f.Pc=f.Pop().Int==0?513:478;continue;}
case 478:{f.Push(f.Locals[3]);f.Pc=479;continue;}
case 479:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=482;continue;}
case 482:{f.Locals[6]=f.Pop();f.Pc=484;continue;}
case 484:{f.Push(f.Locals[6]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",489);}
case 489:{f.Pc=f.Pop().Int==0?513:492;continue;}
case 492:{f.Push(f.Locals[1]);f.Pc=493;continue;}
case 493:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",496);}
case 496:{f.Push(f.Locals[3]);f.Pc=497;continue;}
case 497:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",500);}
case 500:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",503);}
case 503:{f.Pc=f.Pop().Int==0?513:506;continue;}
case 506:{f.Push(f.Locals[6]);f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacementEffect","()Lforge/game/replacement/ReplacementEffect;","invokevirtual",511);}
case 511:{f.Locals[5]=f.Pop();f.Pc=513;continue;}
case 513:{f.Push(f.Locals[0]);f.Pc=514;continue;}
case 514:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffects","Lforge/util/collect/FCollection;"));f.Pc=517;continue;}
case 517:{return rt.Call(f,"forge/util/collect/FCollection","clear","()V","invokevirtual",520);}
case 520:{f.Push(f.Locals[1]);f.Pc=521;continue;}
case 521:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffects","Lforge/util/collect/FCollection;"));f.Pc=524;continue;}
case 524:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",527);}
case 527:{f.Locals[6]=f.Pop();f.Pc=529;continue;}
case 529:{f.Push(f.Locals[6]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",536);}
case 536:{f.Pc=f.Pop().Int==0?608:539;continue;}
case 539:{f.Push(f.Locals[6]);f.Pc=541;continue;}
case 541:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",546);}
case 546:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=549;continue;}
case 549:{f.Locals[7]=f.Pop();f.Pc=551;continue;}
case 551:{f.Push(f.Locals[7]);f.Pc=553;continue;}
case 553:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","isIntrinsic","()Z","invokevirtual",556);}
case 556:{f.Pc=f.Pop().Int==0?605:559;continue;}
case 559:{f.Push(f.Locals[7]);f.Pc=561;continue;}
case 561:{f.Push(f.Locals[0]);f.Pc=562;continue;}
case 562:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=565;continue;}
case 565:{f.Push(f.Locals[2]);f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokevirtual",569);}
case 569:{f.Locals[8]=f.Pop();f.Pc=571;continue;}
case 571:{f.Push(f.Locals[7]);f.Pc=573;continue;}
case 573:{f.Push(f.Locals[5]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","equals","(Ljava/lang/Object;)Z","invokevirtual",578);}
case 578:{f.Pc=f.Pop().Int==0?595:581;continue;}
case 581:{f.Push(f.Locals[5]);f.Pc=583;continue;}
case 583:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasRun","()Z","invokevirtual",586);}
case 586:{f.Pc=f.Pop().Int==0?595:589;continue;}
case 589:{f.Push(f.Locals[8]);f.Pc=591;continue;}
case 591:{f.Push(JValue.I(1));f.Pc=592;continue;}
case 592:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setHasRun","(Z)V","invokevirtual",595);}
case 595:{f.Push(f.Locals[0]);f.Pc=596;continue;}
case 596:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffects","Lforge/util/collect/FCollection;"));f.Pc=599;continue;}
case 599:{f.Push(f.Locals[8]);f.Pc=601;continue;}
case 601:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",604);}
case 604:{f.StackOp("pop");f.Pc=605;continue;}
case 605:{f.Pc=529;continue;}
case 608:{f.Push(f.Locals[0]);f.Pc=609;continue;}
case 609:{f.StackOp("dup");f.Pc=610;continue;}
case 610:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffectsVersion","I"));f.Pc=613;continue;}
case 613:{f.Push(JValue.I(1));f.Pc=614;continue;}
case 614:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=615;continue;}
case 615:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","replacementEffectsVersion","I",value);f.Pc=618;continue;}
case 618:{f.Push(f.Locals[0]);f.Pc=619;continue;}
case 619:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilities","Lforge/util/collect/FCollection;"));f.Pc=622;continue;}
case 622:{return rt.Call(f,"forge/util/collect/FCollection","clear","()V","invokevirtual",625);}
case 625:{f.Push(f.Locals[1]);f.Pc=626;continue;}
case 626:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilities","Lforge/util/collect/FCollection;"));f.Pc=629;continue;}
case 629:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",632);}
case 632:{f.Locals[6]=f.Pop();f.Pc=634;continue;}
case 634:{f.Push(f.Locals[6]);f.Pc=636;continue;}
case 636:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",641);}
case 641:{f.Pc=f.Pop().Int==0?685:644;continue;}
case 644:{f.Push(f.Locals[6]);f.Pc=646;continue;}
case 646:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",651);}
case 651:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=654;continue;}
case 654:{f.Locals[7]=f.Pop();f.Pc=656;continue;}
case 656:{f.Push(f.Locals[7]);f.Pc=658;continue;}
case 658:{return rt.Call(f,"forge/game/staticability/StaticAbility","isIntrinsic","()Z","invokevirtual",661);}
case 661:{f.Pc=f.Pop().Int==0?682:664;continue;}
case 664:{f.Push(f.Locals[0]);f.Pc=665;continue;}
case 665:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilities","Lforge/util/collect/FCollection;"));f.Pc=668;continue;}
case 668:{f.Push(f.Locals[7]);f.Pc=670;continue;}
case 670:{f.Push(f.Locals[0]);f.Pc=671;continue;}
case 671:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=674;continue;}
case 674:{f.Push(f.Locals[2]);f.Pc=675;continue;}
case 675:{return rt.Call(f,"forge/game/staticability/StaticAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/staticability/StaticAbility;","invokevirtual",678);}
case 678:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",681);}
case 681:{f.StackOp("pop");f.Pc=682;continue;}
case 682:{f.Pc=634;continue;}
case 685:{f.Push(f.Locals[0]);f.Pc=686;continue;}
case 686:{f.StackOp("dup");f.Pc=687;continue;}
case 687:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilitiesVersion","I"));f.Pc=690;continue;}
case 690:{f.Push(JValue.I(1));f.Pc=691;continue;}
case 691:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=692;continue;}
case 692:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","staticAbilitiesVersion","I",value);f.Pc=695;continue;}
case 695:{f.Push(f.Locals[2]);f.Pc=696;continue;}
case 696:{f.Pc=f.Pop().Int==0?993:699;continue;}
case 699:{f.Push(f.Locals[0]);f.Pc=700;continue;}
case 700:{f.Push(f.Locals[1]);f.Pc=701;continue;}
case 701:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","changedType","Lforge/card/CardTypeView;"));f.Pc=704;continue;}
case 704:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","changedType","Lforge/card/CardTypeView;",value);f.Pc=707;continue;}
case 707:{f.Push(f.Locals[1]);f.Pc=708;continue;}
case 708:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","landAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=711;continue;}
case 711:{f.Pc=f.Pop().Reference==null?730:714;continue;}
case 714:{f.Push(f.Locals[0]);f.Pc=715;continue;}
case 715:{f.Push(f.Locals[1]);f.Pc=716;continue;}
case 716:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","landAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=719;continue;}
case 719:{f.Push(f.Locals[0]);f.Pc=720;continue;}
case 720:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=723;continue;}
case 723:{f.Push(JValue.I(1));f.Pc=724;continue;}
case 724:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",727);}
case 727:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","landAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=730;continue;}
case 730:{f.Push(f.Locals[1]);f.Pc=731;continue;}
case 731:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","auraAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=734;continue;}
case 734:{f.Pc=f.Pop().Reference==null?753:737;continue;}
case 737:{f.Push(f.Locals[0]);f.Pc=738;continue;}
case 738:{f.Push(f.Locals[1]);f.Pc=739;continue;}
case 739:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","auraAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=742;continue;}
case 742:{f.Push(f.Locals[0]);f.Pc=743;continue;}
case 743:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=746;continue;}
case 746:{f.Push(JValue.I(1));f.Pc=747;continue;}
case 747:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",750);}
case 750:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","auraAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=753;continue;}
case 753:{f.Push(f.Locals[1]);f.Pc=754;continue;}
case 754:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","permanentAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=757;continue;}
case 757:{f.Pc=f.Pop().Reference==null?776:760;continue;}
case 760:{f.Push(f.Locals[0]);f.Pc=761;continue;}
case 761:{f.Push(f.Locals[1]);f.Pc=762;continue;}
case 762:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","permanentAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=765;continue;}
case 765:{f.Push(f.Locals[0]);f.Pc=766;continue;}
case 766:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=769;continue;}
case 769:{f.Push(JValue.I(1));f.Pc=770;continue;}
case 770:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",773);}
case 773:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","permanentAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=776;continue;}
case 776:{f.Push(f.Locals[1]);f.Pc=777;continue;}
case 777:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","loyaltyRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=780;continue;}
case 780:{f.Pc=f.Pop().Reference==null?799:783;continue;}
case 783:{f.Push(f.Locals[0]);f.Pc=784;continue;}
case 784:{f.Push(f.Locals[1]);f.Pc=785;continue;}
case 785:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","loyaltyRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=788;continue;}
case 788:{f.Push(f.Locals[0]);f.Pc=789;continue;}
case 789:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=792;continue;}
case 792:{f.Push(JValue.I(1));f.Pc=793;continue;}
case 793:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokevirtual",796);}
case 796:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","loyaltyRep","Lforge/game/replacement/ReplacementEffect;",value);f.Pc=799;continue;}
case 799:{f.Push(f.Locals[1]);f.Pc=800;continue;}
case 800:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","defenseRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=803;continue;}
case 803:{f.Pc=f.Pop().Reference==null?822:806;continue;}
case 806:{f.Push(f.Locals[0]);f.Pc=807;continue;}
case 807:{f.Push(f.Locals[1]);f.Pc=808;continue;}
case 808:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","defenseRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=811;continue;}
case 811:{f.Push(f.Locals[0]);f.Pc=812;continue;}
case 812:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=815;continue;}
case 815:{f.Push(JValue.I(1));f.Pc=816;continue;}
case 816:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokevirtual",819);}
case 819:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","defenseRep","Lforge/game/replacement/ReplacementEffect;",value);f.Pc=822;continue;}
case 822:{f.Push(f.Locals[1]);f.Pc=823;continue;}
case 823:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","sagaRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=826;continue;}
case 826:{f.Pc=f.Pop().Reference==null?845:829;continue;}
case 829:{f.Push(f.Locals[0]);f.Pc=830;continue;}
case 830:{f.Push(f.Locals[1]);f.Pc=831;continue;}
case 831:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","sagaRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=834;continue;}
case 834:{f.Push(f.Locals[0]);f.Pc=835;continue;}
case 835:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=838;continue;}
case 838:{f.Push(JValue.I(1));f.Pc=839;continue;}
case 839:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokevirtual",842);}
case 842:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","sagaRep","Lforge/game/replacement/ReplacementEffect;",value);f.Pc=845;continue;}
case 845:{f.Push(f.Locals[1]);f.Pc=846;continue;}
case 846:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","adventureRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=849;continue;}
case 849:{f.Pc=f.Pop().Reference==null?868:852;continue;}
case 852:{f.Push(f.Locals[0]);f.Pc=853;continue;}
case 853:{f.Push(f.Locals[1]);f.Pc=854;continue;}
case 854:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","adventureRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=857;continue;}
case 857:{f.Push(f.Locals[0]);f.Pc=858;continue;}
case 858:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=861;continue;}
case 861:{f.Push(JValue.I(1));f.Pc=862;continue;}
case 862:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokevirtual",865);}
case 865:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","adventureRep","Lforge/game/replacement/ReplacementEffect;",value);f.Pc=868;continue;}
case 868:{f.Push(f.Locals[1]);f.Pc=869;continue;}
case 869:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","omenRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=872;continue;}
case 872:{f.Pc=f.Pop().Reference==null?891:875;continue;}
case 875:{f.Push(f.Locals[0]);f.Pc=876;continue;}
case 876:{f.Push(f.Locals[1]);f.Pc=877;continue;}
case 877:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","omenRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=880;continue;}
case 880:{f.Push(f.Locals[0]);f.Pc=881;continue;}
case 881:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=884;continue;}
case 884:{f.Push(JValue.I(1));f.Pc=885;continue;}
case 885:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokevirtual",888);}
case 888:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","omenRep","Lforge/game/replacement/ReplacementEffect;",value);f.Pc=891;continue;}
case 891:{f.Push(f.Locals[1]);f.Pc=892;continue;}
case 892:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","vengeanceRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=895;continue;}
case 895:{f.Pc=f.Pop().Reference==null?914:898;continue;}
case 898:{f.Push(f.Locals[0]);f.Pc=899;continue;}
case 899:{f.Push(f.Locals[1]);f.Pc=900;continue;}
case 900:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","vengeanceRep","Lforge/game/replacement/ReplacementEffect;"));f.Pc=903;continue;}
case 903:{f.Push(f.Locals[0]);f.Pc=904;continue;}
case 904:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=907;continue;}
case 907:{f.Push(JValue.I(1));f.Pc=908;continue;}
case 908:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokevirtual",911);}
case 911:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","vengeanceRep","Lforge/game/replacement/ReplacementEffect;",value);f.Pc=914;continue;}
case 914:{f.Push(f.Locals[1]);f.Pc=915;continue;}
case 915:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","landManaAbilities","Ljava/util/Map;"));f.Pc=918;continue;}
case 918:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",923);}
case 923:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",928);}
case 928:{f.Locals[6]=f.Pop();f.Pc=930;continue;}
case 930:{f.Push(f.Locals[6]);f.Pc=932;continue;}
case 932:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",937);}
case 937:{f.Pc=f.Pop().Int==0?993:940;continue;}
case 940:{f.Push(f.Locals[6]);f.Pc=942;continue;}
case 942:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",947);}
case 947:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=950;continue;}
case 950:{f.Locals[7]=f.Pop();f.Pc=952;continue;}
case 952:{f.Push(f.Locals[0]);f.Pc=953;continue;}
case 953:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","landManaAbilities","Ljava/util/Map;"));f.Pc=956;continue;}
case 956:{f.Push(f.Locals[7]);f.Pc=958;continue;}
case 958:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",963);}
case 963:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/MagicColor$Color"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=966;continue;}
case 966:{f.Push(f.Locals[7]);f.Pc=968;continue;}
case 968:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",973);}
case 973:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=976;continue;}
case 976:{f.Push(f.Locals[0]);f.Pc=977;continue;}
case 977:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=980;continue;}
case 980:{f.Push(JValue.I(1));f.Pc=981;continue;}
case 981:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",984);}
case 984:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",989);}
case 989:{f.StackOp("pop");f.Pc=990;continue;}
case 990:{f.Pc=930;continue;}
case 993:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5362(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?79:17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?76:36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",41);}
case 41:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","PermanentCreature","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","PermanentCreature","Lforge/game/ability/ApiType;"));f.Pc=44;continue;}
case 44:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?76:47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",52);}
case 52:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","PermanentNoncreature","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","PermanentNoncreature","Lforge/game/ability/ApiType;"));f.Pc=55;continue;}
case 55:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?76:58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;"));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",72);}
case 72:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Pc=8;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","intrinsicKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/keyword/KeywordCollection","iterator","()Ljava/util/Iterator;","invokevirtual",86);}
case 86:{f.Locals[3]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",93);}
case 93:{f.Pc=f.Pop().Int==0?130:96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",102);}
case 102:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=105;continue;}
case 105:{f.Locals[4]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","intrinsicKeywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=111;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=117;continue;}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/keyword/KeywordInterface","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordInterface;","invokeinterface",123);}
case 123:{return rt.Call(f,"forge/game/keyword/KeywordCollection","insert","(Lforge/game/keyword/KeywordInterface;)Z","invokevirtual",126);}
case 126:{f.StackOp("pop");f.Pc=127;continue;}
case 127:{f.Pc=87;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","triggers","Lforge/util/collect/FCollection;"));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",137);}
case 137:{f.Locals[3]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[3]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",144);}
case 144:{f.Pc=f.Pop().Int==0?187:147;continue;}
case 147:{f.Push(f.Locals[3]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",153);}
case 153:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=156;continue;}
case 156:{f.Locals[4]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[4]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/trigger/Trigger","isIntrinsic","()Z","invokevirtual",163);}
case 163:{f.Pc=f.Pop().Int==0?184:166;continue;}
case 166:{f.Push(f.Locals[0]);f.Pc=167;continue;}
case 167:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","triggers","Lforge/util/collect/FCollection;"));f.Pc=170;continue;}
case 170:{f.Push(f.Locals[4]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[2]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/trigger/Trigger","copy","(Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokevirtual",180);}
case 180:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",183);}
case 183:{f.StackOp("pop");f.Pc=184;continue;}
case 184:{f.Pc=138;continue;}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffects","Lforge/util/collect/FCollection;"));f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",194);}
case 194:{f.Locals[3]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[3]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",201);}
case 201:{f.Pc=f.Pop().Int==0?244:204;continue;}
case 204:{f.Push(f.Locals[3]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",210);}
case 210:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=213;continue;}
case 213:{f.Locals[4]=f.Pop();f.Pc=215;continue;}
case 215:{f.Push(f.Locals[4]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","isIntrinsic","()Z","invokevirtual",220);}
case 220:{f.Pc=f.Pop().Int==0?241:223;continue;}
case 223:{f.Push(f.Locals[0]);f.Pc=224;continue;}
case 224:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffects","Lforge/util/collect/FCollection;"));f.Pc=227;continue;}
case 227:{f.Push(f.Locals[4]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=233;continue;}
case 233:{f.Push(f.Locals[2]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokevirtual",237);}
case 237:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",240);}
case 240:{f.StackOp("pop");f.Pc=241;continue;}
case 241:{f.Pc=195;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{f.StackOp("dup");f.Pc=246;continue;}
case 246:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffectsVersion","I"));f.Pc=249;continue;}
case 249:{f.Push(JValue.I(1));f.Pc=250;continue;}
case 250:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=251;continue;}
case 251:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","replacementEffectsVersion","I",value);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[1]);f.Pc=255;continue;}
case 255:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilities","Lforge/util/collect/FCollection;"));f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",261);}
case 261:{f.Locals[3]=f.Pop();f.Pc=262;continue;}
case 262:{f.Push(f.Locals[3]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",268);}
case 268:{f.Pc=f.Pop().Int==0?311:271;continue;}
case 271:{f.Push(f.Locals[3]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",277);}
case 277:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=280;continue;}
case 280:{f.Locals[4]=f.Pop();f.Pc=282;continue;}
case 282:{f.Push(f.Locals[4]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/staticability/StaticAbility","isIntrinsic","()Z","invokevirtual",287);}
case 287:{f.Pc=f.Pop().Int==0?308:290;continue;}
case 290:{f.Push(f.Locals[0]);f.Pc=291;continue;}
case 291:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilities","Lforge/util/collect/FCollection;"));f.Pc=294;continue;}
case 294:{f.Push(f.Locals[4]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[0]);f.Pc=297;continue;}
case 297:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","card","Lforge/game/card/Card;"));f.Pc=300;continue;}
case 300:{f.Push(f.Locals[2]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/staticability/StaticAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/staticability/StaticAbility;","invokevirtual",304);}
case 304:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",307);}
case 307:{f.StackOp("pop");f.Pc=308;continue;}
case 308:{f.Pc=262;continue;}
case 311:{f.Push(f.Locals[0]);f.Pc=312;continue;}
case 312:{f.StackOp("dup");f.Pc=313;continue;}
case 313:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilitiesVersion","I"));f.Pc=316;continue;}
case 316:{f.Push(JValue.I(1));f.Pc=317;continue;}
case 317:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=318;continue;}
case 318:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","staticAbilitiesVersion","I",value);f.Pc=321;continue;}
case 321:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5363(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/card/CardStateName;ZLforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5364(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",6);}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/card/CardStateName;ZLforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5365(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardState","copy","(Lforge/game/card/Card;Lforge/card/CardStateName;ZLforge/game/CardTraitBase;)Lforge/game/card/CardState;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5366(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardState"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardState")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardState","<init>","(Lforge/game/card/Card;Lforge/card/CardStateName;)V","invokespecial",9);}
case 9:{f.Locals[5]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[5]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;ZLforge/game/CardTraitBase;)V","invokevirtual",20);}
case 20:{f.Push(f.Locals[5]);f.Pc=22;continue;}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5367(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","rarity","Lforge/card/CardRarity;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5368(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","rarity","Lforge/card/CardRarity;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateRarity","(Lforge/game/card/CardState;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5369(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","setCode","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5370(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","setCode","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateSetCode","(Lforge/game/card/CardState;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5371(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","imageKey","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5372(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","imageKey","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","view","Lforge/game/card/CardView$CardStateView;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateImageKey","(Lforge/game/card/CardState;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5373(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardStateProperty","hasProperty","(Lforge/game/card/CardState;Lforge/game/player/Player;Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Z","invokestatic",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5374(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/ImmutableList","builder","()Lcom/google/common/collect/ImmutableList$Builder;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilities","Lforge/util/collect/FCollection;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","addAll","(Ljava/lang/Iterable;)Lcom/google/common/collect/ImmutableList$Builder;","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","triggers","Lforge/util/collect/FCollection;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","addAll","(Ljava/lang/Iterable;)Lcom/google/common/collect/ImmutableList$Builder;","invokevirtual",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","replacementEffects","Lforge/util/collect/FCollection;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","addAll","(Ljava/lang/Iterable;)Lcom/google/common/collect/ImmutableList$Builder;","invokevirtual",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","staticAbilities","Lforge/util/collect/FCollection;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","addAll","(Ljava/lang/Iterable;)Lcom/google/common/collect/ImmutableList$Builder;","invokevirtual",31);}
case 31:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","build","()Lcom/google/common/collect/ImmutableList;","invokevirtual",34);}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5375(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getTraits","()Lcom/google/common/collect/ImmutableList;","invokevirtual",4);}
case 4:{return rt.Call(f,"com/google/common/collect/ImmutableList","iterator","()Lcom/google/common/collect/UnmodifiableIterator;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?53:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/CardTraitBase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/CardTraitBase","isIntrinsic","()Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?50:34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/CardTraitBase","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?50:45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/CardTraitBase","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",50);}
case 50:{f.Pc=8;continue;}
case 53:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5376(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getTraits","()Lcom/google/common/collect/ImmutableList;","invokevirtual",4);}
case 4:{return rt.Call(f,"com/google/common/collect/ImmutableList","iterator","()Lcom/google/common/collect/UnmodifiableIterator;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?41:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/CardTraitBase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/CardTraitBase","isIntrinsic","()Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?38:34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/CardTraitBase","changeText","()V","invokevirtual",38);}
case 38:{f.Pc=8;continue;}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5377(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getTraits","()Lcom/google/common/collect/ImmutableList;","invokevirtual",4);}
case 4:{return rt.Call(f,"com/google/common/collect/ImmutableList","iterator","()Lcom/google/common/collect/UnmodifiableIterator;","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?46:17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/CardTraitBase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/CardTraitBase","isIntrinsic","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?43:36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/CardTraitBase","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V","invokevirtual",43);}
case 43:{f.Pc=8;continue;}
case 46:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5378(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/game/card/CardState:5378:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",9);}
case 9:{return rt.Call(f,"forge/util/collect/FCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",14);}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5379(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/CardState","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?53:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/trigger/Trigger","isChapter","()Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?50:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/trigger/Trigger","getChapter","()Ljava/lang/Integer;","invokevirtual",43);}
case 43:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",46);}
case 46:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",49);}
case 49:{f.Locals[1]=f.Pop();f.Pc=50;continue;}
case 50:{f.Pc=12;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5380(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","manifestUp","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?36:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",17);}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",21);}
case 21:{f.Push(JValue.R(rt.String("ManifestUp")));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Unmanifest")));f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("manacost")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/CardFactoryUtil","abilityTurnFaceUp","(Lforge/game/card/CardState;Lforge/game/cost/Cost;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",33);}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","manifestUp","Lforge/game/spellability/SpellAbility;",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","manifestUp","Lforge/game/spellability/SpellAbility;"));f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5381(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","cloakUp","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?36:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",17);}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",21);}
case 21:{f.Push(JValue.R(rt.String("CloakUp")));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Uncloak")));f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("manacost")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/CardFactoryUtil","abilityTurnFaceUp","(Lforge/game/card/CardState;Lforge/game/cost/Cost;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",33);}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState","cloakUp","Lforge/game/spellability/SpellAbility;",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","cloakUp","Lforge/game/spellability/SpellAbility;"));f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5382(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","abilityForTrigger","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/game/card/CardState:5382:6:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CardState;)Ljava/util/function/Function;",11);}
case 11:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5383(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","flavorName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","name","Ljava/lang/String;"));f.Pc=11;continue;}
case 11:{f.Pc=18;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","flavorName","Ljava/lang/String;"));f.Pc=18;continue;}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","functionalVariantName","Ljava/lang/String;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",26);}
case 26:{f.Pc=f.Pop().Int==0?40:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState","functionalVariantName","Ljava/lang/String;"));f.Pc=34;continue;}
case 34:{return rt.DynamicCall(f,"forge/game/card/CardState:5383:34:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",39);}
case 39:{return JStep.Return(f.Pop());}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5384(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5385(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5386(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getTypeWithChanges","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardTypeView","isCreature","()Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int==0?35:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardTypeView","isLegendary","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?35:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Villain")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?37:35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",41);}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","getColor","(Lforge/game/card/CardState;)Lforge/card/ColorSet;","invokevirtual",45);}
case 45:{f.Locals[2]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/card/ColorSet","hasRed","()Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int!=0?60:53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/card/ColorSet","hasWhite","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?64:60;continue;}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{f.Pc=65;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5387(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5388(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/MagicColor$Color","getShortName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/MagicColor$Color","getSymbol","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.DynamicCall(f,"forge/game/card/CardState:5388:8:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",25);}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5389(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBasicSpell","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?44:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Reference!=null?44:14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","PermanentCreature","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","PermanentCreature","Lforge/game/ability/ApiType;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?40:27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","PermanentNoncreature","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","PermanentNoncreature","Lforge/game/ability/ApiType;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?44:40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{f.Pc=45;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

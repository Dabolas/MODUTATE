// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C799{
internal static JClass Build(){var c=new JClass("forge/game/spellability/SpellAbility","forge/game/CardTraitBase",new string[]{"forge/game/spellability/ISpellAbility","forge/game/IIdentifiable","java/lang/Comparable"},1057);Add0(c);Add1(c);Add2(c);Add3(c);Add4(c);Add5(c);Add6(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("maxId","I",true,JValue.Default("I"),null));
c.Add(new JField("id","I",false,JValue.Default("I"),null));
c.Add(new JField("originalDescription","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("description","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("originalStackDescription","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("stackDescription","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("activatingPlayer","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("targetingPlayer","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("choosingPlayer","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("controlledByPlayer","Lorg/apache/commons/lang3/tuple/Pair;",false,JValue.Default("Lorg/apache/commons/lang3/tuple/Pair;"),null));
c.Add(new JField("manaCostBeingPaid","Lforge/game/mana/ManaCostBeingPaid;",false,JValue.Default("Lforge/game/mana/ManaCostBeingPaid;"),null));
c.Add(new JField("spentPhyrexian","I",false,JValue.Default("I"),null));
c.Add(new JField("paidLifeAmount","I",false,JValue.Default("I"),null));
c.Add(new JField("grantorOriginal","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("grantorStatic","Lforge/game/staticability/StaticAbility;",false,JValue.Default("Lforge/game/staticability/StaticAbility;"),null));
c.Add(new JField("splicedCards","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("basicSpell","Z",false,JValue.Default("Z"),null));
c.Add(new JField("triggerObj","Lforge/game/trigger/Trigger;",false,JValue.Default("Lforge/game/trigger/Trigger;"),null));
c.Add(new JField("optionalTrigger","Z",false,JValue.Default("Z"),null));
c.Add(new JField("replacementEffect","Lforge/game/replacement/ReplacementEffect;",false,JValue.Default("Lforge/game/replacement/ReplacementEffect;"),null));
c.Add(new JField("altCost","Lforge/game/spellability/AlternativeCost;",false,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("optionalCosts","Ljava/util/EnumSet;",false,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("optionalKeywordAmount","Lcom/google/common/collect/Table;",false,JValue.Default("Lcom/google/common/collect/Table;"),null));
c.Add(new JField("aftermath","Z",false,JValue.Default("Z"),null));
c.Add(new JField("skip","Z",false,JValue.Default("Z"),null));
c.Add(new JField("payCosts","Lforge/game/cost/Cost;",false,JValue.Default("Lforge/game/cost/Cost;"),null));
c.Add(new JField("restrictions","Lforge/game/spellability/SpellAbilityRestriction;",false,JValue.Default("Lforge/game/spellability/SpellAbilityRestriction;"),null));
c.Add(new JField("conditions","Lforge/game/spellability/SpellAbilityCondition;",false,JValue.Default("Lforge/game/spellability/SpellAbilityCondition;"),null));
c.Add(new JField("subAbility","Lforge/game/spellability/AbilitySub;",false,JValue.Default("Lforge/game/spellability/AbilitySub;"),null));
c.Add(new JField("additionalAbilities","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("additionalAbilityLists","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("api","Lforge/game/ability/ApiType;",false,JValue.Default("Lforge/game/ability/ApiType;"),null));
c.Add(new JField("payingMana","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("paidAbilities","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("xManaCostPaid","Ljava/lang/Integer;",false,JValue.Default("Ljava/lang/Integer;"),null));
c.Add(new JField("paidLists","Lcom/google/common/collect/TreeBasedTable;",false,JValue.Default("Lcom/google/common/collect/TreeBasedTable;"),null));
c.Add(new JField("triggeringObjects","Ljava/util/EnumMap;",false,JValue.Default("Ljava/util/EnumMap;"),null));
c.Add(new JField("replacingObjects","Ljava/util/EnumMap;",false,JValue.Default("Ljava/util/EnumMap;"),null));
c.Add(new JField("pipsToReduce","Lcom/google/common/base/Supplier;",false,JValue.Default("Lcom/google/common/base/Supplier;"),null));
c.Add(new JField("chosenList","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("tappedForConvoke","Lcom/google/common/base/Supplier;",false,JValue.Default("Lcom/google/common/base/Supplier;"),null));
c.Add(new JField("sacrificedAsOffering","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("sacrificedAsEmerge","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("maxWaterbend","Ljava/lang/Integer;",false,JValue.Default("Ljava/lang/Integer;"),null));
c.Add(new JField("manaPart","Lforge/game/spellability/AbilityManaPart;",false,JValue.Default("Lforge/game/spellability/AbilityManaPart;"),null));
c.Add(new JField("undoable","Z",false,JValue.Default("Z"),null));
c.Add(new JField("isCopied","Z",false,JValue.Default("Z"),null));
c.Add(new JField("mayChooseNewTargets","Z",false,JValue.Default("Z"),null));
c.Add(new JField("isCastFromPlayEffect","Z",false,JValue.Default("Z"),null));
c.Add(new JField("targetRestrictions","Lforge/game/spellability/TargetRestrictions;",false,JValue.Default("Lforge/game/spellability/TargetRestrictions;"),null));
c.Add(new JField("targetChosen","Lforge/game/spellability/TargetChoices;",false,JValue.Default("Lforge/game/spellability/TargetChoices;"),null));
c.Add(new JField("dividedValue","Ljava/lang/Integer;",false,JValue.Default("Ljava/lang/Integer;"),null));
c.Add(new JField("view","Lforge/game/spellability/SpellAbilityView;",false,JValue.Default("Lforge/game/spellability/SpellAbilityView;"),null));
c.Add(new JField("mayPlay","Lforge/game/card/CardPlayOption;",false,JValue.Default("Lforge/game/card/CardPlayOption;"),null));
c.Add(new JField("lastStateBattlefield","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("lastStateGraveyard","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("rollbackEffects","Lcom/google/common/base/Supplier;",false,JValue.Default("Lcom/google/common/base/Supplier;"),null));
c.Add(new JField("damageMap","Lforge/game/card/CardDamageTable;",false,JValue.Default("Lforge/game/card/CardDamageTable;"),null));
c.Add(new JField("preventMap","Lforge/game/card/CardDamageTable;",false,JValue.Default("Lforge/game/card/CardDamageTable;"),null));
c.Add(new JField("counterTable","Lforge/game/GameEntityCounterTable;",false,JValue.Default("Lforge/game/GameEntityCounterTable;"),null));
c.Add(new JField("changeZoneTable","Lforge/game/card/CardZoneTable;",false,JValue.Default("Lforge/game/card/CardZoneTable;"),null));
c.Add(new JField("loseLifeMap","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("CLASS_HASH","I",true,JValue.Default("I"),null));
}

private static void Add1(JClass c){
c.Add(new JMethod(9182,"forge/game/spellability/SpellAbility","nextId","()I",10,0,2,new JHandler[]{},M9182));
c.Add(new JMethod(9183,"forge/game/spellability/SpellAbility","getLastStateBattlefield","()Lforge/game/card/CardCollection;",1,1,1,new JHandler[]{},M9183));
c.Add(new JMethod(9184,"forge/game/spellability/SpellAbility","setLastStateBattlefield","(Lforge/game/card/CardCollectionView;)V",1,2,4,new JHandler[]{},M9184));
c.Add(new JMethod(9185,"forge/game/spellability/SpellAbility","getLastStateGraveyard","()Lforge/game/card/CardCollection;",1,1,1,new JHandler[]{},M9185));
c.Add(new JMethod(9186,"forge/game/spellability/SpellAbility","setLastStateGraveyard","(Lforge/game/card/CardCollectionView;)V",1,2,4,new JHandler[]{},M9186));
c.Add(new JMethod(9187,"forge/game/spellability/SpellAbility","clearLastState","()V",1,1,2,new JHandler[]{},M9187));
c.Add(new JMethod(9188,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V",4,3,5,new JHandler[]{},M9188));
c.Add(new JMethod(9189,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbilityView;)V",4,4,5,new JHandler[]{},M9189));
c.Add(new JMethod(9190,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbilityView;Lforge/game/card/CardState;)V",4,5,3,new JHandler[]{},M9190));
c.Add(new JMethod(9191,"forge/game/spellability/SpellAbility","getId","()I",17,1,1,new JHandler[]{},M9191));
c.Add(new JMethod(9192,"forge/game/spellability/SpellAbility","hashCode","()I",1,1,3,new JHandler[]{},M9192));
c.Add(new JMethod(9193,"forge/game/spellability/SpellAbility","equals","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M9193));
c.Add(new JMethod(9194,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V",1,6,2,new JHandler[]{},M9194));
c.Add(new JMethod(9195,"forge/game/spellability/SpellAbility","setKeyword","(Lforge/game/keyword/KeywordInterface;)V",1,6,2,new JHandler[]{},M9195));
c.Add(new JMethod(9196,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;",1,1,1,new JHandler[]{},M9196));
c.Add(new JMethod(9197,"forge/game/spellability/SpellAbility","setApi","(Lforge/game/ability/ApiType;)V",1,2,2,new JHandler[]{},M9197));
c.Add(new JMethod(9198,"forge/game/spellability/SpellAbility","findSubAbilityByType","(Lforge/game/ability/ApiType;)Lforge/game/spellability/SpellAbility;",1,3,2,new JHandler[]{},M9198));
c.Add(new JMethod(9199,"forge/game/spellability/SpellAbility","canThisProduce","(Ljava/lang/String;)Z",1,3,3,new JHandler[]{},M9199));
c.Add(new JMethod(9200,"forge/game/spellability/SpellAbility","canProduce","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M9200));
c.Add(new JMethod(9201,"forge/game/spellability/SpellAbility","isManaAbilityFor","(Lforge/game/spellability/SpellAbility;B)Z",1,4,3,new JHandler[]{},M9201));
c.Add(new JMethod(9202,"forge/game/spellability/SpellAbility","isManaCannotCounter","(Lforge/game/spellability/SpellAbility;)Z",1,3,2,new JHandler[]{},M9202));
c.Add(new JMethod(9203,"forge/game/spellability/SpellAbility","amountOfManaGenerated","(Z)I",1,5,3,new JHandler[]{},M9203));
c.Add(new JMethod(9204,"forge/game/spellability/SpellAbility","totalAmountOfManaGenerated","(Lforge/game/spellability/SpellAbility;Z)I",1,5,4,new JHandler[]{},M9204));
c.Add(new JMethod(9205,"forge/game/spellability/SpellAbility","setManaExpressChoice","(Lforge/card/ColorSet;)V",1,3,2,new JHandler[]{},M9205));
c.Add(new JMethod(9206,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;",17,1,1,new JHandler[]{},M9206));
c.Add(new JMethod(9207,"forge/game/spellability/SpellAbility","getAllManaParts","()Ljava/util/List;",17,3,2,new JHandler[]{},M9207));
c.Add(new JMethod(9208,"forge/game/spellability/SpellAbility","isManaAbility","()Z",1,4,2,new JHandler[]{},M9208));
c.Add(new JMethod(9209,"forge/game/spellability/SpellAbility","setManaPart","(Lforge/game/spellability/AbilityManaPart;)V",17,2,2,new JHandler[]{},M9209));
c.Add(new JMethod(9210,"forge/game/spellability/SpellAbility","allowsPayingWithShard","(Lforge/game/card/Card;B)Z",1,4,5,new JHandler[]{},M9210));
c.Add(new JMethod(9211,"forge/game/spellability/SpellAbility","cantBeCopied","()Z",1,1,2,new JHandler[]{},M9211));
c.Add(new JMethod(9212,"forge/game/spellability/SpellAbility","canPlay","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(9213,"forge/game/spellability/SpellAbility","canPlay","(Z)Z",1,4,2,new JHandler[]{},M9213));
c.Add(new JMethod(9214,"forge/game/spellability/SpellAbility","canPlayWithOptionalCost","(Lforge/game/spellability/OptionalCostValue;)Z",1,2,5,new JHandler[]{},M9214));
c.Add(new JMethod(9215,"forge/game/spellability/SpellAbility","isPossible","()Z",1,1,1,new JHandler[]{},M9215));
c.Add(new JMethod(9216,"forge/game/spellability/SpellAbility","promptIfOnlyPossibleAbility","()Z",1,1,1,new JHandler[]{},M9216));
c.Add(new JMethod(9217,"forge/game/spellability/SpellAbility","resolve","()V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(9218,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M9218));
c.Add(new JMethod(9219,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V",1,6,2,new JHandler[]{},M9219));
c.Add(new JMethod(9220,"forge/game/spellability/SpellAbility","getTargetingPlayer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M9220));
c.Add(new JMethod(9221,"forge/game/spellability/SpellAbility","setTargetingPlayer","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M9221));
c.Add(new JMethod(9222,"forge/game/spellability/SpellAbility","getChoosingPlayer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M9222));
c.Add(new JMethod(9223,"forge/game/spellability/SpellAbility","setChoosingPlayer","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M9223));
c.Add(new JMethod(9224,"forge/game/spellability/SpellAbility","getControlledByPlayer","()Lorg/apache/commons/lang3/tuple/Pair;",1,1,1,new JHandler[]{},M9224));
c.Add(new JMethod(9225,"forge/game/spellability/SpellAbility","setControlledByPlayer","(JLforge/game/player/Player;)V",1,4,3,new JHandler[]{},M9225));
c.Add(new JMethod(9226,"forge/game/spellability/SpellAbility","getManaCostBeingPaid","()Lforge/game/mana/ManaCostBeingPaid;",1,1,1,new JHandler[]{},M9226));
c.Add(new JMethod(9227,"forge/game/spellability/SpellAbility","setManaCostBeingPaid","(Lforge/game/mana/ManaCostBeingPaid;)V",1,2,2,new JHandler[]{},M9227));
c.Add(new JMethod(9228,"forge/game/spellability/SpellAbility","getOptionalCosts","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M9228));
c.Add(new JMethod(9229,"forge/game/spellability/SpellAbility","addOptionalCost","(Lforge/game/spellability/OptionalCost;)V",17,2,2,new JHandler[]{},M9229));
c.Add(new JMethod(9230,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z",1,2,2,new JHandler[]{},M9230));
c.Add(new JMethod(9231,"forge/game/spellability/SpellAbility","isSpell","()Z",1,1,1,new JHandler[]{},M9231));
c.Add(new JMethod(9232,"forge/game/spellability/SpellAbility","isAbility","()Z",1,1,1,new JHandler[]{},M9232));
c.Add(new JMethod(9233,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z",1,1,1,new JHandler[]{},M9233));
c.Add(new JMethod(9234,"forge/game/spellability/SpellAbility","isLandAbility","()Z",1,1,1,new JHandler[]{},M9234));
c.Add(new JMethod(9235,"forge/game/spellability/SpellAbility","isTurnFaceUp","()Z",1,1,1,new JHandler[]{},M9235));
c.Add(new JMethod(9236,"forge/game/spellability/SpellAbility","isMorphUp","()Z",1,1,2,new JHandler[]{},M9236));
c.Add(new JMethod(9237,"forge/game/spellability/SpellAbility","isDisguiseUp","()Z",1,1,2,new JHandler[]{},M9237));
c.Add(new JMethod(9238,"forge/game/spellability/SpellAbility","isCastFaceDown","()Z",1,1,1,new JHandler[]{},M9238));
c.Add(new JMethod(9239,"forge/game/spellability/SpellAbility","isManifestUp","()Z",1,1,2,new JHandler[]{},M9239));
c.Add(new JMethod(9240,"forge/game/spellability/SpellAbility","isCloakUp","()Z",1,1,2,new JHandler[]{},M9240));
c.Add(new JMethod(9241,"forge/game/spellability/SpellAbility","isUnlock","()Z",1,1,2,new JHandler[]{},M9241));
c.Add(new JMethod(9242,"forge/game/spellability/SpellAbility","isCycling","()Z",1,1,2,new JHandler[]{},M9242));
c.Add(new JMethod(9243,"forge/game/spellability/SpellAbility","isBackup","()Z",1,1,2,new JHandler[]{},M9243));
c.Add(new JMethod(9244,"forge/game/spellability/SpellAbility","isBoast","()Z",1,1,2,new JHandler[]{},M9244));
c.Add(new JMethod(9245,"forge/game/spellability/SpellAbility","isMonstrosity","()Z",1,1,2,new JHandler[]{},M9245));
}

private static void Add2(JClass c){
c.Add(new JMethod(9246,"forge/game/spellability/SpellAbility","isExhaust","()Z",1,1,2,new JHandler[]{},M9246));
c.Add(new JMethod(9247,"forge/game/spellability/SpellAbility","isPowerUp","()Z",1,1,2,new JHandler[]{},M9247));
c.Add(new JMethod(9248,"forge/game/spellability/SpellAbility","isNinjutsu","()Z",1,1,2,new JHandler[]{},M9248));
c.Add(new JMethod(9249,"forge/game/spellability/SpellAbility","isCumulativeUpkeep","()Z",1,1,2,new JHandler[]{},M9249));
c.Add(new JMethod(9250,"forge/game/spellability/SpellAbility","isBargained","()Z",1,1,2,new JHandler[]{},M9250));
c.Add(new JMethod(9251,"forge/game/spellability/SpellAbility","isBuyback","()Z",1,1,2,new JHandler[]{},M9251));
c.Add(new JMethod(9252,"forge/game/spellability/SpellAbility","isKicked","()Z",1,1,2,new JHandler[]{},M9252));
c.Add(new JMethod(9253,"forge/game/spellability/SpellAbility","isEntwine","()Z",1,1,2,new JHandler[]{},M9253));
c.Add(new JMethod(9254,"forge/game/spellability/SpellAbility","isTeamwork","()Z",1,1,2,new JHandler[]{},M9254));
c.Add(new JMethod(9255,"forge/game/spellability/SpellAbility","isJumpstart","()Z",1,1,2,new JHandler[]{},M9255));
c.Add(new JMethod(9256,"forge/game/spellability/SpellAbility","isGiftPromised","()Z",1,1,2,new JHandler[]{},M9256));
c.Add(new JMethod(9257,"forge/game/spellability/SpellAbility","isBestow","()Z",17,1,2,new JHandler[]{},M9257));
c.Add(new JMethod(9258,"forge/game/spellability/SpellAbility","isBlitz","()Z",17,1,2,new JHandler[]{},M9258));
c.Add(new JMethod(9259,"forge/game/spellability/SpellAbility","isDash","()Z",17,1,2,new JHandler[]{},M9259));
c.Add(new JMethod(9260,"forge/game/spellability/SpellAbility","isDisturb","()Z",17,1,2,new JHandler[]{},M9260));
c.Add(new JMethod(9261,"forge/game/spellability/SpellAbility","isEscape","()Z",17,1,2,new JHandler[]{},M9261));
c.Add(new JMethod(9262,"forge/game/spellability/SpellAbility","isEvoke","()Z",17,1,2,new JHandler[]{},M9262));
c.Add(new JMethod(9263,"forge/game/spellability/SpellAbility","isFreerunning","()Z",17,1,2,new JHandler[]{},M9263));
c.Add(new JMethod(9264,"forge/game/spellability/SpellAbility","isImpending","()Z",17,1,2,new JHandler[]{},M9264));
c.Add(new JMethod(9265,"forge/game/spellability/SpellAbility","isMadness","()Z",17,1,2,new JHandler[]{},M9265));
c.Add(new JMethod(9266,"forge/game/spellability/SpellAbility","isMayhem","()Z",17,1,2,new JHandler[]{},M9266));
c.Add(new JMethod(9267,"forge/game/spellability/SpellAbility","isMutate","()Z",17,1,2,new JHandler[]{},M9267));
c.Add(new JMethod(9268,"forge/game/spellability/SpellAbility","isProwl","()Z",17,1,2,new JHandler[]{},M9268));
c.Add(new JMethod(9269,"forge/game/spellability/SpellAbility","isSneak","()Z",17,1,2,new JHandler[]{},M9269));
c.Add(new JMethod(9270,"forge/game/spellability/SpellAbility","isSurged","()Z",17,1,2,new JHandler[]{},M9270));
c.Add(new JMethod(9271,"forge/game/spellability/SpellAbility","isSpectacle","()Z",17,1,2,new JHandler[]{},M9271));
c.Add(new JMethod(9272,"forge/game/spellability/SpellAbility","isBeamMeUp","()Z",1,1,2,new JHandler[]{},M9272));
c.Add(new JMethod(9273,"forge/game/spellability/SpellAbility","isFlashback","()Z",1,1,2,new JHandler[]{},M9273));
c.Add(new JMethod(9274,"forge/game/spellability/SpellAbility","isHarmonize","()Z",1,1,2,new JHandler[]{},M9274));
c.Add(new JMethod(9275,"forge/game/spellability/SpellAbility","isForetelling","()Z",1,1,1,new JHandler[]{},M9275));
c.Add(new JMethod(9276,"forge/game/spellability/SpellAbility","isForetold","()Z",1,1,2,new JHandler[]{},M9276));
c.Add(new JMethod(9277,"forge/game/spellability/SpellAbility","isWarp","()Z",17,1,2,new JHandler[]{},M9277));
c.Add(new JMethod(9278,"forge/game/spellability/SpellAbility","isPlotting","()Z",1,1,1,new JHandler[]{},M9278));
c.Add(new JMethod(9279,"forge/game/spellability/SpellAbility","isOutlast","()Z",1,1,2,new JHandler[]{},M9279));
c.Add(new JMethod(9280,"forge/game/spellability/SpellAbility","isCraft","()Z",1,1,2,new JHandler[]{},M9280));
c.Add(new JMethod(9281,"forge/game/spellability/SpellAbility","isCrew","()Z",1,1,2,new JHandler[]{},M9281));
c.Add(new JMethod(9282,"forge/game/spellability/SpellAbility","isEquip","()Z",1,1,2,new JHandler[]{},M9282));
c.Add(new JMethod(9283,"forge/game/spellability/SpellAbility","isAftermath","()Z",1,1,1,new JHandler[]{},M9283));
c.Add(new JMethod(9284,"forge/game/spellability/SpellAbility","setAftermath","(Z)V",1,2,2,new JHandler[]{},M9284));
c.Add(new JMethod(9285,"forge/game/spellability/SpellAbility","isChapter","()Z",1,1,1,new JHandler[]{},M9285));
c.Add(new JMethod(9286,"forge/game/spellability/SpellAbility","getChapter","()Ljava/lang/Integer;",1,1,1,new JHandler[]{},M9286));
c.Add(new JMethod(9287,"forge/game/spellability/SpellAbility","isLastChapter","()Z",1,1,1,new JHandler[]{},M9287));
c.Add(new JMethod(9288,"forge/game/spellability/SpellAbility","isAdventure","()Z",1,1,2,new JHandler[]{},M9288));
c.Add(new JMethod(9289,"forge/game/spellability/SpellAbility","isOmen","()Z",1,1,2,new JHandler[]{},M9289));
c.Add(new JMethod(9290,"forge/game/spellability/SpellAbility","isVengeance","()Z",1,1,2,new JHandler[]{},M9290));
c.Add(new JMethod(9291,"forge/game/spellability/SpellAbility","isCurse","()Z",17,1,2,new JHandler[]{},M9291));
c.Add(new JMethod(9292,"forge/game/spellability/SpellAbility","isPwAbility","()Z",17,1,2,new JHandler[]{},M9292));
c.Add(new JMethod(9293,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;",1,1,1,new JHandler[]{},M9293));
c.Add(new JMethod(9294,"forge/game/spellability/SpellAbility","setPayCosts","(Lforge/game/cost/Cost;)V",1,2,2,new JHandler[]{},M9294));
c.Add(new JMethod(9295,"forge/game/spellability/SpellAbility","costHasManaX","()Z",1,1,1,new JHandler[]{},M9295));
c.Add(new JMethod(9296,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;",1,1,1,new JHandler[]{},M9296));
c.Add(new JMethod(9297,"forge/game/spellability/SpellAbility","setRestrictions","(Lforge/game/spellability/SpellAbilityRestriction;)V",1,2,2,new JHandler[]{},M9297));
c.Add(new JMethod(9298,"forge/game/spellability/SpellAbility","getActivationsThisTurn","()I",1,1,2,new JHandler[]{},M9298));
c.Add(new JMethod(9299,"forge/game/spellability/SpellAbility","getActivationsThisGame","()I",1,1,2,new JHandler[]{},M9299));
c.Add(new JMethod(9300,"forge/game/spellability/SpellAbility","getResolvedThisTurn","()I",1,1,2,new JHandler[]{},M9300));
c.Add(new JMethod(9301,"forge/game/spellability/SpellAbility","getConditions","()Lforge/game/spellability/SpellAbilityCondition;",1,1,1,new JHandler[]{},M9301));
c.Add(new JMethod(9302,"forge/game/spellability/SpellAbility","setConditions","(Lforge/game/spellability/SpellAbilityCondition;)V",17,2,2,new JHandler[]{},M9302));
c.Add(new JMethod(9303,"forge/game/spellability/SpellAbility","metConditions","()Z",1,1,2,new JHandler[]{},M9303));
c.Add(new JMethod(9304,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;",1,1,1,new JHandler[]{},M9304));
c.Add(new JMethod(9305,"forge/game/spellability/SpellAbility","clearManaPaid","()V",17,1,1,new JHandler[]{},M9305));
c.Add(new JMethod(9306,"forge/game/spellability/SpellAbility","getSpendPhyrexianMana","()I",17,1,1,new JHandler[]{},M9306));
c.Add(new JMethod(9307,"forge/game/spellability/SpellAbility","setSpendPhyrexianMana","(Z)V",17,2,3,new JHandler[]{},M9307));
c.Add(new JMethod(9308,"forge/game/spellability/SpellAbility","getAmountLifePaid","()I",17,1,1,new JHandler[]{},M9308));
c.Add(new JMethod(9309,"forge/game/spellability/SpellAbility","setPaidLife","(I)V",17,2,2,new JHandler[]{},M9309));
}

private static void Add3(JClass c){
c.Add(new JMethod(9310,"forge/game/spellability/SpellAbility","applyPayingManaEffects","()V",17,9,7,new JHandler[]{},M9310));
c.Add(new JMethod(9311,"forge/game/spellability/SpellAbility","getPayingColors","()Lforge/card/ColorSet;",1,4,2,new JHandler[]{},M9311));
c.Add(new JMethod(9312,"forge/game/spellability/SpellAbility","getPayingManaAbilities","()Ljava/util/List;",1,1,1,new JHandler[]{},M9312));
c.Add(new JMethod(9313,"forge/game/spellability/SpellAbility","getPaidHash","()Lcom/google/common/collect/TreeBasedTable;",1,1,1,new JHandler[]{},M9313));
c.Add(new JMethod(9314,"forge/game/spellability/SpellAbility","setPaidHash","(Lcom/google/common/collect/TreeBasedTable;)V",1,2,2,new JHandler[]{},M9314));
c.Add(new JMethod(9315,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;)Ljava/lang/Iterable;",1,2,2,new JHandler[]{},M9315));
c.Add(new JMethod(9316,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;",1,3,3,new JHandler[]{},M9316));
c.Add(new JMethod(9317,"forge/game/spellability/SpellAbility","addCostToHashList","(Lforge/game/card/Card;Ljava/lang/String;Z)V",1,4,5,new JHandler[]{},M9317));
c.Add(new JMethod(9318,"forge/game/spellability/SpellAbility","resetPaidHash","()V",1,1,1,new JHandler[]{},M9318));
c.Add(new JMethod(9319,"forge/game/spellability/SpellAbility","getTriggeringObjects","()Ljava/util/Map;",1,1,1,new JHandler[]{},M9319));
c.Add(new JMethod(9320,"forge/game/spellability/SpellAbility","setTriggeringObjects","(Ljava/util/Map;)V",1,2,2,new JHandler[]{},M9320));
c.Add(new JMethod(9321,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M9321));
c.Add(new JMethod(9322,"forge/game/spellability/SpellAbility","setTriggeringObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V",1,3,3,new JHandler[]{},M9322));
c.Add(new JMethod(9323,"forge/game/spellability/SpellAbility","hasTriggeringObject","(Lforge/game/ability/AbilityKey;)Z",1,2,2,new JHandler[]{},M9323));
c.Add(new JMethod(9324,"forge/game/spellability/SpellAbility","resetTriggeringObjects","()V",1,1,2,new JHandler[]{},M9324));
c.Add(new JMethod(9325,"forge/game/spellability/SpellAbility","getReplacingObjects","()Ljava/util/Map;",1,1,1,new JHandler[]{},M9325));
c.Add(new JMethod(9326,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M9326));
c.Add(new JMethod(9327,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V",1,3,3,new JHandler[]{},M9327));
c.Add(new JMethod(9328,"forge/game/spellability/SpellAbility","setReplacingObjects","(Ljava/util/Map;)V",1,2,2,new JHandler[]{},M9328));
c.Add(new JMethod(9329,"forge/game/spellability/SpellAbility","setReplacingObjectsFrom","(Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V",129,7,4,new JHandler[]{},M9329));
c.Add(new JMethod(9330,"forge/game/spellability/SpellAbility","resetOnceResolved","()V",1,1,2,new JHandler[]{},M9330));
c.Add(new JMethod(9331,"forge/game/spellability/SpellAbility","yieldKey","()Ljava/lang/String;",1,1,2,new JHandler[]{},M9331));
c.Add(new JMethod(9332,"forge/game/spellability/SpellAbility","getStackDescription","()Ljava/lang/String;",1,2,3,new JHandler[]{},M9332));
c.Add(new JMethod(9333,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V",1,3,2,new JHandler[]{},M9333));
c.Add(new JMethod(9334,"forge/game/spellability/SpellAbility","getOriginalStackDescription","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9334));
c.Add(new JMethod(9335,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9335));
c.Add(new JMethod(9336,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V",1,2,4,new JHandler[]{},M9336));
c.Add(new JMethod(9337,"forge/game/spellability/SpellAbility","getOriginalDescription","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9337));
c.Add(new JMethod(9338,"forge/game/spellability/SpellAbility","getCostDescription","()Ljava/lang/String;",1,5,4,new JHandler[]{},M9338));
c.Add(new JMethod(9339,"forge/game/spellability/SpellAbility","rebuiltDescription","()V",1,2,3,new JHandler[]{},M9339));
c.Add(new JMethod(9340,"forge/game/spellability/SpellAbility","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9340));
c.Add(new JMethod(9341,"forge/game/spellability/SpellAbility","toUnsuppressedString","()Ljava/lang/String;",1,6,4,new JHandler[]{},M9341));
c.Add(new JMethod(9342,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;",1,1,1,new JHandler[]{},M9342));
c.Add(new JMethod(9343,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V",1,2,2,new JHandler[]{},M9343));
c.Add(new JMethod(9344,"forge/game/spellability/SpellAbility","getAdditionalAbilities","()Ljava/util/Map;",1,1,1,new JHandler[]{},M9344));
c.Add(new JMethod(9345,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;",1,2,2,new JHandler[]{},M9345));
c.Add(new JMethod(9346,"forge/game/spellability/SpellAbility","hasAdditionalAbility","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M9346));
c.Add(new JMethod(9347,"forge/game/spellability/SpellAbility","setAdditionalAbility","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)V",1,3,3,new JHandler[]{},M9347));
c.Add(new JMethod(9348,"forge/game/spellability/SpellAbility","getAdditionalAbilityLists","()Ljava/util/Map;",1,1,1,new JHandler[]{},M9348));
c.Add(new JMethod(9349,"forge/game/spellability/SpellAbility","getAdditionalAbilityList","(Ljava/lang/String;)Ljava/util/List;",1,2,2,new JHandler[]{},M9349));
c.Add(new JMethod(9350,"forge/game/spellability/SpellAbility","setAdditionalAbilityList","(Ljava/lang/String;Ljava/util/List;)V",1,6,3,new JHandler[]{},M9350));
c.Add(new JMethod(9351,"forge/game/spellability/SpellAbility","appendSubAbility","(Lforge/game/spellability/AbilitySub;)V",1,2,2,new JHandler[]{},M9351));
c.Add(new JMethod(9352,"forge/game/spellability/SpellAbility","isBasicSpell","()Z",1,1,1,new JHandler[]{},M9352));
c.Add(new JMethod(9353,"forge/game/spellability/SpellAbility","setBasicSpell","(Z)V",1,2,2,new JHandler[]{},M9353));
c.Add(new JMethod(9354,"forge/game/spellability/SpellAbility","getMayPlayOption","()Lforge/game/card/CardPlayOption;",1,1,1,new JHandler[]{},M9354));
c.Add(new JMethod(9355,"forge/game/spellability/SpellAbility","getMayPlay","()Lforge/game/staticability/StaticAbility;",1,1,1,new JHandler[]{},M9355));
c.Add(new JMethod(9356,"forge/game/spellability/SpellAbility","setMayPlay","(Lforge/game/card/CardPlayOption;)V",1,2,2,new JHandler[]{},M9356));
c.Add(new JMethod(9357,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;",1,1,3,new JHandler[]{},M9357));
c.Add(new JMethod(9358,"forge/game/spellability/SpellAbility","copy","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;",1,2,4,new JHandler[]{},M9358));
c.Add(new JMethod(9359,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;",1,3,4,new JHandler[]{},M9359));
c.Add(new JMethod(9360,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;ZZ)Lforge/game/spellability/SpellAbility;",1,4,5,new JHandler[]{},M9360));
c.Add(new JMethod(9361,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;Z)Lforge/game/spellability/SpellAbility;",1,4,5,new JHandler[]{},M9361));
c.Add(new JMethod(9362,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;ZZ)Lforge/game/spellability/SpellAbility;",1,7,6,new JHandler[]{new JHandler(3,350,353,"java/lang/CloneNotSupportedException")},M9362));
c.Add(new JMethod(9363,"forge/game/spellability/SpellAbility","copyWithNoManaCost","()Lforge/game/spellability/SpellAbility;",1,1,2,new JHandler[]{},M9363));
c.Add(new JMethod(9364,"forge/game/spellability/SpellAbility","copyWithNoManaCost","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;",1,3,3,new JHandler[]{},M9364));
c.Add(new JMethod(9365,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;",1,3,2,new JHandler[]{},M9365));
c.Add(new JMethod(9366,"forge/game/spellability/SpellAbility","copyWithManaCostReplaced","(Lforge/game/player/Player;Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;",1,5,2,new JHandler[]{},M9366));
c.Add(new JMethod(9367,"forge/game/spellability/SpellAbility","isTrigger","()Z",1,1,1,new JHandler[]{},M9367));
c.Add(new JMethod(9368,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;",1,1,1,new JHandler[]{},M9368));
c.Add(new JMethod(9369,"forge/game/spellability/SpellAbility","setTrigger","(Lforge/game/trigger/Trigger;)V",1,2,2,new JHandler[]{},M9369));
c.Add(new JMethod(9370,"forge/game/spellability/SpellAbility","isOptionalTrigger","()Z",1,1,1,new JHandler[]{},M9370));
c.Add(new JMethod(9371,"forge/game/spellability/SpellAbility","setOptionalTrigger","(Z)V",1,2,2,new JHandler[]{},M9371));
c.Add(new JMethod(9372,"forge/game/spellability/SpellAbility","getSourceTrigger","()I",1,1,1,new JHandler[]{},M9372));
c.Add(new JMethod(9373,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z",1,1,1,new JHandler[]{},M9373));
}

private static void Add4(JClass c){
c.Add(new JMethod(9374,"forge/game/spellability/SpellAbility","getReplacementEffect","()Lforge/game/replacement/ReplacementEffect;",1,1,1,new JHandler[]{},M9374));
c.Add(new JMethod(9375,"forge/game/spellability/SpellAbility","setReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)V",1,2,2,new JHandler[]{},M9375));
c.Add(new JMethod(9376,"forge/game/spellability/SpellAbility","isMandatory","()Z",1,1,1,new JHandler[]{},M9376));
c.Add(new JMethod(9377,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;)Z",17,2,3,new JHandler[]{},M9377));
c.Add(new JMethod(9378,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;Z)Z",17,14,5,new JHandler[]{},M9378));
c.Add(new JMethod(9379,"forge/game/spellability/SpellAbility","isWrapper","()Z",1,1,1,new JHandler[]{},M9379));
c.Add(new JMethod(9380,"forge/game/spellability/SpellAbility","getPipsToReduce","()Ljava/util/List;",1,1,1,new JHandler[]{},M9380));
c.Add(new JMethod(9381,"forge/game/spellability/SpellAbility","clearPipsToReduce","()V",17,1,1,new JHandler[]{},M9381));
c.Add(new JMethod(9382,"forge/game/spellability/SpellAbility","getTappedForConvoke","()Lforge/game/card/CardCollection;",1,1,1,new JHandler[]{},M9382));
c.Add(new JMethod(9383,"forge/game/spellability/SpellAbility","addTappedForConvoke","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M9383));
c.Add(new JMethod(9384,"forge/game/spellability/SpellAbility","clearTappedForConvoke","()V",1,1,1,new JHandler[]{},M9384));
c.Add(new JMethod(9385,"forge/game/spellability/SpellAbility","isEmerge","()Z",1,1,2,new JHandler[]{},M9385));
c.Add(new JMethod(9386,"forge/game/spellability/SpellAbility","getSacrificedAsEmerge","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M9386));
c.Add(new JMethod(9387,"forge/game/spellability/SpellAbility","setSacrificedAsEmerge","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M9387));
c.Add(new JMethod(9388,"forge/game/spellability/SpellAbility","resetSacrificedAsEmerge","()V",1,1,2,new JHandler[]{},M9388));
c.Add(new JMethod(9389,"forge/game/spellability/SpellAbility","isOffering","()Z",1,1,2,new JHandler[]{},M9389));
c.Add(new JMethod(9390,"forge/game/spellability/SpellAbility","getSacrificedAsOffering","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M9390));
c.Add(new JMethod(9391,"forge/game/spellability/SpellAbility","setSacrificedAsOffering","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M9391));
c.Add(new JMethod(9392,"forge/game/spellability/SpellAbility","resetSacrificedAsOffering","()V",1,1,2,new JHandler[]{},M9392));
c.Add(new JMethod(9393,"forge/game/spellability/SpellAbility","getSplicedCards","()Lforge/game/card/CardCollection;",1,1,1,new JHandler[]{},M9393));
c.Add(new JMethod(9394,"forge/game/spellability/SpellAbility","addSplicedCards","(Lforge/game/card/Card;)V",1,2,3,new JHandler[]{},M9394));
c.Add(new JMethod(9395,"forge/game/spellability/SpellAbility","knownDetermineDefined","(Ljava/lang/String;)Lforge/game/card/CardCollection;",1,8,3,new JHandler[]{},M9395));
c.Add(new JMethod(9396,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;",1,2,2,new JHandler[]{},M9396));
c.Add(new JMethod(9397,"forge/game/spellability/SpellAbility","getTailAbility","()Lforge/game/spellability/SpellAbility;",1,2,1,new JHandler[]{},M9397));
c.Add(new JMethod(9398,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;",1,1,1,new JHandler[]{},M9398));
c.Add(new JMethod(9399,"forge/game/spellability/SpellAbility","getSVarFallback","(Ljava/lang/String;)Ljava/util/List;",4,4,3,new JHandler[]{},M9399));
c.Add(new JMethod(9400,"forge/game/spellability/SpellAbility","isUndoable","()Z",1,1,1,new JHandler[]{},M9400));
c.Add(new JMethod(9401,"forge/game/spellability/SpellAbility","setUndoable","(Z)V",1,2,2,new JHandler[]{},M9401));
c.Add(new JMethod(9402,"forge/game/spellability/SpellAbility","undo","()Z",1,1,2,new JHandler[]{},M9402));
c.Add(new JMethod(9403,"forge/game/spellability/SpellAbility","isCastFromPlayEffect","()Z",1,1,1,new JHandler[]{},M9403));
c.Add(new JMethod(9404,"forge/game/spellability/SpellAbility","setCastFromPlayEffect","(Z)V",1,2,2,new JHandler[]{},M9404));
c.Add(new JMethod(9405,"forge/game/spellability/SpellAbility","isCopied","()Z",1,1,1,new JHandler[]{},M9405));
c.Add(new JMethod(9406,"forge/game/spellability/SpellAbility","setCopied","(Z)V",1,2,2,new JHandler[]{},M9406));
c.Add(new JMethod(9407,"forge/game/spellability/SpellAbility","isMayChooseNewTargets","()Z",1,1,1,new JHandler[]{},M9407));
c.Add(new JMethod(9408,"forge/game/spellability/SpellAbility","setMayChooseNewTargets","(Z)V",1,2,2,new JHandler[]{},M9408));
c.Add(new JMethod(9409,"forge/game/spellability/SpellAbility","isAnnouncing","(Ljava/lang/String;)Z",1,8,2,new JHandler[]{},M9409));
c.Add(new JMethod(9410,"forge/game/spellability/SpellAbility","addAnnounceVar","(Ljava/lang/String;)V",1,8,4,new JHandler[]{},M9410));
c.Add(new JMethod(9411,"forge/game/spellability/SpellAbility","canBeTargetedBy","(Lforge/game/spellability/SpellAbility;)Z",1,2,2,new JHandler[]{},M9411));
c.Add(new JMethod(9412,"forge/game/spellability/SpellAbility","usesTargeting","()Z",1,1,1,new JHandler[]{},M9412));
c.Add(new JMethod(9413,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;",1,1,1,new JHandler[]{},M9413));
c.Add(new JMethod(9414,"forge/game/spellability/SpellAbility","setTargetRestrictions","(Lforge/game/spellability/TargetRestrictions;)V",1,2,2,new JHandler[]{},M9414));
c.Add(new JMethod(9415,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;",1,1,1,new JHandler[]{},M9415));
c.Add(new JMethod(9416,"forge/game/spellability/SpellAbility","setTargets","(Lforge/game/spellability/TargetChoices;)V",1,2,2,new JHandler[]{},M9416));
c.Add(new JMethod(9417,"forge/game/spellability/SpellAbility","resetTargets","()V",1,1,3,new JHandler[]{},M9417));
c.Add(new JMethod(9418,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z",1,1,2,new JHandler[]{},M9418));
c.Add(new JMethod(9419,"forge/game/spellability/SpellAbility","addDividedAllocation","(Lforge/game/GameObject;Ljava/lang/Integer;)V",17,3,3,new JHandler[]{},M9419));
c.Add(new JMethod(9420,"forge/game/spellability/SpellAbility","getDividedValue","(Lforge/game/GameObject;)Ljava/lang/Integer;",1,2,2,new JHandler[]{},M9420));
c.Add(new JMethod(9421,"forge/game/spellability/SpellAbility","getTotalDividedValue","()I",1,1,1,new JHandler[]{},M9421));
c.Add(new JMethod(9422,"forge/game/spellability/SpellAbility","getDividedValue","()Ljava/lang/Integer;",1,1,1,new JHandler[]{},M9422));
c.Add(new JMethod(9423,"forge/game/spellability/SpellAbility","getStillToDivide","()I",1,1,2,new JHandler[]{},M9423));
c.Add(new JMethod(9424,"forge/game/spellability/SpellAbility","resetFirstTarget","(Lforge/game/GameObject;Lforge/game/spellability/SpellAbility;)V",1,4,4,new JHandler[]{},M9424));
c.Add(new JMethod(9425,"forge/game/spellability/SpellAbility","canAddMoreTarget","()Z",1,1,2,new JHandler[]{},M9425));
c.Add(new JMethod(9426,"forge/game/spellability/SpellAbility","isZeroTargets","()Z",1,1,1,new JHandler[]{},M9426));
c.Add(new JMethod(9427,"forge/game/spellability/SpellAbility","isMinTargetChosen","()Z",1,1,3,new JHandler[]{},M9427));
c.Add(new JMethod(9428,"forge/game/spellability/SpellAbility","isMaxTargetChosen","()Z",1,1,3,new JHandler[]{},M9428));
c.Add(new JMethod(9429,"forge/game/spellability/SpellAbility","getMinTargets","()I",1,1,3,new JHandler[]{},M9429));
c.Add(new JMethod(9430,"forge/game/spellability/SpellAbility","getMaxTargets","()I",1,1,3,new JHandler[]{},M9430));
c.Add(new JMethod(9431,"forge/game/spellability/SpellAbility","isTargetNumberValid","()Z",1,1,2,new JHandler[]{},M9431));
c.Add(new JMethod(9432,"forge/game/spellability/SpellAbility","getAllTargetChoices","()Ljava/util/List;",17,3,2,new JHandler[]{},M9432));
c.Add(new JMethod(9433,"forge/game/spellability/SpellAbility","getTargetCard","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M9433));
c.Add(new JMethod(9434,"forge/game/spellability/SpellAbility","setTargetCard","(Lforge/game/card/Card;)V",1,2,3,new JHandler[]{},M9434));
c.Add(new JMethod(9435,"forge/game/spellability/SpellAbility","findTargetedCards","()Lforge/game/card/CardCollectionView;",1,4,2,new JHandler[]{},M9435));
c.Add(new JMethod(9436,"forge/game/spellability/SpellAbility","getSATargetingCard","()Lforge/game/spellability/SpellAbility;",1,1,1,new JHandler[]{},M9436));
c.Add(new JMethod(9437,"forge/game/spellability/SpellAbility","getParentTargetingCard","()Lforge/game/spellability/SpellAbility;",1,2,1,new JHandler[]{},M9437));
}

private static void Add5(JClass c){
c.Add(new JMethod(9438,"forge/game/spellability/SpellAbility","getSATargetingSA","()Lforge/game/spellability/SpellAbility;",1,1,1,new JHandler[]{},M9438));
c.Add(new JMethod(9439,"forge/game/spellability/SpellAbility","getParentTargetingSA","()Lforge/game/spellability/SpellAbility;",1,2,1,new JHandler[]{},M9439));
c.Add(new JMethod(9440,"forge/game/spellability/SpellAbility","getSATargetingPlayer","()Lforge/game/spellability/SpellAbility;",1,1,1,new JHandler[]{},M9440));
c.Add(new JMethod(9441,"forge/game/spellability/SpellAbility","getParentTargetingPlayer","()Lforge/game/spellability/SpellAbility;",1,2,1,new JHandler[]{},M9441));
c.Add(new JMethod(9442,"forge/game/spellability/SpellAbility","getUniqueTargets","()Ljava/util/List;",17,3,2,new JHandler[]{},M9442));
c.Add(new JMethod(9443,"forge/game/spellability/SpellAbility","canTargetSpellAbility","(Lforge/game/spellability/SpellAbility;)Z",1,9,5,new JHandler[]{},M9443));
c.Add(new JMethod(9444,"forge/game/spellability/SpellAbility","isTargeting","(Lforge/game/GameObject;)Z",1,3,2,new JHandler[]{},M9444));
c.Add(new JMethod(9445,"forge/game/spellability/SpellAbility","setupNewTargets","(Lforge/game/player/Player;)Z",1,4,4,new JHandler[]{},M9445));
c.Add(new JMethod(9446,"forge/game/spellability/SpellAbility","setupTargets","()Z",1,5,5,new JHandler[]{},M9446));
c.Add(new JMethod(9447,"forge/game/spellability/SpellAbility","clearTargets","()V",17,1,4,new JHandler[]{},M9447));
c.Add(new JMethod(9448,"forge/game/spellability/SpellAbility","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z",17,14,5,new JHandler[]{},M9448));
c.Add(new JMethod(9449,"forge/game/spellability/SpellAbility","hasProperty","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z",1,5,5,new JHandler[]{},M9449));
c.Add(new JMethod(9450,"forge/game/spellability/SpellAbility","tracksManaSpent","()Z",1,2,2,new JHandler[]{},M9450));
c.Add(new JMethod(9451,"forge/game/spellability/SpellAbility","getTotalManaSpent","()I",1,1,1,new JHandler[]{},M9451));
c.Add(new JMethod(9452,"forge/game/spellability/SpellAbility","getChosenList","()Ljava/util/List;",1,1,1,new JHandler[]{},M9452));
c.Add(new JMethod(9453,"forge/game/spellability/SpellAbility","setChosenList","(Ljava/util/List;)V",1,2,2,new JHandler[]{},M9453));
c.Add(new JMethod(9454,"forge/game/spellability/SpellAbility","changeText","()V",1,5,3,new JHandler[]{},M9454));
c.Add(new JMethod(9455,"forge/game/spellability/SpellAbility","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V",1,7,3,new JHandler[]{},M9455));
c.Add(new JMethod(9456,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V",1,6,2,new JHandler[]{},M9456));
c.Add(new JMethod(9457,"forge/game/spellability/SpellAbility","getView","()Lforge/game/spellability/SpellAbilityView;",1,1,2,new JHandler[]{},M9457));
c.Add(new JMethod(9458,"forge/game/spellability/SpellAbility","compareTo","(Lforge/game/spellability/SpellAbility;)I",1,2,2,new JHandler[]{},M9458));
c.Add(new JMethod(9459,"forge/game/spellability/SpellAbility","calculateScoreForManaAbility","()I",1,4,3,new JHandler[]{},M9459));
c.Add(new JMethod(9460,"forge/game/spellability/SpellAbility","getDamageMap","()Lforge/game/card/CardDamageTable;",1,1,1,new JHandler[]{},M9460));
c.Add(new JMethod(9461,"forge/game/spellability/SpellAbility","getPreventMap","()Lforge/game/card/CardDamageTable;",1,1,1,new JHandler[]{},M9461));
c.Add(new JMethod(9462,"forge/game/spellability/SpellAbility","getCounterTable","()Lforge/game/GameEntityCounterTable;",1,1,1,new JHandler[]{},M9462));
c.Add(new JMethod(9463,"forge/game/spellability/SpellAbility","getChangeZoneTable","()Lforge/game/card/CardZoneTable;",1,1,1,new JHandler[]{},M9463));
c.Add(new JMethod(9464,"forge/game/spellability/SpellAbility","getLoseLifeMap","()Ljava/util/Map;",1,1,1,new JHandler[]{},M9464));
c.Add(new JMethod(9465,"forge/game/spellability/SpellAbility","setDamageMap","(Lforge/game/card/CardDamageTable;)V",1,2,2,new JHandler[]{},M9465));
c.Add(new JMethod(9466,"forge/game/spellability/SpellAbility","setPreventMap","(Lforge/game/card/CardDamageTable;)V",1,2,2,new JHandler[]{},M9466));
c.Add(new JMethod(9467,"forge/game/spellability/SpellAbility","setCounterTable","(Lforge/game/GameEntityCounterTable;)V",1,2,2,new JHandler[]{},M9467));
c.Add(new JMethod(9468,"forge/game/spellability/SpellAbility","setChangeZoneTable","(Lforge/game/card/CardZoneTable;)V",1,2,2,new JHandler[]{},M9468));
c.Add(new JMethod(9469,"forge/game/spellability/SpellAbility","setLoseLifeMap","(Ljava/util/Map;)V",1,2,2,new JHandler[]{},M9469));
c.Add(new JMethod(9470,"forge/game/spellability/SpellAbility","getOriginalAbility","()Lforge/game/spellability/SpellAbility;",1,1,2,new JHandler[]{},M9470));
c.Add(new JMethod(9471,"forge/game/spellability/SpellAbility","setOriginalAbility","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M9471));
c.Add(new JMethod(9472,"forge/game/spellability/SpellAbility","getGrantorStatic","()Lforge/game/staticability/StaticAbility;",1,1,1,new JHandler[]{},M9472));
c.Add(new JMethod(9473,"forge/game/spellability/SpellAbility","setGrantorStatic","(Lforge/game/staticability/StaticAbility;)V",1,2,2,new JHandler[]{},M9473));
c.Add(new JMethod(9474,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z",1,3,2,new JHandler[]{},M9474));
c.Add(new JMethod(9475,"forge/game/spellability/SpellAbility","getAlternativeCost","()Lforge/game/spellability/AlternativeCost;",1,2,1,new JHandler[]{},M9475));
c.Add(new JMethod(9476,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V",1,2,2,new JHandler[]{},M9476));
c.Add(new JMethod(9477,"forge/game/spellability/SpellAbility","getXManaCostPaid","()Ljava/lang/Integer;",1,1,1,new JHandler[]{},M9477));
c.Add(new JMethod(9478,"forge/game/spellability/SpellAbility","setXManaCostPaid","(Ljava/lang/Integer;)V",1,2,2,new JHandler[]{},M9478));
c.Add(new JMethod(9479,"forge/game/spellability/SpellAbility","getXColor","()Ljava/lang/String;",1,7,2,new JHandler[]{},M9479));
c.Add(new JMethod(9480,"forge/game/spellability/SpellAbility","isSkip","()Z",1,1,1,new JHandler[]{},M9480));
c.Add(new JMethod(9481,"forge/game/spellability/SpellAbility","setSkip","(Z)V",1,2,2,new JHandler[]{},M9481));
c.Add(new JMethod(9482,"forge/game/spellability/SpellAbility","canCastTiming","(Lforge/game/player/Player;)Z",1,2,3,new JHandler[]{},M9482));
c.Add(new JMethod(9483,"forge/game/spellability/SpellAbility","canCastTiming","(Lforge/game/card/Card;Lforge/game/player/Player;)Z",1,3,3,new JHandler[]{},M9483));
c.Add(new JMethod(9484,"forge/game/spellability/SpellAbility","withFlash","(Lforge/game/card/Card;Lforge/game/player/Player;)Z",1,3,3,new JHandler[]{},M9484));
c.Add(new JMethod(9485,"forge/game/spellability/SpellAbility","checkRestrictions","(Lforge/game/player/Player;)Z",1,2,3,new JHandler[]{},M9485));
c.Add(new JMethod(9486,"forge/game/spellability/SpellAbility","checkRestrictions","(Lforge/game/card/Card;Lforge/game/player/Player;)Z",1,3,1,new JHandler[]{},M9486));
c.Add(new JMethod(9487,"forge/game/spellability/SpellAbility","addRollbackEffect","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M9487));
c.Add(new JMethod(9488,"forge/game/spellability/SpellAbility","rollback","()V",1,3,3,new JHandler[]{},M9488));
c.Add(new JMethod(9489,"forge/game/spellability/SpellAbility","isHidden","()Z",1,2,2,new JHandler[]{},M9489));
c.Add(new JMethod(9490,"forge/game/spellability/SpellAbility","isLegalAfterStack","()Z",1,1,3,new JHandler[]{},M9490));
c.Add(new JMethod(9491,"forge/game/spellability/SpellAbility","isCounterableBy","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M9491));
c.Add(new JMethod(9492,"forge/game/spellability/SpellAbility","getAlternateHost","(Lforge/game/card/Card;)Lforge/game/card/Card;",1,2,1,new JHandler[]{},M9492));
c.Add(new JMethod(9493,"forge/game/spellability/SpellAbility","hasOptionalKeywordAmount","(Lforge/game/keyword/KeywordInterface;)Z",1,4,5,new JHandler[]{},M9493));
c.Add(new JMethod(9494,"forge/game/spellability/SpellAbility","hasOptionalKeywordAmount","(Lforge/game/keyword/Keyword;)Z",1,2,2,new JHandler[]{},M9494));
c.Add(new JMethod(9495,"forge/game/spellability/SpellAbility","getOptionalKeywords","()Ljava/util/Set;",1,1,1,new JHandler[]{},M9495));
c.Add(new JMethod(9496,"forge/game/spellability/SpellAbility","getOptionalKeywordAmount","(Lforge/game/keyword/KeywordInterface;)I",1,4,5,new JHandler[]{},M9496));
c.Add(new JMethod(9497,"forge/game/spellability/SpellAbility","getOptionalKeywordAmount","(Lforge/game/keyword/Keyword;)I",1,2,2,new JHandler[]{},M9497));
c.Add(new JMethod(9498,"forge/game/spellability/SpellAbility","setOptionalKeywordAmount","(Lforge/game/keyword/KeywordInterface;I)V",1,5,5,new JHandler[]{},M9498));
c.Add(new JMethod(9499,"forge/game/spellability/SpellAbility","clearOptionalKeywordAmount","()V",1,1,1,new JHandler[]{},M9499));
c.Add(new JMethod(9500,"forge/game/spellability/SpellAbility","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9500));
c.Add(new JMethod(9501,"forge/game/spellability/SpellAbility","setName","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M9501));
}

private static void Add6(JClass c){
c.Add(new JMethod(9502,"forge/game/spellability/SpellAbility","getMaxWaterbend","()Ljava/lang/Integer;",1,1,1,new JHandler[]{},M9502));
c.Add(new JMethod(9503,"forge/game/spellability/SpellAbility","setMaxWaterbend","(Lforge/game/cost/Cost;)V",1,2,4,new JHandler[]{},M9503));
c.Add(new JMethod(9504,"forge/game/spellability/SpellAbility","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M9504));
c.Add(new JMethod(9505,"forge/game/spellability/SpellAbility","lambda$getOptionalKeywordAmount$0","(Ljava/lang/Integer;)I",4106,1,1,new JHandler[]{},M9505));
c.Add(new JMethod(9506,"forge/game/spellability/SpellAbility","<clinit>","()V",8,0,1,new JHandler[]{},M9506));
}

internal static JStep M9182(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/spellability/SpellAbility","maxId","I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/SpellAbility","maxId","I"));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/spellability/SpellAbility","maxId","I"))return JStep.Continue;rt.PutStatic("forge/game/spellability/SpellAbility","maxId","I",f.Pop());f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9183(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","lastStateBattlefield","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9184(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",9);}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","lastStateBattlefield","Lforge/game/card/CardCollection;",value);f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9185(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","lastStateGraveyard","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9186(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",9);}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","lastStateGraveyard","Lforge/game/card/CardCollection;",value);f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9187(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","lastStateBattlefield","Lforge/game/card/CardCollection;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","lastStateGraveyard","Lforge/game/card/CardCollection;",value);f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9188(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbilityView;Lforge/game/card/CardState;)V","invokespecial",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9189(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbilityView;Lforge/game/card/CardState;)V","invokespecial",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9190(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/CardTraitBase","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("")));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","originalDescription","Ljava/lang/String;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("")));f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","description","Ljava/lang/String;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("")));f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","originalStackDescription","Ljava/lang/String;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("")));f.Pc=25;continue;}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","stackDescription","Ljava/lang/String;",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","spentPhyrexian","I",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","paidLifeAmount","I",value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(null));f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","splicedCards","Lforge/game/card/CardCollection;",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","basicSpell","Z",value);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","optionalTrigger","Z",value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(null));f.Pc=55;continue;}
case 55:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","altCost","Lforge/game/spellability/AlternativeCost;",value);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.ClassObject("forge/game/spellability/OptionalCost")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",64);}
case 64:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","optionalCosts","Ljava/util/EnumSet;",value);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",71);}
case 71:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","optionalKeywordAmount","Lcom/google/common/collect/Table;",value);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","aftermath","Z",value);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(JValue.I(0));f.Pc=81;continue;}
case 81:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","skip","Z",value);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbilityCondition"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbilityCondition")));f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","<init>","()V","invokespecial",92);}
case 92:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","conditions","Lforge/game/spellability/SpellAbilityCondition;",value);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",99);}
case 99:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilities","Ljava/util/Map;",value);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",106);}
case 106:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilityLists","Ljava/util/Map;",value);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(JValue.R(null));f.Pc=111;continue;}
case 111:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","api","Lforge/game/ability/ApiType;",value);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",118);}
case 118:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","payingMana","Ljava/util/List;",value);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",125);}
case 125:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","paidAbilities","Ljava/util/List;",value);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(null));f.Pc=130;continue;}
case 130:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","xManaCostPaid","Ljava/lang/Integer;",value);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"com/google/common/collect/TreeBasedTable","create","()Lcom/google/common/collect/TreeBasedTable;","invokestatic",137);}
case 137:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","paidLists","Lcom/google/common/collect/TreeBasedTable;",value);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",144);}
case 144:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","triggeringObjects","Ljava/util/EnumMap;",value);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",151);}
case 151:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","replacingObjects","Ljava/util/EnumMap;",value);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9190:155:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",160);}
case 160:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",163);}
case 163:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","pipsToReduce","Lcom/google/common/base/Supplier;",value);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[0]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(null));f.Pc=168;continue;}
case 168:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","chosenList","Ljava/util/List;",value);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9190:172:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",177);}
case 177:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",180);}
case 180:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","tappedForConvoke","Lcom/google/common/base/Supplier;",value);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[0]);f.Pc=184;continue;}
case 184:{f.Push(JValue.I(0));f.Pc=185;continue;}
case 185:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","isCopied","Z",value);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{f.Push(JValue.I(0));f.Pc=190;continue;}
case 190:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","mayChooseNewTargets","Z",value);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[0]);f.Pc=194;continue;}
case 194:{f.Push(JValue.I(0));f.Pc=195;continue;}
case 195:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","isCastFromPlayEffect","Z",value);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[0]);f.Pc=199;continue;}
case 199:{if(!rt.EnsureInitialized(f,"forge/game/spellability/TargetChoices"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/TargetChoices")));f.Pc=202;continue;}
case 202:{f.StackOp("dup");f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/spellability/TargetChoices","<init>","()V","invokespecial",206);}
case 206:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","targetChosen","Lforge/game/spellability/TargetChoices;",value);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[0]);f.Pc=210;continue;}
case 210:{f.Push(JValue.R(null));f.Pc=211;continue;}
case 211:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","dividedValue","Ljava/lang/Integer;",value);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[0]);f.Pc=215;continue;}
case 215:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9190:215:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",220);}
case 220:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",223);}
case 223:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","rollbackEffects","Lcom/google/common/base/Supplier;",value);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[0]);f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String("")));f.Pc=229;continue;}
case 229:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","name","Ljava/lang/String;",value);f.Pc=232;continue;}
case 232:{f.Push(f.Locals[0]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/spellability/SpellAbility","nextId","()I","invokestatic",236);}
case 236:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","id","I",value);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[0]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[1]);f.Pc=241;continue;}
case 241:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","hostCard","Lforge/game/card/Card;",value);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{f.Push(f.Locals[2]);f.Pc=246;continue;}
case 246:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","payCosts","Lforge/game/cost/Cost;",value);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[4]);f.Pc=251;continue;}
case 251:{f.Pc=f.Pop().Reference==null?260:254;continue;}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[4]);f.Pc=257;continue;}
case 257:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","cardState","Lforge/game/card/CardState;",value);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[3]);f.Pc=261;continue;}
case 261:{f.Pc=f.Pop().Reference!=null?273:264;continue;}
case 264:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbilityView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbilityView")));f.Pc=267;continue;}
case 267:{f.StackOp("dup");f.Pc=268;continue;}
case 268:{f.Push(f.Locals[0]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","<init>","(Lforge/game/spellability/SpellAbility;)V","invokespecial",272);}
case 272:{f.Locals[3]=f.Pop();f.Pc=273;continue;}
case 273:{f.Push(f.Locals[0]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[3]);f.Pc=275;continue;}
case 275:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","view","Lforge/game/spellability/SpellAbilityView;",value);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[0]);f.Pc=279;continue;}
case 279:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=282;continue;}
case 282:{f.Pc=f.Pop().Int!=0?296:285;continue;}
case 285:{f.Push(f.Locals[0]);f.Pc=286;continue;}
case 286:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbilityRestriction"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbilityRestriction")));f.Pc=289;continue;}
case 289:{f.StackOp("dup");f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","<init>","()V","invokespecial",293);}
case 293:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","restrictions","Lforge/game/spellability/SpellAbilityRestriction;",value);f.Pc=296;continue;}
case 296:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9191(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","id","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9192(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(31));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(31));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/spellability/SpellAbility","CLASS_HASH","I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/SpellAbility","CLASS_HASH","I"));f.Pc=7;continue;}
case 7:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=8;continue;}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getId","()I","invokevirtual",13);}
case 13:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9193(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?25:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","id","I"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","id","I"));f.Pc=18;continue;}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9194(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","hostCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?9:8;continue;}
case 8:{return JStep.ReturnVoid;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/CardTraitBase","setHostCard","(Lforge/game/card/Card;)V","invokespecial",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","manaPart","Lforge/game/spellability/AbilityManaPart;"));f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Reference==null?29:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","manaPart","Lforge/game/spellability/AbilityManaPart;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","setSourceCard","(Lforge/game/card/Card;)V","invokevirtual",29);}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Reference==null?44:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/AbilitySub","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",44);}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilities","Ljava/util/Map;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",53);}
case 53:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",58);}
case 58:{f.Locals[2]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?94:68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Locals[3]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",82);}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?91:86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",91);}
case 91:{f.Pc=59;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilityLists","Ljava/util/Map;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",103);}
case 103:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",108);}
case 108:{f.Locals[2]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",115);}
case 115:{f.Pc=f.Pop().Int==0?179:118;continue;}
case 118:{f.Push(f.Locals[2]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",124);}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{f.Locals[3]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",134);}
case 134:{f.Locals[4]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[4]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",143);}
case 143:{f.Pc=f.Pop().Int==0?176:146;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",153);}
case 153:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=156;continue;}
case 156:{f.Locals[5]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[5]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/spellability/AbilitySub","getHostCard","()Lforge/game/card/Card;","invokevirtual",163);}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?173:167;continue;}
case 167:{f.Push(f.Locals[5]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/spellability/AbilitySub","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",173);}
case 173:{f.Pc=136;continue;}
case 176:{f.Pc=109;continue;}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","view","Lforge/game/spellability/SpellAbilityView;"));f.Pc=183;continue;}
case 183:{f.Push(f.Locals[0]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","updateHostCard","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",187);}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","view","Lforge/game/spellability/SpellAbilityView;"));f.Pc=191;continue;}
case 191:{f.Push(f.Locals[0]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","updateDescription","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",195);}
case 195:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9195(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/CardTraitBase","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?20:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/AbilitySub","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilities","Ljava/util/Map;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",29);}
case 29:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",34);}
case 34:{f.Locals[2]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?62:44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[3]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellAbility","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",59);}
case 59:{f.Pc=35;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilityLists","Ljava/util/Map;"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",71);}
case 71:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",76);}
case 76:{f.Locals[2]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",83);}
case 83:{f.Pc=f.Pop().Int==0?138:86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",92);}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{f.Locals[3]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",102);}
case 102:{f.Locals[4]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[4]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",111);}
case 111:{f.Pc=f.Pop().Int==0?135:114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",121);}
case 121:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=124;continue;}
case 124:{f.Locals[5]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[5]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/spellability/AbilitySub","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",132);}
case 132:{f.Pc=104;continue;}
case 135:{f.Pc=77;continue;}
case 138:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9196(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","api","Lforge/game/ability/ApiType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9197(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","api","Lforge/game/ability/ApiType;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9198(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?30:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?22:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Pc=5;continue;}
case 30:{f.Push(JValue.R(null));f.Pc=31;continue;}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9199(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?27:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","metConditions","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?27:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","canProduce","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?27:25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9200(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","canThisProduce","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?10:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference==null?32:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/AbilitySub","canProduce","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9201(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference!=null?35:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","canPlay","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?35:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isInstantSpeed","()Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?35:33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",39);}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Reference==null?82:44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","metConditions","()Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?82:51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","meetsManaRestrictions","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?82:59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","abilityProducesManaColor","(Lforge/game/spellability/SpellAbility;B)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?82:68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",73);}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","allowsPayingWithShard","(Lforge/game/card/Card;B)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?82:80;continue;}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=86;continue;}
case 86:{f.Pc=f.Pop().Reference==null?105:89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/AbilitySub","isManaAbilityFor","(Lforge/game/spellability/SpellAbility;B)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?105:101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{f.Pc=106;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9202(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?34:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","metConditions","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?34:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","meetsManaRestrictions","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?34:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","cannotCounterPaidWith","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?34:32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Reference==null?56:41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/AbilitySub","isManaCannotCounter","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int==0?56:52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{f.Pc=57;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9203(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference==null?100:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","metConditions","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?100:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Amount")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?46:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("Amount")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",43);}
case 43:{f.Pc=47;continue;}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Int==0?74:53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isAnyMana","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int!=0?74:60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isComboMana","()Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int!=0?74:67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isSpecialMana","()Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int==0?82:74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=78;continue;}
case 78:{f.Locals[2]=f.Pop();f.Pc=79;continue;}
case 79:{f.Pc=100;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","mana","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",88);}
case 88:{f.Push(JValue.R(rt.String(" ")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",94);}
case 94:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=95;continue;}
case 95:{f.Push(f.Locals[4]);f.Pc=97;continue;}
case 97:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=98;continue;}
case 98:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=99;continue;}
case 99:{f.Locals[2]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9204(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",6);}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference==null?30:13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","meetsManaRestrictions","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?30:22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","amountOfManaGenerated","(Z)I","invokevirtual",28);}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=29;continue;}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Reference==null?50:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/AbilitySub","totalAmountOfManaGenerated","(Lforge/game/spellability/SpellAbility;Z)I","invokevirtual",47);}
case 47:{f.Pc=51;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=52;continue;}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9205(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?14:9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","setExpressChoice","(Lforge/card/ColorSet;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Reference==null?29:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/AbilitySub","setManaExpressChoice","(Lforge/card/ColorSet;)V","invokevirtual",29);}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9206(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","manaPart","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9207(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?20:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference!=null?20:16;continue;}
case 16:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",19);}
case 19:{return JStep.Return(f.Pop());}
case 20:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference==null?36:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Reference==null?57:43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/AbilitySub","getAllManaParts","()Ljava/util/List;","invokevirtual",51);}
case 51:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9208(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?18:16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","isPwAbility","()Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?27:25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?68:34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapsForMana","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapsForMana","Lforge/game/trigger/TriggerType;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int!=0?77:50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ManaAdded","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ManaAdded","Lforge/game/trigger/TriggerType;"));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",57);}
case 57:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int!=0?77:66;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int!=0?77:75;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",81);}
case 81:{f.Locals[1]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{f.Pc=f.Pop().Reference==null?95:86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/cost/Cost","movesCardToOrFromLibrary","()Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?95:93;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 95:{f.Push(JValue.I(0));f.Pc=96;continue;}
case 96:{f.Locals[2]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Locals[3]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{f.Pc=f.Pop().Reference==null?143:103;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","manaPart","Lforge/game/spellability/AbilityManaPart;"));f.Pc=107;continue;}
case 107:{f.Pc=f.Pop().Reference==null?112:110;continue;}
case 110:{f.Push(JValue.I(1));f.Pc=111;continue;}
case 111:{f.Locals[2]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[3]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",116);}
case 116:{f.Pc=f.Pop().Reference==null?135:119;continue;}
case 119:{f.Push(f.Locals[3]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",123);}
case 123:{return rt.Call(f,"forge/game/ability/ApiType","getSpellEffect","()Lforge/game/ability/SpellAbilityEffect;","invokevirtual",126);}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",130);}
case 130:{f.Pc=f.Pop().Int==0?135:133;continue;}
case 133:{f.Push(JValue.I(0));f.Pc=134;continue;}
case 134:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",139);}
case 139:{f.Locals[3]=f.Pop();f.Pc=140;continue;}
case 140:{f.Pc=99;continue;}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9209(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","manaPart","Lforge/game/spellability/AbilityManaPart;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9210(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/staticability/StaticAbilityManaRestriction","manaRestriction","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)Z","invokestatic",5);}
case 5:{f.Pc=f.Pop().Int==0?10:8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("ManaRestriction")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?22:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("ManaRestriction")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?70:40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?68:50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/card/Card","getChosenColor","()Ljava/lang/String;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B","invokestatic",61);}
case 61:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?68:64;continue;}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{f.Pc=69;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(null));f.Pc=73;continue;}
case 73:{f.Push(JValue.R(null));f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int!=0?83:81;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9211(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("CantCopy")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?20:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantBeCopied","cantBeCopied","(Lforge/game/card/Card;)Z","invokestatic",17);}
case 17:{f.Pc=f.Pop().Int==0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9213(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","canPlay","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int!=0?15:13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/GameActionUtil","getOptionalCostValues","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",19);}
case 19:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",24);}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?57:34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/OptionalCostValue"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/SpellAbility","canPlayWithOptionalCost","(Lforge/game/spellability/OptionalCostValue;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int==0?54:52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 54:{f.Pc=25;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?120:64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("AlternateCost")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int==0?120:74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/GameActionUtil","getAdditionalCostSpell","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",78);}
case 78:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",83);}
case 83:{f.Locals[2]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",90);}
case 90:{f.Pc=f.Pop().Int==0?120:93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{f.Locals[3]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?117:108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/spellability/SpellAbility","canPlay","()Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?117:115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 117:{f.Pc=84;continue;}
case 120:{f.Push(JValue.I(0));f.Pc=121;continue;}
case 121:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9214(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/spellability/OptionalCostValue;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",12);}
case 12:{return rt.Call(f,"forge/game/GameActionUtil","addOptionalCosts","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lforge/game/spellability/SpellAbility;","invokestatic",15);}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","canPlay","()Z","invokevirtual",18);}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9215(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","canPlay","()Z","invokevirtual",4);}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9216(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9218(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","activatingPlayer","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9219(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?12:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","activatingPlayer","Lforge/game/player/Player;"));f.Pc=9;continue;}
case 9:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?17:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","activatingPlayer","Lforge/game/player/Player;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference==null?32:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/AbilitySub","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilities","Ljava/util/Map;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",41);}
case 41:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",46);}
case 46:{f.Locals[2]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",53);}
case 53:{f.Pc=f.Pop().Int==0?74:56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{f.Locals[3]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",71);}
case 71:{f.Pc=47;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilityLists","Ljava/util/Map;"));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",83);}
case 83:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",88);}
case 88:{f.Locals[2]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",95);}
case 95:{f.Pc=f.Pop().Int==0?150:98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[3]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",114);}
case 114:{f.Locals[4]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",123);}
case 123:{f.Pc=f.Pop().Int==0?147:126;continue;}
case 126:{f.Push(f.Locals[4]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{f.Locals[5]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[5]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[1]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/spellability/AbilitySub","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",144);}
case 144:{f.Pc=116;continue;}
case 147:{f.Pc=89;continue;}
case 150:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9220(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","targetingPlayer","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9221(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","targetingPlayer","Lforge/game/player/Player;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9222(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","choosingPlayer","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9223(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","choosingPlayer","Lforge/game/player/Player;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9224(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","controlledByPlayer","Lorg/apache/commons/lang3/tuple/Pair;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9225(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?19:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",9);}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","controlledByPlayer","Lorg/apache/commons/lang3/tuple/Pair;",value);f.Pc=16;continue;}
case 16:{f.Pc=24;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","controlledByPlayer","Lorg/apache/commons/lang3/tuple/Pair;",value);f.Pc=24;continue;}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9226(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","manaCostBeingPaid","Lforge/game/mana/ManaCostBeingPaid;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9227(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","manaCostBeingPaid","Lforge/game/mana/ManaCostBeingPaid;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9228(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalCosts","Ljava/util/EnumSet;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9229(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalCosts","Ljava/util/EnumSet;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/EnumSet","copyOf","(Ljava/util/EnumSet;)Ljava/util/EnumSet;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","optionalCosts","Ljava/util/EnumSet;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalCosts","Ljava/util/EnumSet;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/EnumSet","add","(Ljava/lang/Object;)Z","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/OptionalCost","getPip","()Ljava/lang/String;","invokevirtual",24);}
case 24:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?52:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","pipsToReduce","Lcom/google/common/base/Supplier;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/OptionalCost","getPip","()Ljava/lang/String;","invokevirtual",46);}
case 46:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9230(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalCosts","Ljava/util/EnumSet;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9231(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9232(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9233(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9234(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9235(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isMorphUp","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?28:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDisguiseUp","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?28:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManifestUp","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?28:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCloakUp","()Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9236(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("MorphUp")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9237(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("DisguiseUp")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9238(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9239(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ManifestUp")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9240(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("CloakUp")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9241(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Unlock")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9242(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","CYCLING","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","CYCLING","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?20:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","TYPECYCLING","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","TYPECYCLING","Lforge/game/keyword/Keyword;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9243(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","BACKUP","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","BACKUP","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9244(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Boast")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9245(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Monstrosity")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9246(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Exhaust")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9247(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("PowerUp")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9248(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","NINJUTSU","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","NINJUTSU","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9249(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("CumulativeUpkeep")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9250(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Bargain","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Bargain","Lforge/game/spellability/OptionalCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9251(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Buyback","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Buyback","Lforge/game/spellability/OptionalCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9252(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?33:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?33:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",24);}
case 24:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","MULTIKICKER","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","MULTIKICKER","Lforge/game/keyword/Keyword;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOptionalKeywordAmount","(Lforge/game/keyword/Keyword;)I","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int<=0?37:33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{f.Pc=38;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9253(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Entwine","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Entwine","Lforge/game/spellability/OptionalCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9254(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Teamwork","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Teamwork","Lforge/game/spellability/OptionalCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9255(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Jumpstart","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Jumpstart","Lforge/game/spellability/OptionalCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9256(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","PromiseGift","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","PromiseGift","Lforge/game/spellability/OptionalCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9257(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Bestow","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Bestow","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9258(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Blitz","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Blitz","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9259(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Dash","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Dash","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9260(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Disturb","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Disturb","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9261(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Escape","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Escape","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9262(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Evoke","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Evoke","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9263(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Freerunning","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Freerunning","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9264(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Impending","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Impending","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9265(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Madness","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Madness","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9266(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Mayhem","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Mayhem","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9267(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Mutate","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Mutate","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9268(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Prowl","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Prowl","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9269(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Sneak","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Sneak","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9270(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Surge","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Surge","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9271(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Spectacle","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Spectacle","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9272(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","BeamMeUp","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","BeamMeUp","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9273(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Flashback","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Flashback","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9274(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Harmonize","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Harmonize","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9275(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9276(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Foretold","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Foretold","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9277(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Warp","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Warp","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9278(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9279(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","OUTLAST","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","OUTLAST","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9280(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","CRAFT","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","CRAFT","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9281(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","CREW","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","CREW","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9282(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","EQUIP","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","EQUIP","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9283(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","aftermath","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9284(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","aftermath","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9285(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/trigger/Trigger","isChapter","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9286(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/trigger/Trigger","getChapter","()Ljava/lang/Integer;","invokevirtual",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9287(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/trigger/Trigger","isLastChapter","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9288(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardStateName","()Lforge/card/CardStateName;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?32:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",17);}
case 17:{f.Push(JValue.R(rt.String("Adventure")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9289(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardStateName","()Lforge/card/CardStateName;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?32:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",17);}
case 17:{f.Push(JValue.R(rt.String("Omen")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9290(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardStateName","()Lforge/card/CardStateName;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Secondary","Lforge/card/CardStateName;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?32:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",17);}
case 17:{f.Push(JValue.R(rt.String("Vengeance")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9291(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("IsCurse")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9292(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Planeswalker")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9293(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payCosts","Lforge/game/cost/Cost;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9294(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","payCosts","Lforge/game/cost/Cost;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9295(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/cost/Cost","hasNoManaCost","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",19);}
case 19:{return rt.Call(f,"forge/game/cost/CostPartMana","getAmountOfX","()I","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int<=0?29:25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{f.Pc=30;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9296(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","restrictions","Lforge/game/spellability/SpellAbilityRestriction;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9297(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","restrictions","Lforge/game/spellability/SpellAbilityRestriction;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9298(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getAbilityActivatedThisTurn","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9299(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getAbilityActivatedThisGame","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9300(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getAbilityResolvedThisTurn","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9301(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","conditions","Lforge/game/spellability/SpellAbilityCondition;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9302(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","conditions","Lforge/game/spellability/SpellAbilityCondition;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9303(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getConditions","()Lforge/game/spellability/SpellAbilityCondition;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?22:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getConditions","()Lforge/game/spellability/SpellAbilityCondition;","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","areMet","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9304(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payingMana","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9305(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payingMana","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9306(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","spentPhyrexian","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9307(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Int==0?14:5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","spentPhyrexian","I"));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(2));f.Pc=10;continue;}
case 10:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","spentPhyrexian","I",value);f.Pc=18;continue;}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9308(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","paidLifeAmount","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9309(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","paidLifeAmount","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9310(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",9);}
case 9:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?227:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/mana/Mana","triggersWhenSpent","()Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?49:41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",45);}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","addTriggersWhenSpent","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",49);}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/mana/Mana","addsCounters","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?69:57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",61);}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",66);}
case 66:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","createETBCounters","(Lforge/game/card/Card;Lforge/game/player/Player;)V","invokevirtual",69);}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/mana/Mana","addsNoCounterMagic","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?85:77;continue;}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",81);}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","addNoCounterEffect","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",85);}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?224:92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Pc=f.Pop().Reference==null?224:96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/mana/Mana","addsKeywords","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Int==0?224:104;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/mana/Mana","addsKeywordsType","()Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?224:111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[3]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getAddsKeywordsType","()Ljava/lang/String;","invokevirtual",119);}
case 119:{f.Push(f.Locals[3]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/mana/Mana","getSourceCard","()Lforge/game/card/Card;","invokevirtual",123);}
case 123:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",126);}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/mana/Mana","getSourceCard","()Lforge/game/card/Card;","invokevirtual",130);}
case 130:{f.Push(JValue.R(null));f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/spellability/SpellAbility","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int==0?224:137;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",141);}
case 141:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",144);}
case 144:{f.Locals[4]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[3]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/mana/Mana","getAddedKeywords","()Ljava/lang/String;","invokevirtual",150);}
case 150:{f.Push(JValue.R(rt.String(" & ")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",156);}
case 156:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",159);}
case 159:{f.Locals[6]=f.Pop();f.Pc=161;continue;}
case 161:{f.Push(f.Locals[1]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[6]);f.Pc=164;continue;}
case 164:{f.Push(JValue.R(null));f.Pc=165;continue;}
case 165:{f.Push(JValue.I(0));f.Pc=166;continue;}
case 166:{f.Push(f.Locals[4]);f.Pc=168;continue;}
case 168:{f.Push(JValue.R(null));f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",172);}
case 172:{f.Push(f.Locals[3]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/mana/Mana","addsKeywordsUntil","()Z","invokevirtual",176);}
case 176:{f.Pc=f.Pop().Int==0?224:179;continue;}
case 179:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$1")));f.Pc=182;continue;}
case 182:{f.StackOp("dup");f.Pc=183;continue;}
case 183:{f.Push(f.Locals[0]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[1]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[4]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/spellability/SpellAbility$1","<init>","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;J)V","invokespecial",190);}
case 190:{f.Locals[7]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[3]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",196);}
case 196:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getAddsKeywordsUntil","()Ljava/lang/String;","invokevirtual",199);}
case 199:{f.Locals[8]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(JValue.R(rt.String("UntilEOT")));f.Pc=204;continue;}
case 204:{f.Push(f.Locals[8]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",209);}
case 209:{f.Pc=f.Pop().Int==0?224:212;continue;}
case 212:{f.Push(f.Locals[1]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",216);}
case 216:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",219);}
case 219:{f.Push(f.Locals[7]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",224);}
case 224:{f.Pc=15;continue;}
case 227:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9311(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payingMana","Ljava/util/List;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?42:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",36);}
case 36:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=37;continue;}
case 37:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=38;continue;}
case 38:{f.Locals[1]=f.Pop();f.Pc=39;continue;}
case 39:{f.Pc=12;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",46);}
case 46:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9312(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","paidAbilities","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9313(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","paidLists","Lcom/google/common/collect/TreeBasedTable;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9314(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"com/google/common/collect/TreeBasedTable","create","(Lcom/google/common/collect/TreeBasedTable;)Lcom/google/common/collect/TreeBasedTable;","invokestatic",5);}
case 5:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","paidLists","Lcom/google/common/collect/TreeBasedTable;",value);f.Pc=8;continue;}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9315(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","paidLists","Lcom/google/common/collect/TreeBasedTable;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/TreeBasedTable","row","(Ljava/lang/Object;)Ljava/util/SortedMap;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/SortedMap","values","()Ljava/util/Collection;","invokeinterface",13);}
case 13:{return rt.Call(f,"com/google/common/collect/Iterables","concat","(Ljava/lang/Iterable;)Ljava/lang/Iterable;","invokestatic",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9316(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","paidLists","Lcom/google/common/collect/TreeBasedTable;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",9);}
case 9:{return rt.Call(f,"com/google/common/collect/TreeBasedTable","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9317(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","paidLists","Lcom/google/common/collect/TreeBasedTable;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",9);}
case 9:{return rt.Call(f,"com/google/common/collect/TreeBasedTable","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int!=0?35:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","paidLists","Lcom/google/common/collect/TreeBasedTable;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",24);}
case 24:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",31);}
case 31:{return rt.Call(f,"com/google/common/collect/TreeBasedTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","paidLists","Lcom/google/common/collect/TreeBasedTable;"));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",44);}
case 44:{return rt.Call(f,"com/google/common/collect/TreeBasedTable","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9318(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","paidLists","Lcom/google/common/collect/TreeBasedTable;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/TreeBasedTable","clear","()V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9319(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","triggeringObjects","Ljava/util/EnumMap;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9320(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","(Ljava/util/Map;)Ljava/util/EnumMap;","invokestatic",5);}
case 5:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","triggeringObjects","Ljava/util/EnumMap;",value);f.Pc=8;continue;}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9321(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","triggeringObjects","Ljava/util/EnumMap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/EnumMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9322(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","triggeringObjects","Ljava/util/EnumMap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/EnumMap","put","(Ljava/lang/Enum;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",9);}
case 9:{f.StackOp("pop");f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9323(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","triggeringObjects","Ljava/util/EnumMap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/EnumMap","containsKey","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9324(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",4);}
case 4:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","triggeringObjects","Ljava/util/EnumMap;",value);f.Pc=7;continue;}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9325(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","replacingObjects","Ljava/util/EnumMap;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9326(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","replacingObjects","Ljava/util/EnumMap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/EnumMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9327(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","replacingObjects","Ljava/util/EnumMap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/EnumMap","put","(Ljava/lang/Enum;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",9);}
case 9:{f.StackOp("pop");f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9328(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","(Ljava/util/Map;)Ljava/util/EnumMap;","invokestatic",5);}
case 5:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","replacingObjects","Ljava/util/EnumMap;",value);f.Pc=8;continue;}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9329(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[5]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?53:16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[5]);f.Pc=19;continue;}
case 19:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=20;continue;}
case 20:{f.Locals[6]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[6]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?47:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[6]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[6]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",44);}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",47);}
case 47:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=50;continue;}
case 50:{f.Pc=9;continue;}
case 53:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9330(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetTriggeringObjects","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?16:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","setXManaCostPaid","(Ljava/lang/Integer;)V","invokevirtual",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9331(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?24:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","toUnsuppressedString","()Ljava/lang/String;","invokevirtual",18);}
case 18:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9331:18:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",23);}
case 23:{return JStep.Return(f.Pop());}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","toUnsuppressedString","()Ljava/lang/String;","invokevirtual",28);}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9332(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/card/CardView","getText","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","stackDescription","Ljava/lang/String;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?43:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int!=0?43:29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9332:37:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",42);}
case 42:{return JStep.Return(f.Pop());}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","stackDescription","Ljava/lang/String;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?56:53;continue;}
case 53:{f.Push(JValue.R(rt.String("")));f.Pc=55;continue;}
case 55:{return JStep.Return(f.Pop());}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","stackDescription","Ljava/lang/String;"));f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",67);}
case 67:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",70);}
case 70:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",73);}
case 73:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9333(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","originalStackDescription","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","originalStackDescription","Ljava/lang/String;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","stackDescription","Ljava/lang/String;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","hostCard","Lforge/game/card/Card;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Reference!=null?28:23;continue;}
case 23:{f.Push(JValue.R(rt.String("")));f.Pc=25;continue;}
case 25:{f.Pc=38;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","hostCard","Lforge/game/card/Card;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",35);}
case 35:{return rt.Call(f,"forge/game/card/CardView","getText","()Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Locals[2]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","description","Ljava/lang/String;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",46);}
case 46:{f.Pc=f.Pop().Int==0?61:49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",53);}
case 53:{f.Pc=f.Pop().Int==0?61:56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",61);}
case 61:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9334(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","originalStackDescription","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9335(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","description","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9336(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("VERT")));f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("|")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",11);}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","originalDescription","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","originalDescription","Ljava/lang/String;"));f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","description","Ljava/lang/String;",value);f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9337(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","originalDescription","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9338(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payCosts","Lforge/game/cost/Cost;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?17:14;continue;}
case 14:{f.Push(JValue.R(rt.String("")));f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?69:37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(JValue.R(rt.String("Equip")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",50);}
case 50:{f.Locals[1]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",59);}
case 59:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",62);}
case 62:{f.Push(JValue.R(rt.String(" ")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",68);}
case 68:{f.StackOp("pop");f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("CostDesc")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int==0?100:79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("CostDesc")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",87);}
case 87:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",90);}
case 90:{f.Push(JValue.R(rt.String(" ")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",96);}
case 96:{f.StackOp("pop");f.Pc=97;continue;}
case 97:{f.Pc=256;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("AlternateCost")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?225:110;continue;}
case 110:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=113;continue;}
case 113:{f.StackOp("dup");f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("AlternateCost")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",121);}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payCosts","Lforge/game/cost/Cost;"));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/cost/Cost","isAbility","()Z","invokevirtual",128);}
case 128:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",131);}
case 131:{f.Locals[3]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[3]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",136);}
case 136:{f.Locals[4]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payCosts","Lforge/game/cost/Cost;"));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int==0?161:148;continue;}
case 148:{f.Push(f.Locals[4]);f.Pc=150;continue;}
case 150:{f.Pc=f.Pop().Int!=0?161:153;continue;}
case 153:{f.Push(f.Locals[2]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("Pay ")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",160);}
case 160:{f.StackOp("pop");f.Pc=161;continue;}
case 161:{f.Push(f.Locals[2]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[0]);f.Pc=163;continue;}
case 163:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payCosts","Lforge/game/cost/Cost;"));f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",169);}
case 169:{f.StackOp("pop");f.Pc=170;continue;}
case 170:{f.Push(f.Locals[2]);f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String(" or ")));f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",177);}
case 177:{f.Push(f.Locals[4]);f.Pc=179;continue;}
case 179:{f.Pc=f.Pop().Int==0?189:182;continue;}
case 182:{f.Push(f.Locals[3]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/cost/Cost","toString","()Ljava/lang/String;","invokevirtual",186);}
case 186:{f.Pc=196;continue;}
case 189:{f.Push(f.Locals[3]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/cost/Cost","toString","()Ljava/lang/String;","invokevirtual",193);}
case 193:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","uncapitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",196);}
case 196:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",199);}
case 199:{f.StackOp("pop");f.Pc=200;continue;}
case 200:{f.Push(f.Locals[2]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{f.Pc=f.Pop().Int==0?216:205;continue;}
case 205:{f.Push(f.Locals[4]);f.Pc=207;continue;}
case 207:{f.Pc=f.Pop().Int!=0?216:210;continue;}
case 210:{f.Push(JValue.R(rt.String(".")));f.Pc=213;continue;}
case 213:{f.Pc=218;continue;}
case 216:{f.Push(JValue.R(rt.String("")));f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",221);}
case 221:{f.StackOp("pop");f.Pc=222;continue;}
case 222:{f.Pc=234;continue;}
case 225:{f.Push(f.Locals[2]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[0]);f.Pc=227;continue;}
case 227:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payCosts","Lforge/game/cost/Cost;"));f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",233);}
case 233:{f.StackOp("pop");f.Pc=234;continue;}
case 234:{f.Push(f.Locals[0]);f.Pc=235;continue;}
case 235:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payCosts","Lforge/game/cost/Cost;"));f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/cost/Cost","isAbility","()Z","invokevirtual",241);}
case 241:{f.Pc=f.Pop().Int==0?256:244;continue;}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{f.Pc=f.Pop().Int!=0?256:248;continue;}
case 248:{f.Push(f.Locals[2]);f.Pc=249;continue;}
case 249:{f.Push(JValue.R(rt.String(": ")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",255);}
case 255:{f.StackOp("pop");f.Pc=256;continue;}
case 256:{f.Push(f.Locals[2]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",260);}
case 260:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9339(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCostDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9339:11:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",16);}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",22);}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9340(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSuppressed","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?10:7;continue;}
case 7:{f.Push(JValue.R(rt.String("")));f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","toUnsuppressedString","()Ljava/lang/String;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9341(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference==null?131:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?27:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String(" ")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",31);}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Reference==null?123:39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int!=0?123:46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostName","(Lforge/game/CardTraitBase;)Lforge/util/ITranslatable;","invokevirtual",51);}
case 51:{f.Locals[4]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/util/CardTranslation","translateMultipleDescriptionText","(Ljava/lang/String;Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",59);}
case 59:{f.Locals[3]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/util/ITranslatable","getTranslatedName","()Ljava/lang/String;","invokeinterface",67);}
case 67:{f.Locals[5]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",78);}
case 78:{f.Locals[3]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("NICKNAME")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",86);}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/util/Lang","getNickName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",91);}
case 91:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",94);}
case 94:{f.Locals[3]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Reference==null?117:102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("ORIGINALHOST")));f.Pc=106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",110);}
case 110:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",113);}
case 113:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",116);}
case 116:{f.Locals[3]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",127);}
case 127:{f.Locals[2]=f.Pop();f.Pc=128;continue;}
case 128:{f.Pc=10;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",135);}
case 135:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9342(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9343(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?9:8;continue;}
case 8:{return JStep.ReturnVoid;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Reference==null?29:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/AbilitySub","setParent","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",29);}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","view","Lforge/game/spellability/SpellAbilityView;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","updateDescription","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",37);}
case 37:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9344(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilities","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9345(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasAdditionalAbility","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?22:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilities","Ljava/util/Map;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",18);}
case 18:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{f.Push(JValue.R(null));f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9346(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilities","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9347(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?18:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilities","Ljava/util/Map;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Pc=45;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Int==0?33:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/AbilitySub","setParent","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",33);}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilities","Ljava/util/Map;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","view","Lforge/game/spellability/SpellAbilityView;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","updateDescription","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",53);}
case 53:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9348(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilityLists","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9349(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilityLists","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?27:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilityLists","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
case 27:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",30);}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9350(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?27:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilityLists","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Pc=83;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",31);}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",38);}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",47);}
case 47:{f.Pc=f.Pop().Int==0?71:50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[5]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[5]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/AbilitySub","setParent","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",68);}
case 68:{f.Pc=40;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilityLists","Ljava/util/Map;"));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","view","Lforge/game/spellability/SpellAbilityView;"));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","updateDescription","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",91);}
case 91:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9351(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTailAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9352(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","basicSpell","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?38:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCastFaceDown","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?38:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","altCost","Lforge/game/spellability/AlternativeCost;"));f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Reference!=null?38:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",25);}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalCosts","Ljava/util/EnumSet;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/EnumSet","isEmpty","()Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?38:34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{f.Pc=39;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9353(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","basicSpell","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9354(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","mayPlay","Lforge/game/card/CardPlayOption;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9355(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","mayPlay","Lforge/game/card/CardPlayOption;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?17:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","mayPlay","Lforge/game/card/CardPlayOption;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardPlayOption","getAbility","()Lforge/game/staticability/StaticAbility;","invokevirtual",14);}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.R(null));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9356(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","mayPlay","Lforge/game/card/CardPlayOption;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9357(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","hostCard","Lforge/game/card/Card;"));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9358(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","hostCard","Lforge/game/card/Card;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9359(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",6);}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9360(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",6);}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;ZZ)Lforge/game/spellability/SpellAbility;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9361(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;ZZ)Lforge/game/spellability/SpellAbility;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9362(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[5]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/Object","clone","()Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{f.Locals[5]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[5]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Int==0?25:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","id","I"));f.Pc=22;continue;}
case 22:{f.Pc=28;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","nextId","()I","invokestatic",28);}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","id","I",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Pc=f.Pop().Int!=0?44:39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Int==0?48:44;continue;}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{f.Pc=49;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyHelper","(Lforge/game/CardTraitBase;Lforge/game/card/Card;Z)V","invokevirtual",52);}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbilityView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbilityView")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Int!=0?71:64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Reference!=null?75:71;continue;}
case 71:{f.Push(JValue.R(null));f.Pc=72;continue;}
case 72:{f.Pc=82;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",79);}
case 79:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",82);}
case 82:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","<init>","(Lforge/game/spellability/SpellAbility;Lforge/trackable/Tracker;)V","invokespecial",85);}
case 85:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","view","Lforge/game/spellability/SpellAbilityView;",value);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{f.Push(JValue.I(0));f.Pc=91;continue;}
case 91:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","mayChooseNewTargets","Z",value);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[5]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","triggeringObjects","Ljava/util/EnumMap;"));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","(Ljava/util/Map;)Ljava/util/EnumMap;","invokestatic",103);}
case 103:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","triggeringObjects","Ljava/util/EnumMap;",value);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[3]);f.Pc=107;continue;}
case 107:{f.Pc=f.Pop().Int!=0?118:110;continue;}
case 110:{f.Push(f.Locals[5]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",115);}
case 115:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","replacingObjects","Ljava/util/EnumMap;",value);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[5]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",124);}
case 124:{if(!rt.StaticReady(f,"forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"));f.Pc=127;continue;}
case 127:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?136:130;continue;}
case 130:{if(!rt.StaticReady(f,"forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"));f.Pc=133;continue;}
case 133:{f.Pc=143;continue;}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",140);}
case 140:{return rt.Call(f,"forge/game/cost/Cost","copy","()Lforge/game/cost/Cost;","invokevirtual",143);}
case 143:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPayCosts","(Lforge/game/cost/Cost;)V","invokevirtual",146);}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","manaPart","Lforge/game/spellability/AbilityManaPart;"));f.Pc=150;continue;}
case 150:{f.Pc=f.Pop().Reference==null?171:153;continue;}
case 153:{f.Push(f.Locals[5]);f.Pc=155;continue;}
case 155:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AbilityManaPart"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AbilityManaPart")));f.Pc=158;continue;}
case 158:{f.StackOp("dup");f.Pc=159;continue;}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","mapParams","Ljava/util/Map;"));f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","<init>","(Lforge/game/spellability/SpellAbility;Ljava/util/Map;)V","invokespecial",168);}
case 168:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","manaPart","Lforge/game/spellability/AbilityManaPart;",value);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[5]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalKeywordAmount","Lcom/google/common/collect/Table;"));f.Pc=177;continue;}
case 177:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","(Lcom/google/common/collect/Table;)Lcom/google/common/collect/HashBasedTable;","invokestatic",180);}
case 180:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","optionalKeywordAmount","Lcom/google/common/collect/Table;",value);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[0]);f.Pc=184;continue;}
case 184:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","damageMap","Lforge/game/card/CardDamageTable;"));f.Pc=187;continue;}
case 187:{f.Pc=f.Pop().Reference==null?206:190;continue;}
case 190:{f.Push(f.Locals[5]);f.Pc=192;continue;}
case 192:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=195;continue;}
case 195:{f.StackOp("dup");f.Pc=196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","damageMap","Lforge/game/card/CardDamageTable;"));f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","(Lcom/google/common/collect/Table;)V","invokespecial",203);}
case 203:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","damageMap","Lforge/game/card/CardDamageTable;",value);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[0]);f.Pc=207;continue;}
case 207:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","preventMap","Lforge/game/card/CardDamageTable;"));f.Pc=210;continue;}
case 210:{f.Pc=f.Pop().Reference==null?229:213;continue;}
case 213:{f.Push(f.Locals[5]);f.Pc=215;continue;}
case 215:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=218;continue;}
case 218:{f.StackOp("dup");f.Pc=219;continue;}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","preventMap","Lforge/game/card/CardDamageTable;"));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","(Lcom/google/common/collect/Table;)V","invokespecial",226);}
case 226:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","preventMap","Lforge/game/card/CardDamageTable;",value);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","counterTable","Lforge/game/GameEntityCounterTable;"));f.Pc=233;continue;}
case 233:{f.Pc=f.Pop().Reference==null?252:236;continue;}
case 236:{f.Push(f.Locals[5]);f.Pc=238;continue;}
case 238:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=241;continue;}
case 241:{f.StackOp("dup");f.Pc=242;continue;}
case 242:{f.Push(f.Locals[0]);f.Pc=243;continue;}
case 243:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","counterTable","Lforge/game/GameEntityCounterTable;"));f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","(Lcom/google/common/collect/Table;)V","invokespecial",249);}
case 249:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","counterTable","Lforge/game/GameEntityCounterTable;",value);f.Pc=252;continue;}
case 252:{f.Push(f.Locals[0]);f.Pc=253;continue;}
case 253:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","changeZoneTable","Lforge/game/card/CardZoneTable;"));f.Pc=256;continue;}
case 256:{f.Pc=f.Pop().Reference==null?275:259;continue;}
case 259:{f.Push(f.Locals[5]);f.Pc=261;continue;}
case 261:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=264;continue;}
case 264:{f.StackOp("dup");f.Pc=265;continue;}
case 265:{f.Push(f.Locals[0]);f.Pc=266;continue;}
case 266:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","changeZoneTable","Lforge/game/card/CardZoneTable;"));f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardZoneTable;)V","invokespecial",272);}
case 272:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","changeZoneTable","Lforge/game/card/CardZoneTable;",value);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[5]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[0]);f.Pc=278;continue;}
case 278:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payingMana","Ljava/util/List;"));f.Pc=281;continue;}
case 281:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",284);}
case 284:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","payingMana","Ljava/util/List;",value);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[5]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",292);}
case 292:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","paidAbilities","Ljava/util/List;",value);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[5]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[0]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidHash","()Lcom/google/common/collect/TreeBasedTable;","invokevirtual",301);}
case 301:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPaidHash","(Lcom/google/common/collect/TreeBasedTable;)V","invokevirtual",304);}
case 304:{f.Push(f.Locals[0]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",308);}
case 308:{f.Pc=f.Pop().Int==0?323:311;continue;}
case 311:{f.Push(f.Locals[5]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[0]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",317);}
case 317:{return rt.Call(f,"forge/game/spellability/TargetChoices","clone","()Lforge/game/spellability/TargetChoices;","invokevirtual",320);}
case 320:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","targetChosen","Lforge/game/spellability/TargetChoices;",value);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[5]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",328);}
case 328:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilities","Ljava/util/Map;",value);f.Pc=331;continue;}
case 331:{f.Push(f.Locals[5]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",336);}
case 336:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilityLists","Ljava/util/Map;",value);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[0]);f.Pc=340;continue;}
case 340:{f.Push(f.Locals[5]);f.Pc=342;continue;}
case 342:{f.Push(f.Locals[1]);f.Pc=343;continue;}
case 343:{f.Push(f.Locals[2]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[3]);f.Pc=345;continue;}
case 345:{f.Push(f.Locals[4]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/card/CardFactory","copySpellAbility","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;ZZ)V","invokestatic",350);}
case 350:{f.Pc=363;continue;}
case 353:{f.Locals[6]=f.Pop();f.Pc=355;continue;}
case 355:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=358;continue;}
case 358:{f.Push(f.Locals[6]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/Object;)V","invokevirtual",363);}
case 363:{f.Push(f.Locals[5]);f.Pc=365;continue;}
case 365:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9363(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithNoManaCost","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9364(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference!=null?12:10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/cost/Cost","copyWithNoMana","()Lforge/game/cost/Cost;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPayCosts","(Lforge/game/cost/Cost;)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("WithoutManaCost")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int!=0?49:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","mapParams","Ljava/util/Map;"));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("WithoutManaCost")));f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("True")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",54);}
case 54:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9364:54:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",59);}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",62);}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9365(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPayCosts","(Lforge/game/cost/Cost;)V","invokevirtual",10);}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9366(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokevirtual",5);}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference!=null?12:10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/cost/Cost","copyWithNoMana","()Lforge/game/cost/Cost;","invokevirtual",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPayCosts","(Lforge/game/cost/Cost;)V","invokevirtual",34);}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9367(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9368(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","triggerObj","Lforge/game/trigger/Trigger;"));f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9369(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","triggerObj","Lforge/game/trigger/Trigger;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9370(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalTrigger","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9371(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","optionalTrigger","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9372(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?17:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/trigger/Trigger","getId","()I","invokevirtual",14);}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(-1));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9373(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?17:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",14);}
case 14:{f.Pc=29;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","replacementEffect","Lforge/game/replacement/ReplacementEffect;"));f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference==null?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9374(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacementEffect","()Lforge/game/replacement/ReplacementEffect;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","replacementEffect","Lforge/game/replacement/ReplacementEffect;"));f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9375(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","replacementEffect","Lforge/game/replacement/ReplacementEffect;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9376(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalTrigger","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9377(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;Z)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9378(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?28:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",22);}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?28:26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?1637:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isUniqueTargets","()Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?64:49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","getUniqueTargets","()Ljava/util/List;","invokevirtual",53);}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",59);}
case 59:{f.Pc=f.Pop().Int==0?64:62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("TargetsWithDefinedController")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int==0?126:74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=78;continue;}
case 78:{f.Pc=f.Pop().Int==0?126:81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=85;continue;}
case 85:{f.Locals[5]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",91);}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("TargetsWithDefinedController")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",98);}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",102);}
case 102:{f.Locals[6]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{f.Pc=f.Pop().Reference==null?124:109;continue;}
case 109:{f.Push(f.Locals[6]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[5]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",116);}
case 116:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",121);}
case 121:{f.Pc=f.Pop().Int!=0?126:124;continue;}
case 124:{f.Push(JValue.I(0));f.Pc=125;continue;}
case 125:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("TargetsWithSharedCardType")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",133);}
case 133:{f.Pc=f.Pop().Int==0?312:136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=140;continue;}
case 140:{f.Pc=f.Pop().Int==0?312:143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=147;continue;}
case 147:{f.Locals[5]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",153);}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("TargetsWithSharedCardType")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",160);}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",164);}
case 164:{f.Locals[6]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[6]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",171);}
case 171:{f.Locals[7]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[7]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",180);}
case 180:{f.Pc=f.Pop().Int==0?312:183;continue;}
case 183:{f.Push(f.Locals[7]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",190);}
case 190:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=193;continue;}
case 193:{f.Locals[8]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(JValue.R(rt.String("TargetsWithSharedTypes")));f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",202);}
case 202:{f.Pc=f.Pop().Int==0?297:205;continue;}
case 205:{f.Push(JValue.I(0));f.Pc=206;continue;}
case 206:{f.Locals[9]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{f.Push(JValue.R(rt.String("TargetsWithSharedTypes")));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",215);}
case 215:{f.Push(JValue.R(rt.String(",")));f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",221);}
case 221:{f.Locals[10]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(f.Locals[10]);f.Pc=225;continue;}
case 225:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=226;continue;}
case 226:{f.Locals[11]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(JValue.I(0));f.Pc=229;continue;}
case 229:{f.Locals[12]=f.Pop();f.Pc=231;continue;}
case 231:{f.Push(f.Locals[12]);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[11]);f.Pc=235;continue;}
case 235:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?287:238;continue;}
case 238:{f.Push(f.Locals[10]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[12]);f.Pc=242;continue;}
case 242:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=243;continue;}
case 243:{f.Locals[13]=f.Pop();f.Pc=245;continue;}
case 245:{f.Push(f.Locals[5]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",250);}
case 250:{f.Push(f.Locals[13]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",257);}
case 257:{f.Pc=f.Pop().Int==0?281:260;continue;}
case 260:{f.Push(f.Locals[8]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",265);}
case 265:{f.Push(f.Locals[13]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",272);}
case 272:{f.Pc=f.Pop().Int==0?281:275;continue;}
case 275:{f.Push(JValue.I(1));f.Pc=276;continue;}
case 276:{f.Locals[9]=f.Pop();f.Pc=278;continue;}
case 278:{f.Pc=287;continue;}
case 281:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=284;continue;}
case 284:{f.Pc=231;continue;}
case 287:{f.Push(f.Locals[9]);f.Pc=289;continue;}
case 289:{f.Pc=f.Pop().Int!=0?294:292;continue;}
case 292:{f.Push(JValue.I(0));f.Pc=293;continue;}
case 293:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 294:{f.Pc=309;continue;}
case 297:{f.Push(f.Locals[5]);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[8]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/card/Card","sharesCardTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",304);}
case 304:{f.Pc=f.Pop().Int!=0?309:307;continue;}
case 307:{f.Push(JValue.I(0));f.Pc=308;continue;}
case 308:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 309:{f.Pc=173;continue;}
case 312:{f.Push(f.Locals[0]);f.Pc=313;continue;}
case 313:{f.Push(JValue.R(rt.String("TargetsWithControllerProperty")));f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",319);}
case 319:{f.Pc=f.Pop().Int==0?418:322;continue;}
case 322:{f.Push(f.Locals[1]);f.Pc=323;continue;}
case 323:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=326;continue;}
case 326:{f.Pc=f.Pop().Int==0?418:329;continue;}
case 329:{f.Push(f.Locals[0]);f.Pc=330;continue;}
case 330:{f.Push(JValue.R(rt.String("TargetsWithControllerProperty")));f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",336);}
case 336:{f.Locals[5]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[1]);f.Pc=339;continue;}
case 339:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=342;continue;}
case 342:{f.Locals[6]=f.Pop();f.Pc=344;continue;}
case 344:{f.Push(f.Locals[5]);f.Pc=346;continue;}
case 346:{f.Push(JValue.R(rt.String("cmcLECardsInGraveyard")));f.Pc=349;continue;}
case 349:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",352);}
case 352:{f.Pc=f.Pop().Int==0?381:355;continue;}
case 355:{f.Push(f.Locals[6]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",360);}
case 360:{f.Push(f.Locals[6]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",365);}
case 365:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",371);}
case 371:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",376);}
case 376:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?381:379;continue;}
case 379:{f.Push(JValue.I(0));f.Pc=380;continue;}
case 380:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 381:{f.Push(f.Locals[5]);f.Pc=383;continue;}
case 383:{f.Push(JValue.R(rt.String("powerLECardsInGraveyard")));f.Pc=386;continue;}
case 386:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",389);}
case 389:{f.Pc=f.Pop().Int==0?418:392;continue;}
case 392:{f.Push(f.Locals[6]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",397);}
case 397:{f.Push(f.Locals[6]);f.Pc=399;continue;}
case 399:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",402);}
case 402:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",408);}
case 408:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",413);}
case 413:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?418:416;continue;}
case 416:{f.Push(JValue.I(0));f.Pc=417;continue;}
case 417:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 418:{f.Push(f.Locals[0]);f.Pc=419;continue;}
case 419:{f.Push(JValue.R(rt.String("TargetsWithRelatedProperty")));f.Pc=422;continue;}
case 422:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",425);}
case 425:{f.Pc=f.Pop().Int==0?642:428;continue;}
case 428:{f.Push(f.Locals[1]);f.Pc=429;continue;}
case 429:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=432;continue;}
case 432:{f.Pc=f.Pop().Int==0?642:435;continue;}
case 435:{f.Push(f.Locals[0]);f.Pc=436;continue;}
case 436:{f.Push(JValue.R(rt.String("TargetsWithRelatedProperty")));f.Pc=439;continue;}
case 439:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",442);}
case 442:{f.Locals[5]=f.Pop();f.Pc=444;continue;}
case 444:{f.Push(f.Locals[1]);f.Pc=445;continue;}
case 445:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=448;continue;}
case 448:{f.Locals[6]=f.Pop();f.Pc=450;continue;}
case 450:{f.Push(JValue.R(null));f.Pc=451;continue;}
case 451:{f.Locals[7]=f.Pop();f.Pc=453;continue;}
case 453:{f.Push(f.Locals[0]);f.Pc=454;continue;}
case 454:{return rt.Call(f,"forge/game/spellability/SpellAbility","getUniqueTargets","()Ljava/util/List;","invokevirtual",457);}
case 457:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",462);}
case 462:{f.Locals[8]=f.Pop();f.Pc=464;continue;}
case 464:{f.Push(f.Locals[8]);f.Pc=466;continue;}
case 466:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",471);}
case 471:{f.Pc=f.Pop().Int==0?507:474;continue;}
case 474:{f.Push(f.Locals[8]);f.Pc=476;continue;}
case 476:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",481);}
case 481:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=484;continue;}
case 484:{f.Locals[9]=f.Pop();f.Pc=486;continue;}
case 486:{f.Push(f.Locals[9]);f.Pc=488;continue;}
case 488:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=491;continue;}
case 491:{f.Pc=f.Pop().Int==0?504:494;continue;}
case 494:{f.Push(f.Locals[9]);f.Pc=496;continue;}
case 496:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=499;continue;}
case 499:{f.Locals[7]=f.Pop();f.Pc=501;continue;}
case 501:{f.Pc=507;continue;}
case 504:{f.Pc=464;continue;}
case 507:{f.Push(f.Locals[7]);f.Pc=509;continue;}
case 509:{f.Pc=f.Pop().Reference!=null?514:512;continue;}
case 512:{f.Push(JValue.I(0));f.Pc=513;continue;}
case 513:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 514:{f.Push(f.Locals[5]);f.Pc=516;continue;}
case 516:{f.Locals[8]=f.Pop();f.Pc=518;continue;}
case 518:{f.Push(JValue.I(-1));f.Pc=519;continue;}
case 519:{f.Locals[9]=f.Pop();f.Pc=521;continue;}
case 521:{f.Push(f.Locals[8]);f.Pc=523;continue;}
case 523:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",526);}
case 526:{switch(f.Pop().Int){case 72310016:f.Pc=569;break;case 783520524:f.Pc=552;break;default:f.Pc=583;break;}continue;}
case 552:{f.Push(f.Locals[8]);f.Pc=554;continue;}
case 554:{f.Push(JValue.R(rt.String("LEPower")));f.Pc=557;continue;}
case 557:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",560);}
case 560:{f.Pc=f.Pop().Int==0?583:563;continue;}
case 563:{f.Push(JValue.I(0));f.Pc=564;continue;}
case 564:{f.Locals[9]=f.Pop();f.Pc=566;continue;}
case 566:{f.Pc=583;continue;}
case 569:{f.Push(f.Locals[8]);f.Pc=571;continue;}
case 571:{f.Push(JValue.R(rt.String("LECMC")));f.Pc=574;continue;}
case 574:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",577);}
case 577:{f.Pc=f.Pop().Int==0?583:580;continue;}
case 580:{f.Push(JValue.I(1));f.Pc=581;continue;}
case 581:{f.Locals[9]=f.Pop();f.Pc=583;continue;}
case 583:{f.Push(f.Locals[9]);f.Pc=585;continue;}
case 585:{switch(f.Pop().Int){case 0:f.Pc=612;break;case 1:f.Pc=627;break;default:f.Pc=642;break;}continue;}
case 612:{f.Push(f.Locals[6]);f.Pc=614;continue;}
case 614:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",617);}
case 617:{f.Push(f.Locals[7]);f.Pc=619;continue;}
case 619:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",622);}
case 622:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?642:625;continue;}
case 625:{f.Push(JValue.I(0));f.Pc=626;continue;}
case 626:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 627:{f.Push(f.Locals[6]);f.Pc=629;continue;}
case 629:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",632);}
case 632:{f.Push(f.Locals[7]);f.Pc=634;continue;}
case 634:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",637);}
case 637:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?642:640;continue;}
case 640:{f.Push(JValue.I(0));f.Pc=641;continue;}
case 641:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 642:{f.Push(f.Locals[0]);f.Pc=643;continue;}
case 643:{f.Push(JValue.R(rt.String("TargetingPlayerControls")));f.Pc=646;continue;}
case 646:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",649);}
case 649:{f.Pc=f.Pop().Int==0?682:652;continue;}
case 652:{f.Push(f.Locals[1]);f.Pc=653;continue;}
case 653:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=656;continue;}
case 656:{f.Pc=f.Pop().Int==0?682:659;continue;}
case 659:{f.Push(f.Locals[1]);f.Pc=660;continue;}
case 660:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=663;continue;}
case 663:{f.Locals[5]=f.Pop();f.Pc=665;continue;}
case 665:{f.Push(f.Locals[5]);f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",670);}
case 670:{f.Push(f.Locals[0]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetingPlayer","()Lforge/game/player/Player;","invokevirtual",674);}
case 674:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",677);}
case 677:{f.Pc=f.Pop().Int!=0?682:680;continue;}
case 680:{f.Push(JValue.I(0));f.Pc=681;continue;}
case 681:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 682:{f.Push(f.Locals[0]);f.Pc=683;continue;}
case 683:{f.Push(JValue.R(rt.String("MaxTotalTargetCMC")));f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",689);}
case 689:{f.Pc=f.Pop().Int==0?757:692;continue;}
case 692:{f.Push(f.Locals[1]);f.Pc=693;continue;}
case 693:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=696;continue;}
case 696:{f.Pc=f.Pop().Int==0?757:699;continue;}
case 699:{f.Push(f.Locals[0]);f.Pc=700;continue;}
case 700:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",703);}
case 703:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",706);}
case 706:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9378:706:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",711);}
case 711:{return rt.Call(f,"forge/util/Aggregates","sum","(Ljava/lang/Iterable;Ljava/util/function/Function;)I","invokestatic",714);}
case 714:{f.Locals[5]=f.Pop();f.Pc=716;continue;}
case 716:{f.Push(f.Locals[0]);f.Pc=717;continue;}
case 717:{f.Push(f.Locals[1]);f.Pc=718;continue;}
case 718:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTargeting","(Lforge/game/GameObject;)Z","invokevirtual",721);}
case 721:{f.Pc=f.Pop().Int!=0?740:724;continue;}
case 724:{f.Push(f.Locals[1]);f.Pc=725;continue;}
case 725:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=728;continue;}
case 728:{f.Locals[6]=f.Pop();f.Pc=730;continue;}
case 730:{f.Push(f.Locals[5]);f.Pc=732;continue;}
case 732:{f.Push(f.Locals[6]);f.Pc=734;continue;}
case 734:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",737);}
case 737:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=738;continue;}
case 738:{f.Locals[5]=f.Pop();f.Pc=740;continue;}
case 740:{f.Push(f.Locals[5]);f.Pc=742;continue;}
case 742:{f.Push(f.Locals[4]);f.Pc=744;continue;}
case 744:{f.Push(f.Locals[0]);f.Pc=745;continue;}
case 745:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",748);}
case 748:{f.Push(f.Locals[0]);f.Pc=749;continue;}
case 749:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getMaxTotalCMC","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)I","invokevirtual",752);}
case 752:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?757:755;continue;}
case 755:{f.Push(JValue.I(0));f.Pc=756;continue;}
case 756:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 757:{f.Push(f.Locals[0]);f.Pc=758;continue;}
case 758:{f.Push(JValue.R(rt.String("MaxTotalTargetPower")));f.Pc=761;continue;}
case 761:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",764);}
case 764:{f.Pc=f.Pop().Int==0?832:767;continue;}
case 767:{f.Push(f.Locals[1]);f.Pc=768;continue;}
case 768:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=771;continue;}
case 771:{f.Pc=f.Pop().Int==0?832:774;continue;}
case 774:{f.Push(f.Locals[0]);f.Pc=775;continue;}
case 775:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",778);}
case 778:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",781);}
case 781:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9378:781:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",786);}
case 786:{return rt.Call(f,"forge/util/Aggregates","sum","(Ljava/lang/Iterable;Ljava/util/function/Function;)I","invokestatic",789);}
case 789:{f.Locals[5]=f.Pop();f.Pc=791;continue;}
case 791:{f.Push(f.Locals[0]);f.Pc=792;continue;}
case 792:{f.Push(f.Locals[1]);f.Pc=793;continue;}
case 793:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTargeting","(Lforge/game/GameObject;)Z","invokevirtual",796);}
case 796:{f.Pc=f.Pop().Int!=0?815:799;continue;}
case 799:{f.Push(f.Locals[1]);f.Pc=800;continue;}
case 800:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=803;continue;}
case 803:{f.Locals[6]=f.Pop();f.Pc=805;continue;}
case 805:{f.Push(f.Locals[5]);f.Pc=807;continue;}
case 807:{f.Push(f.Locals[6]);f.Pc=809;continue;}
case 809:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",812);}
case 812:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=813;continue;}
case 813:{f.Locals[5]=f.Pop();f.Pc=815;continue;}
case 815:{f.Push(f.Locals[5]);f.Pc=817;continue;}
case 817:{f.Push(f.Locals[4]);f.Pc=819;continue;}
case 819:{f.Push(f.Locals[0]);f.Pc=820;continue;}
case 820:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",823);}
case 823:{f.Push(f.Locals[0]);f.Pc=824;continue;}
case 824:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getMaxTotalPower","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)I","invokevirtual",827);}
case 827:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?832:830;continue;}
case 830:{f.Push(JValue.I(0));f.Pc=831;continue;}
case 831:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 832:{f.Push(f.Locals[4]);f.Pc=834;continue;}
case 834:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isEqualToughness","()Z","invokevirtual",837);}
case 837:{f.Pc=f.Pop().Int==0?909:840;continue;}
case 840:{f.Push(f.Locals[1]);f.Pc=841;continue;}
case 841:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=844;continue;}
case 844:{f.Pc=f.Pop().Int==0?909:847;continue;}
case 847:{f.Push(f.Locals[0]);f.Pc=848;continue;}
case 848:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",851);}
case 851:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",854);}
case 854:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",859);}
case 859:{f.Locals[5]=f.Pop();f.Pc=861;continue;}
case 861:{f.Push(f.Locals[5]);f.Pc=863;continue;}
case 863:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",868);}
case 868:{f.Pc=f.Pop().Int==0?909:871;continue;}
case 871:{f.Push(f.Locals[5]);f.Pc=873;continue;}
case 873:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",878);}
case 878:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=881;continue;}
case 881:{f.Locals[6]=f.Pop();f.Pc=883;continue;}
case 883:{f.Push(f.Locals[1]);f.Pc=884;continue;}
case 884:{f.Push(f.Locals[6]);f.Pc=886;continue;}
case 886:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?906:889;continue;}
case 889:{f.Push(f.Locals[6]);f.Pc=891;continue;}
case 891:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",894);}
case 894:{f.Push(f.Locals[1]);f.Pc=895;continue;}
case 895:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=898;continue;}
case 898:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",901);}
case 901:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?906:904;continue;}
case 904:{f.Push(JValue.I(0));f.Pc=905;continue;}
case 905:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 906:{f.Pc=861;continue;}
case 909:{f.Push(f.Locals[4]);f.Pc=911;continue;}
case 911:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isDifferentCMC","()Z","invokevirtual",914);}
case 914:{f.Pc=f.Pop().Int==0?986:917;continue;}
case 917:{f.Push(f.Locals[1]);f.Pc=918;continue;}
case 918:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=921;continue;}
case 921:{f.Pc=f.Pop().Int==0?986:924;continue;}
case 924:{f.Push(f.Locals[0]);f.Pc=925;continue;}
case 925:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",928);}
case 928:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",931);}
case 931:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",936);}
case 936:{f.Locals[5]=f.Pop();f.Pc=938;continue;}
case 938:{f.Push(f.Locals[5]);f.Pc=940;continue;}
case 940:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",945);}
case 945:{f.Pc=f.Pop().Int==0?986:948;continue;}
case 948:{f.Push(f.Locals[5]);f.Pc=950;continue;}
case 950:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",955);}
case 955:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=958;continue;}
case 958:{f.Locals[6]=f.Pop();f.Pc=960;continue;}
case 960:{f.Push(f.Locals[1]);f.Pc=961;continue;}
case 961:{f.Push(f.Locals[6]);f.Pc=963;continue;}
case 963:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?983:966;continue;}
case 966:{f.Push(f.Locals[6]);f.Pc=968;continue;}
case 968:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",971);}
case 971:{f.Push(f.Locals[1]);f.Pc=972;continue;}
case 972:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=975;continue;}
case 975:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",978);}
case 978:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?983:981;continue;}
case 981:{f.Push(JValue.I(0));f.Pc=982;continue;}
case 982:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 983:{f.Pc=938;continue;}
case 986:{f.Push(f.Locals[4]);f.Pc=988;continue;}
case 988:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isDifferentNames","()Z","invokevirtual",991);}
case 991:{f.Pc=f.Pop().Int==0?1063:994;continue;}
case 994:{f.Push(f.Locals[1]);f.Pc=995;continue;}
case 995:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=998;continue;}
case 998:{f.Pc=f.Pop().Int==0?1063:1001;continue;}
case 1001:{f.Push(f.Locals[0]);f.Pc=1002;continue;}
case 1002:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1005);}
case 1005:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1008);}
case 1008:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1013);}
case 1013:{f.Locals[5]=f.Pop();f.Pc=1015;continue;}
case 1015:{f.Push(f.Locals[5]);f.Pc=1017;continue;}
case 1017:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1022);}
case 1022:{f.Pc=f.Pop().Int==0?1063:1025;continue;}
case 1025:{f.Push(f.Locals[5]);f.Pc=1027;continue;}
case 1027:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1032);}
case 1032:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1035;continue;}
case 1035:{f.Locals[6]=f.Pop();f.Pc=1037;continue;}
case 1037:{f.Push(f.Locals[1]);f.Pc=1038;continue;}
case 1038:{f.Push(f.Locals[6]);f.Pc=1040;continue;}
case 1040:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1060:1043;continue;}
case 1043:{f.Push(f.Locals[6]);f.Pc=1045;continue;}
case 1045:{f.Push(f.Locals[1]);f.Pc=1046;continue;}
case 1046:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1049;continue;}
case 1049:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",1052);}
case 1052:{return rt.Call(f,"forge/game/card/Card","sharesNameWith","(Ljava/lang/String;)Z","invokevirtual",1055);}
case 1055:{f.Pc=f.Pop().Int==0?1060:1058;continue;}
case 1058:{f.Push(JValue.I(0));f.Pc=1059;continue;}
case 1059:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1060:{f.Pc=1015;continue;}
case 1063:{f.Push(f.Locals[4]);f.Pc=1065;continue;}
case 1065:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isSameController","()Z","invokevirtual",1068);}
case 1068:{f.Pc=f.Pop().Int==0?1147:1071;continue;}
case 1071:{f.Push(f.Locals[1]);f.Pc=1072;continue;}
case 1072:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1075;continue;}
case 1075:{f.Pc=f.Pop().Int==0?1147:1078;continue;}
case 1078:{f.Push(f.Locals[1]);f.Pc=1079;continue;}
case 1079:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1082;continue;}
case 1082:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1085);}
case 1085:{f.Locals[5]=f.Pop();f.Pc=1087;continue;}
case 1087:{f.Push(f.Locals[0]);f.Pc=1088;continue;}
case 1088:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1091);}
case 1091:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1094);}
case 1094:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1099);}
case 1099:{f.Locals[6]=f.Pop();f.Pc=1101;continue;}
case 1101:{f.Push(f.Locals[6]);f.Pc=1103;continue;}
case 1103:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1108);}
case 1108:{f.Pc=f.Pop().Int==0?1147:1111;continue;}
case 1111:{f.Push(f.Locals[6]);f.Pc=1113;continue;}
case 1113:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1118);}
case 1118:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1121;continue;}
case 1121:{f.Locals[7]=f.Pop();f.Pc=1123;continue;}
case 1123:{f.Push(f.Locals[1]);f.Pc=1124;continue;}
case 1124:{f.Push(f.Locals[7]);f.Pc=1126;continue;}
case 1126:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1144:1129;continue;}
case 1129:{f.Push(f.Locals[7]);f.Pc=1131;continue;}
case 1131:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1134);}
case 1134:{f.Push(f.Locals[5]);f.Pc=1136;continue;}
case 1136:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1139);}
case 1139:{f.Pc=f.Pop().Int!=0?1144:1142;continue;}
case 1142:{f.Push(JValue.I(0));f.Pc=1143;continue;}
case 1143:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1144:{f.Pc=1101;continue;}
case 1147:{f.Push(f.Locals[4]);f.Pc=1149;continue;}
case 1149:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isDifferentControllers","()Z","invokevirtual",1152);}
case 1152:{f.Pc=f.Pop().Int!=0?1167:1155;continue;}
case 1155:{f.Push(f.Locals[4]);f.Pc=1157;continue;}
case 1157:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isForEachPlayer","()Z","invokevirtual",1160);}
case 1160:{f.Pc=f.Pop().Int==0?1257:1163;continue;}
case 1163:{f.Push(f.Locals[2]);f.Pc=1164;continue;}
case 1164:{f.Pc=f.Pop().Int!=0?1257:1167;continue;}
case 1167:{f.Push(f.Locals[1]);f.Pc=1168;continue;}
case 1168:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1171;continue;}
case 1171:{f.Pc=f.Pop().Int==0?1257:1174;continue;}
case 1174:{f.Push(f.Locals[1]);f.Pc=1175;continue;}
case 1175:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1178;continue;}
case 1178:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1181);}
case 1181:{f.Locals[5]=f.Pop();f.Pc=1183;continue;}
case 1183:{f.Push(f.Locals[0]);f.Pc=1184;continue;}
case 1184:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1187);}
case 1187:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1190);}
case 1190:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1195);}
case 1195:{f.Locals[6]=f.Pop();f.Pc=1197;continue;}
case 1197:{f.Push(f.Locals[6]);f.Pc=1199;continue;}
case 1199:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1204);}
case 1204:{f.Pc=f.Pop().Int==0?1257:1207;continue;}
case 1207:{f.Push(f.Locals[6]);f.Pc=1209;continue;}
case 1209:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1214);}
case 1214:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1217;continue;}
case 1217:{f.Locals[7]=f.Pop();f.Pc=1219;continue;}
case 1219:{f.Push(f.Locals[0]);f.Pc=1220;continue;}
case 1220:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1223);}
case 1223:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",1226);}
case 1226:{f.Push(f.Locals[7]);f.Pc=1228;continue;}
case 1228:{return rt.Call(f,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",1231);}
case 1231:{f.Locals[7]=f.Pop();f.Pc=1233;continue;}
case 1233:{f.Push(f.Locals[1]);f.Pc=1234;continue;}
case 1234:{f.Push(f.Locals[7]);f.Pc=1236;continue;}
case 1236:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1254:1239;continue;}
case 1239:{f.Push(f.Locals[7]);f.Pc=1241;continue;}
case 1241:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1244);}
case 1244:{f.Push(f.Locals[5]);f.Pc=1246;continue;}
case 1246:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1249);}
case 1249:{f.Pc=f.Pop().Int==0?1254:1252;continue;}
case 1252:{f.Push(JValue.I(0));f.Pc=1253;continue;}
case 1253:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1254:{f.Pc=1197;continue;}
case 1257:{f.Push(f.Locals[4]);f.Pc=1259;continue;}
case 1259:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isForEachPlayer","()Z","invokevirtual",1262);}
case 1262:{f.Pc=f.Pop().Int==0?1292:1265;continue;}
case 1265:{f.Push(f.Locals[2]);f.Pc=1266;continue;}
case 1266:{f.Pc=f.Pop().Int==0?1292:1269;continue;}
case 1269:{f.Push(f.Locals[1]);f.Pc=1270;continue;}
case 1270:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1273;continue;}
case 1273:{f.Pc=f.Pop().Int==0?1292:1276;continue;}
case 1276:{f.Push(f.Locals[0]);f.Pc=1277;continue;}
case 1277:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1280);}
case 1280:{f.Push(f.Locals[1]);f.Pc=1281;continue;}
case 1281:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1284;continue;}
case 1284:{return rt.Call(f,"forge/game/spellability/TargetChoices","forEachControllerChanged","(Lforge/game/card/Card;)Z","invokevirtual",1287);}
case 1287:{f.Pc=f.Pop().Int==0?1292:1290;continue;}
case 1290:{f.Push(JValue.I(0));f.Pc=1291;continue;}
case 1291:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1292:{f.Push(f.Locals[4]);f.Pc=1294;continue;}
case 1294:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isWithoutSameCreatureType","()Z","invokevirtual",1297);}
case 1297:{f.Pc=f.Pop().Int==0?1366:1300;continue;}
case 1300:{f.Push(f.Locals[1]);f.Pc=1301;continue;}
case 1301:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1304;continue;}
case 1304:{f.Pc=f.Pop().Int==0?1366:1307;continue;}
case 1307:{f.Push(f.Locals[0]);f.Pc=1308;continue;}
case 1308:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1311);}
case 1311:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1314);}
case 1314:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1319);}
case 1319:{f.Locals[5]=f.Pop();f.Pc=1321;continue;}
case 1321:{f.Push(f.Locals[5]);f.Pc=1323;continue;}
case 1323:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1328);}
case 1328:{f.Pc=f.Pop().Int==0?1366:1331;continue;}
case 1331:{f.Push(f.Locals[5]);f.Pc=1333;continue;}
case 1333:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1338);}
case 1338:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1341;continue;}
case 1341:{f.Locals[6]=f.Pop();f.Pc=1343;continue;}
case 1343:{f.Push(f.Locals[1]);f.Pc=1344;continue;}
case 1344:{f.Push(f.Locals[6]);f.Pc=1346;continue;}
case 1346:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1363:1349;continue;}
case 1349:{f.Push(f.Locals[6]);f.Pc=1351;continue;}
case 1351:{f.Push(f.Locals[1]);f.Pc=1352;continue;}
case 1352:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1355;continue;}
case 1355:{return rt.Call(f,"forge/game/card/Card","sharesCreatureTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",1358);}
case 1358:{f.Pc=f.Pop().Int==0?1363:1361;continue;}
case 1361:{f.Push(JValue.I(0));f.Pc=1362;continue;}
case 1362:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1363:{f.Pc=1321;continue;}
case 1366:{f.Push(f.Locals[4]);f.Pc=1368;continue;}
case 1368:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isWithSameCreatureType","()Z","invokevirtual",1371);}
case 1371:{f.Pc=f.Pop().Int==0?1440:1374;continue;}
case 1374:{f.Push(f.Locals[1]);f.Pc=1375;continue;}
case 1375:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1378;continue;}
case 1378:{f.Pc=f.Pop().Int==0?1440:1381;continue;}
case 1381:{f.Push(f.Locals[0]);f.Pc=1382;continue;}
case 1382:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1385);}
case 1385:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1388);}
case 1388:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1393);}
case 1393:{f.Locals[5]=f.Pop();f.Pc=1395;continue;}
case 1395:{f.Push(f.Locals[5]);f.Pc=1397;continue;}
case 1397:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1402);}
case 1402:{f.Pc=f.Pop().Int==0?1440:1405;continue;}
case 1405:{f.Push(f.Locals[5]);f.Pc=1407;continue;}
case 1407:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1412);}
case 1412:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1415;continue;}
case 1415:{f.Locals[6]=f.Pop();f.Pc=1417;continue;}
case 1417:{f.Push(f.Locals[1]);f.Pc=1418;continue;}
case 1418:{f.Push(f.Locals[6]);f.Pc=1420;continue;}
case 1420:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1437:1423;continue;}
case 1423:{f.Push(f.Locals[6]);f.Pc=1425;continue;}
case 1425:{f.Push(f.Locals[1]);f.Pc=1426;continue;}
case 1426:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1429;continue;}
case 1429:{return rt.Call(f,"forge/game/card/Card","sharesCreatureTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",1432);}
case 1432:{f.Pc=f.Pop().Int!=0?1437:1435;continue;}
case 1435:{f.Push(JValue.I(0));f.Pc=1436;continue;}
case 1436:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1437:{f.Pc=1395;continue;}
case 1440:{f.Push(f.Locals[4]);f.Pc=1442;continue;}
case 1442:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isWithSameCardType","()Z","invokevirtual",1445);}
case 1445:{f.Pc=f.Pop().Int==0?1514:1448;continue;}
case 1448:{f.Push(f.Locals[1]);f.Pc=1449;continue;}
case 1449:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1452;continue;}
case 1452:{f.Pc=f.Pop().Int==0?1514:1455;continue;}
case 1455:{f.Push(f.Locals[0]);f.Pc=1456;continue;}
case 1456:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1459);}
case 1459:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1462);}
case 1462:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1467);}
case 1467:{f.Locals[5]=f.Pop();f.Pc=1469;continue;}
case 1469:{f.Push(f.Locals[5]);f.Pc=1471;continue;}
case 1471:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1476);}
case 1476:{f.Pc=f.Pop().Int==0?1514:1479;continue;}
case 1479:{f.Push(f.Locals[5]);f.Pc=1481;continue;}
case 1481:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1486);}
case 1486:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1489;continue;}
case 1489:{f.Locals[6]=f.Pop();f.Pc=1491;continue;}
case 1491:{f.Push(f.Locals[1]);f.Pc=1492;continue;}
case 1492:{f.Push(f.Locals[6]);f.Pc=1494;continue;}
case 1494:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1511:1497;continue;}
case 1497:{f.Push(f.Locals[6]);f.Pc=1499;continue;}
case 1499:{f.Push(f.Locals[1]);f.Pc=1500;continue;}
case 1500:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1503;continue;}
case 1503:{return rt.Call(f,"forge/game/card/Card","sharesCardTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",1506);}
case 1506:{f.Pc=f.Pop().Int!=0?1511:1509;continue;}
case 1509:{f.Push(JValue.I(0));f.Pc=1510;continue;}
case 1510:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1511:{f.Pc=1469;continue;}
case 1514:{f.Push(f.Locals[1]);f.Pc=1515;continue;}
case 1515:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/GameEntity")?1:0));f.Pc=1518;continue;}
case 1518:{f.Pc=f.Pop().Int==0?1593:1521;continue;}
case 1521:{f.Push(f.Locals[1]);f.Pc=1522;continue;}
case 1522:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1525;continue;}
case 1525:{f.Locals[5]=f.Pop();f.Pc=1527;continue;}
case 1527:{f.Push(f.Locals[5]);f.Pc=1529;continue;}
case 1529:{f.Push(f.Locals[4]);f.Pc=1531;continue;}
case 1531:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getValidTgts","()[Ljava/lang/String;","invokevirtual",1534);}
case 1534:{f.Push(f.Locals[0]);f.Pc=1535;continue;}
case 1535:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",1538);}
case 1538:{f.Push(f.Locals[0]);f.Pc=1539;continue;}
case 1539:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1542);}
case 1542:{f.Push(f.Locals[0]);f.Pc=1543;continue;}
case 1543:{return rt.Call(f,"forge/game/GameEntity","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",1546);}
case 1546:{f.Pc=f.Pop().Int!=0?1551:1549;continue;}
case 1549:{f.Push(JValue.I(0));f.Pc=1550;continue;}
case 1550:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1551:{f.Push(f.Locals[0]);f.Pc=1552;continue;}
case 1552:{f.Push(JValue.R(rt.String("TargetType")));f.Pc=1555;continue;}
case 1555:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1558);}
case 1558:{f.Pc=f.Pop().Int==0?1593:1561;continue;}
case 1561:{f.Push(f.Locals[5]);f.Pc=1563;continue;}
case 1563:{f.Push(f.Locals[0]);f.Pc=1564;continue;}
case 1564:{f.Push(JValue.R(rt.String("TargetType")));f.Pc=1567;continue;}
case 1567:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1570);}
case 1570:{f.Push(JValue.R(rt.String(",")));f.Pc=1573;continue;}
case 1573:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1576);}
case 1576:{f.Push(f.Locals[0]);f.Pc=1577;continue;}
case 1577:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",1580);}
case 1580:{f.Push(f.Locals[0]);f.Pc=1581;continue;}
case 1581:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1584);}
case 1584:{f.Push(f.Locals[0]);f.Pc=1585;continue;}
case 1585:{return rt.Call(f,"forge/game/GameEntity","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",1588);}
case 1588:{f.Pc=f.Pop().Int!=0?1593:1591;continue;}
case 1591:{f.Push(JValue.I(0));f.Pc=1592;continue;}
case 1592:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1593:{f.Push(f.Locals[1]);f.Pc=1594;continue;}
case 1594:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1597;continue;}
case 1597:{f.Pc=f.Pop().Int==0?1637:1600;continue;}
case 1600:{f.Push(f.Locals[1]);f.Pc=1601;continue;}
case 1601:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1604;continue;}
case 1604:{f.Locals[5]=f.Pop();f.Pc=1606;continue;}
case 1606:{f.Push(f.Locals[5]);f.Pc=1608;continue;}
case 1608:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1611);}
case 1611:{f.Pc=f.Pop().Reference==null?1637:1614;continue;}
case 1614:{f.Push(f.Locals[4]);f.Pc=1616;continue;}
case 1616:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getZone","()Ljava/util/List;","invokevirtual",1619);}
case 1619:{f.Push(f.Locals[5]);f.Pc=1621;continue;}
case 1621:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1624);}
case 1624:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1627);}
case 1627:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1632);}
case 1632:{f.Pc=f.Pop().Int!=0?1637:1635;continue;}
case 1635:{f.Push(JValue.I(0));f.Pc=1636;continue;}
case 1636:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1637:{f.Push(f.Locals[1]);f.Pc=1638;continue;}
case 1638:{f.Push(f.Locals[0]);f.Pc=1639;continue;}
case 1639:{return rt.Call(f,"forge/game/GameObject","canBeTargetedBy","(Lforge/game/spellability/SpellAbility;)Z","invokeinterface",1644);}
case 1644:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9379(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9380(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","pipsToReduce","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9381(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","pipsToReduce","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",17);}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9382(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","tappedForConvoke","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9383(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","tappedForConvoke","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",16);}
case 16:{f.StackOp("pop");f.Pc=17;continue;}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9384(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","tappedForConvoke","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9385(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Emerge","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Emerge","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9386(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","sacrificedAsEmerge","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9387(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","sacrificedAsEmerge","Lforge/game/card/Card;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9388(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","sacrificedAsEmerge","Lforge/game/card/Card;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9389(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Offering","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Offering","Lforge/game/spellability/OptionalCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9390(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","sacrificedAsOffering","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9391(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","sacrificedAsOffering","Lforge/game/card/Card;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9392(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","sacrificedAsOffering","Lforge/game/card/Card;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9393(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","splicedCards","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9394(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","splicedCards","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","splicedCards","Lforge/game/card/CardCollection;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","splicedCards","Lforge/game/card/CardCollection;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9395(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",25);}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",31);}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?74:43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[6]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",62);}
case 62:{f.Locals[7]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[7]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Pc=33;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9396(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",7);}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?18:10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Pc=2;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9397(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Reference==null?17:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",13);}
case 13:{f.Locals[1]=f.Pop();f.Pc=14;continue;}
case 14:{f.Pc=2;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9398(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9399(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","FUSE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","FUSE","Lforge/game/keyword/Keyword;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?31:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference==null?31:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Reference==null?49:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",43);}
case 43:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/CardTraitBase","getSVarFallback","(Ljava/lang/String;)Ljava/util/List;","invokespecial",55);}
case 55:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9400(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","undoable","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?31:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payCosts","Lforge/game/cost/Cost;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/cost/Cost","isUndoable","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?31:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?31:27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{f.Pc=32;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9401(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","undoable","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9402(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isUndoable","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?37:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/mana/ManaPool","accountFor","(Lforge/game/spellability/AbilityManaPart;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?37:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payCosts","Lforge/game/cost/Cost;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","hostCard","Lforge/game/card/Card;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/cost/Cost","refundPaidCost","(Lforge/game/card/Card;)V","invokevirtual",35);}
case 35:{f.Push(JValue.I(1));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9403(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","isCastFromPlayEffect","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9404(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","isCastFromPlayEffect","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9405(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","isCopied","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9406(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","isCopied","Z",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Reference==null?20:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",16);}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/AbilitySub","setCopied","(Z)V","invokevirtual",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9407(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","mayChooseNewTargets","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9408(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","mayChooseNewTargets","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9409(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Announce")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",12);}
case 12:{f.Pc=f.Pop().Int==0?17:15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(44));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=30;continue;}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[5]);f.Pc=39;continue;}
case 39:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?69:42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[6]);f.Pc=46;continue;}
case 46:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=47;continue;}
case 47:{f.Locals[7]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[7]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?63:61;continue;}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 63:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=66;continue;}
case 66:{f.Pc=35;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9410(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Announce")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",12);}
case 12:{f.Pc=f.Pop().Int==0?44:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","mapParams","Ljava/util/Map;"));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Announce")));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","originalMapParams","Ljava/util/Map;"));f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("Announce")));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{return JStep.ReturnVoid;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(44));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",50);}
case 50:{f.Locals[3]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Locals[4]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=57;continue;}
case 57:{f.Locals[5]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?95:69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[6]);f.Pc=73;continue;}
case 73:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=74;continue;}
case 74:{f.Locals[7]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[7]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",81);}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?89:88;continue;}
case 88:{return JStep.ReturnVoid;}
case 89:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=92;continue;}
case 92:{f.Pc=62;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","mapParams","Ljava/util/Map;"));f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("Announce")));f.Pc=102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9410:104:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",109);}
case 109:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","originalMapParams","Ljava/util/Map;"));f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("Announce")));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9410:124:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",129);}
case 129:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",134);}
case 134:{f.StackOp("pop");f.Pc=135;continue;}
case 135:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9411(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTargetSpellAbility","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9412(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","targetRestrictions","Lforge/game/spellability/TargetRestrictions;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9413(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","targetRestrictions","Lforge/game/spellability/TargetRestrictions;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9414(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","targetRestrictions","Lforge/game/spellability/TargetRestrictions;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9415(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","targetChosen","Lforge/game/spellability/TargetChoices;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9416(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","targetChosen","Lforge/game/spellability/TargetChoices;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9417(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.EnsureInitialized(f,"forge/game/spellability/TargetChoices"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/TargetChoices")));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/TargetChoices","<init>","()V","invokespecial",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","targetChosen","Lforge/game/spellability/TargetChoices;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9418(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("DividedAsYouChoose")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9419(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/TargetChoices","addDividedAllocation","(Lforge/game/GameObject;Ljava/lang/Integer;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9420(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/TargetChoices","getDividedValue","(Lforge/game/GameObject;)Ljava/lang/Integer;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9421(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTotalDividedValue","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9422(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","dividedValue","Ljava/lang/Integer;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9423(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","dividedValue","Ljava/lang/Integer;"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference!=null?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","dividedValue","Ljava/lang/Integer;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTotalDividedValue","()I","invokevirtual",27);}
case 27:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9424(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference==null?71:6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?63:13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetTargets","()V","invokevirtual",17);}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/TargetChoices","add","(Lforge/game/GameObject;)Z","invokevirtual",25);}
case 25:{f.StackOp("pop");f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/spellability/TargetChoices","getDividedValues","()Ljava/util/Collection;","invokevirtual",33);}
case 33:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int!=0?71:41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/spellability/TargetChoices","getDividedValues","()Ljava/util/Collection;","invokevirtual",50);}
case 50:{f.Push(JValue.R(null));f.Pc=51;continue;}
case 51:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","addDividedAllocation","(Lforge/game/GameObject;Ljava/lang/Integer;)V","invokevirtual",60);}
case 60:{f.Pc=71;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",67);}
case 67:{f.Locals[3]=f.Pop();f.Pc=68;continue;}
case 68:{f.Pc=2;continue;}
case 71:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9425(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/spellability/TargetChoices","size","()I","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMaxTargets","()I","invokevirtual",20);}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9426(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMinTargets","()I","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/spellability/TargetChoices","isEmpty","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9427(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","hostCard","Lforge/game/card/Card;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isMinTargetsChosen","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9428(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","hostCard","Lforge/game/card/Card;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isMaxTargetsChosen","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9429(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getMinTargets","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)I","invokevirtual",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9430(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getMaxTargets","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)I","invokevirtual",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9431(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/spellability/TargetChoices","isEmpty","()Z","invokevirtual",14);}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","isMinTargetChosen","()Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int!=0?24:22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMaxTargets","()I","invokevirtual",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/game/spellability/TargetChoices","size","()I","invokevirtual",35);}
case 35:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?42:38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{f.Pc=43;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9432(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference==null?39:13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?31:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",25);}
case 25:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",35);}
case 35:{f.Locals[2]=f.Pop();f.Pc=36;continue;}
case 36:{f.Pc=9;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9433(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","targetChosen","Lforge/game/spellability/TargetChoices;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9434(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?23:4;continue;}
case 4:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",11);}
case 11:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",14);}
case 14:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9434:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",19);}
case 19:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",22);}
case 22:{return JStep.ReturnVoid;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetTargets","()V","invokevirtual",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","targetChosen","Lforge/game/spellability/TargetChoices;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/TargetChoices","add","(Lforge/game/GameObject;)Z","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",48);}
case 48:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9434:48:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",53);}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",56);}
case 56:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9435(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/spellability/TargetChoices","isTargetingAnyCard","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?18:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",17);}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/spellability/TargetChoices","isTargetingAnySpell","()Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?82:28;continue;}
case 28:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",35);}
case 35:{f.Locals[1]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",40);}
case 40:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetSpells","()Ljava/lang/Iterable;","invokevirtual",43);}
case 43:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",48);}
case 48:{f.Locals[2]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?80:58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",64);}
case 64:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=67;continue;}
case 67:{f.Locals[3]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",73);}
case 73:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",76);}
case 76:{f.StackOp("pop");f.Pc=77;continue;}
case 77:{f.Pc=49;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return JStep.Return(f.Pop());}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParentTargetingCard","()Lforge/game/spellability/SpellAbility;","invokevirtual",86);}
case 86:{f.Locals[1]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(JValue.R(null));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?97:92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","findTargetedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",96);}
case 96:{return JStep.Return(f.Pop());}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParentTargetingSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",101);}
case 101:{f.Locals[1]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(JValue.R(null));f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?112:107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/spellability/SpellAbility","findTargetedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",111);}
case 111:{return JStep.Return(f.Pop());}
case 112:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=115;continue;}
case 115:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9436(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/spellability/TargetChoices","isTargetingAnyCard","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?14:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Pc=18;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParentTargetingCard","()Lforge/game/spellability/SpellAbility;","invokevirtual",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9437(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?29:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/spellability/TargetChoices","isTargetingAnyCard","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?21:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",25);}
case 25:{f.Locals[1]=f.Pop();f.Pc=26;continue;}
case 26:{f.Pc=5;continue;}
case 29:{f.Push(JValue.R(null));f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9438(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/spellability/TargetChoices","isTargetingAnySpell","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?14:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Pc=18;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParentTargetingSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9439(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?29:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/spellability/TargetChoices","isTargetingAnySpell","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?21:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",25);}
case 25:{f.Locals[1]=f.Pop();f.Pc=26;continue;}
case 26:{f.Pc=5;continue;}
case 29:{f.Push(JValue.R(null));f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9440(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/spellability/TargetChoices","isTargetingAnyPlayer","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?14:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Pc=18;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParentTargetingPlayer","()Lforge/game/spellability/SpellAbility;","invokevirtual",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9441(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?29:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/spellability/TargetChoices","isTargetingAnyPlayer","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?21:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",25);}
case 25:{f.Locals[1]=f.Pop();f.Pc=26;continue;}
case 26:{f.Pc=5;continue;}
case 29:{f.Push(JValue.R(null));f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9442(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference==null?39:13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?31:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",25);}
case 25:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",35);}
case 35:{f.Locals[2]=f.Pop();f.Pc=36;continue;}
case 36:{f.Pc=9;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9443(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isWrapper","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?15:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/WrappedAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getWrappedAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","equals","(Ljava/lang/Object;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?30:28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("TargetType")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?71:40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("TargetType")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Push(JValue.R(rt.String(",")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",58);}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",62);}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int!=0?71:69;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("TargetsWithControllerProperty")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?163:81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("TargetsWithControllerProperty")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",88);}
case 88:{f.Locals[3]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("cmcLECardsInGraveyard")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?126:99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",103);}
case 103:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",106);}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",110);}
case 110:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",121);}
case 121:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?126:124;continue;}
case 124:{f.Push(JValue.I(0));f.Pc=125;continue;}
case 125:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("powerLECardsInGraveyard")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",133);}
case 133:{f.Pc=f.Pop().Int==0?163:136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",140);}
case 140:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",143);}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",147);}
case 147:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",153);}
case 153:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",158);}
case 158:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?163:161;continue;}
case 161:{f.Push(JValue.I(0));f.Pc=162;continue;}
case 162:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 163:{f.Push(f.Locals[2]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getSAValidTargeting","()Ljava/lang/String;","invokevirtual",167);}
case 167:{f.Locals[3]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[3]);f.Pc=169;continue;}
case 169:{f.Pc=f.Pop().Reference==null?292:172;continue;}
case 172:{f.Push(JValue.I(0));f.Pc=173;continue;}
case 173:{f.Locals[4]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[1]);f.Pc=176;continue;}
case 176:{f.Locals[5]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[5]);f.Pc=180;continue;}
case 180:{f.Pc=f.Pop().Reference==null?285:183;continue;}
case 183:{f.Push(f.Locals[4]);f.Pc=185;continue;}
case 185:{f.Pc=f.Pop().Int!=0?285:188;continue;}
case 188:{f.Push(f.Locals[5]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",193);}
case 193:{f.Pc=f.Pop().Int==0?275:196;continue;}
case 196:{f.Push(f.Locals[5]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",201);}
case 201:{f.Locals[6]=f.Pop();f.Pc=203;continue;}
case 203:{f.Push(f.Locals[6]);f.Pc=205;continue;}
case 205:{f.Pc=f.Pop().Reference!=null?211:208;continue;}
case 208:{f.Pc=178;continue;}
case 211:{f.Push(f.Locals[6]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/spellability/TargetChoices","iterator","()Ljava/util/Iterator;","invokevirtual",216);}
case 216:{f.Locals[7]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[7]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",225);}
case 225:{f.Pc=f.Pop().Int==0?275:228;continue;}
case 228:{f.Push(f.Locals[7]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",235);}
case 235:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=238;continue;}
case 238:{f.Locals[8]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[8]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[3]);f.Pc=243;continue;}
case 243:{f.Push(JValue.R(rt.String(",")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",249);}
case 249:{f.Push(f.Locals[0]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",253);}
case 253:{f.Push(f.Locals[0]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",257);}
case 257:{f.Push(f.Locals[0]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/GameObject","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokeinterface",263);}
case 263:{f.Pc=f.Pop().Int==0?272:266;continue;}
case 266:{f.Push(JValue.I(1));f.Pc=267;continue;}
case 267:{f.Locals[4]=f.Pop();f.Pc=269;continue;}
case 269:{f.Pc=275;continue;}
case 272:{f.Pc=218;continue;}
case 275:{f.Push(f.Locals[5]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",280);}
case 280:{f.Locals[5]=f.Pop();f.Pc=282;continue;}
case 282:{f.Pc=178;continue;}
case 285:{f.Push(f.Locals[4]);f.Pc=287;continue;}
case 287:{f.Pc=f.Pop().Int!=0?292:290;continue;}
case 290:{f.Push(JValue.I(0));f.Pc=291;continue;}
case 291:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 292:{f.Push(f.Locals[1]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",296);}
case 296:{f.Locals[4]=f.Pop();f.Pc=298;continue;}
case 298:{f.Push(f.Locals[4]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",303);}
case 303:{f.Pc=f.Pop().Int==0?352:306;continue;}
case 306:{f.Push(f.Locals[4]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/card/Card","isEmblem","()Z","invokevirtual",311);}
case 311:{f.Pc=f.Pop().Int!=0?352:314;continue;}
case 314:{f.Push(f.Locals[4]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",319);}
case 319:{f.Pc=f.Pop().Reference==null?332:322;continue;}
case 322:{f.Push(f.Locals[4]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",327);}
case 327:{f.Locals[4]=f.Pop();f.Pc=329;continue;}
case 329:{f.Pc=352;continue;}
case 332:{f.Push(JValue.R(rt.String("Card")));f.Pc=335;continue;}
case 335:{f.Push(f.Locals[2]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getValidTgts","()[Ljava/lang/String;","invokevirtual",339);}
case 339:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","indexOfAny","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)I","invokestatic",342);}
case 342:{f.Push(JValue.I(-1));f.Pc=343;continue;}
case 343:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?350:346;continue;}
case 346:{f.Push(JValue.I(1));f.Pc=347;continue;}
case 347:{f.Pc=351;continue;}
case 350:{f.Push(JValue.I(0));f.Pc=351;continue;}
case 351:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 352:{f.Push(f.Locals[4]);f.Pc=354;continue;}
case 354:{f.Push(f.Locals[2]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getValidTgts","()[Ljava/lang/String;","invokevirtual",358);}
case 358:{f.Push(f.Locals[0]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",362);}
case 362:{f.Push(f.Locals[0]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",366);}
case 366:{f.Push(f.Locals[0]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"forge/game/card/Card","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",370);}
case 370:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9444(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/TargetChoices","contains","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?13:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Reference==null?34:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTargeting","(Lforge/game/GameObject;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?34:30;continue;}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{f.Pc=35;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9445(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?32:9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",18);}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(null));f.Pc=20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/player/PlayerController","chooseNewTargetsFor","(Lforge/game/spellability/SpellAbility;Ljava/util/function/Predicate;Z)Lforge/game/spellability/TargetChoices;","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Reference!=null?32:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTargets","(Lforge/game/spellability/TargetChoices;)V","invokevirtual",32);}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Reference==null?46:41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/AbilitySub","setParent","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",46);}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Locals[2]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Reference!=null?2:52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9446(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?95:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","clearTargets","()V","invokevirtual",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("TargetingPlayer")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?66:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("TargetingPlayer")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",40);}
case 40:{f.Locals[4]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",49);}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Choose the targeting player")));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(null));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{f.Locals[3]=f.Pop();f.Pc=63;continue;}
case 63:{f.Pc=71;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",70);}
case 70:{f.Locals[3]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Pc=f.Pop().Reference!=null?77:75;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTargetingPlayer","(Lforge/game/player/Player;)V","invokevirtual",82);}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",86);}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/player/PlayerController","chooseTargetsFor","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int!=0?95:93;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",99);}
case 99:{f.Locals[3]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[3]);f.Pc=101;continue;}
case 101:{f.Pc=f.Pop().Reference==null?109:104;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/spellability/AbilitySub","setParent","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",109);}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{f.Locals[1]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Pc=f.Pop().Reference!=null?7:115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/staticability/StaticAbilityMustTarget","meetsMustTargetRestriction","(Lforge/game/spellability/SpellAbility;)Z","invokestatic",119);}
case 119:{f.Pc=f.Pop().Int!=0?151:122;continue;}
case 122:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",125);}
case 125:{f.Push(JValue.R(rt.String("lblInvalidTargetSpecification")));f.Pc=128;continue;}
case 128:{f.Push(JValue.I(0));f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",135);}
case 135:{f.Locals[3]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",140);}
case 140:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",143);}
case 143:{f.Push(JValue.R(null));f.Pc=144;continue;}
case 144:{f.Push(JValue.R(null));f.Pc=145;continue;}
case 145:{f.Push(f.Locals[3]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/player/PlayerController","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;)V","invokevirtual",149);}
case 149:{f.Push(JValue.I(0));f.Pc=150;continue;}
case 150:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 151:{f.Push(JValue.I(1));f.Pc=152;continue;}
case 152:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9447(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?40:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetTargets","()V","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?40:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("DividedAsYouChoose")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",34);}
case 34:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","dividedValue","Ljava/lang/Integer;",value);f.Pc=40;continue;}
case 40:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9448(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("\\.")));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(2));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",8);}
case 8:{f.Locals[5]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",14);}
case 14:{f.Locals[6]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{f.Locals[7]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[5]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("!")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?47:32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{f.Locals[7]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",46);}
case 46:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("Spell")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?71:60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int!=0?274:68;continue;}
case 68:{f.Push(f.Locals[7]);f.Pc=70;continue;}
case 70:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(0));f.Pc=74;continue;}
case 74:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("Ability")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?95:84;continue;}
case 84:{f.Push(f.Locals[6]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int!=0?274:92;continue;}
case 92:{f.Push(f.Locals[7]);f.Pc=94;continue;}
case 94:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 95:{f.Push(f.Locals[5]);f.Pc=97;continue;}
case 97:{f.Push(JValue.I(0));f.Pc=98;continue;}
case 98:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("Instant")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?127:108;continue;}
case 108:{f.Push(f.Locals[6]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",113);}
case 113:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/card/CardTypeView","isInstant","()Z","invokeinterface",121);}
case 121:{f.Pc=f.Pop().Int!=0?274:124;continue;}
case 124:{f.Push(f.Locals[7]);f.Pc=126;continue;}
case 126:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 127:{f.Push(f.Locals[5]);f.Pc=129;continue;}
case 129:{f.Push(JValue.I(0));f.Pc=130;continue;}
case 130:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String("Sorcery")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",137);}
case 137:{f.Pc=f.Pop().Int==0?159:140;continue;}
case 140:{f.Push(f.Locals[6]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",145);}
case 145:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",148);}
case 148:{return rt.Call(f,"forge/card/CardTypeView","isSorcery","()Z","invokeinterface",153);}
case 153:{f.Pc=f.Pop().Int!=0?274:156;continue;}
case 156:{f.Push(f.Locals[7]);f.Pc=158;continue;}
case 158:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{f.Push(JValue.I(0));f.Pc=162;continue;}
case 162:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String("Triggered")));f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",169);}
case 169:{f.Pc=f.Pop().Int==0?183:172;continue;}
case 172:{f.Push(f.Locals[6]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int!=0?274:180;continue;}
case 180:{f.Push(f.Locals[7]);f.Pc=182;continue;}
case 182:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 183:{f.Push(f.Locals[5]);f.Pc=185;continue;}
case 185:{f.Push(JValue.I(0));f.Pc=186;continue;}
case 186:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=187;continue;}
case 187:{f.Push(JValue.R(rt.String("Activated")));f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",193);}
case 193:{f.Pc=f.Pop().Int==0?207:196;continue;}
case 196:{f.Push(f.Locals[6]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",201);}
case 201:{f.Pc=f.Pop().Int!=0?274:204;continue;}
case 204:{f.Push(f.Locals[7]);f.Pc=206;continue;}
case 206:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 207:{f.Push(f.Locals[5]);f.Pc=209;continue;}
case 209:{f.Push(JValue.I(0));f.Pc=210;continue;}
case 210:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=211;continue;}
case 211:{f.Push(JValue.R(rt.String("Static")));f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",217);}
case 217:{f.Pc=f.Pop().Int==0?231:220;continue;}
case 220:{f.Push(f.Locals[6]);f.Pc=222;continue;}
case 222:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilityStatic")?1:0));f.Pc=225;continue;}
case 225:{f.Pc=f.Pop().Int!=0?274:228;continue;}
case 228:{f.Push(f.Locals[7]);f.Pc=230;continue;}
case 230:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 231:{f.Push(f.Locals[5]);f.Pc=233;continue;}
case 233:{f.Push(JValue.I(0));f.Pc=234;continue;}
case 234:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=235;continue;}
case 235:{f.Push(JValue.R(rt.String("LandAbility")));f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",241);}
case 241:{f.Pc=f.Pop().Int==0?255:244;continue;}
case 244:{f.Push(f.Locals[6]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/spellability/SpellAbility","isLandAbility","()Z","invokevirtual",249);}
case 249:{f.Pc=f.Pop().Int!=0?274:252;continue;}
case 252:{f.Push(f.Locals[7]);f.Pc=254;continue;}
case 254:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 255:{f.Push(f.Locals[5]);f.Pc=257;continue;}
case 257:{f.Push(JValue.I(0));f.Pc=258;continue;}
case 258:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=259;continue;}
case 259:{f.Push(JValue.R(rt.String("SpellAbility")));f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",265);}
case 265:{f.Pc=f.Pop().Int==0?271:268;continue;}
case 268:{f.Pc=274;continue;}
case 271:{f.Push(f.Locals[7]);f.Pc=273;continue;}
case 273:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 274:{f.Push(f.Locals[5]);f.Pc=276;continue;}
case 276:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=277;continue;}
case 277:{f.Push(JValue.I(1));f.Pc=278;continue;}
case 278:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?345:281;continue;}
case 281:{f.Push(f.Locals[5]);f.Pc=283;continue;}
case 283:{f.Push(JValue.I(1));f.Pc=284;continue;}
case 284:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=285;continue;}
case 285:{f.Locals[8]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[8]);f.Pc=289;continue;}
case 289:{f.Push(JValue.R(rt.String("\\+")));f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",295);}
case 295:{f.Locals[9]=f.Pop();f.Pc=297;continue;}
case 297:{f.Push(f.Locals[9]);f.Pc=299;continue;}
case 299:{f.Locals[10]=f.Pop();f.Pc=301;continue;}
case 301:{f.Push(f.Locals[10]);f.Pc=303;continue;}
case 303:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=304;continue;}
case 304:{f.Locals[11]=f.Pop();f.Pc=306;continue;}
case 306:{f.Push(JValue.I(0));f.Pc=307;continue;}
case 307:{f.Locals[12]=f.Pop();f.Pc=309;continue;}
case 309:{f.Push(f.Locals[12]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[11]);f.Pc=313;continue;}
case 313:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?345:316;continue;}
case 316:{f.Push(f.Locals[10]);f.Pc=318;continue;}
case 318:{f.Push(f.Locals[12]);f.Pc=320;continue;}
case 320:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=321;continue;}
case 321:{f.Locals[13]=f.Pop();f.Pc=323;continue;}
case 323:{f.Push(f.Locals[0]);f.Pc=324;continue;}
case 324:{f.Push(f.Locals[13]);f.Pc=326;continue;}
case 326:{f.Push(f.Locals[2]);f.Pc=327;continue;}
case 327:{f.Push(f.Locals[3]);f.Pc=328;continue;}
case 328:{f.Push(f.Locals[4]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasProperty","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",333);}
case 333:{f.Pc=f.Pop().Int!=0?339:336;continue;}
case 336:{f.Push(f.Locals[7]);f.Pc=338;continue;}
case 338:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 339:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=342;continue;}
case 342:{f.Pc=309;continue;}
case 345:{f.Push(f.Locals[7]);f.Pc=347;continue;}
case 347:{f.Pc=f.Pop().Int!=0?354:350;continue;}
case 350:{f.Push(JValue.I(1));f.Pc=351;continue;}
case 351:{f.Pc=355;continue;}
case 354:{f.Push(JValue.I(0));f.Pc=355;continue;}
case 355:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9449(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("!")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?32:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbilityProperty","hasProperty","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Z","invokestatic",23);}
case 23:{f.Pc=f.Pop().Int!=0?30:26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{f.Pc=31;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbilityProperty","hasProperty","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Z","invokestatic",41);}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9450(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","hostCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?17:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","hostCard","Lforge/game/card/Card;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Reference!=null?19:17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?38:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","hostCard","Lforge/game/card/Card;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card","hasConverge","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?38:36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","hostCard","Lforge/game/card/Card;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/card/CardRules","getOracleText","()Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Locals[1]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?68:56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("was spent to cast")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?68:66;continue;}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?87:75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("mana spent to pay")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?87:85;continue;}
case 85:{f.Push(JValue.I(1));f.Pc=86;continue;}
case 86:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 87:{f.Push(JValue.I(0));f.Pc=88;continue;}
case 88:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9451(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9452(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","chosenList","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9453(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","chosenList","Ljava/util/List;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9454(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/CardTraitBase","changeText","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","targetRestrictions","Lforge/game/spellability/TargetRestrictions;"));f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference==null?19:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","targetRestrictions","Lforge/game/spellability/TargetRestrictions;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","applyTargetTextChanges","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/cost/Cost","applyTextChangeEffects","(Lforge/game/CardTraitBase;)V","invokevirtual",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","originalStackDescription","Ljava/lang/String;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyDescriptionTextChangeEffects","(Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/lang/String;","invokestatic",36);}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","stackDescription","Ljava/lang/String;",value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","originalDescription","Ljava/lang/String;"));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyDescriptionTextChangeEffects","(Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/lang/String;","invokestatic",48);}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","description","Ljava/lang/String;",value);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/SpellAbility","getConditions","()Lforge/game/spellability/SpellAbilityCondition;","invokevirtual",55);}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",59);}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setConditions","(Ljava/util/Map;)V","invokevirtual",62);}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Reference==null?80:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",73);}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",77);}
case 77:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setRestrictions","(Ljava/util/Map;)V","invokevirtual",80);}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=84;continue;}
case 84:{f.Pc=f.Pop().Reference==null?105:87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/spellability/AbilitySub","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",94);}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?105:98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/spellability/AbilitySub","changeText","()V","invokevirtual",105);}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilities","Ljava/util/Map;"));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",114);}
case 114:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",119);}
case 119:{f.Locals[1]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",126);}
case 126:{f.Pc=f.Pop().Int==0?146:129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",135);}
case 135:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=138;continue;}
case 138:{f.Locals[2]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/spellability/SpellAbility","changeText","()V","invokevirtual",143);}
case 143:{f.Pc=120;continue;}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilityLists","Ljava/util/Map;"));f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",155);}
case 155:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",160);}
case 160:{f.Locals[1]=f.Pop();f.Pc=161;continue;}
case 161:{f.Push(f.Locals[1]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",167);}
case 167:{f.Pc=f.Pop().Int==0?218:170;continue;}
case 170:{f.Push(f.Locals[1]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",176);}
case 176:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=179;continue;}
case 179:{f.Locals[2]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",186);}
case 186:{f.Locals[3]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[3]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",193);}
case 193:{f.Pc=f.Pop().Int==0?215:196;continue;}
case 196:{f.Push(f.Locals[3]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",202);}
case 202:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=205;continue;}
case 205:{f.Locals[4]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(f.Locals[4]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/spellability/AbilitySub","changeText","()V","invokevirtual",212);}
case 212:{f.Pc=187;continue;}
case 215:{f.Pc=161;continue;}
case 218:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9455(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/CardTraitBase","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference==null?33:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/AbilitySub","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?33:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/AbilitySub","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V","invokevirtual",33);}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilities","Ljava/util/Map;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",42);}
case 42:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",47);}
case 47:{f.Locals[3]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?78:57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[4]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/spellability/SpellAbility","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V","invokevirtual",75);}
case 75:{f.Pc=48;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilityLists","Ljava/util/Map;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",87);}
case 87:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",92);}
case 92:{f.Locals[3]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",99);}
case 99:{f.Pc=f.Pop().Int==0?157:102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",108);}
case 108:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=111;continue;}
case 111:{f.Locals[4]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[4]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",120);}
case 120:{f.Locals[5]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[5]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",129);}
case 129:{f.Pc=f.Pop().Int==0?154:132;continue;}
case 132:{f.Push(f.Locals[5]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{f.Locals[6]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[6]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[2]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/spellability/AbilitySub","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V","invokevirtual",151);}
case 151:{f.Pc=122;continue;}
case 154:{f.Pc=93;continue;}
case 157:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9456(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/CardTraitBase","setIntrinsic","(Z)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?20:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/AbilitySub","setIntrinsic","(Z)V","invokevirtual",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilities","Ljava/util/Map;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",29);}
case 29:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",34);}
case 34:{f.Locals[2]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?70:44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[3]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",58);}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?67:62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",67);}
case 67:{f.Pc=35;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","additionalAbilityLists","Ljava/util/Map;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",79);}
case 79:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",84);}
case 84:{f.Locals[2]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",91);}
case 91:{f.Pc=f.Pop().Int==0?155:94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",100);}
case 100:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=103;continue;}
case 103:{f.Locals[3]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",110);}
case 110:{f.Locals[4]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[4]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",119);}
case 119:{f.Pc=f.Pop().Int==0?152:122;continue;}
case 122:{f.Push(f.Locals[4]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",129);}
case 129:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=132;continue;}
case 132:{f.Locals[5]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[5]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/spellability/AbilitySub","isIntrinsic","()Z","invokevirtual",139);}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?149:143;continue;}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/spellability/AbilitySub","setIntrinsic","(Z)V","invokevirtual",149);}
case 149:{f.Pc=112;continue;}
case 152:{f.Pc=85;continue;}
case 155:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9457(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","view","Lforge/game/spellability/SpellAbilityView;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","updateHostCard","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","view","Lforge/game/spellability/SpellAbilityView;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","updateDescription","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","view","Lforge/game/spellability/SpellAbilityView;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","updatePromptIfOnlyPossibleAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","view","Lforge/game/spellability/SpellAbilityView;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","updateIsSpell","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","view","Lforge/game/spellability/SpellAbilityView;"));f.Pc=36;continue;}
case 36:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9458(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManaAbility","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?24:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManaAbility","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?24:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","calculateScoreForManaAbility","()I","invokevirtual",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","calculateScoreForManaAbility","()I","invokevirtual",22);}
case 22:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9459(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","manaPart","Lforge/game/spellability/AbilityManaPart;"));f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?15:9;continue;}
case 9:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=12;continue;}
case 12:{f.Pc=60;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","manaPart","Lforge/game/spellability/AbilityManaPart;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","mana","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("Any")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?40:34;continue;}
case 34:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(7)));f.Pc=37;continue;}
case 37:{f.Pc=60;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",45);}
case 45:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=46;continue;}
case 46:{f.Locals[1]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("C")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","canProduce","(Ljava/lang/String;)Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int!=0?60:57;continue;}
case 57:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","payCosts","Lforge/game/cost/Cost;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",67);}
case 67:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",72);}
case 72:{f.Locals[2]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int==0?160:82;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",88);}
case 88:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=91;continue;}
case 91:{f.Locals[3]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[3]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/cost/CostPart","isReusable","()Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int!=0?102:99;continue;}
case 99:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(3)));f.Pc=102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/cost/CostPart","isRenewable","()Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int!=0?112:109;continue;}
case 109:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(3)));f.Pc=112;continue;}
case 112:{f.Push(f.Locals[3]);f.Pc=113;continue;}
case 113:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostTap")?1:0));f.Pc=116;continue;}
case 116:{f.Pc=f.Pop().Int==0?137:119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",123);}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",127);}
case 127:{f.Push(JValue.I(1));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/card/Card","canUntap","(Lforge/game/player/Player;Z)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int!=0?137:134;continue;}
case 134:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(10)));f.Pc=137;continue;}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostSacrifice")?1:0));f.Pc=141;continue;}
case 141:{f.Pc=f.Pop().Int==0?154:144;continue;}
case 144:{f.Push(f.Locals[3]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/cost/CostPart","payCostFromSource","()Z","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Int!=0?154:151;continue;}
case 151:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(40)));f.Pc=154;continue;}
case 154:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(1)));f.Pc=157;continue;}
case 157:{f.Pc=73;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/spellability/SpellAbility","isUndoable","()Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int!=0?170:167;continue;}
case 167:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(50)));f.Pc=170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","subAbility","Lforge/game/spellability/AbilitySub;"));f.Pc=174;continue;}
case 174:{f.Pc=f.Pop().Reference==null?180:177;continue;}
case 177:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(2)));f.Pc=180;continue;}
case 180:{f.Push(f.Locals[1]);f.Pc=181;continue;}
case 181:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9460(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","damageMap","Lforge/game/card/CardDamageTable;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","damageMap","Lforge/game/card/CardDamageTable;"));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Reference==null?27:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDamageMap","()Lforge/game/card/CardDamageTable;","invokevirtual",26);}
case 26:{return JStep.Return(f.Pop());}
case 27:{f.Push(JValue.R(null));f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9461(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","preventMap","Lforge/game/card/CardDamageTable;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","preventMap","Lforge/game/card/CardDamageTable;"));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Reference==null?27:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPreventMap","()Lforge/game/card/CardDamageTable;","invokevirtual",26);}
case 26:{return JStep.Return(f.Pop());}
case 27:{f.Push(JValue.R(null));f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9462(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","counterTable","Lforge/game/GameEntityCounterTable;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","counterTable","Lforge/game/GameEntityCounterTable;"));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Reference==null?27:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCounterTable","()Lforge/game/GameEntityCounterTable;","invokevirtual",26);}
case 26:{return JStep.Return(f.Pop());}
case 27:{f.Push(JValue.R(null));f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9463(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","changeZoneTable","Lforge/game/card/CardZoneTable;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","changeZoneTable","Lforge/game/card/CardZoneTable;"));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Reference==null?27:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getChangeZoneTable","()Lforge/game/card/CardZoneTable;","invokevirtual",26);}
case 26:{return JStep.Return(f.Pop());}
case 27:{f.Push(JValue.R(null));f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9464(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","loseLifeMap","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","loseLifeMap","Ljava/util/Map;"));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Reference==null?27:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLoseLifeMap","()Ljava/util/Map;","invokevirtual",26);}
case 26:{return JStep.Return(f.Pop());}
case 27:{f.Push(JValue.R(null));f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9465(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","damageMap","Lforge/game/card/CardDamageTable;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9466(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","preventMap","Lforge/game/card/CardDamageTable;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9467(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","counterTable","Lforge/game/GameEntityCounterTable;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9468(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","changeZoneTable","Lforge/game/card/CardZoneTable;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9469(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","loseLifeMap","Ljava/util/Map;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9470(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","grantorOriginal","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?11:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Pc=28;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","grantorOriginal","Lforge/game/spellability/SpellAbility;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","grantorOriginal","Lforge/game/spellability/SpellAbility;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9471(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","grantorOriginal","Lforge/game/spellability/SpellAbility;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9472(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","grantorStatic","Lforge/game/staticability/StaticAbility;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9473(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","grantorStatic","Lforge/game/staticability/StaticAbility;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9474(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","altCost","Lforge/game/spellability/AlternativeCost;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/AlternativeCost","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?13:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Reference==null?28:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",27);}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9475(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","altCost","Lforge/game/spellability/AlternativeCost;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","altCost","Lforge/game/spellability/AlternativeCost;"));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",16);}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Reference==null?26:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAlternativeCost","()Lforge/game/spellability/AlternativeCost;","invokevirtual",25);}
case 25:{return JStep.Return(f.Pop());}
case 26:{f.Push(JValue.R(null));f.Pc=27;continue;}
case 27:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9476(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","altCost","Lforge/game/spellability/AlternativeCost;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9477(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","xManaCostPaid","Ljava/lang/Integer;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9478(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","xManaCostPaid","Ljava/lang/Integer;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9479(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("XColor")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",19);}
case 19:{f.Locals[1]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("XColor")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Push(JValue.R(rt.String(",")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?85:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=54;continue;}
case 54:{f.Locals[6]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[6]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",61);}
case 61:{f.Push(JValue.I(2));f.Pc=62;continue;}
case 62:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?72:65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",70);}
case 70:{f.Locals[6]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=82;continue;}
case 82:{f.Pc=43;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",89);}
case 89:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9480(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","skip","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9481(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","skip","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9482(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","canCastTiming","(Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9483(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilityStatic")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?26:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isSorcerySpeed","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?26:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/player/Player","canCastSorcery","()Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int!=0?26:24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int!=0?42:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int!=0?42:40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?68:49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","isPwAbility","()Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int!=0?68:56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isSorcerySpeed","()Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int!=0?68:66;continue;}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/player/Player","canCastSorcery","()Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int!=0?84:75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/SpellAbility","withFlash","(Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?88:84;continue;}
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{f.Pc=89;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9484(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isInstantSpeed","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int!=0?26:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","isLandAbility","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?52:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCastFromPlayEffect","()Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int!=0?50:33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/Card","isInstant","()Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int!=0?50:40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","FLASH","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","FLASH","Lforge/game/keyword/Keyword;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?52:50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/staticability/StaticAbilityCastWithFlash","anyWithFlash","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokestatic",58);}
case 58:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9485(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","checkRestrictions","(Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9486(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9487(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","rollbackEffects","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",16);}
case 16:{f.StackOp("pop");f.Pc=17;continue;}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9488(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","rollbackEffects","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",15);}
case 15:{f.Locals[1]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?50:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[2]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",42);}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/GameAction","ceaseToExist","(Lforge/game/card/Card;Z)V","invokevirtual",47);}
case 47:{f.Pc=16;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","rollbackEffects","Lcom/google/common/base/Supplier;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",65);}
case 65:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9489(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Hidden")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int!=0?33:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("Origin")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?33:22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Origin")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/zone/ZoneType","isHidden","(Ljava/lang/String;)Z","invokestatic",32);}
case 32:{f.Locals[1]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9490(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidAfterStack")));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9491(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9492(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9493(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Reference!=null?13:9;continue;}
case 9:{f.Push(JValue.L(0));f.Pc=10;continue;}
case 10:{f.Pc=23;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",19);}
case 19:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",22);}
case 22:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=23;continue;}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalKeywordAmount","Lcom/google/common/collect/Table;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getKeyword","()Lforge/game/keyword/Keyword;","invokeinterface",34);}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getIdx","()J","invokeinterface",40);}
case 40:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",43);}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",47);}
case 47:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",50);}
case 50:{return rt.Call(f,"com/google/common/collect/Table","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",55);}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9494(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalKeywordAmount","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Table","containsRow","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9495(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalKeywordAmount","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Table","rowKeySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9496(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Reference!=null?13:9;continue;}
case 9:{f.Push(JValue.L(0));f.Pc=10;continue;}
case 10:{f.Pc=23;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",19);}
case 19:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",22);}
case 22:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=23;continue;}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalKeywordAmount","Lcom/google/common/collect/Table;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getKeyword","()Lforge/game/keyword/Keyword;","invokeinterface",34);}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getIdx","()J","invokeinterface",40);}
case 40:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",43);}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",47);}
case 47:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",50);}
case 50:{return rt.Call(f,"com/google/common/collect/Table","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",55);}
case 55:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=58;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",62);}
case 62:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",71);}
case 71:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9497(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalKeywordAmount","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Table","row","(Ljava/lang/Object;)Ljava/util/Map;","invokeinterface",10);}
case 10:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",15);}
case 15:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",20);}
case 20:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbility:9497:20:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",25);}
case 25:{return rt.Call(f,"java/util/stream/Stream","mapToInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/IntStream;","invokeinterface",30);}
case 30:{return rt.Call(f,"java/util/stream/IntStream","sum","()I","invokeinterface",35);}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9498(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Reference!=null?13:9;continue;}
case 9:{f.Push(JValue.L(0));f.Pc=10;continue;}
case 10:{f.Pc=23;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",19);}
case 19:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",22);}
case 22:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=23;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalKeywordAmount","Lcom/google/common/collect/Table;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getKeyword","()Lforge/game/keyword/Keyword;","invokeinterface",34);}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getIdx","()J","invokeinterface",40);}
case 40:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",43);}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",47);}
case 47:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",50);}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",54);}
case 54:{return rt.Call(f,"com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9499(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","optionalKeywordAmount","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Table","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9500(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9501(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","name","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9502(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","maxWaterbend","Ljava/lang/Integer;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9503(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/Cost","getMaxWaterbend","()Ljava/lang/String;","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Reference!=null?27:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility","maxWaterbend","Ljava/lang/Integer;"));f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference==null?26:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","maxWaterbend","Ljava/lang/Integer;",value);f.Pc=26;continue;}
case 26:{return JStep.ReturnVoid;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",32);}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/cost/Cost","getMaxWaterbend","()Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",40);}
case 40:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",43);}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility","maxWaterbend","Ljava/lang/Integer;",value);f.Pc=46;continue;}
case 46:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9504(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","compareTo","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9505(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",4);}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9506(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/SpellAbility","maxId","I"))return JStep.Continue;rt.PutStatic("forge/game/spellability/SpellAbility","maxId","I",f.Pop());f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.ClassObject("forge/game/spellability/SpellAbility")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","hashCode","()I","invokevirtual",9);}
case 9:{if(!rt.StaticReady(f,"forge/game/spellability/SpellAbility","CLASS_HASH","I"))return JStep.Continue;rt.PutStatic("forge/game/spellability/SpellAbility","CLASS_HASH","I",f.Pop());f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

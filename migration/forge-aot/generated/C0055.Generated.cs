// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C55{
internal static JClass Build(){var c=new JClass("forge/card/CardTypeView","java/lang/Object",new string[]{"java/io/Serializable"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(918,"forge/card/CardTypeView","isEmpty","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(919,"forge/card/CardTypeView","getCoreTypes","()Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(920,"forge/card/CardTypeView","getSupertypes","()Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(921,"forge/card/CardTypeView","getSubtypes","()Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(922,"forge/card/CardTypeView","getExcludedCreatureSubTypes","()Ljava/lang/Iterable;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(923,"forge/card/CardTypeView","getCreatureTypes","()Ljava/util/Set;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(924,"forge/card/CardTypeView","getLandTypes","()Ljava/util/Set;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(925,"forge/card/CardTypeView","getPlaneswalkerTypes","()Ljava/util/Set;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(926,"forge/card/CardTypeView","getBattleTypes","()Ljava/util/Set;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(927,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(928,"forge/card/CardTypeView","hasType","(Lforge/card/CardType$CoreType;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(929,"forge/card/CardTypeView","hasSupertype","(Lforge/card/CardType$Supertype;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(930,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(931,"forge/card/CardTypeView","hasCreatureType","(Ljava/lang/String;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(932,"forge/card/CardTypeView","hasAllCreatureTypes","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(933,"forge/card/CardTypeView","hasABasicLandType","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(934,"forge/card/CardTypeView","hasANonBasicLandType","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(935,"forge/card/CardTypeView","sharesCreaturetypeWith","(Lforge/card/CardTypeView;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(936,"forge/card/CardTypeView","sharesLandTypeWith","(Lforge/card/CardTypeView;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(937,"forge/card/CardTypeView","sharesPermanentTypeWith","(Lforge/card/CardTypeView;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(938,"forge/card/CardTypeView","sharesCardTypeWith","(Lforge/card/CardTypeView;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(939,"forge/card/CardTypeView","sharesAllCardTypesWith","(Lforge/card/CardTypeView;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(940,"forge/card/CardTypeView","isPermanent","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(941,"forge/card/CardTypeView","isCreature","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(942,"forge/card/CardTypeView","isPlaneswalker","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(943,"forge/card/CardTypeView","isBattle","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(944,"forge/card/CardTypeView","isLand","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(945,"forge/card/CardTypeView","isArtifact","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(946,"forge/card/CardTypeView","isInstant","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(947,"forge/card/CardTypeView","isSorcery","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(948,"forge/card/CardTypeView","isConspiracy","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(949,"forge/card/CardTypeView","isVanguard","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(950,"forge/card/CardTypeView","isScheme","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(951,"forge/card/CardTypeView","isEnchantment","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(952,"forge/card/CardTypeView","isBasic","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(953,"forge/card/CardTypeView","isLegendary","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(954,"forge/card/CardTypeView","isSnow","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(955,"forge/card/CardTypeView","isBasicLand","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(956,"forge/card/CardTypeView","isPlane","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(957,"forge/card/CardTypeView","isPhenomenon","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(958,"forge/card/CardTypeView","isKindred","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(959,"forge/card/CardTypeView","isDungeon","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(960,"forge/card/CardTypeView","isStickers","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(961,"forge/card/CardTypeView","isAttachment","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(962,"forge/card/CardTypeView","isAura","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(963,"forge/card/CardTypeView","isEquipment","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(964,"forge/card/CardTypeView","isFortification","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(965,"forge/card/CardTypeView","isAttraction","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(966,"forge/card/CardTypeView","isContraption","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(967,"forge/card/CardTypeView","isSaga","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(968,"forge/card/CardTypeView","isHistoric","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(969,"forge/card/CardTypeView","isOutlaw","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(970,"forge/card/CardTypeView","isParty","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(971,"forge/card/CardTypeView","getTypeWithChanges","(Ljava/lang/Iterable;)Lforge/card/CardTypeView;",1025,0,0,new JHandler[]{},null));
}
}}

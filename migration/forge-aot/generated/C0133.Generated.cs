// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C133{
internal static JClass Build(){var c=new JClass("forge/game/GameAction","java/lang/Object",new string[]{},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("holdCheckingStaticAbilities","Z",false,JValue.Default("Z"),null));
c.Add(new JField("effectOrder","Ljava/util/Comparator;",true,JValue.Default("Ljava/util/Comparator;"),null));
c.Add(new JMethod(2036,"forge/game/GameAction","<init>","(Lforge/game/Game;)V",1,2,2,new JHandler[]{},M2036));
c.Add(new JMethod(2037,"forge/game/GameAction","changeZone","(Lforge/game/zone/Zone;Lforge/game/zone/Zone;Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",1,6,7,new JHandler[]{},M2037));
c.Add(new JMethod(2038,"forge/game/GameAction","changeZone","(Lforge/game/zone/Zone;Lforge/game/zone/Zone;Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",2,24,8,new JHandler[]{},M2038));
c.Add(new JMethod(2039,"forge/game/GameAction","setupStaticEffect","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",2,9,7,new JHandler[]{},M2039));
c.Add(new JMethod(2040,"forge/game/GameAction","cleanStaticEffect","(Lforge/game/card/Card;Lforge/game/card/Card;)V",2,3,2,new JHandler[]{},M2040));
c.Add(new JMethod(2041,"forge/game/GameAction","storeChangesZoneAll","(Lforge/game/card/Card;Lforge/game/zone/Zone;Lforge/game/zone/Zone;Ljava/util/Map;)V",2,5,4,new JHandler[]{},M2041));
c.Add(new JMethod(2042,"forge/game/GameAction","unattachCardLeavingBattlefield","(Lforge/game/card/Card;Lforge/game/card/Card;)V",10,2,2,new JHandler[]{},M2042));
c.Add(new JMethod(2043,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",17,4,5,new JHandler[]{},M2043));
c.Add(new JMethod(2044,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,5,6,new JHandler[]{},M2044));
c.Add(new JMethod(2045,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,5,6,new JHandler[]{},M2045));
c.Add(new JMethod(2046,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,9,6,new JHandler[]{new JHandler(0,200,201,"java/lang/Exception")},M2046));
c.Add(new JMethod(2047,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",2,11,7,new JHandler[]{},M2047));
c.Add(new JMethod(2048,"forge/game/GameAction","moveToStack","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",17,4,4,new JHandler[]{},M2048));
c.Add(new JMethod(2049,"forge/game/GameAction","moveToStack","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,4,5,new JHandler[]{},M2049));
c.Add(new JMethod(2050,"forge/game/GameAction","moveToGraveyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",17,3,4,new JHandler[]{},M2050));
c.Add(new JMethod(2051,"forge/game/GameAction","moveToGraveyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,5,5,new JHandler[]{},M2051));
c.Add(new JMethod(2052,"forge/game/GameAction","moveToHand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",17,3,4,new JHandler[]{},M2052));
c.Add(new JMethod(2053,"forge/game/GameAction","moveToHand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,5,5,new JHandler[]{},M2053));
c.Add(new JMethod(2054,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,4,5,new JHandler[]{},M2054));
c.Add(new JMethod(2055,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,6,5,new JHandler[]{},M2055));
c.Add(new JMethod(2056,"forge/game/GameAction","moveToBottomOfLibrary","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",17,3,4,new JHandler[]{},M2056));
c.Add(new JMethod(2057,"forge/game/GameAction","moveToBottomOfLibrary","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,4,5,new JHandler[]{},M2057));
c.Add(new JMethod(2058,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",17,3,4,new JHandler[]{},M2058));
c.Add(new JMethod(2059,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,4,5,new JHandler[]{},M2059));
c.Add(new JMethod(2060,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;)Lforge/game/card/Card;",17,4,5,new JHandler[]{},M2060));
c.Add(new JMethod(2061,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,6,7,new JHandler[]{},M2061));
c.Add(new JMethod(2062,"forge/game/GameAction","moveToVariantDeck","(Lforge/game/card/Card;Lforge/game/zone/ZoneType;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,7,7,new JHandler[]{},M2062));
c.Add(new JMethod(2063,"forge/game/GameAction","moveToJunkyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,5,5,new JHandler[]{},M2063));
c.Add(new JMethod(2064,"forge/game/GameAction","exile","(Lforge/game/card/CardCollection;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/CardCollection;",17,7,5,new JHandler[]{},M2064));
c.Add(new JMethod(2065,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",17,8,5,new JHandler[]{},M2065));
c.Add(new JMethod(2066,"forge/game/GameAction","exileEffect","(Lforge/game/card/Card;)Lforge/game/card/Card;",17,2,4,new JHandler[]{},M2066));
c.Add(new JMethod(2067,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V",17,3,5,new JHandler[]{},M2067));
c.Add(new JMethod(2068,"forge/game/GameAction","ceaseToExist","(Lforge/game/card/Card;Z)V",1,8,4,new JHandler[]{},M2068));
c.Add(new JMethod(2069,"forge/game/GameAction","controllerChangeZoneCorrection","(Lforge/game/card/Card;)V",17,7,4,new JHandler[]{},M2069));
c.Add(new JMethod(2070,"forge/game/GameAction","setHoldCheckingStaticAbilities","(Z)V",2,2,2,new JHandler[]{},M2070));
c.Add(new JMethod(2071,"forge/game/GameAction","isCheckingStaticAbilitiesOnHold","()Z",2,1,1,new JHandler[]{},M2071));
c.Add(new JMethod(2072,"forge/game/GameAction","hasStaticAbilityAffectingZone","(Lforge/game/zone/ZoneType;Lforge/game/staticability/StaticAbilityLayer;)Z",1,7,3,new JHandler[]{},M2072));
c.Add(new JMethod(2073,"forge/game/GameAction","checkStaticAbilities","()V",17,1,2,new JHandler[]{},M2073));
c.Add(new JMethod(2074,"forge/game/GameAction","checkStaticAbilities","(Z)V",17,2,4,new JHandler[]{},M2074));
c.Add(new JMethod(2075,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;)V",17,4,5,new JHandler[]{},M2075));
c.Add(new JMethod(2076,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;Ljava/util/Set;)V",17,22,6,new JHandler[]{},M2076));
c.Add(new JMethod(2077,"forge/game/GameAction","findStaticAbilityToApply","(Lforge/game/staticability/StaticAbilityLayer;Ljava/util/List;Lforge/game/card/CardCollectionView;Ljava/util/Map;Lcom/google/common/collect/Table;)Lforge/game/staticability/StaticAbility;",2,21,5,new JHandler[]{},M2077));
c.Add(new JMethod(2078,"forge/game/GameAction","generateContinuousEffectChanges","(Lforge/game/staticability/StaticAbilityLayer;Lforge/game/staticability/StaticAbility;)Ljava/lang/Iterable;",2,4,4,new JHandler[]{},M2078));
c.Add(new JMethod(2079,"forge/game/GameAction","checkStateEffects","(Z)Z",17,2,3,new JHandler[]{},M2079));
c.Add(new JMethod(2080,"forge/game/GameAction","checkStateEffects","(ZLjava/util/Set;)Z",1,24,5,new JHandler[]{},M2080));
c.Add(new JMethod(2081,"forge/game/GameAction","stateBasedAction_Saga","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z",2,4,3,new JHandler[]{},M2081));
c.Add(new JMethod(2082,"forge/game/GameAction","stateBasedAction_Battle","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z",2,7,6,new JHandler[]{},M2082));
c.Add(new JMethod(2083,"forge/game/GameAction","stateBasedAction_Role","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z",2,8,5,new JHandler[]{},M2083));
c.Add(new JMethod(2084,"forge/game/GameAction","stateBasedAction_Dungeon","(Lforge/game/card/Card;)V",2,2,3,new JHandler[]{},M2084));
c.Add(new JMethod(2085,"forge/game/GameAction","stateBasedAction_Scheme","(Lforge/game/card/Card;)V",2,2,6,new JHandler[]{},M2085));
c.Add(new JMethod(2086,"forge/game/GameAction","stateBasedAction704_attach","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z",2,6,4,new JHandler[]{},M2086));
c.Add(new JMethod(2087,"forge/game/GameAction","stateBasedAction_Contraption","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z",2,5,2,new JHandler[]{},M2087));
c.Add(new JMethod(2088,"forge/game/GameAction","stateBasedAction704_5u","(Lforge/game/player/Player;)Z",2,9,5,new JHandler[]{},M2088));
c.Add(new JMethod(2089,"forge/game/GameAction","stateBasedAction_Commander","(Lforge/game/card/Card;Ljava/util/Map;)Z",2,3,5,new JHandler[]{},M2089));
c.Add(new JMethod(2090,"forge/game/GameAction","stateBasedAction704_5q","(Lforge/game/card/Card;)Z",2,8,4,new JHandler[]{},M2090));
c.Add(new JMethod(2091,"forge/game/GameAction","stateBasedAction704_5r","(Lforge/game/card/Card;)Z",2,5,4,new JHandler[]{},M2091));
c.Add(new JMethod(2092,"forge/game/GameAction","stateBasedAction704_5d","(Lforge/game/card/Card;)Z",2,4,2,new JHandler[]{},M2092));
c.Add(new JMethod(2093,"forge/game/GameAction","checkGameOverCondition","()V",1,8,3,new JHandler[]{},M2093));
c.Add(new JMethod(2094,"forge/game/GameAction","handlePlaneswalkerRule","(Lforge/game/player/Player;Lforge/game/card/CardCollection;)Z",2,7,2,new JHandler[]{},M2094));
c.Add(new JMethod(2095,"forge/game/GameAction","handleLegendRule","(Lforge/game/player/Player;Lforge/game/card/CardCollection;)Z",2,12,9,new JHandler[]{},M2095));
c.Add(new JMethod(2096,"forge/game/GameAction","handleWorldRule","(Lforge/game/card/CardCollection;)Z",2,10,4,new JHandler[]{},M2096));
}

private static void Add1(JClass c){
c.Add(new JMethod(2097,"forge/game/GameAction","sacrifice","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/CardCollection;",17,13,7,new JHandler[]{},M2097));
c.Add(new JMethod(2098,"forge/game/GameAction","destroy","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Z",17,9,4,new JHandler[]{},M2098));
c.Add(new JMethod(2099,"forge/game/GameAction","sacrificeDestroy","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",20,5,4,new JHandler[]{},M2099));
c.Add(new JMethod(2100,"forge/game/GameAction","revealTo","(Lforge/game/card/Card;Lforge/game/player/Player;)V",1,3,3,new JHandler[]{},M2100));
c.Add(new JMethod(2101,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;)V",1,3,4,new JHandler[]{},M2101));
c.Add(new JMethod(2102,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;Ljava/lang/String;)V",1,4,5,new JHandler[]{},M2102));
c.Add(new JMethod(2103,"forge/game/GameAction","revealTo","(Lforge/game/card/Card;Ljava/lang/Iterable;)V",1,3,4,new JHandler[]{},M2103));
c.Add(new JMethod(2104,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Ljava/lang/Iterable;)V",1,3,5,new JHandler[]{},M2104));
c.Add(new JMethod(2105,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Ljava/lang/Iterable;Ljava/lang/String;Z)V",1,9,6,new JHandler[]{},M2105));
c.Add(new JMethod(2106,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;)V",1,3,4,new JHandler[]{},M2106));
c.Add(new JMethod(2107,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;Z)V",1,4,5,new JHandler[]{},M2107));
c.Add(new JMethod(2108,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V",1,5,6,new JHandler[]{},M2108));
c.Add(new JMethod(2109,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;Z)V",1,7,7,new JHandler[]{},M2109));
c.Add(new JMethod(2110,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;ZLjava/lang/String;)V",1,6,7,new JHandler[]{},M2110));
c.Add(new JMethod(2111,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;ZLjava/lang/String;Z)V",1,9,6,new JHandler[]{},M2111));
c.Add(new JMethod(2112,"forge/game/GameAction","revealUnplayableByAI","(Ljava/lang/String;Ljava/util/Map;)V",1,5,3,new JHandler[]{},M2112));
c.Add(new JMethod(2113,"forge/game/GameAction","revealAnte","(Ljava/lang/String;Lcom/google/common/collect/Multimap;)V",1,5,3,new JHandler[]{},M2113));
c.Add(new JMethod(2114,"forge/game/GameAction","revealUnsupported","(Ljava/util/Map;)V",1,4,2,new JHandler[]{},M2114));
c.Add(new JMethod(2115,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V",1,7,4,new JHandler[]{},M2115));
c.Add(new JMethod(2116,"forge/game/GameAction","drawStartingHand","(Lforge/game/player/Player;)V",2,7,4,new JHandler[]{},M2116));
c.Add(new JMethod(2117,"forge/game/GameAction","getLandRatio","(Ljava/util/List;)F",2,5,2,new JHandler[]{},M2117));
c.Add(new JMethod(2118,"forge/game/GameAction","getHandScore","(Ljava/util/List;F)F",2,6,2,new JHandler[]{},M2118));
c.Add(new JMethod(2119,"forge/game/GameAction","startGame","(Lforge/game/GameOutcome;)V",1,2,3,new JHandler[]{},M2119));
c.Add(new JMethod(2120,"forge/game/GameAction","startGame","(Lforge/game/GameOutcome;Ljava/lang/Runnable;)V",1,8,6,new JHandler[]{},M2120));
c.Add(new JMethod(2121,"forge/game/GameAction","determineFirstTurnPlayer","(Lforge/game/GameOutcome;)Lforge/game/player/Player;",2,7,6,new JHandler[]{},M2121));
c.Add(new JMethod(2122,"forge/game/GameAction","runPreOpeningHandActions","(Lforge/game/player/Player;)V",2,12,7,new JHandler[]{},M2122));
c.Add(new JMethod(2123,"forge/game/GameAction","runOpeningHandActions","(Lforge/game/player/Player;)Lforge/game/player/Player;",2,13,3,new JHandler[]{},M2123));
c.Add(new JMethod(2124,"forge/game/GameAction","invoke","(Ljava/lang/Runnable;)V",1,2,1,new JHandler[]{},M2124));
c.Add(new JMethod(2125,"forge/game/GameAction","becomeMonarch","(Lforge/game/player/Player;Ljava/lang/String;)V",1,5,4,new JHandler[]{},M2125));
c.Add(new JMethod(2126,"forge/game/GameAction","takeInitiative","(Lforge/game/player/Player;Ljava/lang/String;)V",1,5,4,new JHandler[]{},M2126));
c.Add(new JMethod(2127,"forge/game/GameAction","scry","(Ljava/util/List;ILforge/game/spellability/SpellAbility;)V",1,14,6,new JHandler[]{},M2127));
c.Add(new JMethod(2128,"forge/game/GameAction","mill","(Lforge/game/player/PlayerCollection;ILforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/CardCollection;",1,14,7,new JHandler[]{},M2128));
c.Add(new JMethod(2129,"forge/game/GameAction","dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V",1,16,7,new JHandler[]{},M2129));
c.Add(new JMethod(2130,"forge/game/GameAction","completeDungeon","(Lforge/game/player/Player;Lforge/game/card/Card;)V",1,4,4,new JHandler[]{},M2130));
c.Add(new JMethod(2131,"forge/game/GameAction","attachAuraOnIndirectETB","(Lforge/game/card/Card;Ljava/util/Map;)Z",2,11,9,new JHandler[]{},M2131));
c.Add(new JMethod(2132,"forge/game/GameAction","getLastState","(Lforge/game/ability/AbilityKey;Lforge/game/spellability/SpellAbility;Ljava/util/Map;Z)Lforge/game/card/CardCollectionView;",1,6,2,new JHandler[]{},M2132));
c.Add(new JMethod(2133,"forge/game/GameAction","$deserializeLambda$","(Ljava/lang/invoke/SerializedLambda;)Ljava/lang/Object;",4106,3,4,new JHandler[]{},M2133));
c.Add(new JMethod(2134,"forge/game/GameAction","lambda$runPreOpeningHandActions$7","(Lforge/game/card/Card;)Z",4106,1,2,new JHandler[]{},M2134));
c.Add(new JMethod(2135,"forge/game/GameAction","lambda$runPreOpeningHandActions$6","(Lforge/game/card/Card;)Z",4106,1,2,new JHandler[]{},M2135));
c.Add(new JMethod(2136,"forge/game/GameAction","lambda$handleWorldRule$5","(Lforge/game/card/Card;)Z",4106,1,2,new JHandler[]{},M2136));
c.Add(new JMethod(2137,"forge/game/GameAction","lambda$checkStateEffects$4","(Lforge/game/card/Card;)Z",4106,1,2,new JHandler[]{},M2137));
c.Add(new JMethod(2138,"forge/game/GameAction","lambda$findStaticAbilityToApply$3","(Lforge/game/staticability/StaticAbility;)Z",4106,1,1,new JHandler[]{},M2138));
c.Add(new JMethod(2139,"forge/game/GameAction","lambda$checkStaticAbilities$2","(Lforge/game/staticability/StaticAbilityLayer;)Ljava/util/Set;",4106,1,1,new JHandler[]{},M2139));
c.Add(new JMethod(2140,"forge/game/GameAction","lambda$checkStaticAbilities$1","(Lforge/game/staticability/StaticAbilityLayer;)Ljava/util/Set;",4106,1,1,new JHandler[]{},M2140));
c.Add(new JMethod(2141,"forge/game/GameAction","lambda$checkStaticAbilities$0","(Lforge/game/card/CardCollectionView;Lforge/util/collect/FCollection;Lforge/game/card/CardCollection;Lforge/game/card/Card;)Z",4106,7,2,new JHandler[]{},M2141));
c.Add(new JMethod(2142,"forge/game/GameAction","lambda$setupStaticEffect$54847c6e$1","(Lforge/game/card/Card;Lforge/game/card/Card;)V",4098,3,3,new JHandler[]{},M2142));
c.Add(new JMethod(2143,"forge/game/GameAction","<clinit>","()V",8,0,2,new JHandler[]{},M2143));
}

internal static JStep M2036(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameAction","holdCheckingStaticAbilities","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2037(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/GameAction","changeZone","(Lforge/game/zone/Zone;Lforge/game/zone/Zone;Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2038(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isCopiedSpell","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?56:7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?56:17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?56:24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Reference==null?56:29;continue;}
case 29:{f.Push(f.Locals[5]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?56:37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?56:49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",56);}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","isCopiedSpell","()Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int!=0?80:63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int==0?91:70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?91:80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Pc=f.Pop().Reference==null?89:84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/zone/Zone","remove","(Lforge/game/card/Card;)V","invokevirtual",89);}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{return JStep.Return(f.Pop());}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{f.Pc=f.Pop().Reference!=null?148:95;continue;}
case 95:{f.Push(f.Locals[3]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int!=0?148:102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[4]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[3]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",110);}
case 110:{return rt.Call(f,"forge/game/zone/Zone","add","(Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/card/Card;)V","invokevirtual",113);}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","()V","invokevirtual",117);}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",124);}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{f.Push(JValue.I(1));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerActiveTrigger","(Lforge/game/card/Card;Z)V","invokevirtual",129);}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=133;continue;}
case 133:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardChangeZone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardChangeZone")));f.Pc=136;continue;}
case 136:{f.StackOp("dup");f.Pc=137;continue;}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/event/GameEventCardChangeZone","<init>","(Lforge/game/card/Card;Lforge/game/zone/Zone;Lforge/game/zone/Zone;)V","invokespecial",143);}
case 143:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",146);}
case 146:{f.Push(f.Locals[3]);f.Pc=147;continue;}
case 147:{return JStep.Return(f.Pop());}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",155);}
case 155:{f.Pc=f.Pop().Int!=0?168:158;continue;}
case 158:{f.Push(f.Locals[2]);f.Pc=159;continue;}
case 159:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",165);}
case 165:{f.Pc=f.Pop().Int==0?172:168;continue;}
case 168:{f.Push(JValue.I(1));f.Pc=169;continue;}
case 169:{f.Pc=173;continue;}
case 172:{f.Push(JValue.I(0));f.Pc=173;continue;}
case 173:{f.Locals[7]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[1]);f.Pc=176;continue;}
case 176:{f.Pc=f.Pop().Reference==null?193:179;continue;}
case 179:{f.Push(f.Locals[1]);f.Pc=180;continue;}
case 180:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",186);}
case 186:{f.Pc=f.Pop().Int==0?193:189;continue;}
case 189:{f.Push(JValue.I(1));f.Pc=190;continue;}
case 190:{f.Pc=194;continue;}
case 193:{f.Push(JValue.I(0));f.Pc=194;continue;}
case 194:{f.Locals[8]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{f.Pc=f.Pop().Reference==null?214:200;continue;}
case 200:{f.Push(f.Locals[1]);f.Pc=201;continue;}
case 201:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",207);}
case 207:{f.Pc=f.Pop().Int==0?214:210;continue;}
case 210:{f.Push(JValue.I(1));f.Pc=211;continue;}
case 211:{f.Pc=215;continue;}
case 214:{f.Push(JValue.I(0));f.Pc=215;continue;}
case 215:{f.Locals[9]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[3]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",221);}
case 221:{f.Locals[10]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(f.Locals[3]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/card/Card","isSpell","()Z","invokevirtual",227);}
case 227:{f.Pc=f.Pop().Int!=0?287:230;continue;}
case 230:{f.Push(f.Locals[3]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",234);}
case 234:{f.Pc=f.Pop().Int==0?287:237;continue;}
case 237:{f.Push(f.Locals[8]);f.Pc=239;continue;}
case 239:{f.Pc=f.Pop().Int!=0?287:242;continue;}
case 242:{f.Push(f.Locals[1]);f.Pc=243;continue;}
case 243:{f.Pc=f.Pop().Reference==null?287:246;continue;}
case 246:{f.Push(f.Locals[1]);f.Pc=247;continue;}
case 247:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",253);}
case 253:{f.Pc=f.Pop().Int!=0?287:256;continue;}
case 256:{f.Push(f.Locals[5]);f.Pc=258;continue;}
case 258:{f.Pc=f.Pop().Reference==null?285:261;continue;}
case 261:{f.Push(f.Locals[5]);f.Pc=263;continue;}
case 263:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellPermanent")?1:0));f.Pc=266;continue;}
case 266:{f.Pc=f.Pop().Int!=0?277:269;continue;}
case 269:{f.Push(f.Locals[5]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCastFaceDown","()Z","invokevirtual",274);}
case 274:{f.Pc=f.Pop().Int==0?285:277;continue;}
case 277:{f.Push(f.Locals[5]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCastFromPlayEffect","()Z","invokevirtual",282);}
case 282:{f.Pc=f.Pop().Int!=0?287:285;continue;}
case 285:{f.Push(f.Locals[3]);f.Pc=286;continue;}
case 286:{return JStep.Return(f.Pop());}
case 287:{f.Push(f.Locals[7]);f.Pc=289;continue;}
case 289:{f.Pc=f.Pop().Int==0?308:292;continue;}
case 292:{f.Push(f.Locals[3]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/card/Card","isInstant","()Z","invokevirtual",296);}
case 296:{f.Pc=f.Pop().Int!=0?306:299;continue;}
case 299:{f.Push(f.Locals[3]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/card/Card","isSorcery","()Z","invokevirtual",303);}
case 303:{f.Pc=f.Pop().Int==0?308:306;continue;}
case 306:{f.Push(f.Locals[3]);f.Pc=307;continue;}
case 307:{return JStep.Return(f.Pop());}
case 308:{f.Push(f.Locals[0]);f.Pc=309;continue;}
case 309:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=312;continue;}
case 312:{f.Push(f.Locals[5]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[6]);f.Pc=316;continue;}
case 316:{f.Push(JValue.I(0));f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/GameAction","getLastState","(Lforge/game/ability/AbilityKey;Lforge/game/spellability/SpellAbility;Ljava/util/Map;Z)Lforge/game/card/CardCollectionView;","invokevirtual",320);}
case 320:{f.Locals[11]=f.Pop();f.Pc=322;continue;}
case 322:{f.Push(f.Locals[0]);f.Pc=323;continue;}
case 323:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=326;continue;}
case 326:{f.Push(f.Locals[5]);f.Pc=328;continue;}
case 328:{f.Push(f.Locals[6]);f.Pc=330;continue;}
case 330:{f.Push(JValue.I(0));f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/GameAction","getLastState","(Lforge/game/ability/AbilityKey;Lforge/game/spellability/SpellAbility;Ljava/util/Map;Z)Lforge/game/card/CardCollectionView;","invokevirtual",334);}
case 334:{f.Locals[12]=f.Pop();f.Pc=336;continue;}
case 336:{f.Push(f.Locals[3]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/card/Card","getGamePieceType","()Lforge/card/GamePieceType;","invokevirtual",340);}
case 340:{if(!rt.StaticReady(f,"forge/card/GamePieceType","ATTRACTION","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","ATTRACTION","Lforge/card/GamePieceType;"));f.Pc=343;continue;}
case 343:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?356:346;continue;}
case 346:{f.Push(f.Locals[3]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/card/Card","getGamePieceType","()Lforge/card/GamePieceType;","invokevirtual",350);}
case 350:{if(!rt.StaticReady(f,"forge/card/GamePieceType","CONTRAPTION","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","CONTRAPTION","Lforge/card/GamePieceType;"));f.Pc=353;continue;}
case 353:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?391:356;continue;}
case 356:{f.Push(f.Locals[7]);f.Pc=358;continue;}
case 358:{f.Pc=f.Pop().Int!=0?391:361;continue;}
case 361:{f.Push(f.Locals[2]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",365);}
case 365:{return rt.Call(f,"forge/game/zone/ZoneType","isPartOfCommandZone","()Z","invokevirtual",368);}
case 368:{f.Pc=f.Pop().Int!=0?391:371;continue;}
case 371:{f.Push(f.Locals[2]);f.Pc=372;continue;}
case 372:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",378);}
case 378:{f.Pc=f.Pop().Int!=0?391:381;continue;}
case 381:{f.Push(f.Locals[0]);f.Pc=382;continue;}
case 382:{f.Push(f.Locals[3]);f.Pc=383;continue;}
case 383:{f.Push(f.Locals[5]);f.Pc=385;continue;}
case 385:{f.Push(f.Locals[6]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/GameAction","moveToJunkyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",390);}
case 390:{return JStep.Return(f.Pop());}
case 391:{f.Push(f.Locals[3]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/card/Card","isSplitCard","()Z","invokevirtual",395);}
case 395:{f.Pc=f.Pop().Int==0?414:398;continue;}
case 398:{f.Push(f.Locals[7]);f.Pc=400;continue;}
case 400:{f.Pc=f.Pop().Int==0?414:403;continue;}
case 403:{f.Push(f.Locals[3]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",407);}
case 407:{f.Pc=f.Pop().Reference!=null?414:410;continue;}
case 410:{f.Push(f.Locals[3]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/card/Card","updateRooms","()V","invokevirtual",414);}
case 414:{f.Push(f.Locals[3]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",418);}
case 418:{f.Pc=f.Pop().Int!=0?433:421;continue;}
case 421:{f.Push(f.Locals[1]);f.Pc=422;continue;}
case 422:{f.Push(f.Locals[2]);f.Pc=423;continue;}
case 423:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",426);}
case 426:{f.Pc=f.Pop().Int==0?433:429;continue;}
case 429:{f.Push(JValue.I(1));f.Pc=430;continue;}
case 430:{f.Pc=434;continue;}
case 433:{f.Push(JValue.I(0));f.Pc=434;continue;}
case 434:{f.Locals[13]=f.Pop();f.Pc=436;continue;}
case 436:{f.Push(JValue.R(null));f.Pc=437;continue;}
case 437:{f.Locals[14]=f.Pop();f.Pc=439;continue;}
case 439:{f.Push(JValue.R(null));f.Pc=440;continue;}
case 440:{f.Locals[15]=f.Pop();f.Pc=442;continue;}
case 442:{f.Push(f.Locals[6]);f.Pc=444;continue;}
case 444:{f.Pc=f.Pop().Reference==null?478:447;continue;}
case 447:{f.Push(f.Locals[6]);f.Pc=449;continue;}
case 449:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=452;continue;}
case 452:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",457);}
case 457:{f.Pc=f.Pop().Int==0?478:460;continue;}
case 460:{f.Push(f.Locals[6]);f.Pc=462;continue;}
case 462:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=465;continue;}
case 465:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",470);}
case 470:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=473;continue;}
case 473:{f.Locals[15]=f.Pop();f.Pc=475;continue;}
case 475:{f.Pc=545;continue;}
case 478:{f.Push(f.Locals[7]);f.Pc=480;continue;}
case 480:{f.Pc=f.Pop().Int==0?545:483;continue;}
case 483:{f.Push(f.Locals[5]);f.Pc=485;continue;}
case 485:{f.Pc=f.Pop().Reference==null?545:488;continue;}
case 488:{f.Push(f.Locals[5]);f.Pc=490;continue;}
case 490:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",493);}
case 493:{f.Pc=f.Pop().Int==0?545:496;continue;}
case 496:{f.Push(f.Locals[5]);f.Pc=498;continue;}
case 498:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacementEffect","()Lforge/game/replacement/ReplacementEffect;","invokevirtual",501);}
case 501:{f.Locals[16]=f.Pop();f.Pc=503;continue;}
case 503:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"));f.Pc=506;continue;}
case 506:{f.Push(f.Locals[16]);f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMode","()Lforge/game/replacement/ReplacementType;","invokevirtual",511);}
case 511:{return rt.Call(f,"forge/game/replacement/ReplacementType","equals","(Ljava/lang/Object;)Z","invokevirtual",514);}
case 514:{f.Pc=f.Pop().Int==0?545:517;continue;}
case 517:{f.Push(f.Locals[5]);f.Pc=519;continue;}
case 519:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=522;continue;}
case 522:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",525);}
case 525:{f.Push(f.Locals[3]);f.Pc=526;continue;}
case 526:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",529);}
case 529:{f.Pc=f.Pop().Int==0?545:532;continue;}
case 532:{f.Push(f.Locals[5]);f.Pc=534;continue;}
case 534:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=537;continue;}
case 537:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",540);}
case 540:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=543;continue;}
case 543:{f.Locals[15]=f.Pop();f.Pc=545;continue;}
case 545:{f.Push(f.Locals[7]);f.Pc=547;continue;}
case 547:{f.Pc=f.Pop().Int!=0?565:550;continue;}
case 550:{f.Push(f.Locals[13]);f.Pc=552;continue;}
case 552:{f.Pc=f.Pop().Int==0?596:555;continue;}
case 555:{f.Push(f.Locals[2]);f.Pc=556;continue;}
case 556:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",559);}
case 559:{return rt.Call(f,"forge/game/zone/ZoneType","isHidden","()Z","invokevirtual",562);}
case 562:{f.Pc=f.Pop().Int==0?596:565;continue;}
case 565:{f.Push(f.Locals[3]);f.Pc=566;continue;}
case 566:{f.Locals[14]=f.Pop();f.Pc=568;continue;}
case 568:{f.Push(f.Locals[15]);f.Pc=570;continue;}
case 570:{f.Pc=f.Pop().Reference!=null?579:573;continue;}
case 573:{f.Push(f.Locals[3]);f.Pc=574;continue;}
case 574:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",577);}
case 577:{f.Locals[15]=f.Pop();f.Pc=579;continue;}
case 579:{f.Push(f.Locals[15]);f.Pc=581;continue;}
case 581:{f.Push(f.Locals[2]);f.Pc=582;continue;}
case 582:{return rt.Call(f,"forge/game/staticability/StaticAbilityCountersRemain","countersRemain","(Lforge/game/card/Card;Lforge/game/zone/Zone;)Z","invokestatic",585);}
case 585:{f.Pc=f.Pop().Int!=0?1027:588;continue;}
case 588:{f.Push(f.Locals[14]);f.Pc=590;continue;}
case 590:{return rt.Call(f,"forge/game/card/Card","clearCounters","()V","invokevirtual",593);}
case 593:{f.Pc=1027;continue;}
case 596:{f.Push(f.Locals[8]);f.Pc=598;continue;}
case 598:{f.Pc=f.Pop().Int==0?631:601;continue;}
case 601:{f.Push(f.Locals[11]);f.Pc=603;continue;}
case 603:{f.Push(f.Locals[3]);f.Pc=604;continue;}
case 604:{return rt.Call(f,"forge/game/card/CardCollectionView","indexOf","(Ljava/lang/Object;)I","invokeinterface",609);}
case 609:{f.Locals[16]=f.Pop();f.Pc=611;continue;}
case 611:{f.Push(f.Locals[16]);f.Pc=613;continue;}
case 613:{f.Push(JValue.I(-1));f.Pc=614;continue;}
case 614:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?631:617;continue;}
case 617:{f.Push(f.Locals[11]);f.Pc=619;continue;}
case 619:{f.Push(f.Locals[16]);f.Pc=621;continue;}
case 621:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",626);}
case 626:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=629;continue;}
case 629:{f.Locals[15]=f.Pop();f.Pc=631;continue;}
case 631:{f.Push(f.Locals[9]);f.Pc=633;continue;}
case 633:{f.Pc=f.Pop().Int==0?666:636;continue;}
case 636:{f.Push(f.Locals[12]);f.Pc=638;continue;}
case 638:{f.Push(f.Locals[3]);f.Pc=639;continue;}
case 639:{return rt.Call(f,"forge/game/card/CardCollectionView","indexOf","(Ljava/lang/Object;)I","invokeinterface",644);}
case 644:{f.Locals[16]=f.Pop();f.Pc=646;continue;}
case 646:{f.Push(f.Locals[16]);f.Pc=648;continue;}
case 648:{f.Push(JValue.I(-1));f.Pc=649;continue;}
case 649:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?666:652;continue;}
case 652:{f.Push(f.Locals[12]);f.Pc=654;continue;}
case 654:{f.Push(f.Locals[16]);f.Pc=656;continue;}
case 656:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",661);}
case 661:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=664;continue;}
case 664:{f.Locals[15]=f.Pop();f.Pc=666;continue;}
case 666:{f.Push(f.Locals[15]);f.Pc=668;continue;}
case 668:{f.Pc=f.Pop().Reference!=null?677:671;continue;}
case 671:{f.Push(f.Locals[3]);f.Pc=672;continue;}
case 672:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",675);}
case 675:{f.Locals[15]=f.Pop();f.Pc=677;continue;}
case 677:{f.Push(f.Locals[8]);f.Pc=679;continue;}
case 679:{f.Pc=f.Pop().Int==0?711:682;continue;}
case 682:{f.Push(f.Locals[2]);f.Pc=683;continue;}
case 683:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",689);}
case 689:{f.Pc=f.Pop().Int!=0?711:692;continue;}
case 692:{f.Push(f.Locals[2]);f.Pc=693;continue;}
case 693:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Flashback","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Flashback","Lforge/game/zone/ZoneType;"));f.Pc=696;continue;}
case 696:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",699);}
case 699:{f.Pc=f.Pop().Int!=0?711:702;continue;}
case 702:{f.Push(f.Locals[0]);f.Pc=703;continue;}
case 703:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=706;continue;}
case 706:{f.Push(f.Locals[15]);f.Pc=708;continue;}
case 708:{return rt.Call(f,"forge/game/Game","addChangeZoneLKIInfo","(Lforge/game/card/Card;)V","invokevirtual",711);}
case 711:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCopyService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCopyService")));f.Pc=714;continue;}
case 714:{f.StackOp("dup");f.Pc=715;continue;}
case 715:{f.Push(f.Locals[3]);f.Pc=716;continue;}
case 716:{return rt.Call(f,"forge/game/card/CardCopyService","<init>","(Lforge/game/card/Card;)V","invokespecial",719);}
case 719:{f.Push(JValue.I(0));f.Pc=720;continue;}
case 720:{return rt.Call(f,"forge/game/card/CardCopyService","copyCard","(Z)Lforge/game/card/Card;","invokevirtual",723);}
case 723:{f.Locals[14]=f.Pop();f.Pc=725;continue;}
case 725:{f.Push(f.Locals[14]);f.Pc=727;continue;}
case 727:{f.Push(f.Locals[3]);f.Pc=728;continue;}
case 728:{return rt.Call(f,"forge/game/card/Card","getGameTimestamp","()J","invokevirtual",731);}
case 731:{return rt.Call(f,"forge/game/card/Card","setGameTimestamp","(J)V","invokevirtual",734);}
case 734:{f.Push(f.Locals[2]);f.Pc=735;continue;}
case 735:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=738;continue;}
case 738:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",741);}
case 741:{f.Pc=f.Pop().Int==0?907:744;continue;}
case 744:{f.Push(f.Locals[14]);f.Pc=746;continue;}
case 746:{f.Push(f.Locals[3]);f.Pc=747;continue;}
case 747:{return rt.Call(f,"forge/game/card/Card","getExiledWith","()Lforge/game/card/Card;","invokevirtual",750);}
case 750:{return rt.Call(f,"forge/game/card/Card","setExiledWith","(Lforge/game/card/Card;)V","invokevirtual",753);}
case 753:{f.Push(f.Locals[14]);f.Pc=755;continue;}
case 755:{f.Push(f.Locals[3]);f.Pc=756;continue;}
case 756:{return rt.Call(f,"forge/game/card/Card","getExiledBy","()Lforge/game/player/Player;","invokevirtual",759);}
case 759:{return rt.Call(f,"forge/game/card/Card","setExiledBy","(Lforge/game/player/Player;)V","invokevirtual",762);}
case 762:{f.Push(f.Locals[14]);f.Pc=764;continue;}
case 764:{f.Push(f.Locals[3]);f.Pc=765;continue;}
case 765:{return rt.Call(f,"forge/game/card/Card","getDrawnThisTurn","()Z","invokevirtual",768);}
case 768:{return rt.Call(f,"forge/game/card/Card","setDrawnThisTurn","(Z)V","invokevirtual",771);}
case 771:{f.Push(f.Locals[3]);f.Pc=772;continue;}
case 772:{return rt.Call(f,"forge/game/card/Card","isRealToken","()Z","invokevirtual",775);}
case 775:{f.Pc=f.Pop().Int==0?787:778;continue;}
case 778:{f.Push(f.Locals[14]);f.Pc=780;continue;}
case 780:{f.Push(f.Locals[3]);f.Pc=781;continue;}
case 781:{return rt.Call(f,"forge/game/card/Card","getCopiedPermanent","()Lforge/game/card/Card;","invokevirtual",784);}
case 784:{return rt.Call(f,"forge/game/card/Card","setCopiedPermanent","(Lforge/game/card/Card;)V","invokevirtual",787);}
case 787:{f.Push(f.Locals[5]);f.Pc=789;continue;}
case 789:{f.Pc=f.Pop().Reference==null?934:792;continue;}
case 792:{f.Push(f.Locals[5]);f.Pc=794;continue;}
case 794:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",797);}
case 797:{f.Pc=f.Pop().Int==0?934:800;continue;}
case 800:{f.Push(f.Locals[3]);f.Pc=801;continue;}
case 801:{f.Push(f.Locals[5]);f.Pc=803;continue;}
case 803:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",806);}
case 806:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",809);}
case 809:{f.Pc=f.Pop().Int==0?934:812;continue;}
case 812:{f.Push(f.Locals[14]);f.Pc=814;continue;}
case 814:{f.Push(f.Locals[1]);f.Pc=815;continue;}
case 815:{return rt.Call(f,"forge/game/card/Card","setCastFrom","(Lforge/game/zone/Zone;)V","invokevirtual",818);}
case 818:{f.Push(f.Locals[14]);f.Pc=820;continue;}
case 820:{f.Push(f.Locals[5]);f.Pc=822;continue;}
case 822:{return rt.Call(f,"forge/game/card/Card","setCastSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",825);}
case 825:{f.Push(f.Locals[14]);f.Pc=827;continue;}
case 827:{f.Push(f.Locals[5]);f.Pc=829;continue;}
case 829:{return rt.Call(f,"forge/game/card/Card","setSplitStateToPlayAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",832);}
case 832:{f.Push(f.Locals[14]);f.Pc=834;continue;}
case 834:{f.Push(f.Locals[5]);f.Pc=836;continue;}
case 836:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",839);}
case 839:{f.Push(JValue.L(0));f.Pc=840;continue;}
case 840:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",843);}
case 843:{f.Push(f.Locals[5]);f.Pc=845;continue;}
case 845:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",848);}
case 848:{f.Locals[16]=f.Pop();f.Pc=850;continue;}
case 850:{f.Push(f.Locals[16]);f.Pc=852;continue;}
case 852:{f.Pc=f.Pop().Reference==null?904:855;continue;}
case 855:{f.Push(f.Locals[14]);f.Pc=857;continue;}
case 857:{f.Push(f.Locals[16]);f.Pc=859;continue;}
case 859:{return rt.Call(f,"forge/game/card/Card","addKeywordForStaticAbility","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",862);}
case 862:{f.Push(f.Locals[5]);f.Pc=864;continue;}
case 864:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",867);}
case 867:{f.Pc=f.Pop().Int!=0?904:870;continue;}
case 870:{f.Push(f.Locals[16]);f.Pc=872;continue;}
case 872:{f.Push(f.Locals[14]);f.Pc=874;continue;}
case 874:{return rt.Call(f,"forge/game/keyword/KeywordInterface","setHostCard","(Lforge/game/card/Card;)V","invokeinterface",879);}
case 879:{f.Push(f.Locals[14]);f.Pc=881;continue;}
case 881:{f.Push(f.Locals[16]);f.Pc=883;continue;}
case 883:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",886);}
case 886:{f.Push(JValue.R(null));f.Pc=887;continue;}
case 887:{f.Push(JValue.I(0));f.Pc=888;continue;}
case 888:{f.Push(f.Locals[14]);f.Pc=890;continue;}
case 890:{return rt.Call(f,"forge/game/card/Card","getGameTimestamp","()J","invokevirtual",893);}
case 893:{f.Push(f.Locals[16]);f.Pc=895;continue;}
case 895:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",900);}
case 900:{f.Push(JValue.I(0));f.Pc=901;continue;}
case 901:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywordsInternal","(Ljava/util/Collection;Ljava/util/Collection;ZJLforge/game/staticability/StaticAbility;Z)V","invokevirtual",904);}
case 904:{f.Pc=934;continue;}
case 907:{f.Push(f.Locals[14]);f.Pc=909;continue;}
case 909:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",912);}
case 912:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=915;continue;}
case 915:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?934:918;continue;}
case 918:{f.Push(f.Locals[14]);f.Pc=920;continue;}
case 920:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=923;continue;}
case 923:{f.Push(JValue.I(0));f.Pc=924;continue;}
case 924:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",927);}
case 927:{f.StackOp("pop");f.Pc=928;continue;}
case 928:{f.Push(f.Locals[14]);f.Pc=930;continue;}
case 930:{f.Push(JValue.I(0));f.Pc=931;continue;}
case 931:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",934);}
case 934:{f.Push(f.Locals[15]);f.Pc=936;continue;}
case 936:{f.Push(f.Locals[2]);f.Pc=937;continue;}
case 937:{return rt.Call(f,"forge/game/staticability/StaticAbilityCountersRemain","countersRemain","(Lforge/game/card/Card;Lforge/game/zone/Zone;)Z","invokestatic",940);}
case 940:{f.Pc=f.Pop().Int==0?956:943;continue;}
case 943:{f.Push(f.Locals[14]);f.Pc=945;continue;}
case 945:{f.Push(f.Locals[15]);f.Pc=947;continue;}
case 947:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",950);}
case 950:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","(Ljava/lang/Iterable;)Lcom/google/common/collect/HashMultiset;","invokestatic",953);}
case 953:{return rt.Call(f,"forge/game/card/Card","setCounters","(Lcom/google/common/collect/Multiset;)V","invokevirtual",956);}
case 956:{f.Push(f.Locals[3]);f.Pc=957;continue;}
case 957:{return rt.Call(f,"forge/game/card/Card","hasIntensity","()Z","invokevirtual",960);}
case 960:{f.Pc=f.Pop().Int==0?973:963;continue;}
case 963:{f.Push(f.Locals[14]);f.Pc=965;continue;}
case 965:{f.Push(f.Locals[3]);f.Pc=966;continue;}
case 966:{f.Push(JValue.I(0));f.Pc=967;continue;}
case 967:{return rt.Call(f,"forge/game/card/Card","getIntensity","(Z)I","invokevirtual",970);}
case 970:{return rt.Call(f,"forge/game/card/Card","setIntensity","(I)V","invokevirtual",973);}
case 973:{f.Push(f.Locals[3]);f.Pc=974;continue;}
case 974:{return rt.Call(f,"forge/game/card/Card","isSpecialized","()Z","invokevirtual",977);}
case 977:{f.Pc=f.Pop().Int==0?991:980;continue;}
case 980:{f.Push(f.Locals[14]);f.Pc=982;continue;}
case 982:{f.Push(f.Locals[3]);f.Pc=983;continue;}
case 983:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",986);}
case 986:{f.Push(JValue.I(0));f.Pc=987;continue;}
case 987:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",990);}
case 990:{f.StackOp("pop");f.Pc=991;continue;}
case 991:{f.Push(f.Locals[3]);f.Pc=992;continue;}
case 992:{return rt.Call(f,"forge/game/card/Card","hasPerpetual","()Z","invokevirtual",995);}
case 995:{f.Pc=f.Pop().Int==0?1004:998;continue;}
case 998:{f.Push(f.Locals[14]);f.Pc=1000;continue;}
case 1000:{f.Push(f.Locals[3]);f.Pc=1001;continue;}
case 1001:{return rt.Call(f,"forge/game/card/Card","setPerpetual","(Lforge/game/card/Card;)V","invokevirtual",1004);}
case 1004:{f.Push(f.Locals[3]);f.Pc=1005;continue;}
case 1005:{return rt.Call(f,"forge/game/card/Card","isStickered","()Z","invokevirtual",1008);}
case 1008:{f.Pc=f.Pop().Int==0?1027:1011;continue;}
case 1011:{f.Push(f.Locals[2]);f.Pc=1012;continue;}
case 1012:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1015);}
case 1015:{return rt.Call(f,"forge/game/zone/ZoneType","isHidden","()Z","invokevirtual",1018);}
case 1018:{f.Pc=f.Pop().Int!=0?1027:1021;continue;}
case 1021:{f.Push(f.Locals[14]);f.Pc=1023;continue;}
case 1023:{f.Push(f.Locals[3]);f.Pc=1024;continue;}
case 1024:{return rt.Call(f,"forge/game/card/Card","setStickers","(Lforge/game/card/Card;)V","invokevirtual",1027);}
case 1027:{f.Push(f.Locals[14]);f.Pc=1029;continue;}
case 1029:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",1032);}
case 1032:{f.Push(f.Locals[0]);f.Pc=1033;continue;}
case 1033:{f.Push(f.Locals[14]);f.Pc=1035;continue;}
case 1035:{f.Push(f.Locals[5]);f.Pc=1037;continue;}
case 1037:{return rt.Call(f,"forge/game/GameAction","setupStaticEffect","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",1040);}
case 1040:{f.Locals[16]=f.Pop();f.Pc=1042;continue;}
case 1042:{f.Push(f.Locals[14]);f.Pc=1044;continue;}
case 1044:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",1047);}
case 1047:{f.Pc=f.Pop().Int==0?1174:1050;continue;}
case 1050:{f.Push(f.Locals[14]);f.Pc=1052;continue;}
case 1052:{return rt.Call(f,"forge/game/card/Card","isAttachedToEntity","()Z","invokevirtual",1055);}
case 1055:{f.Pc=f.Pop().Int!=0?1174:1058;continue;}
case 1058:{f.Push(f.Locals[7]);f.Pc=1060;continue;}
case 1060:{f.Pc=f.Pop().Int==0?1174:1063;continue;}
case 1063:{f.Push(f.Locals[1]);f.Pc=1064;continue;}
case 1064:{f.Pc=f.Pop().Reference==null?1077:1067;continue;}
case 1067:{f.Push(f.Locals[1]);f.Pc=1068;continue;}
case 1068:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=1071;continue;}
case 1071:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",1074);}
case 1074:{f.Pc=f.Pop().Int!=0?1174:1077;continue;}
case 1077:{f.Push(JValue.I(0));f.Pc=1078;continue;}
case 1078:{f.Locals[17]=f.Pop();f.Pc=1080;continue;}
case 1080:{f.Push(f.Locals[0]);f.Pc=1081;continue;}
case 1081:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1084;continue;}
case 1084:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",1087);}
case 1087:{return rt.Call(f,"forge/game/player/PlayerCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",1090);}
case 1090:{f.Push(f.Locals[14]);f.Pc=1092;continue;}
case 1092:{f.Push(JValue.R(null));f.Pc=1093;continue;}
case 1093:{return rt.Call(f,"forge/game/player/PlayerPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;","invokestatic",1096);}
case 1096:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",1101);}
case 1101:{f.Pc=f.Pop().Int==0?1107:1104;continue;}
case 1104:{f.Push(JValue.I(1));f.Pc=1105;continue;}
case 1105:{f.Locals[17]=f.Pop();f.Pc=1107;continue;}
case 1107:{f.Push(f.Locals[17]);f.Pc=1109;continue;}
case 1109:{f.Pc=f.Pop().Int!=0?1131:1112;continue;}
case 1112:{f.Push(f.Locals[11]);f.Pc=1114;continue;}
case 1114:{f.Push(f.Locals[14]);f.Pc=1116;continue;}
case 1116:{f.Push(JValue.R(null));f.Pc=1117;continue;}
case 1117:{return rt.Call(f,"forge/game/card/CardPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;","invokestatic",1120);}
case 1120:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",1125);}
case 1125:{f.Pc=f.Pop().Int==0?1131:1128;continue;}
case 1128:{f.Push(JValue.I(1));f.Pc=1129;continue;}
case 1129:{f.Locals[17]=f.Pop();f.Pc=1131;continue;}
case 1131:{f.Push(f.Locals[17]);f.Pc=1133;continue;}
case 1133:{f.Pc=f.Pop().Int!=0?1155:1136;continue;}
case 1136:{f.Push(f.Locals[12]);f.Pc=1138;continue;}
case 1138:{f.Push(f.Locals[14]);f.Pc=1140;continue;}
case 1140:{f.Push(JValue.R(null));f.Pc=1141;continue;}
case 1141:{return rt.Call(f,"forge/game/card/CardPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;","invokestatic",1144);}
case 1144:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",1149);}
case 1149:{f.Pc=f.Pop().Int==0?1155:1152;continue;}
case 1152:{f.Push(JValue.I(1));f.Pc=1153;continue;}
case 1153:{f.Locals[17]=f.Pop();f.Pc=1155;continue;}
case 1155:{f.Push(f.Locals[17]);f.Pc=1157;continue;}
case 1157:{f.Pc=f.Pop().Int!=0?1174:1160;continue;}
case 1160:{f.Push(f.Locals[3]);f.Pc=1161;continue;}
case 1161:{return rt.Call(f,"forge/game/card/Card","clearControllers","()V","invokevirtual",1164);}
case 1164:{f.Push(f.Locals[0]);f.Pc=1165;continue;}
case 1165:{f.Push(f.Locals[16]);f.Pc=1167;continue;}
case 1167:{f.Push(f.Locals[14]);f.Pc=1169;continue;}
case 1169:{return rt.Call(f,"forge/game/GameAction","cleanStaticEffect","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",1172);}
case 1172:{f.Push(f.Locals[3]);f.Pc=1173;continue;}
case 1173:{return JStep.Return(f.Pop());}
case 1174:{f.Push(f.Locals[6]);f.Pc=1176;continue;}
case 1176:{f.Pc=f.Pop().Reference==null?1210:1179;continue;}
case 1179:{f.Push(f.Locals[6]);f.Pc=1181;continue;}
case 1181:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=1184;continue;}
case 1184:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1189);}
case 1189:{f.Pc=f.Pop().Int==0?1210:1192;continue;}
case 1192:{f.Push(f.Locals[6]);f.Pc=1194;continue;}
case 1194:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=1197;continue;}
case 1197:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1202);}
case 1202:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntityCounterTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1205;continue;}
case 1205:{f.Locals[17]=f.Pop();f.Pc=1207;continue;}
case 1207:{f.Pc=1219;continue;}
case 1210:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=1213;continue;}
case 1213:{f.StackOp("dup");f.Pc=1214;continue;}
case 1214:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",1217);}
case 1217:{f.Locals[17]=f.Pop();f.Pc=1219;continue;}
case 1219:{f.Push(f.Locals[13]);f.Pc=1221;continue;}
case 1221:{f.Pc=f.Pop().Int!=0?1612:1224;continue;}
case 1224:{f.Push(f.Locals[8]);f.Pc=1226;continue;}
case 1226:{f.Pc=f.Pop().Int==0?1256:1229;continue;}
case 1229:{f.Push(f.Locals[7]);f.Pc=1231;continue;}
case 1231:{f.Pc=f.Pop().Int!=0?1256:1234;continue;}
case 1234:{f.Push(f.Locals[3]);f.Pc=1235;continue;}
case 1235:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",1238);}
case 1238:{f.Pc=f.Pop().Int==0?1256:1241;continue;}
case 1241:{f.Push(f.Locals[3]);f.Pc=1242;continue;}
case 1242:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",1245);}
case 1245:{f.Pc=f.Pop().Int==0?1256:1248;continue;}
case 1248:{f.Push(f.Locals[3]);f.Pc=1249;continue;}
case 1249:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1252);}
case 1252:{f.Push(JValue.I(1));f.Pc=1253;continue;}
case 1253:{return rt.Call(f,"forge/game/player/Player","setCommanderReplacementSuppressed","(Z)V","invokevirtual",1256);}
case 1256:{f.Push(f.Locals[14]);f.Pc=1258;continue;}
case 1258:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",1261);}
case 1261:{f.Locals[18]=f.Pop();f.Pc=1263;continue;}
case 1263:{f.Push(f.Locals[18]);f.Pc=1265;continue;}
case 1265:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=1268;continue;}
case 1268:{f.Push(f.Locals[15]);f.Pc=1270;continue;}
case 1270:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1275);}
case 1275:{f.StackOp("pop");f.Pc=1276;continue;}
case 1276:{f.Push(f.Locals[18]);f.Pc=1278;continue;}
case 1278:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=1281;continue;}
case 1281:{f.Push(f.Locals[5]);f.Pc=1283;continue;}
case 1283:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1288);}
case 1288:{f.StackOp("pop");f.Pc=1289;continue;}
case 1289:{f.Push(f.Locals[18]);f.Pc=1291;continue;}
case 1291:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"));f.Pc=1294;continue;}
case 1294:{f.Push(f.Locals[1]);f.Pc=1295;continue;}
case 1295:{f.Pc=f.Pop().Reference==null?1305:1298;continue;}
case 1298:{f.Push(f.Locals[1]);f.Pc=1299;continue;}
case 1299:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1302);}
case 1302:{f.Pc=1306;continue;}
case 1305:{f.Push(JValue.R(null));f.Pc=1306;continue;}
case 1306:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1311);}
case 1311:{f.StackOp("pop");f.Pc=1312;continue;}
case 1312:{f.Push(f.Locals[18]);f.Pc=1314;continue;}
case 1314:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=1317;continue;}
case 1317:{f.Push(f.Locals[2]);f.Pc=1318;continue;}
case 1318:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1321);}
case 1321:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1326);}
case 1326:{f.StackOp("pop");f.Pc=1327;continue;}
case 1327:{f.Push(f.Locals[7]);f.Pc=1329;continue;}
case 1329:{f.Pc=f.Pop().Int==0?1378:1332;continue;}
case 1332:{f.Push(f.Locals[18]);f.Pc=1334;continue;}
case 1334:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","EffectOnly","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","EffectOnly","Lforge/game/ability/AbilityKey;"));f.Pc=1337;continue;}
case 1337:{f.Push(JValue.I(1));f.Pc=1338;continue;}
case 1338:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",1341);}
case 1341:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1346);}
case 1346:{f.StackOp("pop");f.Pc=1347;continue;}
case 1347:{f.Push(f.Locals[18]);f.Pc=1349;continue;}
case 1349:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=1352;continue;}
case 1352:{f.Push(f.Locals[17]);f.Pc=1354;continue;}
case 1354:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1359);}
case 1359:{f.StackOp("pop");f.Pc=1360;continue;}
case 1360:{f.Push(f.Locals[18]);f.Pc=1362;continue;}
case 1362:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"));f.Pc=1365;continue;}
case 1365:{f.Push(f.Locals[17]);f.Pc=1367;continue;}
case 1367:{f.Push(f.Locals[14]);f.Pc=1369;continue;}
case 1369:{return rt.Call(f,"forge/game/GameEntityCounterTable","column","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",1372);}
case 1372:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1377);}
case 1377:{f.StackOp("pop");f.Pc=1378;continue;}
case 1378:{f.Push(f.Locals[6]);f.Pc=1380;continue;}
case 1380:{f.Pc=f.Pop().Reference==null?1392:1383;continue;}
case 1383:{f.Push(f.Locals[18]);f.Pc=1385;continue;}
case 1385:{f.Push(f.Locals[6]);f.Pc=1387;continue;}
case 1387:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",1392);}
case 1392:{f.Push(f.Locals[1]);f.Pc=1393;continue;}
case 1393:{f.Pc=f.Pop().Reference==null?1406:1396;continue;}
case 1396:{f.Push(f.Locals[1]);f.Pc=1397;continue;}
case 1397:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=1400;continue;}
case 1400:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",1403);}
case 1403:{f.Pc=f.Pop().Int==0?1416:1406;continue;}
case 1406:{f.Push(f.Locals[14]);f.Pc=1408;continue;}
case 1408:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1411);}
case 1411:{f.Push(f.Locals[14]);f.Pc=1413;continue;}
case 1413:{return rt.Call(f,"forge/game/player/Player","addInboundToken","(Lforge/game/card/Card;)V","invokevirtual",1416);}
case 1416:{f.Push(f.Locals[0]);f.Pc=1417;continue;}
case 1417:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1420;continue;}
case 1420:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",1423);}
case 1423:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"));f.Pc=1426;continue;}
case 1426:{f.Push(f.Locals[18]);f.Pc=1428;continue;}
case 1428:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",1431);}
case 1431:{f.Locals[19]=f.Pop();f.Pc=1433;continue;}
case 1433:{f.Push(f.Locals[14]);f.Pc=1435;continue;}
case 1435:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1438);}
case 1438:{f.Push(f.Locals[14]);f.Pc=1440;continue;}
case 1440:{return rt.Call(f,"forge/game/player/Player","removeInboundToken","(Lforge/game/card/Card;)V","invokevirtual",1443);}
case 1443:{f.Push(f.Locals[19]);f.Pc=1445;continue;}
case 1445:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=1448;continue;}
case 1448:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1612:1451;continue;}
case 1451:{f.Push(f.Locals[19]);f.Pc=1453;continue;}
case 1453:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=1456;continue;}
case 1456:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1612:1459;continue;}
case 1459:{f.Push(f.Locals[3]);f.Pc=1460;continue;}
case 1460:{return rt.Call(f,"forge/game/card/Card","isManifested","()Z","invokevirtual",1463);}
case 1463:{f.Pc=f.Pop().Int!=0?1473:1466;continue;}
case 1466:{f.Push(f.Locals[3]);f.Pc=1467;continue;}
case 1467:{return rt.Call(f,"forge/game/card/Card","isCloaked","()Z","invokevirtual",1470);}
case 1470:{f.Pc=f.Pop().Int==0?1484:1473;continue;}
case 1473:{f.Push(f.Locals[3]);f.Pc=1474;continue;}
case 1474:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",1477);}
case 1477:{f.Pc=f.Pop().Int!=0?1484:1480;continue;}
case 1480:{f.Push(f.Locals[3]);f.Pc=1481;continue;}
case 1481:{return rt.Call(f,"forge/game/card/Card","forceTurnFaceUp","()V","invokevirtual",1484);}
case 1484:{f.Push(f.Locals[19]);f.Pc=1486;continue;}
case 1486:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Prevented","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Prevented","Lforge/game/replacement/ReplacementResult;"));f.Pc=1489;continue;}
case 1489:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1579:1492;continue;}
case 1492:{f.Push(f.Locals[3]);f.Pc=1493;continue;}
case 1493:{return rt.Call(f,"forge/game/card/Card","clearControllers","()V","invokevirtual",1496);}
case 1496:{f.Push(f.Locals[0]);f.Pc=1497;continue;}
case 1497:{f.Push(f.Locals[16]);f.Pc=1499;continue;}
case 1499:{f.Push(f.Locals[14]);f.Pc=1501;continue;}
case 1501:{return rt.Call(f,"forge/game/GameAction","cleanStaticEffect","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",1504);}
case 1504:{f.Push(f.Locals[5]);f.Pc=1506;continue;}
case 1506:{f.Pc=f.Pop().Reference==null?1549:1509;continue;}
case 1509:{f.Push(f.Locals[5]);f.Pc=1511;continue;}
case 1511:{f.Push(JValue.R(rt.String("Transformed")));f.Pc=1514;continue;}
case 1514:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1517);}
case 1517:{f.Pc=f.Pop().Int!=0?1531:1520;continue;}
case 1520:{f.Push(f.Locals[5]);f.Pc=1522;continue;}
case 1522:{f.Push(JValue.R(rt.String("FaceDown")));f.Pc=1525;continue;}
case 1525:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1528);}
case 1528:{f.Pc=f.Pop().Int==0?1544:1531;continue;}
case 1531:{f.Push(f.Locals[3]);f.Pc=1532;continue;}
case 1532:{f.Push(JValue.I(0));f.Pc=1533;continue;}
case 1533:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",1536);}
case 1536:{f.Push(f.Locals[3]);f.Pc=1537;continue;}
case 1537:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=1540;continue;}
case 1540:{return rt.Call(f,"forge/game/card/Card","changeToState","(Lforge/card/CardStateName;)Z","invokevirtual",1543);}
case 1543:{f.StackOp("pop");f.Pc=1544;continue;}
case 1544:{f.Push(f.Locals[3]);f.Pc=1545;continue;}
case 1545:{f.Push(f.Locals[3]);f.Pc=1546;continue;}
case 1546:{return rt.Call(f,"forge/game/GameAction","unattachCardLeavingBattlefield","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokestatic",1549);}
case 1549:{f.Push(f.Locals[3]);f.Pc=1550;continue;}
case 1550:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=1553;continue;}
case 1553:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",1556);}
case 1556:{f.Pc=f.Pop().Int==0?1610:1559;continue;}
case 1559:{f.Push(f.Locals[2]);f.Pc=1560;continue;}
case 1560:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1563;continue;}
case 1563:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",1566);}
case 1566:{f.Pc=f.Pop().Int!=0?1610:1569;continue;}
case 1569:{f.Push(f.Locals[0]);f.Pc=1570;continue;}
case 1570:{f.Push(f.Locals[3]);f.Pc=1571;continue;}
case 1571:{f.Push(f.Locals[5]);f.Pc=1573;continue;}
case 1573:{f.Push(f.Locals[6]);f.Pc=1575;continue;}
case 1575:{return rt.Call(f,"forge/game/GameAction","moveToGraveyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",1578);}
case 1578:{return JStep.Return(f.Pop());}
case 1579:{f.Push(f.Locals[7]);f.Pc=1581;continue;}
case 1581:{f.Pc=f.Pop().Int==0?1610:1584;continue;}
case 1584:{f.Push(f.Locals[3]);f.Pc=1585;continue;}
case 1585:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",1588);}
case 1588:{f.Pc=f.Pop().Int!=0?1610:1591;continue;}
case 1591:{f.Push(f.Locals[0]);f.Pc=1592;continue;}
case 1592:{f.Push(f.Locals[16]);f.Pc=1594;continue;}
case 1594:{f.Push(f.Locals[14]);f.Pc=1596;continue;}
case 1596:{return rt.Call(f,"forge/game/GameAction","cleanStaticEffect","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",1599);}
case 1599:{f.Push(f.Locals[3]);f.Pc=1600;continue;}
case 1600:{return rt.Call(f,"forge/game/card/Card","removeChangedState","()Z","invokevirtual",1603);}
case 1603:{f.Pc=f.Pop().Int==0?1610:1606;continue;}
case 1606:{f.Push(f.Locals[3]);f.Pc=1607;continue;}
case 1607:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",1610);}
case 1610:{f.Push(f.Locals[3]);f.Pc=1611;continue;}
case 1611:{return JStep.Return(f.Pop());}
case 1612:{f.Push(f.Locals[2]);f.Pc=1613;continue;}
case 1613:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=1616;continue;}
case 1616:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",1619);}
case 1619:{f.Pc=f.Pop().Int!=0?1634:1622;continue;}
case 1622:{f.Push(f.Locals[14]);f.Pc=1624;continue;}
case 1624:{f.Push(f.Locals[0]);f.Pc=1625;continue;}
case 1625:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1628;continue;}
case 1628:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",1631);}
case 1631:{return rt.Call(f,"forge/game/card/Card","setGameTimestamp","(J)V","invokevirtual",1634);}
case 1634:{f.Push(f.Locals[14]);f.Pc=1636;continue;}
case 1636:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",1639);}
case 1639:{f.Pc=f.Pop().Int==0?1776:1642;continue;}
case 1642:{f.Push(f.Locals[14]);f.Pc=1644;continue;}
case 1644:{return rt.Call(f,"forge/game/card/Card","isAttachedToEntity","()Z","invokevirtual",1647);}
case 1647:{f.Pc=f.Pop().Int!=0?1776:1650;continue;}
case 1650:{f.Push(f.Locals[7]);f.Pc=1652;continue;}
case 1652:{f.Pc=f.Pop().Int==0?1776:1655;continue;}
case 1655:{f.Push(f.Locals[1]);f.Pc=1656;continue;}
case 1656:{f.Pc=f.Pop().Reference==null?1767:1659;continue;}
case 1659:{f.Push(f.Locals[1]);f.Pc=1660;continue;}
case 1660:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=1663;continue;}
case 1663:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",1666);}
case 1666:{f.Pc=f.Pop().Int==0?1767:1669;continue;}
case 1669:{f.Push(f.Locals[0]);f.Pc=1670;continue;}
case 1670:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1673;continue;}
case 1673:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",1676);}
case 1676:{f.Push(f.Locals[3]);f.Pc=1677;continue;}
case 1677:{return rt.Call(f,"forge/game/zone/MagicStack","isResolving","(Lforge/game/card/Card;)Z","invokevirtual",1680);}
case 1680:{f.Pc=f.Pop().Int==0?1767:1683;continue;}
case 1683:{f.Push(JValue.I(0));f.Pc=1684;continue;}
case 1684:{f.Locals[18]=f.Pop();f.Pc=1686;continue;}
case 1686:{f.Push(f.Locals[0]);f.Pc=1687;continue;}
case 1687:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1690;continue;}
case 1690:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",1693);}
case 1693:{return rt.Call(f,"forge/game/player/PlayerCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",1696);}
case 1696:{f.Push(f.Locals[14]);f.Pc=1698;continue;}
case 1698:{f.Push(JValue.R(null));f.Pc=1699;continue;}
case 1699:{return rt.Call(f,"forge/game/player/PlayerPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;","invokestatic",1702);}
case 1702:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",1707);}
case 1707:{f.Pc=f.Pop().Int==0?1713:1710;continue;}
case 1710:{f.Push(JValue.I(1));f.Pc=1711;continue;}
case 1711:{f.Locals[18]=f.Pop();f.Pc=1713;continue;}
case 1713:{f.Push(f.Locals[11]);f.Pc=1715;continue;}
case 1715:{f.Push(f.Locals[14]);f.Pc=1717;continue;}
case 1717:{f.Push(JValue.R(null));f.Pc=1718;continue;}
case 1718:{return rt.Call(f,"forge/game/card/CardPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;","invokestatic",1721);}
case 1721:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",1726);}
case 1726:{f.Pc=f.Pop().Int==0?1732:1729;continue;}
case 1729:{f.Push(JValue.I(1));f.Pc=1730;continue;}
case 1730:{f.Locals[18]=f.Pop();f.Pc=1732;continue;}
case 1732:{f.Push(f.Locals[12]);f.Pc=1734;continue;}
case 1734:{f.Push(f.Locals[14]);f.Pc=1736;continue;}
case 1736:{f.Push(JValue.R(null));f.Pc=1737;continue;}
case 1737:{return rt.Call(f,"forge/game/card/CardPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;","invokestatic",1740);}
case 1740:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",1745);}
case 1745:{f.Pc=f.Pop().Int==0?1751:1748;continue;}
case 1748:{f.Push(JValue.I(1));f.Pc=1749;continue;}
case 1749:{f.Locals[18]=f.Pop();f.Pc=1751;continue;}
case 1751:{f.Push(f.Locals[18]);f.Pc=1753;continue;}
case 1753:{f.Pc=f.Pop().Int!=0?1767:1756;continue;}
case 1756:{f.Push(f.Locals[0]);f.Pc=1757;continue;}
case 1757:{f.Push(f.Locals[14]);f.Pc=1759;continue;}
case 1759:{f.Push(f.Locals[5]);f.Pc=1761;continue;}
case 1761:{f.Push(f.Locals[6]);f.Pc=1763;continue;}
case 1763:{return rt.Call(f,"forge/game/GameAction","moveToGraveyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",1766);}
case 1766:{return JStep.Return(f.Pop());}
case 1767:{f.Push(f.Locals[0]);f.Pc=1768;continue;}
case 1768:{f.Push(f.Locals[14]);f.Pc=1770;continue;}
case 1770:{f.Push(f.Locals[6]);f.Pc=1772;continue;}
case 1772:{return rt.Call(f,"forge/game/GameAction","attachAuraOnIndirectETB","(Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",1775);}
case 1775:{f.StackOp("pop");f.Pc=1776;continue;}
case 1776:{f.Push(JValue.R(null));f.Pc=1777;continue;}
case 1777:{f.Locals[18]=f.Pop();f.Pc=1779;continue;}
case 1779:{f.Push(f.Locals[8]);f.Pc=1781;continue;}
case 1781:{f.Pc=f.Pop().Int==0?2009:1784;continue;}
case 1784:{f.Push(f.Locals[7]);f.Pc=1786;continue;}
case 1786:{f.Pc=f.Pop().Int!=0?2009:1789;continue;}
case 1789:{f.Push(f.Locals[3]);f.Pc=1790;continue;}
case 1790:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",1793);}
case 1793:{f.Pc=f.Pop().Int==0?2009:1796;continue;}
case 1796:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1799;continue;}
case 1799:{f.StackOp("dup");f.Pc=1800;continue;}
case 1800:{f.Push(f.Locals[3]);f.Pc=1801;continue;}
case 1801:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1804);}
case 1804:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",1807);}
case 1807:{f.Locals[18]=f.Pop();f.Pc=1809;continue;}
case 1809:{f.Push(f.Locals[18]);f.Pc=1811;continue;}
case 1811:{f.Push(f.Locals[18]);f.Pc=1813;continue;}
case 1813:{f.Push(f.Locals[3]);f.Pc=1814;continue;}
case 1814:{return rt.Call(f,"forge/game/card/CardCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",1817);}
case 1817:{f.Push(f.Locals[14]);f.Pc=1819;continue;}
case 1819:{return rt.Call(f,"forge/game/card/CardCollection","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokevirtual",1822);}
case 1822:{f.StackOp("pop");f.Pc=1823;continue;}
case 1823:{f.Push(f.Locals[5]);f.Pc=1825;continue;}
case 1825:{f.Pc=f.Pop().Reference==null?1868:1828;continue;}
case 1828:{f.Push(f.Locals[2]);f.Pc=1829;continue;}
case 1829:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1832);}
case 1832:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=1835;continue;}
case 1835:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1868:1838;continue;}
case 1838:{f.Push(f.Locals[5]);f.Pc=1840;continue;}
case 1840:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1843);}
case 1843:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1846);}
case 1846:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1849);}
case 1849:{f.Push(f.Locals[18]);f.Pc=1851;continue;}
case 1851:{f.Push(f.Locals[2]);f.Pc=1852;continue;}
case 1852:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1855);}
case 1855:{f.Push(f.Locals[5]);f.Pc=1857;continue;}
case 1857:{return rt.Call(f,"forge/game/player/PlayerController","orderMoveToZoneList","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",1860);}
case 1860:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1863;continue;}
case 1863:{f.Locals[18]=f.Pop();f.Pc=1865;continue;}
case 1865:{f.Pc=1891;continue;}
case 1868:{f.Push(f.Locals[3]);f.Pc=1869;continue;}
case 1869:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1872);}
case 1872:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1875);}
case 1875:{f.Push(f.Locals[18]);f.Pc=1877;continue;}
case 1877:{f.Push(f.Locals[2]);f.Pc=1878;continue;}
case 1878:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1881);}
case 1881:{f.Push(f.Locals[5]);f.Pc=1883;continue;}
case 1883:{return rt.Call(f,"forge/game/player/PlayerController","orderMoveToZoneList","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",1886);}
case 1886:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1889;continue;}
case 1889:{f.Locals[18]=f.Pop();f.Pc=1891;continue;}
case 1891:{f.Push(f.Locals[14]);f.Pc=1893;continue;}
case 1893:{return rt.Call(f,"forge/game/card/Card","isStickered","()Z","invokevirtual",1896);}
case 1896:{f.Pc=f.Pop().Int==0?1927:1899;continue;}
case 1899:{f.Push(f.Locals[3]);f.Pc=1900;continue;}
case 1900:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1903);}
case 1903:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1906);}
case 1906:{f.Push(f.Locals[18]);f.Pc=1908;continue;}
case 1908:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardToKeepStickers","(Lforge/game/card/CardCollectionView;)Lforge/game/card/Card;","invokevirtual",1911);}
case 1911:{f.Locals[19]=f.Pop();f.Pc=1913;continue;}
case 1913:{f.Push(f.Locals[19]);f.Pc=1915;continue;}
case 1915:{f.Push(f.Locals[14]);f.Pc=1917;continue;}
case 1917:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1927:1920;continue;}
case 1920:{f.Push(f.Locals[19]);f.Pc=1922;continue;}
case 1922:{f.Push(f.Locals[14]);f.Pc=1924;continue;}
case 1924:{return rt.Call(f,"forge/game/card/Card","takeStickersFrom","(Lforge/game/card/Card;)V","invokevirtual",1927);}
case 1927:{f.Push(f.Locals[18]);f.Pc=1929;continue;}
case 1929:{f.Push(f.Locals[18]);f.Pc=1931;continue;}
case 1931:{f.Push(f.Locals[14]);f.Pc=1933;continue;}
case 1933:{return rt.Call(f,"forge/game/card/CardCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",1936);}
case 1936:{f.Push(f.Locals[3]);f.Pc=1937;continue;}
case 1937:{return rt.Call(f,"forge/game/card/CardCollection","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokevirtual",1940);}
case 1940:{f.StackOp("pop");f.Pc=1941;continue;}
case 1941:{f.Push(f.Locals[5]);f.Pc=1943;continue;}
case 1943:{f.Pc=f.Pop().Reference==null?2009:1946;continue;}
case 1946:{f.Push(f.Locals[5]);f.Pc=1948;continue;}
case 1948:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSATargetingCard","()Lforge/game/spellability/SpellAbility;","invokevirtual",1951);}
case 1951:{f.Locals[19]=f.Pop();f.Pc=1953;continue;}
case 1953:{f.Push(f.Locals[19]);f.Pc=1955;continue;}
case 1955:{f.Pc=f.Pop().Reference==null?1969:1958;continue;}
case 1958:{f.Push(f.Locals[19]);f.Pc=1960;continue;}
case 1960:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1963);}
case 1963:{f.Push(f.Locals[3]);f.Pc=1964;continue;}
case 1964:{f.Push(f.Locals[18]);f.Pc=1966;continue;}
case 1966:{return rt.Call(f,"forge/game/spellability/TargetChoices","replaceTargetCard","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;)V","invokevirtual",1969);}
case 1969:{f.Push(f.Locals[5]);f.Pc=1971;continue;}
case 1971:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1974);}
case 1974:{f.Locals[20]=f.Pop();f.Pc=1976;continue;}
case 1976:{f.Push(f.Locals[5]);f.Pc=1978;continue;}
case 1978:{f.Push(JValue.R(rt.String("RememberLKI")));f.Pc=1981;continue;}
case 1981:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1984);}
case 1984:{f.Pc=f.Pop().Int!=0?2009:1987;continue;}
case 1987:{f.Push(f.Locals[20]);f.Pc=1989;continue;}
case 1989:{f.Push(f.Locals[3]);f.Pc=1990;continue;}
case 1990:{return rt.Call(f,"forge/game/card/Card","isRemembered","(Ljava/lang/Object;)Z","invokevirtual",1993);}
case 1993:{f.Pc=f.Pop().Int==0?2009:1996;continue;}
case 1996:{f.Push(f.Locals[20]);f.Pc=1998;continue;}
case 1998:{f.Push(f.Locals[3]);f.Pc=1999;continue;}
case 1999:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",2002);}
case 2002:{f.Push(f.Locals[20]);f.Pc=2004;continue;}
case 2004:{f.Push(f.Locals[18]);f.Pc=2006;continue;}
case 2006:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",2009);}
case 2009:{f.Push(f.Locals[1]);f.Pc=2010;continue;}
case 2010:{f.Pc=f.Pop().Reference==null?2463:2013;continue;}
case 2013:{f.Push(f.Locals[8]);f.Pc=2015;continue;}
case 2015:{f.Pc=f.Pop().Int==0?2057:2018;continue;}
case 2018:{f.Push(f.Locals[0]);f.Pc=2019;continue;}
case 2019:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=2022;continue;}
case 2022:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",2025);}
case 2025:{f.Pc=f.Pop().Reference==null?2057:2028;continue;}
case 2028:{f.Push(f.Locals[7]);f.Pc=2030;continue;}
case 2030:{f.Pc=f.Pop().Int!=0?2046:2033;continue;}
case 2033:{f.Push(f.Locals[0]);f.Pc=2034;continue;}
case 2034:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=2037;continue;}
case 2037:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",2040);}
case 2040:{f.Push(f.Locals[15]);f.Pc=2042;continue;}
case 2042:{return rt.Call(f,"forge/game/combat/Combat","saveLKI","(Lforge/game/card/Card;)Lforge/game/combat/CombatLki;","invokevirtual",2045);}
case 2045:{f.StackOp("pop");f.Pc=2046;continue;}
case 2046:{f.Push(f.Locals[0]);f.Pc=2047;continue;}
case 2047:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=2050;continue;}
case 2050:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",2053);}
case 2053:{f.Push(f.Locals[3]);f.Pc=2054;continue;}
case 2054:{return rt.Call(f,"forge/game/combat/Combat","removeFromCombat","(Lforge/game/card/Card;)V","invokevirtual",2057);}
case 2057:{f.Push(f.Locals[1]);f.Pc=2058;continue;}
case 2058:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",2061);}
case 2061:{return rt.Call(f,"forge/game/zone/ZoneType","isDeck","()Z","invokevirtual",2064);}
case 2064:{f.Pc=f.Pop().Int==0?2114:2067;continue;}
case 2067:{f.Push(f.Locals[1]);f.Pc=2068;continue;}
case 2068:{f.Push(f.Locals[2]);f.Pc=2069;continue;}
case 2069:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?2114:2072;continue;}
case 2072:{f.Push(f.Locals[4]);f.Pc=2074;continue;}
case 2074:{f.Push(f.Locals[1]);f.Pc=2075;continue;}
case 2075:{return rt.Call(f,"forge/game/zone/Zone","size","()I","invokevirtual",2078);}
case 2078:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",2081);}
case 2081:{return rt.Call(f,"java/lang/Integer","equals","(Ljava/lang/Object;)Z","invokevirtual",2084);}
case 2084:{f.Pc=f.Pop().Int==0?2114:2087;continue;}
case 2087:{f.Push(f.Locals[4]);f.Pc=2089;continue;}
case 2089:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",2092);}
case 2092:{f.Pc=f.Pop().Int==0?2114:2095;continue;}
case 2095:{f.Push(f.Locals[4]);f.Pc=2097;continue;}
case 2097:{f.Locals[19]=f.Pop();f.Pc=2099;continue;}
case 2099:{f.Push(f.Locals[4]);f.Pc=2101;continue;}
case 2101:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",2104);}
case 2104:{f.Push(JValue.I(1));f.Pc=2105;continue;}
case 2105:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=2106;continue;}
case 2106:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",2109);}
case 2109:{f.Locals[4]=f.Pop();f.Pc=2111;continue;}
case 2111:{f.Push(f.Locals[19]);f.Pc=2113;continue;}
case 2113:{f.StackOp("pop");f.Pc=2114;continue;}
case 2114:{f.Push(f.Locals[18]);f.Pc=2116;continue;}
case 2116:{f.Pc=f.Pop().Reference==null?2166:2119;continue;}
case 2119:{f.Push(f.Locals[18]);f.Pc=2121;continue;}
case 2121:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2124);}
case 2124:{f.Locals[19]=f.Pop();f.Pc=2126;continue;}
case 2126:{f.Push(f.Locals[19]);f.Pc=2128;continue;}
case 2128:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2133);}
case 2133:{f.Pc=f.Pop().Int==0?2166:2136;continue;}
case 2136:{f.Push(f.Locals[19]);f.Pc=2138;continue;}
case 2138:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2143);}
case 2143:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2146;continue;}
case 2146:{f.Locals[20]=f.Pop();f.Pc=2148;continue;}
case 2148:{f.Push(f.Locals[3]);f.Pc=2149;continue;}
case 2149:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",2152);}
case 2152:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"));f.Pc=2155;continue;}
case 2155:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",2158);}
case 2158:{f.Push(f.Locals[20]);f.Pc=2160;continue;}
case 2160:{return rt.Call(f,"forge/game/zone/PlayerZone","remove","(Lforge/game/card/Card;)V","invokevirtual",2163);}
case 2163:{f.Pc=2126;continue;}
case 2166:{f.Push(f.Locals[1]);f.Pc=2167;continue;}
case 2167:{f.Push(f.Locals[3]);f.Pc=2168;continue;}
case 2168:{return rt.Call(f,"forge/game/zone/Zone","remove","(Lforge/game/card/Card;)V","invokevirtual",2171);}
case 2171:{f.Push(f.Locals[3]);f.Pc=2172;continue;}
case 2172:{return rt.Call(f,"forge/game/card/Card","hasEncodedCard","()Z","invokevirtual",2175);}
case 2175:{f.Pc=f.Pop().Int==0?2220:2178;continue;}
case 2178:{f.Push(f.Locals[3]);f.Pc=2179;continue;}
case 2179:{return rt.Call(f,"forge/game/card/Card","getEncodedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",2182);}
case 2182:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",2187);}
case 2187:{f.Locals[19]=f.Pop();f.Pc=2189;continue;}
case 2189:{f.Push(f.Locals[19]);f.Pc=2191;continue;}
case 2191:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2196);}
case 2196:{f.Pc=f.Pop().Int==0?2220:2199;continue;}
case 2199:{f.Push(f.Locals[19]);f.Pc=2201;continue;}
case 2201:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2206);}
case 2206:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2209;continue;}
case 2209:{f.Locals[20]=f.Pop();f.Pc=2211;continue;}
case 2211:{f.Push(f.Locals[20]);f.Pc=2213;continue;}
case 2213:{f.Push(JValue.R(null));f.Pc=2214;continue;}
case 2214:{return rt.Call(f,"forge/game/card/Card","setEncodingCard","(Lforge/game/card/Card;)V","invokevirtual",2217);}
case 2217:{f.Pc=2189;continue;}
case 2220:{f.Push(f.Locals[1]);f.Pc=2221;continue;}
case 2221:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=2224;continue;}
case 2224:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",2227);}
case 2227:{f.Pc=f.Pop().Int==0?2247:2230;continue;}
case 2230:{f.Push(f.Locals[3]);f.Pc=2231;continue;}
case 2231:{return rt.Call(f,"forge/game/card/Card","getEncodingCard","()Lforge/game/card/Card;","invokevirtual",2234);}
case 2234:{f.Locals[19]=f.Pop();f.Pc=2236;continue;}
case 2236:{f.Push(f.Locals[19]);f.Pc=2238;continue;}
case 2238:{f.Pc=f.Pop().Reference==null?2247:2241;continue;}
case 2241:{f.Push(f.Locals[19]);f.Pc=2243;continue;}
case 2243:{f.Push(f.Locals[3]);f.Pc=2244;continue;}
case 2244:{return rt.Call(f,"forge/game/card/Card","removeEncodedCard","(Lforge/game/card/Card;)V","invokevirtual",2247);}
case 2247:{f.Push(f.Locals[1]);f.Pc=2248;continue;}
case 2248:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=2251;continue;}
case 2251:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",2254);}
case 2254:{f.Pc=f.Pop().Int==0?2435:2257;continue;}
case 2257:{f.Push(f.Locals[7]);f.Pc=2259;continue;}
case 2259:{f.Pc=f.Pop().Int==0?2435:2262;continue;}
case 2262:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","hashKeys","()Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",2265);}
case 2265:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","arrayListValues","()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;","invokevirtual",2268);}
case 2268:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$ListMultimapBuilder","build","()Lcom/google/common/collect/ListMultimap;","invokevirtual",2271);}
case 2271:{f.Locals[19]=f.Pop();f.Pc=2273;continue;}
case 2273:{f.Push(f.Locals[3]);f.Pc=2274;continue;}
case 2274:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","OFFSPRING","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","OFFSPRING","Lforge/game/keyword/Keyword;"));f.Pc=2277;continue;}
case 2277:{return rt.Call(f,"forge/game/card/Card","getKeywords","(Lforge/game/keyword/Keyword;)Ljava/util/Collection;","invokevirtual",2280);}
case 2280:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",2285);}
case 2285:{f.Locals[20]=f.Pop();f.Pc=2287;continue;}
case 2287:{f.Push(f.Locals[20]);f.Pc=2289;continue;}
case 2289:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2294);}
case 2294:{f.Pc=f.Pop().Int==0?2339:2297;continue;}
case 2297:{f.Push(f.Locals[20]);f.Pc=2299;continue;}
case 2299:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2304);}
case 2304:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2307;continue;}
case 2307:{f.Locals[21]=f.Pop();f.Pc=2309;continue;}
case 2309:{f.Push(f.Locals[21]);f.Pc=2311;continue;}
case 2311:{return rt.Call(f,"forge/game/keyword/KeywordInterface","isIntrinsic","()Z","invokeinterface",2316);}
case 2316:{f.Pc=f.Pop().Int!=0?2336:2319;continue;}
case 2319:{f.Push(f.Locals[19]);f.Pc=2321;continue;}
case 2321:{f.Push(f.Locals[21]);f.Pc=2323;continue;}
case 2323:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",2328);}
case 2328:{f.Push(f.Locals[21]);f.Pc=2330;continue;}
case 2330:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",2335);}
case 2335:{f.StackOp("pop");f.Pc=2336;continue;}
case 2336:{f.Pc=2287;continue;}
case 2339:{f.Push(f.Locals[19]);f.Pc=2341;continue;}
case 2341:{return rt.Call(f,"com/google/common/collect/Multimap","isEmpty","()Z","invokeinterface",2346);}
case 2346:{f.Pc=f.Pop().Int!=0?2426:2349;continue;}
case 2349:{f.Push(f.Locals[19]);f.Pc=2351;continue;}
case 2351:{return rt.Call(f,"com/google/common/collect/Multimap","asMap","()Ljava/util/Map;","invokeinterface",2356);}
case 2356:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",2361);}
case 2361:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",2366);}
case 2366:{f.Locals[20]=f.Pop();f.Pc=2368;continue;}
case 2368:{f.Push(f.Locals[20]);f.Pc=2370;continue;}
case 2370:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2375);}
case 2375:{f.Pc=f.Pop().Int==0?2426:2378;continue;}
case 2378:{f.Push(f.Locals[20]);f.Pc=2380;continue;}
case 2380:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2385);}
case 2385:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2388;continue;}
case 2388:{f.Locals[21]=f.Pop();f.Pc=2390;continue;}
case 2390:{f.Push(f.Locals[14]);f.Pc=2392;continue;}
case 2392:{f.Push(f.Locals[21]);f.Pc=2394;continue;}
case 2394:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",2399);}
case 2399:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2402;continue;}
case 2402:{f.Push(JValue.R(null));f.Pc=2403;continue;}
case 2403:{f.Push(JValue.I(0));f.Pc=2404;continue;}
case 2404:{f.Push(f.Locals[14]);f.Pc=2406;continue;}
case 2406:{return rt.Call(f,"forge/game/card/Card","getGameTimestamp","()J","invokevirtual",2409);}
case 2409:{f.Push(f.Locals[21]);f.Pc=2411;continue;}
case 2411:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",2416);}
case 2416:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2419;continue;}
case 2419:{f.Push(JValue.I(1));f.Pc=2420;continue;}
case 2420:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywordsInternal","(Ljava/util/Collection;Ljava/util/Collection;ZJLforge/game/staticability/StaticAbility;Z)V","invokevirtual",2423);}
case 2423:{f.Pc=2368;continue;}
case 2426:{f.Push(f.Locals[14]);f.Pc=2428;continue;}
case 2428:{f.Push(f.Locals[3]);f.Pc=2429;continue;}
case 2429:{return rt.Call(f,"forge/game/card/Card","getExiledCards","()Lforge/game/card/CardCollectionView;","invokevirtual",2432);}
case 2432:{return rt.Call(f,"forge/game/card/Card","addExiledCards","(Ljava/lang/Iterable;)V","invokevirtual",2435);}
case 2435:{f.Push(f.Locals[5]);f.Pc=2437;continue;}
case 2437:{f.Pc=f.Pop().Reference==null?2463:2440;continue;}
case 2440:{f.Push(f.Locals[5]);f.Pc=2442;continue;}
case 2442:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCraft","()Z","invokevirtual",2445);}
case 2445:{f.Pc=f.Pop().Int==0?2463:2448;continue;}
case 2448:{f.Push(f.Locals[7]);f.Pc=2450;continue;}
case 2450:{f.Pc=f.Pop().Int==0?2463:2453;continue;}
case 2453:{f.Push(f.Locals[14]);f.Pc=2455;continue;}
case 2455:{f.Push(f.Locals[5]);f.Pc=2457;continue;}
case 2457:{f.Push(JValue.R(rt.String("ExiledCards")));f.Pc=2460;continue;}
case 2460:{return rt.Call(f,"forge/game/card/Card","retainPaidList","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)V","invokevirtual",2463);}
case 2463:{f.Push(f.Locals[18]);f.Pc=2465;continue;}
case 2465:{f.Pc=f.Pop().Reference==null?2763:2468;continue;}
case 2468:{f.Push(f.Locals[3]);f.Pc=2469;continue;}
case 2469:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",2472);}
case 2472:{f.Locals[19]=f.Pop();f.Pc=2474;continue;}
case 2474:{f.Push(f.Locals[3]);f.Pc=2475;continue;}
case 2475:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",2478);}
case 2478:{f.Push(JValue.I(0));f.Pc=2479;continue;}
case 2479:{return rt.Call(f,"forge/game/player/Player","setCommanderReplacementSuppressed","(Z)V","invokevirtual",2482);}
case 2482:{f.Push(f.Locals[3]);f.Pc=2483;continue;}
case 2483:{f.Push(f.Locals[2]);f.Pc=2484;continue;}
case 2484:{return rt.Call(f,"forge/game/card/Card","setZone","(Lforge/game/zone/Zone;)V","invokevirtual",2487);}
case 2487:{f.Push(f.Locals[18]);f.Pc=2489;continue;}
case 2489:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2492);}
case 2492:{f.Locals[20]=f.Pop();f.Pc=2494;continue;}
case 2494:{f.Push(f.Locals[20]);f.Pc=2496;continue;}
case 2496:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2501);}
case 2501:{f.Pc=f.Pop().Int==0?2755:2504;continue;}
case 2504:{f.Push(f.Locals[20]);f.Pc=2506;continue;}
case 2506:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2511);}
case 2511:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2514;continue;}
case 2514:{f.Locals[21]=f.Pop();f.Pc=2516;continue;}
case 2516:{f.Push(f.Locals[21]);f.Pc=2518;continue;}
case 2518:{return rt.Call(f,"forge/game/card/Card","isRealCommander","()Z","invokevirtual",2521);}
case 2521:{f.Pc=f.Pop().Int==0?2530:2524;continue;}
case 2524:{f.Push(f.Locals[21]);f.Pc=2526;continue;}
case 2526:{f.Push(JValue.I(1));f.Pc=2527;continue;}
case 2527:{return rt.Call(f,"forge/game/card/Card","setMoveToCommandZone","(Z)V","invokevirtual",2530);}
case 2530:{f.Push(f.Locals[19]);f.Pc=2532;continue;}
case 2532:{f.Pc=f.Pop().Int==0?2543:2535;continue;}
case 2535:{f.Push(f.Locals[21]);f.Pc=2537;continue;}
case 2537:{return rt.Call(f,"forge/game/card/Card","isRealToken","()Z","invokevirtual",2540);}
case 2540:{f.Pc=f.Pop().Int==0?2551:2543;continue;}
case 2543:{f.Push(f.Locals[21]);f.Pc=2545;continue;}
case 2545:{return rt.Call(f,"forge/game/card/Card","isRealCommander","()Z","invokevirtual",2548);}
case 2548:{f.Pc=f.Pop().Int==0?2664:2551;continue;}
case 2551:{f.Push(f.Locals[21]);f.Pc=2553;continue;}
case 2553:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",2556);}
case 2556:{f.Locals[22]=f.Pop();f.Pc=2558;continue;}
case 2558:{f.Push(f.Locals[22]);f.Pc=2560;continue;}
case 2560:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=2563;continue;}
case 2563:{f.Push(f.Locals[21]);f.Pc=2565;continue;}
case 2565:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2570);}
case 2570:{f.StackOp("pop");f.Pc=2571;continue;}
case 2571:{f.Push(f.Locals[22]);f.Pc=2573;continue;}
case 2573:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=2576;continue;}
case 2576:{f.Push(f.Locals[5]);f.Pc=2578;continue;}
case 2578:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2583);}
case 2583:{f.StackOp("pop");f.Pc=2584;continue;}
case 2584:{f.Push(f.Locals[22]);f.Pc=2586;continue;}
case 2586:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"));f.Pc=2589;continue;}
case 2589:{f.Push(f.Locals[1]);f.Pc=2590;continue;}
case 2590:{f.Pc=f.Pop().Reference==null?2600:2593;continue;}
case 2593:{f.Push(f.Locals[1]);f.Pc=2594;continue;}
case 2594:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",2597);}
case 2597:{f.Pc=2601;continue;}
case 2600:{f.Push(JValue.R(null));f.Pc=2601;continue;}
case 2601:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2606);}
case 2606:{f.StackOp("pop");f.Pc=2607;continue;}
case 2607:{f.Push(f.Locals[22]);f.Pc=2609;continue;}
case 2609:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=2612;continue;}
case 2612:{f.Push(f.Locals[2]);f.Pc=2613;continue;}
case 2613:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",2616);}
case 2616:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2621);}
case 2621:{f.StackOp("pop");f.Pc=2622;continue;}
case 2622:{f.Push(f.Locals[6]);f.Pc=2624;continue;}
case 2624:{f.Pc=f.Pop().Reference==null?2636:2627;continue;}
case 2627:{f.Push(f.Locals[22]);f.Pc=2629;continue;}
case 2629:{f.Push(f.Locals[6]);f.Pc=2631;continue;}
case 2631:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",2636);}
case 2636:{f.Push(f.Locals[0]);f.Pc=2637;continue;}
case 2637:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=2640;continue;}
case 2640:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",2643);}
case 2643:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"));f.Pc=2646;continue;}
case 2646:{f.Push(f.Locals[22]);f.Pc=2648;continue;}
case 2648:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",2651);}
case 2651:{f.Locals[23]=f.Pop();f.Pc=2653;continue;}
case 2653:{f.Push(f.Locals[23]);f.Pc=2655;continue;}
case 2655:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=2658;continue;}
case 2658:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?2664:2661;continue;}
case 2661:{f.Pc=2494;continue;}
case 2664:{f.Push(f.Locals[21]);f.Pc=2666;continue;}
case 2666:{f.Push(f.Locals[3]);f.Pc=2667;continue;}
case 2667:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?2702:2670;continue;}
case 2670:{f.Push(f.Locals[0]);f.Pc=2671;continue;}
case 2671:{f.Push(f.Locals[14]);f.Pc=2673;continue;}
case 2673:{f.Push(f.Locals[1]);f.Pc=2674;continue;}
case 2674:{f.Push(f.Locals[2]);f.Pc=2675;continue;}
case 2675:{f.Push(f.Locals[6]);f.Pc=2677;continue;}
case 2677:{return rt.Call(f,"forge/game/GameAction","storeChangesZoneAll","(Lforge/game/card/Card;Lforge/game/zone/Zone;Lforge/game/zone/Zone;Ljava/util/Map;)V","invokevirtual",2680);}
case 2680:{f.Push(f.Locals[2]);f.Pc=2681;continue;}
case 2681:{f.Push(f.Locals[14]);f.Pc=2683;continue;}
case 2683:{f.Push(f.Locals[4]);f.Pc=2685;continue;}
case 2685:{f.Push(f.Locals[7]);f.Pc=2687;continue;}
case 2687:{f.Pc=f.Pop().Int==0?2694:2690;continue;}
case 2690:{f.Push(JValue.R(null));f.Pc=2691;continue;}
case 2691:{f.Pc=2696;continue;}
case 2694:{f.Push(f.Locals[15]);f.Pc=2696;continue;}
case 2696:{return rt.Call(f,"forge/game/zone/Zone","add","(Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/card/Card;)V","invokevirtual",2699);}
case 2699:{f.Pc=2746;continue;}
case 2702:{f.Push(f.Locals[0]);f.Pc=2703;continue;}
case 2703:{f.Push(f.Locals[21]);f.Pc=2705;continue;}
case 2705:{f.Push(f.Locals[1]);f.Pc=2706;continue;}
case 2706:{f.Push(f.Locals[2]);f.Pc=2707;continue;}
case 2707:{f.Push(f.Locals[6]);f.Pc=2709;continue;}
case 2709:{return rt.Call(f,"forge/game/GameAction","storeChangesZoneAll","(Lforge/game/card/Card;Lforge/game/zone/Zone;Lforge/game/zone/Zone;Ljava/util/Map;)V","invokevirtual",2712);}
case 2712:{f.Push(f.Locals[2]);f.Pc=2713;continue;}
case 2713:{f.Push(f.Locals[21]);f.Pc=2715;continue;}
case 2715:{f.Push(f.Locals[4]);f.Pc=2717;continue;}
case 2717:{f.Push(f.Locals[21]);f.Pc=2719;continue;}
case 2719:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",2722);}
case 2722:{return rt.Call(f,"forge/game/zone/Zone","add","(Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/card/Card;)V","invokevirtual",2725);}
case 2725:{f.Push(f.Locals[21]);f.Pc=2727;continue;}
case 2727:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=2730;continue;}
case 2730:{f.Push(JValue.I(0));f.Pc=2731;continue;}
case 2731:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",2734);}
case 2734:{f.StackOp("pop");f.Pc=2735;continue;}
case 2735:{f.Push(f.Locals[21]);f.Pc=2737;continue;}
case 2737:{f.Push(JValue.I(0));f.Pc=2738;continue;}
case 2738:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",2741);}
case 2741:{f.Push(f.Locals[21]);f.Pc=2743;continue;}
case 2743:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",2746);}
case 2746:{f.Push(f.Locals[21]);f.Pc=2748;continue;}
case 2748:{f.Push(f.Locals[2]);f.Pc=2749;continue;}
case 2749:{return rt.Call(f,"forge/game/card/Card","setZone","(Lforge/game/zone/Zone;)V","invokevirtual",2752);}
case 2752:{f.Pc=2494;continue;}
case 2755:{f.Push(f.Locals[14]);f.Pc=2757;continue;}
case 2757:{return rt.Call(f,"forge/game/card/Card","clearMergedCards","()V","invokevirtual",2760);}
case 2760:{f.Pc=2802;continue;}
case 2763:{f.Push(f.Locals[13]);f.Pc=2765;continue;}
case 2765:{f.Pc=f.Pop().Int!=0?2778:2768;continue;}
case 2768:{f.Push(f.Locals[0]);f.Pc=2769;continue;}
case 2769:{f.Push(f.Locals[14]);f.Pc=2771;continue;}
case 2771:{f.Push(f.Locals[1]);f.Pc=2772;continue;}
case 2772:{f.Push(f.Locals[2]);f.Pc=2773;continue;}
case 2773:{f.Push(f.Locals[6]);f.Pc=2775;continue;}
case 2775:{return rt.Call(f,"forge/game/GameAction","storeChangesZoneAll","(Lforge/game/card/Card;Lforge/game/zone/Zone;Lforge/game/zone/Zone;Ljava/util/Map;)V","invokevirtual",2778);}
case 2778:{f.Push(f.Locals[2]);f.Pc=2779;continue;}
case 2779:{f.Push(f.Locals[14]);f.Pc=2781;continue;}
case 2781:{f.Push(f.Locals[4]);f.Pc=2783;continue;}
case 2783:{f.Push(f.Locals[7]);f.Pc=2785;continue;}
case 2785:{f.Pc=f.Pop().Int==0?2792:2788;continue;}
case 2788:{f.Push(JValue.R(null));f.Pc=2789;continue;}
case 2789:{f.Pc=2794;continue;}
case 2792:{f.Push(f.Locals[15]);f.Pc=2794;continue;}
case 2794:{return rt.Call(f,"forge/game/zone/Zone","add","(Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/card/Card;)V","invokevirtual",2797);}
case 2797:{f.Push(f.Locals[3]);f.Pc=2798;continue;}
case 2798:{f.Push(f.Locals[2]);f.Pc=2799;continue;}
case 2799:{return rt.Call(f,"forge/game/card/Card","setZone","(Lforge/game/zone/Zone;)V","invokevirtual",2802);}
case 2802:{f.Push(f.Locals[8]);f.Pc=2804;continue;}
case 2804:{f.Pc=f.Pop().Int==0?2856:2807;continue;}
case 2807:{f.Push(f.Locals[0]);f.Pc=2808;continue;}
case 2808:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=2811;continue;}
case 2811:{f.Push(f.Locals[15]);f.Pc=2813;continue;}
case 2813:{return rt.Call(f,"forge/game/Game","addLeftBattlefieldThisTurn","(Lforge/game/card/Card;)V","invokevirtual",2816);}
case 2816:{f.Push(f.Locals[14]);f.Pc=2818;continue;}
case 2818:{f.Push(f.Locals[3]);f.Pc=2819;continue;}
case 2819:{return rt.Call(f,"forge/game/GameAction","unattachCardLeavingBattlefield","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokestatic",2822);}
case 2822:{f.Push(f.Locals[3]);f.Pc=2823;continue;}
case 2823:{return rt.Call(f,"forge/game/card/Card","runLeavesPlayCommands","()V","invokevirtual",2826);}
case 2826:{f.Push(f.Locals[14]);f.Pc=2828;continue;}
case 2828:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",2831);}
case 2831:{f.Pc=f.Pop().Int==0?2856:2834;continue;}
case 2834:{f.Push(f.Locals[14]);f.Pc=2836;continue;}
case 2836:{f.Push(JValue.I(0));f.Pc=2837;continue;}
case 2837:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",2840);}
case 2840:{f.Push(f.Locals[0]);f.Pc=2841;continue;}
case 2841:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=2844;continue;}
case 2844:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardTapped"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardTapped")));f.Pc=2847;continue;}
case 2847:{f.StackOp("dup");f.Pc=2848;continue;}
case 2848:{f.Push(f.Locals[3]);f.Pc=2849;continue;}
case 2849:{f.Push(JValue.I(0));f.Pc=2850;continue;}
case 2850:{return rt.Call(f,"forge/game/event/GameEventCardTapped","<init>","(Lforge/game/card/Card;Z)V","invokespecial",2853);}
case 2853:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",2856);}
case 2856:{f.Push(f.Locals[9]);f.Pc=2858;continue;}
case 2858:{f.Pc=f.Pop().Int==0?2870:2861;continue;}
case 2861:{f.Push(f.Locals[0]);f.Pc=2862;continue;}
case 2862:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=2865;continue;}
case 2865:{f.Push(f.Locals[15]);f.Pc=2867;continue;}
case 2867:{return rt.Call(f,"forge/game/Game","addLeftGraveyardThisTurn","(Lforge/game/card/Card;)V","invokevirtual",2870);}
case 2870:{f.Push(f.Locals[3]);f.Pc=2871;continue;}
case 2871:{return rt.Call(f,"forge/game/card/Card","hasMarkedColor","()Z","invokevirtual",2874);}
case 2874:{f.Pc=f.Pop().Int==0?2886:2877;continue;}
case 2877:{f.Push(f.Locals[14]);f.Pc=2879;continue;}
case 2879:{f.Push(f.Locals[3]);f.Pc=2880;continue;}
case 2880:{return rt.Call(f,"forge/game/card/Card","getMarkedColors","()Lforge/card/ColorSet;","invokevirtual",2883);}
case 2883:{return rt.Call(f,"forge/game/card/Card","setMarkedColors","(Lforge/card/ColorSet;)V","invokevirtual",2886);}
case 2886:{f.Push(f.Locals[14]);f.Pc=2888;continue;}
case 2888:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",2891);}
case 2891:{f.Push(f.Locals[0]);f.Pc=2892;continue;}
case 2892:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=2895;continue;}
case 2895:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",2898);}
case 2898:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"));f.Pc=2901;continue;}
case 2901:{return rt.Call(f,"forge/game/trigger/TriggerHandler","suppressMode","(Lforge/game/trigger/TriggerType;)V","invokevirtual",2904);}
case 2904:{f.Push(f.Locals[0]);f.Pc=2905;continue;}
case 2905:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","()V","invokevirtual",2908);}
case 2908:{f.Push(f.Locals[13]);f.Pc=2910;continue;}
case 2910:{f.Pc=f.Pop().Int!=0?2931:2913;continue;}
case 2913:{f.Push(f.Locals[7]);f.Pc=2915;continue;}
case 2915:{f.Pc=f.Pop().Int==0?2931:2918;continue;}
case 2918:{f.Push(f.Locals[0]);f.Pc=2919;continue;}
case 2919:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=2922;continue;}
case 2922:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",2925);}
case 2925:{f.Push(f.Locals[14]);f.Pc=2927;continue;}
case 2927:{f.Push(JValue.I(0));f.Pc=2928;continue;}
case 2928:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerActiveTrigger","(Lforge/game/card/Card;Z)V","invokevirtual",2931);}
case 2931:{f.Push(f.Locals[17]);f.Pc=2933;continue;}
case 2933:{f.Push(f.Locals[0]);f.Pc=2934;continue;}
case 2934:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=2937;continue;}
case 2937:{f.Push(JValue.R(null));f.Pc=2938;continue;}
case 2938:{f.Push(JValue.I(1));f.Pc=2939;continue;}
case 2939:{f.Push(JValue.I(1));f.Pc=2940;continue;}
case 2940:{f.Push(f.Locals[6]);f.Pc=2942;continue;}
case 2942:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;ZZLjava/util/Map;)Z","invokevirtual",2945);}
case 2945:{f.StackOp("pop");f.Pc=2946;continue;}
case 2946:{f.Push(f.Locals[0]);f.Pc=2947;continue;}
case 2947:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=2950;continue;}
case 2950:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",2953);}
case 2953:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"));f.Pc=2956;continue;}
case 2956:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearSuppression","(Lforge/game/trigger/TriggerType;)V","invokevirtual",2959);}
case 2959:{f.Push(f.Locals[0]);f.Pc=2960;continue;}
case 2960:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","()V","invokevirtual",2963);}
case 2963:{f.Push(f.Locals[7]);f.Pc=2965;continue;}
case 2965:{f.Pc=f.Pop().Int==0?3014:2968;continue;}
case 2968:{f.Push(f.Locals[2]);f.Pc=2969;continue;}
case 2969:{f.Push(f.Locals[14]);f.Pc=2971;continue;}
case 2971:{f.Push(f.Locals[15]);f.Pc=2973;continue;}
case 2973:{return rt.Call(f,"forge/game/zone/Zone","saveLKI","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",2976);}
case 2976:{f.Push(f.Locals[14]);f.Pc=2978;continue;}
case 2978:{return rt.Call(f,"forge/game/card/Card","isRoom","()Z","invokevirtual",2981);}
case 2981:{f.Pc=f.Pop().Int==0?3014:2984;continue;}
case 2984:{f.Push(f.Locals[14]);f.Pc=2986;continue;}
case 2986:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",2989);}
case 2989:{f.Pc=f.Pop().Reference==null?3014:2992;continue;}
case 2992:{f.Push(f.Locals[14]);f.Pc=2994;continue;}
case 2994:{f.Push(f.Locals[14]);f.Pc=2996;continue;}
case 2996:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",2999);}
case 2999:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",3002);}
case 3002:{f.Push(f.Locals[14]);f.Pc=3004;continue;}
case 3004:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",3007);}
case 3007:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardStateName","()Lforge/card/CardStateName;","invokevirtual",3010);}
case 3010:{return rt.Call(f,"forge/game/card/Card","unlockRoom","(Lforge/game/player/Player;Lforge/card/CardStateName;)Z","invokevirtual",3013);}
case 3013:{f.StackOp("pop");f.Pc=3014;continue;}
case 3014:{f.Push(f.Locals[2]);f.Pc=3015;continue;}
case 3015:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=3018;continue;}
case 3018:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",3021);}
case 3021:{f.Pc=f.Pop().Int!=0?3028:3024;continue;}
case 3024:{f.Push(f.Locals[3]);f.Pc=3025;continue;}
case 3025:{return rt.Call(f,"forge/game/card/Card","cleanupExiledWith","()V","invokevirtual",3028);}
case 3028:{f.Push(f.Locals[3]);f.Pc=3029;continue;}
case 3029:{return rt.Call(f,"forge/game/card/Card","isStickered","()Z","invokevirtual",3032);}
case 3032:{f.Pc=f.Pop().Int!=0?3043:3035;continue;}
case 3035:{f.Push(f.Locals[14]);f.Pc=3037;continue;}
case 3037:{return rt.Call(f,"forge/game/card/Card","isStickered","()Z","invokevirtual",3040);}
case 3040:{f.Pc=f.Pop().Int==0?3051:3043;continue;}
case 3043:{f.Push(f.Locals[14]);f.Pc=3045;continue;}
case 3045:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",3048);}
case 3048:{return rt.Call(f,"forge/game/card/Card","refreshSheetViews","(Lforge/game/player/Player;)V","invokestatic",3051);}
case 3051:{f.Push(f.Locals[0]);f.Pc=3052;continue;}
case 3052:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=3055;continue;}
case 3055:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardChangeZone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardChangeZone")));f.Pc=3058;continue;}
case 3058:{f.StackOp("dup");f.Pc=3059;continue;}
case 3059:{f.Push(f.Locals[3]);f.Pc=3060;continue;}
case 3060:{f.Push(f.Locals[1]);f.Pc=3061;continue;}
case 3061:{f.Push(f.Locals[2]);f.Pc=3062;continue;}
case 3062:{return rt.Call(f,"forge/game/event/GameEventCardChangeZone","<init>","(Lforge/game/card/Card;Lforge/game/zone/Zone;Lforge/game/zone/Zone;)V","invokespecial",3065);}
case 3065:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",3068);}
case 3068:{f.Push(f.Locals[0]);f.Pc=3069;continue;}
case 3069:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=3072;continue;}
case 3072:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",3075);}
case 3075:{f.Push(f.Locals[14]);f.Pc=3077;continue;}
case 3077:{f.Push(JValue.R(null));f.Pc=3078;continue;}
case 3078:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearActiveTriggers","(Lforge/game/card/Card;Lforge/game/zone/Zone;)V","invokevirtual",3081);}
case 3081:{f.Push(f.Locals[0]);f.Pc=3082;continue;}
case 3082:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=3085;continue;}
case 3085:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",3088);}
case 3088:{f.Push(f.Locals[14]);f.Pc=3090;continue;}
case 3090:{f.Push(JValue.I(0));f.Pc=3091;continue;}
case 3091:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerActiveTrigger","(Lforge/game/card/Card;Z)V","invokevirtual",3094);}
case 3094:{f.Push(f.Locals[13]);f.Pc=3096;continue;}
case 3096:{f.Pc=f.Pop().Int!=0?3240:3099;continue;}
case 3099:{f.Push(f.Locals[14]);f.Pc=3101;continue;}
case 3101:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",3104);}
case 3104:{f.Locals[19]=f.Pop();f.Pc=3106;continue;}
case 3106:{f.Push(f.Locals[19]);f.Pc=3108;continue;}
case 3108:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=3111;continue;}
case 3111:{f.Push(f.Locals[15]);f.Pc=3113;continue;}
case 3113:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3118);}
case 3118:{f.StackOp("pop");f.Pc=3119;continue;}
case 3119:{f.Push(f.Locals[19]);f.Pc=3121;continue;}
case 3121:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=3124;continue;}
case 3124:{f.Push(f.Locals[5]);f.Pc=3126;continue;}
case 3126:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3131);}
case 3131:{f.StackOp("pop");f.Pc=3132;continue;}
case 3132:{f.Push(f.Locals[19]);f.Pc=3134;continue;}
case 3134:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"));f.Pc=3137;continue;}
case 3137:{f.Push(f.Locals[1]);f.Pc=3138;continue;}
case 3138:{f.Pc=f.Pop().Reference==null?3151:3141;continue;}
case 3141:{f.Push(f.Locals[1]);f.Pc=3142;continue;}
case 3142:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",3145);}
case 3145:{return rt.Call(f,"forge/game/zone/ZoneType","name","()Ljava/lang/String;","invokevirtual",3148);}
case 3148:{f.Pc=3152;continue;}
case 3151:{f.Push(JValue.R(null));f.Pc=3152;continue;}
case 3152:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3157);}
case 3157:{f.StackOp("pop");f.Pc=3158;continue;}
case 3158:{f.Push(f.Locals[19]);f.Pc=3160;continue;}
case 3160:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=3163;continue;}
case 3163:{f.Push(f.Locals[2]);f.Pc=3164;continue;}
case 3164:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",3167);}
case 3167:{return rt.Call(f,"forge/game/zone/ZoneType","name","()Ljava/lang/String;","invokevirtual",3170);}
case 3170:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3175);}
case 3175:{f.StackOp("pop");f.Pc=3176;continue;}
case 3176:{f.Push(f.Locals[19]);f.Pc=3178;continue;}
case 3178:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IndividualCostPaymentInstance","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IndividualCostPaymentInstance","Lforge/game/ability/AbilityKey;"));f.Pc=3181;continue;}
case 3181:{f.Push(f.Locals[0]);f.Pc=3182;continue;}
case 3182:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=3185;continue;}
case 3185:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=3188;continue;}
case 3188:{return rt.Call(f,"forge/game/zone/CostPaymentStack","peek","()Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",3191);}
case 3191:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3196);}
case 3196:{f.StackOp("pop");f.Pc=3197;continue;}
case 3197:{f.Push(f.Locals[19]);f.Pc=3199;continue;}
case 3199:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","MergedCards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","MergedCards","Lforge/game/ability/AbilityKey;"));f.Pc=3202;continue;}
case 3202:{f.Push(f.Locals[18]);f.Pc=3204;continue;}
case 3204:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3209);}
case 3209:{f.StackOp("pop");f.Pc=3210;continue;}
case 3210:{f.Push(f.Locals[6]);f.Pc=3212;continue;}
case 3212:{f.Pc=f.Pop().Reference==null?3224:3215;continue;}
case 3215:{f.Push(f.Locals[19]);f.Pc=3217;continue;}
case 3217:{f.Push(f.Locals[6]);f.Pc=3219;continue;}
case 3219:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",3224);}
case 3224:{f.Push(f.Locals[0]);f.Pc=3225;continue;}
case 3225:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=3228;continue;}
case 3228:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",3231);}
case 3231:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=3234;continue;}
case 3234:{f.Push(f.Locals[19]);f.Pc=3236;continue;}
case 3236:{f.Push(JValue.I(1));f.Pc=3237;continue;}
case 3237:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",3240);}
case 3240:{f.Push(f.Locals[8]);f.Pc=3242;continue;}
case 3242:{f.Pc=f.Pop().Int==0?3311:3245;continue;}
case 3245:{f.Push(f.Locals[1]);f.Pc=3246;continue;}
case 3246:{return rt.Call(f,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;","invokevirtual",3249);}
case 3249:{f.Push(f.Locals[2]);f.Pc=3250;continue;}
case 3250:{return rt.Call(f,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;","invokevirtual",3253);}
case 3253:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",3256);}
case 3256:{f.Pc=f.Pop().Int!=0?3311:3259;continue;}
case 3259:{f.Push(f.Locals[15]);f.Pc=3261;continue;}
case 3261:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",3264);}
case 3264:{f.Locals[19]=f.Pop();f.Pc=3266;continue;}
case 3266:{f.Push(f.Locals[19]);f.Pc=3268;continue;}
case 3268:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OriginalController","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OriginalController","Lforge/game/ability/AbilityKey;"));f.Pc=3271;continue;}
case 3271:{f.Push(f.Locals[1]);f.Pc=3272;continue;}
case 3272:{return rt.Call(f,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;","invokevirtual",3275);}
case 3275:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3280);}
case 3280:{f.StackOp("pop");f.Pc=3281;continue;}
case 3281:{f.Push(f.Locals[6]);f.Pc=3283;continue;}
case 3283:{f.Pc=f.Pop().Reference==null?3295:3286;continue;}
case 3286:{f.Push(f.Locals[19]);f.Pc=3288;continue;}
case 3288:{f.Push(f.Locals[6]);f.Pc=3290;continue;}
case 3290:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",3295);}
case 3295:{f.Push(f.Locals[0]);f.Pc=3296;continue;}
case 3296:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=3299;continue;}
case 3299:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",3302);}
case 3302:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesController","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesController","Lforge/game/trigger/TriggerType;"));f.Pc=3305;continue;}
case 3305:{f.Push(f.Locals[19]);f.Pc=3307;continue;}
case 3307:{f.Push(JValue.I(0));f.Pc=3308;continue;}
case 3308:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",3311);}
case 3311:{f.Push(f.Locals[1]);f.Pc=3312;continue;}
case 3312:{f.Pc=f.Pop().Reference!=null?3318:3315;continue;}
case 3315:{f.Push(f.Locals[14]);f.Pc=3317;continue;}
case 3317:{return JStep.Return(f.Pop());}
case 3318:{f.Push(f.Locals[10]);f.Pc=3320;continue;}
case 3320:{f.Pc=f.Pop().Int==0?3382:3323;continue;}
case 3323:{f.Push(f.Locals[8]);f.Pc=3325;continue;}
case 3325:{f.Pc=f.Pop().Int!=0?3343:3328;continue;}
case 3328:{f.Push(f.Locals[1]);f.Pc=3329;continue;}
case 3329:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=3332;continue;}
case 3332:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",3335);}
case 3335:{f.Pc=f.Pop().Int==0?3382:3338;continue;}
case 3338:{f.Push(f.Locals[7]);f.Pc=3340;continue;}
case 3340:{f.Pc=f.Pop().Int!=0?3382:3343;continue;}
case 3343:{f.Push(f.Locals[3]);f.Pc=3344;continue;}
case 3344:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",3347);}
case 3347:{f.Locals[19]=f.Pop();f.Pc=3349;continue;}
case 3349:{f.Push(f.Locals[19]);f.Pc=3351;continue;}
case 3351:{return rt.Call(f,"forge/game/card/Card","forceTurnFaceUp","()V","invokevirtual",3354);}
case 3354:{f.Push(f.Locals[0]);f.Pc=3355;continue;}
case 3355:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3358;continue;}
case 3358:{f.StackOp("dup");f.Pc=3359;continue;}
case 3359:{f.Push(f.Locals[19]);f.Pc=3361;continue;}
case 3361:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",3364);}
case 3364:{f.Push(f.Locals[19]);f.Pc=3366;continue;}
case 3366:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",3369);}
case 3369:{f.Push(JValue.I(1));f.Pc=3370;continue;}
case 3370:{f.Push(f.Locals[1]);f.Pc=3371;continue;}
case 3371:{return rt.Call(f,"forge/game/zone/Zone","toString","()Ljava/lang/String;","invokevirtual",3374);}
case 3374:{return rt.DynamicCall(f,"forge/game/GameAction:2038:3374:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",3379);}
case 3379:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",3382);}
case 3382:{f.Push(f.Locals[8]);f.Pc=3384;continue;}
case 3384:{f.Pc=f.Pop().Int==0?3574:3387;continue;}
case 3387:{f.Push(f.Locals[3]);f.Pc=3388;continue;}
case 3388:{return rt.Call(f,"forge/game/card/Card","isPaired","()Z","invokevirtual",3391);}
case 3391:{f.Pc=f.Pop().Int==0?3414:3394;continue;}
case 3394:{f.Push(f.Locals[3]);f.Pc=3395;continue;}
case 3395:{return rt.Call(f,"forge/game/card/Card","getPairedWith","()Lforge/game/card/Card;","invokevirtual",3398);}
case 3398:{f.Push(JValue.R(null));f.Pc=3399;continue;}
case 3399:{return rt.Call(f,"forge/game/card/Card","setPairedWith","(Lforge/game/card/Card;)V","invokevirtual",3402);}
case 3402:{f.Push(f.Locals[3]);f.Pc=3403;continue;}
case 3403:{return rt.Call(f,"forge/game/card/Card","isRealToken","()Z","invokevirtual",3406);}
case 3406:{f.Pc=f.Pop().Int!=0?3414:3409;continue;}
case 3409:{f.Push(f.Locals[3]);f.Pc=3410;continue;}
case 3410:{f.Push(JValue.R(null));f.Pc=3411;continue;}
case 3411:{return rt.Call(f,"forge/game/card/Card","setPairedWith","(Lforge/game/card/Card;)V","invokevirtual",3414);}
case 3414:{f.Push(f.Locals[3]);f.Pc=3415;continue;}
case 3415:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",3418);}
case 3418:{f.Pc=f.Pop().Reference==null?3646:3421;continue;}
case 3421:{f.Push(f.Locals[3]);f.Pc=3422;continue;}
case 3422:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",3425);}
case 3425:{f.Locals[19]=f.Pop();f.Pc=3427;continue;}
case 3427:{f.Push(f.Locals[1]);f.Pc=3428;continue;}
case 3428:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/PlayerZoneBattlefield"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3431;continue;}
case 3431:{f.Push(f.Locals[19]);f.Pc=3433;continue;}
case 3433:{return rt.Call(f,"forge/game/zone/PlayerZoneBattlefield","removeFromMelded","(Lforge/game/card/Card;)V","invokevirtual",3436);}
case 3436:{f.Push(f.Locals[4]);f.Pc=3438;continue;}
case 3438:{f.Locals[20]=f.Pop();f.Pc=3440;continue;}
case 3440:{f.Push(f.Locals[20]);f.Pc=3442;continue;}
case 3442:{f.Pc=f.Pop().Reference==null?3484:3445;continue;}
case 3445:{f.Push(f.Locals[2]);f.Pc=3446;continue;}
case 3446:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=3449;continue;}
case 3449:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",3452);}
case 3452:{f.Pc=f.Pop().Int!=0?3465:3455;continue;}
case 3455:{f.Push(f.Locals[2]);f.Pc=3456;continue;}
case 3456:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=3459;continue;}
case 3459:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",3462);}
case 3462:{f.Pc=f.Pop().Int==0?3484:3465;continue;}
case 3465:{f.Push(f.Locals[20]);f.Pc=3467;continue;}
case 3467:{f.Locals[21]=f.Pop();f.Pc=3469;continue;}
case 3469:{f.Push(f.Locals[20]);f.Pc=3471;continue;}
case 3471:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",3474);}
case 3474:{f.Push(JValue.I(1));f.Pc=3475;continue;}
case 3475:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=3476;continue;}
case 3476:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",3479);}
case 3479:{f.Locals[20]=f.Pop();f.Pc=3481;continue;}
case 3481:{f.Push(f.Locals[21]);f.Pc=3483;continue;}
case 3483:{f.StackOp("pop");f.Pc=3484;continue;}
case 3484:{f.Push(f.Locals[14]);f.Pc=3486;continue;}
case 3486:{return rt.Call(f,"forge/game/card/Card","isStickered","()Z","invokevirtual",3489);}
case 3489:{f.Pc=f.Pop().Int==0?3525:3492;continue;}
case 3492:{f.Push(f.Locals[3]);f.Pc=3493;continue;}
case 3493:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",3496);}
case 3496:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",3499);}
case 3499:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3502;continue;}
case 3502:{f.StackOp("dup");f.Pc=3503;continue;}
case 3503:{f.Push(f.Locals[14]);f.Pc=3505;continue;}
case 3505:{f.Push(f.Locals[19]);f.Pc=3507;continue;}
case 3507:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;","invokestatic",3510);}
case 3510:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",3513);}
case 3513:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardToKeepStickers","(Lforge/game/card/CardCollectionView;)Lforge/game/card/Card;","invokevirtual",3516);}
case 3516:{f.Push(f.Locals[19]);f.Pc=3518;continue;}
case 3518:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?3525:3521;continue;}
case 3521:{f.Push(JValue.I(1));f.Pc=3522;continue;}
case 3522:{f.Pc=3526;continue;}
case 3525:{f.Push(JValue.I(0));f.Pc=3526;continue;}
case 3526:{f.Locals[21]=f.Pop();f.Pc=3528;continue;}
case 3528:{f.Push(f.Locals[0]);f.Pc=3529;continue;}
case 3529:{f.Push(JValue.R(null));f.Pc=3530;continue;}
case 3530:{f.Push(f.Locals[2]);f.Pc=3531;continue;}
case 3531:{f.Push(f.Locals[19]);f.Pc=3533;continue;}
case 3533:{f.Push(f.Locals[4]);f.Pc=3535;continue;}
case 3535:{f.Push(f.Locals[5]);f.Pc=3537;continue;}
case 3537:{f.Push(f.Locals[6]);f.Pc=3539;continue;}
case 3539:{return rt.Call(f,"forge/game/GameAction","changeZone","(Lforge/game/zone/Zone;Lforge/game/zone/Zone;Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",3542);}
case 3542:{f.Locals[19]=f.Pop();f.Pc=3544;continue;}
case 3544:{f.Push(f.Locals[21]);f.Pc=3546;continue;}
case 3546:{f.Pc=f.Pop().Int==0?3561:3549;continue;}
case 3549:{f.Push(f.Locals[19]);f.Pc=3551;continue;}
case 3551:{f.Pc=f.Pop().Reference==null?3561:3554;continue;}
case 3554:{f.Push(f.Locals[19]);f.Pc=3556;continue;}
case 3556:{f.Push(f.Locals[14]);f.Pc=3558;continue;}
case 3558:{return rt.Call(f,"forge/game/card/Card","takeStickersFrom","(Lforge/game/card/Card;)V","invokevirtual",3561);}
case 3561:{f.Push(f.Locals[0]);f.Pc=3562;continue;}
case 3562:{f.Push(f.Locals[19]);f.Pc=3564;continue;}
case 3564:{f.Push(f.Locals[1]);f.Pc=3565;continue;}
case 3565:{f.Push(f.Locals[2]);f.Pc=3566;continue;}
case 3566:{f.Push(f.Locals[6]);f.Pc=3568;continue;}
case 3568:{return rt.Call(f,"forge/game/GameAction","storeChangesZoneAll","(Lforge/game/card/Card;Lforge/game/zone/Zone;Lforge/game/zone/Zone;Ljava/util/Map;)V","invokevirtual",3571);}
case 3571:{f.Pc=3646;continue;}
case 3574:{f.Push(f.Locals[7]);f.Pc=3576;continue;}
case 3576:{f.Pc=f.Pop().Int==0?3646:3579;continue;}
case 3579:{f.Push(f.Locals[0]);f.Pc=3580;continue;}
case 3580:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=3583;continue;}
case 3583:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",3586);}
case 3586:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",3589);}
case 3589:{f.Locals[19]=f.Pop();f.Pc=3591;continue;}
case 3591:{f.Push(f.Locals[19]);f.Pc=3593;continue;}
case 3593:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3598);}
case 3598:{f.Pc=f.Pop().Int==0?3646:3601;continue;}
case 3601:{f.Push(f.Locals[19]);f.Pc=3603;continue;}
case 3603:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3608);}
case 3608:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3611;continue;}
case 3611:{f.Locals[20]=f.Pop();f.Pc=3613;continue;}
case 3613:{f.Push(f.Locals[14]);f.Pc=3615;continue;}
case 3615:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",3618);}
case 3618:{f.Push(f.Locals[20]);f.Pc=3620;continue;}
case 3620:{return rt.Call(f,"forge/game/card/CardDamageHistory","setNotAttackedSinceLastUpkeepOf","(Lforge/game/player/Player;)V","invokevirtual",3623);}
case 3623:{f.Push(f.Locals[14]);f.Pc=3625;continue;}
case 3625:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",3628);}
case 3628:{f.Push(f.Locals[20]);f.Pc=3630;continue;}
case 3630:{return rt.Call(f,"forge/game/card/CardDamageHistory","setNotBlockedSinceLastUpkeepOf","(Lforge/game/player/Player;)V","invokevirtual",3633);}
case 3633:{f.Push(f.Locals[14]);f.Pc=3635;continue;}
case 3635:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",3638);}
case 3638:{f.Push(f.Locals[20]);f.Pc=3640;continue;}
case 3640:{return rt.Call(f,"forge/game/card/CardDamageHistory","setNotBeenBlockedSinceLastUpkeepOf","(Lforge/game/player/Player;)V","invokevirtual",3643);}
case 3643:{f.Pc=3591;continue;}
case 3646:{f.Push(f.Locals[2]);f.Pc=3647;continue;}
case 3647:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=3650;continue;}
case 3650:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",3653);}
case 3653:{f.Pc=f.Pop().Int!=0?3671:3656;continue;}
case 3656:{f.Push(f.Locals[2]);f.Pc=3657;continue;}
case 3657:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=3660;continue;}
case 3660:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",3663);}
case 3663:{f.Pc=f.Pop().Int!=0?3671:3666;continue;}
case 3666:{f.Push(f.Locals[14]);f.Pc=3668;continue;}
case 3668:{return rt.Call(f,"forge/game/card/Card","clearControllers","()V","invokevirtual",3671);}
case 3671:{f.Push(f.Locals[14]);f.Pc=3673;continue;}
case 3673:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2039(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?21:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("StaticEffect")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?21:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?23:21;continue;}
case 21:{f.Push(JValue.R(null));f.Pc=22;continue;}
case 22:{return JStep.Return(f.Pop());}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",27);}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("StaticEffectCheckSVar")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?91:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("StaticEffectSVarCompare")));f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("GE1")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("StaticEffectCheckSVar")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",58);}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",62);}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(2));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",71);}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",75);}
case 75:{f.Locals[6]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[6]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",86);}
case 86:{f.Pc=f.Pop().Int!=0?91:89;continue;}
case 89:{f.Push(JValue.R(null));f.Pc=90;continue;}
case 90:{return JStep.Return(f.Pop());}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("StaticEffectTimestamp")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasSVar","(Ljava/lang/String;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?119:101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("StaticEffectTimestamp")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",108);}
case 108:{return rt.Call(f,"java/lang/Long","parseLong","(Ljava/lang/String;)J","invokestatic",111);}
case 111:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",114);}
case 114:{f.Locals[4]=f.Pop();f.Pc=116;continue;}
case 116:{f.Pc=143;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",126);}
case 126:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",129);}
case 129:{f.Locals[4]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String("StaticEffectTimestamp")));f.Pc=135;continue;}
case 135:{f.Push(f.Locals[4]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",140);}
case 140:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",143);}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/spellability/SpellAbility","getId","()I","invokevirtual",147);}
case 147:{return rt.DynamicCall(f,"forge/game/GameAction:2039:147:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",152);}
case 152:{f.Locals[5]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[2]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",158);}
case 158:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",164);}
case 164:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",167);}
case 167:{f.Push(f.Locals[5]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/card/CardPredicates","nameEquals","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",172);}
case 172:{return rt.Call(f,"forge/util/IterableUtil","tryFind","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/util/Optional;","invokestatic",175);}
case 175:{f.Locals[6]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[6]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/util/Optional","isPresent","()Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int==0?208:185;continue;}
case 185:{f.Push(f.Locals[6]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/util/Optional","get","()Ljava/lang/Object;","invokevirtual",190);}
case 190:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=193;continue;}
case 193:{f.Locals[7]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[7]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[4]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/lang/Long","longValue","()J","invokevirtual",202);}
case 202:{return rt.Call(f,"forge/game/card/Card","setLayerTimestamp","(J)V","invokevirtual",205);}
case 205:{f.Pc=293;continue;}
case 208:{f.Push(f.Locals[2]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[3]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[2]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",214);}
case 214:{f.Push(f.Locals[5]);f.Pc=216;continue;}
case 216:{f.Push(f.Locals[3]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",220);}
case 220:{f.Push(f.Locals[4]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/lang/Long","longValue","()J","invokevirtual",225);}
case 225:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;J)Lforge/game/card/Card;","invokestatic",228);}
case 228:{f.Locals[7]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[7]);f.Pc=232;continue;}
case 232:{f.Push(JValue.I(0));f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/card/Card","setRenderForUI","(Z)V","invokevirtual",236);}
case 236:{f.Push(f.Locals[7]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[2]);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[2]);f.Pc=240;continue;}
case 240:{f.Push(JValue.R(rt.String("StaticEffect")));f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",246);}
case 246:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",249);}
case 249:{return rt.Call(f,"forge/game/card/Card","addStaticAbility","(Ljava/lang/String;)Lforge/game/staticability/StaticAbility;","invokevirtual",252);}
case 252:{f.Locals[8]=f.Pop();f.Pc=254;continue;}
case 254:{f.Push(f.Locals[8]);f.Pc=256;continue;}
case 256:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",262);}
case 262:{return rt.Call(f,"forge/game/staticability/StaticAbility","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",265);}
case 265:{f.Push(f.Locals[8]);f.Pc=267;continue;}
case 267:{f.Push(JValue.R(rt.String("AffectedZone")));f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("All")));f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/staticability/StaticAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",276);}
case 276:{f.StackOp("pop");f.Pc=277;continue;}
case 277:{f.Push(f.Locals[7]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",282);}
case 282:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",288);}
case 288:{f.Push(f.Locals[7]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/zone/PlayerZone","add","(Lforge/game/card/Card;)V","invokevirtual",293);}
case 293:{f.Push(f.Locals[7]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[1]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",299);}
case 299:{f.Push(f.Locals[1]);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[0]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[7]);f.Pc=303;continue;}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{return rt.DynamicCall(f,"forge/game/GameAction:2039:304:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/GameAction;Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/GameCommand;",309);}
case 309:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",312);}
case 312:{f.Push(f.Locals[0]);f.Pc=313;continue;}
case 313:{f.Push(JValue.I(0));f.Pc=314;continue;}
case 314:{f.Push(JValue.I(1));f.Pc=315;continue;}
case 315:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=318;continue;}
case 318:{f.StackOp("dup");f.Pc=319;continue;}
case 319:{f.Push(JValue.I(0));f.Pc=320;continue;}
case 320:{f.Push(f.Locals[1]);f.Pc=321;continue;}
case 321:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=322;continue;}
case 322:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","([Ljava/lang/Object;)Ljava/util/HashSet;","invokestatic",325);}
case 325:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=328;continue;}
case 328:{f.StackOp("dup");f.Pc=329;continue;}
case 329:{f.Push(f.Locals[1]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",333);}
case 333:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;)V","invokevirtual",336);}
case 336:{f.Push(f.Locals[7]);f.Pc=338;continue;}
case 338:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2040(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?22:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",9);}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/Card","hasRemembered","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int!=0?22:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/GameAction","exileEffect","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2041(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Reference==null?52:5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?52:18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardZoneTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Reference==null?42:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",39);}
case 39:{f.Pc=43;continue;}
case 42:{f.Push(JValue.R(null));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",47);}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2042(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","unAttachAllCards","(Lforge/game/card/Card;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","isAttachedToEntity","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?20:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/card/Card","unattachFromEntity","(Lforge/game/GameEntity;)V","invokevirtual",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2043(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",7);}
case 7:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2044(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2045(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2046(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/zone/ZoneType","ordinal","()I","invokevirtual",7);}
case 7:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8;continue;}
case 8:{switch(f.Pop().Int){case 1:f.Pc=68;break;case 2:f.Pc=80;break;case 3:f.Pc=93;break;case 4:f.Pc=109;break;case 5:f.Pc=121;break;case 6:f.Pc=147;break;case 7:f.Pc=159;break;case 8:f.Pc=159;break;case 9:f.Pc=159;break;case 10:f.Pc=159;break;case 11:f.Pc=173;break;default:f.Pc=185;break;}continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/GameAction","moveToHand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",77);}
case 77:{f.Pc=200;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[5]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",90);}
case 90:{f.Pc=200;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",99);}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",106);}
case 106:{f.Pc=200;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[5]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/GameAction","moveToGraveyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",118);}
case 118:{f.Pc=200;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[4]);f.Pc=124;continue;}
case 124:{f.Push(JValue.I(1));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/Card","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int!=0?135:131;continue;}
case 131:{f.Push(JValue.R(null));f.Pc=132;continue;}
case 132:{f.Pc=200;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[2]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[4]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[5]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",144);}
case 144:{f.Pc=200;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[4]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[5]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/GameAction","moveToStack","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",156);}
case 156:{f.Pc=200;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[1]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[3]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[4]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[5]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/GameAction","moveToVariantDeck","(Lforge/game/card/Card;Lforge/game/zone/ZoneType;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",170);}
case 170:{f.Pc=200;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[2]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[4]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[5]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/GameAction","moveToJunkyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",182);}
case 182:{f.Pc=200;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[2]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",190);}
case 190:{f.Push(f.Locals[1]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",194);}
case 194:{f.Push(f.Locals[2]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[4]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",200);}
case 200:{return JStep.Return(f.Pop());}
case 201:{f.Locals[6]=f.Pop();f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.String("GameAction:moveTo: Exception occurred")));f.Pc=206;continue;}
case 206:{f.Locals[7]=f.Pop();f.Pc=208;continue;}
case 208:{if(!rt.EnsureInitialized(f,"io/sentry/Breadcrumb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("io/sentry/Breadcrumb")));f.Pc=211;continue;}
case 211:{f.StackOp("dup");f.Pc=212;continue;}
case 212:{f.Push(f.Locals[7]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"io/sentry/Breadcrumb","<init>","(Ljava/lang/String;)V","invokespecial",217);}
case 217:{f.Locals[8]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[8]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String("Card")));f.Pc=224;continue;}
case 224:{f.Push(f.Locals[2]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",228);}
case 228:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",231);}
case 231:{f.Push(f.Locals[8]);f.Pc=233;continue;}
case 233:{f.Push(JValue.R(rt.String("SA")));f.Pc=236;continue;}
case 236:{f.Push(f.Locals[4]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/spellability/SpellAbility","toString","()Ljava/lang/String;","invokevirtual",241);}
case 241:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",244);}
case 244:{f.Push(f.Locals[8]);f.Pc=246;continue;}
case 246:{f.Push(JValue.R(rt.String("ZoneType")));f.Pc=249;continue;}
case 249:{f.Push(f.Locals[1]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/zone/ZoneType","name","()Ljava/lang/String;","invokevirtual",253);}
case 253:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",256);}
case 256:{f.Push(f.Locals[8]);f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String("Player")));f.Pc=261;continue;}
case 261:{f.Push(f.Locals[2]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",265);}
case 265:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",268);}
case 268:{f.Push(f.Locals[8]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"io/sentry/Sentry","addBreadcrumb","(Lio/sentry/Breadcrumb;)V","invokestatic",273);}
case 273:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=276;continue;}
case 276:{f.StackOp("dup");f.Pc=277;continue;}
case 277:{f.Push(f.Locals[2]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",281);}
case 281:{f.Push(f.Locals[1]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/zone/ZoneType","name","()Ljava/lang/String;","invokevirtual",285);}
case 285:{return rt.DynamicCall(f,"forge/game/GameAction:2046:285:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",290);}
case 290:{f.Push(f.Locals[6]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",295);}
case 295:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2047(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",8);}
case 8:{f.Locals[6]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Subgame","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Subgame","Lforge/game/zone/ZoneType;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?40:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?34:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","isMerged","()Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?40:34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","moveMergedToSubgame","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",40);}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[6]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/GameAction","changeZone","(Lforge/game/zone/Zone;Lforge/game/zone/Zone;Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",53);}
case 53:{f.Locals[2]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",63);}
case 63:{f.Locals[7]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[7]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",72);}
case 72:{f.Pc=f.Pop().Int==0?297:75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",82);}
case 82:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=85;continue;}
case 85:{f.Locals[8]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[8]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","()Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int!=0?98:95;continue;}
case 95:{f.Pc=65;continue;}
case 98:{f.Push(f.Locals[8]);f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBlockBy","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantBlockBy","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?217:109;continue;}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String("ValidAttacker")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int==0?65:120;continue;}
case 120:{f.Push(f.Locals[8]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("ValidBlocker")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?151:131;continue;}
case 131:{f.Push(f.Locals[8]);f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("ValidBlocker")));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",139);}
case 139:{f.Push(JValue.R(rt.String("Creature.Self")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int==0?151:148;continue;}
case 148:{f.Pc=65;continue;}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=155;continue;}
case 155:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",161);}
case 161:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"));f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",167);}
case 167:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",172);}
case 172:{f.Locals[9]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[9]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",181);}
case 181:{f.Pc=f.Pop().Int==0?217:184;continue;}
case 184:{f.Push(f.Locals[9]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",191);}
case 191:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=194;continue;}
case 194:{f.Locals[10]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[8]);f.Pc=198;continue;}
case 198:{f.Push(JValue.R(rt.String("ValidAttacker")));f.Pc=201;continue;}
case 201:{f.Push(f.Locals[10]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",206);}
case 206:{f.Pc=f.Pop().Int==0?214:209;continue;}
case 209:{f.Push(f.Locals[10]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/card/Card","updateAbilityTextForView","()V","invokevirtual",214);}
case 214:{f.Pc=174;continue;}
case 217:{f.Push(f.Locals[8]);f.Pc=219;continue;}
case 219:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MinMaxBlocker","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","MinMaxBlocker","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",225);}
case 225:{f.Pc=f.Pop().Int==0?294:228;continue;}
case 228:{f.Push(f.Locals[0]);f.Pc=229;continue;}
case 229:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=232;continue;}
case 232:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",238);}
case 238:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"));f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",244);}
case 244:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",249);}
case 249:{f.Locals[9]=f.Pop();f.Pc=251;continue;}
case 251:{f.Push(f.Locals[9]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",258);}
case 258:{f.Pc=f.Pop().Int==0?294:261;continue;}
case 261:{f.Push(f.Locals[9]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",268);}
case 268:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=271;continue;}
case 271:{f.Locals[10]=f.Pop();f.Pc=273;continue;}
case 273:{f.Push(f.Locals[8]);f.Pc=275;continue;}
case 275:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=278;continue;}
case 278:{f.Push(f.Locals[10]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",283);}
case 283:{f.Pc=f.Pop().Int==0?291:286;continue;}
case 286:{f.Push(f.Locals[10]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/card/Card","updateAbilityTextForView","()V","invokevirtual",291);}
case 291:{f.Pc=251;continue;}
case 294:{f.Pc=65;continue;}
case 297:{f.Push(f.Locals[6]);f.Pc=299;continue;}
case 299:{f.Pc=f.Pop().Reference==null?389:302;continue;}
case 302:{f.Push(f.Locals[6]);f.Pc=304;continue;}
case 304:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",310);}
case 310:{f.Pc=f.Pop().Int==0?389:313;continue;}
case 313:{f.Push(f.Locals[0]);f.Pc=314;continue;}
case 314:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/Game","getMaingame","()Lforge/game/Game;","invokevirtual",320);}
case 320:{f.Pc=f.Pop().Reference==null?389:323;continue;}
case 323:{f.Push(f.Locals[2]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",327);}
case 327:{f.Push(f.Locals[2]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/player/Player","getMappingMaingameCard","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",331);}
case 331:{f.Locals[7]=f.Pop();f.Pc=333;continue;}
case 333:{f.Push(f.Locals[7]);f.Pc=335;continue;}
case 335:{f.Pc=f.Pop().Reference==null?389:338;continue;}
case 338:{f.Push(f.Locals[7]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",343);}
case 343:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",349);}
case 349:{f.Pc=f.Pop().Int==0?367:352;continue;}
case 352:{f.Push(f.Locals[0]);f.Pc=353;continue;}
case 353:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=356;continue;}
case 356:{return rt.Call(f,"forge/game/Game","getMaingame","()Lforge/game/Game;","invokevirtual",359);}
case 359:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",362);}
case 362:{f.Push(f.Locals[7]);f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/zone/MagicStack","remove","(Lforge/game/card/Card;)V","invokevirtual",367);}
case 367:{f.Push(f.Locals[0]);f.Pc=368;continue;}
case 368:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/Game","getMaingame","()Lforge/game/Game;","invokevirtual",374);}
case 374:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",377);}
case 377:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Subgame","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Subgame","Lforge/game/zone/ZoneType;"));f.Pc=380;continue;}
case 380:{f.Push(f.Locals[7]);f.Pc=382;continue;}
case 382:{f.Push(JValue.R(null));f.Pc=383;continue;}
case 383:{f.Push(f.Locals[5]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",388);}
case 388:{f.StackOp("pop");f.Pc=389;continue;}
case 389:{f.Push(f.Locals[2]);f.Pc=390;continue;}
case 390:{return rt.Call(f,"forge/game/card/Card","isRealCommander","()Z","invokevirtual",393);}
case 393:{f.Pc=f.Pop().Int==0?401:396;continue;}
case 396:{f.Push(f.Locals[2]);f.Pc=397;continue;}
case 397:{f.Push(JValue.I(1));f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/card/Card","setMoveToCommandZone","(Z)V","invokevirtual",401);}
case 401:{f.Push(f.Locals[2]);f.Pc=402;continue;}
case 402:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2048(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",15);}
case 15:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",32);}
case 32:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/GameAction","moveToStack","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",45);}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2049(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2050(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",6);}
case 6:{return rt.Call(f,"forge/game/GameAction","moveToGraveyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2051(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",10);}
case 10:{f.Locals[4]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2052(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",6);}
case 6:{return rt.Call(f,"forge/game/GameAction","moveToHand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2053(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",10);}
case 10:{f.Locals[4]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2054(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",6);}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2055(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[5]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2056(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",6);}
case 6:{return rt.Call(f,"forge/game/GameAction","moveToBottomOfLibrary","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2057(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(-1));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2058(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",6);}
case 6:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2059(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2060(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2061(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",10);}
case 10:{f.Locals[5]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(-1));f.Pc=14;continue;}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?26:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",23);}
case 23:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?32:26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",31);}
case 31:{f.Locals[2]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",41);}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",48);}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/GameAction","changeZone","(Lforge/game/zone/Zone;Lforge/game/zone/Zone;Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",54);}
case 54:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2062(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",8);}
case 8:{f.Locals[6]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(-1));f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?24:15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[6]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",21);}
case 21:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?30:24;continue;}
case 24:{f.Push(f.Locals[6]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",29);}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",39);}
case 39:{f.Push(f.Locals[6]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",46);}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/GameAction","changeZone","(Lforge/game/zone/Zone;Lforge/game/zone/Zone;Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",53);}
case 53:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2063(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Junkyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Junkyard","Lforge/game/zone/ZoneType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",10);}
case 10:{f.Locals[4]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2064(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",13);}
case 13:{f.Locals[5]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[5]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?54:25;continue;}
case 25:{f.Push(f.Locals[5]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[6]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Pc=15;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2065(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[5]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",27);}
case 27:{f.Locals[6]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?39:36;continue;}
case 36:{f.Push(f.Locals[6]);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",43);}
case 43:{f.Locals[7]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[7]);f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{f.Pc=f.Pop().Reference==null?81:62;continue;}
case 62:{f.Push(f.Locals[7]);f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",72);}
case 72:{return rt.Call(f,"forge/game/zone/ZoneType","name","()Ljava/lang/String;","invokevirtual",75);}
case 75:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",80);}
case 80:{f.StackOp("pop");f.Pc=81;continue;}
case 81:{f.Push(f.Locals[3]);f.Pc=82;continue;}
case 82:{f.Pc=f.Pop().Reference==null?93:85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",93);}
case 93:{f.Push(f.Locals[7]);f.Pc=95;continue;}
case 95:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CostStack","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CostStack","Lforge/game/ability/AbilityKey;"));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=102;continue;}
case 102:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{f.Push(f.Locals[7]);f.Pc=113;continue;}
case 113:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IndividualCostPaymentInstance","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IndividualCostPaymentInstance","Lforge/game/ability/AbilityKey;"));f.Pc=116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/zone/CostPaymentStack","peek","()Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",126);}
case 126:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",131);}
case 131:{f.StackOp("pop");f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",139);}
case 139:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Exiled","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Exiled","Lforge/game/trigger/TriggerType;"));f.Pc=142;continue;}
case 142:{f.Push(f.Locals[7]);f.Pc=144;continue;}
case 144:{f.Push(JValue.I(0));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",148);}
case 148:{f.Push(f.Locals[6]);f.Pc=150;continue;}
case 150:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2066(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2067(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",7);}
case 7:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/trigger/TriggerHandler","suppressMode","(Lforge/game/trigger/TriggerType;)V","invokevirtual",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(null));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",35);}
case 35:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearSuppression","(Lforge/game/trigger/TriggerType;)V","invokevirtual",41);}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2068(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?21:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/zone/MagicStack","remove","(Lforge/game/card/Card;)V","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Reference==null?63:30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/zone/Zone","remove","(Lforge/game/card/Card;)V","invokevirtual",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",40);}
case 40:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/game/card/Card","setZone","(Lforge/game/zone/Zone;)V","invokevirtual",49);}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?63:59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/Card","runLeavesPlayCommands","()V","invokevirtual",63);}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{f.Pc=f.Pop().Int!=0?260:67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",74);}
case 74:{f.Locals[4]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/card/CardCollectionView","indexOf","(Ljava/lang/Object;)I","invokeinterface",84);}
case 84:{f.Locals[5]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(JValue.R(null));f.Pc=87;continue;}
case 87:{f.Locals[6]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[5]);f.Pc=91;continue;}
case 91:{f.Push(JValue.I(-1));f.Pc=92;continue;}
case 92:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?109:95;continue;}
case 95:{f.Push(f.Locals[4]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[5]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[6]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[6]);f.Pc=111;continue;}
case 111:{f.Pc=f.Pop().Reference!=null?120:114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",118);}
case 118:{f.Locals[6]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=124;continue;}
case 124:{f.Push(f.Locals[6]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/Game","addChangeZoneLKIInfo","(Lforge/game/card/Card;)V","invokevirtual",129);}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int==0?260:137;continue;}
case 137:{f.Push(f.Locals[6]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",142);}
case 142:{f.Pc=f.Pop().Int!=0?260:145;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",152);}
case 152:{f.Pc=f.Pop().Reference==null?179:155;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",162);}
case 162:{f.Push(f.Locals[6]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/combat/Combat","saveLKI","(Lforge/game/card/Card;)Lforge/game/combat/CombatLki;","invokevirtual",167);}
case 167:{f.StackOp("pop");f.Pc=168;continue;}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",175);}
case 175:{f.Push(f.Locals[1]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/combat/Combat","removeFromCombat","(Lforge/game/card/Card;)V","invokevirtual",179);}
case 179:{f.Push(f.Locals[6]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",184);}
case 184:{f.Push(f.Locals[6]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",189);}
case 189:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",192);}
case 192:{f.Pc=f.Pop().Int!=0?207:195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",202);}
case 202:{f.Push(f.Locals[6]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerActiveLTBTrigger","(Lforge/game/card/Card;)V","invokevirtual",207);}
case 207:{f.Push(f.Locals[1]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",211);}
case 211:{f.Locals[7]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[7]);f.Pc=215;continue;}
case 215:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=218;continue;}
case 218:{f.Push(f.Locals[6]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",225);}
case 225:{f.StackOp("pop");f.Pc=226;continue;}
case 226:{f.Push(f.Locals[7]);f.Pc=228;continue;}
case 228:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"));f.Pc=231;continue;}
case 231:{f.Push(f.Locals[3]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",235);}
case 235:{return rt.Call(f,"forge/game/zone/ZoneType","name","()Ljava/lang/String;","invokevirtual",238);}
case 238:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",243);}
case 243:{f.StackOp("pop");f.Pc=244;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",251);}
case 251:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=254;continue;}
case 254:{f.Push(f.Locals[7]);f.Pc=256;continue;}
case 256:{f.Push(JValue.I(0));f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",260);}
case 260:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2069(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return rt.DynamicCall(f,"forge/game/GameAction:2069:7:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",12);}
case 12:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference==null?38:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?39:38;continue;}
case 38:{return JStep.ReturnVoid;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;","invokevirtual",43);}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",48);}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Reference==null?68:54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Reference==null?68:59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?69:68;continue;}
case 68:{return JStep.ReturnVoid;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",75);}
case 75:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",78);}
case 78:{f.Locals[5]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{f.Pc=f.Pop().Reference==null?94:85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?95:94;continue;}
case 94:{return JStep.ReturnVoid;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/Card","isPaired","()Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int==0?124:102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","getPairedWith","()Lforge/game/card/Card;","invokevirtual",106);}
case 106:{f.Locals[6]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(null));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/card/Card","setPairedWith","(Lforge/game/card/Card;)V","invokevirtual",113);}
case 113:{f.Push(f.Locals[6]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(null));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/Card","setPairedWith","(Lforge/game/card/Card;)V","invokevirtual",119);}
case 119:{f.Push(f.Locals[6]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",124);}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/Card","runChangeControllerCommands","()V","invokevirtual",128);}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",135);}
case 135:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/trigger/TriggerHandler","suppressMode","(Lforge/game/trigger/TriggerType;)V","invokevirtual",141);}
case 141:{f.Push(f.Locals[2]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/zone/Zone","remove","(Lforge/game/card/Card;)V","invokevirtual",146);}
case 146:{f.Push(f.Locals[5]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/zone/PlayerZone","add","(Lforge/game/card/Card;)V","invokevirtual",152);}
case 152:{f.Push(f.Locals[0]);f.Pc=153;continue;}
case 153:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",159);}
case 159:{return rt.Call(f,"forge/game/phase/PhaseHandler","inCombat","()Z","invokevirtual",162);}
case 162:{f.Pc=f.Pop().Int==0?176:165;continue;}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",172);}
case 172:{f.Push(f.Locals[1]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/combat/Combat","removeFromCombat","(Lforge/game/card/Card;)V","invokevirtual",176);}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{f.Push(JValue.I(1));f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/card/Card","setCameUnderControlSinceLastUpkeep","(Z)V","invokevirtual",181);}
case 181:{f.Push(f.Locals[1]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/card/Card","handleChangedControllerSprocketReset","()V","invokevirtual",185);}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",189);}
case 189:{f.Locals[6]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[6]);f.Pc=193;continue;}
case 193:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OriginalController","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OriginalController","Lforge/game/ability/AbilityKey;"));f.Pc=196;continue;}
case 196:{f.Push(f.Locals[3]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",202);}
case 202:{f.StackOp("pop");f.Pc=203;continue;}
case 203:{f.Push(f.Locals[0]);f.Pc=204;continue;}
case 204:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",210);}
case 210:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesController","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesController","Lforge/game/trigger/TriggerType;"));f.Pc=213;continue;}
case 213:{f.Push(f.Locals[6]);f.Pc=215;continue;}
case 215:{f.Push(JValue.I(0));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",219);}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",226);}
case 226:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearSuppression","(Lforge/game/trigger/TriggerType;)V","invokevirtual",232);}
case 232:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2070(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameAction","holdCheckingStaticAbilities","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2071(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","holdCheckingStaticAbilities","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2072(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?139:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",46);}
case 46:{f.Locals[5]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?136:58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[6]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[6]);f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int!=0?84:81;continue;}
case 81:{f.Pc=48;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{f.Pc=f.Pop().Reference==null?105:88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/staticability/StaticAbility","getLayers","()Ljava/util/Set;","invokevirtual",93);}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",99);}
case 99:{f.Pc=f.Pop().Int!=0?105:102;continue;}
case 102:{f.Pc=48;continue;}
case 105:{f.Push(f.Locals[6]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("AffectedZone")));f.Pc=110;continue;}
case 110:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/zone/ZoneType","toString","()Ljava/lang/String;","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",119);}
case 119:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",122);}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",128);}
case 128:{f.Pc=f.Pop().Int==0?133:131;continue;}
case 131:{f.Push(JValue.I(1));f.Pc=132;continue;}
case 132:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 133:{f.Pc=48;continue;}
case 136:{f.Pc=16;continue;}
case 139:{f.Push(JValue.I(0));f.Pc=140;continue;}
case 140:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2073(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(Z)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2074(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",5);}
case 5:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2075(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;Ljava/util/Set;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2076(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameAction","isCheckingStaticAbilitiesOnHold","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?19:18;continue;}
case 18:{return JStep.ReturnVoid;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/trackable/Tracker","freeze","()V","invokevirtual",29);}
case 29:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",32);}
case 32:{f.Locals[5]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/Game","getStaticEffects","()Lforge/game/StaticEffects;","invokevirtual",41);}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[5]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/StaticEffects","clearStaticEffects","(Ljava/util/Set;Ljava/util/Map;)V","invokevirtual",47);}
case 47:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=50;continue;}
case 50:{f.StackOp("dup");f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",54);}
case 54:{f.Locals[6]=f.Pop();f.Pc=56;continue;}
case 56:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=59;continue;}
case 59:{f.StackOp("dup");f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",63);}
case 63:{f.Locals[7]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(JValue.R(null));f.Pc=66;continue;}
case 66:{f.Locals[8]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",74);}
case 74:{f.Pc=f.Pop().Int==0?82:77;continue;}
case 77:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",80);}
case 80:{f.Locals[8]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{return rt.DynamicCall(f,"forge/game/GameAction:2076:91:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CardCollectionView;Lforge/util/collect/FCollection;Lforge/game/card/CardCollection;)Lforge/util/Visitor;",96);}
case 96:{f.Push(JValue.I(1));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/Game","forEachCardInGame","(Lforge/util/Visitor;Z)V","invokevirtual",100);}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/game/GameAction","effectOrder","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction","effectOrder","Ljava/util/Comparator;"));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/util/collect/FCollection","sort","(Ljava/util/Comparator;)V","invokevirtual",108);}
case 108:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",111);}
case 111:{f.Locals[9]=f.Pop();f.Pc=113;continue;}
case 113:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTINUOUS_LAYERS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CONTINUOUS_LAYERS","Lcom/google/common/collect/ImmutableList;"));f.Pc=116;continue;}
case 116:{return rt.Call(f,"com/google/common/collect/ImmutableList","iterator","()Lcom/google/common/collect/UnmodifiableIterator;","invokevirtual",119);}
case 119:{f.Locals[10]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[10]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",128);}
case 128:{f.Pc=f.Pop().Int==0?619:131;continue;}
case 131:{f.Push(f.Locals[10]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",138);}
case 138:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbilityLayer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=141;continue;}
case 141:{f.Locals[11]=f.Pop();f.Pc=143;continue;}
case 143:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",146);}
case 146:{f.Locals[12]=f.Pop();f.Pc=148;continue;}
case 148:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",151);}
case 151:{f.Locals[13]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[6]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",158);}
case 158:{f.Locals[14]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[14]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",167);}
case 167:{f.Pc=f.Pop().Int==0?210:170;continue;}
case 170:{f.Push(f.Locals[14]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",177);}
case 177:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=180;continue;}
case 180:{f.Locals[15]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[15]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/staticability/StaticAbility","getLayers","()Ljava/util/Set;","invokevirtual",187);}
case 187:{f.Push(f.Locals[11]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",194);}
case 194:{f.Pc=f.Pop().Int==0?207:197;continue;}
case 197:{f.Push(f.Locals[13]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[15]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",206);}
case 206:{f.StackOp("pop");f.Pc=207;continue;}
case 207:{f.Pc=160;continue;}
case 210:{f.Push(f.Locals[13]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",217);}
case 217:{f.Pc=f.Pop().Int!=0?564:220;continue;}
case 220:{f.Push(f.Locals[13]);f.Pc=222;continue;}
case 222:{f.Push(JValue.I(0));f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",228);}
case 228:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=231;continue;}
case 231:{f.Locals[14]=f.Pop();f.Pc=233;continue;}
case 233:{f.Push(f.Locals[14]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/staticability/StaticAbility","isCharacteristicDefining","()Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int!=0?256:241;continue;}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[11]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[13]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[3]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[9]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[8]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/GameAction","findStaticAbilityToApply","(Lforge/game/staticability/StaticAbilityLayer;Ljava/util/List;Lforge/game/card/CardCollectionView;Ljava/util/Map;Lcom/google/common/collect/Table;)Lforge/game/staticability/StaticAbility;","invokevirtual",254);}
case 254:{f.Locals[14]=f.Pop();f.Pc=256;continue;}
case 256:{f.Push(f.Locals[13]);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[14]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",265);}
case 265:{f.StackOp("pop");f.Pc=266;continue;}
case 266:{f.Push(f.Locals[9]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[14]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",275);}
case 275:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=278;continue;}
case 278:{f.Locals[15]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[15]);f.Pc=282;continue;}
case 282:{f.Pc=f.Pop().Reference!=null?341:285;continue;}
case 285:{f.Push(f.Locals[14]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[11]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[4]);f.Pc=291;continue;}
case 291:{f.Pc=f.Pop().Reference==null?315:294;continue;}
case 294:{f.Push(f.Locals[4]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[14]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",301);}
case 301:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",306);}
case 306:{f.Pc=f.Pop().Int==0?315:309;continue;}
case 309:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=312;continue;}
case 312:{f.Pc=316;continue;}
case 315:{f.Push(f.Locals[3]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/staticability/StaticAbility","applyContinuousAbilityBefore","(Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;","invokevirtual",319);}
case 319:{f.Locals[16]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[16]);f.Pc=323;continue;}
case 323:{f.Pc=f.Pop().Reference==null?355:326;continue;}
case 326:{f.Push(f.Locals[9]);f.Pc=328;continue;}
case 328:{f.Push(f.Locals[14]);f.Pc=330;continue;}
case 330:{f.Push(f.Locals[16]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",337);}
case 337:{f.StackOp("pop");f.Pc=338;continue;}
case 338:{f.Pc=355;continue;}
case 341:{f.Push(f.Locals[15]);f.Pc=343;continue;}
case 343:{f.Locals[16]=f.Pop();f.Pc=345;continue;}
case 345:{f.Push(f.Locals[14]);f.Pc=347;continue;}
case 347:{f.Push(f.Locals[11]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[15]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/staticability/StaticAbility","applyContinuousAbility","(Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;","invokevirtual",354);}
case 354:{f.StackOp("pop");f.Pc=355;continue;}
case 355:{f.Push(f.Locals[16]);f.Pc=357;continue;}
case 357:{f.Pc=f.Pop().Reference==null?561:360;continue;}
case 360:{f.Push(f.Locals[5]);f.Pc=362;continue;}
case 362:{f.Push(f.Locals[11]);f.Pc=364;continue;}
case 364:{return rt.DynamicCall(f,"forge/game/GameAction:2076:364:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",369);}
case 369:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",374);}
case 374:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=377;continue;}
case 377:{f.Push(f.Locals[16]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",384);}
case 384:{f.StackOp("pop");f.Pc=385;continue;}
case 385:{f.Push(f.Locals[16]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",392);}
case 392:{f.Locals[17]=f.Pop();f.Pc=394;continue;}
case 394:{f.Push(f.Locals[17]);f.Pc=396;continue;}
case 396:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",401);}
case 401:{f.Pc=f.Pop().Int==0?561:404;continue;}
case 404:{f.Push(f.Locals[17]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",411);}
case 411:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=414;continue;}
case 414:{f.Locals[18]=f.Pop();f.Pc=416;continue;}
case 416:{f.Push(f.Locals[18]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",421);}
case 421:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",426);}
case 426:{f.Locals[19]=f.Pop();f.Pc=428;continue;}
case 428:{f.Push(f.Locals[19]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",435);}
case 435:{f.Pc=f.Pop().Int==0?558:438;continue;}
case 438:{f.Push(f.Locals[19]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",445);}
case 445:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=448;continue;}
case 448:{f.Locals[20]=f.Pop();f.Pc=450;continue;}
case 450:{f.Push(f.Locals[6]);f.Pc=452;continue;}
case 452:{f.Push(f.Locals[20]);f.Pc=454;continue;}
case 454:{return rt.Call(f,"forge/util/collect/FCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",457);}
case 457:{f.Pc=f.Pop().Int!=0?555:460;continue;}
case 460:{f.Push(f.Locals[20]);f.Pc=462;continue;}
case 462:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=465;continue;}
case 465:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",468);}
case 468:{f.Pc=f.Pop().Int==0?555:471;continue;}
case 471:{f.Push(f.Locals[20]);f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/staticability/StaticAbility","zonesCheck","()Z","invokevirtual",476);}
case 476:{f.Pc=f.Pop().Int==0?555:479;continue;}
case 479:{f.Push(f.Locals[12]);f.Pc=481;continue;}
case 481:{f.Push(f.Locals[20]);f.Pc=483;continue;}
case 483:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",488);}
case 488:{f.StackOp("pop");f.Pc=489;continue;}
case 489:{f.Push(f.Locals[20]);f.Pc=491;continue;}
case 491:{f.Push(f.Locals[11]);f.Pc=493;continue;}
case 493:{f.Push(f.Locals[4]);f.Pc=495;continue;}
case 495:{f.Pc=f.Pop().Reference==null?519:498;continue;}
case 498:{f.Push(f.Locals[4]);f.Pc=500;continue;}
case 500:{f.Push(f.Locals[20]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",505);}
case 505:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",510);}
case 510:{f.Pc=f.Pop().Int==0?519:513;continue;}
case 513:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=516;continue;}
case 516:{f.Pc=520;continue;}
case 519:{f.Push(f.Locals[3]);f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/game/staticability/StaticAbility","applyContinuousAbilityBefore","(Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;","invokevirtual",523);}
case 523:{f.Locals[21]=f.Pop();f.Pc=525;continue;}
case 525:{f.Push(f.Locals[21]);f.Pc=527;continue;}
case 527:{f.Pc=f.Pop().Reference==null?555:530;continue;}
case 530:{f.Push(f.Locals[5]);f.Pc=532;continue;}
case 532:{f.Push(f.Locals[11]);f.Pc=534;continue;}
case 534:{return rt.DynamicCall(f,"forge/game/GameAction:2076:534:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",539);}
case 539:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",544);}
case 544:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=547;continue;}
case 547:{f.Push(f.Locals[21]);f.Pc=549;continue;}
case 549:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",554);}
case 554:{f.StackOp("pop");f.Pc=555;continue;}
case 555:{f.Pc=428;continue;}
case 558:{f.Pc=394;continue;}
case 561:{f.Pc=210;continue;}
case 564:{f.Push(f.Locals[6]);f.Pc=566;continue;}
case 566:{f.Push(f.Locals[12]);f.Pc=568;continue;}
case 568:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",571);}
case 571:{f.StackOp("pop");f.Pc=572;continue;}
case 572:{f.Push(f.Locals[0]);f.Pc=573;continue;}
case 573:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=576;continue;}
case 576:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",579);}
case 579:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",582);}
case 582:{f.Locals[14]=f.Pop();f.Pc=584;continue;}
case 584:{f.Push(f.Locals[14]);f.Pc=586;continue;}
case 586:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",591);}
case 591:{f.Pc=f.Pop().Int==0?616:594;continue;}
case 594:{f.Push(f.Locals[14]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",601);}
case 601:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=604;continue;}
case 604:{f.Locals[15]=f.Pop();f.Pc=606;continue;}
case 606:{f.Push(f.Locals[15]);f.Pc=608;continue;}
case 608:{f.Push(f.Locals[11]);f.Pc=610;continue;}
case 610:{return rt.Call(f,"forge/game/player/Player","afterStaticAbilityLayer","(Lforge/game/staticability/StaticAbilityLayer;)V","invokevirtual",613);}
case 613:{f.Pc=584;continue;}
case 616:{f.Pc=121;continue;}
case 619:{f.Push(f.Locals[9]);f.Pc=621;continue;}
case 621:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",626);}
case 626:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",631);}
case 631:{f.Locals[10]=f.Pop();f.Pc=633;continue;}
case 633:{f.Push(f.Locals[10]);f.Pc=635;continue;}
case 635:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",640);}
case 640:{f.Pc=f.Pop().Int==0?681:643;continue;}
case 643:{f.Push(f.Locals[10]);f.Pc=645;continue;}
case 645:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",650);}
case 650:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=653;continue;}
case 653:{f.Locals[11]=f.Pop();f.Pc=655;continue;}
case 655:{f.Push(f.Locals[11]);f.Pc=657;continue;}
case 657:{f.Pc=f.Pop().Reference==null?678:660;continue;}
case 660:{f.Push(f.Locals[11]);f.Pc=662;continue;}
case 662:{f.Push(f.Locals[2]);f.Pc=663;continue;}
case 663:{f.StackOp("dup");f.Pc=664;continue;}
case 664:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",667);}
case 667:{f.StackOp("pop");f.Pc=668;continue;}
case 668:{return rt.DynamicCall(f,"forge/game/GameAction:2076:668:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Set;)Ljava/util/function/Consumer;",673);}
case 673:{return rt.Call(f,"forge/game/card/CardCollectionView","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",678);}
case 678:{f.Pc=633;continue;}
case 681:{f.Push(f.Locals[7]);f.Pc=683;continue;}
case 683:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",686);}
case 686:{f.Locals[10]=f.Pop();f.Pc=688;continue;}
case 688:{f.Push(f.Locals[10]);f.Pc=690;continue;}
case 690:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",695);}
case 695:{f.Pc=f.Pop().Int==0?875:698;continue;}
case 698:{f.Push(f.Locals[10]);f.Pc=700;continue;}
case 700:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",705);}
case 705:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=708;continue;}
case 708:{f.Locals[11]=f.Pop();f.Pc=710;continue;}
case 710:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",713);}
case 713:{f.Locals[12]=f.Pop();f.Pc=715;continue;}
case 715:{f.Push(f.Locals[11]);f.Pc=717;continue;}
case 717:{return rt.Call(f,"forge/game/card/Card","getStaticCommandList","()Ljava/util/List;","invokevirtual",720);}
case 720:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",725);}
case 725:{f.Locals[13]=f.Pop();f.Pc=727;continue;}
case 727:{f.Push(f.Locals[13]);f.Pc=729;continue;}
case 729:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",734);}
case 734:{f.Pc=f.Pop().Int==0?859:737;continue;}
case 737:{f.Push(f.Locals[13]);f.Pc=739;continue;}
case 739:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",744);}
case 744:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/Object;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=747;continue;}
case 747:{f.Locals[14]=f.Pop();f.Pc=749;continue;}
case 749:{f.Push(f.Locals[14]);f.Pc=751;continue;}
case 751:{f.Push(JValue.I(0));f.Pc=752;continue;}
case 752:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=753;continue;}
case 753:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=756;continue;}
case 756:{f.Locals[15]=f.Pop();f.Pc=758;continue;}
case 758:{f.Push(f.Locals[14]);f.Pc=760;continue;}
case 760:{f.Push(JValue.I(1));f.Pc=761;continue;}
case 761:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=762;continue;}
case 762:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=765;continue;}
case 765:{f.Locals[16]=f.Pop();f.Pc=767;continue;}
case 767:{f.Push(f.Locals[14]);f.Pc=769;continue;}
case 769:{f.Push(JValue.I(2));f.Pc=770;continue;}
case 770:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=771;continue;}
case 771:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=774;continue;}
case 774:{f.Locals[17]=f.Pop();f.Pc=776;continue;}
case 776:{f.Push(f.Locals[17]);f.Pc=778;continue;}
case 778:{f.Push(f.Locals[15]);f.Pc=780;continue;}
case 780:{f.Push(JValue.R(null));f.Pc=781;continue;}
case 781:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",784);}
case 784:{f.Locals[18]=f.Pop();f.Pc=786;continue;}
case 786:{f.Push(f.Locals[16]);f.Pc=788;continue;}
case 788:{f.Push(JValue.I(0));f.Pc=789;continue;}
case 789:{f.Push(JValue.I(2));f.Pc=790;continue;}
case 790:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",793);}
case 793:{f.Locals[19]=f.Pop();f.Pc=795;continue;}
case 795:{f.Push(f.Locals[16]);f.Pc=797;continue;}
case 797:{f.Push(JValue.I(2));f.Pc=798;continue;}
case 798:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",801);}
case 801:{f.Locals[20]=f.Pop();f.Pc=803;continue;}
case 803:{f.Push(f.Locals[11]);f.Pc=805;continue;}
case 805:{f.Push(f.Locals[20]);f.Pc=807;continue;}
case 807:{f.Push(JValue.R(null));f.Pc=808;continue;}
case 808:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",811);}
case 811:{f.Locals[21]=f.Pop();f.Pc=813;continue;}
case 813:{f.Push(f.Locals[18]);f.Pc=815;continue;}
case 815:{f.Push(f.Locals[19]);f.Pc=817;continue;}
case 817:{f.Push(f.Locals[21]);f.Pc=819;continue;}
case 819:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",822);}
case 822:{f.Pc=f.Pop().Int==0?856:825;continue;}
case 825:{f.Push(f.Locals[14]);f.Pc=827;continue;}
case 827:{f.Push(JValue.I(3));f.Pc=828;continue;}
case 828:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=829;continue;}
case 829:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/GameCommand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=832;continue;}
case 832:{return rt.Call(f,"forge/GameCommand","run","()V","invokeinterface",837);}
case 837:{f.Push(f.Locals[12]);f.Pc=839;continue;}
case 839:{f.Push(f.Locals[14]);f.Pc=841;continue;}
case 841:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",846);}
case 846:{f.StackOp("pop");f.Pc=847;continue;}
case 847:{f.Push(f.Locals[2]);f.Pc=848;continue;}
case 848:{f.Push(f.Locals[11]);f.Pc=850;continue;}
case 850:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",855);}
case 855:{f.StackOp("pop");f.Pc=856;continue;}
case 856:{f.Pc=727;continue;}
case 859:{f.Push(f.Locals[11]);f.Pc=861;continue;}
case 861:{return rt.Call(f,"forge/game/card/Card","getStaticCommandList","()Ljava/util/List;","invokevirtual",864);}
case 864:{f.Push(f.Locals[12]);f.Pc=866;continue;}
case 866:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",871);}
case 871:{f.StackOp("pop");f.Pc=872;continue;}
case 872:{f.Pc=688;continue;}
case 875:{f.Push(f.Locals[3]);f.Pc=876;continue;}
case 876:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",881);}
case 881:{f.Pc=f.Pop().Int==0?1116:884;continue;}
case 884:{f.Push(f.Locals[0]);f.Pc=885;continue;}
case 885:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=888;continue;}
case 888:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",891);}
case 891:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",894);}
case 894:{f.Locals[10]=f.Pop();f.Pc=896;continue;}
case 896:{f.Push(f.Locals[10]);f.Pc=898;continue;}
case 898:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",903);}
case 903:{f.Pc=f.Pop().Int==0?1067:906;continue;}
case 906:{f.Push(f.Locals[10]);f.Pc=908;continue;}
case 908:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",913);}
case 913:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=916;continue;}
case 916:{f.Locals[11]=f.Pop();f.Pc=918;continue;}
case 918:{f.Push(f.Locals[11]);f.Pc=920;continue;}
case 920:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=923;continue;}
case 923:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",926);}
case 926:{return rt.Call(f,"forge/game/card/CardCollectionView","threadSafeIterable","()Ljava/lang/Iterable;","invokeinterface",931);}
case 931:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",936);}
case 936:{f.Locals[12]=f.Pop();f.Pc=938;continue;}
case 938:{f.Push(f.Locals[12]);f.Pc=940;continue;}
case 940:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",945);}
case 945:{f.Pc=f.Pop().Int==0?1064:948;continue;}
case 948:{f.Push(f.Locals[12]);f.Pc=950;continue;}
case 950:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",955);}
case 955:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=958;continue;}
case 958:{f.Locals[13]=f.Pop();f.Pc=960;continue;}
case 960:{f.Push(f.Locals[13]);f.Pc=962;continue;}
case 962:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",965);}
case 965:{f.Push(f.Locals[11]);f.Pc=967;continue;}
case 967:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",970);}
case 970:{f.Pc=f.Pop().Int!=0?988:973;continue;}
case 973:{f.Push(f.Locals[0]);f.Pc=974;continue;}
case 974:{f.Push(f.Locals[13]);f.Pc=976;continue;}
case 976:{return rt.Call(f,"forge/game/GameAction","controllerChangeZoneCorrection","(Lforge/game/card/Card;)V","invokevirtual",979);}
case 979:{f.Push(f.Locals[2]);f.Pc=980;continue;}
case 980:{f.Push(f.Locals[13]);f.Pc=982;continue;}
case 982:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",987);}
case 987:{f.StackOp("pop");f.Pc=988;continue;}
case 988:{f.Push(f.Locals[13]);f.Pc=990;continue;}
case 990:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",993);}
case 993:{f.Pc=f.Pop().Int==0?1061:996;continue;}
case 996:{f.Push(f.Locals[13]);f.Pc=998;continue;}
case 998:{return rt.Call(f,"forge/game/card/Card","isPaired","()Z","invokevirtual",1001);}
case 1001:{f.Pc=f.Pop().Int==0?1061:1004;continue;}
case 1004:{f.Push(f.Locals[13]);f.Pc=1006;continue;}
case 1006:{return rt.Call(f,"forge/game/card/Card","getPairedWith","()Lforge/game/card/Card;","invokevirtual",1009);}
case 1009:{f.Locals[14]=f.Pop();f.Pc=1011;continue;}
case 1011:{f.Push(f.Locals[14]);f.Pc=1013;continue;}
case 1013:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",1016);}
case 1016:{f.Pc=f.Pop().Int==0?1040:1019;continue;}
case 1019:{f.Push(f.Locals[13]);f.Pc=1021;continue;}
case 1021:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1024);}
case 1024:{f.Push(f.Locals[14]);f.Pc=1026;continue;}
case 1026:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1029);}
case 1029:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1040:1032;continue;}
case 1032:{f.Push(f.Locals[13]);f.Pc=1034;continue;}
case 1034:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",1037);}
case 1037:{f.Pc=f.Pop().Int!=0?1061:1040;continue;}
case 1040:{f.Push(f.Locals[13]);f.Pc=1042;continue;}
case 1042:{f.Push(JValue.R(null));f.Pc=1043;continue;}
case 1043:{return rt.Call(f,"forge/game/card/Card","setPairedWith","(Lforge/game/card/Card;)V","invokevirtual",1046);}
case 1046:{f.Push(f.Locals[14]);f.Pc=1048;continue;}
case 1048:{f.Push(JValue.R(null));f.Pc=1049;continue;}
case 1049:{return rt.Call(f,"forge/game/card/Card","setPairedWith","(Lforge/game/card/Card;)V","invokevirtual",1052);}
case 1052:{f.Push(f.Locals[2]);f.Pc=1053;continue;}
case 1053:{f.Push(f.Locals[13]);f.Pc=1055;continue;}
case 1055:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",1060);}
case 1060:{f.StackOp("pop");f.Pc=1061;continue;}
case 1061:{f.Pc=938;continue;}
case 1064:{f.Pc=896;continue;}
case 1067:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1070);}
case 1070:{f.Locals[10]=f.Pop();f.Pc=1072;continue;}
case 1072:{f.Push(f.Locals[0]);f.Pc=1073;continue;}
case 1073:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1076;continue;}
case 1076:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1079);}
case 1079:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"));f.Pc=1082;continue;}
case 1082:{f.Push(f.Locals[10]);f.Pc=1084;continue;}
case 1084:{f.Push(JValue.I(0));f.Pc=1085;continue;}
case 1085:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1088);}
case 1088:{f.Push(f.Locals[0]);f.Pc=1089;continue;}
case 1089:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1092;continue;}
case 1092:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1095);}
case 1095:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Immediate","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Immediate","Lforge/game/trigger/TriggerType;"));f.Pc=1098;continue;}
case 1098:{f.Push(f.Locals[10]);f.Pc=1100;continue;}
case 1100:{f.Push(JValue.I(0));f.Pc=1101;continue;}
case 1101:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1104);}
case 1104:{f.Push(f.Locals[0]);f.Pc=1105;continue;}
case 1105:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1108;continue;}
case 1108:{return rt.Call(f,"forge/game/Game","getView","()Lforge/game/GameView;","invokevirtual",1111);}
case 1111:{f.Push(f.Locals[8]);f.Pc=1113;continue;}
case 1113:{return rt.Call(f,"forge/game/GameView","setDependencies","(Lcom/google/common/collect/Table;)V","invokevirtual",1116);}
case 1116:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1119;continue;}
case 1119:{f.StackOp("dup");f.Pc=1120;continue;}
case 1120:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1123);}
case 1123:{f.Locals[10]=f.Pop();f.Pc=1125;continue;}
case 1125:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1128;continue;}
case 1128:{f.StackOp("dup");f.Pc=1129;continue;}
case 1129:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1132);}
case 1132:{f.Locals[11]=f.Pop();f.Pc=1134;continue;}
case 1134:{f.Push(f.Locals[5]);f.Pc=1136;continue;}
case 1136:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1139;continue;}
case 1139:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1144);}
case 1144:{f.Pc=f.Pop().Int==0?1208:1147;continue;}
case 1147:{f.Push(f.Locals[5]);f.Pc=1149;continue;}
case 1149:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1152;continue;}
case 1152:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1157);}
case 1157:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1160;continue;}
case 1160:{return rt.DynamicCall(f,"forge/game/GameAction:2076:1160:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Consumer;",1165);}
case 1165:{return rt.Call(f,"java/util/Set","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",1170);}
case 1170:{f.Push(f.Locals[10]);f.Pc=1172;continue;}
case 1172:{f.Push(f.Locals[5]);f.Pc=1174;continue;}
case 1174:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1177;continue;}
case 1177:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1182);}
case 1182:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1185;continue;}
case 1185:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1188);}
case 1188:{f.StackOp("pop");f.Pc=1189;continue;}
case 1189:{f.Push(f.Locals[11]);f.Pc=1191;continue;}
case 1191:{f.Push(f.Locals[5]);f.Pc=1193;continue;}
case 1193:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1196;continue;}
case 1196:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1201);}
case 1201:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1204;continue;}
case 1204:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1207);}
case 1207:{f.StackOp("pop");f.Pc=1208;continue;}
case 1208:{f.Push(f.Locals[5]);f.Pc=1210;continue;}
case 1210:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1213;continue;}
case 1213:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1218);}
case 1218:{f.Pc=f.Pop().Int==0?1282:1221;continue;}
case 1221:{f.Push(f.Locals[5]);f.Pc=1223;continue;}
case 1223:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1226;continue;}
case 1226:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1231);}
case 1231:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1234;continue;}
case 1234:{return rt.DynamicCall(f,"forge/game/GameAction:2076:1234:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Consumer;",1239);}
case 1239:{return rt.Call(f,"java/util/Set","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",1244);}
case 1244:{f.Push(f.Locals[10]);f.Pc=1246;continue;}
case 1246:{f.Push(f.Locals[5]);f.Pc=1248;continue;}
case 1248:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1251;continue;}
case 1251:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1256);}
case 1256:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1259;continue;}
case 1259:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1262);}
case 1262:{f.StackOp("pop");f.Pc=1263;continue;}
case 1263:{f.Push(f.Locals[11]);f.Pc=1265;continue;}
case 1265:{f.Push(f.Locals[5]);f.Pc=1267;continue;}
case 1267:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1270;continue;}
case 1270:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1275);}
case 1275:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1278;continue;}
case 1278:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1281);}
case 1281:{f.StackOp("pop");f.Pc=1282;continue;}
case 1282:{f.Push(f.Locals[5]);f.Pc=1284;continue;}
case 1284:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1287;continue;}
case 1287:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1292);}
case 1292:{f.Pc=f.Pop().Int==0?1314:1295;continue;}
case 1295:{f.Push(f.Locals[10]);f.Pc=1297;continue;}
case 1297:{f.Push(f.Locals[5]);f.Pc=1299;continue;}
case 1299:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1302;continue;}
case 1302:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1307);}
case 1307:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1310;continue;}
case 1310:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1313);}
case 1313:{f.StackOp("pop");f.Pc=1314;continue;}
case 1314:{f.Push(f.Locals[5]);f.Pc=1316;continue;}
case 1316:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1319;continue;}
case 1319:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1324);}
case 1324:{f.Pc=f.Pop().Int==0?1346:1327;continue;}
case 1327:{f.Push(f.Locals[11]);f.Pc=1329;continue;}
case 1329:{f.Push(f.Locals[5]);f.Pc=1331;continue;}
case 1331:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1334;continue;}
case 1334:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1339);}
case 1339:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1342;continue;}
case 1342:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1345);}
case 1345:{f.StackOp("pop");f.Pc=1346;continue;}
case 1346:{f.Push(f.Locals[5]);f.Pc=1348;continue;}
case 1348:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1351;continue;}
case 1351:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1356);}
case 1356:{f.Pc=f.Pop().Int==0?1378:1359;continue;}
case 1359:{f.Push(f.Locals[11]);f.Pc=1361;continue;}
case 1361:{f.Push(f.Locals[5]);f.Pc=1363;continue;}
case 1363:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1366;continue;}
case 1366:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1371);}
case 1371:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1374;continue;}
case 1374:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1377);}
case 1377:{f.StackOp("pop");f.Pc=1378;continue;}
case 1378:{f.Push(f.Locals[5]);f.Pc=1380;continue;}
case 1380:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1383;continue;}
case 1383:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1388);}
case 1388:{f.Pc=f.Pop().Int==0?1410:1391;continue;}
case 1391:{f.Push(f.Locals[11]);f.Pc=1393;continue;}
case 1393:{f.Push(f.Locals[5]);f.Pc=1395;continue;}
case 1395:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1398;continue;}
case 1398:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1403);}
case 1403:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1406;continue;}
case 1406:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1409);}
case 1409:{f.StackOp("pop");f.Pc=1410;continue;}
case 1410:{f.Push(f.Locals[11]);f.Pc=1412;continue;}
case 1412:{return rt.DynamicCall(f,"forge/game/GameAction:2076:1412:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Consumer;",1417);}
case 1417:{return rt.Call(f,"forge/game/card/CardCollection","forEach","(Ljava/util/function/Consumer;)V","invokevirtual",1420);}
case 1420:{f.Push(f.Locals[10]);f.Pc=1422;continue;}
case 1422:{return rt.DynamicCall(f,"forge/game/GameAction:2076:1422:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Consumer;",1427);}
case 1427:{return rt.Call(f,"forge/game/card/CardCollection","forEach","(Ljava/util/function/Consumer;)V","invokevirtual",1430);}
case 1430:{f.Push(f.Locals[5]);f.Pc=1432;continue;}
case 1432:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1435;continue;}
case 1435:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1440);}
case 1440:{f.Pc=f.Pop().Int==0?1466:1443;continue;}
case 1443:{f.Push(f.Locals[5]);f.Pc=1445;continue;}
case 1445:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1448;continue;}
case 1448:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1453);}
case 1453:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1456;continue;}
case 1456:{return rt.DynamicCall(f,"forge/game/GameAction:2076:1456:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Consumer;",1461);}
case 1461:{return rt.Call(f,"java/util/Set","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",1466);}
case 1466:{f.Push(f.Locals[1]);f.Pc=1467;continue;}
case 1467:{f.Pc=f.Pop().Int==0?1494:1470;continue;}
case 1470:{f.Push(f.Locals[2]);f.Pc=1471;continue;}
case 1471:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",1476);}
case 1476:{f.Pc=f.Pop().Int!=0?1494:1479;continue;}
case 1479:{f.Push(f.Locals[0]);f.Pc=1480;continue;}
case 1480:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1483;continue;}
case 1483:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=1486;continue;}
case 1486:{f.StackOp("dup");f.Pc=1487;continue;}
case 1487:{f.Push(f.Locals[2]);f.Pc=1488;continue;}
case 1488:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Ljava/util/Collection;)V","invokespecial",1491);}
case 1491:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1494);}
case 1494:{f.Push(f.Locals[0]);f.Pc=1495;continue;}
case 1495:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1498;continue;}
case 1498:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",1501);}
case 1501:{return rt.Call(f,"forge/trackable/Tracker","unfreeze","()V","invokevirtual",1504);}
case 1504:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2077(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{f.Locals[6]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",18);}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?25:22;continue;}
case 22:{f.Push(f.Locals[6]);f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
case 25:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTINUOUS_LAYERS_WITH_DEPENDENCY","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CONTINUOUS_LAYERS_WITH_DEPENDENCY","Lcom/google/common/collect/ImmutableList;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"com/google/common/collect/ImmutableList","contains","(Ljava/lang/Object;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int!=0?38:35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
case 38:{return rt.DynamicCall(f,"forge/game/GameAction:2077:38:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",43);}
case 43:{f.Locals[7]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[7]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[6]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?60:57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return JStep.Return(f.Pop());}
case 60:{if(!rt.EnsureInitialized(f,"org/jgrapht/graph/DefaultDirectedGraph"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/jgrapht/graph/DefaultDirectedGraph")));f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.ClassObject("org/jgrapht/graph/DefaultEdge")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"org/jgrapht/graph/DefaultDirectedGraph","<init>","(Ljava/lang/Class;)V","invokespecial",70);}
case 70:{f.Locals[8]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",78);}
case 78:{f.Locals[9]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[9]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",87);}
case 87:{f.Pc=f.Pop().Int==0?505:90;continue;}
case 90:{f.Push(f.Locals[9]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",97);}
case 97:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=100;continue;}
case 100:{f.Locals[10]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[8]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[10]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"org/jgrapht/graph/DefaultDirectedGraph","addVertex","(Ljava/lang/Object;)Z","invokevirtual",109);}
case 109:{f.StackOp("pop");f.Pc=110;continue;}
case 110:{f.Push(f.Locals[7]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[10]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",119);}
case 119:{f.Pc=f.Pop().Int==0?125:122;continue;}
case 122:{f.Pc=80;continue;}
case 125:{f.Push(f.Locals[10]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",130);}
case 130:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",133);}
case 133:{f.Push(f.Locals[10]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/util/collect/FCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",140);}
case 140:{f.Locals[11]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{f.Locals[12]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[4]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[10]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",154);}
case 154:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=157;continue;}
case 157:{f.Locals[13]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[13]);f.Pc=161;continue;}
case 161:{f.Pc=f.Pop().Reference!=null?175:164;continue;}
case 164:{f.Push(f.Locals[10]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[3]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous","getAffectedCards","(Lforge/game/staticability/StaticAbility;Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;","invokestatic",170);}
case 170:{f.Locals[13]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(JValue.I(1));f.Pc=173;continue;}
case 173:{f.Locals[12]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[0]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[10]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/GameAction","generateContinuousEffectChanges","(Lforge/game/staticability/StaticAbilityLayer;Lforge/game/staticability/StaticAbility;)Ljava/lang/Iterable;","invokevirtual",182);}
case 182:{f.Locals[14]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[2]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",190);}
case 190:{f.Locals[15]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[15]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",199);}
case 199:{f.Pc=f.Pop().Int==0?479:202;continue;}
case 202:{f.Push(f.Locals[15]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",209);}
case 209:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=212;continue;}
case 212:{f.Locals[16]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[10]);f.Pc=216;continue;}
case 216:{f.Push(f.Locals[16]);f.Pc=218;continue;}
case 218:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?224:221;continue;}
case 221:{f.Pc=192;continue;}
case 224:{f.Push(JValue.I(1));f.Pc=225;continue;}
case 225:{f.Locals[17]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[4]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[16]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",236);}
case 236:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=239;continue;}
case 239:{f.Locals[18]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[18]);f.Pc=243;continue;}
case 243:{f.Pc=f.Pop().Reference!=null?263:246;continue;}
case 246:{f.Push(f.Locals[16]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[1]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[3]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/staticability/StaticAbility","applyContinuousAbilityBefore","(Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;","invokevirtual",253);}
case 253:{f.Locals[18]=f.Pop();f.Pc=255;continue;}
case 255:{f.Push(f.Locals[18]);f.Pc=257;continue;}
case 257:{f.Pc=f.Pop().Reference!=null?275:260;continue;}
case 260:{f.Pc=192;continue;}
case 263:{f.Push(JValue.I(0));f.Pc=264;continue;}
case 264:{f.Locals[17]=f.Pop();f.Pc=266;continue;}
case 266:{f.Push(f.Locals[16]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[1]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[18]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/staticability/StaticAbility","applyContinuousAbility","(Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;","invokevirtual",274);}
case 274:{f.StackOp("pop");f.Pc=275;continue;}
case 275:{f.Push(f.Locals[11]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[10]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",282);}
case 282:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",285);}
case 285:{f.Push(f.Locals[10]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/util/collect/FCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",292);}
case 292:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?299:295;continue;}
case 295:{f.Push(JValue.I(1));f.Pc=296;continue;}
case 296:{f.Pc=300;continue;}
case 299:{f.Push(JValue.I(0));f.Pc=300;continue;}
case 300:{f.Locals[19]=f.Pop();f.Pc=302;continue;}
case 302:{f.Push(f.Locals[19]);f.Pc=304;continue;}
case 304:{f.Pc=f.Pop().Int!=0?347:307;continue;}
case 307:{f.Push(f.Locals[12]);f.Pc=309;continue;}
case 309:{f.Pc=f.Pop().Int==0?347:312;continue;}
case 312:{f.Push(f.Locals[10]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[3]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous","getAffectedCards","(Lforge/game/staticability/StaticAbility;Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;","invokestatic",318);}
case 318:{f.Locals[20]=f.Pop();f.Pc=320;continue;}
case 320:{f.Push(f.Locals[13]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",327);}
case 327:{f.Push(f.Locals[20]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",334);}
case 334:{return rt.Call(f,"com/google/common/collect/Iterators","elementsEqual","(Ljava/util/Iterator;Ljava/util/Iterator;)Z","invokestatic",337);}
case 337:{f.Pc=f.Pop().Int!=0?344:340;continue;}
case 340:{f.Push(JValue.I(1));f.Pc=341;continue;}
case 341:{f.Pc=345;continue;}
case 344:{f.Push(JValue.I(0));f.Pc=345;continue;}
case 345:{f.Locals[19]=f.Pop();f.Pc=347;continue;}
case 347:{f.Push(f.Locals[19]);f.Pc=349;continue;}
case 349:{f.Pc=f.Pop().Int!=0?378:352;continue;}
case 352:{f.Push(f.Locals[0]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[1]);f.Pc=354;continue;}
case 354:{f.Push(f.Locals[10]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"forge/game/GameAction","generateContinuousEffectChanges","(Lforge/game/staticability/StaticAbilityLayer;Lforge/game/staticability/StaticAbility;)Ljava/lang/Iterable;","invokevirtual",359);}
case 359:{f.Locals[20]=f.Pop();f.Pc=361;continue;}
case 361:{f.Push(f.Locals[14]);f.Pc=363;continue;}
case 363:{f.Push(f.Locals[20]);f.Pc=365;continue;}
case 365:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",368);}
case 368:{f.Pc=f.Pop().Int!=0?375:371;continue;}
case 371:{f.Push(JValue.I(1));f.Pc=372;continue;}
case 372:{f.Pc=376;continue;}
case 375:{f.Push(JValue.I(0));f.Pc=376;continue;}
case 376:{f.Locals[19]=f.Pop();f.Pc=378;continue;}
case 378:{f.Push(f.Locals[19]);f.Pc=380;continue;}
case 380:{f.Pc=f.Pop().Int==0?460:383;continue;}
case 383:{f.Push(f.Locals[8]);f.Pc=385;continue;}
case 385:{f.Push(f.Locals[16]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"org/jgrapht/graph/DefaultDirectedGraph","addVertex","(Ljava/lang/Object;)Z","invokevirtual",390);}
case 390:{f.StackOp("pop");f.Pc=391;continue;}
case 391:{f.Push(f.Locals[8]);f.Pc=393;continue;}
case 393:{f.Push(f.Locals[10]);f.Pc=395;continue;}
case 395:{f.Push(f.Locals[16]);f.Pc=397;continue;}
case 397:{return rt.Call(f,"org/jgrapht/graph/DefaultDirectedGraph","addEdge","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",400);}
case 400:{f.StackOp("pop");f.Pc=401;continue;}
case 401:{f.Push(f.Locals[5]);f.Pc=403;continue;}
case 403:{f.Pc=f.Pop().Reference==null?460:406;continue;}
case 406:{f.Push(f.Locals[5]);f.Pc=408;continue;}
case 408:{f.Push(f.Locals[10]);f.Pc=410;continue;}
case 410:{f.Push(f.Locals[16]);f.Pc=412;continue;}
case 412:{return rt.Call(f,"com/google/common/collect/Table","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",417);}
case 417:{f.Pc=f.Pop().Int==0?444:420;continue;}
case 420:{f.Push(f.Locals[5]);f.Pc=422;continue;}
case 422:{f.Push(f.Locals[10]);f.Pc=424;continue;}
case 424:{f.Push(f.Locals[16]);f.Pc=426;continue;}
case 426:{return rt.Call(f,"com/google/common/collect/Table","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",431);}
case 431:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=434;continue;}
case 434:{f.Push(f.Locals[1]);f.Pc=435;continue;}
case 435:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",440);}
case 440:{f.StackOp("pop");f.Pc=441;continue;}
case 441:{f.Pc=460;continue;}
case 444:{f.Push(f.Locals[5]);f.Pc=446;continue;}
case 446:{f.Push(f.Locals[10]);f.Pc=448;continue;}
case 448:{f.Push(f.Locals[16]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[1]);f.Pc=451;continue;}
case 451:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",454);}
case 454:{return rt.Call(f,"com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",459);}
case 459:{f.StackOp("pop");f.Pc=460;continue;}
case 460:{f.Push(f.Locals[0]);f.Pc=461;continue;}
case 461:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/game/Game","getStaticEffects","()Lforge/game/StaticEffects;","invokevirtual",467);}
case 467:{f.Push(f.Locals[16]);f.Pc=469;continue;}
case 469:{f.Push(f.Locals[1]);f.Pc=470;continue;}
case 470:{f.Push(f.Locals[17]);f.Pc=472;continue;}
case 472:{return rt.Call(f,"forge/game/StaticEffects","removeStaticEffect","(Lforge/game/staticability/StaticAbility;Lforge/game/staticability/StaticAbilityLayer;Z)Z","invokevirtual",475);}
case 475:{f.StackOp("pop");f.Pc=476;continue;}
case 476:{f.Pc=192;continue;}
case 479:{f.Push(f.Locals[8]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"org/jgrapht/graph/DefaultDirectedGraph","edgeSet","()Ljava/util/Set;","invokevirtual",484);}
case 484:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",489);}
case 489:{f.Pc=f.Pop().Int==0?502:492;continue;}
case 492:{f.Push(f.Locals[10]);f.Pc=494;continue;}
case 494:{f.Push(f.Locals[6]);f.Pc=496;continue;}
case 496:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?502:499;continue;}
case 499:{f.Push(f.Locals[10]);f.Pc=501;continue;}
case 501:{return JStep.Return(f.Pop());}
case 502:{f.Pc=80;continue;}
case 505:{if(!rt.EnsureInitialized(f,"org/jgrapht/alg/cycle/SzwarcfiterLauerSimpleCycles"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/jgrapht/alg/cycle/SzwarcfiterLauerSimpleCycles")));f.Pc=508;continue;}
case 508:{f.StackOp("dup");f.Pc=509;continue;}
case 509:{f.Push(f.Locals[8]);f.Pc=511;continue;}
case 511:{return rt.Call(f,"org/jgrapht/alg/cycle/SzwarcfiterLauerSimpleCycles","<init>","(Lorg/jgrapht/Graph;)V","invokespecial",514);}
case 514:{return rt.Call(f,"org/jgrapht/alg/cycle/SzwarcfiterLauerSimpleCycles","findSimpleCycles","()Ljava/util/List;","invokevirtual",517);}
case 517:{f.Locals[9]=f.Pop();f.Pc=519;continue;}
case 519:{f.Push(f.Locals[9]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",526);}
case 526:{f.Locals[10]=f.Pop();f.Pc=528;continue;}
case 528:{f.Push(f.Locals[10]);f.Pc=530;continue;}
case 530:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",535);}
case 535:{f.Pc=f.Pop().Int==0?644:538;continue;}
case 538:{f.Push(f.Locals[10]);f.Pc=540;continue;}
case 540:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",545);}
case 545:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=548;continue;}
case 548:{f.Locals[11]=f.Pop();f.Pc=550;continue;}
case 550:{f.Push(JValue.I(0));f.Pc=551;continue;}
case 551:{f.Locals[12]=f.Pop();f.Pc=553;continue;}
case 553:{f.Push(f.Locals[12]);f.Pc=555;continue;}
case 555:{f.Push(f.Locals[11]);f.Pc=557;continue;}
case 557:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",562);}
case 562:{f.Push(JValue.I(1));f.Pc=563;continue;}
case 563:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=564;continue;}
case 564:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?605:567;continue;}
case 567:{f.Push(f.Locals[8]);f.Pc=569;continue;}
case 569:{f.Push(f.Locals[11]);f.Pc=571;continue;}
case 571:{f.Push(f.Locals[12]);f.Pc=573;continue;}
case 573:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",578);}
case 578:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=581;continue;}
case 581:{f.Push(f.Locals[11]);f.Pc=583;continue;}
case 583:{f.Push(f.Locals[12]);f.Pc=585;continue;}
case 585:{f.Push(JValue.I(1));f.Pc=586;continue;}
case 586:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=587;continue;}
case 587:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",592);}
case 592:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=595;continue;}
case 595:{return rt.Call(f,"org/jgrapht/graph/DefaultDirectedGraph","removeEdge","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",598);}
case 598:{f.StackOp("pop");f.Pc=599;continue;}
case 599:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=602;continue;}
case 602:{f.Pc=553;continue;}
case 605:{f.Push(f.Locals[8]);f.Pc=607;continue;}
case 607:{f.Push(f.Locals[11]);f.Pc=609;continue;}
case 609:{f.Push(f.Locals[11]);f.Pc=611;continue;}
case 611:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",616);}
case 616:{f.Push(JValue.I(1));f.Pc=617;continue;}
case 617:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=618;continue;}
case 618:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",623);}
case 623:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=626;continue;}
case 626:{f.Push(f.Locals[11]);f.Pc=628;continue;}
case 628:{f.Push(JValue.I(0));f.Pc=629;continue;}
case 629:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",634);}
case 634:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=637;continue;}
case 637:{return rt.Call(f,"org/jgrapht/graph/DefaultDirectedGraph","removeEdge","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",640);}
case 640:{f.StackOp("pop");f.Pc=641;continue;}
case 641:{f.Pc=528;continue;}
case 644:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",647);}
case 647:{f.Locals[10]=f.Pop();f.Pc=649;continue;}
case 649:{f.Push(f.Locals[8]);f.Pc=651;continue;}
case 651:{return rt.Call(f,"org/jgrapht/graph/DefaultDirectedGraph","vertexSet","()Ljava/util/Set;","invokevirtual",654);}
case 654:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",659);}
case 659:{f.Locals[11]=f.Pop();f.Pc=661;continue;}
case 661:{f.Push(f.Locals[11]);f.Pc=663;continue;}
case 663:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",668);}
case 668:{f.Pc=f.Pop().Int==0?706:671;continue;}
case 671:{f.Push(f.Locals[11]);f.Pc=673;continue;}
case 673:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",678);}
case 678:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=681;continue;}
case 681:{f.Locals[12]=f.Pop();f.Pc=683;continue;}
case 683:{f.Push(f.Locals[8]);f.Pc=685;continue;}
case 685:{f.Push(f.Locals[12]);f.Pc=687;continue;}
case 687:{return rt.Call(f,"org/jgrapht/graph/DefaultDirectedGraph","outDegreeOf","(Ljava/lang/Object;)I","invokevirtual",690);}
case 690:{f.Pc=f.Pop().Int<=0?703:693;continue;}
case 693:{f.Push(f.Locals[10]);f.Pc=695;continue;}
case 695:{f.Push(f.Locals[12]);f.Pc=697;continue;}
case 697:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",702);}
case 702:{f.StackOp("pop");f.Pc=703;continue;}
case 703:{f.Pc=661;continue;}
case 706:{f.Push(f.Locals[8]);f.Pc=708;continue;}
case 708:{f.Push(f.Locals[10]);f.Pc=710;continue;}
case 710:{return rt.Call(f,"org/jgrapht/graph/DefaultDirectedGraph","removeAllVertices","(Ljava/util/Collection;)Z","invokevirtual",713);}
case 713:{f.StackOp("pop");f.Pc=714;continue;}
case 714:{f.Push(f.Locals[8]);f.Pc=716;continue;}
case 716:{return rt.Call(f,"org/jgrapht/graph/DefaultDirectedGraph","vertexSet","()Ljava/util/Set;","invokevirtual",719);}
case 719:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",722);}
case 722:{f.Locals[11]=f.Pop();f.Pc=724;continue;}
case 724:{f.Push(f.Locals[11]);f.Pc=726;continue;}
case 726:{return rt.DynamicCall(f,"forge/game/GameAction:2077:726:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",731);}
case 731:{return rt.Call(f,"java/util/Comparator","comparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokestatic",734);}
case 734:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",739);}
case 739:{f.Push(f.Locals[11]);f.Pc=741;continue;}
case 741:{f.Push(JValue.I(0));f.Pc=742;continue;}
case 742:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",747);}
case 747:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=750;continue;}
case 750:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2078(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/util/Collections","emptyList","()Ljava/util/List;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=8;continue;}
case 8:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?37:11;continue;}
case 11:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",20);}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",31);}
case 31:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2079(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/GameAction","checkStateEffects","(ZLjava/util/Set;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2080(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameAction","checkGameOverCondition","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/zone/MagicStack","isFrozen","()Z","invokevirtual",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",34);}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/zone/MagicStack","setFrozen","(Z)V","invokevirtual",38);}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/trackable/Tracker","freeze","()V","invokevirtual",48);}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{f.Locals[4]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{f.Locals[6]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{f.Locals[7]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(JValue.I(0));f.Pc=61;continue;}
case 61:{f.Locals[8]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[8]);f.Pc=65;continue;}
case 65:{f.Push(JValue.I(9));f.Pc=67;continue;}
case 67:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1620:70;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{f.Locals[9]=f.Pop();f.Pc=73;continue;}
case 73:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",80);}
case 80:{f.Locals[10]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;)V","invokevirtual",91);}
case 91:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",102);}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",109);}
case 109:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",112);}
case 112:{f.Locals[11]=f.Pop();f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",117);}
case 117:{f.Locals[12]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[12]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[11]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",126);}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",133);}
case 133:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",136);}
case 136:{f.Locals[13]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[13]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",145);}
case 145:{f.Pc=f.Pop().Int==0?295:148;continue;}
case 148:{f.Push(f.Locals[13]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",155);}
case 155:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=158;continue;}
case 158:{f.Locals[14]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[14]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/player/Player","checkKeywordCard","()V","invokevirtual",165);}
case 165:{return rt.Call(f,"forge/game/zone/ZoneType","values","()[Lforge/game/zone/ZoneType;","invokestatic",168);}
case 168:{f.Locals[15]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[15]);f.Pc=172;continue;}
case 172:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=173;continue;}
case 173:{f.Locals[16]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(JValue.I(0));f.Pc=176;continue;}
case 176:{f.Locals[17]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[17]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[16]);f.Pc=182;continue;}
case 182:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?292:185;continue;}
case 185:{f.Push(f.Locals[15]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[17]);f.Pc=189;continue;}
case 189:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=190;continue;}
case 190:{f.Locals[18]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[18]);f.Pc=194;continue;}
case 194:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=197;continue;}
case 197:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?286:200;continue;}
case 200:{f.Push(f.Locals[18]);f.Pc=202;continue;}
case 202:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Flashback","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Flashback","Lforge/game/zone/ZoneType;"));f.Pc=205;continue;}
case 205:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?211:208;continue;}
case 208:{f.Pc=286;continue;}
case 211:{f.Push(f.Locals[14]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[18]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",218);}
case 218:{return rt.Call(f,"forge/game/card/CardCollectionView","threadSafeIterable","()Ljava/lang/Iterable;","invokeinterface",223);}
case 223:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",228);}
case 228:{f.Locals[19]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[19]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",237);}
case 237:{f.Pc=f.Pop().Int==0?286:240;continue;}
case 240:{f.Push(f.Locals[19]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",247);}
case 247:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=250;continue;}
case 250:{f.Locals[20]=f.Pop();f.Pc=252;continue;}
case 252:{f.Push(f.Locals[9]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[20]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/GameAction","stateBasedAction704_5d","(Lforge/game/card/Card;)Z","invokevirtual",260);}
case 260:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=261;continue;}
case 261:{f.Locals[9]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(f.Locals[18]);f.Pc=265;continue;}
case 265:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=268;continue;}
case 268:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?283:271;continue;}
case 271:{f.Push(f.Locals[0]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[20]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/GameAction","stateBasedAction_Dungeon","(Lforge/game/card/Card;)V","invokevirtual",277);}
case 277:{f.Push(f.Locals[0]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[20]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/GameAction","stateBasedAction_Scheme","(Lforge/game/card/Card;)V","invokevirtual",283);}
case 283:{f.Pc=230;continue;}
case 286:{f.Locals[17]=JValue.I(unchecked(f.Locals[17].Int+(1)));f.Pc=289;continue;}
case 289:{f.Pc=178;continue;}
case 292:{f.Pc=138;continue;}
case 295:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=298;continue;}
case 298:{f.StackOp("dup");f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",302);}
case 302:{f.Locals[13]=f.Pop();f.Pc=304;continue;}
case 304:{f.Push(JValue.R(null));f.Pc=305;continue;}
case 305:{f.Locals[14]=f.Pop();f.Pc=307;continue;}
case 307:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=310;continue;}
case 310:{f.StackOp("dup");f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",314);}
case 314:{f.Locals[15]=f.Pop();f.Pc=316;continue;}
case 316:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=319;continue;}
case 319:{f.StackOp("dup");f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",323);}
case 323:{f.Locals[16]=f.Pop();f.Pc=325;continue;}
case 325:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=328;continue;}
case 328:{f.StackOp("dup");f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",332);}
case 332:{f.Locals[17]=f.Pop();f.Pc=334;continue;}
case 334:{f.Push(f.Locals[0]);f.Pc=335;continue;}
case 335:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=338;continue;}
case 338:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",344);}
case 344:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",349);}
case 349:{f.Locals[18]=f.Pop();f.Pc=351;continue;}
case 351:{f.Push(f.Locals[18]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",358);}
case 358:{f.Pc=f.Pop().Int==0?843:361;continue;}
case 361:{f.Push(f.Locals[18]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",368);}
case 368:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=371;continue;}
case 371:{f.Locals[19]=f.Pop();f.Pc=373;continue;}
case 373:{f.Push(JValue.I(0));f.Pc=374;continue;}
case 374:{f.Locals[20]=f.Pop();f.Pc=376;continue;}
case 376:{f.Push(f.Locals[19]);f.Pc=378;continue;}
case 378:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","SPACE_SCULPTOR","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","SPACE_SCULPTOR","Lforge/game/keyword/Keyword;"));f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",384);}
case 384:{f.Pc=f.Pop().Int==0?398:387;continue;}
case 387:{f.Push(f.Locals[17]);f.Pc=389;continue;}
case 389:{f.Push(f.Locals[19]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",394);}
case 394:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",397);}
case 397:{f.StackOp("pop");f.Pc=398;continue;}
case 398:{f.Push(f.Locals[19]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",403);}
case 403:{f.Pc=f.Pop().Int==0?568:406;continue;}
case 406:{f.Push(f.Locals[19]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",411);}
case 411:{f.Pc=f.Pop().Int>0?428:414;continue;}
case 414:{f.Push(f.Locals[13]);f.Pc=416;continue;}
case 416:{f.Push(f.Locals[19]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",421);}
case 421:{f.StackOp("pop");f.Pc=422;continue;}
case 422:{f.Push(JValue.I(1));f.Pc=423;continue;}
case 423:{f.Locals[20]=f.Pop();f.Pc=425;continue;}
case 425:{f.Pc=568;continue;}
case 428:{f.Push(f.Locals[19]);f.Pc=430;continue;}
case 430:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","INDESTRUCTIBLE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","INDESTRUCTIBLE","Lforge/game/keyword/Keyword;"));f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",436);}
case 436:{f.Pc=f.Pop().Int==0?442:439;continue;}
case 439:{f.Pc=568;continue;}
case 442:{f.Push(f.Locals[19]);f.Pc=444;continue;}
case 444:{f.Push(JValue.R(rt.String("CARDNAME can't be destroyed by lethal damage unless lethal damage dealt by a single source is marked on it.")));f.Pc=447;continue;}
case 447:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",450);}
case 450:{f.Pc=f.Pop().Int==0?508:453;continue;}
case 453:{f.Push(f.Locals[19]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/card/Card","getLethal","()I","invokevirtual",458);}
case 458:{f.Push(f.Locals[19]);f.Pc=460;continue;}
case 460:{return rt.Call(f,"forge/game/card/Card","getMaxDamageFromSource","()I","invokevirtual",463);}
case 463:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?474:466;continue;}
case 466:{f.Push(f.Locals[19]);f.Pc=468;continue;}
case 468:{return rt.Call(f,"forge/game/card/Card","hasBeenDealtDeathtouchDamage","()Z","invokevirtual",471);}
case 471:{f.Pc=f.Pop().Int==0?568:474;continue;}
case 474:{f.Push(f.Locals[14]);f.Pc=476;continue;}
case 476:{f.Pc=f.Pop().Reference!=null?488:479;continue;}
case 479:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=482;continue;}
case 482:{f.StackOp("dup");f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",486);}
case 486:{f.Locals[14]=f.Pop();f.Pc=488;continue;}
case 488:{f.Push(f.Locals[14]);f.Pc=490;continue;}
case 490:{f.Push(f.Locals[19]);f.Pc=492;continue;}
case 492:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",495);}
case 495:{f.StackOp("pop");f.Pc=496;continue;}
case 496:{f.Push(f.Locals[19]);f.Pc=498;continue;}
case 498:{f.Push(JValue.I(0));f.Pc=499;continue;}
case 499:{return rt.Call(f,"forge/game/card/Card","setHasBeenDealtDeathtouchDamage","(Z)V","invokevirtual",502);}
case 502:{f.Push(JValue.I(1));f.Pc=503;continue;}
case 503:{f.Locals[20]=f.Pop();f.Pc=505;continue;}
case 505:{f.Pc=568;continue;}
case 508:{f.Push(f.Locals[19]);f.Pc=510;continue;}
case 510:{return rt.Call(f,"forge/game/card/Card","hasBeenDealtDeathtouchDamage","()Z","invokevirtual",513);}
case 513:{f.Pc=f.Pop().Int!=0?537:516;continue;}
case 516:{f.Push(f.Locals[19]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"forge/game/card/Card","getDamage","()I","invokevirtual",521);}
case 521:{f.Pc=f.Pop().Int<=0?568:524;continue;}
case 524:{f.Push(f.Locals[19]);f.Pc=526;continue;}
case 526:{return rt.Call(f,"forge/game/card/Card","getLethal","()I","invokevirtual",529);}
case 529:{f.Push(f.Locals[19]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"forge/game/card/Card","getDamage","()I","invokevirtual",534);}
case 534:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?568:537;continue;}
case 537:{f.Push(f.Locals[14]);f.Pc=539;continue;}
case 539:{f.Pc=f.Pop().Reference!=null?551:542;continue;}
case 542:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=545;continue;}
case 545:{f.StackOp("dup");f.Pc=546;continue;}
case 546:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",549);}
case 549:{f.Locals[14]=f.Pop();f.Pc=551;continue;}
case 551:{f.Push(f.Locals[14]);f.Pc=553;continue;}
case 553:{f.Push(f.Locals[19]);f.Pc=555;continue;}
case 555:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",558);}
case 558:{f.StackOp("pop");f.Pc=559;continue;}
case 559:{f.Push(f.Locals[19]);f.Pc=561;continue;}
case 561:{f.Push(JValue.I(0));f.Pc=562;continue;}
case 562:{return rt.Call(f,"forge/game/card/Card","setHasBeenDealtDeathtouchDamage","(Z)V","invokevirtual",565);}
case 565:{f.Push(JValue.I(1));f.Pc=566;continue;}
case 566:{f.Locals[20]=f.Pop();f.Pc=568;continue;}
case 568:{f.Push(f.Locals[20]);f.Pc=570;continue;}
case 570:{f.Push(f.Locals[0]);f.Pc=571;continue;}
case 571:{f.Push(f.Locals[19]);f.Pc=573;continue;}
case 573:{f.Push(f.Locals[16]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"forge/game/GameAction","stateBasedAction_Saga","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z","invokevirtual",578);}
case 578:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=579;continue;}
case 579:{f.Locals[20]=f.Pop();f.Pc=581;continue;}
case 581:{f.Push(f.Locals[20]);f.Pc=583;continue;}
case 583:{f.Push(f.Locals[0]);f.Pc=584;continue;}
case 584:{f.Push(f.Locals[19]);f.Pc=586;continue;}
case 586:{f.Push(f.Locals[13]);f.Pc=588;continue;}
case 588:{return rt.Call(f,"forge/game/GameAction","stateBasedAction_Battle","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z","invokevirtual",591);}
case 591:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=592;continue;}
case 592:{f.Locals[20]=f.Pop();f.Pc=594;continue;}
case 594:{f.Push(f.Locals[20]);f.Pc=596;continue;}
case 596:{f.Push(f.Locals[0]);f.Pc=597;continue;}
case 597:{f.Push(f.Locals[19]);f.Pc=599;continue;}
case 599:{f.Push(f.Locals[15]);f.Pc=601;continue;}
case 601:{return rt.Call(f,"forge/game/GameAction","stateBasedAction_Role","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z","invokevirtual",604);}
case 604:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=605;continue;}
case 605:{f.Locals[20]=f.Pop();f.Pc=607;continue;}
case 607:{f.Push(f.Locals[20]);f.Pc=609;continue;}
case 609:{f.Push(f.Locals[0]);f.Pc=610;continue;}
case 610:{f.Push(f.Locals[19]);f.Pc=612;continue;}
case 612:{f.Push(f.Locals[15]);f.Pc=614;continue;}
case 614:{return rt.Call(f,"forge/game/GameAction","stateBasedAction704_attach","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z","invokevirtual",617);}
case 617:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=618;continue;}
case 618:{f.Locals[20]=f.Pop();f.Pc=620;continue;}
case 620:{f.Push(f.Locals[20]);f.Pc=622;continue;}
case 622:{f.Push(f.Locals[0]);f.Pc=623;continue;}
case 623:{f.Push(f.Locals[19]);f.Pc=625;continue;}
case 625:{f.Push(f.Locals[13]);f.Pc=627;continue;}
case 627:{return rt.Call(f,"forge/game/GameAction","stateBasedAction_Contraption","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z","invokevirtual",630);}
case 630:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=631;continue;}
case 631:{f.Locals[20]=f.Pop();f.Pc=633;continue;}
case 633:{f.Push(f.Locals[20]);f.Pc=635;continue;}
case 635:{f.Push(f.Locals[0]);f.Pc=636;continue;}
case 636:{f.Push(f.Locals[19]);f.Pc=638;continue;}
case 638:{return rt.Call(f,"forge/game/GameAction","stateBasedAction704_5q","(Lforge/game/card/Card;)Z","invokevirtual",641);}
case 641:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=642;continue;}
case 642:{f.Locals[20]=f.Pop();f.Pc=644;continue;}
case 644:{f.Push(f.Locals[20]);f.Pc=646;continue;}
case 646:{f.Push(f.Locals[0]);f.Pc=647;continue;}
case 647:{f.Push(f.Locals[19]);f.Pc=649;continue;}
case 649:{return rt.Call(f,"forge/game/GameAction","stateBasedAction704_5r","(Lforge/game/card/Card;)Z","invokevirtual",652);}
case 652:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=653;continue;}
case 653:{f.Locals[20]=f.Pop();f.Pc=655;continue;}
case 655:{f.Push(f.Locals[19]);f.Pc=657;continue;}
case 657:{f.Push(JValue.R(rt.String("The number of loyalty counters on CARDNAME is equal to the number of Beebles you control.")));f.Pc=660;continue;}
case 660:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",663);}
case 663:{f.Pc=f.Pop().Int==0?789:666;continue;}
case 666:{f.Push(f.Locals[0]);f.Pc=667;continue;}
case 667:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=670;continue;}
case 670:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=673;continue;}
case 673:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",676);}
case 676:{f.Push(JValue.R(rt.String("Beeble.YouCtrl")));f.Pc=679;continue;}
case 679:{f.Push(f.Locals[19]);f.Pc=681;continue;}
case 681:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",684);}
case 684:{f.Push(f.Locals[19]);f.Pc=686;continue;}
case 686:{f.Push(JValue.R(null));f.Pc=687;continue;}
case 687:{return rt.Call(f,"forge/game/card/CardLists","getValidCardCount","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)I","invokestatic",690);}
case 690:{f.Locals[21]=f.Pop();f.Pc=692;continue;}
case 692:{f.Push(f.Locals[19]);f.Pc=694;continue;}
case 694:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=697;continue;}
case 697:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",700);}
case 700:{f.Locals[22]=f.Pop();f.Pc=702;continue;}
case 702:{f.Push(f.Locals[22]);f.Pc=704;continue;}
case 704:{f.Push(f.Locals[21]);f.Pc=706;continue;}
case 706:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?751:709;continue;}
case 709:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=712;continue;}
case 712:{f.StackOp("dup");f.Pc=713;continue;}
case 713:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",716);}
case 716:{f.Locals[23]=f.Pop();f.Pc=718;continue;}
case 718:{f.Push(f.Locals[19]);f.Pc=720;continue;}
case 720:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=723;continue;}
case 723:{f.Push(f.Locals[21]);f.Pc=725;continue;}
case 725:{f.Push(f.Locals[22]);f.Pc=727;continue;}
case 727:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=728;continue;}
case 728:{f.Push(f.Locals[19]);f.Pc=730;continue;}
case 730:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",733);}
case 733:{f.Push(f.Locals[23]);f.Pc=735;continue;}
case 735:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",738);}
case 738:{f.Push(f.Locals[23]);f.Pc=740;continue;}
case 740:{f.Push(f.Locals[0]);f.Pc=741;continue;}
case 741:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=744;continue;}
case 744:{f.Push(JValue.R(null));f.Pc=745;continue;}
case 745:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",748);}
case 748:{f.Pc=773;continue;}
case 751:{f.Push(f.Locals[22]);f.Pc=753;continue;}
case 753:{f.Push(f.Locals[21]);f.Pc=755;continue;}
case 755:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?773:758;continue;}
case 758:{f.Push(f.Locals[19]);f.Pc=760;continue;}
case 760:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=763;continue;}
case 763:{f.Push(f.Locals[22]);f.Pc=765;continue;}
case 765:{f.Push(f.Locals[21]);f.Pc=767;continue;}
case 767:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=768;continue;}
case 768:{f.Push(JValue.R(null));f.Pc=769;continue;}
case 769:{return rt.Call(f,"forge/game/card/Card","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",772);}
case 772:{f.StackOp("pop");f.Pc=773;continue;}
case 773:{f.Push(f.Locals[19]);f.Pc=775;continue;}
case 775:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=778;continue;}
case 778:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",781);}
case 781:{f.Push(f.Locals[22]);f.Pc=783;continue;}
case 783:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?789:786;continue;}
case 786:{f.Push(JValue.I(1));f.Pc=787;continue;}
case 787:{f.Locals[20]=f.Pop();f.Pc=789;continue;}
case 789:{f.Push(f.Locals[19]);f.Pc=791;continue;}
case 791:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",794);}
case 794:{f.Pc=f.Pop().Int==0?824:797;continue;}
case 797:{f.Push(f.Locals[19]);f.Pc=799;continue;}
case 799:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",802);}
case 802:{f.Pc=f.Pop().Int==0?824:805;continue;}
case 805:{f.Push(f.Locals[19]);f.Pc=807;continue;}
case 807:{return rt.Call(f,"forge/game/card/Card","isEnchanting","()Z","invokevirtual",810);}
case 810:{f.Pc=f.Pop().Int!=0?824:813;continue;}
case 813:{f.Push(f.Locals[13]);f.Pc=815;continue;}
case 815:{f.Push(f.Locals[19]);f.Pc=817;continue;}
case 817:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",820);}
case 820:{f.StackOp("pop");f.Pc=821;continue;}
case 821:{f.Push(JValue.I(1));f.Pc=822;continue;}
case 822:{f.Locals[20]=f.Pop();f.Pc=824;continue;}
case 824:{f.Push(f.Locals[20]);f.Pc=826;continue;}
case 826:{f.Pc=f.Pop().Int==0?840:829;continue;}
case 829:{f.Push(f.Locals[10]);f.Pc=831;continue;}
case 831:{f.Push(f.Locals[19]);f.Pc=833;continue;}
case 833:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",836);}
case 836:{f.StackOp("pop");f.Pc=837;continue;}
case 837:{f.Push(JValue.I(1));f.Pc=838;continue;}
case 838:{f.Locals[9]=f.Pop();f.Pc=840;continue;}
case 840:{f.Pc=351;continue;}
case 843:{f.Push(f.Locals[15]);f.Pc=845;continue;}
case 845:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",848);}
case 848:{f.Locals[18]=f.Pop();f.Pc=850;continue;}
case 850:{f.Push(f.Locals[18]);f.Pc=852;continue;}
case 852:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",857);}
case 857:{f.Pc=f.Pop().Int==0?920:860;continue;}
case 860:{f.Push(f.Locals[18]);f.Pc=862;continue;}
case 862:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",867);}
case 867:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=870;continue;}
case 870:{f.Locals[19]=f.Pop();f.Pc=872;continue;}
case 872:{f.Push(f.Locals[19]);f.Pc=874;continue;}
case 874:{f.Push(f.Locals[19]);f.Pc=876;continue;}
case 876:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",879);}
case 879:{return rt.Call(f,"forge/game/card/Card","unattachFromEntity","(Lforge/game/GameEntity;)V","invokevirtual",882);}
case 882:{f.Push(f.Locals[19]);f.Pc=884;continue;}
case 884:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",887);}
case 887:{f.Pc=f.Pop().Int==0?917:890;continue;}
case 890:{f.Push(f.Locals[19]);f.Pc=892;continue;}
case 892:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",895);}
case 895:{f.Pc=f.Pop().Int==0?917:898;continue;}
case 898:{f.Push(f.Locals[19]);f.Pc=900;continue;}
case 900:{return rt.Call(f,"forge/game/card/Card","isEnchanting","()Z","invokevirtual",903);}
case 903:{f.Pc=f.Pop().Int!=0?917:906;continue;}
case 906:{f.Push(f.Locals[13]);f.Pc=908;continue;}
case 908:{f.Push(f.Locals[19]);f.Pc=910;continue;}
case 910:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",913);}
case 913:{f.StackOp("pop");f.Pc=914;continue;}
case 914:{f.Push(JValue.I(1));f.Pc=915;continue;}
case 915:{f.Locals[9]=f.Pop();f.Pc=917;continue;}
case 917:{f.Pc=850;continue;}
case 920:{f.Push(f.Locals[0]);f.Pc=921;continue;}
case 921:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=924;continue;}
case 924:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",927);}
case 927:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",930);}
case 930:{f.Locals[18]=f.Pop();f.Pc=932;continue;}
case 932:{f.Push(f.Locals[18]);f.Pc=934;continue;}
case 934:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",939);}
case 939:{f.Pc=f.Pop().Int==0?1218:942;continue;}
case 942:{f.Push(f.Locals[18]);f.Pc=944;continue;}
case 944:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",949);}
case 949:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=952;continue;}
case 952:{f.Locals[19]=f.Pop();f.Pc=954;continue;}
case 954:{f.Push(f.Locals[17]);f.Pc=956;continue;}
case 956:{return rt.Call(f,"forge/game/player/PlayerCollection","isEmpty","()Z","invokevirtual",959);}
case 959:{f.Pc=f.Pop().Int!=0?983:962;continue;}
case 962:{f.Push(f.Locals[17]);f.Pc=964;continue;}
case 964:{f.Push(f.Locals[19]);f.Pc=966;continue;}
case 966:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",969);}
case 969:{f.Pc=f.Pop().Int!=0?983:972;continue;}
case 972:{f.Push(f.Locals[9]);f.Pc=974;continue;}
case 974:{f.Push(f.Locals[0]);f.Pc=975;continue;}
case 975:{f.Push(f.Locals[19]);f.Pc=977;continue;}
case 977:{return rt.Call(f,"forge/game/GameAction","stateBasedAction704_5u","(Lforge/game/player/Player;)Z","invokevirtual",980);}
case 980:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=981;continue;}
case 981:{f.Locals[9]=f.Pop();f.Pc=983;continue;}
case 983:{f.Push(f.Locals[9]);f.Pc=985;continue;}
case 985:{f.Push(f.Locals[0]);f.Pc=986;continue;}
case 986:{f.Push(f.Locals[19]);f.Pc=988;continue;}
case 988:{f.Push(f.Locals[13]);f.Pc=990;continue;}
case 990:{return rt.Call(f,"forge/game/GameAction","handleLegendRule","(Lforge/game/player/Player;Lforge/game/card/CardCollection;)Z","invokevirtual",993);}
case 993:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=994;continue;}
case 994:{f.Locals[9]=f.Pop();f.Pc=996;continue;}
case 996:{f.Push(f.Locals[0]);f.Pc=997;continue;}
case 997:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1000;continue;}
case 1000:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",1003);}
case 1003:{if(!rt.StaticReady(f,"forge/game/GameType","Commander","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Commander","Lforge/game/GameType;"));f.Pc=1006;continue;}
case 1006:{return rt.Call(f,"forge/game/GameRules","hasAppliedVariant","(Lforge/game/GameType;)Z","invokevirtual",1009);}
case 1009:{f.Pc=f.Pop().Int!=0?1044:1012;continue;}
case 1012:{f.Push(f.Locals[0]);f.Pc=1013;continue;}
case 1013:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1016;continue;}
case 1016:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",1019);}
case 1019:{if(!rt.StaticReady(f,"forge/game/GameType","Brawl","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Brawl","Lforge/game/GameType;"));f.Pc=1022;continue;}
case 1022:{return rt.Call(f,"forge/game/GameRules","hasAppliedVariant","(Lforge/game/GameType;)Z","invokevirtual",1025);}
case 1025:{f.Pc=f.Pop().Int!=0?1044:1028;continue;}
case 1028:{f.Push(f.Locals[0]);f.Pc=1029;continue;}
case 1029:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1032;continue;}
case 1032:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",1035);}
case 1035:{if(!rt.StaticReady(f,"forge/game/GameType","Planeswalker","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Planeswalker","Lforge/game/GameType;"));f.Pc=1038;continue;}
case 1038:{return rt.Call(f,"forge/game/GameRules","hasAppliedVariant","(Lforge/game/GameType;)Z","invokevirtual",1041);}
case 1041:{f.Pc=f.Pop().Int==0?1165:1044;continue;}
case 1044:{f.Push(f.Locals[9]);f.Pc=1046;continue;}
case 1046:{f.Pc=f.Pop().Int!=0?1165:1049;continue;}
case 1049:{f.Push(f.Locals[19]);f.Pc=1051;continue;}
case 1051:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1054;continue;}
case 1054:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1057);}
case 1057:{return rt.Call(f,"forge/game/card/CardCollectionView","threadSafeIterable","()Ljava/lang/Iterable;","invokeinterface",1062);}
case 1062:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",1067);}
case 1067:{f.Locals[20]=f.Pop();f.Pc=1069;continue;}
case 1069:{f.Push(f.Locals[20]);f.Pc=1071;continue;}
case 1071:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1076);}
case 1076:{f.Pc=f.Pop().Int==0?1107:1079;continue;}
case 1079:{f.Push(f.Locals[20]);f.Pc=1081;continue;}
case 1081:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1086);}
case 1086:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1089;continue;}
case 1089:{f.Locals[21]=f.Pop();f.Pc=1091;continue;}
case 1091:{f.Push(f.Locals[9]);f.Pc=1093;continue;}
case 1093:{f.Push(f.Locals[0]);f.Pc=1094;continue;}
case 1094:{f.Push(f.Locals[21]);f.Pc=1096;continue;}
case 1096:{f.Push(f.Locals[12]);f.Pc=1098;continue;}
case 1098:{return rt.Call(f,"forge/game/GameAction","stateBasedAction_Commander","(Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",1101);}
case 1101:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=1102;continue;}
case 1102:{f.Locals[9]=f.Pop();f.Pc=1104;continue;}
case 1104:{f.Pc=1069;continue;}
case 1107:{f.Push(f.Locals[19]);f.Pc=1109;continue;}
case 1109:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=1112;continue;}
case 1112:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1115);}
case 1115:{return rt.Call(f,"forge/game/card/CardCollectionView","threadSafeIterable","()Ljava/lang/Iterable;","invokeinterface",1120);}
case 1120:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",1125);}
case 1125:{f.Locals[20]=f.Pop();f.Pc=1127;continue;}
case 1127:{f.Push(f.Locals[20]);f.Pc=1129;continue;}
case 1129:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1134);}
case 1134:{f.Pc=f.Pop().Int==0?1165:1137;continue;}
case 1137:{f.Push(f.Locals[20]);f.Pc=1139;continue;}
case 1139:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1144);}
case 1144:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1147;continue;}
case 1147:{f.Locals[21]=f.Pop();f.Pc=1149;continue;}
case 1149:{f.Push(f.Locals[9]);f.Pc=1151;continue;}
case 1151:{f.Push(f.Locals[0]);f.Pc=1152;continue;}
case 1152:{f.Push(f.Locals[21]);f.Pc=1154;continue;}
case 1154:{f.Push(f.Locals[12]);f.Pc=1156;continue;}
case 1156:{return rt.Call(f,"forge/game/GameAction","stateBasedAction_Commander","(Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",1159);}
case 1159:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=1160;continue;}
case 1160:{f.Locals[9]=f.Pop();f.Pc=1162;continue;}
case 1162:{f.Pc=1127;continue;}
case 1165:{f.Push(f.Locals[19]);f.Pc=1167;continue;}
case 1167:{return rt.Call(f,"forge/game/player/Player","getSpeed","()I","invokevirtual",1170);}
case 1170:{f.Pc=f.Pop().Int!=0?1202:1173;continue;}
case 1173:{f.Push(f.Locals[19]);f.Pc=1175;continue;}
case 1175:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1178;continue;}
case 1178:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1181);}
case 1181:{return rt.DynamicCall(f,"forge/game/GameAction:2080:1181:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",1186);}
case 1186:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",1191);}
case 1191:{f.Pc=f.Pop().Int==0?1202:1194;continue;}
case 1194:{f.Push(f.Locals[19]);f.Pc=1196;continue;}
case 1196:{return rt.Call(f,"forge/game/player/Player","increaseSpeed","()V","invokevirtual",1199);}
case 1199:{f.Push(JValue.I(1));f.Pc=1200;continue;}
case 1200:{f.Locals[9]=f.Pop();f.Pc=1202;continue;}
case 1202:{f.Push(f.Locals[9]);f.Pc=1204;continue;}
case 1204:{f.Push(f.Locals[0]);f.Pc=1205;continue;}
case 1205:{f.Push(f.Locals[19]);f.Pc=1207;continue;}
case 1207:{f.Push(f.Locals[13]);f.Pc=1209;continue;}
case 1209:{return rt.Call(f,"forge/game/GameAction","handlePlaneswalkerRule","(Lforge/game/player/Player;Lforge/game/card/CardCollection;)Z","invokevirtual",1212);}
case 1212:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=1213;continue;}
case 1213:{f.Locals[9]=f.Pop();f.Pc=1215;continue;}
case 1215:{f.Pc=932;continue;}
case 1218:{f.Push(f.Locals[17]);f.Pc=1220;continue;}
case 1220:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1223);}
case 1223:{f.Locals[18]=f.Pop();f.Pc=1225;continue;}
case 1225:{f.Push(f.Locals[18]);f.Pc=1227;continue;}
case 1227:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1232);}
case 1232:{f.Pc=f.Pop().Int==0?1261:1235;continue;}
case 1235:{f.Push(f.Locals[18]);f.Pc=1237;continue;}
case 1237:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1242);}
case 1242:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1245;continue;}
case 1245:{f.Locals[19]=f.Pop();f.Pc=1247;continue;}
case 1247:{f.Push(f.Locals[9]);f.Pc=1249;continue;}
case 1249:{f.Push(f.Locals[0]);f.Pc=1250;continue;}
case 1250:{f.Push(f.Locals[19]);f.Pc=1252;continue;}
case 1252:{return rt.Call(f,"forge/game/GameAction","stateBasedAction704_5u","(Lforge/game/player/Player;)Z","invokevirtual",1255);}
case 1255:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=1256;continue;}
case 1256:{f.Locals[9]=f.Pop();f.Pc=1258;continue;}
case 1258:{f.Pc=1225;continue;}
case 1261:{f.Push(f.Locals[9]);f.Pc=1263;continue;}
case 1263:{f.Push(f.Locals[0]);f.Pc=1264;continue;}
case 1264:{f.Push(f.Locals[13]);f.Pc=1266;continue;}
case 1266:{return rt.Call(f,"forge/game/GameAction","handleWorldRule","(Lforge/game/card/CardCollection;)Z","invokevirtual",1269);}
case 1269:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=1270;continue;}
case 1270:{f.Locals[9]=f.Pop();f.Pc=1272;continue;}
case 1272:{f.Push(f.Locals[0]);f.Pc=1273;continue;}
case 1273:{f.Push(JValue.I(1));f.Pc=1274;continue;}
case 1274:{return rt.Call(f,"forge/game/GameAction","setHoldCheckingStaticAbilities","(Z)V","invokevirtual",1277);}
case 1277:{f.Push(f.Locals[13]);f.Pc=1279;continue;}
case 1279:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1282);}
case 1282:{f.Push(JValue.I(1));f.Pc=1283;continue;}
case 1283:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1312:1286;continue;}
case 1286:{f.Push(f.Locals[6]);f.Pc=1288;continue;}
case 1288:{f.Pc=f.Pop().Int!=0?1312:1291;continue;}
case 1291:{f.Push(f.Locals[0]);f.Pc=1292;continue;}
case 1292:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1295;continue;}
case 1295:{f.Push(f.Locals[13]);f.Pc=1297;continue;}
case 1297:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1300;continue;}
case 1300:{f.Push(JValue.R(null));f.Pc=1301;continue;}
case 1301:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",1304);}
case 1304:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1307;continue;}
case 1307:{f.Locals[13]=f.Pop();f.Pc=1309;continue;}
case 1309:{f.Push(JValue.I(1));f.Pc=1310;continue;}
case 1310:{f.Locals[6]=f.Pop();f.Pc=1312;continue;}
case 1312:{f.Push(f.Locals[13]);f.Pc=1314;continue;}
case 1314:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1317);}
case 1317:{f.Locals[18]=f.Pop();f.Pc=1319;continue;}
case 1319:{f.Push(f.Locals[18]);f.Pc=1321;continue;}
case 1321:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1326);}
case 1326:{f.Pc=f.Pop().Int==0?1354:1329;continue;}
case 1329:{f.Push(f.Locals[18]);f.Pc=1331;continue;}
case 1331:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1336);}
case 1336:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1339;continue;}
case 1339:{f.Locals[19]=f.Pop();f.Pc=1341;continue;}
case 1341:{f.Push(f.Locals[0]);f.Pc=1342;continue;}
case 1342:{f.Push(f.Locals[19]);f.Pc=1344;continue;}
case 1344:{f.Push(JValue.R(null));f.Pc=1345;continue;}
case 1345:{f.Push(f.Locals[12]);f.Pc=1347;continue;}
case 1347:{return rt.Call(f,"forge/game/GameAction","sacrificeDestroy","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",1350);}
case 1350:{f.StackOp("pop");f.Pc=1351;continue;}
case 1351:{f.Pc=1319;continue;}
case 1354:{f.Push(f.Locals[14]);f.Pc=1356;continue;}
case 1356:{f.Pc=f.Pop().Reference==null?1457:1359;continue;}
case 1359:{f.Push(f.Locals[14]);f.Pc=1361;continue;}
case 1361:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1364);}
case 1364:{f.Push(JValue.I(1));f.Pc=1365;continue;}
case 1365:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1414:1368;continue;}
case 1368:{f.Push(f.Locals[5]);f.Pc=1370;continue;}
case 1370:{f.Pc=f.Pop().Int!=0?1414:1373;continue;}
case 1373:{f.Push(f.Locals[14]);f.Pc=1375;continue;}
case 1375:{return rt.DynamicCall(f,"forge/game/GameAction:2080:1375:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",1380);}
case 1380:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",1383);}
case 1383:{f.Locals[14]=f.Pop();f.Pc=1385;continue;}
case 1385:{f.Push(f.Locals[14]);f.Pc=1387;continue;}
case 1387:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1390);}
case 1390:{f.Pc=f.Pop().Int!=0?1411:1393;continue;}
case 1393:{f.Push(f.Locals[0]);f.Pc=1394;continue;}
case 1394:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1397;continue;}
case 1397:{f.Push(f.Locals[14]);f.Pc=1399;continue;}
case 1399:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1402;continue;}
case 1402:{f.Push(JValue.R(null));f.Pc=1403;continue;}
case 1403:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",1406);}
case 1406:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1409;continue;}
case 1409:{f.Locals[14]=f.Pop();f.Pc=1411;continue;}
case 1411:{f.Push(JValue.I(1));f.Pc=1412;continue;}
case 1412:{f.Locals[5]=f.Pop();f.Pc=1414;continue;}
case 1414:{f.Push(f.Locals[14]);f.Pc=1416;continue;}
case 1416:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1419);}
case 1419:{f.Locals[18]=f.Pop();f.Pc=1421;continue;}
case 1421:{f.Push(f.Locals[18]);f.Pc=1423;continue;}
case 1423:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1428);}
case 1428:{f.Pc=f.Pop().Int==0?1457:1431;continue;}
case 1431:{f.Push(f.Locals[18]);f.Pc=1433;continue;}
case 1433:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1438);}
case 1438:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1441;continue;}
case 1441:{f.Locals[19]=f.Pop();f.Pc=1443;continue;}
case 1443:{f.Push(f.Locals[0]);f.Pc=1444;continue;}
case 1444:{f.Push(f.Locals[19]);f.Pc=1446;continue;}
case 1446:{f.Push(JValue.R(null));f.Pc=1447;continue;}
case 1447:{f.Push(JValue.I(1));f.Pc=1448;continue;}
case 1448:{f.Push(f.Locals[12]);f.Pc=1450;continue;}
case 1450:{return rt.Call(f,"forge/game/GameAction","destroy","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Z","invokevirtual",1453);}
case 1453:{f.StackOp("pop");f.Pc=1454;continue;}
case 1454:{f.Pc=1421;continue;}
case 1457:{f.Push(f.Locals[16]);f.Pc=1459;continue;}
case 1459:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1462);}
case 1462:{f.Push(JValue.I(1));f.Pc=1463;continue;}
case 1463:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1492:1466;continue;}
case 1466:{f.Push(f.Locals[7]);f.Pc=1468;continue;}
case 1468:{f.Pc=f.Pop().Int!=0?1492:1471;continue;}
case 1471:{f.Push(f.Locals[0]);f.Pc=1472;continue;}
case 1472:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1475;continue;}
case 1475:{f.Push(f.Locals[16]);f.Pc=1477;continue;}
case 1477:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1480;continue;}
case 1480:{f.Push(JValue.R(null));f.Pc=1481;continue;}
case 1481:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",1484);}
case 1484:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1487;continue;}
case 1487:{f.Locals[16]=f.Pop();f.Pc=1489;continue;}
case 1489:{f.Push(JValue.I(1));f.Pc=1490;continue;}
case 1490:{f.Locals[7]=f.Pop();f.Pc=1492;continue;}
case 1492:{f.Push(f.Locals[0]);f.Pc=1493;continue;}
case 1493:{f.Push(f.Locals[16]);f.Pc=1495;continue;}
case 1495:{f.Push(JValue.R(null));f.Pc=1496;continue;}
case 1496:{f.Push(JValue.I(1));f.Pc=1497;continue;}
case 1497:{f.Push(f.Locals[12]);f.Pc=1499;continue;}
case 1499:{return rt.Call(f,"forge/game/GameAction","sacrifice","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",1502);}
case 1502:{f.StackOp("pop");f.Pc=1503;continue;}
case 1503:{f.Push(f.Locals[0]);f.Pc=1504;continue;}
case 1504:{f.Push(JValue.I(0));f.Pc=1505;continue;}
case 1505:{return rt.Call(f,"forge/game/GameAction","setHoldCheckingStaticAbilities","(Z)V","invokevirtual",1508);}
case 1508:{f.Push(f.Locals[11]);f.Pc=1510;continue;}
case 1510:{f.Push(f.Locals[0]);f.Pc=1511;continue;}
case 1511:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1514;continue;}
case 1514:{f.Push(JValue.R(null));f.Pc=1515;continue;}
case 1515:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1518);}
case 1518:{f.Push(f.Locals[0]);f.Pc=1519;continue;}
case 1519:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1522;continue;}
case 1522:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1525);}
case 1525:{return rt.Call(f,"forge/game/trigger/TriggerHandler","collectTriggerForWaiting","()V","invokevirtual",1528);}
case 1528:{f.Push(f.Locals[0]);f.Pc=1529;continue;}
case 1529:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1532;continue;}
case 1532:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1535);}
case 1535:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runWaitingTriggers","()Z","invokevirtual",1538);}
case 1538:{f.Pc=f.Pop().Int==0?1544:1541;continue;}
case 1541:{f.Push(JValue.I(1));f.Pc=1542;continue;}
case 1542:{f.Locals[9]=f.Pop();f.Pc=1544;continue;}
case 1544:{f.Push(f.Locals[0]);f.Pc=1545;continue;}
case 1545:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1548;continue;}
case 1548:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1551);}
case 1551:{f.Pc=f.Pop().Reference==null?1565:1554;continue;}
case 1554:{f.Push(f.Locals[0]);f.Pc=1555;continue;}
case 1555:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1558;continue;}
case 1558:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1561);}
case 1561:{return rt.Call(f,"forge/game/combat/Combat","removeAbsentCombatants","()Z","invokevirtual",1564);}
case 1564:{f.StackOp("pop");f.Pc=1565;continue;}
case 1565:{f.Push(f.Locals[10]);f.Pc=1567;continue;}
case 1567:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1570);}
case 1570:{f.Locals[18]=f.Pop();f.Pc=1572;continue;}
case 1572:{f.Push(f.Locals[18]);f.Pc=1574;continue;}
case 1574:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1579);}
case 1579:{f.Pc=f.Pop().Int==0?1606:1582;continue;}
case 1582:{f.Push(f.Locals[18]);f.Pc=1584;continue;}
case 1584:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1589);}
case 1589:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1592;continue;}
case 1592:{f.Locals[19]=f.Pop();f.Pc=1594;continue;}
case 1594:{f.Push(f.Locals[0]);f.Pc=1595;continue;}
case 1595:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1598;continue;}
case 1598:{f.Push(f.Locals[19]);f.Pc=1600;continue;}
case 1600:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",1603);}
case 1603:{f.Pc=1572;continue;}
case 1606:{f.Push(f.Locals[9]);f.Pc=1608;continue;}
case 1608:{f.Pc=f.Pop().Int==0?1620:1611;continue;}
case 1611:{f.Push(JValue.I(1));f.Pc=1612;continue;}
case 1612:{f.Locals[4]=f.Pop();f.Pc=1614;continue;}
case 1614:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=1617;continue;}
case 1617:{f.Pc=63;continue;}
case 1620:{f.Push(f.Locals[0]);f.Pc=1621;continue;}
case 1621:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1624;continue;}
case 1624:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",1627);}
case 1627:{return rt.Call(f,"forge/trackable/Tracker","unfreeze","()V","invokevirtual",1630);}
case 1630:{f.Push(f.Locals[1]);f.Pc=1631;continue;}
case 1631:{f.Pc=f.Pop().Int==0?1658:1634;continue;}
case 1634:{f.Push(f.Locals[2]);f.Pc=1635;continue;}
case 1635:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",1640);}
case 1640:{f.Pc=f.Pop().Int!=0?1658:1643;continue;}
case 1643:{f.Push(f.Locals[0]);f.Pc=1644;continue;}
case 1644:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1647;continue;}
case 1647:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=1650;continue;}
case 1650:{f.StackOp("dup");f.Pc=1651;continue;}
case 1651:{f.Push(f.Locals[2]);f.Pc=1652;continue;}
case 1652:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Ljava/util/Collection;)V","invokespecial",1655);}
case 1655:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1658);}
case 1658:{f.Push(f.Locals[0]);f.Pc=1659;continue;}
case 1659:{return rt.Call(f,"forge/game/GameAction","checkGameOverCondition","()V","invokevirtual",1662);}
case 1662:{f.Push(f.Locals[0]);f.Pc=1663;continue;}
case 1663:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1666;continue;}
case 1666:{return rt.Call(f,"forge/game/Game","getAge","()Lforge/game/GameStage;","invokevirtual",1669);}
case 1669:{if(!rt.StaticReady(f,"forge/game/GameStage","Play","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","Play","Lforge/game/GameStage;"));f.Pc=1672;continue;}
case 1672:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1677:1675;continue;}
case 1675:{f.Push(JValue.I(0));f.Pc=1676;continue;}
case 1676:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1677:{f.Push(f.Locals[0]);f.Pc=1678;continue;}
case 1678:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1681;continue;}
case 1681:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1684);}
case 1684:{return rt.Call(f,"forge/game/trigger/TriggerHandler","resetActiveTriggers","()V","invokevirtual",1687);}
case 1687:{f.Push(f.Locals[0]);f.Pc=1688;continue;}
case 1688:{f.Push(JValue.I(0));f.Pc=1689;continue;}
case 1689:{f.Push(f.Locals[2]);f.Pc=1690;continue;}
case 1690:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=1693;continue;}
case 1693:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;)V","invokevirtual",1696);}
case 1696:{f.Push(f.Locals[3]);f.Pc=1697;continue;}
case 1697:{f.Pc=f.Pop().Int!=0?1710:1700;continue;}
case 1700:{f.Push(f.Locals[0]);f.Pc=1701;continue;}
case 1701:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1704;continue;}
case 1704:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",1707);}
case 1707:{return rt.Call(f,"forge/game/zone/MagicStack","unfreezeStack","()V","invokevirtual",1710);}
case 1710:{f.Push(f.Locals[0]);f.Pc=1711;continue;}
case 1711:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=1714;continue;}
case 1714:{return rt.Call(f,"forge/game/Game","runSBACheckedCommands","()V","invokevirtual",1717);}
case 1717:{f.Push(f.Locals[4]);f.Pc=1719;continue;}
case 1719:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2081(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","isSaga","()Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?16:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/Card","hasChapter","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int!=0?18:16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(null));f.Pc=20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?29:27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LORE","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LORE","Lforge/game/card/CounterEnumType;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","getFinalChapterNr","()I","invokevirtual",40);}
case 40:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?45:43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",52);}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.DynamicCall(f,"forge/game/GameAction:2081:53:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",58);}
case 58:{return rt.Call(f,"forge/game/zone/MagicStack","hasSourceOnStack","(Lforge/game/card/Card;Ljava/util/function/Predicate;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?72:64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(1));f.Pc=71;continue;}
case 71:{f.Locals[3]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2082(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","isBattle","()Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?11:9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",15);}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/Card","getProtectingPlayer","()Lforge/game/player/Player;","invokevirtual",21);}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference==null?36:28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?63:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Reference==null?88:46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",53);}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/combat/Combat","getAttackersOf","(Lforge/game/GameEntity;)Lforge/game/card/CardCollection;","invokevirtual",57);}
case 57:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int!=0?88:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",67);}
case 67:{f.Push(JValue.R(rt.String("Siege")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",75);}
case 75:{f.Pc=f.Pop().Int==0?170:78;continue;}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?170:88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",92);}
case 92:{return rt.Call(f,"forge/card/CardTypeView","getBattleTypes","()Ljava/util/Set;","invokeinterface",97);}
case 97:{f.Push(JValue.R(rt.String("Siege")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",105);}
case 105:{f.Pc=f.Pop().Int==0?144:108;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",113);}
case 113:{f.Push(f.Locals[4]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",118);}
case 118:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=121;continue;}
case 121:{f.StackOp("dup");f.Pc=122;continue;}
case 122:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ChoosePlayer","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ChoosePlayer","Lforge/game/ability/ApiType;"));f.Pc=125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;)V","invokespecial",129);}
case 129:{f.Push(JValue.R(rt.String("Choose an opponent to protect this battle")));f.Pc=132;continue;}
case 132:{f.Push(JValue.R(null));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",136);}
case 136:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=139;continue;}
case 139:{f.Locals[6]=f.Pop();f.Pc=141;continue;}
case 141:{f.Pc=148;continue;}
case 144:{f.Push(f.Locals[4]);f.Pc=146;continue;}
case 146:{f.Locals[6]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[6]);f.Pc=150;continue;}
case 150:{f.Pc=f.Pop().Reference!=null?162:153;continue;}
case 153:{f.Push(f.Locals[2]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",158);}
case 158:{f.StackOp("pop");f.Pc=159;continue;}
case 159:{f.Pc=168;continue;}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[6]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/card/Card","setProtectingPlayer","(Lforge/game/player/Player;)V","invokevirtual",168);}
case 168:{f.Push(JValue.I(1));f.Pc=169;continue;}
case 169:{f.Locals[3]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[1]);f.Pc=171;continue;}
case 171:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","DEFENSE","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","DEFENSE","Lforge/game/card/CounterEnumType;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int<=0?182:180;continue;}
case 180:{f.Push(f.Locals[3]);f.Pc=181;continue;}
case 181:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 182:{f.Push(f.Locals[0]);f.Pc=183;continue;}
case 183:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",189);}
case 189:{f.Push(f.Locals[1]);f.Pc=190;continue;}
case 190:{return rt.DynamicCall(f,"forge/game/GameAction:2082:190:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",195);}
case 195:{return rt.Call(f,"forge/game/zone/MagicStack","hasSourceOnStack","(Lforge/game/card/Card;Ljava/util/function/Predicate;)Z","invokevirtual",198);}
case 198:{f.Pc=f.Pop().Int!=0?209:201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",206);}
case 206:{f.StackOp("pop");f.Pc=207;continue;}
case 207:{f.Push(JValue.I(1));f.Pc=208;continue;}
case 208:{f.Locals[3]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[3]);f.Pc=210;continue;}
case 210:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2083(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","hasCardAttachments","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getAttachedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",15);}
case 15:{f.Push(JValue.R(rt.String("Role")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardPredicates","isType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",21);}
case 21:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?36:34;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",46);}
case 46:{f.Locals[5]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?122:58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[6]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",77);}
case 77:{f.Locals[7]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[7]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",84);}
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?91:88;continue;}
case 88:{f.Pc=48;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/CardPredicates","compareByGameTimestamp","()Ljava/util/Comparator;","invokestatic",96);}
case 96:{return rt.Call(f,"forge/game/card/CardCollection","sort","(Ljava/util/Comparator;)V","invokevirtual",99);}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[7]);f.Pc=102;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{f.Push(f.Locals[7]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",108);}
case 108:{f.Push(JValue.I(1));f.Pc=109;continue;}
case 109:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/card/CardCollection","subList","(II)Lforge/game/card/CardCollection;","invokevirtual",113);}
case 113:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",116);}
case 116:{f.StackOp("pop");f.Pc=117;continue;}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{f.Locals[3]=f.Pop();f.Pc=119;continue;}
case 119:{f.Pc=48;continue;}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2084(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isDungeon","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?19:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","isInLastRoom","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int!=0?20:19;continue;}
case 19:{return JStep.ReturnVoid;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",27);}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(null));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/zone/MagicStack","hasSourceOnStack","(Lforge/game/card/Card;Ljava/util/function/Predicate;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int!=0?44:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",40);}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/GameAction","completeDungeon","(Lforge/game/player/Player;Lforge/game/card/Card;)V","invokevirtual",44);}
case 44:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2085(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isScheme","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?22:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",11);}
case 11:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","Ongoing","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","Ongoing","Lforge/card/CardType$Supertype;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardTypeView","hasSupertype","(Lforge/card/CardType$Supertype;)Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?23:22;continue;}
case 22:{return JStep.ReturnVoid;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",30);}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(null));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/zone/MagicStack","hasSourceOnStack","(Lforge/game/card/Card;Ljava/util/function/Predicate;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?52:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(-1));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(null));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",48);}
case 48:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2086(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","isAttachedToEntity","()Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?48:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",13);}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int!=0?40:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/Card","isBattle","()Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int!=0?40:29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(null));f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/GameEntity","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int!=0?48:40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{f.Locals[3]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/Card","hasCardAttachments","()Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?108:55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/Card","getAttachedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",59);}
case 59:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",64);}
case 64:{f.Locals[4]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",73);}
case 73:{f.Pc=f.Pop().Int==0?108:76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{f.Locals[5]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int!=0?105:96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[5]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",102);}
case 102:{f.StackOp("pop");f.Pc=103;continue;}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{f.Locals[3]=f.Pop();f.Pc=105;continue;}
case 105:{f.Pc=66;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2087(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isContraption","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/Card","getSprocket","()I","invokevirtual",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Int!=0?26:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Int<=0?37:30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(3));f.Pc=32;continue;}
case 32:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?37:35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",44);}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/player/PlayerController","chooseSprocket","(Lforge/game/card/Card;)I","invokevirtual",48);}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","setSprocket","(I)V","invokevirtual",56);}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2088(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CardCollection","threadSafeIterable","()Ljava/lang/Iterable;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?66:34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","hasSector","()Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int!=0?63:54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{f.Locals[2]=f.Pop();f.Pc=63;continue;}
case 63:{f.Pc=24;continue;}
case 66:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",73);}
case 73:{f.Locals[4]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",79);}
case 79:{f.Locals[5]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",88);}
case 88:{f.Pc=f.Pop().Int==0?212:91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",98);}
case 98:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=101;continue;}
case 101:{f.Locals[6]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",107);}
case 107:{f.Push(f.Locals[6]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("Assign")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/player/PlayerController","chooseSector","(Lforge/game/card/Card;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",115);}
case 115:{f.Locals[7]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[6]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[7]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/card/Card","assignSector","(Ljava/lang/String;)V","invokevirtual",124);}
case 124:{f.Push(f.Locals[4]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",129);}
case 129:{f.Pc=f.Pop().Int!=0?167:132;continue;}
case 132:{f.Push(f.Locals[4]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",138);}
case 138:{f.Push(JValue.R(rt.String(" ")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",144);}
case 144:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",147);}
case 147:{f.Push(JValue.R(rt.String("lblAssigns")));f.Pc=150;continue;}
case 150:{f.Push(JValue.I(0));f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",157);}
case 157:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",160);}
case 160:{f.Push(JValue.R(rt.String("\n")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",166);}
case 166:{f.StackOp("pop");f.Pc=167;continue;}
case 167:{f.Push(f.Locals[6]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",172);}
case 172:{f.Push(f.Locals[6]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",177);}
case 177:{return rt.DynamicCall(f,"forge/game/GameAction:2088:177:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",182);}
case 182:{f.Locals[8]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[4]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[8]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",191);}
case 191:{f.Push(JValue.R(rt.String(" ")));f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",197);}
case 197:{f.Push(f.Locals[7]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",202);}
case 202:{f.Push(JValue.R(rt.String("\n")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",208);}
case 208:{f.StackOp("pop");f.Pc=209;continue;}
case 209:{f.Pc=81;continue;}
case 212:{f.Push(f.Locals[4]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",217);}
case 217:{f.Pc=f.Pop().Int<=0?232:220;continue;}
case 220:{f.Push(f.Locals[0]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(null));f.Pc=222;continue;}
case 222:{f.Push(f.Locals[1]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[4]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",228);}
case 228:{f.Push(f.Locals[1]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",232);}
case 232:{f.Push(f.Locals[2]);f.Pc=233;continue;}
case 233:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2089(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isRealCommander","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?82:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","canMoveToCommandZone","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?82:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/trackable/Tracker","flush","()V","invokevirtual",24);}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","setMoveToCommandZone","(Z)V","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",40);}
case 40:{return rt.Call(f,"forge/game/card/CardState","getFirstSpellAbilityWithFallback","()Lforge/game/spellability/SpellAbility;","invokevirtual",43);}
case 43:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","ChangeZoneToAltDestination","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","ChangeZoneToAltDestination","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",50);}
case 50:{return rt.DynamicCall(f,"forge/game/GameAction:2089:50:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",55);}
case 55:{f.Push(JValue.R(null));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int==0?82:62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",67);}
case 67:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",73);}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(null));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 82:{f.Push(JValue.I(0));f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2090(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"));f.Pc=5;continue;}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","M1M1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","M1M1","Lforge/game/card/CounterEnumType;"));f.Pc=9;continue;}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",24);}
case 24:{f.Locals[6]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Int<=0?85:31;continue;}
case 31:{f.Push(f.Locals[6]);f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Int<=0?85:36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/Card","canRemoveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?53:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","canRemoveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int!=0?55:53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",62);}
case 62:{f.Locals[7]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[7]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(null));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/Card","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",72);}
case 72:{f.StackOp("pop");f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[4]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[7]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(null));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/card/Card","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{f.Locals[2]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2091(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","DREAM","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","DREAM","Lforge/game/card/CounterEnumType;"));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int>0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/Card","getCounterMax","(Lforge/game/card/CounterType;)Ljava/lang/Integer;","invokevirtual",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference!=null?30:28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",36);}
case 36:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?65:39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/card/Card","canRemoveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int!=0?49:47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",57);}
case 57:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(null));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/Card","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(1));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 65:{f.Push(JValue.I(0));f.Pc=66;continue;}
case 66:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2092(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","isRealToken","()Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?76:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?37:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/Card","getCopiedPermanent","()Lforge/game/card/Card;","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Reference==null?37:35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?59:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",51);}
case 51:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=54;continue;}
case 54:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?59:57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int!=0?76:69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/zone/Zone","remove","(Lforge/game/card/Card;)V","invokevirtual",74);}
case 74:{f.Push(JValue.I(1));f.Pc=75;continue;}
case 75:{f.Locals[2]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2093(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?11:10;continue;}
case 10:{return JStep.ReturnVoid;}
case 11:{f.Push(JValue.R(null));f.Pc=12;continue;}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",29);}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?162:41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/player/Player","hasWon","()Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int!=0?64:61;continue;}
case 61:{f.Pc=31;continue;}
case 64:{if(!rt.StaticReady(f,"forge/game/GameEndReason","WinsGameSpellEffect","Lforge/game/GameEndReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameEndReason","WinsGameSpellEffect","Lforge/game/GameEndReason;"));f.Pc=67;continue;}
case 67:{f.Locals[1]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",74);}
case 74:{f.Locals[6]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",83);}
case 83:{f.Pc=f.Pop().Int==0?159:86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{f.Locals[7]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/player/Player","getSharedTeam","()Lforge/game/player/PlayerCollection;","invokevirtual",103);}
case 103:{f.Push(f.Locals[7]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?114:111;continue;}
case 111:{f.Pc=76;continue;}
case 114:{f.Push(f.Locals[7]);f.Pc=116;continue;}
case 116:{if(!rt.StaticReady(f,"forge/game/player/GameLossReason","OpponentWon","Lforge/game/player/GameLossReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/GameLossReason","OpponentWon","Lforge/game/player/GameLossReason;"));f.Pc=119;continue;}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/player/Player","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",124);}
case 124:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerOutcome","altWinSourceName","Ljava/lang/String;"));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/player/Player","loseConditionMet","(Lforge/game/player/GameLossReason;Ljava/lang/String;)Z","invokevirtual",130);}
case 130:{f.Pc=f.Pop().Int!=0?138:133;continue;}
case 133:{f.Push(JValue.R(null));f.Pc=134;continue;}
case 134:{f.Locals[1]=f.Pop();f.Pc=135;continue;}
case 135:{f.Pc=156;continue;}
case 138:{f.Push(f.Locals[2]);f.Pc=139;continue;}
case 139:{f.Pc=f.Pop().Reference!=null?147:142;continue;}
case 142:{f.Push(JValue.I(3));f.Pc=143;continue;}
case 143:{return rt.Call(f,"com/google/common/collect/Lists","newArrayListWithCapacity","(I)Ljava/util/ArrayList;","invokestatic",146);}
case 146:{f.Locals[2]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[2]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[7]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",155);}
case 155:{f.StackOp("pop");f.Pc=156;continue;}
case 156:{f.Pc=76;continue;}
case 159:{f.Pc=162;continue;}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{f.Pc=f.Pop().Reference!=null?225:166;continue;}
case 166:{f.Push(f.Locals[3]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",172);}
case 172:{f.Locals[4]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[4]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",181);}
case 181:{f.Pc=f.Pop().Int==0?225:184;continue;}
case 184:{f.Push(f.Locals[4]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",191);}
case 191:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=194;continue;}
case 194:{f.Locals[5]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[5]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/player/Player","checkLoseCondition","()Z","invokevirtual",201);}
case 201:{f.Pc=f.Pop().Int==0?222:204;continue;}
case 204:{f.Push(f.Locals[2]);f.Pc=205;continue;}
case 205:{f.Pc=f.Pop().Reference!=null?213:208;continue;}
case 208:{f.Push(JValue.I(3));f.Pc=209;continue;}
case 209:{return rt.Call(f,"com/google/common/collect/Lists","newArrayListWithCapacity","(I)Ljava/util/ArrayList;","invokestatic",212);}
case 212:{f.Locals[2]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[2]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[5]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",221);}
case 221:{f.StackOp("pop");f.Pc=222;continue;}
case 222:{f.Pc=174;continue;}
case 225:{f.Push(f.Locals[2]);f.Pc=226;continue;}
case 226:{f.Pc=f.Pop().Reference==null?378:229;continue;}
case 229:{f.Push(f.Locals[2]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",233);}
case 233:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",236);}
case 236:{f.Locals[4]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[4]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",245);}
case 245:{f.Pc=f.Pop().Int==0?378:248;continue;}
case 248:{f.Push(f.Locals[4]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",255);}
case 255:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=258;continue;}
case 258:{f.Locals[5]=f.Pop();f.Pc=260;continue;}
case 260:{f.Push(f.Locals[5]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/player/Player","getSharedTeam","()Lforge/game/player/PlayerCollection;","invokevirtual",265);}
case 265:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",268);}
case 268:{f.Locals[6]=f.Pop();f.Pc=270;continue;}
case 270:{f.Push(f.Locals[6]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",277);}
case 277:{f.Pc=f.Pop().Int==0?375:280;continue;}
case 280:{f.Push(f.Locals[6]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",287);}
case 287:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=290;continue;}
case 290:{f.Locals[7]=f.Pop();f.Pc=292;continue;}
case 292:{f.Push(f.Locals[2]);f.Pc=293;continue;}
case 293:{f.Push(f.Locals[7]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",300);}
case 300:{f.Pc=f.Pop().Int!=0?270:303;continue;}
case 303:{f.Push(f.Locals[7]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/player/Player","hasLost","()Z","invokevirtual",308);}
case 308:{f.Pc=f.Pop().Int==0?314:311;continue;}
case 311:{f.Pc=270;continue;}
case 314:{f.Push(f.Locals[5]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/player/Player","conceded","()Z","invokevirtual",319);}
case 319:{f.Pc=f.Pop().Int==0?339:322;continue;}
case 322:{f.Push(f.Locals[7]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/player/Player","concede","()V","invokevirtual",327);}
case 327:{f.Push(f.Locals[2]);f.Pc=328;continue;}
case 328:{f.Push(f.Locals[7]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",335);}
case 335:{f.StackOp("pop");f.Pc=336;continue;}
case 336:{f.Pc=372;continue;}
case 339:{f.Push(f.Locals[7]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[5]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/player/Player","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",346);}
case 346:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerOutcome","lossState","Lforge/game/player/GameLossReason;"));f.Pc=349;continue;}
case 349:{f.Push(f.Locals[5]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/player/Player","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",354);}
case 354:{f.Push(rt.GetField(f.Pop(),"forge/game/player/PlayerOutcome","loseConditionSpell","Ljava/lang/String;"));f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/player/Player","loseConditionMet","(Lforge/game/player/GameLossReason;Ljava/lang/String;)Z","invokevirtual",360);}
case 360:{f.Pc=f.Pop().Int==0?372:363;continue;}
case 363:{f.Push(f.Locals[2]);f.Pc=364;continue;}
case 364:{f.Push(f.Locals[7]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",371);}
case 371:{f.StackOp("pop");f.Pc=372;continue;}
case 372:{f.Pc=270;continue;}
case 375:{f.Pc=238;continue;}
case 378:{f.Push(f.Locals[2]);f.Pc=379;continue;}
case 379:{f.Pc=f.Pop().Reference==null?424:382;continue;}
case 382:{f.Push(f.Locals[2]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",388);}
case 388:{f.Locals[4]=f.Pop();f.Pc=390;continue;}
case 390:{f.Push(f.Locals[4]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",397);}
case 397:{f.Pc=f.Pop().Int==0?424:400;continue;}
case 400:{f.Push(f.Locals[4]);f.Pc=402;continue;}
case 402:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",407);}
case 407:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=410;continue;}
case 410:{f.Locals[5]=f.Pop();f.Pc=412;continue;}
case 412:{f.Push(f.Locals[0]);f.Pc=413;continue;}
case 413:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=416;continue;}
case 416:{f.Push(f.Locals[5]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/Game","onPlayerLost","(Lforge/game/player/Player;)V","invokevirtual",421);}
case 421:{f.Pc=390;continue;}
case 424:{f.Push(f.Locals[1]);f.Pc=425;continue;}
case 425:{f.Pc=f.Pop().Reference!=null?569:428;continue;}
case 428:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",431);}
case 431:{f.Locals[4]=f.Pop();f.Pc=433;continue;}
case 433:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",436);}
case 436:{f.Locals[5]=f.Pop();f.Pc=438;continue;}
case 438:{f.Push(f.Locals[3]);f.Pc=439;continue;}
case 439:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",444);}
case 444:{f.Locals[6]=f.Pop();f.Pc=446;continue;}
case 446:{f.Push(f.Locals[6]);f.Pc=448;continue;}
case 448:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",453);}
case 453:{f.Pc=f.Pop().Int==0?516:456;continue;}
case 456:{f.Push(f.Locals[6]);f.Pc=458;continue;}
case 458:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",463);}
case 463:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=466;continue;}
case 466:{f.Locals[7]=f.Pop();f.Pc=468;continue;}
case 468:{f.Push(f.Locals[7]);f.Pc=470;continue;}
case 470:{return rt.Call(f,"forge/game/player/Player","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",473);}
case 473:{f.Pc=f.Pop().Reference==null?487:476;continue;}
case 476:{f.Push(f.Locals[7]);f.Pc=478;continue;}
case 478:{return rt.Call(f,"forge/game/player/Player","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",481);}
case 481:{return rt.Call(f,"forge/game/player/PlayerOutcome","hasWon","()Z","invokevirtual",484);}
case 484:{f.Pc=f.Pop().Int==0?513:487;continue;}
case 487:{f.Push(f.Locals[4]);f.Pc=489;continue;}
case 489:{f.Push(f.Locals[7]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",496);}
case 496:{f.StackOp("pop");f.Pc=497;continue;}
case 497:{f.Push(f.Locals[5]);f.Pc=499;continue;}
case 499:{f.Push(f.Locals[7]);f.Pc=501;continue;}
case 501:{return rt.Call(f,"forge/game/player/Player","getTeam","()I","invokevirtual",504);}
case 504:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",507);}
case 507:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",512);}
case 512:{f.StackOp("pop");f.Pc=513;continue;}
case 513:{f.Pc=446;continue;}
case 516:{f.Push(f.Locals[4]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",523);}
case 523:{f.Locals[6]=f.Pop();f.Pc=525;continue;}
case 525:{f.Push(f.Locals[6]);f.Pc=527;continue;}
case 527:{f.Push(JValue.I(1));f.Pc=528;continue;}
case 528:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?538:531;continue;}
case 531:{if(!rt.StaticReady(f,"forge/game/GameEndReason","AllOpponentsLost","Lforge/game/GameEndReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameEndReason","AllOpponentsLost","Lforge/game/GameEndReason;"));f.Pc=534;continue;}
case 534:{f.Locals[1]=f.Pop();f.Pc=535;continue;}
case 535:{f.Pc=569;continue;}
case 538:{f.Push(f.Locals[6]);f.Pc=540;continue;}
case 540:{f.Pc=f.Pop().Int!=0?550:543;continue;}
case 543:{if(!rt.StaticReady(f,"forge/game/GameEndReason","Draw","Lforge/game/GameEndReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameEndReason","Draw","Lforge/game/GameEndReason;"));f.Pc=546;continue;}
case 546:{f.Locals[1]=f.Pop();f.Pc=547;continue;}
case 547:{f.Pc=569;continue;}
case 550:{f.Push(f.Locals[5]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",557);}
case 557:{f.Push(JValue.I(1));f.Pc=558;continue;}
case 558:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?568:561;continue;}
case 561:{if(!rt.StaticReady(f,"forge/game/GameEndReason","AllOpposingTeamsLost","Lforge/game/GameEndReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameEndReason","AllOpposingTeamsLost","Lforge/game/GameEndReason;"));f.Pc=564;continue;}
case 564:{f.Locals[1]=f.Pop();f.Pc=565;continue;}
case 565:{f.Pc=569;continue;}
case 568:{return JStep.ReturnVoid;}
case 569:{f.Push(f.Locals[0]);f.Pc=570;continue;}
case 570:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=573;continue;}
case 573:{f.Push(f.Locals[1]);f.Pc=574;continue;}
case 574:{return rt.Call(f,"forge/game/Game","setGameOver","(Lforge/game/GameEndReason;)V","invokevirtual",577);}
case 577:{f.Push(f.Locals[0]);f.Pc=578;continue;}
case 578:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=581;continue;}
case 581:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",584);}
case 584:{return rt.Call(f,"forge/game/zone/MagicStack","clearSimultaneousStack","()V","invokevirtual",587);}
case 587:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2094(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getPlaneswalkersInPlay","()Lforge/game/card/CardCollection;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?70:26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[6]);f.Pc=40;continue;}
case 40:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int>0?67:49;continue;}
case 49:{f.Push(f.Locals[6]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/Card","ignorePlaneswalkerZeroLoyaltyRule","()Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int!=0?67:57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{f.Locals[4]=f.Pop();f.Pc=67;continue;}
case 67:{f.Pc=16;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2095(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",11);}
case 11:{f.Push(JValue.R(rt.String("Legendary")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",17);}
case 17:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?64:32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/Card","ignoreLegendRule","()Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int!=0?61:52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Pc=22;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",70);}
case 70:{f.Pc=f.Pop().Int==0?75:73;continue;}
case 73:{f.Push(JValue.I(0));f.Pc=74;continue;}
case 74:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{f.Locals[4]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{return rt.DynamicCall(f,"forge/game/GameAction:2095:79:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",84);}
case 84:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",87);}
case 87:{f.Locals[5]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{return rt.DynamicCall(f,"forge/game/GameAction:2095:90:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Function;",95);}
case 95:{return rt.Call(f,"com/google/common/collect/Multimaps","index","(Ljava/lang/Iterable;Lcom/google/common/base/Function;)Lcom/google/common/collect/ImmutableListMultimap;","invokestatic",98);}
case 98:{f.Locals[6]=f.Pop();f.Pc=100;continue;}
case 100:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=103;continue;}
case 103:{f.StackOp("dup");f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",107);}
case 107:{f.Locals[7]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[6]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"com/google/common/collect/Multimap","keySet","()Ljava/util/Set;","invokeinterface",116);}
case 116:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",121);}
case 121:{f.Locals[8]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[8]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",130);}
case 130:{f.Pc=f.Pop().Int==0?283:133;continue;}
case 133:{f.Push(f.Locals[8]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",140);}
case 140:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=143;continue;}
case 143:{f.Locals[9]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[9]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?156:153;continue;}
case 153:{f.Pc=123;continue;}
case 156:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=159;continue;}
case 159:{f.StackOp("dup");f.Pc=160;continue;}
case 160:{f.Push(f.Locals[6]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[9]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",169);}
case 169:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",172);}
case 172:{f.Locals[10]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[9]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",179);}
case 179:{f.Pc=f.Pop().Int!=0?204:182;continue;}
case 182:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",185);}
case 185:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",188);}
case 188:{f.Push(f.Locals[9]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/card/CardDb","isNonLegendaryCreatureName","(Ljava/lang/String;)Z","invokevirtual",193);}
case 193:{f.Pc=f.Pop().Int==0?204:196;continue;}
case 196:{f.Push(f.Locals[10]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[5]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",203);}
case 203:{f.StackOp("pop");f.Pc=204;continue;}
case 204:{f.Push(f.Locals[10]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",209);}
case 209:{f.Push(JValue.I(2));f.Pc=210;continue;}
case 210:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?216:213;continue;}
case 213:{f.Pc=123;continue;}
case 216:{f.Push(JValue.I(1));f.Pc=217;continue;}
case 217:{f.Locals[4]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[1]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",223);}
case 223:{f.Push(f.Locals[10]);f.Pc=225;continue;}
case 225:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=228;continue;}
case 228:{f.StackOp("dup");f.Pc=229;continue;}
case 229:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","InternalLegendaryRule","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","InternalLegendaryRule","Lforge/game/ability/ApiType;"));f.Pc=232;continue;}
case 232:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=235;continue;}
case 235:{f.StackOp("dup");f.Pc=236;continue;}
case 236:{f.Push(JValue.I(-1));f.Pc=237;continue;}
case 237:{f.Push(f.Locals[0]);f.Pc=238;continue;}
case 238:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",244);}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/player/Player;)V","invokespecial",248);}
case 248:{f.Push(f.Locals[9]);f.Pc=250;continue;}
case 250:{return rt.DynamicCall(f,"forge/game/GameAction:2095:250:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",255);}
case 255:{f.Push(JValue.R(null));f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",259);}
case 259:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=262;continue;}
case 262:{f.Locals[11]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(f.Locals[10]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[11]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",271);}
case 271:{f.StackOp("pop");f.Pc=272;continue;}
case 272:{f.Push(f.Locals[7]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[10]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",279);}
case 279:{f.StackOp("pop");f.Pc=280;continue;}
case 280:{f.Pc=123;continue;}
case 283:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=286;continue;}
case 286:{f.StackOp("dup");f.Pc=287;continue;}
case 287:{f.Push(f.Locals[5]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",292);}
case 292:{f.Locals[8]=f.Pop();f.Pc=294;continue;}
case 294:{f.Push(f.Locals[8]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[7]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",301);}
case 301:{f.StackOp("pop");f.Pc=302;continue;}
case 302:{f.Push(f.Locals[8]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",307);}
case 307:{f.Push(JValue.I(1));f.Pc=308;continue;}
case 308:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?371:311;continue;}
case 311:{f.Push(JValue.I(1));f.Pc=312;continue;}
case 312:{f.Locals[4]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[1]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",318);}
case 318:{f.Push(f.Locals[8]);f.Pc=320;continue;}
case 320:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=323;continue;}
case 323:{f.StackOp("dup");f.Pc=324;continue;}
case 324:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","InternalLegendaryRule","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","InternalLegendaryRule","Lforge/game/ability/ApiType;"));f.Pc=327;continue;}
case 327:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=330;continue;}
case 330:{f.StackOp("dup");f.Pc=331;continue;}
case 331:{f.Push(JValue.I(-1));f.Pc=332;continue;}
case 332:{f.Push(f.Locals[0]);f.Pc=333;continue;}
case 333:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",339);}
case 339:{f.Push(f.Locals[1]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/player/Player;)V","invokespecial",343);}
case 343:{f.Push(JValue.R(rt.String("You have multiple legendary permanents with non legendary creature names in play.\n\nChoose the one to stay on battlefield (the rest will be moved to graveyard)")));f.Pc=346;continue;}
case 346:{f.Push(JValue.R(null));f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",350);}
case 350:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=353;continue;}
case 353:{f.Locals[9]=f.Pop();f.Pc=355;continue;}
case 355:{f.Push(f.Locals[8]);f.Pc=357;continue;}
case 357:{f.Push(f.Locals[9]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",362);}
case 362:{f.StackOp("pop");f.Pc=363;continue;}
case 363:{f.Push(f.Locals[7]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[8]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",370);}
case 370:{f.StackOp("pop");f.Pc=371;continue;}
case 371:{f.Push(f.Locals[2]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[7]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",377);}
case 377:{f.StackOp("pop");f.Pc=378;continue;}
case 378:{f.Push(f.Locals[4]);f.Pc=380;continue;}
case 380:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2096(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",10);}
case 10:{return rt.DynamicCall(f,"forge/game/GameAction:2096:10:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",15);}
case 15:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",25);}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?31:29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 31:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(JValue.L(0));f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",44);}
case 44:{f.Locals[6]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[6]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",53);}
case 53:{f.Pc=f.Pop().Int==0?113:56;continue;}
case 56:{f.Push(f.Locals[6]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[7]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[7]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/Card","getWorldTimestamp","()J","invokevirtual",73);}
case 73:{f.Locals[8]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[8]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=80;continue;}
case 80:{f.Pc=f.Pop().Int<=0?93:83;continue;}
case 83:{f.Push(f.Locals[8]);f.Pc=85;continue;}
case 85:{f.Locals[4]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",93);}
case 93:{f.Push(f.Locals[8]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[4]);f.Pc=97;continue;}
case 97:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=98;continue;}
case 98:{f.Pc=f.Pop().Int!=0?110:101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[7]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",109);}
case 109:{f.StackOp("pop");f.Pc=110;continue;}
case 110:{f.Pc=46;continue;}
case 113:{f.Push(f.Locals[3]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",119);}
case 119:{f.Push(JValue.I(1));f.Pc=120;continue;}
case 120:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?131:123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",130);}
case 130:{f.StackOp("pop");f.Pc=131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[2]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",136);}
case 136:{f.StackOp("pop");f.Pc=137;continue;}
case 137:{f.Push(JValue.I(1));f.Pc=138;continue;}
case 138:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2097(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","hashKeys","()Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",3);}
case 3:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","arrayListValues","()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;","invokevirtual",6);}
case 6:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$ListMultimapBuilder","build","()Lcom/google/common/collect/ListMultimap;","invokevirtual",9);}
case 9:{f.Locals[5]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference==null?29:15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("ShowSacrificedCards")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?29:25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{f.Pc=30;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",39);}
case 39:{f.Locals[7]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",47);}
case 47:{f.Locals[8]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[8]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",56);}
case 56:{f.Pc=f.Pop().Int==0?206:59;continue;}
case 59:{f.Push(f.Locals[8]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",66);}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{f.Locals[9]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[9]);f.Pc=73;continue;}
case 73:{f.Pc=f.Pop().Reference!=null?79:76;continue;}
case 76:{f.Pc=49;continue;}
case 79:{f.Push(f.Locals[9]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/card/Card","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int!=0?92:89;continue;}
case 89:{f.Pc=49;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",102);}
case 102:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[9]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/card/CardCollection","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",110);}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{f.Locals[10]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[9]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",120);}
case 120:{f.Push(f.Locals[10]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/player/Player","addSacrificedThisTurn","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",126);}
case 126:{f.Push(f.Locals[5]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[9]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",133);}
case 133:{f.Push(f.Locals[10]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",140);}
case 140:{f.StackOp("pop");f.Pc=141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[9]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[2]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[4]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/GameAction","sacrificeDestroy","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",150);}
case 150:{f.Locals[11]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[11]);f.Pc=154;continue;}
case 154:{f.Pc=f.Pop().Reference==null?165:157;continue;}
case 157:{f.Push(f.Locals[7]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[11]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",164);}
case 164:{f.StackOp("pop");f.Pc=165;continue;}
case 165:{f.Push(f.Locals[6]);f.Pc=167;continue;}
case 167:{f.Pc=f.Pop().Int==0?203:170;continue;}
case 170:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",173);}
case 173:{f.Push(JValue.R(rt.String("lblSacrifice")));f.Pc=176;continue;}
case 176:{f.Push(JValue.I(0));f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",183);}
case 183:{f.Locals[12]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[7]);f.Pc=188;continue;}
case 188:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=191;continue;}
case 191:{f.Push(f.Locals[9]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",196);}
case 196:{f.Push(JValue.I(0));f.Pc=197;continue;}
case 197:{f.Push(f.Locals[12]);f.Pc=199;continue;}
case 199:{f.Push(JValue.I(0));f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;ZLjava/lang/String;Z)V","invokevirtual",203);}
case 203:{f.Pc=49;continue;}
case 206:{f.Push(f.Locals[5]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"com/google/common/collect/Multimap","asMap","()Ljava/util/Map;","invokeinterface",213);}
case 213:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",218);}
case 218:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",223);}
case 223:{f.Locals[8]=f.Pop();f.Pc=225;continue;}
case 225:{f.Push(f.Locals[8]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",232);}
case 232:{f.Pc=f.Pop().Int==0?321:235;continue;}
case 235:{f.Push(f.Locals[8]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",242);}
case 242:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=245;continue;}
case 245:{f.Locals[9]=f.Pop();f.Pc=247;continue;}
case 247:{f.Push(f.Locals[9]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",254);}
case 254:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",260);}
case 260:{f.Locals[10]=f.Pop();f.Pc=262;continue;}
case 262:{f.Push(f.Locals[10]);f.Pc=264;continue;}
case 264:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=267;continue;}
case 267:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=270;continue;}
case 270:{f.StackOp("dup");f.Pc=271;continue;}
case 271:{f.Push(f.Locals[9]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",278);}
case 278:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",284);}
case 284:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",289);}
case 289:{f.StackOp("pop");f.Pc=290;continue;}
case 290:{f.Push(f.Locals[10]);f.Pc=292;continue;}
case 292:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=295;continue;}
case 295:{f.Push(f.Locals[2]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",301);}
case 301:{f.StackOp("pop");f.Pc=302;continue;}
case 302:{f.Push(f.Locals[0]);f.Pc=303;continue;}
case 303:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",309);}
case 309:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","SacrificedOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","SacrificedOnce","Lforge/game/trigger/TriggerType;"));f.Pc=312;continue;}
case 312:{f.Push(f.Locals[10]);f.Pc=314;continue;}
case 314:{f.Push(JValue.I(0));f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",318);}
case 318:{f.Pc=225;continue;}
case 321:{f.Push(f.Locals[7]);f.Pc=323;continue;}
case 323:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2098(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","canBeDestroyed","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",13);}
case 13:{f.Locals[5]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[5]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Regeneration","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Regeneration","Lforge/game/ability/AbilityKey;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",36);}
case 36:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Reference==null?56:47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",56);}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",63);}
case 63:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Destroy","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Destroy","Lforge/game/replacement/ReplacementType;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",71);}
case 71:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=74;continue;}
case 74:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?79:77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 79:{f.Push(JValue.R(null));f.Pc=80;continue;}
case 80:{f.Locals[6]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{f.Pc=f.Pop().Reference==null?92:86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",90);}
case 90:{f.Locals[6]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=96;continue;}
case 96:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardDestroyed"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardDestroyed")));f.Pc=99;continue;}
case 99:{f.StackOp("dup");f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/event/GameEventCardDestroyed","<init>","()V","invokespecial",103);}
case 103:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",106);}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",110);}
case 110:{f.Locals[7]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[7]);f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Causer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Causer","Lforge/game/ability/AbilityKey;"));f.Pc=117;continue;}
case 117:{f.Push(f.Locals[6]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Push(f.Locals[4]);f.Pc=127;continue;}
case 127:{f.Pc=f.Pop().Reference==null?139:130;continue;}
case 130:{f.Push(f.Locals[7]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[4]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",139);}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",146);}
case 146:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Destroyed","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Destroyed","Lforge/game/trigger/TriggerType;"));f.Pc=149;continue;}
case 149:{f.Push(f.Locals[7]);f.Pc=151;continue;}
case 151:{f.Push(JValue.I(0));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",155);}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[2]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[4]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/GameAction","sacrificeDestroy","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",163);}
case 163:{f.Locals[8]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[8]);f.Pc=167;continue;}
case 167:{f.Pc=f.Pop().Reference==null?174:170;continue;}
case 170:{f.Push(JValue.I(1));f.Pc=171;continue;}
case 171:{f.Pc=175;continue;}
case 174:{f.Push(JValue.I(0));f.Pc=175;continue;}
case 175:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2099(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/GameAction","moveToGraveyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2100(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Collections","singleton","(Ljava/lang/Object;)Ljava/util/Set;","invokestatic",6);}
case 6:{return rt.Call(f,"forge/game/GameAction","revealTo","(Lforge/game/card/Card;Ljava/lang/Iterable;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2101(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;Ljava/lang/String;)V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2102(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Collections","singleton","(Ljava/lang/Object;)Ljava/util/Set;","invokestatic",6);}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Ljava/lang/Iterable;Ljava/lang/String;Z)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2103(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",9);}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Ljava/lang/Iterable;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2104(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Ljava/lang/Iterable;Ljava/lang/String;Z)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2105(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Int==0?10:9;continue;}
case 9:{return JStep.ReturnVoid;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardCollectionView","getFirst","()Ljava/lang/Object;","invokeinterface",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",25);}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/CardCollectionView","getFirst","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",39);}
case 39:{f.Locals[6]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",47);}
case 47:{f.Locals[7]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[7]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",56);}
case 56:{f.Pc=f.Pop().Int==0?90:59;continue;}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",66);}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{f.Locals[8]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[8]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",76);}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[3]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/player/PlayerController","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;Ljava/lang/String;Z)V","invokevirtual",87);}
case 87:{f.Pc=49;continue;}
case 90:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2106(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;Z)V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2107(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2108(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;Z)V","invokevirtual",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2109(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",5);}
case 5:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8;continue;}
case 8:{f.Locals[6]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[6]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference!=null?16:15;continue;}
case 15:{return JStep.ReturnVoid;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[6]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",30);}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;ZLjava/lang/String;Z)V","invokevirtual",39);}
case 39:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2110(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;ZLjava/lang/String;Z)V","invokevirtual",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2111(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",10);}
case 10:{f.Locals[7]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[7]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?66:22;continue;}
case 22:{f.Push(f.Locals[7]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[8]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{f.Pc=f.Pop().Int==0?48:39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[8]);f.Pc=42;continue;}
case 42:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?48:45;continue;}
case 45:{f.Pc=12;continue;}
case 48:{f.Push(f.Locals[8]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",53);}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/player/PlayerController","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;Ljava/lang/String;Z)V","invokevirtual",63);}
case 63:{f.Pc=12;continue;}
case 66:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2112(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?44:20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/player/PlayerController","revealAISkipCards","(Ljava/lang/String;Ljava/util/Map;)V","invokevirtual",41);}
case 41:{f.Pc=11;continue;}
case 44:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2113(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?44:20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/player/PlayerController","revealAnte","(Ljava/lang/String;Lcom/google/common/collect/Multimap;)V","invokevirtual",41);}
case 41:{f.Pc=11;continue;}
case 44:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2114(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?41:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",34);}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/player/PlayerController","revealUnsupported","(Ljava/util/Map;)V","invokevirtual",38);}
case 38:{f.Pc=11;continue;}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2115(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?39:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[5]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("NICKNAME")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",30);}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/util/Lang","getNickName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",35);}
case 35:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",38);}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",49);}
case 49:{f.Locals[5]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",58);}
case 58:{f.Pc=f.Pop().Int==0?97:61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",68);}
case 68:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=71;continue;}
case 71:{f.Locals[6]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[6]);f.Pc=77;continue;}
case 77:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?83:80;continue;}
case 80:{f.Pc=51;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",88);}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[3]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/player/PlayerController","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;)V","invokevirtual",94);}
case 94:{f.Pc=51;continue;}
case 97:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2116(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/card/CardCollectionView","threadSafeIterable","()Ljava/lang/Iterable;","invokeinterface",15);}
case 15:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/player/Player","getMaxHandSize","()I","invokevirtual",25);}
case 25:{return rt.Call(f,"java/util/List","subList","(II)Ljava/util/List;","invokeinterface",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/game/zone/PlayerZone","getCards","()Lforge/game/card/CardCollectionView;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/card/CardCollectionView","threadSafeIterable","()Ljava/lang/Iterable;","invokeinterface",46);}
case 46:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",49);}
case 49:{f.Locals[4]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",56);}
case 56:{return rt.Call(f,"java/util/Collections","shuffle","(Ljava/util/List;Ljava/util/Random;)V","invokestatic",59);}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/player/Player","getMaxHandSize","()I","invokevirtual",66);}
case 66:{return rt.Call(f,"java/util/List","subList","(II)Ljava/util/List;","invokeinterface",71);}
case 71:{f.Locals[5]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/GameAction","getLandRatio","(Ljava/util/List;)F","invokevirtual",78);}
case 78:{f.Locals[6]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[3]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/GameAction","getHandScore","(Ljava/util/List;F)F","invokevirtual",87);}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/GameAction","getHandScore","(Ljava/util/List;F)F","invokevirtual",95);}
case 95:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fcmpl",a,b));f.Pc=96;continue;}
case 96:{f.Pc=f.Pop().Int<=0?111:99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",106);}
case 106:{f.Push(f.Locals[4]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/zone/PlayerZone","setCards","(Ljava/lang/Iterable;)V","invokevirtual",111);}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/player/Player","getMaxHandSize","()I","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/game/player/Player","drawCards","(I)Lforge/game/card/CardCollectionView;","invokevirtual",119);}
case 119:{f.StackOp("pop");f.Pc=120;continue;}
case 120:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2117(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?43:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?40:37;continue;}
case 37:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=40;continue;}
case 40:{f.Pc=9;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Int!=0?49:47;continue;}
case 47:{f.Push(JValue.F(0));f.Pc=48;continue;}
case 48:{return JStep.Return(f.Pop());}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",57);}
case 57:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=58;continue;}
case 58:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fdiv",a,b));f.Pc=59;continue;}
case 59:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2118(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?46:20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?43:40;continue;}
case 40:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=43;continue;}
case 43:{f.Pc=10;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",53);}
case 53:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=54;continue;}
case 54:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fmul",a,b));f.Pc=55;continue;}
case 55:{f.Locals[4]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=61;continue;}
case 61:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"fsub",a,b));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/Math","abs","(F)F","invokestatic",65);}
case 65:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2119(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/GameAction","startGame","(Lforge/game/GameOutcome;Ljava/lang/Runnable;)V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2120(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameAction","determineFirstTurnPlayer","(Lforge/game/GameOutcome;)Lforge/game/player/Player;","invokevirtual",5);}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/GameRules","getGameType","()Lforge/game/GameType;","invokevirtual",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?31:28;continue;}
case 28:{f.Pc=454;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=35;continue;}
case 35:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventGameStarted"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventGameStarted")));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",49);}
case 49:{return rt.Call(f,"forge/game/event/GameEventGameStarted","<init>","(Lforge/game/GameType;Lforge/game/player/Player;Ljava/lang/Iterable;)V","invokespecial",52);}
case 52:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",55);}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/GameAction","runPreOpeningHandActions","(Lforge/game/player/Player;)V","invokevirtual",60);}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/game/GameStage","Mulligan","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","Mulligan","Lforge/game/GameStage;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/Game","setAge","(Lforge/game/GameStage;)V","invokevirtual",70);}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",77);}
case 77:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",80);}
case 80:{f.Locals[5]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",89);}
case 89:{f.Pc=f.Pop().Int==0?160:92;continue;}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{f.Locals[6]=f.Pop();f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",107);}
case 107:{return rt.Call(f,"forge/StaticData","getFilteredHandsEnabled","()Z","invokevirtual",110);}
case 110:{f.Pc=f.Pop().Int==0?122:113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[6]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/GameAction","drawStartingHand","(Lforge/game/player/Player;)V","invokevirtual",119);}
case 119:{f.Pc=133;continue;}
case 122:{f.Push(f.Locals[6]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[6]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/player/Player","getStartingHandSize","()I","invokevirtual",129);}
case 129:{return rt.Call(f,"forge/game/player/Player","drawCards","(I)Lforge/game/card/CardCollectionView;","invokevirtual",132);}
case 132:{f.StackOp("pop");f.Pc=133;continue;}
case 133:{if(!rt.EnsureInitialized(f,"forge/game/extrahands/BackupPlanService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/extrahands/BackupPlanService")));f.Pc=136;continue;}
case 136:{f.StackOp("dup");f.Pc=137;continue;}
case 137:{f.Push(f.Locals[6]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/extrahands/BackupPlanService","<init>","(Lforge/game/player/Player;)V","invokespecial",142);}
case 142:{f.Locals[7]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[7]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/extrahands/BackupPlanService","initializeExtraHands","()Z","invokevirtual",149);}
case 149:{f.Pc=f.Pop().Int==0?157:152;continue;}
case 152:{f.Push(f.Locals[7]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/extrahands/BackupPlanService","chooseHand","()V","invokevirtual",157);}
case 157:{f.Pc=82;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",167);}
case 167:{return rt.Call(f,"forge/game/GameRules","getGameType","()Lforge/game/GameType;","invokevirtual",170);}
case 170:{if(!rt.StaticReady(f,"forge/game/GameType","Puzzle","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Puzzle","Lforge/game/GameType;"));f.Pc=173;continue;}
case 173:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?187:176;continue;}
case 176:{if(!rt.EnsureInitialized(f,"forge/game/mulligan/MulliganService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mulligan/MulliganService")));f.Pc=179;continue;}
case 179:{f.StackOp("dup");f.Pc=180;continue;}
case 180:{f.Push(f.Locals[3]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/mulligan/MulliganService","<init>","(Lforge/game/player/Player;)V","invokespecial",184);}
case 184:{return rt.Call(f,"forge/game/mulligan/MulliganService","perform","()V","invokevirtual",187);}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/Game","isGameOver","()Z","invokevirtual",194);}
case 194:{f.Pc=f.Pop().Int==0?200:197;continue;}
case 197:{f.Pc=454;continue;}
case 200:{f.Push(f.Locals[0]);f.Pc=201;continue;}
case 201:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",207);}
case 207:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",210);}
case 210:{f.Locals[5]=f.Pop();f.Pc=212;continue;}
case 212:{f.Push(f.Locals[5]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",219);}
case 219:{f.Pc=f.Pop().Int==0?242:222;continue;}
case 222:{f.Push(f.Locals[5]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",229);}
case 229:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=232;continue;}
case 232:{f.Locals[6]=f.Pop();f.Pc=234;continue;}
case 234:{f.Push(f.Locals[6]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/player/Player","runStartGameScripts","()V","invokevirtual",239);}
case 239:{f.Pc=212;continue;}
case 242:{f.Push(f.Locals[0]);f.Pc=243;continue;}
case 243:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=246;continue;}
case 246:{if(!rt.StaticReady(f,"forge/game/GameStage","Play","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","Play","Lforge/game/GameStage;"));f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/Game","setAge","(Lforge/game/GameStage;)V","invokevirtual",252);}
case 252:{f.Push(f.Locals[0]);f.Pc=253;continue;}
case 253:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",259);}
case 259:{if(!rt.StaticReady(f,"forge/game/GameType","Planechase","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Planechase","Lforge/game/GameType;"));f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/GameRules","hasAppliedVariant","(Lforge/game/GameType;)Z","invokevirtual",265);}
case 265:{f.Pc=f.Pop().Int==0?318:268;continue;}
case 268:{f.Push(f.Locals[3]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/player/Player","initPlane","()V","invokevirtual",272);}
case 272:{f.Push(f.Locals[0]);f.Pc=273;continue;}
case 273:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",279);}
case 279:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",282);}
case 282:{f.Locals[5]=f.Pop();f.Pc=284;continue;}
case 284:{f.Push(f.Locals[5]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",291);}
case 291:{f.Pc=f.Pop().Int==0?318:294;continue;}
case 294:{f.Push(f.Locals[5]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",301);}
case 301:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=304;continue;}
case 304:{f.Locals[6]=f.Pop();f.Pc=306;continue;}
case 306:{f.Push(f.Locals[6]);f.Pc=308;continue;}
case 308:{f.Push(f.Locals[0]);f.Pc=309;continue;}
case 309:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/player/Player","createPlanechaseEffects","(Lforge/game/Game;)V","invokevirtual",315);}
case 315:{f.Pc=284;continue;}
case 318:{f.Push(f.Locals[0]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[3]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/GameAction","runOpeningHandActions","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",323);}
case 323:{f.Locals[3]=f.Pop();f.Pc=324;continue;}
case 324:{f.Push(f.Locals[0]);f.Pc=325;continue;}
case 325:{f.Push(JValue.I(1));f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/GameAction","checkStateEffects","(Z)Z","invokevirtual",329);}
case 329:{f.StackOp("pop");f.Pc=330;continue;}
case 330:{f.Push(f.Locals[0]);f.Pc=331;continue;}
case 331:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",337);}
case 337:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","NewGame","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","NewGame","Lforge/game/trigger/TriggerType;"));f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",343);}
case 343:{f.Push(JValue.I(1));f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",347);}
case 347:{f.Push(f.Locals[0]);f.Pc=348;continue;}
case 348:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=351;continue;}
case 351:{f.Push(f.Locals[3]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/Game","setStartingPlayer","(Lforge/game/player/Player;)V","invokevirtual",355);}
case 355:{f.Push(f.Locals[0]);f.Pc=356;continue;}
case 356:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",362);}
case 362:{f.Push(f.Locals[3]);f.Pc=363;continue;}
case 363:{f.Push(f.Locals[2]);f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/phase/PhaseHandler","startFirstTurn","(Lforge/game/player/Player;Ljava/lang/Runnable;)V","invokevirtual",367);}
case 367:{f.Push(f.Locals[0]);f.Pc=368;continue;}
case 368:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",374);}
case 374:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",377);}
case 377:{f.Locals[5]=f.Pop();f.Pc=379;continue;}
case 379:{f.Push(f.Locals[5]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",386);}
case 386:{f.Pc=f.Pop().Int==0?430:389;continue;}
case 389:{f.Push(f.Locals[5]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",396);}
case 396:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=399;continue;}
case 399:{f.Locals[6]=f.Pop();f.Pc=401;continue;}
case 401:{f.Push(f.Locals[6]);f.Pc=403;continue;}
case 403:{f.Push(f.Locals[6]);f.Pc=405;continue;}
case 405:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",411);}
case 411:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",416);}
case 416:{return rt.Call(f,"forge/game/player/Player","setNumCardsInHandStartedThisTurnWith","(I)V","invokevirtual",419);}
case 419:{f.Push(f.Locals[6]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",424);}
case 424:{return rt.Call(f,"forge/game/player/PlayerController","autoPassCancel","()V","invokevirtual",427);}
case 427:{f.Pc=379;continue;}
case 430:{f.Push(f.Locals[0]);f.Pc=431;continue;}
case 431:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=434;continue;}
case 434:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",437);}
case 437:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",440);}
case 440:{f.Locals[3]=f.Pop();f.Pc=441;continue;}
case 441:{f.Push(f.Locals[0]);f.Pc=442;continue;}
case 442:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/game/Game","getAge","()Lforge/game/GameStage;","invokevirtual",448);}
case 448:{if(!rt.StaticReady(f,"forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;"));f.Pc=451;continue;}
case 451:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?18:454;continue;}
case 454:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2121(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?104:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/GameRules","getGameType","()Lforge/game/GameType;","invokevirtual",19);}
case 19:{if(!rt.StaticReady(f,"forge/game/GameType","Puzzle","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Puzzle","Lforge/game/GameType;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/GameType","equals","(Ljava/lang/Object;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?43:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",35);}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",50);}
case 50:{if(!rt.StaticReady(f,"forge/game/GameType","Archenemy","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Archenemy","Lforge/game/GameType;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/GameRules","hasAppliedVariant","(Lforge/game/GameType;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?104:59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",66);}
case 66:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",69);}
case 69:{f.Locals[3]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?104:79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{f.Locals[4]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/player/Player","isArchenemy","()Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?101:98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{return JStep.Return(f.Pop());}
case 101:{f.Pc=70;continue;}
case 104:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",107);}
case 107:{f.Locals[3]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=112;continue;}
case 112:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",118);}
case 118:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",123);}
case 123:{f.Locals[4]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[4]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",132);}
case 132:{f.Pc=f.Pop().Int==0?176:135;continue;}
case 135:{f.Push(f.Locals[4]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",142);}
case 142:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=145;continue;}
case 145:{f.Locals[5]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[5]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",152);}
case 152:{f.Push(JValue.R(rt.String("Power Play")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int==0?173:161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[5]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",167);}
case 167:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",172);}
case 172:{f.StackOp("pop");f.Pc=173;continue;}
case 173:{f.Pc=125;continue;}
case 176:{f.Push(f.Locals[3]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",182);}
case 182:{f.Pc=f.Pop().Int!=0?211:185;continue;}
case 185:{f.Push(f.Locals[3]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",189);}
case 189:{f.Locals[4]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[4]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",196);}
case 196:{return rt.Call(f,"java/util/Collections","shuffle","(Ljava/util/List;Ljava/util/Random;)V","invokestatic",199);}
case 199:{f.Push(f.Locals[4]);f.Pc=201;continue;}
case 201:{f.Push(JValue.I(0));f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",207);}
case 207:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=210;continue;}
case 210:{return JStep.Return(f.Pop());}
case 211:{f.Push(f.Locals[1]);f.Pc=212;continue;}
case 212:{f.Pc=f.Pop().Reference!=null?219:215;continue;}
case 215:{f.Push(JValue.I(1));f.Pc=216;continue;}
case 216:{f.Pc=220;continue;}
case 219:{f.Push(JValue.I(0));f.Pc=220;continue;}
case 220:{f.Locals[4]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[4]);f.Pc=224;continue;}
case 224:{f.Pc=f.Pop().Int==0?244:227;continue;}
case 227:{f.Push(f.Locals[0]);f.Pc=228;continue;}
case 228:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",234);}
case 234:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",237);}
case 237:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=240;continue;}
case 240:{f.Locals[2]=f.Pop();f.Pc=241;continue;}
case 241:{f.Pc=299;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",251);}
case 251:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",254);}
case 254:{f.Locals[5]=f.Pop();f.Pc=256;continue;}
case 256:{f.Push(f.Locals[5]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",263);}
case 263:{f.Pc=f.Pop().Int==0?299:266;continue;}
case 266:{f.Push(f.Locals[5]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",273);}
case 273:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=276;continue;}
case 276:{f.Locals[6]=f.Pop();f.Pc=278;continue;}
case 278:{f.Push(f.Locals[1]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[6]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/player/Player","getRegisteredPlayer","()Lforge/game/player/RegisteredPlayer;","invokevirtual",284);}
case 284:{return rt.Call(f,"forge/game/GameOutcome","isWinner","(Lforge/game/player/RegisteredPlayer;)Z","invokevirtual",287);}
case 287:{f.Pc=f.Pop().Int!=0?296:290;continue;}
case 290:{f.Push(f.Locals[6]);f.Pc=292;continue;}
case 292:{f.Locals[2]=f.Pop();f.Pc=293;continue;}
case 293:{f.Pc=299;continue;}
case 296:{f.Pc=256;continue;}
case 299:{f.Push(f.Locals[2]);f.Pc=300;continue;}
case 300:{f.Pc=f.Pop().Reference!=null?318:303;continue;}
case 303:{f.Push(f.Locals[0]);f.Pc=304;continue;}
case 304:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",310);}
case 310:{f.Push(JValue.I(0));f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",314);}
case 314:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=317;continue;}
case 317:{f.Locals[2]=f.Pop();f.Pc=318;continue;}
case 318:{f.Push(f.Locals[4]);f.Pc=320;continue;}
case 320:{f.Pc=f.Pop().Int==0?343:323;continue;}
case 323:{f.Push(f.Locals[0]);f.Pc=324;continue;}
case 324:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=327;continue;}
case 327:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventFlipCoin"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventFlipCoin")));f.Pc=330;continue;}
case 330:{f.StackOp("dup");f.Pc=331;continue;}
case 331:{f.Push(f.Locals[2]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/player/Player","getView","()Lforge/game/player/PlayerView;","invokevirtual",335);}
case 335:{f.Push(JValue.I(1));f.Pc=336;continue;}
case 336:{f.Push(JValue.I(1));f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/event/GameEventFlipCoin","<init>","(Lforge/game/player/PlayerView;ZZ)V","invokespecial",340);}
case 340:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",343);}
case 343:{f.Push(f.Locals[0]);f.Pc=344;continue;}
case 344:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",350);}
case 350:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",353);}
case 353:{f.Locals[5]=f.Pop();f.Pc=355;continue;}
case 355:{f.Push(f.Locals[5]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",362);}
case 362:{f.Pc=f.Pop().Int==0?394:365;continue;}
case 365:{f.Push(f.Locals[5]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",372);}
case 372:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=375;continue;}
case 375:{f.Locals[6]=f.Pop();f.Pc=377;continue;}
case 377:{f.Push(f.Locals[6]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[2]);f.Pc=380;continue;}
case 380:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?391:383;continue;}
case 383:{f.Push(f.Locals[6]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",388);}
case 388:{return rt.Call(f,"forge/game/player/PlayerController","awaitNextInput","()V","invokevirtual",391);}
case 391:{f.Pc=355;continue;}
case 394:{f.Push(f.Locals[2]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",398);}
case 398:{f.Push(f.Locals[4]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"forge/game/player/PlayerController","chooseStartingPlayer","(Z)Lforge/game/player/Player;","invokevirtual",403);}
case 403:{f.Locals[2]=f.Pop();f.Pc=404;continue;}
case 404:{f.Push(f.Locals[2]);f.Pc=405;continue;}
case 405:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2122(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",9);}
case 9:{return rt.DynamicCall(f,"forge/game/GameAction:2122:9:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",14);}
case 14:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/Game","getCardsInGame","()Lforge/game/card/CardCollectionView;","invokevirtual",25);}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",29);}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.DynamicCall(f,"forge/game/GameAction:2122:33:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",38);}
case 38:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",41);}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{f.Locals[6]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(JValue.I(3));f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Integer;",f.Pop().Int)));f.Pc=50;continue;}
case 50:{f.StackOp("dup");f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",56);}
case 56:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{f.Push(JValue.I(2));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",63);}
case 63:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=64;continue;}
case 64:{f.StackOp("dup");f.Pc=65;continue;}
case 65:{f.Push(JValue.I(2));f.Pc=66;continue;}
case 66:{f.Push(JValue.I(3));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",70);}
case 70:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=71;continue;}
case 71:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",74);}
case 74:{f.Locals[7]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",82);}
case 82:{f.Locals[8]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[8]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",91);}
case 91:{f.Pc=f.Pop().Int==0?175:94;continue;}
case 94:{f.Push(f.Locals[8]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",101);}
case 101:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=104;continue;}
case 104:{f.Locals[9]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[7]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",113);}
case 113:{f.Pc=f.Pop().Int!=0?165:116;continue;}
case 116:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=119;continue;}
case 119:{f.StackOp("dup");f.Pc=120;continue;}
case 120:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ChooseNumber","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ChooseNumber","Lforge/game/ability/ApiType;"));f.Pc=123;continue;}
case 123:{f.Push(f.Locals[9]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/player/Player;)V","invokespecial",129);}
case 129:{f.Locals[10]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",135);}
case 135:{f.Push(f.Locals[10]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("Emissary's Ploy")));f.Pc=140;continue;}
case 140:{f.Push(f.Locals[7]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[9]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",147);}
case 147:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/List;Lforge/game/player/Player;)I","invokevirtual",150);}
case 150:{f.Locals[6]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[7]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[6]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",159);}
case 159:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",164);}
case 164:{f.StackOp("pop");f.Pc=165;continue;}
case 165:{f.Push(f.Locals[9]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[6]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/card/Card","setChosenNumber","(I)V","invokevirtual",172);}
case 172:{f.Pc=84;continue;}
case 175:{f.Push(f.Locals[5]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",182);}
case 182:{f.Locals[8]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[8]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",191);}
case 191:{f.Pc=f.Pop().Int==0?304:194;continue;}
case 194:{f.Push(f.Locals[8]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",201);}
case 201:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=204;continue;}
case 204:{f.Locals[9]=f.Pop();f.Pc=206;continue;}
case 206:{f.Push(f.Locals[9]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/card/Card","hasMarkedColor","()Z","invokevirtual",211);}
case 211:{f.Pc=f.Pop().Int!=0?301:214;continue;}
case 214:{f.Push(f.Locals[2]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/player/Player","isAI","()Z","invokevirtual",218);}
case 218:{f.Pc=f.Pop().Int==0?301:221;continue;}
case 221:{f.Push(f.Locals[9]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",226);}
case 226:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",229);}
case 229:{f.Push(JValue.R(rt.String("lblChooseNColors")));f.Pc=232;continue;}
case 232:{f.Push(JValue.I(1));f.Pc=233;continue;}
case 233:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=236;continue;}
case 236:{f.StackOp("dup");f.Pc=237;continue;}
case 237:{f.Push(JValue.I(0));f.Pc=238;continue;}
case 238:{f.Push(JValue.I(2));f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",242);}
case 242:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",246);}
case 246:{return rt.DynamicCall(f,"forge/game/GameAction:2122:246:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",251);}
case 251:{f.Locals[10]=f.Pop();f.Pc=253;continue;}
case 253:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=256;continue;}
case 256:{f.StackOp("dup");f.Pc=257;continue;}
case 257:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ChooseColor","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ChooseColor","Lforge/game/ability/ApiType;"));f.Pc=260;continue;}
case 260:{f.Push(f.Locals[9]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[2]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/player/Player;)V","invokespecial",266);}
case 266:{f.Locals[11]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[11]);f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("AILogic")));f.Pc=273;continue;}
case 273:{f.Push(JValue.R(rt.String("MostProminentInComputerDeck")));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",279);}
case 279:{f.StackOp("pop");f.Pc=280;continue;}
case 280:{f.Push(f.Locals[9]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[2]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",286);}
case 286:{f.Push(f.Locals[10]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[11]);f.Pc=290;continue;}
case 290:{f.Push(JValue.I(2));f.Pc=291;continue;}
case 291:{f.Push(JValue.I(2));f.Pc=292;continue;}
case 292:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"));f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/player/PlayerController","chooseColors","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;IILforge/card/ColorSet;)Lforge/card/ColorSet;","invokevirtual",298);}
case 298:{return rt.Call(f,"forge/game/card/Card","setMarkedColors","(Lforge/card/ColorSet;)V","invokevirtual",301);}
case 301:{f.Pc=184;continue;}
case 304:{f.Push(f.Locals[0]);f.Pc=305;continue;}
case 305:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=308;continue;}
case 308:{f.Push(f.Locals[2]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",312);}
case 312:{f.Locals[2]=f.Pop();f.Pc=313;continue;}
case 313:{f.Push(f.Locals[2]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[1]);f.Pc=315;continue;}
case 315:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?2:318;continue;}
case 318:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2123(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?179:33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[6]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",50);}
case 50:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",55);}
case 55:{f.Locals[7]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[7]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",64);}
case 64:{f.Pc=f.Pop().Int==0?176:67;continue;}
case 67:{f.Push(f.Locals[7]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Locals[8]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[8]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",86);}
case 86:{f.Locals[9]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[9]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("MayEffectFromOpeningHand")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?173:99;continue;}
case 99:{f.Push(f.Locals[9]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String(":")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",107);}
case 107:{f.Locals[10]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[10]);f.Pc=111;continue;}
case 111:{f.Push(JValue.I(1));f.Pc=112;continue;}
case 112:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=113;continue;}
case 113:{f.Locals[11]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[10]);f.Pc=117;continue;}
case 117:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=118;continue;}
case 118:{f.Push(JValue.I(2));f.Pc=119;continue;}
case 119:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?143:122;continue;}
case 122:{f.Push(f.Locals[10]);f.Pc=124;continue;}
case 124:{f.Push(JValue.I(2));f.Pc=125;continue;}
case 125:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("!PlayFirst")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",132);}
case 132:{f.Pc=f.Pop().Int==0?143:135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[2]);f.Pc=137;continue;}
case 137:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?143:140;continue;}
case 140:{f.Pc=57;continue;}
case 143:{f.Push(f.Locals[6]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[11]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",150);}
case 150:{f.Push(f.Locals[6]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",155);}
case 155:{f.Locals[12]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[12]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[2]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",163);}
case 163:{f.Push(f.Locals[4]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[12]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",172);}
case 172:{f.StackOp("pop");f.Pc=173;continue;}
case 173:{f.Pc=57;continue;}
case 176:{f.Pc=23;continue;}
case 179:{f.Push(f.Locals[4]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",186);}
case 186:{f.Pc=f.Pop().Int!=0?200:189;continue;}
case 189:{f.Push(f.Locals[2]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",193);}
case 193:{f.Push(f.Locals[4]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/player/PlayerController","chooseSaToActivateFromOpeningHand","(Ljava/util/List;)Ljava/util/List;","invokevirtual",198);}
case 198:{f.Locals[4]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(f.Locals[4]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",207);}
case 207:{f.Locals[5]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[5]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",216);}
case 216:{f.Pc=f.Pop().Int==0?278:219;continue;}
case 219:{f.Push(f.Locals[5]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",226);}
case 226:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=229;continue;}
case 229:{f.Locals[6]=f.Pop();f.Pc=231;continue;}
case 231:{f.Push(f.Locals[2]);f.Pc=232;continue;}
case 232:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",238);}
case 238:{f.Push(f.Locals[6]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",243);}
case 243:{return rt.Call(f,"forge/game/zone/PlayerZone","contains","(Lforge/game/card/Card;)Z","invokevirtual",246);}
case 246:{f.Pc=f.Pop().Int!=0?252:249;continue;}
case 249:{f.Pc=209;continue;}
case 252:{f.Push(f.Locals[2]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",256);}
case 256:{f.Push(f.Locals[6]);f.Pc=258;continue;}
case 258:{f.Push(JValue.I(1));f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/player/PlayerController","playSpellAbilityNoStack","(Lforge/game/spellability/SpellAbility;Z)V","invokevirtual",262);}
case 262:{f.Push(f.Locals[6]);f.Pc=264;continue;}
case 264:{f.Push(JValue.R(rt.String("BecomeStartingPlayer")));f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",270);}
case 270:{f.Pc=f.Pop().Int==0?275:273;continue;}
case 273:{f.Push(f.Locals[2]);f.Pc=274;continue;}
case 274:{f.Locals[3]=f.Pop();f.Pc=275;continue;}
case 275:{f.Pc=209;continue;}
case 278:{f.Push(f.Locals[0]);f.Pc=279;continue;}
case 279:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=282;continue;}
case 282:{f.Push(f.Locals[2]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",286);}
case 286:{f.Locals[2]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[2]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[1]);f.Pc=289;continue;}
case 289:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?4:292;continue;}
case 292:{f.Push(f.Locals[3]);f.Pc=293;continue;}
case 293:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2124(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/ThreadUtil","isGameThread","()Z","invokestatic",3);}
case 3:{f.Pc=f.Pop().Int==0?15:6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Runnable","run","()V","invokeinterface",12);}
case 12:{f.Pc=19;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/util/ThreadUtil","invokeInGameThread","(Ljava/lang/Runnable;)V","invokestatic",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2125(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getMonarch","()Lforge/game/player/Player;","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?20:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?21:20;continue;}
case 20:{return JStep.ReturnVoid;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference==null?29:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/player/Player","removeMonarchEffect","()V","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/player/Player","canBecomeMonarch","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?37:36;continue;}
case 36:{return JStep.ReturnVoid;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/player/Player","createMonarchEffect","(Ljava/lang/String;)V","invokevirtual",42);}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/Game","setMonarch","(Lforge/game/player/Player;)V","invokevirtual",50);}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",54);}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",63);}
case 63:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","BecomeMonarch","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","BecomeMonarch","Lforge/game/trigger/TriggerType;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",72);}
case 72:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2126(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getHasInitiative","()Lforge/game/player/Player;","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference!=null?13:12;continue;}
case 12:{return JStep.ReturnVoid;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?63:21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference==null?29:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/player/Player","removeInitiativeEffect","()V","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/player/Player","hasLost","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?50:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokevirtual",45);}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/GameAction","takeInitiative","(Lforge/game/player/Player;Ljava/lang/String;)V","invokevirtual",49);}
case 49:{return JStep.ReturnVoid;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/Game","setHasInitiative","(Lforge/game/player/Player;)V","invokevirtual",58);}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/player/Player","createInitiativeEffect","(Ljava/lang/String;)V","invokevirtual",63);}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",67);}
case 67:{f.Locals[4]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",76);}
case 76:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TakesInitiative","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TakesInitiative","Lforge/game/trigger/TriggerType;"));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",85);}
case 85:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2127(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int>0?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{return rt.Call(f,"com/google/common/collect/Maps","newLinkedHashMap","()Ljava/util/LinkedHashMap;","invokestatic",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?204:28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Locals[7]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",48);}
case 48:{f.Locals[8]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[8]);f.Pc=52;continue;}
case 52:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[8]);f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Num","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Num","Lforge/game/ability/AbilityKey;"));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[7]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",72);}
case 72:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",88);}
case 88:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Scry","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Scry","Lforge/game/replacement/ReplacementType;"));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[8]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",96);}
case 96:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",99);}
case 99:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=100;continue;}
case 100:{switch(f.Pop().Int){case 1:f.Pc=128;break;case 2:f.Pc=131;break;default:f.Pc=152;break;}continue;}
case 128:{f.Pc=155;continue;}
case 131:{f.Push(f.Locals[8]);f.Pc=133;continue;}
case 133:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Num","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Num","Lforge/game/ability/AbilityKey;"));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",141);}
case 141:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",147);}
case 147:{f.Locals[7]=f.Pop();f.Pc=149;continue;}
case 149:{f.Pc=155;continue;}
case 152:{f.Pc=18;continue;}
case 155:{f.Push(f.Locals[7]);f.Pc=157;continue;}
case 157:{f.Pc=f.Pop().Int<=0?201:160;continue;}
case 160:{f.Push(f.Locals[4]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[6]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[7]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",169);}
case 169:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",174);}
case 174:{f.StackOp("pop");f.Pc=175;continue;}
case 175:{f.Push(f.Locals[1]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",181);}
case 181:{f.Push(JValue.I(1));f.Pc=182;continue;}
case 182:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?201:185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[6]);f.Pc=188;continue;}
case 188:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=191;continue;}
case 191:{f.Push(f.Locals[7]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;I)Lforge/game/card/CardCollectionView;","invokevirtual",196);}
case 196:{f.Push(f.Locals[6]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;)V","invokevirtual",201);}
case 201:{f.Pc=18;continue;}
case 204:{return rt.Call(f,"com/google/common/collect/Maps","newLinkedHashMap","()Ljava/util/LinkedHashMap;","invokestatic",207);}
case 207:{f.Locals[5]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[4]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",216);}
case 216:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",221);}
case 221:{f.Locals[6]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(f.Locals[6]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",230);}
case 230:{f.Pc=f.Pop().Int==0?387:233;continue;}
case 233:{f.Push(f.Locals[6]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",240);}
case 240:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=243;continue;}
case 243:{f.Locals[7]=f.Pop();f.Pc=245;continue;}
case 245:{f.Push(f.Locals[7]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",252);}
case 252:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=255;continue;}
case 255:{f.Locals[8]=f.Pop();f.Pc=257;continue;}
case 257:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=260;continue;}
case 260:{f.StackOp("dup");f.Pc=261;continue;}
case 261:{f.Push(f.Locals[8]);f.Pc=263;continue;}
case 263:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=266;continue;}
case 266:{f.Push(f.Locals[7]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",273);}
case 273:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",279);}
case 279:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;I)Lforge/game/card/CardCollectionView;","invokevirtual",282);}
case 282:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",285);}
case 285:{f.Locals[9]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[8]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",292);}
case 292:{f.Push(f.Locals[9]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/player/PlayerController","arrangeForScry","(Lforge/game/card/CardCollection;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokevirtual",297);}
case 297:{f.Locals[10]=f.Pop();f.Pc=299;continue;}
case 299:{f.Push(f.Locals[5]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[8]);f.Pc=303;continue;}
case 303:{f.Push(f.Locals[10]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",310);}
case 310:{f.StackOp("pop");f.Pc=311;continue;}
case 311:{f.Push(f.Locals[10]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","getLeft","()Ljava/lang/Object;","invokevirtual",316);}
case 316:{f.Pc=f.Pop().Reference!=null?323:319;continue;}
case 319:{f.Push(JValue.I(0));f.Pc=320;continue;}
case 320:{f.Pc=334;continue;}
case 323:{f.Push(f.Locals[10]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","getLeft","()Ljava/lang/Object;","invokevirtual",328);}
case 328:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",334);}
case 334:{f.Locals[11]=f.Pop();f.Pc=336;continue;}
case 336:{f.Push(f.Locals[10]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","getRight","()Ljava/lang/Object;","invokevirtual",341);}
case 341:{f.Pc=f.Pop().Reference!=null?348:344;continue;}
case 344:{f.Push(JValue.I(0));f.Pc=345;continue;}
case 345:{f.Pc=359;continue;}
case 348:{f.Push(f.Locals[10]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","getRight","()Ljava/lang/Object;","invokevirtual",353);}
case 353:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=356;continue;}
case 356:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",359);}
case 359:{f.Locals[12]=f.Pop();f.Pc=361;continue;}
case 361:{f.Push(f.Locals[0]);f.Pc=362;continue;}
case 362:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=365;continue;}
case 365:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventScry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventScry")));f.Pc=368;continue;}
case 368:{f.StackOp("dup");f.Pc=369;continue;}
case 369:{f.Push(f.Locals[8]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",374);}
case 374:{f.Push(f.Locals[11]);f.Pc=376;continue;}
case 376:{f.Push(f.Locals[12]);f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/event/GameEventScry","<init>","(Lforge/game/player/PlayerView;II)V","invokespecial",381);}
case 381:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",384);}
case 384:{f.Pc=223;continue;}
case 387:{f.Push(f.Locals[5]);f.Pc=389;continue;}
case 389:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",394);}
case 394:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",399);}
case 399:{f.Locals[6]=f.Pop();f.Pc=401;continue;}
case 401:{f.Push(f.Locals[6]);f.Pc=403;continue;}
case 403:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",408);}
case 408:{f.Pc=f.Pop().Int==0?670:411;continue;}
case 411:{f.Push(f.Locals[6]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",418);}
case 418:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=421;continue;}
case 421:{f.Locals[7]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(f.Locals[7]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",430);}
case 430:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=433;continue;}
case 433:{f.Locals[8]=f.Pop();f.Pc=435;continue;}
case 435:{f.Push(f.Locals[7]);f.Pc=437;continue;}
case 437:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",442);}
case 442:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/ImmutablePair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=445;continue;}
case 445:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","getLeft","()Ljava/lang/Object;","invokevirtual",448);}
case 448:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=451;continue;}
case 451:{f.Locals[9]=f.Pop();f.Pc=453;continue;}
case 453:{f.Push(f.Locals[7]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",460);}
case 460:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/ImmutablePair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=463;continue;}
case 463:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","getRight","()Ljava/lang/Object;","invokevirtual",466);}
case 466:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=469;continue;}
case 469:{f.Locals[10]=f.Pop();f.Pc=471;continue;}
case 471:{f.Push(JValue.I(0));f.Pc=472;continue;}
case 472:{f.Locals[11]=f.Pop();f.Pc=474;continue;}
case 474:{f.Push(f.Locals[9]);f.Pc=476;continue;}
case 476:{f.Pc=f.Pop().Reference==null?535:479;continue;}
case 479:{f.Push(f.Locals[11]);f.Pc=481;continue;}
case 481:{f.Push(f.Locals[9]);f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",486);}
case 486:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=487;continue;}
case 487:{f.Locals[11]=f.Pop();f.Pc=489;continue;}
case 489:{f.Push(f.Locals[9]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"java/util/Collections","reverse","(Ljava/util/List;)V","invokestatic",494);}
case 494:{f.Push(f.Locals[9]);f.Pc=496;continue;}
case 496:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",499);}
case 499:{f.Locals[12]=f.Pop();f.Pc=501;continue;}
case 501:{f.Push(f.Locals[12]);f.Pc=503;continue;}
case 503:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",508);}
case 508:{f.Pc=f.Pop().Int==0?535:511;continue;}
case 511:{f.Push(f.Locals[12]);f.Pc=513;continue;}
case 513:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",518);}
case 518:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=521;continue;}
case 521:{f.Locals[13]=f.Pop();f.Pc=523;continue;}
case 523:{f.Push(f.Locals[0]);f.Pc=524;continue;}
case 524:{f.Push(f.Locals[13]);f.Pc=526;continue;}
case 526:{f.Push(f.Locals[3]);f.Pc=527;continue;}
case 527:{f.Push(JValue.R(null));f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",531);}
case 531:{f.StackOp("pop");f.Pc=532;continue;}
case 532:{f.Pc=501;continue;}
case 535:{f.Push(f.Locals[10]);f.Pc=537;continue;}
case 537:{f.Pc=f.Pop().Reference==null?591:540;continue;}
case 540:{f.Push(f.Locals[11]);f.Pc=542;continue;}
case 542:{f.Push(f.Locals[10]);f.Pc=544;continue;}
case 544:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",547);}
case 547:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=548;continue;}
case 548:{f.Locals[11]=f.Pop();f.Pc=550;continue;}
case 550:{f.Push(f.Locals[10]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",555);}
case 555:{f.Locals[12]=f.Pop();f.Pc=557;continue;}
case 557:{f.Push(f.Locals[12]);f.Pc=559;continue;}
case 559:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",564);}
case 564:{f.Pc=f.Pop().Int==0?591:567;continue;}
case 567:{f.Push(f.Locals[12]);f.Pc=569;continue;}
case 569:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",574);}
case 574:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=577;continue;}
case 577:{f.Locals[13]=f.Pop();f.Pc=579;continue;}
case 579:{f.Push(f.Locals[0]);f.Pc=580;continue;}
case 580:{f.Push(f.Locals[13]);f.Pc=582;continue;}
case 582:{f.Push(f.Locals[3]);f.Pc=583;continue;}
case 583:{f.Push(JValue.R(null));f.Pc=584;continue;}
case 584:{return rt.Call(f,"forge/game/GameAction","moveToBottomOfLibrary","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",587);}
case 587:{f.StackOp("pop");f.Pc=588;continue;}
case 588:{f.Pc=557;continue;}
case 591:{f.Push(f.Locals[3]);f.Pc=592;continue;}
case 592:{f.Pc=f.Pop().Reference==null?662:595;continue;}
case 595:{f.Push(f.Locals[8]);f.Pc=597;continue;}
case 597:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",600);}
case 600:{f.Locals[12]=f.Pop();f.Pc=602;continue;}
case 602:{f.Push(f.Locals[12]);f.Pc=604;continue;}
case 604:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ScryNum","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ScryNum","Lforge/game/ability/AbilityKey;"));f.Pc=607;continue;}
case 607:{f.Push(f.Locals[11]);f.Pc=609;continue;}
case 609:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",612);}
case 612:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",617);}
case 617:{f.StackOp("pop");f.Pc=618;continue;}
case 618:{f.Push(f.Locals[12]);f.Pc=620;continue;}
case 620:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ScryBottom","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ScryBottom","Lforge/game/ability/AbilityKey;"));f.Pc=623;continue;}
case 623:{f.Push(f.Locals[10]);f.Pc=625;continue;}
case 625:{f.Pc=f.Pop().Reference!=null?632:628;continue;}
case 628:{f.Push(JValue.I(0));f.Pc=629;continue;}
case 629:{f.Pc=637;continue;}
case 632:{f.Push(f.Locals[10]);f.Pc=634;continue;}
case 634:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",637);}
case 637:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",640);}
case 640:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",645);}
case 645:{f.StackOp("pop");f.Pc=646;continue;}
case 646:{f.Push(f.Locals[0]);f.Pc=647;continue;}
case 647:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=650;continue;}
case 650:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",653);}
case 653:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Scry","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Scry","Lforge/game/trigger/TriggerType;"));f.Pc=656;continue;}
case 656:{f.Push(f.Locals[12]);f.Pc=658;continue;}
case 658:{f.Push(JValue.I(0));f.Pc=659;continue;}
case 659:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",662);}
case 662:{f.Push(f.Locals[8]);f.Pc=664;continue;}
case 664:{return rt.Call(f,"forge/game/player/Player","incScryThisTurn","()V","invokevirtual",667);}
case 667:{f.Pc=401;continue;}
case 670:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2128(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Reference==null?20:5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("ShowMilledCards")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?20:16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Pc=21;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Locals[6]=f.Pop();f.Pc=23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",30);}
case 30:{f.Locals[7]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",36);}
case 36:{f.Locals[8]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[8]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",45);}
case 45:{f.Pc=f.Pop().Int==0?221:48;continue;}
case 48:{f.Push(f.Locals[8]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",55);}
case 55:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=58;continue;}
case 58:{f.Locals[9]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[9]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int!=0?71:68;continue;}
case 68:{f.Pc=38;continue;}
case 71:{f.Push(f.Locals[9]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/player/Player","mill","(ILforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",82);}
case 82:{f.Locals[10]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[10]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",91);}
case 91:{f.StackOp("pop");f.Pc=92;continue;}
case 92:{f.Push(f.Locals[3]);f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int==0?108:102;continue;}
case 102:{f.Push(JValue.R(rt.String("")));f.Pc=105;continue;}
case 105:{f.Pc=133;continue;}
case 108:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",111);}
case 111:{f.Push(JValue.R(rt.String("lblMilledToZone")));f.Pc=114;continue;}
case 114:{f.Push(JValue.I(1));f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",124);}
case 124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",128);}
case 128:{return rt.DynamicCall(f,"forge/game/GameAction:2128:128:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",133);}
case 133:{f.Locals[11]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[6]);f.Pc=137;continue;}
case 137:{f.Pc=f.Pop().Int==0?184:140;continue;}
case 140:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",143);}
case 143:{f.Push(JValue.R(rt.String("lblMilledCards")));f.Pc=146;continue;}
case 146:{f.Push(JValue.I(0));f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",153);}
case 153:{f.Locals[12]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[11]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int!=0?167:163;continue;}
case 163:{f.Push(JValue.I(1));f.Pc=164;continue;}
case 164:{f.Pc=168;continue;}
case 167:{f.Push(JValue.I(0));f.Pc=168;continue;}
case 168:{f.Locals[13]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[10]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[3]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[9]);f.Pc=176;continue;}
case 176:{f.Push(JValue.I(0));f.Pc=177;continue;}
case 177:{f.Push(f.Locals[12]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[13]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;ZLjava/lang/String;Z)V","invokevirtual",184);}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=188;continue;}
case 188:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=191;continue;}
case 191:{f.StackOp("dup");f.Pc=192;continue;}
case 192:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;"));f.Pc=195;continue;}
case 195:{f.Push(f.Locals[9]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",200);}
case 200:{f.Push(f.Locals[10]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",205);}
case 205:{f.Push(f.Locals[11]);f.Pc=207;continue;}
case 207:{return rt.DynamicCall(f,"forge/game/GameAction:2128:207:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",212);}
case 212:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",215);}
case 215:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",218);}
case 218:{f.Pc=38;continue;}
case 221:{f.Push(f.Locals[7]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",226);}
case 226:{f.Pc=f.Pop().Int!=0?263:229;continue;}
case 229:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",232);}
case 232:{f.Locals[8]=f.Pop();f.Pc=234;continue;}
case 234:{f.Push(f.Locals[8]);f.Pc=236;continue;}
case 236:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=239;continue;}
case 239:{f.Push(f.Locals[7]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",246);}
case 246:{f.StackOp("pop");f.Pc=247;continue;}
case 247:{f.Push(f.Locals[0]);f.Pc=248;continue;}
case 248:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",254);}
case 254:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","MilledAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","MilledAll","Lforge/game/trigger/TriggerType;"));f.Pc=257;continue;}
case 257:{f.Push(f.Locals[8]);f.Pc=259;continue;}
case 259:{f.Push(JValue.I(0));f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",263);}
case 263:{f.Push(f.Locals[7]);f.Pc=265;continue;}
case 265:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2129(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int==0?77:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardDamageTable","columnMap","()Ljava/util/Map;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",13);}
case 13:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[6]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[6]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?77:30;continue;}
case 30:{f.Push(f.Locals[6]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[7]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[7]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[8]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[8]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=59;continue;}
case 59:{f.Pc=f.Pop().Int==0?74:62;continue;}
case 62:{f.Push(f.Locals[8]);f.Pc=64;continue;}
case 64:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=67;continue;}
case 67:{f.Locals[9]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[9]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/Card","clearAssignedDamage","()V","invokevirtual",74);}
case 74:{f.Pc=20;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",84);}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[5]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","runReplaceDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V","invokevirtual",94);}
case 94:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",97);}
case 97:{f.Locals[6]=f.Pop();f.Pc=99;continue;}
case 99:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",102);}
case 102:{f.Locals[7]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/card/CardDamageTable","rowMap","()Ljava/util/Map;","invokevirtual",108);}
case 108:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",113);}
case 113:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",118);}
case 118:{f.Locals[8]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[8]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",127);}
case 127:{f.Pc=f.Pop().Int==0?410:130;continue;}
case 130:{f.Push(f.Locals[8]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",137);}
case 137:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=140;continue;}
case 140:{f.Locals[9]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(f.Locals[9]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",149);}
case 149:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=152;continue;}
case 152:{f.Locals[10]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(JValue.I(0));f.Pc=155;continue;}
case 155:{f.Locals[11]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[9]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",164);}
case 164:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",172);}
case 172:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",177);}
case 177:{f.Locals[12]=f.Pop();f.Pc=179;continue;}
case 179:{f.Push(f.Locals[12]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",186);}
case 186:{f.Pc=f.Pop().Int==0?376:189;continue;}
case 189:{f.Push(f.Locals[12]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",196);}
case 196:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=199;continue;}
case 199:{f.Locals[13]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[13]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",208);}
case 208:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",214);}
case 214:{f.Pc=f.Pop().Int>0?220:217;continue;}
case 217:{f.Pc=179;continue;}
case 220:{f.Push(f.Locals[13]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",227);}
case 227:{f.Locals[15]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[15]);f.Pc=231;continue;}
case 231:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=234;continue;}
case 234:{f.Pc=f.Pop().Int==0?275:237;continue;}
case 237:{f.Push(f.Locals[15]);f.Pc=239;continue;}
case 239:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=242;continue;}
case 242:{f.Locals[14]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(f.Locals[6]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[14]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",253);}
case 253:{f.Pc=f.Pop().Int!=0?275:256;continue;}
case 256:{f.Push(f.Locals[6]);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[14]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[14]);f.Pc=262;continue;}
case 262:{f.Push(JValue.I(0));f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/card/Card","getExcessDamageValue","(Z)I","invokevirtual",266);}
case 266:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",269);}
case 269:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",274);}
case 274:{f.StackOp("pop");f.Pc=275;continue;}
case 275:{f.Push(f.Locals[13]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[13]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",284);}
case 284:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[13]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",294);}
case 294:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=297;continue;}
case 297:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",300);}
case 300:{f.Push(f.Locals[10]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[5]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{f.Push(f.Locals[4]);f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/GameEntity","addDamageAfterPrevention","(ILforge/game/card/Card;Lforge/game/spellability/SpellAbility;ZLforge/game/GameEntityCounterTable;)I","invokevirtual",310);}
case 310:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",313);}
case 313:{return rt.Call(f,"java/util/Map$Entry","setValue","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",318);}
case 318:{f.StackOp("pop");f.Pc=319;continue;}
case 319:{f.Push(f.Locals[11]);f.Pc=321;continue;}
case 321:{f.Push(f.Locals[13]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",328);}
case 328:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=331;continue;}
case 331:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",334);}
case 334:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=335;continue;}
case 335:{f.Locals[11]=f.Pop();f.Pc=337;continue;}
case 337:{f.Push(f.Locals[10]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",342);}
case 342:{f.Push(f.Locals[13]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",349);}
case 349:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=352;continue;}
case 352:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",355);}
case 355:{f.Push(f.Locals[1]);f.Pc=356;continue;}
case 356:{f.Push(f.Locals[10]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[13]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",365);}
case 365:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=368;continue;}
case 368:{f.Push(f.Locals[7]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/card/CardDamageHistory","registerDamage","(IZLforge/game/card/Card;Lforge/game/GameEntity;Ljava/util/Map;)V","invokevirtual",373);}
case 373:{f.Pc=179;continue;}
case 376:{f.Push(f.Locals[11]);f.Pc=378;continue;}
case 378:{f.Pc=f.Pop().Int<=0?407:381;continue;}
case 381:{f.Push(f.Locals[10]);f.Pc=383;continue;}
case 383:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","LIFELINK","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","LIFELINK","Lforge/game/keyword/Keyword;"));f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",389);}
case 389:{f.Pc=f.Pop().Int==0?407:392;continue;}
case 392:{f.Push(f.Locals[10]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",397);}
case 397:{f.Push(f.Locals[11]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[10]);f.Pc=401;continue;}
case 401:{f.Push(f.Locals[5]);f.Pc=403;continue;}
case 403:{return rt.Call(f,"forge/game/player/Player","gainLife","(ILforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",406);}
case 406:{f.StackOp("pop");f.Pc=407;continue;}
case 407:{f.Pc=120;continue;}
case 410:{f.Push(f.Locals[2]);f.Pc=411;continue;}
case 411:{f.Push(f.Locals[1]);f.Pc=412;continue;}
case 412:{f.Push(f.Locals[6]);f.Pc=414;continue;}
case 414:{f.Push(f.Locals[0]);f.Pc=415;continue;}
case 415:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=418;continue;}
case 418:{f.Push(f.Locals[5]);f.Pc=420;continue;}
case 420:{f.Push(f.Locals[7]);f.Pc=422;continue;}
case 422:{return rt.Call(f,"forge/game/card/CardDamageTable","triggerExcessDamage","(ZLjava/util/Map;Lforge/game/Game;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)V","invokevirtual",425);}
case 425:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",428);}
case 428:{f.Locals[8]=f.Pop();f.Pc=430;continue;}
case 430:{f.Push(f.Locals[0]);f.Pc=431;continue;}
case 431:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=434;continue;}
case 434:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",437);}
case 437:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",440);}
case 440:{f.Locals[9]=f.Pop();f.Pc=442;continue;}
case 442:{f.Push(f.Locals[9]);f.Pc=444;continue;}
case 444:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",449);}
case 449:{f.Pc=f.Pop().Int==0?494:452;continue;}
case 452:{f.Push(f.Locals[9]);f.Pc=454;continue;}
case 454:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",459);}
case 459:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=462;continue;}
case 462:{f.Locals[10]=f.Pop();f.Pc=464;continue;}
case 464:{f.Push(f.Locals[10]);f.Pc=466;continue;}
case 466:{return rt.Call(f,"forge/game/player/Player","processDamage","()I","invokevirtual",469);}
case 469:{f.Locals[11]=f.Pop();f.Pc=471;continue;}
case 471:{f.Push(f.Locals[11]);f.Pc=473;continue;}
case 473:{f.Pc=f.Pop().Int<=0?491:476;continue;}
case 476:{f.Push(f.Locals[8]);f.Pc=478;continue;}
case 478:{f.Push(f.Locals[10]);f.Pc=480;continue;}
case 480:{f.Push(f.Locals[11]);f.Pc=482;continue;}
case 482:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",485);}
case 485:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",490);}
case 490:{f.StackOp("pop");f.Pc=491;continue;}
case 491:{f.Pc=442;continue;}
case 494:{f.Push(f.Locals[1]);f.Pc=495;continue;}
case 495:{f.Pc=f.Pop().Int==0?509:498;continue;}
case 498:{f.Push(f.Locals[0]);f.Pc=499;continue;}
case 499:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",505);}
case 505:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runWaitingTriggers","()Z","invokevirtual",508);}
case 508:{f.StackOp("pop");f.Pc=509;continue;}
case 509:{f.Push(f.Locals[8]);f.Pc=511;continue;}
case 511:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",516);}
case 516:{f.Pc=f.Pop().Int!=0?542:519;continue;}
case 519:{f.Push(f.Locals[8]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPIMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",524);}
case 524:{f.Locals[9]=f.Pop();f.Pc=526;continue;}
case 526:{f.Push(f.Locals[0]);f.Pc=527;continue;}
case 527:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=530;continue;}
case 530:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",533);}
case 533:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"));f.Pc=536;continue;}
case 536:{f.Push(f.Locals[9]);f.Pc=538;continue;}
case 538:{f.Push(JValue.I(0));f.Pc=539;continue;}
case 539:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",542);}
case 542:{f.Push(f.Locals[5]);f.Pc=544;continue;}
case 544:{f.Pc=f.Pop().Reference==null?651:547;continue;}
case 547:{f.Push(f.Locals[0]);f.Pc=548;continue;}
case 548:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=551;continue;}
case 551:{f.Push(f.Locals[5]);f.Pc=553;continue;}
case 553:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",556);}
case 556:{return rt.Call(f,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",559);}
case 559:{f.Locals[9]=f.Pop();f.Pc=561;continue;}
case 561:{f.Push(f.Locals[5]);f.Pc=563;continue;}
case 563:{f.Push(JValue.R(rt.String("RememberDamaged")));f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",569);}
case 569:{f.Pc=f.Pop().Int==0?625:572;continue;}
case 572:{f.Push(f.Locals[2]);f.Pc=573;continue;}
case 573:{f.Push(f.Locals[9]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"forge/game/card/CardDamageTable","row","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",578);}
case 578:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",583);}
case 583:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",588);}
case 588:{f.Locals[10]=f.Pop();f.Pc=590;continue;}
case 590:{f.Push(f.Locals[10]);f.Pc=592;continue;}
case 592:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",597);}
case 597:{f.Pc=f.Pop().Int==0?625:600;continue;}
case 600:{f.Push(f.Locals[10]);f.Pc=602;continue;}
case 602:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",607);}
case 607:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=610;continue;}
case 610:{f.Locals[11]=f.Pop();f.Pc=612;continue;}
case 612:{f.Push(f.Locals[5]);f.Pc=614;continue;}
case 614:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",617);}
case 617:{f.Push(f.Locals[11]);f.Pc=619;continue;}
case 619:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",622);}
case 622:{f.Pc=590;continue;}
case 625:{f.Push(f.Locals[5]);f.Pc=627;continue;}
case 627:{f.Push(JValue.R(rt.String("RememberAmount")));f.Pc=630;continue;}
case 630:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",633);}
case 633:{f.Pc=f.Pop().Int==0?651:636;continue;}
case 636:{f.Push(f.Locals[5]);f.Pc=638;continue;}
case 638:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",641);}
case 641:{f.Push(f.Locals[2]);f.Pc=642;continue;}
case 642:{return rt.Call(f,"forge/game/card/CardDamageTable","totalAmount","()I","invokevirtual",645);}
case 645:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",648);}
case 648:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",651);}
case 651:{f.Push(f.Locals[3]);f.Pc=652;continue;}
case 652:{f.Push(f.Locals[1]);f.Pc=653;continue;}
case 653:{return rt.Call(f,"forge/game/card/CardDamageTable","triggerPreventDamage","(Z)V","invokevirtual",656);}
case 656:{f.Push(f.Locals[3]);f.Pc=657;continue;}
case 657:{return rt.Call(f,"forge/game/card/CardDamageTable","clear","()V","invokevirtual",660);}
case 660:{f.Push(f.Locals[2]);f.Pc=661;continue;}
case 661:{f.Push(f.Locals[1]);f.Pc=662;continue;}
case 662:{f.Push(f.Locals[0]);f.Pc=663;continue;}
case 663:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=666;continue;}
case 666:{return rt.Call(f,"forge/game/card/CardDamageTable","triggerDamageDoneOnce","(ZLforge/game/Game;)V","invokevirtual",669);}
case 669:{f.Push(f.Locals[2]);f.Pc=670;continue;}
case 670:{return rt.Call(f,"forge/game/card/CardDamageTable","clear","()V","invokevirtual",673);}
case 673:{f.Push(f.Locals[4]);f.Pc=675;continue;}
case 675:{f.Push(f.Locals[0]);f.Pc=676;continue;}
case 676:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=679;continue;}
case 679:{f.Push(f.Locals[5]);f.Pc=681;continue;}
case 681:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",684);}
case 684:{f.Push(f.Locals[4]);f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/GameEntityCounterTable","clear","()V","invokevirtual",689);}
case 689:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2130(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","addCompletedDungeon","(Lforge/game/card/Card;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/GameAction","ceaseToExist","(Lforge/game/card/Card;Z)V","invokevirtual",11);}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",34);}
case 34:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DungeonCompleted","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DungeonCompleted","Lforge/game/trigger/TriggerType;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",42);}
case 42:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2131(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","ENCHANT","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","ENCHANT","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/card/CardState","getAuraSpell","()Lforge/game/spellability/SpellAbility;","invokevirtual",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference!=null?26:24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",34);}
case 34:{f.Push(JValue.R(rt.ClassObject("forge/game/zone/ZoneType")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","ENCHANT","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","ENCHANT","Lforge/game/keyword/Keyword;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","getKeywords","(Lforge/game/keyword/Keyword;)Ljava/util/Collection;","invokevirtual",51);}
case 51:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",56);}
case 56:{f.Locals[6]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?169:68;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{f.Locals[7]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",87);}
case 87:{f.Locals[8]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[8]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String(":")));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",97);}
case 97:{f.Locals[9]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[9]);f.Pc=101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=103;continue;}
case 103:{f.Locals[10]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[10]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("inZone")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?130:116;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",126);}
case 126:{f.StackOp("pop");f.Pc=127;continue;}
case 127:{f.Pc=141;continue;}
case 130:{f.Push(f.Locals[4]);f.Pc=132;continue;}
case 132:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",140);}
case 140:{f.StackOp("pop");f.Pc=141;continue;}
case 141:{f.Push(f.Locals[10]);f.Pc=143;continue;}
case 143:{f.Push(JValue.R(rt.String("Player")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",149);}
case 149:{f.Pc=f.Pop().Int!=0?163:152;continue;}
case 152:{f.Push(f.Locals[10]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("Opponent")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int==0?166:163;continue;}
case 163:{f.Push(JValue.I(1));f.Pc=164;continue;}
case 164:{f.Locals[5]=f.Pop();f.Pc=166;continue;}
case 166:{f.Pc=58;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",173);}
case 173:{f.Locals[6]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[5]);f.Pc=177;continue;}
case 177:{f.Pc=f.Pop().Int==0?252:180;continue;}
case 180:{f.Push(f.Locals[0]);f.Pc=181;continue;}
case 181:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",187);}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{f.Push(JValue.R(null));f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/player/PlayerPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;","invokestatic",192);}
case 192:{return rt.Call(f,"forge/game/player/PlayerCollection","filter","(Ljava/util/function/Predicate;)Lforge/game/player/PlayerCollection;","invokevirtual",195);}
case 195:{f.Locals[7]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[6]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",202);}
case 202:{f.Push(f.Locals[7]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[3]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",208);}
case 208:{f.Push(JValue.R(rt.String("lblSelectAPlayerAttachSourceTo")));f.Pc=211;continue;}
case 211:{f.Push(JValue.I(1));f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=215;continue;}
case 215:{f.StackOp("dup");f.Pc=216;continue;}
case 216:{f.Push(JValue.I(0));f.Pc=217;continue;}
case 217:{f.Push(f.Locals[1]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",221);}
case 221:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",225);}
case 225:{f.Push(JValue.R(null));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",229);}
case 229:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=232;continue;}
case 232:{f.Locals[8]=f.Pop();f.Pc=234;continue;}
case 234:{f.Push(f.Locals[8]);f.Pc=236;continue;}
case 236:{f.Pc=f.Pop().Reference==null?249:239;continue;}
case 239:{f.Push(f.Locals[1]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[8]);f.Pc=242;continue;}
case 242:{f.Push(JValue.R(null));f.Pc=243;continue;}
case 243:{f.Push(JValue.I(1));f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;Z)V","invokevirtual",247);}
case 247:{f.Push(JValue.I(1));f.Pc=248;continue;}
case 248:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 249:{f.Pc=445;continue;}
case 252:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=255;continue;}
case 255:{f.StackOp("dup");f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",259);}
case 259:{f.Locals[7]=f.Pop();f.Pc=261;continue;}
case 261:{f.Push(f.Locals[2]);f.Pc=262;continue;}
case 262:{f.Pc=f.Pop().Reference==null?349:265;continue;}
case 265:{f.Push(f.Locals[4]);f.Pc=267;continue;}
case 267:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",275);}
case 275:{f.Pc=f.Pop().Int==0?307:278;continue;}
case 278:{f.Push(f.Locals[7]);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[2]);f.Pc=281;continue;}
case 281:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",289);}
case 289:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",295);}
case 295:{f.StackOp("pop");f.Pc=296;continue;}
case 296:{f.Push(f.Locals[4]);f.Pc=298;continue;}
case 298:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=301;continue;}
case 301:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",306);}
case 306:{f.StackOp("pop");f.Pc=307;continue;}
case 307:{f.Push(f.Locals[4]);f.Pc=309;continue;}
case 309:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=312;continue;}
case 312:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",317);}
case 317:{f.Pc=f.Pop().Int==0?349:320;continue;}
case 320:{f.Push(f.Locals[7]);f.Pc=322;continue;}
case 322:{f.Push(f.Locals[2]);f.Pc=323;continue;}
case 323:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=326;continue;}
case 326:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",331);}
case 331:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",337);}
case 337:{f.StackOp("pop");f.Pc=338;continue;}
case 338:{f.Push(f.Locals[4]);f.Pc=340;continue;}
case 340:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=343;continue;}
case 343:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",348);}
case 348:{f.StackOp("pop");f.Pc=349;continue;}
case 349:{f.Push(f.Locals[7]);f.Pc=351;continue;}
case 351:{f.Push(f.Locals[0]);f.Pc=352;continue;}
case 352:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=355;continue;}
case 355:{f.Push(f.Locals[4]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",360);}
case 360:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",363);}
case 363:{f.StackOp("pop");f.Pc=364;continue;}
case 364:{f.Push(f.Locals[7]);f.Pc=366;continue;}
case 366:{f.Push(f.Locals[1]);f.Pc=367;continue;}
case 367:{f.Push(JValue.R(null));f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/card/CardPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;","invokestatic",371);}
case 371:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",374);}
case 374:{f.Locals[7]=f.Pop();f.Pc=376;continue;}
case 376:{f.Push(f.Locals[7]);f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",381);}
case 381:{f.Pc=f.Pop().Int==0?386:384;continue;}
case 384:{f.Push(JValue.I(0));f.Pc=385;continue;}
case 385:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 386:{f.Push(f.Locals[6]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",391);}
case 391:{f.Push(f.Locals[7]);f.Pc=393;continue;}
case 393:{f.Push(f.Locals[3]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",397);}
case 397:{f.Push(JValue.R(rt.String("lblSelectACardAttachSourceTo")));f.Pc=400;continue;}
case 400:{f.Push(JValue.I(1));f.Pc=401;continue;}
case 401:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=404;continue;}
case 404:{f.StackOp("dup");f.Pc=405;continue;}
case 405:{f.Push(JValue.I(0));f.Pc=406;continue;}
case 406:{f.Push(f.Locals[1]);f.Pc=407;continue;}
case 407:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",410);}
case 410:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",414);}
case 414:{f.Push(JValue.R(null));f.Pc=415;continue;}
case 415:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",418);}
case 418:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=421;continue;}
case 421:{f.Locals[8]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(f.Locals[8]);f.Pc=425;continue;}
case 425:{f.Pc=f.Pop().Reference==null?445:428;continue;}
case 428:{f.Push(f.Locals[1]);f.Pc=429;continue;}
case 429:{f.Push(f.Locals[0]);f.Pc=430;continue;}
case 430:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=433;continue;}
case 433:{f.Push(f.Locals[8]);f.Pc=435;continue;}
case 435:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",438);}
case 438:{f.Push(JValue.R(null));f.Pc=439;continue;}
case 439:{f.Push(JValue.I(1));f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;Z)V","invokevirtual",443);}
case 443:{f.Push(JValue.I(1));f.Pc=444;continue;}
case 444:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 445:{f.Push(JValue.I(0));f.Pc=446;continue;}
case 446:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2132(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[5]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?19:7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",14);}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{f.Locals[5]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[5]);f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference!=null?54:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference==null?54:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=32;continue;}
case 32:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?41:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateBattlefield","()Lforge/game/card/CardCollection;","invokevirtual",39);}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=45;continue;}
case 45:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?54:48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateGraveyard","()Lforge/game/card/CardCollection;","invokevirtual",52);}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[5]);f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Reference!=null?125:59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=63;continue;}
case 63:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?92:66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Int==0?83:71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/Game","copyLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",78);}
case 78:{f.Locals[5]=f.Pop();f.Pc=80;continue;}
case 80:{f.Pc=92;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",90);}
case 90:{f.Locals[5]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=96;continue;}
case 96:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?125:99;continue;}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{f.Pc=f.Pop().Int==0?116:104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/Game","copyLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",111);}
case 111:{f.Locals[5]=f.Pop();f.Pc=113;continue;}
case 113:{f.Pc=125;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(rt.GetField(f.Pop(),"forge/game/GameAction","game","Lforge/game/Game;"));f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",123);}
case 123:{f.Locals[5]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[5]);f.Pc=127;continue;}
case 127:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2133(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",11);}
case 11:{switch(f.Pop().Int){case -1502181624:f.Pc=28;break;default:f.Pc=40;break;}continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("lambda$setupStaticEffect$54847c6e$1")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Locals[2]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{switch(f.Pop().Int){case 0:f.Pc=60;break;default:f.Pc=163;break;}continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",64);}
case 64:{f.Push(JValue.I(5));f.Pc=65;continue;}
case 65:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?163:68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",72);}
case 72:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?163:81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",85);}
case 85:{f.Push(JValue.R(rt.String("run")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?163:94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",98);}
case 98:{f.Push(JValue.R(rt.String("()V")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?163:107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",111);}
case 111:{f.Push(JValue.R(rt.String("forge/game/GameAction")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int==0?163:120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",124);}
case 124:{f.Push(JValue.R(rt.String("(Lforge/game/card/Card;Lforge/game/card/Card;)V")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",130);}
case 130:{f.Pc=f.Pop().Int==0?163:133;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{f.Push(JValue.I(0));f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",138);}
case 138:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameAction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",146);}
case 146:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{f.Push(JValue.I(2));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",154);}
case 154:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=157;continue;}
case 157:{return rt.DynamicCall(f,"forge/game/GameAction:2133:157:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/GameAction;Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/GameCommand;",162);}
case 162:{return JStep.Return(f.Pop());}
case 163:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=166;continue;}
case 166:{f.StackOp("dup");f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.String("Invalid lambda deserialization")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",173);}
case 173:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2134(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("Cryptic Spires")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2135(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("Emissary's Ploy")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2136(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/card/CardType$Supertype","World","Lforge/card/CardType$Supertype;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Supertype","World","Lforge/card/CardType$Supertype;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardTypeView","hasSupertype","(Lforge/card/CardType$Supertype;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2137(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","START_YOUR_ENGINES","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","START_YOUR_ENGINES","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2138(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?24:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/Card","isEmblem","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2139(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",3);}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2140(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",3);}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2141(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[3]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{f.Locals[4]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?75:34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[6]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[6]);f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?72:57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/staticability/StaticAbility","zonesCheck","()Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?72:65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[6]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Pc=24;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/Card","getStaticCommandList","()Ljava/util/List;","invokevirtual",80);}
case 80:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",85);}
case 85:{f.Pc=f.Pop().Int!=0?95:88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",94);}
case 94:{f.StackOp("pop");f.Pc=95;continue;}
case 95:{f.Push(f.Locals[4]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/card/Card","getHiddenStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",100);}
case 100:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",105);}
case 105:{f.Locals[5]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[5]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",114);}
case 114:{f.Pc=f.Pop().Int==0?158:117;continue;}
case 117:{f.Push(f.Locals[5]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",124);}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{f.Locals[6]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",137);}
case 137:{f.Pc=f.Pop().Int==0?155:140;continue;}
case 140:{f.Push(f.Locals[6]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/staticability/StaticAbility","zonesCheck","()Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int==0?155:148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[6]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",154);}
case 154:{f.StackOp("pop");f.Pc=155;continue;}
case 155:{f.Pc=107;continue;}
case 158:{f.Push(JValue.I(1));f.Pc=159;continue;}
case 159:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2142(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/GameAction","cleanStaticEffect","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2143(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/GameAction:2143:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",5);}
case 5:{return rt.Call(f,"java/util/Comparator","comparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokestatic",8);}
case 8:{return rt.Call(f,"java/util/Comparator","reversed","()Ljava/util/Comparator;","invokeinterface",13);}
case 13:{return rt.DynamicCall(f,"forge/game/GameAction:2143:13:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",18);}
case 18:{return rt.Call(f,"java/util/Comparator","thenComparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokeinterface",23);}
case 23:{if(!rt.StaticReady(f,"forge/game/GameAction","effectOrder","Ljava/util/Comparator;"))return JStep.Continue;rt.PutStatic("forge/game/GameAction","effectOrder","Ljava/util/Comparator;",f.Pop());f.Pc=26;continue;}
case 26:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C807{
internal static JClass Build(){var c=new JClass("forge/game/spellability/SpellAbilityVariables","java/lang/Object",new string[]{"java/lang/Cloneable"},33);Add0(c);Add1(c);Add2(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("zone","Lforge/game/zone/ZoneType;",false,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("phases","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("firstCombatOnly","Z",false,JValue.Default("Z"),null));
c.Add(new JField("afterBlockersOnly","Z",false,JValue.Default("Z"),null));
c.Add(new JField("gameTypes","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("sorcerySpeed","Z",false,JValue.Default("Z"),null));
c.Add(new JField("instantSpeed","Z",false,JValue.Default("Z"),null));
c.Add(new JField("activator","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("opponentTurn","Z",false,JValue.Default("Z"),null));
c.Add(new JField("playerTurn","Z",false,JValue.Default("Z"),null));
c.Add(new JField("limitToCheck","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("gameLimitToCheck","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("threshold","Z",false,JValue.Default("Z"),null));
c.Add(new JField("metalcraft","Z",false,JValue.Default("Z"),null));
c.Add(new JField("delirium","Z",false,JValue.Default("Z"),null));
c.Add(new JField("hellbent","Z",false,JValue.Default("Z"),null));
c.Add(new JField("revolt","Z",false,JValue.Default("Z"),null));
c.Add(new JField("blessing","Z",false,JValue.Default("Z"),null));
c.Add(new JField("enduringStory","Z",false,JValue.Default("Z"),null));
c.Add(new JField("solved","Z",false,JValue.Default("Z"),null));
c.Add(new JField("isPresent","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("isPresent2","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("presentCompare","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("presentCompare2","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("presentDefined","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("presentDefined2","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("playerDefined","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("playerContains","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("presentZones","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("sVarToCheck","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sVarToCheck2","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sVarOperator","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sVarOperator2","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sVarOperand","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sVarOperand2","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("lifeTotal","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("lifeAmount","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("noDifferentColors","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("manaSpent","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("manaNotSpent","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("chosenColors","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("targetValidTargeting","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("targetsSingleTarget","Z",false,JValue.Default("Z"),null));
c.Add(new JField("classLevel","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("classLevelOperator","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("kicked","Z",false,JValue.Default("Z"),null));
c.Add(new JField("kicked1","Z",false,JValue.Default("Z"),null));
c.Add(new JField("kicked2","Z",false,JValue.Default("Z"),null));
c.Add(new JField("altCostPaid","Z",false,JValue.Default("Z"),null));
c.Add(new JField("optionalCostPaid","Z",false,JValue.Default("Z"),null));
c.Add(new JField("optionalBoolean","Z",false,JValue.Default("Z"),null));
c.Add(new JField("surgeCostPaid","Z",false,JValue.Default("Z"),null));
c.Add(new JField("bargain","Z",false,JValue.Default("Z"),null));
c.Add(new JField("teamwork","Z",false,JValue.Default("Z"),null));
c.Add(new JField("foretold","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(9562,"forge/game/spellability/SpellAbilityVariables","<init>","()V",1,1,2,new JHandler[]{},M9562));
c.Add(new JMethod(9563,"forge/game/spellability/SpellAbilityVariables","setManaSpent","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9563));
c.Add(new JMethod(9564,"forge/game/spellability/SpellAbilityVariables","getManaSpent","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9564));
c.Add(new JMethod(9565,"forge/game/spellability/SpellAbilityVariables","setManaNotSpent","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9565));
c.Add(new JMethod(9566,"forge/game/spellability/SpellAbilityVariables","getManaNotSpent","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9566));
c.Add(new JMethod(9567,"forge/game/spellability/SpellAbilityVariables","setZone","(Lforge/game/zone/ZoneType;)V",17,2,2,new JHandler[]{},M9567));
c.Add(new JMethod(9568,"forge/game/spellability/SpellAbilityVariables","getZone","()Lforge/game/zone/ZoneType;",17,1,1,new JHandler[]{},M9568));
c.Add(new JMethod(9569,"forge/game/spellability/SpellAbilityVariables","setSorcerySpeed","(Z)V",17,2,2,new JHandler[]{},M9569));
c.Add(new JMethod(9570,"forge/game/spellability/SpellAbilityVariables","isSorcerySpeed","()Z",17,1,1,new JHandler[]{},M9570));
}

private static void Add1(JClass c){
c.Add(new JMethod(9571,"forge/game/spellability/SpellAbilityVariables","setInstantSpeed","(Z)V",17,2,2,new JHandler[]{},M9571));
c.Add(new JMethod(9572,"forge/game/spellability/SpellAbilityVariables","isInstantSpeed","()Z",17,1,1,new JHandler[]{},M9572));
c.Add(new JMethod(9573,"forge/game/spellability/SpellAbilityVariables","setActivator","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9573));
c.Add(new JMethod(9574,"forge/game/spellability/SpellAbilityVariables","getActivator","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9574));
c.Add(new JMethod(9575,"forge/game/spellability/SpellAbilityVariables","setPlayerTurn","(Z)V",17,2,2,new JHandler[]{},M9575));
c.Add(new JMethod(9576,"forge/game/spellability/SpellAbilityVariables","getPlayerTurn","()Z",17,1,1,new JHandler[]{},M9576));
c.Add(new JMethod(9577,"forge/game/spellability/SpellAbilityVariables","setOpponentTurn","(Z)V",17,2,2,new JHandler[]{},M9577));
c.Add(new JMethod(9578,"forge/game/spellability/SpellAbilityVariables","getOpponentTurn","()Z",17,1,1,new JHandler[]{},M9578));
c.Add(new JMethod(9579,"forge/game/spellability/SpellAbilityVariables","setPhases","(Ljava/util/Set;)V",17,2,2,new JHandler[]{},M9579));
c.Add(new JMethod(9580,"forge/game/spellability/SpellAbilityVariables","getGameTypes","()Ljava/util/Set;",17,1,1,new JHandler[]{},M9580));
c.Add(new JMethod(9581,"forge/game/spellability/SpellAbilityVariables","setGameTypes","(Ljava/util/Set;)V",17,2,2,new JHandler[]{},M9581));
c.Add(new JMethod(9582,"forge/game/spellability/SpellAbilityVariables","setHellbent","(Z)V",17,2,2,new JHandler[]{},M9582));
c.Add(new JMethod(9583,"forge/game/spellability/SpellAbilityVariables","setThreshold","(Z)V",17,2,2,new JHandler[]{},M9583));
c.Add(new JMethod(9584,"forge/game/spellability/SpellAbilityVariables","setMetalcraft","(Z)V",17,2,2,new JHandler[]{},M9584));
c.Add(new JMethod(9585,"forge/game/spellability/SpellAbilityVariables","setDelirium","(Z)V",1,2,2,new JHandler[]{},M9585));
c.Add(new JMethod(9586,"forge/game/spellability/SpellAbilityVariables","setRevolt","(Z)V",1,2,2,new JHandler[]{},M9586));
c.Add(new JMethod(9587,"forge/game/spellability/SpellAbilityVariables","setBlessing","(Z)V",1,2,2,new JHandler[]{},M9587));
c.Add(new JMethod(9588,"forge/game/spellability/SpellAbilityVariables","setEnduringStory","(Z)V",1,2,2,new JHandler[]{},M9588));
c.Add(new JMethod(9589,"forge/game/spellability/SpellAbilityVariables","setSolved","(Z)V",1,2,2,new JHandler[]{},M9589));
c.Add(new JMethod(9590,"forge/game/spellability/SpellAbilityVariables","setIsPresent","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9590));
c.Add(new JMethod(9591,"forge/game/spellability/SpellAbilityVariables","setIsPresent2","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9591));
c.Add(new JMethod(9592,"forge/game/spellability/SpellAbilityVariables","setPresentCompare","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9592));
c.Add(new JMethod(9593,"forge/game/spellability/SpellAbilityVariables","setPresentCompare2","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9593));
c.Add(new JMethod(9594,"forge/game/spellability/SpellAbilityVariables","getPresentZones","()Ljava/util/List;",17,1,1,new JHandler[]{},M9594));
c.Add(new JMethod(9595,"forge/game/spellability/SpellAbilityVariables","setPresentZones","(Ljava/util/List;)V",17,2,2,new JHandler[]{},M9595));
c.Add(new JMethod(9596,"forge/game/spellability/SpellAbilityVariables","setPresentDefined","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9596));
c.Add(new JMethod(9597,"forge/game/spellability/SpellAbilityVariables","setPresentDefined2","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9597));
c.Add(new JMethod(9598,"forge/game/spellability/SpellAbilityVariables","setSvarToCheck","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9598));
c.Add(new JMethod(9599,"forge/game/spellability/SpellAbilityVariables","setSvarToCheck2","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9599));
c.Add(new JMethod(9600,"forge/game/spellability/SpellAbilityVariables","setSvarOperator","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9600));
c.Add(new JMethod(9601,"forge/game/spellability/SpellAbilityVariables","setSvarOperand","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9601));
c.Add(new JMethod(9602,"forge/game/spellability/SpellAbilityVariables","setSvarOperator2","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9602));
c.Add(new JMethod(9603,"forge/game/spellability/SpellAbilityVariables","setSvarOperand2","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9603));
c.Add(new JMethod(9604,"forge/game/spellability/SpellAbilityVariables","setLimitToCheck","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9604));
c.Add(new JMethod(9605,"forge/game/spellability/SpellAbilityVariables","setGameLimitToCheck","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9605));
c.Add(new JMethod(9606,"forge/game/spellability/SpellAbilityVariables","getLimitToCheck","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9606));
c.Add(new JMethod(9607,"forge/game/spellability/SpellAbilityVariables","getGameLimitToCheck","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9607));
c.Add(new JMethod(9608,"forge/game/spellability/SpellAbilityVariables","isThreshold","()Z",17,1,1,new JHandler[]{},M9608));
c.Add(new JMethod(9609,"forge/game/spellability/SpellAbilityVariables","isMetalcraft","()Z",17,1,1,new JHandler[]{},M9609));
c.Add(new JMethod(9610,"forge/game/spellability/SpellAbilityVariables","isDelirium","()Z",17,1,1,new JHandler[]{},M9610));
c.Add(new JMethod(9611,"forge/game/spellability/SpellAbilityVariables","isHellbent","()Z",17,1,1,new JHandler[]{},M9611));
c.Add(new JMethod(9612,"forge/game/spellability/SpellAbilityVariables","isRevolt","()Z",17,1,1,new JHandler[]{},M9612));
c.Add(new JMethod(9613,"forge/game/spellability/SpellAbilityVariables","isBlessing","()Z",17,1,1,new JHandler[]{},M9613));
c.Add(new JMethod(9614,"forge/game/spellability/SpellAbilityVariables","isEnduringStory","()Z",17,1,1,new JHandler[]{},M9614));
c.Add(new JMethod(9615,"forge/game/spellability/SpellAbilityVariables","isSolved","()Z",17,1,1,new JHandler[]{},M9615));
c.Add(new JMethod(9616,"forge/game/spellability/SpellAbilityVariables","getNoDifferentColors","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9616));
c.Add(new JMethod(9617,"forge/game/spellability/SpellAbilityVariables","setNoDifferentColors","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M9617));
c.Add(new JMethod(9618,"forge/game/spellability/SpellAbilityVariables","isPlayerTurn","()Z",17,1,1,new JHandler[]{},M9618));
c.Add(new JMethod(9619,"forge/game/spellability/SpellAbilityVariables","getPresentCompare","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9619));
c.Add(new JMethod(9620,"forge/game/spellability/SpellAbilityVariables","getPresentCompare2","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9620));
c.Add(new JMethod(9621,"forge/game/spellability/SpellAbilityVariables","getLifeTotal","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9621));
c.Add(new JMethod(9622,"forge/game/spellability/SpellAbilityVariables","setLifeTotal","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9622));
c.Add(new JMethod(9623,"forge/game/spellability/SpellAbilityVariables","getLifeAmount","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9623));
c.Add(new JMethod(9624,"forge/game/spellability/SpellAbilityVariables","setLifeAmount","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9624));
c.Add(new JMethod(9625,"forge/game/spellability/SpellAbilityVariables","getPhases","()Ljava/util/Set;",17,1,1,new JHandler[]{},M9625));
c.Add(new JMethod(9626,"forge/game/spellability/SpellAbilityVariables","getFirstCombatOnly","()Z",17,1,1,new JHandler[]{},M9626));
c.Add(new JMethod(9627,"forge/game/spellability/SpellAbilityVariables","setFirstCombatOnly","(Z)Z",17,2,3,new JHandler[]{},M9627));
c.Add(new JMethod(9628,"forge/game/spellability/SpellAbilityVariables","getAfterBlockersOnly","()Z",17,1,1,new JHandler[]{},M9628));
c.Add(new JMethod(9629,"forge/game/spellability/SpellAbilityVariables","setAfterBlockersOnly","(Z)Z",17,2,3,new JHandler[]{},M9629));
c.Add(new JMethod(9630,"forge/game/spellability/SpellAbilityVariables","getPresentDefined","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9630));
c.Add(new JMethod(9631,"forge/game/spellability/SpellAbilityVariables","getPresentDefined2","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9631));
c.Add(new JMethod(9632,"forge/game/spellability/SpellAbilityVariables","setPlayerDefined","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9632));
c.Add(new JMethod(9633,"forge/game/spellability/SpellAbilityVariables","getPlayerDefined","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9633));
c.Add(new JMethod(9634,"forge/game/spellability/SpellAbilityVariables","getPlayerContains","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9634));
}

private static void Add2(JClass c){
c.Add(new JMethod(9635,"forge/game/spellability/SpellAbilityVariables","setPlayerContains","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9635));
c.Add(new JMethod(9636,"forge/game/spellability/SpellAbilityVariables","getsVarOperand","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9636));
c.Add(new JMethod(9637,"forge/game/spellability/SpellAbilityVariables","getsVarOperand2","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9637));
c.Add(new JMethod(9638,"forge/game/spellability/SpellAbilityVariables","setsVarOperand","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9638));
c.Add(new JMethod(9639,"forge/game/spellability/SpellAbilityVariables","setsVarOperand2","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9639));
c.Add(new JMethod(9640,"forge/game/spellability/SpellAbilityVariables","getsVarToCheck","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9640));
c.Add(new JMethod(9641,"forge/game/spellability/SpellAbilityVariables","getsVarToCheck2","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9641));
c.Add(new JMethod(9642,"forge/game/spellability/SpellAbilityVariables","setsVarToCheck","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9642));
c.Add(new JMethod(9643,"forge/game/spellability/SpellAbilityVariables","setsVarToCheck2","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9643));
c.Add(new JMethod(9644,"forge/game/spellability/SpellAbilityVariables","getsVarOperator","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9644));
c.Add(new JMethod(9645,"forge/game/spellability/SpellAbilityVariables","getsVarOperator2","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9645));
c.Add(new JMethod(9646,"forge/game/spellability/SpellAbilityVariables","setsVarOperator","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9646));
c.Add(new JMethod(9647,"forge/game/spellability/SpellAbilityVariables","setsVarOperator2","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9647));
c.Add(new JMethod(9648,"forge/game/spellability/SpellAbilityVariables","isOpponentTurn","()Z",17,1,1,new JHandler[]{},M9648));
c.Add(new JMethod(9649,"forge/game/spellability/SpellAbilityVariables","getIsPresent","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9649));
c.Add(new JMethod(9650,"forge/game/spellability/SpellAbilityVariables","getIsPresent2","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9650));
c.Add(new JMethod(9651,"forge/game/spellability/SpellAbilityVariables","setColorToCheck","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9651));
c.Add(new JMethod(9652,"forge/game/spellability/SpellAbilityVariables","getColorToCheck","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9652));
c.Add(new JMethod(9653,"forge/game/spellability/SpellAbilityVariables","getTargetValidTargeting","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9653));
c.Add(new JMethod(9654,"forge/game/spellability/SpellAbilityVariables","setTargetValidTargeting","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M9654));
c.Add(new JMethod(9655,"forge/game/spellability/SpellAbilityVariables","targetsSingleTarget","()Z",1,1,1,new JHandler[]{},M9655));
c.Add(new JMethod(9656,"forge/game/spellability/SpellAbilityVariables","setTargetsSingleTarget","(Z)V",1,2,2,new JHandler[]{},M9656));
c.Add(new JMethod(9657,"forge/game/spellability/SpellAbilityVariables","copy","()Lforge/game/spellability/SpellAbilityVariables;",1,2,2,new JHandler[]{new JHandler(0,7,8,"java/lang/CloneNotSupportedException")},M9657));
c.Add(new JMethod(9658,"forge/game/spellability/SpellAbilityVariables","getClassLevel","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9658));
c.Add(new JMethod(9659,"forge/game/spellability/SpellAbilityVariables","setClassLevel","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M9659));
c.Add(new JMethod(9660,"forge/game/spellability/SpellAbilityVariables","getClassLevelOperator","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9660));
c.Add(new JMethod(9661,"forge/game/spellability/SpellAbilityVariables","setClassLevelOperator","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M9661));
}

internal static JStep M9562(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","zone","Lforge/game/zone/ZoneType;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.ClassObject("forge/game/phase/PhaseType")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",17);}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","phases","Ljava/util/Set;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","firstCombatOnly","Z",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","afterBlockersOnly","Z",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.ClassObject("forge/game/GameType")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",36);}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","gameTypes","Ljava/util/Set;",value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sorcerySpeed","Z",value);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","instantSpeed","Z",value);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("You")));f.Pc=52;continue;}
case 52:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","activator","Ljava/lang/String;",value);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","opponentTurn","Z",value);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","playerTurn","Z",value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(null));f.Pc=67;continue;}
case 67:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","limitToCheck","Ljava/lang/String;",value);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(null));f.Pc=72;continue;}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","gameLimitToCheck","Ljava/lang/String;",value);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","threshold","Z",value);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","metalcraft","Z",value);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","delirium","Z",value);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(JValue.I(0));f.Pc=92;continue;}
case 92:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","hellbent","Z",value);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(JValue.I(0));f.Pc=97;continue;}
case 97:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","revolt","Z",value);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(JValue.I(0));f.Pc=102;continue;}
case 102:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","blessing","Z",value);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","enduringStory","Z",value);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","solved","Z",value);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(null));f.Pc=117;continue;}
case 117:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","isPresent","Ljava/lang/String;",value);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(null));f.Pc=122;continue;}
case 122:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","isPresent2","Ljava/lang/String;",value);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("GE1")));f.Pc=128;continue;}
case 128:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentCompare","Ljava/lang/String;",value);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String("GE1")));f.Pc=134;continue;}
case 134:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentCompare2","Ljava/lang/String;",value);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(null));f.Pc=139;continue;}
case 139:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentDefined","Ljava/lang/String;",value);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(JValue.R(null));f.Pc=144;continue;}
case 144:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentDefined2","Ljava/lang/String;",value);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(JValue.R(null));f.Pc=149;continue;}
case 149:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","playerDefined","Ljava/lang/String;",value);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[0]);f.Pc=153;continue;}
case 153:{f.Push(JValue.R(null));f.Pc=154;continue;}
case 154:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","playerContains","Ljava/lang/String;",value);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",164);}
case 164:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentZones","Ljava/util/List;",value);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{f.Push(JValue.R(null));f.Pc=169;continue;}
case 169:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarToCheck","Ljava/lang/String;",value);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(JValue.R(null));f.Pc=174;continue;}
case 174:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarToCheck2","Ljava/lang/String;",value);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[0]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("GE")));f.Pc=180;continue;}
case 180:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarOperator","Ljava/lang/String;",value);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[0]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("GE")));f.Pc=186;continue;}
case 186:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarOperator2","Ljava/lang/String;",value);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("1")));f.Pc=192;continue;}
case 192:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarOperand","Ljava/lang/String;",value);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(JValue.R(rt.String("1")));f.Pc=198;continue;}
case 198:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarOperand2","Ljava/lang/String;",value);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{f.Push(JValue.R(null));f.Pc=203;continue;}
case 203:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","lifeTotal","Ljava/lang/String;",value);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[0]);f.Pc=207;continue;}
case 207:{f.Push(JValue.R(rt.String("GE1")));f.Pc=209;continue;}
case 209:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","lifeAmount","Ljava/lang/String;",value);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(JValue.R(null));f.Pc=214;continue;}
case 214:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","noDifferentColors","Ljava/lang/String;",value);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[0]);f.Pc=218;continue;}
case 218:{f.Push(JValue.R(rt.String("")));f.Pc=220;continue;}
case 220:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","manaSpent","Ljava/lang/String;",value);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[0]);f.Pc=224;continue;}
case 224:{f.Push(JValue.R(rt.String("")));f.Pc=226;continue;}
case 226:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","manaNotSpent","Ljava/lang/String;",value);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{f.Push(JValue.R(null));f.Pc=231;continue;}
case 231:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","chosenColors","Ljava/lang/String;",value);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[0]);f.Pc=235;continue;}
case 235:{f.Push(JValue.R(null));f.Pc=236;continue;}
case 236:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","targetValidTargeting","Ljava/lang/String;",value);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[0]);f.Pc=240;continue;}
case 240:{f.Push(JValue.I(0));f.Pc=241;continue;}
case 241:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","targetsSingleTarget","Z",value);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(null));f.Pc=246;continue;}
case 246:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","classLevel","Ljava/lang/String;",value);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[0]);f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("EQ")));f.Pc=252;continue;}
case 252:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","classLevelOperator","Ljava/lang/String;",value);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[0]);f.Pc=256;continue;}
case 256:{f.Push(JValue.I(0));f.Pc=257;continue;}
case 257:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","kicked","Z",value);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[0]);f.Pc=261;continue;}
case 261:{f.Push(JValue.I(0));f.Pc=262;continue;}
case 262:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","kicked1","Z",value);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[0]);f.Pc=266;continue;}
case 266:{f.Push(JValue.I(0));f.Pc=267;continue;}
case 267:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","kicked2","Z",value);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[0]);f.Pc=271;continue;}
case 271:{f.Push(JValue.I(0));f.Pc=272;continue;}
case 272:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","altCostPaid","Z",value);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[0]);f.Pc=276;continue;}
case 276:{f.Push(JValue.I(0));f.Pc=277;continue;}
case 277:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","optionalCostPaid","Z",value);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[0]);f.Pc=281;continue;}
case 281:{f.Push(JValue.I(1));f.Pc=282;continue;}
case 282:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","optionalBoolean","Z",value);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[0]);f.Pc=286;continue;}
case 286:{f.Push(JValue.I(0));f.Pc=287;continue;}
case 287:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","surgeCostPaid","Z",value);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[0]);f.Pc=291;continue;}
case 291:{f.Push(JValue.I(0));f.Pc=292;continue;}
case 292:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","bargain","Z",value);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[0]);f.Pc=296;continue;}
case 296:{f.Push(JValue.I(0));f.Pc=297;continue;}
case 297:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","teamwork","Z",value);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[0]);f.Pc=301;continue;}
case 301:{f.Push(JValue.I(0));f.Pc=302;continue;}
case 302:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","foretold","Z",value);f.Pc=305;continue;}
case 305:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9563(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","manaSpent","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9564(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","manaSpent","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9565(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","manaNotSpent","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9566(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","manaNotSpent","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9567(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","zone","Lforge/game/zone/ZoneType;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9568(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","zone","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9569(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sorcerySpeed","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9570(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sorcerySpeed","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9571(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","instantSpeed","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9572(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","instantSpeed","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9573(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","activator","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9574(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","activator","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9575(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","playerTurn","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9576(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbilityVariables","isPlayerTurn","()Z","invokevirtual",4);}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9577(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","opponentTurn","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9578(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbilityVariables","isOpponentTurn","()Z","invokevirtual",4);}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9579(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","phases","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9580(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","gameTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9581(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","gameTypes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","gameTypes","Ljava/util/Set;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9582(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","hellbent","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9583(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","threshold","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9584(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","metalcraft","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9585(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","delirium","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9586(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","revolt","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9587(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","blessing","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9588(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","enduringStory","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9589(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","solved","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9590(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","isPresent","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9591(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","isPresent2","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9592(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentCompare","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9593(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentCompare2","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9594(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentZones","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9595(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentZones","Ljava/util/List;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9596(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentDefined","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9597(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentDefined2","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9598(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbilityVariables","setsVarToCheck","(Ljava/lang/String;)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9599(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbilityVariables","setsVarToCheck2","(Ljava/lang/String;)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9600(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbilityVariables","setsVarOperator","(Ljava/lang/String;)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9601(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbilityVariables","setsVarOperand","(Ljava/lang/String;)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9602(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbilityVariables","setsVarOperator2","(Ljava/lang/String;)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9603(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbilityVariables","setsVarOperand2","(Ljava/lang/String;)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9604(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","limitToCheck","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9605(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","gameLimitToCheck","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9606(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","limitToCheck","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9607(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","gameLimitToCheck","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9608(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","threshold","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9609(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","metalcraft","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9610(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","delirium","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9611(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","hellbent","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9612(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","revolt","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9613(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","blessing","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9614(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","enduringStory","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9615(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","solved","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9616(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","noDifferentColors","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9617(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","noDifferentColors","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9618(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","playerTurn","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9619(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentCompare","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9620(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentCompare2","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9621(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","lifeTotal","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9622(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","lifeTotal","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9623(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","lifeAmount","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9624(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","lifeAmount","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9625(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","phases","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9626(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","firstCombatOnly","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9627(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.StackOp("dup_x1");f.Pc=3;continue;}
case 3:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","firstCombatOnly","Z",value);f.Pc=6;continue;}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9628(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","afterBlockersOnly","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9629(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.StackOp("dup_x1");f.Pc=3;continue;}
case 3:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","afterBlockersOnly","Z",value);f.Pc=6;continue;}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9630(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentDefined","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9631(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","presentDefined2","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9632(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","playerDefined","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9633(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","playerDefined","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9634(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","playerContains","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9635(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","playerContains","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9636(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarOperand","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9637(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarOperand2","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9638(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarOperand","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9639(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarOperand2","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9640(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarToCheck","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9641(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarToCheck2","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9642(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarToCheck","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9643(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarToCheck2","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9644(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarOperator","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9645(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarOperator2","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9646(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarOperator","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9647(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","sVarOperator2","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9648(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","opponentTurn","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9649(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","isPresent","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9650(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","isPresent2","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9651(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","chosenColors","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9652(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","chosenColors","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9653(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","targetValidTargeting","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9654(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","targetValidTargeting","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9655(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","targetsSingleTarget","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9656(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","targetsSingleTarget","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9657(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","clone","()Ljava/lang/Object;","invokevirtual",4);}
case 4:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityVariables"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7;continue;}
case 7:{return JStep.Return(f.Pop());}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/Object;)V","invokevirtual",16);}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9658(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","classLevel","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9659(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","classLevel","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9660(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","classLevelOperator","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9661(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityVariables","classLevelOperator","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C513{
internal static JClass Build(){var c=new JClass("forge/game/combat/Combat","java/lang/Object",new string[]{},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("playerWhoAttacks","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("legacyOrderCombatants","Z",false,JValue.Default("Z"),null));
c.Add(new JField("attackConstraints","Lforge/game/combat/AttackConstraints;",false,JValue.Default("Lforge/game/combat/AttackConstraints;"),null));
c.Add(new JField("attackableEntries","Lcom/google/common/base/Supplier;",false,JValue.Default("Lcom/google/common/base/Supplier;"),null));
c.Add(new JField("attackedByBands","Lcom/google/common/base/Supplier;",false,JValue.Default("Lcom/google/common/base/Supplier;"),null));
c.Add(new JField("blockedBands","Lcom/google/common/base/Supplier;",false,JValue.Default("Lcom/google/common/base/Supplier;"),null));
c.Add(new JField("attackersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;",false,JValue.Default("Lcom/google/common/base/Supplier;"),null));
c.Add(new JField("blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;",false,JValue.Default("Lcom/google/common/base/Supplier;"),null));
c.Add(new JField("lkiCache","Lcom/google/common/base/Supplier;",false,JValue.Default("Lcom/google/common/base/Supplier;"),null));
c.Add(new JField("damageMap","Lcom/google/common/base/Supplier;",false,JValue.Default("Lcom/google/common/base/Supplier;"),null));
c.Add(new JField("combatantsThatDealtFirstStrikeDamage","Lcom/google/common/base/Supplier;",false,JValue.Default("Lcom/google/common/base/Supplier;"),null));
c.Add(new JMethod(6027,"forge/game/combat/Combat","<init>","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M6027));
c.Add(new JMethod(6028,"forge/game/combat/Combat","<init>","(Lforge/game/combat/Combat;Lforge/game/IEntityMap;)V",1,12,4,new JHandler[]{},M6028));
c.Add(new JMethod(6029,"forge/game/combat/Combat","isRealCombat","()Z",2,2,2,new JHandler[]{},M6029));
c.Add(new JMethod(6030,"forge/game/combat/Combat","initConstraints","()V",1,1,4,new JHandler[]{},M6030));
c.Add(new JMethod(6031,"forge/game/combat/Combat","toString","()Ljava/lang/String;",1,9,2,new JHandler[]{},M6031));
c.Add(new JMethod(6032,"forge/game/combat/Combat","endCombat","()V",1,6,2,new JHandler[]{},M6032));
c.Add(new JMethod(6033,"forge/game/combat/Combat","clearAttackers","()V",17,3,2,new JHandler[]{},M6033));
c.Add(new JMethod(6034,"forge/game/combat/Combat","getAttackingPlayer","()Lforge/game/player/Player;",17,1,1,new JHandler[]{},M6034));
c.Add(new JMethod(6035,"forge/game/combat/Combat","getAttackConstraints","()Lforge/game/combat/AttackConstraints;",17,1,1,new JHandler[]{},M6035));
c.Add(new JMethod(6036,"forge/game/combat/Combat","getDefenders","()Lforge/util/collect/FCollectionView;",17,1,1,new JHandler[]{},M6036));
c.Add(new JMethod(6037,"forge/game/combat/Combat","getAttackedOpponents","(Lforge/game/player/Player;)Lforge/util/collect/FCollection;",17,5,2,new JHandler[]{},M6037));
c.Add(new JMethod(6038,"forge/game/combat/Combat","getDefendersControlledBy","(Lforge/game/player/Player;)Lforge/util/collect/FCollection;",17,5,2,new JHandler[]{},M6038));
c.Add(new JMethod(6039,"forge/game/combat/Combat","getDefendingPlayers","()Lforge/util/collect/FCollectionView;",17,1,4,new JHandler[]{},M6039));
c.Add(new JMethod(6040,"forge/game/combat/Combat","getDefendingPlaneswalkers","()Lforge/game/card/CardCollection;",17,1,2,new JHandler[]{},M6040));
c.Add(new JMethod(6041,"forge/game/combat/Combat","getDefendingBattles","()Lforge/game/card/CardCollection;",17,1,2,new JHandler[]{},M6041));
c.Add(new JMethod(6042,"forge/game/combat/Combat","getAttackersAndDefenders","()Ljava/util/Map;",17,1,2,new JHandler[]{},M6042));
c.Add(new JMethod(6043,"forge/game/combat/Combat","getAttackingBandsOf","(Lforge/game/GameEntity;)Ljava/util/List;",17,2,2,new JHandler[]{},M6043));
c.Add(new JMethod(6044,"forge/game/combat/Combat","getAttackersOf","(Lforge/game/GameEntity;)Lforge/game/card/CardCollection;",17,5,2,new JHandler[]{},M6044));
c.Add(new JMethod(6045,"forge/game/combat/Combat","addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V",17,3,4,new JHandler[]{},M6045));
c.Add(new JMethod(6046,"forge/game/combat/Combat","addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;Lforge/game/combat/AttackingBand;)V",17,6,3,new JHandler[]{},M6046));
c.Add(new JMethod(6047,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;",17,2,3,new JHandler[]{},M6047));
c.Add(new JMethod(6048,"forge/game/combat/Combat","getDefenderByBand","()Ljava/util/Map;",17,4,3,new JHandler[]{},M6048));
c.Add(new JMethod(6049,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/combat/AttackingBand;)Lforge/game/GameEntity;",17,4,2,new JHandler[]{},M6049));
c.Add(new JMethod(6050,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;",17,4,2,new JHandler[]{},M6050));
c.Add(new JMethod(6051,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;",17,4,2,new JHandler[]{},M6051));
c.Add(new JMethod(6052,"forge/game/combat/Combat","getBandOfAttackerNotNull","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;",17,3,3,new JHandler[]{},M6052));
c.Add(new JMethod(6053,"forge/game/combat/Combat","getAttackingBands","()Ljava/util/List;",17,1,1,new JHandler[]{},M6053));
c.Add(new JMethod(6054,"forge/game/combat/Combat","isAttacking","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z",1,6,2,new JHandler[]{},M6054));
c.Add(new JMethod(6055,"forge/game/combat/Combat","isAttacking","(Lforge/game/card/Card;)Z",17,4,2,new JHandler[]{},M6055));
c.Add(new JMethod(6056,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;",17,4,2,new JHandler[]{},M6056));
c.Add(new JMethod(6057,"forge/game/combat/Combat","isBlocked","(Lforge/game/card/Card;)Z",17,3,2,new JHandler[]{},M6057));
c.Add(new JMethod(6058,"forge/game/combat/Combat","setBlocked","(Lforge/game/card/Card;Z)V",17,3,2,new JHandler[]{},M6058));
c.Add(new JMethod(6059,"forge/game/combat/Combat","addBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;)V",17,4,3,new JHandler[]{},M6059));
c.Add(new JMethod(6060,"forge/game/combat/Combat","removeBlockAssignment","(Lforge/game/card/Card;Lforge/game/card/Card;)V",17,5,2,new JHandler[]{},M6060));
c.Add(new JMethod(6061,"forge/game/combat/Combat","undoBlockingAssignment","(Lforge/game/card/Card;)V",17,3,3,new JHandler[]{},M6061));
c.Add(new JMethod(6062,"forge/game/combat/Combat","getAllBlockers","()Lforge/game/card/CardCollection;",17,4,2,new JHandler[]{},M6062));
c.Add(new JMethod(6063,"forge/game/combat/Combat","getDefendersCreatures","()Lforge/game/card/CardCollection;",17,6,2,new JHandler[]{},M6063));
c.Add(new JMethod(6064,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;",17,2,3,new JHandler[]{},M6064));
c.Add(new JMethod(6065,"forge/game/combat/Combat","getBlockers","(Lforge/game/combat/AttackingBand;)Lforge/game/card/CardCollection;",17,3,3,new JHandler[]{},M6065));
c.Add(new JMethod(6066,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;",17,5,2,new JHandler[]{},M6066));
c.Add(new JMethod(6067,"forge/game/combat/Combat","getAttackingBandsBlockedBy","(Lforge/game/card/Card;)Lforge/util/collect/FCollectionView;",17,5,2,new JHandler[]{},M6067));
c.Add(new JMethod(6068,"forge/game/combat/Combat","getDefendingPlayerRelatedTo","(Lforge/game/card/Card;)Lforge/game/player/Player;",1,3,2,new JHandler[]{},M6068));
c.Add(new JMethod(6069,"forge/game/combat/Combat","orderBlockersForDamageAssignment","()V",1,7,5,new JHandler[]{},M6069));
c.Add(new JMethod(6070,"forge/game/combat/Combat","orderBlockersForDamageAssignment","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)V",1,6,5,new JHandler[]{},M6070));
c.Add(new JMethod(6071,"forge/game/combat/Combat","addBlockerToDamageAssignmentOrder","(Lforge/game/card/Card;Lforge/game/card/Card;)V",1,5,5,new JHandler[]{},M6071));
c.Add(new JMethod(6072,"forge/game/combat/Combat","orderAttackersForDamageAssignment","()V",1,3,2,new JHandler[]{},M6072));
c.Add(new JMethod(6073,"forge/game/combat/Combat","orderAttackersForDamageAssignment","(Lforge/game/card/Card;)V",1,5,3,new JHandler[]{},M6073));
c.Add(new JMethod(6074,"forge/game/combat/Combat","unregisterAttacker","(Lforge/game/card/Card;Lforge/game/combat/AttackingBand;)V",1,8,3,new JHandler[]{},M6074));
c.Add(new JMethod(6075,"forge/game/combat/Combat","unregisterDefender","(Lforge/game/card/Card;Lforge/game/combat/AttackingBand;)V",1,5,2,new JHandler[]{},M6075));
c.Add(new JMethod(6076,"forge/game/combat/Combat","removeFromCombat","(Lforge/game/card/Card;)V",17,10,4,new JHandler[]{},M6076));
c.Add(new JMethod(6077,"forge/game/combat/Combat","removeAbsentCombatants","()Z",17,6,2,new JHandler[]{},M6077));
c.Add(new JMethod(6078,"forge/game/combat/Combat","fireTriggersForUnblockedAttackers","(Lforge/game/Game;)V",17,10,4,new JHandler[]{},M6078));
c.Add(new JMethod(6079,"forge/game/combat/Combat","assignBlockersDamage","(Z)Z",2,15,9,new JHandler[]{},M6079));
}

private static void Add1(JClass c){
c.Add(new JMethod(6080,"forge/game/combat/Combat","assignAttackersDamage","(Z)Z",2,17,9,new JHandler[]{},M6080));
c.Add(new JMethod(6081,"forge/game/combat/Combat","dealDamageThisPhase","(Lforge/game/card/Card;Z)Z",2,3,2,new JHandler[]{},M6081));
c.Add(new JMethod(6082,"forge/game/combat/Combat","assignCombatDamage","(Z)Z",17,3,3,new JHandler[]{},M6082));
c.Add(new JMethod(6083,"forge/game/combat/Combat","dealAssignedDamage","()V",1,4,6,new JHandler[]{},M6083));
c.Add(new JMethod(6084,"forge/game/combat/Combat","isUnblocked","(Lforge/game/card/Card;)Z",17,3,2,new JHandler[]{},M6084));
c.Add(new JMethod(6085,"forge/game/combat/Combat","getUnblockedAttackers","()Lforge/game/card/CardCollection;",17,4,2,new JHandler[]{},M6085));
c.Add(new JMethod(6086,"forge/game/combat/Combat","isPlayerAttacked","(Lforge/game/player/Player;)Z",1,7,2,new JHandler[]{},M6086));
c.Add(new JMethod(6087,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;)Z",1,3,2,new JHandler[]{},M6087));
c.Add(new JMethod(6088,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",1,6,2,new JHandler[]{},M6088));
c.Add(new JMethod(6089,"forge/game/combat/Combat","saveLKI","(Lforge/game/card/Card;)Lforge/game/combat/CombatLki;",1,8,4,new JHandler[]{},M6089));
c.Add(new JMethod(6090,"forge/game/combat/Combat","lambda$new$1","()Lcom/google/common/collect/Multimap;",4106,0,1,new JHandler[]{},M6090));
c.Add(new JMethod(6091,"forge/game/combat/Combat","lambda$new$0","()Lcom/google/common/collect/Multimap;",4106,0,1,new JHandler[]{},M6091));
}

internal static JStep M6027(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.DynamicCall(f,"forge/game/combat/Combat:6027:5:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",10);}
case 10:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.DynamicCall(f,"forge/game/combat/Combat:6027:17:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",22);}
case 22:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",25);}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.DynamicCall(f,"forge/game/combat/Combat:6027:29:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",34);}
case 34:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.DynamicCall(f,"forge/game/combat/Combat:6027:41:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",46);}
case 46:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",49);}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","attackersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;",value);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return rt.DynamicCall(f,"forge/game/combat/Combat:6027:53:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",58);}
case 58:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",61);}
case 61:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;",value);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.DynamicCall(f,"forge/game/combat/Combat:6027:65:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",70);}
case 70:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",73);}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","lkiCache","Lcom/google/common/base/Supplier;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{return rt.DynamicCall(f,"forge/game/combat/Combat:6027:77:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",82);}
case 82:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",85);}
case 85:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","damageMap","Lcom/google/common/base/Supplier;",value);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{return rt.DynamicCall(f,"forge/game/combat/Combat:6027:89:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",94);}
case 94:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",97);}
case 97:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","combatantsThatDealtFirstStrikeDamage","Lcom/google/common/base/Supplier;",value);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;",value);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;"));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",113);}
case 113:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/game/GameRules","hasOrderCombatants","()Z","invokevirtual",119);}
case 119:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","legacyOrderCombatants","Z",value);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/combat/Combat","initConstraints","()V","invokevirtual",126);}
case 126:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6028(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.DynamicCall(f,"forge/game/combat/Combat:6028:5:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",10);}
case 10:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.DynamicCall(f,"forge/game/combat/Combat:6028:17:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",22);}
case 22:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",25);}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.DynamicCall(f,"forge/game/combat/Combat:6028:29:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",34);}
case 34:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.DynamicCall(f,"forge/game/combat/Combat:6028:41:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",46);}
case 46:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",49);}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","attackersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;",value);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return rt.DynamicCall(f,"forge/game/combat/Combat:6028:53:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",58);}
case 58:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",61);}
case 61:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;",value);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.DynamicCall(f,"forge/game/combat/Combat:6028:65:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",70);}
case 70:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",73);}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","lkiCache","Lcom/google/common/base/Supplier;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{return rt.DynamicCall(f,"forge/game/combat/Combat:6028:77:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",82);}
case 82:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",85);}
case 85:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","damageMap","Lcom/google/common/base/Supplier;",value);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{return rt.DynamicCall(f,"forge/game/combat/Combat:6028:89:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Supplier;",94);}
case 94:{return rt.Call(f,"com/google/common/base/Suppliers","memoize","(Lcom/google/common/base/Supplier;)Lcom/google/common/base/Supplier;","invokestatic",97);}
case 97:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","combatantsThatDealtFirstStrikeDamage","Lcom/google/common/base/Supplier;",value);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;"));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/IEntityMap","map","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokeinterface",111);}
case 111:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;",value);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;"));f.Pc=118;continue;}
case 118:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",123);}
case 123:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",129);}
case 129:{f.Locals[3]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",136);}
case 136:{f.Pc=f.Pop().Int==0?177:139;continue;}
case 139:{f.Push(f.Locals[3]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",145);}
case 145:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=148;continue;}
case 148:{f.Locals[4]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;"));f.Pc=154;continue;}
case 154:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",159);}
case 159:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[2]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[4]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/IEntityMap","map","(Lforge/game/GameEntity;)Lforge/game/GameEntity;","invokeinterface",170);}
case 170:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",173);}
case 173:{f.StackOp("pop");f.Pc=174;continue;}
case 174:{f.Pc=130;continue;}
case 177:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=180;continue;}
case 180:{f.StackOp("dup");f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",184);}
case 184:{f.Locals[3]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=189;continue;}
case 189:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",194);}
case 194:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=197;continue;}
case 197:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",202);}
case 202:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",207);}
case 207:{f.Locals[4]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[4]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",216);}
case 216:{f.Pc=f.Pop().Int==0?487:219;continue;}
case 219:{f.Push(f.Locals[4]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",226);}
case 226:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=229;continue;}
case 229:{f.Locals[5]=f.Pop();f.Pc=231;continue;}
case 231:{f.Push(f.Locals[5]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",238);}
case 238:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=241;continue;}
case 241:{f.Locals[6]=f.Pop();f.Pc=243;continue;}
case 243:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=246;continue;}
case 246:{f.StackOp("dup");f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",250);}
case 250:{f.Locals[7]=f.Pop();f.Pc=252;continue;}
case 252:{f.Push(f.Locals[6]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/combat/AttackingBand","getAttackers","()Lforge/game/card/CardCollectionView;","invokevirtual",257);}
case 257:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",262);}
case 262:{f.Locals[8]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(f.Locals[8]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",271);}
case 271:{f.Pc=f.Pop().Int==0?303:274;continue;}
case 274:{f.Push(f.Locals[8]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",281);}
case 281:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=284;continue;}
case 284:{f.Locals[9]=f.Pop();f.Pc=286;continue;}
case 286:{f.Push(f.Locals[7]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[2]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[9]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/IEntityMap","map","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokeinterface",296);}
case 296:{return rt.Call(f,"java/util/ArrayList","add","(Ljava/lang/Object;)Z","invokevirtual",299);}
case 299:{f.StackOp("pop");f.Pc=300;continue;}
case 300:{f.Pc=264;continue;}
case 303:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackingBand"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackingBand")));f.Pc=306;continue;}
case 306:{f.StackOp("dup");f.Pc=307;continue;}
case 307:{f.Push(f.Locals[7]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/game/combat/AttackingBand","<init>","(Ljava/util/List;)V","invokespecial",312);}
case 312:{f.Locals[8]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[5]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",321);}
case 321:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/combat/AttackingBand","isBlocked","()Ljava/lang/Boolean;","invokevirtual",327);}
case 327:{f.Locals[9]=f.Pop();f.Pc=329;continue;}
case 329:{f.Push(f.Locals[9]);f.Pc=331;continue;}
case 331:{f.Pc=f.Pop().Reference==null?344:334;continue;}
case 334:{f.Push(f.Locals[8]);f.Pc=336;continue;}
case 336:{f.Push(f.Locals[9]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",341);}
case 341:{return rt.Call(f,"forge/game/combat/AttackingBand","setBlocked","(Z)V","invokevirtual",344);}
case 344:{f.Push(f.Locals[3]);f.Pc=345;continue;}
case 345:{f.Push(f.Locals[6]);f.Pc=347;continue;}
case 347:{f.Push(f.Locals[8]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"java/util/HashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",352);}
case 352:{f.StackOp("pop");f.Pc=353;continue;}
case 353:{f.Push(f.Locals[5]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",360);}
case 360:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=363;continue;}
case 363:{f.Locals[10]=f.Pop();f.Pc=365;continue;}
case 365:{f.Push(f.Locals[10]);f.Pc=367;continue;}
case 367:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=370;continue;}
case 370:{f.Pc=f.Pop().Int==0?456:373;continue;}
case 373:{f.Push(f.Locals[10]);f.Pc=375;continue;}
case 375:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",381);}
case 381:{f.Push(JValue.I(-1));f.Pc=382;continue;}
case 382:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?456:385;continue;}
case 385:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=388;continue;}
case 388:{f.StackOp("dup");f.Pc=389;continue;}
case 389:{f.Push(JValue.I(-1));f.Pc=390;continue;}
case 390:{f.Push(f.Locals[2]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/IEntityMap","getGame","()Lforge/game/Game;","invokeinterface",396);}
case 396:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",399);}
case 399:{f.Locals[11]=f.Pop();f.Pc=401;continue;}
case 401:{f.Push(f.Locals[11]);f.Pc=403;continue;}
case 403:{f.Push(f.Locals[10]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/GameEntity","getName","()Ljava/lang/String;","invokevirtual",408);}
case 408:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",411);}
case 411:{f.Push(f.Locals[11]);f.Pc=413;continue;}
case 413:{f.Push(f.Locals[2]);f.Pc=414;continue;}
case 414:{f.Push(f.Locals[10]);f.Pc=416;continue;}
case 416:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",422);}
case 422:{return rt.Call(f,"forge/game/IEntityMap","map","(Lforge/game/player/Player;)Lforge/game/player/Player;","invokeinterface",427);}
case 427:{f.Push(JValue.L(0));f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",431);}
case 431:{f.Push(f.Locals[0]);f.Pc=432;continue;}
case 432:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=435;continue;}
case 435:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",440);}
case 440:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=443;continue;}
case 443:{f.Push(f.Locals[11]);f.Pc=445;continue;}
case 445:{f.Push(f.Locals[8]);f.Pc=447;continue;}
case 447:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",452);}
case 452:{f.StackOp("pop");f.Pc=453;continue;}
case 453:{f.Pc=484;continue;}
case 456:{f.Push(f.Locals[0]);f.Pc=457;continue;}
case 457:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=460;continue;}
case 460:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",465);}
case 465:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=468;continue;}
case 468:{f.Push(f.Locals[2]);f.Pc=469;continue;}
case 469:{f.Push(f.Locals[10]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"forge/game/IEntityMap","map","(Lforge/game/GameEntity;)Lforge/game/GameEntity;","invokeinterface",476);}
case 476:{f.Push(f.Locals[8]);f.Pc=478;continue;}
case 478:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",483);}
case 483:{f.StackOp("pop");f.Pc=484;continue;}
case 484:{f.Pc=209;continue;}
case 487:{f.Push(f.Locals[1]);f.Pc=488;continue;}
case 488:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=491;continue;}
case 491:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",496);}
case 496:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=499;continue;}
case 499:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",504);}
case 504:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",509);}
case 509:{f.Locals[4]=f.Pop();f.Pc=511;continue;}
case 511:{f.Push(f.Locals[4]);f.Pc=513;continue;}
case 513:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",518);}
case 518:{f.Pc=f.Pop().Int==0?584:521;continue;}
case 521:{f.Push(f.Locals[4]);f.Pc=523;continue;}
case 523:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",528);}
case 528:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=531;continue;}
case 531:{f.Locals[5]=f.Pop();f.Pc=533;continue;}
case 533:{f.Push(f.Locals[0]);f.Pc=534;continue;}
case 534:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=537;continue;}
case 537:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",542);}
case 542:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=545;continue;}
case 545:{f.Push(f.Locals[3]);f.Pc=546;continue;}
case 546:{f.Push(f.Locals[5]);f.Pc=548;continue;}
case 548:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",553);}
case 553:{return rt.Call(f,"java/util/HashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",556);}
case 556:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=559;continue;}
case 559:{f.Push(f.Locals[2]);f.Pc=560;continue;}
case 560:{f.Push(f.Locals[5]);f.Pc=562;continue;}
case 562:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",567);}
case 567:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=570;continue;}
case 570:{return rt.Call(f,"forge/game/IEntityMap","map","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokeinterface",575);}
case 575:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",580);}
case 580:{f.StackOp("pop");f.Pc=581;continue;}
case 581:{f.Pc=511;continue;}
case 584:{f.Push(f.Locals[1]);f.Pc=585;continue;}
case 585:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=588;continue;}
case 588:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",593);}
case 593:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=596;continue;}
case 596:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",601);}
case 601:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",606);}
case 606:{f.Locals[4]=f.Pop();f.Pc=608;continue;}
case 608:{f.Push(f.Locals[4]);f.Pc=610;continue;}
case 610:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",615);}
case 615:{f.Pc=f.Pop().Int==0?683:618;continue;}
case 618:{f.Push(f.Locals[4]);f.Pc=620;continue;}
case 620:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",625);}
case 625:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=628;continue;}
case 628:{f.Locals[5]=f.Pop();f.Pc=630;continue;}
case 630:{f.Push(f.Locals[0]);f.Pc=631;continue;}
case 631:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=634;continue;}
case 634:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",639);}
case 639:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=642;continue;}
case 642:{f.Push(f.Locals[2]);f.Pc=643;continue;}
case 643:{f.Push(f.Locals[5]);f.Pc=645;continue;}
case 645:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",650);}
case 650:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=653;continue;}
case 653:{return rt.Call(f,"forge/game/IEntityMap","map","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokeinterface",658);}
case 658:{f.Push(f.Locals[2]);f.Pc=659;continue;}
case 659:{f.Push(f.Locals[5]);f.Pc=661;continue;}
case 661:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",666);}
case 666:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=669;continue;}
case 669:{return rt.Call(f,"forge/game/IEntityMap","mapCollection","(Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollection;","invokeinterface",674);}
case 674:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",679);}
case 679:{f.StackOp("pop");f.Pc=680;continue;}
case 680:{f.Pc=608;continue;}
case 683:{f.Push(f.Locals[1]);f.Pc=684;continue;}
case 684:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=687;continue;}
case 687:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",692);}
case 692:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=695;continue;}
case 695:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",700);}
case 700:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",705);}
case 705:{f.Locals[4]=f.Pop();f.Pc=707;continue;}
case 707:{f.Push(f.Locals[4]);f.Pc=709;continue;}
case 709:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",714);}
case 714:{f.Pc=f.Pop().Int==0?782:717;continue;}
case 717:{f.Push(f.Locals[4]);f.Pc=719;continue;}
case 719:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",724);}
case 724:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=727;continue;}
case 727:{f.Locals[5]=f.Pop();f.Pc=729;continue;}
case 729:{f.Push(f.Locals[0]);f.Pc=730;continue;}
case 730:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=733;continue;}
case 733:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",738);}
case 738:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=741;continue;}
case 741:{f.Push(f.Locals[2]);f.Pc=742;continue;}
case 742:{f.Push(f.Locals[5]);f.Pc=744;continue;}
case 744:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",749);}
case 749:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=752;continue;}
case 752:{return rt.Call(f,"forge/game/IEntityMap","map","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokeinterface",757);}
case 757:{f.Push(f.Locals[2]);f.Pc=758;continue;}
case 758:{f.Push(f.Locals[5]);f.Pc=760;continue;}
case 760:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",765);}
case 765:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=768;continue;}
case 768:{return rt.Call(f,"forge/game/IEntityMap","mapCollection","(Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollection;","invokeinterface",773);}
case 773:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",778);}
case 778:{f.StackOp("pop");f.Pc=779;continue;}
case 779:{f.Pc=707;continue;}
case 782:{f.Push(f.Locals[1]);f.Pc=783;continue;}
case 783:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","damageMap","Lcom/google/common/base/Supplier;"));f.Pc=786;continue;}
case 786:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",791);}
case 791:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=794;continue;}
case 794:{return rt.Call(f,"forge/game/card/CardDamageTable","cellSet","()Ljava/util/Set;","invokevirtual",797);}
case 797:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",802);}
case 802:{f.Locals[4]=f.Pop();f.Pc=804;continue;}
case 804:{f.Push(f.Locals[4]);f.Pc=806;continue;}
case 806:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",811);}
case 811:{f.Pc=f.Pop().Int==0?887:814;continue;}
case 814:{f.Push(f.Locals[4]);f.Pc=816;continue;}
case 816:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",821);}
case 821:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table$Cell"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=824;continue;}
case 824:{f.Locals[5]=f.Pop();f.Pc=826;continue;}
case 826:{f.Push(f.Locals[0]);f.Pc=827;continue;}
case 827:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","damageMap","Lcom/google/common/base/Supplier;"));f.Pc=830;continue;}
case 830:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",835);}
case 835:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=838;continue;}
case 838:{f.Push(f.Locals[2]);f.Pc=839;continue;}
case 839:{f.Push(f.Locals[5]);f.Pc=841;continue;}
case 841:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",846);}
case 846:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=849;continue;}
case 849:{return rt.Call(f,"forge/game/IEntityMap","map","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokeinterface",854);}
case 854:{f.Push(f.Locals[2]);f.Pc=855;continue;}
case 855:{f.Push(f.Locals[5]);f.Pc=857;continue;}
case 857:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",862);}
case 862:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=865;continue;}
case 865:{return rt.Call(f,"forge/game/IEntityMap","map","(Lforge/game/GameEntity;)Lforge/game/GameEntity;","invokeinterface",870);}
case 870:{f.Push(f.Locals[5]);f.Pc=872;continue;}
case 872:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",877);}
case 877:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=880;continue;}
case 880:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",883);}
case 883:{f.StackOp("pop");f.Pc=884;continue;}
case 884:{f.Pc=804;continue;}
case 887:{f.Push(f.Locals[0]);f.Pc=888;continue;}
case 888:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackConstraints"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackConstraints")));f.Pc=891;continue;}
case 891:{f.StackOp("dup");f.Pc=892;continue;}
case 892:{f.Push(f.Locals[0]);f.Pc=893;continue;}
case 893:{return rt.Call(f,"forge/game/combat/AttackConstraints","<init>","(Lforge/game/combat/Combat;)V","invokespecial",896);}
case 896:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","attackConstraints","Lforge/game/combat/AttackConstraints;",value);f.Pc=899;continue;}
case 899:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6029(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/Combat","getAttackingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference==null?20:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6030(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/collect/FCollection","clear","()V","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/combat/CombatUtil","getAllPossibleDefenders","(Lforge/game/player/Player;)Lforge/util/collect/FCollectionView;","invokestatic",34);}
case 34:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackConstraints"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackConstraints")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/combat/AttackConstraints","<init>","(Lforge/game/combat/Combat;)V","invokespecial",47);}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/Combat","attackConstraints","Lforge/game/combat/AttackConstraints;",value);f.Pc=50;continue;}
case 50:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6031(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?184:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[3]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/combat/Combat","getAttackersOf","(Lforge/game/GameEntity;)Lforge/game/card/CardCollection;","invokevirtual",48);}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?61:58;continue;}
case 58:{f.Pc=24;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String(" is being attacked by:\n")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",80);}
case 80:{f.Locals[5]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",89);}
case 89:{f.Pc=f.Pop().Int==0?181:92;continue;}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{f.Locals[6]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("  ")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",111);}
case 111:{f.Push(f.Locals[6]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",116);}
case 116:{f.Push(JValue.R(rt.String("\n")));f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[6]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",129);}
case 129:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",132);}
case 132:{f.Locals[7]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",141);}
case 141:{f.Pc=f.Pop().Int==0?178:144;continue;}
case 144:{f.Push(f.Locals[7]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",151);}
case 151:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=154;continue;}
case 154:{f.Locals[8]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{f.Push(JValue.R(rt.String("  ... blocked by: ")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",163);}
case 163:{f.Push(f.Locals[8]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",168);}
case 168:{f.Push(JValue.R(rt.String("\n")));f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",174);}
case 174:{f.StackOp("pop");f.Pc=175;continue;}
case 175:{f.Pc=134;continue;}
case 178:{f.Pc=82;continue;}
case 181:{f.Pc=24;continue;}
case 184:{f.Push(f.Locals[1]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",188);}
case 188:{f.Pc=f.Pop().Int!=0?195:191;continue;}
case 191:{f.Push(JValue.R(rt.String("<no attacks>")));f.Pc=194;continue;}
case 194:{return JStep.Return(f.Pop());}
case 195:{f.Push(f.Locals[1]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",199);}
case 199:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6032(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/combat/Combat","getAllBlockers","()Lforge/game/card/CardCollection;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",19);}
case 19:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/util/collect/FCollection","clear","()V","invokevirtual",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{return rt.Call(f,"com/google/common/collect/Multimap","clear","()V","invokeinterface",42);}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{return rt.Call(f,"com/google/common/collect/Multimap","clear","()V","invokeinterface",59);}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",68);}
case 68:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",76);}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=80;continue;}
case 80:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",93);}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","lkiCache","Lcom/google/common/base/Supplier;"));f.Pc=97;continue;}
case 97:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",102);}
case 102:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",108);}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","combatantsThatDealtFirstStrikeDamage","Lcom/google/common/base/Supplier;"));f.Pc=112;continue;}
case 112:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",117);}
case 117:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",123);}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;"));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",130);}
case 130:{f.Locals[3]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[3]);f.Pc=132;continue;}
case 132:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/Game","getCardsIncludePhasingIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",138);}
case 138:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",143);}
case 143:{f.Locals[4]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[4]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",152);}
case 152:{f.Pc=f.Pop().Int==0?178:155;continue;}
case 155:{f.Push(f.Locals[4]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",162);}
case 162:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=165;continue;}
case 165:{f.Locals[5]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[5]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",172);}
case 172:{return rt.Call(f,"forge/game/card/CardDamageHistory","endCombat","()V","invokevirtual",175);}
case 175:{f.Pc=145;continue;}
case 178:{f.Push(f.Locals[0]);f.Pc=179;continue;}
case 179:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;"));f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/player/Player","clearAttackedPlayersMyCombat","()V","invokevirtual",185);}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",189);}
case 189:{f.Locals[4]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[4]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",198);}
case 198:{f.Pc=f.Pop().Int==0?221:201;continue;}
case 201:{f.Push(f.Locals[4]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",208);}
case 208:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=211;continue;}
case 211:{f.Locals[5]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[5]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/card/Card","updateAttackingForView","()V","invokevirtual",218);}
case 218:{f.Pc=191;continue;}
case 221:{f.Push(f.Locals[2]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",225);}
case 225:{f.Locals[4]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[4]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",234);}
case 234:{f.Pc=f.Pop().Int==0?257:237;continue;}
case 237:{f.Push(f.Locals[4]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",244);}
case 244:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=247;continue;}
case 247:{f.Locals[5]=f.Pop();f.Pc=249;continue;}
case 249:{f.Push(f.Locals[5]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/card/Card","updateBlockingForView","()V","invokevirtual",254);}
case 254:{f.Pc=227;continue;}
case 257:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6033(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?35:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/combat/Combat","removeFromCombat","(Lforge/game/card/Card;)V","invokevirtual",32);}
case 32:{f.Pc=8;continue;}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6034(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6035(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackConstraints","Lforge/game/combat/AttackConstraints;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6036(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6037(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;"));f.Pc=13;continue;}
case 13:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?68:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/combat/Combat","getDefendingPlayers","()Lforge/util/collect/FCollectionView;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?68:35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/combat/Combat","getAttackersOf","(Lforge/game/GameEntity;)Lforge/game/card/CardCollection;","invokevirtual",52);}
case 52:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int!=0?65:58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Pc=26;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6038(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?80:33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?70:50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=55;continue;}
case 55:{f.Pc=f.Pop().Int==0?77:58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",66);}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?77:70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",76);}
case 76:{f.StackOp("pop");f.Pc=77;continue;}
case 77:{f.Pc=24;continue;}
case 80:{f.Push(f.Locals[2]);f.Pc=81;continue;}
case 81:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6039(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",13);}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.ClassObject("forge/game/player/Player")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/lang/Iterable;","invokestatic",21);}
case 21:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",24);}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6040(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.ClassObject("forge/game/card/Card")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/lang/Iterable;","invokestatic",17);}
case 17:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","PLANESWALKERS","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","PLANESWALKERS","Ljava/util/function/Predicate;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",23);}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6041(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.ClassObject("forge/game/card/Card")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/lang/Iterable;","invokestatic",17);}
case 17:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","BATTLES","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","BATTLES","Ljava/util/function/Predicate;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",23);}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6042(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","asSet","()Ljava/util/Set;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/game/combat/Combat:6042:8:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/combat/Combat;)Lcom/google/common/base/Function;",13);}
case 13:{return rt.Call(f,"com/google/common/collect/Maps","asMap","(Ljava/util/Set;Lcom/google/common/base/Function;)Ljava/util/Map;","invokestatic",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6043(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",18);}
case 18:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6044(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"com/google/common/collect/Multimap","containsKey","(Ljava/lang/Object;)Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int!=0?31:29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",49);}
case 49:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",54);}
case 54:{f.Locals[3]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",61);}
case 61:{f.Pc=f.Pop().Int==0?88:64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{f.Locals[4]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/combat/AttackingBand","getAttackers","()Lforge/game/card/CardCollectionView;","invokevirtual",81);}
case 81:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Pc=55;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6045(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/combat/Combat","addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;Lforge/game/combat/AttackingBand;)V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6046(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference!=null?45:25;continue;}
case 25:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",32);}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",36);}
case 36:{return rt.DynamicCall(f,"forge/game/combat/Combat:6046:36:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",41);}
case 41:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",44);}
case 44:{return JStep.ReturnVoid;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",50);}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{f.Pc=f.Pop().Reference==null?63:57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/combat/AttackingBand","removeAttacker","(Lforge/game/card/Card;)V","invokevirtual",63);}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{f.Pc=f.Pop().Reference==null?78:67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",75);}
case 75:{f.Pc=f.Pop().Int!=0?99:78;continue;}
case 78:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackingBand"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackingBand")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/combat/AttackingBand","<init>","(Lforge/game/card/Card;)V","invokespecial",86);}
case 86:{f.Locals[3]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Collection","add","(Ljava/lang/Object;)Z","invokeinterface",95);}
case 95:{f.StackOp("pop");f.Pc=96;continue;}
case 96:{f.Pc=104;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/combat/AttackingBand","addAttacker","(Lforge/game/card/Card;)V","invokevirtual",104);}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/combat/Combat","isRealCombat","()Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?115:111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/Card","updateAttackingForView","()V","invokevirtual",115);}
case 115:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6047(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/combat/AttackingBand;)Lforge/game/GameEntity;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6048(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/IdentityHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/IdentityHashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/IdentityHashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?78:40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",66);}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Pc=31;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6049(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?65:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?62:52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{return JStep.Return(f.Pop());}
case 62:{f.Pc=23;continue;}
case 65:{f.Push(JValue.R(null));f.Pc=66;continue;}
case 66:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6050(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int==0?20:13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int==0?49:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","isBattle","()Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?44:39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/Card","getProtectingPlayer","()Lforge/game/player/Player;","invokevirtual",43);}
case 43:{return JStep.Return(f.Pop());}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",48);}
case 48:{return JStep.Return(f.Pop());}
case 49:{f.Push(JValue.R(null));f.Pc=50;continue;}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6051(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",23);}
case 23:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",28);}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?61:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[3]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/combat/AttackingBand","contains","(Lforge/game/card/Card;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?58:56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return JStep.Return(f.Pop());}
case 58:{f.Pc=29;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","lkiCache","Lcom/google/common/base/Supplier;"));f.Pc=65;continue;}
case 65:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/CardCollection","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/Card","getCombatLKI","()Lforge/game/combat/CombatLki;","invokevirtual",83);}
case 83:{f.Locals[2]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{f.Pc=f.Pop().Reference==null?95:88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/CombatLki","isAttacker","Z"));f.Pc=92;continue;}
case 92:{f.Pc=f.Pop().Int!=0?99:95;continue;}
case 95:{f.Push(JValue.R(null));f.Pc=96;continue;}
case 96:{f.Pc=103;continue;}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/combat/CombatLki","getFirstBand","()Lforge/game/combat/AttackingBand;","invokevirtual",103);}
case 103:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6052(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference!=null?27:10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"java/lang/NullPointerException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/NullPointerException")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",18);}
case 18:{return rt.DynamicCall(f,"forge/game/combat/Combat:6052:18:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",23);}
case 23:{return rt.Call(f,"java/lang/NullPointerException","<init>","(Ljava/lang/String;)V","invokespecial",26);}
case 26:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6053(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",17);}
case 17:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",20);}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6054(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",5);}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",23);}
case 23:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?83:40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",59);}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?80:63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",70);}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?78:74;continue;}
case 74:{f.Push(JValue.I(1));f.Pc=75;continue;}
case 75:{f.Pc=79;continue;}
case 78:{f.Push(JValue.I(0));f.Pc=79;continue;}
case 79:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 80:{f.Pc=30;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6055(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?55:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/combat/AttackingBand","contains","(Lforge/game/card/Card;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?52:50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 52:{f.Pc=23;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6056(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?62:40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/combat/AttackingBand","getAttackers","()Lforge/game/card/CardCollectionView;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",58);}
case 58:{f.StackOp("pop");f.Pc=59;continue;}
case 59:{f.Pc=31;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6057(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference==null?27:10;continue;}
case 10:{if(!rt.StaticReady(f,"java/lang/Boolean","TRUE","Ljava/lang/Boolean;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","TRUE","Ljava/lang/Boolean;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/combat/AttackingBand","isBlocked","()Ljava/lang/Boolean;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/lang/Boolean","equals","(Ljava/lang/Object;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6058(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttackerNotNull","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/combat/AttackingBand","setBlocked","(Z)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6059(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttackerNotNull","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",5);}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",25);}
case 25:{f.StackOp("pop");f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",44);}
case 44:{f.Pc=f.Pop().Int==0?53:47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/combat/Combat","addBlockerToDamageAssignmentOrder","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",53);}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/combat/Combat","isRealCombat","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?64:60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/Card","updateBlockingForView","()V","invokevirtual",64);}
case 64:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6060(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttackerNotNull","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",5);}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Reference==null?40:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Collection","remove","(Ljava/lang/Object;)Z","invokeinterface",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/combat/Combat","isRealCombat","()Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?51:47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","updateBlockingForView","()V","invokevirtual",51);}
case 51:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6061(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",18);}
case 18:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=21;continue;}
case 21:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",26);}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Collection","removeAll","(Ljava/util/Collection;)Z","invokeinterface",32);}
case 32:{f.StackOp("pop");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/combat/Combat","isRealCombat","()Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?44:40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/card/Card","updateBlockingForView","()V","invokevirtual",44);}
case 44:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6062(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?67:40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int!=0?64:58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Pc=31;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6063(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?64:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",40);}
case 40:{f.Locals[4]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Reference==null?61:47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",52);}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Pc=16;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6064(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/combat/AttackingBand;)Lforge/game/card/CardCollection;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6065(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference!=null?33:23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",30);}
case 30:{f.Pc=41;continue;}
case 33:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",41);}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6066(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?89:40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[4]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?86:68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/combat/AttackingBand","getAttackers","()Lforge/game/card/CardCollectionView;","invokevirtual",82);}
case 82:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Pc=31;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6067(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?86:40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[4]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?83:68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Pc=31;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6068(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?16:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/Card","isFortification","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?24:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","getEnchantingCard","()Lforge/game/card/Card;","invokevirtual",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Pc=36;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/Card","isEquipment","()Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?36:31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","getEquipping","()Lforge/game/card/Card;","invokevirtual",35);}
case 35:{f.Locals[2]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",41);}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6069(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?187:40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/combat/AttackingBand","isEmpty","()Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?60:57;continue;}
case 57:{f.Pc=31;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",69);}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",78);}
case 78:{f.Locals[4]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{f.Pc=f.Pop().Reference==null?31:85;continue;}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",92);}
case 92:{f.Pc=f.Pop().Int==0?98:95;continue;}
case 95:{f.Pc=31;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/combat/AttackingBand","getAttackers","()Lforge/game/card/CardCollectionView;","invokevirtual",102);}
case 102:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",107);}
case 107:{f.Locals[5]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[5]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",116);}
case 116:{f.Pc=f.Pop().Int==0?184:119;continue;}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",126);}
case 126:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=129;continue;}
case 129:{f.Locals[6]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[4]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",138);}
case 138:{f.Push(JValue.I(1));f.Pc=139;continue;}
case 139:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?160:142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[6]);f.Pc=145;continue;}
case 145:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=148;continue;}
case 148:{f.StackOp("dup");f.Pc=149;continue;}
case 149:{f.Push(f.Locals[4]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",154);}
case 154:{return rt.Call(f,"forge/game/combat/Combat","orderBlockersForDamageAssignment","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)V","invokevirtual",157);}
case 157:{f.Pc=181;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[6]);f.Pc=163;continue;}
case 163:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=166;continue;}
case 166:{f.StackOp("dup");f.Pc=167;continue;}
case 167:{f.Push(f.Locals[4]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",172);}
case 172:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",175);}
case 175:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",180);}
case 180:{f.StackOp("pop");f.Pc=181;continue;}
case 181:{f.Pc=109;continue;}
case 184:{f.Pc=31;continue;}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",193);}
case 193:{f.Locals[2]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[2]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",200);}
case 200:{f.Pc=f.Pop().Int==0?234:203;continue;}
case 203:{f.Push(f.Locals[2]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",209);}
case 209:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=212;continue;}
case 212:{f.Locals[3]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[0]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[3]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",218);}
case 218:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[3]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",225);}
case 225:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/combat/Combat","orderBlockersForDamageAssignment","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)V","invokevirtual",231);}
case 231:{f.Pc=194;continue;}
case 234:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6070(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",4);}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?15:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","legacyOrderCombatants","Z"));f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Int!=0?43:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",36);}
case 36:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{return JStep.ReturnVoid;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",50);}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/player/PlayerController","orderBlockers","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Lforge/game/card/CardCollection;","invokevirtual",55);}
case 55:{f.Locals[3]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=79;continue;}
case 79:{f.StackOp("dup");f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",83);}
case 83:{f.Locals[4]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",94);}
case 94:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String(" has ordered blockers for ")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",106);}
case 106:{f.StackOp("pop");f.Pc=107;continue;}
case 107:{f.Push(f.Locals[4]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",113);}
case 113:{f.StackOp("pop");f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String(": ")));f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{f.Push(JValue.I(0));f.Pc=124;continue;}
case 124:{f.Locals[5]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[5]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",132);}
case 132:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?173:135;continue;}
case 135:{f.Push(f.Locals[4]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[5]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",143);}
case 143:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",146);}
case 146:{f.StackOp("pop");f.Pc=147;continue;}
case 147:{f.Push(f.Locals[5]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[3]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",153);}
case 153:{f.Push(JValue.I(1));f.Pc=154;continue;}
case 154:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=155;continue;}
case 155:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?167:158;continue;}
case 158:{f.Push(f.Locals[4]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String(", ")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",166);}
case 166:{f.StackOp("pop");f.Pc=167;continue;}
case 167:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=170;continue;}
case 170:{f.Pc=126;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;"));f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",180);}
case 180:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=183;continue;}
case 183:{f.StackOp("dup");f.Pc=184;continue;}
case 184:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","COMBAT","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","COMBAT","Lforge/game/GameLogEntryType;"));f.Pc=187;continue;}
case 187:{f.Push(f.Locals[4]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",192);}
case 192:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",195);}
case 195:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",198);}
case 198:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6071(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",18);}
case 18:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=21;continue;}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Reference==null?33:26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?63:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",54);}
case 54:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Pc=135;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","legacyOrderCombatants","Z"));f.Pc=67;continue;}
case 67:{f.Pc=f.Pop().Int==0?109:70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",77);}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/player/PlayerController","orderBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CardCollection;)Lforge/game/card/CardCollection;","invokevirtual",83);}
case 83:{f.Locals[4]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=89;continue;}
case 89:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",94);}
case 94:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",105);}
case 105:{f.StackOp("pop");f.Pc=106;continue;}
case 106:{f.Pc=135;continue;}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=119;continue;}
case 119:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",124);}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",134);}
case 134:{f.StackOp("pop");f.Pc=135;continue;}
case 135:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6072(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/Combat","getAllBlockers","()Lforge/game/card/CardCollection;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?35:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/combat/Combat","orderAttackersForDamageAssignment","(Lforge/game/card/Card;)V","invokevirtual",32);}
case 32:{f.Pc=8;continue;}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6073(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",15);}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?26:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","legacyOrderCombatants","Z"));f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Int!=0?30:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Pc=39;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",34);}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/player/PlayerController","orderAttackers","(Lforge/game/card/Card;Lforge/game/card/CardCollection;)Lforge/game/card/CardCollection;","invokevirtual",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6074(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",18);}
case 18:{f.StackOp("pop");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Reference==null?124:42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",48);}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",57);}
case 57:{f.Pc=f.Pop().Int==0?124:60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Locals[5]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",91);}
case 91:{f.Pc=f.Pop().Int==0?121:94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[5]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",113);}
case 113:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Pc=50;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",128);}
case 128:{f.Locals[4]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[4]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",135);}
case 135:{return rt.Call(f,"forge/game/zone/MagicStack","iterator","()Ljava/util/Iterator;","invokevirtual",138);}
case 138:{f.Locals[5]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[5]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",147);}
case 147:{f.Pc=f.Pop().Int==0?261:150;continue;}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",157);}
case 157:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=160;continue;}
case 160:{f.Locals[6]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[6]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","isTrigger","()Z","invokevirtual",167);}
case 167:{f.Pc=f.Pop().Int==0?258:170;continue;}
case 170:{f.Push(f.Locals[1]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[6]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSourceCard","()Lforge/game/card/Card;","invokevirtual",176);}
case 176:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",179);}
case 179:{f.Pc=f.Pop().Int==0?258:182;continue;}
case 182:{f.Push(f.Locals[6]);f.Pc=184;continue;}
case 184:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OriginalDefender","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OriginalDefender","Lforge/game/ability/AbilityKey;"));f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",190);}
case 190:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=193;continue;}
case 193:{f.Locals[7]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[7]);f.Pc=197;continue;}
case 197:{f.Pc=f.Pop().Reference==null?258:200;continue;}
case 200:{f.Push(f.Locals[6]);f.Pc=202;continue;}
case 202:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Defender","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Defender","Lforge/game/ability/AbilityKey;"));f.Pc=205;continue;}
case 205:{f.Push(f.Locals[7]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","updateTriggeringObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)Z","invokevirtual",210);}
case 210:{f.StackOp("pop");f.Pc=211;continue;}
case 211:{f.Push(f.Locals[7]);f.Pc=213;continue;}
case 213:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=216;continue;}
case 216:{f.Pc=f.Pop().Int==0?233:219;continue;}
case 219:{f.Push(f.Locals[6]);f.Pc=221;continue;}
case 221:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=224;continue;}
case 224:{f.Push(f.Locals[7]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","updateTriggeringObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)Z","invokevirtual",229);}
case 229:{f.StackOp("pop");f.Pc=230;continue;}
case 230:{f.Pc=258;continue;}
case 233:{f.Push(f.Locals[7]);f.Pc=235;continue;}
case 235:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=238;continue;}
case 238:{f.Pc=f.Pop().Int==0?258:241;continue;}
case 241:{f.Push(f.Locals[6]);f.Pc=243;continue;}
case 243:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=246;continue;}
case 246:{f.Push(f.Locals[7]);f.Pc=248;continue;}
case 248:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",254);}
case 254:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","updateTriggeringObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)Z","invokevirtual",257);}
case 257:{f.StackOp("pop");f.Pc=258;continue;}
case 258:{f.Pc=140;continue;}
case 261:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6075(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",18);}
case 18:{f.StackOp("pop");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/combat/AttackingBand","getAttackers","()Lforge/game/card/CardCollectionView;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",28);}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?101:38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int==0?98:71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",80);}
case 80:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{f.Pc=29;continue;}
case 101:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6076(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference==null?33:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/combat/Combat","unregisterAttacker","(Lforge/game/card/Card;Lforge/game/combat/AttackingBand;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/combat/AttackingBand","removeAttacker","(Lforge/game/card/Card;)V","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/combat/Combat","isRealCombat","()Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/Card","updateAttackingForView","()V","invokevirtual",32);}
case 32:{return JStep.ReturnVoid;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",50);}
case 50:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",55);}
case 55:{f.Locals[3]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",62);}
case 62:{f.Pc=f.Pop().Int==0?111:65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{f.Locals[4]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?108:93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[4]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",102);}
case 102:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/combat/Combat","unregisterDefender","(Lforge/game/card/Card;Lforge/game/combat/AttackingBand;)V","invokevirtual",108);}
case 108:{f.Pc=56;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackableEntries","Lcom/google/common/base/Supplier;"));f.Pc=115;continue;}
case 115:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",120);}
case 120:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.ClassObject("forge/game/card/Card")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/lang/Iterable;","invokestatic",128);}
case 128:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",133);}
case 133:{f.Locals[3]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",140);}
case 140:{f.Pc=f.Pop().Int==0?306:143;continue;}
case 143:{f.Push(f.Locals[3]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",149);}
case 149:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=152;continue;}
case 152:{f.Locals[4]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[4]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int==0?303:163;continue;}
case 163:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",166);}
case 166:{f.Locals[5]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=172;continue;}
case 172:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",177);}
case 177:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[1]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",186);}
case 186:{f.Locals[6]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(f.Locals[6]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",195);}
case 195:{f.Locals[7]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[7]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",204);}
case 204:{f.Pc=f.Pop().Int==0?273:207;continue;}
case 207:{f.Push(f.Locals[7]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",214);}
case 214:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=217;continue;}
case 217:{f.Locals[8]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[1]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[8]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/combat/Combat","unregisterDefender","(Lforge/game/card/Card;Lforge/game/combat/AttackingBand;)V","invokevirtual",226);}
case 226:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=229;continue;}
case 229:{f.StackOp("dup");f.Pc=230;continue;}
case 230:{f.Push(JValue.I(-1));f.Pc=231;continue;}
case 231:{f.Push(f.Locals[1]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",235);}
case 235:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",238);}
case 238:{f.Locals[9]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[9]);f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("<Nothing>")));f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",248);}
case 248:{f.Push(f.Locals[9]);f.Pc=250;continue;}
case 250:{f.Push(f.Locals[1]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",254);}
case 254:{f.Push(JValue.L(0));f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",258);}
case 258:{f.Push(f.Locals[5]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[9]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[8]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",269);}
case 269:{f.StackOp("pop");f.Pc=270;continue;}
case 270:{f.Pc=197;continue;}
case 273:{f.Push(f.Locals[6]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"java/util/Collection","clear","()V","invokeinterface",280);}
case 280:{f.Push(f.Locals[0]);f.Pc=281;continue;}
case 281:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=284;continue;}
case 284:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",289);}
case 289:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=292;continue;}
case 292:{f.Push(f.Locals[5]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"com/google/common/collect/Multimap","putAll","(Lcom/google/common/collect/Multimap;)Z","invokeinterface",299);}
case 299:{f.StackOp("pop");f.Pc=300;continue;}
case 300:{f.Pc=306;continue;}
case 303:{f.Pc=134;continue;}
case 306:{f.Push(f.Locals[0]);f.Pc=307;continue;}
case 307:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=310;continue;}
case 310:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",315);}
case 315:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=318;continue;}
case 318:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",323);}
case 323:{f.Push(f.Locals[1]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"java/util/Collection","remove","(Ljava/lang/Object;)Z","invokeinterface",329);}
case 329:{f.Pc=f.Pop().Int==0?335:332;continue;}
case 332:{f.Pc=306;continue;}
case 335:{f.Push(f.Locals[0]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/combat/Combat","isRealCombat","()Z","invokevirtual",339);}
case 339:{f.Pc=f.Pop().Int==0?346:342;continue;}
case 342:{f.Push(f.Locals[1]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/card/Card","updateBlockingForView","()V","invokevirtual",346);}
case 346:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6077(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?166:40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/combat/AttackingBand","getAttackers","()Lforge/game/card/CardCollectionView;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",67);}
case 67:{f.Locals[4]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?117:79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",86);}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{f.Locals[5]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?107:99;continue;}
case 99:{f.Push(f.Locals[5]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int!=0?114:107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[5]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",113);}
case 113:{f.StackOp("pop");f.Pc=114;continue;}
case 114:{f.Pc=69;continue;}
case 117:{f.Push(f.Locals[3]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",123);}
case 123:{f.Locals[5]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[5]);f.Pc=127;continue;}
case 127:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=130;continue;}
case 130:{f.Pc=f.Pop().Int==0?163:133;continue;}
case 133:{f.Push(f.Locals[5]);f.Pc=135;continue;}
case 135:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=138;continue;}
case 138:{f.Locals[4]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/card/Card","isBattle","()Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int!=0?163:148;continue;}
case 148:{f.Push(f.Locals[4]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/Card","isPlaneswalker","()Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int!=0?163:156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[4]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",162);}
case 162:{f.StackOp("pop");f.Pc=163;continue;}
case 163:{f.Pc=31;continue;}
case 166:{f.Push(f.Locals[0]);f.Pc=167;continue;}
case 167:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=170;continue;}
case 170:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",175);}
case 175:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=178;continue;}
case 178:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",183);}
case 183:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",188);}
case 188:{f.Locals[2]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[2]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",195);}
case 195:{f.Pc=f.Pop().Int==0?245:198;continue;}
case 198:{f.Push(f.Locals[2]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",204);}
case 204:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=207;continue;}
case 207:{f.Locals[3]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[3]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",214);}
case 214:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=217;continue;}
case 217:{f.Locals[4]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[4]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",224);}
case 224:{f.Pc=f.Pop().Int==0?235:227;continue;}
case 227:{f.Push(f.Locals[4]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",232);}
case 232:{f.Pc=f.Pop().Int!=0?242:235;continue;}
case 235:{f.Push(f.Locals[1]);f.Pc=236;continue;}
case 236:{f.Push(f.Locals[4]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",241);}
case 241:{f.StackOp("pop");f.Pc=242;continue;}
case 242:{f.Pc=189;continue;}
case 245:{f.Push(f.Locals[1]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",249);}
case 249:{f.Pc=f.Pop().Int==0?254:252;continue;}
case 252:{f.Push(JValue.I(0));f.Pc=253;continue;}
case 253:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 254:{f.Push(f.Locals[1]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",258);}
case 258:{f.Locals[2]=f.Pop();f.Pc=259;continue;}
case 259:{f.Push(f.Locals[2]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",265);}
case 265:{f.Pc=f.Pop().Int==0?286:268;continue;}
case 268:{f.Push(f.Locals[2]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",274);}
case 274:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=277;continue;}
case 277:{f.Locals[3]=f.Pop();f.Pc=278;continue;}
case 278:{f.Push(f.Locals[0]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[3]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/combat/Combat","removeFromCombat","(Lforge/game/card/Card;)V","invokevirtual",283);}
case 283:{f.Pc=259;continue;}
case 286:{f.Push(JValue.I(1));f.Pc=287;continue;}
case 287:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6078(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",13);}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",21);}
case 21:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?244:36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",66);}
case 66:{f.Locals[5]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{f.Pc=f.Pop().Reference==null?87:73;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",80);}
case 80:{f.Pc=f.Pop().Int!=0?87:83;continue;}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{f.Pc=88;continue;}
case 87:{f.Push(JValue.I(0));f.Pc=88;continue;}
case 88:{f.Locals[6]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[6]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/combat/AttackingBand","setBlocked","(Z)V","invokevirtual",97);}
case 97:{f.Push(f.Locals[6]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Int!=0?241:102;continue;}
case 102:{f.Push(f.Locals[4]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/combat/AttackingBand","isEmpty","()Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int!=0?241:110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/combat/AttackingBand","getAttackers","()Lforge/game/card/CardCollectionView;","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/game/card/CardCollectionView","getFirst","()Ljava/lang/Object;","invokeinterface",121);}
case 121:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",127);}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/combat/AttackingBand;)Lforge/game/GameEntity;","invokevirtual",133);}
case 133:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",138);}
case 138:{f.StackOp("pop");f.Pc=139;continue;}
case 139:{f.Push(f.Locals[4]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/combat/AttackingBand","getAttackers","()Lforge/game/card/CardCollectionView;","invokevirtual",144);}
case 144:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",149);}
case 149:{f.Locals[7]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[7]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",158);}
case 158:{f.Pc=f.Pop().Int==0?241:161;continue;}
case 161:{f.Push(f.Locals[7]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",168);}
case 168:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=171;continue;}
case 171:{f.Locals[8]=f.Pop();f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",176);}
case 176:{f.Locals[9]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[9]);f.Pc=180;continue;}
case 180:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=183;continue;}
case 183:{f.Push(f.Locals[8]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",190);}
case 190:{f.StackOp("pop");f.Pc=191;continue;}
case 191:{f.Push(f.Locals[9]);f.Pc=193;continue;}
case 193:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Defender","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Defender","Lforge/game/ability/AbilityKey;"));f.Pc=196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[8]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",202);}
case 202:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",207);}
case 207:{f.StackOp("pop");f.Pc=208;continue;}
case 208:{f.Push(f.Locals[9]);f.Pc=210;continue;}
case 210:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=213;continue;}
case 213:{f.Push(f.Locals[0]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[8]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",219);}
case 219:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",224);}
case 224:{f.StackOp("pop");f.Pc=225;continue;}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",229);}
case 229:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackerUnblocked","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackerUnblocked","Lforge/game/trigger/TriggerType;"));f.Pc=232;continue;}
case 232:{f.Push(f.Locals[9]);f.Pc=234;continue;}
case 234:{f.Push(JValue.I(0));f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",238);}
case 238:{f.Pc=151;continue;}
case 241:{f.Pc=27;continue;}
case 244:{f.Push(f.Locals[2]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"com/google/common/collect/Multimap","keySet","()Ljava/util/Set;","invokeinterface",250);}
case 250:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",255);}
case 255:{f.Locals[3]=f.Pop();f.Pc=256;continue;}
case 256:{f.Push(f.Locals[3]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",262);}
case 262:{f.Pc=f.Pop().Int==0?332:265;continue;}
case 265:{f.Push(f.Locals[3]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",271);}
case 271:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=274;continue;}
case 274:{f.Locals[4]=f.Pop();f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",279);}
case 279:{f.Locals[5]=f.Pop();f.Pc=281;continue;}
case 281:{f.Push(f.Locals[5]);f.Pc=283;continue;}
case 283:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AttackingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AttackingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=286;continue;}
case 286:{f.Push(f.Locals[4]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",293);}
case 293:{f.StackOp("pop");f.Pc=294;continue;}
case 294:{f.Push(f.Locals[5]);f.Pc=296;continue;}
case 296:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Defenders","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Defenders","Lforge/game/ability/AbilityKey;"));f.Pc=299;continue;}
case 299:{f.Push(f.Locals[2]);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[4]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",307);}
case 307:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",310);}
case 310:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",315);}
case 315:{f.StackOp("pop");f.Pc=316;continue;}
case 316:{f.Push(f.Locals[1]);f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",320);}
case 320:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackerUnblockedOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackerUnblockedOnce","Lforge/game/trigger/TriggerType;"));f.Pc=323;continue;}
case 323:{f.Push(f.Locals[5]);f.Pc=325;continue;}
case 325:{f.Push(JValue.I(0));f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",329);}
case 329:{f.Pc=256;continue;}
case 332:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6079(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/Combat","getAllBlockers","()Lforge/game/card/CardCollection;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?485:23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/combat/Combat","dealDamageThisPhase","(Lforge/game/card/Card;Z)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int!=0?48:45;continue;}
case 45:{f.Pc=13;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Int==0?70:52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","combatantsThatDealtFirstStrikeDamage","Lcom/google/common/base/Supplier;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",75);}
case 75:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",78);}
case 78:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","AssignDealDamage","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","AssignDealDamage","Lforge/game/replacement/ReplacementType;"));f.Pc=81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",86);}
case 86:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",89);}
case 89:{f.StackOp("pop");f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=94;continue;}
case 94:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",109);}
case 109:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=112;continue;}
case 112:{f.Locals[6]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/Card","getNetCombatDamage","()I","invokevirtual",119);}
case 119:{f.Locals[7]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[6]);f.Pc=123;continue;}
case 123:{f.Pc=f.Pop().Reference==null?482:126;continue;}
case 126:{f.Push(f.Locals[6]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int!=0?482:134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/combat/Combat","getAttackingPlayer","()Lforge/game/player/Player;","invokevirtual",138);}
case 138:{f.Locals[8]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[5]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",145);}
case 145:{f.Locals[9]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(JValue.R(null));f.Pc=148;continue;}
case 148:{f.Locals[10]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("You may assign CARDNAME's combat damage divided as you choose among defending player and/or any number of creatures they control.")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int==0?206:161;continue;}
case 161:{f.Push(f.Locals[5]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",166);}
case 166:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",169);}
case 169:{f.Push(f.Locals[5]);f.Pc=171;continue;}
case 171:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","AlternativeDamageAssignment","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","AlternativeDamageAssignment","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",177);}
case 177:{f.Push(JValue.R(rt.String("lblAssignCombatDamageAsChoose")));f.Pc=180;continue;}
case 180:{f.Push(JValue.I(1));f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=184;continue;}
case 184:{f.StackOp("dup");f.Pc=185;continue;}
case 185:{f.Push(JValue.I(0));f.Pc=186;continue;}
case 186:{f.Push(f.Locals[5]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",191);}
case 191:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",195);}
case 195:{f.Push(JValue.R(null));f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/player/PlayerController","confirmStaticApplication","(Lforge/game/card/Card;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",199);}
case 199:{f.Pc=f.Pop().Int==0?206:202;continue;}
case 202:{f.Push(JValue.I(1));f.Pc=203;continue;}
case 203:{f.Pc=207;continue;}
case 206:{f.Push(JValue.I(0));f.Pc=207;continue;}
case 207:{f.Locals[11]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[11]);f.Pc=211;continue;}
case 211:{f.Pc=f.Pop().Int==0?257:214;continue;}
case 214:{f.Push(f.Locals[5]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",219);}
case 219:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",222);}
case 222:{f.Push(f.Locals[8]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",227);}
case 227:{f.Push(JValue.R(null));f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",231);}
case 231:{f.Push(JValue.R(rt.String("lblChoosePlayer")));f.Pc=234;continue;}
case 234:{f.Push(JValue.I(0));f.Pc=235;continue;}
case 235:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",241);}
case 241:{f.Push(JValue.R(null));f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",245);}
case 245:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=248;continue;}
case 248:{f.Locals[10]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(f.Locals[10]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",255);}
case 255:{f.Locals[6]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[6]);f.Pc=259;continue;}
case 259:{f.Push(JValue.I(1));f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/combat/AttackingBand","isValidBand","(Lforge/game/card/CardCollectionView;Z)Z","invokestatic",263);}
case 263:{f.Pc=f.Pop().Int==0?270:266;continue;}
case 266:{f.Push(f.Locals[8]);f.Pc=268;continue;}
case 268:{f.Locals[9]=f.Pop();f.Pc=270;continue;}
case 270:{f.Push(JValue.I(1));f.Pc=271;continue;}
case 271:{f.Locals[3]=f.Pop();f.Pc=272;continue;}
case 272:{f.Push(f.Locals[9]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",277);}
case 277:{f.Push(f.Locals[5]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[6]);f.Pc=281;continue;}
case 281:{f.Push(JValue.R(null));f.Pc=282;continue;}
case 282:{f.Push(f.Locals[7]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[10]);f.Pc=286;continue;}
case 286:{f.Push(f.Locals[11]);f.Pc=288;continue;}
case 288:{f.Pc=f.Pop().Int!=0?308:291;continue;}
case 291:{f.Push(f.Locals[9]);f.Pc=293;continue;}
case 293:{f.Push(f.Locals[5]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",298);}
case 298:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?308:301;continue;}
case 301:{f.Push(f.Locals[0]);f.Pc=302;continue;}
case 302:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","legacyOrderCombatants","Z"));f.Pc=305;continue;}
case 305:{f.Pc=f.Pop().Int!=0?312:308;continue;}
case 308:{f.Push(JValue.I(1));f.Pc=309;continue;}
case 309:{f.Pc=313;continue;}
case 312:{f.Push(JValue.I(0));f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/player/PlayerController","assignCombatDamage","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;ILforge/game/GameEntity;Z)Ljava/util/Map;","invokevirtual",316);}
case 316:{f.Locals[12]=f.Pop();f.Pc=318;continue;}
case 318:{f.Push(f.Locals[12]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",325);}
case 325:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",330);}
case 330:{f.Locals[13]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[13]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",339);}
case 339:{f.Pc=f.Pop().Int==0?482:342;continue;}
case 342:{f.Push(f.Locals[13]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",349);}
case 349:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=352;continue;}
case 352:{f.Locals[14]=f.Pop();f.Pc=354;continue;}
case 354:{f.Push(f.Locals[14]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",361);}
case 361:{f.Pc=f.Pop().Reference!=null?413:364;continue;}
case 364:{f.Push(f.Locals[14]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",371);}
case 371:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=374;continue;}
case 374:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",377);}
case 377:{f.Pc=f.Pop().Int<=0?413:380;continue;}
case 380:{f.Push(f.Locals[0]);f.Pc=381;continue;}
case 381:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","damageMap","Lcom/google/common/base/Supplier;"));f.Pc=384;continue;}
case 384:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",389);}
case 389:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=392;continue;}
case 392:{f.Push(f.Locals[5]);f.Pc=394;continue;}
case 394:{f.Push(f.Locals[10]);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[14]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",403);}
case 403:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",409);}
case 409:{f.StackOp("pop");f.Pc=410;continue;}
case 410:{f.Pc=479;continue;}
case 413:{f.Push(f.Locals[14]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",420);}
case 420:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=423;continue;}
case 423:{f.Push(f.Locals[14]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",430);}
case 430:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=433;continue;}
case 433:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",436);}
case 436:{f.Push(f.Locals[5]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/game/card/Card","addAssignedDamage","(ILforge/game/card/Card;)V","invokevirtual",441);}
case 441:{f.Push(f.Locals[0]);f.Pc=442;continue;}
case 442:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","damageMap","Lcom/google/common/base/Supplier;"));f.Pc=445;continue;}
case 445:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",450);}
case 450:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[5]);f.Pc=455;continue;}
case 455:{f.Push(f.Locals[14]);f.Pc=457;continue;}
case 457:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",462);}
case 462:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=465;continue;}
case 465:{f.Push(f.Locals[14]);f.Pc=467;continue;}
case 467:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",472);}
case 472:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",478);}
case 478:{f.StackOp("pop");f.Pc=479;continue;}
case 479:{f.Pc=332;continue;}
case 482:{f.Pc=13;continue;}
case 485:{f.Push(f.Locals[3]);f.Pc=486;continue;}
case 486:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6080(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?1139:17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardCollection","getFirst","()Ljava/lang/Object;","invokevirtual",21);}
case 21:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=24;continue;}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/combat/Combat","dealDamageThisPhase","(Lforge/game/card/Card;Z)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?46:36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[5]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Pc=10;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Pc=f.Pop().Int==0?68:50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","combatantsThatDealtFirstStrikeDamage","Lcom/google/common/base/Supplier;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[5]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",67);}
case 67:{f.StackOp("pop");f.Pc=68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",73);}
case 73:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",76);}
case 76:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","AssignDealDamage","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","AssignDealDamage","Lforge/game/replacement/ReplacementType;"));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",84);}
case 84:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/Card","getNetCombatDamage","()I","invokevirtual",93);}
case 93:{f.Locals[6]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[6]);f.Pc=97;continue;}
case 97:{f.Pc=f.Pop().Int>0?110:100;continue;}
case 100:{f.Push(f.Locals[3]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",106);}
case 106:{f.StackOp("pop");f.Pc=107;continue;}
case 107:{f.Pc=10;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[5]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",116);}
case 116:{f.Locals[7]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[7]);f.Pc=120;continue;}
case 120:{f.Pc=f.Pop().Reference!=null?133:123;continue;}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[5]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Pc=10;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/combat/AttackingBand;)Lforge/game/GameEntity;","invokevirtual",139);}
case 139:{f.Locals[8]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[5]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",146);}
case 146:{f.Locals[9]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockersOrderedForDamageAssignment","Lcom/google/common/base/Supplier;"));f.Pc=152;continue;}
case 152:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",157);}
case 157:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[5]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",167);}
case 167:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=170;continue;}
case 170:{f.Locals[2]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[8]);f.Pc=173;continue;}
case 173:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=176;continue;}
case 176:{f.Pc=f.Pop().Int==0?200:179;continue;}
case 179:{f.Push(f.Locals[8]);f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("You assign combat damage of each creature attacking you.")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/GameEntity","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",187);}
case 187:{f.Pc=f.Pop().Int==0?200:190;continue;}
case 190:{f.Push(f.Locals[8]);f.Pc=192;continue;}
case 192:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=195;continue;}
case 195:{f.Locals[9]=f.Pop();f.Pc=197;continue;}
case 197:{f.Pc=225;continue;}
case 200:{f.Push(f.Locals[2]);f.Pc=201;continue;}
case 201:{f.Pc=f.Pop().Reference==null?225:204;continue;}
case 204:{f.Push(f.Locals[2]);f.Pc=205;continue;}
case 205:{f.Push(JValue.I(1));f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/combat/AttackingBand","isValidBand","(Lforge/game/card/CardCollectionView;Z)Z","invokestatic",209);}
case 209:{f.Pc=f.Pop().Int==0?225:212;continue;}
case 212:{f.Push(f.Locals[2]);f.Pc=213;continue;}
case 213:{f.Push(JValue.I(0));f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",217);}
case 217:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",223);}
case 223:{f.Locals[9]=f.Pop();f.Pc=225;continue;}
case 225:{f.Push(JValue.I(0));f.Pc=226;continue;}
case 226:{f.Locals[10]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[5]);f.Pc=230;continue;}
case 230:{f.Push(JValue.I(0));f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/staticability/StaticAbilityAssignCombatDamageAsUnblocked","assignCombatDamageAsUnblocked","(Lforge/game/card/Card;Z)Z","invokestatic",234);}
case 234:{f.Pc=f.Pop().Int==0?240:237;continue;}
case 237:{f.Push(JValue.I(1));f.Pc=238;continue;}
case 238:{f.Locals[10]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[10]);f.Pc=242;continue;}
case 242:{f.Pc=f.Pop().Int!=0?306:245;continue;}
case 245:{f.Push(f.Locals[5]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",250);}
case 250:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",253);}
case 253:{f.Push(f.Locals[5]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/combat/Combat","isBlocked","(Lforge/game/card/Card;)Z","invokevirtual",258);}
case 258:{f.Pc=f.Pop().Int==0?306:261;continue;}
case 261:{f.Push(f.Locals[5]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/staticability/StaticAbilityAssignCombatDamageAsUnblocked","assignCombatDamageAsUnblocked","(Lforge/game/card/Card;)Z","invokestatic",266);}
case 266:{f.Pc=f.Pop().Int==0?306:269;continue;}
case 269:{f.Push(f.Locals[9]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",274);}
case 274:{f.Push(f.Locals[5]);f.Pc=276;continue;}
case 276:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","AlternativeDamageAssignment","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","AlternativeDamageAssignment","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",282);}
case 282:{f.Push(JValue.R(rt.String("lblAssignCombatDamageWerentBlocked")));f.Pc=285;continue;}
case 285:{f.Push(JValue.I(1));f.Pc=286;continue;}
case 286:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=289;continue;}
case 289:{f.StackOp("dup");f.Pc=290;continue;}
case 290:{f.Push(JValue.I(0));f.Pc=291;continue;}
case 291:{f.Push(f.Locals[5]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",296);}
case 296:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",300);}
case 300:{f.Push(JValue.R(null));f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/player/PlayerController","confirmStaticApplication","(Lforge/game/card/Card;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",304);}
case 304:{f.Locals[10]=f.Pop();f.Pc=306;continue;}
case 306:{f.Push(JValue.I(0));f.Pc=307;continue;}
case 307:{f.Locals[11]=f.Pop();f.Pc=309;continue;}
case 309:{f.Push(JValue.I(0));f.Pc=310;continue;}
case 310:{f.Locals[12]=f.Pop();f.Pc=312;continue;}
case 312:{f.Push(f.Locals[5]);f.Pc=314;continue;}
case 314:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","TRAMPLE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","TRAMPLE","Lforge/game/keyword/Keyword;"));f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",320);}
case 320:{f.Locals[13]=f.Pop();f.Pc=322;continue;}
case 322:{f.Push(f.Locals[10]);f.Pc=324;continue;}
case 324:{f.Pc=f.Pop().Int!=0?570:327;continue;}
case 327:{f.Push(f.Locals[0]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/combat/Combat","getDefendersCreatures","()Lforge/game/card/CardCollection;","invokevirtual",331);}
case 331:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",334);}
case 334:{f.Pc=f.Pop().Int<=0?390:337;continue;}
case 337:{f.Push(f.Locals[5]);f.Pc=339;continue;}
case 339:{f.Push(JValue.R(rt.String("You may assign CARDNAME's combat damage divided as you choose among defending player and/or any number of creatures they control.")));f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",345);}
case 345:{f.Pc=f.Pop().Int==0?390:348;continue;}
case 348:{f.Push(f.Locals[9]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",353);}
case 353:{f.Push(f.Locals[5]);f.Pc=355;continue;}
case 355:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","AlternativeDamageAssignment","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","AlternativeDamageAssignment","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",361);}
case 361:{f.Push(JValue.R(rt.String("lblAssignCombatDamageAsChoose")));f.Pc=364;continue;}
case 364:{f.Push(JValue.I(1));f.Pc=365;continue;}
case 365:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=368;continue;}
case 368:{f.StackOp("dup");f.Pc=369;continue;}
case 369:{f.Push(JValue.I(0));f.Pc=370;continue;}
case 370:{f.Push(f.Locals[5]);f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",375);}
case 375:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",379);}
case 379:{f.Push(JValue.R(null));f.Pc=380;continue;}
case 380:{return rt.Call(f,"forge/game/player/PlayerController","confirmStaticApplication","(Lforge/game/card/Card;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",383);}
case 383:{f.Pc=f.Pop().Int==0?390:386;continue;}
case 386:{f.Push(JValue.I(1));f.Pc=387;continue;}
case 387:{f.Pc=391;continue;}
case 390:{f.Push(JValue.I(0));f.Pc=391;continue;}
case 391:{f.Locals[11]=f.Pop();f.Pc=393;continue;}
case 393:{f.Push(f.Locals[8]);f.Pc=395;continue;}
case 395:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=398;continue;}
case 398:{f.Pc=f.Pop().Int==0?414:401;continue;}
case 401:{f.Push(f.Locals[11]);f.Pc=403;continue;}
case 403:{f.Pc=f.Pop().Int==0?414:406;continue;}
case 406:{f.Push(f.Locals[0]);f.Pc=407;continue;}
case 407:{f.Push(f.Locals[5]);f.Pc=409;continue;}
case 409:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",412);}
case 412:{f.Locals[8]=f.Pop();f.Pc=414;continue;}
case 414:{f.Push(f.Locals[5]);f.Pc=416;continue;}
case 416:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",419);}
case 419:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",422);}
case 422:{f.Push(f.Locals[5]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"forge/game/combat/Combat","isBlocked","(Lforge/game/card/Card;)Z","invokevirtual",427);}
case 427:{f.Pc=f.Pop().Int!=0?493:430;continue;}
case 430:{f.Push(f.Locals[0]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/combat/Combat","getDefendersCreatures","()Lforge/game/card/CardCollection;","invokevirtual",434);}
case 434:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",437);}
case 437:{f.Pc=f.Pop().Int<=0?493:440;continue;}
case 440:{f.Push(f.Locals[5]);f.Pc=442;continue;}
case 442:{f.Push(JValue.R(rt.String("If CARDNAME is unblocked, you may have it assign its combat damage to a creature defending player controls.")));f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",448);}
case 448:{f.Pc=f.Pop().Int==0?493:451;continue;}
case 451:{f.Push(f.Locals[9]);f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",456);}
case 456:{f.Push(f.Locals[5]);f.Pc=458;continue;}
case 458:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","AlternativeDamageAssignment","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","AlternativeDamageAssignment","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=461;continue;}
case 461:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",464);}
case 464:{f.Push(JValue.R(rt.String("lblAssignCombatDamageToCreature")));f.Pc=467;continue;}
case 467:{f.Push(JValue.I(1));f.Pc=468;continue;}
case 468:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=471;continue;}
case 471:{f.StackOp("dup");f.Pc=472;continue;}
case 472:{f.Push(JValue.I(0));f.Pc=473;continue;}
case 473:{f.Push(f.Locals[5]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",478);}
case 478:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=479;continue;}
case 479:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",482);}
case 482:{f.Push(JValue.R(null));f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/player/PlayerController","confirmStaticApplication","(Lforge/game/card/Card;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",486);}
case 486:{f.Pc=f.Pop().Int==0?493:489;continue;}
case 489:{f.Push(JValue.I(1));f.Pc=490;continue;}
case 490:{f.Pc=494;continue;}
case 493:{f.Push(JValue.I(0));f.Pc=494;continue;}
case 494:{f.Locals[12]=f.Pop();f.Pc=496;continue;}
case 496:{f.Push(f.Locals[11]);f.Pc=498;continue;}
case 498:{f.Pc=f.Pop().Int==0?570:501;continue;}
case 501:{f.Push(f.Locals[2]);f.Pc=502;continue;}
case 502:{f.Pc=f.Pop().Reference==null?512:505;continue;}
case 505:{f.Push(f.Locals[2]);f.Pc=506;continue;}
case 506:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",509);}
case 509:{f.Pc=f.Pop().Int==0?520:512;continue;}
case 512:{f.Push(f.Locals[0]);f.Pc=513;continue;}
case 513:{return rt.Call(f,"forge/game/combat/Combat","getDefendersCreatures","()Lforge/game/card/CardCollection;","invokevirtual",516);}
case 516:{f.Locals[2]=f.Pop();f.Pc=517;continue;}
case 517:{f.Pc=570;continue;}
case 520:{f.Push(f.Locals[0]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"forge/game/combat/Combat","getDefendersCreatures","()Lforge/game/card/CardCollection;","invokevirtual",524);}
case 524:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",527);}
case 527:{f.Locals[14]=f.Pop();f.Pc=529;continue;}
case 529:{f.Push(f.Locals[14]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",536);}
case 536:{f.Pc=f.Pop().Int==0?570:539;continue;}
case 539:{f.Push(f.Locals[14]);f.Pc=541;continue;}
case 541:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",546);}
case 546:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=549;continue;}
case 549:{f.Locals[15]=f.Pop();f.Pc=551;continue;}
case 551:{f.Push(f.Locals[2]);f.Pc=552;continue;}
case 552:{f.Push(f.Locals[15]);f.Pc=554;continue;}
case 554:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",557);}
case 557:{f.Pc=f.Pop().Int!=0?567:560;continue;}
case 560:{f.Push(f.Locals[2]);f.Pc=561;continue;}
case 561:{f.Push(f.Locals[15]);f.Pc=563;continue;}
case 563:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",566);}
case 566:{f.StackOp("pop");f.Pc=567;continue;}
case 567:{f.Pc=529;continue;}
case 570:{f.Push(JValue.I(1));f.Pc=571;continue;}
case 571:{f.Locals[4]=f.Pop();f.Pc=573;continue;}
case 573:{f.Push(f.Locals[8]);f.Pc=575;continue;}
case 575:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=578;continue;}
case 578:{f.Pc=f.Pop().Int==0?648:581;continue;}
case 581:{f.Push(f.Locals[8]);f.Pc=583;continue;}
case 583:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=586;continue;}
case 586:{return rt.Call(f,"forge/game/card/Card","isBattle","()Z","invokevirtual",589);}
case 589:{f.Pc=f.Pop().Int!=0?648:592;continue;}
case 592:{f.Push(f.Locals[5]);f.Pc=594;continue;}
case 594:{f.Push(JValue.R(rt.String("Trample:Planeswalker")));f.Pc=597;continue;}
case 597:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",600);}
case 600:{f.Pc=f.Pop().Int==0?648:603;continue;}
case 603:{f.Push(f.Locals[2]);f.Pc=604;continue;}
case 604:{f.Pc=f.Pop().Reference==null?614:607;continue;}
case 607:{f.Push(f.Locals[2]);f.Pc=608;continue;}
case 608:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",611);}
case 611:{f.Pc=f.Pop().Int==0?630:614;continue;}
case 614:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=617;continue;}
case 617:{f.StackOp("dup");f.Pc=618;continue;}
case 618:{f.Push(f.Locals[8]);f.Pc=620;continue;}
case 620:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=623;continue;}
case 623:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",626);}
case 626:{f.Locals[2]=f.Pop();f.Pc=627;continue;}
case 627:{f.Pc=640;continue;}
case 630:{f.Push(f.Locals[2]);f.Pc=631;continue;}
case 631:{f.Push(f.Locals[8]);f.Pc=633;continue;}
case 633:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=636;continue;}
case 636:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",639);}
case 639:{f.StackOp("pop");f.Pc=640;continue;}
case 640:{f.Push(f.Locals[0]);f.Pc=641;continue;}
case 641:{f.Push(f.Locals[5]);f.Pc=643;continue;}
case 643:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",646);}
case 646:{f.Locals[8]=f.Pop();f.Pc=648;continue;}
case 648:{f.Push(f.Locals[10]);f.Pc=650;continue;}
case 650:{f.Pc=f.Pop().Int==0?688:653;continue;}
case 653:{f.Push(f.Locals[3]);f.Pc=654;continue;}
case 654:{f.Push(f.Locals[5]);f.Pc=656;continue;}
case 656:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",659);}
case 659:{f.StackOp("pop");f.Pc=660;continue;}
case 660:{f.Push(f.Locals[0]);f.Pc=661;continue;}
case 661:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","damageMap","Lcom/google/common/base/Supplier;"));f.Pc=664;continue;}
case 664:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",669);}
case 669:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=672;continue;}
case 672:{f.Push(f.Locals[5]);f.Pc=674;continue;}
case 674:{f.Push(f.Locals[8]);f.Pc=676;continue;}
case 676:{f.Push(f.Locals[6]);f.Pc=678;continue;}
case 678:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",681);}
case 681:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",684);}
case 684:{f.StackOp("pop");f.Pc=685;continue;}
case 685:{f.Pc=1136;continue;}
case 688:{f.Push(f.Locals[2]);f.Pc=689;continue;}
case 689:{f.Pc=f.Pop().Reference==null?699:692;continue;}
case 692:{f.Push(f.Locals[2]);f.Pc=693;continue;}
case 693:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",696);}
case 696:{f.Pc=f.Pop().Int==0?874:699;continue;}
case 699:{f.Push(f.Locals[3]);f.Pc=700;continue;}
case 700:{f.Push(f.Locals[5]);f.Pc=702;continue;}
case 702:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",705);}
case 705:{f.StackOp("pop");f.Pc=706;continue;}
case 706:{f.Push(f.Locals[12]);f.Pc=708;continue;}
case 708:{f.Pc=f.Pop().Int==0?798:711;continue;}
case 711:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=714;continue;}
case 714:{f.StackOp("dup");f.Pc=715;continue;}
case 715:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Cleanup","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Cleanup","Lforge/game/ability/ApiType;"));f.Pc=718;continue;}
case 718:{f.Push(f.Locals[5]);f.Pc=720;continue;}
case 720:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;)V","invokespecial",723);}
case 723:{f.Locals[14]=f.Pop();f.Pc=725;continue;}
case 725:{f.Push(f.Locals[5]);f.Pc=727;continue;}
case 727:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",730);}
case 730:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",733);}
case 733:{f.Push(f.Locals[0]);f.Pc=734;continue;}
case 734:{return rt.Call(f,"forge/game/combat/Combat","getDefendersCreatures","()Lforge/game/card/CardCollection;","invokevirtual",737);}
case 737:{f.Push(f.Locals[14]);f.Pc=739;continue;}
case 739:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",742);}
case 742:{f.Push(JValue.R(rt.String("lblChooseCreature")));f.Pc=745;continue;}
case 745:{f.Push(JValue.I(0));f.Pc=746;continue;}
case 746:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=749;continue;}
case 749:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",752);}
case 752:{f.Push(JValue.I(1));f.Pc=753;continue;}
case 753:{f.Push(JValue.I(1));f.Pc=754;continue;}
case 754:{f.Push(JValue.I(0));f.Pc=755;continue;}
case 755:{f.Push(JValue.R(null));f.Pc=756;continue;}
case 756:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",759);}
case 759:{f.Push(JValue.I(0));f.Pc=760;continue;}
case 760:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",765);}
case 765:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=768;continue;}
case 768:{f.Locals[15]=f.Pop();f.Pc=770;continue;}
case 770:{f.Push(f.Locals[0]);f.Pc=771;continue;}
case 771:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","damageMap","Lcom/google/common/base/Supplier;"));f.Pc=774;continue;}
case 774:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",779);}
case 779:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=782;continue;}
case 782:{f.Push(f.Locals[5]);f.Pc=784;continue;}
case 784:{f.Push(f.Locals[15]);f.Pc=786;continue;}
case 786:{f.Push(f.Locals[6]);f.Pc=788;continue;}
case 788:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",791);}
case 791:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",794);}
case 794:{f.StackOp("pop");f.Pc=795;continue;}
case 795:{f.Pc=1136;continue;}
case 798:{f.Push(f.Locals[13]);f.Pc=800;continue;}
case 800:{f.Pc=f.Pop().Int!=0?817:803;continue;}
case 803:{if(!rt.StaticReady(f,"java/lang/Boolean","TRUE","Ljava/lang/Boolean;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","TRUE","Ljava/lang/Boolean;"));f.Pc=806;continue;}
case 806:{f.Push(f.Locals[7]);f.Pc=808;continue;}
case 808:{return rt.Call(f,"forge/game/combat/AttackingBand","isBlocked","()Ljava/lang/Boolean;","invokevirtual",811);}
case 811:{return rt.Call(f,"java/lang/Boolean","equals","(Ljava/lang/Object;)Z","invokevirtual",814);}
case 814:{f.Pc=f.Pop().Int!=0?1136:817;continue;}
case 817:{f.Push(f.Locals[8]);f.Pc=819;continue;}
case 819:{f.Pc=f.Pop().Reference!=null?846:822;continue;}
case 822:{f.Push(f.Locals[0]);f.Pc=823;continue;}
case 823:{f.Push(f.Locals[5]);f.Pc=825;continue;}
case 825:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",828);}
case 828:{f.Locals[8]=f.Pop();f.Pc=830;continue;}
case 830:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=833;continue;}
case 833:{f.Push(f.Locals[8]);f.Pc=835;continue;}
case 835:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",838);}
case 838:{return rt.DynamicCall(f,"forge/game/combat/Combat:6080:838:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",843);}
case 843:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",846);}
case 846:{f.Push(f.Locals[0]);f.Pc=847;continue;}
case 847:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","damageMap","Lcom/google/common/base/Supplier;"));f.Pc=850;continue;}
case 850:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",855);}
case 855:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=858;continue;}
case 858:{f.Push(f.Locals[5]);f.Pc=860;continue;}
case 860:{f.Push(f.Locals[8]);f.Pc=862;continue;}
case 862:{f.Push(f.Locals[6]);f.Pc=864;continue;}
case 864:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",867);}
case 867:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",870);}
case 870:{f.StackOp("pop");f.Pc=871;continue;}
case 871:{f.Pc=1136;continue;}
case 874:{f.Push(f.Locals[9]);f.Pc=876;continue;}
case 876:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",879);}
case 879:{f.Push(f.Locals[5]);f.Pc=881;continue;}
case 881:{f.Push(f.Locals[2]);f.Pc=882;continue;}
case 882:{f.Push(f.Locals[3]);f.Pc=883;continue;}
case 883:{f.Push(f.Locals[6]);f.Pc=885;continue;}
case 885:{f.Push(f.Locals[8]);f.Pc=887;continue;}
case 887:{f.Push(f.Locals[11]);f.Pc=889;continue;}
case 889:{f.Pc=f.Pop().Int!=0?909:892;continue;}
case 892:{f.Push(f.Locals[5]);f.Pc=894;continue;}
case 894:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",897);}
case 897:{f.Push(f.Locals[9]);f.Pc=899;continue;}
case 899:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?909:902;continue;}
case 902:{f.Push(f.Locals[0]);f.Pc=903;continue;}
case 903:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","legacyOrderCombatants","Z"));f.Pc=906;continue;}
case 906:{f.Pc=f.Pop().Int!=0?913:909;continue;}
case 909:{f.Push(JValue.I(1));f.Pc=910;continue;}
case 910:{f.Pc=914;continue;}
case 913:{f.Push(JValue.I(0));f.Pc=914;continue;}
case 914:{return rt.Call(f,"forge/game/player/PlayerController","assignCombatDamage","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;ILforge/game/GameEntity;Z)Ljava/util/Map;","invokevirtual",917);}
case 917:{f.Locals[14]=f.Pop();f.Pc=919;continue;}
case 919:{f.Push(f.Locals[3]);f.Pc=920;continue;}
case 920:{f.Push(f.Locals[5]);f.Pc=922;continue;}
case 922:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",925);}
case 925:{f.StackOp("pop");f.Pc=926;continue;}
case 926:{f.Push(f.Locals[14]);f.Pc=928;continue;}
case 928:{f.Pc=f.Pop().Reference!=null?941:931;continue;}
case 931:{f.Push(f.Locals[3]);f.Pc=932;continue;}
case 932:{f.Push(f.Locals[5]);f.Pc=934;continue;}
case 934:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",937);}
case 937:{f.StackOp("pop");f.Pc=938;continue;}
case 938:{f.Pc=10;continue;}
case 941:{f.Push(f.Locals[14]);f.Pc=943;continue;}
case 943:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",948);}
case 948:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",953);}
case 953:{f.Locals[15]=f.Pop();f.Pc=955;continue;}
case 955:{f.Push(f.Locals[15]);f.Pc=957;continue;}
case 957:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",962);}
case 962:{f.Pc=f.Pop().Int==0?1136:965;continue;}
case 965:{f.Push(f.Locals[15]);f.Pc=967;continue;}
case 967:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",972);}
case 972:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=975;continue;}
case 975:{f.Locals[16]=f.Pop();f.Pc=977;continue;}
case 977:{f.Push(f.Locals[16]);f.Pc=979;continue;}
case 979:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",984);}
case 984:{f.Pc=f.Pop().Reference!=null?1067:987;continue;}
case 987:{f.Push(f.Locals[16]);f.Pc=989;continue;}
case 989:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",994);}
case 994:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=997;continue;}
case 997:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1000);}
case 1000:{f.Pc=f.Pop().Int<=0?1133:1003;continue;}
case 1003:{f.Push(f.Locals[8]);f.Pc=1005;continue;}
case 1005:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1008;continue;}
case 1008:{f.Pc=f.Pop().Int==0?1034:1011;continue;}
case 1011:{f.Push(f.Locals[8]);f.Pc=1013;continue;}
case 1013:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1016;continue;}
case 1016:{f.Push(f.Locals[16]);f.Pc=1018;continue;}
case 1018:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",1023);}
case 1023:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1026;continue;}
case 1026:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1029);}
case 1029:{f.Push(f.Locals[5]);f.Pc=1031;continue;}
case 1031:{return rt.Call(f,"forge/game/card/Card","addAssignedDamage","(ILforge/game/card/Card;)V","invokevirtual",1034);}
case 1034:{f.Push(f.Locals[0]);f.Pc=1035;continue;}
case 1035:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","damageMap","Lcom/google/common/base/Supplier;"));f.Pc=1038;continue;}
case 1038:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",1043);}
case 1043:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1046;continue;}
case 1046:{f.Push(f.Locals[5]);f.Pc=1048;continue;}
case 1048:{f.Push(f.Locals[8]);f.Pc=1050;continue;}
case 1050:{f.Push(f.Locals[16]);f.Pc=1052;continue;}
case 1052:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",1057);}
case 1057:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1060;continue;}
case 1060:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",1063);}
case 1063:{f.StackOp("pop");f.Pc=1064;continue;}
case 1064:{f.Pc=1133;continue;}
case 1067:{f.Push(f.Locals[16]);f.Pc=1069;continue;}
case 1069:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",1074);}
case 1074:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1077;continue;}
case 1077:{f.Push(f.Locals[16]);f.Pc=1079;continue;}
case 1079:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",1084);}
case 1084:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1087;continue;}
case 1087:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1090);}
case 1090:{f.Push(f.Locals[5]);f.Pc=1092;continue;}
case 1092:{return rt.Call(f,"forge/game/card/Card","addAssignedDamage","(ILforge/game/card/Card;)V","invokevirtual",1095);}
case 1095:{f.Push(f.Locals[0]);f.Pc=1096;continue;}
case 1096:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","damageMap","Lcom/google/common/base/Supplier;"));f.Pc=1099;continue;}
case 1099:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",1104);}
case 1104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1107;continue;}
case 1107:{f.Push(f.Locals[5]);f.Pc=1109;continue;}
case 1109:{f.Push(f.Locals[16]);f.Pc=1111;continue;}
case 1111:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",1116);}
case 1116:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1119;continue;}
case 1119:{f.Push(f.Locals[16]);f.Pc=1121;continue;}
case 1121:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",1126);}
case 1126:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1129;continue;}
case 1129:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",1132);}
case 1132:{f.StackOp("pop");f.Pc=1133;continue;}
case 1133:{f.Pc=955;continue;}
case 1136:{f.Pc=10;continue;}
case 1139:{f.Push(f.Locals[4]);f.Pc=1141;continue;}
case 1141:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6081(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","hasDoubleStrike","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int==0?22:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","hasFirstStrike","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?22:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Int!=0?49:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","combatantsThatDealtFirstStrikeDamage","Lcom/google/common/base/Supplier;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int!=0?49:45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{f.Pc=50;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6082(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/Combat","assignAttackersDamage","(Z)Z","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/combat/Combat","assignBlockersDamage","(Z)Z","invokevirtual",12);}
case 12:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Int!=0?33:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","combatantsThatDealtFirstStrikeDamage","Lcom/google/common/base/Supplier;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",33);}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6083(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","playerWhoAttacks","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","copyLastState","()V","invokevirtual",12);}
case 12:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",27);}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",32);}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","damageMap","Lcom/google/common/base/Supplier;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/GameAction","dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V","invokevirtual",51);}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/Game","copyLastState","()V","invokevirtual",55);}
case 55:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6084(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference==null?27:10;continue;}
case 10:{if(!rt.StaticReady(f,"java/lang/Boolean","FALSE","Ljava/lang/Boolean;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","FALSE","Ljava/lang/Boolean;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/combat/AttackingBand","isBlocked","()Ljava/lang/Boolean;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/lang/Boolean","equals","(Ljava/lang/Object;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6085(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?75:40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[3]=f.Pop();f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"java/lang/Boolean","FALSE","Ljava/lang/Boolean;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","FALSE","Ljava/lang/Boolean;"));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/combat/AttackingBand","isBlocked","()Ljava/lang/Boolean;","invokevirtual",57);}
case 57:{return rt.Call(f,"java/lang/Boolean","equals","(Ljava/lang/Object;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?72:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/combat/AttackingBand","getAttackers","()Lforge/game/card/CardCollectionView;","invokevirtual",68);}
case 68:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Pc=31;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6086(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/collect/Multimap","keySet","()Ljava/util/Set;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?172:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Int==0?56:49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Pc=57;continue;}
case 56:{f.Push(JValue.R(null));f.Pc=57;continue;}
case 57:{f.Locals[4]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(JValue.R(null));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?89:65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",71);}
case 71:{return rt.Call(f,"forge/game/player/Player","sharesTeamWith","(Lforge/game/player/Player;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int!=0?89:77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/Card","getProtectingPlayer","()Lforge/game/player/Player;","invokevirtual",83);}
case 83:{return rt.Call(f,"forge/game/player/Player","sharesTeamWith","(Lforge/game/player/Player;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int==0?23:89;continue;}
case 89:{f.Push(JValue.R(null));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?109:95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/player/Player","sharesTeamWith","(Lforge/game/player/Player;)Z","invokevirtual",103);}
case 103:{f.Pc=f.Pop().Int!=0?109:106;continue;}
case 106:{f.Pc=23;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=113;continue;}
case 113:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",118);}
case 118:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[3]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",127);}
case 127:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",132);}
case 132:{f.Locals[5]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[5]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",141);}
case 141:{f.Pc=f.Pop().Int==0?169:144;continue;}
case 144:{f.Push(f.Locals[5]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",151);}
case 151:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=154;continue;}
case 154:{f.Locals[6]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[6]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/combat/AttackingBand","isEmpty","()Z","invokevirtual",161);}
case 161:{f.Pc=f.Pop().Int!=0?166:164;continue;}
case 164:{f.Push(JValue.I(1));f.Pc=165;continue;}
case 165:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 166:{f.Pc=134;continue;}
case 169:{f.Pc=23;continue;}
case 172:{f.Push(JValue.I(0));f.Pc=173;continue;}
case 173:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6087(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"com/google/common/collect/Multimap","containsValue","(Ljava/lang/Object;)Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?23:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?32:30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","lkiCache","Lcom/google/common/base/Supplier;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/CardCollection","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/Card","getCombatLKI","()Lforge/game/combat/CombatLki;","invokevirtual",54);}
case 54:{f.Locals[2]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(JValue.R(null));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?71:60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/CombatLki","isAttacker","Z"));f.Pc=64;continue;}
case 64:{f.Pc=f.Pop().Int!=0?71:67;continue;}
case 67:{f.Push(JValue.I(1));f.Pc=68;continue;}
case 68:{f.Pc=72;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6088(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",5);}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","blockedBands","Lcom/google/common/base/Supplier;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Reference==null?44:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",39);}
case 39:{f.Pc=f.Pop().Int==0?44:42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int!=0?53:51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","lkiCache","Lcom/google/common/base/Supplier;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/CardCollection","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",69);}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/Card","getCombatLKI","()Lforge/game/combat/CombatLki;","invokevirtual",75);}
case 75:{f.Locals[5]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(JValue.R(null));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[5]);f.Pc=80;continue;}
case 80:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?109:83;continue;}
case 83:{f.Push(f.Locals[5]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/CombatLki","isAttacker","Z"));f.Pc=88;continue;}
case 88:{f.Pc=f.Pop().Int!=0?109:91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/CombatLki","relatedBands","Lforge/util/collect/FCollectionView;"));f.Pc=96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/util/collect/FCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",102);}
case 102:{f.Pc=f.Pop().Int==0?109:105;continue;}
case 105:{f.Push(JValue.I(1));f.Pc=106;continue;}
case 106:{f.Pc=110;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6089(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?12:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference==null?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Int==0?113:36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{f.Locals[5]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","attackedByBands","Lcom/google/common/base/Supplier;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",56);}
case 56:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",61);}
case 61:{f.Locals[6]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",70);}
case 70:{f.Pc=f.Pop().Int==0?103:73;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",80);}
case 80:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=83;continue;}
case 83:{f.Locals[7]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/combat/AttackingBand","contains","(Lforge/game/card/Card;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?100:94;continue;}
case 94:{f.Push(JValue.I(1));f.Pc=95;continue;}
case 95:{f.Locals[5]=f.Pop();f.Pc=97;continue;}
case 97:{f.Pc=103;continue;}
case 100:{f.Pc=63;continue;}
case 103:{f.Push(f.Locals[5]);f.Pc=105;continue;}
case 105:{f.Pc=f.Pop().Int!=0?110:108;continue;}
case 108:{f.Push(JValue.R(null));f.Pc=109;continue;}
case 109:{return JStep.Return(f.Pop());}
case 110:{f.Pc=130;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/combat/Combat","getAttackingBandsBlockedBy","(Lforge/game/card/Card;)Lforge/util/collect/FCollectionView;","invokevirtual",118);}
case 118:{f.Locals[2]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[2]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",125);}
case 125:{f.Pc=f.Pop().Int==0?130:128;continue;}
case 128:{f.Push(JValue.R(null));f.Pc=129;continue;}
case 129:{return JStep.Return(f.Pop());}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/Combat","lkiCache","Lcom/google/common/base/Supplier;"));f.Pc=134;continue;}
case 134:{return rt.Call(f,"com/google/common/base/Supplier","get","()Ljava/lang/Object;","invokeinterface",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",146);}
case 146:{f.StackOp("pop");f.Pc=147;continue;}
case 147:{f.Push(f.Locals[4]);f.Pc=149;continue;}
case 149:{f.Pc=f.Pop().Int==0?163:152;continue;}
case 152:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=155;continue;}
case 155:{f.StackOp("dup");f.Pc=156;continue;}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Object;)V","invokespecial",160);}
case 160:{f.Pc=164;continue;}
case 163:{f.Push(f.Locals[2]);f.Pc=164;continue;}
case 164:{f.Locals[5]=f.Pop();f.Pc=166;continue;}
case 166:{if(!rt.EnsureInitialized(f,"forge/game/combat/CombatLki"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/CombatLki")));f.Pc=169;continue;}
case 169:{f.StackOp("dup");f.Pc=170;continue;}
case 170:{f.Push(f.Locals[4]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[5]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/combat/CombatLki","<init>","(ZLforge/util/collect/FCollectionView;)V","invokespecial",177);}
case 177:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6090(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",3);}
case 3:{return rt.Call(f,"com/google/common/collect/Multimaps","synchronizedMultimap","(Lcom/google/common/collect/Multimap;)Lcom/google/common/collect/Multimap;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6091(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",3);}
case 3:{return rt.Call(f,"com/google/common/collect/Multimaps","synchronizedMultimap","(Lcom/google/common/collect/Multimap;)Lcom/google/common/collect/Multimap;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C515{
internal static JClass Build(){var c=new JClass("forge/game/combat/CombatUtil","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(6094,"forge/game/combat/CombatUtil","<init>","()V",1,1,1,new JHandler[]{},M6094));
c.Add(new JMethod(6095,"forge/game/combat/CombatUtil","getAllPossibleDefenders","(Lforge/game/player/Player;)Lforge/util/collect/FCollectionView;",9,6,2,new JHandler[]{},M6095));
c.Add(new JMethod(6096,"forge/game/combat/CombatUtil","validateAttackers","(Lforge/game/combat/Combat;)Z",9,4,2,new JHandler[]{},M6096));
c.Add(new JMethod(6097,"forge/game/combat/CombatUtil","couldAttackButNotAttacking","(Lforge/game/combat/Combat;Lforge/game/card/Card;)Z",9,6,6,new JHandler[]{},M6097));
c.Add(new JMethod(6098,"forge/game/combat/CombatUtil","canAttack","(Lforge/game/player/Player;)Z",9,2,1,new JHandler[]{},M6098));
c.Add(new JMethod(6099,"forge/game/combat/CombatUtil","getPossibleAttackers","(Lforge/game/player/Player;)Lforge/game/card/CardCollection;",9,1,2,new JHandler[]{},M6099));
c.Add(new JMethod(6100,"forge/game/combat/CombatUtil","canAttack","(Lforge/game/card/Card;)Z",9,1,2,new JHandler[]{},M6100));
c.Add(new JMethod(6101,"forge/game/combat/CombatUtil","canAttack","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z",9,2,3,new JHandler[]{},M6101));
c.Add(new JMethod(6102,"forge/game/combat/CombatUtil","canAttackNextTurn","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z",9,2,3,new JHandler[]{},M6102));
c.Add(new JMethod(6103,"forge/game/combat/CombatUtil","canAttack","(Lforge/game/card/Card;Lforge/game/GameEntity;Z)Z",10,7,3,new JHandler[]{},M6103));
c.Add(new JMethod(6104,"forge/game/combat/CombatUtil","isAttackerSick","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z",9,2,2,new JHandler[]{},M6104));
c.Add(new JMethod(6105,"forge/game/combat/CombatUtil","checkPropagandaEffects","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/combat/Combat;Ljava/util/List;)Z",9,6,5,new JHandler[]{},M6105));
c.Add(new JMethod(6106,"forge/game/combat/CombatUtil","getAttackCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/GameEntity;)Lforge/game/cost/Cost;",9,3,4,new JHandler[]{},M6106));
c.Add(new JMethod(6107,"forge/game/combat/CombatUtil","getAttackCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/util/List;)Lforge/game/cost/Cost;",9,11,4,new JHandler[]{},M6107));
c.Add(new JMethod(6108,"forge/game/combat/CombatUtil","getOptionalAttackCostCreatures","(Lforge/game/card/CardCollection;Ljava/lang/Class;)Lforge/game/card/CardCollection;",9,7,3,new JHandler[]{},M6108));
c.Add(new JMethod(6109,"forge/game/combat/CombatUtil","payRequiredBlockCosts","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;)Z",9,5,5,new JHandler[]{},M6109));
c.Add(new JMethod(6110,"forge/game/combat/CombatUtil","getBlockCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/cost/Cost;",9,10,4,new JHandler[]{},M6110));
c.Add(new JMethod(6111,"forge/game/combat/CombatUtil","checkDeclaredAttacker","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/combat/Combat;Z)V",9,10,4,new JHandler[]{},M6111));
c.Add(new JMethod(6112,"forge/game/combat/CombatUtil","getAllRequirements","(Lforge/game/combat/Combat;)Lforge/game/combat/AttackConstraints;",9,1,3,new JHandler[]{},M6112));
c.Add(new JMethod(6113,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/combat/Combat;)Z",9,4,3,new JHandler[]{},M6113));
c.Add(new JMethod(6114,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;)Z",9,1,2,new JHandler[]{},M6114));
c.Add(new JMethod(6115,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Z)Z",9,4,2,new JHandler[]{},M6115));
c.Add(new JMethod(6116,"forge/game/combat/CombatUtil","canBlockMoreCreatures","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;)Z",9,3,2,new JHandler[]{},M6116));
c.Add(new JMethod(6117,"forge/game/combat/CombatUtil","canBeBlocked","(Lforge/game/card/Card;Lforge/game/combat/Combat;Lforge/game/player/Player;)Z",9,4,3,new JHandler[]{},M6117));
c.Add(new JMethod(6118,"forge/game/combat/CombatUtil","canBlockAtLeastOne","(Lforge/game/card/Card;Ljava/lang/Iterable;)Z",9,4,2,new JHandler[]{},M6118));
c.Add(new JMethod(6119,"forge/game/combat/CombatUtil","canBeBlocked","(Lforge/game/card/Card;Ljava/util/List;Lforge/game/combat/Combat;)Z",9,6,3,new JHandler[]{},M6119));
c.Add(new JMethod(6120,"forge/game/combat/CombatUtil","getPotentialBestBlockers","(Lforge/game/card/Card;Ljava/util/List;Lforge/game/combat/Combat;)Ljava/util/List;",9,7,3,new JHandler[]{},M6120));
c.Add(new JMethod(6121,"forge/game/combat/CombatUtil","findFreeBlockers","(Ljava/util/List;Lforge/game/combat/Combat;)Ljava/util/List;",9,10,3,new JHandler[]{},M6121));
c.Add(new JMethod(6122,"forge/game/combat/CombatUtil","validateBlocks","(Lforge/game/combat/Combat;Lforge/game/player/Player;)Ljava/lang/String;",9,16,5,new JHandler[]{},M6122));
c.Add(new JMethod(6123,"forge/game/combat/CombatUtil","validateTeamBlock","(Lforge/game/combat/Combat;Lforge/game/player/Player;)Ljava/lang/String;",9,2,4,new JHandler[]{},M6123));
c.Add(new JMethod(6124,"forge/game/combat/CombatUtil","validateBlockRestrictions","(Lforge/game/combat/Combat;Lforge/game/player/Player;Ljava/util/List;)Ljava/lang/String;",9,10,4,new JHandler[]{},M6124));
c.Add(new JMethod(6125,"forge/game/combat/CombatUtil","mustBlockAnAttacker","(Lforge/game/card/Card;Lforge/game/combat/Combat;Ljava/util/List;)Z",9,11,4,new JHandler[]{},M6125));
c.Add(new JMethod(6126,"forge/game/combat/CombatUtil","attackerLureSatisfied","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z",10,7,5,new JHandler[]{},M6126));
c.Add(new JMethod(6127,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/player/Player;Lforge/game/combat/Combat;)Z",9,8,3,new JHandler[]{},M6127));
c.Add(new JMethod(6128,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/combat/Combat;)Z",9,8,5,new JHandler[]{},M6128));
c.Add(new JMethod(6129,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",9,2,3,new JHandler[]{},M6129));
c.Add(new JMethod(6130,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;Z)Z",9,3,2,new JHandler[]{},M6130));
c.Add(new JMethod(6131,"forge/game/combat/CombatUtil","canAttackerBeBlockedWithAmount","(Lforge/game/card/Card;ILforge/game/combat/Combat;)Z",9,3,4,new JHandler[]{},M6131));
c.Add(new JMethod(6132,"forge/game/combat/CombatUtil","canAttackerBeBlockedWithAmount","(Lforge/game/card/Card;ILforge/game/player/Player;)Z",9,4,2,new JHandler[]{},M6132));
c.Add(new JMethod(6133,"forge/game/combat/CombatUtil","getMinNumBlockersForAttacker","(Lforge/game/card/Card;Lforge/game/player/Player;)I",9,2,2,new JHandler[]{},M6133));
c.Add(new JMethod(6134,"forge/game/combat/CombatUtil","lambda$mustBlockAnAttacker$2","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;Lforge/game/card/Card;)Z",4106,3,2,new JHandler[]{},M6134));
c.Add(new JMethod(6135,"forge/game/combat/CombatUtil","lambda$canAttack$1","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z",4106,2,2,new JHandler[]{},M6135));
c.Add(new JMethod(6136,"forge/game/combat/CombatUtil","lambda$couldAttackButNotAttacking$0","(Lforge/game/card/Card;Lforge/game/Game;Ljava/util/Map;Lforge/game/combat/AttackConstraints;Lorg/apache/commons/lang3/tuple/Pair;Lforge/game/GameEntity;)Z",4106,7,3,new JHandler[]{},M6136));
}

internal static JStep M6094(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6095(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?53:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",40);}
case 40:{f.StackOp("pop");f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/player/Player","getPlaneswalkersInPlay","()Lforge/game/card/CardCollection;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Pc=16;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",57);}
case 57:{f.Locals[2]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",65);}
case 65:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","BATTLES","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","BATTLES","Ljava/util/function/Predicate;"));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",71);}
case 71:{f.Locals[3]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",76);}
case 76:{f.Locals[4]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",85);}
case 85:{f.Pc=f.Pop().Int==0?122:88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",95);}
case 95:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=98;continue;}
case 98:{f.Locals[5]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/Card","getProtectingPlayer","()Lforge/game/player/Player;","invokevirtual",105);}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?119:112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[5]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",118);}
case 118:{f.StackOp("pop");f.Pc=119;continue;}
case 119:{f.Pc=78;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6096(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/Combat","getAttackConstraints","()Lforge/game/combat/AttackConstraints;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/combat/Combat","getAttackersAndDefenders","()Ljava/util/Map;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/combat/AttackConstraints","countViolations","(Ljava/util/Map;)I","invokevirtual",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(-1));f.Pc=16;continue;}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?21:19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/combat/AttackConstraints","getLegalAttackers","()Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",37);}
case 37:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?44:40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{f.Pc=45;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6097(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?19:4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"forge/game/combat/Combat"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/Combat")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/combat/Combat","<init>","(Lforge/game/player/Player;)V","invokespecial",15);}
case 15:{f.Locals[0]=f.Pop();f.Pc=16;continue;}
case 16:{f.Pc=29;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/combat/Combat","isAttacking","(Lforge/game/card/Card;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?29:27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/combat/Combat","getAttackConstraints","()Lforge/game/combat/AttackConstraints;","invokevirtual",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/combat/AttackConstraints","getLegalAttackers","()Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",38);}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/combat/Combat","getAttackersAndDefenders","()Ljava/util/Map;","invokevirtual",47);}
case 47:{return rt.Call(f,"java/util/HashMap","<init>","(Ljava/util/Map;)V","invokespecial",50);}
case 50:{f.Locals[4]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",56);}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/combat/CombatUtil","getAllPossibleDefenders","(Lforge/game/player/Player;)Lforge/util/collect/FCollectionView;","invokestatic",65);}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{return rt.DynamicCall(f,"forge/game/combat/CombatUtil:6097:72:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Lforge/game/Game;Ljava/util/Map;Lforge/game/combat/AttackConstraints;Lorg/apache/commons/lang3/tuple/Pair;)Ljava/util/function/Predicate;",77);}
case 77:{return rt.Call(f,"forge/util/collect/FCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",82);}
case 82:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6098(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/CombatUtil","getPossibleAttackers","(Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int!=0?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6099(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/game/combat/CombatUtil:6099:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",9);}
case 9:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6100(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/combat/CombatUtil","getAllPossibleDefenders","(Lforge/game/player/Player;)Lforge/util/collect/FCollectionView;","invokestatic",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/game/combat/CombatUtil:6100:8:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",13);}
case 13:{return rt.Call(f,"forge/util/collect/FCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",18);}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6101(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/combat/CombatUtil","canAttack","(Lforge/game/card/Card;Lforge/game/GameEntity;Z)Z","invokestatic",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6102(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/combat/CombatUtil","canAttack","(Lforge/game/card/Card;Lforge/game/GameEntity;Z)Z","invokestatic",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6103(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","isBattle","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?14:12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Int!=0?65:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?63:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int!=0?63:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int!=0?63:39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/combat/CombatUtil","isAttackerSick","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z","invokestatic",44);}
case 44:{f.Pc=f.Pop().Int!=0?63:47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",54);}
case 54:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/phase/PhaseType","isAfter","(Lforge/game/phase/PhaseType;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?65:63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/Card","isGoaded","()Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?198:72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=76;continue;}
case 76:{f.Pc=f.Pop().Int==0?94:79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/Card","isGoadedBy","(Lforge/game/player/Player;)Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int==0?94:90;continue;}
case 90:{f.Push(JValue.I(1));f.Pc=91;continue;}
case 91:{f.Pc=95;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{f.Locals[4]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Int!=0?109:102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=106;continue;}
case 106:{f.Pc=f.Pop().Int!=0?198:109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",113);}
case 113:{return rt.Call(f,"forge/game/combat/CombatUtil","getAllPossibleDefenders","(Lforge/game/player/Player;)Lforge/util/collect/FCollectionView;","invokestatic",116);}
case 116:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",121);}
case 121:{f.Locals[5]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",130);}
case 130:{f.Pc=f.Pop().Int==0?198:133;continue;}
case 133:{f.Push(f.Locals[5]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",140);}
case 140:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=143;continue;}
case 143:{f.Locals[6]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[6]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/GameEntity","equals","(Ljava/lang/Object;)Z","invokevirtual",151);}
case 151:{f.Pc=f.Pop().Int!=0?195:154;continue;}
case 154:{f.Push(f.Locals[6]);f.Pc=156;continue;}
case 156:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=159;continue;}
case 159:{f.Pc=f.Pop().Int==0?195:162;continue;}
case 162:{f.Push(f.Locals[0]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[6]);f.Pc=165;continue;}
case 165:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/card/Card","isGoadedBy","(Lforge/game/player/Player;)Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int!=0?195:174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[6]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/combat/CombatUtil","canAttack","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z","invokestatic",180);}
case 180:{f.Pc=f.Pop().Int==0?195:183;continue;}
case 183:{f.Push(f.Locals[3]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[6]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/combat/CombatUtil","getAttackCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/GameEntity;)Lforge/game/cost/Cost;","invokestatic",190);}
case 190:{f.Pc=f.Pop().Reference!=null?195:193;continue;}
case 193:{f.Push(JValue.I(0));f.Pc=194;continue;}
case 194:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 195:{f.Pc=123;continue;}
case 198:{f.Push(f.Locals[0]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[1]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttackBlock","cantAttack","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z","invokestatic",203);}
case 203:{f.Pc=f.Pop().Int==0?208:206;continue;}
case 206:{f.Push(JValue.I(0));f.Pc=207;continue;}
case 207:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 208:{f.Push(JValue.I(1));f.Pc=209;continue;}
case 209:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6104(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttackBlock","canAttackHaste","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z","invokestatic",5);}
case 5:{f.Pc=f.Pop().Int!=0?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6105(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",7);}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/combat/CombatUtil","getAttackCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/util/List;)Lforge/game/cost/Cost;","invokestatic",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference!=null?20:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/card/Card;Lforge/game/player/Player;)V","invokespecial",32);}
case 32:{f.Locals[5]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",40);}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",43);}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPayCosts","(Lforge/game/cost/Cost;)V","invokevirtual",50);}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("X")));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("0")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",61);}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",65);}
case 65:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",68);}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",77);}
case 77:{return rt.DynamicCall(f,"forge/game/combat/CombatUtil:6105:77:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",82);}
case 82:{return rt.Call(f,"forge/game/player/PlayerController","payCombatCost","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z","invokevirtual",85);}
case 85:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6106(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",6);}
case 6:{return rt.Call(f,"forge/game/combat/CombatUtil","getAttackCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/util/List;)Lforge/game/cost/Cost;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6107(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",28);}
case 28:{f.Locals[6]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[6]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?119:40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Locals[7]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[7]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",57);}
case 57:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",62);}
case 62:{f.Locals[8]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[8]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",71);}
case 71:{f.Pc=f.Pop().Int==0?116:74;continue;}
case 74:{f.Push(f.Locals[8]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{f.Locals[9]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[9]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[3]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/staticability/StaticAbility","getAttackCost","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/util/List;)Lforge/game/cost/Cost;","invokevirtual",94);}
case 94:{f.Locals[10]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(JValue.R(null));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[10]);f.Pc=99;continue;}
case 99:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?113:102;continue;}
case 102:{f.Push(f.Locals[4]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[10]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",109);}
case 109:{f.StackOp("pop");f.Pc=110;continue;}
case 110:{f.Push(JValue.I(1));f.Pc=111;continue;}
case 111:{f.Locals[5]=f.Pop();f.Pc=113;continue;}
case 113:{f.Pc=64;continue;}
case 116:{f.Pc=30;continue;}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{f.Pc=f.Pop().Int!=0?126:124;continue;}
case 124:{f.Push(JValue.R(null));f.Pc=125;continue;}
case 125:{return JStep.Return(f.Pop());}
case 126:{f.Push(f.Locals[4]);f.Pc=128;continue;}
case 128:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6108(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?91:22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",43);}
case 43:{f.Locals[5]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",52);}
case 52:{f.Pc=f.Pop().Int==0?88:55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{f.Locals[6]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasAttackCost","(Lforge/game/card/Card;Ljava/lang/Class;)Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int==0?85:78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Pc=45;continue;}
case 88:{f.Pc=13;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6109(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/combat/CombatUtil","getBlockCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/cost/Cost;","invokestatic",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?13:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/card/Card;Lforge/game/player/Player;)V","invokespecial",25);}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",36);}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPayCosts","(Lforge/game/cost/Cost;)V","invokevirtual",42);}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("X")));f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("0")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",53);}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",57);}
case 57:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",60);}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",68);}
case 68:{return rt.DynamicCall(f,"forge/game/combat/CombatUtil:6109:68:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",73);}
case 73:{return rt.Call(f,"forge/game/player/PlayerController","payCombatCost","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z","invokevirtual",76);}
case 76:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6110(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",27);}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[5]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int==0?115:39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[6]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[6]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",56);}
case 56:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",61);}
case 61:{f.Locals[7]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[7]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",70);}
case 70:{f.Pc=f.Pop().Int==0?112:73;continue;}
case 73:{f.Push(f.Locals[7]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",80);}
case 80:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=83;continue;}
case 83:{f.Locals[8]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[8]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/staticability/StaticAbility","getBlockCost","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/cost/Cost;","invokevirtual",92);}
case 92:{f.Locals[9]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[9]);f.Pc=96;continue;}
case 96:{f.Pc=f.Pop().Reference==null?109:99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[9]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",105);}
case 105:{f.StackOp("pop");f.Pc=106;continue;}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{f.Locals[4]=f.Pop();f.Pc=109;continue;}
case 109:{f.Pc=63;continue;}
case 112:{f.Pc=29;continue;}
case 115:{f.Push(f.Locals[4]);f.Pc=117;continue;}
case 117:{f.Pc=f.Pop().Int==0?122:120;continue;}
case 120:{f.Push(JValue.R(null));f.Pc=121;continue;}
case 121:{return JStep.Return(f.Pop());}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6111(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",5);}
case 5:{f.Locals[4]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",11);}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int==0?176:17;continue;}
case 17:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",20);}
case 20:{f.Locals[6]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[6]);f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OtherAttackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OtherAttackers","Lforge/game/ability/AbilityKey;"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[6]);f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacked","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacked","Lforge/game/ability/AbilityKey;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",68);}
case 68:{f.StackOp("pop");f.Pc=69;continue;}
case 69:{f.Push(f.Locals[6]);f.Pc=71;continue;}
case 71:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",79);}
case 79:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",92);}
case 92:{f.Locals[7]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/combat/Combat","getDefenders","()Lforge/util/collect/FCollectionView;","invokevirtual",98);}
case 98:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",103);}
case 103:{f.Locals[8]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[8]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",112);}
case 112:{f.Pc=f.Pop().Int==0?150:115;continue;}
case 115:{f.Push(f.Locals[8]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",122);}
case 122:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=125;continue;}
case 125:{f.Locals[9]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[2]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[9]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/combat/Combat","getAttackersOf","(Lforge/game/GameEntity;)Lforge/game/card/CardCollection;","invokevirtual",133);}
case 133:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",136);}
case 136:{f.Pc=f.Pop().Int!=0?147:139;continue;}
case 139:{f.Push(f.Locals[7]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[9]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",146);}
case 146:{f.StackOp("pop");f.Pc=147;continue;}
case 147:{f.Pc=105;continue;}
case 150:{f.Push(f.Locals[6]);f.Pc=152;continue;}
case 152:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Defenders","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Defenders","Lforge/game/ability/AbilityKey;"));f.Pc=155;continue;}
case 155:{f.Push(f.Locals[7]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",162);}
case 162:{f.StackOp("pop");f.Pc=163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",167);}
case 167:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Attacks","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Attacks","Lforge/game/trigger/TriggerType;"));f.Pc=170;continue;}
case 170:{f.Push(f.Locals[6]);f.Pc=172;continue;}
case 172:{f.Push(JValue.I(0));f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",176);}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",180);}
case 180:{f.Push(f.Locals[4]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[5]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",189);}
case 189:{return rt.Call(f,"forge/game/card/CardDamageHistory","setCreatureAttackedThisCombat","(Lforge/game/GameEntity;I)V","invokevirtual",192);}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",196);}
case 196:{return rt.Call(f,"forge/game/card/CardDamageHistory","clearNotAttackedSinceLastUpkeepOf","()V","invokevirtual",199);}
case 199:{f.Push(f.Locals[1]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",203);}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",207);}
case 207:{f.Push(f.Locals[4]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/player/Player","addCreaturesAttackedThisTurn","(Lforge/game/card/Card;Lforge/game/GameEntity;)V","invokevirtual",212);}
case 212:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6112(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackConstraints"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackConstraints")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/combat/AttackConstraints","<init>","(Lforge/game/combat/Combat;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6113(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference!=null?15:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;)Z","invokestatic",14);}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlockMoreCreatures","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;)Z","invokestatic",24);}
case 24:{f.Pc=f.Pop().Int!=0?29:27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/combat/Combat","getAllBlockers","()Lforge/game/card/CardCollection;","invokevirtual",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/card/CardPredicates","isController","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",48);}
case 48:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",51);}
case 51:{f.Locals[3]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",57);}
case 57:{return rt.Call(f,"forge/game/staticability/StaticAbilityBlockRestrict","blockRestrictNum","(Lforge/game/player/Player;)I","invokestatic",60);}
case 60:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?65:63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;)Z","invokestatic",69);}
case 69:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6114(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Z)Z","invokestatic",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6115(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","isBattle","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?22:20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Int!=0?35:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?35:33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Pc=f.Pop().Int!=0?55:39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?55:46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttackBlock","canBlockTapped","(Lforge/game/card/Card;)Z","invokestatic",50);}
case 50:{f.Pc=f.Pop().Int!=0?55:53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("CARDNAME can't block.")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int!=0?75:65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("CARDNAME can't attack or block.")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?77:75;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttackBlock","cantBlock","(Lforge/game/card/Card;)Z","invokestatic",81);}
case 81:{f.Pc=f.Pop().Int==0?86:84;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("CARDNAME can't attack or block alone.")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int!=0?106:96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("CARDNAME can't block alone.")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",103);}
case 103:{f.Pc=f.Pop().Int==0?110:106;continue;}
case 106:{f.Push(JValue.I(1));f.Pc=107;continue;}
case 107:{f.Pc=111;continue;}
case 110:{f.Push(JValue.I(0));f.Pc=111;continue;}
case 111:{f.Locals[2]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",119);}
case 119:{f.Locals[3]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",126);}
case 126:{f.Push(JValue.I(2));f.Pc=127;continue;}
case 127:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?134:130;continue;}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{f.Pc=f.Pop().Int!=0?138:134;continue;}
case 134:{f.Push(JValue.I(1));f.Pc=135;continue;}
case 135:{f.Pc=139;continue;}
case 138:{f.Push(JValue.I(0));f.Pc=139;continue;}
case 139:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6116(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Int!=0?16:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/Card","canBlockAny","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?18:16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/Card","canBlockAdditional","()I","invokevirtual",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",30);}
case 30:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?37:33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{f.Pc=38;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6117(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference==null?57:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttackBlock","getMinMaxBlocker","(Lforge/game/card/Card;Lforge/game/player/Player;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",15);}
case 15:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",18);}
case 18:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",24);}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",32);}
case 32:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?37:35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/combat/Combat","getDefendingPlayerRelatedTo","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",42);}
case 42:{f.Locals[3]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Reference==null?57:47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/player/Player","sharesTeamWith","(Lforge/game/player/Player;)Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int!=0?57:55;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(null));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttackBlock","cantBlockBy","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",62);}
case 62:{f.Pc=f.Pop().Int==0?67:65;continue;}
case 65:{f.Push(JValue.I(0));f.Pc=66;continue;}
case 66:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 67:{f.Push(JValue.I(1));f.Pc=68;continue;}
case 68:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6118(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?39:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",31);}
case 31:{f.Pc=f.Pop().Int==0?36:34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 36:{f.Pc=7;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6119(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?47:20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",38);}
case 38:{f.Pc=f.Pop().Int==0?44:41;continue;}
case 41:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=44;continue;}
case 44:{f.Pc=10;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/combat/CombatUtil","canAttackerBeBlockedWithAmount","(Lforge/game/card/Card;ILforge/game/combat/Combat;)Z","invokestatic",53);}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6120(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int!=0?17:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference!=null?19:17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",25);}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",34);}
case 34:{f.Pc=f.Pop().Int==0?70:37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",55);}
case 55:{f.Pc=f.Pop().Int==0?67:58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Pc=27;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.I(0));f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",78);}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",84);}
case 84:{return rt.Call(f,"forge/game/combat/CombatUtil","getMinNumBlockersForAttacker","(Lforge/game/card/Card;Lforge/game/player/Player;)I","invokestatic",87);}
case 87:{f.Locals[4]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/CardLists","sortByPowerDesc","(Ljava/util/List;)V","invokestatic",93);}
case 93:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",96);}
case 96:{f.Locals[5]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{f.Locals[6]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[6]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[4]);f.Pc=105;continue;}
case 105:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?144:108;continue;}
case 108:{f.Push(f.Locals[6]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",116);}
case 116:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?144:119;continue;}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[3]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[6]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",129);}
case 129:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",137);}
case 137:{f.StackOp("pop");f.Pc=138;continue;}
case 138:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=141;continue;}
case 141:{f.Pc=101;continue;}
case 144:{f.Push(f.Locals[5]);f.Pc=146;continue;}
case 146:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6121(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?160:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;)Z","invokestatic",40);}
case 40:{f.Pc=f.Pop().Int==0?157:43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(null));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/combat/CombatUtil","mustBlockAnAttacker","(Lforge/game/card/Card;Lforge/game/combat/Combat;Ljava/util/List;)Z","invokestatic",50);}
case 50:{f.Pc=f.Pop().Int!=0?157:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",59);}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",66);}
case 66:{f.Locals[6]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",73);}
case 73:{f.Locals[7]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",82);}
case 82:{f.Pc=f.Pop().Int==0?145:85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",92);}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{f.Locals[8]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[8]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",103);}
case 103:{f.Locals[9]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[9]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[4]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Push(f.Locals[4]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[5]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlockMoreCreatures","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;)Z","invokestatic",122);}
case 122:{f.Pc=f.Pop().Int!=0?136:125;continue;}
case 125:{f.Push(f.Locals[8]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/combat/CombatUtil","canBeBlocked","(Lforge/game/card/Card;Ljava/util/List;Lforge/game/combat/Combat;)Z","invokestatic",133);}
case 133:{f.Pc=f.Pop().Int==0?142:136;continue;}
case 136:{f.Push(JValue.I(1));f.Pc=137;continue;}
case 137:{f.Locals[6]=f.Pop();f.Pc=139;continue;}
case 139:{f.Pc=145;continue;}
case 142:{f.Pc=75;continue;}
case 145:{f.Push(f.Locals[6]);f.Pc=147;continue;}
case 147:{f.Pc=f.Pop().Int==0?157:150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[4]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",156);}
case 156:{f.StackOp("pop");f.Pc=157;continue;}
case 157:{f.Pc=15;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6122(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/combat/Combat","getAllBlockers","()Lforge/game/card/CardCollection;","invokevirtual",14);}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/combat/CombatUtil","findFreeBlockers","(Ljava/util/List;Lforge/game/combat/Combat;)Ljava/util/List;","invokestatic",25);}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?544:45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[7]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[7]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/Card","getMustBlockCards","()Lforge/game/card/CardCollectionView;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",67);}
case 67:{f.Pc=f.Pop().Int!=0?327:70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",76);}
case 76:{f.Locals[8]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[7]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/Card","getMustBlockCards","()Lforge/game/card/CardCollectionView;","invokevirtual",83);}
case 83:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",88);}
case 88:{f.Locals[9]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[9]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",97);}
case 97:{f.Pc=f.Pop().Int==0?327:100;continue;}
case 100:{f.Push(f.Locals[9]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",107);}
case 107:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=110;continue;}
case 110:{f.Locals[10]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[7]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",117);}
case 117:{f.Push(f.Locals[7]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[10]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/combat/CombatUtil","getBlockCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/cost/Cost;","invokestatic",124);}
case 124:{f.Pc=f.Pop().Reference==null?130:127;continue;}
case 127:{f.Pc=90;continue;}
case 130:{f.Push(f.Locals[10]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/combat/CombatUtil","getMinNumBlockersForAttacker","(Lforge/game/card/Card;Lforge/game/player/Player;)I","invokestatic",136);}
case 136:{f.Push(JValue.I(1));f.Pc=137;continue;}
case 137:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=138;continue;}
case 138:{f.Locals[11]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(JValue.I(0));f.Pc=141;continue;}
case 141:{f.Locals[12]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(JValue.I(0));f.Pc=144;continue;}
case 144:{f.Locals[13]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[13]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[11]);f.Pc=150;continue;}
case 150:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?228:153;continue;}
case 153:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=156;continue;}
case 156:{f.StackOp("dup");f.Pc=157;continue;}
case 157:{f.Push(f.Locals[5]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",162);}
case 162:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",165);}
case 165:{f.Locals[14]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[14]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",174);}
case 174:{f.Pc=f.Pop().Int==0?222:177;continue;}
case 177:{f.Push(f.Locals[14]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",184);}
case 184:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=187;continue;}
case 187:{f.Locals[15]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[15]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[7]);f.Pc=193;continue;}
case 193:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?219:196;continue;}
case 196:{f.Push(f.Locals[10]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[15]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",203);}
case 203:{f.Pc=f.Pop().Int==0?219:206;continue;}
case 206:{f.Push(f.Locals[5]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[15]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",215);}
case 215:{f.StackOp("pop");f.Pc=216;continue;}
case 216:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=219;continue;}
case 219:{f.Pc=167;continue;}
case 222:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=225;continue;}
case 225:{f.Pc=146;continue;}
case 228:{f.Push(f.Locals[12]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[11]);f.Pc=232;continue;}
case 232:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?324:235;continue;}
case 235:{f.Push(f.Locals[8]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[10]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",244);}
case 244:{f.Pc=f.Pop().Int!=0?324:247;continue;}
case 247:{f.Push(f.Locals[7]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[8]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlockMoreCreatures","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;)Z","invokestatic",254);}
case 254:{f.Pc=f.Pop().Int!=0?269:257;continue;}
case 257:{f.Push(f.Locals[5]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[7]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",266);}
case 266:{f.Pc=f.Pop().Int==0?324:269;continue;}
case 269:{f.Push(f.Locals[0]);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[10]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/combat/Combat","isAttacking","(Lforge/game/card/Card;)Z","invokevirtual",275);}
case 275:{f.Pc=f.Pop().Int==0?324:278;continue;}
case 278:{f.Push(f.Locals[10]);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[7]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",285);}
case 285:{f.Pc=f.Pop().Int==0?324:288;continue;}
case 288:{f.Push(JValue.I(3));f.Pc=289;continue;}
case 289:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=292;continue;}
case 292:{f.StackOp("dup");f.Pc=293;continue;}
case 293:{f.Push(JValue.I(0));f.Pc=294;continue;}
case 294:{f.Push(f.Locals[7]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",299);}
case 299:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=300;continue;}
case 300:{f.StackOp("dup");f.Pc=301;continue;}
case 301:{f.Push(JValue.I(1));f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.String("must still block")));f.Pc=305;continue;}
case 305:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=306;continue;}
case 306:{f.StackOp("dup");f.Pc=307;continue;}
case 307:{f.Push(JValue.I(2));f.Pc=308;continue;}
case 308:{f.Push(f.Locals[10]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",313);}
case 313:{f.Push(JValue.R(rt.String(".")));f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/util/TextUtil","addSuffix","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",319);}
case 319:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",323);}
case 323:{return JStep.Return(f.Pop());}
case 324:{f.Pc=90;continue;}
case 327:{f.Push(f.Locals[7]);f.Pc=329;continue;}
case 329:{f.Push(f.Locals[0]);f.Pc=330;continue;}
case 330:{f.Push(f.Locals[5]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/combat/CombatUtil","mustBlockAnAttacker","(Lforge/game/card/Card;Lforge/game/combat/Combat;Ljava/util/List;)Z","invokestatic",335);}
case 335:{f.Pc=f.Pop().Int==0?384:338;continue;}
case 338:{f.Push(JValue.I(3));f.Pc=339;continue;}
case 339:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=342;continue;}
case 342:{f.StackOp("dup");f.Pc=343;continue;}
case 343:{f.Push(JValue.I(0));f.Pc=344;continue;}
case 344:{f.Push(f.Locals[7]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",349);}
case 349:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=350;continue;}
case 350:{f.StackOp("dup");f.Pc=351;continue;}
case 351:{f.Push(JValue.I(1));f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String("must block an attacker, but has not been assigned to block")));f.Pc=355;continue;}
case 355:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=356;continue;}
case 356:{f.StackOp("dup");f.Pc=357;continue;}
case 357:{f.Push(JValue.I(2));f.Pc=358;continue;}
case 358:{f.Push(f.Locals[4]);f.Pc=360;continue;}
case 360:{f.Push(f.Locals[7]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",367);}
case 367:{f.Pc=f.Pop().Int==0?376:370;continue;}
case 370:{f.Push(JValue.R(rt.String("the right ones.")));f.Pc=373;continue;}
case 373:{f.Pc=379;continue;}
case 376:{f.Push(JValue.R(rt.String("any.")));f.Pc=379;continue;}
case 379:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=380;continue;}
case 380:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",383);}
case 383:{return JStep.Return(f.Pop());}
case 384:{f.Push(f.Locals[4]);f.Pc=386;continue;}
case 386:{f.Push(f.Locals[7]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",393);}
case 393:{f.Pc=f.Pop().Int!=0?541:396;continue;}
case 396:{f.Push(f.Locals[7]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/staticability/StaticAbilityMustBlock","blocksEachCombatIfAble","(Lforge/game/card/Card;)Z","invokestatic",401);}
case 401:{f.Pc=f.Pop().Int==0?541:404;continue;}
case 404:{f.Push(f.Locals[3]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",410);}
case 410:{f.Locals[8]=f.Pop();f.Pc=412;continue;}
case 412:{f.Push(f.Locals[8]);f.Pc=414;continue;}
case 414:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",419);}
case 419:{f.Pc=f.Pop().Int==0?541:422;continue;}
case 422:{f.Push(f.Locals[8]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",429);}
case 429:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=432;continue;}
case 432:{f.Locals[9]=f.Pop();f.Pc=434;continue;}
case 434:{f.Push(f.Locals[7]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",439);}
case 439:{f.Push(f.Locals[7]);f.Pc=441;continue;}
case 441:{f.Push(f.Locals[9]);f.Pc=443;continue;}
case 443:{return rt.Call(f,"forge/game/combat/CombatUtil","getBlockCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/cost/Cost;","invokestatic",446);}
case 446:{f.Pc=f.Pop().Reference==null?452:449;continue;}
case 449:{f.Pc=412;continue;}
case 452:{f.Push(f.Locals[9]);f.Pc=454;continue;}
case 454:{f.Push(f.Locals[7]);f.Pc=456;continue;}
case 456:{f.Push(f.Locals[0]);f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/combat/Combat;)Z","invokestatic",460);}
case 460:{f.Pc=f.Pop().Int==0?538:463;continue;}
case 463:{f.Push(JValue.I(1));f.Pc=464;continue;}
case 464:{f.Locals[10]=f.Pop();f.Pc=466;continue;}
case 466:{f.Push(f.Locals[9]);f.Pc=468;continue;}
case 468:{f.Push(f.Locals[1]);f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/game/combat/CombatUtil","getMinNumBlockersForAttacker","(Lforge/game/card/Card;Lforge/game/player/Player;)I","invokestatic",472);}
case 472:{f.Push(JValue.I(1));f.Pc=473;continue;}
case 473:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?511:476;continue;}
case 476:{f.Push(f.Locals[5]);f.Pc=478;continue;}
case 478:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",481);}
case 481:{f.Locals[11]=f.Pop();f.Pc=483;continue;}
case 483:{f.Push(f.Locals[11]);f.Pc=485;continue;}
case 485:{f.Push(f.Locals[0]);f.Pc=486;continue;}
case 486:{f.Push(f.Locals[9]);f.Pc=488;continue;}
case 488:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",491);}
case 491:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",496);}
case 496:{f.StackOp("pop");f.Pc=497;continue;}
case 497:{f.Push(f.Locals[9]);f.Pc=499;continue;}
case 499:{f.Push(f.Locals[11]);f.Pc=501;continue;}
case 501:{f.Push(f.Locals[0]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/combat/CombatUtil","canBeBlocked","(Lforge/game/card/Card;Ljava/util/List;Lforge/game/combat/Combat;)Z","invokestatic",505);}
case 505:{f.Pc=f.Pop().Int!=0?511:508;continue;}
case 508:{f.Push(JValue.I(0));f.Pc=509;continue;}
case 509:{f.Locals[10]=f.Pop();f.Pc=511;continue;}
case 511:{f.Push(f.Locals[10]);f.Pc=513;continue;}
case 513:{f.Pc=f.Pop().Int==0?538:516;continue;}
case 516:{f.Push(JValue.I(2));f.Pc=517;continue;}
case 517:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=520;continue;}
case 520:{f.StackOp("dup");f.Pc=521;continue;}
case 521:{f.Push(JValue.I(0));f.Pc=522;continue;}
case 522:{f.Push(f.Locals[7]);f.Pc=524;continue;}
case 524:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",527);}
case 527:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=528;continue;}
case 528:{f.StackOp("dup");f.Pc=529;continue;}
case 529:{f.Push(JValue.I(1));f.Pc=530;continue;}
case 530:{f.Push(JValue.R(rt.String("must block each combat but was not assigned to block any attacker now.")));f.Pc=533;continue;}
case 533:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=534;continue;}
case 534:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",537);}
case 537:{return JStep.Return(f.Pop());}
case 538:{f.Pc=412;continue;}
case 541:{f.Pc=35;continue;}
case 544:{f.Push(f.Locals[1]);f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",548);}
case 548:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",551);}
case 551:{return rt.Call(f,"forge/game/GameRules","hasSharedTeamTurns","()Z","invokevirtual",554);}
case 554:{f.Pc=f.Pop().Int==0?559:557;continue;}
case 557:{f.Push(JValue.R(null));f.Pc=558;continue;}
case 558:{return JStep.Return(f.Pop());}
case 559:{f.Push(f.Locals[0]);f.Pc=560;continue;}
case 560:{f.Push(f.Locals[1]);f.Pc=561;continue;}
case 561:{f.Push(f.Locals[4]);f.Pc=563;continue;}
case 563:{return rt.Call(f,"forge/game/combat/CombatUtil","validateBlockRestrictions","(Lforge/game/combat/Combat;Lforge/game/player/Player;Ljava/util/List;)Ljava/lang/String;","invokestatic",566);}
case 566:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6123(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/combat/Combat","getAllBlockers","()Lforge/game/card/CardCollection;","invokevirtual",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/Player","getSharedTeam","()Lforge/game/player/PlayerCollection;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/util/collect/FCollectionView;)Lforge/game/card/CardCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/game/combat/CombatUtil","validateBlockRestrictions","(Lforge/game/combat/Combat;Lforge/game/player/Player;Ljava/util/List;)Ljava/lang/String;","invokestatic",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6124(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?236:16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("CARDNAME can't attack or block alone.")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?49:38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("CARDNAME can't block alone.")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?53:49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{f.Pc=54;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{f.Locals[5]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",62);}
case 62:{f.Push(JValue.I(2));f.Pc=63;continue;}
case 63:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?93:66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Int==0?93:71;continue;}
case 71:{f.Push(JValue.I(2));f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",82);}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("can't block alone.")));f.Pc=88;continue;}
case 88:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",92);}
case 92:{return JStep.Return(f.Pop());}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",99);}
case 99:{f.Push(JValue.I(3));f.Pc=100;continue;}
case 100:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?136:103;continue;}
case 103:{f.Push(f.Locals[4]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("CARDNAME can't block unless at least two other creatures block.")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int==0?136:114;continue;}
case 114:{f.Push(JValue.I(2));f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[4]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",125);}
case 125:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=126;continue;}
case 126:{f.StackOp("dup");f.Pc=127;continue;}
case 127:{f.Push(JValue.I(1));f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("can't block unless at least two other creatures block.")));f.Pc=131;continue;}
case 131:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",135);}
case 135:{return JStep.Return(f.Pop());}
case 136:{f.Push(f.Locals[4]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("CARDNAME can't block unless a creature with greater power also blocks.")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int==0?233:147;continue;}
case 147:{f.Push(JValue.I(0));f.Pc=148;continue;}
case 148:{f.Locals[6]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[4]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",155);}
case 155:{f.Locals[7]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[2]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",163);}
case 163:{f.Locals[8]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[8]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",172);}
case 172:{f.Pc=f.Pop().Int==0?206:175;continue;}
case 175:{f.Push(f.Locals[8]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",182);}
case 182:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=185;continue;}
case 185:{f.Locals[9]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[9]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",192);}
case 192:{f.Push(f.Locals[7]);f.Pc=194;continue;}
case 194:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?203:197;continue;}
case 197:{f.Push(JValue.I(1));f.Pc=198;continue;}
case 198:{f.Locals[6]=f.Pop();f.Pc=200;continue;}
case 200:{f.Pc=206;continue;}
case 203:{f.Pc=165;continue;}
case 206:{f.Push(f.Locals[6]);f.Pc=208;continue;}
case 208:{f.Pc=f.Pop().Int!=0?233:211;continue;}
case 211:{f.Push(JValue.I(2));f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=215;continue;}
case 215:{f.StackOp("dup");f.Pc=216;continue;}
case 216:{f.Push(JValue.I(0));f.Pc=217;continue;}
case 217:{f.Push(f.Locals[4]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",222);}
case 222:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=223;continue;}
case 223:{f.StackOp("dup");f.Pc=224;continue;}
case 224:{f.Push(JValue.I(1));f.Pc=225;continue;}
case 225:{f.Push(JValue.R(rt.String("can't block unless a creature with greater power also blocks.")));f.Pc=228;continue;}
case 228:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",232);}
case 232:{return JStep.Return(f.Pop());}
case 233:{f.Pc=7;continue;}
case 236:{f.Push(f.Locals[1]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/staticability/StaticAbilityBlockRestrict","blockRestrictNum","(Lforge/game/player/Player;)I","invokestatic",240);}
case 240:{f.Locals[3]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[2]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",247);}
case 247:{f.Push(f.Locals[3]);f.Pc=248;continue;}
case 248:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?278:251;continue;}
case 251:{f.Push(JValue.I(3));f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=255;continue;}
case 255:{f.StackOp("dup");f.Pc=256;continue;}
case 256:{f.Push(JValue.I(0));f.Pc=257;continue;}
case 257:{f.Push(JValue.R(rt.String("No more than")));f.Pc=260;continue;}
case 260:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=261;continue;}
case 261:{f.StackOp("dup");f.Pc=262;continue;}
case 262:{f.Push(JValue.I(1));f.Pc=263;continue;}
case 263:{f.Push(f.Locals[3]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",267);}
case 267:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=268;continue;}
case 268:{f.StackOp("dup");f.Pc=269;continue;}
case 269:{f.Push(JValue.I(2));f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("creatures can block each combat.")));f.Pc=273;continue;}
case 273:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",277);}
case 277:{return JStep.Return(f.Pop());}
case 278:{f.Push(f.Locals[0]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",282);}
case 282:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",285);}
case 285:{f.Locals[4]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[4]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",294);}
case 294:{f.Pc=f.Pop().Int==0?375:297;continue;}
case 297:{f.Push(f.Locals[4]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",304);}
case 304:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=307;continue;}
case 307:{f.Locals[5]=f.Pop();f.Pc=309;continue;}
case 309:{f.Push(f.Locals[0]);f.Pc=310;continue;}
case 310:{f.Push(f.Locals[5]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",315);}
case 315:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",318);}
case 318:{f.Locals[6]=f.Pop();f.Pc=320;continue;}
case 320:{f.Push(f.Locals[6]);f.Pc=322;continue;}
case 322:{f.Pc=f.Pop().Int<=0?372:325;continue;}
case 325:{f.Push(f.Locals[5]);f.Pc=327;continue;}
case 327:{f.Push(f.Locals[6]);f.Pc=329;continue;}
case 329:{f.Push(f.Locals[0]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/combat/CombatUtil","canAttackerBeBlockedWithAmount","(Lforge/game/card/Card;ILforge/game/combat/Combat;)Z","invokestatic",333);}
case 333:{f.Pc=f.Pop().Int!=0?372:336;continue;}
case 336:{f.Push(JValue.I(4));f.Pc=337;continue;}
case 337:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=340;continue;}
case 340:{f.StackOp("dup");f.Pc=341;continue;}
case 341:{f.Push(JValue.I(0));f.Pc=342;continue;}
case 342:{f.Push(f.Locals[5]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",347);}
case 347:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=348;continue;}
case 348:{f.StackOp("dup");f.Pc=349;continue;}
case 349:{f.Push(JValue.I(1));f.Pc=350;continue;}
case 350:{f.Push(JValue.R(rt.String("cannot be blocked with")));f.Pc=353;continue;}
case 353:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=354;continue;}
case 354:{f.StackOp("dup");f.Pc=355;continue;}
case 355:{f.Push(JValue.I(2));f.Pc=356;continue;}
case 356:{f.Push(f.Locals[6]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",361);}
case 361:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=362;continue;}
case 362:{f.StackOp("dup");f.Pc=363;continue;}
case 363:{f.Push(JValue.I(3));f.Pc=364;continue;}
case 364:{f.Push(JValue.R(rt.String("creatures you've assigned")));f.Pc=367;continue;}
case 367:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",371);}
case 371:{return JStep.Return(f.Pop());}
case 372:{f.Pc=287;continue;}
case 375:{f.Push(JValue.R(null));f.Pc=376;continue;}
case 376:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6125(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?8:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference!=null?10:8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",28);}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",36);}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[6]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",45);}
case 45:{f.Pc=f.Pop().Int==0?169:48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",55);}
case 55:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=58;continue;}
case 58:{f.Locals[7]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[7]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[7]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",69);}
case 69:{return rt.Call(f,"forge/game/combat/CombatUtil","attackerLureSatisfied","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z","invokestatic",72);}
case 72:{f.Pc=f.Pop().Int==0?78:75;continue;}
case 75:{f.Pc=38;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",82);}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[7]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/combat/CombatUtil","getBlockCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/cost/Cost;","invokestatic",88);}
case 88:{f.Pc=f.Pop().Reference==null?94:91;continue;}
case 91:{f.Pc=38;continue;}
case 94:{f.Push(f.Locals[7]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[5]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/combat/CombatUtil","canBeBlocked","(Lforge/game/card/Card;Lforge/game/combat/Combat;Lforge/game/player/Player;)Z","invokestatic",102);}
case 102:{f.Pc=f.Pop().Int==0?166:105;continue;}
case 105:{f.Push(f.Locals[7]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",111);}
case 111:{f.Pc=f.Pop().Int==0?166:114;continue;}
case 114:{f.Push(JValue.I(1));f.Pc=115;continue;}
case 115:{f.Locals[8]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[7]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",123);}
case 123:{f.Locals[9]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[7]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/combat/CombatUtil","getMinNumBlockersForAttacker","(Lforge/game/card/Card;Lforge/game/player/Player;)I","invokestatic",132);}
case 132:{f.Push(JValue.I(1));f.Pc=133;continue;}
case 133:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?153:136;continue;}
case 136:{f.Push(f.Locals[9]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",141);}
case 141:{f.Locals[10]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[7]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[10]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/combat/CombatUtil","canBeBlocked","(Lforge/game/card/Card;Ljava/util/List;Lforge/game/combat/Combat;)Z","invokestatic",151);}
case 151:{f.Locals[8]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[8]);f.Pc=155;continue;}
case 155:{f.Pc=f.Pop().Int==0?166:158;continue;}
case 158:{f.Push(f.Locals[4]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[7]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",165);}
case 165:{f.StackOp("pop");f.Pc=166;continue;}
case 166:{f.Pc=38;continue;}
case 169:{f.Push(f.Locals[0]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/card/Card","getMustBlockCards","()Lforge/game/card/CardCollectionView;","invokevirtual",173);}
case 173:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",178);}
case 178:{f.Locals[6]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[6]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",187);}
case 187:{f.Pc=f.Pop().Int==0?326:190;continue;}
case 190:{f.Push(f.Locals[6]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",197);}
case 197:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=200;continue;}
case 200:{f.Locals[7]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[0]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",206);}
case 206:{f.Push(f.Locals[0]);f.Pc=207;continue;}
case 207:{f.Push(f.Locals[7]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/combat/CombatUtil","getBlockCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/cost/Cost;","invokestatic",212);}
case 212:{f.Pc=f.Pop().Reference==null?218:215;continue;}
case 215:{f.Pc=180;continue;}
case 218:{f.Push(f.Locals[7]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[1]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[5]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/combat/CombatUtil","canBeBlocked","(Lforge/game/card/Card;Lforge/game/combat/Combat;Lforge/game/player/Player;)Z","invokestatic",226);}
case 226:{f.Pc=f.Pop().Int==0?323:229;continue;}
case 229:{f.Push(f.Locals[7]);f.Pc=231;continue;}
case 231:{f.Push(f.Locals[0]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",235);}
case 235:{f.Pc=f.Pop().Int==0?323:238;continue;}
case 238:{f.Push(f.Locals[1]);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[7]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/combat/Combat","isAttacking","(Lforge/game/card/Card;)Z","invokevirtual",244);}
case 244:{f.Pc=f.Pop().Int==0?323:247;continue;}
case 247:{f.Push(JValue.I(1));f.Pc=248;continue;}
case 248:{f.Locals[8]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(f.Locals[1]);f.Pc=251;continue;}
case 251:{f.Push(f.Locals[7]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",256);}
case 256:{f.Locals[9]=f.Pop();f.Pc=258;continue;}
case 258:{f.Push(f.Locals[7]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[9]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/combat/CombatUtil","getMinNumBlockersForAttacker","(Lforge/game/card/Card;Lforge/game/player/Player;)I","invokestatic",265);}
case 265:{f.Push(JValue.I(1));f.Pc=266;continue;}
case 266:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?310:269;continue;}
case 269:{f.Push(f.Locals[2]);f.Pc=270;continue;}
case 270:{f.Pc=f.Pop().Reference==null?284:273;continue;}
case 273:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=276;continue;}
case 276:{f.StackOp("dup");f.Pc=277;continue;}
case 277:{f.Push(f.Locals[2]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",281);}
case 281:{f.Pc=289;continue;}
case 284:{f.Push(f.Locals[9]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",289);}
case 289:{f.Locals[10]=f.Pop();f.Pc=291;continue;}
case 291:{f.Push(f.Locals[10]);f.Pc=293;continue;}
case 293:{f.Push(f.Locals[0]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",299);}
case 299:{f.StackOp("pop");f.Pc=300;continue;}
case 300:{f.Push(f.Locals[7]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[10]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/combat/CombatUtil","canBeBlocked","(Lforge/game/card/Card;Ljava/util/List;Lforge/game/combat/Combat;)Z","invokestatic",308);}
case 308:{f.Locals[8]=f.Pop();f.Pc=310;continue;}
case 310:{f.Push(f.Locals[8]);f.Pc=312;continue;}
case 312:{f.Pc=f.Pop().Int==0?323:315;continue;}
case 315:{f.Push(f.Locals[4]);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[7]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",322);}
case 322:{f.StackOp("pop");f.Pc=323;continue;}
case 323:{f.Pc=180;continue;}
case 326:{f.Push(f.Locals[4]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",331);}
case 331:{f.Pc=f.Pop().Int!=0?347:334;continue;}
case 334:{f.Push(f.Locals[1]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[0]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",339);}
case 339:{f.Push(f.Locals[4]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/game/card/CardCollection","containsAll","(Ljava/util/Collection;)Z","invokevirtual",344);}
case 344:{f.Pc=f.Pop().Int==0?349:347;continue;}
case 347:{f.Push(JValue.I(0));f.Pc=348;continue;}
case 348:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 349:{f.Push(f.Locals[0]);f.Pc=350;continue;}
case 350:{f.Push(JValue.R(rt.String("CARDNAME can't attack or block alone.")));f.Pc=353;continue;}
case 353:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",356);}
case 356:{f.Pc=f.Pop().Int!=0?369:359;continue;}
case 359:{f.Push(f.Locals[0]);f.Pc=360;continue;}
case 360:{f.Push(JValue.R(rt.String("CARDNAME can't block alone.")));f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",366);}
case 366:{f.Pc=f.Pop().Int==0?396:369;continue;}
case 369:{f.Push(f.Locals[0]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",373);}
case 373:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",376);}
case 376:{return rt.Call(f,"forge/game/card/CardCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",379);}
case 379:{f.Push(f.Locals[0]);f.Pc=380;continue;}
case 380:{f.Push(f.Locals[3]);f.Pc=381;continue;}
case 381:{return rt.DynamicCall(f,"forge/game/combat/CombatUtil:6125:381:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;)Ljava/util/function/Predicate;",386);}
case 386:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",391);}
case 391:{f.Pc=f.Pop().Int==0?396:394;continue;}
case 394:{f.Push(JValue.I(0));f.Pc=395;continue;}
case 395:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 396:{f.Push(f.Locals[0]);f.Pc=397;continue;}
case 397:{f.Push(f.Locals[1]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/combat/Combat;)Z","invokestatic",401);}
case 401:{f.Pc=f.Pop().Int!=0?506:404;continue;}
case 404:{f.Push(f.Locals[1]);f.Pc=405;continue;}
case 405:{f.Push(f.Locals[0]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",409);}
case 409:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",412);}
case 412:{f.Pc=f.Pop().Int==0?417:415;continue;}
case 415:{f.Push(JValue.I(0));f.Pc=416;continue;}
case 416:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 417:{f.Push(f.Locals[3]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",423);}
case 423:{f.Locals[6]=f.Pop();f.Pc=425;continue;}
case 425:{f.Push(f.Locals[6]);f.Pc=427;continue;}
case 427:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",432);}
case 432:{f.Pc=f.Pop().Int==0?506:435;continue;}
case 435:{f.Push(f.Locals[6]);f.Pc=437;continue;}
case 437:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",442);}
case 442:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=445;continue;}
case 445:{f.Locals[7]=f.Pop();f.Pc=447;continue;}
case 447:{f.Push(f.Locals[7]);f.Pc=449;continue;}
case 449:{f.Push(f.Locals[0]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[1]);f.Pc=451;continue;}
case 451:{f.Push(f.Locals[7]);f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",456);}
case 456:{return rt.Call(f,"forge/game/combat/CombatUtil","attackerLureSatisfied","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z","invokestatic",459);}
case 459:{f.Locals[8]=f.Pop();f.Pc=461;continue;}
case 461:{f.Push(f.Locals[1]);f.Pc=462;continue;}
case 462:{f.Push(f.Locals[7]);f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",467);}
case 467:{f.Locals[9]=f.Pop();f.Pc=469;continue;}
case 469:{f.Push(f.Locals[8]);f.Pc=471;continue;}
case 471:{f.Pc=f.Pop().Int==0?503:474;continue;}
case 474:{f.Push(f.Locals[9]);f.Pc=476;continue;}
case 476:{f.Push(f.Locals[0]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",480);}
case 480:{f.Pc=f.Pop().Int==0?503:483;continue;}
case 483:{f.Push(f.Locals[9]);f.Pc=485;continue;}
case 485:{f.Push(f.Locals[0]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",489);}
case 489:{f.StackOp("pop");f.Pc=490;continue;}
case 490:{f.Push(f.Locals[7]);f.Pc=492;continue;}
case 492:{f.Push(f.Locals[0]);f.Pc=493;continue;}
case 493:{f.Push(f.Locals[9]);f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/game/combat/CombatUtil","attackerLureSatisfied","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/card/CardCollection;)Z","invokestatic",498);}
case 498:{f.Pc=f.Pop().Int!=0?503:501;continue;}
case 501:{f.Push(JValue.I(0));f.Pc=502;continue;}
case 502:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 503:{f.Pc=425;continue;}
case 506:{f.Push(f.Locals[1]);f.Pc=507;continue;}
case 507:{f.Push(f.Locals[0]);f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",511);}
case 511:{f.Push(f.Locals[4]);f.Pc=513;continue;}
case 513:{return rt.Call(f,"java/util/Collections","disjoint","(Ljava/util/Collection;Ljava/util/Collection;)Z","invokestatic",516);}
case 516:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6126(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("All creatures able to block CARDNAME do so.")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","hasStartOfKeyword","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?63:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("CARDNAME must be blocked if able.")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","hasStartOfKeyword","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?27:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?63:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("CARDNAME must be blocked by exactly one creature if able.")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","hasStartOfKeyword","(Ljava/lang/String;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?45:37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",41);}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?63:45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("CARDNAME must be blocked by two or more creatures if able.")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/Card","hasStartOfKeyword","(Ljava/lang/String;)Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?65:55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",59);}
case 59:{f.Push(JValue.I(2));f.Pc=60;continue;}
case 60:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?65:63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",69);}
case 69:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",74);}
case 74:{f.Locals[3]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",81);}
case 81:{f.Pc=f.Pop().Int==0?194:84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{f.Locals[4]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[4]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",102);}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("MustBeBlockedBy ")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?154:115;continue;}
case 115:{f.Push(f.Locals[5]);f.Pc=117;continue;}
case 117:{f.Push(JValue.R(rt.String("MustBeBlockedBy ")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",123);}
case 123:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",126);}
case 126:{f.Locals[6]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(null));f.Pc=132;continue;}
case 132:{f.Push(JValue.R(null));f.Pc=133;continue;}
case 133:{f.Push(JValue.R(null));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",137);}
case 137:{f.Pc=f.Pop().Int==0?154:140;continue;}
case 140:{f.Push(f.Locals[2]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[6]);f.Pc=143;continue;}
case 143:{f.Push(JValue.R(null));f.Pc=144;continue;}
case 144:{f.Push(JValue.R(null));f.Pc=145;continue;}
case 145:{f.Push(JValue.R(null));f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/card/CardLists","getValidCardCount","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)I","invokestatic",149);}
case 149:{f.Pc=f.Pop().Int!=0?154:152;continue;}
case 152:{f.Push(JValue.I(0));f.Pc=153;continue;}
case 153:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 154:{f.Push(f.Locals[5]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("MustBeBlockedByAll")));f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",162);}
case 162:{f.Pc=f.Pop().Int==0?191:165;continue;}
case 165:{f.Push(f.Locals[5]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.String(":")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",173);}
case 173:{f.Push(JValue.I(1));f.Pc=174;continue;}
case 174:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=175;continue;}
case 175:{f.Locals[6]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[6]);f.Pc=180;continue;}
case 180:{f.Push(JValue.R(null));f.Pc=181;continue;}
case 181:{f.Push(JValue.R(null));f.Pc=182;continue;}
case 182:{f.Push(JValue.R(null));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",186);}
case 186:{f.Pc=f.Pop().Int==0?191:189;continue;}
case 189:{f.Push(JValue.I(0));f.Pc=190;continue;}
case 190:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 191:{f.Pc=75;continue;}
case 194:{f.Push(JValue.I(1));f.Pc=195;continue;}
case 195:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6127(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int==0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?32:30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",38);}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",47);}
case 47:{f.Pc=f.Pop().Int==0?111:50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[5]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",68);}
case 68:{f.Locals[6]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[6]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int==0?108:80;continue;}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",87);}
case 87:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=90;continue;}
case 90:{f.Locals[7]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[7]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[5]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/combat/Combat;)Z","invokestatic",100);}
case 100:{f.Pc=f.Pop().Int==0?105:103;continue;}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 105:{f.Pc=70;continue;}
case 108:{f.Pc=40;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6128(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?8:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference!=null?10:8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/combat/Combat;)Z","invokestatic",15);}
case 15:{f.Pc=f.Pop().Int!=0?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/combat/CombatUtil","canBeBlocked","(Lforge/game/card/Card;Lforge/game/combat/Combat;Lforge/game/player/Player;)Z","invokestatic",29);}
case 29:{f.Pc=f.Pop().Int!=0?34:32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Reference==null?49:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?49:47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{f.Locals[3]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",55);}
case 55:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",60);}
case 60:{f.Locals[4]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",69);}
case 69:{f.Pc=f.Pop().Int==0?193:72;continue;}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{f.Locals[5]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",91);}
case 91:{f.Locals[6]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[6]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("MustBeBlockedBy ")));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Int==0?150:104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("MustBeBlockedBy ")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",112);}
case 112:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",115);}
case 115:{f.Locals[7]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[7]);f.Pc=120;continue;}
case 120:{f.Push(JValue.R(null));f.Pc=121;continue;}
case 121:{f.Push(JValue.R(null));f.Pc=122;continue;}
case 122:{f.Push(JValue.R(null));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?150:129;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",134);}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{f.Push(JValue.R(null));f.Pc=137;continue;}
case 137:{f.Push(JValue.R(null));f.Pc=138;continue;}
case 138:{f.Push(JValue.R(null));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/card/CardLists","getValidCardCount","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)I","invokestatic",142);}
case 142:{f.Pc=f.Pop().Int!=0?150:145;continue;}
case 145:{f.Push(JValue.I(1));f.Pc=146;continue;}
case 146:{f.Locals[3]=f.Pop();f.Pc=147;continue;}
case 147:{f.Pc=193;continue;}
case 150:{f.Push(f.Locals[6]);f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("MustBeBlockedByAll")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int==0?190:161;continue;}
case 161:{f.Push(f.Locals[6]);f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String(":")));f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",169);}
case 169:{f.Push(JValue.I(1));f.Pc=170;continue;}
case 170:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=171;continue;}
case 171:{f.Locals[7]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[1]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[7]);f.Pc=176;continue;}
case 176:{f.Push(JValue.R(null));f.Pc=177;continue;}
case 177:{f.Push(JValue.R(null));f.Pc=178;continue;}
case 178:{f.Push(JValue.R(null));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int==0?190:185;continue;}
case 185:{f.Push(JValue.I(1));f.Pc=186;continue;}
case 186:{f.Locals[3]=f.Pop();f.Pc=187;continue;}
case 187:{f.Pc=193;continue;}
case 190:{f.Pc=62;continue;}
case 193:{f.Push(f.Locals[0]);f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("All creatures able to block CARDNAME do so.")));f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",200);}
case 200:{f.Pc=f.Pop().Int!=0?296:203;continue;}
case 203:{f.Push(f.Locals[0]);f.Pc=204;continue;}
case 204:{f.Push(JValue.R(rt.String("CARDNAME must be blocked if able.")));f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",210);}
case 210:{f.Pc=f.Pop().Int==0?224:213;continue;}
case 213:{f.Push(f.Locals[2]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[0]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",218);}
case 218:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",221);}
case 221:{f.Pc=f.Pop().Int!=0?296:224;continue;}
case 224:{f.Push(f.Locals[0]);f.Pc=225;continue;}
case 225:{f.Push(JValue.R(rt.String("CARDNAME must be blocked by exactly one creature if able.")));f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",231);}
case 231:{f.Pc=f.Pop().Int==0?246:234;continue;}
case 234:{f.Push(f.Locals[2]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[0]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",239);}
case 239:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",242);}
case 242:{f.Push(JValue.I(1));f.Pc=243;continue;}
case 243:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?296:246;continue;}
case 246:{f.Push(f.Locals[0]);f.Pc=247;continue;}
case 247:{f.Push(JValue.R(rt.String("CARDNAME must be blocked by two or more creatures if able.")));f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",253);}
case 253:{f.Pc=f.Pop().Int==0?268:256;continue;}
case 256:{f.Push(f.Locals[2]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[0]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",261);}
case 261:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",264);}
case 264:{f.Push(JValue.I(2));f.Pc=265;continue;}
case 265:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?296:268;continue;}
case 268:{f.Push(f.Locals[1]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/card/Card","getMustBlockCards","()Lforge/game/card/CardCollectionView;","invokevirtual",272);}
case 272:{f.Push(f.Locals[0]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",278);}
case 278:{f.Pc=f.Pop().Int!=0?296:281;continue;}
case 281:{f.Push(f.Locals[3]);f.Pc=282;continue;}
case 282:{f.Pc=f.Pop().Int!=0?296:285;continue;}
case 285:{f.Push(f.Locals[1]);f.Pc=286;continue;}
case 286:{f.Push(f.Locals[2]);f.Pc=287;continue;}
case 287:{f.Push(JValue.R(null));f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/combat/CombatUtil","mustBlockAnAttacker","(Lforge/game/card/Card;Lforge/game/combat/Combat;Ljava/util/List;)Z","invokestatic",291);}
case 291:{f.Pc=f.Pop().Int==0?296:294;continue;}
case 294:{f.Push(JValue.I(0));f.Pc=295;continue;}
case 295:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 296:{f.Push(f.Locals[0]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[1]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",301);}
case 301:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6129(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;Z)Z","invokestatic",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6130(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?15:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference==null?15:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int!=0?17:15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Z)Z","invokestatic",22);}
case 22:{f.Pc=f.Pop().Int!=0?27:25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttackBlock","cantBlockBy","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokestatic",32);}
case 32:{f.Pc=f.Pop().Int==0?37:35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6131(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference==null?14:6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",11);}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/combat/CombatUtil","canAttackerBeBlockedWithAmount","(Lforge/game/card/Card;ILforge/game/player/Player;)Z","invokestatic",18);}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6132(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int!=0?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttackBlock","getMinMaxBlocker","(Lforge/game/card/Card;Lforge/game/player/Player;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",22);}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?40:26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?42:40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6133(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttackBlock","getMinMaxBlocker","(Lforge/game/card/Card;Lforge/game/player/Player;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",5);}
case 5:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",14);}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6134(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?17:5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlockAtLeastOne","(Lforge/game/card/Card;Ljava/lang/Iterable;)Z","invokestatic",10);}
case 10:{f.Pc=f.Pop().Int==0?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6135(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/CombatUtil","canAttack","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z","invokestatic",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6136(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[5]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/combat/CombatUtil","canAttack","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z","invokestatic",6);}
case 6:{f.Pc=f.Pop().Int==0?19:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[5]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/combat/CombatUtil","getAttackCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/GameEntity;)Lforge/game/cost/Cost;","invokestatic",16);}
case 16:{f.Pc=f.Pop().Reference==null?21:19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/combat/AttackConstraints","countViolations","(Ljava/util/Map;)I","invokevirtual",36);}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[6]);f.Pc=40;continue;}
case 40:{f.Push(JValue.I(-1));f.Pc=41;continue;}
case 41:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?46:44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 46:{f.Push(f.Locals[6]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",59);}
case 59:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?66:62;continue;}
case 62:{f.Push(JValue.I(1));f.Pc=63;continue;}
case 63:{f.Pc=67;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C449{
internal static JClass Build(){var c=new JClass("forge/game/card/CardDamageHistory","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("attacksThisGame","I",false,JValue.Default("I"),null));
c.Add(new JField("creatureAttackedThisCombat","I",false,JValue.Default("I"),null));
c.Add(new JField("creatureBlockedThisCombat","Z",false,JValue.Default("Z"),null));
c.Add(new JField("creatureGotBlockedThisCombat","Z",false,JValue.Default("Z"),null));
c.Add(new JField("attackedThisTurn","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("attackedBattleThisTurn","Z",false,JValue.Default("Z"),null));
c.Add(new JField("creatureAttackedLastTurnOf","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("NotAttackedSinceLastUpkeepOf","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("NotBlockedSinceLastUpkeepOf","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("NotBeenBlockedSinceLastUpkeepOf","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("damageDoneThisTurn","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("damagedThisCombat","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("damagedThisGame","Lforge/util/collect/FCollection;",false,JValue.Default("Lforge/util/collect/FCollection;"),null));
c.Add(new JField("hasdealtDamagetoAny","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JMethod(4936,"forge/game/card/CardDamageHistory","<init>","()V",1,1,3,new JHandler[]{},M4936));
c.Add(new JMethod(4937,"forge/game/card/CardDamageHistory","getHasdealtDamagetoAny","()Z",17,1,1,new JHandler[]{},M4937));
c.Add(new JMethod(4938,"forge/game/card/CardDamageHistory","getHasdealtCombatDamagetoAny","()Z",17,1,2,new JHandler[]{},M4938));
c.Add(new JMethod(4939,"forge/game/card/CardDamageHistory","setCreatureAttackedThisCombat","(Lforge/game/GameEntity;I)V",17,4,3,new JHandler[]{},M4939));
c.Add(new JMethod(4940,"forge/game/card/CardDamageHistory","getCreatureAttackedThisCombat","()I",17,1,1,new JHandler[]{},M4940));
c.Add(new JMethod(4941,"forge/game/card/CardDamageHistory","getCreatureAttacksThisTurn","()I",17,1,1,new JHandler[]{},M4941));
c.Add(new JMethod(4942,"forge/game/card/CardDamageHistory","hasAttackedThisTurn","(Lforge/game/GameEntity;)Z",17,2,2,new JHandler[]{},M4942));
c.Add(new JMethod(4943,"forge/game/card/CardDamageHistory","hasAttackedBattleThisTurn","()Z",17,1,1,new JHandler[]{},M4943));
c.Add(new JMethod(4944,"forge/game/card/CardDamageHistory","getAttacksThisGame","()I",17,1,1,new JHandler[]{},M4944));
c.Add(new JMethod(4945,"forge/game/card/CardDamageHistory","setCreatureAttackedLastTurnOf","(Lforge/game/player/Player;Z)V",17,3,2,new JHandler[]{},M4945));
c.Add(new JMethod(4946,"forge/game/card/CardDamageHistory","getCreatureAttackedLastTurnOf","(Lforge/game/player/Player;)Z",17,2,2,new JHandler[]{},M4946));
c.Add(new JMethod(4947,"forge/game/card/CardDamageHistory","setNotAttackedSinceLastUpkeepOf","(Lforge/game/player/Player;)V",17,2,2,new JHandler[]{},M4947));
c.Add(new JMethod(4948,"forge/game/card/CardDamageHistory","clearNotAttackedSinceLastUpkeepOf","()V",17,1,1,new JHandler[]{},M4948));
c.Add(new JMethod(4949,"forge/game/card/CardDamageHistory","hasAttackedSinceLastUpkeepOf","(Lforge/game/player/Player;)Z",17,2,2,new JHandler[]{},M4949));
c.Add(new JMethod(4950,"forge/game/card/CardDamageHistory","setNotBlockedSinceLastUpkeepOf","(Lforge/game/player/Player;)V",17,2,2,new JHandler[]{},M4950));
c.Add(new JMethod(4951,"forge/game/card/CardDamageHistory","clearNotBlockedSinceLastUpkeepOf","()V",17,1,1,new JHandler[]{},M4951));
c.Add(new JMethod(4952,"forge/game/card/CardDamageHistory","hasBlockedSinceLastUpkeepOf","(Lforge/game/player/Player;)Z",17,2,2,new JHandler[]{},M4952));
c.Add(new JMethod(4953,"forge/game/card/CardDamageHistory","setNotBeenBlockedSinceLastUpkeepOf","(Lforge/game/player/Player;)V",17,2,2,new JHandler[]{},M4953));
c.Add(new JMethod(4954,"forge/game/card/CardDamageHistory","clearNotBeenBlockedSinceLastUpkeepOf","()V",17,1,1,new JHandler[]{},M4954));
c.Add(new JMethod(4955,"forge/game/card/CardDamageHistory","hasBeenBlockedSinceLastUpkeepOf","(Lforge/game/player/Player;)Z",17,2,2,new JHandler[]{},M4955));
c.Add(new JMethod(4956,"forge/game/card/CardDamageHistory","setCreatureBlockedThisCombat","(Z)V",17,2,2,new JHandler[]{},M4956));
c.Add(new JMethod(4957,"forge/game/card/CardDamageHistory","getCreatureBlockedThisCombat","()Z",17,1,1,new JHandler[]{},M4957));
c.Add(new JMethod(4958,"forge/game/card/CardDamageHistory","setCreatureGotBlockedThisCombat","(Z)V",17,2,2,new JHandler[]{},M4958));
c.Add(new JMethod(4959,"forge/game/card/CardDamageHistory","getCreatureGotBlockedThisCombat","()Z",17,1,1,new JHandler[]{},M4959));
c.Add(new JMethod(4960,"forge/game/card/CardDamageHistory","getThisCombatDamaged","()Ljava/util/List;",17,1,1,new JHandler[]{},M4960));
c.Add(new JMethod(4961,"forge/game/card/CardDamageHistory","getThisGameDamaged","()Lforge/util/collect/FCollection;",17,1,1,new JHandler[]{},M4961));
c.Add(new JMethod(4962,"forge/game/card/CardDamageHistory","registerDamage","(IZLforge/game/card/Card;Lforge/game/GameEntity;Ljava/util/Map;)V",1,7,6,new JHandler[]{},M4962));
c.Add(new JMethod(4963,"forge/game/card/CardDamageHistory","getDamageDoneThisTurn","(Ljava/lang/Boolean;ZLjava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/CardTraitBase;)I",1,8,9,new JHandler[]{},M4963));
c.Add(new JMethod(4964,"forge/game/card/CardDamageHistory","getDamageDoneThisTurn","(Ljava/lang/Boolean;ZZLjava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/CardTraitBase;)I",1,13,5,new JHandler[]{},M4964));
c.Add(new JMethod(4965,"forge/game/card/CardDamageHistory","getAllDmgInstances","()Ljava/util/List;",1,1,1,new JHandler[]{},M4965));
c.Add(new JMethod(4966,"forge/game/card/CardDamageHistory","newTurn","()V",1,4,2,new JHandler[]{},M4966));
c.Add(new JMethod(4967,"forge/game/card/CardDamageHistory","endCombat","()V",1,1,3,new JHandler[]{},M4967));
}

internal static JStep M4936(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","attacksThisGame","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","creatureAttackedThisCombat","I",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","creatureBlockedThisCombat","Z",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","creatureGotBlockedThisCombat","Z",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",28);}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","attackedThisTurn","Ljava/util/List;",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","attackedBattleThisTurn","Z",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",40);}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","creatureAttackedLastTurnOf","Ljava/util/List;",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",47);}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","NotAttackedSinceLastUpkeepOf","Ljava/util/List;",value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",54);}
case 54:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","NotBlockedSinceLastUpkeepOf","Ljava/util/List;",value);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",61);}
case 61:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","NotBeenBlockedSinceLastUpkeepOf","Ljava/util/List;",value);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",68);}
case 68:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","damageDoneThisTurn","Ljava/util/List;",value);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",75);}
case 75:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","damagedThisCombat","Ljava/util/List;",value);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=82;continue;}
case 82:{f.StackOp("dup");f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",86);}
case 86:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","damagedThisGame","Lforge/util/collect/FCollection;",value);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",93);}
case 93:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","hasdealtDamagetoAny","Ljava/util/Set;",value);f.Pc=96;continue;}
case 96:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4937(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","hasdealtDamagetoAny","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4938(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","hasdealtDamagetoAny","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"java/lang/Boolean","TRUE","Ljava/lang/Boolean;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","TRUE","Ljava/lang/Boolean;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4939(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=4;continue;}
case 4:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","creatureAttackedThisCombat","I",value);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference==null?56:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","attacksThisGame","I"));f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","attacksThisGame","I",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","attackedThisTurn","Ljava/util/List;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=36;continue;}
case 36:{f.Pc=f.Pop().Int==0?56:39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","isBattle","()Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?56:51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","attackedBattleThisTurn","Z",value);f.Pc=56;continue;}
case 56:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4940(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","creatureAttackedThisCombat","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4941(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","attackedThisTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4942(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","attackedThisTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4943(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","attackedBattleThisTurn","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4944(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","attacksThisGame","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4945(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int==0?28:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","creatureAttackedLastTurnOf","Ljava/util/List;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int!=0?28:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","creatureAttackedLastTurnOf","Ljava/util/List;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Pc=f.Pop().Int!=0?48:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","creatureAttackedLastTurnOf","Ljava/util/List;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?48:45;continue;}
case 45:{f.Pc=28;continue;}
case 48:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4946(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","creatureAttackedLastTurnOf","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4947(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","NotAttackedSinceLastUpkeepOf","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4948(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","NotAttackedSinceLastUpkeepOf","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4949(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","NotAttackedSinceLastUpkeepOf","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int!=0?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4950(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","NotBlockedSinceLastUpkeepOf","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4951(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","NotBlockedSinceLastUpkeepOf","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4952(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","NotBlockedSinceLastUpkeepOf","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int!=0?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4953(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","NotBeenBlockedSinceLastUpkeepOf","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4954(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","NotBeenBlockedSinceLastUpkeepOf","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4955(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","NotBeenBlockedSinceLastUpkeepOf","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int!=0?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4956(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","creatureBlockedThisCombat","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4957(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","creatureBlockedThisCombat","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4958(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","creatureGotBlockedThisCombat","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4959(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","creatureGotBlockedThisCombat","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4960(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","damagedThisCombat","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4961(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","damagedThisGame","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4962(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int>0?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","damagedThisGame","Lforge/util/collect/FCollection;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[4]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","hasdealtDamagetoAny","Ljava/util/Set;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",23);}
case 23:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Int==0?90:33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Int==0?90:41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","damagedThisCombat","Ljava/util/List;"));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[6]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/player/Player","getLastTurnNr","()I","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int<=0?90:68;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",73);}
case 73:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",76);}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int!=0?90:84;continue;}
case 84:{f.Push(f.Locals[6]);f.Pc=86;continue;}
case 86:{f.Push(JValue.I(1));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/player/Player","setBeenDealtCombatDamageSinceLastTurn","(Z)V","invokevirtual",90);}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",94);}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",98);}
case 98:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",101);}
case 101:{f.Locals[6]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","damageDoneThisTurn","Ljava/util/List;"));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[6]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Push(f.Locals[4]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[6]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/GameEntity","receiveDamage","(Lorg/apache/commons/lang3/tuple/Pair;)V","invokevirtual",122);}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",126);}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[6]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[3]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",133);}
case 133:{f.Pc=f.Pop().Int==0?140:136;continue;}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{f.Pc=146;continue;}
case 140:{f.Push(f.Locals[3]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[5]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;Ljava/util/Map;)Lforge/game/card/Card;","invokestatic",146);}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[5]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/GameEntity;Ljava/util/Map;)Lforge/game/GameEntity;","invokestatic",153);}
case 153:{return rt.Call(f,"forge/game/Game","addGlobalDamageHistory","(Lforge/game/card/CardDamageHistory;Lorg/apache/commons/lang3/tuple/Pair;Lforge/game/card/Card;Lforge/game/GameEntity;)V","invokevirtual",156);}
case 156:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4963(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[5]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[6]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[7]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardDamageHistory","getDamageDoneThisTurn","(Ljava/lang/Boolean;ZZLjava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/CardTraitBase;)I","invokevirtual",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4964(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[9]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","damageDoneThisTurn","Ljava/util/List;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[10]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[10]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?189:24;continue;}
case 24:{f.Push(f.Locals[10]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[11]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[7]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",41);}
case 41:{f.Push(f.Locals[11]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/Game","getDamageLKI","(Lorg/apache/commons/lang3/tuple/Pair;)Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",46);}
case 46:{f.Locals[12]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Reference==null?64:52;continue;}
case 52:{f.Push(f.Locals[11]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",57);}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?64:61;continue;}
case 61:{f.Pc=14;continue;}
case 64:{f.Push(f.Locals[12]);f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Reference==null?155:69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Pc=f.Pop().Reference==null?120:74;continue;}
case 74:{f.Push(f.Locals[12]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String(",")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",89);}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{f.Pc=f.Pop().Reference!=null?107:96;continue;}
case 96:{f.Push(f.Locals[12]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",101);}
case 101:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=104;continue;}
case 104:{f.Pc=109;continue;}
case 107:{f.Push(f.Locals[6]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/Card","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int!=0?120:117;continue;}
case 117:{f.Pc=14;continue;}
case 120:{f.Push(f.Locals[5]);f.Pc=122;continue;}
case 122:{f.Pc=f.Pop().Reference==null?155:125;continue;}
case 125:{f.Push(f.Locals[12]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",130);}
case 130:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[5]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String(",")));f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",140);}
case 140:{f.Push(f.Locals[7]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[6]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[8]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/GameEntity","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",149);}
case 149:{f.Pc=f.Pop().Int!=0?155:152;continue;}
case 152:{f.Pc=14;continue;}
case 155:{f.Push(f.Locals[9]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[3]);f.Pc=158;continue;}
case 158:{f.Pc=f.Pop().Int==0?165:161;continue;}
case 161:{f.Push(JValue.I(1));f.Pc=162;continue;}
case 162:{f.Pc=176;continue;}
case 165:{f.Push(f.Locals[11]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",170);}
case 170:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",176);}
case 176:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=177;continue;}
case 177:{f.Locals[9]=f.Pop();f.Pc=179;continue;}
case 179:{f.Push(f.Locals[2]);f.Pc=180;continue;}
case 180:{f.Pc=f.Pop().Int==0?186:183;continue;}
case 183:{f.Pc=189;continue;}
case 186:{f.Pc=14;continue;}
case 189:{f.Push(f.Locals[9]);f.Pc=191;continue;}
case 191:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4965(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","damageDoneThisTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4966(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","attackedThisTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageHistory","attackedBattleThisTurn","Z",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","damagedThisCombat","Ljava/util/List;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","damageDoneThisTurn","Ljava/util/List;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",32);}
case 32:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",39);}
case 39:{f.Locals[1]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","damagedThisGame","Lforge/util/collect/FCollection;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",47);}
case 47:{f.Locals[2]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?102:57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[3]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=71;continue;}
case 71:{f.Pc=f.Pop().Int==0?99:74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",81);}
case 81:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",84);}
case 84:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=87;continue;}
case 87:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?99:90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Pc=48;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","damagedThisGame","Lforge/util/collect/FCollection;"));f.Pc=106;continue;}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/util/collect/FCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4967(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageHistory","damagedThisCombat","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{f.Push(JValue.I(-1));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardDamageHistory","setCreatureAttackedThisCombat","(Lforge/game/GameEntity;I)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/CardDamageHistory","setCreatureBlockedThisCombat","(Z)V","invokevirtual",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/CardDamageHistory","setCreatureGotBlockedThisCombat","(Z)V","invokevirtual",25);}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

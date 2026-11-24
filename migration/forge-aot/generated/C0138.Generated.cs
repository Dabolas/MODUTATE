// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C138{
internal static JClass Build(){var c=new JClass("forge/game/GameEntity","java/lang/Object",new string[]{"forge/game/GameObject","forge/game/IIdentifiable"},1057);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("id","I",false,JValue.Default("I"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("attachedCards","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("counters","Lcom/google/common/collect/Multiset;",false,JValue.Default("Lcom/google/common/collect/Multiset;"),null));
c.Add(new JField("damageReceivedThisTurn","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("damageReceivedLastTurn","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(2164,"forge/game/GameEntity","<init>","(I)V",4,2,3,new JHandler[]{},M2164));
c.Add(new JMethod(2165,"forge/game/GameEntity","getId","()I",1,1,1,new JHandler[]{},M2165));
c.Add(new JMethod(2166,"forge/game/GameEntity","dangerouslySetId","(I)V",1,2,2,new JHandler[]{},M2166));
c.Add(new JMethod(2167,"forge/game/GameEntity","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2167));
c.Add(new JMethod(2168,"forge/game/GameEntity","setName","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M2168));
c.Add(new JMethod(2169,"forge/game/GameEntity","addDamageAfterPrevention","(ILforge/game/card/Card;Lforge/game/spellability/SpellAbility;ZLforge/game/GameEntityCounterTable;)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(2170,"forge/game/GameEntity","staticDamagePrevention","(IILforge/game/card/Card;Z)I",1,5,6,new JHandler[]{},M2170));
c.Add(new JMethod(2171,"forge/game/GameEntity","staticDamagePrevention","(IILforge/game/card/Card;ZLjava/lang/Boolean;)I",1,11,5,new JHandler[]{},M2171));
c.Add(new JMethod(2172,"forge/game/GameEntity","staticReplaceDamage","(ILforge/game/card/Card;Z)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(2173,"forge/game/GameEntity","getPreventNextDamageTotalShields","()I",1,1,2,new JHandler[]{},M2173));
c.Add(new JMethod(2174,"forge/game/GameEntity","hasKeyword","(Ljava/lang/String;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(2175,"forge/game/GameEntity","hasKeyword","(Lforge/game/keyword/Keyword;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(2176,"forge/game/GameEntity","getEnchantedBy","()Lforge/game/card/CardCollectionView;",17,1,2,new JHandler[]{},M2176));
c.Add(new JMethod(2177,"forge/game/GameEntity","getAttachedCards","()Lforge/game/card/CardCollectionView;",17,1,2,new JHandler[]{},M2177));
c.Add(new JMethod(2178,"forge/game/GameEntity","getAllAttachedCards","()Lforge/game/card/CardCollectionView;",17,1,1,new JHandler[]{},M2178));
c.Add(new JMethod(2179,"forge/game/GameEntity","setAttachedCards","(Ljava/lang/Iterable;)V",17,2,5,new JHandler[]{},M2179));
c.Add(new JMethod(2180,"forge/game/GameEntity","clearAttachedCards","()V",17,1,4,new JHandler[]{},M2180));
c.Add(new JMethod(2181,"forge/game/GameEntity","hasCardAttachments","()Z",17,1,1,new JHandler[]{},M2181));
c.Add(new JMethod(2182,"forge/game/GameEntity","isEnchanted","()Z",17,1,2,new JHandler[]{},M2182));
c.Add(new JMethod(2183,"forge/game/GameEntity","hasCardAttachment","(Lforge/game/card/Card;)Z",17,2,2,new JHandler[]{},M2183));
c.Add(new JMethod(2184,"forge/game/GameEntity","isEnchantedBy","(Lforge/game/card/Card;)Z",17,2,2,new JHandler[]{},M2184));
c.Add(new JMethod(2185,"forge/game/GameEntity","hasCardAttachment","(Ljava/lang/String;)Z",17,2,2,new JHandler[]{},M2185));
c.Add(new JMethod(2186,"forge/game/GameEntity","isEnchantedBy","(Ljava/lang/String;)Z",17,2,2,new JHandler[]{},M2186));
c.Add(new JMethod(2187,"forge/game/GameEntity","addAttachedCard","(Lforge/game/card/Card;)V",17,2,5,new JHandler[]{},M2187));
c.Add(new JMethod(2188,"forge/game/GameEntity","removeAttachedCard","(Lforge/game/card/Card;)V",17,2,5,new JHandler[]{},M2188));
c.Add(new JMethod(2189,"forge/game/GameEntity","updateAttachedCards","()V",17,1,4,new JHandler[]{},M2189));
c.Add(new JMethod(2190,"forge/game/GameEntity","unAttachAllCards","(Lforge/game/card/Card;)V",17,4,3,new JHandler[]{},M2190));
c.Add(new JMethod(2191,"forge/game/GameEntity","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z",1,3,4,new JHandler[]{},M2191));
c.Add(new JMethod(2192,"forge/game/GameEntity","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Z)Z",1,4,4,new JHandler[]{},M2192));
c.Add(new JMethod(2193,"forge/game/GameEntity","cantBeAttachedMsg","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M2193));
c.Add(new JMethod(2194,"forge/game/GameEntity","cantBeAttachedMsg","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Z)Ljava/lang/String;",1,5,3,new JHandler[]{},M2194));
c.Add(new JMethod(2195,"forge/game/GameEntity","cantBeEquippedByMsg","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,1,new JHandler[]{},M2195));
c.Add(new JMethod(2196,"forge/game/GameEntity","cantBeFortifiedByMsg","(Lforge/game/card/Card;)Ljava/lang/String;",4,2,1,new JHandler[]{},M2196));
c.Add(new JMethod(2197,"forge/game/GameEntity","cantBeEnchantedByMsg","(Lforge/game/card/Card;)Ljava/lang/String;",4,7,5,new JHandler[]{},M2197));
c.Add(new JMethod(2198,"forge/game/GameEntity","hasCounters","()Z",1,1,1,new JHandler[]{},M2198));
c.Add(new JMethod(2199,"forge/game/GameEntity","getCounters","()Lcom/google/common/collect/Multiset;",17,1,1,new JHandler[]{},M2199));
c.Add(new JMethod(2200,"forge/game/GameEntity","getNumAllCounters","()I",17,1,1,new JHandler[]{},M2200));
c.Add(new JMethod(2201,"forge/game/GameEntity","getCounters","(Lforge/game/card/CounterType;)I",17,2,2,new JHandler[]{},M2201));
c.Add(new JMethod(2202,"forge/game/GameEntity","setCounters","(Lforge/game/card/CounterType;Ljava/lang/Integer;)V",1,3,3,new JHandler[]{},M2202));
c.Add(new JMethod(2203,"forge/game/GameEntity","setCounters","(Lcom/google/common/collect/Multiset;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(2204,"forge/game/GameEntity","canRemoveCounters","(Lforge/game/card/CounterType;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(2205,"forge/game/GameEntity","canReceiveCounters","(Lforge/game/card/CounterType;)Z",1,2,3,new JHandler[]{},M2205));
c.Add(new JMethod(2206,"forge/game/GameEntity","canReceiveCounters","(Lforge/game/card/CounterType;Ljava/util/Map;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(2207,"forge/game/GameEntity","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(2208,"forge/game/GameEntity","clearCounters","()V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(2209,"forge/game/GameEntity","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V",17,5,5,new JHandler[]{},M2209));
c.Add(new JMethod(2210,"forge/game/GameEntity","addCounterInternal","(Lforge/game/card/CounterType;ILforge/game/player/Player;ZLforge/game/GameEntityCounterTable;Ljava/util/Map;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(2211,"forge/game/GameEntity","getCounterMax","(Lforge/game/card/CounterType;)Ljava/lang/Integer;",1,2,1,new JHandler[]{},M2211));
c.Add(new JMethod(2212,"forge/game/GameEntity","getDamageReceivedThisTurn","()Ljava/util/List;",1,1,1,new JHandler[]{},M2212));
c.Add(new JMethod(2213,"forge/game/GameEntity","setDamageReceivedThisTurn","(Ljava/util/List;)V",1,2,2,new JHandler[]{},M2213));
c.Add(new JMethod(2214,"forge/game/GameEntity","getDamageReceivedLastTurn","()Ljava/util/List;",1,1,1,new JHandler[]{},M2214));
c.Add(new JMethod(2215,"forge/game/GameEntity","receiveDamage","(Lorg/apache/commons/lang3/tuple/Pair;)V",1,2,2,new JHandler[]{},M2215));
c.Add(new JMethod(2216,"forge/game/GameEntity","getAssignedDamage","()I",17,1,3,new JHandler[]{},M2216));
c.Add(new JMethod(2217,"forge/game/GameEntity","getAssignedCombatDamage","()I",17,1,3,new JHandler[]{},M2217));
c.Add(new JMethod(2218,"forge/game/GameEntity","getAssignedDamage","(Ljava/lang/Boolean;Lforge/game/card/Card;)I",17,3,4,new JHandler[]{},M2218));
c.Add(new JMethod(2219,"forge/game/GameEntity","getAssignedDamage","(Ljava/lang/Boolean;Lforge/game/card/Card;Z)I",17,7,2,new JHandler[]{},M2219));
c.Add(new JMethod(2220,"forge/game/GameEntity","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M2220));
c.Add(new JMethod(2221,"forge/game/GameEntity","hashCode","()I",17,1,1,new JHandler[]{},M2221));
}

private static void Add1(JClass c){
c.Add(new JMethod(2222,"forge/game/GameEntity","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2222));
c.Add(new JMethod(2223,"forge/game/GameEntity","getGame","()Lforge/game/Game;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(2224,"forge/game/GameEntity","getView","()Lforge/game/GameEntityView;",1025,0,0,new JHandler[]{},null));
}

internal static JStep M2164(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("")));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntity","name","Ljava/lang/String;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",18);}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntity","attachedCards","Lforge/game/card/CardCollection;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","()Lcom/google/common/collect/HashMultiset;","invokestatic",25);}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntity","counters","Lcom/google/common/collect/Multiset;",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",32);}
case 32:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntity","damageReceivedThisTurn","Ljava/util/List;",value);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",39);}
case 39:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntity","damageReceivedLastTurn","Ljava/util/List;",value);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntity","id","I",value);f.Pc=47;continue;}
case 47:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2165(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","id","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2166(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntity","id","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2167(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2168(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntity","name","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/GameEntity","getView","()Lforge/game/GameEntityView;","invokevirtual",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/GameEntityView","updateName","(Lforge/game/GameEntity;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2170(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/GameEntity","staticDamagePrevention","(IILforge/game/card/Card;ZLjava/lang/Boolean;)I","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2171(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int>0?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[4]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","canDamagePrevented","(Z)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int!=0?17:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Int==0?54:22;continue;}
case 22:{f.Push(f.Locals[5]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Reference==null?35:27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",32);}
case 32:{f.Pc=45;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",42);}
case 42:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","isPreventCombatDamageThisTurn","()Z","invokevirtual",45);}
case 45:{f.Locals[6]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[6]);f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Int==0?54:52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",58);}
case 58:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",64);}
case 64:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",69);}
case 69:{f.Locals[6]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[6]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",78);}
case 78:{f.Pc=f.Pop().Int==0?343:81;continue;}
case 81:{f.Push(f.Locals[6]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",88);}
case 88:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=91;continue;}
case 91:{f.Locals[7]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[7]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","getReplacementEffects","()Lforge/util/collect/FCollectionView;","invokevirtual",98);}
case 98:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",103);}
case 103:{f.Locals[8]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[8]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",112);}
case 112:{f.Pc=f.Pop().Int==0?340:115;continue;}
case 115:{f.Push(f.Locals[8]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",122);}
case 122:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=125;continue;}
case 125:{f.Locals[9]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMode","()Lforge/game/replacement/ReplacementType;","invokevirtual",132);}
case 132:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/replacement/ReplacementType","equals","(Ljava/lang/Object;)Z","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int==0?105:141;continue;}
case 141:{f.Push(f.Locals[9]);f.Pc=143;continue;}
case 143:{f.Push(JValue.R(rt.String("PreventionEffect")));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Int!=0?164:151;continue;}
case 151:{f.Push(f.Locals[9]);f.Pc=153;continue;}
case 153:{f.Push(JValue.R(rt.String("Prevent")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int!=0?164:161;continue;}
case 161:{f.Pc=105;continue;}
case 164:{f.Push(f.Locals[9]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[0]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",170);}
case 170:{f.Push(f.Locals[7]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",175);}
case 175:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","zonesCheck","(Lforge/game/zone/Zone;)Z","invokevirtual",178);}
case 178:{f.Pc=f.Pop().Int!=0?184:181;continue;}
case 181:{f.Pc=105;continue;}
case 184:{f.Push(f.Locals[9]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",190);}
case 190:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","requirementsCheck","(Lforge/game/Game;)Z","invokevirtual",193);}
case 193:{f.Pc=f.Pop().Int!=0?199:196;continue;}
case 196:{f.Pc=105;continue;}
case 199:{f.Push(JValue.R(rt.String("Immortal Coil")));f.Pc=201;continue;}
case 201:{f.Push(f.Locals[7]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",206);}
case 206:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",209);}
case 209:{f.Pc=f.Pop().Int==0?215:212;continue;}
case 212:{f.Pc=105;continue;}
case 215:{f.Push(f.Locals[9]);f.Pc=217;continue;}
case 217:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=219;continue;}
case 219:{f.Push(f.Locals[3]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",223);}
case 223:{f.Pc=f.Pop().Int!=0?229:226;continue;}
case 226:{f.Pc=105;continue;}
case 229:{f.Push(f.Locals[9]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=233;continue;}
case 233:{f.Push(f.Locals[0]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",237);}
case 237:{f.Pc=f.Pop().Int!=0?243:240;continue;}
case 240:{f.Pc=105;continue;}
case 243:{f.Push(f.Locals[9]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("IsCombat")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",250);}
case 250:{f.Pc=f.Pop().Int==0?273:253;continue;}
case 253:{f.Push(f.Locals[9]);f.Pc=255;continue;}
case 255:{f.Push(JValue.R(rt.String("IsCombat")));f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",260);}
case 260:{f.Push(JValue.R(rt.String("True")));f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",265);}
case 265:{f.Push(f.Locals[4]);f.Pc=267;continue;}
case 267:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?273:270;continue;}
case 270:{f.Pc=105;continue;}
case 273:{f.Push(f.Locals[9]);f.Pc=275;continue;}
case 275:{f.Push(JValue.R(rt.String("Prevent")));f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",280);}
case 280:{f.Pc=f.Pop().Int==0?285:283;continue;}
case 283:{f.Push(JValue.I(0));f.Pc=284;continue;}
case 284:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 285:{f.Push(f.Locals[9]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",290);}
case 290:{f.Pc=f.Pop().Reference==null?335:293;continue;}
case 293:{f.Push(f.Locals[9]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",298);}
case 298:{f.Locals[10]=f.Pop();f.Pc=300;continue;}
case 300:{f.Push(f.Locals[10]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",305);}
case 305:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"));f.Pc=308;continue;}
case 308:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?332:311;continue;}
case 311:{f.Push(JValue.I(0));f.Pc=312;continue;}
case 312:{f.Push(f.Locals[1]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[7]);f.Pc=315;continue;}
case 315:{f.Push(f.Locals[10]);f.Pc=317;continue;}
case 317:{f.Push(JValue.R(rt.String("Amount")));f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",322);}
case 322:{f.Push(f.Locals[10]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",327);}
case 327:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=328;continue;}
case 328:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",331);}
case 331:{f.Locals[1]=f.Pop();f.Pc=332;continue;}
case 332:{f.Pc=337;continue;}
case 335:{f.Push(JValue.I(0));f.Pc=336;continue;}
case 336:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 337:{f.Pc=105;continue;}
case 340:{f.Pc=71;continue;}
case 343:{f.Push(JValue.I(0));f.Pc=344;continue;}
case 344:{f.Push(f.Locals[1]);f.Pc=345;continue;}
case 345:{f.Push(f.Locals[2]);f.Pc=346;continue;}
case 346:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=347;continue;}
case 347:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",350);}
case 350:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2173(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","getTotalPreventionShieldAmount","(Lforge/game/GameEntity;)I","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2176(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntity","getAttachedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/game/GameEntity:2176:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",9);}
case 9:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2177(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntity","getAllAttachedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/CardPredicates","phasedIn","()Ljava/util/function/Predicate;","invokestatic",7);}
case 7:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2178(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","attachedCards","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","getView","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2179(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameEntity","getView","()Lforge/game/GameEntityView;","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","attachedCards","Lforge/game/card/CardCollection;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/GameEntityView","setCards","(Lforge/game/card/CardCollection;Ljava/lang/Iterable;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;","invokevirtual",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntity","attachedCards","Lforge/game/card/CardCollection;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2180(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameEntity","getView","()Lforge/game/GameEntityView;","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","attachedCards","Lforge/game/card/CardCollection;"));f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/GameEntityView","clearCards","(Lforge/game/card/CardCollection;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;","invokevirtual",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntity","attachedCards","Lforge/game/card/CardCollection;",value);f.Pc=18;continue;}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2181(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntity","getAttachedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2182(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntity","getAttachedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/game/GameEntity:2182:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",9);}
case 9:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",14);}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2183(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntity","getAttachedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2184(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameEntity","hasCardAttachment","(Lforge/game/card/Card;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2185(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntity","getAttachedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardPredicates","nameEquals","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2186(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameEntity","hasCardAttachment","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2187(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameEntity","getView","()Lforge/game/GameEntityView;","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","attachedCards","Lforge/game/card/CardCollection;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/GameEntityView","addCard","(Lforge/game/card/CardCollection;Lforge/game/card/Card;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;","invokevirtual",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntity","attachedCards","Lforge/game/card/CardCollection;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2188(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameEntity","getView","()Lforge/game/GameEntityView;","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","attachedCards","Lforge/game/card/CardCollection;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/GameEntityView","removeCard","(Lforge/game/card/CardCollection;Lforge/game/card/Card;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;","invokevirtual",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntity","attachedCards","Lforge/game/card/CardCollection;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2189(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntity","getView","()Lforge/game/GameEntityView;","invokevirtual",4);}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","attachedCards","Lforge/game/card/CardCollection;"));f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/GameEntityView","setCards","(Lforge/game/card/CardCollection;Lforge/game/card/CardCollection;Lforge/trackable/TrackableProperty;)Lforge/game/card/CardCollection;","invokevirtual",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2190(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntity","getAttachedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?38:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","unattachFromEntity","(Lforge/game/GameEntity;Lforge/game/GameEntity;)V","invokevirtual",35);}
case 35:{f.Pc=10;continue;}
case 38:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2191(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameEntity","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2192(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameEntity","cantBeAttachedMsg","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Z)Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Reference!=null?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2193(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameEntity","cantBeAttachedMsg","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Z)Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2194(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isAttachment","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?17:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.DynamicCall(f,"forge/game/GameEntity:2194:11:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",16);}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/GameEntity","equals","(Ljava/lang/Object;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?35:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",29);}
case 29:{return rt.DynamicCall(f,"forge/game/GameEntity:2194:29:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",34);}
case 34:{return JStep.Return(f.Pop());}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?62:42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","RECONFIGURE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","RECONFIGURE","Lforge/game/keyword/Keyword;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int!=0?62:52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",56);}
case 56:{return rt.DynamicCall(f,"forge/game/GameEntity:2194:56:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",61);}
case 61:{return JStep.Return(f.Pop());}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?79:69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",73);}
case 73:{return rt.DynamicCall(f,"forge/game/GameEntity:2194:73:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",78);}
case 78:{return JStep.Return(f.Pop());}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int==0?101:86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/GameEntity","cantBeEnchantedByMsg","(Lforge/game/card/Card;)Ljava/lang/String;","invokevirtual",91);}
case 91:{f.Locals[4]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{f.Pc=f.Pop().Reference==null?101:98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{return JStep.Return(f.Pop());}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/Card","isEquipment","()Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?124:108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/GameEntity","cantBeEquippedByMsg","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",114);}
case 114:{f.Locals[4]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{f.Pc=f.Pop().Reference==null?124:121;continue;}
case 121:{f.Push(f.Locals[4]);f.Pc=123;continue;}
case 123:{return JStep.Return(f.Pop());}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/Card","isFortification","()Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?146:131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/GameEntity","cantBeFortifiedByMsg","(Lforge/game/card/Card;)Ljava/lang/String;","invokevirtual",136);}
case 136:{f.Locals[4]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[4]);f.Pc=140;continue;}
case 140:{f.Pc=f.Pop().Reference==null?146:143;continue;}
case 143:{f.Push(f.Locals[4]);f.Pc=145;continue;}
case 145:{return JStep.Return(f.Pop());}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[3]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttach","cantAttach","(Lforge/game/GameEntity;Lforge/game/card/Card;Z)Lforge/game/staticability/StaticAbility;","invokestatic",152);}
case 152:{f.Locals[4]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[4]);f.Pc=156;continue;}
case 156:{f.Pc=f.Pop().Reference==null?165:159;continue;}
case 159:{f.Push(f.Locals[4]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/staticability/StaticAbility","toString","()Ljava/lang/String;","invokevirtual",164);}
case 164:{return JStep.Return(f.Pop());}
case 165:{f.Push(JValue.R(null));f.Pc=166;continue;}
case 166:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2195(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntity","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/game/GameEntity:2195:4:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2196(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntity","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/game/GameEntity:2196:4:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2197(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","ENCHANT","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","ENCHANT","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?14:10;continue;}
case 10:{f.Push(JValue.R(rt.String("No Enchant Keyword")));f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","ENCHANT","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","ENCHANT","Lforge/game/keyword/Keyword;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/Card","getKeywords","(Lforge/game/keyword/Keyword;)Ljava/util/Collection;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?113:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/keyword/KeywordWithType")?1:0));f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Int==0?110:53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordWithType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{f.Locals[4]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/keyword/KeywordWithType","getValidType","()Ljava/lang/String;","invokevirtual",64);}
case 64:{f.Locals[5]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/keyword/KeywordWithType","getTypeDescription","()Ljava/lang/String;","invokevirtual",71);}
case 71:{f.Locals[6]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String(",")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",82);}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",86);}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(null));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/GameEntity","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int!=0?110:94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/GameEntity","getName","()Ljava/lang/String;","invokevirtual",98);}
case 98:{f.Push(JValue.I(1));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[6]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/util/Lang","nounWithAmount","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",104);}
case 104:{return rt.DynamicCall(f,"forge/game/GameEntity:2197:104:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",109);}
case 109:{return JStep.Return(f.Pop());}
case 110:{f.Pc=27;continue;}
case 113:{f.Push(JValue.R(null));f.Pc=114;continue;}
case 114:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2198(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","counters","Lcom/google/common/collect/Multiset;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Multiset","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2199(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","counters","Lcom/google/common/collect/Multiset;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2200(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","counters","Lcom/google/common/collect/Multiset;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Multiset","size","()I","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2201(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","counters","Lcom/google/common/collect/Multiset;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Multiset","count","(Ljava/lang/Object;)I","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2202(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","counters","Lcom/google/common/collect/Multiset;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",9);}
case 9:{return rt.Call(f,"com/google/common/collect/Multiset","setCount","(Ljava/lang/Object;I)I","invokeinterface",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2205(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/GameEntity","canReceiveCounters","(Lforge/game/card/CounterType;Ljava/util/Map;)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2209(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int<=0?13:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/GameEntity","canReceiveCounters","(Lforge/game/card/CounterType;Ljava/util/Map;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?14:13;continue;}
case 13:{return JStep.ReturnVoid;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2211(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2212(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","damageReceivedThisTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2213(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","damageReceivedThisTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2214(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","damageReceivedLastTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2215(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","damageReceivedThisTurn","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2216(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/GameEntity","getAssignedDamage","(Ljava/lang/Boolean;Lforge/game/card/Card;)I","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2217(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",5);}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/GameEntity","getAssignedDamage","(Ljava/lang/Boolean;Lforge/game/card/Card;)I","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2218(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameEntity","getAssignedDamage","(Ljava/lang/Boolean;Lforge/game/card/Card;Z)I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2219(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","damageReceivedLastTurn","Ljava/util/List;"));f.Pc=11;continue;}
case 11:{f.Pc=18;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","damageReceivedThisTurn","Ljava/util/List;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",23);}
case 23:{f.Locals[5]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[5]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?111:35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[6]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Pc=f.Pop().Reference==null?63:51;continue;}
case 51:{f.Push(f.Locals[6]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",56);}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?63:60;continue;}
case 60:{f.Pc=25;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{f.Pc=f.Pop().Reference==null?92:67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",71);}
case 71:{f.Push(f.Locals[6]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/Game","getDamageLKI","(Lorg/apache/commons/lang3/tuple/Pair;)Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",76);}
case 76:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int!=0?92:89;continue;}
case 89:{f.Pc=25;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",105);}
case 105:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=106;continue;}
case 106:{f.Locals[4]=f.Pop();f.Pc=108;continue;}
case 108:{f.Pc=25;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2220(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Object","hashCode","()I","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","id","I"));f.Pc=14;continue;}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?35:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",25);}
case 25:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?35:31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Pc=36;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2221(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","id","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2222(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntity","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

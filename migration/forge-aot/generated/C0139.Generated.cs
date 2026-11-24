// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C139{
internal static JClass Build(){var c=new JClass("forge/game/GameEntityCounterTable","com/google/common/collect/ForwardingTable",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("dataMap","Lcom/google/common/collect/Table;",false,JValue.Default("Lcom/google/common/collect/Table;"),null));
c.Add(new JMethod(2225,"forge/game/GameEntityCounterTable","<init>","()V",1,1,2,new JHandler[]{},M2225));
c.Add(new JMethod(2226,"forge/game/GameEntityCounterTable","<init>","(Lcom/google/common/collect/Table;)V",1,2,2,new JHandler[]{},M2226));
c.Add(new JMethod(2227,"forge/game/GameEntityCounterTable","delegate","()Lcom/google/common/collect/Table;",4,1,1,new JHandler[]{},M2227));
c.Add(new JMethod(2228,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I",1,7,4,new JHandler[]{},M2228));
c.Add(new JMethod(2229,"forge/game/GameEntityCounterTable","get","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;)I",1,6,3,new JHandler[]{},M2229));
c.Add(new JMethod(2230,"forge/game/GameEntityCounterTable","totalValues","()I",1,1,2,new JHandler[]{},M2230));
c.Add(new JMethod(2231,"forge/game/GameEntityCounterTable","filterToRemove","(Lforge/game/GameEntity;)Lcom/google/common/collect/Multiset;",1,3,2,new JHandler[]{},M2231));
c.Add(new JMethod(2232,"forge/game/GameEntityCounterTable","filterTable","(Lforge/game/card/CounterType;Ljava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/Map;",1,7,6,new JHandler[]{},M2232));
c.Add(new JMethod(2233,"forge/game/GameEntityCounterTable","triggerCountersPutAll","(Lforge/game/Game;)V",1,5,4,new JHandler[]{},M2233));
c.Add(new JMethod(2234,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V",1,3,6,new JHandler[]{},M2234));
c.Add(new JMethod(2235,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;ZZLjava/util/Map;)Z",1,18,7,new JHandler[]{},M2235));
c.Add(new JMethod(2236,"forge/game/GameEntityCounterTable","delegate","()Ljava/lang/Object;",4164,1,1,new JHandler[]{},M2236));
c.Add(new JMethod(2237,"forge/game/GameEntityCounterTable","lambda$filterTable$5","(Ljava/lang/Integer;)Z",4106,1,1,new JHandler[]{},M2237));
c.Add(new JMethod(2238,"forge/game/GameEntityCounterTable","lambda$filterTable$4","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/card/CounterType;Ljava/util/Map$Entry;)I",4106,5,4,new JHandler[]{},M2238));
c.Add(new JMethod(2239,"forge/game/GameEntityCounterTable","lambda$filterTable$3","(Lforge/game/card/CounterType;Ljava/util/Map$Entry;)I",4106,2,2,new JHandler[]{},M2239));
c.Add(new JMethod(2240,"forge/game/GameEntityCounterTable","lambda$filterTable$2","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Ljava/util/Map$Entry;)Z",4106,4,5,new JHandler[]{},M2240));
c.Add(new JMethod(2241,"forge/game/GameEntityCounterTable","lambda$filterTable$1","(Ljava/util/Map$Entry;)Lforge/game/GameEntity;",4106,1,1,new JHandler[]{},M2241));
c.Add(new JMethod(2242,"forge/game/GameEntityCounterTable","lambda$filterTable$0","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Ljava/util/Map$Entry;)Z",4106,4,5,new JHandler[]{},M2242));
}

internal static JStep M2225(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/ForwardingTable","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntityCounterTable","dataMap","Lcom/google/common/collect/Table;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2226(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/ForwardingTable","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameEntityCounterTable","dataMap","Lcom/google/common/collect/Table;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/GameEntityCounterTable","putAll","(Lcom/google/common/collect/Table;)V","invokevirtual",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2227(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameEntityCounterTable","dataMap","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2228(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Optional","ofNullable","(Ljava/lang/Object;)Ljava/util/Optional;","invokestatic",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[5]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/GameEntityCounterTable","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",13);}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{f.Locals[6]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[6]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference!=null?38:23;continue;}
case 23:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","()Lcom/google/common/collect/HashMultiset;","invokestatic",26);}
case 26:{f.Locals[6]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[5]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Int<=0?54:43;continue;}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"com/google/common/collect/Multiset","add","(Ljava/lang/Object;I)I","invokeinterface",53);}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{f.Push(JNumbers.Unary("ineg",f.Pop()));f.Pc=60;continue;}
case 60:{return rt.Call(f,"com/google/common/collect/Multiset","remove","(Ljava/lang/Object;I)I","invokeinterface",65);}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2229(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Optional","ofNullable","(Ljava/lang/Object;)Ljava/util/Optional;","invokestatic",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[4]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/GameEntityCounterTable","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",13);}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference!=null?25:23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Push(f.Locals[5]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"com/google/common/collect/Multiset","count","(Ljava/lang/Object;)I","invokeinterface",33);}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2230(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntityCounterTable","values","()Ljava/util/Collection;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",9);}
case 9:{return rt.DynamicCall(f,"forge/game/GameEntityCounterTable:2230:9:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",14);}
case 14:{return rt.Call(f,"java/util/stream/Collectors","summingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;","invokestatic",17);}
case 17:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",28);}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2231(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameEntityCounterTable","containsColumn","(Ljava/lang/Object;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int!=0?16:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/GameEntity","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",12);}
case 12:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","(Ljava/lang/Iterable;)Lcom/google/common/collect/HashMultiset;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/GameEntityCounterTable","column","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/util/Optional","empty","()Ljava/util/Optional;","invokestatic",24);}
case 24:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[2]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/GameEntity","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",37);}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"com/google/common/collect/Multisets","difference","(Lcom/google/common/collect/Multiset;Lcom/google/common/collect/Multiset;)Lcom/google/common/collect/Multiset;","invokestatic",41);}
case 41:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","(Ljava/lang/Iterable;)Lcom/google/common/collect/HashMultiset;","invokestatic",44);}
case 44:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2232(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntityCounterTable","columnMap","()Ljava/util/Map;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",14);}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[5]);f.Pc=19;continue;}
case 19:{return rt.DynamicCall(f,"forge/game/GameEntityCounterTable:2232:19:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;",24);}
case 24:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",29);}
case 29:{return rt.DynamicCall(f,"forge/game/GameEntityCounterTable:2232:29:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",34);}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[5]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.DynamicCall(f,"forge/game/GameEntityCounterTable:2232:40:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/card/CounterType;)Ljava/util/function/ToIntFunction;",45);}
case 45:{return rt.Call(f,"java/util/stream/Collectors","summingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;","invokestatic",48);}
case 48:{return rt.Call(f,"java/util/stream/Collectors","groupingBy","(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;","invokestatic",51);}
case 51:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",68);}
case 68:{return rt.DynamicCall(f,"forge/game/GameEntityCounterTable:2232:68:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",73);}
case 73:{return rt.Call(f,"java/util/Collection","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2233(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntityCounterTable","isEmpty","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/GameEntityCounterTable","cellSet","()Ljava/util/Set;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?135:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table$Cell"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{return rt.Call(f,"com/google/common/collect/Multiset","isEmpty","()Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int==0?57:54;continue;}
case 54:{f.Pc=18;continue;}
case 57:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",60);}
case 60:{f.Locals[4]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",73);}
case 73:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Optional"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Optional","get","()Ljava/lang/Object;","invokevirtual",79);}
case 79:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Object","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Object","Lforge/game/ability/AbilityKey;"));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[3]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",96);}
case 96:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",101);}
case 101:{f.StackOp("pop");f.Pc=102;continue;}
case 102:{f.Push(f.Locals[4]);f.Pc=104;continue;}
case 104:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",113);}
case 113:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",118);}
case 118:{f.StackOp("pop");f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",123);}
case 123:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","CounterPlayerAddedAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","CounterPlayerAddedAll","Lforge/game/trigger/TriggerType;"));f.Pc=126;continue;}
case 126:{f.Push(f.Locals[4]);f.Pc=128;continue;}
case 128:{f.Push(JValue.I(0));f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",132);}
case 132:{f.Pc=18;continue;}
case 135:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",138);}
case 138:{f.Locals[2]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Objects","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Objects","Lforge/game/ability/AbilityKey;"));f.Pc=143;continue;}
case 143:{f.Push(f.Locals[0]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",154);}
case 154:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","CounterAddedAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","CounterAddedAll","Lforge/game/trigger/TriggerType;"));f.Pc=157;continue;}
case 157:{f.Push(f.Locals[2]);f.Pc=158;continue;}
case 158:{f.Push(JValue.I(0));f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",162);}
case 162:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2234(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?18:7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilityStatic")?1:0));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int!=0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;ZZLjava/util/Map;)Z","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2235(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntityCounterTable","isEmpty","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",16);}
case 16:{f.Locals[6]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/GameEntityCounterTable","columnMap","()Ljava/util/Map;","invokevirtual",22);}
case 22:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",27);}
case 27:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",32);}
case 32:{f.Locals[7]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[7]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?618:44;continue;}
case 44:{f.Push(f.Locals[7]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[8]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[8]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[9]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{f.Pc=f.Pop().Int!=0?212:73;continue;}
case 73:{f.Push(f.Locals[8]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",80);}
case 80:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",86);}
case 86:{f.Locals[10]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[10]);f.Pc=90;continue;}
case 90:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",99);}
case 99:{f.StackOp("pop");f.Pc=100;continue;}
case 100:{f.Push(f.Locals[10]);f.Pc=102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","EffectOnly","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","EffectOnly","Lforge/game/ability/AbilityKey;"));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[3]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",109);}
case 109:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Push(f.Locals[10]);f.Pc=117;continue;}
case 117:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[9]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",127);}
case 127:{f.StackOp("pop");f.Pc=128;continue;}
case 128:{f.Push(f.Locals[5]);f.Pc=130;continue;}
case 130:{f.Pc=f.Pop().Reference==null?142:133;continue;}
case 133:{f.Push(f.Locals[10]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[5]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",142);}
case 142:{if(!rt.StaticReady(f,"forge/game/GameEntityCounterTable$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameEntityCounterTable$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",149);}
case 149:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","AddCounter","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","AddCounter","Lforge/game/replacement/ReplacementType;"));f.Pc=152;continue;}
case 152:{f.Push(f.Locals[10]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",157);}
case 157:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",160);}
case 160:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=161;continue;}
case 161:{switch(f.Pop().Int){case 1:f.Pc=188;break;case 2:f.Pc=191;break;default:f.Pc=209;break;}continue;}
case 188:{f.Pc=212;continue;}
case 191:{f.Push(f.Locals[10]);f.Pc=193;continue;}
case 193:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"));f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",201);}
case 201:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=204;continue;}
case 204:{f.Locals[9]=f.Pop();f.Pc=206;continue;}
case 206:{f.Pc=212;continue;}
case 209:{f.Pc=34;continue;}
case 212:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",215);}
case 215:{f.Locals[10]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[10]);f.Pc=219;continue;}
case 219:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=222;continue;}
case 222:{f.Push(f.Locals[2]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",228);}
case 228:{f.StackOp("pop");f.Pc=229;continue;}
case 229:{f.Push(f.Locals[4]);f.Pc=231;continue;}
case 231:{f.Pc=f.Pop().Int==0?248:234;continue;}
case 234:{f.Push(f.Locals[10]);f.Pc=236;continue;}
case 236:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=239;continue;}
case 239:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",247);}
case 247:{f.StackOp("pop");f.Pc=248;continue;}
case 248:{f.Push(f.Locals[5]);f.Pc=250;continue;}
case 250:{f.Pc=f.Pop().Reference==null?262:253;continue;}
case 253:{f.Push(f.Locals[10]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[5]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",262);}
case 262:{f.Push(f.Locals[8]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",269);}
case 269:{f.Locals[13]=f.Pop();f.Pc=271;continue;}
case 271:{f.Push(f.Locals[13]);f.Pc=273;continue;}
case 273:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=276;continue;}
case 276:{f.Pc=f.Pop().Int==0?300:279;continue;}
case 279:{f.Push(f.Locals[13]);f.Pc=281;continue;}
case 281:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=284;continue;}
case 284:{f.Locals[12]=f.Pop();f.Pc=286;continue;}
case 286:{f.Push(f.Locals[1]);f.Pc=287;continue;}
case 287:{f.Push(JValue.R(null));f.Pc=288;continue;}
case 288:{f.Push(f.Locals[12]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/Game","getCounterAddedThisTurn","(Lforge/game/card/CounterType;Lforge/game/card/Card;)I","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int!=0?300:296;continue;}
case 296:{f.Push(JValue.I(1));f.Pc=297;continue;}
case 297:{f.Pc=301;continue;}
case 300:{f.Push(JValue.I(0));f.Pc=301;continue;}
case 301:{f.Locals[11]=f.Pop();f.Pc=303;continue;}
case 303:{f.Push(f.Locals[9]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",310);}
case 310:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",315);}
case 315:{f.Locals[12]=f.Pop();f.Pc=317;continue;}
case 317:{f.Push(f.Locals[12]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",324);}
case 324:{f.Pc=f.Pop().Int==0?548:327;continue;}
case 327:{f.Push(f.Locals[12]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",334);}
case 334:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=337;continue;}
case 337:{f.Locals[13]=f.Pop();f.Pc=339;continue;}
case 339:{f.Push(f.Locals[2]);f.Pc=340;continue;}
case 340:{f.Pc=f.Pop().Reference==null?357:343;continue;}
case 343:{f.Push(f.Locals[2]);f.Pc=344;continue;}
case 344:{f.Push(JValue.R(rt.String("RememberPut")));f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",350);}
case 350:{f.Pc=f.Pop().Int==0?357:353;continue;}
case 353:{f.Push(JValue.I(1));f.Pc=354;continue;}
case 354:{f.Pc=358;continue;}
case 357:{f.Push(JValue.I(0));f.Pc=358;continue;}
case 358:{f.Locals[14]=f.Pop();f.Pc=360;continue;}
case 360:{f.Push(f.Locals[13]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",367);}
case 367:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=370;continue;}
case 370:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",375);}
case 375:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",380);}
case 380:{f.Locals[15]=f.Pop();f.Pc=382;continue;}
case 382:{f.Push(f.Locals[15]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",389);}
case 389:{f.Pc=f.Pop().Int==0?545:392;continue;}
case 392:{f.Push(f.Locals[15]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",399);}
case 399:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=402;continue;}
case 402:{f.Locals[16]=f.Pop();f.Pc=404;continue;}
case 404:{f.Push(f.Locals[16]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",411);}
case 411:{f.Locals[17]=f.Pop();f.Pc=413;continue;}
case 413:{f.Push(f.Locals[2]);f.Pc=414;continue;}
case 414:{f.Pc=f.Pop().Reference==null?468:417;continue;}
case 417:{f.Push(f.Locals[2]);f.Pc=418;continue;}
case 418:{f.Push(JValue.R(rt.String("MaxFromEffect")));f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",424);}
case 424:{f.Pc=f.Pop().Int==0?468:427;continue;}
case 427:{f.Push(f.Locals[17]);f.Pc=429;continue;}
case 429:{f.Push(f.Locals[2]);f.Pc=430;continue;}
case 430:{f.Push(JValue.R(rt.String("MaxFromEffect")));f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",436);}
case 436:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",439);}
case 439:{f.Push(f.Locals[8]);f.Pc=441;continue;}
case 441:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",446);}
case 446:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=449;continue;}
case 449:{f.Push(f.Locals[16]);f.Pc=451;continue;}
case 451:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",456);}
case 456:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=459;continue;}
case 459:{return rt.Call(f,"forge/game/GameEntity","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",462);}
case 462:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=463;continue;}
case 463:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",466);}
case 466:{f.Locals[17]=f.Pop();f.Pc=468;continue;}
case 468:{f.Push(f.Locals[8]);f.Pc=470;continue;}
case 470:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",475);}
case 475:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=478;continue;}
case 478:{f.Push(f.Locals[16]);f.Pc=480;continue;}
case 480:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",485);}
case 485:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=488;continue;}
case 488:{f.Push(f.Locals[17]);f.Pc=490;continue;}
case 490:{f.Push(f.Locals[13]);f.Pc=492;continue;}
case 492:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",497);}
case 497:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Optional"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=500;continue;}
case 500:{f.Push(JValue.R(null));f.Pc=501;continue;}
case 501:{return rt.Call(f,"java/util/Optional","orElse","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",504);}
case 504:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=507;continue;}
case 507:{f.Push(JValue.I(1));f.Pc=508;continue;}
case 508:{f.Push(f.Locals[6]);f.Pc=510;continue;}
case 510:{f.Push(f.Locals[10]);f.Pc=512;continue;}
case 512:{return rt.Call(f,"forge/game/GameEntity","addCounterInternal","(Lforge/game/card/CounterType;ILforge/game/player/Player;ZLforge/game/GameEntityCounterTable;Ljava/util/Map;)V","invokevirtual",515);}
case 515:{f.Push(f.Locals[14]);f.Pc=517;continue;}
case 517:{f.Pc=f.Pop().Int==0?542:520;continue;}
case 520:{f.Push(f.Locals[17]);f.Pc=522;continue;}
case 522:{f.Pc=f.Pop().Int<=0?542:525;continue;}
case 525:{f.Push(f.Locals[2]);f.Pc=526;continue;}
case 526:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",529);}
case 529:{f.Push(f.Locals[8]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",536);}
case 536:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=539;continue;}
case 539:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",542);}
case 542:{f.Pc=382;continue;}
case 545:{f.Pc=317;continue;}
case 548:{f.Push(f.Locals[6]);f.Pc=550;continue;}
case 550:{f.Push(f.Locals[8]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",557);}
case 557:{return rt.Call(f,"forge/game/GameEntityCounterTable","containsColumn","(Ljava/lang/Object;)Z","invokevirtual",560);}
case 560:{f.Pc=f.Pop().Int==0?615:563;continue;}
case 563:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",566);}
case 566:{f.Locals[10]=f.Pop();f.Pc=568;continue;}
case 568:{f.Push(f.Locals[10]);f.Pc=570;continue;}
case 570:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Object","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Object","Lforge/game/ability/AbilityKey;"));f.Pc=573;continue;}
case 573:{f.Push(f.Locals[8]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",580);}
case 580:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",585);}
case 585:{f.StackOp("pop");f.Pc=586;continue;}
case 586:{f.Push(f.Locals[10]);f.Pc=588;continue;}
case 588:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","FirstTime","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","FirstTime","Lforge/game/ability/AbilityKey;"));f.Pc=591;continue;}
case 591:{f.Push(f.Locals[11]);f.Pc=593;continue;}
case 593:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",596);}
case 596:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",601);}
case 601:{f.StackOp("pop");f.Pc=602;continue;}
case 602:{f.Push(f.Locals[1]);f.Pc=603;continue;}
case 603:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",606);}
case 606:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","CounterTypeAddedAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","CounterTypeAddedAll","Lforge/game/trigger/TriggerType;"));f.Pc=609;continue;}
case 609:{f.Push(f.Locals[10]);f.Pc=611;continue;}
case 611:{f.Push(JValue.I(0));f.Pc=612;continue;}
case 612:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",615);}
case 615:{f.Pc=34;continue;}
case 618:{f.Push(f.Locals[0]);f.Pc=619;continue;}
case 619:{return rt.Call(f,"forge/game/GameEntityCounterTable","totalValues","()I","invokevirtual",622);}
case 622:{f.Locals[7]=f.Pop();f.Pc=624;continue;}
case 624:{f.Push(f.Locals[7]);f.Pc=626;continue;}
case 626:{f.Pc=f.Pop().Int<=0?655:629;continue;}
case 629:{f.Push(f.Locals[2]);f.Pc=630;continue;}
case 630:{f.Pc=f.Pop().Reference==null?655:633;continue;}
case 633:{f.Push(f.Locals[2]);f.Pc=634;continue;}
case 634:{f.Push(JValue.R(rt.String("RememberAmount")));f.Pc=637;continue;}
case 637:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",640);}
case 640:{f.Pc=f.Pop().Int==0?655:643;continue;}
case 643:{f.Push(f.Locals[2]);f.Pc=644;continue;}
case 644:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",647);}
case 647:{f.Push(f.Locals[7]);f.Pc=649;continue;}
case 649:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",652);}
case 652:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",655);}
case 655:{f.Push(f.Locals[6]);f.Pc=657;continue;}
case 657:{f.Push(f.Locals[1]);f.Pc=658;continue;}
case 658:{return rt.Call(f,"forge/game/GameEntityCounterTable","triggerCountersPutAll","(Lforge/game/Game;)V","invokevirtual",661);}
case 661:{f.Push(f.Locals[6]);f.Pc=663;continue;}
case 663:{return rt.Call(f,"forge/game/GameEntityCounterTable","isEmpty","()Z","invokevirtual",666);}
case 666:{f.Pc=f.Pop().Int!=0?673:669;continue;}
case 669:{f.Push(JValue.I(1));f.Pc=670;continue;}
case 670:{f.Pc=674;continue;}
case 673:{f.Push(JValue.I(0));f.Pc=674;continue;}
case 674:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2236(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntityCounterTable","delegate","()Lcom/google/common/collect/Table;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2237(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2238(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",15);}
case 15:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.DynamicCall(f,"forge/game/GameEntityCounterTable:2238:23:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;",28);}
case 28:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",33);}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.DynamicCall(f,"forge/game/GameEntityCounterTable:2238:34:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CounterType;)Ljava/util/function/ToIntFunction;",39);}
case 39:{return rt.Call(f,"java/util/stream/Stream","mapToInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/IntStream;","invokeinterface",44);}
case 44:{return rt.Call(f,"java/util/stream/IntStream","sum","()I","invokeinterface",49);}
case 49:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2239(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?21:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return rt.Call(f,"com/google/common/collect/Multiset","size","()I","invokeinterface",18);}
case 18:{f.Pc=36;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"com/google/common/collect/Multiset","count","(Ljava/lang/Object;)I","invokeinterface",36);}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2240(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?47:4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Optional"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Optional","isPresent","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?51:19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Optional"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Optional","get","()Ljava/lang/Object;","invokevirtual",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",39);}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/player/Player","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?51:47;continue;}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{f.Pc=52;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2241(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2242(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",14);}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/GameEntity","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",19);}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

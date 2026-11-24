// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C575{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventAnteCardsSelected","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cards","Lcom/google/common/collect/Multimap;",false,JValue.Default("Lcom/google/common/collect/Multimap;"),null));
c.Add(new JMethod(6775,"forge/game/event/GameEventAnteCardsSelected","<init>","(Lcom/google/common/collect/Multimap;)V",1,2,2,new JHandler[]{},M6775));
c.Add(new JMethod(6776,"forge/game/event/GameEventAnteCardsSelected","fromCards","(Lcom/google/common/collect/Multimap;)Lforge/game/event/GameEventAnteCardsSelected;",9,1,3,new JHandler[]{},M6776));
c.Add(new JMethod(6777,"forge/game/event/GameEventAnteCardsSelected","convertMap","(Lcom/google/common/collect/Multimap;)Lcom/google/common/collect/Multimap;",10,4,3,new JHandler[]{},M6777));
c.Add(new JMethod(6778,"forge/game/event/GameEventAnteCardsSelected","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6778));
c.Add(new JMethod(6779,"forge/game/event/GameEventAnteCardsSelected","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M6779));
c.Add(new JMethod(6780,"forge/game/event/GameEventAnteCardsSelected","hashCode","()I",17,1,1,new JHandler[]{},M6780));
c.Add(new JMethod(6781,"forge/game/event/GameEventAnteCardsSelected","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6781));
c.Add(new JMethod(6782,"forge/game/event/GameEventAnteCardsSelected","cards","()Lcom/google/common/collect/Multimap;",1,1,1,new JHandler[]{},M6782));
}

internal static JStep M6775(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventAnteCardsSelected","cards","Lcom/google/common/collect/Multimap;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6776(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAnteCardsSelected"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAnteCardsSelected")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/event/GameEventAnteCardsSelected","convertMap","(Lcom/google/common/collect/Multimap;)Lcom/google/common/collect/Multimap;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/event/GameEventAnteCardsSelected","<init>","(Lcom/google/common/collect/Multimap;)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6777(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/HashMultimap","create","()Lcom/google/common/collect/HashMultimap;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",10);}
case 10:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?69:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",48);}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",60);}
case 60:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Pc=16;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6778(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventAnteCardsSelected;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6779(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventAnteCardsSelected:6779:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventAnteCardsSelected;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6780(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventAnteCardsSelected:6780:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventAnteCardsSelected;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6781(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventAnteCardsSelected:6781:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventAnteCardsSelected;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6782(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventAnteCardsSelected","cards","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

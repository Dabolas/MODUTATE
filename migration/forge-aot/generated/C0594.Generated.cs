// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C594{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventCombatUpdate","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("attackers","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("blockers","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(6925,"forge/game/event/GameEventCombatUpdate","<init>","(Ljava/util/List;Ljava/util/List;)V",1,3,2,new JHandler[]{},M6925));
c.Add(new JMethod(6926,"forge/game/event/GameEventCombatUpdate","fromCards","(Ljava/util/List;Ljava/util/List;)Lforge/game/event/GameEventCombatUpdate;",9,2,5,new JHandler[]{},M6926));
c.Add(new JMethod(6927,"forge/game/event/GameEventCombatUpdate","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6927));
c.Add(new JMethod(6928,"forge/game/event/GameEventCombatUpdate","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M6928));
c.Add(new JMethod(6929,"forge/game/event/GameEventCombatUpdate","hashCode","()I",17,1,1,new JHandler[]{},M6929));
c.Add(new JMethod(6930,"forge/game/event/GameEventCombatUpdate","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6930));
c.Add(new JMethod(6931,"forge/game/event/GameEventCombatUpdate","attackers","()Ljava/util/List;",1,1,1,new JHandler[]{},M6931));
c.Add(new JMethod(6932,"forge/game/event/GameEventCombatUpdate","blockers","()Ljava/util/List;",1,1,1,new JHandler[]{},M6932));
}

internal static JStep M6925(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCombatUpdate","attackers","Ljava/util/List;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCombatUpdate","blockers","Ljava/util/List;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6926(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatUpdate"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatUpdate")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference!=null?12:8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{f.Pc=39;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",18);}
case 18:{return rt.DynamicCall(f,"forge/game/event/GameEventCombatUpdate:6926:18:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",23);}
case 23:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",28);}
case 28:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",31);}
case 31:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Reference!=null?47:43;continue;}
case 43:{f.Push(JValue.R(null));f.Pc=44;continue;}
case 44:{f.Pc=74;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",53);}
case 53:{return rt.DynamicCall(f,"forge/game/event/GameEventCombatUpdate:6926:53:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",58);}
case 58:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",63);}
case 63:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",66);}
case 66:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/event/GameEventCombatUpdate","<init>","(Ljava/util/List;Ljava/util/List;)V","invokespecial",77);}
case 77:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6927(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCombatUpdate;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6928(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventCombatUpdate:6928:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCombatUpdate;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6929(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventCombatUpdate:6929:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCombatUpdate;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6930(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventCombatUpdate:6930:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCombatUpdate;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6931(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCombatUpdate","attackers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6932(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCombatUpdate","blockers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

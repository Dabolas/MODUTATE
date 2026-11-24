// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C574{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventAddLog","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("type","Lforge/game/GameLogEntryType;",false,JValue.Default("Lforge/game/GameLogEntryType;"),null));
c.Add(new JField("message","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("sourceCard","Lforge/game/card/CardView;",false,JValue.Default("Lforge/game/card/CardView;"),null));
c.Add(new JMethod(6765,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V",1,3,4,new JHandler[]{},M6765));
c.Add(new JMethod(6766,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/Card;)V",1,4,4,new JHandler[]{},M6766));
c.Add(new JMethod(6767,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/CardView;)V",1,4,2,new JHandler[]{},M6767));
c.Add(new JMethod(6768,"forge/game/event/GameEventAddLog","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6768));
c.Add(new JMethod(6769,"forge/game/event/GameEventAddLog","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M6769));
c.Add(new JMethod(6770,"forge/game/event/GameEventAddLog","hashCode","()I",17,1,1,new JHandler[]{},M6770));
c.Add(new JMethod(6771,"forge/game/event/GameEventAddLog","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6771));
c.Add(new JMethod(6772,"forge/game/event/GameEventAddLog","type","()Lforge/game/GameLogEntryType;",1,1,1,new JHandler[]{},M6772));
c.Add(new JMethod(6773,"forge/game/event/GameEventAddLog","message","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6773));
c.Add(new JMethod(6774,"forge/game/event/GameEventAddLog","sourceCard","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M6774));
}

internal static JStep M6765(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/CardView;)V","invokespecial",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6766(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?14:7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",11);}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/CardView;)V","invokespecial",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6767(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventAddLog","type","Lforge/game/GameLogEntryType;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventAddLog","message","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventAddLog","sourceCard","Lforge/game/card/CardView;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6768(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventAddLog;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6769(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventAddLog:6769:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventAddLog;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6770(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventAddLog:6770:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventAddLog;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6771(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventAddLog:6771:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventAddLog;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6772(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventAddLog","type","Lforge/game/GameLogEntryType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6773(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventAddLog","message","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6774(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventAddLog","sourceCard","Lforge/game/card/CardView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

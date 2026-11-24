// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C609{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventPlayerCounters","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("receiver","Lforge/game/player/PlayerView;",false,JValue.Default("Lforge/game/player/PlayerView;"),null));
c.Add(new JField("type","Lforge/game/card/CounterType;",false,JValue.Default("Lforge/game/card/CounterType;"),null));
c.Add(new JField("oldValue","I",false,JValue.Default("I"),null));
c.Add(new JField("amount","I",false,JValue.Default("I"),null));
c.Add(new JMethod(7039,"forge/game/event/GameEventPlayerCounters","<init>","(Lforge/game/player/Player;Lforge/game/card/CounterType;II)V",1,5,5,new JHandler[]{},M7039));
c.Add(new JMethod(7040,"forge/game/event/GameEventPlayerCounters","<init>","(Lforge/game/player/PlayerView;Lforge/game/card/CounterType;II)V",1,5,2,new JHandler[]{},M7040));
c.Add(new JMethod(7041,"forge/game/event/GameEventPlayerCounters","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M7041));
c.Add(new JMethod(7042,"forge/game/event/GameEventPlayerCounters","toString","()Ljava/lang/String;",1,1,4,new JHandler[]{},M7042));
c.Add(new JMethod(7043,"forge/game/event/GameEventPlayerCounters","hashCode","()I",17,1,1,new JHandler[]{},M7043));
c.Add(new JMethod(7044,"forge/game/event/GameEventPlayerCounters","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M7044));
c.Add(new JMethod(7045,"forge/game/event/GameEventPlayerCounters","receiver","()Lforge/game/player/PlayerView;",1,1,1,new JHandler[]{},M7045));
c.Add(new JMethod(7046,"forge/game/event/GameEventPlayerCounters","type","()Lforge/game/card/CounterType;",1,1,1,new JHandler[]{},M7046));
c.Add(new JMethod(7047,"forge/game/event/GameEventPlayerCounters","oldValue","()I",1,1,1,new JHandler[]{},M7047));
c.Add(new JMethod(7048,"forge/game/event/GameEventPlayerCounters","amount","()I",1,1,1,new JHandler[]{},M7048));
}

internal static JStep M7039(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[4]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/event/GameEventPlayerCounters","<init>","(Lforge/game/player/PlayerView;Lforge/game/card/CounterType;II)V","invokespecial",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7040(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventPlayerCounters","receiver","Lforge/game/player/PlayerView;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventPlayerCounters","type","Lforge/game/card/CounterType;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventPlayerCounters","oldValue","I",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventPlayerCounters","amount","I",value);f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7041(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventPlayerCounters;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7042(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerCounters","receiver","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerCounters","oldValue","I"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerCounters","amount","I"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerCounters","type","Lforge/game/card/CounterType;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",22);}
case 22:{return rt.DynamicCall(f,"forge/game/event/GameEventPlayerCounters:7042:22:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;IILjava/lang/String;)Ljava/lang/String;",27);}
case 27:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7043(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventPlayerCounters:7043:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventPlayerCounters;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7044(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventPlayerCounters:7044:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventPlayerCounters;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7045(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerCounters","receiver","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7046(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerCounters","type","Lforge/game/card/CounterType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7047(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerCounters","oldValue","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7048(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerCounters","amount","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

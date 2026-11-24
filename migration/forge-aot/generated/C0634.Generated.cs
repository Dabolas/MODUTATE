// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C634{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventTurnPhase","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("playerTurn","Lforge/game/player/PlayerView;",false,JValue.Default("Lforge/game/player/PlayerView;"),null));
c.Add(new JField("phase","Lforge/game/phase/PhaseType;",false,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("phaseDesc","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(7241,"forge/game/event/GameEventTurnPhase","<init>","(Lforge/game/player/Player;Lforge/game/phase/PhaseType;Ljava/lang/String;)V",1,4,4,new JHandler[]{},M7241));
c.Add(new JMethod(7242,"forge/game/event/GameEventTurnPhase","<init>","(Lforge/game/player/PlayerView;Lforge/game/phase/PhaseType;Ljava/lang/String;)V",1,4,2,new JHandler[]{},M7242));
c.Add(new JMethod(7243,"forge/game/event/GameEventTurnPhase","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M7243));
c.Add(new JMethod(7244,"forge/game/event/GameEventTurnPhase","toString","()Ljava/lang/String;",1,2,5,new JHandler[]{},M7244));
c.Add(new JMethod(7245,"forge/game/event/GameEventTurnPhase","hashCode","()I",17,1,1,new JHandler[]{},M7245));
c.Add(new JMethod(7246,"forge/game/event/GameEventTurnPhase","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M7246));
c.Add(new JMethod(7247,"forge/game/event/GameEventTurnPhase","playerTurn","()Lforge/game/player/PlayerView;",1,1,1,new JHandler[]{},M7247));
c.Add(new JMethod(7248,"forge/game/event/GameEventTurnPhase","phase","()Lforge/game/phase/PhaseType;",1,1,1,new JHandler[]{},M7248));
c.Add(new JMethod(7249,"forge/game/event/GameEventTurnPhase","phaseDesc","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7249));
}

internal static JStep M7241(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/event/GameEventTurnPhase","<init>","(Lforge/game/player/PlayerView;Lforge/game/phase/PhaseType;Ljava/lang/String;)V","invokespecial",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7242(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventTurnPhase","playerTurn","Lforge/game/player/PlayerView;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventTurnPhase","phase","Lforge/game/phase/PhaseType;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventTurnPhase","phaseDesc","Ljava/lang/String;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7243(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventTurnPhase;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7244(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventTurnPhase","playerTurn","Lforge/game/player/PlayerView;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/PlayerView","getName","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/util/Lang","getPossesive","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",13);}
case 13:{f.Locals[1]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(JValue.I(4));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("turn,")));f.Pc=26;continue;}
case 26:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{f.Push(JValue.I(2));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventTurnPhase","phaseDesc","Ljava/lang/String;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventTurnPhase","phase","Lforge/game/phase/PhaseType;"));f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseType","nameForUi","Ljava/lang/String;"));f.Pc=40;continue;}
case 40:{return rt.DynamicCall(f,"forge/game/event/GameEventTurnPhase:7244:40:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",45);}
case 45:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{f.Push(JValue.I(3));f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("phase")));f.Pc=50;continue;}
case 50:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",54);}
case 54:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7245(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventTurnPhase:7245:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventTurnPhase;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7246(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventTurnPhase:7246:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventTurnPhase;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7247(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventTurnPhase","playerTurn","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7248(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventTurnPhase","phase","Lforge/game/phase/PhaseType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7249(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventTurnPhase","phaseDesc","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

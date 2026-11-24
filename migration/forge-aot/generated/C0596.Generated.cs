// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C596{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventDoorChanged","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("activatingPlayer","Lforge/game/player/PlayerView;",false,JValue.Default("Lforge/game/player/PlayerView;"),null));
c.Add(new JField("card","Lforge/game/card/CardView;",false,JValue.Default("Lforge/game/card/CardView;"),null));
c.Add(new JField("state","Lforge/card/CardStateName;",false,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("unlock","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(6939,"forge/game/event/GameEventDoorChanged","<init>","(Lforge/game/player/Player;Lforge/game/card/Card;Lforge/card/CardStateName;Z)V",1,5,5,new JHandler[]{},M6939));
c.Add(new JMethod(6940,"forge/game/event/GameEventDoorChanged","<init>","(Lforge/game/player/PlayerView;Lforge/game/card/CardView;Lforge/card/CardStateName;Z)V",1,5,2,new JHandler[]{},M6940));
c.Add(new JMethod(6941,"forge/game/event/GameEventDoorChanged","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6941));
c.Add(new JMethod(6942,"forge/game/event/GameEventDoorChanged","toString","()Ljava/lang/String;",1,3,4,new JHandler[]{},M6942));
c.Add(new JMethod(6943,"forge/game/event/GameEventDoorChanged","hashCode","()I",17,1,1,new JHandler[]{},M6943));
c.Add(new JMethod(6944,"forge/game/event/GameEventDoorChanged","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6944));
c.Add(new JMethod(6945,"forge/game/event/GameEventDoorChanged","activatingPlayer","()Lforge/game/player/PlayerView;",1,1,1,new JHandler[]{},M6945));
c.Add(new JMethod(6946,"forge/game/event/GameEventDoorChanged","card","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M6946));
c.Add(new JMethod(6947,"forge/game/event/GameEventDoorChanged","state","()Lforge/card/CardStateName;",1,1,1,new JHandler[]{},M6947));
c.Add(new JMethod(6948,"forge/game/event/GameEventDoorChanged","unlock","()Z",1,1,1,new JHandler[]{},M6948));
}

internal static JStep M6939(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",9);}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/event/GameEventDoorChanged","<init>","(Lforge/game/player/PlayerView;Lforge/game/card/CardView;Lforge/card/CardStateName;Z)V","invokespecial",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6940(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventDoorChanged","activatingPlayer","Lforge/game/player/PlayerView;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventDoorChanged","card","Lforge/game/card/CardView;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventDoorChanged","state","Lforge/card/CardStateName;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventDoorChanged","unlock","Z",value);f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6941(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventDoorChanged;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6942(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventDoorChanged","card","Lforge/game/card/CardView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getName","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventDoorChanged","activatingPlayer","Lforge/game/player/PlayerView;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String(" ")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventDoorChanged","unlock","Z"));f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Int==0?48:43;continue;}
case 43:{f.Push(JValue.R(rt.String("unlocks")));f.Pc=45;continue;}
case 45:{f.Pc=50;continue;}
case 48:{f.Push(JValue.R(rt.String("locks")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String(" ")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",65);}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("Door")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/util/Lang","getPossessedObject","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",71);}
case 71:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",79);}
case 79:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6943(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventDoorChanged:6943:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventDoorChanged;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6944(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventDoorChanged:6944:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventDoorChanged;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6945(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventDoorChanged","activatingPlayer","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6946(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventDoorChanged","card","Lforge/game/card/CardView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6947(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventDoorChanged","state","Lforge/card/CardStateName;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6948(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventDoorChanged","unlock","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

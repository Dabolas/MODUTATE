// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C613{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventPlayerPriority","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("turn","Lforge/game/player/PlayerView;",false,JValue.Default("Lforge/game/player/PlayerView;"),null));
c.Add(new JField("phase","Lforge/game/phase/PhaseType;",false,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("priority","Lforge/game/player/PlayerView;",false,JValue.Default("Lforge/game/player/PlayerView;"),null));
c.Add(new JMethod(7078,"forge/game/event/GameEventPlayerPriority","<init>","(Lforge/game/player/PlayerView;Lforge/game/phase/PhaseType;Lforge/game/player/PlayerView;)V",1,4,2,new JHandler[]{},M7078));
c.Add(new JMethod(7079,"forge/game/event/GameEventPlayerPriority","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M7079));
c.Add(new JMethod(7080,"forge/game/event/GameEventPlayerPriority","toString","()Ljava/lang/String;",1,1,4,new JHandler[]{},M7080));
c.Add(new JMethod(7081,"forge/game/event/GameEventPlayerPriority","hashCode","()I",17,1,1,new JHandler[]{},M7081));
c.Add(new JMethod(7082,"forge/game/event/GameEventPlayerPriority","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M7082));
c.Add(new JMethod(7083,"forge/game/event/GameEventPlayerPriority","turn","()Lforge/game/player/PlayerView;",1,1,1,new JHandler[]{},M7083));
c.Add(new JMethod(7084,"forge/game/event/GameEventPlayerPriority","phase","()Lforge/game/phase/PhaseType;",1,1,1,new JHandler[]{},M7084));
c.Add(new JMethod(7085,"forge/game/event/GameEventPlayerPriority","priority","()Lforge/game/player/PlayerView;",1,1,1,new JHandler[]{},M7085));
}

internal static JStep M7078(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventPlayerPriority","turn","Lforge/game/player/PlayerView;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventPlayerPriority","phase","Lforge/game/phase/PhaseType;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventPlayerPriority","priority","Lforge/game/player/PlayerView;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7079(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventPlayerPriority;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7080(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(2));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Priority -")));f.Pc=8;continue;}
case 8:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerPriority","priority","Lforge/game/player/PlayerView;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/player/PlayerView","toString","()Ljava/lang/String;","invokevirtual",18);}
case 18:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",22);}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7081(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventPlayerPriority:7081:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventPlayerPriority;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7082(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventPlayerPriority:7082:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventPlayerPriority;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7083(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerPriority","turn","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7084(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerPriority","phase","Lforge/game/phase/PhaseType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7085(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerPriority","priority","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

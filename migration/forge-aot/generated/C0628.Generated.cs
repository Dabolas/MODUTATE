// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C628{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventSubgameEnd","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("maingame","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("message","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(7202,"forge/game/event/GameEventSubgameEnd","<init>","(Lforge/game/Game;Ljava/lang/String;)V",1,3,2,new JHandler[]{},M7202));
c.Add(new JMethod(7203,"forge/game/event/GameEventSubgameEnd","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M7203));
c.Add(new JMethod(7204,"forge/game/event/GameEventSubgameEnd","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M7204));
c.Add(new JMethod(7205,"forge/game/event/GameEventSubgameEnd","hashCode","()I",17,1,1,new JHandler[]{},M7205));
c.Add(new JMethod(7206,"forge/game/event/GameEventSubgameEnd","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M7206));
c.Add(new JMethod(7207,"forge/game/event/GameEventSubgameEnd","maingame","()Lforge/game/Game;",1,1,1,new JHandler[]{},M7207));
c.Add(new JMethod(7208,"forge/game/event/GameEventSubgameEnd","message","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7208));
}

internal static JStep M7202(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventSubgameEnd","maingame","Lforge/game/Game;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventSubgameEnd","message","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7203(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventSubgameEnd;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7204(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventSubgameEnd:7204:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventSubgameEnd;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7205(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventSubgameEnd:7205:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventSubgameEnd;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7206(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventSubgameEnd:7206:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventSubgameEnd;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7207(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSubgameEnd","maingame","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7208(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSubgameEnd","message","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

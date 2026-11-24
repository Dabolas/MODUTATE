// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C584{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventCardForetold","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("activatingPlayer","Lforge/game/player/PlayerView;",false,JValue.Default("Lforge/game/player/PlayerView;"),null));
c.Add(new JMethod(6848,"forge/game/event/GameEventCardForetold","<init>","(Lforge/game/player/PlayerView;)V",1,2,2,new JHandler[]{},M6848));
c.Add(new JMethod(6849,"forge/game/event/GameEventCardForetold","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6849));
c.Add(new JMethod(6850,"forge/game/event/GameEventCardForetold","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6850));
c.Add(new JMethod(6851,"forge/game/event/GameEventCardForetold","hashCode","()I",17,1,1,new JHandler[]{},M6851));
c.Add(new JMethod(6852,"forge/game/event/GameEventCardForetold","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6852));
c.Add(new JMethod(6853,"forge/game/event/GameEventCardForetold","activatingPlayer","()Lforge/game/player/PlayerView;",1,1,1,new JHandler[]{},M6853));
}

internal static JStep M6848(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardForetold","activatingPlayer","Lforge/game/player/PlayerView;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6849(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardForetold;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6850(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardForetold","activatingPlayer","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/PlayerView","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return rt.DynamicCall(f,"forge/game/event/GameEventCardForetold:6850:7:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6851(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventCardForetold:6851:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardForetold;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6852(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventCardForetold:6852:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardForetold;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6853(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardForetold","activatingPlayer","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

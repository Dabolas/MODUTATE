// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C586{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventCardPhased","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("card","Lforge/game/card/CardView;",false,JValue.Default("Lforge/game/card/CardView;"),null));
c.Add(new JField("phaseState","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(6865,"forge/game/event/GameEventCardPhased","<init>","(Lforge/game/card/CardView;Z)V",1,3,2,new JHandler[]{},M6865));
c.Add(new JMethod(6866,"forge/game/event/GameEventCardPhased","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6866));
c.Add(new JMethod(6867,"forge/game/event/GameEventCardPhased","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6867));
c.Add(new JMethod(6868,"forge/game/event/GameEventCardPhased","hashCode","()I",17,1,1,new JHandler[]{},M6868));
c.Add(new JMethod(6869,"forge/game/event/GameEventCardPhased","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6869));
c.Add(new JMethod(6870,"forge/game/event/GameEventCardPhased","card","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M6870));
c.Add(new JMethod(6871,"forge/game/event/GameEventCardPhased","phaseState","()Z",1,1,1,new JHandler[]{},M6871));
}

internal static JStep M6865(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardPhased","card","Lforge/game/card/CardView;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardPhased","phaseState","Z",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6866(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardPhased;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6867(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardPhased","card","Lforge/game/card/CardView;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?17:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardPhased","card","Lforge/game/card/CardView;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardView","toString","()Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Pc=26;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardPhased","phaseState","Z"));f.Pc=21;continue;}
case 21:{return rt.DynamicCall(f,"forge/game/event/GameEventCardPhased:6867:21:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Z)Ljava/lang/String;",26);}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6868(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventCardPhased:6868:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardPhased;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6869(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventCardPhased:6869:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardPhased;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6870(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardPhased","card","Lforge/game/card/CardView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6871(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardPhased","phaseState","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

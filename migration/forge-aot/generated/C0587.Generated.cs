// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C587{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventCardPlotted","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("card","Lforge/game/card/CardView;",false,JValue.Default("Lforge/game/card/CardView;"),null));
c.Add(new JField("activatingPlayer","Lforge/game/player/PlayerView;",false,JValue.Default("Lforge/game/player/PlayerView;"),null));
c.Add(new JMethod(6872,"forge/game/event/GameEventCardPlotted","<init>","(Lforge/game/card/Card;Lforge/game/player/Player;)V",1,3,3,new JHandler[]{},M6872));
c.Add(new JMethod(6873,"forge/game/event/GameEventCardPlotted","<init>","(Lforge/game/card/CardView;Lforge/game/player/PlayerView;)V",1,3,2,new JHandler[]{},M6873));
c.Add(new JMethod(6874,"forge/game/event/GameEventCardPlotted","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6874));
c.Add(new JMethod(6875,"forge/game/event/GameEventCardPlotted","toString","()Ljava/lang/String;",1,1,2,new JHandler[]{},M6875));
c.Add(new JMethod(6876,"forge/game/event/GameEventCardPlotted","hashCode","()I",17,1,1,new JHandler[]{},M6876));
c.Add(new JMethod(6877,"forge/game/event/GameEventCardPlotted","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6877));
c.Add(new JMethod(6878,"forge/game/event/GameEventCardPlotted","card","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M6878));
c.Add(new JMethod(6879,"forge/game/event/GameEventCardPlotted","activatingPlayer","()Lforge/game/player/PlayerView;",1,1,1,new JHandler[]{},M6879));
}

internal static JStep M6872(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",9);}
case 9:{return rt.Call(f,"forge/game/event/GameEventCardPlotted","<init>","(Lforge/game/card/CardView;Lforge/game/player/PlayerView;)V","invokespecial",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6873(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardPlotted","card","Lforge/game/card/CardView;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardPlotted","activatingPlayer","Lforge/game/player/PlayerView;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6874(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardPlotted;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6875(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardPlotted","activatingPlayer","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/PlayerView","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardPlotted","card","Lforge/game/card/CardView;"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference==null?24:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardPlotted","card","Lforge/game/card/CardView;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardView","toString","()Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Pc=26;continue;}
case 24:{f.Push(JValue.R(rt.String("(unknown)")));f.Pc=26;continue;}
case 26:{return rt.DynamicCall(f,"forge/game/event/GameEventCardPlotted:6875:26:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6876(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventCardPlotted:6876:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardPlotted;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6877(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventCardPlotted:6877:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardPlotted;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6878(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardPlotted","card","Lforge/game/card/CardView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6879(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardPlotted","activatingPlayer","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

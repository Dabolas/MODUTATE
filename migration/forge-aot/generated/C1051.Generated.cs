// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1051{
internal static JClass Build(){var c=new JClass("forge/game/zone/ZoneView","java/lang/Record",new string[]{"java/io/Serializable"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("player","Lforge/game/player/PlayerView;",false,JValue.Default("Lforge/game/player/PlayerView;"),null));
c.Add(new JField("zoneType","Lforge/game/zone/ZoneType;",false,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JMethod(11165,"forge/game/zone/ZoneView","<init>","(Lforge/game/player/PlayerView;Lforge/game/zone/ZoneType;)V",1,3,2,new JHandler[]{},M11165));
c.Add(new JMethod(11166,"forge/game/zone/ZoneView","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M11166));
c.Add(new JMethod(11167,"forge/game/zone/ZoneView","hashCode","()I",17,1,1,new JHandler[]{},M11167));
c.Add(new JMethod(11168,"forge/game/zone/ZoneView","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M11168));
c.Add(new JMethod(11169,"forge/game/zone/ZoneView","player","()Lforge/game/player/PlayerView;",1,1,1,new JHandler[]{},M11169));
c.Add(new JMethod(11170,"forge/game/zone/ZoneView","zoneType","()Lforge/game/zone/ZoneType;",1,1,1,new JHandler[]{},M11170));
}

internal static JStep M11165(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/ZoneView","player","Lforge/game/player/PlayerView;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/ZoneView","zoneType","Lforge/game/zone/ZoneType;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11166(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/zone/ZoneView:11166:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/zone/ZoneView;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11167(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/zone/ZoneView:11167:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/zone/ZoneView;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11168(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/zone/ZoneView:11168:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/zone/ZoneView;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11169(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/ZoneView","player","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11170(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/ZoneView","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

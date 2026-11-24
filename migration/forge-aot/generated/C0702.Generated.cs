// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C702{
internal static JClass Build(){var c=new JClass("forge/game/player/DelayedReveal","java/lang/Object",new string[]{"java/io/Serializable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(5516713460440436615L),null));
c.Add(new JField("cards","Lforge/trackable/TrackableCollection;",false,JValue.Default("Lforge/trackable/TrackableCollection;"),null));
c.Add(new JField("zone","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("owner","Lforge/game/player/PlayerView;",false,JValue.Default("Lforge/game/player/PlayerView;"),null));
c.Add(new JField("messagePrefix","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(7964,"forge/game/player/DelayedReveal","<init>","(Ljava/lang/Iterable;Lforge/game/zone/ZoneType;Lforge/game/player/PlayerView;)V",1,4,5,new JHandler[]{},M7964));
c.Add(new JMethod(7965,"forge/game/player/DelayedReveal","<init>","(Ljava/lang/Iterable;Lforge/game/zone/ZoneType;Lforge/game/player/PlayerView;Ljava/lang/String;)V",1,5,5,new JHandler[]{},M7965));
c.Add(new JMethod(7966,"forge/game/player/DelayedReveal","<init>","(Ljava/lang/Iterable;Ljava/util/Set;Lforge/game/player/PlayerView;Ljava/lang/String;)V",1,5,2,new JHandler[]{},M7966));
c.Add(new JMethod(7967,"forge/game/player/DelayedReveal","getCards","()Lforge/trackable/TrackableCollection;",1,1,1,new JHandler[]{},M7967));
c.Add(new JMethod(7968,"forge/game/player/DelayedReveal","getZone","()Ljava/util/Set;",1,1,1,new JHandler[]{},M7968));
c.Add(new JMethod(7969,"forge/game/player/DelayedReveal","getOwner","()Lforge/game/player/PlayerView;",1,1,1,new JHandler[]{},M7969));
c.Add(new JMethod(7970,"forge/game/player/DelayedReveal","getMessagePrefix","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7970));
c.Add(new JMethod(7971,"forge/game/player/DelayedReveal","remove","(Lforge/game/card/CardView;)V",1,2,2,new JHandler[]{},M7971));
}

internal static JStep M7964(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/DelayedReveal","<init>","(Ljava/lang/Iterable;Lforge/game/zone/ZoneType;Lforge/game/player/PlayerView;Ljava/lang/String;)V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7965(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Set","of","(Ljava/lang/Object;)Ljava/util/Set;","invokestatic",6);}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/DelayedReveal","<init>","(Ljava/lang/Iterable;Ljava/util/Set;Lforge/game/player/PlayerView;Ljava/lang/String;)V","invokespecial",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7966(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",9);}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/DelayedReveal","cards","Lforge/trackable/TrackableCollection;",value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/DelayedReveal","zone","Ljava/util/Set;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/DelayedReveal","owner","Lforge/game/player/PlayerView;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/DelayedReveal","messagePrefix","Ljava/lang/String;",value);f.Pc=28;continue;}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7967(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/DelayedReveal","cards","Lforge/trackable/TrackableCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7968(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/DelayedReveal","zone","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7969(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/DelayedReveal","owner","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7970(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/DelayedReveal","messagePrefix","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7971(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/DelayedReveal","cards","Lforge/trackable/TrackableCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/trackable/TrackableCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

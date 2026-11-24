// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C616{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventPlayerStatsChanged","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("players","Lforge/util/collect/FCollection;",false,JValue.Default("Lforge/util/collect/FCollection;"),null));
c.Add(new JMethod(7104,"forge/game/event/GameEventPlayerStatsChanged","<init>","(Ljava/util/Collection;)V",1,2,2,new JHandler[]{},M7104));
c.Add(new JMethod(7105,"forge/game/event/GameEventPlayerStatsChanged","<init>","(Lforge/game/player/Player;)V",1,2,5,new JHandler[]{},M7105));
c.Add(new JMethod(7106,"forge/game/event/GameEventPlayerStatsChanged","<init>","(Lforge/util/collect/FCollection;)V",1,2,2,new JHandler[]{},M7106));
c.Add(new JMethod(7107,"forge/game/event/GameEventPlayerStatsChanged","isRedrawHint","()Z",1,1,1,new JHandler[]{},M7107));
c.Add(new JMethod(7108,"forge/game/event/GameEventPlayerStatsChanged","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M7108));
c.Add(new JMethod(7109,"forge/game/event/GameEventPlayerStatsChanged","toString","()Ljava/lang/String;",1,1,4,new JHandler[]{},M7109));
c.Add(new JMethod(7110,"forge/game/event/GameEventPlayerStatsChanged","hashCode","()I",17,1,1,new JHandler[]{},M7110));
c.Add(new JMethod(7111,"forge/game/event/GameEventPlayerStatsChanged","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M7111));
c.Add(new JMethod(7112,"forge/game/event/GameEventPlayerStatsChanged","players","()Lforge/util/collect/FCollection;",1,1,1,new JHandler[]{},M7112));
}

internal static JStep M7104(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/PlayerView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/event/GameEventPlayerStatsChanged","<init>","(Lforge/util/collect/FCollection;)V","invokespecial",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7105(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/player/Player;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",12);}
case 12:{return rt.Call(f,"forge/game/event/GameEventPlayerStatsChanged","<init>","(Ljava/util/Collection;)V","invokespecial",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7106(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventPlayerStatsChanged","players","Lforge/util/collect/FCollection;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7107(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7108(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventPlayerStatsChanged;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7109(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerStatsChanged","players","Lforge/util/collect/FCollection;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?18:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerStatsChanged","players","Lforge/util/collect/FCollection;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/collect/FCollection","isEmpty","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?21:18;continue;}
case 18:{f.Push(JValue.R(rt.String("Player state changes: (empty list)")));f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(JValue.I(2));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Player state changes:")));f.Pc=29;continue;}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerStatsChanged","players","Lforge/util/collect/FCollection;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",39);}
case 39:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",43);}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7110(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventPlayerStatsChanged:7110:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventPlayerStatsChanged;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7111(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventPlayerStatsChanged:7111:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventPlayerStatsChanged;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7112(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventPlayerStatsChanged","players","Lforge/util/collect/FCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

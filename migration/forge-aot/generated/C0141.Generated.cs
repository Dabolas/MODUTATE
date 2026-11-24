// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C141{
internal static JClass Build(){var c=new JClass("forge/game/GameEntityView","forge/trackable/TrackableObject",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-5129089945124455670L),null));
c.Add(new JMethod(2244,"forge/game/GameEntityView","get","(Lforge/game/GameEntity;)Lforge/game/GameEntityView;",9,1,1,new JHandler[]{},M2244));
c.Add(new JMethod(2245,"forge/game/GameEntityView","getEntityCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;",9,4,2,new JHandler[]{},M2245));
c.Add(new JMethod(2246,"forge/game/GameEntityView","getMap","(Ljava/lang/Iterable;)Lforge/game/GameEntityViewMap;",9,2,2,new JHandler[]{},M2246));
c.Add(new JMethod(2247,"forge/game/GameEntityView","<init>","(ILforge/trackable/Tracker;)V",4,3,3,new JHandler[]{},M2247));
c.Add(new JMethod(2248,"forge/game/GameEntityView","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2248));
c.Add(new JMethod(2249,"forge/game/GameEntityView","getName","()Ljava/lang/String;",1,1,2,new JHandler[]{},M2249));
c.Add(new JMethod(2250,"forge/game/GameEntityView","updateName","(Lforge/game/GameEntity;)V",4,2,3,new JHandler[]{},M2250));
c.Add(new JMethod(2251,"forge/game/GameEntityView","getPreventNextDamage","()I",1,1,2,new JHandler[]{},M2251));
c.Add(new JMethod(2252,"forge/game/GameEntityView","updatePreventNextDamage","(Lforge/game/GameEntity;)V",1,2,3,new JHandler[]{},M2252));
c.Add(new JMethod(2253,"forge/game/GameEntityView","getAttachedCards","()Ljava/util/List;",1,1,2,new JHandler[]{},M2253));
c.Add(new JMethod(2254,"forge/game/GameEntityView","hasCardAttachments","()Z",1,1,1,new JHandler[]{},M2254));
c.Add(new JMethod(2255,"forge/game/GameEntityView","getAllAttachedCards","()Ljava/util/List;",1,1,2,new JHandler[]{},M2255));
c.Add(new JMethod(2256,"forge/game/GameEntityView","hasAnyCardAttachments","()Z",1,1,1,new JHandler[]{},M2256));
c.Add(new JMethod(2257,"forge/game/GameEntityView","getCounters","()Lcom/google/common/collect/Multiset;",1,1,2,new JHandler[]{},M2257));
c.Add(new JMethod(2258,"forge/game/GameEntityView","getCounters","(Lforge/game/card/CounterType;)I",1,3,2,new JHandler[]{},M2258));
c.Add(new JMethod(2259,"forge/game/GameEntityView","hasSameCounters","(Lforge/game/GameEntityView;)Z",1,3,2,new JHandler[]{},M2259));
c.Add(new JMethod(2260,"forge/game/GameEntityView","updateCounters","(Lforge/game/GameEntity;)V",1,2,3,new JHandler[]{},M2260));
c.Add(new JMethod(2261,"forge/game/GameEntityView","lambda$getAttachedCards$0","(Lforge/game/card/CardView;)Z",4106,1,1,new JHandler[]{},M2261));
}

internal static JStep M2244(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Pc=12;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/GameEntity","getView","()Lforge/game/GameEntityView;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2245(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableCollection")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/trackable/TrackableCollection","<init>","()V","invokespecial",13);}
case 13:{f.Locals[1]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?52:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/GameEntity","getView","()Lforge/game/GameEntityView;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/trackable/TrackableCollection","add","(Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Pc=21;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2246(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityViewMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityViewMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameEntityViewMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/GameEntityViewMap","putAll","(Ljava/lang/Iterable;)V","invokevirtual",13);}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2247(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/trackable/TrackableObject","<init>","(ILforge/trackable/Tracker;)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2248(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntityView","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2249(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameEntityView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2250(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameEntity","getName","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/GameEntityView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2251(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PreventNextDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PreventNextDamage","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameEntityView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2252(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PreventNextDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PreventNextDamage","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameEntity","getPreventNextDamageTotalShields","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/GameEntityView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2253(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntityView","getAllAttachedCards","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",9);}
case 9:{return rt.DynamicCall(f,"forge/game/GameEntityView:2253:9:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",14);}
case 14:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",19);}
case 19:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",22);}
case 22:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2254(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntityView","getAttachedCards","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2255(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttachedCards","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameEntityView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2256(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntityView","getAllAttachedCards","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2257(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Counters","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Counters","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameEntityView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2258(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntityView","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?17:9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"com/google/common/collect/Multiset","count","(Ljava/lang/Object;)I","invokeinterface",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2259(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/GameEntityView","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?22:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/GameEntityView","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Reference!=null?20:16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Pc=21;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/GameEntityView","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",27);}
case 27:{return rt.Call(f,"com/google/common/collect/Multiset","equals","(Ljava/lang/Object;)Z","invokeinterface",32);}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2260(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Counters","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Counters","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameEntity","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/GameEntityView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Counters","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Counters","Lforge/trackable/TrackableProperty;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/GameEntityView","flagAsChanged","(Lforge/trackable/TrackableProperty;)V","invokevirtual",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2261(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView","isPhasedOut","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

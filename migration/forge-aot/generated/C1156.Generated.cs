// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1156{
internal static JClass Build(){var c=new JClass("forge/util/StreamUtil","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(12019,"forge/util/StreamUtil","<init>","()V",2,1,1,new JHandler[]{},M12019));
c.Add(new JMethod(12020,"forge/util/StreamUtil","stream","(Ljava/lang/Iterable;)Ljava/util/stream/Stream;",9,1,2,new JHandler[]{},M12020));
c.Add(new JMethod(12021,"forge/util/StreamUtil","stream","([Ljava/lang/Object;)Ljava/util/stream/Stream;",9,1,1,new JHandler[]{},M12021));
c.Add(new JMethod(12022,"forge/util/StreamUtil","random","()Ljava/util/stream/Collector;",9,0,2,new JHandler[]{},M12022));
c.Add(new JMethod(12023,"forge/util/StreamUtil","random","(I)Ljava/util/stream/Collector;",9,1,3,new JHandler[]{},M12023));
}

internal static JStep M12019(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12020(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","spliterator","()Ljava/util/Spliterator;","invokeinterface",6);}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/stream/StreamSupport","stream","(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12021(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Arrays","stream","([Ljava/lang/Object;)Ljava/util/stream/Stream;","invokestatic",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12022(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/StreamUtil$RandomCollectorSingle"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/StreamUtil$RandomCollectorSingle")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/StreamUtil$RandomCollectorSingle","<init>","()V","invokespecial",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12023(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/StreamUtil$RandomCollectorMulti"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/StreamUtil$RandomCollectorMulti")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/StreamUtil$RandomCollectorMulti","<init>","(I)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

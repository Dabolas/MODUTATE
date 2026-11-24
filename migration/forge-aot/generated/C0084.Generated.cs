// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C84{
internal static JClass Build(){var c=new JClass("forge/deck/CommanderOptions$Option","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("commanders","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("kind","Lforge/deck/CommanderOptions$Kind;",false,JValue.Default("Lforge/deck/CommanderOptions$Kind;"),null));
c.Add(new JMethod(1321,"forge/deck/CommanderOptions$Option","<init>","(Ljava/util/List;Lforge/deck/CommanderOptions$Kind;)V",1,3,4,new JHandler[]{},M1321));
c.Add(new JMethod(1322,"forge/deck/CommanderOptions$Option","getCommanders","()Ljava/util/List;",1,1,1,new JHandler[]{},M1322));
c.Add(new JMethod(1323,"forge/deck/CommanderOptions$Option","getKind","()Lforge/deck/CommanderOptions$Kind;",1,1,1,new JHandler[]{},M1323));
c.Add(new JMethod(1324,"forge/deck/CommanderOptions$Option","getName","()Ljava/lang/String;",1,1,2,new JHandler[]{},M1324));
c.Add(new JMethod(1325,"forge/deck/CommanderOptions$Option","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1325));
}

internal static JStep M1321(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",13);}
case 13:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/CommanderOptions$Option","commanders","Ljava/util/List;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/CommanderOptions$Option","kind","Lforge/deck/CommanderOptions$Kind;",value);f.Pc=24;continue;}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1322(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/CommanderOptions$Option","commanders","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1323(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/CommanderOptions$Option","kind","Lforge/deck/CommanderOptions$Kind;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1324(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/CommanderOptions$Option","commanders","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",9);}
case 9:{return rt.DynamicCall(f,"forge/deck/CommanderOptions$Option:1324:9:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",14);}
case 14:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",19);}
case 19:{f.Push(JValue.R(rt.String(" + ")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/stream/Collectors","joining","(Ljava/lang/CharSequence;)Ljava/util/stream/Collector;","invokestatic",24);}
case 24:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1325(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/CommanderOptions$Option","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

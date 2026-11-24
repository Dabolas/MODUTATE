// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1133{
internal static JClass Build(){var c=new JClass("forge/util/IterableUtil","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11847,"forge/util/IterableUtil","<init>","()V",1,1,1,new JHandler[]{},M11847));
c.Add(new JMethod(11848,"forge/util/IterableUtil","and","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;",9,1,2,new JHandler[]{},M11848));
c.Add(new JMethod(11849,"forge/util/IterableUtil","or","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;",9,1,2,new JHandler[]{},M11849));
c.Add(new JMethod(11850,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;",9,2,2,new JHandler[]{},M11850));
c.Add(new JMethod(11851,"forge/util/IterableUtil","filter","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;",9,2,2,new JHandler[]{},M11851));
c.Add(new JMethod(11852,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/lang/Iterable;",9,2,2,new JHandler[]{},M11852));
c.Add(new JMethod(11853,"forge/util/IterableUtil","any","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Z",9,2,2,new JHandler[]{},M11853));
c.Add(new JMethod(11854,"forge/util/IterableUtil","all","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Z",9,2,2,new JHandler[]{},M11854));
c.Add(new JMethod(11855,"forge/util/IterableUtil","find","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Object;",9,2,2,new JHandler[]{},M11855));
c.Add(new JMethod(11856,"forge/util/IterableUtil","find","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/lang/Object;)Ljava/lang/Object;",9,3,2,new JHandler[]{},M11856));
c.Add(new JMethod(11857,"forge/util/IterableUtil","tryFind","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/util/Optional;",9,2,2,new JHandler[]{},M11857));
c.Add(new JMethod(11858,"forge/util/IterableUtil","indexOf","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I",9,5,2,new JHandler[]{},M11858));
c.Add(new JMethod(11859,"forge/util/IterableUtil","transform","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/lang/Iterable;",9,2,2,new JHandler[]{},M11859));
c.Add(new JMethod(11860,"forge/util/IterableUtil","lambda$transform$7","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/util/Iterator;",4106,2,2,new JHandler[]{},M11860));
c.Add(new JMethod(11861,"forge/util/IterableUtil","lambda$filter$6","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/util/Iterator;",4106,2,3,new JHandler[]{},M11861));
c.Add(new JMethod(11862,"forge/util/IterableUtil","lambda$filter$5","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/util/Iterator;",4106,2,2,new JHandler[]{},M11862));
c.Add(new JMethod(11863,"forge/util/IterableUtil","lambda$filter$4","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/util/Iterator;",4106,2,2,new JHandler[]{},M11863));
c.Add(new JMethod(11864,"forge/util/IterableUtil","lambda$or$3","(Ljava/lang/Iterable;Ljava/lang/Object;)Z",4106,2,2,new JHandler[]{},M11864));
c.Add(new JMethod(11865,"forge/util/IterableUtil","lambda$or$2","(Ljava/lang/Object;Ljava/util/function/Predicate;)Z",4106,2,2,new JHandler[]{},M11865));
c.Add(new JMethod(11866,"forge/util/IterableUtil","lambda$and$1","(Ljava/lang/Iterable;Ljava/lang/Object;)Z",4106,2,2,new JHandler[]{},M11866));
c.Add(new JMethod(11867,"forge/util/IterableUtil","lambda$and$0","(Ljava/lang/Object;Ljava/util/function/Predicate;)Z",4106,2,2,new JHandler[]{},M11867));
}

internal static JStep M11847(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11848(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/List")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?44:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",16);}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?44:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/function/Predicate"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{return rt.DynamicCall(f,"forge/util/IterableUtil:11848:38:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;",43);}
case 43:{return JStep.Return(f.Pop());}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.DynamicCall(f,"forge/util/IterableUtil:11848:45:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;",50);}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11849(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/List")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?44:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",16);}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?44:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/function/Predicate"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{return rt.DynamicCall(f,"forge/util/IterableUtil:11849:38:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;",43);}
case 43:{return JStep.Return(f.Pop());}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.DynamicCall(f,"forge/util/IterableUtil:11849:45:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;",50);}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11850(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/util/IterableUtil:11850:2:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11851(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/util/IterableUtil:11851:2:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11852(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/util/IterableUtil:11852:2:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/lang/Iterable;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11853(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","spliterator","()Ljava/util/Spliterator;","invokeinterface",6);}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/stream/StreamSupport","stream","(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;","invokestatic",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11854(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","spliterator","()Ljava/util/Spliterator;","invokeinterface",6);}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/stream/StreamSupport","stream","(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;","invokestatic",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/stream/Stream","allMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11855(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","spliterator","()Ljava/util/Spliterator;","invokeinterface",6);}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/stream/StreamSupport","stream","(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;","invokestatic",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",16);}
case 16:{return rt.Call(f,"java/util/stream/Stream","findFirst","()Ljava/util/Optional;","invokeinterface",21);}
case 21:{return rt.Call(f,"java/util/Optional","get","()Ljava/lang/Object;","invokevirtual",24);}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11856(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","spliterator","()Ljava/util/Spliterator;","invokeinterface",6);}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/stream/StreamSupport","stream","(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;","invokestatic",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",16);}
case 16:{return rt.Call(f,"java/util/stream/Stream","findFirst","()Ljava/util/Optional;","invokeinterface",21);}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Optional","orElse","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",25);}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11857(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","spliterator","()Ljava/util/Spliterator;","invokeinterface",6);}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/stream/StreamSupport","stream","(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;","invokestatic",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",16);}
case 16:{return rt.Call(f,"java/util/stream/Stream","findFirst","()Ljava/util/Optional;","invokeinterface",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11858(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?45:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",34);}
case 34:{f.Pc=f.Pop().Int==0?39:37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 39:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=42;continue;}
case 42:{f.Pc=9;continue;}
case 45:{f.Push(JValue.I(-1));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11859(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/util/IterableUtil:11859:2:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/lang/Iterable;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11860(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","spliterator","()Ljava/util/Spliterator;","invokeinterface",6);}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/stream/StreamSupport","stream","(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;","invokestatic",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",16);}
case 16:{return rt.Call(f,"java/util/stream/Stream","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11861(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","spliterator","()Ljava/util/Spliterator;","invokeinterface",6);}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/stream/StreamSupport","stream","(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;","invokestatic",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{return rt.DynamicCall(f,"forge/util/IterableUtil:11861:16:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Class;)Ljava/util/function/Predicate;",21);}
case 21:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",26);}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{return rt.DynamicCall(f,"forge/util/IterableUtil:11861:32:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Class;)Ljava/util/function/Function;",37);}
case 37:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",42);}
case 42:{return rt.Call(f,"java/util/stream/Stream","iterator","()Ljava/util/Iterator;","invokeinterface",47);}
case 47:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11862(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",12);}
case 12:{return rt.Call(f,"java/util/stream/Stream","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11863(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Iterable","spliterator","()Ljava/util/Spliterator;","invokeinterface",6);}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/stream/StreamSupport","stream","(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;","invokestatic",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",16);}
case 16:{return rt.Call(f,"java/util/stream/Stream","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11864(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/util/IterableUtil:11864:2:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Object;)Ljava/util/function/Predicate;",7);}
case 7:{return rt.Call(f,"forge/util/IterableUtil","any","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Z","invokestatic",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11865(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11866(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/util/IterableUtil:11866:2:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Object;)Ljava/util/function/Predicate;",7);}
case 7:{return rt.Call(f,"forge/util/IterableUtil","all","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Z","invokestatic",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11867(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

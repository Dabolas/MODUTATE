// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1157{
internal static JClass Build(){var c=new JClass("forge/util/StreamUtil$RandomCollector","java/lang/Object",new string[]{"java/util/stream/Collector"},1056);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("size","I",false,JValue.Default("I"),null));
c.Add(new JField("CHARACTERISTICS","Ljava/util/EnumSet;",false,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JMethod(12024,"forge/util/StreamUtil$RandomCollector","<init>","(I)V",0,2,2,new JHandler[]{},M12024));
c.Add(new JMethod(12025,"forge/util/StreamUtil$RandomCollector","supplier","()Ljava/util/function/Supplier;",1,1,1,new JHandler[]{},M12025));
c.Add(new JMethod(12026,"forge/util/StreamUtil$RandomCollector","accumulator","()Ljava/util/function/BiConsumer;",1,1,1,new JHandler[]{},M12026));
c.Add(new JMethod(12027,"forge/util/StreamUtil$RandomCollector","combiner","()Ljava/util/function/BinaryOperator;",1,1,1,new JHandler[]{},M12027));
c.Add(new JMethod(12028,"forge/util/StreamUtil$RandomCollector","characteristics","()Ljava/util/Set;",1,1,1,new JHandler[]{},M12028));
c.Add(new JMethod(12029,"forge/util/StreamUtil$RandomCollector","lambda$combiner$1","(Lforge/util/StreamUtil$RandomReservoir;Lforge/util/StreamUtil$RandomReservoir;)Lforge/util/StreamUtil$RandomReservoir;",4106,2,3,new JHandler[]{},M12029));
c.Add(new JMethod(12030,"forge/util/StreamUtil$RandomCollector","lambda$supplier$0","()Lforge/util/StreamUtil$RandomReservoir;",4098,1,3,new JHandler[]{},M12030));
}

internal static JStep M12024(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"java/util/stream/Collector$Characteristics","UNORDERED","Ljava/util/stream/Collector$Characteristics;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/stream/Collector$Characteristics","UNORDERED","Ljava/util/stream/Collector$Characteristics;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",11);}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/StreamUtil$RandomCollector","CHARACTERISTICS","Ljava/util/EnumSet;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/StreamUtil$RandomCollector","size","I",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12025(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/util/StreamUtil$RandomCollector:12025:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/util/StreamUtil$RandomCollector;)Ljava/util/function/Supplier;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12026(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/util/StreamUtil$RandomCollector:12026:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiConsumer;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12027(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/util/StreamUtil$RandomCollector:12027:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BinaryOperator;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12028(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/StreamUtil$RandomCollector","CHARACTERISTICS","Ljava/util/EnumSet;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12029(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/UnsupportedOperationException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/UnsupportedOperationException")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Parallel streams not supported.")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/UnsupportedOperationException","<init>","(Ljava/lang/String;)V","invokespecial",9);}
case 9:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12030(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/StreamUtil$RandomReservoir"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/StreamUtil$RandomReservoir")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/StreamUtil$RandomCollector","size","I"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/StreamUtil$RandomReservoir","<init>","(I)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

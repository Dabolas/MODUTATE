// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1132{
internal static JClass Build(){var c=new JClass("forge/util/ItemPool$1","java/lang/Object",new string[]{"java/util/stream/Collector"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("val$cls","Ljava/lang/Class;",false,JValue.Default("Ljava/lang/Class;"),null));
c.Add(new JMethod(11838,"forge/util/ItemPool$1","<init>","(Ljava/lang/Class;)V",0,2,2,new JHandler[]{},M11838));
c.Add(new JMethod(11839,"forge/util/ItemPool$1","supplier","()Ljava/util/function/Supplier;",1,1,1,new JHandler[]{},M11839));
c.Add(new JMethod(11840,"forge/util/ItemPool$1","accumulator","()Ljava/util/function/BiConsumer;",1,1,1,new JHandler[]{},M11840));
c.Add(new JMethod(11841,"forge/util/ItemPool$1","combiner","()Ljava/util/function/BinaryOperator;",1,1,1,new JHandler[]{},M11841));
c.Add(new JMethod(11842,"forge/util/ItemPool$1","finisher","()Ljava/util/function/Function;",1,1,1,new JHandler[]{},M11842));
c.Add(new JMethod(11843,"forge/util/ItemPool$1","characteristics","()Ljava/util/Set;",1,1,1,new JHandler[]{},M11843));
c.Add(new JMethod(11844,"forge/util/ItemPool$1","lambda$combiner$2","(Lforge/util/ItemPool;Lforge/util/ItemPool;)Lforge/util/ItemPool;",4106,2,2,new JHandler[]{},M11844));
c.Add(new JMethod(11845,"forge/util/ItemPool$1","lambda$accumulator$1","(Ljava/lang/Class;Lforge/util/ItemPool;Lforge/item/InventoryItem;)V",4106,3,3,new JHandler[]{},M11845));
c.Add(new JMethod(11846,"forge/util/ItemPool$1","lambda$supplier$0","(Ljava/lang/Class;)Lforge/util/ItemPool;",4106,1,3,new JHandler[]{},M11846));
}

internal static JStep M11838(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/ItemPool$1","val$cls","Ljava/lang/Class;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11839(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/ItemPool$1","val$cls","Ljava/lang/Class;"));f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/util/ItemPool$1:11839:4:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Class;)Ljava/util/function/Supplier;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11840(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/ItemPool$1","val$cls","Ljava/lang/Class;"));f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/util/ItemPool$1:11840:4:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/Class;)Ljava/util/function/BiConsumer;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11841(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/util/ItemPool$1:11841:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BinaryOperator;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11842(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"java/util/function/Function","identity","()Ljava/util/function/Function;","invokestatic",3);}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11843(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"java/util/stream/Collector$Characteristics","IDENTITY_FINISH","Ljava/util/stream/Collector$Characteristics;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/stream/Collector$Characteristics","IDENTITY_FINISH","Ljava/util/stream/Collector$Characteristics;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11844(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/ItemPool","addAll","(Ljava/lang/Iterable;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11845(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/Class","isInstance","(Ljava/lang/Object;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?21:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Class","cast","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",14);}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/InventoryItem"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/ItemPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",21);}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11846(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/ItemPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/ItemPool")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/ItemPool","<init>","(Ljava/lang/Class;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

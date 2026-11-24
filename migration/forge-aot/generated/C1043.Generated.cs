// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1043{
internal static JClass Build(){var c=new JClass("forge/game/zone/CostPaymentStack","java/lang/Object",new string[]{"java/lang/Iterable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("stack","Ljava/util/Stack;",false,JValue.Default("Ljava/util/Stack;"),null));
c.Add(new JMethod(11016,"forge/game/zone/CostPaymentStack","<init>","()V",1,1,3,new JHandler[]{},M11016));
c.Add(new JMethod(11017,"forge/game/zone/CostPaymentStack","push","(Lforge/game/cost/CostPart;Lforge/game/cost/CostPayment;)Lforge/game/zone/CostPaymentStack$Entry;",1,3,5,new JHandler[]{},M11017));
c.Add(new JMethod(11018,"forge/game/zone/CostPaymentStack","pop","()Lforge/game/zone/CostPaymentStack$Entry;",1,1,1,new JHandler[]{},M11018));
c.Add(new JMethod(11019,"forge/game/zone/CostPaymentStack","peek","()Lforge/game/zone/CostPaymentStack$Entry;",1,1,1,new JHandler[]{},M11019));
c.Add(new JMethod(11020,"forge/game/zone/CostPaymentStack","clear","()V",1,1,1,new JHandler[]{},M11020));
c.Add(new JMethod(11021,"forge/game/zone/CostPaymentStack","iterator","()Ljava/util/Iterator;",1,1,1,new JHandler[]{},M11021));
c.Add(new JMethod(11022,"forge/game/zone/CostPaymentStack","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11022));
}

internal static JStep M11016(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/Stack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Stack")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Stack","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/CostPaymentStack","stack","Ljava/util/Stack;",value);f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11017(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/CostPaymentStack","stack","Ljava/util/Stack;"));f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"forge/game/zone/CostPaymentStack$Entry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/CostPaymentStack$Entry")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/zone/CostPaymentStack$Entry","<init>","(Lforge/game/cost/CostPart;Lforge/game/cost/CostPayment;)V","invokespecial",13);}
case 13:{return rt.Call(f,"java/util/Stack","push","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/CostPaymentStack$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11018(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/CostPaymentStack","stack","Ljava/util/Stack;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Stack","pop","()Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/CostPaymentStack$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11019(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/CostPaymentStack","stack","Ljava/util/Stack;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Stack","empty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/CostPaymentStack","stack","Ljava/util/Stack;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Stack","peek","()Ljava/lang/Object;","invokevirtual",19);}
case 19:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/CostPaymentStack$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=22;continue;}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11020(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/CostPaymentStack","stack","Ljava/util/Stack;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Stack","clear","()V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11021(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/CostPaymentStack","stack","Ljava/util/Stack;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Stack","iterator","()Ljava/util/Iterator;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11022(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/CostPaymentStack","stack","Ljava/util/Stack;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Stack","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

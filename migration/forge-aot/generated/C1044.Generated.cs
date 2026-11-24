// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1044{
internal static JClass Build(){var c=new JClass("forge/game/zone/CostPaymentStack$Entry","java/lang/Record",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cost","Lforge/game/cost/CostPart;",false,JValue.Default("Lforge/game/cost/CostPart;"),null));
c.Add(new JField("payment","Lforge/game/cost/CostPayment;",false,JValue.Default("Lforge/game/cost/CostPayment;"),null));
c.Add(new JMethod(11023,"forge/game/zone/CostPaymentStack$Entry","<init>","(Lforge/game/cost/CostPart;Lforge/game/cost/CostPayment;)V",1,3,2,new JHandler[]{},M11023));
c.Add(new JMethod(11024,"forge/game/zone/CostPaymentStack$Entry","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M11024));
c.Add(new JMethod(11025,"forge/game/zone/CostPaymentStack$Entry","hashCode","()I",17,1,1,new JHandler[]{},M11025));
c.Add(new JMethod(11026,"forge/game/zone/CostPaymentStack$Entry","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M11026));
c.Add(new JMethod(11027,"forge/game/zone/CostPaymentStack$Entry","cost","()Lforge/game/cost/CostPart;",1,1,1,new JHandler[]{},M11027));
c.Add(new JMethod(11028,"forge/game/zone/CostPaymentStack$Entry","payment","()Lforge/game/cost/CostPayment;",1,1,1,new JHandler[]{},M11028));
}

internal static JStep M11023(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/CostPaymentStack$Entry","cost","Lforge/game/cost/CostPart;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/CostPaymentStack$Entry","payment","Lforge/game/cost/CostPayment;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11024(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/zone/CostPaymentStack$Entry:11024:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/zone/CostPaymentStack$Entry;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11025(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/zone/CostPaymentStack$Entry:11025:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/zone/CostPaymentStack$Entry;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11026(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/zone/CostPaymentStack$Entry:11026:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/zone/CostPaymentStack$Entry;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11027(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/CostPaymentStack$Entry","cost","Lforge/game/cost/CostPart;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11028(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/CostPaymentStack$Entry","payment","Lforge/game/cost/CostPayment;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

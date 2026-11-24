// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1108{
internal static JClass Build(){var c=new JClass("forge/util/BagRandomizer$BagRandomizerIterator","java/lang/Object",new string[]{"java/util/Iterator"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("this$0","Lforge/util/BagRandomizer;",false,JValue.Default("Lforge/util/BagRandomizer;"),null));
c.Add(new JMethod(11652,"forge/util/BagRandomizer$BagRandomizerIterator","<init>","(Lforge/util/BagRandomizer;)V",2,2,2,new JHandler[]{},M11652));
c.Add(new JMethod(11653,"forge/util/BagRandomizer$BagRandomizerIterator","hasNext","()Z",1,1,1,new JHandler[]{},M11653));
c.Add(new JMethod(11654,"forge/util/BagRandomizer$BagRandomizerIterator","next","()Ljava/lang/Object;",1,1,1,new JHandler[]{},M11654));
}

internal static JStep M11652(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/BagRandomizer$BagRandomizerIterator","this$0","Lforge/util/BagRandomizer;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11653(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/BagRandomizer$BagRandomizerIterator","this$0","Lforge/util/BagRandomizer;"));f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/util/BagRandomizer","bag","[Ljava/lang/Object;"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int<=0?15:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Pc=16;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11654(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/BagRandomizer$BagRandomizerIterator","this$0","Lforge/util/BagRandomizer;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/BagRandomizer","getNextItem","()Ljava/lang/Object;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

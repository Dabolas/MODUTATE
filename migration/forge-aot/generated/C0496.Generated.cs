// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C496{
internal static JClass Build(){var c=new JClass("forge/game/card/perpetual/PerpetualNewPT","java/lang/Record",new string[]{"forge/game/card/perpetual/PerpetualInterface"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("power","Ljava/lang/Integer;",false,JValue.Default("Ljava/lang/Integer;"),null));
c.Add(new JField("toughness","Ljava/lang/Integer;",false,JValue.Default("Ljava/lang/Integer;"),null));
c.Add(new JMethod(5872,"forge/game/card/perpetual/PerpetualNewPT","<init>","(JLjava/lang/Integer;Ljava/lang/Integer;)V",1,5,3,new JHandler[]{},M5872));
c.Add(new JMethod(5873,"forge/game/card/perpetual/PerpetualNewPT","getTimestamp","()J",1,1,2,new JHandler[]{},M5873));
c.Add(new JMethod(5874,"forge/game/card/perpetual/PerpetualNewPT","applyEffect","(Lforge/game/card/Card;)V",1,2,7,new JHandler[]{},M5874));
c.Add(new JMethod(5875,"forge/game/card/perpetual/PerpetualNewPT","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M5875));
c.Add(new JMethod(5876,"forge/game/card/perpetual/PerpetualNewPT","hashCode","()I",17,1,1,new JHandler[]{},M5876));
c.Add(new JMethod(5877,"forge/game/card/perpetual/PerpetualNewPT","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M5877));
c.Add(new JMethod(5878,"forge/game/card/perpetual/PerpetualNewPT","timestamp","()J",1,1,2,new JHandler[]{},M5878));
c.Add(new JMethod(5879,"forge/game/card/perpetual/PerpetualNewPT","power","()Ljava/lang/Integer;",1,1,1,new JHandler[]{},M5879));
c.Add(new JMethod(5880,"forge/game/card/perpetual/PerpetualNewPT","toughness","()Ljava/lang/Integer;",1,1,1,new JHandler[]{},M5880));
}

internal static JStep M5872(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualNewPT","timestamp","J",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualNewPT","power","Ljava/lang/Integer;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualNewPT","toughness","Ljava/lang/Integer;",value);f.Pc=20;continue;}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5873(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualNewPT","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5874(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualNewPT","power","Ljava/lang/Integer;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualNewPT","toughness","Ljava/lang/Integer;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualNewPT","timestamp","J"));f.Pc=13;continue;}
case 13:{f.Push(JValue.L(0));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","addNewPT","(Ljava/lang/Integer;Ljava/lang/Integer;JJ)V","invokevirtual",17);}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5875(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualNewPT:5875:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualNewPT;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5876(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualNewPT:5876:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualNewPT;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5877(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualNewPT:5877:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualNewPT;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5878(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualNewPT","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5879(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualNewPT","power","Ljava/lang/Integer;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5880(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualNewPT","toughness","Ljava/lang/Integer;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C491{
internal static JClass Build(){var c=new JClass("forge/game/card/perpetual/PerpetualColors","java/lang/Record",new string[]{"forge/game/card/perpetual/PerpetualInterface"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("colors","Lforge/card/ColorSet;",false,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("overwrite","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(5835,"forge/game/card/perpetual/PerpetualColors","<init>","(JLforge/card/ColorSet;Z)V",1,5,3,new JHandler[]{},M5835));
c.Add(new JMethod(5836,"forge/game/card/perpetual/PerpetualColors","getTimestamp","()J",1,1,2,new JHandler[]{},M5836));
c.Add(new JMethod(5837,"forge/game/card/perpetual/PerpetualColors","applyEffect","(Lforge/game/card/Card;)V",1,2,6,new JHandler[]{},M5837));
c.Add(new JMethod(5838,"forge/game/card/perpetual/PerpetualColors","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M5838));
c.Add(new JMethod(5839,"forge/game/card/perpetual/PerpetualColors","hashCode","()I",17,1,1,new JHandler[]{},M5839));
c.Add(new JMethod(5840,"forge/game/card/perpetual/PerpetualColors","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M5840));
c.Add(new JMethod(5841,"forge/game/card/perpetual/PerpetualColors","timestamp","()J",1,1,2,new JHandler[]{},M5841));
c.Add(new JMethod(5842,"forge/game/card/perpetual/PerpetualColors","colors","()Lforge/card/ColorSet;",1,1,1,new JHandler[]{},M5842));
c.Add(new JMethod(5843,"forge/game/card/perpetual/PerpetualColors","overwrite","()Z",1,1,1,new JHandler[]{},M5843));
}

internal static JStep M5835(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualColors","timestamp","J",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualColors","colors","Lforge/card/ColorSet;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualColors","overwrite","Z",value);f.Pc=20;continue;}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5836(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualColors","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5837(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualColors","colors","Lforge/card/ColorSet;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualColors","overwrite","Z"));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int!=0?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualColors","timestamp","J"));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(null));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/Card","addColor","(Lforge/card/ColorSet;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",25);}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5838(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualColors:5838:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualColors;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5839(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualColors:5839:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualColors;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5840(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualColors:5840:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualColors;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5841(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualColors","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5842(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualColors","colors","Lforge/card/ColorSet;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5843(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualColors","overwrite","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

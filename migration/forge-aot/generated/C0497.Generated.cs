// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C497{
internal static JClass Build(){var c=new JClass("forge/game/card/perpetual/PerpetualPTBoost","java/lang/Record",new string[]{"forge/game/card/perpetual/PerpetualInterface"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("power","Ljava/lang/Integer;",false,JValue.Default("Ljava/lang/Integer;"),null));
c.Add(new JField("toughness","Ljava/lang/Integer;",false,JValue.Default("Ljava/lang/Integer;"),null));
c.Add(new JMethod(5881,"forge/game/card/perpetual/PerpetualPTBoost","<init>","(JLjava/lang/Integer;Ljava/lang/Integer;)V",1,5,3,new JHandler[]{},M5881));
c.Add(new JMethod(5882,"forge/game/card/perpetual/PerpetualPTBoost","getTimestamp","()J",1,1,2,new JHandler[]{},M5882));
c.Add(new JMethod(5883,"forge/game/card/perpetual/PerpetualPTBoost","applyEffect","(Lforge/game/card/Card;)V",1,2,7,new JHandler[]{},M5883));
c.Add(new JMethod(5884,"forge/game/card/perpetual/PerpetualPTBoost","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M5884));
c.Add(new JMethod(5885,"forge/game/card/perpetual/PerpetualPTBoost","hashCode","()I",17,1,1,new JHandler[]{},M5885));
c.Add(new JMethod(5886,"forge/game/card/perpetual/PerpetualPTBoost","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M5886));
c.Add(new JMethod(5887,"forge/game/card/perpetual/PerpetualPTBoost","timestamp","()J",1,1,2,new JHandler[]{},M5887));
c.Add(new JMethod(5888,"forge/game/card/perpetual/PerpetualPTBoost","power","()Ljava/lang/Integer;",1,1,1,new JHandler[]{},M5888));
c.Add(new JMethod(5889,"forge/game/card/perpetual/PerpetualPTBoost","toughness","()Ljava/lang/Integer;",1,1,1,new JHandler[]{},M5889));
}

internal static JStep M5881(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualPTBoost","timestamp","J",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualPTBoost","power","Ljava/lang/Integer;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/perpetual/PerpetualPTBoost","toughness","Ljava/lang/Integer;",value);f.Pc=20;continue;}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5882(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualPTBoost","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5883(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualPTBoost","power","Ljava/lang/Integer;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualPTBoost","toughness","Ljava/lang/Integer;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualPTBoost","timestamp","J"));f.Pc=19;continue;}
case 19:{f.Push(JValue.L(0));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","addPTBoost","(IIJJ)V","invokevirtual",23);}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5884(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualPTBoost:5884:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualPTBoost;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5885(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualPTBoost:5885:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualPTBoost;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5886(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/perpetual/PerpetualPTBoost:5886:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/perpetual/PerpetualPTBoost;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5887(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualPTBoost","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5888(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualPTBoost","power","Ljava/lang/Integer;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5889(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/perpetual/PerpetualPTBoost","toughness","Ljava/lang/Integer;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

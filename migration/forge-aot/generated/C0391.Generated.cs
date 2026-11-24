// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C391{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RollDiceEffect$DieRollResult","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("naturalValue","I",false,JValue.Default("I"),null));
c.Add(new JField("modifiedValue","I",false,JValue.Default("I"),null));
c.Add(new JMethod(3691,"forge/game/ability/effects/RollDiceEffect$DieRollResult","<init>","(II)V",1,3,2,new JHandler[]{},M3691));
c.Add(new JMethod(3692,"forge/game/ability/effects/RollDiceEffect$DieRollResult","getNaturalValue","()I",1,1,1,new JHandler[]{},M3692));
c.Add(new JMethod(3693,"forge/game/ability/effects/RollDiceEffect$DieRollResult","getModifiedValue","()I",1,1,1,new JHandler[]{},M3693));
c.Add(new JMethod(3694,"forge/game/ability/effects/RollDiceEffect$DieRollResult","setNaturalValue","(I)V",1,2,2,new JHandler[]{},M3694));
c.Add(new JMethod(3695,"forge/game/ability/effects/RollDiceEffect$DieRollResult","setModifiedValue","(I)V",1,2,2,new JHandler[]{},M3695));
c.Add(new JMethod(3696,"forge/game/ability/effects/RollDiceEffect$DieRollResult","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M3696));
}

internal static JStep M3691(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/RollDiceEffect$DieRollResult","naturalValue","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/RollDiceEffect$DieRollResult","modifiedValue","I",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3692(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/RollDiceEffect$DieRollResult","naturalValue","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3693(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/RollDiceEffect$DieRollResult","modifiedValue","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3694(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/RollDiceEffect$DieRollResult","naturalValue","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3695(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/RollDiceEffect$DieRollResult","modifiedValue","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3696(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/RollDiceEffect$DieRollResult","modifiedValue","I"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

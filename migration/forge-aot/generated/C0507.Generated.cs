// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C507{
internal static JClass Build(){var c=new JClass("forge/game/combat/AttackConstraints$Attack","java/lang/Object",new string[]{"java/lang/Comparable"},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("attacker","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("defender","Lforge/game/GameEntity;",false,JValue.Default("Lforge/game/GameEntity;"),null));
c.Add(new JField("requirements","I",false,JValue.Default("I"),null));
c.Add(new JMethod(5989,"forge/game/combat/AttackConstraints$Attack","<init>","(Lforge/game/combat/AttackConstraints$Attack;)V",2,2,4,new JHandler[]{},M5989));
c.Add(new JMethod(5990,"forge/game/combat/AttackConstraints$Attack","<init>","(Lforge/game/card/Card;Lforge/game/GameEntity;I)V",2,4,2,new JHandler[]{},M5990));
c.Add(new JMethod(5991,"forge/game/combat/AttackConstraints$Attack","compareTo","(Lforge/game/combat/AttackConstraints$Attack;)I",1,2,2,new JHandler[]{},M5991));
c.Add(new JMethod(5992,"forge/game/combat/AttackConstraints$Attack","toString","()Ljava/lang/String;",1,1,3,new JHandler[]{},M5992));
c.Add(new JMethod(5993,"forge/game/combat/AttackConstraints$Attack","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M5993));
}

internal static JStep M5989(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","defender","Lforge/game/GameEntity;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","requirements","I"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/combat/AttackConstraints$Attack","<init>","(Lforge/game/card/Card;Lforge/game/GameEntity;I)V","invokespecial",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5990(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","defender","Lforge/game/GameEntity;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","requirements","I",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5991(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","requirements","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","requirements","I"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/Integer","compare","(II)I","invokestatic",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5992(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","requirements","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","defender","Lforge/game/GameEntity;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",18);}
case 18:{return rt.DynamicCall(f,"forge/game/combat/AttackConstraints$Attack:5992:18:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(ILjava/lang/String;Ljava/lang/String;)Ljava/lang/String;",23);}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5993(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackConstraints$Attack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/combat/AttackConstraints$Attack","compareTo","(Lforge/game/combat/AttackConstraints$Attack;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C682{
internal static JClass Build(){var c=new JClass("forge/game/mana/ManaCostBeingPaid$ShardCount","java/lang/Object",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("xCount","I",false,JValue.Default("I"),null));
c.Add(new JField("totalCount","I",false,JValue.Default("I"),null));
c.Add(new JField("this$0","Lforge/game/mana/ManaCostBeingPaid;",false,JValue.Default("Lforge/game/mana/ManaCostBeingPaid;"),null));
c.Add(new JMethod(7769,"forge/game/mana/ManaCostBeingPaid$ShardCount","<init>","(Lforge/game/mana/ManaCostBeingPaid;)V",2,2,2,new JHandler[]{},M7769));
c.Add(new JMethod(7770,"forge/game/mana/ManaCostBeingPaid$ShardCount","<init>","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/mana/ManaCostBeingPaid$ShardCount;)V",2,3,2,new JHandler[]{},M7770));
c.Add(new JMethod(7771,"forge/game/mana/ManaCostBeingPaid$ShardCount","toString","()Ljava/lang/String;",1,1,2,new JHandler[]{},M7771));
}

internal static JStep M7769(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","this$0","Lforge/game/mana/ManaCostBeingPaid;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7770(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","this$0","Lforge/game/mana/ManaCostBeingPaid;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I",value);f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7771(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","xCount","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaCostBeingPaid$ShardCount","totalCount","I"));f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/game/mana/ManaCostBeingPaid$ShardCount:7771:8:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(II)Ljava/lang/String;",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

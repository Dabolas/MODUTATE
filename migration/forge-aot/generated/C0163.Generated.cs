// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C163{
internal static JClass Build(){var c=new JClass("forge/game/GameSnapshot$UnorderedEntities","java/lang/Record",new string[]{"java/lang/Comparable"},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("toPlayer","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("fromCard","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("newCard","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("fromType","Lforge/game/zone/ZoneType;",false,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("zonePosition","I",false,JValue.Default("I"),null));
c.Add(new JMethod(2565,"forge/game/GameSnapshot$UnorderedEntities","<init>","(Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/zone/ZoneType;I)V",2,6,2,new JHandler[]{},M2565));
c.Add(new JMethod(2566,"forge/game/GameSnapshot$UnorderedEntities","compareTo","(Lforge/game/GameSnapshot$UnorderedEntities;)I",1,2,2,new JHandler[]{},M2566));
c.Add(new JMethod(2567,"forge/game/GameSnapshot$UnorderedEntities","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M2567));
c.Add(new JMethod(2568,"forge/game/GameSnapshot$UnorderedEntities","hashCode","()I",17,1,1,new JHandler[]{},M2568));
c.Add(new JMethod(2569,"forge/game/GameSnapshot$UnorderedEntities","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M2569));
c.Add(new JMethod(2570,"forge/game/GameSnapshot$UnorderedEntities","toPlayer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M2570));
c.Add(new JMethod(2571,"forge/game/GameSnapshot$UnorderedEntities","fromCard","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M2571));
c.Add(new JMethod(2572,"forge/game/GameSnapshot$UnorderedEntities","newCard","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M2572));
c.Add(new JMethod(2573,"forge/game/GameSnapshot$UnorderedEntities","fromType","()Lforge/game/zone/ZoneType;",1,1,1,new JHandler[]{},M2573));
c.Add(new JMethod(2574,"forge/game/GameSnapshot$UnorderedEntities","zonePosition","()I",1,1,1,new JHandler[]{},M2574));
c.Add(new JMethod(2575,"forge/game/GameSnapshot$UnorderedEntities","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M2575));
}

internal static JStep M2565(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","toPlayer","Lforge/game/player/Player;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","fromCard","Lforge/game/card/Card;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","newCard","Lforge/game/card/Card;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","fromType","Lforge/game/zone/ZoneType;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","zonePosition","I",value);f.Pc=31;continue;}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2566(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","zonePosition","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","zonePosition","I"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/Integer","compare","(II)I","invokestatic",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2567(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/GameSnapshot$UnorderedEntities:2567:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/GameSnapshot$UnorderedEntities;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2568(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/GameSnapshot$UnorderedEntities:2568:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/GameSnapshot$UnorderedEntities;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2569(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/GameSnapshot$UnorderedEntities:2569:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/GameSnapshot$UnorderedEntities;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2570(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","toPlayer","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2571(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","fromCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2572(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","newCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2573(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","fromType","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2574(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameSnapshot$UnorderedEntities","zonePosition","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2575(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameSnapshot$UnorderedEntities"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameSnapshot$UnorderedEntities","compareTo","(Lforge/game/GameSnapshot$UnorderedEntities;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C797{
internal static JClass Build(){var c=new JClass("forge/game/spellability/OptionalCostValue","java/lang/Object",new string[]{"java/io/Serializable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("type","Lforge/game/spellability/OptionalCost;",false,JValue.Default("Lforge/game/spellability/OptionalCost;"),null));
c.Add(new JField("cost","Lforge/game/cost/Cost;",false,JValue.Default("Lforge/game/cost/Cost;"),null));
c.Add(new JMethod(9164,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V",1,3,2,new JHandler[]{},M9164));
c.Add(new JMethod(9165,"forge/game/spellability/OptionalCostValue","getType","()Lforge/game/spellability/OptionalCost;",1,1,1,new JHandler[]{},M9165));
c.Add(new JMethod(9166,"forge/game/spellability/OptionalCostValue","getCost","()Lforge/game/cost/Cost;",1,1,1,new JHandler[]{},M9166));
c.Add(new JMethod(9167,"forge/game/spellability/OptionalCostValue","toString","()Ljava/lang/String;",1,3,2,new JHandler[]{},M9167));
}

internal static JStep M9164(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/OptionalCostValue","type","Lforge/game/spellability/OptionalCost;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/OptionalCostValue","cost","Lforge/game/cost/Cost;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9165(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/OptionalCostValue","type","Lforge/game/spellability/OptionalCost;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9166(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/OptionalCostValue","cost","Lforge/game/cost/Cost;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9167(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/OptionalCostValue","type","Lforge/game/spellability/OptionalCost;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/OptionalCost","getName","()Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Push(JValue.R(rt.String("(")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/OptionalCostValue","type","Lforge/game/spellability/OptionalCost;"));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;"));f.Pc=28;continue;}
case 28:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?54:31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Int!=0?54:35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/OptionalCostValue","type","Lforge/game/spellability/OptionalCost;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/OptionalCost","getName","()Ljava/lang/String;","invokevirtual",43);}
case 43:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String(" \u2013 ")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/OptionalCostValue","cost","Lforge/game/cost/Cost;"));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",62);}
case 62:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Int==0?86:71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/OptionalCostValue","type","Lforge/game/spellability/OptionalCost;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/OptionalCost","getName","()Ljava/lang/String;","invokevirtual",78);}
case 78:{return rt.DynamicCall(f,"forge/game/spellability/OptionalCostValue:9167:78:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",83);}
case 83:{f.Pc=88;continue;}
case 86:{f.Push(JValue.R(rt.String("")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",91);}
case 91:{f.StackOp("pop");f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",96);}
case 96:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

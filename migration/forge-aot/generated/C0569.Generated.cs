// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C569{
internal static JClass Build(){var c=new JClass("forge/game/cost/LibraryMovementCostVisitor","forge/game/cost/ICostVisitor$Base",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("INSTANCE","Lforge/game/cost/LibraryMovementCostVisitor;",true,JValue.Default("Lforge/game/cost/LibraryMovementCostVisitor;"),null));
c.Add(new JMethod(6730,"forge/game/cost/LibraryMovementCostVisitor","<init>","()V",2,1,1,new JHandler[]{},M6730));
c.Add(new JMethod(6731,"forge/game/cost/LibraryMovementCostVisitor","movesCardToOrFromLibrary","(Lforge/game/cost/Cost;)Z",9,3,3,new JHandler[]{},M6731));
c.Add(new JMethod(6732,"forge/game/cost/LibraryMovementCostVisitor","visit","(Lforge/game/cost/CostMill;)Ljava/lang/Boolean;",1,2,1,new JHandler[]{},M6732));
c.Add(new JMethod(6733,"forge/game/cost/LibraryMovementCostVisitor","visit","(Lforge/game/cost/CostDraw;)Ljava/lang/Boolean;",1,2,1,new JHandler[]{},M6733));
c.Add(new JMethod(6734,"forge/game/cost/LibraryMovementCostVisitor","visit","(Lforge/game/cost/CostPutCardToLib;)Ljava/lang/Boolean;",1,2,1,new JHandler[]{},M6734));
c.Add(new JMethod(6735,"forge/game/cost/LibraryMovementCostVisitor","visit","(Lforge/game/cost/CostExile;)Ljava/lang/Boolean;",1,2,2,new JHandler[]{},M6735));
c.Add(new JMethod(6736,"forge/game/cost/LibraryMovementCostVisitor","visit","(Lforge/game/cost/CostPutCardToLib;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M6736));
c.Add(new JMethod(6737,"forge/game/cost/LibraryMovementCostVisitor","visit","(Lforge/game/cost/CostMill;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M6737));
c.Add(new JMethod(6738,"forge/game/cost/LibraryMovementCostVisitor","visit","(Lforge/game/cost/CostExile;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M6738));
c.Add(new JMethod(6739,"forge/game/cost/LibraryMovementCostVisitor","visit","(Lforge/game/cost/CostDraw;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M6739));
c.Add(new JMethod(6740,"forge/game/cost/LibraryMovementCostVisitor","<clinit>","()V",8,0,2,new JHandler[]{},M6740));
}

internal static JStep M6730(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/ICostVisitor$Base","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6731(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[1]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?56:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[2]=f.Pop();f.Pc=35;continue;}
case 35:{if(!rt.StaticReady(f,"java/lang/Boolean","TRUE","Ljava/lang/Boolean;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","TRUE","Ljava/lang/Boolean;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/game/cost/LibraryMovementCostVisitor","INSTANCE","Lforge/game/cost/LibraryMovementCostVisitor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/cost/LibraryMovementCostVisitor","INSTANCE","Lforge/game/cost/LibraryMovementCostVisitor;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/cost/CostPart","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;","invokevirtual",45);}
case 45:{return rt.Call(f,"java/lang/Boolean","equals","(Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?53:51;continue;}
case 51:{f.Push(JValue.I(1));f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 53:{f.Pc=16;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6732(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6733(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6734(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6735(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostExile","getFrom","()Ljava/util/List;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6736(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/LibraryMovementCostVisitor","visit","(Lforge/game/cost/CostPutCardToLib;)Ljava/lang/Boolean;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6737(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/LibraryMovementCostVisitor","visit","(Lforge/game/cost/CostMill;)Ljava/lang/Boolean;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6738(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/LibraryMovementCostVisitor","visit","(Lforge/game/cost/CostExile;)Ljava/lang/Boolean;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6739(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/LibraryMovementCostVisitor","visit","(Lforge/game/cost/CostDraw;)Ljava/lang/Boolean;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6740(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/LibraryMovementCostVisitor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/LibraryMovementCostVisitor")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/LibraryMovementCostVisitor","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/game/cost/LibraryMovementCostVisitor","INSTANCE","Lforge/game/cost/LibraryMovementCostVisitor;"))return JStep.Continue;rt.PutStatic("forge/game/cost/LibraryMovementCostVisitor","INSTANCE","Lforge/game/cost/LibraryMovementCostVisitor;",f.Pop());f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

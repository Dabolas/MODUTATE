// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C433{
internal static JClass Build(){var c=new JClass("forge/game/card/Card$CardChangedName","java/lang/Record",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("newName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("addNonLegendaryCreatureNames","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(4844,"forge/game/card/Card$CardChangedName","<init>","(Ljava/lang/String;Z)V",2,3,2,new JHandler[]{},M4844));
c.Add(new JMethod(4845,"forge/game/card/Card$CardChangedName","isOverwrite","()Z",1,1,1,new JHandler[]{},M4845));
c.Add(new JMethod(4846,"forge/game/card/Card$CardChangedName","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M4846));
c.Add(new JMethod(4847,"forge/game/card/Card$CardChangedName","hashCode","()I",17,1,1,new JHandler[]{},M4847));
c.Add(new JMethod(4848,"forge/game/card/Card$CardChangedName","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M4848));
c.Add(new JMethod(4849,"forge/game/card/Card$CardChangedName","newName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M4849));
c.Add(new JMethod(4850,"forge/game/card/Card$CardChangedName","addNonLegendaryCreatureNames","()Z",1,1,1,new JHandler[]{},M4850));
}

internal static JStep M4844(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card$CardChangedName","newName","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card$CardChangedName","addNonLegendaryCreatureNames","Z",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4845(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card$CardChangedName","newName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4846(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/Card$CardChangedName:4846:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/Card$CardChangedName;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4847(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/Card$CardChangedName:4847:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/Card$CardChangedName;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4848(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/Card$CardChangedName:4848:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/Card$CardChangedName;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4849(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card$CardChangedName","newName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4850(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/Card$CardChangedName","addNonLegendaryCreatureNames","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

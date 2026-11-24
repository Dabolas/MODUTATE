// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C523{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostBlight","forge/game/cost/CostPutCounter",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(6245,"forge/game/cost/CostBlight","<init>","(Ljava/lang/String;)V",1,2,5,new JHandler[]{},M6245));
c.Add(new JMethod(6246,"forge/game/cost/CostBlight","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6246));
c.Add(new JMethod(6247,"forge/game/cost/CostBlight","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6247));
}

internal static JStep M6245(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","M1M1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","M1M1","Lforge/game/card/CounterEnumType;"));f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("Creature.YouCtrl")));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("a creature you control")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/CostPutCounter","<init>","(Ljava/lang/String;Lforge/game/card/CounterType;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6246(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostBlight","getAmount","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/game/cost/CostBlight:6246:4:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6247(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostBlight;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

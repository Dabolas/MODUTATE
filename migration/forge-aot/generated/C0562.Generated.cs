// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C562{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostTeamwork","forge/game/cost/CostTapType",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(6612,"forge/game/cost/CostTeamwork","<init>","(Ljava/lang/String;)V",1,2,5,new JHandler[]{},M6612));
}

internal static JStep M6612(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Any")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/game/cost/CostTeamwork:6612:4:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",9);}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/cost/CostTapType","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V","invokespecial",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

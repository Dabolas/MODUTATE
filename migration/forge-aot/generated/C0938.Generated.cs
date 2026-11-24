// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C938{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerDayTimeChanges","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10400,"forge/game/trigger/TriggerDayTimeChanges","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10400));
c.Add(new JMethod(10401,"forge/game/trigger/TriggerDayTimeChanges","performTest","(Ljava/util/Map;)Z",1,2,1,new JHandler[]{},M10401));
c.Add(new JMethod(10402,"forge/game/trigger/TriggerDayTimeChanges","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",1,3,0,new JHandler[]{},M10402));
c.Add(new JMethod(10403,"forge/game/trigger/TriggerDayTimeChanges","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,2,1,new JHandler[]{},M10403));
}

internal static JStep M10400(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10401(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10402(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10403(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

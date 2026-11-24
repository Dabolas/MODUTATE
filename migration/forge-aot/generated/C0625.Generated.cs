// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C625{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventSpellRemovedFromStack","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("sa","Lforge/game/spellability/SpellAbilityView;",false,JValue.Default("Lforge/game/spellability/SpellAbilityView;"),null));
c.Add(new JMethod(7178,"forge/game/event/GameEventSpellRemovedFromStack","<init>","(Lforge/game/spellability/SpellAbilityView;)V",1,2,2,new JHandler[]{},M7178));
c.Add(new JMethod(7179,"forge/game/event/GameEventSpellRemovedFromStack","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M7179));
c.Add(new JMethod(7180,"forge/game/event/GameEventSpellRemovedFromStack","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7180));
c.Add(new JMethod(7181,"forge/game/event/GameEventSpellRemovedFromStack","hashCode","()I",17,1,1,new JHandler[]{},M7181));
c.Add(new JMethod(7182,"forge/game/event/GameEventSpellRemovedFromStack","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M7182));
c.Add(new JMethod(7183,"forge/game/event/GameEventSpellRemovedFromStack","sa","()Lforge/game/spellability/SpellAbilityView;",1,1,1,new JHandler[]{},M7183));
}

internal static JStep M7178(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventSpellRemovedFromStack","sa","Lforge/game/spellability/SpellAbilityView;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7179(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventSpellRemovedFromStack;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7180(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellRemovedFromStack","sa","Lforge/game/spellability/SpellAbilityView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",7);}
case 7:{return rt.DynamicCall(f,"forge/game/event/GameEventSpellRemovedFromStack:7180:7:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7181(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventSpellRemovedFromStack:7181:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventSpellRemovedFromStack;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7182(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventSpellRemovedFromStack:7182:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventSpellRemovedFromStack;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7183(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellRemovedFromStack","sa","Lforge/game/spellability/SpellAbilityView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

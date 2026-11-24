// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C626{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventSpellResolved","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("spell","Lforge/game/spellability/SpellAbilityView;",false,JValue.Default("Lforge/game/spellability/SpellAbilityView;"),null));
c.Add(new JField("hasFizzled","Z",false,JValue.Default("Z"),null));
c.Add(new JField("stackDescription","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(7184,"forge/game/event/GameEventSpellResolved","<init>","(Lforge/game/spellability/SpellAbility;Z)V",1,3,4,new JHandler[]{},M7184));
c.Add(new JMethod(7185,"forge/game/event/GameEventSpellResolved","<init>","(Lforge/game/spellability/SpellAbilityView;ZLjava/lang/String;)V",1,4,2,new JHandler[]{},M7185));
c.Add(new JMethod(7186,"forge/game/event/GameEventSpellResolved","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M7186));
c.Add(new JMethod(7187,"forge/game/event/GameEventSpellResolved","toString","()Ljava/lang/String;",1,1,2,new JHandler[]{},M7187));
c.Add(new JMethod(7188,"forge/game/event/GameEventSpellResolved","hashCode","()I",17,1,1,new JHandler[]{},M7188));
c.Add(new JMethod(7189,"forge/game/event/GameEventSpellResolved","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M7189));
c.Add(new JMethod(7190,"forge/game/event/GameEventSpellResolved","spell","()Lforge/game/spellability/SpellAbilityView;",1,1,1,new JHandler[]{},M7190));
c.Add(new JMethod(7191,"forge/game/event/GameEventSpellResolved","hasFizzled","()Z",1,1,1,new JHandler[]{},M7191));
c.Add(new JMethod(7192,"forge/game/event/GameEventSpellResolved","stackDescription","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7192));
}

internal static JStep M7184(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","get","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityView;","invokestatic",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getStackDescription","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/event/GameEventSpellResolved","<init>","(Lforge/game/spellability/SpellAbilityView;ZLjava/lang/String;)V","invokespecial",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7185(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventSpellResolved","spell","Lforge/game/spellability/SpellAbilityView;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventSpellResolved","hasFizzled","Z",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventSpellResolved","stackDescription","Ljava/lang/String;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7186(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventSpellResolved;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7187(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellResolved","spell","Lforge/game/spellability/SpellAbilityView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellResolved","hasFizzled","Z"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?19:14;continue;}
case 14:{f.Push(JValue.R(rt.String(" (fizzled)")));f.Pc=16;continue;}
case 16:{f.Pc=21;continue;}
case 19:{f.Push(JValue.R(rt.String("")));f.Pc=21;continue;}
case 21:{return rt.DynamicCall(f,"forge/game/event/GameEventSpellResolved:7187:21:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",26);}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7188(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventSpellResolved:7188:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventSpellResolved;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7189(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventSpellResolved:7189:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventSpellResolved;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7190(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellResolved","spell","Lforge/game/spellability/SpellAbilityView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7191(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellResolved","hasFizzled","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7192(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventSpellResolved","stackDescription","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

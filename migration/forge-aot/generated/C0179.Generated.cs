// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C179{
internal static JClass Build(){var c=new JClass("forge/game/ability/AbilityApiBased","forge/game/spellability/AbilityActivated",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("effect","Lforge/game/ability/SpellAbilityEffect;",false,JValue.Default("Lforge/game/ability/SpellAbilityEffect;"),null));
c.Add(new JMethod(2777,"forge/game/ability/AbilityApiBased","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;Ljava/util/Map;)V",1,6,4,new JHandler[]{},M2777));
c.Add(new JMethod(2778,"forge/game/ability/AbilityApiBased","getStackDescription","()Ljava/lang/String;",1,1,3,new JHandler[]{},M2778));
c.Add(new JMethod(2779,"forge/game/ability/AbilityApiBased","resolve","()V",1,1,2,new JHandler[]{},M2779));
}

internal static JStep M2777(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[4]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/AbilityActivated","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/AbilityApiBased","mapParams","Ljava/util/Map;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[5]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/AbilityApiBased","api","Lforge/game/ability/ApiType;",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/AbilityApiBased","api","Lforge/game/ability/ApiType;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/ability/ApiType","getSpellEffect","()Lforge/game/ability/SpellAbilityEffect;","invokevirtual",32);}
case 32:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/AbilityApiBased","effect","Lforge/game/ability/SpellAbilityEffect;",value);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/AbilityApiBased","effect","Lforge/game/ability/SpellAbilityEffect;"));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",43);}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/AbilityApiBased","originalMapParams","Ljava/util/Map;"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/AbilityApiBased","mapParams","Ljava/util/Map;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",56);}
case 56:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2778(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/AbilityApiBased","effect","Lforge/game/ability/SpellAbilityEffect;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/AbilityApiBased","mapParams","Ljava/util/Map;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getStackDescriptionWithSubs","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2779(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/AbilityApiBased","effect","Lforge/game/ability/SpellAbilityEffect;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","resolve","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C190{
internal static JClass Build(){var c=new JClass("forge/game/ability/SpellApiBased","forge/game/spellability/Spell",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-6741797239508483250L),null));
c.Add(new JField("effect","Lforge/game/ability/SpellAbilityEffect;",false,JValue.Default("Lforge/game/ability/SpellAbilityEffect;"),null));
c.Add(new JMethod(2985,"forge/game/ability/SpellApiBased","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;Ljava/util/Map;)V",1,6,3,new JHandler[]{},M2985));
c.Add(new JMethod(2986,"forge/game/ability/SpellApiBased","getStackDescription","()Ljava/lang/String;",1,2,3,new JHandler[]{},M2986));
c.Add(new JMethod(2987,"forge/game/ability/SpellApiBased","resolve","()V",1,1,2,new JHandler[]{},M2987));
}

internal static JStep M2985(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/Spell","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[4]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/SpellApiBased","setTargetRestrictions","(Lforge/game/spellability/TargetRestrictions;)V","invokevirtual",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellApiBased","mapParams","Ljava/util/Map;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/SpellApiBased","api","Lforge/game/ability/ApiType;",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellApiBased","api","Lforge/game/ability/ApiType;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/ApiType","getSpellEffect","()Lforge/game/ability/SpellAbilityEffect;","invokevirtual",36);}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/SpellApiBased","effect","Lforge/game/ability/SpellAbilityEffect;",value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/ability/SpellApiBased","setIntrinsic","(Z)V","invokevirtual",44);}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellApiBased","effect","Lforge/game/ability/SpellAbilityEffect;"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",52);}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellApiBased","originalMapParams","Ljava/util/Map;"));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellApiBased","mapParams","Ljava/util/Map;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",65);}
case 65:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2986(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/Spell","getStackDescription","()Ljava/lang/String;","invokespecial",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?25:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellApiBased","effect","Lforge/game/ability/SpellAbilityEffect;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellApiBased","mapParams","Ljava/util/Map;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getStackDescriptionWithSubs","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",24);}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2987(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellApiBased","effect","Lforge/game/ability/SpellAbilityEffect;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","resolve","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/SpellApiBased","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/player/Player","getAchievementTracker","()Lforge/game/player/AchievementTracker;","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/player/AchievementTracker","onSpellResolve","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

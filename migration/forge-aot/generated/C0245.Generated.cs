// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C245{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ClassLevelUpEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3179,"forge/game/ability/effects/ClassLevelUpEffect","<init>","()V",1,1,1,new JHandler[]{},M3179));
c.Add(new JMethod(3180,"forge/game/ability/effects/ClassLevelUpEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,6,4,new JHandler[]{},M3180));
}

internal static JStep M3179(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3180(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getClassLevel","()I","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","isClassLevelNAbility","(I)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int!=0?26:25;continue;}
case 25:{return JStep.ReturnVoid;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","setClassLevel","(I)V","invokevirtual",35);}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","()V","invokevirtual",42);}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",46);}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearActiveTriggers","(Lforge/game/card/Card;Lforge/game/zone/Zone;)V","invokevirtual",51);}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",55);}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerActiveTrigger","(Lforge/game/card/Card;Z)V","invokevirtual",60);}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",64);}
case 64:{f.Locals[5]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ClassLevel","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ClassLevel","Lforge/game/ability/AbilityKey;"));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",76);}
case 76:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",86);}
case 86:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ClassLevelGained","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ClassLevelGained","Lforge/game/trigger/TriggerType;"));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[5]);f.Pc=91;continue;}
case 91:{f.Push(JValue.I(0));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",95);}
case 95:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

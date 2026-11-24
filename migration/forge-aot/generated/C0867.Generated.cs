// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C867{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityMode","java/lang/Enum",new string[]{},16433);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Continuous","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantAttackUnless","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantBlockUnless","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("OptionalAttackCost","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("OptionalCost","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("AlternativeCost","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantBeCast","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantBeActivated","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantPlayLand","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("DisableTriggers","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("Panharmonicon","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("MustTarget","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantAttack","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CanAttackDefender","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantBlock","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantBlockBy","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CanAttackIfHaste","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CanBlockIfReach","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CanBlockIfShadow","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("MinMaxBlocker","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("BlockTapped","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("AttackVigilance","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("MustAttack","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("PlayerMustAttack","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("MustBlock","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("AssignCombatDamageAsUnblocked","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CombatDamageToughness","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CombatDamageNegatePower","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("ColorlessDamageSource","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("NoCleanupDamage","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("BlockRestrict","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantGainLife","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantLoseLife","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantChangeLife","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantPayLife","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("RaiseCost","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("ReduceCost","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("SetCost","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("IgnoreHexproof","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("IgnoreShroud","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("AttackRestrict","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("AssignNoCombatDamage","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CanAdapt","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantBeCopied","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantBeBeamedUp","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantBeSuspected","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantBecomeMonarch","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantGainControl","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantAttach","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantCrew","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantDraw","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("DrawFromBottom","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantDiscard","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantExile","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantPhaseIn","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantPhaseOut","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantPreventDamage","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantPutCounter","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantRegenerate","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantSacrifice","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantTarget","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantTransform","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantVenture","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CantChangeDayTime","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
}

private static void Add1(JClass c){
c.Add(new JField("ActivateAbilityAsIfHaste","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CastWithFlash","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("IgnoreLandwalk","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("IgnoreLegendRule","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("IgnorePlaneswalkerZeroLoyaltyRule","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("MaxCounter","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("InfectDamage","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("WitherDamage","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("FlipCoinMod","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("FlipCoinDoubler","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("PlotZone","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("ForetellAnyTurn","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("NumLoyaltyAct","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("Activations","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("Devotion","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("GainLifeRadiation","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("SurveilNum","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("TapPowerValue","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("UnspentMana","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("ManaBurn","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("ManaConvert","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("UntapOtherPlayer","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("TurnReversed","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("PhaseReversed","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("AttackRequirement","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("CountersRemain","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("ManaRestriction","Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JField("$VALUES","[Lforge/game/staticability/StaticAbilityMode;",true,JValue.Default("[Lforge/game/staticability/StaticAbilityMode;"),null));
c.Add(new JMethod(10056,"forge/game/staticability/StaticAbilityMode","values","()[Lforge/game/staticability/StaticAbilityMode;",9,0,1,new JHandler[]{},M10056));
c.Add(new JMethod(10057,"forge/game/staticability/StaticAbilityMode","valueOf","(Ljava/lang/String;)Lforge/game/staticability/StaticAbilityMode;",9,1,2,new JHandler[]{},M10057));
c.Add(new JMethod(10058,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M10058));
c.Add(new JMethod(10059,"forge/game/staticability/StaticAbilityMode","smartValueOf","(Ljava/lang/String;)Lforge/game/staticability/StaticAbilityMode;",9,6,3,new JHandler[]{},M10059));
c.Add(new JMethod(10060,"forge/game/staticability/StaticAbilityMode","setValueOf","(Ljava/lang/String;)Ljava/util/Set;",9,7,2,new JHandler[]{},M10060));
c.Add(new JMethod(10061,"forge/game/staticability/StaticAbilityMode","$values","()[Lforge/game/staticability/StaticAbilityMode;",4106,0,4,new JHandler[]{},M10061));
c.Add(new JMethod(10062,"forge/game/staticability/StaticAbilityMode","<clinit>","()V",8,0,4,new JHandler[]{},M10062));
}

internal static JStep M10056(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","$VALUES","[Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","$VALUES","[Lforge/game/staticability/StaticAbilityMode;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/staticability/StaticAbilityMode;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/staticability/StaticAbilityMode;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10057(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/staticability/StaticAbilityMode")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbilityMode"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10058(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10059(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","values","()[Lforge/game/staticability/StaticAbilityMode;","invokestatic",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=17;continue;}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?54:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=31;continue;}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","name","()Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","compareToIgnoreCase","(Ljava/lang/String;)I","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int!=0?48:45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{return JStep.Return(f.Pop());}
case 48:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=51;continue;}
case 51:{f.Pc=21;continue;}
case 54:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityMode:10059:59:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",64);}
case 64:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",67);}
case 67:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10060(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/staticability/StaticAbilityMode")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",5);}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("[, ]+")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=16;continue;}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?59:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=30;continue;}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","smartValueOf","(Ljava/lang/String;)Lforge/game/staticability/StaticAbilityMode;","invokestatic",37);}
case 37:{f.Locals[6]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[6]);f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Reference==null?53:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=56;continue;}
case 56:{f.Pc=20;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10061(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(91));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/staticability/StaticAbilityMode;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantAttackUnless","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantAttackUnless","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBlockUnless","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantBlockUnless","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","OptionalAttackCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","OptionalAttackCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","OptionalCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","OptionalCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AlternativeCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","AlternativeCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBeCast","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantBeCast","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBeActivated","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantBeActivated","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPlayLand","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantPlayLand","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","DisableTriggers","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","DisableTriggers","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Panharmonicon","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","Panharmonicon","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MustTarget","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","MustTarget","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantAttack","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantAttack","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CanAttackDefender","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CanAttackDefender","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBlock","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantBlock","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{f.Push(JValue.I(15));f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBlockBy","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantBlockBy","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=110;continue;}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.I(16));f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CanAttackIfHaste","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CanAttackIfHaste","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=117;continue;}
case 117:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(17));f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CanBlockIfReach","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CanBlockIfReach","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=124;continue;}
case 124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(JValue.I(18));f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CanBlockIfShadow","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CanBlockIfShadow","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=131;continue;}
case 131:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=132;continue;}
case 132:{f.StackOp("dup");f.Pc=133;continue;}
case 133:{f.Push(JValue.I(19));f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MinMaxBlocker","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","MinMaxBlocker","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=138;continue;}
case 138:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=139;continue;}
case 139:{f.StackOp("dup");f.Pc=140;continue;}
case 140:{f.Push(JValue.I(20));f.Pc=142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","BlockTapped","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","BlockTapped","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=145;continue;}
case 145:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=146;continue;}
case 146:{f.StackOp("dup");f.Pc=147;continue;}
case 147:{f.Push(JValue.I(21));f.Pc=149;continue;}
case 149:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AttackVigilance","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","AttackVigilance","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=152;continue;}
case 152:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=153;continue;}
case 153:{f.StackOp("dup");f.Pc=154;continue;}
case 154:{f.Push(JValue.I(22));f.Pc=156;continue;}
case 156:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MustAttack","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","MustAttack","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=159;continue;}
case 159:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=160;continue;}
case 160:{f.StackOp("dup");f.Pc=161;continue;}
case 161:{f.Push(JValue.I(23));f.Pc=163;continue;}
case 163:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","PlayerMustAttack","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","PlayerMustAttack","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=166;continue;}
case 166:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=167;continue;}
case 167:{f.StackOp("dup");f.Pc=168;continue;}
case 168:{f.Push(JValue.I(24));f.Pc=170;continue;}
case 170:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MustBlock","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","MustBlock","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=173;continue;}
case 173:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=174;continue;}
case 174:{f.StackOp("dup");f.Pc=175;continue;}
case 175:{f.Push(JValue.I(25));f.Pc=177;continue;}
case 177:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AssignCombatDamageAsUnblocked","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","AssignCombatDamageAsUnblocked","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=180;continue;}
case 180:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=181;continue;}
case 181:{f.StackOp("dup");f.Pc=182;continue;}
case 182:{f.Push(JValue.I(26));f.Pc=184;continue;}
case 184:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CombatDamageToughness","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CombatDamageToughness","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=187;continue;}
case 187:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=188;continue;}
case 188:{f.StackOp("dup");f.Pc=189;continue;}
case 189:{f.Push(JValue.I(27));f.Pc=191;continue;}
case 191:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CombatDamageNegatePower","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CombatDamageNegatePower","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=194;continue;}
case 194:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=195;continue;}
case 195:{f.StackOp("dup");f.Pc=196;continue;}
case 196:{f.Push(JValue.I(28));f.Pc=198;continue;}
case 198:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ColorlessDamageSource","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","ColorlessDamageSource","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=201;continue;}
case 201:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=202;continue;}
case 202:{f.StackOp("dup");f.Pc=203;continue;}
case 203:{f.Push(JValue.I(29));f.Pc=205;continue;}
case 205:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","NoCleanupDamage","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","NoCleanupDamage","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=208;continue;}
case 208:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=209;continue;}
case 209:{f.StackOp("dup");f.Pc=210;continue;}
case 210:{f.Push(JValue.I(30));f.Pc=212;continue;}
case 212:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","BlockRestrict","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","BlockRestrict","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=215;continue;}
case 215:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=216;continue;}
case 216:{f.StackOp("dup");f.Pc=217;continue;}
case 217:{f.Push(JValue.I(31));f.Pc=219;continue;}
case 219:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantGainLife","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantGainLife","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=222;continue;}
case 222:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=223;continue;}
case 223:{f.StackOp("dup");f.Pc=224;continue;}
case 224:{f.Push(JValue.I(32));f.Pc=226;continue;}
case 226:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantLoseLife","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantLoseLife","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=229;continue;}
case 229:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=230;continue;}
case 230:{f.StackOp("dup");f.Pc=231;continue;}
case 231:{f.Push(JValue.I(33));f.Pc=233;continue;}
case 233:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantChangeLife","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantChangeLife","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=236;continue;}
case 236:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=237;continue;}
case 237:{f.StackOp("dup");f.Pc=238;continue;}
case 238:{f.Push(JValue.I(34));f.Pc=240;continue;}
case 240:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPayLife","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantPayLife","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=243;continue;}
case 243:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=244;continue;}
case 244:{f.StackOp("dup");f.Pc=245;continue;}
case 245:{f.Push(JValue.I(35));f.Pc=247;continue;}
case 247:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","RaiseCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","RaiseCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=250;continue;}
case 250:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=251;continue;}
case 251:{f.StackOp("dup");f.Pc=252;continue;}
case 252:{f.Push(JValue.I(36));f.Pc=254;continue;}
case 254:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ReduceCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","ReduceCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=257;continue;}
case 257:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=258;continue;}
case 258:{f.StackOp("dup");f.Pc=259;continue;}
case 259:{f.Push(JValue.I(37));f.Pc=261;continue;}
case 261:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","SetCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","SetCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=264;continue;}
case 264:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=265;continue;}
case 265:{f.StackOp("dup");f.Pc=266;continue;}
case 266:{f.Push(JValue.I(38));f.Pc=268;continue;}
case 268:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","IgnoreHexproof","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","IgnoreHexproof","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=271;continue;}
case 271:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=272;continue;}
case 272:{f.StackOp("dup");f.Pc=273;continue;}
case 273:{f.Push(JValue.I(39));f.Pc=275;continue;}
case 275:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","IgnoreShroud","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","IgnoreShroud","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=278;continue;}
case 278:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=279;continue;}
case 279:{f.StackOp("dup");f.Pc=280;continue;}
case 280:{f.Push(JValue.I(40));f.Pc=282;continue;}
case 282:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AttackRestrict","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","AttackRestrict","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=285;continue;}
case 285:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=286;continue;}
case 286:{f.StackOp("dup");f.Pc=287;continue;}
case 287:{f.Push(JValue.I(41));f.Pc=289;continue;}
case 289:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AssignNoCombatDamage","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","AssignNoCombatDamage","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=292;continue;}
case 292:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=293;continue;}
case 293:{f.StackOp("dup");f.Pc=294;continue;}
case 294:{f.Push(JValue.I(42));f.Pc=296;continue;}
case 296:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CanAdapt","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CanAdapt","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=299;continue;}
case 299:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=300;continue;}
case 300:{f.StackOp("dup");f.Pc=301;continue;}
case 301:{f.Push(JValue.I(43));f.Pc=303;continue;}
case 303:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBeCopied","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantBeCopied","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=306;continue;}
case 306:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=307;continue;}
case 307:{f.StackOp("dup");f.Pc=308;continue;}
case 308:{f.Push(JValue.I(44));f.Pc=310;continue;}
case 310:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBeBeamedUp","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantBeBeamedUp","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=313;continue;}
case 313:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=314;continue;}
case 314:{f.StackOp("dup");f.Pc=315;continue;}
case 315:{f.Push(JValue.I(45));f.Pc=317;continue;}
case 317:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBeSuspected","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantBeSuspected","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=320;continue;}
case 320:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=321;continue;}
case 321:{f.StackOp("dup");f.Pc=322;continue;}
case 322:{f.Push(JValue.I(46));f.Pc=324;continue;}
case 324:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBecomeMonarch","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantBecomeMonarch","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=327;continue;}
case 327:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=328;continue;}
case 328:{f.StackOp("dup");f.Pc=329;continue;}
case 329:{f.Push(JValue.I(47));f.Pc=331;continue;}
case 331:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantGainControl","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantGainControl","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=334;continue;}
case 334:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=335;continue;}
case 335:{f.StackOp("dup");f.Pc=336;continue;}
case 336:{f.Push(JValue.I(48));f.Pc=338;continue;}
case 338:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantAttach","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantAttach","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=341;continue;}
case 341:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=342;continue;}
case 342:{f.StackOp("dup");f.Pc=343;continue;}
case 343:{f.Push(JValue.I(49));f.Pc=345;continue;}
case 345:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantCrew","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantCrew","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=348;continue;}
case 348:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=349;continue;}
case 349:{f.StackOp("dup");f.Pc=350;continue;}
case 350:{f.Push(JValue.I(50));f.Pc=352;continue;}
case 352:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantDraw","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantDraw","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=355;continue;}
case 355:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=356;continue;}
case 356:{f.StackOp("dup");f.Pc=357;continue;}
case 357:{f.Push(JValue.I(51));f.Pc=359;continue;}
case 359:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","DrawFromBottom","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","DrawFromBottom","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=362;continue;}
case 362:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=363;continue;}
case 363:{f.StackOp("dup");f.Pc=364;continue;}
case 364:{f.Push(JValue.I(52));f.Pc=366;continue;}
case 366:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantDiscard","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantDiscard","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=369;continue;}
case 369:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=370;continue;}
case 370:{f.StackOp("dup");f.Pc=371;continue;}
case 371:{f.Push(JValue.I(53));f.Pc=373;continue;}
case 373:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantExile","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantExile","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=376;continue;}
case 376:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=377;continue;}
case 377:{f.StackOp("dup");f.Pc=378;continue;}
case 378:{f.Push(JValue.I(54));f.Pc=380;continue;}
case 380:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPhaseIn","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantPhaseIn","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=383;continue;}
case 383:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=384;continue;}
case 384:{f.StackOp("dup");f.Pc=385;continue;}
case 385:{f.Push(JValue.I(55));f.Pc=387;continue;}
case 387:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPhaseOut","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantPhaseOut","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=390;continue;}
case 390:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=391;continue;}
case 391:{f.StackOp("dup");f.Pc=392;continue;}
case 392:{f.Push(JValue.I(56));f.Pc=394;continue;}
case 394:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPreventDamage","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantPreventDamage","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=397;continue;}
case 397:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=398;continue;}
case 398:{f.StackOp("dup");f.Pc=399;continue;}
case 399:{f.Push(JValue.I(57));f.Pc=401;continue;}
case 401:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPutCounter","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantPutCounter","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=404;continue;}
case 404:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=405;continue;}
case 405:{f.StackOp("dup");f.Pc=406;continue;}
case 406:{f.Push(JValue.I(58));f.Pc=408;continue;}
case 408:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantRegenerate","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantRegenerate","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=411;continue;}
case 411:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=412;continue;}
case 412:{f.StackOp("dup");f.Pc=413;continue;}
case 413:{f.Push(JValue.I(59));f.Pc=415;continue;}
case 415:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantSacrifice","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantSacrifice","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=418;continue;}
case 418:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=419;continue;}
case 419:{f.StackOp("dup");f.Pc=420;continue;}
case 420:{f.Push(JValue.I(60));f.Pc=422;continue;}
case 422:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantTarget","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantTarget","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=425;continue;}
case 425:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=426;continue;}
case 426:{f.StackOp("dup");f.Pc=427;continue;}
case 427:{f.Push(JValue.I(61));f.Pc=429;continue;}
case 429:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantTransform","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantTransform","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=432;continue;}
case 432:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=433;continue;}
case 433:{f.StackOp("dup");f.Pc=434;continue;}
case 434:{f.Push(JValue.I(62));f.Pc=436;continue;}
case 436:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantVenture","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantVenture","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=439;continue;}
case 439:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=440;continue;}
case 440:{f.StackOp("dup");f.Pc=441;continue;}
case 441:{f.Push(JValue.I(63));f.Pc=443;continue;}
case 443:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantChangeDayTime","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantChangeDayTime","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=446;continue;}
case 446:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=447;continue;}
case 447:{f.StackOp("dup");f.Pc=448;continue;}
case 448:{f.Push(JValue.I(64));f.Pc=450;continue;}
case 450:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ActivateAbilityAsIfHaste","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","ActivateAbilityAsIfHaste","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=453;continue;}
case 453:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=454;continue;}
case 454:{f.StackOp("dup");f.Pc=455;continue;}
case 455:{f.Push(JValue.I(65));f.Pc=457;continue;}
case 457:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CastWithFlash","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CastWithFlash","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=460;continue;}
case 460:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=461;continue;}
case 461:{f.StackOp("dup");f.Pc=462;continue;}
case 462:{f.Push(JValue.I(66));f.Pc=464;continue;}
case 464:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","IgnoreLandwalk","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","IgnoreLandwalk","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=467;continue;}
case 467:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=468;continue;}
case 468:{f.StackOp("dup");f.Pc=469;continue;}
case 469:{f.Push(JValue.I(67));f.Pc=471;continue;}
case 471:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","IgnoreLegendRule","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","IgnoreLegendRule","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=474;continue;}
case 474:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=475;continue;}
case 475:{f.StackOp("dup");f.Pc=476;continue;}
case 476:{f.Push(JValue.I(68));f.Pc=478;continue;}
case 478:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","IgnorePlaneswalkerZeroLoyaltyRule","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","IgnorePlaneswalkerZeroLoyaltyRule","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=481;continue;}
case 481:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=482;continue;}
case 482:{f.StackOp("dup");f.Pc=483;continue;}
case 483:{f.Push(JValue.I(69));f.Pc=485;continue;}
case 485:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MaxCounter","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","MaxCounter","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=488;continue;}
case 488:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=489;continue;}
case 489:{f.StackOp("dup");f.Pc=490;continue;}
case 490:{f.Push(JValue.I(70));f.Pc=492;continue;}
case 492:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","InfectDamage","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","InfectDamage","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=495;continue;}
case 495:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=496;continue;}
case 496:{f.StackOp("dup");f.Pc=497;continue;}
case 497:{f.Push(JValue.I(71));f.Pc=499;continue;}
case 499:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","WitherDamage","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","WitherDamage","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=502;continue;}
case 502:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=503;continue;}
case 503:{f.StackOp("dup");f.Pc=504;continue;}
case 504:{f.Push(JValue.I(72));f.Pc=506;continue;}
case 506:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","FlipCoinMod","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","FlipCoinMod","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=509;continue;}
case 509:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=510;continue;}
case 510:{f.StackOp("dup");f.Pc=511;continue;}
case 511:{f.Push(JValue.I(73));f.Pc=513;continue;}
case 513:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","FlipCoinDoubler","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","FlipCoinDoubler","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=516;continue;}
case 516:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=517;continue;}
case 517:{f.StackOp("dup");f.Pc=518;continue;}
case 518:{f.Push(JValue.I(74));f.Pc=520;continue;}
case 520:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","PlotZone","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","PlotZone","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=523;continue;}
case 523:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=524;continue;}
case 524:{f.StackOp("dup");f.Pc=525;continue;}
case 525:{f.Push(JValue.I(75));f.Pc=527;continue;}
case 527:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ForetellAnyTurn","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","ForetellAnyTurn","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=530;continue;}
case 530:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=531;continue;}
case 531:{f.StackOp("dup");f.Pc=532;continue;}
case 532:{f.Push(JValue.I(76));f.Pc=534;continue;}
case 534:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","NumLoyaltyAct","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","NumLoyaltyAct","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=537;continue;}
case 537:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=538;continue;}
case 538:{f.StackOp("dup");f.Pc=539;continue;}
case 539:{f.Push(JValue.I(77));f.Pc=541;continue;}
case 541:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Activations","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","Activations","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=544;continue;}
case 544:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=545;continue;}
case 545:{f.StackOp("dup");f.Pc=546;continue;}
case 546:{f.Push(JValue.I(78));f.Pc=548;continue;}
case 548:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Devotion","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","Devotion","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=551;continue;}
case 551:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=552;continue;}
case 552:{f.StackOp("dup");f.Pc=553;continue;}
case 553:{f.Push(JValue.I(79));f.Pc=555;continue;}
case 555:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","GainLifeRadiation","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","GainLifeRadiation","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=558;continue;}
case 558:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=559;continue;}
case 559:{f.StackOp("dup");f.Pc=560;continue;}
case 560:{f.Push(JValue.I(80));f.Pc=562;continue;}
case 562:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","SurveilNum","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","SurveilNum","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=565;continue;}
case 565:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=566;continue;}
case 566:{f.StackOp("dup");f.Pc=567;continue;}
case 567:{f.Push(JValue.I(81));f.Pc=569;continue;}
case 569:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","TapPowerValue","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","TapPowerValue","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=572;continue;}
case 572:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=573;continue;}
case 573:{f.StackOp("dup");f.Pc=574;continue;}
case 574:{f.Push(JValue.I(82));f.Pc=576;continue;}
case 576:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","UnspentMana","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","UnspentMana","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=579;continue;}
case 579:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=580;continue;}
case 580:{f.StackOp("dup");f.Pc=581;continue;}
case 581:{f.Push(JValue.I(83));f.Pc=583;continue;}
case 583:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ManaBurn","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","ManaBurn","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=586;continue;}
case 586:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=587;continue;}
case 587:{f.StackOp("dup");f.Pc=588;continue;}
case 588:{f.Push(JValue.I(84));f.Pc=590;continue;}
case 590:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ManaConvert","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","ManaConvert","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=593;continue;}
case 593:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=594;continue;}
case 594:{f.StackOp("dup");f.Pc=595;continue;}
case 595:{f.Push(JValue.I(85));f.Pc=597;continue;}
case 597:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","UntapOtherPlayer","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","UntapOtherPlayer","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=600;continue;}
case 600:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=601;continue;}
case 601:{f.StackOp("dup");f.Pc=602;continue;}
case 602:{f.Push(JValue.I(86));f.Pc=604;continue;}
case 604:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","TurnReversed","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","TurnReversed","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=607;continue;}
case 607:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=608;continue;}
case 608:{f.StackOp("dup");f.Pc=609;continue;}
case 609:{f.Push(JValue.I(87));f.Pc=611;continue;}
case 611:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","PhaseReversed","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","PhaseReversed","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=614;continue;}
case 614:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=615;continue;}
case 615:{f.StackOp("dup");f.Pc=616;continue;}
case 616:{f.Push(JValue.I(88));f.Pc=618;continue;}
case 618:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AttackRequirement","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","AttackRequirement","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=621;continue;}
case 621:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=622;continue;}
case 622:{f.StackOp("dup");f.Pc=623;continue;}
case 623:{f.Push(JValue.I(89));f.Pc=625;continue;}
case 625:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CountersRemain","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CountersRemain","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=628;continue;}
case 628:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=629;continue;}
case 629:{f.StackOp("dup");f.Pc=630;continue;}
case 630:{f.Push(JValue.I(90));f.Pc=632;continue;}
case 632:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ManaRestriction","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","ManaRestriction","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=635;continue;}
case 635:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=636;continue;}
case 636:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10062(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Continuous")));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",11);}
case 11:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("CantAttackUnless")));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",25);}
case 25:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantAttackUnless","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantAttackUnless","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=28;continue;}
case 28:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("CantBlockUnless")));f.Pc=35;continue;}
case 35:{f.Push(JValue.I(2));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",39);}
case 39:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBlockUnless","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantBlockUnless","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=42;continue;}
case 42:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=45;continue;}
case 45:{f.StackOp("dup");f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("OptionalAttackCost")));f.Pc=49;continue;}
case 49:{f.Push(JValue.I(3));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",53);}
case 53:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","OptionalAttackCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","OptionalAttackCost","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=56;continue;}
case 56:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=59;continue;}
case 59:{f.StackOp("dup");f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("OptionalCost")));f.Pc=63;continue;}
case 63:{f.Push(JValue.I(4));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",67);}
case 67:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","OptionalCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","OptionalCost","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=70;continue;}
case 70:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=73;continue;}
case 73:{f.StackOp("dup");f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("AlternativeCost")));f.Pc=77;continue;}
case 77:{f.Push(JValue.I(5));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",81);}
case 81:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AlternativeCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","AlternativeCost","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=84;continue;}
case 84:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=87;continue;}
case 87:{f.StackOp("dup");f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("CantBeCast")));f.Pc=91;continue;}
case 91:{f.Push(JValue.I(6));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",96);}
case 96:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBeCast","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantBeCast","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=99;continue;}
case 99:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=102;continue;}
case 102:{f.StackOp("dup");f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("CantBeActivated")));f.Pc=106;continue;}
case 106:{f.Push(JValue.I(7));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",111);}
case 111:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBeActivated","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantBeActivated","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=114;continue;}
case 114:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=117;continue;}
case 117:{f.StackOp("dup");f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("CantPlayLand")));f.Pc=121;continue;}
case 121:{f.Push(JValue.I(8));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",126);}
case 126:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPlayLand","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantPlayLand","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=129;continue;}
case 129:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=132;continue;}
case 132:{f.StackOp("dup");f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("DisableTriggers")));f.Pc=136;continue;}
case 136:{f.Push(JValue.I(9));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",141);}
case 141:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","DisableTriggers","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","DisableTriggers","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=144;continue;}
case 144:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=147;continue;}
case 147:{f.StackOp("dup");f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String("Panharmonicon")));f.Pc=151;continue;}
case 151:{f.Push(JValue.I(10));f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",156);}
case 156:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Panharmonicon","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","Panharmonicon","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=159;continue;}
case 159:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=162;continue;}
case 162:{f.StackOp("dup");f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String("MustTarget")));f.Pc=166;continue;}
case 166:{f.Push(JValue.I(11));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",171);}
case 171:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MustTarget","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","MustTarget","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=174;continue;}
case 174:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=177;continue;}
case 177:{f.StackOp("dup");f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("CantAttack")));f.Pc=181;continue;}
case 181:{f.Push(JValue.I(12));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",186);}
case 186:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantAttack","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantAttack","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=189;continue;}
case 189:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=192;continue;}
case 192:{f.StackOp("dup");f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.String("CanAttackDefender")));f.Pc=196;continue;}
case 196:{f.Push(JValue.I(13));f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",201);}
case 201:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CanAttackDefender","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CanAttackDefender","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=204;continue;}
case 204:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=207;continue;}
case 207:{f.StackOp("dup");f.Pc=208;continue;}
case 208:{f.Push(JValue.R(rt.String("CantBlock")));f.Pc=211;continue;}
case 211:{f.Push(JValue.I(14));f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",216);}
case 216:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBlock","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantBlock","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=219;continue;}
case 219:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=222;continue;}
case 222:{f.StackOp("dup");f.Pc=223;continue;}
case 223:{f.Push(JValue.R(rt.String("CantBlockBy")));f.Pc=226;continue;}
case 226:{f.Push(JValue.I(15));f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",231);}
case 231:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBlockBy","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantBlockBy","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=234;continue;}
case 234:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=237;continue;}
case 237:{f.StackOp("dup");f.Pc=238;continue;}
case 238:{f.Push(JValue.R(rt.String("CanAttackIfHaste")));f.Pc=241;continue;}
case 241:{f.Push(JValue.I(16));f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",246);}
case 246:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CanAttackIfHaste","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CanAttackIfHaste","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=249;continue;}
case 249:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=252;continue;}
case 252:{f.StackOp("dup");f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.String("CanBlockIfReach")));f.Pc=256;continue;}
case 256:{f.Push(JValue.I(17));f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",261);}
case 261:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CanBlockIfReach","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CanBlockIfReach","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=264;continue;}
case 264:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=267;continue;}
case 267:{f.StackOp("dup");f.Pc=268;continue;}
case 268:{f.Push(JValue.R(rt.String("CanBlockIfShadow")));f.Pc=271;continue;}
case 271:{f.Push(JValue.I(18));f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",276);}
case 276:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CanBlockIfShadow","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CanBlockIfShadow","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=279;continue;}
case 279:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=282;continue;}
case 282:{f.StackOp("dup");f.Pc=283;continue;}
case 283:{f.Push(JValue.R(rt.String("MinMaxBlocker")));f.Pc=286;continue;}
case 286:{f.Push(JValue.I(19));f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",291);}
case 291:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MinMaxBlocker","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","MinMaxBlocker","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=294;continue;}
case 294:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=297;continue;}
case 297:{f.StackOp("dup");f.Pc=298;continue;}
case 298:{f.Push(JValue.R(rt.String("BlockTapped")));f.Pc=301;continue;}
case 301:{f.Push(JValue.I(20));f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",306);}
case 306:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","BlockTapped","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","BlockTapped","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=309;continue;}
case 309:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=312;continue;}
case 312:{f.StackOp("dup");f.Pc=313;continue;}
case 313:{f.Push(JValue.R(rt.String("AttackVigilance")));f.Pc=316;continue;}
case 316:{f.Push(JValue.I(21));f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",321);}
case 321:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AttackVigilance","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","AttackVigilance","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=324;continue;}
case 324:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=327;continue;}
case 327:{f.StackOp("dup");f.Pc=328;continue;}
case 328:{f.Push(JValue.R(rt.String("MustAttack")));f.Pc=331;continue;}
case 331:{f.Push(JValue.I(22));f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",336);}
case 336:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MustAttack","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","MustAttack","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=339;continue;}
case 339:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=342;continue;}
case 342:{f.StackOp("dup");f.Pc=343;continue;}
case 343:{f.Push(JValue.R(rt.String("PlayerMustAttack")));f.Pc=346;continue;}
case 346:{f.Push(JValue.I(23));f.Pc=348;continue;}
case 348:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",351);}
case 351:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","PlayerMustAttack","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","PlayerMustAttack","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=354;continue;}
case 354:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=357;continue;}
case 357:{f.StackOp("dup");f.Pc=358;continue;}
case 358:{f.Push(JValue.R(rt.String("MustBlock")));f.Pc=361;continue;}
case 361:{f.Push(JValue.I(24));f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",366);}
case 366:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MustBlock","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","MustBlock","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=369;continue;}
case 369:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=372;continue;}
case 372:{f.StackOp("dup");f.Pc=373;continue;}
case 373:{f.Push(JValue.R(rt.String("AssignCombatDamageAsUnblocked")));f.Pc=376;continue;}
case 376:{f.Push(JValue.I(25));f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",381);}
case 381:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AssignCombatDamageAsUnblocked","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","AssignCombatDamageAsUnblocked","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=384;continue;}
case 384:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=387;continue;}
case 387:{f.StackOp("dup");f.Pc=388;continue;}
case 388:{f.Push(JValue.R(rt.String("CombatDamageToughness")));f.Pc=391;continue;}
case 391:{f.Push(JValue.I(26));f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",396);}
case 396:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CombatDamageToughness","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CombatDamageToughness","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=399;continue;}
case 399:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=402;continue;}
case 402:{f.StackOp("dup");f.Pc=403;continue;}
case 403:{f.Push(JValue.R(rt.String("CombatDamageNegatePower")));f.Pc=406;continue;}
case 406:{f.Push(JValue.I(27));f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",411);}
case 411:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CombatDamageNegatePower","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CombatDamageNegatePower","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=414;continue;}
case 414:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=417;continue;}
case 417:{f.StackOp("dup");f.Pc=418;continue;}
case 418:{f.Push(JValue.R(rt.String("ColorlessDamageSource")));f.Pc=421;continue;}
case 421:{f.Push(JValue.I(28));f.Pc=423;continue;}
case 423:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",426);}
case 426:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ColorlessDamageSource","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","ColorlessDamageSource","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=429;continue;}
case 429:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=432;continue;}
case 432:{f.StackOp("dup");f.Pc=433;continue;}
case 433:{f.Push(JValue.R(rt.String("NoCleanupDamage")));f.Pc=436;continue;}
case 436:{f.Push(JValue.I(29));f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",441);}
case 441:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","NoCleanupDamage","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","NoCleanupDamage","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=444;continue;}
case 444:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=447;continue;}
case 447:{f.StackOp("dup");f.Pc=448;continue;}
case 448:{f.Push(JValue.R(rt.String("BlockRestrict")));f.Pc=451;continue;}
case 451:{f.Push(JValue.I(30));f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",456);}
case 456:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","BlockRestrict","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","BlockRestrict","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=459;continue;}
case 459:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=462;continue;}
case 462:{f.StackOp("dup");f.Pc=463;continue;}
case 463:{f.Push(JValue.R(rt.String("CantGainLife")));f.Pc=466;continue;}
case 466:{f.Push(JValue.I(31));f.Pc=468;continue;}
case 468:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",471);}
case 471:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantGainLife","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantGainLife","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=474;continue;}
case 474:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=477;continue;}
case 477:{f.StackOp("dup");f.Pc=478;continue;}
case 478:{f.Push(JValue.R(rt.String("CantLoseLife")));f.Pc=481;continue;}
case 481:{f.Push(JValue.I(32));f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",486);}
case 486:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantLoseLife","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantLoseLife","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=489;continue;}
case 489:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=492;continue;}
case 492:{f.StackOp("dup");f.Pc=493;continue;}
case 493:{f.Push(JValue.R(rt.String("CantChangeLife")));f.Pc=496;continue;}
case 496:{f.Push(JValue.I(33));f.Pc=498;continue;}
case 498:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",501);}
case 501:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantChangeLife","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantChangeLife","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=504;continue;}
case 504:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=507;continue;}
case 507:{f.StackOp("dup");f.Pc=508;continue;}
case 508:{f.Push(JValue.R(rt.String("CantPayLife")));f.Pc=511;continue;}
case 511:{f.Push(JValue.I(34));f.Pc=513;continue;}
case 513:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",516);}
case 516:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPayLife","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantPayLife","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=519;continue;}
case 519:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=522;continue;}
case 522:{f.StackOp("dup");f.Pc=523;continue;}
case 523:{f.Push(JValue.R(rt.String("RaiseCost")));f.Pc=526;continue;}
case 526:{f.Push(JValue.I(35));f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",531);}
case 531:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","RaiseCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","RaiseCost","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=534;continue;}
case 534:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=537;continue;}
case 537:{f.StackOp("dup");f.Pc=538;continue;}
case 538:{f.Push(JValue.R(rt.String("ReduceCost")));f.Pc=541;continue;}
case 541:{f.Push(JValue.I(36));f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",546);}
case 546:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ReduceCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","ReduceCost","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=549;continue;}
case 549:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=552;continue;}
case 552:{f.StackOp("dup");f.Pc=553;continue;}
case 553:{f.Push(JValue.R(rt.String("SetCost")));f.Pc=556;continue;}
case 556:{f.Push(JValue.I(37));f.Pc=558;continue;}
case 558:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",561);}
case 561:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","SetCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","SetCost","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=564;continue;}
case 564:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=567;continue;}
case 567:{f.StackOp("dup");f.Pc=568;continue;}
case 568:{f.Push(JValue.R(rt.String("IgnoreHexproof")));f.Pc=571;continue;}
case 571:{f.Push(JValue.I(38));f.Pc=573;continue;}
case 573:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",576);}
case 576:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","IgnoreHexproof","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","IgnoreHexproof","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=579;continue;}
case 579:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=582;continue;}
case 582:{f.StackOp("dup");f.Pc=583;continue;}
case 583:{f.Push(JValue.R(rt.String("IgnoreShroud")));f.Pc=586;continue;}
case 586:{f.Push(JValue.I(39));f.Pc=588;continue;}
case 588:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",591);}
case 591:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","IgnoreShroud","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","IgnoreShroud","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=594;continue;}
case 594:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=597;continue;}
case 597:{f.StackOp("dup");f.Pc=598;continue;}
case 598:{f.Push(JValue.R(rt.String("AttackRestrict")));f.Pc=601;continue;}
case 601:{f.Push(JValue.I(40));f.Pc=603;continue;}
case 603:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",606);}
case 606:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AttackRestrict","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","AttackRestrict","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=609;continue;}
case 609:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=612;continue;}
case 612:{f.StackOp("dup");f.Pc=613;continue;}
case 613:{f.Push(JValue.R(rt.String("AssignNoCombatDamage")));f.Pc=616;continue;}
case 616:{f.Push(JValue.I(41));f.Pc=618;continue;}
case 618:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",621);}
case 621:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AssignNoCombatDamage","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","AssignNoCombatDamage","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=624;continue;}
case 624:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=627;continue;}
case 627:{f.StackOp("dup");f.Pc=628;continue;}
case 628:{f.Push(JValue.R(rt.String("CanAdapt")));f.Pc=631;continue;}
case 631:{f.Push(JValue.I(42));f.Pc=633;continue;}
case 633:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",636);}
case 636:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CanAdapt","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CanAdapt","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=639;continue;}
case 639:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=642;continue;}
case 642:{f.StackOp("dup");f.Pc=643;continue;}
case 643:{f.Push(JValue.R(rt.String("CantBeCopied")));f.Pc=646;continue;}
case 646:{f.Push(JValue.I(43));f.Pc=648;continue;}
case 648:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",651);}
case 651:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBeCopied","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantBeCopied","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=654;continue;}
case 654:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=657;continue;}
case 657:{f.StackOp("dup");f.Pc=658;continue;}
case 658:{f.Push(JValue.R(rt.String("CantBeBeamedUp")));f.Pc=661;continue;}
case 661:{f.Push(JValue.I(44));f.Pc=663;continue;}
case 663:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",666);}
case 666:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBeBeamedUp","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantBeBeamedUp","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=669;continue;}
case 669:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=672;continue;}
case 672:{f.StackOp("dup");f.Pc=673;continue;}
case 673:{f.Push(JValue.R(rt.String("CantBeSuspected")));f.Pc=676;continue;}
case 676:{f.Push(JValue.I(45));f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",681);}
case 681:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBeSuspected","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantBeSuspected","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=684;continue;}
case 684:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=687;continue;}
case 687:{f.StackOp("dup");f.Pc=688;continue;}
case 688:{f.Push(JValue.R(rt.String("CantBecomeMonarch")));f.Pc=691;continue;}
case 691:{f.Push(JValue.I(46));f.Pc=693;continue;}
case 693:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",696);}
case 696:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBecomeMonarch","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantBecomeMonarch","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=699;continue;}
case 699:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=702;continue;}
case 702:{f.StackOp("dup");f.Pc=703;continue;}
case 703:{f.Push(JValue.R(rt.String("CantGainControl")));f.Pc=706;continue;}
case 706:{f.Push(JValue.I(47));f.Pc=708;continue;}
case 708:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",711);}
case 711:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantGainControl","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantGainControl","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=714;continue;}
case 714:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=717;continue;}
case 717:{f.StackOp("dup");f.Pc=718;continue;}
case 718:{f.Push(JValue.R(rt.String("CantAttach")));f.Pc=721;continue;}
case 721:{f.Push(JValue.I(48));f.Pc=723;continue;}
case 723:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",726);}
case 726:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantAttach","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantAttach","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=729;continue;}
case 729:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=732;continue;}
case 732:{f.StackOp("dup");f.Pc=733;continue;}
case 733:{f.Push(JValue.R(rt.String("CantCrew")));f.Pc=736;continue;}
case 736:{f.Push(JValue.I(49));f.Pc=738;continue;}
case 738:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",741);}
case 741:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantCrew","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantCrew","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=744;continue;}
case 744:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=747;continue;}
case 747:{f.StackOp("dup");f.Pc=748;continue;}
case 748:{f.Push(JValue.R(rt.String("CantDraw")));f.Pc=751;continue;}
case 751:{f.Push(JValue.I(50));f.Pc=753;continue;}
case 753:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",756);}
case 756:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantDraw","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantDraw","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=759;continue;}
case 759:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=762;continue;}
case 762:{f.StackOp("dup");f.Pc=763;continue;}
case 763:{f.Push(JValue.R(rt.String("DrawFromBottom")));f.Pc=766;continue;}
case 766:{f.Push(JValue.I(51));f.Pc=768;continue;}
case 768:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",771);}
case 771:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","DrawFromBottom","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","DrawFromBottom","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=774;continue;}
case 774:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=777;continue;}
case 777:{f.StackOp("dup");f.Pc=778;continue;}
case 778:{f.Push(JValue.R(rt.String("CantDiscard")));f.Pc=781;continue;}
case 781:{f.Push(JValue.I(52));f.Pc=783;continue;}
case 783:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",786);}
case 786:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantDiscard","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantDiscard","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=789;continue;}
case 789:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=792;continue;}
case 792:{f.StackOp("dup");f.Pc=793;continue;}
case 793:{f.Push(JValue.R(rt.String("CantExile")));f.Pc=796;continue;}
case 796:{f.Push(JValue.I(53));f.Pc=798;continue;}
case 798:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",801);}
case 801:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantExile","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantExile","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=804;continue;}
case 804:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=807;continue;}
case 807:{f.StackOp("dup");f.Pc=808;continue;}
case 808:{f.Push(JValue.R(rt.String("CantPhaseIn")));f.Pc=811;continue;}
case 811:{f.Push(JValue.I(54));f.Pc=813;continue;}
case 813:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",816);}
case 816:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPhaseIn","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantPhaseIn","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=819;continue;}
case 819:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=822;continue;}
case 822:{f.StackOp("dup");f.Pc=823;continue;}
case 823:{f.Push(JValue.R(rt.String("CantPhaseOut")));f.Pc=826;continue;}
case 826:{f.Push(JValue.I(55));f.Pc=828;continue;}
case 828:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",831);}
case 831:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPhaseOut","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantPhaseOut","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=834;continue;}
case 834:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=837;continue;}
case 837:{f.StackOp("dup");f.Pc=838;continue;}
case 838:{f.Push(JValue.R(rt.String("CantPreventDamage")));f.Pc=841;continue;}
case 841:{f.Push(JValue.I(56));f.Pc=843;continue;}
case 843:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",846);}
case 846:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPreventDamage","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantPreventDamage","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=849;continue;}
case 849:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=852;continue;}
case 852:{f.StackOp("dup");f.Pc=853;continue;}
case 853:{f.Push(JValue.R(rt.String("CantPutCounter")));f.Pc=856;continue;}
case 856:{f.Push(JValue.I(57));f.Pc=858;continue;}
case 858:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",861);}
case 861:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPutCounter","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantPutCounter","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=864;continue;}
case 864:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=867;continue;}
case 867:{f.StackOp("dup");f.Pc=868;continue;}
case 868:{f.Push(JValue.R(rt.String("CantRegenerate")));f.Pc=871;continue;}
case 871:{f.Push(JValue.I(58));f.Pc=873;continue;}
case 873:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",876);}
case 876:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantRegenerate","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantRegenerate","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=879;continue;}
case 879:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=882;continue;}
case 882:{f.StackOp("dup");f.Pc=883;continue;}
case 883:{f.Push(JValue.R(rt.String("CantSacrifice")));f.Pc=886;continue;}
case 886:{f.Push(JValue.I(59));f.Pc=888;continue;}
case 888:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",891);}
case 891:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantSacrifice","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantSacrifice","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=894;continue;}
case 894:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=897;continue;}
case 897:{f.StackOp("dup");f.Pc=898;continue;}
case 898:{f.Push(JValue.R(rt.String("CantTarget")));f.Pc=901;continue;}
case 901:{f.Push(JValue.I(60));f.Pc=903;continue;}
case 903:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",906);}
case 906:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantTarget","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantTarget","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=909;continue;}
case 909:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=912;continue;}
case 912:{f.StackOp("dup");f.Pc=913;continue;}
case 913:{f.Push(JValue.R(rt.String("CantTransform")));f.Pc=916;continue;}
case 916:{f.Push(JValue.I(61));f.Pc=918;continue;}
case 918:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",921);}
case 921:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantTransform","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantTransform","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=924;continue;}
case 924:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=927;continue;}
case 927:{f.StackOp("dup");f.Pc=928;continue;}
case 928:{f.Push(JValue.R(rt.String("CantVenture")));f.Pc=931;continue;}
case 931:{f.Push(JValue.I(62));f.Pc=933;continue;}
case 933:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",936);}
case 936:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantVenture","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantVenture","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=939;continue;}
case 939:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=942;continue;}
case 942:{f.StackOp("dup");f.Pc=943;continue;}
case 943:{f.Push(JValue.R(rt.String("CantChangeDayTime")));f.Pc=946;continue;}
case 946:{f.Push(JValue.I(63));f.Pc=948;continue;}
case 948:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",951);}
case 951:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantChangeDayTime","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CantChangeDayTime","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=954;continue;}
case 954:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=957;continue;}
case 957:{f.StackOp("dup");f.Pc=958;continue;}
case 958:{f.Push(JValue.R(rt.String("ActivateAbilityAsIfHaste")));f.Pc=961;continue;}
case 961:{f.Push(JValue.I(64));f.Pc=963;continue;}
case 963:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",966);}
case 966:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ActivateAbilityAsIfHaste","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","ActivateAbilityAsIfHaste","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=969;continue;}
case 969:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=972;continue;}
case 972:{f.StackOp("dup");f.Pc=973;continue;}
case 973:{f.Push(JValue.R(rt.String("CastWithFlash")));f.Pc=976;continue;}
case 976:{f.Push(JValue.I(65));f.Pc=978;continue;}
case 978:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",981);}
case 981:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CastWithFlash","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CastWithFlash","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=984;continue;}
case 984:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=987;continue;}
case 987:{f.StackOp("dup");f.Pc=988;continue;}
case 988:{f.Push(JValue.R(rt.String("IgnoreLandwalk")));f.Pc=991;continue;}
case 991:{f.Push(JValue.I(66));f.Pc=993;continue;}
case 993:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",996);}
case 996:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","IgnoreLandwalk","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","IgnoreLandwalk","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=999;continue;}
case 999:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1002;continue;}
case 1002:{f.StackOp("dup");f.Pc=1003;continue;}
case 1003:{f.Push(JValue.R(rt.String("IgnoreLegendRule")));f.Pc=1006;continue;}
case 1006:{f.Push(JValue.I(67));f.Pc=1008;continue;}
case 1008:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1011);}
case 1011:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","IgnoreLegendRule","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","IgnoreLegendRule","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1014;continue;}
case 1014:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1017;continue;}
case 1017:{f.StackOp("dup");f.Pc=1018;continue;}
case 1018:{f.Push(JValue.R(rt.String("IgnorePlaneswalkerZeroLoyaltyRule")));f.Pc=1021;continue;}
case 1021:{f.Push(JValue.I(68));f.Pc=1023;continue;}
case 1023:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1026);}
case 1026:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","IgnorePlaneswalkerZeroLoyaltyRule","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","IgnorePlaneswalkerZeroLoyaltyRule","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1029;continue;}
case 1029:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1032;continue;}
case 1032:{f.StackOp("dup");f.Pc=1033;continue;}
case 1033:{f.Push(JValue.R(rt.String("MaxCounter")));f.Pc=1036;continue;}
case 1036:{f.Push(JValue.I(69));f.Pc=1038;continue;}
case 1038:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1041);}
case 1041:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MaxCounter","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","MaxCounter","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1044;continue;}
case 1044:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1047;continue;}
case 1047:{f.StackOp("dup");f.Pc=1048;continue;}
case 1048:{f.Push(JValue.R(rt.String("InfectDamage")));f.Pc=1051;continue;}
case 1051:{f.Push(JValue.I(70));f.Pc=1053;continue;}
case 1053:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1056);}
case 1056:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","InfectDamage","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","InfectDamage","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1059;continue;}
case 1059:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1062;continue;}
case 1062:{f.StackOp("dup");f.Pc=1063;continue;}
case 1063:{f.Push(JValue.R(rt.String("WitherDamage")));f.Pc=1066;continue;}
case 1066:{f.Push(JValue.I(71));f.Pc=1068;continue;}
case 1068:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1071);}
case 1071:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","WitherDamage","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","WitherDamage","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1074;continue;}
case 1074:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1077;continue;}
case 1077:{f.StackOp("dup");f.Pc=1078;continue;}
case 1078:{f.Push(JValue.R(rt.String("FlipCoinMod")));f.Pc=1081;continue;}
case 1081:{f.Push(JValue.I(72));f.Pc=1083;continue;}
case 1083:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1086);}
case 1086:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","FlipCoinMod","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","FlipCoinMod","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1089;continue;}
case 1089:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1092;continue;}
case 1092:{f.StackOp("dup");f.Pc=1093;continue;}
case 1093:{f.Push(JValue.R(rt.String("FlipCoinDoubler")));f.Pc=1096;continue;}
case 1096:{f.Push(JValue.I(73));f.Pc=1098;continue;}
case 1098:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1101);}
case 1101:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","FlipCoinDoubler","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","FlipCoinDoubler","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1104;continue;}
case 1104:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1107;continue;}
case 1107:{f.StackOp("dup");f.Pc=1108;continue;}
case 1108:{f.Push(JValue.R(rt.String("PlotZone")));f.Pc=1111;continue;}
case 1111:{f.Push(JValue.I(74));f.Pc=1113;continue;}
case 1113:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1116);}
case 1116:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","PlotZone","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","PlotZone","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1119;continue;}
case 1119:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1122;continue;}
case 1122:{f.StackOp("dup");f.Pc=1123;continue;}
case 1123:{f.Push(JValue.R(rt.String("ForetellAnyTurn")));f.Pc=1126;continue;}
case 1126:{f.Push(JValue.I(75));f.Pc=1128;continue;}
case 1128:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1131);}
case 1131:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ForetellAnyTurn","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","ForetellAnyTurn","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1134;continue;}
case 1134:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1137;continue;}
case 1137:{f.StackOp("dup");f.Pc=1138;continue;}
case 1138:{f.Push(JValue.R(rt.String("NumLoyaltyAct")));f.Pc=1141;continue;}
case 1141:{f.Push(JValue.I(76));f.Pc=1143;continue;}
case 1143:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1146);}
case 1146:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","NumLoyaltyAct","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","NumLoyaltyAct","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1149;continue;}
case 1149:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1152;continue;}
case 1152:{f.StackOp("dup");f.Pc=1153;continue;}
case 1153:{f.Push(JValue.R(rt.String("Activations")));f.Pc=1156;continue;}
case 1156:{f.Push(JValue.I(77));f.Pc=1158;continue;}
case 1158:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1161);}
case 1161:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Activations","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","Activations","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1164;continue;}
case 1164:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1167;continue;}
case 1167:{f.StackOp("dup");f.Pc=1168;continue;}
case 1168:{f.Push(JValue.R(rt.String("Devotion")));f.Pc=1171;continue;}
case 1171:{f.Push(JValue.I(78));f.Pc=1173;continue;}
case 1173:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1176);}
case 1176:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Devotion","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","Devotion","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1179;continue;}
case 1179:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1182;continue;}
case 1182:{f.StackOp("dup");f.Pc=1183;continue;}
case 1183:{f.Push(JValue.R(rt.String("GainLifeRadiation")));f.Pc=1186;continue;}
case 1186:{f.Push(JValue.I(79));f.Pc=1188;continue;}
case 1188:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1191);}
case 1191:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","GainLifeRadiation","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","GainLifeRadiation","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1194;continue;}
case 1194:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1197;continue;}
case 1197:{f.StackOp("dup");f.Pc=1198;continue;}
case 1198:{f.Push(JValue.R(rt.String("SurveilNum")));f.Pc=1201;continue;}
case 1201:{f.Push(JValue.I(80));f.Pc=1203;continue;}
case 1203:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1206);}
case 1206:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","SurveilNum","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","SurveilNum","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1209;continue;}
case 1209:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1212;continue;}
case 1212:{f.StackOp("dup");f.Pc=1213;continue;}
case 1213:{f.Push(JValue.R(rt.String("TapPowerValue")));f.Pc=1216;continue;}
case 1216:{f.Push(JValue.I(81));f.Pc=1218;continue;}
case 1218:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1221);}
case 1221:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","TapPowerValue","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","TapPowerValue","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1224;continue;}
case 1224:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1227;continue;}
case 1227:{f.StackOp("dup");f.Pc=1228;continue;}
case 1228:{f.Push(JValue.R(rt.String("UnspentMana")));f.Pc=1231;continue;}
case 1231:{f.Push(JValue.I(82));f.Pc=1233;continue;}
case 1233:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1236);}
case 1236:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","UnspentMana","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","UnspentMana","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1239;continue;}
case 1239:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1242;continue;}
case 1242:{f.StackOp("dup");f.Pc=1243;continue;}
case 1243:{f.Push(JValue.R(rt.String("ManaBurn")));f.Pc=1246;continue;}
case 1246:{f.Push(JValue.I(83));f.Pc=1248;continue;}
case 1248:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1251);}
case 1251:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ManaBurn","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","ManaBurn","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1254;continue;}
case 1254:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1257;continue;}
case 1257:{f.StackOp("dup");f.Pc=1258;continue;}
case 1258:{f.Push(JValue.R(rt.String("ManaConvert")));f.Pc=1261;continue;}
case 1261:{f.Push(JValue.I(84));f.Pc=1263;continue;}
case 1263:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1266);}
case 1266:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ManaConvert","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","ManaConvert","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1269;continue;}
case 1269:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1272;continue;}
case 1272:{f.StackOp("dup");f.Pc=1273;continue;}
case 1273:{f.Push(JValue.R(rt.String("UntapOtherPlayer")));f.Pc=1276;continue;}
case 1276:{f.Push(JValue.I(85));f.Pc=1278;continue;}
case 1278:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1281);}
case 1281:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","UntapOtherPlayer","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","UntapOtherPlayer","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1284;continue;}
case 1284:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1287;continue;}
case 1287:{f.StackOp("dup");f.Pc=1288;continue;}
case 1288:{f.Push(JValue.R(rt.String("TurnReversed")));f.Pc=1291;continue;}
case 1291:{f.Push(JValue.I(86));f.Pc=1293;continue;}
case 1293:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1296);}
case 1296:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","TurnReversed","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","TurnReversed","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1299;continue;}
case 1299:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1302;continue;}
case 1302:{f.StackOp("dup");f.Pc=1303;continue;}
case 1303:{f.Push(JValue.R(rt.String("PhaseReversed")));f.Pc=1306;continue;}
case 1306:{f.Push(JValue.I(87));f.Pc=1308;continue;}
case 1308:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1311);}
case 1311:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","PhaseReversed","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","PhaseReversed","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1314;continue;}
case 1314:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1317;continue;}
case 1317:{f.StackOp("dup");f.Pc=1318;continue;}
case 1318:{f.Push(JValue.R(rt.String("AttackRequirement")));f.Pc=1321;continue;}
case 1321:{f.Push(JValue.I(88));f.Pc=1323;continue;}
case 1323:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1326);}
case 1326:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AttackRequirement","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","AttackRequirement","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1329;continue;}
case 1329:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1332;continue;}
case 1332:{f.StackOp("dup");f.Pc=1333;continue;}
case 1333:{f.Push(JValue.R(rt.String("CountersRemain")));f.Pc=1336;continue;}
case 1336:{f.Push(JValue.I(89));f.Pc=1338;continue;}
case 1338:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1341);}
case 1341:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CountersRemain","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","CountersRemain","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1344;continue;}
case 1344:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityMode"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityMode")));f.Pc=1347;continue;}
case 1347:{f.StackOp("dup");f.Pc=1348;continue;}
case 1348:{f.Push(JValue.R(rt.String("ManaRestriction")));f.Pc=1351;continue;}
case 1351:{f.Push(JValue.I(90));f.Pc=1353;continue;}
case 1353:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","<init>","(Ljava/lang/String;I)V","invokespecial",1356);}
case 1356:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ManaRestriction","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","ManaRestriction","Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1359;continue;}
case 1359:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","$values","()[Lforge/game/staticability/StaticAbilityMode;","invokestatic",1362);}
case 1362:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","$VALUES","[Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbilityMode","$VALUES","[Lforge/game/staticability/StaticAbilityMode;",f.Pop());f.Pc=1365;continue;}
case 1365:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

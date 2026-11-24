// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C788{
internal static JClass Build(){var c=new JClass("forge/game/spellability/AbilityActivated","forge/game/spellability/SpellAbility",new string[]{"java/lang/Cloneable"},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9074,"forge/game/spellability/AbilityActivated","<init>","(Lforge/game/card/Card;Ljava/lang/String;)V",1,3,6,new JHandler[]{},M9074));
c.Add(new JMethod(9075,"forge/game/spellability/AbilityActivated","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V",1,4,3,new JHandler[]{},M9075));
c.Add(new JMethod(9076,"forge/game/spellability/AbilityActivated","isActivatedAbility","()Z",1,1,1,new JHandler[]{},M9076));
c.Add(new JMethod(9077,"forge/game/spellability/AbilityActivated","canPlay","()Z",1,4,3,new JHandler[]{},M9077));
c.Add(new JMethod(9078,"forge/game/spellability/AbilityActivated","checkRestrictions","(Lforge/game/card/Card;Lforge/game/player/Player;)Z",1,3,3,new JHandler[]{},M9078));
c.Add(new JMethod(9079,"forge/game/spellability/AbilityActivated","isPossible","()Z",1,1,3,new JHandler[]{},M9079));
c.Add(new JMethod(9080,"forge/game/spellability/AbilityActivated","promptIfOnlyPossibleAbility","()Z",1,1,1,new JHandler[]{},M9080));
c.Add(new JMethod(9081,"forge/game/spellability/AbilityActivated","clone","()Ljava/lang/Object;",17,2,3,new JHandler[]{new JHandler(0,4,5,"java/lang/Exception")},M9081));
}

internal static JStep M9074(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",11);}
case 11:{f.Push(JValue.R(null));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/AbilityActivated","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;)V","invokespecial",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9075(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/AbilityActivated","setTargetRestrictions","(Lforge/game/spellability/TargetRestrictions;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9076(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilityActivated","isTrigger","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9077(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/cost/Cost","hasManaCost","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?29:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/cost/CostPartMana","getManaCostFor","(Lforge/game/spellability/SpellAbility;)Lforge/card/mana/ManaCost;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/card/mana/ManaCost","isNoCost","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?29:27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",33);}
case 33:{f.Locals[1]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Reference!=null?46:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getHostCard","()Lforge/game/card/Card;","invokevirtual",42);}
case 42:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",45);}
case 45:{f.Locals[1]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",50);}
case 50:{f.Locals[2]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/zone/MagicStack","isSplitSecondOnStack","()Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?70:61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/AbilityActivated","isManaAbility","()Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int!=0?70:68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getHostCard","()Lforge/game/card/Card;","invokevirtual",74);}
case 74:{f.Locals[3]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/spellability/AbilityActivated","isSuppressed","()Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?84:82;continue;}
case 82:{f.Push(JValue.I(0));f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/card/Card","isDetained","()Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?93:91;continue;}
case 91:{f.Push(JValue.I(0));f.Pc=92;continue;}
case 92:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",97);}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","canPlay","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int!=0?107:105;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",111);}
case 111:{if(!rt.StaticReady(f,"forge/game/player/PlayerController$FullControlFlag","AllowPaymentStartWithMissingResources","Lforge/game/player/PlayerController$FullControlFlag;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerController$FullControlFlag","AllowPaymentStartWithMissingResources","Lforge/game/player/PlayerController$FullControlFlag;"));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/player/PlayerController","isFullControl","(Lforge/game/player/PlayerController$FullControlFlag;)Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int!=0?132:120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",124);}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(JValue.I(0));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/cost/CostPayment","canPayAdditionalCosts","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Z","invokestatic",129);}
case 129:{f.Pc=f.Pop().Int==0?136:132;continue;}
case 132:{f.Push(JValue.I(1));f.Pc=133;continue;}
case 133:{f.Pc=137;continue;}
case 136:{f.Push(JValue.I(0));f.Pc=137;continue;}
case 137:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9078(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantBeCast","cantBeActivatedAbility","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokestatic",6);}
case 6:{f.Pc=f.Pop().Int!=0?13:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9079(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference!=null?36:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/spellability/AbilityActivated","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",18);}
case 18:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getHostCard","()Lforge/game/card/Card;","invokevirtual",25);}
case 25:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",28);}
case 28:{return rt.DynamicCall(f,"forge/game/spellability/AbilityActivated:9079:28:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",33);}
case 33:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",40);}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getHostCard","()Lforge/game/card/Card;","invokevirtual",44);}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","checkZoneRestrictions","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?70:51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",55);}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/AbilityActivated","getHostCard","()Lforge/game/card/Card;","invokevirtual",59);}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","checkActivatorRestrictions","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?70:66;continue;}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{f.Pc=71;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9080(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9081(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","clone","()Ljava/lang/Object;","invokespecial",4);}
case 4:{return JStep.Return(f.Pop());}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",14);}
case 14:{return rt.DynamicCall(f,"forge/game/spellability/AbilityActivated:9081:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",19);}
case 19:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",22);}
case 22:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C798{
internal static JClass Build(){var c=new JClass("forge/game/spellability/Spell","forge/game/spellability/SpellAbility",new string[]{"java/io/Serializable","java/lang/Cloneable"},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-7930920571482203460L),null));
c.Add(new JField("performanceMode","Z",true,JValue.Default("Z"),null));
c.Add(new JField("castFaceDown","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(9168,"forge/game/spellability/Spell","setPerformanceMode","(Z)V",9,1,1,new JHandler[]{},M9168));
c.Add(new JMethod(9169,"forge/game/spellability/Spell","isPerformanceMode","()Z",9,0,1,new JHandler[]{},M9169));
c.Add(new JMethod(9170,"forge/game/spellability/Spell","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V",1,3,3,new JHandler[]{},M9170));
c.Add(new JMethod(9171,"forge/game/spellability/Spell","canPlay","()Z",1,1,1,new JHandler[]{},M9171));
c.Add(new JMethod(9172,"forge/game/spellability/Spell","canPlayFromHost","()Lforge/game/card/Card;",1,4,4,new JHandler[]{},M9172));
c.Add(new JMethod(9173,"forge/game/spellability/Spell","checkRestrictions","(Lforge/game/card/Card;Lforge/game/player/Player;)Z",1,3,3,new JHandler[]{},M9173));
c.Add(new JMethod(9174,"forge/game/spellability/Spell","clone","()Ljava/lang/Object;",17,2,3,new JHandler[]{new JHandler(0,4,5,"java/lang/Exception")},M9174));
c.Add(new JMethod(9175,"forge/game/spellability/Spell","isSpell","()Z",1,1,1,new JHandler[]{},M9175));
c.Add(new JMethod(9176,"forge/game/spellability/Spell","isAbility","()Z",1,1,1,new JHandler[]{},M9176));
c.Add(new JMethod(9177,"forge/game/spellability/Spell","isCastFaceDown","()Z",1,1,1,new JHandler[]{},M9177));
c.Add(new JMethod(9178,"forge/game/spellability/Spell","setCastFaceDown","(Z)V",1,2,2,new JHandler[]{},M9178));
c.Add(new JMethod(9179,"forge/game/spellability/Spell","getAlternateHost","(Lforge/game/card/Card;)Lforge/game/card/Card;",1,5,4,new JHandler[]{},M9179));
c.Add(new JMethod(9180,"forge/game/spellability/Spell","isCounterableBy","(Lforge/game/spellability/SpellAbility;)Z",1,3,3,new JHandler[]{},M9180));
c.Add(new JMethod(9181,"forge/game/spellability/Spell","<clinit>","()V",8,0,1,new JHandler[]{},M9181));
}

internal static JStep M9168(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/Spell","performanceMode","Z"))return JStep.Continue;rt.PutStatic("forge/game/spellability/Spell","performanceMode","Z",f.Pop());f.Pc=4;continue;}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9169(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/spellability/Spell","performanceMode","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/Spell","performanceMode","Z"));f.Pc=3;continue;}
case 3:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9170(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/Spell","castFaceDown","Z",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","getSpellText","()Ljava/lang/String;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/spellability/Spell","setStackDescription","(Ljava/lang/String;)V","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/Spell","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",23);}
case 23:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",29);}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9171(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/Spell","canPlayFromHost","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9172(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/Spell","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?14:12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/Spell","isCastFromPlayEffect","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?49:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/Spell","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",25);}
case 25:{return rt.Call(f,"forge/game/cost/Cost","hasManaCost","()Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?49:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/Spell","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",35);}
case 35:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/card/mana/ManaCost","isNoCost","()Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?49:47;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{return JStep.Return(f.Pop());}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/Spell","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",53);}
case 53:{f.Locals[2]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Pc=f.Pop().Reference!=null?69:58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",62);}
case 62:{f.Locals[2]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{f.Pc=f.Pop().Reference!=null?69:67;continue;}
case 67:{f.Push(JValue.R(null));f.Pc=68;continue;}
case 68:{return JStep.Return(f.Pop());}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",73);}
case 73:{f.Locals[3]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",78);}
case 78:{return rt.Call(f,"forge/game/zone/MagicStack","isSplitSecondOnStack","()Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?86:84;continue;}
case 84:{f.Push(JValue.R(null));f.Pc=85;continue;}
case 85:{return JStep.Return(f.Pop());}
case 86:{if(!rt.StaticReady(f,"forge/game/spellability/Spell","performanceMode","Z"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/Spell","performanceMode","Z"));f.Pc=89;continue;}
case 89:{f.Pc=f.Pop().Int!=0?114:92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",96);}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int!=0?114:103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",107);}
case 107:{f.Locals[1]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{f.Push(JValue.L(0));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",114);}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/spellability/Spell","getAlternateHost","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",119);}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",123);}
case 123:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=126;continue;}
case 126:{f.Locals[1]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/spellability/Spell","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",131);}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","canPlay","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",136);}
case 136:{f.Pc=f.Pop().Int!=0?141:139;continue;}
case 139:{f.Push(JValue.R(null));f.Pc=140;continue;}
case 140:{return JStep.Return(f.Pop());}
case 141:{f.Push(f.Locals[2]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",145);}
case 145:{if(!rt.StaticReady(f,"forge/game/player/PlayerController$FullControlFlag","AllowPaymentStartWithMissingResources","Lforge/game/player/PlayerController$FullControlFlag;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerController$FullControlFlag","AllowPaymentStartWithMissingResources","Lforge/game/player/PlayerController$FullControlFlag;"));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/player/PlayerController","isFullControl","(Lforge/game/player/PlayerController$FullControlFlag;)Z","invokevirtual",151);}
case 151:{f.Pc=f.Pop().Int!=0?168:154;continue;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/spellability/Spell","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",158);}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(JValue.I(0));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/cost/CostPayment","canPayAdditionalCosts","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Z","invokestatic",163);}
case 163:{f.Pc=f.Pop().Int!=0?168:166;continue;}
case 166:{f.Push(JValue.R(null));f.Pc=167;continue;}
case 167:{return JStep.Return(f.Pop());}
case 168:{f.Push(f.Locals[1]);f.Pc=169;continue;}
case 169:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9173(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantBeCast","cantBeCastAbility","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokestatic",6);}
case 6:{f.Pc=f.Pop().Int!=0?13:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9174(JRuntime rt,JFrame f)
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
case 14:{return rt.DynamicCall(f,"forge/game/spellability/Spell:9174:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",19);}
case 19:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",22);}
case 22:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9175(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9176(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9177(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/Spell","castFaceDown","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9178(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/Spell","castFaceDown","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9179(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?50:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?50:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?31:26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",30);}
case 30:{f.Locals[1]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","forceTurnFaceUp","()V","invokevirtual",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(-1));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","setLKICMC","(I)V","invokevirtual",40);}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/card/Card","setLKICMC","(I)V","invokevirtual",48);}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{f.Locals[2]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/Spell","isBestow","()Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?85:57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","isBestowed","()Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?85:64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int!=0?76:71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",75);}
case 75:{f.Locals[1]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/Card","animateBestow","()V","invokevirtual",80);}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{f.Locals[2]=f.Pop();f.Pc=82;continue;}
case 82:{f.Pc=304;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/spellability/Spell","isCastFaceDown","()Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?114:92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int!=0?104:99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",103);}
case 103:{f.Locals[1]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/card/Card","turnFaceDownNoUpdate","()Z","invokevirtual",108);}
case 108:{f.StackOp("pop");f.Pc=109;continue;}
case 109:{f.Push(JValue.I(1));f.Pc=110;continue;}
case 110:{f.Locals[2]=f.Pop();f.Pc=111;continue;}
case 111:{f.Pc=304;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/spellability/Spell","getCardState","()Lforge/game/card/CardState;","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Reference==null?250:121;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",125);}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/spellability/Spell","getCardStateName","()Lforge/card/CardStateName;","invokevirtual",129);}
case 129:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?250:132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/spellability/Spell","getHostCard","()Lforge/game/card/Card;","invokevirtual",136);}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/spellability/Spell","getCardStateName","()Lforge/card/CardStateName;","invokevirtual",140);}
case 140:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Reference==null?250:146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int!=0?158:153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",157);}
case 157:{f.Locals[1]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/spellability/Spell","getCardStateName","()Lforge/card/CardStateName;","invokevirtual",162);}
case 162:{f.Locals[3]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[3]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",168);}
case 168:{f.Pc=f.Pop().Int!=0?194:171;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[3]);f.Pc=173;continue;}
case 173:{f.Push(JValue.I(0));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/card/Card","addAlternateState","(Lforge/card/CardStateName;Z)V","invokevirtual",177);}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[3]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",182);}
case 182:{f.Push(f.Locals[0]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/spellability/Spell","getHostCard","()Lforge/game/card/Card;","invokevirtual",186);}
case 186:{f.Push(f.Locals[3]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",190);}
case 190:{f.Push(JValue.I(1));f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/card/CardState","copyFrom","(Lforge/game/card/CardState;Z)V","invokevirtual",194);}
case 194:{f.Push(f.Locals[1]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[3]);f.Pc=196;continue;}
case 196:{f.Push(JValue.I(0));f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",200);}
case 200:{f.StackOp("pop");f.Pc=201;continue;}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/spellability/Spell","getHostCard","()Lforge/game/card/Card;","invokevirtual",205);}
case 205:{return rt.Call(f,"forge/game/card/Card","isDoubleFaced","()Z","invokevirtual",208);}
case 208:{f.Pc=f.Pop().Int==0?232:211;continue;}
case 211:{f.Push(f.Locals[1]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/spellability/Spell","getHostCard","()Lforge/game/card/Card;","invokevirtual",216);}
case 216:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",219);}
case 219:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",222);}
case 222:{return rt.Call(f,"forge/card/CardSplitType","getChangedStateName","()Lforge/card/CardStateName;","invokevirtual",225);}
case 225:{f.Push(f.Locals[3]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",229);}
case 229:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",232);}
case 232:{f.Push(f.Locals[1]);f.Pc=233;continue;}
case 233:{f.Push(JValue.I(-1));f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/card/Card","setLKICMC","(I)V","invokevirtual",237);}
case 237:{f.Push(f.Locals[1]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[1]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",242);}
case 242:{return rt.Call(f,"forge/game/card/Card","setLKICMC","(I)V","invokevirtual",245);}
case 245:{f.Push(JValue.I(1));f.Pc=246;continue;}
case 246:{f.Locals[2]=f.Pop();f.Pc=247;continue;}
case 247:{f.Pc=304;continue;}
case 250:{f.Push(f.Locals[0]);f.Pc=251;continue;}
case 251:{f.Push(JValue.R(rt.String("Prototype")));f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/spellability/Spell","hasParam","(Ljava/lang/String;)Z","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Int==0?304:260;continue;}
case 260:{f.Push(f.Locals[1]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/card/Card","getPrototypeTimestamp","()J","invokevirtual",264);}
case 264:{f.Push(JValue.L(-1L));f.Pc=267;continue;}
case 267:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=268;continue;}
case 268:{f.Pc=f.Pop().Int!=0?304:271;continue;}
case 271:{f.Push(f.Locals[1]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",275);}
case 275:{f.Pc=f.Pop().Int!=0?283:278;continue;}
case 278:{f.Push(f.Locals[1]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",282);}
case 282:{f.Locals[1]=f.Pop();f.Pc=283;continue;}
case 283:{f.Push(f.Locals[1]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",287);}
case 287:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",290);}
case 290:{f.Locals[3]=f.Pop();f.Pc=291;continue;}
case 291:{f.Push(f.Locals[1]);f.Pc=292;continue;}
case 292:{f.Push(f.Locals[1]);f.Pc=293;continue;}
case 293:{f.Push(f.Locals[1]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[0]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/card/CardFactory","getCloneStates","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCloneStates;","invokestatic",298);}
case 298:{f.Push(f.Locals[3]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/card/Card","addCloneState","(Lforge/game/card/CardCloneStates;J)V","invokevirtual",302);}
case 302:{f.Push(JValue.I(1));f.Pc=303;continue;}
case 303:{f.Locals[2]=f.Pop();f.Pc=304;continue;}
case 304:{f.Push(f.Locals[2]);f.Pc=305;continue;}
case 305:{f.Pc=f.Pop().Int==0?312:308;continue;}
case 308:{f.Push(f.Locals[1]);f.Pc=309;continue;}
case 309:{f.Pc=313;continue;}
case 312:{f.Push(JValue.R(null));f.Pc=313;continue;}
case 313:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9180(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/Spell","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",18);}
case 18:{f.StackOp("pop");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/Spell","getHostCard","()Lforge/game/card/Card;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",37);}
case 37:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",40);}
case 40:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Counter","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Counter","Lforge/game/replacement/ReplacementType;"));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","cantHappenCheck","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int!=0?54:50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{f.Pc=55;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9181(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/Spell","performanceMode","Z"))return JStep.Continue;rt.PutStatic("forge/game/spellability/Spell","performanceMode","Z",f.Pop());f.Pc=4;continue;}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

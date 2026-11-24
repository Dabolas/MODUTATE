// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C180{
internal static JClass Build(){var c=new JClass("forge/game/ability/AbilityFactory","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("additionalAbilityKeys","Ljava/util/List;",true,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(2780,"forge/game/ability/AbilityFactory","<init>","()V",1,1,1,new JHandler[]{},M2780));
c.Add(new JMethod(2781,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;",9,2,2,new JHandler[]{},M2781));
c.Add(new JMethod(2782,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;",9,3,3,new JHandler[]{},M2782));
c.Add(new JMethod(2783,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;",9,2,3,new JHandler[]{},M2783));
c.Add(new JMethod(2784,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;",10,8,4,new JHandler[]{new JHandler(0,5,8,"java/lang/RuntimeException"),new JHandler(80,88,89,"java/lang/Error"),new JHandler(80,88,89,"java/lang/Exception")},M2784));
c.Add(new JMethod(2785,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;)Lforge/game/spellability/SpellAbility;",9,2,3,new JHandler[]{},M2785));
c.Add(new JMethod(2786,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;",9,3,3,new JHandler[]{},M2786));
c.Add(new JMethod(2787,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/CardState;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;",9,4,4,new JHandler[]{},M2787));
c.Add(new JMethod(2788,"forge/game/ability/AbilityFactory","getAbility","(Ljava/util/Map;Lforge/game/ability/AbilityFactory$AbilityRecordType;Lforge/game/card/CardState;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;",9,4,6,new JHandler[]{},M2788));
c.Add(new JMethod(2789,"forge/game/ability/AbilityFactory","parseAbilityCost","(Lforge/game/card/CardState;Ljava/util/Map;Lforge/game/ability/AbilityFactory$AbilityRecordType;)Lforge/game/cost/Cost;",9,4,5,new JHandler[]{},M2789));
c.Add(new JMethod(2790,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/ability/AbilityFactory$AbilityRecordType;Lforge/game/ability/ApiType;Ljava/util/Map;Lforge/game/cost/Cost;Lforge/game/card/CardState;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;",9,16,6,new JHandler[]{},M2790));
c.Add(new JMethod(2791,"forge/game/ability/AbilityFactory","readTarget","(Ljava/util/Map;)Lforge/game/spellability/TargetRestrictions;",10,1,3,new JHandler[]{},M2791));
c.Add(new JMethod(2792,"forge/game/ability/AbilityFactory","initializeParams","(Lforge/game/spellability/SpellAbility;)V",10,1,2,new JHandler[]{},M2792));
c.Add(new JMethod(2793,"forge/game/ability/AbilityFactory","makeRestrictions","(Lforge/game/spellability/SpellAbility;)V",10,2,2,new JHandler[]{},M2793));
c.Add(new JMethod(2794,"forge/game/ability/AbilityFactory","makeConditions","(Lforge/game/spellability/SpellAbility;)V",10,2,2,new JHandler[]{},M2794));
c.Add(new JMethod(2795,"forge/game/ability/AbilityFactory","getSubAbility","(Lforge/game/card/CardState;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/AbilitySub;",10,3,3,new JHandler[]{},M2795));
c.Add(new JMethod(2796,"forge/game/ability/AbilityFactory","getMapParams","(Ljava/lang/String;)Ljava/util/Map;",9,1,2,new JHandler[]{},M2796));
c.Add(new JMethod(2797,"forge/game/ability/AbilityFactory","adjustChangeZoneTarget","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V",9,4,2,new JHandler[]{},M2797));
c.Add(new JMethod(2798,"forge/game/ability/AbilityFactory","buildFusedAbility","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;",9,14,6,new JHandler[]{},M2798));
c.Add(new JMethod(2799,"forge/game/ability/AbilityFactory","lambda$getAbility$0","(Lforge/game/card/CardState;Lforge/game/IHasSVars;Lforge/game/ability/ApiType;Ljava/lang/String;)Lforge/game/spellability/AbilitySub;",4106,5,3,new JHandler[]{},M2799));
c.Add(new JMethod(2800,"forge/game/ability/AbilityFactory","<clinit>","()V",8,0,4,new JHandler[]{},M2800));
}

internal static JStep M2780(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2781(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;)Lforge/game/spellability/SpellAbility;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2782(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2783(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2784(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/AbilityFactory","getMapParams","(Ljava/lang/String;)Ljava/util/Map;","invokestatic",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Pc=32;continue;}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/RuntimeException","getMessage","()Ljava/lang/String;","invokevirtual",23);}
case 23:{return rt.DynamicCall(f,"forge/game/ability/AbilityFactory:2784:23:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",28);}
case 28:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",31);}
case 31:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","getRecordType","(Ljava/util/Map;)Lforge/game/ability/AbilityFactory$AbilityRecordType;","invokestatic",36);}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(JValue.R(null));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?80:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",48);}
case 48:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?58:54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Pc=62;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",62);}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.DynamicCall(f,"forge/game/ability/AbilityFactory:2784:71:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",76);}
case 76:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",79);}
case 79:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/util/Map;Lforge/game/ability/AbilityFactory$AbilityRecordType;Lforge/game/card/CardState;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",88);}
case 88:{return JStep.Return(f.Pop());}
case 89:{f.Locals[5]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("AbilityFactory:getAbility: crash when trying to create ability ")));f.Pc=93;continue;}
case 93:{f.Locals[6]=f.Pop();f.Pc=95;continue;}
case 95:{if(!rt.EnsureInitialized(f,"io/sentry/Breadcrumb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("io/sentry/Breadcrumb")));f.Pc=98;continue;}
case 98:{f.StackOp("dup");f.Pc=99;continue;}
case 99:{f.Push(f.Locals[6]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"io/sentry/Breadcrumb","<init>","(Ljava/lang/String;)V","invokespecial",104);}
case 104:{f.Locals[7]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[7]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("Card")));f.Pc=110;continue;}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",114);}
case 114:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",117);}
case 117:{f.Push(f.Locals[7]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("Ability")));f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",125);}
case 125:{f.Push(f.Locals[7]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"io/sentry/Sentry","addBreadcrumb","(Lio/sentry/Breadcrumb;)V","invokestatic",130);}
case 130:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=133;continue;}
case 133:{f.StackOp("dup");f.Pc=134;continue;}
case 134:{f.Push(f.Locals[6]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",140);}
case 140:{return rt.DynamicCall(f,"forge/game/ability/AbilityFactory:2784:140:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",145);}
case 145:{f.Push(f.Locals[5]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",150);}
case 150:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2785(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2786(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/CardState;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2787(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/IHasSVars","hasSVar","(Ljava/lang/String;)Z","invokeinterface",7);}
case 7:{f.Pc=f.Pop().Int!=0?33:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.DynamicCall(f,"forge/game/ability/AbilityFactory:2787:24:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",29);}
case 29:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",32);}
case 32:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/IHasSVars","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokeinterface",40);}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/CardState;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",45);}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2788(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","getApiTypeOf","(Ljava/util/Map;)Lforge/game/ability/ApiType;","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/ability/AbilityFactory$AbilityRecordType;Lforge/game/ability/ApiType;Ljava/util/Map;Lforge/game/cost/Cost;Lforge/game/card/CardState;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2789(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Cost")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference==null?46:25;continue;}
case 25:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","Ability","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","Ability","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=34;continue;}
case 34:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?41:37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{f.Pc=42;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",45);}
case 45:{return JStep.Return(f.Pop());}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","Spell","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","Spell","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=50;continue;}
case 50:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?66:53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",61);}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",65);}
case 65:{return JStep.Return(f.Pop());}
case 66:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",74);}
case 74:{return rt.DynamicCall(f,"forge/game/ability/AbilityFactory:2789:74:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",79);}
case 79:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",82);}
case 82:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2790(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",5);}
case 5:{f.Locals[6]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?25:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/ability/AbilityFactory","readTarget","(Ljava/util/Map;)Lforge/game/spellability/TargetRestrictions;","invokestatic",22);}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.R(null));f.Pc=26;continue;}
case 26:{f.Locals[7]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Pc=f.Pop().Reference!=null?40:32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/ability/AbilityFactory","parseAbilityCost","(Lforge/game/card/CardState;Ljava/util/Map;Lforge/game/ability/AbilityFactory$AbilityRecordType;)Lforge/game/cost/Cost;","invokestatic",39);}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[7]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","buildSpellAbility","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;Ljava/util/Map;)Lforge/game/spellability/SpellAbility;","invokevirtual",51);}
case 51:{f.Locals[8]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[8]);f.Pc=55;continue;}
case 55:{f.Pc=f.Pop().Reference!=null?111:58;continue;}
case 58:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=61;continue;}
case 61:{f.StackOp("dup");f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",65);}
case 65:{f.Locals[9]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[9]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("AbilityFactory : SpellAbility was not created for ")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Push(f.Locals[9]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/card/CardState","toString","()Ljava/lang/String;","invokevirtual",82);}
case 82:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[9]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String(". Looking for API: ")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",93);}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=101;continue;}
case 101:{f.StackOp("dup");f.Pc=102;continue;}
case 102:{f.Push(f.Locals[9]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",107);}
case 107:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",110);}
case 110:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 111:{f.Push(f.Locals[5]);f.Pc=113;continue;}
case 113:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/CardState")?1:0));f.Pc=116;continue;}
case 116:{f.Pc=f.Pop().Int==0?132:119;continue;}
case 119:{f.Push(f.Locals[8]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",129);}
case 129:{f.Pc=163;continue;}
case 132:{f.Push(f.Locals[5]);f.Pc=134;continue;}
case 134:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/CardTraitBase")?1:0));f.Pc=137;continue;}
case 137:{f.Pc=f.Pop().Int==0?156:140;continue;}
case 140:{f.Push(f.Locals[8]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[5]);f.Pc=144;continue;}
case 144:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/CardTraitBase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/CardTraitBase","getCardState","()Lforge/game/card/CardState;","invokevirtual",150);}
case 150:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",153);}
case 153:{f.Pc=163;continue;}
case 156:{f.Push(f.Locals[8]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[4]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",163);}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","DelayedTrigger","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","DelayedTrigger","Lforge/game/ability/ApiType;"));f.Pc=167;continue;}
case 167:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?177:170;continue;}
case 170:{f.Push(f.Locals[1]);f.Pc=171;continue;}
case 171:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ImmediateTrigger","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ImmediateTrigger","Lforge/game/ability/ApiType;"));f.Pc=174;continue;}
case 174:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?222:177;continue;}
case 177:{f.Push(f.Locals[2]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("Execute")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",185);}
case 185:{f.Pc=f.Pop().Int==0?222:188;continue;}
case 188:{f.Push(f.Locals[8]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[2]);f.Pc=191;continue;}
case 191:{f.Push(JValue.R(rt.String("Execute")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",198);}
case 198:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[5]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[2]);f.Pc=204;continue;}
case 204:{f.Push(JValue.R(rt.String("Execute")));f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",211);}
case 211:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/IHasSVars","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokeinterface",219);}
case 219:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",222);}
case 222:{f.Push(f.Locals[2]);f.Pc=223;continue;}
case 223:{f.Push(JValue.R(rt.String("PreventionSubAbility")));f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",230);}
case 230:{f.Pc=f.Pop().Int==0?267:233;continue;}
case 233:{f.Push(f.Locals[8]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[2]);f.Pc=236;continue;}
case 236:{f.Push(JValue.R(rt.String("PreventionSubAbility")));f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",243);}
case 243:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[5]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[2]);f.Pc=249;continue;}
case 249:{f.Push(JValue.R(rt.String("PreventionSubAbility")));f.Pc=251;continue;}
case 251:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",256);}
case 256:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/IHasSVars","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokeinterface",264);}
case 264:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",267);}
case 267:{f.Push(f.Locals[2]);f.Pc=268;continue;}
case 268:{f.Push(JValue.R(rt.String("SubAbility")));f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",275);}
case 275:{f.Pc=f.Pop().Int==0?305:278;continue;}
case 278:{f.Push(f.Locals[2]);f.Pc=279;continue;}
case 279:{f.Push(JValue.R(rt.String("SubAbility")));f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",286);}
case 286:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=289;continue;}
case 289:{f.Locals[9]=f.Pop();f.Pc=291;continue;}
case 291:{f.Push(f.Locals[8]);f.Pc=293;continue;}
case 293:{f.Push(f.Locals[4]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[9]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[5]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/ability/AbilityFactory","getSubAbility","(Lforge/game/card/CardState;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/AbilitySub;","invokestatic",302);}
case 302:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",305);}
case 305:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory","additionalAbilityKeys","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory","additionalAbilityKeys","Ljava/util/List;"));f.Pc=308;continue;}
case 308:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",313);}
case 313:{f.Locals[9]=f.Pop();f.Pc=315;continue;}
case 315:{f.Push(f.Locals[9]);f.Pc=317;continue;}
case 317:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",322);}
case 322:{f.Pc=f.Pop().Int==0?386:325;continue;}
case 325:{f.Push(f.Locals[9]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",332);}
case 332:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=335;continue;}
case 335:{f.Locals[10]=f.Pop();f.Pc=337;continue;}
case 337:{f.Push(f.Locals[2]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[10]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",345);}
case 345:{f.Pc=f.Pop().Int==0?383:348;continue;}
case 348:{f.Push(f.Locals[8]);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[10]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",355);}
case 355:{f.Pc=f.Pop().Reference!=null?383:358;continue;}
case 358:{f.Push(f.Locals[8]);f.Pc=360;continue;}
case 360:{f.Push(f.Locals[10]);f.Pc=362;continue;}
case 362:{f.Push(f.Locals[4]);f.Pc=364;continue;}
case 364:{f.Push(f.Locals[2]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[10]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",372);}
case 372:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=375;continue;}
case 375:{f.Push(f.Locals[5]);f.Pc=377;continue;}
case 377:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/CardState;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",380);}
case 380:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAdditionalAbility","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)V","invokevirtual",383);}
case 383:{f.Pc=315;continue;}
case 386:{f.Push(f.Locals[1]);f.Pc=387;continue;}
case 387:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"));f.Pc=390;continue;}
case 390:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?421:393;continue;}
case 393:{f.Push(f.Locals[1]);f.Pc=394;continue;}
case 394:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","GenericChoice","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","GenericChoice","Lforge/game/ability/ApiType;"));f.Pc=397;continue;}
case 397:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?421:400;continue;}
case 400:{f.Push(f.Locals[1]);f.Pc=401;continue;}
case 401:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","AssignGroup","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","AssignGroup","Lforge/game/ability/ApiType;"));f.Pc=404;continue;}
case 404:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?421:407;continue;}
case 407:{f.Push(f.Locals[1]);f.Pc=408;continue;}
case 408:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","VillainousChoice","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","VillainousChoice","Lforge/game/ability/ApiType;"));f.Pc=411;continue;}
case 411:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?421:414;continue;}
case 414:{f.Push(f.Locals[1]);f.Pc=415;continue;}
case 415:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Vote","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Vote","Lforge/game/ability/ApiType;"));f.Pc=418;continue;}
case 418:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?502:421;continue;}
case 421:{f.Push(JValue.R(rt.String("Choices")));f.Pc=424;continue;}
case 424:{f.Locals[9]=f.Pop();f.Pc=426;continue;}
case 426:{f.Push(f.Locals[2]);f.Pc=427;continue;}
case 427:{f.Push(JValue.R(rt.String("Choices")));f.Pc=430;continue;}
case 430:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",435);}
case 435:{f.Pc=f.Pop().Int==0?502:438;continue;}
case 438:{f.Push(f.Locals[2]);f.Pc=439;continue;}
case 439:{f.Push(JValue.R(rt.String("Choices")));f.Pc=442;continue;}
case 442:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",447);}
case 447:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=450;continue;}
case 450:{f.Push(JValue.R(rt.String(",")));f.Pc=453;continue;}
case 453:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",456);}
case 456:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",459);}
case 459:{f.Locals[10]=f.Pop();f.Pc=461;continue;}
case 461:{f.Push(f.Locals[8]);f.Pc=463;continue;}
case 463:{f.Push(JValue.R(rt.String("Choices")));f.Pc=466;continue;}
case 466:{f.Push(f.Locals[10]);f.Pc=468;continue;}
case 468:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",473);}
case 473:{f.Push(f.Locals[4]);f.Pc=475;continue;}
case 475:{f.Push(f.Locals[5]);f.Pc=477;continue;}
case 477:{f.Push(f.Locals[1]);f.Pc=478;continue;}
case 478:{return rt.DynamicCall(f,"forge/game/ability/AbilityFactory:2790:478:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CardState;Lforge/game/IHasSVars;Lforge/game/ability/ApiType;)Ljava/util/function/Function;",483);}
case 483:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",488);}
case 488:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",491);}
case 491:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",496);}
case 496:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=499;continue;}
case 499:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAdditionalAbilityList","(Ljava/lang/String;Ljava/util/List;)V","invokevirtual",502);}
case 502:{f.Push(f.Locals[1]);f.Pc=503;continue;}
case 503:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","RollDice","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","RollDice","Lforge/game/ability/ApiType;"));f.Pc=506;continue;}
case 506:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?608:509;continue;}
case 509:{f.Push(JValue.R(rt.String("ResultSubAbilities")));f.Pc=512;continue;}
case 512:{f.Locals[9]=f.Pop();f.Pc=514;continue;}
case 514:{f.Push(f.Locals[2]);f.Pc=515;continue;}
case 515:{f.Push(JValue.R(rt.String("ResultSubAbilities")));f.Pc=518;continue;}
case 518:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",523);}
case 523:{f.Pc=f.Pop().Int==0?608:526;continue;}
case 526:{f.Push(f.Locals[2]);f.Pc=527;continue;}
case 527:{f.Push(JValue.R(rt.String("ResultSubAbilities")));f.Pc=530;continue;}
case 530:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",535);}
case 535:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=538;continue;}
case 538:{f.Push(JValue.R(rt.String(",")));f.Pc=541;continue;}
case 541:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",544);}
case 544:{f.Locals[10]=f.Pop();f.Pc=546;continue;}
case 546:{f.Push(f.Locals[10]);f.Pc=548;continue;}
case 548:{f.Locals[11]=f.Pop();f.Pc=550;continue;}
case 550:{f.Push(f.Locals[11]);f.Pc=552;continue;}
case 552:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=553;continue;}
case 553:{f.Locals[12]=f.Pop();f.Pc=555;continue;}
case 555:{f.Push(JValue.I(0));f.Pc=556;continue;}
case 556:{f.Locals[13]=f.Pop();f.Pc=558;continue;}
case 558:{f.Push(f.Locals[13]);f.Pc=560;continue;}
case 560:{f.Push(f.Locals[12]);f.Pc=562;continue;}
case 562:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?608:565;continue;}
case 565:{f.Push(f.Locals[11]);f.Pc=567;continue;}
case 567:{f.Push(f.Locals[13]);f.Pc=569;continue;}
case 569:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=570;continue;}
case 570:{f.Locals[14]=f.Pop();f.Pc=572;continue;}
case 572:{f.Push(f.Locals[14]);f.Pc=574;continue;}
case 574:{f.Push(JValue.R(rt.String(":")));f.Pc=577;continue;}
case 577:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",580);}
case 580:{f.Locals[15]=f.Pop();f.Pc=582;continue;}
case 582:{f.Push(f.Locals[8]);f.Pc=584;continue;}
case 584:{f.Push(f.Locals[15]);f.Pc=586;continue;}
case 586:{f.Push(JValue.I(0));f.Pc=587;continue;}
case 587:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=588;continue;}
case 588:{f.Push(f.Locals[4]);f.Pc=590;continue;}
case 590:{f.Push(f.Locals[15]);f.Pc=592;continue;}
case 592:{f.Push(JValue.I(1));f.Pc=593;continue;}
case 593:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=594;continue;}
case 594:{f.Push(f.Locals[5]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/game/ability/AbilityFactory","getSubAbility","(Lforge/game/card/CardState;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/AbilitySub;","invokestatic",599);}
case 599:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAdditionalAbility","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)V","invokevirtual",602);}
case 602:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=605;continue;}
case 605:{f.Pc=558;continue;}
case 608:{f.Push(f.Locals[8]);f.Pc=610;continue;}
case 610:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/ability/SpellApiBased")?1:0));f.Pc=613;continue;}
case 613:{f.Pc=f.Pop().Int==0?656:616;continue;}
case 616:{f.Push(f.Locals[6]);f.Pc=618;continue;}
case 618:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",621);}
case 621:{f.Pc=f.Pop().Int==0?656:624;continue;}
case 624:{f.Push(f.Locals[2]);f.Pc=625;continue;}
case 625:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=628;continue;}
case 628:{f.Push(f.Locals[8]);f.Pc=630;continue;}
case 630:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",633);}
case 633:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",636);}
case 636:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",641);}
case 641:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=644;continue;}
case 644:{f.Locals[9]=f.Pop();f.Pc=646;continue;}
case 646:{f.Push(f.Locals[8]);f.Pc=648;continue;}
case 648:{f.Push(f.Locals[9]);f.Pc=650;continue;}
case 650:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",653);}
case 653:{f.Pc=703;continue;}
case 656:{f.Push(f.Locals[8]);f.Pc=658;continue;}
case 658:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=661;continue;}
case 661:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",664);}
case 664:{f.Pc=f.Pop().Int==0?675:667;continue;}
case 667:{f.Push(f.Locals[8]);f.Pc=669;continue;}
case 669:{return rt.Call(f,"forge/game/spellability/SpellAbility","rebuiltDescription","()V","invokevirtual",672);}
case 672:{f.Pc=703;continue;}
case 675:{f.Push(f.Locals[1]);f.Pc=676;continue;}
case 676:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"));f.Pc=679;continue;}
case 679:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?695:682;continue;}
case 682:{f.Push(f.Locals[8]);f.Pc=684;continue;}
case 684:{f.Push(f.Locals[8]);f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/ability/effects/CharmEffect","makeFormatedDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokestatic",689);}
case 689:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",692);}
case 692:{f.Pc=703;continue;}
case 695:{f.Push(f.Locals[8]);f.Pc=697;continue;}
case 697:{f.Push(JValue.R(rt.String("")));f.Pc=700;continue;}
case 700:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",703);}
case 703:{f.Push(f.Locals[1]);f.Pc=704;continue;}
case 704:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","RollDice","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","RollDice","Lforge/game/ability/ApiType;"));f.Pc=707;continue;}
case 707:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?733:710;continue;}
case 710:{f.Push(f.Locals[8]);f.Pc=712;continue;}
case 712:{f.Push(f.Locals[8]);f.Pc=714;continue;}
case 714:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",717);}
case 717:{f.Push(f.Locals[8]);f.Pc=719;continue;}
case 719:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","makeFormatedDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokestatic",722);}
case 722:{return rt.DynamicCall(f,"forge/game/ability/AbilityFactory:2790:722:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",727);}
case 727:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",730);}
case 730:{f.Pc=766;continue;}
case 733:{f.Push(f.Locals[1]);f.Pc=734;continue;}
case 734:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Repeat","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Repeat","Lforge/game/ability/ApiType;"));f.Pc=737;continue;}
case 737:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?766:740;continue;}
case 740:{f.Push(f.Locals[8]);f.Pc=742;continue;}
case 742:{f.Push(f.Locals[8]);f.Pc=744;continue;}
case 744:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",747);}
case 747:{f.Push(f.Locals[8]);f.Pc=749;continue;}
case 749:{f.Push(JValue.R(rt.String("RepeatSubAbility")));f.Pc=752;continue;}
case 752:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",755);}
case 755:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",758);}
case 758:{return rt.DynamicCall(f,"forge/game/ability/AbilityFactory:2790:758:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",763);}
case 763:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",766);}
case 766:{f.Push(f.Locals[8]);f.Pc=768;continue;}
case 768:{return rt.Call(f,"forge/game/ability/AbilityFactory","initializeParams","(Lforge/game/spellability/SpellAbility;)V","invokestatic",771);}
case 771:{f.Push(f.Locals[8]);f.Pc=773;continue;}
case 773:{return rt.Call(f,"forge/game/ability/AbilityFactory","makeRestrictions","(Lforge/game/spellability/SpellAbility;)V","invokestatic",776);}
case 776:{f.Push(f.Locals[8]);f.Pc=778;continue;}
case 778:{return rt.Call(f,"forge/game/ability/AbilityFactory","makeConditions","(Lforge/game/spellability/SpellAbility;)V","invokestatic",781);}
case 781:{f.Push(f.Locals[8]);f.Pc=783;continue;}
case 783:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2791(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/spellability/TargetRestrictions"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/TargetRestrictions")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","<init>","(Ljava/util/Map;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2792(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("NonBasicSpell")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?15:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","setBasicSpell","(Z)V","invokevirtual",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2793(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?17:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setRestrictions","(Ljava/util/Map;)V","invokevirtual",17);}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2794(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getConditions","()Lforge/game/spellability/SpellAbilityCondition;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setConditions","(Ljava/util/Map;)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2795(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/IHasSVars","hasSVar","(Ljava/lang/String;)Z","invokeinterface",7);}
case 7:{f.Pc=f.Pop().Int==0?20:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/CardState;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
case 20:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",28);}
case 28:{return rt.DynamicCall(f,"forge/game/ability/AbilityFactory:2795:28:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",33);}
case 33:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",36);}
case 36:{f.Push(JValue.R(null));f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2796(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/util/FileSection","DOLLAR_SIGN_KV_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/FileSection","DOLLAR_SIGN_KV_SEPARATOR","Ljava/util/regex/Pattern;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/FileSection","parseToMap","(Ljava/lang/String;Ljava/util/regex/Pattern;)Ljava/util/Map;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2797(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Origin")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?49:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("Origin")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",21);}
case 21:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",27);}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",32);}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Pc=f.Pop().Reference==null?49:37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","canTgtPlayer","()Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int!=0?49:44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setZone","(Ljava/util/List;)V","invokevirtual",49);}
case 49:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2798(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isSplitCard","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?18:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Fuse ability may be built only on split cards")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/IllegalStateException","<init>","(Ljava/lang/String;)V","invokespecial",17);}
case 17:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",25);}
case 25:{f.Locals[1]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardState","getFirstAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",35);}
case 35:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",38);}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","getRecordType","(Ljava/util/Map;)Lforge/game/ability/AbilityFactory$AbilityRecordType;","invokestatic",43);}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","getApiTypeOf","(Ljava/util/Map;)Lforge/game/ability/ApiType;","invokevirtual",51);}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",66);}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("Fuse (You may cast one or both halves of this card from your hand.)")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Push(f.Locals[3]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("ActivationZone")));f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("Hand")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("True")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",113);}
case 113:{f.StackOp("pop");f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",121);}
case 121:{f.Locals[6]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/CardState","getFirstAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",128);}
case 128:{f.Locals[7]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[7]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",135);}
case 135:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",138);}
case 138:{f.Locals[8]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[8]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","getRecordType","(Ljava/util/Map;)Lforge/game/ability/AbilityFactory$AbilityRecordType;","invokestatic",145);}
case 145:{f.Locals[9]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[4]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[8]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","getApiTypeOf","(Ljava/util/Map;)Lforge/game/ability/ApiType;","invokevirtual",154);}
case 154:{f.Locals[10]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[8]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=161;continue;}
case 161:{f.Push(f.Locals[8]);f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",171);}
case 171:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",179);}
case 179:{f.StackOp("pop");f.Pc=180;continue;}
case 180:{f.Push(f.Locals[8]);f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=185;continue;}
case 185:{f.Push(JValue.R(rt.String("")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",193);}
case 193:{f.StackOp("pop");f.Pc=194;continue;}
case 194:{f.Push(f.Locals[1]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[3]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[4]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/ability/AbilityFactory","parseAbilityCost","(Lforge/game/card/CardState;Ljava/util/Map;Lforge/game/ability/AbilityFactory$AbilityRecordType;)Lforge/game/cost/Cost;","invokestatic",201);}
case 201:{f.Locals[11]=f.Pop();f.Pc=203;continue;}
case 203:{f.Push(f.Locals[11]);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[6]);f.Pc=207;continue;}
case 207:{f.Push(f.Locals[8]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[9]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/ability/AbilityFactory","parseAbilityCost","(Lforge/game/card/CardState;Ljava/util/Map;Lforge/game/ability/AbilityFactory$AbilityRecordType;)Lforge/game/cost/Cost;","invokestatic",214);}
case 214:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",217);}
case 217:{f.StackOp("pop");f.Pc=218;continue;}
case 218:{f.Push(f.Locals[4]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[5]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[3]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[11]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[1]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/ability/AbilityFactory$AbilityRecordType;Lforge/game/ability/ApiType;Ljava/util/Map;Lforge/game/cost/Cost;Lforge/game/card/CardState;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",230);}
case 230:{f.Locals[12]=f.Pop();f.Pc=232;continue;}
case 232:{f.Push(f.Locals[12]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[2]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOriginalAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",238);}
case 238:{f.Push(f.Locals[12]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[0]);f.Pc=241;continue;}
case 241:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",247);}
case 247:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",250);}
case 250:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=253;continue;}
case 253:{f.Push(f.Locals[10]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[8]);f.Pc=257;continue;}
case 257:{f.Push(JValue.R(null));f.Pc=258;continue;}
case 258:{f.Push(f.Locals[6]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[6]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/ability/AbilityFactory$AbilityRecordType;Lforge/game/ability/ApiType;Ljava/util/Map;Lforge/game/cost/Cost;Lforge/game/card/CardState;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",265);}
case 265:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=268;continue;}
case 268:{f.Locals[13]=f.Pop();f.Pc=270;continue;}
case 270:{f.Push(f.Locals[13]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[7]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/spellability/AbilitySub","setOriginalAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",277);}
case 277:{f.Push(f.Locals[12]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[13]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/spellability/SpellAbility","appendSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",284);}
case 284:{f.Push(f.Locals[12]);f.Pc=286;continue;}
case 286:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2799(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[3]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/AbilityFactory","getSubAbility","(Lforge/game/card/CardState;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/AbilitySub;","invokestatic",6);}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","GenericChoice","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","GenericChoice","Lforge/game/ability/ApiType;"));f.Pc=12;continue;}
case 12:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?32:15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbilityRestriction"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbilityRestriction")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","<init>","()V","invokespecial",24);}
case 24:{return rt.Call(f,"forge/game/spellability/AbilitySub","setRestrictions","(Lforge/game/spellability/SpellAbilityRestriction;)V","invokevirtual",27);}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/ability/AbilityFactory","makeRestrictions","(Lforge/game/spellability/SpellAbility;)V","invokestatic",32);}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2800(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(28));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("WinSubAbility")));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("OtherwiseSubAbility")));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("BidSubAbility")));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("ChooseNumberSubAbility")));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("Lowest")));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("Highest")));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("NotLowest")));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("GuessCorrect")));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("GuessWrong")));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("MatchedAbility")));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("UnmatchedAbility")));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("HeadsSubAbility")));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("TailsSubAbility")));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("LoseSubAbility")));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String("TrueSubAbility")));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{f.Push(JValue.I(15));f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("FalseSubAbility")));f.Pc=110;continue;}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.I(16));f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("ChosenPile")));f.Pc=117;continue;}
case 117:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(17));f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("UnchosenPile")));f.Pc=124;continue;}
case 124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(JValue.I(18));f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("RepeatSubAbility")));f.Pc=131;continue;}
case 131:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=132;continue;}
case 132:{f.StackOp("dup");f.Pc=133;continue;}
case 133:{f.Push(JValue.I(19));f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String("Execute")));f.Pc=137;continue;}
case 137:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=138;continue;}
case 138:{f.StackOp("dup");f.Pc=139;continue;}
case 139:{f.Push(JValue.I(20));f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("FallbackAbility")));f.Pc=144;continue;}
case 144:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=145;continue;}
case 145:{f.StackOp("dup");f.Pc=146;continue;}
case 146:{f.Push(JValue.I(21));f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String("ChooseSubAbility")));f.Pc=151;continue;}
case 151:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=152;continue;}
case 152:{f.StackOp("dup");f.Pc=153;continue;}
case 153:{f.Push(JValue.I(22));f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("CantChooseSubAbility")));f.Pc=158;continue;}
case 158:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=159;continue;}
case 159:{f.StackOp("dup");f.Pc=160;continue;}
case 160:{f.Push(JValue.I(23));f.Pc=162;continue;}
case 162:{f.Push(JValue.R(rt.String("RegenerationAbility")));f.Pc=165;continue;}
case 165:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=166;continue;}
case 166:{f.StackOp("dup");f.Pc=167;continue;}
case 167:{f.Push(JValue.I(24));f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String("ReturnAbility")));f.Pc=172;continue;}
case 172:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=173;continue;}
case 173:{f.StackOp("dup");f.Pc=174;continue;}
case 174:{f.Push(JValue.I(25));f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.String("GiftAbility")));f.Pc=179;continue;}
case 179:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=180;continue;}
case 180:{f.StackOp("dup");f.Pc=181;continue;}
case 181:{f.Push(JValue.I(26));f.Pc=183;continue;}
case 183:{f.Push(JValue.R(rt.String("VoteSubAbility")));f.Pc=186;continue;}
case 186:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=187;continue;}
case 187:{f.StackOp("dup");f.Pc=188;continue;}
case 188:{f.Push(JValue.I(27));f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("VoteTiedAbility")));f.Pc=193;continue;}
case 193:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=194;continue;}
case 194:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",197);}
case 197:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory","additionalAbilityKeys","Ljava/util/List;"))return JStep.Continue;rt.PutStatic("forge/game/ability/AbilityFactory","additionalAbilityKeys","Ljava/util/List;",f.Pop());f.Pc=200;continue;}
case 200:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

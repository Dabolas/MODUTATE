// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C932{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerDamageAll","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10371,"forge/game/trigger/TriggerDamageAll","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10371));
c.Add(new JMethod(10372,"forge/game/trigger/TriggerDamageAll","performTest","(Ljava/util/Map;)Z",1,3,5,new JHandler[]{},M10372));
c.Add(new JMethod(10373,"forge/game/trigger/TriggerDamageAll","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",1,4,5,new JHandler[]{},M10373));
c.Add(new JMethod(10374,"forge/game/trigger/TriggerDamageAll","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10374));
}

internal static JStep M10371(JRuntime rt,JFrame f)
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

internal static JStep M10372(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("CombatDamage")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/trigger/TriggerDamageAll","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?40:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("CombatDamage")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/trigger/TriggerDamageAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Push(JValue.R(rt.String("True")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",20);}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",35);}
case 35:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[2]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/trigger/TriggerDamageAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",60);}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/trigger/TriggerDamageAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",66);}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/trigger/TriggerDamageAll","getHostCard","()Lforge/game/card/Card;","invokevirtual",70);}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/CardDamageTable","filteredMap","(Ljava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardDamageTable;","invokevirtual",74);}
case 74:{return rt.Call(f,"forge/game/card/CardDamageTable","isEmpty","()Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int!=0?84:80;continue;}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{f.Pc=85;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10373(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/trigger/TriggerDamageAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/trigger/TriggerDamageAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/trigger/TriggerDamageAll","getHostCard","()Lforge/game/card/Card;","invokevirtual",30);}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/CardDamageTable","filteredMap","(Ljava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardDamageTable;","invokevirtual",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardDamageTable","totalAmount","()I","invokevirtual",43);}
case 43:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",46);}
case 46:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Sources","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Sources","Lforge/game/ability/AbilityKey;"));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/CardDamageTable","rowKeySet","()Ljava/util/Set;","invokevirtual",60);}
case 60:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Targets","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Targets","Lforge/game/ability/AbilityKey;"));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/CardDamageTable","columnKeySet","()Ljava/util/Set;","invokevirtual",74);}
case 74:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10374(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",12);}
case 12:{f.Push(JValue.R(rt.String("lblDamageSource")));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.Push(JValue.R(rt.String(": ")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Sources","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Sources","Lforge/game/ability/AbilityKey;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.Push(JValue.R(rt.String(", ")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",49);}
case 49:{f.Push(JValue.R(rt.String("lblDamaged")));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",58);}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.Push(JValue.R(rt.String(": ")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Targets","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Targets","Lforge/game/ability/AbilityKey;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",73);}
case 73:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",76);}
case 76:{f.Push(JValue.R(rt.String(", ")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",86);}
case 86:{f.Push(JValue.R(rt.String("lblAmount")));f.Pc=88;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",95);}
case 95:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",98);}
case 98:{f.Push(JValue.R(rt.String(": ")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",103);}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",110);}
case 110:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",113);}
case 113:{f.StackOp("pop");f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",118);}
case 118:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

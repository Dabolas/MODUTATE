// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C933{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerDamageDealtOnce","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10375,"forge/game/trigger/TriggerDamageDealtOnce","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10375));
c.Add(new JMethod(10376,"forge/game/trigger/TriggerDamageDealtOnce","performTest","(Ljava/util/Map;)Z",17,6,4,new JHandler[]{},M10376));
c.Add(new JMethod(10377,"forge/game/trigger/TriggerDamageDealtOnce","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,4,4,new JHandler[]{},M10377));
c.Add(new JMethod(10378,"forge/game/trigger/TriggerDamageDealtOnce","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10378));
c.Add(new JMethod(10379,"forge/game/trigger/TriggerDamageDealtOnce","getDamageAmount","(Ljava/util/Map;)I",1,5,3,new JHandler[]{},M10379));
c.Add(new JMethod(10380,"forge/game/trigger/TriggerDamageDealtOnce","getDamageTargets","(Ljava/util/Map;)Ljava/util/Set;",1,5,3,new JHandler[]{},M10380));
c.Add(new JMethod(10381,"forge/game/trigger/TriggerDamageDealtOnce","lambda$performTest$0","(Ljava/lang/String;ILjava/lang/Integer;)Z",4106,3,3,new JHandler[]{},M10381));
}

internal static JStep M10375(JRuntime rt,JFrame f)
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

internal static JStep M10376(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("CombatDamage")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/trigger/TriggerDamageDealtOnce","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?40:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("CombatDamage")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/trigger/TriggerDamageDealtOnce","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",15);}
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
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",52);}
case 52:{return rt.Call(f,"forge/game/trigger/TriggerDamageDealtOnce","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int!=0?60:58;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",69);}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{f.Locals[2]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/trigger/TriggerDamageDealtOnce","hasParam","(Ljava/lang/String;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?92:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/trigger/TriggerDamageDealtOnce","getDamageAmount","(Ljava/util/Map;)I","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int>0?92:90;continue;}
case 90:{f.Push(JValue.I(0));f.Pc=91;continue;}
case 91:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("AtLeastOneInstance")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/trigger/TriggerDamageDealtOnce","hasParam","(Ljava/lang/String;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?156:101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("AtLeastOneInstance")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/trigger/TriggerDamageDealtOnce","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",107);}
case 107:{f.Locals[3]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{f.Push(JValue.I(2));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",114);}
case 114:{f.Locals[4]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{f.Push(JValue.I(2));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",121);}
case 121:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",124);}
case 124:{f.Locals[5]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",132);}
case 132:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",137);}
case 137:{f.Push(f.Locals[4]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[5]);f.Pc=141;continue;}
case 141:{return rt.DynamicCall(f,"forge/game/trigger/TriggerDamageDealtOnce:10376:141:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;I)Ljava/util/function/Predicate;",146);}
case 146:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",151);}
case 151:{f.Pc=f.Pop().Int!=0?156:154;continue;}
case 154:{f.Push(JValue.I(0));f.Pc=155;continue;}
case 155:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 156:{f.Push(JValue.I(1));f.Pc=157;continue;}
case 157:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10377(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",26);}
case 26:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Targets","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Targets","Lforge/game/ability/AbilityKey;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/trigger/TriggerDamageDealtOnce","getDamageTargets","(Ljava/util/Map;)Ljava/util/Set;","invokevirtual",41);}
case 41:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/trigger/TriggerDamageDealtOnce","getDamageAmount","(Ljava/util/Map;)I","invokevirtual",56);}
case 56:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",59);}
case 59:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10378(JRuntime rt,JFrame f)
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
case 30:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"));f.Pc=33;continue;}
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

internal static JStep M10379(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",8);}
case 8:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?69:23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{return rt.Call(f,"forge/game/trigger/TriggerDamageDealtOnce","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?66:50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",64);}
case 64:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=65;continue;}
case 65:{f.Locals[2]=f.Pop();f.Pc=66;continue;}
case 66:{f.Pc=14;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10380(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/trigger/TriggerDamageDealtOnce","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?19:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",15);}
case 15:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","(Ljava/lang/Iterable;)Ljava/util/HashSet;","invokestatic",18);}
case 18:{return JStep.Return(f.Pop());}
case 19:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",29);}
case 29:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?78:44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/trigger/TriggerDamageDealtOnce","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?75:66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Pc=35;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10381(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

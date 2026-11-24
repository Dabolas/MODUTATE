// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C970{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerLifeLostAll","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10568,"forge/game/trigger/TriggerLifeLostAll","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10568));
c.Add(new JMethod(10569,"forge/game/trigger/TriggerLifeLostAll","performTest","(Ljava/util/Map;)Z",17,3,3,new JHandler[]{},M10569));
c.Add(new JMethod(10570,"forge/game/trigger/TriggerLifeLostAll","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,4,3,new JHandler[]{},M10570));
c.Add(new JMethod(10571,"forge/game/trigger/TriggerLifeLostAll","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,7,2,new JHandler[]{},M10571));
c.Add(new JMethod(10572,"forge/game/trigger/TriggerLifeLostAll","filteredMap","(Ljava/util/Map;)Ljava/util/Map;",2,7,4,new JHandler[]{},M10572));
}

internal static JStep M10568(JRuntime rt,JFrame f)
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

internal static JStep M10569(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/trigger/TriggerLifeLostAll","filteredMap","(Ljava/util/Map;)Ljava/util/Map;","invokevirtual",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?28:26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10570(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/trigger/TriggerLifeLostAll","filteredMap","(Ljava/util/Map;)Ljava/util/Map;","invokevirtual",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",38);}
case 38:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",43);}
case 43:{f.StackOp("pop");f.Pc=44;continue;}
case 44:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10571(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",28);}
case 28:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?108:45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[6]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",68);}
case 68:{f.Push(JValue.R(rt.String(": ")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",73);}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",80);}
case 80:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",93);}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?105:98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String(", ")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Pc=35;continue;}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",112);}
case 112:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10572(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",10);}
case 10:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?146:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{return rt.Call(f,"forge/game/trigger/TriggerLifeLostAll","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int==0?143:52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.String("ValidAmountEach")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/trigger/TriggerLifeLostAll","hasParam","(Ljava/lang/String;)Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?116:61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("ValidAmountEach")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/trigger/TriggerLifeLostAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",67);}
case 67:{f.Locals[5]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/trigger/TriggerLifeLostAll","getHostCard","()Lforge/game/card/Card;","invokevirtual",73);}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{f.Push(JValue.I(2));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",79);}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",83);}
case 83:{f.Locals[6]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",92);}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",98);}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{f.Push(JValue.I(2));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",105);}
case 105:{f.Push(f.Locals[6]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",110);}
case 110:{f.Pc=f.Pop().Int!=0?116:113;continue;}
case 113:{f.Pc=16;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[4]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",124);}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[4]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",134);}
case 134:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",142);}
case 142:{f.StackOp("pop");f.Pc=143;continue;}
case 143:{f.Pc=16;continue;}
case 146:{f.Push(f.Locals[2]);f.Pc=147;continue;}
case 147:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

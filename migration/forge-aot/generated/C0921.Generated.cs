// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C921{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerCounterAdded","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10326,"forge/game/trigger/TriggerCounterAdded","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10326));
c.Add(new JMethod(10327,"forge/game/trigger/TriggerCounterAdded","performTest","(Ljava/util/Map;)Z",17,7,4,new JHandler[]{},M10327));
c.Add(new JMethod(10328,"forge/game/trigger/TriggerCounterAdded","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,3,6,new JHandler[]{},M10328));
c.Add(new JMethod(10329,"forge/game/trigger/TriggerCounterAdded","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10329));
}

internal static JStep M10326(JRuntime rt,JFrame f)
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

internal static JStep M10327(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterType","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterType","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",25);}
case 25:{return rt.Call(f,"forge/game/trigger/TriggerCounterAdded","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?33:31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",45);}
case 45:{return rt.Call(f,"forge/game/trigger/TriggerCounterAdded","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int!=0?53:51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",65);}
case 65:{return rt.Call(f,"forge/game/trigger/TriggerCounterAdded","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int!=0?73:71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/trigger/TriggerCounterAdded","hasParam","(Ljava/lang/String;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?102:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/trigger/TriggerCounterAdded","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",88);}
case 88:{f.Locals[3]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",94);}
case 94:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",97);}
case 97:{f.Pc=f.Pop().Int!=0?102:100;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("CounterAmount")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/trigger/TriggerCounterAdded","hasParam","(Ljava/lang/String;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?179:111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterAmount","Lforge/game/ability/AbilityKey;"));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",120);}
case 120:{f.Pc=f.Pop().Int==0?179:123;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("CounterAmount")));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/trigger/TriggerCounterAdded","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",129);}
case 129:{f.Locals[3]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{f.Push(JValue.I(0));f.Pc=132;continue;}
case 132:{f.Push(JValue.I(2));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",136);}
case 136:{f.Locals[4]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[3]);f.Pc=139;continue;}
case 139:{f.Push(JValue.I(2));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",143);}
case 143:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",146);}
case 146:{f.Locals[5]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterAmount","Lforge/game/ability/AbilityKey;"));f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",157);}
case 157:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",163);}
case 163:{f.Locals[6]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[6]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[4]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[5]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",174);}
case 174:{f.Pc=f.Pop().Int!=0?179:177;continue;}
case 177:{f.Push(JValue.I(0));f.Pc=178;continue;}
case 178:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 179:{f.Push(JValue.I(1));f.Pc=180;continue;}
case 180:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10328(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(2));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=11;continue;}
case 11:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=17;continue;}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/AbilityKey","copyKeys","(Ljava/util/Map;Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokestatic",21);}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10329(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",12);}
case 12:{f.Push(JValue.R(rt.String("lblAddedOnce")));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.Push(JValue.R(rt.String(": ")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasTriggeringObject","(Lforge/game/ability/AbilityKey;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?52:40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",48);}
case 48:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasTriggeringObject","(Lforge/game/ability/AbilityKey;)Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int==0?74:62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",70);}
case 70:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",73);}
case 73:{f.StackOp("pop");f.Pc=74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",78);}
case 78:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C900{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerBecomesCrewed","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10240,"forge/game/trigger/TriggerBecomesCrewed","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10240));
c.Add(new JMethod(10241,"forge/game/trigger/TriggerBecomesCrewed","performTest","(Ljava/util/Map;)Z",1,5,4,new JHandler[]{},M10241));
c.Add(new JMethod(10242,"forge/game/trigger/TriggerBecomesCrewed","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",1,3,6,new JHandler[]{},M10242));
c.Add(new JMethod(10243,"forge/game/trigger/TriggerBecomesCrewed","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10243));
}

internal static JStep M10240(JRuntime rt,JFrame f)
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

internal static JStep M10241(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/game/trigger/TriggerBecomesCrewed","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("ValidCrew")));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",32);}
case 32:{return rt.Call(f,"forge/game/trigger/TriggerBecomesCrewed","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("FirstTimeCrewed")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/trigger/TriggerBecomesCrewed","hasParam","(Ljava/lang/String;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?72:49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Locals[2]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/Card","getTimesCrewedThisTurn","()I","invokevirtual",66);}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?72:70;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("ValidCrewAmount")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/trigger/TriggerBecomesCrewed","hasParam","(Ljava/lang/String;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?137:81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{f.Locals[2]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{f.Locals[3]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{f.Pc=f.Pop().Reference!=null?113:111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("ValidCrewAmount")));f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/trigger/TriggerBecomesCrewed","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",120);}
case 120:{f.Push(JValue.R(null));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",124);}
case 124:{f.Locals[4]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[4]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",132);}
case 132:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?137:135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 137:{f.Push(JValue.I(1));f.Pc=138;continue;}
case 138:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10242(JRuntime rt,JFrame f)
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
case 14:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"));f.Pc=17;continue;}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/AbilityKey","copyKeys","(Ljava/util/Map;Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokestatic",21);}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10243(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",12);}
case 12:{f.Push(JValue.R(rt.String("lblVehicle")));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.Push(JValue.R(rt.String(": ")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("  ")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",51);}
case 51:{f.Push(JValue.R(rt.String("lblCrew")));f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",60);}
case 60:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",63);}
case 63:{f.Push(JValue.R(rt.String(": ")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",68);}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",75);}
case 75:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",83);}
case 83:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

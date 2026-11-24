// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1008{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerTaps","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10723,"forge/game/trigger/TriggerTaps","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10723));
c.Add(new JMethod(10724,"forge/game/trigger/TriggerTaps","performTest","(Ljava/util/Map;)Z",17,3,4,new JHandler[]{},M10724));
c.Add(new JMethod(10725,"forge/game/trigger/TriggerTaps","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,3,6,new JHandler[]{},M10725));
c.Add(new JMethod(10726,"forge/game/trigger/TriggerTaps","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10726));
}

internal static JStep M10723(JRuntime rt,JFrame f)
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

internal static JStep M10724(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/game/trigger/TriggerTaps","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",32);}
case 32:{return rt.Call(f,"forge/game/trigger/TriggerTaps","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",52);}
case 52:{return rt.Call(f,"forge/game/trigger/TriggerTaps","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int!=0?60:58;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Attacker")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/trigger/TriggerTaps","hasParam","(Ljava/lang/String;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?100:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("Attacker")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/trigger/TriggerTaps","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",75);}
case 75:{f.Push(JValue.R(rt.String("True")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",80);}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",95);}
case 95:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?100:98;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("FirstTime")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/trigger/TriggerTaps","hasParam","(Ljava/lang/String;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?129:109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","FirstTime","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","FirstTime","Lforge/game/ability/AbilityKey;"));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",118);}
case 118:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",124);}
case 124:{f.Pc=f.Pop().Int!=0?129:127;continue;}
case 127:{f.Push(JValue.I(0));f.Pc=128;continue;}
case 128:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("Teamwork")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/trigger/TriggerTaps","hasParam","(Ljava/lang/String;)Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int==0?167:138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IndividualCostPaymentInstance","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IndividualCostPaymentInstance","Lforge/game/ability/AbilityKey;"));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",147);}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/CostPaymentStack$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{f.Locals[2]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{f.Pc=f.Pop().Reference==null?165:155;continue;}
case 155:{f.Push(f.Locals[2]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/zone/CostPaymentStack$Entry","cost","()Lforge/game/cost/CostPart;","invokevirtual",159);}
case 159:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostTeamwork")?1:0));f.Pc=162;continue;}
case 162:{f.Pc=f.Pop().Int!=0?167:165;continue;}
case 165:{f.Push(JValue.I(0));f.Pc=166;continue;}
case 166:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 167:{f.Push(JValue.I(1));f.Pc=168;continue;}
case 168:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10725(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=11;continue;}
case 11:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/ability/AbilityKey","copyKeys","(Ljava/util/Map;Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokestatic",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10726(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",12);}
case 12:{f.Push(JValue.R(rt.String("lblTapped")));f.Pc=14;continue;}
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
case 41:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",44);}
case 44:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

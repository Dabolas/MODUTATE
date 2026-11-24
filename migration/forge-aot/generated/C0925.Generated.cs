// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C925{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerCounterRemoved","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10343,"forge/game/trigger/TriggerCounterRemoved","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10343));
c.Add(new JMethod(10344,"forge/game/trigger/TriggerCounterRemoved","performTest","(Ljava/util/Map;)Z",17,6,4,new JHandler[]{},M10344));
c.Add(new JMethod(10345,"forge/game/trigger/TriggerCounterRemoved","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,3,6,new JHandler[]{},M10345));
c.Add(new JMethod(10346,"forge/game/trigger/TriggerCounterRemoved","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10346));
}

internal static JStep M10343(JRuntime rt,JFrame f)
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

internal static JStep M10344(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterType","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterType","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","NewCounterAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","NewCounterAmount","Lforge/game/ability/AbilityKey;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",38);}
case 38:{return rt.Call(f,"forge/game/trigger/TriggerCounterRemoved","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int!=0?46:44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",58);}
case 58:{return rt.Call(f,"forge/game/trigger/TriggerCounterRemoved","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?66:64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/trigger/TriggerCounterRemoved","hasParam","(Ljava/lang/String;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?97:75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/trigger/TriggerCounterRemoved","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",81);}
case 81:{f.Locals[4]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",89);}
case 89:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int!=0?97:95;continue;}
case 95:{f.Push(JValue.I(0));f.Pc=96;continue;}
case 96:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("NewCounterAmount")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/trigger/TriggerCounterRemoved","hasParam","(Ljava/lang/String;)Z","invokevirtual",103);}
case 103:{f.Pc=f.Pop().Int==0?132:106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("NewCounterAmount")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/trigger/TriggerCounterRemoved","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",112);}
case 112:{f.Locals[4]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",119);}
case 119:{f.Locals[5]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",127);}
case 127:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?132:130;continue;}
case 130:{f.Push(JValue.I(0));f.Pc=131;continue;}
case 131:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 132:{f.Push(JValue.I(1));f.Pc=133;continue;}
case 133:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10345(JRuntime rt,JFrame f)
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

internal static JStep M10346(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",12);}
case 12:{f.Push(JValue.R(rt.String("lblRemovedFrom")));f.Pc=14;continue;}
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

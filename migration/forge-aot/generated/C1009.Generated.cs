// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1009{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerTapsForMana","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10727,"forge/game/trigger/TriggerTapsForMana","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10727));
c.Add(new JMethod(10728,"forge/game/trigger/TriggerTapsForMana","performTest","(Ljava/util/Map;)Z",17,4,4,new JHandler[]{},M10728));
c.Add(new JMethod(10729,"forge/game/trigger/TriggerTapsForMana","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,3,6,new JHandler[]{},M10729));
c.Add(new JMethod(10730,"forge/game/trigger/TriggerTapsForMana","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,2,5,new JHandler[]{},M10730));
}

internal static JStep M10727(JRuntime rt,JFrame f)
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

internal static JStep M10728(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/game/trigger/TriggerTapsForMana","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Activator")));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",32);}
case 32:{return rt.Call(f,"forge/game/trigger/TriggerTapsForMana","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Produced")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/trigger/TriggerTapsForMana","hasParam","(Ljava/lang/String;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?134:49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",58);}
case 58:{f.Locals[2]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/String")?1:0));f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Int!=0?68:66;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{f.Locals[3]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("Produced")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/trigger/TriggerTapsForMana","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",81);}
case 81:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?116:87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/trigger/TriggerTapsForMana","getHostCard","()Lforge/game/card/Card;","invokevirtual",91);}
case 91:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?114:97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/trigger/TriggerTapsForMana","getHostCard","()Lforge/game/card/Card;","invokevirtual",102);}
case 102:{return rt.Call(f,"forge/game/card/Card","getChosenColor","()Ljava/lang/String;","invokevirtual",105);}
case 105:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",108);}
case 108:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int!=0?134:114;continue;}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("Produced")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/trigger/TriggerTapsForMana","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",123);}
case 123:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",126);}
case 126:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",129);}
case 129:{f.Pc=f.Pop().Int!=0?134:132;continue;}
case 132:{f.Push(JValue.I(0));f.Pc=133;continue;}
case 133:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 134:{f.Push(JValue.I(1));f.Pc=135;continue;}
case 135:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10729(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(3));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=11;continue;}
case 11:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"));f.Pc=17;continue;}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(2));f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"));f.Pc=23;continue;}
case 23:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/ability/AbilityKey","copyKeys","(Ljava/util/Map;Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokestatic",27);}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10730(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3);}
case 3:{f.Push(JValue.R(rt.String("lblTappedForMana")));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",19);}
case 19:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",22);}
case 22:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",25);}
case 25:{f.Push(JValue.R(rt.String("lblProduced")));f.Pc=27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",41);}
case 41:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/util/TextUtil","toManaString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",47);}
case 47:{return rt.DynamicCall(f,"forge/game/trigger/TriggerTapsForMana:10730:47:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",52);}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

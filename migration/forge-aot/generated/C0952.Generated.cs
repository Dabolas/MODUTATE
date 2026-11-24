// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C952{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerExiled","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10457,"forge/game/trigger/TriggerExiled","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10457));
c.Add(new JMethod(10458,"forge/game/trigger/TriggerExiled","performTest","(Ljava/util/Map;)Z",17,3,4,new JHandler[]{},M10458));
c.Add(new JMethod(10459,"forge/game/trigger/TriggerExiled","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,3,6,new JHandler[]{},M10459));
c.Add(new JMethod(10460,"forge/game/trigger/TriggerExiled","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,2,3,new JHandler[]{},M10460));
}

internal static JStep M10457(JRuntime rt,JFrame f)
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

internal static JStep M10458(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Origin")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/trigger/TriggerExiled","hasParam","(Ljava/lang/String;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?75:22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Origin")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/trigger/TriggerExiled","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",28);}
case 28:{f.Push(JValue.R(rt.String("Any")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?75:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("Origin")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/trigger/TriggerExiled","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Reference!=null?47:45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("Origin")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/trigger/TriggerExiled","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",53);}
case 53:{f.Push(JValue.R(rt.String(",")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",58);}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",67);}
case 67:{return rt.Call(f,"org/apache/commons/lang3/ArrayUtils","contains","([Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",70);}
case 70:{f.Pc=f.Pop().Int!=0?75:73;continue;}
case 73:{f.Push(JValue.I(0));f.Pc=74;continue;}
case 74:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",87);}
case 87:{return rt.Call(f,"forge/game/trigger/TriggerExiled","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int!=0?95:93;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/trigger/TriggerExiled","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int!=0?107:105;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("WhileKeyword")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/trigger/TriggerExiled","hasParam","(Ljava/lang/String;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?132:116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("WhileKeyword")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/trigger/TriggerExiled","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",123);}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/trigger/TriggerExiled","whileKeywordCheck","(Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int!=0?132:130;continue;}
case 130:{f.Push(JValue.I(0));f.Pc=131;continue;}
case 131:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","MADNESS","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","MADNESS","Lforge/game/keyword/Keyword;"));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/trigger/TriggerExiled","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int==0?184:142;continue;}
case 142:{f.Push(f.Locals[2]);f.Pc=143;continue;}
case 143:{f.Pc=f.Pop().Reference==null?156:146;continue;}
case 146:{f.Push(f.Locals[2]);f.Pc=147;continue;}
case 147:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","MADNESS","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","MADNESS","Lforge/game/keyword/Keyword;"));f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int!=0?158:156;continue;}
case 156:{f.Push(JValue.I(0));f.Pc=157;continue;}
case 157:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/trigger/TriggerExiled","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",162);}
case 162:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",167);}
case 167:{f.Push(f.Locals[2]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",171);}
case 171:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",176);}
case 176:{return rt.Call(f,"java/util/Objects","equals","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",179);}
case 179:{f.Pc=f.Pop().Int!=0?184:182;continue;}
case 182:{f.Push(JValue.I(0));f.Pc=183;continue;}
case 183:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 184:{f.Push(JValue.I(1));f.Pc=185;continue;}
case 185:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10459(JRuntime rt,JFrame f)
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

internal static JStep M10460(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3);}
case 3:{f.Push(JValue.R(rt.String("lblExiled")));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",19);}
case 19:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",22);}
case 22:{return rt.DynamicCall(f,"forge/game/trigger/TriggerExiled:10460:22:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",27);}
case 27:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

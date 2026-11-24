// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C944{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerDrawn","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10424,"forge/game/trigger/TriggerDrawn","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10424));
c.Add(new JMethod(10425,"forge/game/trigger/TriggerDrawn","performTest","(Ljava/util/Map;)Z",17,5,4,new JHandler[]{},M10425));
c.Add(new JMethod(10426,"forge/game/trigger/TriggerDrawn","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,3,6,new JHandler[]{},M10426));
c.Add(new JMethod(10427,"forge/game/trigger/TriggerDrawn","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10427));
}

internal static JStep M10424(JRuntime rt,JFrame f)
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

internal static JStep M10425(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/TriggerDrawn","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",36);}
case 36:{return rt.Call(f,"forge/game/trigger/TriggerDrawn","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int!=0?44:42;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",56);}
case 56:{return rt.Call(f,"forge/game/trigger/TriggerDrawn","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int!=0?64:62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("Number")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/trigger/TriggerDrawn","hasParam","(Ljava/lang/String;)Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int==0?88:73;continue;}
case 73:{f.Push(f.Locals[3]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("Number")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/trigger/TriggerDrawn","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",80);}
case 80:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",83);}
case 83:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?88:86;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("FirstCardInDrawStep")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/trigger/TriggerDrawn","hasParam","(Ljava/lang/String;)Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?177:97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",106);}
case 106:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=109;continue;}
case 109:{f.Locals[4]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("FirstCardInDrawStep")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/trigger/TriggerDrawn","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",117);}
case 117:{f.Push(JValue.R(rt.String("True")));f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",122);}
case 122:{f.Pc=f.Pop().Int==0?151:125;continue;}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",129);}
case 129:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"));f.Pc=132;continue;}
case 132:{f.Push(f.Locals[4]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/phase/PhaseHandler","is","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;)Z","invokevirtual",137);}
case 137:{f.Pc=f.Pop().Int==0?149:140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/player/Player","numDrawnThisDrawStep","()I","invokevirtual",145);}
case 145:{f.Push(JValue.I(1));f.Pc=146;continue;}
case 146:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?177:149;continue;}
case 149:{f.Push(JValue.I(0));f.Pc=150;continue;}
case 150:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 151:{f.Push(f.Locals[4]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/player/Player","numDrawnThisDrawStep","()I","invokevirtual",156);}
case 156:{f.Push(JValue.I(1));f.Pc=157;continue;}
case 157:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?177:160;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",164);}
case 164:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"));f.Pc=167;continue;}
case 167:{f.Push(f.Locals[4]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/phase/PhaseHandler","is","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;)Z","invokevirtual",172);}
case 172:{f.Pc=f.Pop().Int==0?177:175;continue;}
case 175:{f.Push(JValue.I(0));f.Pc=176;continue;}
case 176:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 177:{f.Push(f.Locals[2]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/Game","getAge","()Lforge/game/GameStage;","invokevirtual",181);}
case 181:{if(!rt.StaticReady(f,"forge/game/GameStage","Mulligan","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","Mulligan","Lforge/game/GameStage;"));f.Pc=184;continue;}
case 184:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?189:187;continue;}
case 187:{f.Push(JValue.I(0));f.Pc=188;continue;}
case 188:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 189:{f.Push(f.Locals[1]);f.Pc=190;continue;}
case 190:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CanReveal","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CanReveal","Lforge/game/ability/AbilityKey;"));f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",198);}
case 198:{f.Pc=f.Pop().Int==0?241:201;continue;}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CanReveal","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CanReveal","Lforge/game/ability/AbilityKey;"));f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",210);}
case 210:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",216);}
case 216:{f.Locals[4]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{f.Push(JValue.R(rt.String("ForReveal")));f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/game/trigger/TriggerDrawn","hasParam","(Ljava/lang/String;)Z","invokevirtual",224);}
case 224:{f.Pc=f.Pop().Int==0?234:227;continue;}
case 227:{f.Push(f.Locals[4]);f.Pc=229;continue;}
case 229:{f.Pc=f.Pop().Int!=0?241:232;continue;}
case 232:{f.Push(JValue.I(0));f.Pc=233;continue;}
case 233:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 234:{f.Push(f.Locals[4]);f.Pc=236;continue;}
case 236:{f.Pc=f.Pop().Int==0?241:239;continue;}
case 239:{f.Push(JValue.I(0));f.Pc=240;continue;}
case 240:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 241:{f.Push(JValue.I(1));f.Pc=242;continue;}
case 242:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10426(JRuntime rt,JFrame f)
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

internal static JStep M10427(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",12);}
case 12:{f.Push(JValue.R(rt.String("lblPlayer")));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.Push(JValue.R(rt.String(": ")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",44);}
case 44:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C753{
internal static JClass Build(){var c=new JClass("forge/game/replacement/ReplaceDraw","forge/game/replacement/ReplacementEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(8915,"forge/game/replacement/ReplaceDraw","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M8915));
c.Add(new JMethod(8916,"forge/game/replacement/ReplaceDraw","canReplace","(Ljava/util/Map;)Z",1,4,4,new JHandler[]{},M8916));
c.Add(new JMethod(8917,"forge/game/replacement/ReplaceDraw","setReplacingObjects","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V",1,4,4,new JHandler[]{},M8917));
}

internal static JStep M8915(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8916(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/replacement/ReplaceDraw","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int!=0?25:23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",37);}
case 37:{return rt.Call(f,"forge/game/replacement/ReplaceDraw","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int!=0?45:43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/replacement/ReplaceDraw","getHostCard","()Lforge/game/card/Card;","invokevirtual",49);}
case 49:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",52);}
case 52:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",55);}
case 55:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/phase/PhaseHandler","is","(Lforge/game/phase/PhaseType;Lforge/game/player/Player;)Z","invokevirtual",62);}
case 62:{f.Locals[3]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("NotFirstCardInDrawStep")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/replacement/ReplaceDraw","hasParam","(Ljava/lang/String;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?85:72;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/player/Player","numDrawnThisDrawStep","()I","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int!=0?85:79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{f.Pc=f.Pop().Int==0?85:83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("FirstExtraCardDrawnThisTurn")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/replacement/ReplaceDraw","hasParam","(Ljava/lang/String;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?123:94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ExtraDraws","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ExtraDraws","Lforge/game/ability/AbilityKey;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",109);}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{f.Pc=f.Pop().Int==0?117:113;continue;}
case 113:{f.Push(JValue.I(1));f.Pc=114;continue;}
case 114:{f.Pc=118;continue;}
case 117:{f.Push(JValue.I(0));f.Pc=118;continue;}
case 118:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?123:121;continue;}
case 121:{f.Push(JValue.I(0));f.Pc=122;continue;}
case 122:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 123:{f.Push(JValue.I(1));f.Pc=124;continue;}
case 124:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8917(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13);}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?64:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Reference==null?64:45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",53);}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",61);}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",64);}
case 64:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

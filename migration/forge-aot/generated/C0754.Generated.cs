// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C754{
internal static JClass Build(){var c=new JClass("forge/game/replacement/ReplaceDrawCards","forge/game/replacement/ReplacementEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(8918,"forge/game/replacement/ReplaceDrawCards","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M8918));
c.Add(new JMethod(8919,"forge/game/replacement/ReplaceDrawCards","canReplace","(Ljava/util/Map;)Z",1,6,4,new JHandler[]{},M8919));
c.Add(new JMethod(8920,"forge/game/replacement/ReplaceDrawCards","setReplacingObjects","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V",1,3,4,new JHandler[]{},M8920));
}

internal static JStep M8918(JRuntime rt,JFrame f)
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

internal static JStep M8919(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/game/replacement/ReplaceDrawCards","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Number")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/replacement/ReplaceDrawCards","hasParam","(Ljava/lang/String;)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?83:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",44);}
case 44:{f.Locals[2]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("Number")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/replacement/ReplaceDrawCards","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",51);}
case 51:{f.Locals[3]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{f.Push(JValue.I(2));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",58);}
case 58:{f.Locals[4]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(2));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",65);}
case 65:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",68);}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",78);}
case 78:{f.Pc=f.Pop().Int!=0?83:81;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8920(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13);}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",32);}
case 32:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

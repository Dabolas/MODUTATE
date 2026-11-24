// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C912{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerChaosEnsues","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10290,"forge/game/trigger/TriggerChaosEnsues","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10290));
c.Add(new JMethod(10291,"forge/game/trigger/TriggerChaosEnsues","performTest","(Ljava/util/Map;)Z",1,5,4,new JHandler[]{},M10291));
c.Add(new JMethod(10292,"forge/game/trigger/TriggerChaosEnsues","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",1,3,6,new JHandler[]{},M10292));
c.Add(new JMethod(10293,"forge/game/trigger/TriggerChaosEnsues","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,2,1,new JHandler[]{},M10293));
}

internal static JStep M10290(JRuntime rt,JFrame f)
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

internal static JStep M10291(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/game/trigger/TriggerChaosEnsues","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?121:32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{f.Locals[2]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/GameObject")?1:0));f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Int==0?70:49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[3]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/trigger/TriggerChaosEnsues","getHostCard","()Lforge/game/card/Card;","invokevirtual",59);}
case 59:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int!=0?67:65;continue;}
case 65:{f.Push(JValue.I(0));f.Pc=66;continue;}
case 66:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 67:{f.Pc=121;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/Iterable")?1:0));f.Pc=74;continue;}
case 74:{f.Pc=f.Pop().Int==0?121:77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",86);}
case 86:{f.Locals[3]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",93);}
case 93:{f.Pc=f.Pop().Int==0?121:96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",102);}
case 102:{f.Locals[4]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[4]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/trigger/TriggerChaosEnsues","getHostCard","()Lforge/game/card/Card;","invokevirtual",110);}
case 110:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int!=0?118:116;continue;}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 118:{f.Pc=87;continue;}
case 121:{f.Push(JValue.I(1));f.Pc=122;continue;}
case 122:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10292(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=11;continue;}
case 11:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/ability/AbilityKey","copyKeys","(Ljava/util/Map;Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokestatic",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10293(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

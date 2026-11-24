// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C987{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerPhaseOutAll","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10637,"forge/game/trigger/TriggerPhaseOutAll","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10637));
c.Add(new JMethod(10638,"forge/game/trigger/TriggerPhaseOutAll","performTest","(Ljava/util/Map;)Z",1,2,4,new JHandler[]{},M10638));
c.Add(new JMethod(10639,"forge/game/trigger/TriggerPhaseOutAll","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",1,4,5,new JHandler[]{},M10639));
c.Add(new JMethod(10640,"forge/game/trigger/TriggerPhaseOutAll","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10640));
}

internal static JStep M10637(JRuntime rt,JFrame f)
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

internal static JStep M10638(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/game/trigger/TriggerPhaseOutAll","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10639(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/trigger/TriggerPhaseOutAll","hasParam","(Ljava/lang/String;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?53:22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/trigger/TriggerPhaseOutAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Push(JValue.R(rt.String(",")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/trigger/TriggerPhaseOutAll","getHostCard","()Lforge/game/card/Card;","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",41);}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/trigger/TriggerPhaseOutAll","getHostCard","()Lforge/game/card/Card;","invokevirtual",45);}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/CardPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",49);}
case 49:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",52);}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10640(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",12);}
case 12:{f.Push(JValue.R(rt.String("lblPhasedOut")));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.Push(JValue.R(rt.String(": ")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",38);}
case 38:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",46);}
case 46:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

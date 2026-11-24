// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C836{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityCantPhase","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9939,"forge/game/staticability/StaticAbilityCantPhase","<init>","()V",1,1,1,new JHandler[]{},M9939));
c.Add(new JMethod(9940,"forge/game/staticability/StaticAbilityCantPhase","cantPhaseIn","(Lforge/game/card/Card;)Z",9,1,2,new JHandler[]{},M9940));
c.Add(new JMethod(9941,"forge/game/staticability/StaticAbilityCantPhase","cantPhaseOut","(Lforge/game/card/Card;)Z",9,1,2,new JHandler[]{},M9941));
c.Add(new JMethod(9942,"forge/game/staticability/StaticAbilityCantPhase","cantPhase","(Lforge/game/card/Card;Lforge/game/staticability/StaticAbilityMode;)Z",10,7,2,new JHandler[]{},M9942));
c.Add(new JMethod(9943,"forge/game/staticability/StaticAbilityCantPhase","applyCantPhase","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;)Z",10,2,3,new JHandler[]{},M9943));
}

internal static JStep M9939(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9940(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPhaseIn","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantPhaseIn","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantPhase","cantPhase","(Lforge/game/card/Card;Lforge/game/staticability/StaticAbilityMode;)Z","invokestatic",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9941(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPhaseOut","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantPhaseOut","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantPhase","cantPhase","(Lforge/game/card/Card;Lforge/game/staticability/StaticAbilityMode;)Z","invokestatic",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9942(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?101:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",48);}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",57);}
case 57:{f.Pc=f.Pop().Int==0?98:60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Locals[6]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int!=0?84:81;continue;}
case 81:{f.Pc=50;continue;}
case 84:{f.Push(f.Locals[6]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantPhase","applyCantPhase","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;)Z","invokestatic",90);}
case 90:{f.Pc=f.Pop().Int==0?95:93;continue;}
case 93:{f.Push(JValue.I(1));f.Pc=94;continue;}
case 94:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 95:{f.Pc=50;continue;}
case 98:{f.Pc=18;continue;}
case 101:{f.Push(JValue.I(0));f.Pc=102;continue;}
case 102:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9943(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C877{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityTurnPhaseReversed","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10097,"forge/game/staticability/StaticAbilityTurnPhaseReversed","<init>","()V",1,1,1,new JHandler[]{},M10097));
c.Add(new JMethod(10098,"forge/game/staticability/StaticAbilityTurnPhaseReversed","isTurnReversed","(Lforge/game/player/Player;)Z",9,1,2,new JHandler[]{},M10098));
c.Add(new JMethod(10099,"forge/game/staticability/StaticAbilityTurnPhaseReversed","isPhaseReversed","(Lforge/game/player/Player;)Z",9,1,2,new JHandler[]{},M10099));
c.Add(new JMethod(10100,"forge/game/staticability/StaticAbilityTurnPhaseReversed","anyTurnPhaseReversed","(Lforge/game/player/Player;Lforge/game/staticability/StaticAbilityMode;)Z",12,8,2,new JHandler[]{},M10100));
c.Add(new JMethod(10101,"forge/game/staticability/StaticAbilityTurnPhaseReversed","applyTurnPhaseReversed","(Lforge/game/staticability/StaticAbility;Lforge/game/player/Player;)Z",12,2,3,new JHandler[]{},M10101));
}

internal static JStep M10097(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10098(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","TurnReversed","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","TurnReversed","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbilityTurnPhaseReversed","anyTurnPhaseReversed","(Lforge/game/player/Player;Lforge/game/staticability/StaticAbilityMode;)Z","invokestatic",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10099(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","PhaseReversed","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","PhaseReversed","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbilityTurnPhaseReversed","anyTurnPhaseReversed","(Lforge/game/player/Player;Lforge/game/staticability/StaticAbilityMode;)Z","invokestatic",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10100(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?114:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",53);}
case 53:{f.Locals[6]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[6]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",62);}
case 62:{f.Pc=f.Pop().Int==0?111:65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Locals[7]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[7]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int!=0?89:86;continue;}
case 86:{f.Pc=55;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/staticability/StaticAbilityTurnPhaseReversed","applyTurnPhaseReversed","(Lforge/game/staticability/StaticAbility;Lforge/game/player/Player;)Z","invokestatic",95);}
case 95:{f.Pc=f.Pop().Int==0?108:98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Int!=0?106:102;continue;}
case 102:{f.Push(JValue.I(1));f.Pc=103;continue;}
case 103:{f.Pc=107;continue;}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{f.Locals[2]=f.Pop();f.Pc=108;continue;}
case 108:{f.Pc=55;continue;}
case 111:{f.Pc=21;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10101(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

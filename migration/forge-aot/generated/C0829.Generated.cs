// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C829{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityCantChangeDayTime","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9915,"forge/game/staticability/StaticAbilityCantChangeDayTime","<init>","()V",1,1,1,new JHandler[]{},M9915));
c.Add(new JMethod(9916,"forge/game/staticability/StaticAbilityCantChangeDayTime","cantChangeDay","(Lforge/game/Game;Ljava/lang/Boolean;)Z",9,6,2,new JHandler[]{},M9916));
c.Add(new JMethod(9917,"forge/game/staticability/StaticAbilityCantChangeDayTime","cantChangeDayCheck","(Lforge/game/staticability/StaticAbility;Ljava/lang/Boolean;)Z",10,4,2,new JHandler[]{},M9917));
}

internal static JStep M9915(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9916(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?102:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",42);}
case 42:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",47);}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",56);}
case 56:{f.Pc=f.Pop().Int==0?99:59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",66);}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{f.Locals[5]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantChangeDayTime","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantChangeDayTime","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int!=0?85:82;continue;}
case 82:{f.Pc=49;continue;}
case 85:{f.Push(f.Locals[5]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantChangeDayTime","cantChangeDayCheck","(Lforge/game/staticability/StaticAbility;Ljava/lang/Boolean;)Z","invokestatic",91);}
case 91:{f.Pc=f.Pop().Int==0?96:94;continue;}
case 94:{f.Push(JValue.I(1));f.Pc=95;continue;}
case 95:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 96:{f.Pc=49;continue;}
case 99:{f.Pc=19;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9917(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("NewTime")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?119:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("NewTime")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.I(-1));f.Pc=17;continue;}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",22);}
case 22:{switch(f.Pop().Int){case 68476:f.Pc=48;break;case 75265016:f.Pc=62;break;default:f.Pc=73;break;}continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("Day")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?73:57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{f.Locals[3]=f.Pop();f.Pc=59;continue;}
case 59:{f.Pc=73;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("Night")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int==0?73:71;continue;}
case 71:{f.Push(JValue.I(1));f.Pc=72;continue;}
case 72:{f.Locals[3]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[3]);f.Pc=74;continue;}
case 74:{switch(f.Pop().Int){case 0:f.Pc=100;break;case 1:f.Pc=109;break;default:f.Pc=119;break;}continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?109:107;continue;}
case 107:{f.Push(JValue.I(0));f.Pc=108;continue;}
case 108:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",113);}
case 113:{f.Push(JValue.I(1));f.Pc=114;continue;}
case 114:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?119:117;continue;}
case 117:{f.Push(JValue.I(0));f.Pc=118;continue;}
case 118:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 119:{f.Push(JValue.I(1));f.Pc=120;continue;}
case 120:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

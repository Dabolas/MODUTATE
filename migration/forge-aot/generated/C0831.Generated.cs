// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C831{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityCantDiscard","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9921,"forge/game/staticability/StaticAbilityCantDiscard","<init>","()V",1,1,1,new JHandler[]{},M9921));
c.Add(new JMethod(9922,"forge/game/staticability/StaticAbilityCantDiscard","cantDiscard","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Z)Z",9,8,4,new JHandler[]{},M9922));
c.Add(new JMethod(9923,"forge/game/staticability/StaticAbilityCantDiscard","applyCantDiscardAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Z)Z",9,4,3,new JHandler[]{},M9923));
}

internal static JStep M9921(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9922(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?108:29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",51);}
case 51:{f.Locals[6]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",60);}
case 60:{f.Pc=f.Pop().Int==0?105:63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{f.Locals[7]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantDiscard","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantDiscard","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int!=0?89:86;continue;}
case 86:{f.Pc=53;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantDiscard","applyCantDiscardAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Z)Z","invokestatic",97);}
case 97:{f.Pc=f.Pop().Int==0?102:100;continue;}
case 100:{f.Push(JValue.I(1));f.Pc=101;continue;}
case 101:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 102:{f.Pc=53;continue;}
case 105:{f.Pc=19;continue;}
case 108:{f.Push(JValue.I(0));f.Pc=109;continue;}
case 109:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9923(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("ForCost")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?38:21;continue;}
case 21:{f.Push(JValue.R(rt.String("True")));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("ForCost")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?38:36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int!=0?50:48;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

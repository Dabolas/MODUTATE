// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C879{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityUntapOtherPlayer","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10106,"forge/game/staticability/StaticAbilityUntapOtherPlayer","<init>","()V",1,1,1,new JHandler[]{},M10106));
c.Add(new JMethod(10107,"forge/game/staticability/StaticAbilityUntapOtherPlayer","untap","(Lforge/game/card/Card;Lforge/game/player/Player;)Z",9,6,3,new JHandler[]{},M10107));
c.Add(new JMethod(10108,"forge/game/staticability/StaticAbilityUntapOtherPlayer","applyUntapAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z",9,3,3,new JHandler[]{},M10108));
}

internal static JStep M10106(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10107(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?100:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",44);}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",53);}
case 53:{f.Pc=f.Pop().Int==0?97:56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[5]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","UntapOtherPlayer","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","UntapOtherPlayer","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int!=0?82:79;continue;}
case 79:{f.Pc=46;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/staticability/StaticAbilityUntapOtherPlayer","applyUntapAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokestatic",89);}
case 89:{f.Pc=f.Pop().Int==0?94:92;continue;}
case 92:{f.Push(JValue.I(1));f.Pc=93;continue;}
case 93:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 94:{f.Pc=46;continue;}
case 97:{f.Pc=16;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10108(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int!=0?24:22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

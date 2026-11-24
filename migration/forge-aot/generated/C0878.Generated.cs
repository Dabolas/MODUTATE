// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C878{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityUnspentMana","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10102,"forge/game/staticability/StaticAbilityUnspentMana","<init>","()V",1,1,1,new JHandler[]{},M10102));
c.Add(new JMethod(10103,"forge/game/staticability/StaticAbilityUnspentMana","getManaToKeep","(Lforge/game/player/Player;)Ljava/util/Collection;",9,7,3,new JHandler[]{},M10103));
c.Add(new JMethod(10104,"forge/game/staticability/StaticAbilityUnspentMana","hasManaBurn","(Lforge/game/player/Player;)Z",9,6,3,new JHandler[]{},M10104));
c.Add(new JMethod(10105,"forge/game/staticability/StaticAbilityUnspentMana","applyUnspentManaAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/player/Player;Ljava/util/Set;)V",10,7,3,new JHandler[]{},M10105));
}

internal static JStep M10102(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10103(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?103:31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[4]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",52);}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[5]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",61);}
case 61:{f.Pc=f.Pop().Int==0?100:64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{f.Locals[6]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","UnspentMana","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","UnspentMana","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int!=0?90:87;continue;}
case 87:{f.Pc=54;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/staticability/StaticAbilityUnspentMana","applyUnspentManaAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/player/Player;Ljava/util/Set;)V","invokestatic",97);}
case 97:{f.Pc=54;continue;}
case 100:{f.Pc=22;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10104(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?102:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",46);}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?99:58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ManaBurn","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","ManaBurn","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int!=0?84:81;continue;}
case 81:{f.Pc=48;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int!=0?97:95;continue;}
case 95:{f.Push(JValue.I(0));f.Pc=96;continue;}
case 96:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 97:{f.Push(JValue.I(1));f.Pc=98;continue;}
case 98:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 99:{f.Pc=18;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10105(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?11:10;continue;}
case 10:{return JStep.ReturnVoid;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("ManaType")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?65:20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/card/mana/ManaAtom","MANATYPES","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaAtom","MANATYPES","[B"));f.Pc=23;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=26;continue;}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?62:38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=42;continue;}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",50);}
case 50:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=59;continue;}
case 59:{f.Pc=31;continue;}
case 62:{f.Pc=84;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("ManaType")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",72);}
case 72:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",75);}
case 75:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",78);}
case 78:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

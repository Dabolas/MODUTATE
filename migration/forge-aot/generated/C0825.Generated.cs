// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C825{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityCantBeCast","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9899,"forge/game/staticability/StaticAbilityCantBeCast","<init>","()V",1,1,1,new JHandler[]{},M9899));
c.Add(new JMethod(9900,"forge/game/staticability/StaticAbilityCantBeCast","cantBeCastAbility","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z",9,9,4,new JHandler[]{},M9900));
c.Add(new JMethod(9901,"forge/game/staticability/StaticAbilityCantBeCast","cantBeActivatedAbility","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z",9,8,4,new JHandler[]{},M9901));
c.Add(new JMethod(9902,"forge/game/staticability/StaticAbilityCantBeCast","cantPlayLandAbility","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z",9,8,3,new JHandler[]{},M9902));
c.Add(new JMethod(9903,"forge/game/staticability/StaticAbilityCantBeCast","applyCantBeCastAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z",9,7,4,new JHandler[]{},M9903));
c.Add(new JMethod(9904,"forge/game/staticability/StaticAbilityCantBeCast","applyCantBeActivatedAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z",9,4,3,new JHandler[]{},M9904));
c.Add(new JMethod(9905,"forge/game/staticability/StaticAbilityCantBeCast","applyCantPlayLandAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z",9,4,3,new JHandler[]{},M9905));
}

internal static JStep M9899(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9900(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","setCastSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",32);}
case 32:{f.StackOp("pop");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",38);}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",47);}
case 47:{f.Pc=f.Pop().Int==0?129:50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",67);}
case 67:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",72);}
case 72:{f.Locals[7]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[7]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",81);}
case 81:{f.Pc=f.Pop().Int==0?126:84;continue;}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",91);}
case 91:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=94;continue;}
case 94:{f.Locals[8]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBeCast","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantBeCast","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int!=0?110:107;continue;}
case 107:{f.Pc=74;continue;}
case 110:{f.Push(f.Locals[8]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantBeCast","applyCantBeCastAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokestatic",118);}
case 118:{f.Pc=f.Pop().Int==0?123:121;continue;}
case 121:{f.Push(JValue.I(1));f.Pc=122;continue;}
case 122:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 123:{f.Pc=74;continue;}
case 126:{f.Pc=40;continue;}
case 129:{f.Push(JValue.I(0));f.Pc=130;continue;}
case 130:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9901(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",26);}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?117:38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",45);}
case 45:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=48;continue;}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",60);}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",69);}
case 69:{f.Pc=f.Pop().Int==0?114:72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{f.Locals[7]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBeActivated","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantBeActivated","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int!=0?98:95;continue;}
case 95:{f.Pc=62;continue;}
case 98:{f.Push(f.Locals[7]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantBeCast","applyCantBeActivatedAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokestatic",106);}
case 106:{f.Pc=f.Pop().Int==0?111:109;continue;}
case 109:{f.Push(JValue.I(1));f.Pc=110;continue;}
case 110:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 111:{f.Pc=62;continue;}
case 114:{f.Pc=28;continue;}
case 117:{f.Push(JValue.I(0));f.Pc=118;continue;}
case 118:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9902(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?107:29;continue;}
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
case 60:{f.Pc=f.Pop().Int==0?104:63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{f.Locals[7]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantPlayLand","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantPlayLand","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int!=0?89:86;continue;}
case 86:{f.Pc=53;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantBeCast","applyCantPlayLandAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokestatic",96);}
case 96:{f.Pc=f.Pop().Int==0?101:99;continue;}
case 99:{f.Push(JValue.I(1));f.Pc=100;continue;}
case 100:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 101:{f.Pc=53;continue;}
case 104:{f.Pc=19;continue;}
case 107:{f.Push(JValue.I(0));f.Pc=108;continue;}
case 108:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9903(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("Caster")));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int!=0?24:22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/staticability/StaticAbility","getIgnoreEffectPlayers","()Ljava/util/List;","invokevirtual",28);}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",34);}
case 34:{f.Pc=f.Pop().Int==0?39:37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("OnlySorcerySpeed")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?61:48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Reference==null?61:52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/player/Player","canCastSorcery","()Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?61:59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("Origin")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int==0?107:70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("Origin")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",76);}
case 76:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",79);}
case 79:{f.Locals[4]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/Card","getCastFrom","()Lforge/game/zone/Zone;","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Reference==null?105:88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/Card","getCastFrom","()Lforge/game/zone/Zone;","invokevirtual",94);}
case 94:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",97);}
case 97:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",102);}
case 102:{f.Pc=f.Pop().Int!=0?107:105;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("cmcGT")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?175:116;continue;}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{f.Pc=f.Pop().Reference==null?175:120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("cmcGT")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",126);}
case 126:{f.Push(JValue.R(rt.String("Turns")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?147:134;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",138);}
case 138:{f.Push(f.Locals[3]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/player/Player","getTurn","()I","invokevirtual",142);}
case 142:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?175:145;continue;}
case 145:{f.Push(JValue.I(0));f.Pc=146;continue;}
case 146:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 147:{f.Push(f.Locals[2]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",151);}
case 151:{f.Push(f.Locals[3]);f.Pc=152;continue;}
case 152:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",158);}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("cmcGT")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",164);}
case 164:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",167);}
case 167:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",170);}
case 170:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?175:173;continue;}
case 173:{f.Push(JValue.I(0));f.Pc=174;continue;}
case 174:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 175:{f.Push(f.Locals[0]);f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.String("NumLimitEachTurn")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",181);}
case 181:{f.Pc=f.Pop().Int==0?237:184;continue;}
case 184:{f.Push(f.Locals[3]);f.Pc=185;continue;}
case 185:{f.Pc=f.Pop().Reference==null?237:188;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.String("NumLimitEachTurn")));f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",194);}
case 194:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",197);}
case 197:{f.Locals[4]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[0]);f.Pc=200;continue;}
case 200:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.String("Card")));f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",207);}
case 207:{f.Locals[5]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[5]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[2]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[3]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/card/CardUtil","getThisTurnCast","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",217);}
case 217:{f.Locals[6]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[6]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[3]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/card/CardLists","filterControlledByAsList","(Ljava/lang/Iterable;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",225);}
case 225:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",230);}
case 230:{f.Push(f.Locals[4]);f.Pc=232;continue;}
case 232:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?237:235;continue;}
case 235:{f.Push(JValue.I(0));f.Pc=236;continue;}
case 236:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 237:{f.Push(JValue.I(1));f.Pc=238;continue;}
case 238:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9904(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/staticability/StaticAbility","getIgnoreEffectCards","()Lforge/game/card/CardCollectionView;","invokevirtual",16);}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?27:25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int!=0?39:37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("AffectedZone")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?66:48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("AffectedZone")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",58);}
case 58:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?66:64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("Activator")));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int!=0?78:76;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 78:{f.Push(JValue.I(1));f.Pc=79;continue;}
case 79:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9905(JRuntime rt,JFrame f)
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
case 13:{f.Push(JValue.R(rt.String("Origin")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?49:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Origin")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","getLastKnownZone","()Lforge/game/zone/Zone;","invokevirtual",36);}
case 36:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",39);}
case 39:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",44);}
case 44:{f.Pc=f.Pop().Int!=0?49:47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("Player")));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int!=0?61:59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/staticability/StaticAbility","getIgnoreEffectPlayers","()Ljava/util/List;","invokevirtual",65);}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",71);}
case 71:{f.Pc=f.Pop().Int==0?76:74;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

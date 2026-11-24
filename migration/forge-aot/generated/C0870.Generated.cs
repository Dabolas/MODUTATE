// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C870{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityMustTarget","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10070,"forge/game/staticability/StaticAbilityMustTarget","<init>","()V",1,1,1,new JHandler[]{},M10070));
c.Add(new JMethod(10071,"forge/game/staticability/StaticAbilityMustTarget","filterMustTargetCards","(Lforge/game/player/Player;Ljava/util/List;Lforge/game/spellability/SpellAbility;)Z",9,4,3,new JHandler[]{},M10071));
c.Add(new JMethod(10072,"forge/game/staticability/StaticAbilityMustTarget","meetsMustTargetRestriction","(Lforge/game/spellability/SpellAbility;)Z",9,9,5,new JHandler[]{},M10072));
c.Add(new JMethod(10073,"forge/game/staticability/StaticAbilityMustTarget","getAllRestrictions","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",10,8,3,new JHandler[]{},M10073));
c.Add(new JMethod(10074,"forge/game/staticability/StaticAbilityMustTarget","isRestrictionsMet","(Ljava/util/List;Ljava/util/List;Lforge/game/spellability/SpellAbility;)Z",10,8,2,new JHandler[]{},M10074));
c.Add(new JMethod(10075,"forge/game/staticability/StaticAbilityMustTarget","applyMustTargetCardAbility","(Ljava/util/List;Ljava/util/List;Lforge/game/spellability/SpellAbility;)Z",10,11,3,new JHandler[]{},M10075));
}

internal static JStep M10070(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10071(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",8);}
case 8:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/staticability/StaticAbilityMustTarget","getAllRestrictions","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/staticability/StaticAbilityMustTarget","applyMustTargetCardAbility","(Ljava/util/List;Ljava/util/List;Lforge/game/spellability/SpellAbility;)Z","invokestatic",24);}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10072(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopied","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",16);}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/staticability/StaticAbilityMustTarget","getAllRestrictions","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?33:31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?111:45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("TargetingPlayer")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int!=0?111:54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{f.Locals[4]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",61);}
case 61:{f.Locals[5]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getZone","()Ljava/util/List;","invokevirtual",68);}
case 68:{f.Locals[6]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[6]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",76);}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getValidTgts","()[Ljava/lang/String;","invokevirtual",81);}
case 81:{f.Push(f.Locals[3]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",85);}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",89);}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",93);}
case 93:{f.Locals[7]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/CardLists","getTargetableCards","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",101);}
case 101:{f.Locals[8]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[8]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[3]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/staticability/StaticAbilityMustTarget","isRestrictionsMet","(Ljava/util/List;Ljava/util/List;Lforge/game/spellability/SpellAbility;)Z","invokestatic",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{f.Push(f.Locals[3]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",115);}
case 115:{f.Locals[3]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{f.Pc=f.Pop().Reference!=null?38:120;continue;}
case 120:{f.Push(f.Locals[4]);f.Pc=122;continue;}
case 122:{f.Pc=f.Pop().Int==0?134:125;continue;}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",131);}
case 131:{f.Pc=f.Pop().Int==0?138:134;continue;}
case 134:{f.Push(JValue.I(1));f.Pc=135;continue;}
case 135:{f.Pc=139;continue;}
case 138:{f.Push(JValue.I(0));f.Pc=139;continue;}
case 139:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10073(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",28);}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?156:38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",59);}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int==0?153:71;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",78);}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{f.Locals[6]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MustTarget","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","MustTarget","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?61:94;continue;}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int!=0?108:105;continue;}
case 105:{f.Pc=61;continue;}
case 108:{f.Push(f.Locals[6]);f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",115);}
case 115:{f.Push(f.Locals[6]);f.Pc=117;continue;}
case 117:{f.Push(JValue.R(rt.String("ValidZone")));f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",122);}
case 122:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",125);}
case 125:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",128);}
case 128:{f.Locals[7]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[7]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",138);}
case 138:{f.Pc=f.Pop().Int!=0?150:141;continue;}
case 141:{f.Push(f.Locals[2]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[7]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Pc=61;continue;}
case 153:{f.Pc=29;continue;}
case 156:{f.Push(f.Locals[2]);f.Pc=157;continue;}
case 157:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10074(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",6);}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=8;continue;}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int<0?224:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",20);}
case 20:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=23;continue;}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",35);}
case 35:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",40);}
case 40:{f.Locals[6]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",49);}
case 49:{f.Pc=f.Pop().Int==0?110:52;continue;}
case 52:{f.Push(f.Locals[6]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{f.Locals[7]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[7]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",69);}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",82);}
case 82:{f.Pc=f.Pop().Int==0?107:85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",92);}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?107:101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Pc=110;continue;}
case 107:{f.Pc=42;continue;}
case 110:{f.Push(f.Locals[5]);f.Pc=112;continue;}
case 112:{f.Pc=f.Pop().Int==0?126:115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{f.Pc=218;continue;}
case 126:{f.Push(JValue.I(0));f.Pc=127;continue;}
case 127:{f.Locals[5]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",135);}
case 135:{f.Locals[6]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[6]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",144);}
case 144:{f.Pc=f.Pop().Int==0?205:147;continue;}
case 147:{f.Push(f.Locals[6]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",154);}
case 154:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=157;continue;}
case 157:{f.Locals[7]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[7]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",164);}
case 164:{f.Push(f.Locals[4]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",169);}
case 169:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",177);}
case 177:{f.Pc=f.Pop().Int==0?202:180;continue;}
case 180:{f.Push(f.Locals[7]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[4]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",187);}
case 187:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",193);}
case 193:{f.Pc=f.Pop().Int==0?202:196;continue;}
case 196:{f.Push(JValue.I(1));f.Pc=197;continue;}
case 197:{f.Locals[5]=f.Pop();f.Pc=199;continue;}
case 199:{f.Pc=205;continue;}
case 202:{f.Pc=137;continue;}
case 205:{f.Push(f.Locals[5]);f.Pc=207;continue;}
case 207:{f.Pc=f.Pop().Int!=0?218:210;continue;}
case 210:{f.Push(f.Locals[0]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[3]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",217);}
case 217:{f.StackOp("pop");f.Pc=218;continue;}
case 218:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(-1)));f.Pc=221;continue;}
case 221:{f.Pc=9;continue;}
case 224:{f.Push(f.Locals[0]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",230);}
case 230:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10075(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/staticability/StaticAbilityMustTarget","isRestrictionsMet","(Ljava/util/List;Ljava/util/List;Lforge/game/spellability/SpellAbility;)Z","invokestatic",6);}
case 6:{f.Pc=f.Pop().Int==0?11:9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMaxTargets","()I","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/spellability/TargetChoices","size","()I","invokevirtual",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",31);}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=35;continue;}
case 35:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?46:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",44);}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",55);}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=57;continue;}
case 57:{f.Locals[6]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[6]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Int<0?179:64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Locals[7]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{f.Locals[8]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",86);}
case 86:{f.Locals[9]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[9]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",95);}
case 95:{f.Pc=f.Pop().Int==0?156:98;continue;}
case 98:{f.Push(f.Locals[9]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",105);}
case 105:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=108;continue;}
case 108:{f.Locals[10]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[7]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",115);}
case 115:{f.Push(f.Locals[10]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",120);}
case 120:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",128);}
case 128:{f.Pc=f.Pop().Int==0?153:131;continue;}
case 131:{f.Push(f.Locals[7]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[10]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",138);}
case 138:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int==0?153:147;continue;}
case 147:{f.Push(JValue.I(1));f.Pc=148;continue;}
case 148:{f.Locals[8]=f.Pop();f.Pc=150;continue;}
case 150:{f.Pc=156;continue;}
case 153:{f.Pc=88;continue;}
case 156:{f.Push(f.Locals[8]);f.Pc=158;continue;}
case 158:{f.Pc=f.Pop().Int!=0?173:161;continue;}
case 161:{f.Push(f.Locals[1]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[6]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",169);}
case 169:{f.StackOp("pop");f.Pc=170;continue;}
case 170:{f.Push(JValue.I(1));f.Pc=171;continue;}
case 171:{f.Locals[5]=f.Pop();f.Pc=173;continue;}
case 173:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(-1)));f.Pc=176;continue;}
case 176:{f.Pc=59;continue;}
case 179:{f.Push(f.Locals[5]);f.Pc=181;continue;}
case 181:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

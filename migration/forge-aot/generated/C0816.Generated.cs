// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C816{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityAdditionalActivations","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9849,"forge/game/staticability/StaticAbilityAdditionalActivations","<init>","()V",1,1,1,new JHandler[]{},M9849));
c.Add(new JMethod(9850,"forge/game/staticability/StaticAbilityAdditionalActivations","getLimit","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)I",9,3,4,new JHandler[]{},M9850));
c.Add(new JMethod(9851,"forge/game/staticability/StaticAbilityAdditionalActivations","getLimit","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;I)I",9,11,4,new JHandler[]{},M9851));
c.Add(new JMethod(9852,"forge/game/staticability/StaticAbilityAdditionalActivations","isValid","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z",9,4,3,new JHandler[]{},M9852));
}

internal static JStep M9849(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9850(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbilityAdditionalActivations","getLimit","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;I)I","invokestatic",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9851(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{f.Locals[6]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[6]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?192:33;continue;}
case 33:{f.Push(f.Locals[6]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[7]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[7]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",50);}
case 50:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",55);}
case 55:{f.Locals[8]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[8]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",64);}
case 64:{f.Pc=f.Pop().Int==0?189:67;continue;}
case 67:{f.Push(f.Locals[8]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Locals[9]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[9]);f.Pc=81;continue;}
case 81:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Activations","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","Activations","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int!=0?93:90;continue;}
case 90:{f.Pc=57;continue;}
case 93:{f.Push(f.Locals[9]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/staticability/StaticAbilityAdditionalActivations","isValid","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z","invokestatic",101);}
case 101:{f.Pc=f.Pop().Int!=0?107:104;continue;}
case 104:{f.Pc=57;continue;}
case 107:{f.Push(f.Locals[9]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("MinLimit")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?154:117;continue;}
case 117:{f.Push(f.Locals[9]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",122);}
case 122:{f.Push(f.Locals[9]);f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("MinLimit")));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",129);}
case 129:{f.Push(f.Locals[9]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",134);}
case 134:{f.Locals[10]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[10]);f.Pc=138;continue;}
case 138:{f.Push(JValue.I(-1));f.Pc=139;continue;}
case 139:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?145:142;continue;}
case 142:{f.Push(JValue.I(2147483647));f.Pc=144;continue;}
case 144:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 145:{f.Push(f.Locals[4]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[10]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",152);}
case 152:{f.Locals[4]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[9]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("Additional")));f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",161);}
case 161:{f.Pc=f.Pop().Int==0?186:164;continue;}
case 164:{f.Push(f.Locals[5]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[9]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",171);}
case 171:{f.Push(f.Locals[9]);f.Pc=173;continue;}
case 173:{f.Push(JValue.R(rt.String("Additional")));f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",178);}
case 178:{f.Push(f.Locals[9]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",183);}
case 183:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=184;continue;}
case 184:{f.Locals[5]=f.Pop();f.Pc=186;continue;}
case 186:{f.Pc=57;continue;}
case 189:{f.Pc=23;continue;}
case 192:{f.Push(f.Locals[4]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[5]);f.Pc=196;continue;}
case 196:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=197;continue;}
case 197:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9852(JRuntime rt,JFrame f)
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
case 13:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int!=0?24:22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int!=0?36:34;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

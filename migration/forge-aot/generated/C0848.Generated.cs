// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C848{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityContinuous","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9983,"forge/game/staticability/StaticAbilityContinuous","<init>","()V",2,1,1,new JHandler[]{},M9983));
c.Add(new JMethod(9984,"forge/game/staticability/StaticAbilityContinuous","applyContinuousAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;",9,4,3,new JHandler[]{},M9984));
c.Add(new JMethod(9985,"forge/game/staticability/StaticAbilityContinuous","applyContinuousAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/card/CardCollectionView;Lforge/game/staticability/StaticAbilityLayer;)Lforge/game/card/CardCollectionView;",9,55,11,new JHandler[]{},M9985));
c.Add(new JMethod(9986,"forge/game/staticability/StaticAbilityContinuous","getColorsFromParam","(Lforge/game/staticability/StaticAbility;Ljava/lang/String;)Lforge/card/ColorSet;",10,4,2,new JHandler[]{},M9986));
c.Add(new JMethod(9987,"forge/game/staticability/StaticAbilityContinuous","buildIgnoreEffectAbility","(Lforge/game/staticability/StaticAbility;Ljava/lang/String;Ljava/util/List;Lforge/game/card/CardCollectionView;)V",10,9,10,new JHandler[]{},M9987));
c.Add(new JMethod(9988,"forge/game/staticability/StaticAbilityContinuous","cardsGainedFrom","(Ljava/lang/String;Ljava/util/Map;Lforge/game/card/Card;Lforge/game/staticability/StaticAbility;Lforge/game/Game;)Lforge/game/card/CardCollection;",10,8,6,new JHandler[]{},M9988));
c.Add(new JMethod(9989,"forge/game/staticability/StaticAbilityContinuous","getAffectedPlayers","(Lforge/game/staticability/StaticAbility;)Ljava/util/List;",10,9,5,new JHandler[]{},M9989));
c.Add(new JMethod(9990,"forge/game/staticability/StaticAbilityContinuous","getAffectedCards","(Lforge/game/staticability/StaticAbility;Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;",9,12,5,new JHandler[]{},M9990));
c.Add(new JMethod(9991,"forge/game/staticability/StaticAbilityContinuous","lambda$applyContinuousAbility$8","(Ljava/util/Map;Ljava/lang/String;)Ljava/util/stream/Stream;",4106,2,2,new JHandler[]{},M9991));
c.Add(new JMethod(9992,"forge/game/staticability/StaticAbilityContinuous","lambda$applyContinuousAbility$7","(Lforge/game/card/Card;Ljava/lang/String;)Ljava/lang/String;",4106,3,3,new JHandler[]{},M9992));
c.Add(new JMethod(9993,"forge/game/staticability/StaticAbilityContinuous","lambda$applyContinuousAbility$6","(Lforge/game/card/Card;Ljava/util/List;Ljava/lang/String;)Z",4106,5,4,new JHandler[]{},M9993));
c.Add(new JMethod(9994,"forge/game/staticability/StaticAbilityContinuous","lambda$applyContinuousAbility$5","(Lforge/game/card/Card;Ljava/lang/String;)Z",4106,2,2,new JHandler[]{},M9994));
c.Add(new JMethod(9995,"forge/game/staticability/StaticAbilityContinuous","lambda$applyContinuousAbility$4","(Lforge/game/card/Card;Ljava/lang/String;)Ljava/lang/String;",4106,2,3,new JHandler[]{},M9995));
c.Add(new JMethod(9996,"forge/game/staticability/StaticAbilityContinuous","lambda$applyContinuousAbility$3","(Lforge/game/card/Card;Ljava/util/List;Ljava/lang/String;)Z",4106,3,2,new JHandler[]{},M9996));
c.Add(new JMethod(9997,"forge/game/staticability/StaticAbilityContinuous","lambda$applyContinuousAbility$2","(Lforge/game/CardTraitBase;)Z",4106,1,1,new JHandler[]{},M9997));
c.Add(new JMethod(9998,"forge/game/staticability/StaticAbilityContinuous","lambda$applyContinuousAbility$1","(Lforge/game/card/Card;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Lforge/game/staticability/StaticAbility;Ljava/lang/String;)Ljava/lang/String;",4106,7,5,new JHandler[]{},M9998));
c.Add(new JMethod(9999,"forge/game/staticability/StaticAbilityContinuous","lambda$applyContinuousAbility$0","(Lforge/game/card/Card;Ljava/util/List;Lforge/game/player/Player;Ljava/util/Map;Lforge/game/Game;Lforge/game/staticability/StaticAbility;Ljava/lang/String;)Z",4106,13,5,new JHandler[]{},M9999));
}

internal static JStep M9983(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9984(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous","getAffectedCards","(Lforge/game/staticability/StaticAbility;Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;","invokestatic",5);}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous","applyContinuousAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/card/CardCollectionView;Lforge/game/staticability/StaticAbilityLayer;)Lforge/game/card/CardCollectionView;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9985(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbility","getMapParams","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous","getAffectedPlayers","(Lforge/game/staticability/StaticAbility;)Ljava/util/List;","invokestatic",22);}
case 22:{f.Locals[6]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("Affected")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?54:33;continue;}
case 33:{f.Push(f.Locals[6]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?54:43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",49);}
case 49:{f.Pc=f.Pop().Int==0?54:52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return JStep.Return(f.Pop());}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",59);}
case 59:{f.Locals[7]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[7]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/Game","getStaticEffects","()Lforge/game/StaticEffects;","invokevirtual",66);}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/StaticEffects","getStaticEffect","(Lforge/game/staticability/StaticAbility;)Lforge/game/StaticEffect;","invokevirtual",70);}
case 70:{f.Locals[8]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[8]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/StaticEffect","setAffectedCards","(Lforge/game/card/CardCollectionView;)V","invokevirtual",78);}
case 78:{f.Push(f.Locals[8]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/StaticEffect","setAffectedPlayers","(Ljava/util/List;)V","invokevirtual",85);}
case 85:{f.Push(f.Locals[8]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/StaticEffect","setParams","(Ljava/util/Map;)V","invokevirtual",91);}
case 91:{f.Push(f.Locals[8]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/staticability/StaticAbility","getTimestamp","()J","invokevirtual",97);}
case 97:{return rt.Call(f,"forge/game/StaticEffect","setTimestamp","(J)V","invokevirtual",100);}
case 100:{f.Push(JValue.R(rt.String("")));f.Pc=102;continue;}
case 102:{f.Locals[9]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(JValue.I(0));f.Pc=105;continue;}
case 105:{f.Locals[10]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("")));f.Pc=109;continue;}
case 109:{f.Locals[11]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{f.Locals[12]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("")));f.Pc=116;continue;}
case 116:{f.Locals[13]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(JValue.R(null));f.Pc=119;continue;}
case 119:{f.Locals[14]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("")));f.Pc=123;continue;}
case 123:{f.Locals[15]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(JValue.R(null));f.Pc=126;continue;}
case 126:{f.Locals[16]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(JValue.R(null));f.Pc=129;continue;}
case 129:{f.Locals[17]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(JValue.R(null));f.Pc=132;continue;}
case 132:{f.Locals[18]=f.Pop();f.Pc=134;continue;}
case 134:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",137);}
case 137:{f.Locals[19]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(JValue.R(null));f.Pc=140;continue;}
case 140:{f.Locals[20]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(JValue.R(null));f.Pc=143;continue;}
case 143:{f.Locals[21]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(JValue.R(null));f.Pc=146;continue;}
case 146:{f.Locals[22]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(JValue.R(null));f.Pc=149;continue;}
case 149:{f.Locals[23]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(JValue.R(null));f.Pc=152;continue;}
case 152:{f.Locals[24]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(JValue.R(null));f.Pc=155;continue;}
case 155:{f.Locals[25]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(JValue.R(null));f.Pc=158;continue;}
case 158:{f.Locals[26]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(JValue.R(null));f.Pc=161;continue;}
case 161:{f.Locals[27]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(JValue.R(null));f.Pc=164;continue;}
case 164:{f.Locals[28]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(JValue.R(null));f.Pc=167;continue;}
case 167:{f.Locals[29]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(JValue.I(0));f.Pc=170;continue;}
case 170:{f.Locals[30]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.ClassObject("forge/card/RemoveType")));f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",177);}
case 177:{f.Locals[31]=f.Pop();f.Pc=179;continue;}
case 179:{f.Push(JValue.I(0));f.Pc=180;continue;}
case 180:{f.Locals[32]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(JValue.R(null));f.Pc=183;continue;}
case 183:{f.Locals[33]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(JValue.R(null));f.Pc=186;continue;}
case 186:{f.Locals[34]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(JValue.I(0));f.Pc=189;continue;}
case 189:{f.Locals[35]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(JValue.I(0));f.Pc=192;continue;}
case 192:{f.Locals[36]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(JValue.I(0));f.Pc=195;continue;}
case 195:{f.Locals[37]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(JValue.R(null));f.Pc=198;continue;}
case 198:{f.Locals[38]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(JValue.I(1));f.Pc=201;continue;}
case 201:{f.Locals[39]=f.Pop();f.Pc=203;continue;}
case 203:{f.Push(JValue.R(null));f.Pc=204;continue;}
case 204:{f.Locals[40]=f.Pop();f.Pc=206;continue;}
case 206:{f.Push(f.Locals[2]);f.Pc=207;continue;}
case 207:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=210;continue;}
case 210:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?220:213;continue;}
case 213:{f.Push(f.Locals[2]);f.Pc=214;continue;}
case 214:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=217;continue;}
case 217:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?294:220;continue;}
case 220:{f.Push(f.Locals[3]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String("SetPower")));f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",228);}
case 228:{f.Pc=f.Pop().Int==0?257:231;continue;}
case 231:{f.Push(f.Locals[3]);f.Pc=232;continue;}
case 232:{f.Push(JValue.R(rt.String("SetPower")));f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",239);}
case 239:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=242;continue;}
case 242:{f.Locals[13]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(f.Locals[4]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[13]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[0]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",252);}
case 252:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",255);}
case 255:{f.Locals[14]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[3]);f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String("SetToughness")));f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",265);}
case 265:{f.Pc=f.Pop().Int==0?294:268;continue;}
case 268:{f.Push(f.Locals[3]);f.Pc=269;continue;}
case 269:{f.Push(JValue.R(rt.String("SetToughness")));f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",276);}
case 276:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=279;continue;}
case 279:{f.Locals[15]=f.Pop();f.Pc=281;continue;}
case 281:{f.Push(f.Locals[4]);f.Pc=283;continue;}
case 283:{f.Push(f.Locals[15]);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[0]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",289);}
case 289:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",292);}
case 292:{f.Locals[16]=f.Pop();f.Pc=294;continue;}
case 294:{f.Push(f.Locals[2]);f.Pc=295;continue;}
case 295:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=298;continue;}
case 298:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?371:301;continue;}
case 301:{f.Push(f.Locals[3]);f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.String("AddPower")));f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",309);}
case 309:{f.Pc=f.Pop().Int==0?336:312;continue;}
case 312:{f.Push(f.Locals[3]);f.Pc=313;continue;}
case 313:{f.Push(JValue.R(rt.String("AddPower")));f.Pc=315;continue;}
case 315:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",320);}
case 320:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=323;continue;}
case 323:{f.Locals[9]=f.Pop();f.Pc=325;continue;}
case 325:{f.Push(f.Locals[4]);f.Pc=327;continue;}
case 327:{f.Push(f.Locals[9]);f.Pc=329;continue;}
case 329:{f.Push(f.Locals[0]);f.Pc=330;continue;}
case 330:{f.Push(JValue.I(1));f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",334);}
case 334:{f.Locals[10]=f.Pop();f.Pc=336;continue;}
case 336:{f.Push(f.Locals[3]);f.Pc=337;continue;}
case 337:{f.Push(JValue.R(rt.String("AddToughness")));f.Pc=339;continue;}
case 339:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",344);}
case 344:{f.Pc=f.Pop().Int==0?371:347;continue;}
case 347:{f.Push(f.Locals[3]);f.Pc=348;continue;}
case 348:{f.Push(JValue.R(rt.String("AddToughness")));f.Pc=350;continue;}
case 350:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",355);}
case 355:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=358;continue;}
case 358:{f.Locals[11]=f.Pop();f.Pc=360;continue;}
case 360:{f.Push(f.Locals[4]);f.Pc=362;continue;}
case 362:{f.Push(f.Locals[11]);f.Pc=364;continue;}
case 364:{f.Push(f.Locals[0]);f.Pc=365;continue;}
case 365:{f.Push(JValue.I(1));f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",369);}
case 369:{f.Locals[12]=f.Pop();f.Pc=371;continue;}
case 371:{f.Push(f.Locals[2]);f.Pc=372;continue;}
case 372:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=375;continue;}
case 375:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?983:378;continue;}
case 378:{f.Push(f.Locals[3]);f.Pc=379;continue;}
case 379:{f.Push(JValue.R(rt.String("AddKeyword")));f.Pc=381;continue;}
case 381:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",386);}
case 386:{f.Pc=f.Pop().Int==0?644:389;continue;}
case 389:{f.Push(f.Locals[3]);f.Pc=390;continue;}
case 390:{f.Push(JValue.R(rt.String("AddKeyword")));f.Pc=392;continue;}
case 392:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",397);}
case 397:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=400;continue;}
case 400:{f.Push(JValue.R(rt.String(" & ")));f.Pc=402;continue;}
case 402:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",405);}
case 405:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",408);}
case 408:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",411);}
case 411:{f.Locals[17]=f.Pop();f.Pc=413;continue;}
case 413:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",416);}
case 416:{f.Locals[41]=f.Pop();f.Pc=418;continue;}
case 418:{f.Push(f.Locals[4]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",423);}
case 423:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",426);}
case 426:{f.Locals[42]=f.Pop();f.Pc=428;continue;}
case 428:{f.Push(f.Locals[4]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",433);}
case 433:{return rt.Call(f,"forge/game/player/Player","getId","()I","invokevirtual",436);}
case 436:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",439);}
case 439:{f.Locals[43]=f.Pop();f.Pc=441;continue;}
case 441:{f.Push(f.Locals[17]);f.Pc=443;continue;}
case 443:{f.Push(f.Locals[4]);f.Pc=445;continue;}
case 445:{f.Push(f.Locals[41]);f.Pc=447;continue;}
case 447:{f.Push(f.Locals[5]);f.Pc=449;continue;}
case 449:{f.Push(f.Locals[3]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[7]);f.Pc=452;continue;}
case 452:{f.Push(f.Locals[0]);f.Pc=453;continue;}
case 453:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityContinuous:9985:453:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Ljava/util/List;Lforge/game/player/Player;Ljava/util/Map;Lforge/game/Game;Lforge/game/staticability/StaticAbility;)Ljava/util/function/Predicate;",458);}
case 458:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",463);}
case 463:{f.StackOp("pop");f.Pc=464;continue;}
case 464:{f.Push(f.Locals[17]);f.Pc=466;continue;}
case 466:{f.Push(f.Locals[41]);f.Pc=468;continue;}
case 468:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",473);}
case 473:{f.StackOp("pop");f.Pc=474;continue;}
case 474:{f.Push(f.Locals[17]);f.Pc=476;continue;}
case 476:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",481);}
case 481:{f.Push(f.Locals[4]);f.Pc=483;continue;}
case 483:{f.Push(f.Locals[42]);f.Pc=485;continue;}
case 485:{f.Push(f.Locals[43]);f.Pc=487;continue;}
case 487:{f.Push(f.Locals[3]);f.Pc=488;continue;}
case 488:{f.Push(f.Locals[0]);f.Pc=489;continue;}
case 489:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityContinuous:9985:489:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Lforge/game/staticability/StaticAbility;)Ljava/util/function/Function;",494);}
case 494:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",499);}
case 499:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",502);}
case 502:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",507);}
case 507:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=510;continue;}
case 510:{f.Locals[17]=f.Pop();f.Pc=512;continue;}
case 512:{f.Push(f.Locals[3]);f.Pc=513;continue;}
case 513:{f.Push(JValue.R(rt.String("SharedKeywordsZone")));f.Pc=515;continue;}
case 515:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",520);}
case 520:{f.Pc=f.Pop().Int==0?594:523;continue;}
case 523:{f.Push(f.Locals[3]);f.Pc=524;continue;}
case 524:{f.Push(JValue.R(rt.String("SharedKeywordsZone")));f.Pc=526;continue;}
case 526:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",531);}
case 531:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=534;continue;}
case 534:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",537);}
case 537:{f.Locals[44]=f.Pop();f.Pc=539;continue;}
case 539:{f.Push(f.Locals[3]);f.Pc=540;continue;}
case 540:{f.Push(JValue.R(rt.String("SharedRestrictions")));f.Pc=542;continue;}
case 542:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",547);}
case 547:{f.Pc=f.Pop().Int==0?569:550;continue;}
case 550:{f.Push(f.Locals[3]);f.Pc=551;continue;}
case 551:{f.Push(JValue.R(rt.String("SharedRestrictions")));f.Pc=553;continue;}
case 553:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",558);}
case 558:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=561;continue;}
case 561:{f.Push(JValue.R(rt.String(",")));f.Pc=563;continue;}
case 563:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",566);}
case 566:{f.Pc=578;continue;}
case 569:{f.Push(JValue.I(1));f.Pc=570;continue;}
case 570:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=573;continue;}
case 573:{f.StackOp("dup");f.Pc=574;continue;}
case 574:{f.Push(JValue.I(0));f.Pc=575;continue;}
case 575:{f.Push(JValue.R(rt.String("Card")));f.Pc=577;continue;}
case 577:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=578;continue;}
case 578:{f.Locals[45]=f.Pop();f.Pc=580;continue;}
case 580:{f.Push(f.Locals[17]);f.Pc=582;continue;}
case 582:{f.Push(f.Locals[45]);f.Pc=584;continue;}
case 584:{f.Push(f.Locals[44]);f.Pc=586;continue;}
case 586:{f.Push(f.Locals[4]);f.Pc=588;continue;}
case 588:{f.Push(f.Locals[0]);f.Pc=589;continue;}
case 589:{return rt.Call(f,"forge/game/card/CardFactoryUtil","sharedKeywords","(Ljava/lang/Iterable;[Ljava/lang/String;Ljava/lang/Iterable;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",592);}
case 592:{f.Locals[17]=f.Pop();f.Pc=594;continue;}
case 594:{f.Push(f.Locals[3]);f.Pc=595;continue;}
case 595:{f.Push(JValue.R(rt.String("FromDraftNotes")));f.Pc=597;continue;}
case 597:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",602);}
case 602:{f.Pc=f.Pop().Int==0?641:605;continue;}
case 605:{f.Push(f.Locals[4]);f.Pc=607;continue;}
case 607:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",610);}
case 610:{return rt.Call(f,"forge/game/player/Player","getDraftNotes","()Ljava/util/Map;","invokevirtual",613);}
case 613:{f.Push(f.Locals[3]);f.Pc=614;continue;}
case 614:{f.Push(JValue.R(rt.String("FromDraftNotes")));f.Pc=616;continue;}
case 616:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",621);}
case 621:{f.Push(JValue.R(rt.String("")));f.Pc=623;continue;}
case 623:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",628);}
case 628:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=631;continue;}
case 631:{f.Push(JValue.R(rt.String(",")));f.Pc=633;continue;}
case 633:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",636);}
case 636:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",639);}
case 639:{f.Locals[17]=f.Pop();f.Pc=641;continue;}
case 641:{f.Pc=725;continue;}
case 644:{f.Push(f.Locals[3]);f.Pc=645;continue;}
case 645:{f.Push(JValue.R(rt.String("ShareRememberedKeywords")));f.Pc=647;continue;}
case 647:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",652);}
case 652:{f.Pc=f.Pop().Int==0?725:655;continue;}
case 655:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",658);}
case 658:{f.Locals[41]=f.Pop();f.Pc=660;continue;}
case 660:{f.Push(f.Locals[4]);f.Pc=662;continue;}
case 662:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",665);}
case 665:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",670);}
case 670:{f.Locals[42]=f.Pop();f.Pc=672;continue;}
case 672:{f.Push(f.Locals[42]);f.Pc=674;continue;}
case 674:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",679);}
case 679:{f.Pc=f.Pop().Int==0?711:682;continue;}
case 682:{f.Push(f.Locals[42]);f.Pc=684;continue;}
case 684:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",689);}
case 689:{f.Locals[43]=f.Pop();f.Pc=691;continue;}
case 691:{f.Push(f.Locals[43]);f.Pc=693;continue;}
case 693:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=696;continue;}
case 696:{f.Locals[44]=f.Pop();f.Pc=698;continue;}
case 698:{f.Push(f.Locals[41]);f.Pc=700;continue;}
case 700:{f.Push(f.Locals[44]);f.Pc=702;continue;}
case 702:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",707);}
case 707:{f.StackOp("pop");f.Pc=708;continue;}
case 708:{f.Pc=672;continue;}
case 711:{f.Push(f.Locals[41]);f.Pc=713;continue;}
case 713:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",718);}
case 718:{f.Pc=f.Pop().Int!=0?725:721;continue;}
case 721:{f.Push(f.Locals[41]);f.Pc=723;continue;}
case 723:{f.Locals[17]=f.Pop();f.Pc=725;continue;}
case 725:{f.Push(f.Locals[3]);f.Pc=726;continue;}
case 726:{f.Push(JValue.R(rt.String("GainsStickerAbilitiesOf")));f.Pc=729;continue;}
case 729:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",734);}
case 734:{f.Pc=f.Pop().Int!=0?749:737;continue;}
case 737:{f.Push(f.Locals[3]);f.Pc=738;continue;}
case 738:{f.Push(JValue.R(rt.String("GainsStickerAbilitiesOfDefined")));f.Pc=741;continue;}
case 741:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",746);}
case 746:{f.Pc=f.Pop().Int==0?920:749;continue;}
case 749:{f.Push(f.Locals[3]);f.Pc=750;continue;}
case 750:{f.Push(JValue.R(rt.String("GainsStickerAbilitiesOfDefined")));f.Pc=753;continue;}
case 753:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",758);}
case 758:{f.Pc=f.Pop().Int==0?767:761;continue;}
case 761:{f.Push(JValue.R(rt.String("GainsStickerAbilitiesOfDefined")));f.Pc=764;continue;}
case 764:{f.Pc=770;continue;}
case 767:{f.Push(JValue.R(rt.String("GainsStickerAbilitiesOf")));f.Pc=770;continue;}
case 770:{f.Push(f.Locals[3]);f.Pc=771;continue;}
case 771:{f.Push(f.Locals[4]);f.Pc=773;continue;}
case 773:{f.Push(f.Locals[0]);f.Pc=774;continue;}
case 774:{f.Push(f.Locals[7]);f.Pc=776;continue;}
case 776:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous","cardsGainedFrom","(Ljava/lang/String;Ljava/util/Map;Lforge/game/card/Card;Lforge/game/staticability/StaticAbility;Lforge/game/Game;)Lforge/game/card/CardCollection;","invokestatic",779);}
case 779:{f.Locals[41]=f.Pop();f.Pc=781;continue;}
case 781:{f.Push(f.Locals[41]);f.Pc=783;continue;}
case 783:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",786);}
case 786:{f.Locals[42]=f.Pop();f.Pc=788;continue;}
case 788:{f.Push(f.Locals[42]);f.Pc=790;continue;}
case 790:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",795);}
case 795:{f.Pc=f.Pop().Int==0?920:798;continue;}
case 798:{f.Push(f.Locals[42]);f.Pc=800;continue;}
case 800:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",805);}
case 805:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=808;continue;}
case 808:{f.Locals[43]=f.Pop();f.Pc=810;continue;}
case 810:{f.Push(f.Locals[43]);f.Pc=812;continue;}
case 812:{return rt.Call(f,"forge/game/card/Card","getStickers","()Ljava/util/List;","invokevirtual",815);}
case 815:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",820);}
case 820:{f.Locals[44]=f.Pop();f.Pc=822;continue;}
case 822:{f.Push(f.Locals[44]);f.Pc=824;continue;}
case 824:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",829);}
case 829:{f.Pc=f.Pop().Int==0?917:832;continue;}
case 832:{f.Push(f.Locals[44]);f.Pc=834;continue;}
case 834:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",839);}
case 839:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/sticker/AppliedSticker"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=842;continue;}
case 842:{f.Locals[45]=f.Pop();f.Pc=844;continue;}
case 844:{f.Push(f.Locals[45]);f.Pc=846;continue;}
case 846:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","getKind","()Lforge/game/card/sticker/StickerKind;","invokevirtual",849);}
case 849:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerKind","ABILITY","Lforge/game/card/sticker/StickerKind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/sticker/StickerKind","ABILITY","Lforge/game/card/sticker/StickerKind;"));f.Pc=852;continue;}
case 852:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?858:855;continue;}
case 855:{f.Pc=822;continue;}
case 858:{f.Push(f.Locals[18]);f.Pc=860;continue;}
case 860:{f.Pc=f.Pop().Reference!=null?868:863;continue;}
case 863:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",866);}
case 866:{f.Locals[18]=f.Pop();f.Pc=868;continue;}
case 868:{f.Push(f.Locals[18]);f.Pc=870;continue;}
case 870:{f.Push(f.Locals[45]);f.Pc=872;continue;}
case 872:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",877);}
case 877:{f.StackOp("pop");f.Pc=878;continue;}
case 878:{f.Push(f.Locals[45]);f.Pc=880;continue;}
case 880:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","getGrantedKeywords","()Ljava/util/List;","invokevirtual",883);}
case 883:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",888);}
case 888:{f.Pc=f.Pop().Int!=0?914:891;continue;}
case 891:{f.Push(f.Locals[17]);f.Pc=893;continue;}
case 893:{f.Pc=f.Pop().Reference!=null?901:896;continue;}
case 896:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",899);}
case 899:{f.Locals[17]=f.Pop();f.Pc=901;continue;}
case 901:{f.Push(f.Locals[17]);f.Pc=903;continue;}
case 903:{f.Push(f.Locals[45]);f.Pc=905;continue;}
case 905:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","getGrantedKeywords","()Ljava/util/List;","invokevirtual",908);}
case 908:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",913);}
case 913:{f.StackOp("pop");f.Pc=914;continue;}
case 914:{f.Pc=822;continue;}
case 917:{f.Pc=788;continue;}
case 920:{f.Push(f.Locals[3]);f.Pc=921;continue;}
case 921:{f.Push(JValue.R(rt.String("CantHaveKeyword")));f.Pc=924;continue;}
case 924:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",929);}
case 929:{f.Pc=f.Pop().Int==0?949:932;continue;}
case 932:{f.Push(f.Locals[3]);f.Pc=933;continue;}
case 933:{f.Push(JValue.R(rt.String("CantHaveKeyword")));f.Pc=936;continue;}
case 936:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",941);}
case 941:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=944;continue;}
case 944:{return rt.Call(f,"forge/game/keyword/Keyword","setValueOf","(Ljava/lang/String;)Ljava/util/Set;","invokestatic",947);}
case 947:{f.Locals[33]=f.Pop();f.Pc=949;continue;}
case 949:{f.Push(f.Locals[3]);f.Pc=950;continue;}
case 950:{f.Push(JValue.R(rt.String("RemoveKeyword")));f.Pc=953;continue;}
case 953:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",958);}
case 958:{f.Pc=f.Pop().Int==0?983:961;continue;}
case 961:{f.Push(f.Locals[3]);f.Pc=962;continue;}
case 962:{f.Push(JValue.R(rt.String("RemoveKeyword")));f.Pc=965;continue;}
case 965:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",970);}
case 970:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=973;continue;}
case 973:{f.Push(JValue.R(rt.String(" & ")));f.Pc=975;continue;}
case 975:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",978);}
case 978:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",981);}
case 981:{f.Locals[20]=f.Pop();f.Pc=983;continue;}
case 983:{f.Push(f.Locals[2]);f.Pc=984;continue;}
case 984:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=987;continue;}
case 987:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1030:990;continue;}
case 990:{f.Push(f.Locals[3]);f.Pc=991;continue;}
case 991:{f.Push(JValue.R(rt.String("AddHiddenKeyword")));f.Pc=994;continue;}
case 994:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",999);}
case 999:{f.Pc=f.Pop().Int==0?1030:1002;continue;}
case 1002:{f.Push(f.Locals[19]);f.Pc=1004;continue;}
case 1004:{f.Push(f.Locals[3]);f.Pc=1005;continue;}
case 1005:{f.Push(JValue.R(rt.String("AddHiddenKeyword")));f.Pc=1008;continue;}
case 1008:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1013);}
case 1013:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1016;continue;}
case 1016:{f.Push(JValue.R(rt.String(" & ")));f.Pc=1018;continue;}
case 1018:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1021);}
case 1021:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",1024);}
case 1024:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",1029);}
case 1029:{f.StackOp("pop");f.Pc=1030;continue;}
case 1030:{f.Push(f.Locals[2]);f.Pc=1031;continue;}
case 1031:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1034;continue;}
case 1034:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1376:1037;continue;}
case 1037:{f.Push(f.Locals[3]);f.Pc=1038;continue;}
case 1038:{f.Push(JValue.R(rt.String("RemoveAllAbilities")));f.Pc=1041;continue;}
case 1041:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1046);}
case 1046:{f.Pc=f.Pop().Int==0?1059:1049;continue;}
case 1049:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityContinuous:9985:1049:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",1054);}
case 1054:{f.Locals[29]=f.Pop();f.Pc=1056;continue;}
case 1056:{f.Pc=1081;continue;}
case 1059:{f.Push(f.Locals[3]);f.Pc=1060;continue;}
case 1060:{f.Push(JValue.R(rt.String("RemoveNonManaAbilities")));f.Pc=1063;continue;}
case 1063:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1068);}
case 1068:{f.Pc=f.Pop().Int==0?1081:1071;continue;}
case 1071:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityContinuous:9985:1071:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",1076);}
case 1076:{return rt.Call(f,"java/util/function/Predicate","not","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",1079);}
case 1079:{f.Locals[29]=f.Pop();f.Pc=1081;continue;}
case 1081:{f.Push(f.Locals[3]);f.Pc=1082;continue;}
case 1082:{f.Push(JValue.R(rt.String("AddAbility")));f.Pc=1085;continue;}
case 1085:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1090);}
case 1090:{f.Pc=f.Pop().Int==0?1147:1093;continue;}
case 1093:{f.Push(f.Locals[3]);f.Pc=1094;continue;}
case 1094:{f.Push(JValue.R(rt.String("AddAbility")));f.Pc=1097;continue;}
case 1097:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1102);}
case 1102:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1105;continue;}
case 1105:{f.Push(JValue.R(rt.String(" & ")));f.Pc=1107;continue;}
case 1107:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1110);}
case 1110:{f.Locals[41]=f.Pop();f.Pc=1112;continue;}
case 1112:{f.Push(JValue.I(0));f.Pc=1113;continue;}
case 1113:{f.Locals[42]=f.Pop();f.Pc=1115;continue;}
case 1115:{f.Push(f.Locals[42]);f.Pc=1117;continue;}
case 1117:{f.Push(f.Locals[41]);f.Pc=1119;continue;}
case 1119:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1120;continue;}
case 1120:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1143:1123;continue;}
case 1123:{f.Push(f.Locals[41]);f.Pc=1125;continue;}
case 1125:{f.Push(f.Locals[42]);f.Pc=1127;continue;}
case 1127:{f.Push(f.Locals[0]);f.Pc=1128;continue;}
case 1128:{f.Push(f.Locals[41]);f.Pc=1130;continue;}
case 1130:{f.Push(f.Locals[42]);f.Pc=1132;continue;}
case 1132:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1133;continue;}
case 1133:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1136);}
case 1136:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1137;continue;}
case 1137:{f.Locals[42]=JValue.I(unchecked(f.Locals[42].Int+(1)));f.Pc=1140;continue;}
case 1140:{f.Pc=1115;continue;}
case 1143:{f.Push(f.Locals[41]);f.Pc=1145;continue;}
case 1145:{f.Locals[21]=f.Pop();f.Pc=1147;continue;}
case 1147:{f.Push(f.Locals[3]);f.Pc=1148;continue;}
case 1148:{f.Push(JValue.R(rt.String("AddReplacementEffect")));f.Pc=1151;continue;}
case 1151:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1156);}
case 1156:{f.Pc=f.Pop().Int==0?1213:1159;continue;}
case 1159:{f.Push(f.Locals[3]);f.Pc=1160;continue;}
case 1160:{f.Push(JValue.R(rt.String("AddReplacementEffect")));f.Pc=1163;continue;}
case 1163:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1168);}
case 1168:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1171;continue;}
case 1171:{f.Push(JValue.R(rt.String(" & ")));f.Pc=1173;continue;}
case 1173:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1176);}
case 1176:{f.Locals[41]=f.Pop();f.Pc=1178;continue;}
case 1178:{f.Push(JValue.I(0));f.Pc=1179;continue;}
case 1179:{f.Locals[42]=f.Pop();f.Pc=1181;continue;}
case 1181:{f.Push(f.Locals[42]);f.Pc=1183;continue;}
case 1183:{f.Push(f.Locals[41]);f.Pc=1185;continue;}
case 1185:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1186;continue;}
case 1186:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1209:1189;continue;}
case 1189:{f.Push(f.Locals[41]);f.Pc=1191;continue;}
case 1191:{f.Push(f.Locals[42]);f.Pc=1193;continue;}
case 1193:{f.Push(f.Locals[0]);f.Pc=1194;continue;}
case 1194:{f.Push(f.Locals[41]);f.Pc=1196;continue;}
case 1196:{f.Push(f.Locals[42]);f.Pc=1198;continue;}
case 1198:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1199;continue;}
case 1199:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1202);}
case 1202:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1203;continue;}
case 1203:{f.Locals[42]=JValue.I(unchecked(f.Locals[42].Int+(1)));f.Pc=1206;continue;}
case 1206:{f.Pc=1181;continue;}
case 1209:{f.Push(f.Locals[41]);f.Pc=1211;continue;}
case 1211:{f.Locals[22]=f.Pop();f.Pc=1213;continue;}
case 1213:{f.Push(f.Locals[3]);f.Pc=1214;continue;}
case 1214:{f.Push(JValue.R(rt.String("AddTrigger")));f.Pc=1217;continue;}
case 1217:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1222);}
case 1222:{f.Pc=f.Pop().Int==0?1279:1225;continue;}
case 1225:{f.Push(f.Locals[3]);f.Pc=1226;continue;}
case 1226:{f.Push(JValue.R(rt.String("AddTrigger")));f.Pc=1229;continue;}
case 1229:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1234);}
case 1234:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1237;continue;}
case 1237:{f.Push(JValue.R(rt.String(" & ")));f.Pc=1239;continue;}
case 1239:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1242);}
case 1242:{f.Locals[41]=f.Pop();f.Pc=1244;continue;}
case 1244:{f.Push(JValue.I(0));f.Pc=1245;continue;}
case 1245:{f.Locals[42]=f.Pop();f.Pc=1247;continue;}
case 1247:{f.Push(f.Locals[42]);f.Pc=1249;continue;}
case 1249:{f.Push(f.Locals[41]);f.Pc=1251;continue;}
case 1251:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1252;continue;}
case 1252:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1275:1255;continue;}
case 1255:{f.Push(f.Locals[41]);f.Pc=1257;continue;}
case 1257:{f.Push(f.Locals[42]);f.Pc=1259;continue;}
case 1259:{f.Push(f.Locals[0]);f.Pc=1260;continue;}
case 1260:{f.Push(f.Locals[41]);f.Pc=1262;continue;}
case 1262:{f.Push(f.Locals[42]);f.Pc=1264;continue;}
case 1264:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1265;continue;}
case 1265:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1268);}
case 1268:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1269;continue;}
case 1269:{f.Locals[42]=JValue.I(unchecked(f.Locals[42].Int+(1)));f.Pc=1272;continue;}
case 1272:{f.Pc=1247;continue;}
case 1275:{f.Push(f.Locals[41]);f.Pc=1277;continue;}
case 1277:{f.Locals[27]=f.Pop();f.Pc=1279;continue;}
case 1279:{f.Push(f.Locals[3]);f.Pc=1280;continue;}
case 1280:{f.Push(JValue.R(rt.String("AddStaticAbility")));f.Pc=1283;continue;}
case 1283:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1288);}
case 1288:{f.Pc=f.Pop().Int==0?1345:1291;continue;}
case 1291:{f.Push(f.Locals[3]);f.Pc=1292;continue;}
case 1292:{f.Push(JValue.R(rt.String("AddStaticAbility")));f.Pc=1295;continue;}
case 1295:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1300);}
case 1300:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1303;continue;}
case 1303:{f.Push(JValue.R(rt.String(" & ")));f.Pc=1305;continue;}
case 1305:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1308);}
case 1308:{f.Locals[41]=f.Pop();f.Pc=1310;continue;}
case 1310:{f.Push(JValue.I(0));f.Pc=1311;continue;}
case 1311:{f.Locals[42]=f.Pop();f.Pc=1313;continue;}
case 1313:{f.Push(f.Locals[42]);f.Pc=1315;continue;}
case 1315:{f.Push(f.Locals[41]);f.Pc=1317;continue;}
case 1317:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1318;continue;}
case 1318:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1341:1321;continue;}
case 1321:{f.Push(f.Locals[41]);f.Pc=1323;continue;}
case 1323:{f.Push(f.Locals[42]);f.Pc=1325;continue;}
case 1325:{f.Push(f.Locals[0]);f.Pc=1326;continue;}
case 1326:{f.Push(f.Locals[41]);f.Pc=1328;continue;}
case 1328:{f.Push(f.Locals[42]);f.Pc=1330;continue;}
case 1330:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1331;continue;}
case 1331:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1334);}
case 1334:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1335;continue;}
case 1335:{f.Locals[42]=JValue.I(unchecked(f.Locals[42].Int+(1)));f.Pc=1338;continue;}
case 1338:{f.Pc=1313;continue;}
case 1341:{f.Push(f.Locals[41]);f.Pc=1343;continue;}
case 1343:{f.Locals[28]=f.Pop();f.Pc=1345;continue;}
case 1345:{f.Push(f.Locals[3]);f.Pc=1346;continue;}
case 1346:{f.Push(JValue.R(rt.String("AddSVar")));f.Pc=1349;continue;}
case 1349:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1354);}
case 1354:{f.Pc=f.Pop().Int==0?1376:1357;continue;}
case 1357:{f.Push(f.Locals[3]);f.Pc=1358;continue;}
case 1358:{f.Push(JValue.R(rt.String("AddSVar")));f.Pc=1361;continue;}
case 1361:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1366);}
case 1366:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1369;continue;}
case 1369:{f.Push(JValue.R(rt.String(" & ")));f.Pc=1371;continue;}
case 1371:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1374);}
case 1374:{f.Locals[23]=f.Pop();f.Pc=1376;continue;}
case 1376:{f.Push(f.Locals[2]);f.Pc=1377;continue;}
case 1377:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1380;continue;}
case 1380:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1727:1383;continue;}
case 1383:{f.Push(f.Locals[3]);f.Pc=1384;continue;}
case 1384:{f.Push(JValue.R(rt.String("AddType")));f.Pc=1387;continue;}
case 1387:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1392);}
case 1392:{f.Pc=f.Pop().Int==0?1484:1395;continue;}
case 1395:{f.Push(f.Locals[3]);f.Pc=1396;continue;}
case 1396:{f.Push(JValue.R(rt.String("AddType")));f.Pc=1399;continue;}
case 1399:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1404);}
case 1404:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1407;continue;}
case 1407:{f.Push(JValue.R(rt.String(" & ")));f.Pc=1409;continue;}
case 1409:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1412);}
case 1412:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",1415);}
case 1415:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",1418);}
case 1418:{f.Locals[24]=f.Pop();f.Pc=1420;continue;}
case 1420:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",1423);}
case 1423:{f.Locals[41]=f.Pop();f.Pc=1425;continue;}
case 1425:{f.Push(f.Locals[24]);f.Pc=1427;continue;}
case 1427:{f.Push(f.Locals[4]);f.Pc=1429;continue;}
case 1429:{f.Push(f.Locals[41]);f.Pc=1431;continue;}
case 1431:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityContinuous:9985:1431:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Ljava/util/List;)Ljava/util/function/Predicate;",1436);}
case 1436:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",1441);}
case 1441:{f.StackOp("pop");f.Pc=1442;continue;}
case 1442:{f.Push(f.Locals[24]);f.Pc=1444;continue;}
case 1444:{f.Push(f.Locals[41]);f.Pc=1446;continue;}
case 1446:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",1451);}
case 1451:{f.StackOp("pop");f.Pc=1452;continue;}
case 1452:{f.Push(f.Locals[24]);f.Pc=1454;continue;}
case 1454:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",1459);}
case 1459:{f.Push(f.Locals[4]);f.Pc=1461;continue;}
case 1461:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityContinuous:9985:1461:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Function;",1466);}
case 1466:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",1471);}
case 1471:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",1474);}
case 1474:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",1479);}
case 1479:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1482;continue;}
case 1482:{f.Locals[24]=f.Pop();f.Pc=1484;continue;}
case 1484:{f.Push(f.Locals[3]);f.Pc=1485;continue;}
case 1485:{f.Push(JValue.R(rt.String("RemoveType")));f.Pc=1488;continue;}
case 1488:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1493);}
case 1493:{f.Pc=f.Pop().Int==0?1536:1496;continue;}
case 1496:{f.Push(f.Locals[3]);f.Pc=1497;continue;}
case 1497:{f.Push(JValue.R(rt.String("RemoveType")));f.Pc=1500;continue;}
case 1500:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1505);}
case 1505:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1508;continue;}
case 1508:{f.Push(JValue.R(rt.String(" & ")));f.Pc=1510;continue;}
case 1510:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1513);}
case 1513:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",1516);}
case 1516:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",1519);}
case 1519:{f.Locals[25]=f.Pop();f.Pc=1521;continue;}
case 1521:{f.Push(f.Locals[25]);f.Pc=1523;continue;}
case 1523:{f.Push(f.Locals[4]);f.Pc=1525;continue;}
case 1525:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityContinuous:9985:1525:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",1530);}
case 1530:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",1535);}
case 1535:{f.StackOp("pop");f.Pc=1536;continue;}
case 1536:{f.Push(f.Locals[3]);f.Pc=1537;continue;}
case 1537:{f.Push(JValue.R(rt.String("AddAllCreatureTypes")));f.Pc=1540;continue;}
case 1540:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1545);}
case 1545:{f.Pc=f.Pop().Int==0?1551:1548;continue;}
case 1548:{f.Push(JValue.I(1));f.Pc=1549;continue;}
case 1549:{f.Locals[30]=f.Pop();f.Pc=1551;continue;}
case 1551:{f.Push(f.Locals[24]);f.Pc=1553;continue;}
case 1553:{f.Pc=f.Pop().Reference==null?1566:1556;continue;}
case 1556:{f.Push(f.Locals[24]);f.Pc=1558;continue;}
case 1558:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1563);}
case 1563:{f.Pc=f.Pop().Int!=0?1727:1566;continue;}
case 1566:{f.Push(f.Locals[3]);f.Pc=1567;continue;}
case 1567:{f.Push(JValue.R(rt.String("RemoveSuperTypes")));f.Pc=1570;continue;}
case 1570:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1575);}
case 1575:{f.Pc=f.Pop().Int==0?1589:1578;continue;}
case 1578:{f.Push(f.Locals[31]);f.Pc=1580;continue;}
case 1580:{if(!rt.StaticReady(f,"forge/card/RemoveType","SuperTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","SuperTypes","Lforge/card/RemoveType;"));f.Pc=1583;continue;}
case 1583:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",1588);}
case 1588:{f.StackOp("pop");f.Pc=1589;continue;}
case 1589:{f.Push(f.Locals[3]);f.Pc=1590;continue;}
case 1590:{f.Push(JValue.R(rt.String("RemoveCardTypes")));f.Pc=1593;continue;}
case 1593:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1598);}
case 1598:{f.Pc=f.Pop().Int==0?1612:1601;continue;}
case 1601:{f.Push(f.Locals[31]);f.Pc=1603;continue;}
case 1603:{if(!rt.StaticReady(f,"forge/card/RemoveType","CardTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","CardTypes","Lforge/card/RemoveType;"));f.Pc=1606;continue;}
case 1606:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",1611);}
case 1611:{f.StackOp("pop");f.Pc=1612;continue;}
case 1612:{f.Push(f.Locals[3]);f.Pc=1613;continue;}
case 1613:{f.Push(JValue.R(rt.String("RemoveSubTypes")));f.Pc=1616;continue;}
case 1616:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1621);}
case 1621:{f.Pc=f.Pop().Int==0?1635:1624;continue;}
case 1624:{f.Push(f.Locals[31]);f.Pc=1626;continue;}
case 1626:{if(!rt.StaticReady(f,"forge/card/RemoveType","SubTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","SubTypes","Lforge/card/RemoveType;"));f.Pc=1629;continue;}
case 1629:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",1634);}
case 1634:{f.StackOp("pop");f.Pc=1635;continue;}
case 1635:{f.Push(f.Locals[3]);f.Pc=1636;continue;}
case 1636:{f.Push(JValue.R(rt.String("RemoveLandTypes")));f.Pc=1639;continue;}
case 1639:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1644);}
case 1644:{f.Pc=f.Pop().Int==0?1658:1647;continue;}
case 1647:{f.Push(f.Locals[31]);f.Pc=1649;continue;}
case 1649:{if(!rt.StaticReady(f,"forge/card/RemoveType","LandTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","LandTypes","Lforge/card/RemoveType;"));f.Pc=1652;continue;}
case 1652:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",1657);}
case 1657:{f.StackOp("pop");f.Pc=1658;continue;}
case 1658:{f.Push(f.Locals[3]);f.Pc=1659;continue;}
case 1659:{f.Push(JValue.R(rt.String("RemoveCreatureTypes")));f.Pc=1662;continue;}
case 1662:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1667);}
case 1667:{f.Pc=f.Pop().Int==0?1681:1670;continue;}
case 1670:{f.Push(f.Locals[31]);f.Pc=1672;continue;}
case 1672:{if(!rt.StaticReady(f,"forge/card/RemoveType","CreatureTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","CreatureTypes","Lforge/card/RemoveType;"));f.Pc=1675;continue;}
case 1675:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",1680);}
case 1680:{f.StackOp("pop");f.Pc=1681;continue;}
case 1681:{f.Push(f.Locals[3]);f.Pc=1682;continue;}
case 1682:{f.Push(JValue.R(rt.String("RemoveArtifactTypes")));f.Pc=1685;continue;}
case 1685:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1690);}
case 1690:{f.Pc=f.Pop().Int==0?1704:1693;continue;}
case 1693:{f.Push(f.Locals[31]);f.Pc=1695;continue;}
case 1695:{if(!rt.StaticReady(f,"forge/card/RemoveType","ArtifactTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","ArtifactTypes","Lforge/card/RemoveType;"));f.Pc=1698;continue;}
case 1698:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",1703);}
case 1703:{f.StackOp("pop");f.Pc=1704;continue;}
case 1704:{f.Push(f.Locals[3]);f.Pc=1705;continue;}
case 1705:{f.Push(JValue.R(rt.String("RemoveEnchantmentTypes")));f.Pc=1708;continue;}
case 1708:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1713);}
case 1713:{f.Pc=f.Pop().Int==0?1727:1716;continue;}
case 1716:{f.Push(f.Locals[31]);f.Pc=1718;continue;}
case 1718:{if(!rt.StaticReady(f,"forge/card/RemoveType","EnchantmentTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","EnchantmentTypes","Lforge/card/RemoveType;"));f.Pc=1721;continue;}
case 1721:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",1726);}
case 1726:{f.StackOp("pop");f.Pc=1727;continue;}
case 1727:{f.Push(f.Locals[2]);f.Pc=1728;continue;}
case 1728:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","COLOR","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","COLOR","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1731;continue;}
case 1731:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1797:1734;continue;}
case 1734:{f.Push(f.Locals[3]);f.Pc=1735;continue;}
case 1735:{f.Push(JValue.R(rt.String("AddColor")));f.Pc=1738;continue;}
case 1738:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1743);}
case 1743:{f.Pc=f.Pop().Int==0?1764:1746;continue;}
case 1746:{f.Push(f.Locals[0]);f.Pc=1747;continue;}
case 1747:{f.Push(f.Locals[3]);f.Pc=1748;continue;}
case 1748:{f.Push(JValue.R(rt.String("AddColor")));f.Pc=1751;continue;}
case 1751:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1756);}
case 1756:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1759;continue;}
case 1759:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous","getColorsFromParam","(Lforge/game/staticability/StaticAbility;Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",1762);}
case 1762:{f.Locals[26]=f.Pop();f.Pc=1764;continue;}
case 1764:{f.Push(f.Locals[3]);f.Pc=1765;continue;}
case 1765:{f.Push(JValue.R(rt.String("SetColor")));f.Pc=1768;continue;}
case 1768:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1773);}
case 1773:{f.Pc=f.Pop().Int==0?1797:1776;continue;}
case 1776:{f.Push(f.Locals[0]);f.Pc=1777;continue;}
case 1777:{f.Push(f.Locals[3]);f.Pc=1778;continue;}
case 1778:{f.Push(JValue.R(rt.String("SetColor")));f.Pc=1781;continue;}
case 1781:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1786);}
case 1786:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1789;continue;}
case 1789:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous","getColorsFromParam","(Lforge/game/staticability/StaticAbility;Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",1792);}
case 1792:{f.Locals[26]=f.Pop();f.Pc=1794;continue;}
case 1794:{f.Push(JValue.I(1));f.Pc=1795;continue;}
case 1795:{f.Locals[32]=f.Pop();f.Pc=1797;continue;}
case 1797:{f.Push(f.Locals[2]);f.Pc=1798;continue;}
case 1798:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1801;continue;}
case 1801:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?2019:1804;continue;}
case 1804:{f.Push(f.Locals[3]);f.Pc=1805;continue;}
case 1805:{f.Push(JValue.R(rt.String("MayLookAt")));f.Pc=1808;continue;}
case 1808:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1813);}
case 1813:{f.Pc=f.Pop().Int==0?1863:1816;continue;}
case 1816:{f.Push(f.Locals[3]);f.Pc=1817;continue;}
case 1817:{f.Push(JValue.R(rt.String("MayLookAt")));f.Pc=1820;continue;}
case 1820:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1825);}
case 1825:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1828;continue;}
case 1828:{f.Locals[41]=f.Pop();f.Pc=1830;continue;}
case 1830:{f.Push(JValue.R(rt.String("True")));f.Pc=1833;continue;}
case 1833:{f.Push(f.Locals[41]);f.Pc=1835;continue;}
case 1835:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1838);}
case 1838:{f.Pc=f.Pop().Int==0?1853:1841;continue;}
case 1841:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=1844;continue;}
case 1844:{f.StackOp("dup");f.Pc=1845;continue;}
case 1845:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",1848);}
case 1848:{f.Locals[34]=f.Pop();f.Pc=1850;continue;}
case 1850:{f.Pc=1863;continue;}
case 1853:{f.Push(f.Locals[4]);f.Pc=1855;continue;}
case 1855:{f.Push(f.Locals[41]);f.Pc=1857;continue;}
case 1857:{f.Push(f.Locals[0]);f.Pc=1858;continue;}
case 1858:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1861);}
case 1861:{f.Locals[34]=f.Pop();f.Pc=1863;continue;}
case 1863:{f.Push(f.Locals[3]);f.Pc=1864;continue;}
case 1864:{f.Push(JValue.R(rt.String("MayPlay")));f.Pc=1867;continue;}
case 1867:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1872);}
case 1872:{f.Pc=f.Pop().Int==0?1984:1875;continue;}
case 1875:{f.Push(JValue.I(1));f.Pc=1876;continue;}
case 1876:{f.Locals[35]=f.Pop();f.Pc=1878;continue;}
case 1878:{f.Push(f.Locals[3]);f.Pc=1879;continue;}
case 1879:{f.Push(JValue.R(rt.String("MayPlayWithoutManaCost")));f.Pc=1882;continue;}
case 1882:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1887);}
case 1887:{f.Pc=f.Pop().Int==0?1896:1890;continue;}
case 1890:{f.Push(JValue.I(1));f.Pc=1891;continue;}
case 1891:{f.Locals[36]=f.Pop();f.Pc=1893;continue;}
case 1893:{f.Pc=1922;continue;}
case 1896:{f.Push(f.Locals[3]);f.Pc=1897;continue;}
case 1897:{f.Push(JValue.R(rt.String("MayPlayAltManaCost")));f.Pc=1900;continue;}
case 1900:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1905);}
case 1905:{f.Pc=f.Pop().Int==0?1922:1908;continue;}
case 1908:{f.Push(f.Locals[3]);f.Pc=1909;continue;}
case 1909:{f.Push(JValue.R(rt.String("MayPlayAltManaCost")));f.Pc=1912;continue;}
case 1912:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1917);}
case 1917:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1920;continue;}
case 1920:{f.Locals[38]=f.Pop();f.Pc=1922;continue;}
case 1922:{f.Push(f.Locals[3]);f.Pc=1923;continue;}
case 1923:{f.Push(JValue.R(rt.String("MayPlayWithFlash")));f.Pc=1926;continue;}
case 1926:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1931);}
case 1931:{f.Pc=f.Pop().Int==0?1937:1934;continue;}
case 1934:{f.Push(JValue.I(1));f.Pc=1935;continue;}
case 1935:{f.Locals[37]=f.Pop();f.Pc=1937;continue;}
case 1937:{f.Push(f.Locals[3]);f.Pc=1938;continue;}
case 1938:{f.Push(JValue.R(rt.String("MayPlayLimit")));f.Pc=1941;continue;}
case 1941:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1946);}
case 1946:{f.Pc=f.Pop().Int==0?1969:1949;continue;}
case 1949:{f.Push(f.Locals[3]);f.Pc=1950;continue;}
case 1950:{f.Push(JValue.R(rt.String("MayPlayLimit")));f.Pc=1953;continue;}
case 1953:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1958);}
case 1958:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1961;continue;}
case 1961:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1964);}
case 1964:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1967);}
case 1967:{f.Locals[40]=f.Pop();f.Pc=1969;continue;}
case 1969:{f.Push(f.Locals[3]);f.Pc=1970;continue;}
case 1970:{f.Push(JValue.R(rt.String("MayPlayDontGrantZonePermissions")));f.Pc=1973;continue;}
case 1973:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1978);}
case 1978:{f.Pc=f.Pop().Int==0?1984:1981;continue;}
case 1981:{f.Push(JValue.I(0));f.Pc=1982;continue;}
case 1982:{f.Locals[39]=f.Pop();f.Pc=1984;continue;}
case 1984:{f.Push(f.Locals[3]);f.Pc=1985;continue;}
case 1985:{f.Push(JValue.R(rt.String("IgnoreEffectCost")));f.Pc=1988;continue;}
case 1988:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1993);}
case 1993:{f.Pc=f.Pop().Int==0?2019:1996;continue;}
case 1996:{f.Push(f.Locals[3]);f.Pc=1997;continue;}
case 1997:{f.Push(JValue.R(rt.String("IgnoreEffectCost")));f.Pc=2000;continue;}
case 2000:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2005);}
case 2005:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2008;continue;}
case 2008:{f.Locals[41]=f.Pop();f.Pc=2010;continue;}
case 2010:{f.Push(f.Locals[0]);f.Pc=2011;continue;}
case 2011:{f.Push(f.Locals[41]);f.Pc=2013;continue;}
case 2013:{f.Push(f.Locals[6]);f.Pc=2015;continue;}
case 2015:{f.Push(f.Locals[1]);f.Pc=2016;continue;}
case 2016:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous","buildIgnoreEffectAbility","(Lforge/game/staticability/StaticAbility;Ljava/lang/String;Ljava/util/List;Lforge/game/card/CardCollectionView;)V","invokestatic",2019);}
case 2019:{f.Push(f.Locals[6]);f.Pc=2021;continue;}
case 2021:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",2026);}
case 2026:{f.Locals[41]=f.Pop();f.Pc=2028;continue;}
case 2028:{f.Push(f.Locals[41]);f.Pc=2030;continue;}
case 2030:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2035);}
case 2035:{f.Pc=f.Pop().Int==0?2621:2038;continue;}
case 2038:{f.Push(f.Locals[41]);f.Pc=2040;continue;}
case 2040:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2045);}
case 2045:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2048;continue;}
case 2048:{f.Locals[42]=f.Pop();f.Pc=2050;continue;}
case 2050:{f.Push(f.Locals[17]);f.Pc=2052;continue;}
case 2052:{f.Pc=f.Pop().Reference==null?2087:2055;continue;}
case 2055:{f.Push(f.Locals[17]);f.Pc=2057;continue;}
case 2057:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",2062);}
case 2062:{f.Pc=f.Pop().Int!=0?2087:2065;continue;}
case 2065:{f.Push(f.Locals[42]);f.Pc=2067;continue;}
case 2067:{f.Push(f.Locals[17]);f.Pc=2069;continue;}
case 2069:{f.Push(f.Locals[20]);f.Pc=2071;continue;}
case 2071:{f.Push(f.Locals[8]);f.Pc=2073;continue;}
case 2073:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",2076);}
case 2076:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",2079);}
case 2079:{f.Push(f.Locals[0]);f.Pc=2080;continue;}
case 2080:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",2083);}
case 2083:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=2084;continue;}
case 2084:{return rt.Call(f,"forge/game/player/Player","addChangedKeywords","(Ljava/util/List;Ljava/util/List;Ljava/lang/Long;J)V","invokevirtual",2087);}
case 2087:{f.Push(f.Locals[2]);f.Pc=2088;continue;}
case 2088:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=2091;continue;}
case 2091:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?2618:2094;continue;}
case 2094:{f.Push(f.Locals[3]);f.Pc=2095;continue;}
case 2095:{f.Push(JValue.R(rt.String("SetMaxHandSize")));f.Pc=2098;continue;}
case 2098:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",2103);}
case 2103:{f.Pc=f.Pop().Int==0?2163:2106;continue;}
case 2106:{f.Push(f.Locals[3]);f.Pc=2107;continue;}
case 2107:{f.Push(JValue.R(rt.String("SetMaxHandSize")));f.Pc=2110;continue;}
case 2110:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2115);}
case 2115:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2118;continue;}
case 2118:{f.Locals[43]=f.Pop();f.Pc=2120;continue;}
case 2120:{f.Push(f.Locals[43]);f.Pc=2122;continue;}
case 2122:{f.Push(JValue.R(rt.String("Unlimited")));f.Pc=2125;continue;}
case 2125:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2128);}
case 2128:{f.Pc=f.Pop().Int==0?2140:2131;continue;}
case 2131:{f.Push(f.Locals[42]);f.Pc=2133;continue;}
case 2133:{f.Push(JValue.I(1));f.Pc=2134;continue;}
case 2134:{return rt.Call(f,"forge/game/player/Player","setUnlimitedHandSize","(Z)V","invokevirtual",2137);}
case 2137:{f.Pc=2163;continue;}
case 2140:{f.Push(f.Locals[42]);f.Pc=2142;continue;}
case 2142:{f.Push(JValue.I(0));f.Pc=2143;continue;}
case 2143:{return rt.Call(f,"forge/game/player/Player","setUnlimitedHandSize","(Z)V","invokevirtual",2146);}
case 2146:{f.Push(f.Locals[4]);f.Pc=2148;continue;}
case 2148:{f.Push(f.Locals[43]);f.Pc=2150;continue;}
case 2150:{f.Push(f.Locals[0]);f.Pc=2151;continue;}
case 2151:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",2154);}
case 2154:{f.Locals[44]=f.Pop();f.Pc=2156;continue;}
case 2156:{f.Push(f.Locals[42]);f.Pc=2158;continue;}
case 2158:{f.Push(f.Locals[44]);f.Pc=2160;continue;}
case 2160:{return rt.Call(f,"forge/game/player/Player","setMaxHandSize","(I)V","invokevirtual",2163);}
case 2163:{f.Push(f.Locals[3]);f.Pc=2164;continue;}
case 2164:{f.Push(JValue.R(rt.String("RaiseMaxHandSize")));f.Pc=2167;continue;}
case 2167:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",2172);}
case 2172:{f.Pc=f.Pop().Int==0?2212:2175;continue;}
case 2175:{f.Push(f.Locals[3]);f.Pc=2176;continue;}
case 2176:{f.Push(JValue.R(rt.String("RaiseMaxHandSize")));f.Pc=2179;continue;}
case 2179:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2184);}
case 2184:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2187;continue;}
case 2187:{f.Locals[43]=f.Pop();f.Pc=2189;continue;}
case 2189:{f.Push(f.Locals[4]);f.Pc=2191;continue;}
case 2191:{f.Push(f.Locals[43]);f.Pc=2193;continue;}
case 2193:{f.Push(f.Locals[0]);f.Pc=2194;continue;}
case 2194:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",2197);}
case 2197:{f.Locals[44]=f.Pop();f.Pc=2199;continue;}
case 2199:{f.Push(f.Locals[42]);f.Pc=2201;continue;}
case 2201:{f.Push(f.Locals[42]);f.Pc=2203;continue;}
case 2203:{return rt.Call(f,"forge/game/player/Player","getMaxHandSize","()I","invokevirtual",2206);}
case 2206:{f.Push(f.Locals[44]);f.Pc=2208;continue;}
case 2208:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=2209;continue;}
case 2209:{return rt.Call(f,"forge/game/player/Player","setMaxHandSize","(I)V","invokevirtual",2212);}
case 2212:{f.Push(f.Locals[3]);f.Pc=2213;continue;}
case 2213:{f.Push(JValue.R(rt.String("AdjustLandPlays")));f.Pc=2216;continue;}
case 2216:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",2221);}
case 2221:{f.Pc=f.Pop().Int==0?2284:2224;continue;}
case 2224:{f.Push(f.Locals[3]);f.Pc=2225;continue;}
case 2225:{f.Push(JValue.R(rt.String("AdjustLandPlays")));f.Pc=2228;continue;}
case 2228:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2233);}
case 2233:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2236;continue;}
case 2236:{f.Locals[43]=f.Pop();f.Pc=2238;continue;}
case 2238:{f.Push(f.Locals[43]);f.Pc=2240;continue;}
case 2240:{f.Push(JValue.R(rt.String("Unlimited")));f.Pc=2243;continue;}
case 2243:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2246);}
case 2246:{f.Pc=f.Pop().Int==0?2262:2249;continue;}
case 2249:{f.Push(f.Locals[42]);f.Pc=2251;continue;}
case 2251:{f.Push(f.Locals[8]);f.Pc=2253;continue;}
case 2253:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",2256);}
case 2256:{return rt.Call(f,"forge/game/player/Player","addMaxLandPlaysInfinite","(J)V","invokevirtual",2259);}
case 2259:{f.Pc=2284;continue;}
case 2262:{f.Push(f.Locals[4]);f.Pc=2264;continue;}
case 2264:{f.Push(f.Locals[43]);f.Pc=2266;continue;}
case 2266:{f.Push(f.Locals[0]);f.Pc=2267;continue;}
case 2267:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",2270);}
case 2270:{f.Locals[44]=f.Pop();f.Pc=2272;continue;}
case 2272:{f.Push(f.Locals[42]);f.Pc=2274;continue;}
case 2274:{f.Push(f.Locals[8]);f.Pc=2276;continue;}
case 2276:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",2279);}
case 2279:{f.Push(f.Locals[44]);f.Pc=2281;continue;}
case 2281:{return rt.Call(f,"forge/game/player/Player","addMaxLandPlays","(JI)V","invokevirtual",2284);}
case 2284:{f.Push(f.Locals[3]);f.Pc=2285;continue;}
case 2285:{f.Push(JValue.R(rt.String("ControlOpponentsSearchingLibrary")));f.Pc=2288;continue;}
case 2288:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",2293);}
case 2293:{f.Pc=f.Pop().Int==0?2335:2296;continue;}
case 2296:{f.Push(f.Locals[4]);f.Pc=2298;continue;}
case 2298:{f.Push(f.Locals[3]);f.Pc=2299;continue;}
case 2299:{f.Push(JValue.R(rt.String("ControlOpponentsSearchingLibrary")));f.Pc=2302;continue;}
case 2302:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2307);}
case 2307:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2310;continue;}
case 2310:{f.Push(f.Locals[0]);f.Pc=2311;continue;}
case 2311:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",2314);}
case 2314:{f.Push(JValue.R(null));f.Pc=2315;continue;}
case 2315:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",2318);}
case 2318:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2321;continue;}
case 2321:{f.Locals[43]=f.Pop();f.Pc=2323;continue;}
case 2323:{f.Push(f.Locals[42]);f.Pc=2325;continue;}
case 2325:{f.Push(f.Locals[8]);f.Pc=2327;continue;}
case 2327:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",2330);}
case 2330:{f.Push(f.Locals[43]);f.Pc=2332;continue;}
case 2332:{return rt.Call(f,"forge/game/player/Player","addControlledWhileSearching","(JLforge/game/player/Player;)V","invokevirtual",2335);}
case 2335:{f.Push(f.Locals[3]);f.Pc=2336;continue;}
case 2336:{f.Push(JValue.R(rt.String("ControlVote")));f.Pc=2339;continue;}
case 2339:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",2344);}
case 2344:{f.Pc=f.Pop().Int==0?2358:2347;continue;}
case 2347:{f.Push(f.Locals[42]);f.Pc=2349;continue;}
case 2349:{f.Push(f.Locals[8]);f.Pc=2351;continue;}
case 2351:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",2354);}
case 2354:{return rt.Call(f,"forge/game/player/Player","addControlVote","(J)Z","invokevirtual",2357);}
case 2357:{f.StackOp("pop");f.Pc=2358;continue;}
case 2358:{f.Push(f.Locals[3]);f.Pc=2359;continue;}
case 2359:{f.Push(JValue.R(rt.String("AdditionalVote")));f.Pc=2362;continue;}
case 2362:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",2367);}
case 2367:{f.Pc=f.Pop().Int==0?2406:2370;continue;}
case 2370:{f.Push(f.Locals[3]);f.Pc=2371;continue;}
case 2371:{f.Push(JValue.R(rt.String("AdditionalVote")));f.Pc=2374;continue;}
case 2374:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2379);}
case 2379:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2382;continue;}
case 2382:{f.Locals[43]=f.Pop();f.Pc=2384;continue;}
case 2384:{f.Push(f.Locals[4]);f.Pc=2386;continue;}
case 2386:{f.Push(f.Locals[43]);f.Pc=2388;continue;}
case 2388:{f.Push(f.Locals[0]);f.Pc=2389;continue;}
case 2389:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",2392);}
case 2392:{f.Locals[44]=f.Pop();f.Pc=2394;continue;}
case 2394:{f.Push(f.Locals[42]);f.Pc=2396;continue;}
case 2396:{f.Push(f.Locals[8]);f.Pc=2398;continue;}
case 2398:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",2401);}
case 2401:{f.Push(f.Locals[44]);f.Pc=2403;continue;}
case 2403:{return rt.Call(f,"forge/game/player/Player","addAdditionalVote","(JI)V","invokevirtual",2406);}
case 2406:{f.Push(f.Locals[3]);f.Pc=2407;continue;}
case 2407:{f.Push(JValue.R(rt.String("AdditionalOptionalVote")));f.Pc=2410;continue;}
case 2410:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",2415);}
case 2415:{f.Pc=f.Pop().Int==0?2454:2418;continue;}
case 2418:{f.Push(f.Locals[3]);f.Pc=2419;continue;}
case 2419:{f.Push(JValue.R(rt.String("AdditionalOptionalVote")));f.Pc=2422;continue;}
case 2422:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2427);}
case 2427:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2430;continue;}
case 2430:{f.Locals[43]=f.Pop();f.Pc=2432;continue;}
case 2432:{f.Push(f.Locals[4]);f.Pc=2434;continue;}
case 2434:{f.Push(f.Locals[43]);f.Pc=2436;continue;}
case 2436:{f.Push(f.Locals[0]);f.Pc=2437;continue;}
case 2437:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",2440);}
case 2440:{f.Locals[44]=f.Pop();f.Pc=2442;continue;}
case 2442:{f.Push(f.Locals[42]);f.Pc=2444;continue;}
case 2444:{f.Push(f.Locals[8]);f.Pc=2446;continue;}
case 2446:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",2449);}
case 2449:{f.Push(f.Locals[44]);f.Pc=2451;continue;}
case 2451:{return rt.Call(f,"forge/game/player/Player","addAdditionalOptionalVote","(JI)V","invokevirtual",2454);}
case 2454:{f.Push(f.Locals[3]);f.Pc=2455;continue;}
case 2455:{f.Push(JValue.R(rt.String("AdditionalVillainousChoice")));f.Pc=2458;continue;}
case 2458:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",2463);}
case 2463:{f.Pc=f.Pop().Int==0?2502:2466;continue;}
case 2466:{f.Push(f.Locals[3]);f.Pc=2467;continue;}
case 2467:{f.Push(JValue.R(rt.String("AdditionalVillainousChoice")));f.Pc=2470;continue;}
case 2470:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2475);}
case 2475:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2478;continue;}
case 2478:{f.Locals[43]=f.Pop();f.Pc=2480;continue;}
case 2480:{f.Push(f.Locals[4]);f.Pc=2482;continue;}
case 2482:{f.Push(f.Locals[43]);f.Pc=2484;continue;}
case 2484:{f.Push(f.Locals[0]);f.Pc=2485;continue;}
case 2485:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",2488);}
case 2488:{f.Locals[44]=f.Pop();f.Pc=2490;continue;}
case 2490:{f.Push(f.Locals[42]);f.Pc=2492;continue;}
case 2492:{f.Push(f.Locals[8]);f.Pc=2494;continue;}
case 2494:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",2497);}
case 2497:{f.Push(f.Locals[44]);f.Pc=2499;continue;}
case 2499:{return rt.Call(f,"forge/game/player/Player","addAdditionalVillainousChoices","(JI)V","invokevirtual",2502);}
case 2502:{f.Push(f.Locals[3]);f.Pc=2503;continue;}
case 2503:{f.Push(JValue.R(rt.String("DeclaresAttackers")));f.Pc=2506;continue;}
case 2506:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",2511);}
case 2511:{f.Pc=f.Pop().Int==0?2560:2514;continue;}
case 2514:{f.Push(f.Locals[4]);f.Pc=2516;continue;}
case 2516:{f.Push(f.Locals[3]);f.Pc=2517;continue;}
case 2517:{f.Push(JValue.R(rt.String("DeclaresAttackers")));f.Pc=2520;continue;}
case 2520:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2525);}
case 2525:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2528;continue;}
case 2528:{f.Push(f.Locals[0]);f.Pc=2529;continue;}
case 2529:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",2532);}
case 2532:{f.Locals[43]=f.Pop();f.Pc=2534;continue;}
case 2534:{f.Push(f.Locals[43]);f.Pc=2536;continue;}
case 2536:{return rt.Call(f,"forge/game/player/PlayerCollection","isEmpty","()Z","invokevirtual",2539);}
case 2539:{f.Pc=f.Pop().Int!=0?2560:2542;continue;}
case 2542:{f.Push(f.Locals[42]);f.Pc=2544;continue;}
case 2544:{f.Push(f.Locals[8]);f.Pc=2546;continue;}
case 2546:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",2549);}
case 2549:{f.Push(f.Locals[43]);f.Pc=2551;continue;}
case 2551:{return rt.Call(f,"forge/game/player/PlayerCollection","getFirst","()Ljava/lang/Object;","invokevirtual",2554);}
case 2554:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2557;continue;}
case 2557:{return rt.Call(f,"forge/game/player/Player","addDeclaresAttackers","(JLforge/game/player/Player;)V","invokevirtual",2560);}
case 2560:{f.Push(f.Locals[3]);f.Pc=2561;continue;}
case 2561:{f.Push(JValue.R(rt.String("DeclaresBlockers")));f.Pc=2564;continue;}
case 2564:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",2569);}
case 2569:{f.Pc=f.Pop().Int==0?2618:2572;continue;}
case 2572:{f.Push(f.Locals[4]);f.Pc=2574;continue;}
case 2574:{f.Push(f.Locals[3]);f.Pc=2575;continue;}
case 2575:{f.Push(JValue.R(rt.String("DeclaresBlockers")));f.Pc=2578;continue;}
case 2578:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2583);}
case 2583:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2586;continue;}
case 2586:{f.Push(f.Locals[0]);f.Pc=2587;continue;}
case 2587:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",2590);}
case 2590:{f.Locals[43]=f.Pop();f.Pc=2592;continue;}
case 2592:{f.Push(f.Locals[43]);f.Pc=2594;continue;}
case 2594:{return rt.Call(f,"forge/game/player/PlayerCollection","isEmpty","()Z","invokevirtual",2597);}
case 2597:{f.Pc=f.Pop().Int!=0?2618:2600;continue;}
case 2600:{f.Push(f.Locals[42]);f.Pc=2602;continue;}
case 2602:{f.Push(f.Locals[8]);f.Pc=2604;continue;}
case 2604:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",2607);}
case 2607:{f.Push(f.Locals[43]);f.Pc=2609;continue;}
case 2609:{return rt.Call(f,"forge/game/player/PlayerCollection","getFirst","()Ljava/lang/Object;","invokevirtual",2612);}
case 2612:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2615;continue;}
case 2615:{return rt.Call(f,"forge/game/player/Player","addDeclaresBlockers","(JLforge/game/player/Player;)V","invokevirtual",2618);}
case 2618:{f.Pc=2028;continue;}
case 2621:{f.Push(f.Locals[1]);f.Pc=2622;continue;}
case 2622:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",2627);}
case 2627:{f.Locals[41]=f.Pop();f.Pc=2629;continue;}
case 2629:{f.Push(f.Locals[41]);f.Pc=2631;continue;}
case 2631:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2636);}
case 2636:{f.Pc=f.Pop().Int==0?5713:2639;continue;}
case 2639:{f.Push(f.Locals[41]);f.Pc=2641;continue;}
case 2641:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2646);}
case 2646:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2649;continue;}
case 2649:{f.Locals[42]=f.Pop();f.Pc=2651;continue;}
case 2651:{f.Push(f.Locals[2]);f.Pc=2652;continue;}
case 2652:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=2655;continue;}
case 2655:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?2717:2658;continue;}
case 2658:{f.Push(f.Locals[3]);f.Pc=2659;continue;}
case 2659:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=2662;continue;}
case 2662:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",2667);}
case 2667:{f.Pc=f.Pop().Int==0?2717:2670;continue;}
case 2670:{f.Push(f.Locals[4]);f.Pc=2672;continue;}
case 2672:{f.Push(f.Locals[3]);f.Pc=2673;continue;}
case 2673:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=2676;continue;}
case 2676:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2681);}
case 2681:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2684;continue;}
case 2684:{f.Push(f.Locals[0]);f.Pc=2685;continue;}
case 2685:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",2688);}
case 2688:{f.Locals[43]=f.Pop();f.Pc=2690;continue;}
case 2690:{f.Push(f.Locals[43]);f.Pc=2692;continue;}
case 2692:{return rt.Call(f,"forge/game/player/PlayerCollection","isEmpty","()Z","invokevirtual",2695);}
case 2695:{f.Pc=f.Pop().Int!=0?2717:2698;continue;}
case 2698:{f.Push(f.Locals[42]);f.Pc=2700;continue;}
case 2700:{f.Push(f.Locals[43]);f.Pc=2702;continue;}
case 2702:{f.Push(JValue.I(0));f.Pc=2703;continue;}
case 2703:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",2706);}
case 2706:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2709;continue;}
case 2709:{f.Push(f.Locals[8]);f.Pc=2711;continue;}
case 2711:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",2714);}
case 2714:{return rt.Call(f,"forge/game/card/Card","addTempController","(Lforge/game/player/Player;J)V","invokevirtual",2717);}
case 2717:{f.Push(f.Locals[2]);f.Pc=2718;continue;}
case 2718:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=2721;continue;}
case 2721:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?3657:2724;continue;}
case 2724:{f.Push(f.Locals[3]);f.Pc=2725;continue;}
case 2725:{f.Push(JValue.R(rt.String("GainTextOf")));f.Pc=2728;continue;}
case 2728:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",2733);}
case 2733:{f.Pc=f.Pop().Int==0?3339:2736;continue;}
case 2736:{f.Push(f.Locals[4]);f.Pc=2738;continue;}
case 2738:{f.Push(f.Locals[3]);f.Pc=2739;continue;}
case 2739:{f.Push(JValue.R(rt.String("GainTextOf")));f.Pc=2742;continue;}
case 2742:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2747);}
case 2747:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2750;continue;}
case 2750:{f.Push(f.Locals[0]);f.Pc=2751;continue;}
case 2751:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",2754);}
case 2754:{f.Locals[43]=f.Pop();f.Pc=2756;continue;}
case 2756:{f.Push(f.Locals[43]);f.Pc=2758;continue;}
case 2758:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",2761);}
case 2761:{f.Pc=f.Pop().Int!=0?3339:2764;continue;}
case 2764:{f.Push(f.Locals[43]);f.Pc=2766;continue;}
case 2766:{return rt.Call(f,"forge/game/card/CardCollection","getFirst","()Ljava/lang/Object;","invokevirtual",2769);}
case 2769:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2772;continue;}
case 2772:{f.Locals[44]=f.Pop();f.Pc=2774;continue;}
case 2774:{f.Push(f.Locals[44]);f.Pc=2776;continue;}
case 2776:{f.Push(f.Locals[42]);f.Pc=2778;continue;}
case 2778:{return rt.Call(f,"forge/game/card/Card","isFlipped","()Z","invokevirtual",2781);}
case 2781:{f.Pc=f.Pop().Int==0?2798:2784;continue;}
case 2784:{f.Push(f.Locals[44]);f.Pc=2786;continue;}
case 2786:{return rt.Call(f,"forge/game/card/Card","isFlipCard","()Z","invokevirtual",2789);}
case 2789:{f.Pc=f.Pop().Int==0?2798:2792;continue;}
case 2792:{if(!rt.StaticReady(f,"forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Flipped","Lforge/card/CardStateName;"));f.Pc=2795;continue;}
case 2795:{f.Pc=2803;continue;}
case 2798:{f.Push(f.Locals[44]);f.Pc=2800;continue;}
case 2800:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",2803);}
case 2803:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",2806);}
case 2806:{f.Locals[45]=f.Pop();f.Pc=2808;continue;}
case 2808:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",2811);}
case 2811:{f.Locals[46]=f.Pop();f.Pc=2813;continue;}
case 2813:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",2816);}
case 2816:{f.Locals[47]=f.Pop();f.Pc=2818;continue;}
case 2818:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",2821);}
case 2821:{f.Locals[48]=f.Pop();f.Pc=2823;continue;}
case 2823:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",2826);}
case 2826:{f.Locals[49]=f.Pop();f.Pc=2828;continue;}
case 2828:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",2831);}
case 2831:{f.Locals[50]=f.Pop();f.Pc=2833;continue;}
case 2833:{f.Push(f.Locals[45]);f.Pc=2835;continue;}
case 2835:{return rt.Call(f,"forge/game/card/CardState","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",2838);}
case 2838:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",2843);}
case 2843:{f.Locals[51]=f.Pop();f.Pc=2845;continue;}
case 2845:{f.Push(f.Locals[51]);f.Pc=2847;continue;}
case 2847:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2852);}
case 2852:{f.Pc=f.Pop().Int==0?2886:2855;continue;}
case 2855:{f.Push(f.Locals[51]);f.Pc=2857;continue;}
case 2857:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2862);}
case 2862:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2865;continue;}
case 2865:{f.Locals[52]=f.Pop();f.Pc=2867;continue;}
case 2867:{f.Push(f.Locals[46]);f.Pc=2869;continue;}
case 2869:{f.Push(f.Locals[42]);f.Pc=2871;continue;}
case 2871:{f.Push(f.Locals[52]);f.Pc=2873;continue;}
case 2873:{f.Push(f.Locals[0]);f.Pc=2874;continue;}
case 2874:{return rt.Call(f,"forge/game/card/Card","getSpellAbilityForStaticAbilityByText","(Lforge/game/spellability/SpellAbility;Lforge/game/staticability/StaticAbility;)Lforge/game/spellability/SpellAbility;","invokevirtual",2877);}
case 2877:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",2882);}
case 2882:{f.StackOp("pop");f.Pc=2883;continue;}
case 2883:{f.Pc=2845;continue;}
case 2886:{f.Push(f.Locals[3]);f.Pc=2887;continue;}
case 2887:{f.Push(JValue.R(rt.String("GainTextAbilities")));f.Pc=2890;continue;}
case 2890:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",2895);}
case 2895:{f.Pc=f.Pop().Int==0?2965:2898;continue;}
case 2898:{f.Push(f.Locals[3]);f.Pc=2899;continue;}
case 2899:{f.Push(JValue.R(rt.String("GainTextAbilities")));f.Pc=2902;continue;}
case 2902:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2907);}
case 2907:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2910;continue;}
case 2910:{f.Push(JValue.R(rt.String(" & ")));f.Pc=2912;continue;}
case 2912:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2915);}
case 2915:{f.Locals[51]=f.Pop();f.Pc=2917;continue;}
case 2917:{f.Push(f.Locals[51]);f.Pc=2919;continue;}
case 2919:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2920;continue;}
case 2920:{f.Locals[52]=f.Pop();f.Pc=2922;continue;}
case 2922:{f.Push(JValue.I(0));f.Pc=2923;continue;}
case 2923:{f.Locals[53]=f.Pop();f.Pc=2925;continue;}
case 2925:{f.Push(f.Locals[53]);f.Pc=2927;continue;}
case 2927:{f.Push(f.Locals[52]);f.Pc=2929;continue;}
case 2929:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?2965:2932;continue;}
case 2932:{f.Push(f.Locals[51]);f.Pc=2934;continue;}
case 2934:{f.Push(f.Locals[53]);f.Pc=2936;continue;}
case 2936:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2937;continue;}
case 2937:{f.Locals[54]=f.Pop();f.Pc=2939;continue;}
case 2939:{f.Push(f.Locals[46]);f.Pc=2941;continue;}
case 2941:{f.Push(f.Locals[42]);f.Pc=2943;continue;}
case 2943:{f.Push(f.Locals[0]);f.Pc=2944;continue;}
case 2944:{f.Push(f.Locals[54]);f.Pc=2946;continue;}
case 2946:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",2949);}
case 2949:{f.Push(f.Locals[0]);f.Pc=2950;continue;}
case 2950:{return rt.Call(f,"forge/game/card/Card","getSpellAbilityForStaticAbilityGainedByText","(Ljava/lang/String;Lforge/game/staticability/StaticAbility;)Lforge/game/spellability/SpellAbility;","invokevirtual",2953);}
case 2953:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",2958);}
case 2958:{f.StackOp("pop");f.Pc=2959;continue;}
case 2959:{f.Locals[53]=JValue.I(unchecked(f.Locals[53].Int+(1)));f.Pc=2962;continue;}
case 2962:{f.Pc=2925;continue;}
case 2965:{f.Push(f.Locals[45]);f.Pc=2967;continue;}
case 2967:{return rt.Call(f,"forge/game/card/CardState","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",2970);}
case 2970:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",2975);}
case 2975:{f.Locals[51]=f.Pop();f.Pc=2977;continue;}
case 2977:{f.Push(f.Locals[51]);f.Pc=2979;continue;}
case 2979:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2984);}
case 2984:{f.Pc=f.Pop().Int==0?3018:2987;continue;}
case 2987:{f.Push(f.Locals[51]);f.Pc=2989;continue;}
case 2989:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2994);}
case 2994:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2997;continue;}
case 2997:{f.Locals[52]=f.Pop();f.Pc=2999;continue;}
case 2999:{f.Push(f.Locals[47]);f.Pc=3001;continue;}
case 3001:{f.Push(f.Locals[42]);f.Pc=3003;continue;}
case 3003:{f.Push(f.Locals[52]);f.Pc=3005;continue;}
case 3005:{f.Push(f.Locals[0]);f.Pc=3006;continue;}
case 3006:{return rt.Call(f,"forge/game/card/Card","getTriggerForStaticAbilityByText","(Lforge/game/trigger/Trigger;Lforge/game/staticability/StaticAbility;)Lforge/game/trigger/Trigger;","invokevirtual",3009);}
case 3009:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",3014);}
case 3014:{f.StackOp("pop");f.Pc=3015;continue;}
case 3015:{f.Pc=2977;continue;}
case 3018:{f.Push(f.Locals[45]);f.Pc=3020;continue;}
case 3020:{return rt.Call(f,"forge/game/card/CardState","getReplacementEffects","()Lforge/util/collect/FCollectionView;","invokevirtual",3023);}
case 3023:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",3028);}
case 3028:{f.Locals[51]=f.Pop();f.Pc=3030;continue;}
case 3030:{f.Push(f.Locals[51]);f.Pc=3032;continue;}
case 3032:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3037);}
case 3037:{f.Pc=f.Pop().Int==0?3071:3040;continue;}
case 3040:{f.Push(f.Locals[51]);f.Pc=3042;continue;}
case 3042:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3047);}
case 3047:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3050;continue;}
case 3050:{f.Locals[52]=f.Pop();f.Pc=3052;continue;}
case 3052:{f.Push(f.Locals[48]);f.Pc=3054;continue;}
case 3054:{f.Push(f.Locals[42]);f.Pc=3056;continue;}
case 3056:{f.Push(f.Locals[52]);f.Pc=3058;continue;}
case 3058:{f.Push(f.Locals[0]);f.Pc=3059;continue;}
case 3059:{return rt.Call(f,"forge/game/card/Card","getReplacementEffectForStaticAbilityByText","(Lforge/game/replacement/ReplacementEffect;Lforge/game/staticability/StaticAbility;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",3062);}
case 3062:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",3067);}
case 3067:{f.StackOp("pop");f.Pc=3068;continue;}
case 3068:{f.Pc=3030;continue;}
case 3071:{f.Push(f.Locals[45]);f.Pc=3073;continue;}
case 3073:{return rt.Call(f,"forge/game/card/CardState","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",3076);}
case 3076:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",3081);}
case 3081:{f.Locals[51]=f.Pop();f.Pc=3083;continue;}
case 3083:{f.Push(f.Locals[51]);f.Pc=3085;continue;}
case 3085:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3090);}
case 3090:{f.Pc=f.Pop().Int==0?3124:3093;continue;}
case 3093:{f.Push(f.Locals[51]);f.Pc=3095;continue;}
case 3095:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3100);}
case 3100:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3103;continue;}
case 3103:{f.Locals[52]=f.Pop();f.Pc=3105;continue;}
case 3105:{f.Push(f.Locals[49]);f.Pc=3107;continue;}
case 3107:{f.Push(f.Locals[42]);f.Pc=3109;continue;}
case 3109:{f.Push(f.Locals[52]);f.Pc=3111;continue;}
case 3111:{f.Push(f.Locals[0]);f.Pc=3112;continue;}
case 3112:{return rt.Call(f,"forge/game/card/Card","getStaticAbilityForStaticAbilityByText","(Lforge/game/staticability/StaticAbility;Lforge/game/staticability/StaticAbility;)Lforge/game/staticability/StaticAbility;","invokevirtual",3115);}
case 3115:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",3120);}
case 3120:{f.StackOp("pop");f.Pc=3121;continue;}
case 3121:{f.Pc=3083;continue;}
case 3124:{f.Push(JValue.L(1));f.Pc=3125;continue;}
case 3125:{f.Locals[51]=f.Pop();f.Pc=3127;continue;}
case 3127:{f.Push(f.Locals[45]);f.Pc=3129;continue;}
case 3129:{return rt.Call(f,"forge/game/card/CardState","getIntrinsicKeywords","()Ljava/util/Collection;","invokevirtual",3132);}
case 3132:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",3137);}
case 3137:{f.Locals[53]=f.Pop();f.Pc=3139;continue;}
case 3139:{f.Push(f.Locals[53]);f.Pc=3141;continue;}
case 3141:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3146);}
case 3146:{f.Pc=f.Pop().Int==0?3188:3149;continue;}
case 3149:{f.Push(f.Locals[53]);f.Pc=3151;continue;}
case 3151:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3156);}
case 3156:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3159;continue;}
case 3159:{f.Locals[54]=f.Pop();f.Pc=3161;continue;}
case 3161:{f.Push(f.Locals[50]);f.Pc=3163;continue;}
case 3163:{f.Push(f.Locals[42]);f.Pc=3165;continue;}
case 3165:{f.Push(f.Locals[54]);f.Pc=3167;continue;}
case 3167:{f.Push(f.Locals[0]);f.Pc=3168;continue;}
case 3168:{f.Push(f.Locals[51]);f.Pc=3170;continue;}
case 3170:{return rt.Call(f,"forge/game/card/Card","getKeywordForStaticAbilityByText","(Lforge/game/keyword/KeywordInterface;Lforge/game/staticability/StaticAbility;J)Lforge/game/keyword/KeywordInterface;","invokevirtual",3173);}
case 3173:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",3178);}
case 3178:{f.StackOp("pop");f.Pc=3179;continue;}
case 3179:{f.Push(f.Locals[51]);f.Pc=3181;continue;}
case 3181:{f.Push(JValue.L(1));f.Pc=3182;continue;}
case 3182:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=3183;continue;}
case 3183:{f.Locals[51]=f.Pop();f.Pc=3185;continue;}
case 3185:{f.Pc=3139;continue;}
case 3188:{f.Push(f.Locals[42]);f.Pc=3190;continue;}
case 3190:{f.Push(f.Locals[45]);f.Pc=3192;continue;}
case 3192:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",3195);}
case 3195:{f.Push(JValue.I(0));f.Pc=3196;continue;}
case 3196:{f.Push(f.Locals[8]);f.Pc=3198;continue;}
case 3198:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3201);}
case 3201:{f.Push(f.Locals[0]);f.Pc=3202;continue;}
case 3202:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",3205);}
case 3205:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=3206;continue;}
case 3206:{return rt.Call(f,"forge/game/card/Card","addChangedName","(Ljava/lang/String;ZJJ)V","invokevirtual",3209);}
case 3209:{f.Push(f.Locals[42]);f.Pc=3211;continue;}
case 3211:{f.Push(f.Locals[45]);f.Pc=3213;continue;}
case 3213:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",3216);}
case 3216:{f.Push(JValue.I(0));f.Pc=3217;continue;}
case 3217:{f.Push(f.Locals[8]);f.Pc=3219;continue;}
case 3219:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3222);}
case 3222:{f.Push(f.Locals[0]);f.Pc=3223;continue;}
case 3223:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",3226);}
case 3226:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=3227;continue;}
case 3227:{return rt.Call(f,"forge/game/card/Card","addChangedManaCost","(Lforge/card/mana/ManaCost;ZJJ)V","invokevirtual",3230);}
case 3230:{f.Push(f.Locals[42]);f.Pc=3232;continue;}
case 3232:{f.Push(f.Locals[45]);f.Pc=3234;continue;}
case 3234:{return rt.Call(f,"forge/game/card/CardState","getColor","()Lforge/card/ColorSet;","invokevirtual",3237);}
case 3237:{f.Push(JValue.I(0));f.Pc=3238;continue;}
case 3238:{f.Push(f.Locals[8]);f.Pc=3240;continue;}
case 3240:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3243);}
case 3243:{f.Push(f.Locals[0]);f.Pc=3244;continue;}
case 3244:{return rt.Call(f,"forge/game/card/Card","addColorByText","(Lforge/card/ColorSet;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",3247);}
case 3247:{f.Push(f.Locals[42]);f.Pc=3249;continue;}
case 3249:{f.Push(f.Locals[45]);f.Pc=3251;continue;}
case 3251:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",3254);}
case 3254:{f.Push(f.Locals[8]);f.Pc=3256;continue;}
case 3256:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3259);}
case 3259:{f.Push(f.Locals[0]);f.Pc=3260;continue;}
case 3260:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",3263);}
case 3263:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=3264;continue;}
case 3264:{return rt.Call(f,"forge/game/card/Card","addChangedCardTypesByText","(Lforge/card/CardTypeView;JJ)V","invokevirtual",3267);}
case 3267:{f.Push(f.Locals[42]);f.Pc=3269;continue;}
case 3269:{f.Push(f.Locals[46]);f.Pc=3271;continue;}
case 3271:{f.Push(f.Locals[47]);f.Pc=3273;continue;}
case 3273:{f.Push(f.Locals[48]);f.Pc=3275;continue;}
case 3275:{f.Push(f.Locals[49]);f.Pc=3277;continue;}
case 3277:{f.Push(f.Locals[8]);f.Pc=3279;continue;}
case 3279:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3282);}
case 3282:{f.Push(f.Locals[0]);f.Pc=3283;continue;}
case 3283:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",3286);}
case 3286:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=3287;continue;}
case 3287:{return rt.Call(f,"forge/game/card/Card","addChangedCardTraitsByText","(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;JJ)V","invokevirtual",3290);}
case 3290:{f.Push(f.Locals[42]);f.Pc=3292;continue;}
case 3292:{f.Push(f.Locals[50]);f.Pc=3294;continue;}
case 3294:{f.Push(f.Locals[8]);f.Pc=3296;continue;}
case 3296:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3299);}
case 3299:{f.Push(f.Locals[0]);f.Pc=3300;continue;}
case 3300:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",3303);}
case 3303:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=3304;continue;}
case 3304:{f.Push(JValue.I(0));f.Pc=3305;continue;}
case 3305:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywordsByText","(Ljava/util/List;JJZ)V","invokevirtual",3308);}
case 3308:{f.Push(f.Locals[42]);f.Pc=3310;continue;}
case 3310:{f.Push(f.Locals[45]);f.Pc=3312;continue;}
case 3312:{return rt.Call(f,"forge/game/card/CardState","getBasePower","()I","invokevirtual",3315);}
case 3315:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",3318);}
case 3318:{f.Push(f.Locals[45]);f.Pc=3320;continue;}
case 3320:{return rt.Call(f,"forge/game/card/CardState","getBaseToughness","()I","invokevirtual",3323);}
case 3323:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",3326);}
case 3326:{f.Push(f.Locals[8]);f.Pc=3328;continue;}
case 3328:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3331);}
case 3331:{f.Push(f.Locals[0]);f.Pc=3332;continue;}
case 3332:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",3335);}
case 3335:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=3336;continue;}
case 3336:{return rt.Call(f,"forge/game/card/Card","addNewPTByText","(Ljava/lang/Integer;Ljava/lang/Integer;JJ)V","invokevirtual",3339);}
case 3339:{f.Push(f.Locals[0]);f.Pc=3340;continue;}
case 3340:{f.Push(JValue.R(rt.String("Incorporate")));f.Pc=3343;continue;}
case 3343:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3346);}
case 3346:{f.Pc=f.Pop().Int==0?3403:3349;continue;}
case 3349:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=3352;continue;}
case 3352:{f.StackOp("dup");f.Pc=3353;continue;}
case 3353:{f.Push(f.Locals[0]);f.Pc=3354;continue;}
case 3354:{f.Push(JValue.R(rt.String("Incorporate")));f.Pc=3357;continue;}
case 3357:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3360);}
case 3360:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",3363);}
case 3363:{f.Locals[43]=f.Pop();f.Pc=3365;continue;}
case 3365:{f.Push(f.Locals[42]);f.Pc=3367;continue;}
case 3367:{f.Push(f.Locals[43]);f.Pc=3369;continue;}
case 3369:{f.Push(JValue.I(1));f.Pc=3370;continue;}
case 3370:{f.Push(f.Locals[8]);f.Pc=3372;continue;}
case 3372:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3375);}
case 3375:{f.Push(f.Locals[0]);f.Pc=3376;continue;}
case 3376:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",3379);}
case 3379:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=3380;continue;}
case 3380:{return rt.Call(f,"forge/game/card/Card","addChangedManaCost","(Lforge/card/mana/ManaCost;ZJJ)V","invokevirtual",3383);}
case 3383:{f.Push(f.Locals[42]);f.Pc=3385;continue;}
case 3385:{f.Push(f.Locals[43]);f.Pc=3387;continue;}
case 3387:{return rt.Call(f,"forge/card/mana/ManaCost","getColorProfile","()B","invokevirtual",3390);}
case 3390:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",3393);}
case 3393:{f.Push(JValue.I(1));f.Pc=3394;continue;}
case 3394:{f.Push(f.Locals[8]);f.Pc=3396;continue;}
case 3396:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3399);}
case 3399:{f.Push(f.Locals[0]);f.Pc=3400;continue;}
case 3400:{return rt.Call(f,"forge/game/card/Card","addColorByText","(Lforge/card/ColorSet;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",3403);}
case 3403:{f.Push(f.Locals[0]);f.Pc=3404;continue;}
case 3404:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=3407;continue;}
case 3407:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3410);}
case 3410:{f.Pc=f.Pop().Int==0?3447:3413;continue;}
case 3413:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=3416;continue;}
case 3416:{f.StackOp("dup");f.Pc=3417;continue;}
case 3417:{f.Push(f.Locals[0]);f.Pc=3418;continue;}
case 3418:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=3421;continue;}
case 3421:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3424);}
case 3424:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",3427);}
case 3427:{f.Locals[43]=f.Pop();f.Pc=3429;continue;}
case 3429:{f.Push(f.Locals[42]);f.Pc=3431;continue;}
case 3431:{f.Push(f.Locals[43]);f.Pc=3433;continue;}
case 3433:{f.Push(JValue.I(0));f.Pc=3434;continue;}
case 3434:{f.Push(f.Locals[8]);f.Pc=3436;continue;}
case 3436:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3439);}
case 3439:{f.Push(f.Locals[0]);f.Pc=3440;continue;}
case 3440:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",3443);}
case 3443:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=3444;continue;}
case 3444:{return rt.Call(f,"forge/game/card/Card","addChangedManaCost","(Lforge/card/mana/ManaCost;ZJJ)V","invokevirtual",3447);}
case 3447:{f.Push(f.Locals[0]);f.Pc=3448;continue;}
case 3448:{f.Push(JValue.R(rt.String("AddNames")));f.Pc=3451;continue;}
case 3451:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3454);}
case 3454:{f.Pc=f.Pop().Int==0?3474:3457;continue;}
case 3457:{f.Push(f.Locals[42]);f.Pc=3459;continue;}
case 3459:{f.Push(JValue.R(null));f.Pc=3460;continue;}
case 3460:{f.Push(JValue.I(1));f.Pc=3461;continue;}
case 3461:{f.Push(f.Locals[8]);f.Pc=3463;continue;}
case 3463:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3466);}
case 3466:{f.Push(f.Locals[0]);f.Pc=3467;continue;}
case 3467:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",3470);}
case 3470:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=3471;continue;}
case 3471:{return rt.Call(f,"forge/game/card/Card","addChangedName","(Ljava/lang/String;ZJJ)V","invokevirtual",3474);}
case 3474:{f.Push(f.Locals[0]);f.Pc=3475;continue;}
case 3475:{f.Push(JValue.R(rt.String("SetName")));f.Pc=3478;continue;}
case 3478:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3481);}
case 3481:{f.Pc=f.Pop().Int==0?3537:3484;continue;}
case 3484:{f.Push(f.Locals[0]);f.Pc=3485;continue;}
case 3485:{f.Push(JValue.R(rt.String("SetName")));f.Pc=3488;continue;}
case 3488:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3491);}
case 3491:{f.Locals[43]=f.Pop();f.Pc=3493;continue;}
case 3493:{f.Push(f.Locals[43]);f.Pc=3495;continue;}
case 3495:{f.Push(JValue.R(rt.String("ChosenName")));f.Pc=3498;continue;}
case 3498:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3501);}
case 3501:{f.Pc=f.Pop().Int==0?3511:3504;continue;}
case 3504:{f.Push(f.Locals[4]);f.Pc=3506;continue;}
case 3506:{return rt.Call(f,"forge/game/card/Card","getNamedCard","()Ljava/lang/String;","invokevirtual",3509);}
case 3509:{f.Locals[43]=f.Pop();f.Pc=3511;continue;}
case 3511:{f.Push(f.Locals[43]);f.Pc=3513;continue;}
case 3513:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",3516);}
case 3516:{f.Pc=f.Pop().Int!=0?3537:3519;continue;}
case 3519:{f.Push(f.Locals[42]);f.Pc=3521;continue;}
case 3521:{f.Push(f.Locals[43]);f.Pc=3523;continue;}
case 3523:{f.Push(JValue.I(0));f.Pc=3524;continue;}
case 3524:{f.Push(f.Locals[8]);f.Pc=3526;continue;}
case 3526:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3529);}
case 3529:{f.Push(f.Locals[0]);f.Pc=3530;continue;}
case 3530:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",3533);}
case 3533:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=3534;continue;}
case 3534:{return rt.Call(f,"forge/game/card/Card","addChangedName","(Ljava/lang/String;ZJJ)V","invokevirtual",3537);}
case 3537:{f.Push(f.Locals[3]);f.Pc=3538;continue;}
case 3538:{f.Push(JValue.R(rt.String("ChangeColorWordsTo")));f.Pc=3541;continue;}
case 3541:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",3546);}
case 3546:{f.Pc=f.Pop().Int==0?3657:3549;continue;}
case 3549:{f.Push(f.Locals[3]);f.Pc=3550;continue;}
case 3550:{f.Push(JValue.R(rt.String("ChangeColorWordsTo")));f.Pc=3553;continue;}
case 3553:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3558);}
case 3558:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3561;continue;}
case 3561:{f.Locals[44]=f.Pop();f.Pc=3563;continue;}
case 3563:{f.Push(f.Locals[44]);f.Pc=3565;continue;}
case 3565:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=3568;continue;}
case 3568:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3571);}
case 3571:{f.Pc=f.Pop().Int==0?3608:3574;continue;}
case 3574:{f.Push(f.Locals[4]);f.Pc=3576;continue;}
case 3576:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",3579);}
case 3579:{f.Pc=f.Pop().Int==0?3602:3582;continue;}
case 3582:{f.Push(f.Locals[4]);f.Pc=3584;continue;}
case 3584:{return rt.Call(f,"forge/game/card/Card","getChosenColors","()Ljava/lang/Iterable;","invokevirtual",3587);}
case 3587:{f.Push(JValue.R(null));f.Pc=3588;continue;}
case 3588:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",3591);}
case 3591:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3594;continue;}
case 3594:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",3597);}
case 3597:{f.Locals[43]=f.Pop();f.Pc=3599;continue;}
case 3599:{f.Pc=3615;continue;}
case 3602:{f.Push(JValue.I(0));f.Pc=3603;continue;}
case 3603:{f.Locals[43]=f.Pop();f.Pc=3605;continue;}
case 3605:{f.Pc=3615;continue;}
case 3608:{f.Push(f.Locals[44]);f.Pc=3610;continue;}
case 3610:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",3613);}
case 3613:{f.Locals[43]=f.Pop();f.Pc=3615;continue;}
case 3615:{f.Push(f.Locals[43]);f.Pc=3617;continue;}
case 3617:{f.Pc=f.Pop().Int==0?3657:3620;continue;}
case 3620:{f.Push(f.Locals[43]);f.Pc=3622;continue;}
case 3622:{return rt.Call(f,"forge/card/MagicColor","toLongString","(B)Ljava/lang/String;","invokestatic",3625);}
case 3625:{f.Locals[45]=f.Pop();f.Pc=3627;continue;}
case 3627:{f.Push(f.Locals[42]);f.Pc=3629;continue;}
case 3629:{f.Push(f.Locals[0]);f.Pc=3630;continue;}
case 3630:{f.Push(JValue.R(rt.String("ChangeColorWordsFrom")));f.Pc=3633;continue;}
case 3633:{f.Push(JValue.R(rt.String("Any")));f.Pc=3636;continue;}
case 3636:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3639);}
case 3639:{f.Push(f.Locals[45]);f.Pc=3641;continue;}
case 3641:{f.Push(f.Locals[8]);f.Pc=3643;continue;}
case 3643:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3646);}
case 3646:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",3649);}
case 3649:{f.Push(f.Locals[0]);f.Pc=3650;continue;}
case 3650:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",3653);}
case 3653:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=3654;continue;}
case 3654:{return rt.Call(f,"forge/game/card/Card","addChangedTextColorWord","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;J)V","invokevirtual",3657);}
case 3657:{f.Push(f.Locals[2]);f.Pc=3658;continue;}
case 3658:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=3661;continue;}
case 3661:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?3671:3664;continue;}
case 3664:{f.Push(f.Locals[2]);f.Pc=3665;continue;}
case 3665:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=3668;continue;}
case 3668:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?3761:3671;continue;}
case 3671:{f.Push(f.Locals[14]);f.Pc=3673;continue;}
case 3673:{f.Pc=f.Pop().Reference!=null?3681:3676;continue;}
case 3676:{f.Push(f.Locals[16]);f.Pc=3678;continue;}
case 3678:{f.Pc=f.Pop().Reference==null?3761:3681;continue;}
case 3681:{f.Push(f.Locals[13]);f.Pc=3683;continue;}
case 3683:{f.Push(JValue.R(rt.String("Affected")));f.Pc=3685;continue;}
case 3685:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",3688);}
case 3688:{f.Pc=f.Pop().Int==0?3705:3691;continue;}
case 3691:{f.Push(f.Locals[42]);f.Pc=3693;continue;}
case 3693:{f.Push(f.Locals[13]);f.Pc=3695;continue;}
case 3695:{f.Push(f.Locals[0]);f.Pc=3696;continue;}
case 3696:{f.Push(JValue.I(1));f.Pc=3697;continue;}
case 3697:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",3700);}
case 3700:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",3703);}
case 3703:{f.Locals[14]=f.Pop();f.Pc=3705;continue;}
case 3705:{f.Push(f.Locals[15]);f.Pc=3707;continue;}
case 3707:{f.Push(JValue.R(rt.String("Affected")));f.Pc=3709;continue;}
case 3709:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",3712);}
case 3712:{f.Pc=f.Pop().Int==0?3729:3715;continue;}
case 3715:{f.Push(f.Locals[42]);f.Pc=3717;continue;}
case 3717:{f.Push(f.Locals[15]);f.Pc=3719;continue;}
case 3719:{f.Push(f.Locals[0]);f.Pc=3720;continue;}
case 3720:{f.Push(JValue.I(1));f.Pc=3721;continue;}
case 3721:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",3724);}
case 3724:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",3727);}
case 3727:{f.Locals[16]=f.Pop();f.Pc=3729;continue;}
case 3729:{f.Push(f.Locals[42]);f.Pc=3731;continue;}
case 3731:{f.Push(f.Locals[14]);f.Pc=3733;continue;}
case 3733:{f.Push(f.Locals[16]);f.Pc=3735;continue;}
case 3735:{f.Push(f.Locals[8]);f.Pc=3737;continue;}
case 3737:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3740);}
case 3740:{f.Push(f.Locals[0]);f.Pc=3741;continue;}
case 3741:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",3744);}
case 3744:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=3745;continue;}
case 3745:{f.Push(f.Locals[2]);f.Pc=3746;continue;}
case 3746:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=3749;continue;}
case 3749:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?3756:3752;continue;}
case 3752:{f.Push(JValue.I(1));f.Pc=3753;continue;}
case 3753:{f.Pc=3757;continue;}
case 3756:{f.Push(JValue.I(0));f.Pc=3757;continue;}
case 3757:{f.Push(JValue.I(0));f.Pc=3758;continue;}
case 3758:{return rt.Call(f,"forge/game/card/Card","addNewPT","(Ljava/lang/Integer;Ljava/lang/Integer;JJZZ)V","invokevirtual",3761);}
case 3761:{f.Push(f.Locals[2]);f.Pc=3762;continue;}
case 3762:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=3765;continue;}
case 3765:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?3829:3768;continue;}
case 3768:{f.Push(f.Locals[9]);f.Pc=3770;continue;}
case 3770:{f.Push(JValue.R(rt.String("Affected")));f.Pc=3772;continue;}
case 3772:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",3775);}
case 3775:{f.Pc=f.Pop().Int==0?3789:3778;continue;}
case 3778:{f.Push(f.Locals[42]);f.Pc=3780;continue;}
case 3780:{f.Push(f.Locals[9]);f.Pc=3782;continue;}
case 3782:{f.Push(f.Locals[0]);f.Pc=3783;continue;}
case 3783:{f.Push(JValue.I(1));f.Pc=3784;continue;}
case 3784:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",3787);}
case 3787:{f.Locals[10]=f.Pop();f.Pc=3789;continue;}
case 3789:{f.Push(f.Locals[11]);f.Pc=3791;continue;}
case 3791:{f.Push(JValue.R(rt.String("Affected")));f.Pc=3793;continue;}
case 3793:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",3796);}
case 3796:{f.Pc=f.Pop().Int==0?3810:3799;continue;}
case 3799:{f.Push(f.Locals[42]);f.Pc=3801;continue;}
case 3801:{f.Push(f.Locals[11]);f.Pc=3803;continue;}
case 3803:{f.Push(f.Locals[0]);f.Pc=3804;continue;}
case 3804:{f.Push(JValue.I(1));f.Pc=3805;continue;}
case 3805:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",3808);}
case 3808:{f.Locals[12]=f.Pop();f.Pc=3810;continue;}
case 3810:{f.Push(f.Locals[42]);f.Pc=3812;continue;}
case 3812:{f.Push(f.Locals[10]);f.Pc=3814;continue;}
case 3814:{f.Push(f.Locals[12]);f.Pc=3816;continue;}
case 3816:{f.Push(f.Locals[8]);f.Pc=3818;continue;}
case 3818:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",3821);}
case 3821:{f.Push(f.Locals[0]);f.Pc=3822;continue;}
case 3822:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",3825);}
case 3825:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=3826;continue;}
case 3826:{return rt.Call(f,"forge/game/card/Card","addPTBoost","(IIJJ)V","invokevirtual",3829);}
case 3829:{f.Push(f.Locals[17]);f.Pc=3831;continue;}
case 3831:{f.Pc=f.Pop().Reference==null?3844:3834;continue;}
case 3834:{f.Push(f.Locals[17]);f.Pc=3836;continue;}
case 3836:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",3841);}
case 3841:{f.Pc=f.Pop().Int==0?3854:3844;continue;}
case 3844:{f.Push(f.Locals[20]);f.Pc=3846;continue;}
case 3846:{f.Pc=f.Pop().Reference!=null?3854:3849;continue;}
case 3849:{f.Push(f.Locals[29]);f.Pc=3851;continue;}
case 3851:{f.Pc=f.Pop().Reference==null?4022:3854;continue;}
case 3854:{f.Push(JValue.R(null));f.Pc=3855;continue;}
case 3855:{f.Locals[43]=f.Pop();f.Pc=3857;continue;}
case 3857:{f.Push(f.Locals[17]);f.Pc=3859;continue;}
case 3859:{f.Pc=f.Pop().Reference==null?3933:3862;continue;}
case 3862:{f.Push(f.Locals[17]);f.Pc=3864;continue;}
case 3864:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",3867);}
case 3867:{f.Locals[43]=f.Pop();f.Pc=3869;continue;}
case 3869:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3872);}
case 3872:{f.Locals[44]=f.Pop();f.Pc=3874;continue;}
case 3874:{f.Push(f.Locals[43]);f.Pc=3876;continue;}
case 3876:{f.Push(f.Locals[42]);f.Pc=3878;continue;}
case 3878:{f.Push(f.Locals[44]);f.Pc=3880;continue;}
case 3880:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityContinuous:9985:3880:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Ljava/util/List;)Ljava/util/function/Predicate;",3885);}
case 3885:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",3890);}
case 3890:{f.StackOp("pop");f.Pc=3891;continue;}
case 3891:{f.Push(f.Locals[43]);f.Pc=3893;continue;}
case 3893:{f.Push(f.Locals[44]);f.Pc=3895;continue;}
case 3895:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",3900);}
case 3900:{f.StackOp("pop");f.Pc=3901;continue;}
case 3901:{f.Push(f.Locals[43]);f.Pc=3903;continue;}
case 3903:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",3908);}
case 3908:{f.Push(f.Locals[42]);f.Pc=3910;continue;}
case 3910:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityContinuous:9985:3910:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Function;",3915);}
case 3915:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",3920);}
case 3920:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",3923);}
case 3923:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",3928);}
case 3928:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3931;continue;}
case 3931:{f.Locals[43]=f.Pop();f.Pc=3933;continue;}
case 3933:{f.Push(f.Locals[43]);f.Pc=3935;continue;}
case 3935:{f.Pc=f.Pop().Reference==null?3991:3938;continue;}
case 3938:{f.Push(f.Locals[43]);f.Pc=3940;continue;}
case 3940:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",3945);}
case 3945:{f.Pc=f.Pop().Int!=0?3991:3948;continue;}
case 3948:{f.Push(f.Locals[3]);f.Pc=3949;continue;}
case 3949:{f.Push(JValue.R(rt.String("KeywordMultiplier")));f.Pc=3952;continue;}
case 3952:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",3957);}
case 3957:{f.Pc=f.Pop().Int==0?3991:3960;continue;}
case 3960:{f.Push(f.Locals[43]);f.Pc=3962;continue;}
case 3962:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",3967);}
case 3967:{f.Push(f.Locals[3]);f.Pc=3968;continue;}
case 3968:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityContinuous:9985:3968:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Map;)Ljava/util/function/Function;",3973);}
case 3973:{return rt.Call(f,"java/util/stream/Stream","flatMap","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",3978);}
case 3978:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",3981);}
case 3981:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",3986);}
case 3986:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3989;continue;}
case 3989:{f.Locals[43]=f.Pop();f.Pc=3991;continue;}
case 3991:{f.Push(f.Locals[42]);f.Pc=3993;continue;}
case 3993:{f.Push(f.Locals[43]);f.Pc=3995;continue;}
case 3995:{f.Push(f.Locals[20]);f.Pc=3997;continue;}
case 3997:{f.Push(f.Locals[29]);f.Pc=3999;continue;}
case 3999:{f.Pc=f.Pop().Reference==null?4006:4002;continue;}
case 4002:{f.Push(JValue.I(1));f.Pc=4003;continue;}
case 4003:{f.Pc=4007;continue;}
case 4006:{f.Push(JValue.I(0));f.Pc=4007;continue;}
case 4007:{f.Push(f.Locals[8]);f.Pc=4009;continue;}
case 4009:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",4012);}
case 4012:{f.Push(f.Locals[0]);f.Pc=4013;continue;}
case 4013:{f.Push(JValue.I(0));f.Pc=4014;continue;}
case 4014:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;Z)V","invokevirtual",4017);}
case 4017:{f.Push(f.Locals[42]);f.Pc=4019;continue;}
case 4019:{return rt.Call(f,"forge/game/card/Card","updateKeywordsCache","()V","invokevirtual",4022);}
case 4022:{f.Push(f.Locals[19]);f.Pc=4024;continue;}
case 4024:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",4029);}
case 4029:{f.Pc=f.Pop().Int!=0?4049:4032;continue;}
case 4032:{f.Push(f.Locals[42]);f.Pc=4034;continue;}
case 4034:{f.Push(f.Locals[8]);f.Pc=4036;continue;}
case 4036:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",4039);}
case 4039:{f.Push(f.Locals[0]);f.Pc=4040;continue;}
case 4040:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",4043);}
case 4043:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=4044;continue;}
case 4044:{f.Push(f.Locals[19]);f.Pc=4046;continue;}
case 4046:{return rt.Call(f,"forge/game/card/Card","addHiddenExtrinsicKeywords","(JJLjava/lang/Iterable;)V","invokevirtual",4049);}
case 4049:{f.Push(f.Locals[23]);f.Pc=4051;continue;}
case 4051:{f.Pc=f.Pop().Reference==null?4179:4054;continue;}
case 4054:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",4057);}
case 4057:{f.Locals[43]=f.Pop();f.Pc=4059;continue;}
case 4059:{f.Push(f.Locals[23]);f.Pc=4061;continue;}
case 4061:{f.Locals[44]=f.Pop();f.Pc=4063;continue;}
case 4063:{f.Push(f.Locals[44]);f.Pc=4065;continue;}
case 4065:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4066;continue;}
case 4066:{f.Locals[45]=f.Pop();f.Pc=4068;continue;}
case 4068:{f.Push(JValue.I(0));f.Pc=4069;continue;}
case 4069:{f.Locals[46]=f.Pop();f.Pc=4071;continue;}
case 4071:{f.Push(f.Locals[46]);f.Pc=4073;continue;}
case 4073:{f.Push(f.Locals[45]);f.Pc=4075;continue;}
case 4075:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?4162:4078;continue;}
case 4078:{f.Push(f.Locals[44]);f.Pc=4080;continue;}
case 4080:{f.Push(f.Locals[46]);f.Pc=4082;continue;}
case 4082:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4083;continue;}
case 4083:{f.Locals[47]=f.Pop();f.Pc=4085;continue;}
case 4085:{f.Push(f.Locals[0]);f.Pc=4086;continue;}
case 4086:{f.Push(f.Locals[47]);f.Pc=4088;continue;}
case 4088:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",4091);}
case 4091:{f.Locals[48]=f.Pop();f.Pc=4093;continue;}
case 4093:{f.Push(f.Locals[47]);f.Pc=4095;continue;}
case 4095:{f.Locals[49]=f.Pop();f.Pc=4097;continue;}
case 4097:{f.Push(f.Locals[48]);f.Pc=4099;continue;}
case 4099:{f.Push(JValue.R(rt.String("SVar:")));f.Pc=4102;continue;}
case 4102:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4105);}
case 4105:{f.Pc=f.Pop().Int==0?4144:4108;continue;}
case 4108:{f.Push(f.Locals[48]);f.Pc=4110;continue;}
case 4110:{f.Push(JValue.R(rt.String("SVar:")));f.Pc=4113;continue;}
case 4113:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4116);}
case 4116:{f.Push(JValue.I(1));f.Pc=4117;continue;}
case 4117:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4118;continue;}
case 4118:{f.Locals[48]=f.Pop();f.Pc=4120;continue;}
case 4120:{f.Push(f.Locals[48]);f.Pc=4122;continue;}
case 4122:{f.Push(JValue.R(rt.String(":")));f.Pc=4125;continue;}
case 4125:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4128);}
case 4128:{f.Push(JValue.I(0));f.Pc=4129;continue;}
case 4129:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4130;continue;}
case 4130:{f.Locals[49]=f.Pop();f.Pc=4132;continue;}
case 4132:{f.Push(f.Locals[48]);f.Pc=4134;continue;}
case 4134:{f.Push(JValue.R(rt.String(":")));f.Pc=4137;continue;}
case 4137:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4140);}
case 4140:{f.Push(JValue.I(1));f.Pc=4141;continue;}
case 4141:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4142;continue;}
case 4142:{f.Locals[48]=f.Pop();f.Pc=4144;continue;}
case 4144:{f.Push(f.Locals[43]);f.Pc=4146;continue;}
case 4146:{f.Push(f.Locals[49]);f.Pc=4148;continue;}
case 4148:{f.Push(f.Locals[48]);f.Pc=4150;continue;}
case 4150:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",4155);}
case 4155:{f.StackOp("pop");f.Pc=4156;continue;}
case 4156:{f.Locals[46]=JValue.I(unchecked(f.Locals[46].Int+(1)));f.Pc=4159;continue;}
case 4159:{f.Pc=4071;continue;}
case 4162:{f.Push(f.Locals[42]);f.Pc=4164;continue;}
case 4164:{f.Push(f.Locals[43]);f.Pc=4166;continue;}
case 4166:{f.Push(f.Locals[8]);f.Pc=4168;continue;}
case 4168:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",4171);}
case 4171:{f.Push(f.Locals[0]);f.Pc=4172;continue;}
case 4172:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",4175);}
case 4175:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=4176;continue;}
case 4176:{return rt.Call(f,"forge/game/card/Card","addChangedSVars","(Ljava/util/Map;JJ)V","invokevirtual",4179);}
case 4179:{f.Push(f.Locals[2]);f.Pc=4180;continue;}
case 4180:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=4183;continue;}
case 4183:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?5083:4186;continue;}
case 4186:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",4189);}
case 4189:{f.Locals[43]=f.Pop();f.Pc=4191;continue;}
case 4191:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",4194);}
case 4194:{f.Locals[44]=f.Pop();f.Pc=4196;continue;}
case 4196:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",4199);}
case 4199:{f.Locals[45]=f.Pop();f.Pc=4201;continue;}
case 4201:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",4204);}
case 4204:{f.Locals[46]=f.Pop();f.Pc=4206;continue;}
case 4206:{f.Push(f.Locals[18]);f.Pc=4208;continue;}
case 4208:{f.Pc=f.Pop().Reference==null?4325:4211;continue;}
case 4211:{f.Push(f.Locals[18]);f.Pc=4213;continue;}
case 4213:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",4218);}
case 4218:{f.Locals[47]=f.Pop();f.Pc=4220;continue;}
case 4220:{f.Push(f.Locals[47]);f.Pc=4222;continue;}
case 4222:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",4227);}
case 4227:{f.Pc=f.Pop().Int==0?4325:4230;continue;}
case 4230:{f.Push(f.Locals[47]);f.Pc=4232;continue;}
case 4232:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",4237);}
case 4237:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/sticker/AppliedSticker"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4240;continue;}
case 4240:{f.Locals[48]=f.Pop();f.Pc=4242;continue;}
case 4242:{f.Push(f.Locals[48]);f.Pc=4244;continue;}
case 4244:{f.Push(f.Locals[42]);f.Pc=4246;continue;}
case 4246:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","getGrantedTraits","(Lforge/game/card/Card;)Lforge/game/card/CardTraitChanges;","invokevirtual",4249);}
case 4249:{f.Locals[49]=f.Pop();f.Pc=4251;continue;}
case 4251:{f.Push(f.Locals[43]);f.Pc=4253;continue;}
case 4253:{f.Push(f.Locals[49]);f.Pc=4255;continue;}
case 4255:{return rt.Call(f,"forge/game/card/CardTraitChanges","getAbilities","()Ljava/util/Collection;","invokevirtual",4258);}
case 4258:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",4263);}
case 4263:{f.StackOp("pop");f.Pc=4264;continue;}
case 4264:{f.Push(f.Locals[45]);f.Pc=4266;continue;}
case 4266:{f.Push(f.Locals[49]);f.Pc=4268;continue;}
case 4268:{return rt.Call(f,"forge/game/card/CardTraitChanges","getTriggers","()Ljava/util/Collection;","invokevirtual",4271);}
case 4271:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",4276);}
case 4276:{f.StackOp("pop");f.Pc=4277;continue;}
case 4277:{f.Push(f.Locals[46]);f.Pc=4279;continue;}
case 4279:{f.Push(f.Locals[49]);f.Pc=4281;continue;}
case 4281:{return rt.Call(f,"forge/game/card/CardTraitChanges","getStaticAbilities","()Ljava/util/Collection;","invokevirtual",4284);}
case 4284:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",4289);}
case 4289:{f.StackOp("pop");f.Pc=4290;continue;}
case 4290:{f.Push(f.Locals[49]);f.Pc=4292;continue;}
case 4292:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","grantsAttackTrigger","(Lforge/game/card/CardTraitChanges;)Z","invokestatic",4295);}
case 4295:{f.Pc=f.Pop().Int==0?4322:4298;continue;}
case 4298:{f.Push(f.Locals[42]);f.Pc=4300;continue;}
case 4300:{f.Push(JValue.R(rt.String("HasAttackEffect")));f.Pc=4303;continue;}
case 4303:{f.Push(JValue.R(rt.String("TRUE")));f.Pc=4306;continue;}
case 4306:{return rt.Call(f,"java/util/Map","of","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;","invokestatic",4309);}
case 4309:{f.Push(f.Locals[8]);f.Pc=4311;continue;}
case 4311:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",4314);}
case 4314:{f.Push(f.Locals[0]);f.Pc=4315;continue;}
case 4315:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",4318);}
case 4318:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=4319;continue;}
case 4319:{return rt.Call(f,"forge/game/card/Card","addChangedSVars","(Ljava/util/Map;JJ)V","invokevirtual",4322);}
case 4322:{f.Pc=4220;continue;}
case 4325:{f.Push(f.Locals[21]);f.Pc=4327;continue;}
case 4327:{f.Pc=f.Pop().Reference==null?4443:4330;continue;}
case 4330:{f.Push(f.Locals[21]);f.Pc=4332;continue;}
case 4332:{f.Locals[47]=f.Pop();f.Pc=4334;continue;}
case 4334:{f.Push(f.Locals[47]);f.Pc=4336;continue;}
case 4336:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4337;continue;}
case 4337:{f.Locals[48]=f.Pop();f.Pc=4339;continue;}
case 4339:{f.Push(JValue.I(0));f.Pc=4340;continue;}
case 4340:{f.Locals[49]=f.Pop();f.Pc=4342;continue;}
case 4342:{f.Push(f.Locals[49]);f.Pc=4344;continue;}
case 4344:{f.Push(f.Locals[48]);f.Pc=4346;continue;}
case 4346:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?4443:4349;continue;}
case 4349:{f.Push(f.Locals[47]);f.Pc=4351;continue;}
case 4351:{f.Push(f.Locals[49]);f.Pc=4353;continue;}
case 4353:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4354;continue;}
case 4354:{f.Locals[50]=f.Pop();f.Pc=4356;continue;}
case 4356:{f.Push(f.Locals[50]);f.Pc=4358;continue;}
case 4358:{f.Push(JValue.R(rt.String("CardManaCost")));f.Pc=4361;continue;}
case 4361:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",4364);}
case 4364:{f.Pc=f.Pop().Int==0?4388:4367;continue;}
case 4367:{f.Push(f.Locals[50]);f.Pc=4369;continue;}
case 4369:{f.Push(JValue.R(rt.String("CardManaCost")));f.Pc=4372;continue;}
case 4372:{f.Push(f.Locals[42]);f.Pc=4374;continue;}
case 4374:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",4377);}
case 4377:{return rt.Call(f,"forge/card/mana/ManaCost","getShortString","()Ljava/lang/String;","invokevirtual",4380);}
case 4380:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",4383);}
case 4383:{f.Locals[50]=f.Pop();f.Pc=4385;continue;}
case 4385:{f.Pc=4421;continue;}
case 4388:{f.Push(f.Locals[50]);f.Pc=4390;continue;}
case 4390:{f.Push(JValue.R(rt.String("ConvertedManaCost")));f.Pc=4393;continue;}
case 4393:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",4396);}
case 4396:{f.Pc=f.Pop().Int==0?4421:4399;continue;}
case 4399:{f.Push(f.Locals[42]);f.Pc=4401;continue;}
case 4401:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",4404);}
case 4404:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",4407);}
case 4407:{f.Locals[51]=f.Pop();f.Pc=4409;continue;}
case 4409:{f.Push(f.Locals[50]);f.Pc=4411;continue;}
case 4411:{f.Push(JValue.R(rt.String("ConvertedManaCost")));f.Pc=4414;continue;}
case 4414:{f.Push(f.Locals[51]);f.Pc=4416;continue;}
case 4416:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",4419);}
case 4419:{f.Locals[50]=f.Pop();f.Pc=4421;continue;}
case 4421:{f.Push(f.Locals[43]);f.Pc=4423;continue;}
case 4423:{f.Push(f.Locals[42]);f.Pc=4425;continue;}
case 4425:{f.Push(f.Locals[50]);f.Pc=4427;continue;}
case 4427:{f.Push(f.Locals[0]);f.Pc=4428;continue;}
case 4428:{return rt.Call(f,"forge/game/card/Card","getSpellAbilityForStaticAbility","(Ljava/lang/String;Lforge/game/staticability/StaticAbility;)Lforge/game/spellability/SpellAbility;","invokevirtual",4431);}
case 4431:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",4436);}
case 4436:{f.StackOp("pop");f.Pc=4437;continue;}
case 4437:{f.Locals[49]=JValue.I(unchecked(f.Locals[49].Int+(1)));f.Pc=4440;continue;}
case 4440:{f.Pc=4342;continue;}
case 4443:{f.Push(f.Locals[3]);f.Pc=4444;continue;}
case 4444:{f.Push(JValue.R(rt.String("GainsAbilitiesOf")));f.Pc=4447;continue;}
case 4447:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",4452);}
case 4452:{f.Pc=f.Pop().Int!=0?4467:4455;continue;}
case 4455:{f.Push(f.Locals[3]);f.Pc=4456;continue;}
case 4456:{f.Push(JValue.R(rt.String("GainsAbilitiesOfDefined")));f.Pc=4459;continue;}
case 4459:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",4464);}
case 4464:{f.Pc=f.Pop().Int==0?4678:4467;continue;}
case 4467:{f.Push(f.Locals[3]);f.Pc=4468;continue;}
case 4468:{f.Push(JValue.R(rt.String("GainsAbilitiesOfDefined")));f.Pc=4471;continue;}
case 4471:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",4476);}
case 4476:{f.Pc=f.Pop().Int==0?4485:4479;continue;}
case 4479:{f.Push(JValue.R(rt.String("GainsAbilitiesOfDefined")));f.Pc=4482;continue;}
case 4482:{f.Pc=4488;continue;}
case 4485:{f.Push(JValue.R(rt.String("GainsAbilitiesOf")));f.Pc=4488;continue;}
case 4488:{f.Push(f.Locals[3]);f.Pc=4489;continue;}
case 4489:{f.Push(f.Locals[4]);f.Pc=4491;continue;}
case 4491:{f.Push(f.Locals[0]);f.Pc=4492;continue;}
case 4492:{f.Push(f.Locals[7]);f.Pc=4494;continue;}
case 4494:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous","cardsGainedFrom","(Ljava/lang/String;Ljava/util/Map;Lforge/game/card/Card;Lforge/game/staticability/StaticAbility;Lforge/game/Game;)Lforge/game/card/CardCollection;","invokestatic",4497);}
case 4497:{f.Locals[47]=f.Pop();f.Pc=4499;continue;}
case 4499:{f.Push(f.Locals[47]);f.Pc=4501;continue;}
case 4501:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",4504);}
case 4504:{f.Locals[48]=f.Pop();f.Pc=4506;continue;}
case 4506:{f.Push(f.Locals[48]);f.Pc=4508;continue;}
case 4508:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",4513);}
case 4513:{f.Pc=f.Pop().Int==0?4678:4516;continue;}
case 4516:{f.Push(f.Locals[48]);f.Pc=4518;continue;}
case 4518:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",4523);}
case 4523:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4526;continue;}
case 4526:{f.Locals[49]=f.Pop();f.Pc=4528;continue;}
case 4528:{f.Push(f.Locals[49]);f.Pc=4530;continue;}
case 4530:{return rt.Call(f,"forge/game/card/Card","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",4533);}
case 4533:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",4538);}
case 4538:{f.Locals[50]=f.Pop();f.Pc=4540;continue;}
case 4540:{f.Push(f.Locals[50]);f.Pc=4542;continue;}
case 4542:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",4547);}
case 4547:{f.Pc=f.Pop().Int==0?4675:4550;continue;}
case 4550:{f.Push(f.Locals[50]);f.Pc=4552;continue;}
case 4552:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",4557);}
case 4557:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4560;continue;}
case 4560:{f.Locals[51]=f.Pop();f.Pc=4562;continue;}
case 4562:{f.Push(f.Locals[51]);f.Pc=4564;continue;}
case 4564:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",4567);}
case 4567:{f.Pc=f.Pop().Int==0?4672:4570;continue;}
case 4570:{f.Push(f.Locals[0]);f.Pc=4571;continue;}
case 4571:{f.Push(JValue.R(rt.String("GainsValidAbilities")));f.Pc=4574;continue;}
case 4574:{f.Push(f.Locals[51]);f.Pc=4576;continue;}
case 4576:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",4579);}
case 4579:{f.Pc=f.Pop().Int!=0?4585:4582;continue;}
case 4582:{f.Pc=4540;continue;}
case 4585:{f.Push(f.Locals[51]);f.Pc=4587;continue;}
case 4587:{f.Push(f.Locals[42]);f.Pc=4589;continue;}
case 4589:{f.Push(f.Locals[51]);f.Pc=4591;continue;}
case 4591:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4594);}
case 4594:{f.Push(JValue.I(0));f.Pc=4595;continue;}
case 4595:{f.Push(JValue.I(1));f.Pc=4596;continue;}
case 4596:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;ZZ)Lforge/game/spellability/SpellAbility;","invokevirtual",4599);}
case 4599:{f.Locals[52]=f.Pop();f.Pc=4601;continue;}
case 4601:{f.Push(f.Locals[3]);f.Pc=4602;continue;}
case 4602:{f.Push(JValue.R(rt.String("GainsAbilitiesLimitPerTurn")));f.Pc=4605;continue;}
case 4605:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",4610);}
case 4610:{f.Pc=f.Pop().Int==0?4643:4613;continue;}
case 4613:{f.Push(f.Locals[52]);f.Pc=4615;continue;}
case 4615:{f.Push(f.Locals[51]);f.Pc=4617;continue;}
case 4617:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",4620);}
case 4620:{return rt.Call(f,"forge/game/spellability/SpellAbility","setRestrictions","(Lforge/game/spellability/SpellAbilityRestriction;)V","invokevirtual",4623);}
case 4623:{f.Push(f.Locals[52]);f.Pc=4625;continue;}
case 4625:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",4628);}
case 4628:{f.Push(f.Locals[3]);f.Pc=4629;continue;}
case 4629:{f.Push(JValue.R(rt.String("GainsAbilitiesLimitPerTurn")));f.Pc=4632;continue;}
case 4632:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",4637);}
case 4637:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4640;continue;}
case 4640:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setLimitToCheck","(Ljava/lang/String;)V","invokevirtual",4643);}
case 4643:{f.Push(f.Locals[52]);f.Pc=4645;continue;}
case 4645:{f.Push(f.Locals[51]);f.Pc=4647;continue;}
case 4647:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOriginalAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",4650);}
case 4650:{f.Push(f.Locals[52]);f.Pc=4652;continue;}
case 4652:{f.Push(f.Locals[0]);f.Pc=4653;continue;}
case 4653:{return rt.Call(f,"forge/game/spellability/SpellAbility","setGrantorStatic","(Lforge/game/staticability/StaticAbility;)V","invokevirtual",4656);}
case 4656:{f.Push(f.Locals[52]);f.Pc=4658;continue;}
case 4658:{f.Push(JValue.I(0));f.Pc=4659;continue;}
case 4659:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",4662);}
case 4662:{f.Push(f.Locals[43]);f.Pc=4664;continue;}
case 4664:{f.Push(f.Locals[52]);f.Pc=4666;continue;}
case 4666:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",4671);}
case 4671:{f.StackOp("pop");f.Pc=4672;continue;}
case 4672:{f.Pc=4540;continue;}
case 4675:{f.Pc=4506;continue;}
case 4678:{f.Push(f.Locals[22]);f.Pc=4680;continue;}
case 4680:{f.Pc=f.Pop().Reference==null?4731:4683;continue;}
case 4683:{f.Push(f.Locals[22]);f.Pc=4685;continue;}
case 4685:{f.Locals[47]=f.Pop();f.Pc=4687;continue;}
case 4687:{f.Push(f.Locals[47]);f.Pc=4689;continue;}
case 4689:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4690;continue;}
case 4690:{f.Locals[48]=f.Pop();f.Pc=4692;continue;}
case 4692:{f.Push(JValue.I(0));f.Pc=4693;continue;}
case 4693:{f.Locals[49]=f.Pop();f.Pc=4695;continue;}
case 4695:{f.Push(f.Locals[49]);f.Pc=4697;continue;}
case 4697:{f.Push(f.Locals[48]);f.Pc=4699;continue;}
case 4699:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?4731:4702;continue;}
case 4702:{f.Push(f.Locals[47]);f.Pc=4704;continue;}
case 4704:{f.Push(f.Locals[49]);f.Pc=4706;continue;}
case 4706:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4707;continue;}
case 4707:{f.Locals[50]=f.Pop();f.Pc=4709;continue;}
case 4709:{f.Push(f.Locals[44]);f.Pc=4711;continue;}
case 4711:{f.Push(f.Locals[42]);f.Pc=4713;continue;}
case 4713:{f.Push(f.Locals[50]);f.Pc=4715;continue;}
case 4715:{f.Push(f.Locals[0]);f.Pc=4716;continue;}
case 4716:{return rt.Call(f,"forge/game/card/Card","getReplacementEffectForStaticAbility","(Ljava/lang/String;Lforge/game/staticability/StaticAbility;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",4719);}
case 4719:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",4724);}
case 4724:{f.StackOp("pop");f.Pc=4725;continue;}
case 4725:{f.Locals[49]=JValue.I(unchecked(f.Locals[49].Int+(1)));f.Pc=4728;continue;}
case 4728:{f.Pc=4695;continue;}
case 4731:{f.Push(f.Locals[27]);f.Pc=4733;continue;}
case 4733:{f.Pc=f.Pop().Reference==null?4784:4736;continue;}
case 4736:{f.Push(f.Locals[27]);f.Pc=4738;continue;}
case 4738:{f.Locals[47]=f.Pop();f.Pc=4740;continue;}
case 4740:{f.Push(f.Locals[47]);f.Pc=4742;continue;}
case 4742:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4743;continue;}
case 4743:{f.Locals[48]=f.Pop();f.Pc=4745;continue;}
case 4745:{f.Push(JValue.I(0));f.Pc=4746;continue;}
case 4746:{f.Locals[49]=f.Pop();f.Pc=4748;continue;}
case 4748:{f.Push(f.Locals[49]);f.Pc=4750;continue;}
case 4750:{f.Push(f.Locals[48]);f.Pc=4752;continue;}
case 4752:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?4784:4755;continue;}
case 4755:{f.Push(f.Locals[47]);f.Pc=4757;continue;}
case 4757:{f.Push(f.Locals[49]);f.Pc=4759;continue;}
case 4759:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4760;continue;}
case 4760:{f.Locals[50]=f.Pop();f.Pc=4762;continue;}
case 4762:{f.Push(f.Locals[45]);f.Pc=4764;continue;}
case 4764:{f.Push(f.Locals[42]);f.Pc=4766;continue;}
case 4766:{f.Push(f.Locals[50]);f.Pc=4768;continue;}
case 4768:{f.Push(f.Locals[0]);f.Pc=4769;continue;}
case 4769:{return rt.Call(f,"forge/game/card/Card","getTriggerForStaticAbility","(Ljava/lang/String;Lforge/game/staticability/StaticAbility;)Lforge/game/trigger/Trigger;","invokevirtual",4772);}
case 4772:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",4777);}
case 4777:{f.StackOp("pop");f.Pc=4778;continue;}
case 4778:{f.Locals[49]=JValue.I(unchecked(f.Locals[49].Int+(1)));f.Pc=4781;continue;}
case 4781:{f.Pc=4748;continue;}
case 4784:{f.Push(f.Locals[3]);f.Pc=4785;continue;}
case 4785:{f.Push(JValue.R(rt.String("GainsTriggerAbsOf")));f.Pc=4788;continue;}
case 4788:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",4793);}
case 4793:{f.Pc=f.Pop().Int==0?4915:4796;continue;}
case 4796:{f.Push(JValue.R(rt.String("GainsTriggerAbsOf")));f.Pc=4799;continue;}
case 4799:{f.Push(f.Locals[3]);f.Pc=4800;continue;}
case 4800:{f.Push(f.Locals[4]);f.Pc=4802;continue;}
case 4802:{f.Push(f.Locals[0]);f.Pc=4803;continue;}
case 4803:{f.Push(f.Locals[7]);f.Pc=4805;continue;}
case 4805:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous","cardsGainedFrom","(Ljava/lang/String;Ljava/util/Map;Lforge/game/card/Card;Lforge/game/staticability/StaticAbility;Lforge/game/Game;)Lforge/game/card/CardCollection;","invokestatic",4808);}
case 4808:{f.Locals[47]=f.Pop();f.Pc=4810;continue;}
case 4810:{f.Push(f.Locals[47]);f.Pc=4812;continue;}
case 4812:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",4815);}
case 4815:{f.Locals[48]=f.Pop();f.Pc=4817;continue;}
case 4817:{f.Push(f.Locals[48]);f.Pc=4819;continue;}
case 4819:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",4824);}
case 4824:{f.Pc=f.Pop().Int==0?4915:4827;continue;}
case 4827:{f.Push(f.Locals[48]);f.Pc=4829;continue;}
case 4829:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",4834);}
case 4834:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4837;continue;}
case 4837:{f.Locals[49]=f.Pop();f.Pc=4839;continue;}
case 4839:{f.Push(f.Locals[49]);f.Pc=4841;continue;}
case 4841:{return rt.Call(f,"forge/game/card/Card","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",4844);}
case 4844:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",4849);}
case 4849:{f.Locals[50]=f.Pop();f.Pc=4851;continue;}
case 4851:{f.Push(f.Locals[50]);f.Pc=4853;continue;}
case 4853:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",4858);}
case 4858:{f.Pc=f.Pop().Int==0?4912:4861;continue;}
case 4861:{f.Push(f.Locals[50]);f.Pc=4863;continue;}
case 4863:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",4868);}
case 4868:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4871;continue;}
case 4871:{f.Locals[51]=f.Pop();f.Pc=4873;continue;}
case 4873:{f.Push(f.Locals[42]);f.Pc=4875;continue;}
case 4875:{f.Push(f.Locals[51]);f.Pc=4877;continue;}
case 4877:{f.Push(f.Locals[0]);f.Pc=4878;continue;}
case 4878:{return rt.Call(f,"forge/game/card/Card","addTriggerForStaticAbility","(Lforge/game/trigger/Trigger;Lforge/game/staticability/StaticAbility;)Lforge/game/trigger/Trigger;","invokevirtual",4881);}
case 4881:{f.Locals[52]=f.Pop();f.Pc=4883;continue;}
case 4883:{f.Push(f.Locals[52]);f.Pc=4885;continue;}
case 4885:{return rt.Call(f,"forge/game/trigger/Trigger","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",4888);}
case 4888:{f.Pc=f.Pop().Reference==null?4899:4891;continue;}
case 4891:{f.Push(f.Locals[52]);f.Pc=4893;continue;}
case 4893:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=4896;continue;}
case 4896:{return rt.Call(f,"forge/game/trigger/Trigger","removeParam","(Ljava/lang/String;)V","invokevirtual",4899);}
case 4899:{f.Push(f.Locals[45]);f.Pc=4901;continue;}
case 4901:{f.Push(f.Locals[52]);f.Pc=4903;continue;}
case 4903:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",4908);}
case 4908:{f.StackOp("pop");f.Pc=4909;continue;}
case 4909:{f.Pc=4851;continue;}
case 4912:{f.Pc=4817;continue;}
case 4915:{f.Push(f.Locals[28]);f.Pc=4917;continue;}
case 4917:{f.Pc=f.Pop().Reference==null?5001:4920;continue;}
case 4920:{f.Push(f.Locals[28]);f.Pc=4922;continue;}
case 4922:{f.Locals[47]=f.Pop();f.Pc=4924;continue;}
case 4924:{f.Push(f.Locals[47]);f.Pc=4926;continue;}
case 4926:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4927;continue;}
case 4927:{f.Locals[48]=f.Pop();f.Pc=4929;continue;}
case 4929:{f.Push(JValue.I(0));f.Pc=4930;continue;}
case 4930:{f.Locals[49]=f.Pop();f.Pc=4932;continue;}
case 4932:{f.Push(f.Locals[49]);f.Pc=4934;continue;}
case 4934:{f.Push(f.Locals[48]);f.Pc=4936;continue;}
case 4936:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?5001:4939;continue;}
case 4939:{f.Push(f.Locals[47]);f.Pc=4941;continue;}
case 4941:{f.Push(f.Locals[49]);f.Pc=4943;continue;}
case 4943:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4944;continue;}
case 4944:{f.Locals[50]=f.Pop();f.Pc=4946;continue;}
case 4946:{f.Push(f.Locals[50]);f.Pc=4948;continue;}
case 4948:{f.Push(JValue.R(rt.String("ConvertedManaCost")));f.Pc=4951;continue;}
case 4951:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",4954);}
case 4954:{f.Pc=f.Pop().Int==0?4979:4957;continue;}
case 4957:{f.Push(f.Locals[42]);f.Pc=4959;continue;}
case 4959:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",4962);}
case 4962:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",4965);}
case 4965:{f.Locals[51]=f.Pop();f.Pc=4967;continue;}
case 4967:{f.Push(f.Locals[50]);f.Pc=4969;continue;}
case 4969:{f.Push(JValue.R(rt.String("ConvertedManaCost")));f.Pc=4972;continue;}
case 4972:{f.Push(f.Locals[51]);f.Pc=4974;continue;}
case 4974:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",4977);}
case 4977:{f.Locals[50]=f.Pop();f.Pc=4979;continue;}
case 4979:{f.Push(f.Locals[46]);f.Pc=4981;continue;}
case 4981:{f.Push(f.Locals[42]);f.Pc=4983;continue;}
case 4983:{f.Push(f.Locals[50]);f.Pc=4985;continue;}
case 4985:{f.Push(f.Locals[0]);f.Pc=4986;continue;}
case 4986:{return rt.Call(f,"forge/game/card/Card","getStaticAbilityForStaticAbility","(Ljava/lang/String;Lforge/game/staticability/StaticAbility;)Lforge/game/staticability/StaticAbility;","invokevirtual",4989);}
case 4989:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",4994);}
case 4994:{f.StackOp("pop");f.Pc=4995;continue;}
case 4995:{f.Locals[49]=JValue.I(unchecked(f.Locals[49].Int+(1)));f.Pc=4998;continue;}
case 4998:{f.Pc=4932;continue;}
case 5001:{f.Push(f.Locals[43]);f.Pc=5003;continue;}
case 5003:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",5008);}
case 5008:{f.Pc=f.Pop().Int==0?5036:5011;continue;}
case 5011:{f.Push(f.Locals[45]);f.Pc=5013;continue;}
case 5013:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",5018);}
case 5018:{f.Pc=f.Pop().Int==0?5036:5021;continue;}
case 5021:{f.Push(f.Locals[22]);f.Pc=5023;continue;}
case 5023:{f.Pc=f.Pop().Reference!=null?5036:5026;continue;}
case 5026:{f.Push(f.Locals[28]);f.Pc=5028;continue;}
case 5028:{f.Pc=f.Pop().Reference!=null?5036:5031;continue;}
case 5031:{f.Push(f.Locals[29]);f.Pc=5033;continue;}
case 5033:{f.Pc=f.Pop().Reference==null?5063:5036;continue;}
case 5036:{f.Push(f.Locals[42]);f.Pc=5038;continue;}
case 5038:{f.Push(f.Locals[43]);f.Pc=5040;continue;}
case 5040:{f.Push(f.Locals[45]);f.Pc=5042;continue;}
case 5042:{f.Push(f.Locals[44]);f.Pc=5044;continue;}
case 5044:{f.Push(f.Locals[46]);f.Pc=5046;continue;}
case 5046:{f.Push(f.Locals[29]);f.Pc=5048;continue;}
case 5048:{f.Push(f.Locals[8]);f.Pc=5050;continue;}
case 5050:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",5053);}
case 5053:{f.Push(f.Locals[0]);f.Pc=5054;continue;}
case 5054:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",5057);}
case 5057:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=5058;continue;}
case 5058:{f.Push(JValue.I(0));f.Pc=5059;continue;}
case 5059:{return rt.Call(f,"forge/game/card/Card","addChangedCardTraits","(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/function/Predicate;JJZ)Lforge/game/card/ICardTraitChanges;","invokevirtual",5062);}
case 5062:{f.StackOp("pop");f.Pc=5063;continue;}
case 5063:{f.Push(f.Locals[33]);f.Pc=5065;continue;}
case 5065:{f.Pc=f.Pop().Reference==null?5083:5068;continue;}
case 5068:{f.Push(f.Locals[42]);f.Pc=5070;continue;}
case 5070:{f.Push(f.Locals[8]);f.Pc=5072;continue;}
case 5072:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",5075);}
case 5075:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",5078);}
case 5078:{f.Push(f.Locals[33]);f.Pc=5080;continue;}
case 5080:{return rt.Call(f,"forge/game/card/Card","addCantHaveKeyword","(Ljava/lang/Long;Ljava/lang/Iterable;)V","invokevirtual",5083);}
case 5083:{f.Push(f.Locals[24]);f.Pc=5085;continue;}
case 5085:{f.Pc=f.Pop().Reference==null?5098:5088;continue;}
case 5088:{f.Push(f.Locals[24]);f.Pc=5090;continue;}
case 5090:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",5095);}
case 5095:{f.Pc=f.Pop().Int==0?5128:5098;continue;}
case 5098:{f.Push(f.Locals[25]);f.Pc=5100;continue;}
case 5100:{f.Pc=f.Pop().Reference==null?5113:5103;continue;}
case 5103:{f.Push(f.Locals[25]);f.Pc=5105;continue;}
case 5105:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",5110);}
case 5110:{f.Pc=f.Pop().Int==0?5128:5113;continue;}
case 5113:{f.Push(f.Locals[30]);f.Pc=5115;continue;}
case 5115:{f.Pc=f.Pop().Int!=0?5128:5118;continue;}
case 5118:{f.Push(f.Locals[31]);f.Pc=5120;continue;}
case 5120:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",5125);}
case 5125:{f.Pc=f.Pop().Int!=0?5190:5128;continue;}
case 5128:{f.Push(f.Locals[42]);f.Pc=5130;continue;}
case 5130:{f.Push(f.Locals[24]);f.Pc=5132;continue;}
case 5132:{f.Pc=f.Pop().Reference==null?5148:5135;continue;}
case 5135:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=5138;continue;}
case 5138:{f.StackOp("dup");f.Pc=5139;continue;}
case 5139:{f.Push(f.Locals[24]);f.Pc=5141;continue;}
case 5141:{f.Push(JValue.I(1));f.Pc=5142;continue;}
case 5142:{return rt.Call(f,"forge/card/CardType","<init>","(Ljava/lang/Iterable;Z)V","invokespecial",5145);}
case 5145:{f.Pc=5149;continue;}
case 5148:{f.Push(JValue.R(null));f.Pc=5149;continue;}
case 5149:{f.Push(f.Locals[25]);f.Pc=5151;continue;}
case 5151:{f.Pc=f.Pop().Reference==null?5167:5154;continue;}
case 5154:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=5157;continue;}
case 5157:{f.StackOp("dup");f.Pc=5158;continue;}
case 5158:{f.Push(f.Locals[25]);f.Pc=5160;continue;}
case 5160:{f.Push(JValue.I(1));f.Pc=5161;continue;}
case 5161:{return rt.Call(f,"forge/card/CardType","<init>","(Ljava/lang/Iterable;Z)V","invokespecial",5164);}
case 5164:{f.Pc=5168;continue;}
case 5167:{f.Push(JValue.R(null));f.Pc=5168;continue;}
case 5168:{f.Push(f.Locals[30]);f.Pc=5170;continue;}
case 5170:{f.Push(f.Locals[31]);f.Pc=5172;continue;}
case 5172:{f.Push(f.Locals[8]);f.Pc=5174;continue;}
case 5174:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",5177);}
case 5177:{f.Push(f.Locals[0]);f.Pc=5178;continue;}
case 5178:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",5181);}
case 5181:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=5182;continue;}
case 5182:{f.Push(JValue.I(0));f.Pc=5183;continue;}
case 5183:{f.Push(f.Locals[0]);f.Pc=5184;continue;}
case 5184:{return rt.Call(f,"forge/game/staticability/StaticAbility","isCharacteristicDefining","()Z","invokevirtual",5187);}
case 5187:{return rt.Call(f,"forge/game/card/Card","addChangedCardTypes","(Lforge/card/CardType;Lforge/card/CardType;ZLjava/util/Set;JJZZ)V","invokevirtual",5190);}
case 5190:{f.Push(f.Locals[26]);f.Pc=5192;continue;}
case 5192:{f.Pc=f.Pop().Reference==null?5218:5195;continue;}
case 5195:{f.Push(f.Locals[42]);f.Pc=5197;continue;}
case 5197:{f.Push(f.Locals[26]);f.Pc=5199;continue;}
case 5199:{f.Push(f.Locals[32]);f.Pc=5201;continue;}
case 5201:{f.Pc=f.Pop().Int!=0?5208:5204;continue;}
case 5204:{f.Push(JValue.I(1));f.Pc=5205;continue;}
case 5205:{f.Pc=5209;continue;}
case 5208:{f.Push(JValue.I(0));f.Pc=5209;continue;}
case 5209:{f.Push(f.Locals[8]);f.Pc=5211;continue;}
case 5211:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",5214);}
case 5214:{f.Push(f.Locals[0]);f.Pc=5215;continue;}
case 5215:{return rt.Call(f,"forge/game/card/Card","addColor","(Lforge/card/ColorSet;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",5218);}
case 5218:{f.Push(f.Locals[2]);f.Pc=5219;continue;}
case 5219:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=5222;continue;}
case 5222:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?5344:5225;continue;}
case 5225:{f.Push(f.Locals[3]);f.Pc=5226;continue;}
case 5226:{f.Push(JValue.R(rt.String("Goad")));f.Pc=5229;continue;}
case 5229:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",5234);}
case 5234:{f.Pc=f.Pop().Int==0?5255:5237;continue;}
case 5237:{f.Push(f.Locals[42]);f.Pc=5239;continue;}
case 5239:{f.Push(f.Locals[8]);f.Pc=5241;continue;}
case 5241:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",5244);}
case 5244:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",5247);}
case 5247:{f.Push(f.Locals[4]);f.Pc=5249;continue;}
case 5249:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",5252);}
case 5252:{return rt.Call(f,"forge/game/card/Card","addGoad","(Ljava/lang/Long;Lforge/game/player/Player;)V","invokevirtual",5255);}
case 5255:{f.Push(f.Locals[3]);f.Pc=5256;continue;}
case 5256:{f.Push(JValue.R(rt.String("CanBlockAny")));f.Pc=5259;continue;}
case 5259:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",5264);}
case 5264:{f.Pc=f.Pop().Int==0?5277:5267;continue;}
case 5267:{f.Push(f.Locals[42]);f.Pc=5269;continue;}
case 5269:{f.Push(f.Locals[8]);f.Pc=5271;continue;}
case 5271:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",5274);}
case 5274:{return rt.Call(f,"forge/game/card/Card","addCanBlockAny","(J)V","invokevirtual",5277);}
case 5277:{f.Push(f.Locals[3]);f.Pc=5278;continue;}
case 5278:{f.Push(JValue.R(rt.String("CanBlockAmount")));f.Pc=5281;continue;}
case 5281:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",5286);}
case 5286:{f.Pc=f.Pop().Int==0?5322:5289;continue;}
case 5289:{f.Push(f.Locals[4]);f.Pc=5291;continue;}
case 5291:{f.Push(f.Locals[3]);f.Pc=5292;continue;}
case 5292:{f.Push(JValue.R(rt.String("CanBlockAmount")));f.Pc=5295;continue;}
case 5295:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",5300);}
case 5300:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5303;continue;}
case 5303:{f.Push(f.Locals[0]);f.Pc=5304;continue;}
case 5304:{f.Push(JValue.I(1));f.Pc=5305;continue;}
case 5305:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;Z)I","invokestatic",5308);}
case 5308:{f.Locals[43]=f.Pop();f.Pc=5310;continue;}
case 5310:{f.Push(f.Locals[42]);f.Pc=5312;continue;}
case 5312:{f.Push(f.Locals[43]);f.Pc=5314;continue;}
case 5314:{f.Push(f.Locals[8]);f.Pc=5316;continue;}
case 5316:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",5319);}
case 5319:{return rt.Call(f,"forge/game/card/Card","addCanBlockAdditional","(IJ)V","invokevirtual",5322);}
case 5322:{f.Push(f.Locals[3]);f.Pc=5323;continue;}
case 5323:{f.Push(JValue.R(rt.String("LethalDamageByPower")));f.Pc=5326;continue;}
case 5326:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",5331);}
case 5331:{f.Pc=f.Pop().Int==0?5344:5334;continue;}
case 5334:{f.Push(f.Locals[42]);f.Pc=5336;continue;}
case 5336:{f.Push(f.Locals[8]);f.Pc=5338;continue;}
case 5338:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",5341);}
case 5341:{return rt.Call(f,"forge/game/card/Card","addLethalDamageByPower","(J)V","invokevirtual",5344);}
case 5344:{f.Push(f.Locals[35]);f.Pc=5346;continue;}
case 5346:{f.Pc=f.Pop().Int==0?5648:5349;continue;}
case 5349:{f.Push(f.Locals[40]);f.Pc=5351;continue;}
case 5351:{f.Pc=f.Pop().Reference==null?5366:5354;continue;}
case 5354:{f.Push(f.Locals[0]);f.Pc=5355;continue;}
case 5355:{return rt.Call(f,"forge/game/staticability/StaticAbility","getMayPlayTurn","()I","invokevirtual",5358);}
case 5358:{f.Push(f.Locals[40]);f.Pc=5360;continue;}
case 5360:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",5363);}
case 5363:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?5648:5366;continue;}
case 5366:{f.Push(f.Locals[38]);f.Pc=5368;continue;}
case 5368:{f.Locals[43]=f.Pop();f.Pc=5370;continue;}
case 5370:{f.Push(f.Locals[43]);f.Pc=5372;continue;}
case 5372:{f.Pc=f.Pop().Reference==null?5408:5375;continue;}
case 5375:{f.Push(f.Locals[43]);f.Pc=5377;continue;}
case 5377:{f.Push(JValue.R(rt.String("ConvertedManaCost")));f.Pc=5380;continue;}
case 5380:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",5383);}
case 5383:{f.Pc=f.Pop().Int==0?5408:5386;continue;}
case 5386:{f.Push(f.Locals[42]);f.Pc=5388;continue;}
case 5388:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",5391);}
case 5391:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",5394);}
case 5394:{f.Locals[44]=f.Pop();f.Pc=5396;continue;}
case 5396:{f.Push(f.Locals[43]);f.Pc=5398;continue;}
case 5398:{f.Push(JValue.R(rt.String("ConvertedManaCost")));f.Pc=5401;continue;}
case 5401:{f.Push(f.Locals[44]);f.Pc=5403;continue;}
case 5403:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",5406);}
case 5406:{f.Locals[43]=f.Pop();f.Pc=5408;continue;}
case 5408:{f.Push(f.Locals[3]);f.Pc=5409;continue;}
case 5409:{f.Push(JValue.R(rt.String("MayPlayPlayer")));f.Pc=5412;continue;}
case 5412:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",5417);}
case 5417:{f.Pc=f.Pop().Int==0?5441:5420;continue;}
case 5420:{f.Push(f.Locals[42]);f.Pc=5422;continue;}
case 5422:{f.Push(f.Locals[3]);f.Pc=5423;continue;}
case 5423:{f.Push(JValue.R(rt.String("MayPlayPlayer")));f.Pc=5426;continue;}
case 5426:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",5431);}
case 5431:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5434;continue;}
case 5434:{f.Push(f.Locals[0]);f.Pc=5435;continue;}
case 5435:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",5438);}
case 5438:{f.Pc=5450;continue;}
case 5441:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=5444;continue;}
case 5444:{f.StackOp("dup");f.Pc=5445;continue;}
case 5445:{f.Push(f.Locals[5]);f.Pc=5447;continue;}
case 5447:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","(Lforge/game/player/Player;)V","invokespecial",5450);}
case 5450:{f.Locals[44]=f.Pop();f.Pc=5452;continue;}
case 5452:{f.Push(f.Locals[42]);f.Pc=5454;continue;}
case 5454:{f.Push(f.Locals[44]);f.Pc=5456;continue;}
case 5456:{f.Push(f.Locals[36]);f.Pc=5458;continue;}
case 5458:{f.Push(f.Locals[43]);f.Pc=5460;continue;}
case 5460:{f.Pc=f.Pop().Reference==null?5483:5463;continue;}
case 5463:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=5466;continue;}
case 5466:{f.StackOp("dup");f.Pc=5467;continue;}
case 5467:{f.Push(f.Locals[43]);f.Pc=5469;continue;}
case 5469:{f.Push(JValue.I(0));f.Pc=5470;continue;}
case 5470:{f.Push(f.Locals[42]);f.Pc=5472;continue;}
case 5472:{f.Push(f.Locals[4]);f.Pc=5474;continue;}
case 5474:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",5477);}
case 5477:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;ZZ)V","invokespecial",5480);}
case 5480:{f.Pc=5484;continue;}
case 5483:{f.Push(JValue.R(null));f.Pc=5484;continue;}
case 5484:{f.Push(f.Locals[37]);f.Pc=5486;continue;}
case 5486:{f.Push(f.Locals[39]);f.Pc=5488;continue;}
case 5488:{f.Push(f.Locals[0]);f.Pc=5489;continue;}
case 5489:{return rt.Call(f,"forge/game/card/Card","setMayPlay","(Lforge/game/player/PlayerCollection;ZLforge/game/cost/Cost;ZZLforge/game/staticability/StaticAbility;)V","invokevirtual",5492);}
case 5492:{f.Push(f.Locals[34]);f.Pc=5494;continue;}
case 5494:{f.Pc=f.Pop().Reference==null?5517:5497;continue;}
case 5497:{f.Push(f.Locals[34]);f.Pc=5499;continue;}
case 5499:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",5504);}
case 5504:{f.Pc=f.Pop().Int==0?5517:5507;continue;}
case 5507:{f.Push(f.Locals[34]);f.Pc=5509;continue;}
case 5509:{f.Push(f.Locals[44]);f.Pc=5511;continue;}
case 5511:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",5516);}
case 5516:{f.StackOp("pop");f.Pc=5517;continue;}
case 5517:{f.Push(f.Locals[0]);f.Pc=5518;continue;}
case 5518:{f.Push(JValue.R(rt.String("Affected")));f.Pc=5520;continue;}
case 5520:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",5523);}
case 5523:{f.Pc=f.Pop().Int==0?5648:5526;continue;}
case 5526:{f.Push(f.Locals[0]);f.Pc=5527;continue;}
case 5527:{f.Push(JValue.R(rt.String("Affected")));f.Pc=5529;continue;}
case 5529:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5532);}
case 5532:{f.Push(JValue.R(rt.String("Card.Self")));f.Pc=5535;continue;}
case 5535:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5538);}
case 5538:{f.Pc=f.Pop().Int==0?5648:5541;continue;}
case 5541:{f.Push(f.Locals[42]);f.Pc=5543;continue;}
case 5543:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=5546;continue;}
case 5546:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",5549);}
case 5549:{f.Pc=f.Pop().Int==0?5648:5552;continue;}
case 5552:{f.Push(f.Locals[7]);f.Pc=5554;continue;}
case 5554:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",5557);}
case 5557:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",5560);}
case 5560:{f.Locals[45]=f.Pop();f.Pc=5562;continue;}
case 5562:{f.Push(f.Locals[45]);f.Pc=5564;continue;}
case 5564:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",5569);}
case 5569:{f.Pc=f.Pop().Int==0?5648:5572;continue;}
case 5572:{f.Push(f.Locals[45]);f.Pc=5574;continue;}
case 5574:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",5579);}
case 5579:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5582;continue;}
case 5582:{f.Locals[46]=f.Pop();f.Pc=5584;continue;}
case 5584:{f.Push(f.Locals[46]);f.Pc=5586;continue;}
case 5586:{f.Push(JValue.R(rt.String("Shaman's Trance")));f.Pc=5589;continue;}
case 5589:{return rt.Call(f,"forge/game/player/Player","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",5592);}
case 5592:{f.Pc=f.Pop().Int==0?5645:5595;continue;}
case 5595:{f.Push(f.Locals[44]);f.Pc=5597;continue;}
case 5597:{f.Push(f.Locals[46]);f.Pc=5599;continue;}
case 5599:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",5602);}
case 5602:{f.Pc=f.Pop().Int!=0?5645:5605;continue;}
case 5605:{f.Push(f.Locals[42]);f.Pc=5607;continue;}
case 5607:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=5610;continue;}
case 5610:{f.StackOp("dup");f.Pc=5611;continue;}
case 5611:{f.Push(f.Locals[46]);f.Pc=5613;continue;}
case 5613:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","(Lforge/game/player/Player;)V","invokespecial",5616);}
case 5616:{f.Push(f.Locals[36]);f.Pc=5618;continue;}
case 5618:{f.Push(f.Locals[43]);f.Pc=5620;continue;}
case 5620:{f.Pc=f.Pop().Reference==null?5636:5623;continue;}
case 5623:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=5626;continue;}
case 5626:{f.StackOp("dup");f.Pc=5627;continue;}
case 5627:{f.Push(f.Locals[43]);f.Pc=5629;continue;}
case 5629:{f.Push(JValue.I(0));f.Pc=5630;continue;}
case 5630:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",5633);}
case 5633:{f.Pc=5637;continue;}
case 5636:{f.Push(JValue.R(null));f.Pc=5637;continue;}
case 5637:{f.Push(f.Locals[37]);f.Pc=5639;continue;}
case 5639:{f.Push(f.Locals[39]);f.Pc=5641;continue;}
case 5641:{f.Push(f.Locals[0]);f.Pc=5642;continue;}
case 5642:{return rt.Call(f,"forge/game/card/Card","setMayPlay","(Lforge/game/player/PlayerCollection;ZLforge/game/cost/Cost;ZZLforge/game/staticability/StaticAbility;)V","invokevirtual",5645);}
case 5645:{f.Pc=5562;continue;}
case 5648:{f.Push(f.Locals[34]);f.Pc=5650;continue;}
case 5650:{f.Pc=f.Pop().Reference==null?5710:5653;continue;}
case 5653:{f.Push(f.Locals[42]);f.Pc=5655;continue;}
case 5655:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",5658);}
case 5658:{f.Push(JValue.I(1));f.Pc=5659;continue;}
case 5659:{return rt.Call(f,"forge/game/player/Player","getTopXCardsFromLibrary","(I)Lforge/game/card/CardCollection;","invokevirtual",5662);}
case 5662:{f.Push(f.Locals[42]);f.Pc=5664;continue;}
case 5664:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",5667);}
case 5667:{f.Pc=f.Pop().Int==0?5698:5670;continue;}
case 5670:{f.Push(f.Locals[7]);f.Pc=5672;continue;}
case 5672:{f.Push(f.Locals[42]);f.Pc=5674;continue;}
case 5674:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",5677);}
case 5677:{return rt.Call(f,"forge/game/Game","getTopLibForPlayer","(Lforge/game/player/Player;)Lforge/game/card/Card;","invokevirtual",5680);}
case 5680:{f.Pc=f.Pop().Reference==null?5698:5683;continue;}
case 5683:{f.Push(f.Locals[7]);f.Pc=5685;continue;}
case 5685:{f.Push(f.Locals[42]);f.Pc=5687;continue;}
case 5687:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",5690);}
case 5690:{return rt.Call(f,"forge/game/Game","getTopLibForPlayer","(Lforge/game/player/Player;)Lforge/game/card/Card;","invokevirtual",5693);}
case 5693:{f.Push(f.Locals[42]);f.Pc=5695;continue;}
case 5695:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?5710:5698;continue;}
case 5698:{f.Push(f.Locals[42]);f.Pc=5700;continue;}
case 5700:{f.Push(f.Locals[8]);f.Pc=5702;continue;}
case 5702:{return rt.Call(f,"forge/game/StaticEffect","getTimestamp","()J","invokevirtual",5705);}
case 5705:{f.Push(f.Locals[34]);f.Pc=5707;continue;}
case 5707:{return rt.Call(f,"forge/game/card/Card","addMayLookAt","(JLjava/lang/Iterable;)V","invokevirtual",5710);}
case 5710:{f.Pc=2629;continue;}
case 5713:{f.Push(f.Locals[1]);f.Pc=5714;continue;}
case 5714:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9986(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?35:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?62:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/Card","getChosenColors","()Ljava/lang/Iterable;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/card/ColorSet","fromNames","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",31);}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Pc=62;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("All")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?52:45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"));f.Pc=48;continue;}
case 48:{f.Locals[3]=f.Pop();f.Pc=49;continue;}
case 49:{f.Pc=62;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.String(" & ")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",61);}
case 61:{f.Locals[3]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9987(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?56:28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",47);}
case 47:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Pc=18;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",60);}
case 60:{f.Locals[5]=f.Pop();f.Pc=62;continue;}
case 62:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=65;continue;}
case 65:{f.StackOp("dup");f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(1));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",71);}
case 71:{f.Locals[6]=f.Pop();f.Pc=73;continue;}
case 73:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityContinuous$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityContinuous$1")));f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(null));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous$1","<init>","(Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;Lforge/game/staticability/StaticAbility;Lforge/game/card/CardCollectionView;Ljava/util/List;Lforge/game/card/Card;)V","invokespecial",91);}
case 91:{f.Locals[7]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[7]);f.Pc=95;continue;}
case 95:{f.Push(JValue.I(0));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/spellability/AbilityStatic","setIntrinsic","(Z)V","invokevirtual",99);}
case 99:{f.Push(f.Locals[7]);f.Pc=101;continue;}
case 101:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","InternalIgnoreEffect","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","InternalIgnoreEffect","Lforge/game/ability/ApiType;"));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/AbilityStatic","setApi","(Lforge/game/ability/ApiType;)V","invokevirtual",107);}
case 107:{f.Push(f.Locals[7]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[6]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",114);}
case 114:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityContinuous:9987:114:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",119);}
case 119:{return rt.Call(f,"forge/game/spellability/AbilityStatic","setDescription","(Ljava/lang/String;)V","invokevirtual",122);}
case 122:{f.Push(f.Locals[5]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[7]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",129);}
case 129:{f.Push(JValue.R(null));f.Pc=130;continue;}
case 130:{f.Push(JValue.R(null));f.Pc=131;continue;}
case 131:{f.Push(JValue.R(null));f.Pc=132;continue;}
case 132:{f.Push(JValue.R(null));f.Pc=133;continue;}
case 133:{f.Push(f.Locals[5]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/card/Card","getLayerTimestamp","()J","invokevirtual",138);}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",142);}
case 142:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/Card","addChangedCardTraits","(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/function/Predicate;JJ)Lforge/game/card/ICardTraitChanges;","invokevirtual",146);}
case 146:{f.StackOp("pop");f.Pc=147;continue;}
case 147:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityContinuous$2"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityContinuous$2")));f.Pc=150;continue;}
case 150:{f.StackOp("dup");f.Pc=151;continue;}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous$2","<init>","(Lforge/game/staticability/StaticAbility;)V","invokespecial",155);}
case 155:{f.Locals[8]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[5]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",162);}
case 162:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",165);}
case 165:{f.Push(f.Locals[8]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",170);}
case 170:{f.Push(f.Locals[5]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[8]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",177);}
case 177:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9988(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Defined")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?43:19;continue;}
case 19:{f.Push(f.Locals[5]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",36);}
case 36:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Pc=124;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.String(",")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",58);}
case 58:{f.Locals[6]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("GainsAbilitiesOfZones")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",69);}
case 69:{f.Pc=f.Pop().Int==0?92:72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("GainsAbilitiesOfZones")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",87);}
case 87:{f.Locals[7]=f.Pop();f.Pc=89;continue;}
case 89:{f.Pc=100;continue;}
case 92:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",98);}
case 98:{f.Locals[7]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[4]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",109);}
case 109:{f.Push(f.Locals[6]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[2]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",115);}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",120);}
case 120:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",123);}
case 123:{f.StackOp("pop");f.Pc=124;continue;}
case 124:{f.Push(f.Locals[5]);f.Pc=126;continue;}
case 126:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9989(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbility","getMapParams","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("Affected")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int!=0?38:35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("Affected")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String(",")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Locals[5]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",60);}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",67);}
case 67:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",70);}
case 70:{f.Locals[7]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[7]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int==0?120:82;continue;}
case 82:{f.Push(f.Locals[7]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{f.Locals[8]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[8]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[5]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/player/Player","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?117:107;continue;}
case 107:{f.Push(f.Locals[4]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",116);}
case 116:{f.StackOp("pop");f.Pc=117;continue;}
case 117:{f.Pc=72;continue;}
case 120:{f.Push(f.Locals[4]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",127);}
case 127:{f.Push(JValue.I(1));f.Pc=128;continue;}
case 128:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?147:131;continue;}
case 131:{f.Push(f.Locals[6]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/Game","getTurnOrder","()Lforge/game/Direction;","invokevirtual",136);}
case 136:{return rt.Call(f,"forge/game/Direction","isDefaultDirection","()Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int!=0?147:142;continue;}
case 142:{f.Push(f.Locals[4]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Collections","reverse","(Ljava/util/List;)V","invokestatic",147);}
case 147:{f.Push(f.Locals[4]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/staticability/StaticAbility","getIgnoreEffectPlayers","()Ljava/util/List;","invokevirtual",153);}
case 153:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",158);}
case 158:{f.StackOp("pop");f.Pc=159;continue;}
case 159:{f.Push(f.Locals[4]);f.Pc=161;continue;}
case 161:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9990(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/staticability/StaticAbility","isCharacteristicDefining","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?97:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("ExcludeZone")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?88:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("ExcludeZone")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",40);}
case 40:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",43);}
case 43:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",48);}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",57);}
case 57:{f.Pc=f.Pop().Int==0?88:60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Locals[6]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?85:81;continue;}
case 81:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=84;continue;}
case 84:{return JStep.Return(f.Pop());}
case 85:{f.Pc=50;continue;}
case 88:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=91;continue;}
case 91:{f.StackOp("dup");f.Pc=92;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",96);}
case 96:{return JStep.Return(f.Pop());}
case 97:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=100;continue;}
case 100:{f.StackOp("dup");f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",104);}
case 104:{f.Locals[5]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(JValue.R(null));f.Pc=107;continue;}
case 107:{f.Locals[6]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("AffectedDefined")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",116);}
case 116:{f.Pc=f.Pop().Int==0?139:119;continue;}
case 119:{f.Push(f.Locals[2]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("AffectedDefined")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",127);}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",131);}
case 131:{return rt.Call(f,"forge/game/card/CardPredicates","phasedIn","()Ljava/util/function/Predicate;","invokestatic",134);}
case 134:{return rt.Call(f,"forge/game/card/CardCollection","filter","(Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokevirtual",137);}
case 137:{f.Locals[6]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",145);}
case 145:{f.Pc=f.Pop().Int!=0?228:148;continue;}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("AffectedDefined")));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",155);}
case 155:{f.Pc=f.Pop().Int==0?176:158;continue;}
case 158:{f.Push(f.Locals[5]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",164);}
case 164:{f.StackOp("pop");f.Pc=165;continue;}
case 165:{f.Push(f.Locals[5]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[6]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/card/CardCollection","retainAll","(Ljava/util/Collection;)Z","invokevirtual",172);}
case 172:{f.StackOp("pop");f.Pc=173;continue;}
case 173:{f.Pc=228;continue;}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String("AffectedZone")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",183);}
case 183:{f.Pc=f.Pop().Int==0?212:186;continue;}
case 186:{f.Push(f.Locals[5]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[1]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("AffectedZone")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",196);}
case 196:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",199);}
case 199:{return rt.Call(f,"forge/game/card/CardPredicates","inZone","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;","invokestatic",202);}
case 202:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",205);}
case 205:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",208);}
case 208:{f.StackOp("pop");f.Pc=209;continue;}
case 209:{f.Pc=228;continue;}
case 212:{f.Push(f.Locals[5]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[1]);f.Pc=215;continue;}
case 215:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/card/CardPredicates","inZone","(Lforge/game/zone/ZoneType;)Ljava/util/function/Predicate;","invokestatic",221);}
case 221:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",224);}
case 224:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",227);}
case 227:{f.StackOp("pop");f.Pc=228;continue;}
case 228:{f.Push(f.Locals[0]);f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.String("AffectedDefined")));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",235);}
case 235:{f.Pc=f.Pop().Int==0?249:238;continue;}
case 238:{f.Push(f.Locals[5]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[6]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",245);}
case 245:{f.StackOp("pop");f.Pc=246;continue;}
case 246:{f.Pc=295;continue;}
case 249:{f.Push(f.Locals[0]);f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("AffectedZone")));f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",256);}
case 256:{f.Pc=f.Pop().Int==0?282:259;continue;}
case 259:{f.Push(f.Locals[5]);f.Pc=261;continue;}
case 261:{f.Push(f.Locals[3]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[0]);f.Pc=263;continue;}
case 263:{f.Push(JValue.R(rt.String("AffectedZone")));f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",269);}
case 269:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",272);}
case 272:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",275);}
case 275:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",278);}
case 278:{f.StackOp("pop");f.Pc=279;continue;}
case 279:{f.Pc=295;continue;}
case 282:{f.Push(f.Locals[5]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[3]);f.Pc=285;continue;}
case 285:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",291);}
case 291:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",294);}
case 294:{f.StackOp("pop");f.Pc=295;continue;}
case 295:{f.Push(f.Locals[0]);f.Pc=296;continue;}
case 296:{f.Push(JValue.R(rt.String("Affected")));f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",301);}
case 301:{f.Pc=f.Pop().Int==0?477:304;continue;}
case 304:{f.Push(JValue.R(null));f.Pc=305;continue;}
case 305:{f.Locals[7]=f.Pop();f.Pc=307;continue;}
case 307:{f.Push(f.Locals[4]);f.Pc=309;continue;}
case 309:{f.Push(JValue.R(rt.String("Shaman's Trance")));f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/player/Player","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",315);}
case 315:{f.Pc=f.Pop().Int==0?339:318;continue;}
case 318:{f.Push(f.Locals[0]);f.Pc=319;continue;}
case 319:{f.Push(JValue.R(rt.String("MayPlay")));f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",325);}
case 325:{f.Pc=f.Pop().Int==0?339:328;continue;}
case 328:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=331;continue;}
case 331:{f.StackOp("dup");f.Pc=332;continue;}
case 332:{f.Push(f.Locals[5]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",337);}
case 337:{f.Locals[7]=f.Pop();f.Pc=339;continue;}
case 339:{f.Push(f.Locals[5]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[0]);f.Pc=342;continue;}
case 342:{f.Push(JValue.R(rt.String("Affected")));f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",347);}
case 347:{f.Push(f.Locals[4]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[2]);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[0]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",354);}
case 354:{f.Locals[5]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(f.Locals[7]);f.Pc=358;continue;}
case 358:{f.Pc=f.Pop().Reference==null?477:361;continue;}
case 361:{f.Push(f.Locals[0]);f.Pc=362;continue;}
case 362:{f.Push(JValue.R(rt.String("Affected")));f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",367);}
case 367:{f.Locals[8]=f.Pop();f.Pc=369;continue;}
case 369:{f.Push(f.Locals[8]);f.Pc=371;continue;}
case 371:{f.Push(JValue.R(rt.String("[\\.\\+]YouOwn")));f.Pc=374;continue;}
case 374:{f.Push(JValue.R(rt.String("")));f.Pc=376;continue;}
case 376:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",379);}
case 379:{f.Locals[8]=f.Pop();f.Pc=381;continue;}
case 381:{f.Push(f.Locals[8]);f.Pc=383;continue;}
case 383:{f.Push(JValue.R(rt.String("[\\.\\+]YouCtrl")));f.Pc=386;continue;}
case 386:{f.Push(JValue.R(rt.String("")));f.Pc=388;continue;}
case 388:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",391);}
case 391:{f.Locals[8]=f.Pop();f.Pc=393;continue;}
case 393:{f.Push(f.Locals[8]);f.Pc=395;continue;}
case 395:{f.Push(JValue.R(rt.String(",")));f.Pc=397;continue;}
case 397:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",400);}
case 400:{f.Locals[9]=f.Pop();f.Pc=402;continue;}
case 402:{f.Push(f.Locals[7]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",407);}
case 407:{f.Locals[10]=f.Pop();f.Pc=409;continue;}
case 409:{f.Push(f.Locals[10]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",416);}
case 416:{f.Pc=f.Pop().Int==0?477:419;continue;}
case 419:{f.Push(f.Locals[10]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",426);}
case 426:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=429;continue;}
case 429:{f.Locals[11]=f.Pop();f.Pc=431;continue;}
case 431:{f.Push(f.Locals[11]);f.Pc=433;continue;}
case 433:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",439);}
case 439:{f.Pc=f.Pop().Int==0?474:442;continue;}
case 442:{f.Push(f.Locals[11]);f.Pc=444;continue;}
case 444:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",447);}
case 447:{f.Push(f.Locals[4]);f.Pc=449;continue;}
case 449:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?474:452;continue;}
case 452:{f.Push(f.Locals[11]);f.Pc=454;continue;}
case 454:{f.Push(f.Locals[9]);f.Pc=456;continue;}
case 456:{f.Push(f.Locals[4]);f.Pc=458;continue;}
case 458:{f.Push(f.Locals[2]);f.Pc=459;continue;}
case 459:{f.Push(f.Locals[0]);f.Pc=460;continue;}
case 460:{return rt.Call(f,"forge/game/card/Card","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",463);}
case 463:{f.Pc=f.Pop().Int==0?474:466;continue;}
case 466:{f.Push(f.Locals[5]);f.Pc=468;continue;}
case 468:{f.Push(f.Locals[11]);f.Pc=470;continue;}
case 470:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",473);}
case 473:{f.StackOp("pop");f.Pc=474;continue;}
case 474:{f.Pc=409;continue;}
case 477:{f.Push(f.Locals[5]);f.Pc=479;continue;}
case 479:{f.Push(f.Locals[0]);f.Pc=480;continue;}
case 480:{return rt.Call(f,"forge/game/staticability/StaticAbility","getIgnoreEffectCards","()Lforge/game/card/CardCollectionView;","invokevirtual",483);}
case 483:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",486);}
case 486:{f.StackOp("pop");f.Pc=487;continue;}
case 487:{f.Push(f.Locals[5]);f.Pc=489;continue;}
case 489:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9991(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("KeywordMultiplier")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Integer","valueOf","(Ljava/lang/String;)Ljava/lang/Integer;","invokestatic",15);}
case 15:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Collections","nCopies","(ILjava/lang/Object;)Ljava/util/List;","invokestatic",22);}
case 22:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",27);}
case 27:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9992(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("CardManaCost")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?28:10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("CardManaCost")));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/card/mana/ManaCost","getShortString","()Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{f.Pc=55;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("ConvertedManaCost")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?55:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",42);}
case 42:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",45);}
case 45:{f.Locals[2]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("ConvertedManaCost")));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Locals[1]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9993(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("CardColors")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?20:10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("cardColors")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?96:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?94:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/card/ColorSet","iterator","()Ljava/util/Iterator;","invokevirtual",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",44);}
case 44:{f.Pc=f.Pop().Int==0?94:47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/MagicColor$Color"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("CardColors")));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/card/MagicColor$Color","getName","()Ljava/lang/String;","invokevirtual",68);}
case 68:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",71);}
case 71:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",74);}
case 74:{f.Push(JValue.R(rt.String("cardColors")));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/card/MagicColor$Color","getName","()Ljava/lang/String;","invokevirtual",82);}
case 82:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",85);}
case 85:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Pc=38;continue;}
case 94:{f.Push(JValue.I(1));f.Pc=95;continue;}
case 95:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 96:{f.Push(JValue.I(0));f.Pc=97;continue;}
case 97:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9994(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?19:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","hasChosenType","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?19:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9995(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","hasChosenType2","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?19:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("ChosenType2")));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getChosenType2","()Ljava/lang/String;","invokevirtual",15);}
case 15:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","hasChosenType","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?38:26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",34);}
case 34:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Locals[1]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9996(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?19:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","hasChosenType","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?19:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("ChosenType2")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?38:29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card","hasChosenType2","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?38:36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("ImprintedCreatureType")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?84:48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/Card","hasImprintedCard","()Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?82:55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","getImprintedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/game/card/CardCollectionView","getLast","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",71);}
case 71:{return rt.Call(f,"forge/card/CardTypeView","getCreatureTypes","()Ljava/util/Set;","invokeinterface",76);}
case 76:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Push(JValue.I(1));f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("AllBasicLandType")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?106:94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/card/CardType","getBasicTypes","()Ljava/util/Collection;","invokestatic",98);}
case 98:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",103);}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Push(JValue.I(1));f.Pc=105;continue;}
case 105:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("AllNonBasicLandType")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?128:116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/card/CardType","getNonBasicTypes","()Ljava/util/Collection;","invokestatic",120);}
case 120:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",125);}
case 125:{f.StackOp("pop");f.Pc=126;continue;}
case 126:{f.Push(JValue.I(1));f.Pc=127;continue;}
case 127:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 128:{f.Push(JValue.I(0));f.Pc=129;continue;}
case 129:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9997(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9998(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?41:7;continue;}
case 7:{f.Push(f.Locals[5]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","getChosenColor","()Ljava/lang/String;","invokevirtual",16);}
case 16:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",19);}
case 19:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("chosenColor")));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card","getChosenColor","()Ljava/lang/String;","invokevirtual",33);}
case 33:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","hasChosenType","()Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?62:48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",57);}
case 57:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",60);}
case 60:{f.Locals[5]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/Card","hasChosenNumber","()Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?86:69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("ChosenNumber")));f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/Card","getChosenNumber","()Ljava/lang/Integer;","invokevirtual",78);}
case 78:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",81);}
case 81:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",84);}
case 84:{f.Locals[5]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/Card","hasChosenPlayer","()Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?135:93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/Card","getChosenPlayer","()Lforge/game/player/Player;","invokevirtual",97);}
case 97:{f.Locals[6]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[5]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("ChosenPlayerUID")));f.Pc=104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/player/Player","getId","()I","invokevirtual",109);}
case 109:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",112);}
case 112:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",115);}
case 115:{f.Locals[5]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[5]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("ChosenPlayerName")));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[6]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",127);}
case 127:{return rt.Call(f,"java/util/regex/Matcher","quoteReplacement","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",130);}
case 130:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",133);}
case 133:{f.Locals[5]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/card/Card","hasNamedCard","()Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int==0?173:142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/Card","getNamedCard","()Ljava/lang/String;","invokevirtual",146);}
case 146:{f.Push(JValue.R(rt.String(",")));f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String(";")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",154);}
case 154:{f.Locals[6]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[5]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("ChosenName")));f.Pc=161;continue;}
case 161:{f.Push(f.Locals[6]);f.Pc=163;continue;}
case 163:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityContinuous:9998:163:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",168);}
case 168:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",171);}
case 171:{f.Locals[5]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/card/Card","hasChosenEvenOdd","()Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int==0?217:180;continue;}
case 180:{f.Push(f.Locals[5]);f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String("ChosenEvenOdd")));f.Pc=185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/card/Card","getChosenEvenOdd","()Lforge/game/EvenOdd;","invokevirtual",189);}
case 189:{return rt.Call(f,"forge/game/EvenOdd","toString","()Ljava/lang/String;","invokevirtual",192);}
case 192:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",195);}
case 195:{f.Locals[5]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[5]);f.Pc=199;continue;}
case 199:{f.Push(JValue.R(rt.String("chosenEvenOdd")));f.Pc=202;continue;}
case 202:{f.Push(f.Locals[0]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/card/Card","getChosenEvenOdd","()Lforge/game/EvenOdd;","invokevirtual",206);}
case 206:{return rt.Call(f,"forge/game/EvenOdd","toString","()Ljava/lang/String;","invokevirtual",209);}
case 209:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",212);}
case 212:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",215);}
case 215:{f.Locals[5]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[5]);f.Pc=219;continue;}
case 219:{f.Push(JValue.R(rt.String("HostCardUID")));f.Pc=222;continue;}
case 222:{f.Push(f.Locals[1]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",226);}
case 226:{f.Locals[5]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[5]);f.Pc=230;continue;}
case 230:{f.Push(JValue.R(rt.String("HostCardControllerUID")));f.Pc=233;continue;}
case 233:{f.Push(f.Locals[2]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",237);}
case 237:{f.Locals[5]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[3]);f.Pc=240;continue;}
case 240:{f.Push(JValue.R(rt.String("CalcKeywordN")));f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",248);}
case 248:{f.Pc=f.Pop().Int==0?282:251;continue;}
case 251:{f.Push(f.Locals[5]);f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.String("N")));f.Pc=256;continue;}
case 256:{f.Push(f.Locals[0]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[3]);f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String("CalcKeywordN")));f.Pc=261;continue;}
case 261:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",266);}
case 266:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[4]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",274);}
case 274:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",277);}
case 277:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",280);}
case 280:{f.Locals[5]=f.Pop();f.Pc=282;continue;}
case 282:{f.Push(f.Locals[5]);f.Pc=284;continue;}
case 284:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9999(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?20:7;continue;}
case 7:{f.Push(f.Locals[6]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?20:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","hasChosenType","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?40:27;continue;}
case 27:{f.Push(f.Locals[6]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?40:38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/card/Card","hasChosenNumber","()Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int!=0?60:47;continue;}
case 47:{f.Push(f.Locals[6]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("ChosenNumber")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?60:58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/Card","hasChosenPlayer","()Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int!=0?80:67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("ChosenPlayer")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int==0?80:78;continue;}
case 78:{f.Push(JValue.I(1));f.Pc=79;continue;}
case 79:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/Card","hasNamedCard","()Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int!=0?100:87;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("ChosenName")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?100:98;continue;}
case 98:{f.Push(JValue.I(1));f.Pc=99;continue;}
case 99:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/card/Card","hasChosenEvenOdd","()Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int!=0?131:107;continue;}
case 107:{f.Push(f.Locals[6]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("ChosenEvenOdd")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int!=0?129:118;continue;}
case 118:{f.Push(f.Locals[6]);f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.String("chosenEvenOdd")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?131:129;continue;}
case 129:{f.Push(JValue.I(1));f.Pc=130;continue;}
case 130:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 131:{f.Push(f.Locals[6]);f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("AllColors")));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int!=0?153:142;continue;}
case 142:{f.Push(f.Locals[6]);f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("allColors")));f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?231:153;continue;}
case 153:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=156;continue;}
case 156:{f.Locals[7]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[7]);f.Pc=160;continue;}
case 160:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=161;continue;}
case 161:{f.Locals[8]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(JValue.I(0));f.Pc=164;continue;}
case 164:{f.Locals[9]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[9]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[8]);f.Pc=170;continue;}
case 170:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?229:173;continue;}
case 173:{f.Push(f.Locals[7]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[9]);f.Pc=177;continue;}
case 177:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=178;continue;}
case 178:{f.Locals[10]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[10]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/card/MagicColor","toLongString","(B)Ljava/lang/String;","invokestatic",185);}
case 185:{f.Locals[11]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[6]);f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.String("AllColors")));f.Pc=192;continue;}
case 192:{f.Push(f.Locals[11]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",197);}
case 197:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",200);}
case 200:{f.Locals[12]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[12]);f.Pc=204;continue;}
case 204:{f.Push(JValue.R(rt.String("allColors")));f.Pc=207;continue;}
case 207:{f.Push(f.Locals[11]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",212);}
case 212:{f.Locals[12]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[1]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[12]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",222);}
case 222:{f.StackOp("pop");f.Pc=223;continue;}
case 223:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=226;continue;}
case 226:{f.Pc=166;continue;}
case 229:{f.Push(JValue.I(1));f.Pc=230;continue;}
case 230:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 231:{f.Push(f.Locals[6]);f.Pc=233;continue;}
case 233:{f.Push(JValue.R(rt.String("CommanderColorID")));f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",239);}
case 239:{f.Pc=f.Pop().Int==0?391:242;continue;}
case 242:{f.Push(f.Locals[0]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",246);}
case 246:{return rt.Call(f,"forge/game/player/Player","getCommanders","()Ljava/util/List;","invokevirtual",249);}
case 249:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",254);}
case 254:{f.Pc=f.Pop().Int!=0?389:257;continue;}
case 257:{f.Push(f.Locals[6]);f.Pc=259;continue;}
case 259:{f.Push(JValue.R(rt.String("NotCommanderColorID")));f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",265);}
case 265:{f.Pc=f.Pop().Int==0?330:268;continue;}
case 268:{f.Push(f.Locals[0]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",272);}
case 272:{return rt.Call(f,"forge/game/player/Player","getCommanderColorID","()Lforge/card/ColorSet;","invokevirtual",275);}
case 275:{return rt.Call(f,"forge/card/ColorSet","inverse","()Lforge/card/ColorSet;","invokevirtual",278);}
case 278:{return rt.Call(f,"forge/card/ColorSet","iterator","()Ljava/util/Iterator;","invokevirtual",281);}
case 281:{f.Locals[7]=f.Pop();f.Pc=283;continue;}
case 283:{f.Push(f.Locals[7]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",290);}
case 290:{f.Pc=f.Pop().Int==0?328:293;continue;}
case 293:{f.Push(f.Locals[7]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",300);}
case 300:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/MagicColor$Color"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=303;continue;}
case 303:{f.Locals[8]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[1]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[6]);f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("NotCommanderColorID")));f.Pc=311;continue;}
case 311:{f.Push(f.Locals[8]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/card/MagicColor$Color","getName","()Ljava/lang/String;","invokevirtual",316);}
case 316:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",319);}
case 319:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",324);}
case 324:{f.StackOp("pop");f.Pc=325;continue;}
case 325:{f.Pc=283;continue;}
case 328:{f.Push(JValue.I(1));f.Pc=329;continue;}
case 329:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 330:{f.Push(f.Locals[0]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",334);}
case 334:{return rt.Call(f,"forge/game/player/Player","getCommanderColorID","()Lforge/card/ColorSet;","invokevirtual",337);}
case 337:{return rt.Call(f,"forge/card/ColorSet","iterator","()Ljava/util/Iterator;","invokevirtual",340);}
case 340:{f.Locals[7]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[7]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",349);}
case 349:{f.Pc=f.Pop().Int==0?387:352;continue;}
case 352:{f.Push(f.Locals[7]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",359);}
case 359:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/MagicColor$Color"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=362;continue;}
case 362:{f.Locals[8]=f.Pop();f.Pc=364;continue;}
case 364:{f.Push(f.Locals[1]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[6]);f.Pc=367;continue;}
case 367:{f.Push(JValue.R(rt.String("CommanderColorID")));f.Pc=370;continue;}
case 370:{f.Push(f.Locals[8]);f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/card/MagicColor$Color","getName","()Ljava/lang/String;","invokevirtual",375);}
case 375:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",378);}
case 378:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",383);}
case 383:{f.StackOp("pop");f.Pc=384;continue;}
case 384:{f.Pc=342;continue;}
case 387:{f.Push(JValue.I(1));f.Pc=388;continue;}
case 388:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 389:{f.Push(JValue.I(1));f.Pc=390;continue;}
case 390:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 391:{f.Push(f.Locals[6]);f.Pc=393;continue;}
case 393:{f.Push(JValue.R(rt.String("ColorsYouCtrl")));f.Pc=396;continue;}
case 396:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",399);}
case 399:{f.Pc=f.Pop().Int!=0?413:402;continue;}
case 402:{f.Push(f.Locals[6]);f.Pc=404;continue;}
case 404:{f.Push(JValue.R(rt.String("colorsYouCtrl")));f.Pc=407;continue;}
case 407:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",410);}
case 410:{f.Pc=f.Pop().Int==0?497:413;continue;}
case 413:{f.Push(f.Locals[2]);f.Pc=414;continue;}
case 414:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=417;continue;}
case 417:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",420);}
case 420:{return rt.Call(f,"forge/game/card/CardUtil","getColorsFromCards","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",423);}
case 423:{return rt.Call(f,"forge/card/ColorSet","iterator","()Ljava/util/Iterator;","invokevirtual",426);}
case 426:{f.Locals[7]=f.Pop();f.Pc=428;continue;}
case 428:{f.Push(f.Locals[7]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",435);}
case 435:{f.Pc=f.Pop().Int==0?495:438;continue;}
case 438:{f.Push(f.Locals[7]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",445);}
case 445:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/MagicColor$Color"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=448;continue;}
case 448:{f.Locals[8]=f.Pop();f.Pc=450;continue;}
case 450:{f.Push(f.Locals[6]);f.Pc=452;continue;}
case 452:{f.Push(JValue.R(rt.String("ColorsYouCtrl")));f.Pc=455;continue;}
case 455:{f.Push(f.Locals[8]);f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/card/MagicColor$Color","getName","()Ljava/lang/String;","invokevirtual",460);}
case 460:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",463);}
case 463:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",466);}
case 466:{f.Locals[9]=f.Pop();f.Pc=468;continue;}
case 468:{f.Push(f.Locals[9]);f.Pc=470;continue;}
case 470:{f.Push(JValue.R(rt.String("colorsYouCtrl")));f.Pc=473;continue;}
case 473:{f.Push(f.Locals[8]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/card/MagicColor$Color","getName","()Ljava/lang/String;","invokevirtual",478);}
case 478:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",481);}
case 481:{f.Locals[9]=f.Pop();f.Pc=483;continue;}
case 483:{f.Push(f.Locals[1]);f.Pc=484;continue;}
case 484:{f.Push(f.Locals[9]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",491);}
case 491:{f.StackOp("pop");f.Pc=492;continue;}
case 492:{f.Pc=428;continue;}
case 495:{f.Push(JValue.I(1));f.Pc=496;continue;}
case 496:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 497:{f.Push(f.Locals[6]);f.Pc=499;continue;}
case 499:{f.Push(JValue.R(rt.String("YourBasic")));f.Pc=502;continue;}
case 502:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",505);}
case 505:{f.Pc=f.Pop().Int==0?594:508;continue;}
case 508:{f.Push(f.Locals[0]);f.Pc=509;continue;}
case 509:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",512);}
case 512:{return rt.Call(f,"forge/game/player/Player","getLandsInPlay","()Lforge/game/card/CardCollection;","invokevirtual",515);}
case 515:{f.Locals[7]=f.Pop();f.Pc=517;continue;}
case 517:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=520;continue;}
case 520:{f.Locals[8]=f.Pop();f.Pc=522;continue;}
case 522:{f.Push(f.Locals[8]);f.Pc=524;continue;}
case 524:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",529);}
case 529:{f.Locals[9]=f.Pop();f.Pc=531;continue;}
case 531:{f.Push(f.Locals[9]);f.Pc=533;continue;}
case 533:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",538);}
case 538:{f.Pc=f.Pop().Int==0?592:541;continue;}
case 541:{f.Push(f.Locals[9]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",548);}
case 548:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=551;continue;}
case 551:{f.Locals[10]=f.Pop();f.Pc=553;continue;}
case 553:{f.Push(f.Locals[7]);f.Pc=555;continue;}
case 555:{f.Push(f.Locals[10]);f.Pc=557;continue;}
case 557:{return rt.Call(f,"forge/game/card/CardPredicates","isType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",560);}
case 560:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",565);}
case 565:{f.Pc=f.Pop().Int==0?589:568;continue;}
case 568:{f.Push(f.Locals[6]);f.Pc=570;continue;}
case 570:{f.Push(JValue.R(rt.String("YourBasic")));f.Pc=573;continue;}
case 573:{f.Push(f.Locals[10]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",578);}
case 578:{f.Locals[11]=f.Pop();f.Pc=580;continue;}
case 580:{f.Push(f.Locals[1]);f.Pc=581;continue;}
case 581:{f.Push(f.Locals[11]);f.Pc=583;continue;}
case 583:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",588);}
case 588:{f.StackOp("pop");f.Pc=589;continue;}
case 589:{f.Pc=531;continue;}
case 592:{f.Push(JValue.I(1));f.Pc=593;continue;}
case 593:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 594:{f.Push(f.Locals[6]);f.Pc=596;continue;}
case 596:{f.Push(JValue.R(rt.String("EachCMCAmongDefined")));f.Pc=599;continue;}
case 599:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",602);}
case 602:{f.Pc=f.Pop().Int==0?727:605;continue;}
case 605:{f.Push(f.Locals[3]);f.Pc=606;continue;}
case 606:{f.Push(JValue.R(rt.String("KeywordDefined")));f.Pc=609;continue;}
case 609:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",614);}
case 614:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=617;continue;}
case 617:{f.Locals[7]=f.Pop();f.Pc=619;continue;}
case 619:{f.Push(f.Locals[4]);f.Pc=621;continue;}
case 621:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=624;continue;}
case 624:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",627);}
case 627:{f.Locals[8]=f.Pop();f.Pc=629;continue;}
case 629:{f.Push(f.Locals[8]);f.Pc=631;continue;}
case 631:{f.Push(f.Locals[7]);f.Pc=633;continue;}
case 633:{f.Push(f.Locals[0]);f.Pc=634;continue;}
case 634:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",637);}
case 637:{f.Push(f.Locals[0]);f.Pc=638;continue;}
case 638:{f.Push(f.Locals[5]);f.Pc=640;continue;}
case 640:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",643);}
case 643:{f.Locals[8]=f.Pop();f.Pc=645;continue;}
case 645:{f.Push(f.Locals[8]);f.Pc=647;continue;}
case 647:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",652);}
case 652:{f.Locals[9]=f.Pop();f.Pc=654;continue;}
case 654:{f.Push(f.Locals[9]);f.Pc=656;continue;}
case 656:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",661);}
case 661:{f.Pc=f.Pop().Int==0?725:664;continue;}
case 664:{f.Push(f.Locals[9]);f.Pc=666;continue;}
case 666:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",671);}
case 671:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=674;continue;}
case 674:{f.Locals[10]=f.Pop();f.Pc=676;continue;}
case 676:{f.Push(f.Locals[10]);f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",681);}
case 681:{f.Locals[11]=f.Pop();f.Pc=683;continue;}
case 683:{f.Push(f.Locals[6]);f.Pc=685;continue;}
case 685:{f.Push(JValue.R(rt.String(" from EachCMCAmongDefined")));f.Pc=688;continue;}
case 688:{f.Push(f.Locals[11]);f.Pc=690;continue;}
case 690:{f.Push(f.Locals[11]);f.Pc=692;continue;}
case 692:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityContinuous:9999:692:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(II)Ljava/lang/String;",697);}
case 697:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",700);}
case 700:{f.Locals[12]=f.Pop();f.Pc=702;continue;}
case 702:{f.Push(f.Locals[1]);f.Pc=703;continue;}
case 703:{f.Push(f.Locals[12]);f.Pc=705;continue;}
case 705:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",710);}
case 710:{f.Pc=f.Pop().Int!=0?722:713;continue;}
case 713:{f.Push(f.Locals[1]);f.Pc=714;continue;}
case 714:{f.Push(f.Locals[12]);f.Pc=716;continue;}
case 716:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",721);}
case 721:{f.StackOp("pop");f.Pc=722;continue;}
case 722:{f.Pc=654;continue;}
case 725:{f.Push(JValue.I(1));f.Pc=726;continue;}
case 726:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 727:{f.Push(JValue.I(0));f.Pc=728;continue;}
case 728:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

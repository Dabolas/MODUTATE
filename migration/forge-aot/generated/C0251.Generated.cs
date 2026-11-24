// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C251{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ControlExchangeEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3196,"forge/game/ability/effects/ControlExchangeEffect","<init>","()V",1,1,1,new JHandler[]{},M3196));
c.Add(new JMethod(3197,"forge/game/ability/effects/ControlExchangeEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,3,new JHandler[]{},M3197));
c.Add(new JMethod(3198,"forge/game/ability/effects/ControlExchangeEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,11,9,new JHandler[]{},M3198));
}

internal static JStep M3196(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3197(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Locals[4]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?45:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int<=0?45:33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[2]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("Defined")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?129:54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",58);}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("Defined")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",64);}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",68);}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int==0?84:80;continue;}
case 80:{f.Push(JValue.R(null));f.Pc=81;continue;}
case 81:{f.Pc=95;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",92);}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{f.Locals[3]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[5]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",103);}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?126:107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int!=0?126:114;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{f.Push(JValue.I(1));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",122);}
case 122:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=125;continue;}
case 125:{f.Locals[2]=f.Pop();f.Pc=126;continue;}
case 126:{f.Pc=152;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",136);}
case 136:{f.Push(JValue.I(1));f.Pc=137;continue;}
case 137:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?152:140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",148);}
case 148:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=151;continue;}
case 151:{f.Locals[3]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[2]);f.Pc=153;continue;}
case 153:{f.Pc=f.Pop().Reference==null?160:156;continue;}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{f.Pc=f.Pop().Reference!=null?163:160;continue;}
case 160:{f.Push(JValue.R(rt.String("")));f.Pc=162;continue;}
case 162:{return JStep.Return(f.Pop());}
case 163:{f.Push(f.Locals[2]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",167);}
case 167:{f.Push(f.Locals[3]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",171);}
case 171:{return rt.DynamicCall(f,"forge/game/ability/effects/ControlExchangeEffect:3197:171:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",176);}
case 176:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3198(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{f.Locals[6]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?58:26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",33);}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int<=0?58:45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("Defined")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int==0?141:67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("Defined")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",74);}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",78);}
case 78:{f.Locals[7]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",87);}
case 87:{f.Pc=f.Pop().Int==0?94:90;continue;}
case 90:{f.Push(JValue.R(null));f.Pc=91;continue;}
case 91:{f.Pc=105;continue;}
case 94:{f.Push(f.Locals[7]);f.Pc=96;continue;}
case 96:{f.Push(JValue.I(0));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",102);}
case 102:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=105;continue;}
case 105:{f.Locals[5]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[7]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",114);}
case 114:{f.Push(JValue.I(1));f.Pc=115;continue;}
case 115:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?138:118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",122);}
case 122:{f.Pc=f.Pop().Int!=0?138:125;continue;}
case 125:{f.Push(f.Locals[7]);f.Pc=127;continue;}
case 127:{f.Push(JValue.I(1));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{f.Locals[4]=f.Pop();f.Pc=138;continue;}
case 138:{f.Pc=165;continue;}
case 141:{f.Push(f.Locals[6]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",148);}
case 148:{f.Push(JValue.I(1));f.Pc=149;continue;}
case 149:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?165:152;continue;}
case 152:{f.Push(f.Locals[6]);f.Pc=154;continue;}
case 154:{f.Push(JValue.I(1));f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",160);}
case 160:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=163;continue;}
case 163:{f.Locals[5]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[4]);f.Pc=167;continue;}
case 167:{f.Pc=f.Pop().Reference==null?207:170;continue;}
case 170:{f.Push(f.Locals[5]);f.Pc=172;continue;}
case 172:{f.Pc=f.Pop().Reference==null?207:175;continue;}
case 175:{f.Push(f.Locals[4]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",180);}
case 180:{f.Pc=f.Pop().Int==0?207:183;continue;}
case 183:{f.Push(f.Locals[5]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",188);}
case 188:{f.Pc=f.Pop().Int==0?207:191;continue;}
case 191:{f.Push(f.Locals[4]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",196);}
case 196:{f.Pc=f.Pop().Int!=0?207:199;continue;}
case 199:{f.Push(f.Locals[5]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",204);}
case 204:{f.Pc=f.Pop().Int==0?208:207;continue;}
case 207:{return JStep.ReturnVoid;}
case 208:{f.Push(f.Locals[4]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",213);}
case 213:{f.Locals[7]=f.Pop();f.Pc=215;continue;}
case 215:{f.Push(f.Locals[5]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",220);}
case 220:{f.Locals[8]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[5]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[7]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/card/Card","canBeControlledBy","(Lforge/game/player/Player;)Z","invokevirtual",229);}
case 229:{f.Pc=f.Pop().Int==0?242:232;continue;}
case 232:{f.Push(f.Locals[4]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[8]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/card/Card","canBeControlledBy","(Lforge/game/player/Player;)Z","invokevirtual",239);}
case 239:{f.Pc=f.Pop().Int!=0?243:242;continue;}
case 242:{return JStep.ReturnVoid;}
case 243:{f.Push(f.Locals[1]);f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.String("Optional")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",249);}
case 249:{f.Pc=f.Pop().Int==0?299:252;continue;}
case 252:{f.Push(f.Locals[1]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",256);}
case 256:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",259);}
case 259:{f.Push(f.Locals[1]);f.Pc=260;continue;}
case 260:{f.Push(JValue.R(null));f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",264);}
case 264:{f.Push(JValue.R(rt.String("lblExchangeControl")));f.Pc=266;continue;}
case 266:{f.Push(JValue.I(2));f.Pc=267;continue;}
case 267:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=270;continue;}
case 270:{f.StackOp("dup");f.Pc=271;continue;}
case 271:{f.Push(JValue.I(0));f.Pc=272;continue;}
case 272:{f.Push(f.Locals[4]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",277);}
case 277:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=278;continue;}
case 278:{f.StackOp("dup");f.Pc=279;continue;}
case 279:{f.Push(JValue.I(1));f.Pc=280;continue;}
case 280:{f.Push(f.Locals[5]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",285);}
case 285:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",289);}
case 289:{f.Push(f.Locals[4]);f.Pc=291;continue;}
case 291:{f.Push(JValue.R(null));f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",295);}
case 295:{f.Pc=f.Pop().Int!=0?299:298;continue;}
case 298:{return JStep.ReturnVoid;}
case 299:{f.Push(f.Locals[3]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",303);}
case 303:{f.Locals[9]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[5]);f.Pc=307;continue;}
case 307:{f.Push(f.Locals[7]);f.Pc=309;continue;}
case 309:{f.Push(f.Locals[9]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/card/Card","addTempController","(Lforge/game/player/Player;J)V","invokevirtual",314);}
case 314:{f.Push(f.Locals[4]);f.Pc=316;continue;}
case 316:{f.Push(f.Locals[8]);f.Pc=318;continue;}
case 318:{f.Push(f.Locals[9]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/card/Card","addTempController","(Lforge/game/player/Player;J)V","invokevirtual",323);}
case 323:{f.Push(f.Locals[1]);f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.String("RememberExchanged")));f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",329);}
case 329:{f.Pc=f.Pop().Int==0?344:332;continue;}
case 332:{f.Push(f.Locals[2]);f.Pc=333;continue;}
case 333:{f.Push(f.Locals[4]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",338);}
case 338:{f.Push(f.Locals[2]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[5]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",344);}
case 344:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

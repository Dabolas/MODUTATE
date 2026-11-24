// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C222{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChangeTargetsEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3086,"forge/game/ability/effects/ChangeTargetsEffect","<init>","()V",1,1,1,new JHandler[]{},M3086));
c.Add(new JMethod(3087,"forge/game/ability/effects/ChangeTargetsEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M3087));
c.Add(new JMethod(3088,"forge/game/ability/effects/ChangeTargetsEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,22,9,new JHandler[]{},M3088));
c.Add(new JMethod(3089,"forge/game/ability/effects/ChangeTargetsEffect","lambda$resolve$0","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/GameObject;)Z",4106,3,5,new JHandler[]{},M3089));
}

internal static JStep M3086(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3087(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?22:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",16);}
case 16:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",22);}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3088(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/ChangeTargetsEffect","getTargetSpells","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("RandomTarget")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?36:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/ability/effects/ChangeTargetsEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",33);}
case 33:{f.Pc=37;continue;}
case 36:{f.Push(JValue.R(null));f.Pc=37;continue;}
case 37:{f.Locals[5]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Reference==null?55:44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int==0?55:54;continue;}
case 54:{return JStep.ReturnVoid;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{f.Pc=f.Pop().Reference==null?74:60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",68);}
case 68:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=71;continue;}
case 71:{f.Pc=76;continue;}
case 74:{f.Push(f.Locals[4]);f.Pc=76;continue;}
case 76:{f.Locals[6]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",83);}
case 83:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",86);}
case 86:{f.Locals[7]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",94);}
case 94:{f.Locals[8]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",103);}
case 103:{f.Pc=f.Pop().Int==0?1244:106;continue;}
case 106:{f.Push(f.Locals[8]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",113);}
case 113:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=116;continue;}
case 116:{f.Locals[9]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[7]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[9]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/zone/MagicStack","getInstanceMatchingSpellAbilityID","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",125);}
case 125:{f.Locals[10]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[10]);f.Pc=129;continue;}
case 129:{f.Pc=f.Pop().Reference!=null?135:132;continue;}
case 132:{f.Pc=96;continue;}
case 135:{f.Push(f.Locals[10]);f.Pc=137;continue;}
case 137:{f.Locals[11]=f.Pop();f.Pc=139;continue;}
case 139:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",142);}
case 142:{f.Locals[12]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("Optional")));f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?198:153;continue;}
case 153:{f.Push(f.Locals[6]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",158);}
case 158:{f.Push(f.Locals[1]);f.Pc=159;continue;}
case 159:{f.Push(JValue.R(null));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",163);}
case 163:{f.Push(JValue.R(rt.String("lblDoYouWantChangeAbilityTargets")));f.Pc=165;continue;}
case 165:{f.Push(JValue.I(1));f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=169;continue;}
case 169:{f.StackOp("dup");f.Pc=170;continue;}
case 170:{f.Push(JValue.I(0));f.Pc=171;continue;}
case 171:{f.Push(f.Locals[9]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",176);}
case 176:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",179);}
case 179:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",183);}
case 183:{f.Push(f.Locals[9]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",188);}
case 188:{f.Push(JValue.R(null));f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",192);}
case 192:{f.Pc=f.Pop().Int!=0?198:195;continue;}
case 195:{f.Pc=96;continue;}
case 198:{f.Push(f.Locals[1]);f.Pc=199;continue;}
case 199:{f.Push(JValue.R(rt.String("ChangeSingleTarget")));f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",204);}
case 204:{f.Pc=f.Pop().Int==0?443:207;continue;}
case 207:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=210;continue;}
case 210:{f.StackOp("dup");f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",214);}
case 214:{f.Locals[13]=f.Pop();f.Pc=216;continue;}
case 216:{f.Push(f.Locals[11]);f.Pc=218;continue;}
case 218:{f.Pc=f.Pop().Reference==null?296:221;continue;}
case 221:{f.Push(f.Locals[11]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",226);}
case 226:{f.Locals[14]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[14]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",233);}
case 233:{f.Pc=f.Pop().Int==0?286:236;continue;}
case 236:{f.Push(f.Locals[14]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",241);}
case 241:{return rt.Call(f,"forge/game/spellability/TargetChoices","iterator","()Ljava/util/Iterator;","invokevirtual",244);}
case 244:{f.Locals[15]=f.Pop();f.Pc=246;continue;}
case 246:{f.Push(f.Locals[15]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",253);}
case 253:{f.Pc=f.Pop().Int==0?286:256;continue;}
case 256:{f.Push(f.Locals[15]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",263);}
case 263:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=266;continue;}
case 266:{f.Locals[16]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[13]);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[11]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[16]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",277);}
case 277:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",282);}
case 282:{f.StackOp("pop");f.Pc=283;continue;}
case 283:{f.Pc=246;continue;}
case 286:{f.Push(f.Locals[11]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSubInstance","()Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",291);}
case 291:{f.Locals[11]=f.Pop();f.Pc=293;continue;}
case 293:{f.Pc=216;continue;}
case 296:{f.Push(f.Locals[13]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",303);}
case 303:{f.Pc=f.Pop().Int==0?307:306;continue;}
case 306:{return JStep.ReturnVoid;}
case 307:{f.Push(f.Locals[6]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",312);}
case 312:{f.Push(f.Locals[1]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[13]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/player/PlayerController","chooseTarget","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",318);}
case 318:{f.Locals[14]=f.Pop();f.Pc=320;continue;}
case 320:{f.Push(f.Locals[14]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",325);}
case 325:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=328;continue;}
case 328:{f.Locals[15]=f.Pop();f.Pc=330;continue;}
case 330:{f.Push(f.Locals[14]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getValue","()Ljava/lang/Object;","invokevirtual",335);}
case 335:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=338;continue;}
case 338:{f.Locals[16]=f.Pop();f.Pc=340;continue;}
case 340:{f.Push(f.Locals[15]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getTargetChoices","()Lforge/game/spellability/TargetChoices;","invokevirtual",345);}
case 345:{f.Locals[17]=f.Pop();f.Pc=347;continue;}
case 347:{f.Push(f.Locals[17]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/spellability/TargetChoices","clone","()Lforge/game/spellability/TargetChoices;","invokevirtual",352);}
case 352:{f.Locals[18]=f.Pop();f.Pc=354;continue;}
case 354:{f.Push(f.Locals[18]);f.Pc=356;continue;}
case 356:{f.Push(f.Locals[16]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/spellability/TargetChoices","getDividedValue","(Lforge/game/GameObject;)Ljava/lang/Integer;","invokevirtual",361);}
case 361:{f.Locals[19]=f.Pop();f.Pc=363;continue;}
case 363:{f.Push(f.Locals[1]);f.Pc=364;continue;}
case 364:{f.Push(JValue.R(rt.String("DefinedMagnet")));f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/ability/effects/ChangeTargetsEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",369);}
case 369:{f.Push(JValue.R(null));f.Pc=370;continue;}
case 370:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",373);}
case 373:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=376;continue;}
case 376:{f.Locals[20]=f.Pop();f.Pc=378;continue;}
case 378:{f.Push(f.Locals[18]);f.Pc=380;continue;}
case 380:{f.Push(f.Locals[20]);f.Pc=382;continue;}
case 382:{return rt.Call(f,"forge/game/spellability/TargetChoices","contains","(Ljava/lang/Object;)Z","invokevirtual",385);}
case 385:{f.Pc=f.Pop().Int!=0?440:388;continue;}
case 388:{f.Push(f.Locals[15]);f.Pc=390;continue;}
case 390:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",393);}
case 393:{f.Push(f.Locals[20]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;)Z","invokevirtual",398);}
case 398:{f.Pc=f.Pop().Int==0?440:401;continue;}
case 401:{f.Push(f.Locals[17]);f.Pc=403;continue;}
case 403:{f.Push(f.Locals[16]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/spellability/TargetChoices","remove","(Ljava/lang/Object;)Z","invokevirtual",408);}
case 408:{f.StackOp("pop");f.Pc=409;continue;}
case 409:{f.Push(f.Locals[17]);f.Pc=411;continue;}
case 411:{f.Push(f.Locals[20]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/spellability/TargetChoices","add","(Lforge/game/GameObject;)Z","invokevirtual",416);}
case 416:{f.StackOp("pop");f.Pc=417;continue;}
case 417:{f.Push(f.Locals[19]);f.Pc=419;continue;}
case 419:{f.Pc=f.Pop().Reference==null?431:422;continue;}
case 422:{f.Push(f.Locals[17]);f.Pc=424;continue;}
case 424:{f.Push(f.Locals[20]);f.Pc=426;continue;}
case 426:{f.Push(f.Locals[19]);f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/game/spellability/TargetChoices","addDividedAllocation","(Lforge/game/GameObject;Ljava/lang/Integer;)V","invokevirtual",431);}
case 431:{f.Push(f.Locals[15]);f.Pc=433;continue;}
case 433:{f.Push(f.Locals[18]);f.Pc=435;continue;}
case 435:{f.Push(f.Locals[12]);f.Pc=437;continue;}
case 437:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","updateTarget","(Lforge/game/spellability/TargetChoices;Ljava/util/Set;)V","invokevirtual",440);}
case 440:{f.Pc=997;continue;}
case 443:{f.Push(f.Locals[3]);f.Pc=444;continue;}
case 444:{f.Pc=f.Pop().Int==0?778:447;continue;}
case 447:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=450;continue;}
case 450:{f.StackOp("dup");f.Pc=451;continue;}
case 451:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",454);}
case 454:{f.Locals[13]=f.Pop();f.Pc=456;continue;}
case 456:{f.Push(JValue.I(1));f.Pc=457;continue;}
case 457:{f.Locals[14]=f.Pop();f.Pc=459;continue;}
case 459:{f.Push(f.Locals[11]);f.Pc=461;continue;}
case 461:{f.Pc=f.Pop().Reference==null?650:464;continue;}
case 464:{f.Push(f.Locals[11]);f.Pc=466;continue;}
case 466:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",469);}
case 469:{f.Locals[15]=f.Pop();f.Pc=471;continue;}
case 471:{f.Push(f.Locals[15]);f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",476);}
case 476:{f.Pc=f.Pop().Int==0?640:479;continue;}
case 479:{f.Push(f.Locals[15]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",484);}
case 484:{f.Push(f.Locals[15]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getAllCandidates","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokevirtual",489);}
case 489:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",492);}
case 492:{f.Locals[16]=f.Pop();f.Pc=494;continue;}
case 494:{f.Push(f.Locals[15]);f.Pc=496;continue;}
case 496:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",499);}
case 499:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getZone","()Ljava/util/List;","invokevirtual",502);}
case 502:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=505;continue;}
case 505:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",510);}
case 510:{f.Pc=f.Pop().Int==0?578:513;continue;}
case 513:{f.Push(f.Locals[4]);f.Pc=515;continue;}
case 515:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",518);}
case 518:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",521);}
case 521:{return rt.Call(f,"forge/game/zone/MagicStack","iterator","()Ljava/util/Iterator;","invokevirtual",524);}
case 524:{f.Locals[17]=f.Pop();f.Pc=526;continue;}
case 526:{f.Push(f.Locals[17]);f.Pc=528;continue;}
case 528:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",533);}
case 533:{f.Pc=f.Pop().Int==0?578:536;continue;}
case 536:{f.Push(f.Locals[17]);f.Pc=538;continue;}
case 538:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",543);}
case 543:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=546;continue;}
case 546:{f.Locals[18]=f.Pop();f.Pc=548;continue;}
case 548:{f.Push(f.Locals[18]);f.Pc=550;continue;}
case 550:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",553);}
case 553:{f.Locals[19]=f.Pop();f.Pc=555;continue;}
case 555:{f.Push(f.Locals[15]);f.Pc=557;continue;}
case 557:{f.Push(f.Locals[19]);f.Pc=559;continue;}
case 559:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTargetSpellAbility","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",562);}
case 562:{f.Pc=f.Pop().Int==0?575:565;continue;}
case 565:{f.Push(f.Locals[16]);f.Pc=567;continue;}
case 567:{f.Push(f.Locals[19]);f.Pc=569;continue;}
case 569:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",574);}
case 574:{f.StackOp("pop");f.Pc=575;continue;}
case 575:{f.Pc=526;continue;}
case 578:{f.Push(f.Locals[1]);f.Pc=579;continue;}
case 579:{f.Push(JValue.R(rt.String("RandomTargetRestriction")));f.Pc=581;continue;}
case 581:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",584);}
case 584:{f.Pc=f.Pop().Int==0?603:587;continue;}
case 587:{f.Push(f.Locals[16]);f.Pc=589;continue;}
case 589:{f.Push(f.Locals[1]);f.Pc=590;continue;}
case 590:{f.Push(f.Locals[4]);f.Pc=592;continue;}
case 592:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeTargetsEffect:3088:592:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Ljava/util/function/Predicate;",597);}
case 597:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",602);}
case 602:{f.StackOp("pop");f.Pc=603;continue;}
case 603:{f.Push(f.Locals[16]);f.Pc=605;continue;}
case 605:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",610);}
case 610:{f.Pc=f.Pop().Int==0?619:613;continue;}
case 613:{f.Push(JValue.I(0));f.Pc=614;continue;}
case 614:{f.Locals[14]=f.Pop();f.Pc=616;continue;}
case 616:{f.Pc=650;continue;}
case 619:{f.Push(f.Locals[13]);f.Pc=621;continue;}
case 621:{f.Push(f.Locals[11]);f.Pc=623;continue;}
case 623:{f.Push(f.Locals[16]);f.Pc=625;continue;}
case 625:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",628);}
case 628:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=631;continue;}
case 631:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;","invokestatic",634);}
case 634:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",639);}
case 639:{f.StackOp("pop");f.Pc=640;continue;}
case 640:{f.Push(f.Locals[11]);f.Pc=642;continue;}
case 642:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSubInstance","()Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",645);}
case 645:{f.Locals[11]=f.Pop();f.Pc=647;continue;}
case 647:{f.Pc=459;continue;}
case 650:{f.Push(f.Locals[14]);f.Pc=652;continue;}
case 652:{f.Pc=f.Pop().Int==0?775:655;continue;}
case 655:{f.Push(f.Locals[13]);f.Pc=657;continue;}
case 657:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",662);}
case 662:{f.Locals[15]=f.Pop();f.Pc=664;continue;}
case 664:{f.Push(f.Locals[15]);f.Pc=666;continue;}
case 666:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",671);}
case 671:{f.Pc=f.Pop().Int==0?775:674;continue;}
case 674:{f.Push(f.Locals[15]);f.Pc=676;continue;}
case 676:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",681);}
case 681:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=684;continue;}
case 684:{f.Locals[16]=f.Pop();f.Pc=686;continue;}
case 686:{f.Push(f.Locals[16]);f.Pc=688;continue;}
case 688:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",691);}
case 691:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=694;continue;}
case 694:{f.Locals[17]=f.Pop();f.Pc=696;continue;}
case 696:{f.Push(f.Locals[17]);f.Pc=698;continue;}
case 698:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",701);}
case 701:{f.Locals[18]=f.Pop();f.Pc=703;continue;}
case 703:{f.Push(f.Locals[16]);f.Pc=705;continue;}
case 705:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getValue","()Ljava/lang/Object;","invokevirtual",708);}
case 708:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=711;continue;}
case 711:{f.Locals[19]=f.Pop();f.Pc=713;continue;}
case 713:{f.Push(f.Locals[18]);f.Pc=715;continue;}
case 715:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",718);}
case 718:{f.Locals[20]=f.Pop();f.Pc=720;continue;}
case 720:{f.Push(f.Locals[18]);f.Pc=722;continue;}
case 722:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTotalDividedValue","()I","invokevirtual",725);}
case 725:{f.Locals[21]=f.Pop();f.Pc=727;continue;}
case 727:{f.Push(f.Locals[18]);f.Pc=729;continue;}
case 729:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetTargets","()V","invokevirtual",732);}
case 732:{f.Push(f.Locals[18]);f.Pc=734;continue;}
case 734:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",737);}
case 737:{f.Push(f.Locals[19]);f.Pc=739;continue;}
case 739:{return rt.Call(f,"forge/game/spellability/TargetChoices","add","(Lforge/game/GameObject;)Z","invokevirtual",742);}
case 742:{f.StackOp("pop");f.Pc=743;continue;}
case 743:{f.Push(f.Locals[18]);f.Pc=745;continue;}
case 745:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",748);}
case 748:{f.Pc=f.Pop().Int==0?763:751;continue;}
case 751:{f.Push(f.Locals[18]);f.Pc=753;continue;}
case 753:{f.Push(f.Locals[19]);f.Pc=755;continue;}
case 755:{f.Push(f.Locals[21]);f.Pc=757;continue;}
case 757:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",760);}
case 760:{return rt.Call(f,"forge/game/spellability/SpellAbility","addDividedAllocation","(Lforge/game/GameObject;Ljava/lang/Integer;)V","invokevirtual",763);}
case 763:{f.Push(f.Locals[17]);f.Pc=765;continue;}
case 765:{f.Push(f.Locals[20]);f.Pc=767;continue;}
case 767:{f.Push(f.Locals[12]);f.Pc=769;continue;}
case 769:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","updateTarget","(Lforge/game/spellability/TargetChoices;Ljava/util/Set;)V","invokevirtual",772);}
case 772:{f.Pc=664;continue;}
case 775:{f.Pc=997;continue;}
case 778:{f.Push(f.Locals[11]);f.Pc=780;continue;}
case 780:{f.Pc=f.Pop().Reference==null?997:783;continue;}
case 783:{f.Push(f.Locals[11]);f.Pc=785;continue;}
case 785:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",788);}
case 788:{f.Locals[13]=f.Pop();f.Pc=790;continue;}
case 790:{f.Push(f.Locals[13]);f.Pc=792;continue;}
case 792:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",795);}
case 795:{f.Pc=f.Pop().Int==0?987:798;continue;}
case 798:{f.Push(f.Locals[1]);f.Pc=799;continue;}
case 799:{f.Push(JValue.R(rt.String("DefinedMagnet")));f.Pc=801;continue;}
case 801:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",804);}
case 804:{f.Pc=f.Pop().Int==0?899:807;continue;}
case 807:{f.Push(f.Locals[1]);f.Pc=808;continue;}
case 808:{f.Push(JValue.R(rt.String("DefinedMagnet")));f.Pc=810;continue;}
case 810:{return rt.Call(f,"forge/game/ability/effects/ChangeTargetsEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",813);}
case 813:{f.Push(JValue.R(null));f.Pc=814;continue;}
case 814:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",817);}
case 817:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=820;continue;}
case 820:{f.Locals[14]=f.Pop();f.Pc=822;continue;}
case 822:{f.Push(f.Locals[14]);f.Pc=824;continue;}
case 824:{f.Pc=f.Pop().Reference==null?896:827;continue;}
case 827:{f.Push(f.Locals[13]);f.Pc=829;continue;}
case 829:{f.Push(f.Locals[14]);f.Pc=831;continue;}
case 831:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;)Z","invokevirtual",834);}
case 834:{f.Pc=f.Pop().Int==0?896:837;continue;}
case 837:{f.Push(f.Locals[13]);f.Pc=839;continue;}
case 839:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTotalDividedValue","()I","invokevirtual",842);}
case 842:{f.Locals[15]=f.Pop();f.Pc=844;continue;}
case 844:{f.Push(f.Locals[13]);f.Pc=846;continue;}
case 846:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",849);}
case 849:{f.Locals[16]=f.Pop();f.Pc=851;continue;}
case 851:{f.Push(f.Locals[13]);f.Pc=853;continue;}
case 853:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetTargets","()V","invokevirtual",856);}
case 856:{f.Push(f.Locals[13]);f.Pc=858;continue;}
case 858:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",861);}
case 861:{f.Push(f.Locals[14]);f.Pc=863;continue;}
case 863:{return rt.Call(f,"forge/game/spellability/TargetChoices","add","(Lforge/game/GameObject;)Z","invokevirtual",866);}
case 866:{f.StackOp("pop");f.Pc=867;continue;}
case 867:{f.Push(f.Locals[13]);f.Pc=869;continue;}
case 869:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",872);}
case 872:{f.Pc=f.Pop().Int==0?887:875;continue;}
case 875:{f.Push(f.Locals[13]);f.Pc=877;continue;}
case 877:{f.Push(f.Locals[14]);f.Pc=879;continue;}
case 879:{f.Push(f.Locals[15]);f.Pc=881;continue;}
case 881:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",884);}
case 884:{return rt.Call(f,"forge/game/spellability/SpellAbility","addDividedAllocation","(Lforge/game/GameObject;Ljava/lang/Integer;)V","invokevirtual",887);}
case 887:{f.Push(f.Locals[11]);f.Pc=889;continue;}
case 889:{f.Push(f.Locals[16]);f.Pc=891;continue;}
case 891:{f.Push(f.Locals[12]);f.Pc=893;continue;}
case 893:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","updateTarget","(Lforge/game/spellability/TargetChoices;Ljava/util/Set;)V","invokevirtual",896);}
case 896:{f.Pc=987;continue;}
case 899:{f.Push(f.Locals[1]);f.Pc=900;continue;}
case 900:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",903);}
case 903:{f.Locals[14]=f.Pop();f.Pc=905;continue;}
case 905:{f.Push(f.Locals[13]);f.Pc=907;continue;}
case 907:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetCard","()Lforge/game/card/Card;","invokevirtual",910);}
case 910:{f.Pc=f.Pop().Reference==null?920:913;continue;}
case 913:{f.Push(f.Locals[13]);f.Pc=915;continue;}
case 915:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetCard","()Lforge/game/card/Card;","invokevirtual",918);}
case 918:{f.Locals[14]=f.Pop();f.Pc=920;continue;}
case 920:{f.Push(f.Locals[1]);f.Pc=921;continue;}
case 921:{f.Push(JValue.R(rt.String("TargetRestriction")));f.Pc=924;continue;}
case 924:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",927);}
case 927:{f.Pc=f.Pop().Int==0?954:930;continue;}
case 930:{f.Push(f.Locals[1]);f.Pc=931;continue;}
case 931:{f.Push(JValue.R(rt.String("TargetRestriction")));f.Pc=934;continue;}
case 934:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",937);}
case 937:{f.Push(JValue.R(rt.String(",")));f.Pc=940;continue;}
case 940:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",943);}
case 943:{f.Push(f.Locals[4]);f.Pc=945;continue;}
case 945:{f.Push(f.Locals[14]);f.Pc=947;continue;}
case 947:{f.Push(f.Locals[1]);f.Pc=948;continue;}
case 948:{return rt.Call(f,"forge/game/GameObjectPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",951);}
case 951:{f.Pc=955;continue;}
case 954:{f.Push(JValue.R(null));f.Pc=955;continue;}
case 955:{f.Locals[15]=f.Pop();f.Pc=957;continue;}
case 957:{f.Push(f.Locals[13]);f.Pc=959;continue;}
case 959:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",962);}
case 962:{f.Locals[16]=f.Pop();f.Pc=964;continue;}
case 964:{f.Push(f.Locals[6]);f.Pc=966;continue;}
case 966:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",969);}
case 969:{f.Push(f.Locals[13]);f.Pc=971;continue;}
case 971:{f.Push(f.Locals[15]);f.Pc=973;continue;}
case 973:{f.Push(JValue.I(0));f.Pc=974;continue;}
case 974:{return rt.Call(f,"forge/game/player/PlayerController","chooseNewTargetsFor","(Lforge/game/spellability/SpellAbility;Ljava/util/function/Predicate;Z)Lforge/game/spellability/TargetChoices;","invokevirtual",977);}
case 977:{f.StackOp("pop");f.Pc=978;continue;}
case 978:{f.Push(f.Locals[11]);f.Pc=980;continue;}
case 980:{f.Push(f.Locals[16]);f.Pc=982;continue;}
case 982:{f.Push(f.Locals[12]);f.Pc=984;continue;}
case 984:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","updateTarget","(Lforge/game/spellability/TargetChoices;Ljava/util/Set;)V","invokevirtual",987);}
case 987:{f.Push(f.Locals[11]);f.Pc=989;continue;}
case 989:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSubInstance","()Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",992);}
case 992:{f.Locals[11]=f.Pop();f.Pc=994;continue;}
case 994:{f.Pc=778;continue;}
case 997:{f.Push(f.Locals[12]);f.Pc=999;continue;}
case 999:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",1004);}
case 1004:{f.Locals[13]=f.Pop();f.Pc=1006;continue;}
case 1006:{f.Push(f.Locals[13]);f.Pc=1008;continue;}
case 1008:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1013);}
case 1013:{f.Pc=f.Pop().Int==0?1149:1016;continue;}
case 1016:{f.Push(f.Locals[13]);f.Pc=1018;continue;}
case 1018:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1023);}
case 1023:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1026;continue;}
case 1026:{f.Locals[14]=f.Pop();f.Pc=1028;continue;}
case 1028:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1031);}
case 1031:{f.Locals[15]=f.Pop();f.Pc=1033;continue;}
case 1033:{f.Push(f.Locals[15]);f.Pc=1035;continue;}
case 1035:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SourceSA","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SourceSA","Lforge/game/ability/AbilityKey;"));f.Pc=1038;continue;}
case 1038:{f.Push(f.Locals[9]);f.Pc=1040;continue;}
case 1040:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1045);}
case 1045:{f.StackOp("pop");f.Pc=1046;continue;}
case 1046:{f.Push(f.Locals[15]);f.Pc=1048;continue;}
case 1048:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Target","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Target","Lforge/game/ability/AbilityKey;"));f.Pc=1051;continue;}
case 1051:{f.Push(f.Locals[14]);f.Pc=1053;continue;}
case 1053:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1058);}
case 1058:{f.StackOp("pop");f.Pc=1059;continue;}
case 1059:{f.Push(f.Locals[14]);f.Pc=1061;continue;}
case 1061:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1064;continue;}
case 1064:{f.Pc=f.Pop().Int==0?1129:1067;continue;}
case 1067:{f.Push(f.Locals[14]);f.Pc=1069;continue;}
case 1069:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1072;continue;}
case 1072:{f.Locals[16]=f.Pop();f.Pc=1074;continue;}
case 1074:{f.Push(f.Locals[16]);f.Pc=1076;continue;}
case 1076:{return rt.Call(f,"forge/game/card/Card","hasBecomeTargetThisTurn","()Z","invokevirtual",1079);}
case 1079:{f.Pc=f.Pop().Int!=0?1094:1082;continue;}
case 1082:{f.Push(f.Locals[15]);f.Pc=1084;continue;}
case 1084:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","FirstTime","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","FirstTime","Lforge/game/ability/AbilityKey;"));f.Pc=1087;continue;}
case 1087:{f.Push(JValue.R(null));f.Pc=1088;continue;}
case 1088:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1093);}
case 1093:{f.StackOp("pop");f.Pc=1094;continue;}
case 1094:{f.Push(f.Locals[16]);f.Pc=1096;continue;}
case 1096:{f.Push(f.Locals[9]);f.Pc=1098;continue;}
case 1098:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",1101);}
case 1101:{return rt.Call(f,"forge/game/card/Card","isValiant","(Lforge/game/player/Player;)Z","invokevirtual",1104);}
case 1104:{f.Pc=f.Pop().Int==0?1119:1107;continue;}
case 1107:{f.Push(f.Locals[15]);f.Pc=1109;continue;}
case 1109:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Valiant","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Valiant","Lforge/game/ability/AbilityKey;"));f.Pc=1112;continue;}
case 1112:{f.Push(JValue.R(null));f.Pc=1113;continue;}
case 1113:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1118);}
case 1118:{f.StackOp("pop");f.Pc=1119;continue;}
case 1119:{f.Push(f.Locals[16]);f.Pc=1121;continue;}
case 1121:{f.Push(f.Locals[9]);f.Pc=1123;continue;}
case 1123:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",1126);}
case 1126:{return rt.Call(f,"forge/game/card/Card","addTargetFromThisTurn","(Lforge/game/player/Player;)V","invokevirtual",1129);}
case 1129:{f.Push(f.Locals[4]);f.Pc=1131;continue;}
case 1131:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1134);}
case 1134:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1137);}
case 1137:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","BecomesTarget","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","BecomesTarget","Lforge/game/trigger/TriggerType;"));f.Pc=1140;continue;}
case 1140:{f.Push(f.Locals[15]);f.Pc=1142;continue;}
case 1142:{f.Push(JValue.I(0));f.Pc=1143;continue;}
case 1143:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1146);}
case 1146:{f.Pc=1006;continue;}
case 1149:{f.Push(f.Locals[12]);f.Pc=1151;continue;}
case 1151:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",1156);}
case 1156:{f.Pc=f.Pop().Int!=0?1241:1159;continue;}
case 1159:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1162);}
case 1162:{f.Locals[13]=f.Pop();f.Pc=1164;continue;}
case 1164:{f.Push(f.Locals[13]);f.Pc=1166;continue;}
case 1166:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SourceSA","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SourceSA","Lforge/game/ability/AbilityKey;"));f.Pc=1169;continue;}
case 1169:{f.Push(f.Locals[9]);f.Pc=1171;continue;}
case 1171:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1176);}
case 1176:{f.StackOp("pop");f.Pc=1177;continue;}
case 1177:{f.Push(f.Locals[13]);f.Pc=1179;continue;}
case 1179:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Targets","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Targets","Lforge/game/ability/AbilityKey;"));f.Pc=1182;continue;}
case 1182:{f.Push(f.Locals[12]);f.Pc=1184;continue;}
case 1184:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1189);}
case 1189:{f.StackOp("pop");f.Pc=1190;continue;}
case 1190:{f.Push(f.Locals[13]);f.Pc=1192;continue;}
case 1192:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=1195;continue;}
case 1195:{f.Push(f.Locals[1]);f.Pc=1196;continue;}
case 1196:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1199);}
case 1199:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1204);}
case 1204:{f.StackOp("pop");f.Pc=1205;continue;}
case 1205:{f.Push(f.Locals[3]);f.Pc=1206;continue;}
case 1206:{f.Pc=f.Pop().Int==0?1224:1209;continue;}
case 1209:{f.Push(f.Locals[13]);f.Pc=1211;continue;}
case 1211:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"));f.Pc=1214;continue;}
case 1214:{f.Push(JValue.I(1));f.Pc=1215;continue;}
case 1215:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",1218);}
case 1218:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1223);}
case 1223:{f.StackOp("pop");f.Pc=1224;continue;}
case 1224:{f.Push(f.Locals[4]);f.Pc=1226;continue;}
case 1226:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1229);}
case 1229:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1232);}
case 1232:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","BecomesTargetOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","BecomesTargetOnce","Lforge/game/trigger/TriggerType;"));f.Pc=1235;continue;}
case 1235:{f.Push(f.Locals[13]);f.Pc=1237;continue;}
case 1237:{f.Push(JValue.I(0));f.Pc=1238;continue;}
case 1238:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1241);}
case 1241:{f.Pc=96;continue;}
case 1244:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3089(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("RandomTargetRestriction")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(JValue.R(rt.String(",")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",13);}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/GameObject","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int!=0?31:27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{f.Pc=32;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

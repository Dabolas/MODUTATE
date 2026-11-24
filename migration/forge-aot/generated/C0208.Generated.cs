// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C208{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AttachEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3046,"forge/game/ability/effects/AttachEffect","<init>","()V",1,1,1,new JHandler[]{},M3046));
c.Add(new JMethod(3047,"forge/game/ability/effects/AttachEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,15,6,new JHandler[]{},M3047));
c.Add(new JMethod(3048,"forge/game/ability/effects/AttachEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,7,5,new JHandler[]{},M3048));
}

internal static JStep M3046(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3047(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Locals[6]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?48:28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",39);}
case 39:{f.Push(JValue.R(null));f.Pc=40;continue;}
case 40:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("Object")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?73:57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("Object")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",64);}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",68);}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Pc=240;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("Choices")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?230:82;continue;}
case 82:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=85;continue;}
case 85:{f.Locals[7]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?107:96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",102);}
case 102:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",105);}
case 105:{f.Locals[7]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?125:116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",122);}
case 122:{f.Pc=142;continue;}
case 125:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",128);}
case 128:{f.Push(JValue.R(rt.String("lblChoose")));f.Pc=130;continue;}
case 130:{f.Push(JValue.I(0));f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",137);}
case 137:{return rt.DynamicCall(f,"forge/game/ability/effects/AttachEffect:3047:137:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",142);}
case 142:{f.Locals[8]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[4]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[7]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",151);}
case 151:{f.Push(f.Locals[1]);f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("Choices")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",157);}
case 157:{f.Push(f.Locals[2]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[3]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",163);}
case 163:{f.Locals[9]=f.Pop();f.Pc=165;continue;}
case 165:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",168);}
case 168:{f.Locals[10]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[10]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("Target")));f.Pc=174;continue;}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.String("Defined")));f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/ability/effects/AttachEffect","getDefinedEntitiesOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;","invokestatic",180);}
case 180:{f.Push(JValue.R(null));f.Pc=181;continue;}
case 181:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",184);}
case 184:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",189);}
case 189:{f.StackOp("pop");f.Pc=190;continue;}
case 190:{f.Push(f.Locals[6]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",195);}
case 195:{f.Push(f.Locals[9]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[1]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[8]);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[10]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",205);}
case 205:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=208;continue;}
case 208:{f.Locals[11]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[11]);f.Pc=212;continue;}
case 212:{f.Pc=f.Pop().Reference!=null?216:215;continue;}
case 215:{return JStep.ReturnVoid;}
case 216:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=219;continue;}
case 219:{f.StackOp("dup");f.Pc=220;continue;}
case 220:{f.Push(f.Locals[11]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",225);}
case 225:{f.Locals[5]=f.Pop();f.Pc=227;continue;}
case 227:{f.Pc=240;continue;}
case 230:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=233;continue;}
case 233:{f.StackOp("dup");f.Pc=234;continue;}
case 234:{f.Push(f.Locals[3]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",238);}
case 238:{f.Locals[5]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[5]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",247);}
case 247:{f.Pc=f.Pop().Int==0?251:250;continue;}
case 250:{return JStep.ReturnVoid;}
case 251:{f.Push(f.Locals[1]);f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.String("Object")));f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Int==0?601:260;continue;}
case 260:{f.Push(f.Locals[1]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String("Choices")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",266);}
case 266:{f.Pc=f.Pop().Int!=0?278:269;continue;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("PlayerChoices")));f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",275);}
case 275:{f.Pc=f.Pop().Int==0?601:278;continue;}
case 278:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=281;continue;}
case 281:{f.Locals[8]=f.Pop();f.Pc=283;continue;}
case 283:{f.Push(f.Locals[1]);f.Pc=284;continue;}
case 284:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",289);}
case 289:{f.Pc=f.Pop().Int==0?303:292;continue;}
case 292:{f.Push(f.Locals[1]);f.Pc=293;continue;}
case 293:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",298);}
case 298:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",301);}
case 301:{f.Locals[8]=f.Pop();f.Pc=303;continue;}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",309);}
case 309:{f.Pc=f.Pop().Int==0?321:312;continue;}
case 312:{f.Push(f.Locals[1]);f.Pc=313;continue;}
case 313:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",318);}
case 318:{f.Pc=338;continue;}
case 321:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",324);}
case 324:{f.Push(JValue.R(rt.String("lblChoose")));f.Pc=326;continue;}
case 326:{f.Push(JValue.I(0));f.Pc=327;continue;}
case 327:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",333);}
case 333:{return rt.DynamicCall(f,"forge/game/ability/effects/AttachEffect:3047:333:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",338);}
case 338:{f.Locals[9]=f.Pop();f.Pc=340;continue;}
case 340:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=343;continue;}
case 343:{f.StackOp("dup");f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",347);}
case 347:{f.Locals[10]=f.Pop();f.Pc=349;continue;}
case 349:{f.Push(f.Locals[1]);f.Pc=350;continue;}
case 350:{f.Push(JValue.R(rt.String("PlayerChoices")));f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",355);}
case 355:{f.Pc=f.Pop().Int==0?459:358;continue;}
case 358:{f.Push(f.Locals[3]);f.Pc=359;continue;}
case 359:{f.Push(f.Locals[1]);f.Pc=360;continue;}
case 360:{f.Push(JValue.R(rt.String("PlayerChoices")));f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",365);}
case 365:{f.Push(f.Locals[1]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",369);}
case 369:{f.Locals[10]=f.Pop();f.Pc=371;continue;}
case 371:{f.Push(f.Locals[5]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",378);}
case 378:{f.Locals[11]=f.Pop();f.Pc=380;continue;}
case 380:{f.Push(f.Locals[11]);f.Pc=382;continue;}
case 382:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",387);}
case 387:{f.Pc=f.Pop().Int==0?456:390;continue;}
case 390:{f.Push(f.Locals[11]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",397);}
case 397:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=400;continue;}
case 400:{f.Locals[12]=f.Pop();f.Pc=402;continue;}
case 402:{f.Push(f.Locals[10]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",407);}
case 407:{f.Locals[13]=f.Pop();f.Pc=409;continue;}
case 409:{f.Push(f.Locals[13]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",416);}
case 416:{f.Pc=f.Pop().Int==0?453:419;continue;}
case 419:{f.Push(f.Locals[13]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",426);}
case 426:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=429;continue;}
case 429:{f.Locals[14]=f.Pop();f.Pc=431;continue;}
case 431:{f.Push(f.Locals[14]);f.Pc=433;continue;}
case 433:{f.Push(f.Locals[12]);f.Pc=435;continue;}
case 435:{f.Push(f.Locals[1]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/GameEntity","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",439);}
case 439:{f.Pc=f.Pop().Int!=0?450:442;continue;}
case 442:{f.Push(f.Locals[10]);f.Pc=444;continue;}
case 444:{f.Push(f.Locals[14]);f.Pc=446;continue;}
case 446:{return rt.Call(f,"forge/util/collect/FCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",449);}
case 449:{f.StackOp("pop");f.Pc=450;continue;}
case 450:{f.Pc=409;continue;}
case 453:{f.Pc=380;continue;}
case 456:{f.Pc=564;continue;}
case 459:{f.Push(f.Locals[4]);f.Pc=461;continue;}
case 461:{f.Push(f.Locals[8]);f.Pc=463;continue;}
case 463:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",466);}
case 466:{f.Push(f.Locals[1]);f.Pc=467;continue;}
case 467:{f.Push(JValue.R(rt.String("Choices")));f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",472);}
case 472:{f.Push(f.Locals[2]);f.Pc=473;continue;}
case 473:{f.Push(f.Locals[3]);f.Pc=474;continue;}
case 474:{f.Push(f.Locals[1]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",478);}
case 478:{f.Locals[11]=f.Pop();f.Pc=480;continue;}
case 480:{f.Push(f.Locals[5]);f.Pc=482;continue;}
case 482:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",487);}
case 487:{f.Locals[12]=f.Pop();f.Pc=489;continue;}
case 489:{f.Push(f.Locals[12]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",496);}
case 496:{f.Pc=f.Pop().Int==0?556:499;continue;}
case 499:{f.Push(f.Locals[12]);f.Pc=501;continue;}
case 501:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",506);}
case 506:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=509;continue;}
case 509:{f.Locals[13]=f.Pop();f.Pc=511;continue;}
case 511:{f.Push(f.Locals[1]);f.Pc=512;continue;}
case 512:{f.Push(JValue.R(rt.String("Move")));f.Pc=514;continue;}
case 514:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",517);}
case 517:{f.Pc=f.Pop().Int==0?540:520;continue;}
case 520:{f.Push(f.Locals[13]);f.Pc=522;continue;}
case 522:{return rt.Call(f,"forge/game/card/Card","getAttachedTo","()Lforge/game/card/Card;","invokevirtual",525);}
case 525:{f.Locals[14]=f.Pop();f.Pc=527;continue;}
case 527:{f.Push(f.Locals[14]);f.Pc=529;continue;}
case 529:{f.Pc=f.Pop().Reference==null?540:532;continue;}
case 532:{f.Push(f.Locals[11]);f.Pc=534;continue;}
case 534:{f.Push(f.Locals[14]);f.Pc=536;continue;}
case 536:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",539);}
case 539:{f.StackOp("pop");f.Pc=540;continue;}
case 540:{f.Push(f.Locals[11]);f.Pc=542;continue;}
case 542:{f.Push(f.Locals[13]);f.Pc=544;continue;}
case 544:{f.Push(f.Locals[1]);f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/game/card/CardPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;","invokestatic",548);}
case 548:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",551);}
case 551:{f.Locals[11]=f.Pop();f.Pc=553;continue;}
case 553:{f.Pc=489;continue;}
case 556:{f.Push(f.Locals[10]);f.Pc=558;continue;}
case 558:{f.Push(f.Locals[11]);f.Pc=560;continue;}
case 560:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",563);}
case 563:{f.StackOp("pop");f.Pc=564;continue;}
case 564:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",567);}
case 567:{f.Locals[11]=f.Pop();f.Pc=569;continue;}
case 569:{f.Push(f.Locals[11]);f.Pc=571;continue;}
case 571:{f.Push(JValue.R(rt.String("Attachments")));f.Pc=573;continue;}
case 573:{f.Push(f.Locals[5]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",580);}
case 580:{f.StackOp("pop");f.Pc=581;continue;}
case 581:{f.Push(f.Locals[6]);f.Pc=583;continue;}
case 583:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",586);}
case 586:{f.Push(f.Locals[10]);f.Pc=588;continue;}
case 588:{f.Push(f.Locals[1]);f.Pc=589;continue;}
case 589:{f.Push(f.Locals[9]);f.Pc=591;continue;}
case 591:{f.Push(f.Locals[11]);f.Pc=593;continue;}
case 593:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",596);}
case 596:{f.Locals[7]=f.Pop();f.Pc=598;continue;}
case 598:{f.Pc=673;continue;}
case 601:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=604;continue;}
case 604:{f.StackOp("dup");f.Pc=605;continue;}
case 605:{f.Push(f.Locals[1]);f.Pc=606;continue;}
case 606:{f.Push(JValue.R(rt.String("Defined")));f.Pc=608;continue;}
case 608:{return rt.Call(f,"forge/game/ability/effects/AttachEffect","getDefinedEntitiesOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;","invokestatic",611);}
case 611:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",614);}
case 614:{f.Locals[8]=f.Pop();f.Pc=616;continue;}
case 616:{f.Push(f.Locals[8]);f.Pc=618;continue;}
case 618:{return rt.Call(f,"forge/util/collect/FCollection","isEmpty","()Z","invokevirtual",621);}
case 621:{f.Pc=f.Pop().Int==0?625:624;continue;}
case 624:{return JStep.ReturnVoid;}
case 625:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",628);}
case 628:{f.Push(JValue.R(rt.String("lblChoose")));f.Pc=630;continue;}
case 630:{f.Push(JValue.I(0));f.Pc=631;continue;}
case 631:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=634;continue;}
case 634:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",637);}
case 637:{f.Locals[9]=f.Pop();f.Pc=639;continue;}
case 639:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",642);}
case 642:{f.Locals[10]=f.Pop();f.Pc=644;continue;}
case 644:{f.Push(f.Locals[10]);f.Pc=646;continue;}
case 646:{f.Push(JValue.R(rt.String("Attachments")));f.Pc=648;continue;}
case 648:{f.Push(f.Locals[5]);f.Pc=650;continue;}
case 650:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",655);}
case 655:{f.StackOp("pop");f.Pc=656;continue;}
case 656:{f.Push(f.Locals[6]);f.Pc=658;continue;}
case 658:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",661);}
case 661:{f.Push(f.Locals[8]);f.Pc=663;continue;}
case 663:{f.Push(f.Locals[1]);f.Pc=664;continue;}
case 664:{f.Push(f.Locals[9]);f.Pc=666;continue;}
case 666:{f.Push(f.Locals[10]);f.Pc=668;continue;}
case 668:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",671);}
case 671:{f.Locals[7]=f.Pop();f.Pc=673;continue;}
case 673:{f.Push(f.Locals[7]);f.Pc=675;continue;}
case 675:{f.Pc=f.Pop().Reference!=null?679:678;continue;}
case 678:{return JStep.ReturnVoid;}
case 679:{f.Push(f.Locals[7]);f.Pc=681;continue;}
case 681:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=684;continue;}
case 684:{f.Pc=f.Pop().Int==0?704:687;continue;}
case 687:{f.Push(f.Locals[7]);f.Pc=689;continue;}
case 689:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=692;continue;}
case 692:{f.Locals[9]=f.Pop();f.Pc=694;continue;}
case 694:{f.Push(f.Locals[9]);f.Pc=696;continue;}
case 696:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",699);}
case 699:{f.Locals[8]=f.Pop();f.Pc=701;continue;}
case 701:{f.Pc=711;continue;}
case 704:{f.Push(f.Locals[7]);f.Pc=706;continue;}
case 706:{return rt.Call(f,"forge/game/GameEntity","toString","()Ljava/lang/String;","invokevirtual",709);}
case 709:{f.Locals[8]=f.Pop();f.Pc=711;continue;}
case 711:{f.Push(f.Locals[4]);f.Pc=713;continue;}
case 713:{f.Push(f.Locals[5]);f.Pc=715;continue;}
case 715:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=718;continue;}
case 718:{f.Push(f.Locals[1]);f.Pc=719;continue;}
case 719:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",722);}
case 722:{f.Locals[5]=f.Pop();f.Pc=724;continue;}
case 724:{f.Push(f.Locals[5]);f.Pc=726;continue;}
case 726:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",731);}
case 731:{f.Locals[9]=f.Pop();f.Pc=733;continue;}
case 733:{f.Push(f.Locals[9]);f.Pc=735;continue;}
case 735:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",740);}
case 740:{f.Pc=f.Pop().Int==0?879:743;continue;}
case 743:{f.Push(f.Locals[9]);f.Pc=745;continue;}
case 745:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",750);}
case 750:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=753;continue;}
case 753:{f.Locals[10]=f.Pop();f.Pc=755;continue;}
case 755:{f.Push(f.Locals[10]);f.Pc=757;continue;}
case 757:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",760);}
case 760:{f.Push(f.Locals[10]);f.Pc=762;continue;}
case 762:{f.Push(JValue.R(null));f.Pc=763;continue;}
case 763:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",766);}
case 766:{f.Locals[11]=f.Pop();f.Pc=768;continue;}
case 768:{f.Push(f.Locals[11]);f.Pc=770;continue;}
case 770:{f.Pc=f.Pop().Reference==null?733:773;continue;}
case 773:{f.Push(f.Locals[10]);f.Pc=775;continue;}
case 775:{f.Push(f.Locals[11]);f.Pc=777;continue;}
case 777:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",780);}
case 780:{f.Pc=f.Pop().Int!=0?786:783;continue;}
case 783:{f.Pc=733;continue;}
case 786:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",789);}
case 789:{f.Push(JValue.R(rt.String("lblDoYouWantAttachSourceToTarget")));f.Pc=791;continue;}
case 791:{f.Push(JValue.I(2));f.Pc=792;continue;}
case 792:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=795;continue;}
case 795:{f.StackOp("dup");f.Pc=796;continue;}
case 796:{f.Push(JValue.I(0));f.Pc=797;continue;}
case 797:{f.Push(f.Locals[10]);f.Pc=799;continue;}
case 799:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",802);}
case 802:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=803;continue;}
case 803:{f.StackOp("dup");f.Pc=804;continue;}
case 804:{f.Push(JValue.I(1));f.Pc=805;continue;}
case 805:{f.Push(f.Locals[8]);f.Pc=807;continue;}
case 807:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=808;continue;}
case 808:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",811);}
case 811:{f.Locals[12]=f.Pop();f.Pc=813;continue;}
case 813:{f.Push(f.Locals[1]);f.Pc=814;continue;}
case 814:{f.Push(JValue.R(rt.String("Optional")));f.Pc=816;continue;}
case 816:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",819);}
case 819:{f.Pc=f.Pop().Int==0?843:822;continue;}
case 822:{f.Push(f.Locals[6]);f.Pc=824;continue;}
case 824:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",827);}
case 827:{f.Push(f.Locals[1]);f.Pc=828;continue;}
case 828:{f.Push(JValue.R(null));f.Pc=829;continue;}
case 829:{f.Push(f.Locals[12]);f.Pc=831;continue;}
case 831:{f.Push(f.Locals[11]);f.Pc=833;continue;}
case 833:{f.Push(JValue.R(null));f.Pc=834;continue;}
case 834:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",837);}
case 837:{f.Pc=f.Pop().Int!=0?843:840;continue;}
case 840:{f.Pc=733;continue;}
case 843:{f.Push(f.Locals[10]);f.Pc=845;continue;}
case 845:{f.Push(f.Locals[7]);f.Pc=847;continue;}
case 847:{f.Push(f.Locals[1]);f.Pc=848;continue;}
case 848:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)V","invokevirtual",851);}
case 851:{f.Push(f.Locals[1]);f.Pc=852;continue;}
case 852:{f.Push(JValue.R(rt.String("RememberAttached")));f.Pc=854;continue;}
case 854:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",857);}
case 857:{f.Pc=f.Pop().Int==0?876:860;continue;}
case 860:{f.Push(f.Locals[10]);f.Pc=862;continue;}
case 862:{f.Push(f.Locals[7]);f.Pc=864;continue;}
case 864:{return rt.Call(f,"forge/game/card/Card","isAttachedToEntity","(Lforge/game/GameEntity;)Z","invokevirtual",867);}
case 867:{f.Pc=f.Pop().Int==0?876:870;continue;}
case 870:{f.Push(f.Locals[3]);f.Pc=871;continue;}
case 871:{f.Push(f.Locals[10]);f.Pc=873;continue;}
case 873:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",876);}
case 876:{f.Pc=733;continue;}
case 879:{f.Push(f.Locals[3]);f.Pc=880;continue;}
case 880:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",883);}
case 883:{f.Pc=f.Pop().Int==0?1009:886;continue;}
case 886:{f.Push(f.Locals[1]);f.Pc=887;continue;}
case 887:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",890);}
case 890:{f.Pc=f.Pop().Int==0?1009:893;continue;}
case 893:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=896;continue;}
case 896:{f.StackOp("dup");f.Pc=897;continue;}
case 897:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",900);}
case 900:{f.Locals[9]=f.Pop();f.Pc=902;continue;}
case 902:{f.Push(f.Locals[3]);f.Pc=903;continue;}
case 903:{f.Push(f.Locals[2]);f.Pc=904;continue;}
case 904:{f.Push(JValue.L(0));f.Pc=905;continue;}
case 905:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",908);}
case 908:{f.Push(f.Locals[3]);f.Pc=909;continue;}
case 909:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",912);}
case 912:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",915);}
case 915:{f.Locals[10]=f.Pop();f.Pc=917;continue;}
case 917:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",920);}
case 920:{f.Locals[11]=f.Pop();f.Pc=922;continue;}
case 922:{f.Push(f.Locals[11]);f.Pc=924;continue;}
case 924:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=927;continue;}
case 927:{f.Push(f.Locals[4]);f.Pc=929;continue;}
case 929:{return rt.Call(f,"forge/game/Game","copyLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",932);}
case 932:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",937);}
case 937:{f.StackOp("pop");f.Pc=938;continue;}
case 938:{f.Push(f.Locals[11]);f.Pc=940;continue;}
case 940:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=943;continue;}
case 943:{f.Push(f.Locals[4]);f.Pc=945;continue;}
case 945:{return rt.Call(f,"forge/game/Game","copyLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",948);}
case 948:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",953);}
case 953:{f.StackOp("pop");f.Pc=954;continue;}
case 954:{f.Push(f.Locals[4]);f.Pc=956;continue;}
case 956:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",959);}
case 959:{f.Push(f.Locals[3]);f.Pc=960;continue;}
case 960:{f.Push(f.Locals[3]);f.Pc=961;continue;}
case 961:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",964);}
case 964:{f.Push(f.Locals[1]);f.Pc=965;continue;}
case 965:{f.Push(f.Locals[11]);f.Pc=967;continue;}
case 967:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",970);}
case 970:{f.Locals[12]=f.Pop();f.Pc=972;continue;}
case 972:{f.Push(f.Locals[12]);f.Pc=974;continue;}
case 974:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",977);}
case 977:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",980);}
case 980:{f.Locals[13]=f.Pop();f.Pc=982;continue;}
case 982:{f.Push(f.Locals[13]);f.Pc=984;continue;}
case 984:{f.Push(f.Locals[10]);f.Pc=986;continue;}
case 986:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1001:989;continue;}
case 989:{f.Push(f.Locals[9]);f.Pc=991;continue;}
case 991:{f.Push(f.Locals[10]);f.Pc=993;continue;}
case 993:{f.Push(f.Locals[13]);f.Pc=995;continue;}
case 995:{f.Push(f.Locals[12]);f.Pc=997;continue;}
case 997:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",1000);}
case 1000:{f.StackOp("pop");f.Pc=1001;continue;}
case 1001:{f.Push(f.Locals[9]);f.Pc=1003;continue;}
case 1003:{f.Push(f.Locals[4]);f.Pc=1005;continue;}
case 1005:{f.Push(f.Locals[1]);f.Pc=1006;continue;}
case 1006:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1009);}
case 1009:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3048(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",11);}
case 11:{f.Push(JValue.R(rt.String("lblAttachTo")));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("(?i).*\\sto$")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{f.Pc=f.Pop().Int==0?141:39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",46);}
case 46:{f.Push(JValue.I(2));f.Pc=47;continue;}
case 47:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;","invokevirtual",51);}
case 51:{f.Push(JValue.R(rt.String(" ")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("Object")));f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Self")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",67);}
case 67:{f.Locals[5]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("Self")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?92:80;continue;}
case 80:{f.Push(f.Locals[2]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",85);}
case 85:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Pc=130;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",96);}
case 96:{f.Push(f.Locals[5]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",102);}
case 102:{f.Locals[6]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[6]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",112);}
case 112:{f.Pc=f.Pop().Int==0?121:115;continue;}
case 115:{f.Push(JValue.R(rt.String("it")));f.Pc=118;continue;}
case 118:{f.Pc=126;continue;}
case 121:{f.Push(f.Locals[6]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",126);}
case 126:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String(" to ")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",137);}
case 137:{f.StackOp("pop");f.Pc=138;continue;}
case 138:{f.Pc=153;continue;}
case 141:{f.Push(f.Locals[2]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[3]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",146);}
case 146:{f.Push(JValue.R(rt.String(" ")));f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",152);}
case 152:{f.StackOp("pop");f.Pc=153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/ability/effects/AttachEffect","getTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",157);}
case 157:{f.Locals[5]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",163);}
case 163:{f.Pc=f.Pop().Int==0?176:166;continue;}
case 166:{f.Push(f.Locals[1]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",170);}
case 170:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getValidTgts","()[Ljava/lang/String;","invokevirtual",173);}
case 173:{f.Pc=177;continue;}
case 176:{f.Push(JValue.R(null));f.Pc=177;continue;}
case 177:{f.Locals[6]=f.Pop();f.Pc=179;continue;}
case 179:{f.Push(f.Locals[5]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",186);}
case 186:{f.Pc=f.Pop().Int!=0?202:189;continue;}
case 189:{f.Push(f.Locals[2]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[5]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",195);}
case 195:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",198);}
case 198:{f.StackOp("pop");f.Pc=199;continue;}
case 199:{f.Pc=249;continue;}
case 202:{f.Push(f.Locals[6]);f.Pc=204;continue;}
case 204:{f.Pc=f.Pop().Reference==null?241:207;continue;}
case 207:{f.Push(f.Locals[6]);f.Pc=209;continue;}
case 209:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=210;continue;}
case 210:{f.Pc=f.Pop().Int<=0?241:213;continue;}
case 213:{f.Push(f.Locals[2]);f.Pc=214;continue;}
case 214:{f.Push(JValue.R(rt.String("target ")));f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",220);}
case 220:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",223);}
case 223:{f.Push(JValue.R(rt.String(",")));f.Pc=226;continue;}
case 226:{f.Push(f.Locals[6]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/lang/String","join","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;","invokestatic",231);}
case 231:{return rt.Call(f,"forge/util/Lang","describeValidList","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",234);}
case 234:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",237);}
case 237:{f.StackOp("pop");f.Pc=238;continue;}
case 238:{f.Pc=249;continue;}
case 241:{f.Push(f.Locals[2]);f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("a permanent")));f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",248);}
case 248:{f.StackOp("pop");f.Pc=249;continue;}
case 249:{f.Push(f.Locals[2]);f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String(".")));f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",256);}
case 256:{f.StackOp("pop");f.Pc=257;continue;}
case 257:{f.Push(f.Locals[2]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",261);}
case 261:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

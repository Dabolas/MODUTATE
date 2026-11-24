// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C289{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DigMultipleEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3341,"forge/game/ability/effects/DigMultipleEffect","<init>","()V",1,1,1,new JHandler[]{},M3341));
c.Add(new JMethod(3342,"forge/game/ability/effects/DigMultipleEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,29,10,new JHandler[]{},M3342));
}

internal static JStep M3341(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3342(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("DigNum")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",23);}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",27);}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("SourceZone")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?50:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("SourceZone")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",47);}
case 47:{f.Pc=53;continue;}
case 50:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=53;continue;}
case 53:{f.Locals[6]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("DestinationZone")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?76:64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("DestinationZone")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",70);}
case 70:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",73);}
case 73:{f.Pc=79;continue;}
case 76:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=79;continue;}
case 79:{f.Locals[7]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("DestinationZone2")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int==0?102:90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("DestinationZone2")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",96);}
case 96:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",99);}
case 99:{f.Pc=105;continue;}
case 102:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=105;continue;}
case 105:{f.Locals[8]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?128:116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",122);}
case 122:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",125);}
case 125:{f.Pc=129;continue;}
case 128:{f.Push(JValue.I(-1));f.Pc=129;continue;}
case 129:{f.Locals[9]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String("LibraryPosition2")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",137);}
case 137:{f.Pc=f.Pop().Int==0?152:140;continue;}
case 140:{f.Push(f.Locals[1]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("LibraryPosition2")));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",146);}
case 146:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",149);}
case 149:{f.Pc=153;continue;}
case 152:{f.Push(JValue.I(-1));f.Pc=153;continue;}
case 153:{f.Locals[10]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("ChangeValid")));f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",163);}
case 163:{f.Locals[11]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[1]);f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("Optional")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",171);}
case 171:{f.Locals[12]=f.Pop();f.Pc=173;continue;}
case 173:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=176;continue;}
case 176:{f.StackOp("dup");f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",180);}
case 180:{f.Locals[13]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/ability/effects/DigMultipleEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",186);}
case 186:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",189);}
case 189:{f.Locals[14]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[14]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",198);}
case 198:{f.Pc=f.Pop().Int==0?1345:201;continue;}
case 201:{f.Push(f.Locals[14]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",208);}
case 208:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=211;continue;}
case 211:{f.Locals[15]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[15]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",218);}
case 218:{f.Pc=f.Pop().Int!=0?224:221;continue;}
case 221:{f.Pc=191;continue;}
case 224:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=227;continue;}
case 227:{f.StackOp("dup");f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",231);}
case 231:{f.Locals[16]=f.Pop();f.Pc=233;continue;}
case 233:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=236;continue;}
case 236:{f.StackOp("dup");f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",240);}
case 240:{f.Locals[17]=f.Pop();f.Pc=242;continue;}
case 242:{f.Push(f.Locals[15]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[6]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",249);}
case 249:{f.Locals[18]=f.Pop();f.Pc=251;continue;}
case 251:{f.Push(f.Locals[5]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[18]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",258);}
case 258:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",261);}
case 261:{f.Locals[19]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(JValue.I(0));f.Pc=264;continue;}
case 264:{f.Locals[20]=f.Pop();f.Pc=266;continue;}
case 266:{f.Push(f.Locals[20]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[19]);f.Pc=270;continue;}
case 270:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?292:273;continue;}
case 273:{f.Push(f.Locals[16]);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[18]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[20]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/zone/PlayerZone","get","(I)Lforge/game/card/Card;","invokevirtual",282);}
case 282:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",285);}
case 285:{f.StackOp("pop");f.Pc=286;continue;}
case 286:{f.Locals[20]=JValue.I(unchecked(f.Locals[20].Int+(1)));f.Pc=289;continue;}
case 289:{f.Pc=266;continue;}
case 292:{f.Push(f.Locals[16]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",297);}
case 297:{f.Pc=f.Pop().Int==0?303:300;continue;}
case 300:{f.Pc=191;continue;}
case 303:{f.Push(f.Locals[17]);f.Pc=305;continue;}
case 305:{f.Push(f.Locals[16]);f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",310);}
case 310:{f.StackOp("pop");f.Pc=311;continue;}
case 311:{f.Push(f.Locals[1]);f.Pc=312;continue;}
case 312:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",317);}
case 317:{f.Pc=f.Pop().Int==0?336:320;continue;}
case 320:{f.Push(f.Locals[4]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",325);}
case 325:{f.Push(f.Locals[16]);f.Pc=327;continue;}
case 327:{f.Push(f.Locals[15]);f.Pc=329;continue;}
case 329:{f.Push(JValue.I(0));f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;Z)V","invokevirtual",333);}
case 333:{f.Pc=348;continue;}
case 336:{f.Push(f.Locals[4]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",341);}
case 341:{f.Push(f.Locals[16]);f.Pc=343;continue;}
case 343:{f.Push(f.Locals[15]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;)V","invokevirtual",348);}
case 348:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",351);}
case 351:{f.Locals[20]=f.Pop();f.Pc=353;continue;}
case 353:{f.Push(f.Locals[11]);f.Pc=355;continue;}
case 355:{f.Push(JValue.R(rt.String(",")));f.Pc=357;continue;}
case 357:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",360);}
case 360:{f.Locals[21]=f.Pop();f.Pc=362;continue;}
case 362:{f.Push(f.Locals[21]);f.Pc=364;continue;}
case 364:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=365;continue;}
case 365:{f.Locals[22]=f.Pop();f.Pc=367;continue;}
case 367:{f.Push(JValue.I(0));f.Pc=368;continue;}
case 368:{f.Locals[23]=f.Pop();f.Pc=370;continue;}
case 370:{f.Push(f.Locals[23]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[22]);f.Pc=374;continue;}
case 374:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?425:377;continue;}
case 377:{f.Push(f.Locals[21]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[23]);f.Pc=381;continue;}
case 381:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=382;continue;}
case 382:{f.Locals[24]=f.Pop();f.Pc=384;continue;}
case 384:{f.Push(f.Locals[16]);f.Pc=386;continue;}
case 386:{f.Push(f.Locals[24]);f.Pc=388;continue;}
case 388:{f.Push(f.Locals[2]);f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",392);}
case 392:{f.Push(f.Locals[2]);f.Pc=393;continue;}
case 393:{f.Push(f.Locals[1]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",397);}
case 397:{f.Locals[25]=f.Pop();f.Pc=399;continue;}
case 399:{f.Push(f.Locals[25]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",404);}
case 404:{f.Pc=f.Pop().Int!=0?419:407;continue;}
case 407:{f.Push(f.Locals[20]);f.Pc=409;continue;}
case 409:{f.Push(f.Locals[24]);f.Pc=411;continue;}
case 411:{f.Push(f.Locals[25]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",418);}
case 418:{f.StackOp("pop");f.Pc=419;continue;}
case 419:{f.Locals[23]=JValue.I(unchecked(f.Locals[23].Int+(1)));f.Pc=422;continue;}
case 422:{f.Pc=370;continue;}
case 425:{f.Push(f.Locals[20]);f.Pc=427;continue;}
case 427:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",432);}
case 432:{f.Pc=f.Pop().Int==0?460:435;continue;}
case 435:{f.Push(f.Locals[15]);f.Pc=437;continue;}
case 437:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",440);}
case 440:{f.Push(f.Locals[1]);f.Pc=441;continue;}
case 441:{f.Push(JValue.R(null));f.Pc=442;continue;}
case 442:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",445);}
case 445:{f.Push(JValue.R(rt.String("lblNoValidCards")));f.Pc=447;continue;}
case 447:{f.Push(JValue.I(0));f.Pc=448;continue;}
case 448:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=451;continue;}
case 451:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",454);}
case 454:{return rt.Call(f,"forge/game/player/PlayerController","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;)V","invokevirtual",457);}
case 457:{f.Pc=1063;continue;}
case 460:{f.Push(f.Locals[15]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",465);}
case 465:{f.Push(f.Locals[20]);f.Pc=467;continue;}
case 467:{f.Push(f.Locals[1]);f.Pc=468;continue;}
case 468:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",471);}
case 471:{f.Push(JValue.R(rt.String("lblChooseCards")));f.Pc=473;continue;}
case 473:{f.Push(JValue.I(0));f.Pc=474;continue;}
case 474:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",480);}
case 480:{f.Push(f.Locals[12]);f.Pc=482;continue;}
case 482:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffectMultiple","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",485);}
case 485:{f.Locals[21]=f.Pop();f.Pc=487;continue;}
case 487:{f.Push(f.Locals[21]);f.Pc=489;continue;}
case 489:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",492);}
case 492:{f.Pc=f.Pop().Int!=0?531:495;continue;}
case 495:{f.Push(f.Locals[4]);f.Pc=497;continue;}
case 497:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",500);}
case 500:{f.Push(f.Locals[21]);f.Pc=502;continue;}
case 502:{f.Push(f.Locals[15]);f.Pc=504;continue;}
case 504:{f.Push(JValue.I(1));f.Pc=505;continue;}
case 505:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",508);}
case 508:{f.Push(JValue.R(rt.String("lblPlayerPickedCardFrom")));f.Pc=510;continue;}
case 510:{f.Push(JValue.I(1));f.Pc=511;continue;}
case 511:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=514;continue;}
case 514:{f.StackOp("dup");f.Pc=515;continue;}
case 515:{f.Push(JValue.I(0));f.Pc=516;continue;}
case 516:{f.Push(f.Locals[15]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",521);}
case 521:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=522;continue;}
case 522:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",525);}
case 525:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",528);}
case 528:{f.Pc=564;continue;}
case 531:{f.Push(f.Locals[12]);f.Pc=533;continue;}
case 533:{f.Pc=f.Pop().Int==0?539:536;continue;}
case 536:{f.Pc=564;continue;}
case 539:{f.Push(f.Locals[15]);f.Pc=541;continue;}
case 541:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",544);}
case 544:{f.Push(f.Locals[1]);f.Pc=545;continue;}
case 545:{f.Push(JValue.R(null));f.Pc=546;continue;}
case 546:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",549);}
case 549:{f.Push(JValue.R(rt.String("lblMustChoose")));f.Pc=551;continue;}
case 551:{f.Push(JValue.I(0));f.Pc=552;continue;}
case 552:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=555;continue;}
case 555:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",558);}
case 558:{return rt.Call(f,"forge/game/player/PlayerController","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;)V","invokevirtual",561);}
case 561:{f.Pc=460;continue;}
case 564:{f.Push(f.Locals[1]);f.Pc=565;continue;}
case 565:{f.Push(JValue.R(rt.String("ChooseAmount")));f.Pc=567;continue;}
case 567:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",570);}
case 570:{f.Pc=f.Pop().Int!=0?582:573;continue;}
case 573:{f.Push(f.Locals[1]);f.Pc=574;continue;}
case 574:{f.Push(JValue.R(rt.String("ChosenZone")));f.Pc=576;continue;}
case 576:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",579);}
case 579:{f.Pc=f.Pop().Int==0?818:582;continue;}
case 582:{f.Push(f.Locals[2]);f.Pc=583;continue;}
case 583:{f.Push(f.Locals[1]);f.Pc=584;continue;}
case 584:{f.Push(JValue.R(rt.String("ChooseAmount")));f.Pc=586;continue;}
case 586:{f.Push(JValue.R(rt.String("1")));f.Pc=588;continue;}
case 588:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",591);}
case 591:{f.Push(f.Locals[1]);f.Pc=592;continue;}
case 592:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",595);}
case 595:{f.Locals[22]=f.Pop();f.Pc=597;continue;}
case 597:{f.Push(f.Locals[1]);f.Pc=598;continue;}
case 598:{f.Push(JValue.R(rt.String("ChosenZone")));f.Pc=600;continue;}
case 600:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",603);}
case 603:{f.Pc=f.Pop().Int==0?618:606;continue;}
case 606:{f.Push(f.Locals[1]);f.Pc=607;continue;}
case 607:{f.Push(JValue.R(rt.String("ChosenZone")));f.Pc=609;continue;}
case 609:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",612);}
case 612:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",615);}
case 615:{f.Pc=621;continue;}
case 618:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=621;continue;}
case 621:{f.Locals[23]=f.Pop();f.Pc=623;continue;}
case 623:{f.Push(f.Locals[15]);f.Pc=625;continue;}
case 625:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",628);}
case 628:{f.Push(f.Locals[21]);f.Pc=630;continue;}
case 630:{f.Push(f.Locals[1]);f.Pc=631;continue;}
case 631:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",634);}
case 634:{f.Push(JValue.R(rt.String("lblChooseCards")));f.Pc=636;continue;}
case 636:{f.Push(JValue.I(0));f.Pc=637;continue;}
case 637:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=640;continue;}
case 640:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",643);}
case 643:{f.Push(f.Locals[22]);f.Pc=645;continue;}
case 645:{f.Push(f.Locals[22]);f.Pc=647;continue;}
case 647:{f.Push(JValue.I(0));f.Pc=648;continue;}
case 648:{f.Push(JValue.R(null));f.Pc=649;continue;}
case 649:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",652);}
case 652:{f.Locals[24]=f.Pop();f.Pc=654;continue;}
case 654:{f.Push(f.Locals[24]);f.Pc=656;continue;}
case 656:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",661);}
case 661:{f.Pc=f.Pop().Int!=0?697:664;continue;}
case 664:{f.Push(f.Locals[4]);f.Pc=666;continue;}
case 666:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",669);}
case 669:{f.Push(f.Locals[24]);f.Pc=671;continue;}
case 671:{f.Push(f.Locals[15]);f.Pc=673;continue;}
case 673:{f.Push(JValue.I(1));f.Pc=674;continue;}
case 674:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",677);}
case 677:{f.Push(JValue.R(rt.String("lblPlayerPickedCardFrom")));f.Pc=679;continue;}
case 679:{f.Push(JValue.I(1));f.Pc=680;continue;}
case 680:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=683;continue;}
case 683:{f.StackOp("dup");f.Pc=684;continue;}
case 684:{f.Push(JValue.I(0));f.Pc=685;continue;}
case 685:{f.Push(f.Locals[15]);f.Pc=687;continue;}
case 687:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",690);}
case 690:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=691;continue;}
case 691:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",694);}
case 694:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",697);}
case 697:{f.Push(f.Locals[24]);f.Pc=699;continue;}
case 699:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",704);}
case 704:{f.Locals[25]=f.Pop();f.Pc=706;continue;}
case 706:{f.Push(f.Locals[25]);f.Pc=708;continue;}
case 708:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",713);}
case 713:{f.Pc=f.Pop().Int==0?818:716;continue;}
case 716:{f.Push(f.Locals[25]);f.Pc=718;continue;}
case 718:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",723);}
case 723:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=726;continue;}
case 726:{f.Locals[26]=f.Pop();f.Pc=728;continue;}
case 728:{f.Push(f.Locals[26]);f.Pc=730;continue;}
case 730:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",733);}
case 733:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",736);}
case 736:{f.Locals[27]=f.Pop();f.Pc=738;continue;}
case 738:{f.Push(f.Locals[26]);f.Pc=740;continue;}
case 740:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",743);}
case 743:{f.Push(f.Locals[23]);f.Pc=745;continue;}
case 745:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",748);}
case 748:{f.Locals[28]=f.Pop();f.Pc=750;continue;}
case 750:{f.Push(f.Locals[21]);f.Pc=752;continue;}
case 752:{f.Push(f.Locals[26]);f.Pc=754;continue;}
case 754:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",757);}
case 757:{f.StackOp("pop");f.Pc=758;continue;}
case 758:{f.Push(f.Locals[17]);f.Pc=760;continue;}
case 760:{f.Push(f.Locals[26]);f.Pc=762;continue;}
case 762:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",765);}
case 765:{f.StackOp("pop");f.Pc=766;continue;}
case 766:{f.Push(f.Locals[4]);f.Pc=768;continue;}
case 768:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",771);}
case 771:{f.Push(f.Locals[28]);f.Pc=773;continue;}
case 773:{f.Push(f.Locals[26]);f.Pc=775;continue;}
case 775:{f.Push(f.Locals[1]);f.Pc=776;continue;}
case 776:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",779);}
case 779:{f.Locals[26]=f.Pop();f.Pc=781;continue;}
case 781:{f.Push(f.Locals[27]);f.Pc=783;continue;}
case 783:{f.Push(f.Locals[26]);f.Pc=785;continue;}
case 785:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",788);}
case 788:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",791);}
case 791:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",794);}
case 794:{f.Pc=f.Pop().Int!=0?815:797;continue;}
case 797:{f.Push(f.Locals[13]);f.Pc=799;continue;}
case 799:{f.Push(f.Locals[27]);f.Pc=801;continue;}
case 801:{f.Push(f.Locals[26]);f.Pc=803;continue;}
case 803:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",806);}
case 806:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",809);}
case 809:{f.Push(f.Locals[26]);f.Pc=811;continue;}
case 811:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",814);}
case 814:{f.StackOp("pop");f.Pc=815;continue;}
case 815:{f.Pc=706;continue;}
case 818:{f.Push(f.Locals[21]);f.Pc=820;continue;}
case 820:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",823);}
case 823:{f.Locals[22]=f.Pop();f.Pc=825;continue;}
case 825:{f.Push(f.Locals[22]);f.Pc=827;continue;}
case 827:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",832);}
case 832:{f.Pc=f.Pop().Int==0?1063:835;continue;}
case 835:{f.Push(f.Locals[22]);f.Pc=837;continue;}
case 837:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",842);}
case 842:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=845;continue;}
case 845:{f.Locals[23]=f.Pop();f.Pc=847;continue;}
case 847:{f.Push(f.Locals[23]);f.Pc=849;continue;}
case 849:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",852);}
case 852:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",855);}
case 855:{f.Locals[24]=f.Pop();f.Pc=857;continue;}
case 857:{f.Push(f.Locals[23]);f.Pc=859;continue;}
case 859:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",862);}
case 862:{f.Push(f.Locals[7]);f.Pc=864;continue;}
case 864:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",867);}
case 867:{f.Locals[25]=f.Pop();f.Pc=869;continue;}
case 869:{f.Push(f.Locals[1]);f.Pc=870;continue;}
case 870:{f.Push(JValue.R(rt.String("ChangeLater")));f.Pc=873;continue;}
case 873:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",876);}
case 876:{f.Pc=f.Pop().Int!=0?989:879;continue;}
case 879:{f.Push(f.Locals[25]);f.Pc=881;continue;}
case 881:{return rt.Call(f,"forge/game/zone/PlayerZone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",884);}
case 884:{return rt.Call(f,"forge/game/zone/ZoneType","isDeck","()Z","invokevirtual",887);}
case 887:{f.Pc=f.Pop().Int==0?913:890;continue;}
case 890:{f.Push(f.Locals[4]);f.Pc=892;continue;}
case 892:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",895);}
case 895:{f.Push(f.Locals[7]);f.Pc=897;continue;}
case 897:{f.Push(f.Locals[23]);f.Pc=899;continue;}
case 899:{f.Push(f.Locals[9]);f.Pc=901;continue;}
case 901:{f.Push(f.Locals[1]);f.Pc=902;continue;}
case 902:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",905);}
case 905:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",908);}
case 908:{f.Locals[23]=f.Pop();f.Pc=910;continue;}
case 910:{f.Pc=955;continue;}
case 913:{f.Push(f.Locals[7]);f.Pc=915;continue;}
case 915:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=918;continue;}
case 918:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",921);}
case 921:{f.Pc=f.Pop().Int==0?940:924;continue;}
case 924:{f.Push(f.Locals[1]);f.Pc=925;continue;}
case 925:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=928;continue;}
case 928:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",931);}
case 931:{f.Pc=f.Pop().Int==0?940:934;continue;}
case 934:{f.Push(f.Locals[23]);f.Pc=936;continue;}
case 936:{f.Push(JValue.I(1));f.Pc=937;continue;}
case 937:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",940);}
case 940:{f.Push(f.Locals[4]);f.Pc=942;continue;}
case 942:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",945);}
case 945:{f.Push(f.Locals[25]);f.Pc=947;continue;}
case 947:{f.Push(f.Locals[23]);f.Pc=949;continue;}
case 949:{f.Push(f.Locals[1]);f.Pc=950;continue;}
case 950:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",953);}
case 953:{f.Locals[23]=f.Pop();f.Pc=955;continue;}
case 955:{f.Push(f.Locals[24]);f.Pc=957;continue;}
case 957:{f.Push(f.Locals[23]);f.Pc=959;continue;}
case 959:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",962);}
case 962:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",965);}
case 965:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",968);}
case 968:{f.Pc=f.Pop().Int!=0?989:971;continue;}
case 971:{f.Push(f.Locals[13]);f.Pc=973;continue;}
case 973:{f.Push(f.Locals[24]);f.Pc=975;continue;}
case 975:{f.Push(f.Locals[23]);f.Pc=977;continue;}
case 977:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",980);}
case 980:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",983);}
case 983:{f.Push(f.Locals[23]);f.Pc=985;continue;}
case 985:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",988);}
case 988:{f.StackOp("pop");f.Pc=989;continue;}
case 989:{f.Push(f.Locals[1]);f.Pc=990;continue;}
case 990:{f.Push(JValue.R(rt.String("ExileFaceDown")));f.Pc=993;continue;}
case 993:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",996);}
case 996:{f.Pc=f.Pop().Int==0?1006:999;continue;}
case 999:{f.Push(f.Locals[23]);f.Pc=1001;continue;}
case 1001:{f.Push(JValue.I(1));f.Pc=1002;continue;}
case 1002:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",1005);}
case 1005:{f.StackOp("pop");f.Pc=1006;continue;}
case 1006:{f.Push(f.Locals[1]);f.Pc=1007;continue;}
case 1007:{f.Push(JValue.R(rt.String("Imprint")));f.Pc=1010;continue;}
case 1010:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1013);}
case 1013:{f.Pc=f.Pop().Int==0?1022:1016;continue;}
case 1016:{f.Push(f.Locals[2]);f.Pc=1017;continue;}
case 1017:{f.Push(f.Locals[23]);f.Pc=1019;continue;}
case 1019:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",1022);}
case 1022:{f.Push(f.Locals[1]);f.Pc=1023;continue;}
case 1023:{f.Push(JValue.R(rt.String("ForgetOtherRemembered")));f.Pc=1026;continue;}
case 1026:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1029);}
case 1029:{f.Pc=f.Pop().Int==0?1036:1032;continue;}
case 1032:{f.Push(f.Locals[2]);f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",1036);}
case 1036:{f.Push(f.Locals[1]);f.Pc=1037;continue;}
case 1037:{f.Push(JValue.R(rt.String("RememberChanged")));f.Pc=1040;continue;}
case 1040:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1043);}
case 1043:{f.Pc=f.Pop().Int==0?1052:1046;continue;}
case 1046:{f.Push(f.Locals[2]);f.Pc=1047;continue;}
case 1047:{f.Push(f.Locals[23]);f.Pc=1049;continue;}
case 1049:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1052);}
case 1052:{f.Push(f.Locals[17]);f.Pc=1054;continue;}
case 1054:{f.Push(f.Locals[23]);f.Pc=1056;continue;}
case 1056:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",1059);}
case 1059:{f.StackOp("pop");f.Pc=1060;continue;}
case 1060:{f.Pc=825;continue;}
case 1063:{f.Push(f.Locals[1]);f.Pc=1064;continue;}
case 1064:{f.Push(JValue.R(rt.String("ChangeLater")));f.Pc=1067;continue;}
case 1067:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1070);}
case 1070:{f.Pc=f.Pop().Int!=0?1326:1073;continue;}
case 1073:{f.Push(f.Locals[8]);f.Pc=1075;continue;}
case 1075:{return rt.Call(f,"forge/game/zone/ZoneType","isDeck","()Z","invokevirtual",1078);}
case 1078:{f.Pc=f.Pop().Int!=0?1089:1081;continue;}
case 1081:{f.Push(f.Locals[8]);f.Pc=1083;continue;}
case 1083:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1086;continue;}
case 1086:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1223:1089;continue;}
case 1089:{f.Push(f.Locals[17]);f.Pc=1091;continue;}
case 1091:{f.Locals[21]=f.Pop();f.Pc=1093;continue;}
case 1093:{f.Push(f.Locals[1]);f.Pc=1094;continue;}
case 1094:{f.Push(JValue.R(rt.String("RestRandomOrder")));f.Pc=1097;continue;}
case 1097:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1100);}
case 1100:{f.Pc=f.Pop().Int==0?1108:1103;continue;}
case 1103:{f.Push(f.Locals[21]);f.Pc=1105;continue;}
case 1105:{return rt.Call(f,"forge/game/card/CardLists","shuffle","(Ljava/util/List;)V","invokestatic",1108);}
case 1108:{f.Push(f.Locals[10]);f.Pc=1110;continue;}
case 1110:{f.Push(JValue.I(-1));f.Pc=1111;continue;}
case 1111:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?1119:1114;continue;}
case 1114:{f.Push(f.Locals[21]);f.Pc=1116;continue;}
case 1116:{return rt.Call(f,"java/util/Collections","reverse","(Ljava/util/List;)V","invokestatic",1119);}
case 1119:{f.Push(f.Locals[21]);f.Pc=1121;continue;}
case 1121:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1124);}
case 1124:{f.Locals[22]=f.Pop();f.Pc=1126;continue;}
case 1126:{f.Push(f.Locals[22]);f.Pc=1128;continue;}
case 1128:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1133);}
case 1133:{f.Pc=f.Pop().Int==0?1220:1136;continue;}
case 1136:{f.Push(f.Locals[22]);f.Pc=1138;continue;}
case 1138:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1143);}
case 1143:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1146;continue;}
case 1146:{f.Locals[23]=f.Pop();f.Pc=1148;continue;}
case 1148:{f.Push(f.Locals[23]);f.Pc=1150;continue;}
case 1150:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1153);}
case 1153:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1156);}
case 1156:{f.Locals[24]=f.Pop();f.Pc=1158;continue;}
case 1158:{f.Push(f.Locals[4]);f.Pc=1160;continue;}
case 1160:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1163);}
case 1163:{f.Push(f.Locals[8]);f.Pc=1165;continue;}
case 1165:{f.Push(f.Locals[23]);f.Pc=1167;continue;}
case 1167:{f.Push(f.Locals[10]);f.Pc=1169;continue;}
case 1169:{f.Push(f.Locals[1]);f.Pc=1170;continue;}
case 1170:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1173);}
case 1173:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",1176);}
case 1176:{f.Locals[25]=f.Pop();f.Pc=1178;continue;}
case 1178:{f.Push(f.Locals[25]);f.Pc=1180;continue;}
case 1180:{f.Pc=f.Pop().Reference==null?1217:1183;continue;}
case 1183:{f.Push(f.Locals[24]);f.Pc=1185;continue;}
case 1185:{f.Push(f.Locals[25]);f.Pc=1187;continue;}
case 1187:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1190);}
case 1190:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1193);}
case 1193:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",1196);}
case 1196:{f.Pc=f.Pop().Int!=0?1217:1199;continue;}
case 1199:{f.Push(f.Locals[13]);f.Pc=1201;continue;}
case 1201:{f.Push(f.Locals[24]);f.Pc=1203;continue;}
case 1203:{f.Push(f.Locals[25]);f.Pc=1205;continue;}
case 1205:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1208);}
case 1208:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1211);}
case 1211:{f.Push(f.Locals[25]);f.Pc=1213;continue;}
case 1213:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",1216);}
case 1216:{f.StackOp("pop");f.Pc=1217;continue;}
case 1217:{f.Pc=1126;continue;}
case 1220:{f.Pc=1326;continue;}
case 1223:{f.Push(f.Locals[17]);f.Pc=1225;continue;}
case 1225:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1228);}
case 1228:{f.Locals[21]=f.Pop();f.Pc=1230;continue;}
case 1230:{f.Push(f.Locals[21]);f.Pc=1232;continue;}
case 1232:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1237);}
case 1237:{f.Pc=f.Pop().Int==0?1326:1240;continue;}
case 1240:{f.Push(f.Locals[21]);f.Pc=1242;continue;}
case 1242:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1247);}
case 1247:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1250;continue;}
case 1250:{f.Locals[22]=f.Pop();f.Pc=1252;continue;}
case 1252:{f.Push(f.Locals[22]);f.Pc=1254;continue;}
case 1254:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1257);}
case 1257:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1260);}
case 1260:{f.Locals[23]=f.Pop();f.Pc=1262;continue;}
case 1262:{f.Push(f.Locals[22]);f.Pc=1264;continue;}
case 1264:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1267);}
case 1267:{f.Push(f.Locals[8]);f.Pc=1269;continue;}
case 1269:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",1272);}
case 1272:{f.Locals[24]=f.Pop();f.Pc=1274;continue;}
case 1274:{f.Push(f.Locals[4]);f.Pc=1276;continue;}
case 1276:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1279);}
case 1279:{f.Push(f.Locals[24]);f.Pc=1281;continue;}
case 1281:{f.Push(f.Locals[22]);f.Pc=1283;continue;}
case 1283:{f.Push(f.Locals[1]);f.Pc=1284;continue;}
case 1284:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",1287);}
case 1287:{f.Locals[22]=f.Pop();f.Pc=1289;continue;}
case 1289:{f.Push(f.Locals[23]);f.Pc=1291;continue;}
case 1291:{f.Push(f.Locals[22]);f.Pc=1293;continue;}
case 1293:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1296);}
case 1296:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1299);}
case 1299:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",1302);}
case 1302:{f.Pc=f.Pop().Int!=0?1323:1305;continue;}
case 1305:{f.Push(f.Locals[13]);f.Pc=1307;continue;}
case 1307:{f.Push(f.Locals[23]);f.Pc=1309;continue;}
case 1309:{f.Push(f.Locals[22]);f.Pc=1311;continue;}
case 1311:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1314);}
case 1314:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1317);}
case 1317:{f.Push(f.Locals[22]);f.Pc=1319;continue;}
case 1319:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",1322);}
case 1322:{f.StackOp("pop");f.Pc=1323;continue;}
case 1323:{f.Pc=1230;continue;}
case 1326:{f.Push(f.Locals[1]);f.Pc=1327;continue;}
case 1327:{f.Push(JValue.R(rt.String("ImprintRest")));f.Pc=1330;continue;}
case 1330:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1333);}
case 1333:{f.Pc=f.Pop().Int==0?1342:1336;continue;}
case 1336:{f.Push(f.Locals[2]);f.Pc=1337;continue;}
case 1337:{f.Push(f.Locals[17]);f.Pc=1339;continue;}
case 1339:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",1342);}
case 1342:{f.Pc=191;continue;}
case 1345:{f.Push(f.Locals[13]);f.Pc=1347;continue;}
case 1347:{f.Push(f.Locals[4]);f.Pc=1349;continue;}
case 1349:{f.Push(f.Locals[1]);f.Pc=1350;continue;}
case 1350:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1353);}
case 1353:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

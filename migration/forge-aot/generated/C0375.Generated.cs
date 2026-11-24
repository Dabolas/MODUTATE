// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C375{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RepeatEachEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3633,"forge/game/ability/effects/RepeatEachEffect","<init>","()V",1,1,1,new JHandler[]{},M3633));
c.Add(new JMethod(3634,"forge/game/ability/effects/RepeatEachEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,16,6,new JHandler[]{},M3634));
c.Add(new JMethod(3635,"forge/game/ability/effects/RepeatEachEffect","setVoteAmount","(Ljava/lang/Object;Lforge/game/spellability/SpellAbility;)V",2,5,4,new JHandler[]{},M3635));
c.Add(new JMethod(3636,"forge/game/ability/effects/RepeatEachEffect","$deserializeLambda$","(Ljava/lang/invoke/SerializedLambda;)Ljava/lang/Object;",4106,3,4,new JHandler[]{},M3636));
c.Add(new JMethod(3637,"forge/game/ability/effects/RepeatEachEffect","lambda$resolve$ebfbd808$1","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)V",4106,4,2,new JHandler[]{},M3637));
}

internal static JStep M3633(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3634(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("RepeatSubAbility")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",23);}
case 23:{f.Locals[5]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("Optional")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?64:34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("OptionPrompt")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?64:43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",48);}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(null));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("OptionPrompt")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",56);}
case 56:{f.Push(JValue.R(null));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int!=0?64:63;continue;}
case 63:{return JStep.ReturnVoid;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("UseImprinted")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",70);}
case 70:{f.Locals[6]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(JValue.R(null));f.Pc=73;continue;}
case 73:{f.Locals[7]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(JValue.R(null));f.Pc=76;continue;}
case 76:{f.Locals[8]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("RepeatCards")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?153:87;continue;}
case 87:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",90);}
case 90:{f.Locals[9]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("Zone")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?115:101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("Zone")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",107);}
case 107:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",110);}
case 110:{f.Locals[9]=f.Pop();f.Pc=112;continue;}
case 112:{f.Pc=126;continue;}
case 115:{f.Push(f.Locals[9]);f.Pc=117;continue;}
case 117:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",125);}
case 125:{f.StackOp("pop");f.Pc=126;continue;}
case 126:{f.Push(f.Locals[5]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[9]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",133);}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{f.Push(JValue.R(rt.String("RepeatCards")));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",139);}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",143);}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",148);}
case 148:{f.Locals[7]=f.Pop();f.Pc=150;continue;}
case 150:{f.Pc=272;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("RepeatSpellAbilities")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int==0?250:162;continue;}
case 162:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",165);}
case 165:{f.Locals[8]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{f.Push(JValue.R(rt.String("RepeatSpellAbilities")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",173);}
case 173:{f.Push(JValue.R(rt.String(",")));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",178);}
case 178:{f.Locals[9]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[5]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",185);}
case 185:{return rt.Call(f,"forge/game/zone/MagicStack","iterator","()Ljava/util/Iterator;","invokevirtual",188);}
case 188:{f.Locals[10]=f.Pop();f.Pc=190;continue;}
case 190:{f.Push(f.Locals[10]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",197);}
case 197:{f.Pc=f.Pop().Int==0?247:200;continue;}
case 200:{f.Push(f.Locals[10]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",207);}
case 207:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=210;continue;}
case 210:{f.Locals[11]=f.Pop();f.Pc=212;continue;}
case 212:{f.Push(f.Locals[11]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",217);}
case 217:{f.Push(f.Locals[9]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[2]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",223);}
case 223:{f.Push(f.Locals[2]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[1]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/spellability/SpellAbility","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",228);}
case 228:{f.Pc=f.Pop().Int==0?244:231;continue;}
case 231:{f.Push(f.Locals[8]);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[11]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",238);}
case 238:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",243);}
case 243:{f.StackOp("pop");f.Pc=244;continue;}
case 244:{f.Pc=190;continue;}
case 247:{f.Pc=272;continue;}
case 250:{f.Push(f.Locals[1]);f.Pc=251;continue;}
case 251:{f.Push(JValue.R(rt.String("DefinedCards")));f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",256);}
case 256:{f.Pc=f.Pop().Int==0?272:259;continue;}
case 259:{f.Push(f.Locals[2]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[1]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String("DefinedCards")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",266);}
case 266:{f.Push(f.Locals[1]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",270);}
case 270:{f.Locals[7]=f.Pop();f.Pc=272;continue;}
case 272:{f.Push(f.Locals[1]);f.Pc=273;continue;}
case 273:{f.Push(JValue.R(rt.String("ClearRemembered")));f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",278);}
case 278:{f.Pc=f.Pop().Int==0?285:281;continue;}
case 281:{f.Push(f.Locals[2]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",285);}
case 285:{f.Push(f.Locals[1]);f.Pc=286;continue;}
case 286:{f.Push(JValue.R(rt.String("DamageMap")));f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",291);}
case 291:{f.Pc=f.Pop().Int==0?327:294;continue;}
case 294:{f.Push(f.Locals[1]);f.Pc=295;continue;}
case 295:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=298;continue;}
case 298:{f.StackOp("dup");f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",302);}
case 302:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDamageMap","(Lforge/game/card/CardDamageTable;)V","invokevirtual",305);}
case 305:{f.Push(f.Locals[1]);f.Pc=306;continue;}
case 306:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=309;continue;}
case 309:{f.StackOp("dup");f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",313);}
case 313:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPreventMap","(Lforge/game/card/CardDamageTable;)V","invokevirtual",316);}
case 316:{f.Push(f.Locals[1]);f.Pc=317;continue;}
case 317:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=320;continue;}
case 320:{f.StackOp("dup");f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",324);}
case 324:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCounterTable","(Lforge/game/GameEntityCounterTable;)V","invokevirtual",327);}
case 327:{f.Push(f.Locals[1]);f.Pc=328;continue;}
case 328:{f.Push(JValue.R(rt.String("ChangeZoneTable")));f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",333);}
case 333:{f.Pc=f.Pop().Int==0?347:336;continue;}
case 336:{f.Push(f.Locals[1]);f.Pc=337;continue;}
case 337:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=340;continue;}
case 340:{f.StackOp("dup");f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",344);}
case 344:{return rt.Call(f,"forge/game/spellability/SpellAbility","setChangeZoneTable","(Lforge/game/card/CardZoneTable;)V","invokevirtual",347);}
case 347:{f.Push(f.Locals[1]);f.Pc=348;continue;}
case 348:{f.Push(JValue.R(rt.String("LoseLifeMap")));f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",353);}
case 353:{f.Pc=f.Pop().Int==0?363:356;continue;}
case 356:{f.Push(f.Locals[1]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",360);}
case 360:{return rt.Call(f,"forge/game/spellability/SpellAbility","setLoseLifeMap","(Ljava/util/Map;)V","invokevirtual",363);}
case 363:{f.Push(f.Locals[7]);f.Pc=365;continue;}
case 365:{f.Pc=f.Pop().Reference==null?547:368;continue;}
case 368:{f.Push(f.Locals[7]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",375);}
case 375:{f.Pc=f.Pop().Int!=0?547:378;continue;}
case 378:{f.Push(f.Locals[1]);f.Pc=379;continue;}
case 379:{f.Push(JValue.R(rt.String("ChooseOrder")));f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",384);}
case 384:{f.Pc=f.Pop().Int==0?453:387;continue;}
case 387:{f.Push(f.Locals[7]);f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",394);}
case 394:{f.Push(JValue.I(1));f.Pc=395;continue;}
case 395:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?453:398;continue;}
case 398:{f.Push(f.Locals[1]);f.Pc=399;continue;}
case 399:{f.Push(JValue.R(rt.String("ChooseOrder")));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",404);}
case 404:{f.Push(JValue.R(rt.String("True")));f.Pc=406;continue;}
case 406:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",409);}
case 409:{f.Pc=f.Pop().Int==0?417:412;continue;}
case 412:{f.Push(f.Locals[4]);f.Pc=414;continue;}
case 414:{f.Pc=435;continue;}
case 417:{f.Push(f.Locals[2]);f.Pc=418;continue;}
case 418:{f.Push(f.Locals[1]);f.Pc=419;continue;}
case 419:{f.Push(JValue.R(rt.String("ChooseOrder")));f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",424);}
case 424:{f.Push(f.Locals[1]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",428);}
case 428:{f.Push(JValue.I(0));f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",432);}
case 432:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=435;continue;}
case 435:{f.Locals[9]=f.Pop();f.Pc=437;continue;}
case 437:{f.Push(f.Locals[9]);f.Pc=439;continue;}
case 439:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",442);}
case 442:{f.Push(f.Locals[7]);f.Pc=444;continue;}
case 444:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=447;continue;}
case 447:{f.Push(f.Locals[1]);f.Pc=448;continue;}
case 448:{return rt.Call(f,"forge/game/player/PlayerController","orderMoveToZoneList","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",451);}
case 451:{f.Locals[7]=f.Pop();f.Pc=453;continue;}
case 453:{f.Push(f.Locals[7]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",460);}
case 460:{f.Locals[9]=f.Pop();f.Pc=462;continue;}
case 462:{f.Push(f.Locals[9]);f.Pc=464;continue;}
case 464:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",469);}
case 469:{f.Pc=f.Pop().Int==0?547:472;continue;}
case 472:{f.Push(f.Locals[9]);f.Pc=474;continue;}
case 474:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",479);}
case 479:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=482;continue;}
case 482:{f.Locals[10]=f.Pop();f.Pc=484;continue;}
case 484:{f.Push(f.Locals[6]);f.Pc=486;continue;}
case 486:{f.Pc=f.Pop().Int==0?498:489;continue;}
case 489:{f.Push(f.Locals[2]);f.Pc=490;continue;}
case 490:{f.Push(f.Locals[10]);f.Pc=492;continue;}
case 492:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",495);}
case 495:{f.Pc=504;continue;}
case 498:{f.Push(f.Locals[2]);f.Pc=499;continue;}
case 499:{f.Push(f.Locals[10]);f.Pc=501;continue;}
case 501:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",504);}
case 504:{f.Push(f.Locals[1]);f.Pc=505;continue;}
case 505:{f.Push(JValue.R(rt.String("AmountFromVotes")));f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",510);}
case 510:{f.Pc=f.Pop().Int==0?520:513;continue;}
case 513:{f.Push(f.Locals[0]);f.Pc=514;continue;}
case 514:{f.Push(f.Locals[10]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[1]);f.Pc=517;continue;}
case 517:{return rt.Call(f,"forge/game/ability/effects/RepeatEachEffect","setVoteAmount","(Ljava/lang/Object;Lforge/game/spellability/SpellAbility;)V","invokevirtual",520);}
case 520:{f.Push(f.Locals[3]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",524);}
case 524:{f.Push(f.Locals[6]);f.Pc=526;continue;}
case 526:{f.Pc=f.Pop().Int==0?538:529;continue;}
case 529:{f.Push(f.Locals[2]);f.Pc=530;continue;}
case 530:{f.Push(f.Locals[10]);f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/game/card/Card","removeImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",535);}
case 535:{f.Pc=544;continue;}
case 538:{f.Push(f.Locals[2]);f.Pc=539;continue;}
case 539:{f.Push(f.Locals[10]);f.Pc=541;continue;}
case 541:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",544);}
case 544:{f.Pc=462;continue;}
case 547:{f.Push(f.Locals[8]);f.Pc=549;continue;}
case 549:{f.Pc=f.Pop().Reference==null?602:552;continue;}
case 552:{f.Push(f.Locals[8]);f.Pc=554;continue;}
case 554:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",559);}
case 559:{f.Locals[9]=f.Pop();f.Pc=561;continue;}
case 561:{f.Push(f.Locals[9]);f.Pc=563;continue;}
case 563:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",568);}
case 568:{f.Pc=f.Pop().Int==0?602:571;continue;}
case 571:{f.Push(f.Locals[9]);f.Pc=573;continue;}
case 573:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",578);}
case 578:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=581;continue;}
case 581:{f.Locals[10]=f.Pop();f.Pc=583;continue;}
case 583:{f.Push(f.Locals[2]);f.Pc=584;continue;}
case 584:{f.Push(f.Locals[10]);f.Pc=586;continue;}
case 586:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",589);}
case 589:{f.Push(f.Locals[3]);f.Pc=590;continue;}
case 590:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",593);}
case 593:{f.Push(f.Locals[2]);f.Pc=594;continue;}
case 594:{f.Push(f.Locals[10]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",599);}
case 599:{f.Pc=561;continue;}
case 602:{f.Push(f.Locals[1]);f.Pc=603;continue;}
case 603:{f.Push(JValue.R(rt.String("RepeatTargeted")));f.Pc=605;continue;}
case 605:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",608);}
case 608:{f.Pc=f.Pop().Int==0?663:611;continue;}
case 611:{f.Push(f.Locals[1]);f.Pc=612;continue;}
case 612:{return rt.Call(f,"forge/game/ability/effects/RepeatEachEffect","getTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",615);}
case 615:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",620);}
case 620:{f.Locals[9]=f.Pop();f.Pc=622;continue;}
case 622:{f.Push(f.Locals[9]);f.Pc=624;continue;}
case 624:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",629);}
case 629:{f.Pc=f.Pop().Int==0?663:632;continue;}
case 632:{f.Push(f.Locals[9]);f.Pc=634;continue;}
case 634:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",639);}
case 639:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=642;continue;}
case 642:{f.Locals[10]=f.Pop();f.Pc=644;continue;}
case 644:{f.Push(f.Locals[2]);f.Pc=645;continue;}
case 645:{f.Push(f.Locals[10]);f.Pc=647;continue;}
case 647:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",650);}
case 650:{f.Push(f.Locals[3]);f.Pc=651;continue;}
case 651:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",654);}
case 654:{f.Push(f.Locals[2]);f.Pc=655;continue;}
case 655:{f.Push(f.Locals[10]);f.Pc=657;continue;}
case 657:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",660);}
case 660:{f.Pc=622;continue;}
case 663:{f.Push(f.Locals[1]);f.Pc=664;continue;}
case 664:{f.Push(JValue.R(rt.String("RepeatTypesFrom")));f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",670);}
case 670:{f.Pc=f.Pop().Int==0?938:673;continue;}
case 673:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=676;continue;}
case 676:{f.StackOp("dup");f.Pc=677;continue;}
case 677:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",680);}
case 680:{f.Locals[9]=f.Pop();f.Pc=682;continue;}
case 682:{f.Push(f.Locals[1]);f.Pc=683;continue;}
case 683:{f.Push(JValue.R(rt.String("RepeatTypesFrom")));f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",689);}
case 689:{f.Locals[10]=f.Pop();f.Pc=691;continue;}
case 691:{f.Push(f.Locals[10]);f.Pc=693;continue;}
case 693:{f.Push(JValue.R(rt.String("ThisTurnCast")));f.Pc=696;continue;}
case 696:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",699);}
case 699:{f.Pc=f.Pop().Int==0?732:702;continue;}
case 702:{f.Push(f.Locals[10]);f.Pc=704;continue;}
case 704:{f.Push(JValue.R(rt.String("_")));f.Pc=707;continue;}
case 707:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",710);}
case 710:{f.Locals[12]=f.Pop();f.Pc=712;continue;}
case 712:{f.Push(f.Locals[12]);f.Pc=714;continue;}
case 714:{f.Push(JValue.I(1));f.Pc=715;continue;}
case 715:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=716;continue;}
case 716:{f.Locals[13]=f.Pop();f.Pc=718;continue;}
case 718:{f.Push(f.Locals[13]);f.Pc=720;continue;}
case 720:{f.Push(f.Locals[2]);f.Pc=721;continue;}
case 721:{f.Push(f.Locals[1]);f.Pc=722;continue;}
case 722:{f.Push(f.Locals[4]);f.Pc=724;continue;}
case 724:{return rt.Call(f,"forge/game/card/CardUtil","getThisTurnCast","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",727);}
case 727:{f.Locals[11]=f.Pop();f.Pc=729;continue;}
case 729:{f.Pc=741;continue;}
case 732:{f.Push(f.Locals[2]);f.Pc=733;continue;}
case 733:{f.Push(f.Locals[10]);f.Pc=735;continue;}
case 735:{f.Push(f.Locals[1]);f.Pc=736;continue;}
case 736:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",739);}
case 739:{f.Locals[11]=f.Pop();f.Pc=741;continue;}
case 741:{f.Push(f.Locals[11]);f.Pc=743;continue;}
case 743:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",748);}
case 748:{f.Locals[12]=f.Pop();f.Pc=750;continue;}
case 750:{f.Push(f.Locals[12]);f.Pc=752;continue;}
case 752:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",757);}
case 757:{f.Pc=f.Pop().Int==0?830:760;continue;}
case 760:{f.Push(f.Locals[12]);f.Pc=762;continue;}
case 762:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",767);}
case 767:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=770;continue;}
case 770:{f.Locals[13]=f.Pop();f.Pc=772;continue;}
case 772:{f.Push(f.Locals[13]);f.Pc=774;continue;}
case 774:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",777);}
case 777:{return rt.Call(f,"forge/card/CardTypeView","getCoreTypes","()Ljava/util/Collection;","invokeinterface",782);}
case 782:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",787);}
case 787:{f.Locals[14]=f.Pop();f.Pc=789;continue;}
case 789:{f.Push(f.Locals[14]);f.Pc=791;continue;}
case 791:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",796);}
case 796:{f.Pc=f.Pop().Int==0?827:799;continue;}
case 799:{f.Push(f.Locals[14]);f.Pc=801;continue;}
case 801:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",806);}
case 806:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=809;continue;}
case 809:{f.Locals[15]=f.Pop();f.Pc=811;continue;}
case 811:{f.Push(f.Locals[9]);f.Pc=813;continue;}
case 813:{f.Push(f.Locals[15]);f.Pc=815;continue;}
case 815:{return rt.Call(f,"forge/card/CardType$CoreType","name","()Ljava/lang/String;","invokevirtual",818);}
case 818:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",823);}
case 823:{f.StackOp("pop");f.Pc=824;continue;}
case 824:{f.Pc=789;continue;}
case 827:{f.Pc=750;continue;}
case 830:{f.Push(f.Locals[2]);f.Pc=831;continue;}
case 831:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",834);}
case 834:{f.Locals[12]=f.Pop();f.Pc=836;continue;}
case 836:{f.Push(f.Locals[4]);f.Pc=838;continue;}
case 838:{f.Locals[13]=f.Pop();f.Pc=840;continue;}
case 840:{f.Push(f.Locals[1]);f.Pc=841;continue;}
case 841:{f.Push(JValue.R(rt.String("ChooseOrder")));f.Pc=843;continue;}
case 843:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",846);}
case 846:{f.Pc=f.Pop().Int==0?883:849;continue;}
case 849:{f.Push(f.Locals[1]);f.Pc=850;continue;}
case 850:{f.Push(JValue.R(rt.String("ChooseOrder")));f.Pc=852;continue;}
case 852:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",855);}
case 855:{f.Push(JValue.R(rt.String("True")));f.Pc=857;continue;}
case 857:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",860);}
case 860:{f.Pc=f.Pop().Int!=0?883:863;continue;}
case 863:{f.Push(f.Locals[2]);f.Pc=864;continue;}
case 864:{f.Push(f.Locals[1]);f.Pc=865;continue;}
case 865:{f.Push(JValue.R(rt.String("ChooseOrder")));f.Pc=867;continue;}
case 867:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",870);}
case 870:{f.Push(f.Locals[1]);f.Pc=871;continue;}
case 871:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",874);}
case 874:{f.Push(JValue.I(0));f.Pc=875;continue;}
case 875:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",878);}
case 878:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=881;continue;}
case 881:{f.Locals[13]=f.Pop();f.Pc=883;continue;}
case 883:{f.Push(f.Locals[9]);f.Pc=885;continue;}
case 885:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",890);}
case 890:{f.Pc=f.Pop().Int!=0?932:893;continue;}
case 893:{f.Push(f.Locals[13]);f.Pc=895;continue;}
case 895:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",898);}
case 898:{f.Push(JValue.R(rt.String("Card")));f.Pc=901;continue;}
case 901:{f.Push(f.Locals[1]);f.Pc=902;continue;}
case 902:{f.Push(f.Locals[9]);f.Pc=904;continue;}
case 904:{return rt.Call(f,"forge/game/player/PlayerController","chooseSomeType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/Collection;)Ljava/lang/String;","invokevirtual",907);}
case 907:{f.Locals[14]=f.Pop();f.Pc=909;continue;}
case 909:{f.Push(f.Locals[2]);f.Pc=910;continue;}
case 910:{f.Push(f.Locals[14]);f.Pc=912;continue;}
case 912:{return rt.Call(f,"forge/game/card/Card","setChosenType","(Ljava/lang/String;)V","invokevirtual",915);}
case 915:{f.Push(f.Locals[3]);f.Pc=916;continue;}
case 916:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",919);}
case 919:{f.Push(f.Locals[9]);f.Pc=921;continue;}
case 921:{f.Push(f.Locals[14]);f.Pc=923;continue;}
case 923:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",928);}
case 928:{f.StackOp("pop");f.Pc=929;continue;}
case 929:{f.Pc=883;continue;}
case 932:{f.Push(f.Locals[2]);f.Pc=933;continue;}
case 933:{f.Push(f.Locals[12]);f.Pc=935;continue;}
case 935:{return rt.Call(f,"forge/game/card/Card","setChosenType","(Ljava/lang/String;)V","invokevirtual",938);}
case 938:{f.Push(f.Locals[1]);f.Pc=939;continue;}
case 939:{f.Push(JValue.R(rt.String("RepeatPlayers")));f.Pc=942;continue;}
case 942:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",945);}
case 945:{f.Pc=f.Pop().Int==0?1135:948;continue;}
case 948:{f.Push(f.Locals[1]);f.Pc=949;continue;}
case 949:{f.Push(JValue.R(rt.String("RepeatPlayers")));f.Pc=952;continue;}
case 952:{return rt.Call(f,"forge/game/ability/effects/RepeatEachEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",955);}
case 955:{f.Locals[9]=f.Pop();f.Pc=957;continue;}
case 957:{f.Push(f.Locals[1]);f.Pc=958;continue;}
case 958:{f.Push(JValue.R(rt.String("ClearRememberedBeforeLoop")));f.Pc=961;continue;}
case 961:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",964);}
case 964:{f.Pc=f.Pop().Int==0?971:967;continue;}
case 967:{f.Push(f.Locals[2]);f.Pc=968;continue;}
case 968:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",971);}
case 971:{f.Push(f.Locals[1]);f.Pc=972;continue;}
case 972:{f.Push(JValue.R(rt.String("RepeatOptionalForEachPlayer")));f.Pc=975;continue;}
case 975:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",978);}
case 978:{f.Locals[10]=f.Pop();f.Pc=980;continue;}
case 980:{f.Push(f.Locals[1]);f.Pc=981;continue;}
case 981:{f.Push(JValue.R(rt.String("NextTurnForEachPlayer")));f.Pc=984;continue;}
case 984:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",987);}
case 987:{f.Locals[11]=f.Pop();f.Pc=989;continue;}
case 989:{f.Push(f.Locals[9]);f.Pc=991;continue;}
case 991:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",994);}
case 994:{f.Locals[12]=f.Pop();f.Pc=996;continue;}
case 996:{f.Push(f.Locals[12]);f.Pc=998;continue;}
case 998:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1003);}
case 1003:{f.Pc=f.Pop().Int==0?1135:1006;continue;}
case 1006:{f.Push(f.Locals[12]);f.Pc=1008;continue;}
case 1008:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1013);}
case 1013:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1016;continue;}
case 1016:{f.Locals[13]=f.Pop();f.Pc=1018;continue;}
case 1018:{f.Push(f.Locals[10]);f.Pc=1020;continue;}
case 1020:{f.Pc=f.Pop().Int==0?1047:1023;continue;}
case 1023:{f.Push(f.Locals[13]);f.Pc=1025;continue;}
case 1025:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1028);}
case 1028:{f.Push(f.Locals[3]);f.Pc=1029;continue;}
case 1029:{f.Push(JValue.R(null));f.Pc=1030;continue;}
case 1030:{f.Push(f.Locals[1]);f.Pc=1031;continue;}
case 1031:{f.Push(JValue.R(rt.String("RepeatOptionalMessage")));f.Pc=1034;continue;}
case 1034:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1037);}
case 1037:{f.Push(JValue.R(null));f.Pc=1038;continue;}
case 1038:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",1041);}
case 1041:{f.Pc=f.Pop().Int!=0?1047:1044;continue;}
case 1044:{f.Pc=996;continue;}
case 1047:{f.Push(f.Locals[11]);f.Pc=1049;continue;}
case 1049:{f.Pc=f.Pop().Int==0?1074:1052;continue;}
case 1052:{f.Push(f.Locals[5]);f.Pc=1054;continue;}
case 1054:{return rt.Call(f,"forge/game/Game","getCleanup","()Lforge/game/phase/Phase;","invokevirtual",1057);}
case 1057:{f.Push(f.Locals[13]);f.Pc=1059;continue;}
case 1059:{f.Push(f.Locals[2]);f.Pc=1060;continue;}
case 1060:{f.Push(f.Locals[13]);f.Pc=1062;continue;}
case 1062:{f.Push(f.Locals[3]);f.Pc=1063;continue;}
case 1063:{return rt.DynamicCall(f,"forge/game/ability/effects/RepeatEachEffect:3634:1063:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Lforge/GameCommand;",1068);}
case 1068:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",1071);}
case 1071:{f.Pc=1132;continue;}
case 1074:{f.Push(f.Locals[2]);f.Pc=1075;continue;}
case 1075:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",1078);}
case 1078:{f.Push(JValue.R(rt.ClassObject("forge/game/player/Player")));f.Pc=1080;continue;}
case 1080:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/lang/Iterable;","invokestatic",1083);}
case 1083:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",1086);}
case 1086:{f.Locals[14]=f.Pop();f.Pc=1088;continue;}
case 1088:{f.Push(f.Locals[2]);f.Pc=1089;continue;}
case 1089:{f.Push(f.Locals[14]);f.Pc=1091;continue;}
case 1091:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1094);}
case 1094:{f.Push(f.Locals[2]);f.Pc=1095;continue;}
case 1095:{f.Push(f.Locals[13]);f.Pc=1097;continue;}
case 1097:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1100);}
case 1100:{f.Push(f.Locals[1]);f.Pc=1101;continue;}
case 1101:{f.Push(JValue.R(rt.String("AmountFromVotes")));f.Pc=1103;continue;}
case 1103:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1106);}
case 1106:{f.Pc=f.Pop().Int==0?1116:1109;continue;}
case 1109:{f.Push(f.Locals[0]);f.Pc=1110;continue;}
case 1110:{f.Push(f.Locals[13]);f.Pc=1112;continue;}
case 1112:{f.Push(f.Locals[1]);f.Pc=1113;continue;}
case 1113:{return rt.Call(f,"forge/game/ability/effects/RepeatEachEffect","setVoteAmount","(Ljava/lang/Object;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1116);}
case 1116:{f.Push(f.Locals[3]);f.Pc=1117;continue;}
case 1117:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1120);}
case 1120:{f.Push(f.Locals[2]);f.Pc=1121;continue;}
case 1121:{f.Push(f.Locals[13]);f.Pc=1123;continue;}
case 1123:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",1126);}
case 1126:{f.Push(f.Locals[2]);f.Pc=1127;continue;}
case 1127:{f.Push(f.Locals[14]);f.Pc=1129;continue;}
case 1129:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1132);}
case 1132:{f.Pc=996;continue;}
case 1135:{f.Push(f.Locals[1]);f.Pc=1136;continue;}
case 1136:{f.Push(JValue.R(rt.String("DamageMap")));f.Pc=1138;continue;}
case 1138:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1141);}
case 1141:{f.Pc=f.Pop().Int==0?1166:1144;continue;}
case 1144:{f.Push(f.Locals[5]);f.Pc=1146;continue;}
case 1146:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1149);}
case 1149:{f.Push(JValue.I(0));f.Pc=1150;continue;}
case 1150:{f.Push(f.Locals[1]);f.Pc=1151;continue;}
case 1151:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDamageMap","()Lforge/game/card/CardDamageTable;","invokevirtual",1154);}
case 1154:{f.Push(f.Locals[1]);f.Pc=1155;continue;}
case 1155:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPreventMap","()Lforge/game/card/CardDamageTable;","invokevirtual",1158);}
case 1158:{f.Push(f.Locals[1]);f.Pc=1159;continue;}
case 1159:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCounterTable","()Lforge/game/GameEntityCounterTable;","invokevirtual",1162);}
case 1162:{f.Push(f.Locals[1]);f.Pc=1163;continue;}
case 1163:{return rt.Call(f,"forge/game/GameAction","dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1166);}
case 1166:{f.Push(f.Locals[1]);f.Pc=1167;continue;}
case 1167:{f.Push(JValue.R(rt.String("ChangeZoneTable")));f.Pc=1169;continue;}
case 1169:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1172);}
case 1172:{f.Pc=f.Pop().Int==0?1190:1175;continue;}
case 1175:{f.Push(f.Locals[1]);f.Pc=1176;continue;}
case 1176:{return rt.Call(f,"forge/game/spellability/SpellAbility","getChangeZoneTable","()Lforge/game/card/CardZoneTable;","invokevirtual",1179);}
case 1179:{f.Push(f.Locals[5]);f.Pc=1181;continue;}
case 1181:{f.Push(f.Locals[1]);f.Pc=1182;continue;}
case 1182:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1185);}
case 1185:{f.Push(f.Locals[1]);f.Pc=1186;continue;}
case 1186:{f.Push(JValue.R(null));f.Pc=1187;continue;}
case 1187:{return rt.Call(f,"forge/game/spellability/SpellAbility","setChangeZoneTable","(Lforge/game/card/CardZoneTable;)V","invokevirtual",1190);}
case 1190:{f.Push(f.Locals[1]);f.Pc=1191;continue;}
case 1191:{f.Push(JValue.R(rt.String("LoseLifeMap")));f.Pc=1193;continue;}
case 1193:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1196);}
case 1196:{f.Pc=f.Pop().Int==0?1241:1199;continue;}
case 1199:{f.Push(f.Locals[1]);f.Pc=1200;continue;}
case 1200:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLoseLifeMap","()Ljava/util/Map;","invokevirtual",1203);}
case 1203:{f.Locals[9]=f.Pop();f.Pc=1205;continue;}
case 1205:{f.Push(f.Locals[9]);f.Pc=1207;continue;}
case 1207:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",1212);}
case 1212:{f.Pc=f.Pop().Int!=0?1236:1215;continue;}
case 1215:{f.Push(f.Locals[9]);f.Pc=1217;continue;}
case 1217:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPIMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",1220);}
case 1220:{f.Locals[10]=f.Pop();f.Pc=1222;continue;}
case 1222:{f.Push(f.Locals[5]);f.Pc=1224;continue;}
case 1224:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1227);}
case 1227:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"));f.Pc=1230;continue;}
case 1230:{f.Push(f.Locals[10]);f.Pc=1232;continue;}
case 1232:{f.Push(JValue.I(0));f.Pc=1233;continue;}
case 1233:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1236);}
case 1236:{f.Push(f.Locals[1]);f.Pc=1237;continue;}
case 1237:{f.Push(JValue.R(null));f.Pc=1238;continue;}
case 1238:{return rt.Call(f,"forge/game/spellability/SpellAbility","setLoseLifeMap","(Ljava/util/Map;)V","invokevirtual",1241);}
case 1241:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3635(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","isWrapper","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?20:12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/WrappedAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getWrappedAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",24);}
case 24:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Vote","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Vote","Lforge/game/ability/ApiType;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?37:33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Pc=44;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Vote","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Vote","Lforge/game/ability/ApiType;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","findSubAbilityByType","(Lforge/game/ability/ApiType;)Lforge/game/spellability/SpellAbility;","invokevirtual",44);}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{f.Pc=f.Pop().Reference!=null?86:51;continue;}
case 51:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",58);}
case 58:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",61);}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",65);}
case 65:{return rt.DynamicCall(f,"forge/game/ability/effects/RepeatEachEffect:3635:65:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",70);}
case 70:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",73);}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("Votes")));f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("Number$0")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",83);}
case 83:{f.Pc=107;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("Votes")));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",96);}
case 96:{return rt.DynamicCall(f,"forge/game/ability/effects/RepeatEachEffect:3635:96:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",101);}
case 101:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",104);}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",107);}
case 107:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3636(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",11);}
case 11:{switch(f.Pop().Int){case 1107345399:f.Pc=28;break;default:f.Pc=40;break;}continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("lambda$resolve$ebfbd808$1")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Locals[2]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{switch(f.Pop().Int){case 0:f.Pc=60;break;default:f.Pc=164;break;}continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",64);}
case 64:{f.Push(JValue.I(6));f.Pc=66;continue;}
case 66:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?164:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?164:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Push(JValue.R(rt.String("run")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?164:95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Push(JValue.R(rt.String("()V")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?164:108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",112);}
case 112:{f.Push(JValue.R(rt.String("forge/game/ability/effects/RepeatEachEffect")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int==0?164:121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",125);}
case 125:{f.Push(JValue.R(rt.String("(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)V")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?164:134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(JValue.I(1));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",147);}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(JValue.I(2));f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",155);}
case 155:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=158;continue;}
case 158:{return rt.DynamicCall(f,"forge/game/ability/effects/RepeatEachEffect:3636:158:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Lforge/GameCommand;",163);}
case 163:{return JStep.Return(f.Pop());}
case 164:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=167;continue;}
case 167:{f.StackOp("dup");f.Pc=168;continue;}
case 168:{f.Push(JValue.R(rt.String("Invalid lambda deserialization")));f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",174);}
case 174:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3637(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.ClassObject("forge/game/player/Player")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/lang/Iterable;","invokestatic",9);}
case 9:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",37);}
case 37:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

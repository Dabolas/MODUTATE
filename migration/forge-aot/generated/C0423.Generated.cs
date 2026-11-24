// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C423{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/UnlockDoorEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3804,"forge/game/ability/effects/UnlockDoorEffect","<init>","()V",1,1,1,new JHandler[]{},M3804));
c.Add(new JMethod(3805,"forge/game/ability/effects/UnlockDoorEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,19,5,new JHandler[]{},M3805));
}

internal static JStep M3804(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3805(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Choices")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?129:25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{f.Locals[6]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?47:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Pc=64;continue;}
case 47:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",50);}
case 50:{f.Push(JValue.R(rt.String("lblChoose")));f.Pc=52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",59);}
case 59:{return rt.DynamicCall(f,"forge/game/ability/effects/UnlockDoorEffect:3805:59:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",64);}
case 64:{f.Locals[7]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",73);}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("Choices")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",79);}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",86);}
case 86:{f.Locals[8]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",93);}
case 93:{f.Push(f.Locals[8]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[7]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",101);}
case 101:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[9]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[9]);f.Pc=111;continue;}
case 111:{f.Pc=f.Pop().Reference!=null?115:114;continue;}
case 114:{return JStep.ReturnVoid;}
case 115:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(f.Locals[9]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",124);}
case 124:{f.Locals[5]=f.Pop();f.Pc=126;continue;}
case 126:{f.Pc=135;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/ability/effects/UnlockDoorEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",133);}
case 133:{f.Locals[5]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[5]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",140);}
case 140:{f.Locals[6]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(f.Locals[6]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",149);}
case 149:{f.Pc=f.Pop().Int==0?710:152;continue;}
case 152:{f.Push(f.Locals[6]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",159);}
case 159:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=162;continue;}
case 162:{f.Locals[7]=f.Pop();f.Pc=164;continue;}
case 164:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",167);}
case 167:{f.Locals[8]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[8]);f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("Object")));f.Pc=173;continue;}
case 173:{f.Push(f.Locals[7]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",180);}
case 180:{f.StackOp("pop");f.Pc=181;continue;}
case 181:{f.Push(f.Locals[1]);f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String("Mode")));f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("ThisDoor")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",189);}
case 189:{f.Locals[9]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(JValue.I(-1));f.Pc=192;continue;}
case 192:{f.Locals[10]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[9]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",199);}
case 199:{switch(f.Pop().Int){case -1756574876:f.Pc=248;break;case 1292684172:f.Pc=232;break;case 2100807026:f.Pc=264;break;default:f.Pc=277;break;}continue;}
case 232:{f.Push(f.Locals[9]);f.Pc=234;continue;}
case 234:{f.Push(JValue.R(rt.String("ThisDoor")));f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",239);}
case 239:{f.Pc=f.Pop().Int==0?277:242;continue;}
case 242:{f.Push(JValue.I(0));f.Pc=243;continue;}
case 243:{f.Locals[10]=f.Pop();f.Pc=245;continue;}
case 245:{f.Pc=277;continue;}
case 248:{f.Push(f.Locals[9]);f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("Unlock")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",255);}
case 255:{f.Pc=f.Pop().Int==0?277:258;continue;}
case 258:{f.Push(JValue.I(1));f.Pc=259;continue;}
case 259:{f.Locals[10]=f.Pop();f.Pc=261;continue;}
case 261:{f.Pc=277;continue;}
case 264:{f.Push(f.Locals[9]);f.Pc=266;continue;}
case 266:{f.Push(JValue.R(rt.String("LockOrUnlock")));f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",271);}
case 271:{f.Pc=f.Pop().Int==0?277:274;continue;}
case 274:{f.Push(JValue.I(2));f.Pc=275;continue;}
case 275:{f.Locals[10]=f.Pop();f.Pc=277;continue;}
case 277:{f.Push(f.Locals[10]);f.Pc=279;continue;}
case 279:{switch(f.Pop().Int){case 0:f.Pc=304;break;case 1:f.Pc=319;break;case 2:f.Pc=400;break;default:f.Pc=707;break;}continue;}
case 304:{f.Push(f.Locals[7]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[4]);f.Pc=308;continue;}
case 308:{f.Push(f.Locals[1]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardStateName","()Lforge/card/CardStateName;","invokevirtual",312);}
case 312:{return rt.Call(f,"forge/game/card/Card","unlockRoom","(Lforge/game/player/Player;Lforge/card/CardStateName;)Z","invokevirtual",315);}
case 315:{f.StackOp("pop");f.Pc=316;continue;}
case 316:{f.Pc=707;continue;}
case 319:{f.Push(f.Locals[7]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/card/Card","getLockedRooms","()Ljava/util/Set;","invokevirtual",324);}
case 324:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",329);}
case 329:{f.Push(f.Locals[7]);f.Pc=331;continue;}
case 331:{f.StackOp("dup");f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",335);}
case 335:{f.StackOp("pop");f.Pc=336;continue;}
case 336:{return rt.DynamicCall(f,"forge/game/ability/effects/UnlockDoorEffect:3805:336:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Function;",341);}
case 341:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",346);}
case 346:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",349);}
case 349:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",354);}
case 354:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=357;continue;}
case 357:{f.Locals[11]=f.Pop();f.Pc=359;continue;}
case 359:{f.Push(f.Locals[4]);f.Pc=361;continue;}
case 361:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",364);}
case 364:{f.Push(f.Locals[1]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[11]);f.Pc=367;continue;}
case 367:{f.Push(JValue.R(rt.String("Choose Room to unlock")));f.Pc=369;continue;}
case 369:{f.Push(f.Locals[8]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleCardState","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/CardState;","invokevirtual",374);}
case 374:{f.Locals[12]=f.Pop();f.Pc=376;continue;}
case 376:{f.Push(f.Locals[12]);f.Pc=378;continue;}
case 378:{f.Pc=f.Pop().Reference!=null?384:381;continue;}
case 381:{f.Pc=142;continue;}
case 384:{f.Push(f.Locals[7]);f.Pc=386;continue;}
case 386:{f.Push(f.Locals[4]);f.Pc=388;continue;}
case 388:{f.Push(f.Locals[12]);f.Pc=390;continue;}
case 390:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",393);}
case 393:{return rt.Call(f,"forge/game/card/Card","unlockRoom","(Lforge/game/player/Player;Lforge/card/CardStateName;)Z","invokevirtual",396);}
case 396:{f.StackOp("pop");f.Pc=397;continue;}
case 397:{f.Pc=707;continue;}
case 400:{f.Push(f.Locals[7]);f.Pc=402;continue;}
case 402:{return rt.Call(f,"forge/game/card/Card","getLockedRooms","()Ljava/util/Set;","invokevirtual",405);}
case 405:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",410);}
case 410:{switch(f.Pop().Int){case 0:f.Pc=436;break;case 1:f.Pc=517;break;case 2:f.Pc=629;break;default:f.Pc=707;break;}continue;}
case 436:{f.Push(f.Locals[7]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/game/card/Card","getUnlockedRooms","()Ljava/util/Set;","invokevirtual",441);}
case 441:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",446);}
case 446:{f.Push(f.Locals[7]);f.Pc=448;continue;}
case 448:{f.StackOp("dup");f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",452);}
case 452:{f.StackOp("pop");f.Pc=453;continue;}
case 453:{return rt.DynamicCall(f,"forge/game/ability/effects/UnlockDoorEffect:3805:453:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Function;",458);}
case 458:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",463);}
case 463:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",466);}
case 466:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",471);}
case 471:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=474;continue;}
case 474:{f.Locals[13]=f.Pop();f.Pc=476;continue;}
case 476:{f.Push(f.Locals[4]);f.Pc=478;continue;}
case 478:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",481);}
case 481:{f.Push(f.Locals[1]);f.Pc=482;continue;}
case 482:{f.Push(f.Locals[13]);f.Pc=484;continue;}
case 484:{f.Push(JValue.R(rt.String("Choose Room to lock")));f.Pc=486;continue;}
case 486:{f.Push(f.Locals[8]);f.Pc=488;continue;}
case 488:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleCardState","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/CardState;","invokevirtual",491);}
case 491:{f.Locals[14]=f.Pop();f.Pc=493;continue;}
case 493:{f.Push(f.Locals[14]);f.Pc=495;continue;}
case 495:{f.Pc=f.Pop().Reference!=null?501:498;continue;}
case 498:{f.Pc=142;continue;}
case 501:{f.Push(f.Locals[7]);f.Pc=503;continue;}
case 503:{f.Push(f.Locals[4]);f.Pc=505;continue;}
case 505:{f.Push(f.Locals[14]);f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",510);}
case 510:{return rt.Call(f,"forge/game/card/Card","lockRoom","(Lforge/game/player/Player;Lforge/card/CardStateName;)Z","invokevirtual",513);}
case 513:{f.StackOp("pop");f.Pc=514;continue;}
case 514:{f.Pc=707;continue;}
case 517:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",520);}
case 520:{f.Locals[15]=f.Pop();f.Pc=522;continue;}
case 522:{f.Push(f.Locals[15]);f.Pc=524;continue;}
case 524:{f.Push(f.Locals[7]);f.Pc=526;continue;}
case 526:{if(!rt.StaticReady(f,"forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","LeftSplit","Lforge/card/CardStateName;"));f.Pc=529;continue;}
case 529:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",532);}
case 532:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",537);}
case 537:{f.StackOp("pop");f.Pc=538;continue;}
case 538:{f.Push(f.Locals[15]);f.Pc=540;continue;}
case 540:{f.Push(f.Locals[7]);f.Pc=542;continue;}
case 542:{if(!rt.StaticReady(f,"forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","RightSplit","Lforge/card/CardStateName;"));f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",548);}
case 548:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",553);}
case 553:{f.StackOp("pop");f.Pc=554;continue;}
case 554:{f.Push(f.Locals[4]);f.Pc=556;continue;}
case 556:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",559);}
case 559:{f.Push(f.Locals[1]);f.Pc=560;continue;}
case 560:{f.Push(f.Locals[15]);f.Pc=562;continue;}
case 562:{f.Push(JValue.R(rt.String("Choose Room to lock or unlock")));f.Pc=564;continue;}
case 564:{f.Push(f.Locals[8]);f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleCardState","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/CardState;","invokevirtual",569);}
case 569:{f.Locals[16]=f.Pop();f.Pc=571;continue;}
case 571:{f.Push(f.Locals[16]);f.Pc=573;continue;}
case 573:{f.Pc=f.Pop().Reference!=null?579:576;continue;}
case 576:{f.Pc=142;continue;}
case 579:{f.Push(f.Locals[7]);f.Pc=581;continue;}
case 581:{return rt.Call(f,"forge/game/card/Card","getLockedRooms","()Ljava/util/Set;","invokevirtual",584);}
case 584:{f.Push(f.Locals[16]);f.Pc=586;continue;}
case 586:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",589);}
case 589:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",594);}
case 594:{f.Pc=f.Pop().Int==0?613:597;continue;}
case 597:{f.Push(f.Locals[7]);f.Pc=599;continue;}
case 599:{f.Push(f.Locals[4]);f.Pc=601;continue;}
case 601:{f.Push(f.Locals[16]);f.Pc=603;continue;}
case 603:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",606);}
case 606:{return rt.Call(f,"forge/game/card/Card","unlockRoom","(Lforge/game/player/Player;Lforge/card/CardStateName;)Z","invokevirtual",609);}
case 609:{f.StackOp("pop");f.Pc=610;continue;}
case 610:{f.Pc=707;continue;}
case 613:{f.Push(f.Locals[7]);f.Pc=615;continue;}
case 615:{f.Push(f.Locals[4]);f.Pc=617;continue;}
case 617:{f.Push(f.Locals[16]);f.Pc=619;continue;}
case 619:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",622);}
case 622:{return rt.Call(f,"forge/game/card/Card","lockRoom","(Lforge/game/player/Player;Lforge/card/CardStateName;)Z","invokevirtual",625);}
case 625:{f.StackOp("pop");f.Pc=626;continue;}
case 626:{f.Pc=707;continue;}
case 629:{f.Push(f.Locals[7]);f.Pc=631;continue;}
case 631:{return rt.Call(f,"forge/game/card/Card","getLockedRooms","()Ljava/util/Set;","invokevirtual",634);}
case 634:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",639);}
case 639:{f.Push(f.Locals[7]);f.Pc=641;continue;}
case 641:{f.StackOp("dup");f.Pc=642;continue;}
case 642:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",645);}
case 645:{f.StackOp("pop");f.Pc=646;continue;}
case 646:{return rt.DynamicCall(f,"forge/game/ability/effects/UnlockDoorEffect:3805:646:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Function;",651);}
case 651:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",656);}
case 656:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",659);}
case 659:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",664);}
case 664:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=667;continue;}
case 667:{f.Locals[17]=f.Pop();f.Pc=669;continue;}
case 669:{f.Push(f.Locals[4]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",674);}
case 674:{f.Push(f.Locals[1]);f.Pc=675;continue;}
case 675:{f.Push(f.Locals[17]);f.Pc=677;continue;}
case 677:{f.Push(JValue.R(rt.String("Choose Room to unlock")));f.Pc=679;continue;}
case 679:{f.Push(f.Locals[8]);f.Pc=681;continue;}
case 681:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleCardState","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/CardState;","invokevirtual",684);}
case 684:{f.Locals[18]=f.Pop();f.Pc=686;continue;}
case 686:{f.Push(f.Locals[18]);f.Pc=688;continue;}
case 688:{f.Pc=f.Pop().Reference!=null?694:691;continue;}
case 691:{f.Pc=142;continue;}
case 694:{f.Push(f.Locals[7]);f.Pc=696;continue;}
case 696:{f.Push(f.Locals[4]);f.Pc=698;continue;}
case 698:{f.Push(f.Locals[18]);f.Pc=700;continue;}
case 700:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",703);}
case 703:{return rt.Call(f,"forge/game/card/Card","unlockRoom","(Lforge/game/player/Player;Lforge/card/CardStateName;)Z","invokevirtual",706);}
case 706:{f.StackOp("pop");f.Pc=707;continue;}
case 707:{f.Pc=142;continue;}
case 710:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

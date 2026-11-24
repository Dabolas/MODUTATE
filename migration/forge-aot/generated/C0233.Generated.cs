// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C233{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChooseCardNameEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3139,"forge/game/ability/effects/ChooseCardNameEffect","<init>","()V",1,1,1,new JHandler[]{},M3139));
c.Add(new JMethod(3140,"forge/game/ability/effects/ChooseCardNameEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M3140));
c.Add(new JMethod(3141,"forge/game/ability/effects/ChooseCardNameEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,19,7,new JHandler[]{},M3141));
c.Add(new JMethod(3142,"forge/game/ability/effects/ChooseCardNameEffect","lambda$resolve$2","(Ljava/util/function/Predicate;Lforge/game/card/Card;Lforge/card/ICardFace;)Z",4106,3,2,new JHandler[]{},M3142));
c.Add(new JMethod(3143,"forge/game/ability/effects/ChooseCardNameEffect","lambda$resolve$1","(Ljava/lang/String;)Ljava/util/function/Predicate;",4106,1,1,new JHandler[]{},M3143));
c.Add(new JMethod(3144,"forge/game/ability/effects/ChooseCardNameEffect","lambda$resolve$0","(Lforge/card/ICardFace;)Z",4106,1,1,new JHandler[]{},M3144));
}

internal static JStep M3139(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3140(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/ChooseCardNameEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",7);}
case 7:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardNameEffect:3140:7:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3141(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("Card")));f.Pc=7;continue;}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(JValue.R(null));f.Pc=12;continue;}
case 12:{f.Locals[5]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?38:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("ValidDescription")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("AtRandom")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",44);}
case 44:{f.Locals[6]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("ChooseFromDefinedCards")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",52);}
case 52:{f.Locals[7]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("ChooseFromList")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",60);}
case 60:{f.Locals[8]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{f.Pc=f.Pop().Int!=0?129:67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("SelectPrompt")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?87:76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("SelectPrompt")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",82);}
case 82:{f.Locals[5]=f.Pop();f.Pc=84;continue;}
case 84:{f.Pc=129;continue;}
case 87:{f.Push(JValue.R(null));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?110:93;continue;}
case 93:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",96);}
case 96:{f.Push(JValue.R(rt.String("lblChooseACardName")));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",105);}
case 105:{f.Locals[5]=f.Pop();f.Pc=107;continue;}
case 107:{f.Pc=129;continue;}
case 110:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",113);}
case 113:{f.Push(JValue.R(rt.String("lblChooseASpecificCard")));f.Pc=115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=119;continue;}
case 119:{f.StackOp("dup");f.Pc=120;continue;}
case 120:{f.Push(JValue.I(0));f.Pc=121;continue;}
case 121:{f.Push(f.Locals[4]);f.Pc=123;continue;}
case 123:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",127);}
case 127:{f.Locals[5]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/ability/effects/ChooseCardNameEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",133);}
case 133:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",136);}
case 136:{f.Locals[9]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[9]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",145);}
case 145:{f.Pc=f.Pop().Int==0?899:148;continue;}
case 148:{f.Push(f.Locals[9]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",155);}
case 155:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=158;continue;}
case 158:{f.Locals[10]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[10]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",165);}
case 165:{f.Pc=f.Pop().Int!=0?171:168;continue;}
case 168:{f.Pc=138;continue;}
case 171:{f.Push(f.Locals[7]);f.Pc=173;continue;}
case 173:{f.Pc=f.Pop().Int==0?329:176;continue;}
case 176:{f.Push(f.Locals[2]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("ChooseFromDefinedCards")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",183);}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",187);}
case 187:{f.Locals[12]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[12]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[3]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[2]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",196);}
case 196:{f.Push(f.Locals[2]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[1]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",201);}
case 201:{f.Locals[12]=f.Pop();f.Pc=203;continue;}
case 203:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=206;continue;}
case 206:{f.StackOp("dup");f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",210);}
case 210:{f.Locals[13]=f.Pop();f.Pc=212;continue;}
case 212:{f.Push(f.Locals[12]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",217);}
case 217:{f.Locals[14]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[14]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",226);}
case 226:{f.Pc=f.Pop().Int==0?306:229;continue;}
case 229:{f.Push(f.Locals[14]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",236);}
case 236:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=239;continue;}
case 239:{f.Locals[15]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[15]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",246);}
case 246:{f.Locals[16]=f.Pop();f.Pc=248;continue;}
case 248:{f.Push(f.Locals[13]);f.Pc=250;continue;}
case 250:{f.Push(f.Locals[16]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",255);}
case 255:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",260);}
case 260:{f.Pc=f.Pop().Int==0?266:263;continue;}
case 263:{f.Pc=219;continue;}
case 266:{f.Push(f.Locals[13]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[16]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",273);}
case 273:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",278);}
case 278:{f.StackOp("pop");f.Pc=279;continue;}
case 279:{f.Push(f.Locals[16]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",284);}
case 284:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Split","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Split","Lforge/card/CardSplitType;"));f.Pc=287;continue;}
case 287:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?303:290;continue;}
case 290:{f.Push(f.Locals[13]);f.Pc=292;continue;}
case 292:{f.Push(f.Locals[16]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",297);}
case 297:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",302);}
case 302:{f.StackOp("pop");f.Pc=303;continue;}
case 303:{f.Pc=219;continue;}
case 306:{f.Push(f.Locals[13]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"java/util/Collections","sort","(Ljava/util/List;)V","invokestatic",311);}
case 311:{f.Push(f.Locals[10]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",316);}
case 316:{f.Push(f.Locals[1]);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[13]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[5]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardName","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",324);}
case 324:{f.Locals[11]=f.Pop();f.Pc=326;continue;}
case 326:{f.Pc=835;continue;}
case 329:{f.Push(f.Locals[8]);f.Pc=331;continue;}
case 331:{f.Pc=f.Pop().Int==0?485:334;continue;}
case 334:{f.Push(f.Locals[1]);f.Pc=335;continue;}
case 335:{f.Push(JValue.R(rt.String("ChooseFromList")));f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",340);}
case 340:{f.Push(JValue.R(rt.String(",")));f.Pc=342;continue;}
case 342:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",345);}
case 345:{f.Locals[12]=f.Pop();f.Pc=347;continue;}
case 347:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=350;continue;}
case 350:{f.StackOp("dup");f.Pc=351;continue;}
case 351:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",354);}
case 354:{f.Locals[13]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(f.Locals[12]);f.Pc=358;continue;}
case 358:{f.Locals[14]=f.Pop();f.Pc=360;continue;}
case 360:{f.Push(f.Locals[14]);f.Pc=362;continue;}
case 362:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=363;continue;}
case 363:{f.Locals[15]=f.Pop();f.Pc=365;continue;}
case 365:{f.Push(JValue.I(0));f.Pc=366;continue;}
case 366:{f.Locals[16]=f.Pop();f.Pc=368;continue;}
case 368:{f.Push(f.Locals[16]);f.Pc=370;continue;}
case 370:{f.Push(f.Locals[15]);f.Pc=372;continue;}
case 372:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?444:375;continue;}
case 375:{f.Push(f.Locals[14]);f.Pc=377;continue;}
case 377:{f.Push(f.Locals[16]);f.Pc=379;continue;}
case 379:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=380;continue;}
case 380:{f.Locals[17]=f.Pop();f.Pc=382;continue;}
case 382:{f.Push(f.Locals[17]);f.Pc=384;continue;}
case 384:{f.Push(JValue.R(rt.String(";")));f.Pc=386;continue;}
case 386:{f.Push(JValue.R(rt.String(",")));f.Pc=388;continue;}
case 388:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",391);}
case 391:{f.Locals[17]=f.Pop();f.Pc=393;continue;}
case 393:{f.Push(f.Locals[1]);f.Pc=394;continue;}
case 394:{f.Push(JValue.R(rt.String("ExcludeChosen")));f.Pc=396;continue;}
case 396:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",399);}
case 399:{f.Pc=f.Pop().Int==0?419:402;continue;}
case 402:{f.Push(f.Locals[2]);f.Pc=403;continue;}
case 403:{return rt.Call(f,"forge/game/card/Card","getNamedCards","()Ljava/util/List;","invokevirtual",406);}
case 406:{f.Push(f.Locals[17]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",413);}
case 413:{f.Pc=f.Pop().Int==0?419:416;continue;}
case 416:{f.Pc=438;continue;}
case 419:{f.Push(f.Locals[13]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",424);}
case 424:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",427);}
case 427:{f.Push(f.Locals[17]);f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/card/CardDb","getFaceByName","(Ljava/lang/String;)Lforge/card/ICardFace;","invokevirtual",432);}
case 432:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",437);}
case 437:{f.StackOp("pop");f.Pc=438;continue;}
case 438:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=441;continue;}
case 441:{f.Pc=368;continue;}
case 444:{f.Push(f.Locals[6]);f.Pc=446;continue;}
case 446:{f.Pc=f.Pop().Int==0?467:449;continue;}
case 449:{f.Push(f.Locals[13]);f.Pc=451;continue;}
case 451:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",454);}
case 454:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",462);}
case 462:{f.Locals[11]=f.Pop();f.Pc=464;continue;}
case 464:{f.Pc=482;continue;}
case 467:{f.Push(f.Locals[10]);f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",472);}
case 472:{f.Push(f.Locals[1]);f.Pc=473;continue;}
case 473:{f.Push(f.Locals[13]);f.Pc=475;continue;}
case 475:{f.Push(f.Locals[5]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardName","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",480);}
case 480:{f.Locals[11]=f.Pop();f.Pc=482;continue;}
case 482:{f.Pc=835;continue;}
case 485:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardNameEffect:3141:485:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",490);}
case 490:{f.Locals[12]=f.Pop();f.Pc=492;continue;}
case 492:{f.Push(f.Locals[1]);f.Pc=493;continue;}
case 493:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",498);}
case 498:{f.Pc=f.Pop().Int==0?759:501;continue;}
case 501:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",504);}
case 504:{f.Locals[13]=f.Pop();f.Pc=506;continue;}
case 506:{f.Push(f.Locals[3]);f.Pc=507;continue;}
case 507:{f.Push(JValue.R(rt.String(",")));f.Pc=509;continue;}
case 509:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",512);}
case 512:{f.Locals[14]=f.Pop();f.Pc=514;continue;}
case 514:{f.Push(f.Locals[14]);f.Pc=516;continue;}
case 516:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=517;continue;}
case 517:{f.Locals[15]=f.Pop();f.Pc=519;continue;}
case 519:{f.Push(JValue.I(0));f.Pc=520;continue;}
case 520:{f.Locals[16]=f.Pop();f.Pc=522;continue;}
case 522:{f.Push(f.Locals[16]);f.Pc=524;continue;}
case 524:{f.Push(f.Locals[15]);f.Pc=526;continue;}
case 526:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?695:529;continue;}
case 529:{f.Push(f.Locals[14]);f.Pc=531;continue;}
case 531:{f.Push(f.Locals[16]);f.Pc=533;continue;}
case 533:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=534;continue;}
case 534:{f.Locals[17]=f.Pop();f.Pc=536;continue;}
case 536:{f.Push(f.Locals[17]);f.Pc=538;continue;}
case 538:{f.Push(JValue.R(rt.String("cmcEQ")));f.Pc=540;continue;}
case 540:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",543);}
case 543:{f.Pc=f.Pop().Int==0?591:546;continue;}
case 546:{f.Push(f.Locals[17]);f.Pc=548;continue;}
case 548:{f.Push(JValue.R(rt.String("cmcEQ")));f.Pc=550;continue;}
case 550:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",553);}
case 553:{f.Push(JValue.I(1));f.Pc=554;continue;}
case 554:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=555;continue;}
case 555:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",558);}
case 558:{f.Pc=f.Pop().Int!=0?591:561;continue;}
case 561:{f.Push(f.Locals[17]);f.Pc=563;continue;}
case 563:{f.Push(JValue.R(rt.String("cmcEQ")));f.Pc=565;continue;}
case 565:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",568);}
case 568:{f.Push(JValue.I(1));f.Pc=569;continue;}
case 569:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=570;continue;}
case 570:{f.Locals[18]=f.Pop();f.Pc=572;continue;}
case 572:{f.Push(f.Locals[17]);f.Pc=574;continue;}
case 574:{f.Push(f.Locals[18]);f.Pc=576;continue;}
case 576:{f.Push(f.Locals[2]);f.Pc=577;continue;}
case 577:{f.Push(f.Locals[18]);f.Pc=579;continue;}
case 579:{f.Push(f.Locals[1]);f.Pc=580;continue;}
case 580:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",583);}
case 583:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",586);}
case 586:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",589);}
case 589:{f.Locals[17]=f.Pop();f.Pc=591;continue;}
case 591:{f.Push(f.Locals[17]);f.Pc=593;continue;}
case 593:{f.Push(JValue.R(rt.String("ManaCost=")));f.Pc=595;continue;}
case 595:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",598);}
case 598:{f.Pc=f.Pop().Int==0?679:601;continue;}
case 601:{f.Push(f.Locals[17]);f.Pc=603;continue;}
case 603:{f.Push(JValue.R(rt.String("ManaCost=Equipped")));f.Pc=605;continue;}
case 605:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",608);}
case 608:{f.Pc=f.Pop().Int==0?637:611;continue;}
case 611:{f.Push(f.Locals[2]);f.Pc=612;continue;}
case 612:{return rt.Call(f,"forge/game/card/Card","getEquipping","()Lforge/game/card/Card;","invokevirtual",615);}
case 615:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",618);}
case 618:{return rt.Call(f,"forge/card/mana/ManaCost","getShortString","()Ljava/lang/String;","invokevirtual",621);}
case 621:{f.Locals[18]=f.Pop();f.Pc=623;continue;}
case 623:{f.Push(f.Locals[17]);f.Pc=625;continue;}
case 625:{f.Push(JValue.R(rt.String("=Equipped")));f.Pc=627;continue;}
case 627:{f.Push(f.Locals[18]);f.Pc=629;continue;}
case 629:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",632);}
case 632:{f.Locals[17]=f.Pop();f.Pc=634;continue;}
case 634:{f.Pc=679;continue;}
case 637:{f.Push(f.Locals[17]);f.Pc=639;continue;}
case 639:{f.Push(JValue.R(rt.String("ManaCost=Imprinted")));f.Pc=641;continue;}
case 641:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",644);}
case 644:{f.Pc=f.Pop().Int==0?679:647;continue;}
case 647:{f.Push(f.Locals[2]);f.Pc=648;continue;}
case 648:{return rt.Call(f,"forge/game/card/Card","getImprintedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",651);}
case 651:{return rt.Call(f,"forge/game/card/CardCollectionView","getFirst","()Ljava/lang/Object;","invokeinterface",656);}
case 656:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=659;continue;}
case 659:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",662);}
case 662:{return rt.Call(f,"forge/card/mana/ManaCost","getShortString","()Ljava/lang/String;","invokevirtual",665);}
case 665:{f.Locals[18]=f.Pop();f.Pc=667;continue;}
case 667:{f.Push(f.Locals[17]);f.Pc=669;continue;}
case 669:{f.Push(JValue.R(rt.String("=Imprinted")));f.Pc=672;continue;}
case 672:{f.Push(f.Locals[18]);f.Pc=674;continue;}
case 674:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",677);}
case 677:{f.Locals[17]=f.Pop();f.Pc=679;continue;}
case 679:{f.Push(f.Locals[13]);f.Pc=681;continue;}
case 681:{f.Push(f.Locals[17]);f.Pc=683;continue;}
case 683:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",688);}
case 688:{f.StackOp("pop");f.Pc=689;continue;}
case 689:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=692;continue;}
case 692:{f.Pc=522;continue;}
case 695:{f.Push(JValue.R(rt.String(",")));f.Pc=697;continue;}
case 697:{f.Push(f.Locals[13]);f.Pc=699;continue;}
case 699:{return rt.Call(f,"java/lang/String","join","(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;","invokestatic",702);}
case 702:{f.Locals[3]=f.Pop();f.Pc=703;continue;}
case 703:{f.Push(f.Locals[13]);f.Pc=705;continue;}
case 705:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",710);}
case 710:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardNameEffect:3141:710:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",715);}
case 715:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",720);}
case 720:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",723);}
case 723:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",728);}
case 728:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=731;continue;}
case 731:{return rt.Call(f,"forge/util/IterableUtil","or","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;","invokestatic",734);}
case 734:{f.Locals[12]=f.Pop();f.Pc=736;continue;}
case 736:{f.Push(f.Locals[1]);f.Pc=737;continue;}
case 737:{f.Push(JValue.R(rt.String("ExcludeChosen")));f.Pc=739;continue;}
case 739:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",742);}
case 742:{f.Pc=f.Pop().Int==0?759:745;continue;}
case 745:{f.Push(f.Locals[12]);f.Pc=747;continue;}
case 747:{f.Locals[14]=f.Pop();f.Pc=749;continue;}
case 749:{f.Push(f.Locals[14]);f.Pc=751;continue;}
case 751:{f.Push(f.Locals[2]);f.Pc=752;continue;}
case 752:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardNameEffect:3141:752:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/function/Predicate;Lforge/game/card/Card;)Ljava/util/function/Predicate;",757);}
case 757:{f.Locals[12]=f.Pop();f.Pc=759;continue;}
case 759:{f.Push(f.Locals[6]);f.Pc=761;continue;}
case 761:{f.Pc=f.Pop().Int==0?819:764;continue;}
case 764:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",767);}
case 767:{return rt.Call(f,"forge/StaticData","ensureAllCardsLoaded","()V","invokevirtual",770);}
case 770:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",773);}
case 773:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",776);}
case 776:{return rt.Call(f,"forge/card/CardDb","streamAllFaces","()Ljava/util/stream/Stream;","invokevirtual",779);}
case 779:{f.Push(f.Locals[12]);f.Pc=781;continue;}
case 781:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",786);}
case 786:{return rt.Call(f,"forge/util/StreamUtil","random","()Ljava/util/stream/Collector;","invokestatic",789);}
case 789:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",794);}
case 794:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Optional"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=797;continue;}
case 797:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardNameEffect:3141:797:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",802);}
case 802:{return rt.Call(f,"java/util/Optional","map","(Ljava/util/function/Function;)Ljava/util/Optional;","invokevirtual",805);}
case 805:{f.Push(JValue.R(rt.String("")));f.Pc=808;continue;}
case 808:{return rt.Call(f,"java/util/Optional","orElse","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",811);}
case 811:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=814;continue;}
case 814:{f.Locals[11]=f.Pop();f.Pc=816;continue;}
case 816:{f.Pc=835;continue;}
case 819:{f.Push(f.Locals[10]);f.Pc=821;continue;}
case 821:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",824);}
case 824:{f.Push(f.Locals[1]);f.Pc=825;continue;}
case 825:{f.Push(f.Locals[12]);f.Pc=827;continue;}
case 827:{f.Push(f.Locals[3]);f.Pc=828;continue;}
case 828:{f.Push(f.Locals[5]);f.Pc=830;continue;}
case 830:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardName","(Lforge/game/spellability/SpellAbility;Ljava/util/function/Predicate;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",833);}
case 833:{f.Locals[11]=f.Pop();f.Pc=835;continue;}
case 835:{f.Push(f.Locals[11]);f.Pc=837;continue;}
case 837:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",840);}
case 840:{f.Pc=f.Pop().Int!=0?884:843;continue;}
case 843:{f.Push(f.Locals[2]);f.Pc=844;continue;}
case 844:{f.Push(f.Locals[11]);f.Pc=846;continue;}
case 846:{return rt.Call(f,"forge/game/card/Card","addNamedCard","(Ljava/lang/String;)V","invokevirtual",849);}
case 849:{f.Push(f.Locals[10]);f.Pc=851;continue;}
case 851:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",854);}
case 854:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=857;continue;}
case 857:{f.StackOp("dup");f.Pc=858;continue;}
case 858:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=861;continue;}
case 861:{f.Push(f.Locals[10]);f.Pc=863;continue;}
case 863:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",866);}
case 866:{f.Push(f.Locals[11]);f.Pc=868;continue;}
case 868:{f.Push(f.Locals[2]);f.Pc=869;continue;}
case 869:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",872);}
case 872:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseCardNameEffect:3141:872:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",877);}
case 877:{f.Push(f.Locals[2]);f.Pc=878;continue;}
case 878:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/Card;)V","invokespecial",881);}
case 881:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",884);}
case 884:{f.Push(f.Locals[6]);f.Pc=886;continue;}
case 886:{f.Pc=f.Pop().Int!=0?896:889;continue;}
case 889:{f.Push(f.Locals[10]);f.Pc=891;continue;}
case 891:{f.Push(f.Locals[11]);f.Pc=893;continue;}
case 893:{return rt.Call(f,"forge/game/player/Player","setNamedCard","(Ljava/lang/String;)V","invokevirtual",896);}
case 896:{f.Pc=138;continue;}
case 899:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3142(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",7);}
case 7:{f.Pc=f.Pop().Int==0?32:10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getNamedCards","()Ljava/util/List;","invokevirtual",14);}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",20);}
case 20:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int!=0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3143(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardFacePredicates","valid","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3144(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

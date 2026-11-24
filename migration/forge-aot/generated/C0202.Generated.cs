// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C202{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AnimateEffectBase","forge/game/ability/SpellAbilityEffect",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3025,"forge/game/ability/effects/AnimateEffectBase","<init>","()V",1,1,1,new JHandler[]{},M3025));
c.Add(new JMethod(3026,"forge/game/ability/effects/AnimateEffectBase","doAnimate","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/Integer;Ljava/lang/Integer;Lforge/card/CardType;Lforge/card/CardType;Lforge/card/ColorSet;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;JLjava/lang/String;)V",9,33,11,new JHandler[]{},M3026));
c.Add(new JMethod(3027,"forge/game/ability/effects/AnimateEffectBase","doUnanimate","(Lforge/game/card/Card;J)V",8,3,5,new JHandler[]{},M3027));
c.Add(new JMethod(3028,"forge/game/ability/effects/AnimateEffectBase","lambda$doAnimate$1","(Lforge/game/spellability/SpellAbility;Lforge/game/CardTraitBase;)Z",4106,2,2,new JHandler[]{},M3028));
c.Add(new JMethod(3029,"forge/game/ability/effects/AnimateEffectBase","lambda$doAnimate$0","(Lforge/game/CardTraitBase;)Z",4106,1,1,new JHandler[]{},M3029));
}

internal static JStep M3025(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3026(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[17]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[17]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",11);}
case 11:{f.Locals[18]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("Perpetual")));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[16]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",20);}
case 20:{f.Locals[19]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("AddAllCreatureTypes")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",28);}
case 28:{f.Locals[20]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.ClassObject("forge/card/RemoveType")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",35);}
case 35:{f.Locals[21]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("RemoveSuperTypes")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?57:46;continue;}
case 46:{f.Push(f.Locals[21]);f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/card/RemoveType","SuperTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","SuperTypes","Lforge/card/RemoveType;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("RemoveCardTypes")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?77:66;continue;}
case 66:{f.Push(f.Locals[21]);f.Pc=68;continue;}
case 68:{if(!rt.StaticReady(f,"forge/card/RemoveType","CardTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","CardTypes","Lforge/card/RemoveType;"));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",76);}
case 76:{f.StackOp("pop");f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("RemoveSubTypes")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int==0?97:86;continue;}
case 86:{f.Push(f.Locals[21]);f.Pc=88;continue;}
case 88:{if(!rt.StaticReady(f,"forge/card/RemoveType","SubTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","SubTypes","Lforge/card/RemoveType;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",96);}
case 96:{f.StackOp("pop");f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("RemoveLandTypes")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",103);}
case 103:{f.Pc=f.Pop().Int==0?117:106;continue;}
case 106:{f.Push(f.Locals[21]);f.Pc=108;continue;}
case 108:{if(!rt.StaticReady(f,"forge/card/RemoveType","LandTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","LandTypes","Lforge/card/RemoveType;"));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",116);}
case 116:{f.StackOp("pop");f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("RemoveCreatureTypes")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int==0?137:126;continue;}
case 126:{f.Push(f.Locals[21]);f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/card/RemoveType","CreatureTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","CreatureTypes","Lforge/card/RemoveType;"));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",136);}
case 136:{f.StackOp("pop");f.Pc=137;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("RemoveArtifactTypes")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Int==0?157:146;continue;}
case 146:{f.Push(f.Locals[21]);f.Pc=148;continue;}
case 148:{if(!rt.StaticReady(f,"forge/card/RemoveType","ArtifactTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","ArtifactTypes","Lforge/card/RemoveType;"));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",156);}
case 156:{f.StackOp("pop");f.Pc=157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("RemoveEnchantmentTypes")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",163);}
case 163:{f.Pc=f.Pop().Int==0?177:166;continue;}
case 166:{f.Push(f.Locals[21]);f.Pc=168;continue;}
case 168:{if(!rt.StaticReady(f,"forge/card/RemoveType","EnchantmentTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","EnchantmentTypes","Lforge/card/RemoveType;"));f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",176);}
case 176:{f.StackOp("pop");f.Pc=177;continue;}
case 177:{f.Push(JValue.R(null));f.Pc=178;continue;}
case 178:{f.Locals[22]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(JValue.I(0));f.Pc=181;continue;}
case 181:{f.Locals[23]=f.Pop();f.Pc=183;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("RemoveAllAbilities")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int==0?205:192;continue;}
case 192:{return rt.DynamicCall(f,"forge/game/ability/effects/AnimateEffectBase:3026:192:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",197);}
case 197:{f.Locals[22]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(JValue.I(1));f.Pc=200;continue;}
case 200:{f.Locals[23]=f.Pop();f.Pc=202;continue;}
case 202:{f.Pc=247;continue;}
case 205:{f.Push(f.Locals[1]);f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String("RemoveNonManaAbilities")));f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",211);}
case 211:{f.Pc=f.Pop().Int==0?230:214;continue;}
case 214:{return rt.DynamicCall(f,"forge/game/ability/effects/AnimateEffectBase:3026:214:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",219);}
case 219:{return rt.Call(f,"java/util/function/Predicate","not","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",222);}
case 222:{f.Locals[22]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(JValue.I(1));f.Pc=225;continue;}
case 225:{f.Locals[23]=f.Pop();f.Pc=227;continue;}
case 227:{f.Pc=247;continue;}
case 230:{f.Push(f.Locals[1]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String("RemoveThisAbility")));f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",236);}
case 236:{f.Pc=f.Pop().Int==0?247:239;continue;}
case 239:{f.Push(f.Locals[1]);f.Pc=240;continue;}
case 240:{return rt.DynamicCall(f,"forge/game/ability/effects/AnimateEffectBase:3026:240:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;",245);}
case 245:{f.Locals[22]=f.Pop();f.Pc=247;continue;}
case 247:{f.Push(f.Locals[1]);f.Pc=248;continue;}
case 248:{f.Push(JValue.R(rt.String("RememberAnimated")));f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",253);}
case 253:{f.Pc=f.Pop().Int==0?262:256;continue;}
case 256:{f.Push(f.Locals[17]);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[0]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",262);}
case 262:{f.Push(f.Locals[0]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",266);}
case 266:{f.Locals[24]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[1]);f.Pc=269;continue;}
case 269:{f.Push(JValue.R(rt.String("Incorporate")));f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",274);}
case 274:{f.Pc=f.Pop().Int==0?317:277;continue;}
case 277:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=280;continue;}
case 280:{f.StackOp("dup");f.Pc=281;continue;}
case 281:{f.Push(f.Locals[1]);f.Pc=282;continue;}
case 282:{f.Push(JValue.R(rt.String("Incorporate")));f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",287);}
case 287:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",290);}
case 290:{f.Locals[25]=f.Pop();f.Pc=292;continue;}
case 292:{if(!rt.EnsureInitialized(f,"forge/game/card/perpetual/PerpetualIncorporate"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/perpetual/PerpetualIncorporate")));f.Pc=295;continue;}
case 295:{f.StackOp("dup");f.Pc=296;continue;}
case 296:{f.Push(f.Locals[14]);f.Pc=298;continue;}
case 298:{f.Push(f.Locals[25]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/card/perpetual/PerpetualIncorporate","<init>","(JLforge/card/mana/ManaCost;)V","invokespecial",303);}
case 303:{f.Locals[26]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[0]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[26]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/card/Card","addPerpetual","(Lforge/game/card/perpetual/PerpetualInterface;)V","invokevirtual",311);}
case 311:{f.Push(f.Locals[26]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[0]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/card/perpetual/PerpetualIncorporate","applyEffect","(Lforge/game/card/Card;)V","invokevirtual",317);}
case 317:{f.Push(f.Locals[1]);f.Pc=318;continue;}
case 318:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",323);}
case 323:{f.Pc=f.Pop().Int==0?371:326;continue;}
case 326:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=329;continue;}
case 329:{f.StackOp("dup");f.Pc=330;continue;}
case 330:{f.Push(f.Locals[1]);f.Pc=331;continue;}
case 331:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",336);}
case 336:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",339);}
case 339:{f.Locals[25]=f.Pop();f.Pc=341;continue;}
case 341:{f.Push(f.Locals[19]);f.Pc=343;continue;}
case 343:{f.Pc=f.Pop().Int==0?371:346;continue;}
case 346:{if(!rt.EnsureInitialized(f,"forge/game/card/perpetual/PerpetualManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/perpetual/PerpetualManaCost")));f.Pc=349;continue;}
case 349:{f.StackOp("dup");f.Pc=350;continue;}
case 350:{f.Push(f.Locals[14]);f.Pc=352;continue;}
case 352:{f.Push(f.Locals[25]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/card/perpetual/PerpetualManaCost","<init>","(JLforge/card/mana/ManaCost;)V","invokespecial",357);}
case 357:{f.Locals[26]=f.Pop();f.Pc=359;continue;}
case 359:{f.Push(f.Locals[0]);f.Pc=360;continue;}
case 360:{f.Push(f.Locals[26]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/card/Card","addPerpetual","(Lforge/game/card/perpetual/PerpetualInterface;)V","invokevirtual",365);}
case 365:{f.Push(f.Locals[26]);f.Pc=367;continue;}
case 367:{f.Push(f.Locals[0]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/card/perpetual/PerpetualManaCost","applyEffect","(Lforge/game/card/Card;)V","invokevirtual",371);}
case 371:{f.Push(f.Locals[4]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/card/CardType","isEmpty","()Z","invokevirtual",376);}
case 376:{f.Pc=f.Pop().Int==0?402:379;continue;}
case 379:{f.Push(f.Locals[5]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/card/CardType","isEmpty","()Z","invokevirtual",384);}
case 384:{f.Pc=f.Pop().Int==0?402:387;continue;}
case 387:{f.Push(f.Locals[20]);f.Pc=389;continue;}
case 389:{f.Pc=f.Pop().Int!=0?402:392;continue;}
case 392:{f.Push(f.Locals[21]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",399);}
case 399:{f.Pc=f.Pop().Int!=0?460:402;continue;}
case 402:{f.Push(f.Locals[19]);f.Pc=404;continue;}
case 404:{f.Pc=f.Pop().Int==0?426:407;continue;}
case 407:{f.Push(f.Locals[0]);f.Pc=408;continue;}
case 408:{if(!rt.EnsureInitialized(f,"forge/game/card/perpetual/PerpetualTypes"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/perpetual/PerpetualTypes")));f.Pc=411;continue;}
case 411:{f.StackOp("dup");f.Pc=412;continue;}
case 412:{f.Push(f.Locals[14]);f.Pc=414;continue;}
case 414:{f.Push(f.Locals[4]);f.Pc=416;continue;}
case 416:{f.Push(f.Locals[5]);f.Pc=418;continue;}
case 418:{f.Push(f.Locals[21]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/card/perpetual/PerpetualTypes","<init>","(JLforge/card/CardType;Lforge/card/CardType;Ljava/util/Set;)V","invokespecial",423);}
case 423:{return rt.Call(f,"forge/game/card/Card","addPerpetual","(Lforge/game/card/perpetual/PerpetualInterface;)V","invokevirtual",426);}
case 426:{f.Push(f.Locals[0]);f.Pc=427;continue;}
case 427:{f.Push(f.Locals[4]);f.Pc=429;continue;}
case 429:{f.Push(f.Locals[5]);f.Pc=431;continue;}
case 431:{f.Push(f.Locals[20]);f.Pc=433;continue;}
case 433:{f.Push(f.Locals[21]);f.Pc=435;continue;}
case 435:{f.Push(f.Locals[14]);f.Pc=437;continue;}
case 437:{f.Push(JValue.L(0));f.Pc=438;continue;}
case 438:{f.Push(JValue.I(1));f.Pc=439;continue;}
case 439:{f.Push(JValue.I(0));f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/game/card/Card","addChangedCardTypes","(Lforge/card/CardType;Lforge/card/CardType;ZLjava/util/Set;JJZZ)V","invokevirtual",443);}
case 443:{f.Push(f.Locals[21]);f.Pc=445;continue;}
case 445:{if(!rt.StaticReady(f,"forge/card/RemoveType","LandTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","LandTypes","Lforge/card/RemoveType;"));f.Pc=448;continue;}
case 448:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",453);}
case 453:{f.Pc=f.Pop().Int==0?460:456;continue;}
case 456:{f.Push(f.Locals[0]);f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",460);}
case 460:{f.Push(f.Locals[7]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",467);}
case 467:{f.Pc=f.Pop().Int==0?485:470;continue;}
case 470:{f.Push(f.Locals[8]);f.Pc=472;continue;}
case 472:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",477);}
case 477:{f.Pc=f.Pop().Int==0?485:480;continue;}
case 480:{f.Push(f.Locals[23]);f.Pc=482;continue;}
case 482:{f.Pc=f.Pop().Int==0?522:485;continue;}
case 485:{f.Push(f.Locals[19]);f.Pc=487;continue;}
case 487:{f.Pc=f.Pop().Int==0?509:490;continue;}
case 490:{f.Push(f.Locals[0]);f.Pc=491;continue;}
case 491:{if(!rt.EnsureInitialized(f,"forge/game/card/perpetual/PerpetualKeywords"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/perpetual/PerpetualKeywords")));f.Pc=494;continue;}
case 494:{f.StackOp("dup");f.Pc=495;continue;}
case 495:{f.Push(f.Locals[14]);f.Pc=497;continue;}
case 497:{f.Push(f.Locals[7]);f.Pc=499;continue;}
case 499:{f.Push(f.Locals[8]);f.Pc=501;continue;}
case 501:{f.Push(f.Locals[23]);f.Pc=503;continue;}
case 503:{return rt.Call(f,"forge/game/card/perpetual/PerpetualKeywords","<init>","(JLjava/util/List;Ljava/util/List;Z)V","invokespecial",506);}
case 506:{return rt.Call(f,"forge/game/card/Card","addPerpetual","(Lforge/game/card/perpetual/PerpetualInterface;)V","invokevirtual",509);}
case 509:{f.Push(f.Locals[0]);f.Pc=510;continue;}
case 510:{f.Push(f.Locals[7]);f.Pc=512;continue;}
case 512:{f.Push(f.Locals[8]);f.Pc=514;continue;}
case 514:{f.Push(f.Locals[23]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[14]);f.Pc=518;continue;}
case 518:{f.Push(JValue.R(null));f.Pc=519;continue;}
case 519:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",522);}
case 522:{f.Push(f.Locals[2]);f.Pc=523;continue;}
case 523:{f.Pc=f.Pop().Reference!=null?530:526;continue;}
case 526:{f.Push(f.Locals[3]);f.Pc=527;continue;}
case 527:{f.Pc=f.Pop().Reference==null?562:530;continue;}
case 530:{f.Push(f.Locals[19]);f.Pc=532;continue;}
case 532:{f.Pc=f.Pop().Int==0?550:535;continue;}
case 535:{f.Push(f.Locals[0]);f.Pc=536;continue;}
case 536:{if(!rt.EnsureInitialized(f,"forge/game/card/perpetual/PerpetualNewPT"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/perpetual/PerpetualNewPT")));f.Pc=539;continue;}
case 539:{f.StackOp("dup");f.Pc=540;continue;}
case 540:{f.Push(f.Locals[14]);f.Pc=542;continue;}
case 542:{f.Push(f.Locals[2]);f.Pc=543;continue;}
case 543:{f.Push(f.Locals[3]);f.Pc=544;continue;}
case 544:{return rt.Call(f,"forge/game/card/perpetual/PerpetualNewPT","<init>","(JLjava/lang/Integer;Ljava/lang/Integer;)V","invokespecial",547);}
case 547:{return rt.Call(f,"forge/game/card/Card","addPerpetual","(Lforge/game/card/perpetual/PerpetualInterface;)V","invokevirtual",550);}
case 550:{f.Push(f.Locals[0]);f.Pc=551;continue;}
case 551:{f.Push(f.Locals[2]);f.Pc=552;continue;}
case 552:{f.Push(f.Locals[3]);f.Pc=553;continue;}
case 553:{f.Push(f.Locals[14]);f.Pc=555;continue;}
case 555:{f.Push(JValue.L(0));f.Pc=556;continue;}
case 556:{return rt.Call(f,"forge/game/card/Card","addNewPT","(Ljava/lang/Integer;Ljava/lang/Integer;JJ)V","invokevirtual",559);}
case 559:{f.Pc=578;continue;}
case 562:{f.Push(f.Locals[24]);f.Pc=564;continue;}
case 564:{f.Pc=f.Pop().Int!=0?578:567;continue;}
case 567:{f.Push(f.Locals[0]);f.Pc=568;continue;}
case 568:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",571);}
case 571:{f.Pc=f.Pop().Int==0?578:574;continue;}
case 574:{f.Push(f.Locals[0]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"forge/game/card/Card","updatePTforView","()V","invokevirtual",578);}
case 578:{f.Push(f.Locals[1]);f.Pc=579;continue;}
case 579:{f.Push(JValue.R(rt.String("CantHaveKeyword")));f.Pc=581;continue;}
case 581:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",584);}
case 584:{f.Pc=f.Pop().Int==0?605:587;continue;}
case 587:{f.Push(f.Locals[0]);f.Pc=588;continue;}
case 588:{f.Push(f.Locals[14]);f.Pc=590;continue;}
case 590:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",593);}
case 593:{f.Push(f.Locals[1]);f.Pc=594;continue;}
case 594:{f.Push(JValue.R(rt.String("CantHaveKeyword")));f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",599);}
case 599:{return rt.Call(f,"forge/game/keyword/Keyword","setValueOf","(Ljava/lang/String;)Ljava/util/Set;","invokestatic",602);}
case 602:{return rt.Call(f,"forge/game/card/Card","addCantHaveKeyword","(Ljava/lang/Long;Ljava/lang/Iterable;)V","invokevirtual",605);}
case 605:{f.Push(f.Locals[9]);f.Pc=607;continue;}
case 607:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",612);}
case 612:{f.Pc=f.Pop().Int!=0?624:615;continue;}
case 615:{f.Push(f.Locals[0]);f.Pc=616;continue;}
case 616:{f.Push(f.Locals[14]);f.Pc=618;continue;}
case 618:{f.Push(JValue.L(0));f.Pc=619;continue;}
case 619:{f.Push(f.Locals[9]);f.Pc=621;continue;}
case 621:{return rt.Call(f,"forge/game/card/Card","addHiddenExtrinsicKeywords","(JJLjava/lang/Iterable;)V","invokevirtual",624);}
case 624:{f.Push(f.Locals[6]);f.Pc=626;continue;}
case 626:{f.Pc=f.Pop().Reference==null?678:629;continue;}
case 629:{f.Push(f.Locals[1]);f.Pc=630;continue;}
case 630:{f.Push(JValue.R(rt.String("OverwriteColors")));f.Pc=632;continue;}
case 632:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",635);}
case 635:{f.Locals[25]=f.Pop();f.Pc=637;continue;}
case 637:{f.Push(f.Locals[19]);f.Pc=639;continue;}
case 639:{f.Pc=f.Pop().Int==0?659:642;continue;}
case 642:{f.Push(f.Locals[0]);f.Pc=643;continue;}
case 643:{if(!rt.EnsureInitialized(f,"forge/game/card/perpetual/PerpetualColors"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/perpetual/PerpetualColors")));f.Pc=646;continue;}
case 646:{f.StackOp("dup");f.Pc=647;continue;}
case 647:{f.Push(f.Locals[14]);f.Pc=649;continue;}
case 649:{f.Push(f.Locals[6]);f.Pc=651;continue;}
case 651:{f.Push(f.Locals[25]);f.Pc=653;continue;}
case 653:{return rt.Call(f,"forge/game/card/perpetual/PerpetualColors","<init>","(JLforge/card/ColorSet;Z)V","invokespecial",656);}
case 656:{return rt.Call(f,"forge/game/card/Card","addPerpetual","(Lforge/game/card/perpetual/PerpetualInterface;)V","invokevirtual",659);}
case 659:{f.Push(f.Locals[0]);f.Pc=660;continue;}
case 660:{f.Push(f.Locals[6]);f.Pc=662;continue;}
case 662:{f.Push(f.Locals[25]);f.Pc=664;continue;}
case 664:{f.Pc=f.Pop().Int!=0?671:667;continue;}
case 667:{f.Push(JValue.I(1));f.Pc=668;continue;}
case 668:{f.Pc=672;continue;}
case 671:{f.Push(JValue.I(0));f.Pc=672;continue;}
case 672:{f.Push(f.Locals[14]);f.Pc=674;continue;}
case 674:{f.Push(JValue.R(null));f.Pc=675;continue;}
case 675:{return rt.Call(f,"forge/game/card/Card","addColor","(Lforge/card/ColorSet;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",678);}
case 678:{f.Push(f.Locals[1]);f.Pc=679;continue;}
case 679:{f.Push(JValue.R(rt.String("LeaveBattlefield")));f.Pc=681;continue;}
case 681:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",684);}
case 684:{f.Pc=f.Pop().Int==0?698:687;continue;}
case 687:{f.Push(f.Locals[0]);f.Pc=688;continue;}
case 688:{f.Push(f.Locals[1]);f.Pc=689;continue;}
case 689:{f.Push(f.Locals[1]);f.Pc=690;continue;}
case 690:{f.Push(JValue.R(rt.String("LeaveBattlefield")));f.Pc=692;continue;}
case 692:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",695);}
case 695:{return rt.Call(f,"forge/game/ability/effects/AnimateEffectBase","addLeaveBattlefieldReplacement","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;)V","invokestatic",698);}
case 698:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",701);}
case 701:{f.Locals[25]=f.Pop();f.Pc=703;continue;}
case 703:{f.Push(f.Locals[10]);f.Pc=705;continue;}
case 705:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",710);}
case 710:{f.Locals[26]=f.Pop();f.Pc=712;continue;}
case 712:{f.Push(f.Locals[26]);f.Pc=714;continue;}
case 714:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",719);}
case 719:{f.Pc=f.Pop().Int==0?785:722;continue;}
case 722:{f.Push(f.Locals[26]);f.Pc=724;continue;}
case 724:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",729);}
case 729:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=732;continue;}
case 732:{f.Locals[27]=f.Pop();f.Pc=734;continue;}
case 734:{f.Push(f.Locals[0]);f.Pc=735;continue;}
case 735:{f.Push(f.Locals[27]);f.Pc=737;continue;}
case 737:{f.Push(f.Locals[1]);f.Pc=738;continue;}
case 738:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",741);}
case 741:{f.Locals[28]=f.Pop();f.Pc=743;continue;}
case 743:{f.Push(f.Locals[25]);f.Pc=745;continue;}
case 745:{f.Push(f.Locals[28]);f.Pc=747;continue;}
case 747:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",752);}
case 752:{f.StackOp("pop");f.Pc=753;continue;}
case 753:{f.Push(f.Locals[1]);f.Pc=754;continue;}
case 754:{f.Push(JValue.R(rt.String("TransferActivator")));f.Pc=756;continue;}
case 756:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",759);}
case 759:{f.Pc=f.Pop().Int==0?782:762;continue;}
case 762:{f.Push(f.Locals[28]);f.Pc=764;continue;}
case 764:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",767);}
case 767:{f.Push(f.Locals[1]);f.Pc=768;continue;}
case 768:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",771);}
case 771:{return rt.Call(f,"forge/game/player/Player","getId","()I","invokevirtual",774);}
case 774:{return rt.DynamicCall(f,"forge/game/ability/effects/AnimateEffectBase:3026:774:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",779);}
case 779:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setActivator","(Ljava/lang/String;)V","invokevirtual",782);}
case 782:{f.Pc=712;continue;}
case 785:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",788);}
case 788:{f.Locals[26]=f.Pop();f.Pc=790;continue;}
case 790:{f.Push(f.Locals[11]);f.Pc=792;continue;}
case 792:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",797);}
case 797:{f.Locals[27]=f.Pop();f.Pc=799;continue;}
case 799:{f.Push(f.Locals[27]);f.Pc=801;continue;}
case 801:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",806);}
case 806:{f.Pc=f.Pop().Int==0?844:809;continue;}
case 809:{f.Push(f.Locals[27]);f.Pc=811;continue;}
case 811:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",816);}
case 816:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=819;continue;}
case 819:{f.Locals[28]=f.Pop();f.Pc=821;continue;}
case 821:{f.Push(f.Locals[26]);f.Pc=823;continue;}
case 823:{f.Push(f.Locals[1]);f.Pc=824;continue;}
case 824:{f.Push(f.Locals[28]);f.Pc=826;continue;}
case 826:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",829);}
case 829:{f.Push(f.Locals[0]);f.Pc=830;continue;}
case 830:{f.Push(JValue.I(0));f.Pc=831;continue;}
case 831:{f.Push(f.Locals[1]);f.Pc=832;continue;}
case 832:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;","invokestatic",835);}
case 835:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",840);}
case 840:{f.StackOp("pop");f.Pc=841;continue;}
case 841:{f.Pc=799;continue;}
case 844:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",847);}
case 847:{f.Locals[27]=f.Pop();f.Pc=849;continue;}
case 849:{f.Push(f.Locals[12]);f.Pc=851;continue;}
case 851:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",856);}
case 856:{f.Locals[28]=f.Pop();f.Pc=858;continue;}
case 858:{f.Push(f.Locals[28]);f.Pc=860;continue;}
case 860:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",865);}
case 865:{f.Pc=f.Pop().Int==0?903:868;continue;}
case 868:{f.Push(f.Locals[28]);f.Pc=870;continue;}
case 870:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",875);}
case 875:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=878;continue;}
case 878:{f.Locals[29]=f.Pop();f.Pc=880;continue;}
case 880:{f.Push(f.Locals[27]);f.Pc=882;continue;}
case 882:{f.Push(f.Locals[1]);f.Pc=883;continue;}
case 883:{f.Push(f.Locals[29]);f.Pc=885;continue;}
case 885:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",888);}
case 888:{f.Push(f.Locals[0]);f.Pc=889;continue;}
case 889:{f.Push(JValue.I(0));f.Pc=890;continue;}
case 890:{f.Push(f.Locals[1]);f.Pc=891;continue;}
case 891:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",894);}
case 894:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",899);}
case 899:{f.StackOp("pop");f.Pc=900;continue;}
case 900:{f.Pc=858;continue;}
case 903:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",906);}
case 906:{f.Locals[28]=f.Pop();f.Pc=908;continue;}
case 908:{f.Push(f.Locals[13]);f.Pc=910;continue;}
case 910:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",915);}
case 915:{f.Locals[29]=f.Pop();f.Pc=917;continue;}
case 917:{f.Push(f.Locals[29]);f.Pc=919;continue;}
case 919:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",924);}
case 924:{f.Pc=f.Pop().Int==0?965:927;continue;}
case 927:{f.Push(f.Locals[29]);f.Pc=929;continue;}
case 929:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",934);}
case 934:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=937;continue;}
case 937:{f.Locals[30]=f.Pop();f.Pc=939;continue;}
case 939:{f.Push(f.Locals[28]);f.Pc=941;continue;}
case 941:{f.Push(f.Locals[1]);f.Pc=942;continue;}
case 942:{f.Push(f.Locals[30]);f.Pc=944;continue;}
case 944:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",947);}
case 947:{f.Push(f.Locals[0]);f.Pc=948;continue;}
case 948:{f.Push(f.Locals[1]);f.Pc=949;continue;}
case 949:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",952);}
case 952:{f.Push(JValue.I(0));f.Pc=953;continue;}
case 953:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",956);}
case 956:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",961);}
case 961:{f.StackOp("pop");f.Pc=962;continue;}
case 962:{f.Pc=917;continue;}
case 965:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/AnimateEffectBase$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/AnimateEffectBase$1")));f.Pc=968;continue;}
case 968:{f.StackOp("dup");f.Pc=969;continue;}
case 969:{f.Push(f.Locals[0]);f.Pc=970;continue;}
case 970:{f.Push(f.Locals[14]);f.Pc=972;continue;}
case 972:{f.Push(f.Locals[18]);f.Pc=974;continue;}
case 974:{return rt.Call(f,"forge/game/ability/effects/AnimateEffectBase$1","<init>","(Lforge/game/card/Card;JLforge/game/Game;)V","invokespecial",977);}
case 977:{f.Locals[29]=f.Pop();f.Pc=979;continue;}
case 979:{f.Push(f.Locals[1]);f.Pc=980;continue;}
case 980:{f.Push(JValue.R(rt.String("RevertCost")));f.Pc=983;continue;}
case 983:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",986);}
case 986:{f.Pc=f.Pop().Int==0?1039:989;continue;}
case 989:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=992;continue;}
case 992:{f.StackOp("dup");f.Pc=993;continue;}
case 993:{f.Push(f.Locals[1]);f.Pc=994;continue;}
case 994:{f.Push(JValue.R(rt.String("RevertCost")));f.Pc=997;continue;}
case 997:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1000);}
case 1000:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",1003);}
case 1003:{f.Locals[30]=f.Pop();f.Pc=1005;continue;}
case 1005:{f.Push(f.Locals[1]);f.Pc=1006;continue;}
case 1006:{return rt.Call(f,"forge/game/spellability/SpellAbility","getStackDescription","()Ljava/lang/String;","invokevirtual",1009);}
case 1009:{f.Locals[31]=f.Pop();f.Pc=1011;continue;}
case 1011:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/AnimateEffectBase$2"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/AnimateEffectBase$2")));f.Pc=1014;continue;}
case 1014:{f.StackOp("dup");f.Pc=1015;continue;}
case 1015:{f.Push(f.Locals[0]);f.Pc=1016;continue;}
case 1016:{f.Push(f.Locals[30]);f.Pc=1018;continue;}
case 1018:{f.Push(f.Locals[29]);f.Pc=1020;continue;}
case 1020:{f.Push(f.Locals[30]);f.Pc=1022;continue;}
case 1022:{f.Push(f.Locals[31]);f.Pc=1024;continue;}
case 1024:{return rt.Call(f,"forge/game/ability/effects/AnimateEffectBase$2","<init>","(Lforge/game/card/Card;Lforge/card/mana/ManaCost;Lforge/GameCommand;Lforge/card/mana/ManaCost;Ljava/lang/String;)V","invokespecial",1027);}
case 1027:{f.Locals[32]=f.Pop();f.Pc=1029;continue;}
case 1029:{f.Push(f.Locals[25]);f.Pc=1031;continue;}
case 1031:{f.Push(f.Locals[32]);f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1038);}
case 1038:{f.StackOp("pop");f.Pc=1039;continue;}
case 1039:{f.Push(f.Locals[22]);f.Pc=1041;continue;}
case 1041:{f.Pc=f.Pop().Reference!=null?1084:1044;continue;}
case 1044:{f.Push(f.Locals[25]);f.Pc=1046;continue;}
case 1046:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1051);}
case 1051:{f.Pc=f.Pop().Int==0?1084:1054;continue;}
case 1054:{f.Push(f.Locals[26]);f.Pc=1056;continue;}
case 1056:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1061);}
case 1061:{f.Pc=f.Pop().Int==0?1084:1064;continue;}
case 1064:{f.Push(f.Locals[27]);f.Pc=1066;continue;}
case 1066:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1071);}
case 1071:{f.Pc=f.Pop().Int==0?1084:1074;continue;}
case 1074:{f.Push(f.Locals[28]);f.Pc=1076;continue;}
case 1076:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1081);}
case 1081:{f.Pc=f.Pop().Int!=0?1150:1084;continue;}
case 1084:{f.Push(f.Locals[0]);f.Pc=1085;continue;}
case 1085:{f.Push(f.Locals[25]);f.Pc=1087;continue;}
case 1087:{f.Push(f.Locals[26]);f.Pc=1089;continue;}
case 1089:{f.Push(f.Locals[27]);f.Pc=1091;continue;}
case 1091:{f.Push(f.Locals[28]);f.Pc=1093;continue;}
case 1093:{f.Push(f.Locals[22]);f.Pc=1095;continue;}
case 1095:{f.Push(f.Locals[14]);f.Pc=1097;continue;}
case 1097:{f.Push(JValue.L(0));f.Pc=1098;continue;}
case 1098:{return rt.Call(f,"forge/game/card/Card","addChangedCardTraits","(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/function/Predicate;JJ)Lforge/game/card/ICardTraitChanges;","invokevirtual",1101);}
case 1101:{f.Locals[30]=f.Pop();f.Pc=1103;continue;}
case 1103:{f.Push(f.Locals[19]);f.Pc=1105;continue;}
case 1105:{f.Pc=f.Pop().Int==0?1150:1108;continue;}
case 1108:{f.Push(f.Locals[0]);f.Pc=1109;continue;}
case 1109:{if(!rt.EnsureInitialized(f,"forge/game/card/perpetual/PerpetualAbilities"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/perpetual/PerpetualAbilities")));f.Pc=1112;continue;}
case 1112:{f.StackOp("dup");f.Pc=1113;continue;}
case 1113:{f.Push(f.Locals[14]);f.Pc=1115;continue;}
case 1115:{f.Push(f.Locals[30]);f.Pc=1117;continue;}
case 1117:{return rt.Call(f,"forge/game/card/perpetual/PerpetualAbilities","<init>","(JLforge/game/card/ICardTraitChanges;)V","invokespecial",1120);}
case 1120:{return rt.Call(f,"forge/game/card/Card","addPerpetual","(Lforge/game/card/perpetual/PerpetualInterface;)V","invokevirtual",1123);}
case 1123:{f.Push(f.Locals[30]);f.Pc=1125;continue;}
case 1125:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/CardTraitChanges")?1:0));f.Pc=1128;continue;}
case 1128:{f.Pc=f.Pop().Int==0?1150:1131;continue;}
case 1131:{f.Push(f.Locals[30]);f.Pc=1133;continue;}
case 1133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardTraitChanges"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1136;continue;}
case 1136:{f.Locals[31]=f.Pop();f.Pc=1138;continue;}
case 1138:{f.Push(f.Locals[31]);f.Pc=1140;continue;}
case 1140:{return rt.Call(f,"forge/game/card/CardTraitChanges","containsCostChange","()Z","invokevirtual",1143);}
case 1143:{f.Pc=f.Pop().Int==0?1150:1146;continue;}
case 1146:{f.Push(f.Locals[0]);f.Pc=1147;continue;}
case 1147:{return rt.Call(f,"forge/game/card/Card","calculatePerpetualAdjustedManaCost","()V","invokevirtual",1150);}
case 1150:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=1153;continue;}
case 1153:{f.Push(f.Locals[16]);f.Pc=1155;continue;}
case 1155:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1158);}
case 1158:{f.Pc=f.Pop().Int!=0?1192:1161;continue;}
case 1161:{f.Push(f.Locals[19]);f.Pc=1163;continue;}
case 1163:{f.Pc=f.Pop().Int!=0?1192:1166;continue;}
case 1166:{f.Push(JValue.R(rt.String("UntilAnimatedFaceup")));f.Pc=1169;continue;}
case 1169:{f.Push(f.Locals[16]);f.Pc=1171;continue;}
case 1171:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1174);}
case 1174:{f.Pc=f.Pop().Int==0?1186:1177;continue;}
case 1177:{f.Push(f.Locals[0]);f.Pc=1178;continue;}
case 1178:{f.Push(f.Locals[29]);f.Pc=1180;continue;}
case 1180:{return rt.Call(f,"forge/game/card/Card","addFaceupCommand","(Lforge/GameCommand;)V","invokevirtual",1183);}
case 1183:{f.Pc=1192;continue;}
case 1186:{f.Push(f.Locals[1]);f.Pc=1187;continue;}
case 1187:{f.Push(f.Locals[29]);f.Pc=1189;continue;}
case 1189:{return rt.Call(f,"forge/game/ability/effects/AnimateEffectBase","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",1192);}
case 1192:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3027(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.L(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","removeNewPT","(JJ)V","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.L(0));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","removeChangedCardKeywords","(JJ)Z","invokevirtual",12);}
case 12:{f.StackOp("pop");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(JValue.L(0));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","removeChangedCardTypes","(JJ)Z","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.L(0));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/Card","removeColor","(JJ)V","invokevirtual",26);}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.L(0));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/Card","removeChangedCardTraits","(JJ)Z","invokevirtual",32);}
case 32:{f.StackOp("pop");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",38);}
case 38:{return rt.Call(f,"forge/game/card/Card","removeCantHaveKeyword","(Ljava/lang/Long;)Z","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(JValue.L(0));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","removeHiddenExtrinsicKeywords","(JJ)V","invokevirtual",48);}
case 48:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3028(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3029(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

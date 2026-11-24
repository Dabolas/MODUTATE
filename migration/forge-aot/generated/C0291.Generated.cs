// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C291{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DiscardEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3348,"forge/game/ability/effects/DiscardEffect","<init>","()V",1,1,1,new JHandler[]{},M3348));
c.Add(new JMethod(3349,"forge/game/ability/effects/DiscardEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,14,3,new JHandler[]{},M3349));
c.Add(new JMethod(3350,"forge/game/ability/effects/DiscardEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,21,10,new JHandler[]{},M3350));
}

internal static JStep M3348(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3349(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/DiscardEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/PlayerPredicates","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;","invokestatic",9);}
case 9:{return rt.Call(f,"forge/game/player/PlayerCollection","filter","(Ljava/util/function/Predicate;)Lforge/game/player/PlayerCollection;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int!=0?799:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",34);}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("Mode")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("RevealYouChoose")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",51);}
case 51:{f.Locals[6]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("RevealDiscardAll")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",60);}
case 60:{f.Locals[7]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",66);}
case 66:{f.Locals[8]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",74);}
case 74:{f.Push(JValue.I(1));f.Pc=75;continue;}
case 75:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?82:78;continue;}
case 78:{f.Push(JValue.I(1));f.Pc=79;continue;}
case 79:{f.Pc=83;continue;}
case 82:{f.Push(JValue.I(0));f.Pc=83;continue;}
case 83:{f.Locals[9]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",91);}
case 91:{f.Push(JValue.R(rt.String(" ")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",96);}
case 96:{f.StackOp("pop");f.Pc=97;continue;}
case 97:{f.Push(f.Locals[6]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Int==0?134:102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[9]);f.Pc=105;continue;}
case 105:{f.Pc=f.Pop().Int==0?113:108;continue;}
case 108:{f.Push(JValue.R(rt.String("reveals their hand. ")));f.Pc=110;continue;}
case 110:{f.Pc=115;continue;}
case 113:{f.Push(JValue.R(rt.String("reveal their hands. ")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",118);}
case 118:{f.StackOp("pop");f.Pc=119;continue;}
case 119:{f.Push(f.Locals[3]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[8]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",125);}
case 125:{f.Push(JValue.R(rt.String(" chooses ")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",130);}
case 130:{f.StackOp("pop");f.Pc=131;continue;}
case 131:{f.Pc=183;continue;}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{f.Pc=f.Pop().Int==0?166:139;continue;}
case 139:{f.Push(f.Locals[3]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[9]);f.Pc=142;continue;}
case 142:{f.Pc=f.Pop().Int==0?150:145;continue;}
case 145:{f.Push(JValue.R(rt.String("reveals their hand. ")));f.Pc=147;continue;}
case 147:{f.Pc=152;continue;}
case 150:{f.Push(JValue.R(rt.String("reveal their hands. ")));f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",155);}
case 155:{f.StackOp("pop");f.Pc=156;continue;}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{f.Push(JValue.R(rt.String("They discard ")));f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",162);}
case 162:{f.StackOp("pop");f.Pc=163;continue;}
case 163:{f.Pc=183;continue;}
case 166:{f.Push(f.Locals[3]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[9]);f.Pc=169;continue;}
case 169:{f.Pc=f.Pop().Int==0?177:172;continue;}
case 172:{f.Push(JValue.R(rt.String("discards ")));f.Pc=174;continue;}
case 174:{f.Pc=179;continue;}
case 177:{f.Push(JValue.R(rt.String("discard ")));f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",182);}
case 182:{f.StackOp("pop");f.Pc=183;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int==0?209:192;continue;}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",196);}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",202);}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",206);}
case 206:{f.Pc=210;continue;}
case 209:{f.Push(JValue.I(1));f.Pc=210;continue;}
case 210:{f.Locals[10]=f.Pop();f.Pc=212;continue;}
case 212:{f.Push(f.Locals[10]);f.Pc=214;continue;}
case 214:{f.Push(JValue.I(1));f.Pc=215;continue;}
case 215:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?227:218;continue;}
case 218:{f.Push(f.Locals[9]);f.Pc=220;continue;}
case 220:{f.Pc=f.Pop().Int==0?227:223;continue;}
case 223:{f.Push(JValue.I(1));f.Pc=224;continue;}
case 224:{f.Pc=228;continue;}
case 227:{f.Push(JValue.I(0));f.Pc=228;continue;}
case 228:{f.Locals[11]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(JValue.R(rt.String("card")));f.Pc=232;continue;}
case 232:{f.Locals[12]=f.Pop();f.Pc=234;continue;}
case 234:{f.Push(f.Locals[1]);f.Pc=235;continue;}
case 235:{f.Push(JValue.R(rt.String("DiscardValid")));f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",240);}
case 240:{f.Pc=f.Pop().Int==0?385:243;continue;}
case 243:{f.Push(f.Locals[1]);f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.String("DiscardValidDesc")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",249);}
case 249:{f.Pc=f.Pop().Int==0?261:252;continue;}
case 252:{f.Push(f.Locals[1]);f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.String("DiscardValidDesc")));f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",258);}
case 258:{f.Pc=267;continue;}
case 261:{f.Push(f.Locals[1]);f.Pc=262;continue;}
case 262:{f.Push(JValue.R(rt.String("DiscardValid")));f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",267);}
case 267:{f.Locals[13]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[13]);f.Pc=271;continue;}
case 271:{f.Push(JValue.R(rt.String("Card.nonLand")));f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",276);}
case 276:{f.Pc=f.Pop().Int==0?286:279;continue;}
case 279:{f.Push(JValue.R(rt.String("nonland")));f.Pc=281;continue;}
case 281:{f.Locals[13]=f.Pop();f.Pc=283;continue;}
case 283:{f.Pc=359;continue;}
case 286:{f.Push(f.Locals[13]);f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.String("Card.NamedCard")));f.Pc=290;continue;}
case 290:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int==0?303:296;continue;}
case 296:{f.Push(JValue.R(rt.String("named")));f.Pc=298;continue;}
case 298:{f.Locals[13]=f.Pop();f.Pc=300;continue;}
case 300:{f.Pc=359;continue;}
case 303:{f.Push(f.Locals[13]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/card/CardType$CoreType","isValidEnum","(Ljava/lang/String;)Z","invokestatic",308);}
case 308:{f.Pc=f.Pop().Int==0?321:311;continue;}
case 311:{f.Push(f.Locals[13]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",316);}
case 316:{f.Locals[13]=f.Pop();f.Pc=318;continue;}
case 318:{f.Pc=359;continue;}
case 321:{f.Push(f.Locals[1]);f.Pc=322;continue;}
case 322:{f.Push(JValue.R(rt.String("DiscardValidDesc")));f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",327);}
case 327:{f.Pc=f.Pop().Int!=0?359:330;continue;}
case 330:{f.Push(f.Locals[13]);f.Pc=332;continue;}
case 332:{f.Push(JValue.R(rt.String("[A-Za-z]+[.+].*")));f.Pc=334;continue;}
case 334:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",337);}
case 337:{f.Pc=f.Pop().Int==0?359:340;continue;}
case 340:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",343);}
case 343:{f.Push(f.Locals[13]);f.Pc=345;continue;}
case 345:{f.Push(JValue.R(rt.String(",")));f.Pc=347;continue;}
case 347:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",350);}
case 350:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",353);}
case 353:{f.Push(JValue.I(0));f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/util/Lang","buildValidCardDesc","(Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",357);}
case 357:{f.Locals[13]=f.Pop();f.Pc=359;continue;}
case 359:{f.Push(f.Locals[13]);f.Pc=361;continue;}
case 361:{f.Push(JValue.R(rt.String("(?i).*\\bcards?$")));f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",366);}
case 366:{f.Pc=f.Pop().Int==0?374:369;continue;}
case 369:{f.Push(f.Locals[13]);f.Pc=371;continue;}
case 371:{f.Pc=383;continue;}
case 374:{f.Push(f.Locals[13]);f.Pc=376;continue;}
case 376:{f.Push(f.Locals[12]);f.Pc=378;continue;}
case 378:{return rt.DynamicCall(f,"forge/game/ability/effects/DiscardEffect:3349:378:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",383);}
case 383:{f.Locals[12]=f.Pop();f.Pc=385;continue;}
case 385:{f.Push(f.Locals[5]);f.Pc=387;continue;}
case 387:{f.Push(JValue.R(rt.String("Hand")));f.Pc=389;continue;}
case 389:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",392);}
case 392:{f.Pc=f.Pop().Int==0?415:395;continue;}
case 395:{f.Push(f.Locals[3]);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[9]);f.Pc=398;continue;}
case 398:{f.Pc=f.Pop().Int==0?406:401;continue;}
case 401:{f.Push(JValue.R(rt.String("their hand")));f.Pc=403;continue;}
case 403:{f.Pc=408;continue;}
case 406:{f.Push(JValue.R(rt.String("their hands")));f.Pc=408;continue;}
case 408:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",411);}
case 411:{f.StackOp("pop");f.Pc=412;continue;}
case 412:{f.Pc=668;continue;}
case 415:{f.Push(f.Locals[5]);f.Pc=417;continue;}
case 417:{f.Push(JValue.R(rt.String("Defined")));f.Pc=419;continue;}
case 419:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",422);}
case 422:{f.Pc=f.Pop().Int==0?575:425;continue;}
case 425:{f.Push(f.Locals[1]);f.Pc=426;continue;}
case 426:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",429);}
case 429:{f.Pc=f.Pop().Reference!=null?438:432;continue;}
case 432:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",435);}
case 435:{f.Pc=452;continue;}
case 438:{f.Push(f.Locals[1]);f.Pc=439;continue;}
case 439:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",442);}
case 442:{f.Push(f.Locals[1]);f.Pc=443;continue;}
case 443:{f.Push(JValue.R(rt.String("DefinedCards")));f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",448);}
case 448:{f.Push(f.Locals[1]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",452);}
case 452:{f.Locals[13]=f.Pop();f.Pc=454;continue;}
case 454:{f.Push(f.Locals[13]);f.Pc=456;continue;}
case 456:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",461);}
case 461:{f.Push(JValue.I(1));f.Pc=462;continue;}
case 462:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?487:465;continue;}
case 465:{f.Push(f.Locals[3]);f.Pc=466;continue;}
case 466:{f.Push(f.Locals[13]);f.Pc=468;continue;}
case 468:{f.Push(JValue.I(0));f.Pc=469;continue;}
case 469:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",474);}
case 474:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",480);}
case 480:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",483);}
case 483:{f.StackOp("pop");f.Pc=484;continue;}
case 484:{f.Pc=572;continue;}
case 487:{f.Push(f.Locals[13]);f.Pc=489;continue;}
case 489:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",494);}
case 494:{f.Push(JValue.I(1));f.Pc=495;continue;}
case 495:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?550:498;continue;}
case 498:{f.Push(f.Locals[13]);f.Pc=500;continue;}
case 500:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",505);}
case 505:{f.Push(JValue.I(3));f.Pc=506;continue;}
case 506:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?550:509;continue;}
case 509:{f.Push(f.Locals[3]);f.Pc=510;continue;}
case 510:{f.Push(f.Locals[13]);f.Pc=512;continue;}
case 512:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",517);}
case 517:{return rt.DynamicCall(f,"forge/game/ability/effects/DiscardEffect:3349:517:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",522);}
case 522:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",527);}
case 527:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",530);}
case 530:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",535);}
case 535:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=538;continue;}
case 538:{f.Push(JValue.R(rt.String(", ")));f.Pc=540;continue;}
case 540:{return rt.Call(f,"forge/util/TextUtil","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",543);}
case 543:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",546);}
case 546:{f.StackOp("pop");f.Pc=547;continue;}
case 547:{f.Pc=572;continue;}
case 550:{f.Push(f.Locals[3]);f.Pc=551;continue;}
case 551:{f.Push(f.Locals[13]);f.Pc=553;continue;}
case 553:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",558);}
case 558:{f.Pc=f.Pop().Int==0?566:561;continue;}
case 561:{f.Push(JValue.R(rt.String("that card")));f.Pc=563;continue;}
case 563:{f.Pc=568;continue;}
case 566:{f.Push(JValue.R(rt.String("the rest")));f.Pc=568;continue;}
case 568:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",571);}
case 571:{f.StackOp("pop");f.Pc=572;continue;}
case 572:{f.Pc=668;continue;}
case 575:{f.Push(f.Locals[7]);f.Pc=577;continue;}
case 577:{f.Pc=f.Pop().Int==0?590:580;continue;}
case 580:{f.Push(f.Locals[3]);f.Pc=581;continue;}
case 581:{f.Push(JValue.R(rt.String("all")));f.Pc=583;continue;}
case 583:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",586);}
case 586:{f.StackOp("pop");f.Pc=587;continue;}
case 587:{f.Pc=668;continue;}
case 590:{f.Push(f.Locals[1]);f.Pc=591;continue;}
case 591:{f.Push(JValue.R(rt.String("AnyNumber")));f.Pc=593;continue;}
case 593:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",596);}
case 596:{f.Pc=f.Pop().Int==0?609:599;continue;}
case 599:{f.Push(f.Locals[3]);f.Pc=600;continue;}
case 600:{f.Push(JValue.R(rt.String("any number")));f.Pc=602;continue;}
case 602:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",605);}
case 605:{f.StackOp("pop");f.Pc=606;continue;}
case 606:{f.Pc=668;continue;}
case 609:{f.Push(f.Locals[1]);f.Pc=610;continue;}
case 610:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=612;continue;}
case 612:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",615);}
case 615:{f.Pc=f.Pop().Int==0?656:618;continue;}
case 618:{f.Push(f.Locals[1]);f.Pc=619;continue;}
case 619:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=621;continue;}
case 621:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",624);}
case 624:{f.Push(JValue.R(rt.String("X")));f.Pc=626;continue;}
case 626:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",629);}
case 629:{f.Pc=f.Pop().Int==0?656:632;continue;}
case 632:{f.Push(f.Locals[1]);f.Pc=633;continue;}
case 633:{f.Push(JValue.R(rt.String("X")));f.Pc=635;continue;}
case 635:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",638);}
case 638:{f.Push(JValue.R(rt.String("Remembered$Amount")));f.Pc=640;continue;}
case 640:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",643);}
case 643:{f.Pc=f.Pop().Int==0?656:646;continue;}
case 646:{f.Push(f.Locals[3]);f.Pc=647;continue;}
case 647:{f.Push(JValue.R(rt.String("that many")));f.Pc=649;continue;}
case 649:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",652);}
case 652:{f.StackOp("pop");f.Pc=653;continue;}
case 653:{f.Pc=668;continue;}
case 656:{f.Push(f.Locals[3]);f.Pc=657;continue;}
case 657:{f.Push(f.Locals[10]);f.Pc=659;continue;}
case 659:{f.Push(f.Locals[12]);f.Pc=661;continue;}
case 661:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",664);}
case 664:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",667);}
case 667:{f.StackOp("pop");f.Pc=668;continue;}
case 668:{f.Push(f.Locals[6]);f.Pc=670;continue;}
case 670:{f.Pc=f.Pop().Int==0?749:673;continue;}
case 673:{f.Push(f.Locals[3]);f.Pc=674;continue;}
case 674:{f.Push(f.Locals[12]);f.Pc=676;continue;}
case 676:{f.Push(JValue.R(rt.String(" from ")));f.Pc=678;continue;}
case 678:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",681);}
case 681:{f.Pc=f.Pop().Int==0?689:684;continue;}
case 684:{f.Push(JValue.R(rt.String(". ")));f.Pc=686;continue;}
case 686:{f.Pc=701;continue;}
case 689:{f.Push(f.Locals[9]);f.Pc=691;continue;}
case 691:{f.Pc=f.Pop().Int==0?699:694;continue;}
case 694:{f.Push(JValue.R(rt.String(" from it. ")));f.Pc=696;continue;}
case 696:{f.Pc=701;continue;}
case 699:{f.Push(JValue.R(rt.String(" from them. ")));f.Pc=701;continue;}
case 701:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",704);}
case 704:{f.Push(f.Locals[4]);f.Pc=706;continue;}
case 706:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",709);}
case 709:{f.StackOp("pop");f.Pc=710;continue;}
case 710:{f.Push(f.Locals[3]);f.Pc=711;continue;}
case 711:{f.Push(f.Locals[9]);f.Pc=713;continue;}
case 713:{f.Pc=f.Pop().Int==0?721:716;continue;}
case 716:{f.Push(JValue.R(rt.String(" discards ")));f.Pc=718;continue;}
case 718:{f.Pc=724;continue;}
case 721:{f.Push(JValue.R(rt.String(" discard ")));f.Pc=724;continue;}
case 724:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",727);}
case 727:{f.StackOp("pop");f.Pc=728;continue;}
case 728:{f.Push(f.Locals[3]);f.Pc=729;continue;}
case 729:{f.Push(f.Locals[11]);f.Pc=731;continue;}
case 731:{f.Pc=f.Pop().Int==0?739:734;continue;}
case 734:{f.Push(JValue.R(rt.String("that card")));f.Pc=736;continue;}
case 736:{f.Pc=742;continue;}
case 739:{f.Push(JValue.R(rt.String("those cards")));f.Pc=742;continue;}
case 742:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",745);}
case 745:{f.StackOp("pop");f.Pc=746;continue;}
case 746:{f.Pc=769;continue;}
case 749:{f.Push(f.Locals[7]);f.Pc=751;continue;}
case 751:{f.Pc=f.Pop().Int==0?769:754;continue;}
case 754:{f.Push(f.Locals[3]);f.Pc=755;continue;}
case 755:{f.Push(JValue.R(rt.String(" ")));f.Pc=757;continue;}
case 757:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",760);}
case 760:{f.Push(f.Locals[12]);f.Pc=762;continue;}
case 762:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",765);}
case 765:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",768);}
case 768:{f.StackOp("pop");f.Pc=769;continue;}
case 769:{f.Push(f.Locals[5]);f.Pc=771;continue;}
case 771:{f.Push(JValue.R(rt.String("Random")));f.Pc=774;continue;}
case 774:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",777);}
case 777:{f.Pc=f.Pop().Int==0?791:780;continue;}
case 780:{f.Push(f.Locals[3]);f.Pc=781;continue;}
case 781:{f.Push(JValue.R(rt.String(" at random.")));f.Pc=784;continue;}
case 784:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",787);}
case 787:{f.StackOp("pop");f.Pc=788;continue;}
case 788:{f.Pc=799;continue;}
case 791:{f.Push(f.Locals[3]);f.Pc=792;continue;}
case 792:{f.Push(JValue.R(rt.String(".")));f.Pc=795;continue;}
case 795:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",798);}
case 798:{f.StackOp("pop");f.Pc=799;continue;}
case 799:{f.Push(f.Locals[3]);f.Pc=800;continue;}
case 800:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",803);}
case 803:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3350(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Mode")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/ability/effects/DiscardEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",22);}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("RevealTgtChoose")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?43:34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/ability/effects/DiscardEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Pc=47;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{f.Locals[6]=f.Pop();f.Pc=47;continue;}
case 47:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",50);}
case 50:{f.Locals[7]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[6]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",59);}
case 59:{f.Locals[8]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[8]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int==0?1206:71;continue;}
case 71:{f.Push(f.Locals[8]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",78);}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{f.Locals[9]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[9]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int!=0?94:91;continue;}
case 91:{f.Pc=61;continue;}
case 94:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",101);}
case 101:{f.Locals[10]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[9]);f.Pc=105;continue;}
case 105:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",111);}
case 111:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",116);}
case 116:{f.Locals[11]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("Defined")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",124);}
case 124:{f.Pc=f.Pop().Int==0?202:127;continue;}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Push(JValue.I(1));f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/player/Player","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int!=0?140:137;continue;}
case 137:{f.Pc=61;continue;}
case 140:{f.Push(f.Locals[1]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("Optional")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?176:150;continue;}
case 150:{f.Push(f.Locals[9]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",155);}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","Random","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","Random","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("DiscardMessage")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",166);}
case 166:{f.Push(JValue.R(null));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",170);}
case 170:{f.Pc=f.Pop().Int!=0?176:173;continue;}
case 173:{f.Pc=61;continue;}
case 176:{f.Push(f.Locals[2]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("DefinedCards")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",183);}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",187);}
case 187:{f.Locals[10]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[4]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[10]);f.Pc=193;continue;}
case 193:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=196;continue;}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",200);}
case 200:{f.Locals[10]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[3]);f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.String("Hand")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",208);}
case 208:{f.Pc=f.Pop().Int==0?369:211;continue;}
case 211:{f.Push(f.Locals[9]);f.Pc=213;continue;}
case 213:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",219);}
case 219:{f.Locals[10]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(f.Locals[10]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",228);}
case 228:{f.Pc=f.Pop().Int!=0?244:231;continue;}
case 231:{f.Push(f.Locals[9]);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[1]);f.Pc=234;continue;}
case 234:{f.Push(JValue.I(1));f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/player/Player","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int!=0?244:241;continue;}
case 241:{f.Pc=61;continue;}
case 244:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",247);}
case 247:{f.Push(JValue.R(rt.String("lblDoYouWantDiscardYourHand")));f.Pc=250;continue;}
case 250:{f.Push(JValue.I(0));f.Pc=251;continue;}
case 251:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",257);}
case 257:{f.Locals[12]=f.Pop();f.Pc=259;continue;}
case 259:{f.Push(f.Locals[1]);f.Pc=260;continue;}
case 260:{f.Push(JValue.R(rt.String("Optional")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",266);}
case 266:{f.Pc=f.Pop().Int==0?356:269;continue;}
case 269:{f.Push(f.Locals[9]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",274);}
case 274:{f.Push(f.Locals[1]);f.Pc=275;continue;}
case 275:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","Random","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","Random","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=278;continue;}
case 278:{f.Push(f.Locals[12]);f.Pc=280;continue;}
case 280:{f.Push(JValue.R(null));f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",284);}
case 284:{f.Pc=f.Pop().Int!=0?290:287;continue;}
case 287:{f.Pc=61;continue;}
case 290:{f.Push(f.Locals[6]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",297);}
case 297:{f.Push(JValue.I(1));f.Pc=298;continue;}
case 298:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?356:301;continue;}
case 301:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",304);}
case 304:{f.Push(JValue.R(rt.String("lblPlayerKeepNCardsHand")));f.Pc=307;continue;}
case 307:{f.Push(JValue.I(2));f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=311;continue;}
case 311:{f.StackOp("dup");f.Pc=312;continue;}
case 312:{f.Push(JValue.I(0));f.Pc=313;continue;}
case 313:{f.Push(f.Locals[9]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",318);}
case 318:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=319;continue;}
case 319:{f.StackOp("dup");f.Pc=320;continue;}
case 320:{f.Push(JValue.I(1));f.Pc=321;continue;}
case 321:{f.Push(f.Locals[9]);f.Pc=323;continue;}
case 323:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",329);}
case 329:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",332);}
case 332:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",335);}
case 335:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",339);}
case 339:{f.Locals[12]=f.Pop();f.Pc=341;continue;}
case 341:{f.Push(f.Locals[4]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",346);}
case 346:{f.Push(f.Locals[1]);f.Pc=347;continue;}
case 347:{f.Push(f.Locals[9]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[12]);f.Pc=351;continue;}
case 351:{f.Push(f.Locals[9]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",356);}
case 356:{f.Push(f.Locals[4]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[10]);f.Pc=360;continue;}
case 360:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=363;continue;}
case 363:{f.Push(f.Locals[1]);f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",367);}
case 367:{f.Locals[10]=f.Pop();f.Pc=369;continue;}
case 369:{f.Push(JValue.I(1));f.Pc=370;continue;}
case 370:{f.Locals[12]=f.Pop();f.Pc=372;continue;}
case 372:{f.Push(f.Locals[1]);f.Pc=373;continue;}
case 373:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",378);}
case 378:{f.Pc=f.Pop().Int==0?403:381;continue;}
case 381:{f.Push(f.Locals[2]);f.Pc=382;continue;}
case 382:{f.Push(f.Locals[1]);f.Pc=383;continue;}
case 383:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",388);}
case 388:{f.Push(f.Locals[1]);f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",392);}
case 392:{f.Locals[12]=f.Pop();f.Pc=394;continue;}
case 394:{f.Push(f.Locals[12]);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[11]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",401);}
case 401:{f.Locals[12]=f.Pop();f.Pc=403;continue;}
case 403:{f.Push(f.Locals[3]);f.Pc=404;continue;}
case 404:{f.Push(JValue.R(rt.String("Random")));f.Pc=407;continue;}
case 407:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",410);}
case 410:{f.Pc=f.Pop().Int==0?544:413;continue;}
case 413:{f.Push(f.Locals[9]);f.Pc=415;continue;}
case 415:{f.Push(f.Locals[1]);f.Pc=416;continue;}
case 416:{f.Push(JValue.I(1));f.Pc=417;continue;}
case 417:{return rt.Call(f,"forge/game/player/Player","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",420);}
case 420:{f.Pc=f.Pop().Int!=0?426:423;continue;}
case 423:{f.Pc=61;continue;}
case 426:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",429);}
case 429:{f.Push(JValue.R(rt.String("lblWouldYouLikeRandomDiscardTargetCard")));f.Pc=432;continue;}
case 432:{f.Push(JValue.I(1));f.Pc=433;continue;}
case 433:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=436;continue;}
case 436:{f.StackOp("dup");f.Pc=437;continue;}
case 437:{f.Push(JValue.I(0));f.Pc=438;continue;}
case 438:{f.Push(f.Locals[12]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",443);}
case 443:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=444;continue;}
case 444:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",447);}
case 447:{f.Locals[13]=f.Pop();f.Pc=449;continue;}
case 449:{f.Push(f.Locals[1]);f.Pc=450;continue;}
case 450:{f.Push(JValue.R(rt.String("Optional")));f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",456);}
case 456:{f.Pc=f.Pop().Int==0?480:459;continue;}
case 459:{f.Push(f.Locals[9]);f.Pc=461;continue;}
case 461:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",464);}
case 464:{f.Push(f.Locals[1]);f.Pc=465;continue;}
case 465:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","Random","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","Random","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=468;continue;}
case 468:{f.Push(f.Locals[13]);f.Pc=470;continue;}
case 470:{f.Push(JValue.R(null));f.Pc=471;continue;}
case 471:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",474);}
case 474:{f.Pc=f.Pop().Int!=0?480:477;continue;}
case 477:{f.Pc=61;continue;}
case 480:{f.Push(f.Locals[1]);f.Pc=481;continue;}
case 481:{f.Push(JValue.R(rt.String("DiscardValid")));f.Pc=483;continue;}
case 483:{f.Push(JValue.R(rt.String("Card")));f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",489);}
case 489:{f.Locals[14]=f.Pop();f.Pc=491;continue;}
case 491:{f.Push(f.Locals[9]);f.Pc=493;continue;}
case 493:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=496;continue;}
case 496:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",499);}
case 499:{f.Push(f.Locals[14]);f.Pc=501;continue;}
case 501:{f.Push(f.Locals[2]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",505);}
case 505:{f.Push(f.Locals[2]);f.Pc=506;continue;}
case 506:{f.Push(f.Locals[1]);f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",510);}
case 510:{f.Locals[15]=f.Pop();f.Pc=512;continue;}
case 512:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=515;continue;}
case 515:{f.StackOp("dup");f.Pc=516;continue;}
case 516:{f.Push(f.Locals[15]);f.Pc=518;continue;}
case 518:{f.Push(f.Locals[12]);f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",523);}
case 523:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",526);}
case 526:{f.Locals[10]=f.Pop();f.Pc=528;continue;}
case 528:{f.Push(f.Locals[4]);f.Pc=530;continue;}
case 530:{f.Push(f.Locals[10]);f.Pc=532;continue;}
case 532:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=535;continue;}
case 535:{f.Push(f.Locals[1]);f.Pc=536;continue;}
case 536:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",539);}
case 539:{f.Locals[10]=f.Pop();f.Pc=541;continue;}
case 541:{f.Pc=1191;continue;}
case 544:{f.Push(f.Locals[3]);f.Pc=545;continue;}
case 545:{f.Push(JValue.R(rt.String("TgtChoose")));f.Pc=548;continue;}
case 548:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",551);}
case 551:{f.Pc=f.Pop().Int==0?635:554;continue;}
case 554:{f.Push(f.Locals[1]);f.Pc=555;continue;}
case 555:{f.Push(JValue.R(rt.String("UnlessType")));f.Pc=558;continue;}
case 558:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",561);}
case 561:{f.Pc=f.Pop().Int==0?635:564;continue;}
case 564:{f.Push(f.Locals[9]);f.Pc=566;continue;}
case 566:{f.Push(f.Locals[1]);f.Pc=567;continue;}
case 567:{f.Push(JValue.I(1));f.Pc=568;continue;}
case 568:{return rt.Call(f,"forge/game/player/Player","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",571);}
case 571:{f.Pc=f.Pop().Int!=0?577:574;continue;}
case 574:{f.Pc=61;continue;}
case 577:{f.Push(f.Locals[11]);f.Pc=579;continue;}
case 579:{f.Pc=f.Pop().Int<=0?1191:582;continue;}
case 582:{f.Push(f.Locals[9]);f.Pc=584;continue;}
case 584:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=587;continue;}
case 587:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",590);}
case 590:{f.Locals[13]=f.Pop();f.Pc=592;continue;}
case 592:{f.Push(f.Locals[9]);f.Pc=594;continue;}
case 594:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",597);}
case 597:{f.Push(f.Locals[12]);f.Pc=599;continue;}
case 599:{f.Push(f.Locals[13]);f.Pc=601;continue;}
case 601:{f.Push(f.Locals[1]);f.Pc=602;continue;}
case 602:{f.Push(JValue.R(rt.String("UnlessType")));f.Pc=605;continue;}
case 605:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",608);}
case 608:{f.Push(JValue.R(rt.String(",")));f.Pc=610;continue;}
case 610:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",613);}
case 613:{f.Push(f.Locals[1]);f.Pc=614;continue;}
case 614:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsToDiscardUnlessType","(ILforge/game/card/CardCollectionView;[Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",617);}
case 617:{f.Locals[10]=f.Pop();f.Pc=619;continue;}
case 619:{f.Push(f.Locals[4]);f.Pc=621;continue;}
case 621:{f.Push(f.Locals[10]);f.Pc=623;continue;}
case 623:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=626;continue;}
case 626:{f.Push(f.Locals[1]);f.Pc=627;continue;}
case 627:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",630);}
case 630:{f.Locals[10]=f.Pop();f.Pc=632;continue;}
case 632:{f.Pc=1191;continue;}
case 635:{f.Push(f.Locals[3]);f.Pc=636;continue;}
case 636:{f.Push(JValue.R(rt.String("RevealDiscardAll")));f.Pc=638;continue;}
case 638:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",641);}
case 641:{f.Pc=f.Pop().Int==0?756:644;continue;}
case 644:{f.Push(f.Locals[9]);f.Pc=646;continue;}
case 646:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=649;continue;}
case 649:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",652);}
case 652:{f.Locals[13]=f.Pop();f.Pc=654;continue;}
case 654:{f.Push(f.Locals[13]);f.Pc=656;continue;}
case 656:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",661);}
case 661:{f.Pc=f.Pop().Int==0?667:664;continue;}
case 664:{f.Pc=61;continue;}
case 667:{f.Push(f.Locals[4]);f.Pc=669;continue;}
case 669:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",672);}
case 672:{f.Push(f.Locals[13]);f.Pc=674;continue;}
case 674:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=677;continue;}
case 677:{f.Push(f.Locals[9]);f.Pc=679;continue;}
case 679:{f.Push(JValue.I(1));f.Pc=680;continue;}
case 680:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",683);}
case 683:{f.Push(JValue.R(rt.String("lblReveal")));f.Pc=686;continue;}
case 686:{f.Push(JValue.I(0));f.Pc=687;continue;}
case 687:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=690;continue;}
case 690:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",693);}
case 693:{return rt.DynamicCall(f,"forge/game/ability/effects/DiscardEffect:3350:693:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",698);}
case 698:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",701);}
case 701:{f.Push(f.Locals[9]);f.Pc=703;continue;}
case 703:{f.Push(f.Locals[1]);f.Pc=704;continue;}
case 704:{f.Push(JValue.I(1));f.Pc=705;continue;}
case 705:{return rt.Call(f,"forge/game/player/Player","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",708);}
case 708:{f.Pc=f.Pop().Int!=0?714:711;continue;}
case 711:{f.Pc=61;continue;}
case 714:{f.Push(f.Locals[1]);f.Pc=715;continue;}
case 715:{f.Push(JValue.R(rt.String("DiscardValid")));f.Pc=717;continue;}
case 717:{f.Push(JValue.R(rt.String("Card")));f.Pc=720;continue;}
case 720:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",723);}
case 723:{f.Locals[14]=f.Pop();f.Pc=725;continue;}
case 725:{f.Push(f.Locals[13]);f.Pc=727;continue;}
case 727:{f.Push(f.Locals[14]);f.Pc=729;continue;}
case 729:{f.Push(f.Locals[2]);f.Pc=730;continue;}
case 730:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",733);}
case 733:{f.Push(f.Locals[2]);f.Pc=734;continue;}
case 734:{f.Push(f.Locals[1]);f.Pc=735;continue;}
case 735:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",738);}
case 738:{f.Locals[10]=f.Pop();f.Pc=740;continue;}
case 740:{f.Push(f.Locals[4]);f.Pc=742;continue;}
case 742:{f.Push(f.Locals[10]);f.Pc=744;continue;}
case 744:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=747;continue;}
case 747:{f.Push(f.Locals[1]);f.Pc=748;continue;}
case 748:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",751);}
case 751:{f.Locals[10]=f.Pop();f.Pc=753;continue;}
case 753:{f.Pc=1191;continue;}
case 756:{f.Push(f.Locals[3]);f.Pc=757;continue;}
case 757:{f.Push(JValue.R(rt.String("YouChoose")));f.Pc=760;continue;}
case 760:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",763);}
case 763:{f.Pc=f.Pop().Int!=0?776:766;continue;}
case 766:{f.Push(f.Locals[3]);f.Pc=767;continue;}
case 767:{f.Push(JValue.R(rt.String("TgtChoose")));f.Pc=770;continue;}
case 770:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",773);}
case 773:{f.Pc=f.Pop().Int==0?1191:776;continue;}
case 776:{f.Push(f.Locals[9]);f.Pc=778;continue;}
case 778:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=781;continue;}
case 781:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",784);}
case 784:{f.Locals[13]=f.Pop();f.Pc=786;continue;}
case 786:{f.Push(f.Locals[13]);f.Pc=788;continue;}
case 788:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",793);}
case 793:{f.Pc=f.Pop().Int==0?799:796;continue;}
case 796:{f.Pc=61;continue;}
case 799:{f.Push(f.Locals[1]);f.Pc=800;continue;}
case 800:{f.Push(JValue.R(rt.String("RevealNumber")));f.Pc=803;continue;}
case 803:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",806);}
case 806:{f.Pc=f.Pop().Int==0?839:809;continue;}
case 809:{f.Push(f.Locals[2]);f.Pc=810;continue;}
case 810:{f.Push(f.Locals[1]);f.Pc=811;continue;}
case 811:{f.Push(JValue.R(rt.String("RevealNumber")));f.Pc=814;continue;}
case 814:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",817);}
case 817:{f.Push(f.Locals[1]);f.Pc=818;continue;}
case 818:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",821);}
case 821:{f.Locals[14]=f.Pop();f.Pc=823;continue;}
case 823:{f.Push(f.Locals[9]);f.Pc=825;continue;}
case 825:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",828);}
case 828:{f.Push(f.Locals[14]);f.Pc=830;continue;}
case 830:{f.Push(f.Locals[14]);f.Pc=832;continue;}
case 832:{f.Push(f.Locals[13]);f.Pc=834;continue;}
case 834:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsToRevealFromHand","(IILforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;","invokevirtual",837);}
case 837:{f.Locals[13]=f.Pop();f.Pc=839;continue;}
case 839:{f.Push(f.Locals[9]);f.Pc=841;continue;}
case 841:{f.Locals[14]=f.Pop();f.Pc=843;continue;}
case 843:{f.Push(f.Locals[3]);f.Pc=844;continue;}
case 844:{f.Push(JValue.R(rt.String("YouChoose")));f.Pc=847;continue;}
case 847:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",850);}
case 850:{f.Pc=f.Pop().Int==0?862:853;continue;}
case 853:{f.Push(f.Locals[1]);f.Pc=854;continue;}
case 854:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",857);}
case 857:{f.Locals[14]=f.Pop();f.Pc=859;continue;}
case 859:{f.Pc=885;continue;}
case 862:{f.Push(f.Locals[3]);f.Pc=863;continue;}
case 863:{f.Push(JValue.R(rt.String("RevealTgtChoose")));f.Pc=866;continue;}
case 866:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",869);}
case 869:{f.Pc=f.Pop().Int==0?885:872;continue;}
case 872:{f.Push(f.Locals[5]);f.Pc=874;continue;}
case 874:{f.Push(JValue.I(0));f.Pc=875;continue;}
case 875:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",880);}
case 880:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=883;continue;}
case 883:{f.Locals[14]=f.Pop();f.Pc=885;continue;}
case 885:{f.Push(f.Locals[3]);f.Pc=886;continue;}
case 886:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=889;continue;}
case 889:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",892);}
case 892:{f.Pc=f.Pop().Int==0?907:895;continue;}
case 895:{f.Push(f.Locals[4]);f.Pc=897;continue;}
case 897:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",900);}
case 900:{f.Push(f.Locals[13]);f.Pc=902;continue;}
case 902:{f.Push(f.Locals[9]);f.Pc=904;continue;}
case 904:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;)V","invokevirtual",907);}
case 907:{f.Push(f.Locals[3]);f.Pc=908;continue;}
case 908:{f.Push(JValue.R(rt.String("Look")));f.Pc=911;continue;}
case 911:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",914);}
case 914:{f.Pc=f.Pop().Int==0?936:917;continue;}
case 917:{f.Push(f.Locals[9]);f.Pc=919;continue;}
case 919:{f.Push(f.Locals[14]);f.Pc=921;continue;}
case 921:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?936:924;continue;}
case 924:{f.Push(f.Locals[4]);f.Pc=926;continue;}
case 926:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",929);}
case 929:{f.Push(f.Locals[13]);f.Pc=931;continue;}
case 931:{f.Push(f.Locals[14]);f.Pc=933;continue;}
case 933:{return rt.Call(f,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;)V","invokevirtual",936);}
case 936:{f.Push(f.Locals[9]);f.Pc=938;continue;}
case 938:{f.Push(f.Locals[1]);f.Pc=939;continue;}
case 939:{f.Push(JValue.I(1));f.Pc=940;continue;}
case 940:{return rt.Call(f,"forge/game/player/Player","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",943);}
case 943:{f.Pc=f.Pop().Int!=0?949:946;continue;}
case 946:{f.Pc=61;continue;}
case 949:{f.Push(f.Locals[1]);f.Pc=950;continue;}
case 950:{f.Push(JValue.R(rt.String("DiscardValid")));f.Pc=952;continue;}
case 952:{f.Push(JValue.R(rt.String("Card")));f.Pc=955;continue;}
case 955:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",958);}
case 958:{f.Locals[15]=f.Pop();f.Pc=960;continue;}
case 960:{f.Push(f.Locals[13]);f.Pc=962;continue;}
case 962:{f.Push(f.Locals[15]);f.Pc=964;continue;}
case 964:{f.Push(f.Locals[2]);f.Pc=965;continue;}
case 965:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",968);}
case 968:{f.Push(f.Locals[2]);f.Pc=969;continue;}
case 969:{f.Push(f.Locals[1]);f.Pc=970;continue;}
case 970:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",973);}
case 973:{f.Locals[16]=f.Pop();f.Pc=975;continue;}
case 975:{f.Push(f.Locals[1]);f.Pc=976;continue;}
case 976:{f.Push(JValue.R(rt.String("AnyNumber")));f.Pc=978;continue;}
case 978:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",981);}
case 981:{f.Pc=f.Pop().Int!=0?994:984;continue;}
case 984:{f.Push(f.Locals[1]);f.Pc=985;continue;}
case 985:{f.Push(JValue.R(rt.String("Optional")));f.Pc=988;continue;}
case 988:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",991);}
case 991:{f.Pc=f.Pop().Int==0?998:994;continue;}
case 994:{f.Push(JValue.I(0));f.Pc=995;continue;}
case 995:{f.Pc=1008;continue;}
case 998:{f.Push(f.Locals[16]);f.Pc=1000;continue;}
case 1000:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1003);}
case 1003:{f.Push(f.Locals[12]);f.Pc=1005;continue;}
case 1005:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",1008);}
case 1008:{f.Locals[17]=f.Pop();f.Pc=1010;continue;}
case 1010:{f.Push(f.Locals[1]);f.Pc=1011;continue;}
case 1011:{f.Push(JValue.R(rt.String("AnyNumber")));f.Pc=1013;continue;}
case 1013:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1016);}
case 1016:{f.Pc=f.Pop().Int==0?1027:1019;continue;}
case 1019:{f.Push(f.Locals[16]);f.Pc=1021;continue;}
case 1021:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1024);}
case 1024:{f.Pc=1037;continue;}
case 1027:{f.Push(f.Locals[16]);f.Pc=1029;continue;}
case 1029:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1032);}
case 1032:{f.Push(f.Locals[12]);f.Pc=1034;continue;}
case 1034:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",1037);}
case 1037:{f.Locals[18]=f.Pop();f.Pc=1039;continue;}
case 1039:{f.Push(f.Locals[3]);f.Pc=1040;continue;}
case 1040:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=1043;continue;}
case 1043:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1046);}
case 1046:{f.Pc=f.Pop().Int!=0?1059:1049;continue;}
case 1049:{f.Push(f.Locals[3]);f.Pc=1050;continue;}
case 1050:{f.Push(JValue.R(rt.String("Look")));f.Pc=1053;continue;}
case 1053:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1056);}
case 1056:{f.Pc=f.Pop().Int==0?1063:1059;continue;}
case 1059:{f.Push(JValue.I(1));f.Pc=1060;continue;}
case 1060:{f.Pc=1064;continue;}
case 1063:{f.Push(JValue.I(0));f.Pc=1064;continue;}
case 1064:{f.Locals[19]=f.Pop();f.Pc=1066;continue;}
case 1066:{f.Push(f.Locals[19]);f.Pc=1068;continue;}
case 1068:{f.Pc=f.Pop().Int==0?1076:1071;continue;}
case 1071:{f.Push(f.Locals[13]);f.Pc=1073;continue;}
case 1073:{f.Pc=1078;continue;}
case 1076:{f.Push(f.Locals[16]);f.Pc=1078;continue;}
case 1078:{f.Locals[20]=f.Pop();f.Pc=1080;continue;}
case 1080:{f.Push(f.Locals[18]);f.Pc=1082;continue;}
case 1082:{f.Pc=f.Pop().Int!=0?1091:1085;continue;}
case 1085:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=1088;continue;}
case 1088:{f.Pc=1110;continue;}
case 1091:{f.Push(f.Locals[14]);f.Pc=1093;continue;}
case 1093:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1096);}
case 1096:{f.Push(f.Locals[9]);f.Pc=1098;continue;}
case 1098:{f.Push(f.Locals[1]);f.Pc=1099;continue;}
case 1099:{f.Push(f.Locals[16]);f.Pc=1101;continue;}
case 1101:{f.Push(f.Locals[17]);f.Pc=1103;continue;}
case 1103:{f.Push(f.Locals[18]);f.Pc=1105;continue;}
case 1105:{f.Push(f.Locals[20]);f.Pc=1107;continue;}
case 1107:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsToDiscardFrom","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;IILforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;","invokevirtual",1110);}
case 1110:{f.Locals[10]=f.Pop();f.Pc=1112;continue;}
case 1112:{f.Push(f.Locals[10]);f.Pc=1114;continue;}
case 1114:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",1119);}
case 1119:{f.Pc=f.Pop().Int==0?1125:1122;continue;}
case 1122:{f.Pc=61;continue;}
case 1125:{f.Push(f.Locals[4]);f.Pc=1127;continue;}
case 1127:{f.Push(f.Locals[10]);f.Pc=1129;continue;}
case 1129:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1132;continue;}
case 1132:{f.Push(f.Locals[1]);f.Pc=1133;continue;}
case 1133:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",1136);}
case 1136:{f.Locals[10]=f.Pop();f.Pc=1138;continue;}
case 1138:{f.Push(f.Locals[3]);f.Pc=1139;continue;}
case 1139:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=1142;continue;}
case 1142:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1145);}
case 1145:{f.Pc=f.Pop().Int==0?1191:1148;continue;}
case 1148:{f.Push(f.Locals[9]);f.Pc=1150;continue;}
case 1150:{f.Push(f.Locals[14]);f.Pc=1152;continue;}
case 1152:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1191:1155;continue;}
case 1155:{f.Push(f.Locals[9]);f.Pc=1157;continue;}
case 1157:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1160);}
case 1160:{f.Push(f.Locals[10]);f.Pc=1162;continue;}
case 1162:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=1165;continue;}
case 1165:{f.Push(f.Locals[9]);f.Pc=1167;continue;}
case 1167:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1170);}
case 1170:{f.Push(JValue.R(rt.String("lblPlayerHasChosenCardsFrom")));f.Pc=1173;continue;}
case 1173:{f.Push(JValue.I(1));f.Pc=1174;continue;}
case 1174:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1177;continue;}
case 1177:{f.StackOp("dup");f.Pc=1178;continue;}
case 1178:{f.Push(JValue.I(0));f.Pc=1179;continue;}
case 1179:{f.Push(f.Locals[14]);f.Pc=1181;continue;}
case 1181:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",1184);}
case 1184:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1185;continue;}
case 1185:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1188);}
case 1188:{return rt.Call(f,"forge/game/player/PlayerController","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;Ljava/lang/String;)V","invokevirtual",1191);}
case 1191:{f.Push(f.Locals[7]);f.Pc=1193;continue;}
case 1193:{f.Push(f.Locals[9]);f.Pc=1195;continue;}
case 1195:{f.Push(f.Locals[10]);f.Pc=1197;continue;}
case 1197:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1202);}
case 1202:{f.StackOp("pop");f.Pc=1203;continue;}
case 1203:{f.Pc=61;continue;}
case 1206:{f.Push(f.Locals[1]);f.Pc=1207;continue;}
case 1207:{f.Push(JValue.R(rt.String("RememberDiscardingPlayers")));f.Pc=1210;continue;}
case 1210:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1213);}
case 1213:{f.Pc=f.Pop().Int==0?1227:1216;continue;}
case 1216:{f.Push(f.Locals[2]);f.Pc=1217;continue;}
case 1217:{f.Push(f.Locals[7]);f.Pc=1219;continue;}
case 1219:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",1224);}
case 1224:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1227);}
case 1227:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1230);}
case 1230:{f.Locals[8]=f.Pop();f.Pc=1232;continue;}
case 1232:{f.Push(f.Locals[8]);f.Pc=1234;continue;}
case 1234:{f.Push(f.Locals[1]);f.Pc=1235;continue;}
case 1235:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",1238);}
case 1238:{f.Locals[9]=f.Pop();f.Pc=1240;continue;}
case 1240:{f.Push(f.Locals[3]);f.Pc=1241;continue;}
case 1241:{f.Push(JValue.R(rt.String("Random")));f.Pc=1244;continue;}
case 1244:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1247);}
case 1247:{f.Pc=f.Pop().Int==0?1265:1250;continue;}
case 1250:{f.Push(f.Locals[8]);f.Pc=1252;continue;}
case 1252:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"));f.Pc=1255;continue;}
case 1255:{f.Push(JValue.I(1));f.Pc=1256;continue;}
case 1256:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",1259);}
case 1259:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1264);}
case 1264:{f.StackOp("pop");f.Pc=1265;continue;}
case 1265:{f.Push(f.Locals[1]);f.Pc=1266;continue;}
case 1266:{f.Push(f.Locals[1]);f.Pc=1267;continue;}
case 1267:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilityStatic")?1:0));f.Pc=1270;continue;}
case 1270:{f.Pc=f.Pop().Int!=0?1277:1273;continue;}
case 1273:{f.Push(JValue.I(1));f.Pc=1274;continue;}
case 1274:{f.Pc=1278;continue;}
case 1277:{f.Push(JValue.I(0));f.Pc=1278;continue;}
case 1278:{f.Push(f.Locals[7]);f.Pc=1280;continue;}
case 1280:{f.Push(f.Locals[8]);f.Pc=1282;continue;}
case 1282:{return rt.Call(f,"forge/game/ability/effects/DiscardEffect","discard","(Lforge/game/spellability/SpellAbility;ZLjava/util/Map;Ljava/util/Map;)V","invokestatic",1285);}
case 1285:{f.Push(f.Locals[9]);f.Pc=1287;continue;}
case 1287:{f.Push(f.Locals[4]);f.Pc=1289;continue;}
case 1289:{f.Push(f.Locals[1]);f.Pc=1290;continue;}
case 1290:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1293);}
case 1293:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

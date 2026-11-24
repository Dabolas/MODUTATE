// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C242{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChooseTypeEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3168,"forge/game/ability/effects/ChooseTypeEffect","<init>","()V",1,1,1,new JHandler[]{},M3168));
c.Add(new JMethod(3169,"forge/game/ability/effects/ChooseTypeEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,3,new JHandler[]{},M3169));
c.Add(new JMethod(3170,"forge/game/ability/effects/ChooseTypeEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,16,5,new JHandler[]{},M3170));
}

internal static JStep M3168(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3169(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int!=0?54:15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/ability/effects/ChooseTypeEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",20);}
case 20:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",23);}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String(" chooses a ")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",33);}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("Type")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",39);}
case 39:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",42);}
case 42:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",45);}
case 45:{f.Push(JValue.R(rt.String(" type.")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Pc=61;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("Please improve the stack description.")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",65);}
case 65:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3170(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Type")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/ability/effects/ChooseTypeEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",25);}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("Secretly")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",33);}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("ValidTypes")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?69:44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("ValidTypes")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Push(JValue.R(rt.String(",")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",57);}
case 57:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",60);}
case 60:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Pc=930;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Locals[7]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(JValue.I(-1));f.Pc=73;continue;}
case 73:{f.Locals[8]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",80);}
case 80:{switch(f.Pop().Int){case -1819699067:f.Pc=269;break;case -1246819030:f.Pc=204;break;case -475569475:f.Pc=252;break;case 2092848:f.Pc=156;break;case 2360843:f.Pc=220;break;case 219695277:f.Pc=236;break;case 810117853:f.Pc=188;break;case 1885077599:f.Pc=172;break;default:f.Pc=283;break;}continue;}
case 156:{f.Push(f.Locals[7]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("Card")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",163);}
case 163:{f.Pc=f.Pop().Int==0?283:166;continue;}
case 166:{f.Push(JValue.I(0));f.Pc=167;continue;}
case 167:{f.Locals[8]=f.Pop();f.Pc=169;continue;}
case 169:{f.Pc=283;continue;}
case 172:{f.Push(f.Locals[7]);f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("Creature")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",179);}
case 179:{f.Pc=f.Pop().Int==0?283:182;continue;}
case 182:{f.Push(JValue.I(1));f.Pc=183;continue;}
case 183:{f.Locals[8]=f.Pop();f.Pc=185;continue;}
case 185:{f.Pc=283;continue;}
case 188:{f.Push(f.Locals[7]);f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("Basic Land")));f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",195);}
case 195:{f.Pc=f.Pop().Int==0?283:198;continue;}
case 198:{f.Push(JValue.I(2));f.Pc=199;continue;}
case 199:{f.Locals[8]=f.Pop();f.Pc=201;continue;}
case 201:{f.Pc=283;continue;}
case 204:{f.Push(f.Locals[7]);f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String("Nonbasic Land")));f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",211);}
case 211:{f.Pc=f.Pop().Int==0?283:214;continue;}
case 214:{f.Push(JValue.I(3));f.Pc=215;continue;}
case 215:{f.Locals[8]=f.Pop();f.Pc=217;continue;}
case 217:{f.Pc=283;continue;}
case 220:{f.Push(f.Locals[7]);f.Pc=222;continue;}
case 222:{f.Push(JValue.R(rt.String("Land")));f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",227);}
case 227:{f.Pc=f.Pop().Int==0?283:230;continue;}
case 230:{f.Push(JValue.I(4));f.Pc=231;continue;}
case 231:{f.Locals[8]=f.Pop();f.Pc=233;continue;}
case 233:{f.Pc=283;continue;}
case 236:{f.Push(f.Locals[7]);f.Pc=238;continue;}
case 238:{f.Push(JValue.R(rt.String("Planeswalker")));f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",243);}
case 243:{f.Pc=f.Pop().Int==0?283:246;continue;}
case 246:{f.Push(JValue.I(5));f.Pc=247;continue;}
case 247:{f.Locals[8]=f.Pop();f.Pc=249;continue;}
case 249:{f.Pc=283;continue;}
case 252:{f.Push(f.Locals[7]);f.Pc=254;continue;}
case 254:{f.Push(JValue.R(rt.String("CreatureInTargetedDeck")));f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",259);}
case 259:{f.Pc=f.Pop().Int==0?283:262;continue;}
case 262:{f.Push(JValue.I(6));f.Pc=264;continue;}
case 264:{f.Locals[8]=f.Pop();f.Pc=266;continue;}
case 266:{f.Pc=283;continue;}
case 269:{f.Push(f.Locals[7]);f.Pc=271;continue;}
case 271:{f.Push(JValue.R(rt.String("Shared")));f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",276);}
case 276:{f.Pc=f.Pop().Int==0?283:279;continue;}
case 279:{f.Push(JValue.I(7));f.Pc=281;continue;}
case 281:{f.Locals[8]=f.Pop();f.Pc=283;continue;}
case 283:{f.Push(f.Locals[8]);f.Pc=285;continue;}
case 285:{switch(f.Pop().Int){case 0:f.Pc=332;break;case 1:f.Pc=346;break;case 2:f.Pc=555;break;case 3:f.Pc=569;break;case 4:f.Pc=583;break;case 5:f.Pc=597;break;case 6:f.Pc=611;break;case 7:f.Pc=762;break;default:f.Pc=930;break;}continue;}
case 332:{f.Push(f.Locals[4]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/card/CardType","getAllCardTypes","()Ljava/util/Set;","invokestatic",337);}
case 337:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",342);}
case 342:{f.StackOp("pop");f.Pc=343;continue;}
case 343:{f.Pc=930;continue;}
case 346:{f.Push(f.Locals[1]);f.Pc=347;continue;}
case 347:{f.Push(JValue.R(rt.String("TypesFromDefined")));f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",352);}
case 352:{f.Pc=f.Pop().Int==0?417:355;continue;}
case 355:{f.Push(f.Locals[2]);f.Pc=356;continue;}
case 356:{f.Push(f.Locals[1]);f.Pc=357;continue;}
case 357:{f.Push(JValue.R(rt.String("TypesFromDefined")));f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",362);}
case 362:{f.Push(f.Locals[1]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",366);}
case 366:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",369);}
case 369:{f.Locals[9]=f.Pop();f.Pc=371;continue;}
case 371:{f.Push(f.Locals[9]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",378);}
case 378:{f.Pc=f.Pop().Int==0?414:381;continue;}
case 381:{f.Push(f.Locals[9]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",388);}
case 388:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=391;continue;}
case 391:{f.Locals[10]=f.Pop();f.Pc=393;continue;}
case 393:{f.Push(f.Locals[4]);f.Pc=395;continue;}
case 395:{f.Push(f.Locals[10]);f.Pc=397;continue;}
case 397:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",400);}
case 400:{return rt.Call(f,"forge/card/CardTypeView","getCreatureTypes","()Ljava/util/Set;","invokeinterface",405);}
case 405:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",410);}
case 410:{f.StackOp("pop");f.Pc=411;continue;}
case 411:{f.Pc=371;continue;}
case 414:{f.Pc=930;continue;}
case 417:{f.Push(f.Locals[1]);f.Pc=418;continue;}
case 418:{f.Push(JValue.R(rt.String("MostPrevalentInDefinedZone")));f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",423);}
case 423:{f.Pc=f.Pop().Int==0?541:426;continue;}
case 426:{f.Push(f.Locals[1]);f.Pc=427;continue;}
case 427:{f.Push(JValue.R(rt.String("MostPrevalentInDefinedZone")));f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",432);}
case 432:{f.Push(JValue.R(rt.String("_")));f.Pc=434;continue;}
case 434:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",437);}
case 437:{f.Locals[9]=f.Pop();f.Pc=439;continue;}
case 439:{f.Push(f.Locals[1]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",443);}
case 443:{f.Push(f.Locals[9]);f.Pc=445;continue;}
case 445:{f.Push(JValue.I(0));f.Pc=446;continue;}
case 446:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=447;continue;}
case 447:{f.Push(f.Locals[1]);f.Pc=448;continue;}
case 448:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",451);}
case 451:{f.Push(JValue.I(0));f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",455);}
case 455:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=458;continue;}
case 458:{f.Locals[10]=f.Pop();f.Pc=460;continue;}
case 460:{f.Push(f.Locals[9]);f.Pc=462;continue;}
case 462:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=463;continue;}
case 463:{f.Push(JValue.I(1));f.Pc=464;continue;}
case 464:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?477:467;continue;}
case 467:{f.Push(f.Locals[9]);f.Pc=469;continue;}
case 469:{f.Push(JValue.I(1));f.Pc=470;continue;}
case 470:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=471;continue;}
case 471:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",474);}
case 474:{f.Pc=480;continue;}
case 477:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=480;continue;}
case 480:{f.Locals[11]=f.Pop();f.Pc=482;continue;}
case 482:{f.Push(f.Locals[10]);f.Pc=484;continue;}
case 484:{f.Push(f.Locals[11]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",489);}
case 489:{f.Locals[12]=f.Pop();f.Pc=491;continue;}
case 491:{f.Push(f.Locals[12]);f.Pc=493;continue;}
case 493:{return rt.Call(f,"forge/game/card/CardFactoryUtil","getMostProminentCreatureType","(Lforge/game/card/CardCollectionView;)Ljava/lang/Iterable;","invokestatic",496);}
case 496:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",501);}
case 501:{f.Locals[13]=f.Pop();f.Pc=503;continue;}
case 503:{f.Push(f.Locals[13]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",510);}
case 510:{f.Pc=f.Pop().Int==0?538:513;continue;}
case 513:{f.Push(f.Locals[13]);f.Pc=515;continue;}
case 515:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",520);}
case 520:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=523;continue;}
case 523:{f.Locals[14]=f.Pop();f.Pc=525;continue;}
case 525:{f.Push(f.Locals[4]);f.Pc=527;continue;}
case 527:{f.Push(f.Locals[14]);f.Pc=529;continue;}
case 529:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",534);}
case 534:{f.StackOp("pop");f.Pc=535;continue;}
case 535:{f.Pc=503;continue;}
case 538:{f.Pc=930;continue;}
case 541:{f.Push(f.Locals[4]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/card/CardType","getAllCreatureTypes","()Ljava/util/Collection;","invokestatic",546);}
case 546:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",551);}
case 551:{f.StackOp("pop");f.Pc=552;continue;}
case 552:{f.Pc=930;continue;}
case 555:{f.Push(f.Locals[4]);f.Pc=557;continue;}
case 557:{return rt.Call(f,"forge/card/CardType","getBasicTypes","()Ljava/util/Collection;","invokestatic",560);}
case 560:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",565);}
case 565:{f.StackOp("pop");f.Pc=566;continue;}
case 566:{f.Pc=930;continue;}
case 569:{f.Push(f.Locals[4]);f.Pc=571;continue;}
case 571:{return rt.Call(f,"forge/card/CardType","getNonBasicTypes","()Ljava/util/Collection;","invokestatic",574);}
case 574:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",579);}
case 579:{f.StackOp("pop");f.Pc=580;continue;}
case 580:{f.Pc=930;continue;}
case 583:{f.Push(f.Locals[4]);f.Pc=585;continue;}
case 585:{return rt.Call(f,"forge/card/CardType","getAllLandTypes","()Ljava/util/List;","invokestatic",588);}
case 588:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",593);}
case 593:{f.StackOp("pop");f.Pc=594;continue;}
case 594:{f.Pc=930;continue;}
case 597:{f.Push(f.Locals[4]);f.Pc=599;continue;}
case 599:{return rt.Call(f,"forge/card/CardType","getAllWalkerTypes","()Ljava/util/Collection;","invokestatic",602);}
case 602:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",607);}
case 607:{f.StackOp("pop");f.Pc=608;continue;}
case 608:{f.Pc=930;continue;}
case 611:{f.Push(f.Locals[5]);f.Pc=613;continue;}
case 613:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",618);}
case 618:{f.Locals[9]=f.Pop();f.Pc=620;continue;}
case 620:{f.Push(f.Locals[9]);f.Pc=622;continue;}
case 622:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",627);}
case 627:{f.Pc=f.Pop().Int==0?759:630;continue;}
case 630:{f.Push(f.Locals[9]);f.Pc=632;continue;}
case 632:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",637);}
case 637:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=640;continue;}
case 640:{f.Locals[10]=f.Pop();f.Pc=642;continue;}
case 642:{f.Push(f.Locals[10]);f.Pc=644;continue;}
case 644:{return rt.Call(f,"forge/game/player/Player","getAllCards","()Lforge/game/card/CardCollectionView;","invokevirtual",647);}
case 647:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",652);}
case 652:{f.Locals[11]=f.Pop();f.Pc=654;continue;}
case 654:{f.Push(f.Locals[11]);f.Pc=656;continue;}
case 656:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",661);}
case 661:{f.Pc=f.Pop().Int==0?756:664;continue;}
case 664:{f.Push(f.Locals[11]);f.Pc=666;continue;}
case 666:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",671);}
case 671:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=674;continue;}
case 674:{f.Locals[12]=f.Pop();f.Pc=676;continue;}
case 676:{f.Push(f.Locals[12]);f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",681);}
case 681:{return rt.Call(f,"forge/card/CardTypeView","getCreatureTypes","()Ljava/util/Set;","invokeinterface",686);}
case 686:{f.Pc=f.Pop().Reference==null?753:689;continue;}
case 689:{f.Push(f.Locals[12]);f.Pc=691;continue;}
case 691:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",694);}
case 694:{return rt.Call(f,"forge/card/CardTypeView","getCreatureTypes","()Ljava/util/Set;","invokeinterface",699);}
case 699:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",704);}
case 704:{f.Locals[13]=f.Pop();f.Pc=706;continue;}
case 706:{f.Push(f.Locals[13]);f.Pc=708;continue;}
case 708:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",713);}
case 713:{f.Pc=f.Pop().Int==0?753:716;continue;}
case 716:{f.Push(f.Locals[13]);f.Pc=718;continue;}
case 718:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",723);}
case 723:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=726;continue;}
case 726:{f.Locals[14]=f.Pop();f.Pc=728;continue;}
case 728:{f.Push(f.Locals[4]);f.Pc=730;continue;}
case 730:{f.Push(f.Locals[14]);f.Pc=732;continue;}
case 732:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",737);}
case 737:{f.Pc=f.Pop().Int!=0?750:740;continue;}
case 740:{f.Push(f.Locals[4]);f.Pc=742;continue;}
case 742:{f.Push(f.Locals[14]);f.Pc=744;continue;}
case 744:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",749);}
case 749:{f.StackOp("pop");f.Pc=750;continue;}
case 750:{f.Pc=706;continue;}
case 753:{f.Pc=654;continue;}
case 756:{f.Pc=620;continue;}
case 759:{f.Pc=930;continue;}
case 762:{f.Push(f.Locals[1]);f.Pc=763;continue;}
case 763:{f.Push(JValue.R(rt.String("TypesFromDefined")));f.Pc=765;continue;}
case 765:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",768);}
case 768:{f.Pc=f.Pop().Int==0?930:771;continue;}
case 771:{f.Push(f.Locals[2]);f.Pc=772;continue;}
case 772:{f.Push(f.Locals[1]);f.Pc=773;continue;}
case 773:{f.Push(JValue.R(rt.String("TypesFromDefined")));f.Pc=775;continue;}
case 775:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",778);}
case 778:{f.Push(f.Locals[1]);f.Pc=779;continue;}
case 779:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",782);}
case 782:{f.Locals[9]=f.Pop();f.Pc=784;continue;}
case 784:{f.Push(f.Locals[9]);f.Pc=786;continue;}
case 786:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",789);}
case 789:{f.Push(JValue.I(2));f.Pc=790;continue;}
case 790:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?796:793;continue;}
case 793:{f.Pc=930;continue;}
case 796:{f.Push(f.Locals[9]);f.Pc=798;continue;}
case 798:{f.Push(JValue.I(0));f.Pc=799;continue;}
case 799:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",802);}
case 802:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=805;continue;}
case 805:{f.Locals[10]=f.Pop();f.Pc=807;continue;}
case 807:{f.Push(f.Locals[9]);f.Pc=809;continue;}
case 809:{f.Push(JValue.I(0));f.Pc=810;continue;}
case 810:{return rt.Call(f,"forge/game/card/CardCollection","remove","(I)Ljava/lang/Object;","invokevirtual",813);}
case 813:{f.StackOp("pop");f.Pc=814;continue;}
case 814:{f.Push(f.Locals[10]);f.Pc=816;continue;}
case 816:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",819);}
case 819:{return rt.Call(f,"forge/card/CardTypeView","getCoreTypes","()Ljava/util/Collection;","invokeinterface",824);}
case 824:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",829);}
case 829:{f.Locals[11]=f.Pop();f.Pc=831;continue;}
case 831:{f.Push(f.Locals[11]);f.Pc=833;continue;}
case 833:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",838);}
case 838:{f.Pc=f.Pop().Int==0?930:841;continue;}
case 841:{f.Push(f.Locals[11]);f.Pc=843;continue;}
case 843:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",848);}
case 848:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=851;continue;}
case 851:{f.Locals[12]=f.Pop();f.Pc=853;continue;}
case 853:{f.Push(JValue.I(1));f.Pc=854;continue;}
case 854:{f.Locals[13]=f.Pop();f.Pc=856;continue;}
case 856:{f.Push(f.Locals[9]);f.Pc=858;continue;}
case 858:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",861);}
case 861:{f.Locals[14]=f.Pop();f.Pc=863;continue;}
case 863:{f.Push(f.Locals[14]);f.Pc=865;continue;}
case 865:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",870);}
case 870:{f.Pc=f.Pop().Int==0?909:873;continue;}
case 873:{f.Push(f.Locals[14]);f.Pc=875;continue;}
case 875:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",880);}
case 880:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=883;continue;}
case 883:{f.Locals[15]=f.Pop();f.Pc=885;continue;}
case 885:{f.Push(f.Locals[15]);f.Pc=887;continue;}
case 887:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",890);}
case 890:{f.Push(f.Locals[12]);f.Pc=892;continue;}
case 892:{return rt.Call(f,"forge/card/CardTypeView","hasType","(Lforge/card/CardType$CoreType;)Z","invokeinterface",897);}
case 897:{f.Pc=f.Pop().Int!=0?906:900;continue;}
case 900:{f.Push(JValue.I(0));f.Pc=901;continue;}
case 901:{f.Locals[13]=f.Pop();f.Pc=903;continue;}
case 903:{f.Pc=909;continue;}
case 906:{f.Pc=863;continue;}
case 909:{f.Push(f.Locals[13]);f.Pc=911;continue;}
case 911:{f.Pc=f.Pop().Int==0?927:914;continue;}
case 914:{f.Push(f.Locals[4]);f.Pc=916;continue;}
case 916:{f.Push(f.Locals[12]);f.Pc=918;continue;}
case 918:{return rt.Call(f,"forge/card/CardType$CoreType","name","()Ljava/lang/String;","invokevirtual",921);}
case 921:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",926);}
case 926:{f.StackOp("pop");f.Pc=927;continue;}
case 927:{f.Pc=831;continue;}
case 930:{f.Push(f.Locals[1]);f.Pc=931;continue;}
case 931:{f.Push(JValue.R(rt.String("InvalidTypes")));f.Pc=933;continue;}
case 933:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",936);}
case 936:{f.Pc=f.Pop().Int==0?961:939;continue;}
case 939:{f.Push(f.Locals[4]);f.Pc=941;continue;}
case 941:{f.Push(f.Locals[1]);f.Pc=942;continue;}
case 942:{f.Push(JValue.R(rt.String("InvalidTypes")));f.Pc=944;continue;}
case 944:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",947);}
case 947:{f.Push(JValue.R(rt.String(",")));f.Pc=949;continue;}
case 949:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",952);}
case 952:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",955);}
case 955:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",960);}
case 960:{f.StackOp("pop");f.Pc=961;continue;}
case 961:{f.Push(f.Locals[1]);f.Pc=962;continue;}
case 962:{f.Push(JValue.R(rt.String("Note")));f.Pc=964;continue;}
case 964:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",967);}
case 967:{f.Pc=f.Pop().Int==0?1023:970;continue;}
case 970:{f.Push(f.Locals[2]);f.Pc=971;continue;}
case 971:{return rt.Call(f,"forge/game/card/Card","hasAnyNotedType","()Z","invokevirtual",974);}
case 974:{f.Pc=f.Pop().Int==0?1023:977;continue;}
case 977:{f.Push(f.Locals[2]);f.Pc=978;continue;}
case 978:{return rt.Call(f,"forge/game/card/Card","getNotedTypes","()Ljava/lang/Iterable;","invokevirtual",981);}
case 981:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",986);}
case 986:{f.Locals[7]=f.Pop();f.Pc=988;continue;}
case 988:{f.Push(f.Locals[7]);f.Pc=990;continue;}
case 990:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",995);}
case 995:{f.Pc=f.Pop().Int==0?1023:998;continue;}
case 998:{f.Push(f.Locals[7]);f.Pc=1000;continue;}
case 1000:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1005);}
case 1005:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1008;continue;}
case 1008:{f.Locals[8]=f.Pop();f.Pc=1010;continue;}
case 1010:{f.Push(f.Locals[4]);f.Pc=1012;continue;}
case 1012:{f.Push(f.Locals[8]);f.Pc=1014;continue;}
case 1014:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",1019);}
case 1019:{f.StackOp("pop");f.Pc=1020;continue;}
case 1020:{f.Pc=988;continue;}
case 1023:{f.Push(f.Locals[4]);f.Pc=1025;continue;}
case 1025:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1030);}
case 1030:{f.Pc=f.Pop().Int==0?1045:1033;continue;}
case 1033:{f.Push(f.Locals[1]);f.Pc=1034;continue;}
case 1034:{f.Push(JValue.R(rt.String("TypesFromDefined")));f.Pc=1036;continue;}
case 1036:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1039);}
case 1039:{f.Pc=f.Pop().Int==0?1045:1042;continue;}
case 1042:{f.Pc=1246;continue;}
case 1045:{f.Push(f.Locals[4]);f.Pc=1047;continue;}
case 1047:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1052);}
case 1052:{f.Pc=f.Pop().Int!=0?1226:1055;continue;}
case 1055:{f.Push(f.Locals[5]);f.Pc=1057;continue;}
case 1057:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1062);}
case 1062:{f.Locals[7]=f.Pop();f.Pc=1064;continue;}
case 1064:{f.Push(f.Locals[7]);f.Pc=1066;continue;}
case 1066:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1071);}
case 1071:{f.Pc=f.Pop().Int==0?1223:1074;continue;}
case 1074:{f.Push(f.Locals[7]);f.Pc=1076;continue;}
case 1076:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1081);}
case 1081:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1084;continue;}
case 1084:{f.Locals[8]=f.Pop();f.Pc=1086;continue;}
case 1086:{f.Push(f.Locals[8]);f.Pc=1088;continue;}
case 1088:{f.Locals[10]=f.Pop();f.Pc=1090;continue;}
case 1090:{f.Push(f.Locals[1]);f.Pc=1091;continue;}
case 1091:{f.Push(JValue.R(rt.String("AtRandom")));f.Pc=1094;continue;}
case 1094:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1097);}
case 1097:{f.Pc=f.Pop().Int==0?1116:1100;continue;}
case 1100:{f.Push(f.Locals[4]);f.Pc=1102;continue;}
case 1102:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",1105);}
case 1105:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1108;continue;}
case 1108:{f.Locals[9]=f.Pop();f.Pc=1110;continue;}
case 1110:{f.Push(JValue.R(null));f.Pc=1111;continue;}
case 1111:{f.Locals[10]=f.Pop();f.Pc=1113;continue;}
case 1113:{f.Pc=1130;continue;}
case 1116:{f.Push(f.Locals[8]);f.Pc=1118;continue;}
case 1118:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1121);}
case 1121:{f.Push(f.Locals[3]);f.Pc=1122;continue;}
case 1122:{f.Push(f.Locals[1]);f.Pc=1123;continue;}
case 1123:{f.Push(f.Locals[4]);f.Pc=1125;continue;}
case 1125:{return rt.Call(f,"forge/game/player/PlayerController","chooseSomeType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/Collection;)Ljava/lang/String;","invokevirtual",1128);}
case 1128:{f.Locals[9]=f.Pop();f.Pc=1130;continue;}
case 1130:{f.Push(f.Locals[6]);f.Pc=1132;continue;}
case 1132:{f.Pc=f.Pop().Int!=0?1153:1135;continue;}
case 1135:{f.Push(f.Locals[8]);f.Pc=1137;continue;}
case 1137:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1140);}
case 1140:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1143);}
case 1143:{f.Push(f.Locals[1]);f.Pc=1144;continue;}
case 1144:{f.Push(f.Locals[8]);f.Pc=1146;continue;}
case 1146:{f.Push(f.Locals[9]);f.Pc=1148;continue;}
case 1148:{f.Push(f.Locals[10]);f.Pc=1150;continue;}
case 1150:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",1153);}
case 1153:{f.Push(f.Locals[1]);f.Pc=1154;continue;}
case 1154:{f.Push(JValue.R(rt.String("Note")));f.Pc=1156;continue;}
case 1156:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1159);}
case 1159:{f.Pc=f.Pop().Int==0?1181:1162;continue;}
case 1162:{f.Push(f.Locals[2]);f.Pc=1163;continue;}
case 1163:{f.Push(f.Locals[9]);f.Pc=1165;continue;}
case 1165:{return rt.Call(f,"forge/game/card/Card","addNotedType","(Ljava/lang/String;)V","invokevirtual",1168);}
case 1168:{f.Push(f.Locals[1]);f.Pc=1169;continue;}
case 1169:{f.Push(JValue.R(rt.String("ChooseNoted")));f.Pc=1172;continue;}
case 1172:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1175);}
case 1175:{f.Pc=f.Pop().Int!=0?1181:1178;continue;}
case 1178:{f.Pc=1064;continue;}
case 1181:{f.Push(f.Locals[1]);f.Pc=1182;continue;}
case 1182:{f.Push(JValue.R(rt.String("ChooseType2")));f.Pc=1185;continue;}
case 1185:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1188);}
case 1188:{f.Pc=f.Pop().Int==0?1200:1191;continue;}
case 1191:{f.Push(f.Locals[2]);f.Pc=1192;continue;}
case 1192:{f.Push(f.Locals[9]);f.Pc=1194;continue;}
case 1194:{return rt.Call(f,"forge/game/card/Card","setChosenType2","(Ljava/lang/String;)V","invokevirtual",1197);}
case 1197:{f.Pc=1220;continue;}
case 1200:{f.Push(f.Locals[6]);f.Pc=1202;continue;}
case 1202:{f.Pc=f.Pop().Int==0?1214:1205;continue;}
case 1205:{f.Push(f.Locals[2]);f.Pc=1206;continue;}
case 1206:{f.Push(f.Locals[9]);f.Pc=1208;continue;}
case 1208:{return rt.Call(f,"forge/game/card/Card","setSecretChosenType","(Ljava/lang/String;)V","invokevirtual",1211);}
case 1211:{f.Pc=1220;continue;}
case 1214:{f.Push(f.Locals[2]);f.Pc=1215;continue;}
case 1215:{f.Push(f.Locals[9]);f.Pc=1217;continue;}
case 1217:{return rt.Call(f,"forge/game/card/Card","setChosenType","(Ljava/lang/String;)V","invokevirtual",1220);}
case 1220:{f.Pc=1064;continue;}
case 1223:{f.Pc=1246;continue;}
case 1226:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=1229;continue;}
case 1229:{f.StackOp("dup");f.Pc=1230;continue;}
case 1230:{f.Push(f.Locals[1]);f.Pc=1231;continue;}
case 1231:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1234);}
case 1234:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1237);}
case 1237:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseTypeEffect:3170:1237:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1242);}
case 1242:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",1245);}
case 1245:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 1246:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C329{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/MakeCardEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3480,"forge/game/ability/effects/MakeCardEffect","<init>","()V",1,1,1,new JHandler[]{},M3480));
c.Add(new JMethod(3481,"forge/game/ability/effects/MakeCardEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,29,6,new JHandler[]{},M3481));
c.Add(new JMethod(3482,"forge/game/ability/effects/MakeCardEffect","parseFaces","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;",2,9,3,new JHandler[]{},M3482));
c.Add(new JMethod(3483,"forge/game/ability/effects/MakeCardEffect","finishMaking","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;",2,4,2,new JHandler[]{},M3483));
c.Add(new JMethod(3484,"forge/game/ability/effects/MakeCardEffect","lambda$resolve$0","(Ljava/lang/String;Lforge/item/PaperCard;)Z",4106,2,2,new JHandler[]{},M3484));
}

internal static JStep M3480(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3481(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateBattlefield","()Lforge/game/card/CardCollection;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",17);}
case 17:{f.StackOp("pop");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateGraveyard","()Lforge/game/card/CardCollection;","invokevirtual",26);}
case 26:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("Defined")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",48);}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",55);}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",64);}
case 64:{f.Pc=f.Pop().Int==0?1880:67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Locals[6]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",84);}
case 84:{f.Locals[7]=f.Pop();f.Pc=86;continue;}
case 86:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=89;continue;}
case 89:{f.StackOp("dup");f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",93);}
case 93:{f.Locals[8]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(JValue.R(null));f.Pc=96;continue;}
case 96:{f.Locals[9]=f.Pop();f.Pc=98;continue;}
case 98:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",101);}
case 101:{f.Locals[10]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("OptionPrompt")));f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",111);}
case 111:{f.Locals[11]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("Optional")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Int==0?158:122;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String("OptionPrompt")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?158:131;continue;}
case 131:{f.Push(f.Locals[6]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",136);}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(null));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",141);}
case 141:{f.Push(f.Locals[11]);f.Pc=143;continue;}
case 143:{f.Push(JValue.I(0));f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",150);}
case 150:{f.Push(JValue.R(null));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int!=0?158:157;continue;}
case 157:{return JStep.ReturnVoid;}
case 158:{f.Push(f.Locals[1]);f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("Name")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int==0?238:167;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{f.Push(JValue.R(rt.String("Name")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",173);}
case 173:{f.Locals[12]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[12]);f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String("ChosenName")));f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int==0?225:185;continue;}
case 185:{f.Push(f.Locals[3]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/card/Card","hasNamedCard","()Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int==0?207:192;continue;}
case 192:{f.Push(f.Locals[10]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[3]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/card/Card","getNamedCards","()Ljava/util/List;","invokevirtual",198);}
case 198:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",203);}
case 203:{f.StackOp("pop");f.Pc=204;continue;}
case 204:{f.Pc=235;continue;}
case 207:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=210;continue;}
case 210:{f.Push(f.Locals[3]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",214);}
case 214:{return rt.DynamicCall(f,"forge/game/ability/effects/MakeCardEffect:3481:214:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",219);}
case 219:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",222);}
case 222:{f.Pc=235;continue;}
case 225:{f.Push(f.Locals[10]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[12]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",234);}
case 234:{f.StackOp("pop");f.Pc=235;continue;}
case 235:{f.Pc=620;continue;}
case 238:{f.Push(f.Locals[1]);f.Pc=239;continue;}
case 239:{f.Push(JValue.R(rt.String("Names")));f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",244);}
case 244:{f.Pc=f.Pop().Int==0?321:247;continue;}
case 247:{f.Push(f.Locals[1]);f.Pc=248;continue;}
case 248:{f.Push(JValue.R(rt.String("Names")));f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",253);}
case 253:{f.Push(JValue.R(rt.String(",")));f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",258);}
case 258:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",261);}
case 261:{f.Locals[12]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(f.Locals[12]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",270);}
case 270:{f.Locals[13]=f.Pop();f.Pc=272;continue;}
case 272:{f.Push(f.Locals[13]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",279);}
case 279:{f.Pc=f.Pop().Int==0?318:282;continue;}
case 282:{f.Push(f.Locals[13]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",289);}
case 289:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=292;continue;}
case 292:{f.Locals[14]=f.Pop();f.Pc=294;continue;}
case 294:{f.Push(f.Locals[14]);f.Pc=296;continue;}
case 296:{f.Push(JValue.R(rt.String(";")));f.Pc=298;continue;}
case 298:{f.Push(JValue.R(rt.String(",")));f.Pc=300;continue;}
case 300:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",303);}
case 303:{f.Locals[14]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[10]);f.Pc=307;continue;}
case 307:{f.Push(f.Locals[14]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",314);}
case 314:{f.StackOp("pop");f.Pc=315;continue;}
case 315:{f.Pc=272;continue;}
case 318:{f.Pc=620;continue;}
case 321:{f.Push(f.Locals[1]);f.Pc=322;continue;}
case 322:{f.Push(JValue.R(rt.String("DefinedName")));f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",327);}
case 327:{f.Pc=f.Pop().Int==0?438:330;continue;}
case 330:{f.Push(f.Locals[1]);f.Pc=331;continue;}
case 331:{f.Push(JValue.R(rt.String("DefinedName")));f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",336);}
case 336:{f.Locals[12]=f.Pop();f.Pc=338;continue;}
case 338:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=341;continue;}
case 341:{f.StackOp("dup");f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",345);}
case 345:{f.Locals[13]=f.Pop();f.Pc=347;continue;}
case 347:{f.Push(f.Locals[12]);f.Pc=349;continue;}
case 349:{f.Push(JValue.R(rt.String("ChosenMap")));f.Pc=351;continue;}
case 351:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",354);}
case 354:{f.Pc=f.Pop().Int==0?376:357;continue;}
case 357:{f.Push(f.Locals[3]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/card/Card","getChosenMap","()Ljava/util/Map;","invokevirtual",361);}
case 361:{f.Push(f.Locals[6]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",368);}
case 368:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=371;continue;}
case 371:{f.Locals[13]=f.Pop();f.Pc=373;continue;}
case 373:{f.Pc=385;continue;}
case 376:{f.Push(f.Locals[3]);f.Pc=377;continue;}
case 377:{f.Push(f.Locals[12]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[1]);f.Pc=380;continue;}
case 380:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",383);}
case 383:{f.Locals[13]=f.Pop();f.Pc=385;continue;}
case 385:{f.Push(f.Locals[13]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",390);}
case 390:{f.Locals[14]=f.Pop();f.Pc=392;continue;}
case 392:{f.Push(f.Locals[14]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",399);}
case 399:{f.Pc=f.Pop().Int==0?435:402;continue;}
case 402:{f.Push(f.Locals[14]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",409);}
case 409:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=412;continue;}
case 412:{f.Locals[15]=f.Pop();f.Pc=414;continue;}
case 414:{f.Push(f.Locals[10]);f.Pc=416;continue;}
case 416:{f.Push(f.Locals[15]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",421);}
case 421:{return rt.Call(f,"forge/item/IPaperCard","getName","()Ljava/lang/String;","invokeinterface",426);}
case 426:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",431);}
case 431:{f.StackOp("pop");f.Pc=432;continue;}
case 432:{f.Pc=392;continue;}
case 435:{f.Pc=620;continue;}
case 438:{f.Push(f.Locals[1]);f.Pc=439;continue;}
case 439:{f.Push(JValue.R(rt.String("Spellbook")));f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",444);}
case 444:{f.Pc=f.Pop().Int==0?465:447;continue;}
case 447:{f.Push(f.Locals[8]);f.Pc=449;continue;}
case 449:{f.Push(f.Locals[0]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[1]);f.Pc=451;continue;}
case 451:{f.Push(JValue.R(rt.String("Spellbook")));f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/ability/effects/MakeCardEffect","parseFaces","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;","invokevirtual",456);}
case 456:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",461);}
case 461:{f.StackOp("pop");f.Pc=462;continue;}
case 462:{f.Pc=620;continue;}
case 465:{f.Push(f.Locals[1]);f.Pc=466;continue;}
case 466:{f.Push(JValue.R(rt.String("Choices")));f.Pc=468;continue;}
case 468:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",471);}
case 471:{f.Pc=f.Pop().Int==0?492:474;continue;}
case 474:{f.Push(f.Locals[8]);f.Pc=476;continue;}
case 476:{f.Push(f.Locals[0]);f.Pc=477;continue;}
case 477:{f.Push(f.Locals[1]);f.Pc=478;continue;}
case 478:{f.Push(JValue.R(rt.String("Choices")));f.Pc=480;continue;}
case 480:{return rt.Call(f,"forge/game/ability/effects/MakeCardEffect","parseFaces","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;","invokevirtual",483);}
case 483:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",488);}
case 488:{f.StackOp("pop");f.Pc=489;continue;}
case 489:{f.Pc=620;continue;}
case 492:{f.Push(f.Locals[1]);f.Pc=493;continue;}
case 493:{f.Push(JValue.R(rt.String("Booster")));f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",498);}
case 498:{f.Pc=f.Pop().Int==0?620:501;continue;}
case 501:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",504);}
case 504:{return rt.Call(f,"forge/StaticData","ensureAllCardsLoaded","()V","invokevirtual",507);}
case 507:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",510);}
case 510:{return rt.Call(f,"forge/StaticData","getBoosters","()Lforge/util/storage/IStorage;","invokevirtual",513);}
case 513:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",516);}
case 516:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/SealedTemplate"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=519;continue;}
case 519:{f.Locals[12]=f.Pop();f.Pc=521;continue;}
case 521:{if(!rt.EnsureInitialized(f,"forge/item/BoosterPack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/BoosterPack")));f.Pc=524;continue;}
case 524:{f.StackOp("dup");f.Pc=525;continue;}
case 525:{f.Push(f.Locals[12]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/item/SealedTemplate","getEdition","()Ljava/lang/String;","invokevirtual",530);}
case 530:{f.Push(f.Locals[12]);f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/item/BoosterPack","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;)V","invokespecial",535);}
case 535:{return rt.Call(f,"forge/item/BoosterPack","getCards","()Ljava/util/List;","invokevirtual",538);}
case 538:{f.Locals[9]=f.Pop();f.Pc=540;continue;}
case 540:{f.Push(f.Locals[9]);f.Pc=542;continue;}
case 542:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",547);}
case 547:{f.Locals[13]=f.Pop();f.Pc=549;continue;}
case 549:{f.Push(f.Locals[13]);f.Pc=551;continue;}
case 551:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",556);}
case 556:{f.Pc=f.Pop().Int==0?620:559;continue;}
case 559:{f.Push(f.Locals[13]);f.Pc=561;continue;}
case 561:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",566);}
case 566:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=569;continue;}
case 569:{f.Locals[14]=f.Pop();f.Pc=571;continue;}
case 571:{f.Push(f.Locals[14]);f.Pc=573;continue;}
case 573:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",576);}
case 576:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",579);}
case 579:{f.Locals[15]=f.Pop();f.Pc=581;continue;}
case 581:{f.Push(f.Locals[15]);f.Pc=583;continue;}
case 583:{f.Pc=f.Pop().Reference==null?599:586;continue;}
case 586:{f.Push(f.Locals[8]);f.Pc=588;continue;}
case 588:{f.Push(f.Locals[15]);f.Pc=590;continue;}
case 590:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",595);}
case 595:{f.StackOp("pop");f.Pc=596;continue;}
case 596:{f.Pc=617;continue;}
case 599:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=602;continue;}
case 602:{f.StackOp("dup");f.Pc=603;continue;}
case 603:{f.Push(f.Locals[14]);f.Pc=605;continue;}
case 605:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",608);}
case 608:{return rt.DynamicCall(f,"forge/game/ability/effects/MakeCardEffect:3481:608:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",613);}
case 613:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",616);}
case 616:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 617:{f.Pc=549;continue;}
case 620:{f.Push(f.Locals[8]);f.Pc=622;continue;}
case 622:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",627);}
case 627:{f.Pc=f.Pop().Int!=0?934:630;continue;}
case 630:{f.Push(f.Locals[1]);f.Pc=631;continue;}
case 631:{f.Push(JValue.R(rt.String("Filter")));f.Pc=634;continue;}
case 634:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",637);}
case 637:{f.Pc=f.Pop().Int==0?752:640;continue;}
case 640:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=643;continue;}
case 643:{f.StackOp("dup");f.Pc=644;continue;}
case 644:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",647);}
case 647:{f.Locals[12]=f.Pop();f.Pc=649;continue;}
case 649:{f.Push(f.Locals[8]);f.Pc=651;continue;}
case 651:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",656);}
case 656:{f.Locals[13]=f.Pop();f.Pc=658;continue;}
case 658:{f.Push(f.Locals[13]);f.Pc=660;continue;}
case 660:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",665);}
case 665:{f.Pc=f.Pop().Int==0?735:668;continue;}
case 668:{f.Push(f.Locals[13]);f.Pc=670;continue;}
case 670:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",675);}
case 675:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=678;continue;}
case 678:{f.Locals[14]=f.Pop();f.Pc=680;continue;}
case 680:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",683);}
case 683:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",686);}
case 686:{f.Push(f.Locals[14]);f.Pc=688;continue;}
case 688:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",693);}
case 693:{return rt.Call(f,"forge/card/CardDb","getUniqueByName","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",696);}
case 696:{f.Locals[15]=f.Pop();f.Pc=698;continue;}
case 698:{f.Push(f.Locals[15]);f.Pc=700;continue;}
case 700:{f.Push(f.Locals[6]);f.Pc=702;continue;}
case 702:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",705);}
case 705:{f.Push(f.Locals[1]);f.Pc=706;continue;}
case 706:{f.Push(JValue.R(rt.String("Filter")));f.Pc=709;continue;}
case 709:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",712);}
case 712:{f.Push(f.Locals[6]);f.Pc=714;continue;}
case 714:{f.Push(f.Locals[3]);f.Pc=715;continue;}
case 715:{f.Push(f.Locals[1]);f.Pc=716;continue;}
case 716:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",719);}
case 719:{f.Pc=f.Pop().Int==0?732:722;continue;}
case 722:{f.Push(f.Locals[12]);f.Pc=724;continue;}
case 724:{f.Push(f.Locals[14]);f.Pc=726;continue;}
case 726:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",731);}
case 731:{f.StackOp("pop");f.Pc=732;continue;}
case 732:{f.Pc=658;continue;}
case 735:{f.Push(f.Locals[12]);f.Pc=737;continue;}
case 737:{f.Locals[8]=f.Pop();f.Pc=739;continue;}
case 739:{f.Push(f.Locals[8]);f.Pc=741;continue;}
case 741:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",746);}
case 746:{f.Pc=f.Pop().Int==0?752:749;continue;}
case 749:{f.Pc=57;continue;}
case 752:{f.Push(f.Locals[1]);f.Pc=753;continue;}
case 753:{f.Push(JValue.R(rt.String("SpellbookAmount")));f.Pc=756;continue;}
case 756:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",759);}
case 759:{f.Pc=f.Pop().Int==0?777:762;continue;}
case 762:{f.Push(f.Locals[3]);f.Pc=763;continue;}
case 763:{f.Push(f.Locals[1]);f.Pc=764;continue;}
case 764:{f.Push(JValue.R(rt.String("SpellbookAmount")));f.Pc=767;continue;}
case 767:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",770);}
case 770:{f.Push(f.Locals[1]);f.Pc=771;continue;}
case 771:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",774);}
case 774:{f.Pc=778;continue;}
case 777:{f.Push(JValue.I(1));f.Pc=778;continue;}
case 778:{f.Locals[12]=f.Pop();f.Pc=780;continue;}
case 780:{f.Push(f.Locals[12]);f.Pc=782;continue;}
case 782:{f.Pc=f.Pop().Int<=0?934:785;continue;}
case 785:{f.Push(f.Locals[1]);f.Pc=786;continue;}
case 786:{f.Push(JValue.R(rt.String("AtRandom")));f.Pc=789;continue;}
case 789:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",792);}
case 792:{f.Pc=f.Pop().Int==0?813:795;continue;}
case 795:{f.Push(f.Locals[8]);f.Pc=797;continue;}
case 797:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",800);}
case 800:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=803;continue;}
case 803:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",808);}
case 808:{f.Locals[13]=f.Pop();f.Pc=810;continue;}
case 810:{f.Pc=899;continue;}
case 813:{f.Push(f.Locals[1]);f.Pc=814;continue;}
case 814:{f.Push(JValue.R(rt.String("SpellbookName")));f.Pc=817;continue;}
case 817:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",820);}
case 820:{f.Pc=f.Pop().Int==0?833:823;continue;}
case 823:{f.Push(f.Locals[1]);f.Pc=824;continue;}
case 824:{f.Push(JValue.R(rt.String("SpellbookName")));f.Pc=827;continue;}
case 827:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",830);}
case 830:{f.Pc=837;continue;}
case 833:{f.Push(f.Locals[3]);f.Pc=834;continue;}
case 834:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",837);}
case 837:{f.Locals[14]=f.Pop();f.Pc=839;continue;}
case 839:{f.Push(f.Locals[1]);f.Pc=840;continue;}
case 840:{f.Push(JValue.R(rt.String("Choices")));f.Pc=842;continue;}
case 842:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",845);}
case 845:{f.Pc=f.Pop().Int==0?864:848;continue;}
case 848:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",851);}
case 851:{f.Push(JValue.R(rt.String("lblChooseaCard")));f.Pc=854;continue;}
case 854:{f.Push(JValue.I(0));f.Pc=855;continue;}
case 855:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=858;continue;}
case 858:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",861);}
case 861:{f.Pc=882;continue;}
case 864:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",867);}
case 867:{f.Push(JValue.R(rt.String("lblChooseFromSpellbook")));f.Pc=870;continue;}
case 870:{f.Push(JValue.I(1));f.Pc=871;continue;}
case 871:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=874;continue;}
case 874:{f.StackOp("dup");f.Pc=875;continue;}
case 875:{f.Push(JValue.I(0));f.Pc=876;continue;}
case 876:{f.Push(f.Locals[14]);f.Pc=878;continue;}
case 878:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=879;continue;}
case 879:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",882);}
case 882:{f.Locals[15]=f.Pop();f.Pc=884;continue;}
case 884:{f.Push(f.Locals[6]);f.Pc=886;continue;}
case 886:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",889);}
case 889:{f.Push(f.Locals[1]);f.Pc=890;continue;}
case 890:{f.Push(f.Locals[8]);f.Pc=892;continue;}
case 892:{f.Push(f.Locals[15]);f.Pc=894;continue;}
case 894:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardName","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",897);}
case 897:{f.Locals[13]=f.Pop();f.Pc=899;continue;}
case 899:{f.Push(f.Locals[10]);f.Pc=901;continue;}
case 901:{f.Push(f.Locals[13]);f.Pc=903;continue;}
case 903:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",908);}
case 908:{f.StackOp("pop");f.Pc=909;continue;}
case 909:{f.Push(f.Locals[8]);f.Pc=911;continue;}
case 911:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",914);}
case 914:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",917);}
case 917:{f.Push(f.Locals[13]);f.Pc=919;continue;}
case 919:{return rt.Call(f,"forge/card/CardDb","getFaceByName","(Ljava/lang/String;)Lforge/card/ICardFace;","invokevirtual",922);}
case 922:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",927);}
case 927:{f.StackOp("pop");f.Pc=928;continue;}
case 928:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(-1)));f.Pc=931;continue;}
case 931:{f.Pc=780;continue;}
case 934:{f.Push(f.Locals[1]);f.Pc=935;continue;}
case 935:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=938;continue;}
case 938:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",941);}
case 941:{f.Locals[12]=f.Pop();f.Pc=943;continue;}
case 943:{f.Push(f.Locals[12]);f.Pc=945;continue;}
case 945:{f.Pc=f.Pop().Int==0?954:948;continue;}
case 948:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=951;continue;}
case 951:{f.Pc=967;continue;}
case 954:{f.Push(f.Locals[1]);f.Pc=955;continue;}
case 955:{f.Push(JValue.R(rt.String("Zone")));f.Pc=958;continue;}
case 958:{f.Push(JValue.R(rt.String("Library")));f.Pc=961;continue;}
case 961:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",964);}
case 964:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",967);}
case 967:{f.Locals[13]=f.Pop();f.Pc=969;continue;}
case 969:{f.Push(f.Locals[13]);f.Pc=971;continue;}
case 971:{f.Pc=f.Pop().Reference!=null?975:974;continue;}
case 974:{return JStep.ReturnVoid;}
case 975:{f.Push(f.Locals[1]);f.Pc=976;continue;}
case 976:{f.Push(JValue.R(rt.String("Amount")));f.Pc=979;continue;}
case 979:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",982);}
case 982:{f.Pc=f.Pop().Int==0?1000:985;continue;}
case 985:{f.Push(f.Locals[3]);f.Pc=986;continue;}
case 986:{f.Push(f.Locals[1]);f.Pc=987;continue;}
case 987:{f.Push(JValue.R(rt.String("Amount")));f.Pc=990;continue;}
case 990:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",993);}
case 993:{f.Push(f.Locals[1]);f.Pc=994;continue;}
case 994:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",997);}
case 997:{f.Pc=1001;continue;}
case 1000:{f.Push(JValue.I(1));f.Pc=1001;continue;}
case 1001:{f.Locals[14]=f.Pop();f.Pc=1003;continue;}
case 1003:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1006;continue;}
case 1006:{f.StackOp("dup");f.Pc=1007;continue;}
case 1007:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1010);}
case 1010:{f.Locals[15]=f.Pop();f.Pc=1012;continue;}
case 1012:{f.Push(f.Locals[1]);f.Pc=1013;continue;}
case 1013:{return rt.Call(f,"forge/game/card/CardZoneTable","getSimultaneousInstance","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",1016);}
case 1016:{f.Locals[16]=f.Pop();f.Pc=1018;continue;}
case 1018:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=1021;continue;}
case 1021:{f.StackOp("dup");f.Pc=1022;continue;}
case 1022:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",1025);}
case 1025:{f.Locals[17]=f.Pop();f.Pc=1027;continue;}
case 1027:{f.Push(f.Locals[16]);f.Pc=1029;continue;}
case 1029:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",1032);}
case 1032:{f.Locals[18]=f.Pop();f.Pc=1034;continue;}
case 1034:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1037;continue;}
case 1037:{f.StackOp("dup");f.Pc=1038;continue;}
case 1038:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1041);}
case 1041:{f.Locals[19]=f.Pop();f.Pc=1043;continue;}
case 1043:{f.Push(f.Locals[12]);f.Pc=1045;continue;}
case 1045:{f.Pc=f.Pop().Int==0?1099:1048;continue;}
case 1048:{f.Push(f.Locals[3]);f.Pc=1049;continue;}
case 1049:{f.Push(f.Locals[1]);f.Pc=1050;continue;}
case 1050:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=1053;continue;}
case 1053:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1056);}
case 1056:{f.Push(f.Locals[1]);f.Pc=1057;continue;}
case 1057:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1060);}
case 1060:{f.Locals[19]=f.Pop();f.Pc=1062;continue;}
case 1062:{f.Push(f.Locals[19]);f.Pc=1064;continue;}
case 1064:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1067);}
case 1067:{f.Pc=f.Pop().Int==0?1090:1070;continue;}
case 1070:{f.Push(f.Locals[18]);f.Pc=1072;continue;}
case 1072:{f.Push(f.Locals[1]);f.Pc=1073;continue;}
case 1073:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=1076;continue;}
case 1076:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1079);}
case 1079:{f.Push(f.Locals[3]);f.Pc=1080;continue;}
case 1080:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1083);}
case 1083:{f.Push(f.Locals[3]);f.Pc=1084;continue;}
case 1084:{f.Push(f.Locals[1]);f.Pc=1085;continue;}
case 1085:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1088);}
case 1088:{f.Locals[19]=f.Pop();f.Pc=1090;continue;}
case 1090:{f.Push(f.Locals[19]);f.Pc=1092;continue;}
case 1092:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1095);}
case 1095:{f.Pc=f.Pop().Int==0?1099:1098;continue;}
case 1098:{return JStep.ReturnVoid;}
case 1099:{f.Push(f.Locals[10]);f.Pc=1101;continue;}
case 1101:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1106);}
case 1106:{f.Locals[20]=f.Pop();f.Pc=1108;continue;}
case 1108:{f.Push(f.Locals[20]);f.Pc=1110;continue;}
case 1110:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1115);}
case 1115:{f.Pc=f.Pop().Int==0?1330:1118;continue;}
case 1118:{f.Push(f.Locals[20]);f.Pc=1120;continue;}
case 1120:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1125);}
case 1125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1128;continue;}
case 1128:{f.Locals[21]=f.Pop();f.Pc=1130;continue;}
case 1130:{f.Push(f.Locals[14]);f.Pc=1132;continue;}
case 1132:{f.Locals[22]=f.Pop();f.Pc=1134;continue;}
case 1134:{f.Push(f.Locals[21]);f.Pc=1136;continue;}
case 1136:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1139);}
case 1139:{f.Pc=f.Pop().Int!=0?1327:1142;continue;}
case 1142:{f.Push(f.Locals[22]);f.Pc=1144;continue;}
case 1144:{f.Pc=f.Pop().Int<=0?1327:1147;continue;}
case 1147:{f.Push(f.Locals[9]);f.Pc=1149;continue;}
case 1149:{f.Pc=f.Pop().Reference==null?1187:1152;continue;}
case 1152:{f.Push(f.Locals[9]);f.Pc=1154;continue;}
case 1154:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",1159);}
case 1159:{f.Push(f.Locals[21]);f.Pc=1161;continue;}
case 1161:{return rt.DynamicCall(f,"forge/game/ability/effects/MakeCardEffect:3481:1161:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",1166);}
case 1166:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",1171);}
case 1171:{return rt.Call(f,"java/util/stream/Stream","findAny","()Ljava/util/Optional;","invokeinterface",1176);}
case 1176:{return rt.Call(f,"java/util/Optional","get","()Ljava/lang/Object;","invokevirtual",1179);}
case 1179:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1182;continue;}
case 1182:{f.Locals[23]=f.Pop();f.Pc=1184;continue;}
case 1184:{f.Pc=1224;continue;}
case 1187:{f.Push(f.Locals[1]);f.Pc=1188;continue;}
case 1188:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1191);}
case 1191:{f.Pc=f.Pop().Reference==null?1204:1194;continue;}
case 1194:{f.Push(f.Locals[1]);f.Pc=1195;continue;}
case 1195:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1198);}
case 1198:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",1201);}
case 1201:{f.Pc=1207;continue;}
case 1204:{f.Push(JValue.R(rt.String("???")));f.Pc=1207;continue;}
case 1207:{f.Locals[24]=f.Pop();f.Pc=1209;continue;}
case 1209:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",1212);}
case 1212:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",1215);}
case 1215:{f.Push(f.Locals[21]);f.Pc=1217;continue;}
case 1217:{f.Push(f.Locals[24]);f.Pc=1219;continue;}
case 1219:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",1222);}
case 1222:{f.Locals[23]=f.Pop();f.Pc=1224;continue;}
case 1224:{f.Push(f.Locals[23]);f.Pc=1226;continue;}
case 1226:{f.Pc=f.Pop().Reference!=null?1249:1229;continue;}
case 1229:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=1232;continue;}
case 1232:{f.Push(f.Locals[21]);f.Pc=1234;continue;}
case 1234:{f.Push(f.Locals[3]);f.Pc=1235;continue;}
case 1235:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1238);}
case 1238:{return rt.DynamicCall(f,"forge/game/ability/effects/MakeCardEffect:3481:1238:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1243);}
case 1243:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",1246);}
case 1246:{f.Pc=1327;continue;}
case 1249:{f.Push(f.Locals[23]);f.Pc=1251;continue;}
case 1251:{f.Push(f.Locals[6]);f.Pc=1253;continue;}
case 1253:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",1256);}
case 1256:{f.Locals[24]=f.Pop();f.Pc=1258;continue;}
case 1258:{f.Push(f.Locals[21]);f.Pc=1260;continue;}
case 1260:{f.Push(f.Locals[24]);f.Pc=1262;continue;}
case 1262:{return rt.Call(f,"forge/game/card/CardUtil","turnToRightFace","(Ljava/lang/String;Lforge/game/card/Card;)V","invokestatic",1265);}
case 1265:{f.Push(f.Locals[1]);f.Pc=1266;continue;}
case 1266:{f.Push(JValue.R(rt.String("TokenCard")));f.Pc=1269;continue;}
case 1269:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1272);}
case 1272:{f.Pc=f.Pop().Int==0?1281:1275;continue;}
case 1275:{f.Push(f.Locals[24]);f.Pc=1277;continue;}
case 1277:{f.Push(JValue.I(1));f.Pc=1278;continue;}
case 1278:{return rt.Call(f,"forge/game/card/Card","setTokenCard","(Z)V","invokevirtual",1281);}
case 1281:{f.Push(f.Locals[7]);f.Pc=1283;continue;}
case 1283:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1286);}
case 1286:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=1289;continue;}
case 1289:{f.Push(f.Locals[24]);f.Pc=1291;continue;}
case 1291:{f.Push(f.Locals[1]);f.Pc=1292;continue;}
case 1292:{f.Push(f.Locals[2]);f.Pc=1293;continue;}
case 1293:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",1296);}
case 1296:{f.StackOp("pop");f.Pc=1297;continue;}
case 1297:{f.Push(f.Locals[15]);f.Pc=1299;continue;}
case 1299:{f.Push(f.Locals[24]);f.Pc=1301;continue;}
case 1301:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1304);}
case 1304:{f.StackOp("pop");f.Pc=1305;continue;}
case 1305:{f.Locals[22]=JValue.I(unchecked(f.Locals[22].Int+(-1)));f.Pc=1308;continue;}
case 1308:{f.Push(f.Locals[1]);f.Pc=1309;continue;}
case 1309:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=1312;continue;}
case 1312:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1315);}
case 1315:{f.Pc=f.Pop().Int==0?1324:1318;continue;}
case 1318:{f.Push(f.Locals[24]);f.Pc=1320;continue;}
case 1320:{f.Push(JValue.I(1));f.Pc=1321;continue;}
case 1321:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",1324);}
case 1324:{f.Pc=1142;continue;}
case 1327:{f.Pc=1108;continue;}
case 1330:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1333;continue;}
case 1333:{f.StackOp("dup");f.Pc=1334;continue;}
case 1334:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1337);}
case 1337:{f.Locals[20]=f.Pop();f.Pc=1339;continue;}
case 1339:{f.Push(f.Locals[1]);f.Pc=1340;continue;}
case 1340:{f.Push(JValue.R(rt.String("WithCounter")));f.Pc=1343;continue;}
case 1343:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1346);}
case 1346:{f.Locals[21]=f.Pop();f.Pc=1348;continue;}
case 1348:{f.Push(f.Locals[13]);f.Pc=1350;continue;}
case 1350:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1353;continue;}
case 1353:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",1356);}
case 1356:{f.Locals[22]=f.Pop();f.Pc=1358;continue;}
case 1358:{f.Push(f.Locals[15]);f.Pc=1360;continue;}
case 1360:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1363);}
case 1363:{f.Locals[23]=f.Pop();f.Pc=1365;continue;}
case 1365:{f.Push(f.Locals[23]);f.Pc=1367;continue;}
case 1367:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1372);}
case 1372:{f.Pc=f.Pop().Int==0?1755:1375;continue;}
case 1375:{f.Push(f.Locals[23]);f.Pc=1377;continue;}
case 1377:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1382);}
case 1382:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1385;continue;}
case 1385:{f.Locals[24]=f.Pop();f.Pc=1387;continue;}
case 1387:{f.Push(f.Locals[21]);f.Pc=1389;continue;}
case 1389:{f.Pc=f.Pop().Int==0?1457:1392;continue;}
case 1392:{f.Push(f.Locals[22]);f.Pc=1394;continue;}
case 1394:{f.Pc=f.Pop().Int==0?1457:1397;continue;}
case 1397:{f.Push(f.Locals[3]);f.Pc=1398;continue;}
case 1398:{f.Push(f.Locals[1]);f.Pc=1399;continue;}
case 1399:{f.Push(JValue.R(rt.String("WithCounterNum")));f.Pc=1402;continue;}
case 1402:{f.Push(JValue.R(rt.String("1")));f.Pc=1405;continue;}
case 1405:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1408);}
case 1408:{f.Push(f.Locals[1]);f.Pc=1409;continue;}
case 1409:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1412);}
case 1412:{f.Locals[25]=f.Pop();f.Pc=1414;continue;}
case 1414:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=1417;continue;}
case 1417:{f.StackOp("dup");f.Pc=1418;continue;}
case 1418:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",1421);}
case 1421:{f.Locals[26]=f.Pop();f.Pc=1423;continue;}
case 1423:{f.Push(f.Locals[26]);f.Pc=1425;continue;}
case 1425:{f.Push(f.Locals[6]);f.Pc=1427;continue;}
case 1427:{f.Push(f.Locals[24]);f.Pc=1429;continue;}
case 1429:{f.Push(f.Locals[1]);f.Pc=1430;continue;}
case 1430:{f.Push(JValue.R(rt.String("WithCounter")));f.Pc=1433;continue;}
case 1433:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1436);}
case 1436:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",1439);}
case 1439:{f.Push(f.Locals[25]);f.Pc=1441;continue;}
case 1441:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",1444);}
case 1444:{f.StackOp("pop");f.Pc=1445;continue;}
case 1445:{f.Push(f.Locals[2]);f.Pc=1446;continue;}
case 1446:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=1449;continue;}
case 1449:{f.Push(f.Locals[26]);f.Pc=1451;continue;}
case 1451:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1456);}
case 1456:{f.StackOp("pop");f.Pc=1457;continue;}
case 1457:{f.Push(f.Locals[12]);f.Pc=1459;continue;}
case 1459:{f.Pc=f.Pop().Int==0?1629:1462;continue;}
case 1462:{f.Push(f.Locals[19]);f.Pc=1464;continue;}
case 1464:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1467);}
case 1467:{f.Locals[25]=f.Pop();f.Pc=1469;continue;}
case 1469:{f.Push(f.Locals[25]);f.Pc=1471;continue;}
case 1471:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1476);}
case 1476:{f.Pc=f.Pop().Int==0?1626:1479;continue;}
case 1479:{f.Push(f.Locals[25]);f.Pc=1481;continue;}
case 1481:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1486);}
case 1486:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1489;continue;}
case 1489:{f.Locals[26]=f.Pop();f.Pc=1491;continue;}
case 1491:{f.Push(f.Locals[24]);f.Pc=1493;continue;}
case 1493:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1496);}
case 1496:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1499);}
case 1499:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=1502;continue;}
case 1502:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",1505);}
case 1505:{f.Pc=f.Pop().Int==0?1515:1508;continue;}
case 1508:{f.Push(f.Locals[24]);f.Pc=1510;continue;}
case 1510:{f.Locals[27]=f.Pop();f.Pc=1512;continue;}
case 1512:{f.Pc=1561;continue;}
case 1515:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",1518);}
case 1518:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",1521);}
case 1521:{f.Push(f.Locals[24]);f.Pc=1523;continue;}
case 1523:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",1526);}
case 1526:{f.Push(f.Locals[24]);f.Pc=1528;continue;}
case 1528:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",1531);}
case 1531:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",1534);}
case 1534:{f.Locals[28]=f.Pop();f.Pc=1536;continue;}
case 1536:{f.Push(f.Locals[28]);f.Pc=1538;continue;}
case 1538:{f.Push(f.Locals[6]);f.Pc=1540;continue;}
case 1540:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",1543);}
case 1543:{f.Locals[27]=f.Pop();f.Pc=1545;continue;}
case 1545:{f.Push(f.Locals[7]);f.Pc=1547;continue;}
case 1547:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1550);}
case 1550:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=1553;continue;}
case 1553:{f.Push(f.Locals[27]);f.Pc=1555;continue;}
case 1555:{f.Push(f.Locals[1]);f.Pc=1556;continue;}
case 1556:{f.Push(f.Locals[2]);f.Pc=1557;continue;}
case 1557:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",1560);}
case 1560:{f.StackOp("pop");f.Pc=1561;continue;}
case 1561:{f.Push(f.Locals[27]);f.Pc=1563;continue;}
case 1563:{f.Push(f.Locals[7]);f.Pc=1565;continue;}
case 1565:{f.Push(f.Locals[26]);f.Pc=1567;continue;}
case 1567:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",1570);}
case 1570:{f.Push(f.Locals[1]);f.Pc=1571;continue;}
case 1571:{f.Push(JValue.I(1));f.Pc=1572;continue;}
case 1572:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;Z)V","invokevirtual",1575);}
case 1575:{f.Push(f.Locals[7]);f.Pc=1577;continue;}
case 1577:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1580);}
case 1580:{f.Push(f.Locals[13]);f.Pc=1582;continue;}
case 1582:{f.Push(f.Locals[27]);f.Pc=1584;continue;}
case 1584:{f.Push(f.Locals[1]);f.Pc=1585;continue;}
case 1585:{f.Push(f.Locals[2]);f.Pc=1586;continue;}
case 1586:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",1589);}
case 1589:{f.StackOp("pop");f.Pc=1590;continue;}
case 1590:{f.Push(f.Locals[16]);f.Pc=1592;continue;}
case 1592:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=1595;continue;}
case 1595:{f.Push(f.Locals[27]);f.Pc=1597;continue;}
case 1597:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1600);}
case 1600:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1603);}
case 1603:{f.Push(f.Locals[27]);f.Pc=1605;continue;}
case 1605:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",1608);}
case 1608:{f.StackOp("pop");f.Pc=1609;continue;}
case 1609:{f.Push(f.Locals[20]);f.Pc=1611;continue;}
case 1611:{f.Push(f.Locals[0]);f.Pc=1612;continue;}
case 1612:{f.Push(f.Locals[1]);f.Pc=1613;continue;}
case 1613:{f.Push(f.Locals[27]);f.Pc=1615;continue;}
case 1615:{f.Push(f.Locals[3]);f.Pc=1616;continue;}
case 1616:{return rt.Call(f,"forge/game/ability/effects/MakeCardEffect","finishMaking","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",1619);}
case 1619:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1622);}
case 1622:{f.StackOp("pop");f.Pc=1623;continue;}
case 1623:{f.Pc=1469;continue;}
case 1626:{f.Pc=1752;continue;}
case 1629:{f.Push(f.Locals[1]);f.Pc=1630;continue;}
case 1630:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=1633;continue;}
case 1633:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1636);}
case 1636:{f.Pc=f.Pop().Int==0?1654:1639;continue;}
case 1639:{f.Push(f.Locals[3]);f.Pc=1640;continue;}
case 1640:{f.Push(f.Locals[1]);f.Pc=1641;continue;}
case 1641:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=1644;continue;}
case 1644:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1647);}
case 1647:{f.Push(f.Locals[1]);f.Pc=1648;continue;}
case 1648:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1651);}
case 1651:{f.Pc=1655;continue;}
case 1654:{f.Push(JValue.I(0));f.Pc=1655;continue;}
case 1655:{f.Locals[25]=f.Pop();f.Pc=1657;continue;}
case 1657:{f.Push(f.Locals[7]);f.Pc=1659;continue;}
case 1659:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1662);}
case 1662:{f.Push(f.Locals[13]);f.Pc=1664;continue;}
case 1664:{f.Push(f.Locals[24]);f.Pc=1666;continue;}
case 1666:{f.Push(f.Locals[25]);f.Pc=1668;continue;}
case 1668:{f.Push(f.Locals[1]);f.Pc=1669;continue;}
case 1669:{f.Push(f.Locals[2]);f.Pc=1670;continue;}
case 1670:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",1673);}
case 1673:{f.Locals[26]=f.Pop();f.Pc=1675;continue;}
case 1675:{f.Push(f.Locals[21]);f.Pc=1677;continue;}
case 1677:{f.Pc=f.Pop().Int==0?1719:1680;continue;}
case 1680:{f.Push(f.Locals[22]);f.Pc=1682;continue;}
case 1682:{f.Pc=f.Pop().Int!=0?1719:1685;continue;}
case 1685:{f.Push(f.Locals[26]);f.Pc=1687;continue;}
case 1687:{f.Push(f.Locals[1]);f.Pc=1688;continue;}
case 1688:{f.Push(JValue.R(rt.String("WithCounter")));f.Pc=1691;continue;}
case 1691:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1694);}
case 1694:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",1697);}
case 1697:{f.Push(f.Locals[3]);f.Pc=1698;continue;}
case 1698:{f.Push(f.Locals[1]);f.Pc=1699;continue;}
case 1699:{f.Push(JValue.R(rt.String("WithCounterNum")));f.Pc=1702;continue;}
case 1702:{f.Push(JValue.R(rt.String("1")));f.Pc=1705;continue;}
case 1705:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1708);}
case 1708:{f.Push(f.Locals[1]);f.Pc=1709;continue;}
case 1709:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1712);}
case 1712:{f.Push(f.Locals[6]);f.Pc=1714;continue;}
case 1714:{f.Push(f.Locals[17]);f.Pc=1716;continue;}
case 1716:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",1719);}
case 1719:{f.Push(f.Locals[16]);f.Pc=1721;continue;}
case 1721:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=1724;continue;}
case 1724:{f.Push(f.Locals[26]);f.Pc=1726;continue;}
case 1726:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1729);}
case 1729:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1732);}
case 1732:{f.Push(f.Locals[26]);f.Pc=1734;continue;}
case 1734:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",1737);}
case 1737:{f.StackOp("pop");f.Pc=1738;continue;}
case 1738:{f.Push(f.Locals[20]);f.Pc=1740;continue;}
case 1740:{f.Push(f.Locals[0]);f.Pc=1741;continue;}
case 1741:{f.Push(f.Locals[1]);f.Pc=1742;continue;}
case 1742:{f.Push(f.Locals[26]);f.Pc=1744;continue;}
case 1744:{f.Push(f.Locals[3]);f.Pc=1745;continue;}
case 1745:{return rt.Call(f,"forge/game/ability/effects/MakeCardEffect","finishMaking","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",1748);}
case 1748:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1751);}
case 1751:{f.StackOp("pop");f.Pc=1752;continue;}
case 1752:{f.Pc=1365;continue;}
case 1755:{f.Push(f.Locals[16]);f.Pc=1757;continue;}
case 1757:{f.Push(f.Locals[7]);f.Pc=1759;continue;}
case 1759:{f.Push(f.Locals[1]);f.Pc=1760;continue;}
case 1760:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1763);}
case 1763:{f.Push(f.Locals[17]);f.Pc=1765;continue;}
case 1765:{f.Push(f.Locals[7]);f.Pc=1767;continue;}
case 1767:{f.Push(f.Locals[1]);f.Pc=1768;continue;}
case 1768:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1771);}
case 1771:{f.Push(f.Locals[1]);f.Pc=1772;continue;}
case 1772:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=1775;continue;}
case 1775:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1778);}
case 1778:{f.Pc=f.Pop().Int==0?1794:1781;continue;}
case 1781:{f.Push(f.Locals[7]);f.Pc=1783;continue;}
case 1783:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1786);}
case 1786:{f.Push(f.Locals[15]);f.Pc=1788;continue;}
case 1788:{f.Push(f.Locals[6]);f.Pc=1790;continue;}
case 1790:{f.Push(JValue.I(1));f.Pc=1791;continue;}
case 1791:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;Z)V","invokevirtual",1794);}
case 1794:{f.Push(f.Locals[1]);f.Pc=1795;continue;}
case 1795:{f.Push(JValue.R(rt.String("Conjure")));f.Pc=1798;continue;}
case 1798:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1801);}
case 1801:{f.Pc=f.Pop().Int==0?1850:1804;continue;}
case 1804:{f.Push(f.Locals[6]);f.Pc=1806;continue;}
case 1806:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",1809);}
case 1809:{f.Locals[23]=f.Pop();f.Pc=1811;continue;}
case 1811:{f.Push(f.Locals[23]);f.Pc=1813;continue;}
case 1813:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=1816;continue;}
case 1816:{f.Push(f.Locals[20]);f.Pc=1818;continue;}
case 1818:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1823);}
case 1823:{f.StackOp("pop");f.Pc=1824;continue;}
case 1824:{f.Push(f.Locals[23]);f.Pc=1826;continue;}
case 1826:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=1829;continue;}
case 1829:{f.Push(f.Locals[1]);f.Pc=1830;continue;}
case 1830:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1835);}
case 1835:{f.StackOp("pop");f.Pc=1836;continue;}
case 1836:{f.Push(f.Locals[7]);f.Pc=1838;continue;}
case 1838:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1841);}
case 1841:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ConjureAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ConjureAll","Lforge/game/trigger/TriggerType;"));f.Pc=1844;continue;}
case 1844:{f.Push(f.Locals[23]);f.Pc=1846;continue;}
case 1846:{f.Push(JValue.I(0));f.Pc=1847;continue;}
case 1847:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1850);}
case 1850:{f.Push(f.Locals[13]);f.Pc=1852;continue;}
case 1852:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=1855;continue;}
case 1855:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",1858);}
case 1858:{f.Pc=f.Pop().Int==0?1877:1861;continue;}
case 1861:{f.Push(f.Locals[1]);f.Pc=1862;continue;}
case 1862:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=1865;continue;}
case 1865:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1868);}
case 1868:{f.Pc=f.Pop().Int!=0?1877:1871;continue;}
case 1871:{f.Push(f.Locals[6]);f.Pc=1873;continue;}
case 1873:{f.Push(f.Locals[1]);f.Pc=1874;continue;}
case 1874:{return rt.Call(f,"forge/game/player/Player","shuffle","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1877);}
case 1877:{f.Pc=57;continue;}
case 1880:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3482(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",13);}
case 13:{f.Push(JValue.R(rt.String(",")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=23;continue;}
case 23:{f.Locals[5]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{f.Locals[6]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[6]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?104:35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[6]);f.Pc=39;continue;}
case 39:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=40;continue;}
case 40:{f.Locals[7]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[7]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String(";")));f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String(",")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",51);}
case 51:{f.Locals[7]=f.Pop();f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",56);}
case 56:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",59);}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/card/CardDb","getFaceByName","(Ljava/lang/String;)Lforge/card/ICardFace;","invokevirtual",64);}
case 64:{f.Locals[8]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[8]);f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Reference==null?83:71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[8]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Pc=98;continue;}
case 83:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=86;continue;}
case 86:{f.StackOp("dup");f.Pc=87;continue;}
case 87:{f.Push(f.Locals[7]);f.Pc=89;continue;}
case 89:{return rt.DynamicCall(f,"forge/game/ability/effects/MakeCardEffect:3482:89:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",94);}
case 94:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",97);}
case 97:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 98:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=101;continue;}
case 101:{f.Pc=28;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3483(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("FaceDown")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?16:10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("RememberMade")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?31:26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("ImprintMade")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?46:41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",46);}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3484(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

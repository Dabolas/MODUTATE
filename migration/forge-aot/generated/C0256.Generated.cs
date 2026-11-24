// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C256{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ControlGainVariantEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3211,"forge/game/ability/effects/ControlGainVariantEffect","<init>","()V",1,1,1,new JHandler[]{},M3211));
c.Add(new JMethod(3212,"forge/game/ability/effects/ControlGainVariantEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M3212));
c.Add(new JMethod(3213,"forge/game/ability/effects/ControlGainVariantEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,16,6,new JHandler[]{},M3213));
}

internal static JStep M3211(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3212(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3213(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("ChangeController")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Locals[6]=f.Pop();f.Pc=24;continue;}
case 24:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",27);}
case 27:{f.Locals[7]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",33);}
case 33:{f.Locals[8]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[8]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",44);}
case 44:{f.Locals[9]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[9]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(-1));f.Pc=49;continue;}
case 49:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?60:52;continue;}
case 52:{f.Push(f.Locals[8]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[9]);f.Pc=56;continue;}
case 56:{f.Push(JNumbers.Unary("ineg",f.Pop()));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Collections","rotate","(Ljava/util/List;I)V","invokestatic",60);}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",67);}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("AllValid")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",77);}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",82);}
case 82:{f.Locals[10]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("NextPlayerInChosenDirection")));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?161:94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","getChosenDirection","()Lforge/game/Direction;","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Reference==null?161:101;continue;}
case 101:{f.Push(f.Locals[8]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",106);}
case 106:{f.Locals[11]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[11]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",115);}
case 115:{f.Pc=f.Pop().Int==0?158:118;continue;}
case 118:{f.Push(f.Locals[11]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",125);}
case 125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=128;continue;}
case 128:{f.Locals[12]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[7]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[12]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[10]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[12]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/card/Card","getChosenDirection","()Lforge/game/Direction;","invokevirtual",143);}
case 143:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;Lforge/game/Direction;)Lforge/game/player/Player;","invokevirtual",146);}
case 146:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",149);}
case 149:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",154);}
case 154:{f.StackOp("pop");f.Pc=155;continue;}
case 155:{f.Pc=108;continue;}
case 158:{f.Pc=554;continue;}
case 161:{f.Push(JValue.R(rt.String("CardOwner")));f.Pc=163;continue;}
case 163:{f.Push(f.Locals[6]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",168);}
case 168:{f.Pc=f.Pop().Int==0?226:171;continue;}
case 171:{f.Push(f.Locals[8]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",176);}
case 176:{f.Locals[11]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[11]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",185);}
case 185:{f.Pc=f.Pop().Int==0?223:188;continue;}
case 188:{f.Push(f.Locals[11]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",195);}
case 195:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=198;continue;}
case 198:{f.Locals[12]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(f.Locals[7]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[12]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[10]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[12]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/card/CardPredicates","isOwner","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",211);}
case 211:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",214);}
case 214:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",219);}
case 219:{f.StackOp("pop");f.Pc=220;continue;}
case 220:{f.Pc=178;continue;}
case 223:{f.Pc=554;continue;}
case 226:{f.Push(JValue.R(rt.String("Random")));f.Pc=228;continue;}
case 228:{f.Push(f.Locals[6]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",233);}
case 233:{f.Pc=f.Pop().Int==0?333:236;continue;}
case 236:{f.Push(f.Locals[10]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",241);}
case 241:{f.Locals[11]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[11]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",250);}
case 250:{f.Pc=f.Pop().Int==0?330:253;continue;}
case 253:{f.Push(f.Locals[11]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",260);}
case 260:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=263;continue;}
case 263:{f.Locals[12]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[8]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",270);}
case 270:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=273;continue;}
case 273:{f.Locals[13]=f.Pop();f.Pc=275;continue;}
case 275:{f.Push(f.Locals[7]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[13]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",284);}
case 284:{f.Pc=f.Pop().Int==0?308:287;continue;}
case 287:{f.Push(f.Locals[7]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[13]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",296);}
case 296:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=299;continue;}
case 299:{f.Push(JValue.I(0));f.Pc=300;continue;}
case 300:{f.Push(f.Locals[12]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/card/CardCollection","add","(ILjava/lang/Object;)V","invokevirtual",305);}
case 305:{f.Pc=327;continue;}
case 308:{f.Push(f.Locals[7]);f.Pc=310;continue;}
case 310:{f.Push(f.Locals[13]);f.Pc=312;continue;}
case 312:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=315;continue;}
case 315:{f.StackOp("dup");f.Pc=316;continue;}
case 316:{f.Push(f.Locals[12]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",321);}
case 321:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",326);}
case 326:{f.StackOp("pop");f.Pc=327;continue;}
case 327:{f.Pc=243;continue;}
case 330:{f.Pc=554;continue;}
case 333:{f.Push(JValue.R(rt.String("ChooseNextPlayerInChosenDirection")));f.Pc=335;continue;}
case 335:{f.Push(f.Locals[6]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",340);}
case 340:{f.Pc=f.Pop().Int==0?443:343;continue;}
case 343:{f.Push(f.Locals[2]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/card/Card","getChosenDirection","()Lforge/game/Direction;","invokevirtual",347);}
case 347:{f.Pc=f.Pop().Reference==null?443:350;continue;}
case 350:{f.Push(f.Locals[1]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",354);}
case 354:{f.Locals[11]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(f.Locals[10]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[3]);f.Pc=359;continue;}
case 359:{f.Push(f.Locals[11]);f.Pc=361;continue;}
case 361:{f.Push(f.Locals[2]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/card/Card","getChosenDirection","()Lforge/game/Direction;","invokevirtual",365);}
case 365:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;Lforge/game/Direction;)Lforge/game/player/Player;","invokevirtual",368);}
case 368:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",371);}
case 371:{f.Locals[12]=f.Pop();f.Pc=373;continue;}
case 373:{f.Push(f.Locals[11]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",378);}
case 378:{f.Push(f.Locals[12]);f.Pc=380;continue;}
case 380:{f.Push(f.Locals[1]);f.Pc=381;continue;}
case 381:{f.Push(JValue.R(rt.String(" ")));f.Pc=383;continue;}
case 383:{f.Push(JValue.R(null));f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",387);}
case 387:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=390;continue;}
case 390:{f.Locals[13]=f.Pop();f.Pc=392;continue;}
case 392:{f.Push(f.Locals[13]);f.Pc=394;continue;}
case 394:{f.Pc=f.Pop().Reference==null?416:397;continue;}
case 397:{f.Push(f.Locals[7]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[11]);f.Pc=401;continue;}
case 401:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=404;continue;}
case 404:{f.StackOp("dup");f.Pc=405;continue;}
case 405:{f.Push(f.Locals[13]);f.Pc=407;continue;}
case 407:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",410);}
case 410:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",415);}
case 415:{f.StackOp("pop");f.Pc=416;continue;}
case 416:{f.Push(f.Locals[3]);f.Pc=417;continue;}
case 417:{f.Push(f.Locals[11]);f.Pc=419;continue;}
case 419:{f.Push(f.Locals[2]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/card/Card","getChosenDirection","()Lforge/game/Direction;","invokevirtual",423);}
case 423:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;Lforge/game/Direction;)Lforge/game/player/Player;","invokevirtual",426);}
case 426:{f.Locals[11]=f.Pop();f.Pc=428;continue;}
case 428:{f.Push(f.Locals[11]);f.Pc=430;continue;}
case 430:{f.Push(f.Locals[1]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",434);}
case 434:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",437);}
case 437:{f.Pc=f.Pop().Int==0?356:440;continue;}
case 440:{f.Pc=554;continue;}
case 443:{f.Push(JValue.R(rt.String("ChooseFromPlayerToTheirRight")));f.Pc=445;continue;}
case 445:{f.Push(f.Locals[6]);f.Pc=447;continue;}
case 447:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",450);}
case 450:{f.Pc=f.Pop().Int==0?554:453;continue;}
case 453:{f.Push(f.Locals[8]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",458);}
case 458:{f.Locals[11]=f.Pop();f.Pc=460;continue;}
case 460:{f.Push(f.Locals[11]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",467);}
case 467:{f.Pc=f.Pop().Int==0?554:470;continue;}
case 470:{f.Push(f.Locals[11]);f.Pc=472;continue;}
case 472:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",477);}
case 477:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=480;continue;}
case 480:{f.Locals[12]=f.Pop();f.Pc=482;continue;}
case 482:{f.Push(f.Locals[10]);f.Pc=484;continue;}
case 484:{f.Push(f.Locals[3]);f.Pc=485;continue;}
case 485:{f.Push(f.Locals[12]);f.Pc=487;continue;}
case 487:{if(!rt.StaticReady(f,"forge/game/Direction","Right","Lforge/game/Direction;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Direction","Right","Lforge/game/Direction;"));f.Pc=490;continue;}
case 490:{return rt.Call(f,"forge/game/Game","getNextPlayerAfter","(Lforge/game/player/Player;Lforge/game/Direction;)Lforge/game/player/Player;","invokevirtual",493);}
case 493:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",496);}
case 496:{f.Locals[13]=f.Pop();f.Pc=498;continue;}
case 498:{f.Push(f.Locals[1]);f.Pc=499;continue;}
case 499:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",502);}
case 502:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",505);}
case 505:{f.Push(f.Locals[13]);f.Pc=507;continue;}
case 507:{f.Push(f.Locals[1]);f.Pc=508;continue;}
case 508:{f.Push(f.Locals[12]);f.Pc=510;continue;}
case 510:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",513);}
case 513:{return rt.DynamicCall(f,"forge/game/ability/effects/ControlGainVariantEffect:3213:513:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",518);}
case 518:{f.Push(JValue.R(null));f.Pc=519;continue;}
case 519:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",522);}
case 522:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=525;continue;}
case 525:{f.Locals[14]=f.Pop();f.Pc=527;continue;}
case 527:{f.Push(f.Locals[14]);f.Pc=529;continue;}
case 529:{f.Pc=f.Pop().Reference==null?551:532;continue;}
case 532:{f.Push(f.Locals[7]);f.Pc=534;continue;}
case 534:{f.Push(f.Locals[12]);f.Pc=536;continue;}
case 536:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=539;continue;}
case 539:{f.StackOp("dup");f.Pc=540;continue;}
case 540:{f.Push(f.Locals[14]);f.Pc=542;continue;}
case 542:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",545);}
case 545:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",550);}
case 550:{f.StackOp("pop");f.Pc=551;continue;}
case 551:{f.Pc=460;continue;}
case 554:{f.Push(f.Locals[7]);f.Pc=556;continue;}
case 556:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",561);}
case 561:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",566);}
case 566:{f.Locals[11]=f.Pop();f.Pc=568;continue;}
case 568:{f.Push(f.Locals[11]);f.Pc=570;continue;}
case 570:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",575);}
case 575:{f.Pc=f.Pop().Int==0?675:578;continue;}
case 578:{f.Push(f.Locals[11]);f.Pc=580;continue;}
case 580:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",585);}
case 585:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=588;continue;}
case 588:{f.Locals[12]=f.Pop();f.Pc=590;continue;}
case 590:{f.Push(f.Locals[12]);f.Pc=592;continue;}
case 592:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",597);}
case 597:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=600;continue;}
case 600:{f.Locals[13]=f.Pop();f.Pc=602;continue;}
case 602:{f.Push(f.Locals[12]);f.Pc=604;continue;}
case 604:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",609);}
case 609:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=612;continue;}
case 612:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",615);}
case 615:{f.Locals[14]=f.Pop();f.Pc=617;continue;}
case 617:{f.Push(f.Locals[14]);f.Pc=619;continue;}
case 619:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",624);}
case 624:{f.Pc=f.Pop().Int==0?672:627;continue;}
case 627:{f.Push(f.Locals[14]);f.Pc=629;continue;}
case 629:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",634);}
case 634:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=637;continue;}
case 637:{f.Locals[15]=f.Pop();f.Pc=639;continue;}
case 639:{f.Push(f.Locals[15]);f.Pc=641;continue;}
case 641:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",644);}
case 644:{f.Pc=f.Pop().Int==0?617:647;continue;}
case 647:{f.Push(f.Locals[15]);f.Pc=649;continue;}
case 649:{f.Push(f.Locals[13]);f.Pc=651;continue;}
case 651:{return rt.Call(f,"forge/game/card/Card","canBeControlledBy","(Lforge/game/player/Player;)Z","invokevirtual",654);}
case 654:{f.Pc=f.Pop().Int!=0?660:657;continue;}
case 657:{f.Pc=617;continue;}
case 660:{f.Push(f.Locals[15]);f.Pc=662;continue;}
case 662:{f.Push(f.Locals[13]);f.Pc=664;continue;}
case 664:{f.Push(f.Locals[4]);f.Pc=666;continue;}
case 666:{return rt.Call(f,"forge/game/card/Card","addTempController","(Lforge/game/player/Player;J)V","invokevirtual",669);}
case 669:{f.Pc=617;continue;}
case 672:{f.Pc=568;continue;}
case 675:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

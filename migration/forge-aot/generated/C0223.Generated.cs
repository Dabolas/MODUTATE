// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C223{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChangeTextEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3090,"forge/game/ability/effects/ChangeTextEffect","<init>","()V",1,1,1,new JHandler[]{},M3090));
c.Add(new JMethod(3091,"forge/game/ability/effects/ChangeTextEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,14,7,new JHandler[]{},M3091));
c.Add(new JMethod(3092,"forge/game/ability/effects/ChangeTextEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,11,3,new JHandler[]{},M3092));
}

internal static JStep M3090(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3091(JRuntime rt,JFrame f)
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
case 14:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Duration")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",30);}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("ChangeColorWord")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?207:41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Locals[8]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("ChangeColorWord")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",50);}
case 50:{f.Push(JValue.R(rt.String(" ")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",55);}
case 55:{f.Locals[9]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[9]);f.Pc=59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Choose")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?110:69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",73);}
case 73:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",76);}
case 76:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",79);}
case 79:{f.Push(JValue.R(rt.String("lblChooseColorReplace")));f.Pc=81;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",88);}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/player/PlayerController","chooseColor","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;)B","invokevirtual",95);}
case 95:{f.Locals[8]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[8]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/card/MagicColor","toLongString","(B)Ljava/lang/String;","invokestatic",102);}
case 102:{return rt.Call(f,"forge/util/TextUtil","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",105);}
case 105:{f.Locals[6]=f.Pop();f.Pc=107;continue;}
case 107:{f.Pc=123;continue;}
case 110:{f.Push(f.Locals[9]);f.Pc=112;continue;}
case 112:{f.Push(JValue.I(0));f.Pc=113;continue;}
case 113:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=114;continue;}
case 114:{f.Locals[6]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[6]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",121);}
case 121:{f.Locals[8]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[9]);f.Pc=125;continue;}
case 125:{f.Push(JValue.I(1));f.Pc=126;continue;}
case 126:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("Choose")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",132);}
case 132:{f.Pc=f.Pop().Int==0?198:135;continue;}
case 135:{f.Push(f.Locals[8]);f.Pc=137;continue;}
case 137:{f.Pc=f.Pop().Int!=0?148:140;continue;}
case 140:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"));f.Pc=143;continue;}
case 143:{f.Locals[10]=f.Pop();f.Pc=145;continue;}
case 145:{f.Pc=158;continue;}
case 148:{f.Push(f.Locals[8]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",153);}
case 153:{return rt.Call(f,"forge/card/ColorSet","inverse","()Lforge/card/ColorSet;","invokevirtual",156);}
case 156:{f.Locals[10]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[1]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",162);}
case 162:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",165);}
case 165:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",168);}
case 168:{f.Push(JValue.R(rt.String("lblChooseNewColor")));f.Pc=170;continue;}
case 170:{f.Push(JValue.I(0));f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",177);}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[10]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/player/PlayerController","chooseColor","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;)B","invokevirtual",183);}
case 183:{f.Locals[11]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[11]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/card/MagicColor","toLongString","(B)Ljava/lang/String;","invokestatic",190);}
case 190:{return rt.Call(f,"forge/util/TextUtil","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",193);}
case 193:{f.Locals[7]=f.Pop();f.Pc=195;continue;}
case 195:{f.Pc=204;continue;}
case 198:{f.Push(f.Locals[9]);f.Pc=200;continue;}
case 200:{f.Push(JValue.I(1));f.Pc=201;continue;}
case 201:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=202;continue;}
case 202:{f.Locals[7]=f.Pop();f.Pc=204;continue;}
case 204:{f.Pc=213;continue;}
case 207:{f.Push(JValue.R(null));f.Pc=208;continue;}
case 208:{f.Locals[6]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(JValue.R(null));f.Pc=211;continue;}
case 211:{f.Locals[7]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[1]);f.Pc=214;continue;}
case 214:{f.Push(JValue.R(rt.String("ChangeTypeWord")));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int==0?507:222;continue;}
case 222:{f.Push(JValue.R(rt.String("")));f.Pc=224;continue;}
case 224:{f.Locals[10]=f.Pop();f.Pc=226;continue;}
case 226:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",229);}
case 229:{f.Locals[11]=f.Pop();f.Pc=231;continue;}
case 231:{f.Push(f.Locals[1]);f.Pc=232;continue;}
case 232:{f.Push(JValue.R(rt.String("ChangeTypeWord")));f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",237);}
case 237:{f.Push(JValue.R(rt.String(" ")));f.Pc=239;continue;}
case 239:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",242);}
case 242:{f.Locals[12]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(f.Locals[12]);f.Pc=246;continue;}
case 246:{f.Push(JValue.I(0));f.Pc=247;continue;}
case 247:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=248;continue;}
case 248:{f.Push(JValue.R(rt.String("ChooseBasicLandType")));f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",253);}
case 253:{f.Pc=f.Pop().Int!=0?268:256;continue;}
case 256:{f.Push(f.Locals[12]);f.Pc=258;continue;}
case 258:{f.Push(JValue.I(0));f.Pc=259;continue;}
case 259:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=260;continue;}
case 260:{f.Push(JValue.R(rt.String("ChooseCreatureType")));f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",265);}
case 265:{f.Pc=f.Pop().Int==0?345:268;continue;}
case 268:{f.Push(f.Locals[12]);f.Pc=270;continue;}
case 270:{f.Push(JValue.I(0));f.Pc=271;continue;}
case 271:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=272;continue;}
case 272:{f.Push(JValue.R(rt.String("ChooseBasicLandType")));f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",277);}
case 277:{f.Pc=f.Pop().Int==0?298:280;continue;}
case 280:{f.Push(f.Locals[11]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/card/CardType","getBasicTypes","()Ljava/util/Collection;","invokestatic",285);}
case 285:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",290);}
case 290:{f.StackOp("pop");f.Pc=291;continue;}
case 291:{f.Push(JValue.R(rt.String("basic land")));f.Pc=293;continue;}
case 293:{f.Locals[10]=f.Pop();f.Pc=295;continue;}
case 295:{f.Pc=325;continue;}
case 298:{f.Push(f.Locals[12]);f.Pc=300;continue;}
case 300:{f.Push(JValue.I(0));f.Pc=301;continue;}
case 301:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.String("ChooseCreatureType")));f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",307);}
case 307:{f.Pc=f.Pop().Int==0?325:310;continue;}
case 310:{f.Push(f.Locals[11]);f.Pc=312;continue;}
case 312:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;"));f.Pc=315;continue;}
case 315:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",320);}
case 320:{f.StackOp("pop");f.Pc=321;continue;}
case 321:{f.Push(JValue.R(rt.String("Creature")));f.Pc=323;continue;}
case 323:{f.Locals[10]=f.Pop();f.Pc=325;continue;}
case 325:{f.Push(f.Locals[1]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",329);}
case 329:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",332);}
case 332:{f.Push(f.Locals[10]);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[1]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[11]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/player/PlayerController","chooseSomeType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/Collection;)Ljava/lang/String;","invokevirtual",340);}
case 340:{f.Locals[8]=f.Pop();f.Pc=342;continue;}
case 342:{f.Pc=351;continue;}
case 345:{f.Push(f.Locals[12]);f.Pc=347;continue;}
case 347:{f.Push(JValue.I(0));f.Pc=348;continue;}
case 348:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=349;continue;}
case 349:{f.Locals[8]=f.Pop();f.Pc=351;continue;}
case 351:{f.Push(f.Locals[11]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",358);}
case 358:{f.Push(f.Locals[1]);f.Pc=359;continue;}
case 359:{f.Push(JValue.R(rt.String("ForbiddenNewTypes")));f.Pc=361;continue;}
case 361:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",364);}
case 364:{f.Pc=f.Pop().Int==0?384:367;continue;}
case 367:{f.Push(f.Locals[1]);f.Pc=368;continue;}
case 368:{f.Push(JValue.R(rt.String("ForbiddenNewTypes")));f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",373);}
case 373:{f.Push(JValue.R(rt.String(",")));f.Pc=375;continue;}
case 375:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",378);}
case 378:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",381);}
case 381:{f.Pc=387;continue;}
case 384:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",387);}
case 387:{f.Locals[13]=f.Pop();f.Pc=389;continue;}
case 389:{f.Push(f.Locals[13]);f.Pc=391;continue;}
case 391:{f.Push(f.Locals[8]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",398);}
case 398:{f.StackOp("pop");f.Pc=399;continue;}
case 399:{f.Push(f.Locals[12]);f.Pc=401;continue;}
case 401:{f.Push(JValue.I(1));f.Pc=402;continue;}
case 402:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=403;continue;}
case 403:{f.Push(JValue.R(rt.String("Choose")));f.Pc=405;continue;}
case 405:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",408);}
case 408:{f.Pc=f.Pop().Int==0?498:411;continue;}
case 411:{f.Push(f.Locals[12]);f.Pc=413;continue;}
case 413:{f.Push(JValue.I(1));f.Pc=414;continue;}
case 414:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=415;continue;}
case 415:{f.Push(JValue.R(rt.String("ChooseBasicLandType")));f.Pc=417;continue;}
case 417:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",420);}
case 420:{f.Pc=f.Pop().Int==0?441:423;continue;}
case 423:{f.Push(f.Locals[11]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/card/CardType","getBasicTypes","()Ljava/util/Collection;","invokestatic",428);}
case 428:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",433);}
case 433:{f.StackOp("pop");f.Pc=434;continue;}
case 434:{f.Push(JValue.R(rt.String("basic land")));f.Pc=436;continue;}
case 436:{f.Locals[10]=f.Pop();f.Pc=438;continue;}
case 438:{f.Pc=468;continue;}
case 441:{f.Push(f.Locals[12]);f.Pc=443;continue;}
case 443:{f.Push(JValue.I(1));f.Pc=444;continue;}
case 444:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=445;continue;}
case 445:{f.Push(JValue.R(rt.String("ChooseCreatureType")));f.Pc=447;continue;}
case 447:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",450);}
case 450:{f.Pc=f.Pop().Int==0?468:453;continue;}
case 453:{f.Push(f.Locals[11]);f.Pc=455;continue;}
case 455:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;"));f.Pc=458;continue;}
case 458:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",463);}
case 463:{f.StackOp("pop");f.Pc=464;continue;}
case 464:{f.Push(JValue.R(rt.String("Creature")));f.Pc=466;continue;}
case 466:{f.Locals[10]=f.Pop();f.Pc=468;continue;}
case 468:{f.Push(f.Locals[11]);f.Pc=470;continue;}
case 470:{f.Push(f.Locals[13]);f.Pc=472;continue;}
case 472:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",477);}
case 477:{f.StackOp("pop");f.Pc=478;continue;}
case 478:{f.Push(f.Locals[1]);f.Pc=479;continue;}
case 479:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",482);}
case 482:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",485);}
case 485:{f.Push(f.Locals[10]);f.Pc=487;continue;}
case 487:{f.Push(f.Locals[1]);f.Pc=488;continue;}
case 488:{f.Push(f.Locals[11]);f.Pc=490;continue;}
case 490:{return rt.Call(f,"forge/game/player/PlayerController","chooseSomeType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/Collection;)Ljava/lang/String;","invokevirtual",493);}
case 493:{f.Locals[9]=f.Pop();f.Pc=495;continue;}
case 495:{f.Pc=504;continue;}
case 498:{f.Push(f.Locals[12]);f.Pc=500;continue;}
case 500:{f.Push(JValue.I(1));f.Pc=501;continue;}
case 501:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=502;continue;}
case 502:{f.Locals[9]=f.Pop();f.Pc=504;continue;}
case 504:{f.Pc=513;continue;}
case 507:{f.Push(JValue.R(null));f.Pc=508;continue;}
case 508:{f.Locals[8]=f.Pop();f.Pc=510;continue;}
case 510:{f.Push(JValue.R(null));f.Pc=511;continue;}
case 511:{f.Locals[9]=f.Pop();f.Pc=513;continue;}
case 513:{f.Push(f.Locals[1]);f.Pc=514;continue;}
case 514:{return rt.Call(f,"forge/game/ability/effects/ChangeTextEffect","getCardsfromTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",517);}
case 517:{f.Locals[10]=f.Pop();f.Pc=519;continue;}
case 519:{f.Push(f.Locals[10]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",526);}
case 526:{f.Locals[11]=f.Pop();f.Pc=528;continue;}
case 528:{f.Push(f.Locals[11]);f.Pc=530;continue;}
case 530:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",535);}
case 535:{f.Pc=f.Pop().Int==0?652:538;continue;}
case 538:{f.Push(f.Locals[11]);f.Pc=540;continue;}
case 540:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",545);}
case 545:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=548;continue;}
case 548:{f.Locals[12]=f.Pop();f.Pc=550;continue;}
case 550:{f.Push(f.Locals[6]);f.Pc=552;continue;}
case 552:{f.Pc=f.Pop().Reference==null?572:555;continue;}
case 555:{f.Push(f.Locals[7]);f.Pc=557;continue;}
case 557:{f.Pc=f.Pop().Reference==null?572:560;continue;}
case 560:{f.Push(f.Locals[12]);f.Pc=562;continue;}
case 562:{f.Push(f.Locals[6]);f.Pc=564;continue;}
case 564:{f.Push(f.Locals[7]);f.Pc=566;continue;}
case 566:{f.Push(f.Locals[4]);f.Pc=568;continue;}
case 568:{f.Push(JValue.L(0));f.Pc=569;continue;}
case 569:{return rt.Call(f,"forge/game/card/Card","addChangedTextColorWord","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;J)V","invokevirtual",572);}
case 572:{f.Push(f.Locals[8]);f.Pc=574;continue;}
case 574:{f.Pc=f.Pop().Reference==null?594:577;continue;}
case 577:{f.Push(f.Locals[9]);f.Pc=579;continue;}
case 579:{f.Pc=f.Pop().Reference==null?594:582;continue;}
case 582:{f.Push(f.Locals[12]);f.Pc=584;continue;}
case 584:{f.Push(f.Locals[8]);f.Pc=586;continue;}
case 586:{f.Push(f.Locals[9]);f.Pc=588;continue;}
case 588:{f.Push(f.Locals[4]);f.Pc=590;continue;}
case 590:{f.Push(JValue.L(0));f.Pc=591;continue;}
case 591:{return rt.Call(f,"forge/game/card/Card","addChangedTextTypeWord","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;J)V","invokevirtual",594);}
case 594:{f.Push(f.Locals[5]);f.Pc=596;continue;}
case 596:{f.Pc=f.Pop().Int!=0?626:599;continue;}
case 599:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/ChangeTextEffect$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/ChangeTextEffect$1")));f.Pc=602;continue;}
case 602:{f.StackOp("dup");f.Pc=603;continue;}
case 603:{f.Push(f.Locals[0]);f.Pc=604;continue;}
case 604:{f.Push(f.Locals[7]);f.Pc=606;continue;}
case 606:{f.Push(f.Locals[12]);f.Pc=608;continue;}
case 608:{f.Push(f.Locals[4]);f.Pc=610;continue;}
case 610:{f.Push(f.Locals[9]);f.Pc=612;continue;}
case 612:{return rt.Call(f,"forge/game/ability/effects/ChangeTextEffect$1","<init>","(Lforge/game/ability/effects/ChangeTextEffect;Ljava/lang/String;Lforge/game/card/Card;Ljava/lang/Long;Ljava/lang/String;)V","invokespecial",615);}
case 615:{f.Locals[13]=f.Pop();f.Pc=617;continue;}
case 617:{f.Push(f.Locals[3]);f.Pc=618;continue;}
case 618:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",621);}
case 621:{f.Push(f.Locals[13]);f.Pc=623;continue;}
case 623:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",626);}
case 626:{f.Push(f.Locals[3]);f.Pc=627;continue;}
case 627:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=630;continue;}
case 630:{f.StackOp("dup");f.Pc=631;continue;}
case 631:{f.Push(f.Locals[12]);f.Pc=633;continue;}
case 633:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",636);}
case 636:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",639);}
case 639:{f.Push(f.Locals[12]);f.Pc=641;continue;}
case 641:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",644);}
case 644:{f.Push(f.Locals[12]);f.Pc=646;continue;}
case 646:{return rt.Call(f,"forge/game/card/Card","updateTypesForView","()V","invokevirtual",649);}
case 649:{f.Pc=528;continue;}
case 652:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3092(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ChangeColorWord")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?35:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("ChangeColorWord")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Push(JValue.R(rt.String(" ")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=26;continue;}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=31;continue;}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Pc=39;continue;}
case 35:{f.Push(JValue.R(null));f.Pc=36;continue;}
case 36:{f.Locals[2]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(JValue.R(null));f.Pc=38;continue;}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("ChangeTypeWord")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?76:48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("ChangeTypeWord")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Push(JValue.R(rt.String(" ")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",59);}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=65;continue;}
case 65:{f.Locals[4]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{f.Push(JValue.I(1));f.Pc=70;continue;}
case 70:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=71;continue;}
case 71:{f.Locals[5]=f.Pop();f.Pc=73;continue;}
case 73:{f.Pc=82;continue;}
case 76:{f.Push(JValue.R(null));f.Pc=77;continue;}
case 77:{f.Locals[4]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(JValue.R(null));f.Pc=80;continue;}
case 80:{f.Locals[5]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("Duration")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",90);}
case 90:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",93);}
case 93:{f.Locals[6]=f.Pop();f.Pc=95;continue;}
case 95:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=98;continue;}
case 98:{f.StackOp("dup");f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",102);}
case 102:{f.Locals[7]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("Change the text of ")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/ability/effects/ChangeTextEffect","getCardsfromTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",116);}
case 116:{f.Locals[8]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[8]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",125);}
case 125:{f.Locals[9]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",134);}
case 134:{f.Pc=f.Pop().Int==0?165:137;continue;}
case 137:{f.Push(f.Locals[9]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",144);}
case 144:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=147;continue;}
case 147:{f.Locals[10]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[7]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[10]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",156);}
case 156:{f.Push(JValue.R(rt.String(" ")));f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",161);}
case 161:{f.StackOp("pop");f.Pc=162;continue;}
case 162:{f.Pc=127;continue;}
case 165:{f.Push(f.Locals[2]);f.Pc=166;continue;}
case 166:{f.Pc=f.Pop().Reference==null?282:169;continue;}
case 169:{f.Push(f.Locals[7]);f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String(" by replacing all instances of ")));f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",176);}
case 176:{f.StackOp("pop");f.Pc=177;continue;}
case 177:{f.Push(f.Locals[2]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("Choose")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",183);}
case 183:{f.Pc=f.Pop().Int==0?197:186;continue;}
case 186:{f.Push(f.Locals[7]);f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String("one color word")));f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",193);}
case 193:{f.StackOp("pop");f.Pc=194;continue;}
case 194:{f.Pc=224;continue;}
case 197:{f.Push(f.Locals[2]);f.Pc=198;continue;}
case 198:{f.Push(JValue.R(rt.String("Any")));f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",203);}
case 203:{f.Pc=f.Pop().Int==0?217:206;continue;}
case 206:{f.Push(f.Locals[7]);f.Pc=208;continue;}
case 208:{f.Push(JValue.R(rt.String("each color word")));f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",213);}
case 213:{f.StackOp("pop");f.Pc=214;continue;}
case 214:{f.Pc=224;continue;}
case 217:{f.Push(f.Locals[7]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[2]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",223);}
case 223:{f.StackOp("pop");f.Pc=224;continue;}
case 224:{f.Push(f.Locals[7]);f.Pc=226;continue;}
case 226:{f.Push(JValue.R(rt.String(" with ")));f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",232);}
case 232:{f.StackOp("pop");f.Pc=233;continue;}
case 233:{f.Push(f.Locals[3]);f.Pc=234;continue;}
case 234:{f.Push(JValue.R(rt.String("Choose")));f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",239);}
case 239:{f.Pc=f.Pop().Int==0?275:242;continue;}
case 242:{f.Push(f.Locals[2]);f.Pc=243;continue;}
case 243:{f.Push(JValue.R(rt.String("Choose")));f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",248);}
case 248:{f.Pc=f.Pop().Int==0?263:251;continue;}
case 251:{f.Push(f.Locals[7]);f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.String("another")));f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",259);}
case 259:{f.StackOp("pop");f.Pc=260;continue;}
case 260:{f.Pc=282;continue;}
case 263:{f.Push(f.Locals[7]);f.Pc=265;continue;}
case 265:{f.Push(JValue.R(rt.String("a color word of your choice")));f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",271);}
case 271:{f.StackOp("pop");f.Pc=272;continue;}
case 272:{f.Pc=282;continue;}
case 275:{f.Push(f.Locals[7]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[3]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",281);}
case 281:{f.StackOp("pop");f.Pc=282;continue;}
case 282:{f.Push(f.Locals[4]);f.Pc=284;continue;}
case 284:{f.Pc=f.Pop().Reference==null?452:287;continue;}
case 287:{f.Push(f.Locals[7]);f.Pc=289;continue;}
case 289:{f.Push(JValue.R(rt.String(" by replacing all instances of ")));f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",294);}
case 294:{f.StackOp("pop");f.Pc=295;continue;}
case 295:{f.Push(f.Locals[4]);f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.String("ChooseBasicLandType")));f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",302);}
case 302:{f.Pc=f.Pop().Int==0?317:305;continue;}
case 305:{f.Push(f.Locals[7]);f.Pc=307;continue;}
case 307:{f.Push(JValue.R(rt.String("one basic land type")));f.Pc=310;continue;}
case 310:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",313);}
case 313:{f.StackOp("pop");f.Pc=314;continue;}
case 314:{f.Pc=347;continue;}
case 317:{f.Push(f.Locals[4]);f.Pc=319;continue;}
case 319:{f.Push(JValue.R(rt.String("ChooseCreatureType")));f.Pc=321;continue;}
case 321:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",324);}
case 324:{f.Pc=f.Pop().Int==0?339:327;continue;}
case 327:{f.Push(f.Locals[7]);f.Pc=329;continue;}
case 329:{f.Push(JValue.R(rt.String("one creature type")));f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",335);}
case 335:{f.StackOp("pop");f.Pc=336;continue;}
case 336:{f.Pc=347;continue;}
case 339:{f.Push(f.Locals[7]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[4]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",346);}
case 346:{f.StackOp("pop");f.Pc=347;continue;}
case 347:{f.Push(f.Locals[7]);f.Pc=349;continue;}
case 349:{f.Push(JValue.R(rt.String(" with ")));f.Pc=352;continue;}
case 352:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",355);}
case 355:{f.StackOp("pop");f.Pc=356;continue;}
case 356:{f.Push(f.Locals[5]);f.Pc=358;continue;}
case 358:{f.Push(JValue.R(rt.String("ChooseBasicLandType")));f.Pc=360;continue;}
case 360:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",363);}
case 363:{f.Pc=f.Pop().Int==0?400:366;continue;}
case 366:{f.Push(f.Locals[4]);f.Pc=368;continue;}
case 368:{f.Push(JValue.R(rt.String("ChooseBasicLandType")));f.Pc=370;continue;}
case 370:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",373);}
case 373:{f.Pc=f.Pop().Int==0?388:376;continue;}
case 376:{f.Push(f.Locals[7]);f.Pc=378;continue;}
case 378:{f.Push(JValue.R(rt.String("another")));f.Pc=381;continue;}
case 381:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",384);}
case 384:{f.StackOp("pop");f.Pc=385;continue;}
case 385:{f.Pc=452;continue;}
case 388:{f.Push(f.Locals[7]);f.Pc=390;continue;}
case 390:{f.Push(JValue.R(rt.String("a basic land type of your choice")));f.Pc=393;continue;}
case 393:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",396);}
case 396:{f.StackOp("pop");f.Pc=397;continue;}
case 397:{f.Pc=452;continue;}
case 400:{f.Push(f.Locals[5]);f.Pc=402;continue;}
case 402:{f.Push(JValue.R(rt.String("ChooseCreatureType")));f.Pc=404;continue;}
case 404:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",407);}
case 407:{f.Pc=f.Pop().Int==0?444:410;continue;}
case 410:{f.Push(f.Locals[4]);f.Pc=412;continue;}
case 412:{f.Push(JValue.R(rt.String("ChooseCreatureType")));f.Pc=414;continue;}
case 414:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",417);}
case 417:{f.Pc=f.Pop().Int==0?432:420;continue;}
case 420:{f.Push(f.Locals[7]);f.Pc=422;continue;}
case 422:{f.Push(JValue.R(rt.String("another")));f.Pc=425;continue;}
case 425:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",428);}
case 428:{f.StackOp("pop");f.Pc=429;continue;}
case 429:{f.Pc=452;continue;}
case 432:{f.Push(f.Locals[7]);f.Pc=434;continue;}
case 434:{f.Push(JValue.R(rt.String("a creature type of your choice")));f.Pc=437;continue;}
case 437:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",440);}
case 440:{f.StackOp("pop");f.Pc=441;continue;}
case 441:{f.Pc=452;continue;}
case 444:{f.Push(f.Locals[7]);f.Pc=446;continue;}
case 446:{f.Push(f.Locals[5]);f.Pc=448;continue;}
case 448:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",451);}
case 451:{f.StackOp("pop");f.Pc=452;continue;}
case 452:{f.Push(f.Locals[6]);f.Pc=454;continue;}
case 454:{f.Pc=f.Pop().Int!=0?466:457;continue;}
case 457:{f.Push(f.Locals[7]);f.Pc=459;continue;}
case 459:{f.Push(JValue.R(rt.String(" until end of turn")));f.Pc=462;continue;}
case 462:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",465);}
case 465:{f.StackOp("pop");f.Pc=466;continue;}
case 466:{f.Push(f.Locals[7]);f.Pc=468;continue;}
case 468:{f.Push(JValue.I(46));f.Pc=470;continue;}
case 470:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",473);}
case 473:{f.StackOp("pop");f.Pc=474;continue;}
case 474:{f.Push(f.Locals[1]);f.Pc=475;continue;}
case 475:{f.Push(JValue.R(rt.String("ForbiddenNewTypes")));f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",480);}
case 480:{f.Pc=f.Pop().Int==0?512:483;continue;}
case 483:{f.Push(f.Locals[7]);f.Pc=485;continue;}
case 485:{f.Push(JValue.R(rt.String(" The new creature type can't be ")));f.Pc=488;continue;}
case 488:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",491);}
case 491:{f.StackOp("pop");f.Pc=492;continue;}
case 492:{f.Push(f.Locals[7]);f.Pc=494;continue;}
case 494:{f.Push(f.Locals[1]);f.Pc=495;continue;}
case 495:{f.Push(JValue.R(rt.String("ForbiddenNewTypes")));f.Pc=497;continue;}
case 497:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",500);}
case 500:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",503);}
case 503:{f.StackOp("pop");f.Pc=504;continue;}
case 504:{f.Push(f.Locals[7]);f.Pc=506;continue;}
case 506:{f.Push(JValue.I(46));f.Pc=508;continue;}
case 508:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",511);}
case 511:{f.StackOp("pop");f.Pc=512;continue;}
case 512:{f.Push(f.Locals[6]);f.Pc=514;continue;}
case 514:{f.Pc=f.Pop().Int==0?526:517;continue;}
case 517:{f.Push(f.Locals[7]);f.Pc=519;continue;}
case 519:{f.Push(JValue.R(rt.String(" (This effect lasts indefinitely.)")));f.Pc=522;continue;}
case 522:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",525);}
case 525:{f.StackOp("pop");f.Pc=526;continue;}
case 526:{f.Push(f.Locals[7]);f.Pc=528;continue;}
case 528:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",531);}
case 531:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

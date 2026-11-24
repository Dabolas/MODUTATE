// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C718{
internal static JClass Build(){var c=new JClass("forge/game/player/PlayerProperty","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(8667,"forge/game/player/PlayerProperty","<init>","()V",1,1,1,new JHandler[]{},M8667));
c.Add(new JMethod(8668,"forge/game/player/PlayerProperty","playerHasProperty","(Lforge/game/player/Player;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z",9,14,9,new JHandler[]{},M8668));
c.Add(new JMethod(8669,"forge/game/player/PlayerProperty","comparedPlayer","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/player/Player;",10,4,3,new JHandler[]{},M8669));
}

internal static JStep M8667(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8668(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("Activator")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?32:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?3724:30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("You")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?51:41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int!=0?3724:49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Opponent")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?78:60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int!=0?76:68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int!=0?3724:76;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("OpponentOf ")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?164:87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String(" ")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",93);}
case 93:{f.Push(JValue.I(1));f.Pc=94;continue;}
case 94:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=95;continue;}
case 95:{f.Locals[6]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[6]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",105);}
case 105:{f.Locals[7]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[7]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",114);}
case 114:{f.Locals[8]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[8]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",123);}
case 123:{f.Pc=f.Pop().Int==0?161:126;continue;}
case 126:{f.Push(f.Locals[8]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{f.Locals[9]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[9]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int!=0?156:147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[9]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int!=0?158:156;continue;}
case 156:{f.Push(JValue.I(0));f.Pc=157;continue;}
case 157:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 158:{f.Pc=116;continue;}
case 161:{f.Pc=3724;continue;}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("PlayerUID_")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",170);}
case 170:{f.Pc=f.Pop().Int==0?193:173;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/player/Player","getId","()I","invokevirtual",177);}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("PlayerUID_")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",183);}
case 183:{f.Push(JValue.I(1));f.Pc=184;continue;}
case 184:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",188);}
case 188:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?3724:191;continue;}
case 191:{f.Push(JValue.I(0));f.Pc=192;continue;}
case 192:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 193:{f.Push(f.Locals[1]);f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("YourTeam")));f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",199);}
case 199:{f.Pc=f.Pop().Int==0?212:202;continue;}
case 202:{f.Push(f.Locals[0]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[2]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/player/Player","sameTeam","(Lforge/game/player/Player;)Z","invokevirtual",207);}
case 207:{f.Pc=f.Pop().Int!=0?3724:210;continue;}
case 210:{f.Push(JValue.I(0));f.Pc=211;continue;}
case 211:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 212:{f.Push(f.Locals[1]);f.Pc=213;continue;}
case 213:{f.Push(JValue.R(rt.String("Allies")));f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",218);}
case 218:{f.Pc=f.Pop().Int==0?239:221;continue;}
case 221:{f.Push(f.Locals[0]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[2]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",226);}
case 226:{f.Pc=f.Pop().Int!=0?237:229;continue;}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[2]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",234);}
case 234:{f.Pc=f.Pop().Int==0?3724:237;continue;}
case 237:{f.Push(JValue.I(0));f.Pc=238;continue;}
case 238:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 239:{f.Push(f.Locals[1]);f.Pc=240;continue;}
case 240:{f.Push(JValue.R(rt.String("Active")));f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",245);}
case 245:{f.Pc=f.Pop().Int==0?262:248;continue;}
case 248:{f.Push(f.Locals[5]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",253);}
case 253:{f.Push(f.Locals[0]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Int!=0?3724:260;continue;}
case 260:{f.Push(JValue.I(0));f.Pc=261;continue;}
case 261:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 262:{f.Push(f.Locals[1]);f.Pc=263;continue;}
case 263:{f.Push(JValue.R(rt.String("Other")));f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",268);}
case 268:{f.Pc=f.Pop().Int==0?281:271;continue;}
case 271:{f.Push(f.Locals[0]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[2]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",276);}
case 276:{f.Pc=f.Pop().Int==0?3724:279;continue;}
case 279:{f.Push(JValue.I(0));f.Pc=280;continue;}
case 280:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 281:{f.Push(f.Locals[1]);f.Pc=282;continue;}
case 282:{f.Push(JValue.R(rt.String("CardOwner")));f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",287);}
case 287:{f.Pc=f.Pop().Int==0?303:290;continue;}
case 290:{f.Push(f.Locals[0]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[3]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",295);}
case 295:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",298);}
case 298:{f.Pc=f.Pop().Int!=0?3724:301;continue;}
case 301:{f.Push(JValue.I(0));f.Pc=302;continue;}
case 302:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{f.Push(JValue.R(rt.String("descended")));f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",309);}
case 309:{f.Pc=f.Pop().Int==0?322:312;continue;}
case 312:{f.Push(f.Locals[0]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/player/Player","getDescended","()I","invokevirtual",316);}
case 316:{f.Push(JValue.I(1));f.Pc=317;continue;}
case 317:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?3724:320;continue;}
case 320:{f.Push(JValue.I(0));f.Pc=321;continue;}
case 321:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 322:{f.Push(f.Locals[1]);f.Pc=323;continue;}
case 323:{f.Push(JValue.R(rt.String("committedCrimeThisTurn")));f.Pc=325;continue;}
case 325:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",328);}
case 328:{f.Pc=f.Pop().Int==0?341:331;continue;}
case 331:{f.Push(f.Locals[0]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/player/Player","getCommittedCrimeThisTurn","()I","invokevirtual",335);}
case 335:{f.Push(JValue.I(1));f.Pc=336;continue;}
case 336:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?3724:339;continue;}
case 339:{f.Push(JValue.I(0));f.Pc=340;continue;}
case 340:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 341:{f.Push(f.Locals[1]);f.Pc=342;continue;}
case 342:{f.Push(JValue.R(rt.String("isMonarch")));f.Pc=344;continue;}
case 344:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",347);}
case 347:{f.Pc=f.Pop().Int==0?359:350;continue;}
case 350:{f.Push(f.Locals[0]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/player/Player","isMonarch","()Z","invokevirtual",354);}
case 354:{f.Pc=f.Pop().Int!=0?3724:357;continue;}
case 357:{f.Push(JValue.I(0));f.Pc=358;continue;}
case 358:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 359:{f.Push(f.Locals[1]);f.Pc=360;continue;}
case 360:{f.Push(JValue.R(rt.String("hasInitiative")));f.Pc=362;continue;}
case 362:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",365);}
case 365:{f.Pc=f.Pop().Int==0?377:368;continue;}
case 368:{f.Push(f.Locals[0]);f.Pc=369;continue;}
case 369:{return rt.Call(f,"forge/game/player/Player","hasInitiative","()Z","invokevirtual",372);}
case 372:{f.Pc=f.Pop().Int!=0?3724:375;continue;}
case 375:{f.Push(JValue.I(0));f.Pc=376;continue;}
case 376:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 377:{f.Push(f.Locals[1]);f.Pc=378;continue;}
case 378:{f.Push(JValue.R(rt.String("hasBlessing")));f.Pc=380;continue;}
case 380:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",383);}
case 383:{f.Pc=f.Pop().Int==0?395:386;continue;}
case 386:{f.Push(f.Locals[0]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/player/Player","hasBlessing","()Z","invokevirtual",390);}
case 390:{f.Pc=f.Pop().Int!=0?3724:393;continue;}
case 393:{f.Push(JValue.I(0));f.Pc=394;continue;}
case 394:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 395:{f.Push(f.Locals[1]);f.Pc=396;continue;}
case 396:{f.Push(JValue.R(rt.String("hasEnduringStory")));f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",401);}
case 401:{f.Pc=f.Pop().Int==0?413:404;continue;}
case 404:{f.Push(f.Locals[0]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/player/Player","hasEnduringStory","()Z","invokevirtual",408);}
case 408:{f.Pc=f.Pop().Int!=0?3724:411;continue;}
case 411:{f.Push(JValue.I(0));f.Pc=412;continue;}
case 412:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 413:{f.Push(f.Locals[1]);f.Pc=414;continue;}
case 414:{f.Push(JValue.R(rt.String("CanBeEnchantedBy")));f.Pc=416;continue;}
case 416:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",419);}
case 419:{f.Pc=f.Pop().Int==0?433:422;continue;}
case 422:{f.Push(f.Locals[0]);f.Pc=423;continue;}
case 423:{f.Push(f.Locals[3]);f.Pc=424;continue;}
case 424:{f.Push(JValue.R(null));f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/game/player/Player","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",428);}
case 428:{f.Pc=f.Pop().Int!=0?3724:431;continue;}
case 431:{f.Push(JValue.I(0));f.Pc=432;continue;}
case 432:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 433:{f.Push(f.Locals[1]);f.Pc=434;continue;}
case 434:{f.Push(JValue.R(rt.String("damageDoneSingleSource")));f.Pc=436;continue;}
case 436:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",439);}
case 439:{f.Pc=f.Pop().Int==0?527:442;continue;}
case 442:{f.Push(f.Locals[1]);f.Pc=443;continue;}
case 443:{f.Push(JValue.R(rt.String(" ")));f.Pc=445;continue;}
case 445:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",448);}
case 448:{f.Push(JValue.I(1));f.Pc=449;continue;}
case 449:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=450;continue;}
case 450:{f.Locals[6]=f.Pop();f.Pc=452;continue;}
case 452:{f.Push(f.Locals[5]);f.Pc=454;continue;}
case 454:{f.Push(JValue.R(null));f.Pc=455;continue;}
case 455:{f.Push(JValue.I(0));f.Pc=456;continue;}
case 456:{f.Push(JValue.R(rt.String("Card.YouCtrl")));f.Pc=458;continue;}
case 458:{f.Push(JValue.R(null));f.Pc=459;continue;}
case 459:{f.Push(f.Locals[3]);f.Pc=460;continue;}
case 460:{f.Push(f.Locals[2]);f.Pc=461;continue;}
case 461:{f.Push(f.Locals[4]);f.Pc=463;continue;}
case 463:{return rt.Call(f,"forge/game/Game","getDamageDoneThisTurn","(Ljava/lang/Boolean;ZLjava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/CardTraitBase;)Ljava/util/List;","invokevirtual",466);}
case 466:{f.Locals[7]=f.Pop();f.Pc=468;continue;}
case 468:{f.Push(f.Locals[7]);f.Pc=470;continue;}
case 470:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",475);}
case 475:{f.Pc=f.Pop().Int==0?482:478;continue;}
case 478:{f.Push(JValue.I(0));f.Pc=479;continue;}
case 479:{f.Pc=493;continue;}
case 482:{f.Push(f.Locals[7]);f.Pc=484;continue;}
case 484:{return rt.Call(f,"java/util/Collections","max","(Ljava/util/Collection;)Ljava/lang/Object;","invokestatic",487);}
case 487:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=490;continue;}
case 490:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",493);}
case 493:{f.Locals[8]=f.Pop();f.Pc=495;continue;}
case 495:{f.Push(f.Locals[8]);f.Pc=497;continue;}
case 497:{f.Push(f.Locals[6]);f.Pc=499;continue;}
case 499:{f.Push(JValue.I(0));f.Pc=500;continue;}
case 500:{f.Push(JValue.I(2));f.Pc=501;continue;}
case 501:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",504);}
case 504:{f.Push(f.Locals[3]);f.Pc=505;continue;}
case 505:{f.Push(f.Locals[6]);f.Pc=507;continue;}
case 507:{f.Push(JValue.I(2));f.Pc=508;continue;}
case 508:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",511);}
case 511:{f.Push(f.Locals[4]);f.Pc=513;continue;}
case 513:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",516);}
case 516:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",519);}
case 519:{f.Pc=f.Pop().Int!=0?524:522;continue;}
case 522:{f.Push(JValue.I(0));f.Pc=523;continue;}
case 523:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 524:{f.Pc=3724;continue;}
case 527:{f.Push(f.Locals[1]);f.Pc=528;continue;}
case 528:{f.Push(JValue.R(rt.String("wasDealtCombatDamageThisCombatBy ")));f.Pc=530;continue;}
case 530:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",533);}
case 533:{f.Pc=f.Pop().Int==0?626:536;continue;}
case 536:{f.Push(f.Locals[1]);f.Pc=537;continue;}
case 537:{f.Push(JValue.R(rt.String(" ")));f.Pc=539;continue;}
case 539:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",542);}
case 542:{f.Push(JValue.I(1));f.Pc=543;continue;}
case 543:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=544;continue;}
case 544:{f.Locals[6]=f.Pop();f.Pc=546;continue;}
case 546:{f.Push(JValue.I(0));f.Pc=547;continue;}
case 547:{f.Locals[7]=f.Pop();f.Pc=549;continue;}
case 549:{f.Push(f.Locals[3]);f.Pc=550;continue;}
case 550:{f.Push(f.Locals[6]);f.Pc=552;continue;}
case 552:{f.Push(f.Locals[4]);f.Pc=554;continue;}
case 554:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",557);}
case 557:{f.Locals[8]=f.Pop();f.Pc=559;continue;}
case 559:{f.Push(f.Locals[8]);f.Pc=561;continue;}
case 561:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",566);}
case 566:{f.Locals[9]=f.Pop();f.Pc=568;continue;}
case 568:{f.Push(f.Locals[9]);f.Pc=570;continue;}
case 570:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",575);}
case 575:{f.Pc=f.Pop().Int==0?616:578;continue;}
case 578:{f.Push(f.Locals[9]);f.Pc=580;continue;}
case 580:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",585);}
case 585:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=588;continue;}
case 588:{f.Locals[10]=f.Pop();f.Pc=590;continue;}
case 590:{f.Push(f.Locals[10]);f.Pc=592;continue;}
case 592:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",595);}
case 595:{return rt.Call(f,"forge/game/card/CardDamageHistory","getThisCombatDamaged","()Ljava/util/List;","invokevirtual",598);}
case 598:{f.Push(f.Locals[0]);f.Pc=599;continue;}
case 599:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",604);}
case 604:{f.Pc=f.Pop().Int==0?613:607;continue;}
case 607:{f.Push(JValue.I(1));f.Pc=608;continue;}
case 608:{f.Locals[7]=f.Pop();f.Pc=610;continue;}
case 610:{f.Pc=616;continue;}
case 613:{f.Pc=568;continue;}
case 616:{f.Push(f.Locals[7]);f.Pc=618;continue;}
case 618:{f.Pc=f.Pop().Int!=0?623:621;continue;}
case 621:{f.Push(JValue.I(0));f.Pc=622;continue;}
case 622:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 623:{f.Pc=3724;continue;}
case 626:{f.Push(f.Locals[1]);f.Pc=627;continue;}
case 627:{f.Push(JValue.R(rt.String("wasDealtDamageThisGameBy ")));f.Pc=629;continue;}
case 629:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",632);}
case 632:{f.Pc=f.Pop().Int==0?723:635;continue;}
case 635:{f.Push(f.Locals[1]);f.Pc=636;continue;}
case 636:{f.Push(JValue.R(rt.String(" ")));f.Pc=638;continue;}
case 638:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",641);}
case 641:{f.Push(JValue.I(1));f.Pc=642;continue;}
case 642:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=643;continue;}
case 643:{f.Locals[6]=f.Pop();f.Pc=645;continue;}
case 645:{f.Push(JValue.I(0));f.Pc=646;continue;}
case 646:{f.Locals[7]=f.Pop();f.Pc=648;continue;}
case 648:{f.Push(f.Locals[3]);f.Pc=649;continue;}
case 649:{f.Push(f.Locals[6]);f.Pc=651;continue;}
case 651:{f.Push(f.Locals[4]);f.Pc=653;continue;}
case 653:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",656);}
case 656:{f.Locals[8]=f.Pop();f.Pc=658;continue;}
case 658:{f.Push(f.Locals[8]);f.Pc=660;continue;}
case 660:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",665);}
case 665:{f.Locals[9]=f.Pop();f.Pc=667;continue;}
case 667:{f.Push(f.Locals[9]);f.Pc=669;continue;}
case 669:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",674);}
case 674:{f.Pc=f.Pop().Int==0?713:677;continue;}
case 677:{f.Push(f.Locals[9]);f.Pc=679;continue;}
case 679:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",684);}
case 684:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=687;continue;}
case 687:{f.Locals[10]=f.Pop();f.Pc=689;continue;}
case 689:{f.Push(f.Locals[10]);f.Pc=691;continue;}
case 691:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",694);}
case 694:{return rt.Call(f,"forge/game/card/CardDamageHistory","getThisGameDamaged","()Lforge/util/collect/FCollection;","invokevirtual",697);}
case 697:{f.Push(f.Locals[0]);f.Pc=698;continue;}
case 698:{return rt.Call(f,"forge/util/collect/FCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",701);}
case 701:{f.Pc=f.Pop().Int==0?710:704;continue;}
case 704:{f.Push(JValue.I(1));f.Pc=705;continue;}
case 705:{f.Locals[7]=f.Pop();f.Pc=707;continue;}
case 707:{f.Pc=713;continue;}
case 710:{f.Pc=667;continue;}
case 713:{f.Push(f.Locals[7]);f.Pc=715;continue;}
case 715:{f.Pc=f.Pop().Int!=0?720:718;continue;}
case 718:{f.Push(JValue.I(0));f.Pc=719;continue;}
case 719:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 720:{f.Pc=3724;continue;}
case 723:{f.Push(f.Locals[1]);f.Pc=724;continue;}
case 724:{f.Push(JValue.R(rt.String("wasDealt")));f.Pc=726;continue;}
case 726:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",729);}
case 729:{f.Pc=f.Pop().Int==0?959:732;continue;}
case 732:{f.Push(JValue.R(null));f.Pc=733;continue;}
case 733:{f.Locals[6]=f.Pop();f.Pc=735;continue;}
case 735:{f.Push(f.Locals[1]);f.Pc=736;continue;}
case 736:{f.Push(JValue.R(rt.String("CombatDamage")));f.Pc=738;continue;}
case 738:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",741);}
case 741:{f.Pc=f.Pop().Int==0?763:744;continue;}
case 744:{f.Push(f.Locals[1]);f.Pc=745;continue;}
case 745:{f.Push(JValue.R(rt.String("NonCombat")));f.Pc=747;continue;}
case 747:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",750);}
case 750:{f.Pc=f.Pop().Int!=0?757:753;continue;}
case 753:{f.Push(JValue.I(1));f.Pc=754;continue;}
case 754:{f.Pc=758;continue;}
case 757:{f.Push(JValue.I(0));f.Pc=758;continue;}
case 758:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",761);}
case 761:{f.Locals[6]=f.Pop();f.Pc=763;continue;}
case 763:{f.Push(JValue.R(null));f.Pc=764;continue;}
case 764:{f.Locals[7]=f.Pop();f.Pc=766;continue;}
case 766:{f.Push(JValue.R(rt.String("GE")));f.Pc=768;continue;}
case 768:{f.Locals[8]=f.Pop();f.Pc=770;continue;}
case 770:{f.Push(JValue.I(1));f.Pc=771;continue;}
case 771:{f.Locals[9]=f.Pop();f.Pc=773;continue;}
case 773:{f.Push(f.Locals[1]);f.Pc=774;continue;}
case 774:{f.Push(JValue.R(rt.String("ThisTurnBy")));f.Pc=776;continue;}
case 776:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",779);}
case 779:{f.Pc=f.Pop().Int==0?851:782;continue;}
case 782:{f.Push(JValue.I(2));f.Pc=783;continue;}
case 783:{f.Locals[10]=f.Pop();f.Pc=785;continue;}
case 785:{f.Push(f.Locals[1]);f.Pc=786;continue;}
case 786:{f.Push(JValue.R(rt.String(" ")));f.Pc=788;continue;}
case 788:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",791);}
case 791:{f.Locals[11]=f.Pop();f.Pc=793;continue;}
case 793:{f.Push(f.Locals[1]);f.Pc=794;continue;}
case 794:{f.Push(JValue.R(rt.String("BySource")));f.Pc=796;continue;}
case 796:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",799);}
case 799:{f.Pc=f.Pop().Int==0?808:802;continue;}
case 802:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(-1)));f.Pc=805;continue;}
case 805:{f.Pc=814;continue;}
case 808:{f.Push(f.Locals[11]);f.Pc=810;continue;}
case 810:{f.Push(JValue.I(1));f.Pc=811;continue;}
case 811:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=812;continue;}
case 812:{f.Locals[7]=f.Pop();f.Pc=814;continue;}
case 814:{f.Push(f.Locals[11]);f.Pc=816;continue;}
case 816:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=817;continue;}
case 817:{f.Push(f.Locals[10]);f.Pc=819;continue;}
case 819:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?851:822;continue;}
case 822:{f.Push(f.Locals[11]);f.Pc=824;continue;}
case 824:{f.Push(f.Locals[10]);f.Pc=826;continue;}
case 826:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=827;continue;}
case 827:{f.Push(JValue.I(0));f.Pc=828;continue;}
case 828:{f.Push(JValue.I(2));f.Pc=829;continue;}
case 829:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",832);}
case 832:{f.Locals[8]=f.Pop();f.Pc=834;continue;}
case 834:{f.Push(f.Locals[3]);f.Pc=835;continue;}
case 835:{f.Push(f.Locals[11]);f.Pc=837;continue;}
case 837:{f.Push(f.Locals[10]);f.Pc=839;continue;}
case 839:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=840;continue;}
case 840:{f.Push(JValue.I(2));f.Pc=841;continue;}
case 841:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",844);}
case 844:{f.Push(f.Locals[4]);f.Pc=846;continue;}
case 846:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",849);}
case 849:{f.Locals[9]=f.Pop();f.Pc=851;continue;}
case 851:{f.Push(f.Locals[1]);f.Pc=852;continue;}
case 852:{f.Push(JValue.R(rt.String("LastTurn")));f.Pc=854;continue;}
case 854:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",857);}
case 857:{f.Pc=f.Pop().Int==0?873:860;continue;}
case 860:{f.Push(f.Locals[0]);f.Pc=861;continue;}
case 861:{f.Push(f.Locals[6]);f.Pc=863;continue;}
case 863:{f.Push(JValue.R(null));f.Pc=864;continue;}
case 864:{f.Push(JValue.I(1));f.Pc=865;continue;}
case 865:{return rt.Call(f,"forge/game/player/Player","getAssignedDamage","(Ljava/lang/Boolean;Lforge/game/card/Card;Z)I","invokevirtual",868);}
case 868:{f.Locals[10]=f.Pop();f.Pc=870;continue;}
case 870:{f.Pc=942;continue;}
case 873:{f.Push(f.Locals[1]);f.Pc=874;continue;}
case 874:{f.Push(JValue.R(rt.String("BySource")));f.Pc=876;continue;}
case 876:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",879);}
case 879:{f.Pc=f.Pop().Int==0?910:882;continue;}
case 882:{f.Push(f.Locals[3]);f.Pc=883;continue;}
case 883:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",886);}
case 886:{f.Push(f.Locals[6]);f.Pc=888;continue;}
case 888:{f.Push(JValue.I(0));f.Pc=889;continue;}
case 889:{f.Push(f.Locals[1]);f.Pc=890;continue;}
case 890:{f.Push(JValue.R(rt.String("SourceTimes")));f.Pc=892;continue;}
case 892:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",895);}
case 895:{f.Push(JValue.R(null));f.Pc=896;continue;}
case 896:{f.Push(JValue.R(rt.String("You")));f.Pc=898;continue;}
case 898:{f.Push(f.Locals[3]);f.Pc=899;continue;}
case 899:{f.Push(f.Locals[0]);f.Pc=900;continue;}
case 900:{f.Push(f.Locals[4]);f.Pc=902;continue;}
case 902:{return rt.Call(f,"forge/game/card/CardDamageHistory","getDamageDoneThisTurn","(Ljava/lang/Boolean;ZZLjava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/CardTraitBase;)I","invokevirtual",905);}
case 905:{f.Locals[10]=f.Pop();f.Pc=907;continue;}
case 907:{f.Pc=942;continue;}
case 910:{f.Push(f.Locals[5]);f.Pc=912;continue;}
case 912:{f.Push(f.Locals[6]);f.Pc=914;continue;}
case 914:{f.Push(f.Locals[7]);f.Pc=916;continue;}
case 916:{f.Pc=f.Pop().Reference!=null?923:919;continue;}
case 919:{f.Push(JValue.I(1));f.Pc=920;continue;}
case 920:{f.Pc=924;continue;}
case 923:{f.Push(JValue.I(0));f.Pc=924;continue;}
case 924:{f.Push(f.Locals[7]);f.Pc=926;continue;}
case 926:{f.Push(JValue.R(rt.String("You")));f.Pc=928;continue;}
case 928:{f.Push(f.Locals[3]);f.Pc=929;continue;}
case 929:{f.Push(f.Locals[0]);f.Pc=930;continue;}
case 930:{f.Push(f.Locals[4]);f.Pc=932;continue;}
case 932:{return rt.Call(f,"forge/game/Game","getDamageDoneThisTurn","(Ljava/lang/Boolean;ZLjava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/CardTraitBase;)Ljava/util/List;","invokevirtual",935);}
case 935:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",940);}
case 940:{f.Locals[10]=f.Pop();f.Pc=942;continue;}
case 942:{f.Push(f.Locals[10]);f.Pc=944;continue;}
case 944:{f.Push(f.Locals[8]);f.Pc=946;continue;}
case 946:{f.Push(f.Locals[9]);f.Pc=948;continue;}
case 948:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",951);}
case 951:{f.Pc=f.Pop().Int!=0?956:954;continue;}
case 954:{f.Push(JValue.I(0));f.Pc=955;continue;}
case 955:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 956:{f.Pc=3724;continue;}
case 959:{f.Push(f.Locals[1]);f.Pc=960;continue;}
case 960:{f.Push(JValue.R(rt.String("attackedBySourceThisCombat")));f.Pc=962;continue;}
case 962:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",965);}
case 965:{f.Pc=f.Pop().Int==0?994:968;continue;}
case 968:{f.Push(f.Locals[5]);f.Pc=970;continue;}
case 970:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",973);}
case 973:{f.Pc=f.Pop().Reference==null?992:976;continue;}
case 976:{f.Push(f.Locals[0]);f.Pc=977;continue;}
case 977:{f.Push(f.Locals[5]);f.Pc=979;continue;}
case 979:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",982);}
case 982:{f.Push(f.Locals[3]);f.Pc=983;continue;}
case 983:{return rt.Call(f,"forge/game/combat/Combat","getDefenderPlayerByAttacker","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",986);}
case 986:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",989);}
case 989:{f.Pc=f.Pop().Int!=0?3724:992;continue;}
case 992:{f.Push(JValue.I(0));f.Pc=993;continue;}
case 993:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 994:{f.Push(f.Locals[1]);f.Pc=995;continue;}
case 995:{f.Push(JValue.R(rt.String("attackedBySourceThisTurn")));f.Pc=998;continue;}
case 998:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1001);}
case 1001:{f.Pc=f.Pop().Int==0?1017:1004;continue;}
case 1004:{f.Push(f.Locals[3]);f.Pc=1005;continue;}
case 1005:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",1008);}
case 1008:{f.Push(f.Locals[0]);f.Pc=1009;continue;}
case 1009:{return rt.Call(f,"forge/game/card/CardDamageHistory","hasAttackedThisTurn","(Lforge/game/GameEntity;)Z","invokevirtual",1012);}
case 1012:{f.Pc=f.Pop().Int!=0?3724:1015;continue;}
case 1015:{f.Push(JValue.I(0));f.Pc=1016;continue;}
case 1016:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1017:{f.Push(f.Locals[1]);f.Pc=1018;continue;}
case 1018:{f.Push(JValue.R(rt.String("Attacking")));f.Pc=1021;continue;}
case 1021:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1024);}
case 1024:{f.Pc=f.Pop().Int==0?1052:1027;continue;}
case 1027:{f.Push(f.Locals[5]);f.Pc=1029;continue;}
case 1029:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1032);}
case 1032:{f.Pc=f.Pop().Reference==null?1050:1035;continue;}
case 1035:{f.Push(f.Locals[0]);f.Pc=1036;continue;}
case 1036:{f.Push(f.Locals[5]);f.Pc=1038;continue;}
case 1038:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1041);}
case 1041:{return rt.Call(f,"forge/game/combat/Combat","getAttackingPlayer","()Lforge/game/player/Player;","invokevirtual",1044);}
case 1044:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1047);}
case 1047:{f.Pc=f.Pop().Int!=0?3724:1050;continue;}
case 1050:{f.Push(JValue.I(0));f.Pc=1051;continue;}
case 1051:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1052:{f.Push(f.Locals[1]);f.Pc=1053;continue;}
case 1053:{f.Push(JValue.R(rt.String("Defending")));f.Pc=1056;continue;}
case 1056:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1059);}
case 1059:{f.Pc=f.Pop().Int==0?1094:1062;continue;}
case 1062:{f.Push(f.Locals[5]);f.Pc=1064;continue;}
case 1064:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1067);}
case 1067:{f.Pc=f.Pop().Reference==null?1092:1070;continue;}
case 1070:{f.Push(f.Locals[5]);f.Pc=1072;continue;}
case 1072:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1075);}
case 1075:{return rt.Call(f,"forge/game/combat/Combat","getAttackersAndDefenders","()Ljava/util/Map;","invokevirtual",1078);}
case 1078:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",1083);}
case 1083:{f.Push(f.Locals[0]);f.Pc=1084;continue;}
case 1084:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",1089);}
case 1089:{f.Pc=f.Pop().Int!=0?3724:1092;continue;}
case 1092:{f.Push(JValue.I(0));f.Pc=1093;continue;}
case 1093:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1094:{f.Push(f.Locals[1]);f.Pc=1095;continue;}
case 1095:{f.Push(JValue.R(rt.String("LostLifeThisTurn")));f.Pc=1098;continue;}
case 1098:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1101);}
case 1101:{f.Pc=f.Pop().Int==0?1177:1104;continue;}
case 1104:{f.Push(JValue.R(rt.String("GE")));f.Pc=1106;continue;}
case 1106:{f.Locals[6]=f.Pop();f.Pc=1108;continue;}
case 1108:{f.Push(JValue.I(1));f.Pc=1109;continue;}
case 1109:{f.Locals[7]=f.Pop();f.Pc=1111;continue;}
case 1111:{f.Push(f.Locals[1]);f.Pc=1112;continue;}
case 1112:{f.Push(JValue.R(rt.String("LostLifeThisTurn")));f.Pc=1115;continue;}
case 1115:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1118);}
case 1118:{f.Pc=f.Pop().Int!=0?1158:1121;continue;}
case 1121:{f.Push(f.Locals[1]);f.Pc=1122;continue;}
case 1122:{f.Push(JValue.R(rt.String(" ")));f.Pc=1124;continue;}
case 1124:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1127);}
case 1127:{f.Push(JValue.I(1));f.Pc=1128;continue;}
case 1128:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1129;continue;}
case 1129:{f.Locals[8]=f.Pop();f.Pc=1131;continue;}
case 1131:{f.Push(f.Locals[8]);f.Pc=1133;continue;}
case 1133:{f.Push(JValue.I(0));f.Pc=1134;continue;}
case 1134:{f.Push(JValue.I(2));f.Pc=1135;continue;}
case 1135:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",1138);}
case 1138:{f.Locals[6]=f.Pop();f.Pc=1140;continue;}
case 1140:{f.Push(f.Locals[8]);f.Pc=1142;continue;}
case 1142:{f.Push(JValue.I(2));f.Pc=1143;continue;}
case 1143:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1146);}
case 1146:{f.Locals[9]=f.Pop();f.Pc=1148;continue;}
case 1148:{f.Push(f.Locals[3]);f.Pc=1149;continue;}
case 1149:{f.Push(f.Locals[9]);f.Pc=1151;continue;}
case 1151:{f.Push(f.Locals[4]);f.Pc=1153;continue;}
case 1153:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1156);}
case 1156:{f.Locals[7]=f.Pop();f.Pc=1158;continue;}
case 1158:{f.Push(f.Locals[0]);f.Pc=1159;continue;}
case 1159:{return rt.Call(f,"forge/game/player/Player","getLifeLostThisTurn","()I","invokevirtual",1162);}
case 1162:{f.Push(f.Locals[6]);f.Pc=1164;continue;}
case 1164:{f.Push(f.Locals[7]);f.Pc=1166;continue;}
case 1166:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1169);}
case 1169:{f.Pc=f.Pop().Int!=0?1174:1172;continue;}
case 1172:{f.Push(JValue.I(0));f.Pc=1173;continue;}
case 1173:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1174:{f.Pc=3724;continue;}
case 1177:{f.Push(f.Locals[1]);f.Pc=1178;continue;}
case 1178:{f.Push(JValue.R(rt.String("TappedLandForManaThisTurn")));f.Pc=1181;continue;}
case 1181:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1184);}
case 1184:{f.Pc=f.Pop().Int==0?1196:1187;continue;}
case 1187:{f.Push(f.Locals[0]);f.Pc=1188;continue;}
case 1188:{return rt.Call(f,"forge/game/player/Player","hasTappedLandForManaThisTurn","()Z","invokevirtual",1191);}
case 1191:{f.Pc=f.Pop().Int!=0?3724:1194;continue;}
case 1194:{f.Push(JValue.I(0));f.Pc=1195;continue;}
case 1195:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1196:{f.Push(f.Locals[1]);f.Pc=1197;continue;}
case 1197:{f.Push(JValue.R(rt.String("CardsInHandAtBeginningOfTurn")));f.Pc=1200;continue;}
case 1200:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1203);}
case 1203:{f.Pc=f.Pop().Int==0?1215:1206;continue;}
case 1206:{f.Push(f.Locals[0]);f.Pc=1207;continue;}
case 1207:{return rt.Call(f,"forge/game/player/Player","getNumCardsInHandStartedThisTurnWith","()I","invokevirtual",1210);}
case 1210:{f.Pc=f.Pop().Int>0?3724:1213;continue;}
case 1213:{f.Push(JValue.I(0));f.Pc=1214;continue;}
case 1214:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1215:{f.Push(f.Locals[1]);f.Pc=1216;continue;}
case 1216:{f.Push(JValue.R(rt.String("IsRemembered")));f.Pc=1219;continue;}
case 1219:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1222);}
case 1222:{f.Pc=f.Pop().Int==0?1235:1225;continue;}
case 1225:{f.Push(f.Locals[3]);f.Pc=1226;continue;}
case 1226:{f.Push(f.Locals[0]);f.Pc=1227;continue;}
case 1227:{return rt.Call(f,"forge/game/card/Card","isRemembered","(Ljava/lang/Object;)Z","invokevirtual",1230);}
case 1230:{f.Pc=f.Pop().Int!=0?3724:1233;continue;}
case 1233:{f.Push(JValue.I(0));f.Pc=1234;continue;}
case 1234:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1235:{f.Push(f.Locals[1]);f.Pc=1236;continue;}
case 1236:{f.Push(JValue.R(rt.String("IsRememberedOrController")));f.Pc=1239;continue;}
case 1239:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1242);}
case 1242:{f.Pc=f.Pop().Int==0?1357:1245;continue;}
case 1245:{f.Push(JValue.I(0));f.Pc=1246;continue;}
case 1246:{f.Locals[6]=f.Pop();f.Pc=1248;continue;}
case 1248:{f.Push(f.Locals[3]);f.Pc=1249;continue;}
case 1249:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",1252);}
case 1252:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",1257);}
case 1257:{f.Locals[7]=f.Pop();f.Pc=1259;continue;}
case 1259:{f.Push(f.Locals[7]);f.Pc=1261;continue;}
case 1261:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1266);}
case 1266:{f.Pc=f.Pop().Int==0?1347:1269;continue;}
case 1269:{f.Push(f.Locals[7]);f.Pc=1271;continue;}
case 1271:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1276);}
case 1276:{f.Locals[8]=f.Pop();f.Pc=1278;continue;}
case 1278:{f.Push(f.Locals[8]);f.Pc=1280;continue;}
case 1280:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=1283;continue;}
case 1283:{f.Pc=f.Pop().Int==0?1311:1286;continue;}
case 1286:{f.Push(f.Locals[8]);f.Pc=1288;continue;}
case 1288:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1291;continue;}
case 1291:{f.Locals[9]=f.Pop();f.Pc=1293;continue;}
case 1293:{f.Push(f.Locals[9]);f.Pc=1295;continue;}
case 1295:{f.Push(f.Locals[0]);f.Pc=1296;continue;}
case 1296:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1299);}
case 1299:{f.Pc=f.Pop().Int==0?1308:1302;continue;}
case 1302:{f.Push(JValue.I(1));f.Pc=1303;continue;}
case 1303:{f.Locals[6]=f.Pop();f.Pc=1305;continue;}
case 1305:{f.Pc=1347;continue;}
case 1308:{f.Pc=1344;continue;}
case 1311:{f.Push(f.Locals[8]);f.Pc=1313;continue;}
case 1313:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1316;continue;}
case 1316:{f.Pc=f.Pop().Int==0?1344:1319;continue;}
case 1319:{f.Push(f.Locals[8]);f.Pc=1321;continue;}
case 1321:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1324;continue;}
case 1324:{f.Locals[9]=f.Pop();f.Pc=1326;continue;}
case 1326:{f.Push(f.Locals[9]);f.Pc=1328;continue;}
case 1328:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1331);}
case 1331:{f.Push(f.Locals[0]);f.Pc=1332;continue;}
case 1332:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1335);}
case 1335:{f.Pc=f.Pop().Int==0?1344:1338;continue;}
case 1338:{f.Push(JValue.I(1));f.Pc=1339;continue;}
case 1339:{f.Locals[6]=f.Pop();f.Pc=1341;continue;}
case 1341:{f.Pc=1347;continue;}
case 1344:{f.Pc=1259;continue;}
case 1347:{f.Push(f.Locals[6]);f.Pc=1349;continue;}
case 1349:{f.Pc=f.Pop().Int!=0?1354:1352;continue;}
case 1352:{f.Push(JValue.I(0));f.Pc=1353;continue;}
case 1353:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1354:{f.Pc=3724;continue;}
case 1357:{f.Push(f.Locals[1]);f.Pc=1358;continue;}
case 1358:{f.Push(JValue.R(rt.String("IsTriggerRemembered")));f.Pc=1361;continue;}
case 1361:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1364);}
case 1364:{f.Pc=f.Pop().Int==0?1444:1367;continue;}
case 1367:{f.Push(JValue.I(0));f.Pc=1368;continue;}
case 1368:{f.Locals[6]=f.Pop();f.Pc=1370;continue;}
case 1370:{f.Push(f.Locals[4]);f.Pc=1372;continue;}
case 1372:{return rt.Call(f,"forge/game/CardTraitBase","getTriggerRemembered","()Ljava/util/List;","invokevirtual",1375);}
case 1375:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1380);}
case 1380:{f.Locals[7]=f.Pop();f.Pc=1382;continue;}
case 1382:{f.Push(f.Locals[7]);f.Pc=1384;continue;}
case 1384:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1389);}
case 1389:{f.Pc=f.Pop().Int==0?1434:1392;continue;}
case 1392:{f.Push(f.Locals[7]);f.Pc=1394;continue;}
case 1394:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1399);}
case 1399:{f.Locals[8]=f.Pop();f.Pc=1401;continue;}
case 1401:{f.Push(f.Locals[8]);f.Pc=1403;continue;}
case 1403:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=1406;continue;}
case 1406:{f.Pc=f.Pop().Int==0?1431:1409;continue;}
case 1409:{f.Push(f.Locals[8]);f.Pc=1411;continue;}
case 1411:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1414;continue;}
case 1414:{f.Locals[9]=f.Pop();f.Pc=1416;continue;}
case 1416:{f.Push(f.Locals[9]);f.Pc=1418;continue;}
case 1418:{f.Push(f.Locals[0]);f.Pc=1419;continue;}
case 1419:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1422);}
case 1422:{f.Pc=f.Pop().Int==0?1431:1425;continue;}
case 1425:{f.Push(JValue.I(1));f.Pc=1426;continue;}
case 1426:{f.Locals[6]=f.Pop();f.Pc=1428;continue;}
case 1428:{f.Pc=1434;continue;}
case 1431:{f.Pc=1382;continue;}
case 1434:{f.Push(f.Locals[6]);f.Pc=1436;continue;}
case 1436:{f.Pc=f.Pop().Int!=0?1441:1439;continue;}
case 1439:{f.Push(JValue.I(0));f.Pc=1440;continue;}
case 1440:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1441:{f.Pc=3724;continue;}
case 1444:{f.Push(f.Locals[1]);f.Pc=1445;continue;}
case 1445:{f.Push(JValue.R(rt.String("EnchantedBy")));f.Pc=1448;continue;}
case 1448:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1451);}
case 1451:{f.Pc=f.Pop().Int==0?1464:1454;continue;}
case 1454:{f.Push(f.Locals[0]);f.Pc=1455;continue;}
case 1455:{f.Push(f.Locals[3]);f.Pc=1456;continue;}
case 1456:{return rt.Call(f,"forge/game/player/Player","isEnchantedBy","(Lforge/game/card/Card;)Z","invokevirtual",1459);}
case 1459:{f.Pc=f.Pop().Int!=0?3724:1462;continue;}
case 1462:{f.Push(JValue.I(0));f.Pc=1463;continue;}
case 1463:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1464:{f.Push(f.Locals[1]);f.Pc=1465;continue;}
case 1465:{f.Push(JValue.R(rt.String("EnchantedController")));f.Pc=1468;continue;}
case 1468:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1471);}
case 1471:{f.Pc=f.Pop().Int==0?1502:1474;continue;}
case 1474:{f.Push(f.Locals[3]);f.Pc=1475;continue;}
case 1475:{return rt.Call(f,"forge/game/card/Card","getEnchantingCard","()Lforge/game/card/Card;","invokevirtual",1478);}
case 1478:{f.Locals[6]=f.Pop();f.Pc=1480;continue;}
case 1480:{f.Push(f.Locals[6]);f.Pc=1482;continue;}
case 1482:{f.Pc=f.Pop().Reference==null?1497:1485;continue;}
case 1485:{f.Push(f.Locals[0]);f.Pc=1486;continue;}
case 1486:{f.Push(f.Locals[6]);f.Pc=1488;continue;}
case 1488:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1491);}
case 1491:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1494);}
case 1494:{f.Pc=f.Pop().Int!=0?1499:1497;continue;}
case 1497:{f.Push(JValue.I(0));f.Pc=1498;continue;}
case 1498:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1499:{f.Pc=3724;continue;}
case 1502:{f.Push(f.Locals[1]);f.Pc=1503;continue;}
case 1503:{f.Push(JValue.R(rt.String("Chosen")));f.Pc=1506;continue;}
case 1506:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1509);}
case 1509:{f.Pc=f.Pop().Int==0?1532:1512;continue;}
case 1512:{f.Push(f.Locals[3]);f.Pc=1513;continue;}
case 1513:{return rt.Call(f,"forge/game/card/Card","getChosenPlayer","()Lforge/game/player/Player;","invokevirtual",1516);}
case 1516:{f.Pc=f.Pop().Reference==null?1530:1519;continue;}
case 1519:{f.Push(f.Locals[3]);f.Pc=1520;continue;}
case 1520:{return rt.Call(f,"forge/game/card/Card","getChosenPlayer","()Lforge/game/player/Player;","invokevirtual",1523);}
case 1523:{f.Push(f.Locals[0]);f.Pc=1524;continue;}
case 1524:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1527);}
case 1527:{f.Pc=f.Pop().Int!=0?3724:1530;continue;}
case 1530:{f.Push(JValue.I(0));f.Pc=1531;continue;}
case 1531:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1532:{f.Push(f.Locals[1]);f.Pc=1533;continue;}
case 1533:{f.Push(JValue.R(rt.String("NotedDefender")));f.Pc=1536;continue;}
case 1536:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1539);}
case 1539:{f.Pc=f.Pop().Int==0?1583:1542;continue;}
case 1542:{f.Push(f.Locals[0]);f.Pc=1543;continue;}
case 1543:{return rt.Call(f,"forge/game/player/Player","getDraftNotes","()Ljava/util/Map;","invokevirtual",1546);}
case 1546:{f.Push(JValue.R(rt.String("Cogwork Tracker")));f.Pc=1549;continue;}
case 1549:{f.Push(JValue.R(rt.String("")));f.Pc=1552;continue;}
case 1552:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1557);}
case 1557:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1560;continue;}
case 1560:{f.Locals[6]=f.Pop();f.Pc=1562;continue;}
case 1562:{f.Push(f.Locals[6]);f.Pc=1564;continue;}
case 1564:{f.Push(JValue.R(rt.String(",")));f.Pc=1567;continue;}
case 1567:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1570);}
case 1570:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",1573);}
case 1573:{f.Push(f.Locals[0]);f.Pc=1574;continue;}
case 1574:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1577);}
case 1577:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1582);}
case 1582:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1583:{f.Push(f.Locals[1]);f.Pc=1584;continue;}
case 1584:{f.Push(JValue.R(rt.String("life")));f.Pc=1587;continue;}
case 1587:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1590);}
case 1590:{f.Pc=f.Pop().Int==0?1629:1593;continue;}
case 1593:{f.Push(f.Locals[0]);f.Pc=1594;continue;}
case 1594:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",1597);}
case 1597:{f.Locals[6]=f.Pop();f.Pc=1599;continue;}
case 1599:{f.Push(f.Locals[3]);f.Pc=1600;continue;}
case 1600:{f.Push(f.Locals[1]);f.Pc=1601;continue;}
case 1601:{f.Push(JValue.I(6));f.Pc=1603;continue;}
case 1603:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1606);}
case 1606:{f.Push(f.Locals[4]);f.Pc=1608;continue;}
case 1608:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1611);}
case 1611:{f.Locals[7]=f.Pop();f.Pc=1613;continue;}
case 1613:{f.Push(f.Locals[6]);f.Pc=1615;continue;}
case 1615:{f.Push(f.Locals[1]);f.Pc=1616;continue;}
case 1616:{f.Push(f.Locals[7]);f.Pc=1618;continue;}
case 1618:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1621);}
case 1621:{f.Pc=f.Pop().Int!=0?1626:1624;continue;}
case 1624:{f.Push(JValue.I(0));f.Pc=1625;continue;}
case 1625:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1626:{f.Pc=3724;continue;}
case 1629:{f.Push(f.Locals[1]);f.Pc=1630;continue;}
case 1630:{f.Push(JValue.R(rt.String("IsPoisoned")));f.Pc=1633;continue;}
case 1633:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1636);}
case 1636:{f.Pc=f.Pop().Int==0?1648:1639;continue;}
case 1639:{f.Push(f.Locals[0]);f.Pc=1640;continue;}
case 1640:{return rt.Call(f,"forge/game/player/Player","getPoisonCounters","()I","invokevirtual",1643);}
case 1643:{f.Pc=f.Pop().Int>0?3724:1646;continue;}
case 1646:{f.Push(JValue.I(0));f.Pc=1647;continue;}
case 1647:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1648:{f.Push(f.Locals[1]);f.Pc=1649;continue;}
case 1649:{f.Push(JValue.R(rt.String("IsCorrupted")));f.Pc=1652;continue;}
case 1652:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1655);}
case 1655:{f.Pc=f.Pop().Int==0?1668:1658;continue;}
case 1658:{f.Push(f.Locals[0]);f.Pc=1659;continue;}
case 1659:{return rt.Call(f,"forge/game/player/Player","getPoisonCounters","()I","invokevirtual",1662);}
case 1662:{f.Push(JValue.I(2));f.Pc=1663;continue;}
case 1663:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?3724:1666;continue;}
case 1666:{f.Push(JValue.I(0));f.Pc=1667;continue;}
case 1667:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1668:{f.Push(f.Locals[1]);f.Pc=1669;continue;}
case 1669:{f.Push(JValue.R(rt.String("NoSpeed")));f.Pc=1672;continue;}
case 1672:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1675);}
case 1675:{f.Pc=f.Pop().Int==0?1687:1678;continue;}
case 1678:{f.Push(f.Locals[0]);f.Pc=1679;continue;}
case 1679:{return rt.Call(f,"forge/game/player/Player","noSpeed","()Z","invokevirtual",1682);}
case 1682:{f.Pc=f.Pop().Int!=0?3724:1685;continue;}
case 1685:{f.Push(JValue.I(0));f.Pc=1686;continue;}
case 1686:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1687:{f.Push(f.Locals[1]);f.Pc=1688;continue;}
case 1688:{f.Push(JValue.R(rt.String("MaxSpeed")));f.Pc=1691;continue;}
case 1691:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1694);}
case 1694:{f.Pc=f.Pop().Int==0?1706:1697;continue;}
case 1697:{f.Push(f.Locals[0]);f.Pc=1698;continue;}
case 1698:{return rt.Call(f,"forge/game/player/Player","maxSpeed","()Z","invokevirtual",1701);}
case 1701:{f.Pc=f.Pop().Int!=0?3724:1704;continue;}
case 1704:{f.Push(JValue.I(0));f.Pc=1705;continue;}
case 1705:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1706:{f.Push(f.Locals[1]);f.Pc=1707;continue;}
case 1707:{f.Push(JValue.R(rt.String("targetedBy")));f.Pc=1710;continue;}
case 1710:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1713);}
case 1713:{f.Pc=f.Pop().Int==0?1750:1716;continue;}
case 1716:{f.Push(f.Locals[4]);f.Pc=1718;continue;}
case 1718:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=1721;continue;}
case 1721:{f.Pc=f.Pop().Int!=0?1726:1724;continue;}
case 1724:{f.Push(JValue.I(0));f.Pc=1725;continue;}
case 1725:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1726:{f.Push(f.Locals[4]);f.Pc=1728;continue;}
case 1728:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1731;continue;}
case 1731:{f.Locals[6]=f.Pop();f.Pc=1733;continue;}
case 1733:{f.Push(f.Locals[6]);f.Pc=1735;continue;}
case 1735:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1738);}
case 1738:{f.Push(f.Locals[0]);f.Pc=1739;continue;}
case 1739:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTargeting","(Lforge/game/GameObject;)Z","invokevirtual",1742);}
case 1742:{f.Pc=f.Pop().Int!=0?1747:1745;continue;}
case 1745:{f.Push(JValue.I(0));f.Pc=1746;continue;}
case 1746:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1747:{f.Pc=3724;continue;}
case 1750:{f.Push(f.Locals[1]);f.Pc=1751;continue;}
case 1751:{f.Push(JValue.R(rt.String("controls")));f.Pc=1754;continue;}
case 1754:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1757);}
case 1757:{f.Pc=f.Pop().Int==0?1930:1760;continue;}
case 1760:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=1763;continue;}
case 1763:{f.StackOp("dup");f.Pc=1764;continue;}
case 1764:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",1767);}
case 1767:{f.Locals[6]=f.Pop();f.Pc=1769;continue;}
case 1769:{f.Push(JValue.R(rt.String("(?:\\\\.|[^_\\\\]++)+")));f.Pc=1772;continue;}
case 1772:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",1775);}
case 1775:{f.Locals[7]=f.Pop();f.Pc=1777;continue;}
case 1777:{f.Push(f.Locals[7]);f.Pc=1779;continue;}
case 1779:{f.Push(f.Locals[1]);f.Pc=1780;continue;}
case 1780:{f.Push(JValue.I(8));f.Pc=1782;continue;}
case 1782:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1785);}
case 1785:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",1788);}
case 1788:{f.Locals[8]=f.Pop();f.Pc=1790;continue;}
case 1790:{f.Push(f.Locals[8]);f.Pc=1792;continue;}
case 1792:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",1795);}
case 1795:{f.Pc=f.Pop().Int==0?1814:1798;continue;}
case 1798:{f.Push(f.Locals[6]);f.Pc=1800;continue;}
case 1800:{f.Push(f.Locals[8]);f.Pc=1802;continue;}
case 1802:{return rt.Call(f,"java/util/regex/Matcher","group","()Ljava/lang/String;","invokevirtual",1805);}
case 1805:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1810);}
case 1810:{f.StackOp("pop");f.Pc=1811;continue;}
case 1811:{f.Pc=1790;continue;}
case 1814:{f.Push(f.Locals[0]);f.Pc=1815;continue;}
case 1815:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1818;continue;}
case 1818:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1821);}
case 1821:{f.Push(f.Locals[6]);f.Pc=1823;continue;}
case 1823:{f.Push(JValue.I(0));f.Pc=1824;continue;}
case 1824:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",1829);}
case 1829:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1832;continue;}
case 1832:{f.Push(JValue.R(rt.String("\\_")));f.Pc=1835;continue;}
case 1835:{f.Push(JValue.R(rt.String("_")));f.Pc=1838;continue;}
case 1838:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",1841);}
case 1841:{f.Push(f.Locals[2]);f.Pc=1842;continue;}
case 1842:{f.Push(f.Locals[3]);f.Pc=1843;continue;}
case 1843:{f.Push(f.Locals[4]);f.Pc=1845;continue;}
case 1845:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1848);}
case 1848:{f.Locals[9]=f.Pop();f.Pc=1850;continue;}
case 1850:{f.Push(f.Locals[6]);f.Pc=1852;continue;}
case 1852:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1857);}
case 1857:{f.Push(JValue.I(1));f.Pc=1858;continue;}
case 1858:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1875:1861;continue;}
case 1861:{f.Push(f.Locals[6]);f.Pc=1863;continue;}
case 1863:{f.Push(JValue.I(1));f.Pc=1864;continue;}
case 1864:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",1869);}
case 1869:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1872;continue;}
case 1872:{f.Pc=1877;continue;}
case 1875:{f.Push(JValue.R(rt.String("GE")));f.Pc=1877;continue;}
case 1877:{f.Locals[10]=f.Pop();f.Pc=1879;continue;}
case 1879:{f.Push(f.Locals[6]);f.Pc=1881;continue;}
case 1881:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1886);}
case 1886:{f.Push(JValue.I(1));f.Pc=1887;continue;}
case 1887:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1905:1890;continue;}
case 1890:{f.Push(f.Locals[3]);f.Pc=1891;continue;}
case 1891:{f.Push(f.Locals[10]);f.Pc=1893;continue;}
case 1893:{f.Push(JValue.I(2));f.Pc=1894;continue;}
case 1894:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1897);}
case 1897:{f.Push(f.Locals[4]);f.Pc=1899;continue;}
case 1899:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1902);}
case 1902:{f.Pc=1906;continue;}
case 1905:{f.Push(JValue.I(1));f.Pc=1906;continue;}
case 1906:{f.Locals[11]=f.Pop();f.Pc=1908;continue;}
case 1908:{f.Push(f.Locals[9]);f.Pc=1910;continue;}
case 1910:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",1915);}
case 1915:{f.Push(f.Locals[10]);f.Pc=1917;continue;}
case 1917:{f.Push(f.Locals[11]);f.Pc=1919;continue;}
case 1919:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1922);}
case 1922:{f.Pc=f.Pop().Int!=0?1927:1925;continue;}
case 1925:{f.Push(JValue.I(0));f.Pc=1926;continue;}
case 1926:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1927:{f.Pc=3724;continue;}
case 1930:{f.Push(f.Locals[1]);f.Pc=1931;continue;}
case 1931:{f.Push(JValue.R(rt.String("HasCardsIn")));f.Pc=1934;continue;}
case 1934:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1937);}
case 1937:{f.Pc=f.Pop().Int==0?2020:1940;continue;}
case 1940:{f.Push(f.Locals[1]);f.Pc=1941;continue;}
case 1941:{f.Push(JValue.I(10));f.Pc=1943;continue;}
case 1943:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1946);}
case 1946:{f.Push(JValue.R(rt.String("_")));f.Pc=1949;continue;}
case 1949:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1952);}
case 1952:{f.Locals[6]=f.Pop();f.Pc=1954;continue;}
case 1954:{f.Push(f.Locals[0]);f.Pc=1955;continue;}
case 1955:{f.Push(f.Locals[6]);f.Pc=1957;continue;}
case 1957:{f.Push(JValue.I(0));f.Pc=1958;continue;}
case 1958:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1959;continue;}
case 1959:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",1962);}
case 1962:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1965);}
case 1965:{f.Push(f.Locals[6]);f.Pc=1967;continue;}
case 1967:{f.Push(JValue.I(1));f.Pc=1968;continue;}
case 1968:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1969;continue;}
case 1969:{f.Push(f.Locals[2]);f.Pc=1970;continue;}
case 1970:{f.Push(f.Locals[3]);f.Pc=1971;continue;}
case 1971:{f.Push(f.Locals[4]);f.Pc=1973;continue;}
case 1973:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1976);}
case 1976:{f.Locals[7]=f.Pop();f.Pc=1978;continue;}
case 1978:{f.Push(f.Locals[6]);f.Pc=1980;continue;}
case 1980:{f.Push(JValue.I(2));f.Pc=1981;continue;}
case 1981:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1982;continue;}
case 1982:{f.Locals[8]=f.Pop();f.Pc=1984;continue;}
case 1984:{f.Push(f.Locals[3]);f.Pc=1985;continue;}
case 1985:{f.Push(f.Locals[8]);f.Pc=1987;continue;}
case 1987:{f.Push(JValue.I(2));f.Pc=1988;continue;}
case 1988:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1991);}
case 1991:{f.Push(f.Locals[4]);f.Pc=1993;continue;}
case 1993:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1996);}
case 1996:{f.Locals[9]=f.Pop();f.Pc=1998;continue;}
case 1998:{f.Push(f.Locals[7]);f.Pc=2000;continue;}
case 2000:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",2005);}
case 2005:{f.Push(f.Locals[8]);f.Pc=2007;continue;}
case 2007:{f.Push(f.Locals[9]);f.Pc=2009;continue;}
case 2009:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",2012);}
case 2012:{f.Pc=f.Pop().Int!=0?2017:2015;continue;}
case 2015:{f.Push(JValue.I(0));f.Pc=2016;continue;}
case 2016:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2017:{f.Pc=3724;continue;}
case 2020:{f.Push(f.Locals[1]);f.Pc=2021;continue;}
case 2021:{f.Push(JValue.R(rt.String("withMore")));f.Pc=2024;continue;}
case 2024:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2027);}
case 2027:{f.Pc=f.Pop().Int==0?2115:2030;continue;}
case 2030:{f.Push(f.Locals[1]);f.Pc=2031;continue;}
case 2031:{f.Push(JValue.R(rt.String("sThan")));f.Pc=2034;continue;}
case 2034:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2037);}
case 2037:{f.Push(JValue.I(0));f.Pc=2038;continue;}
case 2038:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2039;continue;}
case 2039:{f.Push(JValue.I(8));f.Pc=2041;continue;}
case 2041:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",2044);}
case 2044:{f.Locals[6]=f.Pop();f.Pc=2046;continue;}
case 2046:{f.Push(f.Locals[1]);f.Pc=2047;continue;}
case 2047:{f.Push(JValue.R(rt.String("sThan")));f.Pc=2050;continue;}
case 2050:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2053);}
case 2053:{f.Push(JValue.I(1));f.Pc=2054;continue;}
case 2054:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2055;continue;}
case 2055:{f.Push(f.Locals[2]);f.Pc=2056;continue;}
case 2056:{f.Push(f.Locals[3]);f.Pc=2057;continue;}
case 2057:{f.Push(f.Locals[4]);f.Pc=2059;continue;}
case 2059:{return rt.Call(f,"forge/game/player/PlayerProperty","comparedPlayer","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/player/Player;","invokestatic",2062);}
case 2062:{f.Locals[7]=f.Pop();f.Pc=2064;continue;}
case 2064:{f.Push(f.Locals[0]);f.Pc=2065;continue;}
case 2065:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=2068;continue;}
case 2068:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",2071);}
case 2071:{f.Push(f.Locals[6]);f.Pc=2073;continue;}
case 2073:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",2076);}
case 2076:{f.Locals[8]=f.Pop();f.Pc=2078;continue;}
case 2078:{f.Push(f.Locals[7]);f.Pc=2080;continue;}
case 2080:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=2083;continue;}
case 2083:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",2086);}
case 2086:{f.Push(f.Locals[6]);f.Pc=2088;continue;}
case 2088:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",2091);}
case 2091:{f.Locals[9]=f.Pop();f.Pc=2093;continue;}
case 2093:{f.Push(f.Locals[8]);f.Pc=2095;continue;}
case 2095:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",2100);}
case 2100:{f.Push(f.Locals[9]);f.Pc=2102;continue;}
case 2102:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",2107);}
case 2107:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?2112:2110;continue;}
case 2110:{f.Push(JValue.I(0));f.Pc=2111;continue;}
case 2111:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2112:{f.Pc=3724;continue;}
case 2115:{f.Push(f.Locals[1]);f.Pc=2116;continue;}
case 2116:{f.Push(JValue.R(rt.String("withAtLeast")));f.Pc=2119;continue;}
case 2119:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2122);}
case 2122:{f.Pc=f.Pop().Int==0?2229:2125;continue;}
case 2125:{f.Push(f.Locals[1]);f.Pc=2126;continue;}
case 2126:{f.Push(JValue.R(rt.String("More")));f.Pc=2129;continue;}
case 2129:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2132);}
case 2132:{f.Push(JValue.I(1));f.Pc=2133;continue;}
case 2133:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2134;continue;}
case 2134:{f.Push(JValue.R(rt.String("sThan")));f.Pc=2137;continue;}
case 2137:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2140);}
case 2140:{f.Push(JValue.I(0));f.Pc=2141;continue;}
case 2141:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2142;continue;}
case 2142:{f.Locals[6]=f.Pop();f.Pc=2144;continue;}
case 2144:{f.Push(f.Locals[1]);f.Pc=2145;continue;}
case 2145:{f.Push(JValue.I(11));f.Pc=2147;continue;}
case 2147:{f.Push(JValue.I(12));f.Pc=2149;continue;}
case 2149:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",2152);}
case 2152:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",2155);}
case 2155:{f.Locals[7]=f.Pop();f.Pc=2157;continue;}
case 2157:{f.Push(f.Locals[1]);f.Pc=2158;continue;}
case 2158:{f.Push(JValue.R(rt.String("sThan")));f.Pc=2161;continue;}
case 2161:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2164);}
case 2164:{f.Push(JValue.I(1));f.Pc=2165;continue;}
case 2165:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2166;continue;}
case 2166:{f.Push(f.Locals[2]);f.Pc=2167;continue;}
case 2167:{f.Push(f.Locals[3]);f.Pc=2168;continue;}
case 2168:{f.Push(f.Locals[4]);f.Pc=2170;continue;}
case 2170:{return rt.Call(f,"forge/game/player/PlayerProperty","comparedPlayer","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/player/Player;","invokestatic",2173);}
case 2173:{f.Locals[8]=f.Pop();f.Pc=2175;continue;}
case 2175:{f.Push(f.Locals[0]);f.Pc=2176;continue;}
case 2176:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=2179;continue;}
case 2179:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",2182);}
case 2182:{f.Push(f.Locals[6]);f.Pc=2184;continue;}
case 2184:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",2187);}
case 2187:{f.Locals[9]=f.Pop();f.Pc=2189;continue;}
case 2189:{f.Push(f.Locals[8]);f.Pc=2191;continue;}
case 2191:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=2194;continue;}
case 2194:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",2197);}
case 2197:{f.Push(f.Locals[6]);f.Pc=2199;continue;}
case 2199:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",2202);}
case 2202:{f.Locals[10]=f.Pop();f.Pc=2204;continue;}
case 2204:{f.Push(f.Locals[9]);f.Pc=2206;continue;}
case 2206:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",2211);}
case 2211:{f.Push(f.Locals[10]);f.Pc=2213;continue;}
case 2213:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",2218);}
case 2218:{f.Push(f.Locals[7]);f.Pc=2220;continue;}
case 2220:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=2221;continue;}
case 2221:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?2226:2224;continue;}
case 2224:{f.Push(JValue.I(0));f.Pc=2225;continue;}
case 2225:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2226:{f.Pc=3724;continue;}
case 2229:{f.Push(f.Locals[1]);f.Pc=2230;continue;}
case 2230:{f.Push(JValue.R(rt.String("hasMore")));f.Pc=2233;continue;}
case 2233:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2236);}
case 2236:{f.Pc=f.Pop().Int==0?2348:2239;continue;}
case 2239:{f.Push(f.Locals[1]);f.Pc=2240;continue;}
case 2240:{f.Push(JValue.R(rt.String("Than")));f.Pc=2243;continue;}
case 2243:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",2246);}
case 2246:{f.Pc=f.Pop().Int==0?2268:2249;continue;}
case 2249:{f.Push(f.Locals[1]);f.Pc=2250;continue;}
case 2250:{f.Push(JValue.R(rt.String("Than")));f.Pc=2253;continue;}
case 2253:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2256);}
case 2256:{f.Push(JValue.I(1));f.Pc=2257;continue;}
case 2257:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2258;continue;}
case 2258:{f.Push(f.Locals[2]);f.Pc=2259;continue;}
case 2259:{f.Push(f.Locals[3]);f.Pc=2260;continue;}
case 2260:{f.Push(f.Locals[4]);f.Pc=2262;continue;}
case 2262:{return rt.Call(f,"forge/game/player/PlayerProperty","comparedPlayer","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/player/Player;","invokestatic",2265);}
case 2265:{f.Pc=2269;continue;}
case 2268:{f.Push(f.Locals[2]);f.Pc=2269;continue;}
case 2269:{f.Locals[6]=f.Pop();f.Pc=2271;continue;}
case 2271:{f.Push(f.Locals[1]);f.Pc=2272;continue;}
case 2272:{f.Push(JValue.I(7));f.Pc=2274;continue;}
case 2274:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",2277);}
case 2277:{f.Push(JValue.R(rt.String("Life")));f.Pc=2280;continue;}
case 2280:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2283);}
case 2283:{f.Pc=f.Pop().Int==0?2300:2286;continue;}
case 2286:{f.Push(f.Locals[0]);f.Pc=2287;continue;}
case 2287:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",2290);}
case 2290:{f.Push(f.Locals[6]);f.Pc=2292;continue;}
case 2292:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",2295);}
case 2295:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?2300:2298;continue;}
case 2298:{f.Push(JValue.I(0));f.Pc=2299;continue;}
case 2299:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2300:{f.Push(f.Locals[1]);f.Pc=2301;continue;}
case 2301:{f.Push(JValue.I(7));f.Pc=2303;continue;}
case 2303:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",2306);}
case 2306:{f.Push(JValue.R(rt.String("CardsInHand")));f.Pc=2309;continue;}
case 2309:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2312);}
case 2312:{f.Pc=f.Pop().Int==0?2345:2315;continue;}
case 2315:{f.Push(f.Locals[0]);f.Pc=2316;continue;}
case 2316:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=2319;continue;}
case 2319:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",2322);}
case 2322:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",2327);}
case 2327:{f.Push(f.Locals[6]);f.Pc=2329;continue;}
case 2329:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=2332;continue;}
case 2332:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",2335);}
case 2335:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",2340);}
case 2340:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?2345:2343;continue;}
case 2343:{f.Push(JValue.I(0));f.Pc=2344;continue;}
case 2344:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2345:{f.Pc=3724;continue;}
case 2348:{f.Push(f.Locals[1]);f.Pc=2349;continue;}
case 2349:{f.Push(JValue.R(rt.String("hasFewer")));f.Pc=2352;continue;}
case 2352:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2355);}
case 2355:{f.Pc=f.Pop().Int==0?2467:2358;continue;}
case 2358:{f.Push(f.Locals[1]);f.Pc=2359;continue;}
case 2359:{f.Push(JValue.R(rt.String("sIn")));f.Pc=2362;continue;}
case 2362:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2365);}
case 2365:{f.Push(JValue.I(0));f.Pc=2366;continue;}
case 2366:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2367;continue;}
case 2367:{f.Push(JValue.I(8));f.Pc=2369;continue;}
case 2369:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",2372);}
case 2372:{f.Locals[6]=f.Pop();f.Pc=2374;continue;}
case 2374:{f.Push(f.Locals[1]);f.Pc=2375;continue;}
case 2375:{f.Push(JValue.R(rt.String("Than")));f.Pc=2378;continue;}
case 2378:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2381);}
case 2381:{f.Push(JValue.I(1));f.Pc=2382;continue;}
case 2382:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2383;continue;}
case 2383:{f.Push(f.Locals[2]);f.Pc=2384;continue;}
case 2384:{f.Push(f.Locals[3]);f.Pc=2385;continue;}
case 2385:{f.Push(f.Locals[4]);f.Pc=2387;continue;}
case 2387:{return rt.Call(f,"forge/game/player/PlayerProperty","comparedPlayer","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/player/Player;","invokestatic",2390);}
case 2390:{f.Locals[7]=f.Pop();f.Pc=2392;continue;}
case 2392:{f.Push(f.Locals[1]);f.Pc=2393;continue;}
case 2393:{f.Push(JValue.I(8));f.Pc=2395;continue;}
case 2395:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",2398);}
case 2398:{f.Push(JValue.R(rt.String("CreaturesInYard")));f.Pc=2401;continue;}
case 2401:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2404);}
case 2404:{f.Pc=f.Pop().Int==0?2413:2407;continue;}
case 2407:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=2410;continue;}
case 2410:{f.Pc=2416;continue;}
case 2413:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=2416;continue;}
case 2416:{f.Locals[8]=f.Pop();f.Pc=2418;continue;}
case 2418:{f.Push(f.Locals[0]);f.Pc=2419;continue;}
case 2419:{f.Push(f.Locals[8]);f.Pc=2421;continue;}
case 2421:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",2424);}
case 2424:{f.Push(f.Locals[6]);f.Pc=2426;continue;}
case 2426:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",2429);}
case 2429:{f.Locals[9]=f.Pop();f.Pc=2431;continue;}
case 2431:{f.Push(f.Locals[7]);f.Pc=2433;continue;}
case 2433:{f.Push(f.Locals[8]);f.Pc=2435;continue;}
case 2435:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",2438);}
case 2438:{f.Push(f.Locals[6]);f.Pc=2440;continue;}
case 2440:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",2443);}
case 2443:{f.Locals[10]=f.Pop();f.Pc=2445;continue;}
case 2445:{f.Push(f.Locals[9]);f.Pc=2447;continue;}
case 2447:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",2452);}
case 2452:{f.Push(f.Locals[10]);f.Pc=2454;continue;}
case 2454:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",2459);}
case 2459:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?2464:2462;continue;}
case 2462:{f.Push(JValue.I(0));f.Pc=2463;continue;}
case 2463:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2464:{f.Pc=3724;continue;}
case 2467:{f.Push(f.Locals[1]);f.Pc=2468;continue;}
case 2468:{f.Push(JValue.R(rt.String("withMost")));f.Pc=2471;continue;}
case 2471:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2474);}
case 2474:{f.Pc=f.Pop().Int==0?2992:2477;continue;}
case 2477:{f.Push(f.Locals[1]);f.Pc=2478;continue;}
case 2478:{f.Push(JValue.I(8));f.Pc=2480;continue;}
case 2480:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",2483);}
case 2483:{f.Locals[6]=f.Pop();f.Pc=2485;continue;}
case 2485:{f.Push(f.Locals[6]);f.Pc=2487;continue;}
case 2487:{f.Push(JValue.R(rt.String("Life")));f.Pc=2490;continue;}
case 2490:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2493);}
case 2493:{f.Pc=f.Pop().Int==0?2568:2496;continue;}
case 2496:{f.Push(f.Locals[0]);f.Pc=2497;continue;}
case 2497:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",2500);}
case 2500:{f.Locals[7]=f.Pop();f.Pc=2502;continue;}
case 2502:{f.Push(f.Locals[5]);f.Pc=2504;continue;}
case 2504:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",2507);}
case 2507:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2510);}
case 2510:{f.Locals[8]=f.Pop();f.Pc=2512;continue;}
case 2512:{f.Push(f.Locals[8]);f.Pc=2514;continue;}
case 2514:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2519);}
case 2519:{f.Pc=f.Pop().Int==0?2554:2522;continue;}
case 2522:{f.Push(f.Locals[8]);f.Pc=2524;continue;}
case 2524:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2529);}
case 2529:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2532;continue;}
case 2532:{f.Locals[9]=f.Pop();f.Pc=2534;continue;}
case 2534:{f.Push(f.Locals[9]);f.Pc=2536;continue;}
case 2536:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",2539);}
case 2539:{f.Push(f.Locals[7]);f.Pc=2541;continue;}
case 2541:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2551:2544;continue;}
case 2544:{f.Push(f.Locals[9]);f.Pc=2546;continue;}
case 2546:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",2549);}
case 2549:{f.Locals[7]=f.Pop();f.Pc=2551;continue;}
case 2551:{f.Pc=2512;continue;}
case 2554:{f.Push(f.Locals[0]);f.Pc=2555;continue;}
case 2555:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",2558);}
case 2558:{f.Push(f.Locals[7]);f.Pc=2560;continue;}
case 2560:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?2565:2563;continue;}
case 2563:{f.Push(JValue.I(0));f.Pc=2564;continue;}
case 2564:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2565:{f.Pc=2989;continue;}
case 2568:{f.Push(f.Locals[6]);f.Pc=2570;continue;}
case 2570:{f.Push(JValue.R(rt.String("PermanentInPlay")));f.Pc=2573;continue;}
case 2573:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2576);}
case 2576:{f.Pc=f.Pop().Int==0?2703:2579;continue;}
case 2579:{f.Push(JValue.I(0));f.Pc=2580;continue;}
case 2580:{f.Locals[7]=f.Pop();f.Pc=2582;continue;}
case 2582:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=2585;continue;}
case 2585:{f.StackOp("dup");f.Pc=2586;continue;}
case 2586:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",2589);}
case 2589:{f.Locals[8]=f.Pop();f.Pc=2591;continue;}
case 2591:{f.Push(f.Locals[5]);f.Pc=2593;continue;}
case 2593:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",2596);}
case 2596:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2599);}
case 2599:{f.Locals[9]=f.Pop();f.Pc=2601;continue;}
case 2601:{f.Push(f.Locals[9]);f.Pc=2603;continue;}
case 2603:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2608);}
case 2608:{f.Pc=f.Pop().Int==0?2676:2611;continue;}
case 2611:{f.Push(f.Locals[9]);f.Pc=2613;continue;}
case 2613:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2618);}
case 2618:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2621;continue;}
case 2621:{f.Locals[10]=f.Pop();f.Pc=2623;continue;}
case 2623:{f.Push(f.Locals[10]);f.Pc=2625;continue;}
case 2625:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=2628;continue;}
case 2628:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",2631);}
case 2631:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",2636);}
case 2636:{f.Locals[11]=f.Pop();f.Pc=2638;continue;}
case 2638:{f.Push(f.Locals[11]);f.Pc=2640;continue;}
case 2640:{f.Push(f.Locals[7]);f.Pc=2642;continue;}
case 2642:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2656:2645;continue;}
case 2645:{f.Push(f.Locals[11]);f.Pc=2647;continue;}
case 2647:{f.Locals[7]=f.Pop();f.Pc=2649;continue;}
case 2649:{f.Push(f.Locals[8]);f.Pc=2651;continue;}
case 2651:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",2656);}
case 2656:{f.Push(f.Locals[11]);f.Pc=2658;continue;}
case 2658:{f.Push(f.Locals[7]);f.Pc=2660;continue;}
case 2660:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?2673:2663;continue;}
case 2663:{f.Push(f.Locals[8]);f.Pc=2665;continue;}
case 2665:{f.Push(f.Locals[10]);f.Pc=2667;continue;}
case 2667:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",2672);}
case 2672:{f.StackOp("pop");f.Pc=2673;continue;}
case 2673:{f.Pc=2601;continue;}
case 2676:{f.Push(f.Locals[8]);f.Pc=2678;continue;}
case 2678:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",2683);}
case 2683:{f.Push(JValue.I(1));f.Pc=2684;continue;}
case 2684:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?2698:2687;continue;}
case 2687:{f.Push(f.Locals[8]);f.Pc=2689;continue;}
case 2689:{f.Push(f.Locals[0]);f.Pc=2690;continue;}
case 2690:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",2695);}
case 2695:{f.Pc=f.Pop().Int!=0?2700:2698;continue;}
case 2698:{f.Push(JValue.I(0));f.Pc=2699;continue;}
case 2699:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2700:{f.Pc=2989;continue;}
case 2703:{f.Push(f.Locals[6]);f.Pc=2705;continue;}
case 2705:{f.Push(JValue.R(rt.String("CardsInHand")));f.Pc=2708;continue;}
case 2708:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2711);}
case 2711:{f.Pc=f.Pop().Int==0?2806:2714;continue;}
case 2714:{f.Push(JValue.I(0));f.Pc=2715;continue;}
case 2715:{f.Locals[7]=f.Pop();f.Pc=2717;continue;}
case 2717:{f.Push(JValue.R(null));f.Pc=2718;continue;}
case 2718:{f.Locals[8]=f.Pop();f.Pc=2720;continue;}
case 2720:{f.Push(f.Locals[5]);f.Pc=2722;continue;}
case 2722:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",2725);}
case 2725:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2728);}
case 2728:{f.Locals[9]=f.Pop();f.Pc=2730;continue;}
case 2730:{f.Push(f.Locals[9]);f.Pc=2732;continue;}
case 2732:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2737);}
case 2737:{f.Pc=f.Pop().Int==0?2792:2740;continue;}
case 2740:{f.Push(f.Locals[9]);f.Pc=2742;continue;}
case 2742:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2747);}
case 2747:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2750;continue;}
case 2750:{f.Locals[10]=f.Pop();f.Pc=2752;continue;}
case 2752:{f.Push(f.Locals[10]);f.Pc=2754;continue;}
case 2754:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=2757;continue;}
case 2757:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",2760);}
case 2760:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",2765);}
case 2765:{f.Push(f.Locals[7]);f.Pc=2767;continue;}
case 2767:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2789:2770;continue;}
case 2770:{f.Push(f.Locals[10]);f.Pc=2772;continue;}
case 2772:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=2775;continue;}
case 2775:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",2778);}
case 2778:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",2783);}
case 2783:{f.Locals[7]=f.Pop();f.Pc=2785;continue;}
case 2785:{f.Push(f.Locals[10]);f.Pc=2787;continue;}
case 2787:{f.Locals[8]=f.Pop();f.Pc=2789;continue;}
case 2789:{f.Pc=2730;continue;}
case 2792:{f.Push(f.Locals[0]);f.Pc=2793;continue;}
case 2793:{f.Push(f.Locals[8]);f.Pc=2795;continue;}
case 2795:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",2798);}
case 2798:{f.Pc=f.Pop().Int!=0?2803:2801;continue;}
case 2801:{f.Push(JValue.I(0));f.Pc=2802;continue;}
case 2802:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2803:{f.Pc=2989;continue;}
case 2806:{f.Push(f.Locals[6]);f.Pc=2808;continue;}
case 2808:{f.Push(JValue.R(rt.String("Type")));f.Pc=2811;continue;}
case 2811:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2814);}
case 2814:{f.Pc=f.Pop().Int==0?2989:2817;continue;}
case 2817:{f.Push(f.Locals[1]);f.Pc=2818;continue;}
case 2818:{f.Push(JValue.R(rt.String("Type")));f.Pc=2821;continue;}
case 2821:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2824);}
case 2824:{f.Push(JValue.I(1));f.Pc=2825;continue;}
case 2825:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2826;continue;}
case 2826:{f.Locals[7]=f.Pop();f.Pc=2828;continue;}
case 2828:{f.Push(JValue.I(0));f.Pc=2829;continue;}
case 2829:{f.Locals[8]=f.Pop();f.Pc=2831;continue;}
case 2831:{f.Push(f.Locals[7]);f.Pc=2833;continue;}
case 2833:{f.Push(JValue.R(rt.String("Only")));f.Pc=2836;continue;}
case 2836:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",2839);}
case 2839:{f.Pc=f.Pop().Int==0?2858:2842;continue;}
case 2842:{f.Push(JValue.I(1));f.Pc=2843;continue;}
case 2843:{f.Locals[8]=f.Pop();f.Pc=2845;continue;}
case 2845:{f.Push(f.Locals[7]);f.Pc=2847;continue;}
case 2847:{f.Push(JValue.R(rt.String("Only")));f.Pc=2850;continue;}
case 2850:{f.Push(JValue.R(rt.String("")));f.Pc=2853;continue;}
case 2853:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",2856);}
case 2856:{f.Locals[7]=f.Pop();f.Pc=2858;continue;}
case 2858:{f.Push(JValue.I(0));f.Pc=2859;continue;}
case 2859:{f.Locals[9]=f.Pop();f.Pc=2861;continue;}
case 2861:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=2864;continue;}
case 2864:{f.StackOp("dup");f.Pc=2865;continue;}
case 2865:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",2868);}
case 2868:{f.Locals[10]=f.Pop();f.Pc=2870;continue;}
case 2870:{f.Push(f.Locals[5]);f.Pc=2872;continue;}
case 2872:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",2875);}
case 2875:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2878);}
case 2878:{f.Locals[11]=f.Pop();f.Pc=2880;continue;}
case 2880:{f.Push(f.Locals[11]);f.Pc=2882;continue;}
case 2882:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2887);}
case 2887:{f.Pc=f.Pop().Int==0?2958:2890;continue;}
case 2890:{f.Push(f.Locals[11]);f.Pc=2892;continue;}
case 2892:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2897);}
case 2897:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2900;continue;}
case 2900:{f.Locals[12]=f.Pop();f.Pc=2902;continue;}
case 2902:{f.Push(f.Locals[12]);f.Pc=2904;continue;}
case 2904:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=2907;continue;}
case 2907:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",2910);}
case 2910:{f.Push(f.Locals[7]);f.Pc=2912;continue;}
case 2912:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",2915);}
case 2915:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",2918);}
case 2918:{f.Locals[13]=f.Pop();f.Pc=2920;continue;}
case 2920:{f.Push(f.Locals[13]);f.Pc=2922;continue;}
case 2922:{f.Push(f.Locals[9]);f.Pc=2924;continue;}
case 2924:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2938:2927;continue;}
case 2927:{f.Push(f.Locals[13]);f.Pc=2929;continue;}
case 2929:{f.Locals[9]=f.Pop();f.Pc=2931;continue;}
case 2931:{f.Push(f.Locals[10]);f.Pc=2933;continue;}
case 2933:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",2938);}
case 2938:{f.Push(f.Locals[13]);f.Pc=2940;continue;}
case 2940:{f.Push(f.Locals[9]);f.Pc=2942;continue;}
case 2942:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?2955:2945;continue;}
case 2945:{f.Push(f.Locals[10]);f.Pc=2947;continue;}
case 2947:{f.Push(f.Locals[12]);f.Pc=2949;continue;}
case 2949:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",2954);}
case 2954:{f.StackOp("pop");f.Pc=2955;continue;}
case 2955:{f.Pc=2880;continue;}
case 2958:{f.Push(f.Locals[8]);f.Pc=2960;continue;}
case 2960:{f.Pc=f.Pop().Int==0?2976:2963;continue;}
case 2963:{f.Push(f.Locals[10]);f.Pc=2965;continue;}
case 2965:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",2970);}
case 2970:{f.Push(JValue.I(1));f.Pc=2971;continue;}
case 2971:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?2976:2974;continue;}
case 2974:{f.Push(JValue.I(0));f.Pc=2975;continue;}
case 2975:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2976:{f.Push(f.Locals[10]);f.Pc=2978;continue;}
case 2978:{f.Push(f.Locals[0]);f.Pc=2979;continue;}
case 2979:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",2984);}
case 2984:{f.Pc=f.Pop().Int!=0?2989:2987;continue;}
case 2987:{f.Push(JValue.I(0));f.Pc=2988;continue;}
case 2988:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2989:{f.Pc=3724;continue;}
case 2992:{f.Push(f.Locals[1]);f.Pc=2993;continue;}
case 2993:{f.Push(JValue.R(rt.String("withLowest")));f.Pc=2996;continue;}
case 2996:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2999);}
case 2999:{f.Pc=f.Pop().Int==0?3140:3002;continue;}
case 3002:{f.Push(f.Locals[1]);f.Pc=3003;continue;}
case 3003:{f.Push(JValue.I(10));f.Pc=3005;continue;}
case 3005:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",3008);}
case 3008:{f.Push(JValue.R(rt.String("Life")));f.Pc=3011;continue;}
case 3011:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3014);}
case 3014:{f.Pc=f.Pop().Int==0?3724:3017;continue;}
case 3017:{f.Push(f.Locals[0]);f.Pc=3018;continue;}
case 3018:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",3021);}
case 3021:{f.Locals[6]=f.Pop();f.Pc=3023;continue;}
case 3023:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3026;continue;}
case 3026:{f.StackOp("dup");f.Pc=3027;continue;}
case 3027:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",3030);}
case 3030:{f.Locals[7]=f.Pop();f.Pc=3032;continue;}
case 3032:{f.Push(f.Locals[5]);f.Pc=3034;continue;}
case 3034:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",3037);}
case 3037:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",3040);}
case 3040:{f.Locals[8]=f.Pop();f.Pc=3042;continue;}
case 3042:{f.Push(f.Locals[8]);f.Pc=3044;continue;}
case 3044:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3049);}
case 3049:{f.Pc=f.Pop().Int==0?3124:3052;continue;}
case 3052:{f.Push(f.Locals[8]);f.Pc=3054;continue;}
case 3054:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3059);}
case 3059:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3062;continue;}
case 3062:{f.Locals[9]=f.Pop();f.Pc=3064;continue;}
case 3064:{f.Push(f.Locals[9]);f.Pc=3066;continue;}
case 3066:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",3069);}
case 3069:{f.Push(f.Locals[6]);f.Pc=3071;continue;}
case 3071:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?3087:3074;continue;}
case 3074:{f.Push(f.Locals[7]);f.Pc=3076;continue;}
case 3076:{f.Push(f.Locals[9]);f.Pc=3078;continue;}
case 3078:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",3083);}
case 3083:{f.StackOp("pop");f.Pc=3084;continue;}
case 3084:{f.Pc=3121;continue;}
case 3087:{f.Push(f.Locals[9]);f.Pc=3089;continue;}
case 3089:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",3092);}
case 3092:{f.Push(f.Locals[6]);f.Pc=3094;continue;}
case 3094:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?3121:3097;continue;}
case 3097:{f.Push(f.Locals[9]);f.Pc=3099;continue;}
case 3099:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",3102);}
case 3102:{f.Locals[6]=f.Pop();f.Pc=3104;continue;}
case 3104:{f.Push(f.Locals[7]);f.Pc=3106;continue;}
case 3106:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",3111);}
case 3111:{f.Push(f.Locals[7]);f.Pc=3113;continue;}
case 3113:{f.Push(f.Locals[9]);f.Pc=3115;continue;}
case 3115:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",3120);}
case 3120:{f.StackOp("pop");f.Pc=3121;continue;}
case 3121:{f.Pc=3042;continue;}
case 3124:{f.Push(f.Locals[7]);f.Pc=3126;continue;}
case 3126:{f.Push(f.Locals[0]);f.Pc=3127;continue;}
case 3127:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",3132);}
case 3132:{f.Pc=f.Pop().Int!=0?3137:3135;continue;}
case 3135:{f.Push(JValue.I(0));f.Pc=3136;continue;}
case 3136:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3137:{f.Pc=3724;continue;}
case 3140:{f.Push(f.Locals[1]);f.Pc=3141;continue;}
case 3141:{f.Push(JValue.R(rt.String("Triggered")));f.Pc=3144;continue;}
case 3144:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3147);}
case 3147:{f.Pc=f.Pop().Int!=0?3160:3150;continue;}
case 3150:{f.Push(f.Locals[1]);f.Pc=3151;continue;}
case 3151:{f.Push(JValue.R(rt.String("OriginalHostRemembered")));f.Pc=3154;continue;}
case 3154:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3157);}
case 3157:{f.Pc=f.Pop().Int==0?3176:3160;continue;}
case 3160:{f.Push(f.Locals[3]);f.Pc=3161;continue;}
case 3161:{f.Push(f.Locals[1]);f.Pc=3162;continue;}
case 3162:{f.Push(f.Locals[4]);f.Pc=3164;continue;}
case 3164:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",3167);}
case 3167:{f.Push(f.Locals[0]);f.Pc=3168;continue;}
case 3168:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",3171);}
case 3171:{f.Pc=f.Pop().Int!=0?3724:3174;continue;}
case 3174:{f.Push(JValue.I(0));f.Pc=3175;continue;}
case 3175:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3176:{f.Push(f.Locals[1]);f.Pc=3177;continue;}
case 3177:{f.Push(JValue.R(rt.String("castSpellThisTurn")));f.Pc=3180;continue;}
case 3180:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3183);}
case 3183:{f.Pc=f.Pop().Int==0?3195:3186;continue;}
case 3186:{f.Push(f.Locals[0]);f.Pc=3187;continue;}
case 3187:{return rt.Call(f,"forge/game/player/Player","getSpellsCastThisTurn","()I","invokevirtual",3190);}
case 3190:{f.Pc=f.Pop().Int!=0?3724:3193;continue;}
case 3193:{f.Push(JValue.I(0));f.Pc=3194;continue;}
case 3194:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3195:{f.Push(f.Locals[1]);f.Pc=3196;continue;}
case 3196:{f.Push(JValue.R(rt.String("attackedWithCreaturesThisTurn")));f.Pc=3199;continue;}
case 3199:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3202);}
case 3202:{f.Pc=f.Pop().Int==0?3219:3205;continue;}
case 3205:{f.Push(f.Locals[0]);f.Pc=3206;continue;}
case 3206:{return rt.Call(f,"forge/game/player/Player","getCreaturesAttackedThisTurn","()Ljava/util/List;","invokevirtual",3209);}
case 3209:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",3214);}
case 3214:{f.Pc=f.Pop().Int==0?3724:3217;continue;}
case 3217:{f.Push(JValue.I(0));f.Pc=3218;continue;}
case 3218:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3219:{f.Push(f.Locals[1]);f.Pc=3220;continue;}
case 3220:{f.Push(JValue.R(rt.String("wasAttackedThisTurnBy")));f.Pc=3223;continue;}
case 3223:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3226);}
case 3226:{f.Pc=f.Pop().Int==0?3294:3229;continue;}
case 3229:{f.Push(f.Locals[1]);f.Pc=3230;continue;}
case 3230:{f.Push(JValue.R(rt.String(" ")));f.Pc=3232;continue;}
case 3232:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",3235);}
case 3235:{f.Push(JValue.I(1));f.Pc=3236;continue;}
case 3236:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3237;continue;}
case 3237:{f.Locals[6]=f.Pop();f.Pc=3239;continue;}
case 3239:{f.Push(f.Locals[2]);f.Pc=3240;continue;}
case 3240:{f.Push(f.Locals[0]);f.Pc=3241;continue;}
case 3241:{return rt.Call(f,"forge/game/player/Player","getCreaturesAttackedThisTurn","(Lforge/game/GameEntity;)Ljava/util/List;","invokevirtual",3244);}
case 3244:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",3249);}
case 3249:{f.Locals[7]=f.Pop();f.Pc=3251;continue;}
case 3251:{f.Push(f.Locals[7]);f.Pc=3253;continue;}
case 3253:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3258);}
case 3258:{f.Pc=f.Pop().Int==0?3292:3261;continue;}
case 3261:{f.Push(f.Locals[7]);f.Pc=3263;continue;}
case 3263:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3268);}
case 3268:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3271;continue;}
case 3271:{f.Locals[8]=f.Pop();f.Pc=3273;continue;}
case 3273:{f.Push(f.Locals[8]);f.Pc=3275;continue;}
case 3275:{f.Push(f.Locals[6]);f.Pc=3277;continue;}
case 3277:{f.Push(f.Locals[2]);f.Pc=3278;continue;}
case 3278:{f.Push(f.Locals[3]);f.Pc=3279;continue;}
case 3279:{f.Push(f.Locals[4]);f.Pc=3281;continue;}
case 3281:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",3284);}
case 3284:{f.Pc=f.Pop().Int==0?3289:3287;continue;}
case 3287:{f.Push(JValue.I(1));f.Pc=3288;continue;}
case 3288:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3289:{f.Pc=3251;continue;}
case 3292:{f.Push(JValue.I(0));f.Pc=3293;continue;}
case 3293:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3294:{f.Push(f.Locals[1]);f.Pc=3295;continue;}
case 3295:{f.Push(JValue.R(rt.String("attackedYouTheirCurrentTurn")));f.Pc=3298;continue;}
case 3298:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3301);}
case 3301:{f.Pc=f.Pop().Int==0?3317:3304;continue;}
case 3304:{f.Push(f.Locals[0]);f.Pc=3305;continue;}
case 3305:{return rt.Call(f,"forge/game/player/Player","getAttackedPlayersMyTurn","()Ljava/lang/Iterable;","invokevirtual",3308);}
case 3308:{f.Push(f.Locals[2]);f.Pc=3309;continue;}
case 3309:{return rt.Call(f,"com/google/common/collect/Iterables","contains","(Ljava/lang/Iterable;Ljava/lang/Object;)Z","invokestatic",3312);}
case 3312:{f.Pc=f.Pop().Int!=0?3724:3315;continue;}
case 3315:{f.Push(JValue.I(0));f.Pc=3316;continue;}
case 3316:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3317:{f.Push(f.Locals[1]);f.Pc=3318;continue;}
case 3318:{f.Push(JValue.R(rt.String("attackedYouCtrlTheirCurrentTurn")));f.Pc=3321;continue;}
case 3321:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3324);}
case 3324:{f.Pc=f.Pop().Int==0?3403:3327;continue;}
case 3327:{f.Push(f.Locals[2]);f.Pc=3328;continue;}
case 3328:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=3331;continue;}
case 3331:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",3334);}
case 3334:{f.Push(f.Locals[1]);f.Pc=3335;continue;}
case 3335:{f.Push(JValue.R(rt.String("_")));f.Pc=3338;continue;}
case 3338:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",3341);}
case 3341:{f.Push(JValue.I(1));f.Pc=3342;continue;}
case 3342:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3343;continue;}
case 3343:{return rt.Call(f,"forge/game/card/CardPredicates","isType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",3346);}
case 3346:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",3349);}
case 3349:{f.Locals[6]=f.Pop();f.Pc=3351;continue;}
case 3351:{f.Push(f.Locals[6]);f.Pc=3353;continue;}
case 3353:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",3358);}
case 3358:{f.Locals[7]=f.Pop();f.Pc=3360;continue;}
case 3360:{f.Push(f.Locals[7]);f.Pc=3362;continue;}
case 3362:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3367);}
case 3367:{f.Pc=f.Pop().Int==0?3401:3370;continue;}
case 3370:{f.Push(f.Locals[7]);f.Pc=3372;continue;}
case 3372:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3377);}
case 3377:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3380;continue;}
case 3380:{f.Locals[8]=f.Pop();f.Pc=3382;continue;}
case 3382:{f.Push(f.Locals[0]);f.Pc=3383;continue;}
case 3383:{f.Push(f.Locals[8]);f.Pc=3385;continue;}
case 3385:{return rt.Call(f,"forge/game/player/Player","getCreaturesAttackedThisTurn","(Lforge/game/GameEntity;)Ljava/util/List;","invokevirtual",3388);}
case 3388:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",3393);}
case 3393:{f.Pc=f.Pop().Int!=0?3398:3396;continue;}
case 3396:{f.Push(JValue.I(1));f.Pc=3397;continue;}
case 3397:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3398:{f.Pc=3360;continue;}
case 3401:{f.Push(JValue.I(0));f.Pc=3402;continue;}
case 3402:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3403:{f.Push(f.Locals[1]);f.Pc=3404;continue;}
case 3404:{f.Push(JValue.R(rt.String("attackedYouTheirLastTurn")));f.Pc=3407;continue;}
case 3407:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3410);}
case 3410:{f.Pc=f.Pop().Int==0?3428:3413;continue;}
case 3413:{f.Push(f.Locals[0]);f.Pc=3414;continue;}
case 3414:{return rt.Call(f,"forge/game/player/Player","getAttackedPlayersMyLastTurn","()Ljava/util/List;","invokevirtual",3417);}
case 3417:{f.Push(f.Locals[2]);f.Pc=3418;continue;}
case 3418:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",3423);}
case 3423:{f.Pc=f.Pop().Int!=0?3724:3426;continue;}
case 3426:{f.Push(JValue.I(0));f.Pc=3427;continue;}
case 3427:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3428:{f.Push(f.Locals[1]);f.Pc=3429;continue;}
case 3429:{f.Push(JValue.R(rt.String("BeenAttackedThisCombat")));f.Pc=3432;continue;}
case 3432:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3435);}
case 3435:{f.Pc=f.Pop().Int==0?3491:3438;continue;}
case 3438:{f.Push(f.Locals[5]);f.Pc=3440;continue;}
case 3440:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",3443);}
case 3443:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",3446);}
case 3446:{f.Locals[6]=f.Pop();f.Pc=3448;continue;}
case 3448:{f.Push(f.Locals[6]);f.Pc=3450;continue;}
case 3450:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3455);}
case 3455:{f.Pc=f.Pop().Int==0?3489:3458;continue;}
case 3458:{f.Push(f.Locals[6]);f.Pc=3460;continue;}
case 3460:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3465);}
case 3465:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3468;continue;}
case 3468:{f.Locals[7]=f.Pop();f.Pc=3470;continue;}
case 3470:{f.Push(f.Locals[7]);f.Pc=3472;continue;}
case 3472:{return rt.Call(f,"forge/game/player/Player","getAttackedPlayersMyCombat","()Ljava/util/List;","invokevirtual",3475);}
case 3475:{f.Push(f.Locals[0]);f.Pc=3476;continue;}
case 3476:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",3481);}
case 3481:{f.Pc=f.Pop().Int==0?3486:3484;continue;}
case 3484:{f.Push(JValue.I(1));f.Pc=3485;continue;}
case 3485:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3486:{f.Pc=3448;continue;}
case 3489:{f.Push(JValue.I(0));f.Pc=3490;continue;}
case 3490:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3491:{f.Push(f.Locals[1]);f.Pc=3492;continue;}
case 3492:{f.Push(JValue.R(rt.String("VenturedThisTurn")));f.Pc=3495;continue;}
case 3495:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3498);}
case 3498:{f.Pc=f.Pop().Int==0?3511:3501;continue;}
case 3501:{f.Push(f.Locals[0]);f.Pc=3502;continue;}
case 3502:{return rt.Call(f,"forge/game/player/Player","getVenturedThisTurn","()I","invokevirtual",3505);}
case 3505:{f.Push(JValue.I(1));f.Pc=3506;continue;}
case 3506:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?3724:3509;continue;}
case 3509:{f.Push(JValue.I(0));f.Pc=3510;continue;}
case 3510:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3511:{f.Push(f.Locals[1]);f.Pc=3512;continue;}
case 3512:{f.Push(JValue.R(rt.String("Condition")));f.Pc=3515;continue;}
case 3515:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3518);}
case 3518:{f.Pc=f.Pop().Int==0?3544:3521;continue;}
case 3521:{f.Push(JValue.I(1));f.Pc=3522;continue;}
case 3522:{f.Push(JValue.R(rt.NewArray("Lforge/game/player/Player;",f.Pop().Int)));f.Pc=3525;continue;}
case 3525:{f.StackOp("dup");f.Pc=3526;continue;}
case 3526:{f.Push(JValue.I(0));f.Pc=3527;continue;}
case 3527:{f.Push(f.Locals[0]);f.Pc=3528;continue;}
case 3528:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=3529;continue;}
case 3529:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",3532);}
case 3532:{f.Push(f.Locals[1]);f.Pc=3533;continue;}
case 3533:{f.Push(f.Locals[3]);f.Pc=3534;continue;}
case 3534:{f.Push(f.Locals[4]);f.Pc=3536;continue;}
case 3536:{return rt.Call(f,"forge/game/ability/AbilityUtils","playerXCount","(Ljava/util/List;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)I","invokestatic",3539);}
case 3539:{f.Pc=f.Pop().Int!=0?3724:3542;continue;}
case 3542:{f.Push(JValue.I(0));f.Pc=3543;continue;}
case 3543:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3544:{f.Push(f.Locals[1]);f.Pc=3545;continue;}
case 3545:{f.Push(JValue.R(rt.String("NotedFor")));f.Pc=3548;continue;}
case 3548:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3551);}
case 3551:{f.Pc=f.Pop().Int==0?3642:3554;continue;}
case 3554:{f.Push(f.Locals[1]);f.Pc=3555;continue;}
case 3555:{f.Push(JValue.R(rt.String("NotedFor")));f.Pc=3558;continue;}
case 3558:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",3561);}
case 3561:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",3564);}
case 3564:{f.Locals[6]=f.Pop();f.Pc=3566;continue;}
case 3566:{f.Push(f.Locals[0]);f.Pc=3567;continue;}
case 3567:{f.Push(f.Locals[6]);f.Pc=3569;continue;}
case 3569:{return rt.Call(f,"forge/game/player/Player","getNotesForName","(Ljava/lang/String;)Lforge/util/collect/FCollection;","invokevirtual",3572);}
case 3572:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",3575);}
case 3575:{f.Locals[7]=f.Pop();f.Pc=3577;continue;}
case 3577:{f.Push(f.Locals[7]);f.Pc=3579;continue;}
case 3579:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3584);}
case 3584:{f.Pc=f.Pop().Int==0?3640:3587;continue;}
case 3587:{f.Push(f.Locals[7]);f.Pc=3589;continue;}
case 3589:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3594);}
case 3594:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3597;continue;}
case 3597:{f.Locals[8]=f.Pop();f.Pc=3599;continue;}
case 3599:{f.Push(f.Locals[8]);f.Pc=3601;continue;}
case 3601:{f.Push(f.Locals[3]);f.Pc=3602;continue;}
case 3602:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",3605);}
case 3605:{return rt.DynamicCall(f,"forge/game/player/PlayerProperty:8668:3605:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",3610);}
case 3610:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3613);}
case 3613:{f.Pc=f.Pop().Int==0?3618:3616;continue;}
case 3616:{f.Push(JValue.I(1));f.Pc=3617;continue;}
case 3617:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3618:{f.Push(f.Locals[8]);f.Pc=3620;continue;}
case 3620:{f.Push(f.Locals[3]);f.Pc=3621;continue;}
case 3621:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",3624);}
case 3624:{return rt.DynamicCall(f,"forge/game/player/PlayerProperty:8668:3624:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",3629);}
case 3629:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3632);}
case 3632:{f.Pc=f.Pop().Int==0?3637:3635;continue;}
case 3635:{f.Push(JValue.I(1));f.Pc=3636;continue;}
case 3636:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3637:{f.Pc=3577;continue;}
case 3640:{f.Push(JValue.I(0));f.Pc=3641;continue;}
case 3641:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3642:{f.Push(f.Locals[1]);f.Pc=3643;continue;}
case 3643:{f.Push(JValue.R(rt.String("counters")));f.Pc=3646;continue;}
case 3646:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3649);}
case 3649:{f.Pc=f.Pop().Int==0?3722:3652;continue;}
case 3652:{f.Push(f.Locals[1]);f.Pc=3653;continue;}
case 3653:{f.Push(JValue.R(rt.String("_")));f.Pc=3656;continue;}
case 3656:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",3659);}
case 3659:{f.Locals[6]=f.Pop();f.Pc=3661;continue;}
case 3661:{f.Push(f.Locals[6]);f.Pc=3663;continue;}
case 3663:{f.Push(JValue.I(1));f.Pc=3664;continue;}
case 3664:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3665;continue;}
case 3665:{f.Push(JValue.I(2));f.Pc=3666;continue;}
case 3666:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",3669);}
case 3669:{f.Locals[7]=f.Pop();f.Pc=3671;continue;}
case 3671:{f.Push(f.Locals[6]);f.Pc=3673;continue;}
case 3673:{f.Push(JValue.I(1));f.Pc=3674;continue;}
case 3674:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3675;continue;}
case 3675:{f.Push(JValue.I(0));f.Pc=3676;continue;}
case 3676:{f.Push(JValue.I(2));f.Pc=3677;continue;}
case 3677:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",3680);}
case 3680:{f.Locals[8]=f.Pop();f.Pc=3682;continue;}
case 3682:{f.Push(f.Locals[3]);f.Pc=3683;continue;}
case 3683:{f.Push(f.Locals[7]);f.Pc=3685;continue;}
case 3685:{f.Push(f.Locals[4]);f.Pc=3687;continue;}
case 3687:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",3690);}
case 3690:{f.Locals[9]=f.Pop();f.Pc=3692;continue;}
case 3692:{f.Push(f.Locals[0]);f.Pc=3693;continue;}
case 3693:{f.Push(f.Locals[6]);f.Pc=3695;continue;}
case 3695:{f.Push(JValue.I(2));f.Pc=3696;continue;}
case 3696:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3697;continue;}
case 3697:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",3700);}
case 3700:{return rt.Call(f,"forge/game/player/Player","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",3703);}
case 3703:{f.Locals[10]=f.Pop();f.Pc=3705;continue;}
case 3705:{f.Push(f.Locals[10]);f.Pc=3707;continue;}
case 3707:{f.Push(f.Locals[8]);f.Pc=3709;continue;}
case 3709:{f.Push(f.Locals[9]);f.Pc=3711;continue;}
case 3711:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",3714);}
case 3714:{f.Pc=f.Pop().Int!=0?3719:3717;continue;}
case 3717:{f.Push(JValue.I(0));f.Pc=3718;continue;}
case 3718:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3719:{f.Pc=3724;continue;}
case 3722:{f.Push(JValue.I(0));f.Pc=3723;continue;}
case 3723:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3724:{f.Push(JValue.I(1));f.Pc=3725;continue;}
case 3725:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8669(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("You")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?11:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",21);}
case 21:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

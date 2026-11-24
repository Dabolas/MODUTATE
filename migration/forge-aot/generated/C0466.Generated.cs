// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C466{
internal static JClass Build(){var c=new JClass("forge/game/card/CardProperty","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(5250,"forge/game/card/CardProperty","<init>","()V",1,1,1,new JHandler[]{},M5250));
c.Add(new JMethod(5251,"forge/game/card/CardProperty","cardHasProperty","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z",9,20,8,new JHandler[]{},M5251));
c.Add(new JMethod(5252,"forge/game/card/CardProperty","hasTimestampMatch","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;)Z",10,5,2,new JHandler[]{},M5252));
c.Add(new JMethod(5253,"forge/game/card/CardProperty","lambda$cardHasProperty$1","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M5253));
c.Add(new JMethod(5254,"forge/game/card/CardProperty","lambda$cardHasProperty$0","(Lforge/game/card/sticker/StickerKind;Lforge/game/card/sticker/AppliedSticker;)Z",4106,2,2,new JHandler[]{},M5254));
}

internal static JStep M5250(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5251(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",11);}
case 11:{f.Locals[6]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[5]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",19);}
case 19:{f.Locals[7]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[7]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",26);}
case 26:{f.Locals[8]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?56:35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("phasedOut")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?54:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(9));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",50);}
case 50:{f.Locals[1]=f.Pop();f.Pc=51;continue;}
case 51:{f.Pc=56;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("noName")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?74:65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/Card","hasNoName","()Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int!=0?14247:72;continue;}
case 72:{f.Push(JValue.I(0));f.Pc=73;continue;}
case 73:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("named")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?122:83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(JValue.I(5));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",88);}
case 88:{f.Push(JValue.R(rt.String(";")));f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String(",")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",95);}
case 95:{f.Locals[9]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[9]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("_")));f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String(" ")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",106);}
case 106:{f.Locals[9]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[9]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/Card","sharesNameWith","(Ljava/lang/String;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int!=0?119:117;continue;}
case 117:{f.Push(JValue.I(0));f.Pc=118;continue;}
case 118:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 119:{f.Pc=14247;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String("NamedCard")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?188:131;continue;}
case 131:{f.Push(JValue.I(0));f.Pc=132;continue;}
case 132:{f.Locals[9]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/card/Card","getNamedCards","()Ljava/util/List;","invokevirtual",138);}
case 138:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",143);}
case 143:{f.Locals[10]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[10]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",152);}
case 152:{f.Pc=f.Pop().Int==0?185:155;continue;}
case 155:{f.Push(f.Locals[10]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",162);}
case 162:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=165;continue;}
case 165:{f.Locals[11]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[11]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/card/Card","sharesNameWith","(Ljava/lang/String;)Z","invokevirtual",173);}
case 173:{f.Pc=f.Pop().Int==0?182:176;continue;}
case 176:{f.Push(JValue.I(1));f.Pc=177;continue;}
case 177:{f.Locals[9]=f.Pop();f.Pc=179;continue;}
case 179:{f.Pc=185;continue;}
case 182:{f.Pc=145;continue;}
case 185:{f.Push(f.Locals[9]);f.Pc=187;continue;}
case 187:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 188:{f.Push(f.Locals[1]);f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.String("NamedByRememberedPlayer")));f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",194);}
case 194:{f.Pc=f.Pop().Int==0?262:197;continue;}
case 197:{f.Push(f.Locals[3]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",201);}
case 201:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",206);}
case 206:{f.Locals[9]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[9]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",215);}
case 215:{f.Pc=f.Pop().Int==0?259:218;continue;}
case 218:{f.Push(f.Locals[9]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",225);}
case 225:{f.Locals[10]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[10]);f.Pc=229;continue;}
case 229:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=232;continue;}
case 232:{f.Pc=f.Pop().Int==0?256:235;continue;}
case 235:{f.Push(f.Locals[10]);f.Pc=237;continue;}
case 237:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=240;continue;}
case 240:{f.Locals[11]=f.Pop();f.Pc=242;continue;}
case 242:{f.Push(f.Locals[0]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[11]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/player/Player","getNamedCard","()Ljava/lang/String;","invokevirtual",248);}
case 248:{return rt.Call(f,"forge/game/card/Card","sharesNameWith","(Ljava/lang/String;)Z","invokevirtual",251);}
case 251:{f.Pc=f.Pop().Int!=0?256:254;continue;}
case 254:{f.Push(JValue.I(0));f.Pc=255;continue;}
case 255:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 256:{f.Pc=208;continue;}
case 259:{f.Pc=14247;continue;}
case 262:{f.Push(f.Locals[1]);f.Pc=263;continue;}
case 263:{f.Push(JValue.R(rt.String("BorderColor")));f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",268);}
case 268:{f.Pc=f.Pop().Int==0?290:271;continue;}
case 271:{f.Push(f.Locals[1]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",275);}
case 275:{f.Push(f.Locals[0]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/card/Card","borderColor","()Lforge/card/CardEdition$BorderColor;","invokevirtual",279);}
case 279:{return rt.Call(f,"forge/card/CardEdition$BorderColor","toString","()Ljava/lang/String;","invokevirtual",282);}
case 282:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",285);}
case 285:{f.Pc=f.Pop().Int!=0?14247:288;continue;}
case 288:{f.Push(JValue.I(0));f.Pc=289;continue;}
case 289:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 290:{f.Push(f.Locals[1]);f.Pc=291;continue;}
case 291:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",296);}
case 296:{f.Pc=f.Pop().Int==0?308:299;continue;}
case 299:{f.Push(f.Locals[0]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",303);}
case 303:{f.Pc=f.Pop().Int!=0?14247:306;continue;}
case 306:{f.Push(JValue.I(0));f.Pc=307;continue;}
case 307:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 308:{f.Push(f.Locals[1]);f.Pc=309;continue;}
case 309:{f.Push(JValue.R(rt.String("Historic")));f.Pc=311;continue;}
case 311:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",314);}
case 314:{f.Pc=f.Pop().Int==0?326:317;continue;}
case 317:{f.Push(f.Locals[0]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/card/Card","isHistoric","()Z","invokevirtual",321);}
case 321:{f.Pc=f.Pop().Int!=0?14247:324;continue;}
case 324:{f.Push(JValue.I(0));f.Pc=325;continue;}
case 325:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 326:{f.Push(f.Locals[1]);f.Pc=327;continue;}
case 327:{f.Push(JValue.R(rt.String("CardUID_")));f.Pc=329;continue;}
case 329:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",332);}
case 332:{f.Pc=f.Pop().Int==0?355:335;continue;}
case 335:{f.Push(f.Locals[0]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",339);}
case 339:{f.Push(f.Locals[1]);f.Pc=340;continue;}
case 340:{f.Push(JValue.R(rt.String("CardUID_")));f.Pc=342;continue;}
case 342:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",345);}
case 345:{f.Push(JValue.I(1));f.Pc=346;continue;}
case 346:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=347;continue;}
case 347:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",350);}
case 350:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?14247:353;continue;}
case 353:{f.Push(JValue.I(0));f.Pc=354;continue;}
case 354:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 355:{f.Push(f.Locals[1]);f.Pc=356;continue;}
case 356:{f.Push(JValue.R(rt.String("ChosenCard")));f.Pc=358;continue;}
case 358:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",361);}
case 361:{f.Pc=f.Pop().Int==0?421:364;continue;}
case 364:{f.Push(f.Locals[3]);f.Pc=365;continue;}
case 365:{return rt.Call(f,"forge/game/card/Card","getChosenCards","()Lforge/game/card/CardCollectionView;","invokevirtual",368);}
case 368:{f.Locals[9]=f.Pop();f.Pc=370;continue;}
case 370:{f.Push(f.Locals[9]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[0]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/card/CardCollectionView","indexOf","(Ljava/lang/Object;)I","invokeinterface",378);}
case 378:{f.Locals[10]=f.Pop();f.Pc=380;continue;}
case 380:{f.Push(f.Locals[10]);f.Pc=382;continue;}
case 382:{f.Push(JValue.I(-1));f.Pc=383;continue;}
case 383:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?388:386;continue;}
case 386:{f.Push(JValue.I(0));f.Pc=387;continue;}
case 387:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 388:{f.Push(f.Locals[1]);f.Pc=389;continue;}
case 389:{f.Push(JValue.R(rt.String("Strict")));f.Pc=391;continue;}
case 391:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",394);}
case 394:{f.Pc=f.Pop().Int==0?418:397;continue;}
case 397:{f.Push(f.Locals[9]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[10]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",406);}
case 406:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=409;continue;}
case 409:{f.Push(f.Locals[0]);f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",413);}
case 413:{f.Pc=f.Pop().Int!=0?418:416;continue;}
case 416:{f.Push(JValue.I(0));f.Pc=417;continue;}
case 417:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 418:{f.Pc=14247;continue;}
case 421:{f.Push(f.Locals[1]);f.Pc=422;continue;}
case 422:{f.Push(JValue.R(rt.String("nonChosenCard")));f.Pc=424;continue;}
case 424:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",427);}
case 427:{f.Pc=f.Pop().Int==0?440:430;continue;}
case 430:{f.Push(f.Locals[3]);f.Pc=431;continue;}
case 431:{f.Push(f.Locals[0]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"forge/game/card/Card","hasChosenCard","(Lforge/game/card/Card;)Z","invokevirtual",435);}
case 435:{f.Pc=f.Pop().Int==0?14247:438;continue;}
case 438:{f.Push(JValue.I(0));f.Pc=439;continue;}
case 439:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 440:{f.Push(f.Locals[1]);f.Pc=441;continue;}
case 441:{f.Push(JValue.R(rt.String("ChosenMode")));f.Pc=443;continue;}
case 443:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",446);}
case 446:{f.Pc=f.Pop().Int==0?467:449;continue;}
case 449:{f.Push(f.Locals[0]);f.Pc=450;continue;}
case 450:{return rt.Call(f,"forge/game/card/Card","getChosenMode","()Ljava/lang/String;","invokevirtual",453);}
case 453:{f.Push(f.Locals[1]);f.Pc=454;continue;}
case 454:{f.Push(JValue.I(10));f.Pc=456;continue;}
case 456:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",459);}
case 459:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",462);}
case 462:{f.Pc=f.Pop().Int!=0?14247:465;continue;}
case 465:{f.Push(JValue.I(0));f.Pc=466;continue;}
case 466:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 467:{f.Push(f.Locals[1]);f.Pc=468;continue;}
case 468:{f.Push(JValue.R(rt.String("ChosenSector")));f.Pc=470;continue;}
case 470:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",473);}
case 473:{f.Pc=f.Pop().Int==0?492:476;continue;}
case 476:{f.Push(f.Locals[3]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/card/Card","getChosenSector","()Ljava/lang/String;","invokevirtual",480);}
case 480:{f.Push(f.Locals[0]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"forge/game/card/Card","getSector","()Ljava/lang/String;","invokevirtual",484);}
case 484:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",487);}
case 487:{f.Pc=f.Pop().Int!=0?14247:490;continue;}
case 490:{f.Push(JValue.I(0));f.Pc=491;continue;}
case 491:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 492:{f.Push(f.Locals[1]);f.Pc=493;continue;}
case 493:{f.Push(JValue.R(rt.String("DifferentSector")));f.Pc=495;continue;}
case 495:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",498);}
case 498:{f.Pc=f.Pop().Int==0?517:501;continue;}
case 501:{f.Push(f.Locals[3]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/card/Card","getSector","()Ljava/lang/String;","invokevirtual",505);}
case 505:{f.Push(f.Locals[0]);f.Pc=506;continue;}
case 506:{return rt.Call(f,"forge/game/card/Card","getSector","()Ljava/lang/String;","invokevirtual",509);}
case 509:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",512);}
case 512:{f.Pc=f.Pop().Int==0?14247:515;continue;}
case 515:{f.Push(JValue.I(0));f.Pc=516;continue;}
case 516:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 517:{f.Push(f.Locals[1]);f.Pc=518;continue;}
case 518:{f.Push(JValue.R(rt.String("DoubleFaced")));f.Pc=520;continue;}
case 520:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",523);}
case 523:{f.Pc=f.Pop().Int==0?535:526;continue;}
case 526:{f.Push(f.Locals[0]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/card/Card","isDoubleFaced","()Z","invokevirtual",530);}
case 530:{f.Pc=f.Pop().Int!=0?14247:533;continue;}
case 533:{f.Push(JValue.I(0));f.Pc=534;continue;}
case 534:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 535:{f.Push(f.Locals[1]);f.Pc=536;continue;}
case 536:{f.Push(JValue.R(rt.String("FrontSide")));f.Pc=538;continue;}
case 538:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",541);}
case 541:{f.Pc=f.Pop().Int==0?553:544;continue;}
case 544:{f.Push(f.Locals[0]);f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/game/card/Card","isBackSide","()Z","invokevirtual",548);}
case 548:{f.Pc=f.Pop().Int==0?14247:551;continue;}
case 551:{f.Push(JValue.I(0));f.Pc=552;continue;}
case 552:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 553:{f.Push(f.Locals[1]);f.Pc=554;continue;}
case 554:{f.Push(JValue.R(rt.String("BackSide")));f.Pc=556;continue;}
case 556:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",559);}
case 559:{f.Pc=f.Pop().Int==0?571:562;continue;}
case 562:{f.Push(f.Locals[0]);f.Pc=563;continue;}
case 563:{return rt.Call(f,"forge/game/card/Card","isBackSide","()Z","invokevirtual",566);}
case 566:{f.Pc=f.Pop().Int!=0?14247:569;continue;}
case 569:{f.Push(JValue.I(0));f.Pc=570;continue;}
case 570:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 571:{f.Push(f.Locals[1]);f.Pc=572;continue;}
case 572:{f.Push(JValue.R(rt.String("CanTransform")));f.Pc=574;continue;}
case 574:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",577);}
case 577:{f.Pc=f.Pop().Int==0?589:580;continue;}
case 580:{f.Push(f.Locals[0]);f.Pc=581;continue;}
case 581:{return rt.Call(f,"forge/game/card/Card","isTransformable","()Z","invokevirtual",584);}
case 584:{f.Pc=f.Pop().Int!=0?14247:587;continue;}
case 587:{f.Push(JValue.I(0));f.Pc=588;continue;}
case 588:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 589:{f.Push(f.Locals[1]);f.Pc=590;continue;}
case 590:{f.Push(JValue.R(rt.String("Transformed")));f.Pc=592;continue;}
case 592:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",595);}
case 595:{f.Pc=f.Pop().Int==0?607:598;continue;}
case 598:{f.Push(f.Locals[0]);f.Pc=599;continue;}
case 599:{return rt.Call(f,"forge/game/card/Card","isTransformed","()Z","invokevirtual",602);}
case 602:{f.Pc=f.Pop().Int!=0?14247:605;continue;}
case 605:{f.Push(JValue.I(0));f.Pc=606;continue;}
case 606:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 607:{f.Push(f.Locals[1]);f.Pc=608;continue;}
case 608:{f.Push(JValue.R(rt.String("Flip")));f.Pc=610;continue;}
case 610:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",613);}
case 613:{f.Pc=f.Pop().Int==0?625:616;continue;}
case 616:{f.Push(f.Locals[0]);f.Pc=617;continue;}
case 617:{return rt.Call(f,"forge/game/card/Card","isFlipCard","()Z","invokevirtual",620);}
case 620:{f.Pc=f.Pop().Int!=0?14247:623;continue;}
case 623:{f.Push(JValue.I(0));f.Pc=624;continue;}
case 624:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 625:{f.Push(f.Locals[1]);f.Pc=626;continue;}
case 626:{f.Push(JValue.R(rt.String("Split")));f.Pc=628;continue;}
case 628:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",631);}
case 631:{f.Pc=f.Pop().Int==0?643:634;continue;}
case 634:{f.Push(f.Locals[0]);f.Pc=635;continue;}
case 635:{return rt.Call(f,"forge/game/card/Card","isSplitCard","()Z","invokevirtual",638);}
case 638:{f.Pc=f.Pop().Int!=0?14247:641;continue;}
case 641:{f.Push(JValue.I(0));f.Pc=642;continue;}
case 642:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 643:{f.Push(f.Locals[1]);f.Pc=644;continue;}
case 644:{f.Push(JValue.R(rt.String("AdventureCard")));f.Pc=646;continue;}
case 646:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",649);}
case 649:{f.Pc=f.Pop().Int==0?661:652;continue;}
case 652:{f.Push(f.Locals[0]);f.Pc=653;continue;}
case 653:{return rt.Call(f,"forge/game/card/Card","isAdventureCard","()Z","invokevirtual",656);}
case 656:{f.Pc=f.Pop().Int!=0?14247:659;continue;}
case 659:{f.Push(JValue.I(0));f.Pc=660;continue;}
case 660:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 661:{f.Push(f.Locals[1]);f.Pc=662;continue;}
case 662:{f.Push(JValue.R(rt.String("IsRingbearer")));f.Pc=664;continue;}
case 664:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",667);}
case 667:{f.Pc=f.Pop().Int==0?679:670;continue;}
case 670:{f.Push(f.Locals[0]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/game/card/Card","isRingBearer","()Z","invokevirtual",674);}
case 674:{f.Pc=f.Pop().Int!=0?14247:677;continue;}
case 677:{f.Push(JValue.I(0));f.Pc=678;continue;}
case 678:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 679:{f.Push(f.Locals[1]);f.Pc=680;continue;}
case 680:{f.Push(JValue.R(rt.String("IsTriggerRemembered")));f.Pc=682;continue;}
case 682:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",685);}
case 685:{f.Pc=f.Pop().Int==0?765:688;continue;}
case 688:{f.Push(JValue.I(0));f.Pc=689;continue;}
case 689:{f.Locals[9]=f.Pop();f.Pc=691;continue;}
case 691:{f.Push(f.Locals[4]);f.Pc=693;continue;}
case 693:{return rt.Call(f,"forge/game/CardTraitBase","getTriggerRemembered","()Ljava/util/List;","invokevirtual",696);}
case 696:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",701);}
case 701:{f.Locals[10]=f.Pop();f.Pc=703;continue;}
case 703:{f.Push(f.Locals[10]);f.Pc=705;continue;}
case 705:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",710);}
case 710:{f.Pc=f.Pop().Int==0?755:713;continue;}
case 713:{f.Push(f.Locals[10]);f.Pc=715;continue;}
case 715:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",720);}
case 720:{f.Locals[11]=f.Pop();f.Pc=722;continue;}
case 722:{f.Push(f.Locals[11]);f.Pc=724;continue;}
case 724:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=727;continue;}
case 727:{f.Pc=f.Pop().Int==0?752:730;continue;}
case 730:{f.Push(f.Locals[11]);f.Pc=732;continue;}
case 732:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=735;continue;}
case 735:{f.Locals[12]=f.Pop();f.Pc=737;continue;}
case 737:{f.Push(f.Locals[12]);f.Pc=739;continue;}
case 739:{f.Push(f.Locals[0]);f.Pc=740;continue;}
case 740:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",743);}
case 743:{f.Pc=f.Pop().Int==0?752:746;continue;}
case 746:{f.Push(JValue.I(1));f.Pc=747;continue;}
case 747:{f.Locals[9]=f.Pop();f.Pc=749;continue;}
case 749:{f.Pc=755;continue;}
case 752:{f.Pc=703;continue;}
case 755:{f.Push(f.Locals[9]);f.Pc=757;continue;}
case 757:{f.Pc=f.Pop().Int!=0?762:760;continue;}
case 760:{f.Push(JValue.I(0));f.Pc=761;continue;}
case 761:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 762:{f.Pc=14247;continue;}
case 765:{f.Push(f.Locals[1]);f.Pc=766;continue;}
case 766:{f.Push(JValue.R(rt.String("YouCtrl")));f.Pc=768;continue;}
case 768:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",771);}
case 771:{f.Pc=f.Pop().Int==0?785:774;continue;}
case 774:{f.Push(f.Locals[8]);f.Pc=776;continue;}
case 776:{f.Push(f.Locals[2]);f.Pc=777;continue;}
case 777:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",780);}
case 780:{f.Pc=f.Pop().Int!=0?14247:783;continue;}
case 783:{f.Push(JValue.I(0));f.Pc=784;continue;}
case 784:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 785:{f.Push(f.Locals[1]);f.Pc=786;continue;}
case 786:{f.Push(JValue.R(rt.String("YourTeamCtrl")));f.Pc=788;continue;}
case 788:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",791);}
case 791:{f.Pc=f.Pop().Int==0?808:794;continue;}
case 794:{f.Push(f.Locals[8]);f.Pc=796;continue;}
case 796:{return rt.Call(f,"forge/game/player/Player","getTeam","()I","invokevirtual",799);}
case 799:{f.Push(f.Locals[2]);f.Pc=800;continue;}
case 800:{return rt.Call(f,"forge/game/player/Player","getTeam","()I","invokevirtual",803);}
case 803:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?14247:806;continue;}
case 806:{f.Push(JValue.I(0));f.Pc=807;continue;}
case 807:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 808:{f.Push(f.Locals[1]);f.Pc=809;continue;}
case 809:{f.Push(JValue.R(rt.String("YouDontCtrl")));f.Pc=811;continue;}
case 811:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",814);}
case 814:{f.Pc=f.Pop().Int==0?828:817;continue;}
case 817:{f.Push(f.Locals[8]);f.Pc=819;continue;}
case 819:{f.Push(f.Locals[2]);f.Pc=820;continue;}
case 820:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",823);}
case 823:{f.Pc=f.Pop().Int==0?14247:826;continue;}
case 826:{f.Push(JValue.I(0));f.Pc=827;continue;}
case 827:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 828:{f.Push(f.Locals[1]);f.Pc=829;continue;}
case 829:{f.Push(JValue.R(rt.String("OppCtrl")));f.Pc=831;continue;}
case 831:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",834);}
case 834:{f.Pc=f.Pop().Int==0?851:837;continue;}
case 837:{f.Push(f.Locals[8]);f.Pc=839;continue;}
case 839:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",842);}
case 842:{f.Push(f.Locals[2]);f.Pc=843;continue;}
case 843:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",846);}
case 846:{f.Pc=f.Pop().Int!=0?14247:849;continue;}
case 849:{f.Push(JValue.I(0));f.Pc=850;continue;}
case 850:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 851:{f.Push(f.Locals[1]);f.Pc=852;continue;}
case 852:{f.Push(JValue.R(rt.String("ChosenCtrl")));f.Pc=855;continue;}
case 855:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",858);}
case 858:{f.Pc=f.Pop().Int==0?875:861;continue;}
case 861:{f.Push(f.Locals[8]);f.Pc=863;continue;}
case 863:{f.Push(f.Locals[3]);f.Pc=864;continue;}
case 864:{return rt.Call(f,"forge/game/card/Card","getChosenPlayer","()Lforge/game/player/Player;","invokevirtual",867);}
case 867:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",870);}
case 870:{f.Pc=f.Pop().Int!=0?14247:873;continue;}
case 873:{f.Push(JValue.I(0));f.Pc=874;continue;}
case 874:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 875:{f.Push(f.Locals[1]);f.Pc=876;continue;}
case 876:{f.Push(JValue.R(rt.String("DefenderCtrl")));f.Pc=879;continue;}
case 879:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",882);}
case 882:{f.Pc=f.Pop().Int==0?949:885;continue;}
case 885:{f.Push(f.Locals[5]);f.Pc=887;continue;}
case 887:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",890);}
case 890:{return rt.Call(f,"forge/game/phase/PhaseHandler","inCombat","()Z","invokevirtual",893);}
case 893:{f.Pc=f.Pop().Int!=0?898:896;continue;}
case 896:{f.Push(JValue.I(0));f.Pc=897;continue;}
case 897:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 898:{f.Push(f.Locals[1]);f.Pc=899;continue;}
case 899:{f.Push(JValue.R(rt.String("ForRemembered")));f.Pc=902;continue;}
case 902:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",905);}
case 905:{f.Pc=f.Pop().Int==0?936:908;continue;}
case 908:{f.Push(f.Locals[3]);f.Pc=909;continue;}
case 909:{return rt.Call(f,"forge/game/card/Card","hasRemembered","()Z","invokevirtual",912);}
case 912:{f.Pc=f.Pop().Int!=0?917:915;continue;}
case 915:{f.Push(JValue.I(0));f.Pc=916;continue;}
case 916:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 917:{f.Push(f.Locals[6]);f.Pc=919;continue;}
case 919:{f.Push(f.Locals[3]);f.Pc=920;continue;}
case 920:{return rt.Call(f,"forge/game/card/Card","getFirstRemembered","()Ljava/lang/Object;","invokevirtual",923);}
case 923:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=926;continue;}
case 926:{return rt.Call(f,"forge/game/combat/Combat","getDefendingPlayerRelatedTo","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",929);}
case 929:{f.Push(f.Locals[8]);f.Pc=931;continue;}
case 931:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?14247:934;continue;}
case 934:{f.Push(JValue.I(0));f.Pc=935;continue;}
case 935:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 936:{f.Push(f.Locals[6]);f.Pc=938;continue;}
case 938:{f.Push(f.Locals[3]);f.Pc=939;continue;}
case 939:{return rt.Call(f,"forge/game/combat/Combat","getDefendingPlayerRelatedTo","(Lforge/game/card/Card;)Lforge/game/player/Player;","invokevirtual",942);}
case 942:{f.Push(f.Locals[8]);f.Pc=944;continue;}
case 944:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?14247:947;continue;}
case 947:{f.Push(JValue.I(0));f.Pc=948;continue;}
case 948:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 949:{f.Push(f.Locals[1]);f.Pc=950;continue;}
case 950:{f.Push(JValue.R(rt.String("OppProtect")));f.Pc=953;continue;}
case 953:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",956);}
case 956:{f.Pc=f.Pop().Int==0?982:959;continue;}
case 959:{f.Push(f.Locals[0]);f.Pc=960;continue;}
case 960:{return rt.Call(f,"forge/game/card/Card","getProtectingPlayer","()Lforge/game/player/Player;","invokevirtual",963);}
case 963:{f.Pc=f.Pop().Reference==null?980:966;continue;}
case 966:{f.Push(f.Locals[2]);f.Pc=967;continue;}
case 967:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",970);}
case 970:{f.Push(f.Locals[0]);f.Pc=971;continue;}
case 971:{return rt.Call(f,"forge/game/card/Card","getProtectingPlayer","()Lforge/game/player/Player;","invokevirtual",974);}
case 974:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",977);}
case 977:{f.Pc=f.Pop().Int!=0?14247:980;continue;}
case 980:{f.Push(JValue.I(0));f.Pc=981;continue;}
case 981:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 982:{f.Push(f.Locals[1]);f.Pc=983;continue;}
case 983:{f.Push(JValue.R(rt.String("ProtectedBy")));f.Pc=986;continue;}
case 986:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",989);}
case 989:{f.Pc=f.Pop().Int==0?1034:992;continue;}
case 992:{f.Push(f.Locals[0]);f.Pc=993;continue;}
case 993:{return rt.Call(f,"forge/game/card/Card","getProtectingPlayer","()Lforge/game/player/Player;","invokevirtual",996);}
case 996:{f.Pc=f.Pop().Reference!=null?1001:999;continue;}
case 999:{f.Push(JValue.I(0));f.Pc=1000;continue;}
case 1000:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1001:{f.Push(f.Locals[3]);f.Pc=1002;continue;}
case 1002:{f.Push(f.Locals[1]);f.Pc=1003;continue;}
case 1003:{f.Push(JValue.I(12));f.Pc=1005;continue;}
case 1005:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1008);}
case 1008:{f.Push(f.Locals[4]);f.Pc=1010;continue;}
case 1010:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1013);}
case 1013:{f.Locals[9]=f.Pop();f.Pc=1015;continue;}
case 1015:{f.Push(f.Locals[9]);f.Pc=1017;continue;}
case 1017:{f.Push(f.Locals[0]);f.Pc=1018;continue;}
case 1018:{return rt.Call(f,"forge/game/card/Card","getProtectingPlayer","()Lforge/game/player/Player;","invokevirtual",1021);}
case 1021:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1026);}
case 1026:{f.Pc=f.Pop().Int!=0?1031:1029;continue;}
case 1029:{f.Push(JValue.I(0));f.Pc=1030;continue;}
case 1030:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1031:{f.Pc=14247;continue;}
case 1034:{f.Push(f.Locals[1]);f.Pc=1035;continue;}
case 1035:{f.Push(JValue.R(rt.String("Defending")));f.Pc=1038;continue;}
case 1038:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1041);}
case 1041:{f.Pc=f.Pop().Int==0?1076:1044;continue;}
case 1044:{f.Push(f.Locals[5]);f.Pc=1046;continue;}
case 1046:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1049);}
case 1049:{f.Pc=f.Pop().Reference==null?1074:1052;continue;}
case 1052:{f.Push(f.Locals[5]);f.Pc=1054;continue;}
case 1054:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1057);}
case 1057:{return rt.Call(f,"forge/game/combat/Combat","getAttackersAndDefenders","()Ljava/util/Map;","invokevirtual",1060);}
case 1060:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",1065);}
case 1065:{f.Push(f.Locals[0]);f.Pc=1066;continue;}
case 1066:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",1071);}
case 1071:{f.Pc=f.Pop().Int!=0?14247:1074;continue;}
case 1074:{f.Push(JValue.I(0));f.Pc=1075;continue;}
case 1075:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1076:{f.Push(f.Locals[1]);f.Pc=1077;continue;}
case 1077:{f.Push(JValue.R(rt.String("DefendingPlayer")));f.Pc=1080;continue;}
case 1080:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1083);}
case 1083:{f.Pc=f.Pop().Int==0?1135:1086;continue;}
case 1086:{f.Push(f.Locals[1]);f.Pc=1087;continue;}
case 1087:{f.Push(JValue.R(rt.String("Ctrl")));f.Pc=1090;continue;}
case 1090:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",1093);}
case 1093:{f.Pc=f.Pop().Int==0?1101:1096;continue;}
case 1096:{f.Push(f.Locals[8]);f.Pc=1098;continue;}
case 1098:{f.Pc=1105;continue;}
case 1101:{f.Push(f.Locals[0]);f.Pc=1102;continue;}
case 1102:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1105);}
case 1105:{f.Locals[9]=f.Pop();f.Pc=1107;continue;}
case 1107:{f.Push(f.Locals[5]);f.Pc=1109;continue;}
case 1109:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",1112);}
case 1112:{return rt.Call(f,"forge/game/phase/PhaseHandler","inCombat","()Z","invokevirtual",1115);}
case 1115:{f.Pc=f.Pop().Int!=0?1120:1118;continue;}
case 1118:{f.Push(JValue.I(0));f.Pc=1119;continue;}
case 1119:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1120:{f.Push(f.Locals[6]);f.Pc=1122;continue;}
case 1122:{f.Push(f.Locals[9]);f.Pc=1124;continue;}
case 1124:{return rt.Call(f,"forge/game/combat/Combat","isPlayerAttacked","(Lforge/game/player/Player;)Z","invokevirtual",1127);}
case 1127:{f.Pc=f.Pop().Int!=0?1132:1130;continue;}
case 1130:{f.Push(JValue.I(0));f.Pc=1131;continue;}
case 1131:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1132:{f.Pc=14247;continue;}
case 1135:{f.Push(f.Locals[1]);f.Pc=1136;continue;}
case 1136:{f.Push(JValue.R(rt.String("EnchantedPlayer")));f.Pc=1139;continue;}
case 1139:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1142);}
case 1142:{f.Pc=f.Pop().Int==0?1197:1145;continue;}
case 1145:{f.Push(f.Locals[1]);f.Pc=1146;continue;}
case 1146:{f.Push(JValue.R(rt.String("Ctrl")));f.Pc=1149;continue;}
case 1149:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",1152);}
case 1152:{f.Pc=f.Pop().Int==0?1160:1155;continue;}
case 1155:{f.Push(f.Locals[8]);f.Pc=1157;continue;}
case 1157:{f.Pc=1164;continue;}
case 1160:{f.Push(f.Locals[0]);f.Pc=1161;continue;}
case 1161:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1164);}
case 1164:{f.Locals[9]=f.Pop();f.Pc=1166;continue;}
case 1166:{f.Push(f.Locals[3]);f.Pc=1167;continue;}
case 1167:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",1170);}
case 1170:{f.Locals[10]=f.Pop();f.Pc=1172;continue;}
case 1172:{f.Push(f.Locals[10]);f.Pc=1174;continue;}
case 1174:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=1177;continue;}
case 1177:{f.Pc=f.Pop().Int==0?1192:1180;continue;}
case 1180:{f.Push(f.Locals[9]);f.Pc=1182;continue;}
case 1182:{f.Push(f.Locals[10]);f.Pc=1184;continue;}
case 1184:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1187);}
case 1187:{f.Pc=f.Pop().Int!=0?1194:1190;continue;}
case 1190:{f.Push(JValue.I(0));f.Pc=1191;continue;}
case 1191:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1192:{f.Push(JValue.I(0));f.Pc=1193;continue;}
case 1193:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1194:{f.Pc=14247;continue;}
case 1197:{f.Push(f.Locals[1]);f.Pc=1198;continue;}
case 1198:{f.Push(JValue.R(rt.String("EnchantedController")));f.Pc=1201;continue;}
case 1201:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1204);}
case 1204:{f.Pc=f.Pop().Int==0?1265:1207;continue;}
case 1207:{f.Push(f.Locals[1]);f.Pc=1208;continue;}
case 1208:{f.Push(JValue.R(rt.String("Ctrl")));f.Pc=1211;continue;}
case 1211:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",1214);}
case 1214:{f.Pc=f.Pop().Int==0?1222:1217;continue;}
case 1217:{f.Push(f.Locals[8]);f.Pc=1219;continue;}
case 1219:{f.Pc=1226;continue;}
case 1222:{f.Push(f.Locals[0]);f.Pc=1223;continue;}
case 1223:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1226);}
case 1226:{f.Locals[9]=f.Pop();f.Pc=1228;continue;}
case 1228:{f.Push(f.Locals[3]);f.Pc=1229;continue;}
case 1229:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",1232);}
case 1232:{f.Locals[10]=f.Pop();f.Pc=1234;continue;}
case 1234:{f.Push(f.Locals[10]);f.Pc=1236;continue;}
case 1236:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1239;continue;}
case 1239:{f.Pc=f.Pop().Int==0?1260:1242;continue;}
case 1242:{f.Push(f.Locals[9]);f.Pc=1244;continue;}
case 1244:{f.Push(f.Locals[10]);f.Pc=1246;continue;}
case 1246:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1249;continue;}
case 1249:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1252);}
case 1252:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1255);}
case 1255:{f.Pc=f.Pop().Int!=0?1262:1258;continue;}
case 1258:{f.Push(JValue.I(0));f.Pc=1259;continue;}
case 1259:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1260:{f.Push(JValue.I(0));f.Pc=1261;continue;}
case 1261:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1262:{f.Pc=14247;continue;}
case 1265:{f.Push(f.Locals[1]);f.Pc=1266;continue;}
case 1266:{f.Push(JValue.R(rt.String("RememberedPlayer")));f.Pc=1269;continue;}
case 1269:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1272);}
case 1272:{f.Pc=f.Pop().Int==0?1337:1275;continue;}
case 1275:{f.Push(f.Locals[1]);f.Pc=1276;continue;}
case 1276:{f.Push(JValue.R(rt.String("Ctrl")));f.Pc=1279;continue;}
case 1279:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",1282);}
case 1282:{f.Pc=f.Pop().Int==0?1290:1285;continue;}
case 1285:{f.Push(f.Locals[8]);f.Pc=1287;continue;}
case 1287:{f.Pc=1294;continue;}
case 1290:{f.Push(f.Locals[0]);f.Pc=1291;continue;}
case 1291:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1294);}
case 1294:{f.Locals[9]=f.Pop();f.Pc=1296;continue;}
case 1296:{f.Push(f.Locals[3]);f.Pc=1297;continue;}
case 1297:{return rt.Call(f,"forge/game/card/Card","hasRemembered","()Z","invokevirtual",1300);}
case 1300:{f.Pc=f.Pop().Int!=0?1323:1303;continue;}
case 1303:{f.Push(f.Locals[5]);f.Pc=1305;continue;}
case 1305:{f.Push(f.Locals[3]);f.Pc=1306;continue;}
case 1306:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",1309);}
case 1309:{f.Locals[10]=f.Pop();f.Pc=1311;continue;}
case 1311:{f.Push(f.Locals[10]);f.Pc=1313;continue;}
case 1313:{f.Push(f.Locals[9]);f.Pc=1315;continue;}
case 1315:{return rt.Call(f,"forge/game/card/Card","isRemembered","(Ljava/lang/Object;)Z","invokevirtual",1318);}
case 1318:{f.Pc=f.Pop().Int!=0?1323:1321;continue;}
case 1321:{f.Push(JValue.I(0));f.Pc=1322;continue;}
case 1322:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1323:{f.Push(f.Locals[3]);f.Pc=1324;continue;}
case 1324:{f.Push(f.Locals[9]);f.Pc=1326;continue;}
case 1326:{return rt.Call(f,"forge/game/card/Card","isRemembered","(Ljava/lang/Object;)Z","invokevirtual",1329);}
case 1329:{f.Pc=f.Pop().Int!=0?1334:1332;continue;}
case 1332:{f.Push(JValue.I(0));f.Pc=1333;continue;}
case 1333:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1334:{f.Pc=14247;continue;}
case 1337:{f.Push(f.Locals[1]);f.Pc=1338;continue;}
case 1338:{f.Push(JValue.R(rt.String("targetedBy")));f.Pc=1341;continue;}
case 1341:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1344);}
case 1344:{f.Pc=f.Pop().Int==0?1384:1347;continue;}
case 1347:{f.Push(f.Locals[4]);f.Pc=1349;continue;}
case 1349:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=1352;continue;}
case 1352:{f.Pc=f.Pop().Int==0?1365:1355;continue;}
case 1355:{f.Push(f.Locals[4]);f.Pc=1357;continue;}
case 1357:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1360;continue;}
case 1360:{f.Locals[9]=f.Pop();f.Pc=1362;continue;}
case 1362:{f.Pc=1367;continue;}
case 1365:{f.Push(JValue.I(0));f.Pc=1366;continue;}
case 1366:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1367:{f.Push(f.Locals[9]);f.Pc=1369;continue;}
case 1369:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1372);}
case 1372:{f.Push(f.Locals[0]);f.Pc=1373;continue;}
case 1373:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTargeting","(Lforge/game/GameObject;)Z","invokevirtual",1376);}
case 1376:{f.Pc=f.Pop().Int!=0?1381:1379;continue;}
case 1379:{f.Push(JValue.I(0));f.Pc=1380;continue;}
case 1380:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1381:{f.Pc=14247;continue;}
case 1384:{f.Push(f.Locals[1]);f.Pc=1385;continue;}
case 1385:{f.Push(JValue.R(rt.String("TargetedPlayerCtrl")));f.Pc=1388;continue;}
case 1388:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1391);}
case 1391:{f.Pc=f.Pop().Int==0?1413:1394;continue;}
case 1394:{f.Push(f.Locals[3]);f.Pc=1395;continue;}
case 1395:{f.Push(JValue.R(rt.String("TargetedPlayer")));f.Pc=1398;continue;}
case 1398:{f.Push(f.Locals[4]);f.Pc=1400;continue;}
case 1400:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1403);}
case 1403:{f.Push(f.Locals[8]);f.Pc=1405;continue;}
case 1405:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",1408);}
case 1408:{f.Pc=f.Pop().Int!=0?14247:1411;continue;}
case 1411:{f.Push(JValue.I(0));f.Pc=1412;continue;}
case 1412:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1413:{f.Push(f.Locals[1]);f.Pc=1414;continue;}
case 1414:{f.Push(JValue.R(rt.String("ActivePlayerCtrl")));f.Pc=1417;continue;}
case 1417:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1420);}
case 1420:{f.Pc=f.Pop().Int==0?1438:1423;continue;}
case 1423:{f.Push(f.Locals[5]);f.Pc=1425;continue;}
case 1425:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",1428);}
case 1428:{f.Push(f.Locals[8]);f.Pc=1430;continue;}
case 1430:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",1433);}
case 1433:{f.Pc=f.Pop().Int!=0?14247:1436;continue;}
case 1436:{f.Push(JValue.I(0));f.Pc=1437;continue;}
case 1437:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1438:{f.Push(f.Locals[1]);f.Pc=1439;continue;}
case 1439:{f.Push(JValue.R(rt.String("YouOwn")));f.Pc=1442;continue;}
case 1442:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1445);}
case 1445:{f.Pc=f.Pop().Int==0?1461:1448;continue;}
case 1448:{f.Push(f.Locals[0]);f.Pc=1449;continue;}
case 1449:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1452);}
case 1452:{f.Push(f.Locals[2]);f.Pc=1453;continue;}
case 1453:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1456);}
case 1456:{f.Pc=f.Pop().Int!=0?14247:1459;continue;}
case 1459:{f.Push(JValue.I(0));f.Pc=1460;continue;}
case 1460:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1461:{f.Push(f.Locals[1]);f.Pc=1462;continue;}
case 1462:{f.Push(JValue.R(rt.String("YouDontOwn")));f.Pc=1465;continue;}
case 1465:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1468);}
case 1468:{f.Pc=f.Pop().Int==0?1484:1471;continue;}
case 1471:{f.Push(f.Locals[0]);f.Pc=1472;continue;}
case 1472:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1475);}
case 1475:{f.Push(f.Locals[2]);f.Pc=1476;continue;}
case 1476:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1479);}
case 1479:{f.Pc=f.Pop().Int==0?14247:1482;continue;}
case 1482:{f.Push(JValue.I(0));f.Pc=1483;continue;}
case 1483:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1484:{f.Push(f.Locals[1]);f.Pc=1485;continue;}
case 1485:{f.Push(JValue.R(rt.String("OppOwn")));f.Pc=1488;continue;}
case 1488:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1491);}
case 1491:{f.Pc=f.Pop().Int==0?1510:1494;continue;}
case 1494:{f.Push(f.Locals[0]);f.Pc=1495;continue;}
case 1495:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1498);}
case 1498:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",1501);}
case 1501:{f.Push(f.Locals[2]);f.Pc=1502;continue;}
case 1502:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",1505);}
case 1505:{f.Pc=f.Pop().Int!=0?14247:1508;continue;}
case 1508:{f.Push(JValue.I(0));f.Pc=1509;continue;}
case 1509:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1510:{f.Push(f.Locals[1]);f.Pc=1511;continue;}
case 1511:{f.Push(JValue.R(rt.String("TargetedPlayerOwn")));f.Pc=1514;continue;}
case 1514:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1517);}
case 1517:{f.Pc=f.Pop().Int==0?1541:1520;continue;}
case 1520:{f.Push(f.Locals[3]);f.Pc=1521;continue;}
case 1521:{f.Push(JValue.R(rt.String("TargetedPlayer")));f.Pc=1524;continue;}
case 1524:{f.Push(f.Locals[4]);f.Pc=1526;continue;}
case 1526:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1529);}
case 1529:{f.Push(f.Locals[0]);f.Pc=1530;continue;}
case 1530:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1533);}
case 1533:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",1536);}
case 1536:{f.Pc=f.Pop().Int!=0?14247:1539;continue;}
case 1539:{f.Push(JValue.I(0));f.Pc=1540;continue;}
case 1540:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1541:{f.Push(f.Locals[1]);f.Pc=1542;continue;}
case 1542:{f.Push(JValue.R(rt.String("OwnedBy")));f.Pc=1545;continue;}
case 1545:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1548);}
case 1548:{f.Pc=f.Pop().Int==0?1604:1551;continue;}
case 1551:{f.Push(f.Locals[1]);f.Pc=1552;continue;}
case 1552:{f.Push(JValue.I(8));f.Pc=1554;continue;}
case 1554:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1557);}
case 1557:{f.Locals[9]=f.Pop();f.Pc=1559;continue;}
case 1559:{f.Push(f.Locals[0]);f.Pc=1560;continue;}
case 1560:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1563);}
case 1563:{f.Push(f.Locals[9]);f.Pc=1565;continue;}
case 1565:{f.Push(f.Locals[2]);f.Pc=1566;continue;}
case 1566:{f.Push(f.Locals[3]);f.Pc=1567;continue;}
case 1567:{f.Push(f.Locals[4]);f.Pc=1569;continue;}
case 1569:{return rt.Call(f,"forge/game/player/Player","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",1572);}
case 1572:{f.Pc=f.Pop().Int!=0?1601:1575;continue;}
case 1575:{f.Push(f.Locals[3]);f.Pc=1576;continue;}
case 1576:{f.Push(f.Locals[9]);f.Pc=1578;continue;}
case 1578:{f.Push(f.Locals[4]);f.Pc=1580;continue;}
case 1580:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1583);}
case 1583:{f.Locals[10]=f.Pop();f.Pc=1585;continue;}
case 1585:{f.Push(f.Locals[10]);f.Pc=1587;continue;}
case 1587:{f.Push(f.Locals[0]);f.Pc=1588;continue;}
case 1588:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1591);}
case 1591:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1596);}
case 1596:{f.Pc=f.Pop().Int!=0?1601:1599;continue;}
case 1599:{f.Push(JValue.I(0));f.Pc=1600;continue;}
case 1600:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1601:{f.Pc=14247;continue;}
case 1604:{f.Push(f.Locals[1]);f.Pc=1605;continue;}
case 1605:{f.Push(JValue.R(rt.String("ControlledBy")));f.Pc=1608;continue;}
case 1608:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1611);}
case 1611:{f.Pc=f.Pop().Int==0?1663:1614;continue;}
case 1614:{f.Push(f.Locals[1]);f.Pc=1615;continue;}
case 1615:{f.Push(JValue.I(13));f.Pc=1617;continue;}
case 1617:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1620);}
case 1620:{f.Locals[9]=f.Pop();f.Pc=1622;continue;}
case 1622:{f.Push(f.Locals[8]);f.Pc=1624;continue;}
case 1624:{f.Push(f.Locals[9]);f.Pc=1626;continue;}
case 1626:{f.Push(f.Locals[2]);f.Pc=1627;continue;}
case 1627:{f.Push(f.Locals[3]);f.Pc=1628;continue;}
case 1628:{f.Push(f.Locals[4]);f.Pc=1630;continue;}
case 1630:{return rt.Call(f,"forge/game/player/Player","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",1633);}
case 1633:{f.Pc=f.Pop().Int!=0?1660:1636;continue;}
case 1636:{f.Push(f.Locals[3]);f.Pc=1637;continue;}
case 1637:{f.Push(f.Locals[9]);f.Pc=1639;continue;}
case 1639:{f.Push(f.Locals[4]);f.Pc=1641;continue;}
case 1641:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1644);}
case 1644:{f.Locals[10]=f.Pop();f.Pc=1646;continue;}
case 1646:{f.Push(f.Locals[10]);f.Pc=1648;continue;}
case 1648:{f.Push(f.Locals[8]);f.Pc=1650;continue;}
case 1650:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1655);}
case 1655:{f.Pc=f.Pop().Int!=0?1660:1658;continue;}
case 1658:{f.Push(JValue.I(0));f.Pc=1659;continue;}
case 1659:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1660:{f.Pc=14247;continue;}
case 1663:{f.Push(f.Locals[1]);f.Pc=1664;continue;}
case 1664:{f.Push(JValue.R(rt.String("OwnerDoesntControl")));f.Pc=1667;continue;}
case 1667:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1670);}
case 1670:{f.Pc=f.Pop().Int==0?1687:1673;continue;}
case 1673:{f.Push(f.Locals[0]);f.Pc=1674;continue;}
case 1674:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1677);}
case 1677:{f.Push(f.Locals[8]);f.Pc=1679;continue;}
case 1679:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1682);}
case 1682:{f.Pc=f.Pop().Int==0?14247:1685;continue;}
case 1685:{f.Push(JValue.I(0));f.Pc=1686;continue;}
case 1686:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1687:{f.Push(f.Locals[1]);f.Pc=1688;continue;}
case 1688:{f.Push(JValue.R(rt.String("ControllerControls")));f.Pc=1691;continue;}
case 1691:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1694);}
case 1694:{f.Pc=f.Pop().Int==0?1957:1697;continue;}
case 1697:{f.Push(f.Locals[1]);f.Pc=1698;continue;}
case 1698:{f.Push(JValue.I(18));f.Pc=1700;continue;}
case 1700:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1703);}
case 1703:{f.Locals[9]=f.Pop();f.Pc=1705;continue;}
case 1705:{f.Push(f.Locals[9]);f.Pc=1707;continue;}
case 1707:{f.Push(JValue.R(rt.String("More")));f.Pc=1710;continue;}
case 1710:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1713);}
case 1713:{f.Pc=f.Pop().Int==0?1779:1716;continue;}
case 1716:{f.Push(f.Locals[9]);f.Pc=1718;continue;}
case 1718:{f.Push(JValue.R(rt.String("More")));f.Pc=1721;continue;}
case 1721:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1724);}
case 1724:{f.Push(JValue.I(1));f.Pc=1725;continue;}
case 1725:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1726;continue;}
case 1726:{f.Locals[10]=f.Pop();f.Pc=1728;continue;}
case 1728:{f.Push(f.Locals[8]);f.Pc=1730;continue;}
case 1730:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1733;continue;}
case 1733:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1736);}
case 1736:{f.Push(f.Locals[10]);f.Pc=1738;continue;}
case 1738:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",1741);}
case 1741:{f.Locals[11]=f.Pop();f.Pc=1743;continue;}
case 1743:{f.Push(f.Locals[2]);f.Pc=1744;continue;}
case 1744:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1747;continue;}
case 1747:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1750);}
case 1750:{f.Push(f.Locals[10]);f.Pc=1752;continue;}
case 1752:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",1755);}
case 1755:{f.Locals[12]=f.Pop();f.Pc=1757;continue;}
case 1757:{f.Push(f.Locals[11]);f.Pc=1759;continue;}
case 1759:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",1764);}
case 1764:{f.Push(f.Locals[12]);f.Pc=1766;continue;}
case 1766:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",1771);}
case 1771:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?1776:1774;continue;}
case 1774:{f.Push(JValue.I(0));f.Pc=1775;continue;}
case 1775:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1776:{f.Pc=1954;continue;}
case 1779:{f.Push(f.Locals[9]);f.Pc=1781;continue;}
case 1781:{f.Push(JValue.R(rt.String("AtLeastAsMany")));f.Pc=1784;continue;}
case 1784:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1787);}
case 1787:{f.Pc=f.Pop().Int==0?1853:1790;continue;}
case 1790:{f.Push(f.Locals[9]);f.Pc=1792;continue;}
case 1792:{f.Push(JValue.R(rt.String("AtLeastAsMany")));f.Pc=1795;continue;}
case 1795:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1798);}
case 1798:{f.Push(JValue.I(1));f.Pc=1799;continue;}
case 1799:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1800;continue;}
case 1800:{f.Locals[10]=f.Pop();f.Pc=1802;continue;}
case 1802:{f.Push(f.Locals[8]);f.Pc=1804;continue;}
case 1804:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1807;continue;}
case 1807:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1810);}
case 1810:{f.Push(f.Locals[10]);f.Pc=1812;continue;}
case 1812:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",1815);}
case 1815:{f.Locals[11]=f.Pop();f.Pc=1817;continue;}
case 1817:{f.Push(f.Locals[2]);f.Pc=1818;continue;}
case 1818:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1821;continue;}
case 1821:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1824);}
case 1824:{f.Push(f.Locals[10]);f.Pc=1826;continue;}
case 1826:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",1829);}
case 1829:{f.Locals[12]=f.Pop();f.Pc=1831;continue;}
case 1831:{f.Push(f.Locals[11]);f.Pc=1833;continue;}
case 1833:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",1838);}
case 1838:{f.Push(f.Locals[12]);f.Pc=1840;continue;}
case 1840:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",1845);}
case 1845:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1850:1848;continue;}
case 1848:{f.Push(JValue.I(0));f.Pc=1849;continue;}
case 1849:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1850:{f.Pc=1954;continue;}
case 1853:{f.Push(f.Locals[8]);f.Pc=1855;continue;}
case 1855:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1858;continue;}
case 1858:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1861);}
case 1861:{f.Locals[10]=f.Pop();f.Pc=1863;continue;}
case 1863:{f.Push(f.Locals[9]);f.Pc=1865;continue;}
case 1865:{f.Push(JValue.R(rt.String("_")));f.Pc=1867;continue;}
case 1867:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1870);}
case 1870:{f.Pc=f.Pop().Int==0?1939:1873;continue;}
case 1873:{f.Push(f.Locals[9]);f.Pc=1875;continue;}
case 1875:{f.Push(JValue.R(rt.String("_")));f.Pc=1877;continue;}
case 1877:{f.Push(JValue.I(2));f.Pc=1878;continue;}
case 1878:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",1881);}
case 1881:{f.Locals[11]=f.Pop();f.Pc=1883;continue;}
case 1883:{f.Push(f.Locals[10]);f.Pc=1885;continue;}
case 1885:{f.Push(f.Locals[11]);f.Pc=1887;continue;}
case 1887:{f.Push(JValue.I(0));f.Pc=1888;continue;}
case 1888:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1889;continue;}
case 1889:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",1892);}
case 1892:{f.Locals[12]=f.Pop();f.Pc=1894;continue;}
case 1894:{f.Push(f.Locals[0]);f.Pc=1895;continue;}
case 1895:{f.Push(f.Locals[11]);f.Pc=1897;continue;}
case 1897:{f.Push(JValue.I(1));f.Pc=1898;continue;}
case 1898:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1899;continue;}
case 1899:{f.Push(JValue.I(2));f.Pc=1900;continue;}
case 1900:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1903);}
case 1903:{f.Push(f.Locals[4]);f.Pc=1905;continue;}
case 1905:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1908);}
case 1908:{f.Locals[13]=f.Pop();f.Pc=1910;continue;}
case 1910:{f.Push(f.Locals[12]);f.Pc=1912;continue;}
case 1912:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",1917);}
case 1917:{f.Push(f.Locals[11]);f.Pc=1919;continue;}
case 1919:{f.Push(JValue.I(1));f.Pc=1920;continue;}
case 1920:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1921;continue;}
case 1921:{f.Push(JValue.I(0));f.Pc=1922;continue;}
case 1922:{f.Push(JValue.I(2));f.Pc=1923;continue;}
case 1923:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",1926);}
case 1926:{f.Push(f.Locals[13]);f.Pc=1928;continue;}
case 1928:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1931);}
case 1931:{f.Pc=f.Pop().Int!=0?1936:1934;continue;}
case 1934:{f.Push(JValue.I(0));f.Pc=1935;continue;}
case 1935:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1936:{f.Pc=1954;continue;}
case 1939:{f.Push(f.Locals[10]);f.Pc=1941;continue;}
case 1941:{f.Push(f.Locals[9]);f.Pc=1943;continue;}
case 1943:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",1946);}
case 1946:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1949);}
case 1949:{f.Pc=f.Pop().Int==0?1954:1952;continue;}
case 1952:{f.Push(JValue.I(0));f.Pc=1953;continue;}
case 1953:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1954:{f.Pc=14247;continue;}
case 1957:{f.Push(f.Locals[1]);f.Pc=1958;continue;}
case 1958:{f.Push(JValue.R(rt.String("StrictlyOther")));f.Pc=1961;continue;}
case 1961:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1964);}
case 1964:{f.Pc=f.Pop().Int==0?1977:1967;continue;}
case 1967:{f.Push(f.Locals[0]);f.Pc=1968;continue;}
case 1968:{f.Push(f.Locals[3]);f.Pc=1969;continue;}
case 1969:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",1972);}
case 1972:{f.Pc=f.Pop().Int==0?14247:1975;continue;}
case 1975:{f.Push(JValue.I(0));f.Pc=1976;continue;}
case 1976:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1977:{f.Push(f.Locals[1]);f.Pc=1978;continue;}
case 1978:{f.Push(JValue.R(rt.String("Other")));f.Pc=1981;continue;}
case 1981:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1984);}
case 1984:{f.Pc=f.Pop().Int==0?1997:1987;continue;}
case 1987:{f.Push(f.Locals[0]);f.Pc=1988;continue;}
case 1988:{f.Push(f.Locals[3]);f.Pc=1989;continue;}
case 1989:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",1992);}
case 1992:{f.Pc=f.Pop().Int==0?14247:1995;continue;}
case 1995:{f.Push(JValue.I(0));f.Pc=1996;continue;}
case 1996:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1997:{f.Push(f.Locals[1]);f.Pc=1998;continue;}
case 1998:{f.Push(JValue.R(rt.String("StrictlySelf")));f.Pc=2001;continue;}
case 2001:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2004);}
case 2004:{f.Pc=f.Pop().Int==0?2017:2007;continue;}
case 2007:{f.Push(f.Locals[0]);f.Pc=2008;continue;}
case 2008:{f.Push(f.Locals[3]);f.Pc=2009;continue;}
case 2009:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",2012);}
case 2012:{f.Pc=f.Pop().Int!=0?14247:2015;continue;}
case 2015:{f.Push(JValue.I(0));f.Pc=2016;continue;}
case 2016:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2017:{f.Push(f.Locals[1]);f.Pc=2018;continue;}
case 2018:{f.Push(JValue.R(rt.String("Self")));f.Pc=2021;continue;}
case 2021:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2024);}
case 2024:{f.Pc=f.Pop().Int==0?2037:2027;continue;}
case 2027:{f.Push(f.Locals[0]);f.Pc=2028;continue;}
case 2028:{f.Push(f.Locals[3]);f.Pc=2029;continue;}
case 2029:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",2032);}
case 2032:{f.Pc=f.Pop().Int!=0?14247:2035;continue;}
case 2035:{f.Push(JValue.I(0));f.Pc=2036;continue;}
case 2036:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2037:{f.Push(f.Locals[1]);f.Pc=2038;continue;}
case 2038:{f.Push(JValue.R(rt.String("ExiledByYou")));f.Pc=2041;continue;}
case 2041:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2044);}
case 2044:{f.Pc=f.Pop().Int==0?2069:2047;continue;}
case 2047:{f.Push(f.Locals[0]);f.Pc=2048;continue;}
case 2048:{return rt.Call(f,"forge/game/card/Card","getExiledBy","()Lforge/game/player/Player;","invokevirtual",2051);}
case 2051:{f.Pc=f.Pop().Reference!=null?2056:2054;continue;}
case 2054:{f.Push(JValue.I(0));f.Pc=2055;continue;}
case 2055:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2056:{f.Push(f.Locals[0]);f.Pc=2057;continue;}
case 2057:{return rt.Call(f,"forge/game/card/Card","getExiledBy","()Lforge/game/player/Player;","invokevirtual",2060);}
case 2060:{f.Push(f.Locals[2]);f.Pc=2061;continue;}
case 2061:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",2064);}
case 2064:{f.Pc=f.Pop().Int!=0?14247:2067;continue;}
case 2067:{f.Push(JValue.I(0));f.Pc=2068;continue;}
case 2068:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2069:{f.Push(f.Locals[1]);f.Pc=2070;continue;}
case 2070:{f.Push(JValue.R(rt.String("ExiledWithSourceLKI")));f.Pc=2073;continue;}
case 2073:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2076);}
case 2076:{f.Pc=f.Pop().Int==0?2186:2079;continue;}
case 2079:{f.Push(f.Locals[0]);f.Pc=2080;continue;}
case 2080:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",2083);}
case 2083:{f.Push(JValue.R(null));f.Pc=2084;continue;}
case 2084:{return rt.Call(f,"forge/game/zone/Zone","getCardsAddedThisTurn","(Lforge/game/zone/ZoneType;)Ljava/util/List;","invokevirtual",2087);}
case 2087:{f.Locals[9]=f.Pop();f.Pc=2089;continue;}
case 2089:{f.Push(f.Locals[9]);f.Pc=2091;continue;}
case 2091:{return rt.Call(f,"forge/game/card/CardPredicates","compareByGameTimestamp","()Ljava/util/Comparator;","invokestatic",2094);}
case 2094:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",2099);}
case 2099:{f.Push(f.Locals[9]);f.Pc=2101;continue;}
case 2101:{f.Push(f.Locals[0]);f.Pc=2102;continue;}
case 2102:{return rt.Call(f,"java/util/List","lastIndexOf","(Ljava/lang/Object;)I","invokeinterface",2107);}
case 2107:{f.Locals[10]=f.Pop();f.Pc=2109;continue;}
case 2109:{f.Push(f.Locals[10]);f.Pc=2111;continue;}
case 2111:{f.Push(JValue.I(-1));f.Pc=2112;continue;}
case 2112:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?2117:2115;continue;}
case 2115:{f.Push(JValue.I(0));f.Pc=2116;continue;}
case 2116:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2117:{f.Push(f.Locals[9]);f.Pc=2119;continue;}
case 2119:{f.Push(f.Locals[10]);f.Pc=2121;continue;}
case 2121:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",2126);}
case 2126:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2129;continue;}
case 2129:{f.Locals[11]=f.Pop();f.Pc=2131;continue;}
case 2131:{f.Push(f.Locals[11]);f.Pc=2133;continue;}
case 2133:{return rt.Call(f,"forge/game/card/Card","getExiledWith","()Lforge/game/card/Card;","invokevirtual",2136);}
case 2136:{f.Pc=f.Pop().Reference!=null?2141:2139;continue;}
case 2139:{f.Push(JValue.I(0));f.Pc=2140;continue;}
case 2140:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2141:{f.Push(f.Locals[3]);f.Pc=2142;continue;}
case 2142:{f.Locals[12]=f.Pop();f.Pc=2144;continue;}
case 2144:{f.Push(f.Locals[4]);f.Pc=2146;continue;}
case 2146:{f.Pc=f.Pop().Reference==null?2168:2149;continue;}
case 2149:{f.Push(f.Locals[4]);f.Pc=2151;continue;}
case 2151:{return rt.Call(f,"forge/game/CardTraitBase","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",2154);}
case 2154:{f.Locals[12]=f.Pop();f.Pc=2156;continue;}
case 2156:{f.Push(f.Locals[12]);f.Pc=2158;continue;}
case 2158:{f.Pc=f.Pop().Reference!=null?2168:2161;continue;}
case 2161:{f.Push(f.Locals[4]);f.Pc=2163;continue;}
case 2163:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",2166);}
case 2166:{f.Locals[12]=f.Pop();f.Pc=2168;continue;}
case 2168:{f.Push(f.Locals[11]);f.Pc=2170;continue;}
case 2170:{return rt.Call(f,"forge/game/card/Card","getExiledWith","()Lforge/game/card/Card;","invokevirtual",2173);}
case 2173:{f.Push(f.Locals[12]);f.Pc=2175;continue;}
case 2175:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",2178);}
case 2178:{f.Pc=f.Pop().Int!=0?2183:2181;continue;}
case 2181:{f.Push(JValue.I(0));f.Pc=2182;continue;}
case 2182:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2183:{f.Pc=14247;continue;}
case 2186:{f.Push(f.Locals[1]);f.Pc=2187;continue;}
case 2187:{f.Push(JValue.R(rt.String("ExiledWithSource")));f.Pc=2190;continue;}
case 2190:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2193);}
case 2193:{f.Pc=f.Pop().Int==0?2257:2196;continue;}
case 2196:{f.Push(f.Locals[0]);f.Pc=2197;continue;}
case 2197:{return rt.Call(f,"forge/game/card/Card","getExiledWith","()Lforge/game/card/Card;","invokevirtual",2200);}
case 2200:{f.Pc=f.Pop().Reference!=null?2205:2203;continue;}
case 2203:{f.Push(JValue.I(0));f.Pc=2204;continue;}
case 2204:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2205:{f.Push(f.Locals[3]);f.Pc=2206;continue;}
case 2206:{f.Locals[9]=f.Pop();f.Pc=2208;continue;}
case 2208:{f.Push(f.Locals[4]);f.Pc=2210;continue;}
case 2210:{f.Pc=f.Pop().Reference==null?2232:2213;continue;}
case 2213:{f.Push(f.Locals[4]);f.Pc=2215;continue;}
case 2215:{return rt.Call(f,"forge/game/CardTraitBase","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",2218);}
case 2218:{f.Locals[9]=f.Pop();f.Pc=2220;continue;}
case 2220:{f.Push(f.Locals[9]);f.Pc=2222;continue;}
case 2222:{f.Pc=f.Pop().Reference!=null?2232:2225;continue;}
case 2225:{f.Push(f.Locals[4]);f.Pc=2227;continue;}
case 2227:{return rt.Call(f,"forge/game/CardTraitBase","getHostCard","()Lforge/game/card/Card;","invokevirtual",2230);}
case 2230:{f.Locals[9]=f.Pop();f.Pc=2232;continue;}
case 2232:{f.Push(f.Locals[3]);f.Pc=2233;continue;}
case 2233:{f.Push(f.Locals[0]);f.Pc=2234;continue;}
case 2234:{return rt.Call(f,"forge/game/card/Card","hasExiledCard","(Lforge/game/card/Card;)Z","invokevirtual",2237);}
case 2237:{f.Pc=f.Pop().Int==0?2252:2240;continue;}
case 2240:{f.Push(f.Locals[0]);f.Pc=2241;continue;}
case 2241:{return rt.Call(f,"forge/game/card/Card","getExiledWith","()Lforge/game/card/Card;","invokevirtual",2244);}
case 2244:{f.Push(f.Locals[9]);f.Pc=2246;continue;}
case 2246:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",2249);}
case 2249:{f.Pc=f.Pop().Int!=0?2254:2252;continue;}
case 2252:{f.Push(JValue.I(0));f.Pc=2253;continue;}
case 2253:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2254:{f.Pc=14247;continue;}
case 2257:{f.Push(f.Locals[1]);f.Pc=2258;continue;}
case 2258:{f.Push(JValue.R(rt.String("ExiledWithEffectSource")));f.Pc=2261;continue;}
case 2261:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2264);}
case 2264:{f.Pc=f.Pop().Int==0?2292:2267;continue;}
case 2267:{f.Push(f.Locals[0]);f.Pc=2268;continue;}
case 2268:{return rt.Call(f,"forge/game/card/Card","getExiledWith","()Lforge/game/card/Card;","invokevirtual",2271);}
case 2271:{f.Pc=f.Pop().Reference!=null?2276:2274;continue;}
case 2274:{f.Push(JValue.I(0));f.Pc=2275;continue;}
case 2275:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2276:{f.Push(f.Locals[0]);f.Pc=2277;continue;}
case 2277:{return rt.Call(f,"forge/game/card/Card","getExiledWith","()Lforge/game/card/Card;","invokevirtual",2280);}
case 2280:{f.Push(f.Locals[3]);f.Pc=2281;continue;}
case 2281:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",2284);}
case 2284:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",2287);}
case 2287:{f.Pc=f.Pop().Int!=0?14247:2290;continue;}
case 2290:{f.Push(JValue.I(0));f.Pc=2291;continue;}
case 2291:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2292:{f.Push(f.Locals[1]);f.Pc=2293;continue;}
case 2293:{f.Push(JValue.R(rt.String("EncodedWithSource")));f.Pc=2296;continue;}
case 2296:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2299);}
case 2299:{f.Pc=f.Pop().Int==0?2317:2302;continue;}
case 2302:{f.Push(f.Locals[0]);f.Pc=2303;continue;}
case 2303:{return rt.Call(f,"forge/game/card/Card","getEncodedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",2306);}
case 2306:{f.Push(f.Locals[3]);f.Pc=2307;continue;}
case 2307:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",2312);}
case 2312:{f.Pc=f.Pop().Int!=0?14247:2315;continue;}
case 2315:{f.Push(JValue.I(0));f.Pc=2316;continue;}
case 2316:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2317:{f.Push(f.Locals[1]);f.Pc=2318;continue;}
case 2318:{f.Push(JValue.R(rt.String("EffectSource")));f.Pc=2321;continue;}
case 2321:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2324);}
case 2324:{f.Pc=f.Pop().Int==0?2349:2327;continue;}
case 2327:{f.Push(f.Locals[3]);f.Pc=2328;continue;}
case 2328:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",2331);}
case 2331:{f.Pc=f.Pop().Int!=0?2336:2334;continue;}
case 2334:{f.Push(JValue.I(0));f.Pc=2335;continue;}
case 2335:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2336:{f.Push(f.Locals[0]);f.Pc=2337;continue;}
case 2337:{f.Push(f.Locals[3]);f.Pc=2338;continue;}
case 2338:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",2341);}
case 2341:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",2344);}
case 2344:{f.Pc=f.Pop().Int!=0?14247:2347;continue;}
case 2347:{f.Push(JValue.I(0));f.Pc=2348;continue;}
case 2348:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2349:{f.Push(f.Locals[1]);f.Pc=2350;continue;}
case 2350:{f.Push(JValue.R(rt.String("CanBeSacrificedBy")));f.Pc=2353;continue;}
case 2353:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2356);}
case 2356:{f.Pc=f.Pop().Int==0?2382:2359;continue;}
case 2359:{f.Push(f.Locals[4]);f.Pc=2361;continue;}
case 2361:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=2364;continue;}
case 2364:{f.Pc=f.Pop().Int==0?2382:2367;continue;}
case 2367:{f.Push(f.Locals[0]);f.Pc=2368;continue;}
case 2368:{f.Push(f.Locals[4]);f.Pc=2370;continue;}
case 2370:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2373;continue;}
case 2373:{f.Push(JValue.I(0));f.Pc=2374;continue;}
case 2374:{return rt.Call(f,"forge/game/card/Card","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",2377);}
case 2377:{f.Pc=f.Pop().Int!=0?14247:2380;continue;}
case 2380:{f.Push(JValue.I(0));f.Pc=2381;continue;}
case 2381:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2382:{f.Push(f.Locals[1]);f.Pc=2383;continue;}
case 2383:{f.Push(JValue.R(rt.String("Attached")));f.Pc=2386;continue;}
case 2386:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2389);}
case 2389:{f.Pc=f.Pop().Int==0?2402:2392;continue;}
case 2392:{f.Push(f.Locals[3]);f.Pc=2393;continue;}
case 2393:{f.Push(f.Locals[0]);f.Pc=2394;continue;}
case 2394:{return rt.Call(f,"forge/game/card/Card","hasCardAttachment","(Lforge/game/card/Card;)Z","invokevirtual",2397);}
case 2397:{f.Pc=f.Pop().Int!=0?14247:2400;continue;}
case 2400:{f.Push(JValue.I(0));f.Pc=2401;continue;}
case 2401:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2402:{f.Push(f.Locals[1]);f.Pc=2403;continue;}
case 2403:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=2406;continue;}
case 2406:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2409);}
case 2409:{f.Pc=f.Pop().Int==0?2493:2412;continue;}
case 2412:{f.Push(f.Locals[1]);f.Pc=2413;continue;}
case 2413:{f.Push(JValue.R(rt.String("AttachedTo ")));f.Pc=2416;continue;}
case 2416:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2419);}
case 2419:{f.Push(JValue.I(1));f.Pc=2420;continue;}
case 2420:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2421;continue;}
case 2421:{f.Locals[9]=f.Pop();f.Pc=2423;continue;}
case 2423:{f.Push(f.Locals[0]);f.Pc=2424;continue;}
case 2424:{return rt.Call(f,"forge/game/card/Card","isAttachedToEntity","()Z","invokevirtual",2427);}
case 2427:{f.Pc=f.Pop().Int!=0?2432:2430;continue;}
case 2430:{f.Push(JValue.I(0));f.Pc=2431;continue;}
case 2431:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2432:{f.Push(f.Locals[0]);f.Pc=2433;continue;}
case 2433:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",2436);}
case 2436:{f.Push(f.Locals[9]);f.Pc=2438;continue;}
case 2438:{f.Push(f.Locals[2]);f.Pc=2439;continue;}
case 2439:{f.Push(f.Locals[3]);f.Pc=2440;continue;}
case 2440:{f.Push(f.Locals[4]);f.Pc=2442;continue;}
case 2442:{return rt.Call(f,"forge/game/GameEntity","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",2445);}
case 2445:{f.Pc=f.Pop().Int!=0?2490:2448;continue;}
case 2448:{f.Push(f.Locals[9]);f.Pc=2450;continue;}
case 2450:{f.Push(JValue.R(rt.String("Player")));f.Pc=2453;continue;}
case 2453:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",2456);}
case 2456:{f.Pc=f.Pop().Int==0?2470:2459;continue;}
case 2459:{f.Push(f.Locals[3]);f.Pc=2460;continue;}
case 2460:{f.Push(f.Locals[9]);f.Pc=2462;continue;}
case 2462:{f.Push(f.Locals[4]);f.Pc=2464;continue;}
case 2464:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",2467);}
case 2467:{f.Pc=2478;continue;}
case 2470:{f.Push(f.Locals[3]);f.Pc=2471;continue;}
case 2471:{f.Push(f.Locals[9]);f.Pc=2473;continue;}
case 2473:{f.Push(f.Locals[4]);f.Pc=2475;continue;}
case 2475:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",2478);}
case 2478:{f.Push(f.Locals[0]);f.Pc=2479;continue;}
case 2479:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",2482);}
case 2482:{return rt.Call(f,"forge/util/collect/FCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",2485);}
case 2485:{f.Pc=f.Pop().Int!=0?2490:2488;continue;}
case 2488:{f.Push(JValue.I(0));f.Pc=2489;continue;}
case 2489:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2490:{f.Pc=14247;continue;}
case 2493:{f.Push(f.Locals[1]);f.Pc=2494;continue;}
case 2494:{f.Push(JValue.R(rt.String("NameNotEnchantingEnchantedPlayer")));f.Pc=2497;continue;}
case 2497:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2500);}
case 2500:{f.Pc=f.Pop().Int==0?2531:2503;continue;}
case 2503:{f.Push(f.Locals[3]);f.Pc=2504;continue;}
case 2504:{return rt.Call(f,"forge/game/card/Card","getPlayerAttachedTo","()Lforge/game/player/Player;","invokevirtual",2507);}
case 2507:{f.Locals[9]=f.Pop();f.Pc=2509;continue;}
case 2509:{f.Push(f.Locals[9]);f.Pc=2511;continue;}
case 2511:{f.Pc=f.Pop().Reference==null?2526:2514;continue;}
case 2514:{f.Push(f.Locals[9]);f.Pc=2516;continue;}
case 2516:{f.Push(f.Locals[0]);f.Pc=2517;continue;}
case 2517:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",2520);}
case 2520:{return rt.Call(f,"forge/game/player/Player","isEnchantedBy","(Ljava/lang/String;)Z","invokevirtual",2523);}
case 2523:{f.Pc=f.Pop().Int==0?2528:2526;continue;}
case 2526:{f.Push(JValue.I(0));f.Pc=2527;continue;}
case 2527:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2528:{f.Pc=14247;continue;}
case 2531:{f.Push(f.Locals[1]);f.Pc=2532;continue;}
case 2532:{f.Push(JValue.R(rt.String("EnchantedBy")));f.Pc=2535;continue;}
case 2535:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2538);}
case 2538:{f.Pc=f.Pop().Int==0?2864:2541;continue;}
case 2541:{f.Push(f.Locals[1]);f.Pc=2542;continue;}
case 2542:{f.Push(JValue.R(rt.String("EnchantedBy")));f.Pc=2545;continue;}
case 2545:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2548);}
case 2548:{f.Pc=f.Pop().Int==0?2572:2551;continue;}
case 2551:{f.Push(f.Locals[0]);f.Pc=2552;continue;}
case 2552:{f.Push(f.Locals[3]);f.Pc=2553;continue;}
case 2553:{return rt.Call(f,"forge/game/card/Card","isEnchantedBy","(Lforge/game/card/Card;)Z","invokevirtual",2556);}
case 2556:{f.Pc=f.Pop().Int!=0?14247:2559;continue;}
case 2559:{f.Push(f.Locals[0]);f.Pc=2560;continue;}
case 2560:{f.Push(f.Locals[3]);f.Pc=2561;continue;}
case 2561:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",2564);}
case 2564:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",2567);}
case 2567:{f.Pc=f.Pop().Int!=0?14247:2570;continue;}
case 2570:{f.Push(JValue.I(0));f.Pc=2571;continue;}
case 2571:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2572:{f.Push(f.Locals[1]);f.Pc=2573;continue;}
case 2573:{f.Push(JValue.R(rt.String("EnchantedBy ")));f.Pc=2576;continue;}
case 2576:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2579);}
case 2579:{f.Push(JValue.I(1));f.Pc=2580;continue;}
case 2580:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2581;continue;}
case 2581:{f.Locals[9]=f.Pop();f.Pc=2583;continue;}
case 2583:{f.Push(f.Locals[9]);f.Pc=2585;continue;}
case 2585:{f.Locals[10]=f.Pop();f.Pc=2587;continue;}
case 2587:{f.Push(JValue.I(-1));f.Pc=2588;continue;}
case 2588:{f.Locals[11]=f.Pop();f.Pc=2590;continue;}
case 2590:{f.Push(f.Locals[10]);f.Pc=2592;continue;}
case 2592:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",2595);}
case 2595:{switch(f.Pop().Int){case -377306608:f.Pc=2637;break;case 1872857672:f.Pc=2620;break;default:f.Pc=2651;break;}continue;}
case 2620:{f.Push(f.Locals[10]);f.Pc=2622;continue;}
case 2622:{f.Push(JValue.R(rt.String("Imprinted")));f.Pc=2625;continue;}
case 2625:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2628);}
case 2628:{f.Pc=f.Pop().Int==0?2651:2631;continue;}
case 2631:{f.Push(JValue.I(0));f.Pc=2632;continue;}
case 2632:{f.Locals[11]=f.Pop();f.Pc=2634;continue;}
case 2634:{f.Pc=2651;continue;}
case 2637:{f.Push(f.Locals[10]);f.Pc=2639;continue;}
case 2639:{f.Push(JValue.R(rt.String("Targeted")));f.Pc=2642;continue;}
case 2642:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2645);}
case 2645:{f.Pc=f.Pop().Int==0?2651:2648;continue;}
case 2648:{f.Push(JValue.I(1));f.Pc=2649;continue;}
case 2649:{f.Locals[11]=f.Pop();f.Pc=2651;continue;}
case 2651:{f.Push(f.Locals[11]);f.Pc=2653;continue;}
case 2653:{switch(f.Pop().Int){case 0:f.Pc=2680;break;case 1:f.Pc=2742;break;default:f.Pc=2807;break;}continue;}
case 2680:{f.Push(f.Locals[3]);f.Pc=2681;continue;}
case 2681:{return rt.Call(f,"forge/game/card/Card","getImprintedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",2684);}
case 2684:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",2689);}
case 2689:{f.Locals[12]=f.Pop();f.Pc=2691;continue;}
case 2691:{f.Push(f.Locals[12]);f.Pc=2693;continue;}
case 2693:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2698);}
case 2698:{f.Pc=f.Pop().Int==0?2739:2701;continue;}
case 2701:{f.Push(f.Locals[12]);f.Pc=2703;continue;}
case 2703:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2708);}
case 2708:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2711;continue;}
case 2711:{f.Locals[13]=f.Pop();f.Pc=2713;continue;}
case 2713:{f.Push(f.Locals[0]);f.Pc=2714;continue;}
case 2714:{f.Push(f.Locals[13]);f.Pc=2716;continue;}
case 2716:{return rt.Call(f,"forge/game/card/Card","isEnchantedBy","(Lforge/game/card/Card;)Z","invokevirtual",2719);}
case 2719:{f.Pc=f.Pop().Int!=0?2736:2722;continue;}
case 2722:{f.Push(f.Locals[0]);f.Pc=2723;continue;}
case 2723:{f.Push(f.Locals[13]);f.Pc=2725;continue;}
case 2725:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",2728);}
case 2728:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",2731);}
case 2731:{f.Pc=f.Pop().Int!=0?2736:2734;continue;}
case 2734:{f.Push(JValue.I(0));f.Pc=2735;continue;}
case 2735:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2736:{f.Pc=2691;continue;}
case 2739:{f.Pc=2861;continue;}
case 2742:{f.Push(f.Locals[3]);f.Pc=2743;continue;}
case 2743:{f.Push(JValue.R(rt.String("Targeted")));f.Pc=2746;continue;}
case 2746:{f.Push(f.Locals[4]);f.Pc=2748;continue;}
case 2748:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",2751);}
case 2751:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2754);}
case 2754:{f.Locals[12]=f.Pop();f.Pc=2756;continue;}
case 2756:{f.Push(f.Locals[12]);f.Pc=2758;continue;}
case 2758:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2763);}
case 2763:{f.Pc=f.Pop().Int==0?2804:2766;continue;}
case 2766:{f.Push(f.Locals[12]);f.Pc=2768;continue;}
case 2768:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2773);}
case 2773:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2776;continue;}
case 2776:{f.Locals[13]=f.Pop();f.Pc=2778;continue;}
case 2778:{f.Push(f.Locals[0]);f.Pc=2779;continue;}
case 2779:{f.Push(f.Locals[13]);f.Pc=2781;continue;}
case 2781:{return rt.Call(f,"forge/game/card/Card","isEnchantedBy","(Lforge/game/card/Card;)Z","invokevirtual",2784);}
case 2784:{f.Pc=f.Pop().Int!=0?2801:2787;continue;}
case 2787:{f.Push(f.Locals[0]);f.Pc=2788;continue;}
case 2788:{f.Push(f.Locals[13]);f.Pc=2790;continue;}
case 2790:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",2793);}
case 2793:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",2796);}
case 2796:{f.Pc=f.Pop().Int!=0?2801:2799;continue;}
case 2799:{f.Push(JValue.I(0));f.Pc=2800;continue;}
case 2800:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2801:{f.Pc=2756;continue;}
case 2804:{f.Pc=2861;continue;}
case 2807:{f.Push(f.Locals[0]);f.Pc=2808;continue;}
case 2808:{return rt.Call(f,"forge/game/card/Card","getEnchantedBy","()Lforge/game/card/CardCollectionView;","invokevirtual",2811);}
case 2811:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",2816);}
case 2816:{f.Locals[12]=f.Pop();f.Pc=2818;continue;}
case 2818:{f.Push(f.Locals[12]);f.Pc=2820;continue;}
case 2820:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2825);}
case 2825:{f.Pc=f.Pop().Int==0?2859:2828;continue;}
case 2828:{f.Push(f.Locals[12]);f.Pc=2830;continue;}
case 2830:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2835);}
case 2835:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2838;continue;}
case 2838:{f.Locals[13]=f.Pop();f.Pc=2840;continue;}
case 2840:{f.Push(f.Locals[13]);f.Pc=2842;continue;}
case 2842:{f.Push(f.Locals[9]);f.Pc=2844;continue;}
case 2844:{f.Push(f.Locals[2]);f.Pc=2845;continue;}
case 2845:{f.Push(f.Locals[3]);f.Pc=2846;continue;}
case 2846:{f.Push(f.Locals[4]);f.Pc=2848;continue;}
case 2848:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",2851);}
case 2851:{f.Pc=f.Pop().Int==0?2856:2854;continue;}
case 2854:{f.Push(JValue.I(1));f.Pc=2855;continue;}
case 2855:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2856:{f.Pc=2818;continue;}
case 2859:{f.Push(JValue.I(0));f.Pc=2860;continue;}
case 2860:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2861:{f.Pc=14247;continue;}
case 2864:{f.Push(f.Locals[1]);f.Pc=2865;continue;}
case 2865:{f.Push(JValue.R(rt.String("Enchanted")));f.Pc=2868;continue;}
case 2868:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2871);}
case 2871:{f.Pc=f.Pop().Int==0?2887:2874;continue;}
case 2874:{f.Push(f.Locals[3]);f.Pc=2875;continue;}
case 2875:{f.Push(f.Locals[0]);f.Pc=2876;continue;}
case 2876:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",2879);}
case 2879:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",2882);}
case 2882:{f.Pc=f.Pop().Int!=0?14247:2885;continue;}
case 2885:{f.Push(JValue.I(0));f.Pc=2886;continue;}
case 2886:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2887:{f.Push(f.Locals[1]);f.Pc=2888;continue;}
case 2888:{f.Push(JValue.R(rt.String("CanEnchant")));f.Pc=2891;continue;}
case 2891:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2894);}
case 2894:{f.Pc=f.Pop().Int==0?3032:2897;continue;}
case 2897:{f.Push(f.Locals[1]);f.Pc=2898;continue;}
case 2898:{f.Push(JValue.I(10));f.Pc=2900;continue;}
case 2900:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",2903);}
case 2903:{f.Locals[9]=f.Pop();f.Pc=2905;continue;}
case 2905:{f.Push(f.Locals[9]);f.Pc=2907;continue;}
case 2907:{f.Push(JValue.R(rt.String("EquippedBy")));f.Pc=2910;continue;}
case 2910:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2913);}
case 2913:{f.Pc=f.Pop().Int==0?2937:2916;continue;}
case 2916:{f.Push(f.Locals[3]);f.Pc=2917;continue;}
case 2917:{return rt.Call(f,"forge/game/card/Card","isEquipping","()Z","invokevirtual",2920);}
case 2920:{f.Pc=f.Pop().Int==0?2935:2923;continue;}
case 2923:{f.Push(f.Locals[3]);f.Pc=2924;continue;}
case 2924:{return rt.Call(f,"forge/game/card/Card","getEquipping","()Lforge/game/card/Card;","invokevirtual",2927);}
case 2927:{f.Push(f.Locals[0]);f.Pc=2928;continue;}
case 2928:{f.Push(JValue.R(null));f.Pc=2929;continue;}
case 2929:{return rt.Call(f,"forge/game/card/Card","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",2932);}
case 2932:{f.Pc=f.Pop().Int!=0?2937:2935;continue;}
case 2935:{f.Push(JValue.I(0));f.Pc=2936;continue;}
case 2936:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2937:{f.Push(f.Locals[9]);f.Pc=2939;continue;}
case 2939:{f.Push(JValue.R(rt.String("Remembered")));f.Pc=2942;continue;}
case 2942:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2945);}
case 2945:{f.Pc=f.Pop().Int==0?3007:2948;continue;}
case 2948:{f.Push(f.Locals[3]);f.Pc=2949;continue;}
case 2949:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",2952);}
case 2952:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",2957);}
case 2957:{f.Locals[10]=f.Pop();f.Pc=2959;continue;}
case 2959:{f.Push(f.Locals[10]);f.Pc=2961;continue;}
case 2961:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2966);}
case 2966:{f.Pc=f.Pop().Int==0?3004:2969;continue;}
case 2969:{f.Push(f.Locals[10]);f.Pc=2971;continue;}
case 2971:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2976);}
case 2976:{f.Locals[11]=f.Pop();f.Pc=2978;continue;}
case 2978:{f.Push(f.Locals[11]);f.Pc=2980;continue;}
case 2980:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=2983;continue;}
case 2983:{f.Pc=f.Pop().Int==0?2999:2986;continue;}
case 2986:{f.Push(f.Locals[11]);f.Pc=2988;continue;}
case 2988:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2991;continue;}
case 2991:{f.Push(f.Locals[0]);f.Pc=2992;continue;}
case 2992:{f.Push(JValue.R(null));f.Pc=2993;continue;}
case 2993:{return rt.Call(f,"forge/game/card/Card","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",2996);}
case 2996:{f.Pc=f.Pop().Int!=0?3001:2999;continue;}
case 2999:{f.Push(JValue.I(0));f.Pc=3000;continue;}
case 3000:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3001:{f.Pc=2959;continue;}
case 3004:{f.Pc=3029;continue;}
case 3007:{f.Push(f.Locals[9]);f.Pc=3009;continue;}
case 3009:{f.Push(JValue.R(rt.String("Source")));f.Pc=3012;continue;}
case 3012:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3015);}
case 3015:{f.Pc=f.Pop().Int==0?3029:3018;continue;}
case 3018:{f.Push(f.Locals[3]);f.Pc=3019;continue;}
case 3019:{f.Push(f.Locals[0]);f.Pc=3020;continue;}
case 3020:{f.Push(JValue.R(null));f.Pc=3021;continue;}
case 3021:{return rt.Call(f,"forge/game/card/Card","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",3024);}
case 3024:{f.Pc=f.Pop().Int!=0?3029:3027;continue;}
case 3027:{f.Push(JValue.I(0));f.Pc=3028;continue;}
case 3028:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3029:{f.Pc=14247;continue;}
case 3032:{f.Push(f.Locals[1]);f.Pc=3033;continue;}
case 3033:{f.Push(JValue.R(rt.String("CanBeEnchantedBy")));f.Pc=3036;continue;}
case 3036:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3039);}
case 3039:{f.Pc=f.Pop().Int==0?3122:3042;continue;}
case 3042:{f.Push(f.Locals[1]);f.Pc=3043;continue;}
case 3043:{f.Push(JValue.I(16));f.Pc=3045;continue;}
case 3045:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",3048);}
case 3048:{f.Push(JValue.R(rt.String("Targeted")));f.Pc=3051;continue;}
case 3051:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3054);}
case 3054:{f.Pc=f.Pop().Int==0?3111:3057;continue;}
case 3057:{f.Push(f.Locals[3]);f.Pc=3058;continue;}
case 3058:{f.Push(JValue.R(rt.String("Targeted")));f.Pc=3061;continue;}
case 3061:{f.Push(f.Locals[4]);f.Pc=3063;continue;}
case 3063:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",3066);}
case 3066:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",3069);}
case 3069:{f.Locals[9]=f.Pop();f.Pc=3071;continue;}
case 3071:{f.Push(f.Locals[9]);f.Pc=3073;continue;}
case 3073:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3078);}
case 3078:{f.Pc=f.Pop().Int==0?3108:3081;continue;}
case 3081:{f.Push(f.Locals[9]);f.Pc=3083;continue;}
case 3083:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3088);}
case 3088:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3091;continue;}
case 3091:{f.Locals[10]=f.Pop();f.Pc=3093;continue;}
case 3093:{f.Push(f.Locals[0]);f.Pc=3094;continue;}
case 3094:{f.Push(f.Locals[10]);f.Pc=3096;continue;}
case 3096:{f.Push(JValue.R(null));f.Pc=3097;continue;}
case 3097:{return rt.Call(f,"forge/game/card/Card","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",3100);}
case 3100:{f.Pc=f.Pop().Int!=0?3105:3103;continue;}
case 3103:{f.Push(JValue.I(0));f.Pc=3104;continue;}
case 3104:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3105:{f.Pc=3071;continue;}
case 3108:{f.Pc=14247;continue;}
case 3111:{f.Push(f.Locals[0]);f.Pc=3112;continue;}
case 3112:{f.Push(f.Locals[3]);f.Pc=3113;continue;}
case 3113:{f.Push(JValue.R(null));f.Pc=3114;continue;}
case 3114:{return rt.Call(f,"forge/game/card/Card","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",3117);}
case 3117:{f.Pc=f.Pop().Int!=0?14247:3120;continue;}
case 3120:{f.Push(JValue.I(0));f.Pc=3121;continue;}
case 3121:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3122:{f.Push(f.Locals[1]);f.Pc=3123;continue;}
case 3123:{f.Push(JValue.R(rt.String("EquippedBy")));f.Pc=3126;continue;}
case 3126:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3129);}
case 3129:{f.Pc=f.Pop().Int!=0?3142:3132;continue;}
case 3132:{f.Push(f.Locals[1]);f.Pc=3133;continue;}
case 3133:{f.Push(JValue.R(rt.String("AttachedBy")));f.Pc=3136;continue;}
case 3136:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3139);}
case 3139:{f.Pc=f.Pop().Int==0?3237:3142;continue;}
case 3142:{f.Push(f.Locals[1]);f.Pc=3143;continue;}
case 3143:{f.Push(JValue.I(10));f.Pc=3145;continue;}
case 3145:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",3148);}
case 3148:{f.Locals[9]=f.Pop();f.Pc=3150;continue;}
case 3150:{f.Push(f.Locals[9]);f.Pc=3152;continue;}
case 3152:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",3155);}
case 3155:{f.Pc=f.Pop().Int!=0?3224:3158;continue;}
case 3158:{f.Push(JValue.I(0));f.Pc=3159;continue;}
case 3159:{f.Locals[10]=f.Pop();f.Pc=3161;continue;}
case 3161:{f.Push(f.Locals[3]);f.Pc=3162;continue;}
case 3162:{f.Push(f.Locals[9]);f.Pc=3164;continue;}
case 3164:{f.Push(f.Locals[4]);f.Pc=3166;continue;}
case 3166:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",3169);}
case 3169:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",3172);}
case 3172:{f.Locals[11]=f.Pop();f.Pc=3174;continue;}
case 3174:{f.Push(f.Locals[11]);f.Pc=3176;continue;}
case 3176:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3181);}
case 3181:{f.Pc=f.Pop().Int==0?3214:3184;continue;}
case 3184:{f.Push(f.Locals[11]);f.Pc=3186;continue;}
case 3186:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3191);}
case 3191:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3194;continue;}
case 3194:{f.Locals[12]=f.Pop();f.Pc=3196;continue;}
case 3196:{f.Push(f.Locals[0]);f.Pc=3197;continue;}
case 3197:{f.Push(f.Locals[12]);f.Pc=3199;continue;}
case 3199:{return rt.Call(f,"forge/game/card/Card","hasCardAttachment","(Lforge/game/card/Card;)Z","invokevirtual",3202);}
case 3202:{f.Pc=f.Pop().Int==0?3211:3205;continue;}
case 3205:{f.Push(JValue.I(1));f.Pc=3206;continue;}
case 3206:{f.Locals[10]=f.Pop();f.Pc=3208;continue;}
case 3208:{f.Pc=3214;continue;}
case 3211:{f.Pc=3174;continue;}
case 3214:{f.Push(f.Locals[10]);f.Pc=3216;continue;}
case 3216:{f.Pc=f.Pop().Int!=0?3221:3219;continue;}
case 3219:{f.Push(JValue.I(0));f.Pc=3220;continue;}
case 3220:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3221:{f.Pc=3234;continue;}
case 3224:{f.Push(f.Locals[0]);f.Pc=3225;continue;}
case 3225:{f.Push(f.Locals[3]);f.Pc=3226;continue;}
case 3226:{return rt.Call(f,"forge/game/card/Card","hasCardAttachment","(Lforge/game/card/Card;)Z","invokevirtual",3229);}
case 3229:{f.Pc=f.Pop().Int!=0?3234:3232;continue;}
case 3232:{f.Push(JValue.I(0));f.Pc=3233;continue;}
case 3233:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3234:{f.Pc=14247;continue;}
case 3237:{f.Push(f.Locals[1]);f.Pc=3238;continue;}
case 3238:{f.Push(JValue.R(rt.String("FortifiedBy")));f.Pc=3241;continue;}
case 3241:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3244);}
case 3244:{f.Pc=f.Pop().Int==0?3257:3247;continue;}
case 3247:{f.Push(f.Locals[0]);f.Pc=3248;continue;}
case 3248:{f.Push(f.Locals[3]);f.Pc=3249;continue;}
case 3249:{return rt.Call(f,"forge/game/card/Card","hasCardAttachment","(Lforge/game/card/Card;)Z","invokevirtual",3252);}
case 3252:{f.Pc=f.Pop().Int!=0?14247:3255;continue;}
case 3255:{f.Push(JValue.I(0));f.Pc=3256;continue;}
case 3256:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3257:{f.Push(f.Locals[1]);f.Pc=3258;continue;}
case 3258:{f.Push(JValue.R(rt.String("CanBeAttachedBy")));f.Pc=3261;continue;}
case 3261:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3264);}
case 3264:{f.Pc=f.Pop().Int==0?3278:3267;continue;}
case 3267:{f.Push(f.Locals[0]);f.Pc=3268;continue;}
case 3268:{f.Push(f.Locals[3]);f.Pc=3269;continue;}
case 3269:{f.Push(JValue.R(null));f.Pc=3270;continue;}
case 3270:{return rt.Call(f,"forge/game/card/Card","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",3273);}
case 3273:{f.Pc=f.Pop().Int!=0?14247:3276;continue;}
case 3276:{f.Push(JValue.I(0));f.Pc=3277;continue;}
case 3277:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3278:{f.Push(f.Locals[1]);f.Pc=3279;continue;}
case 3279:{f.Push(JValue.R(rt.String("CanBeTargetedBy")));f.Pc=3282;continue;}
case 3282:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3285);}
case 3285:{f.Pc=f.Pop().Int==0?3350:3288;continue;}
case 3288:{f.Push(f.Locals[1]);f.Pc=3289;continue;}
case 3289:{f.Push(JValue.I(15));f.Pc=3291;continue;}
case 3291:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",3294);}
case 3294:{f.Locals[9]=f.Pop();f.Pc=3296;continue;}
case 3296:{f.Push(f.Locals[3]);f.Pc=3297;continue;}
case 3297:{f.Push(f.Locals[9]);f.Pc=3299;continue;}
case 3299:{f.Push(f.Locals[4]);f.Pc=3301;continue;}
case 3301:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedSpellAbilities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",3304);}
case 3304:{f.Push(JValue.I(0));f.Pc=3305;continue;}
case 3305:{return rt.Call(f,"forge/util/collect/FCollection","get","(I)Ljava/lang/Object;","invokevirtual",3308);}
case 3308:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3311;continue;}
case 3311:{f.Locals[10]=f.Pop();f.Pc=3313;continue;}
case 3313:{f.Push(f.Locals[10]);f.Pc=3315;continue;}
case 3315:{f.Pc=f.Pop().Reference==null?3347:3318;continue;}
case 3318:{f.Push(f.Locals[10]);f.Pc=3320;continue;}
case 3320:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",3323);}
case 3323:{f.Pc=f.Pop().Int==0?3337:3326;continue;}
case 3326:{f.Push(f.Locals[10]);f.Pc=3328;continue;}
case 3328:{f.Push(f.Locals[0]);f.Pc=3329;continue;}
case 3329:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;)Z","invokevirtual",3332);}
case 3332:{f.Pc=f.Pop().Int!=0?3337:3335;continue;}
case 3335:{f.Push(JValue.I(0));f.Pc=3336;continue;}
case 3336:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3337:{f.Push(f.Locals[10]);f.Pc=3339;continue;}
case 3339:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",3342);}
case 3342:{f.Locals[10]=f.Pop();f.Pc=3344;continue;}
case 3344:{f.Pc=3313;continue;}
case 3347:{f.Pc=14247;continue;}
case 3350:{f.Push(f.Locals[1]);f.Pc=3351;continue;}
case 3351:{f.Push(JValue.R(rt.String("HauntedBy")));f.Pc=3354;continue;}
case 3354:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3357);}
case 3357:{f.Pc=f.Pop().Int==0?3370:3360;continue;}
case 3360:{f.Push(f.Locals[0]);f.Pc=3361;continue;}
case 3361:{f.Push(f.Locals[3]);f.Pc=3362;continue;}
case 3362:{return rt.Call(f,"forge/game/card/Card","isHauntedBy","(Lforge/game/card/Card;)Z","invokevirtual",3365);}
case 3365:{f.Pc=f.Pop().Int!=0?14247:3368;continue;}
case 3368:{f.Push(JValue.I(0));f.Pc=3369;continue;}
case 3369:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3370:{f.Push(f.Locals[1]);f.Pc=3371;continue;}
case 3371:{f.Push(JValue.R(rt.String("notTributed")));f.Pc=3374;continue;}
case 3374:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3377);}
case 3377:{f.Pc=f.Pop().Int==0?3389:3380;continue;}
case 3380:{f.Push(f.Locals[0]);f.Pc=3381;continue;}
case 3381:{return rt.Call(f,"forge/game/card/Card","isTributed","()Z","invokevirtual",3384);}
case 3384:{f.Pc=f.Pop().Int==0?14247:3387;continue;}
case 3387:{f.Push(JValue.I(0));f.Pc=3388;continue;}
case 3388:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3389:{f.Push(f.Locals[1]);f.Pc=3390;continue;}
case 3390:{f.Push(JValue.R(rt.String("madness")));f.Pc=3393;continue;}
case 3393:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3396);}
case 3396:{f.Pc=f.Pop().Int==0?3408:3399;continue;}
case 3399:{f.Push(f.Locals[0]);f.Pc=3400;continue;}
case 3400:{return rt.Call(f,"forge/game/card/Card","isMadness","()Z","invokevirtual",3403);}
case 3403:{f.Pc=f.Pop().Int!=0?14247:3406;continue;}
case 3406:{f.Push(JValue.I(0));f.Pc=3407;continue;}
case 3407:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3408:{f.Push(f.Locals[1]);f.Pc=3409;continue;}
case 3409:{f.Push(JValue.R(rt.String("Paired")));f.Pc=3412;continue;}
case 3412:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3415);}
case 3415:{f.Pc=f.Pop().Int==0?3447:3418;continue;}
case 3418:{f.Push(f.Locals[0]);f.Pc=3419;continue;}
case 3419:{return rt.Call(f,"forge/game/card/Card","isPaired","()Z","invokevirtual",3422);}
case 3422:{f.Pc=f.Pop().Int!=0?3427:3425;continue;}
case 3425:{f.Push(JValue.I(0));f.Pc=3426;continue;}
case 3426:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3427:{f.Push(f.Locals[1]);f.Pc=3428;continue;}
case 3428:{f.Push(JValue.R(rt.String("With")));f.Pc=3431;continue;}
case 3431:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",3434);}
case 3434:{f.Pc=f.Pop().Int==0?14247:3437;continue;}
case 3437:{f.Push(f.Locals[0]);f.Pc=3438;continue;}
case 3438:{return rt.Call(f,"forge/game/card/Card","getPairedWith","()Lforge/game/card/Card;","invokevirtual",3441);}
case 3441:{f.Push(f.Locals[3]);f.Pc=3442;continue;}
case 3442:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?14247:3445;continue;}
case 3445:{f.Push(JValue.I(0));f.Pc=3446;continue;}
case 3446:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3447:{f.Push(f.Locals[1]);f.Pc=3448;continue;}
case 3448:{f.Push(JValue.R(rt.String("Above")));f.Pc=3451;continue;}
case 3451:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3454);}
case 3454:{f.Pc=f.Pop().Int==0?3493:3457;continue;}
case 3457:{f.Push(f.Locals[0]);f.Pc=3458;continue;}
case 3458:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",3461);}
case 3461:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=3464;continue;}
case 3464:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",3467);}
case 3467:{f.Locals[9]=f.Pop();f.Pc=3469;continue;}
case 3469:{f.Push(f.Locals[9]);f.Pc=3471;continue;}
case 3471:{f.Push(f.Locals[3]);f.Pc=3472;continue;}
case 3472:{return rt.Call(f,"forge/game/card/CardCollectionView","indexOf","(Ljava/lang/Object;)I","invokeinterface",3477);}
case 3477:{f.Push(f.Locals[9]);f.Pc=3479;continue;}
case 3479:{f.Push(f.Locals[0]);f.Pc=3480;continue;}
case 3480:{return rt.Call(f,"forge/game/card/CardCollectionView","indexOf","(Ljava/lang/Object;)I","invokeinterface",3485);}
case 3485:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?3490:3488;continue;}
case 3488:{f.Push(JValue.I(0));f.Pc=3489;continue;}
case 3489:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3490:{f.Pc=14247;continue;}
case 3493:{f.Push(f.Locals[1]);f.Pc=3494;continue;}
case 3494:{f.Push(JValue.R(rt.String("DirectlyAbove")));f.Pc=3497;continue;}
case 3497:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3500);}
case 3500:{f.Pc=f.Pop().Int==0?3541:3503;continue;}
case 3503:{f.Push(f.Locals[0]);f.Pc=3504;continue;}
case 3504:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",3507);}
case 3507:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=3510;continue;}
case 3510:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",3513);}
case 3513:{f.Locals[9]=f.Pop();f.Pc=3515;continue;}
case 3515:{f.Push(f.Locals[9]);f.Pc=3517;continue;}
case 3517:{f.Push(f.Locals[0]);f.Pc=3518;continue;}
case 3518:{return rt.Call(f,"forge/game/card/CardCollectionView","indexOf","(Ljava/lang/Object;)I","invokeinterface",3523);}
case 3523:{f.Push(f.Locals[9]);f.Pc=3525;continue;}
case 3525:{f.Push(f.Locals[3]);f.Pc=3526;continue;}
case 3526:{return rt.Call(f,"forge/game/card/CardCollectionView","indexOf","(Ljava/lang/Object;)I","invokeinterface",3531);}
case 3531:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=3532;continue;}
case 3532:{f.Push(JValue.I(1));f.Pc=3533;continue;}
case 3533:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?3538:3536;continue;}
case 3536:{f.Push(JValue.I(0));f.Pc=3537;continue;}
case 3537:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3538:{f.Pc=14247;continue;}
case 3541:{f.Push(f.Locals[1]);f.Pc=3542;continue;}
case 3542:{f.Push(JValue.R(rt.String("TopGraveyardCreature")));f.Pc=3545;continue;}
case 3545:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3548);}
case 3548:{f.Pc=f.Pop().Int==0?3600:3551;continue;}
case 3551:{f.Push(f.Locals[0]);f.Pc=3552;continue;}
case 3552:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",3555);}
case 3555:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=3558;continue;}
case 3558:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",3561);}
case 3561:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"));f.Pc=3564;continue;}
case 3564:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",3567);}
case 3567:{f.Locals[9]=f.Pop();f.Pc=3569;continue;}
case 3569:{f.Push(f.Locals[9]);f.Pc=3571;continue;}
case 3571:{return rt.Call(f,"java/util/Collections","reverse","(Ljava/util/List;)V","invokestatic",3574);}
case 3574:{f.Push(f.Locals[9]);f.Pc=3576;continue;}
case 3576:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",3579);}
case 3579:{f.Pc=f.Pop().Int!=0?3595:3582;continue;}
case 3582:{f.Push(f.Locals[0]);f.Pc=3583;continue;}
case 3583:{f.Push(f.Locals[9]);f.Pc=3585;continue;}
case 3585:{f.Push(JValue.I(0));f.Pc=3586;continue;}
case 3586:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",3589);}
case 3589:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",3592);}
case 3592:{f.Pc=f.Pop().Int!=0?3597:3595;continue;}
case 3595:{f.Push(JValue.I(0));f.Pc=3596;continue;}
case 3596:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3597:{f.Pc=14247;continue;}
case 3600:{f.Push(f.Locals[1]);f.Pc=3601;continue;}
case 3601:{f.Push(JValue.R(rt.String("TopGraveyard")));f.Pc=3604;continue;}
case 3604:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3607);}
case 3607:{f.Pc=f.Pop().Int==0?3761:3610;continue;}
case 3610:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3613;continue;}
case 3613:{f.StackOp("dup");f.Pc=3614;continue;}
case 3614:{f.Push(f.Locals[0]);f.Pc=3615;continue;}
case 3615:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",3618);}
case 3618:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=3621;continue;}
case 3621:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",3624);}
case 3624:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",3627);}
case 3627:{f.Locals[9]=f.Pop();f.Pc=3629;continue;}
case 3629:{f.Push(f.Locals[9]);f.Pc=3631;continue;}
case 3631:{return rt.Call(f,"java/util/Collections","reverse","(Ljava/util/List;)V","invokestatic",3634);}
case 3634:{f.Push(f.Locals[1]);f.Pc=3635;continue;}
case 3635:{f.Push(JValue.I(12));f.Pc=3637;continue;}
case 3637:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",3640);}
case 3640:{f.Push(JValue.R(rt.String("[0-9][0-9]?")));f.Pc=3643;continue;}
case 3643:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",3646);}
case 3646:{f.Pc=f.Pop().Int==0?3735:3649;continue;}
case 3649:{f.Push(f.Locals[1]);f.Pc=3650;continue;}
case 3650:{f.Push(JValue.I(12));f.Pc=3652;continue;}
case 3652:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",3655);}
case 3655:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",3658);}
case 3658:{f.Locals[10]=f.Pop();f.Pc=3660;continue;}
case 3660:{f.Push(f.Locals[10]);f.Pc=3662;continue;}
case 3662:{f.Push(f.Locals[9]);f.Pc=3664;continue;}
case 3664:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",3667);}
case 3667:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",3670);}
case 3670:{f.Locals[11]=f.Pop();f.Pc=3672;continue;}
case 3672:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3675;continue;}
case 3675:{f.StackOp("dup");f.Pc=3676;continue;}
case 3676:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",3679);}
case 3679:{f.Locals[12]=f.Pop();f.Pc=3681;continue;}
case 3681:{f.Push(JValue.I(0));f.Pc=3682;continue;}
case 3682:{f.Locals[13]=f.Pop();f.Pc=3684;continue;}
case 3684:{f.Push(f.Locals[13]);f.Pc=3686;continue;}
case 3686:{f.Push(f.Locals[11]);f.Pc=3688;continue;}
case 3688:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?3713:3691;continue;}
case 3691:{f.Push(f.Locals[12]);f.Pc=3693;continue;}
case 3693:{f.Push(f.Locals[9]);f.Pc=3695;continue;}
case 3695:{f.Push(f.Locals[13]);f.Pc=3697;continue;}
case 3697:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",3700);}
case 3700:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3703;continue;}
case 3703:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",3706);}
case 3706:{f.StackOp("pop");f.Pc=3707;continue;}
case 3707:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=3710;continue;}
case 3710:{f.Pc=3684;continue;}
case 3713:{f.Push(f.Locals[9]);f.Pc=3715;continue;}
case 3715:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",3718);}
case 3718:{f.Pc=f.Pop().Int!=0?3730:3721;continue;}
case 3721:{f.Push(f.Locals[12]);f.Pc=3723;continue;}
case 3723:{f.Push(f.Locals[0]);f.Pc=3724;continue;}
case 3724:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",3727);}
case 3727:{f.Pc=f.Pop().Int!=0?3732:3730;continue;}
case 3730:{f.Push(JValue.I(0));f.Pc=3731;continue;}
case 3731:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3732:{f.Pc=3758;continue;}
case 3735:{f.Push(f.Locals[9]);f.Pc=3737;continue;}
case 3737:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",3740);}
case 3740:{f.Pc=f.Pop().Int!=0?3756:3743;continue;}
case 3743:{f.Push(f.Locals[0]);f.Pc=3744;continue;}
case 3744:{f.Push(f.Locals[9]);f.Pc=3746;continue;}
case 3746:{f.Push(JValue.I(0));f.Pc=3747;continue;}
case 3747:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",3750);}
case 3750:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",3753);}
case 3753:{f.Pc=f.Pop().Int!=0?3758:3756;continue;}
case 3756:{f.Push(JValue.I(0));f.Pc=3757;continue;}
case 3757:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3758:{f.Pc=14247;continue;}
case 3761:{f.Push(f.Locals[1]);f.Pc=3762;continue;}
case 3762:{f.Push(JValue.R(rt.String("BottomGraveyard")));f.Pc=3765;continue;}
case 3765:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3768);}
case 3768:{f.Pc=f.Pop().Int==0?3813:3771;continue;}
case 3771:{f.Push(f.Locals[0]);f.Pc=3772;continue;}
case 3772:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",3775);}
case 3775:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=3778;continue;}
case 3778:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",3781);}
case 3781:{f.Locals[9]=f.Pop();f.Pc=3783;continue;}
case 3783:{f.Push(f.Locals[9]);f.Pc=3785;continue;}
case 3785:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",3790);}
case 3790:{f.Pc=f.Pop().Int!=0?3808:3793;continue;}
case 3793:{f.Push(f.Locals[0]);f.Pc=3794;continue;}
case 3794:{f.Push(f.Locals[9]);f.Pc=3796;continue;}
case 3796:{f.Push(JValue.I(0));f.Pc=3797;continue;}
case 3797:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",3802);}
case 3802:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",3805);}
case 3805:{f.Pc=f.Pop().Int!=0?3810:3808;continue;}
case 3808:{f.Push(JValue.I(0));f.Pc=3809;continue;}
case 3809:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3810:{f.Pc=14247;continue;}
case 3813:{f.Push(f.Locals[1]);f.Pc=3814;continue;}
case 3814:{f.Push(JValue.R(rt.String("TopLibrary")));f.Pc=3817;continue;}
case 3817:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3820);}
case 3820:{f.Pc=f.Pop().Int!=0?3833:3823;continue;}
case 3823:{f.Push(f.Locals[1]);f.Pc=3824;continue;}
case 3824:{f.Push(JValue.R(rt.String("BottomLibrary")));f.Pc=3827;continue;}
case 3827:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3830);}
case 3830:{f.Pc=f.Pop().Int==0?3942:3833;continue;}
case 3833:{f.Push(f.Locals[0]);f.Pc=3834;continue;}
case 3834:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",3837);}
case 3837:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=3840;continue;}
case 3840:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",3843);}
case 3843:{f.Locals[9]=f.Pop();f.Pc=3845;continue;}
case 3845:{f.Push(f.Locals[1]);f.Pc=3846;continue;}
case 3846:{f.Push(JValue.R(rt.String("TopLibrary")));f.Pc=3849;continue;}
case 3849:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3852);}
case 3852:{f.Pc=f.Pop().Int!=0?3912:3855;continue;}
case 3855:{f.Push(f.Locals[1]);f.Pc=3856;continue;}
case 3856:{f.Push(JValue.R(rt.String("_")));f.Pc=3858;continue;}
case 3858:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",3861);}
case 3861:{f.Pc=f.Pop().Int==0?3883:3864;continue;}
case 3864:{f.Push(f.Locals[9]);f.Pc=3866;continue;}
case 3866:{f.Push(f.Locals[1]);f.Pc=3867;continue;}
case 3867:{f.Push(JValue.R(rt.String("_")));f.Pc=3869;continue;}
case 3869:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",3872);}
case 3872:{f.Push(JValue.I(1));f.Pc=3873;continue;}
case 3873:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=3874;continue;}
case 3874:{f.Push(f.Locals[2]);f.Pc=3875;continue;}
case 3875:{f.Push(f.Locals[3]);f.Pc=3876;continue;}
case 3876:{f.Push(f.Locals[4]);f.Pc=3878;continue;}
case 3878:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",3881);}
case 3881:{f.Locals[9]=f.Pop();f.Pc=3883;continue;}
case 3883:{f.Push(f.Locals[1]);f.Pc=3884;continue;}
case 3884:{f.Push(JValue.R(rt.String("Bottom")));f.Pc=3887;continue;}
case 3887:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3890);}
case 3890:{f.Pc=f.Pop().Int==0?3912:3893;continue;}
case 3893:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3896;continue;}
case 3896:{f.StackOp("dup");f.Pc=3897;continue;}
case 3897:{f.Push(f.Locals[9]);f.Pc=3899;continue;}
case 3899:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",3902);}
case 3902:{f.Locals[9]=f.Pop();f.Pc=3904;continue;}
case 3904:{f.Push(f.Locals[9]);f.Pc=3906;continue;}
case 3906:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3909;continue;}
case 3909:{return rt.Call(f,"java/util/Collections","reverse","(Ljava/util/List;)V","invokestatic",3912);}
case 3912:{f.Push(f.Locals[9]);f.Pc=3914;continue;}
case 3914:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",3919);}
case 3919:{f.Pc=f.Pop().Int!=0?3937:3922;continue;}
case 3922:{f.Push(f.Locals[0]);f.Pc=3923;continue;}
case 3923:{f.Push(f.Locals[9]);f.Pc=3925;continue;}
case 3925:{f.Push(JValue.I(0));f.Pc=3926;continue;}
case 3926:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",3931);}
case 3931:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",3934);}
case 3934:{f.Pc=f.Pop().Int!=0?3939:3937;continue;}
case 3937:{f.Push(JValue.I(0));f.Pc=3938;continue;}
case 3938:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3939:{f.Pc=14247;continue;}
case 3942:{f.Push(f.Locals[1]);f.Pc=3943;continue;}
case 3943:{f.Push(JValue.R(rt.String("Cloned")));f.Pc=3946;continue;}
case 3946:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3949);}
case 3949:{f.Pc=f.Pop().Int==0?3972:3952;continue;}
case 3952:{f.Push(f.Locals[0]);f.Pc=3953;continue;}
case 3953:{return rt.Call(f,"forge/game/card/Card","getCloneOrigin","()Lforge/game/card/Card;","invokevirtual",3956);}
case 3956:{f.Pc=f.Pop().Reference==null?3970:3959;continue;}
case 3959:{f.Push(f.Locals[0]);f.Pc=3960;continue;}
case 3960:{return rt.Call(f,"forge/game/card/Card","getCloneOrigin","()Lforge/game/card/Card;","invokevirtual",3963);}
case 3963:{f.Push(f.Locals[3]);f.Pc=3964;continue;}
case 3964:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",3967);}
case 3967:{f.Pc=f.Pop().Int!=0?14247:3970;continue;}
case 3970:{f.Push(JValue.I(0));f.Pc=3971;continue;}
case 3971:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 3972:{f.Push(f.Locals[1]);f.Pc=3973;continue;}
case 3973:{f.Push(JValue.R(rt.String("SharesCMCWith")));f.Pc=3976;continue;}
case 3976:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",3979);}
case 3979:{f.Pc=f.Pop().Int==0?4033:3982;continue;}
case 3982:{f.Push(f.Locals[1]);f.Pc=3983;continue;}
case 3983:{f.Push(JValue.R(rt.String("SharesCMCWith")));f.Pc=3986;continue;}
case 3986:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3989);}
case 3989:{f.Pc=f.Pop().Int==0?4002:3992;continue;}
case 3992:{f.Push(f.Locals[0]);f.Pc=3993;continue;}
case 3993:{f.Push(f.Locals[3]);f.Pc=3994;continue;}
case 3994:{return rt.Call(f,"forge/game/card/Card","sharesCMCWith","(Lforge/game/card/Card;)Z","invokevirtual",3997);}
case 3997:{f.Pc=f.Pop().Int!=0?14247:4000;continue;}
case 4000:{f.Push(JValue.I(0));f.Pc=4001;continue;}
case 4001:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4002:{f.Push(f.Locals[1]);f.Pc=4003;continue;}
case 4003:{f.Push(JValue.R(rt.String("SharesCMCWith ")));f.Pc=4006;continue;}
case 4006:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4009);}
case 4009:{f.Push(JValue.I(1));f.Pc=4010;continue;}
case 4010:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4011;continue;}
case 4011:{f.Locals[9]=f.Pop();f.Pc=4013;continue;}
case 4013:{f.Push(f.Locals[3]);f.Pc=4014;continue;}
case 4014:{f.Push(f.Locals[9]);f.Pc=4016;continue;}
case 4016:{f.Push(f.Locals[4]);f.Pc=4018;continue;}
case 4018:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",4021);}
case 4021:{f.Locals[10]=f.Pop();f.Pc=4023;continue;}
case 4023:{f.Push(f.Locals[10]);f.Pc=4025;continue;}
case 4025:{f.Push(f.Locals[0]);f.Pc=4026;continue;}
case 4026:{return rt.Call(f,"forge/game/card/CardPredicates","sharesCMCWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",4029);}
case 4029:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",4032);}
case 4032:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4033:{f.Push(f.Locals[1]);f.Pc=4034;continue;}
case 4034:{f.Push(JValue.R(rt.String("SharesColorWith")));f.Pc=4037;continue;}
case 4037:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4040);}
case 4040:{f.Pc=f.Pop().Int==0?4512:4043;continue;}
case 4043:{f.Push(f.Locals[0]);f.Pc=4044;continue;}
case 4044:{return rt.Call(f,"forge/game/card/Card","isColorless","()Z","invokevirtual",4047);}
case 4047:{f.Pc=f.Pop().Int==0?4052:4050;continue;}
case 4050:{f.Push(JValue.I(0));f.Pc=4051;continue;}
case 4051:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4052:{f.Push(f.Locals[1]);f.Pc=4053;continue;}
case 4053:{f.Push(JValue.R(rt.String("SharesColorWith")));f.Pc=4056;continue;}
case 4056:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4059);}
case 4059:{f.Pc=f.Pop().Int==0?4072:4062;continue;}
case 4062:{f.Push(f.Locals[0]);f.Pc=4063;continue;}
case 4063:{f.Push(f.Locals[3]);f.Pc=4064;continue;}
case 4064:{return rt.Call(f,"forge/game/card/Card","sharesColorWith","(Lforge/game/card/Card;)Z","invokevirtual",4067);}
case 4067:{f.Pc=f.Pop().Int!=0?14247:4070;continue;}
case 4070:{f.Push(JValue.I(0));f.Pc=4071;continue;}
case 4071:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4072:{f.Push(f.Locals[1]);f.Pc=4073;continue;}
case 4073:{f.Push(JValue.R(rt.String("SharesColorWithOther")));f.Pc=4076;continue;}
case 4076:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4079);}
case 4079:{f.Pc=f.Pop().Int==0?4120:4082;continue;}
case 4082:{f.Push(f.Locals[1]);f.Pc=4083;continue;}
case 4083:{f.Push(JValue.R(rt.String("SharesColorWithOther ")));f.Pc=4086;continue;}
case 4086:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4089);}
case 4089:{f.Push(JValue.I(1));f.Pc=4090;continue;}
case 4090:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4091;continue;}
case 4091:{f.Locals[9]=f.Pop();f.Pc=4093;continue;}
case 4093:{f.Push(f.Locals[3]);f.Pc=4094;continue;}
case 4094:{f.Push(f.Locals[9]);f.Pc=4096;continue;}
case 4096:{f.Push(f.Locals[4]);f.Pc=4098;continue;}
case 4098:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",4101);}
case 4101:{f.Locals[10]=f.Pop();f.Pc=4103;continue;}
case 4103:{f.Push(f.Locals[10]);f.Pc=4105;continue;}
case 4105:{f.Push(f.Locals[0]);f.Pc=4106;continue;}
case 4106:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",4109);}
case 4109:{f.StackOp("pop");f.Pc=4110;continue;}
case 4110:{f.Push(f.Locals[10]);f.Pc=4112;continue;}
case 4112:{f.Push(f.Locals[0]);f.Pc=4113;continue;}
case 4113:{return rt.Call(f,"forge/game/card/CardPredicates","sharesColorWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",4116);}
case 4116:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",4119);}
case 4119:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4120:{f.Push(f.Locals[1]);f.Pc=4121;continue;}
case 4121:{f.Push(JValue.R(rt.String("SharesColorWith ")));f.Pc=4124;continue;}
case 4124:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4127);}
case 4127:{f.Push(JValue.I(1));f.Pc=4128;continue;}
case 4128:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4129;continue;}
case 4129:{f.Locals[9]=f.Pop();f.Pc=4131;continue;}
case 4131:{f.Push(f.Locals[9]);f.Pc=4133;continue;}
case 4133:{f.Locals[10]=f.Pop();f.Pc=4135;continue;}
case 4135:{f.Push(JValue.I(-1));f.Pc=4136;continue;}
case 4136:{f.Locals[11]=f.Pop();f.Pc=4138;continue;}
case 4138:{f.Push(f.Locals[10]);f.Pc=4140;continue;}
case 4140:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",4143);}
case 4143:{switch(f.Pop().Int){case 122487003:f.Pc=4235;break;case 264221645:f.Pc=4218;break;case 346781504:f.Pc=4184;break;case 883682928:f.Pc=4201;break;default:f.Pc=4249;break;}continue;}
case 4184:{f.Push(f.Locals[10]);f.Pc=4186;continue;}
case 4186:{f.Push(JValue.R(rt.String("MostProminentColor")));f.Pc=4189;continue;}
case 4189:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4192);}
case 4192:{f.Pc=f.Pop().Int==0?4249:4195;continue;}
case 4195:{f.Push(JValue.I(0));f.Pc=4196;continue;}
case 4196:{f.Locals[11]=f.Pop();f.Pc=4198;continue;}
case 4198:{f.Pc=4249;continue;}
case 4201:{f.Push(f.Locals[10]);f.Pc=4203;continue;}
case 4203:{f.Push(JValue.R(rt.String("LastCastThisTurn")));f.Pc=4206;continue;}
case 4206:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4209);}
case 4209:{f.Pc=f.Pop().Int==0?4249:4212;continue;}
case 4212:{f.Push(JValue.I(1));f.Pc=4213;continue;}
case 4213:{f.Locals[11]=f.Pop();f.Pc=4215;continue;}
case 4215:{f.Pc=4249;continue;}
case 4218:{f.Push(f.Locals[10]);f.Pc=4220;continue;}
case 4220:{f.Push(JValue.R(rt.String("ActivationColor")));f.Pc=4223;continue;}
case 4223:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4226);}
case 4226:{f.Pc=f.Pop().Int==0?4249:4229;continue;}
case 4229:{f.Push(JValue.I(2));f.Pc=4230;continue;}
case 4230:{f.Locals[11]=f.Pop();f.Pc=4232;continue;}
case 4232:{f.Pc=4249;continue;}
case 4235:{f.Push(f.Locals[10]);f.Pc=4237;continue;}
case 4237:{f.Push(JValue.R(rt.String("TriggeredProduced")));f.Pc=4240;continue;}
case 4240:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4243);}
case 4243:{f.Pc=f.Pop().Int==0?4249:4246;continue;}
case 4246:{f.Push(JValue.I(3));f.Pc=4247;continue;}
case 4247:{f.Locals[11]=f.Pop();f.Pc=4249;continue;}
case 4249:{f.Push(f.Locals[11]);f.Pc=4251;continue;}
case 4251:{switch(f.Pop().Int){case 0:f.Pc=4280;break;case 1:f.Pc=4307;break;case 2:f.Pc=4355;break;case 3:f.Pc=4423;break;default:f.Pc=4489;break;}continue;}
case 4280:{f.Push(f.Locals[5]);f.Pc=4282;continue;}
case 4282:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=4285;continue;}
case 4285:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",4288);}
case 4288:{return rt.Call(f,"forge/game/card/CardFactoryUtil","getMostProminentColors","(Ljava/lang/Iterable;)B","invokestatic",4291);}
case 4291:{f.Locals[12]=f.Pop();f.Pc=4293;continue;}
case 4293:{f.Push(f.Locals[0]);f.Pc=4294;continue;}
case 4294:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",4297);}
case 4297:{f.Push(f.Locals[12]);f.Pc=4299;continue;}
case 4299:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",4302);}
case 4302:{f.Pc=f.Pop().Int!=0?4509:4305;continue;}
case 4305:{f.Push(JValue.I(0));f.Pc=4306;continue;}
case 4306:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4307:{f.Push(f.Locals[5]);f.Pc=4309;continue;}
case 4309:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",4312);}
case 4312:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellCardsCastThisTurn","()Ljava/util/List;","invokevirtual",4315);}
case 4315:{f.Locals[13]=f.Pop();f.Pc=4317;continue;}
case 4317:{f.Push(f.Locals[13]);f.Pc=4319;continue;}
case 4319:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",4324);}
case 4324:{f.Pc=f.Pop().Int!=0?4353:4327;continue;}
case 4327:{f.Push(f.Locals[0]);f.Pc=4328;continue;}
case 4328:{f.Push(f.Locals[13]);f.Pc=4330;continue;}
case 4330:{f.Push(f.Locals[13]);f.Pc=4332;continue;}
case 4332:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",4337);}
case 4337:{f.Push(JValue.I(1));f.Pc=4338;continue;}
case 4338:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=4339;continue;}
case 4339:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",4344);}
case 4344:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4347;continue;}
case 4347:{return rt.Call(f,"forge/game/card/Card","sharesColorWith","(Lforge/game/card/Card;)Z","invokevirtual",4350);}
case 4350:{f.Pc=f.Pop().Int!=0?4509:4353;continue;}
case 4353:{f.Push(JValue.I(0));f.Pc=4354;continue;}
case 4354:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4355:{f.Push(f.Locals[5]);f.Pc=4357;continue;}
case 4357:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",4360);}
case 4360:{f.Push(f.Locals[4]);f.Pc=4362;continue;}
case 4362:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4365;continue;}
case 4365:{return rt.Call(f,"forge/game/zone/MagicStack","getInstanceMatchingSpellAbilityID","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",4368);}
case 4368:{f.Locals[14]=f.Pop();f.Pc=4370;continue;}
case 4370:{f.Push(f.Locals[14]);f.Pc=4372;continue;}
case 4372:{f.Pc=f.Pop().Reference!=null?4377:4375;continue;}
case 4375:{f.Push(JValue.I(0));f.Pc=4376;continue;}
case 4376:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4377:{f.Push(f.Locals[14]);f.Pc=4379;continue;}
case 4379:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4382);}
case 4382:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",4385);}
case 4385:{f.Locals[15]=f.Pop();f.Pc=4387;continue;}
case 4387:{f.Push(f.Locals[15]);f.Pc=4389;continue;}
case 4389:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",4394);}
case 4394:{f.Pc=f.Pop().Int!=0?4421:4397;continue;}
case 4397:{f.Push(f.Locals[0]);f.Pc=4398;continue;}
case 4398:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",4401);}
case 4401:{f.Push(f.Locals[15]);f.Pc=4403;continue;}
case 4403:{f.Push(JValue.I(0));f.Pc=4404;continue;}
case 4404:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",4409);}
case 4409:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4412;continue;}
case 4412:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",4415);}
case 4415:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",4418);}
case 4418:{f.Pc=f.Pop().Int!=0?4509:4421;continue;}
case 4421:{f.Push(JValue.I(0));f.Pc=4422;continue;}
case 4422:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4423:{f.Push(f.Locals[4]);f.Pc=4425;continue;}
case 4425:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4428;continue;}
case 4428:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4431);}
case 4431:{f.Locals[16]=f.Pop();f.Pc=4433;continue;}
case 4433:{f.Push(f.Locals[16]);f.Pc=4435;continue;}
case 4435:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"));f.Pc=4438;continue;}
case 4438:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",4441);}
case 4441:{f.Locals[17]=f.Pop();f.Pc=4443;continue;}
case 4443:{f.Push(f.Locals[17]);f.Pc=4445;continue;}
case 4445:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/String")?1:0));f.Pc=4448;continue;}
case 4448:{f.Pc=f.Pop().Int!=0?4453:4451;continue;}
case 4451:{f.Push(JValue.I(0));f.Pc=4452;continue;}
case 4452:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4453:{f.Push(f.Locals[17]);f.Pc=4455;continue;}
case 4455:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4458;continue;}
case 4458:{f.Locals[18]=f.Pop();f.Pc=4460;continue;}
case 4460:{f.Push(f.Locals[18]);f.Pc=4462;continue;}
case 4462:{f.Push(JValue.R(rt.String(" ")));f.Pc=4464;continue;}
case 4464:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4467);}
case 4467:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",4470);}
case 4470:{f.Locals[19]=f.Pop();f.Pc=4472;continue;}
case 4472:{f.Push(f.Locals[0]);f.Pc=4473;continue;}
case 4473:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",4476);}
case 4476:{f.Push(f.Locals[19]);f.Pc=4478;continue;}
case 4478:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",4481);}
case 4481:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",4484);}
case 4484:{f.Pc=f.Pop().Int!=0?4509:4487;continue;}
case 4487:{f.Push(JValue.I(0));f.Pc=4488;continue;}
case 4488:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4489:{f.Push(f.Locals[3]);f.Pc=4490;continue;}
case 4490:{f.Push(f.Locals[9]);f.Pc=4492;continue;}
case 4492:{f.Push(f.Locals[4]);f.Pc=4494;continue;}
case 4494:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",4497);}
case 4497:{f.Push(f.Locals[0]);f.Pc=4498;continue;}
case 4498:{return rt.Call(f,"forge/game/card/CardPredicates","sharesColorWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",4501);}
case 4501:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",4504);}
case 4504:{f.Pc=f.Pop().Int!=0?4509:4507;continue;}
case 4507:{f.Push(JValue.I(0));f.Pc=4508;continue;}
case 4508:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4509:{f.Pc=14247;continue;}
case 4512:{f.Push(f.Locals[1]);f.Pc=4513;continue;}
case 4513:{f.Push(JValue.R(rt.String("MostProminentColor")));f.Pc=4516;continue;}
case 4516:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4519);}
case 4519:{f.Pc=f.Pop().Int==0?4581:4522;continue;}
case 4522:{f.Push(f.Locals[1]);f.Pc=4523;continue;}
case 4523:{f.Push(JValue.R(rt.String(" ")));f.Pc=4525;continue;}
case 4525:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4528);}
case 4528:{f.Locals[9]=f.Pop();f.Pc=4530;continue;}
case 4530:{f.Push(f.Locals[9]);f.Pc=4532;continue;}
case 4532:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4533;continue;}
case 4533:{f.Push(JValue.I(1));f.Pc=4534;continue;}
case 4534:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?4548:4537;continue;}
case 4537:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=4540;continue;}
case 4540:{f.Push(JValue.R(rt.String("WARNING! Using MostProminentColor property without a color.")));f.Pc=4543;continue;}
case 4543:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",4546);}
case 4546:{f.Push(JValue.I(0));f.Pc=4547;continue;}
case 4547:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4548:{f.Push(f.Locals[9]);f.Pc=4550;continue;}
case 4550:{f.Push(JValue.I(1));f.Pc=4551;continue;}
case 4551:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4552;continue;}
case 4552:{f.Locals[10]=f.Pop();f.Pc=4554;continue;}
case 4554:{f.Push(f.Locals[5]);f.Pc=4556;continue;}
case 4556:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=4559;continue;}
case 4559:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",4562);}
case 4562:{return rt.Call(f,"forge/game/card/CardFactoryUtil","getMostProminentColors","(Ljava/lang/Iterable;)B","invokestatic",4565);}
case 4565:{f.Locals[11]=f.Pop();f.Pc=4567;continue;}
case 4567:{f.Push(f.Locals[11]);f.Pc=4569;continue;}
case 4569:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",4572);}
case 4572:{f.Push(f.Locals[10]);f.Pc=4574;continue;}
case 4574:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",4577);}
case 4577:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",4580);}
case 4580:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4581:{f.Push(f.Locals[1]);f.Pc=4582;continue;}
case 4582:{f.Push(JValue.R(rt.String("MostProminentCreatureTypeInLibrary")));f.Pc=4585;continue;}
case 4585:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4588);}
case 4588:{f.Pc=f.Pop().Int==0?4656:4591;continue;}
case 4591:{f.Push(f.Locals[2]);f.Pc=4592;continue;}
case 4592:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=4595;continue;}
case 4595:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",4598);}
case 4598:{f.Locals[9]=f.Pop();f.Pc=4600;continue;}
case 4600:{f.Push(f.Locals[9]);f.Pc=4602;continue;}
case 4602:{return rt.Call(f,"forge/game/card/CardFactoryUtil","getMostProminentCreatureType","(Lforge/game/card/CardCollectionView;)Ljava/lang/Iterable;","invokestatic",4605);}
case 4605:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",4610);}
case 4610:{f.Locals[10]=f.Pop();f.Pc=4612;continue;}
case 4612:{f.Push(f.Locals[10]);f.Pc=4614;continue;}
case 4614:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",4619);}
case 4619:{f.Pc=f.Pop().Int==0?4653:4622;continue;}
case 4622:{f.Push(f.Locals[10]);f.Pc=4624;continue;}
case 4624:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",4629);}
case 4629:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4632;continue;}
case 4632:{f.Locals[11]=f.Pop();f.Pc=4634;continue;}
case 4634:{f.Push(f.Locals[0]);f.Pc=4635;continue;}
case 4635:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",4638);}
case 4638:{f.Push(f.Locals[11]);f.Pc=4640;continue;}
case 4640:{return rt.Call(f,"forge/card/CardTypeView","hasCreatureType","(Ljava/lang/String;)Z","invokeinterface",4645);}
case 4645:{f.Pc=f.Pop().Int!=0?4650:4648;continue;}
case 4648:{f.Push(JValue.I(0));f.Pc=4649;continue;}
case 4649:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4650:{f.Pc=4612;continue;}
case 4653:{f.Pc=14247;continue;}
case 4656:{f.Push(f.Locals[1]);f.Pc=4657;continue;}
case 4657:{f.Push(JValue.R(rt.String("sharesCreatureTypeWith")));f.Pc=4660;continue;}
case 4660:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4663);}
case 4663:{f.Pc=f.Pop().Int==0?4902:4666;continue;}
case 4666:{f.Push(f.Locals[1]);f.Pc=4667;continue;}
case 4667:{f.Push(JValue.R(rt.String("sharesCreatureTypeWith")));f.Pc=4670;continue;}
case 4670:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4673);}
case 4673:{f.Pc=f.Pop().Int==0?4686:4676;continue;}
case 4676:{f.Push(f.Locals[0]);f.Pc=4677;continue;}
case 4677:{f.Push(f.Locals[3]);f.Pc=4678;continue;}
case 4678:{return rt.Call(f,"forge/game/card/Card","sharesCreatureTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",4681);}
case 4681:{f.Pc=f.Pop().Int!=0?14247:4684;continue;}
case 4684:{f.Push(JValue.I(0));f.Pc=4685;continue;}
case 4685:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4686:{f.Push(f.Locals[1]);f.Pc=4687;continue;}
case 4687:{f.Push(JValue.R(rt.String(" ")));f.Pc=4689;continue;}
case 4689:{f.Push(JValue.I(2));f.Pc=4690;continue;}
case 4690:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",4693);}
case 4693:{f.Push(JValue.I(1));f.Pc=4694;continue;}
case 4694:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4695;continue;}
case 4695:{f.Locals[9]=f.Pop();f.Pc=4697;continue;}
case 4697:{f.Push(f.Locals[9]);f.Pc=4699;continue;}
case 4699:{f.Locals[10]=f.Pop();f.Pc=4701;continue;}
case 4701:{f.Push(JValue.I(-1));f.Pc=4702;continue;}
case 4702:{f.Locals[11]=f.Pop();f.Pc=4704;continue;}
case 4704:{f.Push(f.Locals[10]);f.Pc=4706;continue;}
case 4706:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",4709);}
case 4709:{switch(f.Pop().Int){case 505242904:f.Pc=4728;break;default:f.Pc=4742;break;}continue;}
case 4728:{f.Push(f.Locals[10]);f.Pc=4730;continue;}
case 4730:{f.Push(JValue.R(rt.String("Commander")));f.Pc=4733;continue;}
case 4733:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4736);}
case 4736:{f.Pc=f.Pop().Int==0?4742:4739;continue;}
case 4739:{f.Push(JValue.I(0));f.Pc=4740;continue;}
case 4740:{f.Locals[11]=f.Pop();f.Pc=4742;continue;}
case 4742:{f.Push(f.Locals[11]);f.Pc=4744;continue;}
case 4744:{switch(f.Pop().Int){case 0:f.Pc=4764;break;default:f.Pc=4851;break;}continue;}
case 4764:{f.Push(f.Locals[2]);f.Pc=4765;continue;}
case 4765:{return rt.Call(f,"forge/game/player/Player","getCommanders","()Ljava/util/List;","invokevirtual",4768);}
case 4768:{f.Locals[12]=f.Pop();f.Pc=4770;continue;}
case 4770:{f.Push(f.Locals[12]);f.Pc=4772;continue;}
case 4772:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",4777);}
case 4777:{f.Locals[13]=f.Pop();f.Pc=4779;continue;}
case 4779:{f.Push(f.Locals[13]);f.Pc=4781;continue;}
case 4781:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",4786);}
case 4786:{f.Pc=f.Pop().Int==0?4849:4789;continue;}
case 4789:{f.Push(f.Locals[13]);f.Pc=4791;continue;}
case 4791:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",4796);}
case 4796:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4799;continue;}
case 4799:{f.Locals[14]=f.Pop();f.Pc=4801;continue;}
case 4801:{f.Push(f.Locals[5]);f.Pc=4803;continue;}
case 4803:{f.Push(f.Locals[14]);f.Pc=4805;continue;}
case 4805:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",4808);}
case 4808:{f.Locals[14]=f.Pop();f.Pc=4810;continue;}
case 4810:{f.Push(f.Locals[14]);f.Pc=4812;continue;}
case 4812:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",4815);}
case 4815:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",4818);}
case 4818:{return rt.Call(f,"forge/game/zone/ZoneType","isHidden","()Z","invokevirtual",4821);}
case 4821:{f.Pc=f.Pop().Int!=0?4779:4824;continue;}
case 4824:{f.Push(f.Locals[14]);f.Pc=4826;continue;}
case 4826:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",4829);}
case 4829:{f.Pc=f.Pop().Int==0?4835:4832;continue;}
case 4832:{f.Pc=4779;continue;}
case 4835:{f.Push(f.Locals[0]);f.Pc=4836;continue;}
case 4836:{f.Push(f.Locals[14]);f.Pc=4838;continue;}
case 4838:{return rt.Call(f,"forge/game/card/Card","sharesCreatureTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",4841);}
case 4841:{f.Pc=f.Pop().Int==0?4846:4844;continue;}
case 4844:{f.Push(JValue.I(1));f.Pc=4845;continue;}
case 4845:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4846:{f.Pc=4779;continue;}
case 4849:{f.Push(JValue.I(0));f.Pc=4850;continue;}
case 4850:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4851:{f.Push(f.Locals[3]);f.Pc=4852;continue;}
case 4852:{f.Push(f.Locals[9]);f.Pc=4854;continue;}
case 4854:{f.Push(f.Locals[4]);f.Pc=4856;continue;}
case 4856:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",4859);}
case 4859:{f.Locals[13]=f.Pop();f.Pc=4861;continue;}
case 4861:{f.Push(f.Locals[1]);f.Pc=4862;continue;}
case 4862:{f.Push(JValue.R(rt.String("WithAll")));f.Pc=4865;continue;}
case 4865:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",4868);}
case 4868:{f.Pc=f.Pop().Int==0?4885:4871;continue;}
case 4871:{f.Push(f.Locals[13]);f.Pc=4873;continue;}
case 4873:{f.Push(f.Locals[0]);f.Pc=4874;continue;}
case 4874:{return rt.Call(f,"forge/game/card/CardPredicates","sharesCreatureTypeWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",4877);}
case 4877:{return rt.Call(f,"forge/game/card/CardCollection","allMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",4880);}
case 4880:{f.Pc=f.Pop().Int!=0?4899:4883;continue;}
case 4883:{f.Push(JValue.I(0));f.Pc=4884;continue;}
case 4884:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4885:{f.Push(f.Locals[13]);f.Pc=4887;continue;}
case 4887:{f.Push(f.Locals[0]);f.Pc=4888;continue;}
case 4888:{return rt.Call(f,"forge/game/card/CardPredicates","sharesCreatureTypeWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",4891);}
case 4891:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",4894);}
case 4894:{f.Pc=f.Pop().Int!=0?4899:4897;continue;}
case 4897:{f.Push(JValue.I(0));f.Pc=4898;continue;}
case 4898:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4899:{f.Pc=14247;continue;}
case 4902:{f.Push(f.Locals[1]);f.Pc=4903;continue;}
case 4903:{f.Push(JValue.R(rt.String("sharesCardTypeWith")));f.Pc=4906;continue;}
case 4906:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4909);}
case 4909:{f.Pc=f.Pop().Int==0?5254:4912;continue;}
case 4912:{f.Push(f.Locals[1]);f.Pc=4913;continue;}
case 4913:{f.Push(JValue.R(rt.String("sharesCardTypeWith")));f.Pc=4916;continue;}
case 4916:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4919);}
case 4919:{f.Pc=f.Pop().Int==0?4932:4922;continue;}
case 4922:{f.Push(f.Locals[0]);f.Pc=4923;continue;}
case 4923:{f.Push(f.Locals[3]);f.Pc=4924;continue;}
case 4924:{return rt.Call(f,"forge/game/card/Card","sharesCardTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",4927);}
case 4927:{f.Pc=f.Pop().Int!=0?14247:4930;continue;}
case 4930:{f.Push(JValue.I(0));f.Pc=4931;continue;}
case 4931:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4932:{f.Push(f.Locals[1]);f.Pc=4933;continue;}
case 4933:{f.Push(JValue.R(rt.String("sharesCardTypeWithOther")));f.Pc=4936;continue;}
case 4936:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",4939);}
case 4939:{f.Pc=f.Pop().Int==0?4980:4942;continue;}
case 4942:{f.Push(f.Locals[1]);f.Pc=4943;continue;}
case 4943:{f.Push(JValue.R(rt.String("sharesCardTypeWithOther ")));f.Pc=4946;continue;}
case 4946:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4949);}
case 4949:{f.Push(JValue.I(1));f.Pc=4950;continue;}
case 4950:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4951;continue;}
case 4951:{f.Locals[9]=f.Pop();f.Pc=4953;continue;}
case 4953:{f.Push(f.Locals[3]);f.Pc=4954;continue;}
case 4954:{f.Push(f.Locals[9]);f.Pc=4956;continue;}
case 4956:{f.Push(f.Locals[4]);f.Pc=4958;continue;}
case 4958:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",4961);}
case 4961:{f.Locals[10]=f.Pop();f.Pc=4963;continue;}
case 4963:{f.Push(f.Locals[10]);f.Pc=4965;continue;}
case 4965:{f.Push(f.Locals[0]);f.Pc=4966;continue;}
case 4966:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",4969);}
case 4969:{f.StackOp("pop");f.Pc=4970;continue;}
case 4970:{f.Push(f.Locals[10]);f.Pc=4972;continue;}
case 4972:{f.Push(f.Locals[0]);f.Pc=4973;continue;}
case 4973:{return rt.Call(f,"forge/game/card/CardPredicates","sharesCardTypeWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",4976);}
case 4976:{return rt.Call(f,"forge/util/IterableUtil","any","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Z","invokestatic",4979);}
case 4979:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 4980:{f.Push(f.Locals[1]);f.Pc=4981;continue;}
case 4981:{f.Push(JValue.R(rt.String("sharesCardTypeWith ")));f.Pc=4984;continue;}
case 4984:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",4987);}
case 4987:{f.Push(JValue.I(1));f.Pc=4988;continue;}
case 4988:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=4989;continue;}
case 4989:{f.Locals[9]=f.Pop();f.Pc=4991;continue;}
case 4991:{f.Push(f.Locals[9]);f.Pc=4993;continue;}
case 4993:{f.Locals[10]=f.Pop();f.Pc=4995;continue;}
case 4995:{f.Push(JValue.I(-1));f.Pc=4996;continue;}
case 4996:{f.Locals[11]=f.Pop();f.Pc=4998;continue;}
case 4998:{f.Push(f.Locals[10]);f.Pc=5000;continue;}
case 5000:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",5003);}
case 5003:{switch(f.Pop().Int){case 141688487:f.Pc=5045;break;case 1872857672:f.Pc=5028;break;default:f.Pc=5059;break;}continue;}
case 5028:{f.Push(f.Locals[10]);f.Pc=5030;continue;}
case 5030:{f.Push(JValue.R(rt.String("Imprinted")));f.Pc=5033;continue;}
case 5033:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5036);}
case 5036:{f.Pc=f.Pop().Int==0?5059:5039;continue;}
case 5039:{f.Push(JValue.I(0));f.Pc=5040;continue;}
case 5040:{f.Locals[11]=f.Pop();f.Pc=5042;continue;}
case 5042:{f.Pc=5059;continue;}
case 5045:{f.Push(f.Locals[10]);f.Pc=5047;continue;}
case 5047:{f.Push(JValue.R(rt.String("EachTopLibrary")));f.Pc=5050;continue;}
case 5050:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5053);}
case 5053:{f.Pc=f.Pop().Int==0?5059:5056;continue;}
case 5056:{f.Push(JValue.I(1));f.Pc=5057;continue;}
case 5057:{f.Locals[11]=f.Pop();f.Pc=5059;continue;}
case 5059:{f.Push(f.Locals[11]);f.Pc=5061;continue;}
case 5061:{switch(f.Pop().Int){case 0:f.Pc=5088;break;case 1:f.Pc=5115;break;default:f.Pc=5231;break;}continue;}
case 5088:{f.Push(f.Locals[3]);f.Pc=5089;continue;}
case 5089:{return rt.Call(f,"forge/game/card/Card","hasImprintedCard","()Z","invokevirtual",5092);}
case 5092:{f.Pc=f.Pop().Int==0?5113:5095;continue;}
case 5095:{f.Push(f.Locals[0]);f.Pc=5096;continue;}
case 5096:{f.Push(f.Locals[3]);f.Pc=5097;continue;}
case 5097:{return rt.Call(f,"forge/game/card/Card","getImprintedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",5100);}
case 5100:{f.Push(JValue.R(null));f.Pc=5101;continue;}
case 5101:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",5104);}
case 5104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5107;continue;}
case 5107:{return rt.Call(f,"forge/game/card/Card","sharesCardTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",5110);}
case 5110:{f.Pc=f.Pop().Int!=0?5251:5113;continue;}
case 5113:{f.Push(JValue.I(0));f.Pc=5114;continue;}
case 5114:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5115:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=5118;continue;}
case 5118:{f.StackOp("dup");f.Pc=5119;continue;}
case 5119:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",5122);}
case 5122:{f.Locals[12]=f.Pop();f.Pc=5124;continue;}
case 5124:{f.Push(f.Locals[5]);f.Pc=5126;continue;}
case 5126:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",5129);}
case 5129:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",5132);}
case 5132:{f.Locals[13]=f.Pop();f.Pc=5134;continue;}
case 5134:{f.Push(f.Locals[13]);f.Pc=5136;continue;}
case 5136:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",5141);}
case 5141:{f.Pc=f.Pop().Int==0?5186:5144;continue;}
case 5144:{f.Push(f.Locals[13]);f.Pc=5146;continue;}
case 5146:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",5151);}
case 5151:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5154;continue;}
case 5154:{f.Locals[14]=f.Pop();f.Pc=5156;continue;}
case 5156:{f.Push(f.Locals[14]);f.Pc=5158;continue;}
case 5158:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=5161;continue;}
case 5161:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",5164);}
case 5164:{f.Push(JValue.I(0));f.Pc=5165;continue;}
case 5165:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",5170);}
case 5170:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5173;continue;}
case 5173:{f.Locals[15]=f.Pop();f.Pc=5175;continue;}
case 5175:{f.Push(f.Locals[12]);f.Pc=5177;continue;}
case 5177:{f.Push(f.Locals[15]);f.Pc=5179;continue;}
case 5179:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",5182);}
case 5182:{f.StackOp("pop");f.Pc=5183;continue;}
case 5183:{f.Pc=5134;continue;}
case 5186:{f.Push(f.Locals[12]);f.Pc=5188;continue;}
case 5188:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",5191);}
case 5191:{f.Locals[13]=f.Pop();f.Pc=5193;continue;}
case 5193:{f.Push(f.Locals[13]);f.Pc=5195;continue;}
case 5195:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",5200);}
case 5200:{f.Pc=f.Pop().Int==0?5229:5203;continue;}
case 5203:{f.Push(f.Locals[13]);f.Pc=5205;continue;}
case 5205:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",5210);}
case 5210:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5213;continue;}
case 5213:{f.Locals[14]=f.Pop();f.Pc=5215;continue;}
case 5215:{f.Push(f.Locals[0]);f.Pc=5216;continue;}
case 5216:{f.Push(f.Locals[14]);f.Pc=5218;continue;}
case 5218:{return rt.Call(f,"forge/game/card/Card","sharesCardTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",5221);}
case 5221:{f.Pc=f.Pop().Int==0?5226:5224;continue;}
case 5224:{f.Push(JValue.I(1));f.Pc=5225;continue;}
case 5225:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5226:{f.Pc=5193;continue;}
case 5229:{f.Push(JValue.I(0));f.Pc=5230;continue;}
case 5230:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5231:{f.Push(f.Locals[3]);f.Pc=5232;continue;}
case 5232:{f.Push(f.Locals[9]);f.Pc=5234;continue;}
case 5234:{f.Push(f.Locals[4]);f.Pc=5236;continue;}
case 5236:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",5239);}
case 5239:{f.Push(f.Locals[0]);f.Pc=5240;continue;}
case 5240:{return rt.Call(f,"forge/game/card/CardPredicates","sharesCardTypeWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",5243);}
case 5243:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",5246);}
case 5246:{f.Pc=f.Pop().Int!=0?5251:5249;continue;}
case 5249:{f.Push(JValue.I(0));f.Pc=5250;continue;}
case 5250:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5251:{f.Pc=14247;continue;}
case 5254:{f.Push(f.Locals[1]);f.Pc=5255;continue;}
case 5255:{f.Push(JValue.R(rt.String("sharesAllCardTypesWithOther")));f.Pc=5258;continue;}
case 5258:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5261);}
case 5261:{f.Pc=f.Pop().Int==0?5302:5264;continue;}
case 5264:{f.Push(f.Locals[1]);f.Pc=5265;continue;}
case 5265:{f.Push(JValue.R(rt.String("sharesAllCardTypesWithOther ")));f.Pc=5268;continue;}
case 5268:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",5271);}
case 5271:{f.Push(JValue.I(1));f.Pc=5272;continue;}
case 5272:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5273;continue;}
case 5273:{f.Locals[9]=f.Pop();f.Pc=5275;continue;}
case 5275:{f.Push(f.Locals[3]);f.Pc=5276;continue;}
case 5276:{f.Push(f.Locals[9]);f.Pc=5278;continue;}
case 5278:{f.Push(f.Locals[4]);f.Pc=5280;continue;}
case 5280:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",5283);}
case 5283:{f.Locals[10]=f.Pop();f.Pc=5285;continue;}
case 5285:{f.Push(f.Locals[10]);f.Pc=5287;continue;}
case 5287:{f.Push(f.Locals[0]);f.Pc=5288;continue;}
case 5288:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",5291);}
case 5291:{f.StackOp("pop");f.Pc=5292;continue;}
case 5292:{f.Push(f.Locals[10]);f.Pc=5294;continue;}
case 5294:{f.Push(f.Locals[0]);f.Pc=5295;continue;}
case 5295:{return rt.Call(f,"forge/game/card/CardPredicates","sharesAllCardTypesWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",5298);}
case 5298:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",5301);}
case 5301:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5302:{f.Push(f.Locals[1]);f.Pc=5303;continue;}
case 5303:{f.Push(JValue.R(rt.String("sharesLandTypeWith")));f.Pc=5306;continue;}
case 5306:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5309);}
case 5309:{f.Pc=f.Pop().Int==0?5346:5312;continue;}
case 5312:{f.Push(f.Locals[1]);f.Pc=5313;continue;}
case 5313:{f.Push(JValue.R(rt.String("sharesLandTypeWith ")));f.Pc=5316;continue;}
case 5316:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",5319);}
case 5319:{f.Push(JValue.I(1));f.Pc=5320;continue;}
case 5320:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5321;continue;}
case 5321:{f.Locals[9]=f.Pop();f.Pc=5323;continue;}
case 5323:{f.Push(f.Locals[3]);f.Pc=5324;continue;}
case 5324:{f.Push(f.Locals[9]);f.Pc=5326;continue;}
case 5326:{f.Push(f.Locals[4]);f.Pc=5328;continue;}
case 5328:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",5331);}
case 5331:{f.Push(f.Locals[0]);f.Pc=5332;continue;}
case 5332:{return rt.Call(f,"forge/game/card/CardPredicates","sharesLandTypeWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",5335);}
case 5335:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",5338);}
case 5338:{f.Pc=f.Pop().Int!=0?5343:5341;continue;}
case 5341:{f.Push(JValue.I(0));f.Pc=5342;continue;}
case 5342:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5343:{f.Pc=14247;continue;}
case 5346:{f.Push(f.Locals[1]);f.Pc=5347;continue;}
case 5347:{f.Push(JValue.R(rt.String("sharesPermanentTypeWith")));f.Pc=5350;continue;}
case 5350:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5353);}
case 5353:{f.Pc=f.Pop().Int==0?5366:5356;continue;}
case 5356:{f.Push(f.Locals[0]);f.Pc=5357;continue;}
case 5357:{f.Push(f.Locals[3]);f.Pc=5358;continue;}
case 5358:{return rt.Call(f,"forge/game/card/Card","sharesPermanentTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",5361);}
case 5361:{f.Pc=f.Pop().Int!=0?14247:5364;continue;}
case 5364:{f.Push(JValue.I(0));f.Pc=5365;continue;}
case 5365:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5366:{f.Push(f.Locals[1]);f.Pc=5367;continue;}
case 5367:{f.Push(JValue.R(rt.String("canProduceSameManaTypeWith")));f.Pc=5370;continue;}
case 5370:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5373);}
case 5373:{f.Pc=f.Pop().Int==0?5386:5376;continue;}
case 5376:{f.Push(f.Locals[0]);f.Pc=5377;continue;}
case 5377:{f.Push(f.Locals[3]);f.Pc=5378;continue;}
case 5378:{return rt.Call(f,"forge/game/card/Card","canProduceSameManaTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",5381);}
case 5381:{f.Pc=f.Pop().Int!=0?14247:5384;continue;}
case 5384:{f.Push(JValue.I(0));f.Pc=5385;continue;}
case 5385:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5386:{f.Push(f.Locals[1]);f.Pc=5387;continue;}
case 5387:{f.Push(JValue.R(rt.String("canProduceManaColor")));f.Pc=5390;continue;}
case 5390:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5393);}
case 5393:{f.Pc=f.Pop().Int==0?5460:5396;continue;}
case 5396:{f.Push(f.Locals[1]);f.Pc=5397;continue;}
case 5397:{f.Push(JValue.R(rt.String("canProduceManaColor ")));f.Pc=5400;continue;}
case 5400:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",5403);}
case 5403:{f.Push(JValue.I(1));f.Pc=5404;continue;}
case 5404:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5405;continue;}
case 5405:{f.Locals[9]=f.Pop();f.Pc=5407;continue;}
case 5407:{f.Push(f.Locals[0]);f.Pc=5408;continue;}
case 5408:{return rt.Call(f,"forge/game/card/Card","getManaAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",5411);}
case 5411:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",5416);}
case 5416:{f.Locals[10]=f.Pop();f.Pc=5418;continue;}
case 5418:{f.Push(f.Locals[10]);f.Pc=5420;continue;}
case 5420:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",5425);}
case 5425:{f.Pc=f.Pop().Int==0?5458:5428;continue;}
case 5428:{f.Push(f.Locals[10]);f.Pc=5430;continue;}
case 5430:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",5435);}
case 5435:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5438;continue;}
case 5438:{f.Locals[11]=f.Pop();f.Pc=5440;continue;}
case 5440:{f.Push(f.Locals[11]);f.Pc=5442;continue;}
case 5442:{f.Push(f.Locals[9]);f.Pc=5444;continue;}
case 5444:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",5447);}
case 5447:{return rt.Call(f,"forge/game/spellability/SpellAbility","canProduce","(Ljava/lang/String;)Z","invokevirtual",5450);}
case 5450:{f.Pc=f.Pop().Int==0?5455:5453;continue;}
case 5453:{f.Push(JValue.I(1));f.Pc=5454;continue;}
case 5454:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5455:{f.Pc=5418;continue;}
case 5458:{f.Push(JValue.I(0));f.Pc=5459;continue;}
case 5459:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5460:{f.Push(f.Locals[1]);f.Pc=5461;continue;}
case 5461:{f.Push(JValue.R(rt.String("canProduceMana")));f.Pc=5464;continue;}
case 5464:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5467);}
case 5467:{f.Pc=f.Pop().Int==0?5488:5470;continue;}
case 5470:{f.Push(f.Locals[0]);f.Pc=5471;continue;}
case 5471:{return rt.Call(f,"forge/game/card/Card","getManaAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",5474);}
case 5474:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",5479);}
case 5479:{f.Pc=f.Pop().Int!=0?5486:5482;continue;}
case 5482:{f.Push(JValue.I(1));f.Pc=5483;continue;}
case 5483:{f.Pc=5487;continue;}
case 5486:{f.Push(JValue.I(0));f.Pc=5487;continue;}
case 5487:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5488:{f.Push(f.Locals[1]);f.Pc=5489;continue;}
case 5489:{f.Push(JValue.R(rt.String("sameName")));f.Pc=5492;continue;}
case 5492:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5495);}
case 5495:{f.Pc=f.Pop().Int==0?5508:5498;continue;}
case 5498:{f.Push(f.Locals[0]);f.Pc=5499;continue;}
case 5499:{f.Push(f.Locals[3]);f.Pc=5500;continue;}
case 5500:{return rt.Call(f,"forge/game/card/Card","sharesNameWith","(Lforge/game/card/Card;)Z","invokevirtual",5503);}
case 5503:{f.Pc=f.Pop().Int!=0?14247:5506;continue;}
case 5506:{f.Push(JValue.I(0));f.Pc=5507;continue;}
case 5507:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5508:{f.Push(f.Locals[1]);f.Pc=5509;continue;}
case 5509:{f.Push(JValue.R(rt.String("sharesNameWith")));f.Pc=5512;continue;}
case 5512:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5515);}
case 5515:{f.Pc=f.Pop().Int==0?5962:5518;continue;}
case 5518:{f.Push(f.Locals[1]);f.Pc=5519;continue;}
case 5519:{f.Push(JValue.R(rt.String("sharesNameWith")));f.Pc=5522;continue;}
case 5522:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5525);}
case 5525:{f.Pc=f.Pop().Int==0?5538:5528;continue;}
case 5528:{f.Push(f.Locals[0]);f.Pc=5529;continue;}
case 5529:{f.Push(f.Locals[3]);f.Pc=5530;continue;}
case 5530:{return rt.Call(f,"forge/game/card/Card","sharesNameWith","(Lforge/game/card/Card;)Z","invokevirtual",5533);}
case 5533:{f.Pc=f.Pop().Int!=0?14247:5536;continue;}
case 5536:{f.Push(JValue.I(0));f.Pc=5537;continue;}
case 5537:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5538:{f.Push(f.Locals[1]);f.Pc=5539;continue;}
case 5539:{f.Push(JValue.R(rt.String("sharesNameWith ")));f.Pc=5542;continue;}
case 5542:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",5545);}
case 5545:{f.Push(JValue.I(1));f.Pc=5546;continue;}
case 5546:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=5547;continue;}
case 5547:{f.Locals[9]=f.Pop();f.Pc=5549;continue;}
case 5549:{f.Push(f.Locals[9]);f.Pc=5551;continue;}
case 5551:{f.Push(JValue.R(rt.String("YourGraveyard")));f.Pc=5554;continue;}
case 5554:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5557);}
case 5557:{f.Pc=f.Pop().Int==0?5577:5560;continue;}
case 5560:{f.Push(f.Locals[2]);f.Pc=5561;continue;}
case 5561:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=5564;continue;}
case 5564:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",5567);}
case 5567:{f.Push(f.Locals[0]);f.Pc=5568;continue;}
case 5568:{return rt.Call(f,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",5571);}
case 5571:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",5576);}
case 5576:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5577:{f.Push(f.Locals[9]);f.Pc=5579;continue;}
case 5579:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=5582;continue;}
case 5582:{return rt.Call(f,"forge/game/zone/ZoneType","toString","()Ljava/lang/String;","invokevirtual",5585);}
case 5585:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5588);}
case 5588:{f.Pc=f.Pop().Int==0?5609:5591;continue;}
case 5591:{f.Push(f.Locals[5]);f.Pc=5593;continue;}
case 5593:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=5596;continue;}
case 5596:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",5599);}
case 5599:{f.Push(f.Locals[0]);f.Pc=5600;continue;}
case 5600:{return rt.Call(f,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",5603);}
case 5603:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",5608);}
case 5608:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5609:{f.Push(f.Locals[9]);f.Pc=5611;continue;}
case 5611:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=5614;continue;}
case 5614:{return rt.Call(f,"forge/game/zone/ZoneType","toString","()Ljava/lang/String;","invokevirtual",5617);}
case 5617:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5620);}
case 5620:{f.Pc=f.Pop().Int==0?5641:5623;continue;}
case 5623:{f.Push(f.Locals[5]);f.Pc=5625;continue;}
case 5625:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=5628;continue;}
case 5628:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",5631);}
case 5631:{f.Push(f.Locals[0]);f.Pc=5632;continue;}
case 5632:{return rt.Call(f,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",5635);}
case 5635:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",5640);}
case 5640:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5641:{f.Push(f.Locals[9]);f.Pc=5643;continue;}
case 5643:{f.Push(JValue.R(rt.String("ThisTurnCast")));f.Pc=5646;continue;}
case 5646:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5649);}
case 5649:{f.Pc=f.Pop().Int==0?5677:5652;continue;}
case 5652:{f.Push(JValue.R(rt.String("Card")));f.Pc=5655;continue;}
case 5655:{f.Push(f.Locals[3]);f.Pc=5656;continue;}
case 5656:{f.Push(f.Locals[4]);f.Pc=5658;continue;}
case 5658:{f.Push(f.Locals[2]);f.Pc=5659;continue;}
case 5659:{return rt.Call(f,"forge/game/card/CardUtil","getThisTurnCast","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",5662);}
case 5662:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",5667);}
case 5667:{f.Push(f.Locals[0]);f.Pc=5668;continue;}
case 5668:{return rt.Call(f,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",5671);}
case 5671:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",5676);}
case 5676:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5677:{f.Push(f.Locals[9]);f.Pc=5679;continue;}
case 5679:{f.Push(JValue.R(rt.String("MovedToGrave")));f.Pc=5682;continue;}
case 5682:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5685);}
case 5685:{f.Pc=f.Pop().Int==0?5826:5688;continue;}
case 5688:{f.Push(f.Locals[4]);f.Pc=5690;continue;}
case 5690:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=5693;continue;}
case 5693:{f.Pc=f.Pop().Int!=0?5824:5696;continue;}
case 5696:{f.Push(f.Locals[4]);f.Pc=5698;continue;}
case 5698:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5701;continue;}
case 5701:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",5704);}
case 5704:{f.Locals[10]=f.Pop();f.Pc=5706;continue;}
case 5706:{f.Push(f.Locals[10]);f.Pc=5708;continue;}
case 5708:{f.Pc=f.Pop().Reference==null?5824:5711;continue;}
case 5711:{f.Push(f.Locals[10]);f.Pc=5713;continue;}
case 5713:{f.Push(JValue.R(rt.String("MovedToGrave")));f.Pc=5716;continue;}
case 5716:{f.Push(JValue.I(1));f.Pc=5717;continue;}
case 5717:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",5720);}
case 5720:{f.Pc=f.Pop().Reference==null?5824:5723;continue;}
case 5723:{f.Push(f.Locals[10]);f.Pc=5725;continue;}
case 5725:{f.Push(JValue.R(rt.String("MovedToGrave")));f.Pc=5728;continue;}
case 5728:{f.Push(JValue.I(1));f.Pc=5729;continue;}
case 5729:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",5732);}
case 5732:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",5735);}
case 5735:{f.Pc=f.Pop().Int!=0?5824:5738;continue;}
case 5738:{f.Push(f.Locals[10]);f.Pc=5740;continue;}
case 5740:{f.Push(JValue.R(rt.String("MovedToGrave")));f.Pc=5743;continue;}
case 5743:{f.Push(JValue.I(1));f.Pc=5744;continue;}
case 5744:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",5747);}
case 5747:{f.Locals[11]=f.Pop();f.Pc=5749;continue;}
case 5749:{f.Push(f.Locals[11]);f.Pc=5751;continue;}
case 5751:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",5756);}
case 5756:{f.Locals[12]=f.Pop();f.Pc=5758;continue;}
case 5758:{f.Push(f.Locals[12]);f.Pc=5760;continue;}
case 5760:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",5765);}
case 5765:{f.Pc=f.Pop().Int==0?5824:5768;continue;}
case 5768:{f.Push(f.Locals[12]);f.Pc=5770;continue;}
case 5770:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",5775);}
case 5775:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5778;continue;}
case 5778:{f.Locals[13]=f.Pop();f.Pc=5780;continue;}
case 5780:{f.Push(f.Locals[13]);f.Pc=5782;continue;}
case 5782:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",5785);}
case 5785:{f.Locals[14]=f.Pop();f.Pc=5787;continue;}
case 5787:{f.Push(f.Locals[14]);f.Pc=5789;continue;}
case 5789:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",5792);}
case 5792:{f.Pc=f.Pop().Int==0?5807:5795;continue;}
case 5795:{f.Push(f.Locals[13]);f.Pc=5797;continue;}
case 5797:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",5800);}
case 5800:{return rt.Call(f,"forge/item/IPaperCard","getName","()Ljava/lang/String;","invokeinterface",5805);}
case 5805:{f.Locals[14]=f.Pop();f.Pc=5807;continue;}
case 5807:{f.Push(f.Locals[0]);f.Pc=5808;continue;}
case 5808:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",5811);}
case 5811:{f.Push(f.Locals[14]);f.Pc=5813;continue;}
case 5813:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5816);}
case 5816:{f.Pc=f.Pop().Int==0?5821:5819;continue;}
case 5819:{f.Push(JValue.I(1));f.Pc=5820;continue;}
case 5820:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5821:{f.Pc=5758;continue;}
case 5824:{f.Push(JValue.I(0));f.Pc=5825;continue;}
case 5825:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5826:{f.Push(f.Locals[9]);f.Pc=5828;continue;}
case 5828:{f.Push(JValue.R(rt.String("NonToken")));f.Pc=5831;continue;}
case 5831:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5834);}
case 5834:{f.Pc=f.Pop().Int==0?5867:5837;continue;}
case 5837:{f.Push(f.Locals[5]);f.Pc=5839;continue;}
case 5839:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=5842;continue;}
case 5842:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",5845);}
case 5845:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","NON_TOKEN","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","NON_TOKEN","Ljava/util/function/Predicate;"));f.Pc=5848;continue;}
case 5848:{f.Push(f.Locals[0]);f.Pc=5849;continue;}
case 5849:{return rt.Call(f,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",5852);}
case 5852:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",5855);}
case 5855:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",5858);}
case 5858:{f.Pc=f.Pop().Int!=0?5865:5861;continue;}
case 5861:{f.Push(JValue.I(1));f.Pc=5862;continue;}
case 5862:{f.Pc=5866;continue;}
case 5865:{f.Push(JValue.I(0));f.Pc=5866;continue;}
case 5866:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5867:{f.Push(f.Locals[9]);f.Pc=5869;continue;}
case 5869:{f.Push(JValue.R(rt.String("TriggeredCard")));f.Pc=5872;continue;}
case 5872:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5875);}
case 5875:{f.Pc=f.Pop().Int==0?5935:5878;continue;}
case 5878:{f.Push(f.Locals[4]);f.Pc=5880;continue;}
case 5880:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=5883;continue;}
case 5883:{f.Pc=f.Pop().Int!=0?5898:5886;continue;}
case 5886:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=5889;continue;}
case 5889:{f.Push(JValue.R(rt.String("Looking at TriggeredCard but no SA?")));f.Pc=5892;continue;}
case 5892:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",5895);}
case 5895:{f.Pc=5933;continue;}
case 5898:{f.Push(f.Locals[4]);f.Pc=5900;continue;}
case 5900:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5903;continue;}
case 5903:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",5906);}
case 5906:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=5909;continue;}
case 5909:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",5912);}
case 5912:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5915;continue;}
case 5915:{f.Locals[10]=f.Pop();f.Pc=5917;continue;}
case 5917:{f.Push(f.Locals[10]);f.Pc=5919;continue;}
case 5919:{f.Pc=f.Pop().Reference==null?5933:5922;continue;}
case 5922:{f.Push(f.Locals[0]);f.Pc=5923;continue;}
case 5923:{f.Push(f.Locals[10]);f.Pc=5925;continue;}
case 5925:{return rt.Call(f,"forge/game/card/Card","sharesNameWith","(Lforge/game/card/Card;)Z","invokevirtual",5928);}
case 5928:{f.Pc=f.Pop().Int==0?5933:5931;continue;}
case 5931:{f.Push(JValue.I(1));f.Pc=5932;continue;}
case 5932:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5933:{f.Push(JValue.I(0));f.Pc=5934;continue;}
case 5934:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5935:{f.Push(f.Locals[3]);f.Pc=5936;continue;}
case 5936:{f.Push(f.Locals[9]);f.Pc=5938;continue;}
case 5938:{f.Push(f.Locals[4]);f.Pc=5940;continue;}
case 5940:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",5943);}
case 5943:{f.Locals[10]=f.Pop();f.Pc=5945;continue;}
case 5945:{f.Push(f.Locals[10]);f.Pc=5947;continue;}
case 5947:{f.Push(f.Locals[0]);f.Pc=5948;continue;}
case 5948:{return rt.Call(f,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",5951);}
case 5951:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",5954);}
case 5954:{f.Pc=f.Pop().Int!=0?5959:5957;continue;}
case 5957:{f.Push(JValue.I(0));f.Pc=5958;continue;}
case 5958:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5959:{f.Pc=14247;continue;}
case 5962:{f.Push(f.Locals[1]);f.Pc=5963;continue;}
case 5963:{f.Push(JValue.R(rt.String("doesNotShareNameWith")));f.Pc=5966;continue;}
case 5966:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",5969);}
case 5969:{f.Pc=f.Pop().Int==0?6194:5972;continue;}
case 5972:{f.Push(f.Locals[1]);f.Pc=5973;continue;}
case 5973:{f.Push(JValue.R(rt.String("doesNotShareNameWith")));f.Pc=5976;continue;}
case 5976:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",5979);}
case 5979:{f.Pc=f.Pop().Int==0?5992:5982;continue;}
case 5982:{f.Push(f.Locals[0]);f.Pc=5983;continue;}
case 5983:{f.Push(f.Locals[3]);f.Pc=5984;continue;}
case 5984:{return rt.Call(f,"forge/game/card/Card","sharesNameWith","(Lforge/game/card/Card;)Z","invokevirtual",5987);}
case 5987:{f.Pc=f.Pop().Int==0?14247:5990;continue;}
case 5990:{f.Push(JValue.I(0));f.Pc=5991;continue;}
case 5991:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 5992:{f.Push(f.Locals[1]);f.Pc=5993;continue;}
case 5993:{f.Push(JValue.R(rt.String("doesNotShareNameWith ")));f.Pc=5996;continue;}
case 5996:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",5999);}
case 5999:{f.Push(JValue.I(1));f.Pc=6000;continue;}
case 6000:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6001;continue;}
case 6001:{f.Locals[9]=f.Pop();f.Pc=6003;continue;}
case 6003:{f.Push(f.Locals[9]);f.Pc=6005;continue;}
case 6005:{f.Push(JValue.R(rt.String("Remembered")));f.Pc=6008;continue;}
case 6008:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6011);}
case 6011:{f.Pc=f.Pop().Int!=0?6025:6014;continue;}
case 6014:{f.Push(f.Locals[9]);f.Pc=6016;continue;}
case 6016:{f.Push(JValue.R(rt.String("Imprinted")));f.Pc=6019;continue;}
case 6019:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6022);}
case 6022:{f.Pc=f.Pop().Int==0?6053:6025;continue;}
case 6025:{f.Push(f.Locals[3]);f.Pc=6026;continue;}
case 6026:{f.Push(f.Locals[9]);f.Pc=6028;continue;}
case 6028:{f.Push(f.Locals[4]);f.Pc=6030;continue;}
case 6030:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",6033);}
case 6033:{f.Locals[10]=f.Pop();f.Pc=6035;continue;}
case 6035:{f.Push(f.Locals[10]);f.Pc=6037;continue;}
case 6037:{f.Push(f.Locals[0]);f.Pc=6038;continue;}
case 6038:{return rt.Call(f,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",6041);}
case 6041:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",6044);}
case 6044:{f.Pc=f.Pop().Int!=0?6051:6047;continue;}
case 6047:{f.Push(JValue.I(1));f.Pc=6048;continue;}
case 6048:{f.Pc=6052;continue;}
case 6051:{f.Push(JValue.I(0));f.Pc=6052;continue;}
case 6052:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6053:{f.Push(f.Locals[9]);f.Pc=6055;continue;}
case 6055:{f.Push(JValue.R(rt.String("YourGraveyard")));f.Pc=6058;continue;}
case 6058:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6061);}
case 6061:{f.Pc=f.Pop().Int==0?6089:6064;continue;}
case 6064:{f.Push(f.Locals[2]);f.Pc=6065;continue;}
case 6065:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=6068;continue;}
case 6068:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",6071);}
case 6071:{f.Push(f.Locals[0]);f.Pc=6072;continue;}
case 6072:{return rt.Call(f,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",6075);}
case 6075:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",6080);}
case 6080:{f.Pc=f.Pop().Int!=0?6087:6083;continue;}
case 6083:{f.Push(JValue.I(1));f.Pc=6084;continue;}
case 6084:{f.Pc=6088;continue;}
case 6087:{f.Push(JValue.I(0));f.Pc=6088;continue;}
case 6088:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6089:{f.Push(f.Locals[9]);f.Pc=6091;continue;}
case 6091:{f.Push(JValue.R(rt.String("OtherYourBattlefield")));f.Pc=6094;continue;}
case 6094:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6097);}
case 6097:{f.Pc=f.Pop().Int==0?6157:6100;continue;}
case 6100:{f.Push(f.Locals[2]);f.Pc=6101;continue;}
case 6101:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=6104;continue;}
case 6104:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",6107);}
case 6107:{f.Push(f.Locals[0]);f.Pc=6108;continue;}
case 6108:{return rt.Call(f,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",6111);}
case 6111:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",6114);}
case 6114:{f.Locals[10]=f.Pop();f.Pc=6116;continue;}
case 6116:{f.Push(f.Locals[10]);f.Pc=6118;continue;}
case 6118:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",6121);}
case 6121:{f.Push(JValue.I(1));f.Pc=6122;continue;}
case 6122:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?6151:6125;continue;}
case 6125:{f.Push(f.Locals[10]);f.Pc=6127;continue;}
case 6127:{return rt.Call(f,"forge/game/card/CardCollection","getFirst","()Ljava/lang/Object;","invokevirtual",6130);}
case 6130:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=6133;continue;}
case 6133:{f.Locals[11]=f.Pop();f.Pc=6135;continue;}
case 6135:{f.Push(f.Locals[11]);f.Pc=6137;continue;}
case 6137:{f.Push(f.Locals[0]);f.Pc=6138;continue;}
case 6138:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",6141);}
case 6141:{f.Pc=f.Pop().Int==0?6151:6144;continue;}
case 6144:{f.Push(f.Locals[10]);f.Pc=6146;continue;}
case 6146:{f.Push(f.Locals[0]);f.Pc=6147;continue;}
case 6147:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",6150);}
case 6150:{f.StackOp("pop");f.Pc=6151;continue;}
case 6151:{f.Push(f.Locals[10]);f.Pc=6153;continue;}
case 6153:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",6156);}
case 6156:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6157:{f.Push(f.Locals[5]);f.Pc=6159;continue;}
case 6159:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=6162;continue;}
case 6162:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",6165);}
case 6165:{f.Push(f.Locals[9]);f.Pc=6167;continue;}
case 6167:{f.Push(f.Locals[2]);f.Pc=6168;continue;}
case 6168:{f.Push(f.Locals[3]);f.Pc=6169;continue;}
case 6169:{f.Push(f.Locals[4]);f.Pc=6171;continue;}
case 6171:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",6174);}
case 6174:{f.Locals[10]=f.Pop();f.Pc=6176;continue;}
case 6176:{f.Push(f.Locals[10]);f.Pc=6178;continue;}
case 6178:{f.Push(f.Locals[0]);f.Pc=6179;continue;}
case 6179:{return rt.Call(f,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",6182);}
case 6182:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",6185);}
case 6185:{f.Pc=f.Pop().Int!=0?6192:6188;continue;}
case 6188:{f.Push(JValue.I(1));f.Pc=6189;continue;}
case 6189:{f.Pc=6193;continue;}
case 6192:{f.Push(JValue.I(0));f.Pc=6193;continue;}
case 6193:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6194:{f.Push(f.Locals[1]);f.Pc=6195;continue;}
case 6195:{f.Push(JValue.R(rt.String("sharesControllerWith")));f.Pc=6198;continue;}
case 6198:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6201);}
case 6201:{f.Pc=f.Pop().Int==0?6262:6204;continue;}
case 6204:{f.Push(f.Locals[1]);f.Pc=6205;continue;}
case 6205:{f.Push(JValue.R(rt.String("sharesControllerWith")));f.Pc=6208;continue;}
case 6208:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6211);}
case 6211:{f.Pc=f.Pop().Int==0?6224:6214;continue;}
case 6214:{f.Push(f.Locals[0]);f.Pc=6215;continue;}
case 6215:{f.Push(f.Locals[3]);f.Pc=6216;continue;}
case 6216:{return rt.Call(f,"forge/game/card/Card","sharesControllerWith","(Lforge/game/card/Card;)Z","invokevirtual",6219);}
case 6219:{f.Pc=f.Pop().Int!=0?14247:6222;continue;}
case 6222:{f.Push(JValue.I(0));f.Pc=6223;continue;}
case 6223:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6224:{f.Push(f.Locals[1]);f.Pc=6225;continue;}
case 6225:{f.Push(JValue.R(rt.String("sharesControllerWith ")));f.Pc=6228;continue;}
case 6228:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6231);}
case 6231:{f.Push(JValue.I(1));f.Pc=6232;continue;}
case 6232:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6233;continue;}
case 6233:{f.Locals[9]=f.Pop();f.Pc=6235;continue;}
case 6235:{f.Push(f.Locals[3]);f.Pc=6236;continue;}
case 6236:{f.Push(f.Locals[9]);f.Pc=6238;continue;}
case 6238:{f.Push(f.Locals[4]);f.Pc=6240;continue;}
case 6240:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",6243);}
case 6243:{f.Locals[10]=f.Pop();f.Pc=6245;continue;}
case 6245:{f.Push(f.Locals[10]);f.Pc=6247;continue;}
case 6247:{f.Push(f.Locals[0]);f.Pc=6248;continue;}
case 6248:{return rt.Call(f,"forge/game/card/CardPredicates","sharesControllerWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",6251);}
case 6251:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",6254);}
case 6254:{f.Pc=f.Pop().Int!=0?6259:6257;continue;}
case 6257:{f.Push(JValue.I(0));f.Pc=6258;continue;}
case 6258:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6259:{f.Pc=14247;continue;}
case 6262:{f.Push(f.Locals[1]);f.Pc=6263;continue;}
case 6263:{f.Push(JValue.R(rt.String("sharesOwnerWith")));f.Pc=6266;continue;}
case 6266:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6269);}
case 6269:{f.Pc=f.Pop().Int==0?6339:6272;continue;}
case 6272:{f.Push(f.Locals[1]);f.Pc=6273;continue;}
case 6273:{f.Push(JValue.R(rt.String("sharesOwnerWith")));f.Pc=6276;continue;}
case 6276:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6279);}
case 6279:{f.Pc=f.Pop().Int==0?6298:6282;continue;}
case 6282:{f.Push(f.Locals[0]);f.Pc=6283;continue;}
case 6283:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",6286);}
case 6286:{f.Push(f.Locals[3]);f.Pc=6287;continue;}
case 6287:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",6290);}
case 6290:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",6293);}
case 6293:{f.Pc=f.Pop().Int!=0?14247:6296;continue;}
case 6296:{f.Push(JValue.I(0));f.Pc=6297;continue;}
case 6297:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6298:{f.Push(f.Locals[1]);f.Pc=6299;continue;}
case 6299:{f.Push(JValue.R(rt.String("sharesOwnerWith ")));f.Pc=6302;continue;}
case 6302:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6305);}
case 6305:{f.Push(JValue.I(1));f.Pc=6306;continue;}
case 6306:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6307;continue;}
case 6307:{f.Locals[9]=f.Pop();f.Pc=6309;continue;}
case 6309:{f.Push(f.Locals[3]);f.Pc=6310;continue;}
case 6310:{f.Push(f.Locals[9]);f.Pc=6312;continue;}
case 6312:{f.Push(f.Locals[4]);f.Pc=6314;continue;}
case 6314:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",6317);}
case 6317:{f.Locals[10]=f.Pop();f.Pc=6319;continue;}
case 6319:{f.Push(f.Locals[10]);f.Pc=6321;continue;}
case 6321:{f.Push(f.Locals[0]);f.Pc=6322;continue;}
case 6322:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",6325);}
case 6325:{return rt.Call(f,"forge/game/card/CardPredicates","isOwner","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",6328);}
case 6328:{return rt.Call(f,"forge/game/card/CardCollection","allMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",6331);}
case 6331:{f.Pc=f.Pop().Int!=0?6336:6334;continue;}
case 6334:{f.Push(JValue.I(0));f.Pc=6335;continue;}
case 6335:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6336:{f.Pc=14247;continue;}
case 6339:{f.Push(f.Locals[1]);f.Pc=6340;continue;}
case 6340:{f.Push(JValue.R(rt.String("SecondSpellCastThisTurn")));f.Pc=6343;continue;}
case 6343:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6346);}
case 6346:{f.Pc=f.Pop().Int==0?6397:6349;continue;}
case 6349:{f.Push(JValue.R(rt.String("Card")));f.Pc=6352;continue;}
case 6352:{f.Push(f.Locals[3]);f.Pc=6353;continue;}
case 6353:{f.Push(f.Locals[4]);f.Pc=6355;continue;}
case 6355:{f.Push(f.Locals[2]);f.Pc=6356;continue;}
case 6356:{return rt.Call(f,"forge/game/card/CardUtil","getThisTurnCast","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",6359);}
case 6359:{f.Locals[9]=f.Pop();f.Pc=6361;continue;}
case 6361:{f.Push(f.Locals[9]);f.Pc=6363;continue;}
case 6363:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",6368);}
case 6368:{f.Push(JValue.I(2));f.Pc=6369;continue;}
case 6369:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?6374:6372;continue;}
case 6372:{f.Push(JValue.I(0));f.Pc=6373;continue;}
case 6373:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6374:{f.Push(f.Locals[9]);f.Pc=6376;continue;}
case 6376:{f.Push(JValue.I(1));f.Pc=6377;continue;}
case 6377:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",6382);}
case 6382:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=6385;continue;}
case 6385:{f.Push(f.Locals[0]);f.Pc=6386;continue;}
case 6386:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",6389);}
case 6389:{f.Pc=f.Pop().Int!=0?6394:6392;continue;}
case 6392:{f.Push(JValue.I(0));f.Pc=6393;continue;}
case 6393:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6394:{f.Pc=14247;continue;}
case 6397:{f.Push(f.Locals[1]);f.Pc=6398;continue;}
case 6398:{f.Push(JValue.R(rt.String("ThisTurnCast")));f.Pc=6401;continue;}
case 6401:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6404);}
case 6404:{f.Pc=f.Pop().Int==0?6462:6407;continue;}
case 6407:{f.Push(JValue.R(rt.String("Card")));f.Pc=6410;continue;}
case 6410:{f.Push(f.Locals[3]);f.Pc=6411;continue;}
case 6411:{f.Push(f.Locals[4]);f.Pc=6413;continue;}
case 6413:{f.Push(f.Locals[2]);f.Pc=6414;continue;}
case 6414:{return rt.Call(f,"forge/game/card/CardUtil","getThisTurnCast","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",6417);}
case 6417:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",6422);}
case 6422:{f.Locals[9]=f.Pop();f.Pc=6424;continue;}
case 6424:{f.Push(f.Locals[9]);f.Pc=6426;continue;}
case 6426:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",6431);}
case 6431:{f.Pc=f.Pop().Int==0?6460:6434;continue;}
case 6434:{f.Push(f.Locals[9]);f.Pc=6436;continue;}
case 6436:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",6441);}
case 6441:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=6444;continue;}
case 6444:{f.Locals[10]=f.Pop();f.Pc=6446;continue;}
case 6446:{f.Push(f.Locals[0]);f.Pc=6447;continue;}
case 6447:{f.Push(f.Locals[10]);f.Pc=6449;continue;}
case 6449:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",6452);}
case 6452:{f.Pc=f.Pop().Int==0?6457:6455;continue;}
case 6455:{f.Push(JValue.I(1));f.Pc=6456;continue;}
case 6456:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6457:{f.Pc=6424;continue;}
case 6460:{f.Push(JValue.I(0));f.Pc=6461;continue;}
case 6461:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6462:{f.Push(f.Locals[1]);f.Pc=6463;continue;}
case 6463:{f.Push(JValue.R(rt.String("EnteredUnder")));f.Pc=6466;continue;}
case 6466:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6469);}
case 6469:{f.Pc=f.Pop().Int==0?6534:6472;continue;}
case 6472:{f.Push(f.Locals[0]);f.Pc=6473;continue;}
case 6473:{return rt.Call(f,"forge/game/card/Card","getTurnInController","()Lforge/game/player/Player;","invokevirtual",6476);}
case 6476:{f.Locals[9]=f.Pop();f.Pc=6478;continue;}
case 6478:{f.Push(f.Locals[9]);f.Pc=6480;continue;}
case 6480:{f.Pc=f.Pop().Reference!=null?6485:6483;continue;}
case 6483:{f.Push(JValue.I(0));f.Pc=6484;continue;}
case 6484:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6485:{f.Push(f.Locals[1]);f.Pc=6486;continue;}
case 6486:{f.Push(JValue.I(13));f.Pc=6488;continue;}
case 6488:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",6491);}
case 6491:{f.Locals[10]=f.Pop();f.Pc=6493;continue;}
case 6493:{f.Push(f.Locals[9]);f.Pc=6495;continue;}
case 6495:{f.Push(f.Locals[10]);f.Pc=6497;continue;}
case 6497:{f.Push(f.Locals[2]);f.Pc=6498;continue;}
case 6498:{f.Push(f.Locals[3]);f.Pc=6499;continue;}
case 6499:{f.Push(f.Locals[4]);f.Pc=6501;continue;}
case 6501:{return rt.Call(f,"forge/game/player/Player","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",6504);}
case 6504:{f.Pc=f.Pop().Int!=0?6531:6507;continue;}
case 6507:{f.Push(f.Locals[3]);f.Pc=6508;continue;}
case 6508:{f.Push(f.Locals[10]);f.Pc=6510;continue;}
case 6510:{f.Push(f.Locals[4]);f.Pc=6512;continue;}
case 6512:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",6515);}
case 6515:{f.Locals[11]=f.Pop();f.Pc=6517;continue;}
case 6517:{f.Push(f.Locals[11]);f.Pc=6519;continue;}
case 6519:{f.Push(f.Locals[9]);f.Pc=6521;continue;}
case 6521:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",6526);}
case 6526:{f.Pc=f.Pop().Int!=0?6531:6529;continue;}
case 6529:{f.Push(JValue.I(0));f.Pc=6530;continue;}
case 6530:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6531:{f.Pc=14247;continue;}
case 6534:{f.Push(f.Locals[1]);f.Pc=6535;continue;}
case 6535:{f.Push(JValue.R(rt.String("EnteredSinceYourLastTurn")));f.Pc=6538;continue;}
case 6538:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6541);}
case 6541:{f.Pc=f.Pop().Int==0?6557:6544;continue;}
case 6544:{f.Push(f.Locals[0]);f.Pc=6545;continue;}
case 6545:{return rt.Call(f,"forge/game/card/Card","getTurnInZone","()I","invokevirtual",6548);}
case 6548:{f.Push(f.Locals[2]);f.Pc=6549;continue;}
case 6549:{return rt.Call(f,"forge/game/player/Player","getLastTurnNr","()I","invokevirtual",6552);}
case 6552:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?14247:6555;continue;}
case 6555:{f.Push(JValue.I(0));f.Pc=6556;continue;}
case 6556:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6557:{f.Push(f.Locals[1]);f.Pc=6558;continue;}
case 6558:{f.Push(JValue.R(rt.String("ThisTurnEnteredFrom")));f.Pc=6561;continue;}
case 6561:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6564);}
case 6564:{f.Pc=f.Pop().Int==0?6632:6567;continue;}
case 6567:{f.Push(f.Locals[1]);f.Pc=6568;continue;}
case 6568:{f.Push(JValue.R(rt.String("ThisTurnEnteredFrom_")));f.Pc=6571;continue;}
case 6571:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6574);}
case 6574:{f.Push(JValue.I(1));f.Pc=6575;continue;}
case 6575:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6576;continue;}
case 6576:{f.Locals[9]=f.Pop();f.Pc=6578;continue;}
case 6578:{f.Push(f.Locals[9]);f.Pc=6580;continue;}
case 6580:{f.Push(JValue.R(rt.String("_")));f.Pc=6582;continue;}
case 6582:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6585);}
case 6585:{f.Locals[10]=f.Pop();f.Pc=6587;continue;}
case 6587:{f.Push(f.Locals[10]);f.Pc=6589;continue;}
case 6589:{f.Push(JValue.I(0));f.Pc=6590;continue;}
case 6590:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=6591;continue;}
case 6591:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",6594);}
case 6594:{f.Locals[11]=f.Pop();f.Pc=6596;continue;}
case 6596:{f.Push(f.Locals[0]);f.Pc=6597;continue;}
case 6597:{return rt.Call(f,"forge/game/card/Card","enteredThisTurn","()Z","invokevirtual",6600);}
case 6600:{f.Pc=f.Pop().Int!=0?6605:6603;continue;}
case 6603:{f.Push(JValue.I(0));f.Pc=6604;continue;}
case 6604:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6605:{f.Push(f.Locals[0]);f.Pc=6606;continue;}
case 6606:{return rt.Call(f,"forge/game/card/Card","getLastKnownZone","()Lforge/game/zone/Zone;","invokevirtual",6609);}
case 6609:{f.Locals[12]=f.Pop();f.Pc=6611;continue;}
case 6611:{f.Push(f.Locals[12]);f.Pc=6613;continue;}
case 6613:{f.Pc=f.Pop().Reference==null?6627:6616;continue;}
case 6616:{f.Push(f.Locals[12]);f.Pc=6618;continue;}
case 6618:{f.Push(f.Locals[0]);f.Pc=6619;continue;}
case 6619:{f.Push(f.Locals[11]);f.Pc=6621;continue;}
case 6621:{return rt.Call(f,"forge/game/zone/Zone","isCardAddedThisTurn","(Lforge/game/card/Card;Lforge/game/zone/ZoneType;)Z","invokevirtual",6624);}
case 6624:{f.Pc=f.Pop().Int!=0?6629:6627;continue;}
case 6627:{f.Push(JValue.I(0));f.Pc=6628;continue;}
case 6628:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6629:{f.Pc=14247;continue;}
case 6632:{f.Push(f.Locals[1]);f.Pc=6633;continue;}
case 6633:{f.Push(JValue.R(rt.String("ThisTurnEntered")));f.Pc=6636;continue;}
case 6636:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6639);}
case 6639:{f.Pc=f.Pop().Int==0?6737:6642;continue;}
case 6642:{f.Push(f.Locals[0]);f.Pc=6643;continue;}
case 6643:{return rt.Call(f,"forge/game/card/Card","enteredThisTurn","()Z","invokevirtual",6646);}
case 6646:{f.Pc=f.Pop().Int!=0?6651:6649;continue;}
case 6649:{f.Push(JValue.I(0));f.Pc=6650;continue;}
case 6650:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6651:{f.Push(f.Locals[1]);f.Pc=6652;continue;}
case 6652:{f.Push(JValue.R(rt.String("ThisTurnEntered")));f.Pc=6655;continue;}
case 6655:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6658);}
case 6658:{f.Pc=f.Pop().Int!=0?14247:6661;continue;}
case 6661:{f.Push(f.Locals[1]);f.Pc=6662;continue;}
case 6662:{f.Push(JValue.R(rt.String("Your")));f.Pc=6665;continue;}
case 6665:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",6668);}
case 6668:{f.Locals[9]=f.Pop();f.Pc=6670;continue;}
case 6670:{f.Push(f.Locals[1]);f.Pc=6671;continue;}
case 6671:{f.Push(f.Locals[9]);f.Pc=6673;continue;}
case 6673:{f.Pc=f.Pop().Int==0?6681:6676;continue;}
case 6676:{f.Push(JValue.I(19));f.Pc=6678;continue;}
case 6678:{f.Pc=6683;continue;}
case 6681:{f.Push(JValue.I(15));f.Pc=6683;continue;}
case 6683:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",6686);}
case 6686:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",6689);}
case 6689:{f.Locals[10]=f.Pop();f.Pc=6691;continue;}
case 6691:{f.Push(f.Locals[2]);f.Pc=6692;continue;}
case 6692:{f.Push(f.Locals[10]);f.Pc=6694;continue;}
case 6694:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",6697);}
case 6697:{f.Locals[11]=f.Pop();f.Pc=6699;continue;}
case 6699:{f.Push(f.Locals[11]);f.Pc=6701;continue;}
case 6701:{f.Push(JValue.R(null));f.Pc=6702;continue;}
case 6702:{return rt.Call(f,"forge/game/zone/Zone","getCardsAddedThisTurn","(Lforge/game/zone/ZoneType;)Ljava/util/List;","invokevirtual",6705);}
case 6705:{f.Push(f.Locals[0]);f.Pc=6706;continue;}
case 6706:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",6711);}
case 6711:{f.Pc=f.Pop().Int!=0?6716:6714;continue;}
case 6714:{f.Push(JValue.I(0));f.Pc=6715;continue;}
case 6715:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6716:{f.Push(f.Locals[9]);f.Pc=6718;continue;}
case 6718:{f.Pc=f.Pop().Int==0?6734:6721;continue;}
case 6721:{f.Push(f.Locals[0]);f.Pc=6722;continue;}
case 6722:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",6725);}
case 6725:{f.Push(f.Locals[2]);f.Pc=6726;continue;}
case 6726:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",6729);}
case 6729:{f.Pc=f.Pop().Int!=0?6734:6732;continue;}
case 6732:{f.Push(JValue.I(0));f.Pc=6733;continue;}
case 6733:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6734:{f.Pc=14247;continue;}
case 6737:{f.Push(f.Locals[1]);f.Pc=6738;continue;}
case 6738:{f.Push(JValue.R(rt.String("DiscardedThisTurn")));f.Pc=6741;continue;}
case 6741:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6744);}
case 6744:{f.Pc=f.Pop().Int==0?6765:6747;continue;}
case 6747:{f.Push(f.Locals[0]);f.Pc=6748;continue;}
case 6748:{return rt.Call(f,"forge/game/card/Card","enteredThisTurn","()Z","invokevirtual",6751);}
case 6751:{f.Pc=f.Pop().Int!=0?6756:6754;continue;}
case 6754:{f.Push(JValue.I(0));f.Pc=6755;continue;}
case 6755:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6756:{f.Push(f.Locals[0]);f.Pc=6757;continue;}
case 6757:{return rt.Call(f,"forge/game/card/Card","wasDiscarded","()Z","invokevirtual",6760);}
case 6760:{f.Pc=f.Pop().Int!=0?14247:6763;continue;}
case 6763:{f.Push(JValue.I(0));f.Pc=6764;continue;}
case 6764:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6765:{f.Push(f.Locals[1]);f.Pc=6766;continue;}
case 6766:{f.Push(JValue.R(rt.String("surveilledThisTurn")));f.Pc=6769;continue;}
case 6769:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6772);}
case 6772:{f.Pc=f.Pop().Int==0?6793:6775;continue;}
case 6775:{f.Push(f.Locals[0]);f.Pc=6776;continue;}
case 6776:{return rt.Call(f,"forge/game/card/Card","enteredThisTurn","()Z","invokevirtual",6779);}
case 6779:{f.Pc=f.Pop().Int!=0?6784:6782;continue;}
case 6782:{f.Push(JValue.I(0));f.Pc=6783;continue;}
case 6783:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6784:{f.Push(f.Locals[0]);f.Pc=6785;continue;}
case 6785:{return rt.Call(f,"forge/game/card/Card","wasSurveilled","()Z","invokevirtual",6788);}
case 6788:{f.Pc=f.Pop().Int!=0?14247:6791;continue;}
case 6791:{f.Push(JValue.I(0));f.Pc=6792;continue;}
case 6792:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6793:{f.Push(f.Locals[1]);f.Pc=6794;continue;}
case 6794:{f.Push(JValue.R(rt.String("milledThisTurn")));f.Pc=6797;continue;}
case 6797:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6800);}
case 6800:{f.Pc=f.Pop().Int==0?6821:6803;continue;}
case 6803:{f.Push(f.Locals[0]);f.Pc=6804;continue;}
case 6804:{return rt.Call(f,"forge/game/card/Card","enteredThisTurn","()Z","invokevirtual",6807);}
case 6807:{f.Pc=f.Pop().Int!=0?6812:6810;continue;}
case 6810:{f.Push(JValue.I(0));f.Pc=6811;continue;}
case 6811:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6812:{f.Push(f.Locals[0]);f.Pc=6813;continue;}
case 6813:{return rt.Call(f,"forge/game/card/Card","wasMilled","()Z","invokevirtual",6816);}
case 6816:{f.Pc=f.Pop().Int!=0?14247:6819;continue;}
case 6819:{f.Push(JValue.I(0));f.Pc=6820;continue;}
case 6820:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6821:{f.Push(f.Locals[1]);f.Pc=6822;continue;}
case 6822:{f.Push(JValue.R(rt.String("hasABasicLandType")));f.Pc=6825;continue;}
case 6825:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6828);}
case 6828:{f.Pc=f.Pop().Int==0?6840:6831;continue;}
case 6831:{f.Push(f.Locals[0]);f.Pc=6832;continue;}
case 6832:{return rt.Call(f,"forge/game/card/Card","hasABasicLandType","()Z","invokevirtual",6835);}
case 6835:{f.Pc=f.Pop().Int!=0?14247:6838;continue;}
case 6838:{f.Push(JValue.I(0));f.Pc=6839;continue;}
case 6839:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6840:{f.Push(f.Locals[1]);f.Pc=6841;continue;}
case 6841:{f.Push(JValue.R(rt.String("hasANonBasicLandType")));f.Pc=6844;continue;}
case 6844:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6847);}
case 6847:{f.Pc=f.Pop().Int==0?6859:6850;continue;}
case 6850:{f.Push(f.Locals[0]);f.Pc=6851;continue;}
case 6851:{return rt.Call(f,"forge/game/card/Card","hasANonBasicLandType","()Z","invokevirtual",6854);}
case 6854:{f.Pc=f.Pop().Int!=0?14247:6857;continue;}
case 6857:{f.Push(JValue.I(0));f.Pc=6858;continue;}
case 6858:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6859:{f.Push(f.Locals[1]);f.Pc=6860;continue;}
case 6860:{f.Push(JValue.R(rt.String("hasKeyword")));f.Pc=6863;continue;}
case 6863:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6866);}
case 6866:{f.Pc=f.Pop().Int==0?6884:6869;continue;}
case 6869:{f.Push(f.Locals[0]);f.Pc=6870;continue;}
case 6870:{f.Push(f.Locals[1]);f.Pc=6871;continue;}
case 6871:{f.Push(JValue.I(10));f.Pc=6873;continue;}
case 6873:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",6876);}
case 6876:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",6879);}
case 6879:{f.Pc=f.Pop().Int!=0?14247:6882;continue;}
case 6882:{f.Push(JValue.I(0));f.Pc=6883;continue;}
case 6883:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6884:{f.Push(f.Locals[1]);f.Pc=6885;continue;}
case 6885:{f.Push(JValue.R(rt.String("with")));f.Pc=6888;continue;}
case 6888:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6891);}
case 6891:{f.Pc=f.Pop().Int==0?6943:6894;continue;}
case 6894:{f.Push(f.Locals[1]);f.Pc=6895;continue;}
case 6895:{f.Push(JValue.R(rt.String("without")));f.Pc=6898;continue;}
case 6898:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6901);}
case 6901:{f.Pc=f.Pop().Int==0?6919:6904;continue;}
case 6904:{f.Push(f.Locals[0]);f.Pc=6905;continue;}
case 6905:{f.Push(f.Locals[1]);f.Pc=6906;continue;}
case 6906:{f.Push(JValue.I(7));f.Pc=6908;continue;}
case 6908:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",6911);}
case 6911:{return rt.Call(f,"forge/game/card/Card","hasStartOfUnHiddenKeyword","(Ljava/lang/String;)Z","invokevirtual",6914);}
case 6914:{f.Pc=f.Pop().Int==0?6919:6917;continue;}
case 6917:{f.Push(JValue.I(0));f.Pc=6918;continue;}
case 6918:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6919:{f.Push(f.Locals[1]);f.Pc=6920;continue;}
case 6920:{f.Push(JValue.R(rt.String("without")));f.Pc=6923;continue;}
case 6923:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6926);}
case 6926:{f.Pc=f.Pop().Int!=0?14247:6929;continue;}
case 6929:{f.Push(f.Locals[0]);f.Pc=6930;continue;}
case 6930:{f.Push(f.Locals[1]);f.Pc=6931;continue;}
case 6931:{f.Push(JValue.I(4));f.Pc=6932;continue;}
case 6932:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",6935);}
case 6935:{return rt.Call(f,"forge/game/card/Card","hasStartOfUnHiddenKeyword","(Ljava/lang/String;)Z","invokevirtual",6938);}
case 6938:{f.Pc=f.Pop().Int!=0?14247:6941;continue;}
case 6941:{f.Push(JValue.I(0));f.Pc=6942;continue;}
case 6942:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6943:{f.Push(f.Locals[1]);f.Pc=6944;continue;}
case 6944:{f.Push(JValue.R(rt.String("activated")));f.Pc=6947;continue;}
case 6947:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6950);}
case 6950:{f.Pc=f.Pop().Int==0?6962:6953;continue;}
case 6953:{f.Push(f.Locals[0]);f.Pc=6954;continue;}
case 6954:{return rt.Call(f,"forge/game/card/Card","activatedThisTurn","()Z","invokevirtual",6957);}
case 6957:{f.Pc=f.Pop().Int!=0?14247:6960;continue;}
case 6960:{f.Push(JValue.I(0));f.Pc=6961;continue;}
case 6961:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6962:{f.Push(f.Locals[1]);f.Pc=6963;continue;}
case 6963:{f.Push(JValue.R(rt.String("tapped")));f.Pc=6966;continue;}
case 6966:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6969);}
case 6969:{f.Pc=f.Pop().Int==0?6981:6972;continue;}
case 6972:{f.Push(f.Locals[0]);f.Pc=6973;continue;}
case 6973:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",6976);}
case 6976:{f.Pc=f.Pop().Int!=0?14247:6979;continue;}
case 6979:{f.Push(JValue.I(0));f.Pc=6980;continue;}
case 6980:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6981:{f.Push(f.Locals[1]);f.Pc=6982;continue;}
case 6982:{f.Push(JValue.R(rt.String("untapped")));f.Pc=6985;continue;}
case 6985:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6988);}
case 6988:{f.Pc=f.Pop().Int==0?7000:6991;continue;}
case 6991:{f.Push(f.Locals[0]);f.Pc=6992;continue;}
case 6992:{return rt.Call(f,"forge/game/card/Card","isUntapped","()Z","invokevirtual",6995);}
case 6995:{f.Pc=f.Pop().Int!=0?14247:6998;continue;}
case 6998:{f.Push(JValue.I(0));f.Pc=6999;continue;}
case 6999:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7000:{f.Push(f.Locals[1]);f.Pc=7001;continue;}
case 7001:{f.Push(JValue.R(rt.String("faceDown")));f.Pc=7004;continue;}
case 7004:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7007);}
case 7007:{f.Pc=f.Pop().Int==0?7019:7010;continue;}
case 7010:{f.Push(f.Locals[0]);f.Pc=7011;continue;}
case 7011:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",7014);}
case 7014:{f.Pc=f.Pop().Int!=0?14247:7017;continue;}
case 7017:{f.Push(JValue.I(0));f.Pc=7018;continue;}
case 7018:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7019:{f.Push(f.Locals[1]);f.Pc=7020;continue;}
case 7020:{f.Push(JValue.R(rt.String("faceUp")));f.Pc=7023;continue;}
case 7023:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7026);}
case 7026:{f.Pc=f.Pop().Int==0?7038:7029;continue;}
case 7029:{f.Push(f.Locals[0]);f.Pc=7030;continue;}
case 7030:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",7033);}
case 7033:{f.Pc=f.Pop().Int==0?14247:7036;continue;}
case 7036:{f.Push(JValue.I(0));f.Pc=7037;continue;}
case 7037:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7038:{f.Push(f.Locals[1]);f.Pc=7039;continue;}
case 7039:{f.Push(JValue.R(rt.String("turnedFaceUpThisTurn")));f.Pc=7042;continue;}
case 7042:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7045);}
case 7045:{f.Pc=f.Pop().Int==0?7057:7048;continue;}
case 7048:{f.Push(f.Locals[0]);f.Pc=7049;continue;}
case 7049:{return rt.Call(f,"forge/game/card/Card","wasTurnedFaceUpThisTurn","()Z","invokevirtual",7052);}
case 7052:{f.Pc=f.Pop().Int!=0?14247:7055;continue;}
case 7055:{f.Push(JValue.I(0));f.Pc=7056;continue;}
case 7056:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7057:{f.Push(f.Locals[1]);f.Pc=7058;continue;}
case 7058:{f.Push(JValue.R(rt.String("phasedOut")));f.Pc=7060;continue;}
case 7060:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7063);}
case 7063:{f.Pc=f.Pop().Int==0?7075:7066;continue;}
case 7066:{f.Push(f.Locals[0]);f.Pc=7067;continue;}
case 7067:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",7070);}
case 7070:{f.Pc=f.Pop().Int!=0?14247:7073;continue;}
case 7073:{f.Push(JValue.I(0));f.Pc=7074;continue;}
case 7074:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7075:{f.Push(f.Locals[1]);f.Pc=7076;continue;}
case 7076:{f.Push(JValue.R(rt.String("phasedIn")));f.Pc=7079;continue;}
case 7079:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7082);}
case 7082:{f.Pc=f.Pop().Int==0?7094:7085;continue;}
case 7085:{f.Push(f.Locals[0]);f.Pc=7086;continue;}
case 7086:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",7089);}
case 7089:{f.Pc=f.Pop().Int==0?14247:7092;continue;}
case 7092:{f.Push(JValue.I(0));f.Pc=7093;continue;}
case 7093:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7094:{f.Push(f.Locals[1]);f.Pc=7095;continue;}
case 7095:{f.Push(JValue.R(rt.String("manifested")));f.Pc=7098;continue;}
case 7098:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7101);}
case 7101:{f.Pc=f.Pop().Int==0?7113:7104;continue;}
case 7104:{f.Push(f.Locals[0]);f.Pc=7105;continue;}
case 7105:{return rt.Call(f,"forge/game/card/Card","isManifested","()Z","invokevirtual",7108);}
case 7108:{f.Pc=f.Pop().Int!=0?14247:7111;continue;}
case 7111:{f.Push(JValue.I(0));f.Pc=7112;continue;}
case 7112:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7113:{f.Push(f.Locals[1]);f.Pc=7114;continue;}
case 7114:{f.Push(JValue.R(rt.String("cloaked")));f.Pc=7117;continue;}
case 7117:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7120);}
case 7120:{f.Pc=f.Pop().Int==0?7132:7123;continue;}
case 7123:{f.Push(f.Locals[0]);f.Pc=7124;continue;}
case 7124:{return rt.Call(f,"forge/game/card/Card","isCloaked","()Z","invokevirtual",7127);}
case 7127:{f.Pc=f.Pop().Int!=0?14247:7130;continue;}
case 7130:{f.Push(JValue.I(0));f.Pc=7131;continue;}
case 7131:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7132:{f.Push(f.Locals[1]);f.Pc=7133;continue;}
case 7133:{f.Push(JValue.R(rt.String("DrawnThisTurn")));f.Pc=7136;continue;}
case 7136:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7139);}
case 7139:{f.Pc=f.Pop().Int==0?7151:7142;continue;}
case 7142:{f.Push(f.Locals[0]);f.Pc=7143;continue;}
case 7143:{return rt.Call(f,"forge/game/card/Card","getDrawnThisTurn","()Z","invokevirtual",7146);}
case 7146:{f.Pc=f.Pop().Int!=0?14247:7149;continue;}
case 7149:{f.Push(JValue.I(0));f.Pc=7150;continue;}
case 7150:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7151:{f.Push(f.Locals[1]);f.Pc=7152;continue;}
case 7152:{f.Push(JValue.R(rt.String("FoughtThisTurn")));f.Pc=7155;continue;}
case 7155:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7158);}
case 7158:{f.Pc=f.Pop().Int==0?7170:7161;continue;}
case 7161:{f.Push(f.Locals[0]);f.Pc=7162;continue;}
case 7162:{return rt.Call(f,"forge/game/card/Card","getFoughtThisTurn","()Z","invokevirtual",7165);}
case 7165:{f.Pc=f.Pop().Int!=0?14247:7168;continue;}
case 7168:{f.Push(JValue.I(0));f.Pc=7169;continue;}
case 7169:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7170:{f.Push(f.Locals[1]);f.Pc=7171;continue;}
case 7171:{f.Push(JValue.R(rt.String("firstTurnControlled")));f.Pc=7174;continue;}
case 7174:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7177);}
case 7177:{f.Pc=f.Pop().Int==0?7189:7180;continue;}
case 7180:{f.Push(f.Locals[0]);f.Pc=7181;continue;}
case 7181:{return rt.Call(f,"forge/game/card/Card","isFirstTurnControlled","()Z","invokevirtual",7184);}
case 7184:{f.Pc=f.Pop().Int!=0?14247:7187;continue;}
case 7187:{f.Push(JValue.I(0));f.Pc=7188;continue;}
case 7188:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7189:{f.Push(f.Locals[1]);f.Pc=7190;continue;}
case 7190:{f.Push(JValue.R(rt.String("startedTheTurnUntapped")));f.Pc=7193;continue;}
case 7193:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7196);}
case 7196:{f.Pc=f.Pop().Int==0?7208:7199;continue;}
case 7199:{f.Push(f.Locals[0]);f.Pc=7200;continue;}
case 7200:{return rt.Call(f,"forge/game/card/Card","hasStartedTheTurnUntapped","()Z","invokevirtual",7203);}
case 7203:{f.Pc=f.Pop().Int!=0?14247:7206;continue;}
case 7206:{f.Push(JValue.I(0));f.Pc=7207;continue;}
case 7207:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7208:{f.Push(f.Locals[1]);f.Pc=7209;continue;}
case 7209:{f.Push(JValue.R(rt.String("cameUnderControlSinceLastUpkeep")));f.Pc=7212;continue;}
case 7212:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7215);}
case 7215:{f.Pc=f.Pop().Int==0?7227:7218;continue;}
case 7218:{f.Push(f.Locals[0]);f.Pc=7219;continue;}
case 7219:{return rt.Call(f,"forge/game/card/Card","cameUnderControlSinceLastUpkeep","()Z","invokevirtual",7222);}
case 7222:{f.Pc=f.Pop().Int!=0?14247:7225;continue;}
case 7225:{f.Push(JValue.I(0));f.Pc=7226;continue;}
case 7226:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7227:{f.Push(f.Locals[1]);f.Pc=7228;continue;}
case 7228:{f.Push(JValue.R(rt.String("attackedOrBlockedSinceYourLastUpkeep")));f.Pc=7231;continue;}
case 7231:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7234);}
case 7234:{f.Pc=f.Pop().Int==0?7261:7237;continue;}
case 7237:{f.Push(f.Locals[0]);f.Pc=7238;continue;}
case 7238:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7241);}
case 7241:{f.Push(f.Locals[2]);f.Pc=7242;continue;}
case 7242:{return rt.Call(f,"forge/game/card/CardDamageHistory","hasAttackedSinceLastUpkeepOf","(Lforge/game/player/Player;)Z","invokevirtual",7245);}
case 7245:{f.Pc=f.Pop().Int!=0?14247:7248;continue;}
case 7248:{f.Push(f.Locals[0]);f.Pc=7249;continue;}
case 7249:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7252);}
case 7252:{f.Push(f.Locals[2]);f.Pc=7253;continue;}
case 7253:{return rt.Call(f,"forge/game/card/CardDamageHistory","hasBlockedSinceLastUpkeepOf","(Lforge/game/player/Player;)Z","invokevirtual",7256);}
case 7256:{f.Pc=f.Pop().Int!=0?14247:7259;continue;}
case 7259:{f.Push(JValue.I(0));f.Pc=7260;continue;}
case 7260:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7261:{f.Push(f.Locals[1]);f.Pc=7262;continue;}
case 7262:{f.Push(JValue.R(rt.String("blockedOrBeenBlockedSinceYourLastUpkeep")));f.Pc=7265;continue;}
case 7265:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7268);}
case 7268:{f.Pc=f.Pop().Int==0?7295:7271;continue;}
case 7271:{f.Push(f.Locals[0]);f.Pc=7272;continue;}
case 7272:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7275);}
case 7275:{f.Push(f.Locals[2]);f.Pc=7276;continue;}
case 7276:{return rt.Call(f,"forge/game/card/CardDamageHistory","hasBeenBlockedSinceLastUpkeepOf","(Lforge/game/player/Player;)Z","invokevirtual",7279);}
case 7279:{f.Pc=f.Pop().Int!=0?14247:7282;continue;}
case 7282:{f.Push(f.Locals[0]);f.Pc=7283;continue;}
case 7283:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7286);}
case 7286:{f.Push(f.Locals[2]);f.Pc=7287;continue;}
case 7287:{return rt.Call(f,"forge/game/card/CardDamageHistory","hasBlockedSinceLastUpkeepOf","(Lforge/game/player/Player;)Z","invokevirtual",7290);}
case 7290:{f.Pc=f.Pop().Int!=0?14247:7293;continue;}
case 7293:{f.Push(JValue.I(0));f.Pc=7294;continue;}
case 7294:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7295:{f.Push(f.Locals[1]);f.Pc=7296;continue;}
case 7296:{f.Push(JValue.R(rt.String("DamagedBy")));f.Pc=7299;continue;}
case 7299:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7302);}
case 7302:{f.Pc=f.Pop().Int==0?7514:7305;continue;}
case 7305:{f.Push(f.Locals[1]);f.Pc=7306;continue;}
case 7306:{f.Push(JValue.R(rt.String("DamagedBy")));f.Pc=7309;continue;}
case 7309:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",7312);}
case 7312:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",7315);}
case 7315:{f.Locals[9]=f.Pop();f.Pc=7317;continue;}
case 7317:{f.Push(JValue.R(null));f.Pc=7318;continue;}
case 7318:{f.Locals[10]=f.Pop();f.Pc=7320;continue;}
case 7320:{f.Push(f.Locals[9]);f.Pc=7322;continue;}
case 7322:{f.Push(JValue.R(rt.String(" ")));f.Pc=7324;continue;}
case 7324:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7327);}
case 7327:{f.Pc=f.Pop().Int==0?7344:7330;continue;}
case 7330:{f.Push(f.Locals[3]);f.Pc=7331;continue;}
case 7331:{f.Push(f.Locals[9]);f.Pc=7333;continue;}
case 7333:{f.Push(JValue.I(1));f.Pc=7334;continue;}
case 7334:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",7337);}
case 7337:{f.Push(f.Locals[4]);f.Pc=7339;continue;}
case 7339:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",7342);}
case 7342:{f.Locals[10]=f.Pop();f.Pc=7344;continue;}
case 7344:{f.Push(JValue.I(0));f.Pc=7345;continue;}
case 7345:{f.Locals[11]=f.Pop();f.Pc=7347;continue;}
case 7347:{f.Push(f.Locals[0]);f.Pc=7348;continue;}
case 7348:{return rt.Call(f,"forge/game/card/Card","getDamageReceivedThisTurn","()Ljava/util/List;","invokevirtual",7351);}
case 7351:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",7356);}
case 7356:{f.Locals[12]=f.Pop();f.Pc=7358;continue;}
case 7358:{f.Push(f.Locals[12]);f.Pc=7360;continue;}
case 7360:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",7365);}
case 7365:{f.Pc=f.Pop().Int==0?7504:7368;continue;}
case 7368:{f.Push(f.Locals[12]);f.Pc=7370;continue;}
case 7370:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",7375);}
case 7375:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7378;continue;}
case 7378:{f.Locals[13]=f.Pop();f.Pc=7380;continue;}
case 7380:{f.Push(f.Locals[5]);f.Pc=7382;continue;}
case 7382:{f.Push(f.Locals[13]);f.Pc=7384;continue;}
case 7384:{return rt.Call(f,"forge/game/Game","getDamageLKI","(Lorg/apache/commons/lang3/tuple/Pair;)Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",7387);}
case 7387:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",7390);}
case 7390:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7393;continue;}
case 7393:{f.Locals[14]=f.Pop();f.Pc=7395;continue;}
case 7395:{f.Push(f.Locals[10]);f.Pc=7397;continue;}
case 7397:{f.Pc=f.Pop().Reference==null?7448:7400;continue;}
case 7400:{f.Push(f.Locals[10]);f.Pc=7402;continue;}
case 7402:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",7405);}
case 7405:{f.Locals[15]=f.Pop();f.Pc=7407;continue;}
case 7407:{f.Push(f.Locals[15]);f.Pc=7409;continue;}
case 7409:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",7414);}
case 7414:{f.Pc=f.Pop().Int==0?7445:7417;continue;}
case 7417:{f.Push(f.Locals[15]);f.Pc=7419;continue;}
case 7419:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",7424);}
case 7424:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7427;continue;}
case 7427:{f.Locals[16]=f.Pop();f.Pc=7429;continue;}
case 7429:{f.Push(f.Locals[14]);f.Pc=7431;continue;}
case 7431:{f.Push(f.Locals[16]);f.Pc=7433;continue;}
case 7433:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",7436);}
case 7436:{f.Pc=f.Pop().Int==0?7442:7439;continue;}
case 7439:{f.Push(JValue.I(1));f.Pc=7440;continue;}
case 7440:{f.Locals[11]=f.Pop();f.Pc=7442;continue;}
case 7442:{f.Pc=7407;continue;}
case 7445:{f.Pc=7493;continue;}
case 7448:{f.Push(f.Locals[9]);f.Pc=7450;continue;}
case 7450:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",7453);}
case 7453:{f.Pc=f.Pop().Int==0?7471:7456;continue;}
case 7456:{f.Push(f.Locals[14]);f.Pc=7458;continue;}
case 7458:{f.Push(f.Locals[3]);f.Pc=7459;continue;}
case 7459:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",7462);}
case 7462:{f.Pc=f.Pop().Int==0?7471:7465;continue;}
case 7465:{f.Push(JValue.I(1));f.Pc=7466;continue;}
case 7466:{f.Locals[11]=f.Pop();f.Pc=7468;continue;}
case 7468:{f.Pc=7493;continue;}
case 7471:{f.Push(f.Locals[14]);f.Pc=7473;continue;}
case 7473:{f.Push(f.Locals[9]);f.Pc=7475;continue;}
case 7475:{f.Push(JValue.R(rt.String(";")));f.Pc=7477;continue;}
case 7477:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7480);}
case 7480:{f.Push(f.Locals[2]);f.Pc=7481;continue;}
case 7481:{f.Push(f.Locals[3]);f.Pc=7482;continue;}
case 7482:{f.Push(f.Locals[4]);f.Pc=7484;continue;}
case 7484:{return rt.Call(f,"forge/game/card/Card","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",7487);}
case 7487:{f.Pc=f.Pop().Int==0?7493:7490;continue;}
case 7490:{f.Push(JValue.I(1));f.Pc=7491;continue;}
case 7491:{f.Locals[11]=f.Pop();f.Pc=7493;continue;}
case 7493:{f.Push(f.Locals[11]);f.Pc=7495;continue;}
case 7495:{f.Pc=f.Pop().Int==0?7501:7498;continue;}
case 7498:{f.Pc=7504;continue;}
case 7501:{f.Pc=7358;continue;}
case 7504:{f.Push(f.Locals[11]);f.Pc=7506;continue;}
case 7506:{f.Pc=f.Pop().Int!=0?7511:7509;continue;}
case 7509:{f.Push(JValue.I(0));f.Pc=7510;continue;}
case 7510:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7511:{f.Pc=14247;continue;}
case 7514:{f.Push(f.Locals[1]);f.Pc=7515;continue;}
case 7515:{f.Push(JValue.R(rt.String("isDamaged")));f.Pc=7518;continue;}
case 7518:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7521);}
case 7521:{f.Pc=f.Pop().Int==0?7533:7524;continue;}
case 7524:{f.Push(f.Locals[0]);f.Pc=7525;continue;}
case 7525:{return rt.Call(f,"forge/game/card/Card","getDamage","()I","invokevirtual",7528);}
case 7528:{f.Pc=f.Pop().Int>0?14247:7531;continue;}
case 7531:{f.Push(JValue.I(0));f.Pc=7532;continue;}
case 7532:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7533:{f.Push(f.Locals[1]);f.Pc=7534;continue;}
case 7534:{f.Push(JValue.R(rt.String("Damaged")));f.Pc=7537;continue;}
case 7537:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7540);}
case 7540:{f.Pc=f.Pop().Int==0?7618:7543;continue;}
case 7543:{f.Push(JValue.I(0));f.Pc=7544;continue;}
case 7544:{f.Locals[9]=f.Pop();f.Pc=7546;continue;}
case 7546:{f.Push(f.Locals[3]);f.Pc=7547;continue;}
case 7547:{return rt.Call(f,"forge/game/card/Card","getDamageReceivedThisTurn","()Ljava/util/List;","invokevirtual",7550);}
case 7550:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",7555);}
case 7555:{f.Locals[10]=f.Pop();f.Pc=7557;continue;}
case 7557:{f.Push(f.Locals[10]);f.Pc=7559;continue;}
case 7559:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",7564);}
case 7564:{f.Pc=f.Pop().Int==0?7608:7567;continue;}
case 7567:{f.Push(f.Locals[10]);f.Pc=7569;continue;}
case 7569:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",7574);}
case 7574:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7577;continue;}
case 7577:{f.Locals[11]=f.Pop();f.Pc=7579;continue;}
case 7579:{f.Push(f.Locals[5]);f.Pc=7581;continue;}
case 7581:{f.Push(f.Locals[11]);f.Pc=7583;continue;}
case 7583:{return rt.Call(f,"forge/game/Game","getDamageLKI","(Lorg/apache/commons/lang3/tuple/Pair;)Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",7586);}
case 7586:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",7589);}
case 7589:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7592;continue;}
case 7592:{f.Push(f.Locals[0]);f.Pc=7593;continue;}
case 7593:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",7596);}
case 7596:{f.Pc=f.Pop().Int==0?7605:7599;continue;}
case 7599:{f.Push(JValue.I(1));f.Pc=7600;continue;}
case 7600:{f.Locals[9]=f.Pop();f.Pc=7602;continue;}
case 7602:{f.Pc=7608;continue;}
case 7605:{f.Pc=7557;continue;}
case 7608:{f.Push(f.Locals[9]);f.Pc=7610;continue;}
case 7610:{f.Pc=f.Pop().Int!=0?7615:7613;continue;}
case 7613:{f.Push(JValue.I(0));f.Pc=7614;continue;}
case 7614:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7615:{f.Pc=14247;continue;}
case 7618:{f.Push(f.Locals[1]);f.Pc=7619;continue;}
case 7619:{f.Push(JValue.R(rt.String("dealtCombatDamageThisCombat")));f.Pc=7622;continue;}
case 7622:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7625);}
case 7625:{f.Pc=f.Pop().Int==0?7645:7628;continue;}
case 7628:{f.Push(f.Locals[0]);f.Pc=7629;continue;}
case 7629:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7632);}
case 7632:{return rt.Call(f,"forge/game/card/CardDamageHistory","getThisCombatDamaged","()Ljava/util/List;","invokevirtual",7635);}
case 7635:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",7640);}
case 7640:{f.Pc=f.Pop().Int==0?14247:7643;continue;}
case 7643:{f.Push(JValue.I(0));f.Pc=7644;continue;}
case 7644:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7645:{f.Push(f.Locals[1]);f.Pc=7646;continue;}
case 7646:{f.Push(JValue.R(rt.String("dealtDamageToYouThisTurn")));f.Pc=7649;continue;}
case 7649:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7652);}
case 7652:{f.Pc=f.Pop().Int==0?7677:7655;continue;}
case 7655:{f.Push(f.Locals[0]);f.Pc=7656;continue;}
case 7656:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7659);}
case 7659:{f.Push(JValue.R(null));f.Pc=7660;continue;}
case 7660:{f.Push(JValue.I(1));f.Pc=7661;continue;}
case 7661:{f.Push(JValue.R(null));f.Pc=7662;continue;}
case 7662:{f.Push(JValue.R(rt.String("You")));f.Pc=7665;continue;}
case 7665:{f.Push(f.Locals[0]);f.Pc=7666;continue;}
case 7666:{f.Push(f.Locals[2]);f.Pc=7667;continue;}
case 7667:{f.Push(f.Locals[4]);f.Pc=7669;continue;}
case 7669:{return rt.Call(f,"forge/game/card/CardDamageHistory","getDamageDoneThisTurn","(Ljava/lang/Boolean;ZLjava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/CardTraitBase;)I","invokevirtual",7672);}
case 7672:{f.Pc=f.Pop().Int!=0?14247:7675;continue;}
case 7675:{f.Push(JValue.I(0));f.Pc=7676;continue;}
case 7676:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7677:{f.Push(f.Locals[1]);f.Pc=7678;continue;}
case 7678:{f.Push(JValue.R(rt.String("dealtDamageToOppThisTurn")));f.Pc=7681;continue;}
case 7681:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7684);}
case 7684:{f.Pc=f.Pop().Int==0?7696:7687;continue;}
case 7687:{f.Push(f.Locals[0]);f.Pc=7688;continue;}
case 7688:{return rt.Call(f,"forge/game/card/Card","hasDealtDamageToOpponentThisTurn","()Z","invokevirtual",7691);}
case 7691:{f.Pc=f.Pop().Int!=0?14247:7694;continue;}
case 7694:{f.Push(JValue.I(0));f.Pc=7695;continue;}
case 7695:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7696:{f.Push(f.Locals[1]);f.Pc=7697;continue;}
case 7697:{f.Push(JValue.R(rt.String("dealtCombatDamageThisTurn")));f.Pc=7700;continue;}
case 7700:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7703);}
case 7703:{f.Pc=f.Pop().Int==0?7736:7706;continue;}
case 7706:{f.Push(f.Locals[0]);f.Pc=7707;continue;}
case 7707:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7710);}
case 7710:{f.Push(JValue.I(1));f.Pc=7711;continue;}
case 7711:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",7714);}
case 7714:{f.Push(JValue.I(1));f.Pc=7715;continue;}
case 7715:{f.Push(JValue.R(null));f.Pc=7716;continue;}
case 7716:{f.Push(f.Locals[1]);f.Pc=7717;continue;}
case 7717:{f.Push(JValue.R(rt.String(" ")));f.Pc=7719;continue;}
case 7719:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7722);}
case 7722:{f.Push(JValue.I(1));f.Pc=7723;continue;}
case 7723:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=7724;continue;}
case 7724:{f.Push(f.Locals[0]);f.Pc=7725;continue;}
case 7725:{f.Push(f.Locals[2]);f.Pc=7726;continue;}
case 7726:{f.Push(f.Locals[4]);f.Pc=7728;continue;}
case 7728:{return rt.Call(f,"forge/game/card/CardDamageHistory","getDamageDoneThisTurn","(Ljava/lang/Boolean;ZLjava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/CardTraitBase;)I","invokevirtual",7731);}
case 7731:{f.Pc=f.Pop().Int!=0?14247:7734;continue;}
case 7734:{f.Push(JValue.I(0));f.Pc=7735;continue;}
case 7735:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7736:{f.Push(f.Locals[1]);f.Pc=7737;continue;}
case 7737:{f.Push(JValue.R(rt.String("wasDealtDamageThisTurn")));f.Pc=7740;continue;}
case 7740:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7743);}
case 7743:{f.Pc=f.Pop().Int==0?7755:7746;continue;}
case 7746:{f.Push(f.Locals[0]);f.Pc=7747;continue;}
case 7747:{return rt.Call(f,"forge/game/card/Card","getAssignedDamage","()I","invokevirtual",7750);}
case 7750:{f.Pc=f.Pop().Int!=0?14247:7753;continue;}
case 7753:{f.Push(JValue.I(0));f.Pc=7754;continue;}
case 7754:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7755:{f.Push(f.Locals[1]);f.Pc=7756;continue;}
case 7756:{f.Push(JValue.R(rt.String("wasDealtNonCombatDamageThisTurn")));f.Pc=7759;continue;}
case 7759:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",7762);}
case 7762:{f.Pc=f.Pop().Int==0?7779:7765;continue;}
case 7765:{f.Push(f.Locals[0]);f.Pc=7766;continue;}
case 7766:{f.Push(JValue.I(0));f.Pc=7767;continue;}
case 7767:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",7770);}
case 7770:{f.Push(JValue.R(null));f.Pc=7771;continue;}
case 7771:{return rt.Call(f,"forge/game/card/Card","getAssignedDamage","(Ljava/lang/Boolean;Lforge/game/card/Card;)I","invokevirtual",7774);}
case 7774:{f.Pc=f.Pop().Int!=0?14247:7777;continue;}
case 7777:{f.Push(JValue.I(0));f.Pc=7778;continue;}
case 7778:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7779:{f.Push(f.Locals[1]);f.Pc=7780;continue;}
case 7780:{f.Push(JValue.R(rt.String("wasDealtExcessDamageThisTurn")));f.Pc=7783;continue;}
case 7783:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7786);}
case 7786:{f.Pc=f.Pop().Int==0?7798:7789;continue;}
case 7789:{f.Push(f.Locals[0]);f.Pc=7790;continue;}
case 7790:{return rt.Call(f,"forge/game/card/Card","hasBeenDealtExcessDamageThisTurn","()Z","invokevirtual",7793);}
case 7793:{f.Pc=f.Pop().Int!=0?14247:7796;continue;}
case 7796:{f.Push(JValue.I(0));f.Pc=7797;continue;}
case 7797:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7798:{f.Push(f.Locals[1]);f.Pc=7799;continue;}
case 7799:{f.Push(JValue.R(rt.String("wasDealtDamageByThisGame")));f.Pc=7802;continue;}
case 7802:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7805);}
case 7805:{f.Pc=f.Pop().Int==0?7865:7808;continue;}
case 7808:{f.Push(f.Locals[3]);f.Pc=7809;continue;}
case 7809:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7812);}
case 7812:{return rt.Call(f,"forge/game/card/CardDamageHistory","getThisGameDamaged","()Lforge/util/collect/FCollection;","invokevirtual",7815);}
case 7815:{f.Push(f.Locals[0]);f.Pc=7816;continue;}
case 7816:{return rt.Call(f,"forge/util/collect/FCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",7819);}
case 7819:{f.Locals[9]=f.Pop();f.Pc=7821;continue;}
case 7821:{f.Push(f.Locals[9]);f.Pc=7823;continue;}
case 7823:{f.Push(JValue.I(-1));f.Pc=7824;continue;}
case 7824:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?7829:7827;continue;}
case 7827:{f.Push(JValue.I(0));f.Pc=7828;continue;}
case 7828:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7829:{f.Push(f.Locals[3]);f.Pc=7830;continue;}
case 7830:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7833);}
case 7833:{return rt.Call(f,"forge/game/card/CardDamageHistory","getThisGameDamaged","()Lforge/util/collect/FCollection;","invokevirtual",7836);}
case 7836:{f.Push(f.Locals[9]);f.Pc=7838;continue;}
case 7838:{return rt.Call(f,"forge/util/collect/FCollection","get","(I)Ljava/lang/Object;","invokevirtual",7841);}
case 7841:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7844;continue;}
case 7844:{f.Locals[10]=f.Pop();f.Pc=7846;continue;}
case 7846:{f.Push(f.Locals[10]);f.Pc=7848;continue;}
case 7848:{f.Push(f.Locals[5]);f.Pc=7850;continue;}
case 7850:{f.Push(f.Locals[0]);f.Pc=7851;continue;}
case 7851:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",7854);}
case 7854:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",7857);}
case 7857:{f.Pc=f.Pop().Int!=0?7862:7860;continue;}
case 7860:{f.Push(JValue.I(0));f.Pc=7861;continue;}
case 7861:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7862:{f.Pc=14247;continue;}
case 7865:{f.Push(f.Locals[1]);f.Pc=7866;continue;}
case 7866:{f.Push(JValue.R(rt.String("dealtDamageThisTurn")));f.Pc=7869;continue;}
case 7869:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7872);}
case 7872:{f.Pc=f.Pop().Int==0?7884:7875;continue;}
case 7875:{f.Push(f.Locals[0]);f.Pc=7876;continue;}
case 7876:{return rt.Call(f,"forge/game/card/Card","getTotalDamageDoneBy","()I","invokevirtual",7879);}
case 7879:{f.Pc=f.Pop().Int!=0?14247:7882;continue;}
case 7882:{f.Push(JValue.I(0));f.Pc=7883;continue;}
case 7883:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7884:{f.Push(f.Locals[1]);f.Pc=7885;continue;}
case 7885:{f.Push(JValue.R(rt.String("dealtDamagetoAny")));f.Pc=7888;continue;}
case 7888:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7891);}
case 7891:{f.Pc=f.Pop().Int==0?7902:7894;continue;}
case 7894:{f.Push(f.Locals[0]);f.Pc=7895;continue;}
case 7895:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7898);}
case 7898:{return rt.Call(f,"forge/game/card/CardDamageHistory","getHasdealtDamagetoAny","()Z","invokevirtual",7901);}
case 7901:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7902:{f.Push(f.Locals[1]);f.Pc=7903;continue;}
case 7903:{f.Push(JValue.R(rt.String("dealtCombatDamagetoAny")));f.Pc=7906;continue;}
case 7906:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7909);}
case 7909:{f.Pc=f.Pop().Int==0?7920:7912;continue;}
case 7912:{f.Push(f.Locals[0]);f.Pc=7913;continue;}
case 7913:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7916);}
case 7916:{return rt.Call(f,"forge/game/card/CardDamageHistory","getHasdealtCombatDamagetoAny","()Z","invokevirtual",7919);}
case 7919:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7920:{f.Push(f.Locals[1]);f.Pc=7921;continue;}
case 7921:{f.Push(JValue.R(rt.String("attackedThisTurn")));f.Pc=7924;continue;}
case 7924:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7927);}
case 7927:{f.Pc=f.Pop().Int==0?7942:7930;continue;}
case 7930:{f.Push(f.Locals[0]);f.Pc=7931;continue;}
case 7931:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7934);}
case 7934:{return rt.Call(f,"forge/game/card/CardDamageHistory","getCreatureAttacksThisTurn","()I","invokevirtual",7937);}
case 7937:{f.Pc=f.Pop().Int!=0?14247:7940;continue;}
case 7940:{f.Push(JValue.I(0));f.Pc=7941;continue;}
case 7941:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7942:{f.Push(f.Locals[1]);f.Pc=7943;continue;}
case 7943:{f.Push(JValue.R(rt.String("attackedBattleThisTurn")));f.Pc=7946;continue;}
case 7946:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7949);}
case 7949:{f.Pc=f.Pop().Int==0?7964:7952;continue;}
case 7952:{f.Push(f.Locals[0]);f.Pc=7953;continue;}
case 7953:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7956);}
case 7956:{return rt.Call(f,"forge/game/card/CardDamageHistory","hasAttackedBattleThisTurn","()Z","invokevirtual",7959);}
case 7959:{f.Pc=f.Pop().Int!=0?14247:7962;continue;}
case 7962:{f.Push(JValue.I(0));f.Pc=7963;continue;}
case 7963:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7964:{f.Push(f.Locals[1]);f.Pc=7965;continue;}
case 7965:{f.Push(JValue.R(rt.String("attackedYouThisTurn")));f.Pc=7968;continue;}
case 7968:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7971);}
case 7971:{f.Pc=f.Pop().Int==0?7987:7974;continue;}
case 7974:{f.Push(f.Locals[0]);f.Pc=7975;continue;}
case 7975:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",7978);}
case 7978:{f.Push(f.Locals[2]);f.Pc=7979;continue;}
case 7979:{return rt.Call(f,"forge/game/card/CardDamageHistory","hasAttackedThisTurn","(Lforge/game/GameEntity;)Z","invokevirtual",7982);}
case 7982:{f.Pc=f.Pop().Int!=0?14247:7985;continue;}
case 7985:{f.Push(JValue.I(0));f.Pc=7986;continue;}
case 7986:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7987:{f.Push(f.Locals[1]);f.Pc=7988;continue;}
case 7988:{f.Push(JValue.R(rt.String("attackedLastTurn")));f.Pc=7991;continue;}
case 7991:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7994);}
case 7994:{f.Pc=f.Pop().Int==0?8007:7997;continue;}
case 7997:{f.Push(f.Locals[0]);f.Pc=7998;continue;}
case 7998:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",8001);}
case 8001:{f.Push(f.Locals[8]);f.Pc=8003;continue;}
case 8003:{return rt.Call(f,"forge/game/card/CardDamageHistory","getCreatureAttackedLastTurnOf","(Lforge/game/player/Player;)Z","invokevirtual",8006);}
case 8006:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8007:{f.Push(f.Locals[1]);f.Pc=8008;continue;}
case 8008:{f.Push(JValue.R(rt.String("blockedThisTurn")));f.Pc=8011;continue;}
case 8011:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8014);}
case 8014:{f.Pc=f.Pop().Int==0?8031:8017;continue;}
case 8017:{f.Push(f.Locals[0]);f.Pc=8018;continue;}
case 8018:{return rt.Call(f,"forge/game/card/Card","getBlockedThisTurn","()Ljava/util/List;","invokevirtual",8021);}
case 8021:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",8026);}
case 8026:{f.Pc=f.Pop().Int==0?14247:8029;continue;}
case 8029:{f.Push(JValue.I(0));f.Pc=8030;continue;}
case 8030:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8031:{f.Push(f.Locals[1]);f.Pc=8032;continue;}
case 8032:{f.Push(JValue.R(rt.String("notExertedThisTurn")));f.Pc=8035;continue;}
case 8035:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8038);}
case 8038:{f.Pc=f.Pop().Int==0?8050:8041;continue;}
case 8041:{f.Push(f.Locals[0]);f.Pc=8042;continue;}
case 8042:{return rt.Call(f,"forge/game/card/Card","getExertedThisTurn","()I","invokevirtual",8045);}
case 8045:{f.Pc=f.Pop().Int<=0?14247:8048;continue;}
case 8048:{f.Push(JValue.I(0));f.Pc=8049;continue;}
case 8049:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8050:{f.Push(f.Locals[1]);f.Pc=8051;continue;}
case 8051:{f.Push(JValue.R(rt.String("gotBlockedThisTurn")));f.Pc=8054;continue;}
case 8054:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8057);}
case 8057:{f.Pc=f.Pop().Int==0?8074:8060;continue;}
case 8060:{f.Push(f.Locals[0]);f.Pc=8061;continue;}
case 8061:{return rt.Call(f,"forge/game/card/Card","getBlockedByThisTurn","()Ljava/util/List;","invokevirtual",8064);}
case 8064:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",8069);}
case 8069:{f.Pc=f.Pop().Int==0?14247:8072;continue;}
case 8072:{f.Push(JValue.I(0));f.Pc=8073;continue;}
case 8073:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8074:{f.Push(f.Locals[1]);f.Pc=8075;continue;}
case 8075:{f.Push(JValue.R(rt.String("greatestPower")));f.Pc=8078;continue;}
case 8078:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8081);}
case 8081:{f.Pc=f.Pop().Int==0?8207:8084;continue;}
case 8084:{f.Push(f.Locals[5]);f.Pc=8086;continue;}
case 8086:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=8089;continue;}
case 8089:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",8092);}
case 8092:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"));f.Pc=8095;continue;}
case 8095:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",8098);}
case 8098:{f.Locals[9]=f.Pop();f.Pc=8100;continue;}
case 8100:{f.Push(f.Locals[1]);f.Pc=8101;continue;}
case 8101:{f.Push(JValue.R(rt.String("ControlledBy")));f.Pc=8104;continue;}
case 8104:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",8107);}
case 8107:{f.Pc=f.Pop().Int==0?8156:8110;continue;}
case 8110:{f.Push(f.Locals[3]);f.Pc=8111;continue;}
case 8111:{f.Push(f.Locals[1]);f.Pc=8112;continue;}
case 8112:{f.Push(JValue.R(rt.String("ControlledBy")));f.Pc=8115;continue;}
case 8115:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",8118);}
case 8118:{f.Push(JValue.I(1));f.Pc=8119;continue;}
case 8119:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8120;continue;}
case 8120:{f.Push(f.Locals[4]);f.Pc=8122;continue;}
case 8122:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",8125);}
case 8125:{f.Locals[10]=f.Pop();f.Pc=8127;continue;}
case 8127:{f.Push(f.Locals[9]);f.Pc=8129;continue;}
case 8129:{f.Push(f.Locals[10]);f.Pc=8131;continue;}
case 8131:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/util/collect/FCollectionView;)Lforge/game/card/CardCollection;","invokestatic",8134);}
case 8134:{f.Locals[9]=f.Pop();f.Pc=8136;continue;}
case 8136:{f.Push(f.Locals[0]);f.Pc=8137;continue;}
case 8137:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",8140);}
case 8140:{f.Pc=f.Pop().Int!=0?8156:8143;continue;}
case 8143:{f.Push(f.Locals[9]);f.Pc=8145;continue;}
case 8145:{f.Push(f.Locals[0]);f.Pc=8146;continue;}
case 8146:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",8151);}
case 8151:{f.Pc=f.Pop().Int!=0?8156:8154;continue;}
case 8154:{f.Push(JValue.I(0));f.Pc=8155;continue;}
case 8155:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8156:{f.Push(f.Locals[9]);f.Pc=8158;continue;}
case 8158:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",8163);}
case 8163:{f.Locals[10]=f.Pop();f.Pc=8165;continue;}
case 8165:{f.Push(f.Locals[10]);f.Pc=8167;continue;}
case 8167:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",8172);}
case 8172:{f.Pc=f.Pop().Int==0?8204:8175;continue;}
case 8175:{f.Push(f.Locals[10]);f.Pc=8177;continue;}
case 8177:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",8182);}
case 8182:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8185;continue;}
case 8185:{f.Locals[11]=f.Pop();f.Pc=8187;continue;}
case 8187:{f.Push(f.Locals[11]);f.Pc=8189;continue;}
case 8189:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",8192);}
case 8192:{f.Push(f.Locals[0]);f.Pc=8193;continue;}
case 8193:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",8196);}
case 8196:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?8201:8199;continue;}
case 8199:{f.Push(JValue.I(0));f.Pc=8200;continue;}
case 8200:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8201:{f.Pc=8165;continue;}
case 8204:{f.Pc=14247;continue;}
case 8207:{f.Push(f.Locals[1]);f.Pc=8208;continue;}
case 8208:{f.Push(JValue.R(rt.String("yardGreatestPower")));f.Pc=8211;continue;}
case 8211:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8214);}
case 8214:{f.Pc=f.Pop().Int==0?8283:8217;continue;}
case 8217:{f.Push(f.Locals[2]);f.Pc=8218;continue;}
case 8218:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=8221;continue;}
case 8221:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",8224);}
case 8224:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"));f.Pc=8227;continue;}
case 8227:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",8230);}
case 8230:{f.Locals[9]=f.Pop();f.Pc=8232;continue;}
case 8232:{f.Push(f.Locals[9]);f.Pc=8234;continue;}
case 8234:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",8239);}
case 8239:{f.Locals[10]=f.Pop();f.Pc=8241;continue;}
case 8241:{f.Push(f.Locals[10]);f.Pc=8243;continue;}
case 8243:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",8248);}
case 8248:{f.Pc=f.Pop().Int==0?8280:8251;continue;}
case 8251:{f.Push(f.Locals[10]);f.Pc=8253;continue;}
case 8253:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",8258);}
case 8258:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8261;continue;}
case 8261:{f.Locals[11]=f.Pop();f.Pc=8263;continue;}
case 8263:{f.Push(f.Locals[11]);f.Pc=8265;continue;}
case 8265:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",8268);}
case 8268:{f.Push(f.Locals[0]);f.Pc=8269;continue;}
case 8269:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",8272);}
case 8272:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?8277:8275;continue;}
case 8275:{f.Push(JValue.I(0));f.Pc=8276;continue;}
case 8276:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8277:{f.Pc=8241;continue;}
case 8280:{f.Pc=14247;continue;}
case 8283:{f.Push(f.Locals[1]);f.Pc=8284;continue;}
case 8284:{f.Push(JValue.R(rt.String("leastPower")));f.Pc=8287;continue;}
case 8287:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8290);}
case 8290:{f.Pc=f.Pop().Int==0?8409:8293;continue;}
case 8293:{f.Push(f.Locals[5]);f.Pc=8295;continue;}
case 8295:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=8298;continue;}
case 8298:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",8301);}
case 8301:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"));f.Pc=8304;continue;}
case 8304:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",8307);}
case 8307:{f.Locals[9]=f.Pop();f.Pc=8309;continue;}
case 8309:{f.Push(f.Locals[1]);f.Pc=8310;continue;}
case 8310:{f.Push(JValue.R(rt.String("ControlledBy")));f.Pc=8313;continue;}
case 8313:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",8316);}
case 8316:{f.Pc=f.Pop().Int==0?8358:8319;continue;}
case 8319:{f.Push(f.Locals[3]);f.Pc=8320;continue;}
case 8320:{f.Push(f.Locals[1]);f.Pc=8321;continue;}
case 8321:{f.Push(JValue.R(rt.String("ControlledBy")));f.Pc=8324;continue;}
case 8324:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",8327);}
case 8327:{f.Push(JValue.I(1));f.Pc=8328;continue;}
case 8328:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8329;continue;}
case 8329:{f.Push(f.Locals[4]);f.Pc=8331;continue;}
case 8331:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",8334);}
case 8334:{f.Locals[10]=f.Pop();f.Pc=8336;continue;}
case 8336:{f.Push(f.Locals[9]);f.Pc=8338;continue;}
case 8338:{f.Push(f.Locals[10]);f.Pc=8340;continue;}
case 8340:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/util/collect/FCollectionView;)Lforge/game/card/CardCollection;","invokestatic",8343);}
case 8343:{f.Locals[9]=f.Pop();f.Pc=8345;continue;}
case 8345:{f.Push(f.Locals[9]);f.Pc=8347;continue;}
case 8347:{f.Push(f.Locals[0]);f.Pc=8348;continue;}
case 8348:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",8353);}
case 8353:{f.Pc=f.Pop().Int!=0?8358:8356;continue;}
case 8356:{f.Push(JValue.I(0));f.Pc=8357;continue;}
case 8357:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8358:{f.Push(f.Locals[9]);f.Pc=8360;continue;}
case 8360:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",8365);}
case 8365:{f.Locals[10]=f.Pop();f.Pc=8367;continue;}
case 8367:{f.Push(f.Locals[10]);f.Pc=8369;continue;}
case 8369:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",8374);}
case 8374:{f.Pc=f.Pop().Int==0?8406:8377;continue;}
case 8377:{f.Push(f.Locals[10]);f.Pc=8379;continue;}
case 8379:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",8384);}
case 8384:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8387;continue;}
case 8387:{f.Locals[11]=f.Pop();f.Pc=8389;continue;}
case 8389:{f.Push(f.Locals[11]);f.Pc=8391;continue;}
case 8391:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",8394);}
case 8394:{f.Push(f.Locals[0]);f.Pc=8395;continue;}
case 8395:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",8398);}
case 8398:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?8403:8401;continue;}
case 8401:{f.Push(JValue.I(0));f.Pc=8402;continue;}
case 8402:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8403:{f.Pc=8367;continue;}
case 8406:{f.Pc=14247;continue;}
case 8409:{f.Push(f.Locals[1]);f.Pc=8410;continue;}
case 8410:{f.Push(JValue.R(rt.String("leastToughness")));f.Pc=8413;continue;}
case 8413:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8416);}
case 8416:{f.Pc=f.Pop().Int==0?8535:8419;continue;}
case 8419:{f.Push(f.Locals[5]);f.Pc=8421;continue;}
case 8421:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=8424;continue;}
case 8424:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",8427);}
case 8427:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","CREATURES","Ljava/util/function/Predicate;"));f.Pc=8430;continue;}
case 8430:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",8433);}
case 8433:{f.Locals[9]=f.Pop();f.Pc=8435;continue;}
case 8435:{f.Push(f.Locals[1]);f.Pc=8436;continue;}
case 8436:{f.Push(JValue.R(rt.String("ControlledBy")));f.Pc=8439;continue;}
case 8439:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",8442);}
case 8442:{f.Pc=f.Pop().Int==0?8484:8445;continue;}
case 8445:{f.Push(f.Locals[3]);f.Pc=8446;continue;}
case 8446:{f.Push(f.Locals[1]);f.Pc=8447;continue;}
case 8447:{f.Push(JValue.R(rt.String("ControlledBy")));f.Pc=8450;continue;}
case 8450:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",8453);}
case 8453:{f.Push(JValue.I(1));f.Pc=8454;continue;}
case 8454:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8455;continue;}
case 8455:{f.Push(f.Locals[4]);f.Pc=8457;continue;}
case 8457:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",8460);}
case 8460:{f.Locals[10]=f.Pop();f.Pc=8462;continue;}
case 8462:{f.Push(f.Locals[9]);f.Pc=8464;continue;}
case 8464:{f.Push(f.Locals[10]);f.Pc=8466;continue;}
case 8466:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/util/collect/FCollectionView;)Lforge/game/card/CardCollection;","invokestatic",8469);}
case 8469:{f.Locals[9]=f.Pop();f.Pc=8471;continue;}
case 8471:{f.Push(f.Locals[9]);f.Pc=8473;continue;}
case 8473:{f.Push(f.Locals[0]);f.Pc=8474;continue;}
case 8474:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",8479);}
case 8479:{f.Pc=f.Pop().Int!=0?8484:8482;continue;}
case 8482:{f.Push(JValue.I(0));f.Pc=8483;continue;}
case 8483:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8484:{f.Push(f.Locals[9]);f.Pc=8486;continue;}
case 8486:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",8491);}
case 8491:{f.Locals[10]=f.Pop();f.Pc=8493;continue;}
case 8493:{f.Push(f.Locals[10]);f.Pc=8495;continue;}
case 8495:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",8500);}
case 8500:{f.Pc=f.Pop().Int==0?8532:8503;continue;}
case 8503:{f.Push(f.Locals[10]);f.Pc=8505;continue;}
case 8505:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",8510);}
case 8510:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8513;continue;}
case 8513:{f.Locals[11]=f.Pop();f.Pc=8515;continue;}
case 8515:{f.Push(f.Locals[11]);f.Pc=8517;continue;}
case 8517:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",8520);}
case 8520:{f.Push(f.Locals[0]);f.Pc=8521;continue;}
case 8521:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",8524);}
case 8524:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?8529:8527;continue;}
case 8527:{f.Push(JValue.I(0));f.Pc=8528;continue;}
case 8528:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8529:{f.Pc=8493;continue;}
case 8532:{f.Pc=14247;continue;}
case 8535:{f.Push(f.Locals[1]);f.Pc=8536;continue;}
case 8536:{f.Push(JValue.R(rt.String("greatestCMC_")));f.Pc=8539;continue;}
case 8539:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8542);}
case 8542:{f.Pc=f.Pop().Int==0?8671:8545;continue;}
case 8545:{f.Push(f.Locals[5]);f.Pc=8547;continue;}
case 8547:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=8550;continue;}
case 8550:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",8553);}
case 8553:{f.Locals[9]=f.Pop();f.Pc=8555;continue;}
case 8555:{f.Push(f.Locals[1]);f.Pc=8556;continue;}
case 8556:{f.Push(JValue.R(rt.String("greatestCMC_")));f.Pc=8559;continue;}
case 8559:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",8562);}
case 8562:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",8565);}
case 8565:{f.Locals[10]=f.Pop();f.Pc=8567;continue;}
case 8567:{f.Push(f.Locals[10]);f.Pc=8569;continue;}
case 8569:{f.Push(JValue.R(rt.String("ControlledBy")));f.Pc=8572;continue;}
case 8572:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",8575);}
case 8575:{f.Pc=f.Pop().Int==0?8615:8578;continue;}
case 8578:{f.Push(f.Locals[10]);f.Pc=8580;continue;}
case 8580:{f.Push(JValue.R(rt.String("ControlledBy")));f.Pc=8583;continue;}
case 8583:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",8586);}
case 8586:{f.Push(JValue.I(0));f.Pc=8587;continue;}
case 8587:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8588;continue;}
case 8588:{f.Locals[10]=f.Pop();f.Pc=8590;continue;}
case 8590:{f.Push(f.Locals[3]);f.Pc=8591;continue;}
case 8591:{f.Push(f.Locals[1]);f.Pc=8592;continue;}
case 8592:{f.Push(JValue.R(rt.String("ControlledBy")));f.Pc=8595;continue;}
case 8595:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",8598);}
case 8598:{f.Push(JValue.I(1));f.Pc=8599;continue;}
case 8599:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8600;continue;}
case 8600:{f.Push(JValue.R(null));f.Pc=8601;continue;}
case 8601:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",8604);}
case 8604:{f.Locals[11]=f.Pop();f.Pc=8606;continue;}
case 8606:{f.Push(f.Locals[9]);f.Pc=8608;continue;}
case 8608:{f.Push(f.Locals[11]);f.Pc=8610;continue;}
case 8610:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/util/collect/FCollectionView;)Lforge/game/card/CardCollection;","invokestatic",8613);}
case 8613:{f.Locals[9]=f.Pop();f.Pc=8615;continue;}
case 8615:{f.Push(JValue.R(rt.String("NonLandPermanent")));f.Pc=8618;continue;}
case 8618:{f.Push(f.Locals[10]);f.Pc=8620;continue;}
case 8620:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",8623);}
case 8623:{f.Pc=f.Pop().Int==0?8639:8626;continue;}
case 8626:{f.Push(f.Locals[9]);f.Pc=8628;continue;}
case 8628:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","NONLAND_PERMANENTS","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","NONLAND_PERMANENTS","Ljava/util/function/Predicate;"));f.Pc=8631;continue;}
case 8631:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",8634);}
case 8634:{f.Locals[9]=f.Pop();f.Pc=8636;continue;}
case 8636:{f.Pc=8648;continue;}
case 8639:{f.Push(f.Locals[9]);f.Pc=8641;continue;}
case 8641:{f.Push(f.Locals[10]);f.Pc=8643;continue;}
case 8643:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",8646);}
case 8646:{f.Locals[9]=f.Pop();f.Pc=8648;continue;}
case 8648:{f.Push(f.Locals[9]);f.Pc=8650;continue;}
case 8650:{return rt.Call(f,"forge/game/card/CardLists","getCardsWithHighestCMC","(Ljava/lang/Iterable;)Lforge/game/card/CardCollection;","invokestatic",8653);}
case 8653:{f.Locals[9]=f.Pop();f.Pc=8655;continue;}
case 8655:{f.Push(f.Locals[9]);f.Pc=8657;continue;}
case 8657:{f.Push(f.Locals[0]);f.Pc=8658;continue;}
case 8658:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",8663);}
case 8663:{f.Pc=f.Pop().Int!=0?8668:8666;continue;}
case 8666:{f.Push(JValue.I(0));f.Pc=8667;continue;}
case 8667:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8668:{f.Pc=14247;continue;}
case 8671:{f.Push(f.Locals[1]);f.Pc=8672;continue;}
case 8672:{f.Push(JValue.R(rt.String("greatestRememberedCMC")));f.Pc=8675;continue;}
case 8675:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8678);}
case 8678:{f.Pc=f.Pop().Int==0?8779:8681;continue;}
case 8681:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=8684;continue;}
case 8684:{f.StackOp("dup");f.Pc=8685;continue;}
case 8685:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",8688);}
case 8688:{f.Locals[9]=f.Pop();f.Pc=8690;continue;}
case 8690:{f.Push(f.Locals[3]);f.Pc=8691;continue;}
case 8691:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",8694);}
case 8694:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8699);}
case 8699:{f.Locals[10]=f.Pop();f.Pc=8701;continue;}
case 8701:{f.Push(f.Locals[10]);f.Pc=8703;continue;}
case 8703:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",8708);}
case 8708:{f.Pc=f.Pop().Int==0?8747:8711;continue;}
case 8711:{f.Push(f.Locals[10]);f.Pc=8713;continue;}
case 8713:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",8718);}
case 8718:{f.Locals[11]=f.Pop();f.Pc=8720;continue;}
case 8720:{f.Push(f.Locals[11]);f.Pc=8722;continue;}
case 8722:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=8725;continue;}
case 8725:{f.Pc=f.Pop().Int==0?8744:8728;continue;}
case 8728:{f.Push(f.Locals[9]);f.Pc=8730;continue;}
case 8730:{f.Push(f.Locals[5]);f.Pc=8732;continue;}
case 8732:{f.Push(f.Locals[11]);f.Pc=8734;continue;}
case 8734:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8737;continue;}
case 8737:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",8740);}
case 8740:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",8743);}
case 8743:{f.StackOp("pop");f.Pc=8744;continue;}
case 8744:{f.Pc=8701;continue;}
case 8747:{f.Push(f.Locals[9]);f.Pc=8749;continue;}
case 8749:{f.Push(f.Locals[0]);f.Pc=8750;continue;}
case 8750:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",8753);}
case 8753:{f.Pc=f.Pop().Int!=0?8758:8756;continue;}
case 8756:{f.Push(JValue.I(0));f.Pc=8757;continue;}
case 8757:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8758:{f.Push(f.Locals[9]);f.Pc=8760;continue;}
case 8760:{return rt.Call(f,"forge/game/card/CardLists","getCardsWithHighestCMC","(Ljava/lang/Iterable;)Lforge/game/card/CardCollection;","invokestatic",8763);}
case 8763:{f.Locals[9]=f.Pop();f.Pc=8765;continue;}
case 8765:{f.Push(f.Locals[9]);f.Pc=8767;continue;}
case 8767:{f.Push(f.Locals[0]);f.Pc=8768;continue;}
case 8768:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",8771);}
case 8771:{f.Pc=f.Pop().Int!=0?8776:8774;continue;}
case 8774:{f.Push(JValue.I(0));f.Pc=8775;continue;}
case 8775:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8776:{f.Pc=14247;continue;}
case 8779:{f.Push(f.Locals[1]);f.Pc=8780;continue;}
case 8780:{f.Push(JValue.R(rt.String("lowestRememberedCMC")));f.Pc=8783;continue;}
case 8783:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8786);}
case 8786:{f.Pc=f.Pop().Int==0?8887:8789;continue;}
case 8789:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=8792;continue;}
case 8792:{f.StackOp("dup");f.Pc=8793;continue;}
case 8793:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",8796);}
case 8796:{f.Locals[9]=f.Pop();f.Pc=8798;continue;}
case 8798:{f.Push(f.Locals[3]);f.Pc=8799;continue;}
case 8799:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",8802);}
case 8802:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8807);}
case 8807:{f.Locals[10]=f.Pop();f.Pc=8809;continue;}
case 8809:{f.Push(f.Locals[10]);f.Pc=8811;continue;}
case 8811:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",8816);}
case 8816:{f.Pc=f.Pop().Int==0?8855:8819;continue;}
case 8819:{f.Push(f.Locals[10]);f.Pc=8821;continue;}
case 8821:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",8826);}
case 8826:{f.Locals[11]=f.Pop();f.Pc=8828;continue;}
case 8828:{f.Push(f.Locals[11]);f.Pc=8830;continue;}
case 8830:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=8833;continue;}
case 8833:{f.Pc=f.Pop().Int==0?8852:8836;continue;}
case 8836:{f.Push(f.Locals[9]);f.Pc=8838;continue;}
case 8838:{f.Push(f.Locals[5]);f.Pc=8840;continue;}
case 8840:{f.Push(f.Locals[11]);f.Pc=8842;continue;}
case 8842:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8845;continue;}
case 8845:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",8848);}
case 8848:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",8851);}
case 8851:{f.StackOp("pop");f.Pc=8852;continue;}
case 8852:{f.Pc=8809;continue;}
case 8855:{f.Push(f.Locals[9]);f.Pc=8857;continue;}
case 8857:{f.Push(f.Locals[0]);f.Pc=8858;continue;}
case 8858:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",8861);}
case 8861:{f.Pc=f.Pop().Int!=0?8866:8864;continue;}
case 8864:{f.Push(JValue.I(0));f.Pc=8865;continue;}
case 8865:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8866:{f.Push(f.Locals[9]);f.Pc=8868;continue;}
case 8868:{return rt.Call(f,"forge/game/card/CardLists","getCardsWithLowestCMC","(Ljava/lang/Iterable;)Lforge/game/card/CardCollection;","invokestatic",8871);}
case 8871:{f.Locals[9]=f.Pop();f.Pc=8873;continue;}
case 8873:{f.Push(f.Locals[9]);f.Pc=8875;continue;}
case 8875:{f.Push(f.Locals[0]);f.Pc=8876;continue;}
case 8876:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",8879);}
case 8879:{f.Pc=f.Pop().Int!=0?8884:8882;continue;}
case 8882:{f.Push(JValue.I(0));f.Pc=8883;continue;}
case 8883:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8884:{f.Pc=14247;continue;}
case 8887:{f.Push(f.Locals[1]);f.Pc=8888;continue;}
case 8888:{f.Push(JValue.R(rt.String("lowestCMC")));f.Pc=8891;continue;}
case 8891:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8894);}
case 8894:{f.Pc=f.Pop().Int==0?8974:8897;continue;}
case 8897:{f.Push(f.Locals[5]);f.Pc=8899;continue;}
case 8899:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=8902;continue;}
case 8902:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",8905);}
case 8905:{f.Locals[9]=f.Pop();f.Pc=8907;continue;}
case 8907:{f.Push(f.Locals[9]);f.Pc=8909;continue;}
case 8909:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",8914);}
case 8914:{f.Locals[10]=f.Pop();f.Pc=8916;continue;}
case 8916:{f.Push(f.Locals[10]);f.Pc=8918;continue;}
case 8918:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",8923);}
case 8923:{f.Pc=f.Pop().Int==0?8971:8926;continue;}
case 8926:{f.Push(f.Locals[10]);f.Pc=8928;continue;}
case 8928:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",8933);}
case 8933:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8936;continue;}
case 8936:{f.Locals[11]=f.Pop();f.Pc=8938;continue;}
case 8938:{f.Push(f.Locals[11]);f.Pc=8940;continue;}
case 8940:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",8943);}
case 8943:{f.Pc=f.Pop().Int!=0?8968:8946;continue;}
case 8946:{f.Push(f.Locals[11]);f.Pc=8948;continue;}
case 8948:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",8951);}
case 8951:{f.Pc=f.Pop().Int!=0?8968:8954;continue;}
case 8954:{f.Push(f.Locals[11]);f.Pc=8956;continue;}
case 8956:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",8959);}
case 8959:{f.Push(f.Locals[0]);f.Pc=8960;continue;}
case 8960:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",8963);}
case 8963:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?8968:8966;continue;}
case 8966:{f.Push(JValue.I(0));f.Pc=8967;continue;}
case 8967:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8968:{f.Pc=8916;continue;}
case 8971:{f.Pc=14247;continue;}
case 8974:{f.Push(f.Locals[1]);f.Pc=8975;continue;}
case 8975:{f.Push(JValue.R(rt.String("enchanted")));f.Pc=8978;continue;}
case 8978:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8981);}
case 8981:{f.Pc=f.Pop().Int==0?8993:8984;continue;}
case 8984:{f.Push(f.Locals[0]);f.Pc=8985;continue;}
case 8985:{return rt.Call(f,"forge/game/card/Card","isEnchanted","()Z","invokevirtual",8988);}
case 8988:{f.Pc=f.Pop().Int!=0?14247:8991;continue;}
case 8991:{f.Push(JValue.I(0));f.Pc=8992;continue;}
case 8992:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 8993:{f.Push(f.Locals[1]);f.Pc=8994;continue;}
case 8994:{f.Push(JValue.R(rt.String("enchanting")));f.Pc=8997;continue;}
case 8997:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9000);}
case 9000:{f.Pc=f.Pop().Int==0?9012:9003;continue;}
case 9003:{f.Push(f.Locals[0]);f.Pc=9004;continue;}
case 9004:{return rt.Call(f,"forge/game/card/Card","isEnchanting","()Z","invokevirtual",9007);}
case 9007:{f.Pc=f.Pop().Int!=0?14247:9010;continue;}
case 9010:{f.Push(JValue.I(0));f.Pc=9011;continue;}
case 9011:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9012:{f.Push(f.Locals[1]);f.Pc=9013;continue;}
case 9013:{f.Push(JValue.R(rt.String("equipped")));f.Pc=9016;continue;}
case 9016:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9019);}
case 9019:{f.Pc=f.Pop().Int==0?9031:9022;continue;}
case 9022:{f.Push(f.Locals[0]);f.Pc=9023;continue;}
case 9023:{return rt.Call(f,"forge/game/card/Card","isEquipped","()Z","invokevirtual",9026);}
case 9026:{f.Pc=f.Pop().Int!=0?14247:9029;continue;}
case 9029:{f.Push(JValue.I(0));f.Pc=9030;continue;}
case 9030:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9031:{f.Push(f.Locals[1]);f.Pc=9032;continue;}
case 9032:{f.Push(JValue.R(rt.String("equipping")));f.Pc=9035;continue;}
case 9035:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9038);}
case 9038:{f.Pc=f.Pop().Int==0?9050:9041;continue;}
case 9041:{f.Push(f.Locals[0]);f.Pc=9042;continue;}
case 9042:{return rt.Call(f,"forge/game/card/Card","isEquipping","()Z","invokevirtual",9045);}
case 9045:{f.Pc=f.Pop().Int!=0?14247:9048;continue;}
case 9048:{f.Push(JValue.I(0));f.Pc=9049;continue;}
case 9049:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9050:{f.Push(f.Locals[1]);f.Pc=9051;continue;}
case 9051:{f.Push(JValue.R(rt.String("modified")));f.Pc=9054;continue;}
case 9054:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9057);}
case 9057:{f.Pc=f.Pop().Int==0?9069:9060;continue;}
case 9060:{f.Push(f.Locals[0]);f.Pc=9061;continue;}
case 9061:{return rt.Call(f,"forge/game/card/Card","isModified","()Z","invokevirtual",9064);}
case 9064:{f.Pc=f.Pop().Int!=0?14247:9067;continue;}
case 9067:{f.Push(JValue.I(0));f.Pc=9068;continue;}
case 9068:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9069:{f.Push(f.Locals[1]);f.Pc=9070;continue;}
case 9070:{f.Push(JValue.R(rt.String("stickered")));f.Pc=9073;continue;}
case 9073:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9076);}
case 9076:{f.Pc=f.Pop().Int==0?9088:9079;continue;}
case 9079:{f.Push(f.Locals[0]);f.Pc=9080;continue;}
case 9080:{return rt.Call(f,"forge/game/card/Card","isStickered","()Z","invokevirtual",9083);}
case 9083:{f.Pc=f.Pop().Int!=0?14247:9086;continue;}
case 9086:{f.Push(JValue.I(0));f.Pc=9087;continue;}
case 9087:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9088:{f.Push(f.Locals[1]);f.Pc=9089;continue;}
case 9089:{f.Push(JValue.R(rt.String("stickeredWith ")));f.Pc=9092;continue;}
case 9092:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9095);}
case 9095:{f.Pc=f.Pop().Int==0?9142:9098;continue;}
case 9098:{f.Push(f.Locals[1]);f.Pc=9099;continue;}
case 9099:{f.Push(JValue.R(rt.String("stickeredWith ")));f.Pc=9102;continue;}
case 9102:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",9105);}
case 9105:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",9108);}
case 9108:{return rt.Call(f,"forge/game/card/sticker/StickerKind","smartValueOf","(Ljava/lang/String;)Lforge/game/card/sticker/StickerKind;","invokestatic",9111);}
case 9111:{f.Locals[9]=f.Pop();f.Pc=9113;continue;}
case 9113:{f.Push(f.Locals[0]);f.Pc=9114;continue;}
case 9114:{return rt.Call(f,"forge/game/card/Card","getStickers","()Ljava/util/List;","invokevirtual",9117);}
case 9117:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",9122);}
case 9122:{f.Push(f.Locals[9]);f.Pc=9124;continue;}
case 9124:{return rt.DynamicCall(f,"forge/game/card/CardProperty:5251:9124:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/sticker/StickerKind;)Ljava/util/function/Predicate;",9129);}
case 9129:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",9134);}
case 9134:{f.Pc=f.Pop().Int==0?9139:9137;continue;}
case 9137:{f.Push(JValue.I(0));f.Pc=9138;continue;}
case 9138:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9139:{f.Pc=14247;continue;}
case 9142:{f.Push(f.Locals[1]);f.Pc=9143;continue;}
case 9143:{f.Push(JValue.R(rt.String("token")));f.Pc=9146;continue;}
case 9146:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9149);}
case 9149:{f.Pc=f.Pop().Int==0?9187:9152;continue;}
case 9152:{f.Push(f.Locals[0]);f.Pc=9153;continue;}
case 9153:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",9156);}
case 9156:{f.Pc=f.Pop().Int!=0?9168:9159;continue;}
case 9159:{f.Push(f.Locals[0]);f.Pc=9160;continue;}
case 9160:{return rt.Call(f,"forge/game/card/Card","isTokenCard","()Z","invokevirtual",9163);}
case 9163:{f.Pc=f.Pop().Int!=0?9168:9166;continue;}
case 9166:{f.Push(JValue.I(0));f.Pc=9167;continue;}
case 9167:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9168:{f.Push(f.Locals[1]);f.Pc=9169;continue;}
case 9169:{f.Push(JValue.R(rt.String("Created")));f.Pc=9172;continue;}
case 9172:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",9175);}
case 9175:{f.Pc=f.Pop().Int==0?14247:9178;continue;}
case 9178:{f.Push(f.Locals[0]);f.Pc=9179;continue;}
case 9179:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",9182);}
case 9182:{f.Pc=f.Pop().Reference==null?14247:9185;continue;}
case 9185:{f.Push(JValue.I(0));f.Pc=9186;continue;}
case 9186:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9187:{f.Push(f.Locals[1]);f.Pc=9188;continue;}
case 9188:{f.Push(JValue.R(rt.String("copiedSpell")));f.Pc=9191;continue;}
case 9191:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9194);}
case 9194:{f.Pc=f.Pop().Int==0?9206:9197;continue;}
case 9197:{f.Push(f.Locals[0]);f.Pc=9198;continue;}
case 9198:{return rt.Call(f,"forge/game/card/Card","isCopiedSpell","()Z","invokevirtual",9201);}
case 9201:{f.Pc=f.Pop().Int!=0?14247:9204;continue;}
case 9204:{f.Push(JValue.I(0));f.Pc=9205;continue;}
case 9205:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9206:{f.Push(f.Locals[1]);f.Pc=9207;continue;}
case 9207:{f.Push(JValue.R(rt.String("hasXCost")));f.Pc=9210;continue;}
case 9210:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9213);}
case 9213:{f.Pc=f.Pop().Int==0?9240:9216;continue;}
case 9216:{f.Push(f.Locals[0]);f.Pc=9217;continue;}
case 9217:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",9220);}
case 9220:{f.Locals[9]=f.Pop();f.Pc=9222;continue;}
case 9222:{f.Push(f.Locals[9]);f.Pc=9224;continue;}
case 9224:{f.Pc=f.Pop().Reference==null?9235:9227;continue;}
case 9227:{f.Push(f.Locals[9]);f.Pc=9229;continue;}
case 9229:{return rt.Call(f,"forge/card/mana/ManaCost","countX","()I","invokevirtual",9232);}
case 9232:{f.Pc=f.Pop().Int>0?9237:9235;continue;}
case 9235:{f.Push(JValue.I(0));f.Pc=9236;continue;}
case 9236:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9237:{f.Pc=14247;continue;}
case 9240:{f.Push(f.Locals[1]);f.Pc=9241;continue;}
case 9241:{f.Push(JValue.R(rt.String("suspended")));f.Pc=9244;continue;}
case 9244:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9247);}
case 9247:{f.Pc=f.Pop().Int==0?9259:9250;continue;}
case 9250:{f.Push(f.Locals[0]);f.Pc=9251;continue;}
case 9251:{return rt.Call(f,"forge/game/card/Card","hasSuspend","()Z","invokevirtual",9254);}
case 9254:{f.Pc=f.Pop().Int!=0?14247:9257;continue;}
case 9257:{f.Push(JValue.I(0));f.Pc=9258;continue;}
case 9258:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9259:{f.Push(f.Locals[1]);f.Pc=9260;continue;}
case 9260:{f.Push(JValue.R(rt.String("delved")));f.Pc=9263;continue;}
case 9263:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9266);}
case 9266:{f.Pc=f.Pop().Int==0?9284:9269;continue;}
case 9269:{f.Push(f.Locals[3]);f.Pc=9270;continue;}
case 9270:{return rt.Call(f,"forge/game/card/Card","getDelved","()Lforge/game/card/CardCollectionView;","invokevirtual",9273);}
case 9273:{f.Push(f.Locals[0]);f.Pc=9274;continue;}
case 9274:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",9279);}
case 9279:{f.Pc=f.Pop().Int!=0?14247:9282;continue;}
case 9282:{f.Push(JValue.I(0));f.Pc=9283;continue;}
case 9283:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9284:{f.Push(f.Locals[1]);f.Pc=9285;continue;}
case 9285:{f.Push(JValue.R(rt.String("convoked")));f.Pc=9288;continue;}
case 9288:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9291);}
case 9291:{f.Pc=f.Pop().Int==0?9309:9294;continue;}
case 9294:{f.Push(f.Locals[3]);f.Pc=9295;continue;}
case 9295:{return rt.Call(f,"forge/game/card/Card","getConvoked","()Lforge/game/card/CardCollectionView;","invokevirtual",9298);}
case 9298:{f.Push(f.Locals[0]);f.Pc=9299;continue;}
case 9299:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",9304);}
case 9304:{f.Pc=f.Pop().Int!=0?14247:9307;continue;}
case 9307:{f.Push(JValue.I(0));f.Pc=9308;continue;}
case 9308:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9309:{f.Push(f.Locals[1]);f.Pc=9310;continue;}
case 9310:{f.Push(JValue.R(rt.String("exploited")));f.Pc=9313;continue;}
case 9313:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9316);}
case 9316:{f.Pc=f.Pop().Int==0?9334:9319;continue;}
case 9319:{f.Push(f.Locals[3]);f.Pc=9320;continue;}
case 9320:{return rt.Call(f,"forge/game/card/Card","getExploited","()Lforge/game/card/CardCollectionView;","invokevirtual",9323);}
case 9323:{f.Push(f.Locals[0]);f.Pc=9324;continue;}
case 9324:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",9329);}
case 9329:{f.Pc=f.Pop().Int!=0?14247:9332;continue;}
case 9332:{f.Push(JValue.I(0));f.Pc=9333;continue;}
case 9333:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9334:{f.Push(f.Locals[1]);f.Pc=9335;continue;}
case 9335:{f.Push(JValue.R(rt.String("equalPT")));f.Pc=9338;continue;}
case 9338:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9341);}
case 9341:{f.Pc=f.Pop().Int==0?9357:9344;continue;}
case 9344:{f.Push(f.Locals[0]);f.Pc=9345;continue;}
case 9345:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",9348);}
case 9348:{f.Push(f.Locals[0]);f.Pc=9349;continue;}
case 9349:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",9352);}
case 9352:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?14247:9355;continue;}
case 9355:{f.Push(JValue.I(0));f.Pc=9356;continue;}
case 9356:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9357:{f.Push(f.Locals[1]);f.Pc=9358;continue;}
case 9358:{f.Push(JValue.R(rt.String("powerGTtoughness")));f.Pc=9361;continue;}
case 9361:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9364);}
case 9364:{f.Pc=f.Pop().Int==0?9380:9367;continue;}
case 9367:{f.Push(f.Locals[0]);f.Pc=9368;continue;}
case 9368:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",9371);}
case 9371:{f.Push(f.Locals[0]);f.Pc=9372;continue;}
case 9372:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",9375);}
case 9375:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?14247:9378;continue;}
case 9378:{f.Push(JValue.I(0));f.Pc=9379;continue;}
case 9379:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9380:{f.Push(f.Locals[1]);f.Pc=9381;continue;}
case 9381:{f.Push(JValue.R(rt.String("powerGTbasePower")));f.Pc=9384;continue;}
case 9384:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9387);}
case 9387:{f.Pc=f.Pop().Int==0?9403:9390;continue;}
case 9390:{f.Push(f.Locals[0]);f.Pc=9391;continue;}
case 9391:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",9394);}
case 9394:{f.Push(f.Locals[0]);f.Pc=9395;continue;}
case 9395:{return rt.Call(f,"forge/game/card/Card","getCurrentPower","()I","invokevirtual",9398);}
case 9398:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?14247:9401;continue;}
case 9401:{f.Push(JValue.I(0));f.Pc=9402;continue;}
case 9402:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9403:{f.Push(f.Locals[1]);f.Pc=9404;continue;}
case 9404:{f.Push(JValue.R(rt.String("powerNOTbasePower")));f.Pc=9407;continue;}
case 9407:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9410);}
case 9410:{f.Pc=f.Pop().Int==0?9426:9413;continue;}
case 9413:{f.Push(f.Locals[0]);f.Pc=9414;continue;}
case 9414:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",9417);}
case 9417:{f.Push(f.Locals[0]);f.Pc=9418;continue;}
case 9418:{return rt.Call(f,"forge/game/card/Card","getCurrentPower","()I","invokevirtual",9421);}
case 9421:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?14247:9424;continue;}
case 9424:{f.Push(JValue.I(0));f.Pc=9425;continue;}
case 9425:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9426:{f.Push(f.Locals[1]);f.Pc=9427;continue;}
case 9427:{f.Push(JValue.R(rt.String("powerLTtoughness")));f.Pc=9430;continue;}
case 9430:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9433);}
case 9433:{f.Pc=f.Pop().Int==0?9449:9436;continue;}
case 9436:{f.Push(f.Locals[0]);f.Pc=9437;continue;}
case 9437:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",9440);}
case 9440:{f.Push(f.Locals[0]);f.Pc=9441;continue;}
case 9441:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",9444);}
case 9444:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?14247:9447;continue;}
case 9447:{f.Push(JValue.I(0));f.Pc=9448;continue;}
case 9448:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9449:{f.Push(f.Locals[1]);f.Pc=9450;continue;}
case 9450:{f.Push(JValue.R(rt.String("cmcEven")));f.Pc=9453;continue;}
case 9453:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9456);}
case 9456:{f.Pc=f.Pop().Int==0?9470:9459;continue;}
case 9459:{f.Push(f.Locals[0]);f.Pc=9460;continue;}
case 9460:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",9463);}
case 9463:{f.Push(JValue.I(2));f.Pc=9464;continue;}
case 9464:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=9465;continue;}
case 9465:{f.Pc=f.Pop().Int==0?14247:9468;continue;}
case 9468:{f.Push(JValue.I(0));f.Pc=9469;continue;}
case 9469:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9470:{f.Push(f.Locals[1]);f.Pc=9471;continue;}
case 9471:{f.Push(JValue.R(rt.String("cmcOdd")));f.Pc=9474;continue;}
case 9474:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9477);}
case 9477:{f.Pc=f.Pop().Int==0?9492:9480;continue;}
case 9480:{f.Push(f.Locals[0]);f.Pc=9481;continue;}
case 9481:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",9484);}
case 9484:{f.Push(JValue.I(2));f.Pc=9485;continue;}
case 9485:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=9486;continue;}
case 9486:{f.Push(JValue.I(1));f.Pc=9487;continue;}
case 9487:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?14247:9490;continue;}
case 9490:{f.Push(JValue.I(0));f.Pc=9491;continue;}
case 9491:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9492:{f.Push(f.Locals[1]);f.Pc=9493;continue;}
case 9493:{f.Push(JValue.R(rt.String("powerEven")));f.Pc=9496;continue;}
case 9496:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9499);}
case 9499:{f.Pc=f.Pop().Int==0?9513:9502;continue;}
case 9502:{f.Push(f.Locals[0]);f.Pc=9503;continue;}
case 9503:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",9506);}
case 9506:{f.Push(JValue.I(2));f.Pc=9507;continue;}
case 9507:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=9508;continue;}
case 9508:{f.Pc=f.Pop().Int==0?14247:9511;continue;}
case 9511:{f.Push(JValue.I(0));f.Pc=9512;continue;}
case 9512:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9513:{f.Push(f.Locals[1]);f.Pc=9514;continue;}
case 9514:{f.Push(JValue.R(rt.String("powerOdd")));f.Pc=9517;continue;}
case 9517:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9520);}
case 9520:{f.Pc=f.Pop().Int==0?9535:9523;continue;}
case 9523:{f.Push(f.Locals[0]);f.Pc=9524;continue;}
case 9524:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",9527);}
case 9527:{f.Push(JValue.I(2));f.Pc=9528;continue;}
case 9528:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=9529;continue;}
case 9529:{f.Push(JValue.I(1));f.Pc=9530;continue;}
case 9530:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?14247:9533;continue;}
case 9533:{f.Push(JValue.I(0));f.Pc=9534;continue;}
case 9534:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9535:{f.Push(f.Locals[1]);f.Pc=9536;continue;}
case 9536:{f.Push(JValue.R(rt.String("cmcChosenEvenOdd")));f.Pc=9539;continue;}
case 9539:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9542);}
case 9542:{f.Pc=f.Pop().Int==0?9588:9545;continue;}
case 9545:{f.Push(f.Locals[3]);f.Pc=9546;continue;}
case 9546:{return rt.Call(f,"forge/game/card/Card","hasChosenEvenOdd","()Z","invokevirtual",9549);}
case 9549:{f.Pc=f.Pop().Int!=0?9554:9552;continue;}
case 9552:{f.Push(JValue.I(0));f.Pc=9553;continue;}
case 9553:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9554:{f.Push(f.Locals[0]);f.Pc=9555;continue;}
case 9555:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",9558);}
case 9558:{f.Push(JValue.I(2));f.Pc=9559;continue;}
case 9559:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=9560;continue;}
case 9560:{f.Pc=f.Pop().Int!=0?9567:9563;continue;}
case 9563:{f.Push(JValue.I(1));f.Pc=9564;continue;}
case 9564:{f.Pc=9568;continue;}
case 9567:{f.Push(JValue.I(0));f.Pc=9568;continue;}
case 9568:{f.Push(f.Locals[3]);f.Pc=9569;continue;}
case 9569:{return rt.Call(f,"forge/game/card/Card","getChosenEvenOdd","()Lforge/game/EvenOdd;","invokevirtual",9572);}
case 9572:{if(!rt.StaticReady(f,"forge/game/EvenOdd","Even","Lforge/game/EvenOdd;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/EvenOdd","Even","Lforge/game/EvenOdd;"));f.Pc=9575;continue;}
case 9575:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?9582:9578;continue;}
case 9578:{f.Push(JValue.I(1));f.Pc=9579;continue;}
case 9579:{f.Pc=9583;continue;}
case 9582:{f.Push(JValue.I(0));f.Pc=9583;continue;}
case 9583:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?14247:9586;continue;}
case 9586:{f.Push(JValue.I(0));f.Pc=9587;continue;}
case 9587:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9588:{f.Push(f.Locals[1]);f.Pc=9589;continue;}
case 9589:{f.Push(JValue.R(rt.String("cmcNotChosenEvenOdd")));f.Pc=9592;continue;}
case 9592:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9595);}
case 9595:{f.Pc=f.Pop().Int==0?9641:9598;continue;}
case 9598:{f.Push(f.Locals[3]);f.Pc=9599;continue;}
case 9599:{return rt.Call(f,"forge/game/card/Card","hasChosenEvenOdd","()Z","invokevirtual",9602);}
case 9602:{f.Pc=f.Pop().Int!=0?9607:9605;continue;}
case 9605:{f.Push(JValue.I(0));f.Pc=9606;continue;}
case 9606:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9607:{f.Push(f.Locals[0]);f.Pc=9608;continue;}
case 9608:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",9611);}
case 9611:{f.Push(JValue.I(2));f.Pc=9612;continue;}
case 9612:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=9613;continue;}
case 9613:{f.Pc=f.Pop().Int!=0?9620:9616;continue;}
case 9616:{f.Push(JValue.I(1));f.Pc=9617;continue;}
case 9617:{f.Pc=9621;continue;}
case 9620:{f.Push(JValue.I(0));f.Pc=9621;continue;}
case 9621:{f.Push(f.Locals[3]);f.Pc=9622;continue;}
case 9622:{return rt.Call(f,"forge/game/card/Card","getChosenEvenOdd","()Lforge/game/EvenOdd;","invokevirtual",9625);}
case 9625:{if(!rt.StaticReady(f,"forge/game/EvenOdd","Even","Lforge/game/EvenOdd;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/EvenOdd","Even","Lforge/game/EvenOdd;"));f.Pc=9628;continue;}
case 9628:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?9635:9631;continue;}
case 9631:{f.Push(JValue.I(1));f.Pc=9632;continue;}
case 9632:{f.Pc=9636;continue;}
case 9635:{f.Push(JValue.I(0));f.Pc=9636;continue;}
case 9636:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?14247:9639;continue;}
case 9639:{f.Push(JValue.I(0));f.Pc=9640;continue;}
case 9640:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9641:{f.Push(f.Locals[1]);f.Pc=9642;continue;}
case 9642:{f.Push(JValue.R(rt.String("power")));f.Pc=9645;continue;}
case 9645:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9648);}
case 9648:{f.Pc=f.Pop().Int!=0?9741:9651;continue;}
case 9651:{f.Push(f.Locals[1]);f.Pc=9652;continue;}
case 9652:{f.Push(JValue.R(rt.String("toughness")));f.Pc=9655;continue;}
case 9655:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9658);}
case 9658:{f.Pc=f.Pop().Int!=0?9741:9661;continue;}
case 9661:{f.Push(f.Locals[1]);f.Pc=9662;continue;}
case 9662:{f.Push(JValue.R(rt.String("cmc")));f.Pc=9665;continue;}
case 9665:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9668);}
case 9668:{f.Pc=f.Pop().Int!=0?9741:9671;continue;}
case 9671:{f.Push(f.Locals[1]);f.Pc=9672;continue;}
case 9672:{f.Push(JValue.R(rt.String("totalPT")));f.Pc=9675;continue;}
case 9675:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9678);}
case 9678:{f.Pc=f.Pop().Int!=0?9741:9681;continue;}
case 9681:{f.Push(f.Locals[1]);f.Pc=9682;continue;}
case 9682:{f.Push(JValue.R(rt.String("numColors")));f.Pc=9685;continue;}
case 9685:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9688);}
case 9688:{f.Pc=f.Pop().Int!=0?9741:9691;continue;}
case 9691:{f.Push(f.Locals[1]);f.Pc=9692;continue;}
case 9692:{f.Push(JValue.R(rt.String("basePower")));f.Pc=9695;continue;}
case 9695:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9698);}
case 9698:{f.Pc=f.Pop().Int!=0?9741:9701;continue;}
case 9701:{f.Push(f.Locals[1]);f.Pc=9702;continue;}
case 9702:{f.Push(JValue.R(rt.String("baseToughness")));f.Pc=9705;continue;}
case 9705:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9708);}
case 9708:{f.Pc=f.Pop().Int!=0?9741:9711;continue;}
case 9711:{f.Push(f.Locals[1]);f.Pc=9712;continue;}
case 9712:{f.Push(JValue.R(rt.String("numTypes")));f.Pc=9715;continue;}
case 9715:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9718);}
case 9718:{f.Pc=f.Pop().Int!=0?9741:9721;continue;}
case 9721:{f.Push(f.Locals[1]);f.Pc=9722;continue;}
case 9722:{f.Push(JValue.R(rt.String("numCreatureTypes")));f.Pc=9725;continue;}
case 9725:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9728);}
case 9728:{f.Pc=f.Pop().Int!=0?9741:9731;continue;}
case 9731:{f.Push(f.Locals[1]);f.Pc=9732;continue;}
case 9732:{f.Push(JValue.R(rt.String("baseLoyalty")));f.Pc=9735;continue;}
case 9735:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9738);}
case 9738:{f.Pc=f.Pop().Int==0?10107:9741;continue;}
case 9741:{f.Push(JValue.I(0));f.Pc=9742;continue;}
case 9742:{f.Locals[10]=f.Pop();f.Pc=9744;continue;}
case 9744:{f.Push(JValue.R(rt.String("")));f.Pc=9747;continue;}
case 9747:{f.Locals[11]=f.Pop();f.Pc=9749;continue;}
case 9749:{f.Push(f.Locals[1]);f.Pc=9750;continue;}
case 9750:{f.Push(JValue.R(rt.String("power")));f.Pc=9753;continue;}
case 9753:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9756);}
case 9756:{f.Pc=f.Pop().Int==0?9776:9759;continue;}
case 9759:{f.Push(f.Locals[1]);f.Pc=9760;continue;}
case 9760:{f.Push(JValue.I(7));f.Pc=9762;continue;}
case 9762:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",9765);}
case 9765:{f.Locals[11]=f.Pop();f.Pc=9767;continue;}
case 9767:{f.Push(f.Locals[0]);f.Pc=9768;continue;}
case 9768:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",9771);}
case 9771:{f.Locals[10]=f.Pop();f.Pc=9773;continue;}
case 9773:{f.Pc=10049;continue;}
case 9776:{f.Push(f.Locals[1]);f.Pc=9777;continue;}
case 9777:{f.Push(JValue.R(rt.String("basePower")));f.Pc=9780;continue;}
case 9780:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9783);}
case 9783:{f.Pc=f.Pop().Int==0?9803:9786;continue;}
case 9786:{f.Push(f.Locals[1]);f.Pc=9787;continue;}
case 9787:{f.Push(JValue.I(11));f.Pc=9789;continue;}
case 9789:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",9792);}
case 9792:{f.Locals[11]=f.Pop();f.Pc=9794;continue;}
case 9794:{f.Push(f.Locals[0]);f.Pc=9795;continue;}
case 9795:{return rt.Call(f,"forge/game/card/Card","getCurrentPower","()I","invokevirtual",9798);}
case 9798:{f.Locals[10]=f.Pop();f.Pc=9800;continue;}
case 9800:{f.Pc=10049;continue;}
case 9803:{f.Push(f.Locals[1]);f.Pc=9804;continue;}
case 9804:{f.Push(JValue.R(rt.String("toughness")));f.Pc=9807;continue;}
case 9807:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9810);}
case 9810:{f.Pc=f.Pop().Int==0?9830:9813;continue;}
case 9813:{f.Push(f.Locals[1]);f.Pc=9814;continue;}
case 9814:{f.Push(JValue.I(11));f.Pc=9816;continue;}
case 9816:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",9819);}
case 9819:{f.Locals[11]=f.Pop();f.Pc=9821;continue;}
case 9821:{f.Push(f.Locals[0]);f.Pc=9822;continue;}
case 9822:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",9825);}
case 9825:{f.Locals[10]=f.Pop();f.Pc=9827;continue;}
case 9827:{f.Pc=10049;continue;}
case 9830:{f.Push(f.Locals[1]);f.Pc=9831;continue;}
case 9831:{f.Push(JValue.R(rt.String("baseToughness")));f.Pc=9834;continue;}
case 9834:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9837);}
case 9837:{f.Pc=f.Pop().Int==0?9857:9840;continue;}
case 9840:{f.Push(f.Locals[1]);f.Pc=9841;continue;}
case 9841:{f.Push(JValue.I(15));f.Pc=9843;continue;}
case 9843:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",9846);}
case 9846:{f.Locals[11]=f.Pop();f.Pc=9848;continue;}
case 9848:{f.Push(f.Locals[0]);f.Pc=9849;continue;}
case 9849:{return rt.Call(f,"forge/game/card/Card","getCurrentToughness","()I","invokevirtual",9852);}
case 9852:{f.Locals[10]=f.Pop();f.Pc=9854;continue;}
case 9854:{f.Pc=10049;continue;}
case 9857:{f.Push(f.Locals[1]);f.Pc=9858;continue;}
case 9858:{f.Push(JValue.R(rt.String("cmc")));f.Pc=9861;continue;}
case 9861:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9864);}
case 9864:{f.Pc=f.Pop().Int==0?9883:9867;continue;}
case 9867:{f.Push(f.Locals[1]);f.Pc=9868;continue;}
case 9868:{f.Push(JValue.I(5));f.Pc=9869;continue;}
case 9869:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",9872);}
case 9872:{f.Locals[11]=f.Pop();f.Pc=9874;continue;}
case 9874:{f.Push(f.Locals[0]);f.Pc=9875;continue;}
case 9875:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",9878);}
case 9878:{f.Locals[10]=f.Pop();f.Pc=9880;continue;}
case 9880:{f.Pc=10049;continue;}
case 9883:{f.Push(f.Locals[1]);f.Pc=9884;continue;}
case 9884:{f.Push(JValue.R(rt.String("totalPT")));f.Pc=9887;continue;}
case 9887:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9890);}
case 9890:{f.Pc=f.Pop().Int==0?9915:9893;continue;}
case 9893:{f.Push(f.Locals[1]);f.Pc=9894;continue;}
case 9894:{f.Push(JValue.I(10));f.Pc=9896;continue;}
case 9896:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",9899);}
case 9899:{f.Locals[11]=f.Pop();f.Pc=9901;continue;}
case 9901:{f.Push(f.Locals[0]);f.Pc=9902;continue;}
case 9902:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",9905);}
case 9905:{f.Push(f.Locals[0]);f.Pc=9906;continue;}
case 9906:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",9909);}
case 9909:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=9910;continue;}
case 9910:{f.Locals[10]=f.Pop();f.Pc=9912;continue;}
case 9912:{f.Pc=10049;continue;}
case 9915:{f.Push(f.Locals[1]);f.Pc=9916;continue;}
case 9916:{f.Push(JValue.R(rt.String("numColors")));f.Pc=9919;continue;}
case 9919:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9922);}
case 9922:{f.Pc=f.Pop().Int==0?9945:9925;continue;}
case 9925:{f.Push(f.Locals[1]);f.Pc=9926;continue;}
case 9926:{f.Push(JValue.I(11));f.Pc=9928;continue;}
case 9928:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",9931);}
case 9931:{f.Locals[11]=f.Pop();f.Pc=9933;continue;}
case 9933:{f.Push(f.Locals[0]);f.Pc=9934;continue;}
case 9934:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",9937);}
case 9937:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",9940);}
case 9940:{f.Locals[10]=f.Pop();f.Pc=9942;continue;}
case 9942:{f.Pc=10049;continue;}
case 9945:{f.Push(f.Locals[1]);f.Pc=9946;continue;}
case 9946:{f.Push(JValue.R(rt.String("numTypes")));f.Pc=9949;continue;}
case 9949:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9952);}
case 9952:{f.Pc=f.Pop().Int==0?9980:9955;continue;}
case 9955:{f.Push(f.Locals[1]);f.Pc=9956;continue;}
case 9956:{f.Push(JValue.I(10));f.Pc=9958;continue;}
case 9958:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",9961);}
case 9961:{f.Locals[11]=f.Pop();f.Pc=9963;continue;}
case 9963:{f.Push(f.Locals[0]);f.Pc=9964;continue;}
case 9964:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",9967);}
case 9967:{return rt.Call(f,"forge/card/CardTypeView","getCoreTypes","()Ljava/util/Collection;","invokeinterface",9972);}
case 9972:{return rt.Call(f,"com/google/common/collect/Iterables","size","(Ljava/lang/Iterable;)I","invokestatic",9975);}
case 9975:{f.Locals[10]=f.Pop();f.Pc=9977;continue;}
case 9977:{f.Pc=10049;continue;}
case 9980:{f.Push(f.Locals[1]);f.Pc=9981;continue;}
case 9981:{f.Push(JValue.R(rt.String("numCreatureTypes")));f.Pc=9984;continue;}
case 9984:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9987);}
case 9987:{f.Pc=f.Pop().Int==0?10017:9990;continue;}
case 9990:{f.Push(f.Locals[1]);f.Pc=9991;continue;}
case 9991:{f.Push(JValue.I(18));f.Pc=9993;continue;}
case 9993:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",9996);}
case 9996:{f.Locals[11]=f.Pop();f.Pc=9998;continue;}
case 9998:{f.Push(f.Locals[0]);f.Pc=9999;continue;}
case 9999:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",10002);}
case 10002:{return rt.Call(f,"forge/card/CardTypeView","getCreatureTypes","()Ljava/util/Set;","invokeinterface",10007);}
case 10007:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",10012);}
case 10012:{f.Locals[10]=f.Pop();f.Pc=10014;continue;}
case 10014:{f.Pc=10049;continue;}
case 10017:{f.Push(f.Locals[1]);f.Pc=10018;continue;}
case 10018:{f.Push(JValue.R(rt.String("baseLoyalty")));f.Pc=10021;continue;}
case 10021:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10024);}
case 10024:{f.Pc=f.Pop().Int==0?10049:10027;continue;}
case 10027:{f.Push(f.Locals[1]);f.Pc=10028;continue;}
case 10028:{f.Push(JValue.I(13));f.Pc=10030;continue;}
case 10030:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",10033);}
case 10033:{f.Locals[11]=f.Pop();f.Pc=10035;continue;}
case 10035:{f.Push(f.Locals[0]);f.Pc=10036;continue;}
case 10036:{f.Push(f.Locals[0]);f.Pc=10037;continue;}
case 10037:{return rt.Call(f,"forge/game/card/Card","getBaseLoyalty","()Ljava/lang/String;","invokevirtual",10040);}
case 10040:{f.Push(f.Locals[0]);f.Pc=10041;continue;}
case 10041:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",10044);}
case 10044:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",10047);}
case 10047:{f.Locals[10]=f.Pop();f.Pc=10049;continue;}
case 10049:{f.Push(f.Locals[11]);f.Pc=10051;continue;}
case 10051:{f.Push(JValue.R(rt.String("Chosen")));f.Pc=10054;continue;}
case 10054:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10057);}
case 10057:{f.Pc=f.Pop().Int==0?10081:10060;continue;}
case 10060:{f.Push(f.Locals[3]);f.Pc=10061;continue;}
case 10061:{return rt.Call(f,"forge/game/card/Card","hasChosenNumber","()Z","invokevirtual",10064);}
case 10064:{f.Pc=f.Pop().Int!=0?10069:10067;continue;}
case 10067:{f.Push(JValue.I(0));f.Pc=10068;continue;}
case 10068:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10069:{f.Push(f.Locals[3]);f.Pc=10070;continue;}
case 10070:{return rt.Call(f,"forge/game/card/Card","getChosenNumber","()Ljava/lang/Integer;","invokevirtual",10073);}
case 10073:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",10076);}
case 10076:{f.Locals[9]=f.Pop();f.Pc=10078;continue;}
case 10078:{f.Pc=10091;continue;}
case 10081:{f.Push(f.Locals[3]);f.Pc=10082;continue;}
case 10082:{f.Push(f.Locals[11]);f.Pc=10084;continue;}
case 10084:{f.Push(f.Locals[4]);f.Pc=10086;continue;}
case 10086:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",10089);}
case 10089:{f.Locals[9]=f.Pop();f.Pc=10091;continue;}
case 10091:{f.Push(f.Locals[10]);f.Pc=10093;continue;}
case 10093:{f.Push(f.Locals[1]);f.Pc=10094;continue;}
case 10094:{f.Push(f.Locals[9]);f.Pc=10096;continue;}
case 10096:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",10099);}
case 10099:{f.Pc=f.Pop().Int!=0?10104:10102;continue;}
case 10102:{f.Push(JValue.I(0));f.Pc=10103;continue;}
case 10103:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10104:{f.Pc=14247;continue;}
case 10107:{f.Push(f.Locals[1]);f.Pc=10108;continue;}
case 10108:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=10111;continue;}
case 10111:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10114);}
case 10114:{f.Pc=f.Pop().Int==0?10175:10117;continue;}
case 10117:{f.Push(f.Locals[0]);f.Pc=10118;continue;}
case 10118:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",10121);}
case 10121:{return rt.Call(f,"forge/card/mana/ManaCost","getShortString","()Ljava/lang/String;","invokevirtual",10124);}
case 10124:{f.Locals[9]=f.Pop();f.Pc=10126;continue;}
case 10126:{f.Push(f.Locals[1]);f.Pc=10127;continue;}
case 10127:{f.Push(JValue.R(rt.String("Partial")));f.Pc=10130;continue;}
case 10130:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",10133);}
case 10133:{f.Pc=f.Pop().Int==0?10156:10136;continue;}
case 10136:{f.Push(f.Locals[9]);f.Pc=10138;continue;}
case 10138:{f.Push(f.Locals[1]);f.Pc=10139;continue;}
case 10139:{f.Push(JValue.I(15));f.Pc=10141;continue;}
case 10141:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",10144);}
case 10144:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",10147);}
case 10147:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",10150);}
case 10150:{f.Pc=f.Pop().Int!=0?10172:10153;continue;}
case 10153:{f.Pc=10170;continue;}
case 10156:{f.Push(f.Locals[9]);f.Pc=10158;continue;}
case 10158:{f.Push(f.Locals[1]);f.Pc=10159;continue;}
case 10159:{f.Push(JValue.I(8));f.Pc=10161;continue;}
case 10161:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",10164);}
case 10164:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10167);}
case 10167:{f.Pc=f.Pop().Int!=0?10172:10170;continue;}
case 10170:{f.Push(JValue.I(0));f.Pc=10171;continue;}
case 10171:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10172:{f.Pc=14247;continue;}
case 10175:{f.Push(f.Locals[1]);f.Pc=10176;continue;}
case 10176:{f.Push(JValue.R(rt.String("HasCounters")));f.Pc=10179;continue;}
case 10179:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10182);}
case 10182:{f.Pc=f.Pop().Int==0?10194:10185;continue;}
case 10185:{f.Push(f.Locals[0]);f.Pc=10186;continue;}
case 10186:{return rt.Call(f,"forge/game/card/Card","hasCounters","()Z","invokevirtual",10189);}
case 10189:{f.Pc=f.Pop().Int!=0?14247:10192;continue;}
case 10192:{f.Push(JValue.I(0));f.Pc=10193;continue;}
case 10193:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10194:{f.Push(f.Locals[1]);f.Pc=10195;continue;}
case 10195:{f.Push(JValue.R(rt.String("counters")));f.Pc=10198;continue;}
case 10198:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10201);}
case 10201:{f.Pc=f.Pop().Int==0?10314:10204;continue;}
case 10204:{f.Push(f.Locals[1]);f.Pc=10205;continue;}
case 10205:{f.Push(JValue.R(rt.String("_")));f.Pc=10207;continue;}
case 10207:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",10210);}
case 10210:{f.Locals[9]=f.Pop();f.Pc=10212;continue;}
case 10212:{f.Push(f.Locals[9]);f.Pc=10214;continue;}
case 10214:{f.Push(JValue.I(1));f.Pc=10215;continue;}
case 10215:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=10216;continue;}
case 10216:{f.Push(JValue.I(2));f.Pc=10217;continue;}
case 10217:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",10220);}
case 10220:{f.Locals[10]=f.Pop();f.Pc=10222;continue;}
case 10222:{f.Push(f.Locals[9]);f.Pc=10224;continue;}
case 10224:{f.Push(JValue.I(1));f.Pc=10225;continue;}
case 10225:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=10226;continue;}
case 10226:{f.Push(JValue.I(0));f.Pc=10227;continue;}
case 10227:{f.Push(JValue.I(2));f.Pc=10228;continue;}
case 10228:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",10231);}
case 10231:{f.Locals[11]=f.Pop();f.Pc=10233;continue;}
case 10233:{f.Push(f.Locals[9]);f.Pc=10235;continue;}
case 10235:{f.Push(JValue.I(2));f.Pc=10236;continue;}
case 10236:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=10237;continue;}
case 10237:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",10240);}
case 10240:{f.Locals[12]=f.Pop();f.Pc=10242;continue;}
case 10242:{f.Push(f.Locals[3]);f.Pc=10243;continue;}
case 10243:{f.Push(f.Locals[10]);f.Pc=10245;continue;}
case 10245:{f.Push(f.Locals[4]);f.Pc=10247;continue;}
case 10247:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",10250);}
case 10250:{f.Locals[13]=f.Pop();f.Pc=10252;continue;}
case 10252:{f.Push(f.Locals[9]);f.Pc=10254;continue;}
case 10254:{f.Push(JValue.I(0));f.Pc=10255;continue;}
case 10255:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=10256;continue;}
case 10256:{f.Push(JValue.R(rt.String("ReceivedThisTurn")));f.Pc=10259;continue;}
case 10259:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",10262);}
case 10262:{f.Pc=f.Pop().Int==0?10289:10265;continue;}
case 10265:{f.Push(f.Locals[5]);f.Pc=10267;continue;}
case 10267:{f.Push(f.Locals[12]);f.Pc=10269;continue;}
case 10269:{f.Push(f.Locals[9]);f.Pc=10271;continue;}
case 10271:{f.Push(JValue.I(3));f.Pc=10272;continue;}
case 10272:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=10273;continue;}
case 10273:{f.Push(JValue.R(rt.String("Card.StrictlySelf")));f.Pc=10276;continue;}
case 10276:{f.Push(f.Locals[0]);f.Pc=10277;continue;}
case 10277:{f.Push(f.Locals[8]);f.Pc=10279;continue;}
case 10279:{f.Push(f.Locals[4]);f.Pc=10281;continue;}
case 10281:{return rt.Call(f,"forge/game/Game","getCounterAddedThisTurn","(Lforge/game/card/CounterType;Ljava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/CardTraitBase;)I","invokevirtual",10284);}
case 10284:{f.Locals[14]=f.Pop();f.Pc=10286;continue;}
case 10286:{f.Pc=10297;continue;}
case 10289:{f.Push(f.Locals[0]);f.Pc=10290;continue;}
case 10290:{f.Push(f.Locals[12]);f.Pc=10292;continue;}
case 10292:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",10295);}
case 10295:{f.Locals[14]=f.Pop();f.Pc=10297;continue;}
case 10297:{f.Push(f.Locals[14]);f.Pc=10299;continue;}
case 10299:{f.Push(f.Locals[11]);f.Pc=10301;continue;}
case 10301:{f.Push(f.Locals[13]);f.Pc=10303;continue;}
case 10303:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",10306);}
case 10306:{f.Pc=f.Pop().Int!=0?10311:10309;continue;}
case 10309:{f.Push(JValue.I(0));f.Pc=10310;continue;}
case 10310:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10311:{f.Pc=14247;continue;}
case 10314:{f.Push(f.Locals[1]);f.Pc=10315;continue;}
case 10315:{f.Push(JValue.R(rt.String("attacking")));f.Pc=10318;continue;}
case 10318:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10321);}
case 10321:{f.Pc=f.Pop().Int==0?10603:10324;continue;}
case 10324:{f.Push(JValue.R(null));f.Pc=10325;continue;}
case 10325:{f.Push(f.Locals[6]);f.Pc=10327;continue;}
case 10327:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?10332:10330;continue;}
case 10330:{f.Push(JValue.I(0));f.Pc=10331;continue;}
case 10331:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10332:{f.Push(f.Locals[1]);f.Pc=10333;continue;}
case 10333:{f.Push(JValue.R(rt.String("LKI")));f.Pc=10336;continue;}
case 10336:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",10339);}
case 10339:{f.Pc=f.Pop().Int==0?10347:10342;continue;}
case 10342:{f.Push(f.Locals[7]);f.Pc=10344;continue;}
case 10344:{f.Pc=10348;continue;}
case 10347:{f.Push(f.Locals[0]);f.Pc=10348;continue;}
case 10348:{return rt.Call(f,"forge/game/card/Card","isAttacking","()Z","invokevirtual",10351);}
case 10351:{f.Pc=f.Pop().Int!=0?10356:10354;continue;}
case 10354:{f.Push(JValue.I(0));f.Pc=10355;continue;}
case 10355:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10356:{f.Push(f.Locals[1]);f.Pc=10357;continue;}
case 10357:{f.Push(JValue.R(rt.String("attacking")));f.Pc=10360;continue;}
case 10360:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10363);}
case 10363:{f.Pc=f.Pop().Int==0?10368:10366;continue;}
case 10366:{f.Push(JValue.I(1));f.Pc=10367;continue;}
case 10367:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10368:{f.Push(f.Locals[1]);f.Pc=10369;continue;}
case 10369:{f.Push(JValue.R(rt.String("Alone")));f.Pc=10372;continue;}
case 10372:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",10375);}
case 10375:{f.Pc=f.Pop().Int==0?10403:10378;continue;}
case 10378:{f.Push(f.Locals[0]);f.Pc=10379;continue;}
case 10379:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",10382);}
case 10382:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",10385);}
case 10385:{return rt.DynamicCall(f,"forge/game/card/CardProperty:5251:10385:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",10390);}
case 10390:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",10393);}
case 10393:{f.Push(JValue.I(1));f.Pc=10394;continue;}
case 10394:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?10401:10397;continue;}
case 10397:{f.Push(JValue.I(1));f.Pc=10398;continue;}
case 10398:{f.Pc=10402;continue;}
case 10401:{f.Push(JValue.I(0));f.Pc=10402;continue;}
case 10402:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10403:{f.Push(f.Locals[1]);f.Pc=10404;continue;}
case 10404:{f.Push(JValue.R(rt.String("attackingYou")));f.Pc=10407;continue;}
case 10407:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10410);}
case 10410:{f.Pc=f.Pop().Int==0?10421:10413;continue;}
case 10413:{f.Push(f.Locals[6]);f.Pc=10415;continue;}
case 10415:{f.Push(f.Locals[0]);f.Pc=10416;continue;}
case 10416:{f.Push(f.Locals[2]);f.Pc=10417;continue;}
case 10417:{return rt.Call(f,"forge/game/combat/Combat","isAttacking","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z","invokevirtual",10420);}
case 10420:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10421:{f.Push(f.Locals[1]);f.Pc=10422;continue;}
case 10422:{f.Push(JValue.R(rt.String("attackingSame")));f.Pc=10425;continue;}
case 10425:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10428);}
case 10428:{f.Pc=f.Pop().Int==0?10452:10431;continue;}
case 10431:{f.Push(f.Locals[6]);f.Pc=10433;continue;}
case 10433:{f.Push(f.Locals[3]);f.Pc=10434;continue;}
case 10434:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",10437);}
case 10437:{f.Locals[9]=f.Pop();f.Pc=10439;continue;}
case 10439:{f.Push(f.Locals[6]);f.Pc=10441;continue;}
case 10441:{f.Push(f.Locals[0]);f.Pc=10442;continue;}
case 10442:{f.Push(f.Locals[9]);f.Pc=10444;continue;}
case 10444:{return rt.Call(f,"forge/game/combat/Combat","isAttacking","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z","invokevirtual",10447);}
case 10447:{f.Pc=f.Pop().Int!=0?10452:10450;continue;}
case 10450:{f.Push(JValue.I(0));f.Pc=10451;continue;}
case 10451:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10452:{f.Push(f.Locals[1]);f.Pc=10453;continue;}
case 10453:{f.Push(JValue.R(rt.String("attackingBattle")));f.Pc=10456;continue;}
case 10456:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10459);}
case 10459:{f.Pc=f.Pop().Int==0?10493:10462;continue;}
case 10462:{f.Push(f.Locals[6]);f.Pc=10464;continue;}
case 10464:{f.Push(f.Locals[0]);f.Pc=10465;continue;}
case 10465:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",10468);}
case 10468:{f.Locals[9]=f.Pop();f.Pc=10470;continue;}
case 10470:{f.Push(f.Locals[9]);f.Pc=10472;continue;}
case 10472:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=10475;continue;}
case 10475:{f.Pc=f.Pop().Int!=0?10480:10478;continue;}
case 10478:{f.Push(JValue.I(0));f.Pc=10479;continue;}
case 10479:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10480:{f.Push(f.Locals[9]);f.Pc=10482;continue;}
case 10482:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10485;continue;}
case 10485:{return rt.Call(f,"forge/game/card/Card","isBattle","()Z","invokevirtual",10488);}
case 10488:{f.Pc=f.Pop().Int!=0?10493:10491;continue;}
case 10491:{f.Push(JValue.I(0));f.Pc=10492;continue;}
case 10492:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10493:{f.Push(f.Locals[1]);f.Pc=10494;continue;}
case 10494:{f.Push(JValue.R(rt.String("attackingYouOrYourPW")));f.Pc=10497;continue;}
case 10497:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10500);}
case 10500:{f.Pc=f.Pop().Int==0?10553:10503;continue;}
case 10503:{f.Push(f.Locals[6]);f.Pc=10505;continue;}
case 10505:{f.Push(f.Locals[0]);f.Pc=10506;continue;}
case 10506:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",10509);}
case 10509:{f.Locals[9]=f.Pop();f.Pc=10511;continue;}
case 10511:{f.Push(f.Locals[9]);f.Pc=10513;continue;}
case 10513:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=10516;continue;}
case 10516:{f.Pc=f.Pop().Int==0?10542:10519;continue;}
case 10519:{f.Push(f.Locals[9]);f.Pc=10521;continue;}
case 10521:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10524;continue;}
case 10524:{return rt.Call(f,"forge/game/card/Card","isPlaneswalker","()Z","invokevirtual",10527);}
case 10527:{f.Pc=f.Pop().Int!=0?10532:10530;continue;}
case 10530:{f.Push(JValue.I(0));f.Pc=10531;continue;}
case 10531:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10532:{f.Push(f.Locals[9]);f.Pc=10534;continue;}
case 10534:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10537;continue;}
case 10537:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",10540);}
case 10540:{f.Locals[9]=f.Pop();f.Pc=10542;continue;}
case 10542:{f.Push(f.Locals[2]);f.Pc=10543;continue;}
case 10543:{f.Push(f.Locals[9]);f.Pc=10545;continue;}
case 10545:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",10548);}
case 10548:{f.Pc=f.Pop().Int!=0?10553:10551;continue;}
case 10551:{f.Push(JValue.I(0));f.Pc=10552;continue;}
case 10552:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10553:{f.Push(f.Locals[1]);f.Pc=10554;continue;}
case 10554:{f.Push(JValue.R(rt.String("attacking ")));f.Pc=10557;continue;}
case 10557:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10560);}
case 10560:{f.Pc=f.Pop().Int==0?14247:10563;continue;}
case 10563:{f.Push(f.Locals[3]);f.Pc=10564;continue;}
case 10564:{f.Push(f.Locals[1]);f.Pc=10565;continue;}
case 10565:{f.Push(JValue.R(rt.String(" ")));f.Pc=10567;continue;}
case 10567:{f.Push(JValue.I(2));f.Pc=10568;continue;}
case 10568:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",10571);}
case 10571:{f.Push(JValue.I(1));f.Pc=10572;continue;}
case 10572:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=10573;continue;}
case 10573:{f.Push(f.Locals[4]);f.Pc=10575;continue;}
case 10575:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",10578);}
case 10578:{f.Locals[9]=f.Pop();f.Pc=10580;continue;}
case 10580:{f.Push(f.Locals[6]);f.Pc=10582;continue;}
case 10582:{f.Push(f.Locals[0]);f.Pc=10583;continue;}
case 10583:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",10586);}
case 10586:{f.Locals[10]=f.Pop();f.Pc=10588;continue;}
case 10588:{f.Push(f.Locals[9]);f.Pc=10590;continue;}
case 10590:{f.Push(f.Locals[10]);f.Pc=10592;continue;}
case 10592:{return rt.Call(f,"forge/util/collect/FCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",10595);}
case 10595:{f.Pc=f.Pop().Int!=0?10600:10598;continue;}
case 10598:{f.Push(JValue.I(0));f.Pc=10599;continue;}
case 10599:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10600:{f.Pc=14247;continue;}
case 10603:{f.Push(f.Locals[1]);f.Pc=10604;continue;}
case 10604:{f.Push(JValue.R(rt.String("enlistedThisCombat")));f.Pc=10607;continue;}
case 10607:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10610);}
case 10610:{f.Pc=f.Pop().Int==0?10622:10613;continue;}
case 10613:{f.Push(f.Locals[0]);f.Pc=10614;continue;}
case 10614:{return rt.Call(f,"forge/game/card/Card","getEnlistedThisCombat","()Z","invokevirtual",10617);}
case 10617:{f.Pc=f.Pop().Int!=0?14247:10620;continue;}
case 10620:{f.Push(JValue.I(0));f.Pc=10621;continue;}
case 10621:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10622:{f.Push(f.Locals[1]);f.Pc=10623;continue;}
case 10623:{f.Push(JValue.R(rt.String("attackedThisCombat")));f.Pc=10626;continue;}
case 10626:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10629);}
case 10629:{f.Pc=f.Pop().Int==0?10694:10632;continue;}
case 10632:{f.Push(JValue.R(null));f.Pc=10633;continue;}
case 10633:{f.Push(f.Locals[6]);f.Pc=10635;continue;}
case 10635:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?10648:10638;continue;}
case 10638:{f.Push(f.Locals[0]);f.Pc=10639;continue;}
case 10639:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",10642);}
case 10642:{return rt.Call(f,"forge/game/card/CardDamageHistory","getCreatureAttackedThisCombat","()I","invokevirtual",10645);}
case 10645:{f.Pc=f.Pop().Int!=0?10650:10648;continue;}
case 10648:{f.Push(JValue.I(0));f.Pc=10649;continue;}
case 10649:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10650:{f.Push(f.Locals[1]);f.Pc=10651;continue;}
case 10651:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",10654);}
case 10654:{f.Push(JValue.I(18));f.Pc=10656;continue;}
case 10656:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?14247:10659;continue;}
case 10659:{f.Push(f.Locals[3]);f.Pc=10660;continue;}
case 10660:{f.Push(f.Locals[1]);f.Pc=10661;continue;}
case 10661:{f.Push(JValue.I(21));f.Pc=10663;continue;}
case 10663:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",10666);}
case 10666:{f.Push(f.Locals[4]);f.Pc=10668;continue;}
case 10668:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",10671);}
case 10671:{f.Locals[9]=f.Pop();f.Pc=10673;continue;}
case 10673:{f.Push(f.Locals[0]);f.Pc=10674;continue;}
case 10674:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",10677);}
case 10677:{return rt.Call(f,"forge/game/card/CardDamageHistory","getCreatureAttackedThisCombat","()I","invokevirtual",10680);}
case 10680:{f.Push(f.Locals[1]);f.Pc=10681;continue;}
case 10681:{f.Push(f.Locals[9]);f.Pc=10683;continue;}
case 10683:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",10686);}
case 10686:{f.Pc=f.Pop().Int!=0?10691:10689;continue;}
case 10689:{f.Push(JValue.I(0));f.Pc=10690;continue;}
case 10690:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10691:{f.Pc=14247;continue;}
case 10694:{f.Push(f.Locals[1]);f.Pc=10695;continue;}
case 10695:{f.Push(JValue.R(rt.String("blockedThisCombat")));f.Pc=10698;continue;}
case 10698:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10701);}
case 10701:{f.Pc=f.Pop().Int==0?10722:10704;continue;}
case 10704:{f.Push(JValue.R(null));f.Pc=10705;continue;}
case 10705:{f.Push(f.Locals[6]);f.Pc=10707;continue;}
case 10707:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?10720:10710;continue;}
case 10710:{f.Push(f.Locals[0]);f.Pc=10711;continue;}
case 10711:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",10714);}
case 10714:{return rt.Call(f,"forge/game/card/CardDamageHistory","getCreatureBlockedThisCombat","()Z","invokevirtual",10717);}
case 10717:{f.Pc=f.Pop().Int!=0?14247:10720;continue;}
case 10720:{f.Push(JValue.I(0));f.Pc=10721;continue;}
case 10721:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10722:{f.Push(f.Locals[1]);f.Pc=10723;continue;}
case 10723:{f.Push(JValue.R(rt.String("attackedBySourceThisCombat")));f.Pc=10726;continue;}
case 10726:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",10729);}
case 10729:{f.Pc=f.Pop().Int==0?10770:10732;continue;}
case 10732:{f.Push(JValue.R(null));f.Pc=10733;continue;}
case 10733:{f.Push(f.Locals[6]);f.Pc=10735;continue;}
case 10735:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?10740:10738;continue;}
case 10738:{f.Push(JValue.I(0));f.Pc=10739;continue;}
case 10739:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10740:{f.Push(f.Locals[6]);f.Pc=10742;continue;}
case 10742:{f.Push(f.Locals[3]);f.Pc=10743;continue;}
case 10743:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",10746);}
case 10746:{f.Locals[9]=f.Pop();f.Pc=10748;continue;}
case 10748:{f.Push(f.Locals[9]);f.Pc=10750;continue;}
case 10750:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=10753;continue;}
case 10753:{f.Pc=f.Pop().Int==0?10767:10756;continue;}
case 10756:{f.Push(f.Locals[0]);f.Pc=10757;continue;}
case 10757:{f.Push(f.Locals[9]);f.Pc=10759;continue;}
case 10759:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",10762);}
case 10762:{f.Pc=f.Pop().Int!=0?10767:10765;continue;}
case 10765:{f.Push(JValue.I(0));f.Pc=10766;continue;}
case 10766:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10767:{f.Pc=14247;continue;}
case 10770:{f.Push(f.Locals[1]);f.Pc=10771;continue;}
case 10771:{f.Push(JValue.R(rt.String("blocking")));f.Pc=10774;continue;}
case 10774:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10777);}
case 10777:{f.Pc=f.Pop().Int==0?10987:10780;continue;}
case 10780:{f.Push(f.Locals[6]);f.Pc=10782;continue;}
case 10782:{f.Pc=f.Pop().Reference==null?10794:10785;continue;}
case 10785:{f.Push(f.Locals[6]);f.Pc=10787;continue;}
case 10787:{f.Push(f.Locals[0]);f.Pc=10788;continue;}
case 10788:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;)Z","invokevirtual",10791);}
case 10791:{f.Pc=f.Pop().Int!=0?10796:10794;continue;}
case 10794:{f.Push(JValue.I(0));f.Pc=10795;continue;}
case 10795:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10796:{f.Push(f.Locals[1]);f.Pc=10797;continue;}
case 10797:{f.Push(JValue.R(rt.String("blocking")));f.Pc=10800;continue;}
case 10800:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",10803);}
case 10803:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",10806);}
case 10806:{f.Locals[9]=f.Pop();f.Pc=10808;continue;}
case 10808:{f.Push(f.Locals[9]);f.Pc=10810;continue;}
case 10810:{f.Push(JValue.R(rt.String("Alone")));f.Pc=10813;continue;}
case 10813:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",10816);}
case 10816:{f.Pc=f.Pop().Int==0?10844:10819;continue;}
case 10819:{f.Push(f.Locals[0]);f.Pc=10820;continue;}
case 10820:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",10823);}
case 10823:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",10826);}
case 10826:{return rt.DynamicCall(f,"forge/game/card/CardProperty:5251:10826:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",10831);}
case 10831:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",10834);}
case 10834:{f.Push(JValue.I(1));f.Pc=10835;continue;}
case 10835:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?10842:10838;continue;}
case 10838:{f.Push(JValue.I(1));f.Pc=10839;continue;}
case 10839:{f.Pc=10843;continue;}
case 10842:{f.Push(JValue.I(0));f.Pc=10843;continue;}
case 10843:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10844:{f.Push(f.Locals[9]);f.Pc=10846;continue;}
case 10846:{f.Push(JValue.R(rt.String("Source")));f.Pc=10849;continue;}
case 10849:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10852);}
case 10852:{f.Pc=f.Pop().Int==0?10863:10855;continue;}
case 10855:{f.Push(f.Locals[6]);f.Pc=10857;continue;}
case 10857:{f.Push(f.Locals[0]);f.Pc=10858;continue;}
case 10858:{f.Push(f.Locals[3]);f.Pc=10859;continue;}
case 10859:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",10862);}
case 10862:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10863:{f.Push(f.Locals[9]);f.Pc=10865;continue;}
case 10865:{f.Push(JValue.R(rt.String("CreatureYouCtrl")));f.Pc=10868;continue;}
case 10868:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10871);}
case 10871:{f.Pc=f.Pop().Int==0?10923:10874;continue;}
case 10874:{f.Push(f.Locals[2]);f.Pc=10875;continue;}
case 10875:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",10878);}
case 10878:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",10881);}
case 10881:{f.Locals[10]=f.Pop();f.Pc=10883;continue;}
case 10883:{f.Push(f.Locals[10]);f.Pc=10885;continue;}
case 10885:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",10890);}
case 10890:{f.Pc=f.Pop().Int==0?10921:10893;continue;}
case 10893:{f.Push(f.Locals[10]);f.Pc=10895;continue;}
case 10895:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",10900);}
case 10900:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10903;continue;}
case 10903:{f.Locals[11]=f.Pop();f.Pc=10905;continue;}
case 10905:{f.Push(f.Locals[6]);f.Pc=10907;continue;}
case 10907:{f.Push(f.Locals[0]);f.Pc=10908;continue;}
case 10908:{f.Push(f.Locals[11]);f.Pc=10910;continue;}
case 10910:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",10913);}
case 10913:{f.Pc=f.Pop().Int==0?10918:10916;continue;}
case 10916:{f.Push(JValue.I(1));f.Pc=10917;continue;}
case 10917:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10918:{f.Pc=10883;continue;}
case 10921:{f.Push(JValue.I(0));f.Pc=10922;continue;}
case 10922:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10923:{f.Push(f.Locals[9]);f.Pc=10925;continue;}
case 10925:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",10928);}
case 10928:{f.Pc=f.Pop().Int!=0?10984:10931;continue;}
case 10931:{f.Push(f.Locals[3]);f.Pc=10932;continue;}
case 10932:{f.Push(f.Locals[9]);f.Pc=10934;continue;}
case 10934:{f.Push(f.Locals[4]);f.Pc=10936;continue;}
case 10936:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",10939);}
case 10939:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",10942);}
case 10942:{f.Locals[10]=f.Pop();f.Pc=10944;continue;}
case 10944:{f.Push(f.Locals[10]);f.Pc=10946;continue;}
case 10946:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",10951);}
case 10951:{f.Pc=f.Pop().Int==0?10982:10954;continue;}
case 10954:{f.Push(f.Locals[10]);f.Pc=10956;continue;}
case 10956:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",10961);}
case 10961:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10964;continue;}
case 10964:{f.Locals[11]=f.Pop();f.Pc=10966;continue;}
case 10966:{f.Push(f.Locals[6]);f.Pc=10968;continue;}
case 10968:{f.Push(f.Locals[0]);f.Pc=10969;continue;}
case 10969:{f.Push(f.Locals[11]);f.Pc=10971;continue;}
case 10971:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",10974);}
case 10974:{f.Pc=f.Pop().Int==0?10979:10977;continue;}
case 10977:{f.Push(JValue.I(1));f.Pc=10978;continue;}
case 10978:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10979:{f.Pc=10944;continue;}
case 10982:{f.Push(JValue.I(0));f.Pc=10983;continue;}
case 10983:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10984:{f.Pc=14247;continue;}
case 10987:{f.Push(f.Locals[1]);f.Pc=10988;continue;}
case 10988:{f.Push(JValue.R(rt.String("sharesBlockingAssignmentWith")));f.Pc=10991;continue;}
case 10991:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10994);}
case 10994:{f.Pc=f.Pop().Int==0?11047:10997;continue;}
case 10997:{f.Push(JValue.R(null));f.Pc=10998;continue;}
case 10998:{f.Push(f.Locals[6]);f.Pc=11000;continue;}
case 11000:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?11005:11003;continue;}
case 11003:{f.Push(JValue.I(0));f.Pc=11004;continue;}
case 11004:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11005:{f.Push(JValue.R(null));f.Pc=11006;continue;}
case 11006:{f.Push(f.Locals[6]);f.Pc=11008;continue;}
case 11008:{f.Push(f.Locals[3]);f.Pc=11009;continue;}
case 11009:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",11012);}
case 11012:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?11025:11015;continue;}
case 11015:{f.Push(JValue.R(null));f.Pc=11016;continue;}
case 11016:{f.Push(f.Locals[6]);f.Pc=11018;continue;}
case 11018:{f.Push(f.Locals[0]);f.Pc=11019;continue;}
case 11019:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",11022);}
case 11022:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?11027:11025;continue;}
case 11025:{f.Push(JValue.I(0));f.Pc=11026;continue;}
case 11026:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11027:{f.Push(f.Locals[6]);f.Pc=11029;continue;}
case 11029:{f.Push(f.Locals[3]);f.Pc=11030;continue;}
case 11030:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",11033);}
case 11033:{f.Push(f.Locals[6]);f.Pc=11035;continue;}
case 11035:{f.Push(f.Locals[0]);f.Pc=11036;continue;}
case 11036:{return rt.Call(f,"forge/game/combat/Combat","getAttackersBlockedBy","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",11039);}
case 11039:{return rt.Call(f,"java/util/Collections","disjoint","(Ljava/util/Collection;Ljava/util/Collection;)Z","invokestatic",11042);}
case 11042:{f.Pc=f.Pop().Int==0?14247:11045;continue;}
case 11045:{f.Push(JValue.I(0));f.Pc=11046;continue;}
case 11046:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11047:{f.Push(f.Locals[1]);f.Pc=11048;continue;}
case 11048:{f.Push(JValue.R(rt.String("blocked")));f.Pc=11051;continue;}
case 11051:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11054);}
case 11054:{f.Pc=f.Pop().Int==0?11078:11057;continue;}
case 11057:{f.Push(JValue.R(null));f.Pc=11058;continue;}
case 11058:{f.Push(f.Locals[6]);f.Pc=11060;continue;}
case 11060:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?11076:11063;continue;}
case 11063:{f.Push(f.Locals[6]);f.Pc=11065;continue;}
case 11065:{f.Push(f.Locals[0]);f.Pc=11066;continue;}
case 11066:{return rt.Call(f,"forge/game/combat/Combat","isBlocked","(Lforge/game/card/Card;)Z","invokevirtual",11069);}
case 11069:{f.Pc=f.Pop().Int==0?11076:11072;continue;}
case 11072:{f.Push(JValue.I(1));f.Pc=11073;continue;}
case 11073:{f.Pc=11077;continue;}
case 11076:{f.Push(JValue.I(0));f.Pc=11077;continue;}
case 11077:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11078:{f.Push(f.Locals[1]);f.Pc=11079;continue;}
case 11079:{f.Push(JValue.R(rt.String("blockedBySourceThisTurn")));f.Pc=11082;continue;}
case 11082:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11085);}
case 11085:{f.Pc=f.Pop().Int==0?11099:11088;continue;}
case 11088:{f.Push(f.Locals[0]);f.Pc=11089;continue;}
case 11089:{return rt.Call(f,"forge/game/card/Card","getBlockedByThisTurn","()Ljava/util/List;","invokevirtual",11092);}
case 11092:{f.Push(f.Locals[3]);f.Pc=11093;continue;}
case 11093:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",11098);}
case 11098:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11099:{f.Push(f.Locals[1]);f.Pc=11100;continue;}
case 11100:{f.Push(JValue.R(rt.String("blockedBySourceLKI")));f.Pc=11103;continue;}
case 11103:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11106);}
case 11106:{f.Pc=f.Pop().Int==0?11136:11109;continue;}
case 11109:{f.Push(JValue.R(null));f.Pc=11110;continue;}
case 11110:{f.Push(f.Locals[6]);f.Pc=11112;continue;}
case 11112:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?11134:11115;continue;}
case 11115:{f.Push(f.Locals[6]);f.Pc=11117;continue;}
case 11117:{f.Push(f.Locals[5]);f.Pc=11119;continue;}
case 11119:{f.Push(f.Locals[3]);f.Pc=11120;continue;}
case 11120:{return rt.Call(f,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",11123);}
case 11123:{f.Push(f.Locals[0]);f.Pc=11124;continue;}
case 11124:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",11127);}
case 11127:{f.Pc=f.Pop().Int==0?11134:11130;continue;}
case 11130:{f.Push(JValue.I(1));f.Pc=11131;continue;}
case 11131:{f.Pc=11135;continue;}
case 11134:{f.Push(JValue.I(0));f.Pc=11135;continue;}
case 11135:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11136:{f.Push(f.Locals[1]);f.Pc=11137;continue;}
case 11137:{f.Push(JValue.R(rt.String("blockedBySource")));f.Pc=11140;continue;}
case 11140:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11143);}
case 11143:{f.Pc=f.Pop().Int==0?11168:11146;continue;}
case 11146:{f.Push(JValue.R(null));f.Pc=11147;continue;}
case 11147:{f.Push(f.Locals[6]);f.Pc=11149;continue;}
case 11149:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?11166:11152;continue;}
case 11152:{f.Push(f.Locals[6]);f.Pc=11154;continue;}
case 11154:{f.Push(f.Locals[3]);f.Pc=11155;continue;}
case 11155:{f.Push(f.Locals[0]);f.Pc=11156;continue;}
case 11156:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",11159);}
case 11159:{f.Pc=f.Pop().Int==0?11166:11162;continue;}
case 11162:{f.Push(JValue.I(1));f.Pc=11163;continue;}
case 11163:{f.Pc=11167;continue;}
case 11166:{f.Push(JValue.I(0));f.Pc=11167;continue;}
case 11167:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11168:{f.Push(f.Locals[1]);f.Pc=11169;continue;}
case 11169:{f.Push(JValue.R(rt.String("blockedThisTurn")));f.Pc=11172;continue;}
case 11172:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11175);}
case 11175:{f.Pc=f.Pop().Int==0?11196:11178;continue;}
case 11178:{f.Push(f.Locals[0]);f.Pc=11179;continue;}
case 11179:{return rt.Call(f,"forge/game/card/Card","getBlockedThisTurn","()Ljava/util/List;","invokevirtual",11182);}
case 11182:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",11187);}
case 11187:{f.Pc=f.Pop().Int!=0?11194:11190;continue;}
case 11190:{f.Push(JValue.I(1));f.Pc=11191;continue;}
case 11191:{f.Pc=11195;continue;}
case 11194:{f.Push(JValue.I(0));f.Pc=11195;continue;}
case 11195:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11196:{f.Push(f.Locals[1]);f.Pc=11197;continue;}
case 11197:{f.Push(JValue.R(rt.String("blockedByThisTurn")));f.Pc=11200;continue;}
case 11200:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11203);}
case 11203:{f.Pc=f.Pop().Int==0?11224:11206;continue;}
case 11206:{f.Push(f.Locals[0]);f.Pc=11207;continue;}
case 11207:{return rt.Call(f,"forge/game/card/Card","getBlockedByThisTurn","()Ljava/util/List;","invokevirtual",11210);}
case 11210:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",11215);}
case 11215:{f.Pc=f.Pop().Int!=0?11222:11218;continue;}
case 11218:{f.Push(JValue.I(1));f.Pc=11219;continue;}
case 11219:{f.Pc=11223;continue;}
case 11222:{f.Push(JValue.I(0));f.Pc=11223;continue;}
case 11223:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11224:{f.Push(f.Locals[1]);f.Pc=11225;continue;}
case 11225:{f.Push(JValue.R(rt.String("blockedValidThisTurn ")));f.Pc=11228;continue;}
case 11228:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11231);}
case 11231:{f.Pc=f.Pop().Int==0?11345:11234;continue;}
case 11234:{f.Push(f.Locals[0]);f.Pc=11235;continue;}
case 11235:{return rt.Call(f,"forge/game/card/Card","getBlockedThisTurn","()Ljava/util/List;","invokevirtual",11238);}
case 11238:{f.Locals[9]=f.Pop();f.Pc=11240;continue;}
case 11240:{f.Push(f.Locals[9]);f.Pc=11242;continue;}
case 11242:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",11247);}
case 11247:{f.Pc=f.Pop().Int==0?11252:11250;continue;}
case 11250:{f.Push(JValue.I(0));f.Pc=11251;continue;}
case 11251:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11252:{f.Push(f.Locals[1]);f.Pc=11253;continue;}
case 11253:{f.Push(JValue.R(rt.String(" ")));f.Pc=11255;continue;}
case 11255:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",11258);}
case 11258:{f.Push(JValue.I(1));f.Pc=11259;continue;}
case 11259:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=11260;continue;}
case 11260:{f.Locals[10]=f.Pop();f.Pc=11262;continue;}
case 11262:{f.Push(f.Locals[9]);f.Pc=11264;continue;}
case 11264:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",11269);}
case 11269:{f.Push(f.Locals[10]);f.Pc=11271;continue;}
case 11271:{f.Push(f.Locals[0]);f.Pc=11272;continue;}
case 11272:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",11275);}
case 11275:{f.Push(f.Locals[3]);f.Pc=11276;continue;}
case 11276:{f.Push(f.Locals[4]);f.Pc=11278;continue;}
case 11278:{return rt.Call(f,"forge/game/card/CardPredicates","restriction","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",11281);}
case 11281:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",11286);}
case 11286:{f.Pc=f.Pop().Int==0?11291:11289;continue;}
case 11289:{f.Push(JValue.I(1));f.Pc=11290;continue;}
case 11290:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11291:{f.Push(f.Locals[3]);f.Pc=11292;continue;}
case 11292:{f.Push(f.Locals[10]);f.Pc=11294;continue;}
case 11294:{f.Push(f.Locals[4]);f.Pc=11296;continue;}
case 11296:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",11299);}
case 11299:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",11302);}
case 11302:{f.Locals[11]=f.Pop();f.Pc=11304;continue;}
case 11304:{f.Push(f.Locals[11]);f.Pc=11306;continue;}
case 11306:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",11311);}
case 11311:{f.Pc=f.Pop().Int==0?11343:11314;continue;}
case 11314:{f.Push(f.Locals[11]);f.Pc=11316;continue;}
case 11316:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",11321);}
case 11321:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11324;continue;}
case 11324:{f.Locals[12]=f.Pop();f.Pc=11326;continue;}
case 11326:{f.Push(f.Locals[9]);f.Pc=11328;continue;}
case 11328:{f.Push(f.Locals[12]);f.Pc=11330;continue;}
case 11330:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",11335);}
case 11335:{f.Pc=f.Pop().Int==0?11340:11338;continue;}
case 11338:{f.Push(JValue.I(1));f.Pc=11339;continue;}
case 11339:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11340:{f.Pc=11304;continue;}
case 11343:{f.Push(JValue.I(0));f.Pc=11344;continue;}
case 11344:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11345:{f.Push(f.Locals[1]);f.Pc=11346;continue;}
case 11346:{f.Push(JValue.R(rt.String("blockedByValidThisTurn ")));f.Pc=11349;continue;}
case 11349:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11352);}
case 11352:{f.Pc=f.Pop().Int==0?11466:11355;continue;}
case 11355:{f.Push(f.Locals[0]);f.Pc=11356;continue;}
case 11356:{return rt.Call(f,"forge/game/card/Card","getBlockedByThisTurn","()Ljava/util/List;","invokevirtual",11359);}
case 11359:{f.Locals[9]=f.Pop();f.Pc=11361;continue;}
case 11361:{f.Push(f.Locals[9]);f.Pc=11363;continue;}
case 11363:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",11368);}
case 11368:{f.Pc=f.Pop().Int==0?11373:11371;continue;}
case 11371:{f.Push(JValue.I(0));f.Pc=11372;continue;}
case 11372:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11373:{f.Push(f.Locals[1]);f.Pc=11374;continue;}
case 11374:{f.Push(JValue.R(rt.String(" ")));f.Pc=11376;continue;}
case 11376:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",11379);}
case 11379:{f.Push(JValue.I(1));f.Pc=11380;continue;}
case 11380:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=11381;continue;}
case 11381:{f.Locals[10]=f.Pop();f.Pc=11383;continue;}
case 11383:{f.Push(f.Locals[9]);f.Pc=11385;continue;}
case 11385:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",11390);}
case 11390:{f.Push(f.Locals[10]);f.Pc=11392;continue;}
case 11392:{f.Push(f.Locals[0]);f.Pc=11393;continue;}
case 11393:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",11396);}
case 11396:{f.Push(f.Locals[3]);f.Pc=11397;continue;}
case 11397:{f.Push(f.Locals[4]);f.Pc=11399;continue;}
case 11399:{return rt.Call(f,"forge/game/card/CardPredicates","restriction","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",11402);}
case 11402:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",11407);}
case 11407:{f.Pc=f.Pop().Int==0?11412:11410;continue;}
case 11410:{f.Push(JValue.I(1));f.Pc=11411;continue;}
case 11411:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11412:{f.Push(f.Locals[3]);f.Pc=11413;continue;}
case 11413:{f.Push(f.Locals[10]);f.Pc=11415;continue;}
case 11415:{f.Push(f.Locals[4]);f.Pc=11417;continue;}
case 11417:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",11420);}
case 11420:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",11423);}
case 11423:{f.Locals[11]=f.Pop();f.Pc=11425;continue;}
case 11425:{f.Push(f.Locals[11]);f.Pc=11427;continue;}
case 11427:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",11432);}
case 11432:{f.Pc=f.Pop().Int==0?11464:11435;continue;}
case 11435:{f.Push(f.Locals[11]);f.Pc=11437;continue;}
case 11437:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",11442);}
case 11442:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11445;continue;}
case 11445:{f.Locals[12]=f.Pop();f.Pc=11447;continue;}
case 11447:{f.Push(f.Locals[9]);f.Pc=11449;continue;}
case 11449:{f.Push(f.Locals[12]);f.Pc=11451;continue;}
case 11451:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",11456);}
case 11456:{f.Pc=f.Pop().Int==0?11461:11459;continue;}
case 11459:{f.Push(JValue.I(1));f.Pc=11460;continue;}
case 11460:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11461:{f.Pc=11425;continue;}
case 11464:{f.Push(JValue.I(0));f.Pc=11465;continue;}
case 11465:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11466:{f.Push(f.Locals[1]);f.Pc=11467;continue;}
case 11467:{f.Push(JValue.R(rt.String("isBlockedByRemembered")));f.Pc=11470;continue;}
case 11470:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11473);}
case 11473:{f.Pc=f.Pop().Int==0?11543:11476;continue;}
case 11476:{f.Push(JValue.R(null));f.Pc=11477;continue;}
case 11477:{f.Push(f.Locals[6]);f.Pc=11479;continue;}
case 11479:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?11484:11482;continue;}
case 11482:{f.Push(JValue.I(0));f.Pc=11483;continue;}
case 11483:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11484:{f.Push(f.Locals[3]);f.Pc=11485;continue;}
case 11485:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",11488);}
case 11488:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",11493);}
case 11493:{f.Locals[9]=f.Pop();f.Pc=11495;continue;}
case 11495:{f.Push(f.Locals[9]);f.Pc=11497;continue;}
case 11497:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",11502);}
case 11502:{f.Pc=f.Pop().Int==0?11541:11505;continue;}
case 11505:{f.Push(f.Locals[9]);f.Pc=11507;continue;}
case 11507:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",11512);}
case 11512:{f.Locals[10]=f.Pop();f.Pc=11514;continue;}
case 11514:{f.Push(f.Locals[10]);f.Pc=11516;continue;}
case 11516:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=11519;continue;}
case 11519:{f.Pc=f.Pop().Int==0?11538:11522;continue;}
case 11522:{f.Push(f.Locals[6]);f.Pc=11524;continue;}
case 11524:{f.Push(f.Locals[10]);f.Pc=11526;continue;}
case 11526:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11529;continue;}
case 11529:{f.Push(f.Locals[0]);f.Pc=11530;continue;}
case 11530:{return rt.Call(f,"forge/game/combat/Combat","isBlocking","(Lforge/game/card/Card;Lforge/game/card/Card;)Z","invokevirtual",11533);}
case 11533:{f.Pc=f.Pop().Int==0?11538:11536;continue;}
case 11536:{f.Push(JValue.I(1));f.Pc=11537;continue;}
case 11537:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11538:{f.Pc=11495;continue;}
case 11541:{f.Push(JValue.I(0));f.Pc=11542;continue;}
case 11542:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11543:{f.Push(f.Locals[1]);f.Pc=11544;continue;}
case 11544:{f.Push(JValue.R(rt.String("blockedRemembered")));f.Pc=11547;continue;}
case 11547:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11550);}
case 11550:{f.Pc=f.Pop().Int==0?11619:11553;continue;}
case 11553:{f.Push(f.Locals[3]);f.Pc=11554;continue;}
case 11554:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",11557);}
case 11557:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",11562);}
case 11562:{f.Locals[10]=f.Pop();f.Pc=11564;continue;}
case 11564:{f.Push(f.Locals[10]);f.Pc=11566;continue;}
case 11566:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",11571);}
case 11571:{f.Pc=f.Pop().Int==0?11617:11574;continue;}
case 11574:{f.Push(f.Locals[10]);f.Pc=11576;continue;}
case 11576:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",11581);}
case 11581:{f.Locals[11]=f.Pop();f.Pc=11583;continue;}
case 11583:{f.Push(f.Locals[11]);f.Pc=11585;continue;}
case 11585:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=11588;continue;}
case 11588:{f.Pc=f.Pop().Int==0?11614:11591;continue;}
case 11591:{f.Push(f.Locals[11]);f.Pc=11593;continue;}
case 11593:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11596;continue;}
case 11596:{f.Locals[9]=f.Pop();f.Pc=11598;continue;}
case 11598:{f.Push(f.Locals[0]);f.Pc=11599;continue;}
case 11599:{return rt.Call(f,"forge/game/card/Card","getBlockedThisTurn","()Ljava/util/List;","invokevirtual",11602);}
case 11602:{f.Push(f.Locals[9]);f.Pc=11604;continue;}
case 11604:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",11609);}
case 11609:{f.Pc=f.Pop().Int==0?11614:11612;continue;}
case 11612:{f.Push(JValue.I(1));f.Pc=11613;continue;}
case 11613:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11614:{f.Pc=11564;continue;}
case 11617:{f.Push(JValue.I(0));f.Pc=11618;continue;}
case 11618:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11619:{f.Push(f.Locals[1]);f.Pc=11620;continue;}
case 11620:{f.Push(JValue.R(rt.String("blockedByRemembered")));f.Pc=11623;continue;}
case 11623:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11626);}
case 11626:{f.Pc=f.Pop().Int==0?11695:11629;continue;}
case 11629:{f.Push(f.Locals[3]);f.Pc=11630;continue;}
case 11630:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",11633);}
case 11633:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",11638);}
case 11638:{f.Locals[10]=f.Pop();f.Pc=11640;continue;}
case 11640:{f.Push(f.Locals[10]);f.Pc=11642;continue;}
case 11642:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",11647);}
case 11647:{f.Pc=f.Pop().Int==0?11693:11650;continue;}
case 11650:{f.Push(f.Locals[10]);f.Pc=11652;continue;}
case 11652:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",11657);}
case 11657:{f.Locals[11]=f.Pop();f.Pc=11659;continue;}
case 11659:{f.Push(f.Locals[11]);f.Pc=11661;continue;}
case 11661:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=11664;continue;}
case 11664:{f.Pc=f.Pop().Int==0?11690:11667;continue;}
case 11667:{f.Push(f.Locals[11]);f.Pc=11669;continue;}
case 11669:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11672;continue;}
case 11672:{f.Locals[9]=f.Pop();f.Pc=11674;continue;}
case 11674:{f.Push(f.Locals[0]);f.Pc=11675;continue;}
case 11675:{return rt.Call(f,"forge/game/card/Card","getBlockedByThisTurn","()Ljava/util/List;","invokevirtual",11678);}
case 11678:{f.Push(f.Locals[9]);f.Pc=11680;continue;}
case 11680:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",11685);}
case 11685:{f.Pc=f.Pop().Int==0?11690:11688;continue;}
case 11688:{f.Push(JValue.I(1));f.Pc=11689;continue;}
case 11689:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11690:{f.Pc=11640;continue;}
case 11693:{f.Push(JValue.I(0));f.Pc=11694;continue;}
case 11694:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11695:{f.Push(f.Locals[1]);f.Pc=11696;continue;}
case 11696:{f.Push(JValue.R(rt.String("unblocked")));f.Pc=11699;continue;}
case 11699:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11702);}
case 11702:{f.Pc=f.Pop().Int==0?11721:11705;continue;}
case 11705:{f.Push(f.Locals[6]);f.Pc=11707;continue;}
case 11707:{f.Pc=f.Pop().Reference==null?11719:11710;continue;}
case 11710:{f.Push(f.Locals[6]);f.Pc=11712;continue;}
case 11712:{f.Push(f.Locals[0]);f.Pc=11713;continue;}
case 11713:{return rt.Call(f,"forge/game/combat/Combat","isUnblocked","(Lforge/game/card/Card;)Z","invokevirtual",11716);}
case 11716:{f.Pc=f.Pop().Int!=0?14247:11719;continue;}
case 11719:{f.Push(JValue.I(0));f.Pc=11720;continue;}
case 11720:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11721:{f.Push(f.Locals[1]);f.Pc=11722;continue;}
case 11722:{f.Push(JValue.R(rt.String("attackersBandedWith")));f.Pc=11725;continue;}
case 11725:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11728);}
case 11728:{f.Pc=f.Pop().Int==0?11782:11731;continue;}
case 11731:{f.Push(f.Locals[0]);f.Pc=11732;continue;}
case 11732:{f.Push(f.Locals[3]);f.Pc=11733;continue;}
case 11733:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",11736);}
case 11736:{f.Pc=f.Pop().Int==0?11741:11739;continue;}
case 11739:{f.Push(JValue.I(0));f.Pc=11740;continue;}
case 11740:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11741:{f.Push(f.Locals[6]);f.Pc=11743;continue;}
case 11743:{f.Pc=f.Pop().Reference!=null?11750:11746;continue;}
case 11746:{f.Push(JValue.R(null));f.Pc=11747;continue;}
case 11747:{f.Pc=11756;continue;}
case 11750:{f.Push(f.Locals[6]);f.Pc=11752;continue;}
case 11752:{f.Push(f.Locals[3]);f.Pc=11753;continue;}
case 11753:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",11756);}
case 11756:{f.Locals[9]=f.Pop();f.Pc=11758;continue;}
case 11758:{f.Push(f.Locals[9]);f.Pc=11760;continue;}
case 11760:{f.Pc=f.Pop().Reference==null?11777:11763;continue;}
case 11763:{f.Push(f.Locals[9]);f.Pc=11765;continue;}
case 11765:{return rt.Call(f,"forge/game/combat/AttackingBand","getAttackers","()Lforge/game/card/CardCollectionView;","invokevirtual",11768);}
case 11768:{f.Push(f.Locals[0]);f.Pc=11769;continue;}
case 11769:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",11774);}
case 11774:{f.Pc=f.Pop().Int!=0?11779:11777;continue;}
case 11777:{f.Push(JValue.I(0));f.Pc=11778;continue;}
case 11778:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11779:{f.Pc=14247;continue;}
case 11782:{f.Push(f.Locals[1]);f.Pc=11783;continue;}
case 11783:{f.Push(JValue.R(rt.String("hadToAttackThisCombat")));f.Pc=11786;continue;}
case 11786:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11789);}
case 11789:{f.Pc=f.Pop().Int==0?11850:11792;continue;}
case 11792:{f.Push(f.Locals[6]);f.Pc=11794;continue;}
case 11794:{f.Pc=f.Pop().Reference!=null?11801:11797;continue;}
case 11797:{f.Push(JValue.R(null));f.Pc=11798;continue;}
case 11798:{f.Pc=11818;continue;}
case 11801:{f.Push(f.Locals[6]);f.Pc=11803;continue;}
case 11803:{return rt.Call(f,"forge/game/combat/Combat","getAttackConstraints","()Lforge/game/combat/AttackConstraints;","invokevirtual",11806);}
case 11806:{return rt.Call(f,"forge/game/combat/AttackConstraints","getRequirements","()Ljava/util/Map;","invokevirtual",11809);}
case 11809:{f.Push(f.Locals[0]);f.Pc=11810;continue;}
case 11810:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11815);}
case 11815:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRequirement"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11818;continue;}
case 11818:{f.Locals[9]=f.Pop();f.Pc=11820;continue;}
case 11820:{f.Push(f.Locals[9]);f.Pc=11822;continue;}
case 11822:{f.Pc=f.Pop().Reference==null?11845:11825;continue;}
case 11825:{f.Push(f.Locals[9]);f.Pc=11827;continue;}
case 11827:{return rt.Call(f,"forge/game/combat/AttackRequirement","hasRequirement","()Z","invokevirtual",11830);}
case 11830:{f.Pc=f.Pop().Int==0?11845:11833;continue;}
case 11833:{f.Push(f.Locals[9]);f.Pc=11835;continue;}
case 11835:{return rt.Call(f,"forge/game/combat/AttackRequirement","getAttacker","()Lforge/game/card/Card;","invokevirtual",11838);}
case 11838:{f.Push(f.Locals[0]);f.Pc=11839;continue;}
case 11839:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",11842);}
case 11842:{f.Pc=f.Pop().Int!=0?11847:11845;continue;}
case 11845:{f.Push(JValue.I(0));f.Pc=11846;continue;}
case 11846:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11847:{f.Pc=14247;continue;}
case 11850:{f.Push(f.Locals[1]);f.Pc=11851;continue;}
case 11851:{f.Push(JValue.R(rt.String("couldAttackButNotAttacking")));f.Pc=11854;continue;}
case 11854:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11857);}
case 11857:{f.Pc=f.Pop().Int==0?11882:11860;continue;}
case 11860:{f.Push(f.Locals[5]);f.Pc=11862;continue;}
case 11862:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",11865);}
case 11865:{f.Push(f.Locals[8]);f.Pc=11867;continue;}
case 11867:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",11870);}
case 11870:{f.Pc=f.Pop().Int!=0?11875:11873;continue;}
case 11873:{f.Push(JValue.I(0));f.Pc=11874;continue;}
case 11874:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11875:{f.Push(f.Locals[6]);f.Pc=11877;continue;}
case 11877:{f.Push(f.Locals[0]);f.Pc=11878;continue;}
case 11878:{return rt.Call(f,"forge/game/combat/CombatUtil","couldAttackButNotAttacking","(Lforge/game/combat/Combat;Lforge/game/card/Card;)Z","invokestatic",11881);}
case 11881:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11882:{f.Push(f.Locals[1]);f.Pc=11883;continue;}
case 11883:{f.Push(JValue.R(rt.String("linkedCastSA")));f.Pc=11886;continue;}
case 11886:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11889);}
case 11889:{f.Pc=f.Pop().Int==0?11912:11892;continue;}
case 11892:{f.Push(f.Locals[0]);f.Pc=11893;continue;}
case 11893:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",11896);}
case 11896:{f.Pc=f.Pop().Reference!=null?11901:11899;continue;}
case 11899:{f.Push(JValue.I(0));f.Pc=11900;continue;}
case 11900:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11901:{f.Push(f.Locals[4]);f.Pc=11903;continue;}
case 11903:{f.Push(f.Locals[0]);f.Pc=11904;continue;}
case 11904:{return rt.Call(f,"forge/game/ability/AbilityUtils","isUnlinkedFromCastSA","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)Z","invokestatic",11907);}
case 11907:{f.Pc=f.Pop().Int==0?14247:11910;continue;}
case 11910:{f.Push(JValue.I(0));f.Pc=11911;continue;}
case 11911:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11912:{f.Push(f.Locals[1]);f.Pc=11913;continue;}
case 11913:{f.Push(JValue.R(rt.String("kicked")));f.Pc=11916;continue;}
case 11916:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",11919);}
case 11919:{f.Pc=f.Pop().Int==0?12012:11922;continue;}
case 11922:{f.Push(f.Locals[4]);f.Pc=11924;continue;}
case 11924:{f.Push(f.Locals[0]);f.Pc=11925;continue;}
case 11925:{return rt.Call(f,"forge/game/ability/AbilityUtils","isUnlinkedFromCastSA","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)Z","invokestatic",11928);}
case 11928:{f.Pc=f.Pop().Int==0?11933:11931;continue;}
case 11931:{f.Push(JValue.I(0));f.Pc=11932;continue;}
case 11932:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11933:{f.Push(f.Locals[1]);f.Pc=11934;continue;}
case 11934:{f.Push(JValue.R(rt.String("kicked")));f.Pc=11937;continue;}
case 11937:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11940);}
case 11940:{f.Pc=f.Pop().Int==0?11952:11943;continue;}
case 11943:{f.Push(f.Locals[0]);f.Pc=11944;continue;}
case 11944:{return rt.Call(f,"forge/game/card/Card","getKickerMagnitude","()I","invokevirtual",11947);}
case 11947:{f.Pc=f.Pop().Int!=0?14247:11950;continue;}
case 11950:{f.Push(JValue.I(0));f.Pc=11951;continue;}
case 11951:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11952:{f.Push(f.Locals[1]);f.Pc=11953;continue;}
case 11953:{f.Push(JValue.R(rt.String("kicked ")));f.Pc=11956;continue;}
case 11956:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",11959);}
case 11959:{f.Push(JValue.I(1));f.Pc=11960;continue;}
case 11960:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=11961;continue;}
case 11961:{f.Locals[9]=f.Pop();f.Pc=11963;continue;}
case 11963:{f.Push(JValue.R(rt.String("1")));f.Pc=11966;continue;}
case 11966:{f.Push(f.Locals[9]);f.Pc=11968;continue;}
case 11968:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11971);}
case 11971:{f.Pc=f.Pop().Int==0?11986:11974;continue;}
case 11974:{f.Push(f.Locals[0]);f.Pc=11975;continue;}
case 11975:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;"));f.Pc=11978;continue;}
case 11978:{return rt.Call(f,"forge/game/card/Card","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",11981);}
case 11981:{f.Pc=f.Pop().Int!=0?11986:11984;continue;}
case 11984:{f.Push(JValue.I(0));f.Pc=11985;continue;}
case 11985:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11986:{f.Push(JValue.R(rt.String("2")));f.Pc=11989;continue;}
case 11989:{f.Push(f.Locals[9]);f.Pc=11991;continue;}
case 11991:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11994);}
case 11994:{f.Pc=f.Pop().Int==0?12009:11997;continue;}
case 11997:{f.Push(f.Locals[0]);f.Pc=11998;continue;}
case 11998:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;"));f.Pc=12001;continue;}
case 12001:{return rt.Call(f,"forge/game/card/Card","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",12004);}
case 12004:{f.Pc=f.Pop().Int!=0?12009:12007;continue;}
case 12007:{f.Push(JValue.I(0));f.Pc=12008;continue;}
case 12008:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12009:{f.Pc=14247;continue;}
case 12012:{f.Push(f.Locals[1]);f.Pc=12013;continue;}
case 12013:{f.Push(JValue.R(rt.String("bargained")));f.Pc=12016;continue;}
case 12016:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12019);}
case 12019:{f.Pc=f.Pop().Int==0?12050:12022;continue;}
case 12022:{f.Push(f.Locals[0]);f.Pc=12023;continue;}
case 12023:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12026);}
case 12026:{f.Pc=f.Pop().Reference!=null?12031:12029;continue;}
case 12029:{f.Push(JValue.I(0));f.Pc=12030;continue;}
case 12030:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12031:{f.Push(f.Locals[4]);f.Pc=12033;continue;}
case 12033:{f.Push(f.Locals[0]);f.Pc=12034;continue;}
case 12034:{return rt.Call(f,"forge/game/ability/AbilityUtils","isUnlinkedFromCastSA","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)Z","invokestatic",12037);}
case 12037:{f.Pc=f.Pop().Int==0?12042:12040;continue;}
case 12040:{f.Push(JValue.I(0));f.Pc=12041;continue;}
case 12041:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12042:{f.Push(f.Locals[0]);f.Pc=12043;continue;}
case 12043:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12046);}
case 12046:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBargained","()Z","invokevirtual",12049);}
case 12049:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12050:{f.Push(f.Locals[1]);f.Pc=12051;continue;}
case 12051:{f.Push(JValue.R(rt.String("surged")));f.Pc=12054;continue;}
case 12054:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12057);}
case 12057:{f.Pc=f.Pop().Int==0?12088:12060;continue;}
case 12060:{f.Push(f.Locals[0]);f.Pc=12061;continue;}
case 12061:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12064);}
case 12064:{f.Pc=f.Pop().Reference!=null?12069:12067;continue;}
case 12067:{f.Push(JValue.I(0));f.Pc=12068;continue;}
case 12068:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12069:{f.Push(f.Locals[4]);f.Pc=12071;continue;}
case 12071:{f.Push(f.Locals[0]);f.Pc=12072;continue;}
case 12072:{return rt.Call(f,"forge/game/ability/AbilityUtils","isUnlinkedFromCastSA","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)Z","invokestatic",12075);}
case 12075:{f.Pc=f.Pop().Int==0?12080:12078;continue;}
case 12078:{f.Push(JValue.I(0));f.Pc=12079;continue;}
case 12079:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12080:{f.Push(f.Locals[0]);f.Pc=12081;continue;}
case 12081:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12084);}
case 12084:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSurged","()Z","invokevirtual",12087);}
case 12087:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12088:{f.Push(f.Locals[1]);f.Pc=12089;continue;}
case 12089:{f.Push(JValue.R(rt.String("blitzed")));f.Pc=12092;continue;}
case 12092:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12095);}
case 12095:{f.Pc=f.Pop().Int==0?12126:12098;continue;}
case 12098:{f.Push(f.Locals[0]);f.Pc=12099;continue;}
case 12099:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12102);}
case 12102:{f.Pc=f.Pop().Reference!=null?12107:12105;continue;}
case 12105:{f.Push(JValue.I(0));f.Pc=12106;continue;}
case 12106:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12107:{f.Push(f.Locals[4]);f.Pc=12109;continue;}
case 12109:{f.Push(f.Locals[0]);f.Pc=12110;continue;}
case 12110:{return rt.Call(f,"forge/game/ability/AbilityUtils","isUnlinkedFromCastSA","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)Z","invokestatic",12113);}
case 12113:{f.Pc=f.Pop().Int==0?12118:12116;continue;}
case 12116:{f.Push(JValue.I(0));f.Pc=12117;continue;}
case 12117:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12118:{f.Push(f.Locals[0]);f.Pc=12119;continue;}
case 12119:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12122);}
case 12122:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBlitz","()Z","invokevirtual",12125);}
case 12125:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12126:{f.Push(f.Locals[1]);f.Pc=12127;continue;}
case 12127:{f.Push(JValue.R(rt.String("dashed")));f.Pc=12130;continue;}
case 12130:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12133);}
case 12133:{f.Pc=f.Pop().Int==0?12164:12136;continue;}
case 12136:{f.Push(f.Locals[0]);f.Pc=12137;continue;}
case 12137:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12140);}
case 12140:{f.Pc=f.Pop().Reference!=null?12145:12143;continue;}
case 12143:{f.Push(JValue.I(0));f.Pc=12144;continue;}
case 12144:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12145:{f.Push(f.Locals[4]);f.Pc=12147;continue;}
case 12147:{f.Push(f.Locals[0]);f.Pc=12148;continue;}
case 12148:{return rt.Call(f,"forge/game/ability/AbilityUtils","isUnlinkedFromCastSA","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)Z","invokestatic",12151);}
case 12151:{f.Pc=f.Pop().Int==0?12156:12154;continue;}
case 12154:{f.Push(JValue.I(0));f.Pc=12155;continue;}
case 12155:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12156:{f.Push(f.Locals[0]);f.Pc=12157;continue;}
case 12157:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12160);}
case 12160:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDash","()Z","invokevirtual",12163);}
case 12163:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12164:{f.Push(f.Locals[1]);f.Pc=12165;continue;}
case 12165:{f.Push(JValue.R(rt.String("escaped")));f.Pc=12168;continue;}
case 12168:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12171);}
case 12171:{f.Pc=f.Pop().Int==0?12191:12174;continue;}
case 12174:{f.Push(f.Locals[0]);f.Pc=12175;continue;}
case 12175:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12178);}
case 12178:{f.Pc=f.Pop().Reference!=null?12183:12181;continue;}
case 12181:{f.Push(JValue.I(0));f.Pc=12182;continue;}
case 12182:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12183:{f.Push(f.Locals[0]);f.Pc=12184;continue;}
case 12184:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12187);}
case 12187:{return rt.Call(f,"forge/game/spellability/SpellAbility","isEscape","()Z","invokevirtual",12190);}
case 12190:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12191:{f.Push(f.Locals[1]);f.Pc=12192;continue;}
case 12192:{f.Push(JValue.R(rt.String("evoked")));f.Pc=12195;continue;}
case 12195:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12198);}
case 12198:{f.Pc=f.Pop().Int==0?12229:12201;continue;}
case 12201:{f.Push(f.Locals[0]);f.Pc=12202;continue;}
case 12202:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12205);}
case 12205:{f.Pc=f.Pop().Reference!=null?12210:12208;continue;}
case 12208:{f.Push(JValue.I(0));f.Pc=12209;continue;}
case 12209:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12210:{f.Push(f.Locals[4]);f.Pc=12212;continue;}
case 12212:{f.Push(f.Locals[0]);f.Pc=12213;continue;}
case 12213:{return rt.Call(f,"forge/game/ability/AbilityUtils","isUnlinkedFromCastSA","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)Z","invokestatic",12216);}
case 12216:{f.Pc=f.Pop().Int==0?12221:12219;continue;}
case 12219:{f.Push(JValue.I(0));f.Pc=12220;continue;}
case 12220:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12221:{f.Push(f.Locals[0]);f.Pc=12222;continue;}
case 12222:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12225);}
case 12225:{return rt.Call(f,"forge/game/spellability/SpellAbility","isEvoke","()Z","invokevirtual",12228);}
case 12228:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12229:{f.Push(f.Locals[1]);f.Pc=12230;continue;}
case 12230:{f.Push(JValue.R(rt.String("PromisedGift")));f.Pc=12233;continue;}
case 12233:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12236);}
case 12236:{f.Pc=f.Pop().Int==0?12256:12239;continue;}
case 12239:{f.Push(f.Locals[0]);f.Pc=12240;continue;}
case 12240:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12243);}
case 12243:{f.Pc=f.Pop().Reference!=null?12248:12246;continue;}
case 12246:{f.Push(JValue.I(0));f.Pc=12247;continue;}
case 12247:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12248:{f.Push(f.Locals[0]);f.Pc=12249;continue;}
case 12249:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12252);}
case 12252:{return rt.Call(f,"forge/game/spellability/SpellAbility","isGiftPromised","()Z","invokevirtual",12255);}
case 12255:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12256:{f.Push(f.Locals[1]);f.Pc=12257;continue;}
case 12257:{f.Push(JValue.R(rt.String("Teamwork")));f.Pc=12260;continue;}
case 12260:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12263);}
case 12263:{f.Pc=f.Pop().Int==0?12283:12266;continue;}
case 12266:{f.Push(f.Locals[0]);f.Pc=12267;continue;}
case 12267:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12270);}
case 12270:{f.Pc=f.Pop().Reference!=null?12275:12273;continue;}
case 12273:{f.Push(JValue.I(0));f.Pc=12274;continue;}
case 12274:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12275:{f.Push(f.Locals[0]);f.Pc=12276;continue;}
case 12276:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12279);}
case 12279:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTeamwork","()Z","invokevirtual",12282);}
case 12282:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12283:{f.Push(f.Locals[1]);f.Pc=12284;continue;}
case 12284:{f.Push(JValue.R(rt.String("impended")));f.Pc=12287;continue;}
case 12287:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12290);}
case 12290:{f.Pc=f.Pop().Int==0?12321:12293;continue;}
case 12293:{f.Push(f.Locals[0]);f.Pc=12294;continue;}
case 12294:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12297);}
case 12297:{f.Pc=f.Pop().Reference!=null?12302:12300;continue;}
case 12300:{f.Push(JValue.I(0));f.Pc=12301;continue;}
case 12301:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12302:{f.Push(f.Locals[4]);f.Pc=12304;continue;}
case 12304:{f.Push(f.Locals[0]);f.Pc=12305;continue;}
case 12305:{return rt.Call(f,"forge/game/ability/AbilityUtils","isUnlinkedFromCastSA","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)Z","invokestatic",12308);}
case 12308:{f.Pc=f.Pop().Int==0?12313:12311;continue;}
case 12311:{f.Push(JValue.I(0));f.Pc=12312;continue;}
case 12312:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12313:{f.Push(f.Locals[0]);f.Pc=12314;continue;}
case 12314:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12317);}
case 12317:{return rt.Call(f,"forge/game/spellability/SpellAbility","isImpending","()Z","invokevirtual",12320);}
case 12320:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12321:{f.Push(f.Locals[1]);f.Pc=12322;continue;}
case 12322:{f.Push(JValue.R(rt.String("prowled")));f.Pc=12325;continue;}
case 12325:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12328);}
case 12328:{f.Pc=f.Pop().Int==0?12359:12331;continue;}
case 12331:{f.Push(f.Locals[0]);f.Pc=12332;continue;}
case 12332:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12335);}
case 12335:{f.Pc=f.Pop().Reference!=null?12340:12338;continue;}
case 12338:{f.Push(JValue.I(0));f.Pc=12339;continue;}
case 12339:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12340:{f.Push(f.Locals[4]);f.Pc=12342;continue;}
case 12342:{f.Push(f.Locals[0]);f.Pc=12343;continue;}
case 12343:{return rt.Call(f,"forge/game/ability/AbilityUtils","isUnlinkedFromCastSA","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)Z","invokestatic",12346);}
case 12346:{f.Pc=f.Pop().Int==0?12351:12349;continue;}
case 12349:{f.Push(JValue.I(0));f.Pc=12350;continue;}
case 12350:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12351:{f.Push(f.Locals[0]);f.Pc=12352;continue;}
case 12352:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12355);}
case 12355:{return rt.Call(f,"forge/game/spellability/SpellAbility","isProwl","()Z","invokevirtual",12358);}
case 12358:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12359:{f.Push(f.Locals[1]);f.Pc=12360;continue;}
case 12360:{f.Push(JValue.R(rt.String("spectacle")));f.Pc=12363;continue;}
case 12363:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12366);}
case 12366:{f.Pc=f.Pop().Int==0?12397:12369;continue;}
case 12369:{f.Push(f.Locals[0]);f.Pc=12370;continue;}
case 12370:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12373);}
case 12373:{f.Pc=f.Pop().Reference!=null?12378:12376;continue;}
case 12376:{f.Push(JValue.I(0));f.Pc=12377;continue;}
case 12377:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12378:{f.Push(f.Locals[4]);f.Pc=12380;continue;}
case 12380:{f.Push(f.Locals[0]);f.Pc=12381;continue;}
case 12381:{return rt.Call(f,"forge/game/ability/AbilityUtils","isUnlinkedFromCastSA","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)Z","invokestatic",12384);}
case 12384:{f.Pc=f.Pop().Int==0?12389:12387;continue;}
case 12387:{f.Push(JValue.I(0));f.Pc=12388;continue;}
case 12388:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12389:{f.Push(f.Locals[0]);f.Pc=12390;continue;}
case 12390:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12393);}
case 12393:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpectacle","()Z","invokevirtual",12396);}
case 12396:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12397:{f.Push(f.Locals[1]);f.Pc=12398;continue;}
case 12398:{f.Push(JValue.R(rt.String("sneaked")));f.Pc=12401;continue;}
case 12401:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12404);}
case 12404:{f.Pc=f.Pop().Int==0?12435:12407;continue;}
case 12407:{f.Push(f.Locals[0]);f.Pc=12408;continue;}
case 12408:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12411);}
case 12411:{f.Pc=f.Pop().Reference!=null?12416:12414;continue;}
case 12414:{f.Push(JValue.I(0));f.Pc=12415;continue;}
case 12415:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12416:{f.Push(f.Locals[4]);f.Pc=12418;continue;}
case 12418:{f.Push(f.Locals[0]);f.Pc=12419;continue;}
case 12419:{return rt.Call(f,"forge/game/ability/AbilityUtils","isUnlinkedFromCastSA","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)Z","invokestatic",12422);}
case 12422:{f.Pc=f.Pop().Int==0?12427:12425;continue;}
case 12425:{f.Push(JValue.I(0));f.Pc=12426;continue;}
case 12426:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12427:{f.Push(f.Locals[0]);f.Pc=12428;continue;}
case 12428:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12431);}
case 12431:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSneak","()Z","invokevirtual",12434);}
case 12434:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12435:{f.Push(f.Locals[1]);f.Pc=12436;continue;}
case 12436:{f.Push(JValue.R(rt.String("foretold")));f.Pc=12439;continue;}
case 12439:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12442);}
case 12442:{f.Pc=f.Pop().Int==0?12454:12445;continue;}
case 12445:{f.Push(f.Locals[0]);f.Pc=12446;continue;}
case 12446:{return rt.Call(f,"forge/game/card/Card","isForetold","()Z","invokevirtual",12449);}
case 12449:{f.Pc=f.Pop().Int!=0?14247:12452;continue;}
case 12452:{f.Push(JValue.I(0));f.Pc=12453;continue;}
case 12453:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12454:{f.Push(f.Locals[1]);f.Pc=12455;continue;}
case 12455:{f.Push(JValue.R(rt.String("warped")));f.Pc=12458;continue;}
case 12458:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12461);}
case 12461:{f.Pc=f.Pop().Int==0?12473:12464;continue;}
case 12464:{f.Push(f.Locals[0]);f.Pc=12465;continue;}
case 12465:{return rt.Call(f,"forge/game/card/Card","isWarped","()Z","invokevirtual",12468);}
case 12468:{f.Pc=f.Pop().Int!=0?14247:12471;continue;}
case 12471:{f.Push(JValue.I(0));f.Pc=12472;continue;}
case 12472:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12473:{f.Push(f.Locals[1]);f.Pc=12474;continue;}
case 12474:{f.Push(JValue.R(rt.String("webSlinged")));f.Pc=12477;continue;}
case 12477:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12480);}
case 12480:{f.Pc=f.Pop().Int==0?12492:12483;continue;}
case 12483:{f.Push(f.Locals[0]);f.Pc=12484;continue;}
case 12484:{return rt.Call(f,"forge/game/card/Card","isWebSlinged","()Z","invokevirtual",12487);}
case 12487:{f.Pc=f.Pop().Int!=0?14247:12490;continue;}
case 12490:{f.Push(JValue.I(0));f.Pc=12491;continue;}
case 12491:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12492:{f.Push(f.Locals[1]);f.Pc=12493;continue;}
case 12493:{f.Push(JValue.R(rt.String("CrewedThisTurn")));f.Pc=12496;continue;}
case 12496:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12499);}
case 12499:{f.Pc=f.Pop().Int==0?12515:12502;continue;}
case 12502:{f.Push(f.Locals[0]);f.Pc=12503;continue;}
case 12503:{f.Push(f.Locals[3]);f.Pc=12504;continue;}
case 12504:{return rt.Call(f,"forge/game/card/Card","getCrewedByThisTurn","()Lforge/game/card/CardCollectionView;","invokevirtual",12507);}
case 12507:{return rt.Call(f,"forge/game/card/CardProperty","hasTimestampMatch","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;)Z","invokestatic",12510);}
case 12510:{f.Pc=f.Pop().Int!=0?14247:12513;continue;}
case 12513:{f.Push(JValue.I(0));f.Pc=12514;continue;}
case 12514:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12515:{f.Push(f.Locals[1]);f.Pc=12516;continue;}
case 12516:{f.Push(JValue.R(rt.String("CrewedBySourceThisTurn")));f.Pc=12519;continue;}
case 12519:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12522);}
case 12522:{f.Pc=f.Pop().Int==0?12538:12525;continue;}
case 12525:{f.Push(f.Locals[3]);f.Pc=12526;continue;}
case 12526:{f.Push(f.Locals[0]);f.Pc=12527;continue;}
case 12527:{return rt.Call(f,"forge/game/card/Card","getCrewedByThisTurn","()Lforge/game/card/CardCollectionView;","invokevirtual",12530);}
case 12530:{return rt.Call(f,"forge/game/card/CardProperty","hasTimestampMatch","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;)Z","invokestatic",12533);}
case 12533:{f.Pc=f.Pop().Int!=0?14247:12536;continue;}
case 12536:{f.Push(JValue.I(0));f.Pc=12537;continue;}
case 12537:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12538:{f.Push(f.Locals[1]);f.Pc=12539;continue;}
case 12539:{f.Push(JValue.R(rt.String("HasDevoured")));f.Pc=12542;continue;}
case 12542:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12545);}
case 12545:{f.Pc=f.Pop().Int==0?12562:12548;continue;}
case 12548:{f.Push(f.Locals[0]);f.Pc=12549;continue;}
case 12549:{return rt.Call(f,"forge/game/card/Card","getDevouredCards","()Lforge/game/card/CardCollectionView;","invokevirtual",12552);}
case 12552:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",12557);}
case 12557:{f.Pc=f.Pop().Int==0?14247:12560;continue;}
case 12560:{f.Push(JValue.I(0));f.Pc=12561;continue;}
case 12561:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12562:{f.Push(f.Locals[1]);f.Pc=12563;continue;}
case 12563:{f.Push(JValue.R(rt.String("harnessed")));f.Pc=12566;continue;}
case 12566:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12569);}
case 12569:{f.Pc=f.Pop().Int==0?12581:12572;continue;}
case 12572:{f.Push(f.Locals[0]);f.Pc=12573;continue;}
case 12573:{return rt.Call(f,"forge/game/card/Card","isHarnessed","()Z","invokevirtual",12576);}
case 12576:{f.Pc=f.Pop().Int!=0?14247:12579;continue;}
case 12579:{f.Push(JValue.I(0));f.Pc=12580;continue;}
case 12580:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12581:{f.Push(f.Locals[1]);f.Pc=12582;continue;}
case 12582:{f.Push(JValue.R(rt.String("IsMonstrous")));f.Pc=12585;continue;}
case 12585:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12588);}
case 12588:{f.Pc=f.Pop().Int==0?12600:12591;continue;}
case 12591:{f.Push(f.Locals[0]);f.Pc=12592;continue;}
case 12592:{return rt.Call(f,"forge/game/card/Card","isMonstrous","()Z","invokevirtual",12595);}
case 12595:{f.Pc=f.Pop().Int!=0?14247:12598;continue;}
case 12598:{f.Push(JValue.I(0));f.Pc=12599;continue;}
case 12599:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12600:{f.Push(f.Locals[1]);f.Pc=12601;continue;}
case 12601:{f.Push(JValue.R(rt.String("IsUnearthed")));f.Pc=12604;continue;}
case 12604:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12607);}
case 12607:{f.Pc=f.Pop().Int==0?12619:12610;continue;}
case 12610:{f.Push(f.Locals[0]);f.Pc=12611;continue;}
case 12611:{return rt.Call(f,"forge/game/card/Card","isUnearthed","()Z","invokevirtual",12614);}
case 12614:{f.Pc=f.Pop().Int!=0?14247:12617;continue;}
case 12617:{f.Push(JValue.I(0));f.Pc=12618;continue;}
case 12618:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12619:{f.Push(f.Locals[1]);f.Pc=12620;continue;}
case 12620:{f.Push(JValue.R(rt.String("IsRenowned")));f.Pc=12623;continue;}
case 12623:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12626);}
case 12626:{f.Pc=f.Pop().Int==0?12638:12629;continue;}
case 12629:{f.Push(f.Locals[0]);f.Pc=12630;continue;}
case 12630:{return rt.Call(f,"forge/game/card/Card","isRenowned","()Z","invokevirtual",12633);}
case 12633:{f.Pc=f.Pop().Int!=0?14247:12636;continue;}
case 12636:{f.Push(JValue.I(0));f.Pc=12637;continue;}
case 12637:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12638:{f.Push(f.Locals[1]);f.Pc=12639;continue;}
case 12639:{f.Push(JValue.R(rt.String("IsSolved")));f.Pc=12642;continue;}
case 12642:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12645);}
case 12645:{f.Pc=f.Pop().Int==0?12657:12648;continue;}
case 12648:{f.Push(f.Locals[0]);f.Pc=12649;continue;}
case 12649:{return rt.Call(f,"forge/game/card/Card","isSolved","()Z","invokevirtual",12652);}
case 12652:{f.Pc=f.Pop().Int!=0?14247:12655;continue;}
case 12655:{f.Push(JValue.I(0));f.Pc=12656;continue;}
case 12656:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12657:{f.Push(f.Locals[1]);f.Pc=12658;continue;}
case 12658:{f.Push(JValue.R(rt.String("IsSaddled")));f.Pc=12661;continue;}
case 12661:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12664);}
case 12664:{f.Pc=f.Pop().Int==0?12676:12667;continue;}
case 12667:{f.Push(f.Locals[0]);f.Pc=12668;continue;}
case 12668:{return rt.Call(f,"forge/game/card/Card","isSaddled","()Z","invokevirtual",12671);}
case 12671:{f.Pc=f.Pop().Int!=0?14247:12674;continue;}
case 12674:{f.Push(JValue.I(0));f.Pc=12675;continue;}
case 12675:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12676:{f.Push(f.Locals[1]);f.Pc=12677;continue;}
case 12677:{f.Push(JValue.R(rt.String("SaddledThisTurn")));f.Pc=12680;continue;}
case 12680:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12683);}
case 12683:{f.Pc=f.Pop().Int==0?12699:12686;continue;}
case 12686:{f.Push(f.Locals[0]);f.Pc=12687;continue;}
case 12687:{f.Push(f.Locals[3]);f.Pc=12688;continue;}
case 12688:{return rt.Call(f,"forge/game/card/Card","getSaddledByThisTurn","()Lforge/game/card/CardCollection;","invokevirtual",12691);}
case 12691:{return rt.Call(f,"forge/game/card/CardProperty","hasTimestampMatch","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;)Z","invokestatic",12694);}
case 12694:{f.Pc=f.Pop().Int!=0?14247:12697;continue;}
case 12697:{f.Push(JValue.I(0));f.Pc=12698;continue;}
case 12698:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12699:{f.Push(f.Locals[1]);f.Pc=12700;continue;}
case 12700:{f.Push(JValue.R(rt.String("VisitedThisTurn")));f.Pc=12703;continue;}
case 12703:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12706);}
case 12706:{f.Pc=f.Pop().Int==0?12718:12709;continue;}
case 12709:{f.Push(f.Locals[0]);f.Pc=12710;continue;}
case 12710:{return rt.Call(f,"forge/game/card/Card","wasVisitedThisTurn","()Z","invokevirtual",12713);}
case 12713:{f.Pc=f.Pop().Int!=0?14247:12716;continue;}
case 12716:{f.Push(JValue.I(0));f.Pc=12717;continue;}
case 12717:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12718:{f.Push(f.Locals[1]);f.Pc=12719;continue;}
case 12719:{f.Push(JValue.R(rt.String("IsSuspected")));f.Pc=12722;continue;}
case 12722:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12725);}
case 12725:{f.Pc=f.Pop().Int==0?12737:12728;continue;}
case 12728:{f.Push(f.Locals[0]);f.Pc=12729;continue;}
case 12729:{return rt.Call(f,"forge/game/card/Card","isSuspected","()Z","invokevirtual",12732);}
case 12732:{f.Pc=f.Pop().Int!=0?14247:12735;continue;}
case 12735:{f.Push(JValue.I(0));f.Pc=12736;continue;}
case 12736:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12737:{f.Push(f.Locals[1]);f.Pc=12738;continue;}
case 12738:{f.Push(JValue.R(rt.String("IsPrepared")));f.Pc=12741;continue;}
case 12741:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12744);}
case 12744:{f.Pc=f.Pop().Int==0?12756:12747;continue;}
case 12747:{f.Push(f.Locals[0]);f.Pc=12748;continue;}
case 12748:{return rt.Call(f,"forge/game/card/Card","isPrepared","()Z","invokevirtual",12751);}
case 12751:{f.Pc=f.Pop().Int!=0?14247:12754;continue;}
case 12754:{f.Push(JValue.I(0));f.Pc=12755;continue;}
case 12755:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12756:{f.Push(f.Locals[1]);f.Pc=12757;continue;}
case 12757:{f.Push(JValue.R(rt.String("IsRemembered")));f.Pc=12760;continue;}
case 12760:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12763);}
case 12763:{f.Pc=f.Pop().Int==0?12776:12766;continue;}
case 12766:{f.Push(f.Locals[3]);f.Pc=12767;continue;}
case 12767:{f.Push(f.Locals[0]);f.Pc=12768;continue;}
case 12768:{return rt.Call(f,"forge/game/card/Card","isRemembered","(Ljava/lang/Object;)Z","invokevirtual",12771);}
case 12771:{f.Pc=f.Pop().Int!=0?14247:12774;continue;}
case 12774:{f.Push(JValue.I(0));f.Pc=12775;continue;}
case 12775:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12776:{f.Push(f.Locals[1]);f.Pc=12777;continue;}
case 12777:{f.Push(JValue.R(rt.String("IsImprinted")));f.Pc=12780;continue;}
case 12780:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12783);}
case 12783:{f.Pc=f.Pop().Int==0?12796:12786;continue;}
case 12786:{f.Push(f.Locals[3]);f.Pc=12787;continue;}
case 12787:{f.Push(f.Locals[0]);f.Pc=12788;continue;}
case 12788:{return rt.Call(f,"forge/game/card/Card","hasImprintedCard","(Lforge/game/card/Card;)Z","invokevirtual",12791);}
case 12791:{f.Pc=f.Pop().Int!=0?14247:12794;continue;}
case 12794:{f.Push(JValue.I(0));f.Pc=12795;continue;}
case 12795:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12796:{f.Push(f.Locals[1]);f.Pc=12797;continue;}
case 12797:{f.Push(JValue.R(rt.String("IsGoaded")));f.Pc=12800;continue;}
case 12800:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12803);}
case 12803:{f.Pc=f.Pop().Int==0?12815:12806;continue;}
case 12806:{f.Push(f.Locals[0]);f.Pc=12807;continue;}
case 12807:{return rt.Call(f,"forge/game/card/Card","isGoaded","()Z","invokevirtual",12810);}
case 12810:{f.Pc=f.Pop().Int!=0?14247:12813;continue;}
case 12813:{f.Push(JValue.I(0));f.Pc=12814;continue;}
case 12814:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12815:{f.Push(f.Locals[1]);f.Pc=12816;continue;}
case 12816:{f.Push(JValue.R(rt.String("FullyUnlocked")));f.Pc=12819;continue;}
case 12819:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12822);}
case 12822:{f.Pc=f.Pop().Int==0?12840:12825;continue;}
case 12825:{f.Push(f.Locals[0]);f.Pc=12826;continue;}
case 12826:{return rt.Call(f,"forge/game/card/Card","getUnlockedRooms","()Ljava/util/Set;","invokevirtual",12829);}
case 12829:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",12834);}
case 12834:{f.Push(JValue.I(2));f.Pc=12835;continue;}
case 12835:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?14247:12838;continue;}
case 12838:{f.Push(JValue.I(0));f.Pc=12839;continue;}
case 12839:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12840:{f.Push(f.Locals[1]);f.Pc=12841;continue;}
case 12841:{f.Push(JValue.R(rt.String("canReceiveCounters")));f.Pc=12844;continue;}
case 12844:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",12847);}
case 12847:{f.Pc=f.Pop().Int==0?12870:12850;continue;}
case 12850:{f.Push(f.Locals[0]);f.Pc=12851;continue;}
case 12851:{f.Push(f.Locals[1]);f.Pc=12852;continue;}
case 12852:{f.Push(JValue.R(rt.String(" ")));f.Pc=12854;continue;}
case 12854:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",12857);}
case 12857:{f.Push(JValue.I(1));f.Pc=12858;continue;}
case 12858:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=12859;continue;}
case 12859:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",12862);}
case 12862:{return rt.Call(f,"forge/game/card/Card","canReceiveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",12865);}
case 12865:{f.Pc=f.Pop().Int!=0?14247:12868;continue;}
case 12868:{f.Push(JValue.I(0));f.Pc=12869;continue;}
case 12869:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12870:{f.Push(f.Locals[1]);f.Pc=12871;continue;}
case 12871:{f.Push(JValue.R(rt.String("canBeTurnedFaceUp")));f.Pc=12874;continue;}
case 12874:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12877);}
case 12877:{f.Pc=f.Pop().Int==0?12889:12880;continue;}
case 12880:{f.Push(f.Locals[0]);f.Pc=12881;continue;}
case 12881:{return rt.Call(f,"forge/game/card/Card","canBeTurnedFaceUp","()Z","invokevirtual",12884);}
case 12884:{f.Pc=f.Pop().Int!=0?14247:12887;continue;}
case 12887:{f.Push(JValue.I(0));f.Pc=12888;continue;}
case 12888:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12889:{f.Push(f.Locals[1]);f.Pc=12890;continue;}
case 12890:{f.Push(JValue.R(rt.String("canBeBeamedUp")));f.Pc=12893;continue;}
case 12893:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12896);}
case 12896:{f.Pc=f.Pop().Int==0?12910:12899;continue;}
case 12899:{f.Push(f.Locals[0]);f.Pc=12900;continue;}
case 12900:{f.Push(f.Locals[4]);f.Pc=12902;continue;}
case 12902:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantBeBeamedUp","cantBeBeamedUp","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokestatic",12905);}
case 12905:{f.Pc=f.Pop().Int==0?14247:12908;continue;}
case 12908:{f.Push(JValue.I(0));f.Pc=12909;continue;}
case 12909:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12910:{f.Push(f.Locals[1]);f.Pc=12911;continue;}
case 12911:{f.Push(JValue.R(rt.String("NoAbilities")));f.Pc=12914;continue;}
case 12914:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12917);}
case 12917:{f.Pc=f.Pop().Int==0?12929:12920;continue;}
case 12920:{f.Push(f.Locals[0]);f.Pc=12921;continue;}
case 12921:{return rt.Call(f,"forge/game/card/Card","hasNoAbilities","()Z","invokevirtual",12924);}
case 12924:{f.Pc=f.Pop().Int!=0?14247:12927;continue;}
case 12927:{f.Push(JValue.I(0));f.Pc=12928;continue;}
case 12928:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12929:{f.Push(f.Locals[1]);f.Pc=12930;continue;}
case 12930:{f.Push(JValue.R(rt.String("castKeyword")));f.Pc=12933;continue;}
case 12933:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12936);}
case 12936:{f.Pc=f.Pop().Int==0?12987:12939;continue;}
case 12939:{f.Push(f.Locals[0]);f.Pc=12940;continue;}
case 12940:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",12943);}
case 12943:{f.Locals[9]=f.Pop();f.Pc=12945;continue;}
case 12945:{f.Push(f.Locals[9]);f.Pc=12947;continue;}
case 12947:{f.Pc=f.Pop().Reference!=null?12952:12950;continue;}
case 12950:{f.Push(JValue.I(0));f.Pc=12951;continue;}
case 12951:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12952:{f.Push(f.Locals[9]);f.Pc=12954;continue;}
case 12954:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",12957);}
case 12957:{f.Pc=f.Pop().Int==0?12970:12960;continue;}
case 12960:{f.Push(f.Locals[4]);f.Pc=12962;continue;}
case 12962:{return rt.Call(f,"forge/game/CardTraitBase","isIntrinsic","()Z","invokevirtual",12965);}
case 12965:{f.Pc=f.Pop().Int!=0?12984:12968;continue;}
case 12968:{f.Push(JValue.I(0));f.Pc=12969;continue;}
case 12969:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12970:{f.Push(f.Locals[9]);f.Pc=12972;continue;}
case 12972:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",12975);}
case 12975:{f.Push(f.Locals[4]);f.Pc=12977;continue;}
case 12977:{return rt.Call(f,"forge/game/CardTraitBase","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",12980);}
case 12980:{return rt.Call(f,"java/util/Objects","equals","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",12983);}
case 12983:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12984:{f.Pc=14247;continue;}
case 12987:{f.Push(f.Locals[1]);f.Pc=12988;continue;}
case 12988:{f.Push(JValue.R(rt.String("CastSaSource")));f.Pc=12991;continue;}
case 12991:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12994);}
case 12994:{f.Pc=f.Pop().Int==0?13027:12997;continue;}
case 12997:{f.Push(f.Locals[0]);f.Pc=12998;continue;}
case 12998:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",13001);}
case 13001:{f.Locals[9]=f.Pop();f.Pc=13003;continue;}
case 13003:{f.Push(f.Locals[9]);f.Pc=13005;continue;}
case 13005:{f.Pc=f.Pop().Reference!=null?13010:13008;continue;}
case 13008:{f.Push(JValue.I(0));f.Pc=13009;continue;}
case 13009:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13010:{f.Push(f.Locals[9]);f.Pc=13012;continue;}
case 13012:{f.Push(f.Locals[3]);f.Pc=13013;continue;}
case 13013:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",13016);}
case 13016:{return rt.Call(f,"forge/game/spellability/SpellAbility","equals","(Ljava/lang/Object;)Z","invokevirtual",13019);}
case 13019:{f.Pc=f.Pop().Int!=0?13024:13022;continue;}
case 13022:{f.Push(JValue.I(0));f.Pc=13023;continue;}
case 13023:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13024:{f.Pc=14247;continue;}
case 13027:{f.Push(f.Locals[1]);f.Pc=13028;continue;}
case 13028:{f.Push(JValue.R(rt.String("CastSa")));f.Pc=13031;continue;}
case 13031:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",13034);}
case 13034:{f.Pc=f.Pop().Int==0?13077:13037;continue;}
case 13037:{f.Push(f.Locals[0]);f.Pc=13038;continue;}
case 13038:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",13041);}
case 13041:{f.Locals[9]=f.Pop();f.Pc=13043;continue;}
case 13043:{f.Push(f.Locals[9]);f.Pc=13045;continue;}
case 13045:{f.Pc=f.Pop().Reference!=null?13050:13048;continue;}
case 13048:{f.Push(JValue.I(0));f.Pc=13049;continue;}
case 13049:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13050:{f.Push(f.Locals[1]);f.Pc=13051;continue;}
case 13051:{f.Push(JValue.I(7));f.Pc=13053;continue;}
case 13053:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",13056);}
case 13056:{f.Locals[10]=f.Pop();f.Pc=13058;continue;}
case 13058:{f.Push(f.Locals[9]);f.Pc=13060;continue;}
case 13060:{f.Push(f.Locals[10]);f.Pc=13062;continue;}
case 13062:{f.Push(f.Locals[2]);f.Pc=13063;continue;}
case 13063:{f.Push(f.Locals[3]);f.Pc=13064;continue;}
case 13064:{f.Push(f.Locals[4]);f.Pc=13066;continue;}
case 13066:{return rt.Call(f,"forge/game/spellability/SpellAbility","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",13069);}
case 13069:{f.Pc=f.Pop().Int!=0?13074:13072;continue;}
case 13072:{f.Push(JValue.I(0));f.Pc=13073;continue;}
case 13073:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13074:{f.Pc=14247;continue;}
case 13077:{f.Push(f.Locals[1]);f.Pc=13078;continue;}
case 13078:{f.Push(JValue.R(rt.String("wasCastFrom")));f.Pc=13081;continue;}
case 13081:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",13084);}
case 13084:{f.Pc=f.Pop().Int==0?13249:13087;continue;}
case 13087:{f.Push(f.Locals[1]);f.Pc=13088;continue;}
case 13088:{f.Push(JValue.R(rt.String("ByYou")));f.Pc=13091;continue;}
case 13091:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",13094);}
case 13094:{f.Locals[9]=f.Pop();f.Pc=13096;continue;}
case 13096:{f.Push(f.Locals[1]);f.Pc=13097;continue;}
case 13097:{f.Push(JValue.I(11));f.Pc=13099;continue;}
case 13099:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",13102);}
case 13102:{f.Locals[10]=f.Pop();f.Pc=13104;continue;}
case 13104:{f.Push(JValue.R(null));f.Pc=13105;continue;}
case 13105:{f.Locals[11]=f.Pop();f.Pc=13107;continue;}
case 13107:{f.Push(f.Locals[1]);f.Pc=13108;continue;}
case 13108:{f.Push(JValue.R(rt.String("Your")));f.Pc=13111;continue;}
case 13111:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",13114);}
case 13114:{f.Pc=f.Pop().Int==0?13128:13117;continue;}
case 13117:{f.Push(f.Locals[10]);f.Pc=13119;continue;}
case 13119:{f.Push(JValue.I(4));f.Pc=13120;continue;}
case 13120:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",13123);}
case 13123:{f.Locals[10]=f.Pop();f.Pc=13125;continue;}
case 13125:{f.Push(f.Locals[2]);f.Pc=13126;continue;}
case 13126:{f.Locals[11]=f.Pop();f.Pc=13128;continue;}
case 13128:{f.Push(f.Locals[1]);f.Pc=13129;continue;}
case 13129:{f.Push(JValue.R(rt.String("Their")));f.Pc=13132;continue;}
case 13132:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",13135);}
case 13135:{f.Pc=f.Pop().Int==0?13150:13138;continue;}
case 13138:{f.Push(f.Locals[10]);f.Pc=13140;continue;}
case 13140:{f.Push(JValue.I(5));f.Pc=13141;continue;}
case 13141:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",13144);}
case 13144:{f.Locals[10]=f.Pop();f.Pc=13146;continue;}
case 13146:{f.Push(f.Locals[8]);f.Pc=13148;continue;}
case 13148:{f.Locals[11]=f.Pop();f.Pc=13150;continue;}
case 13150:{f.Push(f.Locals[9]);f.Pc=13152;continue;}
case 13152:{f.Pc=f.Pop().Int==0?13172:13155;continue;}
case 13155:{f.Push(f.Locals[10]);f.Pc=13157;continue;}
case 13157:{f.Push(JValue.I(0));f.Pc=13158;continue;}
case 13158:{f.Push(f.Locals[10]);f.Pc=13160;continue;}
case 13160:{f.Push(JValue.R(rt.String("ByYou")));f.Pc=13163;continue;}
case 13163:{f.Push(JValue.I(0));f.Pc=13164;continue;}
case 13164:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;I)I","invokevirtual",13167);}
case 13167:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",13170);}
case 13170:{f.Locals[10]=f.Pop();f.Pc=13172;continue;}
case 13172:{f.Push(f.Locals[10]);f.Pc=13174;continue;}
case 13174:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",13177);}
case 13177:{f.Locals[12]=f.Pop();f.Pc=13179;continue;}
case 13179:{f.Push(f.Locals[0]);f.Pc=13180;continue;}
case 13180:{return rt.Call(f,"forge/game/card/Card","getCastFrom","()Lforge/game/zone/Zone;","invokevirtual",13183);}
case 13183:{f.Pc=f.Pop().Reference==null?13244:13186;continue;}
case 13186:{f.Push(f.Locals[0]);f.Pc=13187;continue;}
case 13187:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",13190);}
case 13190:{f.Pc=f.Pop().Reference==null?13244:13193;continue;}
case 13193:{f.Push(f.Locals[11]);f.Pc=13195;continue;}
case 13195:{f.Pc=f.Pop().Reference==null?13213:13198;continue;}
case 13198:{f.Push(f.Locals[0]);f.Pc=13199;continue;}
case 13199:{return rt.Call(f,"forge/game/card/Card","getCastFrom","()Lforge/game/zone/Zone;","invokevirtual",13202);}
case 13202:{return rt.Call(f,"forge/game/zone/Zone","getPlayer","()Lforge/game/player/Player;","invokevirtual",13205);}
case 13205:{f.Push(f.Locals[11]);f.Pc=13207;continue;}
case 13207:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",13210);}
case 13210:{f.Pc=f.Pop().Int==0?13244:13213;continue;}
case 13213:{f.Push(f.Locals[9]);f.Pc=13215;continue;}
case 13215:{f.Pc=f.Pop().Int==0?13232:13218;continue;}
case 13218:{f.Push(f.Locals[2]);f.Pc=13219;continue;}
case 13219:{f.Push(f.Locals[0]);f.Pc=13220;continue;}
case 13220:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",13223);}
case 13223:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",13226);}
case 13226:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",13229);}
case 13229:{f.Pc=f.Pop().Int==0?13244:13232;continue;}
case 13232:{f.Push(f.Locals[12]);f.Pc=13234;continue;}
case 13234:{f.Push(f.Locals[0]);f.Pc=13235;continue;}
case 13235:{return rt.Call(f,"forge/game/card/Card","getCastFrom","()Lforge/game/zone/Zone;","invokevirtual",13238);}
case 13238:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",13241);}
case 13241:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?13246:13244;continue;}
case 13244:{f.Push(JValue.I(0));f.Pc=13245;continue;}
case 13245:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13246:{f.Pc=14247;continue;}
case 13249:{f.Push(f.Locals[1]);f.Pc=13250;continue;}
case 13250:{f.Push(JValue.R(rt.String("wasCast")));f.Pc=13253;continue;}
case 13253:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",13256);}
case 13256:{f.Pc=f.Pop().Int==0?13301:13259;continue;}
case 13259:{f.Push(f.Locals[0]);f.Pc=13260;continue;}
case 13260:{return rt.Call(f,"forge/game/card/Card","wasCast","()Z","invokevirtual",13263);}
case 13263:{f.Pc=f.Pop().Int!=0?13268:13266;continue;}
case 13266:{f.Push(JValue.I(0));f.Pc=13267;continue;}
case 13267:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13268:{f.Push(f.Locals[1]);f.Pc=13269;continue;}
case 13269:{f.Push(JValue.R(rt.String("ByYou")));f.Pc=13272;continue;}
case 13272:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",13275);}
case 13275:{f.Pc=f.Pop().Int==0?14247:13278;continue;}
case 13278:{f.Push(f.Locals[0]);f.Pc=13279;continue;}
case 13279:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",13282);}
case 13282:{f.Pc=f.Pop().Reference==null?14247:13285;continue;}
case 13285:{f.Push(f.Locals[2]);f.Pc=13286;continue;}
case 13286:{f.Push(f.Locals[0]);f.Pc=13287;continue;}
case 13287:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",13290);}
case 13290:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",13293);}
case 13293:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",13296);}
case 13296:{f.Pc=f.Pop().Int!=0?14247:13299;continue;}
case 13299:{f.Push(JValue.I(0));f.Pc=13300;continue;}
case 13300:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13301:{f.Push(f.Locals[1]);f.Pc=13302;continue;}
case 13302:{f.Push(JValue.R(rt.String("set")));f.Pc=13305;continue;}
case 13305:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",13308);}
case 13308:{f.Pc=f.Pop().Int==0?13373:13311;continue;}
case 13311:{f.Push(f.Locals[1]);f.Pc=13312;continue;}
case 13312:{f.Push(JValue.I(3));f.Pc=13313;continue;}
case 13313:{f.Push(JValue.I(6));f.Pc=13315;continue;}
case 13315:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",13318);}
case 13318:{f.Locals[9]=f.Pop();f.Pc=13320;continue;}
case 13320:{f.Push(f.Locals[0]);f.Pc=13321;continue;}
case 13321:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",13324);}
case 13324:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",13327);}
case 13327:{f.Pc=f.Pop().Int==0?13332:13330;continue;}
case 13330:{f.Push(JValue.I(0));f.Pc=13331;continue;}
case 13331:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13332:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",13335);}
case 13335:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",13338);}
case 13338:{f.Push(f.Locals[0]);f.Pc=13339;continue;}
case 13339:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",13342);}
case 13342:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"));f.Pc=13345;continue;}
case 13345:{return rt.Call(f,"forge/card/CardDb","getCardFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;)Lforge/item/PaperCard;","invokevirtual",13348);}
case 13348:{f.Locals[10]=f.Pop();f.Pc=13350;continue;}
case 13350:{f.Push(f.Locals[10]);f.Pc=13352;continue;}
case 13352:{f.Pc=f.Pop().Reference==null?13370:13355;continue;}
case 13355:{f.Push(f.Locals[10]);f.Pc=13357;continue;}
case 13357:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",13360);}
case 13360:{f.Push(f.Locals[9]);f.Pc=13362;continue;}
case 13362:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",13365);}
case 13365:{f.Pc=f.Pop().Int!=0?13370:13368;continue;}
case 13368:{f.Push(JValue.I(0));f.Pc=13369;continue;}
case 13369:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13370:{f.Pc=14247;continue;}
case 13373:{f.Push(f.Locals[1]);f.Pc=13374;continue;}
case 13374:{f.Push(JValue.R(rt.String("inZone")));f.Pc=13377;continue;}
case 13377:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",13380);}
case 13380:{f.Pc=f.Pop().Int==0?13425:13383;continue;}
case 13383:{f.Push(f.Locals[1]);f.Pc=13384;continue;}
case 13384:{f.Push(JValue.I(6));f.Pc=13386;continue;}
case 13386:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",13389);}
case 13389:{f.Locals[9]=f.Pop();f.Pc=13391;continue;}
case 13391:{f.Push(f.Locals[9]);f.Pc=13393;continue;}
case 13393:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",13396);}
case 13396:{f.Locals[10]=f.Pop();f.Pc=13398;continue;}
case 13398:{f.Push(f.Locals[7]);f.Pc=13400;continue;}
case 13400:{return rt.Call(f,"forge/game/card/Card","getLastKnownZone","()Lforge/game/zone/Zone;","invokevirtual",13403);}
case 13403:{f.Locals[11]=f.Pop();f.Pc=13405;continue;}
case 13405:{f.Push(f.Locals[11]);f.Pc=13407;continue;}
case 13407:{f.Pc=f.Pop().Reference==null?13420:13410;continue;}
case 13410:{f.Push(f.Locals[11]);f.Pc=13412;continue;}
case 13412:{f.Push(f.Locals[10]);f.Pc=13414;continue;}
case 13414:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",13417);}
case 13417:{f.Pc=f.Pop().Int!=0?13422:13420;continue;}
case 13420:{f.Push(JValue.I(0));f.Pc=13421;continue;}
case 13421:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13422:{f.Pc=14247;continue;}
case 13425:{f.Push(f.Locals[1]);f.Pc=13426;continue;}
case 13426:{f.Push(JValue.R(rt.String("inRealZone")));f.Pc=13429;continue;}
case 13429:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",13432);}
case 13432:{f.Pc=f.Pop().Int==0?13464:13435;continue;}
case 13435:{f.Push(f.Locals[1]);f.Pc=13436;continue;}
case 13436:{f.Push(JValue.I(10));f.Pc=13438;continue;}
case 13438:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",13441);}
case 13441:{f.Locals[9]=f.Pop();f.Pc=13443;continue;}
case 13443:{f.Push(f.Locals[9]);f.Pc=13445;continue;}
case 13445:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",13448);}
case 13448:{f.Locals[10]=f.Pop();f.Pc=13450;continue;}
case 13450:{f.Push(f.Locals[0]);f.Pc=13451;continue;}
case 13451:{f.Push(f.Locals[10]);f.Pc=13453;continue;}
case 13453:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",13456);}
case 13456:{f.Pc=f.Pop().Int!=0?13461:13459;continue;}
case 13459:{f.Push(JValue.I(0));f.Pc=13460;continue;}
case 13460:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13461:{f.Pc=14247;continue;}
case 13464:{f.Push(f.Locals[1]);f.Pc=13465;continue;}
case 13465:{f.Push(JValue.R(rt.String("IsCommander")));f.Pc=13468;continue;}
case 13468:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",13471);}
case 13471:{f.Pc=f.Pop().Int==0?13483:13474;continue;}
case 13474:{f.Push(f.Locals[0]);f.Pc=13475;continue;}
case 13475:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",13478);}
case 13478:{f.Pc=f.Pop().Int!=0?14247:13481;continue;}
case 13481:{f.Push(JValue.I(0));f.Pc=13482;continue;}
case 13482:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13483:{f.Push(f.Locals[1]);f.Pc=13484;continue;}
case 13484:{f.Push(JValue.R(rt.String("NotedFor")));f.Pc=13487;continue;}
case 13487:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",13490);}
case 13490:{f.Pc=f.Pop().Int==0?13581:13493;continue;}
case 13493:{f.Push(f.Locals[1]);f.Pc=13494;continue;}
case 13494:{f.Push(JValue.R(rt.String("NotedFor")));f.Pc=13497;continue;}
case 13497:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",13500);}
case 13500:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",13503);}
case 13503:{f.Locals[9]=f.Pop();f.Pc=13505;continue;}
case 13505:{f.Push(f.Locals[2]);f.Pc=13506;continue;}
case 13506:{f.Push(f.Locals[9]);f.Pc=13508;continue;}
case 13508:{return rt.Call(f,"forge/game/player/Player","getNotesForName","(Ljava/lang/String;)Lforge/util/collect/FCollection;","invokevirtual",13511);}
case 13511:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",13514);}
case 13514:{f.Locals[10]=f.Pop();f.Pc=13516;continue;}
case 13516:{f.Push(f.Locals[10]);f.Pc=13518;continue;}
case 13518:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13523);}
case 13523:{f.Pc=f.Pop().Int==0?13579:13526;continue;}
case 13526:{f.Push(f.Locals[10]);f.Pc=13528;continue;}
case 13528:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",13533);}
case 13533:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13536;continue;}
case 13536:{f.Locals[11]=f.Pop();f.Pc=13538;continue;}
case 13538:{f.Push(f.Locals[11]);f.Pc=13540;continue;}
case 13540:{f.Push(f.Locals[0]);f.Pc=13541;continue;}
case 13541:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",13544);}
case 13544:{return rt.DynamicCall(f,"forge/game/card/CardProperty:5251:13544:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",13549);}
case 13549:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",13552);}
case 13552:{f.Pc=f.Pop().Int==0?13557:13555;continue;}
case 13555:{f.Push(JValue.I(1));f.Pc=13556;continue;}
case 13556:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13557:{f.Push(f.Locals[11]);f.Pc=13559;continue;}
case 13559:{f.Push(f.Locals[0]);f.Pc=13560;continue;}
case 13560:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",13563);}
case 13563:{return rt.DynamicCall(f,"forge/game/card/CardProperty:5251:13563:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",13568);}
case 13568:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",13571);}
case 13571:{f.Pc=f.Pop().Int==0?13576:13574;continue;}
case 13574:{f.Push(JValue.I(1));f.Pc=13575;continue;}
case 13575:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13576:{f.Pc=13516;continue;}
case 13579:{f.Push(JValue.I(0));f.Pc=13580;continue;}
case 13580:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13581:{f.Push(f.Locals[1]);f.Pc=13582;continue;}
case 13582:{f.Push(JValue.R(rt.String("NotedColor")));f.Pc=13585;continue;}
case 13585:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",13588);}
case 13588:{f.Pc=f.Pop().Int==0?13726:13591;continue;}
case 13591:{f.Push(f.Locals[2]);f.Pc=13592;continue;}
case 13592:{return rt.Call(f,"forge/game/player/Player","getDraftNotes","()Ljava/util/Map;","invokevirtual",13595);}
case 13595:{f.Push(JValue.R(rt.String("Regicide")));f.Pc=13598;continue;}
case 13598:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13603);}
case 13603:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13606;continue;}
case 13606:{f.Locals[9]=f.Pop();f.Pc=13608;continue;}
case 13608:{f.Push(f.Locals[9]);f.Pc=13610;continue;}
case 13610:{f.Pc=f.Pop().Reference!=null?13615:13613;continue;}
case 13613:{f.Push(JValue.I(0));f.Pc=13614;continue;}
case 13614:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13615:{f.Push(f.Locals[9]);f.Pc=13617;continue;}
case 13617:{f.Push(JValue.R(rt.String("white")));f.Pc=13620;continue;}
case 13620:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",13623);}
case 13623:{f.Pc=f.Pop().Int==0?13636:13626;continue;}
case 13626:{f.Push(f.Locals[0]);f.Pc=13627;continue;}
case 13627:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",13630);}
case 13630:{return rt.Call(f,"forge/card/ColorSet","hasWhite","()Z","invokevirtual",13633);}
case 13633:{f.Pc=f.Pop().Int!=0?13720:13636;continue;}
case 13636:{f.Push(f.Locals[9]);f.Pc=13638;continue;}
case 13638:{f.Push(JValue.R(rt.String("blue")));f.Pc=13641;continue;}
case 13641:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",13644);}
case 13644:{f.Pc=f.Pop().Int==0?13657:13647;continue;}
case 13647:{f.Push(f.Locals[0]);f.Pc=13648;continue;}
case 13648:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",13651);}
case 13651:{return rt.Call(f,"forge/card/ColorSet","hasBlue","()Z","invokevirtual",13654);}
case 13654:{f.Pc=f.Pop().Int!=0?13720:13657;continue;}
case 13657:{f.Push(f.Locals[9]);f.Pc=13659;continue;}
case 13659:{f.Push(JValue.R(rt.String("black")));f.Pc=13662;continue;}
case 13662:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",13665);}
case 13665:{f.Pc=f.Pop().Int==0?13678:13668;continue;}
case 13668:{f.Push(f.Locals[0]);f.Pc=13669;continue;}
case 13669:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",13672);}
case 13672:{return rt.Call(f,"forge/card/ColorSet","hasBlack","()Z","invokevirtual",13675);}
case 13675:{f.Pc=f.Pop().Int!=0?13720:13678;continue;}
case 13678:{f.Push(f.Locals[9]);f.Pc=13680;continue;}
case 13680:{f.Push(JValue.R(rt.String("red")));f.Pc=13683;continue;}
case 13683:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",13686);}
case 13686:{f.Pc=f.Pop().Int==0?13699:13689;continue;}
case 13689:{f.Push(f.Locals[0]);f.Pc=13690;continue;}
case 13690:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",13693);}
case 13693:{return rt.Call(f,"forge/card/ColorSet","hasRed","()Z","invokevirtual",13696);}
case 13696:{f.Pc=f.Pop().Int!=0?13720:13699;continue;}
case 13699:{f.Push(f.Locals[9]);f.Pc=13701;continue;}
case 13701:{f.Push(JValue.R(rt.String("green")));f.Pc=13704;continue;}
case 13704:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",13707);}
case 13707:{f.Pc=f.Pop().Int==0?13724:13710;continue;}
case 13710:{f.Push(f.Locals[0]);f.Pc=13711;continue;}
case 13711:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",13714);}
case 13714:{return rt.Call(f,"forge/card/ColorSet","hasGreen","()Z","invokevirtual",13717);}
case 13717:{f.Pc=f.Pop().Int==0?13724:13720;continue;}
case 13720:{f.Push(JValue.I(1));f.Pc=13721;continue;}
case 13721:{f.Pc=13725;continue;}
case 13724:{f.Push(JValue.I(0));f.Pc=13725;continue;}
case 13725:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13726:{f.Push(f.Locals[1]);f.Pc=13727;continue;}
case 13727:{f.Push(JValue.R(rt.String("NotedNameNobleBanneret")));f.Pc=13730;continue;}
case 13730:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",13733);}
case 13733:{f.Pc=f.Pop().Int==0?13792:13736;continue;}
case 13736:{f.Push(f.Locals[2]);f.Pc=13737;continue;}
case 13737:{return rt.Call(f,"forge/game/player/Player","getDraftNotes","()Ljava/util/Map;","invokevirtual",13740);}
case 13740:{f.Push(JValue.R(rt.String("Noble Banneret")));f.Pc=13743;continue;}
case 13743:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13748);}
case 13748:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13751;continue;}
case 13751:{f.Locals[9]=f.Pop();f.Pc=13753;continue;}
case 13753:{f.Push(f.Locals[9]);f.Pc=13755;continue;}
case 13755:{f.Pc=f.Pop().Reference==null?13766:13758;continue;}
case 13758:{f.Push(f.Locals[9]);f.Pc=13760;continue;}
case 13760:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",13763);}
case 13763:{f.Pc=f.Pop().Int==0?13768:13766;continue;}
case 13766:{f.Push(JValue.I(0));f.Pc=13767;continue;}
case 13767:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13768:{f.Push(f.Locals[9]);f.Pc=13770;continue;}
case 13770:{f.Push(JValue.R(rt.String(";")));f.Pc=13772;continue;}
case 13772:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",13775);}
case 13775:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",13778);}
case 13778:{f.Locals[10]=f.Pop();f.Pc=13780;continue;}
case 13780:{f.Push(f.Locals[10]);f.Pc=13782;continue;}
case 13782:{f.Push(f.Locals[0]);f.Pc=13783;continue;}
case 13783:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",13786);}
case 13786:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",13791);}
case 13791:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13792:{f.Push(f.Locals[1]);f.Pc=13793;continue;}
case 13793:{f.Push(JValue.R(rt.String("NotedNameAetherSearcher")));f.Pc=13796;continue;}
case 13796:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",13799);}
case 13799:{f.Pc=f.Pop().Int==0?13858:13802;continue;}
case 13802:{f.Push(f.Locals[2]);f.Pc=13803;continue;}
case 13803:{return rt.Call(f,"forge/game/player/Player","getDraftNotes","()Ljava/util/Map;","invokevirtual",13806);}
case 13806:{f.Push(JValue.R(rt.String("Aether Searcher")));f.Pc=13809;continue;}
case 13809:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13814);}
case 13814:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13817;continue;}
case 13817:{f.Locals[9]=f.Pop();f.Pc=13819;continue;}
case 13819:{f.Push(f.Locals[9]);f.Pc=13821;continue;}
case 13821:{f.Pc=f.Pop().Reference==null?13832:13824;continue;}
case 13824:{f.Push(f.Locals[9]);f.Pc=13826;continue;}
case 13826:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",13829);}
case 13829:{f.Pc=f.Pop().Int==0?13834:13832;continue;}
case 13832:{f.Push(JValue.I(0));f.Pc=13833;continue;}
case 13833:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13834:{f.Push(f.Locals[9]);f.Pc=13836;continue;}
case 13836:{f.Push(JValue.R(rt.String(";")));f.Pc=13838;continue;}
case 13838:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",13841);}
case 13841:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",13844);}
case 13844:{f.Locals[10]=f.Pop();f.Pc=13846;continue;}
case 13846:{f.Push(f.Locals[10]);f.Pc=13848;continue;}
case 13848:{f.Push(f.Locals[0]);f.Pc=13849;continue;}
case 13849:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",13852);}
case 13852:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",13857);}
case 13857:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13858:{f.Push(f.Locals[1]);f.Pc=13859;continue;}
case 13859:{f.Push(JValue.R(rt.String("NotedNameSmugglerCaptain")));f.Pc=13862;continue;}
case 13862:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",13865);}
case 13865:{f.Pc=f.Pop().Int==0?13924:13868;continue;}
case 13868:{f.Push(f.Locals[2]);f.Pc=13869;continue;}
case 13869:{return rt.Call(f,"forge/game/player/Player","getDraftNotes","()Ljava/util/Map;","invokevirtual",13872);}
case 13872:{f.Push(JValue.R(rt.String("Smuggler Captain")));f.Pc=13875;continue;}
case 13875:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13880);}
case 13880:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13883;continue;}
case 13883:{f.Locals[9]=f.Pop();f.Pc=13885;continue;}
case 13885:{f.Push(f.Locals[9]);f.Pc=13887;continue;}
case 13887:{f.Pc=f.Pop().Reference==null?13898:13890;continue;}
case 13890:{f.Push(f.Locals[9]);f.Pc=13892;continue;}
case 13892:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",13895);}
case 13895:{f.Pc=f.Pop().Int==0?13900:13898;continue;}
case 13898:{f.Push(JValue.I(0));f.Pc=13899;continue;}
case 13899:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13900:{f.Push(f.Locals[9]);f.Pc=13902;continue;}
case 13902:{f.Push(JValue.R(rt.String(";")));f.Pc=13904;continue;}
case 13904:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",13907);}
case 13907:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",13910);}
case 13910:{f.Locals[10]=f.Pop();f.Pc=13912;continue;}
case 13912:{f.Push(f.Locals[10]);f.Pc=13914;continue;}
case 13914:{f.Push(f.Locals[0]);f.Pc=13915;continue;}
case 13915:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",13918);}
case 13918:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",13923);}
case 13923:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13924:{f.Push(f.Locals[1]);f.Pc=13925;continue;}
case 13925:{f.Push(JValue.R(rt.String("NotedGuessPhantasm")));f.Pc=13928;continue;}
case 13928:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",13931);}
case 13931:{f.Pc=f.Pop().Int==0?13970:13934;continue;}
case 13934:{f.Push(f.Locals[2]);f.Pc=13935;continue;}
case 13935:{return rt.Call(f,"forge/game/player/Player","getDraftNotes","()Ljava/util/Map;","invokevirtual",13938);}
case 13938:{f.Push(JValue.R(rt.String("Spire Phantasm")));f.Pc=13941;continue;}
case 13941:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13946);}
case 13946:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13949;continue;}
case 13949:{f.Locals[9]=f.Pop();f.Pc=13951;continue;}
case 13951:{f.Push(f.Locals[9]);f.Pc=13953;continue;}
case 13953:{f.Pc=f.Pop().Reference==null?13968:13956;continue;}
case 13956:{f.Push(f.Locals[9]);f.Pc=13958;continue;}
case 13958:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",13961);}
case 13961:{f.Pc=f.Pop().Int!=0?13968:13964;continue;}
case 13964:{f.Push(JValue.I(1));f.Pc=13965;continue;}
case 13965:{f.Pc=13969;continue;}
case 13968:{f.Push(JValue.I(0));f.Pc=13969;continue;}
case 13969:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13970:{f.Push(f.Locals[1]);f.Pc=13971;continue;}
case 13971:{f.Push(JValue.R(rt.String("NotedTypes")));f.Pc=13974;continue;}
case 13974:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",13977);}
case 13977:{f.Pc=f.Pop().Int==0?14056:13980;continue;}
case 13980:{f.Push(f.Locals[2]);f.Pc=13981;continue;}
case 13981:{return rt.Call(f,"forge/game/player/Player","getDraftNotes","()Ljava/util/Map;","invokevirtual",13984);}
case 13984:{f.Push(JValue.R(rt.String("Paliano Vanguard")));f.Pc=13987;continue;}
case 13987:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13992);}
case 13992:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13995;continue;}
case 13995:{f.Locals[9]=f.Pop();f.Pc=13997;continue;}
case 13997:{f.Push(f.Locals[9]);f.Pc=13999;continue;}
case 13999:{f.Pc=f.Pop().Reference==null?14010:14002;continue;}
case 14002:{f.Push(f.Locals[9]);f.Pc=14004;continue;}
case 14004:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",14007);}
case 14007:{f.Pc=f.Pop().Int==0?14012:14010;continue;}
case 14010:{f.Push(JValue.I(0));f.Pc=14011;continue;}
case 14011:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14012:{f.Push(f.Locals[9]);f.Pc=14014;continue;}
case 14014:{f.Push(JValue.R(rt.String(",")));f.Pc=14016;continue;}
case 14016:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",14019);}
case 14019:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",14022);}
case 14022:{f.Locals[10]=f.Pop();f.Pc=14024;continue;}
case 14024:{f.Push(f.Locals[0]);f.Pc=14025;continue;}
case 14025:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",14028);}
case 14028:{return rt.Call(f,"forge/card/CardTypeView","getCreatureTypes","()Ljava/util/Set;","invokeinterface",14033);}
case 14033:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",14038);}
case 14038:{f.Push(f.Locals[10]);f.Pc=14040;continue;}
case 14040:{f.StackOp("dup");f.Pc=14041;continue;}
case 14041:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",14044);}
case 14044:{f.StackOp("pop");f.Pc=14045;continue;}
case 14045:{return rt.DynamicCall(f,"forge/game/card/CardProperty:5251:14045:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Predicate;",14050);}
case 14050:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",14055);}
case 14055:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14056:{f.Push(f.Locals[1]);f.Pc=14057;continue;}
case 14057:{f.Push(JValue.R(rt.String("Triggered")));f.Pc=14060;continue;}
case 14060:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",14063);}
case 14063:{f.Pc=f.Pop().Int==0?14154:14066;continue;}
case 14066:{f.Push(f.Locals[4]);f.Pc=14068;continue;}
case 14068:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=14071;continue;}
case 14071:{f.Pc=f.Pop().Int==0?14152:14074;continue;}
case 14074:{f.Push(f.Locals[1]);f.Pc=14075;continue;}
case 14075:{f.Push(JValue.I(9));f.Pc=14077;continue;}
case 14077:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",14080);}
case 14080:{f.Locals[9]=f.Pop();f.Pc=14082;continue;}
case 14082:{f.Push(f.Locals[4]);f.Pc=14084;continue;}
case 14084:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14087;continue;}
case 14087:{f.Locals[10]=f.Pop();f.Pc=14089;continue;}
case 14089:{f.Push(f.Locals[10]);f.Pc=14091;continue;}
case 14091:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",14094);}
case 14094:{f.Push(f.Locals[9]);f.Pc=14096;continue;}
case 14096:{return rt.Call(f,"forge/game/ability/AbilityKey","fromString","(Ljava/lang/String;)Lforge/game/ability/AbilityKey;","invokestatic",14099);}
case 14099:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",14102);}
case 14102:{f.Locals[11]=f.Pop();f.Pc=14104;continue;}
case 14104:{f.Push(JValue.I(0));f.Pc=14105;continue;}
case 14105:{f.Locals[12]=f.Pop();f.Pc=14107;continue;}
case 14107:{f.Push(f.Locals[11]);f.Pc=14109;continue;}
case 14109:{f.Pc=f.Pop().Reference==null?14142:14112;continue;}
case 14112:{f.Push(f.Locals[11]);f.Pc=14114;continue;}
case 14114:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/CardCollection")?1:0));f.Pc=14117;continue;}
case 14117:{f.Pc=f.Pop().Int==0?14134:14120;continue;}
case 14120:{f.Push(f.Locals[11]);f.Pc=14122;continue;}
case 14122:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=14125;continue;}
case 14125:{f.Push(f.Locals[0]);f.Pc=14126;continue;}
case 14126:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",14129);}
case 14129:{f.Locals[12]=f.Pop();f.Pc=14131;continue;}
case 14131:{f.Pc=14142;continue;}
case 14134:{f.Push(f.Locals[0]);f.Pc=14135;continue;}
case 14135:{f.Push(f.Locals[11]);f.Pc=14137;continue;}
case 14137:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",14140);}
case 14140:{f.Locals[12]=f.Pop();f.Pc=14142;continue;}
case 14142:{f.Push(f.Locals[12]);f.Pc=14144;continue;}
case 14144:{f.Pc=f.Pop().Int!=0?14149:14147;continue;}
case 14147:{f.Push(JValue.I(0));f.Pc=14148;continue;}
case 14148:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14149:{f.Pc=14247;continue;}
case 14152:{f.Push(JValue.I(0));f.Pc=14153;continue;}
case 14153:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14154:{f.Push(f.Locals[1]);f.Pc=14155;continue;}
case 14155:{f.Push(JValue.R(rt.String("NotDefined")));f.Pc=14158;continue;}
case 14158:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",14161);}
case 14161:{f.Pc=f.Pop().Int==0?14196:14164;continue;}
case 14164:{f.Push(f.Locals[1]);f.Pc=14165;continue;}
case 14165:{f.Push(JValue.R(rt.String("NotDefined")));f.Pc=14168;continue;}
case 14168:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",14171);}
case 14171:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",14174);}
case 14174:{f.Locals[9]=f.Pop();f.Pc=14176;continue;}
case 14176:{f.Push(f.Locals[3]);f.Pc=14177;continue;}
case 14177:{f.Push(f.Locals[9]);f.Pc=14179;continue;}
case 14179:{f.Push(f.Locals[4]);f.Pc=14181;continue;}
case 14181:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",14184);}
case 14184:{f.Push(f.Locals[0]);f.Pc=14185;continue;}
case 14185:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",14188);}
case 14188:{f.Pc=f.Pop().Int==0?14193:14191;continue;}
case 14191:{f.Push(JValue.I(0));f.Pc=14192;continue;}
case 14192:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14193:{f.Pc=14247;continue;}
case 14196:{f.Push(f.Locals[1]);f.Pc=14197;continue;}
case 14197:{f.Push(JValue.R(rt.String("CanPayManaCost")));f.Pc=14200;continue;}
case 14200:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",14203);}
case 14203:{f.Pc=f.Pop().Int==0?14230:14206;continue;}
case 14206:{f.Push(f.Locals[4]);f.Pc=14208;continue;}
case 14208:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=14211;continue;}
case 14211:{f.Pc=f.Pop().Int!=0?14216:14214;continue;}
case 14214:{f.Push(JValue.I(0));f.Pc=14215;continue;}
case 14215:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14216:{if(!rt.EnsureInitialized(f,"forge/game/card/CardProperty$1CheckCanPayManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardProperty$1CheckCanPayManaCost")));f.Pc=14219;continue;}
case 14219:{f.StackOp("dup");f.Pc=14220;continue;}
case 14220:{f.Push(f.Locals[4]);f.Pc=14222;continue;}
case 14222:{f.Push(f.Locals[0]);f.Pc=14223;continue;}
case 14223:{return rt.Call(f,"forge/game/card/CardProperty$1CheckCanPayManaCost","<init>","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)V","invokespecial",14226);}
case 14226:{return rt.Call(f,"forge/game/card/CardProperty$1CheckCanPayManaCost","check","()Z","invokevirtual",14229);}
case 14229:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14230:{f.Push(f.Locals[0]);f.Pc=14231;continue;}
case 14231:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",14234);}
case 14234:{f.Push(f.Locals[1]);f.Pc=14235;continue;}
case 14235:{f.Push(f.Locals[2]);f.Pc=14236;continue;}
case 14236:{f.Push(f.Locals[3]);f.Pc=14237;continue;}
case 14237:{f.Push(f.Locals[4]);f.Pc=14239;continue;}
case 14239:{return rt.Call(f,"forge/game/card/CardState","hasProperty","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",14242);}
case 14242:{f.Pc=f.Pop().Int!=0?14247:14245;continue;}
case 14245:{f.Push(JValue.I(0));f.Pc=14246;continue;}
case 14246:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14247:{f.Push(JValue.I(1));f.Pc=14248;continue;}
case 14248:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5252(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?52:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?49:44;continue;}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{f.Locals[2]=f.Pop();f.Pc=46;continue;}
case 46:{f.Pc=52;continue;}
case 49:{f.Pc=15;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5253(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getCombatLKI","()Lforge/game/combat/CombatLki;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getCombatLKI","()Lforge/game/combat/CombatLki;","invokevirtual",11);}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/CombatLki","isAttacker","Z"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int!=0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5254(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","getKind","()Lforge/game/card/sticker/StickerKind;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

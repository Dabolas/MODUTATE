// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C198{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AlterAttributeEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3010,"forge/game/ability/effects/AlterAttributeEffect","<init>","()V",1,1,1,new JHandler[]{},M3010));
c.Add(new JMethod(3011,"forge/game/ability/effects/AlterAttributeEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,24,9,new JHandler[]{},M3011));
c.Add(new JMethod(3012,"forge/game/ability/effects/AlterAttributeEffect","$deserializeLambda$","(Ljava/lang/invoke/SerializedLambda;)Ljava/lang/Object;",4106,3,3,new JHandler[]{},M3012));
c.Add(new JMethod(3013,"forge/game/ability/effects/AlterAttributeEffect","lambda$resolve$b573f67e$1","(Lforge/game/card/Card;)V",4106,1,2,new JHandler[]{},M3013));
}

internal static JStep M3010(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3011(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Activate")));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("true")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{return rt.Call(f,"java/lang/Boolean","parseBoolean","(Ljava/lang/String;)Z","invokestatic",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Attributes")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Push(JValue.R(rt.String(",")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Locals[5]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/ability/effects/AlterAttributeEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",40);}
case 40:{f.Locals[6]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("Optional")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?132:51;continue;}
case 51:{f.Push(f.Locals[6]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",56);}
case 56:{f.Locals[7]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("OptionQuestion")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int==0?83:67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("OptionQuestion")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String("TARGETS")));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",80);}
case 80:{f.Pc=88;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/ability/effects/AlterAttributeEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",88);}
case 88:{f.Locals[8]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",95);}
case 95:{f.Push(JValue.I(1));f.Pc=96;continue;}
case 96:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?111:99;continue;}
case 99:{f.Push(f.Locals[6]);f.Pc=101;continue;}
case 101:{f.Push(JValue.I(0));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",105);}
case 105:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=108;continue;}
case 108:{f.Pc=112;continue;}
case 111:{f.Push(JValue.R(null));f.Pc=112;continue;}
case 112:{f.Locals[9]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",118);}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(null));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[8]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[9]);f.Pc=124;continue;}
case 124:{f.Push(JValue.R(null));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int!=0?132:131;continue;}
case 131:{return JStep.ReturnVoid;}
case 132:{f.Push(f.Locals[6]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",137);}
case 137:{f.Locals[7]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[7]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",146);}
case 146:{f.Pc=f.Pop().Int==0?1126:149;continue;}
case 149:{f.Push(f.Locals[7]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",156);}
case 156:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=159;continue;}
case 159:{f.Locals[8]=f.Pop();f.Pc=161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[8]);f.Pc=164;continue;}
case 164:{f.Push(JValue.R(null));f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",168);}
case 168:{f.Locals[9]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[9]);f.Pc=172;continue;}
case 172:{f.Pc=f.Pop().Reference==null?139:175;continue;}
case 175:{f.Push(f.Locals[8]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[9]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int==0?139:185;continue;}
case 185:{f.Push(f.Locals[9]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",190);}
case 190:{f.Pc=f.Pop().Int==0?196:193;continue;}
case 193:{f.Pc=139;continue;}
case 196:{f.Push(f.Locals[5]);f.Pc=198;continue;}
case 198:{f.Locals[10]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(f.Locals[10]);f.Pc=202;continue;}
case 202:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=203;continue;}
case 203:{f.Locals[11]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(JValue.I(0));f.Pc=206;continue;}
case 206:{f.Locals[12]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[12]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[11]);f.Pc=212;continue;}
case 212:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1118:215;continue;}
case 215:{f.Push(f.Locals[10]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[12]);f.Pc=219;continue;}
case 219:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=220;continue;}
case 220:{f.Locals[13]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(JValue.I(0));f.Pc=223;continue;}
case 223:{f.Locals[14]=f.Pop();f.Pc=225;continue;}
case 225:{f.Push(f.Locals[13]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",230);}
case 230:{f.Locals[15]=f.Pop();f.Pc=232;continue;}
case 232:{f.Push(JValue.I(-1));f.Pc=233;continue;}
case 233:{f.Locals[16]=f.Pop();f.Pc=235;continue;}
case 235:{f.Push(f.Locals[15]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",240);}
case 240:{switch(f.Pop().Int){case -1826087577:f.Pc=445;break;case -1812902875:f.Pc=396;break;case -1214908323:f.Pc=364;break;case -774139939:f.Pc=462;break;case -187353385:f.Pc=412;break;case 80066591:f.Pc=380;break;case 342026678:f.Pc=428;break;case 505242904:f.Pc=479;break;case 1183880050:f.Pc=348;break;case 1603401967:f.Pc=332;break;default:f.Pc=493;break;}continue;}
case 332:{f.Push(f.Locals[15]);f.Pc=334;continue;}
case 334:{f.Push(JValue.R(rt.String("Harnessed")));f.Pc=336;continue;}
case 336:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",339);}
case 339:{f.Pc=f.Pop().Int==0?493:342;continue;}
case 342:{f.Push(JValue.I(0));f.Pc=343;continue;}
case 343:{f.Locals[16]=f.Pop();f.Pc=345;continue;}
case 345:{f.Pc=493;continue;}
case 348:{f.Push(f.Locals[15]);f.Pc=350;continue;}
case 350:{f.Push(JValue.R(rt.String("Plotted")));f.Pc=352;continue;}
case 352:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",355);}
case 355:{f.Pc=f.Pop().Int==0?493:358;continue;}
case 358:{f.Push(JValue.I(1));f.Pc=359;continue;}
case 359:{f.Locals[16]=f.Pop();f.Pc=361;continue;}
case 361:{f.Pc=493;continue;}
case 364:{f.Push(f.Locals[15]);f.Pc=366;continue;}
case 366:{f.Push(JValue.R(rt.String("Prepared")));f.Pc=368;continue;}
case 368:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",371);}
case 371:{f.Pc=f.Pop().Int==0?493:374;continue;}
case 374:{f.Push(JValue.I(2));f.Pc=375;continue;}
case 375:{f.Locals[16]=f.Pop();f.Pc=377;continue;}
case 377:{f.Pc=493;continue;}
case 380:{f.Push(f.Locals[15]);f.Pc=382;continue;}
case 382:{f.Push(JValue.R(rt.String("Solve")));f.Pc=384;continue;}
case 384:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",387);}
case 387:{f.Pc=f.Pop().Int==0?493:390;continue;}
case 390:{f.Push(JValue.I(3));f.Pc=391;continue;}
case 391:{f.Locals[16]=f.Pop();f.Pc=393;continue;}
case 393:{f.Pc=493;continue;}
case 396:{f.Push(f.Locals[15]);f.Pc=398;continue;}
case 398:{f.Push(JValue.R(rt.String("Solved")));f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",403);}
case 403:{f.Pc=f.Pop().Int==0?493:406;continue;}
case 406:{f.Push(JValue.I(4));f.Pc=407;continue;}
case 407:{f.Locals[16]=f.Pop();f.Pc=409;continue;}
case 409:{f.Pc=493;continue;}
case 412:{f.Push(f.Locals[15]);f.Pc=414;continue;}
case 414:{f.Push(JValue.R(rt.String("Suspect")));f.Pc=416;continue;}
case 416:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",419);}
case 419:{f.Pc=f.Pop().Int==0?493:422;continue;}
case 422:{f.Push(JValue.I(5));f.Pc=423;continue;}
case 423:{f.Locals[16]=f.Pop();f.Pc=425;continue;}
case 425:{f.Pc=493;continue;}
case 428:{f.Push(f.Locals[15]);f.Pc=430;continue;}
case 430:{f.Push(JValue.R(rt.String("Suspected")));f.Pc=432;continue;}
case 432:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",435);}
case 435:{f.Pc=f.Pop().Int==0?493:438;continue;}
case 438:{f.Push(JValue.I(6));f.Pc=440;continue;}
case 440:{f.Locals[16]=f.Pop();f.Pc=442;continue;}
case 442:{f.Pc=493;continue;}
case 445:{f.Push(f.Locals[15]);f.Pc=447;continue;}
case 447:{f.Push(JValue.R(rt.String("Saddle")));f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",452);}
case 452:{f.Pc=f.Pop().Int==0?493:455;continue;}
case 455:{f.Push(JValue.I(7));f.Pc=457;continue;}
case 457:{f.Locals[16]=f.Pop();f.Pc=459;continue;}
case 459:{f.Pc=493;continue;}
case 462:{f.Push(f.Locals[15]);f.Pc=464;continue;}
case 464:{f.Push(JValue.R(rt.String("Saddled")));f.Pc=466;continue;}
case 466:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",469);}
case 469:{f.Pc=f.Pop().Int==0?493:472;continue;}
case 472:{f.Push(JValue.I(8));f.Pc=474;continue;}
case 474:{f.Locals[16]=f.Pop();f.Pc=476;continue;}
case 476:{f.Pc=493;continue;}
case 479:{f.Push(f.Locals[15]);f.Pc=481;continue;}
case 481:{f.Push(JValue.R(rt.String("Commander")));f.Pc=483;continue;}
case 483:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",486);}
case 486:{f.Pc=f.Pop().Int==0?493:489;continue;}
case 489:{f.Push(JValue.I(9));f.Pc=491;continue;}
case 491:{f.Locals[16]=f.Pop();f.Pc=493;continue;}
case 493:{f.Push(f.Locals[16]);f.Pc=495;continue;}
case 495:{switch(f.Pop().Int){case 0:f.Pc=548;break;case 1:f.Pc=560;break;case 2:f.Pc=586;break;case 3:f.Pc=779;break;case 4:f.Pc=779;break;case 5:f.Pc=831;break;case 6:f.Pc=831;break;case 7:f.Pc=843;break;case 8:f.Pc=843;break;case 9:f.Pc=910;break;default:f.Pc=1088;break;}continue;}
case 548:{f.Push(f.Locals[9]);f.Pc=550;continue;}
case 550:{f.Push(f.Locals[4]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"forge/game/card/Card","setHarnessed","(Z)Z","invokevirtual",555);}
case 555:{f.Locals[14]=f.Pop();f.Pc=557;continue;}
case 557:{f.Pc=1088;continue;}
case 560:{f.Push(f.Locals[9]);f.Pc=562;continue;}
case 562:{f.Push(f.Locals[4]);f.Pc=564;continue;}
case 564:{return rt.Call(f,"forge/game/card/Card","setPlotted","(Z)Z","invokevirtual",567);}
case 567:{f.Locals[14]=f.Pop();f.Pc=569;continue;}
case 569:{f.Push(f.Locals[3]);f.Pc=570;continue;}
case 570:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardPlotted"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardPlotted")));f.Pc=573;continue;}
case 573:{f.StackOp("dup");f.Pc=574;continue;}
case 574:{f.Push(f.Locals[8]);f.Pc=576;continue;}
case 576:{f.Push(f.Locals[2]);f.Pc=577;continue;}
case 577:{return rt.Call(f,"forge/game/event/GameEventCardPlotted","<init>","(Lforge/game/card/Card;Lforge/game/player/Player;)V","invokespecial",580);}
case 580:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",583);}
case 583:{f.Pc=1088;continue;}
case 586:{f.Push(JValue.R(null));f.Pc=587;continue;}
case 587:{f.Locals[17]=f.Pop();f.Pc=589;continue;}
case 589:{f.Push(f.Locals[4]);f.Pc=591;continue;}
case 591:{f.Pc=f.Pop().Int==0?769:594;continue;}
case 594:{f.Push(f.Locals[9]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/game/card/Card","isPrepared","()Z","invokevirtual",599);}
case 599:{f.Pc=f.Pop().Int!=0?1112:602;continue;}
case 602:{f.Push(f.Locals[9]);f.Pc=604;continue;}
case 604:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=607;continue;}
case 607:{return rt.Call(f,"forge/game/card/Card","hasState","(Lforge/card/CardStateName;)Z","invokevirtual",610);}
case 610:{f.Pc=f.Pop().Int!=0?616:613;continue;}
case 613:{f.Pc=1112;continue;}
case 616:{f.Push(f.Locals[1]);f.Pc=617;continue;}
case 617:{f.Push(f.Locals[9]);f.Pc=619;continue;}
case 619:{f.Push(f.Locals[2]);f.Pc=620;continue;}
case 620:{return rt.Call(f,"forge/game/ability/effects/CopyPermanentEffect","getProtoType","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",623);}
case 623:{f.Locals[18]=f.Pop();f.Pc=625;continue;}
case 625:{f.Push(f.Locals[18]);f.Pc=627;continue;}
case 627:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=630;continue;}
case 630:{f.Push(JValue.I(1));f.Pc=631;continue;}
case 631:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",634);}
case 634:{f.StackOp("pop");f.Pc=635;continue;}
case 635:{f.Push(f.Locals[18]);f.Pc=637;continue;}
case 637:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",640);}
case 640:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=643;continue;}
case 643:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",646);}
case 646:{f.Push(f.Locals[18]);f.Pc=648;continue;}
case 648:{return rt.Call(f,"forge/game/zone/PlayerZone","add","(Lforge/game/card/Card;)V","invokevirtual",651);}
case 651:{f.Push(JValue.R(null));f.Pc=652;continue;}
case 652:{f.Push(f.Locals[9]);f.Pc=654;continue;}
case 654:{f.Push(f.Locals[2]);f.Pc=655;continue;}
case 655:{f.Push(f.Locals[9]);f.Pc=657;continue;}
case 657:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",660);}
case 660:{return rt.DynamicCall(f,"forge/game/ability/effects/AlterAttributeEffect:3011:660:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",665);}
case 665:{f.Push(f.Locals[18]);f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",670);}
case 670:{f.Push(f.Locals[3]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",674);}
case 674:{return rt.Call(f,"forge/game/ability/effects/AlterAttributeEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;J)Lforge/game/card/Card;","invokestatic",677);}
case 677:{f.Locals[17]=f.Pop();f.Pc=679;continue;}
case 679:{f.Push(f.Locals[17]);f.Pc=681;continue;}
case 681:{f.Push(f.Locals[18]);f.Pc=683;continue;}
case 683:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",686);}
case 686:{f.Push(f.Locals[17]);f.Pc=688;continue;}
case 688:{f.Push(JValue.I(0));f.Pc=689;continue;}
case 689:{return rt.Call(f,"forge/game/card/Card","setRenderForUI","(Z)V","invokevirtual",692);}
case 692:{f.Push(JValue.R(rt.String("Mode$ SpellCast | TriggerZones$ Command | Static$ True | ValidSA$ Spell.IsRemembered")));f.Pc=694;continue;}
case 694:{f.Locals[19]=f.Pop();f.Pc=696;continue;}
case 696:{f.Push(JValue.R(rt.String("DB$ AlterAttribute | Defined$ EffectSource | Attributes$ Prepared | Activate$ False")));f.Pc=698;continue;}
case 698:{f.Locals[20]=f.Pop();f.Pc=700;continue;}
case 700:{f.Push(f.Locals[19]);f.Pc=702;continue;}
case 702:{f.Push(f.Locals[17]);f.Pc=704;continue;}
case 704:{f.Push(JValue.I(1));f.Pc=705;continue;}
case 705:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",708);}
case 708:{f.Locals[21]=f.Pop();f.Pc=710;continue;}
case 710:{f.Push(f.Locals[17]);f.Pc=712;continue;}
case 712:{f.Push(f.Locals[21]);f.Pc=714;continue;}
case 714:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",717);}
case 717:{f.StackOp("pop");f.Pc=718;continue;}
case 718:{f.Push(f.Locals[20]);f.Pc=720;continue;}
case 720:{f.Push(f.Locals[17]);f.Pc=722;continue;}
case 722:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",725);}
case 725:{f.Locals[22]=f.Pop();f.Pc=727;continue;}
case 727:{f.Push(f.Locals[21]);f.Pc=729;continue;}
case 729:{f.Push(f.Locals[22]);f.Pc=731;continue;}
case 731:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",734);}
case 734:{f.Push(JValue.R(rt.String("Mode$ Continuous | MayPlay$ True | MayPlayPlayer$ EffectSourceController | EffectZone$ Command | AffectedDefined$ Remembered | AffectedZone$ Exile")));f.Pc=737;continue;}
case 737:{f.Locals[23]=f.Pop();f.Pc=739;continue;}
case 739:{f.Push(f.Locals[17]);f.Pc=741;continue;}
case 741:{f.Push(f.Locals[23]);f.Pc=743;continue;}
case 743:{return rt.Call(f,"forge/game/card/Card","addStaticAbility","(Ljava/lang/String;)Lforge/game/staticability/StaticAbility;","invokevirtual",746);}
case 746:{f.StackOp("pop");f.Pc=747;continue;}
case 747:{f.Push(f.Locals[3]);f.Pc=748;continue;}
case 748:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",751);}
case 751:{f.Push(f.Locals[17]);f.Pc=753;continue;}
case 753:{f.Push(f.Locals[1]);f.Pc=754;continue;}
case 754:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",757);}
case 757:{f.Push(f.Locals[9]);f.Pc=759;continue;}
case 759:{f.Push(f.Locals[9]);f.Pc=761;continue;}
case 761:{return rt.DynamicCall(f,"forge/game/ability/effects/AlterAttributeEffect:3011:761:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/card/Card;)Lforge/GameCommand;",766);}
case 766:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",769);}
case 769:{f.Push(f.Locals[9]);f.Pc=771;continue;}
case 771:{f.Push(f.Locals[17]);f.Pc=773;continue;}
case 773:{return rt.Call(f,"forge/game/card/Card","setPrepared","(Lforge/game/card/Card;)V","invokevirtual",776);}
case 776:{f.Pc=1088;continue;}
case 779:{f.Push(f.Locals[9]);f.Pc=781;continue;}
case 781:{f.Push(f.Locals[4]);f.Pc=783;continue;}
case 783:{return rt.Call(f,"forge/game/card/Card","setSolved","(Z)Z","invokevirtual",786);}
case 786:{f.Locals[14]=f.Pop();f.Pc=788;continue;}
case 788:{f.Push(f.Locals[14]);f.Pc=790;continue;}
case 790:{f.Pc=f.Pop().Int==0?1088:793;continue;}
case 793:{f.Push(f.Locals[9]);f.Pc=795;continue;}
case 795:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",798);}
case 798:{f.Locals[18]=f.Pop();f.Pc=800;continue;}
case 800:{f.Push(f.Locals[18]);f.Pc=802;continue;}
case 802:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=805;continue;}
case 805:{f.Push(f.Locals[1]);f.Pc=806;continue;}
case 806:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",809);}
case 809:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",814);}
case 814:{f.StackOp("pop");f.Pc=815;continue;}
case 815:{f.Push(f.Locals[3]);f.Pc=816;continue;}
case 816:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",819);}
case 819:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","CaseSolved","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","CaseSolved","Lforge/game/trigger/TriggerType;"));f.Pc=822;continue;}
case 822:{f.Push(f.Locals[18]);f.Pc=824;continue;}
case 824:{f.Push(JValue.I(0));f.Pc=825;continue;}
case 825:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",828);}
case 828:{f.Pc=1088;continue;}
case 831:{f.Push(f.Locals[9]);f.Pc=833;continue;}
case 833:{f.Push(f.Locals[4]);f.Pc=835;continue;}
case 835:{return rt.Call(f,"forge/game/card/Card","setSuspected","(Z)Z","invokevirtual",838);}
case 838:{f.Locals[14]=f.Pop();f.Pc=840;continue;}
case 840:{f.Pc=1088;continue;}
case 843:{f.Push(f.Locals[9]);f.Pc=845;continue;}
case 845:{f.Push(f.Locals[4]);f.Pc=847;continue;}
case 847:{return rt.Call(f,"forge/game/card/Card","setSaddled","(Z)Z","invokevirtual",850);}
case 850:{f.Locals[14]=f.Pop();f.Pc=852;continue;}
case 852:{f.Push(f.Locals[14]);f.Pc=854;continue;}
case 854:{f.Pc=f.Pop().Int==0?1088:857;continue;}
case 857:{f.Push(f.Locals[1]);f.Pc=858;continue;}
case 858:{f.Push(JValue.R(rt.String("TappedCards")));f.Pc=861;continue;}
case 861:{f.Push(JValue.I(1));f.Pc=862;continue;}
case 862:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",865);}
case 865:{f.Locals[18]=f.Pop();f.Pc=867;continue;}
case 867:{f.Push(f.Locals[9]);f.Pc=869;continue;}
case 869:{f.Push(f.Locals[18]);f.Pc=871;continue;}
case 871:{return rt.Call(f,"forge/game/card/Card","addSaddledByThisTurn","(Lforge/game/card/CardCollection;)V","invokevirtual",874);}
case 874:{f.Push(f.Locals[9]);f.Pc=876;continue;}
case 876:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",879);}
case 879:{f.Locals[19]=f.Pop();f.Pc=881;continue;}
case 881:{f.Push(f.Locals[19]);f.Pc=883;continue;}
case 883:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"));f.Pc=886;continue;}
case 886:{f.Push(f.Locals[18]);f.Pc=888;continue;}
case 888:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",893);}
case 893:{f.StackOp("pop");f.Pc=894;continue;}
case 894:{f.Push(f.Locals[3]);f.Pc=895;continue;}
case 895:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",898);}
case 898:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","BecomesSaddled","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","BecomesSaddled","Lforge/game/trigger/TriggerType;"));f.Pc=901;continue;}
case 901:{f.Push(f.Locals[19]);f.Pc=903;continue;}
case 903:{f.Push(JValue.I(0));f.Pc=904;continue;}
case 904:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",907);}
case 907:{f.Pc=1088;continue;}
case 910:{f.Push(f.Locals[9]);f.Pc=912;continue;}
case 912:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",915);}
case 915:{f.Locals[18]=f.Pop();f.Pc=917;continue;}
case 917:{f.Push(f.Locals[9]);f.Pc=919;continue;}
case 919:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",922);}
case 922:{f.Push(f.Locals[4]);f.Pc=924;continue;}
case 924:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?1088:927;continue;}
case 927:{f.Push(f.Locals[18]);f.Pc=929;continue;}
case 929:{return rt.Call(f,"forge/game/player/Player","getCommanders","()Ljava/util/List;","invokevirtual",932);}
case 932:{f.Push(f.Locals[9]);f.Pc=934;continue;}
case 934:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",939);}
case 939:{f.Push(f.Locals[4]);f.Pc=941;continue;}
case 941:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?947:944;continue;}
case 944:{f.Pc=1088;continue;}
case 947:{f.Push(f.Locals[4]);f.Pc=949;continue;}
case 949:{f.Pc=f.Pop().Int==0?1033:952;continue;}
case 952:{f.Push(f.Locals[3]);f.Pc=953;continue;}
case 953:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",956);}
case 956:{return rt.Call(f,"forge/game/GameRules","hasCommander","()Z","invokevirtual",959);}
case 959:{f.Pc=f.Pop().Int!=0?981:962;continue;}
case 962:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=965;continue;}
case 965:{f.Push(JValue.R(rt.String("Commander status applied in non-commander format. Applying Commander variant.")));f.Pc=968;continue;}
case 968:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",971);}
case 971:{f.Push(f.Locals[3]);f.Pc=972;continue;}
case 972:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",975);}
case 975:{if(!rt.StaticReady(f,"forge/game/GameType","Commander","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Commander","Lforge/game/GameType;"));f.Pc=978;continue;}
case 978:{return rt.Call(f,"forge/game/GameRules","addAppliedVariant","(Lforge/game/GameType;)V","invokevirtual",981);}
case 981:{f.Push(f.Locals[18]);f.Pc=983;continue;}
case 983:{f.Push(f.Locals[9]);f.Pc=985;continue;}
case 985:{return rt.Call(f,"forge/game/player/Player","addCommander","(Lforge/game/card/Card;)V","invokevirtual",988);}
case 988:{f.Push(f.Locals[3]);f.Pc=989;continue;}
case 989:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=992;continue;}
case 992:{f.StackOp("dup");f.Pc=993;continue;}
case 993:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=996;continue;}
case 996:{f.Push(JValue.R(rt.String("%s is now %s's commander.")));f.Pc=999;continue;}
case 999:{f.Push(JValue.I(2));f.Pc=1000;continue;}
case 1000:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1003;continue;}
case 1003:{f.StackOp("dup");f.Pc=1004;continue;}
case 1004:{f.Push(JValue.I(0));f.Pc=1005;continue;}
case 1005:{f.Push(f.Locals[9]);f.Pc=1007;continue;}
case 1007:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",1010);}
case 1010:{return rt.Call(f,"forge/item/IPaperCard","getDisplayName","()Ljava/lang/String;","invokeinterface",1015);}
case 1015:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1016;continue;}
case 1016:{f.StackOp("dup");f.Pc=1017;continue;}
case 1017:{f.Push(JValue.I(1));f.Pc=1018;continue;}
case 1018:{f.Push(f.Locals[18]);f.Pc=1020;continue;}
case 1020:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1021;continue;}
case 1021:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1024);}
case 1024:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",1027);}
case 1027:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1030);}
case 1030:{f.Pc=1082;continue;}
case 1033:{f.Push(f.Locals[18]);f.Pc=1035;continue;}
case 1035:{f.Push(f.Locals[9]);f.Pc=1037;continue;}
case 1037:{return rt.Call(f,"forge/game/player/Player","removeCommander","(Lforge/game/card/Card;)V","invokevirtual",1040);}
case 1040:{f.Push(f.Locals[3]);f.Pc=1041;continue;}
case 1041:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=1044;continue;}
case 1044:{f.StackOp("dup");f.Pc=1045;continue;}
case 1045:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=1048;continue;}
case 1048:{f.Push(JValue.R(rt.String("%s is no longer %s's commander.")));f.Pc=1051;continue;}
case 1051:{f.Push(JValue.I(2));f.Pc=1052;continue;}
case 1052:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1055;continue;}
case 1055:{f.StackOp("dup");f.Pc=1056;continue;}
case 1056:{f.Push(JValue.I(0));f.Pc=1057;continue;}
case 1057:{f.Push(f.Locals[9]);f.Pc=1059;continue;}
case 1059:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",1062);}
case 1062:{return rt.Call(f,"forge/item/IPaperCard","getDisplayName","()Ljava/lang/String;","invokeinterface",1067);}
case 1067:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1068;continue;}
case 1068:{f.StackOp("dup");f.Pc=1069;continue;}
case 1069:{f.Push(JValue.I(1));f.Pc=1070;continue;}
case 1070:{f.Push(f.Locals[18]);f.Pc=1072;continue;}
case 1072:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1073;continue;}
case 1073:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1076);}
case 1076:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",1079);}
case 1079:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1082);}
case 1082:{f.Push(JValue.I(1));f.Pc=1083;continue;}
case 1083:{f.Locals[14]=f.Pop();f.Pc=1085;continue;}
case 1085:{f.Pc=1088;continue;}
case 1088:{f.Push(f.Locals[14]);f.Pc=1090;continue;}
case 1090:{f.Pc=f.Pop().Int==0?1112:1093;continue;}
case 1093:{f.Push(f.Locals[1]);f.Pc=1094;continue;}
case 1094:{f.Push(JValue.R(rt.String("RememberAltered")));f.Pc=1097;continue;}
case 1097:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1100);}
case 1100:{f.Pc=f.Pop().Int==0?1112:1103;continue;}
case 1103:{f.Push(f.Locals[1]);f.Pc=1104;continue;}
case 1104:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1107);}
case 1107:{f.Push(f.Locals[9]);f.Pc=1109;continue;}
case 1109:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1112);}
case 1112:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=1115;continue;}
case 1115:{f.Pc=208;continue;}
case 1118:{f.Push(f.Locals[9]);f.Pc=1120;continue;}
case 1120:{return rt.Call(f,"forge/game/card/Card","updateAbilityTextForView","()V","invokevirtual",1123);}
case 1123:{f.Pc=139;continue;}
case 1126:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3012(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",11);}
case 11:{switch(f.Pop().Int){case -1882053297:f.Pc=28;break;default:f.Pc=40;break;}continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("lambda$resolve$b573f67e$1")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Locals[2]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{switch(f.Pop().Int){case 0:f.Pc=60;break;default:f.Pc=148;break;}continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",64);}
case 64:{f.Push(JValue.I(6));f.Pc=66;continue;}
case 66:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?148:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?148:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Push(JValue.R(rt.String("run")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?148:95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Push(JValue.R(rt.String("()V")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?148:108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",112);}
case 112:{f.Push(JValue.R(rt.String("forge/game/ability/effects/AlterAttributeEffect")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int==0?148:121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",125);}
case 125:{f.Push(JValue.R(rt.String("(Lforge/game/card/Card;)V")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?148:134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{return rt.DynamicCall(f,"forge/game/ability/effects/AlterAttributeEffect:3012:142:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/card/Card;)Lforge/GameCommand;",147);}
case 147:{return JStep.Return(f.Pop());}
case 148:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=151;continue;}
case 151:{f.StackOp("dup");f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("Invalid lambda deserialization")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",158);}
case 158:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3013(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","setPrepared","(Lforge/game/card/Card;)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

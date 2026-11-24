// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C473{
internal static JClass Build(){var c=new JClass("forge/game/card/CardStateProperty","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(5406,"forge/game/card/CardStateProperty","<init>","()V",1,1,1,new JHandler[]{},M5406));
c.Add(new JMethod(5407,"forge/game/card/CardStateProperty","hasProperty","(Lforge/game/card/CardState;Lforge/game/player/Player;Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Z",9,12,5,new JHandler[]{},M5407));
}

internal static JStep M5406(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5407(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Source")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Locals[5]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[5]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int==0?28:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/staticability/StaticAbilityColorlessDamageSource","colorlessDamageSource","(Lforge/game/card/CardState;)Z","invokestatic",17);}
case 17:{f.Pc=f.Pop().Int==0?28:20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/card/ColorSet","C","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","C","Lforge/card/ColorSet;"));f.Pc=23;continue;}
case 23:{f.Locals[6]=f.Pop();f.Pc=25;continue;}
case 25:{f.Pc=38;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","getColor","(Lforge/game/card/CardState;)Lforge/card/ColorSet;","invokevirtual",36);}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardState","getTypeWithChanges","()Lforge/card/CardTypeView;","invokevirtual",42);}
case 42:{f.Locals[7]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("White")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int!=0?89:53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("Blue")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int!=0?89:62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("Black")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int!=0?89:71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("Red")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int!=0?89:80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("Green")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int==0?166:89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("non")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int!=0?102:98;continue;}
case 98:{f.Push(JValue.I(1));f.Pc=99;continue;}
case 99:{f.Pc=103;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{f.Locals[8]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[3]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[8]);f.Pc=108;continue;}
case 108:{f.Pc=f.Pop().Int==0?115:111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{f.Pc=116;continue;}
case 115:{f.Push(JValue.I(3));f.Pc=116;continue;}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",120);}
case 120:{f.Push(f.Locals[5]);f.Pc=122;continue;}
case 122:{f.Pc=f.Pop().Int==0?130:125;continue;}
case 125:{f.Push(JValue.I(6));f.Pc=127;continue;}
case 127:{f.Pc=131;continue;}
case 130:{f.Push(JValue.I(0));f.Pc=131;continue;}
case 131:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",135);}
case 135:{f.Locals[9]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[9]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",142);}
case 142:{f.Locals[10]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[6]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[10]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",151);}
case 151:{f.Locals[11]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[8]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[11]);f.Pc=157;continue;}
case 157:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?164:160;continue;}
case 160:{f.Push(JValue.I(1));f.Pc=161;continue;}
case 161:{f.Pc=165;continue;}
case 164:{f.Push(JValue.I(0));f.Pc=165;continue;}
case 165:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 166:{f.Push(f.Locals[3]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.String("Colorless")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",172);}
case 172:{f.Pc=f.Pop().Int==0?199:175;continue;}
case 175:{f.Push(f.Locals[3]);f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.String("non")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",181);}
case 181:{f.Locals[8]=f.Pop();f.Pc=183;continue;}
case 183:{f.Push(f.Locals[8]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[6]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",190);}
case 190:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?197:193;continue;}
case 193:{f.Push(JValue.I(1));f.Pc=194;continue;}
case 194:{f.Pc=198;continue;}
case 197:{f.Push(JValue.I(0));f.Pc=198;continue;}
case 198:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 199:{f.Push(f.Locals[3]);f.Pc=200;continue;}
case 200:{f.Push(JValue.R(rt.String("MultiColor")));f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",205);}
case 205:{f.Pc=f.Pop().Int==0?214:208;continue;}
case 208:{f.Push(f.Locals[6]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/card/ColorSet","isMulticolor","()Z","invokevirtual",213);}
case 213:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 214:{f.Push(f.Locals[3]);f.Pc=215;continue;}
case 215:{f.Push(JValue.R(rt.String("EnemyColor")));f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",220);}
case 220:{f.Pc=f.Pop().Int==0?287:223;continue;}
case 223:{f.Push(f.Locals[6]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",228);}
case 228:{f.Push(JValue.I(2));f.Pc=229;continue;}
case 229:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?234:232;continue;}
case 232:{f.Push(JValue.I(0));f.Pc=233;continue;}
case 233:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 234:{if(!rt.StaticReady(f,"forge/card/MagicColor","COLORPAIR","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","COLORPAIR","[B"));f.Pc=237;continue;}
case 237:{f.Push(JValue.I(5));f.Pc=238;continue;}
case 238:{f.Push(JValue.I(10));f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/Arrays","copyOfRange","([BII)[B","invokestatic",243);}
case 243:{f.Locals[8]=f.Pop();f.Pc=245;continue;}
case 245:{f.Push(f.Locals[8]);f.Pc=247;continue;}
case 247:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=248;continue;}
case 248:{f.Locals[9]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(JValue.I(0));f.Pc=251;continue;}
case 251:{f.Locals[10]=f.Pop();f.Pc=253;continue;}
case 253:{f.Push(f.Locals[10]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[9]);f.Pc=257;continue;}
case 257:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?285:260;continue;}
case 260:{f.Push(f.Locals[8]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[10]);f.Pc=264;continue;}
case 264:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=265;continue;}
case 265:{f.Locals[11]=f.Pop();f.Pc=267;continue;}
case 267:{f.Push(f.Locals[6]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[11]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/card/ColorSet","hasExactlyColor","(I)Z","invokevirtual",274);}
case 274:{f.Pc=f.Pop().Int==0?279:277;continue;}
case 277:{f.Push(JValue.I(1));f.Pc=278;continue;}
case 278:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 279:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=282;continue;}
case 282:{f.Pc=253;continue;}
case 285:{f.Push(JValue.I(0));f.Pc=286;continue;}
case 286:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 287:{f.Push(f.Locals[3]);f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.String("AllColors")));f.Pc=290;continue;}
case 290:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int==0?302:296;continue;}
case 296:{f.Push(f.Locals[6]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/card/ColorSet","isAllColors","()Z","invokevirtual",301);}
case 301:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 302:{f.Push(f.Locals[3]);f.Pc=303;continue;}
case 303:{f.Push(JValue.R(rt.String("MonoColor")));f.Pc=305;continue;}
case 305:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",308);}
case 308:{f.Pc=f.Pop().Int==0?317:311;continue;}
case 311:{f.Push(f.Locals[6]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/card/ColorSet","isMonoColor","()Z","invokevirtual",316);}
case 316:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 317:{f.Push(f.Locals[3]);f.Pc=318;continue;}
case 318:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=320;continue;}
case 320:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",323);}
case 323:{f.Pc=f.Pop().Int==0?354:326;continue;}
case 326:{f.Push(f.Locals[2]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",330);}
case 330:{f.Pc=f.Pop().Int==0?352:333;continue;}
case 333:{f.Push(f.Locals[6]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[2]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/card/Card","getChosenColor","()Ljava/lang/String;","invokevirtual",339);}
case 339:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",342);}
case 342:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",345);}
case 345:{f.Pc=f.Pop().Int==0?352:348;continue;}
case 348:{f.Push(JValue.I(1));f.Pc=349;continue;}
case 349:{f.Pc=353;continue;}
case 352:{f.Push(JValue.I(0));f.Pc=353;continue;}
case 353:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 354:{f.Push(f.Locals[3]);f.Pc=355;continue;}
case 355:{f.Push(JValue.R(rt.String("AnyChosenColor")));f.Pc=357;continue;}
case 357:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",360);}
case 360:{f.Pc=f.Pop().Int==0?394:363;continue;}
case 363:{f.Push(f.Locals[2]);f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",367);}
case 367:{f.Pc=f.Pop().Int==0?392:370;continue;}
case 370:{f.Push(f.Locals[6]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[2]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/card/Card","getChosenColors","()Ljava/lang/Iterable;","invokevirtual",376);}
case 376:{return rt.Call(f,"forge/card/ColorSet","fromNames","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",379);}
case 379:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",382);}
case 382:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",385);}
case 385:{f.Pc=f.Pop().Int==0?392:388;continue;}
case 388:{f.Push(JValue.I(1));f.Pc=389;continue;}
case 389:{f.Pc=393;continue;}
case 392:{f.Push(JValue.I(0));f.Pc=393;continue;}
case 393:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 394:{f.Push(f.Locals[3]);f.Pc=395;continue;}
case 395:{f.Push(JValue.R(rt.String("AssociatedWithChosenColor")));f.Pc=397;continue;}
case 397:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",400);}
case 400:{f.Pc=f.Pop().Int==0?636:403;continue;}
case 403:{f.Push(f.Locals[2]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/card/Card","getChosenColor","()Ljava/lang/String;","invokevirtual",407);}
case 407:{f.Locals[8]=f.Pop();f.Pc=409;continue;}
case 409:{f.Push(f.Locals[8]);f.Pc=411;continue;}
case 411:{f.Locals[9]=f.Pop();f.Pc=413;continue;}
case 413:{f.Push(JValue.I(-1));f.Pc=414;continue;}
case 414:{f.Locals[10]=f.Pop();f.Pc=416;continue;}
case 416:{f.Push(f.Locals[9]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",421);}
case 421:{switch(f.Pop().Int){case 112785:f.Pc=520;break;case 3027034:f.Pc=488;break;case 93818879:f.Pc=504;break;case 98619139:f.Pc=536;break;case 113101865:f.Pc=472;break;default:f.Pc=549;break;}continue;}
case 472:{f.Push(f.Locals[9]);f.Pc=474;continue;}
case 474:{f.Push(JValue.R(rt.String("white")));f.Pc=476;continue;}
case 476:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",479);}
case 479:{f.Pc=f.Pop().Int==0?549:482;continue;}
case 482:{f.Push(JValue.I(0));f.Pc=483;continue;}
case 483:{f.Locals[10]=f.Pop();f.Pc=485;continue;}
case 485:{f.Pc=549;continue;}
case 488:{f.Push(f.Locals[9]);f.Pc=490;continue;}
case 490:{f.Push(JValue.R(rt.String("blue")));f.Pc=492;continue;}
case 492:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",495);}
case 495:{f.Pc=f.Pop().Int==0?549:498;continue;}
case 498:{f.Push(JValue.I(1));f.Pc=499;continue;}
case 499:{f.Locals[10]=f.Pop();f.Pc=501;continue;}
case 501:{f.Pc=549;continue;}
case 504:{f.Push(f.Locals[9]);f.Pc=506;continue;}
case 506:{f.Push(JValue.R(rt.String("black")));f.Pc=508;continue;}
case 508:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",511);}
case 511:{f.Pc=f.Pop().Int==0?549:514;continue;}
case 514:{f.Push(JValue.I(2));f.Pc=515;continue;}
case 515:{f.Locals[10]=f.Pop();f.Pc=517;continue;}
case 517:{f.Pc=549;continue;}
case 520:{f.Push(f.Locals[9]);f.Pc=522;continue;}
case 522:{f.Push(JValue.R(rt.String("red")));f.Pc=524;continue;}
case 524:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",527);}
case 527:{f.Pc=f.Pop().Int==0?549:530;continue;}
case 530:{f.Push(JValue.I(3));f.Pc=531;continue;}
case 531:{f.Locals[10]=f.Pop();f.Pc=533;continue;}
case 533:{f.Pc=549;continue;}
case 536:{f.Push(f.Locals[9]);f.Pc=538;continue;}
case 538:{f.Push(JValue.R(rt.String("green")));f.Pc=540;continue;}
case 540:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",543);}
case 543:{f.Pc=f.Pop().Int==0?549:546;continue;}
case 546:{f.Push(JValue.I(4));f.Pc=547;continue;}
case 547:{f.Locals[10]=f.Pop();f.Pc=549;continue;}
case 549:{f.Push(f.Locals[10]);f.Pc=551;continue;}
case 551:{switch(f.Pop().Int){case 0:f.Pc=584;break;case 1:f.Pc=594;break;case 2:f.Pc=604;break;case 3:f.Pc=614;break;case 4:f.Pc=624;break;default:f.Pc=634;break;}continue;}
case 584:{f.Push(f.Locals[7]);f.Pc=586;continue;}
case 586:{f.Push(JValue.R(rt.String("Plains")));f.Pc=588;continue;}
case 588:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",593);}
case 593:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 594:{f.Push(f.Locals[7]);f.Pc=596;continue;}
case 596:{f.Push(JValue.R(rt.String("Island")));f.Pc=598;continue;}
case 598:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",603);}
case 603:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 604:{f.Push(f.Locals[7]);f.Pc=606;continue;}
case 606:{f.Push(JValue.R(rt.String("Swamp")));f.Pc=608;continue;}
case 608:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",613);}
case 613:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 614:{f.Push(f.Locals[7]);f.Pc=616;continue;}
case 616:{f.Push(JValue.R(rt.String("Mountain")));f.Pc=618;continue;}
case 618:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",623);}
case 623:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 624:{f.Push(f.Locals[7]);f.Pc=626;continue;}
case 626:{f.Push(JValue.R(rt.String("Forest")));f.Pc=628;continue;}
case 628:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",633);}
case 633:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 634:{f.Push(JValue.I(0));f.Pc=635;continue;}
case 635:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 636:{f.Push(f.Locals[3]);f.Pc=637;continue;}
case 637:{f.Push(JValue.R(rt.String("prepared")));f.Pc=639;continue;}
case 639:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",642);}
case 642:{f.Pc=f.Pop().Int==0?661:645;continue;}
case 645:{f.Push(f.Locals[0]);f.Pc=646;continue;}
case 646:{return rt.Call(f,"forge/game/card/CardState","getStateName","()Lforge/card/CardStateName;","invokevirtual",649);}
case 649:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=652;continue;}
case 652:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?659:655;continue;}
case 655:{f.Push(JValue.I(1));f.Pc=656;continue;}
case 656:{f.Pc=660;continue;}
case 659:{f.Push(JValue.I(0));f.Pc=660;continue;}
case 660:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 661:{f.Push(f.Locals[3]);f.Pc=662;continue;}
case 662:{f.Push(JValue.R(rt.String("Worthy")));f.Pc=664;continue;}
case 664:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",667);}
case 667:{f.Pc=f.Pop().Int==0?675:670;continue;}
case 670:{f.Push(f.Locals[0]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/game/card/CardState","isWorthy","()Z","invokevirtual",674);}
case 674:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 675:{f.Push(f.Locals[3]);f.Pc=676;continue;}
case 676:{f.Push(JValue.R(rt.String("Outlaw")));f.Pc=678;continue;}
case 678:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",681);}
case 681:{f.Pc=f.Pop().Int==0?692:684;continue;}
case 684:{f.Push(f.Locals[7]);f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/card/CardTypeView","isOutlaw","()Z","invokeinterface",691);}
case 691:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 692:{f.Push(f.Locals[3]);f.Pc=693;continue;}
case 693:{f.Push(JValue.R(rt.String("Party")));f.Pc=695;continue;}
case 695:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",698);}
case 698:{f.Pc=f.Pop().Int==0?709:701;continue;}
case 701:{f.Push(f.Locals[7]);f.Pc=703;continue;}
case 703:{return rt.Call(f,"forge/card/CardTypeView","isParty","()Z","invokeinterface",708);}
case 708:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 709:{f.Push(f.Locals[3]);f.Pc=710;continue;}
case 710:{f.Push(JValue.R(rt.String("non")));f.Pc=712;continue;}
case 712:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",715);}
case 715:{f.Pc=f.Pop().Int==0?739:718;continue;}
case 718:{f.Push(f.Locals[7]);f.Pc=720;continue;}
case 720:{f.Push(f.Locals[3]);f.Pc=721;continue;}
case 721:{f.Push(JValue.I(3));f.Pc=722;continue;}
case 722:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",725);}
case 725:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",730);}
case 730:{f.Pc=f.Pop().Int!=0?737:733;continue;}
case 733:{f.Push(JValue.I(1));f.Pc=734;continue;}
case 734:{f.Pc=738;continue;}
case 737:{f.Push(JValue.I(0));f.Pc=738;continue;}
case 738:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 739:{f.Push(f.Locals[3]);f.Pc=740;continue;}
case 740:{f.Push(JValue.R(rt.String("CostsPhyrexianMana")));f.Pc=742;continue;}
case 742:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",745);}
case 745:{f.Pc=f.Pop().Int==0?756:748;continue;}
case 748:{f.Push(f.Locals[0]);f.Pc=749;continue;}
case 749:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",752);}
case 752:{return rt.Call(f,"forge/card/mana/ManaCost","hasPhyrexian","()Z","invokevirtual",755);}
case 755:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 756:{f.Push(f.Locals[3]);f.Pc=757;continue;}
case 757:{f.Push(JValue.R(rt.String("CostsHybridMana")));f.Pc=759;continue;}
case 759:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",762);}
case 762:{f.Pc=f.Pop().Int==0?773:765;continue;}
case 765:{f.Push(f.Locals[0]);f.Pc=766;continue;}
case 766:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",769);}
case 769:{return rt.Call(f,"forge/card/mana/ManaCost","hasHybrid","()Z","invokevirtual",772);}
case 772:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 773:{f.Push(f.Locals[3]);f.Pc=774;continue;}
case 774:{f.Push(JValue.R(rt.String("HasSVar")));f.Pc=776;continue;}
case 776:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",779);}
case 779:{f.Pc=f.Pop().Int==0?797:782;continue;}
case 782:{f.Push(f.Locals[3]);f.Pc=783;continue;}
case 783:{f.Push(JValue.I(8));f.Pc=785;continue;}
case 785:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",788);}
case 788:{f.Locals[8]=f.Pop();f.Pc=790;continue;}
case 790:{f.Push(f.Locals[0]);f.Pc=791;continue;}
case 791:{f.Push(f.Locals[8]);f.Pc=793;continue;}
case 793:{return rt.Call(f,"forge/game/card/CardState","hasSVar","(Ljava/lang/String;)Z","invokevirtual",796);}
case 796:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 797:{f.Push(f.Locals[3]);f.Pc=798;continue;}
case 798:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=800;continue;}
case 800:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",803);}
case 803:{f.Pc=f.Pop().Int==0?857:806;continue;}
case 806:{f.Push(f.Locals[2]);f.Pc=807;continue;}
case 807:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",810);}
case 810:{f.Locals[8]=f.Pop();f.Pc=812;continue;}
case 812:{f.Push(f.Locals[8]);f.Pc=814;continue;}
case 814:{f.Push(JValue.R(rt.String("Non")));f.Pc=816;continue;}
case 816:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",819);}
case 819:{f.Pc=f.Pop().Int==0?847:822;continue;}
case 822:{f.Push(f.Locals[7]);f.Pc=824;continue;}
case 824:{f.Push(f.Locals[8]);f.Pc=826;continue;}
case 826:{f.Push(JValue.I(3));f.Pc=827;continue;}
case 827:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",830);}
case 830:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",833);}
case 833:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",838);}
case 838:{f.Pc=f.Pop().Int!=0?845:841;continue;}
case 841:{f.Push(JValue.I(1));f.Pc=842;continue;}
case 842:{f.Pc=846;continue;}
case 845:{f.Push(JValue.I(0));f.Pc=846;continue;}
case 846:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 847:{f.Push(f.Locals[7]);f.Pc=849;continue;}
case 849:{f.Push(f.Locals[8]);f.Pc=851;continue;}
case 851:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",856);}
case 856:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 857:{f.Push(f.Locals[3]);f.Pc=858;continue;}
case 858:{f.Push(JValue.R(rt.String("IsNotChosenType")));f.Pc=860;continue;}
case 860:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",863);}
case 863:{f.Pc=f.Pop().Int==0?886:866;continue;}
case 866:{f.Push(f.Locals[7]);f.Pc=868;continue;}
case 868:{f.Push(f.Locals[2]);f.Pc=869;continue;}
case 869:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",872);}
case 872:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",877);}
case 877:{f.Pc=f.Pop().Int!=0?884:880;continue;}
case 880:{f.Push(JValue.I(1));f.Pc=881;continue;}
case 881:{f.Pc=885;continue;}
case 884:{f.Push(JValue.I(0));f.Pc=885;continue;}
case 885:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 886:{f.Push(f.Locals[3]);f.Pc=887;continue;}
case 887:{f.Push(JValue.R(rt.String("ChosenType2")));f.Pc=889;continue;}
case 889:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",892);}
case 892:{f.Pc=f.Pop().Int==0?907:895;continue;}
case 895:{f.Push(f.Locals[7]);f.Pc=897;continue;}
case 897:{f.Push(f.Locals[2]);f.Pc=898;continue;}
case 898:{return rt.Call(f,"forge/game/card/Card","getChosenType2","()Ljava/lang/String;","invokevirtual",901);}
case 901:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",906);}
case 906:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 907:{f.Push(f.Locals[3]);f.Pc=908;continue;}
case 908:{f.Push(JValue.R(rt.String("NotedType")));f.Pc=910;continue;}
case 910:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",913);}
case 913:{f.Pc=f.Pop().Int==0?976:916;continue;}
case 916:{f.Push(JValue.I(0));f.Pc=917;continue;}
case 917:{f.Locals[8]=f.Pop();f.Pc=919;continue;}
case 919:{f.Push(f.Locals[2]);f.Pc=920;continue;}
case 920:{return rt.Call(f,"forge/game/card/Card","getNotedTypes","()Ljava/lang/Iterable;","invokevirtual",923);}
case 923:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",928);}
case 928:{f.Locals[9]=f.Pop();f.Pc=930;continue;}
case 930:{f.Push(f.Locals[9]);f.Pc=932;continue;}
case 932:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",937);}
case 937:{f.Pc=f.Pop().Int==0?973:940;continue;}
case 940:{f.Push(f.Locals[9]);f.Pc=942;continue;}
case 942:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",947);}
case 947:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=950;continue;}
case 950:{f.Locals[10]=f.Pop();f.Pc=952;continue;}
case 952:{f.Push(f.Locals[7]);f.Pc=954;continue;}
case 954:{f.Push(f.Locals[10]);f.Pc=956;continue;}
case 956:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",961);}
case 961:{f.Pc=f.Pop().Int==0?970:964;continue;}
case 964:{f.Push(JValue.I(1));f.Pc=965;continue;}
case 965:{f.Locals[8]=f.Pop();f.Pc=967;continue;}
case 967:{f.Pc=973;continue;}
case 970:{f.Pc=930;continue;}
case 973:{f.Push(f.Locals[8]);f.Pc=975;continue;}
case 975:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 976:{f.Push(f.Locals[3]);f.Pc=977;continue;}
case 977:{f.Push(JValue.R(rt.String("hasAbility")));f.Pc=980;continue;}
case 980:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",983);}
case 983:{f.Pc=f.Pop().Int==0?1048:986;continue;}
case 986:{f.Push(f.Locals[3]);f.Pc=987;continue;}
case 987:{f.Push(JValue.I(11));f.Pc=989;continue;}
case 989:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",992);}
case 992:{f.Locals[8]=f.Pop();f.Pc=994;continue;}
case 994:{f.Push(f.Locals[0]);f.Pc=995;continue;}
case 995:{return rt.Call(f,"forge/game/card/CardState","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",998);}
case 998:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1003);}
case 1003:{f.Locals[9]=f.Pop();f.Pc=1005;continue;}
case 1005:{f.Push(f.Locals[9]);f.Pc=1007;continue;}
case 1007:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1012);}
case 1012:{f.Pc=f.Pop().Int==0?1046:1015;continue;}
case 1015:{f.Push(f.Locals[9]);f.Pc=1017;continue;}
case 1017:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1022);}
case 1022:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1025;continue;}
case 1025:{f.Locals[10]=f.Pop();f.Pc=1027;continue;}
case 1027:{f.Push(f.Locals[10]);f.Pc=1029;continue;}
case 1029:{f.Push(f.Locals[8]);f.Pc=1031;continue;}
case 1031:{f.Push(f.Locals[1]);f.Pc=1032;continue;}
case 1032:{f.Push(f.Locals[2]);f.Pc=1033;continue;}
case 1033:{f.Push(f.Locals[4]);f.Pc=1035;continue;}
case 1035:{return rt.Call(f,"forge/game/spellability/SpellAbility","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",1038);}
case 1038:{f.Pc=f.Pop().Int==0?1043:1041;continue;}
case 1041:{f.Push(JValue.I(1));f.Pc=1042;continue;}
case 1042:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1043:{f.Pc=1005;continue;}
case 1046:{f.Push(JValue.I(0));f.Pc=1047;continue;}
case 1047:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1048:{f.Push(f.Locals[3]);f.Pc=1049;continue;}
case 1049:{f.Push(JValue.R(rt.String("hasManaAbility")));f.Pc=1052;continue;}
case 1052:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1055);}
case 1055:{f.Pc=f.Pop().Int==0?1147:1058;continue;}
case 1058:{f.Push(f.Locals[0]);f.Pc=1059;continue;}
case 1059:{return rt.Call(f,"forge/game/card/CardState","getManaAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",1062);}
case 1062:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",1067);}
case 1067:{f.Pc=f.Pop().Int!=0?1072:1070;continue;}
case 1070:{f.Push(JValue.I(1));f.Pc=1071;continue;}
case 1071:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1072:{f.Push(f.Locals[0]);f.Pc=1073;continue;}
case 1073:{return rt.Call(f,"forge/game/card/CardState","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",1076);}
case 1076:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1081);}
case 1081:{f.Locals[8]=f.Pop();f.Pc=1083;continue;}
case 1083:{f.Push(f.Locals[8]);f.Pc=1085;continue;}
case 1085:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1090);}
case 1090:{f.Pc=f.Pop().Int==0?1145:1093;continue;}
case 1093:{f.Push(f.Locals[8]);f.Pc=1095;continue;}
case 1095:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1100);}
case 1100:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1103;continue;}
case 1103:{f.Locals[9]=f.Pop();f.Pc=1105;continue;}
case 1105:{f.Push(f.Locals[9]);f.Pc=1107;continue;}
case 1107:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1110);}
case 1110:{f.Locals[10]=f.Pop();f.Pc=1112;continue;}
case 1112:{f.Push(f.Locals[10]);f.Pc=1114;continue;}
case 1114:{f.Pc=f.Pop().Reference==null?1142:1117;continue;}
case 1117:{f.Push(f.Locals[10]);f.Pc=1119;continue;}
case 1119:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",1122);}
case 1122:{f.Pc=f.Pop().Int!=0?1132:1125;continue;}
case 1125:{f.Push(f.Locals[10]);f.Pc=1127;continue;}
case 1127:{f.Push(f.Locals[9]);f.Pc=1129;continue;}
case 1129:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",1132);}
case 1132:{f.Push(f.Locals[10]);f.Pc=1134;continue;}
case 1134:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManaAbility","()Z","invokevirtual",1137);}
case 1137:{f.Pc=f.Pop().Int==0?1142:1140;continue;}
case 1140:{f.Push(JValue.I(1));f.Pc=1141;continue;}
case 1141:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1142:{f.Pc=1083;continue;}
case 1145:{f.Push(JValue.I(0));f.Pc=1146;continue;}
case 1146:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1147:{f.Push(f.Locals[3]);f.Pc=1148;continue;}
case 1148:{f.Push(JValue.R(rt.String("hasNonManaActivatedAbility")));f.Pc=1151;continue;}
case 1151:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1154);}
case 1154:{f.Pc=f.Pop().Int==0?1205:1157;continue;}
case 1157:{f.Push(f.Locals[0]);f.Pc=1158;continue;}
case 1158:{return rt.Call(f,"forge/game/card/CardState","getNonManaAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",1161);}
case 1161:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1166);}
case 1166:{f.Locals[8]=f.Pop();f.Pc=1168;continue;}
case 1168:{f.Push(f.Locals[8]);f.Pc=1170;continue;}
case 1170:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1175);}
case 1175:{f.Pc=f.Pop().Int==0?1203:1178;continue;}
case 1178:{f.Push(f.Locals[8]);f.Pc=1180;continue;}
case 1180:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1185);}
case 1185:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1188;continue;}
case 1188:{f.Locals[9]=f.Pop();f.Pc=1190;continue;}
case 1190:{f.Push(f.Locals[9]);f.Pc=1192;continue;}
case 1192:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",1195);}
case 1195:{f.Pc=f.Pop().Int==0?1200:1198;continue;}
case 1198:{f.Push(JValue.I(1));f.Pc=1199;continue;}
case 1199:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1200:{f.Pc=1168;continue;}
case 1203:{f.Push(JValue.I(0));f.Pc=1204;continue;}
case 1204:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1205:{f.Push(f.Locals[3]);f.Pc=1206;continue;}
case 1206:{f.Push(JValue.R(rt.String("cmc")));f.Pc=1209;continue;}
case 1209:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1212);}
case 1212:{f.Pc=f.Pop().Int==0?1250:1215;continue;}
case 1215:{f.Push(f.Locals[3]);f.Pc=1216;continue;}
case 1216:{f.Push(JValue.I(5));f.Pc=1217;continue;}
case 1217:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1220);}
case 1220:{f.Locals[8]=f.Pop();f.Pc=1222;continue;}
case 1222:{f.Push(f.Locals[0]);f.Pc=1223;continue;}
case 1223:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",1226);}
case 1226:{return rt.Call(f,"forge/card/mana/ManaCost","getCMC","()I","invokevirtual",1229);}
case 1229:{f.Locals[9]=f.Pop();f.Pc=1231;continue;}
case 1231:{f.Push(f.Locals[2]);f.Pc=1232;continue;}
case 1232:{f.Push(f.Locals[8]);f.Pc=1234;continue;}
case 1234:{f.Push(f.Locals[4]);f.Pc=1236;continue;}
case 1236:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1239);}
case 1239:{f.Locals[10]=f.Pop();f.Pc=1241;continue;}
case 1241:{f.Push(f.Locals[9]);f.Pc=1243;continue;}
case 1243:{f.Push(f.Locals[3]);f.Pc=1244;continue;}
case 1244:{f.Push(f.Locals[10]);f.Pc=1246;continue;}
case 1246:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1249);}
case 1249:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1250:{f.Push(f.Locals[7]);f.Pc=1252;continue;}
case 1252:{f.Push(f.Locals[3]);f.Pc=1253;continue;}
case 1253:{return rt.Call(f,"forge/card/CardTypeView","hasStringType","(Ljava/lang/String;)Z","invokeinterface",1258);}
case 1258:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

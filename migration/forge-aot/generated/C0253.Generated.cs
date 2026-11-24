// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C253{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ControlGainEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3202,"forge/game/ability/effects/ControlGainEffect","<init>","()V",1,1,1,new JHandler[]{},M3202));
c.Add(new JMethod(3203,"forge/game/ability/effects/ControlGainEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,7,3,new JHandler[]{},M3203));
c.Add(new JMethod(3204,"forge/game/ability/effects/ControlGainEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,22,9,new JHandler[]{},M3204));
c.Add(new JMethod(3205,"forge/game/ability/effects/ControlGainEffect","getLoseControlCommand","(Lforge/game/card/Card;JLforge/game/card/Card;)Lforge/GameCommand;",10,5,6,new JHandler[]{},M3205));
c.Add(new JMethod(3206,"forge/game/ability/effects/ControlGainEffect","getDefinedCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;",2,3,3,new JHandler[]{},M3206));
}

internal static JStep M3202(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3203(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("NewController")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/ability/effects/ControlGainEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?35:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",29);}
case 29:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",43);}
case 43:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",46);}
case 46:{f.Push(JValue.R(rt.String(" gains control of")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/ability/effects/ControlGainEffect","getDefinedCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",57);}
case 57:{f.Locals[4]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",66);}
case 66:{f.Pc=f.Pop().Int==0?79:69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String(" (nothing)")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Pc=158;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",86);}
case 86:{f.Locals[5]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",95);}
case 95:{f.Pc=f.Pop().Int==0?158:98;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",105);}
case 105:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=108;continue;}
case 108:{f.Locals[6]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String(" ")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",116);}
case 116:{f.StackOp("pop");f.Pc=117;continue;}
case 117:{f.Push(f.Locals[6]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",122);}
case 122:{f.Pc=f.Pop().Int==0?148:125;continue;}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("Face-down creature (")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",131);}
case 131:{f.Push(f.Locals[6]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",136);}
case 136:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",139);}
case 139:{f.Push(JValue.I(41));f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",144);}
case 144:{f.StackOp("pop");f.Pc=145;continue;}
case 145:{f.Pc=155;continue;}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[6]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",154);}
case 154:{f.StackOp("pop");f.Pc=155;continue;}
case 155:{f.Pc=88;continue;}
case 158:{f.Push(f.Locals[1]);f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("LoseControl")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int==0?323:167;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{f.Push(JValue.R(rt.String("LoseControl")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",173);}
case 173:{f.Locals[5]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[5]);f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String("EOT")));f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int==0?195:185;continue;}
case 185:{f.Push(f.Locals[2]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String(" until end of turn")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",191);}
case 191:{f.StackOp("pop");f.Pc=192;continue;}
case 192:{f.Pc=323;continue;}
case 195:{f.Push(f.Locals[5]);f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String("Untap")));f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",202);}
case 202:{f.Pc=f.Pop().Int==0?227:205;continue;}
case 205:{f.Push(f.Locals[2]);f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String(" for as long as ")));f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",211);}
case 211:{f.Push(f.Locals[1]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",215);}
case 215:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",218);}
case 218:{f.Push(JValue.R(rt.String(" remains tapped")));f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",223);}
case 223:{f.StackOp("pop");f.Pc=224;continue;}
case 224:{f.Pc=323;continue;}
case 227:{f.Push(f.Locals[5]);f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.String("LoseControl")));f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",234);}
case 234:{f.Pc=f.Pop().Int==0?254:237;continue;}
case 237:{f.Push(f.Locals[2]);f.Pc=238;continue;}
case 238:{f.Push(JValue.R(rt.String(" for as long as you control ")));f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",243);}
case 243:{f.Push(f.Locals[1]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",247);}
case 247:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",250);}
case 250:{f.StackOp("pop");f.Pc=251;continue;}
case 251:{f.Pc=323;continue;}
case 254:{f.Push(f.Locals[5]);f.Pc=256;continue;}
case 256:{f.Push(JValue.R(rt.String("LeavesPlay")));f.Pc=258;continue;}
case 258:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",261);}
case 261:{f.Pc=f.Pop().Int==0?286:264;continue;}
case 264:{f.Push(f.Locals[2]);f.Pc=265;continue;}
case 265:{f.Push(JValue.R(rt.String(" for as long as ")));f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",270);}
case 270:{f.Push(f.Locals[1]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",274);}
case 274:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",277);}
case 277:{f.Push(JValue.R(rt.String("remains on the battlefield")));f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",282);}
case 282:{f.StackOp("pop");f.Pc=283;continue;}
case 283:{f.Pc=323;continue;}
case 286:{f.Push(f.Locals[5]);f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.String("StaticCommandCheck")));f.Pc=290;continue;}
case 290:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int==0?306:296;continue;}
case 296:{f.Push(f.Locals[2]);f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.String(" for as long as that creature remains enchanted")));f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",302);}
case 302:{f.StackOp("pop");f.Pc=303;continue;}
case 303:{f.Pc=323;continue;}
case 306:{f.Push(f.Locals[5]);f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("UntilTheEndOfYourNextTurn")));f.Pc=310;continue;}
case 310:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",313);}
case 313:{f.Pc=f.Pop().Int==0?323:316;continue;}
case 316:{f.Push(f.Locals[2]);f.Pc=317;continue;}
case 317:{f.Push(JValue.R(rt.String(" until the end of your next turn")));f.Pc=319;continue;}
case 319:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",322);}
case 322:{f.StackOp("pop");f.Pc=323;continue;}
case 323:{f.Push(f.Locals[2]);f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.String(".")));f.Pc=326;continue;}
case 326:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",329);}
case 329:{f.StackOp("pop");f.Pc=330;continue;}
case 330:{f.Push(f.Locals[1]);f.Pc=331;continue;}
case 331:{f.Push(JValue.R(rt.String("Untap")));f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",336);}
case 336:{f.Pc=f.Pop().Int==0?346:339;continue;}
case 339:{f.Push(f.Locals[2]);f.Pc=340;continue;}
case 340:{f.Push(JValue.R(rt.String(" Untap it.")));f.Pc=342;continue;}
case 342:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",345);}
case 345:{f.StackOp("pop");f.Pc=346;continue;}
case 346:{f.Push(f.Locals[1]);f.Pc=347;continue;}
case 347:{f.Push(JValue.R(rt.String("AddKWs")));f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",352);}
case 352:{f.Pc=f.Pop().Int==0?372:355;continue;}
case 355:{f.Push(f.Locals[1]);f.Pc=356;continue;}
case 356:{f.Push(JValue.R(rt.String("AddKWs")));f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",361);}
case 361:{f.Push(JValue.R(rt.String(" & ")));f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",366);}
case 366:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",369);}
case 369:{f.Pc=373;continue;}
case 372:{f.Push(JValue.R(null));f.Pc=373;continue;}
case 373:{f.Locals[5]=f.Pop();f.Pc=375;continue;}
case 375:{f.Push(f.Locals[1]);f.Pc=376;continue;}
case 376:{f.Push(JValue.R(rt.String("AddKWs")));f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",381);}
case 381:{f.Pc=f.Pop().Int==0?530:384;continue;}
case 384:{f.Push(f.Locals[2]);f.Pc=385;continue;}
case 385:{f.Push(JValue.R(rt.String(" It gains ")));f.Pc=387;continue;}
case 387:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",390);}
case 390:{f.StackOp("pop");f.Pc=391;continue;}
case 391:{f.Push(JValue.I(0));f.Pc=392;continue;}
case 392:{f.Locals[6]=f.Pop();f.Pc=394;continue;}
case 394:{f.Push(f.Locals[6]);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[5]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",403);}
case 403:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?523:406;continue;}
case 406:{f.Push(f.Locals[2]);f.Pc=407;continue;}
case 407:{f.Push(f.Locals[5]);f.Pc=409;continue;}
case 409:{f.Push(f.Locals[6]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",416);}
case 416:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=419;continue;}
case 419:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",422);}
case 422:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",425);}
case 425:{f.StackOp("pop");f.Pc=426;continue;}
case 426:{f.Push(f.Locals[2]);f.Pc=427;continue;}
case 427:{f.Push(f.Locals[5]);f.Pc=429;continue;}
case 429:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",434);}
case 434:{f.Push(JValue.I(2));f.Pc=435;continue;}
case 435:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?457:438;continue;}
case 438:{f.Push(f.Locals[6]);f.Pc=440;continue;}
case 440:{f.Push(JValue.I(1));f.Pc=441;continue;}
case 441:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=442;continue;}
case 442:{f.Push(f.Locals[5]);f.Pc=444;continue;}
case 444:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",449);}
case 449:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?457:452;continue;}
case 452:{f.Push(JValue.R(rt.String(", ")));f.Pc=454;continue;}
case 454:{f.Pc=459;continue;}
case 457:{f.Push(JValue.R(rt.String("")));f.Pc=459;continue;}
case 459:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",462);}
case 462:{f.StackOp("pop");f.Pc=463;continue;}
case 463:{f.Push(f.Locals[2]);f.Pc=464;continue;}
case 464:{f.Push(f.Locals[5]);f.Pc=466;continue;}
case 466:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",471);}
case 471:{f.Push(JValue.I(2));f.Pc=472;continue;}
case 472:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?485:475;continue;}
case 475:{f.Push(f.Locals[6]);f.Pc=477;continue;}
case 477:{f.Pc=f.Pop().Int!=0?485:480;continue;}
case 480:{f.Push(JValue.R(rt.String(" ")));f.Pc=482;continue;}
case 482:{f.Pc=487;continue;}
case 485:{f.Push(JValue.R(rt.String("")));f.Pc=487;continue;}
case 487:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",490);}
case 490:{f.StackOp("pop");f.Pc=491;continue;}
case 491:{f.Push(f.Locals[2]);f.Pc=492;continue;}
case 492:{f.Push(f.Locals[6]);f.Pc=494;continue;}
case 494:{f.Push(JValue.I(2));f.Pc=495;continue;}
case 495:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=496;continue;}
case 496:{f.Push(f.Locals[5]);f.Pc=498;continue;}
case 498:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",503);}
case 503:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?511:506;continue;}
case 506:{f.Push(JValue.R(rt.String("and ")));f.Pc=508;continue;}
case 508:{f.Pc=513;continue;}
case 511:{f.Push(JValue.R(rt.String("")));f.Pc=513;continue;}
case 513:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",516);}
case 516:{f.StackOp("pop");f.Pc=517;continue;}
case 517:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=520;continue;}
case 520:{f.Pc=394;continue;}
case 523:{f.Push(f.Locals[2]);f.Pc=524;continue;}
case 524:{f.Push(JValue.R(rt.String(" until end of turn.")));f.Pc=526;continue;}
case 526:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",529);}
case 529:{f.StackOp("pop");f.Pc=530;continue;}
case 530:{f.Push(f.Locals[2]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",534);}
case 534:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3204(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Optional")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("RememberControlled")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",30);}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("ForgetControlled")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",38);}
case 38:{f.Locals[7]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Untap")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",46);}
case 46:{f.Locals[8]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("AddKWs")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?74:57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("AddKWs")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",63);}
case 63:{f.Push(JValue.R(rt.String(" & ")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",68);}
case 68:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",71);}
case 71:{f.Pc=75;continue;}
case 74:{f.Push(JValue.R(null));f.Pc=75;continue;}
case 75:{f.Locals[9]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("LoseControl")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int==0?103:86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("LoseControl")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",92);}
case 92:{f.Push(JValue.R(rt.String(",")));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",97);}
case 97:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",100);}
case 100:{f.Pc=104;continue;}
case 103:{f.Push(JValue.R(null));f.Pc=104;continue;}
case 104:{f.Locals[10]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[10]);f.Pc=108;continue;}
case 108:{f.Pc=f.Pop().Reference==null?131:111;continue;}
case 111:{f.Push(f.Locals[10]);f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.String("LeavesPlay")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",120);}
case 120:{f.Pc=f.Pop().Int==0?131:123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int!=0?131:130;continue;}
case 130:{return JStep.ReturnVoid;}
case 131:{f.Push(f.Locals[10]);f.Pc=133;continue;}
case 133:{f.Pc=f.Pop().Reference==null?160:136;continue;}
case 136:{f.Push(f.Locals[10]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("LoseControl")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",145);}
case 145:{f.Pc=f.Pop().Int==0?160:148;continue;}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",152);}
case 152:{f.Push(f.Locals[1]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",156);}
case 156:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?160:159;continue;}
case 159:{return JStep.ReturnVoid;}
case 160:{f.Push(f.Locals[10]);f.Pc=162;continue;}
case 162:{f.Pc=f.Pop().Reference==null?185:165;continue;}
case 165:{f.Push(f.Locals[10]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.String("Untap")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",174);}
case 174:{f.Pc=f.Pop().Int==0?185:177;continue;}
case 177:{f.Push(f.Locals[2]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",181);}
case 181:{f.Pc=f.Pop().Int!=0?185:184;continue;}
case 184:{return JStep.ReturnVoid;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("NewController")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/ability/effects/ControlGainEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",191);}
case 191:{f.Locals[11]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(f.Locals[11]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",200);}
case 200:{f.Pc=f.Pop().Int==0?207:203;continue;}
case 203:{f.Push(f.Locals[3]);f.Pc=204;continue;}
case 204:{f.Pc=218;continue;}
case 207:{f.Push(f.Locals[11]);f.Pc=209;continue;}
case 209:{f.Push(JValue.I(0));f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",215);}
case 215:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=218;continue;}
case 218:{f.Locals[12]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(f.Locals[1]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String("Choices")));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",226);}
case 226:{f.Pc=f.Pop().Int==0?355:229;continue;}
case 229:{f.Push(f.Locals[1]);f.Pc=230;continue;}
case 230:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",235);}
case 235:{f.Pc=f.Pop().Int==0?259:238;continue;}
case 238:{f.Push(f.Locals[2]);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[1]);f.Pc=240;continue;}
case 240:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",245);}
case 245:{f.Push(f.Locals[1]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",249);}
case 249:{f.Push(JValue.I(0));f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",253);}
case 253:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=256;continue;}
case 256:{f.Pc=260;continue;}
case 259:{f.Push(f.Locals[3]);f.Pc=260;continue;}
case 260:{f.Locals[14]=f.Pop();f.Pc=262;continue;}
case 262:{f.Push(f.Locals[4]);f.Pc=264;continue;}
case 264:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",270);}
case 270:{f.Push(f.Locals[1]);f.Pc=271;continue;}
case 271:{f.Push(JValue.R(rt.String("Choices")));f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",276);}
case 276:{f.Push(f.Locals[3]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[2]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[1]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",282);}
case 282:{f.Locals[15]=f.Pop();f.Pc=284;continue;}
case 284:{f.Push(f.Locals[15]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",291);}
case 291:{f.Pc=f.Pop().Int==0?295:294;continue;}
case 294:{return JStep.ReturnVoid;}
case 295:{f.Push(f.Locals[1]);f.Pc=296;continue;}
case 296:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",301);}
case 301:{f.Pc=f.Pop().Int==0?313:304;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",310);}
case 310:{f.Pc=330;continue;}
case 313:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",316);}
case 316:{f.Push(JValue.R(rt.String("lblChooseaCard")));f.Pc=318;continue;}
case 318:{f.Push(JValue.I(0));f.Pc=319;continue;}
case 319:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",325);}
case 325:{return rt.DynamicCall(f,"forge/game/ability/effects/ControlGainEffect:3204:325:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",330);}
case 330:{f.Locals[16]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[14]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",337);}
case 337:{f.Push(f.Locals[15]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[1]);f.Pc=340;continue;}
case 340:{f.Push(f.Locals[16]);f.Pc=342;continue;}
case 342:{f.Push(JValue.I(1));f.Pc=343;continue;}
case 343:{f.Push(JValue.I(1));f.Pc=344;continue;}
case 344:{f.Push(f.Locals[5]);f.Pc=346;continue;}
case 346:{f.Push(JValue.R(null));f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",350);}
case 350:{f.Locals[13]=f.Pop();f.Pc=352;continue;}
case 352:{f.Pc=362;continue;}
case 355:{f.Push(f.Locals[0]);f.Pc=356;continue;}
case 356:{f.Push(f.Locals[1]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/ability/effects/ControlGainEffect","getDefinedCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",360);}
case 360:{f.Locals[13]=f.Pop();f.Pc=362;continue;}
case 362:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=365;continue;}
case 365:{f.StackOp("dup");f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",369);}
case 369:{f.Locals[14]=f.Pop();f.Pc=371;continue;}
case 371:{f.Push(f.Locals[13]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",378);}
case 378:{f.Locals[15]=f.Pop();f.Pc=380;continue;}
case 380:{f.Push(f.Locals[15]);f.Pc=382;continue;}
case 382:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",387);}
case 387:{f.Pc=f.Pop().Int==0?993:390;continue;}
case 390:{f.Push(f.Locals[15]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",397);}
case 397:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=400;continue;}
case 400:{f.Locals[16]=f.Pop();f.Pc=402;continue;}
case 402:{f.Push(f.Locals[16]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",407);}
case 407:{f.Pc=f.Pop().Int==0?380:410;continue;}
case 410:{f.Push(f.Locals[16]);f.Pc=412;continue;}
case 412:{f.Push(f.Locals[12]);f.Pc=414;continue;}
case 414:{return rt.Call(f,"forge/game/card/Card","canBeControlledBy","(Lforge/game/player/Player;)Z","invokevirtual",417);}
case 417:{f.Pc=f.Pop().Int!=0?423:420;continue;}
case 420:{f.Pc=380;continue;}
case 423:{f.Push(f.Locals[16]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",428);}
case 428:{f.Pc=f.Pop().Int==0?434:431;continue;}
case 431:{f.Pc=380;continue;}
case 434:{f.Push(f.Locals[1]);f.Pc=435;continue;}
case 435:{f.Push(JValue.R(rt.String("Choices")));f.Pc=437;continue;}
case 437:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",440);}
case 440:{f.Pc=f.Pop().Int!=0?492:443;continue;}
case 443:{f.Push(f.Locals[5]);f.Pc=445;continue;}
case 445:{f.Pc=f.Pop().Int==0?492:448;continue;}
case 448:{f.Push(f.Locals[3]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",452);}
case 452:{f.Push(f.Locals[1]);f.Pc=453;continue;}
case 453:{f.Push(JValue.R(null));f.Pc=454;continue;}
case 454:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",457);}
case 457:{f.Push(JValue.R(rt.String("lblGainControlConfirm")));f.Pc=460;continue;}
case 460:{f.Push(JValue.I(2));f.Pc=461;continue;}
case 461:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=464;continue;}
case 464:{f.StackOp("dup");f.Pc=465;continue;}
case 465:{f.Push(JValue.I(0));f.Pc=466;continue;}
case 466:{f.Push(f.Locals[12]);f.Pc=468;continue;}
case 468:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=469;continue;}
case 469:{f.StackOp("dup");f.Pc=470;continue;}
case 470:{f.Push(JValue.I(1));f.Pc=471;continue;}
case 471:{f.Push(f.Locals[16]);f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",476);}
case 476:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",480);}
case 480:{f.Push(f.Locals[16]);f.Pc=482;continue;}
case 482:{f.Push(JValue.R(null));f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",486);}
case 486:{f.Pc=f.Pop().Int!=0?492:489;continue;}
case 489:{f.Pc=380;continue;}
case 492:{f.Push(f.Locals[16]);f.Pc=494;continue;}
case 494:{f.Push(f.Locals[2]);f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",498);}
case 498:{f.Pc=f.Pop().Int!=0?521:501;continue;}
case 501:{f.Push(f.Locals[2]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/card/Card","getGainControlTargets","()Lforge/game/card/CardCollectionView;","invokevirtual",505);}
case 505:{f.Push(f.Locals[16]);f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",512);}
case 512:{f.Pc=f.Pop().Int!=0?521:515;continue;}
case 515:{f.Push(f.Locals[2]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[16]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"forge/game/card/Card","addGainControlTarget","(Lforge/game/card/Card;)V","invokevirtual",521);}
case 521:{f.Push(f.Locals[4]);f.Pc=523;continue;}
case 523:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",526);}
case 526:{f.Locals[17]=f.Pop();f.Pc=528;continue;}
case 528:{f.Push(f.Locals[16]);f.Pc=530;continue;}
case 530:{f.Push(f.Locals[12]);f.Pc=532;continue;}
case 532:{f.Push(f.Locals[17]);f.Pc=534;continue;}
case 534:{return rt.Call(f,"forge/game/card/Card","addTempController","(Lforge/game/player/Player;J)V","invokevirtual",537);}
case 537:{f.Push(f.Locals[8]);f.Pc=539;continue;}
case 539:{f.Pc=f.Pop().Int==0?558:542;continue;}
case 542:{f.Push(f.Locals[16]);f.Pc=544;continue;}
case 544:{return rt.Call(f,"forge/game/card/Card","untap","()Z","invokevirtual",547);}
case 547:{f.Pc=f.Pop().Int==0?558:550;continue;}
case 550:{f.Push(f.Locals[14]);f.Pc=552;continue;}
case 552:{f.Push(f.Locals[16]);f.Pc=554;continue;}
case 554:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",557);}
case 557:{f.StackOp("pop");f.Pc=558;continue;}
case 558:{f.Push(f.Locals[9]);f.Pc=560;continue;}
case 560:{f.Pc=f.Pop().Reference==null?591:563;continue;}
case 563:{f.Push(f.Locals[16]);f.Pc=565;continue;}
case 565:{f.Push(f.Locals[9]);f.Pc=567;continue;}
case 567:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",570);}
case 570:{f.Push(JValue.I(0));f.Pc=571;continue;}
case 571:{f.Push(f.Locals[17]);f.Pc=573;continue;}
case 573:{f.Push(JValue.R(null));f.Pc=574;continue;}
case 574:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",577);}
case 577:{f.Push(f.Locals[4]);f.Pc=579;continue;}
case 579:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=582;continue;}
case 582:{f.StackOp("dup");f.Pc=583;continue;}
case 583:{f.Push(f.Locals[16]);f.Pc=585;continue;}
case 585:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",588);}
case 588:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",591);}
case 591:{f.Push(f.Locals[6]);f.Pc=593;continue;}
case 593:{f.Pc=f.Pop().Int==0?611:596;continue;}
case 596:{f.Push(f.Locals[2]);f.Pc=597;continue;}
case 597:{f.Push(f.Locals[16]);f.Pc=599;continue;}
case 599:{return rt.Call(f,"forge/game/card/Card","isRemembered","(Ljava/lang/Object;)Z","invokevirtual",602);}
case 602:{f.Pc=f.Pop().Int!=0?611:605;continue;}
case 605:{f.Push(f.Locals[2]);f.Pc=606;continue;}
case 606:{f.Push(f.Locals[16]);f.Pc=608;continue;}
case 608:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",611);}
case 611:{f.Push(f.Locals[7]);f.Pc=613;continue;}
case 613:{f.Pc=f.Pop().Int==0?631:616;continue;}
case 616:{f.Push(f.Locals[2]);f.Pc=617;continue;}
case 617:{f.Push(f.Locals[16]);f.Pc=619;continue;}
case 619:{return rt.Call(f,"forge/game/card/Card","isRemembered","(Ljava/lang/Object;)Z","invokevirtual",622);}
case 622:{f.Pc=f.Pop().Int==0?631:625;continue;}
case 625:{f.Push(f.Locals[2]);f.Pc=626;continue;}
case 626:{f.Push(f.Locals[16]);f.Pc=628;continue;}
case 628:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",631);}
case 631:{f.Push(f.Locals[10]);f.Pc=633;continue;}
case 633:{f.Pc=f.Pop().Reference==null?951:636;continue;}
case 636:{f.Push(f.Locals[16]);f.Pc=638;continue;}
case 638:{f.Push(f.Locals[17]);f.Pc=640;continue;}
case 640:{f.Push(f.Locals[2]);f.Pc=641;continue;}
case 641:{return rt.Call(f,"forge/game/ability/effects/ControlGainEffect","getLoseControlCommand","(Lforge/game/card/Card;JLforge/game/card/Card;)Lforge/GameCommand;","invokestatic",644);}
case 644:{f.Locals[19]=f.Pop();f.Pc=646;continue;}
case 646:{f.Push(f.Locals[10]);f.Pc=648;continue;}
case 648:{f.Push(JValue.R(rt.String("LeavesPlay")));f.Pc=650;continue;}
case 650:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",655);}
case 655:{f.Pc=f.Pop().Int==0?670:658;continue;}
case 658:{f.Push(f.Locals[2]);f.Pc=659;continue;}
case 659:{f.Push(f.Locals[16]);f.Pc=661;continue;}
case 661:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?670:664;continue;}
case 664:{f.Push(f.Locals[2]);f.Pc=665;continue;}
case 665:{f.Push(f.Locals[19]);f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",670);}
case 670:{f.Push(f.Locals[10]);f.Pc=672;continue;}
case 672:{f.Push(JValue.R(rt.String("Untap")));f.Pc=674;continue;}
case 674:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",679);}
case 679:{f.Pc=f.Pop().Int==0?688:682;continue;}
case 682:{f.Push(f.Locals[2]);f.Pc=683;continue;}
case 683:{f.Push(f.Locals[19]);f.Pc=685;continue;}
case 685:{return rt.Call(f,"forge/game/card/Card","addUntapCommand","(Lforge/GameCommand;)V","invokevirtual",688);}
case 688:{f.Push(f.Locals[10]);f.Pc=690;continue;}
case 690:{f.Push(JValue.R(rt.String("LoseControl")));f.Pc=692;continue;}
case 692:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",697);}
case 697:{f.Pc=f.Pop().Int==0?706:700;continue;}
case 700:{f.Push(f.Locals[2]);f.Pc=701;continue;}
case 701:{f.Push(f.Locals[19]);f.Pc=703;continue;}
case 703:{return rt.Call(f,"forge/game/card/Card","addChangeControllerCommand","(Lforge/GameCommand;)V","invokevirtual",706);}
case 706:{f.Push(f.Locals[10]);f.Pc=708;continue;}
case 708:{f.Push(JValue.R(rt.String("EOT")));f.Pc=710;continue;}
case 710:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",715);}
case 715:{f.Pc=f.Pop().Int==0?745:718;continue;}
case 718:{f.Push(f.Locals[4]);f.Pc=720;continue;}
case 720:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",723);}
case 723:{f.Push(f.Locals[19]);f.Pc=725;continue;}
case 725:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",728);}
case 728:{f.Push(f.Locals[16]);f.Pc=730;continue;}
case 730:{f.Push(JValue.R(rt.String("SacMe")));f.Pc=733;continue;}
case 733:{f.Push(JValue.R(rt.String("6")));f.Pc=736;continue;}
case 736:{return rt.Call(f,"java/util/Collections","singletonMap","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;","invokestatic",739);}
case 739:{f.Push(f.Locals[17]);f.Pc=741;continue;}
case 741:{f.Push(JValue.L(0));f.Pc=742;continue;}
case 742:{return rt.Call(f,"forge/game/card/Card","addChangedSVars","(Ljava/util/Map;JJ)V","invokevirtual",745);}
case 745:{f.Push(f.Locals[10]);f.Pc=747;continue;}
case 747:{f.Push(JValue.R(rt.String("EndOfCombat")));f.Pc=750;continue;}
case 750:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",755);}
case 755:{f.Pc=f.Pop().Int==0?785:758;continue;}
case 758:{f.Push(f.Locals[4]);f.Pc=760;continue;}
case 760:{return rt.Call(f,"forge/game/Game","getEndOfCombat","()Lforge/game/phase/Phase;","invokevirtual",763);}
case 763:{f.Push(f.Locals[19]);f.Pc=765;continue;}
case 765:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",768);}
case 768:{f.Push(f.Locals[16]);f.Pc=770;continue;}
case 770:{f.Push(JValue.R(rt.String("SacMe")));f.Pc=773;continue;}
case 773:{f.Push(JValue.R(rt.String("6")));f.Pc=776;continue;}
case 776:{return rt.Call(f,"java/util/Collections","singletonMap","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;","invokestatic",779);}
case 779:{f.Push(f.Locals[17]);f.Pc=781;continue;}
case 781:{f.Push(JValue.L(0));f.Pc=782;continue;}
case 782:{return rt.Call(f,"forge/game/card/Card","addChangedSVars","(Ljava/util/Map;JJ)V","invokevirtual",785);}
case 785:{f.Push(f.Locals[10]);f.Pc=787;continue;}
case 787:{f.Push(JValue.R(rt.String("StaticCommandCheck")));f.Pc=789;continue;}
case 789:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",794);}
case 794:{f.Pc=f.Pop().Int==0?847:797;continue;}
case 797:{f.Push(f.Locals[1]);f.Pc=798;continue;}
case 798:{f.Push(f.Locals[1]);f.Pc=799;continue;}
case 799:{f.Push(JValue.R(rt.String("StaticCommandCheckSVar")));f.Pc=802;continue;}
case 802:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",805);}
case 805:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",808);}
case 808:{f.Locals[20]=f.Pop();f.Pc=810;continue;}
case 810:{f.Push(f.Locals[1]);f.Pc=811;continue;}
case 811:{f.Push(JValue.R(rt.String("StaticCommandSVarCompare")));f.Pc=814;continue;}
case 814:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",817);}
case 817:{f.Locals[21]=f.Pop();f.Pc=819;continue;}
case 819:{f.Push(f.Locals[2]);f.Pc=820;continue;}
case 820:{f.Push(JValue.I(4));f.Pc=821;continue;}
case 821:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=824;continue;}
case 824:{f.StackOp("dup");f.Pc=825;continue;}
case 825:{f.Push(JValue.I(0));f.Pc=826;continue;}
case 826:{f.Push(f.Locals[20]);f.Pc=828;continue;}
case 828:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=829;continue;}
case 829:{f.StackOp("dup");f.Pc=830;continue;}
case 830:{f.Push(JValue.I(1));f.Pc=831;continue;}
case 831:{f.Push(f.Locals[21]);f.Pc=833;continue;}
case 833:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=834;continue;}
case 834:{f.StackOp("dup");f.Pc=835;continue;}
case 835:{f.Push(JValue.I(2));f.Pc=836;continue;}
case 836:{f.Push(f.Locals[16]);f.Pc=838;continue;}
case 838:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=839;continue;}
case 839:{f.StackOp("dup");f.Pc=840;continue;}
case 840:{f.Push(JValue.I(3));f.Pc=841;continue;}
case 841:{f.Push(f.Locals[19]);f.Pc=843;continue;}
case 843:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=844;continue;}
case 844:{return rt.Call(f,"forge/game/card/Card","addStaticCommandList","([Ljava/lang/Object;)V","invokevirtual",847);}
case 847:{f.Push(f.Locals[10]);f.Pc=849;continue;}
case 849:{f.Push(JValue.R(rt.String("UntilSourceUnattached")));f.Pc=852;continue;}
case 852:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",857);}
case 857:{f.Pc=f.Pop().Int==0?893:860;continue;}
case 860:{f.Push(f.Locals[1]);f.Pc=861;continue;}
case 861:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"));f.Pc=864;continue;}
case 864:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",867);}
case 867:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=870;continue;}
case 870:{f.Locals[20]=f.Pop();f.Pc=872;continue;}
case 872:{f.Push(f.Locals[20]);f.Pc=874;continue;}
case 874:{f.Push(f.Locals[19]);f.Pc=876;continue;}
case 876:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",879);}
case 879:{f.Push(f.Locals[20]);f.Pc=881;continue;}
case 881:{f.Push(f.Locals[19]);f.Pc=883;continue;}
case 883:{return rt.Call(f,"forge/game/card/Card","addPhaseOutCommand","(Lforge/GameCommand;)V","invokevirtual",886);}
case 886:{f.Push(f.Locals[20]);f.Pc=888;continue;}
case 888:{f.Push(f.Locals[19]);f.Pc=890;continue;}
case 890:{return rt.Call(f,"forge/game/card/Card","addUnattachCommand","(Lforge/GameCommand;)V","invokevirtual",893);}
case 893:{f.Push(f.Locals[10]);f.Pc=895;continue;}
case 895:{f.Push(JValue.R(rt.String("UntilTheEndOfYourNextTurn")));f.Pc=897;continue;}
case 897:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",902);}
case 902:{f.Pc=f.Pop().Int==0?951:905;continue;}
case 905:{f.Push(f.Locals[4]);f.Pc=907;continue;}
case 907:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",910);}
case 910:{f.Push(f.Locals[1]);f.Pc=911;continue;}
case 911:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",914);}
case 914:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",917);}
case 917:{f.Pc=f.Pop().Int==0?937:920;continue;}
case 920:{f.Push(f.Locals[4]);f.Pc=922;continue;}
case 922:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",925);}
case 925:{f.Push(f.Locals[1]);f.Pc=926;continue;}
case 926:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",929);}
case 929:{f.Push(f.Locals[19]);f.Pc=931;continue;}
case 931:{return rt.Call(f,"forge/game/phase/Phase","registerUntilEnd","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",934);}
case 934:{f.Pc=951;continue;}
case 937:{f.Push(f.Locals[4]);f.Pc=939;continue;}
case 939:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",942);}
case 942:{f.Push(f.Locals[1]);f.Pc=943;continue;}
case 943:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",946);}
case 946:{f.Push(f.Locals[19]);f.Pc=948;continue;}
case 948:{return rt.Call(f,"forge/game/phase/Phase","addUntilEnd","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",951);}
case 951:{f.Push(f.Locals[9]);f.Pc=953;continue;}
case 953:{f.Pc=f.Pop().Reference==null?980:956;continue;}
case 956:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/ControlGainEffect$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/ControlGainEffect$1")));f.Pc=959;continue;}
case 959:{f.StackOp("dup");f.Pc=960;continue;}
case 960:{f.Push(f.Locals[0]);f.Pc=961;continue;}
case 961:{f.Push(f.Locals[16]);f.Pc=963;continue;}
case 963:{f.Push(f.Locals[17]);f.Pc=965;continue;}
case 965:{return rt.Call(f,"forge/game/ability/effects/ControlGainEffect$1","<init>","(Lforge/game/ability/effects/ControlGainEffect;Lforge/game/card/Card;J)V","invokespecial",968);}
case 968:{f.Locals[19]=f.Pop();f.Pc=970;continue;}
case 970:{f.Push(f.Locals[4]);f.Pc=972;continue;}
case 972:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",975);}
case 975:{f.Push(f.Locals[19]);f.Pc=977;continue;}
case 977:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",980);}
case 980:{f.Push(f.Locals[4]);f.Pc=982;continue;}
case 982:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",985);}
case 985:{f.Push(f.Locals[16]);f.Pc=987;continue;}
case 987:{return rt.Call(f,"forge/game/GameAction","controllerChangeZoneCorrection","(Lforge/game/card/Card;)V","invokevirtual",990);}
case 990:{f.Pc=380;continue;}
case 993:{f.Push(f.Locals[14]);f.Pc=995;continue;}
case 995:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",998);}
case 998:{f.Pc=f.Pop().Int!=0?1049:1001;continue;}
case 1001:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1004);}
case 1004:{f.Locals[15]=f.Pop();f.Pc=1006;continue;}
case 1006:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",1009);}
case 1009:{f.Locals[16]=f.Pop();f.Pc=1011;continue;}
case 1011:{f.Push(f.Locals[16]);f.Pc=1013;continue;}
case 1013:{f.Push(f.Locals[3]);f.Pc=1014;continue;}
case 1014:{f.Push(f.Locals[14]);f.Pc=1016;continue;}
case 1016:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1021);}
case 1021:{f.StackOp("pop");f.Pc=1022;continue;}
case 1022:{f.Push(f.Locals[15]);f.Pc=1024;continue;}
case 1024:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"));f.Pc=1027;continue;}
case 1027:{f.Push(f.Locals[16]);f.Pc=1029;continue;}
case 1029:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1034);}
case 1034:{f.StackOp("pop");f.Pc=1035;continue;}
case 1035:{f.Push(f.Locals[4]);f.Pc=1037;continue;}
case 1037:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1040);}
case 1040:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"));f.Pc=1043;continue;}
case 1043:{f.Push(f.Locals[15]);f.Pc=1045;continue;}
case 1045:{f.Push(JValue.I(0));f.Pc=1046;continue;}
case 1046:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1049);}
case 1049:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3205(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/ControlGainEffect$2"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/ControlGainEffect$2")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/ability/effects/ControlGainEffect$2","<init>","(Lforge/game/card/Card;JLforge/game/card/Card;)V","invokespecial",10);}
case 10:{f.Locals[4]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3206(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("AllValid")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?37:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",25);}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("AllValid")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",36);}
case 36:{return JStep.Return(f.Pop());}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/ability/effects/ControlGainEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",41);}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

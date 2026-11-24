// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C238{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChooseNumberEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3156,"forge/game/ability/effects/ChooseNumberEffect","<init>","()V",1,1,1,new JHandler[]{},M3156));
c.Add(new JMethod(3157,"forge/game/ability/effects/ChooseNumberEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,2,new JHandler[]{},M3157));
c.Add(new JMethod(3158,"forge/game/ability/effects/ChooseNumberEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,24,9,new JHandler[]{},M3158));
}

internal static JStep M3156(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3157(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/effects/ChooseNumberEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",16);}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String(" chooses a number.")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3158(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Random")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("ChooseAnyNumber")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Secretly")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",26);}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("Min")));f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("0")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[6]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",45);}
case 45:{f.Locals[7]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("Max")));f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("99")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",55);}
case 55:{f.Locals[8]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[8]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",64);}
case 64:{f.Locals[9]=f.Pop();f.Pc=66;continue;}
case 66:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",69);}
case 69:{f.Locals[10]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{f.Locals[11]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(JValue.R(null));f.Pc=75;continue;}
case 75:{f.Locals[12]=f.Pop();f.Pc=77;continue;}
case 77:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",84);}
case 84:{f.Locals[13]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/ability/effects/ChooseNumberEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",90);}
case 90:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",93);}
case 93:{f.Locals[14]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[14]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",102);}
case 102:{f.Pc=f.Pop().Int==0?646:105;continue;}
case 105:{f.Push(f.Locals[14]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{f.Locals[15]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[15]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",122);}
case 122:{f.Pc=f.Pop().Int!=0?128:125;continue;}
case 125:{f.Pc=95;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{f.Pc=f.Pop().Int==0?179:132;continue;}
case 132:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",135);}
case 135:{f.Push(f.Locals[9]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[7]);f.Pc=139;continue;}
case 139:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=140;continue;}
case 140:{f.Push(JValue.I(1));f.Pc=141;continue;}
case 141:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",145);}
case 145:{f.Push(f.Locals[7]);f.Pc=147;continue;}
case 147:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",151);}
case 151:{f.Locals[16]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[15]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",158);}
case 158:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",161);}
case 161:{f.Push(f.Locals[1]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[15]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[16]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",169);}
case 169:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",172);}
case 172:{f.Push(JValue.R(null));f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",176);}
case 176:{f.Pc=403;continue;}
case 179:{f.Push(f.Locals[1]);f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("ListTitle")));f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",185);}
case 185:{f.Pc=f.Pop().Int==0?197:188;continue;}
case 188:{f.Push(f.Locals[1]);f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.String("ListTitle")));f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",194);}
case 194:{f.Pc=209;continue;}
case 197:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",200);}
case 200:{f.Push(JValue.R(rt.String("lblChooseNumber")));f.Pc=202;continue;}
case 202:{f.Push(JValue.I(0));f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",209);}
case 209:{f.Locals[17]=f.Pop();f.Pc=211;continue;}
case 211:{f.Push(f.Locals[4]);f.Pc=213;continue;}
case 213:{f.Pc=f.Pop().Int==0?255:216;continue;}
case 216:{f.Push(f.Locals[15]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",221);}
case 221:{f.Push(f.Locals[1]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[7]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[9]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[17]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/player/PlayerController","announceRequirements","(Lforge/game/spellability/SpellAbility;IILjava/lang/String;)Ljava/lang/Integer;","invokevirtual",231);}
case 231:{f.Locals[18]=f.Pop();f.Pc=233;continue;}
case 233:{f.Push(f.Locals[18]);f.Pc=235;continue;}
case 235:{f.Pc=f.Pop().Reference!=null?242:238;continue;}
case 238:{f.Push(JValue.I(0));f.Pc=239;continue;}
case 239:{f.Pc=247;continue;}
case 242:{f.Push(f.Locals[18]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",247);}
case 247:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",250);}
case 250:{f.Locals[16]=f.Pop();f.Pc=252;continue;}
case 252:{f.Pc=403;continue;}
case 255:{f.Push(f.Locals[1]);f.Pc=256;continue;}
case 256:{f.Push(JValue.R(rt.String("RemoveChoices")));f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",261);}
case 261:{f.Pc=f.Pop().Int==0?383:264;continue;}
case 264:{f.Push(f.Locals[7]);f.Pc=266;continue;}
case 266:{f.Locals[18]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[18]);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[9]);f.Pc=272;continue;}
case 272:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?294:275;continue;}
case 275:{f.Push(f.Locals[13]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[18]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",282);}
case 282:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",287);}
case 287:{f.StackOp("pop");f.Pc=288;continue;}
case 288:{f.Locals[18]=JValue.I(unchecked(f.Locals[18].Int+(1)));f.Pc=291;continue;}
case 291:{f.Pc=268;continue;}
case 294:{f.Push(f.Locals[2]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",298);}
case 298:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",303);}
case 303:{f.Locals[18]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[18]);f.Pc=307;continue;}
case 307:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",312);}
case 312:{f.Pc=f.Pop().Int==0?348:315;continue;}
case 315:{f.Push(f.Locals[18]);f.Pc=317;continue;}
case 317:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",322);}
case 322:{f.Locals[19]=f.Pop();f.Pc=324;continue;}
case 324:{f.Push(f.Locals[19]);f.Pc=326;continue;}
case 326:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/Integer")?1:0));f.Pc=329;continue;}
case 329:{f.Pc=f.Pop().Int==0?345:332;continue;}
case 332:{f.Push(f.Locals[13]);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[19]);f.Pc=336;continue;}
case 336:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=339;continue;}
case 339:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",344);}
case 344:{f.StackOp("pop");f.Pc=345;continue;}
case 345:{f.Pc=305;continue;}
case 348:{f.Push(f.Locals[13]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",355);}
case 355:{f.Pc=f.Pop().Int==0?361:358;continue;}
case 358:{f.Pc=95;continue;}
case 361:{f.Push(f.Locals[15]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",366);}
case 366:{f.Push(f.Locals[1]);f.Pc=367;continue;}
case 367:{f.Push(f.Locals[17]);f.Pc=369;continue;}
case 369:{f.Push(f.Locals[13]);f.Pc=371;continue;}
case 371:{f.Push(JValue.R(null));f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/List;Lforge/game/player/Player;)I","invokevirtual",375);}
case 375:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",378);}
case 378:{f.Locals[16]=f.Pop();f.Pc=380;continue;}
case 380:{f.Pc=403;continue;}
case 383:{f.Push(f.Locals[15]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",388);}
case 388:{f.Push(f.Locals[1]);f.Pc=389;continue;}
case 389:{f.Push(f.Locals[17]);f.Pc=391;continue;}
case 391:{f.Push(f.Locals[7]);f.Pc=393;continue;}
case 393:{f.Push(f.Locals[9]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;II)I","invokevirtual",398);}
case 398:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",401);}
case 401:{f.Locals[16]=f.Pop();f.Pc=403;continue;}
case 403:{f.Push(f.Locals[5]);f.Pc=405;continue;}
case 405:{f.Pc=f.Pop().Int==0?430:408;continue;}
case 408:{f.Push(f.Locals[1]);f.Pc=409;continue;}
case 409:{f.Push(JValue.R(rt.String("KeepSecret")));f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",414);}
case 414:{f.Pc=f.Pop().Int==0?430:417;continue;}
case 417:{f.Push(f.Locals[2]);f.Pc=418;continue;}
case 418:{f.Push(f.Locals[16]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",423);}
case 423:{f.Push(JValue.I(1));f.Pc=424;continue;}
case 424:{return rt.Call(f,"forge/game/card/Card","setChosenNumber","(IZ)V","invokevirtual",427);}
case 427:{f.Pc=459;continue;}
case 430:{f.Push(f.Locals[5]);f.Pc=432;continue;}
case 432:{f.Pc=f.Pop().Int==0?450:435;continue;}
case 435:{f.Push(f.Locals[10]);f.Pc=437;continue;}
case 437:{f.Push(f.Locals[15]);f.Pc=439;continue;}
case 439:{f.Push(f.Locals[16]);f.Pc=441;continue;}
case 441:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",446);}
case 446:{f.StackOp("pop");f.Pc=447;continue;}
case 447:{f.Pc=459;continue;}
case 450:{f.Push(f.Locals[2]);f.Pc=451;continue;}
case 451:{f.Push(f.Locals[16]);f.Pc=453;continue;}
case 453:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",456);}
case 456:{return rt.Call(f,"forge/game/card/Card","setChosenNumber","(I)V","invokevirtual",459);}
case 459:{f.Push(f.Locals[1]);f.Pc=460;continue;}
case 460:{f.Push(JValue.R(rt.String("Notify")));f.Pc=462;continue;}
case 462:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",465);}
case 465:{f.Pc=f.Pop().Int==0?508:468;continue;}
case 468:{f.Push(f.Locals[15]);f.Pc=470;continue;}
case 470:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",473);}
case 473:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",476);}
case 476:{f.Push(f.Locals[1]);f.Pc=477;continue;}
case 477:{f.Push(f.Locals[2]);f.Pc=478;continue;}
case 478:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",481);}
case 481:{f.Push(JValue.R(rt.String("lblPlayerPickedChosen")));f.Pc=483;continue;}
case 483:{f.Push(JValue.I(2));f.Pc=484;continue;}
case 484:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=487;continue;}
case 487:{f.StackOp("dup");f.Pc=488;continue;}
case 488:{f.Push(JValue.I(0));f.Pc=489;continue;}
case 489:{f.Push(f.Locals[15]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",494);}
case 494:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=495;continue;}
case 495:{f.StackOp("dup");f.Pc=496;continue;}
case 496:{f.Push(JValue.I(1));f.Pc=497;continue;}
case 497:{f.Push(f.Locals[16]);f.Pc=499;continue;}
case 499:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=500;continue;}
case 500:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",503);}
case 503:{f.Push(f.Locals[15]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",508);}
case 508:{f.Push(f.Locals[1]);f.Pc=509;continue;}
case 509:{f.Push(JValue.R(rt.String("Guesser")));f.Pc=511;continue;}
case 511:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",514);}
case 514:{f.Pc=f.Pop().Int==0?643:517;continue;}
case 517:{f.Push(f.Locals[16]);f.Pc=519;continue;}
case 519:{f.Pc=f.Pop().Reference==null?643:522;continue;}
case 522:{f.Push(f.Locals[2]);f.Pc=523;continue;}
case 523:{f.Push(f.Locals[1]);f.Pc=524;continue;}
case 524:{f.Push(JValue.R(rt.String("Guesser")));f.Pc=526;continue;}
case 526:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",529);}
case 529:{f.Push(f.Locals[1]);f.Pc=530;continue;}
case 530:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",533);}
case 533:{f.Locals[17]=f.Pop();f.Pc=535;continue;}
case 535:{f.Push(f.Locals[13]);f.Pc=537;continue;}
case 537:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",542);}
case 542:{f.Pc=f.Pop().Int==0?549:545;continue;}
case 545:{f.Push(JValue.R(null));f.Pc=546;continue;}
case 546:{f.Pc=577;continue;}
case 549:{f.Push(f.Locals[15]);f.Pc=551;continue;}
case 551:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",554);}
case 554:{f.Push(f.Locals[17]);f.Pc=556;continue;}
case 556:{f.Push(f.Locals[1]);f.Pc=557;continue;}
case 557:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",560);}
case 560:{f.Push(JValue.R(rt.String("lblChoosePlayer")));f.Pc=562;continue;}
case 562:{f.Push(JValue.I(0));f.Pc=563;continue;}
case 563:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",569);}
case 569:{f.Push(JValue.I(0));f.Pc=570;continue;}
case 570:{f.Push(JValue.R(null));f.Pc=571;continue;}
case 571:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",574);}
case 574:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=577;continue;}
case 577:{f.Locals[18]=f.Pop();f.Pc=579;continue;}
case 579:{f.Push(f.Locals[18]);f.Pc=581;continue;}
case 581:{f.Pc=f.Pop().Reference==null?636:584;continue;}
case 584:{f.Push(f.Locals[18]);f.Pc=586;continue;}
case 586:{f.Push(f.Locals[18]);f.Pc=588;continue;}
case 588:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",591);}
case 591:{f.Push(f.Locals[1]);f.Pc=592;continue;}
case 592:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",595);}
case 595:{f.Push(JValue.R(rt.String("lblChooseNumber")));f.Pc=597;continue;}
case 597:{f.Push(JValue.I(0));f.Pc=598;continue;}
case 598:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=601;continue;}
case 601:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",604);}
case 604:{f.Push(f.Locals[13]);f.Pc=606;continue;}
case 606:{f.Push(JValue.R(null));f.Pc=607;continue;}
case 607:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/List;Lforge/game/player/Player;)I","invokevirtual",610);}
case 610:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",613);}
case 613:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",616);}
case 616:{f.Locals[12]=f.Pop();f.Pc=618;continue;}
case 618:{f.Push(f.Locals[10]);f.Pc=620;continue;}
case 620:{f.Push(f.Locals[12]);f.Pc=622;continue;}
case 622:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getValue","()Ljava/lang/Object;","invokevirtual",625);}
case 625:{return rt.Call(f,"java/util/Map","containsValue","(Ljava/lang/Object;)Z","invokeinterface",630);}
case 630:{f.Pc=f.Pop().Int==0?636:633;continue;}
case 633:{f.Push(JValue.I(1));f.Pc=634;continue;}
case 634:{f.Locals[11]=f.Pop();f.Pc=636;continue;}
case 636:{f.Push(f.Locals[2]);f.Pc=637;continue;}
case 637:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",640);}
case 640:{return rt.Call(f,"forge/game/Game","incPiledGuessedSA","()V","invokevirtual",643);}
case 643:{f.Pc=95;continue;}
case 646:{f.Push(f.Locals[5]);f.Pc=648;continue;}
case 648:{f.Pc=f.Pop().Int==0?1520:651;continue;}
case 651:{f.Push(f.Locals[10]);f.Pc=653;continue;}
case 653:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",658);}
case 658:{f.Pc=f.Pop().Int!=0?1520:661;continue;}
case 661:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=664;continue;}
case 664:{f.StackOp("dup");f.Pc=665;continue;}
case 665:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",668);}
case 668:{f.Locals[14]=f.Pop();f.Pc=670;continue;}
case 670:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",673);}
case 673:{f.Locals[15]=f.Pop();f.Pc=675;continue;}
case 675:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",678);}
case 678:{f.Locals[16]=f.Pop();f.Pc=680;continue;}
case 680:{f.Push(JValue.I(0));f.Pc=681;continue;}
case 681:{f.Locals[17]=f.Pop();f.Pc=683;continue;}
case 683:{f.Push(JValue.I(2147483647));f.Pc=685;continue;}
case 685:{f.Locals[18]=f.Pop();f.Pc=687;continue;}
case 687:{f.Push(f.Locals[12]);f.Pc=689;continue;}
case 689:{f.Pc=f.Pop().Reference==null?744:692;continue;}
case 692:{f.Push(f.Locals[14]);f.Pc=694;continue;}
case 694:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",697);}
case 697:{f.Push(JValue.R(rt.String("lblPlayerGuessedNum")));f.Pc=699;continue;}
case 699:{f.Push(JValue.I(2));f.Pc=700;continue;}
case 700:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=703;continue;}
case 703:{f.StackOp("dup");f.Pc=704;continue;}
case 704:{f.Push(JValue.I(0));f.Pc=705;continue;}
case 705:{f.Push(f.Locals[12]);f.Pc=707;continue;}
case 707:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",710);}
case 710:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=713;continue;}
case 713:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",716);}
case 716:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=717;continue;}
case 717:{f.StackOp("dup");f.Pc=718;continue;}
case 718:{f.Push(JValue.I(1));f.Pc=719;continue;}
case 719:{f.Push(f.Locals[12]);f.Pc=721;continue;}
case 721:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getValue","()Ljava/lang/Object;","invokevirtual",724);}
case 724:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",727);}
case 727:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=728;continue;}
case 728:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",731);}
case 731:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",734);}
case 734:{f.StackOp("pop");f.Pc=735;continue;}
case 735:{f.Push(f.Locals[14]);f.Pc=737;continue;}
case 737:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=740;continue;}
case 740:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",743);}
case 743:{f.StackOp("pop");f.Pc=744;continue;}
case 744:{f.Push(f.Locals[10]);f.Pc=746;continue;}
case 746:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",751);}
case 751:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",756);}
case 756:{f.Locals[19]=f.Pop();f.Pc=758;continue;}
case 758:{f.Push(f.Locals[19]);f.Pc=760;continue;}
case 760:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",765);}
case 765:{f.Pc=f.Pop().Int==0?924:768;continue;}
case 768:{f.Push(f.Locals[19]);f.Pc=770;continue;}
case 770:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",775);}
case 775:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=778;continue;}
case 778:{f.Locals[20]=f.Pop();f.Pc=780;continue;}
case 780:{f.Push(f.Locals[20]);f.Pc=782;continue;}
case 782:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",787);}
case 787:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=790;continue;}
case 790:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",793);}
case 793:{f.Locals[21]=f.Pop();f.Pc=795;continue;}
case 795:{f.Push(f.Locals[20]);f.Pc=797;continue;}
case 797:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",802);}
case 802:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=805;continue;}
case 805:{f.Locals[22]=f.Pop();f.Pc=807;continue;}
case 807:{f.Push(f.Locals[14]);f.Pc=809;continue;}
case 809:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",812);}
case 812:{f.Push(JValue.R(rt.String("lblPlayerChoseNum")));f.Pc=815;continue;}
case 815:{f.Push(JValue.I(2));f.Pc=816;continue;}
case 816:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=819;continue;}
case 819:{f.StackOp("dup");f.Pc=820;continue;}
case 820:{f.Push(JValue.I(0));f.Pc=821;continue;}
case 821:{f.Push(f.Locals[22]);f.Pc=823;continue;}
case 823:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",826);}
case 826:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=827;continue;}
case 827:{f.StackOp("dup");f.Pc=828;continue;}
case 828:{f.Push(JValue.I(1));f.Pc=829;continue;}
case 829:{f.Push(f.Locals[21]);f.Pc=831;continue;}
case 831:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",834);}
case 834:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=835;continue;}
case 835:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",838);}
case 838:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",841);}
case 841:{f.StackOp("pop");f.Pc=842;continue;}
case 842:{f.Push(f.Locals[14]);f.Pc=844;continue;}
case 844:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=847;continue;}
case 847:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",850);}
case 850:{f.StackOp("pop");f.Pc=851;continue;}
case 851:{f.Push(f.Locals[21]);f.Pc=853;continue;}
case 853:{f.Push(f.Locals[17]);f.Pc=855;continue;}
case 855:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?869:858;continue;}
case 858:{f.Push(f.Locals[15]);f.Pc=860;continue;}
case 860:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",865);}
case 865:{f.Push(f.Locals[21]);f.Pc=867;continue;}
case 867:{f.Locals[17]=f.Pop();f.Pc=869;continue;}
case 869:{f.Push(f.Locals[21]);f.Pc=871;continue;}
case 871:{f.Push(f.Locals[17]);f.Pc=873;continue;}
case 873:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?886:876;continue;}
case 876:{f.Push(f.Locals[15]);f.Pc=878;continue;}
case 878:{f.Push(f.Locals[22]);f.Pc=880;continue;}
case 880:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",885);}
case 885:{f.StackOp("pop");f.Pc=886;continue;}
case 886:{f.Push(f.Locals[21]);f.Pc=888;continue;}
case 888:{f.Push(f.Locals[18]);f.Pc=890;continue;}
case 890:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?904:893;continue;}
case 893:{f.Push(f.Locals[16]);f.Pc=895;continue;}
case 895:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",900);}
case 900:{f.Push(f.Locals[21]);f.Pc=902;continue;}
case 902:{f.Locals[18]=f.Pop();f.Pc=904;continue;}
case 904:{f.Push(f.Locals[21]);f.Pc=906;continue;}
case 906:{f.Push(f.Locals[18]);f.Pc=908;continue;}
case 908:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?921:911;continue;}
case 911:{f.Push(f.Locals[16]);f.Pc=913;continue;}
case 913:{f.Push(f.Locals[22]);f.Pc=915;continue;}
case 915:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",920);}
case 920:{f.StackOp("pop");f.Pc=921;continue;}
case 921:{f.Pc=758;continue;}
case 924:{f.Push(f.Locals[15]);f.Pc=926;continue;}
case 926:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",931);}
case 931:{f.Push(f.Locals[10]);f.Pc=933;continue;}
case 933:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",938);}
case 938:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?945:941;continue;}
case 941:{f.Push(JValue.I(1));f.Pc=942;continue;}
case 942:{f.Pc=946;continue;}
case 945:{f.Push(JValue.I(0));f.Pc=946;continue;}
case 946:{f.Locals[19]=f.Pop();f.Pc=948;continue;}
case 948:{f.Push(f.Locals[2]);f.Pc=949;continue;}
case 949:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",952);}
case 952:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",955);}
case 955:{f.Push(f.Locals[1]);f.Pc=956;continue;}
case 956:{f.Push(f.Locals[2]);f.Pc=957;continue;}
case 957:{f.Push(f.Locals[14]);f.Pc=959;continue;}
case 959:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",962);}
case 962:{f.Push(JValue.R(null));f.Pc=963;continue;}
case 963:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",966);}
case 966:{f.Push(f.Locals[1]);f.Pc=967;continue;}
case 967:{f.Push(JValue.R(rt.String("ChooseNumberSubAbility")));f.Pc=970;continue;}
case 970:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",973);}
case 973:{f.Pc=f.Pop().Int==0?1058:976;continue;}
case 976:{f.Push(f.Locals[1]);f.Pc=977;continue;}
case 977:{f.Push(JValue.R(rt.String("ChooseNumberSubAbility")));f.Pc=980;continue;}
case 980:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",983);}
case 983:{f.Locals[20]=f.Pop();f.Pc=985;continue;}
case 985:{f.Push(f.Locals[10]);f.Pc=987;continue;}
case 987:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",992);}
case 992:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",997);}
case 997:{f.Locals[21]=f.Pop();f.Pc=999;continue;}
case 999:{f.Push(f.Locals[21]);f.Pc=1001;continue;}
case 1001:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1006);}
case 1006:{f.Pc=f.Pop().Int==0?1058:1009;continue;}
case 1009:{f.Push(f.Locals[21]);f.Pc=1011;continue;}
case 1011:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1016);}
case 1016:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1019;continue;}
case 1019:{f.Locals[22]=f.Pop();f.Pc=1021;continue;}
case 1021:{f.Push(f.Locals[2]);f.Pc=1022;continue;}
case 1022:{f.Push(f.Locals[22]);f.Pc=1024;continue;}
case 1024:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1027);}
case 1027:{f.Push(f.Locals[2]);f.Pc=1028;continue;}
case 1028:{f.Push(f.Locals[10]);f.Pc=1030;continue;}
case 1030:{f.Push(f.Locals[22]);f.Pc=1032;continue;}
case 1032:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1037);}
case 1037:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1040;continue;}
case 1040:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1043);}
case 1043:{return rt.Call(f,"forge/game/card/Card","setChosenNumber","(I)V","invokevirtual",1046);}
case 1046:{f.Push(f.Locals[20]);f.Pc=1048;continue;}
case 1048:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1051);}
case 1051:{f.Push(f.Locals[2]);f.Pc=1052;continue;}
case 1052:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",1055);}
case 1055:{f.Pc=999;continue;}
case 1058:{f.Push(f.Locals[1]);f.Pc=1059;continue;}
case 1059:{f.Push(JValue.R(rt.String("Lowest")));f.Pc=1062;continue;}
case 1062:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1065);}
case 1065:{f.Pc=f.Pop().Int==0?1132:1068;continue;}
case 1068:{f.Push(f.Locals[1]);f.Pc=1069;continue;}
case 1069:{f.Push(JValue.R(rt.String("Lowest")));f.Pc=1072;continue;}
case 1072:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",1075);}
case 1075:{f.Locals[20]=f.Pop();f.Pc=1077;continue;}
case 1077:{f.Push(f.Locals[16]);f.Pc=1079;continue;}
case 1079:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1084);}
case 1084:{f.Locals[21]=f.Pop();f.Pc=1086;continue;}
case 1086:{f.Push(f.Locals[21]);f.Pc=1088;continue;}
case 1088:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1093);}
case 1093:{f.Pc=f.Pop().Int==0?1132:1096;continue;}
case 1096:{f.Push(f.Locals[21]);f.Pc=1098;continue;}
case 1098:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1103);}
case 1103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1106;continue;}
case 1106:{f.Locals[22]=f.Pop();f.Pc=1108;continue;}
case 1108:{f.Push(f.Locals[2]);f.Pc=1109;continue;}
case 1109:{f.Push(f.Locals[22]);f.Pc=1111;continue;}
case 1111:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1114);}
case 1114:{f.Push(f.Locals[2]);f.Pc=1115;continue;}
case 1115:{f.Push(f.Locals[18]);f.Pc=1117;continue;}
case 1117:{return rt.Call(f,"forge/game/card/Card","setChosenNumber","(I)V","invokevirtual",1120);}
case 1120:{f.Push(f.Locals[20]);f.Pc=1122;continue;}
case 1122:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1125);}
case 1125:{f.Push(f.Locals[2]);f.Pc=1126;continue;}
case 1126:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",1129);}
case 1129:{f.Pc=1086;continue;}
case 1132:{f.Push(f.Locals[1]);f.Pc=1133;continue;}
case 1133:{f.Push(JValue.R(rt.String("NotLowest")));f.Pc=1136;continue;}
case 1136:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1139);}
case 1139:{f.Pc=f.Pop().Int==0?1266:1142;continue;}
case 1142:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",1145);}
case 1145:{f.Locals[20]=f.Pop();f.Pc=1147;continue;}
case 1147:{f.Push(f.Locals[10]);f.Pc=1149;continue;}
case 1149:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",1154);}
case 1154:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",1159);}
case 1159:{f.Locals[21]=f.Pop();f.Pc=1161;continue;}
case 1161:{f.Push(f.Locals[21]);f.Pc=1163;continue;}
case 1163:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1168);}
case 1168:{f.Pc=f.Pop().Int==0?1208:1171;continue;}
case 1171:{f.Push(f.Locals[21]);f.Pc=1173;continue;}
case 1173:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1178);}
case 1178:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1181;continue;}
case 1181:{f.Locals[22]=f.Pop();f.Pc=1183;continue;}
case 1183:{f.Push(f.Locals[16]);f.Pc=1185;continue;}
case 1185:{f.Push(f.Locals[22]);f.Pc=1187;continue;}
case 1187:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1192);}
case 1192:{f.Pc=f.Pop().Int!=0?1205:1195;continue;}
case 1195:{f.Push(f.Locals[20]);f.Pc=1197;continue;}
case 1197:{f.Push(f.Locals[22]);f.Pc=1199;continue;}
case 1199:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1204);}
case 1204:{f.StackOp("pop");f.Pc=1205;continue;}
case 1205:{f.Pc=1161;continue;}
case 1208:{f.Push(f.Locals[1]);f.Pc=1209;continue;}
case 1209:{f.Push(JValue.R(rt.String("NotLowest")));f.Pc=1212;continue;}
case 1212:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",1215);}
case 1215:{f.Locals[21]=f.Pop();f.Pc=1217;continue;}
case 1217:{f.Push(f.Locals[20]);f.Pc=1219;continue;}
case 1219:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1224);}
case 1224:{f.Locals[22]=f.Pop();f.Pc=1226;continue;}
case 1226:{f.Push(f.Locals[22]);f.Pc=1228;continue;}
case 1228:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1233);}
case 1233:{f.Pc=f.Pop().Int==0?1266:1236;continue;}
case 1236:{f.Push(f.Locals[22]);f.Pc=1238;continue;}
case 1238:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1243);}
case 1243:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1246;continue;}
case 1246:{f.Locals[23]=f.Pop();f.Pc=1248;continue;}
case 1248:{f.Push(f.Locals[2]);f.Pc=1249;continue;}
case 1249:{f.Push(f.Locals[23]);f.Pc=1251;continue;}
case 1251:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1254);}
case 1254:{f.Push(f.Locals[21]);f.Pc=1256;continue;}
case 1256:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1259);}
case 1259:{f.Push(f.Locals[2]);f.Pc=1260;continue;}
case 1260:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",1263);}
case 1263:{f.Pc=1226;continue;}
case 1266:{f.Push(f.Locals[1]);f.Pc=1267;continue;}
case 1267:{f.Push(JValue.R(rt.String("Highest")));f.Pc=1270;continue;}
case 1270:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1273);}
case 1273:{f.Pc=f.Pop().Int==0?1356:1276;continue;}
case 1276:{f.Push(f.Locals[1]);f.Pc=1277;continue;}
case 1277:{f.Push(JValue.R(rt.String("Highest")));f.Pc=1280;continue;}
case 1280:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",1283);}
case 1283:{f.Locals[20]=f.Pop();f.Pc=1285;continue;}
case 1285:{f.Push(f.Locals[15]);f.Pc=1287;continue;}
case 1287:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1292);}
case 1292:{f.Locals[21]=f.Pop();f.Pc=1294;continue;}
case 1294:{f.Push(f.Locals[21]);f.Pc=1296;continue;}
case 1296:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1301);}
case 1301:{f.Pc=f.Pop().Int==0?1340:1304;continue;}
case 1304:{f.Push(f.Locals[21]);f.Pc=1306;continue;}
case 1306:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1311);}
case 1311:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1314;continue;}
case 1314:{f.Locals[22]=f.Pop();f.Pc=1316;continue;}
case 1316:{f.Push(f.Locals[2]);f.Pc=1317;continue;}
case 1317:{f.Push(f.Locals[22]);f.Pc=1319;continue;}
case 1319:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1322);}
case 1322:{f.Push(f.Locals[2]);f.Pc=1323;continue;}
case 1323:{f.Push(f.Locals[17]);f.Pc=1325;continue;}
case 1325:{return rt.Call(f,"forge/game/card/Card","setChosenNumber","(I)V","invokevirtual",1328);}
case 1328:{f.Push(f.Locals[20]);f.Pc=1330;continue;}
case 1330:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1333);}
case 1333:{f.Push(f.Locals[2]);f.Pc=1334;continue;}
case 1334:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",1337);}
case 1337:{f.Pc=1294;continue;}
case 1340:{f.Push(f.Locals[1]);f.Pc=1341;continue;}
case 1341:{f.Push(JValue.R(rt.String("RememberHighest")));f.Pc=1344;continue;}
case 1344:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1347);}
case 1347:{f.Pc=f.Pop().Int==0?1356:1350;continue;}
case 1350:{f.Push(f.Locals[2]);f.Pc=1351;continue;}
case 1351:{f.Push(f.Locals[15]);f.Pc=1353;continue;}
case 1353:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1356);}
case 1356:{f.Push(f.Locals[1]);f.Pc=1357;continue;}
case 1357:{f.Push(JValue.R(rt.String("GuessCorrect")));f.Pc=1360;continue;}
case 1360:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1363);}
case 1363:{f.Pc=f.Pop().Int==0?1385:1366;continue;}
case 1366:{f.Push(f.Locals[11]);f.Pc=1368;continue;}
case 1368:{f.Pc=f.Pop().Int==0?1385:1371;continue;}
case 1371:{f.Push(f.Locals[1]);f.Pc=1372;continue;}
case 1372:{f.Push(JValue.R(rt.String("GuessCorrect")));f.Pc=1375;continue;}
case 1375:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",1378);}
case 1378:{f.Locals[20]=f.Pop();f.Pc=1380;continue;}
case 1380:{f.Push(f.Locals[20]);f.Pc=1382;continue;}
case 1382:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1385);}
case 1385:{f.Push(f.Locals[1]);f.Pc=1386;continue;}
case 1386:{f.Push(JValue.R(rt.String("GuessWrong")));f.Pc=1389;continue;}
case 1389:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1392);}
case 1392:{f.Pc=f.Pop().Int==0?1462:1395;continue;}
case 1395:{f.Push(f.Locals[12]);f.Pc=1397;continue;}
case 1397:{f.Pc=f.Pop().Reference==null?1462:1400;continue;}
case 1400:{f.Push(f.Locals[11]);f.Pc=1402;continue;}
case 1402:{f.Pc=f.Pop().Int!=0?1462:1405;continue;}
case 1405:{f.Push(f.Locals[1]);f.Pc=1406;continue;}
case 1406:{f.Push(JValue.R(rt.String("GuessWrong")));f.Pc=1409;continue;}
case 1409:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",1412);}
case 1412:{f.Locals[20]=f.Pop();f.Pc=1414;continue;}
case 1414:{f.Push(f.Locals[2]);f.Pc=1415;continue;}
case 1415:{f.Push(f.Locals[12]);f.Pc=1417;continue;}
case 1417:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getValue","()Ljava/lang/Object;","invokevirtual",1420);}
case 1420:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1423;continue;}
case 1423:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1426);}
case 1426:{return rt.Call(f,"forge/game/card/Card","setChosenNumber","(I)V","invokevirtual",1429);}
case 1429:{f.Push(f.Locals[2]);f.Pc=1430;continue;}
case 1430:{f.Push(f.Locals[12]);f.Pc=1432;continue;}
case 1432:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",1435);}
case 1435:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1438;continue;}
case 1438:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1441);}
case 1441:{f.Push(f.Locals[20]);f.Pc=1443;continue;}
case 1443:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1446);}
case 1446:{f.Push(f.Locals[2]);f.Pc=1447;continue;}
case 1447:{return rt.Call(f,"forge/game/card/Card","clearChosenNumber","()V","invokevirtual",1450);}
case 1450:{f.Push(f.Locals[2]);f.Pc=1451;continue;}
case 1451:{f.Push(f.Locals[12]);f.Pc=1453;continue;}
case 1453:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",1456);}
case 1456:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1459;continue;}
case 1459:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",1462);}
case 1462:{f.Push(f.Locals[19]);f.Pc=1464;continue;}
case 1464:{f.Pc=f.Pop().Int==0?1491:1467;continue;}
case 1467:{f.Push(f.Locals[1]);f.Pc=1468;continue;}
case 1468:{f.Push(JValue.R(rt.String("MatchedAbility")));f.Pc=1471;continue;}
case 1471:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1474);}
case 1474:{f.Pc=f.Pop().Int==0?1491:1477;continue;}
case 1477:{f.Push(f.Locals[1]);f.Pc=1478;continue;}
case 1478:{f.Push(JValue.R(rt.String("MatchedAbility")));f.Pc=1481;continue;}
case 1481:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",1484);}
case 1484:{f.Locals[20]=f.Pop();f.Pc=1486;continue;}
case 1486:{f.Push(f.Locals[20]);f.Pc=1488;continue;}
case 1488:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1491);}
case 1491:{f.Push(f.Locals[19]);f.Pc=1493;continue;}
case 1493:{f.Pc=f.Pop().Int!=0?1520:1496;continue;}
case 1496:{f.Push(f.Locals[1]);f.Pc=1497;continue;}
case 1497:{f.Push(JValue.R(rt.String("UnmatchedAbility")));f.Pc=1500;continue;}
case 1500:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1503);}
case 1503:{f.Pc=f.Pop().Int==0?1520:1506;continue;}
case 1506:{f.Push(f.Locals[1]);f.Pc=1507;continue;}
case 1507:{f.Push(JValue.R(rt.String("UnmatchedAbility")));f.Pc=1510;continue;}
case 1510:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",1513);}
case 1513:{f.Locals[20]=f.Pop();f.Pc=1515;continue;}
case 1515:{f.Push(f.Locals[20]);f.Pc=1517;continue;}
case 1517:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1520);}
case 1520:{f.Push(f.Locals[1]);f.Pc=1521;continue;}
case 1521:{f.Push(JValue.R(rt.String("RememberChosen")));f.Pc=1524;continue;}
case 1524:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1527);}
case 1527:{f.Pc=f.Pop().Int==0?1541:1530;continue;}
case 1530:{f.Push(f.Locals[2]);f.Pc=1531;continue;}
case 1531:{f.Push(f.Locals[10]);f.Pc=1533;continue;}
case 1533:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",1538);}
case 1538:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1541);}
case 1541:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

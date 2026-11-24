// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C288{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DigEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3337,"forge/game/ability/effects/DigEffect","<init>","()V",1,1,1,new JHandler[]{},M3337));
c.Add(new JMethod(3338,"forge/game/ability/effects/DigEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M3338));
c.Add(new JMethod(3339,"forge/game/ability/effects/DigEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,17,4,new JHandler[]{},M3339));
c.Add(new JMethod(3340,"forge/game/ability/effects/DigEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,45,10,new JHandler[]{},M3340));
}

internal static JStep M3337(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3338(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3339(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/ability/effects/DigEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[5]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("X card")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?66:39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("[")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",45);}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",49);}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.Push(JValue.R(rt.String("] ")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",57);}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Pc=909;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("DigNum")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",77);}
case 77:{f.Locals[6]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("ChangeNum")));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("1")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",87);}
case 87:{f.Locals[7]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("All")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int!=0?109:99;continue;}
case 99:{f.Push(f.Locals[7]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("Any")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?114:109;continue;}
case 109:{f.Push(f.Locals[6]);f.Pc=111;continue;}
case 111:{f.Pc=121;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[7]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",121);}
case 121:{f.Locals[8]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String(" looks at ")));f.Pc=125;continue;}
case 125:{f.Locals[9]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("DestinationZone")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",133);}
case 133:{f.Pc=f.Pop().Int==0?164:136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("DestinationZone")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",142);}
case 142:{f.Push(JValue.R(rt.String("Exile")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?164:150;continue;}
case 150:{f.Push(f.Locals[6]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[8]);f.Pc=154;continue;}
case 154:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?164:157;continue;}
case 157:{f.Push(JValue.R(rt.String(" exiles ")));f.Pc=159;continue;}
case 159:{f.Locals[9]=f.Pop();f.Pc=161;continue;}
case 161:{f.Pc=191;continue;}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",170);}
case 170:{f.Pc=f.Pop().Int==0?191:173;continue;}
case 173:{f.Push(f.Locals[1]);f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",179);}
case 179:{f.Push(JValue.R(rt.String("True")));f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",184);}
case 184:{f.Pc=f.Pop().Int==0?191:187;continue;}
case 187:{f.Push(JValue.R(rt.String(" reveals ")));f.Pc=189;continue;}
case 189:{f.Locals[9]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[3]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[2]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",196);}
case 196:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",199);}
case 199:{f.Push(f.Locals[9]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",204);}
case 204:{f.Push(JValue.R(rt.String("the top ")));f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",209);}
case 209:{f.StackOp("pop");f.Pc=210;continue;}
case 210:{f.Push(f.Locals[3]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[6]);f.Pc=213;continue;}
case 213:{f.Push(JValue.I(1));f.Pc=214;continue;}
case 214:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?222:217;continue;}
case 217:{f.Push(JValue.R(rt.String("card")));f.Pc=219;continue;}
case 219:{f.Pc=232;continue;}
case 222:{f.Push(f.Locals[6]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",227);}
case 227:{return rt.DynamicCall(f,"forge/game/ability/effects/DigEffect:3339:227:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",232);}
case 232:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",235);}
case 235:{f.Push(JValue.R(rt.String(" of ")));f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",240);}
case 240:{f.StackOp("pop");f.Pc=241;continue;}
case 241:{f.Push(f.Locals[4]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[2]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",247);}
case 247:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",252);}
case 252:{f.Pc=f.Pop().Int==0?265:255;continue;}
case 255:{f.Push(f.Locals[3]);f.Pc=256;continue;}
case 256:{f.Push(JValue.R(rt.String("their ")));f.Pc=258;continue;}
case 258:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",261);}
case 261:{f.StackOp("pop");f.Pc=262;continue;}
case 262:{f.Pc=320;continue;}
case 265:{f.Push(f.Locals[4]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",272);}
case 272:{f.Locals[10]=f.Pop();f.Pc=274;continue;}
case 274:{f.Push(f.Locals[10]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",281);}
case 281:{f.Pc=f.Pop().Int==0?320:284;continue;}
case 284:{f.Push(f.Locals[10]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",291);}
case 291:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=294;continue;}
case 294:{f.Locals[11]=f.Pop();f.Pc=296;continue;}
case 296:{f.Push(f.Locals[3]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",300);}
case 300:{f.Push(f.Locals[11]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",305);}
case 305:{return rt.Call(f,"forge/util/Lang","getPossesive","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",308);}
case 308:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",311);}
case 311:{f.Push(JValue.R(rt.String(" ")));f.Pc=313;continue;}
case 313:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",316);}
case 316:{f.StackOp("pop");f.Pc=317;continue;}
case 317:{f.Pc=274;continue;}
case 320:{f.Push(f.Locals[3]);f.Pc=321;continue;}
case 321:{f.Push(JValue.R(rt.String("library.")));f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",326);}
case 326:{f.StackOp("pop");f.Pc=327;continue;}
case 327:{f.Push(f.Locals[6]);f.Pc=329;continue;}
case 329:{f.Push(f.Locals[8]);f.Pc=331;continue;}
case 331:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?909:334;continue;}
case 334:{f.Push(f.Locals[1]);f.Pc=335;continue;}
case 335:{f.Push(JValue.R(rt.String("DestinationZone")));f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",340);}
case 340:{f.Pc=f.Pop().Int==0?355:343;continue;}
case 343:{f.Push(f.Locals[1]);f.Pc=344;continue;}
case 344:{f.Push(JValue.R(rt.String("DestinationZone")));f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",349);}
case 349:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",352);}
case 352:{f.Pc=357;continue;}
case 355:{f.Push(JValue.R(rt.String("hand")));f.Pc=357;continue;}
case 357:{f.Locals[10]=f.Pop();f.Pc=359;continue;}
case 359:{f.Push(f.Locals[1]);f.Pc=360;continue;}
case 360:{f.Push(JValue.R(rt.String("DestinationZone2")));f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",365);}
case 365:{f.Pc=f.Pop().Int==0?380:368;continue;}
case 368:{f.Push(f.Locals[1]);f.Pc=369;continue;}
case 369:{f.Push(JValue.R(rt.String("DestinationZone2")));f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",374);}
case 374:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",377);}
case 377:{f.Pc=382;continue;}
case 380:{f.Push(JValue.R(rt.String("library")));f.Pc=382;continue;}
case 382:{f.Locals[11]=f.Pop();f.Pc=384;continue;}
case 384:{f.Push(JValue.I(0));f.Pc=385;continue;}
case 385:{f.Locals[13]=f.Pop();f.Pc=387;continue;}
case 387:{f.Push(f.Locals[11]);f.Pc=389;continue;}
case 389:{f.Locals[14]=f.Pop();f.Pc=391;continue;}
case 391:{f.Push(JValue.I(-1));f.Pc=392;continue;}
case 392:{f.Locals[15]=f.Pop();f.Pc=394;continue;}
case 394:{f.Push(f.Locals[14]);f.Pc=396;continue;}
case 396:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",399);}
case 399:{switch(f.Pop().Int){case 3194991:f.Pc=464;break;case 96954895:f.Pc=448;break;case 166208699:f.Pc=432;break;default:f.Pc=477;break;}continue;}
case 432:{f.Push(f.Locals[14]);f.Pc=434;continue;}
case 434:{f.Push(JValue.R(rt.String("library")));f.Pc=436;continue;}
case 436:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",439);}
case 439:{f.Pc=f.Pop().Int==0?477:442;continue;}
case 442:{f.Push(JValue.I(0));f.Pc=443;continue;}
case 443:{f.Locals[15]=f.Pop();f.Pc=445;continue;}
case 445:{f.Pc=477;continue;}
case 448:{f.Push(f.Locals[14]);f.Pc=450;continue;}
case 450:{f.Push(JValue.R(rt.String("exile")));f.Pc=452;continue;}
case 452:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",455);}
case 455:{f.Pc=f.Pop().Int==0?477:458;continue;}
case 458:{f.Push(JValue.I(1));f.Pc=459;continue;}
case 459:{f.Locals[15]=f.Pop();f.Pc=461;continue;}
case 461:{f.Pc=477;continue;}
case 464:{f.Push(f.Locals[14]);f.Pc=466;continue;}
case 466:{f.Push(JValue.R(rt.String("hand")));f.Pc=468;continue;}
case 468:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",471);}
case 471:{f.Pc=f.Pop().Int==0?477:474;continue;}
case 474:{f.Push(JValue.I(2));f.Pc=475;continue;}
case 475:{f.Locals[15]=f.Pop();f.Pc=477;continue;}
case 477:{f.Push(f.Locals[15]);f.Pc=479;continue;}
case 479:{switch(f.Pop().Int){case 0:f.Pc=504;break;case 1:f.Pc=551;break;case 2:f.Pc=561;break;default:f.Pc=568;break;}continue;}
case 504:{f.Push(JValue.R(rt.String("0")));f.Pc=506;continue;}
case 506:{f.Push(f.Locals[1]);f.Pc=507;continue;}
case 507:{f.Push(JValue.R(rt.String("LibraryPosition2")));f.Pc=509;continue;}
case 509:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",512);}
case 512:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",515);}
case 515:{f.Pc=f.Pop().Int==0?523:518;continue;}
case 518:{f.Push(JValue.R(rt.String("on top of their library")));f.Pc=520;continue;}
case 520:{f.Pc=525;continue;}
case 523:{f.Push(JValue.R(rt.String("on the bottom of their library")));f.Pc=525;continue;}
case 525:{f.Push(f.Locals[1]);f.Pc=526;continue;}
case 526:{f.Push(JValue.R(rt.String("RestRandomOrder")));f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",531);}
case 531:{f.Pc=f.Pop().Int==0?539:534;continue;}
case 534:{f.Push(JValue.R(rt.String(" in a random order.")));f.Pc=536;continue;}
case 536:{f.Pc=541;continue;}
case 539:{f.Push(JValue.R(rt.String(" in any order.")));f.Pc=541;continue;}
case 541:{return rt.DynamicCall(f,"forge/game/ability/effects/DigEffect:3339:541:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",546);}
case 546:{f.Locals[12]=f.Pop();f.Pc=548;continue;}
case 548:{f.Pc=577;continue;}
case 551:{f.Push(JValue.I(1));f.Pc=552;continue;}
case 552:{f.Locals[13]=f.Pop();f.Pc=554;continue;}
case 554:{f.Push(JValue.R(rt.String(".")));f.Pc=556;continue;}
case 556:{f.Locals[12]=f.Pop();f.Pc=558;continue;}
case 558:{f.Pc=577;continue;}
case 561:{f.Push(JValue.R(rt.String("into their hand.")));f.Pc=563;continue;}
case 563:{f.Locals[12]=f.Pop();f.Pc=565;continue;}
case 565:{f.Pc=577;continue;}
case 568:{f.Push(f.Locals[11]);f.Pc=570;continue;}
case 570:{return rt.DynamicCall(f,"forge/game/ability/effects/DigEffect:3339:570:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",575);}
case 575:{f.Locals[12]=f.Pop();f.Pc=577;continue;}
case 577:{f.Push(JValue.R(rt.String("put ")));f.Pc=579;continue;}
case 579:{f.Locals[14]=f.Pop();f.Pc=581;continue;}
case 581:{f.Push(JValue.R(rt.String(" into their hand ")));f.Pc=583;continue;}
case 583:{f.Locals[15]=f.Pop();f.Pc=585;continue;}
case 585:{f.Push(f.Locals[10]);f.Pc=587;continue;}
case 587:{f.Push(JValue.R(rt.String("exile")));f.Pc=589;continue;}
case 589:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",592);}
case 592:{f.Pc=f.Pop().Int==0?606:595;continue;}
case 595:{f.Push(JValue.R(rt.String("exile ")));f.Pc=597;continue;}
case 597:{f.Locals[14]=f.Pop();f.Pc=599;continue;}
case 599:{f.Push(JValue.R(rt.String(" ")));f.Pc=601;continue;}
case 601:{f.Locals[15]=f.Pop();f.Pc=603;continue;}
case 603:{f.Pc=624;continue;}
case 606:{f.Push(f.Locals[10]);f.Pc=608;continue;}
case 608:{f.Push(JValue.R(rt.String("battlefield")));f.Pc=610;continue;}
case 610:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",613);}
case 613:{f.Pc=f.Pop().Int==0?624:616;continue;}
case 616:{f.Push(JValue.R(rt.String("put ")));f.Pc=618;continue;}
case 618:{f.Locals[14]=f.Pop();f.Pc=620;continue;}
case 620:{f.Push(JValue.R(rt.String(" onto the battlefield ")));f.Pc=622;continue;}
case 622:{f.Locals[15]=f.Pop();f.Pc=624;continue;}
case 624:{f.Push(f.Locals[3]);f.Pc=625;continue;}
case 625:{f.Push(JValue.R(rt.String(" They ")));f.Pc=627;continue;}
case 627:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",630);}
case 630:{f.Push(f.Locals[1]);f.Pc=631;continue;}
case 631:{f.Push(JValue.R(rt.String("Optional")));f.Pc=633;continue;}
case 633:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",636);}
case 636:{f.Pc=f.Pop().Int==0?644:639;continue;}
case 639:{f.Push(JValue.R(rt.String("may ")));f.Pc=641;continue;}
case 641:{f.Pc=646;continue;}
case 644:{f.Push(JValue.R(rt.String("")));f.Pc=646;continue;}
case 646:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",649);}
case 649:{f.Push(f.Locals[14]);f.Pc=651;continue;}
case 651:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",654);}
case 654:{f.StackOp("pop");f.Pc=655;continue;}
case 655:{f.Push(f.Locals[1]);f.Pc=656;continue;}
case 656:{f.Push(JValue.R(rt.String("ChangeValid")));f.Pc=658;continue;}
case 658:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",661);}
case 661:{f.Pc=f.Pop().Int==0?759:664;continue;}
case 664:{f.Push(f.Locals[1]);f.Pc=665;continue;}
case 665:{f.Push(JValue.R(rt.String("ChangeValidDesc")));f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",670);}
case 670:{f.Pc=f.Pop().Int==0?682:673;continue;}
case 673:{f.Push(f.Locals[1]);f.Pc=674;continue;}
case 674:{f.Push(JValue.R(rt.String("ChangeValidDesc")));f.Pc=676;continue;}
case 676:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",679);}
case 679:{f.Pc=713;continue;}
case 682:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",685);}
case 685:{f.Push(f.Locals[1]);f.Pc=686;continue;}
case 686:{f.Push(JValue.R(rt.String("ChangeValid")));f.Pc=688;continue;}
case 688:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",691);}
case 691:{f.Push(JValue.R(rt.String(",")));f.Pc=693;continue;}
case 693:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",696);}
case 696:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",699);}
case 699:{f.Push(f.Locals[8]);f.Pc=701;continue;}
case 701:{f.Push(JValue.I(1));f.Pc=702;continue;}
case 702:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?709:705;continue;}
case 705:{f.Push(JValue.I(1));f.Pc=706;continue;}
case 706:{f.Pc=710;continue;}
case 709:{f.Push(JValue.I(0));f.Pc=710;continue;}
case 710:{return rt.Call(f,"forge/util/Lang","buildValidCardDesc","(Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",713);}
case 713:{f.Locals[16]=f.Pop();f.Pc=715;continue;}
case 715:{f.Push(f.Locals[16]);f.Pc=717;continue;}
case 717:{f.Push(JValue.R(rt.String("card")));f.Pc=719;continue;}
case 719:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","containsIgnoreCase","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z","invokestatic",722);}
case 722:{f.Pc=f.Pop().Int!=0?734:725;continue;}
case 725:{f.Push(f.Locals[16]);f.Pc=727;continue;}
case 727:{return rt.DynamicCall(f,"forge/game/ability/effects/DigEffect:3339:727:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",732);}
case 732:{f.Locals[16]=f.Pop();f.Pc=734;continue;}
case 734:{f.Push(f.Locals[3]);f.Pc=735;continue;}
case 735:{f.Push(f.Locals[8]);f.Pc=737;continue;}
case 737:{f.Push(f.Locals[16]);f.Pc=739;continue;}
case 739:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",742);}
case 742:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",745);}
case 745:{f.Push(JValue.R(rt.String(" from among them")));f.Pc=747;continue;}
case 747:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",750);}
case 750:{f.Push(f.Locals[15]);f.Pc=752;continue;}
case 752:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",755);}
case 755:{f.StackOp("pop");f.Pc=756;continue;}
case 756:{f.Pc=779;continue;}
case 759:{f.Push(f.Locals[3]);f.Pc=760;continue;}
case 760:{f.Push(f.Locals[8]);f.Pc=762;continue;}
case 762:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",765);}
case 765:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",768);}
case 768:{f.Push(JValue.R(rt.String(" of them")));f.Pc=770;continue;}
case 770:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",773);}
case 773:{f.Push(f.Locals[15]);f.Pc=775;continue;}
case 775:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",778);}
case 778:{f.StackOp("pop");f.Pc=779;continue;}
case 779:{f.Push(f.Locals[3]);f.Pc=780;continue;}
case 780:{f.Push(f.Locals[1]);f.Pc=781;continue;}
case 781:{f.Push(JValue.R(rt.String("ExileFaceDown")));f.Pc=783;continue;}
case 783:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",786);}
case 786:{f.Pc=f.Pop().Int==0?794:789;continue;}
case 789:{f.Push(JValue.R(rt.String("face down ")));f.Pc=791;continue;}
case 791:{f.Pc=796;continue;}
case 794:{f.Push(JValue.R(rt.String("")));f.Pc=796;continue;}
case 796:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",799);}
case 799:{f.StackOp("pop");f.Pc=800;continue;}
case 800:{f.Push(f.Locals[1]);f.Pc=801;continue;}
case 801:{f.Push(JValue.R(rt.String("WithCounters")));f.Pc=803;continue;}
case 803:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",806);}
case 806:{f.Pc=f.Pop().Int!=0?818:809;continue;}
case 809:{f.Push(f.Locals[1]);f.Pc=810;continue;}
case 810:{f.Push(JValue.R(rt.String("ExileWithCounters")));f.Pc=812;continue;}
case 812:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",815);}
case 815:{f.Pc=f.Pop().Int==0?879:818;continue;}
case 818:{f.Push(f.Locals[1]);f.Pc=819;continue;}
case 819:{f.Push(JValue.R(rt.String("WithCounters")));f.Pc=821;continue;}
case 821:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",824);}
case 824:{f.Pc=f.Pop().Int==0?836:827;continue;}
case 827:{f.Push(f.Locals[1]);f.Pc=828;continue;}
case 828:{f.Push(JValue.R(rt.String("WithCounters")));f.Pc=830;continue;}
case 830:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",833);}
case 833:{f.Pc=842;continue;}
case 836:{f.Push(f.Locals[1]);f.Pc=837;continue;}
case 837:{f.Push(JValue.R(rt.String("ExileWithCounters")));f.Pc=839;continue;}
case 839:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",842);}
case 842:{f.Locals[16]=f.Pop();f.Pc=844;continue;}
case 844:{f.Push(f.Locals[3]);f.Pc=845;continue;}
case 845:{f.Push(JValue.R(rt.String("with a ")));f.Pc=847;continue;}
case 847:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",850);}
case 850:{f.StackOp("pop");f.Pc=851;continue;}
case 851:{f.Push(f.Locals[3]);f.Pc=852;continue;}
case 852:{f.Push(f.Locals[16]);f.Pc=854;continue;}
case 854:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",857);}
case 857:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",862);}
case 862:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",865);}
case 865:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",868);}
case 868:{f.StackOp("pop");f.Pc=869;continue;}
case 869:{f.Push(f.Locals[3]);f.Pc=870;continue;}
case 870:{f.Push(JValue.R(rt.String(" counter on it. They ")));f.Pc=872;continue;}
case 872:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",875);}
case 875:{f.StackOp("pop");f.Pc=876;continue;}
case 876:{f.Pc=886;continue;}
case 879:{f.Push(f.Locals[3]);f.Pc=880;continue;}
case 880:{f.Push(JValue.R(rt.String("and ")));f.Pc=882;continue;}
case 882:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",885);}
case 885:{f.StackOp("pop");f.Pc=886;continue;}
case 886:{f.Push(f.Locals[3]);f.Pc=887;continue;}
case 887:{f.Push(f.Locals[13]);f.Pc=889;continue;}
case 889:{f.Pc=f.Pop().Int==0?898:892;continue;}
case 892:{f.Push(JValue.R(rt.String("exile the rest.")));f.Pc=895;continue;}
case 895:{f.Pc=905;continue;}
case 898:{f.Push(f.Locals[12]);f.Pc=900;continue;}
case 900:{return rt.DynamicCall(f,"forge/game/ability/effects/DigEffect:3339:900:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",905);}
case 905:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",908);}
case 908:{f.StackOp("pop");f.Pc=909;continue;}
case 909:{f.Push(f.Locals[3]);f.Pc=910;continue;}
case 910:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",913);}
case 913:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3340(JRuntime rt,JFrame f)
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
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",20);}
case 20:{f.Locals[5]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{f.Locals[6]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("DigNum")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",36);}
case 36:{f.Locals[7]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("SourceZone")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?61:48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("SourceZone")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",58);}
case 58:{f.Pc=64;continue;}
case 61:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=64;continue;}
case 64:{f.Locals[8]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("DestinationZone")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?87:75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("DestinationZone")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",81);}
case 81:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",84);}
case 84:{f.Pc=90;continue;}
case 87:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=90;continue;}
case 90:{f.Locals[9]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("DestinationZone2")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?113:101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("DestinationZone2")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",107);}
case 107:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",110);}
case 110:{f.Pc=116;continue;}
case 113:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=116;continue;}
case 116:{f.Locals[10]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",125);}
case 125:{f.Pc=f.Pop().Int==0?141:128;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",135);}
case 135:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",138);}
case 138:{f.Pc=142;continue;}
case 141:{f.Push(JValue.I(-1));f.Pc=142;continue;}
case 142:{f.Locals[11]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("LibraryPosition2")));f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?165:153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("LibraryPosition2")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",159);}
case 159:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",162);}
case 162:{f.Pc=166;continue;}
case 165:{f.Push(JValue.I(-1));f.Pc=166;continue;}
case 166:{f.Locals[12]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[1]);f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String("ChangeValid")));f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("")));f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",176);}
case 176:{f.Locals[13]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[1]);f.Pc=179;continue;}
case 179:{f.Push(JValue.R(rt.String("Optional")));f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",184);}
case 184:{f.Locals[14]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[1]);f.Pc=187;continue;}
case 187:{f.Push(JValue.R(rt.String("SkipReorder")));f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",193);}
case 193:{f.Locals[15]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[1]);f.Pc=196;continue;}
case 196:{f.Push(JValue.R(rt.String("ForceRevealToController")));f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",202);}
case 202:{f.Pc=f.Pop().Int!=0?225:205;continue;}
case 205:{f.Push(f.Locals[1]);f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String("ForceReveal")));f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",212);}
case 212:{f.Pc=f.Pop().Int!=0?225:215;continue;}
case 215:{f.Push(f.Locals[1]);f.Pc=216;continue;}
case 216:{f.Push(JValue.R(rt.String("WithMayLook")));f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",222);}
case 222:{f.Pc=f.Pop().Int==0?229:225;continue;}
case 225:{f.Push(JValue.I(1));f.Pc=226;continue;}
case 226:{f.Pc=230;continue;}
case 229:{f.Push(JValue.I(0));f.Pc=230;continue;}
case 230:{f.Locals[16]=f.Pop();f.Pc=232;continue;}
case 232:{f.Push(f.Locals[1]);f.Pc=233;continue;}
case 233:{f.Push(JValue.R(rt.String("PromptToSkipOptionalAbility")));f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",239);}
case 239:{f.Locals[17]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[1]);f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("OptionalAbilityPrompt")));f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",248);}
case 248:{f.Locals[18]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(JValue.I(0));f.Pc=251;continue;}
case 251:{f.Locals[19]=f.Pop();f.Pc=253;continue;}
case 253:{f.Push(JValue.I(0));f.Pc=254;continue;}
case 254:{f.Locals[20]=f.Pop();f.Pc=256;continue;}
case 256:{f.Push(f.Locals[1]);f.Pc=257;continue;}
case 257:{f.Push(JValue.R(rt.String("RememberChanged")));f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",263);}
case 263:{f.Pc=f.Pop().Int==0?269:266;continue;}
case 266:{f.Push(JValue.I(1));f.Pc=267;continue;}
case 267:{f.Locals[19]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("RememberMovedToZone")));f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",276);}
case 276:{f.Pc=f.Pop().Int==0?316:279;continue;}
case 279:{f.Push(f.Locals[1]);f.Pc=280;continue;}
case 280:{f.Push(JValue.R(rt.String("RememberMovedToZone")));f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",286);}
case 286:{f.Push(JValue.R(rt.String("1")));f.Pc=288;continue;}
case 288:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",291);}
case 291:{f.Pc=f.Pop().Int==0?297:294;continue;}
case 294:{f.Push(JValue.I(1));f.Pc=295;continue;}
case 295:{f.Locals[19]=f.Pop();f.Pc=297;continue;}
case 297:{f.Push(f.Locals[1]);f.Pc=298;continue;}
case 298:{f.Push(JValue.R(rt.String("RememberMovedToZone")));f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",304);}
case 304:{f.Push(JValue.R(rt.String("2")));f.Pc=307;continue;}
case 307:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",310);}
case 310:{f.Pc=f.Pop().Int==0?316:313;continue;}
case 313:{f.Push(JValue.I(1));f.Pc=314;continue;}
case 314:{f.Locals[20]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[1]);f.Pc=317;continue;}
case 317:{f.Push(JValue.R(rt.String("WithTotalCMC")));f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",323);}
case 323:{f.Locals[21]=f.Pop();f.Pc=325;continue;}
case 325:{f.Push(f.Locals[2]);f.Pc=326;continue;}
case 326:{f.Push(f.Locals[1]);f.Pc=327;continue;}
case 327:{f.Push(JValue.R(rt.String("WithTotalCMC")));f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",333);}
case 333:{f.Push(f.Locals[1]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",337);}
case 337:{f.Locals[22]=f.Pop();f.Pc=339;continue;}
case 339:{f.Push(JValue.I(1));f.Pc=340;continue;}
case 340:{f.Locals[23]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(JValue.I(0));f.Pc=343;continue;}
case 343:{f.Locals[24]=f.Pop();f.Pc=345;continue;}
case 345:{f.Push(JValue.I(0));f.Pc=346;continue;}
case 346:{f.Locals[25]=f.Pop();f.Pc=348;continue;}
case 348:{f.Push(f.Locals[1]);f.Pc=349;continue;}
case 349:{f.Push(JValue.R(rt.String("ChangeNum")));f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",354);}
case 354:{f.Pc=f.Pop().Int==0?410:357;continue;}
case 357:{f.Push(f.Locals[1]);f.Pc=358;continue;}
case 358:{f.Push(JValue.R(rt.String("ChangeNum")));f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",363);}
case 363:{f.Push(JValue.R(rt.String("All")));f.Pc=365;continue;}
case 365:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",368);}
case 368:{f.Pc=f.Pop().Int==0?377:371;continue;}
case 371:{f.Push(JValue.I(1));f.Pc=372;continue;}
case 372:{f.Locals[24]=f.Pop();f.Pc=374;continue;}
case 374:{f.Pc=410;continue;}
case 377:{f.Push(f.Locals[1]);f.Pc=378;continue;}
case 378:{f.Push(JValue.R(rt.String("ChangeNum")));f.Pc=380;continue;}
case 380:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",383);}
case 383:{f.Push(JValue.R(rt.String("Any")));f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",388);}
case 388:{f.Pc=f.Pop().Int==0?397:391;continue;}
case 391:{f.Push(JValue.I(1));f.Pc=392;continue;}
case 392:{f.Locals[25]=f.Pop();f.Pc=394;continue;}
case 394:{f.Pc=410;continue;}
case 397:{f.Push(f.Locals[2]);f.Pc=398;continue;}
case 398:{f.Push(f.Locals[1]);f.Pc=399;continue;}
case 399:{f.Push(JValue.R(rt.String("ChangeNum")));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",404);}
case 404:{f.Push(f.Locals[1]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",408);}
case 408:{f.Locals[23]=f.Pop();f.Pc=410;continue;}
case 410:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=413;continue;}
case 413:{f.StackOp("dup");f.Pc=414;continue;}
case 414:{f.Push(f.Locals[4]);f.Pc=416;continue;}
case 416:{return rt.Call(f,"forge/game/Game","copyLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",419);}
case 419:{f.Push(f.Locals[4]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/game/Game","copyLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",424);}
case 424:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",427);}
case 427:{f.Locals[26]=f.Pop();f.Pc=429;continue;}
case 429:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=432;continue;}
case 432:{f.StackOp("dup");f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",436);}
case 436:{f.Locals[27]=f.Pop();f.Pc=438;continue;}
case 438:{f.Push(JValue.I(0));f.Pc=439;continue;}
case 439:{f.Locals[28]=f.Pop();f.Pc=441;continue;}
case 441:{f.Push(f.Locals[1]);f.Pc=442;continue;}
case 442:{return rt.Call(f,"forge/game/ability/effects/DigEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",445);}
case 445:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",448);}
case 448:{f.Locals[29]=f.Pop();f.Pc=450;continue;}
case 450:{f.Push(f.Locals[29]);f.Pc=452;continue;}
case 452:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",457);}
case 457:{f.Pc=f.Pop().Int==0?3027:460;continue;}
case 460:{f.Push(f.Locals[29]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",467);}
case 467:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=470;continue;}
case 470:{f.Locals[30]=f.Pop();f.Pc=472;continue;}
case 472:{f.Push(f.Locals[30]);f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",477);}
case 477:{f.Pc=f.Pop().Int!=0?483:480;continue;}
case 480:{f.Pc=450;continue;}
case 483:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=486;continue;}
case 486:{f.StackOp("dup");f.Pc=487;continue;}
case 487:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",490);}
case 490:{f.Locals[31]=f.Pop();f.Pc=492;continue;}
case 492:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=495;continue;}
case 495:{f.StackOp("dup");f.Pc=496;continue;}
case 496:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",499);}
case 499:{f.Locals[32]=f.Pop();f.Pc=501;continue;}
case 501:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=504;continue;}
case 504:{f.StackOp("dup");f.Pc=505;continue;}
case 505:{f.Push(f.Locals[30]);f.Pc=507;continue;}
case 507:{f.Push(f.Locals[8]);f.Pc=509;continue;}
case 509:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",512);}
case 512:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",515);}
case 515:{f.Locals[33]=f.Pop();f.Pc=517;continue;}
case 517:{f.Push(f.Locals[1]);f.Pc=518;continue;}
case 518:{f.Push(JValue.R(rt.String("FromBottom")));f.Pc=521;continue;}
case 521:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",524);}
case 524:{f.Pc=f.Pop().Int==0?532:527;continue;}
case 527:{f.Push(f.Locals[33]);f.Pc=529;continue;}
case 529:{return rt.Call(f,"java/util/Collections","reverse","(Ljava/util/List;)V","invokestatic",532);}
case 532:{f.Push(f.Locals[7]);f.Pc=534;continue;}
case 534:{f.Push(f.Locals[33]);f.Pc=536;continue;}
case 536:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",539);}
case 539:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",542);}
case 542:{f.Locals[34]=f.Pop();f.Pc=544;continue;}
case 544:{f.Push(JValue.I(0));f.Pc=545;continue;}
case 545:{f.Locals[35]=f.Pop();f.Pc=547;continue;}
case 547:{f.Push(f.Locals[35]);f.Pc=549;continue;}
case 549:{f.Push(f.Locals[34]);f.Pc=551;continue;}
case 551:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?576:554;continue;}
case 554:{f.Push(f.Locals[31]);f.Pc=556;continue;}
case 556:{f.Push(f.Locals[33]);f.Pc=558;continue;}
case 558:{f.Push(f.Locals[35]);f.Pc=560;continue;}
case 560:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",563);}
case 563:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",569);}
case 569:{f.StackOp("pop");f.Pc=570;continue;}
case 570:{f.Locals[35]=JValue.I(unchecked(f.Locals[35].Int+(1)));f.Pc=573;continue;}
case 573:{f.Pc=547;continue;}
case 576:{f.Push(f.Locals[31]);f.Pc=578;continue;}
case 578:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",581);}
case 581:{f.Pc=f.Pop().Int!=0?3024:584;continue;}
case 584:{f.Push(JValue.R(null));f.Pc=585;continue;}
case 585:{f.Locals[35]=f.Pop();f.Pc=587;continue;}
case 587:{f.Push(JValue.I(1));f.Pc=588;continue;}
case 588:{f.Locals[36]=f.Pop();f.Pc=590;continue;}
case 590:{f.Push(f.Locals[1]);f.Pc=591;continue;}
case 591:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=593;continue;}
case 593:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",596);}
case 596:{f.Pc=f.Pop().Int==0?629:599;continue;}
case 599:{f.Push(JValue.R(rt.String("True")));f.Pc=601;continue;}
case 601:{f.Push(f.Locals[1]);f.Pc=602;continue;}
case 602:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=604;continue;}
case 604:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",607);}
case 607:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",610);}
case 610:{f.Pc=f.Pop().Int==0?629:613;continue;}
case 613:{f.Push(f.Locals[4]);f.Pc=615;continue;}
case 615:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",618);}
case 618:{f.Push(f.Locals[31]);f.Pc=620;continue;}
case 620:{f.Push(f.Locals[30]);f.Pc=622;continue;}
case 622:{f.Push(JValue.I(0));f.Pc=623;continue;}
case 623:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;Z)V","invokevirtual",626);}
case 626:{f.Pc=761;continue;}
case 629:{f.Push(f.Locals[1]);f.Pc=630;continue;}
case 630:{f.Push(JValue.R(rt.String("RevealOptional")));f.Pc=633;continue;}
case 633:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",636);}
case 636:{f.Pc=f.Pop().Int==0?711:639;continue;}
case 639:{f.Push(f.Locals[31]);f.Pc=641;continue;}
case 641:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",644);}
case 644:{f.Push(JValue.I(1));f.Pc=645;continue;}
case 645:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?660:648;continue;}
case 648:{f.Push(f.Locals[31]);f.Pc=650;continue;}
case 650:{f.Push(JValue.I(0));f.Pc=651;continue;}
case 651:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",654);}
case 654:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=657;continue;}
case 657:{f.Pc=661;continue;}
case 660:{f.Push(JValue.R(null));f.Pc=661;continue;}
case 661:{f.Locals[37]=f.Pop();f.Pc=663;continue;}
case 663:{f.Push(f.Locals[30]);f.Pc=665;continue;}
case 665:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",668);}
case 668:{f.Push(f.Locals[1]);f.Pc=669;continue;}
case 669:{f.Push(JValue.R(null));f.Pc=670;continue;}
case 670:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",673);}
case 673:{f.Push(JValue.R(rt.String("lblRevealCardToOtherPlayers")));f.Pc=676;continue;}
case 676:{f.Push(JValue.I(0));f.Pc=677;continue;}
case 677:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=680;continue;}
case 680:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",683);}
case 683:{f.Push(f.Locals[37]);f.Pc=685;continue;}
case 685:{f.Push(JValue.R(null));f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",689);}
case 689:{f.Locals[36]=f.Pop();f.Pc=691;continue;}
case 691:{f.Push(f.Locals[36]);f.Pc=693;continue;}
case 693:{f.Pc=f.Pop().Int==0?708:696;continue;}
case 696:{f.Push(f.Locals[4]);f.Pc=698;continue;}
case 698:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",701);}
case 701:{f.Push(f.Locals[31]);f.Pc=703;continue;}
case 703:{f.Push(f.Locals[30]);f.Pc=705;continue;}
case 705:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;)V","invokevirtual",708);}
case 708:{f.Pc=761;continue;}
case 711:{f.Push(f.Locals[1]);f.Pc=712;continue;}
case 712:{f.Push(JValue.R(rt.String("NoLooking")));f.Pc=715;continue;}
case 715:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",718);}
case 718:{f.Pc=f.Pop().Int!=0?761:721;continue;}
case 721:{if(!rt.EnsureInitialized(f,"forge/game/player/DelayedReveal"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/DelayedReveal")));f.Pc=724;continue;}
case 724:{f.StackOp("dup");f.Pc=725;continue;}
case 725:{f.Push(f.Locals[31]);f.Pc=727;continue;}
case 727:{f.Push(f.Locals[8]);f.Pc=729;continue;}
case 729:{f.Push(f.Locals[30]);f.Pc=731;continue;}
case 731:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",734);}
case 734:{f.Push(f.Locals[2]);f.Pc=735;continue;}
case 735:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",738);}
case 738:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",741);}
case 741:{f.Push(JValue.R(rt.String("lblLookingCardIn")));f.Pc=744;continue;}
case 744:{f.Push(JValue.I(0));f.Pc=745;continue;}
case 745:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=748;continue;}
case 748:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",751);}
case 751:{return rt.DynamicCall(f,"forge/game/ability/effects/DigEffect:3340:751:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",756);}
case 756:{return rt.Call(f,"forge/game/player/DelayedReveal","<init>","(Ljava/lang/Iterable;Lforge/game/zone/ZoneType;Lforge/game/player/PlayerView;Ljava/lang/String;)V","invokespecial",759);}
case 759:{f.Locals[35]=f.Pop();f.Pc=761;continue;}
case 761:{f.Push(f.Locals[1]);f.Pc=762;continue;}
case 762:{f.Push(JValue.R(rt.String("RememberRevealed")));f.Pc=765;continue;}
case 765:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",768);}
case 768:{f.Pc=f.Pop().Int==0?782:771;continue;}
case 771:{f.Push(f.Locals[36]);f.Pc=773;continue;}
case 773:{f.Pc=f.Pop().Int==0?782:776;continue;}
case 776:{f.Push(f.Locals[2]);f.Pc=777;continue;}
case 777:{f.Push(f.Locals[31]);f.Pc=779;continue;}
case 779:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",782);}
case 782:{f.Push(f.Locals[1]);f.Pc=783;continue;}
case 783:{f.Push(JValue.R(rt.String("ImprintRevealed")));f.Pc=786;continue;}
case 786:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",789);}
case 789:{f.Pc=f.Pop().Int==0?803:792;continue;}
case 792:{f.Push(f.Locals[36]);f.Pc=794;continue;}
case 794:{f.Pc=f.Pop().Int==0?803:797;continue;}
case 797:{f.Push(f.Locals[2]);f.Pc=798;continue;}
case 798:{f.Push(f.Locals[31]);f.Pc=800;continue;}
case 800:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",803);}
case 803:{f.Push(f.Locals[1]);f.Pc=804;continue;}
case 804:{f.Push(JValue.R(rt.String("Choser")));f.Pc=807;continue;}
case 807:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",810);}
case 810:{f.Pc=f.Pop().Int==0?891:813;continue;}
case 813:{f.Push(f.Locals[2]);f.Pc=814;continue;}
case 814:{f.Push(f.Locals[1]);f.Pc=815;continue;}
case 815:{f.Push(JValue.R(rt.String("Choser")));f.Pc=818;continue;}
case 818:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",821);}
case 821:{f.Push(f.Locals[1]);f.Pc=822;continue;}
case 822:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",825);}
case 825:{f.Locals[37]=f.Pop();f.Pc=827;continue;}
case 827:{f.Push(f.Locals[37]);f.Pc=829;continue;}
case 829:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",834);}
case 834:{f.Pc=f.Pop().Int!=0?875:837;continue;}
case 837:{f.Push(f.Locals[3]);f.Pc=838;continue;}
case 838:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",841);}
case 841:{f.Push(f.Locals[37]);f.Pc=843;continue;}
case 843:{f.Push(JValue.R(null));f.Pc=844;continue;}
case 844:{f.Push(f.Locals[1]);f.Pc=845;continue;}
case 845:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",848);}
case 848:{f.Push(JValue.R(rt.String("lblChooser")));f.Pc=851;continue;}
case 851:{f.Push(JValue.I(0));f.Pc=852;continue;}
case 852:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=855;continue;}
case 855:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",858);}
case 858:{return rt.DynamicCall(f,"forge/game/ability/effects/DigEffect:3340:858:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",863);}
case 863:{f.Push(JValue.I(0));f.Pc=864;continue;}
case 864:{f.Push(f.Locals[30]);f.Pc=866;continue;}
case 866:{f.Push(JValue.R(null));f.Pc=867;continue;}
case 867:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLforge/game/player/Player;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",870);}
case 870:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=873;continue;}
case 873:{f.Locals[6]=f.Pop();f.Pc=875;continue;}
case 875:{f.Push(f.Locals[1]);f.Pc=876;continue;}
case 876:{f.Push(JValue.R(rt.String("SetChosenPlayer")));f.Pc=879;continue;}
case 879:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",882);}
case 882:{f.Pc=f.Pop().Int==0?891:885;continue;}
case 885:{f.Push(f.Locals[2]);f.Pc=886;continue;}
case 886:{f.Push(f.Locals[6]);f.Pc=888;continue;}
case 888:{return rt.Call(f,"forge/game/card/Card","setChosenPlayer","(Lforge/game/player/Player;)V","invokevirtual",891);}
case 891:{f.Push(f.Locals[32]);f.Pc=893;continue;}
case 893:{f.Push(f.Locals[31]);f.Pc=895;continue;}
case 895:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",898);}
case 898:{f.StackOp("pop");f.Pc=899;continue;}
case 899:{f.Push(f.Locals[31]);f.Pc=901;continue;}
case 901:{f.Locals[37]=f.Pop();f.Pc=903;continue;}
case 903:{f.Push(f.Locals[21]);f.Pc=905;continue;}
case 905:{f.Pc=f.Pop().Int==0?926:908;continue;}
case 908:{f.Push(f.Locals[37]);f.Pc=910;continue;}
case 910:{f.Push(f.Locals[22]);f.Pc=912;continue;}
case 912:{return rt.DynamicCall(f,"forge/game/ability/effects/DigEffect:3340:912:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",917);}
case 917:{f.Push(f.Locals[5]);f.Pc=919;continue;}
case 919:{f.Push(f.Locals[2]);f.Pc=920;continue;}
case 920:{f.Push(f.Locals[1]);f.Pc=921;continue;}
case 921:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",924);}
case 924:{f.Locals[37]=f.Pop();f.Pc=926;continue;}
case 926:{f.Push(f.Locals[13]);f.Pc=928;continue;}
case 928:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",931);}
case 931:{f.Pc=f.Pop().Int!=0?975:934;continue;}
case 934:{f.Push(f.Locals[13]);f.Pc=936;continue;}
case 936:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=939;continue;}
case 939:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",942);}
case 942:{f.Pc=f.Pop().Int==0?959:945;continue;}
case 945:{f.Push(f.Locals[13]);f.Pc=947;continue;}
case 947:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=950;continue;}
case 950:{f.Push(f.Locals[2]);f.Pc=951;continue;}
case 951:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",954);}
case 954:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",957);}
case 957:{f.Locals[13]=f.Pop();f.Pc=959;continue;}
case 959:{f.Push(f.Locals[37]);f.Pc=961;continue;}
case 961:{f.Push(f.Locals[13]);f.Pc=963;continue;}
case 963:{f.Push(f.Locals[5]);f.Pc=965;continue;}
case 965:{f.Push(f.Locals[2]);f.Pc=966;continue;}
case 966:{f.Push(f.Locals[1]);f.Pc=967;continue;}
case 967:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",970);}
case 970:{f.Locals[37]=f.Pop();f.Pc=972;continue;}
case 972:{f.Pc=996;continue;}
case 975:{f.Push(f.Locals[21]);f.Pc=977;continue;}
case 977:{f.Pc=f.Pop().Int!=0?996:980;continue;}
case 980:{f.Push(f.Locals[30]);f.Pc=982;continue;}
case 982:{f.Push(f.Locals[6]);f.Pc=984;continue;}
case 984:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?996:987;continue;}
case 987:{f.Push(f.Locals[23]);f.Pc=989;continue;}
case 989:{f.Push(JValue.I(1));f.Pc=990;continue;}
case 990:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?996:993;continue;}
case 993:{f.Push(JValue.R(null));f.Pc=994;continue;}
case 994:{f.Locals[35]=f.Pop();f.Pc=996;continue;}
case 996:{f.Push(f.Locals[16]);f.Pc=998;continue;}
case 998:{f.Pc=f.Pop().Int==0?1046:1001;continue;}
case 1001:{f.Push(f.Locals[1]);f.Pc=1002;continue;}
case 1002:{f.Push(JValue.R(rt.String("ForceReveal")));f.Pc=1005;continue;}
case 1005:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1008);}
case 1008:{f.Pc=f.Pop().Int==0?1028:1011;continue;}
case 1011:{f.Push(f.Locals[1]);f.Pc=1012;continue;}
case 1012:{f.Push(JValue.R(rt.String("ForceReveal")));f.Pc=1015;continue;}
case 1015:{return rt.Call(f,"forge/game/ability/effects/DigEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",1018);}
case 1018:{f.Push(JValue.I(0));f.Pc=1019;continue;}
case 1019:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",1022);}
case 1022:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1025;continue;}
case 1025:{f.Pc=1029;continue;}
case 1028:{f.Push(f.Locals[3]);f.Pc=1029;continue;}
case 1029:{f.Locals[38]=f.Pop();f.Pc=1031;continue;}
case 1031:{f.Push(f.Locals[4]);f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1036);}
case 1036:{f.Push(f.Locals[31]);f.Pc=1038;continue;}
case 1038:{f.Push(f.Locals[38]);f.Pc=1040;continue;}
case 1040:{return rt.Call(f,"forge/game/GameAction","revealTo","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;)V","invokevirtual",1043);}
case 1043:{f.Push(JValue.R(null));f.Pc=1044;continue;}
case 1044:{f.Locals[35]=f.Pop();f.Pc=1046;continue;}
case 1046:{f.Push(f.Locals[14]);f.Pc=1048;continue;}
case 1048:{f.Pc=f.Pop().Int==0?1155:1051;continue;}
case 1051:{f.Push(f.Locals[17]);f.Pc=1053;continue;}
case 1053:{f.Pc=f.Pop().Int==0?1155:1056;continue;}
case 1056:{f.Push(f.Locals[37]);f.Pc=1058;continue;}
case 1058:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1061);}
case 1061:{f.Pc=f.Pop().Int!=0?1155:1064;continue;}
case 1064:{f.Push(f.Locals[18]);f.Pc=1066;continue;}
case 1066:{f.Pc=f.Pop().Reference==null?1074:1069;continue;}
case 1069:{f.Push(f.Locals[18]);f.Pc=1071;continue;}
case 1071:{f.Pc=1100;continue;}
case 1074:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1077);}
case 1077:{f.Push(JValue.R(rt.String("lblWouldYouLikeProceedWithOptionalAbility")));f.Pc=1080;continue;}
case 1080:{f.Push(JValue.I(0));f.Pc=1081;continue;}
case 1081:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1084;continue;}
case 1084:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1087);}
case 1087:{f.Push(f.Locals[2]);f.Pc=1088;continue;}
case 1088:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1091);}
case 1091:{f.Push(f.Locals[1]);f.Pc=1092;continue;}
case 1092:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",1095);}
case 1095:{return rt.DynamicCall(f,"forge/game/ability/effects/DigEffect:3340:1095:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1100);}
case 1100:{f.Locals[38]=f.Pop();f.Pc=1102;continue;}
case 1102:{f.Push(f.Locals[37]);f.Pc=1104;continue;}
case 1104:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1107);}
case 1107:{f.Push(JValue.I(1));f.Pc=1108;continue;}
case 1108:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1123:1111;continue;}
case 1111:{f.Push(f.Locals[37]);f.Pc=1113;continue;}
case 1113:{f.Push(JValue.I(0));f.Pc=1114;continue;}
case 1114:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",1117);}
case 1117:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1120;continue;}
case 1120:{f.Pc=1124;continue;}
case 1123:{f.Push(JValue.R(null));f.Pc=1124;continue;}
case 1124:{f.Locals[39]=f.Pop();f.Pc=1126;continue;}
case 1126:{f.Push(f.Locals[30]);f.Pc=1128;continue;}
case 1128:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1131);}
case 1131:{f.Push(f.Locals[1]);f.Pc=1132;continue;}
case 1132:{f.Push(JValue.R(null));f.Pc=1133;continue;}
case 1133:{f.Push(f.Locals[38]);f.Pc=1135;continue;}
case 1135:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=1138;continue;}
case 1138:{f.Push(f.Locals[2]);f.Pc=1139;continue;}
case 1139:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",1142);}
case 1142:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1145);}
case 1145:{f.Push(f.Locals[39]);f.Pc=1147;continue;}
case 1147:{f.Push(JValue.R(null));f.Pc=1148;continue;}
case 1148:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",1151);}
case 1151:{f.Pc=f.Pop().Int!=0?1155:1154;continue;}
case 1154:{return JStep.ReturnVoid;}
case 1155:{f.Push(f.Locals[37]);f.Pc=1157;continue;}
case 1157:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1160);}
case 1160:{f.Pc=f.Pop().Int==0?1178:1163;continue;}
case 1163:{f.Push(f.Locals[35]);f.Pc=1165;continue;}
case 1165:{f.Pc=f.Pop().Reference==null?1178:1168;continue;}
case 1168:{f.Push(f.Locals[6]);f.Pc=1170;continue;}
case 1170:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1173);}
case 1173:{f.Push(f.Locals[35]);f.Pc=1175;continue;}
case 1175:{return rt.Call(f,"forge/game/player/PlayerController","reveal","(Lforge/game/player/DelayedReveal;)V","invokevirtual",1178);}
case 1178:{f.Push(f.Locals[24]);f.Pc=1180;continue;}
case 1180:{f.Pc=f.Pop().Int==0?1197:1183;continue;}
case 1183:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1186;continue;}
case 1186:{f.StackOp("dup");f.Pc=1187;continue;}
case 1187:{f.Push(f.Locals[37]);f.Pc=1189;continue;}
case 1189:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",1192);}
case 1192:{f.Locals[38]=f.Pop();f.Pc=1194;continue;}
case 1194:{f.Pc=2119;continue;}
case 1197:{f.Push(f.Locals[1]);f.Pc=1198;continue;}
case 1198:{f.Push(JValue.R(rt.String("RandomChange")));f.Pc=1201;continue;}
case 1201:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1204);}
case 1204:{f.Pc=f.Pop().Int==0?1231:1207;continue;}
case 1207:{f.Push(f.Locals[23]);f.Pc=1209;continue;}
case 1209:{f.Push(f.Locals[37]);f.Pc=1211;continue;}
case 1211:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1214);}
case 1214:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",1217);}
case 1217:{f.Locals[39]=f.Pop();f.Pc=1219;continue;}
case 1219:{f.Push(f.Locals[37]);f.Pc=1221;continue;}
case 1221:{f.Push(f.Locals[39]);f.Pc=1223;continue;}
case 1223:{return rt.Call(f,"forge/game/card/CardLists","getRandomSubList","(Ljava/util/List;I)Lforge/game/card/CardCollection;","invokestatic",1226);}
case 1226:{f.Locals[38]=f.Pop();f.Pc=1228;continue;}
case 1228:{f.Pc=2119;continue;}
case 1231:{f.Push(f.Locals[21]);f.Pc=1233;continue;}
case 1233:{f.Pc=f.Pop().Int==0?1453:1236;continue;}
case 1236:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1239;continue;}
case 1239:{f.StackOp("dup");f.Pc=1240;continue;}
case 1240:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1243);}
case 1243:{f.Locals[38]=f.Pop();f.Pc=1245;continue;}
case 1245:{f.Push(f.Locals[37]);f.Pc=1247;continue;}
case 1247:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1250);}
case 1250:{f.Pc=f.Pop().Int==0?1276:1253;continue;}
case 1253:{f.Push(f.Locals[6]);f.Pc=1255;continue;}
case 1255:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1258);}
case 1258:{f.Push(f.Locals[1]);f.Pc=1259;continue;}
case 1259:{f.Push(JValue.R(null));f.Pc=1260;continue;}
case 1260:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1263);}
case 1263:{f.Push(JValue.R(rt.String("lblNoValidCards")));f.Pc=1266;continue;}
case 1266:{f.Push(JValue.I(0));f.Pc=1267;continue;}
case 1267:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1270;continue;}
case 1270:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1273);}
case 1273:{return rt.Call(f,"forge/game/player/PlayerController","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;)V","invokevirtual",1276);}
case 1276:{f.Push(f.Locals[37]);f.Pc=1278;continue;}
case 1278:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1281);}
case 1281:{f.Pc=f.Pop().Int!=0?1403:1284;continue;}
case 1284:{f.Push(f.Locals[25]);f.Pc=1286;continue;}
case 1286:{f.Pc=f.Pop().Int!=0?1299:1289;continue;}
case 1289:{f.Push(f.Locals[38]);f.Pc=1291;continue;}
case 1291:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1294);}
case 1294:{f.Push(f.Locals[23]);f.Pc=1296;continue;}
case 1296:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1403:1299;continue;}
case 1299:{f.Push(f.Locals[6]);f.Pc=1301;continue;}
case 1301:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1304);}
case 1304:{f.Push(f.Locals[37]);f.Pc=1306;continue;}
case 1306:{f.Push(f.Locals[35]);f.Pc=1308;continue;}
case 1308:{f.Push(f.Locals[1]);f.Pc=1309;continue;}
case 1309:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1312);}
case 1312:{f.Push(JValue.R(rt.String("lblChooseOne")));f.Pc=1315;continue;}
case 1315:{f.Push(JValue.I(0));f.Pc=1316;continue;}
case 1316:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1319;continue;}
case 1319:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1322);}
case 1322:{f.Push(f.Locals[25]);f.Pc=1324;continue;}
case 1324:{f.Pc=f.Pop().Int!=0?1332:1327;continue;}
case 1327:{f.Push(f.Locals[14]);f.Pc=1329;continue;}
case 1329:{f.Pc=f.Pop().Int==0?1336:1332;continue;}
case 1332:{f.Push(JValue.I(1));f.Pc=1333;continue;}
case 1333:{f.Pc=1337;continue;}
case 1336:{f.Push(JValue.I(0));f.Pc=1337;continue;}
case 1337:{f.Push(f.Locals[30]);f.Pc=1339;continue;}
case 1339:{f.Push(JValue.R(null));f.Pc=1340;continue;}
case 1340:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLforge/game/player/Player;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",1343);}
case 1343:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1346;continue;}
case 1346:{f.Locals[39]=f.Pop();f.Pc=1348;continue;}
case 1348:{f.Push(f.Locals[39]);f.Pc=1350;continue;}
case 1350:{f.Pc=f.Pop().Reference!=null?1356:1353;continue;}
case 1353:{f.Pc=1403;continue;}
case 1356:{f.Push(f.Locals[38]);f.Pc=1358;continue;}
case 1358:{f.Push(f.Locals[39]);f.Pc=1360;continue;}
case 1360:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1363);}
case 1363:{f.StackOp("pop");f.Pc=1364;continue;}
case 1364:{f.Push(f.Locals[37]);f.Pc=1366;continue;}
case 1366:{f.Push(f.Locals[39]);f.Pc=1368;continue;}
case 1368:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",1371);}
case 1371:{f.StackOp("pop");f.Pc=1372;continue;}
case 1372:{f.Push(f.Locals[22]);f.Pc=1374;continue;}
case 1374:{f.Push(f.Locals[39]);f.Pc=1376;continue;}
case 1376:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",1379);}
case 1379:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=1380;continue;}
case 1380:{f.Locals[22]=f.Pop();f.Pc=1382;continue;}
case 1382:{f.Push(f.Locals[37]);f.Pc=1384;continue;}
case 1384:{f.Push(f.Locals[22]);f.Pc=1386;continue;}
case 1386:{return rt.DynamicCall(f,"forge/game/ability/effects/DigEffect:3340:1386:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",1391);}
case 1391:{f.Push(f.Locals[5]);f.Pc=1393;continue;}
case 1393:{f.Push(f.Locals[2]);f.Pc=1394;continue;}
case 1394:{f.Push(f.Locals[1]);f.Pc=1395;continue;}
case 1395:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1398);}
case 1398:{f.Locals[37]=f.Pop();f.Pc=1400;continue;}
case 1400:{f.Pc=1276;continue;}
case 1403:{f.Push(f.Locals[38]);f.Pc=1405;continue;}
case 1405:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1408);}
case 1408:{f.Pc=f.Pop().Int!=0?2119:1411;continue;}
case 1411:{f.Push(f.Locals[4]);f.Pc=1413;continue;}
case 1413:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1416);}
case 1416:{f.Push(f.Locals[38]);f.Pc=1418;continue;}
case 1418:{f.Push(f.Locals[6]);f.Pc=1420;continue;}
case 1420:{f.Push(JValue.I(1));f.Pc=1421;continue;}
case 1421:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1424);}
case 1424:{f.Push(JValue.R(rt.String("lblPlayerPickedChosen")));f.Pc=1427;continue;}
case 1427:{f.Push(JValue.I(2));f.Pc=1428;continue;}
case 1428:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1431;continue;}
case 1431:{f.StackOp("dup");f.Pc=1432;continue;}
case 1432:{f.Push(JValue.I(0));f.Pc=1433;continue;}
case 1433:{f.Push(f.Locals[6]);f.Pc=1435;continue;}
case 1435:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",1438);}
case 1438:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1439;continue;}
case 1439:{f.StackOp("dup");f.Pc=1440;continue;}
case 1440:{f.Push(JValue.I(1));f.Pc=1441;continue;}
case 1441:{f.Push(JValue.R(rt.String("")));f.Pc=1443;continue;}
case 1443:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1444;continue;}
case 1444:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1447);}
case 1447:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",1450);}
case 1450:{f.Pc=2119;continue;}
case 1453:{f.Push(f.Locals[1]);f.Pc=1454;continue;}
case 1454:{f.Push(JValue.R(rt.String("ForEachColorPair")));f.Pc=1457;continue;}
case 1457:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1460);}
case 1460:{f.Pc=f.Pop().Int==0?1611:1463;continue;}
case 1463:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1466;continue;}
case 1466:{f.StackOp("dup");f.Pc=1467;continue;}
case 1467:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1470);}
case 1470:{f.Locals[38]=f.Pop();f.Pc=1472;continue;}
case 1472:{if(!rt.StaticReady(f,"forge/card/MagicColor","COLORPAIR","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","COLORPAIR","[B"));f.Pc=1475;continue;}
case 1475:{f.Locals[39]=f.Pop();f.Pc=1477;continue;}
case 1477:{f.Push(f.Locals[39]);f.Pc=1479;continue;}
case 1479:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1480;continue;}
case 1480:{f.Locals[40]=f.Pop();f.Pc=1482;continue;}
case 1482:{f.Push(JValue.I(0));f.Pc=1483;continue;}
case 1483:{f.Locals[41]=f.Pop();f.Pc=1485;continue;}
case 1485:{f.Push(f.Locals[41]);f.Pc=1487;continue;}
case 1487:{f.Push(f.Locals[40]);f.Pc=1489;continue;}
case 1489:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1561:1492;continue;}
case 1492:{f.Push(f.Locals[39]);f.Pc=1494;continue;}
case 1494:{f.Push(f.Locals[41]);f.Pc=1496;continue;}
case 1496:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1497;continue;}
case 1497:{f.Locals[42]=f.Pop();f.Pc=1499;continue;}
case 1499:{f.Push(f.Locals[6]);f.Pc=1501;continue;}
case 1501:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1504);}
case 1504:{f.Push(f.Locals[37]);f.Pc=1506;continue;}
case 1506:{f.Push(f.Locals[42]);f.Pc=1508;continue;}
case 1508:{return rt.Call(f,"forge/game/card/CardPredicates","isExactlyColor","(B)Ljava/util/function/Predicate;","invokestatic",1511);}
case 1511:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",1514);}
case 1514:{f.Push(f.Locals[35]);f.Pc=1516;continue;}
case 1516:{f.Push(f.Locals[1]);f.Pc=1517;continue;}
case 1517:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1520);}
case 1520:{f.Push(JValue.R(rt.String("lblChooseOne")));f.Pc=1523;continue;}
case 1523:{f.Push(JValue.I(0));f.Pc=1524;continue;}
case 1524:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1527;continue;}
case 1527:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1530);}
case 1530:{f.Push(JValue.I(0));f.Pc=1531;continue;}
case 1531:{f.Push(f.Locals[30]);f.Pc=1533;continue;}
case 1533:{f.Push(JValue.R(null));f.Pc=1534;continue;}
case 1534:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLforge/game/player/Player;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",1537);}
case 1537:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1540;continue;}
case 1540:{f.Locals[43]=f.Pop();f.Pc=1542;continue;}
case 1542:{f.Push(f.Locals[43]);f.Pc=1544;continue;}
case 1544:{f.Pc=f.Pop().Reference==null?1555:1547;continue;}
case 1547:{f.Push(f.Locals[38]);f.Pc=1549;continue;}
case 1549:{f.Push(f.Locals[43]);f.Pc=1551;continue;}
case 1551:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1554);}
case 1554:{f.StackOp("pop");f.Pc=1555;continue;}
case 1555:{f.Locals[41]=JValue.I(unchecked(f.Locals[41].Int+(1)));f.Pc=1558;continue;}
case 1558:{f.Pc=1485;continue;}
case 1561:{f.Push(f.Locals[38]);f.Pc=1563;continue;}
case 1563:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1566);}
case 1566:{f.Pc=f.Pop().Int!=0?2119:1569;continue;}
case 1569:{f.Push(f.Locals[4]);f.Pc=1571;continue;}
case 1571:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1574);}
case 1574:{f.Push(f.Locals[38]);f.Pc=1576;continue;}
case 1576:{f.Push(f.Locals[6]);f.Pc=1578;continue;}
case 1578:{f.Push(JValue.I(1));f.Pc=1579;continue;}
case 1579:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1582);}
case 1582:{f.Push(JValue.R(rt.String("lblPlayerPickedChosen")));f.Pc=1585;continue;}
case 1585:{f.Push(JValue.I(2));f.Pc=1586;continue;}
case 1586:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1589;continue;}
case 1589:{f.StackOp("dup");f.Pc=1590;continue;}
case 1590:{f.Push(JValue.I(0));f.Pc=1591;continue;}
case 1591:{f.Push(f.Locals[6]);f.Pc=1593;continue;}
case 1593:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",1596);}
case 1596:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1597;continue;}
case 1597:{f.StackOp("dup");f.Pc=1598;continue;}
case 1598:{f.Push(JValue.I(1));f.Pc=1599;continue;}
case 1599:{f.Push(JValue.R(rt.String("")));f.Pc=1601;continue;}
case 1601:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1602;continue;}
case 1602:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1605);}
case 1605:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",1608);}
case 1608:{f.Pc=2119;continue;}
case 1611:{f.Push(f.Locals[1]);f.Pc=1612;continue;}
case 1612:{f.Push(JValue.R(rt.String("WithDifferentPowers")));f.Pc=1615;continue;}
case 1615:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1618);}
case 1618:{f.Pc=f.Pop().Int==0?1741:1621;continue;}
case 1621:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1624;continue;}
case 1624:{f.StackOp("dup");f.Pc=1625;continue;}
case 1625:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1628);}
case 1628:{f.Locals[38]=f.Pop();f.Pc=1630;continue;}
case 1630:{f.Push(f.Locals[37]);f.Pc=1632;continue;}
case 1632:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1635);}
case 1635:{f.Pc=f.Pop().Int!=0?2119:1638;continue;}
case 1638:{f.Push(f.Locals[25]);f.Pc=1640;continue;}
case 1640:{f.Pc=f.Pop().Int!=0?1653:1643;continue;}
case 1643:{f.Push(f.Locals[38]);f.Pc=1645;continue;}
case 1645:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1648);}
case 1648:{f.Push(f.Locals[23]);f.Pc=1650;continue;}
case 1650:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?2119:1653;continue;}
case 1653:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1656);}
case 1656:{f.Push(f.Locals[38]);f.Pc=1658;continue;}
case 1658:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1661);}
case 1661:{f.Pc=f.Pop().Int==0?1670:1664;continue;}
case 1664:{f.Push(JValue.R(rt.String("lblChooseCreature")));f.Pc=1667;continue;}
case 1667:{f.Pc=1673;continue;}
case 1670:{f.Push(JValue.R(rt.String("lblChooseCreatureWithDiffPower")));f.Pc=1673;continue;}
case 1673:{f.Push(JValue.I(0));f.Pc=1674;continue;}
case 1674:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1677;continue;}
case 1677:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1680);}
case 1680:{f.Locals[39]=f.Pop();f.Pc=1682;continue;}
case 1682:{f.Push(f.Locals[30]);f.Pc=1684;continue;}
case 1684:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1687);}
case 1687:{f.Push(f.Locals[37]);f.Pc=1689;continue;}
case 1689:{f.Push(f.Locals[1]);f.Pc=1690;continue;}
case 1690:{f.Push(f.Locals[39]);f.Pc=1692;continue;}
case 1692:{f.Push(JValue.I(1));f.Pc=1693;continue;}
case 1693:{f.Push(JValue.R(null));f.Pc=1694;continue;}
case 1694:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",1697);}
case 1697:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1700;continue;}
case 1700:{f.Locals[40]=f.Pop();f.Pc=1702;continue;}
case 1702:{f.Push(f.Locals[40]);f.Pc=1704;continue;}
case 1704:{f.Pc=f.Pop().Reference!=null?1710:1707;continue;}
case 1707:{f.Pc=2119;continue;}
case 1710:{f.Push(f.Locals[38]);f.Pc=1712;continue;}
case 1712:{f.Push(f.Locals[40]);f.Pc=1714;continue;}
case 1714:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1717);}
case 1717:{f.StackOp("pop");f.Pc=1718;continue;}
case 1718:{f.Push(f.Locals[37]);f.Pc=1720;continue;}
case 1720:{f.Push(f.Locals[40]);f.Pc=1722;continue;}
case 1722:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",1725);}
case 1725:{return rt.DynamicCall(f,"forge/game/ability/effects/DigEffect:3340:1725:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",1730);}
case 1730:{f.Push(f.Locals[3]);f.Pc=1731;continue;}
case 1731:{f.Push(f.Locals[2]);f.Pc=1732;continue;}
case 1732:{f.Push(f.Locals[1]);f.Pc=1733;continue;}
case 1733:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1736);}
case 1736:{f.Locals[37]=f.Pop();f.Pc=1738;continue;}
case 1738:{f.Pc=1630;continue;}
case 1741:{f.Push(f.Locals[1]);f.Pc=1742;continue;}
case 1742:{f.Push(JValue.R(rt.String("PrimaryPrompt")));f.Pc=1745;continue;}
case 1745:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1748);}
case 1748:{f.Pc=f.Pop().Int==0?1763:1751;continue;}
case 1751:{f.Push(f.Locals[1]);f.Pc=1752;continue;}
case 1752:{f.Push(JValue.R(rt.String("PrimaryPrompt")));f.Pc=1755;continue;}
case 1755:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1758);}
case 1758:{f.Locals[39]=f.Pop();f.Pc=1760;continue;}
case 1760:{f.Pc=1939;continue;}
case 1763:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1766);}
case 1766:{f.Push(JValue.R(rt.String("lblChooseCardsPutIntoZone")));f.Pc=1769;continue;}
case 1769:{f.Push(JValue.I(1));f.Pc=1770;continue;}
case 1770:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1773;continue;}
case 1773:{f.StackOp("dup");f.Pc=1774;continue;}
case 1774:{f.Push(JValue.I(0));f.Pc=1775;continue;}
case 1775:{f.Push(f.Locals[9]);f.Pc=1777;continue;}
case 1777:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",1780);}
case 1780:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1781;continue;}
case 1781:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1784);}
case 1784:{f.Locals[39]=f.Pop();f.Pc=1786;continue;}
case 1786:{f.Push(f.Locals[9]);f.Pc=1788;continue;}
case 1788:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=1791;continue;}
case 1791:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",1794);}
case 1794:{f.Pc=f.Pop().Int==0?1939:1797;continue;}
case 1797:{f.Push(f.Locals[10]);f.Pc=1799;continue;}
case 1799:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=1802;continue;}
case 1802:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",1805);}
case 1805:{f.Pc=f.Pop().Int!=0?1879:1808;continue;}
case 1808:{f.Push(f.Locals[23]);f.Pc=1810;continue;}
case 1810:{f.Push(JValue.I(1));f.Pc=1811;continue;}
case 1811:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1879:1814;continue;}
case 1814:{f.Push(f.Locals[11]);f.Pc=1816;continue;}
case 1816:{f.Pc=f.Pop().Int!=0?1845:1819;continue;}
case 1819:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1822);}
case 1822:{f.Push(JValue.R(rt.String("lblChooseACardToLeaveTargetLibraryTop")));f.Pc=1825;continue;}
case 1825:{f.Push(JValue.I(1));f.Pc=1826;continue;}
case 1826:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1829;continue;}
case 1829:{f.StackOp("dup");f.Pc=1830;continue;}
case 1830:{f.Push(JValue.I(0));f.Pc=1831;continue;}
case 1831:{f.Push(f.Locals[30]);f.Pc=1833;continue;}
case 1833:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",1836);}
case 1836:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1837;continue;}
case 1837:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1840);}
case 1840:{f.Locals[39]=f.Pop();f.Pc=1842;continue;}
case 1842:{f.Pc=1939;continue;}
case 1845:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1848);}
case 1848:{f.Push(JValue.R(rt.String("lblChooseACardLeaveTarget")));f.Pc=1851;continue;}
case 1851:{f.Push(JValue.I(2));f.Pc=1852;continue;}
case 1852:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1855;continue;}
case 1855:{f.StackOp("dup");f.Pc=1856;continue;}
case 1856:{f.Push(JValue.I(0));f.Pc=1857;continue;}
case 1857:{f.Push(f.Locals[30]);f.Pc=1859;continue;}
case 1859:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",1862);}
case 1862:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1863;continue;}
case 1863:{f.StackOp("dup");f.Pc=1864;continue;}
case 1864:{f.Push(JValue.I(1));f.Pc=1865;continue;}
case 1865:{f.Push(f.Locals[9]);f.Pc=1867;continue;}
case 1867:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",1870);}
case 1870:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1871;continue;}
case 1871:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1874);}
case 1874:{f.Locals[39]=f.Pop();f.Pc=1876;continue;}
case 1876:{f.Pc=1939;continue;}
case 1879:{f.Push(f.Locals[11]);f.Pc=1881;continue;}
case 1881:{f.Push(JValue.I(-1));f.Pc=1882;continue;}
case 1882:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1911:1885;continue;}
case 1885:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1888);}
case 1888:{f.Push(JValue.R(rt.String("lblChooseCardPutOnTargetLibraryBottom")));f.Pc=1891;continue;}
case 1891:{f.Push(JValue.I(1));f.Pc=1892;continue;}
case 1892:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1895;continue;}
case 1895:{f.StackOp("dup");f.Pc=1896;continue;}
case 1896:{f.Push(JValue.I(0));f.Pc=1897;continue;}
case 1897:{f.Push(f.Locals[30]);f.Pc=1899;continue;}
case 1899:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",1902);}
case 1902:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1903;continue;}
case 1903:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1906);}
case 1906:{f.Locals[39]=f.Pop();f.Pc=1908;continue;}
case 1908:{f.Pc=1939;continue;}
case 1911:{f.Push(f.Locals[11]);f.Pc=1913;continue;}
case 1913:{f.Pc=f.Pop().Int!=0?1939:1916;continue;}
case 1916:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1919);}
case 1919:{f.Push(JValue.R(rt.String("lblChooseCardPutOnTargetLibraryTop")));f.Pc=1922;continue;}
case 1922:{f.Push(JValue.I(1));f.Pc=1923;continue;}
case 1923:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1926;continue;}
case 1926:{f.StackOp("dup");f.Pc=1927;continue;}
case 1927:{f.Push(JValue.I(0));f.Pc=1928;continue;}
case 1928:{f.Push(f.Locals[30]);f.Pc=1930;continue;}
case 1930:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",1933);}
case 1933:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1934;continue;}
case 1934:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1937);}
case 1937:{f.Locals[39]=f.Pop();f.Pc=1939;continue;}
case 1939:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1942;continue;}
case 1942:{f.StackOp("dup");f.Pc=1943;continue;}
case 1943:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1946);}
case 1946:{f.Locals[38]=f.Pop();f.Pc=1948;continue;}
case 1948:{f.Push(f.Locals[37]);f.Pc=1950;continue;}
case 1950:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1953);}
case 1953:{f.Pc=f.Pop().Int==0?1982:1956;continue;}
case 1956:{f.Push(f.Locals[6]);f.Pc=1958;continue;}
case 1958:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1961);}
case 1961:{f.Push(f.Locals[1]);f.Pc=1962;continue;}
case 1962:{f.Push(JValue.R(null));f.Pc=1963;continue;}
case 1963:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1966);}
case 1966:{f.Push(JValue.R(rt.String("lblNoValidCards")));f.Pc=1969;continue;}
case 1969:{f.Push(JValue.I(0));f.Pc=1970;continue;}
case 1970:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1973;continue;}
case 1973:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1976);}
case 1976:{return rt.Call(f,"forge/game/player/PlayerController","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;)V","invokevirtual",1979);}
case 1979:{f.Pc=2058;continue;}
case 1982:{f.Push(f.Locals[25]);f.Pc=1984;continue;}
case 1984:{f.Pc=f.Pop().Int==0?1995:1987;continue;}
case 1987:{f.Push(f.Locals[37]);f.Pc=1989;continue;}
case 1989:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1992);}
case 1992:{f.Pc=2005;continue;}
case 1995:{f.Push(f.Locals[37]);f.Pc=1997;continue;}
case 1997:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",2000);}
case 2000:{f.Push(f.Locals[23]);f.Pc=2002;continue;}
case 2002:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",2005);}
case 2005:{f.Locals[40]=f.Pop();f.Pc=2007;continue;}
case 2007:{f.Push(f.Locals[25]);f.Pc=2009;continue;}
case 2009:{f.Pc=f.Pop().Int!=0?2017:2012;continue;}
case 2012:{f.Push(f.Locals[14]);f.Pc=2014;continue;}
case 2014:{f.Pc=f.Pop().Int==0?2021:2017;continue;}
case 2017:{f.Push(JValue.I(0));f.Pc=2018;continue;}
case 2018:{f.Pc=2023;continue;}
case 2021:{f.Push(f.Locals[40]);f.Pc=2023;continue;}
case 2023:{f.Locals[41]=f.Pop();f.Pc=2025;continue;}
case 2025:{f.Push(f.Locals[40]);f.Pc=2027;continue;}
case 2027:{f.Pc=f.Pop().Int<=0?2058:2030;continue;}
case 2030:{f.Push(f.Locals[38]);f.Pc=2032;continue;}
case 2032:{f.Push(f.Locals[6]);f.Pc=2034;continue;}
case 2034:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2037);}
case 2037:{f.Push(f.Locals[37]);f.Pc=2039;continue;}
case 2039:{f.Push(f.Locals[41]);f.Pc=2041;continue;}
case 2041:{f.Push(f.Locals[40]);f.Pc=2043;continue;}
case 2043:{f.Push(f.Locals[35]);f.Pc=2045;continue;}
case 2045:{f.Push(f.Locals[1]);f.Pc=2046;continue;}
case 2046:{f.Push(f.Locals[39]);f.Pc=2048;continue;}
case 2048:{f.Push(f.Locals[30]);f.Pc=2050;continue;}
case 2050:{f.Push(JValue.R(null));f.Pc=2051;continue;}
case 2051:{return rt.Call(f,"forge/game/player/PlayerController","chooseEntitiesForEffect","(Lforge/util/collect/FCollectionView;IILforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/Player;Ljava/util/Map;)Ljava/util/List;","invokevirtual",2054);}
case 2054:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",2057);}
case 2057:{f.StackOp("pop");f.Pc=2058;continue;}
case 2058:{f.Push(f.Locals[13]);f.Pc=2060;continue;}
case 2060:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",2063);}
case 2063:{f.Pc=f.Pop().Int!=0?2119:2066;continue;}
case 2066:{f.Push(f.Locals[1]);f.Pc=2067;continue;}
case 2067:{f.Push(JValue.R(rt.String("ExileFaceDown")));f.Pc=2069;continue;}
case 2069:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2072);}
case 2072:{f.Pc=f.Pop().Int!=0?2119:2075;continue;}
case 2075:{f.Push(f.Locals[1]);f.Pc=2076;continue;}
case 2076:{f.Push(JValue.R(rt.String("NoReveal")));f.Pc=2079;continue;}
case 2079:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2082);}
case 2082:{f.Pc=f.Pop().Int!=0?2119:2085;continue;}
case 2085:{f.Push(f.Locals[4]);f.Pc=2087;continue;}
case 2087:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",2090);}
case 2090:{f.Push(f.Locals[38]);f.Pc=2092;continue;}
case 2092:{f.Push(f.Locals[6]);f.Pc=2094;continue;}
case 2094:{f.Push(JValue.I(1));f.Pc=2095;continue;}
case 2095:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2098);}
case 2098:{f.Push(JValue.R(rt.String("lblPlayerPickedCardFrom")));f.Pc=2101;continue;}
case 2101:{f.Push(JValue.I(1));f.Pc=2102;continue;}
case 2102:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2105;continue;}
case 2105:{f.StackOp("dup");f.Pc=2106;continue;}
case 2106:{f.Push(JValue.I(0));f.Pc=2107;continue;}
case 2107:{f.Push(f.Locals[6]);f.Pc=2109;continue;}
case 2109:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",2112);}
case 2112:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2113;continue;}
case 2113:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2116);}
case 2116:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",2119);}
case 2119:{f.Push(f.Locals[1]);f.Pc=2120;continue;}
case 2120:{f.Push(JValue.R(rt.String("ForgetOtherRemembered")));f.Pc=2123;continue;}
case 2123:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2126);}
case 2126:{f.Pc=f.Pop().Int==0?2133:2129;continue;}
case 2129:{f.Push(f.Locals[2]);f.Pc=2130;continue;}
case 2130:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",2133);}
case 2133:{f.Push(f.Locals[38]);f.Pc=2135;continue;}
case 2135:{return rt.Call(f,"java/util/Collections","reverse","(Ljava/util/List;)V","invokestatic",2138);}
case 2138:{f.Push(f.Locals[9]);f.Pc=2140;continue;}
case 2140:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=2143;continue;}
case 2143:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",2146);}
case 2146:{f.Pc=f.Pop().Int!=0?2160:2149;continue;}
case 2149:{f.Push(f.Locals[9]);f.Pc=2151;continue;}
case 2151:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=2154;continue;}
case 2154:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",2157);}
case 2157:{f.Pc=f.Pop().Int==0?2205:2160;continue;}
case 2160:{f.Push(f.Locals[1]);f.Pc=2161;continue;}
case 2161:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=2164;continue;}
case 2164:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2167);}
case 2167:{f.Pc=f.Pop().Int==0?2190:2170;continue;}
case 2170:{f.Push(f.Locals[3]);f.Pc=2171;continue;}
case 2171:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2174);}
case 2174:{f.Push(f.Locals[32]);f.Pc=2176;continue;}
case 2176:{f.Push(f.Locals[10]);f.Pc=2178;continue;}
case 2178:{f.Push(f.Locals[1]);f.Pc=2179;continue;}
case 2179:{return rt.Call(f,"forge/game/player/PlayerController","orderMoveToZoneList","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",2182);}
case 2182:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2185;continue;}
case 2185:{f.Locals[38]=f.Pop();f.Pc=2187;continue;}
case 2187:{f.Pc=2205;continue;}
case 2190:{f.Push(f.Locals[4]);f.Pc=2192;continue;}
case 2192:{f.Push(f.Locals[38]);f.Pc=2194;continue;}
case 2194:{f.Push(f.Locals[9]);f.Pc=2196;continue;}
case 2196:{f.Push(f.Locals[1]);f.Pc=2197;continue;}
case 2197:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",2200);}
case 2200:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2203;continue;}
case 2203:{f.Locals[38]=f.Pop();f.Pc=2205;continue;}
case 2205:{f.Push(f.Locals[38]);f.Pc=2207;continue;}
case 2207:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2210);}
case 2210:{f.Locals[39]=f.Pop();f.Pc=2212;continue;}
case 2212:{f.Push(f.Locals[39]);f.Pc=2214;continue;}
case 2214:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2219);}
case 2219:{f.Pc=f.Pop().Int==0?2623:2222;continue;}
case 2222:{f.Push(f.Locals[39]);f.Pc=2224;continue;}
case 2224:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2229);}
case 2229:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2232;continue;}
case 2232:{f.Locals[40]=f.Pop();f.Pc=2234;continue;}
case 2234:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",2237);}
case 2237:{f.Locals[41]=f.Pop();f.Pc=2239;continue;}
case 2239:{f.Push(f.Locals[41]);f.Pc=2241;continue;}
case 2241:{f.Push(f.Locals[26]);f.Pc=2243;continue;}
case 2243:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",2246);}
case 2246:{f.Push(f.Locals[9]);f.Pc=2248;continue;}
case 2248:{return rt.Call(f,"forge/game/zone/ZoneType","isDeck","()Z","invokevirtual",2251);}
case 2251:{f.Pc=f.Pop().Int==0?2277:2254;continue;}
case 2254:{f.Push(f.Locals[4]);f.Pc=2256;continue;}
case 2256:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",2259);}
case 2259:{f.Push(f.Locals[9]);f.Pc=2261;continue;}
case 2261:{f.Push(f.Locals[40]);f.Pc=2263;continue;}
case 2263:{f.Push(f.Locals[11]);f.Pc=2265;continue;}
case 2265:{f.Push(f.Locals[1]);f.Pc=2266;continue;}
case 2266:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",2269);}
case 2269:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",2272);}
case 2272:{f.Locals[40]=f.Pop();f.Pc=2274;continue;}
case 2274:{f.Pc=2553;continue;}
case 2277:{f.Push(f.Locals[9]);f.Pc=2279;continue;}
case 2279:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=2282;continue;}
case 2282:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",2285);}
case 2285:{f.Pc=f.Pop().Int==0?2301:2288;continue;}
case 2288:{f.Push(f.Locals[40]);f.Pc=2290;continue;}
case 2290:{f.Push(f.Locals[1]);f.Pc=2291;continue;}
case 2291:{f.Push(JValue.I(1));f.Pc=2292;continue;}
case 2292:{return rt.Call(f,"forge/game/card/Card","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",2295);}
case 2295:{f.Pc=f.Pop().Int!=0?2301:2298;continue;}
case 2298:{f.Pc=2212;continue;}
case 2301:{f.Push(f.Locals[1]);f.Pc=2302;continue;}
case 2302:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=2305;continue;}
case 2305:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2308);}
case 2308:{f.Pc=f.Pop().Int==0?2317:2311;continue;}
case 2311:{f.Push(f.Locals[40]);f.Pc=2313;continue;}
case 2313:{f.Push(JValue.I(1));f.Pc=2314;continue;}
case 2314:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",2317);}
case 2317:{f.Push(f.Locals[1]);f.Pc=2318;continue;}
case 2318:{f.Push(JValue.R(rt.String("FaceDown")));f.Pc=2321;continue;}
case 2321:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2324);}
case 2324:{f.Pc=f.Pop().Int==0?2340:2327;continue;}
case 2327:{f.Push(f.Locals[40]);f.Pc=2329;continue;}
case 2329:{f.Push(JValue.I(1));f.Pc=2330;continue;}
case 2330:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",2333);}
case 2333:{f.StackOp("pop");f.Pc=2334;continue;}
case 2334:{f.Push(f.Locals[40]);f.Pc=2336;continue;}
case 2336:{f.Push(f.Locals[1]);f.Pc=2337;continue;}
case 2337:{return rt.Call(f,"forge/game/card/CardFactoryUtil","setFaceDownState","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",2340);}
case 2340:{f.Push(f.Locals[9]);f.Pc=2342;continue;}
case 2342:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=2345;continue;}
case 2345:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",2348);}
case 2348:{f.Pc=f.Pop().Int==0?2452:2351;continue;}
case 2351:{f.Push(f.Locals[41]);f.Pc=2353;continue;}
case 2353:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"));f.Pc=2356;continue;}
case 2356:{f.Push(f.Locals[38]);f.Pc=2358;continue;}
case 2358:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2363);}
case 2363:{f.StackOp("pop");f.Pc=2364;continue;}
case 2364:{f.Push(f.Locals[1]);f.Pc=2365;continue;}
case 2365:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=2368;continue;}
case 2368:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2371);}
case 2371:{f.Pc=f.Pop().Int==0?2385:2374;continue;}
case 2374:{f.Push(f.Locals[40]);f.Pc=2376;continue;}
case 2376:{f.Push(f.Locals[3]);f.Pc=2377;continue;}
case 2377:{f.Push(f.Locals[4]);f.Pc=2379;continue;}
case 2379:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",2382);}
case 2382:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",2385);}
case 2385:{f.Push(f.Locals[1]);f.Pc=2386;continue;}
case 2386:{f.Push(JValue.R(rt.String("WithCounters")));f.Pc=2388;continue;}
case 2388:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2391);}
case 2391:{f.Pc=f.Pop().Int==0?2452:2394;continue;}
case 2394:{f.Push(f.Locals[2]);f.Pc=2395;continue;}
case 2395:{f.Push(f.Locals[1]);f.Pc=2396;continue;}
case 2396:{f.Push(JValue.R(rt.String("WithCountersAmount")));f.Pc=2399;continue;}
case 2399:{f.Push(JValue.R(rt.String("1")));f.Pc=2401;continue;}
case 2401:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2404);}
case 2404:{f.Push(f.Locals[1]);f.Pc=2405;continue;}
case 2405:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",2408);}
case 2408:{f.Locals[42]=f.Pop();f.Pc=2410;continue;}
case 2410:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=2413;continue;}
case 2413:{f.StackOp("dup");f.Pc=2414;continue;}
case 2414:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",2417);}
case 2417:{f.Locals[43]=f.Pop();f.Pc=2419;continue;}
case 2419:{f.Push(f.Locals[43]);f.Pc=2421;continue;}
case 2421:{f.Push(f.Locals[3]);f.Pc=2422;continue;}
case 2422:{f.Push(f.Locals[40]);f.Pc=2424;continue;}
case 2424:{f.Push(f.Locals[1]);f.Pc=2425;continue;}
case 2425:{f.Push(JValue.R(rt.String("WithCounters")));f.Pc=2427;continue;}
case 2427:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2430);}
case 2430:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",2433);}
case 2433:{f.Push(f.Locals[42]);f.Pc=2435;continue;}
case 2435:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",2438);}
case 2438:{f.StackOp("pop");f.Pc=2439;continue;}
case 2439:{f.Push(f.Locals[41]);f.Pc=2441;continue;}
case 2441:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=2444;continue;}
case 2444:{f.Push(f.Locals[43]);f.Pc=2446;continue;}
case 2446:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2451);}
case 2451:{f.StackOp("pop");f.Pc=2452;continue;}
case 2452:{f.Push(f.Locals[4]);f.Pc=2454;continue;}
case 2454:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",2457);}
case 2457:{f.Push(f.Locals[40]);f.Pc=2459;continue;}
case 2459:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",2462);}
case 2462:{f.Push(f.Locals[9]);f.Pc=2464;continue;}
case 2464:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",2467);}
case 2467:{f.Push(f.Locals[40]);f.Pc=2469;continue;}
case 2469:{f.Push(f.Locals[1]);f.Pc=2470;continue;}
case 2470:{f.Push(f.Locals[41]);f.Pc=2472;continue;}
case 2472:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",2475);}
case 2475:{f.Locals[40]=f.Pop();f.Pc=2477;continue;}
case 2477:{f.Push(f.Locals[9]);f.Pc=2479;continue;}
case 2479:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=2482;continue;}
case 2482:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",2485);}
case 2485:{f.Pc=f.Pop().Int==0?2509:2488;continue;}
case 2488:{f.Push(f.Locals[40]);f.Pc=2490;continue;}
case 2490:{f.Push(f.Locals[1]);f.Pc=2491;continue;}
case 2491:{f.Push(JValue.R(rt.String("Attacking")));f.Pc=2494;continue;}
case 2494:{f.Push(JValue.R(rt.String("Blocking")));f.Pc=2497;continue;}
case 2497:{return rt.Call(f,"forge/game/ability/effects/DigEffect","addToCombat","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/String;)Z","invokestatic",2500);}
case 2500:{f.Pc=f.Pop().Int==0?2553:2503;continue;}
case 2503:{f.Push(JValue.I(1));f.Pc=2504;continue;}
case 2504:{f.Locals[28]=f.Pop();f.Pc=2506;continue;}
case 2506:{f.Pc=2553;continue;}
case 2509:{f.Push(f.Locals[9]);f.Pc=2511;continue;}
case 2511:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=2514;continue;}
case 2514:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",2517);}
case 2517:{f.Pc=f.Pop().Int==0?2553:2520;continue;}
case 2520:{f.Push(f.Locals[1]);f.Pc=2521;continue;}
case 2521:{f.Push(JValue.R(rt.String("ExileWithCounters")));f.Pc=2523;continue;}
case 2523:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2526);}
case 2526:{f.Pc=f.Pop().Int==0?2547:2529;continue;}
case 2529:{f.Push(f.Locals[40]);f.Pc=2531;continue;}
case 2531:{f.Push(f.Locals[1]);f.Pc=2532;continue;}
case 2532:{f.Push(JValue.R(rt.String("ExileWithCounters")));f.Pc=2534;continue;}
case 2534:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2537);}
case 2537:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",2540);}
case 2540:{f.Push(JValue.I(1));f.Pc=2541;continue;}
case 2541:{f.Push(f.Locals[3]);f.Pc=2542;continue;}
case 2542:{f.Push(f.Locals[27]);f.Pc=2544;continue;}
case 2544:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",2547);}
case 2547:{f.Push(f.Locals[40]);f.Pc=2549;continue;}
case 2549:{f.Push(f.Locals[1]);f.Pc=2550;continue;}
case 2550:{return rt.Call(f,"forge/game/ability/effects/DigEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",2553);}
case 2553:{f.Push(f.Locals[1]);f.Pc=2554;continue;}
case 2554:{f.Push(JValue.R(rt.String("ExileFaceDown")));f.Pc=2556;continue;}
case 2556:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2559);}
case 2559:{f.Pc=f.Pop().Int==0?2569:2562;continue;}
case 2562:{f.Push(f.Locals[40]);f.Pc=2564;continue;}
case 2564:{f.Push(JValue.I(1));f.Pc=2565;continue;}
case 2565:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",2568);}
case 2568:{f.StackOp("pop");f.Pc=2569;continue;}
case 2569:{f.Push(f.Locals[1]);f.Pc=2570;continue;}
case 2570:{f.Push(JValue.R(rt.String("WithMayLook")));f.Pc=2573;continue;}
case 2573:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2576);}
case 2576:{f.Pc=f.Pop().Int==0?2585:2579;continue;}
case 2579:{f.Push(f.Locals[40]);f.Pc=2581;continue;}
case 2581:{f.Push(f.Locals[3]);f.Pc=2582;continue;}
case 2582:{return rt.Call(f,"forge/game/card/Card","addMayLookFaceDownExile","(Lforge/game/player/Player;)V","invokevirtual",2585);}
case 2585:{f.Push(f.Locals[1]);f.Pc=2586;continue;}
case 2586:{f.Push(JValue.R(rt.String("Imprint")));f.Pc=2589;continue;}
case 2589:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2592);}
case 2592:{f.Pc=f.Pop().Int==0?2601:2595;continue;}
case 2595:{f.Push(f.Locals[2]);f.Pc=2596;continue;}
case 2596:{f.Push(f.Locals[40]);f.Pc=2598;continue;}
case 2598:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",2601);}
case 2601:{f.Push(f.Locals[19]);f.Pc=2603;continue;}
case 2603:{f.Pc=f.Pop().Int==0?2612:2606;continue;}
case 2606:{f.Push(f.Locals[2]);f.Pc=2607;continue;}
case 2607:{f.Push(f.Locals[40]);f.Pc=2609;continue;}
case 2609:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",2612);}
case 2612:{f.Push(f.Locals[32]);f.Pc=2614;continue;}
case 2614:{f.Push(f.Locals[40]);f.Pc=2616;continue;}
case 2616:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",2619);}
case 2619:{f.StackOp("pop");f.Pc=2620;continue;}
case 2620:{f.Pc=2212;continue;}
case 2623:{f.Push(f.Locals[32]);f.Pc=2625;continue;}
case 2625:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",2628);}
case 2628:{f.Pc=f.Pop().Int!=0?2635:2631;continue;}
case 2631:{f.Push(JValue.I(1));f.Pc=2632;continue;}
case 2632:{f.Pc=2636;continue;}
case 2635:{f.Push(JValue.I(0));f.Pc=2636;continue;}
case 2636:{f.Locals[39]=f.Pop();f.Pc=2638;continue;}
case 2638:{f.Push(f.Locals[39]);f.Pc=2640;continue;}
case 2640:{f.Pc=f.Pop().Int==0?2713:2643;continue;}
case 2643:{f.Push(f.Locals[1]);f.Pc=2644;continue;}
case 2644:{f.Push(JValue.R(rt.String("DestZone2Optional")));f.Pc=2647;continue;}
case 2647:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2650);}
case 2650:{f.Pc=f.Pop().Int==0?2713:2653;continue;}
case 2653:{f.Push(f.Locals[32]);f.Pc=2655;continue;}
case 2655:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",2658);}
case 2658:{f.Push(JValue.I(1));f.Pc=2659;continue;}
case 2659:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?2674:2662;continue;}
case 2662:{f.Push(f.Locals[32]);f.Pc=2664;continue;}
case 2664:{f.Push(JValue.I(0));f.Pc=2665;continue;}
case 2665:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",2668);}
case 2668:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2671;continue;}
case 2671:{f.Pc=2675;continue;}
case 2674:{f.Push(JValue.R(null));f.Pc=2675;continue;}
case 2675:{f.Locals[40]=f.Pop();f.Pc=2677;continue;}
case 2677:{f.Push(f.Locals[30]);f.Pc=2679;continue;}
case 2679:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2682);}
case 2682:{f.Push(f.Locals[1]);f.Pc=2683;continue;}
case 2683:{f.Push(JValue.R(null));f.Pc=2684;continue;}
case 2684:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2687);}
case 2687:{f.Push(JValue.R(rt.String("lblDoYouWantPutCardToZone")));f.Pc=2690;continue;}
case 2690:{f.Push(JValue.I(1));f.Pc=2691;continue;}
case 2691:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2694;continue;}
case 2694:{f.StackOp("dup");f.Pc=2695;continue;}
case 2695:{f.Push(JValue.I(0));f.Pc=2696;continue;}
case 2696:{f.Push(f.Locals[10]);f.Pc=2698;continue;}
case 2698:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",2701);}
case 2701:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2702;continue;}
case 2702:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2705);}
case 2705:{f.Push(f.Locals[40]);f.Pc=2707;continue;}
case 2707:{f.Push(JValue.R(null));f.Pc=2708;continue;}
case 2708:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",2711);}
case 2711:{f.Locals[39]=f.Pop();f.Pc=2713;continue;}
case 2713:{f.Push(f.Locals[39]);f.Pc=2715;continue;}
case 2715:{f.Pc=f.Pop().Int==0?3024:2718;continue;}
case 2718:{f.Push(f.Locals[10]);f.Pc=2720;continue;}
case 2720:{return rt.Call(f,"forge/game/zone/ZoneType","isDeck","()Z","invokevirtual",2723);}
case 2723:{f.Pc=f.Pop().Int!=0?2734:2726;continue;}
case 2726:{f.Push(f.Locals[10]);f.Pc=2728;continue;}
case 2728:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=2731;continue;}
case 2731:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?2890:2734;continue;}
case 2734:{f.Push(f.Locals[32]);f.Pc=2736;continue;}
case 2736:{f.Locals[40]=f.Pop();f.Pc=2738;continue;}
case 2738:{f.Push(f.Locals[1]);f.Pc=2739;continue;}
case 2739:{f.Push(JValue.R(rt.String("RestRandomOrder")));f.Pc=2741;continue;}
case 2741:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2744);}
case 2744:{f.Pc=f.Pop().Int==0?2755:2747;continue;}
case 2747:{f.Push(f.Locals[40]);f.Pc=2749;continue;}
case 2749:{return rt.Call(f,"forge/game/card/CardLists","shuffle","(Ljava/util/List;)V","invokestatic",2752);}
case 2752:{f.Pc=2813;continue;}
case 2755:{f.Push(f.Locals[15]);f.Pc=2757;continue;}
case 2757:{f.Pc=f.Pop().Int!=0?2813:2760;continue;}
case 2760:{f.Push(f.Locals[32]);f.Pc=2762;continue;}
case 2762:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",2765);}
case 2765:{f.Push(JValue.I(1));f.Pc=2766;continue;}
case 2766:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2813:2769;continue;}
case 2769:{f.Push(f.Locals[10]);f.Pc=2771;continue;}
case 2771:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=2774;continue;}
case 2774:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?2795:2777;continue;}
case 2777:{f.Push(f.Locals[4]);f.Pc=2779;continue;}
case 2779:{f.Push(f.Locals[32]);f.Pc=2781;continue;}
case 2781:{f.Push(f.Locals[10]);f.Pc=2783;continue;}
case 2783:{f.Push(f.Locals[1]);f.Pc=2784;continue;}
case 2784:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",2787);}
case 2787:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2790;continue;}
case 2790:{f.Locals[40]=f.Pop();f.Pc=2792;continue;}
case 2792:{f.Pc=2813;continue;}
case 2795:{f.Push(f.Locals[6]);f.Pc=2797;continue;}
case 2797:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2800);}
case 2800:{f.Push(f.Locals[32]);f.Pc=2802;continue;}
case 2802:{f.Push(f.Locals[10]);f.Pc=2804;continue;}
case 2804:{f.Push(f.Locals[1]);f.Pc=2805;continue;}
case 2805:{return rt.Call(f,"forge/game/player/PlayerController","orderMoveToZoneList","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",2808);}
case 2808:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2811;continue;}
case 2811:{f.Locals[40]=f.Pop();f.Pc=2813;continue;}
case 2813:{f.Push(f.Locals[40]);f.Pc=2815;continue;}
case 2815:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2818);}
case 2818:{f.Locals[41]=f.Pop();f.Pc=2820;continue;}
case 2820:{f.Push(f.Locals[41]);f.Pc=2822;continue;}
case 2822:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2827);}
case 2827:{f.Pc=f.Pop().Int==0?2887:2830;continue;}
case 2830:{f.Push(f.Locals[41]);f.Pc=2832;continue;}
case 2832:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2837);}
case 2837:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2840;continue;}
case 2840:{f.Locals[42]=f.Pop();f.Pc=2842;continue;}
case 2842:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",2845);}
case 2845:{f.Locals[43]=f.Pop();f.Pc=2847;continue;}
case 2847:{f.Push(f.Locals[43]);f.Pc=2849;continue;}
case 2849:{f.Push(f.Locals[26]);f.Pc=2851;continue;}
case 2851:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",2854);}
case 2854:{f.Push(f.Locals[4]);f.Pc=2856;continue;}
case 2856:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",2859);}
case 2859:{f.Push(f.Locals[10]);f.Pc=2861;continue;}
case 2861:{f.Push(f.Locals[42]);f.Pc=2863;continue;}
case 2863:{f.Push(f.Locals[12]);f.Pc=2865;continue;}
case 2865:{f.Push(f.Locals[1]);f.Pc=2866;continue;}
case 2866:{f.Push(f.Locals[43]);f.Pc=2868;continue;}
case 2868:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",2871);}
case 2871:{f.Locals[44]=f.Pop();f.Pc=2873;continue;}
case 2873:{f.Push(f.Locals[20]);f.Pc=2875;continue;}
case 2875:{f.Pc=f.Pop().Int==0?2884:2878;continue;}
case 2878:{f.Push(f.Locals[2]);f.Pc=2879;continue;}
case 2879:{f.Push(f.Locals[44]);f.Pc=2881;continue;}
case 2881:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",2884);}
case 2884:{f.Pc=2820;continue;}
case 2887:{f.Pc=3024;continue;}
case 2890:{f.Push(f.Locals[32]);f.Pc=2892;continue;}
case 2892:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2895);}
case 2895:{f.Locals[40]=f.Pop();f.Pc=2897;continue;}
case 2897:{f.Push(f.Locals[40]);f.Pc=2899;continue;}
case 2899:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2904);}
case 2904:{f.Pc=f.Pop().Int==0?3024:2907;continue;}
case 2907:{f.Push(f.Locals[40]);f.Pc=2909;continue;}
case 2909:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2914);}
case 2914:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2917;continue;}
case 2917:{f.Locals[41]=f.Pop();f.Pc=2919;continue;}
case 2919:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",2922);}
case 2922:{f.Locals[42]=f.Pop();f.Pc=2924;continue;}
case 2924:{f.Push(f.Locals[42]);f.Pc=2926;continue;}
case 2926:{f.Push(f.Locals[26]);f.Pc=2928;continue;}
case 2928:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",2931);}
case 2931:{f.Push(f.Locals[10]);f.Pc=2933;continue;}
case 2933:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=2936;continue;}
case 2936:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?2952:2939;continue;}
case 2939:{f.Push(f.Locals[41]);f.Pc=2941;continue;}
case 2941:{f.Push(f.Locals[1]);f.Pc=2942;continue;}
case 2942:{f.Push(JValue.I(1));f.Pc=2943;continue;}
case 2943:{return rt.Call(f,"forge/game/card/Card","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",2946);}
case 2946:{f.Pc=f.Pop().Int!=0?2952:2949;continue;}
case 2949:{f.Pc=2897;continue;}
case 2952:{f.Push(f.Locals[4]);f.Pc=2954;continue;}
case 2954:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",2957);}
case 2957:{f.Push(f.Locals[10]);f.Pc=2959;continue;}
case 2959:{f.Push(f.Locals[41]);f.Pc=2961;continue;}
case 2961:{f.Push(f.Locals[1]);f.Pc=2962;continue;}
case 2962:{f.Push(f.Locals[42]);f.Pc=2964;continue;}
case 2964:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",2967);}
case 2967:{f.Locals[41]=f.Pop();f.Pc=2969;continue;}
case 2969:{f.Push(f.Locals[10]);f.Pc=2971;continue;}
case 2971:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=2974;continue;}
case 2974:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?3021:2977;continue;}
case 2977:{f.Push(f.Locals[1]);f.Pc=2978;continue;}
case 2978:{f.Push(JValue.R(rt.String("ExileWithCounters")));f.Pc=2980;continue;}
case 2980:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2983);}
case 2983:{f.Pc=f.Pop().Int==0?3004:2986;continue;}
case 2986:{f.Push(f.Locals[41]);f.Pc=2988;continue;}
case 2988:{f.Push(f.Locals[1]);f.Pc=2989;continue;}
case 2989:{f.Push(JValue.R(rt.String("ExileWithCounters")));f.Pc=2991;continue;}
case 2991:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2994);}
case 2994:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",2997);}
case 2997:{f.Push(JValue.I(1));f.Pc=2998;continue;}
case 2998:{f.Push(f.Locals[3]);f.Pc=2999;continue;}
case 2999:{f.Push(f.Locals[27]);f.Pc=3001;continue;}
case 3001:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",3004);}
case 3004:{f.Push(f.Locals[41]);f.Pc=3006;continue;}
case 3006:{f.Push(f.Locals[1]);f.Pc=3007;continue;}
case 3007:{return rt.Call(f,"forge/game/ability/effects/DigEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",3010);}
case 3010:{f.Push(f.Locals[20]);f.Pc=3012;continue;}
case 3012:{f.Pc=f.Pop().Int==0?3021:3015;continue;}
case 3015:{f.Push(f.Locals[2]);f.Pc=3016;continue;}
case 3016:{f.Push(f.Locals[41]);f.Pc=3018;continue;}
case 3018:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",3021);}
case 3021:{f.Pc=2897;continue;}
case 3024:{f.Pc=450;continue;}
case 3027:{f.Push(f.Locals[28]);f.Pc=3029;continue;}
case 3029:{f.Pc=f.Pop().Int==0?3049:3032;continue;}
case 3032:{f.Push(f.Locals[4]);f.Pc=3034;continue;}
case 3034:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",3037);}
case 3037:{f.Push(f.Locals[4]);f.Pc=3039;continue;}
case 3039:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=3042;continue;}
case 3042:{f.StackOp("dup");f.Pc=3043;continue;}
case 3043:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",3046);}
case 3046:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",3049);}
case 3049:{f.Push(f.Locals[26]);f.Pc=3051;continue;}
case 3051:{f.Push(f.Locals[4]);f.Pc=3053;continue;}
case 3053:{f.Push(f.Locals[1]);f.Pc=3054;continue;}
case 3054:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",3057);}
case 3057:{f.Push(f.Locals[27]);f.Pc=3059;continue;}
case 3059:{f.Push(f.Locals[4]);f.Pc=3061;continue;}
case 3061:{f.Push(f.Locals[1]);f.Pc=3062;continue;}
case 3062:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",3065);}
case 3065:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

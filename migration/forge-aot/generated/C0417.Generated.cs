// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C417{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/TokenEffect","forge/game/ability/effects/TokenEffectBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3782,"forge/game/ability/effects/TokenEffect","<init>","()V",1,1,1,new JHandler[]{},M3782));
c.Add(new JMethod(3783,"forge/game/ability/effects/TokenEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,14,5,new JHandler[]{},M3783));
c.Add(new JMethod(3784,"forge/game/ability/effects/TokenEffect","tokenDescriptionFromScript","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",2,18,4,new JHandler[]{},M3784));
c.Add(new JMethod(3785,"forge/game/ability/effects/TokenEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,8,8,new JHandler[]{},M3785));
}

internal static JStep M3782(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3783(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?476:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("\\s*\\([^)]*\\)")));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",34);}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Reference==null?60:41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("Populate")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?60:51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String(",? then populate\\.?$")));f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String(".")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",59);}
case 59:{f.Locals[3]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String(" ")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",66);}
case 66:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",69);}
case 69:{f.Locals[5]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("TokenOwner")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/ability/effects/TokenEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",77);}
case 77:{f.Locals[6]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",87);}
case 87:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("Create")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int!=0?181:98;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String(" create")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?181:107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String(" create")));f.Pc=110;continue;}
case 110:{f.Push(JValue.I(2));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",114);}
case 114:{f.Locals[7]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[7]);f.Pc=118;continue;}
case 118:{f.Push(JValue.I(0));f.Pc=119;continue;}
case 119:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[6]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",125);}
case 125:{f.Push(f.Locals[7]);f.Pc=127;continue;}
case 127:{f.Push(JValue.I(1));f.Pc=128;continue;}
case 128:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=129;continue;}
case 129:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffect:3783:129:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",134);}
case 134:{f.Locals[3]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[6]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",142);}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?155:146;continue;}
case 146:{f.Push(f.Locals[3]);f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String(" create ")));f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String(" creates ")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",154);}
case 154:{f.Locals[3]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[3]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("you")));f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",161);}
case 161:{f.Pc=f.Pop().Int==0?178:164;continue;}
case 164:{f.Push(f.Locals[3]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("you")));f.Pc=167;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",171);}
case 171:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",174);}
case 174:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",177);}
case 177:{f.Locals[3]=f.Pop();f.Pc=178;continue;}
case 178:{f.Pc=474;continue;}
case 181:{f.Push(f.Locals[3]);f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String("Create")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","containsIgnoreCase","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z","invokestatic",187);}
case 187:{f.Pc=f.Pop().Int==0?474:190;continue;}
case 190:{f.Push(f.Locals[6]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",197);}
case 197:{f.Push(JValue.I(1));f.Pc=198;continue;}
case 198:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?206:201;continue;}
case 201:{f.Push(JValue.R(rt.String("creates")));f.Pc=203;continue;}
case 203:{f.Pc=208;continue;}
case 206:{f.Push(JValue.R(rt.String("create")));f.Pc=208;continue;}
case 208:{f.Locals[7]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[6]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",215);}
case 215:{f.Push(f.Locals[7]);f.Pc=217;continue;}
case 217:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffect:3783:217:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",222);}
case 222:{f.Locals[8]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[3]);f.Pc=225;continue;}
case 225:{f.Push(JValue.R(rt.String("Create")));f.Pc=227;continue;}
case 227:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",230);}
case 230:{f.Pc=f.Pop().Int==0?238:233;continue;}
case 233:{f.Push(JValue.R(rt.String("Create")));f.Pc=235;continue;}
case 235:{f.Pc=240;continue;}
case 238:{f.Push(JValue.R(rt.String("create")));f.Pc=240;continue;}
case 240:{f.Locals[9]=f.Pop();f.Pc=242;continue;}
case 242:{f.Push(f.Locals[3]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[9]);f.Pc=245;continue;}
case 245:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffect:3783:245:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",250);}
case 250:{f.Push(JValue.R(rt.String("")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",255);}
case 255:{f.Locals[3]=f.Pop();f.Pc=256;continue;}
case 256:{f.Push(f.Locals[8]);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[3]);f.Pc=259;continue;}
case 259:{f.Push(JValue.R(rt.String("\\. Create ")));f.Pc=261;continue;}
case 261:{f.Push(f.Locals[6]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",266);}
case 266:{f.Push(f.Locals[7]);f.Pc=268;continue;}
case 268:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffect:3783:268:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",273);}
case 273:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",276);}
case 276:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffect:3783:276:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",281);}
case 281:{f.Locals[3]=f.Pop();f.Pc=282;continue;}
case 282:{f.Push(f.Locals[1]);f.Pc=283;continue;}
case 283:{f.Push(JValue.R(rt.String("TokenAmount")));f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",288);}
case 288:{f.Pc=f.Pop().Int==0?465:291;continue;}
case 291:{f.Push(f.Locals[1]);f.Pc=292;continue;}
case 292:{f.Push(JValue.R(rt.String("TokenAmount")));f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",297);}
case 297:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",300);}
case 300:{f.Pc=f.Pop().Int!=0?465:303;continue;}
case 303:{f.Push(f.Locals[2]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{f.Push(JValue.R(rt.String("TokenAmount")));f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",310);}
case 310:{f.Push(f.Locals[1]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",314);}
case 314:{f.Locals[10]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[10]);f.Pc=318;continue;}
case 318:{f.Pc=f.Pop().Int==0?465:321;continue;}
case 321:{f.Push(f.Locals[10]);f.Pc=323;continue;}
case 323:{f.Push(JValue.I(1));f.Pc=324;continue;}
case 324:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?387:327;continue;}
case 327:{f.Push(f.Locals[10]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",332);}
case 332:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffect:3783:332:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",337);}
case 337:{f.Locals[11]=f.Pop();f.Pc=339;continue;}
case 339:{f.Push(f.Locals[3]);f.Pc=340;continue;}
case 340:{f.Push(JValue.R(rt.String(" ")));f.Pc=342;continue;}
case 342:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",345);}
case 345:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",348);}
case 348:{f.Locals[12]=f.Pop();f.Pc=350;continue;}
case 350:{f.Push(f.Locals[12]);f.Pc=352;continue;}
case 352:{f.Push(f.Locals[12]);f.Pc=354;continue;}
case 354:{f.Push(f.Locals[7]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/util/List","indexOf","(Ljava/lang/Object;)I","invokeinterface",361);}
case 361:{f.Push(JValue.I(1));f.Pc=362;continue;}
case 362:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",368);}
case 368:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=371;continue;}
case 371:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffect:3783:371:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",376);}
case 376:{f.Locals[13]=f.Pop();f.Pc=378;continue;}
case 378:{f.Push(f.Locals[3]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[13]);f.Pc=381;continue;}
case 381:{f.Push(f.Locals[11]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",386);}
case 386:{f.Locals[3]=f.Pop();f.Pc=387;continue;}
case 387:{f.Push(JValue.R(null));f.Pc=388;continue;}
case 388:{f.Locals[11]=f.Pop();f.Pc=390;continue;}
case 390:{f.Push(f.Locals[3]);f.Pc=391;continue;}
case 391:{f.Push(JValue.R(rt.String(", where")));f.Pc=393;continue;}
case 393:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",396);}
case 396:{f.Pc=f.Pop().Int==0?406:399;continue;}
case 399:{f.Push(JValue.R(rt.String(", where")));f.Pc=401;continue;}
case 401:{f.Locals[11]=f.Pop();f.Pc=403;continue;}
case 403:{f.Pc=419;continue;}
case 406:{f.Push(f.Locals[3]);f.Pc=407;continue;}
case 407:{f.Push(JValue.R(rt.String(" for each")));f.Pc=409;continue;}
case 409:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",412);}
case 412:{f.Pc=f.Pop().Int==0?419:415;continue;}
case 415:{f.Push(JValue.R(rt.String(" for each")));f.Pc=417;continue;}
case 417:{f.Locals[11]=f.Pop();f.Pc=419;continue;}
case 419:{f.Push(f.Locals[11]);f.Pc=421;continue;}
case 421:{f.Pc=f.Pop().Reference==null?465:424;continue;}
case 424:{f.Push(f.Locals[3]);f.Pc=425;continue;}
case 425:{f.Push(f.Locals[11]);f.Pc=427;continue;}
case 427:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",430);}
case 430:{f.Push(JValue.I(0));f.Pc=431;continue;}
case 431:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=432;continue;}
case 432:{f.Locals[3]=f.Pop();f.Pc=433;continue;}
case 433:{f.Push(f.Locals[3]);f.Pc=434;continue;}
case 434:{f.Push(JValue.R(rt.String("token")));f.Pc=436;continue;}
case 436:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",439);}
case 439:{f.Pc=f.Pop().Int==0?458:442;continue;}
case 442:{f.Push(f.Locals[10]);f.Pc=444;continue;}
case 444:{f.Push(JValue.I(1));f.Pc=445;continue;}
case 445:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?458:448;continue;}
case 448:{f.Push(f.Locals[3]);f.Pc=449;continue;}
case 449:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffect:3783:449:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",454);}
case 454:{f.Locals[3]=f.Pop();f.Pc=455;continue;}
case 455:{f.Pc=465;continue;}
case 458:{f.Push(f.Locals[3]);f.Pc=459;continue;}
case 459:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffect:3783:459:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",464);}
case 464:{f.Locals[3]=f.Pop();f.Pc=465;continue;}
case 465:{f.Push(f.Locals[3]);f.Pc=466;continue;}
case 466:{f.Push(JValue.R(rt.String("you control")));f.Pc=468;continue;}
case 468:{f.Push(JValue.R(rt.String("they control")));f.Pc=470;continue;}
case 470:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",473);}
case 473:{f.Locals[3]=f.Pop();f.Pc=474;continue;}
case 474:{f.Push(f.Locals[3]);f.Pc=475;continue;}
case 475:{return JStep.Return(f.Pop());}
case 476:{f.Push(f.Locals[0]);f.Pc=477;continue;}
case 477:{f.Push(f.Locals[1]);f.Pc=478;continue;}
case 478:{return rt.Call(f,"forge/game/ability/effects/TokenEffect","tokenDescriptionFromScript","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",481);}
case 481:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3784(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("TokenScript")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?16:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("TokenOwner")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/ability/effects/TokenEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("TokenAmount")));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("1")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",37);}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",43);}
case 43:{f.Locals[5]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",50);}
case 50:{f.Pc=f.Pop().Int!=0?62:53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{f.Pc=f.Pop().Int!=0?62:58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{f.Pc=63;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{f.Locals[6]=f.Pop();f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",72);}
case 72:{f.Locals[7]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String(",")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",80);}
case 80:{f.Locals[8]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[8]);f.Pc=84;continue;}
case 84:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=85;continue;}
case 85:{f.Locals[9]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(JValue.I(0));f.Pc=88;continue;}
case 88:{f.Locals[10]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[10]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[9]);f.Pc=94;continue;}
case 94:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?461:97;continue;}
case 97:{f.Push(f.Locals[8]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[10]);f.Pc=101;continue;}
case 101:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=102;continue;}
case 102:{f.Locals[11]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[11]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",113);}
case 113:{f.Pc=f.Pop().Int==0?123:116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",120);}
case 120:{f.Pc=133;continue;}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{f.Push(JValue.I(0));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",130);}
case 130:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=133;continue;}
case 133:{f.Push(JValue.I(0));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/card/token/TokenInfo","getProtoType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Lforge/game/card/Card;","invokestatic",137);}
case 137:{f.Locals[12]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[12]);f.Pc=141;continue;}
case 141:{f.Pc=f.Pop().Reference!=null?147:144;continue;}
case 144:{f.Pc=455;continue;}
case 147:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=150;continue;}
case 150:{f.StackOp("dup");f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",154);}
case 154:{f.Locals[13]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[12]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",161);}
case 161:{return rt.Call(f,"forge/game/card/CardState","getType","()Lforge/card/CardTypeView;","invokevirtual",164);}
case 164:{return rt.Call(f,"forge/card/CardTypeView","isCreature","()Z","invokeinterface",169);}
case 169:{f.Pc=f.Pop().Int==0?201:172;continue;}
case 172:{f.Push(f.Locals[13]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[12]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",179);}
case 179:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",182);}
case 182:{f.Push(JValue.R(rt.String("/")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",187);}
case 187:{f.Push(f.Locals[12]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",192);}
case 192:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",195);}
case 195:{f.Push(JValue.R(rt.String(" ")));f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",200);}
case 200:{f.StackOp("pop");f.Pc=201;continue;}
case 201:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=204;continue;}
case 204:{f.StackOp("dup");f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",208);}
case 208:{f.Locals[14]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[12]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",215);}
case 215:{return rt.Call(f,"forge/card/ColorSet","iterator","()Ljava/util/Iterator;","invokevirtual",218);}
case 218:{f.Locals[15]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(f.Locals[15]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",227);}
case 227:{f.Pc=f.Pop().Int==0?258:230;continue;}
case 230:{f.Push(f.Locals[15]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",237);}
case 237:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/MagicColor$Color"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=240;continue;}
case 240:{f.Locals[16]=f.Pop();f.Pc=242;continue;}
case 242:{f.Push(f.Locals[14]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[16]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/card/MagicColor$Color","getName","()Ljava/lang/String;","invokevirtual",249);}
case 249:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",254);}
case 254:{f.StackOp("pop");f.Pc=255;continue;}
case 255:{f.Pc=220;continue;}
case 258:{f.Push(f.Locals[13]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[14]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",267);}
case 267:{f.Pc=f.Pop().Int==0?275:270;continue;}
case 270:{f.Push(JValue.R(rt.String("")));f.Pc=272;continue;}
case 272:{f.Pc=285;continue;}
case 275:{f.Push(f.Locals[14]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",280);}
case 280:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffect:3784:280:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",285);}
case 285:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",288);}
case 288:{f.StackOp("pop");f.Pc=289;continue;}
case 289:{f.Push(f.Locals[13]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[12]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",296);}
case 296:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",299);}
case 299:{f.Push(JValue.R(rt.String(" ")));f.Pc=301;continue;}
case 301:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",304);}
case 304:{f.Push(f.Locals[12]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",309);}
case 309:{return rt.Call(f,"forge/card/CardTypeView","isCreature","()Z","invokeinterface",314);}
case 314:{f.Pc=f.Pop().Int==0?323:317;continue;}
case 317:{f.Push(JValue.R(rt.String("creature ")));f.Pc=320;continue;}
case 320:{f.Pc=325;continue;}
case 323:{f.Push(JValue.R(rt.String("")));f.Pc=325;continue;}
case 325:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",328);}
case 328:{f.Push(f.Locals[6]);f.Pc=330;continue;}
case 330:{f.Pc=f.Pop().Int!=0?339:333;continue;}
case 333:{f.Push(f.Locals[5]);f.Pc=335;continue;}
case 335:{f.Push(JValue.I(1));f.Pc=336;continue;}
case 336:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?345:339;continue;}
case 339:{f.Push(JValue.R(rt.String("tokens")));f.Pc=342;continue;}
case 342:{f.Pc=347;continue;}
case 345:{f.Push(JValue.R(rt.String("token")));f.Pc=347;continue;}
case 347:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",350);}
case 350:{f.StackOp("pop");f.Pc=351;continue;}
case 351:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=354;continue;}
case 354:{f.StackOp("dup");f.Pc=355;continue;}
case 355:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",358);}
case 358:{f.Locals[15]=f.Pop();f.Pc=360;continue;}
case 360:{f.Push(f.Locals[12]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",365);}
case 365:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",370);}
case 370:{f.Locals[16]=f.Pop();f.Pc=372;continue;}
case 372:{f.Push(f.Locals[16]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",379);}
case 379:{f.Pc=f.Pop().Int==0?415:382;continue;}
case 382:{f.Push(f.Locals[16]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",389);}
case 389:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=392;continue;}
case 392:{f.Locals[17]=f.Pop();f.Pc=394;continue;}
case 394:{f.Push(f.Locals[15]);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[17]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",403);}
case 403:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",406);}
case 406:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",411);}
case 411:{f.StackOp("pop");f.Pc=412;continue;}
case 412:{f.Pc=372;continue;}
case 415:{f.Push(f.Locals[15]);f.Pc=417;continue;}
case 417:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",422);}
case 422:{f.Pc=f.Pop().Int!=0?442:425;continue;}
case 425:{f.Push(f.Locals[13]);f.Pc=427;continue;}
case 427:{f.Push(JValue.R(rt.String(" with ")));f.Pc=430;continue;}
case 430:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",433);}
case 433:{f.Push(f.Locals[15]);f.Pc=435;continue;}
case 435:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",438);}
case 438:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",441);}
case 441:{f.StackOp("pop");f.Pc=442;continue;}
case 442:{f.Push(f.Locals[7]);f.Pc=444;continue;}
case 444:{f.Push(f.Locals[13]);f.Pc=446;continue;}
case 446:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",449);}
case 449:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",454);}
case 454:{f.StackOp("pop");f.Pc=455;continue;}
case 455:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=458;continue;}
case 458:{f.Pc=90;continue;}
case 461:{f.Push(f.Locals[7]);f.Pc=463;continue;}
case 463:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",468);}
case 468:{f.Pc=f.Pop().Int==0?476:471;continue;}
case 471:{f.Push(f.Locals[1]);f.Pc=472;continue;}
case 472:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",475);}
case 475:{return JStep.Return(f.Pop());}
case 476:{f.Push(f.Locals[6]);f.Pc=478;continue;}
case 478:{f.Pc=f.Pop().Int==0?487:481;continue;}
case 481:{f.Push(JValue.R(rt.String("X")));f.Pc=484;continue;}
case 484:{f.Pc=504;continue;}
case 487:{f.Push(f.Locals[5]);f.Pc=489;continue;}
case 489:{f.Push(JValue.I(1));f.Pc=490;continue;}
case 490:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?499:493;continue;}
case 493:{f.Push(JValue.R(rt.String("a")));f.Pc=496;continue;}
case 496:{f.Pc=504;continue;}
case 499:{f.Push(f.Locals[5]);f.Pc=501;continue;}
case 501:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",504);}
case 504:{f.Locals[8]=f.Pop();f.Pc=506;continue;}
case 506:{f.Push(f.Locals[7]);f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",511);}
case 511:{f.Locals[9]=f.Pop();f.Pc=513;continue;}
case 513:{f.Push(f.Locals[6]);f.Pc=515;continue;}
case 515:{f.Pc=f.Pop().Int!=0?537:518;continue;}
case 518:{f.Push(f.Locals[5]);f.Pc=520;continue;}
case 520:{f.Push(JValue.I(1));f.Pc=521;continue;}
case 521:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?537:524;continue;}
case 524:{f.Push(f.Locals[9]);f.Pc=526;continue;}
case 526:{f.Push(JValue.R(rt.String(" tokens")));f.Pc=529;continue;}
case 529:{f.Push(JValue.R(rt.String(" token")));f.Pc=532;continue;}
case 532:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",535);}
case 535:{f.Locals[9]=f.Pop();f.Pc=537;continue;}
case 537:{f.Push(f.Locals[1]);f.Pc=538;continue;}
case 538:{f.Push(f.Locals[3]);f.Pc=539;continue;}
case 539:{f.Push(JValue.R(rt.String("TokenOwner")));f.Pc=541;continue;}
case 541:{return rt.Call(f,"forge/game/ability/effects/TokenEffect","playersOrDescribed","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokestatic",544);}
case 544:{f.Push(f.Locals[3]);f.Pc=545;continue;}
case 545:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",550);}
case 550:{f.Push(JValue.I(1));f.Pc=551;continue;}
case 551:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?559:554;continue;}
case 554:{f.Push(JValue.R(rt.String(" create ")));f.Pc=556;continue;}
case 556:{f.Pc=561;continue;}
case 559:{f.Push(JValue.R(rt.String(" creates ")));f.Pc=561;continue;}
case 561:{f.Push(f.Locals[8]);f.Pc=563;continue;}
case 563:{f.Push(f.Locals[9]);f.Pc=565;continue;}
case 565:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffect:3784:565:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",570);}
case 570:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3785(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("TokenTypes")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?44:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("TokenTypes")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?44:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","hasChosenType","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int!=0?44:43;continue;}
case 43:{return JStep.ReturnVoid;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("TokenColors")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?78:54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("TokenColors")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",61);}
case 61:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int==0?78:70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int!=0?78:77;continue;}
case 77:{return JStep.ReturnVoid;}
case 78:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/mutable/MutableBoolean"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/mutable/MutableBoolean")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(JValue.I(0));f.Pc=83;continue;}
case 83:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","<init>","(Z)V","invokespecial",86);}
case 86:{f.Locals[4]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(JValue.I(1));f.Pc=89;continue;}
case 89:{f.Locals[5]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","getChangeZoneTable","()Lforge/game/card/CardZoneTable;","invokevirtual",95);}
case 95:{f.Locals[6]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[6]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Reference!=null?114:102;continue;}
case 102:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",109);}
case 109:{f.Locals[6]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{f.Locals[5]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("ChangeZoneTable")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?133:124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[6]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/spellability/SpellAbility","setChangeZoneTable","(Lforge/game/card/CardZoneTable;)V","invokevirtual",130);}
case 130:{f.Push(JValue.I(1));f.Pc=131;continue;}
case 131:{f.Locals[5]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[2]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String("TokenAmount")));f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("1")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",142);}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",146);}
case 146:{f.Locals[7]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[7]);f.Pc=150;continue;}
case 150:{f.Push(JValue.I(1));f.Pc=151;continue;}
case 151:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?155:154;continue;}
case 154:{return JStep.ReturnVoid;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{f.Push(JValue.R(rt.String("TokenOwner")));f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/ability/effects/TokenEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",162);}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String("TokenScript")));f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",168);}
case 168:{f.Push(JValue.R(rt.String(",")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",173);}
case 173:{f.Push(f.Locals[7]);f.Pc=175;continue;}
case 175:{f.Push(JValue.I(0));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[6]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[4]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[1]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/ability/effects/TokenEffect","makeTokenTable","(Ljava/lang/Iterable;[Ljava/lang/String;IZLforge/game/card/CardZoneTable;Lorg/apache/commons/lang3/mutable/MutableBoolean;Lforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;","invokevirtual",184);}
case 184:{f.StackOp("pop");f.Pc=185;continue;}
case 185:{f.Push(f.Locals[5]);f.Pc=187;continue;}
case 187:{f.Pc=f.Pop().Int!=0?202:190;continue;}
case 190:{f.Push(f.Locals[6]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[3]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[1]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",197);}
case 197:{f.Push(f.Locals[6]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/card/CardZoneTable","clear","()V","invokevirtual",202);}
case 202:{f.Push(f.Locals[3]);f.Pc=203;continue;}
case 203:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventTokenCreated"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventTokenCreated")));f.Pc=206;continue;}
case 206:{f.StackOp("dup");f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/event/GameEventTokenCreated","<init>","()V","invokespecial",210);}
case 210:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",213);}
case 213:{f.Push(f.Locals[4]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","isTrue","()Z","invokevirtual",218);}
case 218:{f.Pc=f.Pop().Int==0?236:221;continue;}
case 221:{f.Push(f.Locals[3]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",225);}
case 225:{f.Push(f.Locals[3]);f.Pc=226;continue;}
case 226:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=229;continue;}
case 229:{f.StackOp("dup");f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",233);}
case 233:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",236);}
case 236:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C259{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CopyPermanentEffect","forge/game/ability/effects/TokenEffectBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3224,"forge/game/ability/effects/CopyPermanentEffect","<init>","()V",1,1,1,new JHandler[]{},M3224));
c.Add(new JMethod(3225,"forge/game/ability/effects/CopyPermanentEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,11,4,new JHandler[]{},M3225));
c.Add(new JMethod(3226,"forge/game/ability/effects/CopyPermanentEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,23,6,new JHandler[]{},M3226));
c.Add(new JMethod(3227,"forge/game/ability/effects/CopyPermanentEffect","getProtoType","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Lforge/game/card/Card;",9,6,4,new JHandler[]{},M3227));
c.Add(new JMethod(3228,"forge/game/ability/effects/CopyPermanentEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V",1,3,3,new JHandler[]{},M3228));
}

internal static JStep M3224(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3225(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Populate")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?12:9;continue;}
case 9:{f.Push(JValue.R(rt.String("Populate. (Create a token that's a copy of a creature token you control.)")));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("NumCopies")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?51:34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",38);}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("NumCopies")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",48);}
case 48:{f.Pc=52;continue;}
case 51:{f.Push(JValue.I(1));f.Pc=52;continue;}
case 52:{f.Locals[4]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",59);}
case 59:{f.Push(JValue.R(rt.String(" creates ")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("DefinedName")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int==0?98:74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("DefinedName")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",83);}
case 83:{return rt.DynamicCall(f,"forge/game/ability/effects/CopyPermanentEffect:3225:83:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",88);}
case 88:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",91);}
case 91:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",94);}
case 94:{f.StackOp("pop");f.Pc=95;continue;}
case 95:{f.Pc=481;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/ability/effects/CopyPermanentEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",102);}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",111);}
case 111:{f.Push(JValue.I(1));f.Pc=112;continue;}
case 112:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?119:115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{f.Pc=120;continue;}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{f.Locals[6]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String("AddKeywords")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",128);}
case 128:{f.Locals[7]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[4]);f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("token")));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",138);}
case 138:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",141);}
case 141:{f.StackOp("pop");f.Pc=142;continue;}
case 142:{f.Push(f.Locals[2]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[4]);f.Pc=145;continue;}
case 145:{f.Push(JValue.I(1));f.Pc=146;continue;}
case 146:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?154:149;continue;}
case 149:{f.Push(JValue.R(rt.String(" that's a copy")));f.Pc=151;continue;}
case 151:{f.Pc=156;continue;}
case 154:{f.Push(JValue.R(rt.String(" that are copies")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",159);}
case 159:{f.Push(JValue.R(rt.String(" of ")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",164);}
case 164:{f.StackOp("pop");f.Pc=165;continue;}
case 165:{f.Push(f.Locals[2]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[5]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",171);}
case 171:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",174);}
case 174:{f.StackOp("pop");f.Pc=175;continue;}
case 175:{f.Push(f.Locals[7]);f.Pc=177;continue;}
case 177:{f.Pc=f.Pop().Int==0?279:180;continue;}
case 180:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",183);}
case 183:{f.Locals[8]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[8]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String("AddKeywords")));f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",193);}
case 193:{f.Push(JValue.R(rt.String(" & ")));f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",198);}
case 198:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",201);}
case 201:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",206);}
case 206:{f.StackOp("pop");f.Pc=207;continue;}
case 207:{f.Push(f.Locals[1]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",211);}
case 211:{f.Push(JValue.R(rt.String("except")));f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",216);}
case 216:{f.Pc=f.Pop().Int==0?244:219;continue;}
case 219:{f.Push(f.Locals[2]);f.Pc=220;continue;}
case 220:{f.Push(JValue.R(rt.String(", except ")));f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",225);}
case 225:{f.Push(f.Locals[6]);f.Pc=227;continue;}
case 227:{f.Pc=f.Pop().Int==0?235:230;continue;}
case 230:{f.Push(JValue.R(rt.String("it has ")));f.Pc=232;continue;}
case 232:{f.Pc=237;continue;}
case 235:{f.Push(JValue.R(rt.String("they have ")));f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",240);}
case 240:{f.StackOp("pop");f.Pc=241;continue;}
case 241:{f.Pc=266;continue;}
case 244:{f.Push(f.Locals[2]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String(". ")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",250);}
case 250:{f.Push(f.Locals[6]);f.Pc=252;continue;}
case 252:{f.Pc=f.Pop().Int==0?260:255;continue;}
case 255:{f.Push(JValue.R(rt.String("It gains ")));f.Pc=257;continue;}
case 257:{f.Pc=262;continue;}
case 260:{f.Push(JValue.R(rt.String("They gain ")));f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",265);}
case 265:{f.StackOp("pop");f.Pc=266;continue;}
case 266:{f.Push(f.Locals[2]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[8]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",272);}
case 272:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",275);}
case 275:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",278);}
case 278:{f.StackOp("pop");f.Pc=279;continue;}
case 279:{f.Push(f.Locals[1]);f.Pc=280;continue;}
case 280:{f.Push(JValue.R(rt.String("AddTriggers")));f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",285);}
case 285:{f.Pc=f.Pop().Int==0?382:288;continue;}
case 288:{f.Push(f.Locals[1]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",292);}
case 292:{f.Locals[8]=f.Pop();f.Pc=294;continue;}
case 294:{f.Push(f.Locals[8]);f.Pc=296;continue;}
case 296:{f.Push(JValue.R(rt.String("\"")));f.Pc=298;continue;}
case 298:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",301);}
case 301:{f.Pc=f.Pop().Int==0?328:304;continue;}
case 304:{f.Push(f.Locals[8]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[8]);f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("\"")));f.Pc=310;continue;}
case 310:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",313);}
case 313:{f.Push(f.Locals[8]);f.Pc=315;continue;}
case 315:{f.Push(JValue.R(rt.String("\"")));f.Pc=317;continue;}
case 317:{return rt.Call(f,"java/lang/String","lastIndexOf","(Ljava/lang/String;)I","invokevirtual",320);}
case 320:{f.Push(JValue.I(1));f.Pc=321;continue;}
case 321:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=322;continue;}
case 322:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",325);}
case 325:{f.Pc=330;continue;}
case 328:{f.Push(JValue.R(rt.String("[trigger text parsing error]")));f.Pc=330;continue;}
case 330:{f.Locals[9]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[7]);f.Pc=334;continue;}
case 334:{f.Pc=f.Pop().Int==0?352:337;continue;}
case 337:{f.Push(f.Locals[2]);f.Pc=338;continue;}
case 338:{f.Push(JValue.R(rt.String(" and ")));f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",343);}
case 343:{f.Push(f.Locals[9]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",348);}
case 348:{f.StackOp("pop");f.Pc=349;continue;}
case 349:{f.Pc=379;continue;}
case 352:{f.Push(f.Locals[2]);f.Pc=353;continue;}
case 353:{f.Push(JValue.R(rt.String(". ")));f.Pc=355;continue;}
case 355:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",358);}
case 358:{f.Push(f.Locals[6]);f.Pc=360;continue;}
case 360:{f.Pc=f.Pop().Int==0?368:363;continue;}
case 363:{f.Push(JValue.R(rt.String("It gains ")));f.Pc=365;continue;}
case 365:{f.Pc=370;continue;}
case 368:{f.Push(JValue.R(rt.String("They gain ")));f.Pc=370;continue;}
case 370:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",373);}
case 373:{f.Push(f.Locals[9]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",378);}
case 378:{f.StackOp("pop");f.Pc=379;continue;}
case 379:{f.Pc=389;continue;}
case 382:{f.Push(f.Locals[2]);f.Pc=383;continue;}
case 383:{f.Push(JValue.R(rt.String(".")));f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",388);}
case 388:{f.StackOp("pop");f.Pc=389;continue;}
case 389:{f.Push(f.Locals[1]);f.Pc=390;continue;}
case 390:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",395);}
case 395:{f.Pc=f.Pop().Int==0?481:398;continue;}
case 398:{f.Push(f.Locals[1]);f.Pc=399;continue;}
case 399:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",404);}
case 404:{f.Locals[8]=f.Pop();f.Pc=406;continue;}
case 406:{f.Push(JValue.R(rt.String("Sacrifice ")));f.Pc=408;continue;}
case 408:{f.Locals[9]=f.Pop();f.Pc=410;continue;}
case 410:{f.Push(f.Locals[8]);f.Pc=412;continue;}
case 412:{f.Push(JValue.R(rt.String("Exile")));f.Pc=414;continue;}
case 414:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",417);}
case 417:{f.Pc=f.Pop().Int==0?424:420;continue;}
case 420:{f.Push(JValue.R(rt.String("Exile ")));f.Pc=422;continue;}
case 422:{f.Locals[9]=f.Pop();f.Pc=424;continue;}
case 424:{f.Push(f.Locals[2]);f.Pc=425;continue;}
case 425:{f.Push(JValue.R(rt.String(" ")));f.Pc=427;continue;}
case 427:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",430);}
case 430:{f.Push(f.Locals[9]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",435);}
case 435:{f.Push(f.Locals[6]);f.Pc=437;continue;}
case 437:{f.Pc=f.Pop().Int==0?445:440;continue;}
case 440:{f.Push(JValue.R(rt.String("it ")));f.Pc=442;continue;}
case 442:{f.Pc=447;continue;}
case 445:{f.Push(JValue.R(rt.String("them ")));f.Pc=447;continue;}
case 447:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",450);}
case 450:{f.Push(JValue.R(rt.String("at ")));f.Pc=452;continue;}
case 452:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",455);}
case 455:{f.StackOp("pop");f.Pc=456;continue;}
case 456:{f.Push(JValue.R(rt.String("the beginning of the next end step.")));f.Pc=458;continue;}
case 458:{f.Locals[10]=f.Pop();f.Pc=460;continue;}
case 460:{f.Push(f.Locals[8]);f.Pc=462;continue;}
case 462:{f.Push(JValue.R(rt.String("Combat")));f.Pc=464;continue;}
case 464:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",467);}
case 467:{f.Pc=f.Pop().Int==0?474:470;continue;}
case 470:{f.Push(JValue.R(rt.String("end of combat.")));f.Pc=472;continue;}
case 472:{f.Locals[10]=f.Pop();f.Pc=474;continue;}
case 474:{f.Push(f.Locals[2]);f.Pc=475;continue;}
case 475:{f.Push(f.Locals[10]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",480);}
case 480:{f.StackOp("pop");f.Pc=481;continue;}
case 481:{f.Push(f.Locals[2]);f.Pc=482;continue;}
case 482:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",485);}
case 485:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3226(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Locals[5]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("ChosenMap")));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Defined")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",30);}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getChangeZoneTable","()Lforge/game/card/CardZoneTable;","invokevirtual",36);}
case 36:{f.Locals[7]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[7]);f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Reference!=null?55:43;continue;}
case 43:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",50);}
case 50:{f.Locals[7]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{f.Locals[5]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("ChangeZoneTable")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?73:64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[7]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","setChangeZoneTable","(Lforge/game/card/CardZoneTable;)V","invokevirtual",70);}
case 70:{f.Push(JValue.I(1));f.Pc=71;continue;}
case 71:{f.Locals[5]=f.Pop();f.Pc=73;continue;}
case 73:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/mutable/MutableBoolean"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/mutable/MutableBoolean")));f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","<init>","(Z)V","invokespecial",81);}
case 81:{f.Locals[8]=f.Pop();f.Pc=83;continue;}
case 83:{if(!rt.EnsureInitialized(f,"forge/game/card/TokenCreateTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/TokenCreateTable")));f.Pc=86;continue;}
case 86:{f.StackOp("dup");f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/TokenCreateTable","<init>","()V","invokespecial",90);}
case 90:{f.Locals[9]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("Optional")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?127:101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",105);}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(null));f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",110);}
case 110:{f.Push(JValue.R(rt.String("lblCopyPermanentConfirm")));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(0));f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",119);}
case 119:{f.Push(JValue.R(null));f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int!=0?127:126;continue;}
case 126:{return JStep.ReturnVoid;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("NumCopies")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",133);}
case 133:{f.Pc=f.Pop().Int==0?150:136;continue;}
case 136:{f.Push(f.Locals[2]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("NumCopies")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",143);}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",147);}
case 147:{f.Pc=151;continue;}
case 150:{f.Push(JValue.I(1));f.Pc=151;continue;}
case 151:{f.Locals[10]=f.Pop();f.Pc=153;continue;}
case 153:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",156);}
case 156:{f.Locals[11]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[1]);f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("Controller")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int==0?183:167;continue;}
case 167:{f.Push(f.Locals[2]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[1]);f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String("Controller")));f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",174);}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",178);}
case 178:{f.Locals[11]=f.Pop();f.Pc=180;continue;}
case 180:{f.Pc=205;continue;}
case 183:{f.Push(f.Locals[6]);f.Pc=185;continue;}
case 185:{f.Pc=f.Pop().Int==0?205:188;continue;}
case 188:{f.Push(f.Locals[11]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[2]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/card/Card","getChosenMap","()Ljava/util/Map;","invokevirtual",194);}
case 194:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",199);}
case 199:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",204);}
case 204:{f.StackOp("pop");f.Pc=205;continue;}
case 205:{f.Push(f.Locals[11]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",212);}
case 212:{f.Pc=f.Pop().Int==0?224:215;continue;}
case 215:{f.Push(f.Locals[11]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[3]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",223);}
case 223:{f.StackOp("pop");f.Pc=224;continue;}
case 224:{f.Push(f.Locals[11]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",231);}
case 231:{f.Locals[12]=f.Pop();f.Pc=233;continue;}
case 233:{f.Push(f.Locals[12]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",240);}
case 240:{f.Pc=f.Pop().Int==0?1250:243;continue;}
case 243:{f.Push(f.Locals[12]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",250);}
case 250:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=253;continue;}
case 253:{f.Locals[13]=f.Pop();f.Pc=255;continue;}
case 255:{f.Push(f.Locals[13]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",260);}
case 260:{f.Pc=f.Pop().Int!=0?266:263;continue;}
case 263:{f.Pc=233;continue;}
case 266:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",269);}
case 269:{f.Locals[14]=f.Pop();f.Pc=271;continue;}
case 271:{f.Push(f.Locals[1]);f.Pc=272;continue;}
case 272:{f.Push(JValue.R(rt.String("ValidSupportedCopy")));f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",278);}
case 278:{f.Pc=f.Pop().Int==0?564:281;continue;}
case 281:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",284);}
case 284:{return rt.Call(f,"forge/StaticData","ensureAllCardsLoaded","()V","invokevirtual",287);}
case 287:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",290);}
case 290:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",293);}
case 293:{return rt.Call(f,"forge/card/CardDb","getUniqueCards","()Ljava/util/Collection;","invokevirtual",296);}
case 296:{f.Locals[15]=f.Pop();f.Pc=298;continue;}
case 298:{f.Push(f.Locals[1]);f.Pc=299;continue;}
case 299:{f.Push(JValue.R(rt.String("ValidSupportedCopy")));f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",305);}
case 305:{f.Locals[16]=f.Pop();f.Pc=307;continue;}
case 307:{f.Push(f.Locals[16]);f.Pc=309;continue;}
case 309:{f.Push(JValue.R(rt.String("X")));f.Pc=312;continue;}
case 312:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",315);}
case 315:{f.Pc=f.Pop().Int==0?339:318;continue;}
case 318:{f.Push(f.Locals[16]);f.Pc=320;continue;}
case 320:{f.Push(JValue.R(rt.String("X")));f.Pc=323;continue;}
case 323:{f.Push(f.Locals[2]);f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.String("X")));f.Pc=327;continue;}
case 327:{f.Push(f.Locals[1]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",331);}
case 331:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",334);}
case 334:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",337);}
case 337:{f.Locals[16]=f.Pop();f.Pc=339;continue;}
case 339:{f.Push(f.Locals[16]);f.Pc=341;continue;}
case 341:{f.Push(JValue.R(rt.String("creature")));f.Pc=344;continue;}
case 344:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","containsIgnoreCase","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z","invokestatic",347);}
case 347:{f.Pc=f.Pop().Int==0?360:350;continue;}
case 350:{f.Push(f.Locals[15]);f.Pc=352;continue;}
case 352:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_CREATURE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_CREATURE","Ljava/util/function/Predicate;"));f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",358);}
case 358:{f.Locals[15]=f.Pop();f.Pc=360;continue;}
case 360:{f.Push(f.Locals[16]);f.Pc=362;continue;}
case 362:{f.Push(JValue.R(rt.String("equipment")));f.Pc=365;continue;}
case 365:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","containsIgnoreCase","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z","invokestatic",368);}
case 368:{f.Pc=f.Pop().Int==0?388:371;continue;}
case 371:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_EQUIPMENT","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_EQUIPMENT","Ljava/util/function/Predicate;"));f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",377);}
case 377:{f.Locals[17]=f.Pop();f.Pc=379;continue;}
case 379:{f.Push(f.Locals[15]);f.Pc=381;continue;}
case 381:{f.Push(f.Locals[17]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",386);}
case 386:{f.Locals[15]=f.Pop();f.Pc=388;continue;}
case 388:{f.Push(f.Locals[1]);f.Pc=389;continue;}
case 389:{f.Push(JValue.R(rt.String("RandomCopied")));f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",395);}
case 395:{f.Pc=f.Pop().Int==0?561:398;continue;}
case 398:{f.Push(f.Locals[15]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",403);}
case 403:{f.Locals[17]=f.Pop();f.Pc=405;continue;}
case 405:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",408);}
case 408:{f.Locals[18]=f.Pop();f.Pc=410;continue;}
case 410:{f.Push(f.Locals[1]);f.Pc=411;continue;}
case 411:{f.Push(JValue.R(rt.String("RandomNum")));f.Pc=414;continue;}
case 414:{f.Push(JValue.R(rt.String("1")));f.Pc=417;continue;}
case 417:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",420);}
case 420:{f.Locals[19]=f.Pop();f.Pc=422;continue;}
case 422:{f.Push(f.Locals[2]);f.Pc=423;continue;}
case 423:{f.Push(f.Locals[19]);f.Pc=425;continue;}
case 425:{f.Push(f.Locals[1]);f.Pc=426;continue;}
case 426:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",429);}
case 429:{f.Locals[20]=f.Pop();f.Pc=431;continue;}
case 431:{f.Push(f.Locals[20]);f.Pc=433;continue;}
case 433:{f.Pc=f.Pop().Int<=0?541:436;continue;}
case 436:{f.Push(f.Locals[17]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",443);}
case 443:{f.Pc=f.Pop().Int!=0?541:446;continue;}
case 446:{f.Push(f.Locals[17]);f.Pc=448;continue;}
case 448:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",451);}
case 451:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=454;continue;}
case 454:{f.Locals[21]=f.Pop();f.Pc=456;continue;}
case 456:{f.Push(f.Locals[21]);f.Pc=458;continue;}
case 458:{f.Push(f.Locals[3]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",462);}
case 462:{f.Locals[22]=f.Pop();f.Pc=464;continue;}
case 464:{f.Push(f.Locals[22]);f.Pc=466;continue;}
case 466:{f.Push(f.Locals[16]);f.Pc=468;continue;}
case 468:{f.Push(f.Locals[2]);f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",472);}
case 472:{f.Push(f.Locals[2]);f.Pc=473;continue;}
case 473:{f.Push(f.Locals[1]);f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",477);}
case 477:{f.Pc=f.Pop().Int==0?528:480;continue;}
case 480:{f.Push(f.Locals[2]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",484);}
case 484:{return rt.Call(f,"forge/game/player/Player","isAI","()Z","invokevirtual",487);}
case 487:{f.Pc=f.Pop().Int==0?515:490;continue;}
case 490:{f.Push(f.Locals[22]);f.Pc=492;continue;}
case 492:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",495);}
case 495:{f.Pc=f.Pop().Reference==null?515:498;continue;}
case 498:{f.Push(f.Locals[22]);f.Pc=500;continue;}
case 500:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",503);}
case 503:{return rt.Call(f,"forge/card/CardRules","getAiHints","()Lforge/card/CardAiHints;","invokevirtual",506);}
case 506:{return rt.Call(f,"forge/card/CardAiHints","getRemAIDecks","()Z","invokevirtual",509);}
case 509:{f.Pc=f.Pop().Int==0?515:512;continue;}
case 512:{f.Pc=431;continue;}
case 515:{f.Push(f.Locals[18]);f.Pc=517;continue;}
case 517:{f.Push(f.Locals[22]);f.Pc=519;continue;}
case 519:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",524);}
case 524:{f.StackOp("pop");f.Pc=525;continue;}
case 525:{f.Locals[20]=JValue.I(unchecked(f.Locals[20].Int+(-1)));f.Pc=528;continue;}
case 528:{f.Push(f.Locals[17]);f.Pc=530;continue;}
case 530:{f.Push(f.Locals[21]);f.Pc=532;continue;}
case 532:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",537);}
case 537:{f.StackOp("pop");f.Pc=538;continue;}
case 538:{f.Pc=431;continue;}
case 541:{f.Push(f.Locals[18]);f.Pc=543;continue;}
case 543:{f.Locals[14]=f.Pop();f.Pc=545;continue;}
case 545:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=548;continue;}
case 548:{f.Push(f.Locals[14]);f.Pc=550;continue;}
case 550:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",553);}
case 553:{return rt.DynamicCall(f,"forge/game/ability/effects/CopyPermanentEffect:3226:553:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",558);}
case 558:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",561);}
case 561:{f.Pc=1038;continue;}
case 564:{f.Push(f.Locals[1]);f.Pc=565;continue;}
case 565:{f.Push(JValue.R(rt.String("DefinedName")));f.Pc=567;continue;}
case 567:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",570);}
case 570:{f.Pc=f.Pop().Int==0?644:573;continue;}
case 573:{f.Push(f.Locals[1]);f.Pc=574;continue;}
case 574:{f.Push(JValue.R(rt.String("DefinedName")));f.Pc=576;continue;}
case 576:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",579);}
case 579:{f.Locals[15]=f.Pop();f.Pc=581;continue;}
case 581:{f.Push(f.Locals[15]);f.Pc=583;continue;}
case 583:{f.Push(JValue.R(rt.String("NamedCard")));f.Pc=586;continue;}
case 586:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",589);}
case 589:{f.Pc=f.Pop().Int==0?608:592;continue;}
case 592:{f.Push(f.Locals[2]);f.Pc=593;continue;}
case 593:{return rt.Call(f,"forge/game/card/Card","getNamedCard","()Ljava/lang/String;","invokevirtual",596);}
case 596:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",599);}
case 599:{f.Pc=f.Pop().Int!=0?608:602;continue;}
case 602:{f.Push(f.Locals[2]);f.Pc=603;continue;}
case 603:{return rt.Call(f,"forge/game/card/Card","getNamedCard","()Ljava/lang/String;","invokevirtual",606);}
case 606:{f.Locals[15]=f.Pop();f.Pc=608;continue;}
case 608:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",611);}
case 611:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",614);}
case 614:{f.Push(f.Locals[15]);f.Pc=616;continue;}
case 616:{return rt.Call(f,"forge/card/CardDb","getUniqueByName","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",619);}
case 619:{f.Locals[16]=f.Pop();f.Pc=621;continue;}
case 621:{f.Push(f.Locals[16]);f.Pc=623;continue;}
case 623:{f.Pc=f.Pop().Reference==null?641:626;continue;}
case 626:{f.Push(f.Locals[14]);f.Pc=628;continue;}
case 628:{f.Push(f.Locals[16]);f.Pc=630;continue;}
case 630:{f.Push(f.Locals[13]);f.Pc=632;continue;}
case 632:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",635);}
case 635:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",640);}
case 640:{f.StackOp("pop");f.Pc=641;continue;}
case 641:{f.Pc=1038;continue;}
case 644:{f.Push(f.Locals[1]);f.Pc=645;continue;}
case 645:{f.Push(JValue.R(rt.String("Choices")));f.Pc=648;continue;}
case 648:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",651);}
case 651:{f.Pc=f.Pop().Int==0?928:654;continue;}
case 654:{f.Push(f.Locals[3]);f.Pc=655;continue;}
case 655:{f.Locals[15]=f.Pop();f.Pc=657;continue;}
case 657:{f.Push(f.Locals[1]);f.Pc=658;continue;}
case 658:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=661;continue;}
case 661:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",664);}
case 664:{f.Pc=f.Pop().Int==0?692:667;continue;}
case 667:{f.Push(f.Locals[1]);f.Pc=668;continue;}
case 668:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",674);}
case 674:{f.Locals[16]=f.Pop();f.Pc=676;continue;}
case 676:{f.Push(f.Locals[2]);f.Pc=677;continue;}
case 677:{f.Push(f.Locals[16]);f.Pc=679;continue;}
case 679:{f.Push(f.Locals[1]);f.Pc=680;continue;}
case 680:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",683);}
case 683:{f.Push(JValue.I(0));f.Pc=684;continue;}
case 684:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",687);}
case 687:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=690;continue;}
case 690:{f.Locals[15]=f.Pop();f.Pc=692;continue;}
case 692:{f.Push(f.Locals[1]);f.Pc=693;continue;}
case 693:{f.Push(JValue.R(rt.String("Defined")));f.Pc=695;continue;}
case 695:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",698);}
case 698:{f.Pc=f.Pop().Int==0?708:701;continue;}
case 701:{f.Push(f.Locals[1]);f.Pc=702;continue;}
case 702:{return rt.Call(f,"forge/game/ability/effects/CopyPermanentEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",705);}
case 705:{f.Pc=716;continue;}
case 708:{f.Push(f.Locals[4]);f.Pc=710;continue;}
case 710:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=713;continue;}
case 713:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",716);}
case 716:{f.Locals[16]=f.Pop();f.Pc=718;continue;}
case 718:{f.Push(f.Locals[16]);f.Pc=720;continue;}
case 720:{f.Push(f.Locals[1]);f.Pc=721;continue;}
case 721:{f.Push(JValue.R(rt.String("Choices")));f.Pc=724;continue;}
case 724:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",727);}
case 727:{f.Push(f.Locals[3]);f.Pc=728;continue;}
case 728:{f.Push(f.Locals[2]);f.Pc=729;continue;}
case 729:{f.Push(f.Locals[1]);f.Pc=730;continue;}
case 730:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",733);}
case 733:{f.Locals[16]=f.Pop();f.Pc=735;continue;}
case 735:{f.Push(f.Locals[16]);f.Pc=737;continue;}
case 737:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",742);}
case 742:{f.Pc=f.Pop().Int!=0?925:745;continue;}
case 745:{f.Push(f.Locals[1]);f.Pc=746;continue;}
case 746:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=749;continue;}
case 749:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",752);}
case 752:{f.Pc=f.Pop().Int==0?765:755;continue;}
case 755:{f.Push(f.Locals[1]);f.Pc=756;continue;}
case 756:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=759;continue;}
case 759:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",762);}
case 762:{f.Pc=778;continue;}
case 765:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",768);}
case 768:{f.Push(JValue.R(rt.String("lblChooseaCard")));f.Pc=771;continue;}
case 771:{f.Push(JValue.I(0));f.Pc=772;continue;}
case 772:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=775;continue;}
case 775:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",778);}
case 778:{f.Locals[17]=f.Pop();f.Pc=780;continue;}
case 780:{f.Push(f.Locals[1]);f.Pc=781;continue;}
case 781:{f.Push(JValue.R(rt.String("WithDifferentNames")));f.Pc=784;continue;}
case 784:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",787);}
case 787:{f.Pc=f.Pop().Int==0?890:790;continue;}
case 790:{f.Push(f.Locals[16]);f.Pc=792;continue;}
case 792:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",797);}
case 797:{f.Pc=f.Pop().Int!=0?925:800;continue;}
case 800:{f.Push(f.Locals[15]);f.Pc=802;continue;}
case 802:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",805);}
case 805:{f.Push(f.Locals[16]);f.Pc=807;continue;}
case 807:{f.Push(f.Locals[1]);f.Pc=808;continue;}
case 808:{f.Push(f.Locals[17]);f.Pc=810;continue;}
case 810:{f.Push(JValue.I(1));f.Pc=811;continue;}
case 811:{f.Push(JValue.R(null));f.Pc=812;continue;}
case 812:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",815);}
case 815:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=818;continue;}
case 818:{f.Locals[18]=f.Pop();f.Pc=820;continue;}
case 820:{f.Push(f.Locals[18]);f.Pc=822;continue;}
case 822:{f.Pc=f.Pop().Reference==null?855:825;continue;}
case 825:{f.Push(f.Locals[14]);f.Pc=827;continue;}
case 827:{f.Push(f.Locals[18]);f.Pc=829;continue;}
case 829:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",834);}
case 834:{f.StackOp("pop");f.Pc=835;continue;}
case 835:{f.Push(f.Locals[16]);f.Pc=837;continue;}
case 837:{f.Push(f.Locals[18]);f.Pc=839;continue;}
case 839:{return rt.Call(f,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",842);}
case 842:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",847);}
case 847:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",850);}
case 850:{f.Locals[16]=f.Pop();f.Pc=852;continue;}
case 852:{f.Pc=887;continue;}
case 855:{f.Push(f.Locals[15]);f.Pc=857;continue;}
case 857:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",860);}
case 860:{f.Push(f.Locals[1]);f.Pc=861;continue;}
case 861:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","OptionalChoose","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","OptionalChoose","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=864;continue;}
case 864:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",867);}
case 867:{f.Push(JValue.R(rt.String("lblCancelChooseConfirm")));f.Pc=870;continue;}
case 870:{f.Push(JValue.I(0));f.Pc=871;continue;}
case 871:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=874;continue;}
case 874:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",877);}
case 877:{f.Push(JValue.R(null));f.Pc=878;continue;}
case 878:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",881);}
case 881:{f.Pc=f.Pop().Int==0?887:884;continue;}
case 884:{f.Pc=925;continue;}
case 887:{f.Pc=790;continue;}
case 890:{f.Push(f.Locals[15]);f.Pc=892;continue;}
case 892:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",895);}
case 895:{f.Push(f.Locals[16]);f.Pc=897;continue;}
case 897:{f.Push(f.Locals[1]);f.Pc=898;continue;}
case 898:{f.Push(f.Locals[17]);f.Pc=900;continue;}
case 900:{f.Push(JValue.I(0));f.Pc=901;continue;}
case 901:{f.Push(JValue.R(null));f.Pc=902;continue;}
case 902:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",905);}
case 905:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=908;continue;}
case 908:{f.Locals[18]=f.Pop();f.Pc=910;continue;}
case 910:{f.Push(f.Locals[18]);f.Pc=912;continue;}
case 912:{f.Pc=f.Pop().Reference==null?925:915;continue;}
case 915:{f.Push(f.Locals[14]);f.Pc=917;continue;}
case 917:{f.Push(f.Locals[18]);f.Pc=919;continue;}
case 919:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",924);}
case 924:{f.StackOp("pop");f.Pc=925;continue;}
case 925:{f.Pc=1038;continue;}
case 928:{f.Push(f.Locals[6]);f.Pc=930;continue;}
case 930:{f.Pc=f.Pop().Int==0?1032:933;continue;}
case 933:{f.Push(f.Locals[1]);f.Pc=934;continue;}
case 934:{f.Push(JValue.R(rt.String("ChosenMapIndex")));f.Pc=937;continue;}
case 937:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",940);}
case 940:{f.Pc=f.Pop().Int==0?1013:943;continue;}
case 943:{f.Push(f.Locals[1]);f.Pc=944;continue;}
case 944:{f.Push(JValue.R(rt.String("ChosenMapIndex")));f.Pc=947;continue;}
case 947:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",950);}
case 950:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",953);}
case 953:{f.Locals[15]=f.Pop();f.Pc=955;continue;}
case 955:{f.Push(f.Locals[15]);f.Pc=957;continue;}
case 957:{f.Push(f.Locals[2]);f.Pc=958;continue;}
case 958:{return rt.Call(f,"forge/game/card/Card","getChosenMap","()Ljava/util/Map;","invokevirtual",961);}
case 961:{f.Push(f.Locals[13]);f.Pc=963;continue;}
case 963:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",968);}
case 968:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=971;continue;}
case 971:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",974);}
case 974:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?980:977;continue;}
case 977:{f.Pc=233;continue;}
case 980:{f.Push(f.Locals[14]);f.Pc=982;continue;}
case 982:{f.Push(f.Locals[2]);f.Pc=983;continue;}
case 983:{return rt.Call(f,"forge/game/card/Card","getChosenMap","()Ljava/util/Map;","invokevirtual",986);}
case 986:{f.Push(f.Locals[13]);f.Pc=988;continue;}
case 988:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",993);}
case 993:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=996;continue;}
case 996:{f.Push(f.Locals[15]);f.Pc=998;continue;}
case 998:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",1001);}
case 1001:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1004;continue;}
case 1004:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1009);}
case 1009:{f.StackOp("pop");f.Pc=1010;continue;}
case 1010:{f.Pc=1038;continue;}
case 1013:{f.Push(f.Locals[2]);f.Pc=1014;continue;}
case 1014:{return rt.Call(f,"forge/game/card/Card","getChosenMap","()Ljava/util/Map;","invokevirtual",1017);}
case 1017:{f.Push(f.Locals[13]);f.Pc=1019;continue;}
case 1019:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1024);}
case 1024:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1027;continue;}
case 1027:{f.Locals[14]=f.Pop();f.Pc=1029;continue;}
case 1029:{f.Pc=1038;continue;}
case 1032:{f.Push(f.Locals[1]);f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"forge/game/ability/effects/CopyPermanentEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",1036);}
case 1036:{f.Locals[14]=f.Pop();f.Pc=1038;continue;}
case 1038:{f.Push(f.Locals[14]);f.Pc=1040;continue;}
case 1040:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1045);}
case 1045:{f.Locals[15]=f.Pop();f.Pc=1047;continue;}
case 1047:{f.Push(f.Locals[15]);f.Pc=1049;continue;}
case 1049:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1054);}
case 1054:{f.Pc=f.Pop().Int==0?1247:1057;continue;}
case 1057:{f.Push(f.Locals[15]);f.Pc=1059;continue;}
case 1059:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1064);}
case 1064:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1067;continue;}
case 1067:{f.Locals[16]=f.Pop();f.Pc=1069;continue;}
case 1069:{f.Push(f.Locals[16]);f.Pc=1071;continue;}
case 1071:{return rt.Call(f,"forge/game/card/Card","isInstant","()Z","invokevirtual",1074);}
case 1074:{f.Pc=f.Pop().Int!=0?1047:1077;continue;}
case 1077:{f.Push(f.Locals[16]);f.Pc=1079;continue;}
case 1079:{return rt.Call(f,"forge/game/card/Card","isSorcery","()Z","invokevirtual",1082);}
case 1082:{f.Pc=f.Pop().Int==0?1088:1085;continue;}
case 1085:{f.Pc=1047;continue;}
case 1088:{f.Push(f.Locals[1]);f.Pc=1089;continue;}
case 1089:{f.Push(JValue.R(rt.String("ForEach")));f.Pc=1092;continue;}
case 1092:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1095);}
case 1095:{f.Pc=f.Pop().Int==0?1223:1098;continue;}
case 1098:{f.Push(f.Locals[2]);f.Pc=1099;continue;}
case 1099:{f.Push(f.Locals[1]);f.Pc=1100;continue;}
case 1100:{f.Push(JValue.R(rt.String("ForEach")));f.Pc=1103;continue;}
case 1103:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1106);}
case 1106:{f.Push(f.Locals[1]);f.Pc=1107;continue;}
case 1107:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1110);}
case 1110:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1113);}
case 1113:{f.Locals[17]=f.Pop();f.Pc=1115;continue;}
case 1115:{f.Push(f.Locals[17]);f.Pc=1117;continue;}
case 1117:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1122);}
case 1122:{f.Pc=f.Pop().Int==0?1220:1125;continue;}
case 1125:{f.Push(f.Locals[17]);f.Pc=1127;continue;}
case 1127:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1132);}
case 1132:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1135;continue;}
case 1135:{f.Locals[18]=f.Pop();f.Pc=1137;continue;}
case 1137:{f.Push(f.Locals[1]);f.Pc=1138;continue;}
case 1138:{f.Push(JValue.R(rt.String("OptionalForEach")));f.Pc=1141;continue;}
case 1141:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1144);}
case 1144:{f.Pc=f.Pop().Int==0?1185:1147;continue;}
case 1147:{f.Push(f.Locals[3]);f.Pc=1148;continue;}
case 1148:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1151);}
case 1151:{f.Push(f.Locals[1]);f.Pc=1152;continue;}
case 1152:{f.Push(JValue.R(null));f.Pc=1153;continue;}
case 1153:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1156);}
case 1156:{f.Push(JValue.R(rt.String("lblCopyPermanentConfirm")));f.Pc=1158;continue;}
case 1158:{f.Push(JValue.I(0));f.Pc=1159;continue;}
case 1159:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1162;continue;}
case 1162:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1165);}
case 1165:{f.Push(f.Locals[18]);f.Pc=1167;continue;}
case 1167:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1170);}
case 1170:{return rt.DynamicCall(f,"forge/game/ability/effects/CopyPermanentEffect:3226:1170:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1175);}
case 1175:{f.Push(JValue.R(null));f.Pc=1176;continue;}
case 1176:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",1179);}
case 1179:{f.Pc=f.Pop().Int!=0?1185:1182;continue;}
case 1182:{f.Pc=1115;continue;}
case 1185:{f.Push(f.Locals[1]);f.Pc=1186;continue;}
case 1186:{f.Push(f.Locals[16]);f.Pc=1188;continue;}
case 1188:{f.Push(f.Locals[13]);f.Pc=1190;continue;}
case 1190:{return rt.Call(f,"forge/game/ability/effects/CopyPermanentEffect","getProtoType","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",1193);}
case 1193:{f.Locals[19]=f.Pop();f.Pc=1195;continue;}
case 1195:{f.Push(f.Locals[19]);f.Pc=1197;continue;}
case 1197:{f.Push(f.Locals[18]);f.Pc=1199;continue;}
case 1199:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1202);}
case 1202:{f.Push(f.Locals[9]);f.Pc=1204;continue;}
case 1204:{f.Push(f.Locals[13]);f.Pc=1206;continue;}
case 1206:{f.Push(f.Locals[19]);f.Pc=1208;continue;}
case 1208:{f.Push(f.Locals[10]);f.Pc=1210;continue;}
case 1210:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1213);}
case 1213:{return rt.Call(f,"forge/game/card/TokenCreateTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",1216);}
case 1216:{f.StackOp("pop");f.Pc=1217;continue;}
case 1217:{f.Pc=1115;continue;}
case 1220:{f.Pc=1244;continue;}
case 1223:{f.Push(f.Locals[9]);f.Pc=1225;continue;}
case 1225:{f.Push(f.Locals[13]);f.Pc=1227;continue;}
case 1227:{f.Push(f.Locals[1]);f.Pc=1228;continue;}
case 1228:{f.Push(f.Locals[16]);f.Pc=1230;continue;}
case 1230:{f.Push(f.Locals[13]);f.Pc=1232;continue;}
case 1232:{return rt.Call(f,"forge/game/ability/effects/CopyPermanentEffect","getProtoType","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",1235);}
case 1235:{f.Push(f.Locals[10]);f.Pc=1237;continue;}
case 1237:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1240);}
case 1240:{return rt.Call(f,"forge/game/card/TokenCreateTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",1243);}
case 1243:{f.StackOp("pop");f.Pc=1244;continue;}
case 1244:{f.Pc=1047;continue;}
case 1247:{f.Pc=233;continue;}
case 1250:{f.Push(f.Locals[0]);f.Pc=1251;continue;}
case 1251:{f.Push(f.Locals[9]);f.Pc=1253;continue;}
case 1253:{f.Push(JValue.I(1));f.Pc=1254;continue;}
case 1254:{f.Push(f.Locals[7]);f.Pc=1256;continue;}
case 1256:{f.Push(f.Locals[8]);f.Pc=1258;continue;}
case 1258:{f.Push(f.Locals[1]);f.Pc=1259;continue;}
case 1259:{return rt.Call(f,"forge/game/ability/effects/CopyPermanentEffect","makeTokenTable","(Lforge/game/card/TokenCreateTable;ZLforge/game/card/CardZoneTable;Lorg/apache/commons/lang3/mutable/MutableBoolean;Lforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;","invokevirtual",1262);}
case 1262:{f.StackOp("pop");f.Pc=1263;continue;}
case 1263:{f.Push(f.Locals[5]);f.Pc=1265;continue;}
case 1265:{f.Pc=f.Pop().Int!=0?1276:1268;continue;}
case 1268:{f.Push(f.Locals[7]);f.Pc=1270;continue;}
case 1270:{f.Push(f.Locals[4]);f.Pc=1272;continue;}
case 1272:{f.Push(f.Locals[1]);f.Pc=1273;continue;}
case 1273:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1276);}
case 1276:{f.Push(f.Locals[8]);f.Pc=1278;continue;}
case 1278:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","isTrue","()Z","invokevirtual",1281);}
case 1281:{f.Pc=f.Pop().Int==0?1301:1284;continue;}
case 1284:{f.Push(f.Locals[4]);f.Pc=1286;continue;}
case 1286:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",1289);}
case 1289:{f.Push(f.Locals[4]);f.Pc=1291;continue;}
case 1291:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=1294;continue;}
case 1294:{f.StackOp("dup");f.Pc=1295;continue;}
case 1295:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",1298);}
case 1298:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1301);}
case 1301:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3227(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("DefinedName")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?85:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Push(JValue.R(rt.String(",")));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",24);}
case 24:{f.Push(JValue.R(rt.String(" ")));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("_")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",32);}
case 32:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",35);}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",50);}
case 50:{if(!rt.StaticReady(f,"forge/card/CardRarity","Token","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Token","Lforge/card/CardRarity;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/CardState","setRarity","(Lforge/card/CardRarity;)V","invokevirtual",56);}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",60);}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/CardState","setSetCode","(Ljava/lang/String;)V","invokevirtual",65);}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",69);}
case 69:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",72);}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/StaticData","getOtherImageKey","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",79);}
case 79:{return rt.Call(f,"forge/game/card/CardState","setImageKey","(Ljava/lang/String;)V","invokevirtual",82);}
case 82:{f.Pc=216;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",89);}
case 89:{f.Locals[4]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Pc=f.Pop().Reference!=null?99:95;continue;}
case 95:{f.Push(JValue.I(0));f.Pc=96;continue;}
case 96:{f.Pc=106;continue;}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",103);}
case 103:{return rt.Call(f,"forge/game/Game","nextCardId","()I","invokevirtual",106);}
case 106:{f.Locals[5]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Reference!=null?138:115;continue;}
case 115:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[4]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",126);}
case 126:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",129);}
case 129:{f.Locals[3]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/card/Card","setOwner","(Lforge/game/player/Player;)V","invokevirtual",135);}
case 135:{f.Pc=154;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",142);}
case 142:{f.Push(f.Locals[2]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[4]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",150);}
case 150:{return rt.Call(f,"forge/game/card/CardFactory","getCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;ILforge/game/Game;)Lforge/game/card/Card;","invokestatic",153);}
case 153:{f.Locals[3]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[3]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/card/CardFactory","getCloneStates","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCloneStates;","invokestatic",161);}
case 161:{return rt.Call(f,"forge/game/card/Card","setStates","(Ljava/util/Map;)V","invokevirtual",164);}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/card/Card","isTransformable","()Z","invokevirtual",168);}
case 168:{f.Pc=f.Pop().Int==0?205:171;continue;}
case 171:{f.Push(f.Locals[3]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[1]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/card/Card","isTransformed","()Z","invokevirtual",176);}
case 176:{f.Pc=f.Pop().Int==0?185:179;continue;}
case 179:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=182;continue;}
case 182:{f.Pc=188;continue;}
case 185:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=188;continue;}
case 188:{f.Push(JValue.I(1));f.Pc=189;continue;}
case 189:{f.Push(JValue.I(1));f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;ZZ)Z","invokevirtual",193);}
case 193:{f.StackOp("pop");f.Pc=194;continue;}
case 194:{f.Push(f.Locals[3]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[1]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/card/Card","isBackSide","()Z","invokevirtual",199);}
case 199:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",202);}
case 202:{f.Pc=216;continue;}
case 205:{f.Push(f.Locals[3]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[3]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",210);}
case 210:{f.Push(JValue.I(1));f.Pc=211;continue;}
case 211:{f.Push(JValue.I(1));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;ZZ)Z","invokevirtual",215);}
case 215:{f.StackOp("pop");f.Pc=216;continue;}
case 216:{f.Push(f.Locals[3]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[1]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/card/Card","getMarkedColors","()Lforge/card/ColorSet;","invokevirtual",221);}
case 221:{return rt.Call(f,"forge/game/card/Card","setMarkedColors","(Lforge/card/ColorSet;)V","invokevirtual",224);}
case 224:{f.Push(f.Locals[3]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[0]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/card/Card","setTokenSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",229);}
case 229:{f.Push(f.Locals[3]);f.Pc=230;continue;}
case 230:{if(!rt.StaticReady(f,"forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"));f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",236);}
case 236:{f.Push(f.Locals[3]);f.Pc=237;continue;}
case 237:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3228(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Populate")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?76:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Choices")));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Creature.token+YouCtrl")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("Choose a creature token to copy")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int!=0?76:46;continue;}
case 46:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("Populate")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",55);}
case 55:{f.Locals[2]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String(" (Create a token that's a copy of a creature token you control.)")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",72);}
case 72:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

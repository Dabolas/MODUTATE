// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C804{
internal static JClass Build(){var c=new JClass("forge/game/spellability/SpellAbilityProperty","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9526,"forge/game/spellability/SpellAbilityProperty","<init>","()V",1,1,1,new JHandler[]{},M9526));
c.Add(new JMethod(9527,"forge/game/spellability/SpellAbilityProperty","hasProperty","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Z",9,12,5,new JHandler[]{},M9527));
c.Add(new JMethod(9528,"forge/game/spellability/SpellAbilityProperty","lambda$hasProperty$0","(Lforge/game/player/PlayerCollection;Lforge/game/mana/Mana;)Z",4106,2,2,new JHandler[]{},M9528));
}

internal static JStep M9526(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9527(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ManaAbility")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?14:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManaAbility","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("withoutXCost")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?36:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","costHasManaX","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?34:30;continue;}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{f.Pc=35;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("XCost")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?96:45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(5));f.Pc=47;continue;}
case 47:{f.Push(JValue.I(7));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",58);}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{f.Push(JValue.I(7));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",64);}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",68);}
case 68:{f.Locals[6]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/SpellAbility","getXManaCostPaid","()Ljava/lang/Integer;","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Reference!=null?81:77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{f.Pc=88;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/spellability/SpellAbility","getXManaCostPaid","()Ljava/lang/Integer;","invokevirtual",85);}
case 85:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",88);}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",95);}
case 95:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("CountersRemovedToPay")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int==0?161:105;continue;}
case 105:{f.Push(f.Locals[3]);f.Pc=106;continue;}
case 106:{f.Push(JValue.I(20));f.Pc=108;continue;}
case 108:{f.Push(JValue.I(22));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",113);}
case 113:{f.Locals[5]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",119);}
case 119:{f.Push(f.Locals[3]);f.Pc=120;continue;}
case 120:{f.Push(JValue.I(22));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",125);}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",129);}
case 129:{f.Locals[6]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String("CostCountersRemoved")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVarInt","(Ljava/lang/String;)Ljava/lang/Integer;","invokevirtual",137);}
case 137:{f.Locals[7]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[7]);f.Pc=141;continue;}
case 141:{f.Pc=f.Pop().Reference!=null?148:144;continue;}
case 144:{f.Push(JValue.I(0));f.Pc=145;continue;}
case 145:{f.Pc=153;continue;}
case 148:{f.Push(f.Locals[7]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",153);}
case 153:{f.Push(f.Locals[5]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[6]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",160);}
case 160:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{f.Push(JValue.R(rt.String("SacrificedToPay")));f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",167);}
case 167:{f.Pc=f.Pop().Int==0?187:170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("Sacrificed")));f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;)Ljava/lang/Iterable;","invokevirtual",176);}
case 176:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",181);}
case 181:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",186);}
case 186:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 187:{f.Push(f.Locals[3]);f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String("hasTapCost")));f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",193);}
case 193:{f.Pc=f.Pop().Int==0?221:196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",200);}
case 200:{f.Locals[5]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[5]);f.Pc=204;continue;}
case 204:{f.Pc=f.Pop().Reference==null?219:207;continue;}
case 207:{f.Push(f.Locals[5]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/cost/Cost","hasTapCost","()Z","invokevirtual",212);}
case 212:{f.Pc=f.Pop().Int==0?219:215;continue;}
case 215:{f.Push(JValue.I(1));f.Pc=216;continue;}
case 216:{f.Pc=220;continue;}
case 219:{f.Push(JValue.I(0));f.Pc=220;continue;}
case 220:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 221:{f.Push(f.Locals[3]);f.Pc=222;continue;}
case 222:{f.Push(JValue.R(rt.String("Bargain")));f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",227);}
case 227:{f.Pc=f.Pop().Int==0?235:230;continue;}
case 230:{f.Push(f.Locals[0]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBargained","()Z","invokevirtual",234);}
case 234:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 235:{f.Push(f.Locals[3]);f.Pc=236;continue;}
case 236:{f.Push(JValue.R(rt.String("Backup")));f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",241);}
case 241:{f.Pc=f.Pop().Int==0?249:244;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBackup","()Z","invokevirtual",248);}
case 248:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 249:{f.Push(f.Locals[3]);f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("Bestow")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",255);}
case 255:{f.Pc=f.Pop().Int==0?263:258;continue;}
case 258:{f.Push(f.Locals[0]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBestow","()Z","invokevirtual",262);}
case 262:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 263:{f.Push(f.Locals[3]);f.Pc=264;continue;}
case 264:{f.Push(JValue.R(rt.String("Blitz")));f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",269);}
case 269:{f.Pc=f.Pop().Int==0?277:272;continue;}
case 272:{f.Push(f.Locals[0]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBlitz","()Z","invokevirtual",276);}
case 276:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 277:{f.Push(f.Locals[3]);f.Pc=278;continue;}
case 278:{f.Push(JValue.R(rt.String("Buyback")));f.Pc=280;continue;}
case 280:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",283);}
case 283:{f.Pc=f.Pop().Int==0?291:286;continue;}
case 286:{f.Push(f.Locals[0]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBuyback","()Z","invokevirtual",290);}
case 290:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 291:{f.Push(f.Locals[3]);f.Pc=292;continue;}
case 292:{f.Push(JValue.R(rt.String("Craft")));f.Pc=294;continue;}
case 294:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",297);}
case 297:{f.Pc=f.Pop().Int==0?305:300;continue;}
case 300:{f.Push(f.Locals[0]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCraft","()Z","invokevirtual",304);}
case 304:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 305:{f.Push(f.Locals[3]);f.Pc=306;continue;}
case 306:{f.Push(JValue.R(rt.String("Crew")));f.Pc=308;continue;}
case 308:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",311);}
case 311:{f.Pc=f.Pop().Int==0?319:314;continue;}
case 314:{f.Push(f.Locals[0]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCrew","()Z","invokevirtual",318);}
case 318:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 319:{f.Push(f.Locals[3]);f.Pc=320;continue;}
case 320:{f.Push(JValue.R(rt.String("Saddle")));f.Pc=322;continue;}
case 322:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",325);}
case 325:{f.Pc=f.Pop().Int==0?336:328;continue;}
case 328:{f.Push(f.Locals[0]);f.Pc=329;continue;}
case 329:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","SADDLE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","SADDLE","Lforge/game/keyword/Keyword;"));f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",335);}
case 335:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 336:{f.Push(f.Locals[3]);f.Pc=337;continue;}
case 337:{f.Push(JValue.R(rt.String("Station")));f.Pc=339;continue;}
case 339:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",342);}
case 342:{f.Pc=f.Pop().Int==0?353:345;continue;}
case 345:{f.Push(f.Locals[0]);f.Pc=346;continue;}
case 346:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","STATION","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","STATION","Lforge/game/keyword/Keyword;"));f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",352);}
case 352:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 353:{f.Push(f.Locals[3]);f.Pc=354;continue;}
case 354:{f.Push(JValue.R(rt.String("Cycling")));f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",359);}
case 359:{f.Pc=f.Pop().Int==0?367:362;continue;}
case 362:{f.Push(f.Locals[0]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCycling","()Z","invokevirtual",366);}
case 366:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 367:{f.Push(f.Locals[3]);f.Pc=368;continue;}
case 368:{f.Push(JValue.R(rt.String("Dash")));f.Pc=370;continue;}
case 370:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",373);}
case 373:{f.Pc=f.Pop().Int==0?381:376;continue;}
case 376:{f.Push(f.Locals[0]);f.Pc=377;continue;}
case 377:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDash","()Z","invokevirtual",380);}
case 380:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 381:{f.Push(f.Locals[3]);f.Pc=382;continue;}
case 382:{f.Push(JValue.R(rt.String("Disturb")));f.Pc=384;continue;}
case 384:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",387);}
case 387:{f.Pc=f.Pop().Int==0?395:390;continue;}
case 390:{f.Push(f.Locals[0]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDisturb","()Z","invokevirtual",394);}
case 394:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 395:{f.Push(f.Locals[3]);f.Pc=396;continue;}
case 396:{f.Push(JValue.R(rt.String("Embalm")));f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",401);}
case 401:{f.Pc=f.Pop().Int==0?409:404;continue;}
case 404:{f.Push(f.Locals[0]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/spellability/SpellAbility","isEmbalm","()Z","invokevirtual",408);}
case 408:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 409:{f.Push(f.Locals[3]);f.Pc=410;continue;}
case 410:{f.Push(JValue.R(rt.String("Eternalize")));f.Pc=412;continue;}
case 412:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",415);}
case 415:{f.Pc=f.Pop().Int==0?423:418;continue;}
case 418:{f.Push(f.Locals[0]);f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/game/spellability/SpellAbility","isEternalize","()Z","invokevirtual",422);}
case 422:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 423:{f.Push(f.Locals[3]);f.Pc=424;continue;}
case 424:{f.Push(JValue.R(rt.String("BeamMeUp")));f.Pc=426;continue;}
case 426:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",429);}
case 429:{f.Pc=f.Pop().Int==0?437:432;continue;}
case 432:{f.Push(f.Locals[0]);f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBeamMeUp","()Z","invokevirtual",436);}
case 436:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 437:{f.Push(f.Locals[3]);f.Pc=438;continue;}
case 438:{f.Push(JValue.R(rt.String("Flashback")));f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",443);}
case 443:{f.Pc=f.Pop().Int==0?451:446;continue;}
case 446:{f.Push(f.Locals[0]);f.Pc=447;continue;}
case 447:{return rt.Call(f,"forge/game/spellability/SpellAbility","isFlashback","()Z","invokevirtual",450);}
case 450:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 451:{f.Push(f.Locals[3]);f.Pc=452;continue;}
case 452:{f.Push(JValue.R(rt.String("Harmonize")));f.Pc=454;continue;}
case 454:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",457);}
case 457:{f.Pc=f.Pop().Int==0?465:460;continue;}
case 460:{f.Push(f.Locals[0]);f.Pc=461;continue;}
case 461:{return rt.Call(f,"forge/game/spellability/SpellAbility","isHarmonize","()Z","invokevirtual",464);}
case 464:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 465:{f.Push(f.Locals[3]);f.Pc=466;continue;}
case 466:{f.Push(JValue.R(rt.String("Jumpstart")));f.Pc=468;continue;}
case 468:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",471);}
case 471:{f.Pc=f.Pop().Int==0?479:474;continue;}
case 474:{f.Push(f.Locals[0]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/spellability/SpellAbility","isJumpstart","()Z","invokevirtual",478);}
case 478:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 479:{f.Push(f.Locals[3]);f.Pc=480;continue;}
case 480:{f.Push(JValue.R(rt.String("Kicked")));f.Pc=482;continue;}
case 482:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",485);}
case 485:{f.Pc=f.Pop().Int==0?493:488;continue;}
case 488:{f.Push(f.Locals[0]);f.Pc=489;continue;}
case 489:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKicked","()Z","invokevirtual",492);}
case 492:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 493:{f.Push(f.Locals[3]);f.Pc=494;continue;}
case 494:{f.Push(JValue.R(rt.String("Loyalty")));f.Pc=496;continue;}
case 496:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",499);}
case 499:{f.Pc=f.Pop().Int==0?507:502;continue;}
case 502:{f.Push(f.Locals[0]);f.Pc=503;continue;}
case 503:{return rt.Call(f,"forge/game/spellability/SpellAbility","isPwAbility","()Z","invokevirtual",506);}
case 506:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 507:{f.Push(f.Locals[3]);f.Pc=508;continue;}
case 508:{f.Push(JValue.R(rt.String("Aftermath")));f.Pc=510;continue;}
case 510:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",513);}
case 513:{f.Pc=f.Pop().Int==0?521:516;continue;}
case 516:{f.Push(f.Locals[0]);f.Pc=517;continue;}
case 517:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAftermath","()Z","invokevirtual",520);}
case 520:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 521:{f.Push(f.Locals[3]);f.Pc=522;continue;}
case 522:{f.Push(JValue.R(rt.String("PowerUp")));f.Pc=524;continue;}
case 524:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",527);}
case 527:{f.Pc=f.Pop().Int==0?535:530;continue;}
case 530:{f.Push(f.Locals[0]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"forge/game/spellability/SpellAbility","isPowerUp","()Z","invokevirtual",534);}
case 534:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 535:{f.Push(f.Locals[3]);f.Pc=536;continue;}
case 536:{f.Push(JValue.R(rt.String("MorphUp")));f.Pc=538;continue;}
case 538:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",541);}
case 541:{f.Pc=f.Pop().Int==0?549:544;continue;}
case 544:{f.Push(f.Locals[0]);f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/game/spellability/SpellAbility","isMorphUp","()Z","invokevirtual",548);}
case 548:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 549:{f.Push(f.Locals[3]);f.Pc=550;continue;}
case 550:{f.Push(JValue.R(rt.String("ManifestUp")));f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",555);}
case 555:{f.Pc=f.Pop().Int==0?563:558;continue;}
case 558:{f.Push(f.Locals[0]);f.Pc=559;continue;}
case 559:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManifestUp","()Z","invokevirtual",562);}
case 562:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 563:{f.Push(f.Locals[3]);f.Pc=564;continue;}
case 564:{f.Push(JValue.R(rt.String("Teamwork")));f.Pc=566;continue;}
case 566:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",569);}
case 569:{f.Pc=f.Pop().Int==0?577:572;continue;}
case 572:{f.Push(f.Locals[0]);f.Pc=573;continue;}
case 573:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTeamwork","()Z","invokevirtual",576);}
case 576:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 577:{f.Push(f.Locals[3]);f.Pc=578;continue;}
case 578:{f.Push(JValue.R(rt.String("Unlock")));f.Pc=580;continue;}
case 580:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",583);}
case 583:{f.Pc=f.Pop().Int==0?591:586;continue;}
case 586:{f.Push(f.Locals[0]);f.Pc=587;continue;}
case 587:{return rt.Call(f,"forge/game/spellability/SpellAbility","isUnlock","()Z","invokevirtual",590);}
case 590:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 591:{f.Push(f.Locals[3]);f.Pc=592;continue;}
case 592:{f.Push(JValue.R(rt.String("isTurnFaceUp")));f.Pc=594;continue;}
case 594:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",597);}
case 597:{f.Pc=f.Pop().Int==0?605:600;continue;}
case 600:{f.Push(f.Locals[0]);f.Pc=601;continue;}
case 601:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTurnFaceUp","()Z","invokevirtual",604);}
case 604:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 605:{f.Push(f.Locals[3]);f.Pc=606;continue;}
case 606:{f.Push(JValue.R(rt.String("isCastFaceDown")));f.Pc=608;continue;}
case 608:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",611);}
case 611:{f.Pc=f.Pop().Int==0?619:614;continue;}
case 614:{f.Push(f.Locals[0]);f.Pc=615;continue;}
case 615:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCastFaceDown","()Z","invokevirtual",618);}
case 618:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 619:{f.Push(f.Locals[3]);f.Pc=620;continue;}
case 620:{f.Push(JValue.R(rt.String("Unearth")));f.Pc=622;continue;}
case 622:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",625);}
case 625:{f.Pc=f.Pop().Int==0?636:628;continue;}
case 628:{f.Push(f.Locals[0]);f.Pc=629;continue;}
case 629:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","UNEARTH","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","UNEARTH","Lforge/game/keyword/Keyword;"));f.Pc=632;continue;}
case 632:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",635);}
case 635:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 636:{f.Push(f.Locals[3]);f.Pc=637;continue;}
case 637:{f.Push(JValue.R(rt.String("Modular")));f.Pc=639;continue;}
case 639:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",642);}
case 642:{f.Pc=f.Pop().Int==0?653:645;continue;}
case 645:{f.Push(f.Locals[0]);f.Pc=646;continue;}
case 646:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","MODULAR","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","MODULAR","Lforge/game/keyword/Keyword;"));f.Pc=649;continue;}
case 649:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",652);}
case 652:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 653:{f.Push(f.Locals[3]);f.Pc=654;continue;}
case 654:{f.Push(JValue.R(rt.String("Equip")));f.Pc=657;continue;}
case 657:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",660);}
case 660:{f.Pc=f.Pop().Int==0?668:663;continue;}
case 663:{f.Push(f.Locals[0]);f.Pc=664;continue;}
case 664:{return rt.Call(f,"forge/game/spellability/SpellAbility","isEquip","()Z","invokevirtual",667);}
case 667:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 668:{f.Push(f.Locals[3]);f.Pc=669;continue;}
case 669:{f.Push(JValue.R(rt.String("Boast")));f.Pc=672;continue;}
case 672:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",675);}
case 675:{f.Pc=f.Pop().Int==0?683:678;continue;}
case 678:{f.Push(f.Locals[0]);f.Pc=679;continue;}
case 679:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBoast","()Z","invokevirtual",682);}
case 682:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 683:{f.Push(f.Locals[3]);f.Pc=684;continue;}
case 684:{f.Push(JValue.R(rt.String("Monstrosity")));f.Pc=687;continue;}
case 687:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",690);}
case 690:{f.Pc=f.Pop().Int==0?698:693;continue;}
case 693:{f.Push(f.Locals[0]);f.Pc=694;continue;}
case 694:{return rt.Call(f,"forge/game/spellability/SpellAbility","isMonstrosity","()Z","invokevirtual",697);}
case 697:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 698:{f.Push(f.Locals[3]);f.Pc=699;continue;}
case 699:{f.Push(JValue.R(rt.String("Exhaust")));f.Pc=702;continue;}
case 702:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",705);}
case 705:{f.Pc=f.Pop().Int==0?713:708;continue;}
case 708:{f.Push(f.Locals[0]);f.Pc=709;continue;}
case 709:{return rt.Call(f,"forge/game/spellability/SpellAbility","isExhaust","()Z","invokevirtual",712);}
case 712:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 713:{f.Push(f.Locals[3]);f.Pc=714;continue;}
case 714:{f.Push(JValue.R(rt.String("Mayhem")));f.Pc=717;continue;}
case 717:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",720);}
case 720:{f.Pc=f.Pop().Int==0?728:723;continue;}
case 723:{f.Push(f.Locals[0]);f.Pc=724;continue;}
case 724:{return rt.Call(f,"forge/game/spellability/SpellAbility","isMayhem","()Z","invokevirtual",727);}
case 727:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 728:{f.Push(f.Locals[3]);f.Pc=729;continue;}
case 729:{f.Push(JValue.R(rt.String("Mutate")));f.Pc=732;continue;}
case 732:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",735);}
case 735:{f.Pc=f.Pop().Int==0?743:738;continue;}
case 738:{f.Push(f.Locals[0]);f.Pc=739;continue;}
case 739:{return rt.Call(f,"forge/game/spellability/SpellAbility","isMutate","()Z","invokevirtual",742);}
case 742:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 743:{f.Push(f.Locals[3]);f.Pc=744;continue;}
case 744:{f.Push(JValue.R(rt.String("Ninjutsu")));f.Pc=747;continue;}
case 747:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",750);}
case 750:{f.Pc=f.Pop().Int==0?758:753;continue;}
case 753:{f.Push(f.Locals[0]);f.Pc=754;continue;}
case 754:{return rt.Call(f,"forge/game/spellability/SpellAbility","isNinjutsu","()Z","invokevirtual",757);}
case 757:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 758:{f.Push(f.Locals[3]);f.Pc=759;continue;}
case 759:{f.Push(JValue.R(rt.String("Sneak")));f.Pc=762;continue;}
case 762:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",765);}
case 765:{f.Pc=f.Pop().Int==0?773:768;continue;}
case 768:{f.Push(f.Locals[0]);f.Pc=769;continue;}
case 769:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSneak","()Z","invokevirtual",772);}
case 772:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 773:{f.Push(f.Locals[3]);f.Pc=774;continue;}
case 774:{f.Push(JValue.R(rt.String("Foretelling")));f.Pc=777;continue;}
case 777:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",780);}
case 780:{f.Pc=f.Pop().Int==0?788:783;continue;}
case 783:{f.Push(f.Locals[0]);f.Pc=784;continue;}
case 784:{return rt.Call(f,"forge/game/spellability/SpellAbility","isForetelling","()Z","invokevirtual",787);}
case 787:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 788:{f.Push(f.Locals[3]);f.Pc=789;continue;}
case 789:{f.Push(JValue.R(rt.String("Foretold")));f.Pc=792;continue;}
case 792:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",795);}
case 795:{f.Pc=f.Pop().Int==0?803:798;continue;}
case 798:{f.Push(f.Locals[0]);f.Pc=799;continue;}
case 799:{return rt.Call(f,"forge/game/spellability/SpellAbility","isForetold","()Z","invokevirtual",802);}
case 802:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 803:{f.Push(f.Locals[3]);f.Pc=804;continue;}
case 804:{f.Push(JValue.R(rt.String("Plotting")));f.Pc=807;continue;}
case 807:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",810);}
case 810:{f.Pc=f.Pop().Int==0?818:813;continue;}
case 813:{f.Push(f.Locals[0]);f.Pc=814;continue;}
case 814:{return rt.Call(f,"forge/game/spellability/SpellAbility","isPlotting","()Z","invokevirtual",817);}
case 817:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 818:{f.Push(f.Locals[3]);f.Pc=819;continue;}
case 819:{f.Push(JValue.R(rt.String("Outlast")));f.Pc=822;continue;}
case 822:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",825);}
case 825:{f.Pc=f.Pop().Int==0?833:828;continue;}
case 828:{f.Push(f.Locals[0]);f.Pc=829;continue;}
case 829:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOutlast","()Z","invokevirtual",832);}
case 832:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 833:{f.Push(f.Locals[3]);f.Pc=834;continue;}
case 834:{f.Push(JValue.R(rt.String("Modal")));f.Pc=837;continue;}
case 837:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",840);}
case 840:{f.Pc=f.Pop().Int==0?859:843;continue;}
case 843:{f.Push(f.Locals[0]);f.Pc=844;continue;}
case 844:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",847);}
case 847:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"));f.Pc=850;continue;}
case 850:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?857:853;continue;}
case 853:{f.Push(JValue.I(1));f.Pc=854;continue;}
case 854:{f.Pc=858;continue;}
case 857:{f.Push(JValue.I(0));f.Pc=858;continue;}
case 858:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 859:{f.Push(f.Locals[3]);f.Pc=860;continue;}
case 860:{f.Push(JValue.R(rt.String("ClassLevelUp")));f.Pc=863;continue;}
case 863:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",866);}
case 866:{f.Pc=f.Pop().Int==0?885:869;continue;}
case 869:{f.Push(f.Locals[0]);f.Pc=870;continue;}
case 870:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",873);}
case 873:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ClassLevelUp","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ClassLevelUp","Lforge/game/ability/ApiType;"));f.Pc=876;continue;}
case 876:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?883:879;continue;}
case 879:{f.Push(JValue.I(1));f.Pc=880;continue;}
case 880:{f.Pc=884;continue;}
case 883:{f.Push(JValue.I(0));f.Pc=884;continue;}
case 884:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 885:{f.Push(f.Locals[3]);f.Pc=886;continue;}
case 886:{f.Push(JValue.R(rt.String("Daybound")));f.Pc=889;continue;}
case 889:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",892);}
case 892:{f.Pc=f.Pop().Int==0?903:895;continue;}
case 895:{f.Push(f.Locals[0]);f.Pc=896;continue;}
case 896:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","DAYBOUND","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","DAYBOUND","Lforge/game/keyword/Keyword;"));f.Pc=899;continue;}
case 899:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",902);}
case 902:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 903:{f.Push(f.Locals[3]);f.Pc=904;continue;}
case 904:{f.Push(JValue.R(rt.String("Nightbound")));f.Pc=907;continue;}
case 907:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",910);}
case 910:{f.Pc=f.Pop().Int==0?921:913;continue;}
case 913:{f.Push(f.Locals[0]);f.Pc=914;continue;}
case 914:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","NIGHTBOUND","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","NIGHTBOUND","Lforge/game/keyword/Keyword;"));f.Pc=917;continue;}
case 917:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",920);}
case 920:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 921:{f.Push(f.Locals[3]);f.Pc=922;continue;}
case 922:{f.Push(JValue.R(rt.String("Warp")));f.Pc=925;continue;}
case 925:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",928);}
case 928:{f.Pc=f.Pop().Int==0?936:931;continue;}
case 931:{f.Push(f.Locals[0]);f.Pc=932;continue;}
case 932:{return rt.Call(f,"forge/game/spellability/SpellAbility","isWarp","()Z","invokevirtual",935);}
case 935:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 936:{f.Push(f.Locals[3]);f.Pc=937;continue;}
case 937:{f.Push(JValue.R(rt.String("Ward")));f.Pc=940;continue;}
case 940:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",943);}
case 943:{f.Pc=f.Pop().Int==0?954:946;continue;}
case 946:{f.Push(f.Locals[0]);f.Pc=947;continue;}
case 947:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","WARD","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","WARD","Lforge/game/keyword/Keyword;"));f.Pc=950;continue;}
case 950:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",953);}
case 953:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 954:{f.Push(f.Locals[3]);f.Pc=955;continue;}
case 955:{f.Push(JValue.R(rt.String("CumulativeUpkeep")));f.Pc=958;continue;}
case 958:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",961);}
case 961:{f.Pc=f.Pop().Int==0?969:964;continue;}
case 964:{f.Push(f.Locals[0]);f.Pc=965;continue;}
case 965:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCumulativeUpkeep","()Z","invokevirtual",968);}
case 968:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 969:{f.Push(f.Locals[3]);f.Pc=970;continue;}
case 970:{f.Push(JValue.R(rt.String("SameKeyword")));f.Pc=973;continue;}
case 973:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",976);}
case 976:{f.Pc=f.Pop().Int==0?1006:979;continue;}
case 979:{f.Push(f.Locals[0]);f.Pc=980;continue;}
case 980:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",983);}
case 983:{f.Pc=f.Pop().Reference==null?991:986;continue;}
case 986:{f.Push(f.Locals[4]);f.Pc=988;continue;}
case 988:{f.Pc=f.Pop().Reference!=null?993:991;continue;}
case 991:{f.Push(JValue.I(0));f.Pc=992;continue;}
case 992:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 993:{f.Push(f.Locals[0]);f.Pc=994;continue;}
case 994:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",997);}
case 997:{f.Push(f.Locals[4]);f.Pc=999;continue;}
case 999:{return rt.Call(f,"forge/game/CardTraitBase","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",1002);}
case 1002:{return rt.Call(f,"java/util/Objects","equals","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",1005);}
case 1005:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1006:{f.Push(f.Locals[3]);f.Pc=1007;continue;}
case 1007:{f.Push(JValue.R(rt.String("ChapterNotLore")));f.Pc=1010;continue;}
case 1010:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1013);}
case 1013:{f.Pc=f.Pop().Int==0?1047:1016;continue;}
case 1016:{f.Push(f.Locals[0]);f.Pc=1017;continue;}
case 1017:{return rt.Call(f,"forge/game/spellability/SpellAbility","isChapter","()Z","invokevirtual",1020);}
case 1020:{f.Pc=f.Pop().Int!=0?1025:1023;continue;}
case 1023:{f.Push(JValue.I(0));f.Pc=1024;continue;}
case 1024:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1025:{f.Push(f.Locals[0]);f.Pc=1026;continue;}
case 1026:{return rt.Call(f,"forge/game/spellability/SpellAbility","getChapter","()Ljava/lang/Integer;","invokevirtual",1029);}
case 1029:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1032);}
case 1032:{f.Push(f.Locals[0]);f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1036);}
case 1036:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LORE","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LORE","Lforge/game/card/CounterEnumType;"));f.Pc=1039;continue;}
case 1039:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",1042);}
case 1042:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?2372:1045;continue;}
case 1045:{f.Push(JValue.I(0));f.Pc=1046;continue;}
case 1046:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1047:{f.Push(f.Locals[3]);f.Pc=1048;continue;}
case 1048:{f.Push(JValue.R(rt.String("EffectSourceAbility")));f.Pc=1051;continue;}
case 1051:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1054);}
case 1054:{f.Pc=f.Pop().Int==0?1144:1057;continue;}
case 1057:{f.Push(f.Locals[2]);f.Pc=1058;continue;}
case 1058:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",1061);}
case 1061:{f.Pc=f.Pop().Int!=0?1066:1064;continue;}
case 1064:{f.Push(JValue.I(0));f.Pc=1065;continue;}
case 1065:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1066:{f.Push(f.Locals[2]);f.Pc=1067;continue;}
case 1067:{return rt.Call(f,"forge/game/card/Card","getEffectSourceAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1070);}
case 1070:{f.Pc=f.Pop().Reference!=null?1075:1073;continue;}
case 1073:{f.Push(JValue.I(0));f.Pc=1074;continue;}
case 1074:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1075:{f.Push(f.Locals[2]);f.Pc=1076;continue;}
case 1076:{return rt.Call(f,"forge/game/card/Card","getEffectSourceAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1079);}
case 1079:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1082);}
case 1082:{f.Locals[5]=f.Pop();f.Pc=1084;continue;}
case 1084:{f.Push(f.Locals[5]);f.Pc=1086;continue;}
case 1086:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/trigger/WrappedAbility")?1:0));f.Pc=1089;continue;}
case 1089:{f.Pc=f.Pop().Int==0?1106:1092;continue;}
case 1092:{f.Push(f.Locals[5]);f.Pc=1094;continue;}
case 1094:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/WrappedAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1097;continue;}
case 1097:{f.Locals[6]=f.Pop();f.Pc=1099;continue;}
case 1099:{f.Push(f.Locals[6]);f.Pc=1101;continue;}
case 1101:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getWrappedAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1104);}
case 1104:{f.Locals[5]=f.Pop();f.Pc=1106;continue;}
case 1106:{f.Push(f.Locals[0]);f.Pc=1107;continue;}
case 1107:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1110);}
case 1110:{f.Locals[0]=f.Pop();f.Pc=1111;continue;}
case 1111:{f.Push(f.Locals[0]);f.Pc=1112;continue;}
case 1112:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/trigger/WrappedAbility")?1:0));f.Pc=1115;continue;}
case 1115:{f.Pc=f.Pop().Int==0?1130:1118;continue;}
case 1118:{f.Push(f.Locals[0]);f.Pc=1119;continue;}
case 1119:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/WrappedAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1122;continue;}
case 1122:{f.Locals[6]=f.Pop();f.Pc=1124;continue;}
case 1124:{f.Push(f.Locals[6]);f.Pc=1126;continue;}
case 1126:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getWrappedAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1129);}
case 1129:{f.Locals[0]=f.Pop();f.Pc=1130;continue;}
case 1130:{f.Push(f.Locals[0]);f.Pc=1131;continue;}
case 1131:{f.Push(f.Locals[5]);f.Pc=1133;continue;}
case 1133:{return rt.Call(f,"forge/game/spellability/SpellAbility","equals","(Ljava/lang/Object;)Z","invokevirtual",1136);}
case 1136:{f.Pc=f.Pop().Int!=0?1141:1139;continue;}
case 1139:{f.Push(JValue.I(0));f.Pc=1140;continue;}
case 1140:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1141:{f.Pc=2372;continue;}
case 1144:{f.Push(f.Locals[3]);f.Pc=1145;continue;}
case 1145:{f.Push(JValue.R(rt.String("LastChapter")));f.Pc=1148;continue;}
case 1148:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1151);}
case 1151:{f.Pc=f.Pop().Int==0?1159:1154;continue;}
case 1154:{f.Push(f.Locals[0]);f.Pc=1155;continue;}
case 1155:{return rt.Call(f,"forge/game/spellability/SpellAbility","isLastChapter","()Z","invokevirtual",1158);}
case 1158:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1159:{f.Push(f.Locals[3]);f.Pc=1160;continue;}
case 1160:{f.Push(JValue.R(rt.String("paidPhyrexianMana")));f.Pc=1163;continue;}
case 1163:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1166);}
case 1166:{f.Pc=f.Pop().Int==0?1182:1169;continue;}
case 1169:{f.Push(f.Locals[0]);f.Pc=1170;continue;}
case 1170:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSpendPhyrexianMana","()I","invokevirtual",1173);}
case 1173:{f.Pc=f.Pop().Int<=0?1180:1176;continue;}
case 1176:{f.Push(JValue.I(1));f.Pc=1177;continue;}
case 1177:{f.Pc=1181;continue;}
case 1180:{f.Push(JValue.I(0));f.Pc=1181;continue;}
case 1181:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1182:{f.Push(f.Locals[3]);f.Pc=1183;continue;}
case 1183:{f.Push(JValue.R(rt.String("ManaSpentBy")));f.Pc=1186;continue;}
case 1186:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1189);}
case 1189:{f.Pc=f.Pop().Int==0?1236:1192;continue;}
case 1192:{f.Push(f.Locals[3]);f.Pc=1193;continue;}
case 1193:{f.Push(JValue.R(rt.String(" ")));f.Pc=1196;continue;}
case 1196:{f.Push(JValue.I(2));f.Pc=1197;continue;}
case 1197:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",1200);}
case 1200:{f.Locals[5]=f.Pop();f.Pc=1202;continue;}
case 1202:{f.Push(f.Locals[2]);f.Pc=1203;continue;}
case 1203:{f.Push(f.Locals[5]);f.Pc=1205;continue;}
case 1205:{f.Push(JValue.I(1));f.Pc=1206;continue;}
case 1206:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1207;continue;}
case 1207:{f.Push(f.Locals[4]);f.Pc=1209;continue;}
case 1209:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1212);}
case 1212:{f.Locals[6]=f.Pop();f.Pc=1214;continue;}
case 1214:{f.Push(f.Locals[0]);f.Pc=1215;continue;}
case 1215:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",1218);}
case 1218:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",1223);}
case 1223:{f.Push(f.Locals[6]);f.Pc=1225;continue;}
case 1225:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbilityProperty:9527:1225:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/PlayerCollection;)Ljava/util/function/Predicate;",1230);}
case 1230:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",1235);}
case 1235:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1236:{f.Push(f.Locals[3]);f.Pc=1237;continue;}
case 1237:{f.Push(JValue.R(rt.String("ManaSpent")));f.Pc=1240;continue;}
case 1240:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1243);}
case 1243:{f.Pc=f.Pop().Int==0?1295:1246;continue;}
case 1246:{f.Push(f.Locals[3]);f.Pc=1247;continue;}
case 1247:{f.Push(JValue.R(rt.String(" ")));f.Pc=1250;continue;}
case 1250:{f.Push(JValue.I(2));f.Pc=1251;continue;}
case 1251:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",1254);}
case 1254:{f.Locals[5]=f.Pop();f.Pc=1256;continue;}
case 1256:{f.Push(f.Locals[5]);f.Pc=1258;continue;}
case 1258:{f.Push(JValue.I(1));f.Pc=1259;continue;}
case 1259:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1260;continue;}
case 1260:{f.Push(JValue.I(0));f.Pc=1261;continue;}
case 1261:{f.Push(JValue.I(2));f.Pc=1262;continue;}
case 1262:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",1265);}
case 1265:{f.Locals[6]=f.Pop();f.Pc=1267;continue;}
case 1267:{f.Push(f.Locals[2]);f.Pc=1268;continue;}
case 1268:{f.Push(f.Locals[5]);f.Pc=1270;continue;}
case 1270:{f.Push(JValue.I(1));f.Pc=1271;continue;}
case 1271:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1272;continue;}
case 1272:{f.Push(JValue.I(2));f.Pc=1273;continue;}
case 1273:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1276);}
case 1276:{f.Push(f.Locals[4]);f.Pc=1278;continue;}
case 1278:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1281);}
case 1281:{f.Locals[7]=f.Pop();f.Pc=1283;continue;}
case 1283:{f.Push(f.Locals[0]);f.Pc=1284;continue;}
case 1284:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTotalManaSpent","()I","invokevirtual",1287);}
case 1287:{f.Push(f.Locals[6]);f.Pc=1289;continue;}
case 1289:{f.Push(f.Locals[7]);f.Pc=1291;continue;}
case 1291:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1294);}
case 1294:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1295:{f.Push(f.Locals[3]);f.Pc=1296;continue;}
case 1296:{f.Push(JValue.R(rt.String("ManaFrom")));f.Pc=1299;continue;}
case 1299:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1302);}
case 1302:{f.Pc=f.Pop().Int==0?1455:1305;continue;}
case 1305:{f.Push(f.Locals[3]);f.Pc=1306;continue;}
case 1306:{f.Push(JValue.I(8));f.Pc=1308;continue;}
case 1308:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1311);}
case 1311:{f.Locals[5]=f.Pop();f.Pc=1313;continue;}
case 1313:{f.Push(JValue.R(null));f.Pc=1314;continue;}
case 1314:{f.Locals[6]=f.Pop();f.Pc=1316;continue;}
case 1316:{f.Push(f.Locals[5]);f.Pc=1318;continue;}
case 1318:{f.Push(JValue.R(rt.String("_")));f.Pc=1321;continue;}
case 1321:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1324);}
case 1324:{f.Pc=f.Pop().Int==0?1343:1327;continue;}
case 1327:{f.Push(f.Locals[5]);f.Pc=1329;continue;}
case 1329:{f.Push(JValue.R(rt.String("_")));f.Pc=1332;continue;}
case 1332:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1335);}
case 1335:{f.Locals[6]=f.Pop();f.Pc=1337;continue;}
case 1337:{f.Push(f.Locals[6]);f.Pc=1339;continue;}
case 1339:{f.Push(JValue.I(0));f.Pc=1340;continue;}
case 1340:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1341;continue;}
case 1341:{f.Locals[5]=f.Pop();f.Pc=1343;continue;}
case 1343:{f.Push(f.Locals[6]);f.Pc=1345;continue;}
case 1345:{f.Pc=f.Pop().Reference==null?1361:1348;continue;}
case 1348:{f.Push(f.Locals[2]);f.Pc=1349;continue;}
case 1349:{f.Push(f.Locals[6]);f.Pc=1351;continue;}
case 1351:{f.Push(JValue.I(1));f.Pc=1352;continue;}
case 1352:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1353;continue;}
case 1353:{f.Push(f.Locals[4]);f.Pc=1355;continue;}
case 1355:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1358);}
case 1358:{f.Pc=1362;continue;}
case 1361:{f.Push(JValue.I(1));f.Pc=1362;continue;}
case 1362:{f.Locals[7]=f.Pop();f.Pc=1364;continue;}
case 1364:{f.Push(JValue.I(0));f.Pc=1365;continue;}
case 1365:{f.Locals[8]=f.Pop();f.Pc=1367;continue;}
case 1367:{f.Push(f.Locals[0]);f.Pc=1368;continue;}
case 1368:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",1371);}
case 1371:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1376);}
case 1376:{f.Locals[9]=f.Pop();f.Pc=1378;continue;}
case 1378:{f.Push(f.Locals[9]);f.Pc=1380;continue;}
case 1380:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1385);}
case 1385:{f.Pc=f.Pop().Int==0?1442:1388;continue;}
case 1388:{f.Push(f.Locals[9]);f.Pc=1390;continue;}
case 1390:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1395);}
case 1395:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1398;continue;}
case 1398:{f.Locals[10]=f.Pop();f.Pc=1400;continue;}
case 1400:{f.Push(f.Locals[10]);f.Pc=1402;continue;}
case 1402:{return rt.Call(f,"forge/game/mana/Mana","getSourceCard","()Lforge/game/card/Card;","invokevirtual",1405);}
case 1405:{f.Locals[11]=f.Pop();f.Pc=1407;continue;}
case 1407:{f.Push(f.Locals[11]);f.Pc=1409;continue;}
case 1409:{f.Pc=f.Pop().Reference==null?1439:1412;continue;}
case 1412:{f.Push(f.Locals[11]);f.Pc=1414;continue;}
case 1414:{f.Push(f.Locals[5]);f.Pc=1416;continue;}
case 1416:{f.Push(f.Locals[1]);f.Pc=1417;continue;}
case 1417:{f.Push(f.Locals[2]);f.Pc=1418;continue;}
case 1418:{f.Push(f.Locals[4]);f.Pc=1420;continue;}
case 1420:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",1423);}
case 1423:{f.Pc=f.Pop().Int==0?1439:1426;continue;}
case 1426:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=1429;continue;}
case 1429:{f.Push(f.Locals[8]);f.Pc=1431;continue;}
case 1431:{f.Push(f.Locals[7]);f.Pc=1433;continue;}
case 1433:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1439:1436;continue;}
case 1436:{f.Pc=1442;continue;}
case 1439:{f.Pc=1378;continue;}
case 1442:{f.Push(f.Locals[8]);f.Pc=1444;continue;}
case 1444:{f.Push(f.Locals[7]);f.Pc=1446;continue;}
case 1446:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1453:1449;continue;}
case 1449:{f.Push(JValue.I(1));f.Pc=1450;continue;}
case 1450:{f.Pc=1454;continue;}
case 1453:{f.Push(JValue.I(0));f.Pc=1454;continue;}
case 1454:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1455:{f.Push(f.Locals[3]);f.Pc=1456;continue;}
case 1456:{f.Push(JValue.R(rt.String("MayPlaySource")));f.Pc=1459;continue;}
case 1459:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1462);}
case 1462:{f.Pc=f.Pop().Int==0?1488:1465;continue;}
case 1465:{f.Push(f.Locals[0]);f.Pc=1466;continue;}
case 1466:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMayPlay","()Lforge/game/staticability/StaticAbility;","invokevirtual",1469);}
case 1469:{f.Locals[5]=f.Pop();f.Pc=1471;continue;}
case 1471:{f.Push(f.Locals[5]);f.Pc=1473;continue;}
case 1473:{f.Pc=f.Pop().Reference!=null?1478:1476;continue;}
case 1476:{f.Push(JValue.I(0));f.Pc=1477;continue;}
case 1477:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1478:{f.Push(f.Locals[2]);f.Pc=1479;continue;}
case 1479:{f.Push(f.Locals[5]);f.Pc=1481;continue;}
case 1481:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1484);}
case 1484:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",1487);}
case 1487:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1488:{f.Push(f.Locals[3]);f.Pc=1489;continue;}
case 1489:{f.Push(JValue.R(rt.String("KeywordSource")));f.Pc=1492;continue;}
case 1492:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1495);}
case 1495:{f.Pc=f.Pop().Int==0?1536:1498;continue;}
case 1498:{f.Push(f.Locals[0]);f.Pc=1499;continue;}
case 1499:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",1502);}
case 1502:{f.Pc=f.Pop().Reference==null?1517:1505;continue;}
case 1505:{f.Push(f.Locals[0]);f.Pc=1506;continue;}
case 1506:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",1509);}
case 1509:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",1514);}
case 1514:{f.Pc=f.Pop().Reference!=null?1519:1517;continue;}
case 1517:{f.Push(JValue.I(0));f.Pc=1518;continue;}
case 1518:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1519:{f.Push(f.Locals[2]);f.Pc=1520;continue;}
case 1520:{f.Push(f.Locals[0]);f.Pc=1521;continue;}
case 1521:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",1524);}
case 1524:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",1529);}
case 1529:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1532);}
case 1532:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",1535);}
case 1535:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1536:{f.Push(f.Locals[3]);f.Pc=1537;continue;}
case 1537:{f.Push(JValue.R(rt.String("singleTarget")));f.Pc=1540;continue;}
case 1540:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1543);}
case 1543:{f.Pc=f.Pop().Int==0?1614:1546;continue;}
case 1546:{f.Push(JValue.I(0));f.Pc=1547;continue;}
case 1547:{f.Locals[5]=f.Pop();f.Pc=1549;continue;}
case 1549:{f.Push(f.Locals[0]);f.Pc=1550;continue;}
case 1550:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAllTargetChoices","()Ljava/util/List;","invokevirtual",1553);}
case 1553:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1558);}
case 1558:{f.Locals[6]=f.Pop();f.Pc=1560;continue;}
case 1560:{f.Push(f.Locals[6]);f.Pc=1562;continue;}
case 1562:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1567);}
case 1567:{f.Pc=f.Pop().Int==0?1603:1570;continue;}
case 1570:{f.Push(f.Locals[6]);f.Pc=1572;continue;}
case 1572:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1577);}
case 1577:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/TargetChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1580;continue;}
case 1580:{f.Locals[7]=f.Pop();f.Pc=1582;continue;}
case 1582:{f.Push(f.Locals[5]);f.Pc=1584;continue;}
case 1584:{f.Push(f.Locals[7]);f.Pc=1586;continue;}
case 1586:{return rt.Call(f,"forge/game/spellability/TargetChoices","size","()I","invokevirtual",1589);}
case 1589:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1590;continue;}
case 1590:{f.Locals[5]=f.Pop();f.Pc=1592;continue;}
case 1592:{f.Push(f.Locals[5]);f.Pc=1594;continue;}
case 1594:{f.Push(JValue.I(1));f.Pc=1595;continue;}
case 1595:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1600:1598;continue;}
case 1598:{f.Push(JValue.I(0));f.Pc=1599;continue;}
case 1599:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1600:{f.Pc=1560;continue;}
case 1603:{f.Push(f.Locals[5]);f.Pc=1605;continue;}
case 1605:{f.Push(JValue.I(1));f.Pc=1606;continue;}
case 1606:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?1611:1609;continue;}
case 1609:{f.Push(JValue.I(0));f.Pc=1610;continue;}
case 1610:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1611:{f.Pc=2372;continue;}
case 1614:{f.Push(f.Locals[3]);f.Pc=1615;continue;}
case 1615:{f.Push(JValue.R(rt.String("numTargets")));f.Pc=1618;continue;}
case 1618:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1621);}
case 1621:{f.Pc=f.Pop().Int==0?1733:1624;continue;}
case 1624:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=1627;continue;}
case 1627:{f.StackOp("dup");f.Pc=1628;continue;}
case 1628:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",1631);}
case 1631:{f.Locals[5]=f.Pop();f.Pc=1633;continue;}
case 1633:{f.Push(f.Locals[0]);f.Pc=1634;continue;}
case 1634:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAllTargetChoices","()Ljava/util/List;","invokevirtual",1637);}
case 1637:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1642);}
case 1642:{f.Locals[6]=f.Pop();f.Pc=1644;continue;}
case 1644:{f.Push(f.Locals[6]);f.Pc=1646;continue;}
case 1646:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1651);}
case 1651:{f.Pc=f.Pop().Int==0?1679:1654;continue;}
case 1654:{f.Push(f.Locals[6]);f.Pc=1656;continue;}
case 1656:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1661);}
case 1661:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/TargetChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1664;continue;}
case 1664:{f.Locals[7]=f.Pop();f.Pc=1666;continue;}
case 1666:{f.Push(f.Locals[5]);f.Pc=1668;continue;}
case 1668:{f.Push(f.Locals[7]);f.Pc=1670;continue;}
case 1670:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",1675);}
case 1675:{f.StackOp("pop");f.Pc=1676;continue;}
case 1676:{f.Pc=1644;continue;}
case 1679:{f.Push(f.Locals[3]);f.Pc=1680;continue;}
case 1680:{f.Push(JValue.R(rt.String(" ")));f.Pc=1683;continue;}
case 1683:{f.Push(JValue.I(2));f.Pc=1684;continue;}
case 1684:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",1687);}
case 1687:{f.Locals[6]=f.Pop();f.Pc=1689;continue;}
case 1689:{f.Push(f.Locals[6]);f.Pc=1691;continue;}
case 1691:{f.Push(JValue.I(1));f.Pc=1692;continue;}
case 1692:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1693;continue;}
case 1693:{f.Push(JValue.I(0));f.Pc=1694;continue;}
case 1694:{f.Push(JValue.I(2));f.Pc=1695;continue;}
case 1695:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",1698);}
case 1698:{f.Locals[7]=f.Pop();f.Pc=1700;continue;}
case 1700:{f.Push(f.Locals[0]);f.Pc=1701;continue;}
case 1701:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1704);}
case 1704:{f.Push(f.Locals[6]);f.Pc=1706;continue;}
case 1706:{f.Push(JValue.I(1));f.Pc=1707;continue;}
case 1707:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1708;continue;}
case 1708:{f.Push(JValue.I(2));f.Pc=1709;continue;}
case 1709:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1712);}
case 1712:{f.Push(f.Locals[0]);f.Pc=1713;continue;}
case 1713:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1716);}
case 1716:{f.Locals[8]=f.Pop();f.Pc=1718;continue;}
case 1718:{f.Push(f.Locals[5]);f.Pc=1720;continue;}
case 1720:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",1725);}
case 1725:{f.Push(f.Locals[7]);f.Pc=1727;continue;}
case 1727:{f.Push(f.Locals[8]);f.Pc=1729;continue;}
case 1729:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1732);}
case 1732:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1733:{f.Push(f.Locals[3]);f.Pc=1734;continue;}
case 1734:{f.Push(JValue.R(rt.String("IsTargeting")));f.Pc=1737;continue;}
case 1737:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1740);}
case 1740:{f.Pc=f.Pop().Int==0?1830:1743;continue;}
case 1743:{f.Push(f.Locals[3]);f.Pc=1744;continue;}
case 1744:{f.Push(JValue.R(rt.String(" ")));f.Pc=1747;continue;}
case 1747:{f.Push(JValue.I(2));f.Pc=1748;continue;}
case 1748:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",1751);}
case 1751:{f.Locals[5]=f.Pop();f.Pc=1753;continue;}
case 1753:{f.Push(f.Locals[5]);f.Pc=1755;continue;}
case 1755:{f.Push(JValue.I(1));f.Pc=1756;continue;}
case 1756:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1757;continue;}
case 1757:{f.Push(JValue.R(rt.String("~")));f.Pc=1760;continue;}
case 1760:{f.Push(JValue.R(rt.String("+")));f.Pc=1763;continue;}
case 1763:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",1766);}
case 1766:{f.Locals[6]=f.Pop();f.Pc=1768;continue;}
case 1768:{f.Push(JValue.I(0));f.Pc=1769;continue;}
case 1769:{f.Locals[7]=f.Pop();f.Pc=1771;continue;}
case 1771:{f.Push(f.Locals[2]);f.Pc=1772;continue;}
case 1772:{f.Push(f.Locals[6]);f.Pc=1774;continue;}
case 1774:{f.Push(f.Locals[4]);f.Pc=1776;continue;}
case 1776:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",1779);}
case 1779:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1782);}
case 1782:{f.Locals[8]=f.Pop();f.Pc=1784;continue;}
case 1784:{f.Push(f.Locals[8]);f.Pc=1786;continue;}
case 1786:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1791);}
case 1791:{f.Pc=f.Pop().Int==0?1827:1794;continue;}
case 1794:{f.Push(f.Locals[8]);f.Pc=1796;continue;}
case 1796:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1801);}
case 1801:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1804;continue;}
case 1804:{f.Locals[9]=f.Pop();f.Pc=1806;continue;}
case 1806:{f.Push(f.Locals[0]);f.Pc=1807;continue;}
case 1807:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1810);}
case 1810:{f.Push(f.Locals[9]);f.Pc=1812;continue;}
case 1812:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTargeting","(Lforge/game/GameObject;)Z","invokevirtual",1815);}
case 1815:{f.Pc=f.Pop().Int==0?1824:1818;continue;}
case 1818:{f.Push(JValue.I(1));f.Pc=1819;continue;}
case 1819:{f.Locals[7]=f.Pop();f.Pc=1821;continue;}
case 1821:{f.Pc=1827;continue;}
case 1824:{f.Pc=1784;continue;}
case 1827:{f.Push(f.Locals[7]);f.Pc=1829;continue;}
case 1829:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1830:{f.Push(f.Locals[3]);f.Pc=1831;continue;}
case 1831:{f.Push(JValue.R(rt.String("YouCtrl")));f.Pc=1834;continue;}
case 1834:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1837);}
case 1837:{f.Pc=f.Pop().Int==0?1849:1840;continue;}
case 1840:{f.Push(f.Locals[0]);f.Pc=1841;continue;}
case 1841:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",1844);}
case 1844:{f.Push(f.Locals[1]);f.Pc=1845;continue;}
case 1845:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1848);}
case 1848:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1849:{f.Push(f.Locals[3]);f.Pc=1850;continue;}
case 1850:{f.Push(JValue.R(rt.String("OppCtrl")));f.Pc=1853;continue;}
case 1853:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1856);}
case 1856:{f.Pc=f.Pop().Int==0?1868:1859;continue;}
case 1859:{f.Push(f.Locals[0]);f.Pc=1860;continue;}
case 1860:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",1863);}
case 1863:{f.Push(f.Locals[1]);f.Pc=1864;continue;}
case 1864:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",1867);}
case 1867:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1868:{f.Push(f.Locals[3]);f.Pc=1869;continue;}
case 1869:{f.Push(JValue.R(rt.String("cmc")));f.Pc=1872;continue;}
case 1872:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1875);}
case 1875:{f.Pc=f.Pop().Int==0?1944:1878;continue;}
case 1878:{f.Push(f.Locals[0]);f.Pc=1879;continue;}
case 1879:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1882);}
case 1882:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=1885;continue;}
case 1885:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",1888);}
case 1888:{f.Pc=f.Pop().Int==0?1903:1891;continue;}
case 1891:{f.Push(f.Locals[0]);f.Pc=1892;continue;}
case 1892:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1895);}
case 1895:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",1898);}
case 1898:{f.Locals[5]=f.Pop();f.Pc=1900;continue;}
case 1900:{f.Pc=1915;continue;}
case 1903:{f.Push(f.Locals[0]);f.Pc=1904;continue;}
case 1904:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",1907);}
case 1907:{return rt.Call(f,"forge/game/cost/Cost","getTotalMana","()Lforge/card/mana/ManaCost;","invokevirtual",1910);}
case 1910:{return rt.Call(f,"forge/card/mana/ManaCost","getCMC","()I","invokevirtual",1913);}
case 1913:{f.Locals[5]=f.Pop();f.Pc=1915;continue;}
case 1915:{f.Push(f.Locals[2]);f.Pc=1916;continue;}
case 1916:{f.Push(f.Locals[3]);f.Pc=1917;continue;}
case 1917:{f.Push(JValue.I(5));f.Pc=1918;continue;}
case 1918:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1921);}
case 1921:{f.Push(f.Locals[4]);f.Pc=1923;continue;}
case 1923:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1926);}
case 1926:{f.Locals[6]=f.Pop();f.Pc=1928;continue;}
case 1928:{f.Push(f.Locals[5]);f.Pc=1930;continue;}
case 1930:{f.Push(f.Locals[3]);f.Pc=1931;continue;}
case 1931:{f.Push(f.Locals[6]);f.Pc=1933;continue;}
case 1933:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1936);}
case 1936:{f.Pc=f.Pop().Int!=0?1941:1939;continue;}
case 1939:{f.Push(JValue.I(0));f.Pc=1940;continue;}
case 1940:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1941:{f.Pc=2372;continue;}
case 1944:{f.Push(f.Locals[3]);f.Pc=1945;continue;}
case 1945:{f.Push(JValue.R(rt.String("ManaAbilityCantPaidFor")));f.Pc=1948;continue;}
case 1948:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1951);}
case 1951:{f.Pc=f.Pop().Int==0?2070:1954;continue;}
case 1954:{f.Push(f.Locals[1]);f.Pc=1955;continue;}
case 1955:{return rt.Call(f,"forge/game/player/Player","getPaidForSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",1958);}
case 1958:{f.Locals[5]=f.Pop();f.Pc=1960;continue;}
case 1960:{f.Push(f.Locals[5]);f.Pc=1962;continue;}
case 1962:{f.Pc=f.Pop().Reference!=null?1967:1965;continue;}
case 1965:{f.Push(JValue.I(0));f.Pc=1966;continue;}
case 1966:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1967:{f.Push(f.Locals[5]);f.Pc=1969;continue;}
case 1969:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaCostBeingPaid","()Lforge/game/mana/ManaCostBeingPaid;","invokevirtual",1972);}
case 1972:{f.Locals[6]=f.Pop();f.Pc=1974;continue;}
case 1974:{f.Push(JValue.I(0));f.Pc=1975;continue;}
case 1975:{f.Locals[7]=f.Pop();f.Pc=1977;continue;}
case 1977:{if(!rt.StaticReady(f,"forge/card/mana/ManaAtom","MANATYPES","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaAtom","MANATYPES","[B"));f.Pc=1980;continue;}
case 1980:{f.Locals[8]=f.Pop();f.Pc=1982;continue;}
case 1982:{f.Push(f.Locals[8]);f.Pc=1984;continue;}
case 1984:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1985;continue;}
case 1985:{f.Locals[9]=f.Pop();f.Pc=1987;continue;}
case 1987:{f.Push(JValue.I(0));f.Pc=1988;continue;}
case 1988:{f.Locals[10]=f.Pop();f.Pc=1990;continue;}
case 1990:{f.Push(f.Locals[10]);f.Pc=1992;continue;}
case 1992:{f.Push(f.Locals[9]);f.Pc=1994;continue;}
case 1994:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?2032:1997;continue;}
case 1997:{f.Push(f.Locals[8]);f.Pc=1999;continue;}
case 1999:{f.Push(f.Locals[10]);f.Pc=2001;continue;}
case 2001:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2002;continue;}
case 2002:{f.Locals[11]=f.Pop();f.Pc=2004;continue;}
case 2004:{f.Push(f.Locals[6]);f.Pc=2006;continue;}
case 2006:{f.Push(f.Locals[11]);f.Pc=2008;continue;}
case 2008:{f.Push(f.Locals[1]);f.Pc=2009;continue;}
case 2009:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",2012);}
case 2012:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","isAnyPartPayableWith","(BLforge/game/mana/ManaPool;)Z","invokevirtual",2015);}
case 2015:{f.Pc=f.Pop().Int==0?2026:2018;continue;}
case 2018:{f.Push(f.Locals[7]);f.Pc=2020;continue;}
case 2020:{f.Push(f.Locals[11]);f.Pc=2022;continue;}
case 2022:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=2023;continue;}
case 2023:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=2024;continue;}
case 2024:{f.Locals[7]=f.Pop();f.Pc=2026;continue;}
case 2026:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=2029;continue;}
case 2029:{f.Pc=1990;continue;}
case 2032:{f.Push(f.Locals[6]);f.Pc=2034;continue;}
case 2034:{f.Push(JValue.I(64));f.Pc=2036;continue;}
case 2036:{f.Push(f.Locals[1]);f.Pc=2037;continue;}
case 2037:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",2040);}
case 2040:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","isAnyPartPayableWith","(BLforge/game/mana/ManaPool;)Z","invokevirtual",2043);}
case 2043:{f.Pc=f.Pop().Int==0?2054:2046;continue;}
case 2046:{f.Push(f.Locals[7]);f.Pc=2048;continue;}
case 2048:{f.Push(JValue.I(64));f.Pc=2050;continue;}
case 2050:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=2051;continue;}
case 2051:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=2052;continue;}
case 2052:{f.Locals[7]=f.Pop();f.Pc=2054;continue;}
case 2054:{f.Push(f.Locals[0]);f.Pc=2055;continue;}
case 2055:{f.Push(f.Locals[5]);f.Pc=2057;continue;}
case 2057:{f.Push(f.Locals[7]);f.Pc=2059;continue;}
case 2059:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManaAbilityFor","(Lforge/game/spellability/SpellAbility;B)Z","invokevirtual",2062);}
case 2062:{f.Pc=f.Pop().Int==0?2067:2065;continue;}
case 2065:{f.Push(JValue.I(0));f.Pc=2066;continue;}
case 2066:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2067:{f.Pc=2372;continue;}
case 2070:{f.Push(f.Locals[3]);f.Pc=2071;continue;}
case 2071:{f.Push(JValue.R(rt.String("NamedSpell")));f.Pc=2074;continue;}
case 2074:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2077);}
case 2077:{f.Pc=f.Pop().Int==0?2143:2080;continue;}
case 2080:{f.Push(JValue.I(0));f.Pc=2081;continue;}
case 2081:{f.Locals[5]=f.Pop();f.Pc=2083;continue;}
case 2083:{f.Push(f.Locals[2]);f.Pc=2084;continue;}
case 2084:{return rt.Call(f,"forge/game/card/Card","getNamedCards","()Ljava/util/List;","invokevirtual",2087);}
case 2087:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",2092);}
case 2092:{f.Locals[6]=f.Pop();f.Pc=2094;continue;}
case 2094:{f.Push(f.Locals[6]);f.Pc=2096;continue;}
case 2096:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2101);}
case 2101:{f.Pc=f.Pop().Int==0?2140:2104;continue;}
case 2104:{f.Push(f.Locals[6]);f.Pc=2106;continue;}
case 2106:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2111);}
case 2111:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2114;continue;}
case 2114:{f.Locals[7]=f.Pop();f.Pc=2116;continue;}
case 2116:{f.Push(f.Locals[0]);f.Pc=2117;continue;}
case 2117:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",2120);}
case 2120:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",2123);}
case 2123:{f.Push(f.Locals[7]);f.Pc=2125;continue;}
case 2125:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2128);}
case 2128:{f.Pc=f.Pop().Int==0?2137:2131;continue;}
case 2131:{f.Push(JValue.I(1));f.Pc=2132;continue;}
case 2132:{f.Locals[5]=f.Pop();f.Pc=2134;continue;}
case 2134:{f.Pc=2140;continue;}
case 2137:{f.Pc=2094;continue;}
case 2140:{f.Push(f.Locals[5]);f.Pc=2142;continue;}
case 2142:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2143:{f.Push(f.Locals[3]);f.Pc=2144;continue;}
case 2144:{f.Push(JValue.R(rt.String("otherAbility")));f.Pc=2147;continue;}
case 2147:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2150);}
case 2150:{f.Pc=f.Pop().Int==0?2199:2153;continue;}
case 2153:{f.Push(f.Locals[0]);f.Pc=2154;continue;}
case 2154:{f.Push(f.Locals[4]);f.Pc=2156;continue;}
case 2156:{return rt.Call(f,"forge/game/spellability/SpellAbility","equals","(Ljava/lang/Object;)Z","invokevirtual",2159);}
case 2159:{f.Pc=f.Pop().Int==0?2164:2162;continue;}
case 2162:{f.Push(JValue.I(0));f.Pc=2163;continue;}
case 2163:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2164:{f.Push(f.Locals[4]);f.Pc=2166;continue;}
case 2166:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=2169;continue;}
case 2169:{f.Pc=f.Pop().Int==0?2372:2172;continue;}
case 2172:{f.Push(f.Locals[4]);f.Pc=2174;continue;}
case 2174:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2177;continue;}
case 2177:{f.Locals[5]=f.Pop();f.Pc=2179;continue;}
case 2179:{f.Push(f.Locals[0]);f.Pc=2180;continue;}
case 2180:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",2183);}
case 2183:{f.Push(f.Locals[5]);f.Pc=2185;continue;}
case 2185:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",2188);}
case 2188:{return rt.Call(f,"forge/game/spellability/SpellAbility","equals","(Ljava/lang/Object;)Z","invokevirtual",2191);}
case 2191:{f.Pc=f.Pop().Int==0?2196:2194;continue;}
case 2194:{f.Push(JValue.I(0));f.Pc=2195;continue;}
case 2195:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2196:{f.Pc=2372;continue;}
case 2199:{f.Push(f.Locals[3]);f.Pc=2200;continue;}
case 2200:{f.Push(JValue.R(rt.String("CouldCastTiming")));f.Pc=2203;continue;}
case 2203:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2206);}
case 2206:{f.Pc=f.Pop().Int==0?2328:2209;continue;}
case 2209:{f.Push(f.Locals[0]);f.Pc=2210;continue;}
case 2210:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",2213);}
case 2213:{f.Locals[5]=f.Pop();f.Pc=2215;continue;}
case 2215:{f.Push(f.Locals[5]);f.Pc=2217;continue;}
case 2217:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",2220);}
case 2220:{f.Locals[6]=f.Pop();f.Pc=2222;continue;}
case 2222:{f.Push(f.Locals[6]);f.Pc=2224;continue;}
case 2224:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",2227);}
case 2227:{return rt.Call(f,"forge/game/zone/MagicStack","isSplitSecondOnStack","()Z","invokevirtual",2230);}
case 2230:{f.Pc=f.Pop().Int==0?2235:2233;continue;}
case 2233:{f.Push(JValue.I(0));f.Pc=2234;continue;}
case 2234:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2235:{f.Push(f.Locals[1]);f.Pc=2236;continue;}
case 2236:{return rt.Call(f,"forge/game/player/Player","canCastSorcery","()Z","invokevirtual",2239);}
case 2239:{f.Pc=f.Pop().Int!=0?2252:2242;continue;}
case 2242:{f.Push(f.Locals[0]);f.Pc=2243;continue;}
case 2243:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",2246);}
case 2246:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isInstantSpeed","()Z","invokevirtual",2249);}
case 2249:{f.Pc=f.Pop().Int==0?2254:2252;continue;}
case 2252:{f.Push(JValue.I(1));f.Pc=2253;continue;}
case 2253:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2254:{f.Push(f.Locals[0]);f.Pc=2255;continue;}
case 2255:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",2258);}
case 2258:{f.Pc=f.Pop().Int==0?2296:2261;continue;}
case 2261:{f.Push(f.Locals[5]);f.Pc=2263;continue;}
case 2263:{return rt.Call(f,"forge/game/card/Card","isInstant","()Z","invokevirtual",2266);}
case 2266:{f.Pc=f.Pop().Int!=0?2290:2269;continue;}
case 2269:{f.Push(f.Locals[5]);f.Pc=2271;continue;}
case 2271:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","FLASH","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","FLASH","Lforge/game/keyword/Keyword;"));f.Pc=2274;continue;}
case 2274:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",2277);}
case 2277:{f.Pc=f.Pop().Int!=0?2290:2280;continue;}
case 2280:{f.Push(f.Locals[0]);f.Pc=2281;continue;}
case 2281:{f.Push(f.Locals[5]);f.Pc=2283;continue;}
case 2283:{f.Push(f.Locals[1]);f.Pc=2284;continue;}
case 2284:{return rt.Call(f,"forge/game/staticability/StaticAbilityCastWithFlash","anyWithFlash","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokestatic",2287);}
case 2287:{f.Pc=f.Pop().Int==0?2294:2290;continue;}
case 2290:{f.Push(JValue.I(1));f.Pc=2291;continue;}
case 2291:{f.Pc=2295;continue;}
case 2294:{f.Push(JValue.I(0));f.Pc=2295;continue;}
case 2295:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2296:{f.Push(f.Locals[0]);f.Pc=2297;continue;}
case 2297:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",2300);}
case 2300:{f.Pc=f.Pop().Int==0?2326:2303;continue;}
case 2303:{f.Push(f.Locals[0]);f.Pc=2304;continue;}
case 2304:{return rt.Call(f,"forge/game/spellability/SpellAbility","isPwAbility","()Z","invokevirtual",2307);}
case 2307:{f.Pc=f.Pop().Int!=0?2324:2310;continue;}
case 2310:{f.Push(f.Locals[0]);f.Pc=2311;continue;}
case 2311:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",2314);}
case 2314:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isSorcerySpeed","()Z","invokevirtual",2317);}
case 2317:{f.Pc=f.Pop().Int!=0?2324:2320;continue;}
case 2320:{f.Push(JValue.I(1));f.Pc=2321;continue;}
case 2321:{f.Pc=2325;continue;}
case 2324:{f.Push(JValue.I(0));f.Pc=2325;continue;}
case 2325:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2326:{f.Push(JValue.I(1));f.Pc=2327;continue;}
case 2327:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2328:{f.Push(f.Locals[3]);f.Pc=2329;continue;}
case 2329:{f.Push(JValue.R(rt.String("NamedAbility")));f.Pc=2332;continue;}
case 2332:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2335);}
case 2335:{f.Pc=f.Pop().Int==0?2352:2338;continue;}
case 2338:{f.Push(f.Locals[0]);f.Pc=2339;continue;}
case 2339:{return rt.Call(f,"forge/game/spellability/SpellAbility","getName","()Ljava/lang/String;","invokevirtual",2342);}
case 2342:{f.Push(f.Locals[3]);f.Pc=2343;continue;}
case 2343:{f.Push(JValue.I(12));f.Pc=2345;continue;}
case 2345:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",2348);}
case 2348:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2351);}
case 2351:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2352:{f.Push(f.Locals[0]);f.Pc=2353;continue;}
case 2353:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",2356);}
case 2356:{f.Pc=f.Pop().Reference==null?2372:2359;continue;}
case 2359:{f.Push(f.Locals[0]);f.Pc=2360;continue;}
case 2360:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",2363);}
case 2363:{f.Push(f.Locals[3]);f.Pc=2364;continue;}
case 2364:{f.Push(f.Locals[1]);f.Pc=2365;continue;}
case 2365:{f.Push(f.Locals[2]);f.Pc=2366;continue;}
case 2366:{f.Push(f.Locals[4]);f.Pc=2368;continue;}
case 2368:{return rt.Call(f,"forge/game/card/Card","hasProperty","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",2371);}
case 2371:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 2372:{f.Push(JValue.I(1));f.Pc=2373;continue;}
case 2373:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9528(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/mana/Mana","getPlayer","()Lforge/game/player/Player;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

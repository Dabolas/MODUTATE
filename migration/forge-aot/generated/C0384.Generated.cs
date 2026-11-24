// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C384{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RevealEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3660,"forge/game/ability/effects/RevealEffect","<init>","()V",1,1,1,new JHandler[]{},M3660));
c.Add(new JMethod(3661,"forge/game/ability/effects/RevealEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,13,6,new JHandler[]{},M3661));
c.Add(new JMethod(3662,"forge/game/ability/effects/RevealEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,3,new JHandler[]{},M3662));
}

internal static JStep M3660(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3661(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("AnyNumber")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Optional")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?49:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",46);}
case 46:{f.Pc=50;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{f.Locals[6]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/ability/effects/RevealEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",56);}
case 56:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",59);}
case 59:{f.Locals[7]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[7]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int==0?484:71;continue;}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",78);}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{f.Locals[8]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[8]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int!=0?94:91;continue;}
case 91:{f.Pc=61;continue;}
case 94:{f.Push(f.Locals[8]);f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",102);}
case 102:{f.Locals[9]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[9]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",111);}
case 111:{f.Pc=f.Pop().Int==0?117:114;continue;}
case 114:{f.Pc=61;continue;}
case 117:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=120;continue;}
case 120:{f.StackOp("dup");f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",124);}
case 124:{f.Locals[10]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("Random")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",132);}
case 132:{f.Pc=f.Pop().Int==0?211:135;continue;}
case 135:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=138;continue;}
case 138:{f.StackOp("dup");f.Pc=139;continue;}
case 139:{f.Push(f.Locals[9]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",144);}
case 144:{f.Locals[11]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String("RevealValid")));f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",152);}
case 152:{f.Pc=f.Pop().Int==0?172:155;continue;}
case 155:{f.Push(f.Locals[11]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("RevealValid")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",163);}
case 163:{f.Push(f.Locals[8]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[2]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[1]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",170);}
case 170:{f.Locals[11]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[11]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int==0?183:180;continue;}
case 180:{f.Pc=61;continue;}
case 183:{f.Push(f.Locals[11]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",188);}
case 188:{f.Push(f.Locals[6]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",193);}
case 193:{f.Locals[12]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[10]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[11]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[12]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",204);}
case 204:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",207);}
case 207:{f.StackOp("pop");f.Pc=208;continue;}
case 208:{f.Pc=388;continue;}
case 211:{f.Push(f.Locals[1]);f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.String("RevealDefined")));f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",217);}
case 217:{f.Pc=f.Pop().Int==0?240:220;continue;}
case 220:{f.Push(f.Locals[10]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[2]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[1]);f.Pc=224;continue;}
case 224:{f.Push(JValue.R(rt.String("RevealDefined")));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",229);}
case 229:{f.Push(f.Locals[1]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",233);}
case 233:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",236);}
case 236:{f.StackOp("pop");f.Pc=237;continue;}
case 237:{f.Pc=388;continue;}
case 240:{f.Push(f.Locals[1]);f.Pc=241;continue;}
case 241:{f.Push(JValue.R(rt.String("RevealAllValid")));f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",246);}
case 246:{f.Pc=f.Pop().Int==0?273:249;continue;}
case 249:{f.Push(f.Locals[10]);f.Pc=251;continue;}
case 251:{f.Push(f.Locals[9]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[1]);f.Pc=254;continue;}
case 254:{f.Push(JValue.R(rt.String("RevealAllValid")));f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",259);}
case 259:{f.Push(f.Locals[8]);f.Pc=261;continue;}
case 261:{f.Push(f.Locals[2]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[1]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",266);}
case 266:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",269);}
case 269:{f.StackOp("pop");f.Pc=270;continue;}
case 270:{f.Pc=388;continue;}
case 273:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=276;continue;}
case 276:{f.StackOp("dup");f.Pc=277;continue;}
case 277:{f.Push(f.Locals[9]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",282);}
case 282:{f.Locals[11]=f.Pop();f.Pc=284;continue;}
case 284:{f.Push(f.Locals[1]);f.Pc=285;continue;}
case 285:{f.Push(JValue.R(rt.String("RevealValid")));f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",290);}
case 290:{f.Pc=f.Pop().Int==0?310:293;continue;}
case 293:{f.Push(f.Locals[11]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[1]);f.Pc=296;continue;}
case 296:{f.Push(JValue.R(rt.String("RevealValid")));f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",301);}
case 301:{f.Push(f.Locals[8]);f.Pc=303;continue;}
case 303:{f.Push(f.Locals[2]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",308);}
case 308:{f.Locals[11]=f.Pop();f.Pc=310;continue;}
case 310:{f.Push(f.Locals[11]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",315);}
case 315:{f.Pc=f.Pop().Int==0?321:318;continue;}
case 318:{f.Pc=61;continue;}
case 321:{f.Push(f.Locals[6]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[11]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",328);}
case 328:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?338:331;continue;}
case 331:{f.Push(f.Locals[11]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",336);}
case 336:{f.Locals[6]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[6]);f.Pc=340;continue;}
case 340:{f.Locals[12]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[4]);f.Pc=344;continue;}
case 344:{f.Pc=f.Pop().Int==0?360:347;continue;}
case 347:{f.Push(f.Locals[11]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",352);}
case 352:{f.Locals[6]=f.Pop();f.Pc=354;continue;}
case 354:{f.Push(JValue.I(0));f.Pc=355;continue;}
case 355:{f.Locals[12]=f.Pop();f.Pc=357;continue;}
case 357:{f.Pc=368;continue;}
case 360:{f.Push(f.Locals[5]);f.Pc=362;continue;}
case 362:{f.Pc=f.Pop().Int==0?368:365;continue;}
case 365:{f.Push(JValue.I(0));f.Pc=366;continue;}
case 366:{f.Locals[12]=f.Pop();f.Pc=368;continue;}
case 368:{f.Push(f.Locals[10]);f.Pc=370;continue;}
case 370:{f.Push(f.Locals[8]);f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",375);}
case 375:{f.Push(f.Locals[12]);f.Pc=377;continue;}
case 377:{f.Push(f.Locals[6]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[11]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsToRevealFromHand","(IILforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;","invokevirtual",384);}
case 384:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",387);}
case 387:{f.StackOp("pop");f.Pc=388;continue;}
case 388:{f.Push(f.Locals[1]);f.Pc=389;continue;}
case 389:{f.Push(JValue.R(rt.String("RevealToAll")));f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",394);}
case 394:{f.Pc=f.Pop().Int!=0?406:397;continue;}
case 397:{f.Push(f.Locals[1]);f.Pc=398;continue;}
case 398:{f.Push(JValue.R(rt.String("Random")));f.Pc=400;continue;}
case 400:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",403);}
case 403:{f.Pc=f.Pop().Int==0?455:406;continue;}
case 406:{f.Push(f.Locals[1]);f.Pc=407;continue;}
case 407:{f.Push(JValue.R(rt.String("RevealTitle")));f.Pc=409;continue;}
case 409:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",412);}
case 412:{f.Locals[11]=f.Pop();f.Pc=414;continue;}
case 414:{f.Push(f.Locals[3]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",418);}
case 418:{f.Push(f.Locals[10]);f.Pc=420;continue;}
case 420:{f.Push(f.Locals[8]);f.Pc=422;continue;}
case 422:{f.Push(JValue.I(0));f.Pc=423;continue;}
case 423:{f.Push(f.Locals[11]);f.Pc=425;continue;}
case 425:{f.Pc=f.Pop().Int==0?437:428;continue;}
case 428:{f.Push(f.Locals[1]);f.Pc=429;continue;}
case 429:{f.Push(JValue.R(rt.String("RevealTitle")));f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",434);}
case 434:{f.Pc=439;continue;}
case 437:{f.Push(JValue.R(rt.String("")));f.Pc=439;continue;}
case 439:{f.Push(f.Locals[11]);f.Pc=441;continue;}
case 441:{f.Pc=f.Pop().Int!=0?448:444;continue;}
case 444:{f.Push(JValue.I(1));f.Pc=445;continue;}
case 445:{f.Pc=449;continue;}
case 448:{f.Push(JValue.I(0));f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;Z)V","invokevirtual",452);}
case 452:{f.Pc=466;continue;}
case 455:{f.Push(f.Locals[3]);f.Pc=456;continue;}
case 456:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",459);}
case 459:{f.Push(f.Locals[10]);f.Pc=461;continue;}
case 461:{f.Push(f.Locals[8]);f.Pc=463;continue;}
case 463:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;)V","invokevirtual",466);}
case 466:{f.Push(f.Locals[1]);f.Pc=467;continue;}
case 467:{f.Push(JValue.R(rt.String("RememberRevealed")));f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",472);}
case 472:{f.Pc=f.Pop().Int==0?481:475;continue;}
case 475:{f.Push(f.Locals[2]);f.Pc=476;continue;}
case 476:{f.Push(f.Locals[10]);f.Pc=478;continue;}
case 478:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",481);}
case 481:{f.Pc=61;continue;}
case 484:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3662(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/RevealEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int<=0?200:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",27);}
case 27:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",30);}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",36);}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?45:40;continue;}
case 40:{f.Push(JValue.R(rt.String(" reveal ")));f.Pc=42;continue;}
case 42:{f.Pc=47;continue;}
case 45:{f.Push(JValue.R(rt.String(" reveals ")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("AnyNumber")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?70:60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("any number of cards ")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Pc=159;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int==0?152:79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Reference==null?99:86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",90);}
case 90:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",96);}
case 96:{f.Pc=124;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",105);}
case 105:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",108);}
case 108:{f.Pc=f.Pop().Int==0?123:111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",117);}
case 117:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",120);}
case 120:{f.Pc=124;continue;}
case 123:{f.Push(JValue.I(0));f.Pc=124;continue;}
case 124:{f.Locals[4]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[4]);f.Pc=129;continue;}
case 129:{f.Push(JValue.I(1));f.Pc=130;continue;}
case 130:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?143:133;continue;}
case 133:{f.Push(f.Locals[4]);f.Pc=135;continue;}
case 135:{return rt.DynamicCall(f,"forge/game/ability/effects/RevealEffect:3662:135:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",140);}
case 140:{f.Pc=145;continue;}
case 143:{f.Push(JValue.R(rt.String("a card ")));f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",148);}
case 148:{f.StackOp("pop");f.Pc=149;continue;}
case 149:{f.Pc=159;continue;}
case 152:{f.Push(f.Locals[2]);f.Pc=153;continue;}
case 153:{f.Push(JValue.R(rt.String("a card ")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",158);}
case 158:{f.StackOp("pop");f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("Random")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",165);}
case 165:{f.Pc=f.Pop().Int==0?175:168;continue;}
case 168:{f.Push(f.Locals[2]);f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String("at random ")));f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",174);}
case 174:{f.StackOp("pop");f.Pc=175;continue;}
case 175:{f.Push(f.Locals[2]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[3]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",182);}
case 182:{f.Push(JValue.I(1));f.Pc=183;continue;}
case 183:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?191:186;continue;}
case 186:{f.Push(JValue.R(rt.String("from their hands.")));f.Pc=188;continue;}
case 188:{f.Pc=193;continue;}
case 191:{f.Push(JValue.R(rt.String("from their hand.")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",196);}
case 196:{f.StackOp("pop");f.Pc=197;continue;}
case 197:{f.Pc=207;continue;}
case 200:{f.Push(f.Locals[2]);f.Pc=201;continue;}
case 201:{f.Push(JValue.R(rt.String("Error - no target players for RevealHand. ")));f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",206);}
case 206:{f.StackOp("pop");f.Pc=207;continue;}
case 207:{f.Push(f.Locals[2]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",211);}
case 211:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

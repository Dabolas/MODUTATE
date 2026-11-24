// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C201{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AnimateEffect","forge/game/ability/effects/AnimateEffectBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3022,"forge/game/ability/effects/AnimateEffect","<init>","()V",1,1,1,new JHandler[]{},M3022));
c.Add(new JMethod(3023,"forge/game/ability/effects/AnimateEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,28,17,new JHandler[]{},M3023));
c.Add(new JMethod(3024,"forge/game/ability/effects/AnimateEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,16,5,new JHandler[]{},M3024));
}

internal static JStep M3022(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/AnimateEffectBase","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3023(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Duration")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/effects/AnimateEffect","checkValidDuration","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokestatic",23);}
case 23:{f.Pc=f.Pop().Int!=0?27:26;continue;}
case 26:{return JStep.ReturnVoid;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?44:36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("ImprintCards")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?61:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("ImprintCards")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",59);}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(JValue.R(null));f.Pc=62;continue;}
case 62:{f.Locals[6]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("Power")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int==0?89:73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("Power")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",80);}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",84);}
case 84:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",87);}
case 87:{f.Locals[6]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(JValue.R(null));f.Pc=90;continue;}
case 90:{f.Locals[7]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("Toughness")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?117:101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("Toughness")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",108);}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",112);}
case 112:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",115);}
case 115:{f.Locals[7]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",121);}
case 121:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",124);}
case 124:{f.Locals[8]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[8]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",131);}
case 131:{f.Locals[9]=f.Pop();f.Pc=133;continue;}
case 133:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=136;continue;}
case 136:{f.StackOp("dup");f.Pc=137;continue;}
case 137:{f.Push(JValue.I(1));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/card/CardType","<init>","(Z)V","invokespecial",141);}
case 141:{f.Locals[11]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("Types")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",149);}
case 149:{f.Pc=f.Pop().Int==0?172:152;continue;}
case 152:{f.Push(f.Locals[11]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("Types")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",160);}
case 160:{f.Push(JValue.R(rt.String(",")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",165);}
case 165:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",168);}
case 168:{return rt.Call(f,"forge/card/CardType","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",171);}
case 171:{f.StackOp("pop");f.Pc=172;continue;}
case 172:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=175;continue;}
case 175:{f.StackOp("dup");f.Pc=176;continue;}
case 176:{f.Push(JValue.I(1));f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/card/CardType","<init>","(Z)V","invokespecial",180);}
case 180:{f.Locals[12]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Push(JValue.R(rt.String("RemoveTypes")));f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",188);}
case 188:{f.Pc=f.Pop().Int==0?211:191;continue;}
case 191:{f.Push(f.Locals[12]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[1]);f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("RemoveTypes")));f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",199);}
case 199:{f.Push(JValue.R(rt.String(",")));f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",204);}
case 204:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",207);}
case 207:{return rt.Call(f,"forge/card/CardType","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",210);}
case 210:{f.StackOp("pop");f.Pc=211;continue;}
case 211:{f.Push(f.Locals[11]);f.Pc=213;continue;}
case 213:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",218);}
case 218:{f.Pc=f.Pop().Int==0?239:221;continue;}
case 221:{f.Push(f.Locals[11]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/card/CardType","clear","()V","invokevirtual",226);}
case 226:{f.Push(f.Locals[11]);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[2]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",232);}
case 232:{return rt.Call(f,"forge/card/CardType","add","(Ljava/lang/String;)Z","invokevirtual",235);}
case 235:{f.StackOp("pop");f.Pc=236;continue;}
case 236:{f.Pc=264;continue;}
case 239:{f.Push(f.Locals[11]);f.Pc=241;continue;}
case 241:{f.Push(JValue.R(rt.String("ChosenType2")));f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",246);}
case 246:{f.Pc=f.Pop().Int==0?264:249;continue;}
case 249:{f.Push(f.Locals[11]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/card/CardType","clear","()V","invokevirtual",254);}
case 254:{f.Push(f.Locals[11]);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[2]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/card/Card","getChosenType2","()Ljava/lang/String;","invokevirtual",260);}
case 260:{return rt.Call(f,"forge/card/CardType","add","(Ljava/lang/String;)Z","invokevirtual",263);}
case 263:{f.StackOp("pop");f.Pc=264;continue;}
case 264:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",267);}
case 267:{f.Locals[13]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("Keywords")));f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",275);}
case 275:{f.Pc=f.Pop().Int==0?300:278;continue;}
case 278:{f.Push(f.Locals[13]);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[1]);f.Pc=281;continue;}
case 281:{f.Push(JValue.R(rt.String("Keywords")));f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",286);}
case 286:{f.Push(JValue.R(rt.String(" & ")));f.Pc=288;continue;}
case 288:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",291);}
case 291:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",294);}
case 294:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",299);}
case 299:{f.StackOp("pop");f.Pc=300;continue;}
case 300:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",303);}
case 303:{f.Locals[14]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[1]);f.Pc=306;continue;}
case 306:{f.Push(JValue.R(rt.String("RemoveKeywords")));f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",311);}
case 311:{f.Pc=f.Pop().Int==0?336:314;continue;}
case 314:{f.Push(f.Locals[14]);f.Pc=316;continue;}
case 316:{f.Push(f.Locals[1]);f.Pc=317;continue;}
case 317:{f.Push(JValue.R(rt.String("RemoveKeywords")));f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",322);}
case 322:{f.Push(JValue.R(rt.String(" & ")));f.Pc=324;continue;}
case 324:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",327);}
case 327:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",330);}
case 330:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",335);}
case 335:{f.StackOp("pop");f.Pc=336;continue;}
case 336:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",339);}
case 339:{f.Locals[15]=f.Pop();f.Pc=341;continue;}
case 341:{f.Push(f.Locals[1]);f.Pc=342;continue;}
case 342:{f.Push(JValue.R(rt.String("HiddenKeywords")));f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",347);}
case 347:{f.Pc=f.Pop().Int==0?372:350;continue;}
case 350:{f.Push(f.Locals[15]);f.Pc=352;continue;}
case 352:{f.Push(f.Locals[1]);f.Pc=353;continue;}
case 353:{f.Push(JValue.R(rt.String("HiddenKeywords")));f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",358);}
case 358:{f.Push(JValue.R(rt.String(" & ")));f.Pc=360;continue;}
case 360:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",363);}
case 363:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",366);}
case 366:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",371);}
case 371:{f.StackOp("pop");f.Pc=372;continue;}
case 372:{f.Push(JValue.I(0));f.Pc=373;continue;}
case 373:{f.Locals[16]=f.Pop();f.Pc=375;continue;}
case 375:{f.Push(f.Locals[16]);f.Pc=377;continue;}
case 377:{f.Push(f.Locals[13]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",384);}
case 384:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?440:387;continue;}
case 387:{f.Push(f.Locals[13]);f.Pc=389;continue;}
case 389:{f.Push(f.Locals[16]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",396);}
case 396:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=399;continue;}
case 399:{f.Locals[17]=f.Pop();f.Pc=401;continue;}
case 401:{f.Push(f.Locals[2]);f.Pc=402;continue;}
case 402:{f.Push(f.Locals[17]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/card/Card","hasSVar","(Ljava/lang/String;)Z","invokevirtual",407);}
case 407:{f.Pc=f.Pop().Int==0?434:410;continue;}
case 410:{f.Push(f.Locals[13]);f.Pc=412;continue;}
case 412:{f.Push(f.Locals[2]);f.Pc=413;continue;}
case 413:{f.Push(f.Locals[17]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",418);}
case 418:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",423);}
case 423:{f.StackOp("pop");f.Pc=424;continue;}
case 424:{f.Push(f.Locals[13]);f.Pc=426;continue;}
case 426:{f.Push(f.Locals[17]);f.Pc=428;continue;}
case 428:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",433);}
case 433:{f.StackOp("pop");f.Pc=434;continue;}
case 434:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=437;continue;}
case 437:{f.Pc=375;continue;}
case 440:{f.Push(JValue.R(null));f.Pc=441;continue;}
case 441:{f.Locals[16]=f.Pop();f.Pc=443;continue;}
case 443:{f.Push(f.Locals[1]);f.Pc=444;continue;}
case 444:{f.Push(JValue.R(rt.String("Colors")));f.Pc=446;continue;}
case 446:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",449);}
case 449:{f.Pc=f.Pop().Int==0?512:452;continue;}
case 452:{f.Push(f.Locals[1]);f.Pc=453;continue;}
case 453:{f.Push(JValue.R(rt.String("Colors")));f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",458);}
case 458:{f.Locals[17]=f.Pop();f.Pc=460;continue;}
case 460:{f.Push(f.Locals[17]);f.Pc=462;continue;}
case 462:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=464;continue;}
case 464:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",467);}
case 467:{f.Pc=f.Pop().Int==0?482:470;continue;}
case 470:{f.Push(f.Locals[2]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"forge/game/card/Card","getChosenColors","()Ljava/lang/Iterable;","invokevirtual",474);}
case 474:{return rt.Call(f,"forge/card/ColorSet","fromNames","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",477);}
case 477:{f.Locals[16]=f.Pop();f.Pc=479;continue;}
case 479:{f.Pc=512;continue;}
case 482:{f.Push(f.Locals[17]);f.Pc=484;continue;}
case 484:{f.Push(JValue.R(rt.String("All")));f.Pc=486;continue;}
case 486:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",489);}
case 489:{f.Pc=f.Pop().Int==0?500:492;continue;}
case 492:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"));f.Pc=495;continue;}
case 495:{f.Locals[16]=f.Pop();f.Pc=497;continue;}
case 497:{f.Pc=512;continue;}
case 500:{f.Push(f.Locals[17]);f.Pc=502;continue;}
case 502:{f.Push(JValue.R(rt.String(",")));f.Pc=504;continue;}
case 504:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",507);}
case 507:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",510);}
case 510:{f.Locals[16]=f.Pop();f.Pc=512;continue;}
case 512:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",515);}
case 515:{f.Locals[17]=f.Pop();f.Pc=517;continue;}
case 517:{f.Push(f.Locals[1]);f.Pc=518;continue;}
case 518:{f.Push(JValue.R(rt.String("Abilities")));f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",523);}
case 523:{f.Pc=f.Pop().Int==0?548:526;continue;}
case 526:{f.Push(f.Locals[17]);f.Pc=528;continue;}
case 528:{f.Push(f.Locals[1]);f.Pc=529;continue;}
case 529:{f.Push(JValue.R(rt.String("Abilities")));f.Pc=531;continue;}
case 531:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",534);}
case 534:{f.Push(JValue.R(rt.String(",")));f.Pc=536;continue;}
case 536:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",539);}
case 539:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",542);}
case 542:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",547);}
case 547:{f.StackOp("pop");f.Pc=548;continue;}
case 548:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",551);}
case 551:{f.Locals[18]=f.Pop();f.Pc=553;continue;}
case 553:{f.Push(f.Locals[1]);f.Pc=554;continue;}
case 554:{f.Push(JValue.R(rt.String("Replacements")));f.Pc=556;continue;}
case 556:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",559);}
case 559:{f.Pc=f.Pop().Int==0?584:562;continue;}
case 562:{f.Push(f.Locals[18]);f.Pc=564;continue;}
case 564:{f.Push(f.Locals[1]);f.Pc=565;continue;}
case 565:{f.Push(JValue.R(rt.String("Replacements")));f.Pc=567;continue;}
case 567:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",570);}
case 570:{f.Push(JValue.R(rt.String(",")));f.Pc=572;continue;}
case 572:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",575);}
case 575:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",578);}
case 578:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",583);}
case 583:{f.StackOp("pop");f.Pc=584;continue;}
case 584:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",587);}
case 587:{f.Locals[19]=f.Pop();f.Pc=589;continue;}
case 589:{f.Push(f.Locals[1]);f.Pc=590;continue;}
case 590:{f.Push(JValue.R(rt.String("Triggers")));f.Pc=592;continue;}
case 592:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",595);}
case 595:{f.Pc=f.Pop().Int==0?620:598;continue;}
case 598:{f.Push(f.Locals[19]);f.Pc=600;continue;}
case 600:{f.Push(f.Locals[1]);f.Pc=601;continue;}
case 601:{f.Push(JValue.R(rt.String("Triggers")));f.Pc=603;continue;}
case 603:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",606);}
case 606:{f.Push(JValue.R(rt.String(",")));f.Pc=608;continue;}
case 608:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",611);}
case 611:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",614);}
case 614:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",619);}
case 619:{f.StackOp("pop");f.Pc=620;continue;}
case 620:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",623);}
case 623:{f.Locals[20]=f.Pop();f.Pc=625;continue;}
case 625:{f.Push(f.Locals[1]);f.Pc=626;continue;}
case 626:{f.Push(JValue.R(rt.String("staticAbilities")));f.Pc=628;continue;}
case 628:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",631);}
case 631:{f.Pc=f.Pop().Int==0?656:634;continue;}
case 634:{f.Push(f.Locals[20]);f.Pc=636;continue;}
case 636:{f.Push(f.Locals[1]);f.Pc=637;continue;}
case 637:{f.Push(JValue.R(rt.String("staticAbilities")));f.Pc=639;continue;}
case 639:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",642);}
case 642:{f.Push(JValue.R(rt.String(",")));f.Pc=644;continue;}
case 644:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",647);}
case 647:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",650);}
case 650:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",655);}
case 655:{f.StackOp("pop");f.Pc=656;continue;}
case 656:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",659);}
case 659:{f.Locals[21]=f.Pop();f.Pc=661;continue;}
case 661:{f.Push(f.Locals[1]);f.Pc=662;continue;}
case 662:{f.Push(JValue.R(rt.String("sVars")));f.Pc=664;continue;}
case 664:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",667);}
case 667:{f.Pc=f.Pop().Int==0?778:670;continue;}
case 670:{f.Push(f.Locals[1]);f.Pc=671;continue;}
case 671:{f.Push(JValue.R(rt.String("sVars")));f.Pc=673;continue;}
case 673:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",676);}
case 676:{f.Push(JValue.R(rt.String(",")));f.Pc=678;continue;}
case 678:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",681);}
case 681:{f.Locals[22]=f.Pop();f.Pc=683;continue;}
case 683:{f.Push(f.Locals[22]);f.Pc=685;continue;}
case 685:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=686;continue;}
case 686:{f.Locals[23]=f.Pop();f.Pc=688;continue;}
case 688:{f.Push(JValue.I(0));f.Pc=689;continue;}
case 689:{f.Locals[24]=f.Pop();f.Pc=691;continue;}
case 691:{f.Push(f.Locals[24]);f.Pc=693;continue;}
case 693:{f.Push(f.Locals[23]);f.Pc=695;continue;}
case 695:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?778:698;continue;}
case 698:{f.Push(f.Locals[22]);f.Pc=700;continue;}
case 700:{f.Push(f.Locals[24]);f.Pc=702;continue;}
case 702:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=703;continue;}
case 703:{f.Locals[25]=f.Pop();f.Pc=705;continue;}
case 705:{f.Push(f.Locals[1]);f.Pc=706;continue;}
case 706:{f.Push(f.Locals[25]);f.Pc=708;continue;}
case 708:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",711);}
case 711:{f.Locals[26]=f.Pop();f.Pc=713;continue;}
case 713:{f.Push(f.Locals[25]);f.Pc=715;continue;}
case 715:{f.Locals[27]=f.Pop();f.Pc=717;continue;}
case 717:{f.Push(f.Locals[26]);f.Pc=719;continue;}
case 719:{f.Push(JValue.R(rt.String("SVar:")));f.Pc=721;continue;}
case 721:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",724);}
case 724:{f.Pc=f.Pop().Int==0?760:727;continue;}
case 727:{f.Push(f.Locals[26]);f.Pc=729;continue;}
case 729:{f.Push(JValue.R(rt.String("SVar:")));f.Pc=731;continue;}
case 731:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",734);}
case 734:{f.Push(JValue.I(1));f.Pc=735;continue;}
case 735:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=736;continue;}
case 736:{f.Locals[26]=f.Pop();f.Pc=738;continue;}
case 738:{f.Push(f.Locals[26]);f.Pc=740;continue;}
case 740:{f.Push(JValue.R(rt.String(":")));f.Pc=742;continue;}
case 742:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",745);}
case 745:{f.Push(JValue.I(0));f.Pc=746;continue;}
case 746:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=747;continue;}
case 747:{f.Locals[27]=f.Pop();f.Pc=749;continue;}
case 749:{f.Push(f.Locals[26]);f.Pc=751;continue;}
case 751:{f.Push(JValue.R(rt.String(":")));f.Pc=753;continue;}
case 753:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",756);}
case 756:{f.Push(JValue.I(1));f.Pc=757;continue;}
case 757:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=758;continue;}
case 758:{f.Locals[26]=f.Pop();f.Pc=760;continue;}
case 760:{f.Push(f.Locals[21]);f.Pc=762;continue;}
case 762:{f.Push(f.Locals[27]);f.Pc=764;continue;}
case 764:{f.Push(f.Locals[26]);f.Pc=766;continue;}
case 766:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",771);}
case 771:{f.StackOp("pop");f.Pc=772;continue;}
case 772:{f.Locals[24]=JValue.I(unchecked(f.Locals[24].Int+(1)));f.Pc=775;continue;}
case 775:{f.Pc=691;continue;}
case 778:{f.Push(f.Locals[1]);f.Pc=779;continue;}
case 779:{return rt.Call(f,"forge/game/ability/effects/AnimateEffect","getCardsfromTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",782);}
case 782:{f.Locals[22]=f.Pop();f.Pc=784;continue;}
case 784:{f.Push(f.Locals[1]);f.Pc=785;continue;}
case 785:{f.Push(JValue.R(rt.String("Optional")));f.Pc=787;continue;}
case 787:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",790);}
case 790:{f.Pc=f.Pop().Int==0?881:793;continue;}
case 793:{f.Push(f.Locals[22]);f.Pc=795;continue;}
case 795:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",798);}
case 798:{f.Locals[23]=f.Pop();f.Pc=800;continue;}
case 800:{f.Push(f.Locals[1]);f.Pc=801;continue;}
case 801:{f.Push(JValue.R(rt.String("OptionQuestion")));f.Pc=803;continue;}
case 803:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",806);}
case 806:{f.Pc=f.Pop().Int==0?825:809;continue;}
case 809:{f.Push(f.Locals[1]);f.Pc=810;continue;}
case 810:{f.Push(JValue.R(rt.String("OptionQuestion")));f.Pc=812;continue;}
case 812:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",815);}
case 815:{f.Push(JValue.R(rt.String("TARGETS")));f.Pc=817;continue;}
case 817:{f.Push(f.Locals[23]);f.Pc=819;continue;}
case 819:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",822);}
case 822:{f.Pc=830;continue;}
case 825:{f.Push(f.Locals[0]);f.Pc=826;continue;}
case 826:{f.Push(f.Locals[1]);f.Pc=827;continue;}
case 827:{return rt.Call(f,"forge/game/ability/effects/AnimateEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",830);}
case 830:{f.Locals[24]=f.Pop();f.Pc=832;continue;}
case 832:{f.Push(f.Locals[22]);f.Pc=834;continue;}
case 834:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",839);}
case 839:{f.Push(JValue.I(1));f.Pc=840;continue;}
case 840:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?857:843;continue;}
case 843:{f.Push(f.Locals[22]);f.Pc=845;continue;}
case 845:{f.Push(JValue.I(0));f.Pc=846;continue;}
case 846:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",851);}
case 851:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=854;continue;}
case 854:{f.Pc=858;continue;}
case 857:{f.Push(JValue.R(null));f.Pc=858;continue;}
case 858:{f.Locals[25]=f.Pop();f.Pc=860;continue;}
case 860:{f.Push(f.Locals[1]);f.Pc=861;continue;}
case 861:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",864);}
case 864:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",867);}
case 867:{f.Push(f.Locals[1]);f.Pc=868;continue;}
case 868:{f.Push(JValue.R(null));f.Pc=869;continue;}
case 869:{f.Push(f.Locals[24]);f.Pc=871;continue;}
case 871:{f.Push(f.Locals[25]);f.Pc=873;continue;}
case 873:{f.Push(JValue.R(null));f.Pc=874;continue;}
case 874:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",877);}
case 877:{f.Pc=f.Pop().Int!=0?881:880;continue;}
case 880:{return JStep.ReturnVoid;}
case 881:{f.Push(f.Locals[22]);f.Pc=883;continue;}
case 883:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",888);}
case 888:{f.Locals[23]=f.Pop();f.Pc=890;continue;}
case 890:{f.Push(f.Locals[23]);f.Pc=892;continue;}
case 892:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",897);}
case 897:{f.Pc=f.Pop().Int==0?1102:900;continue;}
case 900:{f.Push(f.Locals[23]);f.Pc=902;continue;}
case 902:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",907);}
case 907:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=910;continue;}
case 910:{f.Locals[24]=f.Pop();f.Pc=912;continue;}
case 912:{f.Push(f.Locals[24]);f.Pc=914;continue;}
case 914:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",917);}
case 917:{f.Pc=f.Pop().Int==0?923:920;continue;}
case 920:{f.Pc=890;continue;}
case 923:{f.Push(f.Locals[8]);f.Pc=925;continue;}
case 925:{f.Push(f.Locals[24]);f.Pc=927;continue;}
case 927:{f.Push(JValue.R(null));f.Pc=928;continue;}
case 928:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",931);}
case 931:{f.Locals[25]=f.Pop();f.Pc=933;continue;}
case 933:{f.Push(f.Locals[25]);f.Pc=935;continue;}
case 935:{f.Pc=f.Pop().Reference==null?890:938;continue;}
case 938:{f.Push(f.Locals[24]);f.Pc=940;continue;}
case 940:{f.Push(f.Locals[25]);f.Pc=942;continue;}
case 942:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",945);}
case 945:{f.Pc=f.Pop().Int==0?890:948;continue;}
case 948:{f.Push(f.Locals[25]);f.Pc=950;continue;}
case 950:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",953);}
case 953:{f.Pc=f.Pop().Int==0?959:956;continue;}
case 956:{f.Pc=890;continue;}
case 959:{f.Push(f.Locals[25]);f.Pc=961;continue;}
case 961:{f.Push(f.Locals[1]);f.Pc=962;continue;}
case 962:{f.Push(f.Locals[6]);f.Pc=964;continue;}
case 964:{f.Push(f.Locals[7]);f.Pc=966;continue;}
case 966:{f.Push(f.Locals[11]);f.Pc=968;continue;}
case 968:{f.Push(f.Locals[12]);f.Pc=970;continue;}
case 970:{f.Push(f.Locals[16]);f.Pc=972;continue;}
case 972:{f.Push(f.Locals[13]);f.Pc=974;continue;}
case 974:{f.Push(f.Locals[14]);f.Pc=976;continue;}
case 976:{f.Push(f.Locals[15]);f.Pc=978;continue;}
case 978:{f.Push(f.Locals[17]);f.Pc=980;continue;}
case 980:{f.Push(f.Locals[19]);f.Pc=982;continue;}
case 982:{f.Push(f.Locals[18]);f.Pc=984;continue;}
case 984:{f.Push(f.Locals[20]);f.Pc=986;continue;}
case 986:{f.Push(f.Locals[9]);f.Pc=988;continue;}
case 988:{f.Push(f.Locals[3]);f.Pc=989;continue;}
case 989:{return rt.Call(f,"forge/game/ability/effects/AnimateEffect","doAnimate","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/Integer;Ljava/lang/Integer;Lforge/card/CardType;Lforge/card/CardType;Lforge/card/ColorSet;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;JLjava/lang/String;)V","invokestatic",992);}
case 992:{f.Push(f.Locals[1]);f.Pc=993;continue;}
case 993:{f.Push(JValue.R(rt.String("Name")));f.Pc=996;continue;}
case 996:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",999);}
case 999:{f.Pc=f.Pop().Int==0?1018:1002;continue;}
case 1002:{f.Push(f.Locals[25]);f.Pc=1004;continue;}
case 1004:{f.Push(f.Locals[1]);f.Pc=1005;continue;}
case 1005:{f.Push(JValue.R(rt.String("Name")));f.Pc=1008;continue;}
case 1008:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1011);}
case 1011:{f.Push(JValue.I(0));f.Pc=1012;continue;}
case 1012:{f.Push(f.Locals[9]);f.Pc=1014;continue;}
case 1014:{f.Push(JValue.L(0));f.Pc=1015;continue;}
case 1015:{return rt.Call(f,"forge/game/card/Card","addChangedName","(Ljava/lang/String;ZJJ)V","invokevirtual",1018);}
case 1018:{f.Push(f.Locals[21]);f.Pc=1020;continue;}
case 1020:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",1025);}
case 1025:{f.Pc=f.Pop().Int!=0?1038:1028;continue;}
case 1028:{f.Push(f.Locals[25]);f.Pc=1030;continue;}
case 1030:{f.Push(f.Locals[21]);f.Pc=1032;continue;}
case 1032:{f.Push(f.Locals[9]);f.Pc=1034;continue;}
case 1034:{f.Push(JValue.L(0));f.Pc=1035;continue;}
case 1035:{return rt.Call(f,"forge/game/card/Card","addChangedSVars","(Ljava/util/Map;JJ)V","invokevirtual",1038);}
case 1038:{f.Push(f.Locals[4]);f.Pc=1040;continue;}
case 1040:{f.Pc=f.Pop().Reference==null?1055:1043;continue;}
case 1043:{f.Push(f.Locals[25]);f.Pc=1045;continue;}
case 1045:{f.Push(f.Locals[2]);f.Pc=1046;continue;}
case 1046:{f.Push(f.Locals[4]);f.Pc=1048;continue;}
case 1048:{f.Push(f.Locals[1]);f.Pc=1049;continue;}
case 1049:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",1052);}
case 1052:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1055);}
case 1055:{f.Push(f.Locals[5]);f.Pc=1057;continue;}
case 1057:{f.Pc=f.Pop().Reference==null?1072:1060;continue;}
case 1060:{f.Push(f.Locals[25]);f.Pc=1062;continue;}
case 1062:{f.Push(f.Locals[2]);f.Pc=1063;continue;}
case 1063:{f.Push(f.Locals[5]);f.Pc=1065;continue;}
case 1065:{f.Push(f.Locals[1]);f.Pc=1066;continue;}
case 1066:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1069);}
case 1069:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",1072);}
case 1072:{f.Push(f.Locals[1]);f.Pc=1073;continue;}
case 1073:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCrew","()Z","invokevirtual",1076);}
case 1076:{f.Pc=f.Pop().Int==0?1085:1079;continue;}
case 1079:{f.Push(f.Locals[25]);f.Pc=1081;continue;}
case 1081:{f.Push(f.Locals[1]);f.Pc=1082;continue;}
case 1082:{return rt.Call(f,"forge/game/card/Card","becomesCrewed","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1085);}
case 1085:{f.Push(f.Locals[8]);f.Pc=1087;continue;}
case 1087:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=1090;continue;}
case 1090:{f.StackOp("dup");f.Pc=1091;continue;}
case 1091:{f.Push(f.Locals[25]);f.Pc=1093;continue;}
case 1093:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",1096);}
case 1096:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1099);}
case 1099:{f.Pc=890;continue;}
case 1102:{f.Push(f.Locals[1]);f.Pc=1103;continue;}
case 1103:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=1106;continue;}
case 1106:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1109);}
case 1109:{f.Pc=f.Pop().Int==0?1135:1112;continue;}
case 1112:{f.Push(f.Locals[22]);f.Pc=1114;continue;}
case 1114:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1119);}
case 1119:{f.Pc=f.Pop().Int!=0?1135:1122;continue;}
case 1122:{f.Push(f.Locals[1]);f.Pc=1123;continue;}
case 1123:{f.Push(f.Locals[1]);f.Pc=1124;continue;}
case 1124:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=1127;continue;}
case 1127:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1130);}
case 1130:{f.Push(f.Locals[22]);f.Pc=1132;continue;}
case 1132:{return rt.Call(f,"forge/game/ability/effects/AnimateEffect","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V","invokestatic",1135);}
case 1135:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3024(JRuntime rt,JFrame f)
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
case 14:{return rt.Call(f,"forge/game/ability/effects/AnimateEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",26);}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?34:30;continue;}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{f.Pc=35;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{f.Locals[5]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?122:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Push(JValue.R(rt.String("True")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?102:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int==0?102:73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",80);}
case 80:{f.Locals[6]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{f.Push(JValue.I(0));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String(",")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",93);}
case 93:{f.Push(JValue.I(1));f.Pc=94;continue;}
case 94:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;","invokevirtual",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Pc=114;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",111);}
case 111:{return rt.Call(f,"forge/game/ability/effects/AnimateEffect","tokenizeString","(Lforge/game/spellability/SpellAbility;Ljava/lang/StringBuilder;Ljava/lang/String;)V","invokestatic",114);}
case 114:{f.Push(f.Locals[3]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String(" ")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",121);}
case 121:{f.StackOp("pop");f.Pc=122;continue;}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("DefinedDesc")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",130);}
case 130:{f.Pc=f.Pop().Int==0?143:133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{f.Push(JValue.R(rt.String("DefinedDesc")));f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",140);}
case 140:{f.Pc=164;continue;}
case 143:{f.Push(f.Locals[4]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",150);}
case 150:{f.Pc=f.Pop().Int==0?159:153;continue;}
case 153:{f.Push(JValue.R(rt.String("It")));f.Pc=156;continue;}
case 156:{f.Pc=164;continue;}
case 159:{f.Push(f.Locals[4]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",164);}
case 164:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",167);}
case 167:{f.StackOp("pop");f.Pc=168;continue;}
case 168:{f.Push(f.Locals[3]);f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String(" ")));f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",175);}
case 175:{f.StackOp("pop");f.Pc=176;continue;}
case 176:{f.Push(f.Locals[3]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",180);}
case 180:{f.Locals[6]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(JValue.I(0));f.Pc=183;continue;}
case 183:{f.Locals[7]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(JValue.R(null));f.Pc=186;continue;}
case 186:{f.Locals[8]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(f.Locals[1]);f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.String("Power")));f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",194);}
case 194:{f.Pc=f.Pop().Int==0?213:197;continue;}
case 197:{f.Push(f.Locals[2]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[1]);f.Pc=199;continue;}
case 199:{f.Push(JValue.R(rt.String("Power")));f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",204);}
case 204:{f.Push(f.Locals[1]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",208);}
case 208:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",211);}
case 211:{f.Locals[8]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(JValue.R(null));f.Pc=214;continue;}
case 214:{f.Locals[9]=f.Pop();f.Pc=216;continue;}
case 216:{f.Push(f.Locals[1]);f.Pc=217;continue;}
case 217:{f.Push(JValue.R(rt.String("Toughness")));f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",222);}
case 222:{f.Pc=f.Pop().Int==0?241:225;continue;}
case 225:{f.Push(f.Locals[2]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[1]);f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String("Toughness")));f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",232);}
case 232:{f.Push(f.Locals[1]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",236);}
case 236:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",239);}
case 239:{f.Locals[9]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=244;continue;}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("Duration")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",250);}
case 250:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",253);}
case 253:{f.Locals[10]=f.Pop();f.Pc=255;continue;}
case 255:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",258);}
case 258:{f.Locals[11]=f.Pop();f.Pc=260;continue;}
case 260:{f.Push(f.Locals[1]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String("Types")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",266);}
case 266:{f.Pc=f.Pop().Int==0?294:269;continue;}
case 269:{f.Push(f.Locals[11]);f.Pc=271;continue;}
case 271:{f.Push(f.Locals[1]);f.Pc=272;continue;}
case 272:{f.Push(JValue.R(rt.String("Types")));f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",277);}
case 277:{f.Push(JValue.R(rt.String(",")));f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",282);}
case 282:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",285);}
case 285:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",290);}
case 290:{f.StackOp("pop");f.Pc=291;continue;}
case 291:{f.Push(JValue.I(1));f.Pc=292;continue;}
case 292:{f.Locals[7]=f.Pop();f.Pc=294;continue;}
case 294:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",297);}
case 297:{f.Locals[12]=f.Pop();f.Pc=299;continue;}
case 299:{f.Push(f.Locals[1]);f.Pc=300;continue;}
case 300:{f.Push(JValue.R(rt.String("Keywords")));f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",305);}
case 305:{f.Pc=f.Pop().Int==0?330:308;continue;}
case 308:{f.Push(f.Locals[12]);f.Pc=310;continue;}
case 310:{f.Push(f.Locals[1]);f.Pc=311;continue;}
case 311:{f.Push(JValue.R(rt.String("Keywords")));f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",316);}
case 316:{f.Push(JValue.R(rt.String(" & ")));f.Pc=318;continue;}
case 318:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",321);}
case 321:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",324);}
case 324:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",329);}
case 329:{f.StackOp("pop");f.Pc=330;continue;}
case 330:{f.Push(JValue.I(0));f.Pc=331;continue;}
case 331:{f.Locals[13]=f.Pop();f.Pc=333;continue;}
case 333:{f.Push(f.Locals[13]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[12]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",342);}
case 342:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?399:345;continue;}
case 345:{f.Push(f.Locals[12]);f.Pc=347;continue;}
case 347:{f.Push(f.Locals[13]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",354);}
case 354:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=357;continue;}
case 357:{f.Locals[14]=f.Pop();f.Pc=359;continue;}
case 359:{f.Push(f.Locals[1]);f.Pc=360;continue;}
case 360:{f.Push(f.Locals[14]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasSVar","(Ljava/lang/String;)Z","invokevirtual",365);}
case 365:{f.Pc=f.Pop().Int==0?393:368;continue;}
case 368:{f.Push(f.Locals[12]);f.Pc=370;continue;}
case 370:{f.Push(f.Locals[14]);f.Pc=372;continue;}
case 372:{return rt.DynamicCall(f,"forge/game/ability/effects/AnimateEffect:3024:372:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",377);}
case 377:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",382);}
case 382:{f.StackOp("pop");f.Pc=383;continue;}
case 383:{f.Push(f.Locals[12]);f.Pc=385;continue;}
case 385:{f.Push(f.Locals[14]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",392);}
case 392:{f.StackOp("pop");f.Pc=393;continue;}
case 393:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=396;continue;}
case 396:{f.Pc=333;continue;}
case 399:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",402);}
case 402:{f.Locals[13]=f.Pop();f.Pc=404;continue;}
case 404:{f.Push(f.Locals[1]);f.Pc=405;continue;}
case 405:{f.Push(JValue.R(rt.String("Colors")));f.Pc=407;continue;}
case 407:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",410);}
case 410:{f.Pc=f.Pop().Int==0?438:413;continue;}
case 413:{f.Push(f.Locals[13]);f.Pc=415;continue;}
case 415:{f.Push(f.Locals[1]);f.Pc=416;continue;}
case 416:{f.Push(JValue.R(rt.String("Colors")));f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",421);}
case 421:{f.Push(JValue.R(rt.String(",")));f.Pc=423;continue;}
case 423:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",426);}
case 426:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",429);}
case 429:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",434);}
case 434:{f.StackOp("pop");f.Pc=435;continue;}
case 435:{f.Push(JValue.I(1));f.Pc=436;continue;}
case 436:{f.Locals[7]=f.Pop();f.Pc=438;continue;}
case 438:{f.Push(f.Locals[8]);f.Pc=440;continue;}
case 440:{f.Pc=f.Pop().Reference!=null?448:443;continue;}
case 443:{f.Push(f.Locals[9]);f.Pc=445;continue;}
case 445:{f.Pc=f.Pop().Reference==null?562:448;continue;}
case 448:{f.Push(f.Locals[3]);f.Pc=449;continue;}
case 449:{f.Push(f.Locals[5]);f.Pc=451;continue;}
case 451:{f.Pc=f.Pop().Int==0?460:454;continue;}
case 454:{f.Push(JValue.R(rt.String("has")));f.Pc=457;continue;}
case 457:{f.Pc=463;continue;}
case 460:{f.Push(JValue.R(rt.String("have")));f.Pc=463;continue;}
case 463:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",466);}
case 466:{f.Push(JValue.R(rt.String(" base ")));f.Pc=469;continue;}
case 469:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",472);}
case 472:{f.StackOp("pop");f.Pc=473;continue;}
case 473:{f.Push(f.Locals[8]);f.Pc=475;continue;}
case 475:{f.Pc=f.Pop().Reference==null?516:478;continue;}
case 478:{f.Push(f.Locals[9]);f.Pc=480;continue;}
case 480:{f.Pc=f.Pop().Reference==null?516:483;continue;}
case 483:{f.Push(f.Locals[3]);f.Pc=484;continue;}
case 484:{f.Push(JValue.R(rt.String("power and toughness ")));f.Pc=487;continue;}
case 487:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",490);}
case 490:{f.Push(f.Locals[8]);f.Pc=492;continue;}
case 492:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",495);}
case 495:{f.Push(JValue.R(rt.String("/")));f.Pc=498;continue;}
case 498:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",501);}
case 501:{f.Push(f.Locals[9]);f.Pc=503;continue;}
case 503:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",506);}
case 506:{f.Push(JValue.R(rt.String(" ")));f.Pc=509;continue;}
case 509:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",512);}
case 512:{f.StackOp("pop");f.Pc=513;continue;}
case 513:{f.Pc=562;continue;}
case 516:{f.Push(f.Locals[8]);f.Pc=518;continue;}
case 518:{f.Pc=f.Pop().Reference==null?543:521;continue;}
case 521:{f.Push(f.Locals[3]);f.Pc=522;continue;}
case 522:{f.Push(JValue.R(rt.String("power ")));f.Pc=525;continue;}
case 525:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",528);}
case 528:{f.Push(f.Locals[8]);f.Pc=530;continue;}
case 530:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",533);}
case 533:{f.Push(JValue.R(rt.String(" ")));f.Pc=536;continue;}
case 536:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",539);}
case 539:{f.StackOp("pop");f.Pc=540;continue;}
case 540:{f.Pc=562;continue;}
case 543:{f.Push(f.Locals[3]);f.Pc=544;continue;}
case 544:{f.Push(JValue.R(rt.String("toughness ")));f.Pc=547;continue;}
case 547:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",550);}
case 550:{f.Push(f.Locals[9]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",555);}
case 555:{f.Push(JValue.R(rt.String(" ")));f.Pc=558;continue;}
case 558:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",561);}
case 561:{f.StackOp("pop");f.Pc=562;continue;}
case 562:{f.Push(f.Locals[3]);f.Pc=563;continue;}
case 563:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",566);}
case 566:{f.Push(f.Locals[6]);f.Pc=568;continue;}
case 568:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?584:571;continue;}
case 571:{f.Push(f.Locals[7]);f.Pc=573;continue;}
case 573:{f.Pc=f.Pop().Int==0?584:576;continue;}
case 576:{f.Push(f.Locals[3]);f.Pc=577;continue;}
case 577:{f.Push(JValue.R(rt.String(" and ")));f.Pc=580;continue;}
case 580:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",583);}
case 583:{f.StackOp("pop");f.Pc=584;continue;}
case 584:{f.Push(f.Locals[7]);f.Pc=586;continue;}
case 586:{f.Pc=f.Pop().Int==0?608:589;continue;}
case 589:{f.Push(f.Locals[3]);f.Pc=590;continue;}
case 590:{f.Push(f.Locals[5]);f.Pc=592;continue;}
case 592:{f.Pc=f.Pop().Int==0?601:595;continue;}
case 595:{f.Push(JValue.R(rt.String("becomes ")));f.Pc=598;continue;}
case 598:{f.Pc=604;continue;}
case 601:{f.Push(JValue.R(rt.String("become ")));f.Pc=604;continue;}
case 604:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",607);}
case 607:{f.StackOp("pop");f.Pc=608;continue;}
case 608:{f.Push(f.Locals[13]);f.Pc=610;continue;}
case 610:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=612;continue;}
case 612:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",617);}
case 617:{f.Pc=f.Pop().Int==0?631:620;continue;}
case 620:{f.Push(f.Locals[3]);f.Pc=621;continue;}
case 621:{f.Push(JValue.R(rt.String("color of that player's choice")));f.Pc=624;continue;}
case 624:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",627);}
case 627:{f.StackOp("pop");f.Pc=628;continue;}
case 628:{f.Pc=700;continue;}
case 631:{f.Push(JValue.I(0));f.Pc=632;continue;}
case 632:{f.Locals[14]=f.Pop();f.Pc=634;continue;}
case 634:{f.Push(f.Locals[14]);f.Pc=636;continue;}
case 636:{f.Push(f.Locals[13]);f.Pc=638;continue;}
case 638:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",643);}
case 643:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?700:646;continue;}
case 646:{f.Push(f.Locals[3]);f.Pc=647;continue;}
case 647:{f.Push(f.Locals[13]);f.Pc=649;continue;}
case 649:{f.Push(f.Locals[14]);f.Pc=651;continue;}
case 651:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",656);}
case 656:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=659;continue;}
case 659:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",662);}
case 662:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",665);}
case 665:{f.Push(JValue.R(rt.String(" ")));f.Pc=668;continue;}
case 668:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",671);}
case 671:{f.StackOp("pop");f.Pc=672;continue;}
case 672:{f.Push(f.Locals[14]);f.Pc=674;continue;}
case 674:{f.Push(f.Locals[13]);f.Pc=676;continue;}
case 676:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",681);}
case 681:{f.Push(JValue.I(1));f.Pc=682;continue;}
case 682:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=683;continue;}
case 683:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?694:686;continue;}
case 686:{f.Push(f.Locals[3]);f.Pc=687;continue;}
case 687:{f.Push(JValue.R(rt.String("and ")));f.Pc=690;continue;}
case 690:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",693);}
case 693:{f.StackOp("pop");f.Pc=694;continue;}
case 694:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=697;continue;}
case 697:{f.Pc=634;continue;}
case 700:{f.Push(f.Locals[11]);f.Pc=702;continue;}
case 702:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=704;continue;}
case 704:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",709);}
case 709:{f.Pc=f.Pop().Int==0?723:712;continue;}
case 712:{f.Push(f.Locals[3]);f.Pc=713;continue;}
case 713:{f.Push(JValue.R(rt.String("type of player's choice ")));f.Pc=716;continue;}
case 716:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",719);}
case 719:{f.StackOp("pop");f.Pc=720;continue;}
case 720:{f.Pc=819;continue;}
case 723:{f.Push(JValue.I(0));f.Pc=724;continue;}
case 724:{f.Locals[14]=f.Pop();f.Pc=726;continue;}
case 726:{f.Push(f.Locals[14]);f.Pc=728;continue;}
case 728:{f.Push(f.Locals[11]);f.Pc=730;continue;}
case 730:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",735);}
case 735:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?819:738;continue;}
case 738:{f.Push(f.Locals[11]);f.Pc=740;continue;}
case 740:{f.Push(f.Locals[14]);f.Pc=742;continue;}
case 742:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",747);}
case 747:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=750;continue;}
case 750:{f.Locals[15]=f.Pop();f.Pc=752;continue;}
case 752:{f.Push(f.Locals[14]);f.Pc=754;continue;}
case 754:{f.Pc=f.Pop().Int!=0?784:757;continue;}
case 757:{f.Push(f.Locals[5]);f.Pc=759;continue;}
case 759:{f.Pc=f.Pop().Int==0?784:762;continue;}
case 762:{f.Push(f.Locals[3]);f.Pc=763;continue;}
case 763:{f.Push(f.Locals[15]);f.Pc=765;continue;}
case 765:{return rt.Call(f,"forge/util/Lang","startsWithVowel","(Ljava/lang/String;)Z","invokestatic",768);}
case 768:{f.Pc=f.Pop().Int==0?777:771;continue;}
case 771:{f.Push(JValue.R(rt.String("an ")));f.Pc=774;continue;}
case 774:{f.Pc=780;continue;}
case 777:{f.Push(JValue.R(rt.String("a ")));f.Pc=780;continue;}
case 780:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",783);}
case 783:{f.StackOp("pop");f.Pc=784;continue;}
case 784:{f.Push(f.Locals[3]);f.Pc=785;continue;}
case 785:{f.Push(f.Locals[15]);f.Pc=787;continue;}
case 787:{return rt.Call(f,"forge/card/CardType$CoreType","isValidEnum","(Ljava/lang/String;)Z","invokestatic",790);}
case 790:{f.Pc=f.Pop().Int==0?801:793;continue;}
case 793:{f.Push(f.Locals[15]);f.Pc=795;continue;}
case 795:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",798);}
case 798:{f.Pc=803;continue;}
case 801:{f.Push(f.Locals[15]);f.Pc=803;continue;}
case 803:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",806);}
case 806:{f.Push(JValue.R(rt.String(" ")));f.Pc=809;continue;}
case 809:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",812);}
case 812:{f.StackOp("pop");f.Pc=813;continue;}
case 813:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=816;continue;}
case 816:{f.Pc=726;continue;}
case 819:{f.Push(f.Locals[12]);f.Pc=821;continue;}
case 821:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",826);}
case 826:{f.Pc=f.Pop().Int<=0?877:829;continue;}
case 829:{f.Push(f.Locals[3]);f.Pc=830;continue;}
case 830:{f.Push(f.Locals[3]);f.Pc=831;continue;}
case 831:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",834);}
case 834:{f.Push(f.Locals[6]);f.Pc=836;continue;}
case 836:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?845:839;continue;}
case 839:{f.Push(JValue.R(rt.String("and ")));f.Pc=842;continue;}
case 842:{f.Pc=848;continue;}
case 845:{f.Push(JValue.R(rt.String("")));f.Pc=848;continue;}
case 848:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",851);}
case 851:{f.Push(JValue.R(rt.String(" gains ")));f.Pc=854;continue;}
case 854:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",857);}
case 857:{f.StackOp("pop");f.Pc=858;continue;}
case 858:{f.Push(f.Locals[3]);f.Pc=859;continue;}
case 859:{f.Push(f.Locals[12]);f.Pc=861;continue;}
case 861:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",864);}
case 864:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",867);}
case 867:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",870);}
case 870:{f.Push(JValue.R(rt.String(" ")));f.Pc=873;continue;}
case 873:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",876);}
case 876:{f.StackOp("pop");f.Pc=877;continue;}
case 877:{f.Push(f.Locals[10]);f.Pc=879;continue;}
case 879:{f.Pc=f.Pop().Int!=0?1005:882;continue;}
case 882:{f.Push(f.Locals[3]);f.Pc=883;continue;}
case 883:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",886);}
case 886:{f.Push(f.Locals[6]);f.Pc=888;continue;}
case 888:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1005:891;continue;}
case 891:{f.Push(f.Locals[1]);f.Pc=892;continue;}
case 892:{f.Push(JValue.R(rt.String("Duration")));f.Pc=894;continue;}
case 894:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",897);}
case 897:{f.Locals[14]=f.Pop();f.Pc=899;continue;}
case 899:{f.Push(JValue.R(rt.String("UntilEndOfCombat")));f.Pc=902;continue;}
case 902:{f.Push(f.Locals[14]);f.Pc=904;continue;}
case 904:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",907);}
case 907:{f.Pc=f.Pop().Int==0?921:910;continue;}
case 910:{f.Push(f.Locals[3]);f.Pc=911;continue;}
case 911:{f.Push(JValue.R(rt.String("until end of combat")));f.Pc=914;continue;}
case 914:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",917);}
case 917:{f.StackOp("pop");f.Pc=918;continue;}
case 918:{f.Pc=1005;continue;}
case 921:{f.Push(JValue.R(rt.String("UntilHostLeavesPlay")));f.Pc=924;continue;}
case 924:{f.Push(f.Locals[14]);f.Pc=926;continue;}
case 926:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",929);}
case 929:{f.Pc=f.Pop().Int==0?953:932;continue;}
case 932:{f.Push(f.Locals[3]);f.Pc=933;continue;}
case 933:{f.Push(JValue.R(rt.String("until ")));f.Pc=936;continue;}
case 936:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",939);}
case 939:{f.Push(f.Locals[2]);f.Pc=940;continue;}
case 940:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",943);}
case 943:{f.Push(JValue.R(rt.String(" leaves the battlefield")));f.Pc=946;continue;}
case 946:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",949);}
case 949:{f.StackOp("pop");f.Pc=950;continue;}
case 950:{f.Pc=1005;continue;}
case 953:{f.Push(JValue.R(rt.String("UntilYourNextUpkeep")));f.Pc=956;continue;}
case 956:{f.Push(f.Locals[14]);f.Pc=958;continue;}
case 958:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",961);}
case 961:{f.Pc=f.Pop().Int==0?975:964;continue;}
case 964:{f.Push(f.Locals[3]);f.Pc=965;continue;}
case 965:{f.Push(JValue.R(rt.String("until your next upkeep")));f.Pc=968;continue;}
case 968:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",971);}
case 971:{f.StackOp("pop");f.Pc=972;continue;}
case 972:{f.Pc=1005;continue;}
case 975:{f.Push(JValue.R(rt.String("UntilYourNextTurn")));f.Pc=978;continue;}
case 978:{f.Push(f.Locals[14]);f.Pc=980;continue;}
case 980:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",983);}
case 983:{f.Pc=f.Pop().Int==0?997:986;continue;}
case 986:{f.Push(f.Locals[3]);f.Pc=987;continue;}
case 987:{f.Push(JValue.R(rt.String("until your next turn")));f.Pc=990;continue;}
case 990:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",993);}
case 993:{f.StackOp("pop");f.Pc=994;continue;}
case 994:{f.Pc=1005;continue;}
case 997:{f.Push(f.Locals[3]);f.Pc=998;continue;}
case 998:{f.Push(JValue.R(rt.String("until end of turn")));f.Pc=1001;continue;}
case 1001:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1004);}
case 1004:{f.StackOp("pop");f.Pc=1005;continue;}
case 1005:{f.Push(f.Locals[1]);f.Pc=1006;continue;}
case 1006:{f.Push(JValue.R(rt.String("staticAbilities")));f.Pc=1008;continue;}
case 1008:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1011);}
case 1011:{f.Pc=f.Pop().Int==0?1077:1014;continue;}
case 1014:{f.Push(f.Locals[1]);f.Pc=1015;continue;}
case 1015:{f.Push(JValue.R(rt.String("staticAbilities")));f.Pc=1017;continue;}
case 1017:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1020);}
case 1020:{f.Push(JValue.R(rt.String("MustAttack")));f.Pc=1023;continue;}
case 1023:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1026);}
case 1026:{f.Pc=f.Pop().Int==0?1077:1029;continue;}
case 1029:{f.Push(f.Locals[3]);f.Pc=1030;continue;}
case 1030:{f.Push(f.Locals[3]);f.Pc=1031;continue;}
case 1031:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",1034);}
case 1034:{f.Push(f.Locals[6]);f.Pc=1036;continue;}
case 1036:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1045:1039;continue;}
case 1039:{f.Push(JValue.R(rt.String(" and ")));f.Pc=1042;continue;}
case 1042:{f.Pc=1048;continue;}
case 1045:{f.Push(JValue.R(rt.String("")));f.Pc=1048;continue;}
case 1048:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1051);}
case 1051:{f.StackOp("pop");f.Pc=1052;continue;}
case 1052:{f.Push(f.Locals[3]);f.Pc=1053;continue;}
case 1053:{f.Push(f.Locals[5]);f.Pc=1055;continue;}
case 1055:{f.Pc=f.Pop().Int==0?1064:1058;continue;}
case 1058:{f.Push(JValue.R(rt.String("attacks")));f.Pc=1061;continue;}
case 1061:{f.Pc=1067;continue;}
case 1064:{f.Push(JValue.R(rt.String("attack")));f.Pc=1067;continue;}
case 1067:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1070);}
case 1070:{f.Push(JValue.R(rt.String(" this turn if able")));f.Pc=1073;continue;}
case 1073:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1076);}
case 1076:{f.StackOp("pop");f.Pc=1077;continue;}
case 1077:{f.Push(f.Locals[3]);f.Pc=1078;continue;}
case 1078:{f.Push(JValue.R(rt.String(".")));f.Pc=1081;continue;}
case 1081:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1084);}
case 1084:{f.StackOp("pop");f.Pc=1085;continue;}
case 1085:{f.Push(f.Locals[1]);f.Pc=1086;continue;}
case 1086:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=1089;continue;}
case 1089:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1092);}
case 1092:{f.Pc=f.Pop().Int==0?1220:1095;continue;}
case 1095:{f.Push(f.Locals[3]);f.Pc=1096;continue;}
case 1096:{f.Push(JValue.R(rt.String(" ")));f.Pc=1099;continue;}
case 1099:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1102);}
case 1102:{f.StackOp("pop");f.Pc=1103;continue;}
case 1103:{f.Push(f.Locals[1]);f.Pc=1104;continue;}
case 1104:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=1107;continue;}
case 1107:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1110);}
case 1110:{f.Locals[14]=f.Pop();f.Pc=1112;continue;}
case 1112:{f.Push(f.Locals[5]);f.Pc=1114;continue;}
case 1114:{f.Pc=f.Pop().Int==0?1123:1117;continue;}
case 1117:{f.Push(JValue.R(rt.String("it")));f.Pc=1120;continue;}
case 1120:{f.Pc=1126;continue;}
case 1123:{f.Push(JValue.R(rt.String("them")));f.Pc=1126;continue;}
case 1126:{f.Locals[15]=f.Pop();f.Pc=1128;continue;}
case 1128:{f.Push(f.Locals[14]);f.Pc=1130;continue;}
case 1130:{f.Push(JValue.R(rt.String("Hand")));f.Pc=1133;continue;}
case 1133:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1136);}
case 1136:{f.Pc=f.Pop().Int==0?1161:1139;continue;}
case 1139:{f.Push(f.Locals[3]);f.Pc=1140;continue;}
case 1140:{f.Push(JValue.R(rt.String("Return ")));f.Pc=1143;continue;}
case 1143:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1146);}
case 1146:{f.Push(f.Locals[15]);f.Pc=1148;continue;}
case 1148:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1151);}
case 1151:{f.Push(JValue.R(rt.String(" to your hand")));f.Pc=1154;continue;}
case 1154:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1157);}
case 1157:{f.StackOp("pop");f.Pc=1158;continue;}
case 1158:{f.Pc=1212;continue;}
case 1161:{f.Push(f.Locals[14]);f.Pc=1163;continue;}
case 1163:{f.Push(JValue.R(rt.String("SacrificeCtrl")));f.Pc=1166;continue;}
case 1166:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1169);}
case 1169:{f.Pc=f.Pop().Int==0?1194:1172;continue;}
case 1172:{f.Push(f.Locals[3]);f.Pc=1173;continue;}
case 1173:{f.Push(f.Locals[5]);f.Pc=1175;continue;}
case 1175:{f.Pc=f.Pop().Int==0?1184:1178;continue;}
case 1178:{f.Push(JValue.R(rt.String("Its controller sacrifices it")));f.Pc=1181;continue;}
case 1181:{f.Pc=1187;continue;}
case 1184:{f.Push(JValue.R(rt.String("Their controllers sacrifice them")));f.Pc=1187;continue;}
case 1187:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1190);}
case 1190:{f.StackOp("pop");f.Pc=1191;continue;}
case 1191:{f.Pc=1212;continue;}
case 1194:{f.Push(f.Locals[3]);f.Pc=1195;continue;}
case 1195:{f.Push(f.Locals[14]);f.Pc=1197;continue;}
case 1197:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1200);}
case 1200:{f.Push(JValue.R(rt.String(" ")));f.Pc=1203;continue;}
case 1203:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1206);}
case 1206:{f.Push(f.Locals[15]);f.Pc=1208;continue;}
case 1208:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1211);}
case 1211:{f.StackOp("pop");f.Pc=1212;continue;}
case 1212:{f.Push(f.Locals[3]);f.Pc=1213;continue;}
case 1213:{f.Push(JValue.R(rt.String(" at the beginning of the next end step.")));f.Pc=1216;continue;}
case 1216:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1219);}
case 1219:{f.StackOp("pop");f.Pc=1220;continue;}
case 1220:{f.Push(f.Locals[3]);f.Pc=1221;continue;}
case 1221:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1224);}
case 1224:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C200{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AnimateAllEffect","forge/game/ability/effects/AnimateEffectBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3019,"forge/game/ability/effects/AnimateAllEffect","<init>","()V",1,1,1,new JHandler[]{},M3019));
c.Add(new JMethod(3020,"forge/game/ability/effects/AnimateAllEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,3,new JHandler[]{},M3020));
c.Add(new JMethod(3021,"forge/game/ability/effects/AnimateAllEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,25,18,new JHandler[]{},M3021));
}

internal static JStep M3019(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/AnimateEffectBase","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3020(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("Animate all valid cards.")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3021(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("Power")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?31:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Power")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",23);}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",27);}
case 27:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(JValue.R(null));f.Pc=32;continue;}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("Toughness")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?59:43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("Toughness")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",50);}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",54);}
case 54:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",57);}
case 57:{f.Locals[4]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",63);}
case 63:{f.Locals[5]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",70);}
case 70:{f.Locals[6]=f.Pop();f.Pc=72;continue;}
case 72:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/card/CardType","<init>","(Z)V","invokespecial",80);}
case 80:{f.Locals[8]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("Types")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?111:91;continue;}
case 91:{f.Push(f.Locals[8]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("Types")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Push(JValue.R(rt.String(",")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",104);}
case 104:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",107);}
case 107:{return rt.Call(f,"forge/card/CardType","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=114;continue;}
case 114:{f.StackOp("dup");f.Pc=115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/card/CardType","<init>","(Z)V","invokespecial",119);}
case 119:{f.Locals[9]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("RemoveTypes")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int==0?150:130;continue;}
case 130:{f.Push(f.Locals[9]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("RemoveTypes")));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",138);}
case 138:{f.Push(JValue.R(rt.String(",")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",143);}
case 143:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",146);}
case 146:{return rt.Call(f,"forge/card/CardType","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Push(f.Locals[8]);f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",157);}
case 157:{f.Pc=f.Pop().Int==0?178:160;continue;}
case 160:{f.Push(f.Locals[8]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/card/CardType","clear","()V","invokevirtual",165);}
case 165:{f.Push(f.Locals[8]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[2]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",171);}
case 171:{return rt.Call(f,"forge/card/CardType","add","(Ljava/lang/String;)Z","invokevirtual",174);}
case 174:{f.StackOp("pop");f.Pc=175;continue;}
case 175:{f.Pc=203;continue;}
case 178:{f.Push(f.Locals[8]);f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("ChosenType2")));f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",185);}
case 185:{f.Pc=f.Pop().Int==0?203:188;continue;}
case 188:{f.Push(f.Locals[8]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/card/CardType","clear","()V","invokevirtual",193);}
case 193:{f.Push(f.Locals[8]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/card/Card","getChosenType2","()Ljava/lang/String;","invokevirtual",199);}
case 199:{return rt.Call(f,"forge/card/CardType","add","(Ljava/lang/String;)Z","invokevirtual",202);}
case 202:{f.StackOp("pop");f.Pc=203;continue;}
case 203:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",206);}
case 206:{f.Locals[10]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[1]);f.Pc=209;continue;}
case 209:{f.Push(JValue.R(rt.String("Keywords")));f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",214);}
case 214:{f.Pc=f.Pop().Int==0?239:217;continue;}
case 217:{f.Push(f.Locals[10]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[1]);f.Pc=220;continue;}
case 220:{f.Push(JValue.R(rt.String("Keywords")));f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",225);}
case 225:{f.Push(JValue.R(rt.String(" & ")));f.Pc=227;continue;}
case 227:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",230);}
case 230:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",233);}
case 233:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",238);}
case 238:{f.StackOp("pop");f.Pc=239;continue;}
case 239:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",242);}
case 242:{f.Locals[11]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("RemoveKeywords")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",250);}
case 250:{f.Pc=f.Pop().Int==0?275:253;continue;}
case 253:{f.Push(f.Locals[11]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[1]);f.Pc=256;continue;}
case 256:{f.Push(JValue.R(rt.String("RemoveKeywords")));f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",261);}
case 261:{f.Push(JValue.R(rt.String(" & ")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",266);}
case 266:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",269);}
case 269:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",274);}
case 274:{f.StackOp("pop");f.Pc=275;continue;}
case 275:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",278);}
case 278:{f.Locals[12]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[1]);f.Pc=281;continue;}
case 281:{f.Push(JValue.R(rt.String("HiddenKeywords")));f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",286);}
case 286:{f.Pc=f.Pop().Int==0?311:289;continue;}
case 289:{f.Push(f.Locals[12]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[1]);f.Pc=292;continue;}
case 292:{f.Push(JValue.R(rt.String("HiddenKeywords")));f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",297);}
case 297:{f.Push(JValue.R(rt.String(" & ")));f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",302);}
case 302:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",305);}
case 305:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",310);}
case 310:{f.StackOp("pop");f.Pc=311;continue;}
case 311:{f.Push(JValue.I(0));f.Pc=312;continue;}
case 312:{f.Locals[13]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[13]);f.Pc=316;continue;}
case 316:{f.Push(f.Locals[10]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",323);}
case 323:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?379:326;continue;}
case 326:{f.Push(f.Locals[10]);f.Pc=328;continue;}
case 328:{f.Push(f.Locals[13]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",335);}
case 335:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=338;continue;}
case 338:{f.Locals[14]=f.Pop();f.Pc=340;continue;}
case 340:{f.Push(f.Locals[2]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[14]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/card/Card","hasSVar","(Ljava/lang/String;)Z","invokevirtual",346);}
case 346:{f.Pc=f.Pop().Int==0?373:349;continue;}
case 349:{f.Push(f.Locals[10]);f.Pc=351;continue;}
case 351:{f.Push(f.Locals[2]);f.Pc=352;continue;}
case 352:{f.Push(f.Locals[14]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",357);}
case 357:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",362);}
case 362:{f.StackOp("pop");f.Pc=363;continue;}
case 363:{f.Push(f.Locals[10]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[14]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",372);}
case 372:{f.StackOp("pop");f.Pc=373;continue;}
case 373:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=376;continue;}
case 376:{f.Pc=314;continue;}
case 379:{f.Push(JValue.R(null));f.Pc=380;continue;}
case 380:{f.Locals[13]=f.Pop();f.Pc=382;continue;}
case 382:{f.Push(f.Locals[1]);f.Pc=383;continue;}
case 383:{f.Push(JValue.R(rt.String("Colors")));f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",388);}
case 388:{f.Pc=f.Pop().Int==0?433:391;continue;}
case 391:{f.Push(f.Locals[1]);f.Pc=392;continue;}
case 392:{f.Push(JValue.R(rt.String("Colors")));f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",397);}
case 397:{f.Locals[14]=f.Pop();f.Pc=399;continue;}
case 399:{f.Push(f.Locals[14]);f.Pc=401;continue;}
case 401:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=403;continue;}
case 403:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",406);}
case 406:{f.Pc=f.Pop().Int==0?421:409;continue;}
case 409:{f.Push(f.Locals[2]);f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/game/card/Card","getChosenColors","()Ljava/lang/Iterable;","invokevirtual",413);}
case 413:{return rt.Call(f,"forge/card/ColorSet","fromNames","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",416);}
case 416:{f.Locals[13]=f.Pop();f.Pc=418;continue;}
case 418:{f.Pc=433;continue;}
case 421:{f.Push(f.Locals[14]);f.Pc=423;continue;}
case 423:{f.Push(JValue.R(rt.String(",")));f.Pc=425;continue;}
case 425:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",428);}
case 428:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",431);}
case 431:{f.Locals[13]=f.Pop();f.Pc=433;continue;}
case 433:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",436);}
case 436:{f.Locals[14]=f.Pop();f.Pc=438;continue;}
case 438:{f.Push(f.Locals[1]);f.Pc=439;continue;}
case 439:{f.Push(JValue.R(rt.String("Abilities")));f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",444);}
case 444:{f.Pc=f.Pop().Int==0?469:447;continue;}
case 447:{f.Push(f.Locals[14]);f.Pc=449;continue;}
case 449:{f.Push(f.Locals[1]);f.Pc=450;continue;}
case 450:{f.Push(JValue.R(rt.String("Abilities")));f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",455);}
case 455:{f.Push(JValue.R(rt.String(",")));f.Pc=457;continue;}
case 457:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",460);}
case 460:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",463);}
case 463:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",468);}
case 468:{f.StackOp("pop");f.Pc=469;continue;}
case 469:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",472);}
case 472:{f.Locals[15]=f.Pop();f.Pc=474;continue;}
case 474:{f.Push(f.Locals[1]);f.Pc=475;continue;}
case 475:{f.Push(JValue.R(rt.String("Replacements")));f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",480);}
case 480:{f.Pc=f.Pop().Int==0?505:483;continue;}
case 483:{f.Push(f.Locals[15]);f.Pc=485;continue;}
case 485:{f.Push(f.Locals[1]);f.Pc=486;continue;}
case 486:{f.Push(JValue.R(rt.String("Replacements")));f.Pc=488;continue;}
case 488:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",491);}
case 491:{f.Push(JValue.R(rt.String(",")));f.Pc=493;continue;}
case 493:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",496);}
case 496:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",499);}
case 499:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",504);}
case 504:{f.StackOp("pop");f.Pc=505;continue;}
case 505:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",508);}
case 508:{f.Locals[16]=f.Pop();f.Pc=510;continue;}
case 510:{f.Push(f.Locals[1]);f.Pc=511;continue;}
case 511:{f.Push(JValue.R(rt.String("Triggers")));f.Pc=513;continue;}
case 513:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",516);}
case 516:{f.Pc=f.Pop().Int==0?541:519;continue;}
case 519:{f.Push(f.Locals[16]);f.Pc=521;continue;}
case 521:{f.Push(f.Locals[1]);f.Pc=522;continue;}
case 522:{f.Push(JValue.R(rt.String("Triggers")));f.Pc=524;continue;}
case 524:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",527);}
case 527:{f.Push(JValue.R(rt.String(",")));f.Pc=529;continue;}
case 529:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",532);}
case 532:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",535);}
case 535:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",540);}
case 540:{f.StackOp("pop");f.Pc=541;continue;}
case 541:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",544);}
case 544:{f.Locals[17]=f.Pop();f.Pc=546;continue;}
case 546:{f.Push(f.Locals[1]);f.Pc=547;continue;}
case 547:{f.Push(JValue.R(rt.String("sVars")));f.Pc=549;continue;}
case 549:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",552);}
case 552:{f.Pc=f.Pop().Int==0?577:555;continue;}
case 555:{f.Push(f.Locals[17]);f.Pc=557;continue;}
case 557:{f.Push(f.Locals[1]);f.Pc=558;continue;}
case 558:{f.Push(JValue.R(rt.String("sVars")));f.Pc=560;continue;}
case 560:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",563);}
case 563:{f.Push(JValue.R(rt.String(",")));f.Pc=565;continue;}
case 565:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",568);}
case 568:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",571);}
case 571:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",576);}
case 576:{f.StackOp("pop");f.Pc=577;continue;}
case 577:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",580);}
case 580:{f.Locals[18]=f.Pop();f.Pc=582;continue;}
case 582:{f.Push(f.Locals[1]);f.Pc=583;continue;}
case 583:{f.Push(JValue.R(rt.String("staticAbilities")));f.Pc=585;continue;}
case 585:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",588);}
case 588:{f.Pc=f.Pop().Int==0?613:591;continue;}
case 591:{f.Push(f.Locals[18]);f.Pc=593;continue;}
case 593:{f.Push(f.Locals[1]);f.Pc=594;continue;}
case 594:{f.Push(JValue.R(rt.String("staticAbilities")));f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",599);}
case 599:{f.Push(JValue.R(rt.String(",")));f.Pc=601;continue;}
case 601:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",604);}
case 604:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",607);}
case 607:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",612);}
case 612:{f.StackOp("pop");f.Pc=613;continue;}
case 613:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",616);}
case 616:{f.Locals[19]=f.Pop();f.Pc=618;continue;}
case 618:{f.Push(f.Locals[17]);f.Pc=620;continue;}
case 620:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",625);}
case 625:{f.Locals[20]=f.Pop();f.Pc=627;continue;}
case 627:{f.Push(f.Locals[20]);f.Pc=629;continue;}
case 629:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",634);}
case 634:{f.Pc=f.Pop().Int==0?668:637;continue;}
case 637:{f.Push(f.Locals[20]);f.Pc=639;continue;}
case 639:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",644);}
case 644:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=647;continue;}
case 647:{f.Locals[21]=f.Pop();f.Pc=649;continue;}
case 649:{f.Push(f.Locals[19]);f.Pc=651;continue;}
case 651:{f.Push(f.Locals[21]);f.Pc=653;continue;}
case 653:{f.Push(f.Locals[1]);f.Pc=654;continue;}
case 654:{f.Push(f.Locals[21]);f.Pc=656;continue;}
case 656:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",659);}
case 659:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",664);}
case 664:{f.StackOp("pop");f.Pc=665;continue;}
case 665:{f.Pc=627;continue;}
case 668:{f.Push(f.Locals[1]);f.Pc=669;continue;}
case 669:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=671;continue;}
case 671:{f.Push(JValue.R(rt.String("")));f.Pc=673;continue;}
case 673:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",676);}
case 676:{f.Locals[20]=f.Pop();f.Pc=678;continue;}
case 678:{f.Push(f.Locals[1]);f.Pc=679;continue;}
case 679:{f.Push(JValue.R(rt.String("Zone")));f.Pc=681;continue;}
case 681:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",684);}
case 684:{f.Pc=f.Pop().Int==0?699:687;continue;}
case 687:{f.Push(f.Locals[1]);f.Pc=688;continue;}
case 688:{f.Push(JValue.R(rt.String("Zone")));f.Pc=690;continue;}
case 690:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",693);}
case 693:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",696);}
case 696:{f.Pc=704;continue;}
case 699:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=701;continue;}
case 701:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",704);}
case 704:{f.Locals[22]=f.Pop();f.Pc=706;continue;}
case 706:{f.Push(f.Locals[1]);f.Pc=707;continue;}
case 707:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",710);}
case 710:{f.Pc=f.Pop().Int!=0?722:713;continue;}
case 713:{f.Push(f.Locals[1]);f.Pc=714;continue;}
case 714:{f.Push(JValue.R(rt.String("Defined")));f.Pc=716;continue;}
case 716:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",719);}
case 719:{f.Pc=f.Pop().Int==0?736:722;continue;}
case 722:{f.Push(f.Locals[1]);f.Pc=723;continue;}
case 723:{return rt.Call(f,"forge/game/ability/effects/AnimateAllEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",726);}
case 726:{f.Push(f.Locals[22]);f.Pc=728;continue;}
case 728:{return rt.Call(f,"forge/game/player/PlayerCollection","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollection;","invokevirtual",731);}
case 731:{f.Locals[21]=f.Pop();f.Pc=733;continue;}
case 733:{f.Pc=745;continue;}
case 736:{f.Push(f.Locals[5]);f.Pc=738;continue;}
case 738:{f.Push(f.Locals[22]);f.Pc=740;continue;}
case 740:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",743);}
case 743:{f.Locals[21]=f.Pop();f.Pc=745;continue;}
case 745:{f.Push(f.Locals[21]);f.Pc=747;continue;}
case 747:{f.Push(f.Locals[20]);f.Pc=749;continue;}
case 749:{f.Push(f.Locals[1]);f.Pc=750;continue;}
case 750:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",753);}
case 753:{f.Locals[21]=f.Pop();f.Pc=755;continue;}
case 755:{f.Push(f.Locals[21]);f.Pc=757;continue;}
case 757:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",762);}
case 762:{f.Locals[23]=f.Pop();f.Pc=764;continue;}
case 764:{f.Push(f.Locals[23]);f.Pc=766;continue;}
case 766:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",771);}
case 771:{f.Pc=f.Pop().Int==0?860:774;continue;}
case 774:{f.Push(f.Locals[23]);f.Pc=776;continue;}
case 776:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",781);}
case 781:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=784;continue;}
case 784:{f.Locals[24]=f.Pop();f.Pc=786;continue;}
case 786:{f.Push(f.Locals[24]);f.Pc=788;continue;}
case 788:{f.Push(f.Locals[1]);f.Pc=789;continue;}
case 789:{f.Push(f.Locals[3]);f.Pc=790;continue;}
case 790:{f.Push(f.Locals[4]);f.Pc=792;continue;}
case 792:{f.Push(f.Locals[8]);f.Pc=794;continue;}
case 794:{f.Push(f.Locals[9]);f.Pc=796;continue;}
case 796:{f.Push(f.Locals[13]);f.Pc=798;continue;}
case 798:{f.Push(f.Locals[10]);f.Pc=800;continue;}
case 800:{f.Push(f.Locals[11]);f.Pc=802;continue;}
case 802:{f.Push(f.Locals[12]);f.Pc=804;continue;}
case 804:{f.Push(f.Locals[14]);f.Pc=806;continue;}
case 806:{f.Push(f.Locals[16]);f.Pc=808;continue;}
case 808:{f.Push(f.Locals[15]);f.Pc=810;continue;}
case 810:{f.Push(f.Locals[18]);f.Pc=812;continue;}
case 812:{f.Push(f.Locals[6]);f.Pc=814;continue;}
case 814:{f.Push(f.Locals[1]);f.Pc=815;continue;}
case 815:{f.Push(JValue.R(rt.String("Duration")));f.Pc=817;continue;}
case 817:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",820);}
case 820:{return rt.Call(f,"forge/game/ability/effects/AnimateAllEffect","doAnimate","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/Integer;Ljava/lang/Integer;Lforge/card/CardType;Lforge/card/CardType;Lforge/card/ColorSet;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;JLjava/lang/String;)V","invokestatic",823);}
case 823:{f.Push(f.Locals[19]);f.Pc=825;continue;}
case 825:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",830);}
case 830:{f.Pc=f.Pop().Int!=0?843:833;continue;}
case 833:{f.Push(f.Locals[24]);f.Pc=835;continue;}
case 835:{f.Push(f.Locals[19]);f.Pc=837;continue;}
case 837:{f.Push(f.Locals[6]);f.Pc=839;continue;}
case 839:{f.Push(JValue.L(0));f.Pc=840;continue;}
case 840:{return rt.Call(f,"forge/game/card/Card","addChangedSVars","(Ljava/util/Map;JJ)V","invokevirtual",843);}
case 843:{f.Push(f.Locals[5]);f.Pc=845;continue;}
case 845:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=848;continue;}
case 848:{f.StackOp("dup");f.Pc=849;continue;}
case 849:{f.Push(f.Locals[24]);f.Pc=851;continue;}
case 851:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",854);}
case 854:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",857);}
case 857:{f.Pc=764;continue;}
case 860:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C290{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DigUntilEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3343,"forge/game/ability/effects/DigUntilEffect","<init>","()V",1,1,1,new JHandler[]{},M3343));
c.Add(new JMethod(3344,"forge/game/ability/effects/DigUntilEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M3344));
c.Add(new JMethod(3345,"forge/game/ability/effects/DigUntilEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,10,5,new JHandler[]{},M3345));
c.Add(new JMethod(3346,"forge/game/ability/effects/DigUntilEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,39,9,new JHandler[]{},M3346));
c.Add(new JMethod(3347,"forge/game/ability/effects/DigUntilEffect","lambda$resolve$0","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M3347));
}

internal static JStep M3343(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3344(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3345(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("ValidDescription")));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Valid")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?58:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Valid")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Push(JValue.R(rt.String("Card")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int!=0?58:34;continue;}
case 34:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",37);}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Valid")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",43);}
case 43:{f.Push(JValue.R(rt.String(",")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",48);}
case 48:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",51);}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/Lang","buildValidDesc","(Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",55);}
case 55:{f.Pc=60;continue;}
case 58:{f.Push(JValue.R(rt.String("Card")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",63);}
case 63:{f.Locals[3]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{f.Locals[4]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(JValue.I(1));f.Pc=68;continue;}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("Amount")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int==0?106:79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Amount")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",85);}
case 85:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",88);}
case 88:{f.Locals[5]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",94);}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("Amount")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",100);}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",104);}
case 104:{f.Locals[4]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/ability/effects/DigUntilEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",112);}
case 112:{f.Push(JValue.R(rt.String("Defined")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/ability/effects/DigUntilEffect","playersOrDescribed","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokestatic",117);}
case 117:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",120);}
case 120:{f.Push(JValue.R(rt.String(" ")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",125);}
case 125:{f.StackOp("pop");f.Pc=126;continue;}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("RevealedDestination")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",132);}
case 132:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",135);}
case 135:{f.Locals[6]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=141;continue;}
case 141:{f.Push(f.Locals[6]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int==0?154:149;continue;}
case 149:{f.Push(JValue.R(rt.String("exiles cards from their library until they exile ")));f.Pc=151;continue;}
case 151:{f.Pc=156;continue;}
case 154:{f.Push(JValue.R(rt.String("reveals cards from their library until revealing ")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",159);}
case 159:{f.StackOp("pop");f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("Card")));f.Pc=162;continue;}
case 162:{f.Push(f.Locals[3]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",166);}
case 166:{f.Pc=f.Pop().Int==0?174:169;continue;}
case 169:{f.Push(JValue.R(rt.String("card")));f.Pc=171;continue;}
case 171:{f.Pc=193;continue;}
case 174:{f.Push(f.Locals[3]);f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.String("(?i).*\\bcards?$")));f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",180);}
case 180:{f.Pc=f.Pop().Int==0?187:183;continue;}
case 183:{f.Push(f.Locals[3]);f.Pc=184;continue;}
case 184:{f.Pc=193;continue;}
case 187:{f.Push(f.Locals[3]);f.Pc=188;continue;}
case 188:{return rt.DynamicCall(f,"forge/game/ability/effects/DigUntilEffect:3345:188:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",193);}
case 193:{f.Locals[7]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[7]);f.Pc=198;continue;}
case 198:{f.Push(JValue.R(rt.String("the ")));f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",203);}
case 203:{f.Pc=f.Pop().Int==0?211:206;continue;}
case 206:{f.Push(f.Locals[7]);f.Pc=208;continue;}
case 208:{f.Pc=236;continue;}
case 211:{f.Push(f.Locals[5]);f.Pc=213;continue;}
case 213:{f.Pc=f.Pop().Int==0?226:216;continue;}
case 216:{f.Push(f.Locals[4]);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[7]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",223);}
case 223:{f.Pc=236;continue;}
case 226:{f.Push(f.Locals[7]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",231);}
case 231:{return rt.DynamicCall(f,"forge/game/ability/effects/DigUntilEffect:3345:231:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",236);}
case 236:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",239);}
case 239:{f.StackOp("pop");f.Pc=240;continue;}
case 240:{f.Push(f.Locals[1]);f.Pc=241;continue;}
case 241:{f.Push(JValue.R(rt.String("MaxRevealed")));f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",246);}
case 246:{f.Pc=f.Pop().Int==0?293:249;continue;}
case 249:{f.Push(f.Locals[1]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",253);}
case 253:{f.Push(f.Locals[1]);f.Pc=254;continue;}
case 254:{f.Push(JValue.R(rt.String("MaxRevealed")));f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",259);}
case 259:{f.Push(f.Locals[1]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",263);}
case 263:{f.Locals[8]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[2]);f.Pc=266;continue;}
case 266:{f.Push(JValue.R(rt.String(" or ")));f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",271);}
case 271:{f.Push(f.Locals[8]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",276);}
case 276:{f.Push(f.Locals[8]);f.Pc=278;continue;}
case 278:{f.Push(JValue.I(1));f.Pc=279;continue;}
case 279:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?287:282;continue;}
case 282:{f.Push(JValue.R(rt.String(" card")));f.Pc=284;continue;}
case 284:{f.Pc=289;continue;}
case 287:{f.Push(JValue.R(rt.String(" cards")));f.Pc=289;continue;}
case 289:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",292);}
case 292:{f.StackOp("pop");f.Pc=293;continue;}
case 293:{f.Push(f.Locals[2]);f.Pc=294;continue;}
case 294:{f.Push(JValue.R(rt.String(".")));f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",299);}
case 299:{f.StackOp("pop");f.Pc=300;continue;}
case 300:{f.Push(f.Locals[1]);f.Pc=301;continue;}
case 301:{f.Push(JValue.R(rt.String("NoPutDesc")));f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",306);}
case 306:{f.Pc=f.Pop().Int!=0?551:309;continue;}
case 309:{f.Push(f.Locals[2]);f.Pc=310;continue;}
case 310:{f.Push(JValue.R(rt.String(" Put ")));f.Pc=312;continue;}
case 312:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",315);}
case 315:{f.StackOp("pop");f.Pc=316;continue;}
case 316:{f.Push(f.Locals[1]);f.Pc=317;continue;}
case 317:{f.Push(JValue.R(rt.String("FoundDestination")));f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",322);}
case 322:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",325);}
case 325:{f.Locals[8]=f.Pop();f.Pc=327;continue;}
case 327:{f.Push(f.Locals[8]);f.Pc=329;continue;}
case 329:{f.Pc=f.Pop().Reference==null?528:332;continue;}
case 332:{f.Push(f.Locals[2]);f.Pc=333;continue;}
case 333:{f.Push(f.Locals[4]);f.Pc=335;continue;}
case 335:{f.Push(JValue.I(1));f.Pc=336;continue;}
case 336:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?344:339;continue;}
case 339:{f.Push(f.Locals[5]);f.Pc=341;continue;}
case 341:{f.Pc=f.Pop().Int!=0?349:344;continue;}
case 344:{f.Push(JValue.R(rt.String("those cards")));f.Pc=346;continue;}
case 346:{f.Pc=351;continue;}
case 349:{f.Push(JValue.R(rt.String("that card")));f.Pc=351;continue;}
case 351:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",354);}
case 354:{f.StackOp("pop");f.Pc=355;continue;}
case 355:{f.Push(f.Locals[2]);f.Pc=356;continue;}
case 356:{f.Push(JValue.R(rt.String(" ")));f.Pc=358;continue;}
case 358:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",361);}
case 361:{f.StackOp("pop");f.Pc=362;continue;}
case 362:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=365;continue;}
case 365:{f.Push(f.Locals[8]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",370);}
case 370:{f.Pc=f.Pop().Int==0?380:373;continue;}
case 373:{f.Push(f.Locals[2]);f.Pc=374;continue;}
case 374:{f.Push(JValue.R(rt.String("into their hand ")));f.Pc=376;continue;}
case 376:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",379);}
case 379:{f.StackOp("pop");f.Pc=380;continue;}
case 380:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=383;continue;}
case 383:{f.Push(f.Locals[8]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",388);}
case 388:{f.Pc=f.Pop().Int==0?414:391;continue;}
case 391:{f.Push(f.Locals[2]);f.Pc=392;continue;}
case 392:{f.Push(JValue.R(rt.String("onto the battlefield ")));f.Pc=394;continue;}
case 394:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",397);}
case 397:{f.StackOp("pop");f.Pc=398;continue;}
case 398:{f.Push(f.Locals[1]);f.Pc=399;continue;}
case 399:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",404);}
case 404:{f.Pc=f.Pop().Int==0?414:407;continue;}
case 407:{f.Push(f.Locals[2]);f.Pc=408;continue;}
case 408:{f.Push(JValue.R(rt.String("tapped ")));f.Pc=410;continue;}
case 410:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",413);}
case 413:{f.StackOp("pop");f.Pc=414;continue;}
case 414:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=417;continue;}
case 417:{f.Push(f.Locals[6]);f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",422);}
case 422:{f.Pc=f.Pop().Int==0?432:425;continue;}
case 425:{f.Push(f.Locals[2]);f.Pc=426;continue;}
case 426:{f.Push(JValue.R(rt.String("and all other cards into their graveyard.")));f.Pc=428;continue;}
case 428:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",431);}
case 431:{f.StackOp("pop");f.Pc=432;continue;}
case 432:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=435;continue;}
case 435:{f.Push(f.Locals[6]);f.Pc=437;continue;}
case 437:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",440);}
case 440:{f.Pc=f.Pop().Int==0?450:443;continue;}
case 443:{f.Push(f.Locals[2]);f.Pc=444;continue;}
case 444:{f.Push(JValue.R(rt.String("and exile all other cards revealed this way.")));f.Pc=446;continue;}
case 446:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",449);}
case 449:{f.StackOp("pop");f.Pc=450;continue;}
case 450:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=453;continue;}
case 453:{f.Push(f.Locals[6]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",458);}
case 458:{f.Pc=f.Pop().Int==0?551:461;continue;}
case 461:{f.Push(f.Locals[1]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",465);}
case 465:{f.Push(f.Locals[1]);f.Pc=466;continue;}
case 466:{f.Push(JValue.R(rt.String("RevealedLibraryPosition")));f.Pc=468;continue;}
case 468:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",471);}
case 471:{f.Push(f.Locals[1]);f.Pc=472;continue;}
case 472:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",475);}
case 475:{f.Locals[9]=f.Pop();f.Pc=477;continue;}
case 477:{f.Push(f.Locals[2]);f.Pc=478;continue;}
case 478:{f.Push(JValue.R(rt.String("and the rest on ")));f.Pc=480;continue;}
case 480:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",483);}
case 483:{f.Push(f.Locals[9]);f.Pc=485;continue;}
case 485:{f.Pc=f.Pop().Int>=0?493:488;continue;}
case 488:{f.Push(JValue.R(rt.String("the bottom ")));f.Pc=490;continue;}
case 490:{f.Pc=495;continue;}
case 493:{f.Push(JValue.R(rt.String("top ")));f.Pc=495;continue;}
case 495:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",498);}
case 498:{f.StackOp("pop");f.Pc=499;continue;}
case 499:{f.Push(f.Locals[2]);f.Pc=500;continue;}
case 500:{f.Push(JValue.R(rt.String("of their library")));f.Pc=502;continue;}
case 502:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",505);}
case 505:{f.Push(f.Locals[1]);f.Pc=506;continue;}
case 506:{f.Push(JValue.R(rt.String("RevealRandomOrder")));f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",511);}
case 511:{f.Pc=f.Pop().Int==0?519:514;continue;}
case 514:{f.Push(JValue.R(rt.String(" in a random order.")));f.Pc=516;continue;}
case 516:{f.Pc=521;continue;}
case 519:{f.Push(JValue.R(rt.String(".")));f.Pc=521;continue;}
case 521:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",524);}
case 524:{f.StackOp("pop");f.Pc=525;continue;}
case 525:{f.Pc=551;continue;}
case 528:{f.Push(f.Locals[6]);f.Pc=530;continue;}
case 530:{f.Pc=f.Pop().Reference==null?551:533;continue;}
case 533:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=536;continue;}
case 536:{f.Push(f.Locals[6]);f.Pc=538;continue;}
case 538:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",541);}
case 541:{f.Pc=f.Pop().Int==0?551:544;continue;}
case 544:{f.Push(f.Locals[2]);f.Pc=545;continue;}
case 545:{f.Push(JValue.R(rt.String("all cards revealed this way into their hand")));f.Pc=547;continue;}
case 547:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",550);}
case 550:{f.StackOp("pop");f.Pc=551;continue;}
case 551:{f.Push(f.Locals[2]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",555);}
case 555:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3346(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Amount")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?41:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Amount")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",33);}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Pc=f.Pop().Int!=0?41:40;continue;}
case 40:{return JStep.ReturnVoid;}
case 41:{f.Push(JValue.R(null));f.Pc=42;continue;}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("MaxRevealed")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?69:53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("MaxRevealed")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",60);}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",64);}
case 64:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",67);}
case 67:{f.Locals[5]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(JValue.R(null));f.Pc=70;continue;}
case 70:{f.Locals[6]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("MinTotalCMC")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?97:81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("MinTotalCMC")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",88);}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",92);}
case 92:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",95);}
case 95:{f.Locals[6]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(JValue.I(1));f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=101;continue;}
case 101:{f.StackOp("dup");f.Pc=102;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("Card")));f.Pc=105;continue;}
case 105:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=106;continue;}
case 106:{f.Locals[7]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("Valid")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?130:117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("Valid")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",123);}
case 123:{f.Push(JValue.R(rt.String(",")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",128);}
case 128:{f.Locals[7]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String("RememberFound")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",136);}
case 136:{f.Locals[8]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("ImprintFound")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",144);}
case 144:{f.Locals[9]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String("FoundDestination")));f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",152);}
case 152:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",155);}
case 155:{f.Locals[10]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("OptionalNoDestination")));f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("None")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",165);}
case 165:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",168);}
case 168:{f.Locals[11]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[2]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("FoundLibraryPosition")));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",177);}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",181);}
case 181:{f.Locals[12]=f.Pop();f.Pc=183;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("RevealedDestination")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",189);}
case 189:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",192);}
case 192:{f.Locals[13]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[2]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[1]);f.Pc=196;continue;}
case 196:{f.Push(JValue.R(rt.String("RevealedLibraryPosition")));f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",201);}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",205);}
case 205:{f.Locals[14]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(f.Locals[1]);f.Pc=208;continue;}
case 208:{f.Push(JValue.R(rt.String("NoneFoundDestination")));f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",213);}
case 213:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",216);}
case 216:{f.Locals[15]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[2]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[1]);f.Pc=220;continue;}
case 220:{f.Push(JValue.R(rt.String("NoneFoundLibraryPosition")));f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",225);}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",229);}
case 229:{f.Locals[16]=f.Pop();f.Pc=231;continue;}
case 231:{f.Push(f.Locals[1]);f.Pc=232;continue;}
case 232:{f.Push(JValue.R(rt.String("DigZone")));f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",237);}
case 237:{f.Pc=f.Pop().Int==0?252:240;continue;}
case 240:{f.Push(f.Locals[1]);f.Pc=241;continue;}
case 241:{f.Push(JValue.R(rt.String("DigZone")));f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",246);}
case 246:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",249);}
case 249:{f.Pc=255;continue;}
case 252:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=255;continue;}
case 255:{f.Locals[17]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[1]);f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String("Shuffle")));f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",263);}
case 263:{f.Locals[18]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[1]);f.Pc=266;continue;}
case 266:{f.Push(JValue.R(rt.String("Optional")));f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",271);}
case 271:{f.Locals[19]=f.Pop();f.Pc=273;continue;}
case 273:{f.Push(f.Locals[1]);f.Pc=274;continue;}
case 274:{f.Push(JValue.R(rt.String("OptionalFoundMove")));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",279);}
case 279:{f.Locals[20]=f.Pop();f.Pc=281;continue;}
case 281:{f.Push(f.Locals[17]);f.Pc=283;continue;}
case 283:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=286;continue;}
case 286:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?308:289;continue;}
case 289:{f.Push(f.Locals[13]);f.Pc=291;continue;}
case 291:{f.Pc=f.Pop().Reference==null?308:294;continue;}
case 294:{f.Push(f.Locals[13]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[10]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",301);}
case 301:{f.Pc=f.Pop().Int==0?308:304;continue;}
case 304:{f.Push(JValue.I(1));f.Pc=305;continue;}
case 305:{f.Pc=309;continue;}
case 308:{f.Push(JValue.I(0));f.Pc=309;continue;}
case 309:{f.Locals[21]=f.Pop();f.Pc=311;continue;}
case 311:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=314;continue;}
case 314:{f.StackOp("dup");f.Pc=315;continue;}
case 315:{f.Push(f.Locals[3]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/Game","copyLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",319);}
case 319:{f.Push(f.Locals[3]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/Game","copyLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",323);}
case 323:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",326);}
case 326:{f.Locals[22]=f.Pop();f.Pc=328;continue;}
case 328:{f.Push(JValue.R(null));f.Pc=329;continue;}
case 329:{f.Locals[23]=f.Pop();f.Pc=331;continue;}
case 331:{f.Push(f.Locals[21]);f.Pc=333;continue;}
case 333:{f.Pc=f.Pop().Int!=0?355:336;continue;}
case 336:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=339;continue;}
case 339:{f.StackOp("dup");f.Pc=340;continue;}
case 340:{f.Push(f.Locals[22]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",345);}
case 345:{f.Push(f.Locals[22]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",350);}
case 350:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",353);}
case 353:{f.Locals[23]=f.Pop();f.Pc=355;continue;}
case 355:{f.Push(JValue.I(0));f.Pc=356;continue;}
case 356:{f.Locals[24]=f.Pop();f.Pc=358;continue;}
case 358:{f.Push(f.Locals[1]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/ability/effects/DigUntilEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",362);}
case 362:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",365);}
case 365:{f.Locals[25]=f.Pop();f.Pc=367;continue;}
case 367:{f.Push(f.Locals[25]);f.Pc=369;continue;}
case 369:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",374);}
case 374:{f.Pc=f.Pop().Int==0?1519:377;continue;}
case 377:{f.Push(f.Locals[25]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",384);}
case 384:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=387;continue;}
case 387:{f.Locals[26]=f.Pop();f.Pc=389;continue;}
case 389:{f.Push(f.Locals[26]);f.Pc=391;continue;}
case 391:{f.Pc=f.Pop().Reference==null?367:394;continue;}
case 394:{f.Push(f.Locals[26]);f.Pc=396;continue;}
case 396:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",399);}
case 399:{f.Pc=f.Pop().Int!=0?405:402;continue;}
case 402:{f.Pc=367;continue;}
case 405:{f.Push(f.Locals[19]);f.Pc=407;continue;}
case 407:{f.Pc=f.Pop().Int==0?440:410;continue;}
case 410:{f.Push(f.Locals[26]);f.Pc=412;continue;}
case 412:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",415);}
case 415:{f.Push(f.Locals[1]);f.Pc=416;continue;}
case 416:{f.Push(JValue.R(null));f.Pc=417;continue;}
case 417:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",420);}
case 420:{f.Push(JValue.R(rt.String("lblDoYouWantDigYourLibrary")));f.Pc=423;continue;}
case 423:{f.Push(JValue.I(0));f.Pc=424;continue;}
case 424:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=427;continue;}
case 427:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",430);}
case 430:{f.Push(JValue.R(null));f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",434);}
case 434:{f.Pc=f.Pop().Int!=0?440:437;continue;}
case 437:{f.Pc=367;continue;}
case 440:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=443;continue;}
case 443:{f.StackOp("dup");f.Pc=444;continue;}
case 444:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",447);}
case 447:{f.Locals[27]=f.Pop();f.Pc=449;continue;}
case 449:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=452;continue;}
case 452:{f.StackOp("dup");f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",456);}
case 456:{f.Locals[28]=f.Pop();f.Pc=458;continue;}
case 458:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=461;continue;}
case 461:{f.StackOp("dup");f.Pc=462;continue;}
case 462:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",465);}
case 465:{f.Locals[29]=f.Pop();f.Pc=467;continue;}
case 467:{f.Push(f.Locals[6]);f.Pc=469;continue;}
case 469:{f.Locals[30]=f.Pop();f.Pc=471;continue;}
case 471:{f.Push(f.Locals[26]);f.Pc=473;continue;}
case 473:{f.Push(f.Locals[17]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",478);}
case 478:{f.Locals[31]=f.Pop();f.Pc=480;continue;}
case 480:{f.Push(f.Locals[31]);f.Pc=482;continue;}
case 482:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",485);}
case 485:{f.Locals[32]=f.Pop();f.Pc=487;continue;}
case 487:{f.Push(f.Locals[5]);f.Pc=489;continue;}
case 489:{f.Pc=f.Pop().Reference==null?504:492;continue;}
case 492:{f.Push(f.Locals[5]);f.Pc=494;continue;}
case 494:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",497);}
case 497:{f.Push(f.Locals[32]);f.Pc=499;continue;}
case 499:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",502);}
case 502:{f.Locals[32]=f.Pop();f.Pc=504;continue;}
case 504:{f.Push(JValue.I(0));f.Pc=505;continue;}
case 505:{f.Locals[33]=f.Pop();f.Pc=507;continue;}
case 507:{f.Push(f.Locals[33]);f.Pc=509;continue;}
case 509:{f.Push(f.Locals[32]);f.Pc=511;continue;}
case 511:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?642:514;continue;}
case 514:{f.Push(f.Locals[31]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[33]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"forge/game/zone/PlayerZone","get","(I)Lforge/game/card/Card;","invokevirtual",521);}
case 521:{f.Locals[34]=f.Pop();f.Pc=523;continue;}
case 523:{f.Push(f.Locals[28]);f.Pc=525;continue;}
case 525:{f.Push(f.Locals[34]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",530);}
case 530:{f.StackOp("pop");f.Pc=531;continue;}
case 531:{f.Push(f.Locals[30]);f.Pc=533;continue;}
case 533:{f.Pc=f.Pop().Reference==null?563:536;continue;}
case 536:{f.Push(f.Locals[30]);f.Pc=538;continue;}
case 538:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",541);}
case 541:{f.Push(f.Locals[34]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",546);}
case 546:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=547;continue;}
case 547:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",550);}
case 550:{f.Locals[30]=f.Pop();f.Pc=552;continue;}
case 552:{f.Push(f.Locals[30]);f.Pc=554;continue;}
case 554:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",557);}
case 557:{f.Pc=f.Pop().Int>0?636:560;continue;}
case 560:{f.Pc=642;continue;}
case 563:{f.Push(f.Locals[34]);f.Pc=565;continue;}
case 565:{f.Push(f.Locals[7]);f.Pc=567;continue;}
case 567:{f.Push(f.Locals[1]);f.Pc=568;continue;}
case 568:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",571);}
case 571:{f.Push(f.Locals[2]);f.Pc=572;continue;}
case 572:{f.Push(f.Locals[1]);f.Pc=573;continue;}
case 573:{return rt.Call(f,"forge/game/card/Card","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",576);}
case 576:{f.Pc=f.Pop().Int==0?636:579;continue;}
case 579:{f.Push(f.Locals[27]);f.Pc=581;continue;}
case 581:{f.Push(f.Locals[34]);f.Pc=583;continue;}
case 583:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",586);}
case 586:{f.StackOp("pop");f.Pc=587;continue;}
case 587:{f.Push(f.Locals[1]);f.Pc=588;continue;}
case 588:{f.Push(JValue.R(rt.String("ForgetOtherRemembered")));f.Pc=591;continue;}
case 591:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",594);}
case 594:{f.Pc=f.Pop().Int==0?601:597;continue;}
case 597:{f.Push(f.Locals[2]);f.Pc=598;continue;}
case 598:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",601);}
case 601:{f.Push(f.Locals[8]);f.Pc=603;continue;}
case 603:{f.Pc=f.Pop().Int==0?612:606;continue;}
case 606:{f.Push(f.Locals[2]);f.Pc=607;continue;}
case 607:{f.Push(f.Locals[34]);f.Pc=609;continue;}
case 609:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",612);}
case 612:{f.Push(f.Locals[9]);f.Pc=614;continue;}
case 614:{f.Pc=f.Pop().Int==0?623:617;continue;}
case 617:{f.Push(f.Locals[2]);f.Pc=618;continue;}
case 618:{f.Push(f.Locals[34]);f.Pc=620;continue;}
case 620:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",623);}
case 623:{f.Push(f.Locals[27]);f.Pc=625;continue;}
case 625:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",628);}
case 628:{f.Push(f.Locals[4]);f.Pc=630;continue;}
case 630:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?636:633;continue;}
case 633:{f.Pc=642;continue;}
case 636:{f.Locals[33]=JValue.I(unchecked(f.Locals[33].Int+(1)));f.Pc=639;continue;}
case 639:{f.Pc=507;continue;}
case 642:{f.Push(f.Locals[18]);f.Pc=644;continue;}
case 644:{f.Pc=f.Pop().Int==0?680:647;continue;}
case 647:{f.Push(f.Locals[1]);f.Pc=648;continue;}
case 648:{f.Push(JValue.R(rt.String("ShuffleCondition")));f.Pc=651;continue;}
case 651:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",654);}
case 654:{f.Pc=f.Pop().Int==0?680:657;continue;}
case 657:{f.Push(f.Locals[1]);f.Pc=658;continue;}
case 658:{f.Push(JValue.R(rt.String("ShuffleCondition")));f.Pc=661;continue;}
case 661:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",664);}
case 664:{f.Push(JValue.R(rt.String("NoneFound")));f.Pc=667;continue;}
case 667:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",670);}
case 670:{f.Pc=f.Pop().Int==0?680:673;continue;}
case 673:{f.Push(f.Locals[27]);f.Pc=675;continue;}
case 675:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",678);}
case 678:{f.Locals[18]=f.Pop();f.Pc=680;continue;}
case 680:{f.Push(f.Locals[28]);f.Pc=682;continue;}
case 682:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",685);}
case 685:{f.Pc=f.Pop().Int<=0?700:688;continue;}
case 688:{f.Push(f.Locals[3]);f.Pc=689;continue;}
case 689:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",692);}
case 692:{f.Push(f.Locals[28]);f.Pc=694;continue;}
case 694:{f.Push(f.Locals[26]);f.Pc=696;continue;}
case 696:{f.Push(JValue.I(0));f.Pc=697;continue;}
case 697:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;Z)V","invokevirtual",700);}
case 700:{f.Push(f.Locals[10]);f.Pc=702;continue;}
case 702:{f.Pc=f.Pop().Reference==null?1197:705;continue;}
case 705:{f.Push(f.Locals[21]);f.Pc=707;continue;}
case 707:{f.Pc=f.Pop().Int==0?720:710;continue;}
case 710:{f.Push(f.Locals[28]);f.Pc=712;continue;}
case 712:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",715);}
case 715:{f.Locals[33]=f.Pop();f.Pc=717;continue;}
case 717:{f.Pc=727;continue;}
case 720:{f.Push(f.Locals[27]);f.Pc=722;continue;}
case 722:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",725);}
case 725:{f.Locals[33]=f.Pop();f.Pc=727;continue;}
case 727:{f.Push(f.Locals[33]);f.Pc=729;continue;}
case 729:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",734);}
case 734:{f.Pc=f.Pop().Int==0?1189:737;continue;}
case 737:{f.Push(f.Locals[33]);f.Pc=739;continue;}
case 739:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",744);}
case 744:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=747;continue;}
case 747:{f.Locals[34]=f.Pop();f.Pc=749;continue;}
case 749:{f.Push(f.Locals[20]);f.Pc=751;continue;}
case 751:{f.Pc=f.Pop().Int==0?816:754;continue;}
case 754:{f.Push(f.Locals[26]);f.Pc=756;continue;}
case 756:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",759);}
case 759:{f.Push(f.Locals[1]);f.Pc=760;continue;}
case 760:{f.Push(JValue.R(null));f.Pc=761;continue;}
case 761:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",764);}
case 764:{f.Push(JValue.R(rt.String("lblDoYouWantPutCardToZone")));f.Pc=767;continue;}
case 767:{f.Push(JValue.I(1));f.Pc=768;continue;}
case 768:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=771;continue;}
case 771:{f.StackOp("dup");f.Pc=772;continue;}
case 772:{f.Push(JValue.I(0));f.Pc=773;continue;}
case 773:{f.Push(f.Locals[10]);f.Pc=775;continue;}
case 775:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",778);}
case 778:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=779;continue;}
case 779:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",782);}
case 782:{f.Push(f.Locals[34]);f.Pc=784;continue;}
case 784:{f.Push(JValue.R(null));f.Pc=785;continue;}
case 785:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",788);}
case 788:{f.Pc=f.Pop().Int!=0?816:791;continue;}
case 791:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=794;continue;}
case 794:{f.Push(f.Locals[11]);f.Pc=796;continue;}
case 796:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",799);}
case 799:{f.Pc=f.Pop().Int==0?812:802;continue;}
case 802:{f.Push(f.Locals[33]);f.Pc=804;continue;}
case 804:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",809);}
case 809:{f.Pc=727;continue;}
case 812:{f.Push(f.Locals[11]);f.Pc=814;continue;}
case 814:{f.Locals[10]=f.Pop();f.Pc=816;continue;}
case 816:{f.Push(f.Locals[21]);f.Pc=818;continue;}
case 818:{f.Pc=f.Pop().Int==0?840:821;continue;}
case 821:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=824;continue;}
case 824:{f.StackOp("dup");f.Pc=825;continue;}
case 825:{f.Push(f.Locals[22]);f.Pc=827;continue;}
case 827:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",830);}
case 830:{f.Push(f.Locals[22]);f.Pc=832;continue;}
case 832:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",835);}
case 835:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",838);}
case 838:{f.Locals[23]=f.Pop();f.Pc=840;continue;}
case 840:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",843);}
case 843:{f.Locals[35]=f.Pop();f.Pc=845;continue;}
case 845:{f.Push(f.Locals[35]);f.Pc=847;continue;}
case 847:{f.Push(f.Locals[23]);f.Pc=849;continue;}
case 849:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",852);}
case 852:{f.Push(f.Locals[10]);f.Pc=854;continue;}
case 854:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=857;continue;}
case 857:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",860);}
case 860:{f.Pc=f.Pop().Int==0?1121:863;continue;}
case 863:{f.Push(f.Locals[35]);f.Pc=865;continue;}
case 865:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"));f.Pc=868;continue;}
case 868:{f.Push(f.Locals[27]);f.Pc=870;continue;}
case 870:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",875);}
case 875:{f.StackOp("pop");f.Pc=876;continue;}
case 876:{f.Push(f.Locals[1]);f.Pc=877;continue;}
case 877:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=880;continue;}
case 880:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",883);}
case 883:{f.Pc=f.Pop().Int==0?899:886;continue;}
case 886:{f.Push(f.Locals[34]);f.Pc=888;continue;}
case 888:{f.Push(f.Locals[1]);f.Pc=889;continue;}
case 889:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",892);}
case 892:{f.Push(f.Locals[3]);f.Pc=893;continue;}
case 893:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",896);}
case 896:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",899);}
case 899:{f.Push(f.Locals[1]);f.Pc=900;continue;}
case 900:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=903;continue;}
case 903:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",906);}
case 906:{f.Pc=f.Pop().Int==0?1070:909;continue;}
case 909:{f.Push(f.Locals[34]);f.Pc=911;continue;}
case 911:{f.Push(f.Locals[1]);f.Pc=912;continue;}
case 912:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=915;continue;}
case 915:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",918);}
case 918:{f.Push(f.Locals[1]);f.Pc=919;continue;}
case 919:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",922);}
case 922:{f.Locals[36]=f.Pop();f.Pc=924;continue;}
case 924:{f.Push(f.Locals[36]);f.Pc=926;continue;}
case 926:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",929);}
case 929:{f.Pc=f.Pop().Int==0?957:932;continue;}
case 932:{f.Push(f.Locals[22]);f.Pc=934;continue;}
case 934:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",937);}
case 937:{f.Push(f.Locals[1]);f.Pc=938;continue;}
case 938:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=941;continue;}
case 941:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",944);}
case 944:{f.Push(f.Locals[34]);f.Pc=946;continue;}
case 946:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",949);}
case 949:{f.Push(f.Locals[34]);f.Pc=951;continue;}
case 951:{f.Push(f.Locals[1]);f.Pc=952;continue;}
case 952:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",955);}
case 955:{f.Locals[36]=f.Pop();f.Pc=957;continue;}
case 957:{f.Push(f.Locals[36]);f.Pc=959;continue;}
case 959:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",962);}
case 962:{f.Pc=f.Pop().Int!=0?978:965;continue;}
case 965:{f.Push(f.Locals[36]);f.Pc=967;continue;}
case 967:{f.Push(f.Locals[34]);f.Pc=969;continue;}
case 969:{f.Push(f.Locals[1]);f.Pc=970;continue;}
case 970:{return rt.Call(f,"forge/game/card/CardPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;","invokestatic",973);}
case 973:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",976);}
case 976:{f.Locals[36]=f.Pop();f.Pc=978;continue;}
case 978:{f.Push(f.Locals[36]);f.Pc=980;continue;}
case 980:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",983);}
case 983:{f.Pc=f.Pop().Int!=0?1059:986;continue;}
case 986:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",989);}
case 989:{f.Locals[37]=f.Pop();f.Pc=991;continue;}
case 991:{f.Push(f.Locals[37]);f.Pc=993;continue;}
case 993:{f.Push(JValue.R(rt.String("Attach")));f.Pc=996;continue;}
case 996:{f.Push(f.Locals[34]);f.Pc=998;continue;}
case 998:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1003);}
case 1003:{f.StackOp("pop");f.Pc=1004;continue;}
case 1004:{f.Push(f.Locals[26]);f.Pc=1006;continue;}
case 1006:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1009);}
case 1009:{f.Push(f.Locals[36]);f.Pc=1011;continue;}
case 1011:{f.Push(f.Locals[1]);f.Pc=1012;continue;}
case 1012:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1015);}
case 1015:{f.Push(JValue.R(rt.String("lblSelectACardAttachSourceTo")));f.Pc=1018;continue;}
case 1018:{f.Push(JValue.I(1));f.Pc=1019;continue;}
case 1019:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1022;continue;}
case 1022:{f.StackOp("dup");f.Pc=1023;continue;}
case 1023:{f.Push(JValue.I(0));f.Pc=1024;continue;}
case 1024:{f.Push(f.Locals[34]);f.Pc=1026;continue;}
case 1026:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",1029);}
case 1029:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1030;continue;}
case 1030:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1033);}
case 1033:{f.Push(f.Locals[37]);f.Pc=1035;continue;}
case 1035:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",1038);}
case 1038:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1041;continue;}
case 1041:{f.Locals[38]=f.Pop();f.Pc=1043;continue;}
case 1043:{f.Push(f.Locals[34]);f.Pc=1045;continue;}
case 1045:{f.Push(f.Locals[3]);f.Pc=1046;continue;}
case 1046:{f.Push(f.Locals[38]);f.Pc=1048;continue;}
case 1048:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",1051);}
case 1051:{f.Push(f.Locals[1]);f.Pc=1052;continue;}
case 1052:{f.Push(JValue.I(1));f.Pc=1053;continue;}
case 1053:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;Z)V","invokevirtual",1056);}
case 1056:{f.Pc=1070;continue;}
case 1059:{f.Push(f.Locals[34]);f.Pc=1061;continue;}
case 1061:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",1064);}
case 1064:{f.Pc=f.Pop().Int==0?1070:1067;continue;}
case 1067:{f.Pc=727;continue;}
case 1070:{f.Push(f.Locals[1]);f.Pc=1071;continue;}
case 1071:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=1073;continue;}
case 1073:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1076);}
case 1076:{f.Pc=f.Pop().Int==0?1085:1079;continue;}
case 1079:{f.Push(f.Locals[34]);f.Pc=1081;continue;}
case 1081:{f.Push(JValue.I(1));f.Pc=1082;continue;}
case 1082:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",1085);}
case 1085:{f.Push(f.Locals[3]);f.Pc=1086;continue;}
case 1086:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1089);}
case 1089:{f.Push(f.Locals[10]);f.Pc=1091;continue;}
case 1091:{f.Push(f.Locals[34]);f.Pc=1093;continue;}
case 1093:{f.Push(f.Locals[1]);f.Pc=1094;continue;}
case 1094:{f.Push(f.Locals[35]);f.Pc=1096;continue;}
case 1096:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",1099);}
case 1099:{f.StackOp("pop");f.Pc=1100;continue;}
case 1100:{f.Push(f.Locals[34]);f.Pc=1102;continue;}
case 1102:{f.Push(f.Locals[1]);f.Pc=1103;continue;}
case 1103:{f.Push(JValue.R(rt.String("Attacking")));f.Pc=1106;continue;}
case 1106:{f.Push(JValue.R(rt.String("Blocking")));f.Pc=1109;continue;}
case 1109:{return rt.Call(f,"forge/game/ability/effects/DigUntilEffect","addToCombat","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/String;)Z","invokestatic",1112);}
case 1112:{f.Pc=f.Pop().Int==0?1174:1115;continue;}
case 1115:{f.Push(JValue.I(1));f.Pc=1116;continue;}
case 1116:{f.Locals[24]=f.Pop();f.Pc=1118;continue;}
case 1118:{f.Pc=1174;continue;}
case 1121:{f.Push(f.Locals[1]);f.Pc=1122;continue;}
case 1122:{f.Push(JValue.R(rt.String("NoMoveFound")));f.Pc=1125;continue;}
case 1125:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1128);}
case 1128:{f.Pc=f.Pop().Int==0?1134:1131;continue;}
case 1131:{f.Pc=1174;continue;}
case 1134:{f.Push(f.Locals[3]);f.Pc=1135;continue;}
case 1135:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1138);}
case 1138:{f.Push(f.Locals[10]);f.Pc=1140;continue;}
case 1140:{f.Push(f.Locals[34]);f.Pc=1142;continue;}
case 1142:{f.Push(f.Locals[12]);f.Pc=1144;continue;}
case 1144:{f.Push(f.Locals[1]);f.Pc=1145;continue;}
case 1145:{f.Push(f.Locals[35]);f.Pc=1147;continue;}
case 1147:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",1150);}
case 1150:{f.Locals[34]=f.Pop();f.Pc=1152;continue;}
case 1152:{f.Push(f.Locals[29]);f.Pc=1154;continue;}
case 1154:{f.Push(f.Locals[34]);f.Pc=1156;continue;}
case 1156:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1159);}
case 1159:{f.StackOp("pop");f.Pc=1160;continue;}
case 1160:{f.Push(f.Locals[10]);f.Pc=1162;continue;}
case 1162:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=1165;continue;}
case 1165:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1174:1168;continue;}
case 1168:{f.Push(f.Locals[34]);f.Pc=1170;continue;}
case 1170:{f.Push(f.Locals[1]);f.Pc=1171;continue;}
case 1171:{return rt.Call(f,"forge/game/ability/effects/DigUntilEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",1174);}
case 1174:{f.Push(f.Locals[21]);f.Pc=1176;continue;}
case 1176:{f.Pc=f.Pop().Int==0?1186:1179;continue;}
case 1179:{f.Push(f.Locals[23]);f.Pc=1181;continue;}
case 1181:{f.Push(f.Locals[3]);f.Pc=1182;continue;}
case 1182:{f.Push(f.Locals[1]);f.Pc=1183;continue;}
case 1183:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1186);}
case 1186:{f.Pc=727;continue;}
case 1189:{f.Push(f.Locals[28]);f.Pc=1191;continue;}
case 1191:{f.Push(f.Locals[27]);f.Pc=1193;continue;}
case 1193:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",1196);}
case 1196:{f.StackOp("pop");f.Pc=1197;continue;}
case 1197:{f.Push(f.Locals[1]);f.Pc=1198;continue;}
case 1198:{f.Push(JValue.R(rt.String("RememberRevealed")));f.Pc=1201;continue;}
case 1201:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1204);}
case 1204:{f.Pc=f.Pop().Int==0?1213:1207;continue;}
case 1207:{f.Push(f.Locals[2]);f.Pc=1208;continue;}
case 1208:{f.Push(f.Locals[28]);f.Pc=1210;continue;}
case 1210:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1213);}
case 1213:{f.Push(f.Locals[1]);f.Pc=1214;continue;}
case 1214:{f.Push(JValue.R(rt.String("ImprintRevealed")));f.Pc=1217;continue;}
case 1217:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1220);}
case 1220:{f.Pc=f.Pop().Int==0?1229:1223;continue;}
case 1223:{f.Push(f.Locals[2]);f.Pc=1224;continue;}
case 1224:{f.Push(f.Locals[28]);f.Pc=1226;continue;}
case 1226:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",1229);}
case 1229:{f.Push(f.Locals[1]);f.Pc=1230;continue;}
case 1230:{f.Push(JValue.R(rt.String("RevealRandomOrder")));f.Pc=1232;continue;}
case 1232:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1235);}
case 1235:{f.Pc=f.Pop().Int==0?1246:1238;continue;}
case 1238:{f.Push(f.Locals[28]);f.Pc=1240;continue;}
case 1240:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",1243);}
case 1243:{return rt.Call(f,"java/util/Collections","shuffle","(Ljava/util/List;Ljava/util/Random;)V","invokestatic",1246);}
case 1246:{f.Push(f.Locals[1]);f.Pc=1247;continue;}
case 1247:{f.Push(JValue.R(rt.String("NoMoveRevealed")));f.Pc=1250;continue;}
case 1250:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1253);}
case 1253:{f.Pc=f.Pop().Int!=0?1432:1256;continue;}
case 1256:{f.Push(f.Locals[21]);f.Pc=1258;continue;}
case 1258:{f.Pc=f.Pop().Int==0?1264:1261;continue;}
case 1261:{f.Pc=1432;continue;}
case 1264:{f.Push(f.Locals[13]);f.Pc=1266;continue;}
case 1266:{f.Locals[33]=f.Pop();f.Pc=1268;continue;}
case 1268:{f.Push(f.Locals[14]);f.Pc=1270;continue;}
case 1270:{f.Locals[34]=f.Pop();f.Pc=1272;continue;}
case 1272:{f.Push(f.Locals[1]);f.Pc=1273;continue;}
case 1273:{f.Push(JValue.R(rt.String("NoneFoundDestination")));f.Pc=1275;continue;}
case 1275:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1278);}
case 1278:{f.Pc=f.Pop().Int==0?1299:1281;continue;}
case 1281:{f.Push(f.Locals[27]);f.Pc=1283;continue;}
case 1283:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1286);}
case 1286:{f.Push(f.Locals[4]);f.Pc=1288;continue;}
case 1288:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1299:1291;continue;}
case 1291:{f.Push(f.Locals[15]);f.Pc=1293;continue;}
case 1293:{f.Locals[33]=f.Pop();f.Pc=1295;continue;}
case 1295:{f.Push(f.Locals[16]);f.Pc=1297;continue;}
case 1297:{f.Locals[34]=f.Pop();f.Pc=1299;continue;}
case 1299:{f.Push(f.Locals[33]);f.Pc=1301;continue;}
case 1301:{return rt.Call(f,"forge/game/zone/ZoneType","isKnown","()Z","invokevirtual",1304);}
case 1304:{f.Pc=f.Pop().Int!=0?1329:1307;continue;}
case 1307:{f.Push(f.Locals[33]);f.Pc=1309;continue;}
case 1309:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=1312;continue;}
case 1312:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1356:1315;continue;}
case 1315:{f.Push(f.Locals[18]);f.Pc=1317;continue;}
case 1317:{f.Pc=f.Pop().Int!=0?1356:1320;continue;}
case 1320:{f.Push(f.Locals[1]);f.Pc=1321;continue;}
case 1321:{f.Push(JValue.R(rt.String("RevealRandomOrder")));f.Pc=1323;continue;}
case 1323:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1326);}
case 1326:{f.Pc=f.Pop().Int!=0?1356:1329;continue;}
case 1329:{f.Push(f.Locals[28]);f.Pc=1331;continue;}
case 1331:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1334);}
case 1334:{f.Push(JValue.I(2));f.Pc=1335;continue;}
case 1335:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?1356:1338;continue;}
case 1338:{f.Push(f.Locals[26]);f.Pc=1340;continue;}
case 1340:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1343);}
case 1343:{f.Push(f.Locals[28]);f.Pc=1345;continue;}
case 1345:{f.Push(f.Locals[33]);f.Pc=1347;continue;}
case 1347:{f.Push(f.Locals[1]);f.Pc=1348;continue;}
case 1348:{return rt.Call(f,"forge/game/player/PlayerController","orderMoveToZoneList","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",1351);}
case 1351:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1354;continue;}
case 1354:{f.Locals[28]=f.Pop();f.Pc=1356;continue;}
case 1356:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1359);}
case 1359:{f.Locals[35]=f.Pop();f.Pc=1361;continue;}
case 1361:{f.Push(f.Locals[35]);f.Pc=1363;continue;}
case 1363:{f.Push(f.Locals[22]);f.Pc=1365;continue;}
case 1365:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",1368);}
case 1368:{f.Push(f.Locals[28]);f.Pc=1370;continue;}
case 1370:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1373);}
case 1373:{f.Locals[36]=f.Pop();f.Pc=1375;continue;}
case 1375:{f.Push(f.Locals[36]);f.Pc=1377;continue;}
case 1377:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1382);}
case 1382:{f.Pc=f.Pop().Int==0?1432:1385;continue;}
case 1385:{f.Push(f.Locals[36]);f.Pc=1387;continue;}
case 1387:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1392);}
case 1392:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1395;continue;}
case 1395:{f.Locals[37]=f.Pop();f.Pc=1397;continue;}
case 1397:{f.Push(f.Locals[3]);f.Pc=1398;continue;}
case 1398:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1401);}
case 1401:{f.Push(f.Locals[33]);f.Pc=1403;continue;}
case 1403:{f.Push(f.Locals[37]);f.Pc=1405;continue;}
case 1405:{f.Push(f.Locals[34]);f.Pc=1407;continue;}
case 1407:{f.Push(f.Locals[1]);f.Pc=1408;continue;}
case 1408:{f.Push(f.Locals[35]);f.Pc=1410;continue;}
case 1410:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",1413);}
case 1413:{f.Locals[37]=f.Pop();f.Pc=1415;continue;}
case 1415:{f.Push(f.Locals[33]);f.Pc=1417;continue;}
case 1417:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=1420;continue;}
case 1420:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1429:1423;continue;}
case 1423:{f.Push(f.Locals[37]);f.Pc=1425;continue;}
case 1425:{f.Push(f.Locals[1]);f.Pc=1426;continue;}
case 1426:{return rt.Call(f,"forge/game/ability/effects/DigUntilEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",1429);}
case 1429:{f.Pc=1375;continue;}
case 1432:{f.Push(f.Locals[18]);f.Pc=1434;continue;}
case 1434:{f.Pc=f.Pop().Int==0?1443:1437;continue;}
case 1437:{f.Push(f.Locals[26]);f.Pc=1439;continue;}
case 1439:{f.Push(f.Locals[1]);f.Pc=1440;continue;}
case 1440:{return rt.Call(f,"forge/game/player/Player","shuffle","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1443);}
case 1443:{f.Push(f.Locals[1]);f.Pc=1444;continue;}
case 1444:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","CASCADE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","CASCADE","Lforge/game/keyword/Keyword;"));f.Pc=1447;continue;}
case 1447:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",1450);}
case 1450:{f.Pc=f.Pop().Int==0?1516:1453;continue;}
case 1453:{f.Push(f.Locals[26]);f.Pc=1455;continue;}
case 1455:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",1458);}
case 1458:{f.Locals[33]=f.Pop();f.Pc=1460;continue;}
case 1460:{f.Push(f.Locals[33]);f.Pc=1462;continue;}
case 1462:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=1465;continue;}
case 1465:{f.Push(f.Locals[29]);f.Pc=1467;continue;}
case 1467:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1472);}
case 1472:{f.StackOp("pop");f.Pc=1473;continue;}
case 1473:{f.Push(f.Locals[3]);f.Pc=1474;continue;}
case 1474:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",1477);}
case 1477:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Cascade","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Cascade","Lforge/game/replacement/ReplacementType;"));f.Pc=1480;continue;}
case 1480:{f.Push(f.Locals[33]);f.Pc=1482;continue;}
case 1482:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",1485);}
case 1485:{f.StackOp("pop");f.Pc=1486;continue;}
case 1486:{f.Push(f.Locals[1]);f.Pc=1487;continue;}
case 1487:{f.Push(JValue.R(rt.String("RememberRevealed")));f.Pc=1490;continue;}
case 1490:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1493);}
case 1493:{f.Pc=f.Pop().Int==0?1516:1496;continue;}
case 1496:{f.Push(f.Locals[10]);f.Pc=1498;continue;}
case 1498:{f.Locals[34]=f.Pop();f.Pc=1500;continue;}
case 1500:{f.Push(f.Locals[2]);f.Pc=1501;continue;}
case 1501:{f.Push(f.Locals[29]);f.Pc=1503;continue;}
case 1503:{f.Push(f.Locals[34]);f.Pc=1505;continue;}
case 1505:{return rt.DynamicCall(f,"forge/game/ability/effects/DigUntilEffect:3346:1505:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/zone/ZoneType;)Ljava/util/function/Predicate;",1510);}
case 1510:{return rt.Call(f,"forge/game/card/CardCollection","filter","(Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokevirtual",1513);}
case 1513:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1516);}
case 1516:{f.Pc=367;continue;}
case 1519:{f.Push(f.Locals[24]);f.Pc=1521;continue;}
case 1521:{f.Pc=f.Pop().Int==0?1539:1524;continue;}
case 1524:{f.Push(f.Locals[3]);f.Pc=1525;continue;}
case 1525:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",1528);}
case 1528:{f.Push(f.Locals[3]);f.Pc=1529;continue;}
case 1529:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=1532;continue;}
case 1532:{f.StackOp("dup");f.Pc=1533;continue;}
case 1533:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",1536);}
case 1536:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1539);}
case 1539:{f.Push(f.Locals[21]);f.Pc=1541;continue;}
case 1541:{f.Pc=f.Pop().Int!=0?1551:1544;continue;}
case 1544:{f.Push(f.Locals[23]);f.Pc=1546;continue;}
case 1546:{f.Push(f.Locals[3]);f.Pc=1547;continue;}
case 1547:{f.Push(f.Locals[1]);f.Pc=1548;continue;}
case 1548:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1551);}
case 1551:{f.Push(f.Locals[22]);f.Pc=1553;continue;}
case 1553:{f.Push(f.Locals[3]);f.Pc=1554;continue;}
case 1554:{f.Push(f.Locals[1]);f.Pc=1555;continue;}
case 1555:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1558);}
case 1558:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3347(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int!=0?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

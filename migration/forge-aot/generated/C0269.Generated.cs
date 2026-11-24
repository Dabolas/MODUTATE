// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C269{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CountersPutEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3264,"forge/game/ability/effects/CountersPutEffect","<init>","()V",1,1,1,new JHandler[]{},M3264));
c.Add(new JMethod(3265,"forge/game/ability/effects/CountersPutEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,18,5,new JHandler[]{},M3265));
c.Add(new JMethod(3266,"forge/game/ability/effects/CountersPutEffect","resolvePerType","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/CounterType;ILforge/game/GameEntityCounterTable;Z)V",4,33,8,new JHandler[]{},M3266));
c.Add(new JMethod(3267,"forge/game/ability/effects/CountersPutEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,14,7,new JHandler[]{new JHandler(486,505,508,"java/lang/Exception")},M3267));
c.Add(new JMethod(3268,"forge/game/ability/effects/CountersPutEffect","addRemovePhaseTrigger","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)V",4,13,4,new JHandler[]{},M3268));
c.Add(new JMethod(3269,"forge/game/ability/effects/CountersPutEffect","chooseTypeFromList","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/GameEntity;Lforge/game/player/PlayerController;)Lforge/game/card/CounterType;",4,11,5,new JHandler[]{},M3269));
c.Add(new JMethod(3270,"forge/game/ability/effects/CountersPutEffect","logOutput","(Ljava/util/Map;Lforge/game/card/Card;)Ljava/lang/String;",4,7,3,new JHandler[]{},M3270));
c.Add(new JMethod(3271,"forge/game/ability/effects/CountersPutEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V",1,5,5,new JHandler[]{},M3271));
}

internal static JStep M3264(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3265(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{f.Locals[5]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?183:34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",40);}
case 40:{f.Locals[6]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("True")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int==0?169:52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",56);}
case 56:{f.Locals[7]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[7]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String(",")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?159:68;continue;}
case 68:{f.Push(f.Locals[7]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String(" you ")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int==0?139:78;continue;}
case 78:{f.Push(f.Locals[7]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String(" you ")));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3265:84:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",89);}
case 89:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",92);}
case 92:{f.Locals[7]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(JValue.I(1));f.Pc=95;continue;}
case 95:{f.Locals[5]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[7]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String(" you ")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?118:107;continue;}
case 107:{f.Push(f.Locals[7]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String(" you ")));f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String(" they ")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",116);}
case 116:{f.Locals[7]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[7]);f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.String(" your ")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",125);}
case 125:{f.Pc=f.Pop().Int==0?139:128;continue;}
case 128:{f.Push(f.Locals[7]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String(" your ")));f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String(" their ")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",137);}
case 137:{f.Locals[7]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[7]);f.Pc=142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{f.Push(f.Locals[7]);f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String(",")));f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",150);}
case 150:{f.Push(JValue.I(1));f.Pc=151;continue;}
case 151:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;","invokevirtual",155);}
case 155:{f.StackOp("pop");f.Pc=156;continue;}
case 156:{f.Pc=166;continue;}
case 159:{f.Push(f.Locals[2]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("[CountersPutEffect IfDesc parsing error]")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",165);}
case 165:{f.StackOp("pop");f.Pc=166;continue;}
case 166:{f.Pc=176;continue;}
case 169:{f.Push(f.Locals[2]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[6]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",175);}
case 175:{f.StackOp("pop");f.Pc=176;continue;}
case 176:{f.Push(f.Locals[2]);f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String(" ")));f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",182);}
case 182:{f.StackOp("pop");f.Pc=183;continue;}
case 183:{f.Push(f.Locals[2]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[5]);f.Pc=186;continue;}
case 186:{f.Pc=f.Pop().Int==0?194:189;continue;}
case 189:{f.Push(JValue.R(rt.String("they")));f.Pc=191;continue;}
case 191:{f.Pc=196;continue;}
case 194:{f.Push(f.Locals[4]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",199);}
case 199:{f.Push(JValue.R(rt.String(" ")));f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",204);}
case 204:{f.StackOp("pop");f.Pc=205;continue;}
case 205:{f.Push(f.Locals[1]);f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",211);}
case 211:{f.Pc=f.Pop().Int==0?248:214;continue;}
case 214:{f.Push(JValue.R(rt.String("ExistingCounter")));f.Pc=216;continue;}
case 216:{f.Push(f.Locals[1]);f.Pc=217;continue;}
case 217:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",222);}
case 222:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",225);}
case 225:{f.Pc=f.Pop().Int!=0?248:228;continue;}
case 228:{f.Push(f.Locals[1]);f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",234);}
case 234:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",237);}
case 237:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",242);}
case 242:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",245);}
case 245:{f.Pc=250;continue;}
case 248:{f.Push(JValue.R(rt.String("")));f.Pc=250;continue;}
case 250:{f.Locals[6]=f.Pop();f.Pc=252;continue;}
case 252:{f.Push(JValue.I(4));f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=256;continue;}
case 256:{f.StackOp("dup");f.Pc=257;continue;}
case 257:{f.Push(JValue.I(0));f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String("energy")));f.Pc=260;continue;}
case 260:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=261;continue;}
case 261:{f.StackOp("dup");f.Pc=262;continue;}
case 262:{f.Push(JValue.I(1));f.Pc=263;continue;}
case 263:{f.Push(JValue.R(rt.String("experience")));f.Pc=265;continue;}
case 265:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=266;continue;}
case 266:{f.StackOp("dup");f.Pc=267;continue;}
case 267:{f.Push(JValue.I(2));f.Pc=268;continue;}
case 268:{f.Push(JValue.R(rt.String("poison")));f.Pc=270;continue;}
case 270:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=271;continue;}
case 271:{f.StackOp("dup");f.Pc=272;continue;}
case 272:{f.Push(JValue.I(3));f.Pc=273;continue;}
case 273:{f.Push(JValue.R(rt.String("ticket")));f.Pc=275;continue;}
case 275:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",279);}
case 279:{f.Locals[7]=f.Pop();f.Pc=281;continue;}
case 281:{f.Push(f.Locals[7]);f.Pc=283;continue;}
case 283:{f.Push(f.Locals[6]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",290);}
case 290:{f.Pc=f.Pop().Int==0?363:293;continue;}
case 293:{f.Push(f.Locals[2]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[5]);f.Pc=296;continue;}
case 296:{f.Pc=f.Pop().Int==0?304:299;continue;}
case 299:{f.Push(JValue.R(rt.String("get ")));f.Pc=301;continue;}
case 301:{f.Pc=306;continue;}
case 304:{f.Push(JValue.R(rt.String("gets ")));f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",309);}
case 309:{f.StackOp("pop");f.Pc=310;continue;}
case 310:{f.Push(f.Locals[2]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[3]);f.Pc=312;continue;}
case 312:{f.Push(f.Locals[1]);f.Pc=313;continue;}
case 313:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=315;continue;}
case 315:{f.Push(JValue.R(rt.String("1")));f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",320);}
case 320:{f.Push(f.Locals[1]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",324);}
case 324:{f.Push(f.Locals[6]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",329);}
case 329:{f.Pc=f.Pop().Int==0?337:332;continue;}
case 332:{f.Push(JValue.R(rt.String("counter")));f.Pc=334;continue;}
case 334:{f.Pc=344;continue;}
case 337:{f.Push(f.Locals[6]);f.Pc=339;continue;}
case 339:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3265:339:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",344);}
case 344:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",347);}
case 347:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",350);}
case 350:{f.StackOp("pop");f.Pc=351;continue;}
case 351:{f.Push(f.Locals[2]);f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String(".")));f.Pc=354;continue;}
case 354:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",357);}
case 357:{f.StackOp("pop");f.Pc=358;continue;}
case 358:{f.Push(f.Locals[2]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",362);}
case 362:{return JStep.Return(f.Pop());}
case 363:{f.Push(f.Locals[1]);f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",367);}
case 367:{f.Locals[8]=f.Pop();f.Pc=369;continue;}
case 369:{f.Push(f.Locals[8]);f.Pc=371;continue;}
case 371:{f.Push(JValue.I(34));f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",376);}
case 376:{f.Locals[9]=f.Pop();f.Pc=378;continue;}
case 378:{f.Push(f.Locals[8]);f.Pc=380;continue;}
case 380:{f.Push(JValue.R(rt.String(" for each")));f.Pc=382;continue;}
case 382:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",385);}
case 385:{f.Pc=f.Pop().Int==0?436:388;continue;}
case 388:{f.Push(f.Locals[8]);f.Pc=390;continue;}
case 390:{f.Push(JValue.R(rt.String(", then")));f.Pc=392;continue;}
case 392:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",395);}
case 395:{f.Pc=f.Pop().Int==0?415:398;continue;}
case 398:{f.Push(f.Locals[8]);f.Pc=400;continue;}
case 400:{f.Push(JValue.R(rt.String(", then")));f.Pc=402;continue;}
case 402:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",405);}
case 405:{f.Push(f.Locals[8]);f.Pc=407;continue;}
case 407:{f.Push(JValue.R(rt.String(" for each")));f.Pc=409;continue;}
case 409:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",412);}
case 412:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?436:415;continue;}
case 415:{f.Push(f.Locals[9]);f.Pc=417;continue;}
case 417:{f.Pc=f.Pop().Int<0?432:420;continue;}
case 420:{f.Push(f.Locals[8]);f.Pc=422;continue;}
case 422:{f.Push(JValue.R(rt.String(" for each")));f.Pc=424;continue;}
case 424:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",427);}
case 427:{f.Push(f.Locals[9]);f.Pc=429;continue;}
case 429:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?436:432;continue;}
case 432:{f.Push(JValue.I(1));f.Pc=433;continue;}
case 433:{f.Pc=437;continue;}
case 436:{f.Push(JValue.I(0));f.Pc=437;continue;}
case 437:{f.Locals[10]=f.Pop();f.Pc=439;continue;}
case 439:{f.Push(f.Locals[1]);f.Pc=440;continue;}
case 440:{f.Push(JValue.R(rt.String("CounterTypes")));f.Pc=442;continue;}
case 442:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",445);}
case 445:{f.Pc=f.Pop().Int==0?525:448;continue;}
case 448:{f.Push(f.Locals[8]);f.Pc=450;continue;}
case 450:{f.Push(JValue.R(rt.String("Put ")));f.Pc=452;continue;}
case 452:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",455);}
case 455:{f.Pc=f.Pop().Int==0?498:458;continue;}
case 458:{f.Push(f.Locals[8]);f.Pc=460;continue;}
case 460:{f.Push(JValue.R(rt.String(" on ")));f.Pc=462;continue;}
case 462:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",465);}
case 465:{f.Pc=f.Pop().Int==0?498:468;continue;}
case 468:{f.Push(f.Locals[8]);f.Pc=470;continue;}
case 470:{f.Push(f.Locals[8]);f.Pc=472;continue;}
case 472:{f.Push(JValue.R(rt.String("Put ")));f.Pc=474;continue;}
case 474:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",477);}
case 477:{f.Push(f.Locals[8]);f.Pc=479;continue;}
case 479:{f.Push(JValue.R(rt.String(" on ")));f.Pc=481;continue;}
case 481:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",484);}
case 484:{f.Push(JValue.I(4));f.Pc=485;continue;}
case 485:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=486;continue;}
case 486:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",489);}
case 489:{f.Push(JValue.R(rt.String("Put ")));f.Pc=491;continue;}
case 491:{f.Push(JValue.R(rt.String("puts ")));f.Pc=493;continue;}
case 493:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",496);}
case 496:{f.Locals[8]=f.Pop();f.Pc=498;continue;}
case 498:{f.Push(f.Locals[2]);f.Pc=499;continue;}
case 499:{f.Push(f.Locals[8]);f.Pc=501;continue;}
case 501:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",504);}
case 504:{f.Push(f.Locals[1]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","getTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",508);}
case 508:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",511);}
case 511:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",514);}
case 514:{f.Push(JValue.R(rt.String(".")));f.Pc=516;continue;}
case 516:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",519);}
case 519:{f.StackOp("pop");f.Pc=520;continue;}
case 520:{f.Push(f.Locals[2]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",524);}
case 524:{return JStep.Return(f.Pop());}
case 525:{f.Push(f.Locals[1]);f.Pc=526;continue;}
case 526:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",529);}
case 529:{f.Pc=f.Pop().Int==0?551:532;continue;}
case 532:{f.Push(f.Locals[1]);f.Pc=533;continue;}
case 533:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",536);}
case 536:{f.Locals[11]=f.Pop();f.Pc=538;continue;}
case 538:{f.Push(f.Locals[11]);f.Pc=540;continue;}
case 540:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",545);}
case 545:{f.Pc=f.Pop().Int==0?551:548;continue;}
case 548:{f.Push(JValue.R(rt.String("")));f.Pc=550;continue;}
case 550:{return JStep.Return(f.Pop());}
case 551:{f.Push(f.Locals[3]);f.Pc=552;continue;}
case 552:{f.Push(f.Locals[1]);f.Pc=553;continue;}
case 553:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=555;continue;}
case 555:{f.Push(JValue.R(rt.String("1")));f.Pc=557;continue;}
case 557:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",560);}
case 560:{f.Push(f.Locals[1]);f.Pc=561;continue;}
case 561:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",564);}
case 564:{f.Locals[11]=f.Pop();f.Pc=566;continue;}
case 566:{f.Push(f.Locals[1]);f.Pc=567;continue;}
case 567:{f.Push(JValue.R(rt.String("Bolster")));f.Pc=569;continue;}
case 569:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",572);}
case 572:{f.Pc=f.Pop().Int==0?597:575;continue;}
case 575:{f.Push(f.Locals[2]);f.Pc=576;continue;}
case 576:{f.Push(JValue.R(rt.String("bolsters ")));f.Pc=578;continue;}
case 578:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",581);}
case 581:{f.Push(f.Locals[11]);f.Pc=583;continue;}
case 583:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",586);}
case 586:{f.Push(JValue.R(rt.String(".")));f.Pc=588;continue;}
case 588:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",591);}
case 591:{f.StackOp("pop");f.Pc=592;continue;}
case 592:{f.Push(f.Locals[2]);f.Pc=593;continue;}
case 593:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",596);}
case 596:{return JStep.Return(f.Pop());}
case 597:{f.Push(f.Locals[1]);f.Pc=598;continue;}
case 598:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",601);}
case 601:{f.Locals[12]=f.Pop();f.Pc=603;continue;}
case 603:{f.Push(f.Locals[1]);f.Pc=604;continue;}
case 604:{f.Push(JValue.R(rt.String("DividedRandomly")));f.Pc=606;continue;}
case 606:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",609);}
case 609:{f.Locals[13]=f.Pop();f.Pc=611;continue;}
case 611:{f.Push(f.Locals[12]);f.Pc=613;continue;}
case 613:{f.Pc=f.Pop().Int==0?636:616;continue;}
case 616:{f.Push(f.Locals[2]);f.Pc=617;continue;}
case 617:{f.Push(f.Locals[5]);f.Pc=619;continue;}
case 619:{f.Pc=f.Pop().Int==0?627:622;continue;}
case 622:{f.Push(JValue.R(rt.String("distribute ")));f.Pc=624;continue;}
case 624:{f.Pc=629;continue;}
case 627:{f.Push(JValue.R(rt.String("distributes ")));f.Pc=629;continue;}
case 629:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",632);}
case 632:{f.StackOp("pop");f.Pc=633;continue;}
case 633:{f.Pc=678;continue;}
case 636:{f.Push(f.Locals[13]);f.Pc=638;continue;}
case 638:{f.Pc=f.Pop().Int==0?661:641;continue;}
case 641:{f.Push(f.Locals[2]);f.Pc=642;continue;}
case 642:{f.Push(f.Locals[5]);f.Pc=644;continue;}
case 644:{f.Pc=f.Pop().Int==0?652:647;continue;}
case 647:{f.Push(JValue.R(rt.String("randomly distribute ")));f.Pc=649;continue;}
case 649:{f.Pc=654;continue;}
case 652:{f.Push(JValue.R(rt.String("randomly distributes ")));f.Pc=654;continue;}
case 654:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",657);}
case 657:{f.StackOp("pop");f.Pc=658;continue;}
case 658:{f.Pc=678;continue;}
case 661:{f.Push(f.Locals[2]);f.Pc=662;continue;}
case 662:{f.Push(f.Locals[5]);f.Pc=664;continue;}
case 664:{f.Pc=f.Pop().Int==0?672:667;continue;}
case 667:{f.Push(JValue.R(rt.String("put ")));f.Pc=669;continue;}
case 669:{f.Pc=674;continue;}
case 672:{f.Push(JValue.R(rt.String("puts ")));f.Pc=674;continue;}
case 674:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",677);}
case 677:{f.StackOp("pop");f.Pc=678;continue;}
case 678:{f.Push(f.Locals[1]);f.Pc=679;continue;}
case 679:{f.Push(JValue.R(rt.String("UpTo")));f.Pc=681;continue;}
case 681:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",684);}
case 684:{f.Pc=f.Pop().Int==0?694:687;continue;}
case 687:{f.Push(f.Locals[2]);f.Pc=688;continue;}
case 688:{f.Push(JValue.R(rt.String("up to ")));f.Pc=690;continue;}
case 690:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",693);}
case 693:{f.StackOp("pop");f.Pc=694;continue;}
case 694:{f.Push(f.Locals[2]);f.Pc=695;continue;}
case 695:{f.Push(f.Locals[11]);f.Pc=697;continue;}
case 697:{f.Push(f.Locals[6]);f.Pc=699;continue;}
case 699:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",702);}
case 702:{f.Pc=f.Pop().Int==0?710:705;continue;}
case 705:{f.Push(JValue.R(rt.String("counter")));f.Pc=707;continue;}
case 707:{f.Pc=717;continue;}
case 710:{f.Push(f.Locals[6]);f.Pc=712;continue;}
case 712:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3265:712:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",717);}
case 717:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",720);}
case 720:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",723);}
case 723:{f.StackOp("pop");f.Pc=724;continue;}
case 724:{f.Push(f.Locals[2]);f.Pc=725;continue;}
case 725:{f.Push(f.Locals[12]);f.Pc=727;continue;}
case 727:{f.Pc=f.Pop().Int!=0?735:730;continue;}
case 730:{f.Push(f.Locals[13]);f.Pc=732;continue;}
case 732:{f.Pc=f.Pop().Int==0?740:735;continue;}
case 735:{f.Push(JValue.R(rt.String(" among ")));f.Pc=737;continue;}
case 737:{f.Pc=742;continue;}
case 740:{f.Push(JValue.R(rt.String(" on ")));f.Pc=742;continue;}
case 742:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",745);}
case 745:{f.StackOp("pop");f.Pc=746;continue;}
case 746:{f.Push(f.Locals[1]);f.Pc=747;continue;}
case 747:{f.Push(JValue.R(rt.String("Defined")));f.Pc=749;continue;}
case 749:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",752);}
case 752:{f.Pc=f.Pop().Int==0?879:755;continue;}
case 755:{f.Push(f.Locals[1]);f.Pc=756;continue;}
case 756:{f.Push(JValue.R(rt.String("Defined")));f.Pc=758;continue;}
case 758:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",761);}
case 761:{f.Push(JValue.R(rt.String(" & ")));f.Pc=763;continue;}
case 763:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",766);}
case 766:{f.Pc=f.Pop().Int==0?879:769;continue;}
case 769:{f.Push(f.Locals[1]);f.Pc=770;continue;}
case 770:{f.Push(JValue.R(rt.String("Defined")));f.Pc=772;continue;}
case 772:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",775);}
case 775:{f.Push(JValue.R(rt.String(" & ")));f.Pc=777;continue;}
case 777:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",780);}
case 780:{f.Locals[14]=f.Pop();f.Pc=782;continue;}
case 782:{f.Push(JValue.I(0));f.Pc=783;continue;}
case 783:{f.Locals[15]=f.Pop();f.Pc=785;continue;}
case 785:{f.Push(f.Locals[15]);f.Pc=787;continue;}
case 787:{f.Push(f.Locals[14]);f.Pc=789;continue;}
case 789:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=790;continue;}
case 790:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?876:793;continue;}
case 793:{f.Push(f.Locals[2]);f.Pc=794;continue;}
case 794:{f.Push(f.Locals[3]);f.Pc=795;continue;}
case 795:{f.Push(f.Locals[14]);f.Pc=797;continue;}
case 797:{f.Push(f.Locals[15]);f.Pc=799;continue;}
case 799:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=800;continue;}
case 800:{f.Push(f.Locals[1]);f.Pc=801;continue;}
case 801:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",804);}
case 804:{return rt.Call(f,"forge/util/collect/FCollection","toString","()Ljava/lang/String;","invokevirtual",807);}
case 807:{f.Push(JValue.R(rt.String("[\\[\\]]")));f.Pc=809;continue;}
case 809:{f.Push(JValue.R(rt.String("")));f.Pc=811;continue;}
case 811:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",814);}
case 814:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",817);}
case 817:{f.StackOp("pop");f.Pc=818;continue;}
case 818:{f.Push(f.Locals[15]);f.Pc=820;continue;}
case 820:{f.Push(JValue.I(1));f.Pc=821;continue;}
case 821:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=822;continue;}
case 822:{f.Push(f.Locals[14]);f.Pc=824;continue;}
case 824:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=825;continue;}
case 825:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?870:828;continue;}
case 828:{f.Push(f.Locals[2]);f.Pc=829;continue;}
case 829:{f.Push(JValue.R(rt.String(" and ")));f.Pc=831;continue;}
case 831:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",834);}
case 834:{f.StackOp("pop");f.Pc=835;continue;}
case 835:{f.Push(f.Locals[2]);f.Pc=836;continue;}
case 836:{f.Push(f.Locals[11]);f.Pc=838;continue;}
case 838:{f.Push(f.Locals[6]);f.Pc=840;continue;}
case 840:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",843);}
case 843:{f.Pc=f.Pop().Int==0?851:846;continue;}
case 846:{f.Push(JValue.R(rt.String("counter")));f.Pc=848;continue;}
case 848:{f.Pc=858;continue;}
case 851:{f.Push(f.Locals[6]);f.Pc=853;continue;}
case 853:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3265:853:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",858);}
case 858:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",861);}
case 861:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",864);}
case 864:{f.Push(JValue.R(rt.String(" on ")));f.Pc=866;continue;}
case 866:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",869);}
case 869:{f.StackOp("pop");f.Pc=870;continue;}
case 870:{f.Locals[15]=JValue.I(unchecked(f.Locals[15].Int+(1)));f.Pc=873;continue;}
case 873:{f.Pc=785;continue;}
case 876:{f.Pc=1190;continue;}
case 879:{f.Push(f.Locals[1]);f.Pc=880;continue;}
case 880:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",883);}
case 883:{f.Pc=f.Pop().Int==0?1030:886;continue;}
case 886:{f.Push(f.Locals[1]);f.Pc=887;continue;}
case 887:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",890);}
case 890:{f.Locals[14]=f.Pop();f.Pc=892;continue;}
case 892:{f.Push(JValue.I(0));f.Pc=893;continue;}
case 893:{f.Locals[15]=f.Pop();f.Pc=895;continue;}
case 895:{f.Push(f.Locals[15]);f.Pc=897;continue;}
case 897:{f.Push(f.Locals[14]);f.Pc=899;continue;}
case 899:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",904);}
case 904:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1027:907;continue;}
case 907:{f.Push(f.Locals[14]);f.Pc=909;continue;}
case 909:{f.Push(f.Locals[15]);f.Pc=911;continue;}
case 911:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",916);}
case 916:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=919;continue;}
case 919:{f.Locals[16]=f.Pop();f.Pc=921;continue;}
case 921:{f.Push(f.Locals[2]);f.Pc=922;continue;}
case 922:{f.Push(f.Locals[16]);f.Pc=924;continue;}
case 924:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",927);}
case 927:{f.StackOp("pop");f.Pc=928;continue;}
case 928:{f.Push(f.Locals[1]);f.Pc=929;continue;}
case 929:{f.Push(f.Locals[16]);f.Pc=931;continue;}
case 931:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDividedValue","(Lforge/game/GameObject;)Ljava/lang/Integer;","invokevirtual",934);}
case 934:{f.Locals[17]=f.Pop();f.Pc=936;continue;}
case 936:{f.Push(f.Locals[17]);f.Pc=938;continue;}
case 938:{f.Pc=f.Pop().Reference==null?975:941;continue;}
case 941:{f.Push(f.Locals[2]);f.Pc=942;continue;}
case 942:{f.Push(JValue.R(rt.String(" (")));f.Pc=945;continue;}
case 945:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",948);}
case 948:{f.Push(f.Locals[17]);f.Pc=950;continue;}
case 950:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",953);}
case 953:{f.Push(f.Locals[17]);f.Pc=955;continue;}
case 955:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",958);}
case 958:{f.Push(JValue.I(1));f.Pc=959;continue;}
case 959:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?968:962;continue;}
case 962:{f.Push(JValue.R(rt.String(" counter)")));f.Pc=965;continue;}
case 965:{f.Pc=971;continue;}
case 968:{f.Push(JValue.R(rt.String(" counters)")));f.Pc=971;continue;}
case 971:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",974);}
case 974:{f.StackOp("pop");f.Pc=975;continue;}
case 975:{f.Push(f.Locals[15]);f.Pc=977;continue;}
case 977:{f.Push(f.Locals[14]);f.Pc=979;continue;}
case 979:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",984);}
case 984:{f.Push(JValue.I(2));f.Pc=985;continue;}
case 985:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=986;continue;}
case 986:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?999:989;continue;}
case 989:{f.Push(f.Locals[2]);f.Pc=990;continue;}
case 990:{f.Push(JValue.R(rt.String(" and ")));f.Pc=992;continue;}
case 992:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",995);}
case 995:{f.StackOp("pop");f.Pc=996;continue;}
case 996:{f.Pc=1021;continue;}
case 999:{f.Push(f.Locals[15]);f.Pc=1001;continue;}
case 1001:{f.Push(JValue.I(1));f.Pc=1002;continue;}
case 1002:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1003;continue;}
case 1003:{f.Push(f.Locals[14]);f.Pc=1005;continue;}
case 1005:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1010);}
case 1010:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1021:1013;continue;}
case 1013:{f.Push(f.Locals[2]);f.Pc=1014;continue;}
case 1014:{f.Push(JValue.R(rt.String(", ")));f.Pc=1017;continue;}
case 1017:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1020);}
case 1020:{f.StackOp("pop");f.Pc=1021;continue;}
case 1021:{f.Locals[15]=JValue.I(unchecked(f.Locals[15].Int+(1)));f.Pc=1024;continue;}
case 1024:{f.Pc=895;continue;}
case 1027:{f.Pc=1190;continue;}
case 1030:{f.Push(f.Locals[1]);f.Pc=1031;continue;}
case 1031:{f.Push(JValue.R(rt.String("Choices")));f.Pc=1034;continue;}
case 1034:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1037);}
case 1037:{f.Pc=f.Pop().Int==0?1106:1040;continue;}
case 1040:{f.Push(f.Locals[3]);f.Pc=1041;continue;}
case 1041:{f.Push(f.Locals[1]);f.Pc=1042;continue;}
case 1042:{f.Push(JValue.R(rt.String("ChoiceAmount")));f.Pc=1045;continue;}
case 1045:{f.Push(JValue.R(rt.String("1")));f.Pc=1047;continue;}
case 1047:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1050);}
case 1050:{f.Push(f.Locals[1]);f.Pc=1051;continue;}
case 1051:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1054);}
case 1054:{f.Locals[14]=f.Pop();f.Pc=1056;continue;}
case 1056:{f.Push(f.Locals[1]);f.Pc=1057;continue;}
case 1057:{f.Push(JValue.R(rt.String("ChoicesDesc")));f.Pc=1060;continue;}
case 1060:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1063);}
case 1063:{f.Pc=f.Pop().Int==0?1076:1066;continue;}
case 1066:{f.Push(f.Locals[1]);f.Pc=1067;continue;}
case 1067:{f.Push(JValue.R(rt.String("ChoicesDesc")));f.Pc=1070;continue;}
case 1070:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1073);}
case 1073:{f.Pc=1089;continue;}
case 1076:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",1079);}
case 1079:{f.Push(f.Locals[1]);f.Pc=1080;continue;}
case 1080:{f.Push(JValue.R(rt.String("Choices")));f.Pc=1083;continue;}
case 1083:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1086);}
case 1086:{return rt.Call(f,"forge/util/Lang","describeValidList","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1089);}
case 1089:{f.Locals[15]=f.Pop();f.Pc=1091;continue;}
case 1091:{f.Push(f.Locals[2]);f.Pc=1092;continue;}
case 1092:{f.Push(f.Locals[14]);f.Pc=1094;continue;}
case 1094:{f.Push(f.Locals[15]);f.Pc=1096;continue;}
case 1096:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",1099);}
case 1099:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1102);}
case 1102:{f.StackOp("pop");f.Pc=1103;continue;}
case 1103:{f.Pc=1190;continue;}
case 1106:{f.Push(f.Locals[1]);f.Pc=1107;continue;}
case 1107:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",1110);}
case 1110:{f.Locals[14]=f.Pop();f.Pc=1112;continue;}
case 1112:{f.Push(f.Locals[14]);f.Pc=1114;continue;}
case 1114:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1119);}
case 1119:{f.Locals[15]=f.Pop();f.Pc=1121;continue;}
case 1121:{f.Push(f.Locals[15]);f.Pc=1123;continue;}
case 1123:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1128);}
case 1128:{f.Pc=f.Pop().Int==0?1190:1131;continue;}
case 1131:{f.Push(f.Locals[15]);f.Pc=1133;continue;}
case 1133:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1138);}
case 1138:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1141;continue;}
case 1141:{f.Locals[16]=f.Pop();f.Pc=1143;continue;}
case 1143:{f.Push(f.Locals[16]);f.Pc=1145;continue;}
case 1145:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",1148);}
case 1148:{f.Pc=f.Pop().Int==0?1162:1151;continue;}
case 1151:{f.Push(f.Locals[2]);f.Pc=1152;continue;}
case 1152:{f.Push(JValue.R(rt.String("Morph")));f.Pc=1155;continue;}
case 1155:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1158);}
case 1158:{f.StackOp("pop");f.Pc=1159;continue;}
case 1159:{f.Pc=1169;continue;}
case 1162:{f.Push(f.Locals[2]);f.Pc=1163;continue;}
case 1163:{f.Push(f.Locals[16]);f.Pc=1165;continue;}
case 1165:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",1168);}
case 1168:{f.StackOp("pop");f.Pc=1169;continue;}
case 1169:{f.Push(f.Locals[15]);f.Pc=1171;continue;}
case 1171:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1176);}
case 1176:{f.Pc=f.Pop().Int==0?1187:1179;continue;}
case 1179:{f.Push(f.Locals[2]);f.Pc=1180;continue;}
case 1180:{f.Push(JValue.R(rt.String(", ")));f.Pc=1183;continue;}
case 1183:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1186);}
case 1186:{f.StackOp("pop");f.Pc=1187;continue;}
case 1187:{f.Pc=1121;continue;}
case 1190:{f.Push(f.Locals[2]);f.Pc=1191;continue;}
case 1191:{f.Push(f.Locals[10]);f.Pc=1193;continue;}
case 1193:{f.Pc=f.Pop().Int==0?1211:1196;continue;}
case 1196:{f.Push(f.Locals[8]);f.Pc=1198;continue;}
case 1198:{f.Push(f.Locals[8]);f.Pc=1200;continue;}
case 1200:{f.Push(JValue.R(rt.String(" for each")));f.Pc=1202;continue;}
case 1202:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",1205);}
case 1205:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1208);}
case 1208:{f.Pc=1213;continue;}
case 1211:{f.Push(JValue.R(rt.String(".")));f.Pc=1213;continue;}
case 1213:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1216);}
case 1216:{f.StackOp("pop");f.Pc=1217;continue;}
case 1217:{f.Push(f.Locals[2]);f.Pc=1218;continue;}
case 1218:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1221);}
case 1221:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3266(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[7]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[7]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",11);}
case 11:{f.Locals[8]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",17);}
case 17:{f.Locals[9]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[9]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",24);}
case 24:{f.Locals[10]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("ETB")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",33);}
case 33:{f.Locals[11]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("ExistingCounter")));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",43);}
case 43:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",46);}
case 46:{f.Locals[12]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("EachExistingCounter")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",55);}
case 55:{f.Locals[13]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("PutOnEachOther")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",64);}
case 64:{f.Locals[14]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("PutOnDefined")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",73);}
case 73:{f.Locals[15]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("Optional")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?110:85;continue;}
case 85:{f.Push(f.Locals[10]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(null));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",92);}
case 92:{f.Push(JValue.R(rt.String("lblDoYouWantPutCounter")));f.Pc=95;continue;}
case 95:{f.Push(JValue.I(0));f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",102);}
case 102:{f.Push(JValue.R(null));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int!=0?110:109;continue;}
case 109:{return JStep.ReturnVoid;}
case 110:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",113);}
case 113:{f.Locals[16]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(JValue.I(0));f.Pc=116;continue;}
case 116:{f.Locals[17]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("Choices")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",125);}
case 125:{f.Pc=f.Pop().Int==0?546:128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{f.Pc=f.Pop().Reference!=null?142:132;continue;}
case 132:{f.Push(f.Locals[14]);f.Pc=134;continue;}
case 134:{f.Pc=f.Pop().Int!=0?142:137;continue;}
case 137:{f.Push(f.Locals[15]);f.Pc=139;continue;}
case 139:{f.Pc=f.Pop().Int==0?546:142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=145;continue;}
case 145:{f.Locals[18]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int==0?169:157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",164);}
case 164:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",167);}
case 167:{f.Locals[18]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[9]);f.Pc=171;continue;}
case 171:{f.Locals[19]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[1]);f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",180);}
case 180:{f.Pc=f.Pop().Int==0?222:183;continue;}
case 183:{f.Push(f.Locals[7]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",192);}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",196);}
case 196:{f.Locals[20]=f.Pop();f.Pc=198;continue;}
case 198:{f.Push(f.Locals[20]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",205);}
case 205:{f.Pc=f.Pop().Int==0?209:208;continue;}
case 208:{return JStep.ReturnVoid;}
case 209:{f.Push(f.Locals[20]);f.Pc=211;continue;}
case 211:{f.Push(JValue.I(0));f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",217);}
case 217:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=220;continue;}
case 220:{f.Locals[19]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[7]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[1]);f.Pc=225;continue;}
case 225:{f.Push(JValue.R(rt.String("ChoiceAmount")));f.Pc=228;continue;}
case 228:{f.Push(JValue.R(rt.String("1")));f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",233);}
case 233:{f.Push(f.Locals[1]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",237);}
case 237:{f.Locals[20]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[7]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[1]);f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("MinChoiceAmount")));f.Pc=245;continue;}
case 245:{f.Push(f.Locals[1]);f.Pc=246;continue;}
case 246:{f.Push(JValue.R(rt.String("ChoiceAmount")));f.Pc=249;continue;}
case 249:{f.Push(JValue.R(rt.String("1")));f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",254);}
case 254:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",257);}
case 257:{f.Push(f.Locals[1]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",261);}
case 261:{f.Locals[21]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(f.Locals[20]);f.Pc=265;continue;}
case 265:{f.Pc=f.Pop().Int>0?269:268;continue;}
case 268:{return JStep.ReturnVoid;}
case 269:{f.Push(f.Locals[8]);f.Pc=271;continue;}
case 271:{f.Push(f.Locals[18]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",276);}
case 276:{f.Push(f.Locals[1]);f.Pc=277;continue;}
case 277:{f.Push(JValue.R(rt.String("Choices")));f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",283);}
case 283:{f.Push(f.Locals[9]);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[7]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[1]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",291);}
case 291:{f.Locals[22]=f.Pop();f.Pc=293;continue;}
case 293:{f.Push(f.Locals[3]);f.Pc=294;continue;}
case 294:{f.Pc=f.Pop().Reference==null?318:297;continue;}
case 297:{f.Push(f.Locals[1]);f.Pc=298;continue;}
case 298:{f.Push(JValue.R(rt.String("SkipReceiveCounters")));f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",304);}
case 304:{f.Pc=f.Pop().Int!=0?318:307;continue;}
case 307:{f.Push(f.Locals[22]);f.Pc=309;continue;}
case 309:{f.Push(f.Locals[3]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/card/CardPredicates","canReceiveCounters","(Lforge/game/card/CounterType;)Ljava/util/function/Predicate;","invokestatic",313);}
case 313:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",316);}
case 316:{f.Locals[22]=f.Pop();f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",321);}
case 321:{f.Push(JValue.R(rt.String("lblChooseaCard")));f.Pc=324;continue;}
case 324:{f.Push(JValue.I(0));f.Pc=325;continue;}
case 325:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",331);}
case 331:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3266:331:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",336);}
case 336:{f.Locals[23]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[1]);f.Pc=339;continue;}
case 339:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",345);}
case 345:{f.Pc=f.Pop().Int==0?357:348;continue;}
case 348:{f.Push(f.Locals[1]);f.Pc=349;continue;}
case 349:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",355);}
case 355:{f.Locals[23]=f.Pop();f.Pc=357;continue;}
case 357:{f.Push(f.Locals[1]);f.Pc=358;continue;}
case 358:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=361;continue;}
case 361:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",364);}
case 364:{f.Pc=f.Pop().Int!=0?377:367;continue;}
case 367:{f.Push(f.Locals[1]);f.Pc=368;continue;}
case 368:{f.Push(JValue.R(rt.String("SpecifyCounter")));f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",374);}
case 374:{f.Pc=f.Pop().Int==0?399:377;continue;}
case 377:{f.Push(f.Locals[3]);f.Pc=378;continue;}
case 378:{f.Pc=f.Pop().Reference==null?399:381;continue;}
case 381:{f.Push(f.Locals[23]);f.Pc=383;continue;}
case 383:{f.Push(f.Locals[3]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",389);}
case 389:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3266:389:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",394);}
case 394:{f.Locals[23]=f.Pop();f.Pc=396;continue;}
case 396:{f.Pc=458;continue;}
case 399:{f.Push(f.Locals[14]);f.Pc=401;continue;}
case 401:{f.Pc=f.Pop().Int!=0?409:404;continue;}
case 404:{f.Push(f.Locals[15]);f.Pc=406;continue;}
case 406:{f.Pc=f.Pop().Int==0?458:409;continue;}
case 409:{f.Push(f.Locals[23]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",414);}
case 414:{f.Push(JValue.R(rt.String("lblWithKindCounter")));f.Pc=417;continue;}
case 417:{f.Push(JValue.I(0));f.Pc=418;continue;}
case 418:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",424);}
case 424:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3266:424:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",429);}
case 429:{f.Locals[23]=f.Pop();f.Pc=431;continue;}
case 431:{f.Push(f.Locals[14]);f.Pc=433;continue;}
case 433:{f.Pc=f.Pop().Int==0?458:436;continue;}
case 436:{f.Push(f.Locals[23]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",441);}
case 441:{f.Push(JValue.R(rt.String("lblEachOther")));f.Pc=444;continue;}
case 444:{f.Push(JValue.I(0));f.Pc=445;continue;}
case 445:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=448;continue;}
case 448:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",451);}
case 451:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3266:451:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",456);}
case 456:{f.Locals[23]=f.Pop();f.Pc=458;continue;}
case 458:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",461);}
case 461:{f.Locals[24]=f.Pop();f.Pc=463;continue;}
case 463:{f.Push(f.Locals[3]);f.Pc=464;continue;}
case 464:{f.Pc=f.Pop().Reference==null?478:467;continue;}
case 467:{f.Push(f.Locals[24]);f.Pc=469;continue;}
case 469:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=471;continue;}
case 471:{f.Push(f.Locals[3]);f.Pc=472;continue;}
case 472:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",477);}
case 477:{f.StackOp("pop");f.Pc=478;continue;}
case 478:{f.Push(f.Locals[1]);f.Pc=479;continue;}
case 479:{f.Push(JValue.R(rt.String("DividedRandomly")));f.Pc=481;continue;}
case 481:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",484);}
case 484:{f.Pc=f.Pop().Int==0?500:487;continue;}
case 487:{f.Push(f.Locals[16]);f.Pc=489;continue;}
case 489:{f.Push(f.Locals[22]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",496);}
case 496:{f.StackOp("pop");f.Pc=497;continue;}
case 497:{f.Pc=543;continue;}
case 500:{f.Push(f.Locals[19]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",505);}
case 505:{f.Push(f.Locals[22]);f.Pc=507;continue;}
case 507:{f.Push(f.Locals[1]);f.Pc=508;continue;}
case 508:{f.Push(f.Locals[23]);f.Pc=510;continue;}
case 510:{f.Push(f.Locals[21]);f.Pc=512;continue;}
case 512:{f.Push(f.Locals[20]);f.Pc=514;continue;}
case 514:{f.Push(f.Locals[1]);f.Pc=515;continue;}
case 515:{f.Push(JValue.R(rt.String("ChoiceOptional")));f.Pc=518;continue;}
case 518:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",521);}
case 521:{f.Push(f.Locals[24]);f.Pc=523;continue;}
case 523:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",526);}
case 526:{f.Push(f.Locals[16]);f.Pc=528;continue;}
case 528:{f.StackOp("dup");f.Pc=529;continue;}
case 529:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",532);}
case 532:{f.StackOp("pop");f.Pc=533;continue;}
case 533:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3266:533:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Consumer;",538);}
case 538:{return rt.Call(f,"forge/game/card/CardCollectionView","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",543);}
case 543:{f.Pc=560;continue;}
case 546:{f.Push(f.Locals[16]);f.Pc=548;continue;}
case 548:{f.Push(f.Locals[1]);f.Pc=549;continue;}
case 549:{f.Push(JValue.R(rt.String("Defined")));f.Pc=551;continue;}
case 551:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","getDefinedEntitiesOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;","invokestatic",554);}
case 554:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",559);}
case 559:{f.StackOp("pop");f.Pc=560;continue;}
case 560:{f.Push(f.Locals[4]);f.Pc=562;continue;}
case 562:{f.Locals[18]=f.Pop();f.Pc=564;continue;}
case 564:{f.Push(f.Locals[1]);f.Pc=565;continue;}
case 565:{f.Push(JValue.R(rt.String("DividedRandomly")));f.Pc=567;continue;}
case 567:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",570);}
case 570:{f.Pc=f.Pop().Int==0?831:573;continue;}
case 573:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=576;continue;}
case 576:{f.StackOp("dup");f.Pc=577;continue;}
case 577:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",580);}
case 580:{f.Locals[19]=f.Pop();f.Pc=582;continue;}
case 582:{f.Push(f.Locals[16]);f.Pc=584;continue;}
case 584:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",589);}
case 589:{f.Locals[20]=f.Pop();f.Pc=591;continue;}
case 591:{f.Push(f.Locals[20]);f.Pc=593;continue;}
case 593:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",598);}
case 598:{f.Pc=f.Pop().Int==0?684:601;continue;}
case 601:{f.Push(f.Locals[20]);f.Pc=603;continue;}
case 603:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",608);}
case 608:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=611;continue;}
case 611:{f.Locals[21]=f.Pop();f.Pc=613;continue;}
case 613:{f.Push(f.Locals[21]);f.Pc=615;continue;}
case 615:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=618;continue;}
case 618:{f.Pc=f.Pop().Int==0?674:621;continue;}
case 621:{f.Push(f.Locals[21]);f.Pc=623;continue;}
case 623:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=626;continue;}
case 626:{f.Locals[22]=f.Pop();f.Pc=628;continue;}
case 628:{f.Push(f.Locals[8]);f.Pc=630;continue;}
case 630:{f.Push(f.Locals[22]);f.Pc=632;continue;}
case 632:{f.Push(JValue.R(null));f.Pc=633;continue;}
case 633:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",636);}
case 636:{f.Locals[23]=f.Pop();f.Pc=638;continue;}
case 638:{f.Push(f.Locals[23]);f.Pc=640;continue;}
case 640:{f.Pc=f.Pop().Reference==null?653:643;continue;}
case 643:{f.Push(f.Locals[22]);f.Pc=645;continue;}
case 645:{f.Push(f.Locals[23]);f.Pc=647;continue;}
case 647:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",650);}
case 650:{f.Pc=f.Pop().Int!=0?663:653;continue;}
case 653:{f.Push(f.Locals[20]);f.Pc=655;continue;}
case 655:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",660);}
case 660:{f.Pc=671;continue;}
case 663:{f.Push(f.Locals[19]);f.Pc=665;continue;}
case 665:{f.Push(f.Locals[23]);f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",670);}
case 670:{f.StackOp("pop");f.Pc=671;continue;}
case 671:{f.Pc=681;continue;}
case 674:{f.Push(f.Locals[20]);f.Pc=676;continue;}
case 676:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",681);}
case 681:{f.Pc=591;continue;}
case 684:{f.Push(f.Locals[16]);f.Pc=686;continue;}
case 686:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",691);}
case 691:{f.Pc=f.Pop().Int!=0?695:694;continue;}
case 694:{return JStep.ReturnVoid;}
case 695:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",698);}
case 698:{f.Locals[20]=f.Pop();f.Pc=700;continue;}
case 700:{f.Push(JValue.I(0));f.Pc=701;continue;}
case 701:{f.Locals[21]=f.Pop();f.Pc=703;continue;}
case 703:{f.Push(f.Locals[21]);f.Pc=705;continue;}
case 705:{f.Push(f.Locals[18]);f.Pc=707;continue;}
case 707:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?808:710;continue;}
case 710:{f.Push(f.Locals[19]);f.Pc=712;continue;}
case 712:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",715);}
case 715:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=718;continue;}
case 718:{f.Locals[22]=f.Pop();f.Pc=720;continue;}
case 720:{f.Push(f.Locals[22]);f.Pc=722;continue;}
case 722:{f.Push(f.Locals[3]);f.Pc=723;continue;}
case 723:{f.Push(JValue.I(1));f.Pc=724;continue;}
case 724:{f.Push(f.Locals[2]);f.Pc=725;continue;}
case 725:{f.Push(f.Locals[5]);f.Pc=727;continue;}
case 727:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",730);}
case 730:{f.Push(f.Locals[20]);f.Pc=732;continue;}
case 732:{f.Push(f.Locals[22]);f.Pc=734;continue;}
case 734:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",739);}
case 739:{f.Pc=f.Pop().Int==0?788:742;continue;}
case 742:{f.Push(f.Locals[20]);f.Pc=744;continue;}
case 744:{f.Push(f.Locals[22]);f.Pc=746;continue;}
case 746:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",751);}
case 751:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=754;continue;}
case 754:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",757);}
case 757:{f.Locals[23]=f.Pop();f.Pc=759;continue;}
case 759:{f.Push(f.Locals[23]);f.Pc=761;continue;}
case 761:{f.Push(JValue.I(1));f.Pc=762;continue;}
case 762:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=763;continue;}
case 763:{f.Locals[24]=f.Pop();f.Pc=765;continue;}
case 765:{f.Push(f.Locals[20]);f.Pc=767;continue;}
case 767:{f.Push(f.Locals[22]);f.Pc=769;continue;}
case 769:{f.Push(f.Locals[23]);f.Pc=771;continue;}
case 771:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",774);}
case 774:{f.Push(f.Locals[24]);f.Pc=776;continue;}
case 776:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",779);}
case 779:{return rt.Call(f,"java/util/Map","replace","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",784);}
case 784:{f.StackOp("pop");f.Pc=785;continue;}
case 785:{f.Pc=802;continue;}
case 788:{f.Push(f.Locals[20]);f.Pc=790;continue;}
case 790:{f.Push(f.Locals[22]);f.Pc=792;continue;}
case 792:{f.Push(JValue.I(1));f.Pc=793;continue;}
case 793:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",796);}
case 796:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",801);}
case 801:{f.StackOp("pop");f.Pc=802;continue;}
case 802:{f.Locals[21]=JValue.I(unchecked(f.Locals[21].Int+(1)));f.Pc=805;continue;}
case 805:{f.Pc=703;continue;}
case 808:{f.Push(f.Locals[8]);f.Pc=810;continue;}
case 810:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventRandomLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventRandomLog")));f.Pc=813;continue;}
case 813:{f.StackOp("dup");f.Pc=814;continue;}
case 814:{f.Push(f.Locals[0]);f.Pc=815;continue;}
case 815:{f.Push(f.Locals[20]);f.Pc=817;continue;}
case 817:{f.Push(f.Locals[7]);f.Pc=819;continue;}
case 819:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","logOutput","(Ljava/util/Map;Lforge/game/card/Card;)Ljava/lang/String;","invokevirtual",822);}
case 822:{return rt.Call(f,"forge/game/event/GameEventRandomLog","<init>","(Ljava/lang/String;)V","invokespecial",825);}
case 825:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",828);}
case 828:{f.Pc=3189;continue;}
case 831:{f.Push(f.Locals[16]);f.Pc=833;continue;}
case 833:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",838);}
case 838:{f.Locals[19]=f.Pop();f.Pc=840;continue;}
case 840:{f.Push(f.Locals[19]);f.Pc=842;continue;}
case 842:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",847);}
case 847:{f.Pc=f.Pop().Int==0?3189:850;continue;}
case 850:{f.Push(f.Locals[19]);f.Pc=852;continue;}
case 852:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",857);}
case 857:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=860;continue;}
case 860:{f.Locals[20]=f.Pop();f.Pc=862;continue;}
case 862:{f.Push(JValue.R(null));f.Pc=863;continue;}
case 863:{f.Locals[21]=f.Pop();f.Pc=865;continue;}
case 865:{f.Push(f.Locals[20]);f.Pc=867;continue;}
case 867:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=870;continue;}
case 870:{f.Pc=f.Pop().Int==0?908:873;continue;}
case 873:{f.Push(f.Locals[20]);f.Pc=875;continue;}
case 875:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=878;continue;}
case 878:{f.Locals[22]=f.Pop();f.Pc=880;continue;}
case 880:{f.Push(f.Locals[8]);f.Pc=882;continue;}
case 882:{f.Push(f.Locals[22]);f.Pc=884;continue;}
case 884:{f.Push(JValue.R(null));f.Pc=885;continue;}
case 885:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",888);}
case 888:{f.Locals[21]=f.Pop();f.Pc=890;continue;}
case 890:{f.Push(f.Locals[21]);f.Pc=892;continue;}
case 892:{f.Pc=f.Pop().Reference==null?840:895;continue;}
case 895:{f.Push(f.Locals[22]);f.Pc=897;continue;}
case 897:{f.Push(f.Locals[21]);f.Pc=899;continue;}
case 899:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",902);}
case 902:{f.Pc=f.Pop().Int!=0?908:905;continue;}
case 905:{f.Pc=840;continue;}
case 908:{f.Push(f.Locals[1]);f.Pc=909;continue;}
case 909:{f.Push(JValue.R(rt.String("ChooseDifferent")));f.Pc=912;continue;}
case 912:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",915);}
case 915:{f.Pc=f.Pop().Int==0?1115:918;continue;}
case 918:{f.Push(f.Locals[1]);f.Pc=919;continue;}
case 919:{f.Push(JValue.R(rt.String("ChooseDifferent")));f.Pc=922;continue;}
case 922:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",925);}
case 925:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",928);}
case 928:{f.Locals[22]=f.Pop();f.Pc=930;continue;}
case 930:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",933);}
case 933:{f.Locals[23]=f.Pop();f.Pc=935;continue;}
case 935:{f.Push(f.Locals[1]);f.Pc=936;continue;}
case 936:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=938;continue;}
case 938:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",941);}
case 941:{f.Locals[24]=f.Pop();f.Pc=943;continue;}
case 943:{f.Push(JValue.I(0));f.Pc=944;continue;}
case 944:{f.Locals[25]=f.Pop();f.Pc=946;continue;}
case 946:{f.Push(f.Locals[25]);f.Pc=948;continue;}
case 948:{f.Push(f.Locals[22]);f.Pc=950;continue;}
case 950:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?998:953;continue;}
case 953:{f.Push(f.Locals[0]);f.Pc=954;continue;}
case 954:{f.Push(f.Locals[1]);f.Pc=955;continue;}
case 955:{f.Push(f.Locals[24]);f.Pc=957;continue;}
case 957:{f.Push(f.Locals[20]);f.Pc=959;continue;}
case 959:{f.Push(f.Locals[10]);f.Pc=961;continue;}
case 961:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","chooseTypeFromList","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/GameEntity;Lforge/game/player/PlayerController;)Lforge/game/card/CounterType;","invokevirtual",964);}
case 964:{f.Locals[26]=f.Pop();f.Pc=966;continue;}
case 966:{f.Push(f.Locals[23]);f.Pc=968;continue;}
case 968:{f.Push(f.Locals[26]);f.Pc=970;continue;}
case 970:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",975);}
case 975:{f.StackOp("pop");f.Pc=976;continue;}
case 976:{f.Push(f.Locals[24]);f.Pc=978;continue;}
case 978:{f.Push(f.Locals[26]);f.Pc=980;continue;}
case 980:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",985);}
case 985:{f.Push(JValue.R(rt.String("")));f.Pc=987;continue;}
case 987:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",990);}
case 990:{f.Locals[24]=f.Pop();f.Pc=992;continue;}
case 992:{f.Locals[25]=JValue.I(unchecked(f.Locals[25].Int+(1)));f.Pc=995;continue;}
case 995:{f.Pc=946;continue;}
case 998:{f.Push(f.Locals[23]);f.Pc=1000;continue;}
case 1000:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1005);}
case 1005:{f.Locals[25]=f.Pop();f.Pc=1007;continue;}
case 1007:{f.Push(f.Locals[25]);f.Pc=1009;continue;}
case 1009:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1014);}
case 1014:{f.Pc=f.Pop().Int==0?1112:1017;continue;}
case 1017:{f.Push(f.Locals[25]);f.Pc=1019;continue;}
case 1019:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1024);}
case 1024:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1027;continue;}
case 1027:{f.Locals[26]=f.Pop();f.Pc=1029;continue;}
case 1029:{f.Push(f.Locals[20]);f.Pc=1031;continue;}
case 1031:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=1034;continue;}
case 1034:{f.Pc=f.Pop().Int==0?1056:1037;continue;}
case 1037:{f.Push(f.Locals[20]);f.Pc=1039;continue;}
case 1039:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1042;continue;}
case 1042:{f.Locals[27]=f.Pop();f.Pc=1044;continue;}
case 1044:{f.Push(f.Locals[27]);f.Pc=1046;continue;}
case 1046:{f.Push(f.Locals[26]);f.Pc=1048;continue;}
case 1048:{f.Push(f.Locals[4]);f.Pc=1050;continue;}
case 1050:{f.Push(f.Locals[2]);f.Pc=1051;continue;}
case 1051:{f.Push(f.Locals[5]);f.Pc=1053;continue;}
case 1053:{return rt.Call(f,"forge/game/player/Player","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",1056);}
case 1056:{f.Push(f.Locals[20]);f.Pc=1058;continue;}
case 1058:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1061;continue;}
case 1061:{f.Pc=f.Pop().Int==0?1109:1064;continue;}
case 1064:{f.Push(f.Locals[11]);f.Pc=1066;continue;}
case 1066:{f.Pc=f.Pop().Int==0?1097:1069;continue;}
case 1069:{f.Push(f.Locals[1]);f.Pc=1070;continue;}
case 1070:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=1073;continue;}
case 1073:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",1076);}
case 1076:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntityCounterTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1079;continue;}
case 1079:{f.Locals[27]=f.Pop();f.Pc=1081;continue;}
case 1081:{f.Push(f.Locals[27]);f.Pc=1083;continue;}
case 1083:{f.Push(f.Locals[2]);f.Pc=1084;continue;}
case 1084:{f.Push(f.Locals[21]);f.Pc=1086;continue;}
case 1086:{f.Push(f.Locals[26]);f.Pc=1088;continue;}
case 1088:{f.Push(f.Locals[4]);f.Pc=1090;continue;}
case 1090:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",1093);}
case 1093:{f.StackOp("pop");f.Pc=1094;continue;}
case 1094:{f.Pc=1109;continue;}
case 1097:{f.Push(f.Locals[21]);f.Pc=1099;continue;}
case 1099:{f.Push(f.Locals[26]);f.Pc=1101;continue;}
case 1101:{f.Push(f.Locals[4]);f.Pc=1103;continue;}
case 1103:{f.Push(f.Locals[2]);f.Pc=1104;continue;}
case 1104:{f.Push(f.Locals[5]);f.Pc=1106;continue;}
case 1106:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",1109);}
case 1109:{f.Pc=1007;continue;}
case 1112:{f.Pc=840;continue;}
case 1115:{f.Push(f.Locals[6]);f.Pc=1117;continue;}
case 1117:{f.Pc=f.Pop().Int==0?1666:1120;continue;}
case 1120:{f.Push(f.Locals[1]);f.Pc=1121;continue;}
case 1121:{f.Push(JValue.R(rt.String("CounterTypes")));f.Pc=1123;continue;}
case 1123:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1126);}
case 1126:{f.Pc=f.Pop().Int==0?1666:1129;continue;}
case 1129:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",1132);}
case 1132:{f.Locals[22]=f.Pop();f.Pc=1134;continue;}
case 1134:{f.Push(f.Locals[1]);f.Pc=1135;continue;}
case 1135:{f.Push(JValue.R(rt.String("CounterTypes")));f.Pc=1137;continue;}
case 1137:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1140);}
case 1140:{f.Locals[23]=f.Pop();f.Pc=1142;continue;}
case 1142:{f.Push(f.Locals[23]);f.Pc=1144;continue;}
case 1144:{f.Push(JValue.R(rt.String("ChosenFromList")));f.Pc=1147;continue;}
case 1147:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1150);}
case 1150:{f.Pc=f.Pop().Int==0?1189:1153;continue;}
case 1153:{f.Push(f.Locals[22]);f.Pc=1155;continue;}
case 1155:{f.Push(f.Locals[0]);f.Pc=1156;continue;}
case 1156:{f.Push(f.Locals[1]);f.Pc=1157;continue;}
case 1157:{f.Push(f.Locals[1]);f.Pc=1158;continue;}
case 1158:{f.Push(JValue.R(rt.String("TypeList")));f.Pc=1161;continue;}
case 1161:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1164);}
case 1164:{f.Push(f.Locals[20]);f.Pc=1166;continue;}
case 1166:{f.Push(f.Locals[10]);f.Pc=1168;continue;}
case 1168:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","chooseTypeFromList","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/GameEntity;Lforge/game/player/PlayerController;)Lforge/game/card/CounterType;","invokevirtual",1171);}
case 1171:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1176);}
case 1176:{f.StackOp("pop");f.Pc=1177;continue;}
case 1177:{f.Push(f.Locals[23]);f.Pc=1179;continue;}
case 1179:{f.Push(JValue.R(rt.String("ChosenFromList")));f.Pc=1182;continue;}
case 1182:{f.Push(JValue.R(rt.String("")));f.Pc=1184;continue;}
case 1184:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",1187);}
case 1187:{f.Locals[23]=f.Pop();f.Pc=1189;continue;}
case 1189:{f.Push(f.Locals[23]);f.Pc=1191;continue;}
case 1191:{f.Push(JValue.R(rt.String(",")));f.Pc=1193;continue;}
case 1193:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1196);}
case 1196:{f.Locals[24]=f.Pop();f.Pc=1198;continue;}
case 1198:{f.Push(f.Locals[24]);f.Pc=1200;continue;}
case 1200:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1201;continue;}
case 1201:{f.Locals[25]=f.Pop();f.Pc=1203;continue;}
case 1203:{f.Push(JValue.I(0));f.Pc=1204;continue;}
case 1204:{f.Locals[26]=f.Pop();f.Pc=1206;continue;}
case 1206:{f.Push(f.Locals[26]);f.Pc=1208;continue;}
case 1208:{f.Push(f.Locals[25]);f.Pc=1210;continue;}
case 1210:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1427:1213;continue;}
case 1213:{f.Push(f.Locals[24]);f.Pc=1215;continue;}
case 1215:{f.Push(f.Locals[26]);f.Pc=1217;continue;}
case 1217:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1218;continue;}
case 1218:{f.Locals[27]=f.Pop();f.Pc=1220;continue;}
case 1220:{f.Push(f.Locals[27]);f.Pc=1222;continue;}
case 1222:{f.Push(JValue.R(rt.String("EachType")));f.Pc=1225;continue;}
case 1225:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",1228);}
case 1228:{f.Pc=f.Pop().Int==0?1408:1231;continue;}
case 1231:{f.Push(f.Locals[8]);f.Pc=1233;continue;}
case 1233:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1236;continue;}
case 1236:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1239);}
case 1239:{f.Push(f.Locals[27]);f.Pc=1241;continue;}
case 1241:{f.Push(JValue.R(rt.String("_")));f.Pc=1244;continue;}
case 1244:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1247);}
case 1247:{f.Push(JValue.I(1));f.Pc=1248;continue;}
case 1248:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1249;continue;}
case 1249:{f.Push(f.Locals[9]);f.Pc=1251;continue;}
case 1251:{f.Push(f.Locals[7]);f.Pc=1253;continue;}
case 1253:{f.Push(f.Locals[1]);f.Pc=1254;continue;}
case 1254:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1257);}
case 1257:{f.Locals[28]=f.Pop();f.Pc=1259;continue;}
case 1259:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","()Ljava/util/LinkedHashSet;","invokestatic",1262);}
case 1262:{f.Locals[29]=f.Pop();f.Pc=1264;continue;}
case 1264:{f.Push(f.Locals[28]);f.Pc=1266;continue;}
case 1266:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1271);}
case 1271:{f.Locals[30]=f.Pop();f.Pc=1273;continue;}
case 1273:{f.Push(f.Locals[30]);f.Pc=1275;continue;}
case 1275:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1280);}
case 1280:{f.Pc=f.Pop().Int==0?1316:1283;continue;}
case 1283:{f.Push(f.Locals[30]);f.Pc=1285;continue;}
case 1285:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1290);}
case 1290:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1293;continue;}
case 1293:{f.Locals[31]=f.Pop();f.Pc=1295;continue;}
case 1295:{f.Push(f.Locals[29]);f.Pc=1297;continue;}
case 1297:{f.Push(f.Locals[31]);f.Pc=1299;continue;}
case 1299:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",1302);}
case 1302:{return rt.Call(f,"com/google/common/collect/Multiset","elementSet","()Ljava/util/Set;","invokeinterface",1307);}
case 1307:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",1312);}
case 1312:{f.StackOp("pop");f.Pc=1313;continue;}
case 1313:{f.Pc=1273;continue;}
case 1316:{f.Push(f.Locals[29]);f.Pc=1318;continue;}
case 1318:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",1323);}
case 1323:{f.Locals[30]=f.Pop();f.Pc=1325;continue;}
case 1325:{f.Push(f.Locals[30]);f.Pc=1327;continue;}
case 1327:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1332);}
case 1332:{f.Pc=f.Pop().Int==0?1405:1335;continue;}
case 1335:{f.Push(f.Locals[30]);f.Pc=1337;continue;}
case 1337:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1342);}
case 1342:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1345;continue;}
case 1345:{f.Locals[31]=f.Pop();f.Pc=1347;continue;}
case 1347:{f.Push(f.Locals[1]);f.Pc=1348;continue;}
case 1348:{f.Push(JValue.R(rt.String("AltChoiceForEach")));f.Pc=1351;continue;}
case 1351:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1354);}
case 1354:{f.Pc=f.Pop().Int==0?1389:1357;continue;}
case 1357:{f.Push(f.Locals[1]);f.Pc=1358;continue;}
case 1358:{f.Push(JValue.R(rt.String("AltChoiceForEach")));f.Pc=1361;continue;}
case 1361:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1364);}
case 1364:{f.Push(f.Locals[31]);f.Pc=1366;continue;}
case 1366:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",1369);}
case 1369:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3266:1369:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1374);}
case 1374:{f.Locals[32]=f.Pop();f.Pc=1376;continue;}
case 1376:{f.Push(f.Locals[0]);f.Pc=1377;continue;}
case 1377:{f.Push(f.Locals[1]);f.Pc=1378;continue;}
case 1378:{f.Push(f.Locals[32]);f.Pc=1380;continue;}
case 1380:{f.Push(f.Locals[20]);f.Pc=1382;continue;}
case 1382:{f.Push(f.Locals[10]);f.Pc=1384;continue;}
case 1384:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","chooseTypeFromList","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/GameEntity;Lforge/game/player/PlayerController;)Lforge/game/card/CounterType;","invokevirtual",1387);}
case 1387:{f.Locals[31]=f.Pop();f.Pc=1389;continue;}
case 1389:{f.Push(f.Locals[0]);f.Pc=1390;continue;}
case 1390:{f.Push(f.Locals[1]);f.Pc=1391;continue;}
case 1391:{f.Push(f.Locals[2]);f.Pc=1392;continue;}
case 1392:{f.Push(f.Locals[31]);f.Pc=1394;continue;}
case 1394:{f.Push(f.Locals[4]);f.Pc=1396;continue;}
case 1396:{f.Push(f.Locals[5]);f.Pc=1398;continue;}
case 1398:{f.Push(JValue.I(0));f.Pc=1399;continue;}
case 1399:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","resolvePerType","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/CounterType;ILforge/game/GameEntityCounterTable;Z)V","invokevirtual",1402);}
case 1402:{f.Pc=1325;continue;}
case 1405:{f.Pc=1421;continue;}
case 1408:{f.Push(f.Locals[22]);f.Pc=1410;continue;}
case 1410:{f.Push(f.Locals[27]);f.Pc=1412;continue;}
case 1412:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",1415);}
case 1415:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1420);}
case 1420:{f.StackOp("pop");f.Pc=1421;continue;}
case 1421:{f.Locals[26]=JValue.I(unchecked(f.Locals[26].Int+(1)));f.Pc=1424;continue;}
case 1424:{f.Pc=1206;continue;}
case 1427:{f.Push(f.Locals[4]);f.Pc=1429;continue;}
case 1429:{f.Locals[24]=f.Pop();f.Pc=1431;continue;}
case 1431:{f.Push(f.Locals[22]);f.Pc=1433;continue;}
case 1433:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1438);}
case 1438:{f.Locals[25]=f.Pop();f.Pc=1440;continue;}
case 1440:{f.Push(f.Locals[25]);f.Pc=1442;continue;}
case 1442:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1447);}
case 1447:{f.Pc=f.Pop().Int==0?1663:1450;continue;}
case 1450:{f.Push(f.Locals[25]);f.Pc=1452;continue;}
case 1452:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1457);}
case 1457:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1460;continue;}
case 1460:{f.Locals[26]=f.Pop();f.Pc=1462;continue;}
case 1462:{f.Push(f.Locals[1]);f.Pc=1463;continue;}
case 1463:{f.Push(JValue.R(rt.String("SplitAmount")));f.Pc=1466;continue;}
case 1466:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1469);}
case 1469:{f.Pc=f.Pop().Int==0?1580:1472;continue;}
case 1472:{f.Push(f.Locals[22]);f.Pc=1474;continue;}
case 1474:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1479);}
case 1479:{f.Push(f.Locals[22]);f.Pc=1481;continue;}
case 1481:{f.Push(f.Locals[26]);f.Pc=1483;continue;}
case 1483:{return rt.Call(f,"java/util/List","indexOf","(Ljava/lang/Object;)I","invokeinterface",1488);}
case 1488:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=1489;continue;}
case 1489:{f.Push(JValue.I(1));f.Pc=1490;continue;}
case 1490:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1576:1493;continue;}
case 1493:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",1496);}
case 1496:{f.Locals[27]=f.Pop();f.Pc=1498;continue;}
case 1498:{f.Push(f.Locals[27]);f.Pc=1500;continue;}
case 1500:{f.Push(JValue.R(rt.String("Target")));f.Pc=1503;continue;}
case 1503:{f.Push(f.Locals[20]);f.Pc=1505;continue;}
case 1505:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1510);}
case 1510:{f.StackOp("pop");f.Pc=1511;continue;}
case 1511:{f.Push(f.Locals[27]);f.Pc=1513;continue;}
case 1513:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=1515;continue;}
case 1515:{f.Push(f.Locals[3]);f.Pc=1516;continue;}
case 1516:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1521);}
case 1521:{f.StackOp("pop");f.Pc=1522;continue;}
case 1522:{f.Push(f.Locals[10]);f.Pc=1524;continue;}
case 1524:{f.Push(f.Locals[1]);f.Pc=1525;continue;}
case 1525:{f.Push(f.Locals[26]);f.Pc=1527;continue;}
case 1527:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",1530);}
case 1530:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1533);}
case 1533:{f.Push(JValue.R(rt.String("lblHowManyCounters")));f.Pc=1536;continue;}
case 1536:{f.Push(JValue.I(0));f.Pc=1537;continue;}
case 1537:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1540;continue;}
case 1540:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1543);}
case 1543:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3266:1543:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1548);}
case 1548:{f.Push(JValue.I(0));f.Pc=1549;continue;}
case 1549:{f.Push(f.Locals[24]);f.Pc=1551;continue;}
case 1551:{f.Push(f.Locals[27]);f.Pc=1553;continue;}
case 1553:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;IILjava/util/Map;)I","invokevirtual",1556);}
case 1556:{f.Locals[4]=f.Pop();f.Pc=1558;continue;}
case 1558:{f.Push(f.Locals[4]);f.Pc=1560;continue;}
case 1560:{f.Pc=f.Pop().Int!=0?1566:1563;continue;}
case 1563:{f.Pc=1440;continue;}
case 1566:{f.Push(f.Locals[24]);f.Pc=1568;continue;}
case 1568:{f.Push(f.Locals[4]);f.Pc=1570;continue;}
case 1570:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=1571;continue;}
case 1571:{f.Locals[24]=f.Pop();f.Pc=1573;continue;}
case 1573:{f.Pc=1580;continue;}
case 1576:{f.Push(f.Locals[24]);f.Pc=1578;continue;}
case 1578:{f.Locals[4]=f.Pop();f.Pc=1580;continue;}
case 1580:{f.Push(f.Locals[20]);f.Pc=1582;continue;}
case 1582:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=1585;continue;}
case 1585:{f.Pc=f.Pop().Int==0?1607:1588;continue;}
case 1588:{f.Push(f.Locals[20]);f.Pc=1590;continue;}
case 1590:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1593;continue;}
case 1593:{f.Locals[27]=f.Pop();f.Pc=1595;continue;}
case 1595:{f.Push(f.Locals[27]);f.Pc=1597;continue;}
case 1597:{f.Push(f.Locals[26]);f.Pc=1599;continue;}
case 1599:{f.Push(f.Locals[4]);f.Pc=1601;continue;}
case 1601:{f.Push(f.Locals[2]);f.Pc=1602;continue;}
case 1602:{f.Push(f.Locals[5]);f.Pc=1604;continue;}
case 1604:{return rt.Call(f,"forge/game/player/Player","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",1607);}
case 1607:{f.Push(f.Locals[20]);f.Pc=1609;continue;}
case 1609:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1612;continue;}
case 1612:{f.Pc=f.Pop().Int==0?1660:1615;continue;}
case 1615:{f.Push(f.Locals[11]);f.Pc=1617;continue;}
case 1617:{f.Pc=f.Pop().Int==0?1648:1620;continue;}
case 1620:{f.Push(f.Locals[1]);f.Pc=1621;continue;}
case 1621:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=1624;continue;}
case 1624:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",1627);}
case 1627:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntityCounterTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1630;continue;}
case 1630:{f.Locals[27]=f.Pop();f.Pc=1632;continue;}
case 1632:{f.Push(f.Locals[27]);f.Pc=1634;continue;}
case 1634:{f.Push(f.Locals[2]);f.Pc=1635;continue;}
case 1635:{f.Push(f.Locals[21]);f.Pc=1637;continue;}
case 1637:{f.Push(f.Locals[26]);f.Pc=1639;continue;}
case 1639:{f.Push(f.Locals[4]);f.Pc=1641;continue;}
case 1641:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",1644);}
case 1644:{f.StackOp("pop");f.Pc=1645;continue;}
case 1645:{f.Pc=1660;continue;}
case 1648:{f.Push(f.Locals[21]);f.Pc=1650;continue;}
case 1650:{f.Push(f.Locals[26]);f.Pc=1652;continue;}
case 1652:{f.Push(f.Locals[4]);f.Pc=1654;continue;}
case 1654:{f.Push(f.Locals[2]);f.Pc=1655;continue;}
case 1655:{f.Push(f.Locals[5]);f.Pc=1657;continue;}
case 1657:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",1660);}
case 1660:{f.Pc=1440;continue;}
case 1663:{f.Pc=840;continue;}
case 1666:{f.Push(f.Locals[12]);f.Pc=1668;continue;}
case 1668:{f.Pc=f.Pop().Int==0?2147:1671;continue;}
case 1671:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",1674);}
case 1674:{f.Locals[22]=f.Pop();f.Pc=1676;continue;}
case 1676:{f.Push(f.Locals[20]);f.Pc=1678;continue;}
case 1678:{return rt.Call(f,"forge/game/GameEntity","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",1681);}
case 1681:{return rt.Call(f,"com/google/common/collect/Multiset","elementSet","()Ljava/util/Set;","invokeinterface",1686);}
case 1686:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",1691);}
case 1691:{f.Locals[23]=f.Pop();f.Pc=1693;continue;}
case 1693:{f.Push(f.Locals[23]);f.Pc=1695;continue;}
case 1695:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1700);}
case 1700:{f.Pc=f.Pop().Int==0?1743:1703;continue;}
case 1703:{f.Push(f.Locals[23]);f.Pc=1705;continue;}
case 1705:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1710);}
case 1710:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1713;continue;}
case 1713:{f.Locals[24]=f.Pop();f.Pc=1715;continue;}
case 1715:{f.Push(f.Locals[20]);f.Pc=1717;continue;}
case 1717:{f.Push(f.Locals[24]);f.Pc=1719;continue;}
case 1719:{return rt.Call(f,"forge/game/GameEntity","canReceiveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",1722);}
case 1722:{f.Pc=f.Pop().Int!=0?1730:1725;continue;}
case 1725:{f.Push(f.Locals[14]);f.Pc=1727;continue;}
case 1727:{f.Pc=f.Pop().Int==0?1740:1730;continue;}
case 1730:{f.Push(f.Locals[22]);f.Pc=1732;continue;}
case 1732:{f.Push(f.Locals[24]);f.Pc=1734;continue;}
case 1734:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1739);}
case 1739:{f.StackOp("pop");f.Pc=1740;continue;}
case 1740:{f.Pc=1693;continue;}
case 1743:{f.Push(f.Locals[13]);f.Pc=1745;continue;}
case 1745:{f.Pc=f.Pop().Int==0?1832:1748;continue;}
case 1748:{f.Push(f.Locals[22]);f.Pc=1750;continue;}
case 1750:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1755);}
case 1755:{f.Locals[23]=f.Pop();f.Pc=1757;continue;}
case 1757:{f.Push(f.Locals[23]);f.Pc=1759;continue;}
case 1759:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1764);}
case 1764:{f.Pc=f.Pop().Int==0?1829:1767;continue;}
case 1767:{f.Push(f.Locals[23]);f.Pc=1769;continue;}
case 1769:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1774);}
case 1774:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1777;continue;}
case 1777:{f.Locals[24]=f.Pop();f.Pc=1779;continue;}
case 1779:{f.Push(f.Locals[20]);f.Pc=1781;continue;}
case 1781:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=1784;continue;}
case 1784:{f.Pc=f.Pop().Int==0?1806:1787;continue;}
case 1787:{f.Push(f.Locals[20]);f.Pc=1789;continue;}
case 1789:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1792;continue;}
case 1792:{f.Locals[25]=f.Pop();f.Pc=1794;continue;}
case 1794:{f.Push(f.Locals[25]);f.Pc=1796;continue;}
case 1796:{f.Push(f.Locals[24]);f.Pc=1798;continue;}
case 1798:{f.Push(f.Locals[4]);f.Pc=1800;continue;}
case 1800:{f.Push(f.Locals[2]);f.Pc=1801;continue;}
case 1801:{f.Push(f.Locals[5]);f.Pc=1803;continue;}
case 1803:{return rt.Call(f,"forge/game/player/Player","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",1806);}
case 1806:{f.Push(f.Locals[20]);f.Pc=1808;continue;}
case 1808:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1811;continue;}
case 1811:{f.Pc=f.Pop().Int==0?1826:1814;continue;}
case 1814:{f.Push(f.Locals[21]);f.Pc=1816;continue;}
case 1816:{f.Push(f.Locals[24]);f.Pc=1818;continue;}
case 1818:{f.Push(f.Locals[4]);f.Pc=1820;continue;}
case 1820:{f.Push(f.Locals[2]);f.Pc=1821;continue;}
case 1821:{f.Push(f.Locals[5]);f.Pc=1823;continue;}
case 1823:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",1826);}
case 1826:{f.Pc=1757;continue;}
case 1829:{f.Pc=840;continue;}
case 1832:{f.Push(f.Locals[22]);f.Pc=1834;continue;}
case 1834:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1839);}
case 1839:{f.Pc=f.Pop().Int==0?1845:1842;continue;}
case 1842:{f.Pc=840;continue;}
case 1845:{f.Push(f.Locals[22]);f.Pc=1847;continue;}
case 1847:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1852);}
case 1852:{f.Push(JValue.I(1));f.Pc=1853;continue;}
case 1853:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1871:1856;continue;}
case 1856:{f.Push(f.Locals[22]);f.Pc=1858;continue;}
case 1858:{f.Push(JValue.I(0));f.Pc=1859;continue;}
case 1859:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",1864);}
case 1864:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1867;continue;}
case 1867:{f.Locals[3]=f.Pop();f.Pc=1868;continue;}
case 1868:{f.Pc=1948;continue;}
case 1871:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",1874);}
case 1874:{f.Locals[23]=f.Pop();f.Pc=1876;continue;}
case 1876:{f.Push(f.Locals[23]);f.Pc=1878;continue;}
case 1878:{f.Push(JValue.R(rt.String("Target")));f.Pc=1881;continue;}
case 1881:{f.Push(f.Locals[20]);f.Pc=1883;continue;}
case 1883:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1888);}
case 1888:{f.StackOp("pop");f.Pc=1889;continue;}
case 1889:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1892);}
case 1892:{f.Push(JValue.R(rt.String("lblSelectCounterTypeAddTo")));f.Pc=1895;continue;}
case 1895:{f.Push(JValue.I(0));f.Pc=1896;continue;}
case 1896:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1899;continue;}
case 1899:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1902);}
case 1902:{f.Push(f.Locals[14]);f.Pc=1904;continue;}
case 1904:{f.Pc=f.Pop().Int==0?1923:1907;continue;}
case 1907:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1910);}
case 1910:{f.Push(JValue.R(rt.String("lblEachOther")));f.Pc=1913;continue;}
case 1913:{f.Push(JValue.I(0));f.Pc=1914;continue;}
case 1914:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1917;continue;}
case 1917:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1920);}
case 1920:{f.Pc=1925;continue;}
case 1923:{f.Push(f.Locals[20]);f.Pc=1925;continue;}
case 1925:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1928);}
case 1928:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3266:1928:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1933);}
case 1933:{f.Locals[24]=f.Pop();f.Pc=1935;continue;}
case 1935:{f.Push(f.Locals[10]);f.Pc=1937;continue;}
case 1937:{f.Push(f.Locals[22]);f.Pc=1939;continue;}
case 1939:{f.Push(f.Locals[1]);f.Pc=1940;continue;}
case 1940:{f.Push(f.Locals[24]);f.Pc=1942;continue;}
case 1942:{f.Push(f.Locals[23]);f.Pc=1944;continue;}
case 1944:{return rt.Call(f,"forge/game/player/PlayerController","chooseCounterType","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/CounterType;","invokevirtual",1947);}
case 1947:{f.Locals[3]=f.Pop();f.Pc=1948;continue;}
case 1948:{f.Push(f.Locals[14]);f.Pc=1950;continue;}
case 1950:{f.Pc=f.Pop().Int==0?2049:1953;continue;}
case 1953:{f.Push(f.Locals[8]);f.Pc=1955;continue;}
case 1955:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1958;continue;}
case 1958:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1961);}
case 1961:{f.Push(f.Locals[1]);f.Pc=1962;continue;}
case 1962:{f.Push(JValue.R(rt.String("PutOnEachOther")));f.Pc=1965;continue;}
case 1965:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1968);}
case 1968:{f.Push(f.Locals[9]);f.Pc=1970;continue;}
case 1970:{f.Push(f.Locals[7]);f.Pc=1972;continue;}
case 1972:{f.Push(f.Locals[1]);f.Pc=1973;continue;}
case 1973:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1976);}
case 1976:{f.Locals[23]=f.Pop();f.Pc=1978;continue;}
case 1978:{f.Push(f.Locals[23]);f.Pc=1980;continue;}
case 1980:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1985);}
case 1985:{f.Locals[24]=f.Pop();f.Pc=1987;continue;}
case 1987:{f.Push(f.Locals[24]);f.Pc=1989;continue;}
case 1989:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1994);}
case 1994:{f.Pc=f.Pop().Int==0?2046:1997;continue;}
case 1997:{f.Push(f.Locals[24]);f.Pc=1999;continue;}
case 1999:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2004);}
case 2004:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2007;continue;}
case 2007:{f.Locals[25]=f.Pop();f.Pc=2009;continue;}
case 2009:{f.Push(f.Locals[25]);f.Pc=2011;continue;}
case 2011:{f.Push(f.Locals[20]);f.Pc=2013;continue;}
case 2013:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",2016);}
case 2016:{f.Pc=f.Pop().Int==0?2022:2019;continue;}
case 2019:{f.Pc=1987;continue;}
case 2022:{f.Push(f.Locals[8]);f.Pc=2024;continue;}
case 2024:{f.Push(f.Locals[25]);f.Pc=2026;continue;}
case 2026:{f.Push(JValue.R(null));f.Pc=2027;continue;}
case 2027:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",2030);}
case 2030:{f.Locals[26]=f.Pop();f.Pc=2032;continue;}
case 2032:{f.Push(f.Locals[26]);f.Pc=2034;continue;}
case 2034:{f.Push(f.Locals[3]);f.Pc=2035;continue;}
case 2035:{f.Push(f.Locals[4]);f.Pc=2037;continue;}
case 2037:{f.Push(f.Locals[2]);f.Pc=2038;continue;}
case 2038:{f.Push(f.Locals[5]);f.Pc=2040;continue;}
case 2040:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",2043);}
case 2043:{f.Pc=1987;continue;}
case 2046:{f.Pc=840;continue;}
case 2049:{f.Push(f.Locals[15]);f.Pc=2051;continue;}
case 2051:{f.Pc=f.Pop().Int==0?2147:2054;continue;}
case 2054:{f.Push(f.Locals[7]);f.Pc=2056;continue;}
case 2056:{f.Push(f.Locals[1]);f.Pc=2057;continue;}
case 2057:{f.Push(JValue.R(rt.String("PutOnDefined")));f.Pc=2060;continue;}
case 2060:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2063);}
case 2063:{f.Push(f.Locals[1]);f.Pc=2064;continue;}
case 2064:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",2067);}
case 2067:{f.Locals[23]=f.Pop();f.Pc=2069;continue;}
case 2069:{f.Push(f.Locals[23]);f.Pc=2071;continue;}
case 2071:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",2076);}
case 2076:{f.Locals[24]=f.Pop();f.Pc=2078;continue;}
case 2078:{f.Push(f.Locals[24]);f.Pc=2080;continue;}
case 2080:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2085);}
case 2085:{f.Pc=f.Pop().Int==0?2144:2088;continue;}
case 2088:{f.Push(f.Locals[24]);f.Pc=2090;continue;}
case 2090:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2095);}
case 2095:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2098;continue;}
case 2098:{f.Locals[25]=f.Pop();f.Pc=2100;continue;}
case 2100:{f.Push(f.Locals[8]);f.Pc=2102;continue;}
case 2102:{f.Push(f.Locals[25]);f.Pc=2104;continue;}
case 2104:{f.Push(JValue.R(null));f.Pc=2105;continue;}
case 2105:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",2108);}
case 2108:{f.Locals[26]=f.Pop();f.Pc=2110;continue;}
case 2110:{f.Push(f.Locals[1]);f.Pc=2111;continue;}
case 2111:{f.Push(JValue.R(rt.String("OnlyNewKind")));f.Pc=2114;continue;}
case 2114:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2117);}
case 2117:{f.Pc=f.Pop().Int==0?2130:2120;continue;}
case 2120:{f.Push(f.Locals[26]);f.Pc=2122;continue;}
case 2122:{f.Push(f.Locals[3]);f.Pc=2123;continue;}
case 2123:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",2126);}
case 2126:{f.Push(JValue.I(1));f.Pc=2127;continue;}
case 2127:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?2141:2130;continue;}
case 2130:{f.Push(f.Locals[26]);f.Pc=2132;continue;}
case 2132:{f.Push(f.Locals[3]);f.Pc=2133;continue;}
case 2133:{f.Push(f.Locals[4]);f.Pc=2135;continue;}
case 2135:{f.Push(f.Locals[2]);f.Pc=2136;continue;}
case 2136:{f.Push(f.Locals[5]);f.Pc=2138;continue;}
case 2138:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",2141);}
case 2141:{f.Pc=2078;continue;}
case 2144:{f.Pc=840;continue;}
case 2147:{f.Push(f.Locals[1]);f.Pc=2148;continue;}
case 2148:{f.Push(JValue.R(rt.String("EachFromSource")));f.Pc=2151;continue;}
case 2151:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2154);}
case 2154:{f.Pc=f.Pop().Int==0?2329:2157;continue;}
case 2157:{f.Push(f.Locals[7]);f.Pc=2159;continue;}
case 2159:{f.Push(f.Locals[1]);f.Pc=2160;continue;}
case 2160:{f.Push(JValue.R(rt.String("EachFromSource")));f.Pc=2163;continue;}
case 2163:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2166);}
case 2166:{f.Push(f.Locals[1]);f.Pc=2167;continue;}
case 2167:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",2170);}
case 2170:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2173);}
case 2173:{f.Locals[22]=f.Pop();f.Pc=2175;continue;}
case 2175:{f.Push(f.Locals[22]);f.Pc=2177;continue;}
case 2177:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2182);}
case 2182:{f.Pc=f.Pop().Int==0?2326:2185;continue;}
case 2185:{f.Push(f.Locals[22]);f.Pc=2187;continue;}
case 2187:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2192);}
case 2192:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2195;continue;}
case 2195:{f.Locals[23]=f.Pop();f.Pc=2197;continue;}
case 2197:{f.Push(f.Locals[23]);f.Pc=2199;continue;}
case 2199:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",2202);}
case 2202:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",2207);}
case 2207:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",2212);}
case 2212:{f.Locals[24]=f.Pop();f.Pc=2214;continue;}
case 2214:{f.Push(f.Locals[24]);f.Pc=2216;continue;}
case 2216:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2221);}
case 2221:{f.Pc=f.Pop().Int==0?2323:2224;continue;}
case 2224:{f.Push(f.Locals[24]);f.Pc=2226;continue;}
case 2226:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2231);}
case 2231:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2234;continue;}
case 2234:{f.Locals[25]=f.Pop();f.Pc=2236;continue;}
case 2236:{f.Push(f.Locals[21]);f.Pc=2238;continue;}
case 2238:{f.Pc=f.Pop().Reference==null?2320:2241;continue;}
case 2241:{f.Push(f.Locals[1]);f.Pc=2242;continue;}
case 2242:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=2244;continue;}
case 2244:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2247);}
case 2247:{f.Pc=f.Pop().Int!=0?2259:2250;continue;}
case 2250:{f.Push(f.Locals[25]);f.Pc=2252;continue;}
case 2252:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",2257);}
case 2257:{f.Locals[4]=f.Pop();f.Pc=2259;continue;}
case 2259:{f.Push(f.Locals[11]);f.Pc=2261;continue;}
case 2261:{f.Pc=f.Pop().Int==0?2300:2264;continue;}
case 2264:{f.Push(f.Locals[1]);f.Pc=2265;continue;}
case 2265:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=2268;continue;}
case 2268:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",2271);}
case 2271:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntityCounterTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2274;continue;}
case 2274:{f.Locals[26]=f.Pop();f.Pc=2276;continue;}
case 2276:{f.Push(f.Locals[26]);f.Pc=2278;continue;}
case 2278:{f.Push(f.Locals[2]);f.Pc=2279;continue;}
case 2279:{f.Push(f.Locals[21]);f.Pc=2281;continue;}
case 2281:{f.Push(f.Locals[25]);f.Pc=2283;continue;}
case 2283:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",2288);}
case 2288:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2291;continue;}
case 2291:{f.Push(f.Locals[4]);f.Pc=2293;continue;}
case 2293:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",2296);}
case 2296:{f.StackOp("pop");f.Pc=2297;continue;}
case 2297:{f.Pc=2320;continue;}
case 2300:{f.Push(f.Locals[21]);f.Pc=2302;continue;}
case 2302:{f.Push(f.Locals[25]);f.Pc=2304;continue;}
case 2304:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",2309);}
case 2309:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2312;continue;}
case 2312:{f.Push(f.Locals[4]);f.Pc=2314;continue;}
case 2314:{f.Push(f.Locals[2]);f.Pc=2315;continue;}
case 2315:{f.Push(f.Locals[5]);f.Pc=2317;continue;}
case 2317:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",2320);}
case 2320:{f.Pc=2214;continue;}
case 2323:{f.Pc=2175;continue;}
case 2326:{f.Pc=840;continue;}
case 2329:{f.Push(f.Locals[1]);f.Pc=2330;continue;}
case 2330:{f.Push(JValue.R(rt.String("CounterTypePerDefined")));f.Pc=2333;continue;}
case 2333:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2336);}
case 2336:{f.Pc=f.Pop().Int!=0?2349:2339;continue;}
case 2339:{f.Push(f.Locals[1]);f.Pc=2340;continue;}
case 2340:{f.Push(JValue.R(rt.String("UniqueType")));f.Pc=2343;continue;}
case 2343:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2346);}
case 2346:{f.Pc=f.Pop().Int==0?2372:2349;continue;}
case 2349:{f.Push(f.Locals[0]);f.Pc=2350;continue;}
case 2350:{f.Push(f.Locals[1]);f.Pc=2351;continue;}
case 2351:{f.Push(f.Locals[1]);f.Pc=2352;continue;}
case 2352:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=2354;continue;}
case 2354:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2357);}
case 2357:{f.Push(f.Locals[20]);f.Pc=2359;continue;}
case 2359:{f.Push(f.Locals[10]);f.Pc=2361;continue;}
case 2361:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","chooseTypeFromList","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/GameEntity;Lforge/game/player/PlayerController;)Lforge/game/card/CounterType;","invokevirtual",2364);}
case 2364:{f.Locals[3]=f.Pop();f.Pc=2365;continue;}
case 2365:{f.Push(f.Locals[3]);f.Pc=2366;continue;}
case 2366:{f.Pc=f.Pop().Reference!=null?2372:2369;continue;}
case 2369:{f.Pc=840;continue;}
case 2372:{f.Push(f.Locals[20]);f.Pc=2374;continue;}
case 2374:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=2377;continue;}
case 2377:{f.Pc=f.Pop().Int==0?3160:2380;continue;}
case 2380:{f.Push(f.Locals[1]);f.Pc=2381;continue;}
case 2381:{f.Push(JValue.R(rt.String("CounterNumPerDefined")));f.Pc=2384;continue;}
case 2384:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2387);}
case 2387:{f.Pc=f.Pop().Int==0?2405:2390;continue;}
case 2390:{f.Push(f.Locals[21]);f.Pc=2392;continue;}
case 2392:{f.Push(f.Locals[1]);f.Pc=2393;continue;}
case 2393:{f.Push(JValue.R(rt.String("CounterNumPerDefined")));f.Pc=2396;continue;}
case 2396:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2399);}
case 2399:{f.Push(f.Locals[1]);f.Pc=2400;continue;}
case 2400:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",2403);}
case 2403:{f.Locals[4]=f.Pop();f.Pc=2405;continue;}
case 2405:{f.Push(f.Locals[1]);f.Pc=2406;continue;}
case 2406:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",2409);}
case 2409:{f.Pc=f.Pop().Int==0?2431:2412;continue;}
case 2412:{f.Push(f.Locals[1]);f.Pc=2413;continue;}
case 2413:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",2416);}
case 2416:{f.Pc=f.Pop().Int==0?2431:2419;continue;}
case 2419:{f.Push(f.Locals[1]);f.Pc=2420;continue;}
case 2420:{f.Push(f.Locals[21]);f.Pc=2422;continue;}
case 2422:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDividedValue","(Lforge/game/GameObject;)Ljava/lang/Integer;","invokevirtual",2425);}
case 2425:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",2428);}
case 2428:{f.Pc=2433;continue;}
case 2431:{f.Push(f.Locals[4]);f.Pc=2433;continue;}
case 2433:{f.Locals[4]=f.Pop();f.Pc=2435;continue;}
case 2435:{f.Push(f.Locals[1]);f.Pc=2436;continue;}
case 2436:{f.Push(JValue.R(rt.String("UpTo")));f.Pc=2438;continue;}
case 2438:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2441);}
case 2441:{f.Pc=f.Pop().Int==0?2518:2444;continue;}
case 2444:{f.Push(f.Locals[7]);f.Pc=2446;continue;}
case 2446:{f.Push(f.Locals[1]);f.Pc=2447;continue;}
case 2447:{f.Push(JValue.R(rt.String("UpToMin")));f.Pc=2450;continue;}
case 2450:{f.Push(JValue.R(rt.String("0")));f.Pc=2453;continue;}
case 2453:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2456);}
case 2456:{f.Push(f.Locals[1]);f.Pc=2457;continue;}
case 2457:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",2460);}
case 2460:{f.Locals[23]=f.Pop();f.Pc=2462;continue;}
case 2462:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",2465);}
case 2465:{f.Locals[24]=f.Pop();f.Pc=2467;continue;}
case 2467:{f.Push(f.Locals[24]);f.Pc=2469;continue;}
case 2469:{f.Push(JValue.R(rt.String("Target")));f.Pc=2472;continue;}
case 2472:{f.Push(f.Locals[20]);f.Pc=2474;continue;}
case 2474:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2479);}
case 2479:{f.StackOp("pop");f.Pc=2480;continue;}
case 2480:{f.Push(f.Locals[24]);f.Pc=2482;continue;}
case 2482:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=2484;continue;}
case 2484:{f.Push(f.Locals[3]);f.Pc=2485;continue;}
case 2485:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2490);}
case 2490:{f.StackOp("pop");f.Pc=2491;continue;}
case 2491:{f.Push(f.Locals[10]);f.Pc=2493;continue;}
case 2493:{f.Push(f.Locals[1]);f.Pc=2494;continue;}
case 2494:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2497);}
case 2497:{f.Push(JValue.R(rt.String("lblHowManyCounters")));f.Pc=2500;continue;}
case 2500:{f.Push(JValue.I(0));f.Pc=2501;continue;}
case 2501:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2504;continue;}
case 2504:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2507);}
case 2507:{f.Push(f.Locals[23]);f.Pc=2509;continue;}
case 2509:{f.Push(f.Locals[4]);f.Pc=2511;continue;}
case 2511:{f.Push(f.Locals[24]);f.Pc=2513;continue;}
case 2513:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;IILjava/util/Map;)I","invokevirtual",2516);}
case 2516:{f.Locals[4]=f.Pop();f.Pc=2518;continue;}
case 2518:{f.Push(f.Locals[1]);f.Pc=2519;continue;}
case 2519:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",2522);}
case 2522:{f.Pc=f.Pop().Int==0?2623:2525;continue;}
case 2525:{f.Push(f.Locals[1]);f.Pc=2526;continue;}
case 2526:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",2529);}
case 2529:{f.Pc=f.Pop().Int!=0?2623:2532;continue;}
case 2532:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",2535);}
case 2535:{f.Locals[23]=f.Pop();f.Pc=2537;continue;}
case 2537:{f.Push(f.Locals[23]);f.Pc=2539;continue;}
case 2539:{f.Push(JValue.R(rt.String("Target")));f.Pc=2542;continue;}
case 2542:{f.Push(f.Locals[20]);f.Pc=2544;continue;}
case 2544:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2549);}
case 2549:{f.StackOp("pop");f.Pc=2550;continue;}
case 2550:{f.Push(f.Locals[23]);f.Pc=2552;continue;}
case 2552:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=2554;continue;}
case 2554:{f.Push(f.Locals[3]);f.Pc=2555;continue;}
case 2555:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2560);}
case 2560:{f.StackOp("pop");f.Pc=2561;continue;}
case 2561:{f.Locals[17]=JValue.I(unchecked(f.Locals[17].Int+(1)));f.Pc=2564;continue;}
case 2564:{f.Push(f.Locals[17]);f.Pc=2566;continue;}
case 2566:{f.Push(f.Locals[16]);f.Pc=2568;continue;}
case 2568:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",2573);}
case 2573:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?2582:2576;continue;}
case 2576:{f.Push(f.Locals[18]);f.Pc=2578;continue;}
case 2578:{f.Push(JValue.I(1));f.Pc=2579;continue;}
case 2579:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?2589:2582;continue;}
case 2582:{f.Push(f.Locals[18]);f.Pc=2584;continue;}
case 2584:{f.Locals[4]=f.Pop();f.Pc=2586;continue;}
case 2586:{f.Pc=2623;continue;}
case 2589:{f.Push(f.Locals[10]);f.Pc=2591;continue;}
case 2591:{f.Push(f.Locals[1]);f.Pc=2592;continue;}
case 2592:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2595);}
case 2595:{f.Push(JValue.R(rt.String("lblHowManyCountersThis")));f.Pc=2598;continue;}
case 2598:{f.Push(JValue.I(1));f.Pc=2599;continue;}
case 2599:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2602;continue;}
case 2602:{f.StackOp("dup");f.Pc=2603;continue;}
case 2603:{f.Push(JValue.I(0));f.Pc=2604;continue;}
case 2604:{f.Push(f.Locals[21]);f.Pc=2606;continue;}
case 2606:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",2609);}
case 2609:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2610;continue;}
case 2610:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2613);}
case 2613:{f.Push(JValue.I(1));f.Pc=2614;continue;}
case 2614:{f.Push(f.Locals[18]);f.Pc=2616;continue;}
case 2616:{f.Push(f.Locals[23]);f.Pc=2618;continue;}
case 2618:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;IILjava/util/Map;)I","invokevirtual",2621);}
case 2621:{f.Locals[4]=f.Pop();f.Pc=2623;continue;}
case 2623:{f.Push(f.Locals[1]);f.Pc=2624;continue;}
case 2624:{f.Push(JValue.R(rt.String("Adapt")));f.Pc=2627;continue;}
case 2627:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2630);}
case 2630:{f.Pc=f.Pop().Int==0?2656:2633;continue;}
case 2633:{f.Push(f.Locals[21]);f.Pc=2635;continue;}
case 2635:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"));f.Pc=2638;continue;}
case 2638:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",2641);}
case 2641:{f.Pc=f.Pop().Int==0?2656:2644;continue;}
case 2644:{f.Push(f.Locals[1]);f.Pc=2645;continue;}
case 2645:{f.Push(f.Locals[21]);f.Pc=2647;continue;}
case 2647:{return rt.Call(f,"forge/game/staticability/StaticAbilityAdapt","anyWithAdapt","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)Z","invokestatic",2650);}
case 2650:{f.Pc=f.Pop().Int!=0?2656:2653;continue;}
case 2653:{f.Pc=840;continue;}
case 2656:{f.Push(f.Locals[1]);f.Pc=2657;continue;}
case 2657:{f.Push(JValue.R(rt.String("Monstrosity")));f.Pc=2660;continue;}
case 2660:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2663);}
case 2663:{f.Pc=f.Pop().Int==0?2677:2666;continue;}
case 2666:{f.Push(f.Locals[21]);f.Pc=2668;continue;}
case 2668:{return rt.Call(f,"forge/game/card/Card","isMonstrous","()Z","invokevirtual",2671);}
case 2671:{f.Pc=f.Pop().Int==0?2677:2674;continue;}
case 2674:{f.Pc=840;continue;}
case 2677:{f.Push(f.Locals[1]);f.Pc=2678;continue;}
case 2678:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","TRIBUTE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","TRIBUTE","Lforge/game/keyword/Keyword;"));f.Pc=2681;continue;}
case 2681:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",2684);}
case 2684:{f.Pc=f.Pop().Int==0?2929:2687;continue;}
case 2687:{f.Push(f.Locals[21]);f.Pc=2689;continue;}
case 2689:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",2692);}
case 2692:{f.Locals[23]=f.Pop();f.Pc=2694;continue;}
case 2694:{f.Push(f.Locals[23]);f.Pc=2696;continue;}
case 2696:{f.Push(f.Locals[9]);f.Pc=2698;continue;}
case 2698:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=2701;continue;}
case 2701:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",2704);}
case 2704:{return rt.Call(f,"forge/game/card/Card","setLastKnownZone","(Lforge/game/zone/Zone;)V","invokevirtual",2707);}
case 2707:{f.Push(f.Locals[8]);f.Pc=2709;continue;}
case 2709:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",2712);}
case 2712:{return rt.Call(f,"forge/trackable/Tracker","freeze","()V","invokevirtual",2715);}
case 2715:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=2718;continue;}
case 2718:{f.StackOp("dup");f.Pc=2719;continue;}
case 2719:{f.Push(f.Locals[23]);f.Pc=2721;continue;}
case 2721:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",2724);}
case 2724:{f.Locals[24]=f.Pop();f.Pc=2726;continue;}
case 2726:{f.Push(f.Locals[8]);f.Pc=2728;continue;}
case 2728:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",2731);}
case 2731:{f.Push(JValue.I(0));f.Pc=2732;continue;}
case 2732:{f.Push(JValue.I(1));f.Pc=2733;continue;}
case 2733:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=2736;continue;}
case 2736:{f.StackOp("dup");f.Pc=2737;continue;}
case 2737:{f.Push(JValue.I(0));f.Pc=2738;continue;}
case 2738:{f.Push(f.Locals[23]);f.Pc=2740;continue;}
case 2740:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2741;continue;}
case 2741:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","([Ljava/lang/Object;)Ljava/util/HashSet;","invokestatic",2744);}
case 2744:{f.Push(f.Locals[24]);f.Pc=2746;continue;}
case 2746:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;)V","invokevirtual",2749);}
case 2749:{f.Push(f.Locals[23]);f.Pc=2751;continue;}
case 2751:{f.Push(f.Locals[3]);f.Pc=2752;continue;}
case 2752:{return rt.Call(f,"forge/game/card/Card","canReceiveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",2755);}
case 2755:{f.Pc=f.Pop().Int!=0?2762:2758;continue;}
case 2758:{f.Push(JValue.I(1));f.Pc=2759;continue;}
case 2759:{f.Pc=2763;continue;}
case 2762:{f.Push(JValue.I(0));f.Pc=2763;continue;}
case 2763:{f.Locals[25]=f.Pop();f.Pc=2765;continue;}
case 2765:{f.Push(f.Locals[8]);f.Pc=2767;continue;}
case 2767:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",2770);}
case 2770:{f.Push(JValue.I(0));f.Pc=2771;continue;}
case 2771:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(Z)V","invokevirtual",2774);}
case 2774:{f.Push(f.Locals[8]);f.Pc=2776;continue;}
case 2776:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",2779);}
case 2779:{return rt.Call(f,"forge/trackable/Tracker","clearDelayed","()V","invokevirtual",2782);}
case 2782:{f.Push(f.Locals[8]);f.Pc=2784;continue;}
case 2784:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",2787);}
case 2787:{return rt.Call(f,"forge/trackable/Tracker","unfreeze","()V","invokevirtual",2790);}
case 2790:{f.Push(f.Locals[25]);f.Pc=2792;continue;}
case 2792:{f.Pc=f.Pop().Int==0?2798:2795;continue;}
case 2795:{f.Pc=840;continue;}
case 2798:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",2801);}
case 2801:{f.Locals[26]=f.Pop();f.Pc=2803;continue;}
case 2803:{f.Push(f.Locals[26]);f.Pc=2805;continue;}
case 2805:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=2807;continue;}
case 2807:{f.Push(f.Locals[3]);f.Pc=2808;continue;}
case 2808:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2813);}
case 2813:{f.StackOp("pop");f.Pc=2814;continue;}
case 2814:{f.Push(f.Locals[26]);f.Pc=2816;continue;}
case 2816:{f.Push(JValue.R(rt.String("Amount")));f.Pc=2819;continue;}
case 2819:{f.Push(f.Locals[4]);f.Pc=2821;continue;}
case 2821:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",2824);}
case 2824:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2829);}
case 2829:{f.StackOp("pop");f.Pc=2830;continue;}
case 2830:{f.Push(f.Locals[26]);f.Pc=2832;continue;}
case 2832:{f.Push(JValue.R(rt.String("Target")));f.Pc=2835;continue;}
case 2835:{f.Push(f.Locals[21]);f.Pc=2837;continue;}
case 2837:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",2842);}
case 2842:{f.StackOp("pop");f.Pc=2843;continue;}
case 2843:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2846);}
case 2846:{f.Push(JValue.R(rt.String("lblDoYouWantPutTargetP1P1CountersOnCard")));f.Pc=2849;continue;}
case 2849:{f.Push(JValue.I(2));f.Pc=2850;continue;}
case 2850:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2853;continue;}
case 2853:{f.StackOp("dup");f.Pc=2854;continue;}
case 2854:{f.Push(JValue.I(0));f.Pc=2855;continue;}
case 2855:{f.Push(f.Locals[4]);f.Pc=2857;continue;}
case 2857:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",2860);}
case 2860:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2861;continue;}
case 2861:{f.StackOp("dup");f.Pc=2862;continue;}
case 2862:{f.Push(JValue.I(1));f.Pc=2863;continue;}
case 2863:{f.Push(f.Locals[21]);f.Pc=2865;continue;}
case 2865:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",2868);}
case 2868:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2869;continue;}
case 2869:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2872);}
case 2872:{f.Locals[27]=f.Pop();f.Pc=2874;continue;}
case 2874:{f.Push(f.Locals[10]);f.Pc=2876;continue;}
case 2876:{f.Push(f.Locals[9]);f.Pc=2878;continue;}
case 2878:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",2881);}
case 2881:{f.Push(f.Locals[1]);f.Pc=2882;continue;}
case 2882:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2885);}
case 2885:{f.Push(JValue.R(rt.String("lblChooseAnOpponent")));f.Pc=2888;continue;}
case 2888:{f.Push(JValue.I(0));f.Pc=2889;continue;}
case 2889:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2892;continue;}
case 2892:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2895);}
case 2895:{f.Push(f.Locals[26]);f.Pc=2897;continue;}
case 2897:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",2900);}
case 2900:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2903;continue;}
case 2903:{f.Locals[2]=f.Pop();f.Pc=2904;continue;}
case 2904:{f.Push(f.Locals[2]);f.Pc=2905;continue;}
case 2905:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2908);}
case 2908:{f.Push(f.Locals[1]);f.Pc=2909;continue;}
case 2909:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","Tribute","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","Tribute","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=2912;continue;}
case 2912:{f.Push(f.Locals[27]);f.Pc=2914;continue;}
case 2914:{f.Push(f.Locals[21]);f.Pc=2916;continue;}
case 2916:{f.Push(JValue.R(null));f.Pc=2917;continue;}
case 2917:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",2920);}
case 2920:{f.Pc=f.Pop().Int==0?840:2923;continue;}
case 2923:{f.Push(f.Locals[21]);f.Pc=2925;continue;}
case 2925:{f.Push(JValue.I(1));f.Pc=2926;continue;}
case 2926:{return rt.Call(f,"forge/game/card/Card","setTributed","(Z)V","invokevirtual",2929);}
case 2929:{f.Push(f.Locals[11]);f.Pc=2931;continue;}
case 2931:{f.Pc=f.Pop().Int==0?2961:2934;continue;}
case 2934:{f.Push(f.Locals[1]);f.Pc=2935;continue;}
case 2935:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=2938;continue;}
case 2938:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",2941);}
case 2941:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntityCounterTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2944;continue;}
case 2944:{f.Locals[23]=f.Pop();f.Pc=2946;continue;}
case 2946:{f.Push(f.Locals[23]);f.Pc=2948;continue;}
case 2948:{f.Push(f.Locals[2]);f.Pc=2949;continue;}
case 2949:{f.Push(f.Locals[21]);f.Pc=2951;continue;}
case 2951:{f.Push(f.Locals[3]);f.Pc=2952;continue;}
case 2952:{f.Push(f.Locals[4]);f.Pc=2954;continue;}
case 2954:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",2957);}
case 2957:{f.StackOp("pop");f.Pc=2958;continue;}
case 2958:{f.Pc=2972;continue;}
case 2961:{f.Push(f.Locals[21]);f.Pc=2963;continue;}
case 2963:{f.Push(f.Locals[3]);f.Pc=2964;continue;}
case 2964:{f.Push(f.Locals[4]);f.Pc=2966;continue;}
case 2966:{f.Push(f.Locals[2]);f.Pc=2967;continue;}
case 2967:{f.Push(f.Locals[5]);f.Pc=2969;continue;}
case 2969:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",2972);}
case 2972:{f.Push(f.Locals[1]);f.Pc=2973;continue;}
case 2973:{f.Push(JValue.R(rt.String("Monstrosity")));f.Pc=2976;continue;}
case 2976:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2979);}
case 2979:{f.Pc=f.Pop().Int==0?3025:2982;continue;}
case 2982:{f.Push(f.Locals[21]);f.Pc=2984;continue;}
case 2984:{f.Push(JValue.I(1));f.Pc=2985;continue;}
case 2985:{return rt.Call(f,"forge/game/card/Card","setMonstrous","(Z)V","invokevirtual",2988);}
case 2988:{f.Push(f.Locals[21]);f.Pc=2990;continue;}
case 2990:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",2993);}
case 2993:{f.Locals[23]=f.Pop();f.Pc=2995;continue;}
case 2995:{f.Push(f.Locals[23]);f.Pc=2997;continue;}
case 2997:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"));f.Pc=3000;continue;}
case 3000:{f.Push(f.Locals[4]);f.Pc=3002;continue;}
case 3002:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",3005);}
case 3005:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3010);}
case 3010:{f.StackOp("pop");f.Pc=3011;continue;}
case 3011:{f.Push(f.Locals[8]);f.Pc=3013;continue;}
case 3013:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",3016);}
case 3016:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","BecomeMonstrous","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","BecomeMonstrous","Lforge/game/trigger/TriggerType;"));f.Pc=3019;continue;}
case 3019:{f.Push(f.Locals[23]);f.Pc=3021;continue;}
case 3021:{f.Push(JValue.I(0));f.Pc=3022;continue;}
case 3022:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",3025);}
case 3025:{f.Push(f.Locals[1]);f.Pc=3026;continue;}
case 3026:{f.Push(JValue.R(rt.String("Adapt")));f.Pc=3029;continue;}
case 3029:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3032);}
case 3032:{f.Pc=f.Pop().Int==0?3052:3035;continue;}
case 3035:{f.Push(f.Locals[8]);f.Pc=3037;continue;}
case 3037:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",3040);}
case 3040:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Adapt","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Adapt","Lforge/game/trigger/TriggerType;"));f.Pc=3043;continue;}
case 3043:{f.Push(f.Locals[21]);f.Pc=3045;continue;}
case 3045:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",3048);}
case 3048:{f.Push(JValue.I(0));f.Pc=3049;continue;}
case 3049:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",3052);}
case 3052:{f.Push(f.Locals[1]);f.Pc=3053;continue;}
case 3053:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","RENOWN","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","RENOWN","Lforge/game/keyword/Keyword;"));f.Pc=3056;continue;}
case 3056:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",3059);}
case 3059:{f.Pc=f.Pop().Int==0?3085:3062;continue;}
case 3062:{f.Push(f.Locals[21]);f.Pc=3064;continue;}
case 3064:{f.Push(JValue.I(1));f.Pc=3065;continue;}
case 3065:{return rt.Call(f,"forge/game/card/Card","setRenowned","(Z)V","invokevirtual",3068);}
case 3068:{f.Push(f.Locals[8]);f.Pc=3070;continue;}
case 3070:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",3073);}
case 3073:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","BecomeRenowned","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","BecomeRenowned","Lforge/game/trigger/TriggerType;"));f.Pc=3076;continue;}
case 3076:{f.Push(f.Locals[21]);f.Pc=3078;continue;}
case 3078:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",3081);}
case 3081:{f.Push(JValue.I(0));f.Pc=3082;continue;}
case 3082:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",3085);}
case 3085:{f.Push(f.Locals[1]);f.Pc=3086;continue;}
case 3086:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","MENTOR","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","MENTOR","Lforge/game/keyword/Keyword;"));f.Pc=3089;continue;}
case 3089:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",3092);}
case 3092:{f.Pc=f.Pop().Int==0?3129:3095;continue;}
case 3095:{f.Push(f.Locals[21]);f.Pc=3097;continue;}
case 3097:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",3100);}
case 3100:{f.Locals[23]=f.Pop();f.Pc=3102;continue;}
case 3102:{f.Push(f.Locals[23]);f.Pc=3104;continue;}
case 3104:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"));f.Pc=3107;continue;}
case 3107:{f.Push(f.Locals[7]);f.Pc=3109;continue;}
case 3109:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3114);}
case 3114:{f.StackOp("pop");f.Pc=3115;continue;}
case 3115:{f.Push(f.Locals[8]);f.Pc=3117;continue;}
case 3117:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",3120);}
case 3120:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Mentored","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Mentored","Lforge/game/trigger/TriggerType;"));f.Pc=3123;continue;}
case 3123:{f.Push(f.Locals[23]);f.Pc=3125;continue;}
case 3125:{f.Push(JValue.I(0));f.Pc=3126;continue;}
case 3126:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",3129);}
case 3129:{f.Push(f.Locals[8]);f.Pc=3131;continue;}
case 3131:{f.Push(f.Locals[21]);f.Pc=3133;continue;}
case 3133:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",3136);}
case 3136:{f.Push(f.Locals[1]);f.Pc=3137;continue;}
case 3137:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",3140);}
case 3140:{f.Pc=f.Pop().Int==0?3186:3143;continue;}
case 3143:{f.Push(f.Locals[1]);f.Pc=3144;continue;}
case 3144:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",3147);}
case 3147:{f.Pc=f.Pop().Int!=0?3186:3150;continue;}
case 3150:{f.Push(f.Locals[18]);f.Pc=3152;continue;}
case 3152:{f.Push(f.Locals[4]);f.Pc=3154;continue;}
case 3154:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=3155;continue;}
case 3155:{f.Locals[18]=f.Pop();f.Pc=3157;continue;}
case 3157:{f.Pc=3186;continue;}
case 3160:{f.Push(f.Locals[20]);f.Pc=3162;continue;}
case 3162:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=3165;continue;}
case 3165:{f.Pc=f.Pop().Int==0?3186:3168;continue;}
case 3168:{f.Push(f.Locals[20]);f.Pc=3170;continue;}
case 3170:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3173;continue;}
case 3173:{f.Locals[22]=f.Pop();f.Pc=3175;continue;}
case 3175:{f.Push(f.Locals[22]);f.Pc=3177;continue;}
case 3177:{f.Push(f.Locals[3]);f.Pc=3178;continue;}
case 3178:{f.Push(f.Locals[4]);f.Pc=3180;continue;}
case 3180:{f.Push(f.Locals[2]);f.Pc=3181;continue;}
case 3181:{f.Push(f.Locals[5]);f.Pc=3183;continue;}
case 3183:{return rt.Call(f,"forge/game/player/Player","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",3186);}
case 3186:{f.Pc=840;continue;}
case 3189:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3267(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("1")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",33);}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Locals[7]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("Placer")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?70:49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("Placer")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",61);}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[7]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Locals[8]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?92:80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",87);}
case 87:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=90;continue;}
case 90:{f.Locals[8]=f.Pop();f.Pc=92;continue;}
case 92:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",99);}
case 99:{f.Locals[9]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("TriggeredCounterMap")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?230:111;continue;}
case 111:{f.Push(JValue.R(null));f.Pc=112;continue;}
case 112:{f.Locals[10]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("CounterMapValues")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?136:124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("CounterMapValues")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",131);}
case 131:{return rt.Call(f,"java/lang/Integer","valueOf","(Ljava/lang/String;)Ljava/lang/Integer;","invokestatic",134);}
case 134:{f.Locals[10]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"));f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",143);}
case 143:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=146;continue;}
case 146:{f.Locals[11]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[11]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",155);}
case 155:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",160);}
case 160:{f.Locals[12]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[12]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",169);}
case 169:{f.Pc=f.Pop().Int==0?227:172;continue;}
case 172:{f.Push(f.Locals[12]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",179);}
case 179:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=182;continue;}
case 182:{f.Locals[13]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[7]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[13]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",195);}
case 195:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[10]);f.Pc=200;continue;}
case 200:{f.Pc=f.Pop().Reference!=null?213:203;continue;}
case 203:{f.Push(f.Locals[13]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",210);}
case 210:{f.Pc=218;continue;}
case 213:{f.Push(f.Locals[10]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",218);}
case 218:{f.Push(f.Locals[9]);f.Pc=220;continue;}
case 220:{f.Push(JValue.I(0));f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","resolvePerType","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/CounterType;ILforge/game/GameEntityCounterTable;Z)V","invokevirtual",224);}
case 224:{f.Pc=162;continue;}
case 227:{f.Pc=663;continue;}
case 230:{f.Push(f.Locals[1]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String("SharedKeywords")));f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",237);}
case 237:{f.Pc=f.Pop().Int==0?404:240;continue;}
case 240:{f.Push(f.Locals[1]);f.Pc=241;continue;}
case 241:{f.Push(JValue.R(rt.String("SharedKeywords")));f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",247);}
case 247:{f.Push(JValue.R(rt.String(" & ")));f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",252);}
case 252:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",255);}
case 255:{f.Locals[10]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[1]);f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String("SharedKeywordsDefined")));f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",264);}
case 264:{f.Pc=f.Pop().Int==0?288:267;continue;}
case 267:{f.Push(f.Locals[1]);f.Pc=268;continue;}
case 268:{f.Push(JValue.R(rt.String("SharedKeywordsDefined")));f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",274);}
case 274:{f.Locals[11]=f.Pop();f.Pc=276;continue;}
case 276:{f.Push(f.Locals[10]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[11]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/card/CardFactoryUtil","getSharedKeywords","(Ljava/lang/Iterable;Lforge/game/card/CardCollection;)Ljava/util/List;","invokestatic",283);}
case 283:{f.Locals[10]=f.Pop();f.Pc=285;continue;}
case 285:{f.Pc=350;continue;}
case 288:{f.Push(f.Locals[1]);f.Pc=289;continue;}
case 289:{f.Push(JValue.R(rt.String("SharedKeywordsZone")));f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",295);}
case 295:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",298);}
case 298:{f.Locals[11]=f.Pop();f.Pc=300;continue;}
case 300:{f.Push(f.Locals[1]);f.Pc=301;continue;}
case 301:{f.Push(JValue.R(rt.String("SharedRestrictions")));f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",307);}
case 307:{f.Pc=f.Pop().Int==0?325:310;continue;}
case 310:{f.Push(f.Locals[1]);f.Pc=311;continue;}
case 311:{f.Push(JValue.R(rt.String("SharedRestrictions")));f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",317);}
case 317:{f.Push(JValue.R(rt.String(",")));f.Pc=319;continue;}
case 319:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",322);}
case 322:{f.Pc=335;continue;}
case 325:{f.Push(JValue.I(1));f.Pc=326;continue;}
case 326:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=329;continue;}
case 329:{f.StackOp("dup");f.Pc=330;continue;}
case 330:{f.Push(JValue.I(0));f.Pc=331;continue;}
case 331:{f.Push(JValue.R(rt.String("Card")));f.Pc=334;continue;}
case 334:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=335;continue;}
case 335:{f.Locals[12]=f.Pop();f.Pc=337;continue;}
case 337:{f.Push(f.Locals[10]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[12]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[11]);f.Pc=343;continue;}
case 343:{f.Push(f.Locals[2]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[1]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/card/CardFactoryUtil","sharedKeywords","(Ljava/lang/Iterable;[Ljava/lang/String;Ljava/lang/Iterable;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",348);}
case 348:{f.Locals[10]=f.Pop();f.Pc=350;continue;}
case 350:{f.Push(f.Locals[10]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",357);}
case 357:{f.Locals[11]=f.Pop();f.Pc=359;continue;}
case 359:{f.Push(f.Locals[11]);f.Pc=361;continue;}
case 361:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",366);}
case 366:{f.Pc=f.Pop().Int==0?401:369;continue;}
case 369:{f.Push(f.Locals[11]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",376);}
case 376:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=379;continue;}
case 379:{f.Locals[12]=f.Pop();f.Pc=381;continue;}
case 381:{f.Push(f.Locals[0]);f.Pc=382;continue;}
case 382:{f.Push(f.Locals[1]);f.Pc=383;continue;}
case 383:{f.Push(f.Locals[7]);f.Pc=385;continue;}
case 385:{f.Push(f.Locals[12]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",390);}
case 390:{f.Push(f.Locals[6]);f.Pc=392;continue;}
case 392:{f.Push(f.Locals[9]);f.Pc=394;continue;}
case 394:{f.Push(JValue.I(0));f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","resolvePerType","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/CounterType;ILforge/game/GameEntityCounterTable;Z)V","invokevirtual",398);}
case 398:{f.Pc=359;continue;}
case 401:{f.Pc=663;continue;}
case 404:{f.Push(JValue.R(null));f.Pc=405;continue;}
case 405:{f.Locals[10]=f.Pop();f.Pc=407;continue;}
case 407:{f.Push(f.Locals[1]);f.Pc=408;continue;}
case 408:{f.Push(JValue.R(rt.String("EachExistingCounter")));f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",414);}
case 414:{f.Pc=f.Pop().Int!=0?520:417;continue;}
case 417:{f.Push(f.Locals[1]);f.Pc=418;continue;}
case 418:{f.Push(JValue.R(rt.String("EachFromSource")));f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",424);}
case 424:{f.Pc=f.Pop().Int!=0?520:427;continue;}
case 427:{f.Push(f.Locals[1]);f.Pc=428;continue;}
case 428:{f.Push(JValue.R(rt.String("UniqueType")));f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",434);}
case 434:{f.Pc=f.Pop().Int!=0?520:437;continue;}
case 437:{f.Push(f.Locals[1]);f.Pc=438;continue;}
case 438:{f.Push(JValue.R(rt.String("CounterTypePerDefined")));f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",444);}
case 444:{f.Pc=f.Pop().Int!=0?520:447;continue;}
case 447:{f.Push(f.Locals[1]);f.Pc=448;continue;}
case 448:{f.Push(JValue.R(rt.String("CounterTypes")));f.Pc=450;continue;}
case 450:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",453);}
case 453:{f.Pc=f.Pop().Int!=0?520:456;continue;}
case 456:{f.Push(f.Locals[1]);f.Pc=457;continue;}
case 457:{f.Push(JValue.R(rt.String("ChooseDifferent")));f.Pc=460;continue;}
case 460:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",463);}
case 463:{f.Pc=f.Pop().Int!=0?520:466;continue;}
case 466:{f.Push(f.Locals[1]);f.Pc=467;continue;}
case 467:{f.Push(JValue.R(rt.String("PutOnEachOther")));f.Pc=470;continue;}
case 470:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",473);}
case 473:{f.Pc=f.Pop().Int!=0?520:476;continue;}
case 476:{f.Push(f.Locals[1]);f.Pc=477;continue;}
case 477:{f.Push(JValue.R(rt.String("PutOnDefined")));f.Pc=480;continue;}
case 480:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",483);}
case 483:{f.Pc=f.Pop().Int!=0?520:486;continue;}
case 486:{f.Push(f.Locals[0]);f.Pc=487;continue;}
case 487:{f.Push(f.Locals[1]);f.Pc=488;continue;}
case 488:{f.Push(f.Locals[1]);f.Pc=489;continue;}
case 489:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=491;continue;}
case 491:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",494);}
case 494:{f.Push(JValue.R(null));f.Pc=495;continue;}
case 495:{f.Push(f.Locals[7]);f.Pc=497;continue;}
case 497:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",500);}
case 500:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","chooseTypeFromList","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/GameEntity;Lforge/game/player/PlayerController;)Lforge/game/card/CounterType;","invokevirtual",503);}
case 503:{f.Locals[10]=f.Pop();f.Pc=505;continue;}
case 505:{f.Pc=520;continue;}
case 508:{f.Locals[11]=f.Pop();f.Pc=510;continue;}
case 510:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=513;continue;}
case 513:{f.Push(JValue.R(rt.String("Counter type doesn't match, nor does an SVar exist with the type name.")));f.Pc=516;continue;}
case 516:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",519);}
case 519:{return JStep.ReturnVoid;}
case 520:{f.Push(f.Locals[1]);f.Pc=521;continue;}
case 521:{f.Push(JValue.R(rt.String("ForColor")));f.Pc=524;continue;}
case 524:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",527);}
case 527:{f.Pc=f.Pop().Int==0?649:530;continue;}
case 530:{f.Push(f.Locals[2]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"forge/game/card/Card","getChosenColors","()Ljava/lang/Iterable;","invokevirtual",534);}
case 534:{f.Locals[11]=f.Pop();f.Pc=536;continue;}
case 536:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;"));f.Pc=539;continue;}
case 539:{return rt.Call(f,"com/google/common/collect/ImmutableList","iterator","()Lcom/google/common/collect/UnmodifiableIterator;","invokevirtual",542);}
case 542:{f.Locals[12]=f.Pop();f.Pc=544;continue;}
case 544:{f.Push(f.Locals[12]);f.Pc=546;continue;}
case 546:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",551);}
case 551:{f.Pc=f.Pop().Int==0?637:554;continue;}
case 554:{f.Push(f.Locals[12]);f.Pc=556;continue;}
case 556:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",561);}
case 561:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=564;continue;}
case 564:{f.Locals[13]=f.Pop();f.Pc=566;continue;}
case 566:{f.Push(f.Locals[2]);f.Pc=567;continue;}
case 567:{f.Push(JValue.I(1));f.Pc=568;continue;}
case 568:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=571;continue;}
case 571:{f.StackOp("dup");f.Pc=572;continue;}
case 572:{f.Push(JValue.I(0));f.Pc=573;continue;}
case 573:{f.Push(f.Locals[13]);f.Pc=575;continue;}
case 575:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=576;continue;}
case 576:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",579);}
case 579:{return rt.Call(f,"forge/game/card/Card","setChosenColors","(Ljava/util/List;)V","invokevirtual",582);}
case 582:{f.Push(f.Locals[1]);f.Pc=583;continue;}
case 583:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=586;continue;}
case 586:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",589);}
case 589:{f.Pc=f.Pop().Reference==null?620:592;continue;}
case 592:{f.Push(f.Locals[1]);f.Pc=593;continue;}
case 593:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",596);}
case 596:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=599;continue;}
case 599:{f.Push(f.Locals[1]);f.Pc=600;continue;}
case 600:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=603;continue;}
case 603:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",606);}
case 606:{f.Push(JValue.R(rt.String("chosenColor")));f.Pc=609;continue;}
case 609:{f.Push(f.Locals[13]);f.Pc=611;continue;}
case 611:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",614);}
case 614:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",619);}
case 619:{f.StackOp("pop");f.Pc=620;continue;}
case 620:{f.Push(f.Locals[0]);f.Pc=621;continue;}
case 621:{f.Push(f.Locals[1]);f.Pc=622;continue;}
case 622:{f.Push(f.Locals[7]);f.Pc=624;continue;}
case 624:{f.Push(f.Locals[10]);f.Pc=626;continue;}
case 626:{f.Push(f.Locals[6]);f.Pc=628;continue;}
case 628:{f.Push(f.Locals[9]);f.Pc=630;continue;}
case 630:{f.Push(JValue.I(1));f.Pc=631;continue;}
case 631:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","resolvePerType","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/CounterType;ILforge/game/GameEntityCounterTable;Z)V","invokevirtual",634);}
case 634:{f.Pc=544;continue;}
case 637:{f.Push(f.Locals[2]);f.Pc=638;continue;}
case 638:{f.Push(f.Locals[11]);f.Pc=640;continue;}
case 640:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",643);}
case 643:{return rt.Call(f,"forge/game/card/Card","setChosenColors","(Ljava/util/List;)V","invokevirtual",646);}
case 646:{f.Pc=663;continue;}
case 649:{f.Push(f.Locals[0]);f.Pc=650;continue;}
case 650:{f.Push(f.Locals[1]);f.Pc=651;continue;}
case 651:{f.Push(f.Locals[7]);f.Pc=653;continue;}
case 653:{f.Push(f.Locals[10]);f.Pc=655;continue;}
case 655:{f.Push(f.Locals[6]);f.Pc=657;continue;}
case 657:{f.Push(f.Locals[9]);f.Pc=659;continue;}
case 659:{f.Push(JValue.I(1));f.Pc=660;continue;}
case 660:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","resolvePerType","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/CounterType;ILforge/game/GameEntityCounterTable;Z)V","invokevirtual",663);}
case 663:{f.Push(f.Locals[9]);f.Pc=665;continue;}
case 665:{f.Push(f.Locals[3]);f.Pc=666;continue;}
case 666:{f.Push(f.Locals[8]);f.Pc=668;continue;}
case 668:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",671);}
case 671:{f.Push(f.Locals[1]);f.Pc=672;continue;}
case 672:{f.Push(JValue.R(rt.String("RemovePhase")));f.Pc=675;continue;}
case 675:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",678);}
case 678:{f.Pc=f.Pop().Int==0?815:681;continue;}
case 681:{f.Push(f.Locals[9]);f.Pc=683;continue;}
case 683:{f.Push(f.Locals[7]);f.Pc=685;continue;}
case 685:{return rt.Call(f,"java/util/Optional","of","(Ljava/lang/Object;)Ljava/util/Optional;","invokestatic",688);}
case 688:{return rt.Call(f,"forge/game/GameEntityCounterTable","row","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",691);}
case 691:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",696);}
case 696:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",701);}
case 701:{f.Locals[10]=f.Pop();f.Pc=703;continue;}
case 703:{f.Push(f.Locals[10]);f.Pc=705;continue;}
case 705:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",710);}
case 710:{f.Pc=f.Pop().Int==0?815:713;continue;}
case 713:{f.Push(f.Locals[10]);f.Pc=715;continue;}
case 715:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",720);}
case 720:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=723;continue;}
case 723:{f.Locals[11]=f.Pop();f.Pc=725;continue;}
case 725:{f.Push(f.Locals[11]);f.Pc=727;continue;}
case 727:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",732);}
case 732:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=735;continue;}
case 735:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",740);}
case 740:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",745);}
case 745:{f.Locals[12]=f.Pop();f.Pc=747;continue;}
case 747:{f.Push(f.Locals[12]);f.Pc=749;continue;}
case 749:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",754);}
case 754:{f.Pc=f.Pop().Int==0?812:757;continue;}
case 757:{f.Push(f.Locals[12]);f.Pc=759;continue;}
case 759:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",764);}
case 764:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=767;continue;}
case 767:{f.Locals[13]=f.Pop();f.Pc=769;continue;}
case 769:{f.Push(f.Locals[0]);f.Pc=770;continue;}
case 770:{f.Push(f.Locals[2]);f.Pc=771;continue;}
case 771:{f.Push(f.Locals[1]);f.Pc=772;continue;}
case 772:{f.Push(f.Locals[1]);f.Pc=773;continue;}
case 773:{f.Push(JValue.R(rt.String("RemovePhase")));f.Pc=776;continue;}
case 776:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",779);}
case 779:{f.Push(f.Locals[11]);f.Pc=781;continue;}
case 781:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",786);}
case 786:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=789;continue;}
case 789:{f.Push(f.Locals[13]);f.Pc=791;continue;}
case 791:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",796);}
case 796:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=799;continue;}
case 799:{f.Push(f.Locals[13]);f.Pc=801;continue;}
case 801:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",806);}
case 806:{return rt.Call(f,"forge/game/ability/effects/CountersPutEffect","addRemovePhaseTrigger","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)V","invokevirtual",809);}
case 809:{f.Pc=747;continue;}
case 812:{f.Pc=703;continue;}
case 815:{f.Push(f.Locals[1]);f.Pc=816;continue;}
case 816:{f.Push(JValue.R(rt.String("RememberCards")));f.Pc=819;continue;}
case 819:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",822);}
case 822:{f.Pc=f.Pop().Int==0?834:825;continue;}
case 825:{f.Push(f.Locals[2]);f.Pc=826;continue;}
case 826:{f.Push(f.Locals[9]);f.Pc=828;continue;}
case 828:{return rt.Call(f,"forge/game/GameEntityCounterTable","columnKeySet","()Ljava/util/Set;","invokevirtual",831);}
case 831:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",834);}
case 834:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3268(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",4);}
case 4:{f.Locals[7]=f.Pop();f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Mode$ Phase | Phase$ ")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",16);}
case 16:{f.Locals[8]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[8]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[8]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String(" | TriggerDescription$ For each ")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",33);}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",40);}
case 40:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",43);}
case 43:{f.Push(JValue.R(rt.String(" counter you put on a creature this way, remove a ")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",49);}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",56);}
case 56:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",59);}
case 59:{f.Push(JValue.R(rt.String(" counter from that creature at the beginning of the next")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("Cleanup")));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?88:76;continue;}
case 76:{f.Push(f.Locals[8]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("cleanup step")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Pc=107;continue;}
case 88:{f.Push(JValue.R(rt.String("End of Turn")));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?107:98;continue;}
case 98:{f.Push(f.Locals[8]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String("next end step")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",106);}
case 106:{f.StackOp("pop");f.Pc=107;continue;}
case 107:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=110;continue;}
case 110:{f.StackOp("dup");f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String("DB$ RemoveCounter | Defined$ DelayTriggerRemembered | CounterNum$ 1 | CounterType$ ")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",117);}
case 117:{f.Push(f.Locals[5]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",122);}
case 122:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",125);}
case 125:{f.Locals[9]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(JValue.I(0));f.Pc=128;continue;}
case 128:{f.Locals[10]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[10]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[6]);f.Pc=134;continue;}
case 134:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?211:137;continue;}
case 137:{f.Push(f.Locals[8]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",142);}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[7]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokestatic",148);}
case 148:{f.Locals[11]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[11]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[4]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/trigger/Trigger","addRemembered","(Ljava/lang/Object;)V","invokevirtual",157);}
case 157:{f.Push(f.Locals[9]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",163);}
case 163:{f.Locals[12]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[12]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[7]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",172);}
case 172:{f.Push(f.Locals[11]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[12]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",179);}
case 179:{f.Push(f.Locals[11]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[2]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Push(JValue.I(1));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",187);}
case 187:{return rt.Call(f,"forge/game/trigger/Trigger","setSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",190);}
case 190:{f.Push(f.Locals[2]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",194);}
case 194:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",197);}
case 197:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",200);}
case 200:{f.Push(f.Locals[11]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerDelayedTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",205);}
case 205:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=208;continue;}
case 208:{f.Pc=130;continue;}
case 211:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3269(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[5]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String(",")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[6]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[6]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=16;continue;}
case 16:{f.Locals[7]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Locals[8]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[8]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[7]);f.Pc=25;continue;}
case 25:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?100:28;continue;}
case 28:{f.Push(f.Locals[6]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[8]);f.Pc=32;continue;}
case 32:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=33;continue;}
case 33:{f.Locals[9]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[9]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int!=0?94:43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("UniqueType")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?65:53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[9]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",59);}
case 59:{return rt.Call(f,"forge/game/GameEntity","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int!=0?94:65;continue;}
case 65:{f.Push(f.Locals[9]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",70);}
case 70:{f.Locals[10]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[10]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",81);}
case 81:{f.Pc=f.Pop().Int!=0?94:84;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[10]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",93);}
case 93:{f.StackOp("pop");f.Pc=94;continue;}
case 94:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=97;continue;}
case 97:{f.Pc=21;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("RandomType")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?119:110;continue;}
case 110:{f.Push(f.Locals[5]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",115);}
case 115:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=118;continue;}
case 118:{return JStep.Return(f.Pop());}
case 119:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",122);}
case 122:{f.Locals[6]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[6]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("Target")));f.Pc=129;continue;}
case 129:{f.Push(f.Locals[3]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",135);}
case 135:{f.StackOp("pop");f.Pc=136;continue;}
case 136:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=139;continue;}
case 139:{f.StackOp("dup");f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",143);}
case 143:{f.Locals[7]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[3]);f.Pc=146;continue;}
case 146:{f.Pc=f.Pop().Reference==null?180:149;continue;}
case 149:{f.Push(f.Locals[7]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",154);}
case 154:{f.Push(JValue.R(rt.String("lblSelectCounterTypeAddTo")));f.Pc=157;continue;}
case 157:{f.Push(JValue.I(0));f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",164);}
case 164:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",167);}
case 167:{f.Push(JValue.R(rt.String(" ")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",172);}
case 172:{f.Push(f.Locals[3]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",176);}
case 176:{f.StackOp("pop");f.Pc=177;continue;}
case 177:{f.Pc=199;continue;}
case 180:{f.Push(f.Locals[7]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",185);}
case 185:{f.Push(JValue.R(rt.String("lblSelectCounterType")));f.Pc=188;continue;}
case 188:{f.Push(JValue.I(0));f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",195);}
case 195:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",198);}
case 198:{f.StackOp("pop");f.Pc=199;continue;}
case 199:{f.Push(f.Locals[4]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[5]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[7]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",209);}
case 209:{f.Push(f.Locals[6]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/player/PlayerController","chooseCounterType","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/CounterType;","invokevirtual",214);}
case 214:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3270(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",16);}
case 16:{f.Push(JValue.R(rt.String(" randomly distributed ")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",22);}
case 22:{f.StackOp("pop");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",29);}
case 29:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",34);}
case 34:{f.Pc=f.Pop().Int!=0?48:37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("no counters.")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Pc=199;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("counters: ")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{f.Locals[4]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",65);}
case 65:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",70);}
case 70:{f.Locals[5]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int==0?199:82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{f.Locals[6]=f.Pop();f.Pc=94;continue;}
case 94:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[6]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",105);}
case 105:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",108);}
case 108:{f.Push(JValue.R(rt.String(" (")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",114);}
case 114:{f.Push(f.Locals[6]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",121);}
case 121:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",124);}
case 124:{f.Push(JValue.R(rt.String(" counter")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",130);}
case 130:{f.StackOp("pop");f.Pc=131;continue;}
case 131:{f.Push(f.Locals[3]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[6]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",145);}
case 145:{f.Push(JValue.I(1));f.Pc=146;continue;}
case 146:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?155:149;continue;}
case 149:{f.Push(JValue.R(rt.String("s")));f.Pc=152;continue;}
case 152:{f.Pc=157;continue;}
case 155:{f.Push(JValue.R(rt.String("")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",160);}
case 160:{f.Push(JValue.R(rt.String(")")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",166);}
case 166:{f.StackOp("pop");f.Pc=167;continue;}
case 167:{f.Push(f.Locals[3]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[4]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[1]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",176);}
case 176:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",181);}
case 181:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?189:184;continue;}
case 184:{f.Push(JValue.R(rt.String("")));f.Pc=186;continue;}
case 186:{f.Pc=192;continue;}
case 189:{f.Push(JValue.R(rt.String(", ")));f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",195);}
case 195:{f.StackOp("pop");f.Pc=196;continue;}
case 196:{f.Pc=72;continue;}
case 199:{f.Push(f.Locals[3]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",203);}
case 203:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3271(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Adapt")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?89:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Adapt")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("P1P1")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",32);}
case 32:{f.StackOp("pop");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",40);}
case 40:{f.StackOp("pop");f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int!=0?62:51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int!=0?86:72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3271:77:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",82);}
case 82:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Pc=583;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("Bolster")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?239:98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("Bolster")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",104);}
case 104:{f.Locals[2]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("P1P1")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=118;continue;}
case 118:{f.Push(f.Locals[2]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("Choices")));f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("Creature.leastToughnessControlledByYou")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",133);}
case 133:{f.StackOp("pop");f.Pc=134;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",141);}
case 141:{f.Push(JValue.R(rt.String("lblChooseACreatureWithLeastToughness")));f.Pc=144;continue;}
case 144:{f.Push(JValue.I(0));f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",151);}
case 151:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",154);}
case 154:{f.StackOp("pop");f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("SkipReceiveCounters")));f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("True")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",164);}
case 164:{f.StackOp("pop");f.Pc=165;continue;}
case 165:{f.Push(f.Locals[1]);f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",172);}
case 172:{f.Pc=f.Pop().Int!=0?236:175;continue;}
case 175:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=178;continue;}
case 178:{f.StackOp("dup");f.Pc=179;continue;}
case 179:{f.Push(JValue.R(rt.String("Bolster")));f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",184);}
case 184:{f.Locals[3]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[3]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String(" ")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",191);}
case 191:{f.Push(f.Locals[2]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",195);}
case 195:{f.StackOp("pop");f.Pc=196;continue;}
case 196:{f.Push(f.Locals[2]);f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String("+1/+1 counter")));f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",203);}
case 203:{f.Locals[4]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[3]);f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String(" (Choose a creature with the least toughness among creatures you control and put ")));f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",212);}
case 212:{f.Push(f.Locals[4]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",217);}
case 217:{f.Push(JValue.R(rt.String(" on it.)")));f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",223);}
case 223:{f.StackOp("pop");f.Pc=224;continue;}
case 224:{f.Push(f.Locals[1]);f.Pc=225;continue;}
case 225:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=228;continue;}
case 228:{f.Push(f.Locals[3]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",232);}
case 232:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",235);}
case 235:{f.StackOp("pop");f.Pc=236;continue;}
case 236:{f.Pc=583;continue;}
case 239:{f.Push(f.Locals[1]);f.Pc=240;continue;}
case 240:{f.Push(JValue.R(rt.String("Monstrosity")));f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",246);}
case 246:{f.Pc=f.Pop().Int==0?385:249;continue;}
case 249:{f.Push(f.Locals[1]);f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("Monstrosity")));f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",256);}
case 256:{f.Locals[2]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[1]);f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=260;continue;}
case 260:{f.Push(JValue.R(rt.String("P1P1")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",266);}
case 266:{f.StackOp("pop");f.Pc=267;continue;}
case 267:{f.Push(f.Locals[1]);f.Pc=268;continue;}
case 268:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=270;continue;}
case 270:{f.Push(f.Locals[2]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",274);}
case 274:{f.StackOp("pop");f.Pc=275;continue;}
case 275:{f.Push(f.Locals[1]);f.Pc=276;continue;}
case 276:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",282);}
case 282:{f.Pc=f.Pop().Int!=0?296:285;continue;}
case 285:{f.Push(f.Locals[1]);f.Pc=286;continue;}
case 286:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=289;continue;}
case 289:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",295);}
case 295:{f.StackOp("pop");f.Pc=296;continue;}
case 296:{f.Push(f.Locals[1]);f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",303);}
case 303:{f.Pc=f.Pop().Int!=0?382:306;continue;}
case 306:{f.Push(f.Locals[1]);f.Pc=307;continue;}
case 307:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=310;continue;}
case 310:{f.Push(f.Locals[2]);f.Pc=311;continue;}
case 311:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutEffect:3271:311:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",316);}
case 316:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",319);}
case 319:{f.StackOp("pop");f.Pc=320;continue;}
case 320:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=323;continue;}
case 323:{f.StackOp("dup");f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.String("Monstrosity")));f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",330);}
case 330:{f.Locals[3]=f.Pop();f.Pc=331;continue;}
case 331:{f.Push(f.Locals[3]);f.Pc=332;continue;}
case 332:{f.Push(JValue.R(rt.String(" ")));f.Pc=334;continue;}
case 334:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",337);}
case 337:{f.Push(f.Locals[2]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",341);}
case 341:{f.StackOp("pop");f.Pc=342;continue;}
case 342:{f.Push(f.Locals[2]);f.Pc=343;continue;}
case 343:{f.Push(JValue.R(rt.String("+1/+1 counter")));f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",349);}
case 349:{f.Locals[4]=f.Pop();f.Pc=351;continue;}
case 351:{f.Push(f.Locals[3]);f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String(" (If this creature isn\u2019t monstrous, put ")));f.Pc=355;continue;}
case 355:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",358);}
case 358:{f.Push(f.Locals[4]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",363);}
case 363:{f.Push(JValue.R(rt.String(" on it and it becomes monstrous.)")));f.Pc=366;continue;}
case 366:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",369);}
case 369:{f.StackOp("pop");f.Pc=370;continue;}
case 370:{f.Push(f.Locals[1]);f.Pc=371;continue;}
case 371:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=374;continue;}
case 374:{f.Push(f.Locals[3]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",378);}
case 378:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",381);}
case 381:{f.StackOp("pop");f.Pc=382;continue;}
case 382:{f.Pc=583;continue;}
case 385:{f.Push(f.Locals[1]);f.Pc=386;continue;}
case 386:{f.Push(JValue.R(rt.String("Support")));f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",392);}
case 392:{f.Pc=f.Pop().Int==0?583:395;continue;}
case 395:{f.Push(f.Locals[1]);f.Pc=396;continue;}
case 396:{f.Push(JValue.R(rt.String("Support")));f.Pc=399;continue;}
case 399:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",402);}
case 402:{f.Locals[2]=f.Pop();f.Pc=403;continue;}
case 403:{f.Push(f.Locals[1]);f.Pc=404;continue;}
case 404:{f.Push(JValue.R(rt.String("TargetMin")));f.Pc=407;continue;}
case 407:{f.Push(JValue.R(rt.String("0")));f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",413);}
case 413:{f.StackOp("pop");f.Pc=414;continue;}
case 414:{f.Push(f.Locals[1]);f.Pc=415;continue;}
case 415:{f.Push(JValue.R(rt.String("TargetMax")));f.Pc=418;continue;}
case 418:{f.Push(f.Locals[2]);f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",422);}
case 422:{f.StackOp("pop");f.Pc=423;continue;}
case 423:{f.Push(f.Locals[1]);f.Pc=424;continue;}
case 424:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=426;continue;}
case 426:{f.Push(JValue.R(rt.String("P1P1")));f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",432);}
case 432:{f.StackOp("pop");f.Pc=433;continue;}
case 433:{f.Push(f.Locals[1]);f.Pc=434;continue;}
case 434:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=436;continue;}
case 436:{f.Push(JValue.R(rt.String("1")));f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",441);}
case 441:{f.StackOp("pop");f.Pc=442;continue;}
case 442:{f.Push(f.Locals[1]);f.Pc=443;continue;}
case 443:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",446);}
case 446:{return rt.Call(f,"forge/game/card/Card","isPermanent","()Z","invokevirtual",449);}
case 449:{f.Pc=f.Pop().Int==0?481:452;continue;}
case 452:{f.Push(f.Locals[1]);f.Pc=453;continue;}
case 453:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=456;continue;}
case 456:{f.Push(JValue.R(rt.String("Creature.Other")));f.Pc=459;continue;}
case 459:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",462);}
case 462:{f.StackOp("pop");f.Pc=463;continue;}
case 463:{f.Push(f.Locals[1]);f.Pc=464;continue;}
case 464:{f.Push(JValue.R(rt.String("ValidTgtsDesc")));f.Pc=467;continue;}
case 467:{f.Push(JValue.R(rt.String("other creature")));f.Pc=470;continue;}
case 470:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",473);}
case 473:{f.StackOp("pop");f.Pc=474;continue;}
case 474:{f.Push(JValue.R(rt.String("other target creature")));f.Pc=477;continue;}
case 477:{f.Locals[3]=f.Pop();f.Pc=478;continue;}
case 478:{f.Pc=496;continue;}
case 481:{f.Push(f.Locals[1]);f.Pc=482;continue;}
case 482:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=485;continue;}
case 485:{f.Push(JValue.R(rt.String("Creature")));f.Pc=488;continue;}
case 488:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",491);}
case 491:{f.StackOp("pop");f.Pc=492;continue;}
case 492:{f.Push(JValue.R(rt.String("target creature")));f.Pc=495;continue;}
case 495:{f.Locals[3]=f.Pop();f.Pc=496;continue;}
case 496:{f.Push(f.Locals[1]);f.Pc=497;continue;}
case 497:{if(!rt.EnsureInitialized(f,"forge/game/spellability/TargetRestrictions"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/TargetRestrictions")));f.Pc=500;continue;}
case 500:{f.StackOp("dup");f.Pc=501;continue;}
case 501:{f.Push(f.Locals[1]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",505);}
case 505:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","<init>","(Ljava/util/Map;)V","invokespecial",508);}
case 508:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTargetRestrictions","(Lforge/game/spellability/TargetRestrictions;)V","invokevirtual",511);}
case 511:{f.Push(f.Locals[1]);f.Pc=512;continue;}
case 512:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=515;continue;}
case 515:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",518);}
case 518:{f.Pc=f.Pop().Int!=0?583:521;continue;}
case 521:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=524;continue;}
case 524:{f.StackOp("dup");f.Pc=525;continue;}
case 525:{f.Push(JValue.R(rt.String("Support")));f.Pc=528;continue;}
case 528:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",531);}
case 531:{f.Locals[4]=f.Pop();f.Pc=533;continue;}
case 533:{f.Push(f.Locals[4]);f.Pc=535;continue;}
case 535:{f.Push(JValue.R(rt.String(" ")));f.Pc=537;continue;}
case 537:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",540);}
case 540:{f.Push(f.Locals[2]);f.Pc=541;continue;}
case 541:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",544);}
case 544:{f.StackOp("pop");f.Pc=545;continue;}
case 545:{f.Push(f.Locals[2]);f.Pc=546;continue;}
case 546:{f.Push(f.Locals[3]);f.Pc=547;continue;}
case 547:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",550);}
case 550:{f.Locals[3]=f.Pop();f.Pc=551;continue;}
case 551:{f.Push(f.Locals[4]);f.Pc=553;continue;}
case 553:{f.Push(JValue.R(rt.String(" (Put a +1/+1 counter on each of up to ")));f.Pc=556;continue;}
case 556:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",559);}
case 559:{f.Push(f.Locals[3]);f.Pc=560;continue;}
case 560:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",563);}
case 563:{f.Push(JValue.R(rt.String(".)")));f.Pc=566;continue;}
case 566:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",569);}
case 569:{f.StackOp("pop");f.Pc=570;continue;}
case 570:{f.Push(f.Locals[1]);f.Pc=571;continue;}
case 571:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=574;continue;}
case 574:{f.Push(f.Locals[4]);f.Pc=576;continue;}
case 576:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",579);}
case 579:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",582);}
case 582:{f.StackOp("pop");f.Pc=583;continue;}
case 583:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C297{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/EffectEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3372,"forge/game/ability/effects/EffectEffect","<init>","()V",1,1,1,new JHandler[]{},M3372));
c.Add(new JMethod(3373,"forge/game/ability/effects/EffectEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,25,6,new JHandler[]{},M3373));
c.Add(new JMethod(3374,"forge/game/ability/effects/EffectEffect","$deserializeLambda$","(Ljava/lang/invoke/SerializedLambda;)Ljava/lang/Object;",4106,3,3,new JHandler[]{},M3374));
c.Add(new JMethod(3375,"forge/game/ability/effects/EffectEffect","lambda$resolve$f894d637$1","(Lforge/game/Game;Lforge/game/card/Card;)V",4106,2,2,new JHandler[]{},M3375));
}

internal static JStep M3372(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3373(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{f.Locals[6]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.R(null));f.Pc=20;continue;}
case 20:{f.Locals[7]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(JValue.R(null));f.Pc=23;continue;}
case 23:{f.Locals[8]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(JValue.R(null));f.Pc=26;continue;}
case 26:{f.Locals[9]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(JValue.R(null));f.Pc=29;continue;}
case 29:{f.Locals[10]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("Duration")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Locals[11]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[11]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/ability/effects/EffectEffect","checkValidDuration","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokestatic",45);}
case 45:{f.Pc=f.Pop().Int!=0?49:48;continue;}
case 48:{return JStep.ReturnVoid;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("Abilities")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?71:58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("Abilities")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",64);}
case 64:{f.Push(JValue.R(rt.String(",")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",69);}
case 69:{f.Locals[4]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("Triggers")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?93:80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("Triggers")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Push(JValue.R(rt.String(",")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",91);}
case 91:{f.Locals[5]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("StaticAbilities")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int==0?115:102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("StaticAbilities")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",108);}
case 108:{f.Push(JValue.R(rt.String(",")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",113);}
case 113:{f.Locals[6]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("ReplacementEffects")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?137:124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("ReplacementEffects")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",130);}
case 130:{f.Push(JValue.R(rt.String(",")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",135);}
case 135:{f.Locals[7]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("RememberSpell")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Int==0?209:146;continue;}
case 146:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=149;continue;}
case 149:{f.StackOp("dup");f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",153);}
case 153:{f.Locals[8]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("RememberSpell")));f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",161);}
case 161:{f.Push(JValue.R(rt.String(",")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",166);}
case 166:{f.Locals[12]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[12]);f.Pc=170;continue;}
case 170:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=171;continue;}
case 171:{f.Locals[13]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(JValue.I(0));f.Pc=174;continue;}
case 174:{f.Locals[14]=f.Pop();f.Pc=176;continue;}
case 176:{f.Push(f.Locals[14]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[13]);f.Pc=180;continue;}
case 180:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?209:183;continue;}
case 183:{f.Push(f.Locals[12]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[14]);f.Pc=187;continue;}
case 187:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=188;continue;}
case 188:{f.Locals[15]=f.Pop();f.Pc=190;continue;}
case 190:{f.Push(f.Locals[8]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[2]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[15]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[1]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedSpellAbilities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",199);}
case 199:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",202);}
case 202:{f.StackOp("pop");f.Pc=203;continue;}
case 203:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=206;continue;}
case 206:{f.Pc=176;continue;}
case 209:{f.Push(f.Locals[1]);f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",215);}
case 215:{f.Pc=f.Pop().Int==0?332:218;continue;}
case 218:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=221;continue;}
case 221:{f.StackOp("dup");f.Pc=222;continue;}
case 222:{f.Push(f.Locals[2]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[1]);f.Pc=224;continue;}
case 224:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",229);}
case 229:{f.Push(JValue.R(rt.String(" & ")));f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",234);}
case 234:{f.Push(f.Locals[1]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;[Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",238);}
case 238:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",241);}
case 241:{f.Locals[8]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[1]);f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.String("ForgetCounter")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",249);}
case 249:{f.Pc=f.Pop().Int==0?287:252;continue;}
case 252:{f.Push(f.Locals[1]);f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.String("ForgetCounter")));f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",258);}
case 258:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",261);}
case 261:{f.Locals[12]=f.Pop();f.Pc=263;continue;}
case 263:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=266;continue;}
case 266:{f.StackOp("dup");f.Pc=267;continue;}
case 267:{f.Push(f.Locals[8]);f.Pc=269;continue;}
case 269:{f.Push(JValue.R(rt.ClassObject("forge/game/card/Card")));f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/lang/Iterable;","invokestatic",274);}
case 274:{f.Push(f.Locals[12]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/card/CardPredicates","hasCounter","(Lforge/game/card/CounterType;)Ljava/util/function/Predicate;","invokestatic",279);}
case 279:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",282);}
case 282:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",285);}
case 285:{f.Locals[8]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[8]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/util/collect/FCollection","isEmpty","()Z","invokevirtual",292);}
case 292:{f.Pc=f.Pop().Int==0?332:295;continue;}
case 295:{f.Push(f.Locals[1]);f.Pc=296;continue;}
case 296:{f.Push(JValue.R(rt.String("ForgetOnMoved")));f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",301);}
case 301:{f.Pc=f.Pop().Int!=0?331:304;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{f.Push(JValue.R(rt.String("ExileOnMoved")));f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",310);}
case 310:{f.Pc=f.Pop().Int!=0?331:313;continue;}
case 313:{f.Push(f.Locals[1]);f.Pc=314;continue;}
case 314:{f.Push(JValue.R(rt.String("ForgetCounter")));f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",319);}
case 319:{f.Pc=f.Pop().Int!=0?331:322;continue;}
case 322:{f.Push(f.Locals[1]);f.Pc=323;continue;}
case 323:{f.Push(JValue.R(rt.String("ForgetOnPhasedIn")));f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",328);}
case 328:{f.Pc=f.Pop().Int==0?332:331;continue;}
case 331:{return JStep.ReturnVoid;}
case 332:{f.Push(f.Locals[1]);f.Pc=333;continue;}
case 333:{f.Push(JValue.R(rt.String("RememberLKI")));f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",338);}
case 338:{f.Pc=f.Pop().Int==0?470:341;continue;}
case 341:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=344;continue;}
case 344:{f.StackOp("dup");f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",348);}
case 348:{f.Locals[8]=f.Pop();f.Pc=350;continue;}
case 350:{f.Push(f.Locals[1]);f.Pc=351;continue;}
case 351:{f.Push(JValue.R(rt.String("RememberLKI")));f.Pc=353;continue;}
case 353:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",356);}
case 356:{f.Push(JValue.R(rt.String(",")));f.Pc=358;continue;}
case 358:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",361);}
case 361:{f.Locals[12]=f.Pop();f.Pc=363;continue;}
case 363:{f.Push(f.Locals[12]);f.Pc=365;continue;}
case 365:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=366;continue;}
case 366:{f.Locals[13]=f.Pop();f.Pc=368;continue;}
case 368:{f.Push(JValue.I(0));f.Pc=369;continue;}
case 369:{f.Locals[14]=f.Pop();f.Pc=371;continue;}
case 371:{f.Push(f.Locals[14]);f.Pc=373;continue;}
case 373:{f.Push(f.Locals[13]);f.Pc=375;continue;}
case 375:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?443:378;continue;}
case 378:{f.Push(f.Locals[12]);f.Pc=380;continue;}
case 380:{f.Push(f.Locals[14]);f.Pc=382;continue;}
case 382:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=383;continue;}
case 383:{f.Locals[15]=f.Pop();f.Pc=385;continue;}
case 385:{f.Push(f.Locals[2]);f.Pc=386;continue;}
case 386:{f.Push(f.Locals[15]);f.Pc=388;continue;}
case 388:{f.Push(f.Locals[1]);f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",392);}
case 392:{f.Locals[16]=f.Pop();f.Pc=394;continue;}
case 394:{f.Push(f.Locals[16]);f.Pc=396;continue;}
case 396:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",399);}
case 399:{f.Locals[17]=f.Pop();f.Pc=401;continue;}
case 401:{f.Push(f.Locals[17]);f.Pc=403;continue;}
case 403:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",408);}
case 408:{f.Pc=f.Pop().Int==0?437:411;continue;}
case 411:{f.Push(f.Locals[17]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",418);}
case 418:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=421;continue;}
case 421:{f.Locals[18]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(f.Locals[8]);f.Pc=425;continue;}
case 425:{f.Push(f.Locals[18]);f.Pc=427;continue;}
case 427:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",430);}
case 430:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",433);}
case 433:{f.StackOp("pop");f.Pc=434;continue;}
case 434:{f.Pc=401;continue;}
case 437:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=440;continue;}
case 440:{f.Pc=371;continue;}
case 443:{f.Push(f.Locals[8]);f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/util/collect/FCollection","isEmpty","()Z","invokevirtual",448);}
case 448:{f.Pc=f.Pop().Int==0?470:451;continue;}
case 451:{f.Push(f.Locals[1]);f.Pc=452;continue;}
case 452:{f.Push(JValue.R(rt.String("ForgetOnMoved")));f.Pc=454;continue;}
case 454:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",457);}
case 457:{f.Pc=f.Pop().Int!=0?469:460;continue;}
case 460:{f.Push(f.Locals[1]);f.Pc=461;continue;}
case 461:{f.Push(JValue.R(rt.String("ExileOnMoved")));f.Pc=463;continue;}
case 463:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",466);}
case 466:{f.Pc=f.Pop().Int==0?470:469;continue;}
case 469:{return JStep.ReturnVoid;}
case 470:{f.Push(f.Locals[1]);f.Pc=471;continue;}
case 471:{f.Push(JValue.R(rt.String("ImprintCards")));f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",476);}
case 476:{f.Pc=f.Pop().Int==0?487:479;continue;}
case 479:{f.Push(f.Locals[1]);f.Pc=480;continue;}
case 480:{f.Push(JValue.R(rt.String("ImprintCards")));f.Pc=482;continue;}
case 482:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",485);}
case 485:{f.Locals[9]=f.Pop();f.Pc=487;continue;}
case 487:{f.Push(f.Locals[1]);f.Pc=488;continue;}
case 488:{f.Push(JValue.R(rt.String("NoteCounterDefined")));f.Pc=490;continue;}
case 490:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",493);}
case 493:{f.Pc=f.Pop().Int==0?504:496;continue;}
case 496:{f.Push(f.Locals[1]);f.Pc=497;continue;}
case 497:{f.Push(JValue.R(rt.String("NoteCounterDefined")));f.Pc=499;continue;}
case 499:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",502);}
case 502:{f.Locals[10]=f.Pop();f.Pc=504;continue;}
case 504:{f.Push(f.Locals[1]);f.Pc=505;continue;}
case 505:{f.Push(JValue.R(rt.String("Name")));f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",510);}
case 510:{f.Locals[12]=f.Pop();f.Pc=512;continue;}
case 512:{f.Push(f.Locals[12]);f.Pc=514;continue;}
case 514:{f.Pc=f.Pop().Reference!=null?567:517;continue;}
case 517:{f.Push(f.Locals[1]);f.Pc=518;continue;}
case 518:{f.Push(JValue.R(rt.String("Adventure")));f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",523);}
case 523:{f.Pc=f.Pop().Int==0?540:526;continue;}
case 526:{f.Push(f.Locals[2]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",530);}
case 530:{return rt.DynamicCall(f,"forge/game/ability/effects/EffectEffect:3373:530:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",535);}
case 535:{f.Locals[12]=f.Pop();f.Pc=537;continue;}
case 537:{f.Pc=567;continue;}
case 540:{f.Push(f.Locals[2]);f.Pc=541;continue;}
case 541:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",544);}
case 544:{f.Push(f.Locals[1]);f.Pc=545;continue;}
case 545:{f.Push(JValue.R(rt.String("Boon")));f.Pc=547;continue;}
case 547:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",550);}
case 550:{f.Pc=f.Pop().Int==0?558:553;continue;}
case 553:{f.Push(JValue.R(rt.String("'s Boon")));f.Pc=555;continue;}
case 555:{f.Pc=560;continue;}
case 558:{f.Push(JValue.R(rt.String("'s Effect")));f.Pc=560;continue;}
case 560:{return rt.DynamicCall(f,"forge/game/ability/effects/EffectEffect:3373:560:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",565);}
case 565:{f.Locals[12]=f.Pop();f.Pc=567;continue;}
case 567:{f.Push(f.Locals[1]);f.Pc=568;continue;}
case 568:{f.Push(JValue.R(rt.String("EffectOwner")));f.Pc=570;continue;}
case 570:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",573);}
case 573:{f.Pc=f.Pop().Int==0?590:576;continue;}
case 576:{f.Push(f.Locals[2]);f.Pc=577;continue;}
case 577:{f.Push(f.Locals[1]);f.Pc=578;continue;}
case 578:{f.Push(JValue.R(rt.String("EffectOwner")));f.Pc=580;continue;}
case 580:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",583);}
case 583:{f.Push(f.Locals[1]);f.Pc=584;continue;}
case 584:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",587);}
case 587:{f.Pc=601;continue;}
case 590:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=593;continue;}
case 593:{f.StackOp("dup");f.Pc=594;continue;}
case 594:{f.Push(f.Locals[1]);f.Pc=595;continue;}
case 595:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",598);}
case 598:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","(Lforge/game/player/Player;)V","invokespecial",601);}
case 601:{f.Locals[13]=f.Pop();f.Pc=603;continue;}
case 603:{f.Push(f.Locals[1]);f.Pc=604;continue;}
case 604:{f.Push(JValue.R(rt.String("Unique")));f.Pc=606;continue;}
case 606:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",609);}
case 609:{f.Pc=f.Pop().Int==0?667:612;continue;}
case 612:{f.Push(f.Locals[13]);f.Pc=614;continue;}
case 614:{return rt.Call(f,"forge/game/player/PlayerCollection","threadSafeIterable","()Ljava/lang/Iterable;","invokevirtual",617);}
case 617:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",622);}
case 622:{f.Locals[14]=f.Pop();f.Pc=624;continue;}
case 624:{f.Push(f.Locals[14]);f.Pc=626;continue;}
case 626:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",631);}
case 631:{f.Pc=f.Pop().Int==0?667:634;continue;}
case 634:{f.Push(f.Locals[14]);f.Pc=636;continue;}
case 636:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",641);}
case 641:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=644;continue;}
case 644:{f.Locals[15]=f.Pop();f.Pc=646;continue;}
case 646:{f.Push(f.Locals[15]);f.Pc=648;continue;}
case 648:{f.Push(f.Locals[12]);f.Pc=650;continue;}
case 650:{return rt.Call(f,"forge/game/player/Player","isCardInCommand","(Ljava/lang/String;)Z","invokevirtual",653);}
case 653:{f.Pc=f.Pop().Int==0?664:656;continue;}
case 656:{f.Push(f.Locals[13]);f.Pc=658;continue;}
case 658:{f.Push(f.Locals[15]);f.Pc=660;continue;}
case 660:{return rt.Call(f,"forge/game/player/PlayerCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",663);}
case 663:{f.StackOp("pop");f.Pc=664;continue;}
case 664:{f.Pc=624;continue;}
case 667:{f.Push(f.Locals[13]);f.Pc=669;continue;}
case 669:{return rt.Call(f,"forge/game/player/PlayerCollection","isEmpty","()Z","invokevirtual",672);}
case 672:{f.Pc=f.Pop().Int==0?676:675;continue;}
case 675:{return JStep.ReturnVoid;}
case 676:{f.Push(f.Locals[12]);f.Pc=678;continue;}
case 678:{f.Push(JValue.R(rt.String("Emblem")));f.Pc=680;continue;}
case 680:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",683);}
case 683:{f.Pc=f.Pop().Int==0?761:686;continue;}
case 686:{f.Push(f.Locals[1]);f.Pc=687;continue;}
case 687:{f.Push(JValue.R(rt.String("Image")));f.Pc=689;continue;}
case 689:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",692);}
case 692:{f.Pc=f.Pop().Int==0?716:695;continue;}
case 695:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",698);}
case 698:{f.Push(f.Locals[1]);f.Pc=699;continue;}
case 699:{f.Push(JValue.R(rt.String("Image")));f.Pc=701;continue;}
case 701:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",704);}
case 704:{f.Push(f.Locals[2]);f.Pc=705;continue;}
case 705:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",708);}
case 708:{return rt.Call(f,"forge/StaticData","getOtherImageKey","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",711);}
case 711:{f.Locals[14]=f.Pop();f.Pc=713;continue;}
case 713:{f.Pc=816;continue;}
case 716:{f.Push(f.Locals[12]);f.Pc=718;continue;}
case 718:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",721);}
case 721:{f.Push(JValue.R(rt.String(" \u2014 ")));f.Pc=723;continue;}
case 723:{f.Push(JValue.R(rt.String("_")));f.Pc=725;continue;}
case 725:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",728);}
case 728:{f.Push(JValue.R(rt.String(",")));f.Pc=730;continue;}
case 730:{f.Push(JValue.R(rt.String("")));f.Pc=732;continue;}
case 732:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",735);}
case 735:{f.Push(JValue.R(rt.String(" ")));f.Pc=737;continue;}
case 737:{f.Push(JValue.R(rt.String("_")));f.Pc=739;continue;}
case 739:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",742);}
case 742:{f.Locals[15]=f.Pop();f.Pc=744;continue;}
case 744:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",747);}
case 747:{f.Push(f.Locals[15]);f.Pc=749;continue;}
case 749:{f.Push(f.Locals[2]);f.Pc=750;continue;}
case 750:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",753);}
case 753:{return rt.Call(f,"forge/StaticData","getOtherImageKey","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",756);}
case 756:{f.Locals[14]=f.Pop();f.Pc=758;continue;}
case 758:{f.Pc=816;continue;}
case 761:{f.Push(f.Locals[1]);f.Pc=762;continue;}
case 762:{f.Push(JValue.R(rt.String("Image")));f.Pc=764;continue;}
case 764:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",767);}
case 767:{f.Pc=f.Pop().Int==0?784:770;continue;}
case 770:{f.Push(f.Locals[1]);f.Pc=771;continue;}
case 771:{f.Push(JValue.R(rt.String("Image")));f.Pc=773;continue;}
case 773:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",776);}
case 776:{return rt.Call(f,"forge/ImageKeys","getTokenKey","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",779);}
case 779:{f.Locals[14]=f.Pop();f.Pc=781;continue;}
case 781:{f.Pc=816;continue;}
case 784:{f.Push(f.Locals[1]);f.Pc=785;continue;}
case 785:{f.Push(JValue.R(rt.String("Adventure")));f.Pc=787;continue;}
case 787:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",790);}
case 790:{f.Pc=f.Pop().Int==0?810:793;continue;}
case 793:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",796);}
case 796:{f.Push(JValue.R(rt.String("adventure")));f.Pc=798;continue;}
case 798:{f.Push(f.Locals[2]);f.Pc=799;continue;}
case 799:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",802);}
case 802:{return rt.Call(f,"forge/StaticData","getOtherImageKey","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",805);}
case 805:{f.Locals[14]=f.Pop();f.Pc=807;continue;}
case 807:{f.Pc=816;continue;}
case 810:{f.Push(f.Locals[2]);f.Pc=811;continue;}
case 811:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",814);}
case 814:{f.Locals[14]=f.Pop();f.Pc=816;continue;}
case 816:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",819);}
case 819:{f.Locals[15]=f.Pop();f.Pc=821;continue;}
case 821:{f.Push(f.Locals[15]);f.Pc=823;continue;}
case 823:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=826;continue;}
case 826:{f.Push(f.Locals[1]);f.Pc=827;continue;}
case 827:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateBattlefield","()Lforge/game/card/CardCollection;","invokevirtual",830);}
case 830:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",835);}
case 835:{f.StackOp("pop");f.Pc=836;continue;}
case 836:{f.Push(f.Locals[15]);f.Pc=838;continue;}
case 838:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=841;continue;}
case 841:{f.Push(f.Locals[1]);f.Pc=842;continue;}
case 842:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateGraveyard","()Lforge/game/card/CardCollection;","invokevirtual",845);}
case 845:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",850);}
case 850:{f.StackOp("pop");f.Pc=851;continue;}
case 851:{f.Push(f.Locals[13]);f.Pc=853;continue;}
case 853:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",856);}
case 856:{f.Locals[16]=f.Pop();f.Pc=858;continue;}
case 858:{f.Push(f.Locals[16]);f.Pc=860;continue;}
case 860:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",865);}
case 865:{f.Pc=f.Pop().Int==0?1839:868;continue;}
case 868:{f.Push(f.Locals[16]);f.Pc=870;continue;}
case 870:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",875);}
case 875:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=878;continue;}
case 878:{f.Locals[17]=f.Pop();f.Pc=880;continue;}
case 880:{f.Push(f.Locals[1]);f.Pc=881;continue;}
case 881:{f.Push(f.Locals[17]);f.Pc=883;continue;}
case 883:{f.Push(f.Locals[12]);f.Pc=885;continue;}
case 885:{f.Push(f.Locals[14]);f.Pc=887;continue;}
case 887:{return rt.Call(f,"forge/game/ability/effects/EffectEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",890);}
case 890:{f.Locals[18]=f.Pop();f.Pc=892;continue;}
case 892:{f.Push(f.Locals[1]);f.Pc=893;continue;}
case 893:{f.Push(JValue.R(rt.String("Boon")));f.Pc=895;continue;}
case 895:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",898);}
case 898:{f.Pc=f.Pop().Int==0?907:901;continue;}
case 901:{f.Push(f.Locals[18]);f.Pc=903;continue;}
case 903:{f.Push(JValue.I(1));f.Pc=904;continue;}
case 904:{return rt.Call(f,"forge/game/card/Card","setBoon","(Z)V","invokevirtual",907);}
case 907:{f.Push(f.Locals[4]);f.Pc=909;continue;}
case 909:{f.Pc=f.Pop().Reference==null?967:912;continue;}
case 912:{f.Push(f.Locals[4]);f.Pc=914;continue;}
case 914:{f.Locals[19]=f.Pop();f.Pc=916;continue;}
case 916:{f.Push(f.Locals[19]);f.Pc=918;continue;}
case 918:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=919;continue;}
case 919:{f.Locals[20]=f.Pop();f.Pc=921;continue;}
case 921:{f.Push(JValue.I(0));f.Pc=922;continue;}
case 922:{f.Locals[21]=f.Pop();f.Pc=924;continue;}
case 924:{f.Push(f.Locals[21]);f.Pc=926;continue;}
case 926:{f.Push(f.Locals[20]);f.Pc=928;continue;}
case 928:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?967:931;continue;}
case 931:{f.Push(f.Locals[19]);f.Pc=933;continue;}
case 933:{f.Push(f.Locals[21]);f.Pc=935;continue;}
case 935:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=936;continue;}
case 936:{f.Locals[22]=f.Pop();f.Pc=938;continue;}
case 938:{f.Push(f.Locals[18]);f.Pc=940;continue;}
case 940:{f.Push(f.Locals[22]);f.Pc=942;continue;}
case 942:{f.Push(f.Locals[1]);f.Pc=943;continue;}
case 943:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",946);}
case 946:{f.Locals[23]=f.Pop();f.Pc=948;continue;}
case 948:{f.Push(f.Locals[18]);f.Pc=950;continue;}
case 950:{f.Push(f.Locals[23]);f.Pc=952;continue;}
case 952:{return rt.Call(f,"forge/game/card/Card","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",955);}
case 955:{f.Push(f.Locals[23]);f.Pc=957;continue;}
case 957:{f.Push(JValue.I(1));f.Pc=958;continue;}
case 958:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",961);}
case 961:{f.Locals[21]=JValue.I(unchecked(f.Locals[21].Int+(1)));f.Pc=964;continue;}
case 964:{f.Pc=924;continue;}
case 967:{f.Push(f.Locals[5]);f.Pc=969;continue;}
case 969:{f.Pc=f.Pop().Reference==null?1044:972;continue;}
case 972:{f.Push(f.Locals[5]);f.Pc=974;continue;}
case 974:{f.Locals[19]=f.Pop();f.Pc=976;continue;}
case 976:{f.Push(f.Locals[19]);f.Pc=978;continue;}
case 978:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=979;continue;}
case 979:{f.Locals[20]=f.Pop();f.Pc=981;continue;}
case 981:{f.Push(JValue.I(0));f.Pc=982;continue;}
case 982:{f.Locals[21]=f.Pop();f.Pc=984;continue;}
case 984:{f.Push(f.Locals[21]);f.Pc=986;continue;}
case 986:{f.Push(f.Locals[20]);f.Pc=988;continue;}
case 988:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1044:991;continue;}
case 991:{f.Push(f.Locals[19]);f.Pc=993;continue;}
case 993:{f.Push(f.Locals[21]);f.Pc=995;continue;}
case 995:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=996;continue;}
case 996:{f.Locals[22]=f.Pop();f.Pc=998;continue;}
case 998:{f.Push(f.Locals[1]);f.Pc=999;continue;}
case 999:{f.Push(f.Locals[22]);f.Pc=1001;continue;}
case 1001:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1004);}
case 1004:{f.Push(f.Locals[18]);f.Pc=1006;continue;}
case 1006:{f.Push(JValue.I(1));f.Pc=1007;continue;}
case 1007:{f.Push(f.Locals[1]);f.Pc=1008;continue;}
case 1008:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;","invokestatic",1011);}
case 1011:{f.Locals[23]=f.Pop();f.Pc=1013;continue;}
case 1013:{f.Push(f.Locals[23]);f.Pc=1015;continue;}
case 1015:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=1018;continue;}
case 1018:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",1021);}
case 1021:{return rt.Call(f,"forge/game/trigger/Trigger","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",1024);}
case 1024:{f.Push(f.Locals[23]);f.Pc=1026;continue;}
case 1026:{f.Push(JValue.I(1));f.Pc=1027;continue;}
case 1027:{return rt.Call(f,"forge/game/trigger/Trigger","setIntrinsic","(Z)V","invokevirtual",1030);}
case 1030:{f.Push(f.Locals[18]);f.Pc=1032;continue;}
case 1032:{f.Push(f.Locals[23]);f.Pc=1034;continue;}
case 1034:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",1037);}
case 1037:{f.StackOp("pop");f.Pc=1038;continue;}
case 1038:{f.Locals[21]=JValue.I(unchecked(f.Locals[21].Int+(1)));f.Pc=1041;continue;}
case 1041:{f.Pc=984;continue;}
case 1044:{f.Push(f.Locals[6]);f.Pc=1046;continue;}
case 1046:{f.Pc=f.Pop().Reference==null?1116:1049;continue;}
case 1049:{f.Push(f.Locals[6]);f.Pc=1051;continue;}
case 1051:{f.Locals[19]=f.Pop();f.Pc=1053;continue;}
case 1053:{f.Push(f.Locals[19]);f.Pc=1055;continue;}
case 1055:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1056;continue;}
case 1056:{f.Locals[20]=f.Pop();f.Pc=1058;continue;}
case 1058:{f.Push(JValue.I(0));f.Pc=1059;continue;}
case 1059:{f.Locals[21]=f.Pop();f.Pc=1061;continue;}
case 1061:{f.Push(f.Locals[21]);f.Pc=1063;continue;}
case 1063:{f.Push(f.Locals[20]);f.Pc=1065;continue;}
case 1065:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1116:1068;continue;}
case 1068:{f.Push(f.Locals[19]);f.Pc=1070;continue;}
case 1070:{f.Push(f.Locals[21]);f.Pc=1072;continue;}
case 1072:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1073;continue;}
case 1073:{f.Locals[22]=f.Pop();f.Pc=1075;continue;}
case 1075:{f.Push(f.Locals[18]);f.Pc=1077;continue;}
case 1077:{f.Push(f.Locals[1]);f.Pc=1078;continue;}
case 1078:{f.Push(f.Locals[22]);f.Pc=1080;continue;}
case 1080:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1083);}
case 1083:{return rt.Call(f,"forge/game/card/Card","addStaticAbility","(Ljava/lang/String;)Lforge/game/staticability/StaticAbility;","invokevirtual",1086);}
case 1086:{f.Locals[23]=f.Pop();f.Pc=1088;continue;}
case 1088:{f.Push(f.Locals[23]);f.Pc=1090;continue;}
case 1090:{f.Pc=f.Pop().Reference==null?1110:1093;continue;}
case 1093:{f.Push(f.Locals[23]);f.Pc=1095;continue;}
case 1095:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=1098;continue;}
case 1098:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",1101);}
case 1101:{return rt.Call(f,"forge/game/staticability/StaticAbility","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",1104);}
case 1104:{f.Push(f.Locals[23]);f.Pc=1106;continue;}
case 1106:{f.Push(JValue.I(1));f.Pc=1107;continue;}
case 1107:{return rt.Call(f,"forge/game/staticability/StaticAbility","setIntrinsic","(Z)V","invokevirtual",1110);}
case 1110:{f.Locals[21]=JValue.I(unchecked(f.Locals[21].Int+(1)));f.Pc=1113;continue;}
case 1113:{f.Pc=1061;continue;}
case 1116:{f.Push(f.Locals[7]);f.Pc=1118;continue;}
case 1118:{f.Pc=f.Pop().Reference==null?1201:1121;continue;}
case 1121:{f.Push(f.Locals[7]);f.Pc=1123;continue;}
case 1123:{f.Locals[19]=f.Pop();f.Pc=1125;continue;}
case 1125:{f.Push(f.Locals[19]);f.Pc=1127;continue;}
case 1127:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1128;continue;}
case 1128:{f.Locals[20]=f.Pop();f.Pc=1130;continue;}
case 1130:{f.Push(JValue.I(0));f.Pc=1131;continue;}
case 1131:{f.Locals[21]=f.Pop();f.Pc=1133;continue;}
case 1133:{f.Push(f.Locals[21]);f.Pc=1135;continue;}
case 1135:{f.Push(f.Locals[20]);f.Pc=1137;continue;}
case 1137:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1201:1140;continue;}
case 1140:{f.Push(f.Locals[19]);f.Pc=1142;continue;}
case 1142:{f.Push(f.Locals[21]);f.Pc=1144;continue;}
case 1144:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1145;continue;}
case 1145:{f.Locals[22]=f.Pop();f.Pc=1147;continue;}
case 1147:{f.Push(f.Locals[1]);f.Pc=1148;continue;}
case 1148:{f.Push(f.Locals[22]);f.Pc=1150;continue;}
case 1150:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSVar","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1153);}
case 1153:{f.Locals[23]=f.Pop();f.Pc=1155;continue;}
case 1155:{f.Push(f.Locals[23]);f.Pc=1157;continue;}
case 1157:{f.Push(f.Locals[18]);f.Pc=1159;continue;}
case 1159:{f.Push(JValue.I(1));f.Pc=1160;continue;}
case 1160:{f.Push(f.Locals[18]);f.Pc=1162;continue;}
case 1162:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",1165);}
case 1165:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",1168);}
case 1168:{f.Locals[24]=f.Pop();f.Pc=1170;continue;}
case 1170:{f.Push(f.Locals[24]);f.Pc=1172;continue;}
case 1172:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=1175;continue;}
case 1175:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",1178);}
case 1178:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",1181);}
case 1181:{f.Push(f.Locals[24]);f.Pc=1183;continue;}
case 1183:{f.Push(JValue.I(1));f.Pc=1184;continue;}
case 1184:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setIntrinsic","(Z)V","invokevirtual",1187);}
case 1187:{f.Push(f.Locals[18]);f.Pc=1189;continue;}
case 1189:{f.Push(f.Locals[24]);f.Pc=1191;continue;}
case 1191:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",1194);}
case 1194:{f.StackOp("pop");f.Pc=1195;continue;}
case 1195:{f.Locals[21]=JValue.I(unchecked(f.Locals[21].Int+(1)));f.Pc=1198;continue;}
case 1198:{f.Pc=1133;continue;}
case 1201:{f.Push(f.Locals[1]);f.Pc=1202;continue;}
case 1202:{f.Push(JValue.R(rt.String("RememberKeywords")));f.Pc=1205;continue;}
case 1205:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1208);}
case 1208:{f.Pc=f.Pop().Int==0?1312:1211;continue;}
case 1211:{f.Push(f.Locals[1]);f.Pc=1212;continue;}
case 1212:{f.Push(JValue.R(rt.String("RememberKeywords")));f.Pc=1215;continue;}
case 1215:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1218);}
case 1218:{f.Push(JValue.R(rt.String(",")));f.Pc=1220;continue;}
case 1220:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1223);}
case 1223:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",1226);}
case 1226:{f.Locals[19]=f.Pop();f.Pc=1228;continue;}
case 1228:{f.Push(f.Locals[1]);f.Pc=1229;continue;}
case 1229:{f.Push(JValue.R(rt.String("SharedKeywordsZone")));f.Pc=1232;continue;}
case 1232:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1235);}
case 1235:{f.Pc=f.Pop().Int==0?1300:1238;continue;}
case 1238:{f.Push(f.Locals[1]);f.Pc=1239;continue;}
case 1239:{f.Push(JValue.R(rt.String("SharedKeywordsZone")));f.Pc=1242;continue;}
case 1242:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1245);}
case 1245:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",1248);}
case 1248:{f.Locals[20]=f.Pop();f.Pc=1250;continue;}
case 1250:{f.Push(f.Locals[1]);f.Pc=1251;continue;}
case 1251:{f.Push(JValue.R(rt.String("SharedRestrictions")));f.Pc=1254;continue;}
case 1254:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1257);}
case 1257:{f.Pc=f.Pop().Int==0?1275:1260;continue;}
case 1260:{f.Push(f.Locals[1]);f.Pc=1261;continue;}
case 1261:{f.Push(JValue.R(rt.String("SharedRestrictions")));f.Pc=1264;continue;}
case 1264:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1267);}
case 1267:{f.Push(JValue.R(rt.String(",")));f.Pc=1269;continue;}
case 1269:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1272);}
case 1272:{f.Pc=1285;continue;}
case 1275:{f.Push(JValue.I(1));f.Pc=1276;continue;}
case 1276:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=1279;continue;}
case 1279:{f.StackOp("dup");f.Pc=1280;continue;}
case 1280:{f.Push(JValue.I(0));f.Pc=1281;continue;}
case 1281:{f.Push(JValue.R(rt.String("Card")));f.Pc=1284;continue;}
case 1284:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1285;continue;}
case 1285:{f.Locals[21]=f.Pop();f.Pc=1287;continue;}
case 1287:{f.Push(f.Locals[19]);f.Pc=1289;continue;}
case 1289:{f.Push(f.Locals[21]);f.Pc=1291;continue;}
case 1291:{f.Push(f.Locals[20]);f.Pc=1293;continue;}
case 1293:{f.Push(f.Locals[2]);f.Pc=1294;continue;}
case 1294:{f.Push(f.Locals[1]);f.Pc=1295;continue;}
case 1295:{return rt.Call(f,"forge/game/card/CardFactoryUtil","sharedKeywords","(Ljava/lang/Iterable;[Ljava/lang/String;Ljava/lang/Iterable;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",1298);}
case 1298:{f.Locals[19]=f.Pop();f.Pc=1300;continue;}
case 1300:{f.Push(f.Locals[19]);f.Pc=1302;continue;}
case 1302:{f.Pc=f.Pop().Reference==null?1312:1305;continue;}
case 1305:{f.Push(f.Locals[18]);f.Pc=1307;continue;}
case 1307:{f.Push(f.Locals[19]);f.Pc=1309;continue;}
case 1309:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1312);}
case 1312:{f.Push(f.Locals[8]);f.Pc=1314;continue;}
case 1314:{f.Pc=f.Pop().Reference==null?1443:1317;continue;}
case 1317:{f.Push(f.Locals[18]);f.Pc=1319;continue;}
case 1319:{f.Push(f.Locals[8]);f.Pc=1321;continue;}
case 1321:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1324);}
case 1324:{f.Push(f.Locals[1]);f.Pc=1325;continue;}
case 1325:{f.Push(JValue.R(rt.String("ForgetOnMoved")));f.Pc=1327;continue;}
case 1327:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1330);}
case 1330:{f.Pc=f.Pop().Int==0?1386:1333;continue;}
case 1333:{f.Push(f.Locals[18]);f.Pc=1335;continue;}
case 1335:{f.Push(f.Locals[1]);f.Pc=1336;continue;}
case 1336:{f.Push(JValue.R(rt.String("ForgetOnMoved")));f.Pc=1338;continue;}
case 1338:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1341);}
case 1341:{return rt.Call(f,"forge/game/ability/effects/EffectEffect","addForgetOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",1344);}
case 1344:{f.Push(JValue.R(rt.String("Stack")));f.Pc=1347;continue;}
case 1347:{f.Push(f.Locals[1]);f.Pc=1348;continue;}
case 1348:{f.Push(JValue.R(rt.String("ForgetOnMoved")));f.Pc=1350;continue;}
case 1350:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1353);}
case 1353:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1356);}
case 1356:{f.Pc=f.Pop().Int!=0?1406:1359;continue;}
case 1359:{f.Push(JValue.R(rt.String("False")));f.Pc=1362;continue;}
case 1362:{f.Push(f.Locals[1]);f.Pc=1363;continue;}
case 1363:{f.Push(JValue.R(rt.String("ForgetOnCast")));f.Pc=1366;continue;}
case 1366:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1369);}
case 1369:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",1372);}
case 1372:{f.Pc=f.Pop().Int!=0?1406:1375;continue;}
case 1375:{f.Push(f.Locals[18]);f.Pc=1377;continue;}
case 1377:{f.Push(JValue.R(rt.String("Card.IsRemembered")));f.Pc=1380;continue;}
case 1380:{return rt.Call(f,"forge/game/ability/effects/EffectEffect","addForgetOnCastTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",1383);}
case 1383:{f.Pc=1406;continue;}
case 1386:{f.Push(f.Locals[1]);f.Pc=1387;continue;}
case 1387:{f.Push(JValue.R(rt.String("ExileOnMoved")));f.Pc=1389;continue;}
case 1389:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1392);}
case 1392:{f.Pc=f.Pop().Int==0?1406:1395;continue;}
case 1395:{f.Push(f.Locals[18]);f.Pc=1397;continue;}
case 1397:{f.Push(f.Locals[1]);f.Pc=1398;continue;}
case 1398:{f.Push(JValue.R(rt.String("ExileOnMoved")));f.Pc=1400;continue;}
case 1400:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1403);}
case 1403:{return rt.Call(f,"forge/game/ability/effects/EffectEffect","addExileOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",1406);}
case 1406:{f.Push(f.Locals[1]);f.Pc=1407;continue;}
case 1407:{f.Push(JValue.R(rt.String("ForgetOnPhasedIn")));f.Pc=1409;continue;}
case 1409:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1412);}
case 1412:{f.Pc=f.Pop().Int==0?1420:1415;continue;}
case 1415:{f.Push(f.Locals[18]);f.Pc=1417;continue;}
case 1417:{return rt.Call(f,"forge/game/ability/effects/EffectEffect","addForgetOnPhasedInTrigger","(Lforge/game/card/Card;)V","invokestatic",1420);}
case 1420:{f.Push(f.Locals[1]);f.Pc=1421;continue;}
case 1421:{f.Push(JValue.R(rt.String("ForgetCounter")));f.Pc=1423;continue;}
case 1423:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1426);}
case 1426:{f.Pc=f.Pop().Int==0?1465:1429;continue;}
case 1429:{f.Push(f.Locals[18]);f.Pc=1431;continue;}
case 1431:{f.Push(f.Locals[1]);f.Pc=1432;continue;}
case 1432:{f.Push(JValue.R(rt.String("ForgetCounter")));f.Pc=1434;continue;}
case 1434:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1437);}
case 1437:{return rt.Call(f,"forge/game/ability/effects/EffectEffect","addForgetCounterTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",1440);}
case 1440:{f.Pc=1465;continue;}
case 1443:{f.Push(f.Locals[1]);f.Pc=1444;continue;}
case 1444:{f.Push(JValue.R(rt.String("ForgetOnCast")));f.Pc=1447;continue;}
case 1447:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1450);}
case 1450:{f.Pc=f.Pop().Int==0?1465:1453;continue;}
case 1453:{f.Push(f.Locals[18]);f.Pc=1455;continue;}
case 1455:{f.Push(f.Locals[1]);f.Pc=1456;continue;}
case 1456:{f.Push(JValue.R(rt.String("ForgetOnCast")));f.Pc=1459;continue;}
case 1459:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1462);}
case 1462:{return rt.Call(f,"forge/game/ability/effects/EffectEffect","addForgetOnCastTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",1465);}
case 1465:{f.Push(f.Locals[1]);f.Pc=1466;continue;}
case 1466:{f.Push(JValue.R(rt.String("ExileOnLost")));f.Pc=1469;continue;}
case 1469:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1472);}
case 1472:{f.Pc=f.Pop().Int==0?1480:1475;continue;}
case 1475:{f.Push(f.Locals[18]);f.Pc=1477;continue;}
case 1477:{return rt.Call(f,"forge/game/ability/effects/EffectEffect","addExileOnLostTrigger","(Lforge/game/card/Card;)V","invokestatic",1480);}
case 1480:{f.Push(f.Locals[1]);f.Pc=1481;continue;}
case 1481:{f.Push(JValue.R(rt.String("ExileOnCounter")));f.Pc=1484;continue;}
case 1484:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1487);}
case 1487:{f.Pc=f.Pop().Int==0?1502:1490;continue;}
case 1490:{f.Push(f.Locals[18]);f.Pc=1492;continue;}
case 1492:{f.Push(f.Locals[1]);f.Pc=1493;continue;}
case 1493:{f.Push(JValue.R(rt.String("ExileOnCounter")));f.Pc=1496;continue;}
case 1496:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1499);}
case 1499:{return rt.Call(f,"forge/game/ability/effects/EffectEffect","addExileCounterTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",1502);}
case 1502:{f.Push(f.Locals[9]);f.Pc=1504;continue;}
case 1504:{f.Pc=f.Pop().Reference==null?1519:1507;continue;}
case 1507:{f.Push(f.Locals[18]);f.Pc=1509;continue;}
case 1509:{f.Push(f.Locals[2]);f.Pc=1510;continue;}
case 1510:{f.Push(f.Locals[9]);f.Pc=1512;continue;}
case 1512:{f.Push(f.Locals[1]);f.Pc=1513;continue;}
case 1513:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1516);}
case 1516:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",1519);}
case 1519:{f.Push(f.Locals[10]);f.Pc=1521;continue;}
case 1521:{f.Pc=f.Pop().Reference==null?1568:1524;continue;}
case 1524:{f.Push(f.Locals[2]);f.Pc=1525;continue;}
case 1525:{f.Push(f.Locals[10]);f.Pc=1527;continue;}
case 1527:{f.Push(f.Locals[1]);f.Pc=1528;continue;}
case 1528:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1531);}
case 1531:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1534);}
case 1534:{f.Locals[19]=f.Pop();f.Pc=1536;continue;}
case 1536:{f.Push(f.Locals[19]);f.Pc=1538;continue;}
case 1538:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1543);}
case 1543:{f.Pc=f.Pop().Int==0?1568:1546;continue;}
case 1546:{f.Push(f.Locals[19]);f.Pc=1548;continue;}
case 1548:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1553);}
case 1553:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1556;continue;}
case 1556:{f.Locals[20]=f.Pop();f.Pc=1558;continue;}
case 1558:{f.Push(f.Locals[20]);f.Pc=1560;continue;}
case 1560:{f.Push(f.Locals[18]);f.Pc=1562;continue;}
case 1562:{return rt.Call(f,"forge/game/ability/effects/CountersNoteEffect","noteCounters","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokestatic",1565);}
case 1565:{f.Pc=1536;continue;}
case 1568:{f.Push(f.Locals[2]);f.Pc=1569;continue;}
case 1569:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",1572);}
case 1572:{f.Pc=f.Pop().Int==0?1587:1575;continue;}
case 1575:{f.Push(f.Locals[18]);f.Pc=1577;continue;}
case 1577:{f.Push(f.Locals[2]);f.Pc=1578;continue;}
case 1578:{return rt.Call(f,"forge/game/card/Card","getChosenColors","()Ljava/lang/Iterable;","invokevirtual",1581);}
case 1581:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",1584);}
case 1584:{return rt.Call(f,"forge/game/card/Card","setChosenColors","(Ljava/util/List;)V","invokevirtual",1587);}
case 1587:{f.Push(f.Locals[2]);f.Pc=1588;continue;}
case 1588:{return rt.Call(f,"forge/game/card/Card","hasChosenCard","()Z","invokevirtual",1591);}
case 1591:{f.Pc=f.Pop().Int==0?1603:1594;continue;}
case 1594:{f.Push(f.Locals[18]);f.Pc=1596;continue;}
case 1596:{f.Push(f.Locals[2]);f.Pc=1597;continue;}
case 1597:{return rt.Call(f,"forge/game/card/Card","getChosenCards","()Lforge/game/card/CardCollectionView;","invokevirtual",1600);}
case 1600:{return rt.Call(f,"forge/game/card/Card","setChosenCards","(Ljava/lang/Iterable;)V","invokevirtual",1603);}
case 1603:{f.Push(f.Locals[2]);f.Pc=1604;continue;}
case 1604:{return rt.Call(f,"forge/game/card/Card","hasChosenPlayer","()Z","invokevirtual",1607);}
case 1607:{f.Pc=f.Pop().Int==0?1619:1610;continue;}
case 1610:{f.Push(f.Locals[18]);f.Pc=1612;continue;}
case 1612:{f.Push(f.Locals[2]);f.Pc=1613;continue;}
case 1613:{return rt.Call(f,"forge/game/card/Card","getChosenPlayer","()Lforge/game/player/Player;","invokevirtual",1616);}
case 1616:{return rt.Call(f,"forge/game/card/Card","setChosenPlayer","(Lforge/game/player/Player;)V","invokevirtual",1619);}
case 1619:{f.Push(f.Locals[2]);f.Pc=1620;continue;}
case 1620:{return rt.Call(f,"forge/game/card/Card","getChosenDirection","()Lforge/game/Direction;","invokevirtual",1623);}
case 1623:{f.Pc=f.Pop().Reference==null?1635:1626;continue;}
case 1626:{f.Push(f.Locals[18]);f.Pc=1628;continue;}
case 1628:{f.Push(f.Locals[2]);f.Pc=1629;continue;}
case 1629:{return rt.Call(f,"forge/game/card/Card","getChosenDirection","()Lforge/game/Direction;","invokevirtual",1632);}
case 1632:{return rt.Call(f,"forge/game/card/Card","setChosenDirection","(Lforge/game/Direction;)V","invokevirtual",1635);}
case 1635:{f.Push(f.Locals[2]);f.Pc=1636;continue;}
case 1636:{return rt.Call(f,"forge/game/card/Card","hasChosenType","()Z","invokevirtual",1639);}
case 1639:{f.Pc=f.Pop().Int==0?1651:1642;continue;}
case 1642:{f.Push(f.Locals[18]);f.Pc=1644;continue;}
case 1644:{f.Push(f.Locals[2]);f.Pc=1645;continue;}
case 1645:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",1648);}
case 1648:{return rt.Call(f,"forge/game/card/Card","setChosenType","(Ljava/lang/String;)V","invokevirtual",1651);}
case 1651:{f.Push(f.Locals[2]);f.Pc=1652;continue;}
case 1652:{return rt.Call(f,"forge/game/card/Card","hasChosenType2","()Z","invokevirtual",1655);}
case 1655:{f.Pc=f.Pop().Int==0?1667:1658;continue;}
case 1658:{f.Push(f.Locals[18]);f.Pc=1660;continue;}
case 1660:{f.Push(f.Locals[2]);f.Pc=1661;continue;}
case 1661:{return rt.Call(f,"forge/game/card/Card","getChosenType2","()Ljava/lang/String;","invokevirtual",1664);}
case 1664:{return rt.Call(f,"forge/game/card/Card","setChosenType2","(Ljava/lang/String;)V","invokevirtual",1667);}
case 1667:{f.Push(f.Locals[2]);f.Pc=1668;continue;}
case 1668:{return rt.Call(f,"forge/game/card/Card","hasNamedCard","()Z","invokevirtual",1671);}
case 1671:{f.Pc=f.Pop().Int==0?1686:1674;continue;}
case 1674:{f.Push(f.Locals[18]);f.Pc=1676;continue;}
case 1676:{f.Push(f.Locals[2]);f.Pc=1677;continue;}
case 1677:{return rt.Call(f,"forge/game/card/Card","getNamedCards","()Ljava/util/List;","invokevirtual",1680);}
case 1680:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",1683);}
case 1683:{return rt.Call(f,"forge/game/card/Card","setNamedCards","(Ljava/util/List;)V","invokevirtual",1686);}
case 1686:{f.Push(f.Locals[1]);f.Pc=1687;continue;}
case 1687:{f.Push(JValue.R(rt.String("SetChosenNumber")));f.Pc=1690;continue;}
case 1690:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1693);}
case 1693:{f.Pc=f.Pop().Int==0?1716:1696;continue;}
case 1696:{f.Push(f.Locals[18]);f.Pc=1698;continue;}
case 1698:{f.Push(f.Locals[2]);f.Pc=1699;continue;}
case 1699:{f.Push(f.Locals[1]);f.Pc=1700;continue;}
case 1700:{f.Push(JValue.R(rt.String("SetChosenNumber")));f.Pc=1703;continue;}
case 1703:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1706);}
case 1706:{f.Push(f.Locals[1]);f.Pc=1707;continue;}
case 1707:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1710);}
case 1710:{return rt.Call(f,"forge/game/card/Card","setChosenNumber","(I)V","invokevirtual",1713);}
case 1713:{f.Pc=1735;continue;}
case 1716:{f.Push(f.Locals[2]);f.Pc=1717;continue;}
case 1717:{return rt.Call(f,"forge/game/card/Card","hasChosenNumber","()Z","invokevirtual",1720);}
case 1720:{f.Pc=f.Pop().Int==0?1735:1723;continue;}
case 1723:{f.Push(f.Locals[18]);f.Pc=1725;continue;}
case 1725:{f.Push(f.Locals[2]);f.Pc=1726;continue;}
case 1726:{return rt.Call(f,"forge/game/card/Card","getChosenNumber","()Ljava/lang/Integer;","invokevirtual",1729);}
case 1729:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1732);}
case 1732:{return rt.Call(f,"forge/game/card/Card","setChosenNumber","(I)V","invokevirtual",1735);}
case 1735:{f.Push(f.Locals[1]);f.Pc=1736;continue;}
case 1736:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",1739);}
case 1739:{f.Pc=f.Pop().Int==0?1748:1742;continue;}
case 1742:{f.Push(f.Locals[18]);f.Pc=1744;continue;}
case 1744:{f.Push(f.Locals[2]);f.Pc=1745;continue;}
case 1745:{return rt.Call(f,"forge/game/card/Card","copyChangedTextFrom","(Lforge/game/card/Card;)V","invokevirtual",1748);}
case 1748:{f.Push(f.Locals[1]);f.Pc=1749;continue;}
case 1749:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=1752;continue;}
case 1752:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1755);}
case 1755:{f.Pc=f.Pop().Int==0?1780:1758;continue;}
case 1758:{f.Push(f.Locals[1]);f.Pc=1759;continue;}
case 1759:{f.Push(f.Locals[1]);f.Pc=1760;continue;}
case 1760:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=1763;continue;}
case 1763:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1766);}
case 1766:{f.Push(JValue.I(1));f.Pc=1767;continue;}
case 1767:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=1770;continue;}
case 1770:{f.StackOp("dup");f.Pc=1771;continue;}
case 1771:{f.Push(JValue.I(0));f.Pc=1772;continue;}
case 1772:{f.Push(f.Locals[2]);f.Pc=1773;continue;}
case 1773:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1774;continue;}
case 1774:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",1777);}
case 1777:{return rt.Call(f,"forge/game/ability/effects/EffectEffect","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V","invokestatic",1780);}
case 1780:{f.Push(f.Locals[11]);f.Pc=1782;continue;}
case 1782:{f.Pc=f.Pop().Reference==null?1796:1785;continue;}
case 1785:{f.Push(f.Locals[11]);f.Pc=1787;continue;}
case 1787:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=1790;continue;}
case 1790:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1793);}
case 1793:{f.Pc=f.Pop().Int!=0?1810:1796;continue;}
case 1796:{f.Push(f.Locals[1]);f.Pc=1797;continue;}
case 1797:{f.Push(f.Locals[3]);f.Pc=1798;continue;}
case 1798:{f.Push(f.Locals[18]);f.Pc=1800;continue;}
case 1800:{return rt.DynamicCall(f,"forge/game/ability/effects/EffectEffect:3373:1800:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",1805);}
case 1805:{f.Push(f.Locals[17]);f.Pc=1807;continue;}
case 1807:{return rt.Call(f,"forge/game/ability/effects/EffectEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;Lforge/game/player/Player;)V","invokestatic",1810);}
case 1810:{f.Push(f.Locals[1]);f.Pc=1811;continue;}
case 1811:{f.Push(JValue.R(rt.String("ImprintOnHost")));f.Pc=1814;continue;}
case 1814:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1817);}
case 1817:{f.Pc=f.Pop().Int==0?1826:1820;continue;}
case 1820:{f.Push(f.Locals[2]);f.Pc=1821;continue;}
case 1821:{f.Push(f.Locals[18]);f.Pc=1823;continue;}
case 1823:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",1826);}
case 1826:{f.Push(f.Locals[3]);f.Pc=1827;continue;}
case 1827:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1830);}
case 1830:{f.Push(f.Locals[18]);f.Pc=1832;continue;}
case 1832:{f.Push(f.Locals[1]);f.Pc=1833;continue;}
case 1833:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1836);}
case 1836:{f.Pc=858;continue;}
case 1839:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3374(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",11);}
case 11:{switch(f.Pop().Int){case 520199269:f.Pc=28;break;default:f.Pc=40;break;}continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("lambda$resolve$f894d637$1")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Locals[2]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{switch(f.Pop().Int){case 0:f.Pc=60;break;default:f.Pc=156;break;}continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",64);}
case 64:{f.Push(JValue.I(6));f.Pc=66;continue;}
case 66:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?156:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?156:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Push(JValue.R(rt.String("run")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?156:95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Push(JValue.R(rt.String("()V")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?156:108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",112);}
case 112:{f.Push(JValue.R(rt.String("forge/game/ability/effects/EffectEffect")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int==0?156:121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",125);}
case 125:{f.Push(JValue.R(rt.String("(Lforge/game/Game;Lforge/game/card/Card;)V")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?156:134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/Game"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(JValue.I(1));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",147);}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{return rt.DynamicCall(f,"forge/game/ability/effects/EffectEffect:3374:150:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",155);}
case 155:{return JStep.Return(f.Pop());}
case 156:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=159;continue;}
case 159:{f.StackOp("dup");f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("Invalid lambda deserialization")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",166);}
case 166:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3375(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameAction","exileEffect","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

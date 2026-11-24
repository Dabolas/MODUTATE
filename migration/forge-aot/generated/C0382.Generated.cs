// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C382{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ReplaceTokenEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3652,"forge/game/ability/effects/ReplaceTokenEffect","<init>","()V",1,1,1,new JHandler[]{},M3652));
c.Add(new JMethod(3653,"forge/game/ability/effects/ReplaceTokenEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,23,6,new JHandler[]{},M3653));
c.Add(new JMethod(3654,"forge/game/ability/effects/ReplaceTokenEffect","lambda$resolve$2","(Ljava/util/Map$Entry;)I",4106,1,1,new JHandler[]{},M3654));
c.Add(new JMethod(3655,"forge/game/ability/effects/ReplaceTokenEffect","lambda$resolve$1","(Ljava/util/Map$Entry;)Lforge/game/player/Player;",4106,1,1,new JHandler[]{},M3655));
c.Add(new JMethod(3656,"forge/game/ability/effects/ReplaceTokenEffect","lambda$resolve$0","(Lforge/game/replacement/ReplacementEffect;Ljava/util/Map$Entry;)Z",4106,2,3,new JHandler[]{},M3656));
}

internal static JStep M3652(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3653(JRuntime rt,JFrame f)
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
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Locals[5]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[5]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObjects","()Ljava/util/Map;","invokevirtual",24);}
case 24:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?38:32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",36);}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacementEffect","()Lforge/game/replacement/ReplacementEffect;","invokevirtual",43);}
case 43:{f.Locals[6]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[7]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Token","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Token","Lforge/game/ability/AbilityKey;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",66);}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/TokenCreateTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{f.Locals[8]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OriginalParams","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OriginalParams","Lforge/game/ability/AbilityKey;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{f.Locals[9]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("Amount")));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("Type")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",92);}
case 92:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?220:98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("Amount")));f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("Twice")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",106);}
case 106:{f.Locals[10]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[8]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[7]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/TokenCreateTable","row","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",115);}
case 115:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",120);}
case 120:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",125);}
case 125:{f.Locals[11]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[11]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",134);}
case 134:{f.Pc=f.Pop().Int==0?217:137;continue;}
case 137:{f.Push(f.Locals[11]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",144);}
case 144:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=147;continue;}
case 147:{f.Locals[12]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[6]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("ValidToken")));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[12]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",160);}
case 160:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",163);}
case 163:{f.Pc=f.Pop().Int!=0?169:166;continue;}
case 166:{f.Pc=127;continue;}
case 169:{f.Push(f.Locals[12]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",176);}
case 176:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",182);}
case 182:{f.Push(f.Locals[10]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[2]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/ability/AbilityUtils","doXMath","(ILjava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)I","invokestatic",189);}
case 189:{f.Locals[13]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[8]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[7]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[12]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",202);}
case 202:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[13]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",210);}
case 210:{return rt.Call(f,"forge/game/card/TokenCreateTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",213);}
case 213:{f.StackOp("pop");f.Pc=214;continue;}
case 214:{f.Pc=127;continue;}
case 217:{f.Pc=1223;continue;}
case 220:{f.Push(JValue.R(rt.String("AddToken")));f.Pc=222;continue;}
case 222:{f.Push(f.Locals[1]);f.Pc=223;continue;}
case 223:{f.Push(JValue.R(rt.String("Type")));f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",228);}
case 228:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",231);}
case 231:{f.Pc=f.Pop().Int==0?544:234;continue;}
case 234:{f.Push(f.Locals[4]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",239);}
case 239:{f.Locals[10]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[8]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[7]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/card/TokenCreateTable","row","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",248);}
case 248:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",253);}
case 253:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",258);}
case 258:{f.Push(f.Locals[6]);f.Pc=260;continue;}
case 260:{return rt.DynamicCall(f,"forge/game/ability/effects/ReplaceTokenEffect:3653:260:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/replacement/ReplacementEffect;)Ljava/util/function/Predicate;",265);}
case 265:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",270);}
case 270:{return rt.DynamicCall(f,"forge/game/ability/effects/ReplaceTokenEffect:3653:270:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",275);}
case 275:{return rt.DynamicCall(f,"forge/game/ability/effects/ReplaceTokenEffect:3653:275:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",280);}
case 280:{return rt.Call(f,"java/util/stream/Collectors","summingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;","invokestatic",283);}
case 283:{return rt.Call(f,"java/util/stream/Collectors","groupingBy","(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;","invokestatic",286);}
case 286:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",291);}
case 291:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=294;continue;}
case 294:{f.Locals[12]=f.Pop();f.Pc=296;continue;}
case 296:{f.Push(f.Locals[12]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",303);}
case 303:{f.Pc=f.Pop().Int!=0?541:306;continue;}
case 306:{f.Push(f.Locals[1]);f.Pc=307;continue;}
case 307:{f.Push(JValue.R(rt.String("Amount")));f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",312);}
case 312:{f.Pc=f.Pop().Int==0?380:315;continue;}
case 315:{f.Push(f.Locals[2]);f.Pc=316;continue;}
case 316:{f.Push(f.Locals[1]);f.Pc=317;continue;}
case 317:{f.Push(JValue.R(rt.String("Amount")));f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",322);}
case 322:{f.Push(f.Locals[1]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",326);}
case 326:{f.Locals[13]=f.Pop();f.Pc=328;continue;}
case 328:{f.Push(f.Locals[12]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",335);}
case 335:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",340);}
case 340:{f.Locals[14]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[14]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",349);}
case 349:{f.Pc=f.Pop().Int==0?380:352;continue;}
case 352:{f.Push(f.Locals[14]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",359);}
case 359:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=362;continue;}
case 362:{f.Locals[15]=f.Pop();f.Pc=364;continue;}
case 364:{f.Push(f.Locals[15]);f.Pc=366;continue;}
case 366:{f.Push(f.Locals[13]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",371);}
case 371:{return rt.Call(f,"java/util/Map$Entry","setValue","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",376);}
case 376:{f.StackOp("pop");f.Pc=377;continue;}
case 377:{f.Pc=342;continue;}
case 380:{f.Push(f.Locals[12]);f.Pc=382;continue;}
case 382:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",387);}
case 387:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",392);}
case 392:{f.Locals[13]=f.Pop();f.Pc=394;continue;}
case 394:{f.Push(f.Locals[13]);f.Pc=396;continue;}
case 396:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",401);}
case 401:{f.Pc=f.Pop().Int==0?541:404;continue;}
case 404:{f.Push(f.Locals[13]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",411);}
case 411:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=414;continue;}
case 414:{f.Locals[14]=f.Pop();f.Pc=416;continue;}
case 416:{f.Push(f.Locals[1]);f.Pc=417;continue;}
case 417:{f.Push(JValue.R(rt.String("TokenScript")));f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",422);}
case 422:{f.Push(JValue.R(rt.String(",")));f.Pc=424;continue;}
case 424:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",427);}
case 427:{f.Locals[15]=f.Pop();f.Pc=429;continue;}
case 429:{f.Push(f.Locals[15]);f.Pc=431;continue;}
case 431:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=432;continue;}
case 432:{f.Locals[16]=f.Pop();f.Pc=434;continue;}
case 434:{f.Push(JValue.I(0));f.Pc=435;continue;}
case 435:{f.Locals[17]=f.Pop();f.Pc=437;continue;}
case 437:{f.Push(f.Locals[17]);f.Pc=439;continue;}
case 439:{f.Push(f.Locals[16]);f.Pc=441;continue;}
case 441:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?538:444;continue;}
case 444:{f.Push(f.Locals[15]);f.Pc=446;continue;}
case 446:{f.Push(f.Locals[17]);f.Pc=448;continue;}
case 448:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=449;continue;}
case 449:{f.Locals[18]=f.Pop();f.Pc=451;continue;}
case 451:{f.Push(f.Locals[18]);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[1]);f.Pc=454;continue;}
case 454:{f.Push(f.Locals[3]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/card/token/TokenInfo","getProtoType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",458);}
case 458:{f.Locals[19]=f.Pop();f.Pc=460;continue;}
case 460:{f.Push(f.Locals[19]);f.Pc=462;continue;}
case 462:{f.Pc=f.Pop().Reference!=null?480:465;continue;}
case 465:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=468;continue;}
case 468:{f.StackOp("dup");f.Pc=469;continue;}
case 469:{f.Push(f.Locals[18]);f.Pc=471;continue;}
case 471:{return rt.DynamicCall(f,"forge/game/ability/effects/ReplaceTokenEffect:3653:471:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",476);}
case 476:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",479);}
case 479:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 480:{f.Push(f.Locals[19]);f.Pc=482;continue;}
case 482:{f.Push(f.Locals[5]);f.Pc=484;continue;}
case 484:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=487;continue;}
case 487:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",490);}
case 490:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=493;continue;}
case 493:{return rt.Call(f,"forge/game/card/Card","setTokenSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",496);}
case 496:{f.Push(f.Locals[19]);f.Pc=498;continue;}
case 498:{f.Push(f.Locals[14]);f.Pc=500;continue;}
case 500:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",505);}
case 505:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=508;continue;}
case 508:{f.Push(f.Locals[10]);f.Pc=510;continue;}
case 510:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",513);}
case 513:{f.Push(f.Locals[8]);f.Pc=515;continue;}
case 515:{f.Push(f.Locals[3]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[19]);f.Pc=518;continue;}
case 518:{f.Push(f.Locals[14]);f.Pc=520;continue;}
case 520:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",525);}
case 525:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/game/card/TokenCreateTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",531);}
case 531:{f.StackOp("pop");f.Pc=532;continue;}
case 532:{f.Locals[17]=JValue.I(unchecked(f.Locals[17].Int+(1)));f.Pc=535;continue;}
case 535:{f.Pc=437;continue;}
case 538:{f.Pc=394;continue;}
case 541:{f.Pc=1223;continue;}
case 544:{f.Push(JValue.R(rt.String("ReplaceToken")));f.Pc=546;continue;}
case 546:{f.Push(f.Locals[1]);f.Pc=547;continue;}
case 547:{f.Push(JValue.R(rt.String("Type")));f.Pc=549;continue;}
case 549:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",552);}
case 552:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",555);}
case 555:{f.Pc=f.Pop().Int==0?1083:558;continue;}
case 558:{f.Push(JValue.R(null));f.Pc=559;continue;}
case 559:{f.Locals[10]=f.Pop();f.Pc=561;continue;}
case 561:{f.Push(f.Locals[1]);f.Pc=562;continue;}
case 562:{f.Push(JValue.R(rt.String("ValidChoices")));f.Pc=564;continue;}
case 564:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",567);}
case 567:{f.Pc=f.Pop().Int==0?647:570;continue;}
case 570:{f.Push(f.Locals[4]);f.Pc=572;continue;}
case 572:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=575;continue;}
case 575:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",578);}
case 578:{f.Push(f.Locals[1]);f.Pc=579;continue;}
case 579:{f.Push(JValue.R(rt.String("ValidChoices")));f.Pc=581;continue;}
case 581:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",584);}
case 584:{f.Push(f.Locals[3]);f.Pc=585;continue;}
case 585:{f.Push(f.Locals[2]);f.Pc=586;continue;}
case 586:{f.Push(f.Locals[1]);f.Pc=587;continue;}
case 587:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",590);}
case 590:{f.Locals[11]=f.Pop();f.Pc=592;continue;}
case 592:{f.Push(f.Locals[11]);f.Pc=594;continue;}
case 594:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",599);}
case 599:{f.Pc=f.Pop().Int==0?617:602;continue;}
case 602:{f.Push(f.Locals[9]);f.Pc=604;continue;}
case 604:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=607;continue;}
case 607:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=610;continue;}
case 610:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",615);}
case 615:{f.StackOp("pop");f.Pc=616;continue;}
case 616:{return JStep.ReturnVoid;}
case 617:{f.Push(f.Locals[3]);f.Pc=618;continue;}
case 618:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",621);}
case 621:{f.Push(f.Locals[11]);f.Pc=623;continue;}
case 623:{f.Push(f.Locals[1]);f.Pc=624;continue;}
case 624:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",627);}
case 627:{f.Push(JValue.R(rt.String("lblChooseaCard")));f.Pc=630;continue;}
case 630:{f.Push(JValue.I(0));f.Pc=631;continue;}
case 631:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=634;continue;}
case 634:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",637);}
case 637:{f.Push(JValue.I(0));f.Pc=638;continue;}
case 638:{f.Push(JValue.R(null));f.Pc=639;continue;}
case 639:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",642);}
case 642:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=645;continue;}
case 645:{f.Locals[10]=f.Pop();f.Pc=647;continue;}
case 647:{f.Push(f.Locals[4]);f.Pc=649;continue;}
case 649:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",652);}
case 652:{f.Locals[11]=f.Pop();f.Pc=654;continue;}
case 654:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",657);}
case 657:{f.Locals[13]=f.Pop();f.Pc=659;continue;}
case 659:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",662);}
case 662:{f.Locals[14]=f.Pop();f.Pc=664;continue;}
case 664:{f.Push(f.Locals[8]);f.Pc=666;continue;}
case 666:{f.Push(f.Locals[7]);f.Pc=668;continue;}
case 668:{return rt.Call(f,"forge/game/card/TokenCreateTable","row","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",671);}
case 671:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",676);}
case 676:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",681);}
case 681:{f.Locals[15]=f.Pop();f.Pc=683;continue;}
case 683:{f.Push(f.Locals[15]);f.Pc=685;continue;}
case 685:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",690);}
case 690:{f.Pc=f.Pop().Int==0?805:693;continue;}
case 693:{f.Push(f.Locals[15]);f.Pc=695;continue;}
case 695:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",700);}
case 700:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=703;continue;}
case 703:{f.Locals[16]=f.Pop();f.Pc=705;continue;}
case 705:{f.Push(f.Locals[6]);f.Pc=707;continue;}
case 707:{f.Push(JValue.R(rt.String("ValidToken")));f.Pc=709;continue;}
case 709:{f.Push(f.Locals[16]);f.Pc=711;continue;}
case 711:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",716);}
case 716:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",719);}
case 719:{f.Pc=f.Pop().Int!=0?725:722;continue;}
case 722:{f.Pc=683;continue;}
case 725:{f.Push(f.Locals[16]);f.Pc=727;continue;}
case 727:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",732);}
case 732:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=735;continue;}
case 735:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",738);}
case 738:{f.Locals[17]=f.Pop();f.Pc=740;continue;}
case 740:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/tuple/ImmutablePair"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/tuple/ImmutablePair")));f.Pc=743;continue;}
case 743:{f.StackOp("dup");f.Pc=744;continue;}
case 744:{f.Push(f.Locals[16]);f.Pc=746;continue;}
case 746:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",751);}
case 751:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=754;continue;}
case 754:{f.Push(f.Locals[16]);f.Pc=756;continue;}
case 756:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",761);}
case 761:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=764;continue;}
case 764:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",767);}
case 767:{return rt.Call(f,"org/apache/commons/lang3/tuple/ImmutablePair","<init>","(Ljava/lang/Object;Ljava/lang/Object;)V","invokespecial",770);}
case 770:{f.Locals[18]=f.Pop();f.Pc=772;continue;}
case 772:{f.Push(f.Locals[13]);f.Pc=774;continue;}
case 774:{f.Push(f.Locals[17]);f.Pc=776;continue;}
case 776:{f.Push(f.Locals[18]);f.Pc=778;continue;}
case 778:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",783);}
case 783:{f.StackOp("pop");f.Pc=784;continue;}
case 784:{f.Push(f.Locals[14]);f.Pc=786;continue;}
case 786:{f.Push(f.Locals[16]);f.Pc=788;continue;}
case 788:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",793);}
case 793:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=796;continue;}
case 796:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",801);}
case 801:{f.StackOp("pop");f.Pc=802;continue;}
case 802:{f.Pc=683;continue;}
case 805:{f.Push(f.Locals[8]);f.Pc=807;continue;}
case 807:{f.Push(f.Locals[7]);f.Pc=809;continue;}
case 809:{return rt.Call(f,"forge/game/card/TokenCreateTable","row","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",812);}
case 812:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",817);}
case 817:{f.Push(f.Locals[14]);f.Pc=819;continue;}
case 819:{return rt.Call(f,"java/util/Set","removeAll","(Ljava/util/Collection;)Z","invokeinterface",824);}
case 824:{f.StackOp("pop");f.Pc=825;continue;}
case 825:{f.Push(f.Locals[13]);f.Pc=827;continue;}
case 827:{return rt.Call(f,"com/google/common/collect/Multimap","entries","()Ljava/util/Collection;","invokeinterface",832);}
case 832:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",837);}
case 837:{f.Locals[15]=f.Pop();f.Pc=839;continue;}
case 839:{f.Push(f.Locals[15]);f.Pc=841;continue;}
case 841:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",846);}
case 846:{f.Pc=f.Pop().Int==0?1080:849;continue;}
case 849:{f.Push(f.Locals[15]);f.Pc=851;continue;}
case 851:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",856);}
case 856:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=859;continue;}
case 859:{f.Locals[16]=f.Pop();f.Pc=861;continue;}
case 861:{f.Push(f.Locals[16]);f.Pc=863;continue;}
case 863:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",868);}
case 868:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=871;continue;}
case 871:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",874);}
case 874:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=877;continue;}
case 877:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",880);}
case 880:{f.Locals[17]=f.Pop();f.Pc=882;continue;}
case 882:{f.Push(f.Locals[17]);f.Pc=884;continue;}
case 884:{f.Pc=f.Pop().Int>0?890:887;continue;}
case 887:{f.Pc=839;continue;}
case 890:{f.Push(f.Locals[1]);f.Pc=891;continue;}
case 891:{f.Push(JValue.R(rt.String("TokenScript")));f.Pc=893;continue;}
case 893:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",896);}
case 896:{f.Push(JValue.R(rt.String(",")));f.Pc=898;continue;}
case 898:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",901);}
case 901:{f.Locals[18]=f.Pop();f.Pc=903;continue;}
case 903:{f.Push(f.Locals[18]);f.Pc=905;continue;}
case 905:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=906;continue;}
case 906:{f.Locals[19]=f.Pop();f.Pc=908;continue;}
case 908:{f.Push(JValue.I(0));f.Pc=909;continue;}
case 909:{f.Locals[20]=f.Pop();f.Pc=911;continue;}
case 911:{f.Push(f.Locals[20]);f.Pc=913;continue;}
case 913:{f.Push(f.Locals[19]);f.Pc=915;continue;}
case 915:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1077:918;continue;}
case 918:{f.Push(f.Locals[18]);f.Pc=920;continue;}
case 920:{f.Push(f.Locals[20]);f.Pc=922;continue;}
case 922:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=923;continue;}
case 923:{f.Locals[21]=f.Pop();f.Pc=925;continue;}
case 925:{f.Push(f.Locals[21]);f.Pc=927;continue;}
case 927:{f.Push(JValue.R(rt.String("Chosen")));f.Pc=930;continue;}
case 930:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",933);}
case 933:{f.Pc=f.Pop().Int==0?964:936;continue;}
case 936:{f.Push(f.Locals[1]);f.Pc=937;continue;}
case 937:{f.Push(f.Locals[10]);f.Pc=939;continue;}
case 939:{f.Push(f.Locals[16]);f.Pc=941;continue;}
case 941:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",946);}
case 946:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=949;continue;}
case 949:{return rt.Call(f,"forge/game/ability/effects/CopyPermanentEffect","getProtoType","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",952);}
case 952:{f.Locals[22]=f.Pop();f.Pc=954;continue;}
case 954:{f.Push(f.Locals[22]);f.Pc=956;continue;}
case 956:{f.Push(f.Locals[22]);f.Pc=958;continue;}
case 958:{return rt.Call(f,"forge/game/card/Card","setCopiedPermanent","(Lforge/game/card/Card;)V","invokevirtual",961);}
case 961:{f.Pc=982;continue;}
case 964:{f.Push(f.Locals[21]);f.Pc=966;continue;}
case 966:{f.Push(f.Locals[1]);f.Pc=967;continue;}
case 967:{f.Push(f.Locals[16]);f.Pc=969;continue;}
case 969:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",974);}
case 974:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=977;continue;}
case 977:{return rt.Call(f,"forge/game/card/token/TokenInfo","getProtoType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",980);}
case 980:{f.Locals[22]=f.Pop();f.Pc=982;continue;}
case 982:{f.Push(f.Locals[22]);f.Pc=984;continue;}
case 984:{f.Pc=f.Pop().Reference!=null?1002:987;continue;}
case 987:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=990;continue;}
case 990:{f.StackOp("dup");f.Pc=991;continue;}
case 991:{f.Push(f.Locals[21]);f.Pc=993;continue;}
case 993:{return rt.DynamicCall(f,"forge/game/ability/effects/ReplaceTokenEffect:3653:993:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",998);}
case 998:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",1001);}
case 1001:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 1002:{f.Push(f.Locals[22]);f.Pc=1004;continue;}
case 1004:{f.Push(f.Locals[5]);f.Pc=1006;continue;}
case 1006:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=1009;continue;}
case 1009:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",1012);}
case 1012:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1015;continue;}
case 1015:{return rt.Call(f,"forge/game/card/Card","setTokenSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1018);}
case 1018:{f.Push(f.Locals[22]);f.Pc=1020;continue;}
case 1020:{f.Push(f.Locals[16]);f.Pc=1022;continue;}
case 1022:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",1027);}
case 1027:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1030;continue;}
case 1030:{f.Push(f.Locals[11]);f.Pc=1032;continue;}
case 1032:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",1035);}
case 1035:{f.Push(f.Locals[22]);f.Pc=1037;continue;}
case 1037:{f.Push(f.Locals[16]);f.Pc=1039;continue;}
case 1039:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",1044);}
case 1044:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1047;continue;}
case 1047:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",1050);}
case 1050:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1053;continue;}
case 1053:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1056);}
case 1056:{f.Push(f.Locals[8]);f.Pc=1058;continue;}
case 1058:{f.Push(f.Locals[7]);f.Pc=1060;continue;}
case 1060:{f.Push(f.Locals[22]);f.Pc=1062;continue;}
case 1062:{f.Push(f.Locals[17]);f.Pc=1064;continue;}
case 1064:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1067);}
case 1067:{return rt.Call(f,"forge/game/card/TokenCreateTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",1070);}
case 1070:{f.StackOp("pop");f.Pc=1071;continue;}
case 1071:{f.Locals[20]=JValue.I(unchecked(f.Locals[20].Int+(1)));f.Pc=1074;continue;}
case 1074:{f.Pc=911;continue;}
case 1077:{f.Pc=839;continue;}
case 1080:{f.Pc=1223;continue;}
case 1083:{f.Push(JValue.R(rt.String("ReplaceController")));f.Pc=1086;continue;}
case 1086:{f.Push(f.Locals[1]);f.Pc=1087;continue;}
case 1087:{f.Push(JValue.R(rt.String("Type")));f.Pc=1089;continue;}
case 1089:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1092);}
case 1092:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1095);}
case 1095:{f.Pc=f.Pop().Int==0?1223:1098;continue;}
case 1098:{f.Push(f.Locals[4]);f.Pc=1100;continue;}
case 1100:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",1103);}
case 1103:{f.Locals[10]=f.Pop();f.Pc=1105;continue;}
case 1105:{f.Push(f.Locals[3]);f.Pc=1106;continue;}
case 1106:{f.Locals[12]=f.Pop();f.Pc=1108;continue;}
case 1108:{f.Push(f.Locals[1]);f.Pc=1109;continue;}
case 1109:{f.Push(JValue.R(rt.String("NewController")));f.Pc=1112;continue;}
case 1112:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1115);}
case 1115:{f.Pc=f.Pop().Int==0?1142:1118;continue;}
case 1118:{f.Push(f.Locals[1]);f.Pc=1119;continue;}
case 1119:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1122);}
case 1122:{f.Push(f.Locals[1]);f.Pc=1123;continue;}
case 1123:{f.Push(JValue.R(rt.String("NewController")));f.Pc=1126;continue;}
case 1126:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1129);}
case 1129:{f.Push(f.Locals[1]);f.Pc=1130;continue;}
case 1130:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1133);}
case 1133:{f.Push(JValue.I(0));f.Pc=1134;continue;}
case 1134:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",1137);}
case 1137:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1140;continue;}
case 1140:{f.Locals[12]=f.Pop();f.Pc=1142;continue;}
case 1142:{f.Push(f.Locals[8]);f.Pc=1144;continue;}
case 1144:{f.Push(f.Locals[7]);f.Pc=1146;continue;}
case 1146:{return rt.Call(f,"forge/game/card/TokenCreateTable","row","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",1149);}
case 1149:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",1154);}
case 1154:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",1159);}
case 1159:{f.Locals[13]=f.Pop();f.Pc=1161;continue;}
case 1161:{f.Push(f.Locals[13]);f.Pc=1163;continue;}
case 1163:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1168);}
case 1168:{f.Pc=f.Pop().Int==0?1223:1171;continue;}
case 1171:{f.Push(f.Locals[13]);f.Pc=1173;continue;}
case 1173:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1178);}
case 1178:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1181;continue;}
case 1181:{f.Locals[14]=f.Pop();f.Pc=1183;continue;}
case 1183:{f.Push(f.Locals[6]);f.Pc=1185;continue;}
case 1185:{f.Push(JValue.R(rt.String("ValidToken")));f.Pc=1187;continue;}
case 1187:{f.Push(f.Locals[14]);f.Pc=1189;continue;}
case 1189:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",1194);}
case 1194:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",1197);}
case 1197:{f.Pc=f.Pop().Int!=0?1203:1200;continue;}
case 1200:{f.Pc=1161;continue;}
case 1203:{f.Push(f.Locals[14]);f.Pc=1205;continue;}
case 1205:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",1210);}
case 1210:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1213;continue;}
case 1213:{f.Push(f.Locals[12]);f.Pc=1215;continue;}
case 1215:{f.Push(f.Locals[10]);f.Pc=1217;continue;}
case 1217:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",1220);}
case 1220:{f.Pc=1161;continue;}
case 1223:{f.Push(f.Locals[9]);f.Pc=1225;continue;}
case 1225:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=1228;continue;}
case 1228:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=1231;continue;}
case 1231:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1236);}
case 1236:{f.StackOp("pop");f.Pc=1237;continue;}
case 1237:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3654(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3655(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3656(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidToken")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

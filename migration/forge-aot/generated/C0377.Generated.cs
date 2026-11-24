// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C377{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ReplaceCounterEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3642,"forge/game/ability/effects/ReplaceCounterEffect","<init>","()V",1,1,1,new JHandler[]{},M3642));
c.Add(new JMethod(3643,"forge/game/ability/effects/ReplaceCounterEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,5,new JHandler[]{},M3643));
}

internal static JStep M3642(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3643(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int!=0?13:12;continue;}
case 12:{return JStep.ReturnVoid;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OriginalParams","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OriginalParams","Lforge/game/ability/AbilityKey;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",20);}
case 20:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=23;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",43);}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?387:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("ChooseCounter")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?387:56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Object","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Object","Lforge/game/ability/AbilityKey;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[5]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=73;continue;}
case 73:{f.Pc=f.Pop().Int==0?84:76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{f.Pc=92;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",92);}
case 92:{f.Locals[6]=f.Pop();f.Pc=94;continue;}
case 94:{return rt.Call(f,"com/google/common/collect/HashMultimap","create","()Lcom/google/common/collect/HashMultimap;","invokestatic",97);}
case 97:{f.Locals[7]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",106);}
case 106:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",111);}
case 111:{f.Locals[8]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[8]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",120);}
case 120:{f.Pc=f.Pop().Int==0?212:123;continue;}
case 123:{f.Push(f.Locals[8]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",130);}
case 130:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=133;continue;}
case 133:{f.Locals[9]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[9]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",142);}
case 142:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=145;continue;}
case 145:{return rt.Call(f,"com/google/common/collect/Multiset","elementSet","()Ljava/util/Set;","invokeinterface",150);}
case 150:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",155);}
case 155:{f.Locals[10]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[10]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",164);}
case 164:{f.Pc=f.Pop().Int==0?209:167;continue;}
case 167:{f.Push(f.Locals[10]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",174);}
case 174:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=177;continue;}
case 177:{f.Locals[11]=f.Pop();f.Pc=179;continue;}
case 179:{f.Push(f.Locals[7]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[11]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[9]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",190);}
case 190:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Optional"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=193;continue;}
case 193:{f.Push(JValue.R(null));f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/util/Optional","orElse","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",197);}
case 197:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=200;continue;}
case 200:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",205);}
case 205:{f.StackOp("pop");f.Pc=206;continue;}
case 206:{f.Pc=157;continue;}
case 209:{f.Pc=113;continue;}
case 212:{f.Push(f.Locals[7]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"com/google/common/collect/Multimap","asMap","()Ljava/util/Map;","invokeinterface",219);}
case 219:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",224);}
case 224:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",229);}
case 229:{f.Locals[8]=f.Pop();f.Pc=231;continue;}
case 231:{f.Push(f.Locals[8]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",238);}
case 238:{f.Pc=f.Pop().Int==0?384:241;continue;}
case 241:{f.Push(f.Locals[8]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",248);}
case 248:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=251;continue;}
case 251:{f.Locals[9]=f.Pop();f.Pc=253;continue;}
case 253:{f.Push(f.Locals[6]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",258);}
case 258:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=261;continue;}
case 261:{f.StackOp("dup");f.Pc=262;continue;}
case 262:{f.Push(f.Locals[9]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",269);}
case 269:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",275);}
case 275:{f.Push(f.Locals[1]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[9]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",283);}
case 283:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",291);}
case 291:{return rt.DynamicCall(f,"forge/game/ability/effects/ReplaceCounterEffect:3643:291:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",296);}
case 296:{f.Push(JValue.R(null));f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",300);}
case 300:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/util/Optional","ofNullable","(Ljava/lang/Object;)Ljava/util/Optional;","invokestatic",306);}
case 306:{f.Locals[10]=f.Pop();f.Pc=308;continue;}
case 308:{f.Push(f.Locals[1]);f.Pc=309;continue;}
case 309:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterNum","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterNum","Lforge/game/ability/AbilityKey;"));f.Pc=312;continue;}
case 312:{f.Push(f.Locals[4]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[10]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",321);}
case 321:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=324;continue;}
case 324:{f.Push(f.Locals[9]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",331);}
case 331:{return rt.Call(f,"com/google/common/collect/Multiset","count","(Ljava/lang/Object;)I","invokeinterface",336);}
case 336:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",339);}
case 339:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",342);}
case 342:{f.Push(f.Locals[4]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[10]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",351);}
case 351:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=354;continue;}
case 354:{f.Push(f.Locals[9]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",361);}
case 361:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=364;continue;}
case 364:{f.Push(f.Locals[2]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[1]);f.Pc=366;continue;}
case 366:{f.Push(JValue.R(rt.String("Amount")));f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",371);}
case 371:{f.Push(f.Locals[1]);f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",375);}
case 375:{return rt.Call(f,"com/google/common/collect/Multiset","setCount","(Ljava/lang/Object;I)I","invokeinterface",380);}
case 380:{f.StackOp("pop");f.Pc=381;continue;}
case 381:{f.Pc=231;continue;}
case 384:{f.Pc=653;continue;}
case 387:{f.Push(f.Locals[4]);f.Pc=389;continue;}
case 389:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",394);}
case 394:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",399);}
case 399:{f.Locals[5]=f.Pop();f.Pc=401;continue;}
case 401:{f.Push(f.Locals[5]);f.Pc=403;continue;}
case 403:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",408);}
case 408:{f.Pc=f.Pop().Int==0?653:411;continue;}
case 411:{f.Push(f.Locals[5]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",418);}
case 418:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=421;continue;}
case 421:{f.Locals[6]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(f.Locals[1]);f.Pc=424;continue;}
case 424:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=426;continue;}
case 426:{f.Push(f.Locals[6]);f.Pc=428;continue;}
case 428:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",433);}
case 433:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Optional"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=436;continue;}
case 436:{f.Push(JValue.R(null));f.Pc=437;continue;}
case 437:{return rt.Call(f,"java/util/Optional","orElse","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",440);}
case 440:{return rt.Call(f,"forge/game/spellability/SpellAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",443);}
case 443:{f.Pc=f.Pop().Int!=0?449:446;continue;}
case 446:{f.Pc=401;continue;}
case 449:{f.Push(f.Locals[1]);f.Pc=450;continue;}
case 450:{f.Push(JValue.R(rt.String("ValidCounterType")));f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",455);}
case 455:{f.Pc=f.Pop().Int==0?548:458;continue;}
case 458:{f.Push(f.Locals[1]);f.Pc=459;continue;}
case 459:{f.Push(JValue.R(rt.String("ValidCounterType")));f.Pc=461;continue;}
case 461:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",464);}
case 464:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",467);}
case 467:{f.Locals[7]=f.Pop();f.Pc=469;continue;}
case 469:{f.Push(f.Locals[6]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",476);}
case 476:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=479;continue;}
case 479:{f.Push(f.Locals[7]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"com/google/common/collect/Multiset","contains","(Ljava/lang/Object;)Z","invokeinterface",486);}
case 486:{f.Pc=f.Pop().Int==0?545:489;continue;}
case 489:{f.Push(f.Locals[1]);f.Pc=490;continue;}
case 490:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterNum","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterNum","Lforge/game/ability/AbilityKey;"));f.Pc=493;continue;}
case 493:{f.Push(f.Locals[6]);f.Pc=495;continue;}
case 495:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",500);}
case 500:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=503;continue;}
case 503:{f.Push(f.Locals[7]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"com/google/common/collect/Multiset","count","(Ljava/lang/Object;)I","invokeinterface",510);}
case 510:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",513);}
case 513:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",516);}
case 516:{f.Push(f.Locals[6]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",523);}
case 523:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=526;continue;}
case 526:{f.Push(f.Locals[7]);f.Pc=528;continue;}
case 528:{f.Push(f.Locals[2]);f.Pc=529;continue;}
case 529:{f.Push(f.Locals[1]);f.Pc=530;continue;}
case 530:{f.Push(JValue.R(rt.String("Amount")));f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",535);}
case 535:{f.Push(f.Locals[1]);f.Pc=536;continue;}
case 536:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",539);}
case 539:{return rt.Call(f,"com/google/common/collect/Multiset","setCount","(Ljava/lang/Object;I)I","invokeinterface",544);}
case 544:{f.StackOp("pop");f.Pc=545;continue;}
case 545:{f.Pc=650;continue;}
case 548:{f.Push(f.Locals[6]);f.Pc=550;continue;}
case 550:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",555);}
case 555:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=558;continue;}
case 558:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",563);}
case 563:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",566);}
case 566:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",569);}
case 569:{f.Locals[7]=f.Pop();f.Pc=571;continue;}
case 571:{f.Push(f.Locals[7]);f.Pc=573;continue;}
case 573:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",578);}
case 578:{f.Pc=f.Pop().Int==0?650:581;continue;}
case 581:{f.Push(f.Locals[7]);f.Pc=583;continue;}
case 583:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",588);}
case 588:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=591;continue;}
case 591:{f.Locals[8]=f.Pop();f.Pc=593;continue;}
case 593:{f.Push(f.Locals[1]);f.Pc=594;continue;}
case 594:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterNum","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterNum","Lforge/game/ability/AbilityKey;"));f.Pc=597;continue;}
case 597:{f.Push(f.Locals[8]);f.Pc=599;continue;}
case 599:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",604);}
case 604:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",607);}
case 607:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",610);}
case 610:{f.Push(f.Locals[6]);f.Pc=612;continue;}
case 612:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",617);}
case 617:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=620;continue;}
case 620:{f.Push(f.Locals[8]);f.Pc=622;continue;}
case 622:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",627);}
case 627:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=630;continue;}
case 630:{f.Push(f.Locals[2]);f.Pc=631;continue;}
case 631:{f.Push(f.Locals[1]);f.Pc=632;continue;}
case 632:{f.Push(JValue.R(rt.String("Amount")));f.Pc=634;continue;}
case 634:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",637);}
case 637:{f.Push(f.Locals[1]);f.Pc=638;continue;}
case 638:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",641);}
case 641:{return rt.Call(f,"com/google/common/collect/Multiset","setCount","(Ljava/lang/Object;I)I","invokeinterface",646);}
case 646:{f.StackOp("pop");f.Pc=647;continue;}
case 647:{f.Pc=571;continue;}
case 650:{f.Pc=401;continue;}
case 653:{f.Push(f.Locals[3]);f.Pc=654;continue;}
case 654:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=657;continue;}
case 657:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=660;continue;}
case 660:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",665);}
case 665:{f.StackOp("pop");f.Pc=666;continue;}
case 666:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C252{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ControlExchangeVariantEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3199,"forge/game/ability/effects/ControlExchangeVariantEffect","<init>","()V",1,1,1,new JHandler[]{},M3199));
c.Add(new JMethod(3200,"forge/game/ability/effects/ControlExchangeVariantEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,2,new JHandler[]{},M3200));
c.Add(new JMethod(3201,"forge/game/ability/effects/ControlExchangeVariantEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,18,8,new JHandler[]{},M3201));
}

internal static JStep M3199(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3200(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/ControlExchangeVariantEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",4);}
case 4:{f.Push(JValue.R(rt.String(",")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",9);}
case 9:{return rt.DynamicCall(f,"forge/game/ability/effects/ControlExchangeVariantEffect:3200:9:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3201(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/effects/ControlExchangeVariantEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",16);}
case 16:{f.Push(JValue.I(2));f.Pc=17;continue;}
case 17:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?21:20;continue;}
case 20:{return JStep.ReturnVoid;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[5]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("Zone")));f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",56);}
case 56:{f.Locals[6]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("Type")));f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Card")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",66);}
case 66:{f.Locals[7]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[6]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",75);}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",81);}
case 81:{f.Locals[8]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[5]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[6]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",90);}
case 90:{f.Push(f.Locals[7]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",96);}
case 96:{f.Locals[9]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[8]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",105);}
case 105:{f.Push(f.Locals[9]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",112);}
case 112:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",115);}
case 115:{f.Locals[10]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[2]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",121);}
case 121:{f.Push(f.Locals[8]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",127);}
case 127:{f.Push(JValue.R(rt.String("lblChooseCards")));f.Pc=129;continue;}
case 129:{f.Push(JValue.I(0));f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",136);}
case 136:{f.Push(f.Locals[4]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",141);}
case 141:{return rt.DynamicCall(f,"forge/game/ability/effects/ControlExchangeVariantEffect:3201:141:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",146);}
case 146:{f.Push(JValue.I(0));f.Pc=147;continue;}
case 147:{f.Push(f.Locals[10]);f.Pc=149;continue;}
case 149:{f.Push(JValue.I(1));f.Pc=150;continue;}
case 150:{f.Push(JValue.R(null));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",154);}
case 154:{f.Locals[11]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[11]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",163);}
case 163:{f.Locals[12]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[2]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",169);}
case 169:{f.Push(f.Locals[9]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",175);}
case 175:{f.Push(JValue.R(rt.String("lblChooseCards")));f.Pc=177;continue;}
case 177:{f.Push(JValue.I(0));f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",184);}
case 184:{f.Push(f.Locals[5]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",189);}
case 189:{return rt.DynamicCall(f,"forge/game/ability/effects/ControlExchangeVariantEffect:3201:189:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",194);}
case 194:{f.Push(f.Locals[12]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[12]);f.Pc=198;continue;}
case 198:{f.Push(JValue.I(1));f.Pc=199;continue;}
case 199:{f.Push(JValue.R(null));f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",203);}
case 203:{f.Locals[13]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[11]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",212);}
case 212:{f.Locals[14]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[14]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",221);}
case 221:{f.Pc=f.Pop().Int==0?250:224;continue;}
case 224:{f.Push(f.Locals[14]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",231);}
case 231:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=234;continue;}
case 234:{f.Locals[15]=f.Pop();f.Pc=236;continue;}
case 236:{f.Push(f.Locals[15]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[5]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/card/Card","canBeControlledBy","(Lforge/game/player/Player;)Z","invokevirtual",243);}
case 243:{f.Pc=f.Pop().Int!=0?247:246;continue;}
case 246:{return JStep.ReturnVoid;}
case 247:{f.Pc=214;continue;}
case 250:{f.Push(f.Locals[13]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",257);}
case 257:{f.Locals[14]=f.Pop();f.Pc=259;continue;}
case 259:{f.Push(f.Locals[14]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",266);}
case 266:{f.Pc=f.Pop().Int==0?295:269;continue;}
case 269:{f.Push(f.Locals[14]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",276);}
case 276:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=279;continue;}
case 279:{f.Locals[15]=f.Pop();f.Pc=281;continue;}
case 281:{f.Push(f.Locals[15]);f.Pc=283;continue;}
case 283:{f.Push(f.Locals[4]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/card/Card","canBeControlledBy","(Lforge/game/player/Player;)Z","invokevirtual",288);}
case 288:{f.Pc=f.Pop().Int!=0?292:291;continue;}
case 291:{return JStep.ReturnVoid;}
case 292:{f.Pc=259;continue;}
case 295:{f.Push(f.Locals[1]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",299);}
case 299:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",302);}
case 302:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",305);}
case 305:{f.Locals[14]=f.Pop();f.Pc=307;continue;}
case 307:{f.Push(f.Locals[11]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",314);}
case 314:{f.Locals[16]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[16]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",323);}
case 323:{f.Pc=f.Pop().Int==0?350:326;continue;}
case 326:{f.Push(f.Locals[16]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",333);}
case 333:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=336;continue;}
case 336:{f.Locals[17]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[17]);f.Pc=340;continue;}
case 340:{f.Push(f.Locals[5]);f.Pc=342;continue;}
case 342:{f.Push(f.Locals[14]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/card/Card","addTempController","(Lforge/game/player/Player;J)V","invokevirtual",347);}
case 347:{f.Pc=316;continue;}
case 350:{f.Push(f.Locals[13]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",357);}
case 357:{f.Locals[16]=f.Pop();f.Pc=359;continue;}
case 359:{f.Push(f.Locals[16]);f.Pc=361;continue;}
case 361:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",366);}
case 366:{f.Pc=f.Pop().Int==0?393:369;continue;}
case 369:{f.Push(f.Locals[16]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",376);}
case 376:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=379;continue;}
case 379:{f.Locals[17]=f.Pop();f.Pc=381;continue;}
case 381:{f.Push(f.Locals[17]);f.Pc=383;continue;}
case 383:{f.Push(f.Locals[4]);f.Pc=385;continue;}
case 385:{f.Push(f.Locals[14]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/card/Card","addTempController","(Lforge/game/player/Player;J)V","invokevirtual",390);}
case 390:{f.Pc=359;continue;}
case 393:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

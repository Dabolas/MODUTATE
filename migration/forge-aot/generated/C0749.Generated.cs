// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C749{
internal static JClass Build(){var c=new JClass("forge/game/replacement/ReplaceDamage","forge/game/replacement/ReplacementEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(8903,"forge/game/replacement/ReplaceDamage","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M8903));
c.Add(new JMethod(8904,"forge/game/replacement/ReplaceDamage","canReplace","(Ljava/util/Map;)Z",1,8,4,new JHandler[]{},M8904));
c.Add(new JMethod(8905,"forge/game/replacement/ReplaceDamage","setReplacingObjects","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V",1,3,4,new JHandler[]{},M8905));
}

internal static JStep M8903(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8904(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?28:26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",40);}
case 40:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int!=0?48:46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",60);}
case 60:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int!=0?68:66;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",80);}
case 80:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int!=0?88:86;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("CauseIsSource")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","hasParam","(Ljava/lang/String;)Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?131:97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",106);}
case 106:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=109;continue;}
case 109:{f.Locals[3]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",114);}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",123);}
case 123:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int!=0?131:129;continue;}
case 129:{f.Push(JValue.I(0));f.Pc=130;continue;}
case 130:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String("RelativeToSource")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","hasParam","(Ljava/lang/String;)Z","invokevirtual",137);}
case 137:{f.Pc=f.Pop().Int==0?187:140;continue;}
case 140:{f.Push(f.Locals[1]);f.Pc=141;continue;}
case 141:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",149);}
case 149:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=152;continue;}
case 152:{f.Locals[3]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("RelativeToSource")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",159);}
case 159:{f.Locals[4]=f.Pop();f.Pc=161;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",171);}
case 171:{f.Push(f.Locals[4]);f.Pc=173;continue;}
case 173:{f.Push(JValue.R(rt.String(",")));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",178);}
case 178:{f.Push(f.Locals[3]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","matchesValid","(Ljava/lang/Object;[Ljava/lang/String;Lforge/game/card/Card;)Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int!=0?187:185;continue;}
case 185:{f.Push(JValue.I(0));f.Pc=186;continue;}
case 186:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String("DamageAmount")));f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","hasParam","(Ljava/lang/String;)Z","invokevirtual",193);}
case 193:{f.Pc=f.Pop().Int==0?257:196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String("DamageAmount")));f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",202);}
case 202:{f.Locals[3]=f.Pop();f.Pc=203;continue;}
case 203:{f.Push(f.Locals[3]);f.Pc=204;continue;}
case 204:{f.Push(JValue.I(0));f.Pc=205;continue;}
case 205:{f.Push(JValue.I(2));f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",209);}
case 209:{f.Locals[4]=f.Pop();f.Pc=211;continue;}
case 211:{f.Push(f.Locals[3]);f.Pc=212;continue;}
case 212:{f.Push(JValue.I(2));f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",216);}
case 216:{f.Locals[5]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","getHostCard","()Lforge/game/card/Card;","invokevirtual",222);}
case 222:{f.Push(f.Locals[5]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[0]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",228);}
case 228:{f.Locals[6]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[1]);f.Pc=231;continue;}
case 231:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",239);}
case 239:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",245);}
case 245:{f.Push(f.Locals[4]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[6]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",252);}
case 252:{f.Pc=f.Pop().Int!=0?257:255;continue;}
case 255:{f.Push(JValue.I(0));f.Pc=256;continue;}
case 256:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 257:{f.Push(f.Locals[0]);f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String("IsCombat")));f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","hasParam","(Ljava/lang/String;)Z","invokevirtual",263);}
case 263:{f.Pc=f.Pop().Int==0?297:266;continue;}
case 266:{f.Push(f.Locals[0]);f.Pc=267;continue;}
case 267:{f.Push(JValue.R(rt.String("IsCombat")));f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",272);}
case 272:{f.Push(JValue.R(rt.String("True")));f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",277);}
case 277:{f.Push(f.Locals[1]);f.Pc=278;continue;}
case 278:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IsCombat","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IsCombat","Lforge/game/ability/AbilityKey;"));f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",286);}
case 286:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=289;continue;}
case 289:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",292);}
case 292:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?297:295;continue;}
case 295:{f.Push(JValue.I(0));f.Pc=296;continue;}
case 296:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 297:{f.Push(f.Locals[0]);f.Pc=298;continue;}
case 298:{f.Push(JValue.R(rt.String("DamageTarget")));f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","hasParam","(Ljava/lang/String;)Z","invokevirtual",303);}
case 303:{f.Pc=f.Pop().Int==0?586:306;continue;}
case 306:{f.Push(f.Locals[1]);f.Pc=307;continue;}
case 307:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=310;continue;}
case 310:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",315);}
case 315:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=318;continue;}
case 318:{f.Locals[3]=f.Pop();f.Pc=319;continue;}
case 319:{f.Push(f.Locals[1]);f.Pc=320;continue;}
case 320:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",328);}
case 328:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=331;continue;}
case 331:{f.Locals[4]=f.Pop();f.Pc=333;continue;}
case 333:{f.Push(f.Locals[3]);f.Pc=334;continue;}
case 334:{f.Pc=f.Pop().Reference==null?346:337;continue;}
case 337:{f.Push(f.Locals[3]);f.Pc=338;continue;}
case 338:{f.Push(JValue.R(rt.String("NoRedirection")));f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",343);}
case 343:{f.Pc=f.Pop().Int!=0?356:346;continue;}
case 346:{f.Push(f.Locals[4]);f.Pc=348;continue;}
case 348:{f.Push(JValue.R(rt.String("Damage that would be dealt to CARDNAME can't be redirected.")));f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/GameEntity","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",353);}
case 353:{f.Pc=f.Pop().Int==0?358:356;continue;}
case 356:{f.Push(JValue.I(0));f.Pc=357;continue;}
case 357:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 358:{f.Push(f.Locals[0]);f.Pc=359;continue;}
case 359:{f.Push(JValue.R(rt.String("DamageTarget")));f.Pc=361;continue;}
case 361:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",364);}
case 364:{f.Locals[5]=f.Pop();f.Pc=366;continue;}
case 366:{f.Push(f.Locals[5]);f.Pc=368;continue;}
case 368:{f.Push(JValue.R(rt.String("Replaced")));f.Pc=370;continue;}
case 370:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",373);}
case 373:{f.Pc=f.Pop().Int==0?460:376;continue;}
case 376:{f.Push(f.Locals[5]);f.Pc=378;continue;}
case 378:{f.Push(JValue.R(rt.String("ReplacedSourceController")));f.Pc=380;continue;}
case 380:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",383);}
case 383:{f.Pc=f.Pop().Int==0?420:386;continue;}
case 386:{f.Push(f.Locals[1]);f.Pc=387;continue;}
case 387:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=390;continue;}
case 390:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",395);}
case 395:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=398;continue;}
case 398:{f.Locals[6]=f.Pop();f.Pc=400;continue;}
case 400:{f.Push(f.Locals[2]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",404);}
case 404:{f.Push(f.Locals[6]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",409);}
case 409:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",412);}
case 412:{f.Pc=f.Pop().Int!=0?417:415;continue;}
case 415:{f.Push(JValue.I(0));f.Pc=416;continue;}
case 416:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 417:{f.Pc=586;continue;}
case 420:{f.Push(f.Locals[5]);f.Pc=422;continue;}
case 422:{f.Push(JValue.R(rt.String("ReplacedTargetController")));f.Pc=424;continue;}
case 424:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",427);}
case 427:{f.Pc=f.Pop().Int==0?458:430;continue;}
case 430:{f.Push(f.Locals[4]);f.Pc=432;continue;}
case 432:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=435;continue;}
case 435:{f.Pc=f.Pop().Int==0?456:438;continue;}
case 438:{f.Push(f.Locals[2]);f.Pc=439;continue;}
case 439:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",442);}
case 442:{f.Push(f.Locals[4]);f.Pc=444;continue;}
case 444:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=447;continue;}
case 447:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",450);}
case 450:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",453);}
case 453:{f.Pc=f.Pop().Int!=0?586:456;continue;}
case 456:{f.Push(JValue.I(0));f.Pc=457;continue;}
case 457:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 458:{f.Push(JValue.I(0));f.Pc=459;continue;}
case 459:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 460:{f.Push(f.Locals[0]);f.Pc=461;continue;}
case 461:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","getHostCard","()Lforge/game/card/Card;","invokevirtual",464);}
case 464:{f.Push(f.Locals[5]);f.Pc=466;continue;}
case 466:{f.Push(f.Locals[0]);f.Pc=467;continue;}
case 467:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",470);}
case 470:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",473);}
case 473:{f.Locals[6]=f.Pop();f.Pc=475;continue;}
case 475:{f.Push(f.Locals[6]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",482);}
case 482:{f.Pc=f.Pop().Int==0?510:485;continue;}
case 485:{f.Push(f.Locals[6]);f.Pc=487;continue;}
case 487:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",492);}
case 492:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=495;continue;}
case 495:{f.Locals[7]=f.Pop();f.Pc=497;continue;}
case 497:{f.Push(f.Locals[7]);f.Pc=499;continue;}
case 499:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",502);}
case 502:{f.Pc=f.Pop().Int!=0?507:505;continue;}
case 505:{f.Push(JValue.I(0));f.Pc=506;continue;}
case 506:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 507:{f.Pc=475;continue;}
case 510:{f.Push(f.Locals[0]);f.Pc=511;continue;}
case 511:{return rt.Call(f,"forge/game/replacement/ReplaceDamage","getHostCard","()Lforge/game/card/Card;","invokevirtual",514);}
case 514:{f.Push(f.Locals[5]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[0]);f.Pc=517;continue;}
case 517:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",520);}
case 520:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",523);}
case 523:{f.Locals[6]=f.Pop();f.Pc=525;continue;}
case 525:{f.Push(f.Locals[6]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",532);}
case 532:{f.Pc=f.Pop().Int==0?586:535;continue;}
case 535:{f.Push(f.Locals[6]);f.Pc=537;continue;}
case 537:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",542);}
case 542:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=545;continue;}
case 545:{f.Locals[7]=f.Pop();f.Pc=547;continue;}
case 547:{f.Push(f.Locals[7]);f.Pc=549;continue;}
case 549:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",552);}
case 552:{f.Pc=f.Pop().Int!=0?573:555;continue;}
case 555:{f.Push(f.Locals[7]);f.Pc=557;continue;}
case 557:{return rt.Call(f,"forge/game/card/Card","isPlaneswalker","()Z","invokevirtual",560);}
case 560:{f.Pc=f.Pop().Int!=0?573:563;continue;}
case 563:{f.Push(f.Locals[7]);f.Pc=565;continue;}
case 565:{return rt.Call(f,"forge/game/card/Card","isBattle","()Z","invokevirtual",568);}
case 568:{f.Pc=f.Pop().Int!=0?573:571;continue;}
case 571:{f.Push(JValue.I(0));f.Pc=572;continue;}
case 572:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 573:{f.Push(f.Locals[7]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",578);}
case 578:{f.Pc=f.Pop().Int!=0?583:581;continue;}
case 581:{f.Push(JValue.I(0));f.Pc=582;continue;}
case 582:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 583:{f.Pc=525;continue;}
case 586:{f.Push(JValue.I(1));f.Pc=587;continue;}
case 587:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8905(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13);}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Target","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Target","Lforge/game/ability/AbilityKey;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",32);}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",45);}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",48);}
case 48:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

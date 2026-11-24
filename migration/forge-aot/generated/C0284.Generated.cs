// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C284{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DestroyAllEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3319,"forge/game/ability/effects/DestroyAllEffect","<init>","()V",1,1,1,new JHandler[]{},M3319));
c.Add(new JMethod(3320,"forge/game/ability/effects/DestroyAllEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,4,new JHandler[]{},M3320));
c.Add(new JMethod(3321,"forge/game/ability/effects/DestroyAllEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,15,9,new JHandler[]{},M3321));
c.Add(new JMethod(3322,"forge/game/ability/effects/DestroyAllEffect","lambda$getStackDescription$0","(Ljava/lang/String;)Ljava/lang/String;",4106,1,4,new JHandler[]{},M3322));
}

internal static JStep M3319(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3320(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?16:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("NoRegen")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("ValidDescription")));f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?98:49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Locals[5]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String(",")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",66);}
case 66:{return rt.Call(f,"java/util/Arrays","stream","([Ljava/lang/Object;)Ljava/util/stream/Stream;","invokestatic",69);}
case 69:{return rt.DynamicCall(f,"forge/game/ability/effects/DestroyAllEffect:3320:69:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",74);}
case 74:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",79);}
case 79:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",82);}
case 82:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",87);}
case 87:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(null));f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("and")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",96);}
case 96:{f.Locals[4]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("Destroy all ")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",104);}
case 104:{f.Push(f.Locals[4]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("(?i)^all ")));f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",113);}
case 113:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",116);}
case 116:{f.Push(JValue.R(rt.String(".")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",121);}
case 121:{f.StackOp("pop");f.Pc=122;continue;}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{f.Pc=f.Pop().Int==0?133:126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String(" They can't be regenerated.")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",132);}
case 132:{f.StackOp("pop");f.Pc=133;continue;}
case 133:{f.Push(f.Locals[2]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",137);}
case 137:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3321(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("NoRegen")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("Optional")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",27);}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("ValidDescription")));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Locals[6]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedPlayer","()Lforge/game/player/Player;","invokevirtual",46);}
case 46:{f.Locals[7]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",56);}
case 56:{f.Locals[8]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[8]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("X")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?87:68;continue;}
case 68:{f.Push(f.Locals[8]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("X")));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("X")));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",79);}
case 79:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",82);}
case 82:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",85);}
case 85:{f.Locals[8]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",95);}
case 95:{f.Locals[9]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[7]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Reference==null?111:102;continue;}
case 102:{f.Push(f.Locals[9]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",109);}
case 109:{f.Locals[9]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[9]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[8]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",119);}
case 119:{f.Locals[9]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("RememberDestroyed")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",127);}
case 127:{f.Locals[10]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[10]);f.Pc=131;continue;}
case 131:{f.Pc=f.Pop().Int==0?138:134;continue;}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",138);}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("RememberAllObjects")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int==0?153:147;continue;}
case 147:{f.Push(f.Locals[3]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[9]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",153);}
case 153:{f.Push(f.Locals[9]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",160);}
case 160:{f.Pc=f.Pop().Int==0?169:163;continue;}
case 163:{f.Push(f.Locals[4]);f.Pc=165;continue;}
case 165:{f.Pc=f.Pop().Int==0?169:168;continue;}
case 168:{return JStep.ReturnVoid;}
case 169:{f.Push(f.Locals[4]);f.Pc=171;continue;}
case 171:{f.Pc=f.Pop().Int==0?208:174;continue;}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",178);}
case 178:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",181);}
case 181:{f.Push(f.Locals[1]);f.Pc=182;continue;}
case 182:{f.Push(JValue.R(null));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",186);}
case 186:{f.Push(JValue.R(rt.String("lblWouldYouLikeDestroy")));f.Pc=188;continue;}
case 188:{f.Push(JValue.I(1));f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=192;continue;}
case 192:{f.StackOp("dup");f.Pc=193;continue;}
case 193:{f.Push(JValue.I(0));f.Pc=194;continue;}
case 194:{f.Push(f.Locals[6]);f.Pc=196;continue;}
case 196:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",200);}
case 200:{f.Push(JValue.R(null));f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",204);}
case 204:{f.Pc=f.Pop().Int!=0?208:207;continue;}
case 207:{return JStep.ReturnVoid;}
case 208:{f.Push(f.Locals[9]);f.Pc=210;continue;}
case 210:{return rt.DynamicCall(f,"forge/game/ability/effects/DestroyAllEffect:3321:210:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",215);}
case 215:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",218);}
case 218:{f.Locals[9]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(f.Locals[5]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[9]);f.Pc=224;continue;}
case 224:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=227;continue;}
case 227:{f.Push(f.Locals[1]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",231);}
case 231:{f.Locals[9]=f.Pop();f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",236);}
case 236:{f.Locals[11]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[11]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[1]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",244);}
case 244:{f.Locals[12]=f.Pop();f.Pc=246;continue;}
case 246:{f.Push(f.Locals[9]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",253);}
case 253:{f.Locals[13]=f.Pop();f.Pc=255;continue;}
case 255:{f.Push(f.Locals[13]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",262);}
case 262:{f.Pc=f.Pop().Int==0?356:265;continue;}
case 265:{f.Push(f.Locals[13]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",272);}
case 272:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=275;continue;}
case 275:{f.Locals[14]=f.Pop();f.Pc=277;continue;}
case 277:{f.Push(f.Locals[1]);f.Pc=278;continue;}
case 278:{f.Push(JValue.R(rt.String("NoRegenValid")));f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",283);}
case 283:{f.Pc=f.Pop().Int==0?304:286;continue;}
case 286:{f.Push(f.Locals[14]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[1]);f.Pc=289;continue;}
case 289:{f.Push(JValue.R(rt.String("NoRegenValid")));f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",294);}
case 294:{f.Push(f.Locals[1]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",298);}
case 298:{f.Push(f.Locals[3]);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[1]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",303);}
case 303:{f.Locals[2]=f.Pop();f.Pc=304;continue;}
case 304:{f.Push(f.Locals[5]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",309);}
case 309:{f.Push(f.Locals[14]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[1]);f.Pc=312;continue;}
case 312:{f.Push(f.Locals[2]);f.Pc=313;continue;}
case 313:{f.Pc=f.Pop().Int!=0?320:316;continue;}
case 316:{f.Push(JValue.I(1));f.Pc=317;continue;}
case 317:{f.Pc=321;continue;}
case 320:{f.Push(JValue.I(0));f.Pc=321;continue;}
case 321:{f.Push(f.Locals[11]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"forge/game/GameAction","destroy","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Z","invokevirtual",326);}
case 326:{f.Pc=f.Pop().Int==0?353:329;continue;}
case 329:{f.Push(f.Locals[10]);f.Pc=331;continue;}
case 331:{f.Pc=f.Pop().Int==0?353:334;continue;}
case 334:{f.Push(f.Locals[3]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[12]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",340);}
case 340:{f.Push(f.Locals[14]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",347);}
case 347:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",353);}
case 353:{f.Pc=255;continue;}
case 356:{f.Push(f.Locals[12]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[5]);f.Pc=360;continue;}
case 360:{f.Push(f.Locals[1]);f.Pc=361;continue;}
case 361:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",364);}
case 364:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3322(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;ZZ)Ljava/lang/String;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C910{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerChangesZone","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10280,"forge/game/trigger/TriggerChangesZone","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10280));
c.Add(new JMethod(10281,"forge/game/trigger/TriggerChangesZone","performTest","(Ljava/util/Map;)Z",17,8,4,new JHandler[]{},M10281));
c.Add(new JMethod(10282,"forge/game/trigger/TriggerChangesZone","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,3,6,new JHandler[]{},M10282));
c.Add(new JMethod(10283,"forge/game/trigger/TriggerChangesZone","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10283));
c.Add(new JMethod(10284,"forge/game/trigger/TriggerChangesZone","correctZones","()V",4,2,3,new JHandler[]{},M10284));
}

internal static JStep M10280(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","correctZones","()V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10281(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Origin")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?62:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Origin")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Push(JValue.R(rt.String("Any")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int!=0?62:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Origin")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Reference!=null?34:32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("Origin")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",40);}
case 40:{f.Push(JValue.R(rt.String(",")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",54);}
case 54:{return rt.Call(f,"org/apache/commons/lang3/ArrayUtils","contains","([Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",57);}
case 57:{f.Pc=f.Pop().Int!=0?62:60;continue;}
case 60:{f.Push(JValue.I(0));f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("Destination")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","hasParam","(Ljava/lang/String;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int==0?113:71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("Destination")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",77);}
case 77:{f.Push(JValue.R(rt.String("Any")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int!=0?113:85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("Destination")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",91);}
case 91:{f.Push(JValue.R(rt.String(",")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",96);}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",105);}
case 105:{return rt.Call(f,"org/apache/commons/lang3/ArrayUtils","contains","([Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",108);}
case 108:{f.Pc=f.Pop().Int!=0?113:111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("ExcludedOrigins")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","hasParam","(Ljava/lang/String;)Z","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Int==0?150:122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String("ExcludedOrigins")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",128);}
case 128:{f.Push(JValue.R(rt.String(",")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",133);}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"));f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",142);}
case 142:{return rt.Call(f,"org/apache/commons/lang3/ArrayUtils","contains","([Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",145);}
case 145:{f.Pc=f.Pop().Int==0?150:148;continue;}
case 148:{f.Push(JValue.I(0));f.Pc=149;continue;}
case 149:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("ExcludedDestinations")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","hasParam","(Ljava/lang/String;)Z","invokevirtual",156);}
case 156:{f.Pc=f.Pop().Int==0?187:159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("ExcludedDestinations")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",165);}
case 165:{f.Push(JValue.R(rt.String(",")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",170);}
case 170:{f.Push(f.Locals[1]);f.Pc=171;continue;}
case 171:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",179);}
case 179:{return rt.Call(f,"org/apache/commons/lang3/ArrayUtils","contains","([Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",182);}
case 182:{f.Pc=f.Pop().Int==0?187:185;continue;}
case 185:{f.Push(JValue.I(0));f.Pc=186;continue;}
case 186:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 187:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=189;continue;}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("Origin")));f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",195);}
case 195:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",198);}
case 198:{f.Pc=f.Pop().Int==0?251:201;continue;}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getActiveZone","()Ljava/util/Set;","invokevirtual",205);}
case 205:{f.Pc=f.Pop().Reference==null?251:208;continue;}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getActiveZone","()Ljava/util/Set;","invokevirtual",212);}
case 212:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",220);}
case 220:{f.Pc=f.Pop().Int==0?251:223;continue;}
case 223:{f.Push(f.Locals[1]);f.Pc=224;continue;}
case 224:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=227;continue;}
case 227:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",232);}
case 232:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=235;continue;}
case 235:{f.Locals[2]=f.Pop();f.Pc=236;continue;}
case 236:{f.Push(f.Locals[2]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[0]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getHostCard","()Lforge/game/card/Card;","invokevirtual",241);}
case 241:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",246);}
case 246:{f.Pc=f.Pop().Int!=0?251:249;continue;}
case 249:{f.Push(JValue.I(0));f.Pc=250;continue;}
case 250:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 251:{f.Push(f.Locals[1]);f.Pc=252;continue;}
case 252:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",260);}
case 260:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=263;continue;}
case 263:{f.Locals[2]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(f.Locals[0]);f.Pc=265;continue;}
case 265:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","hasParam","(Ljava/lang/String;)Z","invokevirtual",270);}
case 270:{f.Pc=f.Pop().Int==0?401:273;continue;}
case 273:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=275;continue;}
case 275:{f.Push(f.Locals[0]);f.Pc=276;continue;}
case 276:{f.Push(JValue.R(rt.String("Origin")));f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",281);}
case 281:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",284);}
case 284:{f.Pc=f.Pop().Int!=0?315:287;continue;}
case 287:{f.Push(JValue.R(rt.String("Graveyard")));f.Pc=289;continue;}
case 289:{f.Push(f.Locals[0]);f.Pc=290;continue;}
case 290:{f.Push(JValue.R(rt.String("Origin")));f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",295);}
case 295:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",298);}
case 298:{f.Pc=f.Pop().Int==0?331:301;continue;}
case 301:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=303;continue;}
case 303:{f.Push(f.Locals[0]);f.Pc=304;continue;}
case 304:{f.Push(JValue.R(rt.String("Destination")));f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",309);}
case 309:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",312);}
case 312:{f.Pc=f.Pop().Int!=0?331:315;continue;}
case 315:{f.Push(f.Locals[1]);f.Pc=316;continue;}
case 316:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=319;continue;}
case 319:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",324);}
case 324:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=327;continue;}
case 327:{f.Locals[2]=f.Pop();f.Pc=328;continue;}
case 328:{f.Pc=389;continue;}
case 331:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=333;continue;}
case 333:{f.Push(f.Locals[1]);f.Pc=334;continue;}
case 334:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",342);}
case 342:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",345);}
case 345:{f.Pc=f.Pop().Int==0?389:348;continue;}
case 348:{f.Push(f.Locals[2]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",352);}
case 352:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",358);}
case 358:{f.Push(JValue.R(null));f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/zone/PlayerZone","getCardsAddedThisTurn","(Lforge/game/zone/ZoneType;)Ljava/util/List;","invokevirtual",362);}
case 362:{f.Locals[3]=f.Pop();f.Pc=363;continue;}
case 363:{f.Push(f.Locals[3]);f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/card/CardPredicates","compareByGameTimestamp","()Ljava/util/Comparator;","invokestatic",367);}
case 367:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",372);}
case 372:{f.Push(f.Locals[3]);f.Pc=373;continue;}
case 373:{f.Push(f.Locals[3]);f.Pc=374;continue;}
case 374:{f.Push(f.Locals[2]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"java/util/List","lastIndexOf","(Ljava/lang/Object;)I","invokeinterface",380);}
case 380:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",385);}
case 385:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=388;continue;}
case 388:{f.Locals[2]=f.Pop();f.Pc=389;continue;}
case 389:{f.Push(f.Locals[0]);f.Pc=390;continue;}
case 390:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=392;continue;}
case 392:{f.Push(f.Locals[2]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",396);}
case 396:{f.Pc=f.Pop().Int!=0?401:399;continue;}
case 399:{f.Push(JValue.I(0));f.Pc=400;continue;}
case 400:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 401:{f.Push(f.Locals[0]);f.Pc=402;continue;}
case 402:{f.Push(JValue.R(rt.String("CheckOnTriggeredCard")));f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","hasParam","(Ljava/lang/String;)Z","invokevirtual",407);}
case 407:{f.Pc=f.Pop().Int==0?484:410;continue;}
case 410:{f.Push(f.Locals[0]);f.Pc=411;continue;}
case 411:{f.Push(JValue.R(rt.String("CheckOnTriggeredCard")));f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",416);}
case 416:{f.Push(JValue.R(rt.String(" ")));f.Pc=418;continue;}
case 418:{f.Push(JValue.I(2));f.Pc=419;continue;}
case 419:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",422);}
case 422:{f.Locals[3]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(f.Locals[3]);f.Pc=424;continue;}
case 424:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=425;continue;}
case 425:{f.Push(JValue.I(2));f.Pc=426;continue;}
case 426:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?434:429;continue;}
case 429:{f.Push(JValue.R(rt.String("GE1")));f.Pc=431;continue;}
case 431:{f.Pc=437;continue;}
case 434:{f.Push(f.Locals[3]);f.Pc=435;continue;}
case 435:{f.Push(JValue.I(1));f.Pc=436;continue;}
case 436:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=437;continue;}
case 437:{f.Locals[4]=f.Pop();f.Pc=439;continue;}
case 439:{f.Push(f.Locals[0]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getHostCard","()Lforge/game/card/Card;","invokevirtual",443);}
case 443:{f.Push(f.Locals[4]);f.Pc=445;continue;}
case 445:{f.Push(JValue.I(2));f.Pc=446;continue;}
case 446:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",449);}
case 449:{f.Push(f.Locals[0]);f.Pc=450;continue;}
case 450:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",453);}
case 453:{f.Locals[5]=f.Pop();f.Pc=455;continue;}
case 455:{f.Push(f.Locals[2]);f.Pc=456;continue;}
case 456:{f.Push(f.Locals[3]);f.Pc=457;continue;}
case 457:{f.Push(JValue.I(0));f.Pc=458;continue;}
case 458:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=459;continue;}
case 459:{f.Push(f.Locals[0]);f.Pc=460;continue;}
case 460:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",463);}
case 463:{f.Locals[6]=f.Pop();f.Pc=465;continue;}
case 465:{f.Push(f.Locals[6]);f.Pc=467;continue;}
case 467:{f.Push(f.Locals[4]);f.Pc=469;continue;}
case 469:{f.Push(JValue.I(0));f.Pc=470;continue;}
case 470:{f.Push(JValue.I(2));f.Pc=471;continue;}
case 471:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",474);}
case 474:{f.Push(f.Locals[5]);f.Pc=476;continue;}
case 476:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",479);}
case 479:{f.Pc=f.Pop().Int!=0?484:482;continue;}
case 482:{f.Push(JValue.I(0));f.Pc=483;continue;}
case 483:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 484:{f.Push(f.Locals[0]);f.Pc=485;continue;}
case 485:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=487;continue;}
case 487:{f.Push(f.Locals[1]);f.Pc=488;continue;}
case 488:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=491;continue;}
case 491:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",496);}
case 496:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",499);}
case 499:{f.Pc=f.Pop().Int!=0?504:502;continue;}
case 502:{f.Push(JValue.I(0));f.Pc=503;continue;}
case 503:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 504:{f.Push(f.Locals[0]);f.Pc=505;continue;}
case 505:{f.Push(JValue.R(rt.String("Fizzle")));f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","hasParam","(Ljava/lang/String;)Z","invokevirtual",510);}
case 510:{f.Pc=f.Pop().Int==0?560:513;continue;}
case 513:{f.Push(f.Locals[1]);f.Pc=514;continue;}
case 514:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Fizzle","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Fizzle","Lforge/game/ability/AbilityKey;"));f.Pc=517;continue;}
case 517:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",522);}
case 522:{f.Pc=f.Pop().Int!=0?527:525;continue;}
case 525:{f.Push(JValue.I(0));f.Pc=526;continue;}
case 526:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 527:{f.Push(f.Locals[1]);f.Pc=528;continue;}
case 528:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Fizzle","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Fizzle","Lforge/game/ability/AbilityKey;"));f.Pc=531;continue;}
case 531:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",536);}
case 536:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=539;continue;}
case 539:{f.Locals[3]=f.Pop();f.Pc=540;continue;}
case 540:{f.Push(JValue.R(rt.String("True")));f.Pc=542;continue;}
case 542:{f.Push(f.Locals[0]);f.Pc=543;continue;}
case 543:{f.Push(JValue.R(rt.String("Fizzle")));f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",548);}
case 548:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",551);}
case 551:{f.Push(f.Locals[3]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",555);}
case 555:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?560:558;continue;}
case 558:{f.Push(JValue.I(0));f.Pc=559;continue;}
case 559:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 560:{f.Push(f.Locals[0]);f.Pc=561;continue;}
case 561:{f.Push(JValue.R(rt.String("NotThisAbility")));f.Pc=563;continue;}
case 563:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","hasParam","(Ljava/lang/String;)Z","invokevirtual",566);}
case 566:{f.Pc=f.Pop().Int==0?614:569;continue;}
case 569:{f.Push(f.Locals[1]);f.Pc=570;continue;}
case 570:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=573;continue;}
case 573:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",578);}
case 578:{f.Pc=f.Pop().Int==0?614:581;continue;}
case 581:{f.Push(f.Locals[1]);f.Pc=582;continue;}
case 582:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=585;continue;}
case 585:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",590);}
case 590:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=593;continue;}
case 593:{f.Locals[3]=f.Pop();f.Pc=594;continue;}
case 594:{f.Push(f.Locals[3]);f.Pc=595;continue;}
case 595:{f.Pc=f.Pop().Reference==null?614:598;continue;}
case 598:{f.Push(f.Locals[0]);f.Pc=599;continue;}
case 599:{f.Push(f.Locals[3]);f.Pc=600;continue;}
case 600:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",603);}
case 603:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",606);}
case 606:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","equals","(Ljava/lang/Object;)Z","invokevirtual",609);}
case 609:{f.Pc=f.Pop().Int==0?614:612;continue;}
case 612:{f.Push(JValue.I(0));f.Pc=613;continue;}
case 613:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 614:{f.Push(f.Locals[0]);f.Pc=615;continue;}
case 615:{f.Push(JValue.R(rt.String("ConditionYouCastThisTurn")));f.Pc=617;continue;}
case 617:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","hasParam","(Ljava/lang/String;)Z","invokevirtual",620);}
case 620:{f.Pc=f.Pop().Int==0?708:623;continue;}
case 623:{f.Push(f.Locals[0]);f.Pc=624;continue;}
case 624:{f.Push(JValue.R(rt.String("ConditionYouCastThisTurn")));f.Pc=626;continue;}
case 626:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",629);}
case 629:{f.Locals[3]=f.Pop();f.Pc=630;continue;}
case 630:{f.Push(f.Locals[0]);f.Pc=631;continue;}
case 631:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getHostCard","()Lforge/game/card/Card;","invokevirtual",634);}
case 634:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",637);}
case 637:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",640);}
case 640:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellCardsCastThisTurn","()Ljava/util/List;","invokevirtual",643);}
case 643:{f.Locals[4]=f.Pop();f.Pc=645;continue;}
case 645:{f.Push(f.Locals[4]);f.Pc=647;continue;}
case 647:{f.Push(f.Locals[0]);f.Pc=648;continue;}
case 648:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getHostCard","()Lforge/game/card/Card;","invokevirtual",651);}
case 651:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",654);}
case 654:{return rt.Call(f,"forge/game/card/CardLists","filterControlledByAsList","(Ljava/lang/Iterable;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",657);}
case 657:{f.Locals[4]=f.Pop();f.Pc=659;continue;}
case 659:{f.Push(f.Locals[0]);f.Pc=660;continue;}
case 660:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getHostCard","()Lforge/game/card/Card;","invokevirtual",663);}
case 663:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",666);}
case 666:{f.Locals[5]=f.Pop();f.Pc=668;continue;}
case 668:{f.Push(f.Locals[4]);f.Pc=670;continue;}
case 670:{f.Push(f.Locals[5]);f.Pc=672;continue;}
case 672:{return rt.Call(f,"java/util/function/Predicate","isEqual","(Ljava/lang/Object;)Ljava/util/function/Predicate;","invokestatic",675);}
case 675:{return rt.Call(f,"forge/game/card/CardPredicates","castSA","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",678);}
case 678:{return rt.Call(f,"forge/util/IterableUtil","indexOf","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",681);}
case 681:{f.Locals[6]=f.Pop();f.Pc=683;continue;}
case 683:{f.Push(f.Locals[3]);f.Pc=684;continue;}
case 684:{f.Push(JValue.I(2));f.Pc=685;continue;}
case 685:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",688);}
case 688:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",691);}
case 691:{f.Locals[7]=f.Pop();f.Pc=693;continue;}
case 693:{f.Push(f.Locals[6]);f.Pc=695;continue;}
case 695:{f.Push(JValue.I(1));f.Pc=696;continue;}
case 696:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=697;continue;}
case 697:{f.Push(f.Locals[3]);f.Pc=698;continue;}
case 698:{f.Push(f.Locals[7]);f.Pc=700;continue;}
case 700:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",703);}
case 703:{f.Pc=f.Pop().Int!=0?708:706;continue;}
case 706:{f.Push(JValue.I(0));f.Pc=707;continue;}
case 707:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 708:{f.Push(JValue.I(1));f.Pc=709;continue;}
case 709:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10282(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("Origin")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?55:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",27);}
case 27:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",32);}
case 32:{f.StackOp("pop");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","NewCard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","NewCard","Lforge/game/ability/AbilityKey;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",46);}
case 46:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Pc=76;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(2));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=61;continue;}
case 61:{f.StackOp("dup");f.Pc=62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=66;continue;}
case 66:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{f.Push(JValue.I(1));f.Pc=69;continue;}
case 69:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=72;continue;}
case 72:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/ability/AbilityKey","copyKeys","(Ljava/util/Map;Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokestatic",76);}
case 76:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10283(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",12);}
case 12:{f.Push(JValue.R(rt.String("lblZoneChanger")));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",22);}
case 22:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",25);}
case 25:{f.Push(JValue.R(rt.String(": ")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",38);}
case 38:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",46);}
case 46:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10284(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerChangesZone","validHostZones","Ljava/util/EnumSet;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Reference!=null?19:18;continue;}
case 18:{return JStep.ReturnVoid;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","hasParam","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int!=0?29:28;continue;}
case 28:{return JStep.ReturnVoid;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Origin")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","hasParam","(Ljava/lang/String;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?80:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("Origin")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(JValue.R(rt.String(",")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",49);}
case 49:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/zone/ZoneType","toString","()Ljava/lang/String;","invokevirtual",55);}
case 55:{return rt.Call(f,"org/apache/commons/lang3/ArrayUtils","contains","([Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",58);}
case 58:{f.Locals[1]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Int==0?80:63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","isStatic","()Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int!=0?80:70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",77);}
case 77:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",80);}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Push(JValue.R(rt.String("Self")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?136:95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("Origin")));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","hasParam","(Ljava/lang/String;)Z","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Int==0?118:104;continue;}
case 104:{f.Push(JValue.R(rt.String("Any")));f.Pc=106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("Origin")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",112);}
case 112:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int==0?136:118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.String("Destination")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",125);}
case 125:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",128);}
case 128:{f.Push(JValue.R(rt.ClassObject("forge/game/zone/ZoneType")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"com/google/common/collect/Sets","newEnumSet","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",133);}
case 133:{return rt.Call(f,"forge/game/trigger/TriggerChangesZone","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",136);}
case 136:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

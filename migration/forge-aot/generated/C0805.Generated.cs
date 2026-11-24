// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C805{
internal static JClass Build(){var c=new JClass("forge/game/spellability/SpellAbilityRestriction","forge/game/spellability/SpellAbilityVariables",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9529,"forge/game/spellability/SpellAbilityRestriction","<init>","()V",1,1,1,new JHandler[]{},M9529));
c.Add(new JMethod(9530,"forge/game/spellability/SpellAbilityRestriction","setRestrictions","(Ljava/util/Map;)V",17,3,4,new JHandler[]{},M9530));
c.Add(new JMethod(9531,"forge/game/spellability/SpellAbilityRestriction","checkZoneRestrictions","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z",17,7,5,new JHandler[]{},M9531));
c.Add(new JMethod(9532,"forge/game/spellability/SpellAbilityRestriction","checkTimingRestrictions","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z",17,5,2,new JHandler[]{},M9532));
c.Add(new JMethod(9533,"forge/game/spellability/SpellAbilityRestriction","checkActivatorRestrictions","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z",17,5,5,new JHandler[]{},M9533));
c.Add(new JMethod(9534,"forge/game/spellability/SpellAbilityRestriction","checkOtherRestrictions","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z",17,10,6,new JHandler[]{},M9534));
c.Add(new JMethod(9535,"forge/game/spellability/SpellAbilityRestriction","canPlay","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z",17,5,4,new JHandler[]{},M9535));
c.Add(new JMethod(9536,"forge/game/spellability/SpellAbilityRestriction","lambda$checkOtherRestrictions$1","(Lforge/game/Game;Lforge/game/GameType;)Z",4106,2,2,new JHandler[]{},M9536));
c.Add(new JMethod(9537,"forge/game/spellability/SpellAbilityRestriction","lambda$checkZoneRestrictions$0","(Lforge/game/card/CardPlayOption;)Z",4106,1,1,new JHandler[]{},M9537));
}

internal static JStep M9529(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbilityVariables","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9530(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Activation")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",8);}
case 8:{f.Pc=f.Pop().Int==0?107:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Activation")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",19);}
case 19:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=22;continue;}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Threshold")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?37:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setThreshold","(Z)V","invokevirtual",37);}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Metalcraft")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?51:46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setMetalcraft","(Z)V","invokevirtual",51);}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Delirium")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?65:60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setDelirium","(Z)V","invokevirtual",65);}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("Hellbent")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int==0?79:74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setHellbent","(Z)V","invokevirtual",79);}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Blessing")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?93:88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setBlessing","(Z)V","invokevirtual",93);}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("Solved")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int==0?107:102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setSolved","(Z)V","invokevirtual",107);}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("ActivationZone")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",115);}
case 115:{f.Pc=f.Pop().Int==0?136:118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.String("ActivationZone")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",127);}
case 127:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",133);}
case 133:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",136);}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("SorcerySpeed")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",144);}
case 144:{f.Pc=f.Pop().Int==0?152:147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(JValue.I(1));f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setSorcerySpeed","(Z)V","invokevirtual",152);}
case 152:{f.Push(f.Locals[1]);f.Pc=153;continue;}
case 153:{f.Push(JValue.R(rt.String("InstantSpeed")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",160);}
case 160:{f.Pc=f.Pop().Int==0?168:163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{f.Push(JValue.I(1));f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setInstantSpeed","(Z)V","invokevirtual",168);}
case 168:{f.Push(f.Locals[1]);f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String("PlayerTurn")));f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",176);}
case 176:{f.Pc=f.Pop().Int==0?184:179;continue;}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{f.Push(JValue.I(1));f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setPlayerTurn","(Z)V","invokevirtual",184);}
case 184:{f.Push(f.Locals[1]);f.Pc=185;continue;}
case 185:{f.Push(JValue.R(rt.String("OpponentTurn")));f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",192);}
case 192:{f.Pc=f.Pop().Int==0?200:195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(JValue.I(1));f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setOpponentTurn","(Z)V","invokevirtual",200);}
case 200:{f.Push(f.Locals[1]);f.Pc=201;continue;}
case 201:{f.Push(JValue.R(rt.String("Activator")));f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",208);}
case 208:{f.Pc=f.Pop().Int==0?226:211;continue;}
case 211:{f.Push(f.Locals[0]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[1]);f.Pc=213;continue;}
case 213:{f.Push(JValue.R(rt.String("Activator")));f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",220);}
case 220:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setActivator","(Ljava/lang/String;)V","invokevirtual",226);}
case 226:{f.Push(f.Locals[1]);f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String("ActivationLimit")));f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",234);}
case 234:{f.Pc=f.Pop().Int==0?252:237;continue;}
case 237:{f.Push(f.Locals[0]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[1]);f.Pc=239;continue;}
case 239:{f.Push(JValue.R(rt.String("ActivationLimit")));f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",246);}
case 246:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setLimitToCheck","(Ljava/lang/String;)V","invokevirtual",252);}
case 252:{f.Push(f.Locals[1]);f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.String("GameActivationLimit")));f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",260);}
case 260:{f.Pc=f.Pop().Int==0?278:263;continue;}
case 263:{f.Push(f.Locals[0]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[1]);f.Pc=265;continue;}
case 265:{f.Push(JValue.R(rt.String("GameActivationLimit")));f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",272);}
case 272:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setGameLimitToCheck","(Ljava/lang/String;)V","invokevirtual",278);}
case 278:{f.Push(f.Locals[1]);f.Pc=279;continue;}
case 279:{f.Push(JValue.R(rt.String("ActivationPhases")));f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",286);}
case 286:{f.Pc=f.Pop().Int==0?307:289;continue;}
case 289:{f.Push(f.Locals[0]);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[1]);f.Pc=291;continue;}
case 291:{f.Push(JValue.R(rt.String("ActivationPhases")));f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",298);}
case 298:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/phase/PhaseType","parseRange","(Ljava/lang/String;)Ljava/util/Set;","invokestatic",304);}
case 304:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setPhases","(Ljava/util/Set;)V","invokevirtual",307);}
case 307:{f.Push(f.Locals[1]);f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("ActivationFirstCombat")));f.Pc=310;continue;}
case 310:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",315);}
case 315:{f.Pc=f.Pop().Int==0?324:318;continue;}
case 318:{f.Push(f.Locals[0]);f.Pc=319;continue;}
case 319:{f.Push(JValue.I(1));f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setFirstCombatOnly","(Z)Z","invokevirtual",323);}
case 323:{f.StackOp("pop");f.Pc=324;continue;}
case 324:{f.Push(f.Locals[1]);f.Pc=325;continue;}
case 325:{f.Push(JValue.R(rt.String("ActivationAfterBlockers")));f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",332);}
case 332:{f.Pc=f.Pop().Int==0?341:335;continue;}
case 335:{f.Push(f.Locals[0]);f.Pc=336;continue;}
case 336:{f.Push(JValue.I(1));f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setAfterBlockersOnly","(Z)Z","invokevirtual",340);}
case 340:{f.StackOp("pop");f.Pc=341;continue;}
case 341:{f.Push(f.Locals[1]);f.Pc=342;continue;}
case 342:{f.Push(JValue.R(rt.String("ActivationGameTypes")));f.Pc=344;continue;}
case 344:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",349);}
case 349:{f.Pc=f.Pop().Int==0?370:352;continue;}
case 352:{f.Push(f.Locals[0]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[1]);f.Pc=354;continue;}
case 354:{f.Push(JValue.R(rt.String("ActivationGameTypes")));f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",361);}
case 361:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/GameType","listValueOf","(Ljava/lang/String;)Ljava/util/Set;","invokestatic",367);}
case 367:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setGameTypes","(Ljava/util/Set;)V","invokevirtual",370);}
case 370:{f.Push(f.Locals[1]);f.Pc=371;continue;}
case 371:{f.Push(JValue.R(rt.String("IsPresent")));f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",378);}
case 378:{f.Pc=f.Pop().Int==0?451:381;continue;}
case 381:{f.Push(f.Locals[0]);f.Pc=382;continue;}
case 382:{f.Push(f.Locals[1]);f.Pc=383;continue;}
case 383:{f.Push(JValue.R(rt.String("IsPresent")));f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",390);}
case 390:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setIsPresent","(Ljava/lang/String;)V","invokevirtual",396);}
case 396:{f.Push(f.Locals[1]);f.Pc=397;continue;}
case 397:{f.Push(JValue.R(rt.String("PresentCompare")));f.Pc=399;continue;}
case 399:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",404);}
case 404:{f.Pc=f.Pop().Int==0?422:407;continue;}
case 407:{f.Push(f.Locals[0]);f.Pc=408;continue;}
case 408:{f.Push(f.Locals[1]);f.Pc=409;continue;}
case 409:{f.Push(JValue.R(rt.String("PresentCompare")));f.Pc=411;continue;}
case 411:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",416);}
case 416:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setPresentCompare","(Ljava/lang/String;)V","invokevirtual",422);}
case 422:{f.Push(f.Locals[1]);f.Pc=423;continue;}
case 423:{f.Push(JValue.R(rt.String("PresentZone")));f.Pc=425;continue;}
case 425:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",430);}
case 430:{f.Pc=f.Pop().Int==0?451:433;continue;}
case 433:{f.Push(f.Locals[0]);f.Pc=434;continue;}
case 434:{f.Push(f.Locals[1]);f.Pc=435;continue;}
case 435:{f.Push(JValue.R(rt.String("PresentZone")));f.Pc=437;continue;}
case 437:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",442);}
case 442:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",448);}
case 448:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setPresentZones","(Ljava/util/List;)V","invokevirtual",451);}
case 451:{f.Push(f.Locals[1]);f.Pc=452;continue;}
case 452:{f.Push(JValue.R(rt.String("PresentDefined")));f.Pc=454;continue;}
case 454:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",459);}
case 459:{f.Pc=f.Pop().Int==0?477:462;continue;}
case 462:{f.Push(f.Locals[0]);f.Pc=463;continue;}
case 463:{f.Push(f.Locals[1]);f.Pc=464;continue;}
case 464:{f.Push(JValue.R(rt.String("PresentDefined")));f.Pc=466;continue;}
case 466:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",471);}
case 471:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setPresentDefined","(Ljava/lang/String;)V","invokevirtual",477);}
case 477:{f.Push(f.Locals[1]);f.Pc=478;continue;}
case 478:{f.Push(JValue.R(rt.String("ActivationLifeTotal")));f.Pc=480;continue;}
case 480:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",485);}
case 485:{f.Pc=f.Pop().Int==0?529:488;continue;}
case 488:{f.Push(f.Locals[0]);f.Pc=489;continue;}
case 489:{f.Push(f.Locals[1]);f.Pc=490;continue;}
case 490:{f.Push(JValue.R(rt.String("ActivationLifeTotal")));f.Pc=492;continue;}
case 492:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",497);}
case 497:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=500;continue;}
case 500:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setLifeTotal","(Ljava/lang/String;)V","invokevirtual",503);}
case 503:{f.Push(f.Locals[1]);f.Pc=504;continue;}
case 504:{f.Push(JValue.R(rt.String("ActivationLifeAmount")));f.Pc=506;continue;}
case 506:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",511);}
case 511:{f.Pc=f.Pop().Int==0?529:514;continue;}
case 514:{f.Push(f.Locals[0]);f.Pc=515;continue;}
case 515:{f.Push(f.Locals[1]);f.Pc=516;continue;}
case 516:{f.Push(JValue.R(rt.String("ActivationLifeAmount")));f.Pc=518;continue;}
case 518:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",523);}
case 523:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=526;continue;}
case 526:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setLifeAmount","(Ljava/lang/String;)V","invokevirtual",529);}
case 529:{f.Push(f.Locals[1]);f.Pc=530;continue;}
case 530:{f.Push(JValue.R(rt.String("CheckSVar")));f.Pc=532;continue;}
case 532:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",537);}
case 537:{f.Pc=f.Pop().Int==0?555:540;continue;}
case 540:{f.Push(f.Locals[0]);f.Pc=541;continue;}
case 541:{f.Push(f.Locals[1]);f.Pc=542;continue;}
case 542:{f.Push(JValue.R(rt.String("CheckSVar")));f.Pc=544;continue;}
case 544:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",549);}
case 549:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=552;continue;}
case 552:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setSvarToCheck","(Ljava/lang/String;)V","invokevirtual",555);}
case 555:{f.Push(f.Locals[1]);f.Pc=556;continue;}
case 556:{f.Push(JValue.R(rt.String("SVarCompare")));f.Pc=558;continue;}
case 558:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",563);}
case 563:{f.Pc=f.Pop().Int==0?605:566;continue;}
case 566:{f.Push(f.Locals[0]);f.Pc=567;continue;}
case 567:{f.Push(f.Locals[1]);f.Pc=568;continue;}
case 568:{f.Push(JValue.R(rt.String("SVarCompare")));f.Pc=570;continue;}
case 570:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",575);}
case 575:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=578;continue;}
case 578:{f.Push(JValue.I(0));f.Pc=579;continue;}
case 579:{f.Push(JValue.I(2));f.Pc=580;continue;}
case 580:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",583);}
case 583:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setSvarOperator","(Ljava/lang/String;)V","invokevirtual",586);}
case 586:{f.Push(f.Locals[0]);f.Pc=587;continue;}
case 587:{f.Push(f.Locals[1]);f.Pc=588;continue;}
case 588:{f.Push(JValue.R(rt.String("SVarCompare")));f.Pc=590;continue;}
case 590:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",595);}
case 595:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=598;continue;}
case 598:{f.Push(JValue.I(2));f.Pc=599;continue;}
case 599:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",602);}
case 602:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setSvarOperand","(Ljava/lang/String;)V","invokevirtual",605);}
case 605:{f.Push(f.Locals[1]);f.Pc=606;continue;}
case 606:{f.Push(JValue.R(rt.String("ClassLevel")));f.Pc=608;continue;}
case 608:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",613);}
case 613:{f.Pc=f.Pop().Int==0?655:616;continue;}
case 616:{f.Push(f.Locals[0]);f.Pc=617;continue;}
case 617:{f.Push(f.Locals[1]);f.Pc=618;continue;}
case 618:{f.Push(JValue.R(rt.String("ClassLevel")));f.Pc=620;continue;}
case 620:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",625);}
case 625:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=628;continue;}
case 628:{f.Push(JValue.I(0));f.Pc=629;continue;}
case 629:{f.Push(JValue.I(2));f.Pc=630;continue;}
case 630:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",633);}
case 633:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setClassLevelOperator","(Ljava/lang/String;)V","invokevirtual",636);}
case 636:{f.Push(f.Locals[0]);f.Pc=637;continue;}
case 637:{f.Push(f.Locals[1]);f.Pc=638;continue;}
case 638:{f.Push(JValue.R(rt.String("ClassLevel")));f.Pc=640;continue;}
case 640:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",645);}
case 645:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=648;continue;}
case 648:{f.Push(JValue.I(2));f.Pc=649;continue;}
case 649:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",652);}
case 652:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setClassLevel","(Ljava/lang/String;)V","invokevirtual",655);}
case 655:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9531(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getLastKnownZone","()Lforge/game/zone/Zone;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference==null?35:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Reference==null?35:23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int!=0?375:35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("AdditionalActivationZone")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?68:44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Reference==null?68:49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("AdditionalActivationZone")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",57);}
case 57:{return rt.Call(f,"forge/game/zone/ZoneType","valueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",60);}
case 60:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?68:66;continue;}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?114:75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{f.Pc=f.Pop().Reference==null?94:80;continue;}
case 80:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",88);}
case 88:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int!=0?114:94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Reference==null?116:101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",105);}
case 105:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int!=0?116:114;continue;}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{f.Pc=f.Pop().Reference==null?134:121;continue;}
case 121:{f.Push(f.Locals[4]);f.Pc=123;continue;}
case 123:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",129);}
case 129:{f.Pc=f.Pop().Int==0?134:132;continue;}
case 132:{f.Push(JValue.I(0));f.Pc=133;continue;}
case 133:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int==0?373:141;continue;}
case 141:{f.Push(f.Locals[2]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMayPlayOption","()Lforge/game/card/CardPlayOption;","invokevirtual",145);}
case 145:{f.Locals[5]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[5]);f.Pc=149;continue;}
case 149:{f.Pc=f.Pop().Reference==null?159:152;continue;}
case 152:{f.Push(f.Locals[2]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCastFromPlayEffect","()Z","invokevirtual",156);}
case 156:{f.Pc=f.Pop().Int==0?189:159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",163);}
case 163:{f.Pc=f.Pop().Reference==null?183:166;continue;}
case 166:{f.Push(f.Locals[4]);f.Pc=168;continue;}
case 168:{f.Pc=f.Pop().Reference==null?187:171;continue;}
case 171:{f.Push(f.Locals[4]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",177);}
case 177:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",180);}
case 180:{f.Pc=f.Pop().Int==0?187:183;continue;}
case 183:{f.Push(JValue.I(1));f.Pc=184;continue;}
case 184:{f.Pc=188;continue;}
case 187:{f.Push(JValue.I(0));f.Pc=188;continue;}
case 188:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 189:{f.Push(f.Locals[5]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[3]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/card/CardPlayOption","appliesTo","(Lforge/game/player/Player;)Z","invokevirtual",195);}
case 195:{f.Pc=f.Pop().Int==0?373:198;continue;}
case 198:{f.Push(f.Locals[5]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/card/CardPlayOption","grantsZonePermissions","()Z","invokevirtual",203);}
case 203:{f.Pc=f.Pop().Int!=0?258:206;continue;}
case 206:{f.Push(f.Locals[4]);f.Pc=208;continue;}
case 208:{f.Pc=f.Pop().Reference==null?258:211;continue;}
case 211:{f.Push(f.Locals[4]);f.Pc=213;continue;}
case 213:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int==0?230:222;continue;}
case 222:{f.Push(f.Locals[3]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[1]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",227);}
case 227:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?258:230;continue;}
case 230:{f.Push(f.Locals[2]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",234);}
case 234:{f.Push(f.Locals[3]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/card/Card","mayPlay","(Lforge/game/player/Player;)Ljava/util/List;","invokevirtual",238);}
case 238:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",243);}
case 243:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbilityRestriction:9531:243:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",248);}
case 248:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",253);}
case 253:{f.Pc=f.Pop().Int!=0?258:256;continue;}
case 256:{f.Push(JValue.I(0));f.Pc=257;continue;}
case 257:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 258:{f.Push(f.Locals[2]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMayPlay","()Lforge/game/staticability/StaticAbility;","invokevirtual",262);}
case 262:{return rt.Call(f,"forge/game/staticability/StaticAbility","getMapParams","()Ljava/util/Map;","invokevirtual",265);}
case 265:{f.Locals[6]=f.Pop();f.Pc=267;continue;}
case 267:{f.Push(f.Locals[6]);f.Pc=269;continue;}
case 269:{f.Push(JValue.R(rt.String("Affected")));f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",277);}
case 277:{f.Pc=f.Pop().Int==0?319:280;continue;}
case 280:{f.Push(f.Locals[1]);f.Pc=281;continue;}
case 281:{f.Push(f.Locals[6]);f.Pc=283;continue;}
case 283:{f.Push(JValue.R(rt.String("Affected")));f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",291);}
case 291:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=294;continue;}
case 294:{f.Push(JValue.R(rt.String(",")));f.Pc=297;continue;}
case 297:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",300);}
case 300:{f.Push(f.Locals[3]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[5]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/card/CardPlayOption","getHost","()Lforge/game/card/Card;","invokevirtual",306);}
case 306:{f.Push(f.Locals[5]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/card/CardPlayOption","getAbility","()Lforge/game/staticability/StaticAbility;","invokevirtual",311);}
case 311:{return rt.Call(f,"forge/game/card/Card","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",314);}
case 314:{f.Pc=f.Pop().Int!=0?319:317;continue;}
case 317:{f.Push(JValue.I(0));f.Pc=318;continue;}
case 318:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 319:{f.Push(f.Locals[6]);f.Pc=321;continue;}
case 321:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=324;continue;}
case 324:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",329);}
case 329:{f.Pc=f.Pop().Int==0?371:332;continue;}
case 332:{f.Push(f.Locals[2]);f.Pc=333;continue;}
case 333:{f.Push(f.Locals[6]);f.Pc=335;continue;}
case 335:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=338;continue;}
case 338:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",343);}
case 343:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=346;continue;}
case 346:{f.Push(JValue.R(rt.String(",")));f.Pc=349;continue;}
case 349:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",352);}
case 352:{f.Push(f.Locals[3]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[5]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/card/CardPlayOption","getHost","()Lforge/game/card/Card;","invokevirtual",358);}
case 358:{f.Push(f.Locals[5]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/card/CardPlayOption","getAbility","()Lforge/game/staticability/StaticAbility;","invokevirtual",363);}
case 363:{return rt.Call(f,"forge/game/spellability/SpellAbility","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",366);}
case 366:{f.Pc=f.Pop().Int!=0?371:369;continue;}
case 369:{f.Push(JValue.I(0));f.Pc=370;continue;}
case 370:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 371:{f.Push(JValue.I(1));f.Pc=372;continue;}
case 372:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 373:{f.Push(JValue.I(0));f.Pc=374;continue;}
case 374:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 375:{f.Push(f.Locals[2]);f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",379);}
case 379:{f.Pc=f.Pop().Int==0?412:382;continue;}
case 382:{f.Push(f.Locals[3]);f.Pc=383;continue;}
case 383:{f.Push(f.Locals[1]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",387);}
case 387:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?412:390;continue;}
case 390:{f.Push(f.Locals[0]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",394);}
case 394:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=397;continue;}
case 397:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?410:400;continue;}
case 400:{f.Push(f.Locals[3]);f.Pc=401;continue;}
case 401:{f.Push(JValue.R(rt.String("Shaman's Trance")));f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/player/Player","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",407);}
case 407:{f.Pc=f.Pop().Int!=0?412:410;continue;}
case 410:{f.Push(JValue.I(0));f.Pc=411;continue;}
case 411:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 412:{f.Push(JValue.I(1));f.Pc=413;continue;}
case 413:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9532(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isPlayerTurn","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?32:18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",23);}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?32:30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isOpponentTurn","()Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?56:39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",47);}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int!=0?56:54;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getPhases","()Ljava/util/Set;","invokevirtual",60);}
case 60:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int<=0?90:68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getPhases","()Ljava/util/Set;","invokevirtual",72);}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",77);}
case 77:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",80);}
case 80:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",85);}
case 85:{f.Pc=f.Pop().Int!=0?90:88;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getFirstCombatOnly","()Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?126:97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",102);}
case 102:{return rt.Call(f,"forge/game/phase/PhaseHandler","getNumCombat","()I","invokevirtual",105);}
case 105:{f.Push(f.Locals[4]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",110);}
case 110:{return rt.Call(f,"forge/game/phase/PhaseHandler","inCombat","()Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?120:116;continue;}
case 116:{f.Push(JValue.I(1));f.Pc=117;continue;}
case 117:{f.Pc=121;continue;}
case 120:{f.Push(JValue.I(0));f.Pc=121;continue;}
case 121:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?126:124;continue;}
case 124:{f.Push(JValue.I(0));f.Pc=125;continue;}
case 125:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getAfterBlockersOnly","()Z","invokevirtual",130);}
case 130:{f.Pc=f.Pop().Int==0?146:133;continue;}
case 133:{f.Push(f.Locals[4]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",138);}
case 138:{return rt.Call(f,"forge/game/phase/PhaseHandler","skippedDeclareBlockers","()Z","invokevirtual",141);}
case 141:{f.Pc=f.Pop().Int==0?146:144;continue;}
case 144:{f.Push(JValue.I(0));f.Pc=145;continue;}
case 145:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 146:{f.Push(f.Locals[2]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSneak","()Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?169:153;continue;}
case 153:{f.Push(f.Locals[4]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",158);}
case 158:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/phase/PhaseHandler","is","(Lforge/game/phase/PhaseType;)Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int!=0?169:167;continue;}
case 167:{f.Push(JValue.I(0));f.Pc=168;continue;}
case 168:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 169:{f.Push(JValue.I(1));f.Pc=170;continue;}
case 170:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9533(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCastFromPlayEffect","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?14:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?47:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMayPlay","()Lforge/game/staticability/StaticAbility;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/card/Card","mayPlay","(Lforge/game/staticability/StaticAbility;)Lforge/game/card/CardPlayOption;","invokevirtual",29);}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Reference==null?47:36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardPlayOption","appliesTo","(Lforge/game/player/Player;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?47:45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getActivator","()Ljava/lang/String;","invokevirtual",51);}
case 51:{f.Locals[4]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",60);}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/player/Player","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",65);}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9534(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/Card","isSorcery","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?20:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","isInstant","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?56:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/card/CardTypeView","isLegendary","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?56:32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",39);}
case 39:{f.Push(JValue.R(rt.String("Creature.Legendary,Planeswalker.Legendary")));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",46);}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/CardLists","getValidCardCount","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)I","invokestatic",51);}
case 51:{f.Pc=f.Pop().Int>0?56:54;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAftermath","()Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int!=0?77:63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDisturb","()Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int!=0?77:70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/SpellAbility","isVengeance","()Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?89:77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int!=0?89:87;continue;}
case 87:{f.Push(JValue.I(0));f.Pc=88;continue;}
case 88:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","FUSE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","FUSE","Lforge/game/keyword/Keyword;"));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?111:99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int!=0?111:109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isHellbent","()Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int==0?127:118;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/player/Player","hasHellbent","()Z","invokevirtual",122);}
case 122:{f.Pc=f.Pop().Int!=0?127:125;continue;}
case 125:{f.Push(JValue.I(0));f.Pc=126;continue;}
case 126:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isThreshold","()Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?143:134;continue;}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/player/Player","hasThreshold","()Z","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int!=0?143:141;continue;}
case 141:{f.Push(JValue.I(0));f.Pc=142;continue;}
case 142:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 143:{f.Push(f.Locals[0]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isMetalcraft","()Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?159:150;continue;}
case 150:{f.Push(f.Locals[3]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/player/Player","hasMetalcraft","()Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int!=0?159:157;continue;}
case 157:{f.Push(JValue.I(0));f.Pc=158;continue;}
case 158:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isDelirium","()Z","invokevirtual",163);}
case 163:{f.Pc=f.Pop().Int==0?175:166;continue;}
case 166:{f.Push(f.Locals[3]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/player/Player","hasDelirium","()Z","invokevirtual",170);}
case 170:{f.Pc=f.Pop().Int!=0?175:173;continue;}
case 173:{f.Push(JValue.I(0));f.Pc=174;continue;}
case 174:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 175:{f.Push(f.Locals[2]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSurged","()Z","invokevirtual",179);}
case 179:{f.Pc=f.Pop().Int==0?191:182;continue;}
case 182:{f.Push(f.Locals[3]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/player/Player","hasSurge","()Z","invokevirtual",186);}
case 186:{f.Pc=f.Pop().Int!=0?191:189;continue;}
case 189:{f.Push(JValue.I(0));f.Pc=190;continue;}
case 190:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 191:{f.Push(f.Locals[2]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpectacle","()Z","invokevirtual",195);}
case 195:{f.Pc=f.Pop().Int==0?207:198;continue;}
case 198:{f.Push(f.Locals[3]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/player/Player","getOpponentLostLifeThisTurn","()I","invokevirtual",202);}
case 202:{f.Pc=f.Pop().Int>0?207:205;continue;}
case 205:{f.Push(JValue.I(0));f.Pc=206;continue;}
case 206:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 207:{f.Push(f.Locals[0]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isBlessing","()Z","invokevirtual",211);}
case 211:{f.Pc=f.Pop().Int==0?223:214;continue;}
case 214:{f.Push(f.Locals[3]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/player/Player","hasBlessing","()Z","invokevirtual",218);}
case 218:{f.Pc=f.Pop().Int!=0?223:221;continue;}
case 221:{f.Push(JValue.I(0));f.Pc=222;continue;}
case 222:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 223:{f.Push(f.Locals[0]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isSolved","()Z","invokevirtual",227);}
case 227:{f.Pc=f.Pop().Int==0?239:230;continue;}
case 230:{f.Push(f.Locals[1]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/card/Card","isSolved","()Z","invokevirtual",234);}
case 234:{f.Pc=f.Pop().Int!=0?239:237;continue;}
case 237:{f.Push(JValue.I(0));f.Pc=238;continue;}
case 238:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 239:{f.Push(f.Locals[2]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/spellability/SpellAbility","isProwl","()Z","invokevirtual",243);}
case 243:{f.Pc=f.Pop().Int==0?256:246;continue;}
case 246:{f.Push(f.Locals[3]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[2]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/player/Player","hasProwl","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",251);}
case 251:{f.Pc=f.Pop().Int!=0?256:254;continue;}
case 254:{f.Push(JValue.I(0));f.Pc=255;continue;}
case 255:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 256:{f.Push(f.Locals[2]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/spellability/SpellAbility","isFreerunning","()Z","invokevirtual",260);}
case 260:{f.Pc=f.Pop().Int==0?272:263;continue;}
case 263:{f.Push(f.Locals[3]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/player/Player","hasFreerunning","()Z","invokevirtual",267);}
case 267:{f.Pc=f.Pop().Int!=0?272:270;continue;}
case 270:{f.Push(JValue.I(0));f.Pc=271;continue;}
case 271:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 272:{f.Push(f.Locals[0]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getIsPresent","()Ljava/lang/String;","invokevirtual",276);}
case 276:{f.Pc=f.Pop().Reference==null?394:279;continue;}
case 279:{f.Push(f.Locals[0]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getPresentDefined","()Ljava/lang/String;","invokevirtual",283);}
case 283:{f.Pc=f.Pop().Reference==null?303:286;continue;}
case 286:{f.Push(f.Locals[2]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",290);}
case 290:{f.Push(f.Locals[0]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getPresentDefined","()Ljava/lang/String;","invokevirtual",294);}
case 294:{f.Push(f.Locals[2]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",298);}
case 298:{f.Locals[5]=f.Pop();f.Pc=300;continue;}
case 300:{f.Pc=321;continue;}
case 303:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=306;continue;}
case 306:{f.StackOp("dup");f.Pc=307;continue;}
case 307:{f.Push(f.Locals[4]);f.Pc=309;continue;}
case 309:{f.Push(f.Locals[0]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getPresentZones","()Ljava/util/List;","invokevirtual",313);}
case 313:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",316);}
case 316:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",319);}
case 319:{f.Locals[5]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[0]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getIsPresent","()Ljava/lang/String;","invokevirtual",325);}
case 325:{f.Push(JValue.R(rt.String(",")));f.Pc=328;continue;}
case 328:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",331);}
case 331:{f.Push(f.Locals[3]);f.Pc=332;continue;}
case 332:{f.Push(f.Locals[1]);f.Pc=333;continue;}
case 333:{f.Push(f.Locals[2]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/GameObjectPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",337);}
case 337:{f.Locals[6]=f.Pop();f.Pc=339;continue;}
case 339:{f.Push(f.Locals[5]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/util/collect/FCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",344);}
case 344:{f.Push(f.Locals[6]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",351);}
case 351:{return rt.Call(f,"java/util/stream/Stream","count","()J","invokeinterface",356);}
case 356:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=357;continue;}
case 357:{f.Locals[7]=f.Pop();f.Pc=359;continue;}
case 359:{f.Push(f.Locals[0]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getPresentCompare","()Ljava/lang/String;","invokevirtual",363);}
case 363:{f.Push(JValue.I(2));f.Pc=364;continue;}
case 364:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",367);}
case 367:{f.Locals[8]=f.Pop();f.Pc=369;continue;}
case 369:{f.Push(f.Locals[1]);f.Pc=370;continue;}
case 370:{f.Push(f.Locals[8]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[2]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",376);}
case 376:{f.Locals[9]=f.Pop();f.Pc=378;continue;}
case 378:{f.Push(f.Locals[7]);f.Pc=380;continue;}
case 380:{f.Push(f.Locals[0]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getPresentCompare","()Ljava/lang/String;","invokevirtual",384);}
case 384:{f.Push(f.Locals[9]);f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",389);}
case 389:{f.Pc=f.Pop().Int!=0?394:392;continue;}
case 392:{f.Push(JValue.I(0));f.Pc=393;continue;}
case 393:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 394:{f.Push(f.Locals[0]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getLifeTotal","()Ljava/lang/String;","invokevirtual",398);}
case 398:{f.Pc=f.Pop().Reference==null?457:401;continue;}
case 401:{f.Push(JValue.I(1));f.Pc=402;continue;}
case 402:{f.Locals[5]=f.Pop();f.Pc=404;continue;}
case 404:{f.Push(f.Locals[0]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getLifeTotal","()Ljava/lang/String;","invokevirtual",408);}
case 408:{f.Push(JValue.R(rt.String("You")));f.Pc=411;continue;}
case 411:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",414);}
case 414:{f.Pc=f.Pop().Int==0?423:417;continue;}
case 417:{f.Push(f.Locals[3]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",421);}
case 421:{f.Locals[5]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(f.Locals[2]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",427);}
case 427:{f.Push(f.Locals[0]);f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getLifeAmount","()Ljava/lang/String;","invokevirtual",431);}
case 431:{f.Push(JValue.I(2));f.Pc=432;continue;}
case 432:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",435);}
case 435:{f.Push(f.Locals[2]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",439);}
case 439:{f.Locals[6]=f.Pop();f.Pc=441;continue;}
case 441:{f.Push(f.Locals[5]);f.Pc=443;continue;}
case 443:{f.Push(f.Locals[0]);f.Pc=444;continue;}
case 444:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getLifeAmount","()Ljava/lang/String;","invokevirtual",447);}
case 447:{f.Push(f.Locals[6]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",452);}
case 452:{f.Pc=f.Pop().Int!=0?457:455;continue;}
case 455:{f.Push(JValue.I(0));f.Pc=456;continue;}
case 456:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 457:{f.Push(f.Locals[2]);f.Pc=458;continue;}
case 458:{return rt.Call(f,"forge/game/spellability/SpellAbility","isPwAbility","()Z","invokevirtual",461);}
case 461:{f.Pc=f.Pop().Int==0?532:464;continue;}
case 464:{f.Push(f.Locals[1]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"forge/game/card/Card","getPlaneswalkerAbilityActivated","()I","invokevirtual",468);}
case 468:{f.Locals[5]=f.Pop();f.Pc=470;continue;}
case 470:{f.Push(f.Locals[1]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"forge/game/staticability/StaticAbilityNumLoyaltyAct","limitIncrease","(Lforge/game/card/Card;)Z","invokestatic",474);}
case 474:{f.Pc=f.Pop().Int==0?481:477;continue;}
case 477:{f.Push(JValue.I(2));f.Pc=478;continue;}
case 478:{f.Pc=482;continue;}
case 481:{f.Push(JValue.I(1));f.Pc=482;continue;}
case 482:{f.Locals[6]=f.Pop();f.Pc=484;continue;}
case 484:{f.Push(f.Locals[5]);f.Pc=486;continue;}
case 486:{f.Push(f.Locals[6]);f.Pc=488;continue;}
case 488:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?529:491;continue;}
case 491:{f.Push(f.Locals[6]);f.Pc=493;continue;}
case 493:{f.Push(f.Locals[1]);f.Pc=494;continue;}
case 494:{f.Push(f.Locals[2]);f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/game/staticability/StaticAbilityNumLoyaltyAct","additionalActivations","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)I","invokestatic",498);}
case 498:{f.Push(f.Locals[6]);f.Pc=500;continue;}
case 500:{f.Push(JValue.I(1));f.Pc=501;continue;}
case 501:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?511:504;continue;}
case 504:{f.Push(f.Locals[1]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"forge/game/card/Card","planeswalkerActivationLimitUsed","()Z","invokevirtual",508);}
case 508:{f.Pc=f.Pop().Int==0?515:511;continue;}
case 511:{f.Push(JValue.I(0));f.Pc=512;continue;}
case 512:{f.Pc=516;continue;}
case 515:{f.Push(JValue.I(1));f.Pc=516;continue;}
case 516:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=517;continue;}
case 517:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=518;continue;}
case 518:{f.Locals[6]=f.Pop();f.Pc=520;continue;}
case 520:{f.Push(f.Locals[5]);f.Pc=522;continue;}
case 522:{f.Push(f.Locals[6]);f.Pc=524;continue;}
case 524:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?529:527;continue;}
case 527:{f.Push(JValue.I(0));f.Pc=528;continue;}
case 528:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 529:{f.Pc=583;continue;}
case 532:{f.Push(f.Locals[2]);f.Pc=533;continue;}
case 533:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBoast","()Z","invokevirtual",536);}
case 536:{f.Pc=f.Pop().Int==0?554:539;continue;}
case 539:{f.Push(f.Locals[2]);f.Pc=540;continue;}
case 540:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivationsThisTurn","()I","invokevirtual",543);}
case 543:{f.Push(f.Locals[1]);f.Pc=544;continue;}
case 544:{f.Push(f.Locals[2]);f.Pc=545;continue;}
case 545:{f.Push(f.Locals[3]);f.Pc=546;continue;}
case 546:{return rt.Call(f,"forge/game/staticability/StaticAbilityAdditionalActivations","getLimit","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)I","invokestatic",549);}
case 549:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?583:552;continue;}
case 552:{f.Push(JValue.I(0));f.Pc=553;continue;}
case 553:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 554:{f.Push(f.Locals[2]);f.Pc=555;continue;}
case 555:{return rt.Call(f,"forge/game/spellability/SpellAbility","isExhaust","()Z","invokevirtual",558);}
case 558:{f.Pc=f.Pop().Int!=0?568:561;continue;}
case 561:{f.Push(f.Locals[2]);f.Pc=562;continue;}
case 562:{return rt.Call(f,"forge/game/spellability/SpellAbility","isPowerUp","()Z","invokevirtual",565);}
case 565:{f.Pc=f.Pop().Int==0?583:568;continue;}
case 568:{f.Push(f.Locals[2]);f.Pc=569;continue;}
case 569:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivationsThisGame","()I","invokevirtual",572);}
case 572:{f.Push(f.Locals[1]);f.Pc=573;continue;}
case 573:{f.Push(f.Locals[2]);f.Pc=574;continue;}
case 574:{f.Push(f.Locals[3]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"forge/game/staticability/StaticAbilityAdditionalActivations","getLimit","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)I","invokestatic",578);}
case 578:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?583:581;continue;}
case 581:{f.Push(JValue.I(0));f.Pc=582;continue;}
case 582:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 583:{f.Push(f.Locals[2]);f.Pc=584;continue;}
case 584:{return rt.Call(f,"forge/game/spellability/SpellAbility","isMorphUp","()Z","invokevirtual",587);}
case 587:{f.Pc=f.Pop().Int!=0?597:590;continue;}
case 590:{f.Push(f.Locals[2]);f.Pc=591;continue;}
case 591:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDisguiseUp","()Z","invokevirtual",594);}
case 594:{f.Pc=f.Pop().Int==0?714:597;continue;}
case 597:{f.Push(f.Locals[1]);f.Pc=598;continue;}
case 598:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",601);}
case 601:{f.Pc=f.Pop().Int==0?714:604;continue;}
case 604:{f.Push(f.Locals[1]);f.Pc=605;continue;}
case 605:{f.Locals[5]=f.Pop();f.Pc=607;continue;}
case 607:{f.Push(f.Locals[1]);f.Pc=608;continue;}
case 608:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",611);}
case 611:{f.Pc=f.Pop().Int!=0?620:614;continue;}
case 614:{f.Push(f.Locals[1]);f.Pc=615;continue;}
case 615:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",618);}
case 618:{f.Locals[5]=f.Pop();f.Pc=620;continue;}
case 620:{f.Push(f.Locals[5]);f.Pc=622;continue;}
case 622:{return rt.Call(f,"forge/game/card/Card","forceTurnFaceUp","()V","invokevirtual",625);}
case 625:{f.Push(f.Locals[4]);f.Pc=627;continue;}
case 627:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",630);}
case 630:{return rt.Call(f,"forge/trackable/Tracker","freeze","()V","invokevirtual",633);}
case 633:{f.Push(f.Locals[5]);f.Pc=635;continue;}
case 635:{f.Push(JValue.I(0));f.Pc=636;continue;}
case 636:{return rt.Call(f,"forge/game/card/Card","clearStaticChangedCardKeywords","(Z)Z","invokevirtual",639);}
case 639:{f.StackOp("pop");f.Pc=640;continue;}
case 640:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=643;continue;}
case 643:{f.StackOp("dup");f.Pc=644;continue;}
case 644:{f.Push(f.Locals[5]);f.Pc=646;continue;}
case 646:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",649);}
case 649:{f.Locals[6]=f.Pop();f.Pc=651;continue;}
case 651:{f.Push(f.Locals[4]);f.Pc=653;continue;}
case 653:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",656);}
case 656:{f.Push(JValue.I(0));f.Pc=657;continue;}
case 657:{f.Push(JValue.I(1));f.Pc=658;continue;}
case 658:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=661;continue;}
case 661:{f.StackOp("dup");f.Pc=662;continue;}
case 662:{f.Push(JValue.I(0));f.Pc=663;continue;}
case 663:{f.Push(f.Locals[5]);f.Pc=665;continue;}
case 665:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=666;continue;}
case 666:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","([Ljava/lang/Object;)Ljava/util/HashSet;","invokestatic",669);}
case 669:{f.Push(f.Locals[6]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;)V","invokevirtual",674);}
case 674:{f.Push(f.Locals[5]);f.Pc=676;continue;}
case 676:{f.Push(f.Locals[2]);f.Pc=677;continue;}
case 677:{return rt.Call(f,"forge/game/card/Card","hasSpellAbility","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",680);}
case 680:{f.Locals[7]=f.Pop();f.Pc=682;continue;}
case 682:{f.Push(f.Locals[4]);f.Pc=684;continue;}
case 684:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",687);}
case 687:{f.Push(JValue.I(0));f.Pc=688;continue;}
case 688:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(Z)V","invokevirtual",691);}
case 691:{f.Push(f.Locals[4]);f.Pc=693;continue;}
case 693:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",696);}
case 696:{return rt.Call(f,"forge/trackable/Tracker","clearDelayed","()V","invokevirtual",699);}
case 699:{f.Push(f.Locals[4]);f.Pc=701;continue;}
case 701:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",704);}
case 704:{return rt.Call(f,"forge/trackable/Tracker","unfreeze","()V","invokevirtual",707);}
case 707:{f.Push(f.Locals[7]);f.Pc=709;continue;}
case 709:{f.Pc=f.Pop().Int!=0?714:712;continue;}
case 712:{f.Push(JValue.I(0));f.Pc=713;continue;}
case 713:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 714:{f.Push(f.Locals[2]);f.Pc=715;continue;}
case 715:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManaAbility","()Z","invokevirtual",718);}
case 718:{f.Pc=f.Pop().Int==0?773:721;continue;}
case 721:{f.Push(f.Locals[4]);f.Pc=723;continue;}
case 723:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=726;continue;}
case 726:{return rt.Call(f,"forge/game/zone/CostPaymentStack","iterator","()Ljava/util/Iterator;","invokevirtual",729);}
case 729:{f.Locals[5]=f.Pop();f.Pc=731;continue;}
case 731:{f.Push(f.Locals[5]);f.Pc=733;continue;}
case 733:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",738);}
case 738:{f.Pc=f.Pop().Int==0?773:741;continue;}
case 741:{f.Push(f.Locals[5]);f.Pc=743;continue;}
case 743:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",748);}
case 748:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/CostPaymentStack$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=751;continue;}
case 751:{f.Locals[6]=f.Pop();f.Pc=753;continue;}
case 753:{f.Push(f.Locals[6]);f.Pc=755;continue;}
case 755:{return rt.Call(f,"forge/game/zone/CostPaymentStack$Entry","payment","()Lforge/game/cost/CostPayment;","invokevirtual",758);}
case 758:{return rt.Call(f,"forge/game/cost/CostPayment","getAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",761);}
case 761:{f.Push(f.Locals[2]);f.Pc=762;continue;}
case 762:{return rt.Call(f,"forge/game/spellability/SpellAbility","equals","(Ljava/lang/Object;)Z","invokevirtual",765);}
case 765:{f.Pc=f.Pop().Int==0?770:768;continue;}
case 768:{f.Push(JValue.I(0));f.Pc=769;continue;}
case 769:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 770:{f.Pc=731;continue;}
case 773:{f.Push(f.Locals[0]);f.Pc=774;continue;}
case 774:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getsVarToCheck","()Ljava/lang/String;","invokevirtual",777);}
case 777:{f.Pc=f.Pop().Reference==null?818:780;continue;}
case 780:{f.Push(f.Locals[1]);f.Pc=781;continue;}
case 781:{f.Push(f.Locals[0]);f.Pc=782;continue;}
case 782:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getsVarToCheck","()Ljava/lang/String;","invokevirtual",785);}
case 785:{f.Push(f.Locals[2]);f.Pc=786;continue;}
case 786:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",789);}
case 789:{f.Locals[5]=f.Pop();f.Pc=791;continue;}
case 791:{f.Push(f.Locals[1]);f.Pc=792;continue;}
case 792:{f.Push(f.Locals[0]);f.Pc=793;continue;}
case 793:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getsVarOperand","()Ljava/lang/String;","invokevirtual",796);}
case 796:{f.Push(f.Locals[2]);f.Pc=797;continue;}
case 797:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",800);}
case 800:{f.Locals[6]=f.Pop();f.Pc=802;continue;}
case 802:{f.Push(f.Locals[5]);f.Pc=804;continue;}
case 804:{f.Push(f.Locals[0]);f.Pc=805;continue;}
case 805:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getsVarOperator","()Ljava/lang/String;","invokevirtual",808);}
case 808:{f.Push(f.Locals[6]);f.Pc=810;continue;}
case 810:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",813);}
case 813:{f.Pc=f.Pop().Int!=0?818:816;continue;}
case 816:{f.Push(JValue.I(0));f.Pc=817;continue;}
case 817:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 818:{f.Push(f.Locals[0]);f.Pc=819;continue;}
case 819:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getClassLevel","()Ljava/lang/String;","invokevirtual",822);}
case 822:{f.Pc=f.Pop().Reference==null?858:825;continue;}
case 825:{f.Push(f.Locals[1]);f.Pc=826;continue;}
case 826:{return rt.Call(f,"forge/game/card/Card","getClassLevel","()I","invokevirtual",829);}
case 829:{f.Locals[5]=f.Pop();f.Pc=831;continue;}
case 831:{f.Push(f.Locals[1]);f.Pc=832;continue;}
case 832:{f.Push(f.Locals[0]);f.Pc=833;continue;}
case 833:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getClassLevel","()Ljava/lang/String;","invokevirtual",836);}
case 836:{f.Push(f.Locals[2]);f.Pc=837;continue;}
case 837:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",840);}
case 840:{f.Locals[6]=f.Pop();f.Pc=842;continue;}
case 842:{f.Push(f.Locals[5]);f.Pc=844;continue;}
case 844:{f.Push(f.Locals[0]);f.Pc=845;continue;}
case 845:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getClassLevelOperator","()Ljava/lang/String;","invokevirtual",848);}
case 848:{f.Push(f.Locals[6]);f.Pc=850;continue;}
case 850:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",853);}
case 853:{f.Pc=f.Pop().Int!=0?858:856;continue;}
case 856:{f.Push(JValue.I(0));f.Pc=857;continue;}
case 857:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 858:{f.Push(f.Locals[0]);f.Pc=859;continue;}
case 859:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getGameTypes","()Ljava/util/Set;","invokevirtual",862);}
case 862:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",867);}
case 867:{f.Pc=f.Pop().Int<=0?900:870;continue;}
case 870:{f.Push(f.Locals[4]);f.Pc=872;continue;}
case 872:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbilityRestriction:9534:872:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/Game;)Ljava/util/function/Predicate;",877);}
case 877:{f.Locals[5]=f.Pop();f.Pc=879;continue;}
case 879:{f.Push(f.Locals[0]);f.Pc=880;continue;}
case 880:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getGameTypes","()Ljava/util/Set;","invokevirtual",883);}
case 883:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",888);}
case 888:{f.Push(f.Locals[5]);f.Pc=890;continue;}
case 890:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",895);}
case 895:{f.Pc=f.Pop().Int==0?900:898;continue;}
case 898:{f.Push(JValue.I(0));f.Pc=899;continue;}
case 899:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 900:{f.Push(JValue.I(1));f.Pc=901;continue;}
case 901:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9535(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?14:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","isUsedToPay","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference!=null?50:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",29);}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",35);}
case 35:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",42);}
case 42:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbilityRestriction:9535:42:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",47);}
case 47:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",50);}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","canCastTiming","(Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int!=0?70:59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/staticability/StaticAbilityCastWithFlash","anyWithFlashNeedsInfo","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokestatic",65);}
case 65:{f.Pc=f.Pop().Int!=0?70:68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManaAbility","()Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?99:77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",81);}
case 81:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/zone/CostPaymentStack","peek","()Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Reference==null?99:90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","isInstantSpeed","()Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?99:97;continue;}
case 97:{f.Push(JValue.I(0));f.Pc=98;continue;}
case 98:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","checkActivatorRestrictions","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int!=0?110:108;continue;}
case 108:{f.Push(JValue.I(0));f.Pc=109;continue;}
case 109:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","checkTimingRestrictions","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",116);}
case 116:{f.Pc=f.Pop().Int!=0?121:119;continue;}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","checkZoneRestrictions","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int!=0?132:130;continue;}
case 130:{f.Push(JValue.I(0));f.Pc=131;continue;}
case 131:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","checkOtherRestrictions","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int!=0?144:142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getLimitToCheck","()Ljava/lang/String;","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Reference==null?173:151;continue;}
case 151:{f.Push(f.Locals[1]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[0]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getLimitToCheck","()Ljava/lang/String;","invokevirtual",156);}
case 156:{f.Push(f.Locals[2]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",160);}
case 160:{f.Locals[4]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[2]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivationsThisTurn","()I","invokevirtual",166);}
case 166:{f.Push(f.Locals[4]);f.Pc=168;continue;}
case 168:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?173:171;continue;}
case 171:{f.Push(JValue.I(0));f.Pc=172;continue;}
case 172:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getGameLimitToCheck","()Ljava/lang/String;","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Reference==null?202:180;continue;}
case 180:{f.Push(f.Locals[1]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getGameLimitToCheck","()Ljava/lang/String;","invokevirtual",185);}
case 185:{f.Push(f.Locals[2]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",189);}
case 189:{f.Locals[4]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[2]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivationsThisGame","()I","invokevirtual",195);}
case 195:{f.Push(f.Locals[4]);f.Pc=197;continue;}
case 197:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?202:200;continue;}
case 200:{f.Push(JValue.I(0));f.Pc=201;continue;}
case 201:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 202:{f.Push(JValue.I(1));f.Pc=203;continue;}
case 203:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9536(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameRules","hasAppliedVariant","(Lforge/game/GameType;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9537(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardPlayOption","grantsZonePermissions","()Z","invokevirtual",4);}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

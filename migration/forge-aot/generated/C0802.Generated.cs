// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C802{
internal static JClass Build(){var c=new JClass("forge/game/spellability/SpellAbilityCondition","forge/game/spellability/SpellAbilityVariables",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9516,"forge/game/spellability/SpellAbilityCondition","<init>","()V",1,1,1,new JHandler[]{},M9516));
c.Add(new JMethod(9517,"forge/game/spellability/SpellAbilityCondition","setConditions","(Ljava/util/Map;)V",17,3,4,new JHandler[]{},M9517));
c.Add(new JMethod(9518,"forge/game/spellability/SpellAbilityCondition","areMet","(Lforge/game/spellability/SpellAbility;)Z",17,11,5,new JHandler[]{},M9518));
}

internal static JStep M9516(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbilityVariables","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9517(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Condition")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",8);}
case 8:{f.Pc=f.Pop().Int==0?276:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("Condition")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",19);}
case 19:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=22;continue;}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Threshold")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?37:32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setThreshold","(Z)V","invokevirtual",37);}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Metalcraft")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?51:46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setMetalcraft","(Z)V","invokevirtual",51);}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Delirium")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?65:60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setDelirium","(Z)V","invokevirtual",65);}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("Hellbent")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int==0?79:74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setHellbent","(Z)V","invokevirtual",79);}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Revolt")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?93:88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setRevolt","(Z)V","invokevirtual",93);}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("Blessing")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int==0?107:102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setBlessing","(Z)V","invokevirtual",107);}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("EnduringStory")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?121:116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setEnduringStory","(Z)V","invokevirtual",121);}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("Kicked")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int==0?135:130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(JValue.I(1));f.Pc=132;continue;}
case 132:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","kicked","Z",value);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[2]);f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("Kicked 1")));f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",141);}
case 141:{f.Pc=f.Pop().Int==0?149:144;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(JValue.I(1));f.Pc=146;continue;}
case 146:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","kicked1","Z",value);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[2]);f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.String("Kicked 2")));f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",155);}
case 155:{f.Pc=f.Pop().Int==0?163:158;continue;}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(JValue.I(1));f.Pc=160;continue;}
case 160:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","kicked2","Z",value);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[2]);f.Pc=164;continue;}
case 164:{f.Push(JValue.R(rt.String("Surge")));f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",169);}
case 169:{f.Pc=f.Pop().Int==0?177:172;continue;}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(JValue.I(1));f.Pc=174;continue;}
case 174:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","surgeCostPaid","Z",value);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[2]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("Bargain")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",183);}
case 183:{f.Pc=f.Pop().Int==0?191:186;continue;}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{f.Push(JValue.I(1));f.Pc=188;continue;}
case 188:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","bargain","Z",value);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[2]);f.Pc=192;continue;}
case 192:{f.Push(JValue.R(rt.String("Teamwork")));f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",197);}
case 197:{f.Pc=f.Pop().Int==0?205:200;continue;}
case 200:{f.Push(f.Locals[0]);f.Pc=201;continue;}
case 201:{f.Push(JValue.I(1));f.Pc=202;continue;}
case 202:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","teamwork","Z",value);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[2]);f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String("AltCost")));f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",211);}
case 211:{f.Pc=f.Pop().Int==0?219:214;continue;}
case 214:{f.Push(f.Locals[0]);f.Pc=215;continue;}
case 215:{f.Push(JValue.I(1));f.Pc=216;continue;}
case 216:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","altCostPaid","Z",value);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[2]);f.Pc=220;continue;}
case 220:{f.Push(JValue.R(rt.String("OptionalCost")));f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",225);}
case 225:{f.Pc=f.Pop().Int==0?233:228;continue;}
case 228:{f.Push(f.Locals[0]);f.Pc=229;continue;}
case 229:{f.Push(JValue.I(1));f.Pc=230;continue;}
case 230:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","optionalCostPaid","Z",value);f.Pc=233;continue;}
case 233:{f.Push(f.Locals[2]);f.Pc=234;continue;}
case 234:{f.Push(JValue.R(rt.String("Foretold")));f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",239);}
case 239:{f.Pc=f.Pop().Int==0?247:242;continue;}
case 242:{f.Push(f.Locals[0]);f.Pc=243;continue;}
case 243:{f.Push(JValue.I(1));f.Pc=244;continue;}
case 244:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","foretold","Z",value);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[1]);f.Pc=248;continue;}
case 248:{f.Push(JValue.R(rt.String("ConditionOptionalPaid")));f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",255);}
case 255:{f.Pc=f.Pop().Int==0?276:258;continue;}
case 258:{f.Push(f.Locals[0]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[1]);f.Pc=260;continue;}
case 260:{f.Push(JValue.R(rt.String("ConditionOptionalPaid")));f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",267);}
case 267:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/lang/Boolean","parseBoolean","(Ljava/lang/String;)Z","invokestatic",273);}
case 273:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","optionalBoolean","Z",value);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[1]);f.Pc=277;continue;}
case 277:{f.Push(JValue.R(rt.String("ConditionSorcerySpeed")));f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",284);}
case 284:{f.Pc=f.Pop().Int==0?292:287;continue;}
case 287:{f.Push(f.Locals[0]);f.Pc=288;continue;}
case 288:{f.Push(JValue.I(1));f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setSorcerySpeed","(Z)V","invokevirtual",292);}
case 292:{f.Push(f.Locals[1]);f.Pc=293;continue;}
case 293:{f.Push(JValue.R(rt.String("ConditionPlayerTurn")));f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",300);}
case 300:{f.Pc=f.Pop().Int==0?308:303;continue;}
case 303:{f.Push(f.Locals[0]);f.Pc=304;continue;}
case 304:{f.Push(JValue.I(1));f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setPlayerTurn","(Z)V","invokevirtual",308);}
case 308:{f.Push(f.Locals[1]);f.Pc=309;continue;}
case 309:{f.Push(JValue.R(rt.String("ConditionOpponentTurn")));f.Pc=311;continue;}
case 311:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",316);}
case 316:{f.Pc=f.Pop().Int==0?324:319;continue;}
case 319:{f.Push(f.Locals[0]);f.Pc=320;continue;}
case 320:{f.Push(JValue.I(1));f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setOpponentTurn","(Z)V","invokevirtual",324);}
case 324:{f.Push(f.Locals[1]);f.Pc=325;continue;}
case 325:{f.Push(JValue.R(rt.String("ConditionPhases")));f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",332);}
case 332:{f.Pc=f.Pop().Int==0?353:335;continue;}
case 335:{f.Push(f.Locals[0]);f.Pc=336;continue;}
case 336:{f.Push(f.Locals[1]);f.Pc=337;continue;}
case 337:{f.Push(JValue.R(rt.String("ConditionPhases")));f.Pc=339;continue;}
case 339:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",344);}
case 344:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/phase/PhaseType","parseRange","(Ljava/lang/String;)Ljava/util/Set;","invokestatic",350);}
case 350:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setPhases","(Ljava/util/Set;)V","invokevirtual",353);}
case 353:{f.Push(f.Locals[1]);f.Pc=354;continue;}
case 354:{f.Push(JValue.R(rt.String("ConditionFirstCombat")));f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",361);}
case 361:{f.Pc=f.Pop().Int==0?370:364;continue;}
case 364:{f.Push(f.Locals[0]);f.Pc=365;continue;}
case 365:{f.Push(JValue.I(1));f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setFirstCombatOnly","(Z)Z","invokevirtual",369);}
case 369:{f.StackOp("pop");f.Pc=370;continue;}
case 370:{f.Push(f.Locals[1]);f.Pc=371;continue;}
case 371:{f.Push(JValue.R(rt.String("ConditionGameTypes")));f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",378);}
case 378:{f.Pc=f.Pop().Int==0?399:381;continue;}
case 381:{f.Push(f.Locals[0]);f.Pc=382;continue;}
case 382:{f.Push(f.Locals[1]);f.Pc=383;continue;}
case 383:{f.Push(JValue.R(rt.String("ConditionGameTypes")));f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",390);}
case 390:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/GameType","listValueOf","(Ljava/lang/String;)Ljava/util/Set;","invokestatic",396);}
case 396:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setGameTypes","(Ljava/util/Set;)V","invokevirtual",399);}
case 399:{f.Push(f.Locals[1]);f.Pc=400;continue;}
case 400:{f.Push(JValue.R(rt.String("ConditionActivationLimit")));f.Pc=402;continue;}
case 402:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",407);}
case 407:{f.Pc=f.Pop().Int==0?425:410;continue;}
case 410:{f.Push(f.Locals[0]);f.Pc=411;continue;}
case 411:{f.Push(f.Locals[1]);f.Pc=412;continue;}
case 412:{f.Push(JValue.R(rt.String("ConditionActivationLimit")));f.Pc=414;continue;}
case 414:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",419);}
case 419:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=422;continue;}
case 422:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setLimitToCheck","(Ljava/lang/String;)V","invokevirtual",425);}
case 425:{f.Push(f.Locals[1]);f.Pc=426;continue;}
case 426:{f.Push(JValue.R(rt.String("ConditionChosenColor")));f.Pc=428;continue;}
case 428:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",433);}
case 433:{f.Pc=f.Pop().Int==0?451:436;continue;}
case 436:{f.Push(f.Locals[0]);f.Pc=437;continue;}
case 437:{f.Push(f.Locals[1]);f.Pc=438;continue;}
case 438:{f.Push(JValue.R(rt.String("ConditionChosenColor")));f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",445);}
case 445:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=448;continue;}
case 448:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setColorToCheck","(Ljava/lang/String;)V","invokevirtual",451);}
case 451:{f.Push(f.Locals[1]);f.Pc=452;continue;}
case 452:{f.Push(JValue.R(rt.String("ConditionPresent")));f.Pc=454;continue;}
case 454:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",459);}
case 459:{f.Pc=f.Pop().Int==0?555:462;continue;}
case 462:{f.Push(f.Locals[0]);f.Pc=463;continue;}
case 463:{f.Push(f.Locals[1]);f.Pc=464;continue;}
case 464:{f.Push(JValue.R(rt.String("ConditionPresent")));f.Pc=466;continue;}
case 466:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",471);}
case 471:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setIsPresent","(Ljava/lang/String;)V","invokevirtual",477);}
case 477:{f.Push(f.Locals[1]);f.Pc=478;continue;}
case 478:{f.Push(JValue.R(rt.String("ConditionCompare")));f.Pc=480;continue;}
case 480:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",485);}
case 485:{f.Pc=f.Pop().Int==0?503:488;continue;}
case 488:{f.Push(f.Locals[0]);f.Pc=489;continue;}
case 489:{f.Push(f.Locals[1]);f.Pc=490;continue;}
case 490:{f.Push(JValue.R(rt.String("ConditionCompare")));f.Pc=492;continue;}
case 492:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",497);}
case 497:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=500;continue;}
case 500:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setPresentCompare","(Ljava/lang/String;)V","invokevirtual",503);}
case 503:{f.Push(f.Locals[1]);f.Pc=504;continue;}
case 504:{f.Push(JValue.R(rt.String("ConditionPresent2")));f.Pc=506;continue;}
case 506:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",511);}
case 511:{f.Pc=f.Pop().Int==0?555:514;continue;}
case 514:{f.Push(f.Locals[0]);f.Pc=515;continue;}
case 515:{f.Push(f.Locals[1]);f.Pc=516;continue;}
case 516:{f.Push(JValue.R(rt.String("ConditionPresent2")));f.Pc=518;continue;}
case 518:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",523);}
case 523:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=526;continue;}
case 526:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setIsPresent2","(Ljava/lang/String;)V","invokevirtual",529);}
case 529:{f.Push(f.Locals[1]);f.Pc=530;continue;}
case 530:{f.Push(JValue.R(rt.String("ConditionCompare2")));f.Pc=532;continue;}
case 532:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",537);}
case 537:{f.Pc=f.Pop().Int==0?555:540;continue;}
case 540:{f.Push(f.Locals[0]);f.Pc=541;continue;}
case 541:{f.Push(f.Locals[1]);f.Pc=542;continue;}
case 542:{f.Push(JValue.R(rt.String("ConditionCompare2")));f.Pc=544;continue;}
case 544:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",549);}
case 549:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=552;continue;}
case 552:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setPresentCompare2","(Ljava/lang/String;)V","invokevirtual",555);}
case 555:{f.Push(f.Locals[1]);f.Pc=556;continue;}
case 556:{f.Push(JValue.R(rt.String("ConditionDefined")));f.Pc=558;continue;}
case 558:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",563);}
case 563:{f.Pc=f.Pop().Int==0?581:566;continue;}
case 566:{f.Push(f.Locals[0]);f.Pc=567;continue;}
case 567:{f.Push(f.Locals[1]);f.Pc=568;continue;}
case 568:{f.Push(JValue.R(rt.String("ConditionDefined")));f.Pc=570;continue;}
case 570:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",575);}
case 575:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=578;continue;}
case 578:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setPresentDefined","(Ljava/lang/String;)V","invokevirtual",581);}
case 581:{f.Push(f.Locals[1]);f.Pc=582;continue;}
case 582:{f.Push(JValue.R(rt.String("ConditionDefined2")));f.Pc=584;continue;}
case 584:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",589);}
case 589:{f.Pc=f.Pop().Int==0?607:592;continue;}
case 592:{f.Push(f.Locals[0]);f.Pc=593;continue;}
case 593:{f.Push(f.Locals[1]);f.Pc=594;continue;}
case 594:{f.Push(JValue.R(rt.String("ConditionDefined2")));f.Pc=596;continue;}
case 596:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",601);}
case 601:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=604;continue;}
case 604:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setPresentDefined2","(Ljava/lang/String;)V","invokevirtual",607);}
case 607:{f.Push(f.Locals[1]);f.Pc=608;continue;}
case 608:{f.Push(JValue.R(rt.String("ConditionZone")));f.Pc=610;continue;}
case 610:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",615);}
case 615:{f.Pc=f.Pop().Int==0?636:618;continue;}
case 618:{f.Push(f.Locals[0]);f.Pc=619;continue;}
case 619:{f.Push(f.Locals[1]);f.Pc=620;continue;}
case 620:{f.Push(JValue.R(rt.String("ConditionZone")));f.Pc=622;continue;}
case 622:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",627);}
case 627:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=630;continue;}
case 630:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",633);}
case 633:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setPresentZones","(Ljava/util/List;)V","invokevirtual",636);}
case 636:{f.Push(f.Locals[1]);f.Pc=637;continue;}
case 637:{f.Push(JValue.R(rt.String("ConditionPlayerDefined")));f.Pc=639;continue;}
case 639:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",644);}
case 644:{f.Pc=f.Pop().Int==0?662:647;continue;}
case 647:{f.Push(f.Locals[0]);f.Pc=648;continue;}
case 648:{f.Push(f.Locals[1]);f.Pc=649;continue;}
case 649:{f.Push(JValue.R(rt.String("ConditionPlayerDefined")));f.Pc=651;continue;}
case 651:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",656);}
case 656:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=659;continue;}
case 659:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setPlayerDefined","(Ljava/lang/String;)V","invokevirtual",662);}
case 662:{f.Push(f.Locals[1]);f.Pc=663;continue;}
case 663:{f.Push(JValue.R(rt.String("ConditionPlayerContains")));f.Pc=665;continue;}
case 665:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",670);}
case 670:{f.Pc=f.Pop().Int==0?688:673;continue;}
case 673:{f.Push(f.Locals[0]);f.Pc=674;continue;}
case 674:{f.Push(f.Locals[1]);f.Pc=675;continue;}
case 675:{f.Push(JValue.R(rt.String("ConditionPlayerContains")));f.Pc=677;continue;}
case 677:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",682);}
case 682:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=685;continue;}
case 685:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setPlayerContains","(Ljava/lang/String;)V","invokevirtual",688);}
case 688:{f.Push(f.Locals[1]);f.Pc=689;continue;}
case 689:{f.Push(JValue.R(rt.String("ConditionNotPresent")));f.Pc=691;continue;}
case 691:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",696);}
case 696:{f.Pc=f.Pop().Int==0?720:699;continue;}
case 699:{f.Push(f.Locals[0]);f.Pc=700;continue;}
case 700:{f.Push(f.Locals[1]);f.Pc=701;continue;}
case 701:{f.Push(JValue.R(rt.String("ConditionNotPresent")));f.Pc=703;continue;}
case 703:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",708);}
case 708:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=711;continue;}
case 711:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setIsPresent","(Ljava/lang/String;)V","invokevirtual",714);}
case 714:{f.Push(f.Locals[0]);f.Pc=715;continue;}
case 715:{f.Push(JValue.R(rt.String("EQ0")));f.Pc=717;continue;}
case 717:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setPresentCompare","(Ljava/lang/String;)V","invokevirtual",720);}
case 720:{f.Push(f.Locals[1]);f.Pc=721;continue;}
case 721:{f.Push(JValue.R(rt.String("ConditionLifeTotal")));f.Pc=723;continue;}
case 723:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",728);}
case 728:{f.Pc=f.Pop().Int==0?772:731;continue;}
case 731:{f.Push(f.Locals[0]);f.Pc=732;continue;}
case 732:{f.Push(f.Locals[1]);f.Pc=733;continue;}
case 733:{f.Push(JValue.R(rt.String("ConditionLifeTotal")));f.Pc=735;continue;}
case 735:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",740);}
case 740:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=743;continue;}
case 743:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setLifeTotal","(Ljava/lang/String;)V","invokevirtual",746);}
case 746:{f.Push(f.Locals[1]);f.Pc=747;continue;}
case 747:{f.Push(JValue.R(rt.String("ConditionLifeAmount")));f.Pc=749;continue;}
case 749:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",754);}
case 754:{f.Pc=f.Pop().Int==0?772:757;continue;}
case 757:{f.Push(f.Locals[0]);f.Pc=758;continue;}
case 758:{f.Push(f.Locals[1]);f.Pc=759;continue;}
case 759:{f.Push(JValue.R(rt.String("ConditionLifeAmount")));f.Pc=761;continue;}
case 761:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",766);}
case 766:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=769;continue;}
case 769:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setLifeAmount","(Ljava/lang/String;)V","invokevirtual",772);}
case 772:{f.Push(f.Locals[1]);f.Pc=773;continue;}
case 773:{f.Push(JValue.R(rt.String("ConditionNoDifferentColors")));f.Pc=775;continue;}
case 775:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",780);}
case 780:{f.Pc=f.Pop().Int==0?798:783;continue;}
case 783:{f.Push(f.Locals[0]);f.Pc=784;continue;}
case 784:{f.Push(f.Locals[1]);f.Pc=785;continue;}
case 785:{f.Push(JValue.R(rt.String("ConditionNoDifferentColors")));f.Pc=787;continue;}
case 787:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",792);}
case 792:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=795;continue;}
case 795:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setNoDifferentColors","(Ljava/lang/String;)V","invokevirtual",798);}
case 798:{f.Push(f.Locals[1]);f.Pc=799;continue;}
case 799:{f.Push(JValue.R(rt.String("ConditionManaSpent")));f.Pc=801;continue;}
case 801:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",806);}
case 806:{f.Pc=f.Pop().Int==0?824:809;continue;}
case 809:{f.Push(f.Locals[0]);f.Pc=810;continue;}
case 810:{f.Push(f.Locals[1]);f.Pc=811;continue;}
case 811:{f.Push(JValue.R(rt.String("ConditionManaSpent")));f.Pc=813;continue;}
case 813:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",818);}
case 818:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=821;continue;}
case 821:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setManaSpent","(Ljava/lang/String;)V","invokevirtual",824);}
case 824:{f.Push(f.Locals[1]);f.Pc=825;continue;}
case 825:{f.Push(JValue.R(rt.String("ConditionManaNotSpent")));f.Pc=827;continue;}
case 827:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",832);}
case 832:{f.Pc=f.Pop().Int==0?850:835;continue;}
case 835:{f.Push(f.Locals[0]);f.Pc=836;continue;}
case 836:{f.Push(f.Locals[1]);f.Pc=837;continue;}
case 837:{f.Push(JValue.R(rt.String("ConditionManaNotSpent")));f.Pc=839;continue;}
case 839:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",844);}
case 844:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=847;continue;}
case 847:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setManaNotSpent","(Ljava/lang/String;)V","invokevirtual",850);}
case 850:{f.Push(f.Locals[1]);f.Pc=851;continue;}
case 851:{f.Push(JValue.R(rt.String("ConditionCheckSVar")));f.Pc=853;continue;}
case 853:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",858);}
case 858:{f.Pc=f.Pop().Int==0?876:861;continue;}
case 861:{f.Push(f.Locals[0]);f.Pc=862;continue;}
case 862:{f.Push(f.Locals[1]);f.Pc=863;continue;}
case 863:{f.Push(JValue.R(rt.String("ConditionCheckSVar")));f.Pc=865;continue;}
case 865:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",870);}
case 870:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=873;continue;}
case 873:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setSvarToCheck","(Ljava/lang/String;)V","invokevirtual",876);}
case 876:{f.Push(f.Locals[1]);f.Pc=877;continue;}
case 877:{f.Push(JValue.R(rt.String("ConditionSVarCompare")));f.Pc=880;continue;}
case 880:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",885);}
case 885:{f.Pc=f.Pop().Int==0?929:888;continue;}
case 888:{f.Push(f.Locals[0]);f.Pc=889;continue;}
case 889:{f.Push(f.Locals[1]);f.Pc=890;continue;}
case 890:{f.Push(JValue.R(rt.String("ConditionSVarCompare")));f.Pc=893;continue;}
case 893:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",898);}
case 898:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=901;continue;}
case 901:{f.Push(JValue.I(0));f.Pc=902;continue;}
case 902:{f.Push(JValue.I(2));f.Pc=903;continue;}
case 903:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",906);}
case 906:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setSvarOperator","(Ljava/lang/String;)V","invokevirtual",909);}
case 909:{f.Push(f.Locals[0]);f.Pc=910;continue;}
case 910:{f.Push(f.Locals[1]);f.Pc=911;continue;}
case 911:{f.Push(JValue.R(rt.String("ConditionSVarCompare")));f.Pc=914;continue;}
case 914:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",919);}
case 919:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=922;continue;}
case 922:{f.Push(JValue.I(2));f.Pc=923;continue;}
case 923:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",926);}
case 926:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setSvarOperand","(Ljava/lang/String;)V","invokevirtual",929);}
case 929:{f.Push(f.Locals[1]);f.Pc=930;continue;}
case 930:{f.Push(JValue.R(rt.String("OrOtherConditionSVarCompare")));f.Pc=933;continue;}
case 933:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",938);}
case 938:{f.Pc=f.Pop().Int==0?1028:941;continue;}
case 941:{f.Push(f.Locals[1]);f.Pc=942;continue;}
case 942:{f.Push(JValue.R(rt.String("OrConditionCheckSVar")));f.Pc=945;continue;}
case 945:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",950);}
case 950:{f.Pc=f.Pop().Int==0?972:953;continue;}
case 953:{f.Push(f.Locals[0]);f.Pc=954;continue;}
case 954:{f.Push(f.Locals[1]);f.Pc=955;continue;}
case 955:{f.Push(JValue.R(rt.String("OrConditionCheckSVar")));f.Pc=958;continue;}
case 958:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",963);}
case 963:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=966;continue;}
case 966:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setSvarToCheck2","(Ljava/lang/String;)V","invokevirtual",969);}
case 969:{f.Pc=987;continue;}
case 972:{f.Push(f.Locals[0]);f.Pc=973;continue;}
case 973:{f.Push(f.Locals[1]);f.Pc=974;continue;}
case 974:{f.Push(JValue.R(rt.String("ConditionCheckSVar")));f.Pc=976;continue;}
case 976:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",981);}
case 981:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=984;continue;}
case 984:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setSvarToCheck2","(Ljava/lang/String;)V","invokevirtual",987);}
case 987:{f.Push(f.Locals[0]);f.Pc=988;continue;}
case 988:{f.Push(f.Locals[1]);f.Pc=989;continue;}
case 989:{f.Push(JValue.R(rt.String("OrOtherConditionSVarCompare")));f.Pc=992;continue;}
case 992:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",997);}
case 997:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1000;continue;}
case 1000:{f.Push(JValue.I(0));f.Pc=1001;continue;}
case 1001:{f.Push(JValue.I(2));f.Pc=1002;continue;}
case 1002:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",1005);}
case 1005:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setSvarOperator2","(Ljava/lang/String;)V","invokevirtual",1008);}
case 1008:{f.Push(f.Locals[0]);f.Pc=1009;continue;}
case 1009:{f.Push(f.Locals[1]);f.Pc=1010;continue;}
case 1010:{f.Push(JValue.R(rt.String("OrOtherConditionSVarCompare")));f.Pc=1013;continue;}
case 1013:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1018);}
case 1018:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1021;continue;}
case 1021:{f.Push(JValue.I(2));f.Pc=1022;continue;}
case 1022:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1025);}
case 1025:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setSvarOperand2","(Ljava/lang/String;)V","invokevirtual",1028);}
case 1028:{f.Push(f.Locals[1]);f.Pc=1029;continue;}
case 1029:{f.Push(JValue.R(rt.String("ConditionTargetValidTargeting")));f.Pc=1032;continue;}
case 1032:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1037);}
case 1037:{f.Pc=f.Pop().Int==0?1056:1040;continue;}
case 1040:{f.Push(f.Locals[0]);f.Pc=1041;continue;}
case 1041:{f.Push(f.Locals[1]);f.Pc=1042;continue;}
case 1042:{f.Push(JValue.R(rt.String("ConditionTargetValidTargeting")));f.Pc=1045;continue;}
case 1045:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1050);}
case 1050:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1053;continue;}
case 1053:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setTargetValidTargeting","(Ljava/lang/String;)V","invokevirtual",1056);}
case 1056:{f.Push(f.Locals[1]);f.Pc=1057;continue;}
case 1057:{f.Push(JValue.R(rt.String("ConditionTargetsSingleTarget")));f.Pc=1060;continue;}
case 1060:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1065);}
case 1065:{f.Pc=f.Pop().Int==0?1073:1068;continue;}
case 1068:{f.Push(f.Locals[0]);f.Pc=1069;continue;}
case 1069:{f.Push(JValue.I(1));f.Pc=1070;continue;}
case 1070:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","setTargetsSingleTarget","(Z)V","invokevirtual",1073);}
case 1073:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9518(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?35:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",27);}
case 27:{return rt.DynamicCall(f,"forge/game/spellability/SpellAbilityCondition:9518:27:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",32);}
case 32:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",35);}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",39);}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",44);}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",50);}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","isHellbent","()Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?68:59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/player/Player","hasHellbent","()Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int!=0?68:66;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","isThreshold","()Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?84:75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/player/Player","hasThreshold","()Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int!=0?84:82;continue;}
case 82:{f.Push(JValue.I(0));f.Pc=83;continue;}
case 83:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","isMetalcraft","()Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?100:91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/player/Player","hasMetalcraft","()Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int!=0?100:98;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","isDelirium","()Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?116:107;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/player/Player","hasDelirium","()Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int!=0?116:114;continue;}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","isRevolt","()Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?132:123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/player/Player","hasRevolt","()Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int!=0?132:130;continue;}
case 130:{f.Push(JValue.I(0));f.Pc=131;continue;}
case 131:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","isBlessing","()Z","invokevirtual",136);}
case 136:{f.Pc=f.Pop().Int==0?148:139;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/player/Player","hasBlessing","()Z","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Int!=0?148:146;continue;}
case 146:{f.Push(JValue.I(0));f.Pc=147;continue;}
case 147:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","isEnduringStory","()Z","invokevirtual",152);}
case 152:{f.Pc=f.Pop().Int==0?164:155;continue;}
case 155:{f.Push(f.Locals[2]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/player/Player","hasEnduringStory","()Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int!=0?164:162;continue;}
case 162:{f.Push(JValue.I(0));f.Pc=163;continue;}
case 163:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 164:{f.Push(f.Locals[0]);f.Pc=165;continue;}
case 165:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","kicked","Z"));f.Pc=168;continue;}
case 168:{f.Pc=f.Pop().Int==0?180:171;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKicked","()Z","invokevirtual",175);}
case 175:{f.Pc=f.Pop().Int!=0?180:178;continue;}
case 178:{f.Push(JValue.I(0));f.Pc=179;continue;}
case 179:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 180:{f.Push(f.Locals[0]);f.Pc=181;continue;}
case 181:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","kicked1","Z"));f.Pc=184;continue;}
case 184:{f.Pc=f.Pop().Int==0?199:187;continue;}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;"));f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",194);}
case 194:{f.Pc=f.Pop().Int!=0?199:197;continue;}
case 197:{f.Push(JValue.I(0));f.Pc=198;continue;}
case 198:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 199:{f.Push(f.Locals[0]);f.Pc=200;continue;}
case 200:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","kicked2","Z"));f.Pc=203;continue;}
case 203:{f.Pc=f.Pop().Int==0?218:206;continue;}
case 206:{f.Push(f.Locals[1]);f.Pc=207;continue;}
case 207:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;"));f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",213);}
case 213:{f.Pc=f.Pop().Int!=0?218:216;continue;}
case 216:{f.Push(JValue.I(0));f.Pc=217;continue;}
case 217:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","altCostPaid","Z"));f.Pc=222;continue;}
case 222:{f.Pc=f.Pop().Int==0?237:225;continue;}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","AltCost","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","AltCost","Lforge/game/spellability/OptionalCost;"));f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",232);}
case 232:{f.Pc=f.Pop().Int!=0?237:235;continue;}
case 235:{f.Push(JValue.I(0));f.Pc=236;continue;}
case 236:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 237:{f.Push(f.Locals[0]);f.Pc=238;continue;}
case 238:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","surgeCostPaid","Z"));f.Pc=241;continue;}
case 241:{f.Pc=f.Pop().Int==0?253:244;continue;}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSurged","()Z","invokevirtual",248);}
case 248:{f.Pc=f.Pop().Int!=0?253:251;continue;}
case 251:{f.Push(JValue.I(0));f.Pc=252;continue;}
case 252:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 253:{f.Push(f.Locals[0]);f.Pc=254;continue;}
case 254:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","bargain","Z"));f.Pc=257;continue;}
case 257:{f.Pc=f.Pop().Int==0?269:260;continue;}
case 260:{f.Push(f.Locals[1]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBargained","()Z","invokevirtual",264);}
case 264:{f.Pc=f.Pop().Int!=0?269:267;continue;}
case 267:{f.Push(JValue.I(0));f.Pc=268;continue;}
case 268:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 269:{f.Push(f.Locals[0]);f.Pc=270;continue;}
case 270:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","foretold","Z"));f.Pc=273;continue;}
case 273:{f.Pc=f.Pop().Int==0?285:276;continue;}
case 276:{f.Push(f.Locals[1]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/spellability/SpellAbility","isForetold","()Z","invokevirtual",280);}
case 280:{f.Pc=f.Pop().Int!=0?285:283;continue;}
case 283:{f.Push(JValue.I(0));f.Pc=284;continue;}
case 284:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 285:{f.Push(f.Locals[0]);f.Pc=286;continue;}
case 286:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","teamwork","Z"));f.Pc=289;continue;}
case 289:{f.Pc=f.Pop().Int==0?301:292;continue;}
case 292:{f.Push(f.Locals[1]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTeamwork","()Z","invokevirtual",296);}
case 296:{f.Pc=f.Pop().Int!=0?301:299;continue;}
case 299:{f.Push(JValue.I(0));f.Pc=300;continue;}
case 300:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 301:{f.Push(f.Locals[0]);f.Pc=302;continue;}
case 302:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","optionalCostPaid","Z"));f.Pc=305;continue;}
case 305:{f.Pc=f.Pop().Int==0?327:308;continue;}
case 308:{f.Push(f.Locals[0]);f.Pc=309;continue;}
case 309:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","optionalBoolean","Z"));f.Pc=312;continue;}
case 312:{f.Pc=f.Pop().Int==0?327:315;continue;}
case 315:{f.Push(f.Locals[1]);f.Pc=316;continue;}
case 316:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;"));f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",322);}
case 322:{f.Pc=f.Pop().Int!=0?327:325;continue;}
case 325:{f.Push(JValue.I(0));f.Pc=326;continue;}
case 326:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 327:{f.Push(f.Locals[0]);f.Pc=328;continue;}
case 328:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","optionalCostPaid","Z"));f.Pc=331;continue;}
case 331:{f.Pc=f.Pop().Int==0?353:334;continue;}
case 334:{f.Push(f.Locals[0]);f.Pc=335;continue;}
case 335:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityCondition","optionalBoolean","Z"));f.Pc=338;continue;}
case 338:{f.Pc=f.Pop().Int!=0?353:341;continue;}
case 341:{f.Push(f.Locals[1]);f.Pc=342;continue;}
case 342:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;"));f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalCostPaid","(Lforge/game/spellability/OptionalCost;)Z","invokevirtual",348);}
case 348:{f.Pc=f.Pop().Int==0?353:351;continue;}
case 351:{f.Push(JValue.I(0));f.Pc=352;continue;}
case 352:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 353:{f.Push(f.Locals[0]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getNoDifferentColors","()Ljava/lang/String;","invokevirtual",357);}
case 357:{f.Pc=f.Pop().Reference==null?449:360;continue;}
case 360:{f.Push(f.Locals[5]);f.Pc=362;continue;}
case 362:{f.Push(f.Locals[0]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getNoDifferentColors","()Ljava/lang/String;","invokevirtual",366);}
case 366:{f.Push(f.Locals[1]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",370);}
case 370:{f.Locals[6]=f.Pop();f.Pc=372;continue;}
case 372:{f.Push(f.Locals[6]);f.Pc=374;continue;}
case 374:{f.Push(JValue.R(null));f.Pc=375;continue;}
case 375:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",378);}
case 378:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=381;continue;}
case 381:{f.Locals[7]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(f.Locals[7]);f.Pc=385;continue;}
case 385:{f.Pc=f.Pop().Reference!=null?390:388;continue;}
case 388:{f.Push(JValue.I(0));f.Pc=389;continue;}
case 389:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 390:{f.Push(f.Locals[7]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",395);}
case 395:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",398);}
case 398:{f.Locals[8]=f.Pop();f.Pc=400;continue;}
case 400:{f.Push(f.Locals[6]);f.Pc=402;continue;}
case 402:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",407);}
case 407:{f.Locals[9]=f.Pop();f.Pc=409;continue;}
case 409:{f.Push(f.Locals[9]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",416);}
case 416:{f.Pc=f.Pop().Int==0?449:419;continue;}
case 419:{f.Push(f.Locals[9]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",426);}
case 426:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=429;continue;}
case 429:{f.Locals[10]=f.Pop();f.Pc=431;continue;}
case 431:{f.Push(f.Locals[10]);f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",436);}
case 436:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",439);}
case 439:{f.Push(f.Locals[8]);f.Pc=441;continue;}
case 441:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?446:444;continue;}
case 444:{f.Push(JValue.I(0));f.Pc=445;continue;}
case 445:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 446:{f.Pc=409;continue;}
case 449:{f.Push(f.Locals[0]);f.Pc=450;continue;}
case 450:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","isSorcerySpeed","()Z","invokevirtual",453);}
case 453:{f.Pc=f.Pop().Int==0?465:456;continue;}
case 456:{f.Push(f.Locals[2]);f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/game/player/Player","canCastSorcery","()Z","invokevirtual",460);}
case 460:{f.Pc=f.Pop().Int!=0?465:463;continue;}
case 463:{f.Push(JValue.I(0));f.Pc=464;continue;}
case 464:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 465:{f.Push(f.Locals[0]);f.Pc=466;continue;}
case 466:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","isPlayerTurn","()Z","invokevirtual",469);}
case 469:{f.Pc=f.Pop().Int==0?526:472;continue;}
case 472:{f.Push(f.Locals[1]);f.Pc=473;continue;}
case 473:{f.Push(JValue.R(rt.String("ConditionPlayerTurn")));f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",478);}
case 478:{f.Push(JValue.R(rt.String("False")));f.Pc=481;continue;}
case 481:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",484);}
case 484:{f.Pc=f.Pop().Int!=0?491:487;continue;}
case 487:{f.Push(JValue.I(1));f.Pc=488;continue;}
case 488:{f.Pc=492;continue;}
case 491:{f.Push(JValue.I(0));f.Pc=492;continue;}
case 492:{f.Locals[6]=f.Pop();f.Pc=494;continue;}
case 494:{f.Push(f.Locals[6]);f.Pc=496;continue;}
case 496:{f.Pc=f.Pop().Int!=0?510:499;continue;}
case 499:{f.Push(f.Locals[4]);f.Pc=501;continue;}
case 501:{f.Push(f.Locals[2]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",505);}
case 505:{f.Pc=f.Pop().Int==0?510:508;continue;}
case 508:{f.Push(JValue.I(0));f.Pc=509;continue;}
case 509:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 510:{f.Push(f.Locals[6]);f.Pc=512;continue;}
case 512:{f.Pc=f.Pop().Int==0?526:515;continue;}
case 515:{f.Push(f.Locals[4]);f.Pc=517;continue;}
case 517:{f.Push(f.Locals[2]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",521);}
case 521:{f.Pc=f.Pop().Int!=0?526:524;continue;}
case 524:{f.Push(JValue.I(0));f.Pc=525;continue;}
case 525:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 526:{f.Push(f.Locals[0]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","isOpponentTurn","()Z","invokevirtual",530);}
case 530:{f.Pc=f.Pop().Int==0?547:533;continue;}
case 533:{f.Push(f.Locals[4]);f.Pc=535;continue;}
case 535:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",538);}
case 538:{f.Push(f.Locals[2]);f.Pc=539;continue;}
case 539:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",542);}
case 542:{f.Pc=f.Pop().Int!=0?547:545;continue;}
case 545:{f.Push(JValue.I(0));f.Pc=546;continue;}
case 546:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 547:{f.Push(f.Locals[0]);f.Pc=548;continue;}
case 548:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getFirstCombatOnly","()Z","invokevirtual",551);}
case 551:{f.Pc=f.Pop().Int==0?564:554;continue;}
case 554:{f.Push(f.Locals[4]);f.Pc=556;continue;}
case 556:{return rt.Call(f,"forge/game/phase/PhaseHandler","isFirstCombat","()Z","invokevirtual",559);}
case 559:{f.Pc=f.Pop().Int!=0?564:562;continue;}
case 562:{f.Push(JValue.I(0));f.Pc=563;continue;}
case 563:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 564:{f.Push(f.Locals[0]);f.Pc=565;continue;}
case 565:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getLimitToCheck","()Ljava/lang/String;","invokevirtual",568);}
case 568:{f.Pc=f.Pop().Reference==null?608:571;continue;}
case 571:{f.Push(f.Locals[0]);f.Pc=572;continue;}
case 572:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getLimitToCheck","()Ljava/lang/String;","invokevirtual",575);}
case 575:{f.Locals[6]=f.Pop();f.Pc=577;continue;}
case 577:{f.Push(f.Locals[6]);f.Pc=579;continue;}
case 579:{f.Push(JValue.I(2));f.Pc=580;continue;}
case 580:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",583);}
case 583:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",586);}
case 586:{f.Locals[7]=f.Pop();f.Pc=588;continue;}
case 588:{f.Push(f.Locals[1]);f.Pc=589;continue;}
case 589:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivationsThisTurn","()I","invokevirtual",592);}
case 592:{f.Locals[8]=f.Pop();f.Pc=594;continue;}
case 594:{f.Push(f.Locals[8]);f.Pc=596;continue;}
case 596:{f.Push(f.Locals[6]);f.Pc=598;continue;}
case 598:{f.Push(f.Locals[7]);f.Pc=600;continue;}
case 600:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",603);}
case 603:{f.Pc=f.Pop().Int!=0?608:606;continue;}
case 606:{f.Push(JValue.I(0));f.Pc=607;continue;}
case 607:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 608:{f.Push(f.Locals[0]);f.Pc=609;continue;}
case 609:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPhases","()Ljava/util/Set;","invokevirtual",612);}
case 612:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",617);}
case 617:{f.Pc=f.Pop().Int<=0?639:620;continue;}
case 620:{f.Push(f.Locals[0]);f.Pc=621;continue;}
case 621:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPhases","()Ljava/util/Set;","invokevirtual",624);}
case 624:{f.Push(f.Locals[4]);f.Pc=626;continue;}
case 626:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",629);}
case 629:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",634);}
case 634:{f.Pc=f.Pop().Int!=0?639:637;continue;}
case 637:{f.Push(JValue.I(0));f.Pc=638;continue;}
case 638:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 639:{f.Push(f.Locals[0]);f.Pc=640;continue;}
case 640:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getGameTypes","()Ljava/util/Set;","invokevirtual",643);}
case 643:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",648);}
case 648:{f.Pc=f.Pop().Int<=0?672:651;continue;}
case 651:{f.Push(f.Locals[0]);f.Pc=652;continue;}
case 652:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getGameTypes","()Ljava/util/Set;","invokevirtual",655);}
case 655:{f.Push(f.Locals[3]);f.Pc=656;continue;}
case 656:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",659);}
case 659:{return rt.Call(f,"forge/game/GameRules","getGameType","()Lforge/game/GameType;","invokevirtual",662);}
case 662:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",667);}
case 667:{f.Pc=f.Pop().Int!=0?672:670;continue;}
case 670:{f.Push(JValue.I(0));f.Pc=671;continue;}
case 671:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 672:{f.Push(f.Locals[0]);f.Pc=673;continue;}
case 673:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getColorToCheck","()Ljava/lang/String;","invokevirtual",676);}
case 676:{f.Pc=f.Pop().Reference==null?693:679;continue;}
case 679:{f.Push(f.Locals[5]);f.Pc=681;continue;}
case 681:{f.Push(f.Locals[0]);f.Pc=682;continue;}
case 682:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getColorToCheck","()Ljava/lang/String;","invokevirtual",685);}
case 685:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","(Ljava/lang/String;)Z","invokevirtual",688);}
case 688:{f.Pc=f.Pop().Int!=0?693:691;continue;}
case 691:{f.Push(JValue.I(0));f.Pc=692;continue;}
case 692:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 693:{f.Push(f.Locals[0]);f.Pc=694;continue;}
case 694:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getIsPresent","()Ljava/lang/String;","invokevirtual",697);}
case 697:{f.Pc=f.Pop().Reference==null?940:700;continue;}
case 700:{f.Push(JValue.R(null));f.Pc=701;continue;}
case 701:{f.Locals[6]=f.Pop();f.Pc=703;continue;}
case 703:{f.Push(f.Locals[0]);f.Pc=704;continue;}
case 704:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPresentDefined","()Ljava/lang/String;","invokevirtual",707);}
case 707:{f.Pc=f.Pop().Reference==null?725:710;continue;}
case 710:{f.Push(f.Locals[5]);f.Pc=712;continue;}
case 712:{f.Push(f.Locals[0]);f.Pc=713;continue;}
case 713:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPresentDefined","()Ljava/lang/String;","invokevirtual",716);}
case 716:{f.Push(f.Locals[1]);f.Pc=717;continue;}
case 717:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",720);}
case 720:{f.Locals[6]=f.Pop();f.Pc=722;continue;}
case 722:{f.Pc=865;continue;}
case 725:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=728;continue;}
case 728:{f.StackOp("dup");f.Pc=729;continue;}
case 729:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",732);}
case 732:{f.Locals[6]=f.Pop();f.Pc=734;continue;}
case 734:{f.Push(f.Locals[0]);f.Pc=735;continue;}
case 735:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPresentZones","()Ljava/util/List;","invokevirtual",738);}
case 738:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",743);}
case 743:{f.Locals[7]=f.Pop();f.Pc=745;continue;}
case 745:{f.Push(f.Locals[7]);f.Pc=747;continue;}
case 747:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",752);}
case 752:{f.Pc=f.Pop().Int==0?865:755;continue;}
case 755:{f.Push(f.Locals[7]);f.Pc=757;continue;}
case 757:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",762);}
case 762:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=765;continue;}
case 765:{f.Locals[8]=f.Pop();f.Pc=767;continue;}
case 767:{f.Push(f.Locals[1]);f.Pc=768;continue;}
case 768:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",771);}
case 771:{f.Pc=f.Pop().Int==0?796:774;continue;}
case 774:{f.Push(f.Locals[8]);f.Pc=776;continue;}
case 776:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=779;continue;}
case 779:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",782);}
case 782:{f.Pc=f.Pop().Int!=0?811:785;continue;}
case 785:{f.Push(f.Locals[8]);f.Pc=787;continue;}
case 787:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=790;continue;}
case 790:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",793);}
case 793:{f.Pc=f.Pop().Int!=0?811:796;continue;}
case 796:{f.Push(f.Locals[6]);f.Pc=798;continue;}
case 798:{f.Push(f.Locals[3]);f.Pc=799;continue;}
case 799:{f.Push(f.Locals[8]);f.Pc=801;continue;}
case 801:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",804);}
case 804:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",807);}
case 807:{f.StackOp("pop");f.Pc=808;continue;}
case 808:{f.Pc=862;continue;}
case 811:{f.Push(f.Locals[8]);f.Pc=813;continue;}
case 813:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=816;continue;}
case 816:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",819);}
case 819:{f.Pc=f.Pop().Int==0?838:822;continue;}
case 822:{f.Push(f.Locals[6]);f.Pc=824;continue;}
case 824:{f.Push(f.Locals[1]);f.Pc=825;continue;}
case 825:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",828);}
case 828:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateBattlefield","()Lforge/game/card/CardCollection;","invokevirtual",831);}
case 831:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",834);}
case 834:{f.StackOp("pop");f.Pc=835;continue;}
case 835:{f.Pc=862;continue;}
case 838:{f.Push(f.Locals[8]);f.Pc=840;continue;}
case 840:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=843;continue;}
case 843:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",846);}
case 846:{f.Pc=f.Pop().Int==0?862:849;continue;}
case 849:{f.Push(f.Locals[6]);f.Pc=851;continue;}
case 851:{f.Push(f.Locals[1]);f.Pc=852;continue;}
case 852:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",855);}
case 855:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateGraveyard","()Lforge/game/card/CardCollection;","invokevirtual",858);}
case 858:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",861);}
case 861:{f.StackOp("pop");f.Pc=862;continue;}
case 862:{f.Pc=745;continue;}
case 865:{f.Push(f.Locals[0]);f.Pc=866;continue;}
case 866:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getIsPresent","()Ljava/lang/String;","invokevirtual",869);}
case 869:{f.Push(JValue.R(rt.String(",")));f.Pc=872;continue;}
case 872:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",875);}
case 875:{f.Push(f.Locals[2]);f.Pc=876;continue;}
case 876:{f.Push(f.Locals[5]);f.Pc=878;continue;}
case 878:{f.Push(f.Locals[1]);f.Pc=879;continue;}
case 879:{return rt.Call(f,"forge/game/GameObjectPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",882);}
case 882:{f.Locals[7]=f.Pop();f.Pc=884;continue;}
case 884:{f.Push(f.Locals[6]);f.Pc=886;continue;}
case 886:{return rt.Call(f,"forge/util/collect/FCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",889);}
case 889:{f.Push(f.Locals[7]);f.Pc=891;continue;}
case 891:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",896);}
case 896:{return rt.Call(f,"java/util/stream/Stream","count","()J","invokeinterface",901);}
case 901:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=902;continue;}
case 902:{f.Locals[8]=f.Pop();f.Pc=904;continue;}
case 904:{f.Push(f.Locals[0]);f.Pc=905;continue;}
case 905:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPresentCompare","()Ljava/lang/String;","invokevirtual",908);}
case 908:{f.Push(JValue.I(2));f.Pc=909;continue;}
case 909:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",912);}
case 912:{f.Locals[9]=f.Pop();f.Pc=914;continue;}
case 914:{f.Push(f.Locals[5]);f.Pc=916;continue;}
case 916:{f.Push(f.Locals[9]);f.Pc=918;continue;}
case 918:{f.Push(f.Locals[1]);f.Pc=919;continue;}
case 919:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",922);}
case 922:{f.Locals[10]=f.Pop();f.Pc=924;continue;}
case 924:{f.Push(f.Locals[8]);f.Pc=926;continue;}
case 926:{f.Push(f.Locals[0]);f.Pc=927;continue;}
case 927:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPresentCompare","()Ljava/lang/String;","invokevirtual",930);}
case 930:{f.Push(f.Locals[10]);f.Pc=932;continue;}
case 932:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",935);}
case 935:{f.Pc=f.Pop().Int!=0?940:938;continue;}
case 938:{f.Push(JValue.I(0));f.Pc=939;continue;}
case 939:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 940:{f.Push(f.Locals[0]);f.Pc=941;continue;}
case 941:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getIsPresent2","()Ljava/lang/String;","invokevirtual",944);}
case 944:{f.Pc=f.Pop().Reference==null?1187:947;continue;}
case 947:{f.Push(JValue.R(null));f.Pc=948;continue;}
case 948:{f.Locals[6]=f.Pop();f.Pc=950;continue;}
case 950:{f.Push(f.Locals[0]);f.Pc=951;continue;}
case 951:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPresentDefined2","()Ljava/lang/String;","invokevirtual",954);}
case 954:{f.Pc=f.Pop().Reference==null?972:957;continue;}
case 957:{f.Push(f.Locals[5]);f.Pc=959;continue;}
case 959:{f.Push(f.Locals[0]);f.Pc=960;continue;}
case 960:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPresentDefined2","()Ljava/lang/String;","invokevirtual",963);}
case 963:{f.Push(f.Locals[1]);f.Pc=964;continue;}
case 964:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",967);}
case 967:{f.Locals[6]=f.Pop();f.Pc=969;continue;}
case 969:{f.Pc=1112;continue;}
case 972:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=975;continue;}
case 975:{f.StackOp("dup");f.Pc=976;continue;}
case 976:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",979);}
case 979:{f.Locals[6]=f.Pop();f.Pc=981;continue;}
case 981:{f.Push(f.Locals[0]);f.Pc=982;continue;}
case 982:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPresentZones","()Ljava/util/List;","invokevirtual",985);}
case 985:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",990);}
case 990:{f.Locals[7]=f.Pop();f.Pc=992;continue;}
case 992:{f.Push(f.Locals[7]);f.Pc=994;continue;}
case 994:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",999);}
case 999:{f.Pc=f.Pop().Int==0?1112:1002;continue;}
case 1002:{f.Push(f.Locals[7]);f.Pc=1004;continue;}
case 1004:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1009);}
case 1009:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1012;continue;}
case 1012:{f.Locals[8]=f.Pop();f.Pc=1014;continue;}
case 1014:{f.Push(f.Locals[1]);f.Pc=1015;continue;}
case 1015:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",1018);}
case 1018:{f.Pc=f.Pop().Int==0?1043:1021;continue;}
case 1021:{f.Push(f.Locals[8]);f.Pc=1023;continue;}
case 1023:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1026;continue;}
case 1026:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",1029);}
case 1029:{f.Pc=f.Pop().Int!=0?1058:1032;continue;}
case 1032:{f.Push(f.Locals[8]);f.Pc=1034;continue;}
case 1034:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1037;continue;}
case 1037:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",1040);}
case 1040:{f.Pc=f.Pop().Int!=0?1058:1043;continue;}
case 1043:{f.Push(f.Locals[6]);f.Pc=1045;continue;}
case 1045:{f.Push(f.Locals[3]);f.Pc=1046;continue;}
case 1046:{f.Push(f.Locals[8]);f.Pc=1048;continue;}
case 1048:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1051);}
case 1051:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1054);}
case 1054:{f.StackOp("pop");f.Pc=1055;continue;}
case 1055:{f.Pc=1109;continue;}
case 1058:{f.Push(f.Locals[8]);f.Pc=1060;continue;}
case 1060:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1063;continue;}
case 1063:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",1066);}
case 1066:{f.Pc=f.Pop().Int==0?1085:1069;continue;}
case 1069:{f.Push(f.Locals[6]);f.Pc=1071;continue;}
case 1071:{f.Push(f.Locals[1]);f.Pc=1072;continue;}
case 1072:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1075);}
case 1075:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateBattlefield","()Lforge/game/card/CardCollection;","invokevirtual",1078);}
case 1078:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1081);}
case 1081:{f.StackOp("pop");f.Pc=1082;continue;}
case 1082:{f.Pc=1109;continue;}
case 1085:{f.Push(f.Locals[8]);f.Pc=1087;continue;}
case 1087:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1090;continue;}
case 1090:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",1093);}
case 1093:{f.Pc=f.Pop().Int==0?1109:1096;continue;}
case 1096:{f.Push(f.Locals[6]);f.Pc=1098;continue;}
case 1098:{f.Push(f.Locals[1]);f.Pc=1099;continue;}
case 1099:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1102);}
case 1102:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateGraveyard","()Lforge/game/card/CardCollection;","invokevirtual",1105);}
case 1105:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",1108);}
case 1108:{f.StackOp("pop");f.Pc=1109;continue;}
case 1109:{f.Pc=992;continue;}
case 1112:{f.Push(f.Locals[0]);f.Pc=1113;continue;}
case 1113:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getIsPresent2","()Ljava/lang/String;","invokevirtual",1116);}
case 1116:{f.Push(JValue.R(rt.String(",")));f.Pc=1119;continue;}
case 1119:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1122);}
case 1122:{f.Push(f.Locals[2]);f.Pc=1123;continue;}
case 1123:{f.Push(f.Locals[5]);f.Pc=1125;continue;}
case 1125:{f.Push(f.Locals[1]);f.Pc=1126;continue;}
case 1126:{return rt.Call(f,"forge/game/GameObjectPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",1129);}
case 1129:{f.Locals[7]=f.Pop();f.Pc=1131;continue;}
case 1131:{f.Push(f.Locals[6]);f.Pc=1133;continue;}
case 1133:{return rt.Call(f,"forge/util/collect/FCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",1136);}
case 1136:{f.Push(f.Locals[7]);f.Pc=1138;continue;}
case 1138:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",1143);}
case 1143:{return rt.Call(f,"java/util/stream/Stream","count","()J","invokeinterface",1148);}
case 1148:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=1149;continue;}
case 1149:{f.Locals[8]=f.Pop();f.Pc=1151;continue;}
case 1151:{f.Push(f.Locals[0]);f.Pc=1152;continue;}
case 1152:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPresentCompare2","()Ljava/lang/String;","invokevirtual",1155);}
case 1155:{f.Push(JValue.I(2));f.Pc=1156;continue;}
case 1156:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1159);}
case 1159:{f.Locals[9]=f.Pop();f.Pc=1161;continue;}
case 1161:{f.Push(f.Locals[5]);f.Pc=1163;continue;}
case 1163:{f.Push(f.Locals[9]);f.Pc=1165;continue;}
case 1165:{f.Push(f.Locals[1]);f.Pc=1166;continue;}
case 1166:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1169);}
case 1169:{f.Locals[10]=f.Pop();f.Pc=1171;continue;}
case 1171:{f.Push(f.Locals[8]);f.Pc=1173;continue;}
case 1173:{f.Push(f.Locals[0]);f.Pc=1174;continue;}
case 1174:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPresentCompare2","()Ljava/lang/String;","invokevirtual",1177);}
case 1177:{f.Push(f.Locals[10]);f.Pc=1179;continue;}
case 1179:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1182);}
case 1182:{f.Pc=f.Pop().Int!=0?1187:1185;continue;}
case 1185:{f.Push(JValue.I(0));f.Pc=1186;continue;}
case 1186:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1187:{f.Push(f.Locals[0]);f.Pc=1188;continue;}
case 1188:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPlayerContains","()Ljava/lang/String;","invokevirtual",1191);}
case 1191:{f.Pc=f.Pop().Reference==null?1264:1194;continue;}
case 1194:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=1197;continue;}
case 1197:{f.StackOp("dup");f.Pc=1198;continue;}
case 1198:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",1201);}
case 1201:{f.Locals[6]=f.Pop();f.Pc=1203;continue;}
case 1203:{f.Push(f.Locals[0]);f.Pc=1204;continue;}
case 1204:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPlayerDefined","()Ljava/lang/String;","invokevirtual",1207);}
case 1207:{f.Pc=f.Pop().Reference==null?1228:1210;continue;}
case 1210:{f.Push(f.Locals[6]);f.Pc=1212;continue;}
case 1212:{f.Push(f.Locals[5]);f.Pc=1214;continue;}
case 1214:{f.Push(f.Locals[0]);f.Pc=1215;continue;}
case 1215:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPlayerDefined","()Ljava/lang/String;","invokevirtual",1218);}
case 1218:{f.Push(f.Locals[1]);f.Pc=1219;continue;}
case 1219:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1222);}
case 1222:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",1227);}
case 1227:{f.StackOp("pop");f.Pc=1228;continue;}
case 1228:{f.Push(f.Locals[5]);f.Pc=1230;continue;}
case 1230:{f.Push(f.Locals[0]);f.Pc=1231;continue;}
case 1231:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getPlayerContains","()Ljava/lang/String;","invokevirtual",1234);}
case 1234:{f.Push(f.Locals[1]);f.Pc=1235;continue;}
case 1235:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1238);}
case 1238:{f.Locals[7]=f.Pop();f.Pc=1240;continue;}
case 1240:{f.Push(f.Locals[7]);f.Pc=1242;continue;}
case 1242:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1247);}
case 1247:{f.Pc=f.Pop().Int!=0?1262:1250;continue;}
case 1250:{f.Push(f.Locals[6]);f.Pc=1252;continue;}
case 1252:{f.Push(f.Locals[7]);f.Pc=1254;continue;}
case 1254:{return rt.Call(f,"java/util/List","containsAll","(Ljava/util/Collection;)Z","invokeinterface",1259);}
case 1259:{f.Pc=f.Pop().Int!=0?1264:1262;continue;}
case 1262:{f.Push(JValue.I(0));f.Pc=1263;continue;}
case 1263:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1264:{f.Push(f.Locals[0]);f.Pc=1265;continue;}
case 1265:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getLifeTotal","()Ljava/lang/String;","invokevirtual",1268);}
case 1268:{f.Pc=f.Pop().Reference==null?1364:1271;continue;}
case 1271:{f.Push(f.Locals[5]);f.Pc=1273;continue;}
case 1273:{f.Push(f.Locals[0]);f.Pc=1274;continue;}
case 1274:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getLifeTotal","()Ljava/lang/String;","invokevirtual",1277);}
case 1277:{f.Push(f.Locals[1]);f.Pc=1278;continue;}
case 1278:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1281);}
case 1281:{return rt.Call(f,"forge/game/player/PlayerCollection","getFirst","()Ljava/lang/Object;","invokevirtual",1284);}
case 1284:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1287;continue;}
case 1287:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",1290);}
case 1290:{f.Locals[6]=f.Pop();f.Pc=1292;continue;}
case 1292:{f.Push(JValue.I(1));f.Pc=1293;continue;}
case 1293:{f.Locals[7]=f.Pop();f.Pc=1295;continue;}
case 1295:{f.Push(f.Locals[0]);f.Pc=1296;continue;}
case 1296:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getLifeAmount","()Ljava/lang/String;","invokevirtual",1299);}
case 1299:{f.Push(JValue.I(2));f.Pc=1300;continue;}
case 1300:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1303);}
case 1303:{f.Locals[8]=f.Pop();f.Pc=1305;continue;}
case 1305:{f.Push(f.Locals[8]);f.Pc=1307;continue;}
case 1307:{f.Push(JValue.R(rt.String("X")));f.Pc=1310;continue;}
case 1310:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1313);}
case 1313:{f.Pc=f.Pop().Int==0?1335:1316;continue;}
case 1316:{f.Push(f.Locals[5]);f.Pc=1318;continue;}
case 1318:{f.Push(f.Locals[5]);f.Pc=1320;continue;}
case 1320:{f.Push(JValue.R(rt.String("X")));f.Pc=1323;continue;}
case 1323:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1326);}
case 1326:{f.Push(f.Locals[1]);f.Pc=1327;continue;}
case 1327:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1330);}
case 1330:{f.Locals[7]=f.Pop();f.Pc=1332;continue;}
case 1332:{f.Pc=1348;continue;}
case 1335:{f.Push(f.Locals[0]);f.Pc=1336;continue;}
case 1336:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getLifeAmount","()Ljava/lang/String;","invokevirtual",1339);}
case 1339:{f.Push(JValue.I(2));f.Pc=1340;continue;}
case 1340:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1343);}
case 1343:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1346);}
case 1346:{f.Locals[7]=f.Pop();f.Pc=1348;continue;}
case 1348:{f.Push(f.Locals[6]);f.Pc=1350;continue;}
case 1350:{f.Push(f.Locals[0]);f.Pc=1351;continue;}
case 1351:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getLifeAmount","()Ljava/lang/String;","invokevirtual",1354);}
case 1354:{f.Push(f.Locals[7]);f.Pc=1356;continue;}
case 1356:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1359);}
case 1359:{f.Pc=f.Pop().Int!=0?1364:1362;continue;}
case 1362:{f.Push(JValue.I(0));f.Pc=1363;continue;}
case 1363:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1364:{f.Push(f.Locals[0]);f.Pc=1365;continue;}
case 1365:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getTargetValidTargeting","()Ljava/lang/String;","invokevirtual",1368);}
case 1368:{f.Pc=f.Pop().Reference==null?1505:1371;continue;}
case 1371:{f.Push(f.Locals[1]);f.Pc=1372;continue;}
case 1372:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1375);}
case 1375:{f.Locals[6]=f.Pop();f.Pc=1377;continue;}
case 1377:{f.Push(f.Locals[6]);f.Pc=1379;continue;}
case 1379:{f.Pc=f.Pop().Reference==null?1401:1382;continue;}
case 1382:{f.Push(f.Locals[6]);f.Pc=1384;continue;}
case 1384:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedSpell","()Lforge/game/spellability/SpellAbility;","invokevirtual",1387);}
case 1387:{f.Pc=f.Pop().Reference==null?1401:1390;continue;}
case 1390:{f.Push(f.Locals[6]);f.Pc=1392;continue;}
case 1392:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedSpell","()Lforge/game/spellability/SpellAbility;","invokevirtual",1395);}
case 1395:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1398);}
case 1398:{f.Pc=f.Pop().Reference!=null?1403:1401;continue;}
case 1401:{f.Push(JValue.I(0));f.Pc=1402;continue;}
case 1402:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1403:{f.Push(JValue.I(0));f.Pc=1404;continue;}
case 1404:{f.Locals[7]=f.Pop();f.Pc=1406;continue;}
case 1406:{f.Push(f.Locals[6]);f.Pc=1408;continue;}
case 1408:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedSpell","()Lforge/game/spellability/SpellAbility;","invokevirtual",1411);}
case 1411:{f.Locals[8]=f.Pop();f.Pc=1413;continue;}
case 1413:{f.Push(f.Locals[8]);f.Pc=1415;continue;}
case 1415:{f.Pc=f.Pop().Reference==null?1498:1418;continue;}
case 1418:{f.Push(f.Locals[7]);f.Pc=1420;continue;}
case 1420:{f.Pc=f.Pop().Int!=0?1498:1423;continue;}
case 1423:{f.Push(f.Locals[8]);f.Pc=1425;continue;}
case 1425:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1428);}
case 1428:{return rt.Call(f,"forge/game/spellability/TargetChoices","iterator","()Ljava/util/Iterator;","invokevirtual",1431);}
case 1431:{f.Locals[9]=f.Pop();f.Pc=1433;continue;}
case 1433:{f.Push(f.Locals[9]);f.Pc=1435;continue;}
case 1435:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1440);}
case 1440:{f.Pc=f.Pop().Int==0?1488:1443;continue;}
case 1443:{f.Push(f.Locals[9]);f.Pc=1445;continue;}
case 1445:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1450);}
case 1450:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1453;continue;}
case 1453:{f.Locals[10]=f.Pop();f.Pc=1455;continue;}
case 1455:{f.Push(f.Locals[10]);f.Pc=1457;continue;}
case 1457:{f.Push(f.Locals[0]);f.Pc=1458;continue;}
case 1458:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getTargetValidTargeting","()Ljava/lang/String;","invokevirtual",1461);}
case 1461:{f.Push(JValue.R(rt.String(",")));f.Pc=1464;continue;}
case 1464:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1467);}
case 1467:{f.Push(f.Locals[2]);f.Pc=1468;continue;}
case 1468:{f.Push(f.Locals[5]);f.Pc=1470;continue;}
case 1470:{f.Push(f.Locals[1]);f.Pc=1471;continue;}
case 1471:{return rt.Call(f,"forge/game/GameObject","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokeinterface",1476);}
case 1476:{f.Pc=f.Pop().Int==0?1485:1479;continue;}
case 1479:{f.Push(JValue.I(1));f.Pc=1480;continue;}
case 1480:{f.Locals[7]=f.Pop();f.Pc=1482;continue;}
case 1482:{f.Pc=1488;continue;}
case 1485:{f.Pc=1433;continue;}
case 1488:{f.Push(f.Locals[8]);f.Pc=1490;continue;}
case 1490:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",1493);}
case 1493:{f.Locals[8]=f.Pop();f.Pc=1495;continue;}
case 1495:{f.Pc=1413;continue;}
case 1498:{f.Push(f.Locals[7]);f.Pc=1500;continue;}
case 1500:{f.Pc=f.Pop().Int!=0?1505:1503;continue;}
case 1503:{f.Push(JValue.I(0));f.Pc=1504;continue;}
case 1504:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1505:{f.Push(f.Locals[0]);f.Pc=1506;continue;}
case 1506:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","targetsSingleTarget","()Z","invokevirtual",1509);}
case 1509:{f.Pc=f.Pop().Int==0?1629:1512;continue;}
case 1512:{f.Push(f.Locals[1]);f.Pc=1513;continue;}
case 1513:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1516);}
case 1516:{f.Locals[6]=f.Pop();f.Pc=1518;continue;}
case 1518:{f.Push(f.Locals[6]);f.Pc=1520;continue;}
case 1520:{f.Pc=f.Pop().Reference==null?1542:1523;continue;}
case 1523:{f.Push(f.Locals[6]);f.Pc=1525;continue;}
case 1525:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedSpell","()Lforge/game/spellability/SpellAbility;","invokevirtual",1528);}
case 1528:{f.Pc=f.Pop().Reference==null?1542:1531;continue;}
case 1531:{f.Push(f.Locals[6]);f.Pc=1533;continue;}
case 1533:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedSpell","()Lforge/game/spellability/SpellAbility;","invokevirtual",1536);}
case 1536:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1539);}
case 1539:{f.Pc=f.Pop().Reference!=null?1544:1542;continue;}
case 1542:{f.Push(JValue.I(0));f.Pc=1543;continue;}
case 1543:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1544:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=1547;continue;}
case 1547:{f.StackOp("dup");f.Pc=1548;continue;}
case 1548:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",1551);}
case 1551:{f.Locals[7]=f.Pop();f.Pc=1553;continue;}
case 1553:{f.Push(f.Locals[6]);f.Pc=1555;continue;}
case 1555:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedSpell","()Lforge/game/spellability/SpellAbility;","invokevirtual",1558);}
case 1558:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAllTargetChoices","()Ljava/util/List;","invokevirtual",1561);}
case 1561:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1566);}
case 1566:{f.Locals[8]=f.Pop();f.Pc=1568;continue;}
case 1568:{f.Push(f.Locals[8]);f.Pc=1570;continue;}
case 1570:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1575);}
case 1575:{f.Pc=f.Pop().Int==0?1616:1578;continue;}
case 1578:{f.Push(f.Locals[8]);f.Pc=1580;continue;}
case 1580:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1585);}
case 1585:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/TargetChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1588;continue;}
case 1588:{f.Locals[9]=f.Pop();f.Pc=1590;continue;}
case 1590:{f.Push(f.Locals[7]);f.Pc=1592;continue;}
case 1592:{f.Push(f.Locals[9]);f.Pc=1594;continue;}
case 1594:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",1599);}
case 1599:{f.StackOp("pop");f.Pc=1600;continue;}
case 1600:{f.Push(f.Locals[7]);f.Pc=1602;continue;}
case 1602:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",1607);}
case 1607:{f.Push(JValue.I(1));f.Pc=1608;continue;}
case 1608:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1613:1611;continue;}
case 1611:{f.Push(JValue.I(0));f.Pc=1612;continue;}
case 1612:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1613:{f.Pc=1568;continue;}
case 1616:{f.Push(f.Locals[7]);f.Pc=1618;continue;}
case 1618:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",1623);}
case 1623:{f.Push(JValue.I(1));f.Pc=1624;continue;}
case 1624:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?1629:1627;continue;}
case 1627:{f.Push(JValue.I(0));f.Pc=1628;continue;}
case 1628:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1629:{f.Push(f.Locals[0]);f.Pc=1630;continue;}
case 1630:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getManaSpent","()Ljava/lang/String;","invokevirtual",1633);}
case 1633:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",1636);}
case 1636:{f.Pc=f.Pop().Int==0?1682:1639;continue;}
case 1639:{f.Push(f.Locals[5]);f.Pc=1641;continue;}
case 1641:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",1644);}
case 1644:{f.Locals[6]=f.Pop();f.Pc=1646;continue;}
case 1646:{f.Push(f.Locals[6]);f.Pc=1648;continue;}
case 1648:{f.Pc=f.Pop().Reference!=null?1653:1651;continue;}
case 1651:{f.Push(JValue.I(0));f.Pc=1652;continue;}
case 1652:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1653:{f.Push(f.Locals[6]);f.Pc=1655;continue;}
case 1655:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingColors","()Lforge/card/ColorSet;","invokevirtual",1658);}
case 1658:{f.Push(f.Locals[0]);f.Pc=1659;continue;}
case 1659:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getManaSpent","()Ljava/lang/String;","invokevirtual",1662);}
case 1662:{f.Push(JValue.R(rt.String(" ")));f.Pc=1665;continue;}
case 1665:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1668);}
case 1668:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",1671);}
case 1671:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",1674);}
case 1674:{return rt.Call(f,"forge/card/ColorSet","hasAllColors","(I)Z","invokevirtual",1677);}
case 1677:{f.Pc=f.Pop().Int!=0?1682:1680;continue;}
case 1680:{f.Push(JValue.I(0));f.Pc=1681;continue;}
case 1681:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1682:{f.Push(f.Locals[0]);f.Pc=1683;continue;}
case 1683:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getManaNotSpent","()Ljava/lang/String;","invokevirtual",1686);}
case 1686:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",1689);}
case 1689:{f.Pc=f.Pop().Int==0?1733:1692;continue;}
case 1692:{f.Push(f.Locals[5]);f.Pc=1694;continue;}
case 1694:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",1697);}
case 1697:{f.Locals[6]=f.Pop();f.Pc=1699;continue;}
case 1699:{f.Push(f.Locals[6]);f.Pc=1701;continue;}
case 1701:{f.Pc=f.Pop().Reference==null?1733:1704;continue;}
case 1704:{f.Push(f.Locals[6]);f.Pc=1706;continue;}
case 1706:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingColors","()Lforge/card/ColorSet;","invokevirtual",1709);}
case 1709:{f.Push(f.Locals[0]);f.Pc=1710;continue;}
case 1710:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getManaNotSpent","()Ljava/lang/String;","invokevirtual",1713);}
case 1713:{f.Push(JValue.R(rt.String(" ")));f.Pc=1716;continue;}
case 1716:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1719);}
case 1719:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",1722);}
case 1722:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",1725);}
case 1725:{return rt.Call(f,"forge/card/ColorSet","hasAllColors","(I)Z","invokevirtual",1728);}
case 1728:{f.Pc=f.Pop().Int==0?1733:1731;continue;}
case 1731:{f.Push(JValue.I(0));f.Pc=1732;continue;}
case 1732:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1733:{f.Push(f.Locals[0]);f.Pc=1734;continue;}
case 1734:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getsVarToCheck","()Ljava/lang/String;","invokevirtual",1737);}
case 1737:{f.Pc=f.Pop().Reference==null?1836:1740;continue;}
case 1740:{f.Push(f.Locals[5]);f.Pc=1742;continue;}
case 1742:{f.Push(f.Locals[0]);f.Pc=1743;continue;}
case 1743:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getsVarToCheck","()Ljava/lang/String;","invokevirtual",1746);}
case 1746:{f.Push(f.Locals[1]);f.Pc=1747;continue;}
case 1747:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1750);}
case 1750:{f.Locals[6]=f.Pop();f.Pc=1752;continue;}
case 1752:{f.Push(f.Locals[5]);f.Pc=1754;continue;}
case 1754:{f.Push(f.Locals[0]);f.Pc=1755;continue;}
case 1755:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getsVarOperand","()Ljava/lang/String;","invokevirtual",1758);}
case 1758:{f.Push(f.Locals[1]);f.Pc=1759;continue;}
case 1759:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1762);}
case 1762:{f.Locals[7]=f.Pop();f.Pc=1764;continue;}
case 1764:{f.Push(JValue.I(0));f.Pc=1765;continue;}
case 1765:{f.Locals[8]=f.Pop();f.Pc=1767;continue;}
case 1767:{f.Push(f.Locals[0]);f.Pc=1768;continue;}
case 1768:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getsVarToCheck2","()Ljava/lang/String;","invokevirtual",1771);}
case 1771:{f.Pc=f.Pop().Reference==null?1815:1774;continue;}
case 1774:{f.Push(f.Locals[5]);f.Pc=1776;continue;}
case 1776:{f.Push(f.Locals[0]);f.Pc=1777;continue;}
case 1777:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getsVarToCheck2","()Ljava/lang/String;","invokevirtual",1780);}
case 1780:{f.Push(f.Locals[1]);f.Pc=1781;continue;}
case 1781:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1784);}
case 1784:{f.Locals[9]=f.Pop();f.Pc=1786;continue;}
case 1786:{f.Push(f.Locals[5]);f.Pc=1788;continue;}
case 1788:{f.Push(f.Locals[0]);f.Pc=1789;continue;}
case 1789:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getsVarOperand2","()Ljava/lang/String;","invokevirtual",1792);}
case 1792:{f.Push(f.Locals[1]);f.Pc=1793;continue;}
case 1793:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1796);}
case 1796:{f.Locals[10]=f.Pop();f.Pc=1798;continue;}
case 1798:{f.Push(f.Locals[9]);f.Pc=1800;continue;}
case 1800:{f.Push(f.Locals[0]);f.Pc=1801;continue;}
case 1801:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getsVarOperator2","()Ljava/lang/String;","invokevirtual",1804);}
case 1804:{f.Push(f.Locals[10]);f.Pc=1806;continue;}
case 1806:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1809);}
case 1809:{f.Pc=f.Pop().Int==0?1815:1812;continue;}
case 1812:{f.Push(JValue.I(1));f.Pc=1813;continue;}
case 1813:{f.Locals[8]=f.Pop();f.Pc=1815;continue;}
case 1815:{f.Push(f.Locals[6]);f.Pc=1817;continue;}
case 1817:{f.Push(f.Locals[0]);f.Pc=1818;continue;}
case 1818:{return rt.Call(f,"forge/game/spellability/SpellAbilityCondition","getsVarOperator","()Ljava/lang/String;","invokevirtual",1821);}
case 1821:{f.Push(f.Locals[7]);f.Pc=1823;continue;}
case 1823:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1826);}
case 1826:{f.Pc=f.Pop().Int!=0?1836:1829;continue;}
case 1829:{f.Push(f.Locals[8]);f.Pc=1831;continue;}
case 1831:{f.Pc=f.Pop().Int!=0?1836:1834;continue;}
case 1834:{f.Push(JValue.I(0));f.Pc=1835;continue;}
case 1835:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1836:{f.Push(JValue.I(1));f.Pc=1837;continue;}
case 1837:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

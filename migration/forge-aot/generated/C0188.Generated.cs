// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C188{
internal static JClass Build(){var c=new JClass("forge/game/ability/SpellAbilityEffect$1","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("val$hostCard","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("val$triggerList","Lforge/game/card/CardZoneTable;",false,JValue.Default("Lforge/game/card/CardZoneTable;"),null));
c.Add(new JField("val$sa","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("val$lki","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$trigHandler","Lforge/game/trigger/TriggerHandler;",false,JValue.Default("Lforge/game/trigger/TriggerHandler;"),null));
c.Add(new JMethod(2982,"forge/game/ability/SpellAbilityEffect$1","<init>","(Lforge/game/card/Card;Lforge/game/Game;Lforge/game/card/CardZoneTable;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/trigger/TriggerHandler;)V",0,7,2,new JHandler[]{},M2982));
c.Add(new JMethod(2983,"forge/game/ability/SpellAbilityEffect$1","run","()V",1,12,6,new JHandler[]{},M2983));
}

internal static JStep M2982(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$hostCard","Lforge/game/card/Card;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$game","Lforge/game/Game;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$triggerList","Lforge/game/card/CardZoneTable;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$sa","Lforge/game/spellability/SpellAbility;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[5]);f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$lki","Lforge/game/card/Card;",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[6]);f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$trigHandler","Lforge/game/trigger/TriggerHandler;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",37);}
case 37:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2983(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$hostCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","getUntilLeavesBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?18:17;continue;}
case 17:{return JStep.ReturnVoid;}
case 18:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$game","Lforge/game/Game;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/Game","copyLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",33);}
case 33:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",38);}
case 38:{f.StackOp("pop");f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$game","Lforge/game/Game;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/Game","copyLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",50);}
case 50:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$triggerList","Lforge/game/card/CardZoneTable;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/CardZoneTable","cellSet","()Ljava/util/Set;","invokevirtual",63);}
case 63:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",68);}
case 68:{f.Locals[3]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",75);}
case 75:{f.Pc=f.Pop().Int==0?412:78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",84);}
case 84:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table$Cell"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=87;continue;}
case 87:{f.Locals[4]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",96);}
case 96:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",102);}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",111);}
case 111:{f.Pc=f.Pop().Int==0?409:114;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",121);}
case 121:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=124;continue;}
case 124:{f.Locals[6]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[6]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",134);}
case 134:{f.Pc=f.Pop().Int!=0?140:137;continue;}
case 137:{f.Pc=104;continue;}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$game","Lforge/game/Game;"));f.Pc=144;continue;}
case 144:{f.Push(f.Locals[6]);f.Pc=146;continue;}
case 146:{f.Push(JValue.R(null));f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",150);}
case 150:{f.Locals[7]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[7]);f.Pc=154;continue;}
case 154:{f.Pc=f.Pop().Reference==null?104:157;continue;}
case 157:{f.Push(f.Locals[7]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[6]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int!=0?170:167;continue;}
case 167:{f.Pc=104;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$sa","Lforge/game/spellability/SpellAbility;"));f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("ReturnAbility")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasAdditionalAbility","(Ljava/lang/String;)Z","invokevirtual",179);}
case 179:{f.Pc=f.Pop().Int==0?346:182;continue;}
case 182:{f.Push(f.Locals[0]);f.Pc=183;continue;}
case 183:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$sa","Lforge/game/spellability/SpellAbility;"));f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("ReturnValid")));f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String("Card.IsTriggerRemembered")));f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",193);}
case 193:{f.Locals[8]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[4]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",202);}
case 202:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",205);}
case 205:{f.Push(f.Locals[4]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",212);}
case 212:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",215);}
case 215:{f.Push(f.Locals[8]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[0]);f.Pc=218;continue;}
case 218:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$sa","Lforge/game/spellability/SpellAbility;"));f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String("ReturnAbility")));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",226);}
case 226:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",231);}
case 231:{return rt.DynamicCall(f,"forge/game/ability/SpellAbilityEffect$1:2983:231:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",236);}
case 236:{f.Locals[9]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[9]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[0]);f.Pc=241;continue;}
case 241:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$hostCard","Lforge/game/card/Card;"));f.Pc=244;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$sa","Lforge/game/spellability/SpellAbility;"));f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",251);}
case 251:{f.Push(JValue.R(null));f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;","invokestatic",255);}
case 255:{f.Locals[10]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[10]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[0]);f.Pc=260;continue;}
case 260:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$sa","Lforge/game/spellability/SpellAbility;"));f.Pc=263;continue;}
case 263:{f.Push(f.Locals[0]);f.Pc=264;continue;}
case 264:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$lki","Lforge/game/card/Card;"));f.Pc=267;continue;}
case 267:{f.Push(JValue.I(1));f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",271);}
case 271:{return rt.Call(f,"forge/game/trigger/Trigger","setSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",274);}
case 274:{f.Push(f.Locals[10]);f.Pc=276;continue;}
case 276:{f.Push(JValue.R(null));f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/trigger/Trigger","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",280);}
case 280:{f.Push(f.Locals[10]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[7]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/trigger/Trigger","addRemembered","(Ljava/lang/Object;)V","invokevirtual",287);}
case 287:{f.Push(f.Locals[0]);f.Pc=288;continue;}
case 288:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$sa","Lforge/game/spellability/SpellAbility;"));f.Pc=291;continue;}
case 291:{f.Push(JValue.R(rt.String("ReturnAbility")));f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",296);}
case 296:{f.Push(f.Locals[0]);f.Pc=297;continue;}
case 297:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$hostCard","Lforge/game/card/Card;"));f.Pc=300;continue;}
case 300:{f.Push(f.Locals[0]);f.Pc=301;continue;}
case 301:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$sa","Lforge/game/spellability/SpellAbility;"));f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",307);}
case 307:{f.Push(JValue.I(0));f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",311);}
case 311:{f.Locals[11]=f.Pop();f.Pc=313;continue;}
case 313:{f.Push(f.Locals[11]);f.Pc=315;continue;}
case 315:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=318;continue;}
case 318:{f.Pc=f.Pop().Int==0?330:321;continue;}
case 321:{f.Push(f.Locals[11]);f.Pc=323;continue;}
case 323:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=326;continue;}
case 326:{f.Push(JValue.R(null));f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/spellability/AbilitySub","setParent","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",330);}
case 330:{f.Push(f.Locals[10]);f.Pc=332;continue;}
case 332:{f.Push(f.Locals[11]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",337);}
case 337:{f.Push(f.Locals[0]);f.Pc=338;continue;}
case 338:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$trigHandler","Lforge/game/trigger/TriggerHandler;"));f.Pc=341;continue;}
case 341:{f.Push(f.Locals[10]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerThisTurnDelayedTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",346);}
case 346:{f.Push(f.Locals[0]);f.Pc=347;continue;}
case 347:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$game","Lforge/game/Game;"));f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",353);}
case 353:{f.Push(f.Locals[4]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",360);}
case 360:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=363;continue;}
case 363:{f.Push(f.Locals[7]);f.Pc=365;continue;}
case 365:{f.Push(JValue.I(0));f.Pc=366;continue;}
case 366:{f.Push(JValue.R(null));f.Pc=367;continue;}
case 367:{f.Push(f.Locals[2]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",371);}
case 371:{f.Locals[8]=f.Pop();f.Pc=373;continue;}
case 373:{f.Push(f.Locals[0]);f.Pc=374;continue;}
case 374:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/SpellAbilityEffect$1","val$game","Lforge/game/Game;"));f.Pc=377;continue;}
case 377:{return rt.Call(f,"forge/game/Game","getUntilHostLeavesPlayTriggerList","()Lforge/game/card/CardZoneTable;","invokevirtual",380);}
case 380:{f.Push(f.Locals[4]);f.Pc=382;continue;}
case 382:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",387);}
case 387:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=390;continue;}
case 390:{f.Push(f.Locals[4]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",397);}
case 397:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=400;continue;}
case 400:{f.Push(f.Locals[8]);f.Pc=402;continue;}
case 402:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",405);}
case 405:{f.StackOp("pop");f.Pc=406;continue;}
case 406:{f.Pc=104;continue;}
case 409:{f.Pc=69;continue;}
case 412:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

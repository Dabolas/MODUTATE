// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C283{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DelayedTriggerEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3313,"forge/game/ability/effects/DelayedTriggerEffect","<init>","()V",1,1,1,new JHandler[]{},M3313));
c.Add(new JMethod(3314,"forge/game/ability/effects/DelayedTriggerEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,2,new JHandler[]{},M3314));
c.Add(new JMethod(3315,"forge/game/ability/effects/DelayedTriggerEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,8,5,new JHandler[]{},M3315));
c.Add(new JMethod(3316,"forge/game/ability/effects/DelayedTriggerEffect","$deserializeLambda$","(Ljava/lang/invoke/SerializedLambda;)Ljava/lang/Object;",4106,3,3,new JHandler[]{},M3316));
c.Add(new JMethod(3317,"forge/game/ability/effects/DelayedTriggerEffect","lambda$resolve$cbde8fee$2","(Lforge/game/trigger/TriggerHandler;Lforge/game/trigger/Trigger;)V",4106,2,2,new JHandler[]{},M3317));
c.Add(new JMethod(3318,"forge/game/ability/effects/DelayedTriggerEffect","lambda$resolve$cbde8fee$1","(Lforge/game/trigger/TriggerHandler;Lforge/game/trigger/Trigger;)V",4106,2,2,new JHandler[]{},M3318));
}

internal static JStep M3313(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3314(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?16:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?32:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
case 32:{f.Push(JValue.R(rt.String("")));f.Pc=34;continue;}
case 34:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3315(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",14);}
case 14:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?65:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int!=0?65:43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("Cost")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",92);}
case 92:{f.Push(JValue.R(null));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/util/Map;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;","invokestatic",96);}
case 96:{f.Locals[5]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Push(JValue.I(1));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",106);}
case 106:{return rt.Call(f,"forge/game/trigger/Trigger","setSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",109);}
case 109:{f.Push(f.Locals[5]);f.Pc=111;continue;}
case 111:{f.Push(JValue.R(null));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/trigger/Trigger","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",115);}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?145:124;continue;}
case 124:{f.Push(f.Locals[5]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",133);}
case 133:{f.Push(JValue.R(rt.String(" & ")));f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",138);}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;[Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",142);}
case 142:{return rt.Call(f,"forge/game/trigger/Trigger","addRemembered","(Ljava/util/Collection;)V","invokevirtual",145);}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("RememberNumber")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",151);}
case 151:{f.Pc=f.Pop().Int==0?202:154;continue;}
case 154:{f.Push(f.Locals[2]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",158);}
case 158:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",163);}
case 163:{f.Locals[6]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[6]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",172);}
case 172:{f.Pc=f.Pop().Int==0?202:175;continue;}
case 175:{f.Push(f.Locals[6]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",182);}
case 182:{f.Locals[7]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[7]);f.Pc=186;continue;}
case 186:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/Integer")?1:0));f.Pc=189;continue;}
case 189:{f.Pc=f.Pop().Int==0?199:192;continue;}
case 192:{f.Push(f.Locals[5]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[7]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/trigger/Trigger","addRemembered","(Ljava/lang/Object;)V","invokevirtual",199);}
case 199:{f.Pc=165;continue;}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.String("RememberSVarAmount")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",208);}
case 208:{f.Pc=f.Pop().Int==0?234:211;continue;}
case 211:{f.Push(f.Locals[5]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[2]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[1]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[1]);f.Pc=216;continue;}
case 216:{f.Push(JValue.R(rt.String("RememberSVarAmount")));f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",221);}
case 221:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",224);}
case 224:{f.Push(f.Locals[1]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",228);}
case 228:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",231);}
case 231:{return rt.Call(f,"forge/game/trigger/Trigger","addRemembered","(Ljava/lang/Object;)V","invokevirtual",234);}
case 234:{f.Push(f.Locals[1]);f.Pc=235;continue;}
case 235:{f.Push(JValue.R(rt.String("Execute")));f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasAdditionalAbility","(Ljava/lang/String;)Z","invokevirtual",240);}
case 240:{f.Pc=f.Pop().Int==0?309:243;continue;}
case 243:{f.Push(f.Locals[1]);f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.String("Execute")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",249);}
case 249:{f.Push(f.Locals[2]);f.Pc=250;continue;}
case 250:{f.Push(f.Locals[1]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",254);}
case 254:{f.Push(JValue.I(0));f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",258);}
case 258:{f.Locals[6]=f.Pop();f.Pc=260;continue;}
case 260:{f.Push(f.Locals[6]);f.Pc=262;continue;}
case 262:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=265;continue;}
case 265:{f.Pc=f.Pop().Int==0?277:268;continue;}
case 268:{f.Push(f.Locals[6]);f.Pc=270;continue;}
case 270:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=273;continue;}
case 273:{f.Push(JValue.R(null));f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/spellability/AbilitySub","setParent","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",277);}
case 277:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","SetState","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","SetState","Lforge/game/ability/ApiType;"));f.Pc=280;continue;}
case 280:{f.Push(f.Locals[6]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",285);}
case 285:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?302:288;continue;}
case 288:{f.Push(f.Locals[6]);f.Pc=290;continue;}
case 290:{f.Push(JValue.R(rt.String("StoredTransform")));f.Pc=292;continue;}
case 292:{f.Push(f.Locals[2]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/card/Card","getTransformedTimestamp","()J","invokevirtual",296);}
case 296:{return rt.Call(f,"java/lang/String","valueOf","(J)Ljava/lang/String;","invokestatic",299);}
case 299:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",302);}
case 302:{f.Push(f.Locals[5]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[6]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",309);}
case 309:{f.Push(f.Locals[3]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",313);}
case 313:{f.Locals[6]=f.Pop();f.Pc=315;continue;}
case 315:{f.Push(f.Locals[4]);f.Pc=317;continue;}
case 317:{f.Push(JValue.R(rt.String("DelayedTriggerDefinedPlayer")));f.Pc=319;continue;}
case 319:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",324);}
case 324:{f.Pc=f.Pop().Int==0?365:327;continue;}
case 327:{f.Push(f.Locals[2]);f.Pc=328;continue;}
case 328:{f.Push(f.Locals[4]);f.Pc=330;continue;}
case 330:{f.Push(JValue.R(rt.String("DelayedTriggerDefinedPlayer")));f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",337);}
case 337:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=340;continue;}
case 340:{f.Push(f.Locals[1]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",344);}
case 344:{f.Push(JValue.R(null));f.Pc=345;continue;}
case 345:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",348);}
case 348:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=351;continue;}
case 351:{f.Locals[7]=f.Pop();f.Pc=353;continue;}
case 353:{f.Push(f.Locals[6]);f.Pc=355;continue;}
case 355:{f.Push(f.Locals[7]);f.Pc=357;continue;}
case 357:{f.Push(f.Locals[5]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerPlayerDefinedDelayedTrigger","(Lforge/game/player/Player;Lforge/game/trigger/Trigger;)V","invokevirtual",362);}
case 362:{f.Pc=456;continue;}
case 365:{f.Push(f.Locals[4]);f.Pc=367;continue;}
case 367:{f.Push(JValue.R(rt.String("ThisTurn")));f.Pc=369;continue;}
case 369:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",374);}
case 374:{f.Pc=f.Pop().Int==0?387:377;continue;}
case 377:{f.Push(f.Locals[6]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[5]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerThisTurnDelayedTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",384);}
case 384:{f.Pc=456;continue;}
case 387:{f.Push(f.Locals[4]);f.Pc=389;continue;}
case 389:{f.Push(JValue.R(rt.String("NextTurn")));f.Pc=391;continue;}
case 391:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",396);}
case 396:{f.Pc=f.Pop().Int==0?418:399;continue;}
case 399:{f.Push(f.Locals[3]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"forge/game/Game","getCleanup","()Lforge/game/phase/Phase;","invokevirtual",403);}
case 403:{f.Push(f.Locals[6]);f.Pc=405;continue;}
case 405:{f.Push(f.Locals[5]);f.Pc=407;continue;}
case 407:{return rt.DynamicCall(f,"forge/game/ability/effects/DelayedTriggerEffect:3315:407:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/trigger/TriggerHandler;Lforge/game/trigger/Trigger;)Lforge/GameCommand;",412);}
case 412:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",415);}
case 415:{f.Pc=456;continue;}
case 418:{f.Push(f.Locals[4]);f.Pc=420;continue;}
case 420:{f.Push(JValue.R(rt.String("UpcomingTurn")));f.Pc=422;continue;}
case 422:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",427);}
case 427:{f.Pc=f.Pop().Int==0?449:430;continue;}
case 430:{f.Push(f.Locals[3]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/Game","getCleanup","()Lforge/game/phase/Phase;","invokevirtual",434);}
case 434:{f.Push(f.Locals[6]);f.Pc=436;continue;}
case 436:{f.Push(f.Locals[5]);f.Pc=438;continue;}
case 438:{return rt.DynamicCall(f,"forge/game/ability/effects/DelayedTriggerEffect:3315:438:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/trigger/TriggerHandler;Lforge/game/trigger/Trigger;)Lforge/GameCommand;",443);}
case 443:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",446);}
case 446:{f.Pc=456;continue;}
case 449:{f.Push(f.Locals[6]);f.Pc=451;continue;}
case 451:{f.Push(f.Locals[5]);f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerDelayedTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",456);}
case 456:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3316(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",11);}
case 11:{switch(f.Pop().Int){case -538315728:f.Pc=50;break;case -538315727:f.Pc=36;break;default:f.Pc=62;break;}continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("lambda$resolve$cbde8fee$2")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?62:45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Locals[2]=f.Pop();f.Pc=47;continue;}
case 47:{f.Pc=62;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("lambda$resolve$cbde8fee$1")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?62:60;continue;}
case 60:{f.Push(JValue.I(1));f.Pc=61;continue;}
case 61:{f.Locals[2]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{switch(f.Pop().Int){case 0:f.Pc=88;break;case 1:f.Pc=184;break;default:f.Pc=280;break;}continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",92);}
case 92:{f.Push(JValue.I(6));f.Pc=94;continue;}
case 94:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?280:97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",101);}
case 101:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?280:110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",114);}
case 114:{f.Push(JValue.R(rt.String("run")));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?280:123;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",127);}
case 127:{f.Push(JValue.R(rt.String("()V")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",133);}
case 133:{f.Pc=f.Pop().Int==0?280:136;continue;}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",140);}
case 140:{f.Push(JValue.R(rt.String("forge/game/ability/effects/DelayedTriggerEffect")));f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int==0?280:149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",153);}
case 153:{f.Push(JValue.R(rt.String("(Lforge/game/trigger/TriggerHandler;Lforge/game/trigger/Trigger;)V")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int==0?280:162;continue;}
case 162:{f.Push(f.Locals[0]);f.Pc=163;continue;}
case 163:{f.Push(JValue.I(0));f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",167);}
case 167:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/TriggerHandler"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(JValue.I(1));f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",175);}
case 175:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=178;continue;}
case 178:{return rt.DynamicCall(f,"forge/game/ability/effects/DelayedTriggerEffect:3316:178:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/trigger/TriggerHandler;Lforge/game/trigger/Trigger;)Lforge/GameCommand;",183);}
case 183:{return JStep.Return(f.Pop());}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",188);}
case 188:{f.Push(JValue.I(6));f.Pc=190;continue;}
case 190:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?280:193;continue;}
case 193:{f.Push(f.Locals[0]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",197);}
case 197:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",203);}
case 203:{f.Pc=f.Pop().Int==0?280:206;continue;}
case 206:{f.Push(f.Locals[0]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",210);}
case 210:{f.Push(JValue.R(rt.String("run")));f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",216);}
case 216:{f.Pc=f.Pop().Int==0?280:219;continue;}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",223);}
case 223:{f.Push(JValue.R(rt.String("()V")));f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",229);}
case 229:{f.Pc=f.Pop().Int==0?280:232;continue;}
case 232:{f.Push(f.Locals[0]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",236);}
case 236:{f.Push(JValue.R(rt.String("forge/game/ability/effects/DelayedTriggerEffect")));f.Pc=239;continue;}
case 239:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",242);}
case 242:{f.Pc=f.Pop().Int==0?280:245;continue;}
case 245:{f.Push(f.Locals[0]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",249);}
case 249:{f.Push(JValue.R(rt.String("(Lforge/game/trigger/TriggerHandler;Lforge/game/trigger/Trigger;)V")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",255);}
case 255:{f.Pc=f.Pop().Int==0?280:258;continue;}
case 258:{f.Push(f.Locals[0]);f.Pc=259;continue;}
case 259:{f.Push(JValue.I(0));f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",263);}
case 263:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/TriggerHandler"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[0]);f.Pc=267;continue;}
case 267:{f.Push(JValue.I(1));f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",271);}
case 271:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=274;continue;}
case 274:{return rt.DynamicCall(f,"forge/game/ability/effects/DelayedTriggerEffect:3316:274:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/trigger/TriggerHandler;Lforge/game/trigger/Trigger;)Lforge/GameCommand;",279);}
case 279:{return JStep.Return(f.Pop());}
case 280:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=283;continue;}
case 283:{f.StackOp("dup");f.Pc=284;continue;}
case 284:{f.Push(JValue.R(rt.String("Invalid lambda deserialization")));f.Pc=287;continue;}
case 287:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",290);}
case 290:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3317(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerDelayedTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3318(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerThisTurnDelayedTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",5);}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

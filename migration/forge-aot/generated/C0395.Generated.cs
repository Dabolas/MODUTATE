// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C395{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/SacrificeEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3705,"forge/game/ability/effects/SacrificeEffect","<init>","()V",1,1,1,new JHandler[]{},M3705));
c.Add(new JMethod(3706,"forge/game/ability/effects/SacrificeEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,26,9,new JHandler[]{},M3706));
c.Add(new JMethod(3707,"forge/game/ability/effects/SacrificeEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,15,3,new JHandler[]{},M3707));
c.Add(new JMethod(3708,"forge/game/ability/effects/SacrificeEffect","removeCandidates","(Lforge/game/card/CardCollection;Ljava/util/List;Ljava/util/Set;III)V",2,9,7,new JHandler[]{},M3708));
c.Add(new JMethod(3709,"forge/game/ability/effects/SacrificeEffect","lambda$getStackDescription$1","(Ljava/util/regex/MatchResult;)Ljava/lang/String;",4106,1,1,new JHandler[]{},M3709));
c.Add(new JMethod(3710,"forge/game/ability/effects/SacrificeEffect","lambda$resolve$0","(Lforge/game/card/CardZoneTable;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M3710));
}

internal static JStep M3705(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3706(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Echo")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?160:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("You may pay 0 rather than pay the echo cost for permanents you control.")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/player/Player","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?70:34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",38);}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(null));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",43);}
case 43:{f.Push(JValue.R(rt.String("lblDoYouWantPayEcho")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",52);}
case 52:{return rt.DynamicCall(f,"forge/game/ability/effects/SacrificeEffect:3706:52:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",57);}
case 57:{f.Push(JValue.R(null));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?70:64;continue;}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{f.Locals[5]=f.Pop();f.Pc=67;continue;}
case 67:{f.Pc=103;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",74);}
case 74:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("Echo")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",84);}
case 84:{f.Push(JValue.I(1));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",88);}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(JValue.I(0));f.Pc=90;continue;}
case 90:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=93;continue;}
case 93:{f.StackOp("dup");f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","(Lforge/game/player/Player;)V","invokespecial",98);}
case 98:{return rt.Call(f,"forge/game/player/PlayerController","payCostToPreventEffect","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;ZLforge/util/collect/FCollectionView;)Z","invokevirtual",101);}
case 101:{f.Locals[5]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[4]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",108);}
case 108:{f.Locals[6]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[6]);f.Pc=112;continue;}
case 112:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","EchoPaid","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","EchoPaid","Lforge/game/ability/AbilityKey;"));f.Pc=115;continue;}
case 115:{f.Push(f.Locals[5]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",120);}
case 120:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",125);}
case 125:{f.StackOp("pop");f.Pc=126;continue;}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",130);}
case 130:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","PayEcho","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","PayEcho","Lforge/game/trigger/TriggerType;"));f.Pc=133;continue;}
case 133:{f.Push(f.Locals[6]);f.Pc=135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",139);}
case 139:{f.Push(f.Locals[5]);f.Pc=141;continue;}
case 141:{f.Pc=f.Pop().Int!=0?156:144;continue;}
case 144:{f.Push(f.Locals[4]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",149);}
case 149:{f.Push(f.Locals[2]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int!=0?157:156;continue;}
case 156:{return JStep.ReturnVoid;}
case 157:{f.Pc=352;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{f.Push(JValue.R(rt.String("CumulativeUpkeep")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",166);}
case 166:{f.Pc=f.Pop().Int==0?352:169;continue;}
case 169:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=172;continue;}
case 172:{f.StackOp("dup");f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",176);}
case 176:{f.Locals[5]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[4]);f.Pc=180;continue;}
case 180:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","AGE","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","AGE","Lforge/game/card/CounterEnumType;"));f.Pc=183;continue;}
case 183:{f.Push(JValue.I(1));f.Pc=184;continue;}
case 184:{f.Push(f.Locals[2]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[5]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",190);}
case 190:{f.Push(f.Locals[5]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[3]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[1]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",197);}
case 197:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=200;continue;}
case 200:{f.StackOp("dup");f.Pc=201;continue;}
case 201:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"));f.Pc=204;continue;}
case 204:{f.Push(JValue.I(1));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",208);}
case 208:{f.Locals[6]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[4]);f.Pc=212;continue;}
case 212:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","AGE","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","AGE","Lforge/game/card/CounterEnumType;"));f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",218);}
case 218:{f.Locals[7]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(f.Locals[7]);f.Pc=222;continue;}
case 222:{f.Pc=f.Pop().Int<=0?251:225;continue;}
case 225:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=228;continue;}
case 228:{f.StackOp("dup");f.Pc=229;continue;}
case 229:{f.Push(f.Locals[1]);f.Pc=230;continue;}
case 230:{f.Push(JValue.R(rt.String("CumulativeUpkeep")));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",235);}
case 235:{f.Push(JValue.I(1));f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",239);}
case 239:{f.Locals[8]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[6]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[8]);f.Pc=245;continue;}
case 245:{f.Push(f.Locals[7]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[1]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/cost/Cost","mergeTo","(Lforge/game/cost/Cost;ILforge/game/spellability/SpellAbility;)V","invokevirtual",251);}
case 251:{f.Push(f.Locals[3]);f.Pc=252;continue;}
case 252:{f.Push(f.Locals[4]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",257);}
case 257:{f.Push(f.Locals[2]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",261);}
case 261:{f.Push(f.Locals[6]);f.Pc=263;continue;}
case 263:{f.Push(f.Locals[1]);f.Pc=264;continue;}
case 264:{f.Push(JValue.I(0));f.Pc=265;continue;}
case 265:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=268;continue;}
case 268:{f.StackOp("dup");f.Pc=269;continue;}
case 269:{f.Push(f.Locals[2]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","(Lforge/game/player/Player;)V","invokespecial",273);}
case 273:{return rt.Call(f,"forge/game/player/PlayerController","payCostToPreventEffect","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;ZLforge/util/collect/FCollectionView;)Z","invokevirtual",276);}
case 276:{f.Locals[8]=f.Pop();f.Pc=278;continue;}
case 278:{f.Push(f.Locals[4]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",283);}
case 283:{f.Locals[9]=f.Pop();f.Pc=285;continue;}
case 285:{f.Push(f.Locals[9]);f.Pc=287;continue;}
case 287:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CumulativeUpkeepPaid","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CumulativeUpkeepPaid","Lforge/game/ability/AbilityKey;"));f.Pc=290;continue;}
case 290:{f.Push(f.Locals[8]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",295);}
case 295:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",300);}
case 300:{f.StackOp("pop");f.Pc=301;continue;}
case 301:{f.Push(f.Locals[9]);f.Pc=303;continue;}
case 303:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","PayingMana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","PayingMana","Lforge/game/ability/AbilityKey;"));f.Pc=306;continue;}
case 306:{f.Push(f.Locals[1]);f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",310);}
case 310:{f.Push(JValue.R(rt.String("")));f.Pc=312;continue;}
case 312:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",315);}
case 315:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",320);}
case 320:{f.StackOp("pop");f.Pc=321;continue;}
case 321:{f.Push(f.Locals[3]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",325);}
case 325:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","PayCumulativeUpkeep","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","PayCumulativeUpkeep","Lforge/game/trigger/TriggerType;"));f.Pc=328;continue;}
case 328:{f.Push(f.Locals[9]);f.Pc=330;continue;}
case 330:{f.Push(JValue.I(0));f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",334);}
case 334:{f.Push(f.Locals[8]);f.Pc=336;continue;}
case 336:{f.Pc=f.Pop().Int!=0?351:339;continue;}
case 339:{f.Push(f.Locals[4]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",344);}
case 344:{f.Push(f.Locals[2]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",348);}
case 348:{f.Pc=f.Pop().Int!=0?352:351;continue;}
case 351:{return JStep.ReturnVoid;}
case 352:{f.Push(f.Locals[4]);f.Pc=354;continue;}
case 354:{f.Push(f.Locals[1]);f.Pc=355;continue;}
case 355:{f.Push(JValue.R(rt.String("Amount")));f.Pc=357;continue;}
case 357:{f.Push(JValue.R(rt.String("1")));f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",362);}
case 362:{f.Push(f.Locals[1]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",366);}
case 366:{f.Locals[5]=f.Pop();f.Pc=368;continue;}
case 368:{f.Push(f.Locals[1]);f.Pc=369;continue;}
case 369:{f.Push(JValue.R(rt.String("SacEachValid")));f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",374);}
case 374:{f.Locals[6]=f.Pop();f.Pc=376;continue;}
case 376:{f.Push(f.Locals[1]);f.Pc=377;continue;}
case 377:{f.Push(JValue.R(rt.String("SacValid")));f.Pc=379;continue;}
case 379:{f.Push(JValue.R(rt.String("Self")));f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",384);}
case 384:{f.Locals[7]=f.Pop();f.Pc=386;continue;}
case 386:{f.Push(f.Locals[1]);f.Pc=387;continue;}
case 387:{f.Push(JValue.R(rt.String("SacMessage")));f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",392);}
case 392:{f.Pc=f.Pop().Int==0?406:395;continue;}
case 395:{f.Push(f.Locals[1]);f.Pc=396;continue;}
case 396:{f.Push(JValue.R(rt.String("SacMessage")));f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",401);}
case 401:{f.Locals[8]=f.Pop();f.Pc=403;continue;}
case 403:{f.Pc=425;continue;}
case 406:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",409);}
case 409:{f.Push(f.Locals[7]);f.Pc=411;continue;}
case 411:{f.Push(JValue.R(rt.String(",")));f.Pc=413;continue;}
case 413:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",416);}
case 416:{return rt.Call(f,"java/util/List","of","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",419);}
case 419:{f.Push(JValue.I(0));f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/util/Lang","buildValidDesc","(Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",423);}
case 423:{f.Locals[8]=f.Pop();f.Pc=425;continue;}
case 425:{f.Push(f.Locals[1]);f.Pc=426;continue;}
case 426:{f.Push(JValue.R(rt.String("Destroy")));f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",431);}
case 431:{f.Locals[9]=f.Pop();f.Pc=433;continue;}
case 433:{f.Push(f.Locals[1]);f.Pc=434;continue;}
case 434:{f.Push(JValue.R(rt.String("RememberSacrificed")));f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",439);}
case 439:{f.Locals[10]=f.Pop();f.Pc=441;continue;}
case 441:{f.Push(f.Locals[1]);f.Pc=442;continue;}
case 442:{f.Push(JValue.R(rt.String("Optional")));f.Pc=444;continue;}
case 444:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",447);}
case 447:{f.Locals[11]=f.Pop();f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",452);}
case 452:{f.Locals[12]=f.Pop();f.Pc=454;continue;}
case 454:{f.Push(f.Locals[12]);f.Pc=456;continue;}
case 456:{f.Push(f.Locals[1]);f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",460);}
case 460:{f.Locals[13]=f.Pop();f.Pc=462;continue;}
case 462:{f.Push(f.Locals[7]);f.Pc=464;continue;}
case 464:{f.Push(JValue.R(rt.String("Self")));f.Pc=466;continue;}
case 466:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",469);}
case 469:{f.Pc=f.Pop().Int==0?585:472;continue;}
case 472:{f.Push(f.Locals[3]);f.Pc=473;continue;}
case 473:{f.Push(f.Locals[4]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",478);}
case 478:{f.Pc=f.Pop().Reference==null?585:481;continue;}
case 481:{f.Push(f.Locals[4]);f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",486);}
case 486:{f.Push(f.Locals[2]);f.Pc=487;continue;}
case 487:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",490);}
case 490:{f.Pc=f.Pop().Int==0?1391:493;continue;}
case 493:{f.Push(f.Locals[3]);f.Pc=494;continue;}
case 494:{f.Push(f.Locals[4]);f.Pc=496;continue;}
case 496:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",499);}
case 499:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",505);}
case 505:{f.Pc=f.Pop().Int==0?1391:508;continue;}
case 508:{f.Push(f.Locals[11]);f.Pc=510;continue;}
case 510:{f.Pc=f.Pop().Int==0?547:513;continue;}
case 513:{f.Push(f.Locals[2]);f.Pc=514;continue;}
case 514:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",517);}
case 517:{f.Push(f.Locals[1]);f.Pc=518;continue;}
case 518:{f.Push(JValue.R(null));f.Pc=519;continue;}
case 519:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",522);}
case 522:{f.Push(JValue.R(rt.String("lblDoYouWantSacrificeThis")));f.Pc=525;continue;}
case 525:{f.Push(JValue.I(1));f.Pc=526;continue;}
case 526:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=529;continue;}
case 529:{f.StackOp("dup");f.Pc=530;continue;}
case 530:{f.Push(JValue.I(0));f.Pc=531;continue;}
case 531:{f.Push(f.Locals[4]);f.Pc=533;continue;}
case 533:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",536);}
case 536:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=537;continue;}
case 537:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",540);}
case 540:{f.Push(JValue.R(null));f.Pc=541;continue;}
case 541:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",544);}
case 544:{f.Pc=f.Pop().Int==0?1391:547;continue;}
case 547:{f.Push(f.Locals[3]);f.Pc=548;continue;}
case 548:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",551);}
case 551:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=554;continue;}
case 554:{f.StackOp("dup");f.Pc=555;continue;}
case 555:{f.Push(f.Locals[4]);f.Pc=557;continue;}
case 557:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",560);}
case 560:{f.Push(f.Locals[1]);f.Pc=561;continue;}
case 561:{f.Push(JValue.I(1));f.Pc=562;continue;}
case 562:{f.Push(f.Locals[12]);f.Pc=564;continue;}
case 564:{return rt.Call(f,"forge/game/GameAction","sacrifice","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",567);}
case 567:{f.Pc=f.Pop().Reference==null?1391:570;continue;}
case 570:{f.Push(f.Locals[10]);f.Pc=572;continue;}
case 572:{f.Pc=f.Pop().Int==0?1391:575;continue;}
case 575:{f.Push(f.Locals[4]);f.Pc=577;continue;}
case 577:{f.Push(f.Locals[4]);f.Pc=579;continue;}
case 579:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",582);}
case 582:{f.Pc=1391;continue;}
case 585:{f.Push(JValue.R(null));f.Pc=586;continue;}
case 586:{f.Locals[14]=f.Pop();f.Pc=588;continue;}
case 588:{f.Push(f.Locals[1]);f.Pc=589;continue;}
case 589:{return rt.Call(f,"forge/game/ability/effects/SacrificeEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",592);}
case 592:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",595);}
case 595:{f.Locals[15]=f.Pop();f.Pc=597;continue;}
case 597:{f.Push(f.Locals[15]);f.Pc=599;continue;}
case 599:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",604);}
case 604:{f.Pc=f.Pop().Int==0?1391:607;continue;}
case 607:{f.Push(f.Locals[15]);f.Pc=609;continue;}
case 609:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",614);}
case 614:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=617;continue;}
case 617:{f.Locals[16]=f.Pop();f.Pc=619;continue;}
case 619:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=622;continue;}
case 622:{f.StackOp("dup");f.Pc=623;continue;}
case 623:{f.Push(f.Locals[16]);f.Pc=625;continue;}
case 625:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=628;continue;}
case 628:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",631);}
case 631:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",634);}
case 634:{f.Locals[17]=f.Pop();f.Pc=636;continue;}
case 636:{f.Push(f.Locals[17]);f.Pc=638;continue;}
case 638:{f.Push(f.Locals[13]);f.Pc=640;continue;}
case 640:{return rt.DynamicCall(f,"forge/game/ability/effects/SacrificeEffect:3706:640:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CardZoneTable;)Ljava/util/function/Predicate;",645);}
case 645:{return rt.Call(f,"forge/game/card/CardCollection","removeIf","(Ljava/util/function/Predicate;)Z","invokevirtual",648);}
case 648:{f.StackOp("pop");f.Pc=649;continue;}
case 649:{f.Push(f.Locals[6]);f.Pc=651;continue;}
case 651:{f.Pc=f.Pop().Int==0?913:654;continue;}
case 654:{f.Push(f.Locals[7]);f.Pc=656;continue;}
case 656:{f.Push(JValue.R(rt.String(" & ")));f.Pc=659;continue;}
case 659:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",662);}
case 662:{f.Locals[18]=f.Pop();f.Pc=664;continue;}
case 664:{f.Push(f.Locals[8]);f.Pc=666;continue;}
case 666:{f.Push(JValue.R(rt.String(" & ")));f.Pc=669;continue;}
case 669:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",672);}
case 672:{f.Locals[19]=f.Pop();f.Pc=674;continue;}
case 674:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=677;continue;}
case 677:{f.StackOp("dup");f.Pc=678;continue;}
case 678:{f.Push(f.Locals[18]);f.Pc=680;continue;}
case 680:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=681;continue;}
case 681:{return rt.Call(f,"java/util/ArrayList","<init>","(I)V","invokespecial",684);}
case 684:{f.Locals[20]=f.Pop();f.Pc=686;continue;}
case 686:{f.Push(f.Locals[18]);f.Pc=688;continue;}
case 688:{f.Locals[21]=f.Pop();f.Pc=690;continue;}
case 690:{f.Push(f.Locals[21]);f.Pc=692;continue;}
case 692:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=693;continue;}
case 693:{f.Locals[22]=f.Pop();f.Pc=695;continue;}
case 695:{f.Push(JValue.I(0));f.Pc=696;continue;}
case 696:{f.Locals[23]=f.Pop();f.Pc=698;continue;}
case 698:{f.Push(f.Locals[23]);f.Pc=700;continue;}
case 700:{f.Push(f.Locals[22]);f.Pc=702;continue;}
case 702:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?746:705;continue;}
case 705:{f.Push(f.Locals[21]);f.Pc=707;continue;}
case 707:{f.Push(f.Locals[23]);f.Pc=709;continue;}
case 709:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=710;continue;}
case 710:{f.Locals[24]=f.Pop();f.Pc=712;continue;}
case 712:{f.Push(f.Locals[17]);f.Pc=714;continue;}
case 714:{f.Push(f.Locals[24]);f.Pc=716;continue;}
case 716:{f.Push(f.Locals[1]);f.Pc=717;continue;}
case 717:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",720);}
case 720:{f.Push(f.Locals[1]);f.Pc=721;continue;}
case 721:{f.Push(JValue.I(1));f.Pc=722;continue;}
case 722:{return rt.Call(f,"forge/game/card/CardPredicates","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;","invokestatic",725);}
case 725:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",728);}
case 728:{f.Locals[25]=f.Pop();f.Pc=730;continue;}
case 730:{f.Push(f.Locals[20]);f.Pc=732;continue;}
case 732:{f.Push(f.Locals[25]);f.Pc=734;continue;}
case 734:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",739);}
case 739:{f.StackOp("pop");f.Pc=740;continue;}
case 740:{f.Locals[23]=JValue.I(unchecked(f.Locals[23].Int+(1)));f.Pc=743;continue;}
case 743:{f.Pc=698;continue;}
case 746:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=749;continue;}
case 749:{f.StackOp("dup");f.Pc=750;continue;}
case 750:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",753);}
case 753:{f.Locals[21]=f.Pop();f.Pc=755;continue;}
case 755:{f.Push(JValue.I(0));f.Pc=756;continue;}
case 756:{f.Locals[22]=f.Pop();f.Pc=758;continue;}
case 758:{f.Push(f.Locals[22]);f.Pc=760;continue;}
case 760:{f.Push(f.Locals[18]);f.Pc=762;continue;}
case 762:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=763;continue;}
case 763:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?906:766;continue;}
case 766:{f.Push(f.Locals[20]);f.Pc=768;continue;}
case 768:{f.Push(f.Locals[22]);f.Pc=770;continue;}
case 770:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",775);}
case 775:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=778;continue;}
case 778:{f.Locals[23]=f.Pop();f.Pc=780;continue;}
case 780:{f.Push(f.Locals[23]);f.Pc=782;continue;}
case 782:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",785);}
case 785:{f.Pc=f.Pop().Int==0?791:788;continue;}
case 788:{f.Pc=900;continue;}
case 791:{f.Push(f.Locals[23]);f.Pc=793;continue;}
case 793:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",796);}
case 796:{f.Push(JValue.I(1));f.Pc=797;continue;}
case 797:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?832:800;continue;}
case 800:{f.Push(f.Locals[22]);f.Pc=802;continue;}
case 802:{f.Push(f.Locals[18]);f.Pc=804;continue;}
case 804:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=805;continue;}
case 805:{f.Push(JValue.I(1));f.Pc=806;continue;}
case 806:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=807;continue;}
case 807:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?832:810;continue;}
case 810:{f.Push(f.Locals[0]);f.Pc=811;continue;}
case 811:{f.Push(f.Locals[23]);f.Pc=813;continue;}
case 813:{f.Push(f.Locals[20]);f.Pc=815;continue;}
case 815:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=818;continue;}
case 818:{f.StackOp("dup");f.Pc=819;continue;}
case 819:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",822);}
case 822:{f.Push(f.Locals[22]);f.Pc=824;continue;}
case 824:{f.Push(JValue.I(1));f.Pc=825;continue;}
case 825:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=826;continue;}
case 826:{f.Push(JValue.I(0));f.Pc=827;continue;}
case 827:{f.Push(f.Locals[5]);f.Pc=829;continue;}
case 829:{return rt.Call(f,"forge/game/ability/effects/SacrificeEffect","removeCandidates","(Lforge/game/card/CardCollection;Ljava/util/List;Ljava/util/Set;III)V","invokevirtual",832);}
case 832:{f.Push(f.Locals[16]);f.Pc=834;continue;}
case 834:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",837);}
case 837:{f.Push(f.Locals[1]);f.Pc=838;continue;}
case 838:{f.Push(f.Locals[5]);f.Pc=840;continue;}
case 840:{f.Push(f.Locals[5]);f.Pc=842;continue;}
case 842:{f.Push(f.Locals[23]);f.Pc=844;continue;}
case 844:{f.Push(f.Locals[19]);f.Pc=846;continue;}
case 846:{f.Push(f.Locals[22]);f.Pc=848;continue;}
case 848:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=849;continue;}
case 849:{return rt.Call(f,"forge/game/player/PlayerController","choosePermanentsToSacrifice","(Lforge/game/spellability/SpellAbility;IILforge/game/card/CardCollectionView;Ljava/lang/String;)Lforge/game/card/CardCollectionView;","invokevirtual",852);}
case 852:{f.Locals[14]=f.Pop();f.Pc=854;continue;}
case 854:{f.Push(f.Locals[22]);f.Pc=856;continue;}
case 856:{f.Push(JValue.I(1));f.Pc=857;continue;}
case 857:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=858;continue;}
case 858:{f.Locals[24]=f.Pop();f.Pc=860;continue;}
case 860:{f.Push(f.Locals[24]);f.Pc=862;continue;}
case 862:{f.Push(f.Locals[18]);f.Pc=864;continue;}
case 864:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=865;continue;}
case 865:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?892:868;continue;}
case 868:{f.Push(f.Locals[20]);f.Pc=870;continue;}
case 870:{f.Push(f.Locals[24]);f.Pc=872;continue;}
case 872:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",877);}
case 877:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=880;continue;}
case 880:{f.Push(f.Locals[14]);f.Pc=882;continue;}
case 882:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",885);}
case 885:{f.StackOp("pop");f.Pc=886;continue;}
case 886:{f.Locals[24]=JValue.I(unchecked(f.Locals[24].Int+(1)));f.Pc=889;continue;}
case 889:{f.Pc=860;continue;}
case 892:{f.Push(f.Locals[21]);f.Pc=894;continue;}
case 894:{f.Push(f.Locals[14]);f.Pc=896;continue;}
case 896:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",899);}
case 899:{f.StackOp("pop");f.Pc=900;continue;}
case 900:{f.Locals[22]=JValue.I(unchecked(f.Locals[22].Int+(1)));f.Pc=903;continue;}
case 903:{f.Pc=758;continue;}
case 906:{f.Push(f.Locals[21]);f.Pc=908;continue;}
case 908:{f.Locals[14]=f.Pop();f.Pc=910;continue;}
case 910:{f.Pc=1119;continue;}
case 913:{f.Push(f.Locals[17]);f.Pc=915;continue;}
case 915:{f.Push(f.Locals[7]);f.Pc=917;continue;}
case 917:{f.Push(f.Locals[1]);f.Pc=918;continue;}
case 918:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",921);}
case 921:{f.Locals[18]=f.Pop();f.Pc=923;continue;}
case 923:{f.Push(f.Locals[9]);f.Pc=925;continue;}
case 925:{f.Pc=f.Pop().Int!=0?940:928;continue;}
case 928:{f.Push(f.Locals[18]);f.Pc=930;continue;}
case 930:{f.Push(f.Locals[1]);f.Pc=931;continue;}
case 931:{f.Push(JValue.I(1));f.Pc=932;continue;}
case 932:{return rt.Call(f,"forge/game/card/CardPredicates","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;","invokestatic",935);}
case 935:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",938);}
case 938:{f.Locals[18]=f.Pop();f.Pc=940;continue;}
case 940:{f.Push(f.Locals[1]);f.Pc=941;continue;}
case 941:{f.Push(JValue.R(rt.String("StrictAmount")));f.Pc=944;continue;}
case 944:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",947);}
case 947:{f.Locals[19]=f.Pop();f.Pc=949;continue;}
case 949:{f.Push(f.Locals[11]);f.Pc=951;continue;}
case 951:{f.Pc=f.Pop().Int==0?963:954;continue;}
case 954:{f.Push(f.Locals[19]);f.Pc=956;continue;}
case 956:{f.Pc=f.Pop().Int!=0?963:959;continue;}
case 959:{f.Push(JValue.I(0));f.Pc=960;continue;}
case 960:{f.Pc=965;continue;}
case 963:{f.Push(f.Locals[5]);f.Pc=965;continue;}
case 965:{f.Locals[20]=f.Pop();f.Pc=967;continue;}
case 967:{f.Push(f.Locals[19]);f.Pc=969;continue;}
case 969:{f.Pc=f.Pop().Int==0?988:972;continue;}
case 972:{f.Push(f.Locals[18]);f.Pc=974;continue;}
case 974:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",979);}
case 979:{f.Push(f.Locals[20]);f.Pc=981;continue;}
case 981:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?988:984;continue;}
case 984:{f.Push(JValue.I(1));f.Pc=985;continue;}
case 985:{f.Pc=989;continue;}
case 988:{f.Push(JValue.I(0));f.Pc=989;continue;}
case 989:{f.Locals[21]=f.Pop();f.Pc=991;continue;}
case 991:{f.Push(f.Locals[1]);f.Pc=992;continue;}
case 992:{f.Push(JValue.R(rt.String("Random")));f.Pc=995;continue;}
case 995:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",998);}
case 998:{f.Pc=f.Pop().Int==0?1030:1001;continue;}
case 1001:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1004;continue;}
case 1004:{f.StackOp("dup");f.Pc=1005;continue;}
case 1005:{f.Push(f.Locals[18]);f.Pc=1007;continue;}
case 1007:{f.Push(f.Locals[5]);f.Pc=1009;continue;}
case 1009:{f.Push(f.Locals[18]);f.Pc=1011;continue;}
case 1011:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",1016);}
case 1016:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",1019);}
case 1019:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",1022);}
case 1022:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",1025);}
case 1025:{f.Locals[14]=f.Pop();f.Pc=1027;continue;}
case 1027:{f.Pc=1119;continue;}
case 1030:{f.Push(f.Locals[21]);f.Pc=1032;continue;}
case 1032:{f.Pc=f.Pop().Int!=0?1067:1035;continue;}
case 1035:{f.Push(f.Locals[11]);f.Pc=1037;continue;}
case 1037:{f.Pc=f.Pop().Int==0?1075:1040;continue;}
case 1040:{f.Push(f.Locals[16]);f.Pc=1042;continue;}
case 1042:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1045);}
case 1045:{f.Push(f.Locals[1]);f.Pc=1046;continue;}
case 1046:{f.Push(JValue.R(null));f.Pc=1047;continue;}
case 1047:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1050);}
case 1050:{f.Push(JValue.R(rt.String("lblDoYouWantSacrifice")));f.Pc=1053;continue;}
case 1053:{f.Push(JValue.I(0));f.Pc=1054;continue;}
case 1054:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1057;continue;}
case 1057:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1060);}
case 1060:{f.Push(JValue.R(null));f.Pc=1061;continue;}
case 1061:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",1064);}
case 1064:{f.Pc=f.Pop().Int!=0?1075:1067;continue;}
case 1067:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=1070;continue;}
case 1070:{f.Locals[14]=f.Pop();f.Pc=1072;continue;}
case 1072:{f.Pc=1119;continue;}
case 1075:{f.Push(f.Locals[9]);f.Pc=1077;continue;}
case 1077:{f.Pc=f.Pop().Int==0?1100:1080;continue;}
case 1080:{f.Push(f.Locals[16]);f.Pc=1082;continue;}
case 1082:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1085);}
case 1085:{f.Push(f.Locals[1]);f.Pc=1086;continue;}
case 1086:{f.Push(f.Locals[20]);f.Pc=1088;continue;}
case 1088:{f.Push(f.Locals[5]);f.Pc=1090;continue;}
case 1090:{f.Push(f.Locals[18]);f.Pc=1092;continue;}
case 1092:{f.Push(f.Locals[8]);f.Pc=1094;continue;}
case 1094:{return rt.Call(f,"forge/game/player/PlayerController","choosePermanentsToDestroy","(Lforge/game/spellability/SpellAbility;IILforge/game/card/CardCollectionView;Ljava/lang/String;)Lforge/game/card/CardCollectionView;","invokevirtual",1097);}
case 1097:{f.Pc=1117;continue;}
case 1100:{f.Push(f.Locals[16]);f.Pc=1102;continue;}
case 1102:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1105);}
case 1105:{f.Push(f.Locals[1]);f.Pc=1106;continue;}
case 1106:{f.Push(f.Locals[20]);f.Pc=1108;continue;}
case 1108:{f.Push(f.Locals[5]);f.Pc=1110;continue;}
case 1110:{f.Push(f.Locals[18]);f.Pc=1112;continue;}
case 1112:{f.Push(f.Locals[8]);f.Pc=1114;continue;}
case 1114:{return rt.Call(f,"forge/game/player/PlayerController","choosePermanentsToSacrifice","(Lforge/game/spellability/SpellAbility;IILforge/game/card/CardCollectionView;Ljava/lang/String;)Lforge/game/card/CardCollectionView;","invokevirtual",1117);}
case 1117:{f.Locals[14]=f.Pop();f.Pc=1119;continue;}
case 1119:{f.Push(f.Locals[3]);f.Pc=1120;continue;}
case 1120:{f.Push(f.Locals[14]);f.Pc=1122;continue;}
case 1122:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1125;continue;}
case 1125:{f.Push(f.Locals[1]);f.Pc=1126;continue;}
case 1126:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",1129);}
case 1129:{f.Locals[14]=f.Pop();f.Pc=1131;continue;}
case 1131:{f.Push(f.Locals[9]);f.Pc=1133;continue;}
case 1133:{f.Pc=f.Pop().Int==0?1218:1136;continue;}
case 1136:{f.Push(f.Locals[14]);f.Pc=1138;continue;}
case 1138:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",1143);}
case 1143:{f.Locals[18]=f.Pop();f.Pc=1145;continue;}
case 1145:{f.Push(f.Locals[18]);f.Pc=1147;continue;}
case 1147:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1152);}
case 1152:{f.Pc=f.Pop().Int==0?1215:1155;continue;}
case 1155:{f.Push(f.Locals[18]);f.Pc=1157;continue;}
case 1157:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1162);}
case 1162:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1165;continue;}
case 1165:{f.Locals[19]=f.Pop();f.Pc=1167;continue;}
case 1167:{f.Push(f.Locals[13]);f.Pc=1169;continue;}
case 1169:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",1172);}
case 1172:{f.Push(f.Locals[19]);f.Pc=1174;continue;}
case 1174:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1179);}
case 1179:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1182;continue;}
case 1182:{f.Locals[20]=f.Pop();f.Pc=1184;continue;}
case 1184:{f.Push(f.Locals[3]);f.Pc=1185;continue;}
case 1185:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1188);}
case 1188:{f.Push(f.Locals[19]);f.Pc=1190;continue;}
case 1190:{f.Push(f.Locals[1]);f.Pc=1191;continue;}
case 1191:{f.Push(JValue.I(1));f.Pc=1192;continue;}
case 1192:{f.Push(f.Locals[12]);f.Pc=1194;continue;}
case 1194:{return rt.Call(f,"forge/game/GameAction","destroy","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Z","invokevirtual",1197);}
case 1197:{f.Pc=f.Pop().Int==0?1212:1200;continue;}
case 1200:{f.Push(f.Locals[10]);f.Pc=1202;continue;}
case 1202:{f.Pc=f.Pop().Int==0?1212:1205;continue;}
case 1205:{f.Push(f.Locals[4]);f.Pc=1207;continue;}
case 1207:{f.Push(f.Locals[20]);f.Pc=1209;continue;}
case 1209:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1212);}
case 1212:{f.Pc=1145;continue;}
case 1215:{f.Pc=1388;continue;}
case 1218:{f.Push(f.Locals[3]);f.Pc=1219;continue;}
case 1219:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1222);}
case 1222:{f.Push(f.Locals[14]);f.Pc=1224;continue;}
case 1224:{f.Push(f.Locals[1]);f.Pc=1225;continue;}
case 1225:{f.Push(JValue.I(1));f.Pc=1226;continue;}
case 1226:{f.Push(f.Locals[12]);f.Pc=1228;continue;}
case 1228:{return rt.Call(f,"forge/game/GameAction","sacrifice","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",1231);}
case 1231:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1234);}
case 1234:{f.Locals[18]=f.Pop();f.Pc=1236;continue;}
case 1236:{f.Push(f.Locals[18]);f.Pc=1238;continue;}
case 1238:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1243);}
case 1243:{f.Pc=f.Pop().Int==0?1388:1246;continue;}
case 1246:{f.Push(f.Locals[18]);f.Pc=1248;continue;}
case 1248:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1253);}
case 1253:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1256;continue;}
case 1256:{f.Locals[19]=f.Pop();f.Pc=1258;continue;}
case 1258:{f.Push(f.Locals[13]);f.Pc=1260;continue;}
case 1260:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",1263);}
case 1263:{f.Push(f.Locals[19]);f.Pc=1265;continue;}
case 1265:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1270);}
case 1270:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1273;continue;}
case 1273:{f.Locals[20]=f.Pop();f.Pc=1275;continue;}
case 1275:{f.Push(f.Locals[1]);f.Pc=1276;continue;}
case 1276:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","DEVOUR","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","DEVOUR","Lforge/game/keyword/Keyword;"));f.Pc=1279;continue;}
case 1279:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",1282);}
case 1282:{f.Pc=f.Pop().Int==0?1323:1285;continue;}
case 1285:{f.Push(f.Locals[4]);f.Pc=1287;continue;}
case 1287:{f.Push(f.Locals[20]);f.Pc=1289;continue;}
case 1289:{return rt.Call(f,"forge/game/card/Card","addDevoured","(Lforge/game/card/Card;)V","invokevirtual",1292);}
case 1292:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1295);}
case 1295:{f.Locals[21]=f.Pop();f.Pc=1297;continue;}
case 1297:{f.Push(f.Locals[21]);f.Pc=1299;continue;}
case 1299:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Devoured","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Devoured","Lforge/game/ability/AbilityKey;"));f.Pc=1302;continue;}
case 1302:{f.Push(f.Locals[20]);f.Pc=1304;continue;}
case 1304:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1309);}
case 1309:{f.StackOp("pop");f.Pc=1310;continue;}
case 1310:{f.Push(f.Locals[3]);f.Pc=1311;continue;}
case 1311:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1314);}
case 1314:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Devoured","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Devoured","Lforge/game/trigger/TriggerType;"));f.Pc=1317;continue;}
case 1317:{f.Push(f.Locals[21]);f.Pc=1319;continue;}
case 1319:{f.Push(JValue.I(0));f.Pc=1320;continue;}
case 1320:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1323);}
case 1323:{f.Push(f.Locals[1]);f.Pc=1324;continue;}
case 1324:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","EXPLOIT","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","EXPLOIT","Lforge/game/keyword/Keyword;"));f.Pc=1327;continue;}
case 1327:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",1330);}
case 1330:{f.Pc=f.Pop().Int==0?1373:1333;continue;}
case 1333:{f.Push(f.Locals[4]);f.Pc=1335;continue;}
case 1335:{f.Push(f.Locals[20]);f.Pc=1337;continue;}
case 1337:{return rt.Call(f,"forge/game/card/Card","addExploited","(Lforge/game/card/Card;)V","invokevirtual",1340);}
case 1340:{f.Push(f.Locals[4]);f.Pc=1342;continue;}
case 1342:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",1345);}
case 1345:{f.Locals[21]=f.Pop();f.Pc=1347;continue;}
case 1347:{f.Push(f.Locals[21]);f.Pc=1349;continue;}
case 1349:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Exploited","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Exploited","Lforge/game/ability/AbilityKey;"));f.Pc=1352;continue;}
case 1352:{f.Push(f.Locals[20]);f.Pc=1354;continue;}
case 1354:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1359);}
case 1359:{f.StackOp("pop");f.Pc=1360;continue;}
case 1360:{f.Push(f.Locals[3]);f.Pc=1361;continue;}
case 1361:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1364);}
case 1364:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Exploited","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Exploited","Lforge/game/trigger/TriggerType;"));f.Pc=1367;continue;}
case 1367:{f.Push(f.Locals[21]);f.Pc=1369;continue;}
case 1369:{f.Push(JValue.I(0));f.Pc=1370;continue;}
case 1370:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1373);}
case 1373:{f.Push(f.Locals[10]);f.Pc=1375;continue;}
case 1375:{f.Pc=f.Pop().Int==0?1385:1378;continue;}
case 1378:{f.Push(f.Locals[4]);f.Pc=1380;continue;}
case 1380:{f.Push(f.Locals[20]);f.Pc=1382;continue;}
case 1382:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1385);}
case 1385:{f.Pc=1236;continue;}
case 1388:{f.Pc=597;continue;}
case 1391:{f.Push(f.Locals[13]);f.Pc=1393;continue;}
case 1393:{f.Push(f.Locals[3]);f.Pc=1394;continue;}
case 1394:{f.Push(f.Locals[1]);f.Pc=1395;continue;}
case 1395:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1398);}
case 1398:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3707(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/SacrificeEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("SacValid")));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Self")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Amount")));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("1")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",31);}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("Optional")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",39);}
case 39:{f.Locals[6]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",47);}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?55:51;continue;}
case 51:{f.Push(JValue.I(1));f.Pc=52;continue;}
case 52:{f.Pc=56;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{f.Locals[7]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",64);}
case 64:{f.Pc=f.Pop().Int==0?73:67;continue;}
case 67:{f.Push(JValue.R(rt.String("You")));f.Pc=70;continue;}
case 70:{f.Pc=77;continue;}
case 73:{f.Push(f.Locals[3]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",77);}
case 77:{f.Locals[8]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{f.Pc=f.Pop().Int!=0?93:84;continue;}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{f.Pc=f.Pop().Int==0?93:89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{f.Pc=94;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{f.Locals[9]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("Destroy")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int==0?111:105;continue;}
case 105:{f.Push(JValue.R(rt.String("destroy")));f.Pc=108;continue;}
case 108:{f.Pc=114;continue;}
case 111:{f.Push(JValue.R(rt.String("sacrifice")));f.Pc=114;continue;}
case 114:{f.Locals[10]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[10]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[9]);f.Pc=120;continue;}
case 120:{f.Pc=f.Pop().Int==0?129:123;continue;}
case 123:{f.Push(JValue.R(rt.String("s")));f.Pc=126;continue;}
case 126:{f.Pc=131;continue;}
case 129:{f.Push(JValue.R(rt.String("")));f.Pc=131;continue;}
case 131:{return rt.DynamicCall(f,"forge/game/ability/effects/SacrificeEffect:3707:131:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",136);}
case 136:{f.Locals[11]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[8]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[6]);f.Pc=142;continue;}
case 142:{f.Pc=f.Pop().Int==0?151:145;continue;}
case 145:{f.Push(JValue.R(rt.String(" may ")));f.Pc=148;continue;}
case 148:{f.Pc=154;continue;}
case 151:{f.Push(JValue.R(rt.String(" ")));f.Pc=154;continue;}
case 154:{f.Push(f.Locals[11]);f.Pc=156;continue;}
case 156:{return rt.DynamicCall(f,"forge/game/ability/effects/SacrificeEffect:3707:156:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",161);}
case 161:{f.Locals[12]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",167);}
case 167:{f.Push(f.Locals[5]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",173);}
case 173:{f.Locals[13]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[4]);f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String("Self")));f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int==0?208:185;continue;}
case 185:{f.Push(f.Locals[2]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[12]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",191);}
case 191:{f.Push(f.Locals[1]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",195);}
case 195:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",198);}
case 198:{f.Push(JValue.R(rt.String(".")));f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",204);}
case 204:{f.StackOp("pop");f.Pc=205;continue;}
case 205:{f.Pc=566;continue;}
case 208:{f.Push(f.Locals[4]);f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String("Card.AttachedBy")));f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",216);}
case 216:{f.Pc=f.Pop().Int==0?325:219;continue;}
case 219:{f.Push(f.Locals[1]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",223);}
case 223:{return rt.Call(f,"forge/game/card/Card","getEnchantingCard","()Lforge/game/card/Card;","invokevirtual",226);}
case 226:{f.Locals[14]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[14]);f.Pc=230;continue;}
case 230:{f.Pc=f.Pop().Reference!=null?262:233;continue;}
case 233:{f.Push(f.Locals[2]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[12]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",239);}
case 239:{f.Push(JValue.R(rt.String("the creature enchanted by ")));f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",245);}
case 245:{f.Push(f.Locals[1]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",249);}
case 249:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",252);}
case 252:{f.Push(JValue.R(rt.String(".")));f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",258);}
case 258:{f.StackOp("pop");f.Pc=259;continue;}
case 259:{f.Pc=322;continue;}
case 262:{f.Push(f.Locals[2]);f.Pc=263;continue;}
case 263:{f.Push(f.Locals[14]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",268);}
case 268:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",271);}
case 271:{f.Push(f.Locals[6]);f.Pc=273;continue;}
case 273:{f.Pc=f.Pop().Int==0?282:276;continue;}
case 276:{f.Push(JValue.R(rt.String(" may ")));f.Pc=279;continue;}
case 279:{f.Pc=285;continue;}
case 282:{f.Push(JValue.R(rt.String(" ")));f.Pc=285;continue;}
case 285:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",288);}
case 288:{f.Push(f.Locals[10]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",293);}
case 293:{f.Push(f.Locals[9]);f.Pc=295;continue;}
case 295:{f.Pc=f.Pop().Int==0?304:298;continue;}
case 298:{f.Push(JValue.R(rt.String("s ")));f.Pc=301;continue;}
case 301:{f.Pc=307;continue;}
case 304:{f.Push(JValue.R(rt.String(" ")));f.Pc=307;continue;}
case 307:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",310);}
case 310:{f.Push(f.Locals[14]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",315);}
case 315:{f.Push(JValue.R(rt.String(".")));f.Pc=318;continue;}
case 318:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",321);}
case 321:{f.StackOp("pop");f.Pc=322;continue;}
case 322:{f.Pc=566;continue;}
case 325:{f.Push(f.Locals[1]);f.Pc=326;continue;}
case 326:{f.Push(JValue.R(rt.String("SacMessage")));f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",331);}
case 331:{f.Pc=f.Pop().Int==0?366:334;continue;}
case 334:{f.Push(f.Locals[1]);f.Pc=335;continue;}
case 335:{f.Push(JValue.R(rt.String("SacMessage")));f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",340);}
case 340:{f.Locals[14]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(JValue.R(rt.String("\\b(?:Creature|Permanent|Artifact|Enchantment|Land|Planeswalker|Battle|Card)\\b")));f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",348);}
case 348:{f.Push(f.Locals[14]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",353);}
case 353:{return rt.DynamicCall(f,"forge/game/ability/effects/SacrificeEffect:3707:353:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",358);}
case 358:{return rt.Call(f,"java/util/regex/Matcher","replaceAll","(Ljava/util/function/Function;)Ljava/lang/String;","invokevirtual",361);}
case 361:{f.Locals[14]=f.Pop();f.Pc=363;continue;}
case 363:{f.Pc=385;continue;}
case 366:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",369);}
case 369:{f.Push(f.Locals[4]);f.Pc=371;continue;}
case 371:{f.Push(JValue.R(rt.String(",")));f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",376);}
case 376:{return rt.Call(f,"java/util/List","of","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",379);}
case 379:{f.Push(JValue.I(0));f.Pc=380;continue;}
case 380:{return rt.Call(f,"forge/util/Lang","buildValidDesc","(Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",383);}
case 383:{f.Locals[14]=f.Pop();f.Pc=385;continue;}
case 385:{f.Push(f.Locals[2]);f.Pc=386;continue;}
case 386:{f.Push(f.Locals[12]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",391);}
case 391:{f.StackOp("pop");f.Pc=392;continue;}
case 392:{f.Push(f.Locals[13]);f.Pc=394;continue;}
case 394:{f.Pc=f.Pop().Int!=0?425:397;continue;}
case 397:{f.Push(f.Locals[1]);f.Pc=398;continue;}
case 398:{f.Push(f.Locals[5]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"forge/game/ability/effects/SacrificeEffect","isAmountDeferred","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z","invokestatic",403);}
case 403:{f.Pc=f.Pop().Int==0?425:406;continue;}
case 406:{f.Push(f.Locals[2]);f.Pc=407;continue;}
case 407:{f.Push(JValue.R(rt.String("any number of ")));f.Pc=410;continue;}
case 410:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",413);}
case 413:{f.Push(f.Locals[14]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",418);}
case 418:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",421);}
case 421:{f.StackOp("pop");f.Pc=422;continue;}
case 422:{f.Pc=558;continue;}
case 425:{f.Push(f.Locals[13]);f.Pc=427;continue;}
case 427:{f.Pc=f.Pop().Int!=0?460:430;continue;}
case 430:{f.Push(f.Locals[5]);f.Pc=432;continue;}
case 432:{f.Push(JValue.R(rt.String("\\d+")));f.Pc=435;continue;}
case 435:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",438);}
case 438:{f.Pc=f.Pop().Int!=0?460:441;continue;}
case 441:{f.Push(f.Locals[2]);f.Pc=442;continue;}
case 442:{f.Push(JValue.R(rt.String("X ")));f.Pc=445;continue;}
case 445:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",448);}
case 448:{f.Push(f.Locals[14]);f.Pc=450;continue;}
case 450:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",453);}
case 453:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",456);}
case 456:{f.StackOp("pop");f.Pc=457;continue;}
case 457:{f.Pc=558;continue;}
case 460:{f.Push(f.Locals[14]);f.Pc=462;continue;}
case 462:{f.Push(JValue.R(rt.String("(?i)^(?:a|an|the|\\d+|one|two|three|four|five|six|seven|eight|nine|ten|x|that|those|each|all|any)\\b.*")));f.Pc=465;continue;}
case 465:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",468);}
case 468:{f.Pc=f.Pop().Int==0?496:471;continue;}
case 471:{f.Push(f.Locals[13]);f.Pc=473;continue;}
case 473:{f.Push(JValue.I(1));f.Pc=474;continue;}
case 474:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?486:477;continue;}
case 477:{f.Push(f.Locals[1]);f.Pc=478;continue;}
case 478:{f.Push(JValue.R(rt.String("SacMessage")));f.Pc=480;continue;}
case 480:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",483);}
case 483:{f.Pc=f.Pop().Int==0?496:486;continue;}
case 486:{f.Push(f.Locals[2]);f.Pc=487;continue;}
case 487:{f.Push(f.Locals[14]);f.Pc=489;continue;}
case 489:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",492);}
case 492:{f.StackOp("pop");f.Pc=493;continue;}
case 493:{f.Pc=558;continue;}
case 496:{f.Push(f.Locals[1]);f.Pc=497;continue;}
case 497:{f.Push(JValue.R(rt.String("SacMessage")));f.Pc=499;continue;}
case 499:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",502);}
case 502:{f.Pc=f.Pop().Int==0?546:505;continue;}
case 505:{f.Push(f.Locals[13]);f.Pc=507;continue;}
case 507:{f.Push(JValue.I(1));f.Pc=508;continue;}
case 508:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?546:511;continue;}
case 511:{f.Push(f.Locals[14]);f.Pc=513;continue;}
case 513:{f.Push(JValue.R(rt.String("s")));f.Pc=516;continue;}
case 516:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",519);}
case 519:{f.Pc=f.Pop().Int==0?546:522;continue;}
case 522:{f.Push(f.Locals[2]);f.Pc=523;continue;}
case 523:{f.Push(f.Locals[13]);f.Pc=525;continue;}
case 525:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",528);}
case 528:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",531);}
case 531:{f.Push(JValue.R(rt.String(" ")));f.Pc=534;continue;}
case 534:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",537);}
case 537:{f.Push(f.Locals[14]);f.Pc=539;continue;}
case 539:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",542);}
case 542:{f.StackOp("pop");f.Pc=543;continue;}
case 543:{f.Pc=558;continue;}
case 546:{f.Push(f.Locals[2]);f.Pc=547;continue;}
case 547:{f.Push(f.Locals[13]);f.Pc=549;continue;}
case 549:{f.Push(f.Locals[14]);f.Pc=551;continue;}
case 551:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",554);}
case 554:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",557);}
case 557:{f.StackOp("pop");f.Pc=558;continue;}
case 558:{f.Push(f.Locals[2]);f.Pc=559;continue;}
case 559:{f.Push(JValue.R(rt.String(".")));f.Pc=562;continue;}
case 562:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",565);}
case 565:{f.StackOp("pop");f.Pc=566;continue;}
case 566:{f.Push(f.Locals[2]);f.Pc=567;continue;}
case 567:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",570);}
case 570:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3708(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",8);}
case 8:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?32:11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",17);}
case 17:{f.Push(f.Locals[5]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[6]);f.Pc=21;continue;}
case 21:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=22;continue;}
case 22:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?31:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{return JStep.ReturnVoid;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/ability/effects/SacrificeEffect","removeCandidates","(Lforge/game/card/CardCollection;Ljava/util/List;Ljava/util/Set;III)V","invokevirtual",47);}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",55);}
case 55:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=58;continue;}
case 58:{f.Locals[7]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[7]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?69:68;continue;}
case 68:{return JStep.ReturnVoid;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",75);}
case 75:{f.Pc=f.Pop().Int==0?125:78;continue;}
case 78:{f.Push(f.Locals[7]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",83);}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?101:88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/CardCollection","asSet","()Ljava/util/Set;","invokevirtual",94);}
case 94:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{f.Pc=166;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/card/CardCollection","asSet","()Ljava/util/Set;","invokevirtual",109);}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{f.Push(JValue.I(1));f.Pc=112;continue;}
case 112:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=113;continue;}
case 113:{f.Push(f.Locals[5]);f.Pc=115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=117;continue;}
case 117:{f.Push(f.Locals[6]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/ability/effects/SacrificeEffect","removeCandidates","(Lforge/game/card/CardCollection;Ljava/util/List;Ljava/util/Set;III)V","invokevirtual",122);}
case 122:{f.Pc=166;continue;}
case 125:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=128;continue;}
case 128:{f.StackOp("dup");f.Pc=129;continue;}
case 129:{f.Push(f.Locals[3]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/HashSet","<init>","(Ljava/util/Collection;)V","invokespecial",133);}
case 133:{f.Locals[8]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[8]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[7]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/card/CardCollection","asSet","()Ljava/util/Set;","invokevirtual",142);}
case 142:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",147);}
case 147:{f.StackOp("pop");f.Pc=148;continue;}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[1]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[8]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[4]);f.Pc=155;continue;}
case 155:{f.Push(JValue.I(1));f.Pc=156;continue;}
case 156:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=157;continue;}
case 157:{f.Push(f.Locals[5]);f.Pc=159;continue;}
case 159:{f.Push(JValue.I(1));f.Pc=160;continue;}
case 160:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=161;continue;}
case 161:{f.Push(f.Locals[6]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/ability/effects/SacrificeEffect","removeCandidates","(Lforge/game/card/CardCollection;Ljava/util/List;Ljava/util/Set;III)V","invokevirtual",166);}
case 166:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3709(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/regex/MatchResult","group","()Ljava/lang/String;","invokeinterface",6);}
case 6:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3710(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int!=0?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C335{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/MeldEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3505,"forge/game/ability/effects/MeldEffect","<init>","()V",1,1,1,new JHandler[]{},M3505));
c.Add(new JMethod(3506,"forge/game/ability/effects/MeldEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,15,6,new JHandler[]{},M3506));
}

internal static JStep M3505(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3506(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Primary")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("Secondary")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",24);}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",30);}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",40);}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/CardPredicates","isOwner","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",45);}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/CardPredicates","nameEquals","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",50);}
case 50:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",53);}
case 53:{f.Locals[7]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[7]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("SecondaryType")));f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("Creature")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",65);}
case 65:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",68);}
case 68:{f.Locals[7]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[7]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int==0?79:78;continue;}
case 78:{return JStep.ReturnVoid;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",84);}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",90);}
case 90:{f.Push(JValue.R(rt.String("lblChooseCardToMeld")));f.Pc=92;continue;}
case 92:{f.Push(JValue.I(0));f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Push(JValue.R(null));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{f.Locals[8]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(JValue.I(2));f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=112;continue;}
case 112:{f.StackOp("dup");f.Pc=113;continue;}
case 113:{f.Push(JValue.I(0));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=116;continue;}
case 116:{f.StackOp("dup");f.Pc=117;continue;}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{f.Push(f.Locals[8]);f.Pc=120;continue;}
case 120:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",124);}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{f.Push(JValue.I(1));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/card/CardPredicates","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;","invokestatic",129);}
case 129:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",132);}
case 132:{f.Locals[9]=f.Pop();f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",137);}
case 137:{f.Locals[10]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[10]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[1]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",145);}
case 145:{f.Locals[11]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[5]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",152);}
case 152:{f.Push(f.Locals[9]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[10]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/CardCollection;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",160);}
case 160:{f.Locals[9]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[11]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[5]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[1]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",170);}
case 170:{f.Push(f.Locals[9]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",175);}
case 175:{f.Push(JValue.I(2));f.Pc=176;continue;}
case 176:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?180:179;continue;}
case 179:{return JStep.ReturnVoid;}
case 180:{f.Push(f.Locals[9]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[2]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/card/CardCollection","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",186);}
case 186:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=189;continue;}
case 189:{f.Locals[12]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[9]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[8]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/card/CardCollection","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",198);}
case 198:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=201;continue;}
case 201:{f.Locals[8]=f.Pop();f.Pc=203;continue;}
case 203:{f.Push(f.Locals[12]);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[3]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/card/Card","sharesNameWith","(Ljava/lang/String;)Z","invokevirtual",209);}
case 209:{f.Pc=f.Pop().Int==0?222:212;continue;}
case 212:{f.Push(f.Locals[8]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[4]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/card/Card","sharesNameWith","(Ljava/lang/String;)Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int!=0?223:222;continue;}
case 222:{return JStep.ReturnVoid;}
case 223:{f.Push(f.Locals[9]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",228);}
case 228:{f.Locals[13]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[13]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",237);}
case 237:{f.Pc=f.Pop().Int==0?284:240;continue;}
case 240:{f.Push(f.Locals[13]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",247);}
case 247:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=250;continue;}
case 250:{f.Locals[14]=f.Pop();f.Pc=252;continue;}
case 252:{f.Push(f.Locals[14]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Int!=0?268:260;continue;}
case 260:{f.Push(f.Locals[14]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/card/Card","getCloneOrigin","()Lforge/game/card/Card;","invokevirtual",265);}
case 265:{f.Pc=f.Pop().Reference==null?269:268;continue;}
case 268:{return JStep.ReturnVoid;}
case 269:{f.Push(f.Locals[14]);f.Pc=271;continue;}
case 271:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",277);}
case 277:{f.Pc=f.Pop().Int!=0?281:280;continue;}
case 280:{return JStep.ReturnVoid;}
case 281:{f.Pc=230;continue;}
case 284:{f.Push(f.Locals[1]);f.Pc=285;continue;}
case 285:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",290);}
case 290:{f.Pc=f.Pop().Int==0?299:293;continue;}
case 293:{f.Push(f.Locals[12]);f.Pc=295;continue;}
case 295:{f.Push(JValue.I(1));f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",299);}
case 299:{f.Push(f.Locals[12]);f.Pc=301;continue;}
case 301:{if(!rt.StaticReady(f,"forge/card/CardStateName","Meld","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Meld","Lforge/card/CardStateName;"));f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/card/Card","changeToState","(Lforge/card/CardStateName;)Z","invokevirtual",307);}
case 307:{f.StackOp("pop");f.Pc=308;continue;}
case 308:{f.Push(f.Locals[12]);f.Pc=310;continue;}
case 310:{f.Push(JValue.I(1));f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",314);}
case 314:{f.Push(f.Locals[12]);f.Pc=316;continue;}
case 316:{f.Push(f.Locals[8]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/card/Card","setMeldedWith","(Lforge/game/card/Card;)V","invokevirtual",321);}
case 321:{f.Push(f.Locals[6]);f.Pc=323;continue;}
case 323:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",329);}
case 329:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/PlayerZoneBattlefield"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=332;continue;}
case 332:{f.Locals[13]=f.Pop();f.Pc=334;continue;}
case 334:{f.Push(f.Locals[13]);f.Pc=336;continue;}
case 336:{f.Push(f.Locals[8]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/game/zone/PlayerZoneBattlefield","addToMelded","(Lforge/game/card/Card;)V","invokevirtual",341);}
case 341:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",344);}
case 344:{f.Locals[10]=f.Pop();f.Pc=346;continue;}
case 346:{f.Push(f.Locals[10]);f.Pc=348;continue;}
case 348:{f.Push(f.Locals[1]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",352);}
case 352:{f.Locals[11]=f.Pop();f.Pc=354;continue;}
case 354:{f.Push(f.Locals[5]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",359);}
case 359:{f.Push(f.Locals[12]);f.Pc=361;continue;}
case 361:{f.Push(f.Locals[6]);f.Pc=363;continue;}
case 363:{f.Push(f.Locals[1]);f.Pc=364;continue;}
case 364:{f.Push(f.Locals[10]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",369);}
case 369:{f.Locals[14]=f.Pop();f.Pc=371;continue;}
case 371:{f.Push(f.Locals[8]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/card/Card","isStickered","()Z","invokevirtual",376);}
case 376:{f.Pc=f.Pop().Int==0?394:379;continue;}
case 379:{f.Push(f.Locals[14]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",384);}
case 384:{f.Pc=f.Pop().Int==0?394:387;continue;}
case 387:{f.Push(f.Locals[14]);f.Pc=389;continue;}
case 389:{f.Push(f.Locals[8]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/card/Card","takeStickersFrom","(Lforge/game/card/Card;)V","invokevirtual",394);}
case 394:{f.Push(f.Locals[14]);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[1]);f.Pc=397;continue;}
case 397:{f.Push(JValue.R(rt.String("Attacking")));f.Pc=399;continue;}
case 399:{f.Push(JValue.R(rt.String("Blocking")));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/ability/effects/MeldEffect","addToCombat","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/String;)Z","invokestatic",404);}
case 404:{f.Pc=f.Pop().Int==0?424:407;continue;}
case 407:{f.Push(f.Locals[5]);f.Pc=409;continue;}
case 409:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",412);}
case 412:{f.Push(f.Locals[5]);f.Pc=414;continue;}
case 414:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=417;continue;}
case 417:{f.StackOp("dup");f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",421);}
case 421:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",424);}
case 424:{f.Push(f.Locals[11]);f.Pc=426;continue;}
case 426:{f.Push(f.Locals[5]);f.Pc=428;continue;}
case 428:{f.Push(f.Locals[1]);f.Pc=429;continue;}
case 429:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",432);}
case 432:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

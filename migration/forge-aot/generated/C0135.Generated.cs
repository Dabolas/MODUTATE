// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C135{
internal static JClass Build(){var c=new JClass("forge/game/GameActionUtil","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(2145,"forge/game/GameActionUtil","<init>","()V",2,1,2,new JHandler[]{},M2145));
c.Add(new JMethod(2146,"forge/game/GameActionUtil","getAlternativeCosts","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/util/List;",9,16,6,new JHandler[]{},M2146));
c.Add(new JMethod(2147,"forge/game/GameActionUtil","getGraveyardSpellByKeyword","(Lforge/game/keyword/KeywordInterface;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/spellability/AlternativeCost;)Lforge/game/spellability/SpellAbility;",9,10,6,new JHandler[]{},M2147));
c.Add(new JMethod(2148,"forge/game/GameActionUtil","getMayPlaySpellOptions","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;Z)Ljava/util/List;",9,11,4,new JHandler[]{},M2148));
c.Add(new JMethod(2149,"forge/game/GameActionUtil","getOptionalCostValues","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",9,14,6,new JHandler[]{},M2149));
c.Add(new JMethod(2150,"forge/game/GameActionUtil","addOptionalCosts","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Lforge/game/spellability/SpellAbility;",9,5,4,new JHandler[]{},M2150));
c.Add(new JMethod(2151,"forge/game/GameActionUtil","getAdditionalCostSpell","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",9,12,4,new JHandler[]{},M2151));
c.Add(new JMethod(2152,"forge/game/GameActionUtil","addExtraKeywordCost","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbility;",9,17,6,new JHandler[]{},M2152));
c.Add(new JMethod(2153,"forge/game/GameActionUtil","createETBCountersEffect","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;",9,12,4,new JHandler[]{},M2153));
c.Add(new JMethod(2154,"forge/game/GameActionUtil","generatedTotalMana","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",9,4,2,new JHandler[]{},M2154));
c.Add(new JMethod(2155,"forge/game/GameActionUtil","generatedMana","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",9,6,3,new JHandler[]{},M2155));
c.Add(new JMethod(2156,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;",9,13,6,new JHandler[]{},M2156));
c.Add(new JMethod(2157,"forge/game/GameActionUtil","rollbackAbility","(Lforge/game/spellability/SpellAbility;Lforge/game/zone/Zone;ILforge/game/cost/CostPayment;Lforge/game/card/Card;I)V",9,13,5,new JHandler[]{},M2157));
}

internal static JStep M2145(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{if(!rt.EnsureInitialized(f,"java/lang/AssertionError"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/AssertionError")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/AssertionError","<init>","()V","invokespecial",11);}
case 11:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2146(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",15);}
case 15:{f.Locals[5]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?34:24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?34:32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return JStep.Return(f.Pop());}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int!=0?48:41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","isLandAbility","()Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?1369:48;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{f.Locals[6]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAlternateHost","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",57);}
case 57:{f.Locals[7]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Reference==null?71:64;continue;}
case 64:{f.Push(f.Locals[7]);f.Pc=66;continue;}
case 66:{f.Locals[4]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(JValue.I(1));f.Pc=69;continue;}
case 69:{f.Locals[6]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[6]);f.Pc=73;continue;}
case 73:{f.Pc=f.Pop().Int==0?125:76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",81);}
case 81:{return rt.Call(f,"forge/trackable/Tracker","freeze","()V","invokevirtual",84);}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/Card","clearStaticChangedCardKeywords","(Z)Z","invokevirtual",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{f.Push(f.Locals[4]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",100);}
case 100:{f.Locals[8]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",107);}
case 107:{f.Push(JValue.I(0));f.Pc=108;continue;}
case 108:{f.Push(JValue.I(1));f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=112;continue;}
case 112:{f.StackOp("dup");f.Pc=113;continue;}
case 113:{f.Push(JValue.I(0));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=117;continue;}
case 117:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","([Ljava/lang/Object;)Ljava/util/HashSet;","invokestatic",120);}
case 120:{f.Push(f.Locals[8]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;)V","invokevirtual",125);}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBasicSpell","()Z","invokevirtual",129);}
case 129:{f.Pc=f.Pop().Int==0?196:132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[4]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/staticability/StaticAbilityAlternativeCost","alternativeCosts","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",139);}
case 139:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",144);}
case 144:{f.Locals[8]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[8]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",153);}
case 153:{f.Pc=f.Pop().Int==0?196:156;continue;}
case 156:{f.Push(f.Locals[8]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",163);}
case 163:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=166;continue;}
case 166:{f.Locals[9]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[3]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[9]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",176);}
case 176:{f.StackOp("pop");f.Pc=177;continue;}
case 177:{f.Push(f.Locals[3]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[9]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[4]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[2]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/GameActionUtil","getMayPlaySpellOptions","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;Z)Ljava/util/List;","invokestatic",187);}
case 187:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",192);}
case 192:{f.StackOp("pop");f.Pc=193;continue;}
case 193:{f.Pc=146;continue;}
case 196:{f.Push(f.Locals[3]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[0]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[4]);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[1]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/GameActionUtil","getMayPlaySpellOptions","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;Z)Ljava/util/List;","invokestatic",205);}
case 205:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",210);}
case 210:{f.StackOp("pop");f.Pc=211;continue;}
case 211:{f.Push(f.Locals[0]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBasicSpell","()Z","invokevirtual",215);}
case 215:{f.Pc=f.Pop().Int==0?1336:218;continue;}
case 218:{f.Push(f.Locals[4]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",223);}
case 223:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",228);}
case 228:{f.Locals[8]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[8]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",237);}
case 237:{f.Pc=f.Pop().Int==0?860:240;continue;}
case 240:{f.Push(f.Locals[8]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",247);}
case 247:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=250;continue;}
case 250:{f.Locals[9]=f.Pop();f.Pc=252;continue;}
case 252:{f.Push(f.Locals[9]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",259);}
case 259:{f.Locals[10]=f.Pop();f.Pc=261;continue;}
case 261:{f.Push(f.Locals[10]);f.Pc=263;continue;}
case 263:{f.Push(JValue.R(rt.String("Mayhem")));f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",268);}
case 268:{f.Pc=f.Pop().Int==0?318:271;continue;}
case 271:{f.Push(f.Locals[4]);f.Pc=273;continue;}
case 273:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",279);}
case 279:{f.Pc=f.Pop().Int==0?230:282;continue;}
case 282:{f.Push(f.Locals[4]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/card/Card","wasDiscarded","()Z","invokevirtual",287);}
case 287:{f.Pc=f.Pop().Int==0?230:290;continue;}
case 290:{f.Push(f.Locals[4]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/card/Card","enteredThisTurn","()Z","invokevirtual",295);}
case 295:{f.Pc=f.Pop().Int!=0?301:298;continue;}
case 298:{f.Pc=230;continue;}
case 301:{f.Push(f.Locals[3]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[9]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[0]);f.Pc=305;continue;}
case 305:{f.Push(f.Locals[1]);f.Pc=306;continue;}
case 306:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Mayhem","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Mayhem","Lforge/game/spellability/AlternativeCost;"));f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/game/GameActionUtil","getGraveyardSpellByKeyword","(Lforge/game/keyword/KeywordInterface;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/spellability/AlternativeCost;)Lforge/game/spellability/SpellAbility;","invokestatic",312);}
case 312:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",317);}
case 317:{f.StackOp("pop");f.Pc=318;continue;}
case 318:{f.Push(f.Locals[0]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/spellability/SpellAbility","isLandAbility","()Z","invokevirtual",322);}
case 322:{f.Pc=f.Pop().Int==0?328:325;continue;}
case 325:{f.Pc=230;continue;}
case 328:{f.Push(f.Locals[10]);f.Pc=330;continue;}
case 330:{f.Push(JValue.R(rt.String("Escape")));f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",335);}
case 335:{f.Pc=f.Pop().Int==0?513:338;continue;}
case 338:{f.Push(f.Locals[4]);f.Pc=340;continue;}
case 340:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",346);}
case 346:{f.Pc=f.Pop().Int!=0?352:349;continue;}
case 349:{f.Pc=230;continue;}
case 352:{f.Push(f.Locals[10]);f.Pc=354;continue;}
case 354:{f.Push(JValue.R(rt.String(":")));f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",359);}
case 359:{f.Locals[11]=f.Pop();f.Pc=361;continue;}
case 361:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=364;continue;}
case 364:{f.StackOp("dup");f.Pc=365;continue;}
case 365:{f.Push(f.Locals[11]);f.Pc=367;continue;}
case 367:{f.Push(JValue.I(1));f.Pc=368;continue;}
case 368:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=369;continue;}
case 369:{f.Push(JValue.I(1));f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",373);}
case 373:{f.Locals[12]=f.Pop();f.Pc=375;continue;}
case 375:{f.Push(f.Locals[0]);f.Pc=376;continue;}
case 376:{f.Push(f.Locals[1]);f.Pc=377;continue;}
case 377:{f.Push(f.Locals[12]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithManaCostReplaced","(Lforge/game/player/Player;Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",382);}
case 382:{f.Locals[13]=f.Pop();f.Pc=384;continue;}
case 384:{f.Push(f.Locals[13]);f.Pc=386;continue;}
case 386:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=388;continue;}
case 388:{f.Push(JValue.R(rt.String("Escape\u2014")));f.Pc=390;continue;}
case 390:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",393);}
case 393:{f.StackOp("pop");f.Pc=394;continue;}
case 394:{f.Push(f.Locals[13]);f.Pc=396;continue;}
case 396:{f.Push(JValue.R(rt.String("CostDesc")));f.Pc=398;continue;}
case 398:{f.Push(f.Locals[12]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"forge/game/cost/Cost","toString","()Ljava/lang/String;","invokevirtual",403);}
case 403:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",406);}
case 406:{f.StackOp("pop");f.Pc=407;continue;}
case 407:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=410;continue;}
case 410:{f.StackOp("dup");f.Pc=411;continue;}
case 411:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",414);}
case 414:{f.Locals[14]=f.Pop();f.Pc=416;continue;}
case 416:{f.Push(f.Locals[14]);f.Pc=418;continue;}
case 418:{f.Push(f.Locals[13]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCostDescription","()Ljava/lang/String;","invokevirtual",423);}
case 423:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",426);}
case 426:{f.StackOp("pop");f.Pc=427;continue;}
case 427:{f.Push(f.Locals[14]);f.Pc=429;continue;}
case 429:{f.Push(JValue.R(rt.String("(")));f.Pc=431;continue;}
case 431:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",434);}
case 434:{f.Push(f.Locals[9]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",441);}
case 441:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",444);}
case 444:{f.Push(JValue.R(rt.String(")")));f.Pc=446;continue;}
case 446:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",449);}
case 449:{f.StackOp("pop");f.Pc=450;continue;}
case 450:{f.Push(f.Locals[13]);f.Pc=452;continue;}
case 452:{f.Push(f.Locals[14]);f.Pc=454;continue;}
case 454:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",457);}
case 457:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",460);}
case 460:{f.Push(f.Locals[13]);f.Pc=462;continue;}
case 462:{f.Push(JValue.R(rt.String("AfterDescription")));f.Pc=464;continue;}
case 464:{f.Push(JValue.R(rt.String("(Escaped)")));f.Pc=466;continue;}
case 466:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",469);}
case 469:{f.StackOp("pop");f.Pc=470;continue;}
case 470:{f.Push(f.Locals[13]);f.Pc=472;continue;}
case 472:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Escape","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Escape","Lforge/game/spellability/AlternativeCost;"));f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",478);}
case 478:{f.Push(f.Locals[13]);f.Pc=480;continue;}
case 480:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",483);}
case 483:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",489);}
case 489:{f.Push(f.Locals[13]);f.Pc=491;continue;}
case 491:{f.Push(f.Locals[9]);f.Pc=493;continue;}
case 493:{return rt.Call(f,"forge/game/keyword/KeywordInterface","isIntrinsic","()Z","invokeinterface",498);}
case 498:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",501);}
case 501:{f.Push(f.Locals[3]);f.Pc=502;continue;}
case 502:{f.Push(f.Locals[13]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",509);}
case 509:{f.StackOp("pop");f.Pc=510;continue;}
case 510:{f.Pc=857;continue;}
case 513:{f.Push(f.Locals[10]);f.Pc=515;continue;}
case 515:{f.Push(JValue.R(rt.String("Beam me up")));f.Pc=517;continue;}
case 517:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",520);}
case 520:{f.Pc=f.Pop().Int==0?580:523;continue;}
case 523:{f.Push(f.Locals[4]);f.Pc=525;continue;}
case 525:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",531);}
case 531:{f.Pc=f.Pop().Int!=0?537:534;continue;}
case 534:{f.Pc=230;continue;}
case 537:{f.Push(f.Locals[9]);f.Pc=539;continue;}
case 539:{f.Push(f.Locals[0]);f.Pc=540;continue;}
case 540:{f.Push(f.Locals[1]);f.Pc=541;continue;}
case 541:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","BeamMeUp","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","BeamMeUp","Lforge/game/spellability/AlternativeCost;"));f.Pc=544;continue;}
case 544:{return rt.Call(f,"forge/game/GameActionUtil","getGraveyardSpellByKeyword","(Lforge/game/keyword/KeywordInterface;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/spellability/AlternativeCost;)Lforge/game/spellability/SpellAbility;","invokestatic",547);}
case 547:{f.Locals[11]=f.Pop();f.Pc=549;continue;}
case 549:{f.Push(f.Locals[11]);f.Pc=551;continue;}
case 551:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",554);}
case 554:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=557;continue;}
case 557:{f.StackOp("dup");f.Pc=558;continue;}
case 558:{f.Push(JValue.R(rt.String("Return<1/Creature.YouCtrl+canBeBeamedUp/creature>")));f.Pc=560;continue;}
case 560:{f.Push(JValue.I(0));f.Pc=561;continue;}
case 561:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",564);}
case 564:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",567);}
case 567:{f.StackOp("pop");f.Pc=568;continue;}
case 568:{f.Push(f.Locals[3]);f.Pc=569;continue;}
case 569:{f.Push(f.Locals[11]);f.Pc=571;continue;}
case 571:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",576);}
case 576:{f.StackOp("pop");f.Pc=577;continue;}
case 577:{f.Pc=857;continue;}
case 580:{f.Push(f.Locals[10]);f.Pc=582;continue;}
case 582:{f.Push(JValue.R(rt.String("Flashback")));f.Pc=584;continue;}
case 584:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",587);}
case 587:{f.Pc=f.Pop().Int==0?648:590;continue;}
case 590:{f.Push(f.Locals[4]);f.Pc=592;continue;}
case 592:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=595;continue;}
case 595:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",598);}
case 598:{f.Pc=f.Pop().Int!=0?604:601;continue;}
case 601:{f.Pc=230;continue;}
case 604:{f.Push(f.Locals[10]);f.Pc=606;continue;}
case 606:{f.Push(JValue.R(rt.String("Flashback")));f.Pc=608;continue;}
case 608:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",611);}
case 611:{f.Pc=f.Pop().Int==0?628:614;continue;}
case 614:{f.Push(f.Locals[4]);f.Pc=616;continue;}
case 616:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",619);}
case 619:{return rt.Call(f,"forge/card/mana/ManaCost","isNoCost","()Z","invokevirtual",622);}
case 622:{f.Pc=f.Pop().Int==0?628:625;continue;}
case 625:{f.Pc=230;continue;}
case 628:{f.Push(f.Locals[3]);f.Pc=629;continue;}
case 629:{f.Push(f.Locals[9]);f.Pc=631;continue;}
case 631:{f.Push(f.Locals[0]);f.Pc=632;continue;}
case 632:{f.Push(f.Locals[1]);f.Pc=633;continue;}
case 633:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Flashback","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Flashback","Lforge/game/spellability/AlternativeCost;"));f.Pc=636;continue;}
case 636:{return rt.Call(f,"forge/game/GameActionUtil","getGraveyardSpellByKeyword","(Lforge/game/keyword/KeywordInterface;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/spellability/AlternativeCost;)Lforge/game/spellability/SpellAbility;","invokestatic",639);}
case 639:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",644);}
case 644:{f.StackOp("pop");f.Pc=645;continue;}
case 645:{f.Pc=857;continue;}
case 648:{f.Push(f.Locals[10]);f.Pc=650;continue;}
case 650:{f.Push(JValue.R(rt.String("Harmonize")));f.Pc=653;continue;}
case 653:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",656);}
case 656:{f.Pc=f.Pop().Int==0?718:659;continue;}
case 659:{f.Push(f.Locals[4]);f.Pc=661;continue;}
case 661:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=664;continue;}
case 664:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",667);}
case 667:{f.Pc=f.Pop().Int!=0?673:670;continue;}
case 670:{f.Pc=230;continue;}
case 673:{f.Push(f.Locals[10]);f.Pc=675;continue;}
case 675:{f.Push(JValue.R(rt.String("Harmonize")));f.Pc=678;continue;}
case 678:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",681);}
case 681:{f.Pc=f.Pop().Int==0?698:684;continue;}
case 684:{f.Push(f.Locals[4]);f.Pc=686;continue;}
case 686:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",689);}
case 689:{return rt.Call(f,"forge/card/mana/ManaCost","isNoCost","()Z","invokevirtual",692);}
case 692:{f.Pc=f.Pop().Int==0?698:695;continue;}
case 695:{f.Pc=230;continue;}
case 698:{f.Push(f.Locals[3]);f.Pc=699;continue;}
case 699:{f.Push(f.Locals[9]);f.Pc=701;continue;}
case 701:{f.Push(f.Locals[0]);f.Pc=702;continue;}
case 702:{f.Push(f.Locals[1]);f.Pc=703;continue;}
case 703:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Harmonize","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Harmonize","Lforge/game/spellability/AlternativeCost;"));f.Pc=706;continue;}
case 706:{return rt.Call(f,"forge/game/GameActionUtil","getGraveyardSpellByKeyword","(Lforge/game/keyword/KeywordInterface;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/spellability/AlternativeCost;)Lforge/game/spellability/SpellAbility;","invokestatic",709);}
case 709:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",714);}
case 714:{f.StackOp("pop");f.Pc=715;continue;}
case 715:{f.Pc=857;continue;}
case 718:{f.Push(f.Locals[10]);f.Pc=720;continue;}
case 720:{f.Push(JValue.R(rt.String("Foretell")));f.Pc=723;continue;}
case 723:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",726);}
case 726:{f.Pc=f.Pop().Int==0?857:729;continue;}
case 729:{f.Push(f.Locals[4]);f.Pc=731;continue;}
case 731:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=734;continue;}
case 734:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",737);}
case 737:{f.Pc=f.Pop().Int==0?230:740;continue;}
case 740:{f.Push(f.Locals[4]);f.Pc=742;continue;}
case 742:{return rt.Call(f,"forge/game/card/Card","isForetold","()Z","invokevirtual",745);}
case 745:{f.Pc=f.Pop().Int==0?230:748;continue;}
case 748:{f.Push(f.Locals[4]);f.Pc=750;continue;}
case 750:{return rt.Call(f,"forge/game/card/Card","enteredThisTurn","()Z","invokevirtual",753);}
case 753:{f.Pc=f.Pop().Int!=0?230:756;continue;}
case 756:{f.Push(f.Locals[1]);f.Pc=757;continue;}
case 757:{f.Push(f.Locals[4]);f.Pc=759;continue;}
case 759:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",762);}
case 762:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",765);}
case 765:{f.Pc=f.Pop().Int!=0?771:768;continue;}
case 768:{f.Pc=230;continue;}
case 771:{f.Push(f.Locals[10]);f.Pc=773;continue;}
case 773:{f.Push(JValue.R(rt.String("Foretell")));f.Pc=776;continue;}
case 776:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",779);}
case 779:{f.Pc=f.Pop().Int==0?785:782;continue;}
case 782:{f.Pc=230;continue;}
case 785:{f.Push(f.Locals[0]);f.Pc=786;continue;}
case 786:{f.Push(f.Locals[1]);f.Pc=787;continue;}
case 787:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokevirtual",790);}
case 790:{f.Locals[11]=f.Pop();f.Pc=792;continue;}
case 792:{f.Push(f.Locals[11]);f.Pc=794;continue;}
case 794:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Foretold","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Foretold","Lforge/game/spellability/AlternativeCost;"));f.Pc=797;continue;}
case 797:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",800);}
case 800:{f.Push(f.Locals[11]);f.Pc=802;continue;}
case 802:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",805);}
case 805:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=808;continue;}
case 808:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",811);}
case 811:{f.Push(f.Locals[11]);f.Pc=813;continue;}
case 813:{f.Push(JValue.R(rt.String("AfterDescription")));f.Pc=815;continue;}
case 815:{f.Push(JValue.R(rt.String("(Foretold)")));f.Pc=818;continue;}
case 818:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",821);}
case 821:{f.StackOp("pop");f.Pc=822;continue;}
case 822:{f.Push(f.Locals[10]);f.Pc=824;continue;}
case 824:{f.Push(JValue.R(rt.String(":")));f.Pc=826;continue;}
case 826:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",829);}
case 829:{f.Locals[12]=f.Pop();f.Pc=831;continue;}
case 831:{f.Push(f.Locals[11]);f.Pc=833;continue;}
case 833:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=836;continue;}
case 836:{f.StackOp("dup");f.Pc=837;continue;}
case 837:{f.Push(f.Locals[12]);f.Pc=839;continue;}
case 839:{f.Push(JValue.I(1));f.Pc=840;continue;}
case 840:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=841;continue;}
case 841:{f.Push(JValue.I(0));f.Pc=842;continue;}
case 842:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",845);}
case 845:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPayCosts","(Lforge/game/cost/Cost;)V","invokevirtual",848);}
case 848:{f.Push(f.Locals[3]);f.Pc=849;continue;}
case 849:{f.Push(f.Locals[11]);f.Pc=851;continue;}
case 851:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",856);}
case 856:{f.StackOp("pop");f.Pc=857;continue;}
case 857:{f.Pc=230;continue;}
case 860:{f.Push(f.Locals[4]);f.Pc=862;continue;}
case 862:{return rt.Call(f,"forge/game/card/Card","isForetoldCostByEffect","()Z","invokevirtual",865);}
case 865:{f.Pc=f.Pop().Int==0?997:868;continue;}
case 868:{f.Push(f.Locals[4]);f.Pc=870;continue;}
case 870:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=873;continue;}
case 873:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",876);}
case 876:{f.Pc=f.Pop().Int==0?997:879;continue;}
case 879:{f.Push(f.Locals[1]);f.Pc=880;continue;}
case 880:{f.Push(f.Locals[4]);f.Pc=882;continue;}
case 882:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",885);}
case 885:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",888);}
case 888:{f.Pc=f.Pop().Int==0?997:891;continue;}
case 891:{f.Push(f.Locals[4]);f.Pc=893;continue;}
case 893:{return rt.Call(f,"forge/game/card/Card","isForetold","()Z","invokevirtual",896);}
case 896:{f.Pc=f.Pop().Int==0?997:899;continue;}
case 899:{f.Push(f.Locals[4]);f.Pc=901;continue;}
case 901:{return rt.Call(f,"forge/game/card/Card","enteredThisTurn","()Z","invokevirtual",904);}
case 904:{f.Pc=f.Pop().Int!=0?997:907;continue;}
case 907:{f.Push(f.Locals[4]);f.Pc=909;continue;}
case 909:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",912);}
case 912:{return rt.Call(f,"forge/card/mana/ManaCost","isNoCost","()Z","invokevirtual",915);}
case 915:{f.Pc=f.Pop().Int!=0?997:918;continue;}
case 918:{f.Push(f.Locals[0]);f.Pc=919;continue;}
case 919:{f.Push(f.Locals[1]);f.Pc=920;continue;}
case 920:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokevirtual",923);}
case 923:{f.Locals[8]=f.Pop();f.Pc=925;continue;}
case 925:{f.Push(JValue.I(2));f.Pc=926;continue;}
case 926:{f.Push(f.Locals[0]);f.Pc=927;continue;}
case 927:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",930);}
case 930:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",933);}
case 933:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",936);}
case 936:{return rt.Call(f,"forge/card/mana/ManaCost","getGenericCost","()I","invokevirtual",939);}
case 939:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",942);}
case 942:{f.Locals[9]=f.Pop();f.Pc=944;continue;}
case 944:{f.Push(f.Locals[8]);f.Pc=946;continue;}
case 946:{f.Push(JValue.R(rt.String("ReduceCost")));f.Pc=949;continue;}
case 949:{f.Push(f.Locals[9]);f.Pc=951;continue;}
case 951:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",954);}
case 954:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",957);}
case 957:{f.StackOp("pop");f.Pc=958;continue;}
case 958:{f.Push(f.Locals[8]);f.Pc=960;continue;}
case 960:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Foretold","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Foretold","Lforge/game/spellability/AlternativeCost;"));f.Pc=963;continue;}
case 963:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",966);}
case 966:{f.Push(f.Locals[8]);f.Pc=968;continue;}
case 968:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",971);}
case 971:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=974;continue;}
case 974:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",977);}
case 977:{f.Push(f.Locals[8]);f.Pc=979;continue;}
case 979:{f.Push(JValue.R(rt.String("AfterDescription")));f.Pc=981;continue;}
case 981:{f.Push(JValue.R(rt.String("(Foretold)")));f.Pc=984;continue;}
case 984:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",987);}
case 987:{f.StackOp("pop");f.Pc=988;continue;}
case 988:{f.Push(f.Locals[3]);f.Pc=989;continue;}
case 989:{f.Push(f.Locals[8]);f.Pc=991;continue;}
case 991:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",996);}
case 996:{f.StackOp("pop");f.Pc=997;continue;}
case 997:{f.Push(f.Locals[1]);f.Pc=998;continue;}
case 998:{return rt.Call(f,"forge/game/player/Player","canCastSorcery","()Z","invokevirtual",1001);}
case 1001:{f.Pc=f.Pop().Int==0?1089:1004;continue;}
case 1004:{f.Push(f.Locals[4]);f.Pc=1006;continue;}
case 1006:{return rt.Call(f,"forge/game/card/Card","isPlotted","()Z","invokevirtual",1009);}
case 1009:{f.Pc=f.Pop().Int==0?1089:1012;continue;}
case 1012:{f.Push(f.Locals[4]);f.Pc=1014;continue;}
case 1014:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=1017;continue;}
case 1017:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",1020);}
case 1020:{f.Pc=f.Pop().Int==0?1089:1023;continue;}
case 1023:{f.Push(f.Locals[1]);f.Pc=1024;continue;}
case 1024:{f.Push(f.Locals[4]);f.Pc=1026;continue;}
case 1026:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1029);}
case 1029:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1032);}
case 1032:{f.Pc=f.Pop().Int==0?1089:1035;continue;}
case 1035:{f.Push(f.Locals[4]);f.Pc=1037;continue;}
case 1037:{return rt.Call(f,"forge/game/card/Card","enteredThisTurn","()Z","invokevirtual",1040);}
case 1040:{f.Pc=f.Pop().Int!=0?1089:1043;continue;}
case 1043:{f.Push(f.Locals[0]);f.Pc=1044;continue;}
case 1044:{f.Push(f.Locals[1]);f.Pc=1045;continue;}
case 1045:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithNoManaCost","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokevirtual",1048);}
case 1048:{f.Locals[8]=f.Pop();f.Pc=1050;continue;}
case 1050:{f.Push(f.Locals[8]);f.Pc=1052;continue;}
case 1052:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Plotted","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Plotted","Lforge/game/spellability/AlternativeCost;"));f.Pc=1055;continue;}
case 1055:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",1058);}
case 1058:{f.Push(f.Locals[8]);f.Pc=1060;continue;}
case 1060:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",1063);}
case 1063:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=1066;continue;}
case 1066:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",1069);}
case 1069:{f.Push(f.Locals[8]);f.Pc=1071;continue;}
case 1071:{f.Push(JValue.R(rt.String("AfterDescription")));f.Pc=1073;continue;}
case 1073:{f.Push(JValue.R(rt.String("(Plotted)")));f.Pc=1076;continue;}
case 1076:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1079);}
case 1079:{f.StackOp("pop");f.Pc=1080;continue;}
case 1080:{f.Push(f.Locals[3]);f.Pc=1081;continue;}
case 1081:{f.Push(f.Locals[8]);f.Pc=1083;continue;}
case 1083:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1088);}
case 1088:{f.StackOp("pop");f.Pc=1089;continue;}
case 1089:{f.Push(f.Locals[5]);f.Pc=1091;continue;}
case 1091:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1094);}
case 1094:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=1097;continue;}
case 1097:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=1100;continue;}
case 1100:{return rt.Call(f,"forge/game/GameAction","hasStaticAbilityAffectingZone","(Lforge/game/zone/ZoneType;Lforge/game/staticability/StaticAbilityLayer;)Z","invokevirtual",1103);}
case 1103:{f.Pc=f.Pop().Int==0?1336:1106;continue;}
case 1106:{f.Push(f.Locals[4]);f.Pc=1108;continue;}
case 1108:{return rt.Call(f,"forge/game/card/Card","getMayPlay","()Ljava/util/Map;","invokevirtual",1111);}
case 1111:{f.Locals[8]=f.Pop();f.Pc=1113;continue;}
case 1113:{f.Push(f.Locals[4]);f.Pc=1115;continue;}
case 1115:{return rt.Call(f,"forge/game/card/Card","getLastKnownZone","()Lforge/game/zone/Zone;","invokevirtual",1118);}
case 1118:{f.Locals[9]=f.Pop();f.Pc=1120;continue;}
case 1120:{f.Push(f.Locals[4]);f.Pc=1122;continue;}
case 1122:{f.Locals[10]=f.Pop();f.Pc=1124;continue;}
case 1124:{f.Push(f.Locals[4]);f.Pc=1126;continue;}
case 1126:{return rt.Call(f,"forge/game/card/Card","isLKI","()Z","invokevirtual",1129);}
case 1129:{f.Pc=f.Pop().Int!=0?1139:1132;continue;}
case 1132:{f.Push(f.Locals[4]);f.Pc=1134;continue;}
case 1134:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",1137);}
case 1137:{f.Locals[10]=f.Pop();f.Pc=1139;continue;}
case 1139:{f.Push(f.Locals[10]);f.Pc=1141;continue;}
case 1141:{f.Push(f.Locals[5]);f.Pc=1143;continue;}
case 1143:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",1146);}
case 1146:{return rt.Call(f,"forge/game/card/Card","setLastKnownZone","(Lforge/game/zone/Zone;)V","invokevirtual",1149);}
case 1149:{f.Push(f.Locals[10]);f.Pc=1151;continue;}
case 1151:{f.Push(f.Locals[9]);f.Pc=1153;continue;}
case 1153:{return rt.Call(f,"forge/game/card/Card","setCastFrom","(Lforge/game/zone/Zone;)V","invokevirtual",1156);}
case 1156:{f.Push(f.Locals[10]);f.Pc=1158;continue;}
case 1158:{f.Push(f.Locals[0]);f.Pc=1159;continue;}
case 1159:{return rt.Call(f,"forge/game/card/Card","setCastSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1162);}
case 1162:{f.Push(JValue.I(1));f.Pc=1163;continue;}
case 1163:{f.Locals[6]=f.Pop();f.Pc=1165;continue;}
case 1165:{f.Push(f.Locals[10]);f.Pc=1167;continue;}
case 1167:{f.Push(JValue.I(0));f.Pc=1168;continue;}
case 1168:{return rt.Call(f,"forge/game/card/Card","clearStaticChangedCardKeywords","(Z)Z","invokevirtual",1171);}
case 1171:{f.StackOp("pop");f.Pc=1172;continue;}
case 1172:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1175;continue;}
case 1175:{f.StackOp("dup");f.Pc=1176;continue;}
case 1176:{f.Push(f.Locals[10]);f.Pc=1178;continue;}
case 1178:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",1181);}
case 1181:{f.Locals[11]=f.Pop();f.Pc=1183;continue;}
case 1183:{f.Push(f.Locals[5]);f.Pc=1185;continue;}
case 1185:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1188);}
case 1188:{f.Push(JValue.I(0));f.Pc=1189;continue;}
case 1189:{f.Push(JValue.I(1));f.Pc=1190;continue;}
case 1190:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=1193;continue;}
case 1193:{f.StackOp("dup");f.Pc=1194;continue;}
case 1194:{f.Push(JValue.I(0));f.Pc=1195;continue;}
case 1195:{f.Push(f.Locals[10]);f.Pc=1197;continue;}
case 1197:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1198;continue;}
case 1198:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","([Ljava/lang/Object;)Ljava/util/HashSet;","invokestatic",1201);}
case 1201:{f.Push(f.Locals[11]);f.Pc=1203;continue;}
case 1203:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;)V","invokevirtual",1206);}
case 1206:{f.Push(f.Locals[10]);f.Pc=1208;continue;}
case 1208:{f.Push(f.Locals[8]);f.Pc=1210;continue;}
case 1210:{return rt.Call(f,"forge/game/card/Card","setMayPlay","(Ljava/util/Map;)Ljava/util/Map;","invokevirtual",1213);}
case 1213:{f.StackOp("pop");f.Pc=1214;continue;}
case 1214:{f.Push(f.Locals[10]);f.Pc=1216;continue;}
case 1216:{return rt.Call(f,"forge/game/card/Card","getUnhiddenKeywords","()Lforge/game/keyword/KeywordCollection;","invokevirtual",1219);}
case 1219:{return rt.Call(f,"forge/game/keyword/KeywordCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1222);}
case 1222:{f.Locals[12]=f.Pop();f.Pc=1224;continue;}
case 1224:{f.Push(f.Locals[12]);f.Pc=1226;continue;}
case 1226:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1231);}
case 1231:{f.Pc=f.Pop().Int==0?1329:1234;continue;}
case 1234:{f.Push(f.Locals[12]);f.Pc=1236;continue;}
case 1236:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1241);}
case 1241:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1244;continue;}
case 1244:{f.Locals[13]=f.Pop();f.Pc=1246;continue;}
case 1246:{f.Push(f.Locals[13]);f.Pc=1248;continue;}
case 1248:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getAbilities","()Ljava/util/Collection;","invokeinterface",1253);}
case 1253:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",1258);}
case 1258:{f.Locals[14]=f.Pop();f.Pc=1260;continue;}
case 1260:{f.Push(f.Locals[14]);f.Pc=1262;continue;}
case 1262:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1267);}
case 1267:{f.Pc=f.Pop().Int==0?1326:1270;continue;}
case 1270:{f.Push(f.Locals[14]);f.Pc=1272;continue;}
case 1272:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1277);}
case 1277:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1280;continue;}
case 1280:{f.Locals[15]=f.Pop();f.Pc=1282;continue;}
case 1282:{f.Push(f.Locals[15]);f.Pc=1284;continue;}
case 1284:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",1287);}
case 1287:{f.Pc=f.Pop().Int==0?1323:1290;continue;}
case 1290:{f.Push(f.Locals[15]);f.Pc=1292;continue;}
case 1292:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",1295);}
case 1295:{f.Pc=f.Pop().Int!=0?1323:1298;continue;}
case 1298:{f.Push(f.Locals[3]);f.Pc=1299;continue;}
case 1299:{f.Push(f.Locals[15]);f.Pc=1301;continue;}
case 1301:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1306);}
case 1306:{f.StackOp("pop");f.Pc=1307;continue;}
case 1307:{f.Push(f.Locals[3]);f.Pc=1308;continue;}
case 1308:{f.Push(f.Locals[15]);f.Pc=1310;continue;}
case 1310:{f.Push(f.Locals[10]);f.Pc=1312;continue;}
case 1312:{f.Push(f.Locals[1]);f.Pc=1313;continue;}
case 1313:{f.Push(f.Locals[2]);f.Pc=1314;continue;}
case 1314:{return rt.Call(f,"forge/game/GameActionUtil","getMayPlaySpellOptions","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;Z)Ljava/util/List;","invokestatic",1317);}
case 1317:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",1322);}
case 1322:{f.StackOp("pop");f.Pc=1323;continue;}
case 1323:{f.Pc=1260;continue;}
case 1326:{f.Pc=1224;continue;}
case 1329:{f.Push(f.Locals[10]);f.Pc=1331;continue;}
case 1331:{f.Push(f.Locals[9]);f.Pc=1333;continue;}
case 1333:{return rt.Call(f,"forge/game/card/Card","setLastKnownZone","(Lforge/game/zone/Zone;)V","invokevirtual",1336);}
case 1336:{f.Push(f.Locals[6]);f.Pc=1338;continue;}
case 1338:{f.Pc=f.Pop().Int==0?1366:1341;continue;}
case 1341:{f.Push(f.Locals[5]);f.Pc=1343;continue;}
case 1343:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1346);}
case 1346:{f.Push(JValue.I(0));f.Pc=1347;continue;}
case 1347:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(Z)V","invokevirtual",1350);}
case 1350:{f.Push(f.Locals[5]);f.Pc=1352;continue;}
case 1352:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",1355);}
case 1355:{return rt.Call(f,"forge/trackable/Tracker","clearDelayed","()V","invokevirtual",1358);}
case 1358:{f.Push(f.Locals[5]);f.Pc=1360;continue;}
case 1360:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",1363);}
case 1363:{return rt.Call(f,"forge/trackable/Tracker","unfreeze","()V","invokevirtual",1366);}
case 1366:{f.Pc=1517;continue;}
case 1369:{f.Push(f.Locals[0]);f.Pc=1370;continue;}
case 1370:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManaAbility","()Z","invokevirtual",1373);}
case 1373:{f.Pc=f.Pop().Int==0?1503:1376;continue;}
case 1376:{f.Push(f.Locals[0]);f.Pc=1377;continue;}
case 1377:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",1380);}
case 1380:{f.Pc=f.Pop().Int==0?1503:1383;continue;}
case 1383:{f.Push(f.Locals[1]);f.Pc=1384;continue;}
case 1384:{f.Push(JValue.R(rt.String("Piracy")));f.Pc=1387;continue;}
case 1387:{return rt.Call(f,"forge/game/player/Player","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",1390);}
case 1390:{f.Pc=f.Pop().Int==0?1503:1393;continue;}
case 1393:{f.Push(f.Locals[4]);f.Pc=1395;continue;}
case 1395:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",1398);}
case 1398:{f.Pc=f.Pop().Int==0?1503:1401;continue;}
case 1401:{f.Push(f.Locals[4]);f.Pc=1403;continue;}
case 1403:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",1406);}
case 1406:{f.Pc=f.Pop().Int==0?1503:1409;continue;}
case 1409:{f.Push(f.Locals[1]);f.Pc=1410;continue;}
case 1410:{f.Push(f.Locals[4]);f.Pc=1412;continue;}
case 1412:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1415);}
case 1415:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1418);}
case 1418:{f.Pc=f.Pop().Int!=0?1503:1421;continue;}
case 1421:{f.Push(f.Locals[0]);f.Pc=1422;continue;}
case 1422:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",1425);}
case 1425:{return rt.Call(f,"forge/game/cost/Cost","hasTapCost","()Z","invokevirtual",1428);}
case 1428:{f.Pc=f.Pop().Int==0?1503:1431;continue;}
case 1431:{f.Push(f.Locals[0]);f.Pc=1432;continue;}
case 1432:{f.Push(f.Locals[1]);f.Pc=1433;continue;}
case 1433:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokevirtual",1436);}
case 1436:{f.Locals[6]=f.Pop();f.Pc=1438;continue;}
case 1438:{f.Push(f.Locals[6]);f.Pc=1440;continue;}
case 1440:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",1443);}
case 1443:{f.Push(JValue.R(rt.String("Player")));f.Pc=1446;continue;}
case 1446:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setActivator","(Ljava/lang/String;)V","invokevirtual",1449);}
case 1449:{f.Push(f.Locals[6]);f.Pc=1451;continue;}
case 1451:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAllManaParts","()Ljava/util/List;","invokevirtual",1454);}
case 1454:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1459);}
case 1459:{f.Locals[7]=f.Pop();f.Pc=1461;continue;}
case 1461:{f.Push(f.Locals[7]);f.Pc=1463;continue;}
case 1463:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1468);}
case 1468:{f.Pc=f.Pop().Int==0?1494:1471;continue;}
case 1471:{f.Push(f.Locals[7]);f.Pc=1473;continue;}
case 1473:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1478);}
case 1478:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilityManaPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1481;continue;}
case 1481:{f.Locals[8]=f.Pop();f.Pc=1483;continue;}
case 1483:{f.Push(f.Locals[8]);f.Pc=1485;continue;}
case 1485:{f.Push(JValue.R(rt.String("Spell")));f.Pc=1488;continue;}
case 1488:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","setExtraManaRestriction","(Ljava/lang/String;)V","invokevirtual",1491);}
case 1491:{f.Pc=1461;continue;}
case 1494:{f.Push(f.Locals[3]);f.Pc=1495;continue;}
case 1495:{f.Push(f.Locals[6]);f.Pc=1497;continue;}
case 1497:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1502);}
case 1502:{f.StackOp("pop");f.Pc=1503;continue;}
case 1503:{f.Push(f.Locals[3]);f.Pc=1504;continue;}
case 1504:{f.Push(f.Locals[0]);f.Pc=1505;continue;}
case 1505:{f.Push(f.Locals[4]);f.Pc=1507;continue;}
case 1507:{f.Push(f.Locals[1]);f.Pc=1508;continue;}
case 1508:{return rt.Call(f,"forge/game/staticability/StaticAbilityAlternativeCost","alternativeCosts","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",1511);}
case 1511:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",1516);}
case 1516:{f.StackOp("pop");f.Pc=1517;continue;}
case 1517:{f.Push(f.Locals[3]);f.Pc=1518;continue;}
case 1518:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2147(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",6);}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{f.Locals[5]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String(":")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?147:21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String(":")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",28);}
case 28:{f.Locals[6]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[6]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",44);}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithManaCostReplaced","(Lforge/game/player/Player;Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",47);}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[6]);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=52;continue;}
case 52:{f.Push(JValue.I(2));f.Pc=53;continue;}
case 53:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?63:56;continue;}
case 56:{f.Push(f.Locals[6]);f.Pc=58;continue;}
case 58:{f.Push(JValue.I(2));f.Pc=59;continue;}
case 59:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=60;continue;}
case 60:{f.Pc=66;continue;}
case 63:{f.Push(JValue.R(rt.String("")));f.Pc=66;continue;}
case 66:{f.Locals[7]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[7]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int!=0?144:76;continue;}
case 76:{f.Push(f.Locals[7]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/ability/AbilityFactory","getMapParams","(Ljava/lang/String;)Ljava/util/Map;","invokestatic",81);}
case 81:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",86);}
case 86:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",91);}
case 91:{f.Locals[8]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[8]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",100);}
case 100:{f.Pc=f.Pop().Int==0?144:103;continue;}
case 103:{f.Push(f.Locals[8]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",110);}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{f.Locals[9]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[5]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[9]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",124);}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",134);}
case 134:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",140);}
case 140:{f.StackOp("pop");f.Pc=141;continue;}
case 141:{f.Pc=93;continue;}
case 144:{f.Pc=154;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokevirtual",152);}
case 152:{f.Locals[5]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[5]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",160);}
case 160:{f.Push(f.Locals[5]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",165);}
case 165:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",171);}
case 171:{f.Push(f.Locals[5]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/spellability/SpellAbility","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",177);}
case 177:{f.Push(f.Locals[5]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/keyword/KeywordInterface","isIntrinsic","()Z","invokeinterface",185);}
case 185:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",188);}
case 188:{f.Push(f.Locals[5]);f.Pc=190;continue;}
case 190:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2148(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[4]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?22:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?22:19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","mayPlay","(Lforge/game/player/Player;)Ljava/util/List;","invokevirtual",27);}
case 27:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",32);}
case 32:{f.Locals[5]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?536:44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardPlayOption"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[6]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[6]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/CardPlayOption","getAbility","()Lforge/game/staticability/StaticAbility;","invokevirtual",61);}
case 61:{f.Push(JValue.R(rt.String("MayPlayNotSorcerySpeed")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int==0?80:70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/player/Player","canCastSorcery","()Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?80:77;continue;}
case 77:{f.Pc=34;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBasicSpell","()Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?117:87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbility","costHasManaX","()Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?131:94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",98);}
case 98:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Reference==null?131:104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",108);}
case 108:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",111);}
case 111:{return rt.Call(f,"forge/game/cost/CostPartMana","getXMin","()I","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int<=0?131:117;continue;}
case 117:{f.Push(f.Locals[6]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/card/CardPlayOption","getPayManaCost","()Lforge/game/card/CardPlayOption$PayManaCost;","invokevirtual",122);}
case 122:{if(!rt.StaticReady(f,"forge/game/card/CardPlayOption$PayManaCost","NO","Lforge/game/card/CardPlayOption$PayManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPlayOption$PayManaCost","NO","Lforge/game/card/CardPlayOption$PayManaCost;"));f.Pc=125;continue;}
case 125:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?131:128;continue;}
case 128:{f.Pc=34;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","WARP","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","WARP","Lforge/game/keyword/Keyword;"));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int==0?159:141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",145);}
case 145:{f.Push(f.Locals[6]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/card/CardPlayOption","getHost","()Lforge/game/card/Card;","invokevirtual",150);}
case 150:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int!=0?159:156;continue;}
case 156:{f.Pc=34;continue;}
case 159:{f.Push(f.Locals[6]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/card/CardPlayOption","getHost","()Lforge/game/card/Card;","invokevirtual",164);}
case 164:{f.Locals[7]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[6]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/card/CardPlayOption","getPayManaCost","()Lforge/game/card/CardPlayOption$PayManaCost;","invokevirtual",171);}
case 171:{if(!rt.StaticReady(f,"forge/game/card/CardPlayOption$PayManaCost","NO","Lforge/game/card/CardPlayOption$PayManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPlayOption$PayManaCost","NO","Lforge/game/card/CardPlayOption$PayManaCost;"));f.Pc=174;continue;}
case 174:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?193:177;continue;}
case 177:{f.Push(f.Locals[0]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[2]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithNoManaCost","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokevirtual",182);}
case 182:{f.Locals[8]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[8]);f.Pc=186;continue;}
case 186:{f.Push(JValue.I(0));f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/spellability/SpellAbility","setBasicSpell","(Z)V","invokevirtual",190);}
case 190:{f.Pc=236;continue;}
case 193:{f.Push(f.Locals[6]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/card/CardPlayOption","getAltManaCost","()Lforge/game/cost/Cost;","invokevirtual",198);}
case 198:{f.Pc=f.Pop().Reference==null?222:201;continue;}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[2]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[6]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/card/CardPlayOption","getAltManaCost","()Lforge/game/cost/Cost;","invokevirtual",208);}
case 208:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithManaCostReplaced","(Lforge/game/player/Player;Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",211);}
case 211:{f.Locals[8]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[8]);f.Pc=215;continue;}
case 215:{f.Push(JValue.I(0));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/spellability/SpellAbility","setBasicSpell","(Z)V","invokevirtual",219);}
case 219:{f.Pc=236;continue;}
case 222:{f.Push(f.Locals[3]);f.Pc=223;continue;}
case 223:{f.Pc=f.Pop().Int==0?229:226;continue;}
case 226:{f.Pc=34;continue;}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[2]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokevirtual",234);}
case 234:{f.Locals[8]=f.Pop();f.Pc=236;continue;}
case 236:{f.Push(f.Locals[6]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/card/CardPlayOption","getAbility","()Lforge/game/staticability/StaticAbility;","invokevirtual",241);}
case 241:{f.Push(JValue.R(rt.String("ValidAfterStack")));f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",247);}
case 247:{f.Pc=f.Pop().Int==0?275:250;continue;}
case 250:{f.Push(f.Locals[8]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",255);}
case 255:{f.Push(JValue.R(rt.String("ValidAfterStack")));f.Pc=258;continue;}
case 258:{f.Push(f.Locals[6]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/card/CardPlayOption","getAbility","()Lforge/game/staticability/StaticAbility;","invokevirtual",263);}
case 263:{f.Push(JValue.R(rt.String("ValidAfterStack")));f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",269);}
case 269:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",274);}
case 274:{f.StackOp("pop");f.Pc=275;continue;}
case 275:{f.Push(f.Locals[6]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/card/CardPlayOption","getAbility","()Lforge/game/staticability/StaticAbility;","invokevirtual",280);}
case 280:{f.Push(JValue.R(rt.String("RaiseCost")));f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",286);}
case 286:{f.Pc=f.Pop().Int==0?348:289;continue;}
case 289:{f.Push(f.Locals[6]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/card/CardPlayOption","getAbility","()Lforge/game/staticability/StaticAbility;","invokevirtual",294);}
case 294:{f.Push(JValue.R(rt.String("RaiseCost")));f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",300);}
case 300:{f.Locals[9]=f.Pop();f.Pc=302;continue;}
case 302:{f.Push(f.Locals[6]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/card/CardPlayOption","getAbility","()Lforge/game/staticability/StaticAbility;","invokevirtual",307);}
case 307:{f.Push(f.Locals[9]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasSVar","(Ljava/lang/String;)Z","invokevirtual",312);}
case 312:{f.Pc=f.Pop().Int==0?332:315;continue;}
case 315:{f.Push(f.Locals[7]);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[9]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[6]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/card/CardPlayOption","getAbility","()Lforge/game/staticability/StaticAbility;","invokevirtual",324);}
case 324:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",327);}
case 327:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",330);}
case 330:{f.Locals[9]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[8]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",337);}
case 337:{f.Push(JValue.R(rt.String("RaiseCost")));f.Pc=340;continue;}
case 340:{f.Push(f.Locals[9]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",347);}
case 347:{f.StackOp("pop");f.Pc=348;continue;}
case 348:{f.Push(f.Locals[8]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",353);}
case 353:{f.Locals[9]=f.Pop();f.Pc=355;continue;}
case 355:{f.Push(f.Locals[6]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/card/CardPlayOption","isWithFlash","()Z","invokevirtual",360);}
case 360:{f.Pc=f.Pop().Int==0?369:363;continue;}
case 363:{f.Push(f.Locals[9]);f.Pc=365;continue;}
case 365:{f.Push(JValue.I(1));f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setInstantSpeed","(Z)V","invokevirtual",369);}
case 369:{f.Push(f.Locals[9]);f.Pc=371;continue;}
case 371:{f.Push(JValue.R(null));f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",375);}
case 375:{f.Push(f.Locals[8]);f.Pc=377;continue;}
case 377:{f.Push(f.Locals[6]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/spellability/SpellAbility","setMayPlay","(Lforge/game/card/CardPlayOption;)V","invokevirtual",382);}
case 382:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=385;continue;}
case 385:{f.StackOp("dup");f.Pc=386;continue;}
case 386:{f.Push(f.Locals[0]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",390);}
case 390:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",393);}
case 393:{f.Locals[10]=f.Pop();f.Pc=395;continue;}
case 395:{f.Push(f.Locals[1]);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[7]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",401);}
case 401:{f.Pc=f.Pop().Int!=0?459:404;continue;}
case 404:{f.Push(f.Locals[7]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/card/Card","getRenderForUI","()Z","invokevirtual",409);}
case 409:{f.Pc=f.Pop().Int==0?459:412;continue;}
case 412:{f.Push(f.Locals[10]);f.Pc=414;continue;}
case 414:{f.Push(JValue.R(rt.String(" by ")));f.Pc=417;continue;}
case 417:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",420);}
case 420:{f.StackOp("pop");f.Pc=421;continue;}
case 421:{f.Push(f.Locals[7]);f.Pc=423;continue;}
case 423:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",426);}
case 426:{f.Pc=f.Pop().Int==0?451:429;continue;}
case 429:{f.Push(f.Locals[7]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",434);}
case 434:{f.Pc=f.Pop().Reference==null?451:437;continue;}
case 437:{f.Push(f.Locals[10]);f.Pc=439;continue;}
case 439:{f.Push(f.Locals[7]);f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",444);}
case 444:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",447);}
case 447:{f.StackOp("pop");f.Pc=448;continue;}
case 448:{f.Pc=459;continue;}
case 451:{f.Push(f.Locals[10]);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[7]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",458);}
case 458:{f.StackOp("pop");f.Pc=459;continue;}
case 459:{f.Push(f.Locals[6]);f.Pc=461;continue;}
case 461:{return rt.Call(f,"forge/game/card/CardPlayOption","getAbility","()Lforge/game/staticability/StaticAbility;","invokevirtual",464);}
case 464:{f.Push(JValue.R(rt.String("MayPlayText")));f.Pc=467;continue;}
case 467:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",470);}
case 470:{f.Pc=f.Pop().Int==0?501:473;continue;}
case 473:{f.Push(f.Locals[10]);f.Pc=475;continue;}
case 475:{f.Push(JValue.R(rt.String(" (")));f.Pc=478;continue;}
case 478:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",481);}
case 481:{f.Push(f.Locals[6]);f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/card/CardPlayOption","getAbility","()Lforge/game/staticability/StaticAbility;","invokevirtual",486);}
case 486:{f.Push(JValue.R(rt.String("MayPlayText")));f.Pc=489;continue;}
case 489:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",492);}
case 492:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",495);}
case 495:{f.Push(JValue.R(rt.String(")")));f.Pc=497;continue;}
case 497:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",500);}
case 500:{f.StackOp("pop");f.Pc=501;continue;}
case 501:{f.Push(f.Locals[10]);f.Pc=503;continue;}
case 503:{f.Push(f.Locals[6]);f.Pc=505;continue;}
case 505:{f.Push(JValue.I(0));f.Pc=506;continue;}
case 506:{return rt.Call(f,"forge/game/card/CardPlayOption","toString","(Z)Ljava/lang/String;","invokevirtual",509);}
case 509:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",512);}
case 512:{f.StackOp("pop");f.Pc=513;continue;}
case 513:{f.Push(f.Locals[8]);f.Pc=515;continue;}
case 515:{f.Push(f.Locals[10]);f.Pc=517;continue;}
case 517:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",520);}
case 520:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",523);}
case 523:{f.Push(f.Locals[4]);f.Pc=525;continue;}
case 525:{f.Push(f.Locals[8]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",532);}
case 532:{f.StackOp("pop");f.Pc=533;continue;}
case 533:{f.Pc=34;continue;}
case 536:{f.Push(f.Locals[4]);f.Pc=538;continue;}
case 538:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2149(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference==null?15:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int!=0?17:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","clearPipsToReduce","()V","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?40:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return JStep.Return(f.Pop());}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAlternateHost","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",48);}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Reference==null?61:55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{f.Locals[2]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{f.Locals[4]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Int==0?110:66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",70);}
case 70:{return rt.Call(f,"forge/trackable/Tracker","freeze","()V","invokevirtual",73);}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/Card","clearStaticChangedCardKeywords","(Z)Z","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=82;continue;}
case 82:{f.StackOp("dup");f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",87);}
case 87:{f.Locals[6]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",93);}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{f.Push(JValue.I(1));f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=98;continue;}
case 98:{f.StackOp("dup");f.Pc=99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=102;continue;}
case 102:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","([Ljava/lang/Object;)Ljava/util/HashSet;","invokestatic",105);}
case 105:{f.Push(f.Locals[6]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;)V","invokevirtual",110);}
case 110:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=113;continue;}
case 113:{f.StackOp("dup");f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",118);}
case 118:{f.Locals[6]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[6]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",129);}
case 129:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",132);}
case 132:{f.StackOp("pop");f.Pc=133;continue;}
case 133:{f.Push(f.Locals[6]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",138);}
case 138:{f.Locals[7]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[7]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",147);}
case 147:{f.Pc=f.Pop().Int==0?507:150;continue;}
case 150:{f.Push(f.Locals[7]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",157);}
case 157:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=160;continue;}
case 160:{f.Locals[8]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[8]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",167);}
case 167:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",172);}
case 172:{f.Locals[9]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[9]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",181);}
case 181:{f.Pc=f.Pop().Int==0?504:184;continue;}
case 184:{f.Push(f.Locals[9]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",191);}
case 191:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=194;continue;}
case 194:{f.Locals[10]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[10]);f.Pc=198;continue;}
case 198:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","OptionalCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","OptionalCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",204);}
case 204:{f.Pc=f.Pop().Int!=0?210:207;continue;}
case 207:{f.Pc=174;continue;}
case 210:{f.Push(f.Locals[10]);f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=215;continue;}
case 215:{f.Push(f.Locals[2]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int!=0?225:222;continue;}
case 222:{f.Pc=174;continue;}
case 225:{f.Push(f.Locals[10]);f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=230;continue;}
case 230:{f.Push(f.Locals[0]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",234);}
case 234:{f.Pc=f.Pop().Int!=0?240:237;continue;}
case 237:{f.Pc=174;continue;}
case 240:{f.Push(f.Locals[10]);f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("Activator")));f.Pc=245;continue;}
case 245:{f.Push(f.Locals[0]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",249);}
case 249:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",252);}
case 252:{f.Pc=f.Pop().Int!=0?258:255;continue;}
case 255:{f.Pc=174;continue;}
case 258:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=261;continue;}
case 261:{f.StackOp("dup");f.Pc=262;continue;}
case 262:{f.Push(f.Locals[10]);f.Pc=264;continue;}
case 264:{f.Push(JValue.R(rt.String("Cost")));f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",270);}
case 270:{f.Push(JValue.I(0));f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",274);}
case 274:{f.Locals[11]=f.Pop();f.Pc=276;continue;}
case 276:{f.Push(f.Locals[10]);f.Pc=278;continue;}
case 278:{f.Push(JValue.R(rt.String("ReduceColor")));f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",284);}
case 284:{f.Pc=f.Pop().Int==0?482:287;continue;}
case 287:{f.Push(f.Locals[10]);f.Pc=289;continue;}
case 289:{f.Push(JValue.R(rt.String("ReduceColor")));f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",295);}
case 295:{f.Push(JValue.R(rt.String("W")));f.Pc=298;continue;}
case 298:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",301);}
case 301:{f.Pc=f.Pop().Int==0?326:304;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=308;continue;}
case 308:{f.StackOp("dup");f.Pc=309;continue;}
case 309:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceW","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","ReduceW","Lforge/game/spellability/OptionalCost;"));f.Pc=312;continue;}
case 312:{f.Push(f.Locals[11]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",317);}
case 317:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",322);}
case 322:{f.StackOp("pop");f.Pc=323;continue;}
case 323:{f.Pc=501;continue;}
case 326:{f.Push(f.Locals[10]);f.Pc=328;continue;}
case 328:{f.Push(JValue.R(rt.String("ReduceColor")));f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",334);}
case 334:{f.Push(JValue.R(rt.String("U")));f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",340);}
case 340:{f.Pc=f.Pop().Int==0?365:343;continue;}
case 343:{f.Push(f.Locals[1]);f.Pc=344;continue;}
case 344:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=347;continue;}
case 347:{f.StackOp("dup");f.Pc=348;continue;}
case 348:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceU","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","ReduceU","Lforge/game/spellability/OptionalCost;"));f.Pc=351;continue;}
case 351:{f.Push(f.Locals[11]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",356);}
case 356:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",361);}
case 361:{f.StackOp("pop");f.Pc=362;continue;}
case 362:{f.Pc=501;continue;}
case 365:{f.Push(f.Locals[10]);f.Pc=367;continue;}
case 367:{f.Push(JValue.R(rt.String("ReduceColor")));f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",373);}
case 373:{f.Push(JValue.R(rt.String("B")));f.Pc=376;continue;}
case 376:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",379);}
case 379:{f.Pc=f.Pop().Int==0?404:382;continue;}
case 382:{f.Push(f.Locals[1]);f.Pc=383;continue;}
case 383:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=386;continue;}
case 386:{f.StackOp("dup");f.Pc=387;continue;}
case 387:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceB","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","ReduceB","Lforge/game/spellability/OptionalCost;"));f.Pc=390;continue;}
case 390:{f.Push(f.Locals[11]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",395);}
case 395:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",400);}
case 400:{f.StackOp("pop");f.Pc=401;continue;}
case 401:{f.Pc=501;continue;}
case 404:{f.Push(f.Locals[10]);f.Pc=406;continue;}
case 406:{f.Push(JValue.R(rt.String("ReduceColor")));f.Pc=409;continue;}
case 409:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",412);}
case 412:{f.Push(JValue.R(rt.String("R")));f.Pc=415;continue;}
case 415:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",418);}
case 418:{f.Pc=f.Pop().Int==0?443:421;continue;}
case 421:{f.Push(f.Locals[1]);f.Pc=422;continue;}
case 422:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=425;continue;}
case 425:{f.StackOp("dup");f.Pc=426;continue;}
case 426:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceR","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","ReduceR","Lforge/game/spellability/OptionalCost;"));f.Pc=429;continue;}
case 429:{f.Push(f.Locals[11]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",434);}
case 434:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",439);}
case 439:{f.StackOp("pop");f.Pc=440;continue;}
case 440:{f.Pc=501;continue;}
case 443:{f.Push(f.Locals[10]);f.Pc=445;continue;}
case 445:{f.Push(JValue.R(rt.String("ReduceColor")));f.Pc=448;continue;}
case 448:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",451);}
case 451:{f.Push(JValue.R(rt.String("G")));f.Pc=454;continue;}
case 454:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",457);}
case 457:{f.Pc=f.Pop().Int==0?501:460;continue;}
case 460:{f.Push(f.Locals[1]);f.Pc=461;continue;}
case 461:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=464;continue;}
case 464:{f.StackOp("dup");f.Pc=465;continue;}
case 465:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","ReduceG","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","ReduceG","Lforge/game/spellability/OptionalCost;"));f.Pc=468;continue;}
case 468:{f.Push(f.Locals[11]);f.Pc=470;continue;}
case 470:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",473);}
case 473:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",478);}
case 478:{f.StackOp("pop");f.Pc=479;continue;}
case 479:{f.Pc=501;continue;}
case 482:{f.Push(f.Locals[1]);f.Pc=483;continue;}
case 483:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=486;continue;}
case 486:{f.StackOp("dup");f.Pc=487;continue;}
case 487:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;"));f.Pc=490;continue;}
case 490:{f.Push(f.Locals[11]);f.Pc=492;continue;}
case 492:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",495);}
case 495:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",500);}
case 500:{f.StackOp("pop");f.Pc=501;continue;}
case 501:{f.Pc=174;continue;}
case 504:{f.Pc=140;continue;}
case 507:{f.Push(f.Locals[2]);f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",511);}
case 511:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",516);}
case 516:{f.Locals[7]=f.Pop();f.Pc=518;continue;}
case 518:{f.Push(f.Locals[7]);f.Pc=520;continue;}
case 520:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",525);}
case 525:{f.Pc=f.Pop().Int==0?1135:528;continue;}
case 528:{f.Push(f.Locals[7]);f.Pc=530;continue;}
case 530:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",535);}
case 535:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=538;continue;}
case 538:{f.Locals[8]=f.Pop();f.Pc=540;continue;}
case 540:{f.Push(f.Locals[8]);f.Pc=542;continue;}
case 542:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",547);}
case 547:{f.Locals[9]=f.Pop();f.Pc=549;continue;}
case 549:{f.Push(f.Locals[9]);f.Pc=551;continue;}
case 551:{f.Push(JValue.R(rt.String("Bargain")));f.Pc=554;continue;}
case 554:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",557);}
case 557:{f.Pc=f.Pop().Int==0?595:560;continue;}
case 560:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=563;continue;}
case 563:{f.StackOp("dup");f.Pc=564;continue;}
case 564:{f.Push(JValue.R(rt.String("Sac<1/Artifact;Enchantment;Card.token/artifact, enchantment or token>")));f.Pc=567;continue;}
case 567:{f.Push(JValue.I(0));f.Pc=568;continue;}
case 568:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",571);}
case 571:{f.Locals[10]=f.Pop();f.Pc=573;continue;}
case 573:{f.Push(f.Locals[1]);f.Pc=574;continue;}
case 574:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=577;continue;}
case 577:{f.StackOp("dup");f.Pc=578;continue;}
case 578:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Bargain","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Bargain","Lforge/game/spellability/OptionalCost;"));f.Pc=581;continue;}
case 581:{f.Push(f.Locals[10]);f.Pc=583;continue;}
case 583:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",586);}
case 586:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",591);}
case 591:{f.StackOp("pop");f.Pc=592;continue;}
case 592:{f.Pc=1132;continue;}
case 595:{f.Push(f.Locals[9]);f.Pc=597;continue;}
case 597:{f.Push(JValue.R(rt.String("Buyback")));f.Pc=600;continue;}
case 600:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",603);}
case 603:{f.Pc=f.Pop().Int==0?645:606;continue;}
case 606:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=609;continue;}
case 609:{f.StackOp("dup");f.Pc=610;continue;}
case 610:{f.Push(f.Locals[9]);f.Pc=612;continue;}
case 612:{f.Push(JValue.I(8));f.Pc=614;continue;}
case 614:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",617);}
case 617:{f.Push(JValue.I(0));f.Pc=618;continue;}
case 618:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",621);}
case 621:{f.Locals[10]=f.Pop();f.Pc=623;continue;}
case 623:{f.Push(f.Locals[1]);f.Pc=624;continue;}
case 624:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=627;continue;}
case 627:{f.StackOp("dup");f.Pc=628;continue;}
case 628:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Buyback","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Buyback","Lforge/game/spellability/OptionalCost;"));f.Pc=631;continue;}
case 631:{f.Push(f.Locals[10]);f.Pc=633;continue;}
case 633:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",636);}
case 636:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",641);}
case 641:{f.StackOp("pop");f.Pc=642;continue;}
case 642:{f.Pc=1132;continue;}
case 645:{f.Push(f.Locals[9]);f.Pc=647;continue;}
case 647:{f.Push(JValue.R(rt.String("Entwine")));f.Pc=650;continue;}
case 650:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",653);}
case 653:{f.Pc=f.Pop().Int==0?701:656;continue;}
case 656:{f.Push(f.Locals[9]);f.Pc=658;continue;}
case 658:{f.Push(JValue.R(rt.String(":")));f.Pc=660;continue;}
case 660:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",663);}
case 663:{f.Locals[10]=f.Pop();f.Pc=665;continue;}
case 665:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=668;continue;}
case 668:{f.StackOp("dup");f.Pc=669;continue;}
case 669:{f.Push(f.Locals[10]);f.Pc=671;continue;}
case 671:{f.Push(JValue.I(1));f.Pc=672;continue;}
case 672:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=673;continue;}
case 673:{f.Push(JValue.I(0));f.Pc=674;continue;}
case 674:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",677);}
case 677:{f.Locals[11]=f.Pop();f.Pc=679;continue;}
case 679:{f.Push(f.Locals[1]);f.Pc=680;continue;}
case 680:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=683;continue;}
case 683:{f.StackOp("dup");f.Pc=684;continue;}
case 684:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Entwine","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Entwine","Lforge/game/spellability/OptionalCost;"));f.Pc=687;continue;}
case 687:{f.Push(f.Locals[11]);f.Pc=689;continue;}
case 689:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",692);}
case 692:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",697);}
case 697:{f.StackOp("pop");f.Pc=698;continue;}
case 698:{f.Pc=1132;continue;}
case 701:{f.Push(f.Locals[9]);f.Pc=703;continue;}
case 703:{f.Push(JValue.R(rt.String("Teamwork")));f.Pc=706;continue;}
case 706:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",709);}
case 709:{f.Pc=f.Pop().Int==0?766:712;continue;}
case 712:{f.Push(f.Locals[9]);f.Pc=714;continue;}
case 714:{f.Push(JValue.R(rt.String(":")));f.Pc=716;continue;}
case 716:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",719);}
case 719:{f.Locals[10]=f.Pop();f.Pc=721;continue;}
case 721:{f.Push(f.Locals[10]);f.Pc=723;continue;}
case 723:{f.Push(JValue.I(1));f.Pc=724;continue;}
case 724:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=725;continue;}
case 725:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2149:725:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",730);}
case 730:{f.Locals[11]=f.Pop();f.Pc=732;continue;}
case 732:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=735;continue;}
case 735:{f.StackOp("dup");f.Pc=736;continue;}
case 736:{f.Push(f.Locals[11]);f.Pc=738;continue;}
case 738:{f.Push(JValue.I(0));f.Pc=739;continue;}
case 739:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",742);}
case 742:{f.Locals[12]=f.Pop();f.Pc=744;continue;}
case 744:{f.Push(f.Locals[1]);f.Pc=745;continue;}
case 745:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=748;continue;}
case 748:{f.StackOp("dup");f.Pc=749;continue;}
case 749:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Teamwork","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Teamwork","Lforge/game/spellability/OptionalCost;"));f.Pc=752;continue;}
case 752:{f.Push(f.Locals[12]);f.Pc=754;continue;}
case 754:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",757);}
case 757:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",762);}
case 762:{f.StackOp("pop");f.Pc=763;continue;}
case 763:{f.Pc=1132;continue;}
case 766:{f.Push(f.Locals[9]);f.Pc=768;continue;}
case 768:{f.Push(JValue.R(rt.String("Gift")));f.Pc=771;continue;}
case 771:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",774);}
case 774:{f.Pc=f.Pop().Int==0?812:777;continue;}
case 777:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=780;continue;}
case 780:{f.StackOp("dup");f.Pc=781;continue;}
case 781:{f.Push(JValue.R(rt.String("PromiseGift")));f.Pc=784;continue;}
case 784:{f.Push(JValue.I(0));f.Pc=785;continue;}
case 785:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",788);}
case 788:{f.Locals[10]=f.Pop();f.Pc=790;continue;}
case 790:{f.Push(f.Locals[1]);f.Pc=791;continue;}
case 791:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=794;continue;}
case 794:{f.StackOp("dup");f.Pc=795;continue;}
case 795:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","PromiseGift","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","PromiseGift","Lforge/game/spellability/OptionalCost;"));f.Pc=798;continue;}
case 798:{f.Push(f.Locals[10]);f.Pc=800;continue;}
case 800:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",803);}
case 803:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",808);}
case 808:{f.StackOp("pop");f.Pc=809;continue;}
case 809:{f.Pc=1132;continue;}
case 812:{f.Push(f.Locals[9]);f.Pc=814;continue;}
case 814:{f.Push(JValue.R(rt.String("Kicker")));f.Pc=817;continue;}
case 817:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",820);}
case 820:{f.Pc=f.Pop().Int==0?906:823;continue;}
case 823:{f.Push(f.Locals[9]);f.Pc=825;continue;}
case 825:{f.Push(JValue.I(6));f.Pc=827;continue;}
case 827:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",830);}
case 830:{f.Push(JValue.I(58));f.Pc=832;continue;}
case 832:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",835);}
case 835:{f.Locals[10]=f.Pop();f.Pc=837;continue;}
case 837:{f.Push(JValue.I(0));f.Pc=838;continue;}
case 838:{f.Locals[11]=f.Pop();f.Pc=840;continue;}
case 840:{f.Push(f.Locals[11]);f.Pc=842;continue;}
case 842:{f.Push(f.Locals[10]);f.Pc=844;continue;}
case 844:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=845;continue;}
case 845:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?903:848;continue;}
case 848:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=851;continue;}
case 851:{f.StackOp("dup");f.Pc=852;continue;}
case 852:{f.Push(f.Locals[10]);f.Pc=854;continue;}
case 854:{f.Push(f.Locals[11]);f.Pc=856;continue;}
case 856:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=857;continue;}
case 857:{f.Push(JValue.I(0));f.Pc=858;continue;}
case 858:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",861);}
case 861:{f.Locals[12]=f.Pop();f.Pc=863;continue;}
case 863:{f.Push(f.Locals[11]);f.Pc=865;continue;}
case 865:{f.Pc=f.Pop().Int!=0?874:868;continue;}
case 868:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;"));f.Pc=871;continue;}
case 871:{f.Pc=877;continue;}
case 874:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;"));f.Pc=877;continue;}
case 877:{f.Locals[13]=f.Pop();f.Pc=879;continue;}
case 879:{f.Push(f.Locals[1]);f.Pc=880;continue;}
case 880:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=883;continue;}
case 883:{f.StackOp("dup");f.Pc=884;continue;}
case 884:{f.Push(f.Locals[13]);f.Pc=886;continue;}
case 886:{f.Push(f.Locals[12]);f.Pc=888;continue;}
case 888:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",891);}
case 891:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",896);}
case 896:{f.StackOp("pop");f.Pc=897;continue;}
case 897:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=900;continue;}
case 900:{f.Pc=840;continue;}
case 903:{f.Pc=1132;continue;}
case 906:{f.Push(f.Locals[9]);f.Pc=908;continue;}
case 908:{f.Push(JValue.R(rt.String("Retrace")));f.Pc=911;continue;}
case 911:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",914);}
case 914:{f.Pc=f.Pop().Int==0?962:917;continue;}
case 917:{f.Push(f.Locals[2]);f.Pc=918;continue;}
case 918:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=921;continue;}
case 921:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",924);}
case 924:{f.Pc=f.Pop().Int==0?1132:927;continue;}
case 927:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=930;continue;}
case 930:{f.StackOp("dup");f.Pc=931;continue;}
case 931:{f.Push(JValue.R(rt.String("Discard<1/Land>")));f.Pc=934;continue;}
case 934:{f.Push(JValue.I(0));f.Pc=935;continue;}
case 935:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",938);}
case 938:{f.Locals[10]=f.Pop();f.Pc=940;continue;}
case 940:{f.Push(f.Locals[1]);f.Pc=941;continue;}
case 941:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=944;continue;}
case 944:{f.StackOp("dup");f.Pc=945;continue;}
case 945:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Retrace","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Retrace","Lforge/game/spellability/OptionalCost;"));f.Pc=948;continue;}
case 948:{f.Push(f.Locals[10]);f.Pc=950;continue;}
case 950:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",953);}
case 953:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",958);}
case 958:{f.StackOp("pop");f.Pc=959;continue;}
case 959:{f.Pc=1132;continue;}
case 962:{f.Push(f.Locals[9]);f.Pc=964;continue;}
case 964:{f.Push(JValue.R(rt.String("Jump-start")));f.Pc=967;continue;}
case 967:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",970);}
case 970:{f.Pc=f.Pop().Int==0?1018:973;continue;}
case 973:{f.Push(f.Locals[2]);f.Pc=974;continue;}
case 974:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=977;continue;}
case 977:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",980);}
case 980:{f.Pc=f.Pop().Int==0?1132:983;continue;}
case 983:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=986;continue;}
case 986:{f.StackOp("dup");f.Pc=987;continue;}
case 987:{f.Push(JValue.R(rt.String("Discard<1/Card>")));f.Pc=990;continue;}
case 990:{f.Push(JValue.I(0));f.Pc=991;continue;}
case 991:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",994);}
case 994:{f.Locals[10]=f.Pop();f.Pc=996;continue;}
case 996:{f.Push(f.Locals[1]);f.Pc=997;continue;}
case 997:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=1000;continue;}
case 1000:{f.StackOp("dup");f.Pc=1001;continue;}
case 1001:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Jumpstart","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Jumpstart","Lforge/game/spellability/OptionalCost;"));f.Pc=1004;continue;}
case 1004:{f.Push(f.Locals[10]);f.Pc=1006;continue;}
case 1006:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",1009);}
case 1009:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1014);}
case 1014:{f.StackOp("pop");f.Pc=1015;continue;}
case 1015:{f.Pc=1132;continue;}
case 1018:{f.Push(f.Locals[9]);f.Pc=1020;continue;}
case 1020:{f.Push(JValue.R(rt.String("MayFlashCost")));f.Pc=1023;continue;}
case 1023:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1026);}
case 1026:{f.Pc=f.Pop().Int==0?1074:1029;continue;}
case 1029:{f.Push(f.Locals[9]);f.Pc=1031;continue;}
case 1031:{f.Push(JValue.R(rt.String(":")));f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1036);}
case 1036:{f.Locals[10]=f.Pop();f.Pc=1038;continue;}
case 1038:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=1041;continue;}
case 1041:{f.StackOp("dup");f.Pc=1042;continue;}
case 1042:{f.Push(f.Locals[10]);f.Pc=1044;continue;}
case 1044:{f.Push(JValue.I(1));f.Pc=1045;continue;}
case 1045:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1046;continue;}
case 1046:{f.Push(JValue.I(0));f.Pc=1047;continue;}
case 1047:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",1050);}
case 1050:{f.Locals[11]=f.Pop();f.Pc=1052;continue;}
case 1052:{f.Push(f.Locals[1]);f.Pc=1053;continue;}
case 1053:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=1056;continue;}
case 1056:{f.StackOp("dup");f.Pc=1057;continue;}
case 1057:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Flash","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Flash","Lforge/game/spellability/OptionalCost;"));f.Pc=1060;continue;}
case 1060:{f.Push(f.Locals[11]);f.Pc=1062;continue;}
case 1062:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",1065);}
case 1065:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1070);}
case 1070:{f.StackOp("pop");f.Pc=1071;continue;}
case 1071:{f.Pc=1132;continue;}
case 1074:{f.Push(f.Locals[9]);f.Pc=1076;continue;}
case 1076:{f.Push(JValue.R(rt.String("Offering")));f.Pc=1079;continue;}
case 1079:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1082);}
case 1082:{f.Pc=f.Pop().Int==0?1132:1085;continue;}
case 1085:{f.Push(f.Locals[9]);f.Pc=1087;continue;}
case 1087:{f.Push(JValue.R(rt.String(":")));f.Pc=1089;continue;}
case 1089:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1092);}
case 1092:{f.Push(JValue.I(1));f.Pc=1093;continue;}
case 1093:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1094;continue;}
case 1094:{f.Locals[10]=f.Pop();f.Pc=1096;continue;}
case 1096:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=1099;continue;}
case 1099:{f.StackOp("dup");f.Pc=1100;continue;}
case 1100:{f.Push(f.Locals[10]);f.Pc=1102;continue;}
case 1102:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2149:1102:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1107);}
case 1107:{f.Push(JValue.I(0));f.Pc=1108;continue;}
case 1108:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",1111);}
case 1111:{f.Locals[11]=f.Pop();f.Pc=1113;continue;}
case 1113:{f.Push(f.Locals[1]);f.Pc=1114;continue;}
case 1114:{if(!rt.EnsureInitialized(f,"forge/game/spellability/OptionalCostValue"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/OptionalCostValue")));f.Pc=1117;continue;}
case 1117:{f.StackOp("dup");f.Pc=1118;continue;}
case 1118:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Offering","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Offering","Lforge/game/spellability/OptionalCost;"));f.Pc=1121;continue;}
case 1121:{f.Push(f.Locals[11]);f.Pc=1123;continue;}
case 1123:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","<init>","(Lforge/game/spellability/OptionalCost;Lforge/game/cost/Cost;)V","invokespecial",1126);}
case 1126:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1131);}
case 1131:{f.StackOp("pop");f.Pc=1132;continue;}
case 1132:{f.Pc=518;continue;}
case 1135:{f.Push(f.Locals[4]);f.Pc=1137;continue;}
case 1137:{f.Pc=f.Pop().Int==0?1162:1140;continue;}
case 1140:{f.Push(f.Locals[3]);f.Pc=1141;continue;}
case 1141:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1144);}
case 1144:{f.Push(JValue.I(0));f.Pc=1145;continue;}
case 1145:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(Z)V","invokevirtual",1148);}
case 1148:{f.Push(f.Locals[3]);f.Pc=1149;continue;}
case 1149:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",1152);}
case 1152:{return rt.Call(f,"forge/trackable/Tracker","clearDelayed","()V","invokevirtual",1155);}
case 1155:{f.Push(f.Locals[3]);f.Pc=1156;continue;}
case 1156:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",1159);}
case 1159:{return rt.Call(f,"forge/trackable/Tracker","unfreeze","()V","invokevirtual",1162);}
case 1162:{f.Push(f.Locals[1]);f.Pc=1163;continue;}
case 1163:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2150(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?15:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("ReduceCost")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?45:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("ReduceCost")));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("ReduceCost")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("RaiseCost")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?70:55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("RaiseCost")));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("RaiseCost")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",66);}
case 66:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",76);}
case 76:{f.Locals[3]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",83);}
case 83:{f.Pc=f.Pop().Int==0?199:86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",92);}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/OptionalCostValue"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{f.Locals[4]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","getType","()Lforge/game/spellability/OptionalCost;","invokevirtual",102);}
case 102:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Offering","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Offering","Lforge/game/spellability/OptionalCost;"));f.Pc=105;continue;}
case 105:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?121:108;continue;}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",112);}
case 112:{f.Push(f.Locals[4]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","getCost","()Lforge/game/cost/Cost;","invokevirtual",117);}
case 117:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[4]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","getType","()Lforge/game/spellability/OptionalCost;","invokevirtual",127);}
case 127:{return rt.Call(f,"forge/game/spellability/SpellAbility","addOptionalCost","(Lforge/game/spellability/OptionalCost;)V","invokevirtual",130);}
case 130:{if(!rt.StaticReady(f,"forge/game/GameActionUtil$1","$SwitchMap$forge$game$spellability$OptionalCost","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameActionUtil$1","$SwitchMap$forge$game$spellability$OptionalCost","[I"));f.Pc=133;continue;}
case 133:{f.Push(f.Locals[4]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/spellability/OptionalCostValue","getType","()Lforge/game/spellability/OptionalCost;","invokevirtual",138);}
case 138:{return rt.Call(f,"forge/game/spellability/OptionalCost","ordinal","()I","invokevirtual",141);}
case 141:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=142;continue;}
case 142:{switch(f.Pop().Int){case 1:f.Pc=172;break;case 2:f.Pc=172;break;case 3:f.Pc=185;break;case 4:f.Pc=185;break;default:f.Pc=196;break;}continue;}
case 172:{f.Push(f.Locals[2]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",176);}
case 176:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",182);}
case 182:{f.Pc=196;continue;}
case 185:{f.Push(f.Locals[2]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",189);}
case 189:{f.Push(JValue.I(1));f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setInstantSpeed","(Z)V","invokevirtual",193);}
case 193:{f.Pc=196;continue;}
case 196:{f.Pc=77;continue;}
case 199:{f.Push(f.Locals[2]);f.Pc=200;continue;}
case 200:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2151(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/game/spellability/SpellAbility;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=8;continue;}
case 8:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?202:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",28);}
case 28:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?199:43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[4]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",61);}
case 61:{f.Locals[5]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("AlternateAdditionalCost")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int==0?196:74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",80);}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String(":")));f.Pc=84;continue;}
case 84:{f.Push(JValue.I(2));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",88);}
case 88:{f.Push(JValue.I(1));f.Pc=89;continue;}
case 89:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String(":")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",95);}
case 95:{f.Locals[6]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[6]);f.Pc=99;continue;}
case 99:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=100;continue;}
case 100:{f.Locals[7]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{f.Locals[8]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[8]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[7]);f.Pc=109;continue;}
case 109:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?196:112;continue;}
case 112:{f.Push(f.Locals[6]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[8]);f.Pc=116;continue;}
case 116:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=117;continue;}
case 117:{f.Locals[9]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;","invokevirtual",123);}
case 123:{f.Locals[10]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[10]);f.Pc=127;continue;}
case 127:{f.Push(JValue.I(0));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/spellability/SpellAbility","setBasicSpell","(Z)V","invokevirtual",131);}
case 131:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=134;continue;}
case 134:{f.StackOp("dup");f.Pc=135;continue;}
case 135:{f.Push(f.Locals[9]);f.Pc=137;continue;}
case 137:{f.Push(JValue.I(0));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",141);}
case 141:{f.Locals[11]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[10]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",149);}
case 149:{f.Push(f.Locals[11]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",154);}
case 154:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2151:154:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",159);}
case 159:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",162);}
case 162:{f.Push(f.Locals[10]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",167);}
case 167:{f.Push(f.Locals[11]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",172);}
case 172:{f.StackOp("pop");f.Pc=173;continue;}
case 173:{f.Push(f.Locals[10]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/spellability/SpellAbility","canPlay","()Z","invokevirtual",178);}
case 178:{f.Pc=f.Pop().Int==0?190:181;continue;}
case 181:{f.Push(f.Locals[1]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[10]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",189);}
case 189:{f.StackOp("pop");f.Pc=190;continue;}
case 190:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=193;continue;}
case 193:{f.Pc=105;continue;}
case 196:{f.Pc=34;continue;}
case 199:{f.Pc=312;continue;}
case 202:{f.Push(f.Locals[0]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",206);}
case 206:{f.Pc=f.Pop().Int==0?312:209;continue;}
case 209:{f.Push(f.Locals[0]);f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String("AlternateCost")));f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",216);}
case 216:{f.Pc=f.Pop().Int==0?312:219;continue;}
case 219:{f.Push(f.Locals[1]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",225);}
case 225:{f.Push(f.Locals[0]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;","invokevirtual",229);}
case 229:{f.Locals[2]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[2]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String("AlternateCost")));f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/spellability/SpellAbility","removeParam","(Ljava/lang/String;)V","invokevirtual",237);}
case 237:{f.Push(f.Locals[2]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/spellability/SpellAbility","rebuiltDescription","()V","invokevirtual",241);}
case 241:{f.Push(f.Locals[2]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/spellability/SpellAbility","canPlay","()Z","invokevirtual",245);}
case 245:{f.Pc=f.Pop().Int==0?256:248;continue;}
case 248:{f.Push(f.Locals[1]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[2]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",255);}
case 255:{f.StackOp("pop");f.Pc=256;continue;}
case 256:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=259;continue;}
case 259:{f.StackOp("dup");f.Pc=260;continue;}
case 260:{f.Push(f.Locals[0]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String("AlternateCost")));f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",267);}
case 267:{f.Push(f.Locals[0]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",271);}
case 271:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",274);}
case 274:{f.Locals[3]=f.Pop();f.Pc=275;continue;}
case 275:{f.Push(f.Locals[0]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[3]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",280);}
case 280:{f.Locals[4]=f.Pop();f.Pc=282;continue;}
case 282:{f.Push(f.Locals[4]);f.Pc=284;continue;}
case 284:{f.Push(JValue.R(rt.String("AlternateCost")));f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/spellability/SpellAbility","removeParam","(Ljava/lang/String;)V","invokevirtual",290);}
case 290:{f.Push(f.Locals[4]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/spellability/SpellAbility","rebuiltDescription","()V","invokevirtual",295);}
case 295:{f.Push(f.Locals[4]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/spellability/SpellAbility","canPlay","()Z","invokevirtual",300);}
case 300:{f.Pc=f.Pop().Int==0?312:303;continue;}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[4]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",311);}
case 311:{f.StackOp("pop");f.Pc=312;continue;}
case 312:{f.Push(f.Locals[1]);f.Pc=313;continue;}
case 313:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2152(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopied","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?16:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",27);}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",32);}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",39);}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",45);}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(Z)V","invokevirtual",49);}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{f.Locals[6]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",56);}
case 56:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",61);}
case 61:{f.Locals[7]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[7]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",70);}
case 70:{f.Pc=f.Pop().Int==0?793:73;continue;}
case 73:{f.Push(f.Locals[7]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",80);}
case 80:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=83;continue;}
case 83:{f.Locals[8]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[8]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",92);}
case 92:{f.Locals[9]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[9]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("Casualty")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int==0?259:105;continue;}
case 105:{f.Push(f.Locals[9]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String(":")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",112);}
case 112:{f.Push(JValue.I(1));f.Pc=113;continue;}
case 113:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=114;continue;}
case 114:{f.Locals[10]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/Card","wasCast","()Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?173:123;continue;}
case 123:{f.Push(f.Locals[10]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("X")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?173:134;continue;}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",139);}
case 139:{f.Locals[11]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[11]);f.Pc=143;continue;}
case 143:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2152:143:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",148);}
case 148:{return rt.Call(f,"forge/util/Aggregates","max","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/lang/Integer;","invokestatic",151);}
case 151:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",154);}
case 154:{f.Locals[12]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[5]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("Choose X for Casualty")));f.Pc=162;continue;}
case 162:{f.Push(JValue.I(0));f.Pc=163;continue;}
case 163:{f.Push(f.Locals[12]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;II)I","invokevirtual",168);}
case 168:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",171);}
case 171:{f.Locals[10]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[10]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[10]);f.Pc=177;continue;}
case 177:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2152:177:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",182);}
case 182:{f.Locals[11]=f.Pop();f.Pc=184;continue;}
case 184:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=187;continue;}
case 187:{f.StackOp("dup");f.Pc=188;continue;}
case 188:{f.Push(f.Locals[11]);f.Pc=190;continue;}
case 190:{f.Push(JValue.I(0));f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",194);}
case 194:{f.Locals[12]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[12]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",201);}
case 201:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2152:201:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",206);}
case 206:{f.Locals[13]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[5]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[0]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[12]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[8]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[13]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/player/PlayerController","addKeywordCost","(Lforge/game/spellability/SpellAbility;Lforge/game/cost/Cost;Lforge/game/keyword/KeywordInterface;Ljava/lang/String;)Z","invokevirtual",220);}
case 220:{f.Pc=f.Pop().Int==0?256:223;continue;}
case 223:{f.Push(f.Locals[1]);f.Pc=224;continue;}
case 224:{f.Pc=f.Pop().Reference!=null?232:227;continue;}
case 227:{f.Push(f.Locals[0]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;","invokevirtual",231);}
case 231:{f.Locals[1]=f.Pop();f.Pc=232;continue;}
case 232:{f.Push(f.Locals[1]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",236);}
case 236:{f.Push(f.Locals[12]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",241);}
case 241:{f.StackOp("pop");f.Pc=242;continue;}
case 242:{f.Push(JValue.I(1));f.Pc=243;continue;}
case 243:{f.Locals[6]=f.Pop();f.Pc=245;continue;}
case 245:{f.Push(f.Locals[1]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[8]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[10]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",253);}
case 253:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOptionalKeywordAmount","(Lforge/game/keyword/KeywordInterface;I)V","invokevirtual",256);}
case 256:{f.Pc=790;continue;}
case 259:{f.Push(f.Locals[9]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String("Conspire")));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",267);}
case 267:{f.Pc=f.Pop().Int==0?352:270;continue;}
case 270:{f.Push(f.Locals[2]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",274);}
case 274:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2152:274:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",279);}
case 279:{f.Locals[10]=f.Pop();f.Pc=281;continue;}
case 281:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=284;continue;}
case 284:{f.StackOp("dup");f.Pc=285;continue;}
case 285:{f.Push(f.Locals[10]);f.Pc=287;continue;}
case 287:{f.Push(JValue.I(0));f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",291);}
case 291:{f.Locals[11]=f.Pop();f.Pc=293;continue;}
case 293:{f.Push(f.Locals[11]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",298);}
case 298:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2152:298:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",303);}
case 303:{f.Locals[12]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[5]);f.Pc=307;continue;}
case 307:{f.Push(f.Locals[0]);f.Pc=308;continue;}
case 308:{f.Push(f.Locals[11]);f.Pc=310;continue;}
case 310:{f.Push(f.Locals[8]);f.Pc=312;continue;}
case 312:{f.Push(f.Locals[12]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/player/PlayerController","addKeywordCost","(Lforge/game/spellability/SpellAbility;Lforge/game/cost/Cost;Lforge/game/keyword/KeywordInterface;Ljava/lang/String;)Z","invokevirtual",317);}
case 317:{f.Pc=f.Pop().Int==0?349:320;continue;}
case 320:{f.Push(f.Locals[1]);f.Pc=321;continue;}
case 321:{f.Pc=f.Pop().Reference!=null?329:324;continue;}
case 324:{f.Push(f.Locals[0]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;","invokevirtual",328);}
case 328:{f.Locals[1]=f.Pop();f.Pc=329;continue;}
case 329:{f.Push(f.Locals[1]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",333);}
case 333:{f.Push(f.Locals[11]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",338);}
case 338:{f.StackOp("pop");f.Pc=339;continue;}
case 339:{f.Push(f.Locals[1]);f.Pc=340;continue;}
case 340:{f.Push(f.Locals[8]);f.Pc=342;continue;}
case 342:{f.Push(JValue.I(1));f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOptionalKeywordAmount","(Lforge/game/keyword/KeywordInterface;I)V","invokevirtual",346);}
case 346:{f.Push(JValue.I(1));f.Pc=347;continue;}
case 347:{f.Locals[6]=f.Pop();f.Pc=349;continue;}
case 349:{f.Pc=790;continue;}
case 352:{f.Push(f.Locals[9]);f.Pc=354;continue;}
case 354:{f.Push(JValue.R(rt.String("Multikicker")));f.Pc=357;continue;}
case 357:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",360);}
case 360:{f.Pc=f.Pop().Int==0?468:363;continue;}
case 363:{f.Push(f.Locals[9]);f.Pc=365;continue;}
case 365:{f.Push(JValue.R(rt.String(":")));f.Pc=367;continue;}
case 367:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",370);}
case 370:{f.Push(JValue.I(1));f.Pc=371;continue;}
case 371:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=372;continue;}
case 372:{f.Locals[10]=f.Pop();f.Pc=374;continue;}
case 374:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=377;continue;}
case 377:{f.StackOp("dup");f.Pc=378;continue;}
case 378:{f.Push(f.Locals[10]);f.Pc=380;continue;}
case 380:{f.Push(JValue.I(0));f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",384);}
case 384:{f.Locals[11]=f.Pop();f.Pc=386;continue;}
case 386:{f.Push(f.Locals[11]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",391);}
case 391:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2152:391:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",396);}
case 396:{f.Locals[12]=f.Pop();f.Pc=398;continue;}
case 398:{f.Push(f.Locals[5]);f.Pc=400;continue;}
case 400:{f.Push(f.Locals[0]);f.Pc=401;continue;}
case 401:{f.Push(f.Locals[11]);f.Pc=403;continue;}
case 403:{f.Push(f.Locals[8]);f.Pc=405;continue;}
case 405:{f.Push(f.Locals[12]);f.Pc=407;continue;}
case 407:{f.Push(JValue.I(2147483647));f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumberForKeywordCost","(Lforge/game/spellability/SpellAbility;Lforge/game/cost/Cost;Lforge/game/keyword/KeywordInterface;Ljava/lang/String;I)I","invokevirtual",413);}
case 413:{f.Locals[13]=f.Pop();f.Pc=415;continue;}
case 415:{f.Push(JValue.I(0));f.Pc=416;continue;}
case 416:{f.Locals[14]=f.Pop();f.Pc=418;continue;}
case 418:{f.Push(f.Locals[14]);f.Pc=420;continue;}
case 420:{f.Push(f.Locals[13]);f.Pc=422;continue;}
case 422:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?453:425;continue;}
case 425:{f.Push(f.Locals[1]);f.Pc=426;continue;}
case 426:{f.Pc=f.Pop().Reference!=null?434:429;continue;}
case 429:{f.Push(f.Locals[0]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;","invokevirtual",433);}
case 433:{f.Locals[1]=f.Pop();f.Pc=434;continue;}
case 434:{f.Push(f.Locals[1]);f.Pc=435;continue;}
case 435:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",438);}
case 438:{f.Push(f.Locals[11]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",443);}
case 443:{f.StackOp("pop");f.Pc=444;continue;}
case 444:{f.Push(JValue.I(1));f.Pc=445;continue;}
case 445:{f.Locals[6]=f.Pop();f.Pc=447;continue;}
case 447:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=450;continue;}
case 450:{f.Pc=418;continue;}
case 453:{f.Push(f.Locals[1]);f.Pc=454;continue;}
case 454:{f.Pc=f.Pop().Reference==null?465:457;continue;}
case 457:{f.Push(f.Locals[1]);f.Pc=458;continue;}
case 458:{f.Push(f.Locals[8]);f.Pc=460;continue;}
case 460:{f.Push(f.Locals[13]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOptionalKeywordAmount","(Lforge/game/keyword/KeywordInterface;I)V","invokevirtual",465);}
case 465:{f.Pc=790;continue;}
case 468:{f.Push(f.Locals[9]);f.Pc=470;continue;}
case 470:{f.Push(JValue.R(rt.String("Offspring")));f.Pc=473;continue;}
case 473:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",476);}
case 476:{f.Pc=f.Pop().Int==0?561:479;continue;}
case 479:{f.Push(f.Locals[9]);f.Pc=481;continue;}
case 481:{f.Push(JValue.R(rt.String(":")));f.Pc=483;continue;}
case 483:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",486);}
case 486:{f.Locals[10]=f.Pop();f.Pc=488;continue;}
case 488:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=491;continue;}
case 491:{f.StackOp("dup");f.Pc=492;continue;}
case 492:{f.Push(f.Locals[10]);f.Pc=494;continue;}
case 494:{f.Push(JValue.I(1));f.Pc=495;continue;}
case 495:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=496;continue;}
case 496:{f.Push(JValue.I(0));f.Pc=497;continue;}
case 497:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",500);}
case 500:{f.Locals[11]=f.Pop();f.Pc=502;continue;}
case 502:{f.Push(f.Locals[11]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",507);}
case 507:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2152:507:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",512);}
case 512:{f.Locals[12]=f.Pop();f.Pc=514;continue;}
case 514:{f.Push(f.Locals[5]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[0]);f.Pc=517;continue;}
case 517:{f.Push(f.Locals[11]);f.Pc=519;continue;}
case 519:{f.Push(f.Locals[8]);f.Pc=521;continue;}
case 521:{f.Push(f.Locals[12]);f.Pc=523;continue;}
case 523:{return rt.Call(f,"forge/game/player/PlayerController","addKeywordCost","(Lforge/game/spellability/SpellAbility;Lforge/game/cost/Cost;Lforge/game/keyword/KeywordInterface;Ljava/lang/String;)Z","invokevirtual",526);}
case 526:{f.Pc=f.Pop().Int==0?558:529;continue;}
case 529:{f.Push(f.Locals[1]);f.Pc=530;continue;}
case 530:{f.Pc=f.Pop().Reference!=null?538:533;continue;}
case 533:{f.Push(f.Locals[0]);f.Pc=534;continue;}
case 534:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;","invokevirtual",537);}
case 537:{f.Locals[1]=f.Pop();f.Pc=538;continue;}
case 538:{f.Push(f.Locals[1]);f.Pc=539;continue;}
case 539:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",542);}
case 542:{f.Push(f.Locals[11]);f.Pc=544;continue;}
case 544:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",547);}
case 547:{f.StackOp("pop");f.Pc=548;continue;}
case 548:{f.Push(JValue.I(1));f.Pc=549;continue;}
case 549:{f.Locals[6]=f.Pop();f.Pc=551;continue;}
case 551:{f.Push(f.Locals[1]);f.Pc=552;continue;}
case 552:{f.Push(f.Locals[8]);f.Pc=554;continue;}
case 554:{f.Push(JValue.I(1));f.Pc=555;continue;}
case 555:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOptionalKeywordAmount","(Lforge/game/keyword/KeywordInterface;I)V","invokevirtual",558);}
case 558:{f.Pc=790;continue;}
case 561:{f.Push(f.Locals[9]);f.Pc=563;continue;}
case 563:{f.Push(JValue.R(rt.String("Replicate")));f.Pc=566;continue;}
case 566:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",569);}
case 569:{f.Pc=f.Pop().Int==0?677:572;continue;}
case 572:{f.Push(f.Locals[9]);f.Pc=574;continue;}
case 574:{f.Push(JValue.R(rt.String(":")));f.Pc=576;continue;}
case 576:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",579);}
case 579:{f.Push(JValue.I(1));f.Pc=580;continue;}
case 580:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=581;continue;}
case 581:{f.Locals[10]=f.Pop();f.Pc=583;continue;}
case 583:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=586;continue;}
case 586:{f.StackOp("dup");f.Pc=587;continue;}
case 587:{f.Push(f.Locals[10]);f.Pc=589;continue;}
case 589:{f.Push(JValue.I(0));f.Pc=590;continue;}
case 590:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",593);}
case 593:{f.Locals[11]=f.Pop();f.Pc=595;continue;}
case 595:{f.Push(f.Locals[11]);f.Pc=597;continue;}
case 597:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",600);}
case 600:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2152:600:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",605);}
case 605:{f.Locals[12]=f.Pop();f.Pc=607;continue;}
case 607:{f.Push(f.Locals[5]);f.Pc=609;continue;}
case 609:{f.Push(f.Locals[0]);f.Pc=610;continue;}
case 610:{f.Push(f.Locals[11]);f.Pc=612;continue;}
case 612:{f.Push(f.Locals[8]);f.Pc=614;continue;}
case 614:{f.Push(f.Locals[12]);f.Pc=616;continue;}
case 616:{f.Push(JValue.I(2147483647));f.Pc=619;continue;}
case 619:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumberForKeywordCost","(Lforge/game/spellability/SpellAbility;Lforge/game/cost/Cost;Lforge/game/keyword/KeywordInterface;Ljava/lang/String;I)I","invokevirtual",622);}
case 622:{f.Locals[13]=f.Pop();f.Pc=624;continue;}
case 624:{f.Push(JValue.I(0));f.Pc=625;continue;}
case 625:{f.Locals[14]=f.Pop();f.Pc=627;continue;}
case 627:{f.Push(f.Locals[14]);f.Pc=629;continue;}
case 629:{f.Push(f.Locals[13]);f.Pc=631;continue;}
case 631:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?662:634;continue;}
case 634:{f.Push(f.Locals[1]);f.Pc=635;continue;}
case 635:{f.Pc=f.Pop().Reference!=null?643:638;continue;}
case 638:{f.Push(f.Locals[0]);f.Pc=639;continue;}
case 639:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;","invokevirtual",642);}
case 642:{f.Locals[1]=f.Pop();f.Pc=643;continue;}
case 643:{f.Push(f.Locals[1]);f.Pc=644;continue;}
case 644:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",647);}
case 647:{f.Push(f.Locals[11]);f.Pc=649;continue;}
case 649:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",652);}
case 652:{f.StackOp("pop");f.Pc=653;continue;}
case 653:{f.Push(JValue.I(1));f.Pc=654;continue;}
case 654:{f.Locals[6]=f.Pop();f.Pc=656;continue;}
case 656:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=659;continue;}
case 659:{f.Pc=627;continue;}
case 662:{f.Push(f.Locals[1]);f.Pc=663;continue;}
case 663:{f.Pc=f.Pop().Reference==null?674:666;continue;}
case 666:{f.Push(f.Locals[1]);f.Pc=667;continue;}
case 667:{f.Push(f.Locals[8]);f.Pc=669;continue;}
case 669:{f.Push(f.Locals[13]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOptionalKeywordAmount","(Lforge/game/keyword/KeywordInterface;I)V","invokevirtual",674);}
case 674:{f.Pc=790;continue;}
case 677:{f.Push(f.Locals[9]);f.Pc=679;continue;}
case 679:{f.Push(JValue.R(rt.String("Squad")));f.Pc=682;continue;}
case 682:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",685);}
case 685:{f.Pc=f.Pop().Int==0?790:688;continue;}
case 688:{f.Push(f.Locals[9]);f.Pc=690;continue;}
case 690:{f.Push(JValue.R(rt.String(":")));f.Pc=692;continue;}
case 692:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",695);}
case 695:{f.Push(JValue.I(1));f.Pc=696;continue;}
case 696:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=697;continue;}
case 697:{f.Locals[10]=f.Pop();f.Pc=699;continue;}
case 699:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=702;continue;}
case 702:{f.StackOp("dup");f.Pc=703;continue;}
case 703:{f.Push(f.Locals[10]);f.Pc=705;continue;}
case 705:{f.Push(JValue.I(0));f.Pc=706;continue;}
case 706:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",709);}
case 709:{f.Locals[11]=f.Pop();f.Pc=711;continue;}
case 711:{f.Push(f.Locals[11]);f.Pc=713;continue;}
case 713:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",716);}
case 716:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2152:716:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",721);}
case 721:{f.Locals[12]=f.Pop();f.Pc=723;continue;}
case 723:{f.Push(f.Locals[5]);f.Pc=725;continue;}
case 725:{f.Push(f.Locals[0]);f.Pc=726;continue;}
case 726:{f.Push(f.Locals[11]);f.Pc=728;continue;}
case 728:{f.Push(f.Locals[8]);f.Pc=730;continue;}
case 730:{f.Push(f.Locals[12]);f.Pc=732;continue;}
case 732:{f.Push(JValue.I(2147483647));f.Pc=735;continue;}
case 735:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumberForKeywordCost","(Lforge/game/spellability/SpellAbility;Lforge/game/cost/Cost;Lforge/game/keyword/KeywordInterface;Ljava/lang/String;I)I","invokevirtual",738);}
case 738:{f.Locals[13]=f.Pop();f.Pc=740;continue;}
case 740:{f.Push(JValue.I(0));f.Pc=741;continue;}
case 741:{f.Locals[14]=f.Pop();f.Pc=743;continue;}
case 743:{f.Push(f.Locals[14]);f.Pc=745;continue;}
case 745:{f.Push(f.Locals[13]);f.Pc=747;continue;}
case 747:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?778:750;continue;}
case 750:{f.Push(f.Locals[1]);f.Pc=751;continue;}
case 751:{f.Pc=f.Pop().Reference!=null?759:754;continue;}
case 754:{f.Push(f.Locals[0]);f.Pc=755;continue;}
case 755:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;","invokevirtual",758);}
case 758:{f.Locals[1]=f.Pop();f.Pc=759;continue;}
case 759:{f.Push(f.Locals[1]);f.Pc=760;continue;}
case 760:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",763);}
case 763:{f.Push(f.Locals[11]);f.Pc=765;continue;}
case 765:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",768);}
case 768:{f.StackOp("pop");f.Pc=769;continue;}
case 769:{f.Push(JValue.I(1));f.Pc=770;continue;}
case 770:{f.Locals[6]=f.Pop();f.Pc=772;continue;}
case 772:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=775;continue;}
case 775:{f.Pc=743;continue;}
case 778:{f.Push(f.Locals[1]);f.Pc=779;continue;}
case 779:{f.Pc=f.Pop().Reference==null?790:782;continue;}
case 782:{f.Push(f.Locals[1]);f.Pc=783;continue;}
case 783:{f.Push(f.Locals[8]);f.Pc=785;continue;}
case 785:{f.Push(f.Locals[13]);f.Pc=787;continue;}
case 787:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOptionalKeywordAmount","(Lforge/game/keyword/KeywordInterface;I)V","invokevirtual",790);}
case 790:{f.Pc=63;continue;}
case 793:{f.Push(f.Locals[0]);f.Pc=794;continue;}
case 794:{return rt.Call(f,"forge/game/spellability/SpellAbility","isHarmonize","()Z","invokevirtual",797);}
case 797:{f.Pc=f.Pop().Int==0?917:800;continue;}
case 800:{f.Push(f.Locals[4]);f.Pc=802;continue;}
case 802:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",805);}
case 805:{f.Locals[7]=f.Pop();f.Pc=807;continue;}
case 807:{f.Push(f.Locals[7]);f.Pc=809;continue;}
case 809:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",814);}
case 814:{f.Pc=f.Pop().Int!=0?917:817;continue;}
case 817:{f.Push(f.Locals[7]);f.Pc=819;continue;}
case 819:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2152:819:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",824);}
case 824:{return rt.Call(f,"forge/util/Aggregates","max","(Ljava/lang/Iterable;Ljava/util/function/Function;)Ljava/lang/Integer;","invokestatic",827);}
case 827:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",830);}
case 830:{f.Locals[8]=f.Pop();f.Pc=832;continue;}
case 832:{f.Push(f.Locals[5]);f.Pc=834;continue;}
case 834:{f.Push(f.Locals[0]);f.Pc=835;continue;}
case 835:{f.Push(JValue.R(rt.String("Choose power of creature to tap")));f.Pc=838;continue;}
case 838:{f.Push(JValue.I(0));f.Pc=839;continue;}
case 839:{f.Push(f.Locals[8]);f.Pc=841;continue;}
case 841:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;II)I","invokevirtual",844);}
case 844:{f.Locals[9]=f.Pop();f.Pc=846;continue;}
case 846:{f.Push(f.Locals[9]);f.Pc=848;continue;}
case 848:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2152:848:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",853);}
case 853:{f.Locals[10]=f.Pop();f.Pc=855;continue;}
case 855:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=858;continue;}
case 858:{f.StackOp("dup");f.Pc=859;continue;}
case 859:{f.Push(f.Locals[10]);f.Pc=861;continue;}
case 861:{f.Push(JValue.I(0));f.Pc=862;continue;}
case 862:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",865);}
case 865:{f.Locals[11]=f.Pop();f.Pc=867;continue;}
case 867:{f.Push(f.Locals[5]);f.Pc=869;continue;}
case 869:{f.Push(f.Locals[0]);f.Pc=870;continue;}
case 870:{f.Push(f.Locals[11]);f.Pc=872;continue;}
case 872:{f.Push(f.Locals[0]);f.Pc=873;continue;}
case 873:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",876);}
case 876:{f.Push(JValue.R(rt.String("Tap creature?")));f.Pc=879;continue;}
case 879:{return rt.Call(f,"forge/game/player/PlayerController","addKeywordCost","(Lforge/game/spellability/SpellAbility;Lforge/game/cost/Cost;Lforge/game/keyword/KeywordInterface;Ljava/lang/String;)Z","invokevirtual",882);}
case 882:{f.Pc=f.Pop().Int==0?917:885;continue;}
case 885:{f.Push(f.Locals[1]);f.Pc=886;continue;}
case 886:{f.Pc=f.Pop().Reference!=null?894:889;continue;}
case 889:{f.Push(f.Locals[0]);f.Pc=890;continue;}
case 890:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;","invokevirtual",893);}
case 893:{f.Locals[1]=f.Pop();f.Pc=894;continue;}
case 894:{f.Push(f.Locals[1]);f.Pc=895;continue;}
case 895:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",898);}
case 898:{f.Push(f.Locals[11]);f.Pc=900;continue;}
case 900:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",903);}
case 903:{f.StackOp("pop");f.Pc=904;continue;}
case 904:{f.Push(JValue.I(1));f.Pc=905;continue;}
case 905:{f.Locals[6]=f.Pop();f.Pc=907;continue;}
case 907:{f.Push(f.Locals[1]);f.Pc=908;continue;}
case 908:{f.Push(f.Locals[0]);f.Pc=909;continue;}
case 909:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",912);}
case 912:{f.Push(f.Locals[9]);f.Pc=914;continue;}
case 914:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOptionalKeywordAmount","(Lforge/game/keyword/KeywordInterface;I)V","invokevirtual",917);}
case 917:{f.Push(f.Locals[2]);f.Pc=918;continue;}
case 918:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",921);}
case 921:{f.Pc=f.Pop().Int==0?1130:924;continue;}
case 924:{f.Push(JValue.R(rt.String("As an additional cost to cast creature spells, you may pay any amount of mana. If you do, that creature enters with that many additional +1/+1 counters on it.")));f.Pc=927;continue;}
case 927:{f.Locals[7]=f.Pop();f.Pc=929;continue;}
case 929:{f.Push(f.Locals[4]);f.Pc=931;continue;}
case 931:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=934;continue;}
case 934:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",937);}
case 937:{return rt.Call(f,"forge/game/zone/PlayerZone","iterator","()Ljava/util/Iterator;","invokevirtual",940);}
case 940:{f.Locals[8]=f.Pop();f.Pc=942;continue;}
case 942:{f.Push(f.Locals[8]);f.Pc=944;continue;}
case 944:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",949);}
case 949:{f.Pc=f.Pop().Int==0?1130:952;continue;}
case 952:{f.Push(f.Locals[8]);f.Pc=954;continue;}
case 954:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",959);}
case 959:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=962;continue;}
case 962:{f.Locals[9]=f.Pop();f.Pc=964;continue;}
case 964:{f.Push(f.Locals[9]);f.Pc=966;continue;}
case 966:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",969);}
case 969:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",974);}
case 974:{f.Locals[10]=f.Pop();f.Pc=976;continue;}
case 976:{f.Push(f.Locals[10]);f.Pc=978;continue;}
case 978:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",983);}
case 983:{f.Pc=f.Pop().Int==0?1127:986;continue;}
case 986:{f.Push(f.Locals[10]);f.Pc=988;continue;}
case 988:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",993);}
case 993:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=996;continue;}
case 996:{f.Locals[11]=f.Pop();f.Pc=998;continue;}
case 998:{f.Push(f.Locals[7]);f.Pc=1000;continue;}
case 1000:{f.Push(f.Locals[11]);f.Pc=1002;continue;}
case 1002:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",1007);}
case 1007:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1010);}
case 1010:{f.Pc=f.Pop().Int==0?1124:1013;continue;}
case 1013:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=1016;continue;}
case 1016:{f.StackOp("dup");f.Pc=1017;continue;}
case 1017:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","ONE","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","ONE","Lforge/card/mana/ManaCost;"));f.Pc=1020;continue;}
case 1020:{f.Push(JValue.I(0));f.Pc=1021;continue;}
case 1021:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",1024);}
case 1024:{f.Locals[12]=f.Pop();f.Pc=1026;continue;}
case 1026:{f.Push(f.Locals[9]);f.Pc=1028;continue;}
case 1028:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",1031);}
case 1031:{f.Push(f.Locals[12]);f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",1036);}
case 1036:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2152:1036:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1041);}
case 1041:{f.Locals[13]=f.Pop();f.Pc=1043;continue;}
case 1043:{f.Push(f.Locals[5]);f.Pc=1045;continue;}
case 1045:{f.Push(f.Locals[0]);f.Pc=1046;continue;}
case 1046:{f.Push(f.Locals[12]);f.Pc=1048;continue;}
case 1048:{f.Push(f.Locals[11]);f.Pc=1050;continue;}
case 1050:{f.Push(f.Locals[13]);f.Pc=1052;continue;}
case 1052:{f.Push(JValue.I(2147483647));f.Pc=1055;continue;}
case 1055:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumberForKeywordCost","(Lforge/game/spellability/SpellAbility;Lforge/game/cost/Cost;Lforge/game/keyword/KeywordInterface;Ljava/lang/String;I)I","invokevirtual",1058);}
case 1058:{f.Locals[14]=f.Pop();f.Pc=1060;continue;}
case 1060:{f.Push(f.Locals[14]);f.Pc=1062;continue;}
case 1062:{f.Pc=f.Pop().Int<=0?1124:1065;continue;}
case 1065:{f.Push(f.Locals[9]);f.Pc=1067;continue;}
case 1067:{f.Push(f.Locals[2]);f.Pc=1068;continue;}
case 1068:{f.Push(f.Locals[4]);f.Pc=1070;continue;}
case 1070:{f.Push(JValue.R(rt.String("P1P1")));f.Pc=1073;continue;}
case 1073:{f.Push(f.Locals[14]);f.Pc=1075;continue;}
case 1075:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",1078);}
case 1078:{return rt.Call(f,"forge/game/GameActionUtil","createETBCountersEffect","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",1081);}
case 1081:{f.Locals[15]=f.Pop();f.Pc=1083;continue;}
case 1083:{f.Push(f.Locals[1]);f.Pc=1084;continue;}
case 1084:{f.Pc=f.Pop().Reference!=null?1092:1087;continue;}
case 1087:{f.Push(f.Locals[0]);f.Pc=1088;continue;}
case 1088:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;","invokevirtual",1091);}
case 1091:{f.Locals[1]=f.Pop();f.Pc=1092;continue;}
case 1092:{f.Push(f.Locals[1]);f.Pc=1093;continue;}
case 1093:{f.Push(f.Locals[15]);f.Pc=1095;continue;}
case 1095:{return rt.Call(f,"forge/game/spellability/SpellAbility","addRollbackEffect","(Lforge/game/card/Card;)V","invokevirtual",1098);}
case 1098:{f.Push(JValue.I(0));f.Pc=1099;continue;}
case 1099:{f.Locals[16]=f.Pop();f.Pc=1101;continue;}
case 1101:{f.Push(f.Locals[16]);f.Pc=1103;continue;}
case 1103:{f.Push(f.Locals[14]);f.Pc=1105;continue;}
case 1105:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1124:1108;continue;}
case 1108:{f.Push(f.Locals[1]);f.Pc=1109;continue;}
case 1109:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",1112);}
case 1112:{f.Push(f.Locals[12]);f.Pc=1114;continue;}
case 1114:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",1117);}
case 1117:{f.StackOp("pop");f.Pc=1118;continue;}
case 1118:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=1121;continue;}
case 1121:{f.Pc=1101;continue;}
case 1124:{f.Pc=976;continue;}
case 1127:{f.Pc=942;continue;}
case 1130:{f.Push(f.Locals[6]);f.Pc=1132;continue;}
case 1132:{f.Pc=f.Pop().Int==0?1147:1135;continue;}
case 1135:{f.Push(f.Locals[2]);f.Pc=1136;continue;}
case 1136:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",1139);}
case 1139:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1142);}
case 1142:{f.Push(JValue.I(0));f.Pc=1143;continue;}
case 1143:{f.Push(JValue.R(null));f.Pc=1144;continue;}
case 1144:{return rt.Call(f,"forge/game/trigger/TriggerHandler","resetActiveTriggers","(ZLforge/game/card/CardCollectionView;)V","invokevirtual",1147);}
case 1147:{f.Push(f.Locals[1]);f.Pc=1148;continue;}
case 1148:{f.Pc=f.Pop().Reference==null?1172:1151;continue;}
case 1151:{f.Push(f.Locals[0]);f.Pc=1152;continue;}
case 1152:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1155);}
case 1155:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",1158);}
case 1158:{f.Push(f.Locals[0]);f.Pc=1159;continue;}
case 1159:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1170:1162;continue;}
case 1162:{f.Push(f.Locals[0]);f.Pc=1163;continue;}
case 1163:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1166);}
case 1166:{f.Push(f.Locals[1]);f.Pc=1167;continue;}
case 1167:{return rt.Call(f,"forge/game/card/Card","setCastSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1170);}
case 1170:{f.Push(f.Locals[1]);f.Pc=1171;continue;}
case 1171:{return JStep.Return(f.Pop());}
case 1172:{f.Push(f.Locals[0]);f.Pc=1173;continue;}
case 1173:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2153(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[5]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/Game","nextCardId","()I","invokevirtual",15);}
case 15:{f.Push(f.Locals[5]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",20);}
case 20:{f.Locals[6]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[6]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/card/Card","setGameTimestamp","(J)V","invokevirtual",32);}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",38);}
case 38:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2153:38:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",43);}
case 43:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",46);}
case 46:{f.Push(f.Locals[6]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/Card","setOwner","(Lforge/game/player/Player;)V","invokevirtual",52);}
case 52:{f.Push(f.Locals[6]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",61);}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{if(!rt.StaticReady(f,"forge/card/ColorSet","C","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","C","Lforge/card/ColorSet;"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/Card","setColor","(Lforge/card/ColorSet;)V","invokevirtual",69);}
case 69:{f.Push(f.Locals[6]);f.Pc=71;continue;}
case 71:{if(!rt.StaticReady(f,"forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",77);}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",83);}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2153:86:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",91);}
case 91:{f.Locals[7]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[7]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",99);}
case 99:{f.Locals[8]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[4]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",106);}
case 106:{f.Pc=f.Pop().Int!=0?122:109;continue;}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",119);}
case 119:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",122);}
case 122:{f.Push(JValue.R(rt.String("It enters with ")));f.Pc=125;continue;}
case 125:{f.Locals[9]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[3]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",135);}
case 135:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",140);}
case 140:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2153:140:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",145);}
case 145:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",148);}
case 148:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2153:148:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",153);}
case 153:{f.Locals[9]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[9]);f.Pc=157;continue;}
case 157:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2153:157:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",162);}
case 162:{f.Locals[9]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[9]);f.Pc=166;continue;}
case 166:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2153:166:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",171);}
case 171:{f.Locals[10]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[10]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[6]);f.Pc=177;continue;}
case 177:{f.Push(JValue.I(1));f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",181);}
case 181:{f.Locals[11]=f.Pop();f.Pc=183;continue;}
case 183:{f.Push(f.Locals[11]);f.Pc=185;continue;}
case 185:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setLayer","(Lforge/game/replacement/ReplacementLayer;)V","invokevirtual",191);}
case 191:{f.Push(f.Locals[11]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[8]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",198);}
case 198:{f.Push(f.Locals[11]);f.Pc=200;continue;}
case 200:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",206);}
case 206:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",209);}
case 209:{f.Push(f.Locals[6]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[11]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",216);}
case 216:{f.StackOp("pop");f.Pc=217;continue;}
case 217:{f.Push(f.Locals[6]);f.Pc=219;continue;}
case 219:{f.Push(JValue.R(rt.String("Stack")));f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","addForgetOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",225);}
case 225:{f.Push(f.Locals[5]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",230);}
case 230:{f.Push(f.Locals[6]);f.Pc=232;continue;}
case 232:{f.Push(f.Locals[8]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",237);}
case 237:{f.Push(f.Locals[6]);f.Pc=239;continue;}
case 239:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2154(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference==null?56:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/GameActionUtil","generatedMana","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokestatic",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?48:26;continue;}
case 26:{f.Push(JValue.R(rt.String("0")));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?48:36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",41);}
case 41:{f.Push(JValue.R(rt.String(" ")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",52);}
case 52:{f.Locals[2]=f.Pop();f.Pc=53;continue;}
case 53:{f.Pc=10;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",60);}
case 60:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",63);}
case 63:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2155(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?13:9;continue;}
case 9:{f.Push(JValue.R(rt.String("")));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","amountOfManaGenerated","(Z)I","invokevirtual",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isComboMana","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?46:26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getExpressChoice","()Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Locals[2]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?96:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Locals[2]=f.Pop();f.Pc=43;continue;}
case 43:{f.Pc=96;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isAnyMana","()Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?72:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getExpressChoice","()Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Locals[2]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?96:65;continue;}
case 65:{f.Push(JValue.R(rt.String("Any")));f.Pc=68;continue;}
case 68:{f.Locals[2]=f.Pop();f.Pc=69;continue;}
case 69:{f.Pc=96;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",76);}
case 76:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ManaReflected","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ManaReflected","Lforge/game/ability/ApiType;"));f.Pc=79;continue;}
case 79:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?90:82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getExpressChoice","()Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Locals[2]=f.Pop();f.Pc=87;continue;}
case 87:{f.Pc=96;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","mana","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",95);}
case 95:{f.Locals[2]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Reference==null?111:103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(JValue.I(0));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","setUndoable","(Z)V","invokevirtual",108);}
case 108:{f.Pc=139;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("Amount")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int==0?139:121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("Amount")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",128);}
case 128:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",131);}
case 131:{f.Pc=f.Pop().Int!=0?139:134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/spellability/SpellAbility","setUndoable","(Z)V","invokevirtual",139);}
case 139:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=142;continue;}
case 142:{f.StackOp("dup");f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",146);}
case 146:{f.Locals[4]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[3]);f.Pc=149;continue;}
case 149:{f.Pc=f.Pop().Int>0?164:152;continue;}
case 152:{f.Push(f.Locals[4]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("0")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",160);}
case 160:{f.StackOp("pop");f.Pc=161;continue;}
case 161:{f.Pc=238;continue;}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isComboMana","()Z","invokevirtual",168);}
case 168:{f.Pc=f.Pop().Int==0?181:171;continue;}
case 171:{f.Push(f.Locals[4]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",177);}
case 177:{f.StackOp("pop");f.Pc=178;continue;}
case 178:{f.Pc=238;continue;}
case 181:{f.Push(f.Locals[2]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",185);}
case 185:{f.Pc=f.Pop().Int==0?203:188;continue;}
case 188:{f.Push(f.Locals[4]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[3]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[2]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",195);}
case 195:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",199);}
case 199:{f.StackOp("pop");f.Pc=200;continue;}
case 200:{f.Pc=238;continue;}
case 203:{f.Push(f.Locals[4]);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[2]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",209);}
case 209:{f.StackOp("pop");f.Pc=210;continue;}
case 210:{f.Push(JValue.I(1));f.Pc=211;continue;}
case 211:{f.Locals[5]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[5]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[3]);f.Pc=216;continue;}
case 216:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?238:219;continue;}
case 219:{f.Push(f.Locals[4]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String(" ")));f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",227);}
case 227:{f.Push(f.Locals[2]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",231);}
case 231:{f.StackOp("pop");f.Pc=232;continue;}
case 232:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=235;continue;}
case 235:{f.Pc=213;continue;}
case 238:{f.Push(f.Locals[4]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",243);}
case 243:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2156(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",6);}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?32:10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference==null?30:14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",21);}
case 21:{if(!rt.StaticReady(f,"forge/game/player/PlayerController$FullControlFlag","LayerTimestampOrder","Lforge/game/player/PlayerController$FullControlFlag;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerController$FullControlFlag","LayerTimestampOrder","Lforge/game/player/PlayerController$FullControlFlag;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/player/PlayerController","isFullControl","(Lforge/game/player/PlayerController$FullControlFlag;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?32:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return JStep.Return(f.Pop());}
case 32:{f.Push(JValue.R(null));f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",42);}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",49);}
case 49:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",52);}
case 52:{return rt.Call(f,"forge/game/Game","getPlayersInTurnOrder","(Lforge/game/player/Player;)Lforge/game/player/PlayerCollection;","invokevirtual",55);}
case 55:{f.Locals[6]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",62);}
case 62:{f.Locals[7]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[7]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",71);}
case 71:{f.Pc=f.Pop().Int==0?300:74;continue;}
case 74:{f.Push(f.Locals[7]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{f.Locals[8]=f.Pop();f.Pc=86;continue;}
case 86:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=89;continue;}
case 89:{f.StackOp("dup");f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",93);}
case 93:{f.Locals[9]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",101);}
case 101:{f.Locals[10]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[10]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",110);}
case 110:{f.Pc=f.Pop().Int==0?206:113;continue;}
case 113:{f.Push(f.Locals[10]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",120);}
case 120:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=123;continue;}
case 123:{f.Locals[11]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=129;continue;}
case 129:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?140:132;continue;}
case 132:{f.Push(f.Locals[11]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",137);}
case 137:{f.Pc=145;continue;}
case 140:{f.Push(f.Locals[11]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",145);}
case 145:{f.Locals[12]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[3]);f.Pc=148;continue;}
case 148:{f.Pc=f.Pop().Reference==null?185:151;continue;}
case 151:{f.Push(f.Locals[3]);f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int==0?185:161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",165);}
case 165:{f.Push(f.Locals[3]);f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",172);}
case 172:{f.Push(f.Locals[3]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",176);}
case 176:{f.Push(JValue.I(0));f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",180);}
case 180:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=183;continue;}
case 183:{f.Locals[12]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[12]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[8]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",192);}
case 192:{f.Pc=f.Pop().Int==0?203:195;continue;}
case 195:{f.Push(f.Locals[9]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[11]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",202);}
case 202:{f.StackOp("pop");f.Pc=203;continue;}
case 203:{f.Pc=103;continue;}
case 206:{f.Push(f.Locals[3]);f.Pc=207;continue;}
case 207:{f.Pc=f.Pop().Reference==null?262:210;continue;}
case 210:{f.Push(f.Locals[3]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",214);}
case 214:{f.Push(f.Locals[8]);f.Pc=216;continue;}
case 216:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?262:219;continue;}
case 219:{f.Push(f.Locals[3]);f.Pc=220;continue;}
case 220:{f.Push(JValue.R(rt.String("StaticEffect")));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",226);}
case 226:{f.Pc=f.Pop().Int==0?262:229;continue;}
case 229:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/DetachedCardEffect"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/DetachedCardEffect")));f.Pc=232;continue;}
case 232:{f.StackOp("dup");f.Pc=233;continue;}
case 233:{f.Push(f.Locals[3]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",237);}
case 237:{f.Push(f.Locals[3]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",241);}
case 241:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",244);}
case 244:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2156:244:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",249);}
case 249:{return rt.Call(f,"forge/game/ability/effects/DetachedCardEffect","<init>","(Lforge/game/card/Card;Ljava/lang/String;)V","invokespecial",252);}
case 252:{f.Locals[4]=f.Pop();f.Pc=254;continue;}
case 254:{f.Push(f.Locals[9]);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[4]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",261);}
case 261:{f.StackOp("pop");f.Pc=262;continue;}
case 262:{f.Push(f.Locals[9]);f.Pc=264;continue;}
case 264:{f.Locals[10]=f.Pop();f.Pc=266;continue;}
case 266:{f.Push(f.Locals[9]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",271);}
case 271:{f.Push(JValue.I(1));f.Pc=272;continue;}
case 272:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?289:275;continue;}
case 275:{f.Push(f.Locals[8]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",280);}
case 280:{f.Push(f.Locals[9]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[2]);f.Pc=283;continue;}
case 283:{f.Push(f.Locals[3]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/player/PlayerController","orderMoveToZoneList","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",287);}
case 287:{f.Locals[10]=f.Pop();f.Pc=289;continue;}
case 289:{f.Push(f.Locals[5]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[10]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",296);}
case 296:{f.StackOp("pop");f.Pc=297;continue;}
case 297:{f.Pc=64;continue;}
case 300:{f.Push(f.Locals[4]);f.Pc=302;continue;}
case 302:{f.Pc=f.Pop().Reference==null?389:305;continue;}
case 305:{f.Push(f.Locals[5]);f.Pc=307;continue;}
case 307:{f.Push(f.Locals[4]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/game/card/CardCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",312);}
case 312:{f.Locals[7]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[7]);f.Pc=316;continue;}
case 316:{f.Push(f.Locals[5]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",321);}
case 321:{f.Push(JValue.I(1));f.Pc=322;continue;}
case 322:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=323;continue;}
case 323:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?363:326;continue;}
case 326:{f.Push(f.Locals[3]);f.Pc=327;continue;}
case 327:{f.Push(JValue.R(rt.String("StaticEffectUntilCardID")));f.Pc=330;continue;}
case 330:{f.Push(f.Locals[5]);f.Pc=332;continue;}
case 332:{f.Push(f.Locals[7]);f.Pc=334;continue;}
case 334:{f.Push(JValue.I(1));f.Pc=335;continue;}
case 335:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",339);}
case 339:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",345);}
case 345:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",348);}
case 348:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",351);}
case 351:{f.Push(f.Locals[7]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[5]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",358);}
case 358:{f.Push(JValue.I(2));f.Pc=359;continue;}
case 359:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=360;continue;}
case 360:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=361;continue;}
case 361:{f.Locals[7]=f.Pop();f.Pc=363;continue;}
case 363:{f.Push(f.Locals[3]);f.Pc=364;continue;}
case 364:{f.Push(JValue.R(rt.String("StaticEffectTimestamp")));f.Pc=367;continue;}
case 367:{f.Push(f.Locals[0]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",371);}
case 371:{f.Push(f.Locals[7]);f.Pc=373;continue;}
case 373:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=374;continue;}
case 374:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=375;continue;}
case 375:{return rt.Call(f,"java/lang/String","valueOf","(J)Ljava/lang/String;","invokestatic",378);}
case 378:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",381);}
case 381:{f.Push(f.Locals[5]);f.Pc=383;continue;}
case 383:{f.Push(f.Locals[4]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",388);}
case 388:{f.StackOp("pop");f.Pc=389;continue;}
case 389:{f.Push(f.Locals[5]);f.Pc=391;continue;}
case 391:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2157(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[6]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[6]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","restoreGameState","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?43:17;continue;}
case 17:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",31);}
case 31:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",34);}
case 34:{return rt.DynamicCall(f,"forge/game/GameActionUtil:2157:34:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",39);}
case 39:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",42);}
case 42:{return JStep.ReturnVoid;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Reference==null?367:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int!=0?367:57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",62);}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/zone/Zone","remove","(Lforge/game/card/Card;)V","invokevirtual",67);}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",72);}
case 72:{if(!rt.StaticReady(f,"forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","PreparedSpell","Lforge/card/CardStateName;"));f.Pc=75;continue;}
case 75:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?87:78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",82);}
case 82:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",85);}
case 85:{f.Locals[4]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(null));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/Card","setCastSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",93);}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(null));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/Card","setCastFrom","(Lforge/game/zone/Zone;)V","invokevirtual",99);}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{f.Pc=f.Pop().Int<0?117:103;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/zone/Zone","size","()I","invokevirtual",108);}
case 108:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",111);}
case 111:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",114);}
case 114:{f.Pc=118;continue;}
case 117:{f.Push(JValue.R(null));f.Pc=118;continue;}
case 118:{f.Locals[7]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[4]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[7]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(null));f.Pc=126;continue;}
case 126:{f.Push(JValue.I(1));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/zone/Zone","add","(Lforge/game/card/Card;Ljava/lang/Integer;Lforge/game/card/Card;Z)V","invokevirtual",130);}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[4]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",136);}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(null));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/spellability/SpellAbility","setXManaCostPaid","(Ljava/lang/Integer;)V","invokevirtual",141);}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSpendPhyrexianMana","(Z)V","invokevirtual",146);}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/spellability/SpellAbility","clearPipsToReduce","()V","invokevirtual",150);}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(JValue.I(0));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPaidLife","(I)V","invokevirtual",155);}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("Announce")));f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",162);}
case 162:{f.Pc=f.Pop().Int==0?235:165;continue;}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("Announce")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",172);}
case 172:{f.Push(JValue.R(rt.String(",")));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",178);}
case 178:{f.Locals[8]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[8]);f.Pc=182;continue;}
case 182:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=183;continue;}
case 183:{f.Locals[9]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(JValue.I(0));f.Pc=186;continue;}
case 186:{f.Locals[10]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(f.Locals[10]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[9]);f.Pc=192;continue;}
case 192:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?235:195;continue;}
case 195:{f.Push(f.Locals[8]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[10]);f.Pc=199;continue;}
case 199:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=200;continue;}
case 200:{f.Locals[11]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[11]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",207);}
case 207:{f.Locals[12]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[12]);f.Pc=211;continue;}
case 211:{f.Push(JValue.R(rt.String("X")));f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",217);}
case 217:{f.Pc=f.Pop().Int!=0?229:220;continue;}
case 220:{f.Push(f.Locals[0]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[12]);f.Pc=223;continue;}
case 223:{f.Push(JValue.R(rt.String("0")));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",229);}
case 229:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=232;continue;}
case 232:{f.Pc=188;continue;}
case 235:{f.Push(f.Locals[4]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/card/Card","getSpells","()Lforge/util/collect/FCollectionView;","invokevirtual",240);}
case 240:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",245);}
case 245:{f.Locals[8]=f.Pop();f.Pc=247;continue;}
case 247:{f.Push(f.Locals[8]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",254);}
case 254:{f.Pc=f.Pop().Int==0?279:257;continue;}
case 257:{f.Push(f.Locals[8]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",264);}
case 264:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=267;continue;}
case 267:{f.Locals[9]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[9]);f.Pc=271;continue;}
case 271:{f.Push(f.Locals[4]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",276);}
case 276:{f.Pc=247;continue;}
case 279:{f.Push(f.Locals[0]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/spellability/SpellAbility","rollback","()V","invokevirtual",283);}
case 283:{f.Push(f.Locals[4]);f.Pc=285;continue;}
case 285:{f.Push(JValue.I(0));f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",289);}
case 289:{f.Push(f.Locals[4]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[4]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/card/Card","getFaceupCardStateName","()Lforge/card/CardStateName;","invokevirtual",296);}
case 296:{f.Push(JValue.I(1));f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/card/Card","setState","(Lforge/card/CardStateName;Z)Z","invokevirtual",300);}
case 300:{f.StackOp("pop");f.Pc=301;continue;}
case 301:{f.Push(f.Locals[4]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/card/Card","unanimateBestow","()V","invokevirtual",306);}
case 306:{f.Push(f.Locals[0]);f.Pc=307;continue;}
case 307:{f.Push(JValue.R(rt.String("Prototype")));f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",313);}
case 313:{f.Pc=f.Pop().Int==0?327:316;continue;}
case 316:{f.Push(f.Locals[4]);f.Pc=318;continue;}
case 318:{f.Push(f.Locals[4]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/card/Card","getPrototypeTimestamp","()J","invokevirtual",323);}
case 323:{return rt.Call(f,"forge/game/card/Card","removeCloneState","(J)Z","invokevirtual",326);}
case 326:{f.StackOp("pop");f.Pc=327;continue;}
case 327:{f.Push(f.Locals[0]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTappedForConvoke","()Lforge/game/card/CardCollection;","invokevirtual",331);}
case 331:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",334);}
case 334:{f.Locals[8]=f.Pop();f.Pc=336;continue;}
case 336:{f.Push(f.Locals[8]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",343);}
case 343:{f.Pc=f.Pop().Int==0?367:346;continue;}
case 346:{f.Push(f.Locals[8]);f.Pc=348;continue;}
case 348:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",353);}
case 353:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=356;continue;}
case 356:{f.Locals[9]=f.Pop();f.Pc=358;continue;}
case 358:{f.Push(f.Locals[9]);f.Pc=360;continue;}
case 360:{f.Push(JValue.I(0));f.Pc=361;continue;}
case 361:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",364);}
case 364:{f.Pc=336;continue;}
case 367:{f.Push(f.Locals[0]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",371);}
case 371:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"));f.Pc=374;continue;}
case 374:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?387:377;continue;}
case 377:{f.Push(f.Locals[0]);f.Pc=378;continue;}
case 378:{f.Push(JValue.R(null));f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",382);}
case 382:{f.Push(f.Locals[0]);f.Pc=383;continue;}
case 383:{f.Push(JValue.R(null));f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/game/spellability/SpellAbility","setChosenList","(Ljava/util/List;)V","invokevirtual",387);}
case 387:{f.Push(f.Locals[0]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetOnceResolved","()V","invokevirtual",391);}
case 391:{f.Push(f.Locals[3]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/cost/CostPayment","refundPayment","()V","invokevirtual",395);}
case 395:{f.Push(f.Locals[6]);f.Pc=397;continue;}
case 397:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",400);}
case 400:{f.Push(JValue.I(0));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/zone/MagicStack","setFrozen","(Z)V","invokevirtual",404);}
case 404:{f.Push(f.Locals[6]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",409);}
case 409:{f.Push(f.Locals[5]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearWaitingTriggersFrom","(I)V","invokevirtual",414);}
case 414:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

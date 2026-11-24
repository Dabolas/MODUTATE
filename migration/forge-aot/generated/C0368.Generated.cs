// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C368{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RecruitEffect","forge/game/ability/effects/TokenEffectBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3612,"forge/game/ability/effects/RecruitEffect","<init>","()V",1,1,1,new JHandler[]{},M3612));
c.Add(new JMethod(3613,"forge/game/ability/effects/RecruitEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,3,new JHandler[]{},M3613));
c.Add(new JMethod(3614,"forge/game/ability/effects/RecruitEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,13,6,new JHandler[]{},M3614));
}

internal static JStep M3612(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3613(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/RecruitEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int>0?17:14;continue;}
case 14:{f.Push(JValue.R(rt.String("")));f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
case 17:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",30);}
case 30:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",33);}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",39);}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?48:43;continue;}
case 43:{f.Push(JValue.R(rt.String(" recruit.")));f.Pc=45;continue;}
case 45:{f.Pc=50;continue;}
case 48:{f.Push(JValue.R(rt.String(" recruits.")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",58);}
case 58:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3614(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/mutable/MutableBoolean"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/mutable/MutableBoolean")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","<init>","(Z)V","invokespecial",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/ability/effects/RecruitEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",24);}
case 24:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",27);}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[5]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int==0?282:39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[6]=f.Pop();f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",54);}
case 54:{f.Locals[7]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[7]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",62);}
case 62:{f.Locals[8]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[7]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/player/Player","drawCards","(ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",73);}
case 73:{f.StackOp("pop");f.Pc=74;continue;}
case 74:{f.Push(f.Locals[8]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",81);}
case 81:{f.Push(f.Locals[3]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",85);}
case 85:{return rt.Call(f,"forge/game/trigger/TriggerHandler","collectTriggerForWaiting","()V","invokevirtual",88);}
case 88:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=91;continue;}
case 91:{f.StackOp("dup");f.Pc=92;continue;}
case 92:{f.Push(f.Locals[6]);f.Pc=94;continue;}
case 94:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",100);}
case 100:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",103);}
case 103:{f.Locals[9]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[9]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",110);}
case 110:{f.Pc=f.Pop().Int!=0?279:113;continue;}
case 113:{f.Push(f.Locals[6]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(JValue.I(1));f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/player/Player","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?279:123;continue;}
case 123:{f.Push(f.Locals[9]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",128);}
case 128:{f.Push(JValue.I(1));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",132);}
case 132:{f.Locals[10]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[10]);f.Pc=136;continue;}
case 136:{f.Pc=f.Pop().Int!=0?145:139;continue;}
case 139:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=142;continue;}
case 142:{f.Pc=162;continue;}
case 145:{f.Push(f.Locals[6]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",150);}
case 150:{f.Push(f.Locals[6]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[1]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[9]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[10]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[10]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsToDiscardFrom","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;II)Lforge/game/card/CardCollectionView;","invokevirtual",162);}
case 162:{f.Locals[11]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[3]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[11]);f.Pc=167;continue;}
case 167:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=170;continue;}
case 170:{f.Push(f.Locals[1]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",174);}
case 174:{f.Locals[11]=f.Pop();f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",179);}
case 179:{f.Locals[7]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[7]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",187);}
case 187:{f.Locals[8]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[1]);f.Pc=190;continue;}
case 190:{f.Push(JValue.I(1));f.Pc=191;continue;}
case 191:{f.Push(f.Locals[6]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[11]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/card/CardCollection","getView","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokestatic",198);}
case 198:{return rt.Call(f,"java/util/Map","of","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;","invokestatic",201);}
case 201:{f.Push(f.Locals[7]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/ability/effects/RecruitEffect","discard","(Lforge/game/spellability/SpellAbility;ZLjava/util/Map;Ljava/util/Map;)V","invokestatic",206);}
case 206:{f.Push(f.Locals[8]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[3]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[1]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",213);}
case 213:{f.Push(f.Locals[11]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/card/CardCollectionView","stream","()Ljava/util/stream/Stream;","invokeinterface",220);}
case 220:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","NON_LANDS","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","NON_LANDS","Ljava/util/function/Predicate;"));f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",228);}
case 228:{f.Pc=f.Pop().Int==0?279:231;continue;}
case 231:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=234;continue;}
case 234:{f.StackOp("dup");f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",238);}
case 238:{f.Locals[12]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[0]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[6]);f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.String("w_1_1_human_soldier")));f.Pc=246;continue;}
case 246:{f.Push(JValue.I(1));f.Pc=247;continue;}
case 247:{f.Push(f.Locals[1]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/ability/effects/RecruitEffect","makeTokenTableInternal","(Lforge/game/player/Player;Ljava/lang/String;ILforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;","invokevirtual",251);}
case 251:{f.Push(JValue.I(0));f.Pc=252;continue;}
case 252:{f.Push(f.Locals[12]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[4]);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[1]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/ability/effects/RecruitEffect","makeTokenTable","(Lforge/game/card/TokenCreateTable;ZLforge/game/card/CardZoneTable;Lorg/apache/commons/lang3/mutable/MutableBoolean;Lforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;","invokevirtual",260);}
case 260:{f.StackOp("pop");f.Pc=261;continue;}
case 261:{f.Push(f.Locals[12]);f.Pc=263;continue;}
case 263:{f.Push(f.Locals[3]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[1]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",268);}
case 268:{f.Push(f.Locals[3]);f.Pc=269;continue;}
case 269:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventTokenCreated"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventTokenCreated")));f.Pc=272;continue;}
case 272:{f.StackOp("dup");f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/event/GameEventTokenCreated","<init>","()V","invokespecial",276);}
case 276:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",279);}
case 279:{f.Pc=29;continue;}
case 282:{f.Push(f.Locals[4]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","isTrue","()Z","invokevirtual",287);}
case 287:{f.Pc=f.Pop().Int==0?305:290;continue;}
case 290:{f.Push(f.Locals[3]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",294);}
case 294:{f.Push(f.Locals[3]);f.Pc=295;continue;}
case 295:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=298;continue;}
case 298:{f.StackOp("dup");f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",302);}
case 302:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",305);}
case 305:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

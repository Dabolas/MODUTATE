// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C250{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ConniveEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3192,"forge/game/ability/effects/ConniveEffect","<init>","()V",1,1,1,new JHandler[]{},M3192));
c.Add(new JMethod(3193,"forge/game/ability/effects/ConniveEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M3193));
c.Add(new JMethod(3194,"forge/game/ability/effects/ConniveEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,3,new JHandler[]{},M3194));
c.Add(new JMethod(3195,"forge/game/ability/effects/ConniveEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,19,6,new JHandler[]{},M3195));
}

internal static JStep M3192(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3193(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3194(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/ConniveEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",4);}
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
case 43:{f.Push(JValue.R(rt.String(" connive.")));f.Pc=45;continue;}
case 45:{f.Pc=50;continue;}
case 48:{f.Push(JValue.R(rt.String(" connives.")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",58);}
case 58:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3195(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("ConniveNum")));f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("1")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/ability/effects/ConniveEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",29);}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?40:39;continue;}
case 39:{return JStep.ReturnVoid;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/game/Game","getPlayersInTurnOrder","(Lforge/game/player/Player;)Lforge/game/player/PlayerCollection;","invokevirtual",51);}
case 51:{f.Locals[6]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/CardCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",60);}
case 60:{return rt.DynamicCall(f,"forge/game/ability/effects/ConniveEffect:3195:60:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",65);}
case 65:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",70);}
case 70:{return rt.Call(f,"java/util/stream/Collectors","toSet","()Ljava/util/stream/Collector;","invokestatic",73);}
case 73:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",78);}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/player/PlayerCollection","retainAll","(Ljava/util/Collection;)Z","invokevirtual",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Push(f.Locals[6]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",90);}
case 90:{f.Locals[7]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[7]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",99);}
case 99:{f.Pc=f.Pop().Int==0?472:102;continue;}
case 102:{f.Push(f.Locals[7]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",109);}
case 109:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=112;continue;}
case 112:{f.Locals[8]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[8]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",121);}
case 121:{f.Locals[9]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[9]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int!=0?469:131;continue;}
case 131:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=134;continue;}
case 134:{f.StackOp("dup");f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",138);}
case 138:{f.Locals[10]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[9]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",145);}
case 145:{f.Push(JValue.I(1));f.Pc=146;continue;}
case 146:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?179:149;continue;}
case 149:{f.Push(f.Locals[8]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",154);}
case 154:{f.Push(f.Locals[9]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",160);}
case 160:{f.Push(JValue.R(rt.String("lblChooseConniver")));f.Pc=162;continue;}
case 162:{f.Push(JValue.I(0));f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",169);}
case 169:{f.Push(JValue.R(null));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",173);}
case 173:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=176;continue;}
case 176:{f.Pc=188;continue;}
case 179:{f.Push(f.Locals[9]);f.Pc=181;continue;}
case 181:{f.Push(JValue.I(0));f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",185);}
case 185:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=188;continue;}
case 188:{f.Locals[11]=f.Pop();f.Pc=190;continue;}
case 190:{f.Push(f.Locals[9]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[11]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",197);}
case 197:{f.StackOp("pop");f.Pc=198;continue;}
case 198:{f.Push(f.Locals[3]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",202);}
case 202:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Connive","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Connive","Lforge/game/replacement/ReplacementType;"));f.Pc=205;continue;}
case 205:{f.Push(f.Locals[11]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",210);}
case 210:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",213);}
case 213:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=216;continue;}
case 216:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?222:219;continue;}
case 219:{f.Pc=123;continue;}
case 222:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",225);}
case 225:{f.Locals[12]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[12]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[1]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",233);}
case 233:{f.Locals[13]=f.Pop();f.Pc=235;continue;}
case 235:{f.Push(f.Locals[8]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[4]);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[1]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[12]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/player/Player","drawCards","(ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",245);}
case 245:{f.StackOp("pop");f.Pc=246;continue;}
case 246:{f.Push(f.Locals[13]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[3]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[1]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",253);}
case 253:{f.Push(f.Locals[3]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",257);}
case 257:{return rt.Call(f,"forge/game/trigger/TriggerHandler","collectTriggerForWaiting","()V","invokevirtual",260);}
case 260:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=263;continue;}
case 263:{f.StackOp("dup");f.Pc=264;continue;}
case 264:{f.Push(f.Locals[8]);f.Pc=266;continue;}
case 266:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",272);}
case 272:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",275);}
case 275:{f.Locals[14]=f.Pop();f.Pc=277;continue;}
case 277:{f.Push(f.Locals[14]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",282);}
case 282:{f.Pc=f.Pop().Int!=0?450:285;continue;}
case 285:{f.Push(f.Locals[8]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[1]);f.Pc=288;continue;}
case 288:{f.Push(JValue.I(1));f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/player/Player","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",292);}
case 292:{f.Pc=f.Pop().Int==0?450:295;continue;}
case 295:{f.Push(f.Locals[14]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",300);}
case 300:{f.Push(f.Locals[4]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",305);}
case 305:{f.Locals[15]=f.Pop();f.Pc=307;continue;}
case 307:{f.Push(f.Locals[15]);f.Pc=309;continue;}
case 309:{f.Pc=f.Pop().Int!=0?318:312;continue;}
case 312:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=315;continue;}
case 315:{f.Pc=335;continue;}
case 318:{f.Push(f.Locals[8]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",323);}
case 323:{f.Push(f.Locals[8]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[1]);f.Pc=326;continue;}
case 326:{f.Push(f.Locals[14]);f.Pc=328;continue;}
case 328:{f.Push(f.Locals[15]);f.Pc=330;continue;}
case 330:{f.Push(f.Locals[15]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsToDiscardFrom","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;II)Lforge/game/card/CardCollectionView;","invokevirtual",335);}
case 335:{f.Locals[16]=f.Pop();f.Pc=337;continue;}
case 337:{f.Push(f.Locals[3]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[16]);f.Pc=340;continue;}
case 340:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=343;continue;}
case 343:{f.Push(f.Locals[1]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",347);}
case 347:{f.Locals[16]=f.Pop();f.Pc=349;continue;}
case 349:{f.Push(f.Locals[3]);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[11]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",355);}
case 355:{f.Locals[17]=f.Pop();f.Pc=357;continue;}
case 357:{f.Push(f.Locals[3]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[17]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",363);}
case 363:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",369);}
case 369:{f.Pc=f.Pop().Int==0?406:372;continue;}
case 372:{f.Push(f.Locals[17]);f.Pc=374;continue;}
case 374:{f.Push(f.Locals[11]);f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",379);}
case 379:{f.Pc=f.Pop().Int==0?406:382;continue;}
case 382:{f.Push(f.Locals[16]);f.Pc=384;continue;}
case 384:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","NON_LANDS","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","NON_LANDS","Ljava/util/function/Predicate;"));f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",390);}
case 390:{f.Locals[18]=f.Pop();f.Pc=392;continue;}
case 392:{f.Push(f.Locals[17]);f.Pc=394;continue;}
case 394:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"));f.Pc=397;continue;}
case 397:{f.Push(f.Locals[18]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[8]);f.Pc=401;continue;}
case 401:{f.Push(f.Locals[10]);f.Pc=403;continue;}
case 403:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",406);}
case 406:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",409);}
case 409:{f.Locals[12]=f.Pop();f.Pc=411;continue;}
case 411:{f.Push(f.Locals[12]);f.Pc=413;continue;}
case 413:{f.Push(f.Locals[1]);f.Pc=414;continue;}
case 414:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",417);}
case 417:{f.Locals[13]=f.Pop();f.Pc=419;continue;}
case 419:{f.Push(f.Locals[1]);f.Pc=420;continue;}
case 420:{f.Push(JValue.I(1));f.Pc=421;continue;}
case 421:{f.Push(f.Locals[8]);f.Pc=423;continue;}
case 423:{f.Push(f.Locals[16]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/game/card/CardCollection","getView","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokestatic",428);}
case 428:{return rt.Call(f,"java/util/Map","of","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;","invokestatic",431);}
case 431:{f.Push(f.Locals[12]);f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/ability/effects/ConniveEffect","discard","(Lforge/game/spellability/SpellAbility;ZLjava/util/Map;Ljava/util/Map;)V","invokestatic",436);}
case 436:{f.Push(f.Locals[10]);f.Pc=438;continue;}
case 438:{f.Push(f.Locals[3]);f.Pc=439;continue;}
case 439:{f.Push(f.Locals[1]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",443);}
case 443:{f.Push(f.Locals[13]);f.Pc=445;continue;}
case 445:{f.Push(f.Locals[3]);f.Pc=446;continue;}
case 446:{f.Push(f.Locals[1]);f.Pc=447;continue;}
case 447:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",450);}
case 450:{f.Push(f.Locals[3]);f.Pc=451;continue;}
case 451:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",454);}
case 454:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Connives","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Connives","Lforge/game/trigger/TriggerType;"));f.Pc=457;continue;}
case 457:{f.Push(f.Locals[11]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",462);}
case 462:{f.Push(JValue.I(0));f.Pc=463;continue;}
case 463:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",466);}
case 466:{f.Pc=123;continue;}
case 469:{f.Pc=92;continue;}
case 472:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

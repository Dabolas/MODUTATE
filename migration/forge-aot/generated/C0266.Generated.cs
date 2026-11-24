// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C266{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CountersProliferateEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3256,"forge/game/ability/effects/CountersProliferateEffect","<init>","()V",1,1,1,new JHandler[]{},M3256));
c.Add(new JMethod(3257,"forge/game/ability/effects/CountersProliferateEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,2,new JHandler[]{},M3257));
c.Add(new JMethod(3258,"forge/game/ability/effects/CountersProliferateEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,18,9,new JHandler[]{},M3258));
c.Add(new JMethod(3259,"forge/game/ability/effects/CountersProliferateEffect","lambda$resolve$0","(Lforge/game/player/Player;Lforge/game/player/Player;)Z",4106,2,2,new JHandler[]{},M3259));
}

internal static JStep M3256(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3257(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Proliferate.")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String(" (Choose any number of permanents and/or players,")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String(" then give each another counter of each kind already there.)")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",33);}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3258(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Amount")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?39:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Amount")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",36);}
case 36:{f.Pc=40;continue;}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{f.Locals[5]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",46);}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Source","Lforge/game/ability/AbilityKey;"));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Num","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Num","Lforge/game/ability/AbilityKey;"));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",70);}
case 70:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{if(!rt.StaticReady(f,"forge/game/ability/effects/CountersProliferateEffect$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/effects/CountersProliferateEffect$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",84);}
case 84:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Proliferate","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Proliferate","Lforge/game/replacement/ReplacementType;"));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",92);}
case 92:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",95);}
case 95:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=96;continue;}
case 96:{switch(f.Pop().Int){case 1:f.Pc=124;break;case 2:f.Pc=127;break;default:f.Pc=148;break;}continue;}
case 124:{f.Pc=149;continue;}
case 127:{f.Push(f.Locals[6]);f.Pc=129;continue;}
case 129:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Num","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Num","Lforge/game/ability/AbilityKey;"));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",137);}
case 137:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",143);}
case 143:{f.Locals[5]=f.Pop();f.Pc=145;continue;}
case 145:{f.Pc=149;continue;}
case 148:{return JStep.ReturnVoid;}
case 149:{f.Push(f.Locals[2]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",153);}
case 153:{f.Locals[7]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(JValue.I(0));f.Pc=156;continue;}
case 156:{f.Locals[8]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[8]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[5]);f.Pc=162;continue;}
case 162:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?440:165;continue;}
case 165:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=168;continue;}
case 168:{f.StackOp("dup");f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",172);}
case 172:{f.Locals[9]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[9]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[4]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",181);}
case 181:{return rt.Call(f,"forge/game/player/PlayerPredicates","hasCounters","()Ljava/util/function/Predicate;","invokestatic",184);}
case 184:{return rt.Call(f,"forge/game/player/PlayerCollection","filter","(Ljava/util/function/Predicate;)Lforge/game/player/PlayerCollection;","invokevirtual",187);}
case 187:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",190);}
case 190:{f.StackOp("pop");f.Pc=191;continue;}
case 191:{f.Push(f.Locals[9]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[4]);f.Pc=195;continue;}
case 195:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",201);}
case 201:{return rt.Call(f,"forge/game/card/CardPredicates","hasCounters","()Ljava/util/function/Predicate;","invokestatic",204);}
case 204:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",207);}
case 207:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",210);}
case 210:{f.StackOp("pop");f.Pc=211;continue;}
case 211:{f.Push(f.Locals[7]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[9]);f.Pc=215;continue;}
case 215:{f.Push(JValue.I(0));f.Pc=216;continue;}
case 216:{f.Push(f.Locals[9]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/util/collect/FCollection","size","()I","invokevirtual",221);}
case 221:{f.Push(JValue.R(null));f.Pc=222;continue;}
case 222:{f.Push(f.Locals[1]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",226);}
case 226:{f.Push(JValue.R(rt.String("lblChooseProliferateTarget")));f.Pc=228;continue;}
case 228:{f.Push(JValue.I(0));f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",235);}
case 235:{f.Push(f.Locals[2]);f.Pc=236;continue;}
case 236:{f.Push(JValue.R(null));f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/player/PlayerController","chooseEntitiesForEffect","(Lforge/util/collect/FCollectionView;IILforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/Player;Ljava/util/Map;)Ljava/util/List;","invokevirtual",240);}
case 240:{f.Locals[10]=f.Pop();f.Pc=242;continue;}
case 242:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=245;continue;}
case 245:{f.StackOp("dup");f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",249);}
case 249:{f.Locals[11]=f.Pop();f.Pc=251;continue;}
case 251:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=254;continue;}
case 254:{f.StackOp("dup");f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",258);}
case 258:{f.Locals[12]=f.Pop();f.Pc=260;continue;}
case 260:{f.Push(f.Locals[10]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",267);}
case 267:{f.Locals[13]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[13]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",276);}
case 276:{f.Pc=f.Pop().Int==0?410:279;continue;}
case 279:{f.Push(f.Locals[13]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",286);}
case 286:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=289;continue;}
case 289:{f.Locals[14]=f.Pop();f.Pc=291;continue;}
case 291:{f.Push(f.Locals[14]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/GameEntity","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",296);}
case 296:{return rt.Call(f,"com/google/common/collect/Multiset","elementSet","()Ljava/util/Set;","invokeinterface",301);}
case 301:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",306);}
case 306:{f.Locals[15]=f.Pop();f.Pc=308;continue;}
case 308:{f.Push(f.Locals[15]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",315);}
case 315:{f.Pc=f.Pop().Int==0?407:318;continue;}
case 318:{f.Push(f.Locals[15]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",325);}
case 325:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=328;continue;}
case 328:{f.Locals[16]=f.Pop();f.Pc=330;continue;}
case 330:{f.Push(f.Locals[16]);f.Pc=332;continue;}
case 332:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","POISON","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","POISON","Lforge/game/card/CounterEnumType;"));f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/card/CounterType","is","(Lforge/game/card/CounterEnumType;)Z","invokeinterface",340);}
case 340:{f.Pc=f.Pop().Int==0?393:343;continue;}
case 343:{f.Push(f.Locals[14]);f.Pc=345;continue;}
case 345:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=348;continue;}
case 348:{f.Pc=f.Pop().Int==0?393:351;continue;}
case 351:{f.Push(f.Locals[14]);f.Pc=353;continue;}
case 353:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=356;continue;}
case 356:{f.Locals[17]=f.Pop();f.Pc=358;continue;}
case 358:{f.Push(f.Locals[12]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",365);}
case 365:{f.Push(f.Locals[17]);f.Pc=367;continue;}
case 367:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersProliferateEffect:3258:367:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",372);}
case 372:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",377);}
case 377:{f.Pc=f.Pop().Int==0?383:380;continue;}
case 380:{f.Pc=308;continue;}
case 383:{f.Push(f.Locals[12]);f.Pc=385;continue;}
case 385:{f.Push(f.Locals[17]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",392);}
case 392:{f.StackOp("pop");f.Pc=393;continue;}
case 393:{f.Push(f.Locals[14]);f.Pc=395;continue;}
case 395:{f.Push(f.Locals[16]);f.Pc=397;continue;}
case 397:{f.Push(JValue.I(1));f.Pc=398;continue;}
case 398:{f.Push(f.Locals[2]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[11]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/GameEntity","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",404);}
case 404:{f.Pc=308;continue;}
case 407:{f.Pc=269;continue;}
case 410:{f.Push(f.Locals[11]);f.Pc=412;continue;}
case 412:{f.Push(f.Locals[4]);f.Pc=414;continue;}
case 414:{f.Push(f.Locals[1]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",418);}
case 418:{f.Push(f.Locals[4]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",423);}
case 423:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Proliferate","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Proliferate","Lforge/game/trigger/TriggerType;"));f.Pc=426;continue;}
case 426:{f.Push(f.Locals[2]);f.Pc=427;continue;}
case 427:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",430);}
case 430:{f.Push(JValue.I(0));f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",434);}
case 434:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=437;continue;}
case 437:{f.Pc=158;continue;}
case 440:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3259(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getSharedTeam","()Lforge/game/player/PlayerCollection;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

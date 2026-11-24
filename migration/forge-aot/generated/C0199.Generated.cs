// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C199{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AmassEffect","forge/game/ability/effects/TokenEffectBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3014,"forge/game/ability/effects/AmassEffect","<init>","()V",1,1,1,new JHandler[]{},M3014));
c.Add(new JMethod(3015,"forge/game/ability/effects/AmassEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,4,new JHandler[]{},M3015));
c.Add(new JMethod(3016,"forge/game/ability/effects/AmassEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,13,6,new JHandler[]{},M3016));
c.Add(new JMethod(3017,"forge/game/ability/effects/AmassEffect","$deserializeLambda$","(Ljava/lang/invoke/SerializedLambda;)Ljava/lang/Object;",4106,3,3,new JHandler[]{},M3017));
c.Add(new JMethod(3018,"forge/game/ability/effects/AmassEffect","lambda$resolve$f894d637$1","(Lforge/game/Game;Lforge/game/card/Card;)V",4106,2,2,new JHandler[]{},M3018));
}

internal static JStep M3014(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3015(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Amass ")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Num")));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("1")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("Type")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/card/CardType","getPluralType","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",44);}
case 44:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",47);}
case 47:{f.Push(JValue.R(rt.String(" ")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",57);}
case 57:{f.Push(JValue.R(rt.String(" (Put ")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("+1/+1 counter")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",71);}
case 71:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{return rt.DynamicCall(f,"forge/game/ability/effects/AmassEffect:3015:78:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",83);}
case 83:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",91);}
case 91:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3016(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/ability/effects/AmassEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",14);}
case 14:{return rt.Call(f,"forge/game/player/PlayerCollection","getFirst","()Ljava/lang/Object;","invokevirtual",17);}
case 17:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=20;continue;}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Reference!=null?28:27;continue;}
case 27:{return JStep.ReturnVoid;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Num")));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("1")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",41);}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("Type")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",49);}
case 49:{f.Locals[6]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",59);}
case 59:{f.Push(JValue.R(rt.String("Army")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/CardPredicates","isType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",64);}
case 64:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",69);}
case 69:{f.Pc=f.Pop().Int!=0?253:72;continue;}
case 72:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",79);}
case 79:{f.Locals[7]=f.Pop();f.Pc=81;continue;}
case 81:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/mutable/MutableBoolean"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/mutable/MutableBoolean")));f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{f.Push(JValue.I(0));f.Pc=86;continue;}
case 86:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","<init>","(Z)V","invokespecial",89);}
case 89:{f.Locals[8]=f.Pop();f.Pc=91;continue;}
case 91:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("b_0_0_")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",100);}
case 100:{f.Locals[9]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[9]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("Type")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",110);}
case 110:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",113);}
case 113:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",116);}
case 116:{f.Push(JValue.R(rt.String("_army")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",121);}
case 121:{f.StackOp("pop");f.Pc=122;continue;}
case 122:{f.Push(f.Locals[9]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",127);}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{f.Push(JValue.I(0));f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/token/TokenInfo","getProtoType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Lforge/game/card/Card;","invokestatic",134);}
case 134:{f.Locals[10]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[10]);f.Pc=138;continue;}
case 138:{f.Pc=f.Pop().Reference!=null?152:141;continue;}
case 141:{f.Push(JValue.R(rt.String("b_0_0_army")));f.Pc=143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[4]);f.Pc=146;continue;}
case 146:{f.Push(JValue.I(0));f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/card/token/TokenInfo","getProtoType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Lforge/game/card/Card;","invokestatic",150);}
case 150:{f.Locals[10]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[10]);f.Pc=154;continue;}
case 154:{f.Push(JValue.I(2));f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=158;continue;}
case 158:{f.StackOp("dup");f.Pc=159;continue;}
case 159:{f.Push(JValue.I(0));f.Pc=160;continue;}
case 160:{f.Push(f.Locals[6]);f.Pc=162;continue;}
case 162:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=163;continue;}
case 163:{f.StackOp("dup");f.Pc=164;continue;}
case 164:{f.Push(JValue.I(1));f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("Army")));f.Pc=167;continue;}
case 167:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=168;continue;}
case 168:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",171);}
case 171:{return rt.Call(f,"forge/game/card/Card","setCreatureTypes","(Ljava/util/Collection;)V","invokevirtual",174);}
case 174:{f.Push(f.Locals[10]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[6]);f.Pc=178;continue;}
case 178:{return rt.DynamicCall(f,"forge/game/ability/effects/AmassEffect:3016:178:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",183);}
case 183:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",186);}
case 186:{f.Push(f.Locals[10]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[1]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/card/Card","setTokenSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",192);}
case 192:{f.Push(f.Locals[0]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[0]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[4]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[10]);f.Pc=198;continue;}
case 198:{f.Push(JValue.I(1));f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/ability/effects/AmassEffect","makeTokenTableInternal","(Lforge/game/player/Player;Lforge/game/card/Card;I)Lforge/game/card/TokenCreateTable;","invokevirtual",202);}
case 202:{f.Push(JValue.I(0));f.Pc=203;continue;}
case 203:{f.Push(f.Locals[7]);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[8]);f.Pc=207;continue;}
case 207:{f.Push(f.Locals[1]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/ability/effects/AmassEffect","makeTokenTable","(Lforge/game/card/TokenCreateTable;ZLforge/game/card/CardZoneTable;Lorg/apache/commons/lang3/mutable/MutableBoolean;Lforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;","invokevirtual",211);}
case 211:{f.StackOp("pop");f.Pc=212;continue;}
case 212:{f.Push(f.Locals[7]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[3]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[1]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",219);}
case 219:{f.Push(f.Locals[3]);f.Pc=220;continue;}
case 220:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventTokenCreated"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventTokenCreated")));f.Pc=223;continue;}
case 223:{f.StackOp("dup");f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/event/GameEventTokenCreated","<init>","()V","invokespecial",227);}
case 227:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",230);}
case 230:{f.Push(f.Locals[8]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","isTrue","()Z","invokevirtual",235);}
case 235:{f.Pc=f.Pop().Int==0?253:238;continue;}
case 238:{f.Push(f.Locals[3]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",242);}
case 242:{f.Push(f.Locals[3]);f.Pc=243;continue;}
case 243:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=246;continue;}
case 246:{f.StackOp("dup");f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",250);}
case 250:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",253);}
case 253:{f.Push(f.Locals[4]);f.Pc=255;continue;}
case 255:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",261);}
case 261:{f.Push(JValue.R(rt.String("Army")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",266);}
case 266:{f.Locals[7]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[7]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",275);}
case 275:{f.Pc=f.Pop().Int==0?279:278;continue;}
case 278:{return JStep.ReturnVoid;}
case 279:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",282);}
case 282:{f.Locals[8]=f.Pop();f.Pc=284;continue;}
case 284:{f.Push(f.Locals[8]);f.Pc=286;continue;}
case 286:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=288;continue;}
case 288:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"));f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",296);}
case 296:{f.StackOp("pop");f.Pc=297;continue;}
case 297:{f.Push(f.Locals[8]);f.Pc=299;continue;}
case 299:{f.Push(JValue.R(rt.String("Amount")));f.Pc=301;continue;}
case 301:{f.Push(f.Locals[5]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",306);}
case 306:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",311);}
case 311:{f.StackOp("pop");f.Pc=312;continue;}
case 312:{f.Push(f.Locals[4]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",317);}
case 317:{f.Push(f.Locals[7]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[1]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",323);}
case 323:{f.Push(JValue.R(rt.String("lblChooseAnArmy")));f.Pc=325;continue;}
case 325:{f.Push(JValue.I(0));f.Pc=326;continue;}
case 326:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",332);}
case 332:{f.Push(JValue.I(0));f.Pc=333;continue;}
case 333:{f.Push(f.Locals[8]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",338);}
case 338:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=341;continue;}
case 341:{f.Locals[9]=f.Pop();f.Pc=343;continue;}
case 343:{f.Push(f.Locals[1]);f.Pc=344;continue;}
case 344:{f.Push(JValue.R(rt.String("RememberAmass")));f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",349);}
case 349:{f.Pc=f.Pop().Int==0?358:352;continue;}
case 352:{f.Push(f.Locals[2]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[9]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",358);}
case 358:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=361;continue;}
case 361:{f.StackOp("dup");f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",365);}
case 365:{f.Locals[10]=f.Pop();f.Pc=367;continue;}
case 367:{f.Push(f.Locals[9]);f.Pc=369;continue;}
case 369:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"));f.Pc=372;continue;}
case 372:{f.Push(f.Locals[5]);f.Pc=374;continue;}
case 374:{f.Push(f.Locals[4]);f.Pc=376;continue;}
case 376:{f.Push(f.Locals[10]);f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",381);}
case 381:{f.Push(f.Locals[10]);f.Pc=383;continue;}
case 383:{f.Push(f.Locals[3]);f.Pc=384;continue;}
case 384:{f.Push(f.Locals[1]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",388);}
case 388:{f.Push(f.Locals[9]);f.Pc=390;continue;}
case 390:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",393);}
case 393:{f.Push(f.Locals[6]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/card/CardTypeView","hasCreatureType","(Ljava/lang/String;)Z","invokeinterface",400);}
case 400:{f.Pc=f.Pop().Int!=0?471:403;continue;}
case 403:{f.Push(f.Locals[1]);f.Pc=404;continue;}
case 404:{f.Push(f.Locals[4]);f.Pc=406;continue;}
case 406:{f.Push(JValue.R(rt.String("Amass Effect")));f.Pc=409;continue;}
case 409:{f.Push(f.Locals[2]);f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",413);}
case 413:{return rt.Call(f,"forge/game/ability/effects/AmassEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",416);}
case 416:{f.Locals[11]=f.Pop();f.Pc=418;continue;}
case 418:{f.Push(f.Locals[11]);f.Pc=420;continue;}
case 420:{f.Push(JValue.I(0));f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/game/card/Card","setRenderForUI","(Z)V","invokevirtual",424);}
case 424:{f.Push(f.Locals[11]);f.Pc=426;continue;}
case 426:{f.Push(f.Locals[9]);f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",431);}
case 431:{f.Push(f.Locals[6]);f.Pc=433;continue;}
case 433:{return rt.DynamicCall(f,"forge/game/ability/effects/AmassEffect:3016:433:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",438);}
case 438:{f.Locals[12]=f.Pop();f.Pc=440;continue;}
case 440:{f.Push(f.Locals[11]);f.Pc=442;continue;}
case 442:{f.Push(f.Locals[12]);f.Pc=444;continue;}
case 444:{return rt.Call(f,"forge/game/card/Card","addStaticAbility","(Ljava/lang/String;)Lforge/game/staticability/StaticAbility;","invokevirtual",447);}
case 447:{f.StackOp("pop");f.Pc=448;continue;}
case 448:{f.Push(f.Locals[9]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[3]);f.Pc=451;continue;}
case 451:{f.Push(f.Locals[11]);f.Pc=453;continue;}
case 453:{return rt.DynamicCall(f,"forge/game/ability/effects/AmassEffect:3016:453:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",458);}
case 458:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",461);}
case 461:{f.Push(f.Locals[3]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",465);}
case 465:{f.Push(f.Locals[11]);f.Pc=467;continue;}
case 467:{f.Push(f.Locals[1]);f.Pc=468;continue;}
case 468:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",471);}
case 471:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3017(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",11);}
case 11:{switch(f.Pop().Int){case 520199269:f.Pc=28;break;default:f.Pc=40;break;}continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("lambda$resolve$f894d637$1")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Locals[2]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{switch(f.Pop().Int){case 0:f.Pc=60;break;default:f.Pc=156;break;}continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",64);}
case 64:{f.Push(JValue.I(6));f.Pc=66;continue;}
case 66:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?156:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?156:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Push(JValue.R(rt.String("run")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?156:95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Push(JValue.R(rt.String("()V")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?156:108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",112);}
case 112:{f.Push(JValue.R(rt.String("forge/game/ability/effects/AmassEffect")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int==0?156:121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",125);}
case 125:{f.Push(JValue.R(rt.String("(Lforge/game/Game;Lforge/game/card/Card;)V")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?156:134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/Game"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(JValue.I(1));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",147);}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{return rt.DynamicCall(f,"forge/game/ability/effects/AmassEffect:3017:150:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",155);}
case 155:{return JStep.Return(f.Pop());}
case 156:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=159;continue;}
case 159:{f.StackOp("dup");f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("Invalid lambda deserialization")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",166);}
case 166:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3018(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameAction","exileEffect","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C298{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/EmpowerEffect","forge/game/ability/effects/TokenEffectBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3376,"forge/game/ability/effects/EmpowerEffect","<init>","()V",1,1,1,new JHandler[]{},M3376));
c.Add(new JMethod(3377,"forge/game/ability/effects/EmpowerEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,4,new JHandler[]{},M3377));
c.Add(new JMethod(3378,"forge/game/ability/effects/EmpowerEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,11,6,new JHandler[]{},M3378));
}

internal static JStep M3376(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3377(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Empower ")));f.Pc=6;continue;}
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
case 41:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",44);}
case 44:{f.Push(JValue.R(rt.String(" ")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",49);}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",54);}
case 54:{f.Push(JValue.R(rt.String(" (Put ")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("+1/+1 counter")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",68);}
case 68:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String(" on a ")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",78);}
case 78:{f.Push(f.Locals[5]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",83);}
case 83:{f.Push(JValue.R(rt.String(" token you control.")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String(" If you don't control one, first create a blue ")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",95);}
case 95:{f.Push(f.Locals[5]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",100);}
case 100:{f.Push(JValue.R(rt.String(" planeswalker token with \"-1: Surveil 1.\" and \"-3: Draw a card.\")")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",105);}
case 105:{f.StackOp("pop");f.Pc=106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",110);}
case 110:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3378(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/ability/effects/EmpowerEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",14);}
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
case 59:{f.Push(f.Locals[6]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/CardPredicates","isType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",64);}
case 64:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","TOKEN","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","TOKEN","Ljava/util/function/Predicate;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",72);}
case 72:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int!=0?241:80;continue;}
case 80:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",87);}
case 87:{f.Locals[7]=f.Pop();f.Pc=89;continue;}
case 89:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/mutable/MutableBoolean"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/mutable/MutableBoolean")));f.Pc=92;continue;}
case 92:{f.StackOp("dup");f.Pc=93;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","<init>","(Z)V","invokespecial",97);}
case 97:{f.Locals[8]=f.Pop();f.Pc=99;continue;}
case 99:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=102;continue;}
case 102:{f.StackOp("dup");f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("u_empower_")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",108);}
case 108:{f.Locals[9]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[9]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.String("Type")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",118);}
case 118:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",121);}
case 121:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Push(f.Locals[9]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",130);}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[4]);f.Pc=133;continue;}
case 133:{f.Push(JValue.I(0));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/card/token/TokenInfo","getProtoType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Lforge/game/card/Card;","invokestatic",137);}
case 137:{f.Locals[10]=f.Pop();f.Pc=139;continue;}
case 139:{f.Push(f.Locals[10]);f.Pc=141;continue;}
case 141:{f.Pc=f.Pop().Reference!=null?155:144;continue;}
case 144:{f.Push(JValue.R(rt.String("u_empower")));f.Pc=146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[4]);f.Pc=149;continue;}
case 149:{f.Push(JValue.I(0));f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/token/TokenInfo","getProtoType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Lforge/game/card/Card;","invokestatic",153);}
case 153:{f.Locals[10]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[10]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[6]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/card/Card","addType","(Ljava/lang/String;)V","invokevirtual",162);}
case 162:{f.Push(f.Locals[10]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[6]);f.Pc=166;continue;}
case 166:{return rt.DynamicCall(f,"forge/game/ability/effects/EmpowerEffect:3378:166:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",171);}
case 171:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",174);}
case 174:{f.Push(f.Locals[10]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/card/Card","setTokenSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",180);}
case 180:{f.Push(f.Locals[0]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[4]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[10]);f.Pc=186;continue;}
case 186:{f.Push(JValue.I(1));f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/ability/effects/EmpowerEffect","makeTokenTableInternal","(Lforge/game/player/Player;Lforge/game/card/Card;I)Lforge/game/card/TokenCreateTable;","invokevirtual",190);}
case 190:{f.Push(JValue.I(0));f.Pc=191;continue;}
case 191:{f.Push(f.Locals[7]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[8]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[1]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/ability/effects/EmpowerEffect","makeTokenTable","(Lforge/game/card/TokenCreateTable;ZLforge/game/card/CardZoneTable;Lorg/apache/commons/lang3/mutable/MutableBoolean;Lforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;","invokevirtual",199);}
case 199:{f.StackOp("pop");f.Pc=200;continue;}
case 200:{f.Push(f.Locals[7]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[3]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",207);}
case 207:{f.Push(f.Locals[3]);f.Pc=208;continue;}
case 208:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventTokenCreated"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventTokenCreated")));f.Pc=211;continue;}
case 211:{f.StackOp("dup");f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/event/GameEventTokenCreated","<init>","()V","invokespecial",215);}
case 215:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",218);}
case 218:{f.Push(f.Locals[8]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","isTrue","()Z","invokevirtual",223);}
case 223:{f.Pc=f.Pop().Int==0?241:226;continue;}
case 226:{f.Push(f.Locals[3]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",230);}
case 230:{f.Push(f.Locals[3]);f.Pc=231;continue;}
case 231:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=234;continue;}
case 234:{f.StackOp("dup");f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",238);}
case 238:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",241);}
case 241:{f.Push(f.Locals[4]);f.Pc=243;continue;}
case 243:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",249);}
case 249:{f.Push(f.Locals[6]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/card/CardPredicates","isType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",254);}
case 254:{if(!rt.StaticReady(f,"forge/game/card/CardPredicates","TOKEN","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPredicates","TOKEN","Ljava/util/function/Predicate;"));f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",262);}
case 262:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",265);}
case 265:{f.Locals[7]=f.Pop();f.Pc=267;continue;}
case 267:{f.Push(f.Locals[7]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",274);}
case 274:{f.Pc=f.Pop().Int==0?278:277;continue;}
case 277:{return JStep.ReturnVoid;}
case 278:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",281);}
case 281:{f.Locals[8]=f.Pop();f.Pc=283;continue;}
case 283:{f.Push(f.Locals[8]);f.Pc=285;continue;}
case 285:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=287;continue;}
case 287:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=290;continue;}
case 290:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",295);}
case 295:{f.StackOp("pop");f.Pc=296;continue;}
case 296:{f.Push(f.Locals[8]);f.Pc=298;continue;}
case 298:{f.Push(JValue.R(rt.String("Amount")));f.Pc=300;continue;}
case 300:{f.Push(f.Locals[5]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",305);}
case 305:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",310);}
case 310:{f.StackOp("pop");f.Pc=311;continue;}
case 311:{f.Push(f.Locals[4]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",316);}
case 316:{f.Push(f.Locals[7]);f.Pc=318;continue;}
case 318:{f.Push(f.Locals[1]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",322);}
case 322:{f.Push(JValue.R(rt.String("lblChooseaCard")));f.Pc=324;continue;}
case 324:{f.Push(JValue.I(0));f.Pc=325;continue;}
case 325:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",331);}
case 331:{f.Push(JValue.I(0));f.Pc=332;continue;}
case 332:{f.Push(f.Locals[8]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",337);}
case 337:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=340;continue;}
case 340:{f.Locals[9]=f.Pop();f.Pc=342;continue;}
case 342:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=345;continue;}
case 345:{f.StackOp("dup");f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",349);}
case 349:{f.Locals[10]=f.Pop();f.Pc=351;continue;}
case 351:{f.Push(f.Locals[9]);f.Pc=353;continue;}
case 353:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=356;continue;}
case 356:{f.Push(f.Locals[5]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[4]);f.Pc=360;continue;}
case 360:{f.Push(f.Locals[10]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",365);}
case 365:{f.Push(f.Locals[10]);f.Pc=367;continue;}
case 367:{f.Push(f.Locals[3]);f.Pc=368;continue;}
case 368:{f.Push(f.Locals[1]);f.Pc=369;continue;}
case 369:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",372);}
case 372:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

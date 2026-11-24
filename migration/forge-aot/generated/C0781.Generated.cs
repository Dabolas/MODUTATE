// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C781{
internal static JClass Build(){var c=new JClass("forge/game/replacement/ReplacementHandler","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("hasRun","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("replaceDamageList","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(9026,"forge/game/replacement/ReplacementHandler","<init>","(Lforge/game/Game;)V",1,2,3,new JHandler[]{},M9026));
c.Add(new JMethod(9027,"forge/game/replacement/ReplacementHandler","getReplacementList","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;)Ljava/util/List;",1,12,7,new JHandler[]{},M9027));
c.Add(new JMethod(9028,"forge/game/replacement/ReplacementHandler","collectReplacer","(Lforge/game/replacement/ReplacementEffect;Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;Lforge/game/zone/Zone;Ljava/util/List;)Z",2,7,3,new JHandler[]{},M9028));
c.Add(new JMethod(9029,"forge/game/replacement/ReplacementHandler","cantHappenCheck","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Z",1,3,4,new JHandler[]{},M9029));
c.Add(new JMethod(9030,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;",1,10,5,new JHandler[]{},M9030));
c.Add(new JMethod(9031,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;Lforge/game/player/Player;)Lforge/game/replacement/ReplacementResult;",2,11,5,new JHandler[]{},M9031));
c.Add(new JMethod(9032,"forge/game/replacement/ReplacementHandler","executeReplacement","(Ljava/util/Map;Lforge/game/replacement/ReplacementEffect;Lforge/game/player/Player;)Lforge/game/replacement/ReplacementResult;",2,12,7,new JHandler[]{},M9032));
c.Add(new JMethod(9033,"forge/game/replacement/ReplacementHandler","getPossibleReplaceDamageList","(Lforge/game/player/PlayerCollection;ZLforge/game/card/CardDamageTable;Lforge/game/spellability/SpellAbility;)V",2,20,4,new JHandler[]{},M9033));
c.Add(new JMethod(9034,"forge/game/replacement/ReplacementHandler","runSingleReplaceDamageEffect","(Lforge/game/replacement/ReplacementEffect;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Lforge/game/player/Player;Lforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;)V",2,24,5,new JHandler[]{},M9034));
c.Add(new JMethod(9035,"forge/game/replacement/ReplacementHandler","executeReplaceDamageBufferedSA","(Ljava/util/Map;)V",2,23,4,new JHandler[]{},M9035));
c.Add(new JMethod(9036,"forge/game/replacement/ReplacementHandler","runReplaceDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V",1,28,8,new JHandler[]{},M9036));
c.Add(new JMethod(9037,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;",9,3,4,new JHandler[]{},M9037));
c.Add(new JMethod(9038,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;",9,4,4,new JHandler[]{},M9038));
c.Add(new JMethod(9039,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/util/Map;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;",10,7,4,new JHandler[]{},M9039));
c.Add(new JMethod(9040,"forge/game/replacement/ReplacementHandler","wouldPhaseBeSkipped","(Lforge/game/player/Player;Lforge/game/phase/PhaseType;)Z",1,5,4,new JHandler[]{},M9040));
c.Add(new JMethod(9041,"forge/game/replacement/ReplacementHandler","wouldExtraTurnBeSkipped","(Lforge/game/player/Player;)Z",1,4,4,new JHandler[]{},M9041));
c.Add(new JMethod(9042,"forge/game/replacement/ReplacementHandler","getTotalPreventionShieldAmount","(Lforge/game/GameEntity;)I",1,8,6,new JHandler[]{},M9042));
c.Add(new JMethod(9043,"forge/game/replacement/ReplacementHandler","isPreventCombatDamageThisTurn","()Z",17,5,3,new JHandler[]{},M9043));
c.Add(new JMethod(9044,"forge/game/replacement/ReplacementHandler","isReplacing","()Z",1,1,1,new JHandler[]{},M9044));
c.Add(new JMethod(9045,"forge/game/replacement/ReplacementHandler","lambda$getReplacementList$0","(Lforge/game/card/CardCollection;Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;Ljava/util/List;Lforge/game/card/Card;)Z",4098,15,7,new JHandler[]{},M9045));
}

internal static JStep M9026(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementHandler","hasRun","Ljava/util/Set;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementHandler","replaceDamageList","Ljava/util/List;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;",value);f.Pc=27;continue;}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9027(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/replacement/ReplacementType","equals","(Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?32:10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",22);}
case 22:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Pc=f.Pop().Int==0?50:40;continue;}
case 40:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",47);}
case 47:{f.Pc=51;continue;}
case 50:{f.Push(JValue.R(null));f.Pc=51;continue;}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(JValue.R(null));f.Pc=54;continue;}
case 54:{f.Locals[6]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(JValue.R(null));f.Pc=57;continue;}
case 57:{f.Locals[7]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Int==0?285:64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementEffect","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementEffect","Lforge/game/ability/AbilityKey;"));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",73);}
case 73:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=76;continue;}
case 76:{f.Locals[8]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[8]);f.Pc=80;continue;}
case 80:{f.Pc=f.Pop().Reference==null?128:83;continue;}
case 83:{f.Push(f.Locals[8]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOtherChoices","()Ljava/util/List;","invokevirtual",88);}
case 88:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",93);}
case 93:{f.Pc=f.Pop().Int!=0?128:96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[8]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMode","()Lforge/game/replacement/ReplacementType;","invokevirtual",104);}
case 104:{return rt.Call(f,"forge/game/replacement/ReplacementType","equals","(Ljava/lang/Object;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?128:110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[8]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getLayer","()Lforge/game/replacement/ReplacementLayer;","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/game/replacement/ReplacementLayer","equals","(Ljava/lang/Object;)Z","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Int==0?128:122;continue;}
case 122:{f.Push(f.Locals[8]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOtherChoices","()Ljava/util/List;","invokevirtual",127);}
case 127:{return JStep.Return(f.Pop());}
case 128:{f.Push(f.Locals[2]);f.Pc=129;continue;}
case 129:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",137);}
case 137:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=140;continue;}
case 140:{f.Locals[7]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(f.Locals[7]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/card/Card","getReplacementEffects","()Lforge/util/collect/FCollectionView;","invokevirtual",147);}
case 147:{f.StackOp("pop");f.Pc=148;continue;}
case 148:{f.Push(f.Locals[7]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",153);}
case 153:{f.Locals[6]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[6]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[7]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",162);}
case 162:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",168);}
case 168:{return rt.Call(f,"forge/game/card/Card","setLastKnownZone","(Lforge/game/zone/Zone;)V","invokevirtual",171);}
case 171:{f.Push(f.Locals[2]);f.Pc=172;continue;}
case 172:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterMap","Lforge/game/ability/AbilityKey;"));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",180);}
case 180:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=183;continue;}
case 183:{f.Locals[9]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[6]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[9]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[2]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/card/Card","putEtbCounters","(Ljava/util/Map;Ljava/util/Map;)V","invokevirtual",193);}
case 193:{f.Push(f.Locals[5]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[6]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",200);}
case 200:{f.StackOp("pop");f.Pc=201;continue;}
case 201:{f.Push(JValue.R(null));f.Pc=202;continue;}
case 202:{f.Locals[10]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[2]);f.Pc=205;continue;}
case 205:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"));f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",213);}
case 213:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardZoneTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=216;continue;}
case 216:{f.Locals[11]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[11]);f.Pc=220;continue;}
case 220:{f.Pc=f.Pop().Reference==null?255:223;continue;}
case 223:{f.Push(f.Locals[11]);f.Pc=225;continue;}
case 225:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/card/CardZoneTable","containsColumn","(Ljava/lang/Object;)Z","invokevirtual",231);}
case 231:{f.Pc=f.Pop().Int==0?255:234;continue;}
case 234:{f.Push(f.Locals[11]);f.Pc=236;continue;}
case 236:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/card/CardZoneTable","column","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",242);}
case 242:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",247);}
case 247:{return rt.Call(f,"com/google/common/collect/Iterables","concat","(Ljava/lang/Iterable;)Ljava/lang/Iterable;","invokestatic",250);}
case 250:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","(Ljava/lang/Iterable;)Ljava/util/HashSet;","invokestatic",253);}
case 253:{f.Locals[10]=f.Pop();f.Pc=255;continue;}
case 255:{f.Push(f.Locals[0]);f.Pc=256;continue;}
case 256:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",262);}
case 262:{f.Push(JValue.I(0));f.Pc=263;continue;}
case 263:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",266);}
case 266:{f.Push(f.Locals[5]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[10]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;Ljava/util/Set;)V","invokevirtual",273);}
case 273:{f.Push(f.Locals[2]);f.Pc=274;continue;}
case 274:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=277;continue;}
case 277:{f.Push(f.Locals[6]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",284);}
case 284:{f.StackOp("pop");f.Pc=285;continue;}
case 285:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",288);}
case 288:{f.Locals[8]=f.Pop();f.Pc=290;continue;}
case 290:{f.Push(f.Locals[0]);f.Pc=291;continue;}
case 291:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=294;continue;}
case 294:{f.Push(f.Locals[0]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[5]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[1]);f.Pc=298;continue;}
case 298:{f.Push(f.Locals[2]);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[3]);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[8]);f.Pc=302;continue;}
case 302:{return rt.DynamicCall(f,"forge/game/replacement/ReplacementHandler:9027:302:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/replacement/ReplacementHandler;Lforge/game/card/CardCollection;Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;Ljava/util/List;)Lforge/util/Visitor;",307);}
case 307:{f.Push(f.Locals[7]);f.Pc=309;continue;}
case 309:{f.Pc=f.Pop().Reference==null?327:312;continue;}
case 312:{f.Push(f.Locals[7]);f.Pc=314;continue;}
case 314:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",320);}
case 320:{f.Pc=f.Pop().Int==0?327:323;continue;}
case 323:{f.Push(JValue.I(1));f.Pc=324;continue;}
case 324:{f.Pc=328;continue;}
case 327:{f.Push(JValue.I(0));f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/Game","forEachCardInGame","(Lforge/util/Visitor;Z)V","invokevirtual",331);}
case 331:{f.Push(f.Locals[6]);f.Pc=333;continue;}
case 333:{f.Pc=f.Pop().Reference==null?471:336;continue;}
case 336:{f.Push(f.Locals[6]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/game/card/Card","getReplacementEffects","()Lforge/util/collect/FCollectionView;","invokevirtual",341);}
case 341:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",346);}
case 346:{f.Locals[9]=f.Pop();f.Pc=348;continue;}
case 348:{f.Push(f.Locals[9]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",355);}
case 355:{f.Pc=f.Pop().Int==0?380:358;continue;}
case 358:{f.Push(f.Locals[9]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",365);}
case 365:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=368;continue;}
case 368:{f.Locals[10]=f.Pop();f.Pc=370;continue;}
case 370:{f.Push(f.Locals[10]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[7]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",377);}
case 377:{f.Pc=348;continue;}
case 380:{f.Push(f.Locals[7]);f.Pc=382;continue;}
case 382:{f.Push(f.Locals[6]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/game/card/Card","getStoredKeywords","()Ljava/util/Map;","invokevirtual",387);}
case 387:{f.Push(JValue.I(1));f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/card/Card","setStoredKeywords","(Ljava/util/Map;Z)V","invokevirtual",391);}
case 391:{f.Push(f.Locals[7]);f.Pc=393;continue;}
case 393:{f.Push(f.Locals[6]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/card/Card","getStoredReplacements","()Lcom/google/common/collect/Table;","invokevirtual",398);}
case 398:{return rt.Call(f,"forge/game/card/Card","setStoredReplacements","(Lcom/google/common/collect/Table;)V","invokevirtual",401);}
case 401:{f.Push(f.Locals[7]);f.Pc=403;continue;}
case 403:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",406);}
case 406:{f.Pc=f.Pop().Reference==null?433:409;continue;}
case 409:{f.Push(f.Locals[7]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",414);}
case 414:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",417);}
case 417:{f.Pc=f.Pop().Reference==null?433:420;continue;}
case 420:{f.Push(f.Locals[7]);f.Pc=422;continue;}
case 422:{f.Push(f.Locals[7]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",427);}
case 427:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",430);}
case 430:{return rt.Call(f,"forge/game/card/Card","addKeywordForStaticAbility","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",433);}
case 433:{f.Push(f.Locals[2]);f.Pc=434;continue;}
case 434:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=437;continue;}
case 437:{f.Push(f.Locals[7]);f.Pc=439;continue;}
case 439:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",444);}
case 444:{f.StackOp("pop");f.Pc=445;continue;}
case 445:{f.Push(f.Locals[2]);f.Pc=446;continue;}
case 446:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","NewCard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","NewCard","Lforge/game/ability/AbilityKey;"));f.Pc=449;continue;}
case 449:{f.Push(f.Locals[6]);f.Pc=451;continue;}
case 451:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",454);}
case 454:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",459);}
case 459:{f.StackOp("pop");f.Pc=460;continue;}
case 460:{f.Push(f.Locals[0]);f.Pc=461;continue;}
case 461:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",467);}
case 467:{f.Push(JValue.I(0));f.Pc=468;continue;}
case 468:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(Z)V","invokevirtual",471);}
case 471:{f.Push(f.Locals[8]);f.Pc=473;continue;}
case 473:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9028(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasRun","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?113:7;continue;}
case 7:{f.Push(f.Locals[4]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?21:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getLayer","()Lforge/game/replacement/ReplacementLayer;","invokevirtual",16);}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?113:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","modeCheck","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?113:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","hasRun","Ljava/util/Set;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",39);}
case 39:{f.Pc=f.Pop().Int!=0?55:42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","hasRun","Ljava/util/Set;"));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",52);}
case 52:{f.Pc=f.Pop().Int!=0?113:55;continue;}
case 55:{f.Push(f.Locals[6]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",63);}
case 63:{f.Pc=f.Pop().Int!=0?113:66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","zonesCheck","(Lforge/game/zone/Zone;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?113:75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","requirementsCheck","(Lforge/game/Game;)Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int==0?113:86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","canReplace","(Ljava/util/Map;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?113:94;continue;}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",102);}
case 102:{f.StackOp("pop");f.Pc=103;continue;}
case 103:{f.Push(f.Locals[4]);f.Pc=105;continue;}
case 105:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","CantHappen","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","CantHappen","Lforge/game/replacement/ReplacementLayer;"));f.Pc=108;continue;}
case 108:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?113:111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 113:{f.Push(JValue.I(1));f.Pc=114;continue;}
case 114:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9029(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","CantHappen","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","CantHappen","Lforge/game/replacement/ReplacementLayer;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","getReplacementList","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;)Ljava/util/List;","invokevirtual",9);}
case 9:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int!=0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9030(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Int==0?29:20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=24;continue;}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Pc=38;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",36);}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/replacement/ReplacementLayer","values","()[Lforge/game/replacement/ReplacementLayer;","invokestatic",41);}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=46;continue;}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{f.Locals[7]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[7]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?94:58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[7]);f.Pc=62;continue;}
case 62:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=63;continue;}
case 63:{f.Locals[8]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[8]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;Lforge/game/player/Player;)Lforge/game/replacement/ReplacementResult;","invokevirtual",75);}
case 75:{f.Locals[9]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[9]);f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=82;continue;}
case 82:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?88:85;continue;}
case 85:{f.Push(f.Locals[9]);f.Pc=87;continue;}
case 87:{return JStep.Return(f.Pop());}
case 88:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=91;continue;}
case 91:{f.Pc=51;continue;}
case 94:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=97;continue;}
case 97:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9031(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","getReplacementList","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;)Ljava/util/List;","invokevirtual",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[5]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?23:19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=22;continue;}
case 22:{return JStep.Return(f.Pop());}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","CantHappen","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","CantHappen","Lforge/game/replacement/ReplacementLayer;"));f.Pc=27;continue;}
case 27:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?46:30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[6]=f.Pop();f.Pc=43;continue;}
case 43:{f.Pc=58;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",51);}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleReplacementEffect","(Ljava/util/List;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",56);}
case 56:{f.Locals[6]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",67);}
case 67:{f.StackOp("pop");f.Pc=68;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{f.Push(JValue.I(1));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setHasRun","(Z)V","invokevirtual",74);}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","hasRun","Ljava/util/Set;"));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[6]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOtherChoices","(Ljava/util/List;)V","invokevirtual",93);}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[6]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","executeReplacement","(Ljava/util/Map;Lforge/game/replacement/ReplacementEffect;Lforge/game/player/Player;)Lforge/game/replacement/ReplacementResult;","invokevirtual",102);}
case 102:{f.Locals[7]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=109;continue;}
case 109:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?157:112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",119);}
case 119:{f.Pc=f.Pop().Int!=0?130:122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[2]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",128);}
case 128:{f.Locals[7]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[6]);f.Pc=132;continue;}
case 132:{f.Push(JValue.I(0));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setHasRun","(Z)V","invokevirtual",136);}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","hasRun","Ljava/util/Set;"));f.Pc=140;continue;}
case 140:{f.Push(f.Locals[6]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",147);}
case 147:{f.StackOp("pop");f.Pc=148;continue;}
case 148:{f.Push(f.Locals[6]);f.Pc=150;continue;}
case 150:{f.Push(JValue.R(null));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOtherChoices","(Ljava/util/List;)V","invokevirtual",154);}
case 154:{f.Push(f.Locals[7]);f.Pc=156;continue;}
case 156:{return JStep.Return(f.Pop());}
case 157:{f.Push(f.Locals[6]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getDescription","()Ljava/lang/String;","invokevirtual",162);}
case 162:{f.Locals[8]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[8]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",169);}
case 169:{f.Pc=f.Pop().Int!=0?191:172;continue;}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=176;continue;}
case 176:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=179;continue;}
case 179:{f.StackOp("dup");f.Pc=180;continue;}
case 180:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","EFFECT_REPLACED","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","EFFECT_REPLACED","Lforge/game/GameLogEntryType;"));f.Pc=183;continue;}
case 183:{f.Push(f.Locals[8]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",188);}
case 188:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",191);}
case 191:{f.Push(f.Locals[7]);f.Pc=193;continue;}
case 193:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=196;continue;}
case 196:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?328:199;continue;}
case 199:{f.Push(f.Locals[2]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","(Ljava/util/Map;)Ljava/util/EnumMap;","invokestatic",203);}
case 203:{f.Locals[9]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[9]);f.Pc=207;continue;}
case 207:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",215);}
case 215:{f.StackOp("pop");f.Pc=216;continue;}
case 216:{f.Push(f.Locals[9]);f.Pc=218;continue;}
case 218:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","EffectOnly","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","EffectOnly","Lforge/game/ability/AbilityKey;"));f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",226);}
case 226:{f.Pc=f.Pop().Int==0?244:229;continue;}
case 229:{f.Push(f.Locals[9]);f.Pc=231;continue;}
case 231:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","EffectOnly","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","EffectOnly","Lforge/game/ability/AbilityKey;"));f.Pc=234;continue;}
case 234:{f.Push(JValue.I(1));f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",238);}
case 238:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",243);}
case 243:{f.StackOp("pop");f.Pc=244;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{f.Push(f.Locals[1]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[9]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",251);}
case 251:{f.Locals[10]=f.Pop();f.Pc=253;continue;}
case 253:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementHandler$2","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementHandler$2","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=256;continue;}
case 256:{f.Push(f.Locals[10]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",261);}
case 261:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=262;continue;}
case 262:{switch(f.Pop().Int){case 1:f.Pc=288;break;case 2:f.Pc=288;break;default:f.Pc=312;break;}continue;}
case 288:{f.Push(f.Locals[2]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[9]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",296);}
case 296:{f.Push(f.Locals[2]);f.Pc=297;continue;}
case 297:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=300;continue;}
case 300:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",308);}
case 308:{f.StackOp("pop");f.Pc=309;continue;}
case 309:{f.Pc=328;continue;}
case 312:{f.Push(f.Locals[10]);f.Pc=314;continue;}
case 314:{f.Locals[7]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[2]);f.Pc=317;continue;}
case 317:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=320;continue;}
case 320:{f.Push(f.Locals[10]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",327);}
case 327:{f.StackOp("pop");f.Pc=328;continue;}
case 328:{f.Push(f.Locals[6]);f.Pc=330;continue;}
case 330:{f.Push(JValue.I(0));f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setHasRun","(Z)V","invokevirtual",334);}
case 334:{f.Push(f.Locals[0]);f.Pc=335;continue;}
case 335:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","hasRun","Ljava/util/Set;"));f.Pc=338;continue;}
case 338:{f.Push(f.Locals[6]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/util/Set","remove","(Ljava/lang/Object;)Z","invokeinterface",345);}
case 345:{f.StackOp("pop");f.Pc=346;continue;}
case 346:{f.Push(f.Locals[6]);f.Pc=348;continue;}
case 348:{f.Push(JValue.R(null));f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOtherChoices","(Ljava/util/List;)V","invokevirtual",352);}
case 352:{f.Push(f.Locals[7]);f.Pc=354;continue;}
case 354:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9032(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","hasAlternateState","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?22:14;continue;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?33:22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","ensureAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",37);}
case 37:{f.Locals[5]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Reference==null?176:44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[6]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setReplacingObjects","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V","invokevirtual",55);}
case 55:{f.Push(f.Locals[6]);f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OriginalParams","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OriginalParams","Lforge/game/ability/AbilityKey;"));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",64);}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(2));f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=71;continue;}
case 71:{f.StackOp("dup");f.Pc=72;continue;}
case 72:{f.Push(JValue.I(0));f.Pc=73;continue;}
case 73:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"));f.Pc=76;continue;}
case 76:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{f.Push(JValue.I(1));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObjectsFrom","(Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokevirtual",86);}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",91);}
case 91:{f.Locals[6]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[6]);f.Pc=95;continue;}
case 95:{f.Pc=f.Pop().Reference!=null?48:98;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",109);}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",116);}
case 116:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",119);}
case 119:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/spellability/SpellAbility","setLastStateBattlefield","(Lforge/game/card/CardCollectionView;)V","invokevirtual",125);}
case 125:{f.Push(f.Locals[5]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",136);}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",143);}
case 143:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",146);}
case 146:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/spellability/SpellAbility","setLastStateGraveyard","(Lforge/game/card/CardCollectionView;)V","invokevirtual",152);}
case 152:{f.Push(f.Locals[2]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","isIntrinsic","()Z","invokevirtual",156);}
case 156:{f.Pc=f.Pop().Int==0?170:159;continue;}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{f.Push(JValue.I(1));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",165);}
case 165:{f.Push(f.Locals[5]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/spellability/SpellAbility","changeText","()V","invokevirtual",170);}
case 170:{f.Push(f.Locals[5]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[2]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)V","invokevirtual",176);}
case 176:{f.Push(f.Locals[2]);f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String("Optional")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",183);}
case 183:{f.Pc=f.Pop().Int==0?384:186;continue;}
case 186:{f.Push(f.Locals[3]);f.Pc=187;continue;}
case 187:{f.Locals[6]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[2]);f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("OptionalDecider")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",196);}
case 196:{f.Pc=f.Pop().Int==0?222:199;continue;}
case 199:{f.Push(f.Locals[4]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.String("OptionalDecider")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",208);}
case 208:{f.Push(f.Locals[5]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",213);}
case 213:{f.Push(JValue.I(0));f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",217);}
case 217:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=220;continue;}
case 220:{f.Locals[6]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[4]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/card/Card","getRenderForUI","()Z","invokevirtual",227);}
case 227:{f.Pc=f.Pop().Int==0?238:230;continue;}
case 230:{f.Push(f.Locals[4]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/card/Card","getCardForUi","()Lforge/game/card/Card;","invokevirtual",235);}
case 235:{f.Pc=239;continue;}
case 238:{f.Push(JValue.R(null));f.Pc=239;continue;}
case 239:{f.Push(f.Locals[4]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",244);}
case 244:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",250);}
case 250:{f.Locals[7]=f.Pop();f.Pc=252;continue;}
case 252:{f.Push(f.Locals[2]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getDescription","()Ljava/lang/String;","invokevirtual",256);}
case 256:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=259;continue;}
case 259:{f.Push(f.Locals[7]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",264);}
case 264:{f.Locals[8]=f.Pop();f.Pc=266;continue;}
case 266:{f.Push(f.Locals[1]);f.Pc=267;continue;}
case 267:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",275);}
case 275:{f.Pc=f.Pop().Int==0?319:278;continue;}
case 278:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",281);}
case 281:{f.Push(JValue.R(rt.String("lblApplyCardReplacementEffectToCardConfirm")));f.Pc=284;continue;}
case 284:{f.Push(JValue.I(3));f.Pc=285;continue;}
case 285:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=288;continue;}
case 288:{f.StackOp("dup");f.Pc=289;continue;}
case 289:{f.Push(JValue.I(0));f.Pc=290;continue;}
case 290:{f.Push(f.Locals[7]);f.Pc=292;continue;}
case 292:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=293;continue;}
case 293:{f.StackOp("dup");f.Pc=294;continue;}
case 294:{f.Push(JValue.I(1));f.Pc=295;continue;}
case 295:{f.Push(f.Locals[1]);f.Pc=296;continue;}
case 296:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",304);}
case 304:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",307);}
case 307:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=308;continue;}
case 308:{f.StackOp("dup");f.Pc=309;continue;}
case 309:{f.Push(JValue.I(2));f.Pc=310;continue;}
case 310:{f.Push(f.Locals[8]);f.Pc=312;continue;}
case 312:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",316);}
case 316:{f.Pc=342;continue;}
case 319:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",322);}
case 322:{f.Push(JValue.R(rt.String("lblApplyReplacementEffectOfCardConfirm")));f.Pc=325;continue;}
case 325:{f.Push(JValue.I(2));f.Pc=326;continue;}
case 326:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=329;continue;}
case 329:{f.StackOp("dup");f.Pc=330;continue;}
case 330:{f.Push(JValue.I(0));f.Pc=331;continue;}
case 331:{f.Push(f.Locals[7]);f.Pc=333;continue;}
case 333:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=334;continue;}
case 334:{f.StackOp("dup");f.Pc=335;continue;}
case 335:{f.Push(JValue.I(1));f.Pc=336;continue;}
case 336:{f.Push(f.Locals[8]);f.Pc=338;continue;}
case 338:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",342);}
case 342:{f.Locals[9]=f.Pop();f.Pc=344;continue;}
case 344:{f.Push(f.Locals[1]);f.Pc=345;continue;}
case 345:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=348;continue;}
case 348:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",353);}
case 353:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=356;continue;}
case 356:{f.Locals[10]=f.Pop();f.Pc=358;continue;}
case 358:{f.Push(f.Locals[6]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",363);}
case 363:{f.Push(f.Locals[2]);f.Pc=364;continue;}
case 364:{f.Push(f.Locals[5]);f.Pc=366;continue;}
case 366:{f.Push(f.Locals[10]);f.Pc=368;continue;}
case 368:{f.Push(f.Locals[9]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/player/PlayerController","confirmReplacementEffect","(Lforge/game/replacement/ReplacementEffect;Lforge/game/spellability/SpellAbility;Lforge/game/GameEntity;Ljava/lang/String;)Z","invokevirtual",373);}
case 373:{f.Locals[11]=f.Pop();f.Pc=375;continue;}
case 375:{f.Push(f.Locals[11]);f.Pc=377;continue;}
case 377:{f.Pc=f.Pop().Int!=0?384:380;continue;}
case 380:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=383;continue;}
case 383:{return JStep.Return(f.Pop());}
case 384:{f.Push(JValue.R(rt.String("True")));f.Pc=387;continue;}
case 387:{f.Push(f.Locals[2]);f.Pc=388;continue;}
case 388:{f.Push(JValue.R(rt.String("Prevent")));f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",394);}
case 394:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",397);}
case 397:{f.Locals[6]=f.Pop();f.Pc=399;continue;}
case 399:{f.Push(f.Locals[6]);f.Pc=401;continue;}
case 401:{f.Pc=f.Pop().Int!=0?414:404;continue;}
case 404:{f.Push(f.Locals[2]);f.Pc=405;continue;}
case 405:{f.Push(JValue.R(rt.String("PreventionEffect")));f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",411);}
case 411:{f.Pc=f.Pop().Int==0?491:414;continue;}
case 414:{if(!rt.StaticReady(f,"java/lang/Boolean","TRUE","Ljava/lang/Boolean;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","TRUE","Ljava/lang/Boolean;"));f.Pc=417;continue;}
case 417:{f.Push(f.Locals[1]);f.Pc=418;continue;}
case 418:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","NoPreventDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","NoPreventDamage","Lforge/game/ability/AbilityKey;"));f.Pc=421;continue;}
case 421:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",426);}
case 426:{return rt.Call(f,"java/lang/Boolean","equals","(Ljava/lang/Object;)Z","invokevirtual",429);}
case 429:{f.Pc=f.Pop().Int==0?482:432;continue;}
case 432:{f.Push(f.Locals[2]);f.Pc=433;continue;}
case 433:{f.Push(JValue.R(rt.String("AlwaysReplace")));f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",439);}
case 439:{f.Pc=f.Pop().Int==0?464:442;continue;}
case 442:{f.Push(f.Locals[1]);f.Pc=443;continue;}
case 443:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","PreventedAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","PreventedAmount","Lforge/game/ability/AbilityKey;"));f.Pc=446;continue;}
case 446:{f.Push(f.Locals[1]);f.Pc=447;continue;}
case 447:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=450;continue;}
case 450:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",455);}
case 455:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",460);}
case 460:{f.StackOp("pop");f.Pc=461;continue;}
case 461:{f.Pc=478;continue;}
case 464:{f.Push(f.Locals[1]);f.Pc=465;continue;}
case 465:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","PreventedAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","PreventedAmount","Lforge/game/ability/AbilityKey;"));f.Pc=468;continue;}
case 468:{f.Push(JValue.I(0));f.Pc=469;continue;}
case 469:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",472);}
case 472:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",477);}
case 477:{f.StackOp("pop");f.Pc=478;continue;}
case 478:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=481;continue;}
case 481:{return JStep.Return(f.Pop());}
case 482:{f.Push(f.Locals[6]);f.Pc=484;continue;}
case 484:{f.Pc=f.Pop().Int==0?491:487;continue;}
case 487:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Prevented","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Prevented","Lforge/game/replacement/ReplacementResult;"));f.Pc=490;continue;}
case 490:{return JStep.Return(f.Pop());}
case 491:{f.Push(JValue.R(rt.String("True")));f.Pc=494;continue;}
case 494:{f.Push(f.Locals[2]);f.Pc=495;continue;}
case 495:{f.Push(JValue.R(rt.String("Skip")));f.Pc=498;continue;}
case 498:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",501);}
case 501:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",504);}
case 504:{f.Pc=f.Pop().Int==0?511:507;continue;}
case 507:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Skipped","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Skipped","Lforge/game/replacement/ReplacementResult;"));f.Pc=510;continue;}
case 510:{return JStep.Return(f.Pop());}
case 511:{f.Push(f.Locals[4]);f.Pc=513;continue;}
case 513:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",516);}
case 516:{f.Locals[7]=f.Pop();f.Pc=518;continue;}
case 518:{f.Push(f.Locals[5]);f.Pc=520;continue;}
case 520:{f.Pc=f.Pop().Reference==null?638:523;continue;}
case 523:{f.Push(f.Locals[5]);f.Pc=525;continue;}
case 525:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",528);}
case 528:{f.Locals[8]=f.Pop();f.Pc=530;continue;}
case 530:{f.Push(f.Locals[2]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMode","()Lforge/game/replacement/ReplacementType;","invokevirtual",534);}
case 534:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"));f.Pc=537;continue;}
case 537:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?564:540;continue;}
case 540:{f.Push(f.Locals[8]);f.Pc=542;continue;}
case 542:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"));f.Pc=545;continue;}
case 545:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?564:548;continue;}
case 548:{f.Push(f.Locals[8]);f.Pc=550;continue;}
case 550:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"));f.Pc=553;continue;}
case 553:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?564:556;continue;}
case 556:{f.Push(f.Locals[8]);f.Pc=558;continue;}
case 558:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceEffect","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceEffect","Lforge/game/ability/ApiType;"));f.Pc=561;continue;}
case 561:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?588:564;continue;}
case 564:{f.Push(f.Locals[5]);f.Pc=566;continue;}
case 566:{f.Push(f.Locals[4]);f.Pc=568;continue;}
case 568:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",571);}
case 571:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",574);}
case 574:{f.Push(f.Locals[7]);f.Pc=576;continue;}
case 576:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",579);}
case 579:{f.Push(f.Locals[5]);f.Pc=581;continue;}
case 581:{f.Push(JValue.I(1));f.Pc=582;continue;}
case 582:{return rt.Call(f,"forge/game/player/PlayerController","playSpellAbilityNoStack","(Lforge/game/spellability/SpellAbility;Z)V","invokevirtual",585);}
case 585:{f.Pc=601;continue;}
case 588:{f.Push(f.Locals[1]);f.Pc=589;continue;}
case 589:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=592;continue;}
case 592:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Replaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Replaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=595;continue;}
case 595:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",600);}
case 600:{f.StackOp("pop");f.Pc=601;continue;}
case 601:{f.Push(f.Locals[8]);f.Pc=603;continue;}
case 603:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceToken","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceToken","Lforge/game/ability/ApiType;"));f.Pc=606;continue;}
case 606:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?625:609;continue;}
case 609:{f.Push(f.Locals[8]);f.Pc=611;continue;}
case 611:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceEffect","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceEffect","Lforge/game/ability/ApiType;"));f.Pc=614;continue;}
case 614:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?625:617;continue;}
case 617:{f.Push(f.Locals[8]);f.Pc=619;continue;}
case 619:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceMana","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceMana","Lforge/game/ability/ApiType;"));f.Pc=622;continue;}
case 622:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?638:625;continue;}
case 625:{f.Push(f.Locals[1]);f.Pc=626;continue;}
case 626:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=629;continue;}
case 629:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=632;continue;}
case 632:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",637);}
case 637:{f.StackOp("pop");f.Pc=638;continue;}
case 638:{f.Push(f.Locals[2]);f.Pc=639;continue;}
case 639:{f.Push(JValue.R(rt.String("ReplacementResult")));f.Pc=642;continue;}
case 642:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",645);}
case 645:{f.Pc=f.Pop().Int==0?659:648;continue;}
case 648:{f.Push(f.Locals[2]);f.Pc=649;continue;}
case 649:{f.Push(JValue.R(rt.String("ReplacementResult")));f.Pc=652;continue;}
case 652:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",655);}
case 655:{return rt.Call(f,"forge/game/replacement/ReplacementResult","valueOf","(Ljava/lang/String;)Lforge/game/replacement/ReplacementResult;","invokestatic",658);}
case 658:{return JStep.Return(f.Pop());}
case 659:{f.Push(f.Locals[1]);f.Pc=660;continue;}
case 660:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=663;continue;}
case 663:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",668);}
case 668:{f.Pc=f.Pop().Int==0?684:671;continue;}
case 671:{f.Push(f.Locals[1]);f.Pc=672;continue;}
case 672:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResult","Lforge/game/ability/AbilityKey;"));f.Pc=675;continue;}
case 675:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",680);}
case 680:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementResult"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=683;continue;}
case 683:{return JStep.Return(f.Pop());}
case 684:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Replaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Replaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=687;continue;}
case 687:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9033(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardDamageTable","columnMap","()Ljava/util/Map;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?414:26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[6]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",45);}
case 45:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=48;continue;}
case 48:{f.Locals[7]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[7]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=55;continue;}
case 55:{f.Pc=f.Pop().Int==0?70:58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",67);}
case 67:{f.Pc=82;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",79);}
case 79:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",82);}
case 82:{f.Locals[8]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[8]);f.Pc=86;continue;}
case 86:{f.Push(JValue.I(-1));f.Pc=87;continue;}
case 87:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?93:90;continue;}
case 90:{f.Pc=16;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","replaceDamageList","Ljava/util/List;"));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[8]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[9]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[6]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",116);}
case 116:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",124);}
case 124:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",129);}
case 129:{f.Locals[10]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[10]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",138);}
case 138:{f.Pc=f.Pop().Int==0?411:141;continue;}
case 141:{f.Push(f.Locals[10]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",148);}
case 148:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=151;continue;}
case 151:{f.Locals[11]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[11]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",160);}
case 160:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=163;continue;}
case 163:{f.Locals[12]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[11]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",172);}
case 172:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=175;continue;}
case 175:{f.Locals[13]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[13]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int<=0?408:185;continue;}
case 185:{f.Push(f.Locals[12]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[2]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/card/Card","canDamagePrevented","(Z)Z","invokevirtual",191);}
case 191:{f.Pc=f.Pop().Int==0?214:194;continue;}
case 194:{f.Push(f.Locals[4]);f.Pc=196;continue;}
case 196:{f.Pc=f.Pop().Reference==null?210:199;continue;}
case 199:{f.Push(f.Locals[4]);f.Pc=201;continue;}
case 201:{f.Push(JValue.R(rt.String("NoPrevention")));f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",207);}
case 207:{f.Pc=f.Pop().Int!=0?214:210;continue;}
case 210:{f.Push(JValue.I(1));f.Pc=211;continue;}
case 211:{f.Pc=215;continue;}
case 214:{f.Push(JValue.I(0));f.Pc=215;continue;}
case 215:{f.Locals[14]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[7]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",222);}
case 222:{f.Locals[15]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[15]);f.Pc=226;continue;}
case 226:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=229;continue;}
case 229:{f.Push(f.Locals[12]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",236);}
case 236:{f.StackOp("pop");f.Pc=237;continue;}
case 237:{f.Push(f.Locals[15]);f.Pc=239;continue;}
case 239:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=242;continue;}
case 242:{f.Push(f.Locals[13]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",249);}
case 249:{f.StackOp("pop");f.Pc=250;continue;}
case 250:{f.Push(f.Locals[15]);f.Pc=252;continue;}
case 252:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IsCombat","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IsCombat","Lforge/game/ability/AbilityKey;"));f.Pc=255;continue;}
case 255:{f.Push(f.Locals[2]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",259);}
case 259:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",264);}
case 264:{f.StackOp("pop");f.Pc=265;continue;}
case 265:{f.Push(f.Locals[15]);f.Pc=267;continue;}
case 267:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","NoPreventDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","NoPreventDamage","Lforge/game/ability/AbilityKey;"));f.Pc=270;continue;}
case 270:{f.Push(f.Locals[14]);f.Pc=272;continue;}
case 272:{f.Pc=f.Pop().Int!=0?279:275;continue;}
case 275:{f.Push(JValue.I(1));f.Pc=276;continue;}
case 276:{f.Pc=280;continue;}
case 279:{f.Push(JValue.I(0));f.Pc=280;continue;}
case 280:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",283);}
case 283:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",288);}
case 288:{f.StackOp("pop");f.Pc=289;continue;}
case 289:{f.Push(f.Locals[4]);f.Pc=291;continue;}
case 291:{f.Pc=f.Pop().Reference==null?307:294;continue;}
case 294:{f.Push(f.Locals[15]);f.Pc=296;continue;}
case 296:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=299;continue;}
case 299:{f.Push(f.Locals[4]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",306);}
case 306:{f.StackOp("pop");f.Pc=307;continue;}
case 307:{f.Push(f.Locals[0]);f.Pc=308;continue;}
case 308:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"));f.Pc=311;continue;}
case 311:{f.Push(f.Locals[15]);f.Pc=313;continue;}
case 313:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","getReplacementList","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;)Ljava/util/List;","invokevirtual",319);}
case 319:{f.Locals[16]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[16]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",328);}
case 328:{f.Locals[17]=f.Pop();f.Pc=330;continue;}
case 330:{f.Push(f.Locals[17]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",337);}
case 337:{f.Pc=f.Pop().Int==0?408:340;continue;}
case 340:{f.Push(f.Locals[17]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",347);}
case 347:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=350;continue;}
case 350:{f.Locals[18]=f.Pop();f.Pc=352;continue;}
case 352:{f.Push(f.Locals[9]);f.Pc=354;continue;}
case 354:{f.Push(f.Locals[18]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",361);}
case 361:{f.Pc=f.Pop().Int!=0?381:364;continue;}
case 364:{f.Push(f.Locals[9]);f.Pc=366;continue;}
case 366:{f.Push(f.Locals[18]);f.Pc=368;continue;}
case 368:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=371;continue;}
case 371:{f.StackOp("dup");f.Pc=372;continue;}
case 372:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",375);}
case 375:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",380);}
case 380:{f.StackOp("pop");f.Pc=381;continue;}
case 381:{f.Push(f.Locals[9]);f.Pc=383;continue;}
case 383:{f.Push(f.Locals[18]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",390);}
case 390:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=393;continue;}
case 393:{f.Locals[19]=f.Pop();f.Pc=395;continue;}
case 395:{f.Push(f.Locals[19]);f.Pc=397;continue;}
case 397:{f.Push(f.Locals[15]);f.Pc=399;continue;}
case 399:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",404);}
case 404:{f.StackOp("pop");f.Pc=405;continue;}
case 405:{f.Pc=330;continue;}
case 408:{f.Pc=131;continue;}
case 411:{f.Pc=16;continue;}
case 414:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9034(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[8]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Reference==null?30:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",27);}
case 27:{f.Pc=31;continue;}
case 30:{f.Push(JValue.R(null));f.Pc=31;continue;}
case 31:{f.Locals[9]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[10]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Locals[11]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",76);}
case 76:{f.Locals[12]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMapParams","()Ljava/util/Map;","invokevirtual",82);}
case 82:{f.Locals[13]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","executeReplacement","(Ljava/util/Map;Lforge/game/replacement/ReplacementEffect;Lforge/game/player/Player;)Lforge/game/replacement/ReplacementResult;","invokevirtual",92);}
case 92:{f.Locals[14]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{f.Locals[15]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",117);}
case 117:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",123);}
case 123:{f.Locals[16]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(JValue.R(null));f.Pc=126;continue;}
case 126:{f.Locals[17]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[14]);f.Pc=130;continue;}
case 130:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=133;continue;}
case 133:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?626:136;continue;}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",142);}
case 142:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",147);}
case 147:{f.Locals[18]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[18]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",156);}
case 156:{f.Pc=f.Pop().Int==0?249:159;continue;}
case 159:{f.Push(f.Locals[18]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",166);}
case 166:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=169;continue;}
case 169:{f.Locals[19]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[19]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",178);}
case 178:{f.Push(f.Locals[1]);f.Pc=179;continue;}
case 179:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?185:182;continue;}
case 182:{f.Pc=149;continue;}
case 185:{f.Push(f.Locals[19]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",192);}
case 192:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",201);}
case 201:{f.Pc=f.Pop().Int==0?246:204;continue;}
case 204:{f.Push(f.Locals[19]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",211);}
case 211:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[2]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",220);}
case 220:{f.StackOp("pop");f.Pc=221;continue;}
case 221:{f.Push(f.Locals[19]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",228);}
case 228:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",236);}
case 236:{f.Pc=f.Pop().Int==0?246:239;continue;}
case 239:{f.Push(f.Locals[18]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",246);}
case 246:{f.Pc=149;continue;}
case 249:{f.Push(f.Locals[14]);f.Pc=251;continue;}
case 251:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=254;continue;}
case 254:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?265:257;continue;}
case 257:{f.Push(f.Locals[9]);f.Pc=259;continue;}
case 259:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"));f.Pc=262;continue;}
case 262:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?474:265;continue;}
case 265:{f.Push(f.Locals[3]);f.Pc=266;continue;}
case 266:{f.Locals[19]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[11]);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[15]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/GameEntity","equals","(Ljava/lang/Object;)Z","invokevirtual",275);}
case 275:{f.Pc=f.Pop().Int!=0?339:278;continue;}
case 278:{f.Push(f.Locals[0]);f.Pc=279;continue;}
case 279:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/Game","getPlayersInTurnOrder","()Lforge/game/player/PlayerCollection;","invokevirtual",285);}
case 285:{f.Locals[20]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[15]);f.Pc=289;continue;}
case 289:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=292;continue;}
case 292:{f.Pc=f.Pop().Int==0?308:295;continue;}
case 295:{f.Push(f.Locals[20]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[15]);f.Pc=299;continue;}
case 299:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",305);}
case 305:{f.Pc=321;continue;}
case 308:{f.Push(f.Locals[20]);f.Pc=310;continue;}
case 310:{f.Push(f.Locals[15]);f.Pc=312;continue;}
case 312:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",318);}
case 318:{return rt.Call(f,"forge/game/player/PlayerCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",321);}
case 321:{f.Locals[21]=f.Pop();f.Pc=323;continue;}
case 323:{f.Push(f.Locals[0]);f.Pc=324;continue;}
case 324:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","replaceDamageList","Ljava/util/List;"));f.Pc=327;continue;}
case 327:{f.Push(f.Locals[21]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",334);}
case 334:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=337;continue;}
case 337:{f.Locals[19]=f.Pop();f.Pc=339;continue;}
case 339:{f.Push(f.Locals[0]);f.Pc=340;continue;}
case 340:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"));f.Pc=343;continue;}
case 343:{f.Push(f.Locals[2]);f.Pc=344;continue;}
case 344:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","getReplacementList","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;)Ljava/util/List;","invokevirtual",350);}
case 350:{f.Locals[20]=f.Pop();f.Pc=352;continue;}
case 352:{f.Push(f.Locals[20]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",359);}
case 359:{f.Locals[21]=f.Pop();f.Pc=361;continue;}
case 361:{f.Push(f.Locals[21]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",368);}
case 368:{f.Pc=f.Pop().Int==0?474:371;continue;}
case 371:{f.Push(f.Locals[21]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",378);}
case 378:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=381;continue;}
case 381:{f.Locals[22]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(f.Locals[4]);f.Pc=385;continue;}
case 385:{f.Push(f.Locals[22]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",392);}
case 392:{f.Pc=f.Pop().Int==0?419:395;continue;}
case 395:{f.Push(f.Locals[4]);f.Pc=397;continue;}
case 397:{f.Push(f.Locals[22]);f.Pc=399;continue;}
case 399:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",404);}
case 404:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=407;continue;}
case 407:{f.Push(f.Locals[2]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",413);}
case 413:{f.Pc=f.Pop().Int==0?419:416;continue;}
case 416:{f.Pc=361;continue;}
case 419:{f.Push(f.Locals[19]);f.Pc=421;continue;}
case 421:{f.Push(f.Locals[22]);f.Pc=423;continue;}
case 423:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",428);}
case 428:{f.Pc=f.Pop().Int!=0?448:431;continue;}
case 431:{f.Push(f.Locals[19]);f.Pc=433;continue;}
case 433:{f.Push(f.Locals[22]);f.Pc=435;continue;}
case 435:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=438;continue;}
case 438:{f.StackOp("dup");f.Pc=439;continue;}
case 439:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",442);}
case 442:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",447);}
case 447:{f.StackOp("pop");f.Pc=448;continue;}
case 448:{f.Push(f.Locals[19]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[22]);f.Pc=452;continue;}
case 452:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",457);}
case 457:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=460;continue;}
case 460:{f.Locals[23]=f.Pop();f.Pc=462;continue;}
case 462:{f.Push(f.Locals[23]);f.Pc=464;continue;}
case 464:{f.Push(f.Locals[2]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",470);}
case 470:{f.StackOp("pop");f.Pc=471;continue;}
case 471:{f.Pc=361;continue;}
case 474:{f.Push(f.Locals[9]);f.Pc=476;continue;}
case 476:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"));f.Pc=479;continue;}
case 479:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?626:482;continue;}
case 482:{f.Push(f.Locals[14]);f.Pc=484;continue;}
case 484:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=487;continue;}
case 487:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?626:490;continue;}
case 490:{f.Push(f.Locals[2]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","(Ljava/util/Map;)Ljava/util/EnumMap;","invokestatic",494);}
case 494:{f.Locals[17]=f.Pop();f.Pc=496;continue;}
case 496:{f.Push(f.Locals[17]);f.Pc=498;continue;}
case 498:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=501;continue;}
case 501:{f.Push(f.Locals[11]);f.Pc=503;continue;}
case 503:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",508);}
case 508:{f.StackOp("pop");f.Pc=509;continue;}
case 509:{f.Push(f.Locals[17]);f.Pc=511;continue;}
case 511:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=514;continue;}
case 514:{f.Push(f.Locals[12]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[16]);f.Pc=518;continue;}
case 518:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=519;continue;}
case 519:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",522);}
case 522:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",527);}
case 527:{f.StackOp("pop");f.Pc=528;continue;}
case 528:{f.Push(f.Locals[0]);f.Pc=529;continue;}
case 529:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"));f.Pc=532;continue;}
case 532:{f.Push(f.Locals[17]);f.Pc=534;continue;}
case 534:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=537;continue;}
case 537:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","getReplacementList","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;)Ljava/util/List;","invokevirtual",540);}
case 540:{f.Locals[19]=f.Pop();f.Pc=542;continue;}
case 542:{f.Push(f.Locals[19]);f.Pc=544;continue;}
case 544:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",549);}
case 549:{f.Locals[20]=f.Pop();f.Pc=551;continue;}
case 551:{f.Push(f.Locals[20]);f.Pc=553;continue;}
case 553:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",558);}
case 558:{f.Pc=f.Pop().Int==0?626:561;continue;}
case 561:{f.Push(f.Locals[20]);f.Pc=563;continue;}
case 563:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",568);}
case 568:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=571;continue;}
case 571:{f.Locals[21]=f.Pop();f.Pc=573;continue;}
case 573:{f.Push(f.Locals[3]);f.Pc=574;continue;}
case 574:{f.Push(f.Locals[21]);f.Pc=576;continue;}
case 576:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",581);}
case 581:{f.Pc=f.Pop().Int!=0?600:584;continue;}
case 584:{f.Push(f.Locals[3]);f.Pc=585;continue;}
case 585:{f.Push(f.Locals[21]);f.Pc=587;continue;}
case 587:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=590;continue;}
case 590:{f.StackOp("dup");f.Pc=591;continue;}
case 591:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",594);}
case 594:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",599);}
case 599:{f.StackOp("pop");f.Pc=600;continue;}
case 600:{f.Push(f.Locals[3]);f.Pc=601;continue;}
case 601:{f.Push(f.Locals[21]);f.Pc=603;continue;}
case 603:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",608);}
case 608:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=611;continue;}
case 611:{f.Locals[22]=f.Pop();f.Pc=613;continue;}
case 613:{f.Push(f.Locals[22]);f.Pc=615;continue;}
case 615:{f.Push(f.Locals[17]);f.Pc=617;continue;}
case 617:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",622);}
case 622:{f.StackOp("pop");f.Pc=623;continue;}
case 623:{f.Pc=551;continue;}
case 626:{f.Push(f.Locals[2]);f.Pc=627;continue;}
case 627:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResultMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResultMap","Lforge/game/ability/AbilityKey;"));f.Pc=630;continue;}
case 630:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",635);}
case 635:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=638;continue;}
case 638:{f.Locals[18]=f.Pop();f.Pc=640;continue;}
case 640:{f.Push(f.Locals[18]);f.Pc=642;continue;}
case 642:{f.Push(f.Locals[1]);f.Pc=643;continue;}
case 643:{f.Push(f.Locals[14]);f.Pc=645;continue;}
case 645:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",650);}
case 650:{f.StackOp("pop");f.Pc=651;continue;}
case 651:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementHandler$2","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementHandler$2","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=654;continue;}
case 654:{f.Push(f.Locals[14]);f.Pc=656;continue;}
case 656:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",659);}
case 659:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=660;continue;}
case 660:{switch(f.Pop().Int){case 1:f.Pc=688;break;case 2:f.Pc=691;break;default:f.Pc=836;break;}continue;}
case 688:{f.Pc=955;continue;}
case 691:{f.Push(f.Locals[11]);f.Pc=693;continue;}
case 693:{f.Push(f.Locals[15]);f.Pc=695;continue;}
case 695:{return rt.Call(f,"forge/game/GameEntity","equals","(Ljava/lang/Object;)Z","invokevirtual",698);}
case 698:{f.Pc=f.Pop().Int==0?722:701;continue;}
case 701:{f.Push(f.Locals[6]);f.Pc=703;continue;}
case 703:{f.Push(f.Locals[10]);f.Pc=705;continue;}
case 705:{f.Push(f.Locals[11]);f.Pc=707;continue;}
case 707:{f.Push(f.Locals[16]);f.Pc=709;continue;}
case 709:{f.Push(f.Locals[12]);f.Pc=711;continue;}
case 711:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=712;continue;}
case 712:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",715);}
case 715:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",718);}
case 718:{f.StackOp("pop");f.Pc=719;continue;}
case 719:{f.Pc=746;continue;}
case 722:{f.Push(f.Locals[9]);f.Pc=724;continue;}
case 724:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"));f.Pc=727;continue;}
case 727:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?746:730;continue;}
case 730:{f.Push(f.Locals[6]);f.Pc=732;continue;}
case 732:{f.Push(f.Locals[10]);f.Pc=734;continue;}
case 734:{f.Push(f.Locals[11]);f.Pc=736;continue;}
case 736:{f.Push(f.Locals[16]);f.Pc=738;continue;}
case 738:{f.Push(JNumbers.Unary("ineg",f.Pop()));f.Pc=739;continue;}
case 739:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",742);}
case 742:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",745);}
case 745:{f.StackOp("pop");f.Pc=746;continue;}
case 746:{f.Push(f.Locals[11]);f.Pc=748;continue;}
case 748:{f.Push(f.Locals[15]);f.Pc=750;continue;}
case 750:{return rt.Call(f,"forge/game/GameEntity","equals","(Ljava/lang/Object;)Z","invokevirtual",753);}
case 753:{f.Pc=f.Pop().Int!=0?789:756;continue;}
case 756:{f.Push(f.Locals[9]);f.Pc=758;continue;}
case 758:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"));f.Pc=761;continue;}
case 761:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?774:764;continue;}
case 764:{f.Push(f.Locals[6]);f.Pc=766;continue;}
case 766:{f.Push(f.Locals[10]);f.Pc=768;continue;}
case 768:{f.Push(f.Locals[11]);f.Pc=770;continue;}
case 770:{return rt.Call(f,"forge/game/card/CardDamageTable","remove","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",773);}
case 773:{f.StackOp("pop");f.Pc=774;continue;}
case 774:{f.Push(f.Locals[6]);f.Pc=776;continue;}
case 776:{f.Push(f.Locals[10]);f.Pc=778;continue;}
case 778:{f.Push(f.Locals[15]);f.Pc=780;continue;}
case 780:{f.Push(f.Locals[16]);f.Pc=782;continue;}
case 782:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",785);}
case 785:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",788);}
case 788:{f.StackOp("pop");f.Pc=789;continue;}
case 789:{f.Push(f.Locals[9]);f.Pc=791;continue;}
case 791:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"));f.Pc=794;continue;}
case 794:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?955:797;continue;}
case 797:{f.Push(f.Locals[7]);f.Pc=799;continue;}
case 799:{f.Push(f.Locals[10]);f.Pc=801;continue;}
case 801:{f.Push(f.Locals[11]);f.Pc=803;continue;}
case 803:{f.Push(f.Locals[12]);f.Pc=805;continue;}
case 805:{f.Push(f.Locals[16]);f.Pc=807;continue;}
case 807:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=808;continue;}
case 808:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",811);}
case 811:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",814);}
case 814:{f.StackOp("pop");f.Pc=815;continue;}
case 815:{f.Push(f.Locals[2]);f.Pc=816;continue;}
case 816:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","PreventedAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","PreventedAmount","Lforge/game/ability/AbilityKey;"));f.Pc=819;continue;}
case 819:{f.Push(f.Locals[12]);f.Pc=821;continue;}
case 821:{f.Push(f.Locals[16]);f.Pc=823;continue;}
case 823:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=824;continue;}
case 824:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",827);}
case 827:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",832);}
case 832:{f.StackOp("pop");f.Pc=833;continue;}
case 833:{f.Pc=955;continue;}
case 836:{f.Push(f.Locals[6]);f.Pc=838;continue;}
case 838:{f.Push(f.Locals[10]);f.Pc=840;continue;}
case 840:{f.Push(f.Locals[11]);f.Pc=842;continue;}
case 842:{return rt.Call(f,"forge/game/card/CardDamageTable","remove","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",845);}
case 845:{f.StackOp("pop");f.Pc=846;continue;}
case 846:{f.Push(f.Locals[9]);f.Pc=848;continue;}
case 848:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"));f.Pc=851;continue;}
case 851:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?902:854;continue;}
case 854:{f.Push(f.Locals[13]);f.Pc=856;continue;}
case 856:{f.Push(JValue.R(rt.String("Prevent")));f.Pc=859;continue;}
case 859:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",864);}
case 864:{f.Pc=f.Pop().Int==0?889:867;continue;}
case 867:{f.Push(f.Locals[13]);f.Pc=869;continue;}
case 869:{f.Push(JValue.R(rt.String("Prevent")));f.Pc=872;continue;}
case 872:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",877);}
case 877:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=880;continue;}
case 880:{f.Push(JValue.R(rt.String("True")));f.Pc=883;continue;}
case 883:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",886);}
case 886:{f.Pc=f.Pop().Int!=0?902:889;continue;}
case 889:{f.Push(f.Locals[13]);f.Pc=891;continue;}
case 891:{f.Push(JValue.R(rt.String("PreventionEffect")));f.Pc=894;continue;}
case 894:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",899);}
case 899:{f.Pc=f.Pop().Int==0?932:902;continue;}
case 902:{f.Push(f.Locals[7]);f.Pc=904;continue;}
case 904:{f.Push(f.Locals[10]);f.Pc=906;continue;}
case 906:{f.Push(f.Locals[11]);f.Pc=908;continue;}
case 908:{f.Push(f.Locals[12]);f.Pc=910;continue;}
case 910:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",913);}
case 913:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",916);}
case 916:{f.StackOp("pop");f.Pc=917;continue;}
case 917:{f.Push(f.Locals[2]);f.Pc=918;continue;}
case 918:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","PreventedAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","PreventedAmount","Lforge/game/ability/AbilityKey;"));f.Pc=921;continue;}
case 921:{f.Push(f.Locals[12]);f.Pc=923;continue;}
case 923:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",926);}
case 926:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",931);}
case 931:{f.StackOp("pop");f.Pc=932;continue;}
case 932:{f.Push(f.Locals[9]);f.Pc=934;continue;}
case 934:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"));f.Pc=937;continue;}
case 937:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?955:940;continue;}
case 940:{f.Push(f.Locals[6]);f.Pc=942;continue;}
case 942:{f.Push(f.Locals[10]);f.Pc=944;continue;}
case 944:{f.Push(f.Locals[15]);f.Pc=946;continue;}
case 946:{f.Push(f.Locals[16]);f.Pc=948;continue;}
case 948:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",951);}
case 951:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",954);}
case 954:{f.StackOp("pop");f.Pc=955;continue;}
case 955:{f.Push(f.Locals[8]);f.Pc=957;continue;}
case 957:{f.Push(f.Locals[2]);f.Pc=958;continue;}
case 958:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",963);}
case 963:{f.StackOp("pop");f.Pc=964;continue;}
case 964:{f.Push(f.Locals[9]);f.Pc=966;continue;}
case 966:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"));f.Pc=969;continue;}
case 969:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?982:972;continue;}
case 972:{f.Push(f.Locals[8]);f.Pc=974;continue;}
case 974:{f.Push(f.Locals[17]);f.Pc=976;continue;}
case 976:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",981);}
case 981:{f.StackOp("pop");f.Pc=982;continue;}
case 982:{f.Push(f.Locals[14]);f.Pc=984;continue;}
case 984:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=987;continue;}
case 987:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1023:990;continue;}
case 990:{f.Push(f.Locals[1]);f.Pc=991;continue;}
case 991:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getDescription","()Ljava/lang/String;","invokevirtual",994);}
case 994:{f.Locals[19]=f.Pop();f.Pc=996;continue;}
case 996:{f.Push(f.Locals[19]);f.Pc=998;continue;}
case 998:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",1001);}
case 1001:{f.Pc=f.Pop().Int!=0?1023:1004;continue;}
case 1004:{f.Push(f.Locals[0]);f.Pc=1005;continue;}
case 1005:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=1008;continue;}
case 1008:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=1011;continue;}
case 1011:{f.StackOp("dup");f.Pc=1012;continue;}
case 1012:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","EFFECT_REPLACED","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","EFFECT_REPLACED","Lforge/game/GameLogEntryType;"));f.Pc=1015;continue;}
case 1015:{f.Push(f.Locals[19]);f.Pc=1017;continue;}
case 1017:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",1020);}
case 1020:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1023);}
case 1023:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9035(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",6);}
case 6:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?721:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[4]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Reference!=null?53:50;continue;}
case 50:{f.Pc=12;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",58);}
case 58:{f.Locals[5]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",65);}
case 65:{f.Locals[6]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"));f.Pc=72;continue;}
case 72:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?91:75;continue;}
case 75:{f.Push(f.Locals[6]);f.Pc=77;continue;}
case 77:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"));f.Pc=80;continue;}
case 80:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?91:83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceEffect","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceEffect","Lforge/game/ability/ApiType;"));f.Pc=88;continue;}
case 88:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?106:91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",96);}
case 96:{f.Locals[5]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{f.Pc=f.Pop().Reference!=null?106:103;continue;}
case 103:{f.Pc=12;continue;}
case 106:{f.Push(f.Locals[3]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{f.Locals[7]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[7]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",124);}
case 124:{f.Pc=f.Pop().Int==0?130:127;continue;}
case 127:{f.Pc=12;continue;}
case 130:{f.Push(f.Locals[4]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMapParams","()Ljava/util/Map;","invokevirtual",135);}
case 135:{f.Locals[8]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[8]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("Prevent")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",147);}
case 147:{f.Pc=f.Pop().Int==0?172:150;continue;}
case 150:{f.Push(f.Locals[8]);f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("Prevent")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",160);}
case 160:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String("True")));f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",169);}
case 169:{f.Pc=f.Pop().Int!=0?185:172;continue;}
case 172:{f.Push(f.Locals[8]);f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("PreventionEffect")));f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",182);}
case 182:{f.Pc=f.Pop().Int==0?189:185;continue;}
case 185:{f.Push(JValue.I(1));f.Pc=186;continue;}
case 186:{f.Pc=190;continue;}
case 189:{f.Push(JValue.I(0));f.Pc=190;continue;}
case 190:{f.Locals[9]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[8]);f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("ExecuteMode")));f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",202);}
case 202:{f.Pc=f.Pop().Int==0?231:205;continue;}
case 205:{f.Push(f.Locals[8]);f.Pc=207;continue;}
case 207:{f.Push(JValue.R(rt.String("ExecuteMode")));f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",215);}
case 215:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=218;continue;}
case 218:{f.Push(JValue.R(rt.String("PerSource")));f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",224);}
case 224:{f.Pc=f.Pop().Int==0?231:227;continue;}
case 227:{f.Push(JValue.I(1));f.Pc=228;continue;}
case 228:{f.Pc=232;continue;}
case 231:{f.Push(JValue.I(0));f.Pc=232;continue;}
case 232:{f.Locals[10]=f.Pop();f.Pc=234;continue;}
case 234:{f.Push(f.Locals[8]);f.Pc=236;continue;}
case 236:{f.Push(JValue.R(rt.String("ExecuteMode")));f.Pc=239;continue;}
case 239:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",244);}
case 244:{f.Pc=f.Pop().Int==0?273:247;continue;}
case 247:{f.Push(f.Locals[8]);f.Pc=249;continue;}
case 249:{f.Push(JValue.R(rt.String("ExecuteMode")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",257);}
case 257:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=260;continue;}
case 260:{f.Push(JValue.R(rt.String("PerTarget")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",266);}
case 266:{f.Pc=f.Pop().Int==0?273:269;continue;}
case 269:{f.Push(JValue.I(1));f.Pc=270;continue;}
case 270:{f.Pc=274;continue;}
case 273:{f.Push(JValue.I(0));f.Pc=274;continue;}
case 274:{f.Locals[11]=f.Pop();f.Pc=276;continue;}
case 276:{f.Push(f.Locals[7]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",283);}
case 283:{f.Pc=f.Pop().Int!=0?718:286;continue;}
case 286:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",289);}
case 289:{f.Locals[12]=f.Pop();f.Pc=291;continue;}
case 291:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=294;continue;}
case 294:{f.StackOp("dup");f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",298);}
case 298:{f.Locals[13]=f.Pop();f.Pc=300;continue;}
case 300:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=303;continue;}
case 303:{f.StackOp("dup");f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",307);}
case 307:{f.Locals[14]=f.Pop();f.Pc=309;continue;}
case 309:{f.Push(JValue.I(0));f.Pc=310;continue;}
case 310:{f.Locals[15]=f.Pop();f.Pc=312;continue;}
case 312:{f.Push(f.Locals[7]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",319);}
case 319:{f.Locals[16]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[16]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",328);}
case 328:{f.Pc=f.Pop().Int==0?594:331;continue;}
case 331:{f.Push(f.Locals[16]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",338);}
case 338:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=341;continue;}
case 341:{f.Locals[17]=f.Pop();f.Pc=343;continue;}
case 343:{f.Push(f.Locals[17]);f.Pc=345;continue;}
case 345:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResultMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResultMap","Lforge/game/ability/AbilityKey;"));f.Pc=348;continue;}
case 348:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",353);}
case 353:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=356;continue;}
case 356:{f.Locals[18]=f.Pop();f.Pc=358;continue;}
case 358:{f.Push(f.Locals[18]);f.Pc=360;continue;}
case 360:{f.Push(f.Locals[4]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",367);}
case 367:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementResult"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=370;continue;}
case 370:{f.Locals[19]=f.Pop();f.Pc=372;continue;}
case 372:{f.Push(f.Locals[19]);f.Pc=374;continue;}
case 374:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=377;continue;}
case 377:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?414:380;continue;}
case 380:{f.Push(f.Locals[9]);f.Pc=382;continue;}
case 382:{f.Pc=f.Pop().Int==0?404:385;continue;}
case 385:{if(!rt.StaticReady(f,"java/lang/Boolean","FALSE","Ljava/lang/Boolean;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","FALSE","Ljava/lang/Boolean;"));f.Pc=388;continue;}
case 388:{f.Push(f.Locals[17]);f.Pc=390;continue;}
case 390:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","NoPreventDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","NoPreventDamage","Lforge/game/ability/AbilityKey;"));f.Pc=393;continue;}
case 393:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",398);}
case 398:{return rt.Call(f,"java/lang/Boolean","equals","(Ljava/lang/Object;)Z","invokevirtual",401);}
case 401:{f.Pc=f.Pop().Int==0?414:404;continue;}
case 404:{f.Push(f.Locals[16]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",411);}
case 411:{f.Pc=321;continue;}
case 414:{f.Push(f.Locals[17]);f.Pc=416;continue;}
case 416:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=419;continue;}
case 419:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",424);}
case 424:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=427;continue;}
case 427:{f.Locals[20]=f.Pop();f.Pc=429;continue;}
case 429:{f.Push(f.Locals[10]);f.Pc=431;continue;}
case 431:{f.Pc=f.Pop().Int==0?459:434;continue;}
case 434:{f.Push(f.Locals[13]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",441);}
case 441:{f.Pc=f.Pop().Int!=0?459:444;continue;}
case 444:{f.Push(f.Locals[13]);f.Pc=446;continue;}
case 446:{f.Push(f.Locals[20]);f.Pc=448;continue;}
case 448:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",453);}
case 453:{f.Pc=f.Pop().Int!=0?459:456;continue;}
case 456:{f.Pc=321;continue;}
case 459:{f.Push(f.Locals[17]);f.Pc=461;continue;}
case 461:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=464;continue;}
case 464:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",469);}
case 469:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=472;continue;}
case 472:{f.Locals[21]=f.Pop();f.Pc=474;continue;}
case 474:{f.Push(f.Locals[11]);f.Pc=476;continue;}
case 476:{f.Pc=f.Pop().Int==0?504:479;continue;}
case 479:{f.Push(f.Locals[14]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",486);}
case 486:{f.Pc=f.Pop().Int!=0?504:489;continue;}
case 489:{f.Push(f.Locals[14]);f.Pc=491;continue;}
case 491:{f.Push(f.Locals[21]);f.Pc=493;continue;}
case 493:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",498);}
case 498:{f.Pc=f.Pop().Int!=0?504:501;continue;}
case 501:{f.Pc=321;continue;}
case 504:{f.Push(f.Locals[16]);f.Pc=506;continue;}
case 506:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",511);}
case 511:{f.Push(f.Locals[17]);f.Pc=513;continue;}
case 513:{f.Push(f.Locals[9]);f.Pc=515;continue;}
case 515:{f.Pc=f.Pop().Int==0?524:518;continue;}
case 518:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","PreventedAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","PreventedAmount","Lforge/game/ability/AbilityKey;"));f.Pc=521;continue;}
case 521:{f.Pc=527;continue;}
case 524:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=527;continue;}
case 527:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",532);}
case 532:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=535;continue;}
case 535:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",538);}
case 538:{f.Locals[22]=f.Pop();f.Pc=540;continue;}
case 540:{f.Push(f.Locals[13]);f.Pc=542;continue;}
case 542:{f.Push(f.Locals[20]);f.Pc=544;continue;}
case 544:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",549);}
case 549:{f.Pc=f.Pop().Int!=0?562:552;continue;}
case 552:{f.Push(f.Locals[13]);f.Pc=554;continue;}
case 554:{f.Push(f.Locals[20]);f.Pc=556;continue;}
case 556:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",561);}
case 561:{f.StackOp("pop");f.Pc=562;continue;}
case 562:{f.Push(f.Locals[14]);f.Pc=564;continue;}
case 564:{f.Push(f.Locals[21]);f.Pc=566;continue;}
case 566:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",571);}
case 571:{f.Pc=f.Pop().Int!=0?584:574;continue;}
case 574:{f.Push(f.Locals[14]);f.Pc=576;continue;}
case 576:{f.Push(f.Locals[21]);f.Pc=578;continue;}
case 578:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",583);}
case 583:{f.StackOp("pop");f.Pc=584;continue;}
case 584:{f.Push(f.Locals[15]);f.Pc=586;continue;}
case 586:{f.Push(f.Locals[22]);f.Pc=588;continue;}
case 588:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=589;continue;}
case 589:{f.Locals[15]=f.Pop();f.Pc=591;continue;}
case 591:{f.Pc=321;continue;}
case 594:{f.Push(f.Locals[15]);f.Pc=596;continue;}
case 596:{f.Pc=f.Pop().Int<=0?715:599;continue;}
case 599:{f.Push(f.Locals[12]);f.Pc=601;continue;}
case 601:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=604;continue;}
case 604:{f.Push(f.Locals[13]);f.Pc=606;continue;}
case 606:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",611);}
case 611:{f.Push(JValue.I(1));f.Pc=612;continue;}
case 612:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?620:615;continue;}
case 615:{f.Push(f.Locals[13]);f.Pc=617;continue;}
case 617:{f.Pc=628;continue;}
case 620:{f.Push(f.Locals[13]);f.Pc=622;continue;}
case 622:{f.Push(JValue.I(0));f.Pc=623;continue;}
case 623:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",628);}
case 628:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",633);}
case 633:{f.StackOp("pop");f.Pc=634;continue;}
case 634:{f.Push(f.Locals[12]);f.Pc=636;continue;}
case 636:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=639;continue;}
case 639:{f.Push(f.Locals[14]);f.Pc=641;continue;}
case 641:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",646);}
case 646:{f.Push(JValue.I(1));f.Pc=647;continue;}
case 647:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?655:650;continue;}
case 650:{f.Push(f.Locals[14]);f.Pc=652;continue;}
case 652:{f.Pc=663;continue;}
case 655:{f.Push(f.Locals[14]);f.Pc=657;continue;}
case 657:{f.Push(JValue.I(0));f.Pc=658;continue;}
case 658:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",663);}
case 663:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",668);}
case 668:{f.StackOp("pop");f.Pc=669;continue;}
case 669:{f.Push(f.Locals[12]);f.Pc=671;continue;}
case 671:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=674;continue;}
case 674:{f.Push(f.Locals[15]);f.Pc=676;continue;}
case 676:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",679);}
case 679:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",684);}
case 684:{f.StackOp("pop");f.Pc=685;continue;}
case 685:{f.Push(f.Locals[4]);f.Pc=687;continue;}
case 687:{f.Push(f.Locals[12]);f.Pc=689;continue;}
case 689:{f.Push(f.Locals[4]);f.Pc=691;continue;}
case 691:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",694);}
case 694:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setReplacingObjects","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V","invokevirtual",697);}
case 697:{f.Push(f.Locals[5]);f.Pc=699;continue;}
case 699:{f.Push(f.Locals[4]);f.Pc=701;continue;}
case 701:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getHostCard","()Lforge/game/card/Card;","invokevirtual",704);}
case 704:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",707);}
case 707:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",710);}
case 710:{f.Push(f.Locals[5]);f.Pc=712;continue;}
case 712:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",715);}
case 715:{f.Pc=276;continue;}
case 718:{f.Pc=12;continue;}
case 721:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9036(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getPlayersInTurnOrder","()Lforge/game/player/PlayerCollection;","invokevirtual",7);}
case 7:{f.Locals[6]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{f.Locals[7]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[7]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[6]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",19);}
case 19:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?45:22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","replaceDamageList","Ljava/util/List;"));f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",33);}
case 33:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",38);}
case 38:{f.StackOp("pop");f.Pc=39;continue;}
case 39:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=42;continue;}
case 42:{f.Pc=12;continue;}
case 45:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",52);}
case 52:{f.Locals[7]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[6]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","getPossibleReplaceDamageList","(Lforge/game/player/PlayerCollection;ZLforge/game/card/CardDamageTable;Lforge/game/spellability/SpellAbility;)V","invokevirtual",64);}
case 64:{f.Push(JValue.R(null));f.Pc=65;continue;}
case 65:{f.Locals[8]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(JValue.R(null));f.Pc=68;continue;}
case 68:{f.Locals[9]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{f.Locals[10]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[10]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[6]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",80);}
case 80:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?145:83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","replaceDamageList","Ljava/util/List;"));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[10]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",94);}
case 94:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",102);}
case 102:{f.Pc=f.Pop().Int==0?108:105;continue;}
case 105:{f.Pc=139;continue;}
case 108:{f.Push(f.Locals[6]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[10]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",115);}
case 115:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=118;continue;}
case 118:{f.Locals[8]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","replaceDamageList","Ljava/util/List;"));f.Pc=124;continue;}
case 124:{f.Push(f.Locals[10]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",131);}
case 131:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=134;continue;}
case 134:{f.Locals[9]=f.Pop();f.Pc=136;continue;}
case 136:{f.Pc=145;continue;}
case 139:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=142;continue;}
case 142:{f.Pc=73;continue;}
case 145:{f.Push(f.Locals[9]);f.Pc=147;continue;}
case 147:{f.Pc=f.Pop().Reference!=null?153:150;continue;}
case 150:{f.Pc=1345;continue;}
case 153:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=156;continue;}
case 156:{f.StackOp("dup");f.Pc=157;continue;}
case 157:{f.Push(f.Locals[9]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",164);}
case 164:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",167);}
case 167:{f.Locals[10]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[8]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",174);}
case 174:{f.Push(f.Locals[10]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleReplacementEffect","(Ljava/util/List;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",179);}
case 179:{f.Locals[11]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[9]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[11]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",190);}
case 190:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=193;continue;}
case 193:{f.Locals[12]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[7]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[11]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",204);}
case 204:{f.Pc=f.Pop().Int!=0?224:207;continue;}
case 207:{f.Push(f.Locals[7]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[11]);f.Pc=211;continue;}
case 211:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=214;continue;}
case 214:{f.StackOp("dup");f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",218);}
case 218:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",223);}
case 223:{f.StackOp("pop");f.Pc=224;continue;}
case 224:{f.Push(f.Locals[11]);f.Pc=226;continue;}
case 226:{f.Push(JValue.I(1));f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setHasRun","(Z)V","invokevirtual",230);}
case 230:{f.Push(f.Locals[11]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",235);}
case 235:{f.Locals[13]=f.Pop();f.Pc=237;continue;}
case 237:{f.Push(JValue.R(null));f.Pc=238;continue;}
case 238:{f.Locals[14]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[13]);f.Pc=242;continue;}
case 242:{f.Locals[15]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(JValue.I(0));f.Pc=245;continue;}
case 245:{f.Locals[16]=f.Pop();f.Pc=247;continue;}
case 247:{f.Push(JValue.I(0));f.Pc=248;continue;}
case 248:{f.Locals[17]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(JValue.I(0));f.Pc=251;continue;}
case 251:{f.Locals[18]=f.Pop();f.Pc=253;continue;}
case 253:{f.Push(JValue.I(0));f.Pc=254;continue;}
case 254:{f.Locals[19]=f.Pop();f.Pc=256;continue;}
case 256:{f.Push(f.Locals[13]);f.Pc=258;continue;}
case 258:{f.Pc=f.Pop().Reference==null?647:261;continue;}
case 261:{f.Push(f.Locals[13]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",266);}
case 266:{f.Locals[14]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[14]);f.Pc=270;continue;}
case 270:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"));f.Pc=273;continue;}
case 273:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?292:276;continue;}
case 276:{f.Push(f.Locals[14]);f.Pc=278;continue;}
case 278:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"));f.Pc=281;continue;}
case 281:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?292:284;continue;}
case 284:{f.Push(f.Locals[14]);f.Pc=286;continue;}
case 286:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceEffect","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceEffect","Lforge/game/ability/ApiType;"));f.Pc=289;continue;}
case 289:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?313:292;continue;}
case 292:{f.Push(f.Locals[13]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",297);}
case 297:{f.Locals[15]=f.Pop();f.Pc=299;continue;}
case 299:{f.Push(f.Locals[15]);f.Pc=301;continue;}
case 301:{f.Pc=f.Pop().Reference==null?313:304;continue;}
case 304:{f.Push(JValue.I(1));f.Pc=305;continue;}
case 305:{f.Locals[16]=f.Pop();f.Pc=307;continue;}
case 307:{f.Push(f.Locals[13]);f.Pc=309;continue;}
case 309:{f.Push(JValue.R(null));f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",313);}
case 313:{f.Push(f.Locals[11]);f.Pc=315;continue;}
case 315:{f.Push(JValue.R(rt.String("PreventionEffect")));f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",321);}
case 321:{f.Pc=f.Pop().Int==0?341:324;continue;}
case 324:{f.Push(f.Locals[11]);f.Pc=326;continue;}
case 326:{f.Push(JValue.R(rt.String("PreventionEffect")));f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",332);}
case 332:{f.Push(JValue.R(rt.String("NextN")));f.Pc=335;continue;}
case 335:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",338);}
case 338:{f.Pc=f.Pop().Int!=0?349:341;continue;}
case 341:{f.Push(f.Locals[14]);f.Pc=343;continue;}
case 343:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"));f.Pc=346;continue;}
case 346:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?647:349;continue;}
case 349:{f.Push(f.Locals[14]);f.Pc=351;continue;}
case 351:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"));f.Pc=354;continue;}
case 354:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?383:357;continue;}
case 357:{f.Push(f.Locals[13]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",362);}
case 362:{f.Push(f.Locals[13]);f.Pc=364;continue;}
case 364:{f.Push(JValue.R(rt.String("Amount")));f.Pc=367;continue;}
case 367:{f.Push(JValue.R(rt.String("1")));f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",373);}
case 373:{f.Push(f.Locals[13]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",378);}
case 378:{f.Locals[19]=f.Pop();f.Pc=380;continue;}
case 380:{f.Pc=414;continue;}
case 383:{f.Push(f.Locals[14]);f.Pc=385;continue;}
case 385:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceSplitDamage","Lforge/game/ability/ApiType;"));f.Pc=388;continue;}
case 388:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?414:391;continue;}
case 391:{f.Push(f.Locals[13]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",396);}
case 396:{f.Push(f.Locals[13]);f.Pc=398;continue;}
case 398:{f.Push(JValue.R(rt.String("VarName")));f.Pc=401;continue;}
case 401:{f.Push(JValue.R(rt.String("1")));f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",407);}
case 407:{f.Push(f.Locals[13]);f.Pc=409;continue;}
case 409:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",412);}
case 412:{f.Locals[19]=f.Pop();f.Pc=414;continue;}
case 414:{f.Push(JValue.I(0));f.Pc=415;continue;}
case 415:{f.Locals[20]=f.Pop();f.Pc=417;continue;}
case 417:{f.Push(JValue.I(0));f.Pc=418;continue;}
case 418:{f.Locals[21]=f.Pop();f.Pc=420;continue;}
case 420:{f.Push(JValue.I(0));f.Pc=421;continue;}
case 421:{f.Locals[22]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(JValue.R(null));f.Pc=424;continue;}
case 424:{f.Locals[23]=f.Pop();f.Pc=426;continue;}
case 426:{f.Push(JValue.R(null));f.Pc=427;continue;}
case 427:{f.Locals[24]=f.Pop();f.Pc=429;continue;}
case 429:{f.Push(f.Locals[12]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",436);}
case 436:{f.Locals[25]=f.Pop();f.Pc=438;continue;}
case 438:{f.Push(f.Locals[25]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",445);}
case 445:{f.Pc=f.Pop().Int==0?602:448;continue;}
case 448:{f.Push(f.Locals[25]);f.Pc=450;continue;}
case 450:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",455);}
case 455:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=458;continue;}
case 458:{f.Locals[26]=f.Pop();f.Pc=460;continue;}
case 460:{f.Push(f.Locals[14]);f.Pc=462;continue;}
case 462:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"));f.Pc=465;continue;}
case 465:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?490:468;continue;}
case 468:{if(!rt.StaticReady(f,"java/lang/Boolean","TRUE","Ljava/lang/Boolean;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","TRUE","Ljava/lang/Boolean;"));f.Pc=471;continue;}
case 471:{f.Push(f.Locals[26]);f.Pc=473;continue;}
case 473:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","NoPreventDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","NoPreventDamage","Lforge/game/ability/AbilityKey;"));f.Pc=476;continue;}
case 476:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",481);}
case 481:{return rt.Call(f,"java/lang/Boolean","equals","(Ljava/lang/Object;)Z","invokevirtual",484);}
case 484:{f.Pc=f.Pop().Int==0?490:487;continue;}
case 487:{f.Pc=438;continue;}
case 490:{f.Push(f.Locals[20]);f.Pc=492;continue;}
case 492:{f.Push(f.Locals[26]);f.Pc=494;continue;}
case 494:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=497;continue;}
case 497:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",502);}
case 502:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=505;continue;}
case 505:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",508);}
case 508:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=509;continue;}
case 509:{f.Locals[20]=f.Pop();f.Pc=511;continue;}
case 511:{f.Push(f.Locals[23]);f.Pc=513;continue;}
case 513:{f.Pc=f.Pop().Reference!=null?534:516;continue;}
case 516:{f.Push(f.Locals[26]);f.Pc=518;continue;}
case 518:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=521;continue;}
case 521:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",526);}
case 526:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=529;continue;}
case 529:{f.Locals[23]=f.Pop();f.Pc=531;continue;}
case 531:{f.Pc=555;continue;}
case 534:{f.Push(f.Locals[23]);f.Pc=536;continue;}
case 536:{f.Push(f.Locals[26]);f.Pc=538;continue;}
case 538:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=541;continue;}
case 541:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",546);}
case 546:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",549);}
case 549:{f.Pc=f.Pop().Int!=0?555:552;continue;}
case 552:{f.Push(JValue.I(1));f.Pc=553;continue;}
case 553:{f.Locals[21]=f.Pop();f.Pc=555;continue;}
case 555:{f.Push(f.Locals[24]);f.Pc=557;continue;}
case 557:{f.Pc=f.Pop().Reference!=null?578:560;continue;}
case 560:{f.Push(f.Locals[26]);f.Pc=562;continue;}
case 562:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=565;continue;}
case 565:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",570);}
case 570:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=573;continue;}
case 573:{f.Locals[24]=f.Pop();f.Pc=575;continue;}
case 575:{f.Pc=599;continue;}
case 578:{f.Push(f.Locals[24]);f.Pc=580;continue;}
case 580:{f.Push(f.Locals[26]);f.Pc=582;continue;}
case 582:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=585;continue;}
case 585:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",590);}
case 590:{return rt.Call(f,"forge/game/GameEntity","equals","(Ljava/lang/Object;)Z","invokevirtual",593);}
case 593:{f.Pc=f.Pop().Int!=0?599:596;continue;}
case 596:{f.Push(JValue.I(1));f.Pc=597;continue;}
case 597:{f.Locals[22]=f.Pop();f.Pc=599;continue;}
case 599:{f.Pc=438;continue;}
case 602:{f.Push(f.Locals[20]);f.Pc=604;continue;}
case 604:{f.Push(f.Locals[19]);f.Pc=606;continue;}
case 606:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?647:609;continue;}
case 609:{f.Push(f.Locals[12]);f.Pc=611;continue;}
case 611:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",616);}
case 616:{f.Push(JValue.I(1));f.Pc=617;continue;}
case 617:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?647:620;continue;}
case 620:{f.Push(f.Locals[21]);f.Pc=622;continue;}
case 622:{f.Pc=f.Pop().Int==0?628:625;continue;}
case 625:{f.Push(JValue.I(1));f.Pc=626;continue;}
case 626:{f.Locals[18]=f.Pop();f.Pc=628;continue;}
case 628:{f.Push(f.Locals[13]);f.Pc=630;continue;}
case 630:{f.Push(JValue.R(rt.String("DivideShield")));f.Pc=633;continue;}
case 633:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",636);}
case 636:{f.Pc=f.Pop().Int==0?647:639;continue;}
case 639:{f.Push(f.Locals[22]);f.Pc=641;continue;}
case 641:{f.Pc=f.Pop().Int==0?647:644;continue;}
case 644:{f.Push(JValue.I(1));f.Pc=645;continue;}
case 645:{f.Locals[17]=f.Pop();f.Pc=647;continue;}
case 647:{f.Push(JValue.R(null));f.Pc=648;continue;}
case 648:{f.Locals[20]=f.Pop();f.Pc=650;continue;}
case 650:{f.Push(f.Locals[17]);f.Pc=652;continue;}
case 652:{f.Pc=f.Pop().Int==0?764:655;continue;}
case 655:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=658;continue;}
case 658:{f.StackOp("dup");f.Pc=659;continue;}
case 659:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",662);}
case 662:{f.Locals[21]=f.Pop();f.Pc=664;continue;}
case 664:{f.Push(f.Locals[12]);f.Pc=666;continue;}
case 666:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",671);}
case 671:{f.Locals[22]=f.Pop();f.Pc=673;continue;}
case 673:{f.Push(f.Locals[22]);f.Pc=675;continue;}
case 675:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",680);}
case 680:{f.Pc=f.Pop().Int==0?745:683;continue;}
case 683:{f.Push(f.Locals[22]);f.Pc=685;continue;}
case 685:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",690);}
case 690:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=693;continue;}
case 693:{f.Locals[23]=f.Pop();f.Pc=695;continue;}
case 695:{f.Push(f.Locals[23]);f.Pc=697;continue;}
case 697:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=700;continue;}
case 700:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",705);}
case 705:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=708;continue;}
case 708:{f.Locals[24]=f.Pop();f.Pc=710;continue;}
case 710:{f.Push(f.Locals[23]);f.Pc=712;continue;}
case 712:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=715;continue;}
case 715:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",720);}
case 720:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=723;continue;}
case 723:{f.Locals[25]=f.Pop();f.Pc=725;continue;}
case 725:{f.Push(f.Locals[21]);f.Pc=727;continue;}
case 727:{f.Push(f.Locals[24]);f.Pc=729;continue;}
case 729:{f.Push(f.Locals[25]);f.Pc=731;continue;}
case 731:{return rt.DynamicCall(f,"forge/game/replacement/ReplacementHandler:9036:731:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiFunction;",736);}
case 736:{return rt.Call(f,"java/util/Map","merge","(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;","invokeinterface",741);}
case 741:{f.StackOp("pop");f.Pc=742;continue;}
case 742:{f.Pc=673;continue;}
case 745:{f.Push(f.Locals[8]);f.Pc=747;continue;}
case 747:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",750);}
case 750:{f.Push(f.Locals[11]);f.Pc=752;continue;}
case 752:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getHostCard","()Lforge/game/card/Card;","invokevirtual",755);}
case 755:{f.Push(f.Locals[21]);f.Pc=757;continue;}
case 757:{f.Push(f.Locals[19]);f.Pc=759;continue;}
case 759:{return rt.Call(f,"forge/game/player/PlayerController","divideShield","(Lforge/game/card/Card;Ljava/util/Map;I)Ljava/util/Map;","invokevirtual",762);}
case 762:{f.Locals[20]=f.Pop();f.Pc=764;continue;}
case 764:{f.Push(f.Locals[18]);f.Pc=766;continue;}
case 766:{f.Pc=f.Pop().Int==0?1149:769;continue;}
case 769:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=772;continue;}
case 772:{f.StackOp("dup");f.Pc=773;continue;}
case 773:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",776);}
case 776:{f.Locals[21]=f.Pop();f.Pc=778;continue;}
case 778:{f.Push(f.Locals[12]);f.Pc=780;continue;}
case 780:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",785);}
case 785:{f.Locals[22]=f.Pop();f.Pc=787;continue;}
case 787:{f.Push(f.Locals[22]);f.Pc=789;continue;}
case 789:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",794);}
case 794:{f.Pc=f.Pop().Int==0?861:797;continue;}
case 797:{f.Push(f.Locals[22]);f.Pc=799;continue;}
case 799:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",804);}
case 804:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=807;continue;}
case 807:{f.Locals[23]=f.Pop();f.Pc=809;continue;}
case 809:{f.Push(f.Locals[14]);f.Pc=811;continue;}
case 811:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"));f.Pc=814;continue;}
case 814:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?839:817;continue;}
case 817:{if(!rt.StaticReady(f,"java/lang/Boolean","TRUE","Ljava/lang/Boolean;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","TRUE","Ljava/lang/Boolean;"));f.Pc=820;continue;}
case 820:{f.Push(f.Locals[23]);f.Pc=822;continue;}
case 822:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","NoPreventDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","NoPreventDamage","Lforge/game/ability/AbilityKey;"));f.Pc=825;continue;}
case 825:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",830);}
case 830:{return rt.Call(f,"java/lang/Boolean","equals","(Ljava/lang/Object;)Z","invokevirtual",833);}
case 833:{f.Pc=f.Pop().Int==0?839:836;continue;}
case 836:{f.Pc=787;continue;}
case 839:{f.Push(f.Locals[21]);f.Pc=841;continue;}
case 841:{f.Push(f.Locals[23]);f.Pc=843;continue;}
case 843:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=846;continue;}
case 846:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",851);}
case 851:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=854;continue;}
case 854:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",857);}
case 857:{f.StackOp("pop");f.Pc=858;continue;}
case 858:{f.Pc=787;continue;}
case 861:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",864);}
case 864:{f.Push(JValue.R(rt.String("lblChooseSource")));f.Pc=867;continue;}
case 867:{f.Push(JValue.I(0));f.Pc=868;continue;}
case 868:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=871;continue;}
case 871:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",874);}
case 874:{return rt.DynamicCall(f,"forge/game/replacement/ReplacementHandler:9036:874:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",879);}
case 879:{f.Locals[22]=f.Pop();f.Pc=881;continue;}
case 881:{f.Push(f.Locals[19]);f.Pc=883;continue;}
case 883:{f.Pc=f.Pop().Int<=0?1146:886;continue;}
case 886:{f.Push(f.Locals[21]);f.Pc=888;continue;}
case 888:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",891);}
case 891:{f.Pc=f.Pop().Int!=0?1146:894;continue;}
case 894:{f.Push(f.Locals[8]);f.Pc=896;continue;}
case 896:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",899);}
case 899:{f.Push(f.Locals[21]);f.Pc=901;continue;}
case 901:{f.Push(f.Locals[13]);f.Pc=903;continue;}
case 903:{f.Push(f.Locals[22]);f.Pc=905;continue;}
case 905:{f.Push(JValue.R(null));f.Pc=906;continue;}
case 906:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",909);}
case 909:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=912;continue;}
case 912:{f.Locals[23]=f.Pop();f.Pc=914;continue;}
case 914:{f.Push(f.Locals[21]);f.Pc=916;continue;}
case 916:{f.Push(f.Locals[23]);f.Pc=918;continue;}
case 918:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",921);}
case 921:{f.StackOp("pop");f.Pc=922;continue;}
case 922:{f.Push(f.Locals[12]);f.Pc=924;continue;}
case 924:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",929);}
case 929:{f.Locals[24]=f.Pop();f.Pc=931;continue;}
case 931:{f.Push(f.Locals[24]);f.Pc=933;continue;}
case 933:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",938);}
case 938:{f.Pc=f.Pop().Int==0?1143:941;continue;}
case 941:{f.Push(f.Locals[24]);f.Pc=943;continue;}
case 943:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",948);}
case 948:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=951;continue;}
case 951:{f.Locals[25]=f.Pop();f.Pc=953;continue;}
case 953:{f.Push(f.Locals[23]);f.Pc=955;continue;}
case 955:{f.Push(f.Locals[25]);f.Pc=957;continue;}
case 957:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=960;continue;}
case 960:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",965);}
case 965:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",968);}
case 968:{f.Pc=f.Pop().Int==0?1140:971;continue;}
case 971:{f.Push(f.Locals[24]);f.Pc=973;continue;}
case 973:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",978);}
case 978:{f.Push(f.Locals[20]);f.Pc=980;continue;}
case 980:{f.Pc=f.Pop().Reference==null?1068:983;continue;}
case 983:{f.Push(f.Locals[25]);f.Pc=985;continue;}
case 985:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=988;continue;}
case 988:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",993);}
case 993:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=996;continue;}
case 996:{f.Locals[26]=f.Pop();f.Pc=998;continue;}
case 998:{f.Push(f.Locals[20]);f.Pc=1000;continue;}
case 1000:{f.Push(f.Locals[26]);f.Pc=1002;continue;}
case 1002:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1007);}
case 1007:{f.Pc=f.Pop().Int==0?931:1010;continue;}
case 1010:{f.Push(f.Locals[20]);f.Pc=1012;continue;}
case 1012:{f.Push(f.Locals[26]);f.Pc=1014;continue;}
case 1014:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1019);}
case 1019:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1022;continue;}
case 1022:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1025);}
case 1025:{f.Pc=f.Pop().Int<=0?931:1028;continue;}
case 1028:{f.Push(f.Locals[20]);f.Pc=1030;continue;}
case 1030:{f.Push(f.Locals[26]);f.Pc=1032;continue;}
case 1032:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1037);}
case 1037:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1040;continue;}
case 1040:{f.Locals[27]=f.Pop();f.Pc=1042;continue;}
case 1042:{f.Push(f.Locals[25]);f.Pc=1044;continue;}
case 1044:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DividedShieldAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DividedShieldAmount","Lforge/game/ability/AbilityKey;"));f.Pc=1047;continue;}
case 1047:{f.Push(f.Locals[27]);f.Pc=1049;continue;}
case 1049:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1054);}
case 1054:{f.StackOp("pop");f.Pc=1055;continue;}
case 1055:{f.Push(f.Locals[19]);f.Pc=1057;continue;}
case 1057:{f.Push(f.Locals[27]);f.Pc=1059;continue;}
case 1059:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1062);}
case 1062:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=1063;continue;}
case 1063:{f.Locals[19]=f.Pop();f.Pc=1065;continue;}
case 1065:{f.Pc=1089;continue;}
case 1068:{f.Push(f.Locals[19]);f.Pc=1070;continue;}
case 1070:{f.Push(f.Locals[25]);f.Pc=1072;continue;}
case 1072:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=1075;continue;}
case 1075:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1080);}
case 1080:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1083;continue;}
case 1083:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1086);}
case 1086:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=1087;continue;}
case 1087:{f.Locals[19]=f.Pop();f.Pc=1089;continue;}
case 1089:{f.Push(f.Locals[25]);f.Pc=1091;continue;}
case 1091:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResultMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResultMap","Lforge/game/ability/AbilityKey;"));f.Pc=1094;continue;}
case 1094:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1099);}
case 1099:{f.Pc=f.Pop().Int!=0?1124:1102;continue;}
case 1102:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=1105;continue;}
case 1105:{f.StackOp("dup");f.Pc=1106;continue;}
case 1106:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",1109);}
case 1109:{f.Locals[26]=f.Pop();f.Pc=1111;continue;}
case 1111:{f.Push(f.Locals[25]);f.Pc=1113;continue;}
case 1113:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResultMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResultMap","Lforge/game/ability/AbilityKey;"));f.Pc=1116;continue;}
case 1116:{f.Push(f.Locals[26]);f.Pc=1118;continue;}
case 1118:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1123);}
case 1123:{f.StackOp("pop");f.Pc=1124;continue;}
case 1124:{f.Push(f.Locals[0]);f.Pc=1125;continue;}
case 1125:{f.Push(f.Locals[11]);f.Pc=1127;continue;}
case 1127:{f.Push(f.Locals[25]);f.Pc=1129;continue;}
case 1129:{f.Push(f.Locals[9]);f.Pc=1131;continue;}
case 1131:{f.Push(f.Locals[7]);f.Pc=1133;continue;}
case 1133:{f.Push(f.Locals[8]);f.Pc=1135;continue;}
case 1135:{f.Push(f.Locals[2]);f.Pc=1136;continue;}
case 1136:{f.Push(f.Locals[3]);f.Pc=1137;continue;}
case 1137:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","runSingleReplaceDamageEffect","(Lforge/game/replacement/ReplacementEffect;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Lforge/game/player/Player;Lforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;)V","invokevirtual",1140);}
case 1140:{f.Pc=931;continue;}
case 1143:{f.Pc=881;continue;}
case 1146:{f.Pc=1311;continue;}
case 1149:{f.Push(f.Locals[12]);f.Pc=1151;continue;}
case 1151:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1156);}
case 1156:{f.Locals[21]=f.Pop();f.Pc=1158;continue;}
case 1158:{f.Push(f.Locals[21]);f.Pc=1160;continue;}
case 1160:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1165);}
case 1165:{f.Pc=f.Pop().Int==0?1311:1168;continue;}
case 1168:{f.Push(f.Locals[21]);f.Pc=1170;continue;}
case 1170:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1175);}
case 1175:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1178;continue;}
case 1178:{f.Locals[22]=f.Pop();f.Pc=1180;continue;}
case 1180:{f.Push(f.Locals[20]);f.Pc=1182;continue;}
case 1182:{f.Pc=f.Pop().Reference==null?1257:1185;continue;}
case 1185:{f.Push(f.Locals[22]);f.Pc=1187;continue;}
case 1187:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=1190;continue;}
case 1190:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1195);}
case 1195:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1198;continue;}
case 1198:{f.Locals[23]=f.Pop();f.Pc=1200;continue;}
case 1200:{f.Push(f.Locals[20]);f.Pc=1202;continue;}
case 1202:{f.Push(f.Locals[23]);f.Pc=1204;continue;}
case 1204:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1209);}
case 1209:{f.Pc=f.Pop().Int==0?1158:1212;continue;}
case 1212:{f.Push(f.Locals[20]);f.Pc=1214;continue;}
case 1214:{f.Push(f.Locals[23]);f.Pc=1216;continue;}
case 1216:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1221);}
case 1221:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1224;continue;}
case 1224:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1227);}
case 1227:{f.Pc=f.Pop().Int<=0?1158:1230;continue;}
case 1230:{f.Push(f.Locals[20]);f.Pc=1232;continue;}
case 1232:{f.Push(f.Locals[23]);f.Pc=1234;continue;}
case 1234:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1239);}
case 1239:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1242;continue;}
case 1242:{f.Locals[24]=f.Pop();f.Pc=1244;continue;}
case 1244:{f.Push(f.Locals[22]);f.Pc=1246;continue;}
case 1246:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DividedShieldAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DividedShieldAmount","Lforge/game/ability/AbilityKey;"));f.Pc=1249;continue;}
case 1249:{f.Push(f.Locals[24]);f.Pc=1251;continue;}
case 1251:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1256);}
case 1256:{f.StackOp("pop");f.Pc=1257;continue;}
case 1257:{f.Push(f.Locals[22]);f.Pc=1259;continue;}
case 1259:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResultMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResultMap","Lforge/game/ability/AbilityKey;"));f.Pc=1262;continue;}
case 1262:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",1267);}
case 1267:{f.Pc=f.Pop().Int!=0?1292:1270;continue;}
case 1270:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=1273;continue;}
case 1273:{f.StackOp("dup");f.Pc=1274;continue;}
case 1274:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",1277);}
case 1277:{f.Locals[23]=f.Pop();f.Pc=1279;continue;}
case 1279:{f.Push(f.Locals[22]);f.Pc=1281;continue;}
case 1281:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementResultMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementResultMap","Lforge/game/ability/AbilityKey;"));f.Pc=1284;continue;}
case 1284:{f.Push(f.Locals[23]);f.Pc=1286;continue;}
case 1286:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1291);}
case 1291:{f.StackOp("pop");f.Pc=1292;continue;}
case 1292:{f.Push(f.Locals[0]);f.Pc=1293;continue;}
case 1293:{f.Push(f.Locals[11]);f.Pc=1295;continue;}
case 1295:{f.Push(f.Locals[22]);f.Pc=1297;continue;}
case 1297:{f.Push(f.Locals[9]);f.Pc=1299;continue;}
case 1299:{f.Push(f.Locals[7]);f.Pc=1301;continue;}
case 1301:{f.Push(f.Locals[8]);f.Pc=1303;continue;}
case 1303:{f.Push(f.Locals[2]);f.Pc=1304;continue;}
case 1304:{f.Push(f.Locals[3]);f.Pc=1305;continue;}
case 1305:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","runSingleReplaceDamageEffect","(Lforge/game/replacement/ReplacementEffect;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Lforge/game/player/Player;Lforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;)V","invokevirtual",1308);}
case 1308:{f.Pc=1158;continue;}
case 1311:{f.Push(f.Locals[16]);f.Pc=1313;continue;}
case 1313:{f.Pc=f.Pop().Int==0?1326:1316;continue;}
case 1316:{f.Push(f.Locals[13]);f.Pc=1318;continue;}
case 1318:{f.Push(f.Locals[15]);f.Pc=1320;continue;}
case 1320:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1323;continue;}
case 1323:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",1326);}
case 1326:{f.Push(f.Locals[11]);f.Pc=1328;continue;}
case 1328:{f.Push(JValue.I(0));f.Pc=1329;continue;}
case 1329:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setHasRun","(Z)V","invokevirtual",1332);}
case 1332:{f.Push(f.Locals[9]);f.Pc=1334;continue;}
case 1334:{f.Push(f.Locals[11]);f.Pc=1336;continue;}
case 1336:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1341);}
case 1341:{f.StackOp("pop");f.Pc=1342;continue;}
case 1342:{f.Pc=64;continue;}
case 1345:{f.Push(f.Locals[0]);f.Pc=1346;continue;}
case 1346:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","replaceDamageList","Ljava/util/List;"));f.Pc=1349;continue;}
case 1349:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",1354);}
case 1354:{f.Push(f.Locals[0]);f.Pc=1355;continue;}
case 1355:{f.Push(f.Locals[7]);f.Pc=1357;continue;}
case 1357:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","executeReplaceDamageBufferedSA","(Ljava/util/Map;)V","invokevirtual",1360);}
case 1360:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9037(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9038(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/AbilityFactory","getMapParams","(Ljava/lang/String;)Ljava/util/Map;","invokestatic",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/util/Map;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/replacement/ReplacementEffect;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9039(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Event")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/replacement/ReplacementType","smartValueOf","(Ljava/lang/String;)Lforge/game/replacement/ReplacementType;","invokestatic",15);}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/replacement/ReplacementType","createReplacement","(Ljava/util/Map;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokevirtual",25);}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("ActiveZones")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[6]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(JValue.R(null));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?60:47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[6]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",54);}
case 54:{return rt.Call(f,"java/util/EnumSet","copyOf","(Ljava/util/Collection;)Ljava/util/EnumSet;","invokestatic",57);}
case 57:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",60);}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("ReplaceWith")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",69);}
case 69:{f.Pc=f.Pop().Int==0?98:72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{f.Pc=f.Pop().Reference==null?98:76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("ReplaceWith")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",88);}
case 88:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",95);}
case 95:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",98);}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/CardState")?1:0));f.Pc=102;continue;}
case 102:{f.Pc=f.Pop().Int==0?117:105;continue;}
case 105:{f.Push(f.Locals[5]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",114);}
case 114:{f.Pc=136;continue;}
case 117:{f.Push(f.Locals[3]);f.Pc=118;continue;}
case 118:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/CardTraitBase")?1:0));f.Pc=121;continue;}
case 121:{f.Pc=f.Pop().Int==0?136:124;continue;}
case 124:{f.Push(f.Locals[5]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/CardTraitBase"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/CardTraitBase","getCardState","()Lforge/game/card/CardState;","invokevirtual",133);}
case 133:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",136);}
case 136:{f.Push(f.Locals[5]);f.Pc=138;continue;}
case 138:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9040(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Phase","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Phase","Lforge/game/ability/AbilityKey;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","BeginPhase","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","BeginPhase","Lforge/game/replacement/ReplacementType;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Control","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Control","Lforge/game/replacement/ReplacementLayer;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","getReplacementList","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;)Ljava/util/List;","invokevirtual",27);}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int==0?41:39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9041(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ExtraTurn","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ExtraTurn","Lforge/game/ability/AbilityKey;"));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",18);}
case 18:{f.StackOp("pop");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","BeginTurn","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","BeginTurn","Lforge/game/replacement/ReplacementType;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","getReplacementList","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;)Ljava/util/List;","invokevirtual",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?42:40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9042(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/game/replacement/ReplacementHandler$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/replacement/ReplacementHandler$1")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/replacement/ReplacementHandler$1","<init>","(Lforge/game/replacement/ReplacementHandler;Lforge/game/GameEntity;Ljava/util/List;)V","invokespecial",18);}
case 18:{return rt.Call(f,"forge/game/Game","forEachCardInGame","(Lforge/util/Visitor;)V","invokevirtual",21);}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",29);}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?136:41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",58);}
case 58:{f.Locals[6]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("Amount")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int==0?133:71;continue;}
case 71:{f.Push(f.Locals[6]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("Amount")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",79);}
case 79:{f.Locals[7]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[7]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",86);}
case 86:{f.Pc=f.Pop().Int==0?100:89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[7]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",95);}
case 95:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=96;continue;}
case 96:{f.Locals[3]=f.Pop();f.Pc=97;continue;}
case 97:{f.Pc=133;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[7]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",107);}
case 107:{f.Locals[7]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[7]);f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String("Number$")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int==0?133:120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[7]);f.Pc=123;continue;}
case 123:{f.Push(JValue.I(7));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",128);}
case 128:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",131);}
case 131:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=132;continue;}
case 132:{f.Locals[3]=f.Pop();f.Pc=133;continue;}
case 133:{f.Pc=31;continue;}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9043(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[1]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?167:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[2]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","getReplacementEffects","()Lforge/util/collect/FCollectionView;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",44);}
case 44:{f.Locals[3]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int==0?164:54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",60);}
case 60:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=63;continue;}
case 63:{f.Locals[4]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMode","()Lforge/game/replacement/ReplacementType;","invokevirtual",70);}
case 70:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"));f.Pc=73;continue;}
case 73:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?161:76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getLayer","()Lforge/game/replacement/ReplacementLayer;","invokevirtual",81);}
case 81:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=84;continue;}
case 84:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?161:87;continue;}
case 87:{f.Push(JValue.R(rt.String("True")));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("Prevent")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",98);}
case 98:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Int==0?161:104;continue;}
case 104:{f.Push(JValue.R(rt.String("True")));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[4]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("IsCombat")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",115);}
case 115:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int==0?161:121;continue;}
case 121:{f.Push(f.Locals[4]);f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",129);}
case 129:{f.Pc=f.Pop().Int!=0?161:132;continue;}
case 132:{f.Push(f.Locals[4]);f.Pc=134;continue;}
case 134:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",140);}
case 140:{f.Pc=f.Pop().Int!=0?161:143;continue;}
case 143:{f.Push(f.Locals[4]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=149;continue;}
case 149:{f.Push(f.Locals[2]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",153);}
case 153:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","zonesCheck","(Lforge/game/zone/Zone;)Z","invokevirtual",156);}
case 156:{f.Pc=f.Pop().Int==0?161:159;continue;}
case 159:{f.Push(JValue.I(1));f.Pc=160;continue;}
case 160:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 161:{f.Pc=45;continue;}
case 164:{f.Pc=16;continue;}
case 167:{f.Push(JValue.I(0));f.Pc=168;continue;}
case 168:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9044(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","hasRun","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9045(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?9:4;continue;}
case 4:{f.Push(f.Locals[6]);f.Pc=6;continue;}
case 6:{f.Pc=18;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[6]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{f.Locals[7]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[7]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[6]);f.Pc=24;continue;}
case 24:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?54:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"));f.Pc=31;continue;}
case 31:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?54:34;continue;}
case 34:{f.Push(f.Locals[7]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int!=0?54:42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Reference!=null?58:54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{f.Pc=59;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{f.Locals[8]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[7]);f.Pc=63;continue;}
case 63:{f.Locals[9]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[7]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/Card","getReplacementEffects","()Lforge/util/collect/FCollectionView;","invokevirtual",70);}
case 70:{f.Locals[10]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[8]);f.Pc=74;continue;}
case 74:{f.Pc=f.Pop().Int==0?89:77;continue;}
case 77:{f.Push(f.Locals[10]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",84);}
case 84:{f.Pc=f.Pop().Int==0?89:87;continue;}
case 87:{f.Push(JValue.I(1));f.Pc=88;continue;}
case 88:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=93;continue;}
case 93:{f.Push(f.Locals[7]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",98);}
case 98:{f.Locals[11]=f.Pop();f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/spellability/Spell","isPerformanceMode","()Z","invokestatic",103);}
case 103:{f.Pc=f.Pop().Int==0?156:106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Tap","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Tap","Lforge/game/replacement/ReplacementType;"));f.Pc=110;continue;}
case 110:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?127:113;continue;}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Untap","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Untap","Lforge/game/replacement/ReplacementType;"));f.Pc=117;continue;}
case 117:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?127:120;continue;}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","ProduceMana","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","ProduceMana","Lforge/game/replacement/ReplacementType;"));f.Pc=124;continue;}
case 124:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?156:127;continue;}
case 127:{f.Push(f.Locals[11]);f.Pc=129;continue;}
case 129:{f.Pc=f.Pop().Reference==null?156:132;continue;}
case 132:{f.Push(f.Locals[11]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",137);}
case 137:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=140;continue;}
case 140:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?156:143;continue;}
case 143:{f.Push(f.Locals[11]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",148);}
case 148:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=151;continue;}
case 151:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?156:154;continue;}
case 154:{f.Push(JValue.I(1));f.Pc=155;continue;}
case 155:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 156:{f.Push(f.Locals[8]);f.Pc=158;continue;}
case 158:{f.Pc=f.Pop().Int!=0?224:161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",170);}
case 170:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[7]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",180);}
case 180:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=183;continue;}
case 183:{f.Locals[12]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[12]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[7]);f.Pc=189;continue;}
case 189:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?206:192;continue;}
case 192:{f.Push(f.Locals[12]);f.Pc=194;continue;}
case 194:{f.Locals[7]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[12]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/card/Card","getLastKnownZone","()Lforge/game/zone/Zone;","invokevirtual",201);}
case 201:{f.Locals[11]=f.Pop();f.Pc=203;continue;}
case 203:{f.Pc=224;continue;}
case 206:{f.Push(f.Locals[11]);f.Pc=208;continue;}
case 208:{f.Pc=f.Pop().Reference==null?224:211;continue;}
case 211:{f.Push(f.Locals[11]);f.Pc=213;continue;}
case 213:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int==0?224:222;continue;}
case 222:{f.Push(JValue.I(1));f.Pc=223;continue;}
case 223:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 224:{f.Push(f.Locals[7]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[9]);f.Pc=228;continue;}
case 228:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?236:231;continue;}
case 231:{f.Push(f.Locals[10]);f.Pc=233;continue;}
case 233:{f.Pc=241;continue;}
case 236:{f.Push(f.Locals[7]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/card/Card","getReplacementEffects","()Lforge/util/collect/FCollectionView;","invokevirtual",241);}
case 241:{f.Locals[12]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[12]);f.Pc=245;continue;}
case 245:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/util/List")?1:0));f.Pc=248;continue;}
case 248:{f.Pc=f.Pop().Int==0?310:251;continue;}
case 251:{f.Push(f.Locals[12]);f.Pc=253;continue;}
case 253:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=256;continue;}
case 256:{f.Locals[13]=f.Pop();f.Pc=258;continue;}
case 258:{f.Push(JValue.I(0));f.Pc=259;continue;}
case 259:{f.Locals[14]=f.Pop();f.Pc=261;continue;}
case 261:{f.Push(f.Locals[14]);f.Pc=263;continue;}
case 263:{f.Push(f.Locals[13]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",270);}
case 270:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?308:273;continue;}
case 273:{f.Push(f.Locals[0]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[13]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[14]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",283);}
case 283:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=286;continue;}
case 286:{f.Push(f.Locals[2]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[3]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[4]);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[11]);f.Pc=292;continue;}
case 292:{f.Push(f.Locals[5]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","collectReplacer","(Lforge/game/replacement/ReplacementEffect;Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;Lforge/game/zone/Zone;Ljava/util/List;)Z","invokevirtual",297);}
case 297:{f.Pc=f.Pop().Int!=0?302:300;continue;}
case 300:{f.Push(JValue.I(0));f.Pc=301;continue;}
case 301:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 302:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=305;continue;}
case 305:{f.Pc=261;continue;}
case 308:{f.Push(JValue.I(1));f.Pc=309;continue;}
case 309:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 310:{f.Push(f.Locals[12]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",317);}
case 317:{f.Locals[13]=f.Pop();f.Pc=319;continue;}
case 319:{f.Push(f.Locals[13]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",326);}
case 326:{f.Pc=f.Pop().Int==0?363:329;continue;}
case 329:{f.Push(f.Locals[13]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",336);}
case 336:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=339;continue;}
case 339:{f.Locals[14]=f.Pop();f.Pc=341;continue;}
case 341:{f.Push(f.Locals[0]);f.Pc=342;continue;}
case 342:{f.Push(f.Locals[14]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[2]);f.Pc=345;continue;}
case 345:{f.Push(f.Locals[3]);f.Pc=346;continue;}
case 346:{f.Push(f.Locals[4]);f.Pc=348;continue;}
case 348:{f.Push(f.Locals[11]);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[5]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","collectReplacer","(Lforge/game/replacement/ReplacementEffect;Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;Lforge/game/zone/Zone;Ljava/util/List;)Z","invokevirtual",355);}
case 355:{f.Pc=f.Pop().Int!=0?360:358;continue;}
case 358:{f.Push(JValue.I(0));f.Pc=359;continue;}
case 359:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 360:{f.Pc=319;continue;}
case 363:{f.Push(JValue.I(1));f.Pc=364;continue;}
case 364:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

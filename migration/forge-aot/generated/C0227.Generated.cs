// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C227{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChangeZoneEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3102,"forge/game/ability/effects/ChangeZoneEffect","<init>","()V",1,1,1,new JHandler[]{},M3102));
c.Add(new JMethod(3103,"forge/game/ability/effects/ChangeZoneEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,2,new JHandler[]{},M3103));
c.Add(new JMethod(3104,"forge/game/ability/effects/ChangeZoneEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M3104));
c.Add(new JMethod(3105,"forge/game/ability/effects/ChangeZoneEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M3105));
c.Add(new JMethod(3106,"forge/game/ability/effects/ChangeZoneEffect","changeHiddenOriginStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",10,27,4,new JHandler[]{},M3106));
c.Add(new JMethod(3107,"forge/game/ability/effects/ChangeZoneEffect","changeKnownOriginStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",10,11,4,new JHandler[]{},M3107));
c.Add(new JMethod(3108,"forge/game/ability/effects/ChangeZoneEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M3108));
c.Add(new JMethod(3109,"forge/game/ability/effects/ChangeZoneEffect","changeKnownOriginResolve","(Lforge/game/spellability/SpellAbility;)V",2,34,10,new JHandler[]{},M3109));
c.Add(new JMethod(3110,"forge/game/ability/effects/ChangeZoneEffect","changeHiddenOriginResolve","(Lforge/game/spellability/SpellAbility;)V",2,39,10,new JHandler[]{},M3110));
c.Add(new JMethod(3111,"forge/game/ability/effects/ChangeZoneEffect","handleCastWhileSearching","(Lforge/game/card/CardCollection;Lforge/game/player/Player;)V",2,8,9,new JHandler[]{},M3111));
c.Add(new JMethod(3112,"forge/game/ability/effects/ChangeZoneEffect","allowMultiSelect","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Z",10,2,2,new JHandler[]{},M3112));
c.Add(new JMethod(3113,"forge/game/ability/effects/ChangeZoneEffect","removeFromStack","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;Lforge/game/zone/ZoneType;ILforge/game/Game;Lforge/game/card/CardZoneTable;Lforge/game/GameEntityCounterTable;)V",2,17,5,new JHandler[]{},M3113));
c.Add(new JMethod(3114,"forge/game/ability/effects/ChangeZoneEffect","handleAltDest","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/zone/ZoneType;ILforge/game/player/Player;Lforge/game/card/CardCollectionView;)Lorg/apache/commons/lang3/tuple/Pair;",2,16,7,new JHandler[]{},M3114));
c.Add(new JMethod(3115,"forge/game/ability/effects/ChangeZoneEffect","$deserializeLambda$","(Ljava/lang/invoke/SerializedLambda;)Ljava/lang/Object;",4106,3,3,new JHandler[]{},M3115));
c.Add(new JMethod(3116,"forge/game/ability/effects/ChangeZoneEffect","lambda$changeHiddenOriginResolve$1","(ILforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M3116));
c.Add(new JMethod(3117,"forge/game/ability/effects/ChangeZoneEffect","lambda$changeHiddenOriginResolve$0","(Lforge/game/card/CardCollectionView;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M3117));
c.Add(new JMethod(3118,"forge/game/ability/effects/ChangeZoneEffect","lambda$changeKnownOriginResolve$f894d637$1","(Lforge/game/Game;Lforge/game/card/Card;)V",4106,2,2,new JHandler[]{},M3118));
}

internal static JStep M3102(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3103(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Origin")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","zoneParamIsLibrary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z","invokestatic",6);}
case 6:{f.Pc=f.Pop().Int!=0?18:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Destination")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","zoneParamIsLibrary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z","invokestatic",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3104(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",9);}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/AbilityFactory","adjustChangeZoneTarget","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V","invokestatic",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3105(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isHidden","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?12:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","changeHiddenOriginStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokestatic",11);}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","changeKnownOriginStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokestatic",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3106(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Optional")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("DefinedPlayer")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?45:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("DefinedPlayer")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",43);}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Pc=f.Pop().Reference!=null?69:50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?69:57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",61);}
case 61:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetPlayers","()Ljava/lang/Iterable;","invokevirtual",64);}
case 64:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",67);}
case 67:{f.Locals[4]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Pc=f.Pop().Reference!=null?90:74;continue;}
case 74:{f.Push(JValue.I(1));f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.NewArray("Lforge/game/player/Player;",f.Pop().Int)));f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[2]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",84);}
case 84:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=85;continue;}
case 85:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",88);}
case 88:{f.Locals[4]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",97);}
case 97:{f.Pc=f.Pop().Int==0?105:100;continue;}
case 100:{f.Push(JValue.R(rt.String("that player")));f.Pc=102;continue;}
case 102:{f.Pc=115;continue;}
case 105:{f.Push(f.Locals[4]);f.Pc=107;continue;}
case 107:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:107:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",112);}
case 112:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;)Ljava/lang/String;","invokestatic",115);}
case 115:{f.Locals[5]=f.Pop();f.Pc=117;continue;}
case 117:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",120);}
case 120:{f.Locals[6]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?144:131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",138);}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",142);}
case 142:{f.Locals[6]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[6]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",151);}
case 151:{f.Pc=f.Pop().Int==0?164:154;continue;}
case 154:{f.Push(f.Locals[6]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[4]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",163);}
case 163:{f.StackOp("pop");f.Pc=164;continue;}
case 164:{f.Push(f.Locals[6]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",171);}
case 171:{f.Push(JValue.I(1));f.Pc=172;continue;}
case 172:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?179:175;continue;}
case 175:{f.Push(JValue.I(1));f.Pc=176;continue;}
case 176:{f.Pc=180;continue;}
case 179:{f.Push(JValue.I(0));f.Pc=180;continue;}
case 180:{f.Locals[7]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[6]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",187);}
case 187:{f.Locals[8]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[5]);f.Pc=191;continue;}
case 191:{f.Locals[9]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(f.Locals[8]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[5]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",200);}
case 200:{f.Pc=f.Pop().Int==0?207:203;continue;}
case 203:{f.Push(JValue.R(rt.String("their")));f.Pc=205;continue;}
case 205:{f.Locals[9]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(JValue.R(rt.String("")));f.Pc=209;continue;}
case 209:{f.Locals[10]=f.Pop();f.Pc=211;continue;}
case 211:{f.Push(f.Locals[0]);f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.String("Origin")));f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",217);}
case 217:{f.Pc=f.Pop().Int==0?228:220;continue;}
case 220:{f.Push(f.Locals[0]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String("Origin")));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",226);}
case 226:{f.Locals[10]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[0]);f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.String("Destination")));f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",234);}
case 234:{f.Locals[11]=f.Pop();f.Pc=236;continue;}
case 236:{f.Push(f.Locals[7]);f.Pc=238;continue;}
case 238:{f.Pc=f.Pop().Int==0?249:241;continue;}
case 241:{f.Push(f.Locals[3]);f.Pc=242;continue;}
case 242:{f.Pc=f.Pop().Int!=0?249:245;continue;}
case 245:{f.Push(JValue.I(1));f.Pc=246;continue;}
case 246:{f.Pc=250;continue;}
case 249:{f.Push(JValue.I(0));f.Pc=250;continue;}
case 250:{f.Locals[12]=f.Pop();f.Pc=252;continue;}
case 252:{f.Push(f.Locals[3]);f.Pc=253;continue;}
case 253:{f.Pc=f.Pop().Int==0?261:256;continue;}
case 256:{f.Push(JValue.R(rt.String(" may")));f.Pc=258;continue;}
case 258:{f.Pc=263;continue;}
case 261:{f.Push(JValue.R(rt.String("")));f.Pc=263;continue;}
case 263:{f.Locals[13]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[0]);f.Pc=266;continue;}
case 266:{f.Push(JValue.R(rt.String("ChangeNum")));f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",271);}
case 271:{f.Pc=f.Pop().Int==0?288:274;continue;}
case 274:{f.Push(f.Locals[2]);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[0]);f.Pc=276;continue;}
case 276:{f.Push(JValue.R(rt.String("ChangeNum")));f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",281);}
case 281:{f.Push(f.Locals[0]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",285);}
case 285:{f.Pc=289;continue;}
case 288:{f.Push(JValue.I(1));f.Pc=289;continue;}
case 289:{f.Locals[14]=f.Pop();f.Pc=291;continue;}
case 291:{f.Push(JValue.R(rt.String("card")));f.Pc=293;continue;}
case 293:{f.Locals[15]=f.Pop();f.Pc=295;continue;}
case 295:{f.Push(JValue.I(0));f.Pc=296;continue;}
case 296:{f.Locals[16]=f.Pop();f.Pc=298;continue;}
case 298:{f.Push(f.Locals[0]);f.Pc=299;continue;}
case 299:{f.Push(JValue.R(rt.String("ChangeTypeDesc")));f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",304);}
case 304:{f.Pc=f.Pop().Int==0?352:307;continue;}
case 307:{f.Push(f.Locals[0]);f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("ChangeTypeDesc")));f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",313);}
case 313:{f.Locals[15]=f.Pop();f.Pc=315;continue;}
case 315:{f.Push(f.Locals[15]);f.Pc=317;continue;}
case 317:{f.Push(JValue.R(rt.String("{")));f.Pc=319;continue;}
case 319:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",322);}
case 322:{f.Pc=f.Pop().Int==0?445:325;continue;}
case 325:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=328;continue;}
case 328:{f.StackOp("dup");f.Pc=329;continue;}
case 329:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",332);}
case 332:{f.Locals[17]=f.Pop();f.Pc=334;continue;}
case 334:{f.Push(f.Locals[0]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[17]);f.Pc=337;continue;}
case 337:{f.Push(f.Locals[15]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","tokenizeString","(Lforge/game/spellability/SpellAbility;Ljava/lang/StringBuilder;Ljava/lang/String;)V","invokestatic",342);}
case 342:{f.Push(f.Locals[17]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",347);}
case 347:{f.Locals[15]=f.Pop();f.Pc=349;continue;}
case 349:{f.Pc=445;continue;}
case 352:{f.Push(f.Locals[0]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",356);}
case 356:{f.Pc=f.Pop().Int!=0?368:359;continue;}
case 359:{f.Push(f.Locals[0]);f.Pc=360;continue;}
case 360:{f.Push(JValue.R(rt.String("Defined")));f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",365);}
case 365:{f.Pc=f.Pop().Int==0?389:368;continue;}
case 368:{f.Push(f.Locals[0]);f.Pc=369;continue;}
case 369:{f.Push(JValue.R(rt.String("Defined")));f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",374);}
case 374:{f.Locals[17]=f.Pop();f.Pc=376;continue;}
case 376:{f.Push(f.Locals[17]);f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",381);}
case 381:{f.Locals[15]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(JValue.I(1));f.Pc=384;continue;}
case 384:{f.Locals[16]=f.Pop();f.Pc=386;continue;}
case 386:{f.Pc=445;continue;}
case 389:{f.Push(f.Locals[0]);f.Pc=390;continue;}
case 390:{f.Push(JValue.R(rt.String("ChangeType")));f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",395);}
case 395:{f.Pc=f.Pop().Int==0?445:398;continue;}
case 398:{f.Push(f.Locals[0]);f.Pc=399;continue;}
case 399:{f.Push(JValue.R(rt.String("ChangeType")));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",404);}
case 404:{f.Push(JValue.R(rt.String("Card")));f.Pc=406;continue;}
case 406:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",409);}
case 409:{f.Pc=f.Pop().Int!=0?445:412;continue;}
case 412:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",415);}
case 415:{f.Push(f.Locals[0]);f.Pc=416;continue;}
case 416:{f.Push(JValue.R(rt.String("ChangeType")));f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",421);}
case 421:{f.Push(JValue.R(rt.String(",")));f.Pc=423;continue;}
case 423:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",426);}
case 426:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",429);}
case 429:{f.Push(f.Locals[14]);f.Pc=431;continue;}
case 431:{f.Push(JValue.I(1));f.Pc=432;continue;}
case 432:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?439:435;continue;}
case 435:{f.Push(JValue.I(1));f.Pc=436;continue;}
case 436:{f.Pc=440;continue;}
case 439:{f.Push(JValue.I(0));f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/util/Lang","buildValidCardDesc","(Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",443);}
case 443:{f.Locals[15]=f.Pop();f.Pc=445;continue;}
case 445:{f.Push(f.Locals[15]);f.Pc=447;continue;}
case 447:{f.Push(JValue.R(rt.String("card")));f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",452);}
case 452:{f.Pc=f.Pop().Int==0?460:455;continue;}
case 455:{f.Push(JValue.R(rt.String("")));f.Pc=457;continue;}
case 457:{f.Pc=462;continue;}
case 460:{f.Push(JValue.R(rt.String(" card")));f.Pc=462;continue;}
case 462:{f.Locals[17]=f.Pop();f.Pc=464;continue;}
case 464:{f.Push(f.Locals[0]);f.Pc=465;continue;}
case 465:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=467;continue;}
case 467:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",470);}
case 470:{f.Locals[18]=f.Pop();f.Pc=472;continue;}
case 472:{f.Push(f.Locals[0]);f.Pc=473;continue;}
case 473:{f.Push(JValue.R(rt.String("Attacking")));f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",478);}
case 478:{f.Locals[19]=f.Pop();f.Pc=480;continue;}
case 480:{f.Push(f.Locals[0]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"forge/game/spellability/SpellAbility","isNinjutsu","()Z","invokevirtual",484);}
case 484:{f.Pc=f.Pop().Int==0?493:487;continue;}
case 487:{f.Push(JValue.I(1));f.Pc=488;continue;}
case 488:{f.Locals[18]=f.Pop();f.Pc=490;continue;}
case 490:{f.Push(JValue.I(1));f.Pc=491;continue;}
case 491:{f.Locals[19]=f.Pop();f.Pc=493;continue;}
case 493:{f.Push(f.Locals[10]);f.Pc=495;continue;}
case 495:{f.Push(JValue.R(rt.String("Library")));f.Pc=497;continue;}
case 497:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",500);}
case 500:{f.Pc=f.Pop().Int==0?575:503;continue;}
case 503:{f.Push(f.Locals[0]);f.Pc=504;continue;}
case 504:{f.Push(JValue.R(rt.String("Defined")));f.Pc=506;continue;}
case 506:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",509);}
case 509:{f.Pc=f.Pop().Int==0?575:512;continue;}
case 512:{f.Push(f.Locals[11]);f.Pc=514;continue;}
case 514:{f.Push(JValue.R(rt.String("Exile")));f.Pc=516;continue;}
case 516:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",519);}
case 519:{f.Pc=f.Pop().Int==0?555:522;continue;}
case 522:{f.Push(f.Locals[1]);f.Pc=523;continue;}
case 523:{f.Push(JValue.R(rt.String("Exile the top card of your library")));f.Pc=525;continue;}
case 525:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",528);}
case 528:{f.StackOp("pop");f.Pc=529;continue;}
case 529:{f.Push(f.Locals[0]);f.Pc=530;continue;}
case 530:{f.Push(JValue.R(rt.String("ExileFaceDown")));f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",535);}
case 535:{f.Pc=f.Pop().Int==0?545:538;continue;}
case 538:{f.Push(f.Locals[1]);f.Pc=539;continue;}
case 539:{f.Push(JValue.R(rt.String(" face down")));f.Pc=541;continue;}
case 541:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",544);}
case 544:{f.StackOp("pop");f.Pc=545;continue;}
case 545:{f.Push(f.Locals[1]);f.Pc=546;continue;}
case 546:{f.Push(JValue.R(rt.String(".")));f.Pc=548;continue;}
case 548:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",551);}
case 551:{f.StackOp("pop");f.Pc=552;continue;}
case 552:{f.Pc=2783;continue;}
case 555:{f.Push(f.Locals[11]);f.Pc=557;continue;}
case 557:{f.Push(JValue.R(rt.String("Ante")));f.Pc=559;continue;}
case 559:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",562);}
case 562:{f.Pc=f.Pop().Int==0?2783:565;continue;}
case 565:{f.Push(f.Locals[1]);f.Pc=566;continue;}
case 566:{f.Push(JValue.R(rt.String("Add the top card of your library to the ante.")));f.Pc=568;continue;}
case 568:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",571);}
case 571:{f.StackOp("pop");f.Pc=572;continue;}
case 572:{f.Pc=2783;continue;}
case 575:{f.Push(f.Locals[10]);f.Pc=577;continue;}
case 577:{f.Push(JValue.R(rt.String("Library")));f.Pc=579;continue;}
case 579:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",582);}
case 582:{f.Pc=f.Pop().Int==0?1125:585;continue;}
case 585:{f.Push(f.Locals[0]);f.Pc=586;continue;}
case 586:{f.Push(JValue.R(rt.String("OriginAlternative")));f.Pc=588;continue;}
case 588:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",591);}
case 591:{f.Locals[20]=f.Pop();f.Pc=593;continue;}
case 593:{f.Push(f.Locals[1]);f.Pc=594;continue;}
case 594:{f.Push(f.Locals[8]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",599);}
case 599:{f.Push(f.Locals[3]);f.Pc=600;continue;}
case 600:{f.Pc=f.Pop().Int==0?608:603;continue;}
case 603:{f.Push(JValue.R(rt.String(" may search ")));f.Pc=605;continue;}
case 605:{f.Pc=625;continue;}
case 608:{f.Push(f.Locals[12]);f.Pc=610;continue;}
case 610:{f.Pc=f.Pop().Int==0?618:613;continue;}
case 613:{f.Push(JValue.R(rt.String("es ")));f.Pc=615;continue;}
case 615:{f.Pc=620;continue;}
case 618:{f.Push(JValue.R(rt.String(" ")));f.Pc=620;continue;}
case 620:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:620:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",625);}
case 625:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",628);}
case 628:{f.StackOp("pop");f.Pc=629;continue;}
case 629:{f.Push(f.Locals[1]);f.Pc=630;continue;}
case 630:{f.Push(f.Locals[9]);f.Pc=632;continue;}
case 632:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",635);}
case 635:{f.Push(f.Locals[9]);f.Pc=637;continue;}
case 637:{f.Push(f.Locals[8]);f.Pc=639;continue;}
case 639:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",642);}
case 642:{f.Pc=f.Pop().Int==0?650:645;continue;}
case 645:{f.Push(JValue.R(rt.String("'s ")));f.Pc=647;continue;}
case 647:{f.Pc=652;continue;}
case 650:{f.Push(JValue.R(rt.String(" ")));f.Pc=652;continue;}
case 652:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",655);}
case 655:{f.Push(JValue.R(rt.String("library")));f.Pc=657;continue;}
case 657:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",660);}
case 660:{f.StackOp("pop");f.Pc=661;continue;}
case 661:{f.Push(f.Locals[20]);f.Pc=663;continue;}
case 663:{f.Pc=f.Pop().Int==0?695:666;continue;}
case 666:{f.Push(f.Locals[1]);f.Pc=667;continue;}
case 667:{f.Push(f.Locals[0]);f.Pc=668;continue;}
case 668:{f.Push(JValue.R(rt.String("OriginAlternative")));f.Pc=670;continue;}
case 670:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",673);}
case 673:{f.Push(JValue.R(rt.String("Hand")));f.Pc=675;continue;}
case 675:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",678);}
case 678:{f.Pc=f.Pop().Int==0?686:681;continue;}
case 681:{f.Push(JValue.R(rt.String(", hand, and/or graveyard for ")));f.Pc=683;continue;}
case 683:{f.Pc=688;continue;}
case 686:{f.Push(JValue.R(rt.String(" and/or graveyard for ")));f.Pc=688;continue;}
case 688:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",691);}
case 691:{f.StackOp("pop");f.Pc=692;continue;}
case 692:{f.Pc=702;continue;}
case 695:{f.Push(f.Locals[1]);f.Pc=696;continue;}
case 696:{f.Push(JValue.R(rt.String(" for ")));f.Pc=698;continue;}
case 698:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",701);}
case 701:{f.StackOp("pop");f.Pc=702;continue;}
case 702:{f.Push(f.Locals[14]);f.Pc=704;continue;}
case 704:{f.Push(JValue.I(1));f.Pc=705;continue;}
case 705:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?715:708;continue;}
case 708:{f.Push(f.Locals[1]);f.Pc=709;continue;}
case 709:{f.Push(JValue.R(rt.String(" up to ")));f.Pc=711;continue;}
case 711:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",714);}
case 714:{f.StackOp("pop");f.Pc=715;continue;}
case 715:{f.Push(f.Locals[1]);f.Pc=716;continue;}
case 716:{f.Push(f.Locals[14]);f.Pc=718;continue;}
case 718:{f.Push(f.Locals[15]);f.Pc=720;continue;}
case 720:{f.Push(f.Locals[17]);f.Pc=722;continue;}
case 722:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:722:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",727);}
case 727:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",730);}
case 730:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",733);}
case 733:{f.Push(JValue.R(rt.String(", ")));f.Pc=736;continue;}
case 736:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",739);}
case 739:{f.StackOp("pop");f.Pc=740;continue;}
case 740:{f.Push(f.Locals[0]);f.Pc=741;continue;}
case 741:{f.Push(JValue.R(rt.String("NoReveal")));f.Pc=744;continue;}
case 744:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",747);}
case 747:{f.Pc=f.Pop().Int!=0?817:750;continue;}
case 750:{f.Push(f.Locals[11]);f.Pc=752;continue;}
case 752:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",755);}
case 755:{f.Pc=f.Pop().Reference==null?817:758;continue;}
case 758:{f.Push(f.Locals[11]);f.Pc=760;continue;}
case 760:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",763);}
case 763:{return rt.Call(f,"forge/game/zone/ZoneType","isHidden","()Z","invokevirtual",766);}
case 766:{f.Pc=f.Pop().Int==0?817:769;continue;}
case 769:{f.Push(f.Locals[12]);f.Pc=771;continue;}
case 771:{f.Pc=f.Pop().Int==0?797:774;continue;}
case 774:{f.Push(f.Locals[1]);f.Pc=775;continue;}
case 775:{f.Push(f.Locals[14]);f.Pc=777;continue;}
case 777:{f.Push(JValue.I(1));f.Pc=778;continue;}
case 778:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?787:781;continue;}
case 781:{f.Push(JValue.R(rt.String("reveals them, ")));f.Pc=784;continue;}
case 784:{f.Pc=790;continue;}
case 787:{f.Push(JValue.R(rt.String("reveals it, ")));f.Pc=790;continue;}
case 790:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",793);}
case 793:{f.StackOp("pop");f.Pc=794;continue;}
case 794:{f.Pc=817;continue;}
case 797:{f.Push(f.Locals[1]);f.Pc=798;continue;}
case 798:{f.Push(f.Locals[14]);f.Pc=800;continue;}
case 800:{f.Push(JValue.I(1));f.Pc=801;continue;}
case 801:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?810:804;continue;}
case 804:{f.Push(JValue.R(rt.String("reveal them, ")));f.Pc=807;continue;}
case 807:{f.Pc=813;continue;}
case 810:{f.Push(JValue.R(rt.String("reveal it, ")));f.Pc=813;continue;}
case 813:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",816);}
case 816:{f.StackOp("pop");f.Pc=817;continue;}
case 817:{f.Push(f.Locals[11]);f.Pc=819;continue;}
case 819:{f.Push(JValue.R(rt.String("Exile")));f.Pc=821;continue;}
case 821:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",824);}
case 824:{f.Pc=f.Pop().Int==0?877:827;continue;}
case 827:{f.Push(f.Locals[14]);f.Pc=829;continue;}
case 829:{f.Push(JValue.I(1));f.Pc=830;continue;}
case 830:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?855:833;continue;}
case 833:{f.Push(f.Locals[1]);f.Pc=834;continue;}
case 834:{f.Push(f.Locals[12]);f.Pc=836;continue;}
case 836:{f.Pc=f.Pop().Int==0?845:839;continue;}
case 839:{f.Push(JValue.R(rt.String("exiles it")));f.Pc=842;continue;}
case 842:{f.Pc=848;continue;}
case 845:{f.Push(JValue.R(rt.String("exile it")));f.Pc=848;continue;}
case 848:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",851);}
case 851:{f.StackOp("pop");f.Pc=852;continue;}
case 852:{f.Pc=1087;continue;}
case 855:{f.Push(f.Locals[1]);f.Pc=856;continue;}
case 856:{f.Push(f.Locals[12]);f.Pc=858;continue;}
case 858:{f.Pc=f.Pop().Int==0?867:861;continue;}
case 861:{f.Push(JValue.R(rt.String("exiles them")));f.Pc=864;continue;}
case 864:{f.Pc=870;continue;}
case 867:{f.Push(JValue.R(rt.String("exile them")));f.Pc=870;continue;}
case 870:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",873);}
case 873:{f.StackOp("pop");f.Pc=874;continue;}
case 874:{f.Pc=1087;continue;}
case 877:{f.Push(f.Locals[12]);f.Pc=879;continue;}
case 879:{f.Pc=f.Pop().Int==0?888:882;continue;}
case 882:{f.Push(JValue.R(rt.String("puts ")));f.Pc=885;continue;}
case 885:{f.Pc=891;continue;}
case 888:{f.Push(JValue.R(rt.String("put ")));f.Pc=891;continue;}
case 891:{f.Locals[21]=f.Pop();f.Pc=893;continue;}
case 893:{f.Push(f.Locals[1]);f.Pc=894;continue;}
case 894:{f.Push(f.Locals[14]);f.Pc=896;continue;}
case 896:{f.Push(JValue.I(1));f.Pc=897;continue;}
case 897:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?910:900;continue;}
case 900:{f.Push(f.Locals[21]);f.Pc=902;continue;}
case 902:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:902:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",907);}
case 907:{f.Pc=917;continue;}
case 910:{f.Push(f.Locals[21]);f.Pc=912;continue;}
case 912:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:912:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",917);}
case 917:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",920);}
case 920:{f.StackOp("pop");f.Pc=921;continue;}
case 921:{f.Push(f.Locals[11]);f.Pc=923;continue;}
case 923:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=926;continue;}
case 926:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",929);}
case 929:{f.Pc=f.Pop().Int==0?1016:932;continue;}
case 932:{f.Push(f.Locals[1]);f.Pc=933;continue;}
case 933:{f.Push(JValue.R(rt.String("onto the battlefield")));f.Pc=936;continue;}
case 936:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",939);}
case 939:{f.StackOp("pop");f.Pc=940;continue;}
case 940:{f.Push(f.Locals[18]);f.Pc=942;continue;}
case 942:{f.Pc=f.Pop().Int==0?969:945;continue;}
case 945:{f.Push(f.Locals[1]);f.Pc=946;continue;}
case 946:{f.Push(JValue.R(rt.String(" tapped")));f.Pc=949;continue;}
case 949:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",952);}
case 952:{f.Push(f.Locals[19]);f.Pc=954;continue;}
case 954:{f.Pc=f.Pop().Int==0?963:957;continue;}
case 957:{f.Push(JValue.R(rt.String(" and")));f.Pc=960;continue;}
case 960:{f.Pc=965;continue;}
case 963:{f.Push(JValue.R(rt.String("")));f.Pc=965;continue;}
case 965:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",968);}
case 968:{f.StackOp("pop");f.Pc=969;continue;}
case 969:{f.Push(f.Locals[1]);f.Pc=970;continue;}
case 970:{f.Push(f.Locals[19]);f.Pc=972;continue;}
case 972:{f.Pc=f.Pop().Int==0?981:975;continue;}
case 975:{f.Push(JValue.R(rt.String(" attacking")));f.Pc=978;continue;}
case 978:{f.Pc=983;continue;}
case 981:{f.Push(JValue.R(rt.String("")));f.Pc=983;continue;}
case 983:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",986);}
case 986:{f.StackOp("pop");f.Pc=987;continue;}
case 987:{f.Push(f.Locals[0]);f.Pc=988;continue;}
case 988:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=991;continue;}
case 991:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",994);}
case 994:{f.Pc=f.Pop().Int==0?1016:997;continue;}
case 997:{f.Push(f.Locals[1]);f.Pc=998;continue;}
case 998:{f.Push(JValue.R(rt.String(" under ")));f.Pc=1001;continue;}
case 1001:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1004);}
case 1004:{f.Push(f.Locals[8]);f.Pc=1006;continue;}
case 1006:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1009);}
case 1009:{f.Push(JValue.R(rt.String("'s control")));f.Pc=1012;continue;}
case 1012:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1015);}
case 1015:{f.StackOp("pop");f.Pc=1016;continue;}
case 1016:{f.Push(f.Locals[11]);f.Pc=1018;continue;}
case 1018:{f.Push(JValue.R(rt.String("Hand")));f.Pc=1020;continue;}
case 1020:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1023);}
case 1023:{f.Pc=f.Pop().Int==0?1051:1026;continue;}
case 1026:{f.Push(f.Locals[14]);f.Pc=1028;continue;}
case 1028:{f.Push(JValue.I(1));f.Pc=1029;continue;}
case 1029:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1043:1032;continue;}
case 1032:{f.Push(f.Locals[1]);f.Pc=1033;continue;}
case 1033:{f.Push(JValue.R(rt.String("into their hand")));f.Pc=1036;continue;}
case 1036:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1039);}
case 1039:{f.StackOp("pop");f.Pc=1040;continue;}
case 1040:{f.Pc=1051;continue;}
case 1043:{f.Push(f.Locals[1]);f.Pc=1044;continue;}
case 1044:{f.Push(JValue.R(rt.String("into their owner's hand")));f.Pc=1047;continue;}
case 1047:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1050);}
case 1050:{f.StackOp("pop");f.Pc=1051;continue;}
case 1051:{f.Push(f.Locals[11]);f.Pc=1053;continue;}
case 1053:{f.Push(JValue.R(rt.String("Graveyard")));f.Pc=1056;continue;}
case 1056:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1059);}
case 1059:{f.Pc=f.Pop().Int==0?1087:1062;continue;}
case 1062:{f.Push(f.Locals[14]);f.Pc=1064;continue;}
case 1064:{f.Push(JValue.I(1));f.Pc=1065;continue;}
case 1065:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1079:1068;continue;}
case 1068:{f.Push(f.Locals[1]);f.Pc=1069;continue;}
case 1069:{f.Push(JValue.R(rt.String("into its owner's graveyard")));f.Pc=1072;continue;}
case 1072:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1075);}
case 1075:{f.StackOp("pop");f.Pc=1076;continue;}
case 1076:{f.Pc=1087;continue;}
case 1079:{f.Push(f.Locals[1]);f.Pc=1080;continue;}
case 1080:{f.Push(JValue.R(rt.String("into their owner's graveyard")));f.Pc=1083;continue;}
case 1083:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1086);}
case 1086:{f.StackOp("pop");f.Pc=1087;continue;}
case 1087:{f.Push(f.Locals[1]);f.Pc=1088;continue;}
case 1088:{f.Push(f.Locals[12]);f.Pc=1090;continue;}
case 1090:{f.Pc=f.Pop().Int==0?1099:1093;continue;}
case 1093:{f.Push(JValue.R(rt.String(", then shuffles")));f.Pc=1096;continue;}
case 1096:{f.Pc=1102;continue;}
case 1099:{f.Push(JValue.R(rt.String(", then shuffle")));f.Pc=1102;continue;}
case 1102:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1105);}
case 1105:{f.Push(f.Locals[20]);f.Pc=1107;continue;}
case 1107:{f.Pc=f.Pop().Int==0?1116:1110;continue;}
case 1110:{f.Push(JValue.R(rt.String(" if they searched their library.")));f.Pc=1113;continue;}
case 1113:{f.Pc=1118;continue;}
case 1116:{f.Push(JValue.R(rt.String(".")));f.Pc=1118;continue;}
case 1118:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1121);}
case 1121:{f.StackOp("pop");f.Pc=1122;continue;}
case 1122:{f.Pc=2783;continue;}
case 1125:{f.Push(f.Locals[10]);f.Pc=1127;continue;}
case 1127:{f.Push(JValue.R(rt.String("Sideboard")));f.Pc=1130;continue;}
case 1130:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1133);}
case 1133:{f.Pc=f.Pop().Int==0?1317:1136;continue;}
case 1136:{f.Push(f.Locals[1]);f.Pc=1137;continue;}
case 1137:{f.Push(f.Locals[8]);f.Pc=1139;continue;}
case 1139:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1142);}
case 1142:{f.StackOp("pop");f.Pc=1143;continue;}
case 1143:{f.Push(f.Locals[0]);f.Pc=1144;continue;}
case 1144:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=1147;continue;}
case 1147:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1150);}
case 1150:{f.Pc=f.Pop().Int==0?1231:1153;continue;}
case 1153:{f.Push(f.Locals[1]);f.Pc=1154;continue;}
case 1154:{f.Push(JValue.R(rt.String(" may reveal ")));f.Pc=1157;continue;}
case 1157:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1160);}
case 1160:{f.Push(f.Locals[14]);f.Pc=1162;continue;}
case 1162:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",1165);}
case 1165:{f.Push(JValue.R(rt.String(" ")));f.Pc=1167;continue;}
case 1167:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1170);}
case 1170:{f.Push(f.Locals[15]);f.Pc=1172;continue;}
case 1172:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1175);}
case 1175:{f.Push(JValue.R(rt.String(" from outside the game and put ")));f.Pc=1178;continue;}
case 1178:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1181);}
case 1181:{f.StackOp("pop");f.Pc=1182;continue;}
case 1182:{f.Push(f.Locals[14]);f.Pc=1184;continue;}
case 1184:{f.Push(JValue.I(1));f.Pc=1185;continue;}
case 1185:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1199:1188;continue;}
case 1188:{f.Push(f.Locals[1]);f.Pc=1189;continue;}
case 1189:{f.Push(JValue.R(rt.String("it ")));f.Pc=1192;continue;}
case 1192:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1195);}
case 1195:{f.StackOp("pop");f.Pc=1196;continue;}
case 1196:{f.Pc=1207;continue;}
case 1199:{f.Push(f.Locals[1]);f.Pc=1200;continue;}
case 1200:{f.Push(JValue.R(rt.String("them ")));f.Pc=1203;continue;}
case 1203:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1206);}
case 1206:{f.StackOp("pop");f.Pc=1207;continue;}
case 1207:{f.Push(f.Locals[1]);f.Pc=1208;continue;}
case 1208:{f.Push(JValue.R(rt.String("into their ")));f.Pc=1211;continue;}
case 1211:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1214);}
case 1214:{f.Push(f.Locals[11]);f.Pc=1216;continue;}
case 1216:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",1219);}
case 1219:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1222);}
case 1222:{f.Push(JValue.R(rt.String(".")));f.Pc=1224;continue;}
case 1224:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1227);}
case 1227:{f.StackOp("pop");f.Pc=1228;continue;}
case 1228:{f.Pc=2783;continue;}
case 1231:{f.Push(f.Locals[0]);f.Pc=1232;continue;}
case 1232:{f.Push(JValue.R(rt.String("Mandatory")));f.Pc=1235;continue;}
case 1235:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1238);}
case 1238:{f.Pc=f.Pop().Int==0?1268:1241;continue;}
case 1241:{f.Push(f.Locals[1]);f.Pc=1242;continue;}
case 1242:{f.Push(JValue.R(rt.String(" put")));f.Pc=1245;continue;}
case 1245:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1248);}
case 1248:{f.Push(f.Locals[7]);f.Pc=1250;continue;}
case 1250:{f.Pc=f.Pop().Int!=0?1258:1253;continue;}
case 1253:{f.Push(JValue.R(rt.String(" ")));f.Pc=1255;continue;}
case 1255:{f.Pc=1261;continue;}
case 1258:{f.Push(JValue.R(rt.String("s ")));f.Pc=1261;continue;}
case 1261:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1264);}
case 1264:{f.StackOp("pop");f.Pc=1265;continue;}
case 1265:{f.Pc=1276;continue;}
case 1268:{f.Push(f.Locals[1]);f.Pc=1269;continue;}
case 1269:{f.Push(JValue.R(rt.String(" may put ")));f.Pc=1272;continue;}
case 1272:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1275);}
case 1275:{f.StackOp("pop");f.Pc=1276;continue;}
case 1276:{f.Push(f.Locals[1]);f.Pc=1277;continue;}
case 1277:{f.Push(f.Locals[14]);f.Pc=1279;continue;}
case 1279:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",1282);}
case 1282:{f.Push(JValue.R(rt.String(" ")));f.Pc=1284;continue;}
case 1284:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1287);}
case 1287:{f.Push(f.Locals[15]);f.Pc=1289;continue;}
case 1289:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1292);}
case 1292:{f.Push(JValue.R(rt.String(" from outside the game into their ")));f.Pc=1295;continue;}
case 1295:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1298);}
case 1298:{f.StackOp("pop");f.Pc=1299;continue;}
case 1299:{f.Push(f.Locals[1]);f.Pc=1300;continue;}
case 1300:{f.Push(f.Locals[11]);f.Pc=1302;continue;}
case 1302:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",1305);}
case 1305:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1308);}
case 1308:{f.Push(JValue.R(rt.String(".")));f.Pc=1310;continue;}
case 1310:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1313);}
case 1313:{f.StackOp("pop");f.Pc=1314;continue;}
case 1314:{f.Pc=2783;continue;}
case 1317:{f.Push(f.Locals[10]);f.Pc=1319;continue;}
case 1319:{f.Push(JValue.R(rt.String("Hand")));f.Pc=1321;continue;}
case 1321:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1324);}
case 1324:{f.Pc=f.Pop().Int==0?1884:1327;continue;}
case 1327:{f.Push(f.Locals[1]);f.Pc=1328;continue;}
case 1328:{f.Push(f.Locals[8]);f.Pc=1330;continue;}
case 1330:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1333);}
case 1333:{f.StackOp("pop");f.Pc=1334;continue;}
case 1334:{f.Push(f.Locals[8]);f.Pc=1336;continue;}
case 1336:{f.Push(f.Locals[5]);f.Pc=1338;continue;}
case 1338:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1341);}
case 1341:{f.Pc=f.Pop().Int!=0?1530:1344;continue;}
case 1344:{f.Push(f.Locals[1]);f.Pc=1345;continue;}
case 1345:{f.Push(f.Locals[3]);f.Pc=1346;continue;}
case 1346:{f.Pc=f.Pop().Int==0?1355:1349;continue;}
case 1349:{f.Push(JValue.R(rt.String(" looks at ")));f.Pc=1352;continue;}
case 1352:{f.Pc=1369;continue;}
case 1355:{f.Push(f.Locals[12]);f.Pc=1357;continue;}
case 1357:{f.Pc=f.Pop().Int==0?1366:1360;continue;}
case 1360:{f.Push(JValue.R(rt.String(" looks at ")));f.Pc=1363;continue;}
case 1363:{f.Pc=1369;continue;}
case 1366:{f.Push(JValue.R(rt.String(" look at ")));f.Pc=1369;continue;}
case 1369:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1372);}
case 1372:{f.Push(f.Locals[5]);f.Pc=1374;continue;}
case 1374:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1377);}
case 1377:{f.Push(JValue.R(rt.String("'s hand and ")));f.Pc=1380;continue;}
case 1380:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1383);}
case 1383:{f.StackOp("pop");f.Pc=1384;continue;}
case 1384:{f.Push(f.Locals[1]);f.Pc=1385;continue;}
case 1385:{f.Push(f.Locals[3]);f.Pc=1386;continue;}
case 1386:{f.Pc=f.Pop().Int==0?1395:1389;continue;}
case 1389:{f.Push(JValue.R(rt.String("may ")));f.Pc=1392;continue;}
case 1392:{f.Pc=1397;continue;}
case 1395:{f.Push(JValue.R(rt.String("")));f.Pc=1397;continue;}
case 1397:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1400);}
case 1400:{f.Push(f.Locals[11]);f.Pc=1402;continue;}
case 1402:{f.Push(JValue.R(rt.String("Exile")));f.Pc=1404;continue;}
case 1404:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1407);}
case 1407:{f.Pc=f.Pop().Int==0?1427:1410;continue;}
case 1410:{f.Push(f.Locals[12]);f.Pc=1412;continue;}
case 1412:{f.Pc=f.Pop().Int==0?1421:1415;continue;}
case 1415:{f.Push(JValue.R(rt.String("exiles ")));f.Pc=1418;continue;}
case 1418:{f.Pc=1441;continue;}
case 1421:{f.Push(JValue.R(rt.String("exile ")));f.Pc=1424;continue;}
case 1424:{f.Pc=1441;continue;}
case 1427:{f.Push(f.Locals[12]);f.Pc=1429;continue;}
case 1429:{f.Pc=f.Pop().Int==0?1438:1432;continue;}
case 1432:{f.Push(JValue.R(rt.String("puts ")));f.Pc=1435;continue;}
case 1435:{f.Pc=1441;continue;}
case 1438:{f.Push(JValue.R(rt.String("put ")));f.Pc=1441;continue;}
case 1441:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1444);}
case 1444:{f.StackOp("pop");f.Pc=1445;continue;}
case 1445:{f.Push(f.Locals[1]);f.Pc=1446;continue;}
case 1446:{f.Push(f.Locals[14]);f.Pc=1448;continue;}
case 1448:{f.Push(JValue.I(1));f.Pc=1449;continue;}
case 1449:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1458:1452;continue;}
case 1452:{f.Push(JValue.R(rt.String("one")));f.Pc=1455;continue;}
case 1455:{f.Pc=1463;continue;}
case 1458:{f.Push(f.Locals[14]);f.Pc=1460;continue;}
case 1460:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",1463);}
case 1463:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1466);}
case 1466:{f.Push(JValue.R(rt.String(" of those ")));f.Pc=1469;continue;}
case 1469:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1472);}
case 1472:{f.StackOp("pop");f.Pc=1473;continue;}
case 1473:{f.Push(f.Locals[15]);f.Pc=1475;continue;}
case 1475:{f.Push(JValue.R(rt.String("(?i)\\s*cards?$")));f.Pc=1478;continue;}
case 1478:{f.Push(JValue.R(rt.String("")));f.Pc=1480;continue;}
case 1480:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1483);}
case 1483:{f.Locals[20]=f.Pop();f.Pc=1485;continue;}
case 1485:{f.Push(f.Locals[1]);f.Pc=1486;continue;}
case 1486:{f.Push(f.Locals[20]);f.Pc=1488;continue;}
case 1488:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1491);}
case 1491:{f.Pc=f.Pop().Int==0?1499:1494;continue;}
case 1494:{f.Push(JValue.R(rt.String("")));f.Pc=1496;continue;}
case 1496:{f.Pc=1506;continue;}
case 1499:{f.Push(f.Locals[20]);f.Pc=1501;continue;}
case 1501:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:1501:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1506);}
case 1506:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1509);}
case 1509:{f.Push(f.Locals[14]);f.Pc=1511;continue;}
case 1511:{f.Push(JValue.I(1));f.Pc=1512;continue;}
case 1512:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1520:1515;continue;}
case 1515:{f.Push(JValue.R(rt.String("card")));f.Pc=1517;continue;}
case 1517:{f.Pc=1523;continue;}
case 1520:{f.Push(JValue.R(rt.String("cards")));f.Pc=1523;continue;}
case 1523:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1526);}
case 1526:{f.StackOp("pop");f.Pc=1527;continue;}
case 1527:{f.Pc=1675;continue;}
case 1530:{f.Push(f.Locals[11]);f.Pc=1532;continue;}
case 1532:{f.Push(JValue.R(rt.String("Exile")));f.Pc=1534;continue;}
case 1534:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1537);}
case 1537:{f.Pc=f.Pop().Int==0?1546:1540;continue;}
case 1540:{f.Push(JValue.R(rt.String(" exiles ")));f.Pc=1543;continue;}
case 1543:{f.Pc=1549;continue;}
case 1546:{f.Push(JValue.R(rt.String(" puts ")));f.Pc=1549;continue;}
case 1549:{f.Locals[20]=f.Pop();f.Pc=1551;continue;}
case 1551:{f.Push(f.Locals[7]);f.Pc=1553;continue;}
case 1553:{f.Pc=f.Pop().Int!=0?1568:1556;continue;}
case 1556:{f.Push(f.Locals[20]);f.Pc=1558;continue;}
case 1558:{f.Push(JValue.R(rt.String("s")));f.Pc=1561;continue;}
case 1561:{f.Push(JValue.R(rt.String("")));f.Pc=1563;continue;}
case 1563:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",1566);}
case 1566:{f.Locals[20]=f.Pop();f.Pc=1568;continue;}
case 1568:{f.Push(f.Locals[3]);f.Pc=1569;continue;}
case 1569:{f.Pc=f.Pop().Int==0?1592:1572;continue;}
case 1572:{f.Push(f.Locals[20]);f.Pc=1574;continue;}
case 1574:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",1577);}
case 1577:{f.Push(JValue.R(rt.String("s$")));f.Pc=1580;continue;}
case 1580:{f.Push(JValue.R(rt.String("")));f.Pc=1582;continue;}
case 1582:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1585);}
case 1585:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:1585:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1590);}
case 1590:{f.Locals[20]=f.Pop();f.Pc=1592;continue;}
case 1592:{f.Push(f.Locals[1]);f.Pc=1593;continue;}
case 1593:{f.Push(f.Locals[20]);f.Pc=1595;continue;}
case 1595:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1598);}
case 1598:{f.StackOp("pop");f.Pc=1599;continue;}
case 1599:{f.Push(f.Locals[16]);f.Pc=1601;continue;}
case 1601:{f.Pc=f.Pop().Int==0?1614:1604;continue;}
case 1604:{f.Push(f.Locals[1]);f.Pc=1605;continue;}
case 1605:{f.Push(f.Locals[15]);f.Pc=1607;continue;}
case 1607:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1610);}
case 1610:{f.StackOp("pop");f.Pc=1611;continue;}
case 1611:{f.Pc=1656;continue;}
case 1614:{f.Push(f.Locals[15]);f.Pc=1616;continue;}
case 1616:{f.Push(JValue.R(rt.String("Card")));f.Pc=1618;continue;}
case 1618:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","containsIgnoreCase","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z","invokestatic",1621);}
case 1621:{f.Pc=f.Pop().Int==0?1639:1624;continue;}
case 1624:{f.Push(f.Locals[1]);f.Pc=1625;continue;}
case 1625:{f.Push(f.Locals[14]);f.Pc=1627;continue;}
case 1627:{f.Push(f.Locals[15]);f.Pc=1629;continue;}
case 1629:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",1632);}
case 1632:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1635);}
case 1635:{f.StackOp("pop");f.Pc=1636;continue;}
case 1636:{f.Pc=1656;continue;}
case 1639:{f.Push(f.Locals[1]);f.Pc=1640;continue;}
case 1640:{f.Push(f.Locals[14]);f.Pc=1642;continue;}
case 1642:{f.Push(f.Locals[15]);f.Pc=1644;continue;}
case 1644:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:1644:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1649);}
case 1649:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",1652);}
case 1652:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1655);}
case 1655:{f.StackOp("pop");f.Pc=1656;continue;}
case 1656:{f.Push(f.Locals[1]);f.Pc=1657;continue;}
case 1657:{f.Push(JValue.R(rt.String(" from ")));f.Pc=1660;continue;}
case 1660:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1663);}
case 1663:{f.Push(f.Locals[9]);f.Pc=1665;continue;}
case 1665:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1668);}
case 1668:{f.Push(JValue.R(rt.String(" hand")));f.Pc=1671;continue;}
case 1671:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1674);}
case 1674:{f.StackOp("pop");f.Pc=1675;continue;}
case 1675:{f.Push(f.Locals[11]);f.Pc=1677;continue;}
case 1677:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=1680;continue;}
case 1680:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1683);}
case 1683:{f.Pc=f.Pop().Int==0?1770:1686;continue;}
case 1686:{f.Push(f.Locals[1]);f.Pc=1687;continue;}
case 1687:{f.Push(JValue.R(rt.String(" onto the battlefield")));f.Pc=1690;continue;}
case 1690:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1693);}
case 1693:{f.StackOp("pop");f.Pc=1694;continue;}
case 1694:{f.Push(f.Locals[18]);f.Pc=1696;continue;}
case 1696:{f.Pc=f.Pop().Int==0?1723:1699;continue;}
case 1699:{f.Push(f.Locals[1]);f.Pc=1700;continue;}
case 1700:{f.Push(JValue.R(rt.String(" tapped")));f.Pc=1703;continue;}
case 1703:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1706);}
case 1706:{f.Push(f.Locals[19]);f.Pc=1708;continue;}
case 1708:{f.Pc=f.Pop().Int==0?1717:1711;continue;}
case 1711:{f.Push(JValue.R(rt.String(" and")));f.Pc=1714;continue;}
case 1714:{f.Pc=1719;continue;}
case 1717:{f.Push(JValue.R(rt.String("")));f.Pc=1719;continue;}
case 1719:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1722);}
case 1722:{f.StackOp("pop");f.Pc=1723;continue;}
case 1723:{f.Push(f.Locals[1]);f.Pc=1724;continue;}
case 1724:{f.Push(f.Locals[19]);f.Pc=1726;continue;}
case 1726:{f.Pc=f.Pop().Int==0?1735:1729;continue;}
case 1729:{f.Push(JValue.R(rt.String(" attacking")));f.Pc=1732;continue;}
case 1732:{f.Pc=1737;continue;}
case 1735:{f.Push(JValue.R(rt.String("")));f.Pc=1737;continue;}
case 1737:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1740);}
case 1740:{f.StackOp("pop");f.Pc=1741;continue;}
case 1741:{f.Push(f.Locals[0]);f.Pc=1742;continue;}
case 1742:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=1745;continue;}
case 1745:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1748);}
case 1748:{f.Pc=f.Pop().Int==0?1770:1751;continue;}
case 1751:{f.Push(f.Locals[1]);f.Pc=1752;continue;}
case 1752:{f.Push(JValue.R(rt.String(" under ")));f.Pc=1755;continue;}
case 1755:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1758);}
case 1758:{f.Push(f.Locals[8]);f.Pc=1760;continue;}
case 1760:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1763);}
case 1763:{f.Push(JValue.R(rt.String("'s control")));f.Pc=1766;continue;}
case 1766:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1769);}
case 1769:{f.StackOp("pop");f.Pc=1770;continue;}
case 1770:{f.Push(f.Locals[11]);f.Pc=1772;continue;}
case 1772:{f.Push(JValue.R(rt.String("Library")));f.Pc=1774;continue;}
case 1774:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1777);}
case 1777:{f.Pc=f.Pop().Int==0?1874:1780;continue;}
case 1780:{f.Push(f.Locals[0]);f.Pc=1781;continue;}
case 1781:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=1784;continue;}
case 1784:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1787);}
case 1787:{f.Pc=f.Pop().Int==0?1805:1790;continue;}
case 1790:{f.Push(f.Locals[2]);f.Pc=1791;continue;}
case 1791:{f.Push(f.Locals[0]);f.Pc=1792;continue;}
case 1792:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=1795;continue;}
case 1795:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1798);}
case 1798:{f.Push(f.Locals[0]);f.Pc=1799;continue;}
case 1799:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1802);}
case 1802:{f.Pc=1806;continue;}
case 1805:{f.Push(JValue.I(0));f.Pc=1806;continue;}
case 1806:{f.Locals[20]=f.Pop();f.Pc=1808;continue;}
case 1808:{f.Push(f.Locals[20]);f.Pc=1810;continue;}
case 1810:{f.Pc=f.Pop().Int!=0?1821:1813;continue;}
case 1813:{f.Push(f.Locals[1]);f.Pc=1814;continue;}
case 1814:{f.Push(JValue.R(rt.String(" on top")));f.Pc=1817;continue;}
case 1817:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1820);}
case 1820:{f.StackOp("pop");f.Pc=1821;continue;}
case 1821:{f.Push(f.Locals[20]);f.Pc=1823;continue;}
case 1823:{f.Push(JValue.I(-1));f.Pc=1824;continue;}
case 1824:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1835:1827;continue;}
case 1827:{f.Push(f.Locals[1]);f.Pc=1828;continue;}
case 1828:{f.Push(JValue.R(rt.String(" on the bottom")));f.Pc=1831;continue;}
case 1831:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1834);}
case 1834:{f.StackOp("pop");f.Pc=1835;continue;}
case 1835:{f.Push(f.Locals[1]);f.Pc=1836;continue;}
case 1836:{f.Push(JValue.R(rt.String(" of ")));f.Pc=1839;continue;}
case 1839:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1842);}
case 1842:{f.Push(f.Locals[9]);f.Pc=1844;continue;}
case 1844:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1847);}
case 1847:{f.StackOp("pop");f.Pc=1848;continue;}
case 1848:{f.Push(f.Locals[9]);f.Pc=1850;continue;}
case 1850:{f.Push(JValue.R(rt.String("their")));f.Pc=1852;continue;}
case 1852:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1855);}
case 1855:{f.Pc=f.Pop().Int!=0?1866:1858;continue;}
case 1858:{f.Push(f.Locals[1]);f.Pc=1859;continue;}
case 1859:{f.Push(JValue.R(rt.String("'s")));f.Pc=1862;continue;}
case 1862:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1865);}
case 1865:{f.StackOp("pop");f.Pc=1866;continue;}
case 1866:{f.Push(f.Locals[1]);f.Pc=1867;continue;}
case 1867:{f.Push(JValue.R(rt.String(" library")));f.Pc=1870;continue;}
case 1870:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1873);}
case 1873:{f.StackOp("pop");f.Pc=1874;continue;}
case 1874:{f.Push(f.Locals[1]);f.Pc=1875;continue;}
case 1875:{f.Push(JValue.R(rt.String(".")));f.Pc=1877;continue;}
case 1877:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1880);}
case 1880:{f.StackOp("pop");f.Pc=1881;continue;}
case 1881:{f.Pc=2783;continue;}
case 1884:{f.Push(f.Locals[10]);f.Pc=1886;continue;}
case 1886:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=1889;continue;}
case 1889:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1892);}
case 1892:{f.Pc=f.Pop().Int==0?2126:1895;continue;}
case 1895:{f.Push(f.Locals[15]);f.Pc=1897;continue;}
case 1897:{f.Locals[20]=f.Pop();f.Pc=1899;continue;}
case 1899:{f.Push(f.Locals[16]);f.Pc=1901;continue;}
case 1901:{f.Pc=f.Pop().Int!=0?1972:1904;continue;}
case 1904:{f.Push(f.Locals[0]);f.Pc=1905;continue;}
case 1905:{f.Push(JValue.R(rt.String("ChangeType")));f.Pc=1907;continue;}
case 1907:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1910);}
case 1910:{f.Pc=f.Pop().Int==0?1972:1913;continue;}
case 1913:{f.Push(f.Locals[0]);f.Pc=1914;continue;}
case 1914:{f.Push(JValue.R(rt.String("ChangeTypeDesc")));f.Pc=1916;continue;}
case 1916:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1919);}
case 1919:{f.Pc=f.Pop().Int!=0?1972:1922;continue;}
case 1922:{f.Push(f.Locals[0]);f.Pc=1923;continue;}
case 1923:{f.Push(JValue.R(rt.String("ChangeType")));f.Pc=1925;continue;}
case 1925:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1928);}
case 1928:{f.Push(JValue.R(rt.String("Card")));f.Pc=1930;continue;}
case 1930:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1933);}
case 1933:{f.Pc=f.Pop().Int!=0?1972:1936;continue;}
case 1936:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",1939);}
case 1939:{f.Push(f.Locals[0]);f.Pc=1940;continue;}
case 1940:{f.Push(JValue.R(rt.String("ChangeType")));f.Pc=1942;continue;}
case 1942:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1945);}
case 1945:{f.Push(JValue.R(rt.String(",")));f.Pc=1947;continue;}
case 1947:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1950);}
case 1950:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",1953);}
case 1953:{f.Push(f.Locals[14]);f.Pc=1955;continue;}
case 1955:{f.Push(JValue.I(1));f.Pc=1956;continue;}
case 1956:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?1963:1959;continue;}
case 1959:{f.Push(JValue.I(1));f.Pc=1960;continue;}
case 1960:{f.Pc=1964;continue;}
case 1963:{f.Push(JValue.I(0));f.Pc=1964;continue;}
case 1964:{return rt.Call(f,"forge/util/Lang","buildValidDesc","(Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",1967);}
case 1967:{f.Locals[20]=f.Pop();f.Pc=1969;continue;}
case 1969:{f.Pc=1987;continue;}
case 1972:{f.Push(f.Locals[15]);f.Pc=1974;continue;}
case 1974:{f.Push(JValue.R(rt.String("card")));f.Pc=1976;continue;}
case 1976:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1979);}
case 1979:{f.Pc=f.Pop().Int==0?1987:1982;continue;}
case 1982:{f.Push(JValue.R(rt.String("permanent")));f.Pc=1985;continue;}
case 1985:{f.Locals[20]=f.Pop();f.Pc=1987;continue;}
case 1987:{f.Push(f.Locals[11]);f.Pc=1989;continue;}
case 1989:{f.Push(JValue.R(rt.String("Exile")));f.Pc=1991;continue;}
case 1991:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1994);}
case 1994:{f.Locals[21]=f.Pop();f.Pc=1996;continue;}
case 1996:{f.Push(f.Locals[21]);f.Pc=1998;continue;}
case 1998:{f.Pc=f.Pop().Int==0?2007:2001;continue;}
case 2001:{f.Push(JValue.R(rt.String("exile")));f.Pc=2004;continue;}
case 2004:{f.Pc=2010;continue;}
case 2007:{f.Push(JValue.R(rt.String("return")));f.Pc=2010;continue;}
case 2010:{f.Locals[22]=f.Pop();f.Pc=2012;continue;}
case 2012:{f.Push(f.Locals[1]);f.Pc=2013;continue;}
case 2013:{f.Push(f.Locals[8]);f.Pc=2015;continue;}
case 2015:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2018);}
case 2018:{f.Push(f.Locals[3]);f.Pc=2019;continue;}
case 2019:{f.Pc=f.Pop().Int==0?2032:2022;continue;}
case 2022:{f.Push(f.Locals[22]);f.Pc=2024;continue;}
case 2024:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:2024:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2029);}
case 2029:{f.Pc=2054;continue;}
case 2032:{f.Push(f.Locals[12]);f.Pc=2034;continue;}
case 2034:{f.Pc=f.Pop().Int==0?2047:2037;continue;}
case 2037:{f.Push(f.Locals[22]);f.Pc=2039;continue;}
case 2039:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:2039:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2044);}
case 2044:{f.Pc=2054;continue;}
case 2047:{f.Push(f.Locals[22]);f.Pc=2049;continue;}
case 2049:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:2049:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2054);}
case 2054:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2057);}
case 2057:{f.StackOp("pop");f.Pc=2058;continue;}
case 2058:{f.Push(f.Locals[1]);f.Pc=2059;continue;}
case 2059:{f.Push(f.Locals[16]);f.Pc=2061;continue;}
case 2061:{f.Pc=f.Pop().Int==0?2069:2064;continue;}
case 2064:{f.Push(f.Locals[20]);f.Pc=2066;continue;}
case 2066:{f.Pc=2076;continue;}
case 2069:{f.Push(f.Locals[14]);f.Pc=2071;continue;}
case 2071:{f.Push(f.Locals[20]);f.Pc=2073;continue;}
case 2073:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",2076);}
case 2076:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2079);}
case 2079:{f.StackOp("pop");f.Pc=2080;continue;}
case 2080:{f.Push(f.Locals[21]);f.Pc=2082;continue;}
case 2082:{f.Pc=f.Pop().Int!=0?2116:2085;continue;}
case 2085:{f.Push(f.Locals[1]);f.Pc=2086;continue;}
case 2086:{f.Push(f.Locals[11]);f.Pc=2088;continue;}
case 2088:{f.Push(JValue.R(rt.String("Hand")));f.Pc=2090;continue;}
case 2090:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2093);}
case 2093:{f.Pc=f.Pop().Int==0?2102:2096;continue;}
case 2096:{f.Push(JValue.R(rt.String(" to their hand")));f.Pc=2099;continue;}
case 2099:{f.Pc=2112;continue;}
case 2102:{f.Push(f.Locals[11]);f.Pc=2104;continue;}
case 2104:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",2107);}
case 2107:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:2107:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2112);}
case 2112:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2115);}
case 2115:{f.StackOp("pop");f.Pc=2116;continue;}
case 2116:{f.Push(f.Locals[1]);f.Pc=2117;continue;}
case 2117:{f.Push(JValue.R(rt.String(".")));f.Pc=2119;continue;}
case 2119:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2122);}
case 2122:{f.StackOp("pop");f.Pc=2123;continue;}
case 2123:{f.Pc=2783;continue;}
case 2126:{f.Push(f.Locals[10]);f.Pc=2128;continue;}
case 2128:{f.Push(JValue.R(rt.String("Graveyard")));f.Pc=2131;continue;}
case 2131:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2134);}
case 2134:{f.Pc=f.Pop().Int==0?2494:2137;continue;}
case 2137:{f.Push(f.Locals[0]);f.Pc=2138;continue;}
case 2138:{f.Push(JValue.R(rt.String("ChangeNumDesc")));f.Pc=2141;continue;}
case 2141:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2144);}
case 2144:{f.Locals[20]=f.Pop();f.Pc=2146;continue;}
case 2146:{f.Push(f.Locals[0]);f.Pc=2147;continue;}
case 2147:{f.Push(JValue.R(rt.String("Mandatory")));f.Pc=2150;continue;}
case 2150:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2153);}
case 2153:{f.Locals[21]=f.Pop();f.Pc=2155;continue;}
case 2155:{f.Push(f.Locals[20]);f.Pc=2157;continue;}
case 2157:{f.Pc=f.Pop().Int==0?2181:2160;continue;}
case 2160:{f.Push(f.Locals[0]);f.Pc=2161;continue;}
case 2161:{f.Push(JValue.R(rt.String("ChangeNumDesc")));f.Pc=2164;continue;}
case 2164:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2167);}
case 2167:{f.Push(f.Locals[15]);f.Pc=2169;continue;}
case 2169:{f.Push(f.Locals[17]);f.Pc=2171;continue;}
case 2171:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:2171:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2176);}
case 2176:{f.Locals[22]=f.Pop();f.Pc=2178;continue;}
case 2178:{f.Pc=2221;continue;}
case 2181:{f.Push(f.Locals[21]);f.Pc=2183;continue;}
case 2183:{f.Pc=f.Pop().Int!=0?2205:2186;continue;}
case 2186:{f.Push(f.Locals[14]);f.Pc=2188;continue;}
case 2188:{f.Push(f.Locals[15]);f.Pc=2190;continue;}
case 2190:{f.Push(f.Locals[17]);f.Pc=2192;continue;}
case 2192:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:2192:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2197);}
case 2197:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",2200);}
case 2200:{f.Locals[22]=f.Pop();f.Pc=2202;continue;}
case 2202:{f.Pc=2221;continue;}
case 2205:{f.Push(f.Locals[14]);f.Pc=2207;continue;}
case 2207:{f.Push(f.Locals[15]);f.Pc=2209;continue;}
case 2209:{f.Push(f.Locals[17]);f.Pc=2211;continue;}
case 2211:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:2211:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2216);}
case 2216:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",2219);}
case 2219:{f.Locals[22]=f.Pop();f.Pc=2221;continue;}
case 2221:{f.Push(f.Locals[11]);f.Pc=2223;continue;}
case 2223:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=2226;continue;}
case 2226:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2229);}
case 2229:{f.Locals[23]=f.Pop();f.Pc=2231;continue;}
case 2231:{f.Push(f.Locals[11]);f.Pc=2233;continue;}
case 2233:{f.Push(JValue.R(rt.String("Hand")));f.Pc=2235;continue;}
case 2235:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2238);}
case 2238:{f.Locals[24]=f.Pop();f.Pc=2240;continue;}
case 2240:{f.Push(f.Locals[11]);f.Pc=2242;continue;}
case 2242:{f.Push(JValue.R(rt.String("Exile")));f.Pc=2244;continue;}
case 2244:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2247);}
case 2247:{f.Pc=f.Pop().Int==0?2256:2250;continue;}
case 2250:{f.Push(JValue.R(rt.String(" exiles ")));f.Pc=2253;continue;}
case 2253:{f.Pc=2259;continue;}
case 2256:{f.Push(JValue.R(rt.String(" returns ")));f.Pc=2259;continue;}
case 2259:{f.Locals[25]=f.Pop();f.Pc=2261;continue;}
case 2261:{f.Push(f.Locals[7]);f.Pc=2263;continue;}
case 2263:{f.Pc=f.Pop().Int!=0?2278:2266;continue;}
case 2266:{f.Push(f.Locals[25]);f.Pc=2268;continue;}
case 2268:{f.Push(JValue.R(rt.String("s")));f.Pc=2271;continue;}
case 2271:{f.Push(JValue.R(rt.String("")));f.Pc=2273;continue;}
case 2273:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",2276);}
case 2276:{f.Locals[25]=f.Pop();f.Pc=2278;continue;}
case 2278:{f.Push(f.Locals[3]);f.Pc=2279;continue;}
case 2279:{f.Pc=f.Pop().Int==0?2302:2282;continue;}
case 2282:{f.Push(f.Locals[25]);f.Pc=2284;continue;}
case 2284:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",2287);}
case 2287:{f.Push(JValue.R(rt.String("s$")));f.Pc=2290;continue;}
case 2290:{f.Push(JValue.R(rt.String("")));f.Pc=2292;continue;}
case 2292:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2295);}
case 2295:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:2295:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2300);}
case 2300:{f.Locals[25]=f.Pop();f.Pc=2302;continue;}
case 2302:{f.Push(f.Locals[1]);f.Pc=2303;continue;}
case 2303:{f.Push(f.Locals[8]);f.Pc=2305;continue;}
case 2305:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2308);}
case 2308:{f.Push(f.Locals[25]);f.Pc=2310;continue;}
case 2310:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2313);}
case 2313:{f.Push(f.Locals[21]);f.Pc=2315;continue;}
case 2315:{f.Pc=f.Pop().Int!=0?2323:2318;continue;}
case 2318:{f.Push(f.Locals[20]);f.Pc=2320;continue;}
case 2320:{f.Pc=f.Pop().Int==0?2328:2323;continue;}
case 2323:{f.Push(JValue.R(rt.String("")));f.Pc=2325;continue;}
case 2325:{f.Pc=2331;continue;}
case 2328:{f.Push(JValue.R(rt.String("up to ")));f.Pc=2331;continue;}
case 2331:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2334);}
case 2334:{f.StackOp("pop");f.Pc=2335;continue;}
case 2335:{f.Push(f.Locals[1]);f.Pc=2336;continue;}
case 2336:{f.Push(f.Locals[22]);f.Pc=2338;continue;}
case 2338:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2341);}
case 2341:{f.StackOp("pop");f.Pc=2342;continue;}
case 2342:{f.Push(f.Locals[1]);f.Pc=2343;continue;}
case 2343:{f.Push(JValue.R(rt.String(" from their graveyard")));f.Pc=2346;continue;}
case 2346:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2349);}
case 2349:{f.Push(f.Locals[6]);f.Pc=2351;continue;}
case 2351:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",2356);}
case 2356:{f.Push(JValue.I(1));f.Pc=2357;continue;}
case 2357:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2366:2360;continue;}
case 2360:{f.Push(JValue.R(rt.String("s")));f.Pc=2363;continue;}
case 2363:{f.Pc=2368;continue;}
case 2366:{f.Push(JValue.R(rt.String("")));f.Pc=2368;continue;}
case 2368:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2371);}
case 2371:{f.StackOp("pop");f.Pc=2372;continue;}
case 2372:{f.Push(f.Locals[11]);f.Pc=2374;continue;}
case 2374:{f.Push(JValue.R(rt.String("Exile")));f.Pc=2376;continue;}
case 2376:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2379);}
case 2379:{f.Pc=f.Pop().Int!=0?2422:2382;continue;}
case 2382:{f.Push(f.Locals[1]);f.Pc=2383;continue;}
case 2383:{f.Push(f.Locals[23]);f.Pc=2385;continue;}
case 2385:{f.Pc=f.Pop().Int==0?2394:2388;continue;}
case 2388:{f.Push(JValue.R(rt.String(" to the ")));f.Pc=2391;continue;}
case 2391:{f.Pc=2408;continue;}
case 2394:{f.Push(f.Locals[24]);f.Pc=2396;continue;}
case 2396:{f.Pc=f.Pop().Int==0?2405:2399;continue;}
case 2399:{f.Push(JValue.R(rt.String(" to their ")));f.Pc=2402;continue;}
case 2402:{f.Pc=2408;continue;}
case 2405:{f.Push(JValue.R(rt.String(" into their ")));f.Pc=2408;continue;}
case 2408:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2411);}
case 2411:{f.StackOp("pop");f.Pc=2412;continue;}
case 2412:{f.Push(f.Locals[1]);f.Pc=2413;continue;}
case 2413:{f.Push(f.Locals[11]);f.Pc=2415;continue;}
case 2415:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",2418);}
case 2418:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2421);}
case 2421:{f.StackOp("pop");f.Pc=2422;continue;}
case 2422:{f.Push(f.Locals[0]);f.Pc=2423;continue;}
case 2423:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=2426;continue;}
case 2426:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2429);}
case 2429:{f.Pc=f.Pop().Int==0?2484:2432;continue;}
case 2432:{f.Push(f.Locals[0]);f.Pc=2433;continue;}
case 2433:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=2436;continue;}
case 2436:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2439);}
case 2439:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",2442);}
case 2442:{f.Locals[26]=f.Pop();f.Pc=2444;continue;}
case 2444:{f.Push(f.Locals[26]);f.Pc=2446;continue;}
case 2446:{f.Pc=f.Pop().Reference==null?2476:2449;continue;}
case 2449:{f.Push(f.Locals[1]);f.Pc=2450;continue;}
case 2450:{f.Push(JValue.R(rt.String(" with an additional ")));f.Pc=2453;continue;}
case 2453:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2456);}
case 2456:{f.Push(f.Locals[26]);f.Pc=2458;continue;}
case 2458:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",2463);}
case 2463:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2466);}
case 2466:{f.Push(JValue.R(rt.String(" counter on it")));f.Pc=2469;continue;}
case 2469:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2472);}
case 2472:{f.StackOp("pop");f.Pc=2473;continue;}
case 2473:{f.Pc=2484;continue;}
case 2476:{f.Push(f.Locals[1]);f.Pc=2477;continue;}
case 2477:{f.Push(JValue.R(rt.String(" [ChangeZoneEffect WithCountersType error]")));f.Pc=2480;continue;}
case 2480:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2483);}
case 2483:{f.StackOp("pop");f.Pc=2484;continue;}
case 2484:{f.Push(f.Locals[1]);f.Pc=2485;continue;}
case 2485:{f.Push(JValue.R(rt.String(".")));f.Pc=2487;continue;}
case 2487:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2490);}
case 2490:{f.StackOp("pop");f.Pc=2491;continue;}
case 2491:{f.Pc=2783;continue;}
case 2494:{f.Push(f.Locals[10]);f.Pc=2496;continue;}
case 2496:{f.Push(JValue.R(rt.String("Exile")));f.Pc=2498;continue;}
case 2498:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2501);}
case 2501:{f.Pc=f.Pop().Int==0?2579:2504;continue;}
case 2504:{f.Push(f.Locals[1]);f.Pc=2505;continue;}
case 2505:{f.Push(f.Locals[8]);f.Pc=2507;continue;}
case 2507:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2510);}
case 2510:{f.Push(f.Locals[3]);f.Pc=2511;continue;}
case 2511:{f.Pc=f.Pop().Int==0?2520:2514;continue;}
case 2514:{f.Push(JValue.R(rt.String(" may put ")));f.Pc=2517;continue;}
case 2517:{f.Pc=2534;continue;}
case 2520:{f.Push(f.Locals[12]);f.Pc=2522;continue;}
case 2522:{f.Pc=f.Pop().Int==0?2531:2525;continue;}
case 2525:{f.Push(JValue.R(rt.String(" puts ")));f.Pc=2528;continue;}
case 2528:{f.Pc=2534;continue;}
case 2531:{f.Push(JValue.R(rt.String(" put ")));f.Pc=2534;continue;}
case 2534:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2537);}
case 2537:{f.Push(f.Locals[14]);f.Pc=2539;continue;}
case 2539:{f.Push(f.Locals[15]);f.Pc=2541;continue;}
case 2541:{f.Push(f.Locals[17]);f.Pc=2543;continue;}
case 2543:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:2543:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2548);}
case 2548:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",2551);}
case 2551:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2554);}
case 2554:{f.StackOp("pop");f.Pc=2555;continue;}
case 2555:{f.Push(f.Locals[1]);f.Pc=2556;continue;}
case 2556:{f.Push(JValue.R(rt.String(" into their ")));f.Pc=2559;continue;}
case 2559:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2562);}
case 2562:{f.Push(f.Locals[11]);f.Pc=2564;continue;}
case 2564:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",2567);}
case 2567:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2570);}
case 2570:{f.Push(JValue.R(rt.String(".")));f.Pc=2572;continue;}
case 2572:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2575);}
case 2575:{f.StackOp("pop");f.Pc=2576;continue;}
case 2576:{f.Pc=2783;continue;}
case 2579:{f.Push(f.Locals[10]);f.Pc=2581;continue;}
case 2581:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",2584);}
case 2584:{f.Pc=f.Pop().Int!=0?2783:2587;continue;}
case 2587:{f.Push(f.Locals[11]);f.Pc=2589;continue;}
case 2589:{f.Pc=f.Pop().Reference==null?2783:2592;continue;}
case 2592:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",2595);}
case 2595:{f.Locals[20]=f.Pop();f.Pc=2597;continue;}
case 2597:{f.Push(f.Locals[10]);f.Pc=2599;continue;}
case 2599:{f.Push(JValue.R(rt.String(",")));f.Pc=2601;continue;}
case 2601:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2604);}
case 2604:{f.Locals[21]=f.Pop();f.Pc=2606;continue;}
case 2606:{f.Push(f.Locals[21]);f.Pc=2608;continue;}
case 2608:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2609;continue;}
case 2609:{f.Locals[22]=f.Pop();f.Pc=2611;continue;}
case 2611:{f.Push(JValue.I(0));f.Pc=2612;continue;}
case 2612:{f.Locals[23]=f.Pop();f.Pc=2614;continue;}
case 2614:{f.Push(f.Locals[23]);f.Pc=2616;continue;}
case 2616:{f.Push(f.Locals[22]);f.Pc=2618;continue;}
case 2618:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?2669:2621;continue;}
case 2621:{f.Push(f.Locals[21]);f.Pc=2623;continue;}
case 2623:{f.Push(f.Locals[23]);f.Pc=2625;continue;}
case 2625:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2626;continue;}
case 2626:{f.Locals[24]=f.Pop();f.Pc=2628;continue;}
case 2628:{f.Push(f.Locals[20]);f.Pc=2630;continue;}
case 2630:{f.Push(JValue.R(rt.String("Command")));f.Pc=2633;continue;}
case 2633:{f.Push(f.Locals[24]);f.Pc=2635;continue;}
case 2635:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2638);}
case 2638:{f.Pc=f.Pop().Int==0?2647:2641;continue;}
case 2641:{f.Push(JValue.R(rt.String("the command zone")));f.Pc=2644;continue;}
case 2644:{f.Pc=2657;continue;}
case 2647:{f.Push(f.Locals[24]);f.Pc=2649;continue;}
case 2649:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",2652);}
case 2652:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:2652:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2657);}
case 2657:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",2662);}
case 2662:{f.StackOp("pop");f.Pc=2663;continue;}
case 2663:{f.Locals[23]=JValue.I(unchecked(f.Locals[23].Int+(1)));f.Pc=2666;continue;}
case 2666:{f.Pc=2614;continue;}
case 2669:{f.Push(f.Locals[1]);f.Pc=2670;continue;}
case 2670:{f.Push(f.Locals[8]);f.Pc=2672;continue;}
case 2672:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2675);}
case 2675:{f.Push(f.Locals[3]);f.Pc=2676;continue;}
case 2676:{f.Pc=f.Pop().Int==0?2685:2679;continue;}
case 2679:{f.Push(JValue.R(rt.String(" may put ")));f.Pc=2682;continue;}
case 2682:{f.Pc=2699;continue;}
case 2685:{f.Push(f.Locals[12]);f.Pc=2687;continue;}
case 2687:{f.Pc=f.Pop().Int==0?2696:2690;continue;}
case 2690:{f.Push(JValue.R(rt.String(" puts ")));f.Pc=2693;continue;}
case 2693:{f.Pc=2699;continue;}
case 2696:{f.Push(JValue.R(rt.String(" put ")));f.Pc=2699;continue;}
case 2699:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2702);}
case 2702:{f.Push(f.Locals[16]);f.Pc=2704;continue;}
case 2704:{f.Pc=f.Pop().Int==0?2712:2707;continue;}
case 2707:{f.Push(f.Locals[15]);f.Pc=2709;continue;}
case 2709:{f.Pc=2726;continue;}
case 2712:{f.Push(f.Locals[14]);f.Pc=2714;continue;}
case 2714:{f.Push(f.Locals[15]);f.Pc=2716;continue;}
case 2716:{f.Push(f.Locals[17]);f.Pc=2718;continue;}
case 2718:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:2718:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",2723);}
case 2723:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",2726);}
case 2726:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2729);}
case 2729:{f.Push(JValue.R(rt.String(" from ")));f.Pc=2732;continue;}
case 2732:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2735);}
case 2735:{f.Push(f.Locals[20]);f.Pc=2737;continue;}
case 2737:{f.Push(JValue.R(null));f.Pc=2738;continue;}
case 2738:{f.Push(JValue.R(rt.String("or")));f.Pc=2741;continue;}
case 2741:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",2744);}
case 2744:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2747);}
case 2747:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=2750;continue;}
case 2750:{f.Push(f.Locals[11]);f.Pc=2752;continue;}
case 2752:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2755);}
case 2755:{f.Pc=f.Pop().Int==0?2764:2758;continue;}
case 2758:{f.Push(JValue.R(rt.String(" onto the battlefield")));f.Pc=2761;continue;}
case 2761:{f.Pc=2774;continue;}
case 2764:{f.Push(f.Locals[11]);f.Pc=2766;continue;}
case 2766:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",2769);}
case 2769:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3106:2769:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2774);}
case 2774:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2777);}
case 2777:{f.Push(JValue.R(rt.String(".")));f.Pc=2779;continue;}
case 2779:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2782);}
case 2782:{f.StackOp("pop");f.Pc=2783;continue;}
case 2783:{f.Push(f.Locals[1]);f.Pc=2784;continue;}
case 2784:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",2787);}
case 2787:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3107(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Destination")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(JValue.R(null));f.Pc=24;continue;}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Origin")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?55:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("Origin")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",44);}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",62);}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int==0?80:71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","getCardsfromTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",75);}
case 75:{f.Locals[6]=f.Pop();f.Pc=77;continue;}
case 77:{f.Pc=92;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("Defined")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",87);}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","knownDetermineDefined","(Ljava/lang/String;)Lforge/game/card/CardCollection;","invokevirtual",90);}
case 90:{f.Locals[6]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("DefinedDesc")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int!=0?120:102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?120:109;continue;}
case 109:{f.Push(f.Locals[6]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"com/google/common/collect/Iterables","isEmpty","(Ljava/lang/Iterable;)Z","invokestatic",114);}
case 114:{f.Pc=f.Pop().Int==0?120:117;continue;}
case 117:{f.Push(JValue.R(rt.String("")));f.Pc=119;continue;}
case 119:{return JStep.Return(f.Pop());}
case 120:{f.Push(f.Locals[5]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String(" ")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",127);}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("DefinedDesc")));f.Pc=131;continue;}
case 131:{f.Push(f.Locals[6]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/lang/Iterable;)Ljava/lang/String;","invokestatic",136);}
case 136:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",139);}
case 139:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",142);}
case 142:{f.StackOp("pop");f.Pc=143;continue;}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",148);}
case 148:{f.Locals[7]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[6]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"com/google/common/collect/Iterables","size","(Ljava/lang/Iterable;)I","invokestatic",155);}
case 155:{f.Push(JValue.I(1));f.Pc=156;continue;}
case 156:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?165:159;continue;}
case 159:{f.Push(JValue.R(rt.String(" their ")));f.Pc=162;continue;}
case 162:{f.Pc=168;continue;}
case 165:{f.Push(JValue.R(rt.String(" its ")));f.Pc=168;continue;}
case 168:{f.Locals[8]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.String(" from the graveyard")));f.Pc=173;continue;}
case 173:{f.Locals[9]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[3]);f.Pc=176;continue;}
case 176:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int==0?327:185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("Attacking")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",191);}
case 191:{f.Locals[10]=f.Pop();f.Pc=193;continue;}
case 193:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=196;continue;}
case 196:{f.Push(f.Locals[4]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",201);}
case 201:{f.Pc=f.Pop().Int==0?232:204;continue;}
case 204:{f.Push(f.Locals[1]);f.Pc=205;continue;}
case 205:{f.Push(JValue.R(rt.String("Return")));f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",211);}
case 211:{f.Push(f.Locals[7]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",216);}
case 216:{f.Push(JValue.R(rt.String(" from the graveyard")));f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",222);}
case 222:{f.Push(JValue.R(rt.String(" to the battlefield")));f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",228);}
case 228:{f.StackOp("pop");f.Pc=229;continue;}
case 229:{f.Pc=251;continue;}
case 232:{f.Push(f.Locals[1]);f.Pc=233;continue;}
case 233:{f.Push(JValue.R(rt.String("Put")));f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",239);}
case 239:{f.Push(f.Locals[7]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",244);}
case 244:{f.Push(JValue.R(rt.String(" onto the battlefield")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",250);}
case 250:{f.StackOp("pop");f.Pc=251;continue;}
case 251:{f.Push(f.Locals[0]);f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Int==0?284:260;continue;}
case 260:{f.Push(f.Locals[1]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String(" tapped")));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",267);}
case 267:{f.Push(f.Locals[10]);f.Pc=269;continue;}
case 269:{f.Pc=f.Pop().Int==0?278:272;continue;}
case 272:{f.Push(JValue.R(rt.String(" and")));f.Pc=275;continue;}
case 275:{f.Pc=280;continue;}
case 278:{f.Push(JValue.R(rt.String("")));f.Pc=280;continue;}
case 280:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",283);}
case 283:{f.StackOp("pop");f.Pc=284;continue;}
case 284:{f.Push(f.Locals[1]);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[10]);f.Pc=287;continue;}
case 287:{f.Pc=f.Pop().Int==0?296:290;continue;}
case 290:{f.Push(JValue.R(rt.String(" attacking")));f.Pc=293;continue;}
case 293:{f.Pc=298;continue;}
case 296:{f.Push(JValue.R(rt.String("")));f.Pc=298;continue;}
case 298:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",301);}
case 301:{f.StackOp("pop");f.Pc=302;continue;}
case 302:{f.Push(f.Locals[0]);f.Pc=303;continue;}
case 303:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",309);}
case 309:{f.Pc=f.Pop().Int==0?320:312;continue;}
case 312:{f.Push(f.Locals[1]);f.Pc=313;continue;}
case 313:{f.Push(JValue.R(rt.String(" under your control")));f.Pc=316;continue;}
case 316:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",319);}
case 319:{f.StackOp("pop");f.Pc=320;continue;}
case 320:{f.Push(f.Locals[1]);f.Pc=321;continue;}
case 321:{f.Push(JValue.R(rt.String(".")));f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",326);}
case 326:{f.StackOp("pop");f.Pc=327;continue;}
case 327:{f.Push(f.Locals[3]);f.Pc=328;continue;}
case 328:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",334);}
case 334:{f.Pc=f.Pop().Int==0?441:337;continue;}
case 337:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=340;continue;}
case 340:{f.Push(f.Locals[4]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",345);}
case 345:{f.Pc=f.Pop().Int==0?376:348;continue;}
case 348:{f.Push(f.Locals[1]);f.Pc=349;continue;}
case 349:{f.Push(JValue.R(rt.String("Return")));f.Pc=352;continue;}
case 352:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",355);}
case 355:{f.Push(f.Locals[7]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",360);}
case 360:{f.Push(JValue.R(rt.String(" from the graveyard")));f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",366);}
case 366:{f.Push(JValue.R(rt.String(" to")));f.Pc=369;continue;}
case 369:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",372);}
case 372:{f.StackOp("pop");f.Pc=373;continue;}
case 373:{f.Pc=428;continue;}
case 376:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=379;continue;}
case 379:{f.Push(f.Locals[4]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",384);}
case 384:{f.Pc=f.Pop().Int==0?409:387;continue;}
case 387:{f.Push(f.Locals[1]);f.Pc=388;continue;}
case 388:{f.Push(JValue.R(rt.String("Return")));f.Pc=391;continue;}
case 391:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",394);}
case 394:{f.Push(f.Locals[7]);f.Pc=396;continue;}
case 396:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",399);}
case 399:{f.Push(JValue.R(rt.String(" to")));f.Pc=402;continue;}
case 402:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",405);}
case 405:{f.StackOp("pop");f.Pc=406;continue;}
case 406:{f.Pc=428;continue;}
case 409:{f.Push(f.Locals[1]);f.Pc=410;continue;}
case 410:{f.Push(JValue.R(rt.String("Put")));f.Pc=413;continue;}
case 413:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",416);}
case 416:{f.Push(f.Locals[7]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",421);}
case 421:{f.Push(JValue.R(rt.String(" in")));f.Pc=424;continue;}
case 424:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",427);}
case 427:{f.StackOp("pop");f.Pc=428;continue;}
case 428:{f.Push(f.Locals[1]);f.Pc=429;continue;}
case 429:{f.Push(f.Locals[8]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",434);}
case 434:{f.Push(JValue.R(rt.String("owner's hand.")));f.Pc=437;continue;}
case 437:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",440);}
case 440:{f.StackOp("pop");f.Pc=441;continue;}
case 441:{f.Push(f.Locals[3]);f.Pc=442;continue;}
case 442:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",448);}
case 448:{f.Pc=f.Pop().Int==0?644:451;continue;}
case 451:{f.Push(f.Locals[0]);f.Pc=452;continue;}
case 452:{f.Push(JValue.R(rt.String("Shuffle")));f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",458);}
case 458:{f.Pc=f.Pop().Int==0?496:461;continue;}
case 461:{f.Push(f.Locals[1]);f.Pc=462;continue;}
case 462:{f.Push(JValue.R(rt.String("Shuffle")));f.Pc=465;continue;}
case 465:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",468);}
case 468:{f.Push(f.Locals[7]);f.Pc=470;continue;}
case 470:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",473);}
case 473:{f.StackOp("pop");f.Pc=474;continue;}
case 474:{f.Push(f.Locals[1]);f.Pc=475;continue;}
case 475:{f.Push(JValue.R(rt.String(" into")));f.Pc=478;continue;}
case 478:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",481);}
case 481:{f.Push(f.Locals[8]);f.Pc=483;continue;}
case 483:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",486);}
case 486:{f.Push(JValue.R(rt.String("owner's library.")));f.Pc=489;continue;}
case 489:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",492);}
case 492:{f.StackOp("pop");f.Pc=493;continue;}
case 493:{f.Pc=644;continue;}
case 496:{f.Push(f.Locals[1]);f.Pc=497;continue;}
case 497:{f.Push(JValue.R(rt.String("Put")));f.Pc=500;continue;}
case 500:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",503);}
case 503:{f.Push(f.Locals[7]);f.Pc=505;continue;}
case 505:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",508);}
case 508:{f.StackOp("pop");f.Pc=509;continue;}
case 509:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=512;continue;}
case 512:{f.Push(f.Locals[4]);f.Pc=514;continue;}
case 514:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",517);}
case 517:{f.Pc=f.Pop().Int==0?528:520;continue;}
case 520:{f.Push(f.Locals[1]);f.Pc=521;continue;}
case 521:{f.Push(JValue.R(rt.String(" from the graveyard")));f.Pc=524;continue;}
case 524:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",527);}
case 527:{f.StackOp("pop");f.Pc=528;continue;}
case 528:{f.Push(f.Locals[0]);f.Pc=529;continue;}
case 529:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",535);}
case 535:{f.Pc=f.Pop().Int==0?553:538;continue;}
case 538:{f.Push(f.Locals[2]);f.Pc=539;continue;}
case 539:{f.Push(f.Locals[0]);f.Pc=540;continue;}
case 540:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",546);}
case 546:{f.Push(f.Locals[0]);f.Pc=547;continue;}
case 547:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",550);}
case 550:{f.Pc=554;continue;}
case 553:{f.Push(JValue.I(0));f.Pc=554;continue;}
case 554:{f.Locals[10]=f.Pop();f.Pc=556;continue;}
case 556:{f.Push(f.Locals[10]);f.Pc=558;continue;}
case 558:{f.Push(JValue.I(-1));f.Pc=559;continue;}
case 559:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?584:562;continue;}
case 562:{f.Push(f.Locals[1]);f.Pc=563;continue;}
case 563:{f.Push(JValue.R(rt.String(" on the bottom of")));f.Pc=566;continue;}
case 566:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",569);}
case 569:{f.Push(f.Locals[8]);f.Pc=571;continue;}
case 571:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",574);}
case 574:{f.Push(JValue.R(rt.String("owner's library.")));f.Pc=577;continue;}
case 577:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",580);}
case 580:{f.StackOp("pop");f.Pc=581;continue;}
case 581:{f.Pc=644;continue;}
case 584:{f.Push(f.Locals[10]);f.Pc=586;continue;}
case 586:{f.Pc=f.Pop().Int!=0?611:589;continue;}
case 589:{f.Push(f.Locals[1]);f.Pc=590;continue;}
case 590:{f.Push(JValue.R(rt.String(" on top of")));f.Pc=593;continue;}
case 593:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",596);}
case 596:{f.Push(f.Locals[8]);f.Pc=598;continue;}
case 598:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",601);}
case 601:{f.Push(JValue.R(rt.String("owner's library.")));f.Pc=604;continue;}
case 604:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",607);}
case 607:{f.StackOp("pop");f.Pc=608;continue;}
case 608:{f.Pc=644;continue;}
case 611:{f.Push(f.Locals[1]);f.Pc=612;continue;}
case 612:{f.Push(JValue.R(rt.String(" ")));f.Pc=614;continue;}
case 614:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",617);}
case 617:{f.Push(f.Locals[10]);f.Pc=619;continue;}
case 619:{f.Push(JValue.I(1));f.Pc=620;continue;}
case 620:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=621;continue;}
case 621:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",624);}
case 624:{f.Push(JValue.R(rt.String(" from the top of")));f.Pc=627;continue;}
case 627:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",630);}
case 630:{f.StackOp("pop");f.Pc=631;continue;}
case 631:{f.Push(f.Locals[1]);f.Pc=632;continue;}
case 632:{f.Push(f.Locals[8]);f.Pc=634;continue;}
case 634:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",637);}
case 637:{f.Push(JValue.R(rt.String("owner's library.")));f.Pc=640;continue;}
case 640:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",643);}
case 643:{f.StackOp("pop");f.Pc=644;continue;}
case 644:{f.Push(f.Locals[3]);f.Pc=645;continue;}
case 645:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=648;continue;}
case 648:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",651);}
case 651:{f.Pc=f.Pop().Int==0?692:654;continue;}
case 654:{f.Push(f.Locals[1]);f.Pc=655;continue;}
case 655:{f.Push(JValue.R(rt.String("Exile")));f.Pc=657;continue;}
case 657:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",660);}
case 660:{f.Push(f.Locals[7]);f.Pc=662;continue;}
case 662:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",665);}
case 665:{f.StackOp("pop");f.Pc=666;continue;}
case 666:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=669;continue;}
case 669:{f.Push(f.Locals[4]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",674);}
case 674:{f.Pc=f.Pop().Int==0?685:677;continue;}
case 677:{f.Push(f.Locals[1]);f.Pc=678;continue;}
case 678:{f.Push(JValue.R(rt.String(" from the graveyard")));f.Pc=681;continue;}
case 681:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",684);}
case 684:{f.StackOp("pop");f.Pc=685;continue;}
case 685:{f.Push(f.Locals[1]);f.Pc=686;continue;}
case 686:{f.Push(JValue.R(rt.String(".")));f.Pc=688;continue;}
case 688:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",691);}
case 691:{f.StackOp("pop");f.Pc=692;continue;}
case 692:{f.Push(f.Locals[3]);f.Pc=693;continue;}
case 693:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"));f.Pc=696;continue;}
case 696:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",699);}
case 699:{f.Pc=f.Pop().Int==0?721:702;continue;}
case 702:{f.Push(f.Locals[1]);f.Pc=703;continue;}
case 703:{f.Push(JValue.R(rt.String("Ante")));f.Pc=705;continue;}
case 705:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",708);}
case 708:{f.Push(f.Locals[7]);f.Pc=710;continue;}
case 710:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",713);}
case 713:{f.StackOp("pop");f.Pc=714;continue;}
case 714:{f.Push(f.Locals[1]);f.Pc=715;continue;}
case 715:{f.Push(JValue.R(rt.String(".")));f.Pc=717;continue;}
case 717:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",720);}
case 720:{f.StackOp("pop");f.Pc=721;continue;}
case 721:{f.Push(f.Locals[3]);f.Pc=722;continue;}
case 722:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=725;continue;}
case 725:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",728);}
case 728:{f.Pc=f.Pop().Int==0?781:731;continue;}
case 731:{f.Push(f.Locals[1]);f.Pc=732;continue;}
case 732:{f.Push(JValue.R(rt.String("Put")));f.Pc=735;continue;}
case 735:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",738);}
case 738:{f.Push(f.Locals[7]);f.Pc=740;continue;}
case 740:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",743);}
case 743:{f.StackOp("pop");f.Pc=744;continue;}
case 744:{f.Push(f.Locals[4]);f.Pc=746;continue;}
case 746:{f.Pc=f.Pop().Reference==null?762:749;continue;}
case 749:{f.Push(f.Locals[1]);f.Pc=750;continue;}
case 750:{f.Push(JValue.R(rt.String(" from ")));f.Pc=753;continue;}
case 753:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",756);}
case 756:{f.Push(f.Locals[4]);f.Pc=758;continue;}
case 758:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",761);}
case 761:{f.StackOp("pop");f.Pc=762;continue;}
case 762:{f.Push(f.Locals[1]);f.Pc=763;continue;}
case 763:{f.Push(JValue.R(rt.String(" into")));f.Pc=766;continue;}
case 766:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",769);}
case 769:{f.Push(f.Locals[8]);f.Pc=771;continue;}
case 771:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",774);}
case 774:{f.Push(JValue.R(rt.String("owner's graveyard.")));f.Pc=777;continue;}
case 777:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",780);}
case 780:{f.StackOp("pop");f.Pc=781;continue;}
case 781:{f.Push(f.Locals[1]);f.Pc=782;continue;}
case 782:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",785);}
case 785:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3108(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Duration")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","checkValidDuration","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokestatic",11);}
case 11:{f.Pc=f.Pop().Int!=0?15:14;continue;}
case 14:{return JStep.ReturnVoid;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","isHidden","()Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?37:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","isNinjutsu","()Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int!=0?37:29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","changeHiddenOriginResolve","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",34);}
case 34:{f.Pc=42;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","changeKnownOriginResolve","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",42);}
case 42:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3109(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",20);}
case 20:{f.Locals[5]=f.Pop();f.Pc=22;continue;}
case 22:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",29);}
case 29:{f.Locals[6]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("Destination")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",40);}
case 40:{f.Locals[7]=f.Pop();f.Pc=42;continue;}
case 42:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",45);}
case 45:{f.Locals[8]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("Origin")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?73:56;continue;}
case 56:{f.Push(f.Locals[8]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("Origin")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",64);}
case 64:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",67);}
case 67:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",72);}
case 72:{f.StackOp("pop");f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?99:83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",92);}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",96);}
case 96:{f.Pc=100;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{f.Locals[9]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("DestinationAlternative")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?150:112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[7]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[9]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","handleAltDest","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/zone/ZoneType;ILforge/game/player/Player;Lforge/game/card/CardCollectionView;)Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",125);}
case 125:{f.Locals[10]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[10]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",132);}
case 132:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=135;continue;}
case 135:{f.Locals[7]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[10]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getValue","()Ljava/lang/Object;","invokevirtual",142);}
case 142:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",148);}
case 148:{f.Locals[9]=f.Pop();f.Pc=150;continue;}
case 150:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=153;continue;}
case 153:{f.StackOp("dup");f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",157);}
case 157:{f.Locals[10]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/card/CardZoneTable","getSimultaneousInstance","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",163);}
case 163:{f.Locals[11]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[11]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",170);}
case 170:{f.Locals[12]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[1]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","getTargetSpells","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",176);}
case 176:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",181);}
case 181:{f.Locals[13]=f.Pop();f.Pc=183;continue;}
case 183:{f.Push(f.Locals[13]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",190);}
case 190:{f.Pc=f.Pop().Int==0?258:193;continue;}
case 193:{f.Push(f.Locals[13]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",200);}
case 200:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=203;continue;}
case 203:{f.Locals[14]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[14]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",210);}
case 210:{f.Pc=f.Pop().Int!=0?216:213;continue;}
case 213:{f.Pc=183;continue;}
case 216:{f.Push(f.Locals[5]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",221);}
case 221:{f.Push(f.Locals[14]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/zone/MagicStack","getInstanceMatchingSpellAbilityID","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",226);}
case 226:{f.Locals[15]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[15]);f.Pc=230;continue;}
case 230:{f.Pc=f.Pop().Reference!=null?236:233;continue;}
case 233:{f.Pc=183;continue;}
case 236:{f.Push(f.Locals[0]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[14]);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[1]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[15]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[7]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[9]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[5]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[11]);f.Pc=250;continue;}
case 250:{f.Push(f.Locals[10]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","removeFromStack","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;Lforge/game/zone/ZoneType;ILforge/game/Game;Lforge/game/card/CardZoneTable;Lforge/game/GameEntityCounterTable;)V","invokevirtual",255);}
case 255:{f.Pc=183;continue;}
case 258:{f.Push(f.Locals[1]);f.Pc=259;continue;}
case 259:{f.Push(JValue.R(rt.String("RememberChanged")));f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",265);}
case 265:{f.Locals[13]=f.Pop();f.Pc=267;continue;}
case 267:{f.Push(f.Locals[1]);f.Pc=268;continue;}
case 268:{f.Push(JValue.R(rt.String("ForgetChanged")));f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",274);}
case 274:{f.Locals[14]=f.Pop();f.Pc=276;continue;}
case 276:{f.Push(f.Locals[1]);f.Pc=277;continue;}
case 277:{f.Push(JValue.R(rt.String("Imprint")));f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",283);}
case 283:{f.Locals[15]=f.Pop();f.Pc=285;continue;}
case 285:{f.Push(f.Locals[1]);f.Pc=286;continue;}
case 286:{f.Push(JValue.R(rt.String("Unimprint")));f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",292);}
case 292:{f.Pc=f.Pop().Int==0?300:295;continue;}
case 295:{f.Push(f.Locals[4]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/card/Card","clearImprintedCards","()V","invokevirtual",300);}
case 300:{f.Push(f.Locals[1]);f.Pc=301;continue;}
case 301:{f.Push(JValue.R(rt.String("ForgetOtherRemembered")));f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",307);}
case 307:{f.Pc=f.Pop().Int==0?315:310;continue;}
case 310:{f.Push(f.Locals[4]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",315);}
case 315:{f.Push(f.Locals[1]);f.Pc=316;continue;}
case 316:{f.Push(JValue.R(rt.String("Optional")));f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",321);}
case 321:{f.Locals[16]=f.Pop();f.Pc=323;continue;}
case 323:{f.Push(f.Locals[1]);f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.String("Shuffle")));f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",330);}
case 330:{f.Pc=f.Pop().Int==0?353:333;continue;}
case 333:{f.Push(JValue.R(rt.String("True")));f.Pc=336;continue;}
case 336:{f.Push(f.Locals[1]);f.Pc=337;continue;}
case 337:{f.Push(JValue.R(rt.String("Shuffle")));f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",343);}
case 343:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",346);}
case 346:{f.Pc=f.Pop().Int==0?353:349;continue;}
case 349:{f.Push(JValue.I(1));f.Pc=350;continue;}
case 350:{f.Pc=354;continue;}
case 353:{f.Push(JValue.I(0));f.Pc=354;continue;}
case 354:{f.Locals[17]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(JValue.I(0));f.Pc=357;continue;}
case 357:{f.Locals[18]=f.Pop();f.Pc=359;continue;}
case 359:{f.Push(f.Locals[1]);f.Pc=360;continue;}
case 360:{f.Push(JValue.R(rt.String("ShuffleNonMandatory")));f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",366);}
case 366:{f.Pc=f.Pop().Int==0?396:369;continue;}
case 369:{f.Push(f.Locals[3]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",373);}
case 373:{f.Push(f.Locals[1]);f.Pc=374;continue;}
case 374:{f.Push(JValue.R(null));f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",378);}
case 378:{f.Push(JValue.R(rt.String("lblDoyouWantShuffleTheLibrary")));f.Pc=381;continue;}
case 381:{f.Push(JValue.I(0));f.Pc=382;continue;}
case 382:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",388);}
case 388:{f.Push(JValue.R(null));f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",392);}
case 392:{f.Pc=f.Pop().Int!=0?396:395;continue;}
case 395:{return JStep.ReturnVoid;}
case 396:{f.Push(f.Locals[3]);f.Pc=397;continue;}
case 397:{f.Locals[19]=f.Pop();f.Pc=399;continue;}
case 399:{f.Push(f.Locals[1]);f.Pc=400;continue;}
case 400:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=402;continue;}
case 402:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",405);}
case 405:{f.Pc=f.Pop().Int==0?429:408;continue;}
case 408:{f.Push(f.Locals[4]);f.Pc=410;continue;}
case 410:{f.Push(f.Locals[1]);f.Pc=411;continue;}
case 411:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",416);}
case 416:{f.Push(f.Locals[1]);f.Pc=417;continue;}
case 417:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",420);}
case 420:{f.Push(JValue.I(0));f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",424);}
case 424:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=427;continue;}
case 427:{f.Locals[19]=f.Pop();f.Pc=429;continue;}
case 429:{f.Push(f.Locals[7]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"forge/game/zone/ZoneType","isDeck","()Z","invokevirtual",434);}
case 434:{f.Pc=f.Pop().Int==0?447:437;continue;}
case 437:{f.Push(f.Locals[2]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",443);}
case 443:{f.Push(JValue.I(1));f.Pc=444;continue;}
case 444:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?461:447;continue;}
case 447:{f.Push(f.Locals[19]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",452);}
case 452:{if(!rt.StaticReady(f,"forge/game/player/PlayerController$FullControlFlag","LayerTimestampOrder","Lforge/game/player/PlayerController$FullControlFlag;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerController$FullControlFlag","LayerTimestampOrder","Lforge/game/player/PlayerController$FullControlFlag;"));f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/player/PlayerController","isFullControl","(Lforge/game/player/PlayerController$FullControlFlag;)Z","invokevirtual",458);}
case 458:{f.Pc=f.Pop().Int==0?532:461;continue;}
case 461:{f.Push(f.Locals[17]);f.Pc=463;continue;}
case 463:{f.Pc=f.Pop().Int!=0?532:466;continue;}
case 466:{f.Push(f.Locals[1]);f.Pc=467;continue;}
case 467:{f.Push(JValue.R(rt.String("RandomOrder")));f.Pc=470;continue;}
case 470:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",473);}
case 473:{f.Pc=f.Pop().Int==0?497:476;continue;}
case 476:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=479;continue;}
case 479:{f.StackOp("dup");f.Pc=480;continue;}
case 480:{f.Push(f.Locals[2]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",484);}
case 484:{f.Locals[20]=f.Pop();f.Pc=486;continue;}
case 486:{f.Push(f.Locals[20]);f.Pc=488;continue;}
case 488:{return rt.Call(f,"forge/game/card/CardLists","shuffle","(Ljava/util/List;)V","invokestatic",491);}
case 491:{f.Push(f.Locals[20]);f.Pc=493;continue;}
case 493:{f.Locals[2]=f.Pop();f.Pc=494;continue;}
case 494:{f.Pc=532;continue;}
case 497:{f.Push(f.Locals[1]);f.Pc=498;continue;}
case 498:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=500;continue;}
case 500:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",503);}
case 503:{f.Pc=f.Pop().Int==0?522:506;continue;}
case 506:{f.Push(f.Locals[19]);f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",511);}
case 511:{f.Push(f.Locals[2]);f.Pc=512;continue;}
case 512:{f.Push(f.Locals[7]);f.Pc=514;continue;}
case 514:{f.Push(f.Locals[1]);f.Pc=515;continue;}
case 515:{return rt.Call(f,"forge/game/player/PlayerController","orderMoveToZoneList","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",518);}
case 518:{f.Locals[2]=f.Pop();f.Pc=519;continue;}
case 519:{f.Pc=532;continue;}
case 522:{f.Push(f.Locals[5]);f.Pc=524;continue;}
case 524:{f.Push(f.Locals[2]);f.Pc=525;continue;}
case 525:{f.Push(f.Locals[7]);f.Pc=527;continue;}
case 527:{f.Push(f.Locals[1]);f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",531);}
case 531:{f.Locals[2]=f.Pop();f.Pc=532;continue;}
case 532:{f.Push(f.Locals[2]);f.Pc=533;continue;}
case 533:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",538);}
case 538:{f.Locals[20]=f.Pop();f.Pc=540;continue;}
case 540:{f.Push(f.Locals[20]);f.Pc=542;continue;}
case 542:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",547);}
case 547:{f.Pc=f.Pop().Int==0?2819:550;continue;}
case 550:{f.Push(f.Locals[20]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",557);}
case 557:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=560;continue;}
case 560:{f.Locals[21]=f.Pop();f.Pc=562;continue;}
case 562:{f.Push(f.Locals[1]);f.Pc=563;continue;}
case 563:{f.Push(JValue.R(rt.String("StaticEffectUntilCardID")));f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasSVar","(Ljava/lang/String;)Z","invokevirtual",569);}
case 569:{f.Pc=f.Pop().Int==0?597:572;continue;}
case 572:{f.Push(f.Locals[1]);f.Pc=573;continue;}
case 573:{f.Push(JValue.R(rt.String("StaticEffectUntilCardID")));f.Pc=576;continue;}
case 576:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVarInt","(Ljava/lang/String;)Ljava/lang/Integer;","invokevirtual",579);}
case 579:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",582);}
case 582:{f.Push(f.Locals[21]);f.Pc=584;continue;}
case 584:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",587);}
case 587:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?597:590;continue;}
case 590:{f.Push(f.Locals[1]);f.Pc=591;continue;}
case 591:{f.Push(JValue.R(rt.String("StaticEffectTimestamp")));f.Pc=594;continue;}
case 594:{return rt.Call(f,"forge/game/spellability/SpellAbility","removeSVar","(Ljava/lang/String;)V","invokevirtual",597);}
case 597:{f.Push(f.Locals[5]);f.Pc=599;continue;}
case 599:{f.Push(f.Locals[21]);f.Pc=601;continue;}
case 601:{f.Push(JValue.R(null));f.Pc=602;continue;}
case 602:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",605);}
case 605:{f.Locals[22]=f.Pop();f.Pc=607;continue;}
case 607:{f.Push(f.Locals[22]);f.Pc=609;continue;}
case 609:{f.Pc=f.Pop().Reference==null?540:612;continue;}
case 612:{f.Push(f.Locals[21]);f.Pc=614;continue;}
case 614:{f.Push(f.Locals[22]);f.Pc=616;continue;}
case 616:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",619);}
case 619:{f.Pc=f.Pop().Int==0?540:622;continue;}
case 622:{f.Push(f.Locals[22]);f.Pc=624;continue;}
case 624:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",627);}
case 627:{f.Pc=f.Pop().Int==0?633:630;continue;}
case 630:{f.Pc=540;continue;}
case 633:{f.Push(f.Locals[1]);f.Pc=634;continue;}
case 634:{f.Push(JValue.R(rt.String("RememberLKI")));f.Pc=637;continue;}
case 637:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",640);}
case 640:{f.Pc=f.Pop().Int==0?653:643;continue;}
case 643:{f.Push(f.Locals[4]);f.Pc=645;continue;}
case 645:{f.Push(f.Locals[22]);f.Pc=647;continue;}
case 647:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",650);}
case 650:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",653);}
case 653:{f.Push(JValue.I(1));f.Pc=654;continue;}
case 654:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=657;continue;}
case 657:{f.StackOp("dup");f.Pc=658;continue;}
case 658:{f.Push(JValue.I(0));f.Pc=659;continue;}
case 659:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",662);}
case 662:{f.Push(JValue.R(rt.String("lblDoYouWantMoveTargetFromOriToDest")));f.Pc=665;continue;}
case 665:{f.Push(JValue.I(3));f.Pc=666;continue;}
case 666:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=669;continue;}
case 669:{f.StackOp("dup");f.Pc=670;continue;}
case 670:{f.Push(JValue.I(0));f.Pc=671;continue;}
case 671:{f.Push(f.Locals[22]);f.Pc=673;continue;}
case 673:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",676);}
case 676:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=677;continue;}
case 677:{f.StackOp("dup");f.Pc=678;continue;}
case 678:{f.Push(JValue.I(1));f.Pc=679;continue;}
case 679:{f.Push(f.Locals[8]);f.Pc=681;continue;}
case 681:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3109:681:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",686);}
case 686:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;)Ljava/lang/String;","invokestatic",689);}
case 689:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=690;continue;}
case 690:{f.StackOp("dup");f.Pc=691;continue;}
case 691:{f.Push(JValue.I(2));f.Pc=692;continue;}
case 692:{f.Push(f.Locals[7]);f.Pc=694;continue;}
case 694:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",697);}
case 697:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=698;continue;}
case 698:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",701);}
case 701:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=702;continue;}
case 702:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",705);}
case 705:{f.Locals[23]=f.Pop();f.Pc=707;continue;}
case 707:{f.Push(f.Locals[16]);f.Pc=709;continue;}
case 709:{f.Pc=f.Pop().Int==0?733:712;continue;}
case 712:{f.Push(f.Locals[19]);f.Pc=714;continue;}
case 714:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",717);}
case 717:{f.Push(f.Locals[1]);f.Pc=718;continue;}
case 718:{f.Push(JValue.R(null));f.Pc=719;continue;}
case 719:{f.Push(f.Locals[23]);f.Pc=721;continue;}
case 721:{f.Push(f.Locals[22]);f.Pc=723;continue;}
case 723:{f.Push(JValue.R(null));f.Pc=724;continue;}
case 724:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",727);}
case 727:{f.Pc=f.Pop().Int!=0?733:730;continue;}
case 730:{f.Pc=540;continue;}
case 733:{f.Push(f.Locals[5]);f.Pc=735;continue;}
case 735:{f.Push(f.Locals[22]);f.Pc=737;continue;}
case 737:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",740);}
case 740:{f.Locals[24]=f.Pop();f.Pc=742;continue;}
case 742:{f.Push(f.Locals[24]);f.Pc=744;continue;}
case 744:{f.Pc=f.Pop().Reference==null?540:747;continue;}
case 747:{f.Push(f.Locals[8]);f.Pc=749;continue;}
case 749:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",754);}
case 754:{f.Pc=f.Pop().Int!=0?775:757;continue;}
case 757:{f.Push(f.Locals[8]);f.Pc=759;continue;}
case 759:{f.Push(f.Locals[24]);f.Pc=761;continue;}
case 761:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",764);}
case 764:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",769);}
case 769:{f.Pc=f.Pop().Int!=0?775:772;continue;}
case 772:{f.Pc=540;continue;}
case 775:{f.Push(f.Locals[24]);f.Pc=777;continue;}
case 777:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=780;continue;}
case 780:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",783);}
case 783:{f.Pc=f.Pop().Int==0?796:786;continue;}
case 786:{f.Push(f.Locals[5]);f.Pc=788;continue;}
case 788:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",791);}
case 791:{f.Push(f.Locals[22]);f.Pc=793;continue;}
case 793:{return rt.Call(f,"forge/game/zone/MagicStack","remove","(Lforge/game/card/Card;)V","invokevirtual",796);}
case 796:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",799);}
case 799:{f.Locals[26]=f.Pop();f.Pc=801;continue;}
case 801:{f.Push(f.Locals[26]);f.Pc=803;continue;}
case 803:{f.Push(f.Locals[11]);f.Pc=805;continue;}
case 805:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",808);}
case 808:{f.Push(f.Locals[7]);f.Pc=810;continue;}
case 810:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=813;continue;}
case 813:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",816);}
case 816:{f.Pc=f.Pop().Int==0?1901:819;continue;}
case 819:{f.Push(f.Locals[26]);f.Pc=821;continue;}
case 821:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"));f.Pc=824;continue;}
case 824:{f.Push(f.Locals[2]);f.Pc=825;continue;}
case 825:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",830);}
case 830:{f.StackOp("pop");f.Pc=831;continue;}
case 831:{f.Push(f.Locals[1]);f.Pc=832;continue;}
case 832:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",835);}
case 835:{f.Pc=f.Pop().Int==0?899:838;continue;}
case 838:{f.Push(f.Locals[1]);f.Pc=839;continue;}
case 839:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacementEffect","()Lforge/game/replacement/ReplacementEffect;","invokevirtual",842);}
case 842:{f.Locals[27]=f.Pop();f.Pc=844;continue;}
case 844:{f.Push(f.Locals[26]);f.Pc=846;continue;}
case 846:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","ReplacementEffect","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","ReplacementEffect","Lforge/game/ability/AbilityKey;"));f.Pc=849;continue;}
case 849:{f.Push(f.Locals[27]);f.Pc=851;continue;}
case 851:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",856);}
case 856:{f.StackOp("pop");f.Pc=857;continue;}
case 857:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"));f.Pc=860;continue;}
case 860:{f.Push(f.Locals[27]);f.Pc=862;continue;}
case 862:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMode","()Lforge/game/replacement/ReplacementType;","invokevirtual",865);}
case 865:{return rt.Call(f,"forge/game/replacement/ReplacementType","equals","(Ljava/lang/Object;)Z","invokevirtual",868);}
case 868:{f.Pc=f.Pop().Int==0?899:871;continue;}
case 871:{f.Push(f.Locals[1]);f.Pc=872;continue;}
case 872:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=875;continue;}
case 875:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",878);}
case 878:{f.Pc=f.Pop().Reference==null?899:881;continue;}
case 881:{f.Push(f.Locals[26]);f.Pc=883;continue;}
case 883:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=886;continue;}
case 886:{f.Push(f.Locals[1]);f.Pc=887;continue;}
case 887:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=890;continue;}
case 890:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",893);}
case 893:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",898);}
case 898:{f.StackOp("pop");f.Pc=899;continue;}
case 899:{f.Push(f.Locals[1]);f.Pc=900;continue;}
case 900:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=902;continue;}
case 902:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",905);}
case 905:{f.Pc=f.Pop().Int!=0?915:908;continue;}
case 908:{f.Push(f.Locals[1]);f.Pc=909;continue;}
case 909:{return rt.Call(f,"forge/game/spellability/SpellAbility","isNinjutsu","()Z","invokevirtual",912);}
case 912:{f.Pc=f.Pop().Int==0?921:915;continue;}
case 915:{f.Push(f.Locals[22]);f.Pc=917;continue;}
case 917:{f.Push(JValue.I(1));f.Pc=918;continue;}
case 918:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",921);}
case 921:{f.Push(f.Locals[1]);f.Pc=922;continue;}
case 922:{f.Push(JValue.R(rt.String("Transformed")));f.Pc=925;continue;}
case 925:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",928);}
case 928:{f.Pc=f.Pop().Int==0?979:931;continue;}
case 931:{f.Push(f.Locals[22]);f.Pc=933;continue;}
case 933:{return rt.Call(f,"forge/game/card/Card","isTransformable","()Z","invokevirtual",936);}
case 936:{f.Pc=f.Pop().Int==0?540:939;continue;}
case 939:{f.Push(f.Locals[26]);f.Pc=941;continue;}
case 941:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=944;continue;}
case 944:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",949);}
case 949:{f.Pc=f.Pop().Int!=0?968:952;continue;}
case 952:{f.Push(f.Locals[26]);f.Pc=954;continue;}
case 954:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=957;continue;}
case 957:{f.Push(f.Locals[22]);f.Pc=959;continue;}
case 959:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",962);}
case 962:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",967);}
case 967:{f.StackOp("pop");f.Pc=968;continue;}
case 968:{f.Push(f.Locals[22]);f.Pc=970;continue;}
case 970:{f.Push(JValue.R(rt.String("Transform")));f.Pc=973;continue;}
case 973:{f.Push(JValue.R(null));f.Pc=974;continue;}
case 974:{f.Push(f.Locals[1]);f.Pc=975;continue;}
case 975:{return rt.Call(f,"forge/game/card/Card","changeCardState","(Ljava/lang/String;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",978);}
case 978:{f.StackOp("pop");f.Pc=979;continue;}
case 979:{f.Push(f.Locals[1]);f.Pc=980;continue;}
case 980:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=983;continue;}
case 983:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",986);}
case 986:{f.Pc=f.Pop().Int==0?1094:989;continue;}
case 989:{f.Push(f.Locals[4]);f.Pc=991;continue;}
case 991:{f.Push(f.Locals[1]);f.Pc=992;continue;}
case 992:{f.Push(JValue.R(rt.String("WithCountersAmount")));f.Pc=995;continue;}
case 995:{f.Push(JValue.R(rt.String("1")));f.Pc=998;continue;}
case 998:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1001);}
case 1001:{f.Push(f.Locals[1]);f.Pc=1002;continue;}
case 1002:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1005);}
case 1005:{f.Locals[27]=f.Pop();f.Pc=1007;continue;}
case 1007:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=1010;continue;}
case 1010:{f.StackOp("dup");f.Pc=1011;continue;}
case 1011:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",1014);}
case 1014:{f.Locals[28]=f.Pop();f.Pc=1016;continue;}
case 1016:{f.Push(f.Locals[26]);f.Pc=1018;continue;}
case 1018:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=1021;continue;}
case 1021:{f.Push(f.Locals[28]);f.Pc=1023;continue;}
case 1023:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1028);}
case 1028:{f.StackOp("pop");f.Pc=1029;continue;}
case 1029:{f.Push(f.Locals[1]);f.Pc=1030;continue;}
case 1030:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1036);}
case 1036:{f.Push(JValue.R(rt.String(",")));f.Pc=1038;continue;}
case 1038:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1041);}
case 1041:{f.Locals[29]=f.Pop();f.Pc=1043;continue;}
case 1043:{f.Push(f.Locals[29]);f.Pc=1045;continue;}
case 1045:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1046;continue;}
case 1046:{f.Locals[30]=f.Pop();f.Pc=1048;continue;}
case 1048:{f.Push(JValue.I(0));f.Pc=1049;continue;}
case 1049:{f.Locals[31]=f.Pop();f.Pc=1051;continue;}
case 1051:{f.Push(f.Locals[31]);f.Pc=1053;continue;}
case 1053:{f.Push(f.Locals[30]);f.Pc=1055;continue;}
case 1055:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1091:1058;continue;}
case 1058:{f.Push(f.Locals[29]);f.Pc=1060;continue;}
case 1060:{f.Push(f.Locals[31]);f.Pc=1062;continue;}
case 1062:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1063;continue;}
case 1063:{f.Locals[32]=f.Pop();f.Pc=1065;continue;}
case 1065:{f.Push(f.Locals[32]);f.Pc=1067;continue;}
case 1067:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",1070);}
case 1070:{f.Locals[33]=f.Pop();f.Pc=1072;continue;}
case 1072:{f.Push(f.Locals[28]);f.Pc=1074;continue;}
case 1074:{f.Push(f.Locals[3]);f.Pc=1075;continue;}
case 1075:{f.Push(f.Locals[22]);f.Pc=1077;continue;}
case 1077:{f.Push(f.Locals[33]);f.Pc=1079;continue;}
case 1079:{f.Push(f.Locals[27]);f.Pc=1081;continue;}
case 1081:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",1084);}
case 1084:{f.StackOp("pop");f.Pc=1085;continue;}
case 1085:{f.Locals[31]=JValue.I(unchecked(f.Locals[31].Int+(1)));f.Pc=1088;continue;}
case 1088:{f.Pc=1051;continue;}
case 1091:{f.Pc=1116;continue;}
case 1094:{f.Push(f.Locals[1]);f.Pc=1095;continue;}
case 1095:{f.Push(JValue.R(rt.String("WithNotedCounters")));f.Pc=1098;continue;}
case 1098:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1101);}
case 1101:{f.Pc=f.Pop().Int==0?1116:1104;continue;}
case 1104:{f.Push(f.Locals[22]);f.Pc=1106;continue;}
case 1106:{f.Push(f.Locals[4]);f.Pc=1108;continue;}
case 1108:{f.Push(f.Locals[19]);f.Pc=1110;continue;}
case 1110:{f.Push(f.Locals[1]);f.Pc=1111;continue;}
case 1111:{f.Push(f.Locals[26]);f.Pc=1113;continue;}
case 1113:{return rt.Call(f,"forge/game/ability/effects/CountersNoteEffect","loadCounters","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)V","invokestatic",1116);}
case 1116:{f.Push(f.Locals[1]);f.Pc=1117;continue;}
case 1117:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=1120;continue;}
case 1120:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1123);}
case 1123:{f.Pc=f.Pop().Int==0?1199:1126;continue;}
case 1126:{f.Push(f.Locals[1]);f.Pc=1127;continue;}
case 1127:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=1130;continue;}
case 1130:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1133);}
case 1133:{f.Locals[27]=f.Pop();f.Pc=1135;continue;}
case 1135:{f.Push(f.Locals[27]);f.Pc=1137;continue;}
case 1137:{f.Push(JValue.R(rt.String("True")));f.Pc=1140;continue;}
case 1140:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1143);}
case 1143:{f.Pc=f.Pop().Int==0?1150:1146;continue;}
case 1146:{f.Push(f.Locals[3]);f.Pc=1147;continue;}
case 1147:{f.Pc=1165;continue;}
case 1150:{f.Push(f.Locals[4]);f.Pc=1152;continue;}
case 1152:{f.Push(f.Locals[27]);f.Pc=1154;continue;}
case 1154:{f.Push(f.Locals[1]);f.Pc=1155;continue;}
case 1155:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1158);}
case 1158:{f.Push(JValue.I(0));f.Pc=1159;continue;}
case 1159:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",1162);}
case 1162:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1165;continue;}
case 1165:{f.Locals[28]=f.Pop();f.Pc=1167;continue;}
case 1167:{f.Push(f.Locals[28]);f.Pc=1169;continue;}
case 1169:{f.Pc=f.Pop().Reference==null?1199:1172;continue;}
case 1172:{f.Push(f.Locals[28]);f.Pc=1174;continue;}
case 1174:{f.Push(f.Locals[22]);f.Pc=1176;continue;}
case 1176:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1179);}
case 1179:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?1187:1182;continue;}
case 1182:{f.Push(f.Locals[22]);f.Pc=1184;continue;}
case 1184:{return rt.Call(f,"forge/game/card/Card","runChangeControllerCommands","()V","invokevirtual",1187);}
case 1187:{f.Push(f.Locals[22]);f.Pc=1189;continue;}
case 1189:{f.Push(f.Locals[28]);f.Pc=1191;continue;}
case 1191:{f.Push(f.Locals[5]);f.Pc=1193;continue;}
case 1193:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",1196);}
case 1196:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",1199);}
case 1199:{f.Push(f.Locals[1]);f.Pc=1200;continue;}
case 1200:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=1203;continue;}
case 1203:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1206);}
case 1206:{f.Pc=f.Pop().Int==0?1367:1209;continue;}
case 1209:{f.Push(f.Locals[4]);f.Pc=1211;continue;}
case 1211:{f.Push(f.Locals[1]);f.Pc=1212;continue;}
case 1212:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=1215;continue;}
case 1215:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1218);}
case 1218:{f.Push(f.Locals[1]);f.Pc=1219;continue;}
case 1219:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1222);}
case 1222:{f.Locals[27]=f.Pop();f.Pc=1224;continue;}
case 1224:{f.Push(f.Locals[27]);f.Pc=1226;continue;}
case 1226:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1229);}
case 1229:{f.Pc=f.Pop().Int==0?1254:1232;continue;}
case 1232:{f.Push(f.Locals[12]);f.Pc=1234;continue;}
case 1234:{f.Push(f.Locals[1]);f.Pc=1235;continue;}
case 1235:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=1238;continue;}
case 1238:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1241);}
case 1241:{f.Push(f.Locals[4]);f.Pc=1243;continue;}
case 1243:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1246);}
case 1246:{f.Push(f.Locals[4]);f.Pc=1248;continue;}
case 1248:{f.Push(f.Locals[1]);f.Pc=1249;continue;}
case 1249:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1252);}
case 1252:{f.Locals[27]=f.Pop();f.Pc=1254;continue;}
case 1254:{f.Push(f.Locals[27]);f.Pc=1256;continue;}
case 1256:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1259);}
case 1259:{f.Pc=f.Pop().Int!=0?1275:1262;continue;}
case 1262:{f.Push(f.Locals[27]);f.Pc=1264;continue;}
case 1264:{f.Push(f.Locals[22]);f.Pc=1266;continue;}
case 1266:{f.Push(f.Locals[1]);f.Pc=1267;continue;}
case 1267:{return rt.Call(f,"forge/game/card/CardPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;","invokestatic",1270);}
case 1270:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",1273);}
case 1273:{f.Locals[27]=f.Pop();f.Pc=1275;continue;}
case 1275:{f.Push(f.Locals[27]);f.Pc=1277;continue;}
case 1277:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1280);}
case 1280:{f.Pc=f.Pop().Int!=0?1356:1283;continue;}
case 1283:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",1286);}
case 1286:{f.Locals[28]=f.Pop();f.Pc=1288;continue;}
case 1288:{f.Push(f.Locals[28]);f.Pc=1290;continue;}
case 1290:{f.Push(JValue.R(rt.String("Attach")));f.Pc=1293;continue;}
case 1293:{f.Push(f.Locals[22]);f.Pc=1295;continue;}
case 1295:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1300);}
case 1300:{f.StackOp("pop");f.Pc=1301;continue;}
case 1301:{f.Push(f.Locals[3]);f.Pc=1302;continue;}
case 1302:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1305);}
case 1305:{f.Push(f.Locals[27]);f.Pc=1307;continue;}
case 1307:{f.Push(f.Locals[1]);f.Pc=1308;continue;}
case 1308:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1311);}
case 1311:{f.Push(JValue.R(rt.String("lblSelectACardAttachSourceTo")));f.Pc=1314;continue;}
case 1314:{f.Push(JValue.I(1));f.Pc=1315;continue;}
case 1315:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1318;continue;}
case 1318:{f.StackOp("dup");f.Pc=1319;continue;}
case 1319:{f.Push(JValue.I(0));f.Pc=1320;continue;}
case 1320:{f.Push(f.Locals[22]);f.Pc=1322;continue;}
case 1322:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",1325);}
case 1325:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1326;continue;}
case 1326:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1329);}
case 1329:{f.Push(f.Locals[28]);f.Pc=1331;continue;}
case 1331:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",1334);}
case 1334:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1337;continue;}
case 1337:{f.Locals[29]=f.Pop();f.Pc=1339;continue;}
case 1339:{f.Push(f.Locals[22]);f.Pc=1341;continue;}
case 1341:{f.Push(f.Locals[5]);f.Pc=1343;continue;}
case 1343:{f.Push(f.Locals[29]);f.Pc=1345;continue;}
case 1345:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",1348);}
case 1348:{f.Push(f.Locals[1]);f.Pc=1349;continue;}
case 1349:{f.Push(JValue.I(1));f.Pc=1350;continue;}
case 1350:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;Z)V","invokevirtual",1353);}
case 1353:{f.Pc=1367;continue;}
case 1356:{f.Push(f.Locals[22]);f.Pc=1358;continue;}
case 1358:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",1361);}
case 1361:{f.Pc=f.Pop().Int==0?1367:1364;continue;}
case 1364:{f.Pc=540;continue;}
case 1367:{f.Push(f.Locals[1]);f.Pc=1368;continue;}
case 1368:{f.Push(JValue.R(rt.String("AttachedToPlayer")));f.Pc=1371;continue;}
case 1371:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1374);}
case 1374:{f.Pc=f.Pop().Int==0?1466:1377;continue;}
case 1377:{f.Push(f.Locals[4]);f.Pc=1379;continue;}
case 1379:{f.Push(f.Locals[1]);f.Pc=1380;continue;}
case 1380:{f.Push(JValue.R(rt.String("AttachedToPlayer")));f.Pc=1383;continue;}
case 1383:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1386);}
case 1386:{f.Push(f.Locals[1]);f.Pc=1387;continue;}
case 1387:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",1390);}
case 1390:{f.Locals[27]=f.Pop();f.Pc=1392;continue;}
case 1392:{f.Push(f.Locals[27]);f.Pc=1394;continue;}
case 1394:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",1399);}
case 1399:{f.Pc=f.Pop().Int!=0?540:1402;continue;}
case 1402:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",1405);}
case 1405:{f.Locals[28]=f.Pop();f.Pc=1407;continue;}
case 1407:{f.Push(f.Locals[28]);f.Pc=1409;continue;}
case 1409:{f.Push(JValue.R(rt.String("Attach")));f.Pc=1412;continue;}
case 1412:{f.Push(f.Locals[22]);f.Pc=1414;continue;}
case 1414:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1419);}
case 1419:{f.StackOp("pop");f.Pc=1420;continue;}
case 1420:{f.Push(f.Locals[3]);f.Pc=1421;continue;}
case 1421:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1424);}
case 1424:{f.Push(f.Locals[27]);f.Pc=1426;continue;}
case 1426:{f.Push(f.Locals[1]);f.Pc=1427;continue;}
case 1427:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1430);}
case 1430:{f.Push(JValue.R(rt.String("lblSelectAPlayerAttachSourceTo")));f.Pc=1433;continue;}
case 1433:{f.Push(JValue.I(1));f.Pc=1434;continue;}
case 1434:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1437;continue;}
case 1437:{f.StackOp("dup");f.Pc=1438;continue;}
case 1438:{f.Push(JValue.I(0));f.Pc=1439;continue;}
case 1439:{f.Push(f.Locals[22]);f.Pc=1441;continue;}
case 1441:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",1444);}
case 1444:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1445;continue;}
case 1445:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1448);}
case 1448:{f.Push(f.Locals[28]);f.Pc=1450;continue;}
case 1450:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",1453);}
case 1453:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1456;continue;}
case 1456:{f.Locals[29]=f.Pop();f.Pc=1458;continue;}
case 1458:{f.Push(f.Locals[22]);f.Pc=1460;continue;}
case 1460:{f.Push(f.Locals[29]);f.Pc=1462;continue;}
case 1462:{f.Push(f.Locals[1]);f.Pc=1463;continue;}
case 1463:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1466);}
case 1466:{f.Push(f.Locals[1]);f.Pc=1467;continue;}
case 1467:{f.Push(JValue.R(rt.String("FaceDown")));f.Pc=1470;continue;}
case 1470:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1473);}
case 1473:{f.Pc=f.Pop().Int==0?1489:1476;continue;}
case 1476:{f.Push(f.Locals[22]);f.Pc=1478;continue;}
case 1478:{f.Push(JValue.I(1));f.Pc=1479;continue;}
case 1479:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",1482);}
case 1482:{f.StackOp("pop");f.Pc=1483;continue;}
case 1483:{f.Push(f.Locals[22]);f.Pc=1485;continue;}
case 1485:{f.Push(f.Locals[1]);f.Pc=1486;continue;}
case 1486:{return rt.Call(f,"forge/game/card/CardFactoryUtil","setFaceDownState","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",1489);}
case 1489:{f.Push(f.Locals[5]);f.Pc=1491;continue;}
case 1491:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1494);}
case 1494:{f.Push(f.Locals[22]);f.Pc=1496;continue;}
case 1496:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1499);}
case 1499:{f.Push(f.Locals[7]);f.Pc=1501;continue;}
case 1501:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",1504);}
case 1504:{f.Push(f.Locals[22]);f.Pc=1506;continue;}
case 1506:{f.Push(f.Locals[1]);f.Pc=1507;continue;}
case 1507:{f.Push(f.Locals[26]);f.Pc=1509;continue;}
case 1509:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",1512);}
case 1512:{f.Locals[25]=f.Pop();f.Pc=1514;continue;}
case 1514:{f.Push(f.Locals[25]);f.Pc=1516;continue;}
case 1516:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1519);}
case 1519:{f.Push(f.Locals[24]);f.Pc=1521;continue;}
case 1521:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",1524);}
case 1524:{f.Pc=f.Pop().Int==0?1530:1527;continue;}
case 1527:{f.Pc=540;continue;}
case 1530:{f.Push(f.Locals[1]);f.Pc=1531;continue;}
case 1531:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","UNEARTH","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","UNEARTH","Lforge/game/keyword/Keyword;"));f.Pc=1534;continue;}
case 1534:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",1537);}
case 1537:{f.Pc=f.Pop().Int==0?1648:1540;continue;}
case 1540:{f.Push(f.Locals[25]);f.Pc=1542;continue;}
case 1542:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",1545);}
case 1545:{f.Pc=f.Pop().Int==0?1648:1548;continue;}
case 1548:{f.Push(f.Locals[25]);f.Pc=1550;continue;}
case 1550:{f.Push(JValue.I(1));f.Pc=1551;continue;}
case 1551:{return rt.Call(f,"forge/game/card/Card","setUnearthed","(Z)V","invokevirtual",1554);}
case 1554:{f.Push(f.Locals[1]);f.Pc=1555;continue;}
case 1555:{f.Push(f.Locals[1]);f.Pc=1556;continue;}
case 1556:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",1559);}
case 1559:{f.Push(JValue.R(rt.String("Unearth Effect")));f.Pc=1562;continue;}
case 1562:{f.Push(f.Locals[4]);f.Pc=1564;continue;}
case 1564:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",1567);}
case 1567:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",1570);}
case 1570:{f.Locals[27]=f.Pop();f.Pc=1572;continue;}
case 1572:{f.Push(f.Locals[27]);f.Pc=1574;continue;}
case 1574:{f.Push(JValue.I(0));f.Pc=1575;continue;}
case 1575:{return rt.Call(f,"forge/game/card/Card","setRenderForUI","(Z)V","invokevirtual",1578);}
case 1578:{f.Push(f.Locals[27]);f.Pc=1580;continue;}
case 1580:{f.Push(f.Locals[25]);f.Pc=1582;continue;}
case 1582:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1585);}
case 1585:{f.Push(JValue.R(rt.String("Mode$ Continuous | Affected$ Card.IsRemembered | EffectZone$ Command | AddKeyword$ Haste")));f.Pc=1588;continue;}
case 1588:{f.Locals[28]=f.Pop();f.Pc=1590;continue;}
case 1590:{f.Push(f.Locals[27]);f.Pc=1592;continue;}
case 1592:{f.Push(f.Locals[28]);f.Pc=1594;continue;}
case 1594:{return rt.Call(f,"forge/game/card/Card","addStaticAbility","(Ljava/lang/String;)Lforge/game/staticability/StaticAbility;","invokevirtual",1597);}
case 1597:{f.StackOp("pop");f.Pc=1598;continue;}
case 1598:{f.Push(f.Locals[27]);f.Pc=1600;continue;}
case 1600:{f.Push(JValue.R(rt.String("Exile")));f.Pc=1602;continue;}
case 1602:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","addLeaveBattlefieldReplacement","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",1605);}
case 1605:{f.Push(f.Locals[25]);f.Pc=1607;continue;}
case 1607:{f.Push(f.Locals[5]);f.Pc=1609;continue;}
case 1609:{f.Push(f.Locals[27]);f.Pc=1611;continue;}
case 1611:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3109:1611:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",1616);}
case 1616:{return rt.Call(f,"forge/game/card/Card","addLeavesPlayCommand","(Lforge/GameCommand;)V","invokevirtual",1619);}
case 1619:{f.Push(f.Locals[5]);f.Pc=1621;continue;}
case 1621:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1624);}
case 1624:{f.Push(f.Locals[27]);f.Pc=1626;continue;}
case 1626:{f.Push(f.Locals[1]);f.Pc=1627;continue;}
case 1627:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1630);}
case 1630:{f.Push(f.Locals[1]);f.Pc=1631;continue;}
case 1631:{f.Push(JValue.R(rt.String("Exile")));f.Pc=1633;continue;}
case 1633:{f.Push(JValue.I(1));f.Pc=1634;continue;}
case 1634:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=1637;continue;}
case 1637:{f.StackOp("dup");f.Pc=1638;continue;}
case 1638:{f.Push(JValue.I(0));f.Pc=1639;continue;}
case 1639:{f.Push(f.Locals[25]);f.Pc=1641;continue;}
case 1641:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1642;continue;}
case 1642:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",1645);}
case 1645:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V","invokestatic",1648);}
case 1648:{f.Push(f.Locals[1]);f.Pc=1649;continue;}
case 1649:{f.Push(JValue.R(rt.String("LeaveBattlefield")));f.Pc=1652;continue;}
case 1652:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1655);}
case 1655:{f.Pc=f.Pop().Int==0?1671:1658;continue;}
case 1658:{f.Push(f.Locals[25]);f.Pc=1660;continue;}
case 1660:{f.Push(f.Locals[1]);f.Pc=1661;continue;}
case 1661:{f.Push(f.Locals[1]);f.Pc=1662;continue;}
case 1662:{f.Push(JValue.R(rt.String("LeaveBattlefield")));f.Pc=1665;continue;}
case 1665:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1668);}
case 1668:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","addLeaveBattlefieldReplacement","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;)V","invokestatic",1671);}
case 1671:{f.Push(f.Locals[25]);f.Pc=1673;continue;}
case 1673:{f.Push(f.Locals[1]);f.Pc=1674;continue;}
case 1674:{f.Push(JValue.R(rt.String("Attacking")));f.Pc=1676;continue;}
case 1676:{f.Push(JValue.R(rt.String("Blocking")));f.Pc=1679;continue;}
case 1679:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","addToCombat","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/String;)Z","invokestatic",1682);}
case 1682:{f.Pc=f.Pop().Int==0?1688:1685;continue;}
case 1685:{f.Push(JValue.I(1));f.Pc=1686;continue;}
case 1686:{f.Locals[18]=f.Pop();f.Pc=1688;continue;}
case 1688:{f.Push(f.Locals[1]);f.Pc=1689;continue;}
case 1689:{return rt.Call(f,"forge/game/spellability/SpellAbility","isNinjutsu","()Z","invokevirtual",1692);}
case 1692:{f.Pc=f.Pop().Int==0?1752:1695;continue;}
case 1695:{f.Push(f.Locals[1]);f.Pc=1696;continue;}
case 1696:{f.Push(JValue.R(rt.String("Returned")));f.Pc=1699;continue;}
case 1699:{f.Push(JValue.I(1));f.Pc=1700;continue;}
case 1700:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",1703);}
case 1703:{return rt.Call(f,"forge/game/card/CardCollection","getFirst","()Ljava/lang/Object;","invokevirtual",1706);}
case 1706:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1709;continue;}
case 1709:{f.Locals[27]=f.Pop();f.Pc=1711;continue;}
case 1711:{f.Push(f.Locals[5]);f.Pc=1713;continue;}
case 1713:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1716);}
case 1716:{f.Push(f.Locals[27]);f.Pc=1718;continue;}
case 1718:{return rt.Call(f,"forge/game/combat/Combat","getDefenderByAttacker","(Lforge/game/card/Card;)Lforge/game/GameEntity;","invokevirtual",1721);}
case 1721:{f.Locals[28]=f.Pop();f.Pc=1723;continue;}
case 1723:{f.Push(f.Locals[5]);f.Pc=1725;continue;}
case 1725:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1728);}
case 1728:{f.Push(f.Locals[25]);f.Pc=1730;continue;}
case 1730:{f.Push(f.Locals[28]);f.Pc=1732;continue;}
case 1732:{return rt.Call(f,"forge/game/combat/Combat","addAttacker","(Lforge/game/card/Card;Lforge/game/GameEntity;)V","invokevirtual",1735);}
case 1735:{f.Push(f.Locals[5]);f.Pc=1737;continue;}
case 1737:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",1740);}
case 1740:{f.Push(f.Locals[25]);f.Pc=1742;continue;}
case 1742:{return rt.Call(f,"forge/game/combat/Combat","getBandOfAttacker","(Lforge/game/card/Card;)Lforge/game/combat/AttackingBand;","invokevirtual",1745);}
case 1745:{f.Push(JValue.I(0));f.Pc=1746;continue;}
case 1746:{return rt.Call(f,"forge/game/combat/AttackingBand","setBlocked","(Z)V","invokevirtual",1749);}
case 1749:{f.Push(JValue.I(1));f.Pc=1750;continue;}
case 1750:{f.Locals[18]=f.Pop();f.Pc=1752;continue;}
case 1752:{f.Push(f.Locals[1]);f.Pc=1753;continue;}
case 1753:{f.Push(JValue.R(rt.String("AttachAfter")));f.Pc=1756;continue;}
case 1756:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1759);}
case 1759:{f.Pc=f.Pop().Int==0?2365:1762;continue;}
case 1762:{f.Push(f.Locals[25]);f.Pc=1764;continue;}
case 1764:{return rt.Call(f,"forge/game/card/Card","isAttachment","()Z","invokevirtual",1767);}
case 1767:{f.Pc=f.Pop().Int==0?2365:1770;continue;}
case 1770:{f.Push(f.Locals[4]);f.Pc=1772;continue;}
case 1772:{f.Push(f.Locals[1]);f.Pc=1773;continue;}
case 1773:{f.Push(JValue.R(rt.String("AttachAfter")));f.Pc=1776;continue;}
case 1776:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1779);}
case 1779:{f.Push(f.Locals[1]);f.Pc=1780;continue;}
case 1780:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1783);}
case 1783:{f.Locals[27]=f.Pop();f.Pc=1785;continue;}
case 1785:{f.Push(f.Locals[27]);f.Pc=1787;continue;}
case 1787:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1790);}
case 1790:{f.Pc=f.Pop().Int==0?1821:1793;continue;}
case 1793:{f.Push(f.Locals[5]);f.Pc=1795;continue;}
case 1795:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1798;continue;}
case 1798:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1801);}
case 1801:{f.Push(f.Locals[1]);f.Pc=1802;continue;}
case 1802:{f.Push(JValue.R(rt.String("AttachAfter")));f.Pc=1805;continue;}
case 1805:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1808);}
case 1808:{f.Push(f.Locals[4]);f.Pc=1810;continue;}
case 1810:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",1813);}
case 1813:{f.Push(f.Locals[4]);f.Pc=1815;continue;}
case 1815:{f.Push(f.Locals[1]);f.Pc=1816;continue;}
case 1816:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1819);}
case 1819:{f.Locals[27]=f.Pop();f.Pc=1821;continue;}
case 1821:{f.Push(f.Locals[27]);f.Pc=1823;continue;}
case 1823:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1826);}
case 1826:{f.Pc=f.Pop().Int!=0?1898:1829;continue;}
case 1829:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1832);}
case 1832:{f.Push(JValue.R(rt.String("lblSelectACardAttachSourceTo")));f.Pc=1835;continue;}
case 1835:{f.Push(JValue.I(1));f.Pc=1836;continue;}
case 1836:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1839;continue;}
case 1839:{f.StackOp("dup");f.Pc=1840;continue;}
case 1840:{f.Push(JValue.I(0));f.Pc=1841;continue;}
case 1841:{f.Push(f.Locals[22]);f.Pc=1843;continue;}
case 1843:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",1846);}
case 1846:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1847;continue;}
case 1847:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1850);}
case 1850:{f.Locals[28]=f.Pop();f.Pc=1852;continue;}
case 1852:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",1855);}
case 1855:{f.Locals[29]=f.Pop();f.Pc=1857;continue;}
case 1857:{f.Push(f.Locals[29]);f.Pc=1859;continue;}
case 1859:{f.Push(JValue.R(rt.String("Attach")));f.Pc=1862;continue;}
case 1862:{f.Push(f.Locals[22]);f.Pc=1864;continue;}
case 1864:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1869);}
case 1869:{f.StackOp("pop");f.Pc=1870;continue;}
case 1870:{f.Push(f.Locals[19]);f.Pc=1872;continue;}
case 1872:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1875);}
case 1875:{f.Push(f.Locals[27]);f.Pc=1877;continue;}
case 1877:{f.Push(f.Locals[1]);f.Pc=1878;continue;}
case 1878:{f.Push(f.Locals[28]);f.Pc=1880;continue;}
case 1880:{f.Push(f.Locals[29]);f.Pc=1882;continue;}
case 1882:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",1885);}
case 1885:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1888;continue;}
case 1888:{f.Locals[30]=f.Pop();f.Pc=1890;continue;}
case 1890:{f.Push(f.Locals[25]);f.Pc=1892;continue;}
case 1892:{f.Push(f.Locals[30]);f.Pc=1894;continue;}
case 1894:{f.Push(f.Locals[1]);f.Pc=1895;continue;}
case 1895:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1898);}
case 1898:{f.Pc=2365;continue;}
case 1901:{f.Push(f.Locals[7]);f.Pc=1903;continue;}
case 1903:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=1906;continue;}
case 1906:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",1909);}
case 1909:{f.Pc=f.Pop().Int==0?1931:1912;continue;}
case 1912:{f.Push(f.Locals[22]);f.Pc=1914;continue;}
case 1914:{f.Push(f.Locals[1]);f.Pc=1915;continue;}
case 1915:{f.Push(JValue.I(1));f.Pc=1916;continue;}
case 1916:{return rt.Call(f,"forge/game/card/Card","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",1919);}
case 1919:{f.Pc=f.Pop().Int!=0?1925:1922;continue;}
case 1922:{f.Pc=540;continue;}
case 1925:{f.Push(f.Locals[22]);f.Pc=1927;continue;}
case 1927:{f.Push(f.Locals[1]);f.Pc=1928;continue;}
case 1928:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",1931);}
case 1931:{f.Push(f.Locals[5]);f.Pc=1933;continue;}
case 1933:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1936);}
case 1936:{f.Push(f.Locals[7]);f.Pc=1938;continue;}
case 1938:{f.Push(f.Locals[22]);f.Pc=1940;continue;}
case 1940:{f.Push(f.Locals[9]);f.Pc=1942;continue;}
case 1942:{f.Push(f.Locals[1]);f.Pc=1943;continue;}
case 1943:{f.Push(f.Locals[26]);f.Pc=1945;continue;}
case 1945:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",1948);}
case 1948:{f.Locals[25]=f.Pop();f.Pc=1950;continue;}
case 1950:{f.Push(f.Locals[7]);f.Pc=1952;continue;}
case 1952:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=1955;continue;}
case 1955:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",1958);}
case 1958:{f.Pc=f.Pop().Int==0?2001:1961;continue;}
case 1961:{f.Push(f.Locals[12]);f.Pc=1963;continue;}
case 1963:{f.Push(f.Locals[22]);f.Pc=1965;continue;}
case 1965:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",1970);}
case 1970:{f.Pc=f.Pop().Int==0?2001:1973;continue;}
case 1973:{f.Push(f.Locals[4]);f.Pc=1975;continue;}
case 1975:{f.Push(f.Locals[22]);f.Pc=1977;continue;}
case 1977:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",1980);}
case 1980:{f.Pc=f.Pop().Int==0?2001:1983;continue;}
case 1983:{f.Push(f.Locals[25]);f.Pc=1985;continue;}
case 1985:{f.Push(f.Locals[1]);f.Pc=1986;continue;}
case 1986:{f.Push(f.Locals[12]);f.Pc=1988;continue;}
case 1988:{f.Push(f.Locals[22]);f.Pc=1990;continue;}
case 1990:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1995);}
case 1995:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1998;continue;}
case 1998:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)V","invokestatic",2001);}
case 2001:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=2004;continue;}
case 2004:{f.Push(f.Locals[7]);f.Pc=2006;continue;}
case 2006:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",2009);}
case 2009:{f.Pc=f.Pop().Int==0?2090:2012;continue;}
case 2012:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=2015;continue;}
case 2015:{f.Push(f.Locals[24]);f.Pc=2017;continue;}
case 2017:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",2020);}
case 2020:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",2023);}
case 2023:{f.Pc=f.Pop().Int==0?2090:2026;continue;}
case 2026:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=2029;continue;}
case 2029:{f.StackOp("dup");f.Pc=2030;continue;}
case 2030:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",2033);}
case 2033:{f.Locals[27]=f.Pop();f.Pc=2035;continue;}
case 2035:{f.Push(f.Locals[27]);f.Pc=2037;continue;}
case 2037:{f.Push(f.Locals[25]);f.Pc=2039;continue;}
case 2039:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",2042);}
case 2042:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2045);}
case 2045:{f.Push(JValue.R(rt.String(" has moved from Command Zone to ")));f.Pc=2048;continue;}
case 2048:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2051);}
case 2051:{f.Push(f.Locals[3]);f.Pc=2052;continue;}
case 2052:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",2055);}
case 2055:{f.Push(JValue.R(rt.String("'s hand.")));f.Pc=2058;continue;}
case 2058:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2061);}
case 2061:{f.StackOp("pop");f.Pc=2062;continue;}
case 2062:{f.Push(f.Locals[5]);f.Pc=2064;continue;}
case 2064:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=2067;continue;}
case 2067:{f.StackOp("dup");f.Pc=2068;continue;}
case 2068:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;"));f.Pc=2071;continue;}
case 2071:{f.Push(f.Locals[27]);f.Pc=2073;continue;}
case 2073:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",2076);}
case 2076:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",2079);}
case 2079:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",2082);}
case 2082:{f.Push(f.Locals[6]);f.Pc=2084;continue;}
case 2084:{f.Push(f.Locals[25]);f.Pc=2086;continue;}
case 2086:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",2089);}
case 2089:{f.StackOp("pop");f.Pc=2090;continue;}
case 2090:{f.Push(f.Locals[1]);f.Pc=2091;continue;}
case 2091:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=2094;continue;}
case 2094:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2097);}
case 2097:{f.Pc=f.Pop().Int==0?2142:2100;continue;}
case 2100:{f.Push(f.Locals[1]);f.Pc=2101;continue;}
case 2101:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=2104;continue;}
case 2104:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2107);}
case 2107:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",2110);}
case 2110:{f.Locals[27]=f.Pop();f.Pc=2112;continue;}
case 2112:{f.Push(f.Locals[4]);f.Pc=2114;continue;}
case 2114:{f.Push(f.Locals[1]);f.Pc=2115;continue;}
case 2115:{f.Push(JValue.R(rt.String("WithCountersAmount")));f.Pc=2118;continue;}
case 2118:{f.Push(JValue.R(rt.String("1")));f.Pc=2121;continue;}
case 2121:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2124);}
case 2124:{f.Push(f.Locals[1]);f.Pc=2125;continue;}
case 2125:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",2128);}
case 2128:{f.Locals[28]=f.Pop();f.Pc=2130;continue;}
case 2130:{f.Push(f.Locals[25]);f.Pc=2132;continue;}
case 2132:{f.Push(f.Locals[27]);f.Pc=2134;continue;}
case 2134:{f.Push(f.Locals[28]);f.Pc=2136;continue;}
case 2136:{f.Push(f.Locals[3]);f.Pc=2137;continue;}
case 2137:{f.Push(f.Locals[10]);f.Pc=2139;continue;}
case 2139:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",2142);}
case 2142:{f.Push(f.Locals[1]);f.Pc=2143;continue;}
case 2143:{f.Push(JValue.R(rt.String("ExileFaceDown")));f.Pc=2145;continue;}
case 2145:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2148);}
case 2148:{f.Pc=f.Pop().Int!=0?2161:2151;continue;}
case 2151:{f.Push(f.Locals[1]);f.Pc=2152;continue;}
case 2152:{f.Push(JValue.R(rt.String("FaceDown")));f.Pc=2155;continue;}
case 2155:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2158);}
case 2158:{f.Pc=f.Pop().Int==0?2168:2161;continue;}
case 2161:{f.Push(f.Locals[25]);f.Pc=2163;continue;}
case 2163:{f.Push(JValue.I(1));f.Pc=2164;continue;}
case 2164:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",2167);}
case 2167:{f.StackOp("pop");f.Pc=2168;continue;}
case 2168:{f.Push(f.Locals[1]);f.Pc=2169;continue;}
case 2169:{f.Push(JValue.R(rt.String("Foretold")));f.Pc=2172;continue;}
case 2172:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2175);}
case 2175:{f.Pc=f.Pop().Int==0?2200:2178;continue;}
case 2178:{f.Push(f.Locals[25]);f.Pc=2180;continue;}
case 2180:{f.Push(JValue.I(1));f.Pc=2181;continue;}
case 2181:{return rt.Call(f,"forge/game/card/Card","setForetold","(Z)V","invokevirtual",2184);}
case 2184:{f.Push(f.Locals[1]);f.Pc=2185;continue;}
case 2185:{f.Push(JValue.R(rt.String("ForetoldCost")));f.Pc=2188;continue;}
case 2188:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2191);}
case 2191:{f.Pc=f.Pop().Int==0?2200:2194;continue;}
case 2194:{f.Push(f.Locals[25]);f.Pc=2196;continue;}
case 2196:{f.Push(JValue.I(1));f.Pc=2197;continue;}
case 2197:{return rt.Call(f,"forge/game/card/Card","setForetoldCostByEffect","(Z)V","invokevirtual",2200);}
case 2200:{f.Push(f.Locals[1]);f.Pc=2201;continue;}
case 2201:{f.Push(JValue.R(rt.String("WithMayLook")));f.Pc=2204;continue;}
case 2204:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2207);}
case 2207:{f.Pc=f.Pop().Int!=0?2220:2210;continue;}
case 2210:{f.Push(f.Locals[1]);f.Pc=2211;continue;}
case 2211:{f.Push(JValue.R(rt.String("Foretold")));f.Pc=2214;continue;}
case 2214:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2217);}
case 2217:{f.Pc=f.Pop().Int==0?2226:2220;continue;}
case 2220:{f.Push(f.Locals[25]);f.Pc=2222;continue;}
case 2222:{f.Push(f.Locals[3]);f.Pc=2223;continue;}
case 2223:{return rt.Call(f,"forge/game/card/Card","addMayLookFaceDownExile","(Lforge/game/player/Player;)V","invokevirtual",2226);}
case 2226:{f.Push(f.Locals[1]);f.Pc=2227;continue;}
case 2227:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",2230);}
case 2230:{f.Pc=f.Pop().Int==0?2349:2233;continue;}
case 2233:{f.Push(f.Locals[1]);f.Pc=2234;continue;}
case 2234:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",2237);}
case 2237:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","WARP","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","WARP","Lforge/game/keyword/Keyword;"));f.Pc=2240;continue;}
case 2240:{return rt.Call(f,"forge/game/trigger/Trigger","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",2243);}
case 2243:{f.Pc=f.Pop().Int==0?2349:2246;continue;}
case 2246:{f.Push(f.Locals[1]);f.Pc=2247;continue;}
case 2247:{f.Push(f.Locals[1]);f.Pc=2248;continue;}
case 2248:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",2251);}
case 2251:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",2254);}
case 2254:{f.Push(f.Locals[1]);f.Pc=2255;continue;}
case 2255:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",2258);}
case 2258:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",2261);}
case 2261:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3109:2261:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2266);}
case 2266:{f.Push(f.Locals[1]);f.Pc=2267;continue;}
case 2267:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",2270);}
case 2270:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",2273);}
case 2273:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",2276);}
case 2276:{f.Locals[27]=f.Pop();f.Pc=2278;continue;}
case 2278:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=2281;continue;}
case 2281:{f.StackOp("dup");f.Pc=2282;continue;}
case 2282:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",2285);}
case 2285:{f.Locals[28]=f.Pop();f.Pc=2287;continue;}
case 2287:{f.Push(f.Locals[28]);f.Pc=2289;continue;}
case 2289:{f.Push(JValue.R(rt.String("Mode$ Continuous | MayPlay$ True | EffectZone$ Command | Affected$ Card.IsRemembered+nonLand+!ThisTurnEntered")));f.Pc=2292;continue;}
case 2292:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2295);}
case 2295:{f.StackOp("pop");f.Pc=2296;continue;}
case 2296:{f.Push(f.Locals[28]);f.Pc=2298;continue;}
case 2298:{f.Push(JValue.R(rt.String(" | AffectedZone$ Exile | Description$ You may cast the card.")));f.Pc=2301;continue;}
case 2301:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",2304);}
case 2304:{f.StackOp("pop");f.Pc=2305;continue;}
case 2305:{f.Push(f.Locals[27]);f.Pc=2307;continue;}
case 2307:{f.Push(f.Locals[28]);f.Pc=2309;continue;}
case 2309:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",2312);}
case 2312:{return rt.Call(f,"forge/game/card/Card","addStaticAbility","(Ljava/lang/String;)Lforge/game/staticability/StaticAbility;","invokevirtual",2315);}
case 2315:{f.StackOp("pop");f.Pc=2316;continue;}
case 2316:{f.Push(f.Locals[27]);f.Pc=2318;continue;}
case 2318:{f.Push(f.Locals[25]);f.Pc=2320;continue;}
case 2320:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",2323);}
case 2323:{f.Push(f.Locals[27]);f.Pc=2325;continue;}
case 2325:{f.Push(JValue.R(rt.String("Exile")));f.Pc=2327;continue;}
case 2327:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","addForgetOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",2330);}
case 2330:{f.Push(f.Locals[27]);f.Pc=2332;continue;}
case 2332:{f.Push(JValue.R(rt.String("Card.IsRemembered")));f.Pc=2335;continue;}
case 2335:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","addForgetOnCastTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",2338);}
case 2338:{f.Push(f.Locals[5]);f.Pc=2340;continue;}
case 2340:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",2343);}
case 2343:{f.Push(f.Locals[27]);f.Pc=2345;continue;}
case 2345:{f.Push(f.Locals[1]);f.Pc=2346;continue;}
case 2346:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",2349);}
case 2349:{f.Push(f.Locals[1]);f.Pc=2350;continue;}
case 2350:{f.Push(JValue.R(rt.String("TrackDiscarded")));f.Pc=2353;continue;}
case 2353:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2356);}
case 2356:{f.Pc=f.Pop().Int==0?2365:2359;continue;}
case 2359:{f.Push(f.Locals[25]);f.Pc=2361;continue;}
case 2361:{f.Push(JValue.I(1));f.Pc=2362;continue;}
case 2362:{return rt.Call(f,"forge/game/card/Card","setDiscarded","(Z)V","invokevirtual",2365);}
case 2365:{f.Push(f.Locals[25]);f.Pc=2367;continue;}
case 2367:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",2370);}
case 2370:{f.Push(f.Locals[24]);f.Pc=2372;continue;}
case 2372:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",2375);}
case 2375:{f.Pc=f.Pop().Int!=0?2816:2378;continue;}
case 2378:{f.Push(JValue.R(null));f.Pc=2379;continue;}
case 2379:{f.Locals[27]=f.Pop();f.Pc=2381;continue;}
case 2381:{f.Push(f.Locals[22]);f.Pc=2383;continue;}
case 2383:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",2386);}
case 2386:{f.Pc=f.Pop().Reference==null?2454:2389;continue;}
case 2389:{f.Push(f.Locals[5]);f.Pc=2391;continue;}
case 2391:{f.Push(f.Locals[22]);f.Pc=2393;continue;}
case 2393:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",2396);}
case 2396:{f.Push(JValue.R(null));f.Pc=2397;continue;}
case 2397:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",2400);}
case 2400:{f.Locals[27]=f.Pop();f.Pc=2402;continue;}
case 2402:{f.Push(f.Locals[1]);f.Pc=2403;continue;}
case 2403:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=2406;continue;}
case 2406:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2409);}
case 2409:{f.Pc=f.Pop().Int==0?2454:2412;continue;}
case 2412:{f.Push(f.Locals[1]);f.Pc=2413;continue;}
case 2413:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=2416;continue;}
case 2416:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2419);}
case 2419:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",2422);}
case 2422:{f.Locals[28]=f.Pop();f.Pc=2424;continue;}
case 2424:{f.Push(f.Locals[4]);f.Pc=2426;continue;}
case 2426:{f.Push(f.Locals[1]);f.Pc=2427;continue;}
case 2427:{f.Push(JValue.R(rt.String("WithCountersAmount")));f.Pc=2430;continue;}
case 2430:{f.Push(JValue.R(rt.String("1")));f.Pc=2433;continue;}
case 2433:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2436);}
case 2436:{f.Push(f.Locals[1]);f.Pc=2437;continue;}
case 2437:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",2440);}
case 2440:{f.Locals[29]=f.Pop();f.Pc=2442;continue;}
case 2442:{f.Push(f.Locals[27]);f.Pc=2444;continue;}
case 2444:{f.Push(f.Locals[28]);f.Pc=2446;continue;}
case 2446:{f.Push(f.Locals[29]);f.Pc=2448;continue;}
case 2448:{f.Push(f.Locals[3]);f.Pc=2449;continue;}
case 2449:{f.Push(f.Locals[10]);f.Pc=2451;continue;}
case 2451:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",2454);}
case 2454:{f.Push(f.Locals[22]);f.Pc=2456;continue;}
case 2456:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",2459);}
case 2459:{f.Pc=f.Pop().Int==0?2561:2462;continue;}
case 2462:{f.Push(f.Locals[22]);f.Pc=2464;continue;}
case 2464:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",2467);}
case 2467:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",2472);}
case 2472:{f.Locals[28]=f.Pop();f.Pc=2474;continue;}
case 2474:{f.Push(f.Locals[28]);f.Pc=2476;continue;}
case 2476:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2481);}
case 2481:{f.Pc=f.Pop().Int==0?2561:2484;continue;}
case 2484:{f.Push(f.Locals[28]);f.Pc=2486;continue;}
case 2486:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2491);}
case 2491:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2494;continue;}
case 2494:{f.Locals[29]=f.Pop();f.Pc=2496;continue;}
case 2496:{f.Push(f.Locals[29]);f.Pc=2498;continue;}
case 2498:{f.Push(f.Locals[22]);f.Pc=2500;continue;}
case 2500:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?2506:2503;continue;}
case 2503:{f.Pc=2474;continue;}
case 2506:{f.Push(f.Locals[1]);f.Pc=2507;continue;}
case 2507:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=2510;continue;}
case 2510:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2513);}
case 2513:{f.Pc=f.Pop().Int==0?2558:2516;continue;}
case 2516:{f.Push(f.Locals[1]);f.Pc=2517;continue;}
case 2517:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=2520;continue;}
case 2520:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2523);}
case 2523:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",2526);}
case 2526:{f.Locals[30]=f.Pop();f.Pc=2528;continue;}
case 2528:{f.Push(f.Locals[4]);f.Pc=2530;continue;}
case 2530:{f.Push(f.Locals[1]);f.Pc=2531;continue;}
case 2531:{f.Push(JValue.R(rt.String("WithCountersAmount")));f.Pc=2534;continue;}
case 2534:{f.Push(JValue.R(rt.String("1")));f.Pc=2537;continue;}
case 2537:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2540);}
case 2540:{f.Push(f.Locals[1]);f.Pc=2541;continue;}
case 2541:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",2544);}
case 2544:{f.Locals[31]=f.Pop();f.Pc=2546;continue;}
case 2546:{f.Push(f.Locals[29]);f.Pc=2548;continue;}
case 2548:{f.Push(f.Locals[30]);f.Pc=2550;continue;}
case 2550:{f.Push(f.Locals[31]);f.Pc=2552;continue;}
case 2552:{f.Push(f.Locals[3]);f.Pc=2553;continue;}
case 2553:{f.Push(f.Locals[10]);f.Pc=2555;continue;}
case 2555:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",2558);}
case 2558:{f.Pc=2474;continue;}
case 2561:{f.Push(f.Locals[13]);f.Pc=2563;continue;}
case 2563:{f.Pc=f.Pop().Reference==null?2647:2566;continue;}
case 2566:{f.Push(f.Locals[4]);f.Pc=2568;continue;}
case 2568:{f.Push(f.Locals[25]);f.Pc=2570;continue;}
case 2570:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",2573);}
case 2573:{f.Push(f.Locals[27]);f.Pc=2575;continue;}
case 2575:{f.Pc=f.Pop().Reference==null?2585:2578;continue;}
case 2578:{f.Push(f.Locals[4]);f.Pc=2580;continue;}
case 2580:{f.Push(f.Locals[27]);f.Pc=2582;continue;}
case 2582:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",2585);}
case 2585:{f.Push(f.Locals[22]);f.Pc=2587;continue;}
case 2587:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",2590);}
case 2590:{f.Pc=f.Pop().Int==0?2647:2593;continue;}
case 2593:{f.Push(f.Locals[22]);f.Pc=2595;continue;}
case 2595:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",2598);}
case 2598:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",2603);}
case 2603:{f.Locals[28]=f.Pop();f.Pc=2605;continue;}
case 2605:{f.Push(f.Locals[28]);f.Pc=2607;continue;}
case 2607:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2612);}
case 2612:{f.Pc=f.Pop().Int==0?2647:2615;continue;}
case 2615:{f.Push(f.Locals[28]);f.Pc=2617;continue;}
case 2617:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2622);}
case 2622:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2625;continue;}
case 2625:{f.Locals[29]=f.Pop();f.Pc=2627;continue;}
case 2627:{f.Push(f.Locals[29]);f.Pc=2629;continue;}
case 2629:{f.Push(f.Locals[22]);f.Pc=2631;continue;}
case 2631:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?2637:2634;continue;}
case 2634:{f.Pc=2605;continue;}
case 2637:{f.Push(f.Locals[4]);f.Pc=2639;continue;}
case 2639:{f.Push(f.Locals[29]);f.Pc=2641;continue;}
case 2641:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",2644);}
case 2644:{f.Pc=2605;continue;}
case 2647:{f.Push(f.Locals[14]);f.Pc=2649;continue;}
case 2649:{f.Pc=f.Pop().Reference==null?2659:2652;continue;}
case 2652:{f.Push(f.Locals[4]);f.Pc=2654;continue;}
case 2654:{f.Push(f.Locals[25]);f.Pc=2656;continue;}
case 2656:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",2659);}
case 2659:{f.Push(f.Locals[15]);f.Pc=2661;continue;}
case 2661:{f.Pc=f.Pop().Reference==null?2816:2664;continue;}
case 2664:{f.Push(f.Locals[4]);f.Pc=2666;continue;}
case 2666:{f.Push(f.Locals[25]);f.Pc=2668;continue;}
case 2668:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",2671);}
case 2671:{f.Push(f.Locals[22]);f.Pc=2673;continue;}
case 2673:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",2676);}
case 2676:{f.Pc=f.Pop().Int==0?2816:2679;continue;}
case 2679:{f.Push(f.Locals[22]);f.Pc=2681;continue;}
case 2681:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",2684);}
case 2684:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",2689);}
case 2689:{f.Locals[28]=f.Pop();f.Pc=2691;continue;}
case 2691:{f.Push(f.Locals[28]);f.Pc=2693;continue;}
case 2693:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2698);}
case 2698:{f.Pc=f.Pop().Int==0?2733:2701;continue;}
case 2701:{f.Push(f.Locals[28]);f.Pc=2703;continue;}
case 2703:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2708);}
case 2708:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2711;continue;}
case 2711:{f.Locals[29]=f.Pop();f.Pc=2713;continue;}
case 2713:{f.Push(f.Locals[29]);f.Pc=2715;continue;}
case 2715:{f.Push(f.Locals[22]);f.Pc=2717;continue;}
case 2717:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?2723:2720;continue;}
case 2720:{f.Pc=2691;continue;}
case 2723:{f.Push(f.Locals[4]);f.Pc=2725;continue;}
case 2725:{f.Push(f.Locals[29]);f.Pc=2727;continue;}
case 2727:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",2730);}
case 2730:{f.Pc=2691;continue;}
case 2733:{f.Push(f.Locals[1]);f.Pc=2734;continue;}
case 2734:{f.Push(JValue.R(rt.String("ImprintLast")));f.Pc=2737;continue;}
case 2737:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2740);}
case 2740:{f.Pc=f.Pop().Int==0?2816:2743;continue;}
case 2743:{f.Push(JValue.R(null));f.Pc=2744;continue;}
case 2744:{f.Locals[28]=f.Pop();f.Pc=2746;continue;}
case 2746:{f.Push(f.Locals[25]);f.Pc=2748;continue;}
case 2748:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",2751);}
case 2751:{f.Push(f.Locals[7]);f.Pc=2753;continue;}
case 2753:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",2756);}
case 2756:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",2761);}
case 2761:{f.Locals[29]=f.Pop();f.Pc=2763;continue;}
case 2763:{f.Push(f.Locals[29]);f.Pc=2765;continue;}
case 2765:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2770);}
case 2770:{f.Pc=f.Pop().Int==0?2809:2773;continue;}
case 2773:{f.Push(f.Locals[29]);f.Pc=2775;continue;}
case 2775:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2780);}
case 2780:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2783;continue;}
case 2783:{f.Locals[30]=f.Pop();f.Pc=2785;continue;}
case 2785:{f.Push(f.Locals[4]);f.Pc=2787;continue;}
case 2787:{f.Push(f.Locals[30]);f.Pc=2789;continue;}
case 2789:{return rt.Call(f,"forge/game/card/Card","hasImprintedCard","(Lforge/game/card/Card;)Z","invokevirtual",2792);}
case 2792:{f.Pc=f.Pop().Int==0?2806:2795;continue;}
case 2795:{f.Push(f.Locals[4]);f.Pc=2797;continue;}
case 2797:{f.Push(f.Locals[30]);f.Pc=2799;continue;}
case 2799:{return rt.Call(f,"forge/game/card/Card","removeImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",2802);}
case 2802:{f.Push(f.Locals[30]);f.Pc=2804;continue;}
case 2804:{f.Locals[28]=f.Pop();f.Pc=2806;continue;}
case 2806:{f.Pc=2763;continue;}
case 2809:{f.Push(f.Locals[4]);f.Pc=2811;continue;}
case 2811:{f.Push(f.Locals[28]);f.Pc=2813;continue;}
case 2813:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",2816);}
case 2816:{f.Pc=540;continue;}
case 2819:{f.Push(f.Locals[18]);f.Pc=2821;continue;}
case 2821:{f.Pc=f.Pop().Int==0?2841:2824;continue;}
case 2824:{f.Push(f.Locals[5]);f.Pc=2826;continue;}
case 2826:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",2829);}
case 2829:{f.Push(f.Locals[5]);f.Pc=2831;continue;}
case 2831:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=2834;continue;}
case 2834:{f.StackOp("dup");f.Pc=2835;continue;}
case 2835:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",2838);}
case 2838:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",2841);}
case 2841:{f.Push(f.Locals[6]);f.Pc=2843;continue;}
case 2843:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",2846);}
case 2846:{f.Pc=f.Pop().Int!=0?2864:2849;continue;}
case 2849:{f.Push(f.Locals[5]);f.Pc=2851;continue;}
case 2851:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",2854);}
case 2854:{f.Push(f.Locals[6]);f.Pc=2856;continue;}
case 2856:{f.Push(f.Locals[3]);f.Pc=2857;continue;}
case 2857:{f.Push(JValue.I(1));f.Pc=2858;continue;}
case 2858:{f.Push(JValue.R(rt.String("Revealed cards in ")));f.Pc=2861;continue;}
case 2861:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",2864);}
case 2864:{f.Push(f.Locals[11]);f.Pc=2866;continue;}
case 2866:{f.Push(f.Locals[5]);f.Pc=2868;continue;}
case 2868:{f.Push(f.Locals[1]);f.Pc=2869;continue;}
case 2869:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",2872);}
case 2872:{f.Push(f.Locals[10]);f.Pc=2874;continue;}
case 2874:{f.Push(f.Locals[5]);f.Pc=2876;continue;}
case 2876:{f.Push(f.Locals[1]);f.Pc=2877;continue;}
case 2877:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",2880);}
case 2880:{f.Push(f.Locals[1]);f.Pc=2881;continue;}
case 2881:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=2884;continue;}
case 2884:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2887);}
case 2887:{f.Pc=f.Pop().Int==0?2914:2890;continue;}
case 2890:{f.Push(f.Locals[11]);f.Pc=2892;continue;}
case 2892:{return rt.Call(f,"forge/game/card/CardZoneTable","isEmpty","()Z","invokevirtual",2895);}
case 2895:{f.Pc=f.Pop().Int!=0?2914:2898;continue;}
case 2898:{f.Push(f.Locals[1]);f.Pc=2899;continue;}
case 2899:{f.Push(f.Locals[1]);f.Pc=2900;continue;}
case 2900:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=2903;continue;}
case 2903:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2906);}
case 2906:{f.Push(f.Locals[11]);f.Pc=2908;continue;}
case 2908:{return rt.Call(f,"forge/game/card/CardZoneTable","allCards","()Ljava/lang/Iterable;","invokevirtual",2911);}
case 2911:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V","invokestatic",2914);}
case 2914:{f.Push(f.Locals[11]);f.Pc=2916;continue;}
case 2916:{f.Push(f.Locals[1]);f.Pc=2917;continue;}
case 2917:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","changeZoneUntilCommand","(Lforge/game/card/CardZoneTable;Lforge/game/spellability/SpellAbility;)V","invokestatic",2920);}
case 2920:{f.Push(f.Locals[7]);f.Pc=2922;continue;}
case 2922:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=2925;continue;}
case 2925:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",2928);}
case 2928:{f.Pc=f.Pop().Int==0?2940:2931;continue;}
case 2931:{f.Push(f.Locals[11]);f.Pc=2933;continue;}
case 2933:{return rt.Call(f,"forge/game/card/CardZoneTable","allCards","()Ljava/lang/Iterable;","invokevirtual",2936);}
case 2936:{f.Push(f.Locals[1]);f.Pc=2937;continue;}
case 2937:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","handleExiledWith","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;)V","invokestatic",2940);}
case 2940:{f.Push(f.Locals[7]);f.Pc=2942;continue;}
case 2942:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=2945;continue;}
case 2945:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",2948);}
case 2948:{f.Pc=f.Pop().Int==0?3094:2951;continue;}
case 2951:{f.Push(f.Locals[17]);f.Pc=2953;continue;}
case 2953:{f.Pc=f.Pop().Int==0?3094:2956;continue;}
case 2956:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=2959;continue;}
case 2959:{f.StackOp("dup");f.Pc=2960;continue;}
case 2960:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",2963);}
case 2963:{f.Locals[20]=f.Pop();f.Pc=2965;continue;}
case 2965:{f.Push(f.Locals[1]);f.Pc=2966;continue;}
case 2966:{f.Push(JValue.R(rt.String("TargetsWithDefinedController")));f.Pc=2969;continue;}
case 2969:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2972);}
case 2972:{f.Pc=f.Pop().Int==0?2997:2975;continue;}
case 2975:{f.Push(f.Locals[20]);f.Pc=2977;continue;}
case 2977:{f.Push(f.Locals[4]);f.Pc=2979;continue;}
case 2979:{f.Push(f.Locals[1]);f.Pc=2980;continue;}
case 2980:{f.Push(JValue.R(rt.String("TargetsWithDefinedController")));f.Pc=2983;continue;}
case 2983:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2986);}
case 2986:{f.Push(f.Locals[1]);f.Pc=2987;continue;}
case 2987:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",2990);}
case 2990:{return rt.Call(f,"forge/game/player/PlayerCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",2993);}
case 2993:{f.StackOp("pop");f.Pc=2994;continue;}
case 2994:{f.Pc=3056;continue;}
case 2997:{f.Push(f.Locals[2]);f.Pc=2998;continue;}
case 2998:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",3003);}
case 3003:{f.Locals[21]=f.Pop();f.Pc=3005;continue;}
case 3005:{f.Push(f.Locals[21]);f.Pc=3007;continue;}
case 3007:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3012);}
case 3012:{f.Pc=f.Pop().Int==0?3041:3015;continue;}
case 3015:{f.Push(f.Locals[21]);f.Pc=3017;continue;}
case 3017:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3022);}
case 3022:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3025;continue;}
case 3025:{f.Locals[22]=f.Pop();f.Pc=3027;continue;}
case 3027:{f.Push(f.Locals[20]);f.Pc=3029;continue;}
case 3029:{f.Push(f.Locals[22]);f.Pc=3031;continue;}
case 3031:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",3034);}
case 3034:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",3037);}
case 3037:{f.StackOp("pop");f.Pc=3038;continue;}
case 3038:{f.Pc=3005;continue;}
case 3041:{f.Push(f.Locals[20]);f.Pc=3043;continue;}
case 3043:{return rt.Call(f,"forge/game/player/PlayerCollection","isEmpty","()Z","invokevirtual",3046);}
case 3046:{f.Pc=f.Pop().Int==0?3056:3049;continue;}
case 3049:{f.Push(f.Locals[20]);f.Pc=3051;continue;}
case 3051:{f.Push(f.Locals[3]);f.Pc=3052;continue;}
case 3052:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",3055);}
case 3055:{f.StackOp("pop");f.Pc=3056;continue;}
case 3056:{f.Push(f.Locals[20]);f.Pc=3058;continue;}
case 3058:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",3061);}
case 3061:{f.Locals[21]=f.Pop();f.Pc=3063;continue;}
case 3063:{f.Push(f.Locals[21]);f.Pc=3065;continue;}
case 3065:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3070);}
case 3070:{f.Pc=f.Pop().Int==0?3094:3073;continue;}
case 3073:{f.Push(f.Locals[21]);f.Pc=3075;continue;}
case 3075:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3080);}
case 3080:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3083;continue;}
case 3083:{f.Locals[22]=f.Pop();f.Pc=3085;continue;}
case 3085:{f.Push(f.Locals[22]);f.Pc=3087;continue;}
case 3087:{f.Push(f.Locals[1]);f.Pc=3088;continue;}
case 3088:{return rt.Call(f,"forge/game/player/Player","shuffle","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",3091);}
case 3091:{f.Pc=3063;continue;}
case 3094:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3110(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("ChooseFromDefined")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("Defined")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int!=0?33:28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Int==0?37:33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{f.Pc=38;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("ChangeType")));f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Locals[6]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("Mandatory")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",57);}
case 57:{f.Locals[7]=f.Pop();f.Pc=59;continue;}
case 59:{return rt.Call(f,"com/google/common/collect/Maps","newLinkedHashMap","()Ljava/util/LinkedHashMap;","invokestatic",62);}
case 62:{f.Locals[8]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("DefinedPlayer")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",71);}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",75);}
case 75:{f.Locals[9]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[9]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","sortAPNAP","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)V","invokestatic",83);}
case 83:{f.Push(JValue.R(null));f.Pc=84;continue;}
case 84:{f.Locals[10]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?158:95;continue;}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",102);}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",106);}
case 106:{f.Locals[11]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[11]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",115);}
case 115:{f.Pc=f.Pop().Int!=0?158:118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",122);}
case 122:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",125);}
case 125:{f.Push(f.Locals[11]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(null));f.Pc=128;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",132);}
case 132:{f.Push(JValue.R(rt.String("lblChooser")));f.Pc=135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",142);}
case 142:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:142:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",147);}
case 147:{f.Push(JValue.I(0));f.Pc=148;continue;}
case 148:{f.Push(JValue.R(null));f.Pc=149;continue;}
case 149:{f.Push(JValue.R(null));f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLforge/game/player/Player;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",153);}
case 153:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=156;continue;}
case 156:{f.Locals[10]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[9]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",165);}
case 165:{f.Locals[11]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[11]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",174);}
case 174:{f.Pc=f.Pop().Int==0?3158:177;continue;}
case 177:{f.Push(f.Locals[11]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",184);}
case 184:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=187;continue;}
case 187:{f.Locals[12]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[10]);f.Pc=191;continue;}
case 191:{f.Locals[13]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(f.Locals[13]);f.Pc=195;continue;}
case 195:{f.Pc=f.Pop().Reference!=null?202:198;continue;}
case 198:{f.Push(f.Locals[12]);f.Pc=200;continue;}
case 200:{f.Locals[13]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",206);}
case 206:{f.Pc=f.Pop().Int==0?227:209;continue;}
case 209:{f.Push(f.Locals[1]);f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String("DefinedPlayer")));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",215);}
case 215:{f.Pc=f.Pop().Int!=0?227:218;continue;}
case 218:{f.Push(f.Locals[1]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",222);}
case 222:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedPlayer","()Lforge/game/player/Player;","invokevirtual",225);}
case 225:{f.Locals[12]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[12]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",232);}
case 232:{f.Pc=f.Pop().Int!=0?238:235;continue;}
case 235:{f.Pc=167;continue;}
case 238:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",241);}
case 241:{f.Locals[14]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[1]);f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.String("Origin")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",249);}
case 249:{f.Pc=f.Pop().Int==0?269:252;continue;}
case 252:{f.Push(f.Locals[14]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[1]);f.Pc=255;continue;}
case 255:{f.Push(JValue.R(rt.String("Origin")));f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",260);}
case 260:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",263);}
case 263:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",268);}
case 268:{f.StackOp("pop");f.Pc=269;continue;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("Destination")));f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",275);}
case 275:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",278);}
case 278:{f.Locals[15]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[1]);f.Pc=281;continue;}
case 281:{f.Push(JValue.R(rt.String("OriginAlternative")));f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",286);}
case 286:{f.Pc=f.Pop().Int==0?613:289;continue;}
case 289:{f.Push(f.Locals[1]);f.Pc=290;continue;}
case 290:{f.Push(JValue.R(rt.String("OriginAlternative")));f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",295);}
case 295:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",298);}
case 298:{f.Locals[16]=f.Pop();f.Pc=300;continue;}
case 300:{f.Push(f.Locals[12]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[16]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",307);}
case 307:{f.Push(f.Locals[1]);f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("ChangeType")));f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",313);}
case 313:{f.Push(f.Locals[1]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",317);}
case 317:{f.Locals[17]=f.Pop();f.Pc=319;continue;}
case 319:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=322;continue;}
case 322:{f.StackOp("dup");f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",326);}
case 326:{f.Locals[18]=f.Pop();f.Pc=328;continue;}
case 328:{f.Push(f.Locals[18]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",333);}
case 333:{f.Push(JValue.R(rt.String("lblSearchLibrary")));f.Pc=336;continue;}
case 336:{f.Push(JValue.I(0));f.Pc=337;continue;}
case 337:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",343);}
case 343:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",346);}
case 346:{f.Push(JValue.R(rt.String(" ")));f.Pc=348;continue;}
case 348:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",351);}
case 351:{f.StackOp("pop");f.Pc=352;continue;}
case 352:{f.Push(f.Locals[18]);f.Pc=354;continue;}
case 354:{f.Push(f.Locals[17]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",361);}
case 361:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",364);}
case 364:{f.Push(JValue.R(rt.String(" ")));f.Pc=366;continue;}
case 366:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",369);}
case 369:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",372);}
case 372:{f.Push(JValue.R(rt.String("lblCardMatchSearchingTypeInAlternateZones")));f.Pc=375;continue;}
case 375:{f.Push(JValue.I(0));f.Pc=376;continue;}
case 376:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",382);}
case 382:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",385);}
case 385:{f.StackOp("pop");f.Pc=386;continue;}
case 386:{f.Push(f.Locals[13]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",391);}
case 391:{f.Push(f.Locals[1]);f.Pc=392;continue;}
case 392:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","ChangeZoneFromAltSource","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","ChangeZoneFromAltSource","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=395;continue;}
case 395:{f.Push(f.Locals[18]);f.Pc=397;continue;}
case 397:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",400);}
case 400:{f.Push(JValue.R(null));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",404);}
case 404:{f.Pc=f.Pop().Int!=0?414:407;continue;}
case 407:{f.Push(f.Locals[14]);f.Pc=409;continue;}
case 409:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",414);}
case 414:{f.Push(f.Locals[16]);f.Pc=416;continue;}
case 416:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",421);}
case 421:{f.Pc=f.Pop().Int!=0?539:424;continue;}
case 424:{f.Push(f.Locals[14]);f.Pc=426;continue;}
case 426:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",431);}
case 431:{f.Push(f.Locals[16]);f.Pc=433;continue;}
case 433:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",438);}
case 438:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=439;continue;}
case 439:{f.Push(JValue.I(1));f.Pc=440;continue;}
case 440:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?539:443;continue;}
case 443:{f.Push(f.Locals[16]);f.Pc=445;continue;}
case 445:{f.Push(JValue.I(0));f.Pc=446;continue;}
case 446:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",451);}
case 451:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=454;continue;}
case 454:{f.Locals[19]=f.Pop();f.Pc=456;continue;}
case 456:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",459);}
case 459:{f.Push(JValue.R(rt.String("lblSearchPlayerZoneConfirm")));f.Pc=462;continue;}
case 462:{f.Push(JValue.I(2));f.Pc=463;continue;}
case 463:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=466;continue;}
case 466:{f.StackOp("dup");f.Pc=467;continue;}
case 467:{f.Push(JValue.I(0));f.Pc=468;continue;}
case 468:{f.Push(JValue.R(rt.String("{player's}")));f.Pc=471;continue;}
case 471:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=472;continue;}
case 472:{f.StackOp("dup");f.Pc=473;continue;}
case 473:{f.Push(JValue.I(1));f.Pc=474;continue;}
case 474:{f.Push(f.Locals[19]);f.Pc=476;continue;}
case 476:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",479);}
case 479:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",482);}
case 482:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",486);}
case 486:{f.Locals[20]=f.Pop();f.Pc=488;continue;}
case 488:{f.Push(f.Locals[20]);f.Pc=490;continue;}
case 490:{f.Push(f.Locals[13]);f.Pc=492;continue;}
case 492:{f.Push(f.Locals[12]);f.Pc=494;continue;}
case 494:{return rt.Call(f,"forge/util/MessageUtil","formatMessage","(Ljava/lang/String;Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;","invokestatic",497);}
case 497:{f.Locals[20]=f.Pop();f.Pc=499;continue;}
case 499:{f.Push(f.Locals[13]);f.Pc=501;continue;}
case 501:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",504);}
case 504:{f.Push(f.Locals[1]);f.Pc=505;continue;}
case 505:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","ChangeZoneFromAltSource","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","ChangeZoneFromAltSource","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=508;continue;}
case 508:{f.Push(f.Locals[20]);f.Pc=510;continue;}
case 510:{f.Push(JValue.R(null));f.Pc=511;continue;}
case 511:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",514);}
case 514:{f.Pc=f.Pop().Int==0?527:517;continue;}
case 517:{f.Push(f.Locals[14]);f.Pc=519;continue;}
case 519:{f.Push(f.Locals[19]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",526);}
case 526:{f.StackOp("pop");f.Pc=527;continue;}
case 527:{f.Push(f.Locals[16]);f.Pc=529;continue;}
case 529:{f.Push(JValue.I(0));f.Pc=530;continue;}
case 530:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",535);}
case 535:{f.StackOp("pop");f.Pc=536;continue;}
case 536:{f.Pc=414;continue;}
case 539:{f.Push(f.Locals[14]);f.Pc=541;continue;}
case 541:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",546);}
case 546:{f.Pc=f.Pop().Int==0?553:549;continue;}
case 549:{f.Push(f.Locals[16]);f.Pc=551;continue;}
case 551:{f.Locals[14]=f.Pop();f.Pc=553;continue;}
case 553:{f.Push(f.Locals[14]);f.Pc=555;continue;}
case 555:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",560);}
case 560:{f.Locals[19]=f.Pop();f.Pc=562;continue;}
case 562:{f.Push(f.Locals[19]);f.Pc=564;continue;}
case 564:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",569);}
case 569:{f.Pc=f.Pop().Int==0?613:572;continue;}
case 572:{f.Push(f.Locals[19]);f.Pc=574;continue;}
case 574:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",579);}
case 579:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=582;continue;}
case 582:{f.Locals[20]=f.Pop();f.Pc=584;continue;}
case 584:{f.Push(f.Locals[20]);f.Pc=586;continue;}
case 586:{return rt.Call(f,"forge/game/zone/ZoneType","isKnown","()Z","invokevirtual",589);}
case 589:{f.Pc=f.Pop().Int==0?610:592;continue;}
case 592:{f.Push(f.Locals[17]);f.Pc=594;continue;}
case 594:{f.Push(f.Locals[20]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/game/card/CardPredicates","inZone","(Lforge/game/zone/ZoneType;)Ljava/util/function/Predicate;","invokestatic",599);}
case 599:{return rt.Call(f,"forge/game/card/CardCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",604);}
case 604:{f.Pc=f.Pop().Int==0?610:607;continue;}
case 607:{f.Push(JValue.I(1));f.Pc=608;continue;}
case 608:{f.Locals[7]=f.Pop();f.Pc=610;continue;}
case 610:{f.Pc=562;continue;}
case 613:{f.Push(f.Locals[1]);f.Pc=614;continue;}
case 614:{f.Push(JValue.R(rt.String("Optional")));f.Pc=616;continue;}
case 616:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",619);}
case 619:{f.Pc=f.Pop().Int==0?769:622;continue;}
case 622:{f.Push(f.Locals[1]);f.Pc=623;continue;}
case 623:{f.Push(JValue.R(rt.String("OptionalPrompt")));f.Pc=626;continue;}
case 626:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",629);}
case 629:{f.Pc=f.Pop().Int==0?644:632;continue;}
case 632:{f.Push(f.Locals[1]);f.Pc=633;continue;}
case 633:{f.Push(JValue.R(rt.String("OptionalPrompt")));f.Pc=636;continue;}
case 636:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",639);}
case 639:{f.Locals[16]=f.Pop();f.Pc=641;continue;}
case 641:{f.Pc=737;continue;}
case 644:{f.Push(f.Locals[5]);f.Pc=646;continue;}
case 646:{f.Pc=f.Pop().Int==0?700:649;continue;}
case 649:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",652);}
case 652:{f.Push(JValue.R(rt.String("lblPutThatCardFromPlayerOriginToDestination")));f.Pc=655;continue;}
case 655:{f.Push(JValue.I(3));f.Pc=656;continue;}
case 656:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=659;continue;}
case 659:{f.StackOp("dup");f.Pc=660;continue;}
case 660:{f.Push(JValue.I(0));f.Pc=661;continue;}
case 661:{f.Push(JValue.R(rt.String("{player's}")));f.Pc=664;continue;}
case 664:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=665;continue;}
case 665:{f.StackOp("dup");f.Pc=666;continue;}
case 666:{f.Push(JValue.I(1));f.Pc=667;continue;}
case 667:{f.Push(f.Locals[14]);f.Pc=669;continue;}
case 669:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:669:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",674);}
case 674:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;)Ljava/lang/String;","invokestatic",677);}
case 677:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",680);}
case 680:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=681;continue;}
case 681:{f.StackOp("dup");f.Pc=682;continue;}
case 682:{f.Push(JValue.I(2));f.Pc=683;continue;}
case 683:{f.Push(f.Locals[15]);f.Pc=685;continue;}
case 685:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",688);}
case 688:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",691);}
case 691:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=692;continue;}
case 692:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",695);}
case 695:{f.Locals[16]=f.Pop();f.Pc=697;continue;}
case 697:{f.Pc=737;continue;}
case 700:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",703);}
case 703:{f.Push(JValue.R(rt.String("lblSearchPlayerZoneConfirm")));f.Pc=706;continue;}
case 706:{f.Push(JValue.I(2));f.Pc=707;continue;}
case 707:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=710;continue;}
case 710:{f.StackOp("dup");f.Pc=711;continue;}
case 711:{f.Push(JValue.I(0));f.Pc=712;continue;}
case 712:{f.Push(JValue.R(rt.String("{player's}")));f.Pc=715;continue;}
case 715:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=716;continue;}
case 716:{f.StackOp("dup");f.Pc=717;continue;}
case 717:{f.Push(JValue.I(1));f.Pc=718;continue;}
case 718:{f.Push(f.Locals[14]);f.Pc=720;continue;}
case 720:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:720:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",725);}
case 725:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;)Ljava/lang/String;","invokestatic",728);}
case 728:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",731);}
case 731:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=732;continue;}
case 732:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",735);}
case 735:{f.Locals[16]=f.Pop();f.Pc=737;continue;}
case 737:{f.Push(f.Locals[16]);f.Pc=739;continue;}
case 739:{f.Push(f.Locals[13]);f.Pc=741;continue;}
case 741:{f.Push(f.Locals[12]);f.Pc=743;continue;}
case 743:{return rt.Call(f,"forge/util/MessageUtil","formatMessage","(Ljava/lang/String;Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;","invokestatic",746);}
case 746:{f.Locals[17]=f.Pop();f.Pc=748;continue;}
case 748:{f.Push(f.Locals[13]);f.Pc=750;continue;}
case 750:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",753);}
case 753:{f.Push(f.Locals[1]);f.Pc=754;continue;}
case 754:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","ChangeZoneGeneral","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","ChangeZoneGeneral","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=757;continue;}
case 757:{f.Push(f.Locals[17]);f.Pc=759;continue;}
case 759:{f.Push(JValue.R(null));f.Pc=760;continue;}
case 760:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",763);}
case 763:{f.Pc=f.Pop().Int!=0?769:766;continue;}
case 766:{f.Pc=167;continue;}
case 769:{f.Push(f.Locals[12]);f.Pc=771;continue;}
case 771:{return rt.Call(f,"forge/game/player/Player","isControlled","()Z","invokevirtual",774);}
case 774:{f.Pc=f.Pop().Int==0?788:777;continue;}
case 777:{f.Push(f.Locals[14]);f.Pc=779;continue;}
case 779:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=782;continue;}
case 782:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",787);}
case 787:{f.StackOp("pop");f.Pc=788;continue;}
case 788:{f.Push(f.Locals[1]);f.Pc=789;continue;}
case 789:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=792;continue;}
case 792:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",795);}
case 795:{f.Pc=f.Pop().Int==0?813:798;continue;}
case 798:{f.Push(f.Locals[2]);f.Pc=799;continue;}
case 799:{f.Push(f.Locals[1]);f.Pc=800;continue;}
case 800:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=803;continue;}
case 803:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",806);}
case 806:{f.Push(f.Locals[1]);f.Pc=807;continue;}
case 807:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",810);}
case 810:{f.Pc=814;continue;}
case 813:{f.Push(JValue.I(0));f.Pc=814;continue;}
case 814:{f.Locals[16]=f.Pop();f.Pc=816;continue;}
case 816:{f.Push(f.Locals[1]);f.Pc=817;continue;}
case 817:{f.Push(JValue.R(rt.String("ChangeNum")));f.Pc=819;continue;}
case 819:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",822);}
case 822:{f.Pc=f.Pop().Int==0?839:825;continue;}
case 825:{f.Push(f.Locals[2]);f.Pc=826;continue;}
case 826:{f.Push(f.Locals[1]);f.Pc=827;continue;}
case 827:{f.Push(JValue.R(rt.String("ChangeNum")));f.Pc=829;continue;}
case 829:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",832);}
case 832:{f.Push(f.Locals[1]);f.Pc=833;continue;}
case 833:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",836);}
case 836:{f.Pc=840;continue;}
case 839:{f.Push(JValue.I(1));f.Pc=840;continue;}
case 840:{f.Locals[17]=f.Pop();f.Pc=842;continue;}
case 842:{f.Push(JValue.I(1));f.Pc=843;continue;}
case 843:{f.Locals[19]=f.Pop();f.Pc=845;continue;}
case 845:{f.Push(JValue.I(0));f.Pc=846;continue;}
case 846:{f.Locals[20]=f.Pop();f.Pc=848;continue;}
case 848:{f.Push(f.Locals[5]);f.Pc=850;continue;}
case 850:{f.Pc=f.Pop().Int==0?980:853;continue;}
case 853:{f.Push(JValue.I(0));f.Pc=854;continue;}
case 854:{f.Locals[19]=f.Pop();f.Pc=856;continue;}
case 856:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=859;continue;}
case 859:{f.StackOp("dup");f.Pc=860;continue;}
case 860:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",863);}
case 863:{f.Locals[18]=f.Pop();f.Pc=865;continue;}
case 865:{f.Push(f.Locals[4]);f.Pc=867;continue;}
case 867:{f.Pc=f.Pop().Int==0?876:870;continue;}
case 870:{f.Push(JValue.R(rt.String("ChooseFromDefined")));f.Pc=873;continue;}
case 873:{f.Pc=878;continue;}
case 876:{f.Push(JValue.R(rt.String("Defined")));f.Pc=878;continue;}
case 878:{f.Locals[21]=f.Pop();f.Pc=880;continue;}
case 880:{f.Push(f.Locals[2]);f.Pc=881;continue;}
case 881:{f.Push(f.Locals[1]);f.Pc=882;continue;}
case 882:{f.Push(f.Locals[21]);f.Pc=884;continue;}
case 884:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",887);}
case 887:{f.Push(f.Locals[1]);f.Pc=888;continue;}
case 888:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",891);}
case 891:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",894);}
case 894:{f.Locals[22]=f.Pop();f.Pc=896;continue;}
case 896:{f.Push(f.Locals[22]);f.Pc=898;continue;}
case 898:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",903);}
case 903:{f.Pc=f.Pop().Int==0?961:906;continue;}
case 906:{f.Push(f.Locals[22]);f.Pc=908;continue;}
case 908:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",913);}
case 913:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=916;continue;}
case 916:{f.Locals[23]=f.Pop();f.Pc=918;continue;}
case 918:{f.Push(f.Locals[3]);f.Pc=919;continue;}
case 919:{f.Push(f.Locals[23]);f.Pc=921;continue;}
case 921:{f.Push(JValue.R(null));f.Pc=922;continue;}
case 922:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",925);}
case 925:{f.Locals[24]=f.Pop();f.Pc=927;continue;}
case 927:{f.Push(f.Locals[24]);f.Pc=929;continue;}
case 929:{f.Pc=f.Pop().Reference==null?958:932;continue;}
case 932:{f.Push(f.Locals[23]);f.Pc=934;continue;}
case 934:{f.Push(f.Locals[24]);f.Pc=936;continue;}
case 936:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",939);}
case 939:{f.Pc=f.Pop().Int==0?958:942;continue;}
case 942:{f.Push(f.Locals[24]);f.Pc=944;continue;}
case 944:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",947);}
case 947:{f.Pc=f.Pop().Int!=0?958:950;continue;}
case 950:{f.Push(f.Locals[18]);f.Pc=952;continue;}
case 952:{f.Push(f.Locals[24]);f.Pc=954;continue;}
case 954:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",957);}
case 957:{f.StackOp("pop");f.Pc=958;continue;}
case 958:{f.Pc=896;continue;}
case 961:{f.Push(f.Locals[1]);f.Pc=962;continue;}
case 962:{f.Push(JValue.R(rt.String("ChangeNum")));f.Pc=964;continue;}
case 964:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",967);}
case 967:{f.Pc=f.Pop().Int!=0?977:970;continue;}
case 970:{f.Push(f.Locals[18]);f.Pc=972;continue;}
case 972:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",975);}
case 975:{f.Locals[17]=f.Pop();f.Pc=977;continue;}
case 977:{f.Pc=1123;continue;}
case 980:{f.Push(f.Locals[14]);f.Pc=982;continue;}
case 982:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=985;continue;}
case 985:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",990);}
case 990:{f.Pc=f.Pop().Int!=0?1033:993;continue;}
case 993:{f.Push(f.Locals[14]);f.Pc=995;continue;}
case 995:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=998;continue;}
case 998:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1003);}
case 1003:{f.Pc=f.Pop().Int!=0?1033:1006;continue;}
case 1006:{f.Push(f.Locals[1]);f.Pc=1007;continue;}
case 1007:{f.Push(JValue.R(rt.String("DefinedPlayer")));f.Pc=1009;continue;}
case 1009:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1012);}
case 1012:{f.Pc=f.Pop().Int!=0?1033:1015;continue;}
case 1015:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1018;continue;}
case 1018:{f.StackOp("dup");f.Pc=1019;continue;}
case 1019:{f.Push(f.Locals[3]);f.Pc=1020;continue;}
case 1020:{f.Push(f.Locals[14]);f.Pc=1022;continue;}
case 1022:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",1025);}
case 1025:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",1028);}
case 1028:{f.Locals[18]=f.Pop();f.Pc=1030;continue;}
case 1030:{f.Pc=1123;continue;}
case 1033:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1036;continue;}
case 1036:{f.StackOp("dup");f.Pc=1037;continue;}
case 1037:{f.Push(f.Locals[12]);f.Pc=1039;continue;}
case 1039:{f.Push(f.Locals[14]);f.Pc=1041;continue;}
case 1041:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",1044);}
case 1044:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",1047);}
case 1047:{f.Locals[18]=f.Pop();f.Pc=1049;continue;}
case 1049:{f.Push(f.Locals[14]);f.Pc=1051;continue;}
case 1051:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=1054;continue;}
case 1054:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1059);}
case 1059:{f.Pc=f.Pop().Int==0?1123:1062;continue;}
case 1062:{f.Push(f.Locals[1]);f.Pc=1063;continue;}
case 1063:{f.Push(JValue.R(rt.String("NoLooking")));f.Pc=1066;continue;}
case 1066:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1069);}
case 1069:{f.Pc=f.Pop().Int!=0?1123:1072;continue;}
case 1072:{f.Push(JValue.I(1));f.Pc=1073;continue;}
case 1073:{f.Locals[20]=f.Pop();f.Pc=1075;continue;}
case 1075:{f.Push(f.Locals[13]);f.Pc=1077;continue;}
case 1077:{f.Push(f.Locals[1]);f.Pc=1078;continue;}
case 1078:{f.Push(f.Locals[12]);f.Pc=1080;continue;}
case 1080:{return rt.Call(f,"forge/game/player/Player","getSearchableLibrary","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/card/CardCollectionView;","invokevirtual",1083);}
case 1083:{f.Locals[21]=f.Pop();f.Pc=1085;continue;}
case 1085:{f.Push(f.Locals[18]);f.Pc=1087;continue;}
case 1087:{f.Push(f.Locals[21]);f.Pc=1089;continue;}
case 1089:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:1089:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CardCollectionView;)Ljava/util/function/Predicate;",1094);}
case 1094:{return rt.Call(f,"forge/game/card/CardCollection","removeIf","(Ljava/util/function/Predicate;)Z","invokevirtual",1097);}
case 1097:{f.StackOp("pop");f.Pc=1098;continue;}
case 1098:{f.Push(f.Locals[21]);f.Pc=1100;continue;}
case 1100:{f.Pc=f.Pop().Reference!=null?1123:1103;continue;}
case 1103:{f.Push(f.Locals[1]);f.Pc=1104;continue;}
case 1104:{f.Push(JValue.R(rt.String("ShuffleNonMandatory")));f.Pc=1107;continue;}
case 1107:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1110);}
case 1110:{f.Pc=f.Pop().Int!=0?1117:1113;continue;}
case 1113:{f.Push(JValue.I(1));f.Pc=1114;continue;}
case 1114:{f.Pc=1118;continue;}
case 1117:{f.Push(JValue.I(0));f.Pc=1118;continue;}
case 1118:{f.Locals[19]=f.Pop();f.Pc=1120;continue;}
case 1120:{f.Push(JValue.I(0));f.Pc=1121;continue;}
case 1121:{f.Locals[20]=f.Pop();f.Pc=1123;continue;}
case 1123:{f.Push(JValue.R(null));f.Pc=1124;continue;}
case 1124:{f.Locals[21]=f.Pop();f.Pc=1126;continue;}
case 1126:{f.Push(f.Locals[5]);f.Pc=1128;continue;}
case 1128:{f.Pc=f.Pop().Int!=0?1305:1131;continue;}
case 1131:{f.Push(f.Locals[1]);f.Pc=1132;continue;}
case 1132:{f.Push(JValue.R(rt.String("AlreadyRevealed")));f.Pc=1135;continue;}
case 1135:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1138);}
case 1138:{f.Pc=f.Pop().Int!=0?1305:1141;continue;}
case 1141:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",1144);}
case 1144:{f.Locals[22]=f.Pop();f.Pc=1146;continue;}
case 1146:{f.Push(JValue.R(null));f.Pc=1147;continue;}
case 1147:{f.Locals[23]=f.Pop();f.Pc=1149;continue;}
case 1149:{f.Push(f.Locals[14]);f.Pc=1151;continue;}
case 1151:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=1154;continue;}
case 1154:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1159);}
case 1159:{f.Pc=f.Pop().Int==0?1188:1162;continue;}
case 1162:{f.Push(f.Locals[20]);f.Pc=1164;continue;}
case 1164:{f.Pc=f.Pop().Int==0?1188:1167;continue;}
case 1167:{f.Push(f.Locals[13]);f.Pc=1169;continue;}
case 1169:{f.Push(f.Locals[1]);f.Pc=1170;continue;}
case 1170:{f.Push(f.Locals[12]);f.Pc=1172;continue;}
case 1172:{return rt.Call(f,"forge/game/player/Player","getSearchableLibrary","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/card/CardCollectionView;","invokevirtual",1175);}
case 1175:{f.Locals[23]=f.Pop();f.Pc=1177;continue;}
case 1177:{f.Push(f.Locals[22]);f.Pc=1179;continue;}
case 1179:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=1182;continue;}
case 1182:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",1187);}
case 1187:{f.StackOp("pop");f.Pc=1188;continue;}
case 1188:{f.Push(f.Locals[14]);f.Pc=1190;continue;}
case 1190:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=1193;continue;}
case 1193:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1198);}
case 1198:{f.Pc=f.Pop().Int==0?1255:1201;continue;}
case 1201:{f.Push(f.Locals[12]);f.Pc=1203;continue;}
case 1203:{f.Push(f.Locals[13]);f.Pc=1205;continue;}
case 1205:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",1208);}
case 1208:{f.Pc=f.Pop().Int==0?1255:1211;continue;}
case 1211:{f.Push(f.Locals[23]);f.Pc=1213;continue;}
case 1213:{f.Pc=f.Pop().Reference==null?1234:1216;continue;}
case 1216:{f.Push(f.Locals[23]);f.Pc=1218;continue;}
case 1218:{f.Push(f.Locals[12]);f.Pc=1220;continue;}
case 1220:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=1223;continue;}
case 1223:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1226);}
case 1226:{return rt.Call(f,"com/google/common/collect/Iterables","concat","(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/lang/Iterable;","invokestatic",1229);}
case 1229:{f.Locals[23]=f.Pop();f.Pc=1231;continue;}
case 1231:{f.Pc=1244;continue;}
case 1234:{f.Push(f.Locals[12]);f.Pc=1236;continue;}
case 1236:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=1239;continue;}
case 1239:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",1242);}
case 1242:{f.Locals[23]=f.Pop();f.Pc=1244;continue;}
case 1244:{f.Push(f.Locals[22]);f.Pc=1246;continue;}
case 1246:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=1249;continue;}
case 1249:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",1254);}
case 1254:{f.StackOp("pop");f.Pc=1255;continue;}
case 1255:{f.Push(f.Locals[22]);f.Pc=1257;continue;}
case 1257:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",1262);}
case 1262:{f.Pc=f.Pop().Int!=0?1305:1265;continue;}
case 1265:{if(!rt.EnsureInitialized(f,"forge/game/player/DelayedReveal"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/DelayedReveal")));f.Pc=1268;continue;}
case 1268:{f.StackOp("dup");f.Pc=1269;continue;}
case 1269:{f.Push(f.Locals[23]);f.Pc=1271;continue;}
case 1271:{f.Push(f.Locals[22]);f.Pc=1273;continue;}
case 1273:{f.Push(f.Locals[12]);f.Pc=1275;continue;}
case 1275:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",1278);}
case 1278:{f.Push(f.Locals[2]);f.Pc=1279;continue;}
case 1279:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",1282);}
case 1282:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1285);}
case 1285:{f.Push(JValue.R(rt.String("lblLookingCardIn")));f.Pc=1288;continue;}
case 1288:{f.Push(JValue.I(0));f.Pc=1289;continue;}
case 1289:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1292;continue;}
case 1292:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1295);}
case 1295:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:1295:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1300);}
case 1300:{return rt.Call(f,"forge/game/player/DelayedReveal","<init>","(Ljava/lang/Iterable;Ljava/util/Set;Lforge/game/player/PlayerView;Ljava/lang/String;)V","invokespecial",1303);}
case 1303:{f.Locals[21]=f.Pop();f.Pc=1305;continue;}
case 1305:{f.Push(JValue.R(null));f.Pc=1306;continue;}
case 1306:{f.Locals[22]=f.Pop();f.Pc=1308;continue;}
case 1308:{f.Push(f.Locals[20]);f.Pc=1310;continue;}
case 1310:{f.Pc=f.Pop().Int==0?1429:1313;continue;}
case 1313:{f.Push(f.Locals[13]);f.Pc=1315;continue;}
case 1315:{f.Push(f.Locals[12]);f.Pc=1317;continue;}
case 1317:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1320);}
case 1320:{f.Pc=f.Pop().Int==0?1380:1323;continue;}
case 1323:{f.Push(f.Locals[12]);f.Pc=1325;continue;}
case 1325:{return rt.Call(f,"forge/game/player/Player","getControlledWhileSearching","()Ljava/util/Map$Entry;","invokevirtual",1328);}
case 1328:{f.Locals[23]=f.Pop();f.Pc=1330;continue;}
case 1330:{f.Push(f.Locals[23]);f.Pc=1332;continue;}
case 1332:{f.Pc=f.Pop().Reference==null?1367:1335;continue;}
case 1335:{f.Push(f.Locals[23]);f.Pc=1337;continue;}
case 1337:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",1342);}
case 1342:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Long"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1345;continue;}
case 1345:{f.Locals[22]=f.Pop();f.Pc=1347;continue;}
case 1347:{f.Push(f.Locals[12]);f.Pc=1349;continue;}
case 1349:{f.Push(f.Locals[22]);f.Pc=1351;continue;}
case 1351:{return rt.Call(f,"java/lang/Long","longValue","()J","invokevirtual",1354);}
case 1354:{f.Push(f.Locals[23]);f.Pc=1356;continue;}
case 1356:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",1361);}
case 1361:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1364;continue;}
case 1364:{return rt.Call(f,"forge/game/player/Player","addController","(JLforge/game/player/Player;)V","invokevirtual",1367);}
case 1367:{f.Push(f.Locals[13]);f.Pc=1369;continue;}
case 1369:{return rt.Call(f,"forge/game/player/Player","incLibrarySearched","()V","invokevirtual",1372);}
case 1372:{f.Push(f.Locals[0]);f.Pc=1373;continue;}
case 1373:{f.Push(f.Locals[18]);f.Pc=1375;continue;}
case 1375:{f.Push(f.Locals[13]);f.Pc=1377;continue;}
case 1377:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","handleCastWhileSearching","(Lforge/game/card/CardCollection;Lforge/game/player/Player;)V","invokevirtual",1380);}
case 1380:{f.Push(f.Locals[1]);f.Pc=1381;continue;}
case 1381:{f.Push(JValue.R(rt.String("RememberSearcher")));f.Pc=1384;continue;}
case 1384:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1387);}
case 1387:{f.Pc=f.Pop().Int==0?1396:1390;continue;}
case 1390:{f.Push(f.Locals[2]);f.Pc=1391;continue;}
case 1391:{f.Push(f.Locals[12]);f.Pc=1393;continue;}
case 1393:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1396);}
case 1396:{f.Push(f.Locals[13]);f.Pc=1398;continue;}
case 1398:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",1401);}
case 1401:{f.Locals[23]=f.Pop();f.Pc=1403;continue;}
case 1403:{f.Push(f.Locals[23]);f.Pc=1405;continue;}
case 1405:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Target","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Target","Lforge/game/ability/AbilityKey;"));f.Pc=1408;continue;}
case 1408:{f.Push(f.Locals[12]);f.Pc=1410;continue;}
case 1410:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1415);}
case 1415:{f.StackOp("pop");f.Pc=1416;continue;}
case 1416:{f.Push(f.Locals[3]);f.Pc=1417;continue;}
case 1417:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1420);}
case 1420:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","SearchedLibrary","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","SearchedLibrary","Lforge/game/trigger/TriggerType;"));f.Pc=1423;continue;}
case 1423:{f.Push(f.Locals[23]);f.Pc=1425;continue;}
case 1425:{f.Push(JValue.I(0));f.Pc=1426;continue;}
case 1426:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1429);}
case 1429:{f.Push(f.Locals[5]);f.Pc=1431;continue;}
case 1431:{f.Pc=f.Pop().Int!=0?1470:1434;continue;}
case 1434:{f.Push(f.Locals[6]);f.Pc=1436;continue;}
case 1436:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1439);}
case 1439:{f.Pc=f.Pop().Int!=0?1470:1442;continue;}
case 1442:{f.Push(f.Locals[6]);f.Pc=1444;continue;}
case 1444:{f.Push(JValue.R(rt.String("EACH")));f.Pc=1447;continue;}
case 1447:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1450);}
case 1450:{f.Pc=f.Pop().Int!=0?1470:1453;continue;}
case 1453:{f.Push(f.Locals[18]);f.Pc=1455;continue;}
case 1455:{f.Push(f.Locals[1]);f.Pc=1456;continue;}
case 1456:{f.Push(JValue.R(rt.String("ChangeType")));f.Pc=1458;continue;}
case 1458:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1461);}
case 1461:{f.Push(f.Locals[1]);f.Pc=1462;continue;}
case 1462:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",1465);}
case 1465:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1468;continue;}
case 1468:{f.Locals[18]=f.Pop();f.Pc=1470;continue;}
case 1470:{f.Push(f.Locals[18]);f.Pc=1472;continue;}
case 1472:{return rt.Call(f,"forge/game/card/CardCollection","sort","()V","invokevirtual",1475);}
case 1475:{f.Push(f.Locals[1]);f.Pc=1476;continue;}
case 1476:{f.Push(JValue.R(rt.String("NoShuffle")));f.Pc=1479;continue;}
case 1479:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1482);}
case 1482:{f.Pc=f.Pop().Int!=0?1501:1485;continue;}
case 1485:{f.Push(JValue.R(rt.String("False")));f.Pc=1488;continue;}
case 1488:{f.Push(f.Locals[1]);f.Pc=1489;continue;}
case 1489:{f.Push(JValue.R(rt.String("Shuffle")));f.Pc=1492;continue;}
case 1492:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1495);}
case 1495:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1498);}
case 1498:{f.Pc=f.Pop().Int==0?1504:1501;continue;}
case 1501:{f.Push(JValue.I(0));f.Pc=1502;continue;}
case 1502:{f.Locals[19]=f.Pop();f.Pc=1504;continue;}
case 1504:{f.Push(f.Locals[1]);f.Pc=1505;continue;}
case 1505:{f.Push(JValue.R(rt.String("Unimprint")));f.Pc=1508;continue;}
case 1508:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1511);}
case 1511:{f.Pc=f.Pop().Int==0?1518:1514;continue;}
case 1514:{f.Push(f.Locals[2]);f.Pc=1515;continue;}
case 1515:{return rt.Call(f,"forge/game/card/Card","clearImprintedCards","()V","invokevirtual",1518);}
case 1518:{f.Push(f.Locals[1]);f.Pc=1519;continue;}
case 1519:{f.Push(JValue.R(rt.String("ForgetOtherRemembered")));f.Pc=1522;continue;}
case 1522:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1525);}
case 1525:{f.Pc=f.Pop().Int==0?1532:1528;continue;}
case 1528:{f.Push(f.Locals[2]);f.Pc=1529;continue;}
case 1529:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",1532);}
case 1532:{f.Push(f.Locals[1]);f.Pc=1533;continue;}
case 1533:{f.Push(JValue.R(rt.String("SelectPrompt")));f.Pc=1536;continue;}
case 1536:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1539);}
case 1539:{f.Pc=f.Pop().Int==0?1552:1542;continue;}
case 1542:{f.Push(f.Locals[1]);f.Pc=1543;continue;}
case 1543:{f.Push(JValue.R(rt.String("SelectPrompt")));f.Pc=1546;continue;}
case 1546:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1549);}
case 1549:{f.Pc=1594;continue;}
case 1552:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1555);}
case 1555:{f.Push(JValue.R(rt.String("lblSelectCardFromPlayerZone")));f.Pc=1558;continue;}
case 1558:{f.Push(JValue.I(2));f.Pc=1559;continue;}
case 1559:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1562;continue;}
case 1562:{f.StackOp("dup");f.Pc=1563;continue;}
case 1563:{f.Push(JValue.I(0));f.Pc=1564;continue;}
case 1564:{f.Push(JValue.R(rt.String("{player's}")));f.Pc=1567;continue;}
case 1567:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1568;continue;}
case 1568:{f.StackOp("dup");f.Pc=1569;continue;}
case 1569:{f.Push(JValue.I(1));f.Pc=1570;continue;}
case 1570:{f.Push(f.Locals[14]);f.Pc=1572;continue;}
case 1572:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:1572:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",1577);}
case 1577:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;)Ljava/lang/String;","invokestatic",1580);}
case 1580:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",1583);}
case 1583:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1584;continue;}
case 1584:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1587);}
case 1587:{f.Push(f.Locals[13]);f.Pc=1589;continue;}
case 1589:{f.Push(f.Locals[12]);f.Pc=1591;continue;}
case 1591:{return rt.Call(f,"forge/util/MessageUtil","formatMessage","(Ljava/lang/String;Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1594);}
case 1594:{f.Locals[23]=f.Pop();f.Pc=1596;continue;}
case 1596:{f.Push(f.Locals[1]);f.Pc=1597;continue;}
case 1597:{f.Push(JValue.R(rt.String("WithTotalCMC")));f.Pc=1600;continue;}
case 1600:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1603);}
case 1603:{f.Locals[24]=f.Pop();f.Pc=1605;continue;}
case 1605:{f.Push(f.Locals[1]);f.Pc=1606;continue;}
case 1606:{f.Push(JValue.R(rt.String("WithTotalPower")));f.Pc=1609;continue;}
case 1609:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1612);}
case 1612:{f.Locals[25]=f.Pop();f.Pc=1614;continue;}
case 1614:{f.Push(f.Locals[1]);f.Pc=1615;continue;}
case 1615:{f.Push(JValue.R(rt.String("WithTotalCardTypes")));f.Pc=1618;continue;}
case 1618:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1621);}
case 1621:{f.Locals[26]=f.Pop();f.Pc=1623;continue;}
case 1623:{f.Push(f.Locals[2]);f.Pc=1624;continue;}
case 1624:{f.Push(f.Locals[24]);f.Pc=1626;continue;}
case 1626:{f.Push(f.Locals[1]);f.Pc=1627;continue;}
case 1627:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1630);}
case 1630:{f.Locals[27]=f.Pop();f.Pc=1632;continue;}
case 1632:{f.Push(f.Locals[2]);f.Pc=1633;continue;}
case 1633:{f.Push(f.Locals[25]);f.Pc=1635;continue;}
case 1635:{f.Push(f.Locals[1]);f.Pc=1636;continue;}
case 1636:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1639);}
case 1639:{f.Locals[28]=f.Pop();f.Pc=1641;continue;}
case 1641:{f.Push(f.Locals[2]);f.Pc=1642;continue;}
case 1642:{f.Push(f.Locals[26]);f.Pc=1644;continue;}
case 1644:{f.Push(f.Locals[1]);f.Pc=1645;continue;}
case 1645:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1648);}
case 1648:{f.Locals[29]=f.Pop();f.Pc=1650;continue;}
case 1650:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=1653;continue;}
case 1653:{f.StackOp("dup");f.Pc=1654;continue;}
case 1654:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",1657);}
case 1657:{f.Locals[30]=f.Pop();f.Pc=1659;continue;}
case 1659:{f.Push(f.Locals[1]);f.Pc=1660;continue;}
case 1660:{f.Push(JValue.R(rt.String("SameNameAsEach")));f.Pc=1663;continue;}
case 1663:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1666);}
case 1666:{f.Pc=f.Pop().Int==0?1836:1669;continue;}
case 1669:{f.Push(JValue.I(1));f.Pc=1670;continue;}
case 1670:{f.Locals[31]=f.Pop();f.Pc=1672;continue;}
case 1672:{f.Push(f.Locals[2]);f.Pc=1673;continue;}
case 1673:{f.Push(f.Locals[1]);f.Pc=1674;continue;}
case 1674:{f.Push(JValue.R(rt.String("SameNameAsEach")));f.Pc=1677;continue;}
case 1677:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1680);}
case 1680:{f.Push(f.Locals[1]);f.Pc=1681;continue;}
case 1681:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",1684);}
case 1684:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1687);}
case 1687:{f.Locals[32]=f.Pop();f.Pc=1689;continue;}
case 1689:{f.Push(f.Locals[32]);f.Pc=1691;continue;}
case 1691:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1696);}
case 1696:{f.Pc=f.Pop().Int==0?1833:1699;continue;}
case 1699:{f.Push(f.Locals[32]);f.Pc=1701;continue;}
case 1701:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1706);}
case 1706:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1709;continue;}
case 1709:{f.Locals[33]=f.Pop();f.Pc=1711;continue;}
case 1711:{f.Push(f.Locals[18]);f.Pc=1713;continue;}
case 1713:{f.Push(f.Locals[33]);f.Pc=1715;continue;}
case 1715:{return rt.Call(f,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",1718);}
case 1718:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",1721);}
case 1721:{f.Locals[34]=f.Pop();f.Pc=1723;continue;}
case 1723:{f.Push(f.Locals[34]);f.Pc=1725;continue;}
case 1725:{f.Push(f.Locals[30]);f.Pc=1727;continue;}
case 1727:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",1730);}
case 1730:{f.StackOp("pop");f.Pc=1731;continue;}
case 1731:{f.Push(f.Locals[34]);f.Pc=1733;continue;}
case 1733:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1736);}
case 1736:{f.Pc=f.Pop().Int==0?1747:1739;continue;}
case 1739:{f.Push(f.Locals[31]);f.Pc=1741;continue;}
case 1741:{f.Pc=f.Pop().Int!=0?1747:1744;continue;}
case 1744:{f.Pc=1689;continue;}
case 1747:{f.Push(f.Locals[13]);f.Pc=1749;continue;}
case 1749:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1752);}
case 1752:{f.Push(f.Locals[15]);f.Pc=1754;continue;}
case 1754:{f.Push(f.Locals[14]);f.Pc=1756;continue;}
case 1756:{f.Push(f.Locals[1]);f.Pc=1757;continue;}
case 1757:{f.Push(f.Locals[34]);f.Pc=1759;continue;}
case 1759:{f.Push(f.Locals[31]);f.Pc=1761;continue;}
case 1761:{f.Pc=f.Pop().Int==0?1769:1764;continue;}
case 1764:{f.Push(f.Locals[21]);f.Pc=1766;continue;}
case 1766:{f.Pc=1770;continue;}
case 1769:{f.Push(JValue.R(null));f.Pc=1770;continue;}
case 1770:{f.Push(f.Locals[23]);f.Pc=1772;continue;}
case 1772:{f.Push(f.Locals[33]);f.Pc=1774;continue;}
case 1774:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",1777);}
case 1777:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:1777:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1782);}
case 1782:{f.Push(f.Locals[7]);f.Pc=1784;continue;}
case 1784:{f.Pc=f.Pop().Int!=0?1791:1787;continue;}
case 1787:{f.Push(JValue.I(1));f.Pc=1788;continue;}
case 1788:{f.Pc=1792;continue;}
case 1791:{f.Push(JValue.I(0));f.Pc=1792;continue;}
case 1792:{f.Push(f.Locals[13]);f.Pc=1794;continue;}
case 1794:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleCardForZoneChange","(Lforge/game/zone/ZoneType;Ljava/util/List;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;Lforge/game/player/DelayedReveal;Ljava/lang/String;ZLforge/game/player/Player;)Lforge/game/card/Card;","invokevirtual",1797);}
case 1797:{f.Locals[35]=f.Pop();f.Pc=1799;continue;}
case 1799:{f.Push(JValue.I(0));f.Pc=1800;continue;}
case 1800:{f.Locals[31]=f.Pop();f.Pc=1802;continue;}
case 1802:{f.Push(f.Locals[35]);f.Pc=1804;continue;}
case 1804:{f.Pc=f.Pop().Reference==null?1830:1807;continue;}
case 1807:{f.Push(f.Locals[30]);f.Pc=1809;continue;}
case 1809:{f.Push(f.Locals[35]);f.Pc=1811;continue;}
case 1811:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1814);}
case 1814:{f.StackOp("pop");f.Pc=1815;continue;}
case 1815:{f.Push(f.Locals[21]);f.Pc=1817;continue;}
case 1817:{f.Pc=f.Pop().Reference==null?1830:1820;continue;}
case 1820:{f.Push(f.Locals[21]);f.Pc=1822;continue;}
case 1822:{f.Push(f.Locals[35]);f.Pc=1824;continue;}
case 1824:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",1827);}
case 1827:{return rt.Call(f,"forge/game/player/DelayedReveal","remove","(Lforge/game/card/CardView;)V","invokevirtual",1830);}
case 1830:{f.Pc=1689;continue;}
case 1833:{f.Pc=2926;continue;}
case 1836:{f.Push(f.Locals[6]);f.Pc=1838;continue;}
case 1838:{f.Push(JValue.R(rt.String("EACH")));f.Pc=1841;continue;}
case 1841:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1844);}
case 1844:{f.Pc=f.Pop().Int==0?1990:1847;continue;}
case 1847:{f.Push(f.Locals[6]);f.Pc=1849;continue;}
case 1849:{f.Push(JValue.I(5));f.Pc=1850;continue;}
case 1850:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1853);}
case 1853:{f.Push(JValue.R(rt.String(" & ")));f.Pc=1856;continue;}
case 1856:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1859);}
case 1859:{f.Locals[31]=f.Pop();f.Pc=1861;continue;}
case 1861:{f.Push(f.Locals[31]);f.Pc=1863;continue;}
case 1863:{f.Locals[32]=f.Pop();f.Pc=1865;continue;}
case 1865:{f.Push(f.Locals[32]);f.Pc=1867;continue;}
case 1867:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1868;continue;}
case 1868:{f.Locals[33]=f.Pop();f.Pc=1870;continue;}
case 1870:{f.Push(JValue.I(0));f.Pc=1871;continue;}
case 1871:{f.Locals[34]=f.Pop();f.Pc=1873;continue;}
case 1873:{f.Push(f.Locals[34]);f.Pc=1875;continue;}
case 1875:{f.Push(f.Locals[33]);f.Pc=1877;continue;}
case 1877:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1987:1880;continue;}
case 1880:{f.Push(f.Locals[32]);f.Pc=1882;continue;}
case 1882:{f.Push(f.Locals[34]);f.Pc=1884;continue;}
case 1884:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1885;continue;}
case 1885:{f.Locals[35]=f.Pop();f.Pc=1887;continue;}
case 1887:{f.Push(JValue.I(0));f.Pc=1888;continue;}
case 1888:{f.Locals[36]=f.Pop();f.Pc=1890;continue;}
case 1890:{f.Push(f.Locals[36]);f.Pc=1892;continue;}
case 1892:{f.Push(f.Locals[17]);f.Pc=1894;continue;}
case 1894:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1981:1897;continue;}
case 1897:{f.Push(f.Locals[18]);f.Pc=1899;continue;}
case 1899:{f.Push(f.Locals[35]);f.Pc=1901;continue;}
case 1901:{f.Push(f.Locals[1]);f.Pc=1902;continue;}
case 1902:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",1905);}
case 1905:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1908;continue;}
case 1908:{f.Locals[37]=f.Pop();f.Pc=1910;continue;}
case 1910:{f.Push(f.Locals[30]);f.Pc=1912;continue;}
case 1912:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1915);}
case 1915:{f.Pc=f.Pop().Int!=0?1926:1918;continue;}
case 1918:{f.Push(f.Locals[37]);f.Pc=1920;continue;}
case 1920:{f.Push(f.Locals[30]);f.Pc=1922;continue;}
case 1922:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",1925);}
case 1925:{f.StackOp("pop");f.Pc=1926;continue;}
case 1926:{f.Push(f.Locals[13]);f.Pc=1928;continue;}
case 1928:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1931);}
case 1931:{f.Push(f.Locals[15]);f.Pc=1933;continue;}
case 1933:{f.Push(f.Locals[14]);f.Pc=1935;continue;}
case 1935:{f.Push(f.Locals[1]);f.Pc=1936;continue;}
case 1936:{f.Push(f.Locals[37]);f.Pc=1938;continue;}
case 1938:{f.Push(f.Locals[21]);f.Pc=1940;continue;}
case 1940:{f.Push(f.Locals[23]);f.Pc=1942;continue;}
case 1942:{f.Push(f.Locals[7]);f.Pc=1944;continue;}
case 1944:{f.Pc=f.Pop().Int!=0?1951:1947;continue;}
case 1947:{f.Push(JValue.I(1));f.Pc=1948;continue;}
case 1948:{f.Pc=1952;continue;}
case 1951:{f.Push(JValue.I(0));f.Pc=1952;continue;}
case 1952:{f.Push(f.Locals[13]);f.Pc=1954;continue;}
case 1954:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleCardForZoneChange","(Lforge/game/zone/ZoneType;Ljava/util/List;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;Lforge/game/player/DelayedReveal;Ljava/lang/String;ZLforge/game/player/Player;)Lforge/game/card/Card;","invokevirtual",1957);}
case 1957:{f.Locals[38]=f.Pop();f.Pc=1959;continue;}
case 1959:{f.Push(f.Locals[38]);f.Pc=1961;continue;}
case 1961:{f.Pc=f.Pop().Reference!=null?1967:1964;continue;}
case 1964:{f.Pc=1975;continue;}
case 1967:{f.Push(f.Locals[30]);f.Pc=1969;continue;}
case 1969:{f.Push(f.Locals[38]);f.Pc=1971;continue;}
case 1971:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",1974);}
case 1974:{f.StackOp("pop");f.Pc=1975;continue;}
case 1975:{f.Locals[36]=JValue.I(unchecked(f.Locals[36].Int+(1)));f.Pc=1978;continue;}
case 1978:{f.Pc=1890;continue;}
case 1981:{f.Locals[34]=JValue.I(unchecked(f.Locals[34].Int+(1)));f.Pc=1984;continue;}
case 1984:{f.Pc=1873;continue;}
case 1987:{f.Pc=2926;continue;}
case 1990:{f.Push(f.Locals[17]);f.Pc=1992;continue;}
case 1992:{f.Push(JValue.I(1));f.Pc=1993;continue;}
case 1993:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2210:1996;continue;}
case 1996:{f.Push(f.Locals[13]);f.Pc=1998;continue;}
case 1998:{f.Push(f.Locals[1]);f.Pc=1999;continue;}
case 1999:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","allowMultiSelect","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Z","invokestatic",2002);}
case 2002:{f.Pc=f.Pop().Int==0?2210:2005;continue;}
case 2005:{f.Push(f.Locals[1]);f.Pc=2006;continue;}
case 2006:{f.Push(JValue.R(rt.String("SelectPrompt")));f.Pc=2009;continue;}
case 2009:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2012);}
case 2012:{f.Pc=f.Pop().Int!=0?2124:2015;continue;}
case 2015:{f.Push(f.Locals[18]);f.Pc=2017;continue;}
case 2017:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",2020);}
case 2020:{f.Push(f.Locals[17]);f.Pc=2022;continue;}
case 2022:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2080:2025;continue;}
case 2025:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2028);}
case 2028:{f.Push(JValue.R(rt.String("lblSelectUpToNumCardFromPlayerZone")));f.Pc=2031;continue;}
case 2031:{f.Push(JValue.I(3));f.Pc=2032;continue;}
case 2032:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2035;continue;}
case 2035:{f.StackOp("dup");f.Pc=2036;continue;}
case 2036:{f.Push(JValue.I(0));f.Pc=2037;continue;}
case 2037:{f.Push(f.Locals[17]);f.Pc=2039;continue;}
case 2039:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",2042);}
case 2042:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2043;continue;}
case 2043:{f.StackOp("dup");f.Pc=2044;continue;}
case 2044:{f.Push(JValue.I(1));f.Pc=2045;continue;}
case 2045:{f.Push(JValue.R(rt.String("{player's}")));f.Pc=2048;continue;}
case 2048:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2049;continue;}
case 2049:{f.StackOp("dup");f.Pc=2050;continue;}
case 2050:{f.Push(JValue.I(2));f.Pc=2051;continue;}
case 2051:{f.Push(f.Locals[14]);f.Pc=2053;continue;}
case 2053:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:2053:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",2058);}
case 2058:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;)Ljava/lang/String;","invokestatic",2061);}
case 2061:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",2064);}
case 2064:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2065;continue;}
case 2065:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2068);}
case 2068:{f.Push(f.Locals[13]);f.Pc=2070;continue;}
case 2070:{f.Push(f.Locals[12]);f.Pc=2072;continue;}
case 2072:{return rt.Call(f,"forge/util/MessageUtil","formatMessage","(Ljava/lang/String;Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;","invokestatic",2075);}
case 2075:{f.Locals[23]=f.Pop();f.Pc=2077;continue;}
case 2077:{f.Pc=2124;continue;}
case 2080:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2083);}
case 2083:{f.Push(JValue.R(rt.String("lblSelectCardsFromPlayerZone")));f.Pc=2086;continue;}
case 2086:{f.Push(JValue.I(2));f.Pc=2087;continue;}
case 2087:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2090;continue;}
case 2090:{f.StackOp("dup");f.Pc=2091;continue;}
case 2091:{f.Push(JValue.I(0));f.Pc=2092;continue;}
case 2092:{f.Push(JValue.R(rt.String("{player's}")));f.Pc=2095;continue;}
case 2095:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2096;continue;}
case 2096:{f.StackOp("dup");f.Pc=2097;continue;}
case 2097:{f.Push(JValue.I(1));f.Pc=2098;continue;}
case 2098:{f.Push(f.Locals[14]);f.Pc=2100;continue;}
case 2100:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:2100:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",2105);}
case 2105:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;)Ljava/lang/String;","invokestatic",2108);}
case 2108:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",2111);}
case 2111:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2112;continue;}
case 2112:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2115);}
case 2115:{f.Push(f.Locals[13]);f.Pc=2117;continue;}
case 2117:{f.Push(f.Locals[12]);f.Pc=2119;continue;}
case 2119:{return rt.Call(f,"forge/util/MessageUtil","formatMessage","(Ljava/lang/String;Lforge/game/player/Player;Ljava/lang/Object;)Ljava/lang/String;","invokestatic",2122);}
case 2122:{f.Locals[23]=f.Pop();f.Pc=2124;continue;}
case 2124:{f.Push(f.Locals[1]);f.Pc=2125;continue;}
case 2125:{f.Push(JValue.R(rt.String("Mandatory")));f.Pc=2128;continue;}
case 2128:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2131);}
case 2131:{f.Pc=f.Pop().Int==0?2147:2134;continue;}
case 2134:{f.Push(f.Locals[17]);f.Pc=2136;continue;}
case 2136:{f.Push(f.Locals[18]);f.Pc=2138;continue;}
case 2138:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",2141);}
case 2141:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",2144);}
case 2144:{f.Pc=2148;continue;}
case 2147:{f.Push(JValue.I(0));f.Pc=2148;continue;}
case 2148:{f.Locals[32]=f.Pop();f.Pc=2150;continue;}
case 2150:{f.Push(f.Locals[13]);f.Pc=2152;continue;}
case 2152:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2155);}
case 2155:{f.Push(f.Locals[15]);f.Pc=2157;continue;}
case 2157:{f.Push(f.Locals[14]);f.Pc=2159;continue;}
case 2159:{f.Push(f.Locals[1]);f.Pc=2160;continue;}
case 2160:{f.Push(f.Locals[18]);f.Pc=2162;continue;}
case 2162:{f.Push(f.Locals[32]);f.Pc=2164;continue;}
case 2164:{f.Push(f.Locals[17]);f.Pc=2166;continue;}
case 2166:{f.Push(f.Locals[21]);f.Pc=2168;continue;}
case 2168:{f.Push(f.Locals[23]);f.Pc=2170;continue;}
case 2170:{f.Push(f.Locals[13]);f.Pc=2172;continue;}
case 2172:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForZoneChange","(Lforge/game/zone/ZoneType;Ljava/util/List;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;IILforge/game/player/DelayedReveal;Ljava/lang/String;Lforge/game/player/Player;)Ljava/util/List;","invokevirtual",2175);}
case 2175:{f.Locals[31]=f.Pop();f.Pc=2177;continue;}
case 2177:{f.Push(f.Locals[31]);f.Pc=2179;continue;}
case 2179:{f.Pc=f.Pop().Reference==null?2194:2182;continue;}
case 2182:{f.Push(f.Locals[31]);f.Pc=2184;continue;}
case 2184:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",2189);}
case 2189:{f.Push(f.Locals[17]);f.Pc=2191;continue;}
case 2191:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?2150:2194;continue;}
case 2194:{f.Push(f.Locals[31]);f.Pc=2196;continue;}
case 2196:{f.Pc=f.Pop().Reference==null?2207:2199;continue;}
case 2199:{f.Push(f.Locals[30]);f.Pc=2201;continue;}
case 2201:{f.Push(f.Locals[31]);f.Pc=2203;continue;}
case 2203:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",2206);}
case 2206:{f.StackOp("pop");f.Pc=2207;continue;}
case 2207:{f.Pc=2926;continue;}
case 2210:{f.Push(JValue.I(0));f.Pc=2211;continue;}
case 2211:{f.Locals[31]=f.Pop();f.Pc=2213;continue;}
case 2213:{f.Push(f.Locals[31]);f.Pc=2215;continue;}
case 2215:{f.Push(f.Locals[17]);f.Pc=2217;continue;}
case 2217:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?2911:2220;continue;}
case 2220:{f.Push(f.Locals[1]);f.Pc=2221;continue;}
case 2221:{f.Push(JValue.R(rt.String("DifferentNames")));f.Pc=2224;continue;}
case 2224:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2227);}
case 2227:{f.Pc=f.Pop().Int==0?2279:2230;continue;}
case 2230:{f.Push(f.Locals[30]);f.Pc=2232;continue;}
case 2232:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2235);}
case 2235:{f.Locals[32]=f.Pop();f.Pc=2237;continue;}
case 2237:{f.Push(f.Locals[32]);f.Pc=2239;continue;}
case 2239:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2244);}
case 2244:{f.Pc=f.Pop().Int==0?2279:2247;continue;}
case 2247:{f.Push(f.Locals[32]);f.Pc=2249;continue;}
case 2249:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2254);}
case 2254:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2257;continue;}
case 2257:{f.Locals[33]=f.Pop();f.Pc=2259;continue;}
case 2259:{f.Push(f.Locals[18]);f.Pc=2261;continue;}
case 2261:{f.Push(f.Locals[33]);f.Pc=2263;continue;}
case 2263:{return rt.Call(f,"forge/game/card/CardPredicates","sharesNameWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",2266);}
case 2266:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",2271);}
case 2271:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",2274);}
case 2274:{f.Locals[18]=f.Pop();f.Pc=2276;continue;}
case 2276:{f.Pc=2237;continue;}
case 2279:{f.Push(f.Locals[1]);f.Pc=2280;continue;}
case 2280:{f.Push(JValue.R(rt.String("DifferentCMC")));f.Pc=2283;continue;}
case 2283:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2286);}
case 2286:{f.Pc=f.Pop().Int==0?2338:2289;continue;}
case 2289:{f.Push(f.Locals[30]);f.Pc=2291;continue;}
case 2291:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2294);}
case 2294:{f.Locals[32]=f.Pop();f.Pc=2296;continue;}
case 2296:{f.Push(f.Locals[32]);f.Pc=2298;continue;}
case 2298:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2303);}
case 2303:{f.Pc=f.Pop().Int==0?2338:2306;continue;}
case 2306:{f.Push(f.Locals[32]);f.Pc=2308;continue;}
case 2308:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2313);}
case 2313:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2316;continue;}
case 2316:{f.Locals[33]=f.Pop();f.Pc=2318;continue;}
case 2318:{f.Push(f.Locals[18]);f.Pc=2320;continue;}
case 2320:{f.Push(f.Locals[33]);f.Pc=2322;continue;}
case 2322:{return rt.Call(f,"forge/game/card/CardPredicates","sharesCMCWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",2325);}
case 2325:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",2330);}
case 2330:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",2333);}
case 2333:{f.Locals[18]=f.Pop();f.Pc=2335;continue;}
case 2335:{f.Pc=2296;continue;}
case 2338:{f.Push(f.Locals[1]);f.Pc=2339;continue;}
case 2339:{f.Push(JValue.R(rt.String("DifferentPower")));f.Pc=2342;continue;}
case 2342:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2345);}
case 2345:{f.Pc=f.Pop().Int==0?2401:2348;continue;}
case 2348:{f.Push(f.Locals[30]);f.Pc=2350;continue;}
case 2350:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2353);}
case 2353:{f.Locals[32]=f.Pop();f.Pc=2355;continue;}
case 2355:{f.Push(f.Locals[32]);f.Pc=2357;continue;}
case 2357:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2362);}
case 2362:{f.Pc=f.Pop().Int==0?2401:2365;continue;}
case 2365:{f.Push(f.Locals[32]);f.Pc=2367;continue;}
case 2367:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2372);}
case 2372:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2375;continue;}
case 2375:{f.Locals[33]=f.Pop();f.Pc=2377;continue;}
case 2377:{f.Push(f.Locals[33]);f.Pc=2379;continue;}
case 2379:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",2382);}
case 2382:{f.Locals[34]=f.Pop();f.Pc=2384;continue;}
case 2384:{f.Push(f.Locals[18]);f.Pc=2386;continue;}
case 2386:{f.Push(f.Locals[34]);f.Pc=2388;continue;}
case 2388:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:2388:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",2393);}
case 2393:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",2396);}
case 2396:{f.Locals[18]=f.Pop();f.Pc=2398;continue;}
case 2398:{f.Pc=2355;continue;}
case 2401:{f.Push(f.Locals[1]);f.Pc=2402;continue;}
case 2402:{f.Push(JValue.R(rt.String("ShareLandType")));f.Pc=2405;continue;}
case 2405:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2408);}
case 2408:{f.Pc=f.Pop().Int==0?2455:2411;continue;}
case 2411:{f.Push(f.Locals[30]);f.Pc=2413;continue;}
case 2413:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",2416);}
case 2416:{f.Locals[32]=f.Pop();f.Pc=2418;continue;}
case 2418:{f.Push(f.Locals[32]);f.Pc=2420;continue;}
case 2420:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2425);}
case 2425:{f.Pc=f.Pop().Int==0?2455:2428;continue;}
case 2428:{f.Push(f.Locals[32]);f.Pc=2430;continue;}
case 2430:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2435);}
case 2435:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2438;continue;}
case 2438:{f.Locals[33]=f.Pop();f.Pc=2440;continue;}
case 2440:{f.Push(f.Locals[18]);f.Pc=2442;continue;}
case 2442:{f.Push(f.Locals[33]);f.Pc=2444;continue;}
case 2444:{return rt.Call(f,"forge/game/card/CardPredicates","sharesLandTypeWith","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",2447);}
case 2447:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",2450);}
case 2450:{f.Locals[18]=f.Pop();f.Pc=2452;continue;}
case 2452:{f.Pc=2418;continue;}
case 2455:{f.Push(f.Locals[24]);f.Pc=2457;continue;}
case 2457:{f.Pc=f.Pop().Reference==null?2485:2460;continue;}
case 2460:{f.Push(f.Locals[27]);f.Pc=2462;continue;}
case 2462:{f.Pc=f.Pop().Int<0?2485:2465;continue;}
case 2465:{f.Push(f.Locals[18]);f.Pc=2467;continue;}
case 2467:{f.Push(f.Locals[27]);f.Pc=2469;continue;}
case 2469:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:2469:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",2474);}
case 2474:{f.Push(f.Locals[2]);f.Pc=2475;continue;}
case 2475:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",2478);}
case 2478:{f.Push(f.Locals[2]);f.Pc=2479;continue;}
case 2479:{f.Push(f.Locals[1]);f.Pc=2480;continue;}
case 2480:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",2483);}
case 2483:{f.Locals[18]=f.Pop();f.Pc=2485;continue;}
case 2485:{f.Push(f.Locals[25]);f.Pc=2487;continue;}
case 2487:{f.Pc=f.Pop().Reference==null?2515:2490;continue;}
case 2490:{f.Push(f.Locals[28]);f.Pc=2492;continue;}
case 2492:{f.Pc=f.Pop().Int<0?2515:2495;continue;}
case 2495:{f.Push(f.Locals[18]);f.Pc=2497;continue;}
case 2497:{f.Push(f.Locals[28]);f.Pc=2499;continue;}
case 2499:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:2499:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",2504);}
case 2504:{f.Push(f.Locals[2]);f.Pc=2505;continue;}
case 2505:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",2508);}
case 2508:{f.Push(f.Locals[2]);f.Pc=2509;continue;}
case 2509:{f.Push(f.Locals[1]);f.Pc=2510;continue;}
case 2510:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",2513);}
case 2513:{f.Locals[18]=f.Pop();f.Pc=2515;continue;}
case 2515:{f.Push(f.Locals[31]);f.Pc=2517;continue;}
case 2517:{f.Pc=f.Pop().Int!=0?2524:2520;continue;}
case 2520:{f.Push(JValue.I(1));f.Pc=2521;continue;}
case 2521:{f.Pc=2525;continue;}
case 2524:{f.Push(JValue.I(0));f.Pc=2525;continue;}
case 2525:{f.Locals[32]=f.Pop();f.Pc=2527;continue;}
case 2527:{f.Push(JValue.R(null));f.Pc=2528;continue;}
case 2528:{f.Locals[33]=f.Pop();f.Pc=2530;continue;}
case 2530:{f.Push(f.Locals[1]);f.Pc=2531;continue;}
case 2531:{f.Push(JValue.R(rt.String("AtRandom")));f.Pc=2534;continue;}
case 2534:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2537);}
case 2537:{f.Pc=f.Pop().Int==0?2573:2540;continue;}
case 2540:{f.Push(f.Locals[32]);f.Pc=2542;continue;}
case 2542:{f.Pc=f.Pop().Int==0?2560:2545;continue;}
case 2545:{f.Push(f.Locals[21]);f.Pc=2547;continue;}
case 2547:{f.Pc=f.Pop().Reference==null?2560:2550;continue;}
case 2550:{f.Push(f.Locals[13]);f.Pc=2552;continue;}
case 2552:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2555);}
case 2555:{f.Push(f.Locals[21]);f.Pc=2557;continue;}
case 2557:{return rt.Call(f,"forge/game/player/PlayerController","reveal","(Lforge/game/player/DelayedReveal;)V","invokevirtual",2560);}
case 2560:{f.Push(f.Locals[18]);f.Pc=2562;continue;}
case 2562:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",2565);}
case 2565:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2568;continue;}
case 2568:{f.Locals[33]=f.Pop();f.Pc=2570;continue;}
case 2570:{f.Pc=2733;continue;}
case 2573:{f.Push(f.Locals[5]);f.Pc=2575;continue;}
case 2575:{f.Pc=f.Pop().Int==0?2597:2578;continue;}
case 2578:{f.Push(f.Locals[4]);f.Pc=2580;continue;}
case 2580:{f.Pc=f.Pop().Int!=0?2597:2583;continue;}
case 2583:{f.Push(f.Locals[18]);f.Pc=2585;continue;}
case 2585:{f.Push(JValue.R(null));f.Pc=2586;continue;}
case 2586:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",2589);}
case 2589:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2592;continue;}
case 2592:{f.Locals[33]=f.Pop();f.Pc=2594;continue;}
case 2594:{f.Pc=2733;continue;}
case 2597:{f.Push(f.Locals[26]);f.Pc=2599;continue;}
case 2599:{f.Pc=f.Pop().Reference==null?2666:2602;continue;}
case 2602:{f.Push(f.Locals[23]);f.Pc=2604;continue;}
case 2604:{f.Locals[34]=f.Pop();f.Pc=2606;continue;}
case 2606:{f.Push(f.Locals[34]);f.Pc=2608;continue;}
case 2608:{f.Push(f.Locals[29]);f.Pc=2610;continue;}
case 2610:{f.Push(JValue.I(0));f.Pc=2611;continue;}
case 2611:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",2614);}
case 2614:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:2614:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",2619);}
case 2619:{f.Locals[34]=f.Pop();f.Pc=2621;continue;}
case 2621:{f.Push(f.Locals[13]);f.Pc=2623;continue;}
case 2623:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2626);}
case 2626:{f.Push(f.Locals[15]);f.Pc=2628;continue;}
case 2628:{f.Push(f.Locals[14]);f.Pc=2630;continue;}
case 2630:{f.Push(f.Locals[1]);f.Pc=2631;continue;}
case 2631:{f.Push(f.Locals[18]);f.Pc=2633;continue;}
case 2633:{f.Push(f.Locals[32]);f.Pc=2635;continue;}
case 2635:{f.Pc=f.Pop().Int==0?2643:2638;continue;}
case 2638:{f.Push(f.Locals[21]);f.Pc=2640;continue;}
case 2640:{f.Pc=2644;continue;}
case 2643:{f.Push(JValue.R(null));f.Pc=2644;continue;}
case 2644:{f.Push(f.Locals[34]);f.Pc=2646;continue;}
case 2646:{f.Push(f.Locals[7]);f.Pc=2648;continue;}
case 2648:{f.Pc=f.Pop().Int!=0?2655:2651;continue;}
case 2651:{f.Push(JValue.I(1));f.Pc=2652;continue;}
case 2652:{f.Pc=2656;continue;}
case 2655:{f.Push(JValue.I(0));f.Pc=2656;continue;}
case 2656:{f.Push(f.Locals[13]);f.Pc=2658;continue;}
case 2658:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleCardForZoneChange","(Lforge/game/zone/ZoneType;Ljava/util/List;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;Lforge/game/player/DelayedReveal;Ljava/lang/String;ZLforge/game/player/Player;)Lforge/game/card/Card;","invokevirtual",2661);}
case 2661:{f.Locals[33]=f.Pop();f.Pc=2663;continue;}
case 2663:{f.Pc=2733;continue;}
case 2666:{f.Push(f.Locals[23]);f.Pc=2668;continue;}
case 2668:{f.Locals[34]=f.Pop();f.Pc=2670;continue;}
case 2670:{f.Push(f.Locals[17]);f.Pc=2672;continue;}
case 2672:{f.Push(JValue.I(1));f.Pc=2673;continue;}
case 2673:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2691:2676;continue;}
case 2676:{f.Push(f.Locals[34]);f.Pc=2678;continue;}
case 2678:{f.Push(f.Locals[31]);f.Pc=2680;continue;}
case 2680:{f.Push(JValue.I(1));f.Pc=2681;continue;}
case 2681:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=2682;continue;}
case 2682:{f.Push(f.Locals[17]);f.Pc=2684;continue;}
case 2684:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3110:2684:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;II)Ljava/lang/String;",2689);}
case 2689:{f.Locals[34]=f.Pop();f.Pc=2691;continue;}
case 2691:{f.Push(f.Locals[13]);f.Pc=2693;continue;}
case 2693:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2696);}
case 2696:{f.Push(f.Locals[15]);f.Pc=2698;continue;}
case 2698:{f.Push(f.Locals[14]);f.Pc=2700;continue;}
case 2700:{f.Push(f.Locals[1]);f.Pc=2701;continue;}
case 2701:{f.Push(f.Locals[18]);f.Pc=2703;continue;}
case 2703:{f.Push(f.Locals[32]);f.Pc=2705;continue;}
case 2705:{f.Pc=f.Pop().Int==0?2713:2708;continue;}
case 2708:{f.Push(f.Locals[21]);f.Pc=2710;continue;}
case 2710:{f.Pc=2714;continue;}
case 2713:{f.Push(JValue.R(null));f.Pc=2714;continue;}
case 2714:{f.Push(f.Locals[34]);f.Pc=2716;continue;}
case 2716:{f.Push(f.Locals[7]);f.Pc=2718;continue;}
case 2718:{f.Pc=f.Pop().Int!=0?2725:2721;continue;}
case 2721:{f.Push(JValue.I(1));f.Pc=2722;continue;}
case 2722:{f.Pc=2726;continue;}
case 2725:{f.Push(JValue.I(0));f.Pc=2726;continue;}
case 2726:{f.Push(f.Locals[13]);f.Pc=2728;continue;}
case 2728:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleCardForZoneChange","(Lforge/game/zone/ZoneType;Ljava/util/List;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;Lforge/game/player/DelayedReveal;Ljava/lang/String;ZLforge/game/player/Player;)Lforge/game/card/Card;","invokevirtual",2731);}
case 2731:{f.Locals[33]=f.Pop();f.Pc=2733;continue;}
case 2733:{f.Push(f.Locals[33]);f.Pc=2735;continue;}
case 2735:{f.Pc=f.Pop().Reference!=null?2821:2738;continue;}
case 2738:{f.Push(f.Locals[18]);f.Pc=2740;continue;}
case 2740:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",2743);}
case 2743:{f.Push(f.Locals[17]);f.Pc=2745;continue;}
case 2745:{f.Push(f.Locals[31]);f.Pc=2747;continue;}
case 2747:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=2748;continue;}
case 2748:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",2751);}
case 2751:{f.Locals[34]=f.Pop();f.Pc=2753;continue;}
case 2753:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",2756);}
case 2756:{f.Push(JValue.R(rt.String("lblCancelSearchUpToSelectNumCards")));f.Pc=2759;continue;}
case 2759:{f.Push(JValue.I(1));f.Pc=2760;continue;}
case 2760:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=2763;continue;}
case 2763:{f.StackOp("dup");f.Pc=2764;continue;}
case 2764:{f.Push(JValue.I(0));f.Pc=2765;continue;}
case 2765:{f.Push(f.Locals[34]);f.Pc=2767;continue;}
case 2767:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",2770);}
case 2770:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=2771;continue;}
case 2771:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",2774);}
case 2774:{f.Locals[35]=f.Pop();f.Pc=2776;continue;}
case 2776:{f.Push(f.Locals[18]);f.Pc=2778;continue;}
case 2778:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",2781);}
case 2781:{f.Pc=f.Pop().Int!=0?2911:2784;continue;}
case 2784:{f.Push(f.Locals[1]);f.Pc=2785;continue;}
case 2785:{f.Push(JValue.R(rt.String("SkipCancelPrompt")));f.Pc=2788;continue;}
case 2788:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2791);}
case 2791:{f.Pc=f.Pop().Int!=0?2911:2794;continue;}
case 2794:{f.Push(f.Locals[13]);f.Pc=2796;continue;}
case 2796:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2799);}
case 2799:{f.Push(f.Locals[1]);f.Pc=2800;continue;}
case 2800:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","ChangeZoneGeneral","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","ChangeZoneGeneral","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=2803;continue;}
case 2803:{f.Push(f.Locals[35]);f.Pc=2805;continue;}
case 2805:{f.Push(JValue.R(null));f.Pc=2806;continue;}
case 2806:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",2809);}
case 2809:{f.Pc=f.Pop().Int==0?2815:2812;continue;}
case 2812:{f.Pc=2911;continue;}
case 2815:{f.Locals[31]=JValue.I(unchecked(f.Locals[31].Int+(-1)));f.Pc=2818;continue;}
case 2818:{f.Pc=2905;continue;}
case 2821:{f.Push(f.Locals[18]);f.Pc=2823;continue;}
case 2823:{f.Push(f.Locals[33]);f.Pc=2825;continue;}
case 2825:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",2828);}
case 2828:{f.StackOp("pop");f.Pc=2829;continue;}
case 2829:{f.Push(f.Locals[21]);f.Pc=2831;continue;}
case 2831:{f.Pc=f.Pop().Reference==null?2844:2834;continue;}
case 2834:{f.Push(f.Locals[21]);f.Pc=2836;continue;}
case 2836:{f.Push(f.Locals[33]);f.Pc=2838;continue;}
case 2838:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",2841);}
case 2841:{return rt.Call(f,"forge/game/player/DelayedReveal","remove","(Lforge/game/card/CardView;)V","invokevirtual",2844);}
case 2844:{f.Push(f.Locals[30]);f.Pc=2846;continue;}
case 2846:{f.Push(f.Locals[33]);f.Pc=2848;continue;}
case 2848:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",2851);}
case 2851:{f.StackOp("pop");f.Pc=2852;continue;}
case 2852:{f.Push(f.Locals[24]);f.Pc=2854;continue;}
case 2854:{f.Pc=f.Pop().Reference==null?2867:2857;continue;}
case 2857:{f.Push(f.Locals[27]);f.Pc=2859;continue;}
case 2859:{f.Push(f.Locals[33]);f.Pc=2861;continue;}
case 2861:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",2864);}
case 2864:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=2865;continue;}
case 2865:{f.Locals[27]=f.Pop();f.Pc=2867;continue;}
case 2867:{f.Push(f.Locals[25]);f.Pc=2869;continue;}
case 2869:{f.Pc=f.Pop().Reference==null?2882:2872;continue;}
case 2872:{f.Push(f.Locals[28]);f.Pc=2874;continue;}
case 2874:{f.Push(f.Locals[33]);f.Pc=2876;continue;}
case 2876:{return rt.Call(f,"forge/game/card/Card","getCurrentPower","()I","invokevirtual",2879);}
case 2879:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=2880;continue;}
case 2880:{f.Locals[28]=f.Pop();f.Pc=2882;continue;}
case 2882:{f.Push(f.Locals[26]);f.Pc=2884;continue;}
case 2884:{f.Pc=f.Pop().Reference==null?2905:2887;continue;}
case 2887:{f.Push(f.Locals[29]);f.Pc=2889;continue;}
case 2889:{f.Push(f.Locals[33]);f.Pc=2891;continue;}
case 2891:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",2894);}
case 2894:{return rt.Call(f,"forge/card/CardTypeView","getCoreTypes","()Ljava/util/Collection;","invokeinterface",2899);}
case 2899:{return rt.Call(f,"com/google/common/collect/Iterables","size","(Ljava/lang/Iterable;)I","invokestatic",2902);}
case 2902:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=2903;continue;}
case 2903:{f.Locals[29]=f.Pop();f.Pc=2905;continue;}
case 2905:{f.Locals[31]=JValue.I(unchecked(f.Locals[31].Int+(1)));f.Pc=2908;continue;}
case 2908:{f.Pc=2213;continue;}
case 2911:{f.Push(f.Locals[26]);f.Pc=2913;continue;}
case 2913:{f.Pc=f.Pop().Reference==null?2926:2916;continue;}
case 2916:{f.Push(f.Locals[29]);f.Pc=2918;continue;}
case 2918:{f.Pc=f.Pop().Int<=0?2926:2921;continue;}
case 2921:{f.Push(f.Locals[30]);f.Pc=2923;continue;}
case 2923:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",2926);}
case 2926:{f.Push(f.Locals[1]);f.Pc=2927;continue;}
case 2927:{f.Push(JValue.R(rt.String("ShuffleChangedPile")));f.Pc=2930;continue;}
case 2930:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2933);}
case 2933:{f.Pc=f.Pop().Int==0?2941:2936;continue;}
case 2936:{f.Push(f.Locals[30]);f.Pc=2938;continue;}
case 2938:{return rt.Call(f,"forge/game/card/CardLists","shuffle","(Ljava/util/List;)V","invokestatic",2941);}
case 2941:{f.Push(f.Locals[1]);f.Pc=2942;continue;}
case 2942:{f.Push(JValue.R(rt.String("DestinationAlternative")));f.Pc=2945;continue;}
case 2945:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2948);}
case 2948:{f.Pc=f.Pop().Int==0?2990:2951;continue;}
case 2951:{f.Push(f.Locals[0]);f.Pc=2952;continue;}
case 2952:{f.Push(f.Locals[1]);f.Pc=2953;continue;}
case 2953:{f.Push(f.Locals[2]);f.Pc=2954;continue;}
case 2954:{f.Push(f.Locals[15]);f.Pc=2956;continue;}
case 2956:{f.Push(f.Locals[16]);f.Pc=2958;continue;}
case 2958:{f.Push(f.Locals[13]);f.Pc=2960;continue;}
case 2960:{f.Push(f.Locals[30]);f.Pc=2962;continue;}
case 2962:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","handleAltDest","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/zone/ZoneType;ILforge/game/player/Player;Lforge/game/card/CardCollectionView;)Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",2965);}
case 2965:{f.Locals[31]=f.Pop();f.Pc=2967;continue;}
case 2967:{f.Push(f.Locals[31]);f.Pc=2969;continue;}
case 2969:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",2972);}
case 2972:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2975;continue;}
case 2975:{f.Locals[15]=f.Pop();f.Pc=2977;continue;}
case 2977:{f.Push(f.Locals[31]);f.Pc=2979;continue;}
case 2979:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getValue","()Ljava/lang/Object;","invokevirtual",2982);}
case 2982:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2985;continue;}
case 2985:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",2988);}
case 2988:{f.Locals[16]=f.Pop();f.Pc=2990;continue;}
case 2990:{f.Push(f.Locals[14]);f.Pc=2992;continue;}
case 2992:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=2995;continue;}
case 2995:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",3000);}
case 3000:{f.Pc=f.Pop().Int==0?3022:3003;continue;}
case 3003:{f.Push(f.Locals[15]);f.Pc=3005;continue;}
case 3005:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=3008;continue;}
case 3008:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?3022:3011;continue;}
case 3011:{f.Push(f.Locals[19]);f.Pc=3013;continue;}
case 3013:{f.Pc=f.Pop().Int==0?3022:3016;continue;}
case 3016:{f.Push(f.Locals[12]);f.Pc=3018;continue;}
case 3018:{f.Push(f.Locals[1]);f.Pc=3019;continue;}
case 3019:{return rt.Call(f,"forge/game/player/Player","shuffle","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",3022);}
case 3022:{f.Push(f.Locals[1]);f.Pc=3023;continue;}
case 3023:{f.Push(JValue.R(rt.String("Reorder")));f.Pc=3026;continue;}
case 3026:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3029);}
case 3029:{f.Pc=f.Pop().Int==0?3054:3032;continue;}
case 3032:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3035;continue;}
case 3035:{f.StackOp("dup");f.Pc=3036;continue;}
case 3036:{f.Push(f.Locals[13]);f.Pc=3038;continue;}
case 3038:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",3041);}
case 3041:{f.Push(f.Locals[30]);f.Pc=3043;continue;}
case 3043:{f.Push(f.Locals[15]);f.Pc=3045;continue;}
case 3045:{f.Push(f.Locals[1]);f.Pc=3046;continue;}
case 3046:{return rt.Call(f,"forge/game/player/PlayerController","orderMoveToZoneList","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",3049);}
case 3049:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",3052);}
case 3052:{f.Locals[30]=f.Pop();f.Pc=3054;continue;}
case 3054:{f.Push(f.Locals[22]);f.Pc=3056;continue;}
case 3056:{f.Pc=f.Pop().Reference==null?3069:3059;continue;}
case 3059:{f.Push(f.Locals[12]);f.Pc=3061;continue;}
case 3061:{f.Push(f.Locals[22]);f.Pc=3063;continue;}
case 3063:{return rt.Call(f,"java/lang/Long","longValue","()J","invokevirtual",3066);}
case 3066:{return rt.Call(f,"forge/game/player/Player","removeController","(J)V","invokevirtual",3069);}
case 3069:{f.Push(f.Locals[1]);f.Pc=3070;continue;}
case 3070:{f.Push(JValue.R(rt.String("Exactly")));f.Pc=3073;continue;}
case 3073:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3076);}
case 3076:{f.Pc=f.Pop().Int==0?3092:3079;continue;}
case 3079:{f.Push(f.Locals[30]);f.Pc=3081;continue;}
case 3081:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",3084);}
case 3084:{f.Push(f.Locals[17]);f.Pc=3086;continue;}
case 3086:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?3092:3089;continue;}
case 3089:{f.Pc=167;continue;}
case 3092:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices")));f.Pc=3095;continue;}
case 3095:{f.StackOp("dup");f.Pc=3096;continue;}
case 3096:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","<init>","()V","invokespecial",3099);}
case 3099:{f.Locals[31]=f.Pop();f.Pc=3101;continue;}
case 3101:{f.Push(f.Locals[31]);f.Pc=3103;continue;}
case 3103:{f.Push(f.Locals[20]);f.Pc=3105;continue;}
case 3105:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","searchedLibrary","Z",value);f.Pc=3108;continue;}
case 3108:{f.Push(f.Locals[31]);f.Pc=3110;continue;}
case 3110:{f.Push(f.Locals[19]);f.Pc=3112;continue;}
case 3112:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","shuffleMandatory","Z",value);f.Pc=3115;continue;}
case 3115:{f.Push(f.Locals[31]);f.Pc=3117;continue;}
case 3117:{f.Push(f.Locals[30]);f.Pc=3119;continue;}
case 3119:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","chosenCards","Lforge/game/card/CardCollection;",value);f.Pc=3122;continue;}
case 3122:{f.Push(f.Locals[31]);f.Pc=3124;continue;}
case 3124:{f.Push(f.Locals[16]);f.Pc=3126;continue;}
case 3126:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","libraryPos","I",value);f.Pc=3129;continue;}
case 3129:{f.Push(f.Locals[31]);f.Pc=3131;continue;}
case 3131:{f.Push(f.Locals[14]);f.Pc=3133;continue;}
case 3133:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","origin","Ljava/util/List;",value);f.Pc=3136;continue;}
case 3136:{f.Push(f.Locals[31]);f.Pc=3138;continue;}
case 3138:{f.Push(f.Locals[15]);f.Pc=3140;continue;}
case 3140:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","destination","Lforge/game/zone/ZoneType;",value);f.Pc=3143;continue;}
case 3143:{f.Push(f.Locals[8]);f.Pc=3145;continue;}
case 3145:{f.Push(f.Locals[12]);f.Pc=3147;continue;}
case 3147:{f.Push(f.Locals[31]);f.Pc=3149;continue;}
case 3149:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3154);}
case 3154:{f.StackOp("pop");f.Pc=3155;continue;}
case 3155:{f.Pc=167;continue;}
case 3158:{f.Push(f.Locals[1]);f.Pc=3159;continue;}
case 3159:{f.Push(JValue.R(rt.String("RememberChanged")));f.Pc=3162;continue;}
case 3162:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3165);}
case 3165:{f.Locals[11]=f.Pop();f.Pc=3167;continue;}
case 3167:{f.Push(f.Locals[1]);f.Pc=3168;continue;}
case 3168:{f.Push(JValue.R(rt.String("ForgetChanged")));f.Pc=3171;continue;}
case 3171:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3174);}
case 3174:{f.Locals[12]=f.Pop();f.Pc=3176;continue;}
case 3176:{f.Push(f.Locals[1]);f.Pc=3177;continue;}
case 3177:{f.Push(JValue.R(rt.String("Champion")));f.Pc=3180;continue;}
case 3180:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3183);}
case 3183:{f.Locals[13]=f.Pop();f.Pc=3185;continue;}
case 3185:{f.Push(f.Locals[1]);f.Pc=3186;continue;}
case 3186:{f.Push(JValue.R(rt.String("Imprint")));f.Pc=3189;continue;}
case 3189:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3192);}
case 3192:{f.Locals[14]=f.Pop();f.Pc=3194;continue;}
case 3194:{f.Push(JValue.I(0));f.Pc=3195;continue;}
case 3195:{f.Locals[15]=f.Pop();f.Pc=3197;continue;}
case 3197:{f.Push(f.Locals[1]);f.Pc=3198;continue;}
case 3198:{return rt.Call(f,"forge/game/card/CardZoneTable","getSimultaneousInstance","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",3201);}
case 3201:{f.Locals[16]=f.Pop();f.Pc=3203;continue;}
case 3203:{f.Push(f.Locals[8]);f.Pc=3205;continue;}
case 3205:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",3210);}
case 3210:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",3215);}
case 3215:{f.Locals[17]=f.Pop();f.Pc=3217;continue;}
case 3217:{f.Push(f.Locals[17]);f.Pc=3219;continue;}
case 3219:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3224);}
case 3224:{f.Pc=f.Pop().Int==0?5034:3227;continue;}
case 3227:{f.Push(f.Locals[17]);f.Pc=3229;continue;}
case 3229:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3234);}
case 3234:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3237;continue;}
case 3237:{f.Locals[18]=f.Pop();f.Pc=3239;continue;}
case 3239:{f.Push(f.Locals[8]);f.Pc=3241;continue;}
case 3241:{f.Push(f.Locals[18]);f.Pc=3243;continue;}
case 3243:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3248);}
case 3248:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3251;continue;}
case 3251:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","searchedLibrary","Z"));f.Pc=3254;continue;}
case 3254:{f.Locals[19]=f.Pop();f.Pc=3256;continue;}
case 3256:{f.Push(f.Locals[8]);f.Pc=3258;continue;}
case 3258:{f.Push(f.Locals[18]);f.Pc=3260;continue;}
case 3260:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3265);}
case 3265:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3268;continue;}
case 3268:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","shuffleMandatory","Z"));f.Pc=3271;continue;}
case 3271:{f.Locals[20]=f.Pop();f.Pc=3273;continue;}
case 3273:{f.Push(f.Locals[8]);f.Pc=3275;continue;}
case 3275:{f.Push(f.Locals[18]);f.Pc=3277;continue;}
case 3277:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3282);}
case 3282:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3285;continue;}
case 3285:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","chosenCards","Lforge/game/card/CardCollection;"));f.Pc=3288;continue;}
case 3288:{f.Locals[21]=f.Pop();f.Pc=3290;continue;}
case 3290:{f.Push(f.Locals[8]);f.Pc=3292;continue;}
case 3292:{f.Push(f.Locals[18]);f.Pc=3294;continue;}
case 3294:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3299);}
case 3299:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3302;continue;}
case 3302:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","libraryPos","I"));f.Pc=3305;continue;}
case 3305:{f.Locals[22]=f.Pop();f.Pc=3307;continue;}
case 3307:{f.Push(f.Locals[8]);f.Pc=3309;continue;}
case 3309:{f.Push(f.Locals[18]);f.Pc=3311;continue;}
case 3311:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3316);}
case 3316:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3319;continue;}
case 3319:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","origin","Ljava/util/List;"));f.Pc=3322;continue;}
case 3322:{f.Locals[23]=f.Pop();f.Pc=3324;continue;}
case 3324:{f.Push(f.Locals[8]);f.Pc=3326;continue;}
case 3326:{f.Push(f.Locals[18]);f.Pc=3328;continue;}
case 3328:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3333);}
case 3333:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3336;continue;}
case 3336:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/ChangeZoneEffect$HiddenOriginChoices","destination","Lforge/game/zone/ZoneType;"));f.Pc=3339;continue;}
case 3339:{f.Locals[24]=f.Pop();f.Pc=3341;continue;}
case 3341:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3344;continue;}
case 3344:{f.StackOp("dup");f.Pc=3345;continue;}
case 3345:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",3348);}
case 3348:{f.Locals[25]=f.Pop();f.Pc=3350;continue;}
case 3350:{f.Push(f.Locals[10]);f.Pc=3352;continue;}
case 3352:{f.Push(f.Locals[18]);f.Pc=3354;continue;}
case 3354:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",3357);}
case 3357:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3360;continue;}
case 3360:{f.Locals[26]=f.Pop();f.Pc=3362;continue;}
case 3362:{f.Push(f.Locals[21]);f.Pc=3364;continue;}
case 3364:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",3367);}
case 3367:{f.Locals[27]=f.Pop();f.Pc=3369;continue;}
case 3369:{f.Push(f.Locals[27]);f.Pc=3371;continue;}
case 3371:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",3376);}
case 3376:{f.Pc=f.Pop().Int==0?4866:3379;continue;}
case 3379:{f.Push(f.Locals[27]);f.Pc=3381;continue;}
case 3381:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",3386);}
case 3386:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3389;continue;}
case 3389:{f.Locals[28]=f.Pop();f.Pc=3391;continue;}
case 3391:{f.Push(f.Locals[3]);f.Pc=3392;continue;}
case 3392:{f.Push(f.Locals[28]);f.Pc=3394;continue;}
case 3394:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",3397);}
case 3397:{f.Locals[30]=f.Pop();f.Pc=3399;continue;}
case 3399:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",3402);}
case 3402:{f.Locals[31]=f.Pop();f.Pc=3404;continue;}
case 3404:{f.Push(f.Locals[31]);f.Pc=3406;continue;}
case 3406:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","FoundSearchingLibrary","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","FoundSearchingLibrary","Lforge/game/ability/AbilityKey;"));f.Pc=3409;continue;}
case 3409:{f.Push(f.Locals[19]);f.Pc=3411;continue;}
case 3411:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",3414);}
case 3414:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3419);}
case 3419:{f.StackOp("pop");f.Pc=3420;continue;}
case 3420:{f.Push(f.Locals[31]);f.Pc=3422;continue;}
case 3422:{f.Push(f.Locals[16]);f.Pc=3424;continue;}
case 3424:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",3427);}
case 3427:{f.Push(f.Locals[24]);f.Pc=3429;continue;}
case 3429:{f.Pc=f.Pop().Reference!=null?3439:3432;continue;}
case 3432:{f.Push(f.Locals[28]);f.Pc=3434;continue;}
case 3434:{f.Locals[29]=f.Pop();f.Pc=3436;continue;}
case 3436:{f.Pc=4415;continue;}
case 3439:{f.Push(f.Locals[24]);f.Pc=3441;continue;}
case 3441:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=3444;continue;}
case 3444:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",3447);}
case 3447:{f.Pc=f.Pop().Int==0?3469:3450;continue;}
case 3450:{f.Push(f.Locals[3]);f.Pc=3451;continue;}
case 3451:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",3454);}
case 3454:{f.Push(f.Locals[28]);f.Pc=3456;continue;}
case 3456:{f.Push(f.Locals[22]);f.Pc=3458;continue;}
case 3458:{f.Push(f.Locals[1]);f.Pc=3459;continue;}
case 3459:{f.Push(f.Locals[31]);f.Pc=3461;continue;}
case 3461:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",3464);}
case 3464:{f.Locals[29]=f.Pop();f.Pc=3466;continue;}
case 3466:{f.Pc=4415;continue;}
case 3469:{f.Push(f.Locals[24]);f.Pc=3471;continue;}
case 3471:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=3474;continue;}
case 3474:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",3477);}
case 3477:{f.Pc=f.Pop().Int==0?4217:3480;continue;}
case 3480:{f.Push(f.Locals[31]);f.Pc=3482;continue;}
case 3482:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"));f.Pc=3485;continue;}
case 3485:{f.Push(f.Locals[21]);f.Pc=3487;continue;}
case 3487:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3492);}
case 3492:{f.StackOp("pop");f.Pc=3493;continue;}
case 3493:{f.Push(f.Locals[1]);f.Pc=3494;continue;}
case 3494:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=3496;continue;}
case 3496:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3499);}
case 3499:{f.Pc=f.Pop().Int==0?3508:3502;continue;}
case 3502:{f.Push(f.Locals[28]);f.Pc=3504;continue;}
case 3504:{f.Push(JValue.I(1));f.Pc=3505;continue;}
case 3505:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",3508);}
case 3508:{f.Push(f.Locals[1]);f.Pc=3509;continue;}
case 3509:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=3512;continue;}
case 3512:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3515);}
case 3515:{f.Pc=f.Pop().Int==0?3587:3518;continue;}
case 3518:{f.Push(f.Locals[1]);f.Pc=3519;continue;}
case 3519:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=3522;continue;}
case 3522:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3525);}
case 3525:{f.Locals[32]=f.Pop();f.Pc=3527;continue;}
case 3527:{f.Push(f.Locals[32]);f.Pc=3529;continue;}
case 3529:{f.Push(JValue.R(rt.String("True")));f.Pc=3532;continue;}
case 3532:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",3535);}
case 3535:{f.Pc=f.Pop().Int==0?3545:3538;continue;}
case 3538:{f.Push(f.Locals[1]);f.Pc=3539;continue;}
case 3539:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",3542);}
case 3542:{f.Pc=3559;continue;}
case 3545:{f.Push(f.Locals[2]);f.Pc=3546;continue;}
case 3546:{f.Push(f.Locals[32]);f.Pc=3548;continue;}
case 3548:{f.Push(f.Locals[1]);f.Pc=3549;continue;}
case 3549:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",3552);}
case 3552:{f.Push(JValue.I(0));f.Pc=3553;continue;}
case 3553:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",3556);}
case 3556:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3559;continue;}
case 3559:{f.Locals[33]=f.Pop();f.Pc=3561;continue;}
case 3561:{f.Push(f.Locals[33]);f.Pc=3563;continue;}
case 3563:{f.Push(f.Locals[28]);f.Pc=3565;continue;}
case 3565:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",3568);}
case 3568:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?3576:3571;continue;}
case 3571:{f.Push(f.Locals[28]);f.Pc=3573;continue;}
case 3573:{return rt.Call(f,"forge/game/card/Card","runChangeControllerCommands","()V","invokevirtual",3576);}
case 3576:{f.Push(f.Locals[28]);f.Pc=3578;continue;}
case 3578:{f.Push(f.Locals[33]);f.Pc=3580;continue;}
case 3580:{f.Push(f.Locals[3]);f.Pc=3581;continue;}
case 3581:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",3584);}
case 3584:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",3587);}
case 3587:{f.Push(f.Locals[1]);f.Pc=3588;continue;}
case 3588:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=3591;continue;}
case 3591:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3594);}
case 3594:{f.Pc=f.Pop().Int==0?3662:3597;continue;}
case 3597:{f.Push(f.Locals[1]);f.Pc=3598;continue;}
case 3598:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=3601;continue;}
case 3601:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3604);}
case 3604:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",3607);}
case 3607:{f.Locals[32]=f.Pop();f.Pc=3609;continue;}
case 3609:{f.Push(f.Locals[2]);f.Pc=3610;continue;}
case 3610:{f.Push(f.Locals[1]);f.Pc=3611;continue;}
case 3611:{f.Push(JValue.R(rt.String("WithCountersAmount")));f.Pc=3614;continue;}
case 3614:{f.Push(JValue.R(rt.String("1")));f.Pc=3617;continue;}
case 3617:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3620);}
case 3620:{f.Push(f.Locals[1]);f.Pc=3621;continue;}
case 3621:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",3624);}
case 3624:{f.Locals[33]=f.Pop();f.Pc=3626;continue;}
case 3626:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=3629;continue;}
case 3629:{f.StackOp("dup");f.Pc=3630;continue;}
case 3630:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",3633);}
case 3633:{f.Locals[34]=f.Pop();f.Pc=3635;continue;}
case 3635:{f.Push(f.Locals[34]);f.Pc=3637;continue;}
case 3637:{f.Push(f.Locals[18]);f.Pc=3639;continue;}
case 3639:{f.Push(f.Locals[28]);f.Pc=3641;continue;}
case 3641:{f.Push(f.Locals[32]);f.Pc=3643;continue;}
case 3643:{f.Push(f.Locals[33]);f.Pc=3645;continue;}
case 3645:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",3648);}
case 3648:{f.StackOp("pop");f.Pc=3649;continue;}
case 3649:{f.Push(f.Locals[31]);f.Pc=3651;continue;}
case 3651:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=3654;continue;}
case 3654:{f.Push(f.Locals[34]);f.Pc=3656;continue;}
case 3656:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3661);}
case 3661:{f.StackOp("pop");f.Pc=3662;continue;}
case 3662:{f.Push(f.Locals[1]);f.Pc=3663;continue;}
case 3663:{f.Push(JValue.R(rt.String("Transformed")));f.Pc=3666;continue;}
case 3666:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3669);}
case 3669:{f.Pc=f.Pop().Int==0?3720:3672;continue;}
case 3672:{f.Push(f.Locals[28]);f.Pc=3674;continue;}
case 3674:{return rt.Call(f,"forge/game/card/Card","isTransformable","()Z","invokevirtual",3677);}
case 3677:{f.Pc=f.Pop().Int==0?3369:3680;continue;}
case 3680:{f.Push(f.Locals[31]);f.Pc=3682;continue;}
case 3682:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=3685;continue;}
case 3685:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",3690);}
case 3690:{f.Pc=f.Pop().Int!=0?3709:3693;continue;}
case 3693:{f.Push(f.Locals[31]);f.Pc=3695;continue;}
case 3695:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=3698;continue;}
case 3698:{f.Push(f.Locals[28]);f.Pc=3700;continue;}
case 3700:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",3703);}
case 3703:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3708);}
case 3708:{f.StackOp("pop");f.Pc=3709;continue;}
case 3709:{f.Push(f.Locals[28]);f.Pc=3711;continue;}
case 3711:{f.Push(JValue.R(rt.String("Transform")));f.Pc=3714;continue;}
case 3714:{f.Push(JValue.R(null));f.Pc=3715;continue;}
case 3715:{f.Push(f.Locals[1]);f.Pc=3716;continue;}
case 3716:{return rt.Call(f,"forge/game/card/Card","changeCardState","(Ljava/lang/String;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",3719);}
case 3719:{f.StackOp("pop");f.Pc=3720;continue;}
case 3720:{f.Push(f.Locals[1]);f.Pc=3721;continue;}
case 3721:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=3724;continue;}
case 3724:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3727);}
case 3727:{f.Pc=f.Pop().Int==0?3900:3730;continue;}
case 3730:{f.Push(f.Locals[28]);f.Pc=3732;continue;}
case 3732:{return rt.Call(f,"forge/game/card/Card","isAttachment","()Z","invokevirtual",3735);}
case 3735:{f.Pc=f.Pop().Int==0?3900:3738;continue;}
case 3738:{f.Push(f.Locals[2]);f.Pc=3739;continue;}
case 3739:{f.Push(f.Locals[1]);f.Pc=3740;continue;}
case 3740:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=3743;continue;}
case 3743:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3746);}
case 3746:{f.Push(f.Locals[1]);f.Pc=3747;continue;}
case 3747:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",3750);}
case 3750:{f.Locals[32]=f.Pop();f.Pc=3752;continue;}
case 3752:{f.Push(f.Locals[32]);f.Pc=3754;continue;}
case 3754:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",3757);}
case 3757:{f.Pc=f.Pop().Int==0?3783:3760;continue;}
case 3760:{f.Push(f.Locals[16]);f.Pc=3762;continue;}
case 3762:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",3765);}
case 3765:{f.Push(f.Locals[1]);f.Pc=3766;continue;}
case 3766:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=3769;continue;}
case 3769:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3772);}
case 3772:{f.Push(f.Locals[2]);f.Pc=3773;continue;}
case 3773:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",3776);}
case 3776:{f.Push(f.Locals[2]);f.Pc=3777;continue;}
case 3777:{f.Push(f.Locals[1]);f.Pc=3778;continue;}
case 3778:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",3781);}
case 3781:{f.Locals[32]=f.Pop();f.Pc=3783;continue;}
case 3783:{f.Push(f.Locals[32]);f.Pc=3785;continue;}
case 3785:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",3788);}
case 3788:{f.Pc=f.Pop().Int!=0?3804:3791;continue;}
case 3791:{f.Push(f.Locals[32]);f.Pc=3793;continue;}
case 3793:{f.Push(f.Locals[28]);f.Pc=3795;continue;}
case 3795:{f.Push(f.Locals[1]);f.Pc=3796;continue;}
case 3796:{return rt.Call(f,"forge/game/card/CardPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;","invokestatic",3799);}
case 3799:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",3802);}
case 3802:{f.Locals[32]=f.Pop();f.Pc=3804;continue;}
case 3804:{f.Push(f.Locals[32]);f.Pc=3806;continue;}
case 3806:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",3809);}
case 3809:{f.Pc=f.Pop().Int!=0?3889:3812;continue;}
case 3812:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3815);}
case 3815:{f.Push(JValue.R(rt.String("lblSelectACardAttachSourceTo")));f.Pc=3818;continue;}
case 3818:{f.Push(JValue.I(1));f.Pc=3819;continue;}
case 3819:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=3822;continue;}
case 3822:{f.StackOp("dup");f.Pc=3823;continue;}
case 3823:{f.Push(JValue.I(0));f.Pc=3824;continue;}
case 3824:{f.Push(f.Locals[28]);f.Pc=3826;continue;}
case 3826:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",3829);}
case 3829:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=3830;continue;}
case 3830:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",3833);}
case 3833:{f.Locals[33]=f.Pop();f.Pc=3835;continue;}
case 3835:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",3838);}
case 3838:{f.Locals[34]=f.Pop();f.Pc=3840;continue;}
case 3840:{f.Push(f.Locals[34]);f.Pc=3842;continue;}
case 3842:{f.Push(JValue.R(rt.String("Attach")));f.Pc=3845;continue;}
case 3845:{f.Push(f.Locals[28]);f.Pc=3847;continue;}
case 3847:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3852);}
case 3852:{f.StackOp("pop");f.Pc=3853;continue;}
case 3853:{f.Push(f.Locals[26]);f.Pc=3855;continue;}
case 3855:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",3858);}
case 3858:{f.Push(f.Locals[32]);f.Pc=3860;continue;}
case 3860:{f.Push(f.Locals[1]);f.Pc=3861;continue;}
case 3861:{f.Push(f.Locals[33]);f.Pc=3863;continue;}
case 3863:{f.Push(f.Locals[34]);f.Pc=3865;continue;}
case 3865:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",3868);}
case 3868:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3871;continue;}
case 3871:{f.Locals[35]=f.Pop();f.Pc=3873;continue;}
case 3873:{f.Push(f.Locals[28]);f.Pc=3875;continue;}
case 3875:{f.Push(f.Locals[3]);f.Pc=3876;continue;}
case 3876:{f.Push(f.Locals[35]);f.Pc=3878;continue;}
case 3878:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",3881);}
case 3881:{f.Push(f.Locals[1]);f.Pc=3882;continue;}
case 3882:{f.Push(JValue.I(1));f.Pc=3883;continue;}
case 3883:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;Z)V","invokevirtual",3886);}
case 3886:{f.Pc=3900;continue;}
case 3889:{f.Push(f.Locals[28]);f.Pc=3891;continue;}
case 3891:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",3894);}
case 3894:{f.Pc=f.Pop().Int==0?3900:3897;continue;}
case 3897:{f.Pc=3369;continue;}
case 3900:{f.Push(f.Locals[1]);f.Pc=3901;continue;}
case 3901:{f.Push(JValue.R(rt.String("AttachedToPlayer")));f.Pc=3904;continue;}
case 3904:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",3907);}
case 3907:{f.Pc=f.Pop().Int==0?4003:3910;continue;}
case 3910:{f.Push(f.Locals[2]);f.Pc=3911;continue;}
case 3911:{f.Push(f.Locals[1]);f.Pc=3912;continue;}
case 3912:{f.Push(JValue.R(rt.String("AttachedToPlayer")));f.Pc=3915;continue;}
case 3915:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",3918);}
case 3918:{f.Push(f.Locals[1]);f.Pc=3919;continue;}
case 3919:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",3922);}
case 3922:{f.Locals[32]=f.Pop();f.Pc=3924;continue;}
case 3924:{f.Push(f.Locals[32]);f.Pc=3926;continue;}
case 3926:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",3931);}
case 3931:{f.Pc=f.Pop().Int!=0?3369:3934;continue;}
case 3934:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3937);}
case 3937:{f.Push(JValue.R(rt.String("lblSelectACardAttachSourceTo")));f.Pc=3940;continue;}
case 3940:{f.Push(JValue.I(1));f.Pc=3941;continue;}
case 3941:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=3944;continue;}
case 3944:{f.StackOp("dup");f.Pc=3945;continue;}
case 3945:{f.Push(JValue.I(0));f.Pc=3946;continue;}
case 3946:{f.Push(f.Locals[28]);f.Pc=3948;continue;}
case 3948:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",3951);}
case 3951:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=3952;continue;}
case 3952:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",3955);}
case 3955:{f.Locals[33]=f.Pop();f.Pc=3957;continue;}
case 3957:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",3960);}
case 3960:{f.Locals[34]=f.Pop();f.Pc=3962;continue;}
case 3962:{f.Push(f.Locals[34]);f.Pc=3964;continue;}
case 3964:{f.Push(JValue.R(rt.String("Attach")));f.Pc=3967;continue;}
case 3967:{f.Push(f.Locals[28]);f.Pc=3969;continue;}
case 3969:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",3974);}
case 3974:{f.StackOp("pop");f.Pc=3975;continue;}
case 3975:{f.Push(f.Locals[18]);f.Pc=3977;continue;}
case 3977:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",3980);}
case 3980:{f.Push(f.Locals[32]);f.Pc=3982;continue;}
case 3982:{f.Push(f.Locals[1]);f.Pc=3983;continue;}
case 3983:{f.Push(f.Locals[33]);f.Pc=3985;continue;}
case 3985:{f.Push(f.Locals[34]);f.Pc=3987;continue;}
case 3987:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",3990);}
case 3990:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=3993;continue;}
case 3993:{f.Locals[35]=f.Pop();f.Pc=3995;continue;}
case 3995:{f.Push(f.Locals[28]);f.Pc=3997;continue;}
case 3997:{f.Push(f.Locals[35]);f.Pc=3999;continue;}
case 3999:{f.Push(f.Locals[1]);f.Pc=4000;continue;}
case 4000:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)V","invokevirtual",4003);}
case 4003:{f.Push(f.Locals[28]);f.Pc=4005;continue;}
case 4005:{f.Push(f.Locals[1]);f.Pc=4006;continue;}
case 4006:{f.Push(JValue.R(rt.String("Attacking")));f.Pc=4008;continue;}
case 4008:{f.Push(JValue.R(rt.String("Blocking")));f.Pc=4011;continue;}
case 4011:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","addToCombat","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/String;)Z","invokestatic",4014);}
case 4014:{f.Pc=f.Pop().Int==0?4020:4017;continue;}
case 4017:{f.Push(JValue.I(1));f.Pc=4018;continue;}
case 4018:{f.Locals[15]=f.Pop();f.Pc=4020;continue;}
case 4020:{f.Push(f.Locals[1]);f.Pc=4021;continue;}
case 4021:{f.Push(JValue.R(rt.String("FaceDown")));f.Pc=4024;continue;}
case 4024:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",4027);}
case 4027:{f.Pc=f.Pop().Int==0?4043:4030;continue;}
case 4030:{f.Push(f.Locals[28]);f.Pc=4032;continue;}
case 4032:{f.Push(JValue.I(1));f.Pc=4033;continue;}
case 4033:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",4036);}
case 4036:{f.StackOp("pop");f.Pc=4037;continue;}
case 4037:{f.Push(f.Locals[28]);f.Pc=4039;continue;}
case 4039:{f.Push(f.Locals[1]);f.Pc=4040;continue;}
case 4040:{return rt.Call(f,"forge/game/card/CardFactoryUtil","setFaceDownState","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",4043);}
case 4043:{f.Push(f.Locals[3]);f.Pc=4044;continue;}
case 4044:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",4047);}
case 4047:{f.Push(f.Locals[28]);f.Pc=4049;continue;}
case 4049:{f.Push(f.Locals[28]);f.Pc=4051;continue;}
case 4051:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",4054);}
case 4054:{f.Push(f.Locals[1]);f.Pc=4055;continue;}
case 4055:{f.Push(f.Locals[31]);f.Pc=4057;continue;}
case 4057:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",4060);}
case 4060:{f.Locals[29]=f.Pop();f.Pc=4062;continue;}
case 4062:{f.Push(f.Locals[1]);f.Pc=4063;continue;}
case 4063:{f.Push(JValue.R(rt.String("AttachAfter")));f.Pc=4066;continue;}
case 4066:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",4069);}
case 4069:{f.Pc=f.Pop().Int==0?4415:4072;continue;}
case 4072:{f.Push(f.Locals[29]);f.Pc=4074;continue;}
case 4074:{return rt.Call(f,"forge/game/card/Card","isAttachment","()Z","invokevirtual",4077);}
case 4077:{f.Pc=f.Pop().Int==0?4415:4080;continue;}
case 4080:{f.Push(f.Locals[29]);f.Pc=4082;continue;}
case 4082:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",4085);}
case 4085:{f.Pc=f.Pop().Int==0?4415:4088;continue;}
case 4088:{f.Push(f.Locals[2]);f.Pc=4089;continue;}
case 4089:{f.Push(f.Locals[1]);f.Pc=4090;continue;}
case 4090:{f.Push(JValue.R(rt.String("AttachAfter")));f.Pc=4093;continue;}
case 4093:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4096);}
case 4096:{f.Push(f.Locals[1]);f.Pc=4097;continue;}
case 4097:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",4100);}
case 4100:{f.Locals[32]=f.Pop();f.Pc=4102;continue;}
case 4102:{f.Push(f.Locals[32]);f.Pc=4104;continue;}
case 4104:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",4107);}
case 4107:{f.Pc=f.Pop().Int==0?4137:4110;continue;}
case 4110:{f.Push(f.Locals[3]);f.Pc=4111;continue;}
case 4111:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=4114;continue;}
case 4114:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",4117);}
case 4117:{f.Push(f.Locals[1]);f.Pc=4118;continue;}
case 4118:{f.Push(JValue.R(rt.String("AttachAfter")));f.Pc=4121;continue;}
case 4121:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4124);}
case 4124:{f.Push(f.Locals[28]);f.Pc=4126;continue;}
case 4126:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",4129);}
case 4129:{f.Push(f.Locals[28]);f.Pc=4131;continue;}
case 4131:{f.Push(f.Locals[1]);f.Pc=4132;continue;}
case 4132:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",4135);}
case 4135:{f.Locals[32]=f.Pop();f.Pc=4137;continue;}
case 4137:{f.Push(f.Locals[32]);f.Pc=4139;continue;}
case 4139:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",4142);}
case 4142:{f.Pc=f.Pop().Int!=0?4214:4145;continue;}
case 4145:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",4148);}
case 4148:{f.Push(JValue.R(rt.String("lblSelectACardAttachSourceTo")));f.Pc=4151;continue;}
case 4151:{f.Push(JValue.I(1));f.Pc=4152;continue;}
case 4152:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=4155;continue;}
case 4155:{f.StackOp("dup");f.Pc=4156;continue;}
case 4156:{f.Push(JValue.I(0));f.Pc=4157;continue;}
case 4157:{f.Push(f.Locals[28]);f.Pc=4159;continue;}
case 4159:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",4162);}
case 4162:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=4163;continue;}
case 4163:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",4166);}
case 4166:{f.Locals[33]=f.Pop();f.Pc=4168;continue;}
case 4168:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",4171);}
case 4171:{f.Locals[34]=f.Pop();f.Pc=4173;continue;}
case 4173:{f.Push(f.Locals[34]);f.Pc=4175;continue;}
case 4175:{f.Push(JValue.R(rt.String("Attach")));f.Pc=4178;continue;}
case 4178:{f.Push(f.Locals[29]);f.Pc=4180;continue;}
case 4180:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",4185);}
case 4185:{f.StackOp("pop");f.Pc=4186;continue;}
case 4186:{f.Push(f.Locals[26]);f.Pc=4188;continue;}
case 4188:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",4191);}
case 4191:{f.Push(f.Locals[32]);f.Pc=4193;continue;}
case 4193:{f.Push(f.Locals[1]);f.Pc=4194;continue;}
case 4194:{f.Push(f.Locals[33]);f.Pc=4196;continue;}
case 4196:{f.Push(f.Locals[34]);f.Pc=4198;continue;}
case 4198:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",4201);}
case 4201:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4204;continue;}
case 4204:{f.Locals[35]=f.Pop();f.Pc=4206;continue;}
case 4206:{f.Push(f.Locals[29]);f.Pc=4208;continue;}
case 4208:{f.Push(f.Locals[35]);f.Pc=4210;continue;}
case 4210:{f.Push(f.Locals[1]);f.Pc=4211;continue;}
case 4211:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)V","invokevirtual",4214);}
case 4214:{f.Pc=4415;continue;}
case 4217:{f.Push(f.Locals[24]);f.Pc=4219;continue;}
case 4219:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=4222;continue;}
case 4222:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",4225);}
case 4225:{f.Pc=f.Pop().Int==0?4398:4228;continue;}
case 4228:{f.Push(f.Locals[28]);f.Pc=4230;continue;}
case 4230:{f.Push(f.Locals[1]);f.Pc=4231;continue;}
case 4231:{f.Push(JValue.I(1));f.Pc=4232;continue;}
case 4232:{return rt.Call(f,"forge/game/card/Card","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",4235);}
case 4235:{f.Pc=f.Pop().Int!=0?4241:4238;continue;}
case 4238:{f.Pc=3369;continue;}
case 4241:{f.Push(f.Locals[3]);f.Pc=4242;continue;}
case 4242:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",4245);}
case 4245:{f.Push(f.Locals[28]);f.Pc=4247;continue;}
case 4247:{f.Push(f.Locals[1]);f.Pc=4248;continue;}
case 4248:{f.Push(f.Locals[31]);f.Pc=4250;continue;}
case 4250:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",4253);}
case 4253:{f.Locals[29]=f.Pop();f.Pc=4255;continue;}
case 4255:{f.Push(f.Locals[29]);f.Pc=4257;continue;}
case 4257:{f.Push(f.Locals[1]);f.Pc=4258;continue;}
case 4258:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",4261);}
case 4261:{f.Push(f.Locals[16]);f.Pc=4263;continue;}
case 4263:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",4266);}
case 4266:{f.Locals[32]=f.Pop();f.Pc=4268;continue;}
case 4268:{f.Push(f.Locals[24]);f.Pc=4270;continue;}
case 4270:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=4273;continue;}
case 4273:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",4276);}
case 4276:{f.Pc=f.Pop().Int==0?4318:4279;continue;}
case 4279:{f.Push(f.Locals[32]);f.Pc=4281;continue;}
case 4281:{f.Push(f.Locals[28]);f.Pc=4283;continue;}
case 4283:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",4288);}
case 4288:{f.Pc=f.Pop().Int==0?4318:4291;continue;}
case 4291:{f.Push(f.Locals[2]);f.Pc=4292;continue;}
case 4292:{f.Push(f.Locals[28]);f.Pc=4294;continue;}
case 4294:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",4297);}
case 4297:{f.Pc=f.Pop().Int==0?4318:4300;continue;}
case 4300:{f.Push(f.Locals[29]);f.Pc=4302;continue;}
case 4302:{f.Push(f.Locals[1]);f.Pc=4303;continue;}
case 4303:{f.Push(f.Locals[32]);f.Pc=4305;continue;}
case 4305:{f.Push(f.Locals[28]);f.Pc=4307;continue;}
case 4307:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",4312);}
case 4312:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4315;continue;}
case 4315:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)V","invokestatic",4318);}
case 4318:{f.Push(f.Locals[1]);f.Pc=4319;continue;}
case 4319:{f.Push(JValue.R(rt.String("ExileFaceDown")));f.Pc=4321;continue;}
case 4321:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",4324);}
case 4324:{f.Pc=f.Pop().Int==0?4334:4327;continue;}
case 4327:{f.Push(f.Locals[29]);f.Pc=4329;continue;}
case 4329:{f.Push(JValue.I(1));f.Pc=4330;continue;}
case 4330:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",4333);}
case 4333:{f.StackOp("pop");f.Pc=4334;continue;}
case 4334:{f.Push(f.Locals[1]);f.Pc=4335;continue;}
case 4335:{f.Push(JValue.R(rt.String("Foretold")));f.Pc=4338;continue;}
case 4338:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",4341);}
case 4341:{f.Pc=f.Pop().Int==0?4366:4344;continue;}
case 4344:{f.Push(f.Locals[29]);f.Pc=4346;continue;}
case 4346:{f.Push(JValue.I(1));f.Pc=4347;continue;}
case 4347:{return rt.Call(f,"forge/game/card/Card","setForetold","(Z)V","invokevirtual",4350);}
case 4350:{f.Push(f.Locals[1]);f.Pc=4351;continue;}
case 4351:{f.Push(JValue.R(rt.String("ForetoldCost")));f.Pc=4354;continue;}
case 4354:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",4357);}
case 4357:{f.Pc=f.Pop().Int==0?4366:4360;continue;}
case 4360:{f.Push(f.Locals[29]);f.Pc=4362;continue;}
case 4362:{f.Push(JValue.I(1));f.Pc=4363;continue;}
case 4363:{return rt.Call(f,"forge/game/card/Card","setForetoldCostByEffect","(Z)V","invokevirtual",4366);}
case 4366:{f.Push(f.Locals[1]);f.Pc=4367;continue;}
case 4367:{f.Push(JValue.R(rt.String("WithMayLook")));f.Pc=4370;continue;}
case 4370:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",4373);}
case 4373:{f.Pc=f.Pop().Int!=0?4386:4376;continue;}
case 4376:{f.Push(f.Locals[1]);f.Pc=4377;continue;}
case 4377:{f.Push(JValue.R(rt.String("Foretold")));f.Pc=4380;continue;}
case 4380:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",4383);}
case 4383:{f.Pc=f.Pop().Int==0?4395:4386;continue;}
case 4386:{f.Push(f.Locals[29]);f.Pc=4388;continue;}
case 4388:{f.Push(f.Locals[1]);f.Pc=4389;continue;}
case 4389:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4392);}
case 4392:{return rt.Call(f,"forge/game/card/Card","addMayLookFaceDownExile","(Lforge/game/player/Player;)V","invokevirtual",4395);}
case 4395:{f.Pc=4415;continue;}
case 4398:{f.Push(f.Locals[3]);f.Pc=4399;continue;}
case 4399:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",4402);}
case 4402:{f.Push(f.Locals[24]);f.Pc=4404;continue;}
case 4404:{f.Push(f.Locals[28]);f.Pc=4406;continue;}
case 4406:{f.Push(JValue.I(0));f.Pc=4407;continue;}
case 4407:{f.Push(f.Locals[1]);f.Pc=4408;continue;}
case 4408:{f.Push(f.Locals[31]);f.Pc=4410;continue;}
case 4410:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",4413);}
case 4413:{f.Locals[29]=f.Pop();f.Pc=4415;continue;}
case 4415:{f.Push(f.Locals[25]);f.Pc=4417;continue;}
case 4417:{f.Push(f.Locals[29]);f.Pc=4419;continue;}
case 4419:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",4422);}
case 4422:{f.StackOp("pop");f.Pc=4423;continue;}
case 4423:{f.Push(f.Locals[30]);f.Pc=4425;continue;}
case 4425:{f.Pc=f.Pop().Reference==null?4542:4428;continue;}
case 4428:{f.Push(f.Locals[28]);f.Pc=4430;continue;}
case 4430:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",4433);}
case 4433:{f.Pc=f.Pop().Reference==null?4470:4436;continue;}
case 4436:{f.Push(f.Locals[3]);f.Pc=4437;continue;}
case 4437:{f.Push(f.Locals[28]);f.Pc=4439;continue;}
case 4439:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",4442);}
case 4442:{f.Push(JValue.R(null));f.Pc=4443;continue;}
case 4443:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",4446);}
case 4446:{f.Locals[32]=f.Pop();f.Pc=4448;continue;}
case 4448:{f.Push(f.Locals[32]);f.Pc=4450;continue;}
case 4450:{f.Pc=f.Pop().Reference==null?4470:4453;continue;}
case 4453:{f.Push(f.Locals[24]);f.Pc=4455;continue;}
case 4455:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=4458;continue;}
case 4458:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",4461);}
case 4461:{f.Pc=f.Pop().Int==0?4470:4464;continue;}
case 4464:{f.Push(f.Locals[32]);f.Pc=4466;continue;}
case 4466:{f.Push(f.Locals[1]);f.Pc=4467;continue;}
case 4467:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",4470);}
case 4470:{f.Push(f.Locals[28]);f.Pc=4472;continue;}
case 4472:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",4475);}
case 4475:{f.Pc=f.Pop().Int==0?4542:4478;continue;}
case 4478:{f.Push(f.Locals[28]);f.Pc=4480;continue;}
case 4480:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",4483);}
case 4483:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",4488);}
case 4488:{f.Locals[32]=f.Pop();f.Pc=4490;continue;}
case 4490:{f.Push(f.Locals[32]);f.Pc=4492;continue;}
case 4492:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",4497);}
case 4497:{f.Pc=f.Pop().Int==0?4542:4500;continue;}
case 4500:{f.Push(f.Locals[32]);f.Pc=4502;continue;}
case 4502:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",4507);}
case 4507:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4510;continue;}
case 4510:{f.Locals[33]=f.Pop();f.Pc=4512;continue;}
case 4512:{f.Push(f.Locals[33]);f.Pc=4514;continue;}
case 4514:{f.Push(f.Locals[28]);f.Pc=4516;continue;}
case 4516:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?4522:4519;continue;}
case 4519:{f.Pc=4490;continue;}
case 4522:{f.Push(f.Locals[24]);f.Pc=4524;continue;}
case 4524:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=4527;continue;}
case 4527:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",4530);}
case 4530:{f.Pc=f.Pop().Int==0?4539:4533;continue;}
case 4533:{f.Push(f.Locals[28]);f.Pc=4535;continue;}
case 4535:{f.Push(f.Locals[1]);f.Pc=4536;continue;}
case 4536:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",4539);}
case 4539:{f.Pc=4490;continue;}
case 4542:{f.Push(f.Locals[13]);f.Pc=4544;continue;}
case 4544:{f.Pc=f.Pop().Int==0?4579:4547;continue;}
case 4547:{f.Push(f.Locals[2]);f.Pc=4548;continue;}
case 4548:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",4551);}
case 4551:{f.Locals[32]=f.Pop();f.Pc=4553;continue;}
case 4553:{f.Push(f.Locals[32]);f.Pc=4555;continue;}
case 4555:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Championed","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Championed","Lforge/game/ability/AbilityKey;"));f.Pc=4558;continue;}
case 4558:{f.Push(f.Locals[28]);f.Pc=4560;continue;}
case 4560:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",4565);}
case 4565:{f.StackOp("pop");f.Pc=4566;continue;}
case 4566:{f.Push(f.Locals[3]);f.Pc=4567;continue;}
case 4567:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",4570);}
case 4570:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Championed","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Championed","Lforge/game/trigger/TriggerType;"));f.Pc=4573;continue;}
case 4573:{f.Push(f.Locals[32]);f.Pc=4575;continue;}
case 4575:{f.Push(JValue.I(0));f.Pc=4576;continue;}
case 4576:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",4579);}
case 4579:{f.Push(f.Locals[11]);f.Pc=4581;continue;}
case 4581:{f.Pc=f.Pop().Int==0?4682:4584;continue;}
case 4584:{f.Push(f.Locals[2]);f.Pc=4585;continue;}
case 4585:{f.Push(f.Locals[29]);f.Pc=4587;continue;}
case 4587:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",4590);}
case 4590:{f.Push(f.Locals[28]);f.Pc=4592;continue;}
case 4592:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",4595);}
case 4595:{f.Pc=f.Pop().Reference==null?4621:4598;continue;}
case 4598:{f.Push(f.Locals[3]);f.Pc=4599;continue;}
case 4599:{f.Push(f.Locals[28]);f.Pc=4601;continue;}
case 4601:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",4604);}
case 4604:{f.Push(JValue.R(null));f.Pc=4605;continue;}
case 4605:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",4608);}
case 4608:{f.Locals[32]=f.Pop();f.Pc=4610;continue;}
case 4610:{f.Push(f.Locals[32]);f.Pc=4612;continue;}
case 4612:{f.Pc=f.Pop().Reference==null?4621:4615;continue;}
case 4615:{f.Push(f.Locals[2]);f.Pc=4616;continue;}
case 4616:{f.Push(f.Locals[32]);f.Pc=4618;continue;}
case 4618:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",4621);}
case 4621:{f.Push(f.Locals[28]);f.Pc=4623;continue;}
case 4623:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",4626);}
case 4626:{f.Pc=f.Pop().Int==0?4682:4629;continue;}
case 4629:{f.Push(f.Locals[28]);f.Pc=4631;continue;}
case 4631:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",4634);}
case 4634:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",4639);}
case 4639:{f.Locals[32]=f.Pop();f.Pc=4641;continue;}
case 4641:{f.Push(f.Locals[32]);f.Pc=4643;continue;}
case 4643:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",4648);}
case 4648:{f.Pc=f.Pop().Int==0?4682:4651;continue;}
case 4651:{f.Push(f.Locals[32]);f.Pc=4653;continue;}
case 4653:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",4658);}
case 4658:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4661;continue;}
case 4661:{f.Locals[33]=f.Pop();f.Pc=4663;continue;}
case 4663:{f.Push(f.Locals[33]);f.Pc=4665;continue;}
case 4665:{f.Push(f.Locals[28]);f.Pc=4667;continue;}
case 4667:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?4673:4670;continue;}
case 4670:{f.Pc=4641;continue;}
case 4673:{f.Push(f.Locals[2]);f.Pc=4674;continue;}
case 4674:{f.Push(f.Locals[33]);f.Pc=4676;continue;}
case 4676:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",4679);}
case 4679:{f.Pc=4641;continue;}
case 4682:{f.Push(f.Locals[1]);f.Pc=4683;continue;}
case 4683:{f.Push(JValue.R(rt.String("RememberLKI")));f.Pc=4686;continue;}
case 4686:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",4689);}
case 4689:{f.Pc=f.Pop().Int==0?4701:4692;continue;}
case 4692:{f.Push(f.Locals[2]);f.Pc=4693;continue;}
case 4693:{f.Push(f.Locals[28]);f.Pc=4695;continue;}
case 4695:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",4698);}
case 4698:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",4701);}
case 4701:{f.Push(f.Locals[12]);f.Pc=4703;continue;}
case 4703:{f.Pc=f.Pop().Int==0?4712:4706;continue;}
case 4706:{f.Push(f.Locals[2]);f.Pc=4707;continue;}
case 4707:{f.Push(f.Locals[29]);f.Pc=4709;continue;}
case 4709:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",4712);}
case 4712:{f.Push(f.Locals[14]);f.Pc=4714;continue;}
case 4714:{f.Pc=f.Pop().Int==0?4784:4717;continue;}
case 4717:{f.Push(f.Locals[2]);f.Pc=4718;continue;}
case 4718:{f.Push(f.Locals[29]);f.Pc=4720;continue;}
case 4720:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",4723);}
case 4723:{f.Push(f.Locals[28]);f.Pc=4725;continue;}
case 4725:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",4728);}
case 4728:{f.Pc=f.Pop().Int==0?4784:4731;continue;}
case 4731:{f.Push(f.Locals[28]);f.Pc=4733;continue;}
case 4733:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",4736);}
case 4736:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",4741);}
case 4741:{f.Locals[32]=f.Pop();f.Pc=4743;continue;}
case 4743:{f.Push(f.Locals[32]);f.Pc=4745;continue;}
case 4745:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",4750);}
case 4750:{f.Pc=f.Pop().Int==0?4784:4753;continue;}
case 4753:{f.Push(f.Locals[32]);f.Pc=4755;continue;}
case 4755:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",4760);}
case 4760:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=4763;continue;}
case 4763:{f.Locals[33]=f.Pop();f.Pc=4765;continue;}
case 4765:{f.Push(f.Locals[33]);f.Pc=4767;continue;}
case 4767:{f.Push(f.Locals[28]);f.Pc=4769;continue;}
case 4769:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?4775:4772;continue;}
case 4772:{f.Pc=4743;continue;}
case 4775:{f.Push(f.Locals[2]);f.Pc=4776;continue;}
case 4776:{f.Push(f.Locals[33]);f.Pc=4778;continue;}
case 4778:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",4781);}
case 4781:{f.Pc=4743;continue;}
case 4784:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=4787;continue;}
case 4787:{f.Push(f.Locals[24]);f.Pc=4789;continue;}
case 4789:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",4792);}
case 4792:{f.Pc=f.Pop().Int==0?4863:4795;continue;}
case 4795:{f.Push(f.Locals[1]);f.Pc=4796;continue;}
case 4796:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=4799;continue;}
case 4799:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",4802);}
case 4802:{f.Pc=f.Pop().Int==0?4863:4805;continue;}
case 4805:{f.Push(f.Locals[1]);f.Pc=4806;continue;}
case 4806:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=4809;continue;}
case 4809:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4812);}
case 4812:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",4815);}
case 4815:{f.Locals[32]=f.Pop();f.Pc=4817;continue;}
case 4817:{f.Push(f.Locals[2]);f.Pc=4818;continue;}
case 4818:{f.Push(f.Locals[1]);f.Pc=4819;continue;}
case 4819:{f.Push(JValue.R(rt.String("WithCountersAmount")));f.Pc=4822;continue;}
case 4822:{f.Push(JValue.R(rt.String("1")));f.Pc=4825;continue;}
case 4825:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4828);}
case 4828:{f.Push(f.Locals[1]);f.Pc=4829;continue;}
case 4829:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",4832);}
case 4832:{f.Locals[33]=f.Pop();f.Pc=4834;continue;}
case 4834:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=4837;continue;}
case 4837:{f.StackOp("dup");f.Pc=4838;continue;}
case 4838:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",4841);}
case 4841:{f.Locals[34]=f.Pop();f.Pc=4843;continue;}
case 4843:{f.Push(f.Locals[29]);f.Pc=4845;continue;}
case 4845:{f.Push(f.Locals[32]);f.Pc=4847;continue;}
case 4847:{f.Push(f.Locals[33]);f.Pc=4849;continue;}
case 4849:{f.Push(f.Locals[18]);f.Pc=4851;continue;}
case 4851:{f.Push(f.Locals[34]);f.Pc=4853;continue;}
case 4853:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",4856);}
case 4856:{f.Push(f.Locals[34]);f.Pc=4858;continue;}
case 4858:{f.Push(f.Locals[3]);f.Pc=4859;continue;}
case 4859:{f.Push(f.Locals[1]);f.Pc=4860;continue;}
case 4860:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",4863);}
case 4863:{f.Pc=3369;continue;}
case 4866:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=4869;continue;}
case 4869:{f.Push(f.Locals[24]);f.Pc=4871;continue;}
case 4871:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",4874);}
case 4874:{f.Pc=f.Pop().Int!=0?4900:4877;continue;}
case 4877:{f.Push(f.Locals[6]);f.Pc=4879;continue;}
case 4879:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",4882);}
case 4882:{f.Pc=f.Pop().Int!=0?4900:4885;continue;}
case 4885:{f.Push(f.Locals[5]);f.Pc=4887;continue;}
case 4887:{f.Pc=f.Pop().Int!=0?4900:4890;continue;}
case 4890:{f.Push(f.Locals[6]);f.Pc=4892;continue;}
case 4892:{f.Push(JValue.R(rt.String("Card")));f.Pc=4894;continue;}
case 4894:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4897);}
case 4897:{f.Pc=f.Pop().Int==0?4918:4900;continue;}
case 4900:{f.Push(f.Locals[1]);f.Pc=4901;continue;}
case 4901:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=4904;continue;}
case 4904:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",4907);}
case 4907:{f.Pc=f.Pop().Int==0?4939:4910;continue;}
case 4910:{f.Push(f.Locals[25]);f.Pc=4912;continue;}
case 4912:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",4915);}
case 4915:{f.Pc=f.Pop().Int!=0?4939:4918;continue;}
case 4918:{f.Push(f.Locals[1]);f.Pc=4919;continue;}
case 4919:{f.Push(JValue.R(rt.String("NoReveal")));f.Pc=4922;continue;}
case 4922:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",4925);}
case 4925:{f.Pc=f.Pop().Int!=0?4939:4928;continue;}
case 4928:{f.Push(f.Locals[3]);f.Pc=4929;continue;}
case 4929:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",4932);}
case 4932:{f.Push(f.Locals[25]);f.Pc=4934;continue;}
case 4934:{f.Push(f.Locals[18]);f.Pc=4936;continue;}
case 4936:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;)V","invokevirtual",4939);}
case 4939:{f.Push(f.Locals[23]);f.Pc=4941;continue;}
case 4941:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=4944;continue;}
case 4944:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",4949);}
case 4949:{f.Pc=f.Pop().Int==0?4968:4952;continue;}
case 4952:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=4955;continue;}
case 4955:{f.Push(f.Locals[24]);f.Pc=4957;continue;}
case 4957:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",4960);}
case 4960:{f.Pc=f.Pop().Int!=0?4968:4963;continue;}
case 4963:{f.Push(f.Locals[20]);f.Pc=4965;continue;}
case 4965:{f.Pc=f.Pop().Int!=0?4994:4968;continue;}
case 4968:{f.Push(f.Locals[1]);f.Pc=4969;continue;}
case 4969:{f.Push(JValue.R(rt.String("Shuffle")));f.Pc=4972;continue;}
case 4972:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",4975);}
case 4975:{f.Pc=f.Pop().Int==0?5000:4978;continue;}
case 4978:{f.Push(JValue.R(rt.String("True")));f.Pc=4981;continue;}
case 4981:{f.Push(f.Locals[1]);f.Pc=4982;continue;}
case 4982:{f.Push(JValue.R(rt.String("Shuffle")));f.Pc=4985;continue;}
case 4985:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",4988);}
case 4988:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",4991);}
case 4991:{f.Pc=f.Pop().Int==0?5000:4994;continue;}
case 4994:{f.Push(f.Locals[18]);f.Pc=4996;continue;}
case 4996:{f.Push(f.Locals[1]);f.Pc=4997;continue;}
case 4997:{return rt.Call(f,"forge/game/player/Player","shuffle","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5000);}
case 5000:{f.Push(f.Locals[1]);f.Pc=5001;continue;}
case 5001:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=5004;continue;}
case 5004:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",5007);}
case 5007:{f.Pc=f.Pop().Int==0?5031:5010;continue;}
case 5010:{f.Push(f.Locals[25]);f.Pc=5012;continue;}
case 5012:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",5015);}
case 5015:{f.Pc=f.Pop().Int!=0?5031:5018;continue;}
case 5018:{f.Push(f.Locals[1]);f.Pc=5019;continue;}
case 5019:{f.Push(f.Locals[1]);f.Pc=5020;continue;}
case 5020:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=5023;continue;}
case 5023:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5026);}
case 5026:{f.Push(f.Locals[25]);f.Pc=5028;continue;}
case 5028:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V","invokestatic",5031);}
case 5031:{f.Pc=3217;continue;}
case 5034:{f.Push(f.Locals[15]);f.Pc=5036;continue;}
case 5036:{f.Pc=f.Pop().Int==0?5054:5039;continue;}
case 5039:{f.Push(f.Locals[3]);f.Pc=5040;continue;}
case 5040:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",5043);}
case 5043:{f.Push(f.Locals[3]);f.Pc=5044;continue;}
case 5044:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=5047;continue;}
case 5047:{f.StackOp("dup");f.Pc=5048;continue;}
case 5048:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",5051);}
case 5051:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",5054);}
case 5054:{f.Push(f.Locals[16]);f.Pc=5056;continue;}
case 5056:{f.Push(f.Locals[3]);f.Pc=5057;continue;}
case 5057:{f.Push(f.Locals[1]);f.Pc=5058;continue;}
case 5058:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",5061);}
case 5061:{f.Push(f.Locals[16]);f.Pc=5063;continue;}
case 5063:{f.Push(f.Locals[1]);f.Pc=5064;continue;}
case 5064:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","changeZoneUntilCommand","(Lforge/game/card/CardZoneTable;Lforge/game/spellability/SpellAbility;)V","invokestatic",5067);}
case 5067:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3111(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("While you're searching your library, you may cast CARDNAME from your library.")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardLists","getKeyword","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",12);}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/player/PlayerController","tempShowCards","(Ljava/lang/Iterable;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?145:32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{f.Push(JValue.R(null));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSpellsFromPlayEffect","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/card/CardStateName;ZLjava/util/function/Predicate;)Ljava/util/List;","invokestatic",55);}
case 55:{f.Locals[6]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",64);}
case 64:{f.Pc=f.Pop().Int==0?70:67;continue;}
case 67:{f.Pc=22;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",74);}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/player/PlayerController","getAbilityToPlay","(Lforge/game/card/Card;Ljava/util/List;)Lforge/game/spellability/SpellAbility;","invokevirtual",81);}
case 81:{f.Locals[7]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",87);}
case 87:{f.Push(f.Locals[7]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(null));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",93);}
case 93:{f.Push(JValue.R(rt.String("lblDoYouWantPlayCard")));f.Pc=96;continue;}
case 96:{f.Push(JValue.I(1));f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=100;continue;}
case 100:{f.StackOp("dup");f.Pc=101;continue;}
case 101:{f.Push(JValue.I(0));f.Pc=102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",107);}
case 107:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",111);}
case 111:{f.Push(f.Locals[5]);f.Pc=113;continue;}
case 113:{f.Push(JValue.R(null));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int!=0?123:120;continue;}
case 120:{f.Pc=22;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",127);}
case 127:{f.Push(f.Locals[7]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/player/PlayerController","playSaFromPlayEffect","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",132);}
case 132:{f.Pc=f.Pop().Int==0?142:135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[5]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",141);}
case 141:{f.StackOp("pop");f.Pc=142;continue;}
case 142:{f.Pc=22;continue;}
case 145:{f.Push(f.Locals[2]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",149);}
case 149:{return rt.Call(f,"forge/game/player/PlayerController","endTempShowCards","()V","invokevirtual",152);}
case 152:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3112(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/PlayerController","isAI","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?113:10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("ShareLandType")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?113:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("DifferentNames")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?113:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("DifferentPower")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int!=0?113:40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("DifferentCMC")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int!=0?113:50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("AtRandom")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int!=0?113:60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Defined")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?79:69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("ChooseFromDefined")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int==0?113:79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("WithTotalCMC")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int!=0?113:89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("WithTotalPower")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int!=0?113:99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String("WithTotalCardTypes")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int!=0?113:109;continue;}
case 109:{f.Push(JValue.I(1));f.Pc=110;continue;}
case 110:{f.Pc=114;continue;}
case 113:{f.Push(JValue.I(0));f.Pc=114;continue;}
case 114:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3113(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[9]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[6]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",11);}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/zone/MagicStack","remove","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference==null?400:20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",23);}
case 23:{f.Locals[10]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[10]);f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","StackSa","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","StackSa","Lforge/game/ability/AbilityKey;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[10]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[7]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",44);}
case 44:{f.Push(JValue.R(null));f.Pc=45;continue;}
case 45:{f.Locals[11]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("RememberChanged")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",54);}
case 54:{f.Locals[12]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("Imprint")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",63);}
case 63:{f.Locals[13]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?75:72;continue;}
case 72:{f.Pc=253;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=80;continue;}
case 80:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?101:83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",88);}
case 88:{f.Push(f.Locals[9]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[10]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/GameAction","moveToGraveyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",96);}
case 96:{f.Locals[11]=f.Pop();f.Pc=98;continue;}
case 98:{f.Pc=253;continue;}
case 101:{f.Push(f.Locals[4]);f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=106;continue;}
case 106:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?144:109;continue;}
case 109:{f.Push(f.Locals[9]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[2]);f.Pc=112;continue;}
case 112:{f.Push(JValue.I(1));f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/card/Card","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",116);}
case 116:{f.Pc=f.Pop().Int!=0?120:119;continue;}
case 119:{return JStep.ReturnVoid;}
case 120:{f.Push(f.Locals[6]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",125);}
case 125:{f.Push(f.Locals[9]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[2]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[10]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",133);}
case 133:{f.Locals[11]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[11]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",141);}
case 141:{f.Pc=253;continue;}
case 144:{f.Push(f.Locals[4]);f.Pc=146;continue;}
case 146:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=149;continue;}
case 149:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?170:152;continue;}
case 152:{f.Push(f.Locals[6]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",157);}
case 157:{f.Push(f.Locals[9]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[2]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[10]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/GameAction","moveToHand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",165);}
case 165:{f.Locals[11]=f.Pop();f.Pc=167;continue;}
case 167:{f.Pc=253;continue;}
case 170:{f.Push(f.Locals[4]);f.Pc=172;continue;}
case 172:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=175;continue;}
case 175:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?233:178;continue;}
case 178:{f.Push(f.Locals[6]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",183);}
case 183:{f.Push(f.Locals[9]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[5]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[2]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[10]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",193);}
case 193:{f.Locals[11]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{f.Push(JValue.R(rt.String("Shuffle")));f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",202);}
case 202:{f.Pc=f.Pop().Int==0?253:205;continue;}
case 205:{f.Push(JValue.R(rt.String("True")));f.Pc=208;continue;}
case 208:{f.Push(f.Locals[2]);f.Pc=209;continue;}
case 209:{f.Push(JValue.R(rt.String("Shuffle")));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",215);}
case 215:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",218);}
case 218:{f.Pc=f.Pop().Int==0?253:221;continue;}
case 221:{f.Push(f.Locals[9]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",226);}
case 226:{f.Push(f.Locals[2]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/player/Player","shuffle","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",230);}
case 230:{f.Pc=253;continue;}
case 233:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=236;continue;}
case 236:{f.StackOp("dup");f.Pc=237;continue;}
case 237:{f.Push(f.Locals[2]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",241);}
case 241:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",244);}
case 244:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3113:244:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",249);}
case 249:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",252);}
case 252:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 253:{f.Push(f.Locals[2]);f.Pc=254;continue;}
case 254:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",260);}
case 260:{f.Pc=f.Pop().Int==0?348:263;continue;}
case 263:{f.Push(f.Locals[2]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",267);}
case 267:{f.Locals[14]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[2]);f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("WithCountersPlacer")));f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",276);}
case 276:{f.Pc=f.Pop().Int==0?303:279;continue;}
case 279:{f.Push(f.Locals[2]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",283);}
case 283:{f.Push(f.Locals[2]);f.Pc=284;continue;}
case 284:{f.Push(JValue.R(rt.String("WithCountersPlacer")));f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",290);}
case 290:{f.Push(f.Locals[2]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",294);}
case 294:{f.Push(JValue.I(0));f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",298);}
case 298:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=301;continue;}
case 301:{f.Locals[14]=f.Pop();f.Pc=303;continue;}
case 303:{f.Push(f.Locals[2]);f.Pc=304;continue;}
case 304:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",310);}
case 310:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",313);}
case 313:{f.Locals[15]=f.Pop();f.Pc=315;continue;}
case 315:{f.Push(f.Locals[2]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",319);}
case 319:{f.Push(f.Locals[2]);f.Pc=320;continue;}
case 320:{f.Push(JValue.R(rt.String("WithCountersAmount")));f.Pc=323;continue;}
case 323:{f.Push(JValue.R(rt.String("1")));f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",329);}
case 329:{f.Push(f.Locals[2]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",333);}
case 333:{f.Locals[16]=f.Pop();f.Pc=335;continue;}
case 335:{f.Push(f.Locals[11]);f.Pc=337;continue;}
case 337:{f.Push(f.Locals[15]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[16]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[14]);f.Pc=343;continue;}
case 343:{f.Push(f.Locals[8]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",348);}
case 348:{f.Push(f.Locals[12]);f.Pc=350;continue;}
case 350:{f.Pc=f.Pop().Int==0?362:353;continue;}
case 353:{f.Push(f.Locals[2]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",357);}
case 357:{f.Push(f.Locals[9]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",362);}
case 362:{f.Push(f.Locals[13]);f.Pc=364;continue;}
case 364:{f.Pc=f.Pop().Int==0?376:367;continue;}
case 367:{f.Push(f.Locals[2]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",371);}
case 371:{f.Push(f.Locals[9]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",376);}
case 376:{f.Push(f.Locals[1]);f.Pc=377;continue;}
case 377:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",380);}
case 380:{f.Pc=f.Pop().Int!=0?400:383;continue;}
case 383:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=386;continue;}
case 386:{f.Push(f.Locals[2]);f.Pc=387;continue;}
case 387:{f.Push(JValue.R(rt.String("Destination")));f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",392);}
case 392:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3113:392:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",397);}
case 397:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",400);}
case 400:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3114(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Locals[7]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{f.Locals[8]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("DestAltSVar")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?103:16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{f.Locals[7]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("DestAltSVar")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Locals[9]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[9]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("MANDATORY ")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?54:39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{f.Locals[8]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[9]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("MANDATORY ")));f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Locals[9]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("DestAltSVarCompare")));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("GE1")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",64);}
case 64:{f.Locals[10]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[10]);f.Pc=68;continue;}
case 68:{f.Push(JValue.I(2));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",72);}
case 72:{f.Locals[11]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[9]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",81);}
case 81:{f.Locals[12]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[12]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[10]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[11]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",94);}
case 94:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",97);}
case 97:{f.Pc=f.Pop().Int==0?103:100;continue;}
case 100:{f.Push(JValue.I(1));f.Pc=101;continue;}
case 101:{f.Locals[7]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("DestinationAlternative")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",110);}
case 110:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",113);}
case 113:{f.Locals[9]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[9]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("LibraryPositionAlternative")));f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("0")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",127);}
case 127:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",130);}
case 130:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",133);}
case 133:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",136);}
case 136:{f.Locals[10]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[7]);f.Pc=140;continue;}
case 140:{f.Pc=f.Pop().Int==0?151:143;continue;}
case 143:{f.Push(f.Locals[8]);f.Pc=145;continue;}
case 145:{f.Pc=f.Pop().Int!=0?151:148;continue;}
case 148:{f.Push(f.Locals[10]);f.Pc=150;continue;}
case 150:{return JStep.Return(f.Pop());}
case 151:{f.Push(f.Locals[7]);f.Pc=153;continue;}
case 153:{f.Pc=f.Pop().Int==0?431:156;continue;}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",163);}
case 163:{f.Pc=f.Pop().Int==0?181:166;continue;}
case 166:{f.Push(f.Locals[9]);f.Pc=168;continue;}
case 168:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",174);}
case 174:{f.Pc=f.Pop().Int==0?181:177;continue;}
case 177:{f.Push(JValue.I(1));f.Pc=178;continue;}
case 178:{f.Pc=182;continue;}
case 181:{f.Push(JValue.I(0));f.Pc=182;continue;}
case 182:{f.Locals[11]=f.Pop();f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",187);}
case 187:{f.Push(f.Locals[11]);f.Pc=189;continue;}
case 189:{f.Pc=f.Pop().Int==0?198:192;continue;}
case 192:{f.Push(JValue.R(rt.String("lblChooseLibraryPosition")));f.Pc=195;continue;}
case 195:{f.Pc=201;continue;}
case 198:{f.Push(JValue.R(rt.String("lblChooseDestination")));f.Pc=201;continue;}
case 201:{f.Push(JValue.I(0));f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",208);}
case 208:{f.Locals[12]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[11]);f.Pc=212;continue;}
case 212:{f.Pc=f.Pop().Int==0?287:215;continue;}
case 215:{f.Push(JValue.I(2));f.Pc=216;continue;}
case 216:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=219;continue;}
case 219:{f.StackOp("dup");f.Pc=220;continue;}
case 220:{f.Push(JValue.I(0));f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",224);}
case 224:{f.Push(JValue.R(rt.String("lblTop")));f.Pc=227;continue;}
case 227:{f.Push(JValue.I(0));f.Pc=228;continue;}
case 228:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",234);}
case 234:{f.Push(f.Locals[4]);f.Pc=236;continue;}
case 236:{f.Pc=f.Pop().Int!=0?244:239;continue;}
case 239:{f.Push(JValue.R(rt.String("")));f.Pc=241;continue;}
case 241:{f.Pc=259;continue;}
case 244:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",247);}
case 247:{f.Push(f.Locals[4]);f.Pc=249;continue;}
case 249:{f.Push(JValue.I(1));f.Pc=250;continue;}
case 250:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/util/Lang","getOrdinal","(I)Ljava/lang/String;","invokevirtual",254);}
case 254:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3114:254:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",259);}
case 259:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3114:259:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",264);}
case 264:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=265;continue;}
case 265:{f.StackOp("dup");f.Pc=266;continue;}
case 266:{f.Push(JValue.I(1));f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",270);}
case 270:{f.Push(JValue.R(rt.String("lblBottom")));f.Pc=273;continue;}
case 273:{f.Push(JValue.I(0));f.Pc=274;continue;}
case 274:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",280);}
case 280:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",284);}
case 284:{f.Pc=315;continue;}
case 287:{f.Push(JValue.I(2));f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=291;continue;}
case 291:{f.StackOp("dup");f.Pc=292;continue;}
case 292:{f.Push(JValue.I(0));f.Pc=293;continue;}
case 293:{f.Push(f.Locals[3]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",297);}
case 297:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",300);}
case 300:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=301;continue;}
case 301:{f.StackOp("dup");f.Pc=302;continue;}
case 302:{f.Push(JValue.I(1));f.Pc=303;continue;}
case 303:{f.Push(f.Locals[9]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",308);}
case 308:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",311);}
case 311:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=312;continue;}
case 312:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",315);}
case 315:{f.Locals[13]=f.Pop();f.Pc=317;continue;}
case 317:{f.Push(f.Locals[5]);f.Pc=319;continue;}
case 319:{f.Locals[14]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[1]);f.Pc=322;continue;}
case 322:{f.Push(JValue.R(rt.String("AlternativeDecider")));f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",328);}
case 328:{f.Pc=f.Pop().Int==0?368:331;continue;}
case 331:{f.Push(f.Locals[2]);f.Pc=332;continue;}
case 332:{f.Push(f.Locals[1]);f.Pc=333;continue;}
case 333:{f.Push(JValue.R(rt.String("AlternativeDecider")));f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",339);}
case 339:{f.Push(f.Locals[1]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",343);}
case 343:{f.Locals[15]=f.Pop();f.Pc=345;continue;}
case 345:{f.Push(f.Locals[15]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/player/PlayerCollection","isEmpty","()Z","invokevirtual",350);}
case 350:{f.Pc=f.Pop().Int==0?357:353;continue;}
case 353:{f.Push(JValue.R(null));f.Pc=354;continue;}
case 354:{f.Pc=366;continue;}
case 357:{f.Push(f.Locals[15]);f.Pc=359;continue;}
case 359:{f.Push(JValue.I(0));f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",363);}
case 363:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=366;continue;}
case 366:{f.Locals[14]=f.Pop();f.Pc=368;continue;}
case 368:{f.Push(f.Locals[6]);f.Pc=370;continue;}
case 370:{f.Pc=f.Pop().Reference==null?398:373;continue;}
case 373:{f.Push(f.Locals[6]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",380);}
case 380:{f.Push(JValue.I(1));f.Pc=381;continue;}
case 381:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?398:384;continue;}
case 384:{f.Push(f.Locals[6]);f.Pc=386;continue;}
case 386:{f.Push(JValue.I(0));f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",392);}
case 392:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=395;continue;}
case 395:{f.Pc=399;continue;}
case 398:{f.Push(JValue.R(null));f.Pc=399;continue;}
case 399:{f.Locals[15]=f.Pop();f.Pc=401;continue;}
case 401:{f.Push(f.Locals[14]);f.Pc=403;continue;}
case 403:{f.Pc=f.Pop().Reference==null?431:406;continue;}
case 406:{f.Push(f.Locals[14]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",411);}
case 411:{f.Push(f.Locals[1]);f.Pc=412;continue;}
case 412:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","ChangeZoneToAltDestination","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","ChangeZoneToAltDestination","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=415;continue;}
case 415:{f.Push(f.Locals[12]);f.Pc=417;continue;}
case 417:{f.Push(f.Locals[13]);f.Pc=419;continue;}
case 419:{f.Push(f.Locals[15]);f.Pc=421;continue;}
case 421:{f.Push(JValue.R(null));f.Pc=422;continue;}
case 422:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/List;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",425);}
case 425:{f.Pc=f.Pop().Int!=0?431:428;continue;}
case 428:{f.Push(f.Locals[10]);f.Pc=430;continue;}
case 430:{return JStep.Return(f.Pop());}
case 431:{f.Push(f.Locals[3]);f.Pc=432;continue;}
case 432:{f.Push(f.Locals[4]);f.Pc=434;continue;}
case 434:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",437);}
case 437:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",440);}
case 440:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3115(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",11);}
case 11:{switch(f.Pop().Int){case -614085532:f.Pc=28;break;default:f.Pc=40;break;}continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("lambda$changeKnownOriginResolve$f894d637$1")));f.Pc=32;continue;}
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
case 112:{f.Push(JValue.R(rt.String("forge/game/ability/effects/ChangeZoneEffect")));f.Pc=115;continue;}
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
case 150:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneEffect:3115:150:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",155);}
case 155:{return JStep.Return(f.Pop());}
case 156:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=159;continue;}
case 159:{f.StackOp("dup");f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("Invalid lambda deserialization")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",166);}
case 166:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3116(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3117(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?28:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference==null?24:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int!=0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3118(JRuntime rt,JFrame f)
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

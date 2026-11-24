// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C303{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/EndureEffect","forge/game/ability/effects/TokenEffectBase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3391,"forge/game/ability/effects/EndureEffect","<init>","()V",1,1,1,new JHandler[]{},M3391));
c.Add(new JMethod(3392,"forge/game/ability/effects/EndureEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,4,new JHandler[]{},M3392));
c.Add(new JMethod(3393,"forge/game/ability/effects/EndureEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,14,9,new JHandler[]{},M3393));
}

internal static JStep M3391(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3392(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/ability/effects/EndureEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",25);}
case 25:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String(" ")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",44);}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?53:48;continue;}
case 48:{f.Push(JValue.R(rt.String("endure")));f.Pc=50;continue;}
case 50:{f.Pc=55;continue;}
case 53:{f.Push(JValue.R(rt.String("endures")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",58);}
case 58:{f.StackOp("pop");f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Num")));f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("1")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",68);}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",72);}
case 72:{f.Locals[5]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String(" ")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",80);}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String(". ")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",92);}
case 92:{f.StackOp("pop");f.Pc=93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",97);}
case 97:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3393(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Num")));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("1")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",27);}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[5]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?36:35;continue;}
case 35:{return JStep.ReturnVoid;}
case 36:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=39;continue;}
case 39:{f.StackOp("dup");f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",43);}
case 43:{f.Locals[6]=f.Pop();f.Pc=45;continue;}
case 45:{if(!rt.EnsureInitialized(f,"forge/game/card/TokenCreateTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/TokenCreateTable")));f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/TokenCreateTable","<init>","()V","invokespecial",52);}
case 52:{f.Locals[7]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/ability/effects/EndureEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",59);}
case 59:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",66);}
case 66:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",71);}
case 71:{f.Locals[8]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[8]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",80);}
case 80:{f.Pc=f.Pop().Int==0?301:83;continue;}
case 83:{f.Push(f.Locals[8]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{f.Locals[9]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[9]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",100);}
case 100:{f.Locals[10]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[9]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(null));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",109);}
case 109:{f.Locals[11]=f.Pop();f.Pc=111;continue;}
case 111:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",114);}
case 114:{f.Locals[12]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[12]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("RevealedCard")));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[9]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",127);}
case 127:{f.StackOp("pop");f.Pc=128;continue;}
case 128:{f.Push(f.Locals[12]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("Amount")));f.Pc=132;continue;}
case 132:{f.Push(f.Locals[5]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",137);}
case 137:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",142);}
case 142:{f.StackOp("pop");f.Pc=143;continue;}
case 143:{f.Push(f.Locals[11]);f.Pc=145;continue;}
case 145:{f.Pc=f.Pop().Reference==null?239:148;continue;}
case 148:{f.Push(f.Locals[11]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int==0?239:156;continue;}
case 156:{f.Push(f.Locals[11]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[9]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",163);}
case 163:{f.Pc=f.Pop().Int==0?239:166;continue;}
case 166:{f.Push(f.Locals[11]);f.Pc=168;continue;}
case 168:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"));f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/card/Card","canReceiveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",174);}
case 174:{f.Pc=f.Pop().Int==0?239:177;continue;}
case 177:{f.Push(f.Locals[10]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",182);}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Push(JValue.R(null));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",187);}
case 187:{f.Push(JValue.R(rt.String("lblEndureAction")));f.Pc=189;continue;}
case 189:{f.Push(JValue.I(2));f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=193;continue;}
case 193:{f.StackOp("dup");f.Pc=194;continue;}
case 194:{f.Push(JValue.I(0));f.Pc=195;continue;}
case 195:{f.Push(f.Locals[9]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",200);}
case 200:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=201;continue;}
case 201:{f.StackOp("dup");f.Pc=202;continue;}
case 202:{f.Push(JValue.I(1));f.Pc=203;continue;}
case 203:{f.Push(f.Locals[5]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",208);}
case 208:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",212);}
case 212:{f.Push(f.Locals[11]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[12]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int==0?239:222;continue;}
case 222:{f.Push(f.Locals[11]);f.Pc=224;continue;}
case 224:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"));f.Pc=227;continue;}
case 227:{f.Push(f.Locals[5]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[10]);f.Pc=231;continue;}
case 231:{f.Push(f.Locals[6]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",236);}
case 236:{f.Pc=298;continue;}
case 239:{f.Push(JValue.R(rt.String("w_x_x_spirit")));f.Pc=241;continue;}
case 241:{f.Push(f.Locals[1]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[10]);f.Pc=244;continue;}
case 244:{f.Push(JValue.I(0));f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/card/token/TokenInfo","getProtoType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Lforge/game/card/Card;","invokestatic",248);}
case 248:{f.Locals[13]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(f.Locals[13]);f.Pc=252;continue;}
case 252:{f.Push(f.Locals[4]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/card/Card","setBasePowerString","(Ljava/lang/String;)V","invokevirtual",257);}
case 257:{f.Push(f.Locals[13]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[5]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/card/Card","setBasePower","(I)V","invokevirtual",264);}
case 264:{f.Push(f.Locals[13]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[4]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/card/Card","setBaseToughnessString","(Ljava/lang/String;)V","invokevirtual",271);}
case 271:{f.Push(f.Locals[13]);f.Pc=273;continue;}
case 273:{f.Push(f.Locals[5]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/card/Card","setBaseToughness","(I)V","invokevirtual",278);}
case 278:{f.Push(f.Locals[13]);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[1]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/card/Card","setTokenSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",284);}
case 284:{f.Push(f.Locals[7]);f.Pc=286;continue;}
case 286:{f.Push(f.Locals[10]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[13]);f.Pc=290;continue;}
case 290:{f.Push(JValue.I(1));f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",294);}
case 294:{return rt.Call(f,"forge/game/card/TokenCreateTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",297);}
case 297:{f.StackOp("pop");f.Pc=298;continue;}
case 298:{f.Pc=73;continue;}
case 301:{f.Push(f.Locals[6]);f.Pc=303;continue;}
case 303:{f.Push(f.Locals[3]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",308);}
case 308:{f.Push(f.Locals[7]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/card/TokenCreateTable","isEmpty","()Z","invokevirtual",313);}
case 313:{f.Pc=f.Pop().Int!=0?389:316;continue;}
case 316:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=319;continue;}
case 319:{f.StackOp("dup");f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",323);}
case 323:{f.Locals[8]=f.Pop();f.Pc=325;continue;}
case 325:{if(!rt.EnsureInitialized(f,"org/apache/commons/lang3/mutable/MutableBoolean"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("org/apache/commons/lang3/mutable/MutableBoolean")));f.Pc=328;continue;}
case 328:{f.StackOp("dup");f.Pc=329;continue;}
case 329:{f.Push(JValue.I(0));f.Pc=330;continue;}
case 330:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","<init>","(Z)V","invokespecial",333);}
case 333:{f.Locals[9]=f.Pop();f.Pc=335;continue;}
case 335:{f.Push(f.Locals[0]);f.Pc=336;continue;}
case 336:{f.Push(f.Locals[7]);f.Pc=338;continue;}
case 338:{f.Push(JValue.I(0));f.Pc=339;continue;}
case 339:{f.Push(f.Locals[8]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[9]);f.Pc=343;continue;}
case 343:{f.Push(f.Locals[1]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/ability/effects/EndureEffect","makeTokenTable","(Lforge/game/card/TokenCreateTable;ZLforge/game/card/CardZoneTable;Lorg/apache/commons/lang3/mutable/MutableBoolean;Lforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;","invokevirtual",347);}
case 347:{f.StackOp("pop");f.Pc=348;continue;}
case 348:{f.Push(f.Locals[8]);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[3]);f.Pc=351;continue;}
case 351:{f.Push(f.Locals[1]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",355);}
case 355:{f.Push(f.Locals[3]);f.Pc=356;continue;}
case 356:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventTokenCreated"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventTokenCreated")));f.Pc=359;continue;}
case 359:{f.StackOp("dup");f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/event/GameEventTokenCreated","<init>","()V","invokespecial",363);}
case 363:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",366);}
case 366:{f.Push(f.Locals[9]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","isTrue","()Z","invokevirtual",371);}
case 371:{f.Pc=f.Pop().Int==0?389:374;continue;}
case 374:{f.Push(f.Locals[3]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/Game","updateCombatForView","()V","invokevirtual",378);}
case 378:{f.Push(f.Locals[3]);f.Pc=379;continue;}
case 379:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCombatChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCombatChanged")));f.Pc=382;continue;}
case 382:{f.StackOp("dup");f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/game/event/GameEventCombatChanged","<init>","()V","invokespecial",386);}
case 386:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",389);}
case 389:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

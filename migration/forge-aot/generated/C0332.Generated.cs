// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C332{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ManifestBaseEffect","forge/game/ability/SpellAbilityEffect",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3494,"forge/game/ability/effects/ManifestBaseEffect","<init>","()V",1,1,1,new JHandler[]{},M3494));
c.Add(new JMethod(3495,"forge/game/ability/effects/ManifestBaseEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,2,new JHandler[]{},M3495));
c.Add(new JMethod(3496,"forge/game/ability/effects/ManifestBaseEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,6,4,new JHandler[]{},M3496));
c.Add(new JMethod(3497,"forge/game/ability/effects/ManifestBaseEffect","manifestLoop","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;I)V",4,14,10,new JHandler[]{},M3497));
c.Add(new JMethod(3498,"forge/game/ability/effects/ManifestBaseEffect","getDefaultMessage","()Ljava/lang/String;",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(3499,"forge/game/ability/effects/ManifestBaseEffect","internalEffect","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;",1028,0,0,new JHandler[]{},null));
}

internal static JStep M3494(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3495(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?18:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/ability/effects/ManifestBaseEffect","zoneParamIsLibrary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z","invokestatic",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3496(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Amount")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?28:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Amount")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",25);}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("DefinedPlayer")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/effects/ManifestBaseEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",36);}
case 36:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",48);}
case 48:{f.Pc=f.Pop().Int==0?74:51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Locals[5]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/ability/effects/ManifestBaseEffect","manifestLoop","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;I)V","invokevirtual",71);}
case 71:{f.Pc=41;continue;}
case 74:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3497(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",10);}
case 10:{f.Locals[5]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",17);}
case 17:{f.Locals[6]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Locals[8]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Choices")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?40:31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?178:40;continue;}
case 40:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=43;continue;}
case 43:{f.Locals[9]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?75:54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",63);}
case 63:{f.Locals[9]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[9]);f.Pc=67;continue;}
case 67:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",73);}
case 73:{f.Locals[8]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[9]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",81);}
case 81:{f.Locals[10]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("Choices")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?110:92;continue;}
case 92:{f.Push(f.Locals[10]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("Choices")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",100);}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[4]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",108);}
case 108:{f.Locals[10]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[10]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",117);}
case 117:{f.Pc=f.Pop().Int==0?121:120;continue;}
case 120:{return JStep.ReturnVoid;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int==0?139:130;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",136);}
case 136:{f.Pc=148;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/ability/effects/ManifestBaseEffect","getDefaultMessage","()Ljava/lang/String;","invokevirtual",143);}
case 143:{return rt.DynamicCall(f,"forge/game/ability/effects/ManifestBaseEffect:3497:143:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",148);}
case 148:{f.Locals[11]=f.Pop();f.Pc=150;continue;}
case 150:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=153;continue;}
case 153:{f.StackOp("dup");f.Pc=154;continue;}
case 154:{f.Push(f.Locals[2]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",158);}
case 158:{f.Push(f.Locals[10]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[11]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[3]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[3]);f.Pc=165;continue;}
case 165:{f.Push(JValue.I(0));f.Pc=166;continue;}
case 166:{f.Push(JValue.R(null));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",170);}
case 170:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",173);}
case 173:{f.Locals[7]=f.Pop();f.Pc=175;continue;}
case 175:{f.Pc=230;continue;}
case 178:{f.Push(JValue.R(rt.String("TopOfLibrary")));f.Pc=180;continue;}
case 180:{f.Push(f.Locals[1]);f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("Defined")));f.Pc=183;continue;}
case 183:{f.Push(JValue.R(rt.String("TopOfLibrary")));f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",188);}
case 188:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",191);}
case 191:{f.Pc=f.Pop().Int==0?207:194;continue;}
case 194:{f.Push(f.Locals[2]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[3]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/player/Player","getTopXCardsFromLibrary","(I)Lforge/game/card/CardCollection;","invokevirtual",199);}
case 199:{f.Locals[7]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(JValue.I(1));f.Pc=202;continue;}
case 202:{f.Locals[8]=f.Pop();f.Pc=204;continue;}
case 204:{f.Pc=230;continue;}
case 207:{f.Push(f.Locals[1]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/ability/effects/ManifestBaseEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",211);}
case 211:{f.Locals[7]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[7]);f.Pc=215;continue;}
case 215:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/card/CardPredicates","inZone","(Lforge/game/zone/ZoneType;)Ljava/util/function/Predicate;","invokestatic",221);}
case 221:{return rt.Call(f,"forge/game/card/CardCollection","allMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",224);}
case 224:{f.Pc=f.Pop().Int==0?230:227;continue;}
case 227:{f.Push(JValue.I(1));f.Pc=228;continue;}
case 228:{f.Locals[8]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[1]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String("Shuffle")));f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",236);}
case 236:{f.Pc=f.Pop().Int==0?244:239;continue;}
case 239:{f.Push(f.Locals[7]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/card/CardLists","shuffle","(Ljava/util/List;)V","invokestatic",244);}
case 244:{f.Push(f.Locals[8]);f.Pc=246;continue;}
case 246:{f.Pc=f.Pop().Int==0?344:249;continue;}
case 249:{f.Push(f.Locals[7]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",254);}
case 254:{f.Locals[9]=f.Pop();f.Pc=256;continue;}
case 256:{f.Push(f.Locals[9]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",263);}
case 263:{f.Pc=f.Pop().Int==0?341:266;continue;}
case 266:{f.Push(f.Locals[9]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",273);}
case 273:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=276;continue;}
case 276:{f.Locals[10]=f.Pop();f.Pc=278;continue;}
case 278:{f.Push(f.Locals[6]);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[10]);f.Pc=282;continue;}
case 282:{f.Push(JValue.R(null));f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",286);}
case 286:{f.Locals[11]=f.Pop();f.Pc=288;continue;}
case 288:{f.Push(f.Locals[11]);f.Pc=290;continue;}
case 290:{f.Pc=f.Pop().Reference==null?256:293;continue;}
case 293:{f.Push(f.Locals[10]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[11]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",300);}
case 300:{f.Pc=f.Pop().Int!=0?306:303;continue;}
case 303:{f.Pc=256;continue;}
case 306:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",309);}
case 309:{f.Locals[12]=f.Pop();f.Pc=311;continue;}
case 311:{f.Push(f.Locals[12]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[1]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",317);}
case 317:{f.Locals[13]=f.Pop();f.Pc=319;continue;}
case 319:{f.Push(f.Locals[0]);f.Pc=320;continue;}
case 320:{f.Push(f.Locals[11]);f.Pc=322;continue;}
case 322:{f.Push(f.Locals[2]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[1]);f.Pc=324;continue;}
case 324:{f.Push(f.Locals[12]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/ability/effects/ManifestBaseEffect","internalEffect","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",329);}
case 329:{f.StackOp("pop");f.Pc=330;continue;}
case 330:{f.Push(f.Locals[13]);f.Pc=332;continue;}
case 332:{f.Push(f.Locals[6]);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[1]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",338);}
case 338:{f.Pc=256;continue;}
case 341:{f.Pc=436;continue;}
case 344:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",347);}
case 347:{f.Locals[9]=f.Pop();f.Pc=349;continue;}
case 349:{f.Push(f.Locals[9]);f.Pc=351;continue;}
case 351:{f.Push(f.Locals[1]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",355);}
case 355:{f.Locals[10]=f.Pop();f.Pc=357;continue;}
case 357:{f.Push(f.Locals[7]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",362);}
case 362:{f.Locals[11]=f.Pop();f.Pc=364;continue;}
case 364:{f.Push(f.Locals[11]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",371);}
case 371:{f.Pc=f.Pop().Int==0?428:374;continue;}
case 374:{f.Push(f.Locals[11]);f.Pc=376;continue;}
case 376:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",381);}
case 381:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=384;continue;}
case 384:{f.Locals[12]=f.Pop();f.Pc=386;continue;}
case 386:{f.Push(f.Locals[6]);f.Pc=388;continue;}
case 388:{f.Push(f.Locals[12]);f.Pc=390;continue;}
case 390:{f.Push(JValue.R(null));f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",394);}
case 394:{f.Locals[13]=f.Pop();f.Pc=396;continue;}
case 396:{f.Push(f.Locals[13]);f.Pc=398;continue;}
case 398:{f.Pc=f.Pop().Reference==null?364:401;continue;}
case 401:{f.Push(f.Locals[12]);f.Pc=403;continue;}
case 403:{f.Push(f.Locals[13]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",408);}
case 408:{f.Pc=f.Pop().Int!=0?414:411;continue;}
case 411:{f.Pc=364;continue;}
case 414:{f.Push(f.Locals[0]);f.Pc=415;continue;}
case 415:{f.Push(f.Locals[13]);f.Pc=417;continue;}
case 417:{f.Push(f.Locals[2]);f.Pc=418;continue;}
case 418:{f.Push(f.Locals[1]);f.Pc=419;continue;}
case 419:{f.Push(f.Locals[9]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/game/ability/effects/ManifestBaseEffect","internalEffect","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",424);}
case 424:{f.StackOp("pop");f.Pc=425;continue;}
case 425:{f.Pc=364;continue;}
case 428:{f.Push(f.Locals[10]);f.Pc=430;continue;}
case 430:{f.Push(f.Locals[6]);f.Pc=432;continue;}
case 432:{f.Push(f.Locals[1]);f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",436);}
case 436:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

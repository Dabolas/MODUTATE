// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C292{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DiscoverEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3351,"forge/game/ability/effects/DiscoverEffect","<init>","()V",1,1,1,new JHandler[]{},M3351));
c.Add(new JMethod(3352,"forge/game/ability/effects/DiscoverEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M3352));
c.Add(new JMethod(3353,"forge/game/ability/effects/DiscoverEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,6,new JHandler[]{},M3353));
c.Add(new JMethod(3354,"forge/game/ability/effects/DiscoverEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,24,7,new JHandler[]{},M3354));
c.Add(new JMethod(3355,"forge/game/ability/effects/DiscoverEffect","changeZone","(Lforge/game/card/CardCollection;Lforge/game/zone/ZoneType;Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V",2,13,6,new JHandler[]{},M3355));
c.Add(new JMethod(3356,"forge/game/ability/effects/DiscoverEffect","lambda$resolve$0","(ILforge/game/spellability/SpellAbility;)Z",4106,2,2,new JHandler[]{},M3356));
}

internal static JStep M3351(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3352(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3353(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/DiscoverEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",9);}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?18:13;continue;}
case 13:{f.Push(JValue.R(rt.String(" discovers ")));f.Pc=15;continue;}
case 15:{f.Pc=20;continue;}
case 18:{f.Push(JValue.R(rt.String(" discover ")));f.Pc=20;continue;}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",25);}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",30);}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("Num")));f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("1")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",42);}
case 42:{return rt.DynamicCall(f,"forge/game/ability/effects/DiscoverEffect:3353:42:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;",47);}
case 47:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3354(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/ability/effects/DiscoverEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Num")));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("1")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",29);}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",36);}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[6]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",45);}
case 45:{f.Pc=f.Pop().Int==0?731:48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",55);}
case 55:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=58;continue;}
case 58:{f.Locals[7]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[7]);f.Pc=62;continue;}
case 62:{f.Pc=f.Pop().Reference==null?73:65;continue;}
case 65:{f.Push(f.Locals[7]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int!=0?74:73;continue;}
case 73:{return JStep.ReturnVoid;}
case 74:{f.Push(JValue.R(null));f.Pc=75;continue;}
case 75:{f.Locals[8]=f.Pop();f.Pc=77;continue;}
case 77:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",84);}
case 84:{f.Locals[9]=f.Pop();f.Pc=86;continue;}
case 86:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=89;continue;}
case 89:{f.StackOp("dup");f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",93);}
case 93:{f.Locals[10]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",103);}
case 103:{f.Locals[11]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[11]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/zone/PlayerZone","iterator","()Ljava/util/Iterator;","invokevirtual",110);}
case 110:{f.Locals[12]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[12]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",119);}
case 119:{f.Pc=f.Pop().Int==0?193:122;continue;}
case 122:{f.Push(f.Locals[12]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",129);}
case 129:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=132;continue;}
case 132:{f.Locals[13]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[9]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[13]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",141);}
case 141:{f.StackOp("pop");f.Pc=142;continue;}
case 142:{f.Push(f.Locals[13]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int!=0?182:150;continue;}
case 150:{f.Push(f.Locals[13]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",155);}
case 155:{f.Push(f.Locals[5]);f.Pc=157;continue;}
case 157:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?182:160;continue;}
case 160:{f.Push(f.Locals[13]);f.Pc=162;continue;}
case 162:{f.Locals[8]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("RememberDiscovered")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",170);}
case 170:{f.Pc=f.Pop().Int==0?193:173;continue;}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[13]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",179);}
case 179:{f.Pc=193;continue;}
case 182:{f.Push(f.Locals[10]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[13]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",189);}
case 189:{f.StackOp("pop");f.Pc=190;continue;}
case 190:{f.Pc=112;continue;}
case 193:{f.Push(f.Locals[3]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",197);}
case 197:{f.Push(f.Locals[9]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[7]);f.Pc=201;continue;}
case 201:{f.Push(JValue.I(0));f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;Z)V","invokevirtual",205);}
case 205:{f.Push(f.Locals[0]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[9]);f.Pc=208;continue;}
case 208:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=211;continue;}
case 211:{f.Push(f.Locals[3]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[1]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/ability/effects/DiscoverEffect","changeZone","(Lforge/game/card/CardCollection;Lforge/game/zone/ZoneType;Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",216);}
case 216:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=219;continue;}
case 219:{f.StackOp("dup");f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",223);}
case 223:{f.Locals[12]=f.Pop();f.Pc=225;continue;}
case 225:{f.Push(f.Locals[12]);f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String("Card")));f.Pc=229;continue;}
case 229:{f.Push(f.Locals[8]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",236);}
case 236:{f.StackOp("pop");f.Pc=237;continue;}
case 237:{f.Push(f.Locals[8]);f.Pc=239;continue;}
case 239:{f.Pc=f.Pop().Reference==null?681:242;continue;}
case 242:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",245);}
case 245:{f.Push(JValue.R(rt.String("lblDiscoverChoice")));f.Pc=247;continue;}
case 247:{f.Push(JValue.I(1));f.Pc=248;continue;}
case 248:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=251;continue;}
case 251:{f.StackOp("dup");f.Pc=252;continue;}
case 252:{f.Push(JValue.I(0));f.Pc=253;continue;}
case 253:{f.Push(f.Locals[8]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",258);}
case 258:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",262);}
case 262:{f.Locals[13]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(f.Locals[8]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",269);}
case 269:{f.Locals[14]=f.Pop();f.Pc=271;continue;}
case 271:{f.Push(JValue.I(2));f.Pc=272;continue;}
case 272:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=275;continue;}
case 275:{f.StackOp("dup");f.Pc=276;continue;}
case 276:{f.Push(JValue.I(0));f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",280);}
case 280:{f.Push(JValue.R(rt.String("lblCast")));f.Pc=282;continue;}
case 282:{f.Push(JValue.I(0));f.Pc=283;continue;}
case 283:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",289);}
case 289:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",292);}
case 292:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=293;continue;}
case 293:{f.StackOp("dup");f.Pc=294;continue;}
case 294:{f.Push(JValue.I(1));f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",298);}
case 298:{f.Push(JValue.R(rt.String("lblHandZone")));f.Pc=300;continue;}
case 300:{f.Push(JValue.I(0));f.Pc=301;continue;}
case 301:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",307);}
case 307:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",310);}
case 310:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=311;continue;}
case 311:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",314);}
case 314:{f.Locals[15]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[7]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",321);}
case 321:{f.Push(f.Locals[1]);f.Pc=322;continue;}
case 322:{f.Push(JValue.R(null));f.Pc=323;continue;}
case 323:{f.Push(f.Locals[13]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[15]);f.Pc=327;continue;}
case 327:{f.Push(f.Locals[8]);f.Pc=329;continue;}
case 329:{f.Push(f.Locals[12]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/List;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",334);}
case 334:{f.Locals[16]=f.Pop();f.Pc=336;continue;}
case 336:{f.Push(JValue.I(0));f.Pc=337;continue;}
case 337:{f.Locals[17]=f.Pop();f.Pc=339;continue;}
case 339:{f.Push(f.Locals[16]);f.Pc=341;continue;}
case 341:{f.Pc=f.Pop().Int==0?653:344;continue;}
case 344:{f.Push(f.Locals[8]);f.Pc=346;continue;}
case 346:{f.Push(f.Locals[7]);f.Pc=348;continue;}
case 348:{return rt.Call(f,"forge/game/ability/AbilityUtils","getBasicSpellsFromPlayEffect","(Lforge/game/card/Card;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",351);}
case 351:{f.Locals[18]=f.Pop();f.Pc=353;continue;}
case 353:{f.Push(f.Locals[18]);f.Pc=355;continue;}
case 355:{return rt.DynamicCall(f,"forge/game/ability/effects/DiscoverEffect:3354:355:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",360);}
case 360:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",365);}
case 365:{f.StackOp("pop");f.Pc=366;continue;}
case 366:{f.Push(f.Locals[18]);f.Pc=368;continue;}
case 368:{f.Push(f.Locals[5]);f.Pc=370;continue;}
case 370:{return rt.DynamicCall(f,"forge/game/ability/effects/DiscoverEffect:3354:370:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",375);}
case 375:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",380);}
case 380:{f.StackOp("pop");f.Pc=381;continue;}
case 381:{f.Push(f.Locals[18]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",388);}
case 388:{f.Pc=f.Pop().Int==0?414:391;continue;}
case 391:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=394;continue;}
case 394:{f.Push(f.Locals[2]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",398);}
case 398:{f.Push(f.Locals[8]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",403);}
case 403:{return rt.DynamicCall(f,"forge/game/ability/effects/DiscoverEffect:3354:403:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",408);}
case 408:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",411);}
case 411:{f.Pc=653;continue;}
case 414:{f.Push(f.Locals[7]);f.Pc=416;continue;}
case 416:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",419);}
case 419:{f.Push(f.Locals[8]);f.Pc=421;continue;}
case 421:{f.Push(f.Locals[18]);f.Pc=423;continue;}
case 423:{return rt.Call(f,"forge/game/player/PlayerController","getAbilityToPlay","(Lforge/game/card/Card;Ljava/util/List;)Lforge/game/spellability/SpellAbility;","invokevirtual",426);}
case 426:{f.Locals[19]=f.Pop();f.Pc=428;continue;}
case 428:{f.Push(f.Locals[19]);f.Pc=430;continue;}
case 430:{f.Pc=f.Pop().Reference!=null?439:433;continue;}
case 433:{f.Push(JValue.I(1));f.Pc=434;continue;}
case 434:{f.Locals[17]=f.Pop();f.Pc=436;continue;}
case 436:{f.Pc=653;continue;}
case 439:{f.Push(f.Locals[19]);f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithNoManaCost","()Lforge/game/spellability/SpellAbility;","invokevirtual",444);}
case 444:{f.Locals[19]=f.Pop();f.Pc=446;continue;}
case 446:{f.Push(JValue.I(0));f.Pc=447;continue;}
case 447:{f.Locals[20]=f.Pop();f.Pc=449;continue;}
case 449:{f.Push(f.Locals[19]);f.Pc=451;continue;}
case 451:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",454);}
case 454:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",457);}
case 457:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",462);}
case 462:{f.Locals[21]=f.Pop();f.Pc=464;continue;}
case 464:{f.Push(f.Locals[21]);f.Pc=466;continue;}
case 466:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",471);}
case 471:{f.Pc=f.Pop().Int==0?538:474;continue;}
case 474:{f.Push(f.Locals[21]);f.Pc=476;continue;}
case 476:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",481);}
case 481:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=484;continue;}
case 484:{f.Locals[22]=f.Pop();f.Pc=486;continue;}
case 486:{f.Push(f.Locals[22]);f.Pc=488;continue;}
case 488:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostDiscard")?1:0));f.Pc=491;continue;}
case 491:{f.Pc=f.Pop().Int!=0?502:494;continue;}
case 494:{f.Push(f.Locals[22]);f.Pc=496;continue;}
case 496:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostReveal")?1:0));f.Pc=499;continue;}
case 499:{f.Pc=f.Pop().Int==0?535:502;continue;}
case 502:{f.Push(f.Locals[22]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",507);}
case 507:{f.Push(JValue.R(rt.String("Card")));f.Pc=509;continue;}
case 509:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",512);}
case 512:{f.Pc=f.Pop().Int!=0?535:515;continue;}
case 515:{f.Push(f.Locals[22]);f.Pc=517;continue;}
case 517:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",520);}
case 520:{f.Push(JValue.R(rt.String("Random")));f.Pc=523;continue;}
case 523:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",526);}
case 526:{f.Pc=f.Pop().Int!=0?535:529;continue;}
case 529:{f.Push(JValue.I(1));f.Pc=530;continue;}
case 530:{f.Locals[20]=f.Pop();f.Pc=532;continue;}
case 532:{f.Pc=538;continue;}
case 535:{f.Pc=464;continue;}
case 538:{f.Push(f.Locals[20]);f.Pc=540;continue;}
case 540:{f.Pc=f.Pop().Int!=0?552:543;continue;}
case 543:{f.Push(f.Locals[19]);f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",548);}
case 548:{f.Push(JValue.I(1));f.Pc=549;continue;}
case 549:{return rt.Call(f,"forge/game/cost/Cost","setMandatory","(Z)V","invokevirtual",552);}
case 552:{f.Push(f.Locals[19]);f.Pc=554;continue;}
case 554:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",557);}
case 557:{f.Pc=f.Pop().Int==0?574:560;continue;}
case 560:{f.Push(f.Locals[20]);f.Pc=562;continue;}
case 562:{f.Pc=f.Pop().Int!=0?574:565;continue;}
case 565:{f.Push(f.Locals[19]);f.Pc=567;continue;}
case 567:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",570);}
case 570:{f.Push(JValue.I(1));f.Pc=571;continue;}
case 571:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setMandatory","(Z)V","invokevirtual",574);}
case 574:{f.Push(f.Locals[7]);f.Pc=576;continue;}
case 576:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",579);}
case 579:{f.Push(f.Locals[19]);f.Pc=581;continue;}
case 581:{return rt.Call(f,"forge/game/player/PlayerController","playSaFromPlayEffect","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",584);}
case 584:{f.Pc=f.Pop().Int==0?653:587;continue;}
case 587:{f.Push(f.Locals[19]);f.Pc=589;continue;}
case 589:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",592);}
case 592:{f.Locals[21]=f.Pop();f.Pc=594;continue;}
case 594:{f.Push(f.Locals[3]);f.Pc=595;continue;}
case 595:{f.Push(f.Locals[21]);f.Pc=597;continue;}
case 597:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",600);}
case 600:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",603);}
case 603:{f.Locals[22]=f.Pop();f.Pc=605;continue;}
case 605:{f.Push(f.Locals[14]);f.Pc=607;continue;}
case 607:{f.Push(f.Locals[22]);f.Pc=609;continue;}
case 609:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",612);}
case 612:{f.Pc=f.Pop().Int!=0?653:615;continue;}
case 615:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=618;continue;}
case 618:{f.StackOp("dup");f.Pc=619;continue;}
case 619:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",622);}
case 622:{f.Locals[23]=f.Pop();f.Pc=624;continue;}
case 624:{f.Push(f.Locals[23]);f.Pc=626;continue;}
case 626:{f.Push(f.Locals[14]);f.Pc=628;continue;}
case 628:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",631);}
case 631:{f.Push(f.Locals[22]);f.Pc=633;continue;}
case 633:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",636);}
case 636:{f.Push(f.Locals[3]);f.Pc=637;continue;}
case 637:{f.Push(f.Locals[8]);f.Pc=639;continue;}
case 639:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",642);}
case 642:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",645);}
case 645:{f.StackOp("pop");f.Pc=646;continue;}
case 646:{f.Push(f.Locals[23]);f.Pc=648;continue;}
case 648:{f.Push(f.Locals[3]);f.Pc=649;continue;}
case 649:{f.Push(f.Locals[1]);f.Pc=650;continue;}
case 650:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",653);}
case 653:{f.Push(f.Locals[16]);f.Pc=655;continue;}
case 655:{f.Pc=f.Pop().Int==0?663:658;continue;}
case 658:{f.Push(f.Locals[17]);f.Pc=660;continue;}
case 660:{f.Pc=f.Pop().Int==0?681:663;continue;}
case 663:{f.Push(f.Locals[0]);f.Pc=664;continue;}
case 664:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=667;continue;}
case 667:{f.StackOp("dup");f.Pc=668;continue;}
case 668:{f.Push(f.Locals[8]);f.Pc=670;continue;}
case 670:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",673);}
case 673:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=676;continue;}
case 676:{f.Push(f.Locals[3]);f.Pc=677;continue;}
case 677:{f.Push(f.Locals[1]);f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/game/ability/effects/DiscoverEffect","changeZone","(Lforge/game/card/CardCollection;Lforge/game/zone/ZoneType;Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",681);}
case 681:{f.Push(f.Locals[0]);f.Pc=682;continue;}
case 682:{f.Push(f.Locals[10]);f.Pc=684;continue;}
case 684:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=687;continue;}
case 687:{f.Push(f.Locals[3]);f.Pc=688;continue;}
case 688:{f.Push(f.Locals[1]);f.Pc=689;continue;}
case 689:{return rt.Call(f,"forge/game/ability/effects/DiscoverEffect","changeZone","(Lforge/game/card/CardCollection;Lforge/game/zone/ZoneType;Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",692);}
case 692:{f.Push(f.Locals[7]);f.Pc=694;continue;}
case 694:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",697);}
case 697:{f.Locals[13]=f.Pop();f.Pc=699;continue;}
case 699:{f.Push(f.Locals[13]);f.Pc=701;continue;}
case 701:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"));f.Pc=704;continue;}
case 704:{f.Push(f.Locals[5]);f.Pc=706;continue;}
case 706:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",709);}
case 709:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",714);}
case 714:{f.StackOp("pop");f.Pc=715;continue;}
case 715:{f.Push(f.Locals[3]);f.Pc=716;continue;}
case 716:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",719);}
case 719:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Discover","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Discover","Lforge/game/trigger/TriggerType;"));f.Pc=722;continue;}
case 722:{f.Push(f.Locals[13]);f.Pc=724;continue;}
case 724:{f.Push(JValue.I(0));f.Pc=725;continue;}
case 725:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",728);}
case 728:{f.Pc=38;continue;}
case 731:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3355(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",12);}
case 12:{f.Locals[6]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[6]);f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/Game","copyLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",23);}
case 23:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[6]);f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/Game","copyLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",38);}
case 38:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",43);}
case 43:{f.StackOp("pop");f.Pc=44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{f.Locals[7]=f.Pop();f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",54);}
case 54:{f.Locals[8]=f.Pop();f.Pc=56;continue;}
case 56:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?73:66;continue;}
case 66:{f.Push(JValue.I(-1));f.Pc=67;continue;}
case 67:{f.Locals[7]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/CardLists","shuffle","(Ljava/util/List;)V","invokestatic",73);}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",77);}
case 77:{f.Locals[9]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[9]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",86);}
case 86:{f.Pc=f.Pop().Int==0?189:89;continue;}
case 89:{f.Push(f.Locals[9]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",96);}
case 96:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=99;continue;}
case 99:{f.Locals[10]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[10]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",106);}
case 106:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",109);}
case 109:{f.Locals[11]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[3]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",115);}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[10]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[7]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[4]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[6]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",127);}
case 127:{f.Locals[12]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[12]);f.Pc=131;continue;}
case 131:{f.Pc=f.Pop().Reference==null?186:134;continue;}
case 134:{f.Push(f.Locals[11]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[12]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",141);}
case 141:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",144);}
case 144:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int!=0?186:150;continue;}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[11]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[12]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",159);}
case 159:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",162);}
case 162:{f.Push(f.Locals[12]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",167);}
case 167:{f.StackOp("pop");f.Pc=168;continue;}
case 168:{f.Push(f.Locals[8]);f.Pc=170;continue;}
case 170:{f.Pc=f.Pop().Int==0?186:173;continue;}
case 173:{f.Push(f.Locals[5]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[3]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[4]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",181);}
case 181:{f.Push(f.Locals[5]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/card/CardZoneTable","clear","()V","invokevirtual",186);}
case 186:{f.Pc=79;continue;}
case 189:{f.Push(f.Locals[8]);f.Pc=191;continue;}
case 191:{f.Pc=f.Pop().Int!=0?202:194;continue;}
case 194:{f.Push(f.Locals[5]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[3]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[4]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",202);}
case 202:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3356(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/cost/Cost","getTotalMana","()Lforge/card/mana/ManaCost;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/card/mana/ManaCost","getCMC","()I","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

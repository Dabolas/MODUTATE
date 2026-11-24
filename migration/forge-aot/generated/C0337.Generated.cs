// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C337{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/MultiplePilesEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3511,"forge/game/ability/effects/MultiplePilesEffect","<init>","()V",1,1,1,new JHandler[]{},M3511));
c.Add(new JMethod(3512,"forge/game/ability/effects/MultiplePilesEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,4,new JHandler[]{},M3512));
c.Add(new JMethod(3513,"forge/game/ability/effects/MultiplePilesEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,18,9,new JHandler[]{},M3513));
}

internal static JStep M3511(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3512(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Piles")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("Separate all ")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",31);}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?44:39;continue;}
case 39:{f.Push(JValue.R(rt.String("")));f.Pc=41;continue;}
case 41:{f.Pc=64;continue;}
case 44:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",47);}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/util/Lang","describeValidList","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Push(JValue.R(rt.String(" card$")));f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",59);}
case 59:{return rt.DynamicCall(f,"forge/game/ability/effects/MultiplePilesEffect:3512:59:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",64);}
case 64:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",67);}
case 67:{f.Push(JValue.R(rt.String("cards ")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",72);}
case 72:{f.StackOp("pop");f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/ability/effects/MultiplePilesEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",78);}
case 78:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",81);}
case 81:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("controls into ")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",91);}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",95);}
case 95:{f.Push(JValue.R(rt.String(" piles.")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",105);}
case 105:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3513(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Zone")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?26:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Zone")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",23);}
case 23:{f.Pc=29;continue;}
case 26:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=29;continue;}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("RandomChosen")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",36);}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("Piles")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",47);}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",52);}
case 52:{f.Locals[6]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",62);}
case 62:{f.Locals[7]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/ability/effects/MultiplePilesEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",68);}
case 68:{f.Locals[8]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[8]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",77);}
case 77:{f.Locals[9]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",83);}
case 83:{f.Locals[10]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[8]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[10]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",94);}
case 94:{f.Pc=f.Pop().Int==0?136:97;continue;}
case 97:{f.Push(f.Locals[10]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[8]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(null));f.Pc=102;continue;}
case 102:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",105);}
case 105:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int!=0?136:111;continue;}
case 111:{f.Push(f.Locals[8]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[9]);f.Pc=115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=117;continue;}
case 117:{f.Push(f.Locals[8]);f.Pc=119;continue;}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",125);}
case 125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/List","add","(ILjava/lang/Object;)V","invokeinterface",133);}
case 133:{f.Pc=85;continue;}
case 136:{f.Push(f.Locals[8]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",143);}
case 143:{f.Locals[11]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[11]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",152);}
case 152:{f.Pc=f.Pop().Int==0?363:155;continue;}
case 155:{f.Push(f.Locals[11]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",162);}
case 162:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=165;continue;}
case 165:{f.Locals[12]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[12]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",172);}
case 172:{f.Pc=f.Pop().Int!=0?178:175;continue;}
case 175:{f.Pc=145;continue;}
case 178:{f.Push(f.Locals[1]);f.Pc=179;continue;}
case 179:{f.Push(JValue.R(rt.String("DefinedCards")));f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",184);}
case 184:{f.Pc=f.Pop().Int==0?203:187;continue;}
case 187:{f.Push(f.Locals[2]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[1]);f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.String("DefinedCards")));f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",194);}
case 194:{f.Push(f.Locals[1]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",198);}
case 198:{f.Locals[13]=f.Pop();f.Pc=200;continue;}
case 200:{f.Pc=218;continue;}
case 203:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=206;continue;}
case 206:{f.StackOp("dup");f.Pc=207;continue;}
case 207:{f.Push(f.Locals[12]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[3]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",213);}
case 213:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",216);}
case 216:{f.Locals[13]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[13]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[7]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[2]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",226);}
case 226:{f.Push(f.Locals[2]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[1]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",231);}
case 231:{f.Locals[13]=f.Pop();f.Pc=233;continue;}
case 233:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",236);}
case 236:{f.Locals[14]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(JValue.I(1));f.Pc=239;continue;}
case 239:{f.Locals[15]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[15]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[5]);f.Pc=245;continue;}
case 245:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?317:248;continue;}
case 248:{f.Push(f.Locals[13]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",253);}
case 253:{f.Locals[16]=f.Pop();f.Pc=255;continue;}
case 255:{f.Push(f.Locals[12]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",260);}
case 260:{f.Push(f.Locals[13]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[1]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",266);}
case 266:{f.Push(JValue.R(rt.String("lblChooseCardsInTargetPile")));f.Pc=268;continue;}
case 268:{f.Push(JValue.I(1));f.Pc=269;continue;}
case 269:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=272;continue;}
case 272:{f.StackOp("dup");f.Pc=273;continue;}
case 273:{f.Push(JValue.I(0));f.Pc=274;continue;}
case 274:{f.Push(f.Locals[15]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",279);}
case 279:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",283);}
case 283:{f.Push(JValue.I(0));f.Pc=284;continue;}
case 284:{f.Push(f.Locals[16]);f.Pc=286;continue;}
case 286:{f.Push(JValue.I(0));f.Pc=287;continue;}
case 287:{f.Push(JValue.R(null));f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",291);}
case 291:{f.Locals[17]=f.Pop();f.Pc=293;continue;}
case 293:{f.Push(f.Locals[14]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[17]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",302);}
case 302:{f.StackOp("pop");f.Pc=303;continue;}
case 303:{f.Push(f.Locals[13]);f.Pc=305;continue;}
case 305:{f.Push(f.Locals[17]);f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",310);}
case 310:{f.StackOp("pop");f.Pc=311;continue;}
case 311:{f.Locals[15]=JValue.I(unchecked(f.Locals[15].Int+(1)));f.Pc=314;continue;}
case 314:{f.Pc=241;continue;}
case 317:{f.Push(f.Locals[14]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[13]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",326);}
case 326:{f.StackOp("pop");f.Pc=327;continue;}
case 327:{f.Push(f.Locals[12]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",332);}
case 332:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",335);}
case 335:{f.Push(f.Locals[1]);f.Pc=336;continue;}
case 336:{f.Push(f.Locals[12]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[14]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",343);}
case 343:{f.Push(f.Locals[12]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",348);}
case 348:{f.Push(f.Locals[6]);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[12]);f.Pc=352;continue;}
case 352:{f.Push(f.Locals[14]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",359);}
case 359:{f.StackOp("pop");f.Pc=360;continue;}
case 360:{f.Pc=145;continue;}
case 363:{f.Push(f.Locals[4]);f.Pc=365;continue;}
case 365:{f.Pc=f.Pop().Int==0?454:368;continue;}
case 368:{f.Push(f.Locals[6]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",375);}
case 375:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",380);}
case 380:{f.Locals[11]=f.Pop();f.Pc=382;continue;}
case 382:{f.Push(f.Locals[11]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",389);}
case 389:{f.Pc=f.Pop().Int==0?431:392;continue;}
case 392:{f.Push(f.Locals[11]);f.Pc=394;continue;}
case 394:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",399);}
case 399:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=402;continue;}
case 402:{f.Locals[12]=f.Pop();f.Pc=404;continue;}
case 404:{f.Push(f.Locals[12]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",411);}
case 411:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=414;continue;}
case 414:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",417);}
case 417:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=420;continue;}
case 420:{f.Locals[13]=f.Pop();f.Pc=422;continue;}
case 422:{f.Push(f.Locals[2]);f.Pc=423;continue;}
case 423:{f.Push(f.Locals[13]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",428);}
case 428:{f.Pc=382;continue;}
case 431:{f.Push(f.Locals[1]);f.Pc=432;continue;}
case 432:{f.Push(JValue.R(rt.String("ChosenPile")));f.Pc=435;continue;}
case 435:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",438);}
case 438:{f.Locals[11]=f.Pop();f.Pc=440;continue;}
case 440:{f.Push(f.Locals[11]);f.Pc=442;continue;}
case 442:{f.Pc=f.Pop().Reference==null?450:445;continue;}
case 445:{f.Push(f.Locals[11]);f.Pc=447;continue;}
case 447:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",450);}
case 450:{f.Push(f.Locals[2]);f.Pc=451;continue;}
case 451:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",454);}
case 454:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

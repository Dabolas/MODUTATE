// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C304{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ExploreEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3394,"forge/game/ability/effects/ExploreEffect","<init>","()V",1,1,1,new JHandler[]{},M3394));
c.Add(new JMethod(3395,"forge/game/ability/effects/ExploreEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M3395));
c.Add(new JMethod(3396,"forge/game/ability/effects/ExploreEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,3,new JHandler[]{},M3396));
c.Add(new JMethod(3397,"forge/game/ability/effects/ExploreEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,17,9,new JHandler[]{},M3397));
}

internal static JStep M3394(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3395(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3396(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/ExploreEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference==null?27:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?32:27;continue;}
case 27:{f.Push(JValue.R(rt.String("That creature")));f.Pc=29;continue;}
case 29:{f.Pc=36;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",36);}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String(" ")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",54);}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?63:58;continue;}
case 58:{f.Push(JValue.R(rt.String("explore")));f.Pc=60;continue;}
case 60:{f.Pc=65;continue;}
case 63:{f.Push(JValue.R(rt.String("explores")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",68);}
case 68:{f.StackOp("pop");f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String(". ")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",80);}
case 80:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3397(JRuntime rt,JFrame f)
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
case 12:{f.Push(JValue.R(rt.String("Num")));f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("1")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/ability/effects/ExploreEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",30);}
case 30:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",37);}
case 37:{f.Locals[5]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",46);}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?407:58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[7]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[7]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",75);}
case 75:{f.Locals[8]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{f.Locals[9]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[9]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?404:87;continue;}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",91);}
case 91:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Explore","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Explore","Lforge/game/replacement/ReplacementType;"));f.Pc=94;continue;}
case 94:{f.Push(f.Locals[7]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",99);}
case 99:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",102);}
case 102:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=105;continue;}
case 105:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?111:108;continue;}
case 108:{f.Pc=398;continue;}
case 111:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=114;continue;}
case 114:{f.StackOp("dup");f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",118);}
case 118:{f.Locals[10]=f.Pop();f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",123);}
case 123:{f.Locals[11]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[11]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",131);}
case 131:{f.Locals[12]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(JValue.I(0));f.Pc=134;continue;}
case 134:{f.Locals[13]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[8]);f.Pc=138;continue;}
case 138:{f.Push(JValue.I(1));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/player/Player","getTopXCardsFromLibrary","(I)Lforge/game/card/CardCollection;","invokevirtual",142);}
case 142:{f.Locals[14]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[14]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",149);}
case 149:{f.Pc=f.Pop().Int!=0?291:152;continue;}
case 152:{f.Push(f.Locals[3]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",156);}
case 156:{f.Push(f.Locals[14]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[8]);f.Pc=160;continue;}
case 160:{f.Push(JValue.I(0));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",164);}
case 164:{f.Push(JValue.R(rt.String("lblRevealedForExplore")));f.Pc=166;continue;}
case 166:{f.Push(JValue.I(0));f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",173);}
case 173:{return rt.DynamicCall(f,"forge/game/ability/effects/ExploreEffect:3397:173:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",178);}
case 178:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",181);}
case 181:{f.Push(f.Locals[14]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/card/CardCollection","getFirst","()Ljava/lang/Object;","invokevirtual",186);}
case 186:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=189;continue;}
case 189:{f.Locals[15]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[15]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",196);}
case 196:{f.Pc=f.Pop().Int==0?221:199;continue;}
case 199:{f.Push(f.Locals[3]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",203);}
case 203:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=206;continue;}
case 206:{f.Push(f.Locals[15]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[1]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[11]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",214);}
case 214:{f.StackOp("pop");f.Pc=215;continue;}
case 215:{f.Push(JValue.I(1));f.Pc=216;continue;}
case 216:{f.Locals[13]=f.Pop();f.Pc=218;continue;}
case 218:{f.Pc=291;continue;}
case 221:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",224);}
case 224:{f.Locals[16]=f.Pop();f.Pc=226;continue;}
case 226:{f.Push(f.Locals[16]);f.Pc=228;continue;}
case 228:{f.Push(JValue.R(rt.String("RevealedCard")));f.Pc=230;continue;}
case 230:{f.Push(f.Locals[15]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",237);}
case 237:{f.StackOp("pop");f.Pc=238;continue;}
case 238:{f.Push(f.Locals[8]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",243);}
case 243:{f.Push(f.Locals[1]);f.Pc=244;continue;}
case 244:{f.Push(JValue.R(null));f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",248);}
case 248:{f.Push(JValue.R(rt.String("lblPutThisCardToYourGraveyard")));f.Pc=250;continue;}
case 250:{f.Push(JValue.I(1));f.Pc=251;continue;}
case 251:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=254;continue;}
case 254:{f.StackOp("dup");f.Pc=255;continue;}
case 255:{f.Push(JValue.I(0));f.Pc=256;continue;}
case 256:{f.Push(f.Locals[15]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",261);}
case 261:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",265);}
case 265:{f.Push(f.Locals[15]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[16]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",272);}
case 272:{f.Pc=f.Pop().Int==0?291:275;continue;}
case 275:{f.Push(f.Locals[3]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",279);}
case 279:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=282;continue;}
case 282:{f.Push(f.Locals[15]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[1]);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[11]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",290);}
case 290:{f.StackOp("pop");f.Pc=291;continue;}
case 291:{f.Push(f.Locals[13]);f.Pc=293;continue;}
case 293:{f.Pc=f.Pop().Int!=0?335:296;continue;}
case 296:{f.Push(f.Locals[3]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[7]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",302);}
case 302:{f.Locals[15]=f.Pop();f.Pc=304;continue;}
case 304:{f.Push(f.Locals[15]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",309);}
case 309:{f.Pc=f.Pop().Int==0?335:312;continue;}
case 312:{f.Push(f.Locals[15]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[7]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",319);}
case 319:{f.Pc=f.Pop().Int==0?335:322;continue;}
case 322:{f.Push(f.Locals[7]);f.Pc=324;continue;}
case 324:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"));f.Pc=327;continue;}
case 327:{f.Push(JValue.I(1));f.Pc=328;continue;}
case 328:{f.Push(f.Locals[8]);f.Pc=330;continue;}
case 330:{f.Push(f.Locals[10]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",335);}
case 335:{f.Push(f.Locals[8]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/player/Player","addExploredThisTurn","()V","invokevirtual",340);}
case 340:{f.Push(f.Locals[7]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",345);}
case 345:{f.Locals[15]=f.Pop();f.Pc=347;continue;}
case 347:{f.Push(f.Locals[14]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",352);}
case 352:{f.Pc=f.Pop().Int!=0?371:355;continue;}
case 355:{f.Push(f.Locals[15]);f.Pc=357;continue;}
case 357:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Explored","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Explored","Lforge/game/ability/AbilityKey;"));f.Pc=360;continue;}
case 360:{f.Push(f.Locals[14]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/card/CardCollection","getFirst","()Ljava/lang/Object;","invokevirtual",365);}
case 365:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",370);}
case 370:{f.StackOp("pop");f.Pc=371;continue;}
case 371:{f.Push(f.Locals[3]);f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",375);}
case 375:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Explores","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Explores","Lforge/game/trigger/TriggerType;"));f.Pc=378;continue;}
case 378:{f.Push(f.Locals[15]);f.Pc=380;continue;}
case 380:{f.Push(JValue.I(0));f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",384);}
case 384:{f.Push(f.Locals[10]);f.Pc=386;continue;}
case 386:{f.Push(f.Locals[3]);f.Pc=387;continue;}
case 387:{f.Push(f.Locals[1]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",391);}
case 391:{f.Push(f.Locals[12]);f.Pc=393;continue;}
case 393:{f.Push(f.Locals[3]);f.Pc=394;continue;}
case 394:{f.Push(f.Locals[1]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",398);}
case 398:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=401;continue;}
case 401:{f.Pc=80;continue;}
case 404:{f.Pc=48;continue;}
case 407:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

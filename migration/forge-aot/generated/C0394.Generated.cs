// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C394{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/SacrificeAllEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3701,"forge/game/ability/effects/SacrificeAllEffect","<init>","()V",1,1,1,new JHandler[]{},M3701));
c.Add(new JMethod(3702,"forge/game/ability/effects/SacrificeAllEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,4,new JHandler[]{},M3702));
c.Add(new JMethod(3703,"forge/game/ability/effects/SacrificeAllEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,13,5,new JHandler[]{},M3703));
c.Add(new JMethod(3704,"forge/game/ability/effects/SacrificeAllEffect","lambda$getStackDescription$0","(Ljava/lang/String;)Ljava/lang/String;",4106,1,4,new JHandler[]{},M3704));
}

internal static JStep M3701(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3702(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Controller")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?56:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Controller")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/effects/SacrificeAllEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",29);}
case 29:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",32);}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",38);}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?47:42;continue;}
case 42:{f.Push(JValue.R(rt.String(" sacrifices ")));f.Pc=44;continue;}
case 44:{f.Pc=49;continue;}
case 47:{f.Push(JValue.R(rt.String(" sacrifice ")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Pc=63;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("Sacrifice ")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("Defined")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?94:72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/ability/effects/SacrificeAllEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",76);}
case 76:{f.Locals[3]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",82);}
case 82:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",85);}
case 85:{f.Push(JValue.R(rt.String(".")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Pc=180;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("ValidDescription")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?122:103;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("ValidDescription")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",110);}
case 110:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",113);}
case 113:{f.Push(JValue.R(rt.String(".")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",118);}
case 118:{f.StackOp("pop");f.Pc=119;continue;}
case 119:{f.Pc=180;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?173:131;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String("all ")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",137);}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",143);}
case 143:{f.Push(JValue.R(rt.String(",")));f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",148);}
case 148:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",151);}
case 151:{return rt.DynamicCall(f,"forge/game/ability/effects/SacrificeAllEffect:3702:151:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",156);}
case 156:{f.Push(JValue.R(rt.String("or")));f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",161);}
case 161:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",164);}
case 164:{f.Push(JValue.R(rt.String(".")));f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",169);}
case 169:{f.StackOp("pop");f.Pc=170;continue;}
case 170:{f.Pc=180;continue;}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("permanents.")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",179);}
case 179:{f.StackOp("pop");f.Pc=180;continue;}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",184);}
case 184:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3703(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Defined")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?41:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Defined")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",36);}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Pc=74;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",49);}
case 49:{f.Locals[5]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?74:60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",68);}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",72);}
case 72:{f.Locals[5]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("RememberSacrificed")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",80);}
case 80:{f.Locals[6]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{f.Pc=f.Pop().Int==0?91:87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",91);}
case 91:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",98);}
case 98:{f.Locals[7]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",107);}
case 107:{f.Locals[8]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",116);}
case 116:{f.Pc=f.Pop().Int==0?161:119;continue;}
case 119:{f.Push(f.Locals[8]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",126);}
case 126:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=129;continue;}
case 129:{f.Locals[9]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[9]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{f.Push(JValue.I(1));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/card/Card","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int!=0?144:141;continue;}
case 141:{f.Pc=109;continue;}
case 144:{f.Push(f.Locals[7]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[9]);f.Pc=150;continue;}
case 150:{f.Push(JValue.R(null));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",154);}
case 154:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",157);}
case 157:{f.StackOp("pop");f.Pc=158;continue;}
case 158:{f.Pc=109;continue;}
case 161:{f.Push(f.Locals[7]);f.Pc=163;continue;}
case 163:{f.Locals[5]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[1]);f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("Controller")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int==0?195:174;continue;}
case 174:{f.Push(f.Locals[5]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",180);}
case 180:{f.Push(f.Locals[1]);f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("Controller")));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",186);}
case 186:{f.Push(f.Locals[1]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",190);}
case 190:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/util/collect/FCollectionView;)Lforge/game/card/CardCollection;","invokestatic",193);}
case 193:{f.Locals[5]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[4]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[5]);f.Pc=199;continue;}
case 199:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=202;continue;}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",206);}
case 206:{f.Locals[5]=f.Pop();f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",211);}
case 211:{f.Locals[8]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[8]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[1]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",219);}
case 219:{f.Locals[9]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(f.Locals[4]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",226);}
case 226:{f.Push(f.Locals[5]);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[1]);f.Pc=229;continue;}
case 229:{f.Push(JValue.I(1));f.Pc=230;continue;}
case 230:{f.Push(f.Locals[8]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/GameAction","sacrifice","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",235);}
case 235:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",238);}
case 238:{f.Locals[10]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[10]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",247);}
case 247:{f.Pc=f.Pop().Int==0?308:250;continue;}
case 250:{f.Push(f.Locals[10]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",257);}
case 257:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=260;continue;}
case 260:{f.Locals[11]=f.Pop();f.Pc=262;continue;}
case 262:{f.Push(f.Locals[9]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",267);}
case 267:{f.Push(f.Locals[11]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",274);}
case 274:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=277;continue;}
case 277:{f.Locals[12]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[6]);f.Pc=281;continue;}
case 281:{f.Pc=f.Pop().Int==0?290:284;continue;}
case 284:{f.Push(f.Locals[2]);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[12]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",290);}
case 290:{f.Push(f.Locals[1]);f.Pc=291;continue;}
case 291:{f.Push(JValue.R(rt.String("ImprintSacrificed")));f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",296);}
case 296:{f.Pc=f.Pop().Int==0?305:299;continue;}
case 299:{f.Push(f.Locals[2]);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[12]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",305);}
case 305:{f.Pc=240;continue;}
case 308:{f.Push(f.Locals[9]);f.Pc=310;continue;}
case 310:{f.Push(f.Locals[4]);f.Pc=312;continue;}
case 312:{f.Push(f.Locals[1]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",316);}
case 316:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3704(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;ZZ)Ljava/lang/String;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

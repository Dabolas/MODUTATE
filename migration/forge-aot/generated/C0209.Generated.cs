// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C209{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/BalanceEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3049,"forge/game/ability/effects/BalanceEffect","<init>","()V",1,1,1,new JHandler[]{},M3049));
c.Add(new JMethod(3050,"forge/game/ability/effects/BalanceEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,17,8,new JHandler[]{},M3050));
}

internal static JStep M3049(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3050(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Valid")));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Card")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Zone")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?47:35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("Zone")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",44);}
case 44:{f.Pc=50;continue;}
case 47:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=50;continue;}
case 50:{f.Locals[6]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(JValue.I(2147483647));f.Pc=54;continue;}
case 54:{f.Locals[7]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/Game","getPlayersInTurnOrder","()Lforge/game/player/PlayerCollection;","invokevirtual",61);}
case 61:{f.Locals[8]=f.Pop();f.Pc=63;continue;}
case 63:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=66;continue;}
case 66:{f.StackOp("dup");f.Pc=67;continue;}
case 67:{f.Push(f.Locals[8]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/util/collect/FCollectionView","size","()I","invokeinterface",74);}
case 74:{return rt.Call(f,"java/util/ArrayList","<init>","(I)V","invokespecial",77);}
case 77:{f.Locals[9]=f.Pop();f.Pc=79;continue;}
case 79:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",82);}
case 82:{f.Locals[10]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{f.Locals[11]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[11]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[8]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/util/collect/FCollectionView","size","()I","invokeinterface",96);}
case 96:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?160:99;continue;}
case 99:{f.Push(f.Locals[9]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[8]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[11]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/util/collect/FCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",110);}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[6]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",118);}
case 118:{f.Push(f.Locals[5]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[3]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",126);}
case 126:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",131);}
case 131:{f.StackOp("pop");f.Pc=132;continue;}
case 132:{f.Push(f.Locals[7]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[9]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[11]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",143);}
case 143:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",149);}
case 149:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",152);}
case 152:{f.Locals[7]=f.Pop();f.Pc=154;continue;}
case 154:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=157;continue;}
case 157:{f.Pc=87;continue;}
case 160:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",163);}
case 163:{f.Locals[11]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[11]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",171);}
case 171:{f.Locals[12]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(JValue.I(0));f.Pc=174;continue;}
case 174:{f.Locals[13]=f.Pop();f.Pc=176;continue;}
case 176:{f.Push(f.Locals[13]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[8]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/util/collect/FCollectionView","size","()I","invokeinterface",185);}
case 185:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?331:188;continue;}
case 188:{f.Push(f.Locals[8]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[13]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/util/collect/FCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",197);}
case 197:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=200;continue;}
case 200:{f.Locals[14]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[9]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[13]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",211);}
case 211:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",217);}
case 217:{f.Push(f.Locals[7]);f.Pc=219;continue;}
case 219:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=220;continue;}
case 220:{f.Locals[15]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[15]);f.Pc=224;continue;}
case 224:{f.Pc=f.Pop().Int!=0?230:227;continue;}
case 227:{f.Pc=325;continue;}
case 230:{f.Push(f.Locals[6]);f.Pc=232;continue;}
case 232:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int==0?281:241;continue;}
case 241:{f.Push(f.Locals[10]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[14]);f.Pc=245;continue;}
case 245:{f.Push(f.Locals[14]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",250);}
case 250:{f.Push(f.Locals[14]);f.Pc=252;continue;}
case 252:{f.Push(f.Locals[1]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[9]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[13]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",262);}
case 262:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[15]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[15]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsToDiscardFrom","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollection;II)Lforge/game/card/CardCollectionView;","invokevirtual",272);}
case 272:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",277);}
case 277:{f.StackOp("pop");f.Pc=278;continue;}
case 278:{f.Pc=325;continue;}
case 281:{f.Push(f.Locals[14]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",286);}
case 286:{f.Push(f.Locals[1]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[15]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[15]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[9]);f.Pc=293;continue;}
case 293:{f.Push(f.Locals[13]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",300);}
case 300:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=303;continue;}
case 303:{f.Push(f.Locals[5]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/player/PlayerController","choosePermanentsToSacrifice","(Lforge/game/spellability/SpellAbility;IILforge/game/card/CardCollectionView;Ljava/lang/String;)Lforge/game/card/CardCollectionView;","invokevirtual",308);}
case 308:{f.Locals[16]=f.Pop();f.Pc=310;continue;}
case 310:{f.Push(f.Locals[4]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",315);}
case 315:{f.Push(f.Locals[16]);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[1]);f.Pc=318;continue;}
case 318:{f.Push(JValue.I(1));f.Pc=319;continue;}
case 319:{f.Push(f.Locals[11]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/GameAction","sacrifice","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",324);}
case 324:{f.StackOp("pop");f.Pc=325;continue;}
case 325:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=328;continue;}
case 328:{f.Pc=176;continue;}
case 331:{f.Push(f.Locals[6]);f.Pc=333;continue;}
case 333:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",339);}
case 339:{f.Pc=f.Pop().Int==0?351:342;continue;}
case 342:{f.Push(f.Locals[1]);f.Pc=343;continue;}
case 343:{f.Push(JValue.I(1));f.Pc=344;continue;}
case 344:{f.Push(f.Locals[10]);f.Pc=346;continue;}
case 346:{f.Push(f.Locals[11]);f.Pc=348;continue;}
case 348:{return rt.Call(f,"forge/game/ability/effects/BalanceEffect","discard","(Lforge/game/spellability/SpellAbility;ZLjava/util/Map;Ljava/util/Map;)V","invokestatic",351);}
case 351:{f.Push(f.Locals[12]);f.Pc=353;continue;}
case 353:{f.Push(f.Locals[4]);f.Pc=355;continue;}
case 355:{f.Push(f.Locals[1]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",359);}
case 359:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

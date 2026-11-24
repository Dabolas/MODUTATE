// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C426{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/VentureEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3815,"forge/game/ability/effects/VentureEffect","<init>","()V",1,1,1,new JHandler[]{},M3815));
c.Add(new JMethod(3816,"forge/game/ability/effects/VentureEffect","getDungeonCard","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/card/Card;",2,14,5,new JHandler[]{},M3816));
c.Add(new JMethod(3817,"forge/game/ability/effects/VentureEffect","chooseNextRoom","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/Card;Ljava/lang/String;)Ljava/lang/String;",2,15,6,new JHandler[]{},M3817));
c.Add(new JMethod(3818,"forge/game/ability/effects/VentureEffect","ventureIntoDungeon","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)V",2,8,7,new JHandler[]{},M3818));
c.Add(new JMethod(3819,"forge/game/ability/effects/VentureEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,4,3,new JHandler[]{},M3819));
c.Add(new JMethod(3820,"forge/game/ability/effects/VentureEffect","lambda$getDungeonCard$3","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",4106,2,1,new JHandler[]{},M3820));
c.Add(new JMethod(3821,"forge/game/ability/effects/VentureEffect","lambda$getDungeonCard$2","(Ljava/util/Map$Entry;)Lforge/card/ICardFace;",4106,1,1,new JHandler[]{},M3821));
c.Add(new JMethod(3822,"forge/game/ability/effects/VentureEffect","lambda$getDungeonCard$1","(Ljava/util/Map$Entry;)Z",4106,1,1,new JHandler[]{},M3822));
c.Add(new JMethod(3823,"forge/game/ability/effects/VentureEffect","lambda$getDungeonCard$0","(Ljava/lang/String;Ljava/util/Map$Entry;)Z",4106,2,2,new JHandler[]{},M3823));
}

internal static JStep M3815(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3816(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",12);}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",30);}
case 30:{f.Pc=f.Pop().Int==0?85:33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[6]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",50);}
case 50:{return rt.Call(f,"forge/card/CardTypeView","isDungeon","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?82:58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/Card","isInLastRoom","()Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int!=0?69:66;continue;}
case 66:{f.Push(f.Locals[6]);f.Pc=68;continue;}
case 68:{return JStep.Return(f.Pop());}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",73);}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/GameAction","completeDungeon","(Lforge/game/player/Player;Lforge/game/card/Card;)V","invokevirtual",79);}
case 79:{f.Pc=85;continue;}
case 82:{f.Pc=23;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("Dungeon")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?114:94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("Dungeon")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",100);}
case 100:{f.Locals[6]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[6]);f.Pc=104;continue;}
case 104:{return rt.DynamicCall(f,"forge/game/ability/effects/VentureEffect:3816:104:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",109);}
case 109:{f.Locals[5]=f.Pop();f.Pc=111;continue;}
case 111:{f.Pc=121;continue;}
case 114:{return rt.DynamicCall(f,"forge/game/ability/effects/VentureEffect:3816:114:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",119);}
case 119:{f.Locals[5]=f.Pop();f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",124);}
case 124:{return rt.Call(f,"forge/StaticData","getAllTokens","()Lforge/token/TokenDb;","invokevirtual",127);}
case 127:{return rt.Call(f,"forge/token/TokenDb","getRules","()Ljava/util/Map;","invokevirtual",130);}
case 130:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",135);}
case 135:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",140);}
case 140:{f.Push(f.Locals[5]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",147);}
case 147:{return rt.DynamicCall(f,"forge/game/ability/effects/VentureEffect:3816:147:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",152);}
case 152:{return rt.DynamicCall(f,"forge/game/ability/effects/VentureEffect:3816:152:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",157);}
case 157:{return rt.DynamicCall(f,"forge/game/ability/effects/VentureEffect:3816:157:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BinaryOperator;",162);}
case 162:{return rt.DynamicCall(f,"forge/game/ability/effects/VentureEffect:3816:162:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",167);}
case 167:{return rt.Call(f,"java/util/stream/Collectors","toMap","(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;Ljava/util/function/Supplier;)Ljava/util/stream/Collector;","invokestatic",170);}
case 170:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",175);}
case 175:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=178;continue;}
case 178:{f.Locals[6]=f.Pop();f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",183);}
case 183:{f.Push(JValue.R(rt.String("lblChooseDungeon")));f.Pc=185;continue;}
case 185:{f.Push(JValue.I(0));f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",192);}
case 192:{f.Locals[7]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[2]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",198);}
case 198:{f.Push(f.Locals[1]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[6]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",206);}
case 206:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",209);}
case 209:{f.Push(f.Locals[7]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleCardFace","(Lforge/game/spellability/SpellAbility;Ljava/util/List;Ljava/lang/String;)Lforge/card/ICardFace;","invokevirtual",214);}
case 214:{f.Locals[8]=f.Pop();f.Pc=216;continue;}
case 216:{f.Push(f.Locals[8]);f.Pc=218;continue;}
case 218:{f.Pc=f.Pop().Reference!=null?223:221;continue;}
case 221:{f.Push(JValue.R(null));f.Pc=222;continue;}
case 222:{return JStep.Return(f.Pop());}
case 223:{f.Push(f.Locals[6]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[8]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",232);}
case 232:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=235;continue;}
case 235:{f.Locals[9]=f.Pop();f.Pc=237;continue;}
case 237:{f.Push(f.Locals[1]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",241);}
case 241:{f.Locals[10]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[1]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",247);}
case 247:{f.Locals[11]=f.Pop();f.Pc=249;continue;}
case 249:{f.Push(f.Locals[11]);f.Pc=251;continue;}
case 251:{f.Push(f.Locals[10]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",256);}
case 256:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",262);}
case 262:{f.Locals[12]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(f.Locals[12]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[9]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/card/token/TokenInfo","tokenSetFor","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",271);}
case 271:{f.Locals[12]=f.Pop();f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",276);}
case 276:{return rt.Call(f,"forge/StaticData","getAllTokens","()Lforge/token/TokenDb;","invokevirtual",279);}
case 279:{f.Push(f.Locals[9]);f.Pc=281;continue;}
case 281:{f.Push(f.Locals[12]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/token/TokenDb","getToken","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperToken;","invokevirtual",286);}
case 286:{f.Push(f.Locals[2]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[3]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/card/CardFactory","getCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;Lforge/game/Game;)Lforge/game/card/Card;","invokestatic",291);}
case 291:{f.Locals[13]=f.Pop();f.Pc=293;continue;}
case 293:{f.Push(f.Locals[13]);f.Pc=295;continue;}
case 295:{if(!rt.StaticReady(f,"forge/card/GamePieceType","DUNGEON","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","DUNGEON","Lforge/card/GamePieceType;"));f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",301);}
case 301:{f.Push(f.Locals[3]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",305);}
case 305:{f.Push(f.Locals[13]);f.Pc=307;continue;}
case 307:{f.Push(f.Locals[1]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",311);}
case 311:{f.Push(f.Locals[13]);f.Pc=313;continue;}
case 313:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3817(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{f.Locals[5]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",13);}
case 13:{f.Locals[6]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[6]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?74:25;continue;}
case 25:{f.Push(f.Locals[6]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[7]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[7]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",42);}
case 42:{f.Locals[8]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[8]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("RoomName")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",51);}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?71:59;continue;}
case 59:{f.Push(f.Locals[8]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("NextRoomName")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",66);}
case 66:{f.Locals[5]=f.Pop();f.Pc=68;continue;}
case 68:{f.Pc=74;continue;}
case 71:{f.Pc=15;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String(",")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",81);}
case 81:{f.Locals[6]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=86;continue;}
case 86:{f.Push(JValue.I(1));f.Pc=87;continue;}
case 87:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?95:90;continue;}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{f.Push(JValue.I(0));f.Pc=93;continue;}
case 93:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=94;continue;}
case 94:{return JStep.Return(f.Pop());}
case 95:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=98;continue;}
case 98:{f.StackOp("dup");f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",102);}
case 102:{f.Locals[7]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{f.Locals[8]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[8]);f.Pc=110;continue;}
case 110:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=111;continue;}
case 111:{f.Locals[9]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(JValue.I(0));f.Pc=114;continue;}
case 114:{f.Locals[10]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[10]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[9]);f.Pc=120;continue;}
case 120:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?217:123;continue;}
case 123:{f.Push(f.Locals[8]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[10]);f.Pc=127;continue;}
case 127:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=128;continue;}
case 128:{f.Locals[11]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/Card","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",134);}
case 134:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",139);}
case 139:{f.Locals[12]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[12]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",148);}
case 148:{f.Pc=f.Pop().Int==0?211:151;continue;}
case 151:{f.Push(f.Locals[12]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",158);}
case 158:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=161;continue;}
case 161:{f.Locals[13]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[13]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",168);}
case 168:{f.Locals[14]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[14]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("RoomName")));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",177);}
case 177:{f.Push(f.Locals[11]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int==0?208:185;continue;}
case 185:{f.Push(f.Locals[7]);f.Pc=187;continue;}
case 187:{if(!rt.EnsureInitialized(f,"forge/game/trigger/WrappedAbility"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/trigger/WrappedAbility")));f.Pc=190;continue;}
case 190:{f.StackOp("dup");f.Pc=191;continue;}
case 191:{f.Push(f.Locals[13]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[14]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/trigger/WrappedAbility","<init>","(Lforge/game/trigger/Trigger;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)V","invokespecial",199);}
case 199:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",204);}
case 204:{f.StackOp("pop");f.Pc=205;continue;}
case 205:{f.Pc=211;continue;}
case 208:{f.Pc=141;continue;}
case 211:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=214;continue;}
case 214:{f.Pc=116;continue;}
case 217:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",220);}
case 220:{f.Push(JValue.R(rt.String("lblChooseRoom")));f.Pc=223;continue;}
case 223:{f.Push(JValue.I(0));f.Pc=224;continue;}
case 224:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",230);}
case 230:{f.Locals[8]=f.Pop();f.Pc=232;continue;}
case 232:{f.Push(f.Locals[2]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",236);}
case 236:{f.Push(f.Locals[7]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[1]);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[8]);f.Pc=241;continue;}
case 241:{f.Push(JValue.R(null));f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleSpellForEffect","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/spellability/SpellAbility;","invokevirtual",245);}
case 245:{f.Locals[9]=f.Pop();f.Pc=247;continue;}
case 247:{f.Push(f.Locals[9]);f.Pc=249;continue;}
case 249:{f.Push(JValue.R(rt.String("RoomName")));f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",254);}
case 254:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3818(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantVenture","cantVenture","(Lforge/game/player/Player;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int==0?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/ability/effects/VentureEffect","getDungeonCard","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/card/Card;","invokevirtual",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/Card","getCurrentRoom","()Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference==null?41:33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?72:41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",46);}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/util/collect/FCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",58);}
case 58:{f.Locals[7]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[7]);f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("RoomName")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",67);}
case 67:{f.Locals[6]=f.Pop();f.Pc=69;continue;}
case 69:{f.Pc=84;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/ability/effects/VentureEffect","chooseNextRoom","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Lforge/game/card/Card;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",82);}
case 82:{f.Locals[6]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/card/Card","setCurrentRoom","(Ljava/lang/String;)V","invokevirtual",91);}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardCounters"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardCounters")));f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("LEVEL")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",104);}
case 104:{f.Push(JValue.I(0));f.Pc=105;continue;}
case 105:{f.Push(JValue.I(1));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/event/GameEventCardCounters","<init>","(Lforge/game/card/Card;Lforge/game/card/CounterType;II)V","invokespecial",109);}
case 109:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",112);}
case 112:{f.Push(f.Locals[4]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",117);}
case 117:{f.Locals[7]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[7]);f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","RoomName","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","RoomName","Lforge/game/ability/AbilityKey;"));f.Pc=124;continue;}
case 124:{f.Push(f.Locals[6]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",131);}
case 131:{f.StackOp("pop");f.Pc=132;continue;}
case 132:{f.Push(f.Locals[3]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",136);}
case 136:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","RoomEntered","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","RoomEntered","Lforge/game/trigger/TriggerType;"));f.Pc=139;continue;}
case 139:{f.Push(f.Locals[7]);f.Pc=141;continue;}
case 141:{f.Push(JValue.I(0));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",145);}
case 145:{f.Push(f.Locals[2]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/player/Player","incrementVenturedThisTurn","()V","invokevirtual",149);}
case 149:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3819(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/VentureEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?46:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int!=0?37:34;continue;}
case 34:{f.Pc=8;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/ability/effects/VentureEffect","ventureIntoDungeon","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)V","invokevirtual",43);}
case 43:{f.Pc=8;continue;}
case 46:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3820(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3821(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3822(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRules","isEnterableDungeon","()Z","invokevirtual",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3823(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

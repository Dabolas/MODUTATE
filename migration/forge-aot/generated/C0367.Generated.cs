// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C367{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RearrangeTopOfLibraryEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3607,"forge/game/ability/effects/RearrangeTopOfLibraryEffect","<init>","()V",1,1,1,new JHandler[]{},M3607));
c.Add(new JMethod(3608,"forge/game/ability/effects/RearrangeTopOfLibraryEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,7,4,new JHandler[]{},M3608));
c.Add(new JMethod(3609,"forge/game/ability/effects/RearrangeTopOfLibraryEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,7,5,new JHandler[]{},M3609));
c.Add(new JMethod(3610,"forge/game/ability/effects/RearrangeTopOfLibraryEffect","rearrangeTopOfLibrary","(Lforge/game/card/Card;Lforge/game/player/Player;IZLforge/game/spellability/SpellAbility;)V",10,10,6,new JHandler[]{},M3610));
c.Add(new JMethod(3611,"forge/game/ability/effects/RearrangeTopOfLibraryEffect","lambda$getStackDescription$0","(Lforge/game/player/Player;)Ljava/lang/String;",4106,1,2,new JHandler[]{},M3611));
}

internal static JStep M3607(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3608(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/effects/RearrangeTopOfLibraryEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("MayShuffle")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",29);}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("Look at the top ")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?61:56;continue;}
case 56:{f.Push(JValue.R(rt.String("card")));f.Pc=58;continue;}
case 58:{f.Pc=68;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{return rt.DynamicCall(f,"forge/game/ability/effects/RearrangeTopOfLibraryEffect:3608:63:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",68);}
case 68:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String(" of ")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",86);}
case 86:{f.Pc=f.Pop().Int==0?100:89;continue;}
case 89:{f.Push(f.Locals[6]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("target player's")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",96);}
case 96:{f.StackOp("pop");f.Pc=97;continue;}
case 97:{f.Pc=139;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",108);}
case 108:{return rt.DynamicCall(f,"forge/game/ability/effects/RearrangeTopOfLibraryEffect:3608:108:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",113);}
case 113:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",118);}
case 118:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",121);}
case 121:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",126);}
case 126:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(null));f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("and")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",135);}
case 135:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",138);}
case 138:{f.StackOp("pop");f.Pc=139;continue;}
case 139:{f.Push(f.Locals[6]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String(" library. Then put ")));f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",146);}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{f.Push(JValue.I(1));f.Pc=149;continue;}
case 149:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?157:152;continue;}
case 152:{f.Push(JValue.R(rt.String("it")));f.Pc=154;continue;}
case 154:{f.Pc=159;continue;}
case 157:{f.Push(JValue.R(rt.String("them")));f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",162);}
case 162:{f.Push(JValue.R(rt.String(" back in any order. ")));f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",167);}
case 167:{f.StackOp("pop");f.Pc=168;continue;}
case 168:{f.Push(f.Locals[5]);f.Pc=170;continue;}
case 170:{f.Pc=f.Pop().Int==0?218:173;continue;}
case 173:{f.Push(f.Locals[6]);f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.String("You may have ")));f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",180);}
case 180:{f.StackOp("pop");f.Pc=181;continue;}
case 181:{f.Push(f.Locals[3]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",187);}
case 187:{f.Push(JValue.I(1));f.Pc=188;continue;}
case 188:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?202:191;continue;}
case 191:{f.Push(f.Locals[6]);f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.String("those")));f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",198);}
case 198:{f.StackOp("pop");f.Pc=199;continue;}
case 199:{f.Pc=210;continue;}
case 202:{f.Push(f.Locals[6]);f.Pc=204;continue;}
case 204:{f.Push(JValue.R(rt.String("that")));f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",209);}
case 209:{f.StackOp("pop");f.Pc=210;continue;}
case 210:{f.Push(f.Locals[6]);f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.String(" player shuffle their library.")));f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",217);}
case 217:{f.StackOp("pop");f.Pc=218;continue;}
case 218:{f.Push(f.Locals[6]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",223);}
case 223:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3609(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("MayShuffle")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/ability/effects/RearrangeTopOfLibraryEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",29);}
case 29:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",32);}
case 32:{f.Locals[5]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?80:44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[6]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[6]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?67:64;continue;}
case 64:{f.Pc=34;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/ability/effects/RearrangeTopOfLibraryEffect","rearrangeTopOfLibrary","(Lforge/game/card/Card;Lforge/game/player/Player;IZLforge/game/spellability/SpellAbility;)V","invokestatic",77);}
case 77:{f.Pc=34;continue;}
case 80:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3610(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("RearrangePlayer")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?33:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("RearrangePlayer")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",23);}
case 23:{f.Push(JValue.R(null));f.Pc=24;continue;}
case 24:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Pc=38;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",38);}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Reference!=null?46:45;continue;}
case 45:{return JStep.ReturnVoid;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/player/Player","getTopXCardsFromLibrary","(I)Lforge/game/card/CardCollection;","invokevirtual",51);}
case 51:{f.Locals[6]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",58);}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/player/PlayerController","orderMoveToZoneList","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",68);}
case 68:{f.Locals[7]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[7]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",77);}
case 77:{f.Locals[8]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[8]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",86);}
case 86:{f.Pc=f.Pop().Int==0?120:89;continue;}
case 89:{f.Push(f.Locals[8]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",96);}
case 96:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=99;continue;}
case 99:{f.Locals[9]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",105);}
case 105:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",108);}
case 108:{f.Push(f.Locals[9]);f.Pc=110;continue;}
case 110:{f.Push(JValue.I(0));f.Pc=111;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",116);}
case 116:{f.StackOp("pop");f.Pc=117;continue;}
case 117:{f.Pc=79;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{f.Pc=f.Pop().Int==0?157:124;continue;}
case 124:{f.Push(f.Locals[5]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",129);}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(null));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",135);}
case 135:{f.Push(JValue.R(rt.String("lblDoyouWantShuffleTheLibrary")));f.Pc=137;continue;}
case 137:{f.Push(JValue.I(0));f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",144);}
case 144:{f.Push(JValue.R(null));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Int==0?157:151;continue;}
case 151:{f.Push(f.Locals[1]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[4]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/player/Player","shuffle","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",157);}
case 157:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3611(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/util/Lang","getPossesive","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

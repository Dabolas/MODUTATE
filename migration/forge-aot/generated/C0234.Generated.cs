// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C234{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChooseColorEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3145,"forge/game/ability/effects/ChooseColorEffect","<init>","()V",1,1,1,new JHandler[]{},M3145));
c.Add(new JMethod(3146,"forge/game/ability/effects/ChooseColorEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,2,new JHandler[]{},M3146));
c.Add(new JMethod(3147,"forge/game/ability/effects/ChooseColorEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,13,7,new JHandler[]{},M3147));
}

internal static JStep M3145(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3146(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/effects/ChooseColorEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",16);}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String(" chooses a color")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("OrColors")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?43:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String(" or colors")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String(".")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",54);}
case 54:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3147(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Choices")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?51:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("Choices")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",31);}
case 31:{f.Push(JValue.R(rt.String(",")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",47);}
case 47:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",50);}
case 50:{f.Locals[3]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("ColorsFrom")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?127:60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("ColorsFrom")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",67);}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",71);}
case 71:{return rt.Call(f,"forge/game/card/CardUtil","getColorsFromCards","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",74);}
case 74:{f.Locals[4]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?85:84;continue;}
case 84:{return JStep.ReturnVoid;}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/card/ColorSet","stream","()Ljava/util/stream/Stream;","invokevirtual",90);}
case 90:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseColorEffect:3147:90:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",95);}
case 95:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",100);}
case 100:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseColorEffect:3147:100:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",105);}
case 105:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",110);}
case 110:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseColorEffect:3147:110:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",115);}
case 115:{return rt.Call(f,"java/util/stream/Collectors","toCollection","(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;","invokestatic",118);}
case 118:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",123);}
case 123:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=126;continue;}
case 126:{f.Locals[3]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("Exclude")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",133);}
case 133:{f.Pc=f.Pop().Int==0?186:136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("Exclude")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",142);}
case 142:{f.Push(JValue.R(rt.String(",")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",147);}
case 147:{f.Locals[4]=f.Pop();f.Pc=149;continue;}
case 149:{f.Push(f.Locals[4]);f.Pc=151;continue;}
case 151:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=152;continue;}
case 152:{f.Locals[5]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(JValue.I(0));f.Pc=155;continue;}
case 155:{f.Locals[6]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[6]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?186:164;continue;}
case 164:{f.Push(f.Locals[4]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[6]);f.Pc=168;continue;}
case 168:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=169;continue;}
case 169:{f.Locals[7]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[3]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[7]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",179);}
case 179:{f.StackOp("pop");f.Pc=180;continue;}
case 180:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=183;continue;}
case 183:{f.Pc=157;continue;}
case 186:{f.Push(f.Locals[1]);f.Pc=187;continue;}
case 187:{f.Push(JValue.R(rt.String("ExcludeColorsFrom")));f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",192);}
case 192:{f.Pc=f.Pop().Int==0?309:195;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String("ExcludeColorsFrom")));f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",202);}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",206);}
case 206:{return rt.Call(f,"forge/game/card/CardUtil","getColorsFromCards","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",209);}
case 209:{f.Locals[4]=f.Pop();f.Pc=211;continue;}
case 211:{f.Push(f.Locals[4]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",216);}
case 216:{f.Pc=f.Pop().Int!=0?309:219;continue;}
case 219:{f.Push(f.Locals[4]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/card/ColorSet","stream","()Ljava/util/stream/Stream;","invokevirtual",224);}
case 224:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseColorEffect:3147:224:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",229);}
case 229:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",234);}
case 234:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseColorEffect:3147:234:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",239);}
case 239:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",244);}
case 244:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseColorEffect:3147:244:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",249);}
case 249:{return rt.Call(f,"java/util/stream/Collectors","toCollection","(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;","invokestatic",252);}
case 252:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",257);}
case 257:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/ArrayList"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",263);}
case 263:{f.Locals[5]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[5]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",272);}
case 272:{f.Pc=f.Pop().Int==0?299:275;continue;}
case 275:{f.Push(f.Locals[5]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",282);}
case 282:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=285;continue;}
case 285:{f.Locals[6]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[3]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[6]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",295);}
case 295:{f.StackOp("pop");f.Pc=296;continue;}
case 296:{f.Pc=265;continue;}
case 299:{f.Push(f.Locals[3]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",305);}
case 305:{f.Pc=f.Pop().Int==0?309:308;continue;}
case 308:{return JStep.ReturnVoid;}
case 309:{f.Push(f.Locals[1]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/ability/effects/ChooseColorEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",313);}
case 313:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",316);}
case 316:{f.Locals[4]=f.Pop();f.Pc=318;continue;}
case 318:{f.Push(f.Locals[4]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",325);}
case 325:{f.Pc=f.Pop().Int==0?737:328;continue;}
case 328:{f.Push(f.Locals[4]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",335);}
case 335:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=338;continue;}
case 338:{f.Locals[5]=f.Pop();f.Pc=340;continue;}
case 340:{f.Push(f.Locals[5]);f.Pc=342;continue;}
case 342:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",345);}
case 345:{f.Pc=f.Pop().Int!=0?356:348;continue;}
case 348:{f.Push(f.Locals[1]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[5]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/ability/effects/ChooseColorEffect","getNewChooser","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/player/Player;","invokestatic",354);}
case 354:{f.Locals[5]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(f.Locals[1]);f.Pc=357;continue;}
case 357:{f.Push(JValue.R(rt.String("UpTo")));f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",362);}
case 362:{f.Pc=f.Pop().Int==0?369:365;continue;}
case 365:{f.Push(JValue.I(0));f.Pc=366;continue;}
case 366:{f.Pc=383;continue;}
case 369:{f.Push(f.Locals[1]);f.Pc=370;continue;}
case 370:{f.Push(JValue.R(rt.String("TwoColors")));f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",375);}
case 375:{f.Pc=f.Pop().Int==0?382:378;continue;}
case 378:{f.Push(JValue.I(2));f.Pc=379;continue;}
case 379:{f.Pc=383;continue;}
case 382:{f.Push(JValue.I(1));f.Pc=383;continue;}
case 383:{f.Locals[6]=f.Pop();f.Pc=385;continue;}
case 385:{f.Push(f.Locals[1]);f.Pc=386;continue;}
case 386:{f.Push(JValue.R(rt.String("TwoColors")));f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",391);}
case 391:{f.Pc=f.Pop().Int==0?398:394;continue;}
case 394:{f.Push(JValue.I(2));f.Pc=395;continue;}
case 395:{f.Pc=417;continue;}
case 398:{f.Push(f.Locals[1]);f.Pc=399;continue;}
case 399:{f.Push(JValue.R(rt.String("OrColors")));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",404);}
case 404:{f.Pc=f.Pop().Int==0?416:407;continue;}
case 407:{f.Push(f.Locals[3]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",413);}
case 413:{f.Pc=417;continue;}
case 416:{f.Push(JValue.I(1));f.Pc=417;continue;}
case 417:{f.Locals[7]=f.Pop();f.Pc=419;continue;}
case 419:{f.Push(JValue.R(null));f.Pc=420;continue;}
case 420:{f.Locals[8]=f.Pop();f.Pc=422;continue;}
case 422:{f.Push(f.Locals[7]);f.Pc=424;continue;}
case 424:{f.Push(JValue.I(1));f.Pc=425;continue;}
case 425:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?445:428;continue;}
case 428:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",431);}
case 431:{f.Push(JValue.R(rt.String("lblChooseAColor")));f.Pc=433;continue;}
case 433:{f.Push(JValue.I(0));f.Pc=434;continue;}
case 434:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=437;continue;}
case 437:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",440);}
case 440:{f.Locals[8]=f.Pop();f.Pc=442;continue;}
case 442:{f.Pc=538;continue;}
case 445:{f.Push(f.Locals[7]);f.Pc=447;continue;}
case 447:{f.Push(f.Locals[6]);f.Pc=449;continue;}
case 449:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?516:452;continue;}
case 452:{f.Push(f.Locals[7]);f.Pc=454;continue;}
case 454:{f.Push(JValue.I(5));f.Pc=455;continue;}
case 455:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?483:458;continue;}
case 458:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",461);}
case 461:{f.Push(JValue.R(rt.String("lblAtLastChooseNumColors")));f.Pc=463;continue;}
case 463:{f.Push(JValue.I(1));f.Pc=464;continue;}
case 464:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=467;continue;}
case 467:{f.StackOp("dup");f.Pc=468;continue;}
case 468:{f.Push(JValue.I(0));f.Pc=469;continue;}
case 469:{f.Push(f.Locals[6]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",474);}
case 474:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",478);}
case 478:{f.Locals[8]=f.Pop();f.Pc=480;continue;}
case 480:{f.Pc=538;continue;}
case 483:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",486);}
case 486:{f.Push(JValue.R(rt.String("lblChooseSpecifiedRangeColors")));f.Pc=488;continue;}
case 488:{f.Push(JValue.I(2));f.Pc=489;continue;}
case 489:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=492;continue;}
case 492:{f.StackOp("dup");f.Pc=493;continue;}
case 493:{f.Push(JValue.I(0));f.Pc=494;continue;}
case 494:{f.Push(f.Locals[6]);f.Pc=496;continue;}
case 496:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",499);}
case 499:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=500;continue;}
case 500:{f.StackOp("dup");f.Pc=501;continue;}
case 501:{f.Push(JValue.I(1));f.Pc=502;continue;}
case 502:{f.Push(f.Locals[7]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",507);}
case 507:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",511);}
case 511:{f.Locals[8]=f.Pop();f.Pc=513;continue;}
case 513:{f.Pc=538;continue;}
case 516:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",519);}
case 519:{f.Push(JValue.R(rt.String("lblChooseNColors")));f.Pc=521;continue;}
case 521:{f.Push(JValue.I(1));f.Pc=522;continue;}
case 522:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=525;continue;}
case 525:{f.StackOp("dup");f.Pc=526;continue;}
case 526:{f.Push(JValue.I(0));f.Pc=527;continue;}
case 527:{f.Push(f.Locals[7]);f.Pc=529;continue;}
case 529:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",532);}
case 532:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=533;continue;}
case 533:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",536);}
case 536:{f.Locals[8]=f.Pop();f.Pc=538;continue;}
case 538:{if(!rt.StaticReady(f,"forge/card/ColorSet","C","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","C","Lforge/card/ColorSet;"));f.Pc=541;continue;}
case 541:{f.Locals[9]=f.Pop();f.Pc=543;continue;}
case 543:{f.Push(f.Locals[5]);f.Pc=545;continue;}
case 545:{f.Locals[10]=f.Pop();f.Pc=547;continue;}
case 547:{f.Push(f.Locals[1]);f.Pc=548;continue;}
case 548:{f.Push(JValue.R(rt.String("Random")));f.Pc=550;continue;}
case 550:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",553);}
case 553:{f.Pc=f.Pop().Int==0?625:556;continue;}
case 556:{f.Push(JValue.I(0));f.Pc=557;continue;}
case 557:{f.Locals[12]=f.Pop();f.Pc=559;continue;}
case 559:{f.Push(f.Locals[12]);f.Pc=561;continue;}
case 561:{f.Push(f.Locals[6]);f.Pc=563;continue;}
case 563:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?619:566;continue;}
case 566:{f.Push(f.Locals[3]);f.Pc=567;continue;}
case 567:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",570);}
case 570:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=573;continue;}
case 573:{f.Locals[11]=f.Pop();f.Pc=575;continue;}
case 575:{f.Push(f.Locals[3]);f.Pc=576;continue;}
case 576:{f.Push(f.Locals[11]);f.Pc=578;continue;}
case 578:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",583);}
case 583:{f.StackOp("pop");f.Pc=584;continue;}
case 584:{f.Push(JValue.I(2));f.Pc=585;continue;}
case 585:{f.Push(JValue.R(rt.NewArray("Lforge/card/ColorSet;",f.Pop().Int)));f.Pc=588;continue;}
case 588:{f.StackOp("dup");f.Pc=589;continue;}
case 589:{f.Push(JValue.I(0));f.Pc=590;continue;}
case 590:{f.Push(f.Locals[9]);f.Pc=592;continue;}
case 592:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=593;continue;}
case 593:{f.StackOp("dup");f.Pc=594;continue;}
case 594:{f.Push(JValue.I(1));f.Pc=595;continue;}
case 595:{f.Push(JValue.I(1));f.Pc=596;continue;}
case 596:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=599;continue;}
case 599:{f.StackOp("dup");f.Pc=600;continue;}
case 600:{f.Push(JValue.I(0));f.Pc=601;continue;}
case 601:{f.Push(f.Locals[11]);f.Pc=603;continue;}
case 603:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=604;continue;}
case 604:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",607);}
case 607:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=608;continue;}
case 608:{return rt.Call(f,"forge/card/ColorSet","combine","([Lforge/card/ColorSet;)Lforge/card/ColorSet;","invokestatic",611);}
case 611:{f.Locals[9]=f.Pop();f.Pc=613;continue;}
case 613:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=616;continue;}
case 616:{f.Pc=559;continue;}
case 619:{f.Push(JValue.R(null));f.Pc=620;continue;}
case 620:{f.Locals[10]=f.Pop();f.Pc=622;continue;}
case 622:{f.Pc=646;continue;}
case 625:{f.Push(f.Locals[5]);f.Pc=627;continue;}
case 627:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",630);}
case 630:{f.Push(f.Locals[8]);f.Pc=632;continue;}
case 632:{f.Push(f.Locals[1]);f.Pc=633;continue;}
case 633:{f.Push(f.Locals[6]);f.Pc=635;continue;}
case 635:{f.Push(f.Locals[7]);f.Pc=637;continue;}
case 637:{f.Push(f.Locals[3]);f.Pc=638;continue;}
case 638:{return rt.Call(f,"forge/card/ColorSet","fromNames","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",641);}
case 641:{return rt.Call(f,"forge/game/player/PlayerController","chooseColors","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;IILforge/card/ColorSet;)Lforge/card/ColorSet;","invokevirtual",644);}
case 644:{f.Locals[9]=f.Pop();f.Pc=646;continue;}
case 646:{f.Push(f.Locals[9]);f.Pc=648;continue;}
case 648:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",651);}
case 651:{f.Pc=f.Pop().Int==0?655:654;continue;}
case 654:{return JStep.ReturnVoid;}
case 655:{f.Push(f.Locals[2]);f.Pc=656;continue;}
case 656:{f.Push(f.Locals[9]);f.Pc=658;continue;}
case 658:{return rt.Call(f,"forge/card/ColorSet","stream","()Ljava/util/stream/Stream;","invokevirtual",661);}
case 661:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseColorEffect:3147:661:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",666);}
case 666:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",671);}
case 671:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",674);}
case 674:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",679);}
case 679:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=682;continue;}
case 682:{return rt.Call(f,"forge/game/card/Card","setChosenColors","(Ljava/util/List;)V","invokevirtual",685);}
case 685:{f.Push(f.Locals[9]);f.Pc=687;continue;}
case 687:{return rt.Call(f,"forge/card/ColorSet","stream","()Ljava/util/stream/Stream;","invokevirtual",690);}
case 690:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseColorEffect:3147:690:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",695);}
case 695:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",700);}
case 700:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",703);}
case 703:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",708);}
case 708:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=711;continue;}
case 711:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",714);}
case 714:{f.Locals[11]=f.Pop();f.Pc=716;continue;}
case 716:{f.Push(f.Locals[5]);f.Pc=718;continue;}
case 718:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",721);}
case 721:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",724);}
case 724:{f.Push(f.Locals[1]);f.Pc=725;continue;}
case 725:{f.Push(f.Locals[5]);f.Pc=727;continue;}
case 727:{f.Push(f.Locals[11]);f.Pc=729;continue;}
case 729:{f.Push(f.Locals[10]);f.Pc=731;continue;}
case 731:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",734);}
case 734:{f.Pc=318;continue;}
case 737:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

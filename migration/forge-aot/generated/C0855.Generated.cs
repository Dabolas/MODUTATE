// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C855{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityFlipCoinMod","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10015,"forge/game/staticability/StaticAbilityFlipCoinMod","<init>","()V",1,1,1,new JHandler[]{},M10015));
c.Add(new JMethod(10016,"forge/game/staticability/StaticAbilityFlipCoinMod","fixedResult","(Lforge/game/player/Player;)Ljava/lang/Boolean;",9,1,2,new JHandler[]{},M10016));
c.Add(new JMethod(10017,"forge/game/staticability/StaticAbilityFlipCoinMod","getFlipMultiplier","(Lforge/game/player/Player;)I",9,1,3,new JHandler[]{},M10017));
c.Add(new JMethod(10018,"forge/game/staticability/StaticAbilityFlipCoinMod","filterStaticAbilities","(Lforge/game/player/Player;Lforge/game/staticability/StaticAbilityMode;)Ljava/util/stream/Stream;",10,2,3,new JHandler[]{},M10018));
c.Add(new JMethod(10019,"forge/game/staticability/StaticAbilityFlipCoinMod","lambda$filterStaticAbilities$2","(Lforge/game/staticability/StaticAbilityMode;Lforge/game/player/Player;Lforge/game/staticability/StaticAbility;)Z",4106,3,3,new JHandler[]{},M10019));
c.Add(new JMethod(10020,"forge/game/staticability/StaticAbilityFlipCoinMod","lambda$filterStaticAbilities$1","(Lforge/game/card/Card;)Ljava/util/stream/Stream;",4106,1,1,new JHandler[]{},M10020));
c.Add(new JMethod(10021,"forge/game/staticability/StaticAbilityFlipCoinMod","lambda$fixedResult$0","(Lforge/game/staticability/StaticAbility;)Ljava/lang/Boolean;",4106,1,2,new JHandler[]{},M10021));
}

internal static JStep M10015(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10016(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","FlipCoinMod","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","FlipCoinMod","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbilityFlipCoinMod","filterStaticAbilities","(Lforge/game/player/Player;Lforge/game/staticability/StaticAbilityMode;)Ljava/util/stream/Stream;","invokestatic",7);}
case 7:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityFlipCoinMod:10016:7:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",12);}
case 12:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/stream/Stream","findFirst","()Ljava/util/Optional;","invokeinterface",22);}
case 22:{f.Push(JValue.R(null));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Optional","orElse","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10017(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","FlipCoinDoubler","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","FlipCoinDoubler","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/staticability/StaticAbilityFlipCoinMod","filterStaticAbilities","(Lforge/game/player/Player;Lforge/game/staticability/StaticAbilityMode;)Ljava/util/stream/Stream;","invokestatic",8);}
case 8:{return rt.Call(f,"java/util/stream/Stream","count","()J","invokeinterface",13);}
case 13:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=14;continue;}
case 14:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ishl",a,b));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10018(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/card/CardCollectionView","stream","()Ljava/util/stream/Stream;","invokeinterface",15);}
case 15:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityFlipCoinMod:10018:15:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",20);}
case 20:{return rt.Call(f,"java/util/stream/Stream","flatMap","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",25);}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityFlipCoinMod:10018:27:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/staticability/StaticAbilityMode;Lforge/game/player/Player;)Ljava/util/function/Predicate;",32);}
case 32:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",37);}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10019(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?22:8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10020(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/util/collect/FCollectionView","stream","()Ljava/util/stream/Stream;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10021(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Result")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",6);}
case 6:{return rt.Call(f,"java/lang/Boolean","valueOf","(Ljava/lang/String;)Ljava/lang/Boolean;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

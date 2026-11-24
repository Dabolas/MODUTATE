// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C717{
internal static JClass Build(){var c=new JClass("forge/game/player/PlayerPredicates","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("NOT_LOST","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JMethod(8635,"forge/game/player/PlayerPredicates","<init>","()V",1,1,1,new JHandler[]{},M8635));
c.Add(new JMethod(8636,"forge/game/player/PlayerPredicates","isTargetableBy","(Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;",9,1,2,new JHandler[]{},M8636));
c.Add(new JMethod(8637,"forge/game/player/PlayerPredicates","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;",9,2,2,new JHandler[]{},M8637));
c.Add(new JMethod(8638,"forge/game/player/PlayerPredicates","isOpponentOf","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M8638));
c.Add(new JMethod(8639,"forge/game/player/PlayerPredicates","sameTeam","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",9,1,2,new JHandler[]{},M8639));
c.Add(new JMethod(8640,"forge/game/player/PlayerPredicates","isCardInPlay","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M8640));
c.Add(new JMethod(8641,"forge/game/player/PlayerPredicates","isNotCardInPlay","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M8641));
c.Add(new JMethod(8642,"forge/game/player/PlayerPredicates","hasCounters","()Ljava/util/function/Predicate;",9,0,1,new JHandler[]{},M8642));
c.Add(new JMethod(8643,"forge/game/player/PlayerPredicates","lifeLessOrEqualTo","(I)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M8643));
c.Add(new JMethod(8644,"forge/game/player/PlayerPredicates","lifeGreaterOrEqualTo","(I)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M8644));
c.Add(new JMethod(8645,"forge/game/player/PlayerPredicates","hasCounter","(Lforge/game/card/CounterType;)Ljava/util/function/Predicate;",9,1,2,new JHandler[]{},M8645));
c.Add(new JMethod(8646,"forge/game/player/PlayerPredicates","hasCounter","(Lforge/game/card/CounterType;I)Ljava/util/function/Predicate;",9,2,2,new JHandler[]{},M8646));
c.Add(new JMethod(8647,"forge/game/player/PlayerPredicates","hasKeyword","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M8647));
c.Add(new JMethod(8648,"forge/game/player/PlayerPredicates","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;",9,2,2,new JHandler[]{},M8648));
c.Add(new JMethod(8649,"forge/game/player/PlayerPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;",9,4,4,new JHandler[]{},M8649));
c.Add(new JMethod(8650,"forge/game/player/PlayerPredicates","compareByZoneSize","(Lforge/game/zone/ZoneType;)Ljava/util/Comparator;",9,1,1,new JHandler[]{},M8650));
c.Add(new JMethod(8651,"forge/game/player/PlayerPredicates","compareByZoneSize","(Lforge/game/zone/ZoneType;Ljava/util/function/Predicate;)Ljava/util/Comparator;",9,2,2,new JHandler[]{},M8651));
c.Add(new JMethod(8652,"forge/game/player/PlayerPredicates","compareByLife","()Ljava/util/Comparator;",9,0,1,new JHandler[]{},M8652));
c.Add(new JMethod(8653,"forge/game/player/PlayerPredicates","compareByPoison","()Ljava/util/Comparator;",9,0,1,new JHandler[]{},M8653));
c.Add(new JMethod(8654,"forge/game/player/PlayerPredicates","lambda$static$11","(Lforge/game/player/Player;)Z",4106,1,1,new JHandler[]{},M8654));
c.Add(new JMethod(8655,"forge/game/player/PlayerPredicates","lambda$compareByZoneSize$10","(Lforge/game/zone/ZoneType;Ljava/util/function/Predicate;Lforge/game/player/Player;)I",4106,3,2,new JHandler[]{},M8655));
c.Add(new JMethod(8656,"forge/game/player/PlayerPredicates","lambda$compareByZoneSize$9","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;)I",4106,2,2,new JHandler[]{},M8656));
c.Add(new JMethod(8657,"forge/game/player/PlayerPredicates","lambda$restriction$8","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Z",4106,5,5,new JHandler[]{},M8657));
c.Add(new JMethod(8658,"forge/game/player/PlayerPredicates","lambda$canBeAttached$7","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z",4106,3,3,new JHandler[]{},M8658));
c.Add(new JMethod(8659,"forge/game/player/PlayerPredicates","lambda$hasKeyword$6","(Ljava/lang/String;Lforge/game/player/Player;)Z",4106,2,2,new JHandler[]{},M8659));
c.Add(new JMethod(8660,"forge/game/player/PlayerPredicates","lambda$hasCounter$5","(Lforge/game/card/CounterType;ILforge/game/player/Player;)Z",4106,3,2,new JHandler[]{},M8660));
c.Add(new JMethod(8661,"forge/game/player/PlayerPredicates","lambda$lifeGreaterOrEqualTo$4","(ILforge/game/player/Player;)Z",4106,2,2,new JHandler[]{},M8661));
c.Add(new JMethod(8662,"forge/game/player/PlayerPredicates","lambda$lifeLessOrEqualTo$3","(ILforge/game/player/Player;)Z",4106,2,2,new JHandler[]{},M8662));
c.Add(new JMethod(8663,"forge/game/player/PlayerPredicates","lambda$isCardInPlay$2","(Ljava/lang/String;Lforge/game/player/Player;)Z",4106,2,2,new JHandler[]{},M8663));
c.Add(new JMethod(8664,"forge/game/player/PlayerPredicates","lambda$isOpponentOf$1","(Lforge/game/player/Player;Lforge/game/player/Player;)Z",4106,2,2,new JHandler[]{},M8664));
c.Add(new JMethod(8665,"forge/game/player/PlayerPredicates","lambda$canDiscardBy$0","(Lforge/game/spellability/SpellAbility;ZLforge/game/player/Player;)Z",4106,3,3,new JHandler[]{},M8665));
c.Add(new JMethod(8666,"forge/game/player/PlayerPredicates","<clinit>","()V",8,0,1,new JHandler[]{},M8666));
}

internal static JStep M8635(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8636(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",5);}
case 5:{f.StackOp("pop");f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8636:6:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8637(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8637:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8638(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8638:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8639(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",5);}
case 5:{f.StackOp("pop");f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8639:6:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8640(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8640:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8641(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/PlayerPredicates","isCardInPlay","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",4);}
case 4:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8642(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8642:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8643(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8643:1:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8644(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8644:1:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8645(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/PlayerPredicates","hasCounter","(Lforge/game/card/CounterType;I)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8646(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8646:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CounterType;I)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8647(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8647:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/lang/String;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8648(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8648:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8649(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8649:4:java/lang/invoke/LambdaMetafactory.metafactory","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8650(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8650:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/zone/ZoneType;)Ljava/util/function/ToIntFunction;",6);}
case 6:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8651(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8651:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/zone/ZoneType;Ljava/util/function/Predicate;)Ljava/util/function/ToIntFunction;",7);}
case 7:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8652(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8652:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",5);}
case 5:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8653(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8653:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",5);}
case 5:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8654(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?17:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/player/Player","getOutcome","()Lforge/game/player/PlayerOutcome;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/player/PlayerOutcome","hasWon","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8655(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8656(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8657(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[4]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Reference==null?21:5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8658(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/player/Player","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8659(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8660(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?13:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8661(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8662(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8663(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","isCardInPlay","(Ljava/lang/String;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8664(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8665(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/player/Player","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8666(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/player/PlayerPredicates:8666:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{if(!rt.StaticReady(f,"forge/game/player/PlayerPredicates","NOT_LOST","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/game/player/PlayerPredicates","NOT_LOST","Ljava/util/function/Predicate;",f.Pop());f.Pc=8;continue;}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C461{
internal static JClass Build(){var c=new JClass("forge/game/card/CardLists","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("ToughnessComparator","Ljava/util/Comparator;",true,JValue.Default("Ljava/util/Comparator;"),null));
c.Add(new JField("ToughnessComparatorInv","Ljava/util/Comparator;",true,JValue.Default("Ljava/util/Comparator;"),null));
c.Add(new JField("PowerComparator","Ljava/util/Comparator;",true,JValue.Default("Ljava/util/Comparator;"),null));
c.Add(new JField("CmcComparator","Ljava/util/Comparator;",true,JValue.Default("Ljava/util/Comparator;"),null));
c.Add(new JField("CmcComparatorInv","Ljava/util/Comparator;",true,JValue.Default("Ljava/util/Comparator;"),null));
c.Add(new JField("TextLenComparator","Ljava/util/Comparator;",true,JValue.Default("Ljava/util/Comparator;"),null));
c.Add(new JMethod(5056,"forge/game/card/CardLists","<init>","()V",1,1,1,new JHandler[]{},M5056));
c.Add(new JMethod(5057,"forge/game/card/CardLists","filterToughness","(Ljava/lang/Iterable;I)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5057));
c.Add(new JMethod(5058,"forge/game/card/CardLists","filterPower","(Ljava/lang/Iterable;I)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5058));
c.Add(new JMethod(5059,"forge/game/card/CardLists","filterLEPower","(Ljava/lang/Iterable;I)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5059));
c.Add(new JMethod(5060,"forge/game/card/CardLists","filterAnyCounters","(Ljava/lang/Iterable;I)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5060));
c.Add(new JMethod(5061,"forge/game/card/CardLists","sortByCmcDesc","(Ljava/util/List;)V",9,1,2,new JHandler[]{},M5061));
c.Add(new JMethod(5062,"forge/game/card/CardLists","sortByToughnessAsc","(Ljava/util/List;)V",9,1,2,new JHandler[]{},M5062));
c.Add(new JMethod(5063,"forge/game/card/CardLists","sortByToughnessDesc","(Ljava/util/List;)V",9,1,2,new JHandler[]{},M5063));
c.Add(new JMethod(5064,"forge/game/card/CardLists","sortByPowerAsc","(Ljava/util/List;)V",9,1,2,new JHandler[]{},M5064));
c.Add(new JMethod(5065,"forge/game/card/CardLists","sortByPowerDesc","(Ljava/util/List;)V",9,1,2,new JHandler[]{},M5065));
c.Add(new JMethod(5066,"forge/game/card/CardLists","getRandomSubList","(Ljava/util/List;I)Lforge/game/card/CardCollection;",9,4,3,new JHandler[]{},M5066));
c.Add(new JMethod(5067,"forge/game/card/CardLists","shuffle","(Ljava/util/List;)V",9,1,2,new JHandler[]{},M5067));
c.Add(new JMethod(5068,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5068));
c.Add(new JMethod(5069,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/util/collect/FCollectionView;)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5069));
c.Add(new JMethod(5070,"forge/game/card/CardLists","filterControlledByAsList","(Ljava/lang/Iterable;Lforge/game/player/Player;)Ljava/util/List;",9,2,2,new JHandler[]{},M5070));
c.Add(new JMethod(5071,"forge/game/card/CardLists","filterControlledByAsList","(Ljava/lang/Iterable;Lforge/util/collect/FCollectionView;)Ljava/util/List;",9,2,2,new JHandler[]{},M5071));
c.Add(new JMethod(5072,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;",9,5,5,new JHandler[]{},M5072));
c.Add(new JMethod(5073,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;",9,5,5,new JHandler[]{},M5073));
c.Add(new JMethod(5074,"forge/game/card/CardLists","getValidCardsAsList","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/List;",9,5,5,new JHandler[]{},M5074));
c.Add(new JMethod(5075,"forge/game/card/CardLists","getValidCardCount","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)I",9,5,5,new JHandler[]{},M5075));
c.Add(new JMethod(5076,"forge/game/card/CardLists","getTargetableCards","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;",9,10,2,new JHandler[]{},M5076));
c.Add(new JMethod(5077,"forge/game/card/CardLists","canSubsequentlyTarget","(Lforge/game/card/CardCollection;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;",9,2,3,new JHandler[]{},M5077));
c.Add(new JMethod(5078,"forge/game/card/CardLists","getKeyword","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5078));
c.Add(new JMethod(5079,"forge/game/card/CardLists","getKeyword","(Ljava/lang/Iterable;Lforge/game/keyword/Keyword;)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5079));
c.Add(new JMethod(5080,"forge/game/card/CardLists","getNotKeyword","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5080));
c.Add(new JMethod(5081,"forge/game/card/CardLists","getNotKeyword","(Ljava/lang/Iterable;Lforge/game/keyword/Keyword;)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5081));
c.Add(new JMethod(5082,"forge/game/card/CardLists","getAmountOfKeyword","(Ljava/lang/Iterable;Ljava/lang/String;)I",9,5,3,new JHandler[]{},M5082));
c.Add(new JMethod(5083,"forge/game/card/CardLists","getAmountOfKeyword","(Ljava/lang/Iterable;Lforge/game/keyword/Keyword;)I",9,5,3,new JHandler[]{},M5083));
c.Add(new JMethod(5084,"forge/game/card/CardLists","getNotType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5084));
c.Add(new JMethod(5085,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5085));
c.Add(new JMethod(5086,"forge/game/card/CardLists","getNotColor","(Ljava/lang/Iterable;B)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5086));
c.Add(new JMethod(5087,"forge/game/card/CardLists","getColor","(Ljava/lang/Iterable;B)Lforge/game/card/CardCollection;",9,2,2,new JHandler[]{},M5087));
c.Add(new JMethod(5088,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;",9,2,4,new JHandler[]{},M5088));
c.Add(new JMethod(5089,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;",9,3,5,new JHandler[]{},M5089));
c.Add(new JMethod(5090,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/lang/Iterable;)Lforge/game/card/CardCollection;",9,2,4,new JHandler[]{},M5090));
c.Add(new JMethod(5091,"forge/game/card/CardLists","filterAsList","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/util/List;",9,2,2,new JHandler[]{},M5091));
c.Add(new JMethod(5092,"forge/game/card/CardLists","filterAsList","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Predicate;)Ljava/util/List;",9,3,3,new JHandler[]{},M5092));
c.Add(new JMethod(5093,"forge/game/card/CardLists","filterAsList","(Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljava/util/List;",9,2,2,new JHandler[]{},M5093));
c.Add(new JMethod(5094,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I",9,5,2,new JHandler[]{},M5094));
c.Add(new JMethod(5095,"forge/game/card/CardLists","getCardsWithHighestCMC","(Ljava/lang/Iterable;)Lforge/game/card/CardCollection;",9,6,2,new JHandler[]{},M5095));
c.Add(new JMethod(5096,"forge/game/card/CardLists","getCardsWithLowestCMC","(Ljava/lang/Iterable;)Lforge/game/card/CardCollection;",9,6,2,new JHandler[]{},M5096));
c.Add(new JMethod(5097,"forge/game/card/CardLists","getTotalPower","(Ljava/lang/Iterable;Lforge/game/CardTraitBase;)I",9,6,4,new JHandler[]{},M5097));
c.Add(new JMethod(5098,"forge/game/card/CardLists","getTotalChroma","(Ljava/lang/Iterable;B)I",9,7,2,new JHandler[]{},M5098));
c.Add(new JMethod(5099,"forge/game/card/CardLists","getTotalCMC","(Ljava/lang/Iterable;)I",9,4,3,new JHandler[]{},M5099));
c.Add(new JMethod(5100,"forge/game/card/CardLists","cmcCanSumTo","(ILjava/lang/Iterable;)Z",9,6,2,new JHandler[]{},M5100));
c.Add(new JMethod(5101,"forge/game/card/CardLists","isSubsetSum","(Ljava/util/List;I)Z",9,4,3,new JHandler[]{},M5101));
c.Add(new JMethod(5102,"forge/game/card/CardLists","getDifferentNamesCount","(Ljava/lang/Iterable;)I",9,5,6,new JHandler[]{},M5102));
c.Add(new JMethod(5103,"forge/game/card/CardLists","lambda$getDifferentNamesCount$8","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5103));
c.Add(new JMethod(5104,"forge/game/card/CardLists","lambda$getDifferentNamesCount$7","(Ljava/util/List;Ljava/util/List;)Ljava/util/List;",4106,2,2,new JHandler[]{},M5104));
c.Add(new JMethod(5105,"forge/game/card/CardLists","lambda$getDifferentNamesCount$6","(Ljava/util/List;Lforge/game/card/Card;)V",4106,2,2,new JHandler[]{},M5105));
c.Add(new JMethod(5106,"forge/game/card/CardLists","lambda$getDifferentNamesCount$5","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5106));
c.Add(new JMethod(5107,"forge/game/card/CardLists","lambda$static$4","(Lforge/game/card/Card;)I",4106,1,1,new JHandler[]{},M5107));
c.Add(new JMethod(5108,"forge/game/card/CardLists","lambda$filterAnyCounters$3","(ILforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5108));
c.Add(new JMethod(5109,"forge/game/card/CardLists","lambda$filterLEPower$2","(ILforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5109));
c.Add(new JMethod(5110,"forge/game/card/CardLists","lambda$filterPower$1","(ILforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5110));
c.Add(new JMethod(5111,"forge/game/card/CardLists","lambda$filterToughness$0","(ILforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5111));
c.Add(new JMethod(5112,"forge/game/card/CardLists","<clinit>","()V",8,0,1,new JHandler[]{},M5112));
}

internal static JStep M5056(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5057(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/CardLists:5057:2:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",7);}
case 7:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5058(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/CardLists:5058:2:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",7);}
case 7:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5059(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/CardLists:5059:2:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",7);}
case 7:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5060(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/CardLists:5060:2:java/lang/invoke/LambdaMetafactory.metafactory","(I)Ljava/util/function/Predicate;",7);}
case 7:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5061(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/card/CardLists","CmcComparatorInv","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardLists","CmcComparatorInv","Ljava/util/Comparator;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5062(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/card/CardLists","ToughnessComparator","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardLists","ToughnessComparator","Ljava/util/Comparator;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5063(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/card/CardLists","ToughnessComparatorInv","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardLists","ToughnessComparatorInv","Ljava/util/Comparator;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5064(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/card/CardLists","PowerComparator","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardLists","PowerComparator","Ljava/util/Comparator;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5065(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/card/CardLists","PowerComparator","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardLists","PowerComparator","Ljava/util/Comparator;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Collections","reverseOrder","(Ljava/util/Comparator;)Ljava/util/Comparator;","invokestatic",7);}
case 7:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5066(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?12:10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",28);}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",33);}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?57:37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/CardLists","shuffle","(Ljava/util/List;)V","invokestatic",41);}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/CardCollection","remove","(I)Ljava/lang/Object;","invokevirtual",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Pc=29;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5067(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",4);}
case 4:{return rt.Call(f,"java/util/Collections","shuffle","(Ljava/util/List;Ljava/util/Random;)V","invokestatic",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5068(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","isController","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5069(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","isControlledByAnyOf","(Lforge/util/collect/FCollectionView;)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5070(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","isController","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/card/CardLists","filterAsList","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/util/List;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5071(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","isControlledByAnyOf","(Lforge/util/collect/FCollectionView;)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/card/CardLists","filterAsList","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/util/List;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5072(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",9);}
case 9:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5073(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String(",")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[4]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",14);}
case 14:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5074(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String(",")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[4]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",14);}
case 14:{return rt.Call(f,"forge/game/card/CardLists","filterAsList","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/util/List;","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5075(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String(",")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[4]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",14);}
case 14:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",17);}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5076(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","isTargetableBy","(Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/spellability/TargetChoices","isEmpty","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?396:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?396:26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMinTargets","()I","invokevirtual",30);}
case 30:{f.Push(JValue.I(2));f.Pc=31;continue;}
case 31:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?396:34;continue;}
case 34:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",41);}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",46);}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",52);}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[5]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",61);}
case 61:{f.Pc=f.Pop().Int==0?390:64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{f.Locals[6]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isSameController","()Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?156:84;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{f.Locals[7]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",91);}
case 91:{f.Locals[8]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[8]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",100);}
case 100:{f.Pc=f.Pop().Int==0?144:103;continue;}
case 103:{f.Push(f.Locals[8]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",110);}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{f.Locals[9]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[6]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[9]);f.Pc=119;continue;}
case 119:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?141:122;continue;}
case 122:{f.Push(f.Locals[6]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",127);}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",132);}
case 132:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?141:135;continue;}
case 135:{f.Push(JValue.I(1));f.Pc=136;continue;}
case 136:{f.Locals[7]=f.Pop();f.Pc=138;continue;}
case 138:{f.Pc=144;continue;}
case 141:{f.Pc=93;continue;}
case 144:{f.Push(f.Locals[7]);f.Pc=146;continue;}
case 146:{f.Pc=f.Pop().Int!=0?156:149;continue;}
case 149:{f.Push(f.Locals[3]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[6]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",155);}
case 155:{f.StackOp("pop");f.Pc=156;continue;}
case 156:{f.Push(f.Locals[4]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isWithoutSameCreatureType","()Z","invokevirtual",161);}
case 161:{f.Pc=f.Pop().Int==0?233:164;continue;}
case 164:{f.Push(JValue.I(0));f.Pc=165;continue;}
case 165:{f.Locals[7]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[2]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",171);}
case 171:{f.Locals[8]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[8]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",180);}
case 180:{f.Pc=f.Pop().Int==0?221:183;continue;}
case 183:{f.Push(f.Locals[8]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",190);}
case 190:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=193;continue;}
case 193:{f.Locals[9]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[6]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[9]);f.Pc=199;continue;}
case 199:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?218:202;continue;}
case 202:{f.Push(f.Locals[6]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[9]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/card/Card","sharesCreatureTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",209);}
case 209:{f.Pc=f.Pop().Int!=0?218:212;continue;}
case 212:{f.Push(JValue.I(1));f.Pc=213;continue;}
case 213:{f.Locals[7]=f.Pop();f.Pc=215;continue;}
case 215:{f.Pc=221;continue;}
case 218:{f.Pc=173;continue;}
case 221:{f.Push(f.Locals[7]);f.Pc=223;continue;}
case 223:{f.Pc=f.Pop().Int!=0?233:226;continue;}
case 226:{f.Push(f.Locals[3]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[6]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",232);}
case 232:{f.StackOp("pop");f.Pc=233;continue;}
case 233:{f.Push(f.Locals[4]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isWithSameCreatureType","()Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int==0?310:241;continue;}
case 241:{f.Push(JValue.I(0));f.Pc=242;continue;}
case 242:{f.Locals[7]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(f.Locals[2]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",248);}
case 248:{f.Locals[8]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(f.Locals[8]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",257);}
case 257:{f.Pc=f.Pop().Int==0?298:260;continue;}
case 260:{f.Push(f.Locals[8]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",267);}
case 267:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=270;continue;}
case 270:{f.Locals[9]=f.Pop();f.Pc=272;continue;}
case 272:{f.Push(f.Locals[6]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[9]);f.Pc=276;continue;}
case 276:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?295:279;continue;}
case 279:{f.Push(f.Locals[6]);f.Pc=281;continue;}
case 281:{f.Push(f.Locals[9]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/card/Card","sharesCreatureTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",286);}
case 286:{f.Pc=f.Pop().Int==0?295:289;continue;}
case 289:{f.Push(JValue.I(1));f.Pc=290;continue;}
case 290:{f.Locals[7]=f.Pop();f.Pc=292;continue;}
case 292:{f.Pc=298;continue;}
case 295:{f.Pc=250;continue;}
case 298:{f.Push(f.Locals[7]);f.Pc=300;continue;}
case 300:{f.Pc=f.Pop().Int!=0?310:303;continue;}
case 303:{f.Push(f.Locals[3]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[6]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",309);}
case 309:{f.StackOp("pop");f.Pc=310;continue;}
case 310:{f.Push(f.Locals[4]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isWithSameCardType","()Z","invokevirtual",315);}
case 315:{f.Pc=f.Pop().Int==0?387:318;continue;}
case 318:{f.Push(JValue.I(0));f.Pc=319;continue;}
case 319:{f.Locals[7]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[2]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",325);}
case 325:{f.Locals[8]=f.Pop();f.Pc=327;continue;}
case 327:{f.Push(f.Locals[8]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",334);}
case 334:{f.Pc=f.Pop().Int==0?375:337;continue;}
case 337:{f.Push(f.Locals[8]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",344);}
case 344:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=347;continue;}
case 347:{f.Locals[9]=f.Pop();f.Pc=349;continue;}
case 349:{f.Push(f.Locals[6]);f.Pc=351;continue;}
case 351:{f.Push(f.Locals[9]);f.Pc=353;continue;}
case 353:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?372:356;continue;}
case 356:{f.Push(f.Locals[6]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[9]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/card/Card","sharesCardTypeWith","(Lforge/game/card/Card;)Z","invokevirtual",363);}
case 363:{f.Pc=f.Pop().Int==0?372:366;continue;}
case 366:{f.Push(JValue.I(1));f.Pc=367;continue;}
case 367:{f.Locals[7]=f.Pop();f.Pc=369;continue;}
case 369:{f.Pc=375;continue;}
case 372:{f.Pc=327;continue;}
case 375:{f.Push(f.Locals[7]);f.Pc=377;continue;}
case 377:{f.Pc=f.Pop().Int!=0?387:380;continue;}
case 380:{f.Push(f.Locals[3]);f.Pc=381;continue;}
case 381:{f.Push(f.Locals[6]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",386);}
case 386:{f.StackOp("pop");f.Pc=387;continue;}
case 387:{f.Pc=54;continue;}
case 390:{f.Push(f.Locals[2]);f.Pc=391;continue;}
case 391:{f.Push(f.Locals[3]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",395);}
case 395:{f.StackOp("pop");f.Pc=396;continue;}
case 396:{f.Push(f.Locals[2]);f.Pc=397;continue;}
case 397:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5077(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/spellability/TargetChoices","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",18);}
case 18:{f.StackOp("pop");f.Pc=19;continue;}
case 19:{return rt.DynamicCall(f,"forge/game/card/CardLists:5077:19:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;",24);}
case 24:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",27);}
case 27:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5078(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","hasKeyword","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5079(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","hasKeyword","(Lforge/game/keyword/Keyword;)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5080(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","hasKeyword","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",10);}
case 10:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5081(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","hasKeyword","(Lforge/game/keyword/Keyword;)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",10);}
case 10:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5082(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?41:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","getAmountOfKeyword","(Ljava/lang/String;)I","invokevirtual",36);}
case 36:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=37;continue;}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Pc=9;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5083(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?41:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","getAmountOfKeyword","(Lforge/game/keyword/Keyword;)I","invokevirtual",36);}
case 36:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=37;continue;}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Pc=9;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5084(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","isType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",10);}
case 10:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5085(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","isType","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5086(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","isColor","(B)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",10);}
case 10:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5087(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPredicates","isColor","(B)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5088(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",9);}
case 9:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5089(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",15);}
case 15:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5090(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/util/IterableUtil","and","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;","invokestatic",9);}
case 9:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",12);}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5091(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",5);}
case 5:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5092(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",8);}
case 8:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",11);}
case 11:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5093(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/IterableUtil","and","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",8);}
case 8:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5094(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?52:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",43);}
case 43:{f.Pc=f.Pop().Int==0?49:46;continue;}
case 46:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=49;continue;}
case 49:{f.Pc=15;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5095(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?73:26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",42);}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?57:50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{f.Locals[2]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",57);}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?70:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Pc=17;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5096(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(25));f.Pc=10;continue;}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?74:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",43);}
case 43:{f.Locals[5]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?58:51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{f.Locals[2]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",58);}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?71:64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Pc=18;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5097(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?79:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/staticability/StaticAbilityTapPowerValue","withToughness","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokestatic",35);}
case 35:{f.Pc=f.Pop().Int==0?53:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",45);}
case 45:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",48);}
case 48:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=49;continue;}
case 49:{f.Locals[2]=f.Pop();f.Pc=50;continue;}
case 50:{f.Pc=76;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/staticability/StaticAbilityTapPowerValue","getMod","(Lforge/game/card/Card;Lforge/game/CardTraitBase;)I","invokestatic",59);}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",68);}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",74);}
case 74:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=75;continue;}
case 75:{f.Locals[2]=f.Pop();f.Pc=76;continue;}
case 76:{f.Pc=9;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5098(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?79:18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/card/mana/ManaCost","iterator","()Ljava/util/Iterator;","invokevirtual",37);}
case 37:{f.Locals[5]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",46);}
case 46:{f.Pc=f.Pop().Int==0?76:49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/card/mana/ManaCostShard","isColor","(B)Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int==0?73:70;continue;}
case 70:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=73;continue;}
case 73:{f.Pc=39;continue;}
case 76:{f.Pc=9;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5099(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?42:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",34);}
case 34:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",37);}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=38;continue;}
case 38:{f.Locals[1]=f.Pop();f.Pc=39;continue;}
case 39:{f.Pc=9;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5100(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?67:20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",36);}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?46:44;continue;}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?64:52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",58);}
case 58:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Pc=11;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",73);}
case 73:{f.Pc=f.Pop().Int==0?78:76;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(null));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",85);}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/card/CardLists","isSubsetSum","(Ljava/util/List;I)Z","invokestatic",90);}
case 90:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5101(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int!=0?6:4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int!=0?19:17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",44);}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?54:48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/CardLists","isSubsetSum","(Ljava/util/List;I)Z","invokestatic",53);}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/CardLists","isSubsetSum","(Ljava/util/List;I)Z","invokestatic",59);}
case 59:{f.Pc=f.Pop().Int!=0?75:62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",68);}
case 68:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/CardLists","isSubsetSum","(Ljava/util/List;I)Z","invokestatic",72);}
case 72:{f.Pc=f.Pop().Int==0?79:75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{f.Pc=80;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5102(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/StreamUtil","stream","(Ljava/lang/Iterable;)Ljava/util/stream/Stream;","invokestatic",4);}
case 4:{return rt.DynamicCall(f,"forge/game/card/CardLists:5102:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",9);}
case 9:{return rt.DynamicCall(f,"forge/game/card/CardLists:5102:9:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",14);}
case 14:{return rt.DynamicCall(f,"forge/game/card/CardLists:5102:14:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiConsumer;",19);}
case 19:{return rt.DynamicCall(f,"forge/game/card/CardLists:5102:19:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BinaryOperator;",24);}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.NewArray("Ljava/util/stream/Collector$Characteristics;",f.Pop().Int)));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/stream/Collector","of","(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;","invokestatic",31);}
case 31:{return rt.Call(f,"java/util/stream/Collectors","partitioningBy","(Ljava/util/function/Predicate;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;","invokestatic",34);}
case 34:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[1]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"java/lang/Boolean","FALSE","Ljava/lang/Boolean;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","FALSE","Ljava/lang/Boolean;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[2]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"java/lang/Boolean","TRUE","Ljava/lang/Boolean;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/Boolean","TRUE","Ljava/lang/Boolean;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",73);}
case 73:{f.Locals[3]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",80);}
case 80:{f.Pc=f.Pop().Int==0?127:83;continue;}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{f.Locals[4]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",100);}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{return rt.DynamicCall(f,"forge/game/card/CardLists:5102:102:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",107);}
case 107:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",112);}
case 112:{f.Pc=f.Pop().Int==0?124:115;continue;}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",123);}
case 123:{f.StackOp("pop");f.Pc=124;continue;}
case 124:{f.Pc=74;continue;}
case 127:{f.Push(f.Locals[2]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",133);}
case 133:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5103(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","sharesNameWith","(Lforge/game/card/Card;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5104(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",7);}
case 7:{f.StackOp("pop");f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5105(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","hasNoName","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?35:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",13);}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.DynamicCall(f,"forge/game/card/CardLists:5105:14:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",19);}
case 19:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?35:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5106(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","sharesNameWith","(Lforge/game/card/Card;)Z","invokevirtual",5);}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5107(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getView","()Lforge/game/card/CardView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/CardView","getText","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5108(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getNumAllCounters","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5109(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5110(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5111(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5112(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/game/card/CardLists:5112:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",5);}
case 5:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",8);}
case 8:{if(!rt.StaticReady(f,"forge/game/card/CardLists","ToughnessComparator","Ljava/util/Comparator;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardLists","ToughnessComparator","Ljava/util/Comparator;",f.Pop());f.Pc=11;continue;}
case 11:{return rt.DynamicCall(f,"forge/game/card/CardLists:5112:11:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",16);}
case 16:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",19);}
case 19:{return rt.Call(f,"java/util/Comparator","reversed","()Ljava/util/Comparator;","invokeinterface",24);}
case 24:{if(!rt.StaticReady(f,"forge/game/card/CardLists","ToughnessComparatorInv","Ljava/util/Comparator;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardLists","ToughnessComparatorInv","Ljava/util/Comparator;",f.Pop());f.Pc=27;continue;}
case 27:{return rt.DynamicCall(f,"forge/game/card/CardLists:5112:27:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",32);}
case 32:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",35);}
case 35:{if(!rt.StaticReady(f,"forge/game/card/CardLists","PowerComparator","Ljava/util/Comparator;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardLists","PowerComparator","Ljava/util/Comparator;",f.Pop());f.Pc=38;continue;}
case 38:{return rt.DynamicCall(f,"forge/game/card/CardLists:5112:38:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",43);}
case 43:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",46);}
case 46:{if(!rt.StaticReady(f,"forge/game/card/CardLists","CmcComparator","Ljava/util/Comparator;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardLists","CmcComparator","Ljava/util/Comparator;",f.Pop());f.Pc=49;continue;}
case 49:{return rt.DynamicCall(f,"forge/game/card/CardLists:5112:49:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",54);}
case 54:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",57);}
case 57:{return rt.Call(f,"java/util/Comparator","reversed","()Ljava/util/Comparator;","invokeinterface",62);}
case 62:{if(!rt.StaticReady(f,"forge/game/card/CardLists","CmcComparatorInv","Ljava/util/Comparator;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardLists","CmcComparatorInv","Ljava/util/Comparator;",f.Pop());f.Pc=65;continue;}
case 65:{return rt.DynamicCall(f,"forge/game/card/CardLists:5112:65:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",70);}
case 70:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",73);}
case 73:{if(!rt.StaticReady(f,"forge/game/card/CardLists","TextLenComparator","Ljava/util/Comparator;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardLists","TextLenComparator","Ljava/util/Comparator;",f.Pop());f.Pc=76;continue;}
case 76:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}

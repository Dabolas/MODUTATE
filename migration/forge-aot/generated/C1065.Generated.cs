// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1065{
internal static JClass Build(){var c=new JClass("forge/item/PaperCardPredicates","java/lang/Object",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("IS_COMMON","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_UNCOMMON","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_RARE","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_MYTHIC_RARE","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_RARE_OR_MYTHIC","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_SPECIAL","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_BASIC_LAND_RARITY","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_BLACK","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_BLUE","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_GREEN","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_RED","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_WHITE","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_COLORLESS","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_UNREBALANCED","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_REBALANCED","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_NON_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_BASIC_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("NOT_BASIC_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("NOT_TRUE_BASIC_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_NONBASIC_LAND","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("IS_CREATURE","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("CAN_BE_COMMANDER","Ljava/util/function/Predicate;",true,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JMethod(11311,"forge/item/PaperCardPredicates","<init>","()V",1,1,1,new JHandler[]{},M11311));
c.Add(new JMethod(11312,"forge/item/PaperCardPredicates","printedInSets","([Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,2,new JHandler[]{},M11312));
c.Add(new JMethod(11313,"forge/item/PaperCardPredicates","printedInSets","(Ljava/util/List;Z)Ljava/util/function/Predicate;",9,2,4,new JHandler[]{},M11313));
c.Add(new JMethod(11314,"forge/item/PaperCardPredicates","printedInSet","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,6,new JHandler[]{},M11314));
c.Add(new JMethod(11315,"forge/item/PaperCardPredicates","printedWithRarity","(Lforge/card/CardRarity;)Ljava/util/function/Predicate;",9,1,3,new JHandler[]{},M11315));
c.Add(new JMethod(11316,"forge/item/PaperCardPredicates","searchableName","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)Ljava/util/function/Predicate;",9,2,4,new JHandler[]{},M11316));
c.Add(new JMethod(11317,"forge/item/PaperCardPredicates","name","(Ljava/lang/String;)Ljava/util/function/Predicate;",9,1,3,new JHandler[]{},M11317));
c.Add(new JMethod(11318,"forge/item/PaperCardPredicates","names","(Ljava/util/List;)Ljava/util/function/Predicate;",9,1,3,new JHandler[]{},M11318));
c.Add(new JMethod(11319,"forge/item/PaperCardPredicates","isFoil","(Z)Ljava/util/function/Predicate;",9,1,3,new JHandler[]{},M11319));
c.Add(new JMethod(11320,"forge/item/PaperCardPredicates","printedInAnyEditions","([Ljava/lang/String;)Ljava/util/function/Predicate;",9,2,3,new JHandler[]{},M11320));
c.Add(new JMethod(11321,"forge/item/PaperCardPredicates","onlyPrintedInEditions","([Ljava/lang/String;)Ljava/util/function/Predicate;",9,2,3,new JHandler[]{},M11321));
c.Add(new JMethod(11322,"forge/item/PaperCardPredicates","isObtainableAnyEdition","()Ljava/util/function/Predicate;",9,0,1,new JHandler[]{},M11322));
c.Add(new JMethod(11323,"forge/item/PaperCardPredicates","isObtainableNotRestricted","([Ljava/lang/String;)Ljava/util/function/Predicate;",9,2,3,new JHandler[]{},M11323));
c.Add(new JMethod(11324,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;",9,1,1,new JHandler[]{},M11324));
c.Add(new JMethod(11325,"forge/item/PaperCardPredicates","lambda$static$11","(Lforge/item/PaperCard;)Z",4106,1,1,new JHandler[]{},M11325));
c.Add(new JMethod(11326,"forge/item/PaperCardPredicates","lambda$fromRules$10","(Ljava/util/function/Predicate;Lforge/item/PaperCard;)Z",4106,2,2,new JHandler[]{},M11326));
c.Add(new JMethod(11327,"forge/item/PaperCardPredicates","lambda$isObtainableNotRestricted$9","(Ljava/util/Set;Lforge/item/PaperCard;)Z",4106,2,3,new JHandler[]{},M11327));
c.Add(new JMethod(11328,"forge/item/PaperCardPredicates","lambda$isObtainableNotRestricted$8","(Ljava/util/Set;Lforge/item/PaperCard;Ljava/lang/String;)Z",4106,3,2,new JHandler[]{},M11328));
c.Add(new JMethod(11329,"forge/item/PaperCardPredicates","lambda$isObtainableAnyEdition$7","(Lforge/item/PaperCard;)Z",4106,1,2,new JHandler[]{},M11329));
c.Add(new JMethod(11330,"forge/item/PaperCardPredicates","lambda$isObtainableAnyEdition$6","(Lforge/item/PaperCard;Ljava/lang/String;)Z",4106,2,2,new JHandler[]{},M11330));
c.Add(new JMethod(11331,"forge/item/PaperCardPredicates","lambda$onlyPrintedInEditions$5","(Ljava/util/Set;Lforge/item/PaperCard;)Z",4106,2,3,new JHandler[]{},M11331));
c.Add(new JMethod(11332,"forge/item/PaperCardPredicates","lambda$onlyPrintedInEditions$4","(Ljava/util/Set;Lforge/item/PaperCard;Ljava/lang/String;)Z",4106,3,2,new JHandler[]{},M11332));
c.Add(new JMethod(11333,"forge/item/PaperCardPredicates","lambda$printedInAnyEditions$3","(Ljava/util/Set;Lforge/item/PaperCard;)Z",4106,2,3,new JHandler[]{},M11333));
c.Add(new JMethod(11334,"forge/item/PaperCardPredicates","lambda$printedInAnyEditions$2","(Ljava/util/Set;Lforge/item/PaperCard;Ljava/lang/String;)Z",4106,3,2,new JHandler[]{},M11334));
c.Add(new JMethod(11335,"forge/item/PaperCardPredicates","lambda$printedInSet$1","(Lforge/item/PaperCard;)Z",4106,1,1,new JHandler[]{},M11335));
c.Add(new JMethod(11336,"forge/item/PaperCardPredicates","lambda$printedInSets$0","(Lforge/item/PaperCard;)Z",4106,1,1,new JHandler[]{},M11336));
c.Add(new JMethod(11337,"forge/item/PaperCardPredicates","<clinit>","()V",8,0,3,new JHandler[]{},M11337));
}

internal static JStep M11311(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11312(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",4);}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCardPredicates","printedInSets","(Ljava/util/List;Z)Ljava/util/function/Predicate;","invokestatic",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11313(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?19:13;continue;}
case 13:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11313:13:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",18);}
case 18:{return JStep.Return(f.Pop());}
case 19:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateSets"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateSets")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateSets","<init>","(Ljava/util/List;Z)V","invokespecial",28);}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11314(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int==0?13:7;continue;}
case 7:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11314:7:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",12);}
case 12:{return JStep.Return(f.Pop());}
case 13:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateSets"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateSets")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=25;continue;}
case 25:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",28);}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateSets","<init>","(Ljava/util/List;Z)V","invokespecial",32);}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11315(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicatePrintedWithRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicatePrintedWithRarity")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicatePrintedWithRarity","<init>","(Lforge/card/CardRarity;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11316(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateSearchableName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateSearchableName")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateSearchableName","<init>","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)V","invokespecial",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11317(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateName"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateName")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateName","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11318(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateNames"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateNames")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateNames","<init>","(Ljava/util/List;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11319(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateFoil"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateFoil")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateFoil","<init>","(Z)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11320(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",8);}
case 8:{return rt.Call(f,"java/util/HashSet","<init>","(Ljava/util/Collection;)V","invokespecial",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11320:13:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Set;)Ljava/util/function/Predicate;",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11321(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",8);}
case 8:{return rt.Call(f,"java/util/HashSet","<init>","(Ljava/util/Collection;)V","invokespecial",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11321:13:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Set;)Ljava/util/function/Predicate;",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11322(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11322:0:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11323(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",8);}
case 8:{return rt.Call(f,"java/util/HashSet","<init>","(Ljava/util/Collection;)V","invokespecial",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11323:13:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Set;)Ljava/util/function/Predicate;",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11324(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11324:1:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11325(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardRules","getColor","()Lforge/card/ColorSet;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11326(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11327(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Lforge/item/PaperCard;)Ljava/util/List;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",15);}
case 15:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11327:15:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",20);}
case 20:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11327:27:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Set;Lforge/item/PaperCard;)Ljava/util/function/Predicate;",32);}
case 32:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",37);}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11328(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",7);}
case 7:{f.Pc=f.Pop().Int!=0?31:10;continue;}
case 10:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",13);}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/card/CardEdition","isCardObtainable","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?31:27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{f.Pc=32;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11329(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Lforge/item/PaperCard;)Ljava/util/List;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",15);}
case 15:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11329:15:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",20);}
case 20:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11329:26:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/item/PaperCard;)Ljava/util/function/Predicate;",31);}
case 31:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",36);}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11330(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/card/CardEdition","isCardObtainable","(Ljava/lang/String;)Z","invokevirtual",14);}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11331(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Lforge/item/PaperCard;)Ljava/util/List;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",15);}
case 15:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11331:15:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",20);}
case 20:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11331:27:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Set;Lforge/item/PaperCard;)Ljava/util/function/Predicate;",32);}
case 32:{return rt.Call(f,"java/util/stream/Stream","allMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",37);}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11332(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",7);}
case 7:{f.Pc=f.Pop().Int==0?31:10;continue;}
case 10:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",13);}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/card/CardEdition","isCardObtainable","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?31:27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{f.Pc=32;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11333(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Lforge/item/PaperCard;)Ljava/util/List;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",15);}
case 15:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11333:15:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",20);}
case 20:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11333:27:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Set;Lforge/item/PaperCard;)Ljava/util/function/Predicate;",32);}
case 32:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",37);}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11334(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",7);}
case 7:{f.Pc=f.Pop().Int==0?31:10;continue;}
case 10:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",13);}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/card/CardEdition","isCardObtainable","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?31:27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{f.Pc=32;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11335(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11336(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11337(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateRarity")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/CardRarity","Common","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Common","Lforge/card/CardRarity;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateRarity","<init>","(Lforge/card/CardRarity;)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_COMMON","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_COMMON","Ljava/util/function/Predicate;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateRarity")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/card/CardRarity","Uncommon","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Uncommon","Lforge/card/CardRarity;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateRarity","<init>","(Lforge/card/CardRarity;)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_UNCOMMON","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_UNCOMMON","Ljava/util/function/Predicate;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateRarity")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/card/CardRarity","Rare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Rare","Lforge/card/CardRarity;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateRarity","<init>","(Lforge/card/CardRarity;)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_RARE","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_RARE","Ljava/util/function/Predicate;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateRarity")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","MythicRare","Lforge/card/CardRarity;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateRarity","<init>","(Lforge/card/CardRarity;)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_MYTHIC_RARE","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_MYTHIC_RARE","Ljava/util/function/Predicate;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_RARE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_RARE","Ljava/util/function/Predicate;"));f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_MYTHIC_RARE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_MYTHIC_RARE","Ljava/util/function/Predicate;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",63);}
case 63:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_RARE_OR_MYTHIC","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_RARE_OR_MYTHIC","Ljava/util/function/Predicate;",f.Pop());f.Pc=66;continue;}
case 66:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateRarity")));f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateRarity","<init>","(Lforge/card/CardRarity;)V","invokespecial",76);}
case 76:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_SPECIAL","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_SPECIAL","Ljava/util/function/Predicate;",f.Pop());f.Pc=79;continue;}
case 79:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateRarity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateRarity")));f.Pc=82;continue;}
case 82:{f.StackOp("dup");f.Pc=83;continue;}
case 83:{if(!rt.StaticReady(f,"forge/card/CardRarity","BasicLand","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","BasicLand","Lforge/card/CardRarity;"));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateRarity","<init>","(Lforge/card/CardRarity;)V","invokespecial",89);}
case 89:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_BASIC_LAND_RARITY","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_BASIC_LAND_RARITY","Ljava/util/function/Predicate;",f.Pop());f.Pc=92;continue;}
case 92:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateColor")));f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLACK","Lforge/card/MagicColor$Color;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateColor","<init>","(Lforge/card/MagicColor$Color;)V","invokespecial",102);}
case 102:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_BLACK","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_BLACK","Ljava/util/function/Predicate;",f.Pop());f.Pc=105;continue;}
case 105:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateColor")));f.Pc=108;continue;}
case 108:{f.StackOp("dup");f.Pc=109;continue;}
case 109:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","BLUE","Lforge/card/MagicColor$Color;"));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateColor","<init>","(Lforge/card/MagicColor$Color;)V","invokespecial",115);}
case 115:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_BLUE","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_BLUE","Ljava/util/function/Predicate;",f.Pop());f.Pc=118;continue;}
case 118:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateColor")));f.Pc=121;continue;}
case 121:{f.StackOp("dup");f.Pc=122;continue;}
case 122:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","GREEN","Lforge/card/MagicColor$Color;"));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateColor","<init>","(Lforge/card/MagicColor$Color;)V","invokespecial",128);}
case 128:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_GREEN","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_GREEN","Ljava/util/function/Predicate;",f.Pop());f.Pc=131;continue;}
case 131:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateColor")));f.Pc=134;continue;}
case 134:{f.StackOp("dup");f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","RED","Lforge/card/MagicColor$Color;"));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateColor","<init>","(Lforge/card/MagicColor$Color;)V","invokespecial",141);}
case 141:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_RED","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_RED","Ljava/util/function/Predicate;",f.Pop());f.Pc=144;continue;}
case 144:{if(!rt.EnsureInitialized(f,"forge/item/PaperCardPredicates$PredicateColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperCardPredicates$PredicateColor")));f.Pc=147;continue;}
case 147:{f.StackOp("dup");f.Pc=148;continue;}
case 148:{if(!rt.StaticReady(f,"forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Color","WHITE","Lforge/card/MagicColor$Color;"));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/item/PaperCardPredicates$PredicateColor","<init>","(Lforge/card/MagicColor$Color;)V","invokespecial",154);}
case 154:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_WHITE","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_WHITE","Ljava/util/function/Predicate;",f.Pop());f.Pc=157;continue;}
case 157:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11337:157:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",162);}
case 162:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_COLORLESS","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_COLORLESS","Ljava/util/function/Predicate;",f.Pop());f.Pc=165;continue;}
case 165:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11337:165:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",170);}
case 170:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_UNREBALANCED","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_UNREBALANCED","Ljava/util/function/Predicate;",f.Pop());f.Pc=173;continue;}
case 173:{return rt.DynamicCall(f,"forge/item/PaperCardPredicates:11337:173:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",178);}
case 178:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_REBALANCED","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_REBALANCED","Ljava/util/function/Predicate;",f.Pop());f.Pc=181;continue;}
case 181:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_LAND","Ljava/util/function/Predicate;"));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",187);}
case 187:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=190;continue;}
case 190:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_NON_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_NON_LAND","Ljava/util/function/Predicate;"));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",196);}
case 196:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_NON_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_NON_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=199;continue;}
case 199:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;"));f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",205);}
case 205:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=208;continue;}
case 208:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","NOT_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","NOT_BASIC_LAND","Ljava/util/function/Predicate;"));f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",214);}
case 214:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","NOT_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","NOT_BASIC_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=217;continue;}
case 217:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_TRUE_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_TRUE_BASIC_LAND","Ljava/util/function/Predicate;"));f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/util/function/Predicate","not","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",223);}
case 223:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",226);}
case 226:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","NOT_TRUE_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","NOT_TRUE_BASIC_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=229;continue;}
case 229:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_NONBASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_NONBASIC_LAND","Ljava/util/function/Predicate;"));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",235);}
case 235:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_NONBASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_NONBASIC_LAND","Ljava/util/function/Predicate;",f.Pop());f.Pc=238;continue;}
case 238:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_CREATURE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_CREATURE","Ljava/util/function/Predicate;"));f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",244);}
case 244:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_CREATURE","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","IS_CREATURE","Ljava/util/function/Predicate;",f.Pop());f.Pc=247;continue;}
case 247:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","CAN_BE_COMMANDER","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","CAN_BE_COMMANDER","Ljava/util/function/Predicate;"));f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",253);}
case 253:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","CAN_BE_COMMANDER","Ljava/util/function/Predicate;"))return JStep.Continue;rt.PutStatic("forge/item/PaperCardPredicates","CAN_BE_COMMANDER","Ljava/util/function/Predicate;",f.Pop());f.Pc=256;continue;}
case 256:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
